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
using RecNet;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Tokens;
using UJect.Injection;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x88B3140", Offset = "0x88B1D40", VA = "0x1888B3140")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Cameras_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x88B3020", Offset = "0x88B1C20", VA = "0x1888B3020", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Cameras.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class CameraFade : IAYHKPDKXHL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		internal enum FadeState
		{
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			Invalid,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			ShowingCamera,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			FadingToBlack,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			ShowingBlack,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			FadingToCamera
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private class ZTLLFVGRVJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public FadeState JGVCVWZYEJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public int DOUQLNKXDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public CancellationTokenSource AEZSZODGANR;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8530650", Offset = "0x852F250", VA = "0x188530650")]
			public ZTLLFVGRVJK(FadeState a, int b, CancellationTokenSource c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class NWHSPSXOTVD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public bool PGMRXDYFXWY;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public NWHSPSXOTVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x88B30A0", Offset = "0x88B1CA0", VA = "0x1888B30A0")]
			internal object ADOJELZRUJA((Token token, FadeState State, bool allFadeTokensRemoved) x)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IYYKLORVOJF
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			private struct <<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|1>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000040")]
				public IYYKLORVOJF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000041")]
				private List<TaskCompletionSource<FadeState>> <awaitersToNotify>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x88B5760", Offset = "0x88B4360", VA = "0x1888B5760", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x88B5E50", Offset = "0x88B4A50", VA = "0x1888B5E50", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int DOUQLNKXDCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public CameraFade VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public ZTLLFVGRVJK TCFDPSWTRYE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public CancellationToken AOXLOEXRQNR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public FadeState HZWQHGLKWBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public object UGYXNZYXLKR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public float XYWCUXXBVZV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public FadeState ABXBIUYYKAQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public CancellationToken BRWIXRIITRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Func<int, object> VOABNJMVDPU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			public Func<int, object> VOFIKQGSNBD;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IYYKLORVOJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x88B2EF0", Offset = "0x88B1AF0", VA = "0x1888B2EF0")]
			internal object BAOOWYOQRSL(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x88B2E90", Offset = "0x88B1A90", VA = "0x1888B2E90")]
			internal object BAJHZRUTIHC(int a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x88B2F50", Offset = "0x88B1B50", VA = "0x1888B2F50")]
			[AsyncStateMachine(typeof(<<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|1>d))]
			internal Task NWRUGIHLOKV()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private sealed class GVPOHBQMARY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public TaskCompletionSource<FadeState> JDNGBXHNYRH;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GVPOHBQMARY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x88B2E40", Offset = "0x88B1A40", VA = "0x1888B2E40")]
			internal void BLUPULPNYVP()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <RegisterNewWaitForTask>d__65 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public ICollection<TaskCompletionSource<FadeState>> tcsList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private GVPOHBQMARY <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private IDisposable <registration>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private TaskAwaiter<FadeState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x88B3740", Offset = "0x88B2340", VA = "0x1888B3740", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x88B3F60", Offset = "0x88B2B60", VA = "0x1888B3F60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <RunTransitionAsync>d__62 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public CameraFade <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public ZTLLFVGRVJK transitionTaskState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float endOpacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public CancellationToken systemDisposalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private IYYKLORVOJF <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Func<FadeRate> durationFetch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private CancellationTokenSource <cts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private float? <lastFadeSlope>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			private float <lerpTimeStart>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private float <lerpTimeEnd>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private float <lerpStartValue>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private float <lerpEndValue>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x88B3FC0", Offset = "0x88B2BC0", VA = "0x1888B3FC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x88B5700", Offset = "0x88B4300", VA = "0x1888B5700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <WaitForFadeToBlack>d__64 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public CameraFade <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private CancellationTokenSource <tokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x88B67D0", Offset = "0x88B53D0", VA = "0x1888B67D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x88B6C10", Offset = "0x88B5810", VA = "0x1888B6C10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <WaitForFadeToCamera>d__51 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public CameraFade <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private CancellationTokenSource <tokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x88B6C70", Offset = "0x88B5870", VA = "0x1888B6C70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x88B70B0", Offset = "0x88B5CB0", VA = "0x1888B70B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly SQLLGURPDAX EIQBGSHLMTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly WIAMBHWBQTM RWFLLVBIUGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly EDFELDUZHLG RBMDHMRKJCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly SUINRICUHZP GZSCRWRLOYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly ONXPLJRQFYA QUZSKPCYYKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Func<Task> QFJOCRQBDCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly ARXTMFLBYDS MXVIHAHAMXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly ARXTMFLBYDS RRVNUCIZDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly CancellationTokenSource SFGJTKKUEVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly CancellationToken VQCZGPOIGDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly ELMPTLKJSVI<Token> SDRWAFJVEZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly object KKMBJSMYMWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly object EAFRYYQRIMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<TaskCompletionSource<FadeState>> RRFWSJAEXWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<TaskCompletionSource<FadeState>> ZNMXDQDRLZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<ZTLLFVGRVJK> ODLAQGREHOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int UIXPBIPBGCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FadeState JLKDVULQQGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal bool UYYBXWDPJLF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ALLQAVDJATO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x88B0AD0", Offset = "0x88AF6D0", VA = "0x1888B0AD0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool VSFCAPDBIVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x88B1100", Offset = "0x88AFD00", VA = "0x1888B1100", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DEMCVQSHMNR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x88B03B0", Offset = "0x88AEFB0", VA = "0x1888B03B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float KKPLGKOYVCI
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xDF1180", Offset = "0xDEFD80", VA = "0x180DF1180", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE807A0", Offset = "0xE7F3A0", VA = "0x180E807A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private FadeState ATFCPMVDCPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x3085020", Offset = "0x3083C20", VA = "0x183085020")]
			get
			{
				return default(FadeState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x88B06A0", Offset = "0x88AF2A0", VA = "0x1888B06A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KQOUTLQMHTF
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x88B1420", Offset = "0x88B0020", VA = "0x1888B1420", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88B23F0", Offset = "0x88B0FF0", VA = "0x1888B23F0")]
		private FadeState ZYYQIPWWLZB(FadeState a)
		{
			return default(FadeState);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88B2340", Offset = "0x88B0F40", VA = "0x1888B2340")]
		private void ZNYBASEXYLD(ZTLLFVGRVJK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88B17F0", Offset = "0x88B03F0", VA = "0x1888B17F0")]
		private void MIONGRHNHAW(ZTLLFVGRVJK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88B03F0", Offset = "0x88AEFF0", VA = "0x1888B03F0")]
		private void CQWTYZFXLVN(FadeState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x88B0690", Offset = "0x88AF290", VA = "0x1888B0690")]
		private int CSWUJTMQBWR()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x88B2B80", Offset = "0x88B1780", VA = "0x1888B2B80")]
		[RecRoom.NoEngine.Common.Preserve]
		public CameraFade([Inject(null)] SQLLGURPDAX cameraRig, [Inject(null)] WIAMBHWBQTM animateInOutSuppressionManager, [Inject(null)] EDFELDUZHLG gameConfigsProvider, [Inject("CameraFadeTimeoutDetector")] SUINRICUHZP timeoutDetector, [Inject(null)] ONXPLJRQFYA timeService, [Inject(null)] DAYZJXRBYGJ<CameraFadeOptions> options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x88B2500", Offset = "0x88B1100", VA = "0x1888B2500")]
		internal CameraFade(SQLLGURPDAX cameraRig, WIAMBHWBQTM animateInOutSuppressionManager, EDFELDUZHLG gameConfigsProvider, SUINRICUHZP timeoutDetector, ONXPLJRQFYA timeService, DAYZJXRBYGJ<CameraFadeOptions> options, Func<Task>? yieldFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x88B1CF0", Offset = "0x88B08F0", VA = "0x1888B1CF0", Slot = "8")]
		public OIFFNCMBAPW XMZUBXAPZXK(Token a, [Optional] CameraFadeParams? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88B1110", Offset = "0x88AFD10", VA = "0x1888B1110", Slot = "9")]
		[AsyncStateMachine(typeof(<WaitForFadeToCamera>d__51))]
		public Task KOHLPNWYZHV([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88B0AF0", Offset = "0x88AF6F0", VA = "0x1888B0AF0", Slot = "10")]
		public IReadOnlyCollection<Token> FSMIYGHUKSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x88B0B40", Offset = "0x88AF740", VA = "0x1888B0B40")]
		internal void GUHDNNRXJIK(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x88B1940", Offset = "0x88B0540", VA = "0x1888B1940")]
		private FadeRate QEZKJTXPOGF()
		{
			return default(FadeRate);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x88B03C0", Offset = "0x88AEFC0", VA = "0x1888B03C0")]
		private FadeRate BETQEFQXICX()
		{
			return default(FadeRate);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x88B0930", Offset = "0x88AF530", VA = "0x1888B0930")]
		internal void ELWCYUKSVMC(Token a, CameraFadeParams b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x88B1200", Offset = "0x88AFE00", VA = "0x1888B1200")]
		private static void KORWQVKZXLJ(List<TaskCompletionSource<FadeState>> a, FadeState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88B14F0", Offset = "0x88B00F0", VA = "0x1888B14F0")]
		private void LRMKCJJRUQR(float a, Func<FadeRate> b, FadeState c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88B1080", Offset = "0x88AFC80", VA = "0x1888B1080")]
		private static bool IPDJGDDEMKS(float a, float b, float c = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88B0F30", Offset = "0x88AFB30", VA = "0x1888B0F30")]
		[AsyncStateMachine(typeof(<RunTransitionAsync>d__62))]
		private Task HHDDKQSHABR(ZTLLFVGRVJK a, float b, Func<FadeRate> c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88B1A70", Offset = "0x88B0670", VA = "0x1888B1A70")]
		private void WLMZZCVKIXR(float a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88B1850", Offset = "0x88B0450", VA = "0x1888B1850")]
		[AsyncStateMachine(typeof(<WaitForFadeToBlack>d__64))]
		internal Task OXDZBXVCXPR([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88B1970", Offset = "0x88B0570", VA = "0x1888B1970")]
		[AsyncStateMachine(typeof(<RegisterNewWaitForTask>d__65))]
		private static Task QHOMHLNBWMT(ICollection<TaskCompletionSource<FadeState>> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88B08F0", Offset = "0x88AF4F0", VA = "0x1888B08F0", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class RMQTNEVGMGL : OIFFNCMBAPW, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private struct <Await>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public RMQTNEVGMGL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88B3460", Offset = "0x88B2060", VA = "0x1888B3460", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x88B36E0", Offset = "0x88B22E0", VA = "0x1888B36E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private static readonly string VMLDWYYUVLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly EATWKRGETKI WZJVJTQFRQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly CameraFade DAVMPNPSUDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly Token KFRYZTAHFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private bool DDIOUOLRIDQ;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88B3370", Offset = "0x88B1F70", VA = "0x1888B3370")]
		internal RMQTNEVGMGL(CameraFade a, Token b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x88B3210", Offset = "0x88B1E10", VA = "0x1888B3210", Slot = "4")]
		[AsyncStateMachine(typeof(<Await>d__6))]
		public Task GXTEMUXOUCZ([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x88B31C0", Offset = "0x88B1DC0", VA = "0x1888B31C0", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal readonly struct FadeRate : IEquatable<FadeRate>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly bool Instant;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly float Slope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly float AbsSlope;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88B2D70", Offset = "0x88B1970", VA = "0x1888B2D70")]
		public FadeRate(float rise, float duration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x88B2C80", Offset = "0x88B1880", VA = "0x1888B2C80", Slot = "4")]
		public bool Equals(FadeRate other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x88B2BD0", Offset = "0x88B17D0", VA = "0x1888B2BD0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x88B2CA0", Offset = "0x88B18A0", VA = "0x1888B2CA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x88B2CF0", Offset = "0x88B18F0", VA = "0x1888B2CF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal class ARXTMFLBYDS
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public enum FindMethod : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			FastestFade,
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			SlowestFade
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly FindMethod NQEIOTZIMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly Dictionary<object, FadeRate> VSNWUJHWSWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly FadeRate LRTJQOWBLNG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FadeRate ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x1736420", Offset = "0x1735020", VA = "0x181736420")]
			[CompilerGenerated]
			get
			{
				return default(FadeRate);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x1735D00", Offset = "0x1734900", VA = "0x181735D00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x88B0300", Offset = "0x88AEF00", VA = "0x1888B0300")]
		public ARXTMFLBYDS(FindMethod a, FadeRate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x88B01B0", Offset = "0x88AEDB0", VA = "0x1888B01B0")]
		public void SRRRFDYXFYU(object a, FadeRate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x88B0140", Offset = "0x88AED40", VA = "0x1888B0140")]
		public void Remove(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x88AFE60", Offset = "0x88AEA60", VA = "0x1888AFE60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x88AFEF0", Offset = "0x88AEAF0", VA = "0x1888AFEF0")]
		private void GKXXLIAAZXD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x88B02C0", Offset = "0x88AEEC0", VA = "0x1888B02C0")]
		private FadeRate YIKGAJOFEWT()
		{
			return default(FadeRate);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x88AFEB0", Offset = "0x88AEAB0", VA = "0x1888AFEB0")]
		private FadeRate FNRVBXGCLJC()
		{
			return default(FadeRate);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88AFF90", Offset = "0x88AEB90", VA = "0x1888AFF90")]
		private FadeRate HHCPQWMACQC(int a)
		{
			return default(FadeRate);
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
