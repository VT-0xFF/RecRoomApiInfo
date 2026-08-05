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
public interface ABBMOOBKCLK<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PJCOKEHFEBB(in TAction LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction KIHHDDFGDPI(in TAction LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction GAOKGNOKLNJ(in TAction LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> LGJPEADFDPA(in TAction LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PMFLKDLIPPO(in TAction LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FLEEILCBHIN(in TAction LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GHJDGFMLKIE(in TAction LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool LBFBIIENJJH(in TAction LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool CHCAOEBNMED(in TAction LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DKCCKCPKBCP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::MILDMIBLDIO<FCOAMEIJFML> KFACOOCDCMH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMCGGAGODJI();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFNIJIKBPGA(global::MILDMIBLDIO<HHLNMPACLPP> PFFJGCGMEDP, in TAction LBPAPOGAAHD);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DBENPCMHIAF<TAction, TResult>
{
	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TResult HLAKBDJNNAP(in TAction LBPAPOGAAHD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction[] MLBKNDAAKAA();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HBGOJJFIFEE<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IEBBLLGNDCH(TPartialSnapshot PNPHPOBIFIK);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TFullSnapshot CGAICHNHPCB(TPartialSnapshot[] EALOJFIMLOK);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public sealed class FCOAMEIJFML
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public sealed class HHLNMPACLPP
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class CEMAMONJIJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> where TActionReceiver : global::DBENPCMHIAF<TAction, Task<global::EFLIEPEIGHL<object, OMKBBKFADKC>>> where TActionDeps : global::ABBMOOBKCLK<TAction> where TStaticNetSysDeps : global::DKCCKCPKBCP<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private interface OIFOJPCGLDN
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IILPJIENDCF(in global::EFLIEPEIGHL<object, OMKBBKFADKC> HHGIFHKDCCA);

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FNHIKJEFLKM();

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::EFLIEPEIGHL<object, OMKBBKFADKC> EGEDJPIDKEJ();

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KNDFMPGAAOM(Exception PMGBIMIMLBD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class MFGCHEFPFBE : OIFOJPCGLDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::EFLIEPEIGHL<object, OMKBBKFADKC>> NNLABGMBPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::EFLIEPEIGHL<object, OMKBBKFADKC>> EFFHMIHEFEM;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1A71EB0", Offset = "0x1A708B0", VA = "0x181A71EB0")]
		private MFGCHEFPFBE(TaskCompletionSource<global::EFLIEPEIGHL<object, OMKBBKFADKC>> GCHODDCLCNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1A71DE0", Offset = "0x1A707E0", VA = "0x181A71DE0")]
		public static MFGCHEFPFBE NDGDIJBCNJC(TaskCompletionSource<global::EFLIEPEIGHL<object, OMKBBKFADKC>> GCHODDCLCNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1A71D20", Offset = "0x1A70720", VA = "0x181A71D20")]
		public void IILPJIENDCF(in global::EFLIEPEIGHL<object, OMKBBKFADKC> HHGIFHKDCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1A71C40", Offset = "0x1A70640", VA = "0x181A71C40", Slot = "5")]
		public void FNHIKJEFLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1A71B90", Offset = "0x1A70590", VA = "0x181A71B90", Slot = "6")]
		public global::EFLIEPEIGHL<object, OMKBBKFADKC> EGEDJPIDKEJ()
		{
			return default(global::EFLIEPEIGHL<object, OMKBBKFADKC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1A71D80", Offset = "0x1A70780", VA = "0x181A71D80", Slot = "7")]
		public void KNDFMPGAAOM(Exception PMGBIMIMLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1A71B60", Offset = "0x1A70560", VA = "0x181A71B60", Slot = "4")]
		private void BKDFMKGHHNM(in global::EFLIEPEIGHL<object, OMKBBKFADKC> HHGIFHKDCCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class CPLMDFPJBNL : OIFOJPCGLDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::EFLIEPEIGHL<object, OMKBBKFADKC>> NNLABGMBPKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::EFLIEPEIGHL<object, OMKBBKFADKC> HMEAFPKCJHB;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1A58D90", Offset = "0x1A57790", VA = "0x181A58D90")]
		private CPLMDFPJBNL(TaskCompletionSource<global::EFLIEPEIGHL<object, OMKBBKFADKC>> GCHODDCLCNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1A71DE0", Offset = "0x1A707E0", VA = "0x181A71DE0")]
		public static CPLMDFPJBNL NDGDIJBCNJC(TaskCompletionSource<global::EFLIEPEIGHL<object, OMKBBKFADKC>> GCHODDCLCNC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x24C1990", Offset = "0x24C0390", VA = "0x1824C1990")]
		public void IILPJIENDCF(in global::EFLIEPEIGHL<object, OMKBBKFADKC> HHGIFHKDCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x28DA030", Offset = "0x28D8A30", VA = "0x1828DA030", Slot = "5")]
		public void FNHIKJEFLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x909700", Offset = "0x908100", VA = "0x180909700", Slot = "6")]
		public global::EFLIEPEIGHL<object, OMKBBKFADKC> EGEDJPIDKEJ()
		{
			return default(global::EFLIEPEIGHL<object, OMKBBKFADKC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x28DA090", Offset = "0x28D8A90", VA = "0x1828DA090", Slot = "7")]
		public void KNDFMPGAAOM(Exception PMGBIMIMLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1A71B60", Offset = "0x1A70560", VA = "0x181A71B60", Slot = "4")]
		private void BKDFMKGHHNM(in global::EFLIEPEIGHL<object, OMKBBKFADKC> HHGIFHKDCCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class JBCOABLOKLK : OIFOJPCGLDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::EFLIEPEIGHL<object, OMKBBKFADKC>> EFFHMIHEFEM;

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1C10FF0", Offset = "0x1C0F9F0", VA = "0x181C10FF0")]
		private JBCOABLOKLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1C10F30", Offset = "0x1C0F930", VA = "0x181C10F30")]
		public static JBCOABLOKLK NDGDIJBCNJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1C10ED0", Offset = "0x1C0F8D0", VA = "0x181C10ED0")]
		public void IILPJIENDCF(in global::EFLIEPEIGHL<object, OMKBBKFADKC> HHGIFHKDCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "5")]
		public void FNHIKJEFLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1C10E70", Offset = "0x1C0F870", VA = "0x181C10E70", Slot = "6")]
		public global::EFLIEPEIGHL<object, OMKBBKFADKC> EGEDJPIDKEJ()
		{
			return default(global::EFLIEPEIGHL<object, OMKBBKFADKC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
		public void KNDFMPGAAOM(Exception PMGBIMIMLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1A71B60", Offset = "0x1A70560", VA = "0x181A71B60", Slot = "4")]
		private void BKDFMKGHHNM(in global::EFLIEPEIGHL<object, OMKBBKFADKC> HHGIFHKDCCA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NHGNMKEIBPD : OIFOJPCGLDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::EFLIEPEIGHL<object, OMKBBKFADKC> HMEAFPKCJHB;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7D07F0", Offset = "0x7CF1F0", VA = "0x1807D07F0")]
		private NHGNMKEIBPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1C10F30", Offset = "0x1C0F930", VA = "0x181C10F30")]
		public static NHGNMKEIBPD NDGDIJBCNJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x18199B0", Offset = "0x18183B0", VA = "0x1818199B0")]
		public void IILPJIENDCF(in global::EFLIEPEIGHL<object, OMKBBKFADKC> HHGIFHKDCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "5")]
		public void FNHIKJEFLKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C65F0", Offset = "0x9C4FF0", VA = "0x1809C65F0", Slot = "6")]
		public global::EFLIEPEIGHL<object, OMKBBKFADKC> EGEDJPIDKEJ()
		{
			return default(global::EFLIEPEIGHL<object, OMKBBKFADKC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6A0000", Offset = "0x69EA00", VA = "0x1806A0000", Slot = "7")]
		public void KNDFMPGAAOM(Exception PMGBIMIMLBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1A71B60", Offset = "0x1A70560", VA = "0x181A71B60", Slot = "4")]
		private void BKDFMKGHHNM(in global::EFLIEPEIGHL<object, OMKBBKFADKC> HHGIFHKDCCA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct CKOKMFBPKCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::EFLIEPEIGHL<object, OMKBBKFADKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::CEMAMONJIJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::MILDMIBLDIO<FCOAMEIJFML> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::MILDMIBLDIO<HHLNMPACLPP> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::EFLIEPEIGHL<object, OMKBBKFADKC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x229BE00", Offset = "0x229A800", VA = "0x18229BE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x229C0B0", Offset = "0x229AAB0", VA = "0x18229C0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct MNECOHPNLEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::EFLIEPEIGHL<object, OMKBBKFADKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::CEMAMONJIJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::MILDMIBLDIO<FCOAMEIJFML> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::MILDMIBLDIO<HHLNMPACLPP> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private OIFOJPCGLDN <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x2054DF0", Offset = "0x20537F0", VA = "0x182054DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2055640", Offset = "0x2054040", VA = "0x182055640", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct AOJDAGFDFJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::CEMAMONJIJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public OIFOJPCGLDN completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private OIFOJPCGLDN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::EFLIEPEIGHL<object, OMKBBKFADKC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x2034220", Offset = "0x2032C20", VA = "0x182034220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x795F10", Offset = "0x794910", VA = "0x180795F10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver CENIOMHDDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps JKPFCPNNCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps AACCCDCBFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int IDKHKKIILOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int ICGMFHEGDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::MILDMIBLDIO<HHLNMPACLPP>, TaskCompletionSource<global::EFLIEPEIGHL<object, OMKBBKFADKC>>> FIKBGFDPJGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private global::DGEPEFGGDOL<HHLNMPACLPP> JDGOCDNHBDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int BBFIGMEHKHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task PDGBBDOAHOA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool BPDGFDPMLHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80DF90", Offset = "0x80C990", VA = "0x18080DF90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80D9E0", Offset = "0x80C3E0", VA = "0x18080D9E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x21DDF30", Offset = "0x21DC930", VA = "0x1821DDF30")]
	protected CEMAMONJIJE(TActionDeps CILIGPIAHLD, TStaticNetSysDeps GNLGHDEGKLH, int BIDKNHEECMI, int PLFHDHFGDBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x21DDCB0", Offset = "0x21DC6B0", VA = "0x1821DDCB0")]
	public static global::CEMAMONJIJE<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> NDGDIJBCNJC(TActionDeps CILIGPIAHLD, TStaticNetSysDeps GNLGHDEGKLH, [Optional] int? BIDKNHEECMI, [Optional] int? PLFHDHFGDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x21DD4D0", Offset = "0x21DBED0", VA = "0x1821DD4D0")]
	public Task<global::EFLIEPEIGHL<object, OMKBBKFADKC>> HFNIJIKBPGA(in TAction LBPAPOGAAHD, bool NKBCABNHNAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x21DD4C0", Offset = "0x21DBEC0", VA = "0x1821DD4C0")]
	public void FONMENFDCIP(in TActionReceiver FMKMDNEMGPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x21DD9E0", Offset = "0x21DC3E0", VA = "0x1821DD9E0")]
	[AsyncStateMachine(typeof(global::CEMAMONJIJE<, , , >.CKOKMFBPKCP))]
	public Task<global::EFLIEPEIGHL<object, OMKBBKFADKC>> HLAKBDJNNAP(global::MILDMIBLDIO<FCOAMEIJFML> NAPNJBCBGJA, global::MILDMIBLDIO<HHLNMPACLPP> PFFJGCGMEDP, TAction LBPAPOGAAHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x21DDB40", Offset = "0x21DC540", VA = "0x1821DDB40")]
	[AsyncStateMachine(typeof(global::CEMAMONJIJE<, , , >.MNECOHPNLEG))]
	private Task<global::EFLIEPEIGHL<object, OMKBBKFADKC>> KGCBGLLDPKC(global::MILDMIBLDIO<FCOAMEIJFML> NAPNJBCBGJA, global::MILDMIBLDIO<HHLNMPACLPP> PFFJGCGMEDP, TAction LBPAPOGAAHD, Task CHNCPANEFOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x21DDDF0", Offset = "0x21DC7F0", VA = "0x1821DDDF0")]
	[AsyncStateMachine(typeof(global::CEMAMONJIJE<, , , >.AOJDAGFDFJK))]
	private Task PBGJHIKKPGB(TAction LBPAPOGAAHD, OIFOJPCGLDN BOFPLFGLCCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x21DD7E0", Offset = "0x21DC1E0", VA = "0x1821DD7E0")]
	private void HIIHPIPCJOB(TAction LBPAPOGAAHD, bool NDDCDOAEKAK, bool LMPFMFHIHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct KENKIBJBFBG<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : global::HBGOJJFIFEE<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private TPartialSnapshot[] CFCHPIKELCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private int EJAFECODDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private TDeps CALHALNNKLJ;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x2416490", Offset = "0x2414E90", VA = "0x182416490")]
	internal KENKIBJBFBG(TPartialSnapshot[] EKHNOLBIOCP, int IJDMINGFPOA, TDeps MOAJGIGLIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x2415EF0", Offset = "0x24148F0", VA = "0x182415EF0")]
	public global::EMINNCDMFKM<TFullSnapshot> IPFKJNDGEAB(TPartialSnapshot PNPHPOBIFIK)
	{
		return default(global::EMINNCDMFKM<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x2415EA0", Offset = "0x24148A0", VA = "0x182415EA0")]
	public bool ADHDOAHLPEI(TPartialSnapshot PNPHPOBIFIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x2416370", Offset = "0x2414D70", VA = "0x182416370")]
	public static global::KENKIBJBFBG<TPartialSnapshot, TFullSnapshot, TDeps> NDGDIJBCNJC(TDeps MOAJGIGLIIO)
	{
		return default(global::KENKIBJBFBG<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class NMIAIOABNDH : OMKBBKFADKC
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6072E40", Offset = "0x6071840", VA = "0x186072E40", Slot = "5")]
	public override string LMGGBHHFOJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x19CB650", Offset = "0x19CA050", VA = "0x1819CB650")]
	public NMIAIOABNDH()
	{
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
