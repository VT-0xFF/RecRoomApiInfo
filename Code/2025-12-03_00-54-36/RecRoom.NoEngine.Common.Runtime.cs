using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common.Delegates;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8316EB0", Offset = "0x8315AB0", VA = "0x188316EB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace System.Text
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class YRBTGLQVTUI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x831C6F0", Offset = "0x831B2F0", VA = "0x18831C6F0")]
		public static string LSYQVOCHFCM(this Encoding a, [In] ReadOnlySequence<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3C02B80", Offset = "0x3C01780", VA = "0x183C02B80")]
		private static void FLICJJDIVGB<a>(this ReadOnlySequence<a> sequence, [Out] ReadOnlySpan<a> firstSpan, [Out] SequencePosition a)
		{
		}
	}
}
namespace System.Diagnostics.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property, AllowMultiple = true, Inherited = false)]
	public sealed class MemberNotNullWhenAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8316D20", Offset = "0x8315920", VA = "0x188316D20")]
		public MemberNotNullWhenAttribute(bool returnValue, string member)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8316DD0", Offset = "0x83159D0", VA = "0x188316DD0")]
		public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class DSJADUTKULM
	{
	}
}
namespace RecRoom.DebugStats
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface COKMELLJRQK
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool KSUYSHBDFFC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BYOZFFQPSMM(string a, double b, [Optional] string? unit);
	}
}
namespace RecRoom.Analytics
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MBYEYYGAJNS : COWDDSZUSXM, SFTJYLLNBGE, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int PFSQVTCSWRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Queue<double> IZIDNJAQVYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private double MSUWNWXIXSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private double OLSBQUAKIOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private double YZAPUDXWGRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int MLOWIIAFFRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private double ARVFAGYHZXZ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int OPJJOUMYGFK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAC5FE0", Offset = "0xAC4BE0", VA = "0x180AC5FE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public double VLQPNNEYWFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x83166C0", Offset = "0x83152C0", VA = "0x1883166C0", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public double CQPPHSXXBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x27F2D20", Offset = "0x27F1920", VA = "0x1827F2D20", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double EJMUKQAYMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2815A90", Offset = "0x2814690", VA = "0x182815A90", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x83169B0", Offset = "0x83155B0", VA = "0x1883169B0")]
		public MBYEYYGAJNS(int a, double b = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8316880", Offset = "0x8315480", VA = "0x188316880", Slot = "7")]
		public void SQYPXVXKXRA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8316810", Offset = "0x8315410", VA = "0x188316810", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8316720", Offset = "0x8315320", VA = "0x188316720", Slot = "9")]
		public object Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ZJEUURDBFAU : COWDDSZUSXM, SFTJYLLNBGE, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private long JMQLFWTJZBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private double JTKFSXYSPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private double YCLRCJTLQGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private double CNFYEVLEGHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private double ZKEUHTRAXXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private double MSUWNWXIXSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private double OLSBQUAKIOT;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long PAZVGVVRFWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public double CQPPHSXXBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4C86BC0", Offset = "0x4C857C0", VA = "0x184C86BC0", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public double EJMUKQAYMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xB2A310", Offset = "0xB28F10", VA = "0x180B2A310", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public double PZEDYUPEDYP
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB2A300", Offset = "0xB28F00", VA = "0x180B2A300")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public double VLQPNNEYWFQ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x27F2D10", Offset = "0x27F1910", VA = "0x1827F2D10", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x831D370", Offset = "0x831BF70", VA = "0x18831D370", Slot = "10")]
		public virtual void SQYPXVXKXRA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x831D330", Offset = "0x831BF30", VA = "0x18831D330", Slot = "11")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x831D2D0", Offset = "0x831BED0", VA = "0x18831D2D0", Slot = "9")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8310540", Offset = "0x830F140", VA = "0x188310540")]
		public ZJEUURDBFAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class DAYHAQPEDQC : ZJEUURDBFAU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public double MWZLNKAJMPU
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xB2A2F0", Offset = "0xB28EF0", VA = "0x180B2A2F0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x75C6F20", Offset = "0x75C5B20", VA = "0x1875C6F20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8310410", Offset = "0x830F010", VA = "0x188310410", Slot = "10")]
		public override void SQYPXVXKXRA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83103D0", Offset = "0x830EFD0", VA = "0x1883103D0", Slot = "11")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8310540", Offset = "0x830F140", VA = "0x188310540")]
		public DAYHAQPEDQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface COWDDSZUSXM : SFTJYLLNBGE, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		double VLQPNNEYWFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		double CQPPHSXXBJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		double EJMUKQAYMGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QQIBKBMXTWL : SFTJYLLNBGE, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private double RNIOQZKSSIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private double FRXRUPIDVZX;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public double KBCQUAEOSXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8317350", Offset = "0x8315F50", VA = "0x188317350")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x70A2CD0", Offset = "0x70A18D0", VA = "0x1870A2CD0", Slot = "4")]
		public void SQYPXVXKXRA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8317360", Offset = "0x8315F60", VA = "0x188317360", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8317300", Offset = "0x8315F00", VA = "0x188317300", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public QQIBKBMXTWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SFTJYLLNBGE : ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SQYPXVXKXRA(double a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class ITNCICUDGPF : SFTJYLLNBGE, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private double UDFFPHHYYHW;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double KBCQUAEOSXO
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xF4FD90", Offset = "0xF4E990", VA = "0x180F4FD90")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5768C00", Offset = "0x5767800", VA = "0x185768C00", Slot = "4")]
		public void SQYPXVXKXRA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8313E20", Offset = "0x8312A20", VA = "0x188313E20", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8313DD0", Offset = "0x83129D0", VA = "0x188313DD0", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ITNCICUDGPF()
		{
		}
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ZCIEDSNRWUX<a> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate Task<a> TaskGenerator(CancellationToken cancellationToken);

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <Debounce>d__4 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<a> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public ZCIEDSNRWUX<a> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public TaskGenerator taskGenerator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private TaskCompletionSource<a> <tcs>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private CancellationTokenSource <runningCancellationTokenSource>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private TaskAwaiter<a> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x4D58EB0", Offset = "0x4D57AB0", VA = "0x184D58EB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x4D5B050", Offset = "0x4D59C50", VA = "0x184D5B050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly CancellationTokenSource WNMHKZWJWAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CancellationTokenSource? BGKRMEUZJDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskCompletionSource<a>? JYVEALIRRYM;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3E94020", Offset = "0x3E92C20", VA = "0x183E94020")]
		[AsyncStateMachine(typeof(ZCIEDSNRWUX<>.<Debounce>d__4))]
		public Task<a> ZZAJTIXQBAY(TaskGenerator taskGenerator, [Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3E93FB0", Offset = "0x3E92BB0", VA = "0x183E93FB0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3E94290", Offset = "0x3E92E90", VA = "0x183E94290")]
		public ZCIEDSNRWUX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class Box<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly EqualityComparer<T> SJIXENJDGYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T KBCQUAEOSXO;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4E33540", Offset = "0x4E32140", VA = "0x184E33540")]
		public Box([In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7015DD0", Offset = "0x70149D0", VA = "0x187015DD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7016970", Offset = "0x7015570", VA = "0x187016970", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7016B50", Offset = "0x7015750", VA = "0x187016B50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3456820", Offset = "0x3455420", VA = "0x183456820")]
		public static Box<T> New<T>([In] T value) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class QCNDMBCEMRE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x83172D0", Offset = "0x8315ED0", VA = "0x1883172D0")]
		public static void GBAFKKDDUPV(this CancellationTokenSource a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
	public class CS9FunctionPointerAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public CS9FunctionPointerAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
	public class CS9ImprovedNullableConstraints : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public CS9ImprovedNullableConstraints(string why)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class VKZPGPAZIWR
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3BCDA60", Offset = "0x3BCC660", VA = "0x183BCDA60")]
		public static LogString GPGWTKCXRNU<a>()
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x831C460", Offset = "0x831B060", VA = "0x18831C460")]
		public static LogString REKMQQZTVRO([CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3BCE2D0", Offset = "0x3BCCED0", VA = "0x183BCE2D0")]
		public static LogString SOARIMRAGXS<T>([CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3BCDAD0", Offset = "0x3BCC6D0", VA = "0x183BCDAD0")]
		public static LogString GPGWTKCXRNU<T>(this T a) where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3BCE3C0", Offset = "0x3BCCFC0", VA = "0x183BCE3C0")]
		public static LogString SOARIMRAGXS<T>(this T a, [CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x831C4C0", Offset = "0x831B0C0", VA = "0x18831C4C0")]
		public static LogString SOARIMRAGXS(string a, [CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x831C540", Offset = "0x831B140", VA = "0x18831C540")]
		public static string ZOQWAJSZZST(this object a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public delegate bool GetIsQuittingDelegate();
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CS9FunctionPointer]
	public delegate long GetOngoingTicksDelegate();
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public sealed class ZTRCGVOXLMK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly ZTRCGVOXLMK PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public ZTRCGVOXLMK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class JMLDOSMILIY
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static EngineShimState SUHXZVBAMKU;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static EngineShimState AZMHDQYZLIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x83153B0", Offset = "0x8313FB0", VA = "0x1883153B0")]
			get
			{
				return default(EngineShimState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LogDelegates DPTDVDKHQOV
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x8314F60", Offset = "0x8313B60", VA = "0x188314F60")]
			get
			{
				return default(LogDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static PerfScopeDelegates DELSAIIBRQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8315080", Offset = "0x8313C80", VA = "0x188315080")]
			get
			{
				return default(PerfScopeDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static bool TANBOEEVVSY
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8315240", Offset = "0x8313E40", VA = "0x188315240")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8314DC0", Offset = "0x83139C0", VA = "0x188314DC0")]
		public static void DEVGRMJRIHQ([In] EngineShimState engineShimState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x83150D0", Offset = "0x8313CD0", VA = "0x1883150D0")]
		public static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8315470", Offset = "0x8314070", VA = "0x188315470")]
		public static void XKWSIQEAOSL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3723080", Offset = "0x3721C80", VA = "0x183723080")]
		public static void XKWSIQEAOSL<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8315310", Offset = "0x8313F10", VA = "0x188315310")]
		public static void UZIMCWKUHKA(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x83152B0", Offset = "0x8313EB0", VA = "0x1883152B0")]
		public static void UDDBYQOJOAB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8315540", Offset = "0x8314140", VA = "0x188315540")]
		public static void YQXHGYHFTOV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x83155A0", Offset = "0x83141A0", VA = "0x1883155A0")]
		public static string ZOQWAJSZZST(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8315400", Offset = "0x8314000", VA = "0x188315400")]
		public static long WQPPUQUUUWE()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x83151A0", Offset = "0x8313DA0", VA = "0x1883151A0")]
		public static bool NEZLJIDGDJU(bool a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8314FB0", Offset = "0x8313BB0", VA = "0x188314FB0")]
		public static double LBIOZGENHNN()
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public readonly struct EngineShimState
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly LogDelegates LogDelegates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly PerfScopeDelegates PerfScopeDelegates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly ToDebugJsonDelegate ToDebugJsonDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public readonly GetOngoingTicksDelegate GetOngoingTicksDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public readonly FormatAsyncCallstackDelegate FormatAsyncCallstackDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public readonly GetIsQuittingDelegate GetIsQuittingDelegate;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public static readonly ToDebugJsonDelegate EmptyToDebugJsonDelegate;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public static readonly GetOngoingTicksDelegate EmptyGetOngoingTicksDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public static readonly FormatAsyncCallstackDelegate EmptyFormatAsyncCallstackDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static readonly GetIsQuittingDelegate EmptyGetIsQuittingDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly EngineShimState Empty;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool XIYOMFQFIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8310760", Offset = "0x830F360", VA = "0x188310760")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8310ED0", Offset = "0x830FAD0", VA = "0x188310ED0")]
		public EngineShimState([In] LogDelegates logDelegates, [In] PerfScopeDelegates perfScopeDelegates, ToDebugJsonDelegate toDebugJsonDelegate, GetOngoingTicksDelegate getOngoingTicksDelegate, FormatAsyncCallstackDelegate formatAsyncCallstackDelegate, GetIsQuittingDelegate getIsQuittingDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xBEC860", Offset = "0xBEB460", VA = "0x180BEC860")]
		private static string CBTLVXQCRMG(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA96160", Offset = "0xA94D60", VA = "0x180A96160")]
		private static long VHAONZBGLOR()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960")]
		private static string XMQSXKRCPCX(string a, string? prefix, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		private static bool ISVPKCKQASD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8310650", Offset = "0x830F250", VA = "0x188310650")]
		private static EngineShimState DATIDMKDUAM()
		{
			return default(EngineShimState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface GOBWESELGYH<a> where a : notnull, NWNCJNHUMKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a UCKUBDUZFPI();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface NWNCJNHUMKH : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool NKEZNUYAGGQ
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AGOXQMNLUBO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface GBMNYUSYUQI<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool BQMHWPIWXMR([In] a other);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void InAction<T>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct IndexValuePair<T> : IEquatable<IndexValuePair<T>>, GBMNYUSYUQI<IndexValuePair<T>> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly int Index;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x2E61CA0", Offset = "0x2E608A0", VA = "0x182E61CA0")]
		public IndexValuePair([In] T value, int index)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x4FBE4E0", Offset = "0x4FBD0E0", VA = "0x184FBE4E0")]
		public static bool OKWKXGGAXFT([In] IndexValuePair<T> left, [In] IndexValuePair<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4FBDC00", Offset = "0x4FBC800", VA = "0x184FBDC00", Slot = "4")]
		public bool Equals(IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x4FBDAC0", Offset = "0x4FBC6C0", VA = "0x184FBDAC0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x4FBC690", Offset = "0x4FBB290", VA = "0x184FBC690")]
		public bool BQMHWPIWXMR([In] IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4FBDED0", Offset = "0x4FBCAD0", VA = "0x184FBDED0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x4FC09F0", Offset = "0x4FBF5F0", VA = "0x184FC09F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4FBFF80", Offset = "0x4FBEB80", VA = "0x184FBFF80")]
		public void QWOWOOZCIPT([Out] T a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4FBD3D0", Offset = "0x4FBBFD0", VA = "0x184FBD3D0")]
		public (T, int) DEOOLWQMWSI()
		{
			return default((T, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4FBCE10", Offset = "0x4FBBA10", VA = "0x184FBCE10", Slot = "5")]
		private bool BYNPDWTYIIO([In] IndexValuePair<T> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class FRIKDCDTEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x367ED70", Offset = "0x367D970", VA = "0x18367ED70")]
		public static IndexValuePair<T> New<T>([In] T value, int index) where T : notnull
		{
			return default(IndexValuePair<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class SQJMQUEWWPR
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B010", Offset = "0x3A39C10", VA = "0x183A3B010")]
		public static bool BQMHWPIWXMR<T, U>([In] T self, [In] U obj) where T : notnull, GBMNYUSYUQI<T> where U : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate TResult InFunc<T, out TResult>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface BZNKTGGYCXZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		TimeSpan LVJRZBYJQBY
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		Action? FEFZBACVSUF
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(Slot = "2")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Start();

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void XVHNTYOFVDE();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void Stop();
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public readonly struct LogDelegates
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public readonly ShouldLogDelegate ShouldLogDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public readonly LogDelegate LogDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public readonly ShouldLogDelegate ShouldLogWarningDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public readonly LogDelegate LogWarningDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public readonly ShouldLogDelegate ShouldLogErrorDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public readonly LogDelegate LogErrorDelegate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public readonly LogExceptionDelegate LogExceptionDelegate;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly ShouldLogDelegate EmptyShouldLogDelegate;

		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public static readonly LogDelegate EmptyLogDelegate;

		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public static readonly ShouldLogDelegate EmptyShouldLogWarningDelegate;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public static readonly LogDelegate EmptyLogWarningDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly ShouldLogDelegate EmptyShouldLogErrorDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public static readonly LogDelegate EmptyLogErrorDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly LogExceptionDelegate EmptyLogExceptionDelegate;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly LogDelegates Empty;

		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public static readonly ShouldLogDelegate AlwaysShouldLogDelegate;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool XIYOMFQFIIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x83159D0", Offset = "0x83145D0", VA = "0x1883159D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xBF8AD0", Offset = "0xBF76D0", VA = "0x180BF8AD0")]
		public LogDelegates(ShouldLogDelegate shouldLogDelegate, LogDelegate logDelegate, ShouldLogDelegate shouldLogWarningDelegate, LogDelegate logWarningDelegate, ShouldLogDelegate shouldLogErrorDelegate, LogDelegate logErrorDelegate, LogExceptionDelegate logExceptionDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		private static bool KLQOYMPRXQL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void HVWZCVAKWLA(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		private static bool NHPQMGASWMZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void WRXHIHEXWPE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
		private static bool SWCBZPVBLJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void VIJTMGVPHQM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void ATVGUOTQRYL(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x83156E0", Offset = "0x83142E0", VA = "0x1883156E0")]
		private static LogDelegates DATIDMKDUAM()
		{
			return default(LogDelegates);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0")]
		private static bool BKULUQCHGYV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8315890", Offset = "0x8314490", VA = "0x188315890")]
		public void Log(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8315820", Offset = "0x8314420", VA = "0x188315820")]
		public void JXCZAZBXOGF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8315CB0", Offset = "0x83148B0", VA = "0x188315CB0")]
		public void XKWSIQEAOSL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xBF8920", Offset = "0xBF7520", VA = "0x180BF8920")]
		public void UZIMCWKUHKA(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8315BD0", Offset = "0x83147D0", VA = "0x188315BD0")]
		public void XKWSIQEAOSL(MessageFunc a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x379F380", Offset = "0x379DF80", VA = "0x18379F380")]
		public void XKWSIQEAOSL<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x379F200", Offset = "0x379DE00", VA = "0x18379F200")]
		public void Log<T>([In] T arg, FastestMessageFunc<T> message) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x379F660", Offset = "0x379E260", VA = "0x18379F660")]
		public void XKWSIQEAOSL<T>([In] T arg, FastestMessageFunc<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8315900", Offset = "0x8314500", VA = "0x188315900")]
		public bool NEZLJIDGDJU(bool a, string b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public readonly struct LogString
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly string Value;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
		public LogString(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBB8ED0", Offset = "0xBB7AD0", VA = "0x180BB8ED0")]
		public static implicit operator string([In] LogString self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xDE5490", Offset = "0xDE4090", VA = "0x180DE5490")]
		public static implicit operator LogString(string other)
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8316670", Offset = "0x8315270", VA = "0x188316670")]
		public string RMJMPPLYVKH(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x8316590", Offset = "0x8315190", VA = "0x188316590")]
		public string IWUEWVFPASR(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xBB8ED0", Offset = "0xBB7AD0", VA = "0x180BB8ED0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AttributeUsage(AttributeTargets.Method)]
	public class MustUseReturnValueAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public MustUseReturnValueAttribute()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct None : IEquatable<None>
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAB0AB0", Offset = "0xAAF6B0", VA = "0x180AB0AB0", Slot = "4")]
		public bool Equals(None other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8316E20", Offset = "0x8315A20", VA = "0x188316E20", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8316E70", Offset = "0x8315A70", VA = "0x188316E70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8316E80", Offset = "0x8315A80", VA = "0x188316E80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[Todo("Now that `#nullable enable` is supported in our project, we should probably prefer that. The whole point of this type was to force checking before getting a value.`#nullable enable` can also force checking.")]
	public readonly struct Option<T> : IEquatable<Option<T>> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly bool IsSome;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool GAHVXABNFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x257D580", Offset = "0x257C180", VA = "0x18257D580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x59BC8E0", Offset = "0x59BB4E0", VA = "0x1859BC8E0")]
		public Option([In] T value, bool isValid)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x59BB5E0", Offset = "0x59BA1E0", VA = "0x1859BB5E0")]
		public static bool OKWKXGGAXFT([In] Option<T> left, [In] Option<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x59B9740", Offset = "0x59B8340", VA = "0x1859B9740", Slot = "4")]
		public bool Equals(Option<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x59BA1F0", Offset = "0x59B8DF0", VA = "0x1859BA1F0", Slot = "0")]
		public override bool Equals(object? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x59BA940", Offset = "0x59B9540", VA = "0x1859BA940", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x59BC320", Offset = "0x59BAF20", VA = "0x1859BC320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class FKRUFQZVPIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x367D300", Offset = "0x367BF00", VA = "0x18367D300")]
		public static Option<T> TYMECFWDYRZ<T>([In] T value) where T : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x367CE60", Offset = "0x367BA60", VA = "0x18367CE60")]
		public static Option<T?> None<T>()
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x367D6F0", Offset = "0x367C2F0", VA = "0x18367D6F0")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x367D680", Offset = "0x367C280", VA = "0x18367D680")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value, [Out] Option<T> res) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x367CF90", Offset = "0x367BB90", VA = "0x18367CF90")]
		public static a? SAGSJXCZCRX<a>([In] this Option<a> opt, a? a)
		{
			return (a?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x367C7A0", Offset = "0x367B3A0", VA = "0x18367C7A0")]
		public static bool HURUYXPBAJZ<T>([In] this Option<T> opt, T a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class BXIRDFHRNSH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x33A33C0", Offset = "0x33A1FC0", VA = "0x1833A33C0")]
		public static a RHTCBIGUQPJ<a>([In] this Option<a> opt) where a : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class GXLNDPCTDGQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8311040", Offset = "0x830FC40", VA = "0x188311040")]
		public static bool SLYXYQHNFGA(int a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct PerfScopeDelegates
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public readonly IntPtr BeginPerfScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly IntPtr EndPerfScope;

		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public static readonly IntPtr EmptyBeginPerfScopeDelegate;

		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public static readonly IntPtr EmptyEndPerfScopeDelegate;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly PerfScopeDelegates Empty;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool XIYOMFQFIIA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8316FC0", Offset = "0x8315BC0", VA = "0x188316FC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xDE2580", Offset = "0xDE1180", VA = "0x180DE2580")]
		public PerfScopeDelegates(IntPtr beginPerfScope, IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void ULUEVJFNVTU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		private static void PSRXCFSYCTY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8316F30", Offset = "0x8315B30", VA = "0x188316F30")]
		private static PerfScopeDelegates DATIDMKDUAM()
		{
			return default(PerfScopeDelegates);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly ref struct PerfScopeToken
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private readonly IntPtr _endPerfScope;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x1105300", Offset = "0x1103F00", VA = "0x181105300")]
		private PerfScopeToken(IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x83171E0", Offset = "0x8315DE0", VA = "0x1883171E0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x83171F0", Offset = "0x8315DF0", VA = "0x1883171F0")]
		public static PerfScopeToken New(string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x28A2810", Offset = "0x28A1410", VA = "0x1828A2810")]
		public static PerfScopeToken New([In] PerfScopeDelegates perfScopeDelegates, string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x28A25C0", Offset = "0x28A11C0", VA = "0x1828A25C0")]
		public static PerfScopeToken New([In] PerfScopeDelegates perfScopeDelegates, Func<string> name)
		{
			return default(PerfScopeToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Obfuscation(Exclude = true)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public PreserveAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class HOFPPTRYALV : SHA256
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static bool? NGGMXCCFMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IntPtr BPGMFTUSUGM;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static bool ULHEILELPVK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8311630", Offset = "0x8310230", VA = "0x188311630")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x83110D0", Offset = "0x830FCD0", VA = "0x1883110D0")]
		public new static SHA256 Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8311340", Offset = "0x830FF40", VA = "0x188311340")]
		private static extern int GetSHA256DigestSize();

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8311060", Offset = "0x830FC60", VA = "0x188311060")]
		private static extern IntPtr CreateSHA256();

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x83111E0", Offset = "0x830FDE0", VA = "0x1883111E0")]
		private static extern void DestroySHA256(IntPtr sha256);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x83116E0", Offset = "0x83102E0", VA = "0x1883116E0")]
		private static extern void UpdateSHA256Digest(IntPtr sha256, byte[] data, int offset, int dataLength);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x83112A0", Offset = "0x830FEA0", VA = "0x1883112A0")]
		private static extern void FinalSHA256Digest(IntPtr sha256, byte[] digest);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x83117A0", Offset = "0x83103A0", VA = "0x1883117A0")]
		private HOFPPTRYALV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x83113B0", Offset = "0x830FFB0", VA = "0x1883113B0", Slot = "18")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8311470", Offset = "0x8310070", VA = "0x188311470", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x83115A0", Offset = "0x83101A0", VA = "0x1883115A0", Slot = "20")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8311260", Offset = "0x830FE60", VA = "0x188311260", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class ILUPRZIZCJT
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public delegate bool TryTransformFunction<in TInput, TResult>(TInput input, [Out] TResult result);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class SAAAFTYAZLK : GOBWESELGYH<NWNCJNHUMKH>
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			private sealed class HOWZRUICEXN : NWNCJNHUMKH, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				public static readonly HOWZRUICEXN PGFSJHGESKI;

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public bool NKEZNUYAGGQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0x8311930", Offset = "0x8310530", VA = "0x188311930", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x83117D0", Offset = "0x83103D0", VA = "0x1883117D0", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
				public void AGOXQMNLUBO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
				public HOWZRUICEXN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly SAAAFTYAZLK PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private SAAAFTYAZLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x8317370", Offset = "0x8315F70", VA = "0x188317370", Slot = "4")]
			public NWNCJNHUMKH UCKUBDUZFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class SYESKSKCTIL : GOBWESELGYH<NWNCJNHUMKH>
		{
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			private sealed class DRDFMINOBGI : NWNCJNHUMKH, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public static readonly DRDFMINOBGI PGFSJHGESKI;

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public bool NKEZNUYAGGQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0x83105C0", Offset = "0x830F1C0", VA = "0x1883105C0", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000108")]
				[Cpp2IlInjected.Address(RVA = "0x8310570", Offset = "0x830F170", VA = "0x188310570", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "5")]
				public void AGOXQMNLUBO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
				public DRDFMINOBGI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly SYESKSKCTIL PGFSJHGESKI;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			private SYESKSKCTIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8317430", Offset = "0x8316030", VA = "0x188317430", Slot = "4")]
			public NWNCJNHUMKH UCKUBDUZFPI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class NZUZJZNCYOU<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public TaskCompletionSource<a> FKUVMPIJOON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public CancellationToken HROQVQQIJZL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public CancellationTokenRegistration SLFNVGHNQLM;

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public NZUZJZNCYOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x57B0CC0", Offset = "0x57AF8C0", VA = "0x1857B0CC0")]
			internal void UXCDGSLSSAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x57B0D30", Offset = "0x57AF930", VA = "0x1857B0D30")]
			internal void UXHKDZFQBMH(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class CRQWXMXIQTK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public TaskCompletionSource<None> UPSUWKZBRXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int QFDJABVOZXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Action<Task> HUVVFXMGSVM;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public CRQWXMXIQTK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x83102C0", Offset = "0x830EEC0", VA = "0x1883102C0")]
			internal void TOZSRXTTXXW(Task a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class MLXEEDMOGFZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Func<bool> VZHDGEKJQYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public TimeSpan GDIIKNTJCZN;

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public MLXEEDMOGFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8316CB0", Offset = "0x83158B0", VA = "0x188316CB0")]
			internal Task WKAQEIWCPZL(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class IYUJLYMVERT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Func<bool> VZHDGEKJQYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public TimeSpan GDIIKNTJCZN;

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public IYUJLYMVERT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x8314520", Offset = "0x8313120", VA = "0x188314520")]
			internal Task LTGUFBVPHHS(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class BQZSGHCYFBZ<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public TaskCompletionSource<a> UPSUWKZBRXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken JYQZVSPGEXW;

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public BQZSGHCYFBZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x6E5B090", Offset = "0x6E59C90", VA = "0x186E5B090")]
			internal void WEVOWOKZPGE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class KRQLEYHUQRC<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public CancellationTokenRegistration SLFNVGHNQLM;

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public KRQLEYHUQRC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x4D9DE60", Offset = "0x4D9CA60", VA = "0x184D9DE60")]
			internal void WFAVTVEWYRN(Task<a> a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <FireAndForget>d__9 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Task t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x8317600", Offset = "0x8316200", VA = "0x188317600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xAF5C80", Offset = "0xAF4880", VA = "0x180AF5C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct <FireAndForgetSilent>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public Task t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x83174F0", Offset = "0x83160F0", VA = "0x1883174F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xAF5C80", Offset = "0xAF4880", VA = "0x180AF5C80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct <IgnoreException>d__11<TException> : IAsyncStateMachine where TException : notnull, Exception
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Task t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x4E6A8A0", Offset = "0x4E694A0", VA = "0x184E6A8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x4E6AA10", Offset = "0x4E69610", VA = "0x184E6AA10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct <LogAndRethrowExceptions>d__15<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public Task<T> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public bool logCancellations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Log log;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public Func<Task<T>, string> logMessageFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x4F714F0", Offset = "0x4F700F0", VA = "0x184F714F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x4F71E60", Offset = "0x4F70A60", VA = "0x184F71E60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <LogAndRethrowExceptions>d__16<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Task<T> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x4F72950", Offset = "0x4F71550", VA = "0x184F72950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x4F72D30", Offset = "0x4F71930", VA = "0x184F72D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <LogAndRethrowExceptions>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public Task self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x8317760", Offset = "0x8316360", VA = "0x188317760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x83179E0", Offset = "0x83165E0", VA = "0x1883179E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <LogExceptions>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public Task self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x8317A40", Offset = "0x8316640", VA = "0x188317A40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x8317C50", Offset = "0x8316850", VA = "0x188317C50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <RunOnMainThread>d__68 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Func<Task> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8317CC0", Offset = "0x83168C0", VA = "0x188317CC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8317FF0", Offset = "0x8316BF0", VA = "0x188317FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <RunWhile>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			public Func<CancellationToken, Task> innerTaskConstructor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public Task t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			private Task <innerTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private TaskAwaiter<TaskStatus> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8318050", Offset = "0x8316C50", VA = "0x188318050", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x8318760", Offset = "0x8317360", VA = "0x188318760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <Then>d__50 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public Task task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Action then;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x83187C0", Offset = "0x83173C0", VA = "0x1883187C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x8318940", Offset = "0x8317540", VA = "0x188318940", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <Then>d__51<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Task<T> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public Action<T> then;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x51BB6E0", Offset = "0x51BA2E0", VA = "0x1851BB6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x51BBB00", Offset = "0x51BA700", VA = "0x1851BBB00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <TryTransformList>d__24<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Task<List<TInput>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public TryTransformFunction<TInput, TResult> transformFunction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private TaskAwaiter<List<TInput>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x524DC60", Offset = "0x524C860", VA = "0x18524DC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x524ED60", Offset = "0x524D960", VA = "0x18524ED60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <Until>d__44 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8319A00", Offset = "0x8318600", VA = "0x188319A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8319BE0", Offset = "0x83187E0", VA = "0x188319BE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <Until>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8319C40", Offset = "0x8318840", VA = "0x188319C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8319FA0", Offset = "0x8318BA0", VA = "0x188319FA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <UntilWithTimeout>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x831A000", Offset = "0x8318C00", VA = "0x18831A000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x831A2F0", Offset = "0x8318EF0", VA = "0x18831A2F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <UntilWithTimeout>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x831A350", Offset = "0x8318F50", VA = "0x18831A350", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x831A5A0", Offset = "0x83191A0", VA = "0x18831A5A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <WaitAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public Func<CancellationToken, Task> taskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private CancellationTokenSource <linkedCTS>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x831A600", Offset = "0x8319200", VA = "0x18831A600", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x831AB40", Offset = "0x8319740", VA = "0x18831AB40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <WaitAsync>d__27<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public Func<CancellationToken, Task<T>> taskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public Func<OperationCanceledException, T> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private CancellationTokenSource <linkedCTS>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x5254090", Offset = "0x5252C90", VA = "0x185254090", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x5254FC0", Offset = "0x5253BC0", VA = "0x185254FC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <WhenAllSafe>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public AsyncTaskMethodBuilder<IEnumerable<Task>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public IEnumerable<Task> tasks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private Task[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x831ABA0", Offset = "0x83197A0", VA = "0x18831ABA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x831AE20", Offset = "0x8319A20", VA = "0x18831AE20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <WhenAllSafe>d__32<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public IEnumerable<Task<T>> tasks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private Task<T>[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x5257690", Offset = "0x5256290", VA = "0x185257690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x4DBE440", Offset = "0x4DBD040", VA = "0x184DBE440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <WhenAllTyped>d__34<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Task<T1> task1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public Task<T2> task2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public Task<T3> task3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x5257EE0", Offset = "0x5256AE0", VA = "0x185257EE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x5258CC0", Offset = "0x52578C0", VA = "0x185258CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <WhenAllTyped>d__36<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Task<T1> task1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Task<T2> task2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Task<T3> task3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public Task<T4> task4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Task<T5> task5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x52598E0", Offset = "0x52584E0", VA = "0x1852598E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x525A0C0", Offset = "0x5258CC0", VA = "0x18525A0C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private struct <While>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x831AE90", Offset = "0x8319A90", VA = "0x18831AE90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x831B070", Offset = "0x8319C70", VA = "0x18831B070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private struct <While>d__39 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x831B0D0", Offset = "0x8319CD0", VA = "0x18831B0D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x831B440", Offset = "0x831A040", VA = "0x18831B440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct <WhileWithTimeout>d__41 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x831B4A0", Offset = "0x831A0A0", VA = "0x18831B4A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x831B790", Offset = "0x831A390", VA = "0x18831B790", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private struct <WhileWithTimeout>d__42 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x831B7F0", Offset = "0x831A3F0", VA = "0x18831B7F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x831BA40", Offset = "0x831A640", VA = "0x18831BA40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static SynchronizationContext? USPDABROJWG;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly TaskCompletionSource<None> YFIOCMKNOJI;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static Task QBEQNVKHCBU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8312EE0", Offset = "0x8311AE0", VA = "0x188312EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8311C80", Offset = "0x8310880", VA = "0x188311C80")]
		public static bool DEUYAOEBRBD(this Task a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x36F7D00", Offset = "0x36F6900", VA = "0x1836F7D00")]
		public static Task<T> DWXQHASISJG<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83123E0", Offset = "0x8310FE0", VA = "0x1883123E0")]
		public static Task HNGGCZKXUEU(this Task a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x36FAE10", Offset = "0x36F9A10", VA = "0x1836FAE10")]
		public static Task<TResult> HNGGCZKXUEU<TResult>(this Task<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x36F8F50", Offset = "0x36F7B50", VA = "0x1836F8F50")]
		public static TaskCompletionSource<TResult> HNGGCZKXUEU<TResult>(this TaskCompletionSource<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x83129D0", Offset = "0x83115D0", VA = "0x1883129D0")]
		public static IDisposable? LLFRZJPTGXD(CancellationToken a, CancellationToken b, [Out] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8313AE0", Offset = "0x83126E0", VA = "0x188313AE0")]
		[AsyncStateMachine(typeof(<FireAndForget>d__9))]
		public static void ZCCCEEBJRHT(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x8312DE0", Offset = "0x83119E0", VA = "0x188312DE0")]
		[AsyncStateMachine(typeof(<FireAndForgetSilent>d__10))]
		public static void PZTUKUNLCJK(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x36FD470", Offset = "0x36FC070", VA = "0x1836FD470")]
		[AsyncStateMachine(typeof(<IgnoreException>d__11<>))]
		public static Task UBUMRAYPVYC<TException>(this Task a) where TException : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x36FDD90", Offset = "0x36FC990", VA = "0x1836FDD90")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__15<>))]
		public static Task<T> ZXUZHMCAKPP<T>(this Task<T> a, Log b, Func<Task<T>, string> c, bool d = false) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x36FDBB0", Offset = "0x36FC7B0", VA = "0x1836FDBB0")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__16<>))]
		public static Task<T> ZXUZHMCAKPP<T>(this Task<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8313B90", Offset = "0x8312790", VA = "0x188313B90")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__17))]
		public static Task ZXUZHMCAKPP(this Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8312B60", Offset = "0x8311760", VA = "0x188312B60")]
		[AsyncStateMachine(typeof(<LogExceptions>d__18))]
		public static Task<TaskStatus> LTLUSWWZXVD(this Task? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x36FCF60", Offset = "0x36FBB60", VA = "0x1836FCF60")]
		public static (Task<b?>?, Action<b?>?) QELOKKAFBPO<b>([Optional] CancellationToken a)
		{
			return default((Task<b>, Action<b>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x36F7EF0", Offset = "0x36F6AF0", VA = "0x1836F7EF0")]
		[AsyncStateMachine(typeof(<TryTransformList>d__24<, >))]
		public static Task<List<TResult>> FKTWPUVUTZW<TResult, TInput>(this Task<List<TInput>> a, TryTransformFunction<TInput, TResult> b) where TResult : notnull where TInput : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8312630", Offset = "0x8311230", VA = "0x188312630")]
		[AsyncStateMachine(typeof(<RunWhile>d__25))]
		public static Task JMDJQJEPHGF(Task a, CancellationToken b, Func<CancellationToken, Task> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8311CB0", Offset = "0x83108B0", VA = "0x188311CB0")]
		[AsyncStateMachine(typeof(<WaitAsync>d__26))]
		public static Task DNXDJYWNJEO(Func<CancellationToken, Task> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x36F7B30", Offset = "0x36F6730", VA = "0x1836F7B30")]
		[AsyncStateMachine(typeof(<WaitAsync>d__27<>))]
		public static Task<T> DNXDJYWNJEO<T>(Func<CancellationToken, Task<T>> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Func<OperationCanceledException, T>? handleTimeout) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8311DE0", Offset = "0x83109E0", VA = "0x188311DE0")]
		public static Task EOIEHNONUZG(params Task[] tasks)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8311E30", Offset = "0x8310A30", VA = "0x188311E30")]
		public static Task EOIEHNONUZG(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8311B80", Offset = "0x8310780", VA = "0x188311B80")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__30))]
		public static Task<IEnumerable<Task>> AGOZXLGPIJJ(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x36F77A0", Offset = "0x36F63A0", VA = "0x1836F77A0")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__32<>))]
		public static Task<IEnumerable<Task<T>>> AGOZXLGPIJJ<T>(IEnumerable<Task<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x36FD940", Offset = "0x36FC540", VA = "0x1836FD940")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__34<, , >))]
		public static Task<(T1, T2, T3)> WJMWFNYDSVM<T1, T2, T3>(Task<T1> a, Task<T2> b, Task<T3> c) where T1 : notnull where T2 : notnull where T3 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x36FD7F0", Offset = "0x36FC3F0", VA = "0x1836FD7F0")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__36<, , , , >))]
		public static Task<(T1, T2, T3, T4, T5)> WJMWFNYDSVM<T1, T2, T3, T4, T5>(Task<T1> a, Task<T2> b, Task<T3> c, Task<T4> d, Task<T5> e) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x83133A0", Offset = "0x8311FA0", VA = "0x1883133A0")]
		[AsyncStateMachine(typeof(<While>d__38))]
		public static Task UVDKURBNRRC(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8313290", Offset = "0x8311E90", VA = "0x188313290")]
		[AsyncStateMachine(typeof(<While>d__39))]
		public static Task UVDKURBNRRC(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8313490", Offset = "0x8312090", VA = "0x188313490")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__41))]
		public static Task UYFCFXQGVOT(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x83135C0", Offset = "0x83121C0", VA = "0x1883135C0")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__42))]
		public static Task UYFCFXQGVOT(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x83130B0", Offset = "0x8311CB0", VA = "0x1883130B0")]
		[AsyncStateMachine(typeof(<Until>d__44))]
		public static Task TINTFLHCGAZ(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8312FA0", Offset = "0x8311BA0", VA = "0x188312FA0")]
		[AsyncStateMachine(typeof(<Until>d__45))]
		public static Task TINTFLHCGAZ(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8312760", Offset = "0x8311360", VA = "0x188312760")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__47))]
		public static Task KIDAXNLUYKU(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8312890", Offset = "0x8311490", VA = "0x188312890")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__48))]
		public static Task KIDAXNLUYKU(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x83131A0", Offset = "0x8311DA0", VA = "0x1883131A0")]
		[AsyncStateMachine(typeof(<Then>d__50))]
		[Obsolete]
		public static Task Then(this Task task, Action then)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x36FD270", Offset = "0x36FBE70", VA = "0x1836FD270")]
		[AsyncStateMachine(typeof(<Then>d__51<>))]
		[Obsolete]
		public static Task Then<T>(this Task<T> task, Action<T> then) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8313C60", Offset = "0x8312860", VA = "0x188313C60")]
		private static void ZZCYXEZUPFY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8313780", Offset = "0x8312380", VA = "0x188313780")]
		public static bool XMURMCCLKWX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8311A00", Offset = "0x8310600", VA = "0x188311A00")]
		private static void ABEMRSYSLCX(SynchronizationContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x83122D0", Offset = "0x8310ED0", VA = "0x1883122D0")]
		private static void FTBRDCHWWKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8312C50", Offset = "0x8311850", VA = "0x188312C50")]
		public static void NESJDLJVHXK([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8313700", Offset = "0x8312300", VA = "0x188313700")]
		public static void VXUJGYIMKLX([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8312E90", Offset = "0x8311A90", VA = "0x188312E90")]
		public static GOBWESELGYH<NWNCJNHUMKH> QKMPAGFPQGS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8312F50", Offset = "0x8311B50", VA = "0x188312F50")]
		public static GOBWESELGYH<NWNCJNHUMKH> RYLQIXJPODF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8312D10", Offset = "0x8311910", VA = "0x188312D10")]
		[AsyncStateMachine(typeof(<RunOnMainThread>d__68))]
		public static Task OLXNCPHYPKU(Func<Task> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class TestedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public TestedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class MDILEJJPHTX
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8316B90", Offset = "0x8315790", VA = "0x188316B90")]
		public static bool UHJIAALETYL(this CRJEUNMGTTM a, DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x8316A70", Offset = "0x8315670", VA = "0x188316A70")]
		public static TimeSpan HGBGCSAVLPM(this CRJEUNMGTTM a, DateTime b)
		{
			return default(TimeSpan);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class WKVVIBTLPII : CRJEUNMGTTM
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public static readonly CRJEUNMGTTM PGFSJHGESKI;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DateTime KFGTMEBQBVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x831C640", Offset = "0x831B240", VA = "0x18831C640", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DateTimeOffset DWFJQMFPUDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x831C5E0", Offset = "0x831B1E0", VA = "0x18831C5E0", Slot = "5")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public WKVVIBTLPII()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface CRJEUNMGTTM
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		DateTime KFGTMEBQBVT
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		DateTimeOffset DWFJQMFPUDQ
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class JMIDWISJQXE
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static long ASOWUYXVWFI
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x8314590", Offset = "0x8313190", VA = "0x188314590")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static long BUPDSYERCPN
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x8314AA0", Offset = "0x83136A0", VA = "0x188314AA0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static double SCDFEIUKNLQ
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x8314840", Offset = "0x8313440", VA = "0x188314840")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static double LBPZLZPZBEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x8314790", Offset = "0x8313390", VA = "0x188314790")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static double TRPQBPUVIPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8314960", Offset = "0x8313560", VA = "0x188314960")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static double JXHLQXHMIOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x83149C0", Offset = "0x83135C0", VA = "0x1883149C0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8314670", Offset = "0x8313270", VA = "0x188314670")]
		public static double EXWOWEISQCY(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8314700", Offset = "0x8313300", VA = "0x188314700")]
		public static double IZDKBBNQAPZ(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x8314A10", Offset = "0x8313610", VA = "0x188314A10")]
		public static double RYZRRXYTZPQ(double a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x83145E0", Offset = "0x83131E0", VA = "0x1883145E0")]
		public static long EVBKALAGYVL(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x83149B0", Offset = "0x83135B0", VA = "0x1883149B0")]
		public static long ONDXFOMPJHF(long a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8314890", Offset = "0x8313490", VA = "0x188314890")]
		public static double NMHBWJVJQTD(long a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x83147E0", Offset = "0x83133E0", VA = "0x1883147E0")]
		public static double LXFYQXUIEZM(long a, long b)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class IWJGYCWPCFK : BZNKTGGYCXZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public static readonly TimeSpan ACVTJQYCMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly System.Timers.Timer MIHMEFXFBWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private TimeSpan NQWYEJZENHA;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TimeSpan LVJRZBYJQBY
		{
			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x8313ED0", Offset = "0x8312AD0", VA = "0x188313ED0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Action? FEFZBACVSUF
		{
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xA974E0", Offset = "0xA960E0", VA = "0x180A974E0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x8314270", Offset = "0x8312E70", VA = "0x188314270")]
		[Preserve]
		public IWJGYCWPCFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x83142E0", Offset = "0x8312EE0", VA = "0x1883142E0")]
		public IWJGYCWPCFK(TimeSpan a, [Optional] Action? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x83140D0", Offset = "0x8312CD0", VA = "0x1883140D0", Slot = "7")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8314190", Offset = "0x8312D90", VA = "0x188314190", Slot = "8")]
		public void XVHNTYOFVDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x8314160", Offset = "0x8312D60", VA = "0x188314160", Slot = "9")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x103F860", Offset = "0x103E460", VA = "0x18103F860")]
		private void IIPSWNCMSBP(object a, ElapsedEventArgs b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x8314030", Offset = "0x8312C30", VA = "0x188314030")]
		private static void RHHWNXNUOYQ(TimeSpan a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x8313E30", Offset = "0x8312A30", VA = "0x188313E30", Slot = "10")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class TodoAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public readonly string? Tag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public readonly string Description;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x7B74900", Offset = "0x7B73500", VA = "0x187B74900")]
		public TodoAttribute(string description)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5065F40", Offset = "0x5064B40", VA = "0x185065F40")]
		public TodoAttribute(string tag, string description)
		{
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
	public struct Union32 : IEquatable<Union32>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public uint U32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int I32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public float F32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public ushort U16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public ushort U16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public short I16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public short I16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public char Char_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public char Char_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public byte U8_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public byte U8_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public byte U8_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public byte U8_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool Bool_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool Bool_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public bool Bool_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public bool Bool_3;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1A639C0", Offset = "0x1A625C0", VA = "0x181A639C0")]
		public static Union32 LTSFVQPERPR(uint a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1A639C0", Offset = "0x1A625C0", VA = "0x181A639C0")]
		public static Union32 LRFLPEHOAJN(int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x831C210", Offset = "0x831AE10", VA = "0x18831C210")]
		public static Union32 XCFQNGBCHXY(float a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x831BB30", Offset = "0x831A730", VA = "0x18831BB30")]
		public static Union32 PIXIXXFALXE(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x831BB30", Offset = "0x831A730", VA = "0x18831BB30")]
		public static Union32 SQVEYDSQYUX(bool a, bool b, bool c, bool d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x831BB30", Offset = "0x831A730", VA = "0x18831BB30")]
		public static Union32 QIOZLXXGBLM(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x2002930", Offset = "0x2001530", VA = "0x182002930")]
		public static bool OKWKXGGAXFT(Union32 a, Union32 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2002830", Offset = "0x2001430", VA = "0x182002830", Slot = "4")]
		public bool Equals(Union32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x831BAA0", Offset = "0x831A6A0", VA = "0x18831BAA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x12DBE10", Offset = "0x12DAA10", VA = "0x1812DBE10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x831BB50", Offset = "0x831A750", VA = "0x18831BB50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public struct Union64
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public ulong U64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public long I64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public double F64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public uint U32_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public uint U32_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public int I32_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int I32_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public float F32_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public float F32_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public ushort U16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public ushort U16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public ushort U16_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public ushort U16_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public short I16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public short I16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public short I16_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public short I16_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public char Char_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public char Char_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public char Char_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public char Char_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public byte U8_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public byte U8_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public byte U8_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public byte U8_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public byte U8_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public byte U8_5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public byte U8_6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public byte U8_7;

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960")]
		public static Union64 New(long i64)
		{
			return default(Union64);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x831C220", Offset = "0x831AE20", VA = "0x18831C220")]
		public static Union64 New(byte u8_0, byte u8_1, byte u8_2, byte u8_3, byte u8_4, byte u8_5, byte u8_6, byte u8_7)
		{
			return default(Union64);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
	public struct Union8 : IEquatable<Union8>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public byte U8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public bool Bool;

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x2FF15A0", Offset = "0x2FF01A0", VA = "0x182FF15A0")]
		public static Union8 PIXIXXFALXE(byte a)
		{
			return default(Union8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x2FF15A0", Offset = "0x2FF01A0", VA = "0x182FF15A0")]
		public static Union8 SQVEYDSQYUX(bool a)
		{
			return default(Union8);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x831C310", Offset = "0x831AF10", VA = "0x18831C310")]
		public static bool OKWKXGGAXFT(Union8 a, Union8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x72B7B30", Offset = "0x72B6730", VA = "0x1872B7B30", Slot = "4")]
		public bool Equals(Union8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x831C270", Offset = "0x831AE70", VA = "0x18831C270", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x831C300", Offset = "0x831AF00", VA = "0x18831C300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x831C320", Offset = "0x831AF20", VA = "0x18831C320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class UnreachableCaseException<T> : Exception where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public readonly T Case;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6041C60", Offset = "0x6040860", VA = "0x186041C60")]
		public UnreachableCaseException(T @case)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class RZFFMNRXPRF
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3A0FDF0", Offset = "0x3A0E9F0", VA = "0x183A0FDF0")]
		public static IEnumerable<T> WYGSJSAYBRQ<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960")]
		public static T[] RJCNIZDTQPW<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xB15960", Offset = "0xB14560", VA = "0x180B15960")]
		public static IEnumerable<T> WMVSGZMHVIN<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C660", Offset = "0x3A0B260", VA = "0x183A0C660")]
		public static HashSet<T> BIKHFEZZSGR<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3A0DDA0", Offset = "0x3A0C9A0", VA = "0x183A0DDA0")]
		public static KeyValuePair<TKey, TValue> HUTNNKHHXED<TKey, TValue>([In] TKey key, [In] TValue value) where TKey : notnull where TValue : notnull
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3A0EE30", Offset = "0x3A0DA30", VA = "0x183A0EE30")]
		public static List<T> RVYYKOCSUOD<T>(IEnumerable<T> a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class WillBeRenamedToAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public readonly string To;

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
		public WillBeRenamedToAttribute(string to)
		{
		}
	}
}
namespace RecRoom.NoEngine.Common.Delegates
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public delegate object FastestMessageFunc<T>([In] T args);
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate object FastMessageFunc<T>(T args);
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[CS9FunctionPointer]
	public delegate string FormatAsyncCallstackDelegate(string str, string? prefix, bool trailingWhitespace);
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CS9FunctionPointer]
	public delegate void LogDelegate(string message);
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CS9FunctionPointer]
	public delegate void LogExceptionDelegate(Exception ex);
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public delegate object MessageFunc();
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[CS9FunctionPointer]
	public delegate bool ShouldLogDelegate();
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CS9FunctionPointer]
	public delegate string ToDebugJsonDelegate(object obj);
}
namespace RecRoom.NoEngine.Common.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[AttributeUsage(AttributeTargets.Enum)]
	public class ContiguousZeroIndexedEnumAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
		public ContiguousZeroIndexedEnumAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class YURZPNFFSOM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct <TimerDelay>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			public int millisecondsDelay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private System.Threading.Timer <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private bool <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private object <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private int <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private bool <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private ValueTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x83189A0", Offset = "0x83175A0", VA = "0x1883189A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8319260", Offset = "0x8317E60", VA = "0x188319260", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private static readonly TimerCallback MZEHTRPLOIX;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private static readonly Action<object?> JGHGGMGFDLM;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x831CE50", Offset = "0x831BA50", VA = "0x18831CE50")]
		public static Task<bool> PTQFSQEVPHU(int a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x831CC90", Offset = "0x831B890", VA = "0x18831CC90")]
		[AsyncStateMachine(typeof(<TimerDelay>d__2))]
		private static Task<bool> KVEWTFCVKHF(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x831CDC0", Offset = "0x831B9C0", VA = "0x18831CDC0")]
		private static void MXYPGMPFYOI(object? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x831D150", Offset = "0x831BD50", VA = "0x18831D150")]
		private static void VQYMTHDHXOH(object? a)
		{
		}
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
