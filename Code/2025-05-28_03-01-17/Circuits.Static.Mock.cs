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
		[Cpp2IlInjected.Address(RVA = "0xA336C0", Offset = "0xA324C0", VA = "0x180A336C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2858170", Offset = "0x2856F70", VA = "0x182858170")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA34390", Offset = "0xA33190", VA = "0x180A34390")]
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
		[Cpp2IlInjected.Address(RVA = "0xA343D0", Offset = "0xA331D0", VA = "0x180A343D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class HHMFGDOPAGH<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, PPAIEIINDHH.BBMLNAGAEIP<TAction, TNetSys> where TReceiverDeps : notnull, PPAIEIINDHH.KKMHHFMHCJB<TAction, TReceiver> where TRootDeps : notnull, PPAIEIINDHH.JPHGIHLIEKF<BEPCLDNEIBO, TAction, TRoot> where TRoot : notnull where TDeps : notnull, PPAIEIINDHH.JMNOCPOJNGK<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class PKANHFFINKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? KIKICBHEDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<AMCECIHOGOD<TAction>> MDAOBNGMNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool IOJFOMGONOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> ABJIFINHJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool HGBBEDHMFEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? EKDKCIFOMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly KIFCBJDDJKP<BEPCLDNEIBO, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> DLGCBODAHMD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool JENALPJJDKF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5784420", Offset = "0x5783220", VA = "0x185784420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x57849C0", Offset = "0x57837C0", VA = "0x1857849C0")]
		public PKANHFFINKN(int? FAABGGFJEPF, List<AMCECIHOGOD<TAction>> EMNPFPBEBEH, bool EMBIHFFIGMA, List<Func<Task>> FLAHFMKFAJA, bool NOHOGPKNBMH, TAction[]? IAGCMGFGDOG, KIFCBJDDJKP<BEPCLDNEIBO, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> GOMEADMMGKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5784740", Offset = "0x5783540", VA = "0x185784740")]
		public static HHMFGDOPAGH<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.PKANHFFINKN NBEICDCLFEE(TDeps JCFBNAHPHAO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BKDMIPGHPJA
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
			public BKDMIPGHPJA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4198660", Offset = "0x4197460", VA = "0x184198660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4198A70", Offset = "0x4197870", VA = "0x184198A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public PKANHFFINKN client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public BIHBDMOHDCK<FMJOCPEIHPL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public BKDMIPGHPJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6092750", Offset = "0x6091550", VA = "0x186092750")]
		[AsyncStateMachine(typeof(HHMFGDOPAGH<, , , , , , , >.BKDMIPGHPJA.<<SendActionToAll>b__0>d))]
		internal Task GMDPOHOIKIO()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NNDPJKACONF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public HHMFGDOPAGH<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public BIHBDMOHDCK<FMJOCPEIHPL> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public BIHBDMOHDCK<FMJOCPEIHPL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public BIHBDMOHDCK<BEPCLDNEIBO> requestId;

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
		private TaskAwaiter<JKEBLLKKBOM<object, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5500FE0", Offset = "0x54FFDE0", VA = "0x185500FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5501990", Offset = "0x5500790", VA = "0x185501990", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private PKGDJDPCMOK<FMJOCPEIHPL, PKANHFFINKN> AELIPHPHKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<AMCECIHOGOD<TAction>> HHCKLOHNHCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int CJDELOHBOKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int CIGIGFPOLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int DCPOPGJGNKO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4C2DF10", Offset = "0x4C2CD10", VA = "0x184C2DF10")]
	public HHMFGDOPAGH(int INAJLBMHABM, int LILJFCLKDHC, int DOJDHADMKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CC20", Offset = "0x4C2BA20", VA = "0x184C2CC20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CFB0", Offset = "0x4C2BDB0", VA = "0x184C2CFB0")]
	public void KKOHIOADNDL(BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH, TDeps JCFBNAHPHAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CF10", Offset = "0x4C2BD10", VA = "0x184C2CF10")]
	public void KGOFBPFMHOM(BIHBDMOHDCK<FMJOCPEIHPL> EMKNGKOPAPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C2DEC0", Offset = "0x4C2CCC0", VA = "0x184C2DEC0")]
	public void MEBHIEALMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2DA20", Offset = "0x4C2C820", VA = "0x184C2DA20")]
	public (Task, Task[]) KNHLBDALFEK(TRoot IPCOMOHMNHK, [In] GFAEBDOOJCH<FMJOCPEIHPL> EMMMFPJLKFF, [In] PKGDJDPCMOK<FMJOCPEIHPL, TNetSys> JDBMALONGAG, [In] PKGDJDPCMOK<FMJOCPEIHPL, TReceiver> GOCHICPMFCH, BIHBDMOHDCK<FMJOCPEIHPL> ONEIDEFNEFO, BIHBDMOHDCK<BEPCLDNEIBO> AEHODJLJACF, TAction CFDGGKIIHOI)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D030", Offset = "0x4C2BE30", VA = "0x184C2D030")]
	public Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> KNHLBDALFEK(TRoot IPCOMOHMNHK, TNetSys HLDOEFCHGDK, BIHBDMOHDCK<FMJOCPEIHPL> ONEIDEFNEFO, TAction CFDGGKIIHOI, bool DPAGNCPIBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CDC0", Offset = "0x4C2BBC0", VA = "0x184C2CDC0")]
	[AsyncStateMachine(typeof(HHMFGDOPAGH<, , , , , , , >.NNDPJKACONF))]
	public Task GIECFKBDPJB(TRoot IPCOMOHMNHK, TNetSys EFJNGGEJMAB, TReceiver HAAEOKEMPKE, BIHBDMOHDCK<FMJOCPEIHPL> FLPPCGHIDNG, BIHBDMOHDCK<FMJOCPEIHPL> ONEIDEFNEFO, BIHBDMOHDCK<BEPCLDNEIBO> AEHODJLJACF, TAction CFDGGKIIHOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C990", Offset = "0x4C2B790", VA = "0x184C2C990")]
	public Task CALPPFHKOHP(TRoot IPCOMOHMNHK, TNetSys EFJNGGEJMAB, TReceiver HAAEOKEMPKE, BIHBDMOHDCK<FMJOCPEIHPL> FLPPCGHIDNG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct AMCECIHOGOD<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly BIHBDMOHDCK<FMJOCPEIHPL> AIDNDLKBIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly BIHBDMOHDCK<BEPCLDNEIBO> LFEONLIOGDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction NHFNAEIGEKK;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xC3BD10", Offset = "0xC3AB10", VA = "0x180C3BD10")]
	public AMCECIHOGOD(BIHBDMOHDCK<FMJOCPEIHPL> FAPLIEIFOHC, BIHBDMOHDCK<BEPCLDNEIBO> AEHODJLJACF, TAction CFDGGKIIHOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class KLAFPEMELCG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x39D8F40", Offset = "0x39D7D40", VA = "0x1839D8F40")]
	public static AMCECIHOGOD<TAction> NBEICDCLFEE<TAction>(BIHBDMOHDCK<FMJOCPEIHPL> FAPLIEIFOHC, BIHBDMOHDCK<BEPCLDNEIBO> AEHODJLJACF, TAction CFDGGKIIHOI) where TAction : notnull
	{
		return default(AMCECIHOGOD<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class LCLGPAIHKMN<TRoot, TDeps> : OEINHBKKCEG where TRoot : notnull where TDeps : notnull, JKIMPDANFCO.IMGACFDGOJE<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct HBHFBDOKAOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public LCLGPAIHKMN<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public CMGFJHDBEGO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<JKEBLLKKBOM<object?, CHEIGOJMDOJ>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4C15B20", Offset = "0x4C14920", VA = "0x184C15B20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x4C15ED0", Offset = "0x4C14CD0", VA = "0x184C15ED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps JLPOGPHFPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot PNPPCEOCLJN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public BIHBDMOHDCK<FMJOCPEIHPL> IHHOBAGEDII
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC17D00", Offset = "0xC16B00", VA = "0x180C17D00")]
		[CompilerGenerated]
		get
		{
			return default(BIHBDMOHDCK<FMJOCPEIHPL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2D13A90", Offset = "0x2D12890", VA = "0x182D13A90")]
	public LCLGPAIHKMN(TDeps JCFBNAHPHAO, TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> AMOPEOJDIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5155560", Offset = "0x5154360", VA = "0x185155560", Slot = "4")]
	[AsyncStateMachine(typeof(LCLGPAIHKMN<, >.HBHFBDOKAOK))]
	public Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> KNHLBDALFEK(CMGFJHDBEGO CFDGGKIIHOI, bool DPAGNCPIBHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class JKIMPDANFCO
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface IMGACFDGOJE<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<JKEBLLKKBOM<object, CHEIGOJMDOJ>> KNHLBDALFEK(TRoot IPCOMOHMNHK, BIHBDMOHDCK<FMJOCPEIHPL> ONEIDEFNEFO, CMGFJHDBEGO CFDGGKIIHOI, bool DPAGNCPIBHD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class MOBCDMLFELL : BEENFEHKPGK
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void FONAOCKNOPD();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly MOBCDMLFELL ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly FONAOCKNOPD? PCGEFAHFNEL;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA0CF10", Offset = "0xA0BD10", VA = "0x180A0CF10")]
	public MOBCDMLFELL([Optional] FONAOCKNOPD? CBEBFMFNHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1183490", Offset = "0x1182290", VA = "0x181183490", Slot = "4")]
	public void HDOAKBHIPOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class OKHCMBFONFH : JDLEDCNCBNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void MKGNHMMGKGH(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> IMLPHIHCCPJ, BIHBDMOHDCK<KAJIMMHBMBI> AGDBGFMOJFI);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void CKPAGCGHKJL(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> IMLPHIHCCPJ, BIHBDMOHDCK<KAJIMMHBMBI> AGDBGFMOJFI);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void KGCFJFJAEIH(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly OKHCMBFONFH ICOFMPPJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly MKGNHMMGKGH? FNDCJKFGBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CKPAGCGHKJL? NKKKAMHOANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly KGCFJFJAEIH? LDKNMKEPEAH;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xC59BA0", Offset = "0xC589A0", VA = "0x180C59BA0")]
	public OKHCMBFONFH([Optional] MKGNHMMGKGH? OPBLDPFCHAO, [Optional] CKPAGCGHKJL? DLDKEBHDIFA, [Optional] KGCFJFJAEIH? OHBAHGHGBDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2858210", Offset = "0x2857010", VA = "0x182858210", Slot = "4")]
	public void OnEdgeDidAdd(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> IMLPHIHCCPJ, BIHBDMOHDCK<KAJIMMHBMBI> AGDBGFMOJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2858230", Offset = "0x2857030", VA = "0x182858230", Slot = "5")]
	public void OnEdgeWillRemove(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<IEDJJDGMFHP> IMLPHIHCCPJ, BIHBDMOHDCK<KAJIMMHBMBI> AGDBGFMOJFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x28581F0", Offset = "0x2856FF0", VA = "0x1828581F0", Slot = "6")]
	public void JODIKIEGFNO(BIHBDMOHDCK<HJIDLNADIFB> AEHJOFBOANC, BIHBDMOHDCK<KCAEAGPDLDO> HLGNHFCFAMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "11")]
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
