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
		[Cpp2IlInjected.Address(RVA = "0x7E5080", Offset = "0x7E4280", VA = "0x1807E5080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EBCFD0", Offset = "0x6EBC1D0", VA = "0x186EBCFD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E3190", Offset = "0x7E2390", VA = "0x1807E3190")]
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
		[Cpp2IlInjected.Address(RVA = "0x17C7540", Offset = "0x17C6740", VA = "0x1817C7540")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[FDHBNKNBNCC]
public class JIDLGPAGJEJ : MLAIMLPDPAE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum DIHPBGLPHFK
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
	private sealed class LBMIEAAPFOK : IAsyncStateMachine
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
		public JIDLGPAGJEJ <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public LBMIEAAPFOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EBC750", Offset = "0x6EBB950", VA = "0x186EBC750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class OCJCOMKLGMK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OCJCOMKLGMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD060", Offset = "0x6EBC260", VA = "0x186EBD060")]
		internal void FEOBBAHIKCH(DIHPBGLPHFK fadeState)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OKANAGIKAII : IAsyncStateMachine
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
		public Func<GDCDCCLEKOB> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DIHPBGLPHFK completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public JIDLGPAGJEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private OCJCOMKLGMK <>8__1;

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
		private GDCDCCLEKOB <currentFadeRate>5__10;

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
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public OKANAGIKAII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6EBD090", Offset = "0x6EBC290", VA = "0x186EBD090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EFMBJIPEFGC : IAsyncStateMachine
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
		public JIDLGPAGJEJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <tokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public EFMBJIPEFGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9E70", Offset = "0x6EB9070", VA = "0x186EB9E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class CLBDHGNELEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public TaskCompletionSource<DIHPBGLPHFK> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CLBDHGNELEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9B50", Offset = "0x6EB8D50", VA = "0x186EB9B50")]
		internal void JGGLLEJMOMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class MIPDODDJDJL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716330", Offset = "0x715730")]
		public ICollection<TaskCompletionSource<DIHPBGLPHFK>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private CLBDHGNELEF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<DIHPBGLPHFK> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public MIPDODDJDJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EBCA80", Offset = "0x6EBBC80", VA = "0x186EBCA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly GEGJPPMHKLD CBFMLHGPBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NBJOJCNGECN CGABLOLLLEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly ABJPHNNDPLE CJGKPKOFFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CFENLOCLIID OLEOLKIAPLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FMABBFFAJFM EJNAPPPBKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> NENEJFBFAKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly JKHLEFIBAIM HDPIEKGLCHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly JKHLEFIBAIM JCEKINBIPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource HBAMIOMJPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken EEDAMAPOBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ENAGHADOJDO<DEILOLEAADK> FGLDHJMFEFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object ODADENKBJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object PKDKICPIOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<DIHPBGLPHFK>> KLDJLGJGHBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<DIHPBGLPHFK>> MCHINGFCIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DIHPBGLPHFK KFNFDPLKJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool HNLHBIIDBNB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DEFLPMOLDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB120", Offset = "0x6EBA320", VA = "0x186EBB120", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BDDNIKCDIFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6EBAFC0", Offset = "0x6EBA1C0", VA = "0x186EBAFC0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool FCJHKCAAPEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB410", Offset = "0x6EBA610", VA = "0x186EBB410", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float IMJKACOPJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC31D40", Offset = "0xC30F40", VA = "0x180C31D40", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1056BA0", Offset = "0x1055DA0", VA = "0x181056BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DIHPBGLPHFK GGNFHLDOMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x890120", Offset = "0x88F320", VA = "0x180890120")]
		get
		{
			return default(DIHPBGLPHFK);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB7C0", Offset = "0x6EBA9C0", VA = "0x186EBB7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<DIHPBGLPHFK> ICLHHLHNFNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EBAA80", Offset = "0x6EB9C80", VA = "0x186EBAA80")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EBB420", Offset = "0x6EBA620", VA = "0x186EBB420")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC190", Offset = "0x6EBB390", VA = "0x186EBC190")]
	[Preserve]
	public JIDLGPAGJEJ([NDGONEEEGIA(null)] GEGJPPMHKLD CBFMLHGPBGD, [NDGONEEEGIA(null)] NBJOJCNGECN CGABLOLLLEJ, [NDGONEEEGIA(null)] ABJPHNNDPLE CJGKPKOFFDL, [NDGONEEEGIA("CameraFadeTimeoutDetector")] CFENLOCLIID OLEOLKIAPLB, [NDGONEEEGIA(null)] FMABBFFAJFM EJNAPPPBKFD, [NDGONEEEGIA(null)] KLEGICIHAEO<CameraFadeOptions> CPPBBBCKIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6EBBB50", Offset = "0x6EBAD50", VA = "0x186EBBB50")]
	internal JIDLGPAGJEJ(GEGJPPMHKLD CBFMLHGPBGD, NBJOJCNGECN CGABLOLLLEJ, ABJPHNNDPLE CJGKPKOFFDL, CFENLOCLIID OLEOLKIAPLB, FMABBFFAJFM EJNAPPPBKFD, KLEGICIHAEO<CameraFadeOptions> CPPBBBCKIMF, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x716030", Offset = "0x715430")] Func<Task> NENEJFBFAKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA460", Offset = "0x6EB9660", VA = "0x186EBA460", Slot = "8")]
	public EKENKMHAPBN BAIILHAPKJJ(DEILOLEAADK FDCOCHLAHJD, [Optional] KIGAEDKIJFP? KEONJOFJCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB4C0", Offset = "0x6EBA6C0", VA = "0x186EBB4C0", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LBMIEAAPFOK))]
	public Task JKMACFPIEEO([Optional] CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB0D0", Offset = "0x6EBA2D0", VA = "0x186EBB0D0", Slot = "10")]
	public IReadOnlyCollection<DEILOLEAADK> FJGDJMPCBKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAB50", Offset = "0x6EB9D50", VA = "0x186EBAB50")]
	internal void CLFELHFLJCL(DEILOLEAADK FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB970", Offset = "0x6EBAB70", VA = "0x186EBB970")]
	private GDCDCCLEKOB NMFFLMDCBEL()
	{
		return default(GDCDCCLEKOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAB20", Offset = "0x6EB9D20", VA = "0x186EBAB20")]
	private GDCDCCLEKOB CADHKBDINOI()
	{
		return default(GDCDCCLEKOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB140", Offset = "0x6EBA340", VA = "0x186EBB140")]
	internal void GIJKKKFBFPM(DEILOLEAADK FDCOCHLAHJD, KIGAEDKIJFP LDEHOAKHJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB2E0", Offset = "0x6EBA4E0", VA = "0x186EBB2E0")]
	private static void HKHKBEDKPFL(IReadOnlyList<TaskCompletionSource<DIHPBGLPHFK>> BOHPHCOJEMP, DIHPBGLPHFK EHKOIEJKJPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB9A0", Offset = "0x6EBABA0", VA = "0x186EBB9A0")]
	private void OLFHKHBJCPD(float ECMEMPLFPCJ, Func<GDCDCCLEKOB> HNNNPLHAPCL, DIHPBGLPHFK HFKDFBPEGKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB8F0", Offset = "0x6EBAAF0", VA = "0x186EBB8F0")]
	private static bool KDKKAJBBMLN(float GGFLAOCNMAP, float PIINDHALINJ, float JIOCOMFAJPP = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBB610", Offset = "0x6EBA810", VA = "0x186EBB610")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(OKANAGIKAII))]
	private Task KCEFLBMOGMM(CancellationToken JIEKCCCMBMG, float ECMEMPLFPCJ, Func<GDCDCCLEKOB> LMEIFCJOIFG, DIHPBGLPHFK HFKDFBPEGKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAFD0", Offset = "0x6EBA1D0", VA = "0x186EBAFD0")]
	private void EBDAKKEDOFN(float PLAAPDGJOPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAE30", Offset = "0x6EBA030", VA = "0x186EBAE30")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(EFMBJIPEFGC))]
	internal Task DIGEINPLPAH([Optional] CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBACE0", Offset = "0x6EB9EE0", VA = "0x186EBACE0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(MIPDODDJDJL))]
	private static Task CLLEMCBAHIK(ICollection<TaskCompletionSource<DIHPBGLPHFK>> BOHPHCOJEMP, CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EBAF80", Offset = "0x6EBA180", VA = "0x186EBAF80", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class BGCPDGOACGH : EKENKMHAPBN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class CLLMPONMLPE : IAsyncStateMachine
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
		public BGCPDGOACGH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public CLLMPONMLPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EB9BA0", Offset = "0x6EB8DA0", VA = "0x186EB9BA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly OFLNMJKDMHF BCNOMOPEMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly JIDLGPAGJEJ GBBLODABHLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly DEILOLEAADK FDCOCHLAHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private bool IFCDFOBKGCM;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9AA0", Offset = "0x6EB8CA0", VA = "0x186EB9AA0")]
	internal BGCPDGOACGH(JIDLGPAGJEJ GBBLODABHLP, DEILOLEAADK FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9950", Offset = "0x6EB8B50", VA = "0x186EB9950", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CLLMPONMLPE))]
	public Task OIIEFEPDCKB([Optional] CancellationToken MELLLMEKJLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9790", Offset = "0x6EB8990", VA = "0x186EB9790", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class JKHLEFIBAIM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum GDKBNBIDBOB : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly GDKBNBIDBOB ACAKGDKAFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Dictionary<object, GDCDCCLEKOB> PFCHGAPPAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly GDCDCCLEKOB MNPGJDOPFLO;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public GDCDCCLEKOB HDFPEMDEFEE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x16D3320", Offset = "0x16D2520", VA = "0x1816D3320")]
		[CompilerGenerated]
		get
		{
			return default(GDCDCCLEKOB);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x16D3340", Offset = "0x16D2540", VA = "0x1816D3340")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC6A0", Offset = "0x6EBB8A0", VA = "0x186EBC6A0")]
	public JKHLEFIBAIM(GDKBNBIDBOB ACAKGDKAFMC, GDCDCCLEKOB MNPGJDOPFLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC3C0", Offset = "0x6EBB5C0", VA = "0x186EBC3C0")]
	public void LAJLEINODPG(object FDCOCHLAHJD, GDCDCCLEKOB OPCJHBHBDAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC2C0", Offset = "0x6EBB4C0", VA = "0x186EBC2C0")]
	public void HCICIMHFKFM(object FDCOCHLAHJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC330", Offset = "0x6EBB530", VA = "0x186EBC330")]
	public void HNOBOGMOMNO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC220", Offset = "0x6EBB420", VA = "0x186EBC220")]
	private void GBMINGAHAIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC1E0", Offset = "0x6EBB3E0", VA = "0x186EBC1E0")]
	private GDCDCCLEKOB FBPJLLOGPGD()
	{
		return default(GDCDCCLEKOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC380", Offset = "0x6EBB580", VA = "0x186EBC380")]
	private GDCDCCLEKOB KEFBAOIBDCJ()
	{
		return default(GDCDCCLEKOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6EBC4E0", Offset = "0x6EBB6E0", VA = "0x186EBC4E0")]
	private GDCDCCLEKOB MFGAGOADAEL(int EGJHMPMPLPG)
	{
		return default(GDCDCCLEKOB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal readonly struct GDCDCCLEKOB : IEquatable<GDCDCCLEKOB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly bool KBLMFJEBGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly float BCBMGCDDGHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly float JEOCIFBJKIO;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA380", Offset = "0x6EB9580", VA = "0x186EBA380")]
	public GDCDCCLEKOB(float AOJIHCJIPHE, float KPNFPBFKGFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA250", Offset = "0x6EB9450", VA = "0x186EBA250", Slot = "4")]
	public bool Equals(GDCDCCLEKOB JMNBIHILIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA1A0", Offset = "0x6EB93A0", VA = "0x186EBA1A0", Slot = "0")]
	public override bool Equals(object? PPNJOAJJOFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA290", Offset = "0x6EB9490", VA = "0x186EBA290", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6EBA2E0", Offset = "0x6EB94E0", VA = "0x186EBA2E0", Slot = "3")]
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
