using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface DGEDNHDNLNP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GKFLKFBGJAK(in TAction GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction NAHBOECCNCK(in TAction GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction HKDFAJNEEAO(in TAction GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> CILEIHBHBKK(in TAction GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FDMECPFKPLI(in TAction GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DDGGLDGKIFD(in TAction GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GDLCHEEJNOC(in TAction GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ACCKOKICFPM(in TAction GHCLFMPOHGP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool LKFBNKMJLKD(in TAction GHCLFMPOHGP);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HDDHLFCGAIP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::JMIGNGAIFLD<GPJHBAGCCPI> FGACHGMBDAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KBEDFGKLKFC();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDINFJAPLGM(in global::JMIGNGAIFLD<LAIJMPOJKOG> MGGEMHPGBME, in TAction GHCLFMPOHGP);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JBBJLGCCNGC<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int KBGNHNCMDNG(TPartialSnapshot CACBDLDNPEK);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot EFBOFCGAJPJ(TPartialSnapshot[] OIILANPMNOK);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class GPJHBAGCCPI
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class LAIJMPOJKOG
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class DLLGGPDOHID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::ALCHJICADNN<TAction, Task<global::EABJJOPDGLM<object, JMNFFALHFMO>>, TActionReceiver> where TActionReceiver : global::OFNCBLPBLDG<TAction, Task<global::EABJJOPDGLM<object, JMNFFALHFMO>>> where TActionDeps : global::DGEDNHDNLNP<TAction> where TStaticNetSysDeps : global::HDDHLFCGAIP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private interface LDCPOOIJCOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HOMMAEGGKHL(in global::EABJJOPDGLM<object, JMNFFALHFMO> LHPJBAGJLHP);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AOEBOABOMGL();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::EABJJOPDGLM<object, JMNFFALHFMO> PJNMAJOEFMJ();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void AMADBAIBIKD(Exception LGPNHAIJKII);
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class AHKNNDONLNI : LDCPOOIJCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::EABJJOPDGLM<object, JMNFFALHFMO>> BLFHAMAIBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::EABJJOPDGLM<object, JMNFFALHFMO>> DOBODCIDMAP;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x46BF700", Offset = "0x46BE900", VA = "0x1846BF700")]
		private AHKNNDONLNI(TaskCompletionSource<global::EABJJOPDGLM<object, JMNFFALHFMO>> JBGAAGDOAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x16AB2C0", Offset = "0x16AA4C0", VA = "0x1816AB2C0")]
		public static AHKNNDONLNI HCEINCHCOLK(TaskCompletionSource<global::EABJJOPDGLM<object, JMNFFALHFMO>> JBGAAGDOAJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x46BF600", Offset = "0x46BE800", VA = "0x1846BF600")]
		public void HOMMAEGGKHL(in global::EABJJOPDGLM<object, JMNFFALHFMO> LHPJBAGJLHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x46BF540", Offset = "0x46BE740", VA = "0x1846BF540", Slot = "5")]
		public void AOEBOABOMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x46BF660", Offset = "0x46BE860", VA = "0x1846BF660", Slot = "6")]
		public global::EABJJOPDGLM<object, JMNFFALHFMO> PJNMAJOEFMJ()
		{
			return default(global::EABJJOPDGLM<object, JMNFFALHFMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x46BF4E0", Offset = "0x46BE6E0", VA = "0x1846BF4E0", Slot = "7")]
		public void AMADBAIBIKD(Exception LGPNHAIJKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x46BF4B0", Offset = "0x46BE6B0", VA = "0x1846BF4B0", Slot = "4")]
		private void AGIABEJHCEG(in global::EABJJOPDGLM<object, JMNFFALHFMO> LHPJBAGJLHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class NKGPPAJPCJB : LDCPOOIJCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::EABJJOPDGLM<object, JMNFFALHFMO>> BLFHAMAIBDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::EABJJOPDGLM<object, JMNFFALHFMO> GGGBAJJENPC;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1343700", Offset = "0x1342900", VA = "0x181343700")]
		private NKGPPAJPCJB(TaskCompletionSource<global::EABJJOPDGLM<object, JMNFFALHFMO>> JBGAAGDOAJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x16AB2C0", Offset = "0x16AA4C0", VA = "0x1816AB2C0")]
		public static NKGPPAJPCJB HCEINCHCOLK(TaskCompletionSource<global::EABJJOPDGLM<object, JMNFFALHFMO>> JBGAAGDOAJP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xBDD320", Offset = "0xBDC520", VA = "0x180BDD320")]
		public void HOMMAEGGKHL(in global::EABJJOPDGLM<object, JMNFFALHFMO> LHPJBAGJLHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x46D5770", Offset = "0x46D4970", VA = "0x1846D5770", Slot = "5")]
		public void AOEBOABOMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7EA030", Offset = "0x7E9230", VA = "0x1807EA030", Slot = "6")]
		public global::EABJJOPDGLM<object, JMNFFALHFMO> PJNMAJOEFMJ()
		{
			return default(global::EABJJOPDGLM<object, JMNFFALHFMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x46D5710", Offset = "0x46D4910", VA = "0x1846D5710", Slot = "7")]
		public void AMADBAIBIKD(Exception LGPNHAIJKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x46BF4B0", Offset = "0x46BE6B0", VA = "0x1846BF4B0", Slot = "4")]
		private void AGIABEJHCEG(in global::EABJJOPDGLM<object, JMNFFALHFMO> LHPJBAGJLHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class ICOGKDOMHDL : LDCPOOIJCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::EABJJOPDGLM<object, JMNFFALHFMO>> DOBODCIDMAP;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x46D3E70", Offset = "0x46D3070", VA = "0x1846D3E70")]
		private ICOGKDOMHDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x46D04A0", Offset = "0x46CF6A0", VA = "0x1846D04A0")]
		public static ICOGKDOMHDL HCEINCHCOLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x46D3DB0", Offset = "0x46D2FB0", VA = "0x1846D3DB0")]
		public void HOMMAEGGKHL(in global::EABJJOPDGLM<object, JMNFFALHFMO> LHPJBAGJLHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		public void AOEBOABOMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x46D3E10", Offset = "0x46D3010", VA = "0x1846D3E10", Slot = "6")]
		public global::EABJJOPDGLM<object, JMNFFALHFMO> PJNMAJOEFMJ()
		{
			return default(global::EABJJOPDGLM<object, JMNFFALHFMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		public void AMADBAIBIKD(Exception LGPNHAIJKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x46BF4B0", Offset = "0x46BE6B0", VA = "0x1846BF4B0", Slot = "4")]
		private void AGIABEJHCEG(in global::EABJJOPDGLM<object, JMNFFALHFMO> LHPJBAGJLHP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class GFPPKOKNOFC : LDCPOOIJCOO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::EABJJOPDGLM<object, JMNFFALHFMO> GGGBAJJENPC;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xE8BA70", Offset = "0xE8AC70", VA = "0x180E8BA70")]
		private GFPPKOKNOFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x46D04A0", Offset = "0x46CF6A0", VA = "0x1846D04A0")]
		public static GFPPKOKNOFC HCEINCHCOLK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xEAF340", Offset = "0xEAE540", VA = "0x180EAF340")]
		public void HOMMAEGGKHL(in global::EABJJOPDGLM<object, JMNFFALHFMO> LHPJBAGJLHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "5")]
		public void AOEBOABOMGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6FD290", Offset = "0x6FC490", VA = "0x1806FD290", Slot = "6")]
		public global::EABJJOPDGLM<object, JMNFFALHFMO> PJNMAJOEFMJ()
		{
			return default(global::EABJJOPDGLM<object, JMNFFALHFMO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350", Slot = "7")]
		public void AMADBAIBIKD(Exception LGPNHAIJKII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x46BF4B0", Offset = "0x46BE6B0", VA = "0x1846BF4B0", Slot = "4")]
		private void AGIABEJHCEG(in global::EABJJOPDGLM<object, JMNFFALHFMO> LHPJBAGJLHP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct IJNPCEAAKMH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::EABJJOPDGLM<object, JMNFFALHFMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::DLLGGPDOHID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::JMIGNGAIFLD<GPJHBAGCCPI> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::JMIGNGAIFLD<LAIJMPOJKOG> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::EABJJOPDGLM<object, JMNFFALHFMO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x46D3EE0", Offset = "0x46D30E0", VA = "0x1846D3EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x46D4160", Offset = "0x46D3360", VA = "0x1846D4160", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct ODGLPANMOHL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::EABJJOPDGLM<object, JMNFFALHFMO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::DLLGGPDOHID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::JMIGNGAIFLD<GPJHBAGCCPI> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::JMIGNGAIFLD<LAIJMPOJKOG> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private LDCPOOIJCOO <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x46D57D0", Offset = "0x46D49D0", VA = "0x1846D57D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x46D5F60", Offset = "0x46D5160", VA = "0x1846D5F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct LONCMBHOHBB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::DLLGGPDOHID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public LDCPOOIJCOO completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private LDCPOOIJCOO <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::EABJJOPDGLM<object, JMNFFALHFMO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x46D4570", Offset = "0x46D3770", VA = "0x1846D4570", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x612450", Offset = "0x611650", VA = "0x180612450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver KPAIIFNBDJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps LNBCJMJEHJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps CLAJHMBAIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int IPKDHLIFNAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int FGOIOKIACFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::JMIGNGAIFLD<LAIJMPOJKOG>, TaskCompletionSource<global::EABJJOPDGLM<object, JMNFFALHFMO>>> GKDHJMLLNEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::KDABLKIGFDC<LAIJMPOJKOG> FIBIEOGHOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool ELAAGGPELCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int AJFNPBLFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task MMFFECAOEDN;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x46D0230", Offset = "0x46CF430", VA = "0x1846D0230")]
	protected DLLGGPDOHID(TActionDeps GMBOOPGJBBG, TStaticNetSysDeps PMJDODNJNMP, int LBAFLLNCJME, int GMKBPFKCEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x46CFD90", Offset = "0x46CEF90", VA = "0x1846CFD90")]
	public static global::DLLGGPDOHID<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> HCEINCHCOLK(TActionDeps GMBOOPGJBBG, TStaticNetSysDeps PMJDODNJNMP, [Optional] int? LBAFLLNCJME, [Optional] int? GMKBPFKCEDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x46CF7F0", Offset = "0x46CE9F0", VA = "0x1846CF7F0")]
	public Task<global::EABJJOPDGLM<object, JMNFFALHFMO>> CDINFJAPLGM(in TAction GHCLFMPOHGP, bool ENEAOCOIMMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x46CF7E0", Offset = "0x46CE9E0", VA = "0x1846CF7E0")]
	public void BGJBKHPPEDB(in TActionReceiver OGJGKCFPNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x46CFC40", Offset = "0x46CEE40", VA = "0x1846CFC40")]
	[AsyncStateMachine(typeof(global::DLLGGPDOHID<, , , >.IJNPCEAAKMH))]
	public Task<global::EABJJOPDGLM<object, JMNFFALHFMO>> COFJGNJACGA(global::JMIGNGAIFLD<GPJHBAGCCPI> FDPPFMAFMMG, global::JMIGNGAIFLD<LAIJMPOJKOG> MGGEMHPGBME, TAction GHCLFMPOHGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x46D00E0", Offset = "0x46CF2E0", VA = "0x1846D00E0")]
	[AsyncStateMachine(typeof(global::DLLGGPDOHID<, , , >.ODGLPANMOHL))]
	private Task<global::EABJJOPDGLM<object, JMNFFALHFMO>> ODNKACDFDHK(global::JMIGNGAIFLD<GPJHBAGCCPI> FDPPFMAFMMG, global::JMIGNGAIFLD<LAIJMPOJKOG> MGGEMHPGBME, TAction GHCLFMPOHGP, Task EHKJDNFDLEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x46CFAF0", Offset = "0x46CECF0", VA = "0x1846CFAF0")]
	[AsyncStateMachine(typeof(global::DLLGGPDOHID<, , , >.LONCMBHOHBB))]
	private Task COBKAKKMHFC(TAction GHCLFMPOHGP, LDCPOOIJCOO FADNKEGPBEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x46CFEC0", Offset = "0x46CF0C0", VA = "0x1846CFEC0")]
	private void MELNBNMKFMA(TAction GHCLFMPOHGP, bool CLFDPLGBPMN, bool GCFNHPOJEEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3AB2410", Offset = "0x3AB1610", VA = "0x183AB2410", Slot = "4")]
	private Task<global::EABJJOPDGLM<object, JMNFFALHFMO>> ELGGLCJLFIL(in TAction GHCLFMPOHGP, bool ENEAOCOIMMA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct ACLBCFLEDME<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::JBBJLGCCNGC<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] HFGCDIJKFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int KEBONOCMCJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps BAPDCJKANBN;

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x37E4120", Offset = "0x37E3320", VA = "0x1837E4120")]
	internal ACLBCFLEDME(TPartialSnapshot[] JMONFHFLLEP, int DLBACCBHGMM, TDeps BINNMIIOOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37E3D50", Offset = "0x37E2F50", VA = "0x1837E3D50")]
	public global::CMBKIHGPMOG<TFullSnapshot> HAIDKHCFMKD(TPartialSnapshot CACBDLDNPEK)
	{
		return default(global::CMBKIHGPMOG<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37E4020", Offset = "0x37E3220", VA = "0x1837E4020")]
	public bool HCOLJABEEJG(TPartialSnapshot CACBDLDNPEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37E3F30", Offset = "0x37E3130", VA = "0x1837E3F30")]
	public static global::ACLBCFLEDME<TPartialSnapshot, TFullSnapshot, TDeps> HCEINCHCOLK(TDeps BINNMIIOOPN)
	{
		return default(global::ACLBCFLEDME<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class MNOKAELABHP : JMNFFALHFMO
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x28A4320", Offset = "0x28A3520", VA = "0x1828A4320", Slot = "5")]
	public override string DLCNIEHKNDI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x9D1870", Offset = "0x9D0A70", VA = "0x1809D1870")]
	private MNOKAELABHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x383B1A0", Offset = "0x383A3A0", VA = "0x18383B1A0")]
	public static global::EABJJOPDGLM<TOk, JMNFFALHFMO> HCEINCHCOLK<TOk>()
	{
		return default(global::EABJJOPDGLM<TOk, JMNFFALHFMO>);
	}
}
namespace Cpp2IlInjected;

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
