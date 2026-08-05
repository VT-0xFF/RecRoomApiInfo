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
		[Cpp2IlInjected.Address(RVA = "0x343E260", Offset = "0x343D260", VA = "0x18343E260")]
		private KNLDMKNOJKK(TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> BMDFGGJGHHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2200", Offset = "0x1FE1200", VA = "0x181FE2200")]
		public static KNLDMKNOJKK BAPHMNFAJJN(TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> BMDFGGJGHHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x343E200", Offset = "0x343D200", VA = "0x18343E200")]
		public void PMGDHHKFMOL(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x343E140", Offset = "0x343D140", VA = "0x18343E140", Slot = "5")]
		public void PKDCJGPPMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x343E0A0", Offset = "0x343D0A0", VA = "0x18343E0A0", Slot = "6")]
		public global::BIPEOHBIPOP<object, DLKEDDGGOAP> HIPKCOCBAOD()
		{
			return default(global::BIPEOHBIPOP<object, DLKEDDGGOAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x343E040", Offset = "0x343D040", VA = "0x18343E040", Slot = "7")]
		public void GKLKKNJGEEA(Exception PEGIBFBCBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3434D00", Offset = "0x3433D00", VA = "0x183434D00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x18F69B0", Offset = "0x18F59B0", VA = "0x1818F69B0")]
		private LIKHNEBIAKH(TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> BMDFGGJGHHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1FE2200", Offset = "0x1FE1200", VA = "0x181FE2200")]
		public static LIKHNEBIAKH BAPHMNFAJJN(TaskCompletionSource<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> BMDFGGJGHHI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x334A680", Offset = "0x3349680", VA = "0x18334A680")]
		public void PMGDHHKFMOL(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x343E7D0", Offset = "0x343D7D0", VA = "0x18343E7D0", Slot = "5")]
		public void PKDCJGPPMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8AAB20", Offset = "0x8A9B20", VA = "0x1808AAB20", Slot = "6")]
		public global::BIPEOHBIPOP<object, DLKEDDGGOAP> HIPKCOCBAOD()
		{
			return default(global::BIPEOHBIPOP<object, DLKEDDGGOAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x343E770", Offset = "0x343D770", VA = "0x18343E770", Slot = "7")]
		public void GKLKKNJGEEA(Exception PEGIBFBCBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3434D00", Offset = "0x3433D00", VA = "0x183434D00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3974A30", Offset = "0x3973A30", VA = "0x183974A30")]
		private MFFJFPCFHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3434C40", Offset = "0x3433C40", VA = "0x183434C40")]
		public static MFFJFPCFHHE BAPHMNFAJJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x39749D0", Offset = "0x39739D0", VA = "0x1839749D0")]
		public void PMGDHHKFMOL(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		public void PKDCJGPPMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3974970", Offset = "0x3973970", VA = "0x183974970", Slot = "6")]
		public global::BIPEOHBIPOP<object, DLKEDDGGOAP> HIPKCOCBAOD()
		{
			return default(global::BIPEOHBIPOP<object, DLKEDDGGOAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "7")]
		public void GKLKKNJGEEA(Exception PEGIBFBCBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x3434D00", Offset = "0x3433D00", VA = "0x183434D00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
		private ELJHABDECKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3434C40", Offset = "0x3433C40", VA = "0x183434C40")]
		public static ELJHABDECKA BAPHMNFAJJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA1A3B0", Offset = "0xA193B0", VA = "0x180A1A3B0")]
		public void PMGDHHKFMOL(in global::BIPEOHBIPOP<object, DLKEDDGGOAP> AFGNBGMNGPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "5")]
		public void PKDCJGPPMNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5614A0", Offset = "0x5604A0", VA = "0x1805614A0", Slot = "6")]
		public global::BIPEOHBIPOP<object, DLKEDDGGOAP> HIPKCOCBAOD()
		{
			return default(global::BIPEOHBIPOP<object, DLKEDDGGOAP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x555010", Offset = "0x554010", VA = "0x180555010", Slot = "7")]
		public void GKLKKNJGEEA(Exception PEGIBFBCBDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3434D00", Offset = "0x3433D00", VA = "0x183434D00", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3975280", Offset = "0x3974280", VA = "0x183975280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x39754B0", Offset = "0x39744B0", VA = "0x1839754B0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3974AA0", Offset = "0x3973AA0", VA = "0x183974AA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3975230", Offset = "0x3974230", VA = "0x183975230", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3973FD0", Offset = "0x3972FD0", VA = "0x183973FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5CB9D0", Offset = "0x5CA9D0", VA = "0x1805CB9D0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x396C880", Offset = "0x396B880", VA = "0x18396C880")]
	protected FBAAPHJBMHG(TActionDeps FJILLBNHCBL, TNetSysStaticDeps OCHLGGPHGMI, int JCFDBPBLFGB, int HHGIIBOJJDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x396C050", Offset = "0x396B050", VA = "0x18396C050")]
	public static global::FBAAPHJBMHG<TAction, TActionReceiver, TActionDeps, TNetSysStaticDeps> BAPHMNFAJJN(TActionDeps FJILLBNHCBL, TNetSysStaticDeps OCHLGGPHGMI, [Optional] int? JCFDBPBLFGB, [Optional] int? HHGIIBOJJDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x396C2D0", Offset = "0x396B2D0", VA = "0x18396C2D0")]
	public Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> JIHHCIBGKMI(in TAction DJBODGKMGGL, bool KDILHDOOBEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x396C870", Offset = "0x396B870", VA = "0x18396C870")]
	public void PFFFOIAADML(in TActionReceiver IJPJNFBCFCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x396C5D0", Offset = "0x396B5D0", VA = "0x18396C5D0")]
	[AsyncStateMachine(typeof(global::FBAAPHJBMHG<, , , >.OAMBNFKOLEH))]
	public Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> KCJDPCGOHPH(global::EMJMCNHDCKE<NMDMCNKPNFB> OFDDFGBMNKD, global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, TAction DJBODGKMGGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x396C180", Offset = "0x396B180", VA = "0x18396C180")]
	[AsyncStateMachine(typeof(global::FBAAPHJBMHG<, , , >.MOPFNMAMFND))]
	private Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> GJACDFHMIHA(global::EMJMCNHDCKE<NMDMCNKPNFB> OFDDFGBMNKD, global::EMJMCNHDCKE<PLMPGGHOKJJ> GMBFCMDCOMC, TAction DJBODGKMGGL, Task BAJMLCFIAHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x396C720", Offset = "0x396B720", VA = "0x18396C720")]
	[AsyncStateMachine(typeof(global::FBAAPHJBMHG<, , , >.LJKKHBNJHNK))]
	private Task NOPEOPHAIHJ(TAction DJBODGKMGGL, DNBFHGIJOBL KMHGFGKKMNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x396BED0", Offset = "0x396AED0", VA = "0x18396BED0")]
	private void ANFAKMKKPGG(TAction DJBODGKMGGL, bool EBCHHEOMPFA, bool HFDFEHMEINO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x1C46E10", Offset = "0x1C45E10", VA = "0x181C46E10", Slot = "4")]
	private Task<global::BIPEOHBIPOP<object, DLKEDDGGOAP>> EEIIPBBMIHC(in TAction DJBODGKMGGL, bool KDILHDOOBEL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class DFIGGNEGOFL : DLKEDDGGOAP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4DA97C0", Offset = "0x4DA87C0", VA = "0x184DA97C0", Slot = "4")]
	public override string FCLGPCIMGFI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1919EE0", Offset = "0x1918EE0", VA = "0x181919EE0")]
	private DFIGGNEGOFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x18C81B0", Offset = "0x18C71B0", VA = "0x1818C81B0")]
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
