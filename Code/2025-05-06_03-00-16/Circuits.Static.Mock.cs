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
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2790F80", Offset = "0x278F780", VA = "0x182790F80")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA09330", Offset = "0xA07B30", VA = "0x180A09330")]
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
		[Cpp2IlInjected.Address(RVA = "0xA09370", Offset = "0xA07B70", VA = "0x180A09370")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class HAJBOPOAJDN<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, FJEFMNCBJDG.EPHLLDAPKBG<TAction, TNetSys> where TReceiverDeps : notnull, FJEFMNCBJDG.LOIHMJCCLFN<TAction, TReceiver> where TRootDeps : notnull, FJEFMNCBJDG.GILFMGNKHJJ<JJMFOMJPOBG, TAction, TRoot> where TRoot : notnull where TDeps : notnull, FJEFMNCBJDG.KNLPGEMLABC<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class CBONBMJLPMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? MPMHCEFOEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<AFHBANDMFIN<TAction>> KIPPFCLLNJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool OOEKNEDAGJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> CLHNINHPFAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool ECJMLMFKMFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? MELCICGBDBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly HJFPDIHBHAM<JJMFOMJPOBG, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> KJOBBDEMONB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool KOPEBGFIJKH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x630B1E0", Offset = "0x63099E0", VA = "0x18630B1E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x630B230", Offset = "0x6309A30", VA = "0x18630B230")]
		public CBONBMJLPMN(int? BBHNFMGAANL, List<AFHBANDMFIN<TAction>> EBANBCKCMOP, bool NDONLBJDPAD, List<Func<Task>> HJMOAOMPPJJ, bool DKFLAGGOGEE, TAction[]? IEHNGFHANBD, HJFPDIHBHAM<JJMFOMJPOBG, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> JKJNCGNOMJI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x630AC90", Offset = "0x6309490", VA = "0x18630AC90")]
		public static HAJBOPOAJDN<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.CBONBMJLPMN CJOJELENPLJ(TDeps ILEBEOADOPL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class GGDLPPOLCFA
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
			public GGDLPPOLCFA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3FD69C0", Offset = "0x3FD51C0", VA = "0x183FD69C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x3FD6D70", Offset = "0x3FD5570", VA = "0x183FD6D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CBONBMJLPMN client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public NLPIAAOFKEO<PIEODFHFNCJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<HCGBMJDNFKJ<object?, CPMHOEMAGED>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public GGDLPPOLCFA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4996200", Offset = "0x4994A00", VA = "0x184996200")]
		[AsyncStateMachine(typeof(HAJBOPOAJDN<, , , , , , , >.GGDLPPOLCFA.<<SendActionToAll>b__0>d))]
		internal Task DMINPPPIBLC()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct JIIACHBEIAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public HAJBOPOAJDN<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public NLPIAAOFKEO<PIEODFHFNCJ> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public NLPIAAOFKEO<PIEODFHFNCJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NLPIAAOFKEO<JJMFOMJPOBG> requestId;

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
		private TaskAwaiter<HCGBMJDNFKJ<object, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4DC3910", Offset = "0x4DC2110", VA = "0x184DC3910", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4DC42C0", Offset = "0x4DC2AC0", VA = "0x184DC42C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OABOCIAOEJE<PIEODFHFNCJ, CBONBMJLPMN> LOHHOCKOOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<AFHBANDMFIN<TAction>> EINBBMBMOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int PIMHKGINCGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int EEBOGMPMLAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int COPLNBIAFGE;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4A2BA10", Offset = "0x4A2A210", VA = "0x184A2BA10")]
	public HAJBOPOAJDN(int IIJFCNLIECA, int MBCNJKMHKPO, int IJODJCDHAKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4A2B190", Offset = "0x4A29990", VA = "0x184A2B190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A2B110", Offset = "0x4A29910", VA = "0x184A2B110")]
	public void DDEFKHANDHF(NLPIAAOFKEO<PIEODFHFNCJ> AOKFPIHOGDG, TDeps ILEBEOADOPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A2B1D0", Offset = "0x4A299D0", VA = "0x184A2B1D0")]
	public void EFMCCDLJFAN(NLPIAAOFKEO<PIEODFHFNCJ> AOKFPIHOGDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A2B9C0", Offset = "0x4A2A1C0", VA = "0x184A2B9C0")]
	public void PMAEMDIHGFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A2A940", Offset = "0x4A29140", VA = "0x184A2A940")]
	public (Task, Task[]) BNDAGKPJEFF(TRoot PNDCHGJLEGG, [In] DPFLMJLLNFF<PIEODFHFNCJ> MJBNEEDGOOE, [In] OABOCIAOEJE<PIEODFHFNCJ, TNetSys> POCPAPGBCIO, [In] OABOCIAOEJE<PIEODFHFNCJ, TReceiver> CGLAJNJJBNL, NLPIAAOFKEO<PIEODFHFNCJ> EEPMLGNKEHB, NLPIAAOFKEO<JJMFOMJPOBG> JALDPIJOHOL, TAction GFMBHCHPLDH)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A2ADE0", Offset = "0x4A295E0", VA = "0x184A2ADE0")]
	public Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> BNDAGKPJEFF(TRoot PNDCHGJLEGG, TNetSys IEFOJDMLPOO, NLPIAAOFKEO<PIEODFHFNCJ> EEPMLGNKEHB, TAction GFMBHCHPLDH, bool EOPFBMLNBOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A2B710", Offset = "0x4A29F10", VA = "0x184A2B710")]
	[AsyncStateMachine(typeof(HAJBOPOAJDN<, , , , , , , >.JIIACHBEIAA))]
	public Task JBDLGEIFEGE(TRoot PNDCHGJLEGG, TNetSys LOJNJFGGPLC, TReceiver KEEAPFDDBLD, NLPIAAOFKEO<PIEODFHFNCJ> OMKDBLNDDFM, NLPIAAOFKEO<PIEODFHFNCJ> EEPMLGNKEHB, NLPIAAOFKEO<JJMFOMJPOBG> JALDPIJOHOL, TAction GFMBHCHPLDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A2B480", Offset = "0x4A29C80", VA = "0x184A2B480")]
	public Task IGIJNFPDAOE(TRoot PNDCHGJLEGG, TNetSys LOJNJFGGPLC, TReceiver KEEAPFDDBLD, NLPIAAOFKEO<PIEODFHFNCJ> OMKDBLNDDFM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct AFHBANDMFIN<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly NLPIAAOFKEO<PIEODFHFNCJ> PPNEANMLLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly NLPIAAOFKEO<JJMFOMJPOBG> AOILHLACPEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction KAECCKELDPM;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xC035A0", Offset = "0xC01DA0", VA = "0x180C035A0")]
	public AFHBANDMFIN(NLPIAAOFKEO<PIEODFHFNCJ> EIOPAHLHHKC, NLPIAAOFKEO<JJMFOMJPOBG> JALDPIJOHOL, TAction GFMBHCHPLDH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class NJEAHODGDFL
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x392A980", Offset = "0x3929180", VA = "0x18392A980")]
	public static AFHBANDMFIN<TAction> CJOJELENPLJ<TAction>(NLPIAAOFKEO<PIEODFHFNCJ> EIOPAHLHHKC, NLPIAAOFKEO<JJMFOMJPOBG> JALDPIJOHOL, TAction GFMBHCHPLDH) where TAction : notnull
	{
		return default(AFHBANDMFIN<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class GOIBBGHJMNJ<TRoot, TDeps> : PPIFDECMEOD where TRoot : notnull where TDeps : notnull, CMIMLPDNMGP.LFGNIMKKKNM<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EGFHKKHLOIL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public GOIBBGHJMNJ<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public IOPMFGMDJPO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<HCGBMJDNFKJ<object?, CPMHOEMAGED>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x43F69C0", Offset = "0x43F51C0", VA = "0x1843F69C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x43F7030", Offset = "0x43F5830", VA = "0x1843F7030", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps DDCMACNPPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot KEFHDLAAPGP;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NLPIAAOFKEO<PIEODFHFNCJ> PHJLCDHFBDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xBD6AB0", Offset = "0xBD52B0", VA = "0x180BD6AB0")]
		[CompilerGenerated]
		get
		{
			return default(NLPIAAOFKEO<PIEODFHFNCJ>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2C3D410", Offset = "0x2C3BC10", VA = "0x182C3D410")]
	public GOIBBGHJMNJ(TDeps ILEBEOADOPL, TRoot PNDCHGJLEGG, NLPIAAOFKEO<PIEODFHFNCJ> GHGMBCDGKNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x49D72D0", Offset = "0x49D5AD0", VA = "0x1849D72D0", Slot = "4")]
	[AsyncStateMachine(typeof(GOIBBGHJMNJ<, >.EGFHKKHLOIL))]
	public Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> BNDAGKPJEFF(IOPMFGMDJPO GFMBHCHPLDH, bool EOPFBMLNBOG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class CMIMLPDNMGP
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LFGNIMKKKNM<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<HCGBMJDNFKJ<object, CPMHOEMAGED>> BNDAGKPJEFF(TRoot PNDCHGJLEGG, NLPIAAOFKEO<PIEODFHFNCJ> EEPMLGNKEHB, IOPMFGMDJPO GFMBHCHPLDH, bool EOPFBMLNBOG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HIINEFLKCHG : JHKCEHEHMON
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void OGHDDJKDCEI();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly HIINEFLKCHG DJLOIKDDKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly OGHDDJKDCEI? BKICACCPEEC;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9EBB90", Offset = "0x9EA390", VA = "0x1809EBB90")]
	public HIINEFLKCHG([Optional] OGHDDJKDCEI? LAHOJLACCJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1107FE0", Offset = "0x11067E0", VA = "0x181107FE0", Slot = "4")]
	public void EDGHCNKHDDB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class EMCMGMCNMEJ : BEJOLKFJADO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void NHJOLFCBKKI(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void DADGAHLKFII(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void MPEFONOILDH(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly EMCMGMCNMEJ DJLOIKDDKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly NHJOLFCBKKI? PLELPIDOGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DADGAHLKFII? KDBBEBCDOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MPEFONOILDH? NJFCDLNBPDB;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xC2FD30", Offset = "0xC2E530", VA = "0x180C2FD30")]
	public EMCMGMCNMEJ([Optional] NHJOLFCBKKI? PFPNPEHKNPE, [Optional] DADGAHLKFII? PHKOLCNJMKL, [Optional] MPEFONOILDH? FOAPMDABLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2790E10", Offset = "0x278F610", VA = "0x182790E10", Slot = "4")]
	public void OnEdgeDidAdd(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2790E30", Offset = "0x278F630", VA = "0x182790E30", Slot = "5")]
	public void OnEdgeWillRemove(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<BFEAKKGKCCO> HHLKACCBEBO, NLPIAAOFKEO<GCOKIOOPJJN> AJOCPGOGBJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2790DF0", Offset = "0x278F5F0", VA = "0x182790DF0", Slot = "6")]
	public void LNMIDLAKLKG(NLPIAAOFKEO<PAJOPNAJIFC> FOEJGIIEFNC, NLPIAAOFKEO<KGLBPIDLJAB> OPPFCAMGFJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "9")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9DECB0", Offset = "0x9DD4B0", VA = "0x1809DECB0", Slot = "10")]
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
