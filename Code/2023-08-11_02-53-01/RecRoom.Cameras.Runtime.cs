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
		[Cpp2IlInjected.Address(RVA = "0x7E01F0", Offset = "0x7DE9F0", VA = "0x1807E01F0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A360", Offset = "0x6E68B60", VA = "0x186E6A360")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7EEC40", Offset = "0x7ED440", VA = "0x1807EEC40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA14660", Offset = "0xA12E60", VA = "0x180A14660")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[ACFLGLMHDEN]
public class CCKNDLKAIDB : EIOFPFLBFKO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum DAMBPGOEAMG
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

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class IMOPLHKGMPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CCKNDLKAIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private CancellationTokenSource <tokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private CancellationToken <token>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public IMOPLHKGMPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6E69970", Offset = "0x6E68170", VA = "0x186E69970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class MGLGPLKHOFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MGLGPLKHOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A330", Offset = "0x6E68B30", VA = "0x186E6A330")]
		internal void NBGHFAEKOFM(DAMBPGOEAMG fadeState)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FJELDHEDKMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<IBJHFGBNLEP> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DAMBPGOEAMG completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CCKNDLKAIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private MGLGPLKHOFC <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private object <animateInOutSuppressionToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private float <transitionStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private CancellationToken <cancellationToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private float? <lastFadeSlope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private float <lerpTimeStart>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float <lerpTimeEnd>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float <lerpStartValue>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float <lerpEndValue>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private IBJHFGBNLEP <currentFadeRate>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float <now>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float <currentFade>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float <timeRemaining>5__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float <currentLerpSlopePerc>5__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float <newCurrentFade>5__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Exception <ex>5__16;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float <totalTime>5__17;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public FJELDHEDKMI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6E68900", Offset = "0x6E67100", VA = "0x186E68900", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class BCIKKNHJGBF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public CCKNDLKAIDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <tokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public BCIKKNHJGBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6E66300", Offset = "0x6E64B00", VA = "0x186E66300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class OHBKDMHFHML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public TaskCompletionSource<DAMBPGOEAMG> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public OHBKDMHFHML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A3F0", Offset = "0x6E68BF0", VA = "0x186E6A3F0")]
		internal void HOBDKGJBOBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DPLLCOLBIGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x712C00", Offset = "0x712000")]
		public ICollection<TaskCompletionSource<DAMBPGOEAMG>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private OHBKDMHFHML <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<DAMBPGOEAMG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public DPLLCOLBIGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E683B0", Offset = "0x6E66BB0", VA = "0x186E683B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly EEBAKACIHIC BIFEEIDJDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly MAEGNNDAMOK JDNODDHGBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LDOHJBCKEED FMKDNPLHJLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly IIGCLKAJIGA OFGDNIPJBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FIHDKPEAOBM AHBAIFGILLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> JDOHACEJKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly OMPGAJDCMAJ MPBFOOLOJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly OMPGAJDCMAJ GKFDOCGMMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource MPLOOJOOFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken EMHHMIAKMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NHLBAGGFEFP<NHDFEEHHMNM> CKCDFGBIIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object FCJJLPEGGIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object MFGAAICDEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<DAMBPGOEAMG>> DKCDBOMLNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<DAMBPGOEAMG>> KFLFMHNJDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DAMBPGOEAMG PMINJPMGLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool EGOOECJFAPD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool CEAMHAFEACK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6E66680", Offset = "0x6E64E80", VA = "0x186E66680", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NKKABAHOAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6E66D70", Offset = "0x6E65570", VA = "0x186E66D70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHCAMNDBJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E67D10", Offset = "0x6E66510", VA = "0x186E67D10", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float GOLAOOCFMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCC17E0", Offset = "0xCBFFE0", VA = "0x180CC17E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xCC17F0", Offset = "0xCBFFF0", VA = "0x180CC17F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DAMBPGOEAMG MLCPFJLJEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x90C2C0", Offset = "0x90AAC0", VA = "0x18090C2C0")]
		get
		{
			return default(DAMBPGOEAMG);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E66F30", Offset = "0x6E65730", VA = "0x186E66F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<DAMBPGOEAMG> NKEPNHHJIFF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E66870", Offset = "0x6E65070", VA = "0x186E66870")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E67900", Offset = "0x6E66100", VA = "0x186E67900")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E68360", Offset = "0x6E66B60", VA = "0x186E68360")]
	[Preserve]
	public CCKNDLKAIDB([JHPEMCNOMHI(null)] EEBAKACIHIC BIFEEIDJDII, [JHPEMCNOMHI(null)] MAEGNNDAMOK JDNODDHGBKM, [JHPEMCNOMHI(null)] LDOHJBCKEED FMKDNPLHJLH, [JHPEMCNOMHI("CameraFadeTimeoutDetector")] IIGCLKAJIGA OFGDNIPJBOF, [JHPEMCNOMHI(null)] FIHDKPEAOBM AHBAIFGILLP, [JHPEMCNOMHI(null)] PCOHLDANFPN<CameraFadeOptions> LFCKIHDGDIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E67D20", Offset = "0x6E66520", VA = "0x186E67D20")]
	internal CCKNDLKAIDB(EEBAKACIHIC BIFEEIDJDII, MAEGNNDAMOK JDNODDHGBKM, LDOHJBCKEED FMKDNPLHJLH, IIGCLKAJIGA OFGDNIPJBOF, FIHDKPEAOBM AHBAIFGILLP, PCOHLDANFPN<CameraFadeOptions> LFCKIHDGDIE, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x712900", Offset = "0x711D00")] Func<Task> JDOHACEJKCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E672E0", Offset = "0x6E65AE0", VA = "0x186E672E0", Slot = "8")]
	public LEPNKPNFGGL NGNELIDCOLK(NHDFEEHHMNM AMCDGOPKAOE, [Optional] EJEGGHOHHKH? PBKEKAHOLGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E67BC0", Offset = "0x6E663C0", VA = "0x186E67BC0", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(IMOPLHKGMPP))]
	public Task PGMMBAKKPLI([Optional] CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E66630", Offset = "0x6E64E30", VA = "0x186E66630", Slot = "10")]
	public IReadOnlyCollection<NHDFEEHHMNM> BKBOLCMFAAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E666A0", Offset = "0x6E64EA0", VA = "0x186E666A0")]
	internal void CIDGGKCOMGD(NHDFEEHHMNM AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E66B60", Offset = "0x6E65360", VA = "0x186E66B60")]
	private IBJHFGBNLEP GOKDCFDAILL()
	{
		return default(IBJHFGBNLEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E66D40", Offset = "0x6E65540", VA = "0x186E66D40")]
	private IBJHFGBNLEP GPCCJKKJPNM()
	{
		return default(IBJHFGBNLEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E67A20", Offset = "0x6E66220", VA = "0x186E67A20")]
	internal void OOJKHMADPLD(NHDFEEHHMNM AMCDGOPKAOE, EJEGGHOHHKH NHBOPECOACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E671B0", Offset = "0x6E659B0", VA = "0x186E671B0")]
	private static void NEDDBBIPJLC(IReadOnlyList<TaskCompletionSource<DAMBPGOEAMG>> ODNEFJIIGDL, DAMBPGOEAMG EIOCIPLIHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E66D80", Offset = "0x6E65580", VA = "0x186E66D80")]
	private void KGAIEFNHGKL(float GJOBDFOLBDB, Func<IBJHFGBNLEP> PCBKKOPKAPG, DAMBPGOEAMG JJFIAABIODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E679A0", Offset = "0x6E661A0", VA = "0x186E679A0")]
	private static bool ODKONKACBMM(float MBLAPCMEEGI, float NBEGIGNBOIE, float EIBOPJAJCMI = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E66B90", Offset = "0x6E65390", VA = "0x186E66B90")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FJELDHEDKMI))]
	private Task GOOCPIPOOPO(CancellationToken MAGFBIFMOHG, float GJOBDFOLBDB, Func<IBJHFGBNLEP> ALJCHJKAKJJ, DAMBPGOEAMG JJFIAABIODB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E66910", Offset = "0x6E65110", VA = "0x186E66910")]
	private void FBIGNNFEFIM(float ALBEDAJEMBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E67060", Offset = "0x6E65860", VA = "0x186E67060")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BCIKKNHJGBF))]
	internal Task MLPLOBBDIHO([Optional] CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E66A10", Offset = "0x6E65210", VA = "0x186E66A10")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPLLCOLBIGL))]
	private static Task FNKKDCHEELH(ICollection<TaskCompletionSource<DAMBPGOEAMG>> ODNEFJIIGDL, CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E66830", Offset = "0x6E65030", VA = "0x186E66830", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class KNPLJJGCDFD : LEPNKPNFGGL, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class MBPIGGLJFBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public KNPLJJGCDFD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public MBPIGGLJFBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A060", Offset = "0x6E68860", VA = "0x186E6A060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly IKEKIKHIMNF NHFFIGCGGFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly CCKNDLKAIDB GALIFFFIOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly NHDFEEHHMNM AMCDGOPKAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private bool DGDBOBKJJDN;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E69FB0", Offset = "0x6E687B0", VA = "0x186E69FB0")]
	internal KNPLJJGCDFD(CCKNDLKAIDB GALIFFFIOPB, NHDFEEHHMNM AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E69E60", Offset = "0x6E68660", VA = "0x186E69E60", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MBPIGGLJFBB))]
	public Task GGNLKAMBEPH([Optional] CancellationToken NNLBJPBEHPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E69CA0", Offset = "0x6E684A0", VA = "0x186E69CA0", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class OMPGAJDCMAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum CNDAKBFINNN : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly CNDAKBFINNN FHJHOEPHODM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Dictionary<object, IBJHFGBNLEP> LKOIDIOEALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly IBJHFGBNLEP OMIIICOJGGO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IBJHFGBNLEP PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x17D8390", Offset = "0x17D6B90", VA = "0x1817D8390")]
		[CompilerGenerated]
		get
		{
			return default(IBJHFGBNLEP);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x17D8440", Offset = "0x17D6C40", VA = "0x1817D8440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A900", Offset = "0x6E69100", VA = "0x186E6A900")]
	public OMPGAJDCMAJ(CNDAKBFINNN FHJHOEPHODM, IBJHFGBNLEP OMIIICOJGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A7E0", Offset = "0x6E68FE0", VA = "0x186E6A7E0")]
	public void OMMPPHKKJAF(object AMCDGOPKAOE, IBJHFGBNLEP KGHFFGDPHEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A690", Offset = "0x6E68E90", VA = "0x186E6A690")]
	public void FNJGHMKCCPI(object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A640", Offset = "0x6E68E40", VA = "0x186E6A640")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A700", Offset = "0x6E68F00", VA = "0x186E6A700")]
	private void HCDKIODCDAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A7A0", Offset = "0x6E68FA0", VA = "0x186E6A7A0")]
	private IBJHFGBNLEP JOAGOBLOBNH()
	{
		return default(IBJHFGBNLEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A440", Offset = "0x6E68C40", VA = "0x186E6A440")]
	private IBJHFGBNLEP BPCCJAPACPM()
	{
		return default(IBJHFGBNLEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A480", Offset = "0x6E68C80", VA = "0x186E6A480")]
	private IBJHFGBNLEP CJKACCPCFFH(int NGFLDKGCIOG)
	{
		return default(IBJHFGBNLEP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal readonly struct IBJHFGBNLEP : IEquatable<IBJHFGBNLEP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly bool HFCABELMBHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly float LAFNMGMJHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly float LHBLCKPCFIG;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E69890", Offset = "0x6E68090", VA = "0x186E69890")]
	public IBJHFGBNLEP(float JNCAFMFCJBD, float DBCGMGMJHMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E696B0", Offset = "0x6E67EB0", VA = "0x186E696B0", Slot = "4")]
	public bool Equals(IBJHFGBNLEP OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E696F0", Offset = "0x6E67EF0", VA = "0x186E696F0", Slot = "0")]
	public override bool Equals(object? CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E697A0", Offset = "0x6E67FA0", VA = "0x186E697A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E697F0", Offset = "0x6E67FF0", VA = "0x186E697F0", Slot = "3")]
	public override string ToString()
	{
		return null;
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
