using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Cameras.Effects;
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
		[Cpp2IlInjected.Address(RVA = "0x7D3CA0", Offset = "0x7D2AA0", VA = "0x1807D3CA0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5F0B2C0", Offset = "0x5F0A0C0", VA = "0x185F0B2C0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D4330", Offset = "0x7D3130", VA = "0x1807D4330")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D3170", VA = "0x1807D4370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[AILBKAMKKLP]
public class LLDAOIJAFDE : PGDMLCJHKPC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum LGPHHCMFDFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		ShowingCamera,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		FadingToBlack,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		ShowingBlack,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		FadingToCamera
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BIAFFMEDGDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public LLDAOIJAFDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F06FA0", Offset = "0x5F05DA0", VA = "0x185F06FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5F073A0", Offset = "0x5F061A0", VA = "0x185F073A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class IBCEMIMMKGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IBCEMIMMKGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F08EA0", Offset = "0x5F07CA0", VA = "0x185F08EA0")]
		internal void EGLIEIKBFOE(LGPHHCMFDFO fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BNHCLCNLEMF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public LGPHHCMFDFO completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public LLDAOIJAFDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<MGNLHHJPKMI> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private IBCEMIMMKGI <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private object <animateInOutSuppressionToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private float <transitionStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private CancellationToken <cancellationToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float? <lastFadeSlope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private float <lerpTimeStart>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private float <lerpTimeEnd>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private float <lerpStartValue>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float <lerpEndValue>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F07400", Offset = "0x5F06200", VA = "0x185F07400", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F08140", Offset = "0x5F06F40", VA = "0x185F08140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NFJGNPFMCDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public LLDAOIJAFDE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F0AE50", Offset = "0x5F09C50", VA = "0x185F0AE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5F0B260", Offset = "0x5F0A060", VA = "0x185F0B260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class AHHOPLCJMNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TaskCompletionSource<LGPHHCMFDFO> tcs;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public AHHOPLCJMNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F069F0", Offset = "0x5F057F0", VA = "0x185F069F0")]
		internal void NBLPFFFOEFB()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DIFDMAPHFHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public ICollection<TaskCompletionSource<LGPHHCMFDFO>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private AHHOPLCJMNA <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<LGPHHCMFDFO> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F081A0", Offset = "0x5F06FA0", VA = "0x185F081A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F08810", Offset = "0x5F07610", VA = "0x185F08810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly AAJLDCICMNO JBLHPDDFMKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly EMGELIHJFAH PGJBIFCBPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly IEKKJHEMAIE FMJOMMKOKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly GJEPPGLMPJH OFAMNPBAICI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IALBADGNFIJ OALMGENFEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> BCDAEMHIPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BHFCLHOAKMF HPIHAAJFDEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BHFCLHOAKMF PIDLAMHCGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource CJPKDBDPPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken DNNFGDCDABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HPDNKHJABPG<EOHKIDCJHLO> KMMBHPCFPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object ANEGBDIGHDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object HLKFHKPGKAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<LGPHHCMFDFO>> GGJMJIGHFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<LGPHHCMFDFO>> DMFGJFCMMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private LGPHHCMFDFO MILIOGJCELE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool NNGPMJGFIJL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OJONEECCDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5F09CA0", Offset = "0x5F08AA0", VA = "0x185F09CA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HCIACCKLBFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5F0A130", Offset = "0x5F08F30", VA = "0x185F0A130", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ELINOIBFCLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F0A000", Offset = "0x5F08E00", VA = "0x185F0A000", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float NBJNCBMAIIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB669D0", Offset = "0xB657D0", VA = "0x180B669D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB669B0", Offset = "0xB657B0", VA = "0x180B669B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private LGPHHCMFDFO PHJHFHNKPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBB9390", Offset = "0xBB8190", VA = "0x180BB9390")]
		get
		{
			return default(LGPHHCMFDFO);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F09AB0", Offset = "0x5F088B0", VA = "0x185F09AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<LGPHHCMFDFO> HLIEDDINFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F09CC0", Offset = "0x5F08AC0", VA = "0x185F09CC0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F09BE0", Offset = "0x5F089E0", VA = "0x185F09BE0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5F0AB20", Offset = "0x5F09920", VA = "0x185F0AB20")]
	[Preserve]
	public LLDAOIJAFDE([LICAMFFCLCL(null)] AAJLDCICMNO JBLHPDDFMKF, [LICAMFFCLCL(null)] EMGELIHJFAH PGJBIFCBPBI, [LICAMFFCLCL(null)] IEKKJHEMAIE FMJOMMKOKGI, [LICAMFFCLCL("CameraFadeTimeoutDetector")] GJEPPGLMPJH OFAMNPBAICI, [LICAMFFCLCL(null)] IALBADGNFIJ OALMGENFEGL, [LICAMFFCLCL(null)] DANCBNPBEAB<CameraFadeOptions> BAPOGPMCDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5F0A470", Offset = "0x5F09270", VA = "0x185F0A470")]
	internal LLDAOIJAFDE(AAJLDCICMNO JBLHPDDFMKF, EMGELIHJFAH PGJBIFCBPBI, IEKKJHEMAIE FMJOMMKOKGI, GJEPPGLMPJH OFAMNPBAICI, IALBADGNFIJ OALMGENFEGL, DANCBNPBEAB<CameraFadeOptions> BAPOGPMCDNA, Func<Task>? BCDAEMHIPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5F093E0", Offset = "0x5F081E0", VA = "0x185F093E0", Slot = "8")]
	public NDMGEAOFJHB EBJFOFCGOJK(EOHKIDCJHLO NBGOKNOECBH, [Optional] FBFGLNHCDGM? LKLOMBJDOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5F0A010", Offset = "0x5F08E10", VA = "0x185F0A010", Slot = "9")]
	[AsyncStateMachine(typeof(BIAFFMEDGDB))]
	public Task LBCBLBMBCFL([Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5F09FB0", Offset = "0x5F08DB0", VA = "0x185F09FB0", Slot = "10")]
	public IReadOnlyCollection<EOHKIDCJHLO> KCKBKOAPJFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5F09010", Offset = "0x5F07E10", VA = "0x185F09010")]
	internal void BBGGMBBIIDD(EOHKIDCJHLO NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5F09A00", Offset = "0x5F08800", VA = "0x185F09A00")]
	private MGNLHHJPKMI FBAPFDNJKBM()
	{
		return default(MGNLHHJPKMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5F0A100", Offset = "0x5F08F00", VA = "0x185F0A100")]
	private MGNLHHJPKMI MHPJHPJEBHC()
	{
		return default(MGNLHHJPKMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5F0A2C0", Offset = "0x5F090C0", VA = "0x185F0A2C0")]
	internal void POCEHKDKKDD(EOHKIDCJHLO NBGOKNOECBH, FBFGLNHCDGM CCGPHIHLLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5F08ED0", Offset = "0x5F07CD0", VA = "0x185F08ED0")]
	private static void AKDIDPNGIMG(IReadOnlyList<TaskCompletionSource<LGPHHCMFDFO>> DOOBLNKCCNP, LGPHHCMFDFO JKBECCMMHFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5F0A140", Offset = "0x5F08F40", VA = "0x185F0A140")]
	private void PFFCDGJBAFI(float MJLLOKFEEDL, Func<MGNLHHJPKMI> MEFAEJBOHMP, LGPHHCMFDFO OLPGAICDFME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5F09A30", Offset = "0x5F08830", VA = "0x185F09A30")]
	private static bool FLJNFILHPMP(float GCMDJKOKHCO, float LGCDJBDIEJC, float BFLBMOAOEDJ = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5F09D80", Offset = "0x5F08B80", VA = "0x185F09D80")]
	[AsyncStateMachine(typeof(BNHCLCNLEMF))]
	private Task JBBFCLAKIEG(CancellationToken JPLHPFGGALJ, float MJLLOKFEEDL, Func<MGNLHHJPKMI> CNBCJHOJCLE, LGPHHCMFDFO OLPGAICDFME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5F09290", Offset = "0x5F08090", VA = "0x185F09290")]
	private void CGEAHMFEEPF(float IPCAIOHOFEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5F09EC0", Offset = "0x5F08CC0", VA = "0x185F09EC0")]
	[AsyncStateMachine(typeof(NFJGNPFMCDG))]
	internal Task JHJNANFCBLK([Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5F09190", Offset = "0x5F07F90", VA = "0x185F09190")]
	[AsyncStateMachine(typeof(DIFDMAPHFHL))]
	private static Task BINDBCEMBID(ICollection<TaskCompletionSource<LGPHHCMFDFO>> DOOBLNKCCNP, CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5F093A0", Offset = "0x5F081A0", VA = "0x185F093A0", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class GNIKMBCEDEN : NDMGEAOFJHB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct HCNAELOKEAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public GNIKMBCEDEN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5F08BC0", Offset = "0x5F079C0", VA = "0x185F08BC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F08E40", Offset = "0x5F07C40", VA = "0x185F08E40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EHEIKHGHOCA HBMHGMCFMGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly LLDAOIJAFDE HHMBCOKEGOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly EOHKIDCJHLO NBGOKNOECBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private bool OADMEOKPNBL;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5F08B10", Offset = "0x5F07910", VA = "0x185F08B10")]
	internal GNIKMBCEDEN(LLDAOIJAFDE HHMBCOKEGOC, EOHKIDCJHLO NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5F08870", Offset = "0x5F07670", VA = "0x185F08870", Slot = "4")]
	[AsyncStateMachine(typeof(HCNAELOKEAA))]
	public Task AIKFKOMELHC([Optional] CancellationToken HHBHDBLGMFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5F08960", Offset = "0x5F07760", VA = "0x185F08960", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal readonly struct MGNLHHJPKMI : IEquatable<MGNLHHJPKMI>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly bool LJMMJFPBFAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly float OJACAJOANEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly float CNACBFEHNML;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5F0AD80", Offset = "0x5F09B80", VA = "0x185F0AD80")]
	public MGNLHHJPKMI(float HPGFGEEHPOP, float JABPPPAGBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5F0AC20", Offset = "0x5F09A20", VA = "0x185F0AC20", Slot = "4")]
	public bool Equals(MGNLHHJPKMI FPEEGIOMOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5F0AB70", Offset = "0x5F09970", VA = "0x185F0AB70", Slot = "0")]
	public override bool Equals(object? NHLNHJGAONN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5F0AC60", Offset = "0x5F09A60", VA = "0x185F0AC60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5F0ACE0", Offset = "0x5F09AE0", VA = "0x185F0ACE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class BHFCLHOAKMF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum DANOIKKAPJD : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly DANOIKKAPJD ILEGDIPPGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<object, MGNLHHJPKMI> BONMENBBDID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly MGNLHHJPKMI FDBAENIPAHE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public MGNLHHJPKMI DFPHMDCMPIO
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x92B3F0", Offset = "0x92A1F0", VA = "0x18092B3F0")]
		[CompilerGenerated]
		get
		{
			return default(MGNLHHJPKMI);
		}
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x92E570", Offset = "0x92D370", VA = "0x18092E570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5F06EE0", Offset = "0x5F05CE0", VA = "0x185F06EE0")]
	public BHFCLHOAKMF(DANOIKKAPJD ILEGDIPPGOJ, MGNLHHJPKMI FDBAENIPAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5F06AD0", Offset = "0x5F058D0", VA = "0x185F06AD0")]
	public void EBEJCNLIMLB(object NBGOKNOECBH, MGNLHHJPKMI FFBJHJAGKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x5F06E30", Offset = "0x5F05C30", VA = "0x185F06E30")]
	public void JJGPDDBMEBN(object NBGOKNOECBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5F06A80", Offset = "0x5F05880", VA = "0x185F06A80")]
	public void BBGCGJHDDBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5F06D90", Offset = "0x5F05B90", VA = "0x185F06D90")]
	private void JDIDPEICGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5F06A40", Offset = "0x5F05840", VA = "0x185F06A40")]
	private MGNLHHJPKMI ACHPPGGDBAB()
	{
		return default(MGNLHHJPKMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5F06EA0", Offset = "0x5F05CA0", VA = "0x185F06EA0")]
	private MGNLHHJPKMI MJBCAHMIBDJ()
	{
		return default(MGNLHHJPKMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5F06BF0", Offset = "0x5F059F0", VA = "0x185F06BF0")]
	private MGNLHHJPKMI HJOLBOBDOFO(int KGDMDGAPCCK)
	{
		return default(MGNLHHJPKMI);
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
