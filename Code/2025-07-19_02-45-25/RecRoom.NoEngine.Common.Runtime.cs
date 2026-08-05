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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x82DA7E0", Offset = "0x82D97E0", VA = "0x1882DA7E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BMDJCHIMDBN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x82D0470", Offset = "0x82CF470", VA = "0x1882D0470")]
	public static string FDBNBOEKDCK(this Encoding MBOPBMHOEMD, [In] ReadOnlySequence<byte> ODOOLGJOBIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x39D8FE0", Offset = "0x39D7FE0", VA = "0x1839D8FE0")]
	private static void LENAJOLHFCL<T>(this ReadOnlySequence<T> DJMNHAGBIMA, [Out] ReadOnlySpan<T> PLKEIHBAPII, [Out] SequencePosition OMMNLCHPNAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
public sealed class KJELKHNGAFN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x82D99E0", Offset = "0x82D89E0", VA = "0x1882D99E0")]
	public KJELKHNGAFN(bool JIFFOEOAAEF, string HJCMOPOBLHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x82D9990", Offset = "0x82D8990", VA = "0x1882D9990")]
	public KJELKHNGAFN(bool JIFFOEOAAEF, params string[] OHBNKPADDCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LDHMBDNIAIP
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ECCMHKLACIA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CMGLIGKCKHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MBEFICHEHCC(string DAKIIEIEKNI, double IOALKPFEKEK, [Optional] string? OFOKMOCFKNF);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EPLGHBPHPCF : FLMKDPCDNGH, IDLNMAOMLDM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int DALOBBDOBEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Queue<double> NOKIMPNELGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private double IEGNAFDKBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private double EOMGFLMBKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private double PMEPAGPGFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int IJOGGJJHLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private double FIBLFJNPLOH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BOAKGKOEGPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA7E570", Offset = "0xA7D570", VA = "0x180A7E570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double MELGAPDCIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82D51D0", Offset = "0x82D41D0", VA = "0x1882D51D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double ECLJKCAFJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x50C8B40", Offset = "0x50C7B40", VA = "0x1850C8B40", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double MICMCNJLBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x29A2C40", Offset = "0x29A1C40", VA = "0x1829A2C40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x82D54D0", Offset = "0x82D44D0", VA = "0x1882D54D0")]
	public EPLGHBPHPCF(int GGPGEJDAOGO, double FIBLFJNPLOH = 0.0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x82D52A0", Offset = "0x82D42A0", VA = "0x1882D52A0", Slot = "7")]
	public void BJEPEOIMLPF(double GHNFCHHGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x82D5230", Offset = "0x82D4230", VA = "0x1882D5230", Slot = "8")]
	public void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x82D53D0", Offset = "0x82D43D0", VA = "0x1882D53D0", Slot = "9")]
	public object Clone()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public class HNDPDIHGHNJ : FLMKDPCDNGH, IDLNMAOMLDM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private long MFFPIAPMHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private double NLLHCILNDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private double PLENHBMIACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private double GNPFNGFNFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private double EDACFODHEDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private double IEGNAFDKBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private double EOMGFLMBKFN;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long JHCCKPLGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double ECLJKCAFJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74C4940", Offset = "0x74C3940", VA = "0x1874C4940", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MICMCNJLBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74C4DD0", Offset = "0x74C3DD0", VA = "0x1874C4DD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double GOEGLDAPKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x74C4910", Offset = "0x74C3910", VA = "0x1874C4910")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double MELGAPDCIKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x313CE30", Offset = "0x313BE30", VA = "0x18313CE30", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x82D6F80", Offset = "0x82D5F80", VA = "0x1882D6F80", Slot = "10")]
	public virtual void BJEPEOIMLPF(double GHNFCHHGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x82D6F40", Offset = "0x82D5F40", VA = "0x1882D6F40", Slot = "11")]
	public virtual void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x82D70A0", Offset = "0x82D60A0", VA = "0x1882D70A0", Slot = "9")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x82D0200", Offset = "0x82CF200", VA = "0x1882D0200")]
	public HNDPDIHGHNJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class BKOCIOIHOKL : HNDPDIHGHNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double EGCGOBCOANH
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x74C4970", Offset = "0x74C3970", VA = "0x1874C4970")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x74C49A0", Offset = "0x74C39A0", VA = "0x1874C49A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x82D00D0", Offset = "0x82CF0D0", VA = "0x1882D00D0", Slot = "10")]
	public override void BJEPEOIMLPF(double GHNFCHHGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x82D0090", Offset = "0x82CF090", VA = "0x1882D0090", Slot = "11")]
	public override void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x82D0200", Offset = "0x82CF200", VA = "0x1882D0200")]
	public BKOCIOIHOKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FLMKDPCDNGH : IDLNMAOMLDM, ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double MELGAPDCIKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double ECLJKCAFJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double MICMCNJLBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class NDFNIIADMBD : IDLNMAOMLDM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private double DMCJADOLDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private double EDBGNBMIDMH;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public double BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x82D9C50", Offset = "0x82D8C50", VA = "0x1882D9C50")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F17310", Offset = "0x6F16310", VA = "0x186F17310", Slot = "4")]
	public void BJEPEOIMLPF(double GHNFCHHGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x82D9BF0", Offset = "0x82D8BF0", VA = "0x1882D9BF0", Slot = "5")]
	public void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x82D9C00", Offset = "0x82D8C00", VA = "0x1882D9C00", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public NDFNIIADMBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface IDLNMAOMLDM : ICloneable
{
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJEPEOIMLPF(double GHNFCHHGJAG);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEEGGHAFLLE();
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PBHOGKLOCPO : IDLNMAOMLDM, ICloneable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private double IOALKPFEKEK;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public double BDJLGAHJNPH
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x49956E0", Offset = "0x49946E0", VA = "0x1849956E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5747650", Offset = "0x5746650", VA = "0x185747650", Slot = "4")]
	public void BJEPEOIMLPF(double GHNFCHHGJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x82DB210", Offset = "0x82DA210", VA = "0x1882DB210", Slot = "5")]
	public void AEEGGHAFLLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x82DB220", Offset = "0x82DA220", VA = "0x1882DB220", Slot = "6")]
	public object Clone()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public PBHOGKLOCPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ELPNMOHOPPO<TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate Task<TResult> FICOKBCDDJI(CancellationToken KGALDHLEDNC);

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct MOPDMGKHPMC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public ELPNMOHOPPO<TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public FICOKBCDDJI taskGenerator;

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
		[Cpp2IlInjected.Address(RVA = "0x570A3A0", Offset = "0x57093A0", VA = "0x18570A3A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x570B370", Offset = "0x570A370", VA = "0x18570B370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private readonly CancellationTokenSource KGNGGHKAGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private CancellationTokenSource? EFPBKPHJLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private TaskCompletionSource<TResult>? COBKMPJLNBB;

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4919730", Offset = "0x4918730", VA = "0x184919730")]
	[AsyncStateMachine(typeof(ELPNMOHOPPO<>.MOPDMGKHPMC))]
	public Task<TResult> IDIDOINONJP(FICOKBCDDJI FNAEBNBGICC, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x49196C0", Offset = "0x49186C0", VA = "0x1849196C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x4919860", Offset = "0x4918860", VA = "0x184919860")]
	public ELPNMOHOPPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class ECMPKEFGOEF<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private static readonly EqualityComparer<T> IMOOBMIHPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public T BDJLGAHJNPH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x48ED340", Offset = "0x48EC340", VA = "0x1848ED340")]
	public ECMPKEFGOEF([In] T IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48EC630", Offset = "0x48EB630", VA = "0x1848EC630", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x48ECC20", Offset = "0x48EBC20", VA = "0x1848ECC20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x48ECDA0", Offset = "0x48EBDA0", VA = "0x1848ECDA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class HBCFNIDJNLE
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x39D4600", Offset = "0x39D3600", VA = "0x1839D4600")]
	public static ECMPKEFGOEF<T> MPFKOOIPONO<T>([In] T IOALKPFEKEK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class JJCJFNAAJGB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x82D8ED0", Offset = "0x82D7ED0", VA = "0x1882D8ED0")]
	public static void CFOKKNGCDHJ(this CancellationTokenSource KGNGGHKAGHI, bool CHNJPMLPFIM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
public class KKIPOIIKBDF : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public KKIPOIIKBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
public class MDIDPKNNAGM : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public MDIDPKNNAGM(string DNKNGGPOLML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class FHABCJCAIGA
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D960", Offset = "0x3C3C960", VA = "0x183C3D960")]
	public static MFCEKPGNINC AEBBFFMPONJ<T>()
	{
		return default(MFCEKPGNINC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x82D5980", Offset = "0x82D4980", VA = "0x1882D5980")]
	public static MFCEKPGNINC ODOBPOMAOHF([CallerMemberName] string HJLBILHBIIC = "")
	{
		return default(MFCEKPGNINC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3C3DC30", Offset = "0x3C3CC30", VA = "0x183C3DC30")]
	public static MFCEKPGNINC MBGIEEBJHBB<T>([CallerMemberName] string HJLBILHBIIC = "") where T : notnull
	{
		return default(MFCEKPGNINC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D9E0", Offset = "0x3C3C9E0", VA = "0x183C3D9E0")]
	public static MFCEKPGNINC AEBBFFMPONJ<T>(this T CIABMLDDFBB) where T : notnull
	{
		return default(MFCEKPGNINC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x3C3DCC0", Offset = "0x3C3CCC0", VA = "0x183C3DCC0")]
	public static MFCEKPGNINC ODOBPOMAOHF<T>(this T CIABMLDDFBB, [CallerMemberName] string HJLBILHBIIC = "") where T : notnull
	{
		return default(MFCEKPGNINC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3C3DB90", Offset = "0x3C3CB90", VA = "0x183C3DB90")]
	public static MFCEKPGNINC MBGIEEBJHBB<T>(this T OLHDOIOOPGE, [CallerMemberName] string HJLBILHBIIC = "") where T : notnull
	{
		return default(MFCEKPGNINC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x82D5900", Offset = "0x82D4900", VA = "0x1882D5900")]
	public static MFCEKPGNINC MBGIEEBJHBB(string NFKOJFJNKDF, [CallerMemberName] string HJLBILHBIIC = "")
	{
		return default(MFCEKPGNINC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x82D5860", Offset = "0x82D4860", VA = "0x1882D5860")]
	public static string CGBAJPPPECO(this object OLHDOIOOPGE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public delegate bool BENKLIPPEDA();
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KKIPOIIKBDF]
public delegate long EBLJNCMNOOE();
[Cpp2IlInjected.Token(Token = "0x200001C")]
public sealed class CFOGANKLPFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public static readonly CFOGANKLPFI KONBGMLOLPI;

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public CFOGANKLPFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class ABJOPACFCAG
{
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private static NJNMEKBNMFG LOMEBIIIHCG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static NJNMEKBNMFG FEKFPLOHNJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82CEDE0", Offset = "0x82CDDE0", VA = "0x1882CEDE0")]
		get
		{
			return default(NJNMEKBNMFG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static GMIFOMPDPFI BFMLNFHBIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82CE950", Offset = "0x82CD950", VA = "0x1882CE950")]
		get
		{
			return default(GMIFOMPDPFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static JFHANBBOLPA GCBFJFMBBAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82CEB10", Offset = "0x82CDB10", VA = "0x1882CEB10")]
		get
		{
			return default(JFHANBBOLPA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public static bool HKMHOCKHKDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82CEB60", Offset = "0x82CDB60", VA = "0x1882CEB60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82CEBD0", Offset = "0x82CDBD0", VA = "0x1882CEBD0")]
	public static void LKBEDGGNOOI([In] NJNMEKBNMFG ALBKDDLEBHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x82CE630", Offset = "0x82CD630", VA = "0x1882CE630")]
	public static void APKHGLJHJLF(string OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x82CE820", Offset = "0x82CD820", VA = "0x1882CE820")]
	public static void GMJFKJBABOF(string OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x318EC40", Offset = "0x318DC40", VA = "0x18318EC40")]
	public static void GMJFKJBABOF<T>(T AJDOBKLONKL, KGOMNAFLOJH<T> OBCNAJEENCI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x82CE780", Offset = "0x82CD780", VA = "0x1882CE780")]
	public static void FBPFKKLELOE(Exception MMCKGPNIIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x82CE8F0", Offset = "0x82CD8F0", VA = "0x1882CE8F0")]
	public static void GNKJMPOGPII(string HJLBILHBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x82CED80", Offset = "0x82CDD80", VA = "0x1882CED80")]
	public static void NJELDGFAGMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x82CE700", Offset = "0x82CD700", VA = "0x1882CE700")]
	public static string CGBAJPPPECO(object PGIOEBKALDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x82CEE30", Offset = "0x82CDE30", VA = "0x1882CEE30")]
	public static long PKMJCHKMFEP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82CEA70", Offset = "0x82CDA70", VA = "0x1882CEA70")]
	public static bool HINFGPJNPAB(bool OHAJJEFFGJP, string OBCNAJEENCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x82CE9A0", Offset = "0x82CD9A0", VA = "0x1882CE9A0")]
	public static double HGPIGKDMGNO()
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct NJNMEKBNMFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly GMIFOMPDPFI BFMLNFHBIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly JFHANBBOLPA GCBFJFMBBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly DACAMHKPCKE GEMJFBIGNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly EBLJNCMNOOE FFPLCIAHCFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly BBOPEPECMJF KMMCIEDCBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public readonly BENKLIPPEDA CKNIPHEOHHA;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly DACAMHKPCKE BFFHILNEDHC;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly EBLJNCMNOOE LOPPPOIEMHB;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public static readonly BBOPEPECMJF MJLJMLGKHIO;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly BENKLIPPEDA EHJCELNENJJ;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly NJNMEKBNMFG JBLEAIPIMOC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool BMKKEHNACIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82D9D50", Offset = "0x82D8D50", VA = "0x1882D9D50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x82DA730", Offset = "0x82D9730", VA = "0x1882DA730")]
	public NJNMEKBNMFG([In] GMIFOMPDPFI DNPIDODHJPD, [In] JFHANBBOLPA BJLIAPFKMFH, DACAMHKPCKE OKILEILIFIF, EBLJNCMNOOE CGDJPCMHJOA, BBOPEPECMJF DANBHLFDEJD, BENKLIPPEDA OCEHLGBCPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82DA000", Offset = "0x82D9000", VA = "0x1882DA000")]
	private static string PCJCELKGLAN(object PGIOEBKALDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA60530", Offset = "0xA5F530", VA = "0x180A60530")]
	private static long BIPEAPOLAPA()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	private static string ANFNKKDPPMG(string NGKMMOMPFOH, string? DGMLMPAOEHN, bool BEFKNBFNAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0")]
	private static bool PJMHNPKBJMK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82D9EF0", Offset = "0x82D8EF0", VA = "0x1882D9EF0")]
	private static NJNMEKBNMFG MJHLNKIBIPN()
	{
		return default(NJNMEKBNMFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface CCGHGKDCNOA
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PEOEPOEPBCJ DBPMCIGLPAN();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface PEOEPOEPBCJ : INotifyCompletion
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	bool ICOLIBANBIB
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HIIAJKHHCOK();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface PNBPCEACENO<T> where T : notnull
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JLIONPMOOGD([In] T EDJHHGMLKFA);
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public delegate void DJBIIFDBLMD<T>([In] T AJDOBKLONKL);
[Cpp2IlInjected.Token(Token = "0x2000023")]
public readonly struct AACADNAKHPC<T> : IEquatable<AACADNAKHPC<T>>, PNBPCEACENO<AACADNAKHPC<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public readonly T BDJLGAHJNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public readonly int MKOCHPIICKK;

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x2A60660", Offset = "0x2A5F660", VA = "0x182A60660")]
	public AACADNAKHPC([In] T IOALKPFEKEK, int HLGKMAPOEBE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x50BDCE0", Offset = "0x50BCCE0", VA = "0x1850BDCE0")]
	public static bool PHGIAKEDBEK([In] AACADNAKHPC<T> AKPAAKDLPCB, [In] AACADNAKHPC<T> AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x50BC950", Offset = "0x50BB950", VA = "0x1850BC950", Slot = "4")]
	public bool Equals(AACADNAKHPC<T> EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4908EB0", Offset = "0x4907EB0", VA = "0x184908EB0", Slot = "0")]
	public override bool Equals(object EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x50BD780", Offset = "0x50BC780", VA = "0x1850BD780")]
	public bool JLIONPMOOGD([In] AACADNAKHPC<T> EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x50BCD20", Offset = "0x50BBD20", VA = "0x1850BCD20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x50BE7C0", Offset = "0x50BD7C0", VA = "0x1850BE7C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x50BCF30", Offset = "0x50BBF30", VA = "0x1850BCF30")]
	public void HBLCGHBNJLA([Out] T IOALKPFEKEK, [Out] int HLGKMAPOEBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x50BD860", Offset = "0x50BC860", VA = "0x1850BD860")]
	public (T, int) OOGBHKPHJIB()
	{
		return default((T, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x50BD730", Offset = "0x50BC730", VA = "0x1850BD730", Slot = "5")]
	private bool HNDOACNDHAC([In] AACADNAKHPC<T> EDJHHGMLKFA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class JPCMALOHEPH
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x3CF3770", Offset = "0x3CF2770", VA = "0x183CF3770")]
	public static AACADNAKHPC<T> MPFKOOIPONO<T>([In] T IOALKPFEKEK, int HLGKMAPOEBE) where T : notnull
	{
		return default(AACADNAKHPC<T>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class AHDBIFENDKK
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x319D860", Offset = "0x319C860", VA = "0x18319D860")]
	public static bool JLIONPMOOGD<T, U>([In] T OLHDOIOOPGE, [In] U PGIOEBKALDP) where T : notnull, PNBPCEACENO<T> where U : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public delegate TResult FKPMPJBBCNP<T, out TResult>([In] T AJDOBKLONKL);
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KPHGACKJABC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000017")]
	TimeSpan HINIPGFMNNL
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Action? ENALANCEJDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AGMPLOGOAAB();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PONABAEDPBA();

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ILACAOECPPO();
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct GMIFOMPDPFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public readonly PNFMJAOPDPB CCONNFNFPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public readonly CDIGKPEMEPB BLJCDNGAKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public readonly PNFMJAOPDPB HBMECFOFGIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public readonly CDIGKPEMEPB PFIOGNDGJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly PNFMJAOPDPB FMODCHFEALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly CDIGKPEMEPB OBLPOFLLDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly HDFFBLLKMIC LJKCLEHOPGH;

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly PNFMJAOPDPB OLBMBPIDMIE;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly CDIGKPEMEPB GIAOGLHOHLD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly PNFMJAOPDPB LKLMFLDEEGN;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly CDIGKPEMEPB HMLNFOFOOAP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly PNFMJAOPDPB NHFNHKMPHCF;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly CDIGKPEMEPB HLGCJPCDEGJ;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly HDFFBLLKMIC IGOJEJCMHHL;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly GMIFOMPDPFI JBLEAIPIMOC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly PNFMJAOPDPB AKKICLLKPDC;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool BMKKEHNACIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x82D5A70", Offset = "0x82D4A70", VA = "0x1882D5A70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0xE99CC0", Offset = "0xE98CC0", VA = "0x180E99CC0")]
	public GMIFOMPDPFI(PNFMJAOPDPB PMKHAPEGODF, CDIGKPEMEPB FGICLEFNCON, PNFMJAOPDPB KNGPGONNBDG, CDIGKPEMEPB AAHCCLCGAGG, PNFMJAOPDPB LKIAJJCICJP, CDIGKPEMEPB IANJJGPPKGO, HDFFBLLKMIC OFDCJADAKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0")]
	private static bool AMBIBCEDAEG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	private static void GIFHBBKDGOC(string OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0")]
	private static bool EFBHMIOGEMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	private static void NNLDLOIDMIK(string OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAAA6B0", VA = "0x180AAB6B0")]
	private static bool HANCOHOMHLD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	private static void FGIIOFNCPMO(string OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	private static void BGNDLPEBJAG(Exception MMCKGPNIIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x82D5F70", Offset = "0x82D4F70", VA = "0x1882D5F70")]
	private static GMIFOMPDPFI MJHLNKIBIPN()
	{
		return default(GMIFOMPDPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0")]
	private static bool CIAOGPOHNJF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x82D5C70", Offset = "0x82D4C70", VA = "0x1882D5C70")]
	public void APKHGLJHJLF(object OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x82D5F00", Offset = "0x82D4F00", VA = "0x1882D5F00")]
	public void JPFKAAADBKC(object OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x82D5CE0", Offset = "0x82D4CE0", VA = "0x1882D5CE0")]
	public void GMJFKJBABOF(object OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE9A060", Offset = "0xE99060", VA = "0x180E9A060")]
	public void FBPFKKLELOE(Exception MMCKGPNIIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x82D5D50", Offset = "0x82D4D50", VA = "0x1882D5D50")]
	public void GMJFKJBABOF(FILILBAOAIO OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3C64670", Offset = "0x3C63670", VA = "0x183C64670")]
	public void GMJFKJBABOF<T>(T AJDOBKLONKL, KGOMNAFLOJH<T> OBCNAJEENCI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3C644F0", Offset = "0x3C634F0", VA = "0x183C644F0")]
	public void APKHGLJHJLF<T>([In] T AJDOBKLONKL, MNOBPDIPKBE<T> OBCNAJEENCI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C64740", Offset = "0x3C63740", VA = "0x183C64740")]
	public void GMJFKJBABOF<T>([In] T AJDOBKLONKL, MNOBPDIPKBE<T> OBCNAJEENCI) where T : notnull
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x82D5E30", Offset = "0x82D4E30", VA = "0x1882D5E30")]
	public bool HINFGPJNPAB(bool OHAJJEFFGJP, string OBCNAJEENCI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct MFCEKPGNINC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly string BDJLGAHJNPH;

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0xE50960", Offset = "0xE4F960", VA = "0x180E50960")]
	public MFCEKPGNINC(string IOALKPFEKEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60")]
	public static string MJOOONLKLLN([In] MFCEKPGNINC OLHDOIOOPGE)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x13EEFA0", Offset = "0x13EDFA0", VA = "0x1813EEFA0")]
	public static MFCEKPGNINC MJOOONLKLLN(string EDJHHGMLKFA)
	{
		return default(MFCEKPGNINC);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x82D9AC0", Offset = "0x82D8AC0", VA = "0x1882D9AC0")]
	public string KCMHPMJCPPJ(string DECCMGJEIIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x82D9B10", Offset = "0x82D8B10", VA = "0x1882D9B10")]
	public string NCGOKPDMKJM(object KLLAHLEHMOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0xAEAB60", Offset = "0xAE9B60", VA = "0x180AEAB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[AttributeUsage(AttributeTargets.Method)]
public class GANEKJHKDKC : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public GANEKJHKDKC()
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct GAAICFLNCNK : IEquatable<GAAICFLNCNK>
{
	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0xA7B3A0", Offset = "0xA7A3A0", VA = "0x180A7B3A0", Slot = "4")]
	public bool Equals(GAAICFLNCNK EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x82D59E0", Offset = "0x82D49E0", VA = "0x1882D59E0", Slot = "0")]
	public override bool Equals(object EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x82D5A30", Offset = "0x82D4A30", VA = "0x1882D5A30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x82D5A40", Offset = "0x82D4A40", VA = "0x1882D5A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[GMCEAOPKHKI("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
public readonly struct ILFGODFHMHE<T> : IEquatable<ILFGODFHMHE<T>> where T : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T BDJLGAHJNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly bool IJCAMBPAJED;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public bool ONCBDKEHLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x502D720", Offset = "0x502C720", VA = "0x18502D720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x502E730", Offset = "0x502D730", VA = "0x18502E730")]
	public ILFGODFHMHE([In] T IOALKPFEKEK, bool LNMKMKKFLEK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x502DD10", Offset = "0x502CD10", VA = "0x18502DD10")]
	public static bool PHGIAKEDBEK([In] ILFGODFHMHE<T> AKPAAKDLPCB, [In] ILFGODFHMHE<T> AIKJCCNDBKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x502C770", Offset = "0x502B770", VA = "0x18502C770", Slot = "4")]
	public bool Equals(ILFGODFHMHE<T> EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x502CCD0", Offset = "0x502BCD0", VA = "0x18502CCD0", Slot = "0")]
	public override bool Equals(object? EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x502CFD0", Offset = "0x502BFD0", VA = "0x18502CFD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x502E3F0", Offset = "0x502D3F0", VA = "0x18502E3F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class NGDAJIHNGAJ
{
	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2960", Offset = "0x3DF1960", VA = "0x183DF2960")]
	public static ILFGODFHMHE<T> CAPPHPBKNOF<T>([In] T IOALKPFEKEK) where T : notnull
	{
		return default(ILFGODFHMHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2B60", Offset = "0x3DF1B60", VA = "0x183DF2B60")]
	public static ILFGODFHMHE<T?> JEMKANIADFH<T>()
	{
		return default(ILFGODFHMHE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2D20", Offset = "0x3DF1D20", VA = "0x183DF2D20")]
	public static bool LGFMCNHELDK<T>([In] this ILFGODFHMHE<T> KFGEKJKPGCC, [Out][NotNullWhen(true)] T IOALKPFEKEK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2CB0", Offset = "0x3DF1CB0", VA = "0x183DF2CB0")]
	public static bool LGFMCNHELDK<T>([In] this ILFGODFHMHE<T> KFGEKJKPGCC, [Out][NotNullWhen(true)] T IOALKPFEKEK, [Out] ILFGODFHMHE<T> GPIAGJEBNHK) where T : notnull
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2E90", Offset = "0x3DF1E90", VA = "0x183DF2E90")]
	public static T? OJPENKBCCJM<T>([In] this ILFGODFHMHE<T> KFGEKJKPGCC, T? CAILINJCNIJ)
	{
		return (T?)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2D50", Offset = "0x3DF1D50", VA = "0x183DF2D50")]
	public static bool MGEEGCDMLKN<T>([In] this ILFGODFHMHE<T> KFGEKJKPGCC, T IOALKPFEKEK) where T : notnull
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class APMAHFAPPFH
{
	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x31AFB70", Offset = "0x31AEB70", VA = "0x1831AFB70")]
	public static T OJEHIOLDDOO<T>([In] this ILFGODFHMHE<T> KFGEKJKPGCC) where T : class
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct JFHANBBOLPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly IntPtr GNKJMPOGPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly IntPtr NJELDGFAGMA;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly IntPtr EKMIBOLDMDP;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly IntPtr DNODAMJEHAK;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly JFHANBBOLPA JBLEAIPIMOC;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool BMKKEHNACIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x82D8510", Offset = "0x82D7510", VA = "0x1882D8510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0xBDB810", Offset = "0xBDA810", VA = "0x180BDB810")]
	public JFHANBBOLPA(IntPtr CNMHIBLMHKC, IntPtr CGLAKPHCPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	private static void IFCNKGLNHHN(string HJLBILHBIIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520")]
	private static void AEHNBMADGBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x82D85F0", Offset = "0x82D75F0", VA = "0x1882D85F0")]
	private static JFHANBBOLPA MJHLNKIBIPN()
	{
		return default(JFHANBBOLPA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly ref struct NGPJOIHPFKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly IntPtr JPCBPIJOILH;

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x1354E00", Offset = "0x1353E00", VA = "0x181354E00")]
	private NGPJOIHPFKE(IntPtr CGLAKPHCPII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x82D9D40", Offset = "0x82D8D40", VA = "0x1882D9D40")]
	public void NIIIKCLLCBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x82D9C60", Offset = "0x82D8C60", VA = "0x1882D9C60")]
	public static NGPJOIHPFKE MPFKOOIPONO(string HJLBILHBIIC)
	{
		return default(NGPJOIHPFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x2A35440", Offset = "0x2A34440", VA = "0x182A35440")]
	public static NGPJOIHPFKE MPFKOOIPONO([In] JFHANBBOLPA BJLIAPFKMFH, string HJLBILHBIIC)
	{
		return default(NGPJOIHPFKE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2A34FD0", Offset = "0x2A33FD0", VA = "0x182A34FD0")]
	public static NGPJOIHPFKE MPFKOOIPONO([In] JFHANBBOLPA BJLIAPFKMFH, Func<string> HJLBILHBIIC)
	{
		return default(NGPJOIHPFKE);
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public PreserveAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class HMIDAMFGPBN : SHA256
{
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static bool? PFJBLKJDNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private IntPtr PHAPNEFKJJD;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool DKJDLLKJIPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x82D67A0", Offset = "0x82D57A0", VA = "0x1882D67A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x82D6E90", Offset = "0x82D5E90", VA = "0x1882D6E90")]
	public static SHA256 MEFBGKEPBLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x82D6BD0", Offset = "0x82D5BD0", VA = "0x1882D6BD0")]
	private static extern int IJICDFOLIGB();

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x82D6D00", Offset = "0x82D5D00", VA = "0x1882D6D00")]
	private static extern IntPtr JACPGOPHKBH();

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x82D6E10", Offset = "0x82D5E10", VA = "0x1882D6E10")]
	private static extern void LHCPPAJHOGG(IntPtr PHAPNEFKJJD);

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x82D6920", Offset = "0x82D5920", VA = "0x1882D6920")]
	private static extern void HIJNICHNHCI(IntPtr PHAPNEFKJJD, byte[] INCJDDLACNP, int MOAJDMPNBPN, int JKHIBPGKDLB);

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x82D6D70", Offset = "0x82D5D70", VA = "0x1882D6D70")]
	private static extern void KICMMJDGHGD(IntPtr PHAPNEFKJJD, byte[] OGGDKLDCEEO);

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x82D6F10", Offset = "0x82D5F10", VA = "0x1882D6F10")]
	private HMIDAMFGPBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x82D69E0", Offset = "0x82D59E0", VA = "0x1882D69E0", Slot = "18")]
	protected override void HashCore(byte[] MFIJBPNIELL, int EFOIGNDONHG, int FEDOMILMIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x82D6AA0", Offset = "0x82D5AA0", VA = "0x1882D6AA0", Slot = "19")]
	protected override byte[] HashFinal()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x82D6C40", Offset = "0x82D5C40", VA = "0x1882D6C40", Slot = "20")]
	public override void Initialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x82D6890", Offset = "0x82D5890", VA = "0x1882D6890", Slot = "13")]
	protected override void Dispose(bool EFFINLOFOIL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class DEBJONOJJIM
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate bool LFABDGICHEA<in TInput, TResult>(TInput JMJJABEKOFI, [Out] TResult BGOCMPMGKKI);

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	private sealed class EDJDDIPJFKJ : CCGHGKDCNOA
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class DOGNBDDDNIL : PEOEPOEPBCJ, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly DOGNBDDDNIL KONBGMLOLPI;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			public bool ICOLIBANBIB
			{
				[Cpp2IlInjected.Token(Token = "0x60000FB")]
				[Cpp2IlInjected.Address(RVA = "0x82D4200", Offset = "0x82D3200", VA = "0x1882D4200", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x82D4260", Offset = "0x82D3260", VA = "0x1882D4260", Slot = "6")]
			public void OnCompleted(Action FEJGGBKHODF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			public void HIIAJKHHCOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public DOGNBDDDNIL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public static readonly EDJDDIPJFKJ KONBGMLOLPI;

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		private EDJDDIPJFKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x82D4630", Offset = "0x82D3630", VA = "0x1882D4630", Slot = "4")]
		public PEOEPOEPBCJ DBPMCIGLPAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private sealed class DPEJGLDBCCM : CCGHGKDCNOA
	{
		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class KGGEDMKEGHF : PEOEPOEPBCJ, INotifyCompletion
		{
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly KGGEDMKEGHF KONBGMLOLPI;

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			public bool ICOLIBANBIB
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0x82D98A0", Offset = "0x82D88A0", VA = "0x1882D98A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x82D98C0", Offset = "0x82D88C0", VA = "0x1882D98C0", Slot = "6")]
			public void OnCompleted(Action FEJGGBKHODF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "5")]
			public void HIIAJKHHCOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
			public KGGEDMKEGHF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public static readonly DPEJGLDBCCM KONBGMLOLPI;

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		private DPEJGLDBCCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x82D4440", Offset = "0x82D3440", VA = "0x1882D4440", Slot = "4")]
		public PEOEPOEPBCJ DBPMCIGLPAN()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class GDKCJGFDDAI<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public TaskCompletionSource<TResult> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public CancellationToken token;

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GDKCJGFDDAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3D60", Offset = "0x4EA2D60", VA = "0x184EA3D60")]
		internal void MPEGIPLGNKN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class GAAFEAEKECL<TResult> where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public CancellationTokenRegistration registration;

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public GAAFEAEKECL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4E44EA0", Offset = "0x4E43EA0", VA = "0x184E44EA0")]
		internal void KNABMBADLIK(Task<TResult> _)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct ODLCIKBIDFG : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82DB0B0", Offset = "0x82DA0B0", VA = "0x1882DB0B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct GPIAAJOAOLL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D6690", Offset = "0x82D5690", VA = "0x1882D6690", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xAB7210", Offset = "0xAB6210", VA = "0x180AB7210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct MFAAENJGLOB<TException> : IAsyncStateMachine where TException : notnull, Exception
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
		[Cpp2IlInjected.Address(RVA = "0x56B2430", Offset = "0x56B1430", VA = "0x1856B2430", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x56B25A0", Offset = "0x56B15A0", VA = "0x1856B25A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[CompilerGenerated]
	private struct FPDHKANGCIA<T> : IAsyncStateMachine where T : notnull
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
		public ONIHMLNNEEF log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public Func<Task<T>, string> logMessageFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter<T> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4DC1410", Offset = "0x4DC0410", VA = "0x184DC1410", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4DC1810", Offset = "0x4DC0810", VA = "0x184DC1810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private struct JDOLIDMNIAK<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x5299E50", Offset = "0x5298E50", VA = "0x185299E50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x529A680", Offset = "0x5299680", VA = "0x18529A680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private struct DDHJJFLHJBH : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D1C00", Offset = "0x82D0C00", VA = "0x1882D1C00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x82D1E10", Offset = "0x82D0E10", VA = "0x1882D1E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class DEEKDENMKHJ<T> where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public DEEKDENMKHJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3D60", Offset = "0x4EA2D60", VA = "0x184EA3D60")]
		internal void MMBDCAPNKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6E87C50", Offset = "0x6E86C50", VA = "0x186E87C50")]
		internal void PGCNHIKBDMP(T arg1)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct NJFIDHNJNMM<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
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
		public LFABDGICHEA<TInput, TResult> transformFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private TaskAwaiter<List<TInput>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x578B7F0", Offset = "0x578A7F0", VA = "0x18578B7F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x578BEA0", Offset = "0x578AEA0", VA = "0x18578BEA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private struct ODIDFPKEFPD : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82DA860", Offset = "0x82D9860", VA = "0x1882DA860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x82DB050", Offset = "0x82DA050", VA = "0x1882DB050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private struct EOEHIIODJDN : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D4C30", Offset = "0x82D3C30", VA = "0x1882D4C30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x82D5170", Offset = "0x82D4170", VA = "0x1882D5170", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct JCHLBNONLGJ<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x52951F0", Offset = "0x52941F0", VA = "0x1852951F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x52960F0", Offset = "0x52950F0", VA = "0x1852960F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class ADHNHMPIJHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public TaskCompletionSource<GAAICFLNCNK> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public int tasksRemaining;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Action<Task> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public ADHNHMPIJHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x82CEF60", Offset = "0x82CDF60", VA = "0x1882CEF60")]
		internal void BCLAFPHGMDP(Task t)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private struct CPIHJCMDOLA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D12A0", Offset = "0x82D02A0", VA = "0x1882D12A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x82D1520", Offset = "0x82D0520", VA = "0x1882D1520", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private struct KIDEFJFOAIB<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x53BBCD0", Offset = "0x53BACD0", VA = "0x1853BBCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x445B020", Offset = "0x445A020", VA = "0x18445B020", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private struct HMCIBPMDNFD<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4F51B70", Offset = "0x4F50B70", VA = "0x184F51B70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x445A150", Offset = "0x4459150", VA = "0x18445A150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private struct GANICJIHDMK<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x4E49750", Offset = "0x4E48750", VA = "0x184E49750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x4E4A5C0", Offset = "0x4E495C0", VA = "0x184E4A5C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private struct IGFPBBMHLOE : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D74A0", Offset = "0x82D64A0", VA = "0x1882D74A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x82D7680", Offset = "0x82D6680", VA = "0x1882D7680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private struct BOMIFIFALBI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D0A20", Offset = "0x82CFA20", VA = "0x1882D0A20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x82D0D90", Offset = "0x82CFD90", VA = "0x1882D0D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private struct EEAGADOIJDO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D4700", Offset = "0x82D3700", VA = "0x1882D4700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x82D49F0", Offset = "0x82D39F0", VA = "0x1882D49F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class CGLOFECIAPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public CGLOFECIAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x82D0E70", Offset = "0x82CFE70", VA = "0x1882D0E70")]
		internal Task MGFOMOOLMBC(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private struct AAGMDCIEPNI : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82CE370", Offset = "0x82CD370", VA = "0x1882CE370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x82CE5D0", Offset = "0x82CD5D0", VA = "0x1882CE5D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct IJODBCACOOJ : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D7AA0", Offset = "0x82D6AA0", VA = "0x1882D7AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x82D7C80", Offset = "0x82D6C80", VA = "0x1882D7C80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private struct IGNPPALJELL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D76E0", Offset = "0x82D66E0", VA = "0x1882D76E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x82D7A40", Offset = "0x82D6A40", VA = "0x1882D7A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private struct CNMCOOIKCBO : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D0F50", Offset = "0x82CFF50", VA = "0x1882D0F50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x82D1240", Offset = "0x82D0240", VA = "0x1882D1240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[CompilerGenerated]
	private sealed class CJPEINAEIJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public Func<bool> condition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public TimeSpan pollingInterval;

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public CJPEINAEIJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x82D0EE0", Offset = "0x82CFEE0", VA = "0x1882D0EE0")]
		internal Task EFJGNEODKFH(CancellationToken timeoutToken)
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private struct FDDMDCJMFML : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D55A0", Offset = "0x82D45A0", VA = "0x1882D55A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x82D5800", Offset = "0x82D4800", VA = "0x1882D5800", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private struct EGGGDKKKJKP : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D4A50", Offset = "0x82D3A50", VA = "0x1882D4A50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x82D4BD0", Offset = "0x82D3BD0", VA = "0x1882D4BD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private struct CDJGILGOEAK<T> : IAsyncStateMachine where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0x68AA9F0", Offset = "0x68A99F0", VA = "0x1868AA9F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x68AAEF0", Offset = "0x68A9EF0", VA = "0x1868AAEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private struct IDNJMLDPDHL : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D7110", Offset = "0x82D6110", VA = "0x1882D7110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x82D7440", Offset = "0x82D6440", VA = "0x1882D7440", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static SynchronizationContext? DDHEGPIFMGG;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly TaskCompletionSource<GAAICFLNCNK> NBCDKAJKOIE;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static Task AGEEEAJGDIE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x82D3B20", Offset = "0x82D2B20", VA = "0x1882D3B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x82D1FB0", Offset = "0x82D0FB0", VA = "0x1882D1FB0")]
	public static bool BHHBLIKICBC(this Task CAIMNCAIJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E4D0", Offset = "0x3A8D4D0", VA = "0x183A8E4D0")]
	public static Task<T> JMNJGHOMGCL<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x82D3B90", Offset = "0x82D2B90", VA = "0x1882D3B90")]
	public static Task NIBKEOLOHOF(this Task CAIMNCAIJDI, CancellationToken GFDDDAIMFOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A912D0", Offset = "0x3A902D0", VA = "0x183A912D0")]
	public static Task<TResult> NIBKEOLOHOF<TResult>(this Task<TResult> CAIMNCAIJDI, CancellationToken GFDDDAIMFOH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A8F250", Offset = "0x3A8E250", VA = "0x183A8F250")]
	public static TaskCompletionSource<TResult> NIBKEOLOHOF<TResult>(this TaskCompletionSource<TResult> MLBJJBKEMAG, CancellationToken GFDDDAIMFOH) where TResult : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x82D3DF0", Offset = "0x82D2DF0", VA = "0x1882D3DF0")]
	public static IDisposable? NKEFIMOOECK(CancellationToken FFHMEILKOFK, CancellationToken CBGJIPLJOND, [Out] CancellationToken EGJNFKPGLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x82D2AE0", Offset = "0x82D1AE0", VA = "0x1882D2AE0")]
	[AsyncStateMachine(typeof(ODLCIKBIDFG))]
	public static void FKHFGJNIDOF(this Task HBPDACJCCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x82D1FE0", Offset = "0x82D0FE0", VA = "0x1882D1FE0")]
	[AsyncStateMachine(typeof(GPIAAJOAOLL))]
	public static void BMPDBPNPCLG(this Task HBPDACJCCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A8DD00", Offset = "0x3A8CD00", VA = "0x183A8DD00")]
	[AsyncStateMachine(typeof(MFAAENJGLOB<>))]
	public static Task ENOLMBNFPHM<TException>(this Task HBPDACJCCKM) where TException : notnull, Exception
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A931C0", Offset = "0x3A921C0", VA = "0x183A931C0")]
	[AsyncStateMachine(typeof(FPDHKANGCIA<>))]
	public static Task<T> OMHCNBDMECN<T>(this Task<T> OLHDOIOOPGE, ONIHMLNNEEF EFJNGOKNPIL, Func<Task<T>, string> OIDCIBMNGPC, bool MCABNGIODHO = false) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A930E0", Offset = "0x3A920E0", VA = "0x183A930E0")]
	[AsyncStateMachine(typeof(JDOLIDMNIAK<>))]
	public static Task<T> OMHCNBDMECN<T>(this Task<T> OLHDOIOOPGE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x82D4050", Offset = "0x82D3050", VA = "0x1882D4050")]
	[AsyncStateMachine(typeof(DDHJJFLHJBH))]
	public static Task<TaskStatus> PBHBCNJDEGN(this Task? OLHDOIOOPGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3A8DAC0", Offset = "0x3A8CAC0", VA = "0x183A8DAC0")]
	public static (Task<T?>?, Action<T?>?) DGJIJHGGOPG<T>([Optional] CancellationToken KGALDHLEDNC)
	{
		return default((Task<T>, Action<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E3D0", Offset = "0x3A8D3D0", VA = "0x183A8E3D0")]
	[AsyncStateMachine(typeof(NJFIDHNJNMM<, >))]
	public static Task<List<TResult>> JDEMCNOEIMJ<TResult, TInput>(this Task<List<TInput>> CAIMNCAIJDI, LFABDGICHEA<TInput, TResult> LLCGPHEFCEJ) where TResult : notnull where TInput : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x82D1E80", Offset = "0x82D0E80", VA = "0x1882D1E80")]
	[AsyncStateMachine(typeof(ODIDFPKEFPD))]
	public static Task AKNOFPNJFKB(Task HBPDACJCCKM, CancellationToken JDJIJJCCKPD, Func<CancellationToken, Task> LMMEHJENEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x82D30A0", Offset = "0x82D20A0", VA = "0x1882D30A0")]
	[AsyncStateMachine(typeof(EOEHIIODJDN))]
	public static Task HMFKJJNOAGA(Func<CancellationToken, Task> EMDGJLMHKMK, TimeSpan IKDPIKPLFHI, [Optional] CancellationToken JDJIJJCCKPD, [Optional] Action<OperationCanceledException>? MOEJFLJNANM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E170", Offset = "0x3A8D170", VA = "0x183A8E170")]
	[AsyncStateMachine(typeof(JCHLBNONLGJ<>))]
	public static Task<T> HMFKJJNOAGA<T>(Func<CancellationToken, Task<T>> EMDGJLMHKMK, TimeSpan IKDPIKPLFHI, [Optional] CancellationToken JDJIJJCCKPD, [Optional] Func<OperationCanceledException, T>? MOEJFLJNANM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x82D3800", Offset = "0x82D2800", VA = "0x1882D3800")]
	public static Task INKBCOPMJMH(params Task[] CCABELAFCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x82D3340", Offset = "0x82D2340", VA = "0x1882D3340")]
	public static Task INKBCOPMJMH(IEnumerable<Task> CCABELAFCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x82D2680", Offset = "0x82D1680", VA = "0x1882D2680")]
	[AsyncStateMachine(typeof(CPIHJCMDOLA))]
	public static Task<IEnumerable<Task>> EPCHOHGAJMI(IEnumerable<Task> CCABELAFCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A8DEB0", Offset = "0x3A8CEB0", VA = "0x183A8DEB0")]
	[AsyncStateMachine(typeof(KIDEFJFOAIB<>))]
	public static Task<IEnumerable<Task<T>>> EPCHOHGAJMI<T>(IEnumerable<Task<T>> CCABELAFCCB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E8E0", Offset = "0x3A8D8E0", VA = "0x183A8E8E0")]
	[AsyncStateMachine(typeof(HMCIBPMDNFD<, , >))]
	public static Task<(T1, T2, T3)> KBDIJPGPLMC<T1, T2, T3>(Task<T1> KONCNGCOOJH, Task<T2> ABDHOHELCNE, Task<T3> JJGHGKHOGDK) where T1 : notnull where T2 : notnull where T3 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x3A8E620", Offset = "0x3A8D620", VA = "0x183A8E620")]
	[AsyncStateMachine(typeof(GANICJIHDMK<, , , , >))]
	public static Task<(T1, T2, T3, T4, T5)> KBDIJPGPLMC<T1, T2, T3, T4, T5>(Task<T1> KONCNGCOOJH, Task<T2> ABDHOHELCNE, Task<T3> JJGHGKHOGDK, Task<T4> AFKFFHMNIMG, Task<T5> HDLNBGCBPJK) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x82D39E0", Offset = "0x82D29E0", VA = "0x1882D39E0")]
	[AsyncStateMachine(typeof(IGFPBBMHLOE))]
	public static Task KAOEADOAMAG(Func<bool> OHAJJEFFGJP, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x82D38D0", Offset = "0x82D28D0", VA = "0x1882D38D0")]
	[AsyncStateMachine(typeof(BOMIFIFALBI))]
	public static Task KAOEADOAMAG(Func<bool> OHAJJEFFGJP, TimeSpan BFCGHKAMHAC, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x82D29B0", Offset = "0x82D19B0", VA = "0x1882D29B0")]
	[AsyncStateMachine(typeof(EEAGADOIJDO))]
	public static Task FFCOPIIGCFH(Func<bool> OHAJJEFFGJP, TimeSpan IKDPIKPLFHI, [Optional] CancellationToken KGALDHLEDNC, [Optional] Action<OperationCanceledException>? MOEJFLJNANM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x82D2870", Offset = "0x82D1870", VA = "0x1882D2870")]
	[AsyncStateMachine(typeof(AAGMDCIEPNI))]
	public static Task FFCOPIIGCFH(Func<bool> OHAJJEFFGJP, TimeSpan IKDPIKPLFHI, TimeSpan BFCGHKAMHAC, [Optional] CancellationToken KGALDHLEDNC, [Optional] Action<OperationCanceledException>? MOEJFLJNANM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x82D2090", Offset = "0x82D1090", VA = "0x1882D2090")]
	[AsyncStateMachine(typeof(IJODBCACOOJ))]
	public static Task BPIIADAJPHA(Func<bool> OHAJJEFFGJP, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x82D2180", Offset = "0x82D1180", VA = "0x1882D2180")]
	[AsyncStateMachine(typeof(IGNPPALJELL))]
	public static Task BPIIADAJPHA(Func<bool> OHAJJEFFGJP, TimeSpan BFCGHKAMHAC, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x82D2290", Offset = "0x82D1290", VA = "0x1882D2290")]
	[AsyncStateMachine(typeof(CNMCOOIKCBO))]
	public static Task DLGFFJNFMBA(Func<bool> OHAJJEFFGJP, TimeSpan IKDPIKPLFHI, [Optional] CancellationToken KGALDHLEDNC, [Optional] Action<OperationCanceledException>? MOEJFLJNANM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x82D23C0", Offset = "0x82D13C0", VA = "0x1882D23C0")]
	[AsyncStateMachine(typeof(FDDMDCJMFML))]
	public static Task DLGFFJNFMBA(Func<bool> OHAJJEFFGJP, TimeSpan IKDPIKPLFHI, TimeSpan BFCGHKAMHAC, [Optional] CancellationToken KGALDHLEDNC, [Optional] Action<OperationCanceledException>? MOEJFLJNANM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x82D2780", Offset = "0x82D1780", VA = "0x1882D2780")]
	[AsyncStateMachine(typeof(EGGGDKKKJKP))]
	[Obsolete]
	public static Task FFBJONJKLME(this Task CAIMNCAIJDI, Action AGCKAHNKEDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A8DF90", Offset = "0x3A8CF90", VA = "0x183A8DF90")]
	[AsyncStateMachine(typeof(CDJGILGOEAK<>))]
	[Obsolete]
	public static Task FFBJONJKLME<T>(this Task<T> CAIMNCAIJDI, Action<T> AGCKAHNKEDN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x82D25D0", Offset = "0x82D15D0", VA = "0x1882D25D0")]
	private static void EMEIBDFFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x82D2B90", Offset = "0x82D1B90", VA = "0x1882D2B90")]
	public static bool HGEBJJAIGBL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x82D2F10", Offset = "0x82D1F10", VA = "0x1882D2F10")]
	private static void HJLKBADOKFB(SynchronizationContext IOALKPFEKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x82D3220", Offset = "0x82D2220", VA = "0x1882D3220")]
	private static void IIBKBKJFNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x82D3F80", Offset = "0x82D2F80", VA = "0x1882D3F80")]
	public static void OHBHAMPODIM([Optional] string? OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x82D3850", Offset = "0x82D2850", VA = "0x1882D3850")]
	public static void JPLKFCGANNF([Optional] string? OBCNAJEENCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x82D3AD0", Offset = "0x82D2AD0", VA = "0x1882D3AD0")]
	public static CCGHGKDCNOA LCBIOGNKGDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x82D31D0", Offset = "0x82D21D0", VA = "0x1882D31D0")]
	public static CCGHGKDCNOA IFEEHFAKBGO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x82D2500", Offset = "0x82D1500", VA = "0x1882D2500")]
	[AsyncStateMachine(typeof(IDNJMLDPDHL))]
	public static Task DMLKJOAEKJC(Func<Task> MIHDDGGCGJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class NMAHPGPJLGN : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public NMAHPGPJLGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public static class BLANGNPLCAF
{
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x82D0350", Offset = "0x82CF350", VA = "0x1882D0350")]
	public static bool ONOBBBKAIIC(this NPOGFCNMGND HGGNFBFIEPG, DateTime PBJOFJBCJKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x82D0230", Offset = "0x82CF230", VA = "0x1882D0230")]
	public static TimeSpan JICMKEEJCHD(this NPOGFCNMGND HGGNFBFIEPG, DateTime PBJOFJBCJKC)
	{
		return default(TimeSpan);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class ECMENJCHNCN : NPOGFCNMGND
{
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public static readonly NPOGFCNMGND KONBGMLOLPI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public DateTime GKANKFMDPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x82D4570", Offset = "0x82D3570", VA = "0x1882D4570", Slot = "4")]
		get
		{
			return default(DateTime);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public DateTimeOffset BGLIJPMHIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x82D4510", Offset = "0x82D3510", VA = "0x1882D4510", Slot = "5")]
		get
		{
			return default(DateTimeOffset);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
	public ECMENJCHNCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface NPOGFCNMGND
{
	[Cpp2IlInjected.Token(Token = "0x17000022")]
	DateTime GKANKFMDPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	DateTimeOffset BGLIJPMHIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class IKPMMMKDPKA
{
	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static long JDBNKEPJEKF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x82D80B0", Offset = "0x82D70B0", VA = "0x1882D80B0")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public static long LHIPBLAOBOF
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x82D7D40", Offset = "0x82D6D40", VA = "0x1882D7D40")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public static double NIGNOLEOBGB
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x82D7F00", Offset = "0x82D6F00", VA = "0x1882D7F00")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public static double OLNDEAHPANP
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x82D7CE0", Offset = "0x82D6CE0", VA = "0x1882D7CE0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static double FCAKNKBGPBM
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x82D7EB0", Offset = "0x82D6EB0", VA = "0x1882D7EB0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public static double ILDGOFOEHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x82D8100", Offset = "0x82D7100", VA = "0x1882D8100")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x82D7D90", Offset = "0x82D6D90", VA = "0x1882D7D90")]
	public static double FMHFGILJPCK(long OOAOAAOLGCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x82D8150", Offset = "0x82D7150", VA = "0x1882D8150")]
	public static double NNMIICGDLMA(long OOAOAAOLGCJ)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x82D7E20", Offset = "0x82D6E20", VA = "0x1882D7E20")]
	public static double IACEFMLDPCA(double IJLEJNDFMKO)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x82D7F50", Offset = "0x82D6F50", VA = "0x1882D7F50")]
	public static long JNJEHPPDNAL(long GLANCCCAPLO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x82D7D30", Offset = "0x82D6D30", VA = "0x1882D7D30")]
	public static long EBPMNEJIAGI(long DCJNMMJMNPC, long MHKLAPDIGEE)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x82D7FE0", Offset = "0x82D6FE0", VA = "0x1882D7FE0")]
	public static double KLNIGDLOIAL(long DCJNMMJMNPC, long MHKLAPDIGEE)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x82D81E0", Offset = "0x82D71E0", VA = "0x1882D81E0")]
	public static double PLMPKLCBAGF(long DCJNMMJMNPC, long MHKLAPDIGEE)
	{
		return default(double);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public sealed class JGEIMGAJNFL : KPHGACKJABC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public static readonly TimeSpan JMLEOGEBOAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly System.Timers.Timer HDAJLMNMKDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private TimeSpan IKDPIKPLFHI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public TimeSpan HINIPGFMNNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA63F80", Offset = "0xA62F80", VA = "0x180A63F80", Slot = "4")]
		get
		{
			return default(TimeSpan);
		}
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x82D89A0", Offset = "0x82D79A0", VA = "0x1882D89A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Action? ENALANCEJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0xA63FD0", Offset = "0xA62FD0", VA = "0x180A63FD0", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA63F90", Offset = "0xA62F90", VA = "0x180A63F90", Slot = "6")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x82D8E60", Offset = "0x82D7E60", VA = "0x1882D8E60")]
	[Preserve]
	public JGEIMGAJNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x82D8C10", Offset = "0x82D7C10", VA = "0x1882D8C10")]
	public JGEIMGAJNFL(TimeSpan IKDPIKPLFHI, [Optional] Action? DGJMBLMJJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x82D87D0", Offset = "0x82D77D0", VA = "0x1882D87D0", Slot = "7")]
	public void AGMPLOGOAAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x82D8B30", Offset = "0x82D7B30", VA = "0x1882D8B30", Slot = "8")]
	public void PONABAEDPBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x82D8B00", Offset = "0x82D7B00", VA = "0x1882D8B00", Slot = "9")]
	public void ILACAOECPPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x1297C10", Offset = "0x1296C10", VA = "0x181297C10")]
	private void OAMKJKFKIOF(object CIABMLDDFBB, ElapsedEventArgs GHINBINAHHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x82D8900", Offset = "0x82D7900", VA = "0x1882D8900")]
	private static void ECEMNNGJMKH(TimeSpan KIHFECFNNAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x82D8860", Offset = "0x82D7860", VA = "0x1882D8860", Slot = "10")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public class GMCEAOPKHKI : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public readonly string? GBJAIFIDHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public readonly string FMJEMOMMPEK;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x1917860", Offset = "0x1916860", VA = "0x181917860")]
	public GMCEAOPKHKI(string GAPCMICLLJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5375110", Offset = "0x5374110", VA = "0x185375110")]
	public GMCEAOPKHKI(string MIMAHBNFICG, string GAPCMICLLJD)
	{
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000062")]
[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
public struct AKECAGNFEBE : IEquatable<AKECAGNFEBE>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public uint EOADEHIGHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public int KBEKFPHBAAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public float MFIAFHKPFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public ushort BONFFOKGNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public ushort KGJMNKOPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public short KBEFOMKFJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public short MIAKIPMOCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public char MPECDIPKGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public char IPKGOHFHIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public byte HJJEGDMNOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public byte LOGHODAKLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public byte OJALILJEJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public byte LNPJHJEMNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool EPLJNGDIDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public bool HCKGPNFLHJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool LJIHHGNPBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool IBEIFFGEIEL;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x20EC780", Offset = "0x20EB780", VA = "0x1820EC780")]
	public static AKECAGNFEBE PPECPBIACFO(uint LHEBALHFOND)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x20EC780", Offset = "0x20EB780", VA = "0x1820EC780")]
	public static AKECAGNFEBE FBAJFNDGCJP(int EPDONOMIGEB)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x82CF070", Offset = "0x82CE070", VA = "0x1882CF070")]
	public static AKECAGNFEBE DPPMAJHLJFL(float JJMJIAAHAEH)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x82CF110", Offset = "0x82CE110", VA = "0x1882CF110")]
	public static AKECAGNFEBE NMBEOKNBOMH(byte DLMGHFMLHPO, byte PJDEPMOBDBO, byte FBNJECLKMKG, byte FPMFMBCMGHK)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x82CF110", Offset = "0x82CE110", VA = "0x1882CF110")]
	public static AKECAGNFEBE MNIIAOPNFDD(bool DFOMHIJJNBH, bool PNKNGKHBBGF, bool JLBOOFEDCJP, bool BODJGCIGBMD)
	{
		return default(AKECAGNFEBE);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x82CF110", Offset = "0x82CE110", VA = "0x1882CF110")]
	public static AKECAGNFEBE FEAOIJKNDCA(byte JALCOBNAHHM, byte EFKHDIKBIIH, byte ELNPABNLGKL, byte PKBPJOCEOMI)
	{
		return default(AKECAGNFEBE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x242D030", Offset = "0x242C030", VA = "0x18242D030")]
	public static bool PHGIAKEDBEK(AKECAGNFEBE MLCJFBKFHOP, AKECAGNFEBE FPNPAOBAPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x242CF30", Offset = "0x242BF30", VA = "0x18242CF30", Slot = "4")]
	public bool Equals(AKECAGNFEBE EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x82CF080", Offset = "0x82CE080", VA = "0x1882CF080", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x152C290", Offset = "0x152B290", VA = "0x18152C290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x82CF130", Offset = "0x82CE130", VA = "0x1882CF130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct KEIBIMNCBEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public ulong AFECGHGIPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public long MPMCJLAKKOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public double MGEHEIPEPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public uint CGODOLLFFAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public uint CCPKKFBFHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public int HBHAHKDJGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public int LONCPFFCKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public float CPDKHKKKJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public float DJILPJEJEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public ushort BONFFOKGNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public ushort KGJMNKOPBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public ushort NLDGIAGNOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public ushort BPMJKHALBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public short KBEFOMKFJHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public short MIAKIPMOCGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public short BDMGHIPNFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public short DGPMFBAGEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public char MPECDIPKGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public char IPKGOHFHIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public char DIAJKCEDGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public char LCDMAFGCDPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public byte HJJEGDMNOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public byte LOGHODAKLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public byte OJALILJEJDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public byte LNPJHJEMNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	public byte LOFIOGFHNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	public byte CAHLGBDOEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	public byte IJDJIPLHHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public byte AJGHMDLGEOL;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static KEIBIMNCBEO MPFKOOIPONO(long IELBLOPPEJJ)
	{
		return default(KEIBIMNCBEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x82D9850", Offset = "0x82D8850", VA = "0x1882D9850")]
	public static KEIBIMNCBEO MPFKOOIPONO(byte DLMGHFMLHPO, byte PJDEPMOBDBO, byte FBNJECLKMKG, byte FPMFMBCMGHK, byte BMCACLFMOBJ, byte LLMAMFPMOIO, byte CIDJBCOJAIB, byte NIJDDFLHLCD)
	{
		return default(KEIBIMNCBEO);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000064")]
[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
public struct PDMEIHNDCPC : IEquatable<PDMEIHNDCPC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	public byte NGOOCDCNBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public bool KNIGENHBDGI;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x31661F0", Offset = "0x31651F0", VA = "0x1831661F0")]
	public static PDMEIHNDCPC NMBEOKNBOMH(byte DMKKOKPCHBO)
	{
		return default(PDMEIHNDCPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x31661F0", Offset = "0x31651F0", VA = "0x1831661F0")]
	public static PDMEIHNDCPC MNIIAOPNFDD(bool DLMOLCJCIJA)
	{
		return default(PDMEIHNDCPC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x82DB310", Offset = "0x82DA310", VA = "0x1882DB310")]
	public static bool PHGIAKEDBEK(PDMEIHNDCPC MLCJFBKFHOP, PDMEIHNDCPC FPNPAOBAPAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x7194550", Offset = "0x7193550", VA = "0x187194550", Slot = "4")]
	public bool Equals(PDMEIHNDCPC EDJHHGMLKFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x82DB270", Offset = "0x82DA270", VA = "0x1882DB270", Slot = "0")]
	public override bool Equals(object PGIOEBKALDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x82DB300", Offset = "0x82DA300", VA = "0x1882DB300", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x82DB320", Offset = "0x82DA320", VA = "0x1882DB320", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class GDGMBEIAEAH<T> : Exception where T : struct
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	public readonly T BKKKFCFBDAP;

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3580", Offset = "0x4EA2580", VA = "0x184EA3580")]
	public GDGMBEIAEAH(T CEOEONEOFDO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class DLAPCILENJM
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D7D0", Offset = "0x3A3C7D0", VA = "0x183A3D7D0")]
	public static IEnumerable<T> AIANHMIDJOK<T>() where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static T[] IILPCMIKDON<T>(params T[] CAHCOHCFHFM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0xDBBB10", Offset = "0xDBAB10", VA = "0x180DBBB10")]
	public static IEnumerable<T> DMMDMMBNBKJ<T>(params T[] CAHCOHCFHFM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x39D4600", Offset = "0x39D3600", VA = "0x1839D4600")]
	public static HashSet<T> ALKAHKGFEHA<T>(params T[] CAHCOHCFHFM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3A98FA0", Offset = "0x3A97FA0", VA = "0x183A98FA0")]
	public static KeyValuePair<TKey, TValue> EKFBIBGDHOL<TKey, TValue>([In] TKey DAKIIEIEKNI, [In] TValue IOALKPFEKEK) where TKey : notnull where TValue : notnull
	{
		return default(KeyValuePair<TKey, TValue>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x39D4600", Offset = "0x39D3600", VA = "0x1839D4600")]
	public static List<T> JHIFPPDPLID<T>(IEnumerable<T> NKOHPCLOFJA) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[AttributeUsage(AttributeTargets.All)]
public sealed class MLAGFKJAAFH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	public readonly string AHGOFHBKOBN;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
	public MLAGFKJAAFH(string BAEJCLGOEMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public delegate object MNOBPDIPKBE<T>([In] T DELLHDJPKBE);
[Cpp2IlInjected.Token(Token = "0x2000069")]
public delegate object KGOMNAFLOJH<T>(T DELLHDJPKBE);
[Cpp2IlInjected.Token(Token = "0x200006A")]
[KKIPOIIKBDF]
public delegate string BBOPEPECMJF(string NGKMMOMPFOH, string? DGMLMPAOEHN, bool BEFKNBFNAPN);
[Cpp2IlInjected.Token(Token = "0x200006B")]
[KKIPOIIKBDF]
public delegate void CDIGKPEMEPB(string OBCNAJEENCI);
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KKIPOIIKBDF]
public delegate void HDFFBLLKMIC(Exception MMCKGPNIIIO);
[Cpp2IlInjected.Token(Token = "0x200006D")]
public delegate object FILILBAOAIO();
[Cpp2IlInjected.Token(Token = "0x200006E")]
[KKIPOIIKBDF]
public delegate bool PNFMJAOPDPB();
[Cpp2IlInjected.Token(Token = "0x200006F")]
[KKIPOIIKBDF]
public delegate string DACAMHKPCKE(object PGIOEBKALDP);
[Cpp2IlInjected.Token(Token = "0x2000070")]
[AttributeUsage(AttributeTargets.Enum)]
public class PJCPEMBHIMH : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
	public PJCPEMBHIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class DANMLMIPPAF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private struct KBFHPODKBEM : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x82D8F00", Offset = "0x82D7F00", VA = "0x1882D8F00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x82D97E0", Offset = "0x82D87E0", VA = "0x1882D97E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private static readonly TimerCallback NDHENDPFKLL;

	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static readonly Action<object?> EEAJKOIHKIF;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x82D17E0", Offset = "0x82D07E0", VA = "0x1882D17E0")]
	public static Task<bool> PDIBHHGFHGJ(int MOGCEHMBIDD, [Optional] CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x82D1590", Offset = "0x82D0590", VA = "0x1882D1590")]
	[AsyncStateMachine(typeof(KBFHPODKBEM))]
	private static Task<bool> GCDCAEFFPFF(int MOGCEHMBIDD, CancellationToken KGALDHLEDNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x82D1750", Offset = "0x82D0750", VA = "0x1882D1750")]
	private static void INLHBHHFKHJ(object? GICMHPOANOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x82D16C0", Offset = "0x82D06C0", VA = "0x1882D16C0")]
	private static void GJBGEJMHKPK(object? GICMHPOANOB)
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
