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
		[Cpp2IlInjected.Address(RVA = "0x8389E0", Offset = "0x8377E0", VA = "0x1808389E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FBAF70", Offset = "0x6FB9D70", VA = "0x186FBAF70")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x917630", Offset = "0x916430", VA = "0x180917630")]
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
		[Cpp2IlInjected.Address(RVA = "0xF6F160", Offset = "0xF6DF60", VA = "0x180F6F160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[MMBMKHHBAJO]
public class EGNMMDGCOFP : BIKJOEANJOJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum DCKBIDJAKMH
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
	private sealed class ABCPDBDFKJA : IAsyncStateMachine
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
		public EGNMMDGCOFP <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ABCPDBDFKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6FB6FA0", Offset = "0x6FB5DA0", VA = "0x186FB6FA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class EJOAKKNOCFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public EJOAKKNOCFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9710", Offset = "0x6FB8510", VA = "0x186FB9710")]
		internal void GIKKOIICGCG(DCKBIDJAKMH fadeState)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HONFCMOMNHN : IAsyncStateMachine
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
		public Func<LOMBPBKBFPD> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public DCKBIDJAKMH completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public EGNMMDGCOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private EJOAKKNOCFH <>8__1;

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
		private LOMBPBKBFPD <currentFadeRate>5__10;

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
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public HONFCMOMNHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9C80", Offset = "0x6FB8A80", VA = "0x186FB9C80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JEFHDIPIGJC : IAsyncStateMachine
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
		public EGNMMDGCOFP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CancellationTokenSource <tokenSource>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public JEFHDIPIGJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6FBA9B0", Offset = "0x6FB97B0", VA = "0x186FBA9B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class DDNHAOINNHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public TaskCompletionSource<DCKBIDJAKMH> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public DDNHAOINNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7930", Offset = "0x6FB6730", VA = "0x186FB7930")]
		internal void DFPOHPPDJLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class FPOGKFOMIAC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xAF4F0", Offset = "0xAE8F0")]
		public ICollection<TaskCompletionSource<DCKBIDJAKMH>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private DDNHAOINNHK <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter<DCKBIDJAKMH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public FPOGKFOMIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9740", Offset = "0x6FB8540", VA = "0x186FB9740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JLNCNJEHMHB JHKMELNGAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FCOAHODBHIN JMMHADBECMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly CMCCNLDPEHJ JJDFOBHIKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly KHHLDKCIMJH BEGDOAOGPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly PCDENCJPNEO PNNLDAFFGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> NBDCIJAOJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly PEMNGCBEKJM PNKFGIINGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly PEMNGCBEKJM GCBKHAJJFMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource KBKNLPIAEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken EKFAKPFICGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KDNPCFAPKID<MKAPBHKEDAL> FHEMDNECCHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object CLCGNDEHJDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object EOGPBJKDOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<DCKBIDJAKMH>> DLJHFHHOFLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<DCKBIDJAKMH>> FONMMJCPKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private DCKBIDJAKMH LBMAGCBBCLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool CEDKOPJHIAN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool AMJBCBAHALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9060", Offset = "0x6FB7E60", VA = "0x186FB9060", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KLPKEPJIADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9050", Offset = "0x6FB7E50", VA = "0x186FB9050", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JDOJGIAMEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8F30", Offset = "0x6FB7D30", VA = "0x186FB8F30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float KFPNIFBLMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9D8010", Offset = "0x9D6E10", VA = "0x1809D8010", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9D8020", Offset = "0x9D6E20", VA = "0x1809D8020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DCKBIDJAKMH HIPGIFPPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x959C00", Offset = "0x958A00", VA = "0x180959C00")]
		get
		{
			return default(DCKBIDJAKMH);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7CD0", Offset = "0x6FB6AD0", VA = "0x186FB7CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<DCKBIDJAKMH> NBJIKFEJOBC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8400", Offset = "0x6FB7200", VA = "0x186FB8400")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7E00", Offset = "0x6FB6C00", VA = "0x186FB7E00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB9080", Offset = "0x6FB7E80", VA = "0x186FB9080")]
	[Preserve]
	public EGNMMDGCOFP([DNPFPOCMFCA(null)] JLNCNJEHMHB JHKMELNGAOK, [DNPFPOCMFCA(null)] FCOAHODBHIN JMMHADBECMA, [DNPFPOCMFCA(null)] CMCCNLDPEHJ JJDFOBHIKII, [DNPFPOCMFCA("CameraFadeTimeoutDetector")] KHHLDKCIMJH BEGDOAOGPPO, [DNPFPOCMFCA(null)] PCDENCJPNEO PNNLDAFFGIA, [DNPFPOCMFCA(null)] NFHBFEFILIO<CameraFadeOptions> PJMJNHMCCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6FB90D0", Offset = "0x6FB7ED0", VA = "0x186FB90D0")]
	internal EGNMMDGCOFP(JLNCNJEHMHB JHKMELNGAOK, FCOAHODBHIN JMMHADBECMA, CMCCNLDPEHJ JJDFOBHIKII, KHHLDKCIMJH BEGDOAOGPPO, PCDENCJPNEO PNNLDAFFGIA, NFHBFEFILIO<CameraFadeOptions> PJMJNHMCCBP, [Cpp2IlInjected.Attribute(Name = "NullableAttribute", RVA = "0xAF1F0", Offset = "0xAE5F0")] Func<Task> NBDCIJAOJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8620", Offset = "0x6FB7420", VA = "0x186FB8620", Slot = "8")]
	public LKBPDDBOOCC JJCPLINJBKB(MKAPBHKEDAL GKNJCIECGND, [Optional] NJMMCNNLJMC? DPPFFGBEFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7EA0", Offset = "0x6FB6CA0", VA = "0x186FB7EA0", Slot = "9")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ABCPDBDFKJA))]
	public Task CKLMPGDLMMP([Optional] CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6FB83B0", Offset = "0x6FB71B0", VA = "0x186FB83B0", Slot = "10")]
	public IReadOnlyCollection<MKAPBHKEDAL> HGKHINCAFMN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6FB81B0", Offset = "0x6FB6FB0", VA = "0x186FB81B0")]
	internal void FBGBIKJFAPL(MKAPBHKEDAL GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6FB85F0", Offset = "0x6FB73F0", VA = "0x186FB85F0")]
	private LOMBPBKBFPD JGOLKBFGMEL()
	{
		return default(LOMBPBKBFPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8140", Offset = "0x6FB6F40", VA = "0x186FB8140")]
	private LOMBPBKBFPD DFNGJJMNJLK()
	{
		return default(LOMBPBKBFPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7B30", Offset = "0x6FB6930", VA = "0x186FB7B30")]
	internal void BNGFHCEBIHP(MKAPBHKEDAL GKNJCIECGND, NJMMCNNLJMC PKNIPOKJMNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8E00", Offset = "0x6FB7C00", VA = "0x186FB8E00")]
	private static void JMHEGCALBEI(IReadOnlyList<TaskCompletionSource<DCKBIDJAKMH>> MDLHKCLKIBL, DCKBIDJAKMH KEDLBDKJCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8C50", Offset = "0x6FB7A50", VA = "0x186FB8C50")]
	private void JKPLFKCJPHP(float ENNCGJEBDBB, Func<LOMBPBKBFPD> GFHEOIFJBMG, DCKBIDJAKMH DKKBHMIKHGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8330", Offset = "0x6FB7130", VA = "0x186FB8330")]
	private static bool FDOGIHBIKFF(float IKGMJGNOMBA, float GOEPIJCAGGA, float FECKIDBLKDF = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7980", Offset = "0x6FB6780", VA = "0x186FB7980")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HONFCMOMNHN))]
	private Task BBLKFNMPBCD(CancellationToken HDKDIECCHLF, float ENNCGJEBDBB, Func<LOMBPBKBFPD> EAEELIBBOLC, DCKBIDJAKMH DKKBHMIKHGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8F40", Offset = "0x6FB7D40", VA = "0x186FB8F40")]
	private void LGIAMCNNECC(float DHJOLNBHIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6FB84A0", Offset = "0x6FB72A0", VA = "0x186FB84A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(JEFHDIPIGJC))]
	internal Task IDLLHKKEGMF([Optional] CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7FF0", Offset = "0x6FB6DF0", VA = "0x186FB7FF0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(FPOGKFOMIAC))]
	private static Task DAEJHFPKLKM(ICollection<TaskCompletionSource<DCKBIDJAKMH>> MDLHKCLKIBL, CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6FB8170", Offset = "0x6FB6F70", VA = "0x186FB8170", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class BKHMHDNMNDD : LKBPDDBOOCC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class ACDHIIIBBOP : IAsyncStateMachine
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
		public BKHMHDNMNDD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public ACDHIIIBBOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6FB72A0", Offset = "0x6FB60A0", VA = "0x186FB72A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly KJEOIMPLCHA GEALAGHNIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private readonly EGNMMDGCOFP EEMNCJIGFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly MKAPBHKEDAL GKNJCIECGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private bool BLMLHEIKNME;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7880", Offset = "0x6FB6680", VA = "0x186FB7880")]
	internal BKHMHDNMNDD(EGNMMDGCOFP EEMNCJIGFPB, MKAPBHKEDAL GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7730", Offset = "0x6FB6530", VA = "0x186FB7730", Slot = "4")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(ACDHIIIBBOP))]
	public Task IAOEKIMEOAN([Optional] CancellationToken KIMBGNGMOGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6FB7570", Offset = "0x6FB6370", VA = "0x186FB7570", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal class PEMNGCBEKJM
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum LOEEGJPKCHE : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly LOEEGJPKCHE ILMJDLPBMPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private readonly Dictionary<object, LOMBPBKBFPD> FMLAHJIDJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly LOMBPBKBFPD EPHLIEPDHBH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LOMBPBKBFPD ODIKHJJHMMN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x17655A0", Offset = "0x17643A0", VA = "0x1817655A0")]
		[CompilerGenerated]
		get
		{
			return default(LOMBPBKBFPD);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x17655F0", Offset = "0x17643F0", VA = "0x1817655F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB4C0", Offset = "0x6FBA2C0", VA = "0x186FBB4C0")]
	public PEMNGCBEKJM(LOEEGJPKCHE ILMJDLPBMPL, LOMBPBKBFPD EPHLIEPDHBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB140", Offset = "0x6FB9F40", VA = "0x186FBB140")]
	public void ONOPGMHGHFO(object GKNJCIECGND, LOMBPBKBFPD IMLGLMGKBLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB0D0", Offset = "0x6FB9ED0", VA = "0x186FBB0D0")]
	public void OIPPMFBKPAM(object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB080", Offset = "0x6FB9E80", VA = "0x186FBB080")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB260", Offset = "0x6FBA060", VA = "0x186FBB260")]
	private void OPLKFBIOBBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB040", Offset = "0x6FB9E40", VA = "0x186FBB040")]
	private LOMBPBKBFPD FABHNNDIBIG()
	{
		return default(LOMBPBKBFPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB000", Offset = "0x6FB9E00", VA = "0x186FBB000")]
	private LOMBPBKBFPD EJPOJJLBPNJ()
	{
		return default(LOMBPBKBFPD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6FBB300", Offset = "0x6FBA100", VA = "0x186FBB300")]
	private LOMBPBKBFPD PKBHNNENEBI(int LMFJBGOEFHI)
	{
		return default(LOMBPBKBFPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal readonly struct LOMBPBKBFPD : IEquatable<LOMBPBKBFPD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly bool GIGIHCKFEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public readonly float CIAFNNKMFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public readonly float DIKNFGGGGHF;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAE90", Offset = "0x6FB9C90", VA = "0x186FBAE90")]
	public LOMBPBKBFPD(float DGPGNJIEPNC, float OJEMEIILDPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6FBAD60", Offset = "0x6FB9B60", VA = "0x186FBAD60", Slot = "4")]
	public bool Equals(LOMBPBKBFPD FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6FBACB0", Offset = "0x6FB9AB0", VA = "0x186FBACB0", Slot = "0")]
	public override bool Equals(object? GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6FBADA0", Offset = "0x6FB9BA0", VA = "0x186FBADA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6FBADF0", Offset = "0x6FB9BF0", VA = "0x186FBADF0", Slot = "3")]
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
