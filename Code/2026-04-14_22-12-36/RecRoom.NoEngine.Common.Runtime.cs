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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x99A3E80", Offset = "0x99A2A80", VA = "0x1899A3E80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace System.Text
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class QTRGYTVIMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99A4CC0", Offset = "0x99A38C0", VA = "0x1899A4CC0")]
		public static string QGOSMAICKCR(this Encoding a, [In] ReadOnlySequence<byte> bytes)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3E3B250", Offset = "0x3E39E50", VA = "0x183E3B250")]
		private static void KJYFZYKGIXM<a>(this ReadOnlySequence<a> sequence, [Out] ReadOnlySpan<a> firstSpan, [Out] SequencePosition a)
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
		[Cpp2IlInjected.Address(RVA = "0x99A33D0", Offset = "0x99A1FD0", VA = "0x1899A33D0")]
		public MemberNotNullWhenAttribute(bool returnValue, string member)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99A3480", Offset = "0x99A2080", VA = "0x1899A3480")]
		public MemberNotNullWhenAttribute(bool returnValue, params string[] members)
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class MBGOYJQBTCR
	{
	}
}
namespace RecRoom.DebugStats
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface GECDSUKCEGL
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		bool PSWKWARYWUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PDOCYDNDTJN(string a, double b, [Optional] string? unit);
	}
}
namespace RecRoom.Analytics
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class QFBKXOQNDNP : VNXKEVOHAEN, JFZOSJBHMXB, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public int SVGPWRKANUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly Queue<double> TRNURIIPECU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private double VEKCGCAQCWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private double TFAKMWKVCBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private double RFINXMTTFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private int XDOYXQCNSCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private double NZFFPYBYDTU;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int AROBBGQPYUP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1DB90", VA = "0x180D1EF90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public double HFKQHVGGAGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x99A4BA0", Offset = "0x99A37A0", VA = "0x1899A4BA0", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public double LCEUZYBEGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8C40", Offset = "0x2AC7840", VA = "0x182AC8C40", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public double JCVDGSLJFSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x2AEC0E0", Offset = "0x2AEACE0", VA = "0x182AEC0E0", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99A4C00", Offset = "0x99A3800", VA = "0x1899A4C00")]
		public QFBKXOQNDNP(int a, double b = 0.0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99A4A00", Offset = "0x99A3600", VA = "0x1899A4A00", Slot = "7")]
		public void QARACVJFRCX(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99A4B30", Offset = "0x99A3730", VA = "0x1899A4B30", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99A4910", Offset = "0x99A3510", VA = "0x1899A4910", Slot = "9")]
		public object Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MNWNYXYIJAF : VNXKEVOHAEN, JFZOSJBHMXB, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private long YGGWGOVCADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private double XNADNVYARHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private double CSNDAOGLILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private double VPEJHVRFGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private double ODHDNUFZDSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private double VEKCGCAQCWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private double TFAKMWKVCBE;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public long LHDUJAQMHJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public double LCEUZYBEGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x62A6E10", Offset = "0x62A5A10", VA = "0x1862A6E10", Slot = "5")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public double JCVDGSLJFSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xE1D9D0", Offset = "0xE1C5D0", VA = "0x180E1D9D0", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public double WDONVYAHLUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xE1D9C0", Offset = "0xE1C5C0", VA = "0x180E1D9C0")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public double HFKQHVGGAGV
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2AC8E70", Offset = "0x2AC7A70", VA = "0x182AC8E70", Slot = "4")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99A27D0", Offset = "0x99A13D0", VA = "0x1899A27D0", Slot = "10")]
		public virtual void QARACVJFRCX(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99A28F0", Offset = "0x99A14F0", VA = "0x1899A28F0", Slot = "11")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99A2770", Offset = "0x99A1370", VA = "0x1899A2770", Slot = "9")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99A2930", Offset = "0x99A1530", VA = "0x1899A2930")]
		public MNWNYXYIJAF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class VVSXWXGUNLF : MNWNYXYIJAF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public double OKUWEQPTWZR
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xE1D9B0", Offset = "0xE1C5B0", VA = "0x180E1D9B0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8BBBFE0", Offset = "0x8BBABE0", VA = "0x188BBBFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99AC600", Offset = "0x99AB200", VA = "0x1899AC600", Slot = "10")]
		public override void QARACVJFRCX(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99AC730", Offset = "0x99AB330", VA = "0x1899AC730", Slot = "11")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99A2930", Offset = "0x99A1530", VA = "0x1899A2930")]
		public VVSXWXGUNLF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface VNXKEVOHAEN : JFZOSJBHMXB, ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		double HFKQHVGGAGV
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		double LCEUZYBEGOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		double JCVDGSLJFSO
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class HQHKNYTDLCI : JFZOSJBHMXB, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private double VHPWHTMCCOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private double FUVULRIBVOA;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public double YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x99A1640", Offset = "0x99A0240", VA = "0x1899A1640")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x869FB40", Offset = "0x869E740", VA = "0x18869FB40", Slot = "4")]
		public void QARACVJFRCX(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x99A1650", Offset = "0x99A0250", VA = "0x1899A1650", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99A15F0", Offset = "0x99A01F0", VA = "0x1899A15F0", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public HQHKNYTDLCI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JFZOSJBHMXB : ICloneable
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QARACVJFRCX(double a);

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Reset();
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class TLKQTPKYBWW : JFZOSJBHMXB, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private double BGRSASFVZVT;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public double YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x126FE20", Offset = "0x126EA20", VA = "0x18126FE20")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x703E030", Offset = "0x703CC30", VA = "0x18703E030", Slot = "4")]
		public void QARACVJFRCX(double a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99A52B0", Offset = "0x99A3EB0", VA = "0x1899A52B0", Slot = "5")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99A5260", Offset = "0x99A3E60", VA = "0x1899A5260", Slot = "6")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public TLKQTPKYBWW()
		{
		}
	}
}
namespace RecRoom.NoEngine.Common
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class BZUPDANYFEI<a> : IDisposable
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
			public BZUPDANYFEI<a> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x64E8830", Offset = "0x64E7430", VA = "0x1864E8830", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x64E9660", Offset = "0x64E8260", VA = "0x1864E9660", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly CancellationTokenSource YOMUJIVFYSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private CancellationTokenSource? ROKGGIJAUYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskCompletionSource<a>? MDBSXACLBEN;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4FBFFA0", Offset = "0x4FBEBA0", VA = "0x184FBFFA0")]
		[AsyncStateMachine(typeof(BZUPDANYFEI<>.<Debounce>d__4))]
		public Task<a> CWGIRFEZFSD(TaskGenerator taskGenerator, [Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4FC0210", Offset = "0x4FBEE10", VA = "0x184FC0210", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4FC02F0", Offset = "0x4FBEEF0", VA = "0x184FC02F0")]
		public BZUPDANYFEI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public sealed class Box<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private static readonly EqualityComparer<T> DZGONEZFMYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T YMGSSSXYISN;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x506D7F0", Offset = "0x506C3F0", VA = "0x18506D7F0")]
		public Box([In] T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x506C410", Offset = "0x506B010", VA = "0x18506C410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x506CAD0", Offset = "0x506B6D0", VA = "0x18506CAD0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x506CC30", Offset = "0x506B830", VA = "0x18506CC30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class Box
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x37CC230", Offset = "0x37CAE30", VA = "0x1837CC230")]
		public static Box<T> New<T>([In] T value) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class YQYGXPWGYWP
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x99ACA00", Offset = "0x99AB600", VA = "0x1899ACA00")]
		public static void MERQDPDHCZC(this CancellationTokenSource a, bool b = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AttributeUsage(AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false)]
	public class CS9FunctionPointerAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public CS9FunctionPointerAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Parameter, AllowMultiple = false)]
	public class CS9ImprovedNullableConstraints : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public CS9ImprovedNullableConstraints(string why)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class WSQWLPHGNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x41037C0", Offset = "0x41023C0", VA = "0x1841037C0")]
		public static LogString YGZGEIRUMBB<a>()
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99AC890", Offset = "0x99AB490", VA = "0x1899AC890")]
		public static LogString WZRVKMKBELZ([CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x41026E0", Offset = "0x41012E0", VA = "0x1841026E0")]
		public static LogString KGNJDXCQFAV<T>([CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4103750", Offset = "0x4102350", VA = "0x184103750")]
		public static LogString YGZGEIRUMBB<T>(this T a) where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x41027D0", Offset = "0x41013D0", VA = "0x1841027D0")]
		public static LogString KGNJDXCQFAV<T>(this T a, [CallerMemberName] string name = "") where T : notnull
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99AC810", Offset = "0x99AB410", VA = "0x1899AC810")]
		public static LogString KGNJDXCQFAV(string a, [CallerMemberName] string name = "")
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99AC770", Offset = "0x99AB370", VA = "0x1899AC770")]
		public static string CHXHDIHGCOC(this object a)
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
	public sealed class GACPKBCJAUP : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public static readonly GACPKBCJAUP UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public GACPKBCJAUP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class NEKLWBMBLKX
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static EngineShimState QOGHBLMXXVJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public static EngineShimState PXSFBRPZICU
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x99A36E0", Offset = "0x99A22E0", VA = "0x1899A36E0")]
			get
			{
				return default(EngineShimState);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public static LogDelegates AHTYWXIUQIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x99A3730", Offset = "0x99A2330", VA = "0x1899A3730")]
			get
			{
				return default(LogDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public static PerfScopeDelegates WVITLPPOANN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x99A34D0", Offset = "0x99A20D0", VA = "0x1899A34D0")]
			get
			{
				return default(PerfScopeDelegates);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public static bool DFWWJLKWOUX
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x99A3670", Offset = "0x99A2270", VA = "0x1899A3670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x99A3950", Offset = "0x99A2550", VA = "0x1899A3950")]
		public static void OYEDQDBHARD([In] EngineShimState engineShimState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x99A3880", Offset = "0x99A2480", VA = "0x1899A3880")]
		public static void Log(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x99A35A0", Offset = "0x99A21A0", VA = "0x1899A35A0")]
		public static void GODHZEQXDWE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3D2F250", Offset = "0x3D2DE50", VA = "0x183D2F250")]
		public static void GODHZEQXDWE<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x99A3C30", Offset = "0x99A2830", VA = "0x1899A3C30")]
		public static void WJTCZYAYMPV(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x99A3780", Offset = "0x99A2380", VA = "0x1899A3780")]
		public static void KVZPJDCULKS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x99A3CD0", Offset = "0x99A28D0", VA = "0x1899A3CD0")]
		public static void WKMGSMLRUSG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x99A3520", Offset = "0x99A2120", VA = "0x1899A3520")]
		public static string CHXHDIHGCOC(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x99A3BC0", Offset = "0x99A27C0", VA = "0x1899A3BC0")]
		public static long URYQMUXAZKV()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x99A37E0", Offset = "0x99A23E0", VA = "0x1899A37E0")]
		public static bool LNTMPLQJGUV(bool a, string b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x99A3AF0", Offset = "0x99A26F0", VA = "0x1899A3AF0")]
		public static double TVJDGCINNFE()
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
		public bool ZTVEKVOKXHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x99A0A80", Offset = "0x999F680", VA = "0x1899A0A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99A1300", Offset = "0x999FF00", VA = "0x1899A1300")]
		public EngineShimState([In] LogDelegates logDelegates, [In] PerfScopeDelegates perfScopeDelegates, ToDebugJsonDelegate toDebugJsonDelegate, GetOngoingTicksDelegate getOngoingTicksDelegate, FormatAsyncCallstackDelegate formatAsyncCallstackDelegate, GetIsQuittingDelegate getIsQuittingDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xEF6DE0", Offset = "0xEF59E0", VA = "0x180EF6DE0")]
		private static string EQQRJGLGZBH(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEEB40", VA = "0x180CEFF40")]
		private static long WZJJCPULGZM()
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0")]
		private static string AUEUVDADLLE(string a, string? prefix, bool b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		private static bool KQRZVZFLLOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x99A0C20", Offset = "0x999F820", VA = "0x1899A0C20")]
		private static EngineShimState MJUNZLSFHVN()
		{
			return default(EngineShimState);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface UBEBOZCAVGU<a> where a : notnull, KONMMJWHXTO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(Slot = "0")]
		a ZIWBNELVIQR();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public interface KONMMJWHXTO : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool SQVJFZTNKTD
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MVUJCEMZVBP();
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface OBLVMRVNUCX<a> where a : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool VPMCMGYWJAO([In] a other);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate void InAction<T>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public readonly struct IndexValuePair<T> : IEquatable<IndexValuePair<T>>, OBLVMRVNUCX<IndexValuePair<T>> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public readonly int Index;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x3136DA0", Offset = "0x31359A0", VA = "0x183136DA0")]
		public IndexValuePair([In] T value, int index)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x65DC7F0", Offset = "0x65DB3F0", VA = "0x1865DC7F0")]
		public static bool IQJYWSDTJLC([In] IndexValuePair<T> left, [In] IndexValuePair<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x65DB060", Offset = "0x65D9C60", VA = "0x1865DB060", Slot = "4")]
		public bool Equals(IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x65DAE90", Offset = "0x65D9A90", VA = "0x1865DAE90", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x65DED20", Offset = "0x65DD920", VA = "0x1865DED20")]
		public bool VPMCMGYWJAO([In] IndexValuePair<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x65DBA20", Offset = "0x65DA620", VA = "0x1865DBA20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x65DDFB0", Offset = "0x65DCBB0", VA = "0x1865DDFB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x65DA6F0", Offset = "0x65D92F0", VA = "0x1865DA6F0")]
		public void BXVWZDHELXS([Out] T a, [Out] int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x65DDAC0", Offset = "0x65DC6C0", VA = "0x1865DDAC0")]
		public (T, int) KFKRTLNWZNX()
		{
			return default((T, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x65DB550", Offset = "0x65DA150", VA = "0x1865DB550", Slot = "5")]
		private bool GRLZBYRUTYF([In] IndexValuePair<T> other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public static class TUGGFAQKAOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x3F5FA80", Offset = "0x3F5E680", VA = "0x183F5FA80")]
		public static IndexValuePair<T> New<T>([In] T value, int index) where T : notnull
		{
			return default(IndexValuePair<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public static class GVPUBJEQYWA
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x3ADC6E0", Offset = "0x3ADB2E0", VA = "0x183ADC6E0")]
		public static bool VPMCMGYWJAO<T, U>([In] T self, [In] U obj) where T : notnull, OBLVMRVNUCX<T> where U : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate TResult InFunc<T, out TResult>([In] T arg);
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public interface VIKWRACORBK : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000017")]
		TimeSpan PGDCYPIXPWD
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		Action? UEIKJOFUJYI
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
		void EAPMVKNDUEH();

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
		public bool ZTVEKVOKXHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x99A18E0", Offset = "0x99A04E0", VA = "0x1899A18E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xF03A30", Offset = "0xF02630", VA = "0x180F03A30")]
		public LogDelegates(ShouldLogDelegate shouldLogDelegate, LogDelegate logDelegate, ShouldLogDelegate shouldLogWarningDelegate, LogDelegate logWarningDelegate, ShouldLogDelegate shouldLogErrorDelegate, LogDelegate logErrorDelegate, LogExceptionDelegate logExceptionDelegate)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		private static bool LVHKVNCMDUI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void VVAFGLWDXKV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		private static bool ZYELKIRMQCM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void NSVQXMNEMUP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
		private static bool NRDYOSQKSIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void UMQOKWOUKUJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void ZDPWCVTHAVE(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x99A1C20", Offset = "0x99A0820", VA = "0x1899A1C20")]
		private static LogDelegates MJUNZLSFHVN()
		{
			return default(LogDelegates);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0")]
		private static bool PBQQQTFNJXW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x99A1BB0", Offset = "0x99A07B0", VA = "0x1899A1BB0")]
		public void Log(object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x99A1D60", Offset = "0x99A0960", VA = "0x1899A1D60")]
		public void NVJNDWKHFAC(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x99A1870", Offset = "0x99A0470", VA = "0x1899A1870")]
		public void GODHZEQXDWE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xF03850", Offset = "0xF02450", VA = "0x180F03850")]
		public void WJTCZYAYMPV(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x99A1790", Offset = "0x99A0390", VA = "0x1899A1790")]
		public void GODHZEQXDWE(MessageFunc a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3C14F70", Offset = "0x3C13B70", VA = "0x183C14F70")]
		public void GODHZEQXDWE<T>(T a, FastMessageFunc<T> b) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3C15300", Offset = "0x3C13F00", VA = "0x183C15300")]
		public void Log<T>([In] T arg, FastestMessageFunc<T> message) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3C15240", Offset = "0x3C13E40", VA = "0x183C15240")]
		public void GODHZEQXDWE<T>([In] T arg, FastestMessageFunc<T> a) where T : notnull
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99A1AE0", Offset = "0x99A06E0", VA = "0x1899A1AE0")]
		public bool LNTMPLQJGUV(bool a, string b)
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
		[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
		public LogString(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6C90", VA = "0x180EC8090")]
		public static implicit operator string([In] LogString self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x10CD690", Offset = "0x10CC290", VA = "0x1810CD690")]
		public static implicit operator LogString(string other)
		{
			return default(LogString);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x99A2720", Offset = "0x99A1320", VA = "0x1899A2720")]
		public string ZKZSZOIRUBG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x99A2640", Offset = "0x99A1240", VA = "0x1899A2640")]
		public string GJFDSWZTLHQ(object a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6C90", VA = "0x180EC8090", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public MustUseReturnValueAttribute()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public readonly struct None : IEquatable<None>
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD087A0", VA = "0x180D09BA0", Slot = "4")]
		public bool Equals(None other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x99A3DF0", Offset = "0x99A29F0", VA = "0x1899A3DF0", Slot = "0")]
		public override bool Equals(object other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x99A3E40", Offset = "0x99A2A40", VA = "0x1899A3E40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x99A3E50", Offset = "0x99A2A50", VA = "0x1899A3E50", Slot = "3")]
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
		public bool SSYDIZVHGNY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x2913140", Offset = "0x2911D40", VA = "0x182913140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x73C0EA0", Offset = "0x73BFAA0", VA = "0x1873C0EA0")]
		public Option([In] T value, bool isValid)
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x73BF930", Offset = "0x73BE530", VA = "0x1873BF930")]
		public static bool IQJYWSDTJLC([In] Option<T> left, [In] Option<T> right)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x73BDD10", Offset = "0x73BC910", VA = "0x1873BDD10", Slot = "4")]
		public bool Equals(Option<T> other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x73BE7C0", Offset = "0x73BD3C0", VA = "0x1873BE7C0", Slot = "0")]
		public override bool Equals(object? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x73BEF10", Offset = "0x73BDB10", VA = "0x1873BEF10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x73C0860", Offset = "0x73BF460", VA = "0x1873C0860", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public static class EQYPVZNRRMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x39339A0", Offset = "0x39325A0", VA = "0x1839339A0")]
		public static Option<T> NENGGABFUJG<T>([In] T value) where T : notnull
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x3933D20", Offset = "0x3932920", VA = "0x183933D20")]
		public static Option<T?> None<T>()
		{
			return default(Option<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x3934120", Offset = "0x3932D20", VA = "0x183934120")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x39340B0", Offset = "0x3932CB0", VA = "0x1839340B0")]
		public static bool Try<T>([In] this Option<T> opt, [Out][NotNullWhen(true)] T value, [Out] Option<T> res) where T : notnull
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3934150", Offset = "0x3932D50", VA = "0x183934150")]
		public static a? VXMNFMECVCA<a>([In] this Option<a> opt, a? a)
		{
			return (a?)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3933340", Offset = "0x3931F40", VA = "0x183933340")]
		public static bool JRYDGWZYVWI<T>([In] this Option<T> opt, T a) where T : notnull
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public static class ANRJMLLJEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x3366AB0", Offset = "0x33656B0", VA = "0x183366AB0")]
		public static a PMEOKIBLDLO<a>([In] this Option<a> opt) where a : class
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public static class ORFXAVKODPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x99A4540", Offset = "0x99A3140", VA = "0x1899A4540")]
		public static bool UEOBAQHNGDZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x99A4560", Offset = "0x99A3160", VA = "0x1899A4560")]
		public static bool XYVKLBIBXKQ(int a)
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
		public bool ZTVEKVOKXHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x99A4570", Offset = "0x99A3170", VA = "0x1899A4570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
		public PerfScopeDelegates(IntPtr beginPerfScope, IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void EPVHLNVCDTJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		private static void PURGZDZMRFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x99A4640", Offset = "0x99A3240", VA = "0x1899A4640")]
		private static PerfScopeDelegates MJUNZLSFHVN()
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
		[Cpp2IlInjected.Address(RVA = "0x13FFF50", Offset = "0x13FEB50", VA = "0x1813FFF50")]
		private PerfScopeToken(IntPtr endPerfScope)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x99A4820", Offset = "0x99A3420", VA = "0x1899A4820")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x99A4830", Offset = "0x99A3430", VA = "0x1899A4830")]
		public static PerfScopeToken New(string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x2B797B0", Offset = "0x2B783B0", VA = "0x182B797B0")]
		public static PerfScopeToken New([In] PerfScopeDelegates perfScopeDelegates, string name)
		{
			return default(PerfScopeToken);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x2B79530", Offset = "0x2B78130", VA = "0x182B79530")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public PreserveAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class EJAIJCPXWDW : SHA256
	{
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private static bool? DLDCIUUDJFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IntPtr PJUANHUSJRJ;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public static bool DKMMZPLDPUF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x99A09A0", Offset = "0x999F5A0", VA = "0x1899A09A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x99A0380", Offset = "0x999EF80", VA = "0x1899A0380")]
		public new static SHA256 Create()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x99A05F0", Offset = "0x999F1F0", VA = "0x1899A05F0")]
		private static extern int GetSHA256DigestSize();

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x99A0310", Offset = "0x999EF10", VA = "0x1899A0310")]
		private static extern IntPtr CreateSHA256();

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x99A0490", Offset = "0x999F090", VA = "0x1899A0490")]
		private static extern void DestroySHA256(IntPtr sha256);

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x99A08E0", Offset = "0x999F4E0", VA = "0x1899A08E0")]
		private static extern void UpdateSHA256Digest(IntPtr sha256, byte[] data, int offset, int dataLength);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x99A0550", Offset = "0x999F150", VA = "0x1899A0550")]
		private static extern void FinalSHA256Digest(IntPtr sha256, byte[] digest);

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x99A0A50", Offset = "0x999F650", VA = "0x1899A0A50")]
		private EJAIJCPXWDW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x99A0660", Offset = "0x999F260", VA = "0x1899A0660", Slot = "18")]
		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x99A0720", Offset = "0x999F320", VA = "0x1899A0720", Slot = "19")]
		protected override byte[] HashFinal()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x99A0850", Offset = "0x999F450", VA = "0x1899A0850", Slot = "20")]
		public override void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x99A0510", Offset = "0x999F110", VA = "0x1899A0510", Slot = "13")]
		protected override void Dispose(bool disposing)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class TZVERWFBMXG
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public delegate bool TryTransformFunction<in TInput, TResult>(TInput input, [Out] TResult result);

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		private sealed class EGHLZXOLGIZ : UBEBOZCAVGU<KONMMJWHXTO>
		{
			[Cpp2IlInjected.Token(Token = "0x2000037")]
			private sealed class AOYRZMTNZSS : KONMMJWHXTO, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				public static readonly AOYRZMTNZSS UXEDIFVFAQD;

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public bool SQVJFZTNKTD
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0x99A00A0", Offset = "0x999ECA0", VA = "0x1899A00A0", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x999FF40", Offset = "0x999EB40", VA = "0x18999FF40", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
				public void MVUJCEMZVBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000100")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public AOYRZMTNZSS()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly EGHLZXOLGIZ UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private EGHLZXOLGIZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x99A0250", Offset = "0x999EE50", VA = "0x1899A0250", Slot = "4")]
			public KONMMJWHXTO ZIWBNELVIQR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		private sealed class IBHFFOAMUVA : UBEBOZCAVGU<KONMMJWHXTO>
		{
			[Cpp2IlInjected.Token(Token = "0x200003A")]
			private sealed class CJQZCCIUKSN : KONMMJWHXTO, INotifyCompletion
			{
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				public static readonly CJQZCCIUKSN UXEDIFVFAQD;

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public bool SQVJFZTNKTD
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0x99A01C0", Offset = "0x999EDC0", VA = "0x1899A01C0", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000109")]
				[Cpp2IlInjected.Address(RVA = "0x99A0170", Offset = "0x999ED70", VA = "0x1899A0170", Slot = "6")]
				public void OnCompleted(Action continuation)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
				public void MVUJCEMZVBP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600010B")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public CJQZCCIUKSN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public static readonly IBHFFOAMUVA UXEDIFVFAQD;

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			private IBHFFOAMUVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x99A1660", Offset = "0x99A0260", VA = "0x1899A1660", Slot = "4")]
			public KONMMJWHXTO ZIWBNELVIQR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class OYIADEXPWFG<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public TaskCompletionSource<a> RPLADFBOMAS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public CancellationTokenRegistration PIELNWQDEPD;

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public OYIADEXPWFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x5148500", Offset = "0x5147100", VA = "0x185148500")]
			internal void SRSRUETYORX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x72CB400", Offset = "0x72CA000", VA = "0x1872CB400")]
			internal void SRNKWYABFGO(a a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class YPRJWODNIVX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public TaskCompletionSource<None> VRLFPLAXGXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public int IQMXZJHIABY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Action<Task> QKHJAEPTHFD;

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public YPRJWODNIVX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x99AC8F0", Offset = "0x99AB4F0", VA = "0x1899AC8F0")]
			internal void RSTBRECQEYR(Task a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class JBJVEBURCHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Func<bool> UUCAJYYDFMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public TimeSpan QLXFEPGOFVU;

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public JBJVEBURCHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x99A1720", Offset = "0x99A0320", VA = "0x1899A1720")]
			internal Task QHLROZEGHGC(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class ZAPEMMMEAEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Func<bool> UUCAJYYDFMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public TimeSpan QLXFEPGOFVU;

			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ZAPEMMMEAEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x99ACA30", Offset = "0x99AB630", VA = "0x1899ACA30")]
			internal Task YXXXJJZSIKH(CancellationToken a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000041")]
		[CompilerGenerated]
		private sealed class ZSPODLREJLS<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public TaskCompletionSource<a> VRLFPLAXGXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public CancellationToken NKJFKBMZQHX;

			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ZSPODLREJLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x5148370", Offset = "0x5146F70", VA = "0x185148370")]
			internal void UIKMYCKPXVV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private sealed class OKVCEQKDTTN<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public CancellationTokenRegistration PIELNWQDEPD;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public OKVCEQKDTTN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x5B32800", Offset = "0x5B31400", VA = "0x185B32800")]
			internal void UIFGAVQSOKM(Task<a> a)
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
			[Cpp2IlInjected.Address(RVA = "0x99A77A0", Offset = "0x99A63A0", VA = "0x1899A77A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A7690", Offset = "0x99A6290", VA = "0x1899A7690", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51830", VA = "0x180D52C30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x692CCD0", Offset = "0x692B8D0", VA = "0x18692CCD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x692CE40", Offset = "0x692BA40", VA = "0x18692CE40", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6942C20", Offset = "0x6941820", VA = "0x186942C20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6943670", Offset = "0x6942270", VA = "0x186943670", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A7900", Offset = "0x99A6500", VA = "0x1899A7900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x99A7B80", Offset = "0x99A6780", VA = "0x1899A7B80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A7BE0", Offset = "0x99A67E0", VA = "0x1899A7BE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x99A7DF0", Offset = "0x99A69F0", VA = "0x1899A7DF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A7E60", Offset = "0x99A6A60", VA = "0x1899A7E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x99A8190", Offset = "0x99A6D90", VA = "0x1899A8190", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A81F0", Offset = "0x99A6DF0", VA = "0x1899A81F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x99A8900", Offset = "0x99A7500", VA = "0x1899A8900", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A8960", Offset = "0x99A7560", VA = "0x1899A8960", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x99A8AE0", Offset = "0x99A76E0", VA = "0x1899A8AE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x705D6F0", Offset = "0x705C2F0", VA = "0x18705D6F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x705D9C0", Offset = "0x705C5C0", VA = "0x18705D9C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7061850", Offset = "0x7060450", VA = "0x187061850", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x41E29E0", Offset = "0x41E15E0", VA = "0x1841E29E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x70672D0", Offset = "0x7065ED0", VA = "0x1870672D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x7068300", Offset = "0x7066F00", VA = "0x187068300", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A9BA0", Offset = "0x99A87A0", VA = "0x1899A9BA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x99A9D80", Offset = "0x99A8980", VA = "0x1899A9D80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99A9DE0", Offset = "0x99A89E0", VA = "0x1899A9DE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x99AA140", Offset = "0x99A8D40", VA = "0x1899AA140", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AA1A0", Offset = "0x99A8DA0", VA = "0x1899AA1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x99AA490", Offset = "0x99A9090", VA = "0x1899AA490", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AA4F0", Offset = "0x99A90F0", VA = "0x1899AA4F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x99AA740", Offset = "0x99A9340", VA = "0x1899AA740", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AA7A0", Offset = "0x99A93A0", VA = "0x1899AA7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x99AACE0", Offset = "0x99A98E0", VA = "0x1899AACE0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x706DF80", Offset = "0x706CB80", VA = "0x18706DF80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x706E610", Offset = "0x706D210", VA = "0x18706E610", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AAD40", Offset = "0x99A9940", VA = "0x1899AAD40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x99AAFC0", Offset = "0x99A9BC0", VA = "0x1899AAFC0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7070950", Offset = "0x706F550", VA = "0x187070950", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x6649CF0", Offset = "0x66488F0", VA = "0x186649CF0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7071D80", Offset = "0x7070980", VA = "0x187071D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x7072230", Offset = "0x7070E30", VA = "0x187072230", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x7072F10", Offset = "0x7071B10", VA = "0x187072F10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x70736F0", Offset = "0x70722F0", VA = "0x1870736F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AB030", Offset = "0x99A9C30", VA = "0x1899AB030", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x99AB210", Offset = "0x99A9E10", VA = "0x1899AB210", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AB270", Offset = "0x99A9E70", VA = "0x1899AB270", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x99AB5E0", Offset = "0x99AA1E0", VA = "0x1899AB5E0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AB640", Offset = "0x99AA240", VA = "0x1899AB640", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x99AB930", Offset = "0x99AA530", VA = "0x1899AB930", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x99AB990", Offset = "0x99AA590", VA = "0x1899AB990", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x99ABBE0", Offset = "0x99AA7E0", VA = "0x1899ABBE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private static SynchronizationContext? TQZCZIMVHTF;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private static readonly TaskCompletionSource<None> HTNPPPGGXPP;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public static Task NQICLUHTHZD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x99A6130", Offset = "0x99A4D30", VA = "0x1899A6130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x99A6B60", Offset = "0x99A5760", VA = "0x1899A6B60")]
		public static bool TYCDJVIWLHO(this Task a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3F61C80", Offset = "0x3F60880", VA = "0x183F61C80")]
		public static Task<T> ENIQFPJFBNX<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x99A6910", Offset = "0x99A5510", VA = "0x1899A6910")]
		public static Task TBLDXHGYJIX(this Task a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3F65B10", Offset = "0x3F64710", VA = "0x183F65B10")]
		public static Task<TResult> TBLDXHGYJIX<TResult>(this Task<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3F63A30", Offset = "0x3F62630", VA = "0x183F63A30")]
		public static TaskCompletionSource<TResult> TBLDXHGYJIX<TResult>(this TaskCompletionSource<TResult> a, CancellationToken b) where TResult : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x99A5960", Offset = "0x99A4560", VA = "0x1899A5960")]
		public static IDisposable? FXULDSQAUEM(CancellationToken a, CancellationToken b, [Out] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x99A6080", Offset = "0x99A4C80", VA = "0x1899A6080")]
		[AsyncStateMachine(typeof(<FireAndForget>d__9))]
		public static void KRMTVXTGZYY(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x99A5E50", Offset = "0x99A4A50", VA = "0x1899A5E50")]
		[AsyncStateMachine(typeof(<FireAndForgetSilent>d__10))]
		public static void IJEBJXCVNON(this Task a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x3F62080", Offset = "0x3F60C80", VA = "0x183F62080")]
		[AsyncStateMachine(typeof(<IgnoreException>d__11<>))]
		public static Task FCJPVPLPMXN<TException>(this Task a) where TException : notnull, Exception
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x3F61740", Offset = "0x3F60340", VA = "0x183F61740")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__12<>))]
		public static Task<T> CUNTUFYLBUE<T>(this Task<T> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x99A56C0", Offset = "0x99A42C0", VA = "0x1899A56C0")]
		[AsyncStateMachine(typeof(<LogAndRethrowExceptions>d__13))]
		public static Task CUNTUFYLBUE(this Task a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x99A7170", Offset = "0x99A5D70", VA = "0x1899A7170")]
		[AsyncStateMachine(typeof(<LogExceptions>d__14))]
		public static Task<TaskStatus> WKFSGUSPHQU(this Task? self)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x3F62380", Offset = "0x3F60F80", VA = "0x183F62380")]
		public static (Task<b?>?, Action<b?>?) GJGLQNJKPEZ<b>([Optional] CancellationToken a)
		{
			return default((Task<b>, Action<b>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x3F682D0", Offset = "0x3F66ED0", VA = "0x183F682D0")]
		[AsyncStateMachine(typeof(<Transform>d__17<, >))]
		public static Task<TResult> Transform<TResult, TInput>(this Task<TInput> task, Func<TInput, TResult> transformation) where TResult : notnull where TInput : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x3F61640", Offset = "0x3F60240", VA = "0x183F61640")]
		[AsyncStateMachine(typeof(<TryTransformList>d__20<, >))]
		public static Task<List<TResult>> BYJUSIOJWNF<TResult, TInput>(this Task<List<TInput>> a, TryTransformFunction<TInput, TResult> b) where TResult : notnull where TInput : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x99A5F00", Offset = "0x99A4B00", VA = "0x1899A5F00")]
		[AsyncStateMachine(typeof(<RunWhile>d__21))]
		public static Task JYYQJXGBXHE(Task a, CancellationToken b, Func<CancellationToken, Task> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x99A6410", Offset = "0x99A5010", VA = "0x1899A6410")]
		[AsyncStateMachine(typeof(<WaitAsync>d__22))]
		public static Task OYHALJWZRAP(Func<CancellationToken, Task> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x3F62830", Offset = "0x3F61430", VA = "0x183F62830")]
		[AsyncStateMachine(typeof(<WaitAsync>d__23<>))]
		public static Task<T> OYHALJWZRAP<T>(Func<CancellationToken, Task<T>> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Func<OperationCanceledException, T>? handleTimeout) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x99A6C80", Offset = "0x99A5880", VA = "0x1899A6C80")]
		public static Task UMHCSNOMHYB(params Task[] tasks)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x99A6CD0", Offset = "0x99A58D0", VA = "0x1899A6CD0")]
		public static Task UMHCSNOMHYB(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x99A5790", Offset = "0x99A4390", VA = "0x1899A5790")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__26))]
		public static Task<IEnumerable<Task>> DEPKVTGFSVU(IEnumerable<Task> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F61B10", Offset = "0x3F60710", VA = "0x183F61B10")]
		[AsyncStateMachine(typeof(<WhenAllSafe>d__28<>))]
		public static Task<IEnumerable<Task<T>>> DEPKVTGFSVU<T>(IEnumerable<Task<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F687D0", Offset = "0x3F673D0", VA = "0x183F687D0")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__30<, , >))]
		public static Task<(T1, T2, T3)> YIUPURABWBL<T1, T2, T3>(Task<T1> a, Task<T2> b, Task<T3> c) where T1 : notnull where T2 : notnull where T3 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F68680", Offset = "0x3F67280", VA = "0x183F68680")]
		[AsyncStateMachine(typeof(<WhenAllTyped>d__32<, , , , >))]
		public static Task<(T1, T2, T3, T4, T5)> YIUPURABWBL<T1, T2, T3, T4, T5>(Task<T1> a, Task<T2> b, Task<T3> c, Task<T4> d, Task<T5> e) where T1 : notnull where T2 : notnull where T3 : notnull where T4 : notnull where T5 : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x99A6540", Offset = "0x99A5140", VA = "0x1899A6540")]
		[AsyncStateMachine(typeof(<While>d__34))]
		public static Task PIUJLUOHGMN(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x99A6630", Offset = "0x99A5230", VA = "0x1899A6630")]
		[AsyncStateMachine(typeof(<While>d__35))]
		public static Task PIUJLUOHGMN(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x99A5450", Offset = "0x99A4050", VA = "0x1899A5450")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__37))]
		public static Task CUBZOONHBHS(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x99A5580", Offset = "0x99A4180", VA = "0x1899A5580")]
		[AsyncStateMachine(typeof(<WhileWithTimeout>d__38))]
		public static Task CUBZOONHBHS(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x99A7420", Offset = "0x99A6020", VA = "0x1899A7420")]
		[AsyncStateMachine(typeof(<Until>d__40))]
		public static Task YOVFHKLTEEY(Func<bool> a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x99A7310", Offset = "0x99A5F10", VA = "0x1899A7310")]
		[AsyncStateMachine(typeof(<Until>d__41))]
		public static Task YOVFHKLTEEY(Func<bool> a, TimeSpan b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x99A61A0", Offset = "0x99A4DA0", VA = "0x1899A61A0")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__43))]
		public static Task OQHLXFODKHN(Func<bool> a, TimeSpan b, [Optional] CancellationToken c, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x99A62D0", Offset = "0x99A4ED0", VA = "0x1899A62D0")]
		[AsyncStateMachine(typeof(<UntilWithTimeout>d__44))]
		public static Task OQHLXFODKHN(Func<bool> a, TimeSpan b, TimeSpan c, [Optional] CancellationToken d, [Optional] Action<OperationCanceledException>? handleTimeout)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x99A6B90", Offset = "0x99A5790", VA = "0x1899A6B90")]
		[AsyncStateMachine(typeof(<Then>d__46))]
		[Obsolete]
		public static Task Then(this Task task, Action then)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x3F680D0", Offset = "0x3F66CD0", VA = "0x183F680D0")]
		[AsyncStateMachine(typeof(<Then>d__47<>))]
		[Obsolete]
		public static Task Then<T>(this Task<T> task, Action<T> then) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x99A7260", Offset = "0x99A5E60", VA = "0x1899A7260")]
		private static void XGQWCRPRBUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x99A5AF0", Offset = "0x99A46F0", VA = "0x1899A5AF0")]
		public static bool GXMKOGMFYRE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x99A6740", Offset = "0x99A5340", VA = "0x1899A6740")]
		private static void PXRORXISGDI(SynchronizationContext a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x99A5340", Offset = "0x99A3F40", VA = "0x1899A5340")]
		private static void ANCKVFVKHJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x99A7510", Offset = "0x99A6110", VA = "0x1899A7510")]
		public static void ZCPPZGSRGMV([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x99A52C0", Offset = "0x99A3EC0", VA = "0x1899A52C0")]
		public static void ADEAOSBNJDO([Optional] string? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x99A68C0", Offset = "0x99A54C0", VA = "0x1899A68C0")]
		public static UBEBOZCAVGU<KONMMJWHXTO> ROYFGZQKBAF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x99A6030", Offset = "0x99A4C30", VA = "0x1899A6030")]
		public static UBEBOZCAVGU<KONMMJWHXTO> KNUUDIXVUWE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x99A5890", Offset = "0x99A4490", VA = "0x1899A5890")]
		[AsyncStateMachine(typeof(<RunOnMainThread>d__64))]
		public static Task FDIKZSMAYVH(Func<Task> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
	public class TestedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public TestedAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class MWGVTOBNDIS
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x99A32B0", Offset = "0x99A1EB0", VA = "0x1899A32B0")]
		public static bool LOQGRLZKYQQ(this PBWCOHCUVUP a, DateTime b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x99A3190", Offset = "0x99A1D90", VA = "0x1899A3190")]
		public static TimeSpan KXNFKPTDNUX(this PBWCOHCUVUP a, DateTime b)
		{
			return default(TimeSpan);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public class HPHRDWZJJYZ : PBWCOHCUVUP
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public static readonly PBWCOHCUVUP UXEDIFVFAQD;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public DateTime OBRJHSTNJGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x99A1540", Offset = "0x99A0140", VA = "0x1899A1540", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public DateTimeOffset KHRRTDKJHXH
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x99A14E0", Offset = "0x99A00E0", VA = "0x1899A14E0", Slot = "5")]
			get
			{
				return default(DateTimeOffset);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		public HPHRDWZJJYZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public interface PBWCOHCUVUP
	{
		[Cpp2IlInjected.Token(Token = "0x17000022")]
		DateTime OBRJHSTNJGO
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		DateTimeOffset KHRRTDKJHXH
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public static class MRORHGWSUGZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public static long JHOLFNWKUCN
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x99A2AB0", Offset = "0x99A16B0", VA = "0x1899A2AB0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public static long MVOZYMMZBJW
		{
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x99A2BE0", Offset = "0x99A17E0", VA = "0x1899A2BE0")]
			[CompilerGenerated]
			get
			{
				return default(long);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public static double CXWYKUFXAON
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x99A2DE0", Offset = "0x99A19E0", VA = "0x1899A2DE0")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public static double RFCLDHIGSHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x99A2B90", Offset = "0x99A1790", VA = "0x1899A2B90")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public static double FGAGVIBRUIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x99A2D90", Offset = "0x99A1990", VA = "0x1899A2D90")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public static double MGZRGVTGOCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x99A2A00", Offset = "0x99A1600", VA = "0x1899A2A00")]
			[CompilerGenerated]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x99A2970", Offset = "0x99A1570", VA = "0x1899A2970")]
		public static double EGROWRMQDPP(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x99A2C30", Offset = "0x99A1830", VA = "0x1899A2C30")]
		public static double VGMTLWCHREI(long a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x99A2E30", Offset = "0x99A1A30", VA = "0x1899A2E30")]
		public static double ZSZYAMCOKGP(double a)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x99A2B00", Offset = "0x99A1700", VA = "0x1899A2B00")]
		public static long KANWRJIWMJM(long a)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x99A2960", Offset = "0x99A1560", VA = "0x1899A2960")]
		public static long BEABUNVSWAE(long a, long b)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x99A2CC0", Offset = "0x99A18C0", VA = "0x1899A2CC0")]
		public static double VHKQQBDQJPG(long a, long b)
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x99A2A50", Offset = "0x99A1650", VA = "0x1899A2A50")]
		public static double FAWJECNYYTH(long a, long b)
		{
			return default(double);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public sealed class ALSEGBSMPXH : VIKWRACORBK, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public static readonly TimeSpan SGXMSYHTPXG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly System.Timers.Timer IPAFJWBYNGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private TimeSpan ATGTGSTETVV;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public TimeSpan PGDCYPIXPWD
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "4")]
			get
			{
				return default(TimeSpan);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0x999F960", Offset = "0x999E560", VA = "0x18999F960", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public Action? UEIKJOFUJYI
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2FC0", VA = "0x180CF43C0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x999FED0", Offset = "0x999EAD0", VA = "0x18999FED0")]
		[Preserve]
		public ALSEGBSMPXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x999FC90", Offset = "0x999E890", VA = "0x18999FC90")]
		public ALSEGBSMPXH(TimeSpan a, [Optional] Action? b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x999FB60", Offset = "0x999E760", VA = "0x18999FB60", Slot = "7")]
		public void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x999F8F0", Offset = "0x999E4F0", VA = "0x18999F8F0", Slot = "8")]
		public void EAPMVKNDUEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x999FBF0", Offset = "0x999E7F0", VA = "0x18999FBF0", Slot = "9")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x135ABC0", Offset = "0x13597C0", VA = "0x18135ABC0")]
		private void AZDRJXQJVRA(object a, ElapsedEventArgs b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x999FAC0", Offset = "0x999E6C0", VA = "0x18999FAC0")]
		private static void SURZHLAXMKP(TimeSpan a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x999F850", Offset = "0x999E450", VA = "0x18999F850", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x91BA4E0", Offset = "0x91B90E0", VA = "0x1891BA4E0")]
		public TodoAttribute(string description)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x71D9360", Offset = "0x71D7F60", VA = "0x1871D9360")]
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
		[Cpp2IlInjected.Address(RVA = "0x1CDF450", Offset = "0x1CDE050", VA = "0x181CDF450")]
		public static Union32 RKJNAKPSCRA(uint a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1CDF450", Offset = "0x1CDE050", VA = "0x181CDF450")]
		public static Union32 WVIXCKVSHSO(int a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x99ABCF0", Offset = "0x99AA8F0", VA = "0x1899ABCF0")]
		public static Union32 PNXUQEYZFST(float a)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x99ABC40", Offset = "0x99AA840", VA = "0x1899ABC40")]
		public static Union32 GVSCYUWSOBD(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x99ABC40", Offset = "0x99AA840", VA = "0x1899ABC40")]
		public static Union32 AURWMVCTEQI(bool a, bool b, bool c, bool d)
		{
			return default(Union32);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x99ABC40", Offset = "0x99AA840", VA = "0x1899ABC40")]
		public static Union32 CYINDOFGKID(byte a, byte b, byte c, byte d)
		{
			return default(Union32);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x2382940", Offset = "0x2381540", VA = "0x182382940")]
		public static bool IQJYWSDTJLC(Union32 a, Union32 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x2382920", Offset = "0x2381520", VA = "0x182382920", Slot = "4")]
		public bool Equals(Union32 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x99ABC60", Offset = "0x99AA860", VA = "0x1899ABC60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x161A620", Offset = "0x1619220", VA = "0x18161A620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x99ABD00", Offset = "0x99AA900", VA = "0x1899ABD00", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0")]
		public static Union64 New(long i64)
		{
			return default(Union64);
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x99AC3C0", Offset = "0x99AAFC0", VA = "0x1899AC3C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x32C79F0", Offset = "0x32C65F0", VA = "0x1832C79F0")]
		public static Union8 GVSCYUWSOBD(byte a)
		{
			return default(Union8);
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x32C79F0", Offset = "0x32C65F0", VA = "0x1832C79F0")]
		public static Union8 AURWMVCTEQI(bool a)
		{
			return default(Union8);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x99AC4B0", Offset = "0x99AB0B0", VA = "0x1899AC4B0")]
		public static bool IQJYWSDTJLC(Union8 a, Union8 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x88AB9E0", Offset = "0x88AA5E0", VA = "0x1888AB9E0", Slot = "4")]
		public bool Equals(Union8 other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x99AC410", Offset = "0x99AB010", VA = "0x1899AC410", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x99AC4A0", Offset = "0x99AB0A0", VA = "0x1899AC4A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x99AC4C0", Offset = "0x99AB0C0", VA = "0x1899AC4C0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D65130", Offset = "0x7D63D30", VA = "0x187D65130")]
		public UnreachableCaseException(T @case)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public static class SFLOFCECTRG
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3F02B90", Offset = "0x3F01790", VA = "0x183F02B90")]
		public static IEnumerable<T> ACUMXMXTVYL<T>() where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0")]
		public static T[] QLPRAOVSUCD<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0xDF96B0", Offset = "0xDF82B0", VA = "0x180DF96B0")]
		public static IEnumerable<T> NVIIWIUAOBK<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x3F06170", Offset = "0x3F04D70", VA = "0x183F06170")]
		public static HashSet<T> YGYJEOBIWLM<T>(params T[] @params) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3F02C20", Offset = "0x3F01820", VA = "0x183F02C20")]
		public static KeyValuePair<TKey, TValue> BSXZAAKMGZI<TKey, TValue>([In] TKey key, [In] TValue value) where TKey : notnull where TValue : notnull
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3F046B0", Offset = "0x3F032B0", VA = "0x183F046B0")]
		public static List<T> GUUNWOKZIVA<T>(IEnumerable<T> a) where T : notnull
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
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public ContiguousZeroIndexedEnumAttribute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public static class OJCJGHAMGID
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
			[Cpp2IlInjected.Address(RVA = "0x99A8B40", Offset = "0x99A7740", VA = "0x1899A8B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x99A9400", Offset = "0x99A8000", VA = "0x1899A9400", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private static readonly TimerCallback NXKTYSYVWIC;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private static readonly Action<object?> FMABQYXJMJL;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x99A4030", Offset = "0x99A2C30", VA = "0x1899A4030")]
		public static Task<bool> JWJLAZQDAXT(int a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x99A3F00", Offset = "0x99A2B00", VA = "0x1899A3F00")]
		[AsyncStateMachine(typeof(<TimerDelay>d__2))]
		private static Task<bool> AFNWLPBXNNW(int a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x99A4330", Offset = "0x99A2F30", VA = "0x1899A4330")]
		private static void OYZRBDRNCWP(object? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x99A43C0", Offset = "0x99A2FC0", VA = "0x1899A43C0")]
		private static void SHIBVVYSFFQ(object? a)
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
