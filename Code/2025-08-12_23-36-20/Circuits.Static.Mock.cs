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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B03FA0", Offset = "0x2B02DA0", VA = "0x182B03FA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class EALONLBIKCM<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, JKMPAGDAEHD.DACBMIEMALJ<TAction, TNetSys> where TReceiverDeps : notnull, JKMPAGDAEHD.PLNAJAJLLNB<TAction, TReceiver> where TRootDeps : notnull, JKMPAGDAEHD.PBAJJOLFMDE<TAction, TRoot> where TRoot : notnull where TDeps : notnull, JKMPAGDAEHD.FBFHCMOGFBE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class ELFIOOHCNHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? EBPCNDDADPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<Func<Task>> EPJJCDNPGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool LNKPPDBMJCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> HGDLHMPFAOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool MMELNECBIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? IOLDDMCKONM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly NMLFOCEABCJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> MKGFODGNJCA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool NCCJCALBMAC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x4A66C10", Offset = "0x4A65A10", VA = "0x184A66C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4A66C60", Offset = "0x4A65A60", VA = "0x184A66C60")]
		public ELFIOOHCNHE(int? DPOOOBGBLIP, List<Func<Task>> GNFIKMLOBJE, bool NFNDKNHDEAP, List<Func<Task>> AGHDOFLOCDI, bool EBHEFDEJMEB, TAction[]? MAHEMHKDBMF, NMLFOCEABCJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> DNLJJEJADGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4A669C0", Offset = "0x4A657C0", VA = "0x184A669C0")]
		public static EALONLBIKCM<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.ELFIOOHCNHE ELDPFIHNJDG(TDeps OPJFEEDOIEH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BGIKMMADPIC
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
			public BGIKMMADPIC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<GECIHKBMECG<object?, HFPJGMECLBA>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<GECIHKBMECG<object, HFPJGMECLBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x44F9070", Offset = "0x44F7E70", VA = "0x1844F9070", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x44F97B0", Offset = "0x44F85B0", VA = "0x1844F97B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public ELFIOOHCNHE client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public PFJMKELOBBL<DLKFGHJHLMA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<GECIHKBMECG<object?, HFPJGMECLBA>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public BGIKMMADPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x66E8F30", Offset = "0x66E7D30", VA = "0x1866E8F30")]
		[AsyncStateMachine(typeof(EALONLBIKCM<, , , , , , , >.BGIKMMADPIC.<<SendActionToAll>b__0>d))]
		internal Task DECHHKBOCGD()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class CIDALOIFMIO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private struct <<ReceiveAction>b__0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public CIDALOIFMIO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskCompletionSource<GECIHKBMECG<object, HFPJGMECLBA>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<GECIHKBMECG<object, HFPJGMECLBA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x44F7890", Offset = "0x44F6690", VA = "0x1844F7890", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x44F7C30", Offset = "0x44F6A30", VA = "0x1844F7C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public ELFIOOHCNHE client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public PFJMKELOBBL<DLKFGHJHLMA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TaskCompletionSource<GECIHKBMECG<object, HFPJGMECLBA>> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public CIDALOIFMIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C6BE90", Offset = "0x6C6AC90", VA = "0x186C6BE90")]
		[AsyncStateMachine(typeof(EALONLBIKCM<, , , , , , , >.CIDALOIFMIO.<<ReceiveAction>b__0>d))]
		internal Task OHLFLOMHDMA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private DMCDLOLKCAK<DLKFGHJHLMA, ELFIOOHCNHE> NHECOMDPIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<HNENJMODBAH<TAction>> GOGJDKKNLIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int FBEDIIFFHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int CPOIMDHGGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int JDCAPDPPAPL;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4A38030", Offset = "0x4A36E30", VA = "0x184A38030")]
	public EALONLBIKCM(int MLLBENKIOJK, int BDAKKEFMOLK, int AHJNPKCGLDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4A37350", Offset = "0x4A36150", VA = "0x184A37350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4A37A20", Offset = "0x4A36820", VA = "0x184A37A20")]
	public void IEBBAPMBBGN(PFJMKELOBBL<DLKFGHJHLMA> KDPNMEKECKM, TDeps OPJFEEDOIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4A37A00", Offset = "0x4A36800", VA = "0x184A37A00")]
	public void GFMOMOICLPD(PFJMKELOBBL<DLKFGHJHLMA> KDPNMEKECKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4A37B20", Offset = "0x4A36920", VA = "0x184A37B20")]
	public void JGOLLBMELEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4A37000", Offset = "0x4A35E00", VA = "0x184A37000")]
	public Task<GECIHKBMECG<object, HFPJGMECLBA>> CJGPEGMNMCN(TRoot MMENCBNBOBJ, [In] MJLAEMKGHHA<DLKFGHJHLMA> CKOIHIEIOOB, [In] DMCDLOLKCAK<DLKFGHJHLMA, TNetSys> EHDNLLNJNHP, [In] DMCDLOLKCAK<DLKFGHJHLMA, TReceiver> FFDHFKNIKMB, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction IJBAPONMLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4A367A0", Offset = "0x4A355A0", VA = "0x184A367A0")]
	public Task<GECIHKBMECG<object, HFPJGMECLBA>> CJGPEGMNMCN(TRoot MMENCBNBOBJ, TNetSys JFKPMDJNDHF, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction IJBAPONMLAP, bool AJACKFAPAJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4A37370", Offset = "0x4A36170", VA = "0x184A37370")]
	public Task<GECIHKBMECG<object, HFPJGMECLBA>> FMPDGCGNEKC(TRoot MMENCBNBOBJ, TNetSys DFGPEOEPHCH, TReceiver BIJLHPHALFD, PFJMKELOBBL<DLKFGHJHLMA> AGBBDOJPKKO, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, TAction IJBAPONMLAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4A37DC0", Offset = "0x4A36BC0", VA = "0x184A37DC0")]
	public Task OECIFMGNJBA(TRoot MMENCBNBOBJ, TNetSys DFGPEOEPHCH, TReceiver BIJLHPHALFD, PFJMKELOBBL<DLKFGHJHLMA> AGBBDOJPKKO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal readonly struct HNENJMODBAH<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly PFJMKELOBBL<DLKFGHJHLMA> BBBGDMJCAPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction HJJNBKKLEBI;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1942DD0", Offset = "0x1941BD0", VA = "0x181942DD0")]
	public HNENJMODBAH(PFJMKELOBBL<DLKFGHJHLMA> DGMBCDDJKOF, TAction IJBAPONMLAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class MOBAOINOPEL
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3DBACA0", Offset = "0x3DB9AA0", VA = "0x183DBACA0")]
	public static HNENJMODBAH<TAction> ELDPFIHNJDG<TAction>(PFJMKELOBBL<DLKFGHJHLMA> DGMBCDDJKOF, TAction IJBAPONMLAP) where TAction : notnull
	{
		return default(HNENJMODBAH<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class GNJJPKEHOJH<TRoot, TDeps> : IJKDLEDIKPB where TRoot : notnull where TDeps : notnull, GDNHODPOHGI.DAPJCGKIIHC<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct OKJHDJCJEKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<GECIHKBMECG<object?, HFPJGMECLBA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public GNJJPKEHOJH<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public KOJJPDBHKHG action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<GECIHKBMECG<object?, HFPJGMECLBA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6920", Offset = "0x5AD5720", VA = "0x185AD6920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5AD6F90", Offset = "0x5AD5D90", VA = "0x185AD6F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps BFCDJMDIFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot KFPLBHFPLLI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public PFJMKELOBBL<DLKFGHJHLMA> HLKHBCPBIAF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAE69D0", Offset = "0xAE57D0", VA = "0x180AE69D0")]
		[CompilerGenerated]
		get
		{
			return default(PFJMKELOBBL<DLKFGHJHLMA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3045E60", Offset = "0x3044C60", VA = "0x183045E60")]
	public GNJJPKEHOJH(TDeps OPJFEEDOIEH, TRoot MMENCBNBOBJ, PFJMKELOBBL<DLKFGHJHLMA> KFNIJGLJECO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x500DFE0", Offset = "0x500CDE0", VA = "0x18500DFE0", Slot = "4")]
	[AsyncStateMachine(typeof(GNJJPKEHOJH<, >.OKJHDJCJEKO))]
	public Task<GECIHKBMECG<object, HFPJGMECLBA>> CJGPEGMNMCN(KOJJPDBHKHG IJBAPONMLAP, bool AJACKFAPAJP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GDNHODPOHGI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface DAPJCGKIIHC<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<GECIHKBMECG<object, HFPJGMECLBA>> CJGPEGMNMCN(TRoot MMENCBNBOBJ, PFJMKELOBBL<DLKFGHJHLMA> LBDMJCCNJOD, KOJJPDBHKHG IJBAPONMLAP, bool AJACKFAPAJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class OHCNOJOCDDG : IDDNIDNFLGN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void PFDGBNJHJNL(PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<ONHJNBAOPLN> HHKENNCHPLI, PFJMKELOBBL<JNPLKINCBGM> INEOMKFDMNC);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void ADFLDJODIAK(PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<ONHJNBAOPLN> HHKENNCHPLI, PFJMKELOBBL<JNPLKINCBGM> INEOMKFDMNC);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void FCKDGCDGAJE(PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<OAPHEJLBOJB> NKENCNIEFON);

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly OHCNOJOCDDG MOIOIMEFPHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly PFDGBNJHJNL? LCJFJMLGGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly ADFLDJODIAK? EJDJJCFGECP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FCKDGCDGAJE? PDAGHPIPDPE;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xDE3F00", Offset = "0xDE2D00", VA = "0x180DE3F00")]
	public OHCNOJOCDDG([Optional] PFDGBNJHJNL? BAMKOGHECKF, [Optional] ADFLDJODIAK? MCPIKOCBDPP, [Optional] FCKDGCDGAJE? NDOABMANEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B04040", Offset = "0x2B02E40", VA = "0x182B04040", Slot = "4")]
	public void OnEdgeDidAdd(PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<ONHJNBAOPLN> HHKENNCHPLI, PFJMKELOBBL<JNPLKINCBGM> INEOMKFDMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B04060", Offset = "0x2B02E60", VA = "0x182B04060", Slot = "5")]
	public void OnEdgeWillRemove(PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<ONHJNBAOPLN> HHKENNCHPLI, PFJMKELOBBL<JNPLKINCBGM> INEOMKFDMNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B04020", Offset = "0x2B02E20", VA = "0x182B04020", Slot = "6")]
	public void KCGJALGIBPF(PFJMKELOBBL<FGBJJIEAJJD> CPLLEEFPGDP, PFJMKELOBBL<OAPHEJLBOJB> NKENCNIEFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "10")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "11")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "12")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "13")]
	public void OnEditGraphDidPop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "8")]
	public void JPPCBCLIMGB(PFJMKELOBBL<NMIOEHIEHIK> HKDCNPAMGKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "9")]
	public void CACINJPINMF(PFJMKELOBBL<NMIOEHIEHIK> HKDCNPAMGKJ)
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
