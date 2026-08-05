using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class MKKNJEJMPAN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : NMFJILMJCKD.MMDIJOELNIA<TAction, TNetSys> where TReceiverDeps : NMFJILMJCKD.ODJJGBEELKC<TMActor, TAction, TReceiver> where TRootDeps : NMFJILMJCKD.GDKHLFMJOEH<TMRequest, TMActor, TAction, TRoot> where TDeps : NMFJILMJCKD.IKMENAPLHAI<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private interface KAFNNAJEKMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CFBAGKBHICD(in EGKNCMFMAMB<object, MNMNGBCAHAO> COGPMIAOIBF);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CIFPNLEGFKM();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		EGKNCMFMAMB<object, MNMNGBCAHAO> GPJHGGOFMFH();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IGKADEKPEHJ(Exception IOPPNPIHIME);
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private sealed class HBCDCPCGLDP : KAFNNAJEKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly TaskCompletionSource<EGKNCMFMAMB<object, MNMNGBCAHAO>> CMGACMJFPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<EGKNCMFMAMB<object, AGHPCJDDHII>> OFAEPKJGLJB;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38FFCB0", Offset = "0x38FE2B0", VA = "0x1838FFCB0")]
		private HBCDCPCGLDP(TaskCompletionSource<EGKNCMFMAMB<object, MNMNGBCAHAO>> MBJNFNPEPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1FF00C0", Offset = "0x1FEE6C0", VA = "0x181FF00C0")]
		public static HBCDCPCGLDP JBGFDEKBNPE(TaskCompletionSource<EGKNCMFMAMB<object, MNMNGBCAHAO>> MBJNFNPEPOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x38FF790", Offset = "0x38FDD90", VA = "0x1838FF790")]
		public void CFBAGKBHICD(in EGKNCMFMAMB<object, MNMNGBCAHAO> COGPMIAOIBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x38FF910", Offset = "0x38FDF10", VA = "0x1838FF910", Slot = "5")]
		public void CIFPNLEGFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x38FF9F0", Offset = "0x38FDFF0", VA = "0x1838FF9F0", Slot = "6")]
		public EGKNCMFMAMB<object, MNMNGBCAHAO> GPJHGGOFMFH()
		{
			return default(EGKNCMFMAMB<object, MNMNGBCAHAO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x38FFBB0", Offset = "0x38FE1B0", VA = "0x1838FFBB0", Slot = "7")]
		public void IGKADEKPEHJ(Exception IOPPNPIHIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0190", Offset = "0x1FEE790", VA = "0x181FF0190", Slot = "4")]
		private void NLPKHEIADLF(in EGKNCMFMAMB<object, MNMNGBCAHAO> COGPMIAOIBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private sealed class IIPOKNHBEAE : KAFNNAJEKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly TaskCompletionSource<EGKNCMFMAMB<object, MNMNGBCAHAO>> CMGACMJFPAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> BGGJPCKLKCH;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x15BDFA0", Offset = "0x15BC5A0", VA = "0x1815BDFA0")]
		private IIPOKNHBEAE(TaskCompletionSource<EGKNCMFMAMB<object, MNMNGBCAHAO>> MBJNFNPEPOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x1FF00C0", Offset = "0x1FEE6C0", VA = "0x181FF00C0")]
		public static IIPOKNHBEAE JBGFDEKBNPE(TaskCompletionSource<EGKNCMFMAMB<object, MNMNGBCAHAO>> MBJNFNPEPOE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1FEFF20", Offset = "0x1FEE520", VA = "0x181FEFF20")]
		public void CFBAGKBHICD(in EGKNCMFMAMB<object, MNMNGBCAHAO> COGPMIAOIBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1FEFF40", Offset = "0x1FEE540", VA = "0x181FEFF40", Slot = "5")]
		public void CIFPNLEGFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA62E30", Offset = "0xA61430", VA = "0x180A62E30", Slot = "6")]
		public EGKNCMFMAMB<object, MNMNGBCAHAO> GPJHGGOFMFH()
		{
			return default(EGKNCMFMAMB<object, MNMNGBCAHAO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0000", Offset = "0x1FEE600", VA = "0x181FF0000", Slot = "7")]
		public void IGKADEKPEHJ(Exception IOPPNPIHIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0190", Offset = "0x1FEE790", VA = "0x181FF0190", Slot = "4")]
		private void NLPKHEIADLF(in EGKNCMFMAMB<object, MNMNGBCAHAO> COGPMIAOIBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private sealed class AEAJDNGMFNF : KAFNNAJEKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<EGKNCMFMAMB<object, MNMNGBCAHAO>> OFAEPKJGLJB;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x26DC9A0", Offset = "0x26DAFA0", VA = "0x1826DC9A0")]
		private AEAJDNGMFNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x26DC8F0", Offset = "0x26DAEF0", VA = "0x1826DC8F0")]
		public static AEAJDNGMFNF JBGFDEKBNPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x26DC770", Offset = "0x26DAD70", VA = "0x1826DC770")]
		public void CFBAGKBHICD(in EGKNCMFMAMB<object, MNMNGBCAHAO> COGPMIAOIBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		public void CIFPNLEGFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x26DC830", Offset = "0x26DAE30", VA = "0x1826DC830", Slot = "6")]
		public EGKNCMFMAMB<object, MNMNGBCAHAO> GPJHGGOFMFH()
		{
			return default(EGKNCMFMAMB<object, MNMNGBCAHAO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		public void IGKADEKPEHJ(Exception IOPPNPIHIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0190", Offset = "0x1FEE790", VA = "0x181FF0190", Slot = "4")]
		private void NLPKHEIADLF(in EGKNCMFMAMB<object, MNMNGBCAHAO> COGPMIAOIBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private sealed class PHLDIGNJCGH : KAFNNAJEKMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> BGGJPCKLKCH;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		private PHLDIGNJCGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x26DC8F0", Offset = "0x26DAEF0", VA = "0x1826DC8F0")]
		public static PHLDIGNJCGH JBGFDEKBNPE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1E87700", Offset = "0x1E85D00", VA = "0x181E87700")]
		public void CFBAGKBHICD(in EGKNCMFMAMB<object, MNMNGBCAHAO> COGPMIAOIBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		public void CIFPNLEGFKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9420E0", Offset = "0x9406E0", VA = "0x1809420E0", Slot = "6")]
		public EGKNCMFMAMB<object, MNMNGBCAHAO> GPJHGGOFMFH()
		{
			return default(EGKNCMFMAMB<object, MNMNGBCAHAO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "7")]
		public void IGKADEKPEHJ(Exception IOPPNPIHIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1FF0190", Offset = "0x1FEE790", VA = "0x181FF0190", Slot = "4")]
		private void NLPKHEIADLF(in EGKNCMFMAMB<object, MNMNGBCAHAO> COGPMIAOIBF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class IBPHFDJECAG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public JIONBOANMAG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::MKKNJEJMPAN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskCompletionSource<EGKNCMFMAMB<object, MNMNGBCAHAO>> <tcs>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private JIONBOANMAG<TMRequest> <requestId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public IBPHFDJECAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1ACCC80", Offset = "0x1ACB280", VA = "0x181ACCC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class GCCGIEIKACO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JIONBOANMAG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::MKKNJEJMPAN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private TAction <finalAction>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TAction <action>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public GCCGIEIKACO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3B4B440", Offset = "0x3B49A40", VA = "0x183B4B440", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class DECHFKEHEEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public JIONBOANMAG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public JIONBOANMAG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public global::MKKNJEJMPAN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task <lastReceive>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> <nextReceive>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public DECHFKEHEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x25B50C0", Offset = "0x25B36C0", VA = "0x1825B50C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DBALOEAKABK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public JIONBOANMAG<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public JIONBOANMAG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public global::MKKNJEJMPAN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool <wasWaitingForSnapshot>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool <isMyAction>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private KAFNNAJEKMD <completion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public DBALOEAKABK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x25B1DB0", Offset = "0x25B03B0", VA = "0x1825B1DB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class PKDIIOAIIPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public KAFNNAJEKMD completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public global::MKKNJEJMPAN<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IEnumerator<TAction> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TAction <subAction>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private KAFNNAJEKMD <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <result>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private object <ok>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object <ok>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TAction <ok1>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private KAFNNAJEKMD <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private KAFNNAJEKMD <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private EGKNCMFMAMB<object, MNMNGBCAHAO> <>s__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<EGKNCMFMAMB<object, MNMNGBCAHAO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x97F990", Offset = "0x97DF90", VA = "0x18097F990")]
		public PKDIIOAIIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2C5FD10", Offset = "0x2C5E310", VA = "0x182C5FD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86F750", Offset = "0x86DD50", VA = "0x18086F750", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps NENKFPBEKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<JIONBOANMAG<TMRequest>, TaskCompletionSource<EGKNCMFMAMB<object, MNMNGBCAHAO>>> KBLIPGBHPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private BHMILADLCKH<TMRequest> KJDOOHDFOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int FNMEBDFHBHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Task MPBLIEALECB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps HIAMNNPOAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3485390", Offset = "0x3483990", VA = "0x183485390")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps PLAGKEOFIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3485390", Offset = "0x3483990", VA = "0x183485390")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps JEODCEHPLBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3485390", Offset = "0x3483990", VA = "0x183485390")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BFGLOBLBAEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xC104C0", Offset = "0xC0EAC0", VA = "0x180C104C0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xC104A0", Offset = "0xC0EAA0", VA = "0x180C104A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OHOLHJAGDOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC10490", Offset = "0xC0EA90", VA = "0x180C10490")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC10420", Offset = "0xC0EA20", VA = "0x180C10420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PNBBBBFHJOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B1A20", Offset = "0x9B0020", VA = "0x1809B1A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3486A70", Offset = "0x3485070", VA = "0x183486A70")]
	public MKKNJEJMPAN(TDeps OBBCAGMEJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x3484910", Offset = "0x3482F10", VA = "0x183484910")]
	public Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> AAPKGBIDMKK(TRoot MPEICFNBKOF, TNetSys NGFIFDJEECE, JIONBOANMAG<TMActor> NNPKLLDAPNB, TAction INJMGBDPOBO, bool ELJOHFEPCKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x34851B0", Offset = "0x34837B0", VA = "0x1834851B0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::MKKNJEJMPAN<, , , , , , , , , >.IBPHFDJECAG))]
	private Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> AAPKGBIDMKK(TRoot MPEICFNBKOF, JIONBOANMAG<TMActor> NNPKLLDAPNB, TAction INJMGBDPOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3485410", Offset = "0x3483A10", VA = "0x183485410")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::MKKNJEJMPAN<, , , , , , , , , >.GCCGIEIKACO))]
	private Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> EGLLOLPLEFC(TRoot MPEICFNBKOF, JIONBOANMAG<TMActor> NNPKLLDAPNB, TAction[] AJGALEDKINC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3485A70", Offset = "0x3484070", VA = "0x183485A70")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::MKKNJEJMPAN<, , , , , , , , , >.DECHFKEHEEH))]
	public Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> GALAKOGPBNJ(TRoot MPEICFNBKOF, TNetSys DEFIGKHPMEK, TReceiver BIHBIOFPAIP, JIONBOANMAG<TMActor> NNPKLLDAPNB, JIONBOANMAG<TMRequest> CMGGAOILMDM, TAction INJMGBDPOBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x34861A0", Offset = "0x34847A0", VA = "0x1834861A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::MKKNJEJMPAN<, , , , , , , , , >.DBALOEAKABK))]
	private Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> JDDJFLEKJAD(TRoot MPEICFNBKOF, TNetSys DEFIGKHPMEK, TReceiver BIHBIOFPAIP, JIONBOANMAG<TMActor> NNPKLLDAPNB, JIONBOANMAG<TMRequest> CMGGAOILMDM, TAction INJMGBDPOBO, Task NFFMGDAMHJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3486660", Offset = "0x3484C60", VA = "0x183486660")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::MKKNJEJMPAN<, , , , , , , , , >.PKDIIOAIIPO))]
	private Task KJNIEKAMIMK(TRoot MPEICFNBKOF, TNetSys DEFIGKHPMEK, TReceiver BIHBIOFPAIP, TAction INJMGBDPOBO, KAFNNAJEKMD OPBGPAOPIMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3485CB0", Offset = "0x34842B0", VA = "0x183485CB0")]
	private void HFPDDHBLKKD(TRoot MPEICFNBKOF, TNetSys DEFIGKHPMEK, TReceiver BIHBIOFPAIP, JIONBOANMAG<TMActor> NNPKLLDAPNB, TAction INJMGBDPOBO, bool NNCDOCPEKPH, bool DIPBNAJNGIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class NMFJILMJCKD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface GDKHLFMJOEH<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PAJAKFAAILC(TRoot MPEICFNBKOF);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JEDPMDMOENO(TRoot MPEICFNBKOF);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int JIFEELFGEPL(TRoot MPEICFNBKOF);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int FAPNDEKJKOA(TRoot MPEICFNBKOF);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PHOGJINJCIB(TRoot MPEICFNBKOF);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task AAPKGBIDMKK(TRoot MPEICFNBKOF, JIONBOANMAG<TMActor> NNPKLLDAPNB, JIONBOANMAG<TMRequest> CMGGAOILMDM, TAction INJMGBDPOBO, bool JAFCGGCBGBO = true);
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MMDIJOELNIA<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BPAPPNDOJOO(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction ENFJMJFFIFL(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction KCCPNNAGKGC(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> JCPPCLIFCLN(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] EFDGPNFJCPM(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO, int KLCGPIHLOMH);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NMMHCHNDFGN(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LHPIHDOKGLF(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BBFNPEFEDBC(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool OMBJHOBPKDL(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool NDOJOLCMOMC(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HPMNHLEGOOD(TNetSys HGFMINGHCIF, TAction INJMGBDPOBO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ODJJGBEELKC<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JIONBOANMAG<TMActor> OMIDFLKKFIL(TReceiver BIHBIOFPAIP);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<EGKNCMFMAMB<object, MNMNGBCAHAO>> GALAKOGPBNJ(TReceiver BIHBIOFPAIP, TAction INJMGBDPOBO);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] JOIBNDCKFCC(TReceiver BIHBIOFPAIP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface IKMENAPLHAI<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps HIAMNNPOAEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps JEODCEHPLBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps PLAGKEOFIIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct EDKFCAJHMDJ<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : HGMMFEPJEKJ.AKCFMOPIFCH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal TPartialSnapshot[] JFHNCHHOFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal int HPCHHEDDGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal TDeps NENKFPBEKNA;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2332C60", Offset = "0x2331260", VA = "0x182332C60")]
	internal EDKFCAJHMDJ(TPartialSnapshot[] HGIHCGMFMCN, int PEJIIPJFPLL, TDeps OBBCAGMEJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x2332BB0", Offset = "0x23311B0", VA = "0x182332BB0")]
	public static EDKFCAJHMDJ<TPartialSnapshot, TFullSnapshot, TDeps> JBGFDEKBNPE(TDeps OBBCAGMEJPG)
	{
		return default(EDKFCAJHMDJ<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HGMMFEPJEKJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface AKCFMOPIFCH<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OFBMEGKMFOP(in TPartialSnapshot NHOJIHKLOKP);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot ONOCJFIJEEL(TPartialSnapshot[] BFIGJKFJLHJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2AD4A90", Offset = "0x2AD3090", VA = "0x182AD4A90")]
	public static JJBGMPOBLPN<TFullSnapshot> GEPGCBFJNBF<TFullSnapshot, TPartialSnapshot, TDeps>(this ref EDKFCAJHMDJ<TPartialSnapshot, TFullSnapshot, TDeps> PBJDHAKDMFG, TPartialSnapshot NHOJIHKLOKP) where TDeps : AKCFMOPIFCH<TPartialSnapshot, TFullSnapshot>
	{
		return default(JJBGMPOBLPN<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2AD49C0", Offset = "0x2AD2FC0", VA = "0x182AD49C0")]
	public static bool AFMLECNDMPL<TPartialSnapshot, TFullSnapshot, TDeps>(this ref EDKFCAJHMDJ<TPartialSnapshot, TFullSnapshot, TDeps> PBJDHAKDMFG, TPartialSnapshot NHOJIHKLOKP) where TDeps : AKCFMOPIFCH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class KDFNMNDLKOJ : ONNGGILNJJP
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7275520", Offset = "0x7273B20", VA = "0x187275520", Slot = "7")]
	public override string EIGPMPLDIJO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x20C3400", Offset = "0x20C1A00", VA = "0x1820C3400")]
	public KDFNMNDLKOJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KBGOFNKGEBI<TPartialAction, TFullAction, TDeps> where TDeps : NKBLJMPFPLO.ADANOEDBGNK<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal TPartialAction[] DFCAJEGGNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	internal int JMEJLINPAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal TDeps NENKFPBEKNA;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2332C60", Offset = "0x2331260", VA = "0x182332C60")]
	internal KBGOFNKGEBI(TPartialAction[] ECEKHFIIGHA, int OGNBPEFJDND, TDeps OBBCAGMEJPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2332BB0", Offset = "0x23311B0", VA = "0x182332BB0")]
	public static KBGOFNKGEBI<TPartialAction, TFullAction, TDeps> JBGFDEKBNPE(TDeps OBBCAGMEJPG)
	{
		return default(KBGOFNKGEBI<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NKBLJMPFPLO
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ADANOEDBGNK<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EKBMBLAMPHB(in TPartialAction IKLENPNPIDN);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction CGEDPFCLDDF(TPartialAction[] CENBLNNOLCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2718E20", Offset = "0x2717420", VA = "0x182718E20")]
	public static JJBGMPOBLPN<TFullAction> GEPGCBFJNBF<TFullAction, TPartialAction, TDeps>(this ref KBGOFNKGEBI<TPartialAction, TFullAction, TDeps> PBJDHAKDMFG, TPartialAction IKLENPNPIDN) where TDeps : ADANOEDBGNK<TPartialAction, TFullAction>
	{
		return default(JJBGMPOBLPN<TFullAction>);
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
