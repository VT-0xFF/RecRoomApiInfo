using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class APHOENCOAFM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : JEGAPLKDOBP.DMCFHCHOCEC<TAction, TNetSys> where TReceiverDeps : JEGAPLKDOBP.ELMJCDMIINB<TMActor, TAction, TReceiver> where TRootDeps : JEGAPLKDOBP.DCBHIDENBCO<TMRequest, TMActor, TAction, TRoot> where TDeps : JEGAPLKDOBP.BEFCCFFNKOK<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private interface BEJDLHABMAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DLDAAPGLAAO(in CLFKONEBOLH<object, IDFBCILOOIB> GAFKIBJKPNO);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MHOHCDEECMG();

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CLFKONEBOLH<object, IDFBCILOOIB> NEKEOPCHIIM();

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void DJIANMFMEKA(Exception ODBCLHKGDHB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private sealed class DKIJMAHELBM : BEJDLHABMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private readonly TaskCompletionSource<CLFKONEBOLH<object, IDFBCILOOIB>> JGPDDMMHLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private readonly List<CLFKONEBOLH<object, IAPKFGPHFCN>> NKNFMPENHOI;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3777EB0", Offset = "0x37770B0", VA = "0x183777EB0")]
		private DKIJMAHELBM(TaskCompletionSource<CLFKONEBOLH<object, IDFBCILOOIB>> ELJNJOHOLGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2F66250", Offset = "0x2F65450", VA = "0x182F66250")]
		public static DKIJMAHELBM NMBJFIHLDEO(TaskCompletionSource<CLFKONEBOLH<object, IDFBCILOOIB>> ELJNJOHOLGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x37779B0", Offset = "0x3776BB0", VA = "0x1837779B0")]
		public void DLDAAPGLAAO(in CLFKONEBOLH<object, IDFBCILOOIB> GAFKIBJKPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3777AF0", Offset = "0x3776CF0", VA = "0x183777AF0", Slot = "5")]
		public void MHOHCDEECMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3777D60", Offset = "0x3776F60", VA = "0x183777D60", Slot = "6")]
		public CLFKONEBOLH<object, IDFBCILOOIB> NEKEOPCHIIM()
		{
			return default(CLFKONEBOLH<object, IDFBCILOOIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x37778F0", Offset = "0x3776AF0", VA = "0x1837778F0", Slot = "7")]
		public void DJIANMFMEKA(Exception ODBCLHKGDHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1CBDE80", Offset = "0x1CBD080", VA = "0x181CBDE80", Slot = "4")]
		private void DCLDELIIKDH(in CLFKONEBOLH<object, IDFBCILOOIB> GAFKIBJKPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private sealed class NHFHBANNHPH : BEJDLHABMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly TaskCompletionSource<CLFKONEBOLH<object, IDFBCILOOIB>> JGPDDMMHLHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private CLFKONEBOLH<object, IDFBCILOOIB> MAJPDKCEJOL;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x1CCC600", Offset = "0x1CCB800", VA = "0x181CCC600")]
		private NHFHBANNHPH(TaskCompletionSource<CLFKONEBOLH<object, IDFBCILOOIB>> ELJNJOHOLGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2F66250", Offset = "0x2F65450", VA = "0x182F66250")]
		public static NHFHBANNHPH NMBJFIHLDEO(TaskCompletionSource<CLFKONEBOLH<object, IDFBCILOOIB>> ELJNJOHOLGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x930300", Offset = "0x92F500", VA = "0x180930300")]
		public void DLDAAPGLAAO(in CLFKONEBOLH<object, IDFBCILOOIB> GAFKIBJKPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2F66190", Offset = "0x2F65390", VA = "0x182F66190", Slot = "5")]
		public void MHOHCDEECMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8F8BD0", Offset = "0x8F7DD0", VA = "0x1808F8BD0", Slot = "6")]
		public CLFKONEBOLH<object, IDFBCILOOIB> NEKEOPCHIIM()
		{
			return default(CLFKONEBOLH<object, IDFBCILOOIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2F66130", Offset = "0x2F65330", VA = "0x182F66130", Slot = "7")]
		public void DJIANMFMEKA(Exception ODBCLHKGDHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1CBDE80", Offset = "0x1CBD080", VA = "0x181CBDE80", Slot = "4")]
		private void DCLDELIIKDH(in CLFKONEBOLH<object, IDFBCILOOIB> GAFKIBJKPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	private sealed class CJOIBPHLNPL : BEJDLHABMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly List<CLFKONEBOLH<object, IDFBCILOOIB>> NKNFMPENHOI;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5069C00", Offset = "0x5068E00", VA = "0x185069C00")]
		private CJOIBPHLNPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4663250", Offset = "0x4662450", VA = "0x184663250")]
		public static CJOIBPHLNPL NMBJFIHLDEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5069AE0", Offset = "0x5068CE0", VA = "0x185069AE0")]
		public void DLDAAPGLAAO(in CLFKONEBOLH<object, IDFBCILOOIB> GAFKIBJKPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		public void MHOHCDEECMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5069BA0", Offset = "0x5068DA0", VA = "0x185069BA0", Slot = "6")]
		public CLFKONEBOLH<object, IDFBCILOOIB> NEKEOPCHIIM()
		{
			return default(CLFKONEBOLH<object, IDFBCILOOIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		public void DJIANMFMEKA(Exception ODBCLHKGDHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1CBDE80", Offset = "0x1CBD080", VA = "0x181CBDE80", Slot = "4")]
		private void DCLDELIIKDH(in CLFKONEBOLH<object, IDFBCILOOIB> GAFKIBJKPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private sealed class NNAOEMNMOOF : BEJDLHABMAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private CLFKONEBOLH<object, IDFBCILOOIB> MAJPDKCEJOL;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		private NNAOEMNMOOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x4663250", Offset = "0x4662450", VA = "0x184663250")]
		public static NNAOEMNMOOF NMBJFIHLDEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x2A94ED0", Offset = "0x2A940D0", VA = "0x182A94ED0")]
		public void DLDAAPGLAAO(in CLFKONEBOLH<object, IDFBCILOOIB> GAFKIBJKPNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		public void MHOHCDEECMG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x980060", Offset = "0x97F260", VA = "0x180980060", Slot = "6")]
		public CLFKONEBOLH<object, IDFBCILOOIB> NEKEOPCHIIM()
		{
			return default(CLFKONEBOLH<object, IDFBCILOOIB>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "7")]
		public void DJIANMFMEKA(Exception ODBCLHKGDHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1CBDE80", Offset = "0x1CBD080", VA = "0x181CBDE80", Slot = "4")]
		private void DCLDELIIKDH(in CLFKONEBOLH<object, IDFBCILOOIB> GAFKIBJKPNO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class LNJAMCFIEAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public AsyncTaskMethodBuilder<CLFKONEBOLH<object, IDFBCILOOIB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public IECPEPBGFBA<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public global::APHOENCOAFM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private TaskCompletionSource<CLFKONEBOLH<object, IDFBCILOOIB>> <tcs>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private IECPEPBGFBA<TMRequest> <requestId>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private TaskAwaiter<CLFKONEBOLH<object, IDFBCILOOIB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public LNJAMCFIEAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x42A0D20", Offset = "0x429FF20", VA = "0x1842A0D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class ABEIOMCIOCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AsyncTaskMethodBuilder<CLFKONEBOLH<object, IDFBCILOOIB>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public IECPEPBGFBA<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public global::APHOENCOAFM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		private CLFKONEBOLH<object, IDFBCILOOIB> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private TaskAwaiter<CLFKONEBOLH<object, IDFBCILOOIB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public ABEIOMCIOCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x42DCCB0", Offset = "0x42DBEB0", VA = "0x1842DCCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class LGMGKJPBGCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AsyncTaskMethodBuilder<CLFKONEBOLH<object, IDFBCILOOIB>> <>t__builder;

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
		public IECPEPBGFBA<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public IECPEPBGFBA<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public global::APHOENCOAFM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Task <lastReceive>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private Task<CLFKONEBOLH<object, IDFBCILOOIB>> <nextReceive>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<CLFKONEBOLH<object, IDFBCILOOIB>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public LGMGKJPBGCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x38DCE80", Offset = "0x38DC080", VA = "0x1838DCE80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class PPOFHHPLFGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public AsyncTaskMethodBuilder<CLFKONEBOLH<object, IDFBCILOOIB>> <>t__builder;

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
		public IECPEPBGFBA<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public IECPEPBGFBA<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public global::APHOENCOAFM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private bool <wasWaitingForSnapshot>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool <isMyAction>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private BEJDLHABMAM <completion>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Exception <ex>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public PPOFHHPLFGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x31D83A0", Offset = "0x31D75A0", VA = "0x1831D83A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class NNMHEJFBNHB : IAsyncStateMachine
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
		public BEJDLHABMAM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public global::APHOENCOAFM<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private IEnumerator<TAction> <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TAction <subAction>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private BEJDLHABMAM <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <>s__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <result>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private object <ok>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <result>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private object <ok>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private TAction <ok1>5__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private BEJDLHABMAM <>s__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <>s__13;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private BEJDLHABMAM <>s__14;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private CLFKONEBOLH<object, IDFBCILOOIB> <>s__15;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<CLFKONEBOLH<object, IDFBCILOOIB>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x1913A50", Offset = "0x1912C50", VA = "0x181913A50")]
		public NNMHEJFBNHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x466ECB0", Offset = "0x466DEB0", VA = "0x18466ECB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x841A70", Offset = "0x840C70", VA = "0x180841A70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly TDeps APHBGODKBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly Dictionary<IECPEPBGFBA<TMRequest>, TaskCompletionSource<CLFKONEBOLH<object, IDFBCILOOIB>>> MFJBJOCDPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OOIHPNDPLEB<TMRequest> EINALDFGHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int DBKOAACKACM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private Task GECPIALMFFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps LGOOPOEDBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3937440", Offset = "0x3936640", VA = "0x183937440")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps OJKEFAHPBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x3937440", Offset = "0x3936640", VA = "0x183937440")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps FBAFGLCFAAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x3937440", Offset = "0x3936640", VA = "0x183937440")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CCMIOLLCFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99AF00", Offset = "0x99A100", VA = "0x18099AF00")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x99AF40", Offset = "0x99A140", VA = "0x18099AF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OMJFPPKDCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAEC550", Offset = "0xAEB750", VA = "0x180AEC550")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD8C670", Offset = "0xD8B870", VA = "0x180D8C670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HHPMNCADCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F9D40", Offset = "0x8F8F40", VA = "0x1808F9D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3939540", Offset = "0x3938740", VA = "0x183939540")]
	public APHOENCOAFM(TDeps FLJLOPPINOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x39374C0", Offset = "0x39366C0", VA = "0x1839374C0")]
	public Task<CLFKONEBOLH<object, IDFBCILOOIB>> GMAELNDOOEH(TRoot NPDELNKHCNM, TNetSys CNPNAHBMLAL, IECPEPBGFBA<TMActor> DPPFMLJLOBF, TAction JFFMHPNGJBK, bool DLHKIKAKMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x3937D00", Offset = "0x3936F00", VA = "0x183937D00")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::APHOENCOAFM<, , , , , , , , , >.LNJAMCFIEAN))]
	private Task<CLFKONEBOLH<object, IDFBCILOOIB>> GMAELNDOOEH(TRoot NPDELNKHCNM, IECPEPBGFBA<TMActor> DPPFMLJLOBF, TAction JFFMHPNGJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3939180", Offset = "0x3938380", VA = "0x183939180")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::APHOENCOAFM<, , , , , , , , , >.ABEIOMCIOCL))]
	private Task<CLFKONEBOLH<object, IDFBCILOOIB>> POCGMHCFKPM(TRoot NPDELNKHCNM, IECPEPBGFBA<TMActor> DPPFMLJLOBF, TAction[] PAILLJKMHAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3938120", Offset = "0x3937320", VA = "0x183938120")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::APHOENCOAFM<, , , , , , , , , >.LGMGKJPBGCM))]
	public Task<CLFKONEBOLH<object, IDFBCILOOIB>> IFGAODEDJAC(TRoot NPDELNKHCNM, TNetSys JIKHGJKFMAD, TReceiver OBPGNCIMCCF, IECPEPBGFBA<TMActor> DPPFMLJLOBF, IECPEPBGFBA<TMRequest> KNDAKNLFNCF, TAction JFFMHPNGJBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x3938360", Offset = "0x3937560", VA = "0x183938360")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::APHOENCOAFM<, , , , , , , , , >.PPOFHHPLFGH))]
	private Task<CLFKONEBOLH<object, IDFBCILOOIB>> IOGHONCONEB(TRoot NPDELNKHCNM, TNetSys JIKHGJKFMAD, TReceiver OBPGNCIMCCF, IECPEPBGFBA<TMActor> DPPFMLJLOBF, IECPEPBGFBA<TMRequest> KNDAKNLFNCF, TAction JFFMHPNGJBK, Task JOCPKLCFFGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3938F80", Offset = "0x3938180", VA = "0x183938F80")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(global::APHOENCOAFM<, , , , , , , , , >.NNMHEJFBNHB))]
	private Task LDDBLFKMAFJ(TRoot NPDELNKHCNM, TNetSys JIKHGJKFMAD, TReceiver OBPGNCIMCCF, TAction JFFMHPNGJBK, BEJDLHABMAM CBCELJBLMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x3938B60", Offset = "0x3937D60", VA = "0x183938B60")]
	private void LALENCAOIOE(TRoot NPDELNKHCNM, TNetSys JIKHGJKFMAD, TReceiver OBPGNCIMCCF, IECPEPBGFBA<TMActor> DPPFMLJLOBF, TAction JFFMHPNGJBK, bool JJCHIJGKCIL, bool JIAMGOELLAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JEGAPLKDOBP
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface DCBHIDENBCO<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LOPJNBPJJEO(TRoot NPDELNKHCNM);

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int FGHGBLJMMJD(TRoot NPDELNKHCNM);

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int ELANAJDOBJC(TRoot NPDELNKHCNM);

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int CLIPLIKNPAF(TRoot NPDELNKHCNM);

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HPJAHDJECGP(TRoot NPDELNKHCNM);

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task GMAELNDOOEH(TRoot NPDELNKHCNM, IECPEPBGFBA<TMActor> DPPFMLJLOBF, IECPEPBGFBA<TMRequest> KNDAKNLFNCF, TAction JFFMHPNGJBK, bool PPLGNHBAEJL = true);
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DMCFHCHOCEC<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LIJJPEGOEPC(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction AIKAOLONBNM(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction PAHFNJEABFK(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> OOEBAGPHJOM(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] EBLJIHMCFGE(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK, int AABEDGAGFIE);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool BMAOIIMIEAM(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DLDMGMCAIEN(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LNJPGFBJOGJ(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool FEIGINLCHKC(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool HGJMOGMMBCP(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool IFGBFBPHJDC(TNetSys DIFDNCKPNJA, TAction JFFMHPNGJBK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface ELMJCDMIINB<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IECPEPBGFBA<TMActor> LKOGIMAAAOA(TReceiver OBPGNCIMCCF);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CLFKONEBOLH<object, IDFBCILOOIB>> IFGAODEDJAC(TReceiver OBPGNCIMCCF, TAction JFFMHPNGJBK);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] BLJMHGDPIMI(TReceiver OBPGNCIMCCF);
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface BEFCCFFNKOK<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps LGOOPOEDBLH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps FBAFGLCFAAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps OJKEFAHPBLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct LNDFMNBKIGP<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : NIDDLIALBNB.BDFCMKMPGEH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	internal TPartialSnapshot[] CGJEKPIGHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal int IDAMPJJLBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	internal TDeps APHBGODKBHN;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x42A0630", Offset = "0x429F830", VA = "0x1842A0630")]
	internal LNDFMNBKIGP(TPartialSnapshot[] FANHPFNDILH, int DGLOBDODPKM, TDeps FLJLOPPINOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x42A05D0", Offset = "0x429F7D0", VA = "0x1842A05D0")]
	public static LNDFMNBKIGP<TPartialSnapshot, TFullSnapshot, TDeps> NMBJFIHLDEO(TDeps FLJLOPPINOK)
	{
		return default(LNDFMNBKIGP<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NIDDLIALBNB
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface BDFCMKMPGEH<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MMGOFICFBGN(in TPartialSnapshot ECFKNOFCPJF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot DFHBBHMLEDC(TPartialSnapshot[] KBDFOBMMNBF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7C40", Offset = "0x2FE6E40", VA = "0x182FE7C40")]
	public static NFEJPMDMHAA<TFullSnapshot> JONHIJHGPOE<TFullSnapshot, TPartialSnapshot, TDeps>(this ref LNDFMNBKIGP<TPartialSnapshot, TFullSnapshot, TDeps> DCMHODHEGEC, TPartialSnapshot ECFKNOFCPJF) where TDeps : BDFCMKMPGEH<TPartialSnapshot, TFullSnapshot>
	{
		return default(NFEJPMDMHAA<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x2FE7D90", Offset = "0x2FE6F90", VA = "0x182FE7D90")]
	public static bool KOHEMFEAKOF<TPartialSnapshot, TFullSnapshot, TDeps>(this ref LNDFMNBKIGP<TPartialSnapshot, TFullSnapshot, TDeps> DCMHODHEGEC, TPartialSnapshot ECFKNOFCPJF) where TDeps : BDFCMKMPGEH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class COLLOHIEPAK : EOPGPABPDLG
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x15AED50", Offset = "0x15ADF50", VA = "0x1815AED50", Slot = "7")]
	public override string OFGOCDOINLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x15AED80", Offset = "0x15ADF80", VA = "0x1815AED80")]
	public COLLOHIEPAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct DCLGJIDDEOG<TPartialAction, TFullAction, TDeps> where TDeps : NHEEHKJMOEF.GDHOHAKEKAA<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	internal TPartialAction[] NOCDPIKHPFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	internal int NNKFBHGOPKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	internal TDeps APHBGODKBHN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x42A0630", Offset = "0x429F830", VA = "0x1842A0630")]
	internal DCLGJIDDEOG(TPartialAction[] PDMBHODMLAM, int LALNKKGNJPK, TDeps FLJLOPPINOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x42A05D0", Offset = "0x429F7D0", VA = "0x1842A05D0")]
	public static DCLGJIDDEOG<TPartialAction, TFullAction, TDeps> NMBJFIHLDEO(TDeps FLJLOPPINOK)
	{
		return default(DCLGJIDDEOG<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NHEEHKJMOEF
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface GDHOHAKEKAA<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OMKOJGHFMJD(in TPartialAction ICHFDKGELCA);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction FFICAEBOKFJ(TPartialAction[] FEBDJOKIEBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2FE6EF0", Offset = "0x2FE60F0", VA = "0x182FE6EF0")]
	public static NFEJPMDMHAA<TFullAction> JONHIJHGPOE<TFullAction, TPartialAction, TDeps>(this ref DCLGJIDDEOG<TPartialAction, TFullAction, TDeps> DCMHODHEGEC, TPartialAction ICHFDKGELCA) where TDeps : GDHOHAKEKAA<TPartialAction, TFullAction>
	{
		return default(NFEJPMDMHAA<TFullAction>);
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
