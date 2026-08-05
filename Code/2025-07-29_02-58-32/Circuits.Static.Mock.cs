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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A99110", Offset = "0x2A97B10", VA = "0x182A99110")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class FKGKHFLDDAA<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, BLKICEHGHMP.HOHAJICCDFD<TAction, TNetSys> where TReceiverDeps : notnull, BLKICEHGHMP.DLEIKPFMALC<TAction, TReceiver> where TRootDeps : notnull, BLKICEHGHMP.OGFGGOIIDIO<TAction, TRoot> where TRoot : notnull where TDeps : notnull, BLKICEHGHMP.ILGMGEFLLCJ<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class CEICDMEIIFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? LMAAFLEBFIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<Func<Task>> JGAPKKBIBMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool PKPEAKBCEJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> INEGJCNMKEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool HFEIDGGOPOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? CFANCEIONHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly FAPKMFIJAPJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> GAEINIECFOF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool GOGGJBIABEP
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x696B390", Offset = "0x6969D90", VA = "0x18696B390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x696B830", Offset = "0x696A230", VA = "0x18696B830")]
		public CEICDMEIIFJ(int? LBMGMHLGBFL, List<Func<Task>> JDNHIMBLGHK, bool HFHNHKBOPLP, List<Func<Task>> DMMGKHKOCKI, bool BKBBMDIIELB, TAction[]? CCJNIAFMOAG, FAPKMFIJAPJ<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> HFPPKNBINHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x696B630", Offset = "0x696A030", VA = "0x18696B630")]
		public static FKGKHFLDDAA<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.CEICDMEIIFJ MDDJOGPLAFO(TDeps MADJNKEDNDC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class JKCNKKJMOJM
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
			public JKCNKKJMOJM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<DOHEMIFBILP<object?, EFLLFLJPHFD>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<DOHEMIFBILP<object, EFLLFLJPHFD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x446B780", Offset = "0x446A180", VA = "0x18446B780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x446BF20", Offset = "0x446A920", VA = "0x18446BF20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CEICDMEIIFJ client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public COBPPOBACAG<CPIJMOKFOJA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<DOHEMIFBILP<object?, EFLLFLJPHFD>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public JKCNKKJMOJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x53E0690", Offset = "0x53DF090", VA = "0x1853E0690")]
		[AsyncStateMachine(typeof(FKGKHFLDDAA<, , , , , , , >.JKCNKKJMOJM.<<SendActionToAll>b__0>d))]
		internal Task LHDGEAJPFGA()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class PLOPHKMLAFL
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
			public PLOPHKMLAFL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskCompletionSource<DOHEMIFBILP<object, EFLLFLJPHFD>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<DOHEMIFBILP<object, EFLLFLJPHFD>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4469F90", Offset = "0x4468990", VA = "0x184469F90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x446A330", Offset = "0x4468D30", VA = "0x18446A330", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CEICDMEIIFJ client;

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
		public COBPPOBACAG<CPIJMOKFOJA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TaskCompletionSource<DOHEMIFBILP<object, EFLLFLJPHFD>> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public PLOPHKMLAFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5B52340", Offset = "0x5B50D40", VA = "0x185B52340")]
		[AsyncStateMachine(typeof(FKGKHFLDDAA<, , , , , , , >.PLOPHKMLAFL.<<ReceiveAction>b__0>d))]
		internal Task MPDJJBGKDFI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HCBAHOABANP<CPIJMOKFOJA, CEICDMEIIFJ> ILHAKFLOKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<HDBDAGKHDAK<TAction>> DDJOMBCIBEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int EEPEICIHFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int JJNMFFBJIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int CILGBFDOJIG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4E1F570", Offset = "0x4E1DF70", VA = "0x184E1F570")]
	public FKGKHFLDDAA(int KMMPAPLMNPJ, int NLNDDCMJFKA, int OMHFCBMBDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EDA0", Offset = "0x4E1D7A0", VA = "0x184E1EDA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4E1F4D0", Offset = "0x4E1DED0", VA = "0x184E1F4D0")]
	public void JACJEALIOFB(COBPPOBACAG<CPIJMOKFOJA> CDBGILBOAEE, TDeps MADJNKEDNDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4E1F550", Offset = "0x4E1DF50", VA = "0x184E1F550")]
	public void JDCMLNALEOM(COBPPOBACAG<CPIJMOKFOJA> CDBGILBOAEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4E1ED70", Offset = "0x4E1D770", VA = "0x184E1ED70")]
	public void BGHDBDMIDFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E6D0", Offset = "0x4E1D0D0", VA = "0x184E1E6D0")]
	public Task<DOHEMIFBILP<object, EFLLFLJPHFD>> AKEKHHBABGE(TRoot PJFDNMGHMBL, [In] LGABLCKNDKK<CPIJMOKFOJA> FCPODIHKBFK, [In] HCBAHOABANP<CPIJMOKFOJA, TNetSys> FCMAHMJNGCK, [In] HCBAHOABANP<CPIJMOKFOJA, TReceiver> HIEFONPAKAH, COBPPOBACAG<CPIJMOKFOJA> JKFIKKHIHEB, TAction FOAIPBIEILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4E1E450", Offset = "0x4E1CE50", VA = "0x184E1E450")]
	public Task<DOHEMIFBILP<object, EFLLFLJPHFD>> AKEKHHBABGE(TRoot PJFDNMGHMBL, TNetSys AANOAFILNFN, COBPPOBACAG<CPIJMOKFOJA> JKFIKKHIHEB, TAction FOAIPBIEILM, bool LCFHKMEANIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4E1EDC0", Offset = "0x4E1D7C0", VA = "0x184E1EDC0")]
	public Task<DOHEMIFBILP<object, EFLLFLJPHFD>> HFNPJLHDEKG(TRoot PJFDNMGHMBL, TNetSys MEGGODCCMAI, TReceiver JCPGGABKCEJ, COBPPOBACAG<CPIJMOKFOJA> KBMJDNCPCKI, COBPPOBACAG<CPIJMOKFOJA> JKFIKKHIHEB, TAction FOAIPBIEILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4E1DCE0", Offset = "0x4E1C6E0", VA = "0x184E1DCE0")]
	public Task AFCOJGJHOCH(TRoot PJFDNMGHMBL, TNetSys MEGGODCCMAI, TReceiver JCPGGABKCEJ, COBPPOBACAG<CPIJMOKFOJA> KBMJDNCPCKI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal readonly struct HDBDAGKHDAK<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly COBPPOBACAG<CPIJMOKFOJA> ODBGIMGIGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction HCPODONJHPC;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1900540", Offset = "0x18FEF40", VA = "0x181900540")]
	public HDBDAGKHDAK(COBPPOBACAG<CPIJMOKFOJA> FCNHLPKGBDC, TAction FOAIPBIEILM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class HNMOKHMGAAK
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C937E0", Offset = "0x3C921E0", VA = "0x183C937E0")]
	public static HDBDAGKHDAK<TAction> MDDJOGPLAFO<TAction>(COBPPOBACAG<CPIJMOKFOJA> FCNHLPKGBDC, TAction FOAIPBIEILM) where TAction : notnull
	{
		return default(HDBDAGKHDAK<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class NENFPBHJLPL<TRoot, TDeps> : KHOENIFOJDF where TRoot : notnull where TDeps : notnull, KGJEFPMHKLI.KDMFAMNNDAI<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KNFFIMKAOFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<DOHEMIFBILP<object?, EFLLFLJPHFD>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public NENFPBHJLPL<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public KEMGOOKCBDH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<DOHEMIFBILP<object?, EFLLFLJPHFD>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x55035B0", Offset = "0x5501FB0", VA = "0x1855035B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5503BB0", Offset = "0x55025B0", VA = "0x185503BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps CHPBOPOCLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot MIIJBCOMCPN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public COBPPOBACAG<CPIJMOKFOJA> LMGBIBCCALJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAE0120", Offset = "0xADEB20", VA = "0x180AE0120")]
		[CompilerGenerated]
		get
		{
			return default(COBPPOBACAG<CPIJMOKFOJA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2FCED20", Offset = "0x2FCD720", VA = "0x182FCED20")]
	public NENFPBHJLPL(TDeps MADJNKEDNDC, TRoot PJFDNMGHMBL, COBPPOBACAG<CPIJMOKFOJA> KCPJDDKPHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x58AFB20", Offset = "0x58AE520", VA = "0x1858AFB20", Slot = "4")]
	[AsyncStateMachine(typeof(NENFPBHJLPL<, >.KNFFIMKAOFD))]
	public Task<DOHEMIFBILP<object, EFLLFLJPHFD>> AKEKHHBABGE(KEMGOOKCBDH FOAIPBIEILM, bool LCFHKMEANIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KGJEFPMHKLI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface KDMFAMNNDAI<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DOHEMIFBILP<object, EFLLFLJPHFD>> AKEKHHBABGE(TRoot PJFDNMGHMBL, COBPPOBACAG<CPIJMOKFOJA> JKFIKKHIHEB, KEMGOOKCBDH FOAIPBIEILM, bool LCFHKMEANIB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GGLDDGNEMFL : FOLICNJBFGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void MGHDGEADLFP();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly GGLDDGNEMFL NDAIDGNOFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly MGHDGEADLFP? JIHIBFBGOOO;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA93860", Offset = "0xA92260", VA = "0x180A93860")]
	public GGLDDGNEMFL([Optional] MGHDGEADLFP? HGEMHBFKNCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x12E6990", Offset = "0x12E5390", VA = "0x1812E6990", Slot = "4")]
	public void MFCFGAILLEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class LPPFNLCAKBI : NMLLGAFDPCE
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void IEPLFIFJHDN(COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<IIGNEBOMHLM> MJAGJGKKLFE, COBPPOBACAG<BHNPPOPBMAI> INCKNNPDILH);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void NOPFNEBFLHF(COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<IIGNEBOMHLM> MJAGJGKKLFE, COBPPOBACAG<BHNPPOPBMAI> INCKNNPDILH);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void POIMOCLCOJO(COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<CFJBLOCLLGM> KALNIGICCJC);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly LPPFNLCAKBI NDAIDGNOFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IEPLFIFJHDN? KEPEPOBILHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NOPFNEBFLHF? NBIGLPKFJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly POIMOCLCOJO? ADGGNNPOCNO;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xDB36D0", Offset = "0xDB20D0", VA = "0x180DB36D0")]
	public LPPFNLCAKBI([Optional] IEPLFIFJHDN? DEDBMHAEDME, [Optional] NOPFNEBFLHF? LGODAJJEGEG, [Optional] POIMOCLCOJO? BOFKFEIFFFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2A99020", Offset = "0x2A97A20", VA = "0x182A99020", Slot = "4")]
	public void OnEdgeDidAdd(COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<IIGNEBOMHLM> MJAGJGKKLFE, COBPPOBACAG<BHNPPOPBMAI> INCKNNPDILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2A99040", Offset = "0x2A97A40", VA = "0x182A99040", Slot = "5")]
	public void OnEdgeWillRemove(COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<IIGNEBOMHLM> MJAGJGKKLFE, COBPPOBACAG<BHNPPOPBMAI> INCKNNPDILH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A99000", Offset = "0x2A97A00", VA = "0x182A99000", Slot = "6")]
	public void MGMKFMFFEBH(COBPPOBACAG<JNIKNMAMHFM> IOCOOEFIBIE, COBPPOBACAG<CFJBLOCLLGM> KALNIGICCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA85A40", Offset = "0xA84440", VA = "0x180A85A40", Slot = "11")]
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
