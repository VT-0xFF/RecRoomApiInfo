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
		[Cpp2IlInjected.Address(RVA = "0x7F1AF0", Offset = "0x7F0EF0", VA = "0x1807F1AF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6EE7B30", Offset = "0x6EE6F30", VA = "0x186EE7B30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D1B70", Offset = "0x8D0F70", VA = "0x1808D1B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9D7910", Offset = "0x9D6D10", VA = "0x1809D7910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[BFHCHFMBBNB]
public class OJBMBLEFLKM : FHJNLLNECND, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum CLBKLPJKGDE
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
	private sealed class DPNCANGBINP : IAsyncStateMachine
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
		public OJBMBLEFLKM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public DPNCANGBINP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6EC0", Offset = "0x6EE62C0", VA = "0x186EE6EC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class KHMIFDHONGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public KHMIFDHONGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6EE7B00", Offset = "0x6EE6F00", VA = "0x186EE7B00")]
		internal void IKLAAFHKLFM(CLBKLPJKGDE fadeState)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class BJAKKEOJPFE : IAsyncStateMachine
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
		public Func<PMGPHNCIGBP> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CLBKLPJKGDE completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public OJBMBLEFLKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private KHMIFDHONGK <>8__1;

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
		private PMGPHNCIGBP <currentFadeRate>5__10;

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
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public BJAKKEOJPFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE6110", Offset = "0x6EE5510", VA = "0x186EE6110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PMGHGCOKJHN : IAsyncStateMachine
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
		public OJBMBLEFLKM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <tokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public PMGHGCOKJHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9990", Offset = "0x6EE8D90", VA = "0x186EE9990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class PEPILPPPIJO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public TaskCompletionSource<CLBKLPJKGDE> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public PEPILPPPIJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9940", Offset = "0x6EE8D40", VA = "0x186EE9940")]
		internal void LNBKPKIGOCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FDBKKEECEAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C600", Offset = "0x71BA00")]
		public ICollection<TaskCompletionSource<CLBKLPJKGDE>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private PEPILPPPIJO <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<CLBKLPJKGDE> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public FDBKKEECEAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6EE71F0", Offset = "0x6EE65F0", VA = "0x186EE71F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IAOMBNEEADI EIEDDLCIDGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GKAAIFBEBBN DDOBHCDIFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly JALNCDMAJCJ FMKCFGBFEPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly CAIMKLEKLDA IGFLGEGOOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ENJODDNJIKD DGLIEJINEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> BDOPIOODFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly ABCIODCBKPP BIDFHFIINHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly ABCIODCBKPP LKKHPHHBHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource EOMANCMIDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken DCOIDCKJOMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NIBIHKFMNHF<ICHPPOJKHCG> AHEIJLOIBBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object KDMEHLJDFAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object FILLHMPNAHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<CLBKLPJKGDE>> CKLLLKDDOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<CLBKLPJKGDE>> BMMBIKJCKLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private CLBKLPJKGDE LBDCBNCEPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool EIAIKGINNCG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool ICPLMMHHOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8200", Offset = "0x6EE7600", VA = "0x186EE8200", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool NEHOFBPMFOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8220", Offset = "0x6EE7620", VA = "0x186EE8220", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHHKNJHHIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EE9100", Offset = "0x6EE8500", VA = "0x186EE9100", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float OLHICNHMIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB7AC70", Offset = "0xB7A070", VA = "0x180B7AC70", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB7AC80", Offset = "0xB7A080", VA = "0x180B7AC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private CLBKLPJKGDE GLNIKJNLCIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C0F70", Offset = "0x9C0370", VA = "0x1809C0F70")]
		get
		{
			return default(CLBKLPJKGDE);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8230", Offset = "0x6EE7630", VA = "0x186EE8230")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<CLBKLPJKGDE> AOFHJPLDLBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8160", Offset = "0x6EE7560", VA = "0x186EE8160")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6EE8000", Offset = "0x6EE7400", VA = "0x186EE8000")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE92B0", Offset = "0x6EE86B0", VA = "0x186EE92B0")]
	[Preserve]
	public OJBMBLEFLKM([EPGFAMNCJKC(null)] IAOMBNEEADI EIEDDLCIDGK, [EPGFAMNCJKC(null)] GKAAIFBEBBN DDOBHCDIFOC, [EPGFAMNCJKC(null)] JALNCDMAJCJ FMKCFGBFEPO, [EPGFAMNCJKC("CameraFadeTimeoutDetector")] CAIMKLEKLDA IGFLGEGOOIP, [EPGFAMNCJKC(null)] ENJODDNJIKD DGLIEJINEGA, [EPGFAMNCJKC(null)] BJGAAEALPEI<CameraFadeOptions> CPIBKOBEODB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9300", Offset = "0x6EE8700", VA = "0x186EE9300")]
	internal OJBMBLEFLKM(IAOMBNEEADI EIEDDLCIDGK, GKAAIFBEBBN DDOBHCDIFOC, JALNCDMAJCJ FMKCFGBFEPO, CAIMKLEKLDA IGFLGEGOOIP, ENJODDNJIKD DGLIEJINEGA, BJGAAEALPEI<CameraFadeOptions> CPIBKOBEODB, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0x71C300", Offset = "0x71B700")] Func<Task> BDOPIOODFAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8AE0", Offset = "0x6EE7EE0", VA = "0x186EE8AE0", Slot = "8")]
	public OBNCBHOMJNM OANHKIHCFPJ(ICHPPOJKHCG GAOLOMEJCOK, [Optional] OBNNLMLLADJ? HLFCBCPPEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8390", Offset = "0x6EE7790", VA = "0x186EE8390", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(DPNCANGBINP))]
	public Task LFEDABNOHHL([Optional] CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EE84E0", Offset = "0x6EE78E0", VA = "0x186EE84E0", Slot = "10")]
	public IReadOnlyCollection<ICHPPOJKHCG> MDJEEHICMLD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7BC0", Offset = "0x6EE6FC0", VA = "0x186EE7BC0")]
	internal void AECHDPHMMKA(ICHPPOJKHCG GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7D50", Offset = "0x6EE7150", VA = "0x186EE7D50")]
	private PMGPHNCIGBP AHJODJIJDGD()
	{
		return default(PMGPHNCIGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8360", Offset = "0x6EE7760", VA = "0x186EE8360")]
	private PMGPHNCIGBP LAEAMKKGJEP()
	{
		return default(PMGPHNCIGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9110", Offset = "0x6EE8510", VA = "0x186EE9110")]
	internal void PNPBGJPNDPN(ICHPPOJKHCG GAOLOMEJCOK, OBNNLMLLADJ IGJOFKNDKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7ED0", Offset = "0x6EE72D0", VA = "0x186EE7ED0")]
	private static void AKOBDCGJNKG(IReadOnlyList<TaskCompletionSource<CLBKLPJKGDE>> IGLEDCGEKNL, CLBKLPJKGDE GPBBPKGFGEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8830", Offset = "0x6EE7C30", VA = "0x186EE8830")]
	private void NAJNFPGBHFL(float JIOPKMFEGBJ, Func<PMGPHNCIGBP> AJGNPMAFHHM, CLBKLPJKGDE FHOPKEKJMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EE80E0", Offset = "0x6EE74E0", VA = "0x186EE80E0")]
	private static bool EBOKHPBLBMH(float EJOFMGLMADH, float CMACFBOCONA, float KJHPABNMIHN = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EE8530", Offset = "0x6EE7930", VA = "0x186EE8530")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BJAKKEOJPFE))]
	private Task MJMCJODINNN(CancellationToken OFJDILOINPC, float JIOPKMFEGBJ, Func<PMGPHNCIGBP> EBFLIOIPCAN, CLBKLPJKGDE FHOPKEKJMMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE89E0", Offset = "0x6EE7DE0", VA = "0x186EE89E0")]
	private void NHNPAABBLHB(float OOELMMAMPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7D80", Offset = "0x6EE7180", VA = "0x186EE7D80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(PMGHGCOKJHN))]
	internal Task AIGACMOPDMH([Optional] CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE86E0", Offset = "0x6EE7AE0", VA = "0x186EE86E0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FDBKKEECEAJ))]
	private static Task MNBAAEGDEHK(ICollection<TaskCompletionSource<CLBKLPJKGDE>> IGLEDCGEKNL, CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE80A0", Offset = "0x6EE74A0", VA = "0x186EE80A0", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class JFFNBIJDPPC : OBNCBHOMJNM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class APFFBDHLGIM : IAsyncStateMachine
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
		public JFFNBIJDPPC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
		public APFFBDHLGIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6EE5E40", Offset = "0x6EE5240", VA = "0x186EE5E40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly KLBCBGMJKEB IDDDJGJFGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly OJBMBLEFLKM DPKNGPELMFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly ICHPPOJKHCG GAOLOMEJCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private bool NEOLAOAJOPA;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7A50", Offset = "0x6EE6E50", VA = "0x186EE7A50")]
	internal JFFNBIJDPPC(OJBMBLEFLKM DPKNGPELMFM, ICHPPOJKHCG GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7900", Offset = "0x6EE6D00", VA = "0x186EE7900", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(APFFBDHLGIM))]
	public Task IDONKIBONJM([Optional] CancellationToken DNKHCCGNODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6EE7740", Offset = "0x6EE6B40", VA = "0x186EE7740", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class ABCIODCBKPP
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum PHGPACBNFAC : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly PHGPACBNFAC PMDFBEPKCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Dictionary<object, PMGPHNCIGBP> GKHPHMEPOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly PMGPHNCIGBP CCCIDBOMFCB;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public PMGPHNCIGBP EEMAOFBHODN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xC78710", Offset = "0xC77B10", VA = "0x180C78710")]
		[CompilerGenerated]
		get
		{
			return default(PMGPHNCIGBP);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xC7AEC0", Offset = "0xC7A2C0", VA = "0x180C7AEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5D90", Offset = "0x6EE5190", VA = "0x186EE5D90")]
	public ABCIODCBKPP(PHGPACBNFAC PMDFBEPKCLF, PMGPHNCIGBP CCCIDBOMFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5B30", Offset = "0x6EE4F30", VA = "0x186EE5B30")]
	public void FNPLHAFFDON(object GAOLOMEJCOK, PMGPHNCIGBP BOGCLPKLCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5CD0", Offset = "0x6EE50D0", VA = "0x186EE5CD0")]
	public void PBDAKCGNFND(object GAOLOMEJCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5D40", Offset = "0x6EE5140", VA = "0x186EE5D40")]
	public void PEHJALIONDD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5A90", Offset = "0x6EE4E90", VA = "0x186EE5A90")]
	private void EPDMBNCOHOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5C90", Offset = "0x6EE5090", VA = "0x186EE5C90")]
	private PMGPHNCIGBP OMGIBOFDCMN()
	{
		return default(PMGPHNCIGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6EE5C50", Offset = "0x6EE5050", VA = "0x186EE5C50")]
	private PMGPHNCIGBP LFOBJPDLBLK()
	{
		return default(PMGPHNCIGBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6EE58D0", Offset = "0x6EE4CD0", VA = "0x186EE58D0")]
	private PMGPHNCIGBP AHBKFGGFFEH(int HDHEIFAHNEA)
	{
		return default(PMGPHNCIGBP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal readonly struct PMGPHNCIGBP : IEquatable<PMGPHNCIGBP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly bool EPDNKGDEIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly float EJFOGLCIDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly float FCAIPHLAFPN;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9EA0", Offset = "0x6EE92A0", VA = "0x186EE9EA0")]
	public PMGPHNCIGBP(float IKEMDCEJHKF, float IDCDACBEHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9D70", Offset = "0x6EE9170", VA = "0x186EE9D70", Slot = "4")]
	public bool Equals(PMGPHNCIGBP LNOOAJJNCAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9CC0", Offset = "0x6EE90C0", VA = "0x186EE9CC0", Slot = "0")]
	public override bool Equals(object? ICNDEPGFBMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9DB0", Offset = "0x6EE91B0", VA = "0x186EE9DB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6EE9E00", Offset = "0x6EE9200", VA = "0x186EE9E00", Slot = "3")]
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
