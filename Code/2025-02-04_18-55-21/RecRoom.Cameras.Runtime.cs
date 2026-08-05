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
using RecRoom.Logging.Attributes;
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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71639E0", Offset = "0x71627E0", VA = "0x1871639E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Cameras_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[RecRoom.Logging.Attributes.Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : CGFLIBNDCKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7163950", Offset = "0x7162750", VA = "0x187163950", Slot = "4")]
		public override void EHDMJEMLBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HLDENJBKDHO]
public class JNGCHOPMLAM : MCGABFLMDLK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum DKOGBMCLJPM
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		ShowingCamera,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		FadingToBlack,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		ShowingBlack,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		FadingToCamera
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private struct LEINCHPAINC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public JNGCHOPMLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x71634B0", Offset = "0x71622B0", VA = "0x1871634B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x71638F0", Offset = "0x71626F0", VA = "0x1871638F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class AAPKMACGKJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public AAPKMACGKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7160210", Offset = "0x715F010", VA = "0x187160210")]
		internal void BPCBBPPFBKH(DKOGBMCLJPM fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct PEABNLEFNNG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public DKOGBMCLJPM completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JNGCHOPMLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<IJCLJOBCMLG> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private AAPKMACGKJJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private object <animateInOutSuppressionToken>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private float <transitionStart>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private CancellationToken <cancellationToken>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private object <>7__wrap4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private int <>7__wrap5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private float? <lastFadeSlope>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private float <lerpTimeStart>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float <lerpTimeEnd>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float <lerpStartValue>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private float <lerpEndValue>5__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7164130", Offset = "0x7162F30", VA = "0x187164130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7165160", Offset = "0x7163F60", VA = "0x187165160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IBIAFPPKMPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public JNGCHOPMLAM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7160C20", Offset = "0x715FA20", VA = "0x187160C20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7161060", Offset = "0x715FE60", VA = "0x187161060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class DBIKLGMICGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TaskCompletionSource<DKOGBMCLJPM> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public DBIKLGMICGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7160BD0", Offset = "0x715F9D0", VA = "0x187160BD0")]
		internal void OJFODKGMBEJ()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct PDELLJDPDBM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ICollection<TaskCompletionSource<DKOGBMCLJPM>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private DBIKLGMICGL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<DKOGBMCLJPM> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7163A60", Offset = "0x7162860", VA = "0x187163A60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x71640D0", Offset = "0x7162ED0", VA = "0x1871640D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly GJHMBELIBNP HPCGOKOHBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly PDCGNIPIMOJ MLJALCCOHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly DPIEDOFFLCF HMHLOFOACGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly OGONOFCBGBB EEOFCPPBILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BFGDOKOKOHB JFABNNLFOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> NDKGCBKEGLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly DBECEJLBJCF ABIDMIHPCAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly DBECEJLBJCF FKGEFEDONFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource PHAIBFPFPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken FKFDDGCCMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly KJCHFGEFOPE<LNJPDINAFGA> AKIKOLDCFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object FDKLIIIJNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object KOEPPPGMHOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<DKOGBMCLJPM>> LLMBIHHLHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<DKOGBMCLJPM>> GIMHEDIDNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private DKOGBMCLJPM ODHHGKBFHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal bool OMIDFFOPLKK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool KHLIFAMJOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7161AA0", Offset = "0x71608A0", VA = "0x187161AA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DDFAKCNDKEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7161810", Offset = "0x7160610", VA = "0x187161810", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool JFHNBGNIBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7161A90", Offset = "0x7160890", VA = "0x187161A90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float FLNJJGLFDAL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xACAC30", Offset = "0xAC9A30", VA = "0x180ACAC30", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xB30D70", Offset = "0xB2FB70", VA = "0x180B30D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private DKOGBMCLJPM ICKKEMKPCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xC75820", Offset = "0xC74620", VA = "0x180C75820")]
		get
		{
			return default(DKOGBMCLJPM);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7162320", Offset = "0x7161120", VA = "0x187162320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool PDOHAIJEGKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7161B80", Offset = "0x7160980", VA = "0x187161B80", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<DKOGBMCLJPM> LMHOBBOJDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7162680", Offset = "0x7161480", VA = "0x187162680")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7161AC0", Offset = "0x71608C0", VA = "0x187161AC0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7162DB0", Offset = "0x7161BB0", VA = "0x187162DB0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JNGCHOPMLAM([MHFJPMCEEAM(null)] GJHMBELIBNP HPCGOKOHBNH, [MHFJPMCEEAM(null)] PDCGNIPIMOJ MLJALCCOHFD, [MHFJPMCEEAM(null)] DPIEDOFFLCF HMHLOFOACGH, [MHFJPMCEEAM("CameraFadeTimeoutDetector")] OGONOFCBGBB EEOFCPPBILM, [MHFJPMCEEAM(null)] BFGDOKOKOHB JFABNNLFOFD, [MHFJPMCEEAM(null)] HGDALPBEPLL<CameraFadeOptions> IDEGCFOPFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7162E00", Offset = "0x7161C00", VA = "0x187162E00")]
	internal JNGCHOPMLAM(GJHMBELIBNP HPCGOKOHBNH, PDCGNIPIMOJ MLJALCCOHFD, DPIEDOFFLCF HMHLOFOACGH, OGONOFCBGBB EEOFCPPBILM, BFGDOKOKOHB JFABNNLFOFD, HGDALPBEPLL<CameraFadeOptions> IDEGCFOPFGC, Func<Task>? NDKGCBKEGLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7161C30", Offset = "0x7160A30", VA = "0x187161C30", Slot = "8")]
	public MECFKNCPAJB EHOAPPMEHDG(LNJPDINAFGA HACFGBHNOCC, [Optional] JHABKOKJCFM? MGGMACBHAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7162C30", Offset = "0x7161A30", VA = "0x187162C30", Slot = "9")]
	[AsyncStateMachine(typeof(LEINCHPAINC))]
	public Task PIMIGMLEDNL([Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7162740", Offset = "0x7161540", VA = "0x187162740", Slot = "10")]
	public IReadOnlyCollection<LNJPDINAFGA> KEKINDLAAGD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x71628C0", Offset = "0x71616C0", VA = "0x1871628C0")]
	internal void MGDKCELMGBN(LNJPDINAFGA HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7162890", Offset = "0x7161690", VA = "0x187162890")]
	private IJCLJOBCMLG MGAMCJEJDLK()
	{
		return default(IJCLJOBCMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x71624A0", Offset = "0x71612A0", VA = "0x1871624A0")]
	private IJCLJOBCMLG GJAFNNBCGCG()
	{
		return default(IJCLJOBCMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x71624D0", Offset = "0x71612D0", VA = "0x1871624D0")]
	internal void GPFKPJFHHGG(LNJPDINAFGA HACFGBHNOCC, JHABKOKJCFM MBPFOBAAEHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7161960", Offset = "0x7160760", VA = "0x187161960")]
	private static void BHMABGLMAGM(IReadOnlyList<TaskCompletionSource<DKOGBMCLJPM>> KEHKDADDKHF, DKOGBMCLJPM COLJHPOCLEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7161680", Offset = "0x7160480", VA = "0x187161680")]
	private void AILPAELOMGD(float BPKDJPMPPIM, Func<IJCLJOBCMLG> FMCBBMOBAHG, DKOGBMCLJPM DFLDODPDCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x71622A0", Offset = "0x71610A0", VA = "0x1871622A0")]
	private static bool ENFEONPFGJN(float HJGGLHBFMKO, float AGAPPIBJJBC, float FBCACOLPBOC = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7161820", Offset = "0x7160620", VA = "0x187161820")]
	[AsyncStateMachine(typeof(PEABNLEFNNG))]
	private Task BFGBHPACAGF(CancellationToken JHKFKNKNOJO, float BPKDJPMPPIM, Func<IJCLJOBCMLG> PBNEDECJGOE, DKOGBMCLJPM DFLDODPDCIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7162790", Offset = "0x7161590", VA = "0x187162790")]
	private void KNBFAPDKPNA(float NEOECMIPNOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7162B40", Offset = "0x7161940", VA = "0x187162B40")]
	[AsyncStateMachine(typeof(IBIAFPPKMPM))]
	internal Task NOOOBNJCDIG([Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7162A40", Offset = "0x7161840", VA = "0x187162A40")]
	[AsyncStateMachine(typeof(PDELLJDPDBM))]
	private static Task MLJKPEOMNKD(ICollection<TaskCompletionSource<DKOGBMCLJPM>> KEHKDADDKHF, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7161BF0", Offset = "0x71609F0", VA = "0x187161BF0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class CHICCDNDEDO : MECFKNCPAJB, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct INPMGPKBGGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public CHICCDNDEDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x71613A0", Offset = "0x71601A0", VA = "0x1871613A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7161620", Offset = "0x7160420", VA = "0x187161620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly string GJNPPLPELIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly PJHHGAKMFFO DGFDFJJPAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly JNGCHOPMLAM IMNGJMLKNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly LNJPDINAFGA HACFGBHNOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool EICHBLDJPCE;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x7160570", Offset = "0x715F370", VA = "0x187160570")]
	internal CHICCDNDEDO(JNGCHOPMLAM IMNGJMLKNLD, LNJPDINAFGA HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7160240", Offset = "0x715F040", VA = "0x187160240", Slot = "4")]
	[AsyncStateMachine(typeof(INPMGPKBGGK))]
	public Task AAHIOABCCAI([Optional] CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x7160330", Offset = "0x715F130", VA = "0x187160330", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct IJCLJOBCMLG : IEquatable<IJCLJOBCMLG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool EMKPCOEJMLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly float JDHIMHACCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly float PDHDLDGHGKK;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x71612D0", Offset = "0x71600D0", VA = "0x1871612D0")]
	public IJCLJOBCMLG(float OFFAANAINOC, float ENFBFHBOFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x7161170", Offset = "0x715FF70", VA = "0x187161170", Slot = "4")]
	public bool Equals(IJCLJOBCMLG LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x71610C0", Offset = "0x715FEC0", VA = "0x1871610C0", Slot = "0")]
	public override bool Equals(object? JOOHPPHJKMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x71611B0", Offset = "0x715FFB0", VA = "0x1871611B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7161230", Offset = "0x7160030", VA = "0x187161230", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class DBECEJLBJCF
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum NIACHBBCONO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly NIACHBBCONO AFKFMDKDOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<object, IJCLJOBCMLG> NGHIGBHFKFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly IJCLJOBCMLG NKNFOPAIIKI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IJCLJOBCMLG HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xBD6790", Offset = "0xBD5590", VA = "0x180BD6790")]
		[CompilerGenerated]
		get
		{
			return default(IJCLJOBCMLG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xBD68D0", Offset = "0xBD56D0", VA = "0x180BD68D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x7160B10", Offset = "0x715F910", VA = "0x187160B10")]
	public DBECEJLBJCF(NIACHBBCONO AFKFMDKDOIO, IJCLJOBCMLG NKNFOPAIIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x71609A0", Offset = "0x715F7A0", VA = "0x1871609A0")]
	public void MNLFLPNEHBH(object HACFGBHNOCC, IJCLJOBCMLG ICGMGMINBPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7160890", Offset = "0x715F690", VA = "0x187160890")]
	public void IEINLEAGPOE(object HACFGBHNOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7160AC0", Offset = "0x715F8C0", VA = "0x187160AC0")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7160900", Offset = "0x715F700", VA = "0x187160900")]
	private void JOECBMHDLII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7160850", Offset = "0x715F650", VA = "0x187160850")]
	private IJCLJOBCMLG FOKCCBPKBPH()
	{
		return default(IJCLJOBCMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7160810", Offset = "0x715F610", VA = "0x187160810")]
	private IJCLJOBCMLG EIHKKNFKGAB()
	{
		return default(IJCLJOBCMLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7160670", Offset = "0x715F470", VA = "0x187160670")]
	private IJCLJOBCMLG EADBAGPCCGG(int CAKHLKBKKOG)
	{
		return default(IJCLJOBCMLG);
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
