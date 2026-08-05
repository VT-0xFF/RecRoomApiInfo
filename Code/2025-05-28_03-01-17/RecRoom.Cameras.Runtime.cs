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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C72C30", Offset = "0x7C71A30", VA = "0x187C72C30")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
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
	public class LogRegistrationIndex : FNHPAIPGMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x7C702F0", Offset = "0x7C6F0F0", VA = "0x187C702F0", Slot = "4")]
		public override void KEMEJJLNDFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[DOEGHAPPEHM]
public class NDCFFBGLHLJ : IFKLAILBPMB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	internal enum OJEMKGMAAIH
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
	private class HAFDLEMJPLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public OJEMKGMAAIH DFMINMAOEJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public int MGFMIHENMIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public CancellationTokenSource JANOHMJCACE;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7932640", Offset = "0x7931440", VA = "0x187932640")]
		public HAFDLEMJPLO(OJEMKGMAAIH DFMINMAOEJO, int MGFMIHENMIP, CancellationTokenSource JANOHMJCACE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct JCPCOHPILGC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public NDCFFBGLHLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C6FE50", Offset = "0x7C6EC50", VA = "0x187C6FE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C70290", Offset = "0x7C6F090", VA = "0x187C70290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class EBOEINMCCBM
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		private struct <<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public EBOEINMCCBM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private List<TaskCompletionSource<OJEMKGMAAIH>> <awaitersToNotify>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C72CB0", Offset = "0x7C71AB0", VA = "0x187C72CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7C731E0", Offset = "0x7C71FE0", VA = "0x187C731E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NDCFFBGLHLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public HAFDLEMJPLO transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public OJEMKGMAAIH transitionType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public object animateInOutSuppressionToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public int taskId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public OJEMKGMAAIH completionState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public EBOEINMCCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EC70", Offset = "0x7C6DA70", VA = "0x187C6EC70")]
		[AsyncStateMachine(typeof(<<RunTransitionAsync>g__CleanupStateAndNotifyWaiters|0>d))]
		internal Task ONFJDFAFMFJ()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct CMFENILINEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public NDCFFBGLHLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public HAFDLEMJPLO transitionTaskState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float endOpacity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public CancellationToken systemDisposalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public Func<IDBIIBHPGCO> durationFetch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private EBOEINMCCBM <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private CancellationTokenSource <cts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private object <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private int <>7__wrap3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private float? <lastFadeSlope>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private float <lerpTimeStart>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private float <lerpTimeEnd>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private float <lerpStartValue>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private float <lerpEndValue>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C6DB10", Offset = "0x7C6C910", VA = "0x187C6DB10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C6EC10", Offset = "0x7C6DA10", VA = "0x187C6EC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct BJEPPAHOFCD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NDCFFBGLHLJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private CancellationTokenSource <tokenSource>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C6D670", Offset = "0x7C6C470", VA = "0x187C6D670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C6DAB0", Offset = "0x7C6C8B0", VA = "0x187C6DAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private sealed class NFHLMCBCLOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public TaskCompletionSource<OJEMKGMAAIH> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public NFHLMCBCLOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7C724D0", Offset = "0x7C712D0", VA = "0x187C724D0")]
		internal void JFHDFMJDGJI()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IONPJBCMCNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public ICollection<TaskCompletionSource<OJEMKGMAAIH>> tcsList;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private NFHLMCBCLOH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private IDisposable <registration>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private TaskAwaiter<OJEMKGMAAIH> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6F580", Offset = "0x7C6E380", VA = "0x187C6F580", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6FDF0", Offset = "0x7C6EBF0", VA = "0x187C6FDF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static readonly IEBEPMGFCGH NHLEILEPJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly IIHDJNFABHA HGMANODNIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly AOJCALIFAED DKADNPFGKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly IPJEPIMCHKK FMBEDHKNIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LLHIOIFAFBN OKFIGCGIADO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly BHPMGJFNKAL JCJEHAKOCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly Func<Task> FOPJFPDICEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly GLHHINJKOCI MJFILJJPEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly GLHHINJKOCI KHOGBHFIFGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly CancellationTokenSource BCBGKFGMCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly CancellationToken JKJDAMPPPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly NJKPLOFPION<DPBIDJALKLM> PHICNNMCIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly object EHKFBNDJJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly object JDKFHPGKEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly List<TaskCompletionSource<OJEMKGMAAIH>> LCKKFGKDNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private readonly List<TaskCompletionSource<OJEMKGMAAIH>> OGGBADHKPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<HAFDLEMJPLO> JGFIBJMFPOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private int CEDNBKIJJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private OJEMKGMAAIH GOJPDDBLKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal bool HLCKNDMKLJD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LDLCNKFKBLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C71760", Offset = "0x7C70560", VA = "0x187C71760", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool ELLIFNKEFHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C70660", Offset = "0x7C6F460", VA = "0x187C70660", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NCLKNECDGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C70580", Offset = "0x7C6F380", VA = "0x187C70580", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public float JNECHBEBDEI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xC3C8E0", Offset = "0xC3B6E0", VA = "0x180C3C8E0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC83370", Offset = "0xC82170", VA = "0x180C83370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private OJEMKGMAAIH BJEDEKIAONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xDDCA90", Offset = "0xDDB890", VA = "0x180DDCA90")]
		get
		{
			return default(OJEMKGMAAIH);
		}
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C70470", Offset = "0x7C6F270", VA = "0x187C70470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HHLMCNGFLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C70590", Offset = "0x7C6F390", VA = "0x187C70590", Slot = "11")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C71950", Offset = "0x7C70750", VA = "0x187C71950")]
	private OJEMKGMAAIH NMLFEDJNCFK(OJEMKGMAAIH JNOIIIFBOLM)
	{
		return default(OJEMKGMAAIH);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C71B20", Offset = "0x7C70920", VA = "0x187C71B20")]
	private void PCKDGDEOOOP(HAFDLEMJPLO GAOJMHMOANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C71AC0", Offset = "0x7C708C0", VA = "0x187C71AC0")]
	private void PBKCHKLAJEO(HAFDLEMJPLO GAOJMHMOANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C714E0", Offset = "0x7C702E0", VA = "0x187C714E0")]
	private void KBABHBKDHMO(OJEMKGMAAIH DFMINMAOEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C70FF0", Offset = "0x7C6FDF0", VA = "0x187C70FF0")]
	private int EHIJIICEMLD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7C72480", Offset = "0x7C71280", VA = "0x187C72480")]
	[RecRoom.NoEngine.Common.Preserve]
	public NDCFFBGLHLJ([LCNEJNNIOGA(null)] IIHDJNFABHA HGMANODNIMH, [LCNEJNNIOGA(null)] AOJCALIFAED DKADNPFGKFN, [LCNEJNNIOGA(null)] IPJEPIMCHKK FMBEDHKNIIH, [LCNEJNNIOGA("CameraFadeTimeoutDetector")] LLHIOIFAFBN OKFIGCGIADO, [LCNEJNNIOGA(null)] BHPMGJFNKAL JCJEHAKOCPM, [LCNEJNNIOGA(null)] NCACABFENMC<CameraFadeOptions> FMKKHOLMGDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7C71D70", Offset = "0x7C70B70", VA = "0x187C71D70")]
	internal NDCFFBGLHLJ(IIHDJNFABHA HGMANODNIMH, AOJCALIFAED DKADNPFGKFN, IPJEPIMCHKK FMBEDHKNIIH, LLHIOIFAFBN OKFIGCGIADO, BHPMGJFNKAL JCJEHAKOCPM, NCACABFENMC<CameraFadeOptions> FMKKHOLMGDF, Func<Task>? FOPJFPDICEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7C70820", Offset = "0x7C6F620", VA = "0x187C70820", Slot = "8")]
	public GNICADJCPCM CECODFJLNOH(DPBIDJALKLM JLFLGDNCANL, [Optional] JPLANFDFAFC? AHEKEIJFPIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7C71BF0", Offset = "0x7C709F0", VA = "0x187C71BF0", Slot = "9")]
	[AsyncStateMachine(typeof(JCPCOHPILGC))]
	public Task PPOAKAAEHDA([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7C71900", Offset = "0x7C70700", VA = "0x187C71900", Slot = "10")]
	public IReadOnlyCollection<DPBIDJALKLM> NAAAHKLGFEE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C71780", Offset = "0x7C70580", VA = "0x187C71780")]
	internal void MPMCPOHENOP(DPBIDJALKLM JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C71A90", Offset = "0x7C70890", VA = "0x187C71A90")]
	private IDBIIBHPGCO OBECPCIPHNP()
	{
		return default(IDBIIBHPGCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C71080", Offset = "0x7C6FE80", VA = "0x187C71080")]
	private IDBIIBHPGCO GCPBAEOIKMF()
	{
		return default(IDBIIBHPGCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C70670", Offset = "0x7C6F470", VA = "0x187C70670")]
	internal void CCDJDLHFHOH(DPBIDJALKLM JLFLGDNCANL, JPLANFDFAFC CBDJOMANNOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C719E0", Offset = "0x7C707E0", VA = "0x187C719E0")]
	private static void OAKMMAKONGO(List<TaskCompletionSource<OJEMKGMAAIH>> EINILPNBGCI, OJEMKGMAAIH HLNLNAOFKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C710B0", Offset = "0x7C6FEB0", VA = "0x187C710B0")]
	private void HLAKNEHCHFK(float HMDDGDAPDMH, Func<IDBIIBHPGCO> MEGPCHJADMG, OJEMKGMAAIH JBIGLDDNANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C71000", Offset = "0x7C6FE00", VA = "0x187C71000")]
	private static bool GCDEIPODPFG(float CHIPBNNCPBF, float MDEAIGKHMKE, float MFHMNDJJPGF = 0.0001f)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C71610", Offset = "0x7C70410", VA = "0x187C71610")]
	[AsyncStateMachine(typeof(CMFENILINEH))]
	private Task KLIDEBFOIEG(HAFDLEMJPLO FPBINMCBFED, float HMDDGDAPDMH, Func<IDBIIBHPGCO> BPDIILAOBMN, CancellationToken IPJOAONBMHJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C70EA0", Offset = "0x7C6FCA0", VA = "0x187C70EA0")]
	private void CGBFIGPBMEH(float BHADJJFAMCA, int MGFMIHENMIP = -1)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C70380", Offset = "0x7C6F180", VA = "0x187C70380")]
	[AsyncStateMachine(typeof(BJEPPAHOFCD))]
	internal Task AELBHMDFNPB([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C713E0", Offset = "0x7C701E0", VA = "0x187C713E0")]
	[AsyncStateMachine(typeof(IONPJBCMCNN))]
	private static Task JFGMKONBGJE(ICollection<TaskCompletionSource<OJEMKGMAAIH>> EINILPNBGCI, CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C70FB0", Offset = "0x7C6FDB0", VA = "0x187C70FB0", Slot = "12")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
internal class NLCKFCPCEGP : GNICADJCPCM, IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct NKIHFJLAFMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NLCKFCPCEGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7C72520", Offset = "0x7C71320", VA = "0x187C72520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7C727A0", Offset = "0x7C715A0", VA = "0x187C727A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static readonly string OGPCBLAKMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly KPBNFJAGDEP BJEJMAIIKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private readonly NDCFFBGLHLJ CDKPMDBACAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly DPBIDJALKLM JLFLGDNCANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private bool OMPJCPABCDP;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7C72B30", Offset = "0x7C71930", VA = "0x187C72B30")]
	internal NLCKFCPCEGP(NDCFFBGLHLJ CDKPMDBACAH, DPBIDJALKLM JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x7C729B0", Offset = "0x7C717B0", VA = "0x187C729B0", Slot = "4")]
	[AsyncStateMachine(typeof(NKIHFJLAFMB))]
	public Task PDLKJFOABAE([Optional] CancellationToken GHKBKDKNIOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x7C72800", Offset = "0x7C71600", VA = "0x187C72800", Slot = "5")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
internal readonly struct IDBIIBHPGCO : IEquatable<IDBIIBHPGCO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public readonly bool BDFLBADEFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly float MIBEOIBCNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public readonly float EBHGICOAIKL;

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F4B0", Offset = "0x7C6E2B0", VA = "0x187C6F4B0")]
	public IDBIIBHPGCO(float KCFGGEPAMLD, float NFGIPBFMCLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F350", Offset = "0x7C6E150", VA = "0x187C6F350", Slot = "4")]
	public bool Equals(IDBIIBHPGCO HBLONCAMFLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F2A0", Offset = "0x7C6E0A0", VA = "0x187C6F2A0", Slot = "0")]
	public override bool Equals(object? GLEBGNJJOHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F390", Offset = "0x7C6E190", VA = "0x187C6F390", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F410", Offset = "0x7C6E210", VA = "0x187C6F410", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
internal class GLHHINJKOCI
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum IGCJDHMMFLO : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		FastestFade,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		SlowestFade
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly IGCJDHMMFLO IOLOGNBPILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<object, IDBIIBHPGCO> NFDFBGOIJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly IDBIIBHPGCO BCOHMBKEGAG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public IDBIIBHPGCO COJGBJGNJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD51020", Offset = "0xD4FE20", VA = "0x180D51020")]
		[CompilerGenerated]
		get
		{
			return default(IDBIIBHPGCO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD51160", Offset = "0xD4FF60", VA = "0x180D51160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F1E0", Offset = "0x7C6DFE0", VA = "0x187C6F1E0")]
	public GLHHINJKOCI(IGCJDHMMFLO IOLOGNBPILB, IDBIIBHPGCO BCOHMBKEGAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EE80", Offset = "0x7C6DC80", VA = "0x187C6EE80")]
	public void IJPAHEPDDKD(object JLFLGDNCANL, IDBIIBHPGCO LLEMKLFIAJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EDD0", Offset = "0x7C6DBD0", VA = "0x187C6EDD0")]
	public void FKCGDELNEED(object JLFLGDNCANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7C6ED80", Offset = "0x7C6DB80", VA = "0x187C6ED80")]
	public void CCLJDABAPHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7C6F140", Offset = "0x7C6DF40", VA = "0x187C6F140")]
	private void PMOEPOLNFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x7C6ED40", Offset = "0x7C6DB40", VA = "0x187C6ED40")]
	private IDBIIBHPGCO BGBDECAHBOI()
	{
		return default(IDBIIBHPGCO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EE40", Offset = "0x7C6DC40", VA = "0x187C6EE40")]
	private IDBIIBHPGCO HCNOOAMFEII()
	{
		return default(IDBIIBHPGCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x7C6EFA0", Offset = "0x7C6DDA0", VA = "0x187C6EFA0")]
	private IDBIIBHPGCO OJAEBNLEPDJ(int CHNDFPFDJFM)
	{
		return default(IDBIIBHPGCO);
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
