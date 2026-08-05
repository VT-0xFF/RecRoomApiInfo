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
		[Cpp2IlInjected.Address(RVA = "0xA2B980", Offset = "0xA2AB80", VA = "0x180A2B980")]
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
		[Cpp2IlInjected.Address(RVA = "0x28D4490", Offset = "0x28D3690", VA = "0x1828D4490")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA2C560", Offset = "0xA2B760", VA = "0x180A2C560")]
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
		[Cpp2IlInjected.Address(RVA = "0xA2C5A0", Offset = "0xA2B7A0", VA = "0x180A2C5A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class GMGNMGLKLDP<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, BKMOEILPCAA.MEMHKBFANIB<TAction, TNetSys> where TReceiverDeps : notnull, BKMOEILPCAA.FKKBIIGGPHN<TAction, TReceiver> where TRootDeps : notnull, BKMOEILPCAA.EPLNGPJMFNL<LHCEFEOGAFF, TAction, TRoot> where TRoot : notnull where TDeps : notnull, BKMOEILPCAA.APNDLGACNJN<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class HLCHPHHKNMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? ALPOIBNIKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<KHAJOEAIGBG<TAction>> PJBCJLHNIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool OCNDNPDMGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> PHIAAGAJIOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool CGJCDLNEHGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? MFCBDCGHIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly BJJHPIAEFEP<LHCEFEOGAFF, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> KNCFMOCIDFA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool ECPJLHAFBEI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x4CB1410", Offset = "0x4CB0610", VA = "0x184CB1410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4CB1900", Offset = "0x4CB0B00", VA = "0x184CB1900")]
		public HLCHPHHKNMD(int? CIDNJMOHIOP, List<KHAJOEAIGBG<TAction>> BHONLENFBOF, bool JPIGLKNDMPE, List<Func<Task>> FJCFPFALFLE, bool GJEKLILAGED, TAction[]? DNBDKKIJNOO, BJJHPIAEFEP<LHCEFEOGAFF, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> LKNDIICBKGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4CB16B0", Offset = "0x4CB08B0", VA = "0x184CB16B0")]
		public static GMGNMGLKLDP<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.HLCHPHHKNMD FAHGDJGLLGD(TDeps AHPCPGHNHGP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class DKOENMFGOBP
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
			public DKOENMFGOBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<DJNAMIFBMIO<object?, FMHHFFBAGLO>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x41CA360", Offset = "0x41C9560", VA = "0x1841CA360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x41CAAF0", Offset = "0x41C9CF0", VA = "0x1841CAAF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public HLCHPHHKNMD client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public KCKEEEOMPIF<DDJEBBDGHKM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<DJNAMIFBMIO<object?, FMHHFFBAGLO>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
		public DKOENMFGOBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x422A3A0", Offset = "0x42295A0", VA = "0x18422A3A0")]
		[AsyncStateMachine(typeof(GMGNMGLKLDP<, , , , , , , >.DKOENMFGOBP.<<SendActionToAll>b__0>d))]
		internal Task LHONKIBNEHH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct CHCILDJJLPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GMGNMGLKLDP<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public KCKEEEOMPIF<DDJEBBDGHKM> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public KCKEEEOMPIF<DDJEBBDGHKM> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public KCKEEEOMPIF<LHCEFEOGAFF> requestId;

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
		private TaskAwaiter<DJNAMIFBMIO<object, FMHHFFBAGLO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6794ED0", Offset = "0x67940D0", VA = "0x186794ED0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x67957A0", Offset = "0x67949A0", VA = "0x1867957A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private ENEMFDFPNBB<DDJEBBDGHKM, HLCHPHHKNMD> FJGEGHMIOAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<KHAJOEAIGBG<TAction>> GAGONIOLPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int GKFMJIEJFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int EBDDJDFABLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int MJLKGPIFMMI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AD60", Offset = "0x4C29F60", VA = "0x184C2AD60")]
	public GMGNMGLKLDP(int PMIGBKMHGHC, int BAOIGMKLNPC, int HJFECOBGFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4C29C00", Offset = "0x4C28E00", VA = "0x184C29C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AC50", Offset = "0x4C29E50", VA = "0x184C2AC50")]
	public void PAPKGIHBOFE(KCKEEEOMPIF<DDJEBBDGHKM> JFOBNAKMELF, TDeps AHPCPGHNHGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C29C20", Offset = "0x4C28E20", VA = "0x184C29C20")]
	public void FMILBCDCIBD(KCKEEEOMPIF<DDJEBBDGHKM> JFOBNAKMELF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C2AD30", Offset = "0x4C29F30", VA = "0x184C2AD30")]
	public void PMIPHBFEKEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C29C40", Offset = "0x4C28E40", VA = "0x184C29C40")]
	public (Task, Task[]) NKKNLPIJJDE(TRoot OLEJNEHCCLF, [In] LANEICCBKCK<DDJEBBDGHKM> HMKAFICPMMO, [In] ENEMFDFPNBB<DDJEBBDGHKM, TNetSys> EHNDNKJENOI, [In] ENEMFDFPNBB<DDJEBBDGHKM, TReceiver> OJOBCBOHAEO, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, KCKEEEOMPIF<LHCEFEOGAFF> DLEIIMMOIIE, TAction CJLPDLONOLK)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A2F0", Offset = "0x4C294F0", VA = "0x184C2A2F0")]
	public Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> NKKNLPIJJDE(TRoot OLEJNEHCCLF, TNetSys GCPKMNCMKPP, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, TAction CJLPDLONOLK, bool BDEEAIOAPNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C2A9A0", Offset = "0x4C29BA0", VA = "0x184C2A9A0")]
	[AsyncStateMachine(typeof(GMGNMGLKLDP<, , , , , , , >.CHCILDJJLPF))]
	public Task ONKDNIGPEGJ(TRoot OLEJNEHCCLF, TNetSys NBFFFHGOMEC, TReceiver NHMNHKCABDL, KCKEEEOMPIF<DDJEBBDGHKM> CJJPBDJCHBK, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, KCKEEEOMPIF<LHCEFEOGAFF> DLEIIMMOIIE, TAction CJLPDLONOLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C299A0", Offset = "0x4C28BA0", VA = "0x184C299A0")]
	public Task DDBHJDIKMLL(TRoot OLEJNEHCCLF, TNetSys NBFFFHGOMEC, TReceiver NHMNHKCABDL, KCKEEEOMPIF<DDJEBBDGHKM> CJJPBDJCHBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct KHAJOEAIGBG<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly KCKEEEOMPIF<DDJEBBDGHKM> IOCAALPOFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly KCKEEEOMPIF<LHCEFEOGAFF> JJBCAIHOCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction AEAPOBFEPDH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xC79050", Offset = "0xC78250", VA = "0x180C79050")]
	public KHAJOEAIGBG(KCKEEEOMPIF<DDJEBBDGHKM> MKCPMOJFGDP, KCKEEEOMPIF<LHCEFEOGAFF> DLEIIMMOIIE, TAction CJLPDLONOLK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class AFMBKLCACMG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x2FA6570", Offset = "0x2FA5770", VA = "0x182FA6570")]
	public static KHAJOEAIGBG<TAction> FAHGDJGLLGD<TAction>(KCKEEEOMPIF<DDJEBBDGHKM> MKCPMOJFGDP, KCKEEEOMPIF<LHCEFEOGAFF> DLEIIMMOIIE, TAction CJLPDLONOLK) where TAction : notnull
	{
		return default(KHAJOEAIGBG<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class KFPCECBAOED<TRoot, TDeps> : DKJCDGBLKAF where TRoot : notnull where TDeps : notnull, DDJHPHONIEN.CKOOBHPIEKN<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MMKBKNHLPHK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<DJNAMIFBMIO<object?, FMHHFFBAGLO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public KFPCECBAOED<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EKLFCKLHJOP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<DJNAMIFBMIO<object?, FMHHFFBAGLO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x542C090", Offset = "0x542B290", VA = "0x18542C090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x542C670", Offset = "0x542B870", VA = "0x18542C670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps EMPPIJCDCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot EAEEACIDMDH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public KCKEEEOMPIF<DDJEBBDGHKM> FHOHIPPHIJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA67480", Offset = "0xA66680", VA = "0x180A67480")]
		[CompilerGenerated]
		get
		{
			return default(KCKEEEOMPIF<DDJEBBDGHKM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2DC06D0", Offset = "0x2DBF8D0", VA = "0x182DC06D0")]
	public KFPCECBAOED(TDeps AHPCPGHNHGP, TRoot OLEJNEHCCLF, KCKEEEOMPIF<DDJEBBDGHKM> LBIHCCBAODA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5130940", Offset = "0x512FB40", VA = "0x185130940", Slot = "4")]
	[AsyncStateMachine(typeof(KFPCECBAOED<, >.MMKBKNHLPHK))]
	public Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> NKKNLPIJJDE(EKLFCKLHJOP CJLPDLONOLK, bool BDEEAIOAPNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class DDJHPHONIEN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface CKOOBHPIEKN<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DJNAMIFBMIO<object, FMHHFFBAGLO>> NKKNLPIJJDE(TRoot OLEJNEHCCLF, KCKEEEOMPIF<DDJEBBDGHKM> LJGIJNKMNHP, EKLFCKLHJOP CJLPDLONOLK, bool BDEEAIOAPNG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DJKBMPCPFLL : DGEOCJPLKIE
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void FOLJPFHPJDK();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly DJKBMPCPFLL AIBLJDBPKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly FOLJPFHPJDK? KALAHCHPPMB;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public DJKBMPCPFLL([Optional] FOLJPFHPJDK? CNCNMJJCMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1175330", Offset = "0x1174530", VA = "0x181175330", Slot = "4")]
	public void PMAFFFNDFGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NHPHMPNPIPA : DBMGKAPDBBN
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void DOEOFNKAJKM(KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DOFCOOPBBLO> EGLOMPMAIMO, KCKEEEOMPIF<FJGEHMMFOEB> CAPHMMGCHHE);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void AGBBCAKAHMI(KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DOFCOOPBBLO> EGLOMPMAIMO, KCKEEEOMPIF<FJGEHMMFOEB> CAPHMMGCHHE);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void HBKIBCIGCGC(KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DMIELAKFPBJ> KHABIKOGJPF);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly NHPHMPNPIPA AIBLJDBPKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly DOEOFNKAJKM? FJHOGLKMHEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly AGBBCAKAHMI? DGPBOKLNMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly HBKIBCIGCGC? EJBBJHFHIKH;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xC9C830", Offset = "0xC9BA30", VA = "0x180C9C830")]
	public NHPHMPNPIPA([Optional] DOEOFNKAJKM? GHLDEDOMLNC, [Optional] AGBBCAKAHMI? OGJIBHNOKNN, [Optional] HBKIBCIGCGC? DGGFHPENAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x28D43A0", Offset = "0x28D35A0", VA = "0x1828D43A0", Slot = "4")]
	public void OnEdgeDidAdd(KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DOFCOOPBBLO> EGLOMPMAIMO, KCKEEEOMPIF<FJGEHMMFOEB> CAPHMMGCHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28D43C0", Offset = "0x28D35C0", VA = "0x1828D43C0", Slot = "5")]
	public void OnEdgeWillRemove(KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DOFCOOPBBLO> EGLOMPMAIMO, KCKEEEOMPIF<FJGEHMMFOEB> CAPHMMGCHHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x28D4380", Offset = "0x28D3580", VA = "0x1828D4380", Slot = "6")]
	public void FIOLKMGMLCE(KCKEEEOMPIF<BGIICJNKCNN> PHMPPPDJDDA, KCKEEEOMPIF<DMIELAKFPBJ> KHABIKOGJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "11")]
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
