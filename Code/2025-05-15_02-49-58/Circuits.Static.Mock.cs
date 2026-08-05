using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27C4850", Offset = "0x27C2E50", VA = "0x1827C4850")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class GJLEIFMOAOI<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, GAIDIFCBGED.GEGLOHJNKDC<TAction, TNetSys> where TReceiverDeps : notnull, GAIDIFCBGED.ADHEJIAJDIB<TAction, TReceiver> where TRootDeps : notnull, GAIDIFCBGED.FNDPPMMAIMC<LKLNHBLJDLM, TAction, TRoot> where TRoot : notnull where TDeps : notnull, GAIDIFCBGED.NJHFAJFJHKA<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class MHNLOPIALCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? NBACNFHHJHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<DJBBEMIADHG<TAction>> JMAIGBFGBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool DOFMFAPNLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> GEJMEFMIGGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool DCDOOLPKLPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? LEMGLMEBIJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly AMFPENCNKGE<LKLNHBLJDLM, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> EMBMELOELJG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool KHENOLDDNCG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x535BA70", Offset = "0x535A070", VA = "0x18535BA70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x535BB10", Offset = "0x535A110", VA = "0x18535BB10")]
		public MHNLOPIALCB(int? MNCEBEOEHAO, List<DJBBEMIADHG<TAction>> ECNAHNAKCAB, bool LEMNBIAIFLJ, List<Func<Task>> BNCDPLJNAAI, bool BJBGLABDAMH, TAction[]? FBPPHHBBJNA, AMFPENCNKGE<LKLNHBLJDLM, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> HIEGHANFGIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x535B7F0", Offset = "0x5359DF0", VA = "0x18535B7F0")]
		public static GJLEIFMOAOI<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.MHNLOPIALCB ACADPGMDEBE(TDeps MMCKJCAOGBM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DHOGLBMHKDB
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
			public DHOGLBMHKDB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4075DF0", Offset = "0x40743F0", VA = "0x184075DF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x40765B0", Offset = "0x4074BB0", VA = "0x1840765B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public MHNLOPIALCB client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public EDBALDILLBK<FKBNPBHMLOJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<HHHCCNLMPJL<object?, DLKBDBKHJCC>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DHOGLBMHKDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F0B0", Offset = "0x6A3D6B0", VA = "0x186A3F0B0")]
		[AsyncStateMachine(typeof(GJLEIFMOAOI<, , , , , , , >.DHOGLBMHKDB.<<SendActionToAll>b__0>d))]
		internal Task KBJDGOLHHPC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct AFDENCLKCNF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GJLEIFMOAOI<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public EDBALDILLBK<FKBNPBHMLOJ> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public EDBALDILLBK<FKBNPBHMLOJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public EDBALDILLBK<LKLNHBLJDLM> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private TaskAwaiter<HHHCCNLMPJL<object, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4A7D4F0", Offset = "0x4A7BAF0", VA = "0x184A7D4F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4A7D9D0", Offset = "0x4A7BFD0", VA = "0x184A7D9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private MDCFHPFNPDO<FKBNPBHMLOJ, MHNLOPIALCB> JKJLLCPKDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<DJBBEMIADHG<TAction>> HADEEJLEHIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int PILNBKGCCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int OAILKEDCEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int DANBGCIHNGA;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4AC37C0", Offset = "0x4AC1DC0", VA = "0x184AC37C0")]
	public GJLEIFMOAOI(int OAGNJDPBKLO, int NDMGGKPPPEI, int EMANABNNGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4AC20B0", Offset = "0x4AC06B0", VA = "0x184AC20B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2030", Offset = "0x4AC0630", VA = "0x184AC2030")]
	public void DLEFJAMGNIF(EDBALDILLBK<FKBNPBHMLOJ> GMGHHBHDHEG, TDeps MMCKJCAOGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4AC20F0", Offset = "0x4AC06F0", VA = "0x184AC20F0")]
	public void JACMAKCGDNN(EDBALDILLBK<FKBNPBHMLOJ> GMGHHBHDHEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2FA0", Offset = "0x4AC15A0", VA = "0x184AC2FA0")]
	public void KPJFLKDLEKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4AC23C0", Offset = "0x4AC09C0", VA = "0x184AC23C0")]
	public (Task, Task[]) JLIINDMBLNI(TRoot KNNDNAPJIDP, [In] HJDCHFHKCJH<FKBNPBHMLOJ> FKGCCNLGFOE, [In] MDCFHPFNPDO<FKBNPBHMLOJ, TNetSys> KDHMLHFFHHB, [In] MDCFHPFNPDO<FKBNPBHMLOJ, TReceiver> NGHIAOIJEEE, EDBALDILLBK<FKBNPBHMLOJ> IJAHNOHAHPB, EDBALDILLBK<LKLNHBLJDLM> IELIEGDMFFE, TAction BDCLNIJAFBF)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2860", Offset = "0x4AC0E60", VA = "0x184AC2860")]
	public Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> JLIINDMBLNI(TRoot KNNDNAPJIDP, TNetSys OHEIAKHGGAM, EDBALDILLBK<FKBNPBHMLOJ> IJAHNOHAHPB, TAction BDCLNIJAFBF, bool CKEAKKIBMKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AC2FF0", Offset = "0x4AC15F0", VA = "0x184AC2FF0")]
	[AsyncStateMachine(typeof(GJLEIFMOAOI<, , , , , , , >.AFDENCLKCNF))]
	public Task LAPMPJGNIMF(TRoot KNNDNAPJIDP, TNetSys CCPPJJBKAPH, TReceiver NGKGGMDFKFD, EDBALDILLBK<FKBNPBHMLOJ> MFEDKILKNPJ, EDBALDILLBK<FKBNPBHMLOJ> IJAHNOHAHPB, EDBALDILLBK<LKLNHBLJDLM> IELIEGDMFFE, TAction BDCLNIJAFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4AC32A0", Offset = "0x4AC18A0", VA = "0x184AC32A0")]
	public Task OCIHFFEGJGE(TRoot KNNDNAPJIDP, TNetSys CCPPJJBKAPH, TReceiver NGKGGMDFKFD, EDBALDILLBK<FKBNPBHMLOJ> MFEDKILKNPJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct DJBBEMIADHG<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly EDBALDILLBK<FKBNPBHMLOJ> JFBHAEJBPPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly EDBALDILLBK<LKLNHBLJDLM> AFGKMCHFADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction AGDACFKAIAI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xC18420", Offset = "0xC16A20", VA = "0x180C18420")]
	public DJBBEMIADHG(EDBALDILLBK<FKBNPBHMLOJ> GIBLACJPDHG, EDBALDILLBK<LKLNHBLJDLM> IELIEGDMFFE, TAction BDCLNIJAFBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class CLJHPHOPMLC
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3659A60", Offset = "0x3658060", VA = "0x183659A60")]
	public static DJBBEMIADHG<TAction> ACADPGMDEBE<TAction>(EDBALDILLBK<FKBNPBHMLOJ> GIBLACJPDHG, EDBALDILLBK<LKLNHBLJDLM> IELIEGDMFFE, TAction BDCLNIJAFBF) where TAction : notnull
	{
		return default(DJBBEMIADHG<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class GLHHNJIJJPN<TRoot, TDeps> : HNNMKAAPCJH where TRoot : notnull where TDeps : notnull, IFKIFHGMBKH.FGKKLEBHCAO<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GBIOICIEIEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public GLHHNJIJJPN<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public AFPLFKDKJPC action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<HHHCCNLMPJL<object?, DLKBDBKHJCC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4A9E490", Offset = "0x4A9CA90", VA = "0x184A9E490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4A9EA90", Offset = "0x4A9D090", VA = "0x184A9EA90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps IJFOHHKJJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot KHHKDJGNINC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public EDBALDILLBK<FKBNPBHMLOJ> GHLLDLDGGII
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBF5280", Offset = "0xBF3880", VA = "0x180BF5280")]
		[CompilerGenerated]
		get
		{
			return default(EDBALDILLBK<FKBNPBHMLOJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2C60E00", Offset = "0x2C5F400", VA = "0x182C60E00")]
	public GLHHNJIJJPN(TDeps MMCKJCAOGBM, TRoot KNNDNAPJIDP, EDBALDILLBK<FKBNPBHMLOJ> DIIJCPLHBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4AC6BA0", Offset = "0x4AC51A0", VA = "0x184AC6BA0", Slot = "4")]
	[AsyncStateMachine(typeof(GLHHNJIJJPN<, >.GBIOICIEIEH))]
	public Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> JLIINDMBLNI(AFPLFKDKJPC BDCLNIJAFBF, bool CKEAKKIBMKM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IFKIFHGMBKH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FGKKLEBHCAO<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HHHCCNLMPJL<object, DLKBDBKHJCC>> JLIINDMBLNI(TRoot KNNDNAPJIDP, EDBALDILLBK<FKBNPBHMLOJ> IJAHNOHAHPB, AFPLFKDKJPC BDCLNIJAFBF, bool CKEAKKIBMKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JPPAOOHINKK : JKDCNEKHLLH
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void KFANDNCNOHL();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly JPPAOOHINKK MLIJHBGBMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KFANDNCNOHL? DFOEOPPPIIB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public JPPAOOHINKK([Optional] KFANDNCNOHL? NKNLBLMCKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x113DFD0", Offset = "0x113C5D0", VA = "0x18113DFD0", Slot = "4")]
	public void MGFKALCJCEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class CICPJDINDPA : CNEPDHFEGMD
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void NIHJHBGEICN(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void NNLJOCHBFHO(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void NIMAGLKIEGI(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly CICPJDINDPA MLIJHBGBMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NIHJHBGEICN? FODOAKJJAEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NNLJOCHBFHO? CFNBFMAJDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly NIMAGLKIEGI? IEAOCMNEALG;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xC46E90", Offset = "0xC45490", VA = "0x180C46E90")]
	public CICPJDINDPA([Optional] NIHJHBGEICN? KIICLACFJDM, [Optional] NNLJOCHBFHO? JAPAIECGIDL, [Optional] NIMAGLKIEGI? LGAIEDIOHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x27C45F0", Offset = "0x27C2BF0", VA = "0x1827C45F0", Slot = "4")]
	public void OnEdgeDidAdd(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x27C4610", Offset = "0x27C2C10", VA = "0x1827C4610", Slot = "5")]
	public void OnEdgeWillRemove(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<MBCPFFKFBDC> DNALEDMNCKH, EDBALDILLBK<AIHJLHNMKCJ> EMINHKBJOFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27C45D0", Offset = "0x27C2BD0", VA = "0x1827C45D0", Slot = "6")]
	public void EJDBBIPOJCK(EDBALDILLBK<BIEIIMCKPHN> KJCOKJBCCGD, EDBALDILLBK<ALEKBGLLPHJ> MIEKOPKCEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "9")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "10")]
	public void OnEditGraphDidPop()
	{
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
