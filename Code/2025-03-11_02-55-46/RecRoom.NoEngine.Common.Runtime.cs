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
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x76FF6F0", Offset = "0x76FEAF0", VA = "0x1876FF6F0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
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
		[Cpp2IlInjected.Address(RVA = "0x9905D0", Offset = "0x98F9D0", VA = "0x1809905D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JHGFIENLBKE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76FACC0", Offset = "0x76FA0C0", VA = "0x1876FACC0")]
	public static string KDKFLOPCACE(this Encoding DGBGKDBCDII, [In] ReadOnlySequence<byte> KPLABGDDBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x351C260", Offset = "0x351B660", VA = "0x18351C260")]
	private static void LFKNPFADCPF<T>(this ReadOnlySequence<T> KDODPLEFNAL, [Out] ReadOnlySpan<T> NMICEOKCIHK, [Out] SequencePosition NNDPIGFFLGM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class HPPCADPKKJF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x76F7C20", Offset = "0x76F7020", VA = "0x1876F7C20")]
	public HPPCADPKKJF(bool MDLMAPPFDFL, string JODDMIMJDPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x17D3B60", Offset = "0x17D2F60", VA = "0x1817D3B60")]
	public HPPCADPKKJF(bool MDLMAPPFDFL, params string[] LBKNHEKJPBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EMAEDELMBAI
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CPDMDFCIFDM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NNLMJDPIFEC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFGJAKLBKEG(string MCNLCGLNHHO, double PEBNJNGMMHE, [Optional] string? OIPIOAFPPNC);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class MGJPIIMMKAP : MDPECAEJBND, CMHKGLEPGLE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int BNEHNKNPPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> JPLOCOFEOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double IKENCPHIKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double MNJHKANCBHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double JKHEMBJFEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int DLINCIKKBKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double LKNBEKJMKEI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HIPPHGNNAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x983DD0", Offset = "0x9831D0", VA = "0x180983DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double LNCGOPLADLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x76FEDC0", Offset = "0x76FE1C0", VA = "0x1876FEDC0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double JIHFPGCIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x49F8D00", Offset = "0x49F8100", VA = "0x1849F8D00", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double HMHIGNENCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2559850", Offset = "0x2558C50", VA = "0x182559850", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x76FEE20", Offset = "0x76FE220", VA = "0x1876FEE20")]
	public MGJPIIMMKAP(int IBPGJBEANPO, double LKNBEKJMKEI = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x76FEC90", Offset = "0x76FE090", VA = "0x1876FEC90", Slot = "7")]
	public void MLEDJNKDOLN(double GHFLHNCPIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x76FEC20", Offset = "0x76FE020", VA = "0x1876FEC20", Slot = "8")]
	public void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x76FEB20", Offset = "0x76FDF20", VA = "0x1876FEB20", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HGEJMLCILDE : MDPECAEJBND, CMHKGLEPGLE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long LOHPPDCIAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double LNNFMCBAJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double AOJFKPKHEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double HKAOBGKBJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double FCIGACBFGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double IKENCPHIKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double MNJHKANCBHC;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long ECPNGLCMABA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JIHFPGCIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A60780", Offset = "0x6A5FB80", VA = "0x186A60780", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double HMHIGNENCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A60770", Offset = "0x6A5FB70", VA = "0x186A60770", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double HKANIMBPMLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A60760", Offset = "0x6A5FB60", VA = "0x186A60760")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double LNCGOPLADLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BDCAC0", Offset = "0x2BDBEC0", VA = "0x182BDCAC0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x76F6FC0", Offset = "0x76F63C0", VA = "0x1876F6FC0", Slot = "10")]
	public virtual void MLEDJNKDOLN(double GHFLHNCPIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x76F6F80", Offset = "0x76F6380", VA = "0x1876F6F80", Slot = "11")]
	public virtual void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x76F6F10", Offset = "0x76F6310", VA = "0x1876F6F10", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x76F70E0", Offset = "0x76F64E0", VA = "0x1876F70E0")]
	public HGEJMLCILDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class IHGOPPMANFE : HGEJMLCILDE
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double LEDLODCKDKC
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A60730", Offset = "0x6A5FB30", VA = "0x186A60730")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A602A0", Offset = "0x6A5F6A0", VA = "0x186A602A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x76F9F90", Offset = "0x76F9390", VA = "0x1876F9F90", Slot = "10")]
	public override void MLEDJNKDOLN(double GHFLHNCPIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x76F9F50", Offset = "0x76F9350", VA = "0x1876F9F50", Slot = "11")]
	public override void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x76F70E0", Offset = "0x76F64E0", VA = "0x1876F70E0")]
	public IHGOPPMANFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface MDPECAEJBND : CMHKGLEPGLE, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double LNCGOPLADLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double JIHFPGCIHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double HMHIGNENCNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class KBECAIONDME : CMHKGLEPGLE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double GKNLGJPDFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double OFEHGACCGHA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x76FB8F0", Offset = "0x76FACF0", VA = "0x1876FB8F0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x765B8E0", Offset = "0x765ACE0", VA = "0x18765B8E0", Slot = "4")]
	public void MLEDJNKDOLN(double GHFLHNCPIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x76FB950", Offset = "0x76FAD50", VA = "0x1876FB950", Slot = "5")]
	public void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x76FB900", Offset = "0x76FAD00", VA = "0x1876FB900", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public KBECAIONDME()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CMHKGLEPGLE : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MLEDJNKDOLN(double GHFLHNCPIIL);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKGADJFONBN();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PPBIHFNHENK : CMHKGLEPGLE, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double PEBNJNGMMHE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double KAMPPLLIEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x41B45A0", Offset = "0x41B39A0", VA = "0x1841B45A0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4E60A00", Offset = "0x4E5FE00", VA = "0x184E60A00", Slot = "4")]
	public void MLEDJNKDOLN(double GHFLHNCPIIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x76FF950", Offset = "0x76FED50", VA = "0x1876FF950", Slot = "5")]
	public void HKGADJFONBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x76FF900", Offset = "0x76FED00", VA = "0x1876FF900", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public PPBIHFNHENK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DPDBBJJNIPP<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> OKEBMBKIOPH(CancellationToken MLAPMBKLAOF);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct OBNIAJMCDLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DPDBBJJNIPP<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public OKEBMBKIOPH taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4F97F50", Offset = "0x4F97350", VA = "0x184F97F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4F99010", Offset = "0x4F98410", VA = "0x184F99010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource GBICCIOOCED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? KNOHOMGANOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? HHAPPALDEHK;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6411640", Offset = "0x6410A40", VA = "0x186411640")]
	[AsyncStateMachine(typeof(DPDBBJJNIPP<>.OBNIAJMCDLL))]
	public Task<TResult> HDLCINHMJAD(OKEBMBKIOPH HJGNOPHCKDF, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x64115D0", Offset = "0x64109D0", VA = "0x1864115D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6411780", Offset = "0x6410B80", VA = "0x186411780")]
	public DPDBBJJNIPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class JOMNHOHCGJK<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> EDFIIKANHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T KAMPPLLIEDO;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4817360", Offset = "0x4816760", VA = "0x184817360")]
	public JOMNHOHCGJK([In] T PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A3E0C0", Offset = "0x4A3D4C0", VA = "0x184A3E0C0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A3E560", Offset = "0x4A3D960", VA = "0x184A3E560", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A3E9E0", Offset = "0x4A3DDE0", VA = "0x184A3E9E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class LNMFJAADOHL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x34828A0", Offset = "0x3481CA0", VA = "0x1834828A0")]
	public static JOMNHOHCGJK<T> KMDIICJFNJF<T>([In] T PEBNJNGMMHE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class IGDCIJKFDLL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x76F9F20", Offset = "0x76F9320", VA = "0x1876F9F20")]
	public static void MCKHHANMKAO(this CancellationTokenSource GBICCIOOCED, bool FALDDAMAGIN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class ICLKNMOKHNO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
	public ICLKNMOKHNO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class IEAAMAIOELF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
	public IEAAMAIOELF(string PEADNDNHNGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class PIBGNCMJLNG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x366FF00", Offset = "0x366F300", VA = "0x18366FF00")]
	public static DFPMOGGIPEH GFBEFFJCMHB<T>()
	{
		return default(DFPMOGGIPEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3670200", Offset = "0x366F600", VA = "0x183670200")]
	public static DFPMOGGIPEH IPGAEBNCOCA<T>([CallerMemberName] string OGOCCCFKJPG = "") where T : notnull
	{
		return default(DFPMOGGIPEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x366FF80", Offset = "0x366F380", VA = "0x18366FF80")]
	public static DFPMOGGIPEH GFBEFFJCMHB<T>(this T NCCMNNBGHEA) where T : notnull
	{
		return default(DFPMOGGIPEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x366FDB0", Offset = "0x366F1B0", VA = "0x18366FDB0")]
	public static DFPMOGGIPEH CIJBELANAFJ<T>(this T NCCMNNBGHEA, [CallerMemberName] string OGOCCCFKJPG = "") where T : notnull
	{
		return default(DFPMOGGIPEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3670150", Offset = "0x366F550", VA = "0x183670150")]
	public static DFPMOGGIPEH IPGAEBNCOCA<T>(this T IIICNLIAPBJ, [CallerMemberName] string OGOCCCFKJPG = "") where T : notnull
	{
		return default(DFPMOGGIPEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x76FF7E0", Offset = "0x76FEBE0", VA = "0x1876FF7E0")]
	public static DFPMOGGIPEH IPGAEBNCOCA(string DBLKAIMEHPK, [CallerMemberName] string OGOCCCFKJPG = "")
	{
		return default(DFPMOGGIPEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x76FF860", Offset = "0x76FEC60", VA = "0x1876FF860")]
	public static string LNFNPNNCMAC(this object IIICNLIAPBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool EJAEGJHFPJI();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ICLKNMOKHNO]
public delegate long ENLBINBOBBB();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class IOBFJKAFPFA
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private static KFBODOEEBOH IHFBEBJBFFE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static KFBODOEEBOH ACPPKEKJHKP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x76FA400", Offset = "0x76F9800", VA = "0x1876FA400")]
		get
		{
			return default(KFBODOEEBOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static ABLGJAKKLME IDOPFLFFIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x76FA0C0", Offset = "0x76F94C0", VA = "0x1876FA0C0")]
		get
		{
			return default(ABLGJAKKLME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static HKDKFMNFEGF DMBNECEBHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x76FA630", Offset = "0x76F9A30", VA = "0x1876FA630")]
		get
		{
			return default(HKDKFMNFEGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool IJEMGKCKNMK
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x76FA860", Offset = "0x76F9C60", VA = "0x1876FA860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x76FA260", Offset = "0x76F9660", VA = "0x1876FA260")]
	public static void EKFHKKBBGBJ([In] KFBODOEEBOH AFIGHJPFDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x76FA110", Offset = "0x76F9510", VA = "0x1876FA110")]
	public static void COHAOGFFGHO(string LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x76FA4C0", Offset = "0x76F98C0", VA = "0x1876FA4C0")]
	public static void IBIHEEBAPEC(string LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3509CC0", Offset = "0x35090C0", VA = "0x183509CC0")]
	public static void IBIHEEBAPEC<T>(T EEHMKJMNANF, FGABCFFNONJ<T> LPIFIOEEOGF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x76FA7C0", Offset = "0x76F9BC0", VA = "0x1876FA7C0")]
	public static void NFOCDBBOCMK(Exception BOKONMFPKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x76FA1E0", Offset = "0x76F95E0", VA = "0x1876FA1E0")]
	public static void DHANEFCKPEP(string OGOCCCFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x76FA450", Offset = "0x76F9850", VA = "0x1876FA450")]
	public static void FOMJAGKMMEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x76FA680", Offset = "0x76F9A80", VA = "0x1876FA680")]
	public static string LNFNPNNCMAC(object NBAMGPFDMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x76FA8D0", Offset = "0x76F9CD0", VA = "0x1876FA8D0")]
	public static long OGMPAIPHFHG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x76FA590", Offset = "0x76F9990", VA = "0x1876FA590")]
	public static bool JCPLINIPPFD(bool FMLBJPAMJAA, string LPIFIOEEOGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x76FA6F0", Offset = "0x76F9AF0", VA = "0x1876FA6F0")]
	public static double LPKNMGCAGNN()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct KFBODOEEBOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly ABLGJAKKLME IDOPFLFFIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly HKDKFMNFEGF DMBNECEBHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly JPHHFLDGFLK PIBDDNMPIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly ENLBINBOBBB MHENLACHIGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly LHFOHFLJLIK AKLKAEIIBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly EJAEGJHFPJI EAHGENOJPHB;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly JPHHFLDGFLK PELFPDOOPCO;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly ENLBINBOBBB OCIAOBCDHDI;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly LHFOHFLJLIK MLCBGPAJBME;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly EJAEGJHFPJI KOEDOHBDGCD;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly KFBODOEEBOH MAEOIBKNBOE;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool EAANCJCJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x76FBCE0", Offset = "0x76FB0E0", VA = "0x1876FBCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76FC530", Offset = "0x76FB930", VA = "0x1876FC530")]
	public KFBODOEEBOH([In] ABLGJAKKLME AFGAGDGMCDC, [In] HKDKFMNFEGF DFMLJEJCINP, JPHHFLDGFLK FNNFAIEKPMP, ENLBINBOBBB CACOJJAJKHP, LHFOHFLJLIK GEIHLCPHDCE, EJAEGJHFPJI CMBDLBNGOAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x76FBCA0", Offset = "0x76FB0A0", VA = "0x1876FBCA0")]
	private static string HLDJPKFNCBO(object NBAMGPFDMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x966910", Offset = "0x965D10", VA = "0x180966910")]
	private static long OBCEMHHBAPM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	private static string GCHMJIPAKLH(string KDFEGOCHHNF, string? MLLBPGGFLHM, bool NKGKEFIFEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
	private static bool HELOMLGICGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x76FBBA0", Offset = "0x76FAFA0", VA = "0x1876FBBA0")]
	private static KFBODOEEBOH AGDMFDAJBNG()
	{
		return default(KFBODOEEBOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface MICOHECFBLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OKLLPPJAAFE ADJMMNLCDBA();
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OKLLPPJAAFE : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool JJCLLNLCAMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PEJAMAAHHOL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NMNCOFBKMHI<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDKCOPFPMJO([In] T MNALNBMKJLK);
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public delegate void IBMKEKOHLID<T>([In] T EEHMKJMNANF);
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct LKOJHCKIDHK<T> : IEquatable<LKOJHCKIDHK<T>>, NMNCOFBKMHI<LKOJHCKIDHK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public readonly T KAMPPLLIEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly int NGGCGOFGPAK;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4C0FA00", Offset = "0x4C0EE00", VA = "0x184C0FA00")]
	public LKOJHCKIDHK([In] T PEBNJNGMMHE, int FFCBHHABFJN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4C0EC60", Offset = "0x4C0E060", VA = "0x184C0EC60")]
	public static bool JECEAGOPPKI([In] LKOJHCKIDHK<T> BBGKOKBOEGA, [In] LKOJHCKIDHK<T> NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x48133C0", Offset = "0x48127C0", VA = "0x1848133C0", Slot = "4")]
	public bool Equals(LKOJHCKIDHK<T> MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D090", Offset = "0x4C0C490", VA = "0x184C0D090", Slot = "0")]
	public override bool Equals(object MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4C0EAF0", Offset = "0x4C0DEF0", VA = "0x184C0EAF0")]
	public bool HDKCOPFPMJO([In] LKOJHCKIDHK<T> MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E8D0", Offset = "0x4C0DCD0", VA = "0x184C0E8D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4C0F360", Offset = "0x4C0E760", VA = "0x184C0F360", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E0A0", Offset = "0x4C0D4A0", VA = "0x184C0E0A0")]
	public void COICBMCKFLC([Out] T PEBNJNGMMHE, [Out] int FFCBHHABFJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E2D0", Offset = "0x4C0D6D0", VA = "0x184C0E2D0")]
	public (T, int) GBGEMJEDGME()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4C0D8F0", Offset = "0x4C0CCF0", VA = "0x184C0D8F0", Slot = "5")]
	private bool ADPGLNAHCHF([In] LKOJHCKIDHK<T> MNALNBMKJLK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class OBPLGBEIJNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x36519E0", Offset = "0x3650DE0", VA = "0x1836519E0")]
	public static LKOJHCKIDHK<T> KMDIICJFNJF<T>([In] T PEBNJNGMMHE, int FFCBHHABFJN) where T : notnull
	{
		return default(LKOJHCKIDHK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class EHOHEFCCFBJ
{
	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x3310950", Offset = "0x330FD50", VA = "0x183310950")]
	public static bool HDKCOPFPMJO<T, U>([In] T IIICNLIAPBJ, [In] U NBAMGPFDMIB) where T : notnull, NMNCOFBKMHI<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public delegate TResult OGMNLMLJFEL<T, out TResult>([In] T EEHMKJMNANF);
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface LFEJENGEAGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan GGHDECEONNG
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? NIHKNFNGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EDANEBCOOOB();

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LAPNCKBMFIP();

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OLLPJMBNIFG();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct ABLGJAKKLME
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly IPECHCCOLFD LMMDOFBNLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly BEEGMBDMOME CEIJMPEHNJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IPECHCCOLFD JGACBFJNHPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly BEEGMBDMOME CBCPDLELFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly IPECHCCOLFD IIFILDMDEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly BEEGMBDMOME PIPMABIDPPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly IMDGDEPPECK PIADKEHBFKN;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public static readonly IPECHCCOLFD KKDMIMIAFFO;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly BEEGMBDMOME MOLBFELCAOO;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly IPECHCCOLFD DOAMHODJLCP;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly BEEGMBDMOME LKKPCBNLNEA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly IPECHCCOLFD PEOHCDDBFKI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly BEEGMBDMOME KDDHPJFJNOL;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly IMDGDEPPECK AJANPACLMKG;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly ABLGJAKKLME MAEOIBKNBOE;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly IPECHCCOLFD KIBHGOIFHHJ;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EAANCJCJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x76F3D50", Offset = "0x76F3150", VA = "0x1876F3D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0xC532C0", Offset = "0xC526C0", VA = "0x180C532C0")]
	public ABLGJAKKLME(IPECHCCOLFD ELAAIHAKPMA, BEEGMBDMOME OGGCBCAKHIJ, IPECHCCOLFD MHFGOGIOFEM, BEEGMBDMOME IPAHOEOCFLC, IPECHCCOLFD OKOKBNPMLFB, BEEGMBDMOME KNDGDIMCJNN, IMDGDEPPECK EGEBPGODJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
	private static bool FAPFFFOLNEO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private static void HPDMDJEDKFA(string LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
	private static bool DAJHGGDBLIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private static void OKBCOMFPEAK(string LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9AFB60", Offset = "0x9AEF60", VA = "0x1809AFB60")]
	private static bool LPKJCJFNCAE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private static void DNCBOJNHLBJ(string LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private static void POCLNIKFHNI(Exception BOKONMFPKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x76F3980", Offset = "0x76F2D80", VA = "0x1876F3980")]
	private static ABLGJAKKLME AGDMFDAJBNG()
	{
		return default(ABLGJAKKLME);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0")]
	private static bool BNGFBCALCGF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x76F3AC0", Offset = "0x76F2EC0", VA = "0x1876F3AC0")]
	public void COHAOGFFGHO(object LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x76F3F30", Offset = "0x76F3330", VA = "0x1876F3F30")]
	public void NMFLJOGGMAF(object LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x76F3C10", Offset = "0x76F3010", VA = "0x1876F3C10")]
	public void IBIHEEBAPEC(object LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xC5CC30", Offset = "0xC5C030", VA = "0x180C5CC30")]
	public void NFOCDBBOCMK(Exception BOKONMFPKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x76F3B30", Offset = "0x76F2F30", VA = "0x1876F3B30")]
	public void IBIHEEBAPEC(BJJDLKAELBO LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6560", Offset = "0x3BB5960", VA = "0x183BB6560")]
	public void IBIHEEBAPEC<T>(T EEHMKJMNANF, FGABCFFNONJ<T> LPIFIOEEOGF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6220", Offset = "0x3BB5620", VA = "0x183BB6220")]
	public void COHAOGFFGHO<T>([In] T EEHMKJMNANF, GPLAPEEBCFB<T> LPIFIOEEOGF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3BB63C0", Offset = "0x3BB57C0", VA = "0x183BB63C0")]
	public void IBIHEEBAPEC<T>([In] T EEHMKJMNANF, GPLAPEEBCFB<T> LPIFIOEEOGF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x76F3C80", Offset = "0x76F3080", VA = "0x1876F3C80")]
	public bool JCPLINIPPFD(bool FMLBJPAMJAA, string LPIFIOEEOGF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DFPMOGGIPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly string KAMPPLLIEDO;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0xC1B040", Offset = "0xC1A440", VA = "0x180C1B040")]
	public DFPMOGGIPEH(string PEBNJNGMMHE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0")]
	public static string JKGHIELMIOO([In] DFPMOGGIPEH IIICNLIAPBJ)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x20A0F20", Offset = "0x20A0320", VA = "0x1820A0F20")]
	public static DFPMOGGIPEH JKGHIELMIOO(string MNALNBMKJLK)
	{
		return default(DFPMOGGIPEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x76F4AA0", Offset = "0x76F3EA0", VA = "0x1876F4AA0")]
	public string ABAAJJAGIFA(string HEFHCBPMGEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x76F4AF0", Offset = "0x76F3EF0", VA = "0x1876F4AF0")]
	public string NKDCMLNGFEH(object PHFFPFNJLED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xC1AFD0", Offset = "0xC1A3D0", VA = "0x180C1AFD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[AttributeUsage(AttributeTargets.Method)]
public class HGAKIEJIDNO : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
	public HGAKIEJIDNO()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct AOFFOIKPJDJ : IEquatable<AOFFOIKPJDJ>
{
	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x980BB0", Offset = "0x97FFB0", VA = "0x180980BB0", Slot = "4")]
	public bool Equals(AOFFOIKPJDJ MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x76F4550", Offset = "0x76F3950", VA = "0x1876F4550", Slot = "0")]
	public override bool Equals(object MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x76F45A0", Offset = "0x76F39A0", VA = "0x1876F45A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x76F45B0", Offset = "0x76F39B0", VA = "0x1876F45B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[FDIEMNELNCN("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct CCAOJCEHJPO<T> : IEquatable<CCAOJCEHJPO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T KAMPPLLIEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly bool LFMKEKDECIL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool FDBCJNPJBFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x606C6C0", Offset = "0x606BAC0", VA = "0x18606C6C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x606CFD0", Offset = "0x606C3D0", VA = "0x18606CFD0")]
	public CCAOJCEHJPO([In] T PEBNJNGMMHE, bool MIPCGELADED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x606BF60", Offset = "0x606B360", VA = "0x18606BF60")]
	public static bool JECEAGOPPKI([In] CCAOJCEHJPO<T> BBGKOKBOEGA, [In] CCAOJCEHJPO<T> NBNHMPFPBPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x606AC40", Offset = "0x606A040", VA = "0x18606AC40", Slot = "4")]
	public bool Equals(CCAOJCEHJPO<T> MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x606B0D0", Offset = "0x606A4D0", VA = "0x18606B0D0", Slot = "0")]
	public override bool Equals(object? MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x606BC50", Offset = "0x606B050", VA = "0x18606BC50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x606CE70", Offset = "0x606C270", VA = "0x18606CE70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class GLBJCGFMIOP
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x34BDD10", Offset = "0x34BD110", VA = "0x1834BDD10")]
	public static CCAOJCEHJPO<T> OFGDGMHJENO<T>([In] T PEBNJNGMMHE) where T : notnull
	{
		return default(CCAOJCEHJPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x34BDA00", Offset = "0x34BCE00", VA = "0x1834BDA00")]
	public static CCAOJCEHJPO<T?> JFKHKHILJFE<T>()
	{
		return default(CCAOJCEHJPO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x34BD8D0", Offset = "0x34BCCD0", VA = "0x1834BD8D0")]
	public static bool GIBKABPJKPP<T>([In] this CCAOJCEHJPO<T> GGAPFNFGNLN, [Out][NotNullWhen(true)] T PEBNJNGMMHE) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x34BD890", Offset = "0x34BCC90", VA = "0x1834BD890")]
	public static bool GIBKABPJKPP<T>([In] this CCAOJCEHJPO<T> GGAPFNFGNLN, [Out][NotNullWhen(true)] T PEBNJNGMMHE, [Out] CCAOJCEHJPO<T> BDJKLIBOHIO) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x34BD800", Offset = "0x34BCC00", VA = "0x1834BD800")]
	public static T? EBEALAKDGHM<T>([In] this CCAOJCEHJPO<T> GGAPFNFGNLN, T? CIKOELCEFFM)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x34BDB50", Offset = "0x34BCF50", VA = "0x1834BDB50")]
	public static bool JGMNBJHMNHM<T>([In] this CCAOJCEHJPO<T> GGAPFNFGNLN, T PEBNJNGMMHE) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ABGDCKODBGO
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3BB6210", Offset = "0x3BB5610", VA = "0x183BB6210")]
	public static T FPIMMMLBPPN<T>([In] this CCAOJCEHJPO<T> GGAPFNFGNLN) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct HKDKFMNFEGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly IntPtr DHANEFCKPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr FOMJAGKMMEN;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly IntPtr LOKNFHEBKIB;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr HBHDCDGKGAL;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly HKDKFMNFEGF MAEOIBKNBOE;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool EAANCJCJLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x76F7900", Offset = "0x76F6D00", VA = "0x1876F7900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x9CC970", Offset = "0x9CBD70", VA = "0x1809CC970")]
	public HKDKFMNFEGF(IntPtr LANPAJFHCNI, IntPtr GHNJHMIJAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private static void DBGEPEMEOAE(string OGOCCCFKJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900")]
	private static void BGBEFEALJKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x76F7870", Offset = "0x76F6C70", VA = "0x1876F7870")]
	private static HKDKFMNFEGF AGDMFDAJBNG()
	{
		return default(HKDKFMNFEGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly ref struct CMEEMPALHNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IntPtr MILHEENFJLL;

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x1501850", Offset = "0x1500C50", VA = "0x181501850")]
	private CMEEMPALHNB(IntPtr GHNJHMIJAKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x76F49A0", Offset = "0x76F3DA0", VA = "0x1876F49A0")]
	public void AICKIPOBPIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x76F49C0", Offset = "0x76F3DC0", VA = "0x1876F49C0")]
	public static CMEEMPALHNB KMDIICJFNJF(string OGOCCCFKJPG)
	{
		return default(CMEEMPALHNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x25BBED0", Offset = "0x25BB2D0", VA = "0x1825BBED0")]
	public static CMEEMPALHNB KMDIICJFNJF([In] HKDKFMNFEGF DFMLJEJCINP, string OGOCCCFKJPG)
	{
		return default(CMEEMPALHNB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x25BBFA0", Offset = "0x25BB3A0", VA = "0x1825BBFA0")]
	public static CMEEMPALHNB KMDIICJFNJF([In] HKDKFMNFEGF DFMLJEJCINP, Func<string> OGOCCCFKJPG)
	{
		return default(CMEEMPALHNB);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class ICFHPBIFHLC
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public delegate bool EIAMABOJFGF<in TInput, TResult>(TInput NIPDIMDKGGA, [Out] TResult HOCIBOCHCFJ);

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	private sealed class JNKKADLJIPF : MICOHECFBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		private sealed class KMLEMABJPIA : OKLLPPJAAFE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly KMLEMABJPIA AJPLFLPAHGP;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			public bool JJCLLNLCAMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E8")]
				[Cpp2IlInjected.Address(RVA = "0x76FCA50", Offset = "0x76FBE50", VA = "0x1876FCA50", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x76FCAB0", Offset = "0x76FBEB0", VA = "0x1876FCAB0", Slot = "6")]
			public void OnCompleted(Action BOAELGLJEHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			public void PEJAMAAHHOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public KMLEMABJPIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public static readonly JNKKADLJIPF AJPLFLPAHGP;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		private JNKKADLJIPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x76FB280", Offset = "0x76FA680", VA = "0x1876FB280", Slot = "4")]
		public OKLLPPJAAFE ADJMMNLCDBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	private sealed class MAGBCDNHLDC : MICOHECFBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		private sealed class LAPAFOEBLOK : OKLLPPJAAFE, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly LAPAFOEBLOK AJPLFLPAHGP;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool JJCLLNLCAMJ
			{
				[Cpp2IlInjected.Token(Token = "0x60000F3")]
				[Cpp2IlInjected.Address(RVA = "0x76FCC70", Offset = "0x76FC070", VA = "0x1876FCC70", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x76FCC90", Offset = "0x76FC090", VA = "0x1876FCC90", Slot = "6")]
			public void OnCompleted(Action BOAELGLJEHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x966900", Offset = "0x965D00", VA = "0x180966900", Slot = "5")]
			public void PEJAMAAHHOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
			public LAPAFOEBLOK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public static readonly MAGBCDNHLDC AJPLFLPAHGP;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		private MAGBCDNHLDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x76FE6A0", Offset = "0x76FDAA0", VA = "0x1876FE6A0", Slot = "4")]
		public OKLLPPJAAFE ADJMMNLCDBA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GNGBDNIEILE<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public GNGBDNIEILE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4128370", Offset = "0x4127770", VA = "0x184128370")]
		internal void JOKGLFIDGPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class AKNCPOMBAGF<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public AKNCPOMBAGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4736850", Offset = "0x4735C50", VA = "0x184736850")]
		internal void DCOBMJKAMOJ(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct KHKOBDKCCBA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76FC8F0", Offset = "0x76FBCF0", VA = "0x1876FC8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private struct PPGMJDLOFIP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76FF960", Offset = "0x76FED60", VA = "0x1876FF960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9B1C90", Offset = "0x9B1090", VA = "0x1809B1C90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct CNMGLAHFGBH<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x61FFC90", Offset = "0x61FF090", VA = "0x1861FFC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x61FFE00", Offset = "0x61FF200", VA = "0x1861FFE00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct EKJNMGOKDJF<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4127A90", Offset = "0x4126E90", VA = "0x184127A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x41282E0", Offset = "0x41276E0", VA = "0x1841282E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct DMKGNABENDO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76F4BD0", Offset = "0x76F3FD0", VA = "0x1876F4BD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x76F4DE0", Offset = "0x76F41E0", VA = "0x1876F4DE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private sealed class EKOKDCBOLHD<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public EKOKDCBOLHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4128370", Offset = "0x4127770", VA = "0x184128370")]
		internal void AKAGEFPHDFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x41283D0", Offset = "0x41277D0", VA = "0x1841283D0")]
		internal void KJCBIPEDMMH(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JFMGJLONBAA<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public EIAMABOJFGF<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4A0FA70", Offset = "0x4A0EE70", VA = "0x184A0FA70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4A10180", Offset = "0x4A0F580", VA = "0x184A10180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct GBJFGLFKIJG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76F5EC0", Offset = "0x76F52C0", VA = "0x1876F5EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x76F66C0", Offset = "0x76F5AC0", VA = "0x1876F66C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct KAFLEBOOOHL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76FB340", Offset = "0x76FA740", VA = "0x1876FB340", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x76FB890", Offset = "0x76FAC90", VA = "0x1876FB890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct MGHLKBMLFGE<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4DFEFF0", Offset = "0x4DFE3F0", VA = "0x184DFEFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4A43830", Offset = "0x4A42C30", VA = "0x184A43830", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class HPGLEFLPIHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public TaskCompletionSource<AOFFOIKPJDJ> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public HPGLEFLPIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x76F7B10", Offset = "0x76F6F10", VA = "0x1876F7B10")]
		internal void OAGBDBPPFLF(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct FFGCOFEAIAA<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x44F8120", Offset = "0x44F7520", VA = "0x1844F8120", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x3D60950", Offset = "0x3D5FD50", VA = "0x183D60950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct DMPBJLNODEE<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x640D7B0", Offset = "0x640CBB0", VA = "0x18640D7B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x640DFE0", Offset = "0x640D3E0", VA = "0x18640DFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct KBFKPJHJEEP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76FB960", Offset = "0x76FAD60", VA = "0x1876FB960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x76FBB40", Offset = "0x76FAF40", VA = "0x1876FBB40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct FGJBEPPPKJC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76F5090", Offset = "0x76F4490", VA = "0x1876F5090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x76F53F0", Offset = "0x76F47F0", VA = "0x1876F53F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct HFGBHNOMMAN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76F6BC0", Offset = "0x76F5FC0", VA = "0x1876F6BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x76F6EB0", Offset = "0x76F62B0", VA = "0x1876F6EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class OPOAPKNCPED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public OPOAPKNCPED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x76FF770", Offset = "0x76FEB70", VA = "0x1876FF770")]
		internal Task BPEDJPDMLCG(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct JGAHDMJLJIH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76FAA00", Offset = "0x76F9E00", VA = "0x1876FAA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x76FAC60", Offset = "0x76FA060", VA = "0x1876FAC60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct EDNHJBAJIJF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76F4E50", Offset = "0x76F4250", VA = "0x1876F4E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x76F5030", Offset = "0x76F4430", VA = "0x1876F5030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct MELEINGLANP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76FE760", Offset = "0x76FDB60", VA = "0x1876FE760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x76FEAC0", Offset = "0x76FDEC0", VA = "0x1876FEAC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct CKINMANIPJD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76F4650", Offset = "0x76F3A50", VA = "0x1876F4650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x76F4940", Offset = "0x76F3D40", VA = "0x1876F4940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class CIFCKIDOHIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
		public CIFCKIDOHIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x76F45E0", Offset = "0x76F39E0", VA = "0x1876F45E0")]
		internal Task FOKFKAMPGDC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct GCHLDBLNEEE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76F6720", Offset = "0x76F5B20", VA = "0x1876F6720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x76F6980", Offset = "0x76F5D80", VA = "0x1876F6980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct GGFCLBPFCGO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76F69E0", Offset = "0x76F5DE0", VA = "0x1876F69E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x76F6B60", Offset = "0x76F5F60", VA = "0x1876F6B60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct OLHDPICDNMA<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4FC3EE0", Offset = "0x4FC32E0", VA = "0x184FC3EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x4FC4140", Offset = "0x4FC3540", VA = "0x184FC4140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct FNOAAIILAMK : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76F5B30", Offset = "0x76F4F30", VA = "0x1876F5B30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x76F5E60", Offset = "0x76F5260", VA = "0x1876F5E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static SynchronizationContext? PEHAFPLGGJN;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly TaskCompletionSource<AOFFOIKPJDJ> FDMHDPPLPPN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static Task IAKEIEIIFGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x76F8180", Offset = "0x76F7580", VA = "0x1876F8180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x76F8EE0", Offset = "0x76F82E0", VA = "0x1876F8EE0")]
	public static bool KGBELKAAIAK(this Task GELALODAJCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x34FB8B0", Offset = "0x34FACB0", VA = "0x1834FB8B0")]
	public static Task<T> HNDLMBPPCEF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x76F89C0", Offset = "0x76F7DC0", VA = "0x1876F89C0")]
	public static Task HBCLGJGINNH(this Task GELALODAJCE, CancellationToken OCDOGNMJENC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x34F89A0", Offset = "0x34F7DA0", VA = "0x1834F89A0")]
	public static Task<TResult> HBCLGJGINNH<TResult>(this Task<TResult> GELALODAJCE, CancellationToken OCDOGNMJENC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x34F8FC0", Offset = "0x34F83C0", VA = "0x1834F8FC0")]
	public static TaskCompletionSource<TResult> HBCLGJGINNH<TResult>(this TaskCompletionSource<TResult> BIBGJEOCDEP, CancellationToken OCDOGNMJENC) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x76F82C0", Offset = "0x76F76C0", VA = "0x1876F82C0")]
	public static IDisposable? ELHDKHALAHG(CancellationToken MIPCOAKBCEC, CancellationToken KNAFENHBJMB, [Out] CancellationToken ICAJMIBAOEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x76F93A0", Offset = "0x76F87A0", VA = "0x1876F93A0")]
	[AsyncStateMachine(typeof(KHKOBDKCCBA))]
	public static void LGKNNGEECCH(this Task MPAMMAGABHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x76F9A50", Offset = "0x76F8E50", VA = "0x1876F9A50")]
	[AsyncStateMachine(typeof(PPGMJDLOFIP))]
	public static void NDPHAHNIOIB(this Task MPAMMAGABHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x34FC090", Offset = "0x34FB490", VA = "0x1834FC090")]
	[AsyncStateMachine(typeof(CNMGLAHFGBH<>))]
	public static Task PHPBFKKJMPM<TException>(this Task MPAMMAGABHA) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x34F7240", Offset = "0x34F6640", VA = "0x1834F7240")]
	[AsyncStateMachine(typeof(EKJNMGOKDJF<>))]
	public static Task<T> CDFNFCMPIEC<T>(this Task<T> IIICNLIAPBJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x76F8010", Offset = "0x76F7410", VA = "0x1876F8010")]
	[AsyncStateMachine(typeof(DMKGNABENDO))]
	public static Task<TaskStatus> DDOFDMOLOAM(this Task? IIICNLIAPBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x34FBD20", Offset = "0x34FB120", VA = "0x1834FBD20")]
	public static (Task<T?>?, Action<T?>?) LMBEHCMOFEF<T>([Optional] CancellationToken MLAPMBKLAOF)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x34FBA30", Offset = "0x34FAE30", VA = "0x1834FBA30")]
	[AsyncStateMachine(typeof(JFMGJLONBAA<, >))]
	public static Task<List<TResult>> JHJLBNLPBBO<TResult, TInput>(this Task<List<TInput>> GELALODAJCE, EIAMABOJFGF<TInput, TResult> MBALHGGPOOJ) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x76F9270", Offset = "0x76F8670", VA = "0x1876F9270")]
	[AsyncStateMachine(typeof(GBJFGLFKIJG))]
	public static Task LGCBIKPBCIJ(Task MPAMMAGABHA, CancellationToken IMBEMDEIDGJ, Func<CancellationToken, Task> CMDIOGNAHNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x76F8840", Offset = "0x76F7C40", VA = "0x1876F8840")]
	[AsyncStateMachine(typeof(KAFLEBOOOHL))]
	public static Task FGLOMECCPBG(Func<CancellationToken, Task> KJCHANDKGBO, TimeSpan OFCJJHCKIII, [Optional] CancellationToken IMBEMDEIDGJ, [Optional] Action<OperationCanceledException>? FLAGKHNINNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x34F7420", Offset = "0x34F6820", VA = "0x1834F7420")]
	[AsyncStateMachine(typeof(MGHLKBMLFGE<>))]
	public static Task<T> FGLOMECCPBG<T>(Func<CancellationToken, Task<T>> KJCHANDKGBO, TimeSpan OFCJJHCKIII, [Optional] CancellationToken IMBEMDEIDGJ, [Optional] Func<OperationCanceledException, T>? FLAGKHNINNA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x76F9540", Offset = "0x76F8940", VA = "0x1876F9540")]
	public static Task MMOHMCEIDJN(params Task[] BPEGHAOBLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x76F9590", Offset = "0x76F8990", VA = "0x1876F9590")]
	public static Task MMOHMCEIDJN(IEnumerable<Task> BPEGHAOBLGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x34FBC30", Offset = "0x34FB030", VA = "0x1834FBC30")]
	[AsyncStateMachine(typeof(FFGCOFEAIAA<>))]
	public static Task<IEnumerable<Task<T>>> KJNLHIGGABM<T>(IEnumerable<Task<T>> BPEGHAOBLGF) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x34F6F60", Offset = "0x34F6360", VA = "0x1834F6F60")]
	[AsyncStateMachine(typeof(DMPBJLNODEE<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> BCJBCGFEDFK<T1, T2, T3, T4, T5>(Task<T1> NGBKLNFENBH, Task<T2> GOLLGJGDBDE, Task<T3> MJJBKFBHBHB, Task<T4> JHGMEAJKIBE, Task<T5> EFCCOCFKICO) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x76F9B50", Offset = "0x76F8F50", VA = "0x1876F9B50")]
	[AsyncStateMachine(typeof(KBFKPJHJEEP))]
	public static Task NIOHBJDCPPH(Func<bool> FMLBJPAMJAA, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x76F9C40", Offset = "0x76F9040", VA = "0x1876F9C40")]
	[AsyncStateMachine(typeof(FGJBEPPPKJC))]
	public static Task NIOHBJDCPPH(Func<bool> FMLBJPAMJAA, TimeSpan BCPGOJCIBHJ, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x76F8710", Offset = "0x76F7B10", VA = "0x1876F8710")]
	[AsyncStateMachine(typeof(HFGBHNOMMAN))]
	public static Task FDPCFMFDBOC(Func<bool> FMLBJPAMJAA, TimeSpan OFCJJHCKIII, [Optional] CancellationToken MLAPMBKLAOF, [Optional] Action<OperationCanceledException>? FLAGKHNINNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x76F85D0", Offset = "0x76F79D0", VA = "0x1876F85D0")]
	[AsyncStateMachine(typeof(JGAHDMJLJIH))]
	public static Task FDPCFMFDBOC(Func<bool> FMLBJPAMJAA, TimeSpan OFCJJHCKIII, TimeSpan BCPGOJCIBHJ, [Optional] CancellationToken MLAPMBKLAOF, [Optional] Action<OperationCanceledException>? FLAGKHNINNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x76F8DF0", Offset = "0x76F81F0", VA = "0x1876F8DF0")]
	[AsyncStateMachine(typeof(EDNHJBAJIJF))]
	public static Task KBEJPIFIKLC(Func<bool> FMLBJPAMJAA, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x76F8CE0", Offset = "0x76F80E0", VA = "0x1876F8CE0")]
	[AsyncStateMachine(typeof(MELEINGLANP))]
	public static Task KBEJPIFIKLC(Func<bool> FMLBJPAMJAA, TimeSpan BCPGOJCIBHJ, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x76F7E30", Offset = "0x76F7230", VA = "0x1876F7E30")]
	[AsyncStateMachine(typeof(CKINMANIPJD))]
	public static Task ANNNKNDKDHI(Func<bool> FMLBJPAMJAA, TimeSpan OFCJJHCKIII, [Optional] CancellationToken MLAPMBKLAOF, [Optional] Action<OperationCanceledException>? FLAGKHNINNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x76F7CF0", Offset = "0x76F70F0", VA = "0x1876F7CF0")]
	[AsyncStateMachine(typeof(GCHLDBLNEEE))]
	public static Task ANNNKNDKDHI(Func<bool> FMLBJPAMJAA, TimeSpan OFCJJHCKIII, TimeSpan BCPGOJCIBHJ, [Optional] CancellationToken MLAPMBKLAOF, [Optional] Action<OperationCanceledException>? FLAGKHNINNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x76F9450", Offset = "0x76F8850", VA = "0x1876F9450")]
	[AsyncStateMachine(typeof(GGFCLBPFCGO))]
	[Obsolete]
	public static Task MBKIKMFEFGP(this Task GELALODAJCE, Action CNDMINKKMOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x34FBFA0", Offset = "0x34FB3A0", VA = "0x1834FBFA0")]
	[AsyncStateMachine(typeof(OLHDPICDNMA<>))]
	[Obsolete]
	public static Task MBKIKMFEFGP<T>(this Task<T> GELALODAJCE, Action<T> CNDMINKKMOO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x76F7F60", Offset = "0x76F7360", VA = "0x1876F7F60")]
	private static void BEGLKOMLGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x76F8F10", Offset = "0x76F8310", VA = "0x1876F8F10")]
	public static bool KICBOKFGNHO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x76F8450", Offset = "0x76F7850", VA = "0x1876F8450")]
	private static void FDJLGMEKIIB(SynchronizationContext PEBNJNGMMHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x76F9D50", Offset = "0x76F9150", VA = "0x1876F9D50")]
	private static void OHKHOFLHHPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x76F8C10", Offset = "0x76F8010", VA = "0x1876F8C10")]
	public static void JPBPEAIJFJK([Optional] string? LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x76F8100", Offset = "0x76F7500", VA = "0x1876F8100")]
	public static void DLNLCGHOOLK([Optional] string? LPIFIOEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x76F9B00", Offset = "0x76F8F00", VA = "0x1876F9B00")]
	public static MICOHECFBLJ NGDCAGODLEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x76F8970", Offset = "0x76F7D70", VA = "0x1876F8970")]
	public static MICOHECFBLJ FJHCHDANJPB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x76F81F0", Offset = "0x76F75F0", VA = "0x1876F81F0")]
	[AsyncStateMachine(typeof(FNOAAIILAMK))]
	public static Task EIMCAPAIKCO(Func<Task> JPHIIBFAEAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MENIDINFMMJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
	public MENIDINFMMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public class HHAOHLDJCAK : GHGLMKCGIMF
{
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public static readonly GHGLMKCGIMF AJPLFLPAHGP;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DateTime EJLOBLNOFGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x76F7170", Offset = "0x76F6570", VA = "0x1876F7170", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTimeOffset AGAHDNGLOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x76F7110", Offset = "0x76F6510", VA = "0x1876F7110", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x96D700", Offset = "0x96CB00", VA = "0x18096D700")]
	public HHAOHLDJCAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public interface GHGLMKCGIMF
{
	[Cpp2IlInjected.Token(Token = "0x17000021")]
	DateTime EJLOBLNOFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTimeOffset AGAHDNGLOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class NEAMNPDFKOD
{
	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public static long EBHAGKEGOME
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x76FF080", Offset = "0x76FE480", VA = "0x1876FF080")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long GLFDEEANEOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x76FF120", Offset = "0x76FE520", VA = "0x1876FF120")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static double JNGJAOPCPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x76FF2E0", Offset = "0x76FE6E0", VA = "0x1876FF2E0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double DBLDJLKHNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x76FF0D0", Offset = "0x76FE4D0", VA = "0x1876FF0D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double PFNOCDICOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x76FF200", Offset = "0x76FE600", VA = "0x1876FF200")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double KAIDFEOLKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x76FF030", Offset = "0x76FE430", VA = "0x1876FF030")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x76FF250", Offset = "0x76FE650", VA = "0x1876FF250")]
	public static double NFIFDFLDKIK(long MGHFMALCDEJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x76FF330", Offset = "0x76FE730", VA = "0x1876FF330")]
	public static double ONBCIDFECAK(long MGHFMALCDEJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x76FF3C0", Offset = "0x76FE7C0", VA = "0x1876FF3C0")]
	public static double PFDOMOHKKDD(double POBDFFAOEKC)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x76FF170", Offset = "0x76FE570", VA = "0x1876FF170")]
	public static long JCIANEGONKD(long JJPFHPNOEHC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x76FF020", Offset = "0x76FE420", VA = "0x1876FF020")]
	public static long BPPHMKIMFPO(long NDNCMNECHMI, long AJHEJFLNMEI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x76FEEF0", Offset = "0x76FE2F0", VA = "0x1876FEEF0")]
	public static double BGPCHDNKBKK(long NDNCMNECHMI, long AJHEJFLNMEI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x76FEFC0", Offset = "0x76FE3C0", VA = "0x1876FEFC0")]
	public static double BNPJIPLBLAO(long NDNCMNECHMI, long AJHEJFLNMEI)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public sealed class FMMMFLABEKB : LFEJENGEAGE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly TimeSpan GIOLAMIMPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly System.Timers.Timer LMBGFJBPMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private TimeSpan OFCJJHCKIII;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public TimeSpan GGHDECEONNG
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9682E0", Offset = "0x9676E0", VA = "0x1809682E0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x76F5580", Offset = "0x76F4980", VA = "0x1876F5580", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Action? NIHKNFNGBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x969470", Offset = "0x968870", VA = "0x180969470", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x76F5AD0", Offset = "0x76F4ED0", VA = "0x1876F5AD0")]
	[Preserve]
	public FMMMFLABEKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x76F5880", Offset = "0x76F4C80", VA = "0x1876F5880")]
	public FMMMFLABEKB(TimeSpan OFCJJHCKIII, [Optional] Action? PBDLNCKBHEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x76F54F0", Offset = "0x76F48F0", VA = "0x1876F54F0", Slot = "7")]
	public void EDANEBCOOOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x76F56E0", Offset = "0x76F4AE0", VA = "0x1876F56E0", Slot = "8")]
	public void LAPNCKBMFIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x76F5750", Offset = "0x76F4B50", VA = "0x1876F5750", Slot = "9")]
	public void OLLPJMBNIFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xFD7510", Offset = "0xFD6910", VA = "0x180FD7510")]
	private void HMGJLPFGCBN(object NCCMNNBGHEA, ElapsedEventArgs OKLPBFCEPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x76F5780", Offset = "0x76F4B80", VA = "0x1876F5780")]
	private static void OMAMJFEPDPG(TimeSpan JIJIIPOEEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x76F5450", Offset = "0x76F4850", VA = "0x1876F5450", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class FDIEMNELNCN : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public readonly string? FEIEDJDADNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public readonly string FEBGHFLEEJP;

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x70AA510", Offset = "0x70A9910", VA = "0x1870AA510")]
	public FDIEMNELNCN(string APDEKOCIEGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4874990", Offset = "0x4873D90", VA = "0x184874990")]
	public FDIEMNELNCN(string IDNJHOBOFAO, string APDEKOCIEGN)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct LMMLKBHKBDN : IEquatable<LMMLKBHKBDN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public uint CPPJFCCEIOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public int PCKKDKGCANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public float IJEFMNJLANJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public ushort LEFKIBAOEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public ushort FECJEDCPJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public short OBMPOFDIFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public short CHCALGKGKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public char NGCAHBLANKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public char NHLOKFEDPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public byte ONLFMBOLCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte ICFEDKAOFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public byte JLGIAGDHCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public byte LAONGCFJECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public bool LPMHHECNDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public bool DICGFIPKGFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool JEKMLJHCLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public bool PDHAEHPALGE;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x1C8C810", Offset = "0x1C8BC10", VA = "0x181C8C810")]
	public static LMMLKBHKBDN MIBBCIBOHFC(uint LPEFGANDPGH)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x1C8C810", Offset = "0x1C8BC10", VA = "0x181C8C810")]
	public static LMMLKBHKBDN LMDJHMAOEFF(int IJNAPLMKODI)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x76FD7B0", Offset = "0x76FCBB0", VA = "0x1876FD7B0")]
	public static LMMLKBHKBDN BJHOALPLBFP(float MIHOFCAFHOH)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x76FD840", Offset = "0x76FCC40", VA = "0x1876FD840")]
	public static LMMLKBHKBDN FCMDACJKLCA(byte HJFJHEEIHEN, byte HIOPOHAKJDH, byte BBCGFBBMBHG, byte HAFFIODPFEO)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x76FD840", Offset = "0x76FCC40", VA = "0x1876FD840")]
	public static LMMLKBHKBDN NKNLMAIOIAE(bool FPCNEKDDAPC, bool IACDEDFOEHD, bool GGPOHJOCGDN, bool PLDPFMOHPND)
	{
		return default(LMMLKBHKBDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x76FD840", Offset = "0x76FCC40", VA = "0x1876FD840")]
	public static LMMLKBHKBDN FCNFEDDJHBF(byte OCGEFNFAFOF, byte BKEHGJANCAC, byte PHFGGHFOMGI, byte MDAANPCICFO)
	{
		return default(LMMLKBHKBDN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x1F606A0", Offset = "0x1F5FAA0", VA = "0x181F606A0")]
	public static bool JECEAGOPPKI(LMMLKBHKBDN HGHHJPDLMPJ, LMMLKBHKBDN OLNKLOFDFBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x1F60680", Offset = "0x1F5FA80", VA = "0x181F60680", Slot = "4")]
	public bool Equals(LMMLKBHKBDN MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x76FD7C0", Offset = "0x76FCBC0", VA = "0x1876FD7C0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x115EB10", Offset = "0x115DF10", VA = "0x18115EB10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x76FD860", Offset = "0x76FCC60", VA = "0x1876FD860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct LPDKAPEIFMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public ulong AGCNFJMNHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public long DFOKFPECDHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public double MLGIILOGBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public uint LPNHHJLKFKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public uint LOIMLCIDAMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public int CKFJAGMLBHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int HBDJEEPJEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float DJHBJJPODJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public float NDJBILGJKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort LEFKIBAOEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public ushort FECJEDCPJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public ushort ABFDIKNBIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public ushort GFNOMOKIHIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public short OBMPOFDIFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public short CHCALGKGKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public short KNPLEHABAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public short NIDLGCCIDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public char NGCAHBLANKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public char NHLOKFEDPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public char JEDFPGEIKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public char PIEGLLPLFIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public byte ONLFMBOLCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public byte ICFEDKAOFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public byte JLGIAGDHCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public byte LAONGCFJECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte MKBAMANOGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public byte ICJJEAAFKNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public byte DKJLCIOELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public byte NOEIHJGMOKE;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static LPDKAPEIFMK KMDIICJFNJF(long LNFAAAKPFJB)
	{
		return default(LPDKAPEIFMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x76FE650", Offset = "0x76FDA50", VA = "0x1876FE650")]
	public static LPDKAPEIFMK KMDIICJFNJF(byte HJFJHEEIHEN, byte HIOPOHAKJDH, byte BBCGFBBMBHG, byte HAFFIODPFEO, byte MGOHLGBAHMG, byte KBIEBAOPIFO, byte IPOHOOFFJGL, byte KCPBOHLHBMP)
	{
		return default(LPDKAPEIFMK);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct KGNMDDOLMMM : IEquatable<KGNMDDOLMMM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public byte MJHINOEGLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool MMEEBHMICGH;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x2BFD220", Offset = "0x2BFC620", VA = "0x182BFD220")]
	public static KGNMDDOLMMM FCMDACJKLCA(byte HKHPIMIEGFJ)
	{
		return default(KGNMDDOLMMM);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x2BFD220", Offset = "0x2BFC620", VA = "0x182BFD220")]
	public static KGNMDDOLMMM NKNLMAIOIAE(bool HFNHBPGHMBN)
	{
		return default(KGNMDDOLMMM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x76FC680", Offset = "0x76FBA80", VA = "0x1876FC680")]
	public static bool JECEAGOPPKI(KGNMDDOLMMM HGHHJPDLMPJ, KGNMDDOLMMM OLNKLOFDFBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x673CA70", Offset = "0x673BE70", VA = "0x18673CA70", Slot = "4")]
	public bool Equals(KGNMDDOLMMM MNALNBMKJLK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x76FC5E0", Offset = "0x76FB9E0", VA = "0x1876FC5E0", Slot = "0")]
	public override bool Equals(object NBAMGPFDMIB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x76FC670", Offset = "0x76FBA70", VA = "0x1876FC670", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x76FC690", Offset = "0x76FBA90", VA = "0x1876FC690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class PJIPHNKGGCJ<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public readonly T MNFHKDIMMIO;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x50A64D0", Offset = "0x50A58D0", VA = "0x1850A64D0")]
	public PJIPHNKGGCJ(T NIJOHCBEGAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class MGLMLPNOELA
{
	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x3548770", Offset = "0x3547B70", VA = "0x183548770")]
	public static IEnumerable<T> OBKBMCGOOCE<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static T[] CCJMLJCBIGI<T>(params T[] IOEJEMFDGBP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0xB838A0", Offset = "0xB82CA0", VA = "0x180B838A0")]
	public static IEnumerable<T> BBKNPHKIPCK<T>(params T[] IOEJEMFDGBP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x34828A0", Offset = "0x3481CA0", VA = "0x1834828A0")]
	public static HashSet<T> MHCDOMFKLAN<T>(params T[] IOEJEMFDGBP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x35BC950", Offset = "0x35BBD50", VA = "0x1835BC950")]
	public static KeyValuePair<TKey, TValue> IOFJIPLIGLC<TKey, TValue>([In] TKey MCNLCGLNHHO, [In] TValue PEBNJNGMMHE) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x34828A0", Offset = "0x3481CA0", VA = "0x1834828A0")]
	public static List<T> FDIDAMEIFJO<T>(IEnumerable<T> GONANEIKMGH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All)]
public sealed class AJMJIHOHNKK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly string KJDKMMLGMKB;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x990590", Offset = "0x98F990", VA = "0x180990590")]
	public AJMJIHOHNKK(string LKAFJIABCIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public delegate object GPLAPEEBCFB<T>([In] T BKIADHLGJLK);
[Cpp2IlInjected.Token(Token = "0x2000063")]
public delegate object FGABCFFNONJ<T>(T BKIADHLGJLK);
[Cpp2IlInjected.Token(Token = "0x2000064")]
[ICLKNMOKHNO]
public delegate string LHFOHFLJLIK(string KDFEGOCHHNF, string? MLLBPGGFLHM, bool NKGKEFIFEFM);
[Cpp2IlInjected.Token(Token = "0x2000065")]
[ICLKNMOKHNO]
public delegate void BEEGMBDMOME(string LPIFIOEEOGF);
[Cpp2IlInjected.Token(Token = "0x2000066")]
[ICLKNMOKHNO]
public delegate void IMDGDEPPECK(Exception BOKONMFPKMC);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object BJJDLKAELBO();
[Cpp2IlInjected.Token(Token = "0x2000068")]
[ICLKNMOKHNO]
public delegate bool IPECHCCOLFD();
[Cpp2IlInjected.Token(Token = "0x2000069")]
[ICLKNMOKHNO]
public delegate string JPHHFLDGFLK(object NBAMGPFDMIB);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[AttributeUsage(AttributeTargets.Enum)]
public class BKNIMIMDCGL : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x98FE40", Offset = "0x98F240", VA = "0x18098FE40")]
	public BKNIMIMDCGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public static class HJMIKNJLJPK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CompilerGenerated]
	private struct LJCBBKMMAMA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x76FCE50", Offset = "0x76FC250", VA = "0x1876FCE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x76FD740", Offset = "0x76FCB40", VA = "0x1876FD740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly TimerCallback DICCGHHDFIB;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly Action<object?> MIPGOAICMJP;

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x76F73E0", Offset = "0x76F67E0", VA = "0x1876F73E0")]
	public static Task<bool> KLGGMFJCECF(int GAJCHJEOONF, [Optional] CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x76F7220", Offset = "0x76F6620", VA = "0x1876F7220")]
	[AsyncStateMachine(typeof(LJCBBKMMAMA))]
	private static Task<bool> AFGADIDCPJG(int GAJCHJEOONF, CancellationToken MLAPMBKLAOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x76F7350", Offset = "0x76F6750", VA = "0x1876F7350")]
	private static void EBNJECOENAL(object? MLIDEILJAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x76F76E0", Offset = "0x76F6AE0", VA = "0x1876F76E0")]
	private static void PHEHAHGLGEB(object? MLIDEILJAJE)
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
