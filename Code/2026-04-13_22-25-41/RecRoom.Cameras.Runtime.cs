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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x97109D0", Offset = "0x970F3D0", VA = "0x1897109D0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x9710950", Offset = "0x970F350", VA = "0x189710950", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Cameras.Effects
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[Tested]
	public class CameraFade : DHHTRSYXRJU, IDisposable
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
		private class CSGLFQYQRIT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public FadeState GKIPGNWBXCT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public int UIAAABRMZXG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public CancellationTokenSource EHQPSGDDCBC;

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x9326340", Offset = "0x9324D40", VA = "0x189326340")]
			public CSGLFQYQRIT(FadeState a, int b, CancellationTokenSource c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class AHOMGQIPSTG
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			private struct <<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public AHOMGQIPSTG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000034")]
				private List<TaskCompletionSource<FadeState>> <awaitersToNotify>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x4000035")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0x97126D0", Offset = "0x97110D0", VA = "0x1897126D0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x9712BE0", Offset = "0x97115E0", VA = "0x189712BE0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public CameraFade DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public CSGLFQYQRIT EAUGOBRUGEX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public CancellationToken XKCAMCSUPQU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public FadeState KSJTYEXLNHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public object ULJZNBXBOBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public float UKBEWOLJXOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public int UIAAABRMZXG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public FadeState BGUSMBBNOSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public CancellationToken ZEEGQZQQUPF;

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public AHOMGQIPSTG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x970E620", Offset = "0x970D020", VA = "0x18970E620")]
			[AsyncStateMachine(typeof(<<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|0>d))]
			internal Task VEPPQOOYTMB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class YHTYVRENSLP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public TaskCompletionSource<FadeState> VRLFPLAXGXU;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public YHTYVRENSLP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9713D30", Offset = "0x9712730", VA = "0x189713D30")]
			internal void EBJWIDWDING()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <RegisterNewWaitForTask>d__65 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public ICollection<TaskCompletionSource<FadeState>> tcsList;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private YHTYVRENSLP <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private IDisposable <registration>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private TaskAwaiter<FadeState> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9710D30", Offset = "0x970F730", VA = "0x189710D30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9711540", Offset = "0x970FF40", VA = "0x189711540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <RunTransitionAsync>d__62 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public CameraFade <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public CSGLFQYQRIT transitionTaskState;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public float endOpacity;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public CancellationToken systemDisposalToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public Func<FadeRate> durationFetch;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private AHOMGQIPSTG <>8__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			private CancellationTokenSource <cts>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			private object <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int <>7__wrap3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private float? <lastFadeSlope>5__5;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private float <lerpTimeStart>5__6;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private float <lerpTimeEnd>5__7;

			[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			private float <lerpStartValue>5__8;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private float <lerpEndValue>5__9;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x97115A0", Offset = "0x970FFA0", VA = "0x1897115A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9712670", Offset = "0x9711070", VA = "0x189712670", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private struct <WaitForFadeToBlack>d__64 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public CameraFade <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private CancellationTokenSource <tokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9713000", Offset = "0x9711A00", VA = "0x189713000", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9713440", Offset = "0x9711E40", VA = "0x189713440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <WaitForFadeToCamera>d__51 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public CameraFade <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private CancellationTokenSource <tokenSource>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x97134A0", Offset = "0x9711EA0", VA = "0x1897134A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x97138E0", Offset = "0x97122E0", VA = "0x1897138E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TTDNZSUZDGK MZDLMBZBNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private readonly BTSJKCEBAAZ NJDIMGHTKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private readonly CQTKPAWHYMF YSEFCYENSIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly VIKWRACORBK UUTMAPGEITL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly OLXSVKGLTSR JHWPGRGOPRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Func<Task> BDKYXGEGLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly ZEKIPXPUAPX JKTNCCELSAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly ZEKIPXPUAPX HBAFGBZEPCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly CancellationTokenSource RDMZBDOYDKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly CancellationToken OZLTJHKIMRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly KOYZDEQQCAJ<Token> BKJYIUPEIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly object RPVECRQAACD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly object GCHWDLZASXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<TaskCompletionSource<FadeState>> ANQMKCZQOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly List<TaskCompletionSource<FadeState>> UXISHWQFMVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<CSGLFQYQRIT> OYCQRDUMJSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private int MYEBSHDNKJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private FadeState YDCCNTNQGNU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		internal bool VDUESHREMPY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool ARRDIDHGMAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x970FB20", Offset = "0x970E520", VA = "0x18970FB20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool FUATTKSLAAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x970F700", Offset = "0x970E100", VA = "0x18970F700", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool WWKALCANUUQ
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x970FCE0", Offset = "0x970E6E0", VA = "0x18970FCE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float TLVYOYCUYYZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD98E70", Offset = "0xD97870", VA = "0x180D98E70", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xDECF90", Offset = "0xDEB990", VA = "0x180DECF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private FadeState TVKKHUAZLCN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x2E32000", Offset = "0x2E30A00", VA = "0x182E32000")]
			get
			{
				return default(FadeState);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x970E820", Offset = "0x970D220", VA = "0x18970E820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GURQHXTSZOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x970F8B0", Offset = "0x970E2B0", VA = "0x18970F8B0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x970FF00", Offset = "0x970E900", VA = "0x18970FF00")]
		private FadeState ZXSKNDBNHSO(FadeState a)
		{
			return default(FadeState);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x970EFA0", Offset = "0x970D9A0", VA = "0x18970EFA0")]
		private void EBYRUZZLEGQ(CSGLFQYQRIT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x970FCF0", Offset = "0x970E6F0", VA = "0x18970FCF0")]
		private void WSQDURRLYZB(CSGLFQYQRIT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x970E6F0", Offset = "0x970D0F0", VA = "0x18970E6F0")]
		private void ADFMEQLEMZC(FadeState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x970F5F0", Offset = "0x970DFF0", VA = "0x18970F5F0")]
		private int QIDKBAZKOAU()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9710010", Offset = "0x970EA10", VA = "0x189710010")]
		[RecRoom.NoEngine.Common.Preserve]
		public CameraFade([Inject(null)] TTDNZSUZDGK cameraRig, [Inject(null)] BTSJKCEBAAZ animateInOutSuppressionManager, [Inject(null)] CQTKPAWHYMF gameConfigsProvider, [Inject("CameraFadeTimeoutDetector")] VIKWRACORBK timeoutDetector, [Inject(null)] OLXSVKGLTSR timeService, [Inject(null)] WVKPEZKZXWE<CameraFadeOptions> options)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9710060", Offset = "0x970EA60", VA = "0x189710060")]
		internal CameraFade(TTDNZSUZDGK cameraRig, BTSJKCEBAAZ animateInOutSuppressionManager, CQTKPAWHYMF gameConfigsProvider, VIKWRACORBK timeoutDetector, OLXSVKGLTSR timeService, WVKPEZKZXWE<CameraFadeOptions> options, Func<Task>? yieldFunc)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x970E930", Offset = "0x970D330", VA = "0x18970E930", Slot = "8")]
		public VPOGTRRWOLD DIOEBEZKPZX(Token a, [Optional] CameraFadeParams? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x970FA30", Offset = "0x970E430", VA = "0x18970FA30", Slot = "9")]
		[AsyncStateMachine(typeof(<WaitForFadeToCamera>d__51))]
		public Task TJREXOSVLOY([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x970FB40", Offset = "0x970E540", VA = "0x18970FB40", Slot = "10")]
		public IReadOnlyCollection<Token> UJJSFNITIAI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x970FD80", Offset = "0x970E780", VA = "0x18970FD80")]
		internal void XEJWYMAAHCP(Token a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x970FD50", Offset = "0x970E750", VA = "0x18970FD50")]
		private FadeRate XAQPETCTJKE()
		{
			return default(FadeRate);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x970F350", Offset = "0x970DD50", VA = "0x18970F350")]
		private FadeRate FHRMOPFAYXK()
		{
			return default(FadeRate);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x970F710", Offset = "0x970E110", VA = "0x18970F710")]
		internal void RIQQLXPEUJJ(Token a, CameraFadeParams b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x970F980", Offset = "0x970E380", VA = "0x18970F980")]
		private static void RUSGAZATVQS(List<TaskCompletionSource<FadeState>> a, FadeState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x970F050", Offset = "0x970DA50", VA = "0x18970F050")]
		private void FCAKFDAGGHU(float a, Func<FadeRate> b, FadeState c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x970F480", Offset = "0x970DE80", VA = "0x18970F480")]
		private static bool GWQHFAEOFEZ(float a, float b, float c = 0.0001f)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x970FB90", Offset = "0x970E590", VA = "0x18970FB90")]
		[AsyncStateMachine(typeof(<RunTransitionAsync>d__62))]
		private Task WDAQQHLKEZM(CSGLFQYQRIT a, float b, Func<FadeRate> c, CancellationToken d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x970F600", Offset = "0x970E000", VA = "0x18970F600")]
		private void QQDSMOJBEJU(float a, int b = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x970F500", Offset = "0x970DF00", VA = "0x18970F500")]
		[AsyncStateMachine(typeof(<WaitForFadeToBlack>d__64))]
		internal Task KNAXQMRNFYS([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x970F380", Offset = "0x970DD80", VA = "0x18970F380")]
		[AsyncStateMachine(typeof(<RegisterNewWaitForTask>d__65))]
		private static Task FIWPBYSKHLM(ICollection<TaskCompletionSource<FadeState>> a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x970EF60", Offset = "0x970D960", VA = "0x18970EF60", Slot = "12")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class VVYUHSUYFLO : VPOGTRRWOLD, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		[CompilerGenerated]
		private struct <Await>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public VVYUHSUYFLO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9710A50", Offset = "0x970F450", VA = "0x189710A50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x9710CD0", Offset = "0x970F6D0", VA = "0x189710CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static readonly string YBJWRKZTSRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private readonly DisposeReminder WOBRZHDYHAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly CameraFade LQPFCRJLLSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly Token NKJFKBMZQHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private bool INFOAPNSOCD;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9713C50", Offset = "0x9712650", VA = "0x189713C50")]
		internal VVYUHSUYFLO(CameraFade a, Token b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9713AF0", Offset = "0x97124F0", VA = "0x189713AF0", Slot = "4")]
		[AsyncStateMachine(typeof(<Await>d__6))]
		public Task OLLVPKGYRGK([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9713940", Offset = "0x9712340", VA = "0x189713940", Slot = "5")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal readonly struct FadeRate : IEquatable<FadeRate>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public readonly bool Instant;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly float Slope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly float AbsSlope;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9710880", Offset = "0x970F280", VA = "0x189710880")]
		public FadeRate(float rise, float duration)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9710790", Offset = "0x970F190", VA = "0x189710790", Slot = "4")]
		public bool Equals(FadeRate other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x97106E0", Offset = "0x970F0E0", VA = "0x1897106E0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x97107B0", Offset = "0x970F1B0", VA = "0x1897107B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9710800", Offset = "0x970F200", VA = "0x189710800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	internal class ZEKIPXPUAPX
	{
		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public enum FindMethod : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			FastestFade,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			SlowestFade
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly FindMethod APTWYHHFLOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private readonly Dictionary<object, FadeRate> GFWFGCZDBTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly FadeRate TFNZEYJBKCL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public FadeRate YMGSSSXYISN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x166C780", Offset = "0x166B180", VA = "0x18166C780")]
			[CompilerGenerated]
			get
			{
				return default(FadeRate);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x166BAC0", Offset = "0x166A4C0", VA = "0x18166BAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9714220", Offset = "0x9712C20", VA = "0x189714220")]
		public ZEKIPXPUAPX(FindMethod a, FadeRate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9713E10", Offset = "0x9712810", VA = "0x189713E10")]
		public void IQHZIDOQUXJ(object a, FadeRate b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9714000", Offset = "0x9712A00", VA = "0x189714000")]
		public void Remove(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9713D80", Offset = "0x9712780", VA = "0x189713D80")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9713F20", Offset = "0x9712920", VA = "0x189713F20")]
		private void LQFXSJEWMXY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9713DD0", Offset = "0x97127D0", VA = "0x189713DD0")]
		private FadeRate EWXYJOOKZSG()
		{
			return default(FadeRate);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9713FC0", Offset = "0x97129C0", VA = "0x189713FC0")]
		private FadeRate LTQZZVICLBD()
		{
			return default(FadeRate);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9714070", Offset = "0x9712A70", VA = "0x189714070")]
		private FadeRate URUKNCTHCHV(int a)
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
