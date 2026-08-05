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
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9780", VA = "0x1807DAB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x6039DF0", Offset = "0x60389F0", VA = "0x186039DF0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DB530", Offset = "0x7DA130", VA = "0x1807DB530")]
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
		[Cpp2IlInjected.Address(RVA = "0x7DB570", Offset = "0x7DA170", VA = "0x1807DB570")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[JHPFJEFPNKG]
public class KCPJDFJNPIK : MGCBNOFKFNA, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal enum JNMGKGAKAKL
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
	private struct AGFNLIBONFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public KCPJDFJNPIK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x60353E0", Offset = "0x6033FE0", VA = "0x1860353E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60357E0", Offset = "0x60343E0", VA = "0x1860357E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class FPEGNEGEHIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public FPEGNEGEHIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60367A0", Offset = "0x60353A0", VA = "0x1860367A0")]
		internal void ODJNNAFFGIE(JNMGKGAKAKL fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct JDFGGOLEJOE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public JNMGKGAKAKL completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public KCPJDFJNPIK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public Func<CBKOGMBPBLH> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private FPEGNEGEHIM <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x6037070", Offset = "0x6035C70", VA = "0x186037070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6037DB0", Offset = "0x60369B0", VA = "0x186037DB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HJBEHJKGPOG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public KCPJDFJNPIK <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x60367D0", Offset = "0x60353D0", VA = "0x1860367D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6036BE0", Offset = "0x60357E0", VA = "0x186036BE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private sealed class BEHJPHBICDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public TaskCompletionSource<JNMGKGAKAKL> tcs;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
		public BEHJPHBICDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6035840", Offset = "0x6034440", VA = "0x186035840")]
		internal void INJEJAIMFFJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct DEAJOKCCBHN : IAsyncStateMachine
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
		public ICollection<TaskCompletionSource<JNMGKGAKAKL>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private BEHJPHBICDD <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TaskAwaiter<JNMGKGAKAKL> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60360D0", Offset = "0x6034CD0", VA = "0x1860360D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6036740", Offset = "0x6035340", VA = "0x186036740", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly EHCILDDPKPI MHPBINFJAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly JOBIBLJJKMP FMLCHPJLOHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly PLBKOCBJDEA HODNAMPDCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly OIDPKNKLGAJ EEIMAJPAPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly FKJGKDNGJPP NCMMBIBBOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly Func<Task> EELJBFHDEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BIGCFMMAJCG BPOGEMAJLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly BIGCFMMAJCG CPJBEGMKLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly CancellationTokenSource DELHBFPGPMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationToken PCNKLBBOBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly NLAOINFHHNN<CAPELAHPHJP> GKBDLJLDIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly object ADEOFCHEJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object BIAHFJCNOBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly List<TaskCompletionSource<JNMGKGAKAKL>> GCIDDDNDOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<JNMGKGAKAKL>> IHGBJKHMKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private JNMGKGAKAKL ODGPJFCLBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	internal bool ONBIFNFGOLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool NNMIGBKCCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x60393F0", Offset = "0x6037FF0", VA = "0x1860393F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KLDJIEGAKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6037FA0", Offset = "0x6036BA0", VA = "0x186037FA0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BPIMFFHBLCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60387B0", Offset = "0x60373B0", VA = "0x1860387B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float GAFEGDENHLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84CB90", Offset = "0x84B790", VA = "0x18084CB90", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86C140", Offset = "0x86AD40", VA = "0x18086C140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private JNMGKGAKAKL EEJOKPBFCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC6BA10", Offset = "0xC6A610", VA = "0x180C6BA10")]
		get
		{
			return default(JNMGKGAKAKL);
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6038680", Offset = "0x6037280", VA = "0x186038680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<JNMGKGAKAKL> KINEOBICEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6037FB0", Offset = "0x6036BB0", VA = "0x186037FB0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6038A50", Offset = "0x6037650", VA = "0x186038A50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6039410", Offset = "0x6038010", VA = "0x186039410")]
	[Preserve]
	public KCPJDFJNPIK([NNEMKPMNJAE(null)] EHCILDDPKPI MHPBINFJAKK, [NNEMKPMNJAE(null)] JOBIBLJJKMP FMLCHPJLOHL, [NNEMKPMNJAE(null)] PLBKOCBJDEA HODNAMPDCOC, [NNEMKPMNJAE("CameraFadeTimeoutDetector")] OIDPKNKLGAJ EEIMAJPAPBG, [NNEMKPMNJAE(null)] FKJGKDNGJPP NCMMBIBBOEC, [NNEMKPMNJAE(null)] AKPBPIKHFBD<CameraFadeOptions> JAIAHAGCBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6039460", Offset = "0x6038060", VA = "0x186039460")]
	internal KCPJDFJNPIK(EHCILDDPKPI MHPBINFJAKK, JOBIBLJJKMP FMLCHPJLOHL, PLBKOCBJDEA HODNAMPDCOC, OIDPKNKLGAJ EEIMAJPAPBG, FKJGKDNGJPP NCMMBIBBOEC, AKPBPIKHFBD<CameraFadeOptions> JAIAHAGCBLM, Func<Task>? EELJBFHDEIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6038CC0", Offset = "0x60378C0", VA = "0x186038CC0", Slot = "8")]
	public LKLHBHIGFAI JAJCHOCLOBG(CAPELAHPHJP DGPOLLDAHJK, [Optional] NGBPNDOFBKL? EJAFLLIHBJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6038070", Offset = "0x6036C70", VA = "0x186038070", Slot = "9")]
	[AsyncStateMachine(typeof(AGFNLIBONFD))]
	public Task DCGABKPHDOI([Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6037F50", Offset = "0x6036B50", VA = "0x186037F50", Slot = "10")]
	public IReadOnlyCollection<CAPELAHPHJP> BLICDIPPJDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60387C0", Offset = "0x60373C0", VA = "0x1860387C0")]
	internal void FJNNAIOOMPM(CAPELAHPHJP DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6038B10", Offset = "0x6037710", VA = "0x186038B10")]
	private CBKOGMBPBLH IKCNJCGMFAH()
	{
		return default(CBKOGMBPBLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x60393C0", Offset = "0x6037FC0", VA = "0x1860393C0")]
	private CBKOGMBPBLH NCIGANHJGBA()
	{
		return default(CBKOGMBPBLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x60383D0", Offset = "0x6036FD0", VA = "0x1860383D0")]
	internal void EABHMNNGNOB(CAPELAHPHJP DGPOLLDAHJK, NGBPNDOFBKL KGOPFFJLFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6038160", Offset = "0x6036D60", VA = "0x186038160")]
	private static void DEMPOFFNNLC(IReadOnlyList<TaskCompletionSource<JNMGKGAKAKL>> EOMHMMLIIPA, JNMGKGAKAKL CGKPLAEDJFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6038B40", Offset = "0x6037740", VA = "0x186038B40")]
	private void IOJJMOAHLKK(float FIBPPKLCLOG, Func<CBKOGMBPBLH> FGMGLHFOMKJ, JNMGKGAKAKL KFCGKBHEJKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6039340", Offset = "0x6037F40", VA = "0x186039340")]
	private static bool KHIDFBMDHIA(float PKCAMDKHNLN, float ECIMPLOCMKE, float OMPPNALJJJL = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6037E10", Offset = "0x6036A10", VA = "0x186037E10")]
	[AsyncStateMachine(typeof(JDFGGOLEJOE))]
	private Task ABNFDOGIBMM(CancellationToken NFEFCAGIEPH, float FIBPPKLCLOG, Func<CBKOGMBPBLH> HBBFEPEKOPP, JNMGKGAKAKL KFCGKBHEJKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6038940", Offset = "0x6037540", VA = "0x186038940")]
	private void GCCGCACHNOH(float IPCFPIMDHAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60382A0", Offset = "0x6036EA0", VA = "0x1860382A0")]
	[AsyncStateMachine(typeof(HJBEHJKGPOG))]
	internal Task DGKOOFCIPMO([Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6038580", Offset = "0x6037180", VA = "0x186038580")]
	[AsyncStateMachine(typeof(DEAJOKCCBHN))]
	private static Task EOPJDMLAKMO(ICollection<TaskCompletionSource<JNMGKGAKAKL>> EOMHMMLIIPA, CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6038390", Offset = "0x6036F90", VA = "0x186038390", Slot = "11")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal class JCLPFIIGEBK : LKLHBHIGFAI, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KDKMGJOBPMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public JCLPFIIGEBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6039B10", Offset = "0x6038710", VA = "0x186039B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6039D90", Offset = "0x6038990", VA = "0x186039D90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static readonly string PMHGBKLOLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	private readonly PMKDBMIPKGM IKNKGJBJGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly KCPJDFJNPIK GKGCFCBONBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private readonly CAPELAHPHJP DGPOLLDAHJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private bool DLLGBEPLAAB;

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6036F70", Offset = "0x6035B70", VA = "0x186036F70")]
	internal JCLPFIIGEBK(KCPJDFJNPIK GKGCFCBONBF, CAPELAHPHJP DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6036DF0", Offset = "0x60359F0", VA = "0x186036DF0", Slot = "4")]
	[AsyncStateMachine(typeof(KDKMGJOBPMN))]
	public Task JMEJBFPBDAO([Optional] CancellationToken EJGJLLMBDIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6036C40", Offset = "0x6035840", VA = "0x186036C40", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal readonly struct CBKOGMBPBLH : IEquatable<CBKOGMBPBLH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly bool NBAADMIJBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly float IIPLABBCLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly float FPJNGIKIONC;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6036000", Offset = "0x6034C00", VA = "0x186036000")]
	public CBKOGMBPBLH(float HJBPNBAJMAK, float FBOJEGKGGFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6035DF0", Offset = "0x60349F0", VA = "0x186035DF0", Slot = "4")]
	public bool Equals(CBKOGMBPBLH NAFFCAIMPLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6035E30", Offset = "0x6034A30", VA = "0x186035E30", Slot = "0")]
	public override bool Equals(object? OGGNGHKHHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6035EE0", Offset = "0x6034AE0", VA = "0x186035EE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6035F60", Offset = "0x6034B60", VA = "0x186035F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class BIGCFMMAJCG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum BEIMOBALBFO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly BEIMOBALBFO DDNJACKFGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<object, CBKOGMBPBLH> CKFPIHKLFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly CBKOGMBPBLH CIBDIBHGDMG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CBKOGMBPBLH BLAEOCKJGCA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9B7A20", Offset = "0x9B6620", VA = "0x1809B7A20")]
		[CompilerGenerated]
		get
		{
			return default(CBKOGMBPBLH);
		}
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9B7D40", Offset = "0x9B6940", VA = "0x1809B7D40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6035D30", Offset = "0x6034930", VA = "0x186035D30")]
	public BIGCFMMAJCG(BEIMOBALBFO DDNJACKFGPA, CBKOGMBPBLH CIBDIBHGDMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6035AA0", Offset = "0x60346A0", VA = "0x186035AA0")]
	public void DPFFOHLLONE(object DGPOLLDAHJK, CBKOGMBPBLH HJGMODLCCGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6035A30", Offset = "0x6034630", VA = "0x186035A30")]
	public void DMBJGENFJDP(object DGPOLLDAHJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6035BC0", Offset = "0x60347C0", VA = "0x186035BC0")]
	public void GEDHBEKABPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6035C10", Offset = "0x6034810", VA = "0x186035C10")]
	private void HJKNBGGJLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6035CB0", Offset = "0x60348B0", VA = "0x186035CB0")]
	private CBKOGMBPBLH KBGDOKJIEPA()
	{
		return default(CBKOGMBPBLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6035CF0", Offset = "0x60348F0", VA = "0x186035CF0")]
	private CBKOGMBPBLH PNLMJPJPFGI()
	{
		return default(CBKOGMBPBLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6035890", Offset = "0x6034490", VA = "0x186035890")]
	private CBKOGMBPBLH BABMAKHOAAC(int EJAPCLHMGIL)
	{
		return default(CBKOGMBPBLH);
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
