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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C48380", Offset = "0x7C46B80", VA = "0x187C48380")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HBLFHBPMNIB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C40900", Offset = "0x7C3F100", VA = "0x187C40900")]
	public static string DLJEFEGHCIF(this Encoding DDHPDENHFML, [In] ReadOnlySequence<byte> FLMLKMBDILC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x37A10D0", Offset = "0x379F8D0", VA = "0x1837A10D0")]
	private static void MHLPNHNLAGJ<T>(this ReadOnlySequence<T> DOGMACCPFAG, [Out] ReadOnlySpan<T> HFMECGKPJFA, [Out] SequencePosition DGJLLLECKHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class DPFCDNDBJGJ : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F0B0", Offset = "0x7C3D8B0", VA = "0x187C3F0B0")]
	public DPFCDNDBJGJ(bool MFOFGFANCHI, string AHMCJMAKEBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F060", Offset = "0x7C3D860", VA = "0x187C3F060")]
	public DPFCDNDBJGJ(bool MFOFGFANCHI, params string[] GFFHLDBEOJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class OAINJAMAMGE
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GFGMPBNMHLK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EIHKIOFBGBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKLBNMAIJMK(string BELIEAFHDAH, double OPMIAMEJKDH, [Optional] string? LJODNGGONNF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class BIHCKBFLDIM : GJELCMBFPPK, NNHNFLMHDFD, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int EFGPFKINKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> APKPHLNMIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double EDGENFDJJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double FGNFJAMALCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double MGMHBDFAMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int LFJOGBLHGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double GBIJJAGIDBA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DKLCEBDNIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9FCF80", Offset = "0x9FB780", VA = "0x1809FCF80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double DIGCJAKJFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C3DAD0", Offset = "0x7C3C2D0", VA = "0x187C3DAD0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double MGGLIIJDLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4A60DA0", Offset = "0x4A5F5A0", VA = "0x184A60DA0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double BABAGKJIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x26DA770", Offset = "0x26D8F70", VA = "0x1826DA770", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DDD0", Offset = "0x7C3C5D0", VA = "0x187C3DDD0")]
	public BIHCKBFLDIM(int GHADCJOBKNH, double GBIJJAGIDBA = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DC30", Offset = "0x7C3C430", VA = "0x187C3DC30", Slot = "7")]
	public void JFHNPOKANNB(double DDLBJHGGANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DD60", Offset = "0x7C3C560", VA = "0x187C3DD60", Slot = "8")]
	public void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DB30", Offset = "0x7C3C330", VA = "0x187C3DB30", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class FGAEPOKLELL : GJELCMBFPPK, NNHNFLMHDFD, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long PCFOAHIEPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double LDMDKJIFDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double KIAFPDBEOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double HPPMFGKHNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double NHKPCIKHLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double EDGENFDJJHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double FGNFJAMALCL;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long FCHJPHAGFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double MGGLIIJDLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F9F0", Offset = "0x6F0E1F0", VA = "0x186F0F9F0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double BABAGKJIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F0FA10", Offset = "0x6F0E210", VA = "0x186F0FA10", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double MAOKLNIBPGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F540", Offset = "0x6F0DD40", VA = "0x186F0F540")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double DIGCJAKJFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2DB3760", Offset = "0x2DB1F60", VA = "0x182DB3760", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FF20", Offset = "0x7C3E720", VA = "0x187C3FF20", Slot = "10")]
	public virtual void JFHNPOKANNB(double DDLBJHGGANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C40040", Offset = "0x7C3E840", VA = "0x187C40040", Slot = "11")]
	public virtual void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FEB0", Offset = "0x7C3E6B0", VA = "0x187C3FEB0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C40080", Offset = "0x7C3E880", VA = "0x187C40080")]
	public FGAEPOKLELL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class ODOADBLPIDJ : FGAEPOKLELL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double CLKHAKKHOGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F590", Offset = "0x6F0DD90", VA = "0x186F0F590")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6F0F560", Offset = "0x6F0DD60", VA = "0x186F0F560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C48500", Offset = "0x7C46D00", VA = "0x187C48500", Slot = "10")]
	public override void JFHNPOKANNB(double DDLBJHGGANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C48630", Offset = "0x7C46E30", VA = "0x187C48630", Slot = "11")]
	public override void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C40080", Offset = "0x7C3E880", VA = "0x187C40080")]
	public ODOADBLPIDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GJELCMBFPPK : NNHNFLMHDFD, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double DIGCJAKJFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double MGGLIIJDLMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double BABAGKJIFEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NDFDJDFOKCB : NNHNFLMHDFD, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double OEOJMHLCCNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double ELBCOABMKKA;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C47800", Offset = "0x7C46000", VA = "0x187C47800")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7B9FD50", Offset = "0x7B9E550", VA = "0x187B9FD50", Slot = "4")]
	public void JFHNPOKANNB(double DDLBJHGGANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C47860", Offset = "0x7C46060", VA = "0x187C47860", Slot = "5")]
	public void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C47810", Offset = "0x7C46010", VA = "0x187C47810", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NDFDJDFOKCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NNHNFLMHDFD : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFHNPOKANNB(double DDLBJHGGANE);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OMPDHJNPJPG();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NFFJBJHFKMP : NNHNFLMHDFD, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double OPMIAMEJKDH;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double GDCDOMLHCOE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x44ABFA0", Offset = "0x44AA7A0", VA = "0x1844ABFA0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x52CD6E0", Offset = "0x52CBEE0", VA = "0x1852CD6E0", Slot = "4")]
	public void JFHNPOKANNB(double DDLBJHGGANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7C47AE0", Offset = "0x7C462E0", VA = "0x187C47AE0", Slot = "5")]
	public void OMPDHJNPJPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7C47A90", Offset = "0x7C46290", VA = "0x187C47A90", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public NFFJBJHFKMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class DMHEBBJHCAJ<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> BJHIDMGEPNH(CancellationToken DNHBNMHIDAC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IBAKDENJBML : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DMHEBBJHCAJ<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public BJHIDMGEPNH taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x4B54680", Offset = "0x4B52E80", VA = "0x184B54680", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4B55740", Offset = "0x4B53F40", VA = "0x184B55740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource GCOFADJEBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? GEJOJKICEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? NJIJJOJGCHC;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x68E3A30", Offset = "0x68E2230", VA = "0x1868E3A30")]
	[AsyncStateMachine(typeof(DMHEBBJHCAJ<>.IBAKDENJBML))]
	public Task<TResult> ALKGLKMIMGD(BJHIDMGEPNH BPBMHGHEFIJ, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x68E3B70", Offset = "0x68E2370", VA = "0x1868E3B70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x68E3BE0", Offset = "0x68E23E0", VA = "0x1868E3BE0")]
	public DMHEBBJHCAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GAFPNOFBEFH<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> FKJNGIDDNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T GDCDOMLHCOE;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x497AE30", Offset = "0x4979630", VA = "0x18497AE30")]
	public GAFPNOFBEFH([In] T OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x497A300", Offset = "0x4978B00", VA = "0x18497A300", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x497A7F0", Offset = "0x4978FF0", VA = "0x18497A7F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x497AAF0", Offset = "0x49792F0", VA = "0x18497AAF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class OIILHPJFMNP
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x358FF90", Offset = "0x358E790", VA = "0x18358FF90")]
	public static GAFPNOFBEFH<T> CJOJELENPLJ<T>([In] T OPMIAMEJKDH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class NLNCGANNELC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x7C48350", Offset = "0x7C46B50", VA = "0x187C48350")]
	public static void PFHJCJIPJFA(this CancellationTokenSource GCOFADJEBOL, bool LLAPAPECNAP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class LGOONGJINIG : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
	public LGOONGJINIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class HAFDNMLPCDB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
	public HAFDNMLPCDB(string DLLEFEIEFJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class GHLFPIBFJIC
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3799530", Offset = "0x3797D30", VA = "0x183799530")]
	public static MINEABMMGIB HLECCPPOLPI<T>()
	{
		return default(MINEABMMGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x3799780", Offset = "0x3797F80", VA = "0x183799780")]
	public static MINEABMMGIB MNAPCBHEONF<T>([CallerMemberName] string GLGOHIJMLFB = "") where T : notnull
	{
		return default(MINEABMMGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x37995B0", Offset = "0x3797DB0", VA = "0x1837995B0")]
	public static MINEABMMGIB HLECCPPOLPI<T>(this T LDIOMGMJIGF) where T : notnull
	{
		return default(MINEABMMGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x37993E0", Offset = "0x3797BE0", VA = "0x1837993E0")]
	public static MINEABMMGIB AGJLODCEOOM<T>(this T LDIOMGMJIGF, [CallerMemberName] string GLGOHIJMLFB = "") where T : notnull
	{
		return default(MINEABMMGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3799820", Offset = "0x3798020", VA = "0x183799820")]
	public static MINEABMMGIB MNAPCBHEONF<T>(this T NFOGFJOGLPE, [CallerMemberName] string GLGOHIJMLFB = "") where T : notnull
	{
		return default(MINEABMMGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7C407C0", Offset = "0x7C3EFC0", VA = "0x187C407C0")]
	public static MINEABMMGIB MNAPCBHEONF(string LAOCPBJBAGE, [CallerMemberName] string GLGOHIJMLFB = "")
	{
		return default(MINEABMMGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C40720", Offset = "0x7C3EF20", VA = "0x187C40720")]
	public static string HJCLFKLBOGG(this object NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool PDLNAFEDLMM();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[LGOONGJINIG]
public delegate long FBCLOKNPKEJ();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class FLCEKDFHPAF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly FLCEKDFHPAF DJLOIKDDKCN;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public FLCEKDFHPAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class HPAIBGBNICL
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static HHEIOGPIONG BNHGAMEHCLM;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static HHEIOGPIONG EDGAMIHCNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7C445D0", Offset = "0x7C42DD0", VA = "0x187C445D0")]
		get
		{
			return default(HHEIOGPIONG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static IGODEECKAHO IHBEAFCIMKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C446F0", Offset = "0x7C42EF0", VA = "0x187C446F0")]
		get
		{
			return default(IGODEECKAHO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static OFAPNEPKMDG IFPEAFLFJLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C448B0", Offset = "0x7C430B0", VA = "0x187C448B0")]
		get
		{
			return default(OFAPNEPKMDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool KBDBIICJEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7C44C40", Offset = "0x7C43440", VA = "0x187C44C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x7C44CB0", Offset = "0x7C434B0", VA = "0x187C44CB0")]
	public static void PILIEIDIMDG([In] HHEIOGPIONG ONGHEGNFNDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x7C44740", Offset = "0x7C42F40", VA = "0x187C44740")]
	public static void BAOGIJBMDME(string NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x7C44620", Offset = "0x7C42E20", VA = "0x187C44620")]
	public static void AMHNOMFECLM(string NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x37C1510", Offset = "0x37BFD10", VA = "0x1837C1510")]
	public static void AMHNOMFECLM<T>(T MJAILKMLAHP, MPLFLFBFKNO<T> NJAAPDELBNN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7C44810", Offset = "0x7C43010", VA = "0x187C44810")]
	public static void BMPPMADKLCJ(Exception IIIACJLJMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7C44970", Offset = "0x7C43170", VA = "0x187C44970")]
	public static void EKHGDOJBNEE(string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C44AC0", Offset = "0x7C432C0", VA = "0x187C44AC0")]
	public static void GMCKBCFMJNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7C44B30", Offset = "0x7C43330", VA = "0x187C44B30")]
	public static string HJCLFKLBOGG(object PNHCNFOFAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7C44900", Offset = "0x7C43100", VA = "0x187C44900")]
	public static long DJDHLMMMPJP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7C44BA0", Offset = "0x7C433A0", VA = "0x187C44BA0")]
	public static bool OOAABMLECBF(bool JEKEJINPKGE, string NJAAPDELBNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7C449F0", Offset = "0x7C431F0", VA = "0x187C449F0")]
	public static double EOHIEIFFLEL()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct HHEIOGPIONG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly IGODEECKAHO IHBEAFCIMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly OFAPNEPKMDG IFPEAFLFJLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly EJAOLHODNHM CDMBCJLIICJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly FBCLOKNPKEJ NFPLLEPCENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly DHPFKNNCMAG KIELHFHEHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly PDLNAFEDLMM PLACBHELKDG;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly EJAOLHODNHM FGINBEKFAFC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly FBCLOKNPKEJ PJIGOJGIPOD;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly DHPFKNNCMAG BBLDFPHOCMB;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly PDLNAFEDLMM NNBFNDJCEGC;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly HHEIOGPIONG HMAILHHHNAA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool KBDBMNHHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7C43BD0", Offset = "0x7C423D0", VA = "0x187C43BD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7C44520", Offset = "0x7C42D20", VA = "0x187C44520")]
	public HHEIOGPIONG([In] IGODEECKAHO BCIOMFMOJID, [In] OFAPNEPKMDG HNEPBKBNNJC, EJAOLHODNHM KGCBKONHLJN, FBCLOKNPKEJ EOKDHHHKFCA, DHPFKNNCMAG CMHPIJJPCKD, PDLNAFEDLMM DOOJGIIHCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C43B90", Offset = "0x7C42390", VA = "0x187C43B90")]
	private static string IHLOPCCMKPJ(object PNHCNFOFAFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x9DECC0", Offset = "0x9DD4C0", VA = "0x1809DECC0")]
	private static long MLLLNJMCMKG()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	private static string KKONHMAHNOB(string NECPKEMHBDH, string? DKNLPKBPECP, bool INDBIEDPNAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
	private static bool HDKPLONEBEF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C43D60", Offset = "0x7C42560", VA = "0x187C43D60")]
	private static HHEIOGPIONG NOCJJFGBKEF()
	{
		return default(HHEIOGPIONG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface FIGNDOAGHFB
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LMFIGECAJPI HJMFLLMLOGL();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface LMFIGECAJPI : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool PKJNPIMLPAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOCGJDHOMAL();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KMJPBECDOKN<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IJPOBLPPPDM([In] T PGPJMFPAKOO);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void FJNOJOLGJID<T>([In] T MJAILKMLAHP);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct KMAJCCMGMJC<T> : IEquatable<KMAJCCMGMJC<T>>, KMJPBECDOKN<KMAJCCMGMJC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T GDCDOMLHCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int NHCKMLOFHLI;

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x27893A0", Offset = "0x2787BA0", VA = "0x1827893A0")]
	public KMAJCCMGMJC([In] T OPMIAMEJKDH, int FPEOONOJHML)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4F32F90", Offset = "0x4F31790", VA = "0x184F32F90")]
	public static bool NIDGPKKMDPO([In] KMAJCCMGMJC<T> HKAFAMHBCLL, [In] KMAJCCMGMJC<T> JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4F31D00", Offset = "0x4F30500", VA = "0x184F31D00", Slot = "4")]
	public bool Equals(KMAJCCMGMJC<T> PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4B7A5E0", Offset = "0x4B78DE0", VA = "0x184B7A5E0", Slot = "0")]
	public override bool Equals(object PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4F32A90", Offset = "0x4F31290", VA = "0x184F32A90")]
	public bool IJPOBLPPPDM([In] KMAJCCMGMJC<T> PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4F32870", Offset = "0x4F31070", VA = "0x184F32870", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4F33AF0", Offset = "0x4F322F0", VA = "0x184F33AF0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4F320F0", Offset = "0x4F308F0", VA = "0x184F320F0")]
	public void GBLJIMIKPOB([Out] T OPMIAMEJKDH, [Out] int FPEOONOJHML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4F32C40", Offset = "0x4F31440", VA = "0x184F32C40")]
	public (T, int) MMLMMKPFOCC()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4F32F40", Offset = "0x4F31740", VA = "0x184F32F40", Slot = "5")]
	private bool NGIPBGPFDHO([In] KMAJCCMGMJC<T> PGPJMFPAKOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JMPPBOFCGJC
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x380B4A0", Offset = "0x3809CA0", VA = "0x18380B4A0")]
	public static KMAJCCMGMJC<T> CJOJELENPLJ<T>([In] T OPMIAMEJKDH, int FPEOONOJHML) where T : notnull
	{
		return default(KMAJCCMGMJC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class EAMIBFPELFG
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x35F47E0", Offset = "0x35F2FE0", VA = "0x1835F47E0")]
	public static bool IJPOBLPPPDM<T, U>([In] T NFOGFJOGLPE, [In] U PNHCNFOFAFI) where T : notnull, KMJPBECDOKN<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult JNHEFCFBDAL<T, out TResult>([In] T MJAILKMLAHP);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FPKJCIHMIBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan NMPMHCFEMCA
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? CDHBAFBNBGO
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GIABKOFDCIF();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MCNEIFANLEE();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void HLPFPMIACMD();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct IGODEECKAHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly DPOCDIDPBLK MEOACKKAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly BKFFAGCGJDM KJCNDJOMCJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly DPOCDIDPBLK MAAJBNJILNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly BKFFAGCGJDM HDFBPAABJEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly DPOCDIDPBLK DGBIGAIBDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly BKFFAGCGJDM CKDEOKFBBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly ONCKHBNNHDK MEFDOICMLMH;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly DPOCDIDPBLK LANGPJKNHHP;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly BKFFAGCGJDM CKJENKONFBD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly DPOCDIDPBLK NBHEJJPKLEO;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly BKFFAGCGJDM FLHIDOIPDAD;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly DPOCDIDPBLK AAEPCICKHLB;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly BKFFAGCGJDM JIBNKFCBKPL;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly ONCKHBNNHDK HHLKJHLIIAK;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly IGODEECKAHO HMAILHHHNAA;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly DPOCDIDPBLK LAPCDGHKMDF;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool KBDBMNHHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x7C45400", Offset = "0x7C43C00", VA = "0x187C45400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xD44370", Offset = "0xD42B70", VA = "0x180D44370")]
	public IGODEECKAHO(DPOCDIDPBLK BBILDFMNCKE, BKFFAGCGJDM CKDMKGFFHNA, DPOCDIDPBLK IMDGMLJAONE, BKFFAGCGJDM DGPMLGBDINB, DPOCDIDPBLK NMDLHPCMAKK, BKFFAGCGJDM HLMHAHGIOME, ONCKHBNNHDK AKJPJEBMBOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
	private static bool ACCBPNEHAPH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void MMMMFMNJPGC(string NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
	private static bool AJEFEHOIJLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void POIAAGIJEJE(string NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA28A40", Offset = "0xA27240", VA = "0x180A28A40")]
	private static bool BDGKEMDHCEM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void MNEBMNHMJEE(string NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void IEJLBGNJMJE(Exception IIIACJLJMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x7C455E0", Offset = "0x7C43DE0", VA = "0x187C455E0")]
	private static IGODEECKAHO NOCJJFGBKEF()
	{
		return default(IGODEECKAHO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540")]
	private static bool AJFMFADMAJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x7C45320", Offset = "0x7C43B20", VA = "0x187C45320")]
	public void BAOGIJBMDME(object NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x7C45390", Offset = "0x7C43B90", VA = "0x187C45390")]
	public void JGDAAKEJEFJ(object NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x7C451D0", Offset = "0x7C439D0", VA = "0x187C451D0")]
	public void AMHNOMFECLM(object NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0xD441D0", Offset = "0xD429D0", VA = "0x180D441D0")]
	public void BMPPMADKLCJ(Exception IIIACJLJMAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7C45240", Offset = "0x7C43A40", VA = "0x187C45240")]
	public void AMHNOMFECLM(BDEMBBEOKCL NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x37E8E20", Offset = "0x37E7620", VA = "0x1837E8E20")]
	public void AMHNOMFECLM<T>(T MJAILKMLAHP, MPLFLFBFKNO<T> NJAAPDELBNN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x37E8FC0", Offset = "0x37E77C0", VA = "0x1837E8FC0")]
	public void BAOGIJBMDME<T>([In] T MJAILKMLAHP, PCOHKKLNOPM<T> NJAAPDELBNN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x37E8C80", Offset = "0x37E7480", VA = "0x1837E8C80")]
	public void AMHNOMFECLM<T>([In] T MJAILKMLAHP, PCOHKKLNOPM<T> NJAAPDELBNN) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7C45720", Offset = "0x7C43F20", VA = "0x187C45720")]
	public bool OOAABMLECBF(bool JEKEJINPKGE, string NJAAPDELBNN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct MINEABMMGIB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string GDCDOMLHCOE;

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE50", Offset = "0xCEC650", VA = "0x180CEDE50")]
	public MINEABMMGIB(string OPMIAMEJKDH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60")]
	public static string FGIKKMMHFBO([In] MINEABMMGIB NFOGFJOGLPE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x22459A0", Offset = "0x22441A0", VA = "0x1822459A0")]
	public static MINEABMMGIB FGIKKMMHFBO(string PGPJMFPAKOO)
	{
		return default(MINEABMMGIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7C473E0", Offset = "0x7C45BE0", VA = "0x187C473E0")]
	public string JHCGIPLJKBO(string HCBFCADAOMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7C47300", Offset = "0x7C45B00", VA = "0x187C47300")]
	public string EKBPPJOMGIK(object NAOCLOHDKMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0xCEDE60", Offset = "0xCEC660", VA = "0x180CEDE60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class JGOEKBEIPHI : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
	public JGOEKBEIPHI()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct OLONILFLODF : IEquatable<OLONILFLODF>
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9540", Offset = "0x9F7D40", VA = "0x1809F9540", Slot = "4")]
	public bool Equals(OLONILFLODF PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C49160", Offset = "0x7C47960", VA = "0x187C49160", Slot = "0")]
	public override bool Equals(object PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7C491B0", Offset = "0x7C479B0", VA = "0x187C491B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7C491C0", Offset = "0x7C479C0", VA = "0x187C491C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[ENFMKHMGDHB("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct PPKNIFNDLFA<T> : IEquatable<PPKNIFNDLFA<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T GDCDOMLHCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool JAANNBBJEIM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool JIHBNBFBBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x558EC10", Offset = "0x558D410", VA = "0x18558EC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x558F460", Offset = "0x558DC60", VA = "0x18558F460")]
	public PPKNIFNDLFA([In] T OPMIAMEJKDH, bool PABKHGDMMPM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x558E6B0", Offset = "0x558CEB0", VA = "0x18558E6B0")]
	public static bool NIDGPKKMDPO([In] PPKNIFNDLFA<T> HKAFAMHBCLL, [In] PPKNIFNDLFA<T> JAKFFJGMBEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x558D180", Offset = "0x558B980", VA = "0x18558D180", Slot = "4")]
	public bool Equals(PPKNIFNDLFA<T> PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x558D8E0", Offset = "0x558C0E0", VA = "0x18558D8E0", Slot = "0")]
	public override bool Equals(object? PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x558E1A0", Offset = "0x558C9A0", VA = "0x18558E1A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x558F020", Offset = "0x558D820", VA = "0x18558F020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class HCCEDNOHAPL
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x37A1670", Offset = "0x379FE70", VA = "0x1837A1670")]
	public static PPKNIFNDLFA<T> GMKBAMPOOMH<T>([In] T OPMIAMEJKDH) where T : notnull
	{
		return default(PPKNIFNDLFA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x37A1880", Offset = "0x37A0080", VA = "0x1837A1880")]
	public static PPKNIFNDLFA<T?> HAFACAFOGHA<T>()
	{
		return default(PPKNIFNDLFA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x37A1540", Offset = "0x379FD40", VA = "0x1837A1540")]
	public static bool BMDGMAMBBKB<T>([In] this PPKNIFNDLFA<T> NHKEHOKPNJC, [Out][NotNullWhen(true)] T OPMIAMEJKDH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x37A1500", Offset = "0x379FD00", VA = "0x1837A1500")]
	public static bool BMDGMAMBBKB<T>([In] this PPKNIFNDLFA<T> NHKEHOKPNJC, [Out][NotNullWhen(true)] T OPMIAMEJKDH, [Out] PPKNIFNDLFA<T> NFIKHPFJCPH) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x37A1980", Offset = "0x37A0180", VA = "0x1837A1980")]
	public static T? MDKIOKLLLMM<T>([In] this PPKNIFNDLFA<T> NHKEHOKPNJC, T? LHCNPHOLELG)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x37A19E0", Offset = "0x37A01E0", VA = "0x1837A19E0")]
	public static bool OOGBHNIHACD<T>([In] this PPKNIFNDLFA<T> NHKEHOKPNJC, T OPMIAMEJKDH) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LKIMJFMGDMF
{
	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x38877A0", Offset = "0x3885FA0", VA = "0x1838877A0")]
	public static T BMIFNCDPOIN<T>([In] this PPKNIFNDLFA<T> NHKEHOKPNJC) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct OFAPNEPKMDG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr EKHGDOJBNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr GMCKBCFMJNC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr JGCMPHBNFGH;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr MDMDEBJKHPM;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly OFAPNEPKMDG HMAILHHHNAA;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool KBDBMNHHFOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7C48670", Offset = "0x7C46E70", VA = "0x187C48670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0xA81780", Offset = "0xA7FF80", VA = "0x180A81780")]
	public OFAPNEPKMDG(IntPtr PONEKDNAKMK, IntPtr KEDFIGIOBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void IGOKMLLJKAP(string GLGOHIJMLFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0")]
	private static void NPLEFGDNHMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7C48740", Offset = "0x7C46F40", VA = "0x187C48740")]
	private static OFAPNEPKMDG NOCJJFGBKEF()
	{
		return default(OFAPNEPKMDG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct OBKEFBGMKBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr DLBNOAHOLHH;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0xEBA050", Offset = "0xEB8850", VA = "0x180EBA050")]
	private OBKEFBGMKBE(IntPtr KEDFIGIOBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7C484E0", Offset = "0x7C46CE0", VA = "0x187C484E0")]
	public void OCOBEACFBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C48400", Offset = "0x7C46C00", VA = "0x187C48400")]
	public static OBKEFBGMKBE CJOJELENPLJ(string GLGOHIJMLFB)
	{
		return default(OBKEFBGMKBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x275C4E0", Offset = "0x275ACE0", VA = "0x18275C4E0")]
	public static OBKEFBGMKBE CJOJELENPLJ([In] OFAPNEPKMDG HNEPBKBNNJC, string GLGOHIJMLFB)
	{
		return default(OBKEFBGMKBE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x275C320", Offset = "0x275AB20", VA = "0x18275C320")]
	public static OBKEFBGMKBE CJOJELENPLJ([In] OFAPNEPKMDG HNEPBKBNNJC, Func<string> GLGOHIJMLFB)
	{
		return default(OBKEFBGMKBE);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class BFFLOOAHOCB : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? ABOPBPFOMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr EIMAFPGAKJI;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool GADAAMAELED
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D8F0", Offset = "0x7C3C0F0", VA = "0x187C3D8F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D760", Offset = "0x7C3BF60", VA = "0x187C3D760")]
	public static SHA256 NKIHIDGHACP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D6F0", Offset = "0x7C3BEF0", VA = "0x187C3D6F0")]
	private static extern int MEICEEGPDIG();

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D7E0", Offset = "0x7C3BFE0", VA = "0x187C3D7E0")]
	private static extern IntPtr OCBPKHILMBM();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D3C0", Offset = "0x7C3BBC0", VA = "0x187C3D3C0")]
	private static extern void GCCPACPINBC(IntPtr EIMAFPGAKJI);

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D9E0", Offset = "0x7C3C1E0", VA = "0x187C3D9E0")]
	private static extern void PFABLGDMPMB(IntPtr EIMAFPGAKJI, byte[] NFNBKNAJBPN, int BFKGIFAKMAP, int BKMOJCCPOHD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D850", Offset = "0x7C3C050", VA = "0x187C3D850")]
	private static extern void OILGOHMMLNF(IntPtr EIMAFPGAKJI, byte[] OFIMBNAOOHA);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DAA0", Offset = "0x7C3C2A0", VA = "0x187C3DAA0")]
	private BFFLOOAHOCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D440", Offset = "0x7C3BC40", VA = "0x187C3D440", Slot = "18")]
	protected override void HashCore(byte[] CPIDEKBKOPO, int NJDFDBLAOIK, int DDPKBEHEFIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D500", Offset = "0x7C3BD00", VA = "0x187C3D500", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D630", Offset = "0x7C3BE30", VA = "0x187C3D630", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D330", Offset = "0x7C3BB30", VA = "0x187C3D330", Slot = "13")]
	protected override void Dispose(bool DBCKCNEHCEJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class HFPGLMCJKPL
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool OHMDGCDECLA<in TInput, TResult>(TInput JEOEDPICHHI, [Out] TResult HLPIAOANGMD);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class NBAECCJIEOG : FIGNDOAGHFB
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class NEMECMANDHM : LMFIGECAJPI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly NEMECMANDHM DJLOIKDDKCN;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool PKJNPIMLPAB
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x7C47870", Offset = "0x7C46070", VA = "0x187C47870", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7C478D0", Offset = "0x7C460D0", VA = "0x187C478D0", Slot = "6")]
			public void OnCompleted(Action BNCGMGHGIKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			public void KOCGJDHOMAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public NEMECMANDHM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly NBAECCJIEOG DJLOIKDDKCN;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		private NBAECCJIEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C47740", Offset = "0x7C45F40", VA = "0x187C47740", Slot = "4")]
		public LMFIGECAJPI HJMFLLMLOGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class KNPOOPNPMAL : FIGNDOAGHFB
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class AHEIOGDALLK : LMFIGECAJPI, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly AHEIOGDALLK DJLOIKDDKCN;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool PKJNPIMLPAB
			{
				[Cpp2IlInjected.Token(Token = "0x6000103")]
				[Cpp2IlInjected.Address(RVA = "0x7C3C690", Offset = "0x7C3AE90", VA = "0x187C3C690", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x7C3C6B0", Offset = "0x7C3AEB0", VA = "0x187C3C6B0", Slot = "6")]
			public void OnCompleted(Action BNCGMGHGIKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "5")]
			public void KOCGJDHOMAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
			public AHEIOGDALLK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly KNPOOPNPMAL DJLOIKDDKCN;

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		private KNPOOPNPMAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x7C46BA0", Offset = "0x7C453A0", VA = "0x187C46BA0", Slot = "4")]
		public LMFIGECAJPI HJMFLLMLOGL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class NHDODJOHJFG<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public NHDODJOHJFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x43D5C50", Offset = "0x43D4450", VA = "0x1843D5C50")]
		internal void LMADLBIBDHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class GJBLCCKEMOM<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GJBLCCKEMOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x495B250", Offset = "0x4959A50", VA = "0x18495B250")]
		internal void LLDBHMGDCON(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct KCJPLDIGCFB : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x7C46A40", Offset = "0x7C45240", VA = "0x187C46A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct KPEBECOILPJ : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x7C46C60", Offset = "0x7C45460", VA = "0x187C46C60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA2F200", Offset = "0xA2DA00", VA = "0x180A2F200", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct DOLJLPNJBKD<TException> : IAsyncStateMachine where TException : notnull, Exception
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

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x68EB570", Offset = "0x68E9D70", VA = "0x1868EB570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x68EB6E0", Offset = "0x68E9EE0", VA = "0x1868EB6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct BPEAJPNDHJF<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6017A40", Offset = "0x6016240", VA = "0x186017A40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6018290", Offset = "0x6016A90", VA = "0x186018290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct HCJBMADGBOA : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x7C40EC0", Offset = "0x7C3F6C0", VA = "0x187C40EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x7C410D0", Offset = "0x7C3F8D0", VA = "0x187C410D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class EAGKHHMPKAL<T> where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public EAGKHHMPKAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x43D5C50", Offset = "0x43D4450", VA = "0x1843D5C50")]
		internal void CJCAJDFPJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x43D5BD0", Offset = "0x43D43D0", VA = "0x1843D5BD0")]
		internal void AIEBHLGILKE(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private struct OAJGKKCKLDP<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public OHMDGCDECLA<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x54588C0", Offset = "0x54570C0", VA = "0x1854588C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5458FD0", Offset = "0x54577D0", VA = "0x185458FD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct OHLIAIJJDGH : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C48910", Offset = "0x7C47110", VA = "0x187C48910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x7C49100", Offset = "0x7C47900", VA = "0x187C49100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct NLGHAGFJJGF : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x7C47DB0", Offset = "0x7C465B0", VA = "0x187C47DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x7C482F0", Offset = "0x7C46AF0", VA = "0x187C482F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct IOHBOEFGFGN<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4B891D0", Offset = "0x4B879D0", VA = "0x184B891D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4A5C960", Offset = "0x4A5B160", VA = "0x184A5C960", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class BOAMCJLNDLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public TaskCompletionSource<OLONILFLODF> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public BOAMCJLNDLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x7C3ED40", Offset = "0x7C3D540", VA = "0x187C3ED40")]
		internal void EEKNIAANIOF(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct IJGFOHKBCHM<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x4B79DD0", Offset = "0x4B785D0", VA = "0x184B79DD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x3FD9AD0", Offset = "0x3FD82D0", VA = "0x183FD9AD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct OCLPKCGINHE<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x545B0A0", Offset = "0x54598A0", VA = "0x18545B0A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8B80", Offset = "0x3FD7380", VA = "0x183FD8B80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct MOKOMPGMFAC<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x5298220", Offset = "0x5296A20", VA = "0x185298220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x5299120", Offset = "0x5297920", VA = "0x185299120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct HEHAOPEOHCI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7C41140", Offset = "0x7C3F940", VA = "0x187C41140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7C41320", Offset = "0x7C3FB20", VA = "0x187C41320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct AMKPKCFOBPN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x7C3C770", Offset = "0x7C3AF70", VA = "0x187C3C770", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CAD0", Offset = "0x7C3B2D0", VA = "0x187C3CAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct LDNLMGEKEDK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7C46D70", Offset = "0x7C45570", VA = "0x187C46D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C47060", Offset = "0x7C45860", VA = "0x187C47060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class GLLAEGMLCDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GLLAEGMLCDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x7C40840", Offset = "0x7C3F040", VA = "0x187C40840")]
		internal Task DEAIKFJJHCI(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct HPMDLMNAOPG : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7C44F10", Offset = "0x7C43710", VA = "0x187C44F10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C45170", Offset = "0x7C43970", VA = "0x187C45170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private struct FJMCLIPDFLM : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x7C400B0", Offset = "0x7C3E8B0", VA = "0x187C400B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x7C40290", Offset = "0x7C3EA90", VA = "0x187C40290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct FLKMDNNBGNC : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x7C40360", Offset = "0x7C3EB60", VA = "0x187C40360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7C406C0", Offset = "0x7C3EEC0", VA = "0x187C406C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct JCBPEJNIPMN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7C466F0", Offset = "0x7C44EF0", VA = "0x187C466F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x7C469E0", Offset = "0x7C451E0", VA = "0x187C469E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class HFHDNCBDLMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HFHDNCBDLMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x7C41710", Offset = "0x7C3FF10", VA = "0x187C41710")]
		internal Task NAOMNGJCDOD(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct NGJNDLJCPCI : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x7C47AF0", Offset = "0x7C462F0", VA = "0x187C47AF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x7C47D50", Offset = "0x7C46550", VA = "0x187C47D50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private struct HFJNJCCMLEN : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C41780", Offset = "0x7C3FF80", VA = "0x187C41780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x7C41900", Offset = "0x7C40100", VA = "0x187C41900", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct HPGLBNEKJFC<T> : IAsyncStateMachine where T : notnull
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

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4A9F0B0", Offset = "0x4A9D8B0", VA = "0x184A9F0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x4A9F5D0", Offset = "0x4A9DDD0", VA = "0x184A9F5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct HFBDABDGDCP : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x7C41380", Offset = "0x7C3FB80", VA = "0x187C41380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x7C416B0", Offset = "0x7C3FEB0", VA = "0x187C416B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? BIACFFNJBCJ;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<OLONILFLODF> MHINBLKFCIE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task AOCOMEINDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x7C42150", Offset = "0x7C40950", VA = "0x187C42150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7C41A10", Offset = "0x7C40210", VA = "0x187C41A10")]
	public static bool BDMONOHLJKE(this Task BFOIMBMKJIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37B16D0", Offset = "0x37AFED0", VA = "0x1837B16D0")]
	public static Task<T> GMHOIKLDDCH<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C43880", Offset = "0x7C42080", VA = "0x187C43880")]
	public static Task PIMBIMDMOMI(this Task BFOIMBMKJIA, CancellationToken JILOCOLKOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37B4840", Offset = "0x37B3040", VA = "0x1837B4840")]
	public static Task<TResult> PIMBIMDMOMI<TResult>(this Task<TResult> BFOIMBMKJIA, CancellationToken JILOCOLKOMJ) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x37B54E0", Offset = "0x37B3CE0", VA = "0x1837B54E0")]
	public static TaskCompletionSource<TResult> PIMBIMDMOMI<TResult>(this TaskCompletionSource<TResult> INGEFKPJIKN, CancellationToken JILOCOLKOMJ) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7C431B0", Offset = "0x7C419B0", VA = "0x187C431B0")]
	public static IDisposable? MKLEOPMCAON(CancellationToken JGPECLOCAEL, CancellationToken LJMJDKGOOAG, [Out] CancellationToken PIPFMGMCEGJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7C41960", Offset = "0x7C40160", VA = "0x187C41960")]
	[AsyncStateMachine(typeof(KCJPLDIGCFB))]
	public static void ADCJNLMACGA(this Task NACLDKPPPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7C42C90", Offset = "0x7C41490", VA = "0x187C42C90")]
	[AsyncStateMachine(typeof(KPEBECOILPJ))]
	public static void GEJHKBFILDC(this Task NACLDKPPPKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x37B1420", Offset = "0x37AFC20", VA = "0x1837B1420")]
	[AsyncStateMachine(typeof(DOLJLPNJBKD<>))]
	public static Task DHOOFMPDEPP<TException>(this Task NACLDKPPPKG) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x37B1850", Offset = "0x37B0050", VA = "0x1837B1850")]
	[AsyncStateMachine(typeof(BPEAJPNDHJF<>))]
	public static Task<T> GMLGOIKENAF<T>(this Task<T> NFOGFJOGLPE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7C424C0", Offset = "0x7C40CC0", VA = "0x187C424C0")]
	[AsyncStateMachine(typeof(HCJBMADGBOA))]
	public static Task<TaskStatus> FBLKOOOJHCH(this Task? NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x37B1A30", Offset = "0x37B0230", VA = "0x1837B1A30")]
	public static (Task<T?>?, Action<T?>?) OCGCJMHBAAB<T>([Optional] CancellationToken DNHBNMHIDAC)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x37B0D20", Offset = "0x37AF520", VA = "0x1837B0D20")]
	[AsyncStateMachine(typeof(OAJGKKCKLDP<, >))]
	public static Task<List<TResult>> BAKOCOIEGGF<TResult, TInput>(this Task<List<TInput>> BFOIMBMKJIA, OHMDGCDECLA<TInput, TResult> BJBGHGGGIBB) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7C42E10", Offset = "0x7C41610", VA = "0x187C42E10")]
	[AsyncStateMachine(typeof(OHLIAIJJDGH))]
	public static Task IMMAGDPLKOM(Task NACLDKPPPKG, CancellationToken HPBFCDCKFAO, Func<CancellationToken, Task> ACKAMLPDEOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C43460", Offset = "0x7C41C60", VA = "0x187C43460")]
	[AsyncStateMachine(typeof(NLGHAGFJJGF))]
	public static Task OJJBOBDBOEN(Func<CancellationToken, Task> FMJKHBAJLOP, TimeSpan GCGADGABLMH, [Optional] CancellationToken HPBFCDCKFAO, [Optional] Action<OperationCanceledException>? ECEMCCFGBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x37B1CB0", Offset = "0x37B04B0", VA = "0x1837B1CB0")]
	[AsyncStateMachine(typeof(IOHBOEFGFGN<>))]
	public static Task<T> OJJBOBDBOEN<T>(Func<CancellationToken, Task<T>> FMJKHBAJLOP, TimeSpan GCGADGABLMH, [Optional] CancellationToken HPBFCDCKFAO, [Optional] Func<OperationCanceledException, T>? ECEMCCFGBPM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C42100", Offset = "0x7C40900", VA = "0x187C42100")]
	public static Task BOMKFNEHGDD(params Task[] FKPJHMKDBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x7C41C40", Offset = "0x7C40440", VA = "0x187C41C40")]
	public static Task BOMKFNEHGDD(IEnumerable<Task> FKPJHMKDBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x37B15E0", Offset = "0x37AFDE0", VA = "0x1837B15E0")]
	[AsyncStateMachine(typeof(IJGFOHKBCHM<>))]
	public static Task<IEnumerable<Task<T>>> EHMNEFBCLEK<T>(IEnumerable<Task<T>> FKPJHMKDBCC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x37B12F0", Offset = "0x37AFAF0", VA = "0x1837B12F0")]
	[AsyncStateMachine(typeof(OCLPKCGINHE<, , >))]
	public static Task<(T1, T2, T3)> COAHEHHKNEJ<T1, T2, T3>(Task<T1> JEPIDIPHMIL, Task<T2> MMMKEIOICLP, Task<T3> AJBLKHMLGBN) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x37B1010", Offset = "0x37AF810", VA = "0x1837B1010")]
	[AsyncStateMachine(typeof(MOKOMPGMFAC<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> COAHEHHKNEJ<T1, T2, T3, T4, T5>(Task<T1> JEPIDIPHMIL, Task<T2> MMMKEIOICLP, Task<T3> AJBLKHMLGBN, Task<T4> INBNFNGHFBJ, Task<T5> FCHECGDCEEM) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7C41B50", Offset = "0x7C40350", VA = "0x187C41B50")]
	[AsyncStateMachine(typeof(HEHAOPEOHCI))]
	public static Task BGCGJFKEPKP(Func<bool> JEKEJINPKGE, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7C41A40", Offset = "0x7C40240", VA = "0x187C41A40")]
	[AsyncStateMachine(typeof(AMKPKCFOBPN))]
	public static Task BGCGJFKEPKP(Func<bool> JEKEJINPKGE, TimeSpan BLMGPFMGCDE, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x7C43750", Offset = "0x7C41F50", VA = "0x187C43750")]
	[AsyncStateMachine(typeof(LDNLMGEKEDK))]
	public static Task ONGMFNJEDEK(Func<bool> JEKEJINPKGE, TimeSpan GCGADGABLMH, [Optional] CancellationToken DNHBNMHIDAC, [Optional] Action<OperationCanceledException>? ECEMCCFGBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x7C43610", Offset = "0x7C41E10", VA = "0x187C43610")]
	[AsyncStateMachine(typeof(HPMDLMNAOPG))]
	public static Task ONGMFNJEDEK(Func<bool> JEKEJINPKGE, TimeSpan GCGADGABLMH, TimeSpan BLMGPFMGCDE, [Optional] CancellationToken DNHBNMHIDAC, [Optional] Action<OperationCanceledException>? ECEMCCFGBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x7C426C0", Offset = "0x7C40EC0", VA = "0x187C426C0")]
	[AsyncStateMachine(typeof(FJMCLIPDFLM))]
	public static Task FMGDIAPFJEI(Func<bool> JEKEJINPKGE, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x7C425B0", Offset = "0x7C40DB0", VA = "0x187C425B0")]
	[AsyncStateMachine(typeof(FLKMDNNBGNC))]
	public static Task FMGDIAPFJEI(Func<bool> JEKEJINPKGE, TimeSpan BLMGPFMGCDE, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x7C43080", Offset = "0x7C41880", VA = "0x187C43080")]
	[AsyncStateMachine(typeof(JCBPEJNIPMN))]
	public static Task MDKLLJGBKLJ(Func<bool> JEKEJINPKGE, TimeSpan GCGADGABLMH, [Optional] CancellationToken DNHBNMHIDAC, [Optional] Action<OperationCanceledException>? ECEMCCFGBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C42F40", Offset = "0x7C41740", VA = "0x187C42F40")]
	[AsyncStateMachine(typeof(NGJNDLJCPCI))]
	public static Task MDKLLJGBKLJ(Func<bool> JEKEJINPKGE, TimeSpan GCGADGABLMH, TimeSpan BLMGPFMGCDE, [Optional] CancellationToken DNHBNMHIDAC, [Optional] Action<OperationCanceledException>? ECEMCCFGBPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x7C421C0", Offset = "0x7C409C0", VA = "0x187C421C0")]
	[Obsolete]
	[AsyncStateMachine(typeof(HFJNJCCMLEN))]
	public static Task CIAMBMNCJFD(this Task BFOIMBMKJIA, Action GEFHGNNLJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x37B0E30", Offset = "0x37AF630", VA = "0x1837B0E30")]
	[AsyncStateMachine(typeof(HPGLBNEKJFC<>))]
	[Obsolete]
	public static Task CIAMBMNCJFD<T>(this Task<T> BFOIMBMKJIA, Action<T> GEFHGNNLJOC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x7C422B0", Offset = "0x7C40AB0", VA = "0x187C422B0")]
	private static void DLIFGICMJLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x7C42930", Offset = "0x7C41130", VA = "0x187C42930")]
	public static bool GCNAFJCPAHH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x7C427B0", Offset = "0x7C40FB0", VA = "0x187C427B0")]
	private static void GBHOCOEJACG(SynchronizationContext OPMIAMEJKDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x7C423B0", Offset = "0x7C40BB0", VA = "0x187C423B0")]
	private static void EOELIBANABH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x7C42D40", Offset = "0x7C41540", VA = "0x187C42D40")]
	public static void ILMEBOEHLEA([Optional] string? NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x7C43590", Offset = "0x7C41D90", VA = "0x187C43590")]
	public static void OMHEMGFOIEI([Optional] string? NJAAPDELBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x7C42360", Offset = "0x7C40B60", VA = "0x187C42360")]
	public static FIGNDOAGHFB ECNGFFOIHAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x7C43410", Offset = "0x7C41C10", VA = "0x187C43410")]
	public static FIGNDOAGHFB NOFNFKCKNIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x7C43340", Offset = "0x7C41B40", VA = "0x187C43340")]
	[AsyncStateMachine(typeof(HFBDABDGDCP))]
	public static Task MOENEFDDPAO(Func<Task> JPLDGHHMNAI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class DBBJMDENMLB : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
	public DBBJMDENMLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public static class LMNPOPFJABK
{
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x7C470C0", Offset = "0x7C458C0", VA = "0x187C470C0")]
	public static bool FMHOIPAKMOE(this GIBKPHCLPMP NCEGKIPAPPN, DateTime EMFNLFEAEHH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x7C471E0", Offset = "0x7C459E0", VA = "0x187C471E0")]
	public static TimeSpan FOABCEFHJEN(this GIBKPHCLPMP NCEGKIPAPPN, DateTime EMFNLFEAEHH)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CHACMIIGJKP : GIBKPHCLPMP
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public static readonly GIBKPHCLPMP DJLOIKDDKCN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime MOPBMCFHOCM
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EEB0", Offset = "0x7C3D6B0", VA = "0x187C3EEB0", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset JHBEFLHNLCE
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C3EE50", Offset = "0x7C3D650", VA = "0x187C3EE50", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public CHACMIIGJKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public interface GIBKPHCLPMP
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime MOPBMCFHOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset JHBEFLHNLCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class BDNDEFOHKHH
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long KHJHOFBIILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CB30", Offset = "0x7C3B330", VA = "0x187C3CB30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long BGLMGEBCFCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CF50", Offset = "0x7C3B750", VA = "0x187C3CF50")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double JLCCIPOOGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CE20", Offset = "0x7C3B620", VA = "0x187C3CE20")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double BAFDHHJOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CF00", Offset = "0x7C3B700", VA = "0x187C3CF00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double PMDNCAGJFLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x7C3CC70", Offset = "0x7C3B470", VA = "0x187C3CC70")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double CFBFLGPCIBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x7C3D040", Offset = "0x7C3B840", VA = "0x187C3D040")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CE70", Offset = "0x7C3B670", VA = "0x187C3CE70")]
	public static double KGJCNFNGNOB(long BMNEAPGJPNI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CFA0", Offset = "0x7C3B7A0", VA = "0x187C3CFA0")]
	public static double NFLANJOBGEF(long BMNEAPGJPNI)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CCC0", Offset = "0x7C3B4C0", VA = "0x187C3CCC0")]
	public static double IEEFJKNKGEP(double ONDBAKNJDLN)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CB80", Offset = "0x7C3B380", VA = "0x187C3CB80")]
	public static long AGLGDGIHHLA(long FOLPOAMFDOE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3D030", Offset = "0x7C3B830", VA = "0x187C3D030")]
	public static long NKNEMJOLIHE(long PNEDOJIAHEJ, long EKPCOCCFPHK)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CD50", Offset = "0x7C3B550", VA = "0x187C3CD50")]
	public static double IENGGBPOEFP(long PNEDOJIAHEJ, long EKPCOCCFPHK)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3CC10", Offset = "0x7C3B410", VA = "0x187C3CC10")]
	public static double GNAMCMKONLG(long PNEDOJIAHEJ, long EKPCOCCFPHK)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public sealed class ECDJGCMADPL : FPKJCIHMIBK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public static readonly TimeSpan PKFMONCEBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly System.Timers.Timer NIBJMJJGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private TimeSpan GCGADGABLMH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan NMPMHCFEMCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x9DF730", Offset = "0x9DDF30", VA = "0x1809DF730", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x7C3F220", Offset = "0x7C3DA20", VA = "0x187C3F220", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? CDHBAFBNBGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9DF710", Offset = "0x9DDF10", VA = "0x1809DF710", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9DF720", Offset = "0x9DDF20", VA = "0x1809DF720", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F5B0", Offset = "0x7C3DDB0", VA = "0x187C3F5B0")]
	[Preserve]
	public ECDJGCMADPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F610", Offset = "0x7C3DE10", VA = "0x187C3F610")]
	public ECDJGCMADPL(TimeSpan GCGADGABLMH, [Optional] Action? OJEHEFHAIKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F380", Offset = "0x7C3DB80", VA = "0x187C3F380", Slot = "7")]
	public void GIABKOFDCIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F4D0", Offset = "0x7C3DCD0", VA = "0x187C3F4D0", Slot = "8")]
	public void MCNEIFANLEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F410", Offset = "0x7C3DC10", VA = "0x187C3F410", Slot = "9")]
	public void HLPFPMIACMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x1107FE0", Offset = "0x11067E0", VA = "0x181107FE0")]
	private void HPNABGEAEIJ(object LDIOMGMJIGF, ElapsedEventArgs NPMADJKPEII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F440", Offset = "0x7C3DC40", VA = "0x187C3F440")]
	private static void KJIDGBOJDPN(TimeSpan KAEKAGGLOMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F180", Offset = "0x7C3D980", VA = "0x187C3F180", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class ENFMKHMGDHB : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public readonly string? FFMOLMBIDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public readonly string NJJPEPDLCHL;

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x757F700", Offset = "0x757DF00", VA = "0x18757F700")]
	public ENFMKHMGDHB(string NIAMDMBDIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4AF2C80", Offset = "0x4AF1480", VA = "0x184AF2C80")]
	public ENFMKHMGDHB(string LEKFEHEMONH, string NIAMDMBDIJG)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000060")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct BJMMIOLMFDK : IEquatable<BJMMIOLMFDK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public uint KAEDMGDKLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public int EHPCJBFMGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public float BINIJEICDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public ushort IBLNHNFKLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public ushort FLIFFEFFBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public short HKDLCEIGCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public short PJEMKDEGKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public char ABJECKHKEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public char HFNCEBIILKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public byte KLGIIBGMCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public byte FHAAFHOLCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public byte GPEABHEFCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public byte BLMBFNJJALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public bool PPMNKCAOJMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool PLAFDIIPGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public bool DAHMKAOMLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public bool JMAMNBNNEHF;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CD20", Offset = "0x1E1B520", VA = "0x181E1CD20")]
	public static BJMMIOLMFDK MAMGNFBJKGM(uint DEFBMOABAAO)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1E1CD20", Offset = "0x1E1B520", VA = "0x181E1CD20")]
	public static BJMMIOLMFDK HEOMHCHNPJD(int NPCPHAAALNN)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DEC0", Offset = "0x7C3C6C0", VA = "0x187C3DEC0")]
	public static BJMMIOLMFDK CBMBGCDEONM(float HFNCEAFHCPB)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DEA0", Offset = "0x7C3C6A0", VA = "0x187C3DEA0")]
	public static BJMMIOLMFDK PCMPGAPDLIF(byte HOCPBADODMP, byte DKIJADEOIIC, byte INMHOIDAGOA, byte BKODEGCGGEH)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DEA0", Offset = "0x7C3C6A0", VA = "0x187C3DEA0")]
	public static BJMMIOLMFDK HJFHECPCLFE(bool LIEIFIDMFLN, bool JMBMFCODDMI, bool JKPDPLIHLOM, bool OEHAOCOJAFC)
	{
		return default(BJMMIOLMFDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DEA0", Offset = "0x7C3C6A0", VA = "0x187C3DEA0")]
	public static BJMMIOLMFDK ABCMFOKNEPO(byte LEOMDIBOEPN, byte CBFBABPFKMF, byte KLADIBGJCOE, byte AILPHFEDIOE)
	{
		return default(BJMMIOLMFDK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x210E590", Offset = "0x210CD90", VA = "0x18210E590")]
	public static bool NIDGPKKMDPO(BJMMIOLMFDK ANGFJALIIBO, BJMMIOLMFDK LNEMONKDKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x210E570", Offset = "0x210CD70", VA = "0x18210E570", Slot = "4")]
	public bool Equals(BJMMIOLMFDK PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DED0", Offset = "0x7C3C6D0", VA = "0x187C3DED0", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x1295300", Offset = "0x1293B00", VA = "0x181295300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7C3DF50", Offset = "0x7C3C750", VA = "0x187C3DF50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000061")]
public struct HAJELLNALOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ulong PFMCDILBFIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public long CHBNOFELFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public double OPLNICCNIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public uint EEBBJCELJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public uint IGBANJPILOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public int NPIODNKODIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public int JJCAOJFGENA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public float OLCNMNKJILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public float NBPDPCKMOCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public ushort IBLNHNFKLND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public ushort FLIFFEFFBDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public ushort IFGCKHLIJFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public ushort DIACBADIFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public short HKDLCEIGCGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public short PJEMKDEGKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public short HBEGOOEEDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public short CDNDLMDCDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public char ABJECKHKEGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public char HFNCEBIILKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public char CKIJPHBOOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public char MDAEHJPDHEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public byte KLGIIBGMCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public byte FHAAFHOLCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public byte GPEABHEFCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public byte BLMBFNJJALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public byte MIMNCINGLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public byte NFJDJEAOOEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public byte OHENIDJANMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public byte LCGGPOFHEEH;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static HAJELLNALOI CJOJELENPLJ(long LGOPMNBCGJB)
	{
		return default(HAJELLNALOI);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x7C408B0", Offset = "0x7C3F0B0", VA = "0x187C408B0")]
	public static HAJELLNALOI CJOJELENPLJ(byte HOCPBADODMP, byte DKIJADEOIIC, byte INMHOIDAGOA, byte BKODEGCGGEH, byte OEDALOKKEFF, byte KLKECDILHIL, byte GOLFFDHMGNP, byte LNOKIBCCOML)
	{
		return default(HAJELLNALOI);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct NADMIJNJMMC : IEquatable<NADMIJNJMMC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public byte PEGKCBGEBGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool AIHKJPKJOJA;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x2DD9C60", Offset = "0x2DD8460", VA = "0x182DD9C60")]
	public static NADMIJNJMMC PCMPGAPDLIF(byte BECHHLHIADO)
	{
		return default(NADMIJNJMMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD9C60", Offset = "0x2DD8460", VA = "0x182DD9C60")]
	public static NADMIJNJMMC HJFHECPCLFE(bool CONKKDIPCHA)
	{
		return default(NADMIJNJMMC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7C474D0", Offset = "0x7C45CD0", VA = "0x187C474D0")]
	public static bool NIDGPKKMDPO(NADMIJNJMMC ANGFJALIIBO, NADMIJNJMMC LNEMONKDKMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5880", Offset = "0x6BE4080", VA = "0x186BE5880", Slot = "4")]
	public bool Equals(NADMIJNJMMC PGPJMFPAKOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7C47430", Offset = "0x7C45C30", VA = "0x187C47430", Slot = "0")]
	public override bool Equals(object PNHCNFOFAFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7C474C0", Offset = "0x7C45CC0", VA = "0x187C474C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7C474E0", Offset = "0x7C45CE0", VA = "0x187C474E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PJHIIAMIIMJ<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public readonly T ACIAFDPLJDM;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x55696A0", Offset = "0x5567EA0", VA = "0x1855696A0")]
	public PJHIIAMIIMJ(T DDFMFNDPJPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public static class CILDDFJLFHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3590020", Offset = "0x358E820", VA = "0x183590020")]
	public static IEnumerable<T> LGNEOFGOJOP<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static T[] HBPIKJLMDPI<T>(params T[] DLLDMFPEOGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0xC627A0", Offset = "0xC60FA0", VA = "0x180C627A0")]
	public static IEnumerable<T> MMBLPPLAMID<T>(params T[] DLLDMFPEOGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x358FF90", Offset = "0x358E790", VA = "0x18358FF90")]
	public static HashSet<T> PNKCNBMLMKL<T>(params T[] DLLDMFPEOGK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x358FEA0", Offset = "0x358E6A0", VA = "0x18358FEA0")]
	public static KeyValuePair<TKey, TValue> BKFBAALPDIL<TKey, TValue>([In] TKey BELIEAFHDAH, [In] TValue OPMIAMEJKDH) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x358FF90", Offset = "0x358E790", VA = "0x18358FF90")]
	public static List<T> EEOBBMLOLAB<T>(IEnumerable<T> ECFHLCJLIHE) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[AttributeUsage(AttributeTargets.All)]
public sealed class OKIIAHNJPLO : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public readonly string BKJOBAOJHEM;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
	public OKIIAHNJPLO(string FCJOOPHGPGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public delegate object PCOHKKLNOPM<T>([In] T FHMAIKMLNLH);
[Cpp2IlInjected.Token(Token = "0x2000067")]
public delegate object MPLFLFBFKNO<T>(T FHMAIKMLNLH);
[Cpp2IlInjected.Token(Token = "0x2000068")]
[LGOONGJINIG]
public delegate string DHPFKNNCMAG(string NECPKEMHBDH, string? DKNLPKBPECP, bool INDBIEDPNAL);
[Cpp2IlInjected.Token(Token = "0x2000069")]
[LGOONGJINIG]
public delegate void BKFFAGCGJDM(string NJAAPDELBNN);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[LGOONGJINIG]
public delegate void ONCKHBNNHDK(Exception IIIACJLJMAE);
[Cpp2IlInjected.Token(Token = "0x200006B")]
public delegate object BDEMBBEOKCL();
[Cpp2IlInjected.Token(Token = "0x200006C")]
[LGOONGJINIG]
public delegate bool DPOCDIDPBLK();
[Cpp2IlInjected.Token(Token = "0x200006D")]
[LGOONGJINIG]
public delegate string EJAOLHODNHM(object PNHCNFOFAFI);
[Cpp2IlInjected.Token(Token = "0x200006E")]
[AttributeUsage(AttributeTargets.Enum)]
public class OMJAMKCKKID : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
	public OMJAMKCKKID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class FAIDPLKHNKL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CompilerGenerated]
	private struct IILFJKNPBNK : IAsyncStateMachine
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

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x7C45DA0", Offset = "0x7C445A0", VA = "0x187C45DA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x7C46680", Offset = "0x7C44E80", VA = "0x187C46680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly TimerCallback BDAEAKAJJBB;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly Action<object?> EKFJDMJLNLP;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7C3FAB0", Offset = "0x7C3E2B0", VA = "0x187C3FAB0")]
	public static Task<bool> KMMAOPANDOK(int KKDLJFHAHHH, [Optional] CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F980", Offset = "0x7C3E180", VA = "0x187C3F980")]
	[AsyncStateMachine(typeof(IILFJKNPBNK))]
	private static Task<bool> JJCDNMGPKNP(int KKDLJFHAHHH, CancellationToken DNHBNMHIDAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F860", Offset = "0x7C3E060", VA = "0x187C3F860")]
	private static void BEBPGNCLMNK(object? LLNIPANPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x7C3F8F0", Offset = "0x7C3E0F0", VA = "0x187C3F8F0")]
	private static void HNDFCHJPOFE(object? LLNIPANPIOA)
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
