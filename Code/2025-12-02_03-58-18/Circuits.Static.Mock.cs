using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Circuits.Shared.Api;
using Circuits.Shared.Utilities;
using Circuits.Static.Api;
using Circuits.Static.Core.NetSystem;
using Circuits.Static.Mock.Core.NetSystem;
using Circuits.Static.RecRoom.Dependencies;
using Circuits.Static.RecRoom.Protobuf;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.DataStructures;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D3F40", Offset = "0x28D2B40", VA = "0x1828D3F40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAC01D0", Offset = "0xABEDD0", VA = "0x180AC01D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC0210", Offset = "0xABEE10", VA = "0x180AC0210")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace Circuits.Static.Mock.RecRoom.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public sealed class OMMXYTJGNHV<a, b, c, d, e, f, g, h> : IDisposable where a : notnull where b : notnull where c : notnull where d : notnull, BFACBNGTTJL.GGKRIQJBKVW<a, b> where e : notnull, BFACBNGTTJL.PSEMMSKKBRB<a, c> where f : notnull, BFACBNGTTJL.ZGIMNPCIEIW<a, g> where g : notnull where h : notnull, BFACBNGTTJL.LGUBDHHAHFH<d, e, f>
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		internal sealed class GHZGZDSJPWP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			internal int? VXWFORNAMBW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			internal readonly List<Func<Task>> XHUQMCQVRZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			internal bool SCKMMSUNNWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			internal readonly List<Func<Task>> PGPHEZWWFSA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			internal bool BUYJYKDDGGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			internal a[]? UQIPMESPTQV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			internal readonly MTNHRKQBEEZ<a, b, c, d, e, f, g, h> BFACBNGTTJL;

			[Cpp2IlInjected.Token(Token = "0x17000001")]
			internal bool QDDJGXUAWBA
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x4D90FF0", Offset = "0x4D8FBF0", VA = "0x184D90FF0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x4D91090", Offset = "0x4D8FC90", VA = "0x184D91090")]
			public GHZGZDSJPWP(int? a, List<Func<Task>> b, bool c, List<Func<Task>> d, bool e, a[]? pausedSnapshot, MTNHRKQBEEZ<a, b, c, d, e, f, g, h> f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x4D90E40", Offset = "0x4D8FA40", VA = "0x184D90E40")]
			public static OMMXYTJGNHV<a, b, c, d, e, f, g, h>.GHZGZDSJPWP New(h deps)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		[CompilerGenerated]
		private sealed class WNRSWAJADRM
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct <<SendActionToAll>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public WNRSWAJADRM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				private TaskCompletionSource<Result<object?, GGHDNJMZMXZ>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				private TaskAwaiter<Result<object, GGHDNJMZMXZ>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x3CB4130", Offset = "0x3CB2D30", VA = "0x183CB4130", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x3CB44A0", Offset = "0x3CB30A0", VA = "0x183CB44A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public GHZGZDSJPWP MTMSGULZJRS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public g CEBPHRDGBWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public b IZXEIMWTNXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public Id32<VXOAABITZCX> AUUKRTAMIAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public bool UVTOFAIYNGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public TaskCompletionSource<Result<object?, GGHDNJMZMXZ>> UPSUWKZBRXF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public a AWNKAJDXXTK;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public WNRSWAJADRM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x6505C80", Offset = "0x6504880", VA = "0x186505C80")]
			[AsyncStateMachine(typeof(OMMXYTJGNHV<, , , , , , , >.WNRSWAJADRM.<<SendActionToAll>b__0>d))]
			internal Task HGFXJEWGYPB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class SBNSPJVPEDH
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private struct <<ReceiveAction>b__0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public SBNSPJVPEDH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				private TaskCompletionSource<Result<object, GGHDNJMZMXZ>> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				private TaskAwaiter<Result<object, GGHDNJMZMXZ>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x3CAF350", Offset = "0x3CADF50", VA = "0x183CAF350", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x3CAF720", Offset = "0x3CAE320", VA = "0x183CAF720", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public GHZGZDSJPWP MTMSGULZJRS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public g CEBPHRDGBWL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public b UFRNRWPCTBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public c OURZZCMNOLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public Id32<VXOAABITZCX> AUUKRTAMIAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public a NBTBCYHIVUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			public TaskCompletionSource<Result<object, GGHDNJMZMXZ>> UPSUWKZBRXF;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public SBNSPJVPEDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5CFE9B0", Offset = "0x5CFD5B0", VA = "0x185CFE9B0")]
			[AsyncStateMachine(typeof(OMMXYTJGNHV<, , , , , , , >.SBNSPJVPEDH.<<ReceiveAction>b__0>d))]
			internal Task TBGVPDGIYAG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private SOAField<VXOAABITZCX, GHZGZDSJPWP> LAAAFPQJALW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<CachedAction<a>> LZJBQPADMKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public readonly int PEJQSOGYJGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public readonly int SSQRHAFZDYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public readonly int TAFPISLXTTA;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x58CED70", Offset = "0x58CD970", VA = "0x1858CED70")]
		public OMMXYTJGNHV(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58CC0D0", Offset = "0x58CACD0", VA = "0x1858CC0D0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x58CCE10", Offset = "0x58CBA10", VA = "0x1858CCE10")]
		public void JFJCCTMXIBD(Id32<VXOAABITZCX> clientId, h a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x58CEB70", Offset = "0x58CD770", VA = "0x1858CEB70")]
		public void OYXSXEKJXSD(Id32<VXOAABITZCX> clientId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x58CEC50", Offset = "0x58CD850", VA = "0x1858CEC50")]
		public void QAIXRDFEKBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x58CDD20", Offset = "0x58CC920", VA = "0x1858CDD20")]
		public Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(g a, [In] SOAId32<VXOAABITZCX> clientIds, [In] SOAField<VXOAABITZCX, b> clients, [In] SOAField<VXOAABITZCX, c> receivers, Id32<VXOAABITZCX> senderId, a b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x58CE8F0", Offset = "0x58CD4F0", VA = "0x1858CE8F0")]
		public Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(g a, b b, Id32<VXOAABITZCX> senderId, a c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x58CC110", Offset = "0x58CAD10", VA = "0x1858CC110")]
		public Task<Result<object, GGHDNJMZMXZ>> FXWPUQGUJCW(g a, b b, c c, Id32<VXOAABITZCX> receiverId, Id32<VXOAABITZCX> senderId, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x58CD400", Offset = "0x58CC000", VA = "0x1858CD400")]
		public Task JOPFHWUYINI(g a, b b, c c, Id32<VXOAABITZCX> receiverId)
		{
			return null;
		}
	}
}
namespace Circuits.Static.Mock.Core.NetSystem
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal readonly struct CachedAction<TAction> where TAction : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly Id32<VXOAABITZCX> ActorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly TAction Action;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1688A10", Offset = "0x1687610", VA = "0x181688A10")]
		public CachedAction(Id32<VXOAABITZCX> actorId, TAction action)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	internal static class QRRBVNQMXUT
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x395A910", Offset = "0x3959510", VA = "0x18395A910")]
		public static CachedAction<TAction> New<TAction>(Id32<VXOAABITZCX> actorId, TAction action) where TAction : notnull
		{
			return default(CachedAction<TAction>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public sealed class NSRRADRIHLT<a, b> : BOOLTIYANOI where a : notnull where b : notnull, GHZGZDSJPWP.LGJNITTFOIP<a>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <SendActionToAll>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public AsyncTaskMethodBuilder<Result<object?, GGHDNJMZMXZ>> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public NSRRADRIHLT<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public NOYQGYRQTEZ action;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public bool clearBufferedRpcs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TaskAwaiter<Result<object?, GGHDNJMZMXZ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x508D790", Offset = "0x508C390", VA = "0x18508D790", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x508DEF0", Offset = "0x508CAF0", VA = "0x18508DEF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly b GSCBNDREEJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly a JALSKXMEXLG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Id32<VXOAABITZCX> PNPKCJIEICO
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAA74F0", Offset = "0xAA60F0", VA = "0x180AA74F0")]
			[CompilerGenerated]
			get
			{
				return default(Id32<VXOAABITZCX>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x579F800", Offset = "0x579E400", VA = "0x18579F800")]
		public NSRRADRIHLT(b a, a b, Id32<VXOAABITZCX> localActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x579F530", Offset = "0x579E130", VA = "0x18579F530", Slot = "4")]
		[AsyncStateMachine(typeof(NSRRADRIHLT<, >.<SendActionToAll>d__6))]
		public Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(NOYQGYRQTEZ a, bool b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GHZGZDSJPWP
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public interface LGJNITTFOIP<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(Slot = "0")]
			Task<Result<object, GGHDNJMZMXZ>> LJOGCRVKTZH(a a, Id32<VXOAABITZCX> senderId, NOYQGYRQTEZ b, bool c);
		}
	}
}
namespace Circuits.Static.Mock.Api
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public sealed class AKRGEODBOQB : RWIONSQNIGM
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public delegate void OnEdgeDidAddDelegate(Id32<LJKQDQDPBOO> graphId, Id32<QOGVDVXCRZJ> srcId, Id32<WTGBYXZBMTM> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public delegate void OnEdgeWillRemoveDelegate(Id32<LJKQDQDPBOO> graphId, Id32<QOGVDVXCRZJ> srcId, Id32<WTGBYXZBMTM> dstId);

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public delegate void OnStaticNodeWillDestroyDelegate(Id32<LJKQDQDPBOO> graphId, Id32<YNBOVCHXCPU> nodeId);

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static readonly AKRGEODBOQB PGFSJHGESKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly OnEdgeDidAddDelegate? IYOIYNCLGAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private readonly OnEdgeWillRemoveDelegate? PZLBBEFZUSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private readonly OnStaticNodeWillDestroyDelegate? RYRKOYYZVNG;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xDA16A0", Offset = "0xDA02A0", VA = "0x180DA16A0")]
		public AKRGEODBOQB([Optional] OnEdgeDidAddDelegate? a, [Optional] OnEdgeWillRemoveDelegate? b, [Optional] OnStaticNodeWillDestroyDelegate? c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x28D3E60", Offset = "0x28D2A60", VA = "0x1828D3E60", Slot = "4")]
		public void OnEdgeDidAdd(Id32<LJKQDQDPBOO> graphId, Id32<QOGVDVXCRZJ> srcId, Id32<WTGBYXZBMTM> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x28D3E80", Offset = "0x28D2A80", VA = "0x1828D3E80", Slot = "5")]
		public void OnEdgeWillRemove(Id32<LJKQDQDPBOO> graphId, Id32<QOGVDVXCRZJ> srcId, Id32<WTGBYXZBMTM> dstId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x28D3E40", Offset = "0x28D2A40", VA = "0x1828D3E40", Slot = "6")]
		public void OFAPHLGJGUC(Id32<LJKQDQDPBOO> graphId, Id32<YNBOVCHXCPU> nodeId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "7")]
		public void OnFunctionDeclsRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "10")]
		public void OnObjectPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "11")]
		public void OnPlayerPropertiesRefreshed()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "12")]
		public void OnEditGraphDidPush()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "13")]
		public void OnEditGraphDidPop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "8")]
		public void WCSBEVNZELM(Id32<LXNPHCPZGGO> functionId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "9")]
		public void QXRDAHALCGE(Id32<LXNPHCPZGGO> functionId)
		{
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
