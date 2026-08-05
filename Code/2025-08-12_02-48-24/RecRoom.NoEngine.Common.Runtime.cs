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
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85CA330", Offset = "0x85C8930", VA = "0x1885CA330")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0AE0", Offset = "0xABF0E0", VA = "0x180AC0AE0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JKNHKECLAPF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x85C5440", Offset = "0x85C3A40", VA = "0x1885C5440")]
	public static string BIOEEPCDPBO(this Encoding IHCNHBPPIAK, [In] ReadOnlySequence<byte> NCMOHOAIBBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3E39920", Offset = "0x3E37F20", VA = "0x183E39920")]
	private static void EOENFMLBMLL<T>(this ReadOnlySequence<T> PEFGHDGBIEG, [Out] ReadOnlySpan<T> PEPOIPDPPHP, [Out] SequencePosition NMDPPNGCJLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class EAPJDKNMMKA : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x85BED80", Offset = "0x85BD380", VA = "0x1885BED80")]
	public EAPJDKNMMKA(bool ECFOJHFNHJB, string NKCEABIFHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x85BEE60", Offset = "0x85BD460", VA = "0x1885BEE60")]
	public EAPJDKNMMKA(bool ECFOJHFNHJB, params string[] LAHOOBFDLNI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KAHLLLCHPCA
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface FHBLDJNFGEM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IACALJFCOFE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHKAELNFMPI(string HFLDIIIPBCG, double FKMNCAKIOFK, [Optional] string? DLBNDONJFMA);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GEELFAHLHFB : EFMIOLLFLFP, HCJAGCOJEOH, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int KMLIOEIIOPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> GLLKDGJOKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double AJNNFOKDGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double BHCLOJJFNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double MIDALPLPPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int OGLOGIAMOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double AAMOAFCPPKA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DHFNIFHFHIH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xAB3880", Offset = "0xAB1E80", VA = "0x180AB3880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double HMLIKOJBAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x85BFF00", Offset = "0x85BE500", VA = "0x1885BFF00", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double DGCONLAPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2A216E0", Offset = "0x2A1FCE0", VA = "0x182A216E0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double AGPDBMJADOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2A582A0", Offset = "0x2A568A0", VA = "0x182A582A0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x85C0200", Offset = "0x85BE800", VA = "0x1885C0200")]
	public GEELFAHLHFB(int JMNKPGIFBMP, double AAMOAFCPPKA = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x85BFF60", Offset = "0x85BE560", VA = "0x1885BFF60", Slot = "7")]
	public void CABKLPHLDLI(double PGNMBFKGLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x85C0190", Offset = "0x85BE790", VA = "0x1885C0190", Slot = "8")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x85C0090", Offset = "0x85BE690", VA = "0x1885C0090", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class IEPOGGHPCID : EFMIOLLFLFP, HCJAGCOJEOH, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long FEEKNNBMJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double HNAGKEEEGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double JOKCIHBLLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double FDJPIGMOFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double FAHNDGGJLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double AJNNFOKDGKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double BHCLOJJFNGO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DGBEIHMBLFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double DGCONLAPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x778CCC0", Offset = "0x778B2C0", VA = "0x18778CCC0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double AGPDBMJADOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x778C860", Offset = "0x778AE60", VA = "0x18778C860", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double PLPFANLIBCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x778CCA0", Offset = "0x778B2A0", VA = "0x18778CCA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double HMLIKOJBAJM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A21700", Offset = "0x2A1FD00", VA = "0x182A21700", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x85C1CA0", Offset = "0x85C02A0", VA = "0x1885C1CA0", Slot = "10")]
	public virtual void CABKLPHLDLI(double PGNMBFKGLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x85C1E30", Offset = "0x85C0430", VA = "0x1885C1E30", Slot = "11")]
	public virtual void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x85C1DC0", Offset = "0x85C03C0", VA = "0x1885C1DC0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x85C1E70", Offset = "0x85C0470", VA = "0x1885C1E70")]
	public IEPOGGHPCID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LGOGDIPJFJK : IEPOGGHPCID
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double OGNJALNDOHM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x778CCD0", Offset = "0x778B2D0", VA = "0x18778CCD0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x778C870", Offset = "0x778AE70", VA = "0x18778C870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x85C7F80", Offset = "0x85C6580", VA = "0x1885C7F80", Slot = "10")]
	public override void CABKLPHLDLI(double PGNMBFKGLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x85C80B0", Offset = "0x85C66B0", VA = "0x1885C80B0", Slot = "11")]
	public override void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x85C1E70", Offset = "0x85C0470", VA = "0x1885C1E70")]
	public LGOGDIPJFJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface EFMIOLLFLFP : HCJAGCOJEOH, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double HMLIKOJBAJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double DGCONLAPJBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double AGPDBMJADOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class PNOLCAPMGFP : HCJAGCOJEOH, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double BNIAGNJFLEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double KPPPHJIHAFH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x85CACF0", Offset = "0x85C92F0", VA = "0x1885CACF0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x71C58F0", Offset = "0x71C3EF0", VA = "0x1871C58F0", Slot = "4")]
	public void CABKLPHLDLI(double PGNMBFKGLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x85CAD00", Offset = "0x85C9300", VA = "0x1885CAD00", Slot = "5")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x85CACA0", Offset = "0x85C92A0", VA = "0x1885CACA0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public PNOLCAPMGFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HCJAGCOJEOH : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CABKLPHLDLI(double PGNMBFKGLAH);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IMGLACMMFNI();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class CFAIHHCJKPO : HCJAGCOJEOH, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double FKMNCAKIOFK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double FAGODIAEODP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x120BB30", Offset = "0x120A130", VA = "0x18120BB30")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x59B75C0", Offset = "0x59B5BC0", VA = "0x1859B75C0", Slot = "4")]
	public void CABKLPHLDLI(double PGNMBFKGLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x85BE500", Offset = "0x85BCB00", VA = "0x1885BE500", Slot = "5")]
	public void IMGLACMMFNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x85BE4B0", Offset = "0x85BCAB0", VA = "0x1885BE4B0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public CFAIHHCJKPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ECDGFPHNEKP<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> IKBOLEPACIN(CancellationToken MEKNAIONNND);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct CGCJLJAJAMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ECDGFPHNEKP<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public IKBOLEPACIN taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x6DD59A0", Offset = "0x6DD3FA0", VA = "0x186DD59A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6DD69F0", Offset = "0x6DD4FF0", VA = "0x186DD69F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource HJMKFNDDHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? LAGMOAGHNLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? PCNEPKHABBH;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E200", Offset = "0x4A4C800", VA = "0x184A4E200")]
	[AsyncStateMachine(typeof(ECDGFPHNEKP<>.CGCJLJAJAMI))]
	public Task<TResult> ADMCKGFBJLK(IKBOLEPACIN BCGALHNGCBA, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E340", Offset = "0x4A4C940", VA = "0x184A4E340", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4A4E3B0", Offset = "0x4A4C9B0", VA = "0x184A4E3B0")]
	public ECDGFPHNEKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class EDNHFMIDFFA<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> PCNHLFMJLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T FAGODIAEODP;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4A56ED0", Offset = "0x4A554D0", VA = "0x184A56ED0")]
	public EDNHFMIDFFA([In] T FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A55D10", Offset = "0x4A54310", VA = "0x184A55D10", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4A565C0", Offset = "0x4A54BC0", VA = "0x184A565C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4A56CC0", Offset = "0x4A552C0", VA = "0x184A56CC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class GNFBOJKILKB
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8630", Offset = "0x3BD6C30", VA = "0x183BD8630")]
	public static EDNHFMIDFFA<T> BPFPEFLIIPC<T>([In] T FKMNCAKIOFK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class OMOPPDGKPDG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x85CAA30", Offset = "0x85C9030", VA = "0x1885CAA30")]
	public static void FKJPGNODKCO(this CancellationTokenSource HJMKFNDDHID, bool BKFGMGGFKBA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class BKCJPPCFFFH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public BKCJPPCFFFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class HCMEEGOFNEK : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public HCMEEGOFNEK(string NIJMFFGPJIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class BCGEBEHOAHI
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3B0E3C0", Offset = "0x3B0C9C0", VA = "0x183B0E3C0")]
	public static NHCELAJFOCI MMPMKGNIFOF<T>()
	{
		return default(NHCELAJFOCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x85BDF20", Offset = "0x85BC520", VA = "0x1885BDF20")]
	public static NHCELAJFOCI FELJOIFLNOD([CallerMemberName] string DJFMCHMDHGK = "")
	{
		return default(NHCELAJFOCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3B0E190", Offset = "0x3B0C790", VA = "0x183B0E190")]
	public static NHCELAJFOCI IBHECGJENFJ<T>([CallerMemberName] string DJFMCHMDHGK = "") where T : notnull
	{
		return default(NHCELAJFOCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3B0E440", Offset = "0x3B0CA40", VA = "0x183B0E440")]
	public static NHCELAJFOCI MMPMKGNIFOF<T>(this T CGLIDCMIAEF) where T : notnull
	{
		return default(NHCELAJFOCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3B0E010", Offset = "0x3B0C610", VA = "0x183B0E010")]
	public static NHCELAJFOCI FELJOIFLNOD<T>(this T CGLIDCMIAEF, [CallerMemberName] string DJFMCHMDHGK = "") where T : notnull
	{
		return default(NHCELAJFOCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3B0E220", Offset = "0x3B0C820", VA = "0x183B0E220")]
	public static NHCELAJFOCI IBHECGJENFJ<T>(this T CCKLBDLJPNG, [CallerMemberName] string DJFMCHMDHGK = "") where T : notnull
	{
		return default(NHCELAJFOCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x85BDF80", Offset = "0x85BC580", VA = "0x1885BDF80")]
	public static NHCELAJFOCI IBHECGJENFJ(string MELMENILBGM, [CallerMemberName] string DJFMCHMDHGK = "")
	{
		return default(NHCELAJFOCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x85BDE80", Offset = "0x85BC480", VA = "0x1885BDE80")]
	public static string AEDPBAMPCNI(this object CCKLBDLJPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool EOACEICOFML();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BKCJPPCFFFH]
public delegate long JEIDNOBOFMN();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class IHGPCEBDMMM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly IHGPCEBDMMM DOBPPELCKJD;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public IHGPCEBDMMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class GMCNGGEGNGL
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static JMKIGEDEDCG FNPJKIDINLE;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static JMKIGEDEDCG HGBMLHCLCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x85C0EE0", Offset = "0x85BF4E0", VA = "0x1885C0EE0")]
		get
		{
			return default(JMKIGEDEDCG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static JKOPPOLJOEJ CLNGADFHKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x85C0F90", Offset = "0x85BF590", VA = "0x1885C0F90")]
		get
		{
			return default(JKOPPOLJOEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static OALCPCGHNMA DGKOCDHOHEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x85C0C50", Offset = "0x85BF250", VA = "0x1885C0C50")]
		get
		{
			return default(OALCPCGHNMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool MHKKIABHMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85C0FE0", Offset = "0x85BF5E0", VA = "0x1885C0FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x85C0AA0", Offset = "0x85BF0A0", VA = "0x1885C0AA0")]
	public static void CIELEGCDDFO([In] JMKIGEDEDCG JLHNCGEDJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x85C0860", Offset = "0x85BEE60", VA = "0x1885C0860")]
	public static void AOPICECIPOD(string IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x85C0930", Offset = "0x85BEF30", VA = "0x1885C0930")]
	public static void BBAMHENPGLL(string IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3DABB70", Offset = "0x3DAA170", VA = "0x183DABB70")]
	public static void BBAMHENPGLL<T>(T HOOMHDKIGBG, HPFCFOLIJFH<T> IFEHDCDCFPK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x85C0A00", Offset = "0x85BF000", VA = "0x1885C0A00")]
	public static void BDLFIOLIBJG(Exception JLPOJCLEBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x85C0CA0", Offset = "0x85BF2A0", VA = "0x1885C0CA0")]
	public static void FEKDDBGEIEA(string DJFMCHMDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x85C0F30", Offset = "0x85BF530", VA = "0x1885C0F30")]
	public static void LCFGDHOACEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x85C07E0", Offset = "0x85BEDE0", VA = "0x1885C07E0")]
	public static string AEDPBAMPCNI(object NDBJJGOPOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x85C0E70", Offset = "0x85BF470", VA = "0x1885C0E70")]
	public static long KFABFOAHDGJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x85C0DD0", Offset = "0x85BF3D0", VA = "0x1885C0DD0")]
	public static bool GFBNHBOPLJO(bool OEOGIGLGCGF, string IFEHDCDCFPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x85C0D00", Offset = "0x85BF300", VA = "0x1885C0D00")]
	public static double GCEGMJONFOD()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct JMKIGEDEDCG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly JKOPPOLJOEJ CLNGADFHKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly OALCPCGHNMA DGKOCDHOHEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly OGAEPJNCNDM IJOBCDEBLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly JEIDNOBOFMN APKBNINNFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly MKHCCOMHLNI EIKODLFNECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly EOACEICOFML ACCNFJBCCGI;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly OGAEPJNCNDM JJFLMOODNOG;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly JEIDNOBOFMN CMOMFMNCDLO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly MKHCCOMHLNI EDEKHJDFEII;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly EOACEICOFML JGCJLMEEOAH;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly JMKIGEDEDCG KBCDDOOGPEK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool ACEIOKDFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85C6730", Offset = "0x85C4D30", VA = "0x1885C6730")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x85C7000", Offset = "0x85C5600", VA = "0x1885C7000")]
	public JMKIGEDEDCG([In] JKOPPOLJOEJ LEMIDOLKCCL, [In] OALCPCGHNMA BGFNPMKAFGH, OGAEPJNCNDM JGNMICOLKAE, JEIDNOBOFMN JHDFHLOIOFC, MKHCCOMHLNI NLEOLNMLBGP, EOACEICOFML DGBGLKCJBDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x85C68D0", Offset = "0x85C4ED0", VA = "0x1885C68D0")]
	private static string NOMPAMCELLA(object NDBJJGOPOFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA97AD0", Offset = "0xA960D0", VA = "0x180A97AD0")]
	private static long EOKKPECMOGA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	private static string PEABEIPKDKD(string IAKFGDELOKN, string? KOHOAAFOHKL, bool PFGJFPKJCOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
	private static bool IOAPCAEGCDH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85C6620", Offset = "0x85C4C20", VA = "0x1885C6620")]
	private static JMKIGEDEDCG ACGBGAOJHAB()
	{
		return default(JMKIGEDEDCG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface LEAIFAPCDML
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KBMACPEMFIF PMJGCHFEIKP();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface KBMACPEMFIF : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ALMJMEFJFAC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBEEOLPLCJE();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface CFFKDHOLKHH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AOLJNLPKMBH([In] T IBCMCOKAJEM);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void FHMDFFIIADB<T>([In] T HOOMHDKIGBG);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct ADPAFALDCBO<T> : IEquatable<ADPAFALDCBO<T>>, CFFKDHOLKHH<ADPAFALDCBO<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T FAGODIAEODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int LBGMECNKHAM;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x3084C60", Offset = "0x3083260", VA = "0x183084C60")]
	public ADPAFALDCBO([In] T FKMNCAKIOFK, int LEPAEEGOBDO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51EADA0", Offset = "0x51E93A0", VA = "0x1851EADA0")]
	public static bool LMIMJGGKHMP([In] ADPAFALDCBO<T> LEOAACGBJCD, [In] ADPAFALDCBO<T> GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x51EAC10", Offset = "0x51E9210", VA = "0x1851EAC10", Slot = "4")]
	public bool Equals(ADPAFALDCBO<T> IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4F24B10", Offset = "0x4F23110", VA = "0x184F24B10", Slot = "0")]
	public override bool Equals(object IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x51EAAE0", Offset = "0x51E90E0", VA = "0x1851EAAE0")]
	public bool AOLJNLPKMBH([In] ADPAFALDCBO<T> IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x51EACF0", Offset = "0x51E92F0", VA = "0x1851EACF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x51EAE60", Offset = "0x51E9460", VA = "0x1851EAE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51EAB70", Offset = "0x51E9170", VA = "0x1851EAB70")]
	public void BHACFNDCJGJ([Out] T FKMNCAKIOFK, [Out] int LEPAEEGOBDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x51EAC90", Offset = "0x51E9290", VA = "0x1851EAC90")]
	public (T, int) GECDMFOGODJ()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x51EAD50", Offset = "0x51E9350", VA = "0x1851EAD50", Slot = "5")]
	private bool JDCONGICJLH([In] ADPAFALDCBO<T> IBCMCOKAJEM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DPHMHDIKMIM
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3BE98C0", Offset = "0x3BE7EC0", VA = "0x183BE98C0")]
	public static ADPAFALDCBO<T> BPFPEFLIIPC<T>([In] T FKMNCAKIOFK, int LEPAEEGOBDO) where T : notnull
	{
		return default(ADPAFALDCBO<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class IANGNLDMJHL
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0170", Offset = "0x3DEE770", VA = "0x183DF0170")]
	public static bool AOLJNLPKMBH<T, U>([In] T CCKLBDLJPNG, [In] U NDBJJGOPOFO) where T : notnull, CFFKDHOLKHH<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult JGMNCJFOLDK<T, out TResult>([In] T HOOMHDKIGBG);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface EEJEGNJBENC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan OJDNAFOKNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? DFAHJONMABI
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JKGHENBEODP();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHLIKPJFFME();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MNEFMGBPPHF();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct JKOPPOLJOEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly LNNGPDJMJGH HGJDCKNHCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly COPKBMBABLK IJEOJJKHLGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly LNNGPDJMJGH DIDMGGPOKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly COPKBMBABLK JBPGNBIMPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly LNNGPDJMJGH NBKAKCNIOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly COPKBMBABLK LEALBGNOCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly HBHFMGKLIKA GBHNFFOHCPI;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly LNNGPDJMJGH JBAGCBHOPIF;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly COPKBMBABLK CALDKHJFNFJ;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly LNNGPDJMJGH OKIJCFFKPEL;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly COPKBMBABLK APAPIKPEADP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly LNNGPDJMJGH JMBDJBGCODC;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly COPKBMBABLK IMOKPOCLAAK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly HBHFMGKLIKA LGOACKNLJFP;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly JKOPPOLJOEJ KBCDDOOGPEK;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly LNNGPDJMJGH HEONMIFOMJF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool ACEIOKDFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x85C5D00", Offset = "0x85C4300", VA = "0x1885C5D00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xF0A770", Offset = "0xF08D70", VA = "0x180F0A770")]
	public JKOPPOLJOEJ(LNNGPDJMJGH CFLCMBMOGLE, COPKBMBABLK NDHDABLCJOE, LNNGPDJMJGH GFEKJKIBPHK, COPKBMBABLK ONGMHOPOBJO, LNNGPDJMJGH ENIKNIIIMMG, COPKBMBABLK EEHDJJMJAKP, HBHFMGKLIKA CJPOIPNELON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
	private static bool LDJFNEPOFDG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void AILGNBFPMIE(string IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
	private static bool FGONOFKKLKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void DHLHIEFJHCD(string IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xAE06A0", Offset = "0xADECA0", VA = "0x180AE06A0")]
	private static bool KAPKBCIKJJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void BCOIAHNAMFH(string IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void IHBMCDEJLMJ(Exception JLPOJCLEBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x85C5A00", Offset = "0x85C4000", VA = "0x1885C5A00")]
	private static JKOPPOLJOEJ ACGBGAOJHAB()
	{
		return default(JKOPPOLJOEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0")]
	private static bool GJGAOOMNLCJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x85C5B40", Offset = "0x85C4140", VA = "0x1885C5B40")]
	public void AOPICECIPOD(object IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x85C5F00", Offset = "0x85C4500", VA = "0x1885C5F00")]
	public void EGBKOKPDGOP(object IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x85C5C90", Offset = "0x85C4290", VA = "0x1885C5C90")]
	public void BBAMHENPGLL(object IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xF08F70", Offset = "0xF07570", VA = "0x180F08F70")]
	public void BDLFIOLIBJG(Exception JLPOJCLEBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x85C5BB0", Offset = "0x85C41B0", VA = "0x1885C5BB0")]
	public void BBAMHENPGLL(ONPPLFBJMMN IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3E39C00", Offset = "0x3E38200", VA = "0x183E39C00")]
	public void BBAMHENPGLL<T>(T HOOMHDKIGBG, HPFCFOLIJFH<T> IFEHDCDCFPK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3E39A80", Offset = "0x3E38080", VA = "0x183E39A80")]
	public void AOPICECIPOD<T>([In] T HOOMHDKIGBG, KCNEOAAJAIK<T> IFEHDCDCFPK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E39CD0", Offset = "0x3E382D0", VA = "0x183E39CD0")]
	public void BBAMHENPGLL<T>([In] T HOOMHDKIGBG, KCNEOAAJAIK<T> IFEHDCDCFPK) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x85C5F70", Offset = "0x85C4570", VA = "0x1885C5F70")]
	public bool GFBNHBOPLJO(bool OEOGIGLGCGF, string IFEHDCDCFPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct NHCELAJFOCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string FAGODIAEODP;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xEB2930", Offset = "0xEB0F30", VA = "0x180EB2930")]
	public NHCELAJFOCI(string FKMNCAKIOFK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570")]
	public static string HPNBGLLBBBG([In] NHCELAJFOCI CCKLBDLJPNG)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x1485C10", Offset = "0x1484210", VA = "0x181485C10")]
	public static NHCELAJFOCI HPNBGLLBBBG(string IBCMCOKAJEM)
	{
		return default(NHCELAJFOCI);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x85C9EB0", Offset = "0x85C84B0", VA = "0x1885C9EB0")]
	public string FIACPPGFNDF(string BOKKEFJOAFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x85C9F00", Offset = "0x85C8500", VA = "0x1885C9F00")]
	public string MILGNDKFDEN(object GIBBEKEOBHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xB41570", Offset = "0xB3FB70", VA = "0x180B41570", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class APKFIPDHNMB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public APKFIPDHNMB()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct GDCHOBJFCMN : IEquatable<GDCHOBJFCMN>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xAB05C0", Offset = "0xAAEBC0", VA = "0x180AB05C0", Slot = "4")]
	public bool Equals(GDCHOBJFCMN IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x85BFE70", Offset = "0x85BE470", VA = "0x1885BFE70", Slot = "0")]
	public override bool Equals(object IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x85BFEC0", Offset = "0x85BE4C0", VA = "0x1885BFEC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x85BFED0", Offset = "0x85BE4D0", VA = "0x1885BFED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[BHJILBNHLDI("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct FDKDBGPHKIF<T> : IEquatable<FDKDBGPHKIF<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T FAGODIAEODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool LLJHGJBDADF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool FPCAFDCNAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4F25D70", Offset = "0x4F24370", VA = "0x184F25D70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4F26D30", Offset = "0x4F25330", VA = "0x184F26D30")]
	public FDKDBGPHKIF([In] T FKMNCAKIOFK, bool PLGLDFMDJBN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x4F25E90", Offset = "0x4F24490", VA = "0x184F25E90")]
	public static bool LMIMJGGKHMP([In] FDKDBGPHKIF<T> LEOAACGBJCD, [In] FDKDBGPHKIF<T> GDBFOEGEGHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4F24980", Offset = "0x4F22F80", VA = "0x184F24980", Slot = "4")]
	public bool Equals(FDKDBGPHKIF<T> IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4F25270", Offset = "0x4F23870", VA = "0x184F25270", Slot = "0")]
	public override bool Equals(object? IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4F257E0", Offset = "0x4F23DE0", VA = "0x184F257E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4F269D0", Offset = "0x4F24FD0", VA = "0x184F269D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class KACIKDDONLN
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3E60610", Offset = "0x3E5EC10", VA = "0x183E60610")]
	public static FDKDBGPHKIF<T> HALJCABGOKM<T>([In] T FKMNCAKIOFK) where T : notnull
	{
		return default(FDKDBGPHKIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3E608B0", Offset = "0x3E5EEB0", VA = "0x183E608B0")]
	public static FDKDBGPHKIF<T?> MAAGEGDDNNF<T>()
	{
		return default(FDKDBGPHKIF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3E60780", Offset = "0x3E5ED80", VA = "0x183E60780")]
	public static bool IEGIHNPGGNO<T>([In] this FDKDBGPHKIF<T> NMBGOHHDPHF, [Out][NotNullWhen(true)] T FKMNCAKIOFK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3E60740", Offset = "0x3E5ED40", VA = "0x183E60740")]
	public static bool IEGIHNPGGNO<T>([In] this FDKDBGPHKIF<T> NMBGOHHDPHF, [Out][NotNullWhen(true)] T FKMNCAKIOFK, [Out] FDKDBGPHKIF<T> MBFKCEFNJOJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3E603B0", Offset = "0x3E5E9B0", VA = "0x183E603B0")]
	public static T? CJIGAIEDKKE<T>([In] this FDKDBGPHKIF<T> NMBGOHHDPHF, T? DAKPJNHJLJO)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3E60410", Offset = "0x3E5EA10", VA = "0x183E60410")]
	public static bool DICCAIDOMPH<T>([In] this FDKDBGPHKIF<T> NMBGOHHDPHF, T FKMNCAKIOFK) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class HNJIGCCHFIC
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3DE1510", Offset = "0x3DDFB10", VA = "0x183DE1510")]
	public static T LKJLJCNEEJK<T>([In] this FDKDBGPHKIF<T> NMBGOHHDPHF) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct OALCPCGHNMA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr FEKDDBGEIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr LCFGDHOACEA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr LJIOPHABNDA;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr DKKNFPGHIEL;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly OALCPCGHNMA KBCDDOOGPEK;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool ACEIOKDFPFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x85CA440", Offset = "0x85C8A40", VA = "0x1885CA440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xC41130", Offset = "0xC3F730", VA = "0x180C41130")]
	public OALCPCGHNMA(IntPtr EJALEJOEOLL, IntPtr FIEJLNDNJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void GMCEOABHDHL(string DJFMCHMDHGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0")]
	private static void DEMDBEGBHDA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x85CA3B0", Offset = "0x85C89B0", VA = "0x1885CA3B0")]
	private static OALCPCGHNMA ACGBGAOJHAB()
	{
		return default(OALCPCGHNMA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct GABHPKIHNKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr EICCLLLDIBH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x13E0130", Offset = "0x13DE730", VA = "0x1813E0130")]
	private GABHPKIHNKA(IntPtr FIEJLNDNJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x85BFE60", Offset = "0x85BE460", VA = "0x1885BFE60")]
	public void CKBKAMMKCLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x85BFD80", Offset = "0x85BE380", VA = "0x1885BFD80")]
	public static GABHPKIHNKA BPFPEFLIIPC(string DJFMCHMDHGK)
	{
		return default(GABHPKIHNKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE2E0", Offset = "0x2AEC8E0", VA = "0x182AEE2E0")]
	public static GABHPKIHNKA BPFPEFLIIPC([In] OALCPCGHNMA BGFNPMKAFGH, string DJFMCHMDHGK)
	{
		return default(GABHPKIHNKA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2AEE600", Offset = "0x2AECC00", VA = "0x182AEE600")]
	public static GABHPKIHNKA BPFPEFLIIPC([In] OALCPCGHNMA BGFNPMKAFGH, Func<string> DJFMCHMDHGK)
	{
		return default(GABHPKIHNKA);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class CLPDEOADBMH : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? PCHBMDDLJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr HNDKBHMCCEN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool IBPCFAHODBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x85BEC60", Offset = "0x85BD260", VA = "0x1885BEC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x85BE710", Offset = "0x85BCD10", VA = "0x1885BE710")]
	public static SHA256 EEPJBIPIECL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x85BEB80", Offset = "0x85BD180", VA = "0x1885BEB80")]
	private static extern int KJHCJAMCOLG();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x85BEBF0", Offset = "0x85BD1F0", VA = "0x1885BEBF0")]
	private static extern IntPtr NFACLNCDEDC();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x85BEB00", Offset = "0x85BD100", VA = "0x1885BEB00")]
	private static extern void JJCIIMGKMCB(IntPtr HNDKBHMCCEN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x85BE980", Offset = "0x85BCF80", VA = "0x1885BE980")]
	private static extern void IOEOPJEIJNN(IntPtr HNDKBHMCCEN, byte[] DAJAOHIJHHL, int EFCGAKGCCGN, int JGGELGGFPJF);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x85BE5E0", Offset = "0x85BCBE0", VA = "0x1885BE5E0")]
	private static extern void BHMMGMLKCPJ(IntPtr HNDKBHMCCEN, byte[] JBDBHHMFMJK);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x85BED50", Offset = "0x85BD350", VA = "0x1885BED50")]
	private CLPDEOADBMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x85BE790", Offset = "0x85BCD90", VA = "0x1885BE790", Slot = "18")]
	protected override void HashCore(byte[] OHHBFAGELLA, int DNKLIHBDDPE, int ILMEJNBCHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x85BE850", Offset = "0x85BCE50", VA = "0x1885BE850", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x85BEA40", Offset = "0x85BD040", VA = "0x1885BEA40", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x85BE680", Offset = "0x85BCC80", VA = "0x1885BE680", Slot = "13")]
	protected override void Dispose(bool PBLLNBJKALP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class JCNLAEJBMLF
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool ODFLIJJHIKP<in TInput, TResult>(TInput EKNLPIEMHNC, [Out] TResult CENCPMGPALN);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class HGAGFGENJDF : LEAIFAPCDML
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class LFLMINHMGMF : KBMACPEMFIF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly LFLMINHMGMF DOBPPELCKJD;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool ALMJMEFJFAC
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x85C7D40", Offset = "0x85C6340", VA = "0x1885C7D40", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x85C7DA0", Offset = "0x85C63A0", VA = "0x1885C7DA0", Slot = "6")]
			public void OnCompleted(Action PKEMBIGMGHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			public void LBEEOLPLCJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public LFLMINHMGMF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly HGAGFGENJDF DOBPPELCKJD;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		private HGAGFGENJDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x85C1110", Offset = "0x85BF710", VA = "0x1885C1110", Slot = "4")]
		public KBMACPEMFIF PMJGCHFEIKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class CIENMDILPNE : LEAIFAPCDML
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class MCPKEIJDNMA : KBMACPEMFIF, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly MCPKEIJDNMA DOBPPELCKJD;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool ALMJMEFJFAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x85C8450", Offset = "0x85C6A50", VA = "0x1885C8450", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x85C8470", Offset = "0x85C6A70", VA = "0x1885C8470", Slot = "6")]
			public void OnCompleted(Action PKEMBIGMGHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA97AC0", Offset = "0xA960C0", VA = "0x180A97AC0", Slot = "5")]
			public void LBEEOLPLCJE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
			public MCPKEIJDNMA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly CIENMDILPNE DOBPPELCKJD;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		private CIENMDILPNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x85BE510", Offset = "0x85BCB10", VA = "0x1885BE510", Slot = "4")]
		public KBMACPEMFIF PMJGCHFEIKP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class LLOBJKPIBDN<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LLOBJKPIBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5236410", Offset = "0x5234A10", VA = "0x185236410")]
		internal void IOCPDEBEBEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PGPJBGHCOEC<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public PGPJBGHCOEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5C6BCD0", Offset = "0x5C6A2D0", VA = "0x185C6BCD0")]
		internal void NEKHLJDOCGB(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct ICHPBPKBLFC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C1B40", Offset = "0x85C0140", VA = "0x1885C1B40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GFJMIBBKGII : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C02D0", Offset = "0x85BE8D0", VA = "0x1885C02D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xAE2D00", Offset = "0xAE1300", VA = "0x180AE2D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct IMBDKKBDEMI<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x525DEA0", Offset = "0x525C4A0", VA = "0x18525DEA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x525E010", Offset = "0x525C610", VA = "0x18525E010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct IFOOEAMIHGE<T> : IAsyncStateMachine where T : notnull
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
		public IDGHEFJHGEI log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<Task<T>, string> logMessageFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5237EA0", Offset = "0x52364A0", VA = "0x185237EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x52382C0", Offset = "0x52368C0", VA = "0x1852382C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct CKJKANHLLIL<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6EC2DE0", Offset = "0x6EC13E0", VA = "0x186EC2DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6EC3220", Offset = "0x6EC1820", VA = "0x186EC3220", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct BLEMKDPNBMP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85BE230", Offset = "0x85BC830", VA = "0x1885BE230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x85BE440", Offset = "0x85BCA40", VA = "0x1885BE440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class IFJKHDMBPFP<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public IFJKHDMBPFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5236410", Offset = "0x5234A10", VA = "0x185236410")]
		internal void LLGFKPJLGAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x52363B0", Offset = "0x52349B0", VA = "0x1852363B0")]
		internal void FOAFADIHFBK(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct HFMDLLMCODM<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public ODFLIJJHIKP<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x50B4A00", Offset = "0x50B3000", VA = "0x1850B4A00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x50B50F0", Offset = "0x50B36F0", VA = "0x1850B50F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct LAFFPGCLIBL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C73D0", Offset = "0x85C59D0", VA = "0x1885C73D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x85C7BD0", Offset = "0x85C61D0", VA = "0x1885C7BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct IJNDFCKMIAC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C24A0", Offset = "0x85C0AA0", VA = "0x1885C24A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x85C29F0", Offset = "0x85C0FF0", VA = "0x1885C29F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct HHFEMIMNJHC<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x50B6890", Offset = "0x50B4E90", VA = "0x1850B6890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x4FEF1B0", Offset = "0x4FED7B0", VA = "0x184FEF1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class LBCIAHMPGDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TaskCompletionSource<GDCHOBJFCMN> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public LBCIAHMPGDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x85C7C30", Offset = "0x85C6230", VA = "0x1885C7C30")]
		internal void BMDEGBKHIOL(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct LLIPPBHPNCP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C80F0", Offset = "0x85C66F0", VA = "0x1885C80F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x85C8370", Offset = "0x85C6970", VA = "0x1885C8370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct LFEBCJOJJBH<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x56DA3A0", Offset = "0x56D89A0", VA = "0x1856DA3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x454D8C0", Offset = "0x454BEC0", VA = "0x18454D8C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct LBFLLHBPGLN<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x56C7470", Offset = "0x56C5A70", VA = "0x1856C7470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x454C970", Offset = "0x454AF70", VA = "0x18454C970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct MCMMHMOAFFK<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x594D220", Offset = "0x594B820", VA = "0x18594D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x594E100", Offset = "0x594C700", VA = "0x18594E100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct ELHBELEJELL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85BF200", Offset = "0x85BD800", VA = "0x1885BF200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x85BF3E0", Offset = "0x85BD9E0", VA = "0x1885BF3E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct AEKCHPKICPP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85BDAB0", Offset = "0x85BC0B0", VA = "0x1885BDAB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x85BDE20", Offset = "0x85BC420", VA = "0x1885BDE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct NIPLMNGICFE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C9FE0", Offset = "0x85C85E0", VA = "0x1885C9FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x85CA2D0", Offset = "0x85C88D0", VA = "0x1885CA2D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class GIFBKHNFHHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public GIFBKHNFHHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x85C0770", Offset = "0x85BED70", VA = "0x1885C0770")]
		internal Task KGJBKACOLFH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct IFBOAEDHOCI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C2160", Offset = "0x85C0760", VA = "0x1885C2160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x85C23C0", Offset = "0x85C09C0", VA = "0x1885C23C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct FJBDLAAOGCE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85BF440", Offset = "0x85BDA40", VA = "0x1885BF440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x85BF620", Offset = "0x85BDC20", VA = "0x1885BF620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct ODBFCMGECPA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85CA670", Offset = "0x85C8C70", VA = "0x1885CA670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x85CA9D0", Offset = "0x85C8FD0", VA = "0x1885CA9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct EBEJCCOHJHJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85BEEB0", Offset = "0x85BD4B0", VA = "0x1885BEEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x85BF1A0", Offset = "0x85BD7A0", VA = "0x1885BF1A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class MBMAEJBCHKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public MBMAEJBCHKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x85C83E0", Offset = "0x85C69E0", VA = "0x1885C83E0")]
		internal Task MDAKMKDLDDF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct IFBEKBDFAPG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C1EA0", Offset = "0x85C04A0", VA = "0x1885C1EA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x85C2100", Offset = "0x85C0700", VA = "0x1885C2100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct BCGEMDAHBCD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85BE000", Offset = "0x85BC600", VA = "0x1885BE000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x85BE180", Offset = "0x85BC780", VA = "0x1885BE180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct BPDLFMCDADL<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x6A26550", Offset = "0x6A24B50", VA = "0x186A26550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6A26A70", Offset = "0x6A25070", VA = "0x186A26A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct GGCJDBFJDAG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C03E0", Offset = "0x85BE9E0", VA = "0x1885C03E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x85C0710", Offset = "0x85BED10", VA = "0x1885C0710", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? LDENIPNINLI;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<GDCHOBJFCMN> HOPIOMBPCAL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task NDBGEFNNFIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x85C3140", Offset = "0x85C1740", VA = "0x1885C3140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x85C39D0", Offset = "0x85C1FD0", VA = "0x1885C39D0")]
	public static bool FCFJKIMPCIH(this Task PIKAFIDPPMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E2E2E0", Offset = "0x3E2C8E0", VA = "0x183E2E2E0")]
	public static Task<T> CKCLDDLJJDF<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x85C4DF0", Offset = "0x85C33F0", VA = "0x1885C4DF0")]
	public static Task OCBPEFOHOHG(this Task PIKAFIDPPMC, CancellationToken HNGIMMGBLII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3E32000", Offset = "0x3E30600", VA = "0x183E32000")]
	public static Task<TResult> OCBPEFOHOHG<TResult>(this Task<TResult> PIKAFIDPPMC, CancellationToken HNGIMMGBLII) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3E2FF80", Offset = "0x3E2E580", VA = "0x183E2FF80")]
	public static TaskCompletionSource<TResult> OCBPEFOHOHG<TResult>(this TaskCompletionSource<TResult> CHMGFJHNNCC, CancellationToken HNGIMMGBLII) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x85C3A00", Offset = "0x85C2000", VA = "0x1885C3A00")]
	public static IDisposable? FKFJGAFCLFG(CancellationToken HBBDPGNHEJE, CancellationToken MMHCAODLIHG, [Out] CancellationToken DOEFAKDDDMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x85C4730", Offset = "0x85C2D30", VA = "0x1885C4730")]
	[AsyncStateMachine(typeof(ICHPBPKBLFC))]
	public static void MJEOIFHAJCG(this Task IHNLGGEEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x85C3420", Offset = "0x85C1A20", VA = "0x1885C3420")]
	[AsyncStateMachine(typeof(GFJMIBBKGII))]
	public static void BFKLAELPKGF(this Task IHNLGGEEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3E2E210", Offset = "0x3E2C810", VA = "0x183E2E210")]
	[AsyncStateMachine(typeof(IMBDKKBDEMI<>))]
	public static Task AHMJDAPEPKN<TException>(this Task IHNLGGEEIFC) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3E2EFB0", Offset = "0x3E2D5B0", VA = "0x183E2EFB0")]
	[AsyncStateMachine(typeof(IFOOEAMIHGE<>))]
	public static Task<T> JBKDLNAJPFH<T>(this Task<T> CCKLBDLJPNG, IDGHEFJHGEI FEFALLLFAGB, Func<Task<T>, string> OINKBOLGIAP, bool NMDFOCJHDAM = false) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E2EDF0", Offset = "0x3E2D3F0", VA = "0x183E2EDF0")]
	[AsyncStateMachine(typeof(CKJKANHLLIL<>))]
	public static Task<T> JBKDLNAJPFH<T>(this Task<T> CCKLBDLJPNG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x85C3C90", Offset = "0x85C2290", VA = "0x1885C3C90")]
	[AsyncStateMachine(typeof(BLEMKDPNBMP))]
	public static Task<TaskStatus> HFAPDFKDMDN(this Task? CCKLBDLJPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3E2E810", Offset = "0x3E2CE10", VA = "0x183E2E810")]
	public static (Task<T?>?, Action<T?>?) DOGJKJMBCPL<T>([Optional] CancellationToken MEKNAIONNND)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3E2F0D0", Offset = "0x3E2D6D0", VA = "0x183E2F0D0")]
	[AsyncStateMachine(typeof(HFMDLLMCODM<, >))]
	public static Task<List<TResult>> MHNMDNPPMOD<TResult, TInput>(this Task<List<TInput>> PIKAFIDPPMC, ODFLIJJHIKP<TInput, TResult> DEMOICLFFAH) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x85C38A0", Offset = "0x85C1EA0", VA = "0x1885C38A0")]
	[AsyncStateMachine(typeof(LAFFPGCLIBL))]
	public static Task DCHHKHIEJDI(Task IHNLGGEEIFC, CancellationToken MMLPHNDIFBG, Func<CancellationToken, Task> OAPMDPAICNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x85C5050", Offset = "0x85C3650", VA = "0x1885C5050")]
	[AsyncStateMachine(typeof(IJNDFCKMIAC))]
	public static Task PCIJAIEPLBG(Func<CancellationToken, Task> PKCOIGPGNAJ, TimeSpan BEJCNBKHBLB, [Optional] CancellationToken MMLPHNDIFBG, [Optional] Action<OperationCanceledException>? LFHDIOEDLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E338B0", Offset = "0x3E31EB0", VA = "0x183E338B0")]
	[AsyncStateMachine(typeof(HHFEMIMNJHC<>))]
	public static Task<T> PCIJAIEPLBG<T>(Func<CancellationToken, Task<T>> PKCOIGPGNAJ, TimeSpan BEJCNBKHBLB, [Optional] CancellationToken MMLPHNDIFBG, [Optional] Func<OperationCanceledException, T>? LFHDIOEDLHI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x85C4CF0", Offset = "0x85C32F0", VA = "0x1885C4CF0")]
	public static Task NMHOEGDOBIM(params Task[] CIMPPALFCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x85C4830", Offset = "0x85C2E30", VA = "0x1885C4830")]
	public static Task NMHOEGDOBIM(IEnumerable<Task> CIMPPALFCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x85C3B90", Offset = "0x85C2190", VA = "0x1885C3B90")]
	[AsyncStateMachine(typeof(LLIPPBHPNCP))]
	public static Task<IEnumerable<Task>> GLPOFCJEHHC(IEnumerable<Task> CIMPPALFCEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3E2EB30", Offset = "0x3E2D130", VA = "0x183E2EB30")]
	[AsyncStateMachine(typeof(LFEBCJOJJBH<>))]
	public static Task<IEnumerable<Task<T>>> GLPOFCJEHHC<T>(IEnumerable<Task<T>> CIMPPALFCEL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3E2E6F0", Offset = "0x3E2CCF0", VA = "0x183E2E6F0")]
	[AsyncStateMachine(typeof(LBFLLHBPGLN<, , >))]
	public static Task<(T1, T2, T3)> CKGOIPPDLKJ<T1, T2, T3>(Task<T1> AAABBFCNNCJ, Task<T2> JNLJMDJCJKD, Task<T3> BNGLBDJFIOB) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3E2E430", Offset = "0x3E2CA30", VA = "0x183E2E430")]
	[AsyncStateMachine(typeof(MCMMHMOAFFK<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> CKGOIPPDLKJ<T1, T2, T3, T4, T5>(Task<T1> AAABBFCNNCJ, Task<T2> JNLJMDJCJKD, Task<T3> BNGLBDJFIOB, Task<T4> KAAGIEOIDBC, Task<T5> ELPAECHHNMI) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x85C5180", Offset = "0x85C3780", VA = "0x1885C5180")]
	[AsyncStateMachine(typeof(ELHBELEJELL))]
	public static Task PHAFHKMIOAO(Func<bool> OEOGIGLGCGF, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x85C5270", Offset = "0x85C3870", VA = "0x1885C5270")]
	[AsyncStateMachine(typeof(AEKCHPKICPP))]
	public static Task PHAFHKMIOAO(Func<bool> OEOGIGLGCGF, TimeSpan EKIDBIALBHG, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x85C31B0", Offset = "0x85C17B0", VA = "0x1885C31B0")]
	[AsyncStateMachine(typeof(NIPLMNGICFE))]
	public static Task AOFFHHMGEEB(Func<bool> OEOGIGLGCGF, TimeSpan BEJCNBKHBLB, [Optional] CancellationToken MEKNAIONNND, [Optional] Action<OperationCanceledException>? LFHDIOEDLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x85C32E0", Offset = "0x85C18E0", VA = "0x1885C32E0")]
	[AsyncStateMachine(typeof(IFBOAEDHOCI))]
	public static Task AOFFHHMGEEB(Func<bool> OEOGIGLGCGF, TimeSpan BEJCNBKHBLB, TimeSpan EKIDBIALBHG, [Optional] CancellationToken MEKNAIONNND, [Optional] Action<OperationCanceledException>? LFHDIOEDLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x85C4380", Offset = "0x85C2980", VA = "0x1885C4380")]
	[AsyncStateMachine(typeof(FJBDLAAOGCE))]
	public static Task JODNNJJMNOP(Func<bool> OEOGIGLGCGF, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x85C4270", Offset = "0x85C2870", VA = "0x1885C4270")]
	[AsyncStateMachine(typeof(ODBFCMGECPA))]
	public static Task JODNNJJMNOP(Func<bool> OEOGIGLGCGF, TimeSpan EKIDBIALBHG, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x85C4000", Offset = "0x85C2600", VA = "0x1885C4000")]
	[AsyncStateMachine(typeof(EBEJCCOHJHJ))]
	public static Task JNINKHPLPOD(Func<bool> OEOGIGLGCGF, TimeSpan BEJCNBKHBLB, [Optional] CancellationToken MEKNAIONNND, [Optional] Action<OperationCanceledException>? LFHDIOEDLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x85C4130", Offset = "0x85C2730", VA = "0x1885C4130")]
	[AsyncStateMachine(typeof(IFBEKBDFAPG))]
	public static Task JNINKHPLPOD(Func<bool> OEOGIGLGCGF, TimeSpan BEJCNBKHBLB, TimeSpan EKIDBIALBHG, [Optional] CancellationToken MEKNAIONNND, [Optional] Action<OperationCanceledException>? LFHDIOEDLHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x85C3F10", Offset = "0x85C2510", VA = "0x1885C3F10")]
	[AsyncStateMachine(typeof(BCGEMDAHBCD))]
	[Obsolete]
	public static Task IMAOHEAGIEB(this Task PIKAFIDPPMC, Action FBDPJOEEIIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3E2EC10", Offset = "0x3E2D210", VA = "0x183E2EC10")]
	[AsyncStateMachine(typeof(BPDLFMCDADL<>))]
	[Obsolete]
	public static Task IMAOHEAGIEB<T>(this Task<T> PIKAFIDPPMC, Action<T> FBDPJOEEIIG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x85C4D40", Offset = "0x85C3340", VA = "0x1885C4D40")]
	private static void NPHKNGLNPLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x85C3520", Offset = "0x85C1B20", VA = "0x1885C3520")]
	public static bool BMNAOLNDCON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x85C3D80", Offset = "0x85C2380", VA = "0x1885C3D80")]
	private static void IDCBKLPDPBK(SynchronizationContext FKMNCAKIOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x85C4470", Offset = "0x85C2A70", VA = "0x1885C4470")]
	private static void KGHGHALOHPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x85C4590", Offset = "0x85C2B90", VA = "0x1885C4590")]
	public static void KOAJIMPHMGE([Optional] string? IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x85C30C0", Offset = "0x85C16C0", VA = "0x1885C30C0")]
	public static void ABCKDAEOJFF([Optional] string? IFEHDCDCFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x85C47E0", Offset = "0x85C2DE0", VA = "0x1885C47E0")]
	public static LEAIFAPCDML MOCJBOFBANK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x85C34D0", Offset = "0x85C1AD0", VA = "0x1885C34D0")]
	public static LEAIFAPCDML BMMDJGKIELG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x85C4660", Offset = "0x85C2C60", VA = "0x1885C4660")]
	[AsyncStateMachine(typeof(GGCJDBFJDAG))]
	public static Task MDDFINGDIAC(Func<Task> MGENEOADHDD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class KALHGBCMMAN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public KALHGBCMMAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class PFPFDBNGLPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x85CAA60", Offset = "0x85C9060", VA = "0x1885CAA60")]
	public static bool INHHDEBEBBH(this NBJJMADLGPF NEAJBOMOKKJ, DateTime JMPONBOLEEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x85CAB80", Offset = "0x85C9180", VA = "0x1885CAB80")]
	public static TimeSpan KEPNEJEODLN(this NBJJMADLGPF NEAJBOMOKKJ, DateTime JMPONBOLEEG)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class MKMICOPBBKB : NBJJMADLGPF
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly NBJJMADLGPF DOBPPELCKJD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime KIJAJHNAKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x85C8E70", Offset = "0x85C7470", VA = "0x1885C8E70", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset JDBMCFILILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x85C8EB0", Offset = "0x85C74B0", VA = "0x1885C8EB0", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
	public MKMICOPBBKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface NBJJMADLGPF
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime KIJAJHNAKJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset JDBMCFILILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class MFCAFCMJHFI
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long FIPIBFNLKKI
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x85C87E0", Offset = "0x85C6DE0", VA = "0x1885C87E0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long DJIPPHPACJH
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x85C8A40", Offset = "0x85C7040", VA = "0x1885C8A40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double PBKJPMBACJH
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x85C85D0", Offset = "0x85C6BD0", VA = "0x1885C85D0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double PILHCGPIEOC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x85C8740", Offset = "0x85C6D40", VA = "0x1885C8740")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double JJDHDIFPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x85C8990", Offset = "0x85C6F90", VA = "0x1885C8990")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double NPPEKMBEJOO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85C8790", Offset = "0x85C6D90", VA = "0x1885C8790")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x85C8540", Offset = "0x85C6B40", VA = "0x1885C8540")]
	public static double AIGBCFJGPAC(long KCLFDGBMEKG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x85C8620", Offset = "0x85C6C20", VA = "0x1885C8620")]
	public static double CMLEGFNLBLC(long KCLFDGBMEKG)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x85C8830", Offset = "0x85C6E30", VA = "0x1885C8830")]
	public static double KALLIDCHBMI(double OLHLMKNFJJF)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x85C86B0", Offset = "0x85C6CB0", VA = "0x1885C86B0")]
	public static long CPDGKDLFMGD(long AEKHJIAHDFD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x85C8A90", Offset = "0x85C7090", VA = "0x1885C8A90")]
	public static long NKNOHNDJEHL(long MHOLEHAGBFN, long KCIPAOHBDFO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x85C88C0", Offset = "0x85C6EC0", VA = "0x1885C88C0")]
	public static double KOKAIPGKIAN(long MHOLEHAGBFN, long KCIPAOHBDFO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x85C89E0", Offset = "0x85C6FE0", VA = "0x1885C89E0")]
	public static double LLNBGJPOKLK(long MHOLEHAGBFN, long KCIPAOHBDFO)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class FKOEBNKGNII : EEJEGNJBENC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly TimeSpan BDJPENGDMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly System.Timers.Timer AGEIHALJKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private TimeSpan BEJCNBKHBLB;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan OJDNAFOKNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99190", VA = "0x180A9AB90", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x85BF8C0", Offset = "0x85BDEC0", VA = "0x1885BF8C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? DFAHJONMABI
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA94FB0", Offset = "0xA935B0", VA = "0x180A94FB0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA94DB0", Offset = "0xA933B0", VA = "0x180A94DB0", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x85BFD10", Offset = "0x85BE310", VA = "0x1885BFD10")]
	[Preserve]
	public FKOEBNKGNII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x85BFAC0", Offset = "0x85BE0C0", VA = "0x1885BFAC0")]
	public FKOEBNKGNII(TimeSpan BEJCNBKHBLB, [Optional] Action? MBJMEABMIKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x85BF830", Offset = "0x85BDE30", VA = "0x1885BF830", Slot = "7")]
	public void JKGHENBEODP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x85BF7C0", Offset = "0x85BDDC0", VA = "0x1885BF7C0", Slot = "8")]
	public void JHLIKPJFFME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x85BFA20", Offset = "0x85BE020", VA = "0x1885BFA20", Slot = "9")]
	public void MNEFMGBPPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x13194B0", Offset = "0x1317AB0", VA = "0x1813194B0")]
	private void CNGBNEJOAAH(object CGLIDCMIAEF, ElapsedEventArgs FEMMKOBPFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x85BF720", Offset = "0x85BDD20", VA = "0x1885BF720")]
	private static void IFGPOJBGLDJ(TimeSpan KIDALIDBGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x85BF680", Offset = "0x85BDC80", VA = "0x1885BF680", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class BHJILBNHLDI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly string? MKNFAJBBNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string ACHJJIPNFFG;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1987520", Offset = "0x1985B20", VA = "0x181987520")]
	public BHJILBNHLDI(string OINDFPIKPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x567B110", Offset = "0x5679710", VA = "0x18567B110")]
	public BHJILBNHLDI(string BBLDJOHEJKC, string OINDFPIKPLL)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct NCIHCFDNMCG : IEquatable<NCIHCFDNMCG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public uint GDGPHKABHMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int CHFMGIDKMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float LPFAKLCABGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public ushort CHLIEJNKMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort KKHNHKDACHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public short HMNAILGLJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public short HJJOGJIOAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public char NEHJEEFNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public char FOHHIDFPNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public byte LBFGPBCKLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public byte PNBINCJGHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public byte KPKLOHDABPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public byte OIAPNODLINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool KGFPJOKHLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool KDCKIKOAMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool POFBNLCABOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool LBEOBKFHGFA;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x217FD40", Offset = "0x217E340", VA = "0x18217FD40")]
	public static NCIHCFDNMCG KFBPOKGJFPC(uint NACAMDBCBOG)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x217FD40", Offset = "0x217E340", VA = "0x18217FD40")]
	public static NCIHCFDNMCG JFKCJGLECDL(int KFIPCFMANMO)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x85C9040", Offset = "0x85C7640", VA = "0x1885C9040")]
	public static NCIHCFDNMCG NHFLBFNDNLP(float FANJIAPAGMI)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x85C8F90", Offset = "0x85C7590", VA = "0x1885C8F90")]
	public static NCIHCFDNMCG PEIJFIPMBKH(byte DAMNJKOCDMI, byte INLFKCKPOCG, byte KKKFNLMJPHP, byte KCEOFDPDCPG)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x85C8F90", Offset = "0x85C7590", VA = "0x1885C8F90")]
	public static NCIHCFDNMCG AIPKANFAGPL(bool PFBPKGMJDFE, bool LDKLGBELLKD, bool MMGMOCEMLKC, bool LFMDMNIBLIM)
	{
		return default(NCIHCFDNMCG);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x85C8F90", Offset = "0x85C7590", VA = "0x1885C8F90")]
	public static NCIHCFDNMCG DOFMEGEKFPH(byte IMOHPMMDEOI, byte AKACPFAPMOI, byte OJEKAEEHOPO, byte HDDJPFCLKHA)
	{
		return default(NCIHCFDNMCG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x24C4F00", Offset = "0x24C3500", VA = "0x1824C4F00")]
	public static bool LMIMJGGKHMP(NCIHCFDNMCG KNPHEACNGDK, NCIHCFDNMCG IMDBLBCMEAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x24C4E00", Offset = "0x24C3400", VA = "0x1824C4E00", Slot = "4")]
	public bool Equals(NCIHCFDNMCG IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x85C8FB0", Offset = "0x85C75B0", VA = "0x1885C8FB0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x15B33F0", Offset = "0x15B19F0", VA = "0x1815B33F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x85C9050", Offset = "0x85C7650", VA = "0x1885C9050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct BFDDAGMFHBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public ulong IIMHOACMKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public long EJGFILHIANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public double GCPLDFONAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public uint FLNFBNKBKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public uint DPBJACFMICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int FLLAJHJADHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int JIBECHHBFCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public float IGHDPJGLOPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public float HCCEBLCOAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public ushort CHLIEJNKMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public ushort KKHNHKDACHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public ushort KABHNNHJANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public ushort HBDGPDPBFPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public short HMNAILGLJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public short HJJOGJIOAGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public short CMOJGFGJHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public short BOJCOPNLCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public char NEHJEEFNLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public char FOHHIDFPNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public char LBGELJCAOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public char APKCMOLLKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte LBFGPBCKLCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte PNBINCJGHFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public byte KPKLOHDABPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public byte OIAPNODLINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public byte FALBGHCKLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public byte NEDJGCDFMFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public byte CBNCEBBDGLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public byte LCEKACFIPDE;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static BFDDAGMFHBH BPFPEFLIIPC(long IFOEAHKOJLG)
	{
		return default(BFDDAGMFHBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x85BE1E0", Offset = "0x85BC7E0", VA = "0x1885BE1E0")]
	public static BFDDAGMFHBH BPFPEFLIIPC(byte DAMNJKOCDMI, byte INLFKCKPOCG, byte KKKFNLMJPHP, byte KCEOFDPDCPG, byte BELJGEODMPP, byte EFFIAIPDEOC, byte GMLCAGEBKFF, byte HEPKMBIIGAM)
	{
		return default(BFDDAGMFHBH);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct KKIPCMDLAAC : IEquatable<KKIPCMDLAAC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public byte OABAAJAEFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public bool OKBJFEGDNIO;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x322CA00", Offset = "0x322B000", VA = "0x18322CA00")]
	public static KKIPCMDLAAC PEIJFIPMBKH(byte ABECEKONMBI)
	{
		return default(KKIPCMDLAAC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x322CA00", Offset = "0x322B000", VA = "0x18322CA00")]
	public static KKIPCMDLAAC AIPKANFAGPL(bool GDDAEPLINAK)
	{
		return default(KKIPCMDLAAC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x85C7150", Offset = "0x85C5750", VA = "0x1885C7150")]
	public static bool LMIMJGGKHMP(KKIPCMDLAAC KNPHEACNGDK, KKIPCMDLAAC IMDBLBCMEAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x745C220", Offset = "0x745A820", VA = "0x18745C220", Slot = "4")]
	public bool Equals(KKIPCMDLAAC IBCMCOKAJEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x85C70B0", Offset = "0x85C56B0", VA = "0x1885C70B0", Slot = "0")]
	public override bool Equals(object NDBJJGOPOFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x85C7140", Offset = "0x85C5740", VA = "0x1885C7140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x85C7160", Offset = "0x85C5760", VA = "0x1885C7160", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class DCHEDKGHEHJ<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly T NEMBOKFNCIJ;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x459ECF0", Offset = "0x459D2F0", VA = "0x18459ECF0")]
	public DCHEDKGHEHJ(T CMDCKOHJHBH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class PBOKHLCDBKI
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3E8AF50", Offset = "0x3E89550", VA = "0x183E8AF50")]
	public static IEnumerable<T> ILHBHGNMJEH<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static T[] HPHELIEACLI<T>(params T[] NAHCPLHIFCO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xE0C5B0", Offset = "0xE0ABB0", VA = "0x180E0C5B0")]
	public static IEnumerable<T> ADKEFBDHHEG<T>(params T[] NAHCPLHIFCO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8630", Offset = "0x3BD6C30", VA = "0x183BD8630")]
	public static HashSet<T> PJKELOMLJJJ<T>(params T[] NAHCPLHIFCO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3F680F0", Offset = "0x3F666F0", VA = "0x183F680F0")]
	public static KeyValuePair<TKey, TValue> AHMONKJMJOC<TKey, TValue>([In] TKey HFLDIIIPBCG, [In] TValue FKMNCAKIOFK) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3BD8630", Offset = "0x3BD6C30", VA = "0x183BD8630")]
	public static List<T> NGPJLAGDHPH<T>(IEnumerable<T> HLOMEJLEMOF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[AttributeUsage(AttributeTargets.All)]
public sealed class CCBNCKLFKLD : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string HFNGJHEJFKL;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xAC0AA0", Offset = "0xABF0A0", VA = "0x180AC0AA0")]
	public CCBNCKLFKLD(string IKOPHEOIONA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object KCNEOAAJAIK<T>([In] T KGIPMLMDBBA);
[Cpp2IlInjected.Token(Token = "0x2000069")]
public delegate object HPFCFOLIJFH<T>(T KGIPMLMDBBA);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[BKCJPPCFFFH]
public delegate string MKHCCOMHLNI(string IAKFGDELOKN, string? KOHOAAFOHKL, bool PFGJFPKJCOK);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[BKCJPPCFFFH]
public delegate void COPKBMBABLK(string IFEHDCDCFPK);
[Cpp2IlInjected.Token(Token = "0x200006C")]
[BKCJPPCFFFH]
public delegate void HBHFMGKLIKA(Exception JLPOJCLEBPP);
[Cpp2IlInjected.Token(Token = "0x200006D")]
public delegate object ONPPLFBJMMN();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[BKCJPPCFFFH]
public delegate bool LNNGPDJMJGH();
[Cpp2IlInjected.Token(Token = "0x200006F")]
[BKCJPPCFFFH]
public delegate string OGAEPJNCNDM(object NDBJJGOPOFO);
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AttributeUsage(AttributeTargets.Enum)]
public class PEGABGJFDGN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xABFAB0", Offset = "0xABE0B0", VA = "0x180ABFAB0")]
	public PEGABGJFDGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class IMOLJKIPAJE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct HNDFMCCMMGA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x85C11E0", Offset = "0x85BF7E0", VA = "0x1885C11E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x85C1AD0", Offset = "0x85C00D0", VA = "0x1885C1AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly TimerCallback AGCOLIHNKFJ;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly Action<object?> BICGDJMEACP;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x85C2AE0", Offset = "0x85C10E0", VA = "0x1885C2AE0")]
	public static Task<bool> HIOIOJIACKC(int JMHCKFABLGO, [Optional] CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x85C2DF0", Offset = "0x85C13F0", VA = "0x1885C2DF0")]
	[AsyncStateMachine(typeof(HNDFMCCMMGA))]
	private static Task<bool> NMNPDFHIKDK(int JMHCKFABLGO, CancellationToken MEKNAIONNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x85C2F20", Offset = "0x85C1520", VA = "0x1885C2F20")]
	private static void OOILCKLECLI(object? BJGEPEKIJPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x85C2A50", Offset = "0x85C1050", VA = "0x1885C2A50")]
	private static void GENNGDPEAFM(object? BJGEPEKIJPC)
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
