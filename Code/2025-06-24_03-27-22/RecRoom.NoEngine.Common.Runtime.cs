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
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F2B7A0", Offset = "0x7F2A3A0", VA = "0x187F2B7A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
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
		[Cpp2IlInjected.Address(RVA = "0xA48890", Offset = "0xA47490", VA = "0x180A48890")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HGJDENFMNCL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7F23D20", Offset = "0x7F22920", VA = "0x187F23D20")]
	public static string JIKNCHCLKGE(this Encoding FOBGCAJBHNG, [In] ReadOnlySequence<byte> OEOOBGJGDIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3AB1740", Offset = "0x3AB0340", VA = "0x183AB1740")]
	private static void OCOHDIMIEJM<T>(this ReadOnlySequence<T> HOAJPHOCGDM, [Out] ReadOnlySpan<T> NJMEDLHENML, [Out] SequencePosition HOHHCCFFPGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class CNEPDABBEFD : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7F21020", Offset = "0x7F1FC20", VA = "0x187F21020")]
	public CNEPDABBEFD(bool CPFLGGPDLGO, string BOHBANGFLBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7F210F0", Offset = "0x7F1FCF0", VA = "0x187F210F0")]
	public CNEPDABBEFD(bool CPFLGGPDLGO, params string[] FKNHOLPKNGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OAKNOOLFBGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LFLFLPMEJPK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AAJAOLOJIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IKIIJJNNAJF(string MEPFFFGIFGB, double OOHGFGHCOAJ, [Optional] string? KLKFBFAPBBF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LJIOGGLDENE : OJKKEFEDAIK, DDCBIKNOOEN, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int OKNAIPFFKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> IPODNOMKJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double PNMBBJAACMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double LMOAHCJOHNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double OMIDDFGKKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int OLCFPDOFEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double PNCCPEAOPEM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int GCHGGNGOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B560", Offset = "0xA3A160", VA = "0x180A3B560")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double MFBCKEFPOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A070", Offset = "0x7F28C70", VA = "0x187F2A070", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double ABIKOLPCPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x51FE9B0", Offset = "0x51FD5B0", VA = "0x1851FE9B0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double GNACIELENFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2896E30", Offset = "0x2895A30", VA = "0x182896E30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A140", Offset = "0x7F28D40", VA = "0x187F2A140")]
	public LJIOGGLDENE(int CKDLPHPFEHA, double PNCCPEAOPEM = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7F29E40", Offset = "0x7F28A40", VA = "0x187F29E40", Slot = "7")]
	public void ALHMGGAFJMP(double AGKJLFOJIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A0D0", Offset = "0x7F28CD0", VA = "0x187F2A0D0", Slot = "8")]
	public void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7F29F70", Offset = "0x7F28B70", VA = "0x187F29F70", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class CIANNNKMMKD : OJKKEFEDAIK, DDCBIKNOOEN, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long DPOOEAFKIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double LIDGKNMFPLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double INNPCDGKLOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double KFGLJJGHAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double GGEAPAENLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double PNMBBJAACMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double LMOAHCJOHNJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long OJAJOFHLGMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double ABIKOLPCPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x715F170", Offset = "0x715DD70", VA = "0x18715F170", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double GNACIELENFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x715F1F0", Offset = "0x715DDF0", VA = "0x18715F1F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double GGCINJIKBBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x715F1C0", Offset = "0x715DDC0", VA = "0x18715F1C0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double MFBCKEFPOEH
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2FFAF20", Offset = "0x2FF9B20", VA = "0x182FFAF20", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7F20E20", Offset = "0x7F1FA20", VA = "0x187F20E20", Slot = "10")]
	public virtual void ALHMGGAFJMP(double AGKJLFOJIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7F20FB0", Offset = "0x7F1FBB0", VA = "0x187F20FB0", Slot = "11")]
	public virtual void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7F20F40", Offset = "0x7F1FB40", VA = "0x187F20F40", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7F20FF0", Offset = "0x7F1FBF0", VA = "0x187F20FF0")]
	public CIANNNKMMKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class HDOFLMOKDMF : CIANNNKMMKD
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double ONIJIIECLKE
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x715F660", Offset = "0x715E260", VA = "0x18715F660")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x715F200", Offset = "0x715DE00", VA = "0x18715F200")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7F23BB0", Offset = "0x7F227B0", VA = "0x187F23BB0", Slot = "10")]
	public override void ALHMGGAFJMP(double AGKJLFOJIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7F23CE0", Offset = "0x7F228E0", VA = "0x187F23CE0", Slot = "11")]
	public override void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7F20FF0", Offset = "0x7F1FBF0", VA = "0x187F20FF0")]
	public HDOFLMOKDMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OJKKEFEDAIK : DDCBIKNOOEN, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double MFBCKEFPOEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double ABIKOLPCPLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double GNACIELENFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BIBDLCCADGB : DDCBIKNOOEN, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double NHADKPDJBEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double AJEJNOAFEEN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7F20430", Offset = "0x7F1F030", VA = "0x187F20430")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BB9170", Offset = "0x6BB7D70", VA = "0x186BB9170", Slot = "4")]
	public void ALHMGGAFJMP(double AGKJLFOJIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7F20440", Offset = "0x7F1F040", VA = "0x187F20440", Slot = "5")]
	public void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F203E0", Offset = "0x7F1EFE0", VA = "0x187F203E0", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public BIBDLCCADGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DDCBIKNOOEN : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ALHMGGAFJMP(double AGKJLFOJIKC);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NFHAHJGCAOH();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MLOPDABAOEI : DDCBIKNOOEN, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double OOHGFGHCOAJ;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double IOOEMCNJEAH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x47B9090", Offset = "0x47B7C90", VA = "0x1847B9090")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x550B720", Offset = "0x550A320", VA = "0x18550B720", Slot = "4")]
	public void ALHMGGAFJMP(double AGKJLFOJIKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A3B0", Offset = "0x7F28FB0", VA = "0x187F2A3B0", Slot = "5")]
	public void NFHAHJGCAOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A360", Offset = "0x7F28F60", VA = "0x187F2A360", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public MLOPDABAOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FPGKCLEHBAK<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> NKGGPAHJPDH(CancellationToken DKKNFNCKCEB);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct FDNMGGKEPGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public FPGKCLEHBAK<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NKGGPAHJPDH taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4BEB850", Offset = "0x4BEA450", VA = "0x184BEB850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4BEC780", Offset = "0x4BEB380", VA = "0x184BEC780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource MIJBGGNKLIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? PJALCGHCDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? HGEDFHHIAPI;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4C5B8B0", Offset = "0x4C5A4B0", VA = "0x184C5B8B0")]
	[AsyncStateMachine(typeof(FPGKCLEHBAK<>.FDNMGGKEPGC))]
	public Task<TResult> MHCPBDMBNFN(NKGGPAHJPDH PLKDKAIGLME, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4C5B840", Offset = "0x4C5A440", VA = "0x184C5B840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4C5B9E0", Offset = "0x4C5A5E0", VA = "0x184C5B9E0")]
	public FPGKCLEHBAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class FNLGOJEPIOB<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> BOIGDIKLFBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T IOOEMCNJEAH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4C21A70", Offset = "0x4C20670", VA = "0x184C21A70")]
	public FNLGOJEPIOB([In] T OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4C20E70", Offset = "0x4C1FA70", VA = "0x184C20E70", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4C213B0", Offset = "0x4C1FFB0", VA = "0x184C213B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4C214C0", Offset = "0x4C200C0", VA = "0x184C214C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class NMJIJPJFDAI
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3834190", Offset = "0x3832D90", VA = "0x183834190")]
	public static FNLGOJEPIOB<T> JHMOIFLKJAD<T>([In] T OOHGFGHCOAJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class APBMBHLAIAC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FBB0", Offset = "0x7F1E7B0", VA = "0x187F1FBB0")]
	public static void EDFOBANCMPL(this CancellationTokenSource MIJBGGNKLIG, bool NEFGDEEMGNI = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class CIGHNBJCJJN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
	public CIGHNBJCJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class PBCDFBCKEKM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
	public PBCDFBCKEKM(string MJDNFBDBMPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class HMHMCIBNEPP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB930", Offset = "0x3ABA530", VA = "0x183ABB930")]
	public static GDHLEEMMDMO KPEBHEFKCKP<T>()
	{
		return default(GDHLEEMMDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7F26590", Offset = "0x7F25190", VA = "0x187F26590")]
	public static GDHLEEMMDMO FFPNGGBNNOJ([CallerMemberName] string LAOCJKNALFF = "")
	{
		return default(GDHLEEMMDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBB80", Offset = "0x3ABA780", VA = "0x183ABBB80")]
	public static GDHLEEMMDMO LIODEMIKFOE<T>([CallerMemberName] string LAOCJKNALFF = "") where T : notnull
	{
		return default(GDHLEEMMDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB8B0", Offset = "0x3ABA4B0", VA = "0x183ABB8B0")]
	public static GDHLEEMMDMO KPEBHEFKCKP<T>(this T NGGJJFKLDLG) where T : notnull
	{
		return default(GDHLEEMMDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB760", Offset = "0x3ABA360", VA = "0x183ABB760")]
	public static GDHLEEMMDMO FFPNGGBNNOJ<T>(this T NGGJJFKLDLG, [CallerMemberName] string LAOCJKNALFF = "") where T : notnull
	{
		return default(GDHLEEMMDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3ABBAE0", Offset = "0x3ABA6E0", VA = "0x183ABBAE0")]
	public static GDHLEEMMDMO LIODEMIKFOE<T>(this T LAAPKLDJLPE, [CallerMemberName] string LAOCJKNALFF = "") where T : notnull
	{
		return default(GDHLEEMMDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7F265F0", Offset = "0x7F251F0", VA = "0x187F265F0")]
	public static GDHLEEMMDMO LIODEMIKFOE(string ECDCEBCHIFL, [CallerMemberName] string LAOCJKNALFF = "")
	{
		return default(GDHLEEMMDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7F264F0", Offset = "0x7F250F0", VA = "0x187F264F0")]
	public static string BDNKNJMKGBP(this object LAAPKLDJLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool JJKNJPFIGMB();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[CIGHNBJCJJN]
public delegate long MHGICKABONP();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class APBIJGMOPOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly APBIJGMOPOK LBPNLDGACAA;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public APBIJGMOPOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JNLHEJEEKHM
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static ICMNCHANICE HPAJOBEALGC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static ICMNCHANICE NMHGBJKAHNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7F289B0", Offset = "0x7F275B0", VA = "0x187F289B0")]
		get
		{
			return default(ICMNCHANICE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static NAMBDIICIDA GBANKFHGNLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7F28360", Offset = "0x7F26F60", VA = "0x187F28360")]
		get
		{
			return default(NAMBDIICIDA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static LINBPNIFKCD DELNMNLBFNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7F28760", Offset = "0x7F27360", VA = "0x187F28760")]
		get
		{
			return default(LINBPNIFKCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool ICABHLKDCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7F28880", Offset = "0x7F27480", VA = "0x187F28880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7F285C0", Offset = "0x7F271C0", VA = "0x187F285C0")]
	public static void HCKCAPLECDC([In] ICMNCHANICE CDHFFGDHOOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7F287B0", Offset = "0x7F273B0", VA = "0x187F287B0")]
	public static void HOEGMFFOKBK(string FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x7F283B0", Offset = "0x7F26FB0", VA = "0x187F283B0")]
	public static void BOJGMFDJNPA(string FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3B35F50", Offset = "0x3B34B50", VA = "0x183B35F50")]
	public static void BOJGMFDJNPA<T>(T NOONBIFJDPN, PGPMPCPIKND<T> FNFIPKNHEOF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7F28480", Offset = "0x7F27080", VA = "0x187F28480")]
	public static void DNGIDHMJBAO(Exception DFLKFAIHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7F288F0", Offset = "0x7F274F0", VA = "0x187F288F0")]
	public static void KLOJDBOCKHE(string LAOCJKNALFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7F28950", Offset = "0x7F27550", VA = "0x187F28950")]
	public static void LEMKGCKAKJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7F282F0", Offset = "0x7F26EF0", VA = "0x187F282F0")]
	public static string BDNKNJMKGBP(object KDKJDFFGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7F281B0", Offset = "0x7F26DB0", VA = "0x187F281B0")]
	public static long AHEHFJMALNJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7F28520", Offset = "0x7F27120", VA = "0x187F28520")]
	public static bool EBMEMKHCFPC(bool JIMAJCFJLFE, string FNFIPKNHEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7F28220", Offset = "0x7F26E20", VA = "0x187F28220")]
	public static double BBIAHLFEPBB()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct ICMNCHANICE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly NAMBDIICIDA GBANKFHGNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly LINBPNIFKCD DELNMNLBFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly BEGPDAALGKG IHOEHEAAIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly MHGICKABONP OLKPLAELFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly BOFEAALMHKM KPLDELKIJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly JJKNJPFIGMB EHOIDLGBICG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly BEGPDAALGKG JFKMNMCDCOO;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly MHGICKABONP LMCONPPKLFG;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly BOFEAALMHKM LFDNLGELNOD;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly JJKNJPFIGMB ONMMKMGELDD;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly ICMNCHANICE LELJIFADAHI;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool PNOGDJAFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7F26F00", Offset = "0x7F25B00", VA = "0x187F26F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F27850", Offset = "0x7F26450", VA = "0x187F27850")]
	public ICMNCHANICE([In] NAMBDIICIDA KKJGIHODDME, [In] LINBPNIFKCD OFJEJBGPEDF, BEGPDAALGKG PMEDCJALHFB, MHGICKABONP DEGLHBHBDLD, BOFEAALMHKM DLFCHCGNMPO, JJKNJPFIGMB NGDOPAFBOJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7F26EC0", Offset = "0x7F25AC0", VA = "0x187F26EC0")]
	private static string CKKDFCEOBMD(object KDKJDFFGNJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE90", Offset = "0xA1CA90", VA = "0x180A1DE90")]
	private static long LDMIGCCNJAG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	private static string FKOFIEKAAMI(string KMCLKBGAPBL, string? BGBBINOABDF, bool DNCLOJOLBAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	private static bool NOHMELGDBKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7F27090", Offset = "0x7F25C90", VA = "0x187F27090")]
	private static ICMNCHANICE IMGDCIJGLFP()
	{
		return default(ICMNCHANICE);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface OKHIIGNFPLG
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FGPNLEOAOJB LCIABKLGBLO();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FGPNLEOAOJB : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool GHBNADMNCLG
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOPJECOALEL();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JFKHBKEEEFC<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKFPOCCPKFE([In] T GMNGNCHKEBK);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void OOLKLMMMDGI<T>([In] T NOONBIFJDPN);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct CNFNHDKIAIK<T> : IEquatable<CNFNHDKIAIK<T>>, JFKHBKEEEFC<CNFNHDKIAIK<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T IOOEMCNJEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int FCJKCAOMEFN;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6999B90", Offset = "0x6998790", VA = "0x186999B90")]
	public CNFNHDKIAIK([In] T OOHGFGHCOAJ, int EMMACFPOKFB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69990F0", Offset = "0x6997CF0", VA = "0x1869990F0")]
	public static bool JOHLOKGLNML([In] CNFNHDKIAIK<T> NAHMIIJKKEL, [In] CNFNHDKIAIK<T> IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6487220", Offset = "0x6485E20", VA = "0x186487220", Slot = "4")]
	public bool Equals(CNFNHDKIAIK<T> GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4B7B3D0", Offset = "0x4B79FD0", VA = "0x184B7B3D0", Slot = "0")]
	public override bool Equals(object GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69981D0", Offset = "0x6996DD0", VA = "0x1869981D0")]
	public bool CKFPOCCPKFE([In] CNFNHDKIAIK<T> GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6998430", Offset = "0x6997030", VA = "0x186998430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69997C0", Offset = "0x69983C0", VA = "0x1869997C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6998130", Offset = "0x6996D30", VA = "0x186998130")]
	public void AMHBPBGIPFF([Out] T OOHGFGHCOAJ, [Out] int EMMACFPOKFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69988B0", Offset = "0x69974B0", VA = "0x1869988B0")]
	public (T, int) HHGJNLGKPLP()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6998C50", Offset = "0x6997850", VA = "0x186998C50", Slot = "5")]
	private bool IFCGHCEPJJL([In] CNFNHDKIAIK<T> GMNGNCHKEBK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class ONGKHGFGHGD
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3C77E00", Offset = "0x3C76A00", VA = "0x183C77E00")]
	public static CNFNHDKIAIK<T> JHMOIFLKJAD<T>([In] T OOHGFGHCOAJ, int EMMACFPOKFB) where T : notnull
	{
		return default(CNFNHDKIAIK<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class HNJNPBAJFDE
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x3ABC420", Offset = "0x3ABB020", VA = "0x183ABC420")]
	public static bool CKFPOCCPKFE<T, U>([In] T LAAPKLDJLPE, [In] U KDKJDFFGNJJ) where T : notnull, JFKHBKEEEFC<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult NJOOJDPELKA<T, out TResult>([In] T NOONBIFJDPN);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface CJENPGOKKKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan COENNDCPEIE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? IMMCNFHKOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KDHJHGHKFGC();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EDKOEELMPHP();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DABNHEKODGF();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct NAMBDIICIDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly AEIAPIBNMKC CMDGJMMPFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly IIOAGFHECKA ODKGJIEDEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly AEIAPIBNMKC GGBGPGDFBAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly IIOAGFHECKA BBEJIEEKKMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly AEIAPIBNMKC HMCACGDIBLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly IIOAGFHECKA FLNKECBBKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly OLEMFJBEDMA NBABGAIDPOD;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly AEIAPIBNMKC HCIBNAEPECA;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly IIOAGFHECKA ACMABBGLGMD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly AEIAPIBNMKC GDMDBLHEILN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly IIOAGFHECKA AGPCJFJGIIP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly AEIAPIBNMKC ONFNKBIEDBH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly IIOAGFHECKA MBIKFPAGALK;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly OLEMFJBEDMA OLNNINBIICK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly NAMBDIICIDA LELJIFADAHI;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly AEIAPIBNMKC KPJLPCNBBGO;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PNOGDJAFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7F2AB80", Offset = "0x7F29780", VA = "0x187F2AB80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xE18D10", Offset = "0xE17910", VA = "0x180E18D10")]
	public NAMBDIICIDA(AEIAPIBNMKC CKHMGDKNCCB, IIOAGFHECKA PDACGFMJELB, AEIAPIBNMKC KMHOHIHONKI, IIOAGFHECKA AKMDDMIOBLH, AEIAPIBNMKC PLBEBKHOJBP, IIOAGFHECKA KOJDGPAPMEA, OLEMFJBEDMA HPPIDEOHKIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	private static bool KCHMCOFCONB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void GKKBPLBKHLI(string FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	private static bool EOOMFPFPJHK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void HCFJPKGPLBO(string FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xA689A0", Offset = "0xA675A0", VA = "0x180A689A0")]
	private static bool JKPDEPOOEKL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void CCGIECEADNC(string FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void JPMMNLHLGMA(Exception DFLKFAIHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x7F2ADD0", Offset = "0x7F299D0", VA = "0x187F2ADD0")]
	private static NAMBDIICIDA IMGDCIJGLFP()
	{
		return default(NAMBDIICIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390")]
	private static bool KMPAJLCMALN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7F2AD60", Offset = "0x7F29960", VA = "0x187F2AD60")]
	public void HOEGMFFOKBK(object FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A8F0", Offset = "0x7F294F0", VA = "0x187F2A8F0")]
	public void AJGHABDGLHA(object FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A960", Offset = "0x7F29560", VA = "0x187F2A960")]
	public void BOJGMFDJNPA(object FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE14A60", Offset = "0xE13660", VA = "0x180E14A60")]
	public void DNGIDHMJBAO(Exception DFLKFAIHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x7F2A9D0", Offset = "0x7F295D0", VA = "0x187F2A9D0")]
	public void BOJGMFDJNPA(HAAPAJEFIGM FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3C14F60", Offset = "0x3C13B60", VA = "0x183C14F60")]
	public void BOJGMFDJNPA<T>(T NOONBIFJDPN, PGPMPCPIKND<T> FNFIPKNHEOF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3C15020", Offset = "0x3C13C20", VA = "0x183C15020")]
	public void HOEGMFFOKBK<T>([In] T NOONBIFJDPN, EMFGKBALFMA<T> FNFIPKNHEOF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C14D10", Offset = "0x3C13910", VA = "0x183C14D10")]
	public void BOJGMFDJNPA<T>([In] T NOONBIFJDPN, EMFGKBALFMA<T> FNFIPKNHEOF) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F2AAB0", Offset = "0x7F296B0", VA = "0x187F2AAB0")]
	public bool EBMEMKHCFPC(bool JIMAJCFJLFE, string FNFIPKNHEOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct GDHLEEMMDMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string IOOEMCNJEAH;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xDCEEA0", Offset = "0xDCDAA0", VA = "0x180DCEEA0")]
	public GDHLEEMMDMO(string OOHGFGHCOAJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520")]
	public static string GHOKLFELACP([In] GDHLEEMMDMO LAAPKLDJLPE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x13442A0", Offset = "0x1342EA0", VA = "0x1813442A0")]
	public static GDHLEEMMDMO GHOKLFELACP(string GMNGNCHKEBK)
	{
		return default(GDHLEEMMDMO);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7F23080", Offset = "0x7F21C80", VA = "0x187F23080")]
	public string LODCILNHPLM(string KLPPFCFOKMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7F22FA0", Offset = "0x7F21BA0", VA = "0x187F22FA0")]
	public string JAMEGBCFNAG(object DOFDMOHKNMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA8A520", Offset = "0xA89120", VA = "0x180A8A520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class LHPJEGGMPCF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
	public LHPJEGGMPCF()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct BOFEABKGBFC : IEquatable<BOFEABKGBFC>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "4")]
	public bool Equals(BOFEABKGBFC GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F20790", Offset = "0x7F1F390", VA = "0x187F20790", Slot = "0")]
	public override bool Equals(object GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7F207E0", Offset = "0x7F1F3E0", VA = "0x187F207E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7F207F0", Offset = "0x7F1F3F0", VA = "0x187F207F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[MHCDBJJGKDE("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct MFCBKIOLAIJ<T> : IEquatable<MFCBKIOLAIJ<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T IOOEMCNJEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool AMEJNCIANNK;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool EEMJNGJKLDI
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x54B3CC0", Offset = "0x54B28C0", VA = "0x1854B3CC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x54B5340", Offset = "0x54B3F40", VA = "0x1854B5340")]
	public MFCBKIOLAIJ([In] T OOHGFGHCOAJ, bool NKGIAPOMHGC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x54B48F0", Offset = "0x54B34F0", VA = "0x1854B48F0")]
	public static bool JOHLOKGLNML([In] MFCBKIOLAIJ<T> NAHMIIJKKEL, [In] MFCBKIOLAIJ<T> IJNKBHOINCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x54B34C0", Offset = "0x54B20C0", VA = "0x1854B34C0", Slot = "4")]
	public bool Equals(MFCBKIOLAIJ<T> GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x54B3260", Offset = "0x54B1E60", VA = "0x1854B3260", Slot = "0")]
	public override bool Equals(object? GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x54B3D90", Offset = "0x54B2990", VA = "0x1854B3D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x54B5090", Offset = "0x54B3C90", VA = "0x1854B5090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class LLJNOODHJEO
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B980A0", Offset = "0x3B96CA0", VA = "0x183B980A0")]
	public static MFCBKIOLAIJ<T> BLJLOAKHOEN<T>([In] T OOHGFGHCOAJ) where T : notnull
	{
		return default(MFCBKIOLAIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B983D0", Offset = "0x3B96FD0", VA = "0x183B983D0")]
	public static MFCBKIOLAIJ<T?> IAIEIKFACMC<T>()
	{
		return default(MFCBKIOLAIJ<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B98170", Offset = "0x3B96D70", VA = "0x183B98170")]
	public static bool DIJKECNNPKG<T>([In] this MFCBKIOLAIJ<T> JBJKCLOJIJG, [Out][NotNullWhen(true)] T OOHGFGHCOAJ) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3B98130", Offset = "0x3B96D30", VA = "0x183B98130")]
	public static bool DIJKECNNPKG<T>([In] this MFCBKIOLAIJ<T> JBJKCLOJIJG, [Out][NotNullWhen(true)] T OOHGFGHCOAJ, [Out] MFCBKIOLAIJ<T> JFBGMMNBJOC) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3B981A0", Offset = "0x3B96DA0", VA = "0x183B981A0")]
	public static T? GFNIMLIMIMD<T>([In] this MFCBKIOLAIJ<T> JBJKCLOJIJG, T? IPOLOHBNCGD)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B98450", Offset = "0x3B97050", VA = "0x183B98450")]
	public static bool JHBCGONLDAJ<T>([In] this MFCBKIOLAIJ<T> JBJKCLOJIJG, T OOHGFGHCOAJ) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LIEGPFGHCFG
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3B91AF0", Offset = "0x3B906F0", VA = "0x183B91AF0")]
	public static T EBDHOENJKDI<T>([In] this MFCBKIOLAIJ<T> JBJKCLOJIJG) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct LINBPNIFKCD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr KLOJDBOCKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr LEMKGCKAKJA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr JJNLEJBDPOG;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr ANNDOBPMFND;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly LINBPNIFKCD LELJIFADAHI;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool PNOGDJAFBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7F29BA0", Offset = "0x7F287A0", VA = "0x187F29BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xB5F450", Offset = "0xB5E050", VA = "0x180B5F450")]
	public LINBPNIFKCD(IntPtr CAMOOIONHGH, IntPtr BGFNJJOCFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void FFOJDBPIAKG(string LAOCJKNALFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80")]
	private static void GOLMCJDNAFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7F29C70", Offset = "0x7F28870", VA = "0x187F29C70")]
	private static LINBPNIFKCD IMGDCIJGLFP()
	{
		return default(LINBPNIFKCD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct EMHLGMGIMML
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr NNIDLMFOHII;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x12A44A0", Offset = "0x12A30A0", VA = "0x1812A44A0")]
	private EMHLGMGIMML(IntPtr BGFNJJOCFLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7F21AC0", Offset = "0x7F206C0", VA = "0x187F21AC0")]
	public void LDCCMKMJIMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7F219F0", Offset = "0x7F205F0", VA = "0x187F219F0")]
	public static EMHLGMGIMML JHMOIFLKJAD(string LAOCJKNALFF)
	{
		return default(EMHLGMGIMML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x29221C0", Offset = "0x2920DC0", VA = "0x1829221C0")]
	public static EMHLGMGIMML JHMOIFLKJAD([In] LINBPNIFKCD OFJEJBGPEDF, string LAOCJKNALFF)
	{
		return default(EMHLGMGIMML);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2921E90", Offset = "0x2920A90", VA = "0x182921E90")]
	public static EMHLGMGIMML JHMOIFLKJAD([In] LINBPNIFKCD OFJEJBGPEDF, Func<string> LAOCJKNALFF)
	{
		return default(EMHLGMGIMML);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class DDDNDHNHAOJ : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? BMGAPMLMIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr BLAIHKHKBIN;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool GKCDHEEDJJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7F216E0", Offset = "0x7F202E0", VA = "0x187F216E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7F21470", Offset = "0x7F20070", VA = "0x187F21470")]
	public static SHA256 GLOMJONEBBE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7F21950", Offset = "0x7F20550", VA = "0x187F21950")]
	private static extern int JIJIGLCFFEN();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7F21250", Offset = "0x7F1FE50", VA = "0x187F21250")]
	private static extern IntPtr BNNJMMJBJOP();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F213F0", Offset = "0x7F1FFF0", VA = "0x187F213F0")]
	private static extern void FKHPPIFNGNB(IntPtr BLAIHKHKBIN);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7F217D0", Offset = "0x7F203D0", VA = "0x187F217D0")]
	private static extern void IJIHPJFKGNA(IntPtr BLAIHKHKBIN, byte[] PEDMEJIDLNB, int KPHEINADMCH, int EKHEFELHLCG);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7F212C0", Offset = "0x7F1FEC0", VA = "0x187F212C0")]
	private static extern void DGFGJJPOMNH(IntPtr BLAIHKHKBIN, byte[] KMGBCMCHBHC);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7F219C0", Offset = "0x7F205C0", VA = "0x187F219C0")]
	private DDDNDHNHAOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7F214F0", Offset = "0x7F200F0", VA = "0x187F214F0", Slot = "18")]
	protected override void HashCore(byte[] IKALPCJBCLK, int DOPAAFIKLPK, int AMPHGOJHFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7F215B0", Offset = "0x7F201B0", VA = "0x187F215B0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7F21890", Offset = "0x7F20490", VA = "0x187F21890", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7F21360", Offset = "0x7F1FF60", VA = "0x187F21360", Slot = "13")]
	protected override void Dispose(bool LKEAJHCAOAD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HJDLDIJKIGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool OKEOJKPMGBA<in TInput, TResult>(TInput OLMHJMNEENP, [Out] TResult DBJBIPJCIKA);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class JJBCOKPHNCM : OKHIIGNFPLG
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class NCLJBJIGFHD : FGPNLEOAOJB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly NCLJBJIGFHD LBPNLDGACAA;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool GHBNADMNCLG
			{
				[Cpp2IlInjected.Token(Token = "0x60000F9")]
				[Cpp2IlInjected.Address(RVA = "0x7F2B580", Offset = "0x7F2A180", VA = "0x187F2B580", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7F2B5E0", Offset = "0x7F2A1E0", VA = "0x187F2B5E0", Slot = "6")]
			public void OnCompleted(Action JPMKDGPIIAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			public void BOPJECOALEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public NCLJBJIGFHD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly JJBCOKPHNCM LBPNLDGACAA;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		private JJBCOKPHNCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7F280F0", Offset = "0x7F26CF0", VA = "0x187F280F0", Slot = "4")]
		public FGPNLEOAOJB LCIABKLGBLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class NBHNPIPEJLO : OKHIIGNFPLG
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class MGPPCHDJBOA : FGPNLEOAOJB, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly MGPPCHDJBOA LBPNLDGACAA;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool GHBNADMNCLG
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x7F2A280", Offset = "0x7F28E80", VA = "0x187F2A280", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x7F2A2A0", Offset = "0x7F28EA0", VA = "0x187F2A2A0", Slot = "6")]
			public void OnCompleted(Action JPMKDGPIIAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "5")]
			public void BOPJECOALEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public MGPPCHDJBOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly NBHNPIPEJLO LBPNLDGACAA;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		private NBHNPIPEJLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B4C0", Offset = "0x7F2A0C0", VA = "0x187F2B4C0", Slot = "4")]
		public FGPNLEOAOJB LCIABKLGBLO()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class FKEMCIMAPHP<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public FKEMCIMAPHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4720720", Offset = "0x471F320", VA = "0x184720720")]
		internal void JKOFCMIMAKF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LHFDOPBJACB<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public LHFDOPBJACB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4DBF450", Offset = "0x4DBE050", VA = "0x184DBF450")]
		internal void DNOBPEMPPFN(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct FPEMJCKMCHM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x7F22A60", Offset = "0x7F21660", VA = "0x187F22A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GLOAHNNIIAH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x7F23450", Offset = "0x7F22050", VA = "0x187F23450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA6B020", Offset = "0xA69C20", VA = "0x180A6B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct ABDGEDDEOKO<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4CDF7D0", Offset = "0x4CDE3D0", VA = "0x184CDF7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4CDF940", Offset = "0x4CDE540", VA = "0x184CDF940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct LFMPOCNJNLE<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x52B78D0", Offset = "0x52B64D0", VA = "0x1852B78D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x52B7CF0", Offset = "0x52B68F0", VA = "0x1852B7CF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct EOHFDECHEPF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7F21AD0", Offset = "0x7F206D0", VA = "0x187F21AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x7F21CE0", Offset = "0x7F208E0", VA = "0x187F21CE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class EFJJGPBOPCI<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public EFJJGPBOPCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x4720720", Offset = "0x471F320", VA = "0x184720720")]
		internal void IGBIGLNKMPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4720760", Offset = "0x471F360", VA = "0x184720760")]
		internal void PBJOGFLAMEK(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct KDAIFHADMDH<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public OKEOJKPMGBA<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x51D1AD0", Offset = "0x51D06D0", VA = "0x1851D1AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x51D2180", Offset = "0x51D0D80", VA = "0x1851D2180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct IANGKCFNGHG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7F26670", Offset = "0x7F25270", VA = "0x187F26670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7F26E60", Offset = "0x7F25A60", VA = "0x187F26E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct AKKAMGPOJID : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F250", Offset = "0x7F1DE50", VA = "0x187F1F250", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F790", Offset = "0x7F1E390", VA = "0x187F1F790", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct IEGDCCHNBPB<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4E68FE0", Offset = "0x4E67BE0", VA = "0x184E68FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4E69EE0", Offset = "0x4E68AE0", VA = "0x184E69EE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class DBLCHBIJEAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<BOFEABKGBFC> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public DBLCHBIJEAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x7F21140", Offset = "0x7F1FD40", VA = "0x187F21140")]
		internal void JBMJBMDPGII(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct LBAHPKKCLFA<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public IEnumerable<Task<T>> tasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private Task<T>[] <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x527C3B0", Offset = "0x527AFB0", VA = "0x18527C3B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x42738F0", Offset = "0x42724F0", VA = "0x1842738F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct DGCIEBBCBNI<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public Task<T1> task1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Task<T2> task2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Task<T3> task3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x429DFB0", Offset = "0x429CBB0", VA = "0x18429DFB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x4272A20", Offset = "0x4271620", VA = "0x184272A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct ADKGGJGIAGN<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

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
		public Task<T4> task4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Task<T5> task5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3300", Offset = "0x4CE1F00", VA = "0x184CE3300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x4CE3AE0", Offset = "0x4CE26E0", VA = "0x184CE3AE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct BJDOKEPBJIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7F20450", Offset = "0x7F1F050", VA = "0x187F20450", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7F20630", Offset = "0x7F1F230", VA = "0x187F20630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct CFLKGIJELNH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7F20820", Offset = "0x7F1F420", VA = "0x187F20820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7F20B80", Offset = "0x7F1F780", VA = "0x187F20B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct MNGIJOJKKLA : IAsyncStateMachine
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
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A5A0", Offset = "0x7F291A0", VA = "0x187F2A5A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A890", Offset = "0x7F29490", VA = "0x187F2A890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GENOEBJIMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public GENOEBJIMAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7F230D0", Offset = "0x7F21CD0", VA = "0x187F230D0")]
		internal Task NFMGKBPGCBA(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct OGOIHJEAPPJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B820", Offset = "0x7F2A420", VA = "0x187F2B820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BA80", Offset = "0x7F2A680", VA = "0x187F2BA80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct LHCGLGJKHIB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7F29960", Offset = "0x7F28560", VA = "0x187F29960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7F29B40", Offset = "0x7F28740", VA = "0x187F29B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct EPJBDIENBFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private YieldAwaitable.YieldAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7F21D50", Offset = "0x7F20950", VA = "0x187F21D50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7F220B0", Offset = "0x7F20CB0", VA = "0x187F220B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct ANKDKPOFFFH : IAsyncStateMachine
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
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F7F0", Offset = "0x7F1E3F0", VA = "0x187F1F7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FAE0", Offset = "0x7F1E6E0", VA = "0x187F1FAE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MBGHJMFCAHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public MBGHJMFCAHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A210", Offset = "0x7F28E10", VA = "0x187F2A210")]
		internal Task GABJHIAIIIF(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct AEOEFAJLKMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public TimeSpan timeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Action<OperationCanceledException> handleTimeout;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7F1EF90", Offset = "0x7F1DB90", VA = "0x187F1EF90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7F1F1F0", Offset = "0x7F1DDF0", VA = "0x187F1F1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct MMNNMGBKKIJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Task task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Action then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A3C0", Offset = "0x7F28FC0", VA = "0x187F2A3C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x7F2A540", Offset = "0x7F29140", VA = "0x187F2A540", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct DPMDKHKKMJB<T> : IAsyncStateMachine where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public Task<T> task;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Action<T> then;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x42DD9B0", Offset = "0x42DC5B0", VA = "0x1842DD9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x42DDEB0", Offset = "0x42DCAB0", VA = "0x1842DDEB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct GCOIBICFCOP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public Func<Task> function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private object <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7F22C10", Offset = "0x7F21810", VA = "0x187F22C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x7F22F40", Offset = "0x7F21B40", VA = "0x187F22F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? JABKPBICCLH;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<BOFEABKGBFC> PMAHJMEHAFK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task CBCBJKNNJNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x7F24E40", Offset = "0x7F23A40", VA = "0x187F24E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7F24BD0", Offset = "0x7F237D0", VA = "0x187F24BD0")]
	public static bool CKBHFFPJNCG(this Task NKDMFOKACBI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3AB45B0", Offset = "0x3AB31B0", VA = "0x183AB45B0")]
	public static Task<T> HBBGNCOLKLJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7F257A0", Offset = "0x7F243A0", VA = "0x187F257A0")]
	public static Task KCPEBPFIFKF(this Task NKDMFOKACBI, CancellationToken HEDGIMBCGHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7B30", Offset = "0x3AB6730", VA = "0x183AB7B30")]
	public static Task<TResult> KCPEBPFIFKF<TResult>(this Task<TResult> NKDMFOKACBI, CancellationToken HEDGIMBCGHA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB7320", Offset = "0x3AB5F20", VA = "0x183AB7320")]
	public static TaskCompletionSource<TResult> KCPEBPFIFKF<TResult>(this TaskCompletionSource<TResult> GGCMENFMEPO, CancellationToken HEDGIMBCGHA) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7F254E0", Offset = "0x7F240E0", VA = "0x187F254E0")]
	public static IDisposable? JACAMJHAJFE(CancellationToken LPLPJCKFIDL, CancellationToken MDKCLIKBMEK, [Out] CancellationToken IIJDHCDNCGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7F24EB0", Offset = "0x7F23AB0", VA = "0x187F24EB0")]
	[AsyncStateMachine(typeof(FPEMJCKMCHM))]
	public static void FPFBGNMNCBI(this Task LPCHKKFEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7F25E20", Offset = "0x7F24A20", VA = "0x187F25E20")]
	[AsyncStateMachine(typeof(GLOAHNNIIAH))]
	public static void NPLJJHCJHPF(this Task LPCHKKFEGJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3AB92B0", Offset = "0x3AB7EB0", VA = "0x183AB92B0")]
	[AsyncStateMachine(typeof(ABDGEDDEOKO<>))]
	public static Task NBMPDNMGNJF<TException>(this Task LPCHKKFEGJO) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3AB90F0", Offset = "0x3AB7CF0", VA = "0x183AB90F0")]
	[AsyncStateMachine(typeof(LFMPOCNJNLE<>))]
	public static Task<T> LJKCLACKAJP<T>(this Task<T> LAAPKLDJLPE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7F24AE0", Offset = "0x7F236E0", VA = "0x187F24AE0")]
	[AsyncStateMachine(typeof(EOHFDECHEPF))]
	public static Task<TaskStatus> CGCPNGNCGBD(this Task? LAAPKLDJLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4090", Offset = "0x3AB2C90", VA = "0x183AB4090")]
	public static (Task<T?>?, Action<T?>?) CJILHNPOCOL<T>([Optional] CancellationToken DKKNFNCKCEB)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3AB44B0", Offset = "0x3AB30B0", VA = "0x183AB44B0")]
	[AsyncStateMachine(typeof(KDAIFHADMDH<, >))]
	public static Task<List<TResult>> EIOLNCBKHJL<TResult, TInput>(this Task<List<TInput>> NKDMFOKACBI, OKEOJKPMGBA<TInput, TResult> JGFMADHLHDK) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F25ED0", Offset = "0x7F24AD0", VA = "0x187F25ED0")]
	[AsyncStateMachine(typeof(IANGKCFNGHG))]
	public static Task OGMBBMEJCEM(Task LPCHKKFEGJO, CancellationToken DCACDPOIBLL, Func<CancellationToken, Task> MAEDODGBDKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7F25670", Offset = "0x7F24270", VA = "0x187F25670")]
	[AsyncStateMachine(typeof(AKKAMGPOJID))]
	public static Task JLOKEFOAFKF(Func<CancellationToken, Task> NLJABCHLKFD, TimeSpan AJHEJELDLBD, [Optional] CancellationToken DCACDPOIBLL, [Optional] Action<OperationCanceledException>? EICBNNLLINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4AE0", Offset = "0x3AB36E0", VA = "0x183AB4AE0")]
	[AsyncStateMachine(typeof(IEGDCCHNBPB<>))]
	public static Task<T> JLOKEFOAFKF<T>(Func<CancellationToken, Task<T>> NLJABCHLKFD, TimeSpan AJHEJELDLBD, [Optional] CancellationToken DCACDPOIBLL, [Optional] Func<OperationCanceledException, T>? EICBNNLLINB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7F243D0", Offset = "0x7F22FD0", VA = "0x187F243D0")]
	public static Task CCGJBBLAPJM(params Task[] MPLJBBKOIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7F24420", Offset = "0x7F23020", VA = "0x187F24420")]
	public static Task CCGJBBLAPJM(IEnumerable<Task> MPLJBBKOIAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x3AB9460", Offset = "0x3AB8060", VA = "0x183AB9460")]
	[AsyncStateMachine(typeof(LBAHPKKCLFA<>))]
	public static Task<IEnumerable<Task<T>>> OIKBBAHDCHI<T>(IEnumerable<Task<T>> MPLJBBKOIAA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x3AB49C0", Offset = "0x3AB35C0", VA = "0x183AB49C0")]
	[AsyncStateMachine(typeof(DGCIEBBCBNI<, , >))]
	public static Task<(T1, T2, T3)> HONGJOBPNHM<T1, T2, T3>(Task<T1> KFAADCBBBCL, Task<T2> BHMCDBBHLOO, Task<T3> POKDODEOBGB) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3AB4700", Offset = "0x3AB3300", VA = "0x183AB4700")]
	[AsyncStateMachine(typeof(ADKGGJGIAGN<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> HONGJOBPNHM<T1, T2, T3, T4, T5>(Task<T1> KFAADCBBBCL, Task<T2> BHMCDBBHLOO, Task<T3> POKDODEOBGB, Task<T4> MCAOCHODHKN, Task<T5> NLKAAJBJKHP) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7F248E0", Offset = "0x7F234E0", VA = "0x187F248E0")]
	[AsyncStateMachine(typeof(BJDOKEPBJIF))]
	public static Task CCIEKOBFBFL(Func<bool> JIMAJCFJLFE, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7F249D0", Offset = "0x7F235D0", VA = "0x187F249D0")]
	[AsyncStateMachine(typeof(CFLKGIJELNH))]
	public static Task CCIEKOBFBFL(Func<bool> JIMAJCFJLFE, TimeSpan KGJGLGNJBOD, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7F250A0", Offset = "0x7F23CA0", VA = "0x187F250A0")]
	[AsyncStateMachine(typeof(MNGIJOJKKLA))]
	public static Task GDHIKBGCFPO(Func<bool> JIMAJCFJLFE, TimeSpan AJHEJELDLBD, [Optional] CancellationToken DKKNFNCKCEB, [Optional] Action<OperationCanceledException>? EICBNNLLINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7F24F60", Offset = "0x7F23B60", VA = "0x187F24F60")]
	[AsyncStateMachine(typeof(OGOIHJEAPPJ))]
	public static Task GDHIKBGCFPO(Func<bool> JIMAJCFJLFE, TimeSpan AJHEJELDLBD, TimeSpan KGJGLGNJBOD, [Optional] CancellationToken DKKNFNCKCEB, [Optional] Action<OperationCanceledException>? EICBNNLLINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7F25C80", Offset = "0x7F24880", VA = "0x187F25C80")]
	[AsyncStateMachine(typeof(LHCGLGJKHIB))]
	public static Task NFBBCAPHEHB(Func<bool> JIMAJCFJLFE, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7F25B70", Offset = "0x7F24770", VA = "0x187F25B70")]
	[AsyncStateMachine(typeof(EPJBDIENBFE))]
	public static Task NFBBCAPHEHB(Func<bool> JIMAJCFJLFE, TimeSpan KGJGLGNJBOD, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7F253B0", Offset = "0x7F23FB0", VA = "0x187F253B0")]
	[AsyncStateMachine(typeof(ANKDKPOFFFH))]
	public static Task IEBBDEDBDBE(Func<bool> JIMAJCFJLFE, TimeSpan AJHEJELDLBD, [Optional] CancellationToken DKKNFNCKCEB, [Optional] Action<OperationCanceledException>? EICBNNLLINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7F25270", Offset = "0x7F23E70", VA = "0x187F25270")]
	[AsyncStateMachine(typeof(AEOEFAJLKMF))]
	public static Task IEBBDEDBDBE(Func<bool> JIMAJCFJLFE, TimeSpan AJHEJELDLBD, TimeSpan KGJGLGNJBOD, [Optional] CancellationToken DKKNFNCKCEB, [Optional] Action<OperationCanceledException>? EICBNNLLINB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x7F24D50", Offset = "0x7F23950", VA = "0x187F24D50")]
	[AsyncStateMachine(typeof(MMNNMGBKKIJ))]
	[Obsolete]
	public static Task DPHGCLAFPOH(this Task NKDMFOKACBI, Action IJIKHEGBKLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x3AB42D0", Offset = "0x3AB2ED0", VA = "0x183AB42D0")]
	[AsyncStateMachine(typeof(DPMDKHKKMJB<>))]
	[Obsolete]
	public static Task DPHGCLAFPOH<T>(this Task<T> NKDMFOKACBI, Action<T> IJIKHEGBKLP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F25D70", Offset = "0x7F24970", VA = "0x187F25D70")]
	private static void NHGAPBOEIDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7F26000", Offset = "0x7F24C00", VA = "0x187F26000")]
	public static bool PAMPGGOLEGA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7F259F0", Offset = "0x7F245F0", VA = "0x187F259F0")]
	private static void KNAEICBHALI(SynchronizationContext OOHGFGHCOAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7F242C0", Offset = "0x7F22EC0", VA = "0x187F242C0")]
	private static void AGCBDCCIJKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7F24C80", Offset = "0x7F23880", VA = "0x187F24C80")]
	public static void DODKDOPBKNP([Optional] string? FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7F24C00", Offset = "0x7F23800", VA = "0x187F24C00")]
	public static void DMIJLDBEAFM([Optional] string? FNFIPKNHEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7F25220", Offset = "0x7F23E20", VA = "0x187F25220")]
	public static OKHIIGNFPLG HJGPIIOJCHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7F251D0", Offset = "0x7F23DD0", VA = "0x187F251D0")]
	public static OKHIIGNFPLG HAKMOPNBICH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x7F26360", Offset = "0x7F24F60", VA = "0x187F26360")]
	[AsyncStateMachine(typeof(GCOIBICFCOP))]
	public static Task PENJDHBAMKG(Func<Task> PAGHHLHAGEE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class BOOMHEJPJEF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
	public BOOMHEJPJEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class CHAPDKCHACN
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7F20D00", Offset = "0x7F1F900", VA = "0x187F20D00")]
	public static bool BCDPKFCFBKC(this KDAAJHGJFCF HEJAILMBFCL, DateTime BAENAEFKODN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x7F20BE0", Offset = "0x7F1F7E0", VA = "0x187F20BE0")]
	public static TimeSpan ABMLKCCECMH(this KDAAJHGJFCF HEJAILMBFCL, DateTime BAENAEFKODN)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class IKEGBPNDBJI : KDAAJHGJFCF
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly KDAAJHGJFCF LBPNLDGACAA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime OGGIJIIELLP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7F27900", Offset = "0x7F26500", VA = "0x187F27900", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset MOGEPCLAGLN
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7F27940", Offset = "0x7F26540", VA = "0x187F27940", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
	public IKEGBPNDBJI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface KDAAJHGJFCF
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime OGGIJIIELLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset MOGEPCLAGLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class BDAJLCEDFNK
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long KFHAHLGOMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FF60", Offset = "0x7F1EB60", VA = "0x187F1FF60")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long FBPEOGMKENN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD90", Offset = "0x7F1E990", VA = "0x187F1FD90")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double AANJLNFMBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FE80", Offset = "0x7F1EA80", VA = "0x187F1FE80")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double FLEAICDFNHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FDE0", Offset = "0x7F1E9E0", VA = "0x187F1FDE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double EKAOPLNMFBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FE30", Offset = "0x7F1EA30", VA = "0x187F1FE30")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double EPLBNCNHKDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7F20080", Offset = "0x7F1EC80", VA = "0x187F20080")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FBE0", Offset = "0x7F1E7E0", VA = "0x187F1FBE0")]
	public static double AIANMPJFEDF(long CLGDDJEPIAD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD00", Offset = "0x7F1E900", VA = "0x187F1FD00")]
	public static double FEGMLAIJHLG(long CLGDDJEPIAD)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FC70", Offset = "0x7F1E870", VA = "0x187F1FC70")]
	public static double FCEPLGGOAKN(double CBACAFKJEOM)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FED0", Offset = "0x7F1EAD0", VA = "0x187F1FED0")]
	public static long LKKPIMCELEH(long KLCDLOHEBCJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7F20130", Offset = "0x7F1ED30", VA = "0x187F20130")]
	public static long PPJKKKJJOHA(long KPHELKLNNHF, long ANMLIOEMPOK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FFB0", Offset = "0x7F1EBB0", VA = "0x187F1FFB0")]
	public static double MIAPFDAKCIG(long KPHELKLNNHF, long ANMLIOEMPOK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7F200D0", Offset = "0x7F1ECD0", VA = "0x187F200D0")]
	public static double OIJDBNLPAKC(long KPHELKLNNHF, long ANMLIOEMPOK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class JACNJMIENLE : CJENPGOKKKF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly TimeSpan ENGEGKPDBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly System.Timers.Timer KDCDPEHJICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TimeSpan AJHEJELDLBD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan COENNDCPEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA20EB0", Offset = "0xA1FAB0", VA = "0x180A20EB0", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x7F27BE0", Offset = "0x7F267E0", VA = "0x187F27BE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? IMMCNFHKOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB40", Offset = "0xA1D740", VA = "0x180A1EB40", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA1EB20", Offset = "0xA1D720", VA = "0x180A1EB20", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7F28090", Offset = "0x7F26C90", VA = "0x187F28090")]
	[Preserve]
	public JACNJMIENLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7F27E40", Offset = "0x7F26A40", VA = "0x187F27E40")]
	public JACNJMIENLE(TimeSpan AJHEJELDLBD, [Optional] Action? JKBKKIKKGLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7F27B50", Offset = "0x7F26750", VA = "0x187F27B50", Slot = "7")]
	public void KDHJHGHKFGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7F27AE0", Offset = "0x7F266E0", VA = "0x187F27AE0", Slot = "8")]
	public void EDKOEELMPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x7F27A10", Offset = "0x7F26610", VA = "0x187F27A10", Slot = "9")]
	public void DABNHEKODGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x11FDA70", Offset = "0x11FC670", VA = "0x1811FDA70")]
	private void FEABLOMFBBN(object NGGJJFKLDLG, ElapsedEventArgs PKOMJIEMMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7F27D40", Offset = "0x7F26940", VA = "0x187F27D40")]
	private static void LKKFAGEMBKG(TimeSpan KBPHFKFHEOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7F27A40", Offset = "0x7F26640", VA = "0x187F27A40", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class MHCDBJJGKDE : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string? MOELDIBJICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string HGPHMFIAEFG;

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x1801D70", Offset = "0x1800970", VA = "0x181801D70")]
	public MHCDBJJGKDE(string NFKNKHBBLBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4CE1230", Offset = "0x4CDFE30", VA = "0x184CE1230")]
	public MHCDBJJGKDE(string GPIJFOKHGBC, string NFKNKHBBLBH)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct KAMJILGICKA : IEquatable<KAMJILGICKA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public uint IOIOIBFHGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int NGOMKKPGIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float FEGOLHMPGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public ushort ODDNNEOBACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public ushort ENFEFNFELBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short AILOJDJBMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public short NGINMJKNCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char KDHHCANPEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char OFJGHHJLJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte MBFMGDCLEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte CONGGHKDHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte MKGFAJEHNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte BMDDFPLCOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool BMLDAANNAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool FKDPCMFEBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool DOFGMIODBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool MCKLIHLBDCB;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB210", Offset = "0x1FF9E10", VA = "0x181FFB210")]
	public static KAMJILGICKA KFDCPMNCKJB(uint JHEMPGFPAIO)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x1FFB210", Offset = "0x1FF9E10", VA = "0x181FFB210")]
	public static KAMJILGICKA KOBIKCAOCIC(int OONNDFOKJNP)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7F28AE0", Offset = "0x7F276E0", VA = "0x187F28AE0")]
	public static KAMJILGICKA BPCDNKONMCA(float BFMACJFDIKP)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7F28AC0", Offset = "0x7F276C0", VA = "0x187F28AC0")]
	public static KAMJILGICKA AIKENMLABBN(byte MLNPFGNJHIG, byte IAMJGMMBMON, byte CBGFPPCKIPE, byte PJIILDBMOAP)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7F28AC0", Offset = "0x7F276C0", VA = "0x187F28AC0")]
	public static KAMJILGICKA IJAFNOBEODH(bool LEEAABAODCI, bool LOENMFNGBGH, bool APBHJDMBIOP, bool BAIDDIJJIBH)
	{
		return default(KAMJILGICKA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7F28AC0", Offset = "0x7F276C0", VA = "0x187F28AC0")]
	public static KAMJILGICKA LNKPGDLJIBP(byte CILLANHEFCM, byte GIELOALKKLN, byte DHCMLMKDDDM, byte NOOOAMNHFIB)
	{
		return default(KAMJILGICKA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x230B2F0", Offset = "0x2309EF0", VA = "0x18230B2F0")]
	public static bool JOHLOKGLNML(KAMJILGICKA HLPEBKMLKLE, KAMJILGICKA MAELALMKOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x230B2D0", Offset = "0x2309ED0", VA = "0x18230B2D0", Slot = "4")]
	public bool Equals(KAMJILGICKA GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7F28AF0", Offset = "0x7F276F0", VA = "0x187F28AF0", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x14235B0", Offset = "0x14221B0", VA = "0x1814235B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7F28B70", Offset = "0x7F27770", VA = "0x187F28B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct GAKMBLFOJBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ulong PAHGNLJNALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public long HADOBEEFBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public double OFKHDEKKPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public uint EODFHBIJEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public uint IILMGKBIDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public int CBOBIKDBFFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public int FGCJHANDLGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float EBKFPCKJBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float PCKGKEALLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public ushort ODDNNEOBACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public ushort ENFEFNFELBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public ushort BPDGPLCINHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public ushort GKIGEFNFPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public short AILOJDJBMAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public short NGINMJKNCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public short IABPDHMLGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public short BLFGNGNPMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public char KDHHCANPEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public char OFJGHHJLJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public char MGDALJLNNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public char LPKGONLGMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public byte MBFMGDCLEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public byte CONGGHKDHEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public byte MKGFAJEHNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public byte BMDDFPLCOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public byte CIEIFFHCJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public byte PMOLJMKFAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte GMOICIGLPCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte FEPHPMLCPAF;

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static GAKMBLFOJBI JHMOIFLKJAD(long BBGOOJJPOAL)
	{
		return default(GAKMBLFOJBI);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x7F22BC0", Offset = "0x7F217C0", VA = "0x187F22BC0")]
	public static GAKMBLFOJBI JHMOIFLKJAD(byte MLNPFGNJHIG, byte IAMJGMMBMON, byte CBGFPPCKIPE, byte PJIILDBMOAP, byte FJPPHCHCGFJ, byte JAEOCAAIBHG, byte HALECEIPNIK, byte GBPEKAIPPNF)
	{
		return default(GAKMBLFOJBI);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct GJICPMMEPLC : IEquatable<GJICPMMEPLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte DLNPPDHAFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool EDCLGAKOHOC;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x30146C0", Offset = "0x30132C0", VA = "0x1830146C0")]
	public static GJICPMMEPLC AIKENMLABBN(byte BOKFDKJLCNG)
	{
		return default(GJICPMMEPLC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x30146C0", Offset = "0x30132C0", VA = "0x1830146C0")]
	public static GJICPMMEPLC IJAFNOBEODH(bool GMLKFMNCGNJ)
	{
		return default(GJICPMMEPLC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7F231E0", Offset = "0x7F21DE0", VA = "0x187F231E0")]
	public static bool JOHLOKGLNML(GJICPMMEPLC HLPEBKMLKLE, GJICPMMEPLC MAELALMKOEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6E31FF0", Offset = "0x6E30BF0", VA = "0x186E31FF0", Slot = "4")]
	public bool Equals(GJICPMMEPLC GMNGNCHKEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7F23140", Offset = "0x7F21D40", VA = "0x187F23140", Slot = "0")]
	public override bool Equals(object KDKJDFFGNJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7F231D0", Offset = "0x7F21DD0", VA = "0x187F231D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7F231F0", Offset = "0x7F21DF0", VA = "0x187F231F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class AAELAIFEDFJ<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly T OHNHOENBMFG;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4CDD310", Offset = "0x4CDBF10", VA = "0x184CDD310")]
	public AAELAIFEDFJ(T PLBOLCGODBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class MPDDEENIFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8170", Offset = "0x3BB6D70", VA = "0x183BB8170")]
	public static IEnumerable<T> IABPEEJAHKJ<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static T[] KLIEADIPNHN<T>(params T[] GCGGOBMDHCK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0xD21E30", Offset = "0xD20A30", VA = "0x180D21E30")]
	public static IEnumerable<T> BCIDHCFHOIJ<T>(params T[] GCGGOBMDHCK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3834190", Offset = "0x3832D90", VA = "0x183834190")]
	public static HashSet<T> FPNFCDKKBKB<T>(params T[] GCGGOBMDHCK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3BB8080", Offset = "0x3BB6C80", VA = "0x183BB8080")]
	public static KeyValuePair<TKey, TValue> EJEALLOJLHC<TKey, TValue>([In] TKey MEPFFFGIFGB, [In] TValue OOHGFGHCOAJ) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3834190", Offset = "0x3832D90", VA = "0x183834190")]
	public static List<T> MIBPKAGMAIK<T>(IEnumerable<T> OGLPOFDOMIH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AttributeUsage(AttributeTargets.All)]
public sealed class FMJJHJFKIEK : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string JPLBGJAEKHC;

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0xA48850", Offset = "0xA47450", VA = "0x180A48850")]
	public FMJJHJFKIEK(string HKLMEDDFFBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public delegate object EMFGKBALFMA<T>([In] T FABPHEFJGGN);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object PGPMPCPIKND<T>(T FABPHEFJGGN);
[Cpp2IlInjected.Token(Token = "0x2000068")]
[CIGHNBJCJJN]
public delegate string BOFEAALMHKM(string KMCLKBGAPBL, string? BGBBINOABDF, bool DNCLOJOLBAN);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[CIGHNBJCJJN]
public delegate void IIOAGFHECKA(string FNFIPKNHEOF);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[CIGHNBJCJJN]
public delegate void OLEMFJBEDMA(Exception DFLKFAIHDKI);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public delegate object HAAPAJEFIGM();
[Cpp2IlInjected.Token(Token = "0x200006C")]
[CIGHNBJCJJN]
public delegate bool AEIAPIBNMKC();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[CIGHNBJCJJN]
public delegate string BEGPDAALGKG(object KDKJDFFGNJJ);
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AttributeUsage(AttributeTargets.Enum)]
public class LIEHCDIGHCI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0xA478F0", Offset = "0xA464F0", VA = "0x180A478F0")]
	public LIEHCDIGHCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class GNNOOOJIKHD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct FFKFGGNLMJP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public AsyncTaskMethodBuilder<bool> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public int millisecondsDelay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private System.Threading.Timer <timer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private object <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private int <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private bool <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private object <>7__wrap6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private int <>7__wrap7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private bool <>7__wrap8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private TaskAwaiter<bool> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private ValueTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F22110", Offset = "0x7F20D10", VA = "0x187F22110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x7F229F0", Offset = "0x7F215F0", VA = "0x187F229F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly TimerCallback FGNBINOIFID;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly Action<object?> LNJBLCJCEKP;

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7F23560", Offset = "0x7F22160", VA = "0x187F23560")]
	public static Task<bool> EJEFKBLBPHI(int CDNFMCLCLGL, [Optional] CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7F238F0", Offset = "0x7F224F0", VA = "0x187F238F0")]
	[AsyncStateMachine(typeof(FFKFGGNLMJP))]
	private static Task<bool> HJHMIEGNOCN(int CDNFMCLCLGL, CancellationToken DKKNFNCKCEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7F23860", Offset = "0x7F22460", VA = "0x187F23860")]
	private static void GKFEEOBIBBP(object? DKILGKEHOLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x7F23A20", Offset = "0x7F22620", VA = "0x187F23A20")]
	private static void POBBFJNJAKC(object? DKILGKEHOLM)
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
