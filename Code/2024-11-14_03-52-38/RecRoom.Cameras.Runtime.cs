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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C301B0", Offset = "0x6C2F5B0", VA = "0x186C301B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
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
	public class LogRegistrationIndex : ADNHPIGEHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6C2F850", Offset = "0x6C2EC50", VA = "0x186C2F850", Slot = "4")]
		public override void CIGOIKFLIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[MMCIGIHMOCH]
public class IMNGKNDAGBH : KMFABHCMNEC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum MLEOANPPIAG
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
	private struct AIIPJOFOCFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IMNGKNDAGBH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6C2C5E0", Offset = "0x6C2B9E0", VA = "0x186C2C5E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CA20", Offset = "0x6C2BE20", VA = "0x186C2CA20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class HCKGEEDNHEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public CancellationTokenSource cts;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public HCKGEEDNHEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D990", Offset = "0x6C2CD90", VA = "0x186C2D990")]
		internal void HMLLGNBGJLP(MLEOANPPIAG fadeState)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct ODCCNCNFNKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public MLEOANPPIAG completedState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public IMNGKNDAGBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Func<OJCEEIOAGJF> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private HCKGEEDNHEF <>8__1;

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
		[Cpp2IlInjected.Address(RVA = "0x6C30230", Offset = "0x6C2F630", VA = "0x186C30230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6C31260", Offset = "0x6C30660", VA = "0x186C31260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NAANBJDGACG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public IMNGKNDAGBH <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6C2F8E0", Offset = "0x6C2ECE0", VA = "0x186C2F8E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2FD20", Offset = "0x6C2F120", VA = "0x186C2FD20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private sealed class IFHPPCIDOCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TaskCompletionSource<MLEOANPPIAG> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public IFHPPCIDOCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D9C0", Offset = "0x6C2CDC0", VA = "0x186C2D9C0")]
		internal void ANGPKJODMGH()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct BMDCNABLDDP : IAsyncStateMachine
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
		public ICollection<TaskCompletionSource<MLEOANPPIAG>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private IFHPPCIDOCH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TaskAwaiter<MLEOANPPIAG> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6C2CA80", Offset = "0x6C2BE80", VA = "0x186C2CA80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D0F0", Offset = "0x6C2C4F0", VA = "0x186C2D0F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly LBMIABIPEGM BAEFFLBDHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HCIACOOFKLH FDCALKDMJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly FGJGNMDINBC CINKBOJJCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HJIJLIPJCIF LDDJGMBDOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CCHAHIINPBN JJJCFMMGODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> BGKODDLAPCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GANBCLCHCLG IDAHNDDHDBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GANBCLCHCLG ANBKHLAIABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource GCHHJFKLENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken CNALIJCEGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly CJKNKKAGDAH<DBMONBFGKOC> BAEHLHALNBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object KJCJJNMCMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object LFEHGJNAMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<MLEOANPPIAG>> IPBCKNHLKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<MLEOANPPIAG>> ELLGDMJMJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private MLEOANPPIAG BJKOCPJIBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	internal bool KKFOFFNFCIA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PKPIGDAEOLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DEE0", Offset = "0x6C2D2E0", VA = "0x186C2DEE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool GJEBOBGLMEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DB50", Offset = "0x6C2CF50", VA = "0x186C2DB50", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BLEMBGPDHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DC60", Offset = "0x6C2D060", VA = "0x186C2DC60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float CPJIAGAHIML
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xCC5590", Offset = "0xCC4990", VA = "0x180CC5590", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCEC7C0", Offset = "0xCEBBC0", VA = "0x180CEC7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private MLEOANPPIAG IJBCPJPPMIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9713B0", Offset = "0x9707B0", VA = "0x1809713B0")]
		get
		{
			return default(MLEOANPPIAG);
		}
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6C2DF50", Offset = "0x6C2D350", VA = "0x186C2DF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool BMAFPKECJIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E4B0", Offset = "0x6C2D8B0", VA = "0x186C2E4B0", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	private event Action<MLEOANPPIAG> JBOLHEJBKKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E0D0", Offset = "0x6C2D4D0", VA = "0x186C2E0D0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2E3F0", Offset = "0x6C2D7F0", VA = "0x186C2E3F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F800", Offset = "0x6C2EC00", VA = "0x186C2F800")]
	[RecRoom.NoEngine.Common.Preserve]
	public IMNGKNDAGBH([NDMEANGLJKD(null)] LBMIABIPEGM BAEFFLBDHHF, [NDMEANGLJKD(null)] HCIACOOFKLH FDCALKDMJAI, [NDMEANGLJKD(null)] FGJGNMDINBC CINKBOJJCID, [NDMEANGLJKD("CameraFadeTimeoutDetector")] HJIJLIPJCIF LDDJGMBDOHF, [NDMEANGLJKD(null)] CCHAHIINPBN JJJCFMMGODF, [NDMEANGLJKD(null)] MJGBEPJIPCF<CameraFadeOptions> POLCFNEEHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C2F150", Offset = "0x6C2E550", VA = "0x186C2F150")]
	internal IMNGKNDAGBH(LBMIABIPEGM BAEFFLBDHHF, HCIACOOFKLH FDCALKDMJAI, FGJGNMDINBC CINKBOJJCID, HJIJLIPJCIF LDDJGMBDOHF, CCHAHIINPBN JJJCFMMGODF, MJGBEPJIPCF<CameraFadeOptions> POLCFNEEHMO, Func<Task>? BGKODDLAPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E7C0", Offset = "0x6C2DBC0", VA = "0x186C2E7C0", Slot = "8")]
	public KDLPOCPGHFC NPGEGCLNNFF(DBMONBFGKOC CFGHNHCDKCN, [Optional] PIMLDNEIEMA? OMEDDKHOJEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E190", Offset = "0x6C2D590", VA = "0x186C2E190", Slot = "9")]
	[AsyncStateMachine(typeof(AIIPJOFOCFB))]
	public Task HCCAJHOIPMM([Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DF00", Offset = "0x6C2D300", VA = "0x186C2DF00", Slot = "10")]
	public IReadOnlyCollection<DBMONBFGKOC> FOFFJHEIOEK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E640", Offset = "0x6C2DA40", VA = "0x186C2E640")]
	internal void MLOACHCGOAH(DBMONBFGKOC CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E3C0", Offset = "0x6C2D7C0", VA = "0x186C2E3C0")]
	private OJCEEIOAGJF JMHPHJJMLHI()
	{
		return default(OJCEEIOAGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E520", Offset = "0x6C2D920", VA = "0x186C2E520")]
	private OJCEEIOAGJF MJFGGEBBODB()
	{
		return default(OJCEEIOAGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DCB0", Offset = "0x6C2D0B0", VA = "0x186C2DCB0")]
	internal void EEJNPMHDICL(DBMONBFGKOC CFGHNHCDKCN, PIMLDNEIEMA HPFPLOHIODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DA10", Offset = "0x6C2CE10", VA = "0x186C2DA10")]
	private static void ALALEIFABBD(IReadOnlyList<TaskCompletionSource<MLEOANPPIAG>> FMFHIHFEEKI, MLEOANPPIAG IBGAGLJMFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EE30", Offset = "0x6C2E230", VA = "0x186C2EE30")]
	private void OFEHEFKLLDI(float OIFOPNLHACC, Func<OJCEEIOAGJF> EGFPPBJMEAA, MLEOANPPIAG IIIFEMAGAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DE60", Offset = "0x6C2D260", VA = "0x186C2DE60")]
	private static bool FIJIMMBNNFL(float FIGPMCHHKJO, float LLNOONNFEHK, float LEJDKGIOJFB = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E280", Offset = "0x6C2D680", VA = "0x186C2E280")]
	[AsyncStateMachine(typeof(ODCCNCNFNKD))]
	private Task JGGBBAJHKGL(CancellationToken FJFHCIBPLHE, float OIFOPNLHACC, Func<OJCEEIOAGJF> JGCLEBLNELG, MLEOANPPIAG IIIFEMAGAAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C2EFC0", Offset = "0x6C2E3C0", VA = "0x186C2EFC0")]
	private void OPPJAMPELJM(float KBPAJCKIMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C2E550", Offset = "0x6C2D950", VA = "0x186C2E550")]
	[AsyncStateMachine(typeof(NAANBJDGACG))]
	internal Task MJNNPICPPFN([Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DB60", Offset = "0x6C2CF60", VA = "0x186C2DB60")]
	[AsyncStateMachine(typeof(BMDCNABLDDP))]
	private static Task CJBLBAALJAF(ICollection<TaskCompletionSource<MLEOANPPIAG>> FMFHIHFEEKI, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C2DC70", Offset = "0x6C2D070", VA = "0x186C2DC70", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
internal class NGGAAFFKKNB : KDLPOCPGHFC, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GHKFIHJEIFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public NGGAAFFKKNB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D6B0", Offset = "0x6C2CAB0", VA = "0x186C2D6B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C2D930", Offset = "0x6C2CD30", VA = "0x186C2D930", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly string KAPKIBPKEPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly HLACFEIODAE KODNCECHAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private readonly IMNGKNDAGBH LCDCIFFOOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly DBMONBFGKOC CFGHNHCDKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private bool MPIODIOKEMH;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6C300B0", Offset = "0x6C2F4B0", VA = "0x186C300B0")]
	internal NGGAAFFKKNB(IMNGKNDAGBH LCDCIFFOOJN, DBMONBFGKOC CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FF30", Offset = "0x6C2F330", VA = "0x186C2FF30", Slot = "4")]
	[AsyncStateMachine(typeof(GHKFIHJEIFB))]
	public Task NMKHEALEEDO([Optional] CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6C2FD80", Offset = "0x6C2F180", VA = "0x186C2FD80", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal readonly struct OJCEEIOAGJF : IEquatable<OJCEEIOAGJF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly bool PFFDMOGNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly float NNFCIFHFKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly float EPCDMGJDOJH;

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6C314D0", Offset = "0x6C308D0", VA = "0x186C314D0")]
	public OJCEEIOAGJF(float HPFLJEMNNMI, float IKJGJGIMFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6C31370", Offset = "0x6C30770", VA = "0x186C31370", Slot = "4")]
	public bool Equals(OJCEEIOAGJF OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6C312C0", Offset = "0x6C306C0", VA = "0x186C312C0", Slot = "0")]
	public override bool Equals(object? FAKGLFFOLFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6C313B0", Offset = "0x6C307B0", VA = "0x186C313B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6C31430", Offset = "0x6C30830", VA = "0x186C31430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class GANBCLCHCLG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum GLFDAPBPIKF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private readonly GLFDAPBPIKF JACDJMFOJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly Dictionary<object, OJCEEIOAGJF> ODBDNKKMIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly OJCEEIOAGJF BEKFNGCDOHE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public OJCEEIOAGJF FDJCHKNOIDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xE4D020", Offset = "0xE4C420", VA = "0x180E4D020")]
		[CompilerGenerated]
		get
		{
			return default(OJCEEIOAGJF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xE4D280", Offset = "0xE4C680", VA = "0x180E4D280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D5F0", Offset = "0x6C2C9F0", VA = "0x186C2D5F0")]
	public GANBCLCHCLG(GLFDAPBPIKF JACDJMFOJMJ, OJCEEIOAGJF BEKFNGCDOHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D150", Offset = "0x6C2C550", VA = "0x186C2D150")]
	public void BALPAFFHJNL(object CFGHNHCDKCN, OJCEEIOAGJF EJMEDKAPJOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D270", Offset = "0x6C2C670", VA = "0x186C2D270")]
	public void BIJNEFLCHFA(object CFGHNHCDKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D2E0", Offset = "0x6C2C6E0", VA = "0x186C2D2E0")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D550", Offset = "0x6C2C950", VA = "0x186C2D550")]
	private void PEIBIICCPEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D510", Offset = "0x6C2C910", VA = "0x186C2D510")]
	private OJCEEIOAGJF NOBDIKMODPE()
	{
		return default(OJCEEIOAGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D4D0", Offset = "0x6C2C8D0", VA = "0x186C2D4D0")]
	private OJCEEIOAGJF ILDMLCPDINM()
	{
		return default(OJCEEIOAGJF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6C2D330", Offset = "0x6C2C730", VA = "0x186C2D330")]
	private OJCEEIOAGJF GHIJLFKLLLN(int EKHEMBHOBMJ)
	{
		return default(OJCEEIOAGJF);
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
