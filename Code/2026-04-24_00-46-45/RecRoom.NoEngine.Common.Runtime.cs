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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B14BF0", Offset = "0x9B135F0", VA = "0x189B14BF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace System.Text
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class JHHRRGHTJGZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9B12460", Offset = "0x9B10E60", VA = "0x189B12460")]
		public static string TPBZTRCPNTZ(this Encoding a, [In] ReadOnlySequence<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3B8C530", Offset = "0x3B8AF30", VA = "0x183B8C530")]
		private static void FFJMPXFVEEQ<a>(this ReadOnlySequence<a> sequence, [Out] ReadOnlySpan<a> firstSpan, [Out] SequencePosition a)
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
		[Cpp2IlInjected.Address(RVA = "0x9B14420", Offset = "0x9B12E20", VA = "0x189B14420")]
		public MemberNotNullWhenAttribute(bool returnValue, string member)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B144D0", Offset = "0x9B12ED0", VA = "0x189B144D0")]
		public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class CSBBZKCFJMT
	{
	}
}
namespace RecRoom.DebugStats
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface MVCRJQUMVOR
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool UYFTQQALMXR
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HXUOMTPLVVH(string a, double b, [Optional] string? unit);
	}
}
namespace RecRoom.Analytics
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class PUXWCCFEZPB : QOIMFQVWJUD, NKYWSYHKTRL, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int XNGUFRIGHHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Queue<double> GFQIEHIQGIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private double WCWLBTOAUFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private double XUDNAONXHPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private double GRJSJZCRQYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int LNPPMGLVSKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private double YXQKNWGCXCQ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int QYEZATFVXCV
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD40BE0", Offset = "0xD3F5E0", VA = "0x180D40BE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public double WIFMPTRACFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x9B15220", Offset = "0x9B13C20", VA = "0x189B15220", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public double TIITIXKBMDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFC20", Offset = "0x2AEE620", VA = "0x182AEFC20", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double UZPVHSJXZNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2B21F20", Offset = "0x2B20920", VA = "0x182B21F20", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9B15280", Offset = "0x9B13C80", VA = "0x189B15280")]
		public PUXWCCFEZPB(int a, double b = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9B15080", Offset = "0x9B13A80", VA = "0x189B15080", Slot = "7")]
		public void PFXEFQMACQV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9B151B0", Offset = "0x9B13BB0", VA = "0x189B151B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9B14F90", Offset = "0x9B13990", VA = "0x189B14F90", Slot = "9")]
		public object Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class UWGUPICIAQP : QOIMFQVWJUD, NKYWSYHKTRL, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private long XUYKWNJGNYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private double SOAHXIKAFZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private double ACSRBGTQIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private double JRENZQYYYQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private double QMUOEFEXAOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private double WCWLBTOAUFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private double XUDNAONXHPG;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public double TIITIXKBMDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6396330", Offset = "0x6394D30", VA = "0x186396330", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public double UZPVHSJXZNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE3D950", Offset = "0xE3C350", VA = "0x180E3D950", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public double YAUNJICQLVI
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xE3D940", Offset = "0xE3C340", VA = "0x180E3D940")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public double WIFMPTRACFZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AEFC10", Offset = "0x2AEE610", VA = "0x182AEFC10", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D3C0", Offset = "0x9B1BDC0", VA = "0x189B1D3C0", Slot = "10")]
		public virtual void PFXEFQMACQV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D4E0", Offset = "0x9B1BEE0", VA = "0x189B1D4E0", Slot = "11")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D360", Offset = "0x9B1BD60", VA = "0x189B1D360", Slot = "9")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B14DE0", Offset = "0x9B137E0", VA = "0x189B14DE0")]
		public UWGUPICIAQP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class ODEPXSNNETP : UWGUPICIAQP
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public double WPELDVDFUPT
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xE3D930", Offset = "0xE3C330", VA = "0x180E3D930")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8D35FB0", Offset = "0x8D349B0", VA = "0x188D35FB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B14C70", Offset = "0x9B13670", VA = "0x189B14C70", Slot = "10")]
		public override void PFXEFQMACQV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B14DA0", Offset = "0x9B137A0", VA = "0x189B14DA0", Slot = "11")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B14DE0", Offset = "0x9B137E0", VA = "0x189B14DE0")]
		public ODEPXSNNETP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface QOIMFQVWJUD : NKYWSYHKTRL, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		double WIFMPTRACFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		double TIITIXKBMDU
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		double UZPVHSJXZNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QQGCOKNGLSC : NKYWSYHKTRL, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private double UVTFKMYSTCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private double XMSWUKYDMLE;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public double BPERYPXGUEX
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9B15850", Offset = "0x9B14250", VA = "0x189B15850")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x880DB00", Offset = "0x880C500", VA = "0x18880DB00", Slot = "4")]
		public void PFXEFQMACQV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9B15840", Offset = "0x9B14240", VA = "0x189B15840", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9B157F0", Offset = "0x9B141F0", VA = "0x189B157F0", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public QQGCOKNGLSC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NKYWSYHKTRL : ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PFXEFQMACQV(double a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class KAEHJCJEYCA : NKYWSYHKTRL, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private double LRHGTXAQZPF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double BPERYPXGUEX
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x12A1DA0", Offset = "0x12A07A0", VA = "0x1812A1DA0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x706A960", Offset = "0x7069360", VA = "0x18706A960", Slot = "4")]
		public void PFXEFQMACQV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9B12C90", Offset = "0x9B11690", VA = "0x189B12C90", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9B12C40", Offset = "0x9B11640", VA = "0x189B12C40", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KAEHJCJEYCA()
		{
		}
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class DYYNDWUJYIK<a> : IDisposable
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
			public DYYNDWUJYIK<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x657C4E0", Offset = "0x657AEE0", VA = "0x18657C4E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x657D360", Offset = "0x657BD60", VA = "0x18657D360", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly CancellationTokenSource SLFNIPILTVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CancellationTokenSource? QWBIEZVWHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskCompletionSource<a>? ELXYIEXETJB;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x53BCAE0", Offset = "0x53BB4E0", VA = "0x1853BCAE0")]
		[AsyncStateMachine(typeof(DYYNDWUJYIK<>.<Debounce>d__4))]
		public Task<a> YSIIZCLDPOJ(TaskGenerator taskGenerator, [Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x53BC910", Offset = "0x53BB310", VA = "0x1853BC910", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x53BCC20", Offset = "0x53BB620", VA = "0x1853BCC20")]
		public DYYNDWUJYIK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class Box<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly EqualityComparer<T> LAAYZITWIWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T BPERYPXGUEX;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5006810", Offset = "0x5005210", VA = "0x185006810")]
		public Box([In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5004800", Offset = "0x5003200", VA = "0x185004800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x50053D0", Offset = "0x5003DD0", VA = "0x1850053D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50055C0", Offset = "0x5003FC0", VA = "0x1850055C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x380DC90", Offset = "0x380C690", VA = "0x18380DC90")]
		public static Box<T> New<T>([In] T value) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class WHEEBDCIVDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9B1DEE0", Offset = "0x9B1C8E0", VA = "0x189B1DEE0")]
		public static void FBVOEVSRAHI(this CancellationTokenSource a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
	public class CS9FunctionPointerAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public CS9FunctionPointerAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
	public class CS9ImprovedNullableConstraints : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public CS9ImprovedNullableConstraints(string why)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class PFWCKPAIQVO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D2A0", Offset = "0x3D9BCA0", VA = "0x183D9D2A0")]
		public static LogString DEWFGJBOWCB<a>()
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B14F30", Offset = "0x9B13930", VA = "0x189B14F30")]
		public static LogString UNGNUHDKBOZ([CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E090", Offset = "0x3D9CA90", VA = "0x183D9E090")]
		public static LogString MHTIMVFKWQD<T>([CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D310", Offset = "0x3D9BD10", VA = "0x183D9D310")]
		public static LogString DEWFGJBOWCB<T>(this T a) where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D9E180", Offset = "0x3D9CB80", VA = "0x183D9E180")]
		public static LogString MHTIMVFKWQD<T>(this T a, [CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9B14EB0", Offset = "0x9B138B0", VA = "0x189B14EB0")]
		public static LogString MHTIMVFKWQD(string a, [CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9B14E10", Offset = "0x9B13810", VA = "0x189B14E10")]
		public static string KUKNKANCFVO(this object a)
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
	public sealed class ACNQDSKFJJT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly ACNQDSKFJJT UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ACNQDSKFJJT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class QSQVYIJBFIB
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static EngineShimState ZZATFGXMECR;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static EngineShimState VKGZLCZCMVM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9B15AD0", Offset = "0x9B144D0", VA = "0x189B15AD0")]
			get
			{
				return default(EngineShimState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LogDelegates GTJGATDOPFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9B16070", Offset = "0x9B14A70", VA = "0x189B16070")]
			get
			{
				return default(LogDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static PerfScopeDelegates NLHHCGDQMJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x9B15E80", Offset = "0x9B14880", VA = "0x189B15E80")]
			get
			{
				return default(PerfScopeDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static bool MCZIFVZFUAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9B15CC0", Offset = "0x9B146C0", VA = "0x189B15CC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9B15860", Offset = "0x9B14260", VA = "0x189B15860")]
		public static void AJWDPBEQAPF([In] EngineShimState engineShimState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9B15DB0", Offset = "0x9B147B0", VA = "0x189B15DB0")]
		public static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9B15FA0", Offset = "0x9B149A0", VA = "0x189B15FA0")]
		public static void UXPWTIRECES(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3E43DF0", Offset = "0x3E427F0", VA = "0x183E43DF0")]
		public static void UXPWTIRECES<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9B15C20", Offset = "0x9B14620", VA = "0x189B15C20")]
		public static void HPMFTMJSIBL(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9B15F40", Offset = "0x9B14940", VA = "0x189B15F40")]
		public static void UAPRIJYFEMI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9B15B20", Offset = "0x9B14520", VA = "0x189B15B20")]
		public static void ECZNWBNXNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9B15D30", Offset = "0x9B14730", VA = "0x189B15D30")]
		public static string KUKNKANCFVO(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9B15ED0", Offset = "0x9B148D0", VA = "0x189B15ED0")]
		public static long RVENKOCPJPN()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9B15B80", Offset = "0x9B14580", VA = "0x189B15B80")]
		public static bool HGZBYDHMBKX(bool a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9B15A00", Offset = "0x9B14400", VA = "0x189B15A00")]
		public static double BJXLOAYNZTK()
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
		public bool RQLJIMEKAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9B11880", Offset = "0x9B10280", VA = "0x189B11880")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B12100", Offset = "0x9B10B00", VA = "0x189B12100")]
		public EngineShimState([In] LogDelegates logDelegates, [In] PerfScopeDelegates perfScopeDelegates, ToDebugJsonDelegate toDebugJsonDelegate, GetOngoingTicksDelegate getOngoingTicksDelegate, FormatAsyncCallstackDelegate formatAsyncCallstackDelegate, GetIsQuittingDelegate getIsQuittingDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xF312F0", Offset = "0xF2FCF0", VA = "0x180F312F0")]
		private static string JWDLJVYSCLR(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160")]
		private static long JMTKVPXHXFO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		private static string JKFSANSEROY(string a, string? prefix, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		private static bool UBTTTFKPOGW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9B11A20", Offset = "0x9B10420", VA = "0x189B11A20")]
		private static EngineShimState KVKHHAZVRZT()
		{
			return default(EngineShimState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface HUOSGZFVSJI<a> where a : notnull, HRDYSUFEMPY
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a SNLTNYBYHWT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface HRDYSUFEMPY : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool KRFCYIIVZMT
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZADHFYCTPZF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface SCCEHWEFPHH<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XNDJLZYNOLK([In] a other);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void InAction<T>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct IndexValuePair<T> : IEquatable<IndexValuePair<T>>, SCCEHWEFPHH<IndexValuePair<T>> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly int Index;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3170D00", Offset = "0x316F700", VA = "0x183170D00")]
		public IndexValuePair([In] T value, int index)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6614310", Offset = "0x6612D10", VA = "0x186614310")]
		public static bool SHHUBVCQRYC([In] IndexValuePair<T> left, [In] IndexValuePair<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6612940", Offset = "0x6611340", VA = "0x186612940", Slot = "4")]
		public bool Equals(IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x66127C0", Offset = "0x66111C0", VA = "0x1866127C0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6615EE0", Offset = "0x66148E0", VA = "0x186615EE0")]
		public bool XNDJLZYNOLK([In] IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6612D20", Offset = "0x6611720", VA = "0x186612D20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x66152D0", Offset = "0x6613CD0", VA = "0x1866152D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6611DB0", Offset = "0x66107B0", VA = "0x186611DB0")]
		public void EBEXHOFOLIC([Out] T a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x66134D0", Offset = "0x6611ED0", VA = "0x1866134D0")]
		public (T, int) NZVHBKRJPYP()
		{
			return default((T, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6616660", Offset = "0x6615060", VA = "0x186616660", Slot = "5")]
		private bool YQRYXRNXEYX([In] IndexValuePair<T> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class FVKLZPNAYPV
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3AE0FA0", Offset = "0x3ADF9A0", VA = "0x183AE0FA0")]
		public static IndexValuePair<T> New<T>([In] T value, int index) where T : notnull
		{
			return default(IndexValuePair<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class KFOSRQGUIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3BFDE70", Offset = "0x3BFC870", VA = "0x183BFDE70")]
		public static bool XNDJLZYNOLK<T, U>([In] T self, [In] U obj) where T : notnull, SCCEHWEFPHH<T> where U : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate TResult InFunc<T, out TResult>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface CUXEOZYDVVA : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		TimeSpan IEVVDAVSZPP
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		Action? KZACHPEDEMK
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
		void WHDUIBKCTAV();

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
		public bool RQLJIMEKAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x9B13450", Offset = "0x9B11E50", VA = "0x189B13450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xF36880", Offset = "0xF35280", VA = "0x180F36880")]
		public LogDelegates(ShouldLogDelegate shouldLogDelegate, LogDelegate logDelegate, ShouldLogDelegate shouldLogWarningDelegate, LogDelegate logWarningDelegate, ShouldLogDelegate shouldLogErrorDelegate, LogDelegate logErrorDelegate, LogExceptionDelegate logExceptionDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		private static bool RYCULTOFPGS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void RVVZQULLFWL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		private static bool HFUSNAKKJQK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void WTQYETXUVQB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
		private static bool RADZKWEKYIU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void KNDGCIKZEFR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void QTWXOPAMVYY(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9B13720", Offset = "0x9B12120", VA = "0x189B13720")]
		private static LogDelegates KVKHHAZVRZT()
		{
			return default(LogDelegates);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
		private static bool AEDJJCLYSLE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9B13860", Offset = "0x9B12260", VA = "0x189B13860")]
		public void Log(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9B138D0", Offset = "0x9B122D0", VA = "0x189B138D0")]
		public void PBOZSOOQQSE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9B13A20", Offset = "0x9B12420", VA = "0x189B13A20")]
		public void UXPWTIRECES(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xF36730", Offset = "0xF35130", VA = "0x180F36730")]
		public void HPMFTMJSIBL(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9B13940", Offset = "0x9B12340", VA = "0x189B13940")]
		public void UXPWTIRECES(MessageFunc a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3C262F0", Offset = "0x3C24CF0", VA = "0x183C262F0")]
		public void UXPWTIRECES<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3C26170", Offset = "0x3C24B70", VA = "0x183C26170")]
		public void Log<T>([In] T arg, FastestMessageFunc<T> message) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3C265C0", Offset = "0x3C24FC0", VA = "0x183C265C0")]
		public void UXPWTIRECES<T>([In] T arg, FastestMessageFunc<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B13650", Offset = "0x9B12050", VA = "0x189B13650")]
		public bool HGZBYDHMBKX(bool a, string b)
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
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		public LogString(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
		public static implicit operator string([In] LogString self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x111A6A0", Offset = "0x11190A0", VA = "0x18111A6A0")]
		public static implicit operator LogString(string other)
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9B143D0", Offset = "0x9B12DD0", VA = "0x189B143D0")]
		public string XRXEQZOHUXM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x9B142F0", Offset = "0x9B12CF0", VA = "0x189B142F0")]
		public string ETOHDQWSENC(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public MustUseReturnValueAttribute()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct None : IEquatable<None>
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "4")]
		public bool Equals(None other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x9B14B60", Offset = "0x9B13560", VA = "0x189B14B60", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x9B14BB0", Offset = "0x9B135B0", VA = "0x189B14BB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x9B14BC0", Offset = "0x9B135C0", VA = "0x189B14BC0", Slot = "3")]
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
		public bool TBJILMDEOAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x29497A0", Offset = "0x29481A0", VA = "0x1829497A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x73DC4E0", Offset = "0x73DAEE0", VA = "0x1873DC4E0")]
		public Option([In] T value, bool isValid)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x73DAC40", Offset = "0x73D9640", VA = "0x1873DAC40")]
		public static bool SHHUBVCQRYC([In] Option<T> left, [In] Option<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x73D92D0", Offset = "0x73D7CD0", VA = "0x1873D92D0", Slot = "4")]
		public bool Equals(Option<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x73D9E40", Offset = "0x73D8840", VA = "0x1873D9E40", Slot = "0")]
		public override bool Equals(object? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x73DA5B0", Offset = "0x73D8FB0", VA = "0x1873DA5B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x73DBF10", Offset = "0x73DA910", VA = "0x1873DBF10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class IKPVCQRPZIX
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3B6A6D0", Offset = "0x3B690D0", VA = "0x183B6A6D0")]
		public static Option<T> XARIKQZLQZM<T>([In] T value) where T : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3B69F10", Offset = "0x3B68910", VA = "0x183B69F10")]
		public static Option<T?> None<T>()
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3B6A330", Offset = "0x3B68D30", VA = "0x183B6A330")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3B6A2C0", Offset = "0x3B68CC0", VA = "0x183B6A2C0")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value, [Out] Option<T> res) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3B6A360", Offset = "0x3B68D60", VA = "0x183B6A360")]
		public static a? WSIKIMMKITY<a>([In] this Option<a> opt, a? a)
		{
			return (a?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3B69830", Offset = "0x3B68230", VA = "0x183B69830")]
		public static bool JUOHDHBKZTQ<T>([In] this Option<T> opt, T a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class NDLLDFFBYZW
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3D54250", Offset = "0x3D52C50", VA = "0x183D54250")]
		public static a BMBPXYGEBKC<a>([In] this Option<a> opt) where a : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class TSOZJQOMYER
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9B18D80", Offset = "0x9B17780", VA = "0x189B18D80")]
		public static bool FXGJACCDTIN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9B18DA0", Offset = "0x9B177A0", VA = "0x189B18DA0")]
		public static bool QCXHYXVEINA(int a)
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
		public bool RQLJIMEKAHB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9B15340", Offset = "0x9B13D40", VA = "0x189B15340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
		public PerfScopeDelegates(IntPtr beginPerfScope, IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void DJTPWRNLSMN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private static void ISAMFQHLBLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x9B15410", Offset = "0x9B13E10", VA = "0x189B15410")]
		private static PerfScopeDelegates KVKHHAZVRZT()
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

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80")]
		private PerfScopeToken(IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x9B155F0", Offset = "0x9B13FF0", VA = "0x189B155F0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x9B15600", Offset = "0x9B14000", VA = "0x189B15600")]
		public static PerfScopeToken New(string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEA20", Offset = "0x2BAD420", VA = "0x182BAEA20")]
		public static PerfScopeToken New([In] PerfScopeDelegates perfScopeDelegates, string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2BAEAB0", Offset = "0x2BAD4B0", VA = "0x182BAEAB0")]
		public static PerfScopeToken New([In] PerfScopeDelegates perfScopeDelegates, Func<string> name)
		{
			return default(PerfScopeToken);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Obfuscation(Exclude = true)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public PreserveAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class EIFHLYRRTLM : SHA256
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static bool? SOISUTYXOIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IntPtr EROGALULRFL;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static bool WJJGELHJBHV
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x9B116E0", Offset = "0x9B100E0", VA = "0x189B116E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9B11180", Offset = "0x9B0FB80", VA = "0x189B11180")]
		public new static SHA256 Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9B113F0", Offset = "0x9B0FDF0", VA = "0x189B113F0")]
		private static extern int GetSHA256DigestSize();

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9B11110", Offset = "0x9B0FB10", VA = "0x189B11110")]
		private static extern IntPtr CreateSHA256();

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9B11290", Offset = "0x9B0FC90", VA = "0x189B11290")]
		private static extern void DestroySHA256(IntPtr sha256);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9B11790", Offset = "0x9B10190", VA = "0x189B11790")]
		private static extern void UpdateSHA256Digest(IntPtr sha256, byte[] data, int offset, int dataLength);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x9B11350", Offset = "0x9B0FD50", VA = "0x189B11350")]
		private static extern void FinalSHA256Digest(IntPtr sha256, byte[] digest);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x9B11850", Offset = "0x9B10250", VA = "0x189B11850")]
		private EIFHLYRRTLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x9B11460", Offset = "0x9B0FE60", VA = "0x189B11460", Slot = "18")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x9B11520", Offset = "0x9B0FF20", VA = "0x189B11520", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9B11650", Offset = "0x9B10050", VA = "0x189B11650", Slot = "20")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x9B11310", Offset = "0x9B0FD10", VA = "0x189B11310", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class SZMVPVXRQNE
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public delegate bool TryTransformFunction<in TInput, TResult>(TInput input, [Out] TResult result);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class KUTGLTEITXB : HUOSGZFVSJI<HRDYSUFEMPY>
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			private sealed class JPKWZSMSWOI : HRDYSUFEMPY, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				public static readonly JPKWZSMSWOI UIOXUQVVXGJ;

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public bool KRFCYIIVZMT
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0x9B12B70", Offset = "0x9B11570", VA = "0x189B12B70", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x9B12A10", Offset = "0x9B11410", VA = "0x189B12A10", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
				public void ZADHFYCTPZF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public JPKWZSMSWOI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly KUTGLTEITXB UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private KUTGLTEITXB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x9B13390", Offset = "0x9B11D90", VA = "0x189B13390", Slot = "4")]
			public HRDYSUFEMPY SNLTNYBYHWT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class ATPUDUISWMM : HUOSGZFVSJI<HRDYSUFEMPY>
		{
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			private sealed class JCMWRPYYYIT : HRDYSUFEMPY, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public static readonly JCMWRPYYYIT UIOXUQVVXGJ;

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public bool KRFCYIIVZMT
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0x9B123D0", Offset = "0x9B10DD0", VA = "0x189B123D0", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x9B12380", Offset = "0x9B10D80", VA = "0x189B12380", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
				public void ZADHFYCTPZF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public JCMWRPYYYIT()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly ATPUDUISWMM UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			private ATPUDUISWMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x9B10DA0", Offset = "0x9B0F7A0", VA = "0x189B10DA0", Slot = "4")]
			public HRDYSUFEMPY SNLTNYBYHWT()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class TJABUXRAETU<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public TaskCompletionSource<a> YWWGQGHZHSY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public CancellationToken MBGDDUIYIKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public CancellationTokenRegistration EQUCTYDHZHV;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public TJABUXRAETU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x68CF4D0", Offset = "0x68CDED0", VA = "0x1868CF4D0")]
			internal void JKDIGZARCPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x7A4FF50", Offset = "0x7A4E950", VA = "0x187A4FF50")]
			internal void JJYBJSGTTEA(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class HSXXEZIOVPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public TaskCompletionSource<None> QYRNFAFLNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int HBXXXQGEDBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Action<Task> XZCUBOGIXAH;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public HSXXEZIOVPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x9B12270", Offset = "0x9B10C70", VA = "0x189B12270")]
			internal void DLNRMWAEMEH(Task a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class ZXYYBHYRMKZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Func<bool> PEAUDSYQQDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public TimeSpan YDEBJLXLAHG;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ZXYYBHYRMKZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9B1DF10", Offset = "0x9B1C910", VA = "0x189B1DF10")]
			internal Task RGAELWLJLIQ(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class BTYIIVPTFJQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Func<bool> PEAUDSYQQDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public TimeSpan YDEBJLXLAHG;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BTYIIVPTFJQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x9B110A0", Offset = "0x9B0FAA0", VA = "0x189B110A0")]
			internal Task FQQVGQWTRZP(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class LOHVEAZHKAS<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public TaskCompletionSource<a> QYRNFAFLNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken FNXEAWPFEJJ;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LOHVEAZHKAS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x68CF550", Offset = "0x68CDF50", VA = "0x1868CF550")]
			internal void GRAHOYWUHCR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class IVKTFJQXAWJ<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public CancellationTokenRegistration EQUCTYDHZHV;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public IVKTFJQXAWJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x6609900", Offset = "0x6608300", VA = "0x186609900")]
			internal void GQVARSCWXRI(Task<a> a)
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

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x9B18EC0", Offset = "0x9B178C0", VA = "0x189B18EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x9B18DB0", Offset = "0x9B177B0", VA = "0x189B18DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x69C2A50", Offset = "0x69C1450", VA = "0x1869C2A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x69C2BC0", Offset = "0x69C15C0", VA = "0x1869C2BC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct <LogAndRethrowExceptions>d__12<T> : IAsyncStateMachine where T : notnull
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
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x69D9940", Offset = "0x69D8340", VA = "0x1869D9940", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x69D9E10", Offset = "0x69D8810", VA = "0x1869D9E10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <LogAndRethrowExceptions>d__13 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public Task self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9B19020", Offset = "0x9B17A20", VA = "0x189B19020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9B192A0", Offset = "0x9B17CA0", VA = "0x189B192A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <LogExceptions>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public Task self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x9B19300", Offset = "0x9B17D00", VA = "0x189B19300", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x9B19510", Offset = "0x9B17F10", VA = "0x189B19510", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <RunOnMainThread>d__64 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public Func<Task> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x9B19580", Offset = "0x9B17F80", VA = "0x189B19580", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x9B198B0", Offset = "0x9B182B0", VA = "0x189B198B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <RunWhile>d__21 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<CancellationToken, Task> innerTaskConstructor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Task t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			private Task <innerTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private TaskAwaiter<TaskStatus> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x9B19910", Offset = "0x9B18310", VA = "0x189B19910", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x9B1A020", Offset = "0x9B18A20", VA = "0x189B1A020", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <Then>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public Task task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Action then;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x9B1A080", Offset = "0x9B18A80", VA = "0x189B1A080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x9B1A200", Offset = "0x9B18C00", VA = "0x189B1A200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <Then>d__47<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public Task<T> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public Action<T> then;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7186190", Offset = "0x7184B90", VA = "0x187186190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x71863A0", Offset = "0x7184DA0", VA = "0x1871863A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <Transform>d__17<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public AsyncTaskMethodBuilder<TResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public Task<TInput> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public Func<TInput, TResult> transformation;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			private TaskAwaiter<TInput> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x718A550", Offset = "0x7188F50", VA = "0x18718A550", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x42231D0", Offset = "0x4221BD0", VA = "0x1842231D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <TryTransformList>d__20<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<List<TInput>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public TryTransformFunction<TInput, TResult> transformFunction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<List<TInput>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7190DD0", Offset = "0x718F7D0", VA = "0x187190DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7191480", Offset = "0x718FE80", VA = "0x187191480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <Until>d__40 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x9B1B2C0", Offset = "0x9B19CC0", VA = "0x189B1B2C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x9B1B4A0", Offset = "0x9B19EA0", VA = "0x189B1B4A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <Until>d__41 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x9B1B500", Offset = "0x9B19F00", VA = "0x189B1B500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x9B1B860", Offset = "0x9B1A260", VA = "0x189B1B860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <UntilWithTimeout>d__43 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x9B1B8C0", Offset = "0x9B1A2C0", VA = "0x189B1B8C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x9B1BBB0", Offset = "0x9B1A5B0", VA = "0x189B1BBB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <UntilWithTimeout>d__44 : IAsyncStateMachine
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

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x9B1BC10", Offset = "0x9B1A610", VA = "0x189B1BC10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x9B1BE60", Offset = "0x9B1A860", VA = "0x189B1BE60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <WaitAsync>d__22 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public Func<CancellationToken, Task> taskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private CancellationTokenSource <linkedCTS>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x9B1BEC0", Offset = "0x9B1A8C0", VA = "0x189B1BEC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x9B1C400", Offset = "0x9B1AE00", VA = "0x189B1C400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <WaitAsync>d__23<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public Func<CancellationToken, Task<T>> taskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Func<OperationCanceledException, T> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			private CancellationTokenSource <linkedCTS>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x7196A70", Offset = "0x7195470", VA = "0x187196A70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x7197AD0", Offset = "0x71964D0", VA = "0x187197AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <WhenAllSafe>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public AsyncTaskMethodBuilder<IEnumerable<Task>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public IEnumerable<Task> tasks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private Task[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x9B1C460", Offset = "0x9B1AE60", VA = "0x189B1C460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x9B1C6E0", Offset = "0x9B1B0E0", VA = "0x189B1C6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <WhenAllSafe>d__28<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public IEnumerable<Task<T>> tasks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Task<T>[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x719A1A0", Offset = "0x7198BA0", VA = "0x18719A1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x66A2530", Offset = "0x66A0F30", VA = "0x1866A2530", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <WhenAllTyped>d__30<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public Task<T1> task1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public Task<T2> task2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public Task<T3> task3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x719AA40", Offset = "0x7199440", VA = "0x18719AA40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x719B7B0", Offset = "0x719A1B0", VA = "0x18719B7B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <WhenAllTyped>d__32<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public Task<T1> task1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public Task<T2> task2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public Task<T3> task3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public Task<T4> task4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public Task<T5> task5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x719B920", Offset = "0x719A320", VA = "0x18719B920", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x719CD00", Offset = "0x719B700", VA = "0x18719CD00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private struct <While>d__34 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x9B1C750", Offset = "0x9B1B150", VA = "0x189B1C750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x9B1C930", Offset = "0x9B1B330", VA = "0x189B1C930", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private struct <While>d__35 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9B1C990", Offset = "0x9B1B390", VA = "0x189B1C990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9B1CD00", Offset = "0x9B1B700", VA = "0x189B1CD00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct <WhileWithTimeout>d__37 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x9B1CD60", Offset = "0x9B1B760", VA = "0x189B1CD60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x9B1D050", Offset = "0x9B1BA50", VA = "0x189B1D050", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private struct <WhileWithTimeout>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9B1D0B0", Offset = "0x9B1BAB0", VA = "0x189B1D0B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x9B1D300", Offset = "0x9B1BD00", VA = "0x189B1D300", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static SynchronizationContext? XOGAMQXBNGV;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly TaskCompletionSource<None> JYPBJJBDCLR;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static Task EBFHRHOEOKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x9B18830", Offset = "0x9B17230", VA = "0x189B18830")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9B18800", Offset = "0x9B17200", VA = "0x189B18800")]
		public static bool SNKEANRZSGS(this Task a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D1C0", Offset = "0x3F2BBC0", VA = "0x183F2D1C0")]
		public static Task<T> WQPIBCILJMP<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9B176B0", Offset = "0x9B160B0", VA = "0x189B176B0")]
		public static Task JUFWMMFDVAN(this Task a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F2A140", Offset = "0x3F28B40", VA = "0x183F2A140")]
		public static Task<TResult> JUFWMMFDVAN<TResult>(this Task<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F28A60", Offset = "0x3F27460", VA = "0x183F28A60")]
		public static TaskCompletionSource<TResult> JUFWMMFDVAN<TResult>(this TaskCompletionSource<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9B17C30", Offset = "0x9B16630", VA = "0x189B17C30")]
		public static IDisposable? OORCHWKMVUO(CancellationToken a, CancellationToken b, [Out] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x9B18990", Offset = "0x9B17390", VA = "0x189B18990")]
		[AsyncStateMachine(typeof(<FireAndForget>d__9))]
		public static void UDFENDYMVPY(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x9B16BD0", Offset = "0x9B155D0", VA = "0x189B16BD0")]
		[AsyncStateMachine(typeof(<FireAndForgetSilent>d__10))]
		public static void ETOTPRTBNQH(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F2D070", Offset = "0x3F2BA70", VA = "0x183F2D070")]
		[AsyncStateMachine(typeof(<IgnoreException>d__11<>))]
		public static Task WCKCJSUEQLT<TException>(this Task a) where TException : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F27920", Offset = "0x3F26320", VA = "0x183F27920")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__12<>))]
		public static Task<T> IOAJSAOYWYG<T>(this Task<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9B17030", Offset = "0x9B15A30", VA = "0x189B17030")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__13))]
		public static Task IOAJSAOYWYG(this Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9B18AC0", Offset = "0x9B174C0", VA = "0x189B18AC0")]
		[AsyncStateMachine(typeof(<LogExceptions>d__14))]
		public static Task<TaskStatus> WGBSUGBLVSS(this Task? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F27710", Offset = "0x3F26110", VA = "0x183F27710")]
		public static (Task<b?>?, Action<b?>?) FNERJNGUOJR<b>([Optional] CancellationToken a)
		{
			return default((Task<b>, Action<b>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CF70", Offset = "0x3F2B970", VA = "0x183F2CF70")]
		[AsyncStateMachine(typeof(<Transform>d__17<, >))]
		public static Task<TResult> Transform<TResult, TInput>(this Task<TInput> task, Func<TInput, TResult> transformation) where TResult : notnull where TInput : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3F273E0", Offset = "0x3F25DE0", VA = "0x183F273E0")]
		[AsyncStateMachine(typeof(<TryTransformList>d__20<, >))]
		public static Task<List<TResult>> FMXKLTBXRER<TResult, TInput>(this Task<List<TInput>> a, TryTransformFunction<TInput, TResult> b) where TResult : notnull where TInput : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x9B17900", Offset = "0x9B16300", VA = "0x189B17900")]
		[AsyncStateMachine(typeof(<RunWhile>d__21))]
		public static Task JZBVAFDSBQU(Task a, CancellationToken b, Func<CancellationToken, Task> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9B18420", Offset = "0x9B16E20", VA = "0x189B18420")]
		[AsyncStateMachine(typeof(<WaitAsync>d__22))]
		public static Task RGKWLZONQXH(Func<CancellationToken, Task> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CB20", Offset = "0x3F2B520", VA = "0x183F2CB20")]
		[AsyncStateMachine(typeof(<WaitAsync>d__23<>))]
		public static Task<T> RGKWLZONQXH<T>(Func<CancellationToken, Task<T>> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Func<OperationCanceledException, T>? handleTimeout) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x9B17660", Offset = "0x9B16060", VA = "0x189B17660")]
		public static Task JTKJQRBJNZN(params Task[] tasks)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9B171C0", Offset = "0x9B15BC0", VA = "0x189B171C0")]
		public static Task JTKJQRBJNZN(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9B16AD0", Offset = "0x9B154D0", VA = "0x189B16AD0")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__26))]
		public static Task<IEnumerable<Task>> CPPBMYEXTOQ(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F26CB0", Offset = "0x3F256B0", VA = "0x183F26CB0")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__28<>))]
		public static Task<IEnumerable<Task<T>>> CPPBMYEXTOQ<T>(IEnumerable<Task<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F271A0", Offset = "0x3F25BA0", VA = "0x183F271A0")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__30<, , >))]
		public static Task<(T1, T2, T3)> CTMPXKOKGXV<T1, T2, T3>(Task<T1> a, Task<T2> b, Task<T3> c) where T1 : notnull where T2 : notnull where T3 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F27050", Offset = "0x3F25A50", VA = "0x183F27050")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__32<, , , , >))]
		public static Task<(T1, T2, T3, T4, T5)> CTMPXKOKGXV<T1, T2, T3, T4, T5>(Task<T1> a, Task<T2> b, Task<T3> c, Task<T4> d, Task<T5> e) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9B17B40", Offset = "0x9B16540", VA = "0x189B17B40")]
		[AsyncStateMachine(typeof(<While>d__34))]
		public static Task KCLMRQFKZOD(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9B17A30", Offset = "0x9B16430", VA = "0x189B17A30")]
		[AsyncStateMachine(typeof(<While>d__35))]
		public static Task KCLMRQFKZOD(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x9B17F40", Offset = "0x9B16940", VA = "0x189B17F40")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__37))]
		public static Task OYPFWFUIQMO(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x9B18070", Offset = "0x9B16A70", VA = "0x189B18070")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__38))]
		public static Task OYPFWFUIQMO(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x9B18600", Offset = "0x9B17000", VA = "0x189B18600")]
		[AsyncStateMachine(typeof(<Until>d__40))]
		public static Task SMBFNZJGFVI(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9B186F0", Offset = "0x9B170F0", VA = "0x189B186F0")]
		[AsyncStateMachine(typeof(<Until>d__41))]
		public static Task SMBFNZJGFVI(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9B182F0", Offset = "0x9B16CF0", VA = "0x189B182F0")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__43))]
		public static Task QXIGJWUHHYJ(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9B181B0", Offset = "0x9B16BB0", VA = "0x189B181B0")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__44))]
		public static Task QXIGJWUHHYJ(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9B188A0", Offset = "0x9B172A0", VA = "0x189B188A0")]
		[AsyncStateMachine(typeof(<Then>d__46))]
		[Obsolete]
		public static Task Then(this Task task, Action then)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F2CD70", Offset = "0x3F2B770", VA = "0x183F2CD70")]
		[AsyncStateMachine(typeof(<Then>d__47<>))]
		[Obsolete]
		public static Task Then<T>(this Task<T> task, Action<T> then) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9B18550", Offset = "0x9B16F50", VA = "0x189B18550")]
		private static void RHYWWTXMXVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9B16C80", Offset = "0x9B15680", VA = "0x189B16C80")]
		public static bool GFOALVMAFYE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9B17DC0", Offset = "0x9B167C0", VA = "0x189B17DC0")]
		private static void OUJQYYUXAQE(SynchronizationContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x9B18BB0", Offset = "0x9B175B0", VA = "0x189B18BB0")]
		private static void WVCGKSTDHEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9B17100", Offset = "0x9B15B00", VA = "0x189B17100")]
		public static void JJBPLJUNYHZ([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x9B18A40", Offset = "0x9B17440", VA = "0x189B18A40")]
		public static void VDBUOIDUSIK([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x9B16FE0", Offset = "0x9B159E0", VA = "0x189B16FE0")]
		public static HUOSGZFVSJI<HRDYSUFEMPY> GYZTYKJDFDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9B16A80", Offset = "0x9B15480", VA = "0x189B16A80")]
		public static HUOSGZFVSJI<HRDYSUFEMPY> CAKGEWCRZOW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9B169B0", Offset = "0x9B153B0", VA = "0x189B169B0")]
		[AsyncStateMachine(typeof(<RunOnMainThread>d__64))]
		public static Task BKDIUJCLXDB(Func<Task> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class TestedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public TestedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class BASIQCOUTGQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x9B10E60", Offset = "0x9B0F860", VA = "0x189B10E60")]
		public static bool VPPWPQMKZJA(this TCLCCHUUZYZ a, DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x9B10F80", Offset = "0x9B0F980", VA = "0x189B10F80")]
		public static TimeSpan YUUAGVUNMNH(this TCLCCHUUZYZ a, DateTime b)
		{
			return default(TimeSpan);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class QBFELWOLIIL : TCLCCHUUZYZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly TCLCCHUUZYZ UIOXUQVVXGJ;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DateTime CERICCIOQUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9B156E0", Offset = "0x9B140E0", VA = "0x189B156E0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DateTimeOffset QLWPDJVOJQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x9B15720", Offset = "0x9B14120", VA = "0x189B15720", Slot = "5")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public QBFELWOLIIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface TCLCCHUUZYZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		DateTime CERICCIOQUE
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		DateTimeOffset QLWPDJVOJQD
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class RDGPYPPZPTB
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static long SZRFYGUPURV
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x9B16360", Offset = "0x9B14D60", VA = "0x189B16360")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static long DGUOQXHGVKG
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x9B162C0", Offset = "0x9B14CC0", VA = "0x189B162C0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static double HCZIWVPHTJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x9B16310", Offset = "0x9B14D10", VA = "0x189B16310")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static double QKBALJLIXMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x9B164D0", Offset = "0x9B14ED0", VA = "0x189B164D0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static double PICGANZLSDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x9B16180", Offset = "0x9B14B80", VA = "0x189B16180")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static double SXSSXWQARPT
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9B16520", Offset = "0x9B14F20", VA = "0x189B16520")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x9B163B0", Offset = "0x9B14DB0", VA = "0x189B163B0")]
		public static double PZSFGVVJGHZ(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x9B16440", Offset = "0x9B14E40", VA = "0x189B16440")]
		public static double QZZQKYBPNQC(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x9B16230", Offset = "0x9B14C30", VA = "0x189B16230")]
		public static double BPTDLIWEJGB(double a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x9B16570", Offset = "0x9B14F70", VA = "0x189B16570")]
		public static long SMAHMKQBXTO(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9B16600", Offset = "0x9B15000", VA = "0x189B16600")]
		public static long TLBXZBDLGDE(long a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x9B16610", Offset = "0x9B15010", VA = "0x189B16610")]
		public static double ZZFXIHJTFYG(long a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9B161D0", Offset = "0x9B14BD0", VA = "0x189B161D0")]
		public static double AWOUCRRNFMH(long a, long b)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class KSRUZJEHOTF : CUXEOZYDVVA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly TimeSpan VLFZAHOUBTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly System.Timers.Timer WQPRTSQVXSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TimeSpan TBPVWICGHKJ;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TimeSpan IEVVDAVSZPP
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x9B12F10", Offset = "0x9B11910", VA = "0x189B12F10", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Action? KZACHPEDEMK
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9B13320", Offset = "0x9B11D20", VA = "0x189B13320")]
		[Preserve]
		public KSRUZJEHOTF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9B130E0", Offset = "0x9B11AE0", VA = "0x189B130E0")]
		public KSRUZJEHOTF(TimeSpan a, [Optional] Action? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9B12DE0", Offset = "0x9B117E0", VA = "0x189B12DE0", Slot = "7")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9B12EA0", Offset = "0x9B118A0", VA = "0x189B12EA0", Slot = "8")]
		public void WHDUIBKCTAV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9B12E70", Offset = "0x9B11870", VA = "0x189B12E70", Slot = "9")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x138F360", Offset = "0x138DD60", VA = "0x18138F360")]
		private void WOELKBPMNSU(object a, ElapsedEventArgs b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9B12CA0", Offset = "0x9B116A0", VA = "0x189B12CA0")]
		private static void DAKFKGKAMEJ(TimeSpan a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9B12D40", Offset = "0x9B11740", VA = "0x189B12D40", Slot = "10")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class TodoAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public readonly string? Tag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public readonly string Description;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9329360", Offset = "0x9327D60", VA = "0x189329360")]
		public TodoAttribute(string description)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x7151560", Offset = "0x714FF60", VA = "0x187151560")]
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
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public uint U32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public int I32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public float F32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public ushort U16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public ushort U16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public short I16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public short I16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public char Char_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public char Char_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public byte U8_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public byte U8_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public byte U8_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public byte U8_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public bool Bool_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public bool Bool_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public bool Bool_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public bool Bool_3;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1CF37F0", Offset = "0x1CF21F0", VA = "0x181CF37F0")]
		public static Union32 BJHDKBPBKMA(uint a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1CF37F0", Offset = "0x1CF21F0", VA = "0x181CF37F0")]
		public static Union32 SVBHBDGYGXW(int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D5D0", Offset = "0x9B1BFD0", VA = "0x189B1D5D0")]
		public static Union32 NQCBGDIVXUZ(float a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D5B0", Offset = "0x9B1BFB0", VA = "0x189B1D5B0")]
		public static Union32 SQXFHSUYUDR(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D5B0", Offset = "0x9B1BFB0", VA = "0x189B1D5B0")]
		public static Union32 KGTJVCWUESC(bool a, bool b, bool c, bool d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D5B0", Offset = "0x9B1BFB0", VA = "0x189B1D5B0")]
		public static Union32 ILUBIADFBBT(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x23BD7A0", Offset = "0x23BC1A0", VA = "0x1823BD7A0")]
		public static bool SHHUBVCQRYC(Union32 a, Union32 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x23BD780", Offset = "0x23BC180", VA = "0x1823BD780", Slot = "4")]
		public bool Equals(Union32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D520", Offset = "0x9B1BF20", VA = "0x189B1D520", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x1645620", Offset = "0x1644020", VA = "0x181645620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x9B1D5E0", Offset = "0x9B1BFE0", VA = "0x189B1D5E0", Slot = "3")]
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
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public ulong U64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public long I64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public double F64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public uint U32_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public uint U32_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public int I32_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public int I32_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public float F32_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public float F32_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public ushort U16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public ushort U16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public ushort U16_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public ushort U16_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public short I16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public short I16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public short I16_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public short I16_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public char Char_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public char Char_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public char Char_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public char Char_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public byte U8_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public byte U8_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public byte U8_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public byte U8_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public byte U8_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public byte U8_5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public byte U8_6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public byte U8_7;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static Union64 New(long i64)
		{
			return default(Union64);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9B1DCA0", Offset = "0x9B1C6A0", VA = "0x189B1DCA0")]
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
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public byte U8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public bool Bool;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3301770", Offset = "0x3300170", VA = "0x183301770")]
		public static Union8 SQXFHSUYUDR(byte a)
		{
			return default(Union8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x3301770", Offset = "0x3300170", VA = "0x183301770")]
		public static Union8 KGTJVCWUESC(bool a)
		{
			return default(Union8);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x9B1DD90", Offset = "0x9B1C790", VA = "0x189B1DD90")]
		public static bool SHHUBVCQRYC(Union8 a, Union8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x8A197D0", Offset = "0x8A181D0", VA = "0x188A197D0", Slot = "4")]
		public bool Equals(Union8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x9B1DCF0", Offset = "0x9B1C6F0", VA = "0x189B1DCF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9B1DD80", Offset = "0x9B1C780", VA = "0x189B1DD80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x9B1DDA0", Offset = "0x9B1C7A0", VA = "0x189B1DDA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class UnreachableCaseException<T> : Exception where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public readonly T Case;

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7D3AD00", Offset = "0x7D39700", VA = "0x187D3AD00")]
		public UnreachableCaseException(T @case)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class GEGUEHISOBY
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3B02230", Offset = "0x3B00C30", VA = "0x183B02230")]
		public static IEnumerable<T> WFWMNJVWQPH<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static T[] FBAVMZLRBNH<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static IEnumerable<T> VUXDXYWIYRQ<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3B020E0", Offset = "0x3B00AE0", VA = "0x183B020E0")]
		public static HashSet<T> SUHSMHJJMSM<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3B015E0", Offset = "0x3AFFFE0", VA = "0x183B015E0")]
		public static KeyValuePair<TKey, TValue> PNVGCLQFPGQ<TKey, TValue>([In] TKey key, [In] TValue value) where TKey : notnull where TValue : notnull
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3B021C0", Offset = "0x3B00BC0", VA = "0x183B021C0")]
		public static List<T> VDZIAMZZCXK<T>(IEnumerable<T> a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class WillBeRenamedToAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public readonly string To;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public ContiguousZeroIndexedEnumAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class NCCEMEZPEBX
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct <TimerDelay>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public int millisecondsDelay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000151")]
			private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000152")]
			private System.Threading.Timer <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			private bool <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			private object <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private int <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private bool <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private ValueTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x9B1A260", Offset = "0x9B18C60", VA = "0x189B1A260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x9B1AB20", Offset = "0x9B19520", VA = "0x189B1AB20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private static readonly TimerCallback ZVAXATZSTAM;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly Action<object?> XLWAEUMASIL;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x9B145B0", Offset = "0x9B12FB0", VA = "0x189B145B0")]
		public static Task<bool> SCTGWIRPWIX(int a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9B14940", Offset = "0x9B13340", VA = "0x189B14940")]
		[AsyncStateMachine(typeof(<TimerDelay>d__2))]
		private static Task<bool> TVXSSDOUXAS(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x9B14520", Offset = "0x9B12F20", VA = "0x189B14520")]
		private static void PWUNRYPFDJX(object? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x9B148B0", Offset = "0x9B132B0", VA = "0x189B148B0")]
		private static void TEMALGAKOSQ(object? a)
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
