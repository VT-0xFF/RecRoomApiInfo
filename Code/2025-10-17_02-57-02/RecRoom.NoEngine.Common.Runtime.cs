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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x865FC20", Offset = "0x865E220", VA = "0x18865FC20")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD0990", Offset = "0xACEF90", VA = "0x180AD0990")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace System.Text
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class CPNEJKIHVIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x865AD20", Offset = "0x8659320", VA = "0x18865AD20")]
		public static string CABXOKJZAOR(this Encoding a, [In] ReadOnlySequence<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x36C7220", Offset = "0x36C5820", VA = "0x1836C7220")]
		private static void LVMYVKVLOTM<a>(this ReadOnlySequence<a> sequence, [Out] ReadOnlySpan<a> firstSpan, [Out] SequencePosition a)
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
		[Cpp2IlInjected.Address(RVA = "0x865FA90", Offset = "0x865E090", VA = "0x18865FA90")]
		public MemberNotNullWhenAttribute(bool returnValue, string member)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x865FB40", Offset = "0x865E140", VA = "0x18865FB40")]
		public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class SNYSDFDYURX
	{
	}
}
namespace RecRoom.DebugStats
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface OSTXANVOCBN
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool EIWDQNHUFYN
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JWEVFBEDEXF(string a, double b, [Optional] string? unit);
	}
}
namespace RecRoom.Analytics
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class SIWDZCWCVKV : CAOQSOLKXAJ, QHRFUUADGLJ, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int ZUGJLQUZTDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Queue<double> XDBJINESXTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private double GJOALLZOREY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private double IICQPQNUGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private double XAXRDGBTOHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int TYPQDIFABWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private double GGUGHCUHNUS;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int SSWRAJBCYAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAD6210", Offset = "0xAD4810", VA = "0x180AD6210")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public double VIRUNAIPRPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x8660620", Offset = "0x865EC20", VA = "0x188660620", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public double QLTHRPZANNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2A53FF0", Offset = "0x2A525F0", VA = "0x182A53FF0", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double SKHXVUNGCPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2A73BF0", Offset = "0x2A721F0", VA = "0x182A73BF0", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8660820", Offset = "0x865EE20", VA = "0x188660820")]
		public SIWDZCWCVKV(int a, double b = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8660680", Offset = "0x865EC80", VA = "0x188660680", Slot = "7")]
		public void KCSIGIWXJLV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86607B0", Offset = "0x865EDB0", VA = "0x1886607B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8660530", Offset = "0x865EB30", VA = "0x188660530", Slot = "9")]
		public object Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class ZLTJNUOAKYZ : CAOQSOLKXAJ, QHRFUUADGLJ, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private long ZYZGCKPXBNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private double HAYEHPOVYHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private double CHVCVHJYAHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private double BGPYEAMPOZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private double PDFKWMNGJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private double GJOALLZOREY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private double IICQPQNUGHI;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long MAXRYHRIEQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public double QLTHRPZANNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4F5CC10", Offset = "0x4F5B210", VA = "0x184F5CC10", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public double SKHXVUNGCPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE8CC10", Offset = "0xE8B210", VA = "0x180E8CC10", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public double YOGBFLPDDCQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xE8CC00", Offset = "0xE8B200", VA = "0x180E8CC00")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public double VIRUNAIPRPH
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A53C40", Offset = "0x2A52240", VA = "0x182A53C40", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8667370", Offset = "0x8665970", VA = "0x188667370", Slot = "10")]
		public virtual void KCSIGIWXJLV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8667490", Offset = "0x8665A90", VA = "0x188667490", Slot = "11")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8667310", Offset = "0x8665910", VA = "0x188667310", Slot = "9")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8661250", Offset = "0x865F850", VA = "0x188661250")]
		public ZLTJNUOAKYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class TXOLWKIWKEP : ZLTJNUOAKYZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public double EGCLHCZZXGT
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xE8CBF0", Offset = "0xE8B1F0", VA = "0x180E8CBF0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x787FBC0", Offset = "0x787E1C0", VA = "0x18787FBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86610E0", Offset = "0x865F6E0", VA = "0x1886610E0", Slot = "10")]
		public override void KCSIGIWXJLV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8661210", Offset = "0x865F810", VA = "0x188661210", Slot = "11")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8661250", Offset = "0x865F850", VA = "0x188661250")]
		public TXOLWKIWKEP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface CAOQSOLKXAJ : QHRFUUADGLJ, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		double VIRUNAIPRPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		double QLTHRPZANNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		double SKHXVUNGCPY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ZKQJPECKLTO : QHRFUUADGLJ, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private double DUMMUJBOAVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private double QTOEIMCGNWA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public double HOYELULZOXT
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x8667300", Offset = "0x8665900", VA = "0x188667300")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x735FA60", Offset = "0x735E060", VA = "0x18735FA60", Slot = "4")]
		public void KCSIGIWXJLV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86672F0", Offset = "0x86658F0", VA = "0x1886672F0", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86672A0", Offset = "0x86658A0", VA = "0x1886672A0", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public ZKQJPECKLTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface QHRFUUADGLJ : ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KCSIGIWXJLV(double a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class KRGSXQPRJLU : QHRFUUADGLJ, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private double ZXQVAYEVMSN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double HOYELULZOXT
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x12B2520", Offset = "0x12B0B20", VA = "0x1812B2520")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5A5B080", Offset = "0x5A59680", VA = "0x185A5B080", Slot = "4")]
		public void KCSIGIWXJLV(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x865C590", Offset = "0x865AB90", VA = "0x18865C590", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x865C540", Offset = "0x865AB40", VA = "0x18865C540", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public KRGSXQPRJLU()
		{
		}
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ONLTKXVJEIE<a> : IDisposable
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
			public ONLTKXVJEIE<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x5005C30", Offset = "0x5004230", VA = "0x185005C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x5006A60", Offset = "0x5005060", VA = "0x185006A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly CancellationTokenSource ERMOUZTPHRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CancellationTokenSource? FKXOSQQPPRM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskCompletionSource<a>? GBXZTQGMTTP;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3F40", Offset = "0x5BC2540", VA = "0x185BC3F40")]
		[AsyncStateMachine(typeof(ONLTKXVJEIE<>.<Debounce>d__4))]
		public Task<a> YOJYKZRRCCH(TaskGenerator taskGenerator, [Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5BC3D90", Offset = "0x5BC2390", VA = "0x185BC3D90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5BC4070", Offset = "0x5BC2670", VA = "0x185BC4070")]
		public ONLTKXVJEIE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class Box<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly EqualityComparer<T> UMKEDJGELBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T HOYELULZOXT;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x494DE60", Offset = "0x494C460", VA = "0x18494DE60")]
		public Box([In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x72FE560", Offset = "0x72FCB60", VA = "0x1872FE560", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72FF0E0", Offset = "0x72FD6E0", VA = "0x1872FF0E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x72FF2C0", Offset = "0x72FD8C0", VA = "0x1872FF2C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x36BB600", Offset = "0x36B9C00", VA = "0x1836BB600")]
		public static Box<T> New<T>([In] T value) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class LVECJIIZLAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x865EA70", Offset = "0x865D070", VA = "0x18865EA70")]
		public static void FMFMGZZEHFG(this CancellationTokenSource a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
	public class CS9FunctionPointerAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public CS9FunctionPointerAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
	public class CS9ImprovedNullableConstraints : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public CS9ImprovedNullableConstraints(string why)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class KGJIGLVBUBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x39B6510", Offset = "0x39B4B10", VA = "0x1839B6510")]
		public static LogString AMMTOJXIAYD<a>()
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x865C440", Offset = "0x865AA40", VA = "0x18865C440")]
		public static LogString TJSMNORLHRJ([CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x39B6880", Offset = "0x39B4E80", VA = "0x1839B6880")]
		public static LogString EPCHUZKIQTT<T>([CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x39B64A0", Offset = "0x39B4AA0", VA = "0x1839B64A0")]
		public static LogString AMMTOJXIAYD<T>(this T a) where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x39B6970", Offset = "0x39B4F70", VA = "0x1839B6970")]
		public static LogString EPCHUZKIQTT<T>(this T a, [CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x865C3C0", Offset = "0x865A9C0", VA = "0x18865C3C0")]
		public static LogString EPCHUZKIQTT(string a, [CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x865C4A0", Offset = "0x865AAA0", VA = "0x18865C4A0")]
		public static string ZWZWMTMPUPA(this object a)
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
	public sealed class MREFXOEKCQP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly MREFXOEKCQP ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public MREFXOEKCQP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class BEUCGETDWNF
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static EngineShimState CRKKSUPCLKH;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static EngineShimState XHVPHBXGULK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x865A2B0", Offset = "0x86588B0", VA = "0x18865A2B0")]
			get
			{
				return default(EngineShimState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LogDelegates GEEWBSFENWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x865A300", Offset = "0x8658900", VA = "0x18865A300")]
			get
			{
				return default(LogDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static PerfScopeDelegates HEKFGSFRTJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x865A1C0", Offset = "0x86587C0", VA = "0x18865A1C0")]
			get
			{
				return default(PerfScopeDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static bool GMYCHXSCUXZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x865A790", Offset = "0x8658D90", VA = "0x18865A790")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x865A5F0", Offset = "0x8658BF0", VA = "0x18865A5F0")]
		public static void RHKPJYJCJKF([In] EngineShimState engineShimState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x865A350", Offset = "0x8658950", VA = "0x18865A350")]
		public static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x865A870", Offset = "0x8658E70", VA = "0x18865A870")]
		public static void XPCLCMOKABS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x360EBD0", Offset = "0x360D1D0", VA = "0x18360EBD0")]
		public static void XPCLCMOKABS<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x865A550", Offset = "0x8658B50", VA = "0x18865A550")]
		public static void RGKDMJVRGSP(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x865A160", Offset = "0x8658760", VA = "0x18865A160")]
		public static void CVFEGHZWWBI(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x865A420", Offset = "0x8658A20", VA = "0x18865A420")]
		public static void NBVDAYZDQTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x865A940", Offset = "0x8658F40", VA = "0x18865A940")]
		public static string ZWZWMTMPUPA(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x865A800", Offset = "0x8658E00", VA = "0x18865A800")]
		public static long WNHSPUQZHEJ()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x865A210", Offset = "0x8658810", VA = "0x18865A210")]
		public static bool HRKRGJXOPIZ(bool a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x865A480", Offset = "0x8658A80", VA = "0x18865A480")]
		public static double OVGAZGULGFY()
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
		public bool XEAGQKLOKWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x865B320", Offset = "0x8659920", VA = "0x18865B320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x865BB60", Offset = "0x865A160", VA = "0x18865BB60")]
		public EngineShimState([In] LogDelegates logDelegates, [In] PerfScopeDelegates perfScopeDelegates, ToDebugJsonDelegate toDebugJsonDelegate, GetOngoingTicksDelegate getOngoingTicksDelegate, FormatAsyncCallstackDelegate formatAsyncCallstackDelegate, GetIsQuittingDelegate getIsQuittingDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xB674E0", Offset = "0xB65AE0", VA = "0x180B674E0")]
		private static string PVNHSILATYB(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAA6860", Offset = "0xAA4E60", VA = "0x180AA6860")]
		private static long SYMGOOGJVCO()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		private static string GXIZBGLXJNQ(string a, string? prefix, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		private static bool RQKOJFGSFRW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x865B4B0", Offset = "0x8659AB0", VA = "0x18865B4B0")]
		private static EngineShimState XTCJPTIRROT()
		{
			return default(EngineShimState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface FAHXEUAJZBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AHOFSAAQNGI RKOJMYXYBOB();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface AHOFSAAQNGI : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool WFQPOOLMCWV
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NPEEMGAJFGV();
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface DAMLRSAATDB<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool WYCXDAIGFPQ([In] a other);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void InAction<T>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct IndexValuePair<T> : IEquatable<IndexValuePair<T>>, DAMLRSAATDB<IndexValuePair<T>> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly int Index;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x30B4EB0", Offset = "0x30B34B0", VA = "0x1830B4EB0")]
		public IndexValuePair([In] T value, int index)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x51EDCD0", Offset = "0x51EC2D0", VA = "0x1851EDCD0")]
		public static bool HCJGUXGANNO([In] IndexValuePair<T> left, [In] IndexValuePair<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x51EC980", Offset = "0x51EAF80", VA = "0x1851EC980", Slot = "4")]
		public bool Equals(IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x51EC710", Offset = "0x51EAD10", VA = "0x1851EC710", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x51F08A0", Offset = "0x51EEEA0", VA = "0x1851F08A0")]
		public bool WYCXDAIGFPQ([In] IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x51ECD60", Offset = "0x51EB360", VA = "0x1851ECD60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x51EF700", Offset = "0x51EDD00", VA = "0x1851EF700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x51EED10", Offset = "0x51ED310", VA = "0x1851EED10")]
		public void PKKFLCUPRJW([Out] T a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x51EBFB0", Offset = "0x51EA5B0", VA = "0x1851EBFB0")]
		public (T, int) EEYLWBQKTCV()
		{
			return default((T, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x51F0260", Offset = "0x51EE860", VA = "0x1851F0260", Slot = "5")]
		private bool VAFDRBLPNRT([In] IndexValuePair<T> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class OKEAVISEOHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3B0D680", Offset = "0x3B0BC80", VA = "0x183B0D680")]
		public static IndexValuePair<T> New<T>([In] T value, int index) where T : notnull
		{
			return default(IndexValuePair<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class XWGHSGWQGHW
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8120", Offset = "0x3ED6720", VA = "0x183ED8120")]
		public static bool WYCXDAIGFPQ<T, U>([In] T self, [In] U obj) where T : notnull, DAMLRSAATDB<T> where U : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate TResult InFunc<T, out TResult>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface EOCPOTBZUFG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		TimeSpan VWJSEOXYZGL
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		Action? FXOASWOYLAY
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
		void ACIZBOKVNGH();

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
		public bool XEAGQKLOKWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x865EAA0", Offset = "0x865D0A0", VA = "0x18865EAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xF7D500", Offset = "0xF7BB00", VA = "0x180F7D500")]
		public LogDelegates(ShouldLogDelegate shouldLogDelegate, LogDelegate logDelegate, ShouldLogDelegate shouldLogWarningDelegate, LogDelegate logWarningDelegate, ShouldLogDelegate shouldLogErrorDelegate, LogDelegate logErrorDelegate, LogExceptionDelegate logExceptionDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		private static bool OFWBONQSMYE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void GSIAYIZEMQV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		private static bool KKUYDVAGCQQ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void OLDTGZSOOZN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xAF05B0", Offset = "0xAEEBB0", VA = "0x180AF05B0")]
		private static bool BHFURFELCYS()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void DZMTJJPIQJH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void WQMGARJZSCS(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x865EF80", Offset = "0x865D580", VA = "0x18865EF80")]
		private static LogDelegates XTCJPTIRROT()
		{
			return default(LogDelegates);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350")]
		private static bool CGLHILFKUEY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x865EDC0", Offset = "0x865D3C0", VA = "0x18865EDC0")]
		public void Log(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x865ED50", Offset = "0x865D350", VA = "0x18865ED50")]
		public void KMVJMNBSKBE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x865EF10", Offset = "0x865D510", VA = "0x18865EF10")]
		public void XPCLCMOKABS(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xF7D3B0", Offset = "0xF7B9B0", VA = "0x180F7D3B0")]
		public void RGKDMJVRGSP(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x865EE30", Offset = "0x865D430", VA = "0x18865EE30")]
		public void XPCLCMOKABS(MessageFunc a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x39DB740", Offset = "0x39D9D40", VA = "0x1839DB740")]
		public void XPCLCMOKABS<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x39DB5C0", Offset = "0x39D9BC0", VA = "0x1839DB5C0")]
		public void Log<T>([In] T arg, FastestMessageFunc<T> message) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x39DBA20", Offset = "0x39DA020", VA = "0x1839DBA20")]
		public void XPCLCMOKABS<T>([In] T arg, FastestMessageFunc<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x865EC80", Offset = "0x865D280", VA = "0x18865EC80")]
		public bool HRKRGJXOPIZ(bool a, string b)
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
		[Cpp2IlInjected.Address(RVA = "0xF411F0", Offset = "0xF3F7F0", VA = "0x180F411F0")]
		public LogString(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70")]
		public static implicit operator string([In] LogString self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x153BCA0", Offset = "0x153A2A0", VA = "0x18153BCA0")]
		public static implicit operator LogString(string other)
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x865F9D0", Offset = "0x865DFD0", VA = "0x18865F9D0")]
		public string PTFDFZWEZKY(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x865F8F0", Offset = "0x865DEF0", VA = "0x18865F8F0")]
		public string KKJRBLKOBDQ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xBBDF70", Offset = "0xBBC570", VA = "0x180BBDF70", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public MustUseReturnValueAttribute()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct None : IEquatable<None>
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xAC1350", Offset = "0xABF950", VA = "0x180AC1350", Slot = "4")]
		public bool Equals(None other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x865FB90", Offset = "0x865E190", VA = "0x18865FB90", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x865FBE0", Offset = "0x865E1E0", VA = "0x18865FBE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x865FBF0", Offset = "0x865E1F0", VA = "0x18865FBF0", Slot = "3")]
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
		public bool YCTXCBVHJWK
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0xC01330", Offset = "0xBFF930", VA = "0x180C01330")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5C78920", Offset = "0x5C76F20", VA = "0x185C78920")]
		public Option([In] T value, bool isValid)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5C77E60", Offset = "0x5C76460", VA = "0x185C77E60")]
		public static bool HCJGUXGANNO([In] Option<T> left, [In] Option<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x5C75880", Offset = "0x5C73E80", VA = "0x185C75880", Slot = "4")]
		public bool Equals(Option<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5C76330", Offset = "0x5C74930", VA = "0x185C76330", Slot = "0")]
		public override bool Equals(object? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x5C76A80", Offset = "0x5C75080", VA = "0x185C76A80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x5C78360", Offset = "0x5C76960", VA = "0x185C78360", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class YBJBGPPFMUR
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE5B0", Offset = "0x3EDCBB0", VA = "0x183EDE5B0")]
		public static Option<T> QLTWRXHTMLK<T>([In] T value) where T : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE270", Offset = "0x3EDC870", VA = "0x183EDE270")]
		public static Option<T?> None<T>()
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3EDEE00", Offset = "0x3EDD400", VA = "0x183EDEE00")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x3EDEDC0", Offset = "0x3EDD3C0", VA = "0x183EDEDC0")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value, [Out] Option<T> res) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3EDDEB0", Offset = "0x3EDC4B0", VA = "0x183EDDEB0")]
		public static a? CRGPCNFFBTG<a>([In] this Option<a> opt, a? a)
		{
			return (a?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3EDE6D0", Offset = "0x3EDCCD0", VA = "0x183EDE6D0")]
		public static bool SJCMILBPAEQ<T>([In] this Option<T> opt, T a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class QXRKCEZUFZQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3C3A180", Offset = "0x3C38780", VA = "0x183C3A180")]
		public static a RDROHFFVCJO<a>([In] this Option<a> opt) where a : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class IPPSWJPPEHR
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x865C3A0", Offset = "0x865A9A0", VA = "0x18865C3A0")]
		public static bool SWDODYNSERF(int a)
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
		public bool XEAGQKLOKWN
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8660100", Offset = "0x865E700", VA = "0x188660100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xCD7A50", Offset = "0xCD6050", VA = "0x180CD7A50")]
		public PerfScopeDelegates(IntPtr beginPerfScope, IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void VYEDMFQIHHZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850")]
		private static void YYLAXBBSWCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x86601C0", Offset = "0x865E7C0", VA = "0x1886601C0")]
		private static PerfScopeDelegates XTCJPTIRROT()
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
		[Cpp2IlInjected.Address(RVA = "0x14457D0", Offset = "0x1443DD0", VA = "0x1814457D0")]
		private PerfScopeToken(IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8660390", Offset = "0x865E990", VA = "0x188660390")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x86603A0", Offset = "0x865E9A0", VA = "0x1886603A0")]
		public static PerfScopeToken New(string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x2B00660", Offset = "0x2AFEC60", VA = "0x182B00660")]
		public static PerfScopeToken New([In] PerfScopeDelegates perfScopeDelegates, string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2AFFFB0", Offset = "0x2AFE5B0", VA = "0x182AFFFB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public PreserveAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class YURXLKFTMIU : SHA256
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static bool? XYIDIZMUVUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IntPtr STDWSBPTFYD;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static bool MSFVRDYTSAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8667110", Offset = "0x8665710", VA = "0x188667110")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8666BB0", Offset = "0x86651B0", VA = "0x188666BB0")]
		public new static SHA256 Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8666E20", Offset = "0x8665420", VA = "0x188666E20")]
		private static extern int GetSHA256DigestSize();

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8666B40", Offset = "0x8665140", VA = "0x188666B40")]
		private static extern IntPtr CreateSHA256();

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8666CC0", Offset = "0x86652C0", VA = "0x188666CC0")]
		private static extern void DestroySHA256(IntPtr sha256);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x86671B0", Offset = "0x86657B0", VA = "0x1886671B0")]
		private static extern void UpdateSHA256Digest(IntPtr sha256, byte[] data, int offset, int dataLength);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8666D80", Offset = "0x8665380", VA = "0x188666D80")]
		private static extern void FinalSHA256Digest(IntPtr sha256, byte[] digest);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x8667270", Offset = "0x8665870", VA = "0x188667270")]
		private YURXLKFTMIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x8666E90", Offset = "0x8665490", VA = "0x188666E90", Slot = "18")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x8666F50", Offset = "0x8665550", VA = "0x188666F50", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8667080", Offset = "0x8665680", VA = "0x188667080", Slot = "20")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x8666D40", Offset = "0x8665340", VA = "0x188666D40", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class LURIPPGUOHO
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public delegate bool TryTransformFunction<in TInput, TResult>(TInput input, [Out] TResult result);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class QAGBIURJVLH : FAHXEUAJZBB
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			private sealed class OAYCBGVAGNQ : AHOFSAAQNGI, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				public static readonly OAYCBGVAGNQ ZQTZABWNUIL;

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public bool WFQPOOLMCWV
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0x865FCA0", Offset = "0x865E2A0", VA = "0x18865FCA0", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x865FD00", Offset = "0x865E300", VA = "0x18865FD00", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
				public void NPEEMGAJFGV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public OAYCBGVAGNQ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly QAGBIURJVLH ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private QAGBIURJVLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x8660470", Offset = "0x865EA70", VA = "0x188660470", Slot = "4")]
			public AHOFSAAQNGI RKOJMYXYBOB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class BRXLGRCUBYW : FAHXEUAJZBB
		{
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			private sealed class CKHOXIZSUHL : AHOFSAAQNGI, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public static readonly CKHOXIZSUHL ZQTZABWNUIL;

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public bool WFQPOOLMCWV
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0x865AC40", Offset = "0x8659240", VA = "0x18865AC40", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x865AC60", Offset = "0x8659260", VA = "0x18865AC60", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
				public void NPEEMGAJFGV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
				public CKHOXIZSUHL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly BRXLGRCUBYW ZQTZABWNUIL;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			private BRXLGRCUBYW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x865AA70", Offset = "0x8659070", VA = "0x18865AA70", Slot = "4")]
			public AHOFSAAQNGI RKOJMYXYBOB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class SMRBQCSNRGN<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public TaskCompletionSource<a> HFPKDTPTZNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public CancellationToken YBWQEIOLJEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public CancellationTokenRegistration YZJSZFUOCIR;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public SMRBQCSNRGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x511D4F0", Offset = "0x511BAF0", VA = "0x18511D4F0")]
			internal void OYPPBLGMPDX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x5F868C0", Offset = "0x5F84EC0", VA = "0x185F868C0")]
			internal void OYKIEEMPFSO(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class BUHEGFXHPGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public TaskCompletionSource<None> DJPZNQAOSXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int NFXULRMBSCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Action<Task> LGWPYJTLUNX;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public BUHEGFXHPGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x865AB30", Offset = "0x8659130", VA = "0x18865AB30")]
			internal void BENVBZMLQQR(Task a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class EEKHYSGFUFU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Func<bool> APDLYOERAOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public TimeSpan FZQVVTUFSOW;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public EEKHYSGFUFU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x865B2B0", Offset = "0x86598B0", VA = "0x18865B2B0")]
			internal Task BUTVWJOXKQS(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class LAZVWXPPIEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Func<bool> APDLYOERAOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public TimeSpan FZQVVTUFSOW;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public LAZVWXPPIEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x865C5A0", Offset = "0x865ABA0", VA = "0x18865C5A0")]
			internal Task IUIXHINOMVB(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class HGOUKDFWUVK<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public TaskCompletionSource<a> DJPZNQAOSXE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken YABTGEYHGAN;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public HGOUKDFWUVK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x511D450", Offset = "0x511BA50", VA = "0x18511D450")]
			internal void BOSFZVKYOVZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class OXPFOIQDGVF<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public CancellationTokenRegistration YZJSZFUOCIR;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OXPFOIQDGVF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5BD82C0", Offset = "0x5BD68C0", VA = "0x185BD82C0")]
			internal void BOMZCORBFKQ(Task<a> a)
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
			[Cpp2IlInjected.Address(RVA = "0x8661280", Offset = "0x865F880", VA = "0x188661280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x8661410", Offset = "0x865FA10", VA = "0x188661410", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8661590", Offset = "0x865FB90", VA = "0x188661590", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8661480", Offset = "0x865FA80", VA = "0x188661480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xB06220", Offset = "0xB04820", VA = "0x180B06220", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x50F7320", Offset = "0x50F5920", VA = "0x1850F7320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x50F7490", Offset = "0x50F5A90", VA = "0x1850F7490", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x51FDCE0", Offset = "0x51FC2E0", VA = "0x1851FDCE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x51FE650", Offset = "0x51FCC50", VA = "0x1851FE650", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x51FE7C0", Offset = "0x51FCDC0", VA = "0x1851FE7C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x51FF520", Offset = "0x51FDB20", VA = "0x1851FF520", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86616F0", Offset = "0x865FCF0", VA = "0x1886616F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8661970", Offset = "0x865FF70", VA = "0x188661970", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86619D0", Offset = "0x865FFD0", VA = "0x1886619D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8661BE0", Offset = "0x86601E0", VA = "0x188661BE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8661C50", Offset = "0x8660250", VA = "0x188661C50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x8661F80", Offset = "0x8660580", VA = "0x188661F80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8661FE0", Offset = "0x86605E0", VA = "0x188661FE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x86626F0", Offset = "0x8660CF0", VA = "0x1886626F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8662750", Offset = "0x8660D50", VA = "0x188662750", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x86628D0", Offset = "0x8660ED0", VA = "0x1886628D0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x54DC220", Offset = "0x54DA820", VA = "0x1854DC220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x54DC430", Offset = "0x54DAA30", VA = "0x1854DC430", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x54E70E0", Offset = "0x54E56E0", VA = "0x1854E70E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x54E7680", Offset = "0x54E5C80", VA = "0x1854E7680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86639A0", Offset = "0x8661FA0", VA = "0x1886639A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x8663B80", Offset = "0x8662180", VA = "0x188663B80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8663BE0", Offset = "0x86621E0", VA = "0x188663BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8663F40", Offset = "0x8662540", VA = "0x188663F40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8663FA0", Offset = "0x86625A0", VA = "0x188663FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x8664290", Offset = "0x8662890", VA = "0x188664290", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86642F0", Offset = "0x86628F0", VA = "0x1886642F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8664540", Offset = "0x8662B40", VA = "0x188664540", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x86645A0", Offset = "0x8662BA0", VA = "0x1886645A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8664AF0", Offset = "0x86630F0", VA = "0x188664AF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x556F960", Offset = "0x556DF60", VA = "0x18556F960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x5570860", Offset = "0x556EE60", VA = "0x185570860", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8664B50", Offset = "0x8663150", VA = "0x188664B50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8664DD0", Offset = "0x86633D0", VA = "0x188664DD0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5573A50", Offset = "0x5572050", VA = "0x185573A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4FECD50", Offset = "0x4FEB350", VA = "0x184FECD50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x55742A0", Offset = "0x55728A0", VA = "0x1855742A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x5575080", Offset = "0x5573680", VA = "0x185575080", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5575CA0", Offset = "0x55742A0", VA = "0x185575CA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x5576480", Offset = "0x5574A80", VA = "0x185576480", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8664E40", Offset = "0x8663440", VA = "0x188664E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8665020", Offset = "0x8663620", VA = "0x188665020", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8665080", Offset = "0x8663680", VA = "0x188665080", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x86653E0", Offset = "0x86639E0", VA = "0x1886653E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8665440", Offset = "0x8663A40", VA = "0x188665440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8665730", Offset = "0x8663D30", VA = "0x188665730", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8665790", Offset = "0x8663D90", VA = "0x188665790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x86659E0", Offset = "0x8663FE0", VA = "0x1886659E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static SynchronizationContext? MNIEYMOJOAP;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly TaskCompletionSource<None> AHSYWNQTNZT;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static Task BQZVCJEYOHL
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x865D1D0", Offset = "0x865B7D0", VA = "0x18865D1D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x865D090", Offset = "0x865B690", VA = "0x18865D090")]
		public static bool MMQFEUKOKQQ(this Task a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x865E100", Offset = "0x865C700", VA = "0x18865E100")]
		[AsyncStateMachine(typeof(<AsNone>d__3))]
		public static Task<None> WHVFOUXUDXY(this Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x39BDF80", Offset = "0x39BC580", VA = "0x1839BDF80")]
		public static Task<T> KCIZJXQBAWJ<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x865E780", Offset = "0x865CD80", VA = "0x18865E780")]
		public static Task YGEFWZOYAVR(this Task a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x39C2670", Offset = "0x39C0C70", VA = "0x1839C2670")]
		public static Task<TResult> YGEFWZOYAVR<TResult>(this Task<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x39C0510", Offset = "0x39BEB10", VA = "0x1839C0510")]
		public static TaskCompletionSource<TResult> YGEFWZOYAVR<TResult>(this TaskCompletionSource<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x865D240", Offset = "0x865B840", VA = "0x18865D240")]
		public static IDisposable? ONEQLYYPNGE(CancellationToken a, CancellationToken b, [Out] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x865DCB0", Offset = "0x865C2B0", VA = "0x18865DCB0")]
		[AsyncStateMachine(typeof(<FireAndForget>d__9))]
		public static void UPISPRNCUIU(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x865C920", Offset = "0x865AF20", VA = "0x18865C920")]
		[AsyncStateMachine(typeof(<FireAndForgetSilent>d__10))]
		public static void DSEQQRMEGIF(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x39BD9D0", Offset = "0x39BBFD0", VA = "0x1839BD9D0")]
		[AsyncStateMachine(typeof(<IgnoreException>d__11<>))]
		public static Task JEMWUEEPVDJ<TException>(this Task a) where TException : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x39BDCD0", Offset = "0x39BC2D0", VA = "0x1839BDCD0")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__15<>))]
		public static Task<T> JVFWPNNIJIM<T>(this Task<T> a, Log b, Func<Task<T>, string> c, bool d = false) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x39BDBE0", Offset = "0x39BC1E0", VA = "0x1839BDBE0")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__16<>))]
		public static Task<T> JVFWPNNIJIM<T>(this Task<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x865CD50", Offset = "0x865B350", VA = "0x18865CD50")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__17))]
		public static Task JVFWPNNIJIM(this Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x865D8D0", Offset = "0x865BED0", VA = "0x18865D8D0")]
		[AsyncStateMachine(typeof(<LogExceptions>d__18))]
		public static Task<TaskStatus> TNQWNDXOFXW(this Task? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x39BECB0", Offset = "0x39BD2B0", VA = "0x1839BECB0")]
		public static (Task<b?>?, Action<b?>?) TPXOMVMUMSB<b>([Optional] CancellationToken a)
		{
			return default((Task<b>, Action<b>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x39BE170", Offset = "0x39BC770", VA = "0x1839BE170")]
		[AsyncStateMachine(typeof(<TryTransformList>d__24<, >))]
		public static Task<List<TResult>> KECUUSUWVJR<TResult, TInput>(this Task<List<TInput>> a, TryTransformFunction<TInput, TResult> b) where TResult : notnull where TInput : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x865CC20", Offset = "0x865B220", VA = "0x18865CC20")]
		[AsyncStateMachine(typeof(<RunWhile>d__25))]
		public static Task JTGBSPPACPI(Task a, CancellationToken b, Func<CancellationToken, Task> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x865DD60", Offset = "0x865C360", VA = "0x18865DD60")]
		[AsyncStateMachine(typeof(<WaitAsync>d__26))]
		public static Task VCXBYHKWDNV(Func<CancellationToken, Task> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x39BF460", Offset = "0x39BDA60", VA = "0x1839BF460")]
		[AsyncStateMachine(typeof(<WaitAsync>d__27<>))]
		public static Task<T> VCXBYHKWDNV<T>(Func<CancellationToken, Task<T>> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Func<OperationCanceledException, T>? handleTimeout) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x865E1F0", Offset = "0x865C7F0", VA = "0x18865E1F0")]
		public static Task WVARWDVJEGB(params Task[] tasks)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x865E240", Offset = "0x865C840", VA = "0x18865E240")]
		public static Task WVARWDVJEGB(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x865D490", Offset = "0x865BA90", VA = "0x18865D490")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__30))]
		public static Task<IEnumerable<Task>> RHXNLVFGKTI(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x39BE460", Offset = "0x39BCA60", VA = "0x1839BE460")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__32<>))]
		public static Task<IEnumerable<Task<T>>> RHXNLVFGKTI<T>(IEnumerable<Task<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x39BE950", Offset = "0x39BCF50", VA = "0x1839BE950")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__34<, , >))]
		public static Task<(T1, T2, T3)> SSCBKKFHHZP<T1, T2, T3>(Task<T1> a, Task<T2> b, Task<T3> c) where T1 : notnull where T2 : notnull where T3 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x39BE800", Offset = "0x39BCE00", VA = "0x1839BE800")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__36<, , , , >))]
		public static Task<(T1, T2, T3, T4, T5)> SSCBKKFHHZP<T1, T2, T3, T4, T5>(Task<T1> a, Task<T2> b, Task<T3> c, Task<T4> d, Task<T5> e) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x865DAB0", Offset = "0x865C0B0", VA = "0x18865DAB0")]
		[AsyncStateMachine(typeof(<While>d__38))]
		public static Task UAJSSHLBICR(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x865DBA0", Offset = "0x865C1A0", VA = "0x18865DBA0")]
		[AsyncStateMachine(typeof(<While>d__39))]
		public static Task UAJSSHLBICR(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x865DE90", Offset = "0x865C490", VA = "0x18865DE90")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__41))]
		public static Task VYBXBTXOZPS(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x865DFC0", Offset = "0x865C5C0", VA = "0x18865DFC0")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__42))]
		public static Task VYBXBTXOZPS(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x865CAE0", Offset = "0x865B0E0", VA = "0x18865CAE0")]
		[AsyncStateMachine(typeof(<Until>d__44))]
		public static Task ENEPBFDQXAU(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x865C9D0", Offset = "0x865AFD0", VA = "0x18865C9D0")]
		[AsyncStateMachine(typeof(<Until>d__45))]
		public static Task ENEPBFDQXAU(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x865CF60", Offset = "0x865B560", VA = "0x18865CF60")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__47))]
		public static Task LVYGDPIGASH(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x865CE20", Offset = "0x865B420", VA = "0x18865CE20")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__48))]
		public static Task LVYGDPIGASH(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x865D9C0", Offset = "0x865BFC0", VA = "0x18865D9C0")]
		[AsyncStateMachine(typeof(<Then>d__50))]
		[Obsolete]
		public static Task Then(this Task task, Action then)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x39BEFC0", Offset = "0x39BD5C0", VA = "0x1839BEFC0")]
		[AsyncStateMachine(typeof(<Then>d__51<>))]
		[Obsolete]
		public static Task Then<T>(this Task<T> task, Action<T> then) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x865E6E0", Offset = "0x865CCE0", VA = "0x18865E6E0")]
		private static void XDWFMAEOVTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x865D590", Offset = "0x865BB90", VA = "0x18865D590")]
		public static bool SKPPOYMKURU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x865C610", Offset = "0x865AC10", VA = "0x18865C610")]
		private static void BDPZMTJOLBA(SynchronizationContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x865D0C0", Offset = "0x865B6C0", VA = "0x18865D0C0")]
		private static void NHMUDDLVEAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x865D3D0", Offset = "0x865B9D0", VA = "0x18865D3D0")]
		public static void QZXCUADONKN([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x865C780", Offset = "0x865AD80", VA = "0x18865C780")]
		public static void BDUAKYRZNTW([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x865CBD0", Offset = "0x865B1D0", VA = "0x18865CBD0")]
		public static FAHXEUAJZBB FNLYLYYSRYN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x865C8D0", Offset = "0x865AED0", VA = "0x18865C8D0")]
		public static FAHXEUAJZBB DIWZFEDDZPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x865C800", Offset = "0x865AE00", VA = "0x18865C800")]
		[AsyncStateMachine(typeof(<RunOnMainThread>d__68))]
		public static Task CMNKBYAAOON(Func<Task> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class TestedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public TestedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class OBGOFBQZGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x865FEC0", Offset = "0x865E4C0", VA = "0x18865FEC0")]
		public static bool OEYMOQQPIGU(this PINCEDMLUMT a, DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x865FFE0", Offset = "0x865E5E0", VA = "0x18865FFE0")]
		public static TimeSpan RMRVATVOOAL(this PINCEDMLUMT a, DateTime b)
		{
			return default(TimeSpan);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class VUGGNXINHGN : PINCEDMLUMT
	{
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public static readonly PINCEDMLUMT ZQTZABWNUIL;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DateTime LAIVTWAORMC
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8666460", Offset = "0x8664A60", VA = "0x188666460", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DateTimeOffset VUVZTIJNPFD
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x8666400", Offset = "0x8664A00", VA = "0x188666400", Slot = "5")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public VUGGNXINHGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public interface PINCEDMLUMT
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		DateTime LAIVTWAORMC
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		DateTimeOffset VUVZTIJNPFD
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public static class TALFQHOFRUJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static long UNQACOULYVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x8660C40", Offset = "0x865F240", VA = "0x188660C40")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static long JEOKEXIZJHC
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x8660BF0", Offset = "0x865F1F0", VA = "0x188660BF0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static double EBOZXOKUOMZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x8660AE0", Offset = "0x865F0E0", VA = "0x188660AE0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static double WJJBWZYVQWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x8660BA0", Offset = "0x865F1A0", VA = "0x188660BA0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static double GNLQMXXZILW
		{
			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x8660A00", Offset = "0x865F000", VA = "0x188660A00")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static double WABPEYZRXFR
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x8660D60", Offset = "0x865F360", VA = "0x188660D60")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x8660DB0", Offset = "0x865F3B0", VA = "0x188660DB0")]
		public static double YBPHJUQNNMF(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8660A50", Offset = "0x865F050", VA = "0x188660A50")]
		public static double ERIYCWGHRKE(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x86608E0", Offset = "0x865EEE0", VA = "0x1886608E0")]
		public static double BOUQAZFFAJZ(double a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x8660970", Offset = "0x865EF70", VA = "0x188660970")]
		public static long BZAHERMZAKC(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x8660B30", Offset = "0x865F130", VA = "0x188660B30")]
		public static long MBABWLXMXKU(long a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x8660C90", Offset = "0x865F290", VA = "0x188660C90")]
		public static double UQPKEKERXAE(long a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x8660B40", Offset = "0x865F140", VA = "0x188660B40")]
		public static double QEMCVVLSKYV(long a, long b)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public sealed class FHNEGXVPSMJ : EOCPOTBZUFG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly TimeSpan WWBCJLWJRTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly System.Timers.Timer TYIPCZXJUDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private TimeSpan UYBCAYAIRSD;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TimeSpan VWJSEOXYZGL
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x865BC80", Offset = "0x865A280", VA = "0x18865BC80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Action? FXOASWOYLAY
		{
			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAAB6B0", Offset = "0xAA9CB0", VA = "0x180AAB6B0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0xAAA9C0", Offset = "0xAA8FC0", VA = "0x180AAA9C0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x865C280", Offset = "0x865A880", VA = "0x18865C280")]
		[Preserve]
		public FHNEGXVPSMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x865C040", Offset = "0x865A640", VA = "0x18865C040")]
		public FHNEGXVPSMJ(TimeSpan a, [Optional] Action? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x865BF10", Offset = "0x865A510", VA = "0x18865BF10", Slot = "7")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x865BC10", Offset = "0x865A210", VA = "0x18865BC10", Slot = "8")]
		public void ACIZBOKVNGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x865BFA0", Offset = "0x865A5A0", VA = "0x18865BFA0", Slot = "9")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x13B5900", Offset = "0x13B3F00", VA = "0x1813B5900")]
		private void ZPOPYEUDDWO(object a, ElapsedEventArgs b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x865BE80", Offset = "0x865A480", VA = "0x18865BE80")]
		private static void QXLZFKNMFFN(TimeSpan a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x865BDE0", Offset = "0x865A3E0", VA = "0x18865BDE0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x1A09160", Offset = "0x1A07760", VA = "0x181A09160")]
		public TodoAttribute(string description)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5764350", Offset = "0x5762950", VA = "0x185764350")]
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
		[Cpp2IlInjected.Address(RVA = "0x21E9A20", Offset = "0x21E8020", VA = "0x1821E9A20")]
		public static Union32 PICBDERKEAK(uint a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x21E9A20", Offset = "0x21E8020", VA = "0x1821E9A20")]
		public static Union32 OZCUGJWZWVE(int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x8665AF0", Offset = "0x86640F0", VA = "0x188665AF0")]
		public static Union32 NLFRBJEZLWL(float a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x8665AD0", Offset = "0x86640D0", VA = "0x188665AD0")]
		public static Union32 MSUIBCHAJBP(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x8665AD0", Offset = "0x86640D0", VA = "0x188665AD0")]
		public static Union32 HBSRDTJEUCU(bool a, bool b, bool c, bool d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x8665AD0", Offset = "0x86640D0", VA = "0x188665AD0")]
		public static Union32 GYRCUFMXNQX(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x2542530", Offset = "0x2540B30", VA = "0x182542530")]
		public static bool HCJGUXGANNO(Union32 a, Union32 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x2542510", Offset = "0x2540B10", VA = "0x182542510", Slot = "4")]
		public bool Equals(Union32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x8665A40", Offset = "0x8664040", VA = "0x188665A40", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x163ED10", Offset = "0x163D310", VA = "0x18163ED10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x8665B00", Offset = "0x8664100", VA = "0x188665B00", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static Union64 New(long i64)
		{
			return default(Union64);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x86661C0", Offset = "0x86647C0", VA = "0x1886661C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x323FDB0", Offset = "0x323E3B0", VA = "0x18323FDB0")]
		public static Union8 MSUIBCHAJBP(byte a)
		{
			return default(Union8);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x323FDB0", Offset = "0x323E3B0", VA = "0x18323FDB0")]
		public static Union8 HBSRDTJEUCU(bool a)
		{
			return default(Union8);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x86662B0", Offset = "0x86648B0", VA = "0x1886662B0")]
		public static bool HCJGUXGANNO(Union8 a, Union8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x7572570", Offset = "0x7570B70", VA = "0x187572570", Slot = "4")]
		public bool Equals(Union8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x8666210", Offset = "0x8664810", VA = "0x188666210", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x86662A0", Offset = "0x86648A0", VA = "0x1886662A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x86662C0", Offset = "0x86648C0", VA = "0x1886662C0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D1CE0", Offset = "0x63D02E0", VA = "0x1863D1CE0")]
		public UnreachableCaseException(T @case)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public static class EQZBFVZFLTS
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x37F7CE0", Offset = "0x37F62E0", VA = "0x1837F7CE0")]
		public static IEnumerable<T> PCKZKKPYSBN<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static T[] KBHHZWUJIIX<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0xE6A110", Offset = "0xE68710", VA = "0x180E6A110")]
		public static IEnumerable<T> USVOIINBLUI<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x37F7290", Offset = "0x37F5890", VA = "0x1837F7290")]
		public static HashSet<T> GQYBZJWXJFM<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x37F7DE0", Offset = "0x37F63E0", VA = "0x1837F7DE0")]
		public static KeyValuePair<TKey, TValue> THYTSNXKPCC<TKey, TValue>([In] TKey key, [In] TValue value) where TKey : notnull where TValue : notnull
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x37F7D70", Offset = "0x37F6370", VA = "0x1837F7D70")]
		public static List<T> RPRKUVRMJMG<T>(IEnumerable<T> a) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xAD0950", Offset = "0xACEF50", VA = "0x180AD0950")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
		public ContiguousZeroIndexedEnumAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public static class XFSHNAWVDXJ
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
			[Cpp2IlInjected.Address(RVA = "0x8662930", Offset = "0x8660F30", VA = "0x188662930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x8663200", Offset = "0x8661800", VA = "0x188663200", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private static readonly TimerCallback XJAFVCDFIOW;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private static readonly Action<object?> FQAEISOHOVD;

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x8666510", Offset = "0x8664B10", VA = "0x188666510")]
		public static Task<bool> EAHCIKKMPWR(int a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8666800", Offset = "0x8664E00", VA = "0x188666800")]
		[AsyncStateMachine(typeof(<TimerDelay>d__2))]
		private static Task<bool> GVIEXPPDJEY(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x86669C0", Offset = "0x8664FC0", VA = "0x1886669C0")]
		private static void TVRLQZNJTPZ(object? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8666930", Offset = "0x8664F30", VA = "0x188666930")]
		private static void HTLXLWFPKWC(object? a)
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
