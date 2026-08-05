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
public interface NDGMIODNGAD<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EKEFCIGOKLF(in TAction DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction HPBCOMBNFJJ(in TAction DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction IKBLBNHDNGN(in TAction DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> MAOOMPMAINH(in TAction DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MONINGNAJEE(in TAction DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LHDNBFKJIFD(in TAction DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool LGOBEBNNILN(in TAction DJBODGKMGGL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool FLFNPPIKFFF(in TAction DJBODGKMGGL);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LHFKLJDBOMN<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::EMJMCNHDCKE<NMDMCNKPNFB> AEGNGGMAOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NLCGHLEDMME();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIHHCIBGKMI(in global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, in TAction DJBODGKMGGL);
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct NMDMCNKPNFB
{
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000005")]
public readonly struct PLMPGGHOKJJ
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> : global::KPPFLOLLHAM<TAction, Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>>, TActionReceiver> where TActionReceiver : global::GAECGMPHMKD<TAction, Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>>> where TActionDeps : global::NDGMIODNGAD<TAction> where TNetSysStaticDeps : global::LHFKLJDBOMN<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface DNBFHGIJOBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PMGDHHKFMOL(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PKDCJGPPMNB();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::BIPEOHBIPOP<object, DLKEDDGGOAP> HIPKCOCBAOD();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GKLKKNJGEEA(Exception PEGIBFBCBDC);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class KNLDMKNOJKK : DNBFHGIJOBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> ENPDGEAODLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> IEFDGHEHEJG;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x35D1790", Offset = "0x35CFF90", VA = "0x1835D1790")]
		private KNLDMKNOJKK(TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> BMDFGGJGHHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCEE0", Offset = "0x2BCB6E0", VA = "0x182BCCEE0")]
		public static KNLDMKNOJKK BAPHMNFAJJN(TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> BMDFGGJGHHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x35D1730", Offset = "0x35CFF30", VA = "0x1835D1730")]
		public void PMGDHHKFMOL(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x35D1670", Offset = "0x35CFE70", VA = "0x1835D1670", Slot = "5")]
		public void PKDCJGPPMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x35D15D0", Offset = "0x35CFDD0", VA = "0x1835D15D0", Slot = "6")]
		public global::BIPEOHBIPOP<object, DLKEDDGGOAP> HIPKCOCBAOD()
		{
			return default(global::BIPEOHBIPOP<object, DLKEDDGGOAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x35D1570", Offset = "0x35CFD70", VA = "0x1835D1570", Slot = "7")]
		public void GKLKKNJGEEA(Exception PEGIBFBCBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x35C9800", Offset = "0x35C8000", VA = "0x1835C9800", Slot = "4")]
		private void BDHPACIMPFN(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class LIKHNEBIAKH : DNBFHGIJOBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> ENPDGEAODLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::BIPEOHBIPOP<object, DLKEDDGGOAP> MFFLPHOODGD;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x1F9B960", Offset = "0x1F9A160", VA = "0x181F9B960")]
		private LIKHNEBIAKH(TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> BMDFGGJGHHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2BCCEE0", Offset = "0x2BCB6E0", VA = "0x182BCCEE0")]
		public static LIKHNEBIAKH BAPHMNFAJJN(TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> BMDFGGJGHHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3570160", Offset = "0x356E960", VA = "0x183570160")]
		public void PMGDHHKFMOL(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x35D1D00", Offset = "0x35D0500", VA = "0x1835D1D00", Slot = "5")]
		public void PKDCJGPPMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x562000", Offset = "0x560800", VA = "0x180562000", Slot = "6")]
		public global::BIPEOHBIPOP<object, DLKEDDGGOAP> HIPKCOCBAOD()
		{
			return default(global::BIPEOHBIPOP<object, DLKEDDGGOAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x35D1CA0", Offset = "0x35D04A0", VA = "0x1835D1CA0", Slot = "7")]
		public void GKLKKNJGEEA(Exception PEGIBFBCBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x35C9800", Offset = "0x35C8000", VA = "0x1835C9800", Slot = "4")]
		private void BDHPACIMPFN(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class MFFJFPCFHHE : DNBFHGIJOBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> IEFDGHEHEJG;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x35D27C0", Offset = "0x35D0FC0", VA = "0x1835D27C0")]
		private MFFJFPCFHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x35C9740", Offset = "0x35C7F40", VA = "0x1835C9740")]
		public static MFFJFPCFHHE BAPHMNFAJJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x35D2760", Offset = "0x35D0F60", VA = "0x1835D2760")]
		public void PMGDHHKFMOL(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "5")]
		public void PKDCJGPPMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x35D2700", Offset = "0x35D0F00", VA = "0x1835D2700", Slot = "6")]
		public global::BIPEOHBIPOP<object, DLKEDDGGOAP> HIPKCOCBAOD()
		{
			return default(global::BIPEOHBIPOP<object, DLKEDDGGOAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "7")]
		public void GKLKKNJGEEA(Exception PEGIBFBCBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x35C9800", Offset = "0x35C8000", VA = "0x1835C9800", Slot = "4")]
		private void BDHPACIMPFN(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class ELJHABDECKA : DNBFHGIJOBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::BIPEOHBIPOP<object, DLKEDDGGOAP> MFFLPHOODGD;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
		private ELJHABDECKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x35C9740", Offset = "0x35C7F40", VA = "0x1835C9740")]
		public static ELJHABDECKA BAPHMNFAJJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x10F7FD0", Offset = "0x10F67D0", VA = "0x1810F7FD0")]
		public void PMGDHHKFMOL(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "5")]
		public void PKDCJGPPMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7FEE80", Offset = "0x7FD680", VA = "0x1807FEE80", Slot = "6")]
		public global::BIPEOHBIPOP<object, DLKEDDGGOAP> HIPKCOCBAOD()
		{
			return default(global::BIPEOHBIPOP<object, DLKEDDGGOAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x561E80", Offset = "0x560680", VA = "0x180561E80", Slot = "7")]
		public void GKLKKNJGEEA(Exception PEGIBFBCBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35C9800", Offset = "0x35C8000", VA = "0x1835C9800", Slot = "4")]
		private void BDHPACIMPFN(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct OAMBNFKOLEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::EMJMCNHDCKE<NMDMCNKPNFB> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::EMJMCNHDCKE<PLMPGGHOKJJ> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x35D8060", Offset = "0x35D6860", VA = "0x1835D8060", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x35D8290", Offset = "0x35D6A90", VA = "0x1835D8290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct MOPFNMAMFND : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::EMJMCNHDCKE<NMDMCNKPNFB> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::EMJMCNHDCKE<PLMPGGHOKJJ> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private DNBFHGIJOBL <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x35D2830", Offset = "0x35D1030", VA = "0x1835D2830", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x35D2FC0", Offset = "0x35D17C0", VA = "0x1835D2FC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LJKKHBNJHNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public DNBFHGIJOBL completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DNBFHGIJOBL <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x35D1D60", Offset = "0x35D0560", VA = "0x1835D1D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7006D0", Offset = "0x6FEED0", VA = "0x1807006D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver EFDKNGJAABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps FAIEFDDOFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TNetSysStaticDeps MPKHEKANGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int GGDLBCANCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int LHAPABAEABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::EMJMCNHDCKE<PLMPGGHOKJJ>, TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>>> MALKOHMDGGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::IADGJABECBM<PLMPGGHOKJJ> JJLNAPDGLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool AEFMNKDMPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int DBCDEHMGIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task ONONLGBPEMN;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3D55560", Offset = "0x3D53D60", VA = "0x183D55560")]
	protected FBAAPHJBMHG(TActionDeps FJILLBNHCBL, TNetSysStaticDeps OCHLGGPHGMI, int JCFDBPBLFGB, int HHGIIBOJJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3D54CB0", Offset = "0x3D534B0", VA = "0x183D54CB0")]
	public static global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> BAPHMNFAJJN(TActionDeps FJILLBNHCBL, TNetSysStaticDeps OCHLGGPHGMI, [Optional] int? JCFDBPBLFGB, [Optional] int? HHGIIBOJJDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3D54F30", Offset = "0x3D53730", VA = "0x183D54F30")]
	public Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> JIHHCIBGKMI(in TAction DJBODGKMGGL, bool KDILHDOOBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3D55550", Offset = "0x3D53D50", VA = "0x183D55550")]
	public void PFFFOIAADML(in TActionReceiver IJPJNFBCFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3D552B0", Offset = "0x3D53AB0", VA = "0x183D552B0")]
	[AsyncStateMachine(typeof(global::FBAAPHJBMHG<, , , >.OAMBNFKOLEH))]
	public Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> KCJDPCGOHPH(global::EMJMCNHDCKE<NMDMCNKPNFB> OFDDFGBMNKD, global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, TAction DJBODGKMGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3D54DE0", Offset = "0x3D535E0", VA = "0x183D54DE0")]
	[AsyncStateMachine(typeof(global::FBAAPHJBMHG<, , , >.MOPFNMAMFND))]
	private Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> GJACDFHMIHA(global::EMJMCNHDCKE<NMDMCNKPNFB> OFDDFGBMNKD, global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, TAction DJBODGKMGGL, Task BAJMLCFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3D55400", Offset = "0x3D53C00", VA = "0x183D55400")]
	[AsyncStateMachine(typeof(global::FBAAPHJBMHG<, , , >.LJKKHBNJHNK))]
	private Task NOPEOPHAIHJ(TAction DJBODGKMGGL, DNBFHGIJOBL KMHGFGKKMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3D54AE0", Offset = "0x3D532E0", VA = "0x183D54AE0")]
	private void ANFAKMKKPGG(TAction DJBODGKMGGL, bool EBCHHEOMPFA, bool HFDFEHMEINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x33689B0", Offset = "0x33671B0", VA = "0x1833689B0", Slot = "4")]
	private Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> EEIIPBBMIHC(in TAction DJBODGKMGGL, bool KDILHDOOBEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DFIGGNEGOFL : DLKEDDGGOAP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0xC73CB0", Offset = "0xC724B0", VA = "0x180C73CB0", Slot = "4")]
	public override string FCLGPCIMGFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0xC73CE0", Offset = "0xC724E0", VA = "0x180C73CE0")]
	private DFIGGNEGOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1FBB2E0", Offset = "0x1FB9AE0", VA = "0x181FBB2E0")]
	public static global::BIPEOHBIPOP<TOk, DLKEDDGGOAP> BAPHMNFAJJN<TOk>()
	{
		return default(global::BIPEOHBIPOP<TOk, DLKEDDGGOAP>);
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
