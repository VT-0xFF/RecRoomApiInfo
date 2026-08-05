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
		[Cpp2IlInjected.Address(RVA = "0xA873F0", Offset = "0xA85FF0", VA = "0x180A873F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A47020", Offset = "0x2A45C20", VA = "0x182A47020")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA87960", Offset = "0xA86560", VA = "0x180A87960")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA879A0", Offset = "0xA865A0", VA = "0x180A879A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class OPNLJBIDGGC<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, GJDHOMEHADK.KPNNGKBLNKM<TAction, TNetSys> where TReceiverDeps : notnull, GJDHOMEHADK.CPPICEMGEJL<TAction, TReceiver> where TRootDeps : notnull, GJDHOMEHADK.FJMCDEDNNIB<HHLPKMGDIPM, TAction, TRoot> where TRoot : notnull where TDeps : notnull, GJDHOMEHADK.KCLJCJPPNFK<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class DCJFGHHPALP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? LKBOGMDBJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<KEAPAJNDLDG<TAction>> BNECLANPALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool OLMCDMDJHJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> JLEAOJPANBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool FAFHLMHNJHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? GOJNMKHBAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly ABMHJIEHPIL<HHLPKMGDIPM, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> LJHIGMGHFMD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool IDHAFBPIKCF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x4458E70", Offset = "0x4457A70", VA = "0x184458E70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x44593B0", Offset = "0x4457FB0", VA = "0x1844593B0")]
		public DCJFGHHPALP(int? BPINHJLMGPF, List<KEAPAJNDLDG<TAction>> LPKOMKGPBDE, bool OJLMDDOGHFH, List<Func<Task>> GNDAJCDPEAG, bool HMCEEHJIFMO, TAction[]? HIADFHJJLMO, ABMHJIEHPIL<HHLPKMGDIPM, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> OFKPCIGOMBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4458F10", Offset = "0x4457B10", VA = "0x184458F10")]
		public static OPNLJBIDGGC<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.DCJFGHHPALP MJMNOIPJNFN(TDeps BNLBDNCLLFN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FFIHPKMEJNB
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
			public FFIHPKMEJNB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<IADHIMOENNN<object?, KHGGKMBDLJL>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<IADHIMOENNN<object, KHGGKMBDLJL>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x441E730", Offset = "0x441D330", VA = "0x18441E730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x441EAD0", Offset = "0x441D6D0", VA = "0x18441EAD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public DCJFGHHPALP client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public COMEADPNKEA<CFLJBDKGOMH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<IADHIMOENNN<object?, KHGGKMBDLJL>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public FFIHPKMEJNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4D6F9F0", Offset = "0x4D6E5F0", VA = "0x184D6F9F0")]
		[AsyncStateMachine(typeof(OPNLJBIDGGC<, , , , , , , >.FFIHPKMEJNB.<<SendActionToAll>b__0>d))]
		internal Task OCNHJNKJKNM()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct KCHEMAODPAJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public OPNLJBIDGGC<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public COMEADPNKEA<CFLJBDKGOMH> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public COMEADPNKEA<CFLJBDKGOMH> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public COMEADPNKEA<HHLPKMGDIPM> requestId;

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
		private TaskAwaiter<IADHIMOENNN<object, KHGGKMBDLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5399EB0", Offset = "0x5398AB0", VA = "0x185399EB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x539A780", Offset = "0x5399380", VA = "0x18539A780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private EOPNNEHIPIK<CFLJBDKGOMH, DCJFGHHPALP> FLKLINNBCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<KEAPAJNDLDG<TAction>> EEHBMBJHENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int CODIGOBGNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int FALJDPJAIFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int AGAFGHEHAJB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x590BBC0", Offset = "0x590A7C0", VA = "0x18590BBC0")]
	public OPNLJBIDGGC(int OIJMEPBBLGG, int KKKHPHBNGFN, int CBFFIGKEFAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x590B7E0", Offset = "0x590A3E0", VA = "0x18590B7E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x590BAE0", Offset = "0x590A6E0", VA = "0x18590BAE0")]
	public void HGLFFDDMNBE(COMEADPNKEA<CFLJBDKGOMH> DNMDEMHKFBL, TDeps BNLBDNCLLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x590AA60", Offset = "0x5909660", VA = "0x18590AA60")]
	public void DHFCGFKDOGF(COMEADPNKEA<CFLJBDKGOMH> DNMDEMHKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x590B800", Offset = "0x590A400", VA = "0x18590B800")]
	public void ELCFKCFOJDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x590B130", Offset = "0x5909D30", VA = "0x18590B130")]
	public (Task, Task[]) DKHAACOFLDL(TRoot OLIIIAEGOLD, [In] JHCNNIEGGJG<CFLJBDKGOMH> BMILALMOJCO, [In] EOPNNEHIPIK<CFLJBDKGOMH, TNetSys> FIFNBKOCDIG, [In] EOPNNEHIPIK<CFLJBDKGOMH, TReceiver> FJBICPPNLCG, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, COMEADPNKEA<HHLPKMGDIPM> MANPAFALMMC, TAction KLIEOOEGDML)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x590AEC0", Offset = "0x5909AC0", VA = "0x18590AEC0")]
	public Task<IADHIMOENNN<object, KHGGKMBDLJL>> DKHAACOFLDL(TRoot OLIIIAEGOLD, TNetSys NGJLHELIFON, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, TAction KLIEOOEGDML, bool NJBBGJCHDOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x590B830", Offset = "0x590A430", VA = "0x18590B830")]
	[AsyncStateMachine(typeof(OPNLJBIDGGC<, , , , , , , >.KCHEMAODPAJ))]
	public Task ENJILADPIFM(TRoot OLIIIAEGOLD, TNetSys HPECMONLBCL, TReceiver NHJPJMHIKLA, COMEADPNKEA<CFLJBDKGOMH> BLFEHAELPKE, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, COMEADPNKEA<HHLPKMGDIPM> MANPAFALMMC, TAction KLIEOOEGDML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x590A5A0", Offset = "0x59091A0", VA = "0x18590A5A0")]
	public Task BDMAEJHOHDB(TRoot OLIIIAEGOLD, TNetSys HPECMONLBCL, TReceiver NHJPJMHIKLA, COMEADPNKEA<CFLJBDKGOMH> BLFEHAELPKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct KEAPAJNDLDG<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly COMEADPNKEA<CFLJBDKGOMH> PPFMJEMDJIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly COMEADPNKEA<HHLPKMGDIPM> LHHBJBILGEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction IAOKKNFJFJE;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD2A730", Offset = "0xD29330", VA = "0x180D2A730")]
	public KEAPAJNDLDG(COMEADPNKEA<CFLJBDKGOMH> JGGIBDMAPLG, COMEADPNKEA<HHLPKMGDIPM> MANPAFALMMC, TAction KLIEOOEGDML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class PJFJMLEDKJG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3E16E80", Offset = "0x3E15A80", VA = "0x183E16E80")]
	public static KEAPAJNDLDG<TAction> MJMNOIPJNFN<TAction>(COMEADPNKEA<CFLJBDKGOMH> JGGIBDMAPLG, COMEADPNKEA<HHLPKMGDIPM> MANPAFALMMC, TAction KLIEOOEGDML) where TAction : notnull
	{
		return default(KEAPAJNDLDG<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class FMENENAGCAH<TRoot, TDeps> : MKGNPBOLLPA where TRoot : notnull where TDeps : notnull, MEJELGNDEHM.JOADFANJJII<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EKGMCABCHKD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<IADHIMOENNN<object?, KHGGKMBDLJL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public FMENENAGCAH<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public ONEEMEFCJNK action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<IADHIMOENNN<object?, KHGGKMBDLJL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x48E3010", Offset = "0x48E1C10", VA = "0x1848E3010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x48E33B0", Offset = "0x48E1FB0", VA = "0x1848E33B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps HIMLJAGALBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot COPMBFGCJCG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public COMEADPNKEA<CFLJBDKGOMH> MBOBDLPANJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAB6800", Offset = "0xAB5400", VA = "0x180AB6800")]
		[CompilerGenerated]
		get
		{
			return default(COMEADPNKEA<CFLJBDKGOMH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F7C450", Offset = "0x2F7B050", VA = "0x182F7C450")]
	public FMENENAGCAH(TDeps BNLBDNCLLFN, TRoot OLIIIAEGOLD, COMEADPNKEA<CFLJBDKGOMH> NFKBMBAOGIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D7DD90", Offset = "0x4D7C990", VA = "0x184D7DD90", Slot = "4")]
	[AsyncStateMachine(typeof(FMENENAGCAH<, >.EKGMCABCHKD))]
	public Task<IADHIMOENNN<object, KHGGKMBDLJL>> DKHAACOFLDL(ONEEMEFCJNK KLIEOOEGDML, bool NJBBGJCHDOE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class MEJELGNDEHM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface JOADFANJJII<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<IADHIMOENNN<object, KHGGKMBDLJL>> DKHAACOFLDL(TRoot OLIIIAEGOLD, COMEADPNKEA<CFLJBDKGOMH> OMFLIKNBECA, ONEEMEFCJNK KLIEOOEGDML, bool NJBBGJCHDOE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JFJHDJOADMP : IDOMKILLBMP
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void EJNCODGJHDN();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly JFJHDJOADMP MFAGMJBMEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly EJNCODGJHDN? MLEAPMPBDOA;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA628A0", Offset = "0xA614A0", VA = "0x180A628A0")]
	public JFJHDJOADMP([Optional] EJNCODGJHDN? PEIBGGOOOFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1289A70", Offset = "0x1288670", VA = "0x181289A70", Slot = "4")]
	public void IHPDIBFNJCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OFIOPFLCBNL : GBFPKHAHIAF
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void OGMLICHHCFB(COMEADPNKEA<MAPJCLOKAJL> DJIIOAADINA, COMEADPNKEA<OKAAAIHIEKD> JMIOFLDOCAH, COMEADPNKEA<ABACMLEFBFD> IMJJMCCJJDD);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void MPBOGILKJAB(COMEADPNKEA<MAPJCLOKAJL> DJIIOAADINA, COMEADPNKEA<OKAAAIHIEKD> JMIOFLDOCAH, COMEADPNKEA<ABACMLEFBFD> IMJJMCCJJDD);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void IJFGGLECABI(COMEADPNKEA<MAPJCLOKAJL> DJIIOAADINA, COMEADPNKEA<DDIFFCPDEKA> LJOMDKEKAFC);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly OFIOPFLCBNL MFAGMJBMEEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly OGMLICHHCFB? ONGLEMKMIEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly MPBOGILKJAB? IPGNKFFNDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly IJFGGLECABI? EMNIGGFPGDO;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xD56060", Offset = "0xD54C60", VA = "0x180D56060")]
	public OFIOPFLCBNL([Optional] OGMLICHHCFB? FNLEHHOFACN, [Optional] MPBOGILKJAB? COBOABPDPAD, [Optional] IJFGGLECABI? HDOGMPPBFFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2A470C0", Offset = "0x2A45CC0", VA = "0x182A470C0", Slot = "4")]
	public void OnEdgeDidAdd(COMEADPNKEA<MAPJCLOKAJL> DJIIOAADINA, COMEADPNKEA<OKAAAIHIEKD> JMIOFLDOCAH, COMEADPNKEA<ABACMLEFBFD> IMJJMCCJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2A470E0", Offset = "0x2A45CE0", VA = "0x182A470E0", Slot = "5")]
	public void OnEdgeWillRemove(COMEADPNKEA<MAPJCLOKAJL> DJIIOAADINA, COMEADPNKEA<OKAAAIHIEKD> JMIOFLDOCAH, COMEADPNKEA<ABACMLEFBFD> IMJJMCCJJDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2A470A0", Offset = "0x2A45CA0", VA = "0x182A470A0", Slot = "6")]
	public void LMMGOHNGPLO(COMEADPNKEA<MAPJCLOKAJL> DJIIOAADINA, COMEADPNKEA<DDIFFCPDEKA> LJOMDKEKAFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "11")]
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
