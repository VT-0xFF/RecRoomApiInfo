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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8878C80", Offset = "0x8877C80", VA = "0x188878C80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF8980", Offset = "0xAF7980", VA = "0x180AF8980")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace System.Text
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class YYUQSSOHPBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8881B70", Offset = "0x8880B70", VA = "0x188881B70")]
		public static string OBSIVEYETQK(this Encoding a, [In] ReadOnlySequence<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3F6DF00", Offset = "0x3F6CF00", VA = "0x183F6DF00")]
		private static void AORPWKIIZOT<a>(this ReadOnlySequence<a> sequence, [Out] ReadOnlySpan<a> firstSpan, [Out] SequencePosition a)
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
		[Cpp2IlInjected.Address(RVA = "0x8878390", Offset = "0x8877390", VA = "0x188878390")]
		public MemberNotNullWhenAttribute(bool returnValue, string member)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8878440", Offset = "0x8877440", VA = "0x188878440")]
		public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class JUUTZETBRUA
	{
	}
}
namespace RecRoom.DebugStats
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface BEOMSIVANNW
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool CBXDVGOVTGK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TTNKUBRTJJM(string a, double b, [Optional] string? unit);
	}
}
namespace RecRoom.Analytics
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AYRMJBDWWDM : GLRHXBHWOHS, SPTUWSESTSC, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int HKYSANFKOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Queue<double> CPCCZGBQFIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private double CQUVPIWXIWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private double YTFJZPMGHUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private double EENMJVPDFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int SMWBJHBMFWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private double UMNZBKOEJDP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int NTYAHRLHTSG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAFDCE0", Offset = "0xAFCCE0", VA = "0x180AFDCE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public double ICCCZJQYYUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8874EB0", Offset = "0x8873EB0", VA = "0x188874EB0", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public double QOTRIOZKOVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AC96F0", Offset = "0x2AC86F0", VA = "0x182AC96F0", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double ORACTLMULMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2AE9940", Offset = "0x2AE8940", VA = "0x182AE9940", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88750B0", Offset = "0x88740B0", VA = "0x1888750B0")]
		public AYRMJBDWWDM(int a, double b = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8874F10", Offset = "0x8873F10", VA = "0x188874F10", Slot = "7")]
		public void MXWCMZHTFGA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8875040", Offset = "0x8874040", VA = "0x188875040", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8874DC0", Offset = "0x8873DC0", VA = "0x188874DC0", Slot = "9")]
		public object Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class VNEIOCTIYRI : GLRHXBHWOHS, SPTUWSESTSC, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private long JTKNTDYULGQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private double WJVTEUKSSBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private double ADCRYBYMDLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private double DHRBKLIDBTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private double KSKDCALHGCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private double CQUVPIWXIWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private double YTFJZPMGHUR;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long ZRHYXWVKFWI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public double QOTRIOZKOVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x50F2260", Offset = "0x50F1260", VA = "0x1850F2260", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public double ORACTLMULMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xEEDD80", Offset = "0xEECD80", VA = "0x180EEDD80", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public double LGDZIRMMNSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xEEDD70", Offset = "0xEECD70", VA = "0x180EEDD70")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public double ICCCZJQYYUA
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC96E0", Offset = "0x2AC86E0", VA = "0x182AC96E0", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88814E0", Offset = "0x88804E0", VA = "0x1888814E0", Slot = "10")]
		public virtual void MXWCMZHTFGA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8881600", Offset = "0x8880600", VA = "0x188881600", Slot = "11")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8881480", Offset = "0x8880480", VA = "0x188881480", Slot = "9")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x887B340", Offset = "0x887A340", VA = "0x18887B340")]
		public VNEIOCTIYRI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class PONKKGPMDRC : VNEIOCTIYRI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public double BJZUQZLDXAY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xEEDD60", Offset = "0xEECD60", VA = "0x180EEDD60")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7A7AC50", Offset = "0x7A79C50", VA = "0x187A7AC50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x887B1D0", Offset = "0x887A1D0", VA = "0x18887B1D0", Slot = "10")]
		public override void MXWCMZHTFGA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x887B300", Offset = "0x887A300", VA = "0x18887B300", Slot = "11")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x887B340", Offset = "0x887A340", VA = "0x18887B340")]
		public PONKKGPMDRC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface GLRHXBHWOHS : SPTUWSESTSC, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		double ICCCZJQYYUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		double QOTRIOZKOVB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		double ORACTLMULMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class PYDLUPXHWQB : SPTUWSESTSC, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private double YFHYNKAFQKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private double RDHSKLLAVTZ;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public double AUBFRNVZHSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x887B3D0", Offset = "0x887A3D0", VA = "0x18887B3D0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7542910", Offset = "0x7541910", VA = "0x187542910", Slot = "4")]
		public void MXWCMZHTFGA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x887B3C0", Offset = "0x887A3C0", VA = "0x18887B3C0", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x887B370", Offset = "0x887A370", VA = "0x18887B370", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public PYDLUPXHWQB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface SPTUWSESTSC : ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MXWCMZHTFGA(double a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class IGIGIIEYEFD : SPTUWSESTSC, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private double GATNUZUDYSC;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double AUBFRNVZHSG
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1332430", Offset = "0x1331430", VA = "0x181332430")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5B42580", Offset = "0x5B41580", VA = "0x185B42580", Slot = "4")]
		public void MXWCMZHTFGA(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8876370", Offset = "0x8875370", VA = "0x188876370", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8876320", Offset = "0x8875320", VA = "0x188876320", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public IGIGIIEYEFD()
		{
		}
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class RXDFHYBUQWN<a> : IDisposable
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
			public RXDFHYBUQWN<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x51AA040", Offset = "0x51A9040", VA = "0x1851AA040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x51AAEC0", Offset = "0x51A9EC0", VA = "0x1851AAEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly CancellationTokenSource IZNZIVMMOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CancellationTokenSource? LHKFNDVYFKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskCompletionSource<a>? JWGQRVTCKJY;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5EECF00", Offset = "0x5EEBF00", VA = "0x185EECF00")]
		[AsyncStateMachine(typeof(RXDFHYBUQWN<>.<Debounce>d__4))]
		public Task<a> ETOQJCMLSXY(TaskGenerator taskGenerator, [Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5EECD30", Offset = "0x5EEBD30", VA = "0x185EECD30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5EED040", Offset = "0x5EEC040", VA = "0x185EED040")]
		public RXDFHYBUQWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class Box<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly EqualityComparer<T> RTEUDAUZEGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T AUBFRNVZHSG;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x413C630", Offset = "0x413B630", VA = "0x18413C630")]
		public Box([In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x413A620", Offset = "0x4139620", VA = "0x18413A620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x413B1F0", Offset = "0x413A1F0", VA = "0x18413B1F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x413B3E0", Offset = "0x413A3E0", VA = "0x18413B3E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3748B30", Offset = "0x3747B30", VA = "0x183748B30")]
		public static Box<T> New<T>([In] T value) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class QVKWKIOFGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x887C0A0", Offset = "0x887B0A0", VA = "0x18887C0A0")]
		public static void APMCGQTMBPP(this CancellationTokenSource a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
	public class CS9FunctionPointerAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public CS9FunctionPointerAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
	public class CS9ImprovedNullableConstraints : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public CS9ImprovedNullableConstraints(string why)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class SSLJUGMVYCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E1C0", Offset = "0x3D7D1C0", VA = "0x183D7E1C0")]
		public static LogString DDVFLSCPEQI<a>()
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x887C150", Offset = "0x887B150", VA = "0x18887C150")]
		public static LogString DEQDNNBTBPY([CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D7D0", Offset = "0x3D7C7D0", VA = "0x183D7D7D0")]
		public static LogString AVBXJFPLMOS<T>([CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E150", Offset = "0x3D7D150", VA = "0x183D7E150")]
		public static LogString DDVFLSCPEQI<T>(this T a) where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D7D8C0", Offset = "0x3D7C8C0", VA = "0x183D7D8C0")]
		public static LogString AVBXJFPLMOS<T>(this T a, [CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x887C0D0", Offset = "0x887B0D0", VA = "0x18887C0D0")]
		public static LogString AVBXJFPLMOS(string a, [CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x887C1B0", Offset = "0x887B1B0", VA = "0x18887C1B0")]
		public static string QYNVXMTHASZ(this object a)
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
	public sealed class MLKWIVJPPUQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly MLKWIVJPPUQ HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public MLKWIVJPPUQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class QQKULPHQVWO
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static EngineShimState TEGDUMUQMZA;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static EngineShimState YQMKUWAPYZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x887BD30", Offset = "0x887AD30", VA = "0x18887BD30")]
			get
			{
				return default(EngineShimState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LogDelegates EZXZSUCHKNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x887BC80", Offset = "0x887AC80", VA = "0x18887BC80")]
			get
			{
				return default(LogDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static PerfScopeDelegates XOXGDWTWVWW
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x887BB60", Offset = "0x887AB60", VA = "0x18887BB60")]
			get
			{
				return default(PerfScopeDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static bool RPBAFZTXILI
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x887BD80", Offset = "0x887AD80", VA = "0x18887BD80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x887B8F0", Offset = "0x887A8F0", VA = "0x18887B8F0")]
		public static void IGMYXEUACHK([In] EngineShimState engineShimState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x887BBB0", Offset = "0x887ABB0", VA = "0x18887BBB0")]
		public static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x887BA90", Offset = "0x887AA90", VA = "0x18887BA90")]
		public static void JEMZWVHAXWB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3CB3C60", Offset = "0x3CB2C60", VA = "0x183CB3C60")]
		public static void JEMZWVHAXWB<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x887BF40", Offset = "0x887AF40", VA = "0x18887BF40")]
		public static void WMTUUIXVZIS(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x887B890", Offset = "0x887A890", VA = "0x18887B890")]
		public static void IECFNYTEOMT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x887BCD0", Offset = "0x887ACD0", VA = "0x18887BCD0")]
		public static void PHXTZYLBCFV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x887BDF0", Offset = "0x887ADF0", VA = "0x18887BDF0")]
		public static string QYNVXMTHASZ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x887B820", Offset = "0x887A820", VA = "0x18887B820")]
		public static long IBWPITBYOMW()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x887B780", Offset = "0x887A780", VA = "0x18887B780")]
		public static bool BIQFRBCARBK(bool a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x887BE70", Offset = "0x887AE70", VA = "0x18887BE70")]
		public static double RKZTGESXRND()
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
		public bool TECFEJJOIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8875390", Offset = "0x8874390", VA = "0x188875390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8875B00", Offset = "0x8874B00", VA = "0x188875B00")]
		public EngineShimState([In] LogDelegates logDelegates, [In] PerfScopeDelegates perfScopeDelegates, ToDebugJsonDelegate toDebugJsonDelegate, GetOngoingTicksDelegate getOngoingTicksDelegate, FormatAsyncCallstackDelegate formatAsyncCallstackDelegate, GetIsQuittingDelegate getIsQuittingDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB4E050", Offset = "0xB4D050", VA = "0x180B4E050")]
		private static string NXABXOFJGQI(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xACE160", Offset = "0xACD160", VA = "0x180ACE160")]
		private static long HYUEMETDXZF()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0")]
		private static string IHOJBGWZTMJ(string a, string? prefix, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		private static bool PUTXGJOCNGJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8875280", Offset = "0x8874280", VA = "0x188875280")]
		private static EngineShimState BSAUDCWXOTI()
		{
			return default(EngineShimState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface WKUYAUAYQMR<a> where a : notnull, JCUVPIZWEBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a LAVWNHZCBUM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface JCUVPIZWEBL : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool NYIDVADDLVI
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FAKBZIEIFKC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface CMJSCLNOINY<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool FSWIJMLMNCH([In] a other);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void InAction<T>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct IndexValuePair<T> : IEquatable<IndexValuePair<T>>, CMJSCLNOINY<IndexValuePair<T>> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly int Index;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x31371E0", Offset = "0x31361E0", VA = "0x1831371E0")]
		public IndexValuePair([In] T value, int index)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5366570", Offset = "0x5365570", VA = "0x185366570")]
		public static bool RZMMTPOVALZ([In] IndexValuePair<T> left, [In] IndexValuePair<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x53641A0", Offset = "0x53631A0", VA = "0x1853641A0", Slot = "4")]
		public bool Equals(IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5363F80", Offset = "0x5362F80", VA = "0x185363F80", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x53646E0", Offset = "0x53636E0", VA = "0x1853646E0")]
		public bool FSWIJMLMNCH([In] IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x53648D0", Offset = "0x53638D0", VA = "0x1853648D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5367760", Offset = "0x5366760", VA = "0x185367760", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x5368050", Offset = "0x5367050", VA = "0x185368050")]
		public void ZFXAJJHVNLN([Out] T a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5365220", Offset = "0x5364220", VA = "0x185365220")]
		public (T, int) ILZGMZDGYZM()
		{
			return default((T, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5367530", Offset = "0x5366530", VA = "0x185367530", Slot = "5")]
		private bool TWMXXTWDWYQ([In] IndexValuePair<T> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class OJFWRLWHRVC
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3B8A580", Offset = "0x3B89580", VA = "0x183B8A580")]
		public static IndexValuePair<T> New<T>([In] T value, int index) where T : notnull
		{
			return default(IndexValuePair<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class GQXMJFAEATL
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x399CDD0", Offset = "0x399BDD0", VA = "0x18399CDD0")]
		public static bool FSWIJMLMNCH<T, U>([In] T self, [In] U obj) where T : notnull, CMJSCLNOINY<T> where U : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate TResult InFunc<T, out TResult>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface GGJILDPYXWZ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		TimeSpan QOOJPSJYIFK
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		Action? HTRBASAHFRR
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
		void FBDQIWNVURC();

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
		public bool TECFEJJOIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x8877780", Offset = "0x8876780", VA = "0x188877780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xFD6DC0", Offset = "0xFD5DC0", VA = "0x180FD6DC0")]
		public LogDelegates(ShouldLogDelegate shouldLogDelegate, LogDelegate logDelegate, ShouldLogDelegate shouldLogWarningDelegate, LogDelegate logWarningDelegate, ShouldLogDelegate shouldLogErrorDelegate, LogDelegate logErrorDelegate, LogExceptionDelegate logExceptionDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		private static bool NLFWTBPZLEN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void NOWOLFIPDHG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		private static bool PTSUMGQSUWP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void OJJLFZFUVWM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xB179E0", Offset = "0xB169E0", VA = "0x180B179E0")]
		private static bool PMURKYFIIXX()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void SKPESWJCOUG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void QVURKSGHDJD(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8877410", Offset = "0x8876410", VA = "0x188877410")]
		private static LogDelegates BSAUDCWXOTI()
		{
			return default(LogDelegates);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210")]
		private static bool SLQWZXQZYID()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x88776A0", Offset = "0x88766A0", VA = "0x1888776A0")]
		public void Log(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8877710", Offset = "0x8876710", VA = "0x188877710")]
		public void RXZHPEXCSBF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8877630", Offset = "0x8876630", VA = "0x188877630")]
		public void JEMZWVHAXWB(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xFD6C10", Offset = "0xFD5C10", VA = "0x180FD6C10")]
		public void WMTUUIXVZIS(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8877550", Offset = "0x8876550", VA = "0x188877550")]
		public void JEMZWVHAXWB(MessageFunc a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3A8BBD0", Offset = "0x3A8ABD0", VA = "0x183A8BBD0")]
		public void JEMZWVHAXWB<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3A8BF70", Offset = "0x3A8AF70", VA = "0x183A8BF70")]
		public void Log<T>([In] T arg, FastestMessageFunc<T> message) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3A8BEB0", Offset = "0x3A8AEB0", VA = "0x183A8BEB0")]
		public void JEMZWVHAXWB<T>([In] T arg, FastestMessageFunc<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8877340", Offset = "0x8876340", VA = "0x188877340")]
		public bool BIQFRBCARBK(bool a, string b)
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
		[Cpp2IlInjected.Address(RVA = "0xF99620", Offset = "0xF98620", VA = "0x180F99620")]
		public LogString(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xC10050", Offset = "0xC0F050", VA = "0x180C10050")]
		public static implicit operator string([In] LogString self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x1185790", Offset = "0x1184790", VA = "0x181185790")]
		public static implicit operator LogString(string other)
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x88782D0", Offset = "0x88772D0", VA = "0x1888782D0")]
		public string NOZOIDSJZHT(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x88781F0", Offset = "0x88771F0", VA = "0x1888781F0")]
		public string GFPSIXBYAZZ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xC10050", Offset = "0xC0F050", VA = "0x180C10050", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public MustUseReturnValueAttribute()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct None : IEquatable<None>
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAE9210", Offset = "0xAE8210", VA = "0x180AE9210", Slot = "4")]
		public bool Equals(None other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x8878BF0", Offset = "0x8877BF0", VA = "0x188878BF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8878C40", Offset = "0x8877C40", VA = "0x188878C40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8878C50", Offset = "0x8877C50", VA = "0x188878C50", Slot = "3")]
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
		public bool LJTSNLXOVKP
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xC6FC90", Offset = "0xC6EC90", VA = "0x180C6FC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5D81FF0", Offset = "0x5D80FF0", VA = "0x185D81FF0")]
		public Option([In] T value, bool isValid)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5D80E70", Offset = "0x5D7FE70", VA = "0x185D80E70")]
		public static bool RZMMTPOVALZ([In] Option<T> left, [In] Option<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5D7ECE0", Offset = "0x5D7DCE0", VA = "0x185D7ECE0", Slot = "4")]
		public bool Equals(Option<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5D7F7C0", Offset = "0x5D7E7C0", VA = "0x185D7F7C0", Slot = "0")]
		public override bool Equals(object? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5D7FF30", Offset = "0x5D7EF30", VA = "0x185D7FF30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5D81A20", Offset = "0x5D80A20", VA = "0x185D81A20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class EGCZJZDMDPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x387F620", Offset = "0x387E620", VA = "0x18387F620")]
		public static Option<T> UGRXCUWSEQF<T>([In] T value) where T : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x387EFC0", Offset = "0x387DFC0", VA = "0x18387EFC0")]
		public static Option<T?> None<T>()
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x387F3E0", Offset = "0x387E3E0", VA = "0x18387F3E0")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x387F370", Offset = "0x387E370", VA = "0x18387F370")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value, [Out] Option<T> res) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x387EC00", Offset = "0x387DC00", VA = "0x18387EC00")]
		public static a? ISDZSOQWOLN<a>([In] this Option<a> opt, a? a)
		{
			return (a?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x387E780", Offset = "0x387D780", VA = "0x18387E780")]
		public static bool HCYFYYFUJTP<T>([In] this Option<T> opt, T a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class MHBREBTOBSV
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3A9CFE0", Offset = "0x3A9BFE0", VA = "0x183A9CFE0")]
		public static a RWUEXIXGOPP<a>([In] this Option<a> opt) where a : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class KFBAUBDVUBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8877320", Offset = "0x8876320", VA = "0x188877320")]
		public static bool ABGLCCZLMYG(int a)
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
		public bool TECFEJJOIIK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x887B470", Offset = "0x887A470", VA = "0x18887B470")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xD189A0", Offset = "0xD179A0", VA = "0x180D189A0")]
		public PerfScopeDelegates(IntPtr beginPerfScope, IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void UVHIKECOPGU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		private static void FSULDCSEPQY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x887B3E0", Offset = "0x887A3E0", VA = "0x18887B3E0")]
		private static PerfScopeDelegates BSAUDCWXOTI()
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
		[Cpp2IlInjected.Address(RVA = "0x14B55E0", Offset = "0x14B45E0", VA = "0x1814B55E0")]
		private PerfScopeToken(IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x887B690", Offset = "0x887A690", VA = "0x18887B690")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x887B6A0", Offset = "0x887A6A0", VA = "0x18887B6A0")]
		public static PerfScopeToken New(string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B76150", Offset = "0x2B75150", VA = "0x182B76150")]
		public static PerfScopeToken New([In] PerfScopeDelegates perfScopeDelegates, string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B75D00", Offset = "0x2B74D00", VA = "0x182B75D00")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public PreserveAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class ILYPRHWRNLH : SHA256
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static bool? OAEYDIMPSWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IntPtr GEDKHYSUVNA;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static bool UZULSPAEDBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8876A10", Offset = "0x8875A10", VA = "0x188876A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x88763F0", Offset = "0x88753F0", VA = "0x1888763F0")]
		public new static SHA256 Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8876660", Offset = "0x8875660", VA = "0x188876660")]
		private static extern int GetSHA256DigestSize();

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8876380", Offset = "0x8875380", VA = "0x188876380")]
		private static extern IntPtr CreateSHA256();

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8876500", Offset = "0x8875500", VA = "0x188876500")]
		private static extern void DestroySHA256(IntPtr sha256);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x8876950", Offset = "0x8875950", VA = "0x188876950")]
		private static extern void UpdateSHA256Digest(IntPtr sha256, byte[] data, int offset, int dataLength);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x88765C0", Offset = "0x88755C0", VA = "0x1888765C0")]
		private static extern void FinalSHA256Digest(IntPtr sha256, byte[] digest);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8876AC0", Offset = "0x8875AC0", VA = "0x188876AC0")]
		private ILYPRHWRNLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x88766D0", Offset = "0x88756D0", VA = "0x1888766D0", Slot = "18")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8876790", Offset = "0x8875790", VA = "0x188876790", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x88768C0", Offset = "0x88758C0", VA = "0x1888768C0", Slot = "20")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8876580", Offset = "0x8875580", VA = "0x188876580", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class PHICICWVMBB
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public delegate bool TryTransformFunction<in TInput, TResult>(TInput input, [Out] TResult result);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class TFAPMYGZLRE : WKUYAUAYQMR<JCUVPIZWEBL>
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			private sealed class VXOKPCLXLAV : JCUVPIZWEBL, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				public static readonly VXOKPCLXLAV HNQVBJEYTYC;

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public bool NYIDVADDLVI
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0x88819E0", Offset = "0x88809E0", VA = "0x1888819E0", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x8881880", Offset = "0x8880880", VA = "0x188881880", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
				public void FAKBZIEIFKC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public VXOKPCLXLAV()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly TFAPMYGZLRE HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private TFAPMYGZLRE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x887C250", Offset = "0x887B250", VA = "0x18887C250", Slot = "4")]
			public JCUVPIZWEBL LAVWNHZCBUM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class YPAZWVITZJH : WKUYAUAYQMR<JCUVPIZWEBL>
		{
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			private sealed class ZVJTXOMQKKS : JCUVPIZWEBL, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public static readonly ZVJTXOMQKKS HNQVBJEYTYC;

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public bool NYIDVADDLVI
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0x8882280", Offset = "0x8881280", VA = "0x188882280", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x8882230", Offset = "0x8881230", VA = "0x188882230", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "5")]
				public void FAKBZIEIFKC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
				public ZVJTXOMQKKS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly YPAZWVITZJH HNQVBJEYTYC;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			private YPAZWVITZJH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x8881AB0", Offset = "0x8880AB0", VA = "0x188881AB0", Slot = "4")]
			public JCUVPIZWEBL LAVWNHZCBUM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class RCJFJZUWIHQ<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public TaskCompletionSource<a> BFXRSXDVPGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public CancellationToken AWXXZWOUPED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public CancellationTokenRegistration UXDSJAQMFZG;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public RCJFJZUWIHQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5E31BB0", Offset = "0x5E30BB0", VA = "0x185E31BB0")]
			internal void OUPVKZYKJUO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5EC2BC0", Offset = "0x5EC1BC0", VA = "0x185EC2BC0")]
			internal void OUVCIGSHTFX(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class DCEYDDAQGHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public TaskCompletionSource<None> VMXMCYTGNIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int HLKXRUOFHGX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Action<Task> RTOYDAIMEGI;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public DCEYDDAQGHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x8875170", Offset = "0x8874170", VA = "0x188875170")]
			internal void BYOBIHPCMOW(Task a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class GOJJTQXRCYR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Func<bool> WACKKFNMNZE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public TimeSpan WYMRTTPVZQR;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public GOJJTQXRCYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x88762B0", Offset = "0x88752B0", VA = "0x1888762B0")]
			internal Task YUCFKJPBRSX(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class NMFIJOSQTOH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Func<bool> WACKKFNMNZE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public TimeSpan WYMRTTPVZQR;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public NMFIJOSQTOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x8878490", Offset = "0x8877490", VA = "0x188878490")]
			internal Task AHENXRCFTBE(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class QDUEEIHCIQZ<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public TaskCompletionSource<a> VMXMCYTGNIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken JSDUBRPEAHQ;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public QDUEEIHCIQZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5E318B0", Offset = "0x5E308B0", VA = "0x185E318B0")]
			internal void VGXUKHCAROO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class TDDSTICGHUK<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public CancellationTokenRegistration UXDSJAQMFZG;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public TDDSTICGHUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5EEF290", Offset = "0x5EEE290", VA = "0x185EEF290")]
			internal void VHDBHNVYAZX(Task<a> a)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct <AsNone>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public AsyncTaskMethodBuilder<None> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public Task task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x887C310", Offset = "0x887B310", VA = "0x18887C310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x887C4A0", Offset = "0x887B4A0", VA = "0x18887C4A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct <FireAndForget>d__9 : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x887C620", Offset = "0x887B620", VA = "0x18887C620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct <FireAndForgetSilent>d__10 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public Task t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x887C510", Offset = "0x887B510", VA = "0x18887C510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xB2DD90", Offset = "0xB2CD90", VA = "0x180B2DD90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct <IgnoreException>d__11<TException> : IAsyncStateMachine where TException : notnull, Exception
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public Task t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x5302170", Offset = "0x5301170", VA = "0x185302170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x53022E0", Offset = "0x53012E0", VA = "0x1853022E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private struct <LogAndRethrowExceptions>d__15<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public Task<T> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public bool logCancellations;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public Log log;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public Func<Task<T>, string> logMessageFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x53B96F0", Offset = "0x53B86F0", VA = "0x1853B96F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x53BA180", Offset = "0x53B9180", VA = "0x1853BA180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct <LogAndRethrowExceptions>d__16<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public Task<T> self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x53BA800", Offset = "0x53B9800", VA = "0x1853BA800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x53BAFF0", Offset = "0x53B9FF0", VA = "0x1853BAFF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct <LogAndRethrowExceptions>d__17 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Task self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private TaskAwaiter<TaskStatus> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x887C780", Offset = "0x887B780", VA = "0x18887C780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x887CA00", Offset = "0x887BA00", VA = "0x18887CA00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct <LogExceptions>d__18 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public AsyncTaskMethodBuilder<TaskStatus> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			public Task self;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x887CA60", Offset = "0x887BA60", VA = "0x18887CA60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x887CC70", Offset = "0x887BC70", VA = "0x18887CC70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct <RunOnMainThread>d__68 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public Func<Task> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			private object <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x887CCE0", Offset = "0x887BCE0", VA = "0x18887CCE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x887D010", Offset = "0x887C010", VA = "0x18887D010", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct <RunWhile>d__25 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public Func<CancellationToken, Task> innerTaskConstructor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public Task t;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			private CancellationTokenSource <innerTaskCancellationTokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			private Task <innerTask>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			private TaskAwaiter<TaskStatus> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x887D070", Offset = "0x887C070", VA = "0x18887D070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x887D780", Offset = "0x887C780", VA = "0x18887D780", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct <Then>d__50 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public Task task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Action then;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x887D7E0", Offset = "0x887C7E0", VA = "0x18887D7E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x887D960", Offset = "0x887C960", VA = "0x18887D960", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct <Then>d__51<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public Task<T> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Action<T> then;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x569E700", Offset = "0x569D700", VA = "0x18569E700", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x569EFC0", Offset = "0x569DFC0", VA = "0x18569EFC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private struct <TryTransformList>d__24<TInput, TResult> : IAsyncStateMachine where TInput : notnull where TResult : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AsyncTaskMethodBuilder<List<TResult>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public Task<List<TInput>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public TryTransformFunction<TInput, TResult> transformFunction;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			private TaskAwaiter<List<TInput>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x56AA0A0", Offset = "0x56A90A0", VA = "0x1856AA0A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x56AA680", Offset = "0x56A9680", VA = "0x1856AA680", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <Until>d__44 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x887EA20", Offset = "0x887DA20", VA = "0x18887EA20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x887EC00", Offset = "0x887DC00", VA = "0x18887EC00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		[CompilerGenerated]
		private struct <Until>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x887EC60", Offset = "0x887DC60", VA = "0x18887EC60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x887EFC0", Offset = "0x887DFC0", VA = "0x18887EFC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000052")]
		[CompilerGenerated]
		private struct <UntilWithTimeout>d__47 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x887F020", Offset = "0x887E020", VA = "0x18887F020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x887F310", Offset = "0x887E310", VA = "0x18887F310", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private struct <UntilWithTimeout>d__48 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x887F370", Offset = "0x887E370", VA = "0x18887F370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x887F5C0", Offset = "0x887E5C0", VA = "0x18887F5C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		[CompilerGenerated]
		private struct <WaitAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public Func<CancellationToken, Task> taskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private CancellationTokenSource <linkedCTS>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x887F620", Offset = "0x887E620", VA = "0x18887F620", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x887FB60", Offset = "0x887EB60", VA = "0x18887FB60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		[CompilerGenerated]
		private struct <WaitAsync>d__27<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public CancellationToken externalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public Func<CancellationToken, Task<T>> taskBuilder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public Func<OperationCanceledException, T> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			private CancellationTokenSource <linkedCTS>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0x5747C60", Offset = "0x5746C60", VA = "0x185747C60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x5748CC0", Offset = "0x5747CC0", VA = "0x185748CC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[CompilerGenerated]
		private struct <WhenAllSafe>d__30 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public AsyncTaskMethodBuilder<IEnumerable<Task>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public IEnumerable<Task> tasks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private Task[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x887FBC0", Offset = "0x887EBC0", VA = "0x18887FBC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x887FE40", Offset = "0x887EE40", VA = "0x18887FE40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private struct <WhenAllSafe>d__32<T> : IAsyncStateMachine where T : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public AsyncTaskMethodBuilder<IEnumerable<Task<T>>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public IEnumerable<Task<T>> tasks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			private Task<T>[] <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private int <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x574BBF0", Offset = "0x574ABF0", VA = "0x18574BBF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x5191C90", Offset = "0x5190C90", VA = "0x185191C90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000058")]
		[CompilerGenerated]
		private struct <WhenAllTyped>d__34<T1, T2, T3> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public AsyncTaskMethodBuilder<(T1, T2, T3)> <>t__builder;

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
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x574D0E0", Offset = "0x574C0E0", VA = "0x18574D0E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x574D5B0", Offset = "0x574C5B0", VA = "0x18574D5B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000059")]
		[CompilerGenerated]
		private struct <WhenAllTyped>d__36<T1, T2, T3, T4, T5> : IAsyncStateMachine where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public AsyncTaskMethodBuilder<(T1, T2, T3, T4, T5)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public Task<T1> task1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public Task<T2> task2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public Task<T3> task3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public Task<T4> task4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public Task<T5> task5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x574D720", Offset = "0x574C720", VA = "0x18574D720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x574EB10", Offset = "0x574DB10", VA = "0x18574EB10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005A")]
		[CompilerGenerated]
		private struct <While>d__38 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x887FEB0", Offset = "0x887EEB0", VA = "0x18887FEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8880090", Offset = "0x887F090", VA = "0x188880090", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		[CompilerGenerated]
		private struct <While>d__39 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private TaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x88800F0", Offset = "0x887F0F0", VA = "0x1888800F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x8880460", Offset = "0x887F460", VA = "0x188880460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		[CompilerGenerated]
		private struct <WhileWithTimeout>d__41 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x88804C0", Offset = "0x887F4C0", VA = "0x1888804C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x88807B0", Offset = "0x887F7B0", VA = "0x1888807B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct <WhileWithTimeout>d__42 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public Func<bool> condition;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public TimeSpan pollingInterval;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public TimeSpan timeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public Action<OperationCanceledException> handleTimeout;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8880810", Offset = "0x887F810", VA = "0x188880810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x8880A60", Offset = "0x887FA60", VA = "0x188880A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static SynchronizationContext? RWBKDKWOXAE;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly TaskCompletionSource<None> RMCHALNNTVO;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static Task WXTBRCQMFXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x887A980", Offset = "0x8879980", VA = "0x18887A980")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x88797B0", Offset = "0x88787B0", VA = "0x1888797B0")]
		public static bool KTOYXGQNFWD(this Task a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x887AF70", Offset = "0x8879F70", VA = "0x18887AF70")]
		[AsyncStateMachine(typeof(<AsNone>d__3))]
		public static Task<None> WHDDCWOQJKH(this Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C0F0", Offset = "0x3B9B0F0", VA = "0x183B9C0F0")]
		public static Task<T> IPGJCRSEGAK<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8879560", Offset = "0x8878560", VA = "0x188879560")]
		public static Task KOKCPQPZBNA(this Task a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3B9F450", Offset = "0x3B9E450", VA = "0x183B9F450")]
		public static Task<TResult> KOKCPQPZBNA<TResult>(this Task<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3B9D590", Offset = "0x3B9C590", VA = "0x183B9D590")]
		public static TaskCompletionSource<TResult> KOKCPQPZBNA<TResult>(this TaskCompletionSource<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8879210", Offset = "0x8878210", VA = "0x188879210")]
		public static IDisposable? HFBLOWXPRXB(CancellationToken a, CancellationToken b, [Out] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x887B060", Offset = "0x887A060", VA = "0x18887B060")]
		[AsyncStateMachine(typeof(<FireAndForget>d__9))]
		public static void YMCWFYIHJFB(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x88790E0", Offset = "0x88780E0", VA = "0x1888790E0")]
		[AsyncStateMachine(typeof(<FireAndForgetSilent>d__10))]
		public static void GEGUAXKJOOK(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3BA1370", Offset = "0x3BA0370", VA = "0x183BA1370")]
		[AsyncStateMachine(typeof(<IgnoreException>d__11<>))]
		public static Task KOPLHAAZOSE<TException>(this Task a) where TException : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C4F0", Offset = "0x3B9B4F0", VA = "0x183B9C4F0")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__15<>))]
		public static Task<T> KCTBDMMABRB<T>(this Task<T> a, Log b, Func<Task<T>, string> c, bool d = false) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C310", Offset = "0x3B9B310", VA = "0x183B9C310")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__16<>))]
		public static Task<T> KCTBDMMABRB<T>(this Task<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x88793A0", Offset = "0x88783A0", VA = "0x1888793A0")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__17))]
		public static Task KCTBDMMABRB(this Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8879470", Offset = "0x8878470", VA = "0x188879470")]
		[AsyncStateMachine(typeof(<LogExceptions>d__18))]
		public static Task<TaskStatus> KNEAQRKAQHB(this Task? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3B9B720", Offset = "0x3B9A720", VA = "0x183B9B720")]
		public static (Task<b?>?, Action<b?>?) CGKXIMUJDKC<b>([Optional] CancellationToken a)
		{
			return default((Task<b>, Action<b>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3B9BF70", Offset = "0x3B9AF70", VA = "0x183B9BF70")]
		[AsyncStateMachine(typeof(<TryTransformList>d__24<, >))]
		public static Task<List<TResult>> GJBDJQVLFAC<TResult, TInput>(this Task<List<TInput>> a, TryTransformFunction<TInput, TResult> b) where TResult : notnull where TInput : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8878FB0", Offset = "0x8877FB0", VA = "0x188878FB0")]
		[AsyncStateMachine(typeof(<RunWhile>d__25))]
		public static Task FGPZFSPAQRJ(Task a, CancellationToken b, Func<CancellationToken, Task> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x887A9F0", Offset = "0x88799F0", VA = "0x18887A9F0")]
		[AsyncStateMachine(typeof(<WaitAsync>d__26))]
		public static Task SIGCHHVQKUQ(Func<CancellationToken, Task> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3BA19C0", Offset = "0x3BA09C0", VA = "0x183BA19C0")]
		[AsyncStateMachine(typeof(<WaitAsync>d__27<>))]
		public static Task<T> SIGCHHVQKUQ<T>(Func<CancellationToken, Task<T>> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Func<OperationCanceledException, T>? handleTimeout) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x887A210", Offset = "0x8879210", VA = "0x18887A210")]
		public static Task QLVCIFUQJIW(params Task[] tasks)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x887A260", Offset = "0x8879260", VA = "0x18887A260")]
		public static Task QLVCIFUQJIW(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x88797E0", Offset = "0x88787E0", VA = "0x1888797E0")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__30))]
		public static Task<IEnumerable<Task>> KXAJVUUPVZD(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3BA1630", Offset = "0x3BA0630", VA = "0x183BA1630")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__32<>))]
		public static Task<IEnumerable<Task<T>>> KXAJVUUPVZD<T>(IEnumerable<Task<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3B9BD30", Offset = "0x3B9AD30", VA = "0x183B9BD30")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__34<, , >))]
		public static Task<(T1, T2, T3)> FDCGZEWIWWM<T1, T2, T3>(Task<T1> a, Task<T2> b, Task<T3> c) where T1 : notnull where T2 : notnull where T3 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3B9BBE0", Offset = "0x3B9ABE0", VA = "0x183B9BBE0")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__36<, , , , >))]
		public static Task<(T1, T2, T3, T4, T5)> FDCGZEWIWWM<T1, T2, T3, T4, T5>(Task<T1> a, Task<T2> b, Task<T3> c, Task<T4> d, Task<T5> e) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8878D00", Offset = "0x8877D00", VA = "0x188878D00")]
		[AsyncStateMachine(typeof(<While>d__38))]
		public static Task CZLJCONVAQC(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8878DF0", Offset = "0x8877DF0", VA = "0x188878DF0")]
		[AsyncStateMachine(typeof(<While>d__39))]
		public static Task CZLJCONVAQC(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x887A850", Offset = "0x8879850", VA = "0x18887A850")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__41))]
		public static Task QWRGBSUHMNX(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x887A710", Offset = "0x8879710", VA = "0x18887A710")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__42))]
		public static Task QWRGBSUHMNX(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8879FC0", Offset = "0x8878FC0", VA = "0x188879FC0")]
		[AsyncStateMachine(typeof(<Until>d__44))]
		public static Task QGUSQPQTSOX(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x887A0B0", Offset = "0x88790B0", VA = "0x18887A0B0")]
		[AsyncStateMachine(typeof(<Until>d__45))]
		public static Task QGUSQPQTSOX(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x88798E0", Offset = "0x88788E0", VA = "0x1888798E0")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__47))]
		public static Task LBQWYASHUJE(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8879A10", Offset = "0x8878A10", VA = "0x188879A10")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__48))]
		public static Task LBQWYASHUJE(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x887AE80", Offset = "0x8879E80", VA = "0x18887AE80")]
		[AsyncStateMachine(typeof(<Then>d__50))]
		[Obsolete]
		public static Task Then(this Task task, Action then)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3BA1C10", Offset = "0x3BA0C10", VA = "0x183BA1C10")]
		[AsyncStateMachine(typeof(<Then>d__51<>))]
		[Obsolete]
		public static Task Then<T>(this Task<T> task, Action<T> then) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8878F00", Offset = "0x8877F00", VA = "0x188878F00")]
		private static void EQTSXSONSHS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8879B50", Offset = "0x8878B50", VA = "0x188879B50")]
		public static bool LPHWWGEEBJD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x887AD00", Offset = "0x8879D00", VA = "0x18887AD00")]
		private static void TYYDYHVYRIN(SynchronizationContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x887ABF0", Offset = "0x8879BF0", VA = "0x18887ABF0")]
		private static void TXYOEZYLJIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8879EB0", Offset = "0x8878EB0", VA = "0x188879EB0")]
		public static void MLOKZBMVYAS([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8879190", Offset = "0x8878190", VA = "0x188879190")]
		public static void GHSJBKWSCIT([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x887A1C0", Offset = "0x88791C0", VA = "0x18887A1C0")]
		public static WKUYAUAYQMR<JCUVPIZWEBL> QIPEGVNWZBK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8879F70", Offset = "0x8878F70", VA = "0x188879F70")]
		public static WKUYAUAYQMR<JCUVPIZWEBL> PLUQNWGRDKF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x887AB20", Offset = "0x8879B20", VA = "0x18887AB20")]
		[AsyncStateMachine(typeof(<RunOnMainThread>d__68))]
		public static Task SZRFWMWSDDY(Func<Task> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class TestedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public TestedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class VWUMHGUSMZV
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x8881640", Offset = "0x8880640", VA = "0x188881640")]
		public static bool FGLBGEZVGXL(this DLQLZVLWGAM a, DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8881760", Offset = "0x8880760", VA = "0x188881760")]
		public static TimeSpan MHXDGWPCLXO(this DLQLZVLWGAM a, DateTime b)
		{
			return default(TimeSpan);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class ZEDVQXBBIAG : DLQLZVLWGAM
	{
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static readonly DLQLZVLWGAM HNQVBJEYTYC;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DateTime FPZYGIHNXJV
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8882120", Offset = "0x8881120", VA = "0x188882120", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DateTimeOffset ASETTCQCGHC
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8882160", Offset = "0x8881160", VA = "0x188882160", Slot = "5")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public ZEDVQXBBIAG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public interface DLQLZVLWGAM
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		DateTime FPZYGIHNXJV
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		DateTimeOffset ASETTCQCGHC
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class JBPVLTSDWXO
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static long FKXVYYXYWAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x8876E30", Offset = "0x8875E30", VA = "0x188876E30")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static long ISZZOJTDEGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8876C20", Offset = "0x8875C20", VA = "0x188876C20")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static double ZAXAFQPFXKU
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8876CC0", Offset = "0x8875CC0", VA = "0x188876CC0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static double BGKZNZQDJQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8877000", Offset = "0x8876000", VA = "0x188877000")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static double GIRWQMKLXDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8876C70", Offset = "0x8875C70", VA = "0x188876C70")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static double PHATJTKJNNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8876B00", Offset = "0x8875B00", VA = "0x188876B00")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8876EE0", Offset = "0x8875EE0", VA = "0x188876EE0")]
		public static double WRHZTDGHTLE(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8876D10", Offset = "0x8875D10", VA = "0x188876D10")]
		public static double QYVZTGBWAWR(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8876F70", Offset = "0x8875F70", VA = "0x188876F70")]
		public static double YHCNWWDKKHW(double a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8876DA0", Offset = "0x8875DA0", VA = "0x188876DA0")]
		public static long RWDRAFFDFIP(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8876AF0", Offset = "0x8875AF0", VA = "0x188876AF0")]
		public static long KXIKABZFJQF(long a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8876B50", Offset = "0x8875B50", VA = "0x188876B50")]
		public static double OAZNBPGPHTF(long a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8876E80", Offset = "0x8875E80", VA = "0x188876E80")]
		public static double TDUTQPJECRW(long a, long b)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class NUKXOQIZQQK : GGJILDPYXWZ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly TimeSpan PGMNBRGFCVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly System.Timers.Timer VIMHVNHBLNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private TimeSpan DLEHJPOMNSU;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TimeSpan QOOJPSJYIFK
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x88786B0", Offset = "0x88776B0", VA = "0x1888786B0", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Action? HTRBASAHFRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xACFDA0", Offset = "0xACEDA0", VA = "0x180ACFDA0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xACFF70", Offset = "0xACEF70", VA = "0x180ACFF70", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8878940", Offset = "0x8877940", VA = "0x188878940")]
		[Preserve]
		public NUKXOQIZQQK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x88789B0", Offset = "0x88779B0", VA = "0x1888789B0")]
		public NUKXOQIZQQK(TimeSpan a, [Optional] Action? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x8878810", Offset = "0x8877810", VA = "0x188878810", Slot = "7")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x88785A0", Offset = "0x88775A0", VA = "0x1888785A0", Slot = "8")]
		public void FBDQIWNVURC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x88788A0", Offset = "0x88778A0", VA = "0x1888788A0", Slot = "9")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x1412070", Offset = "0x1411070", VA = "0x181412070")]
		private void JCQERCYBKRZ(object a, ElapsedEventArgs b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x8878610", Offset = "0x8877610", VA = "0x188878610")]
		private static void PWRITHIXSMK(TimeSpan a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x8878500", Offset = "0x8877500", VA = "0x188878500", Slot = "10")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
	public class TodoAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public readonly string? Tag;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public readonly string Description;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0840", Offset = "0x1AAF840", VA = "0x181AB0840")]
		public TodoAttribute(string description)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x58A2A40", Offset = "0x58A1A40", VA = "0x1858A2A40")]
		public TodoAttribute(string tag, string description)
		{
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[DebuggerDisplay("U32: {U32}, I32: {I32}, F32: {F32}, U16_0: {U16_0}, I16_1: {I16_1}, Char_0: '{Char_0}', Char_1: '{Char_1}', U8_0: {U8_0}, U8_1: {U8_1}, U8_2: {U8_2}, U8_3: {U8_3}, Bool_0: {Bool_0}, Bool_1: {Bool_1}, Bool_2: {Bool_2}, Bool_3: {Bool_3}")]
	public struct Union32 : IEquatable<Union32>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public uint U32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public int I32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public float F32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public ushort U16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public ushort U16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public short I16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public short I16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public char Char_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public char Char_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public byte U8_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public byte U8_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public byte U8_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public byte U8_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public bool Bool_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public bool Bool_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public bool Bool_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public bool Bool_3;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267C60", VA = "0x182268C60")]
		public static Union32 KOAXXBNDJAZ(uint a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x2268C60", Offset = "0x2267C60", VA = "0x182268C60")]
		public static Union32 KLODQPFMRUV(int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8880AC0", Offset = "0x887FAC0", VA = "0x188880AC0")]
		public static Union32 BEGNDGUOJBK(float a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8880B60", Offset = "0x887FB60", VA = "0x188880B60")]
		public static Union32 TJMLVBYGEJK(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8880B60", Offset = "0x887FB60", VA = "0x188880B60")]
		public static Union32 IBVSIAVMBDH(bool a, bool b, bool c, bool d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8880B60", Offset = "0x887FB60", VA = "0x188880B60")]
		public static Union32 ROULXVQOIOU(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x25CB820", Offset = "0x25CA820", VA = "0x1825CB820")]
		public static bool RZMMTPOVALZ(Union32 a, Union32 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x25CB800", Offset = "0x25CA800", VA = "0x1825CB800", Slot = "4")]
		public bool Equals(Union32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8880AD0", Offset = "0x887FAD0", VA = "0x188880AD0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x16AB700", Offset = "0x16AA700", VA = "0x1816AB700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8880B80", Offset = "0x887FB80", VA = "0x188880B80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public struct Union64
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public ulong U64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public long I64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public double F64;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public uint U32_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public uint U32_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public int I32_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public int I32_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public float F32_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public float F32_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public ushort U16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public ushort U16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public ushort U16_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public ushort U16_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public short I16_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public short I16_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public short I16_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public short I16_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public char Char_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public char Char_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public char Char_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public char Char_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public byte U8_0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public byte U8_1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public byte U8_2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public byte U8_3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public byte U8_4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public byte U8_5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public byte U8_6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public byte U8_7;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0")]
		public static Union64 New(long i64)
		{
			return default(Union64);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x8881240", Offset = "0x8880240", VA = "0x188881240")]
		public static Union64 New(byte u8_0, byte u8_1, byte u8_2, byte u8_3, byte u8_4, byte u8_5, byte u8_6, byte u8_7)
		{
			return default(Union64);
		}
	}
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[DebuggerDisplay("U8: {U8}, Bool: {Bool}")]
	public struct Union8 : IEquatable<Union8>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public byte U8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public bool Bool;

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x32BF1A0", Offset = "0x32BE1A0", VA = "0x1832BF1A0")]
		public static Union8 TJMLVBYGEJK(byte a)
		{
			return default(Union8);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x32BF1A0", Offset = "0x32BE1A0", VA = "0x1832BF1A0")]
		public static Union8 IBVSIAVMBDH(bool a)
		{
			return default(Union8);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x8881330", Offset = "0x8880330", VA = "0x188881330")]
		public static bool RZMMTPOVALZ(Union8 a, Union8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7757070", Offset = "0x7756070", VA = "0x187757070", Slot = "4")]
		public bool Equals(Union8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8881290", Offset = "0x8880290", VA = "0x188881290", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x8881320", Offset = "0x8880320", VA = "0x188881320", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x8881340", Offset = "0x8880340", VA = "0x188881340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class UnreachableCaseException<T> : Exception where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public readonly T Case;

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x65BE040", Offset = "0x65BD040", VA = "0x1865BE040")]
		public UnreachableCaseException(T @case)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class ISLQXVMBIPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x39F2FF0", Offset = "0x39F1FF0", VA = "0x1839F2FF0")]
		public static IEnumerable<T> CBEVHOVQREU<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0")]
		public static T[] WVOYYYCKBYK<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xEC56A0", Offset = "0xEC46A0", VA = "0x180EC56A0")]
		public static IEnumerable<T> CSMCPMCNDXB<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x39F4000", Offset = "0x39F3000", VA = "0x1839F4000")]
		public static HashSet<T> HVEJZUCVKPZ<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x39F4170", Offset = "0x39F3170", VA = "0x1839F4170")]
		public static KeyValuePair<TKey, TValue> PFWSFEIUHWB<TKey, TValue>([In] TKey key, [In] TValue value) where TKey : notnull where TValue : notnull
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x39F3BD0", Offset = "0x39F2BD0", VA = "0x1839F3BD0")]
		public static List<T> EDYFFIIIPOB<T>(IEnumerable<T> a) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[AttributeUsage(AttributeTargets.All)]
	public sealed class WillBeRenamedToAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public readonly string To;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0xAF8940", Offset = "0xAF7940", VA = "0x180AF8940")]
		public WillBeRenamedToAttribute(string to)
		{
		}
	}
}
namespace RecRoom.NoEngine.Common.Delegates
{
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public delegate object FastestMessageFunc<T>([In] T args);
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public delegate object FastMessageFunc<T>(T args);
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[CS9FunctionPointer]
	public delegate string FormatAsyncCallstackDelegate(string str, string? prefix, bool trailingWhitespace);
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[CS9FunctionPointer]
	public delegate void LogDelegate(string message);
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[CS9FunctionPointer]
	public delegate void LogExceptionDelegate(Exception ex);
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public delegate object MessageFunc();
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[CS9FunctionPointer]
	public delegate bool ShouldLogDelegate();
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[CS9FunctionPointer]
	public delegate string ToDebugJsonDelegate(object obj);
}
namespace RecRoom.NoEngine.Common.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[AttributeUsage(AttributeTargets.Enum)]
	public class ContiguousZeroIndexedEnumAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public ContiguousZeroIndexedEnumAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public static class FMWFXUOKCRQ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct <TimerDelay>d__2 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public AsyncTaskMethodBuilder<bool> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public int millisecondsDelay;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000156")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000157")]
			private CancellationTokenRegistration <cancellationTokenRegistration>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000158")]
			private System.Threading.Timer <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000159")]
			private object <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private int <>7__wrap4;

			[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
			[Cpp2IlInjected.Token(Token = "0x400015B")]
			private bool <>7__wrap5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private object <>7__wrap6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400015D")]
			private int <>7__wrap7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400015E")]
			private bool <>7__wrap8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400015F")]
			private TaskAwaiter<bool> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000160")]
			private ValueTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x887D9C0", Offset = "0x887C9C0", VA = "0x18887D9C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x887E280", Offset = "0x887D280", VA = "0x18887E280", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly TimerCallback MRXLRWJWNRT;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private static readonly Action<object?> TVCZFWRBZJS;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8875BB0", Offset = "0x8874BB0", VA = "0x188875BB0")]
		public static Task<bool> BFTNUMQUCRG(int a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8875FD0", Offset = "0x8874FD0", VA = "0x188875FD0")]
		[AsyncStateMachine(typeof(<TimerDelay>d__2))]
		private static Task<bool> XRJBTZMAREF(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8875F40", Offset = "0x8874F40", VA = "0x188875F40")]
		private static void QZZCNOWQRLY(object? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8875EB0", Offset = "0x8874EB0", VA = "0x188875EB0")]
		private static void IZWEQEBMAXD(object? a)
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
