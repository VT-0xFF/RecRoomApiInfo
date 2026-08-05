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
public interface OHOBLHGEKNO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int CNOEGGBANPG(in TAction BBFDPEJCJGH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	TAction BJCFBNBCDND(in TAction BBFDPEJCJGH);

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "2")]
	TAction MDEPMOEFPLK(in TAction BBFDPEJCJGH);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IReadOnlyList<TAction> KNCPIKJBJKA(in TAction BBFDPEJCJGH);

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OCJLLBOLIGI(in TAction BBFDPEJCJGH);

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HCCEMOGNEGD(in TAction BBFDPEJCJGH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KJHNBNFHBBO(in TAction BBFDPEJCJGH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool CFJMOJOIAOM(in TAction BBFDPEJCJGH);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KFKJNIJFHGO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	global::KAIKGGJFLNK<NGMMLBJDCEK> NFGNOKNCFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IIPOACPKKDA();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ACEAELEFHEI(in global::KAIKGGJFLNK<ONONLFICLLA> OPHEIECBKKM, in TAction BBFDPEJCJGH);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public sealed class NGMMLBJDCEK
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class ONONLFICLLA
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IIJIIFNGKJF<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> : global::JPBNCLMOFKH<TAction, Task<global::ANJGOILPOFD<object, IJNIBKNKMJK>>, TActionReceiver> where TActionReceiver : global::KPOBCJKLIPP<TAction, Task<global::ANJGOILPOFD<object, IJNIBKNKMJK>>> where TActionDeps : global::OHOBLHGEKNO<TAction> where TStaticNetSysDeps : global::KFKJNIJFHGO<TAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface GEGBCFOHDNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void KEMIPDDEAFD(in global::ANJGOILPOFD<object, IJNIBKNKMJK> JOPBNPIPIOF);

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MLPKLAIMEKI();

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "2")]
		global::ANJGOILPOFD<object, IJNIBKNKMJK> BJHAOPJINHN();

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void HBJLJNHKNDJ(Exception JLOJDMEEFHO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private sealed class OIOIJGMJLIA : GEGBCFOHDNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly TaskCompletionSource<global::ANJGOILPOFD<object, IJNIBKNKMJK>> PJCMJIJFCMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<global::ANJGOILPOFD<object, IJNIBKNKMJK>> EGGINCDHPIC;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x2A486A0", Offset = "0x2A46EA0", VA = "0x182A486A0")]
		private OIOIJGMJLIA(TaskCompletionSource<global::ANJGOILPOFD<object, IJNIBKNKMJK>> CHKICMKABKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2A48330", Offset = "0x2A46B30", VA = "0x182A48330")]
		public static OIOIJGMJLIA HFGDAGIMEIK(TaskCompletionSource<global::ANJGOILPOFD<object, IJNIBKNKMJK>> CHKICMKABKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x2A48580", Offset = "0x2A46D80", VA = "0x182A48580")]
		public void KEMIPDDEAFD(in global::ANJGOILPOFD<object, IJNIBKNKMJK> JOPBNPIPIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x2A485E0", Offset = "0x2A46DE0", VA = "0x182A485E0", Slot = "5")]
		public void MLPKLAIMEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2A48480", Offset = "0x2A46C80", VA = "0x182A48480", Slot = "6")]
		public global::ANJGOILPOFD<object, IJNIBKNKMJK> BJHAOPJINHN()
		{
			return default(global::ANJGOILPOFD<object, IJNIBKNKMJK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2A48520", Offset = "0x2A46D20", VA = "0x182A48520", Slot = "7")]
		public void HBJLJNHKNDJ(Exception JLOJDMEEFHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2A366A0", Offset = "0x2A34EA0", VA = "0x182A366A0", Slot = "4")]
		private void GFMBABCGDPK(in global::ANJGOILPOFD<object, IJNIBKNKMJK> JOPBNPIPIOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private sealed class ODDFFCCMNPK : GEGBCFOHDNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private readonly TaskCompletionSource<global::ANJGOILPOFD<object, IJNIBKNKMJK>> PJCMJIJFCMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private global::ANJGOILPOFD<object, IJNIBKNKMJK> DJFCDIIGKJD;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2806BE0", Offset = "0x28053E0", VA = "0x182806BE0")]
		private ODDFFCCMNPK(TaskCompletionSource<global::ANJGOILPOFD<object, IJNIBKNKMJK>> CHKICMKABKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2A48330", Offset = "0x2A46B30", VA = "0x182A48330")]
		public static ODDFFCCMNPK HFGDAGIMEIK(TaskCompletionSource<global::ANJGOILPOFD<object, IJNIBKNKMJK>> CHKICMKABKF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2A48400", Offset = "0x2A46C00", VA = "0x182A48400")]
		public void KEMIPDDEAFD(in global::ANJGOILPOFD<object, IJNIBKNKMJK> JOPBNPIPIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2A48420", Offset = "0x2A46C20", VA = "0x182A48420", Slot = "5")]
		public void MLPKLAIMEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5EB790", Offset = "0x5E9F90", VA = "0x1805EB790", Slot = "6")]
		public global::ANJGOILPOFD<object, IJNIBKNKMJK> BJHAOPJINHN()
		{
			return default(global::ANJGOILPOFD<object, IJNIBKNKMJK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x2A482D0", Offset = "0x2A46AD0", VA = "0x182A482D0", Slot = "7")]
		public void HBJLJNHKNDJ(Exception JLOJDMEEFHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2A366A0", Offset = "0x2A34EA0", VA = "0x182A366A0", Slot = "4")]
		private void GFMBABCGDPK(in global::ANJGOILPOFD<object, IJNIBKNKMJK> JOPBNPIPIOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private sealed class BCHJIJIENEM : GEGBCFOHDNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<global::ANJGOILPOFD<object, IJNIBKNKMJK>> EGGINCDHPIC;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2A367F0", Offset = "0x2A34FF0", VA = "0x182A367F0")]
		private BCHJIJIENEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2A366D0", Offset = "0x2A34ED0", VA = "0x182A366D0")]
		public static BCHJIJIENEM HFGDAGIMEIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2A36790", Offset = "0x2A34F90", VA = "0x182A36790")]
		public void KEMIPDDEAFD(in global::ANJGOILPOFD<object, IJNIBKNKMJK> JOPBNPIPIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
		public void MLPKLAIMEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x2A36640", Offset = "0x2A34E40", VA = "0x182A36640", Slot = "6")]
		public global::ANJGOILPOFD<object, IJNIBKNKMJK> BJHAOPJINHN()
		{
			return default(global::ANJGOILPOFD<object, IJNIBKNKMJK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
		public void HBJLJNHKNDJ(Exception JLOJDMEEFHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2A366A0", Offset = "0x2A34EA0", VA = "0x182A366A0", Slot = "4")]
		private void GFMBABCGDPK(in global::ANJGOILPOFD<object, IJNIBKNKMJK> JOPBNPIPIOF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class JCKAEIKHACE : GEGBCFOHDNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private global::ANJGOILPOFD<object, IJNIBKNKMJK> DJFCDIIGKJD;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xF360A0", Offset = "0xF348A0", VA = "0x180F360A0")]
		private JCKAEIKHACE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2A366D0", Offset = "0x2A34ED0", VA = "0x182A366D0")]
		public static JCKAEIKHACE HFGDAGIMEIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x14E2C70", Offset = "0x14E1470", VA = "0x1814E2C70")]
		public void KEMIPDDEAFD(in global::ANJGOILPOFD<object, IJNIBKNKMJK> JOPBNPIPIOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "5")]
		public void MLPKLAIMEKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60DD70", Offset = "0x60C570", VA = "0x18060DD70", Slot = "6")]
		public global::ANJGOILPOFD<object, IJNIBKNKMJK> BJHAOPJINHN()
		{
			return default(global::ANJGOILPOFD<object, IJNIBKNKMJK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x574910", Offset = "0x573110", VA = "0x180574910", Slot = "7")]
		public void HBJLJNHKNDJ(Exception JLOJDMEEFHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2A366A0", Offset = "0x2A34EA0", VA = "0x182A366A0", Slot = "4")]
		private void GFMBABCGDPK(in global::ANJGOILPOFD<object, IJNIBKNKMJK> JOPBNPIPIOF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NAMIDBHMHLC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public AsyncTaskMethodBuilder<global::ANJGOILPOFD<object, IJNIBKNKMJK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::IIJIIFNGKJF<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public global::KAIKGGJFLNK<NGMMLBJDCEK> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public global::KAIKGGJFLNK<ONONLFICLLA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter<global::ANJGOILPOFD<object, IJNIBKNKMJK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2A46D10", Offset = "0x2A45510", VA = "0x182A46D10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2A46F40", Offset = "0x2A45740", VA = "0x182A46F40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OPNFLNMOJDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AsyncTaskMethodBuilder<global::ANJGOILPOFD<object, IJNIBKNKMJK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::IIJIIFNGKJF<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::KAIKGGJFLNK<NGMMLBJDCEK> actorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::KAIKGGJFLNK<ONONLFICLLA> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private GEGBCFOHDNF <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2A49300", Offset = "0x2A47B00", VA = "0x182A49300", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2A49A90", Offset = "0x2A48290", VA = "0x182A49A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OBOHDAILPMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public global::IIJIIFNGKJF<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public GEGBCFOHDNF completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private GEGBCFOHDNF <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private TaskAwaiter<global::ANJGOILPOFD<object, IJNIBKNKMJK>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2A47930", Offset = "0x2A46130", VA = "0x182A47930", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x80FEF0", Offset = "0x80E6F0", VA = "0x18080FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private TActionReceiver EMIMJNDFNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly TActionDeps KCFCELNJHII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly TStaticNetSysDeps DKIMDCNIOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int BBPPNMNKDBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int ANJMGKHKIJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<global::KAIKGGJFLNK<ONONLFICLLA>, TaskCompletionSource<global::ANJGOILPOFD<object, IJNIBKNKMJK>>> BLIKHLLHKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly global::CNCIPLGLFDF<ONONLFICLLA> MMEABNCECMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private bool KHPDFPLAPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private int FMKALJAPNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private Task GIAOCFHOPCL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2A3FAE0", Offset = "0x2A3E2E0", VA = "0x182A3FAE0")]
	protected IIJIIFNGKJF(TActionDeps AIGAGFIPEAH, TStaticNetSysDeps MMOECBDCEAL, int ICBCLKCKFKP, int MKIEIDOKHPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F820", Offset = "0x2A3E020", VA = "0x182A3F820")]
	public static global::IIJIIFNGKJF<TAction, TActionReceiver, TActionDeps, TStaticNetSysDeps> HFGDAGIMEIK(TActionDeps AIGAGFIPEAH, TStaticNetSysDeps MMOECBDCEAL, [Optional] int? ICBCLKCKFKP, [Optional] int? MKIEIDOKHPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F100", Offset = "0x2A3D900", VA = "0x182A3F100")]
	public Task<global::ANJGOILPOFD<object, IJNIBKNKMJK>> ACEAELEFHEI(in TAction BBFDPEJCJGH, bool HJJKJFFLPBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F980", Offset = "0x2A3E180", VA = "0x182A3F980")]
	public void LNGLODCOHPF(in TActionReceiver JMKBPOBBAOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F6D0", Offset = "0x2A3DED0", VA = "0x182A3F6D0")]
	[AsyncStateMachine(typeof(global::IIJIIFNGKJF<, , , >.NAMIDBHMHLC))]
	public Task<global::ANJGOILPOFD<object, IJNIBKNKMJK>> FPPEHFEOAKE(global::KAIKGGJFLNK<NGMMLBJDCEK> OCMBECMMGPG, global::KAIKGGJFLNK<ONONLFICLLA> OPHEIECBKKM, TAction BBFDPEJCJGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F580", Offset = "0x2A3DD80", VA = "0x182A3F580")]
	[AsyncStateMachine(typeof(global::IIJIIFNGKJF<, , , >.OPNFLNMOJDK))]
	private Task<global::ANJGOILPOFD<object, IJNIBKNKMJK>> AGPDFOHLMJC(global::KAIKGGJFLNK<NGMMLBJDCEK> OCMBECMMGPG, global::KAIKGGJFLNK<ONONLFICLLA> OPHEIECBKKM, TAction BBFDPEJCJGH, Task NHHBJHDIDJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F990", Offset = "0x2A3E190", VA = "0x182A3F990")]
	[AsyncStateMachine(typeof(global::IIJIIFNGKJF<, , , >.OBOHDAILPMG))]
	private Task PCLJFHHGFHL(TAction BBFDPEJCJGH, GEGBCFOHDNF IEINPOICMEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F400", Offset = "0x2A3DC00", VA = "0x182A3F400")]
	private void AGDLACJPEEA(TAction BBFDPEJCJGH, bool HONBFCFCBIE, bool GBGNOHFICOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2A3F950", Offset = "0x2A3E150", VA = "0x182A3F950", Slot = "4")]
	private Task<global::ANJGOILPOFD<object, IJNIBKNKMJK>> LMGAGEFKPJA(in TAction BBFDPEJCJGH, bool HJJKJFFLPBI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class LCDKPDHEHCN : IJNIBKNKMJK
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x1256940", Offset = "0x1255140", VA = "0x181256940", Slot = "4")]
	public override string HLEMLFABCEH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x1239040", Offset = "0x1237840", VA = "0x181239040")]
	private LCDKPDHEHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x247DCF0", Offset = "0x247C4F0", VA = "0x18247DCF0")]
	public static global::ANJGOILPOFD<TOk, IJNIBKNKMJK> HFGDAGIMEIK<TOk>()
	{
		return default(global::ANJGOILPOFD<TOk, IJNIBKNKMJK>);
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
