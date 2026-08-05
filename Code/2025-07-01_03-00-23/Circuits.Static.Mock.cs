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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x29B8920", Offset = "0x29B6F20", VA = "0x1829B8920")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class CNLOLDMPOJP<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, PCGFNEGKEFB.JAJODCHBJBN<TAction, TNetSys> where TReceiverDeps : notnull, PCGFNEGKEFB.KMMAFKCJLGL<TAction, TReceiver> where TRootDeps : notnull, PCGFNEGKEFB.ACGBOGBHMEL<BPPAIFNMLAH, TAction, TRoot> where TRoot : notnull where TDeps : notnull, PCGFNEGKEFB.HOAKNGLMODD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class MIMIABJBKFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? HJCLCIPDFHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<GINLCPGFHEO<TAction>> IKODAJPCCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool CAFCFFOGEJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> LJJBABABBGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool BLAJMKHFGJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? GKAJAIDGEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly COPKANDOGDI<BPPAIFNMLAH, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> CGEMANCAPAL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool MIOANBJJAAG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5610380", Offset = "0x560E980", VA = "0x185610380")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5610420", Offset = "0x560EA20", VA = "0x185610420")]
		public MIMIABJBKFM(int? JALEMMECFHA, List<GINLCPGFHEO<TAction>> GKIHDFOFFNM, bool GMIINMMIJFG, List<Func<Task>> BCINMLLBIMM, bool OMCOKKHFFJF, TAction[]? PHDMOAMNPJJ, COPKANDOGDI<BPPAIFNMLAH, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> GIKFALPGKOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5610110", Offset = "0x560E710", VA = "0x185610110")]
		public static CNLOLDMPOJP<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.MIMIABJBKFM BFOPDLPDKBM(TDeps GMIGKAKBDIM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class KODJKJHGIHK
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
			public KODJKJHGIHK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<FANMKCKHALG<object?, GNLHMHNEEGO>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<FANMKCKHALG<object, GNLHMHNEEGO>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4307EC0", Offset = "0x43064C0", VA = "0x184307EC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4308600", Offset = "0x4306C00", VA = "0x184308600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public MIMIABJBKFM client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public LLDGDOINCKI<JLBFOIDJJFC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<FANMKCKHALG<object?, GNLHMHNEEGO>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public KODJKJHGIHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x52E6110", Offset = "0x52E4710", VA = "0x1852E6110")]
		[AsyncStateMachine(typeof(CNLOLDMPOJP<, , , , , , , >.KODJKJHGIHK.<<SendActionToAll>b__0>d))]
		internal Task HJFCLLMGAGE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct MGIGPNIIGNO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CNLOLDMPOJP<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public LLDGDOINCKI<JLBFOIDJJFC> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public LLDGDOINCKI<JLBFOIDJJFC> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LLDGDOINCKI<BPPAIFNMLAH> requestId;

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
		private TaskAwaiter<FANMKCKHALG<object, GNLHMHNEEGO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x56083A0", Offset = "0x56069A0", VA = "0x1856083A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5608890", Offset = "0x5606E90", VA = "0x185608890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NKNEHBBBKOO<JLBFOIDJJFC, MIMIABJBKFM> EBCHIOJJPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<GINLCPGFHEO<TAction>> HFBEIHCMMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int PDBGCKNCIDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int LHHNAGOPIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int DGPBDAOAIBP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x687E740", Offset = "0x687CD40", VA = "0x18687E740")]
	public CNLOLDMPOJP(int ANFDEEOELNH, int KDEGJMLGMBP, int DJEJNLNPJII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x687E440", Offset = "0x687CA40", VA = "0x18687E440", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x687DE40", Offset = "0x687C440", VA = "0x18687DE40")]
	public void BFNOHFPDHGH(LLDGDOINCKI<JLBFOIDJJFC> AIEJLCEJPCJ, TDeps GMIGKAKBDIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x687DF40", Offset = "0x687C540", VA = "0x18687DF40")]
	public void BHGINAHKPFD(LLDGDOINCKI<JLBFOIDJJFC> AIEJLCEJPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x687E460", Offset = "0x687CA60", VA = "0x18687E460")]
	public void PGDOJCLFIJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x687D050", Offset = "0x687B650", VA = "0x18687D050")]
	public (Task, Task[]) ANGIGKOKHEN(TRoot CMAFOEIBEKN, [In] IEHGEBAEJIK<JLBFOIDJJFC> GIDJFDLCBCM, [In] NKNEHBBBKOO<JLBFOIDJJFC, TNetSys> JJJAIHIGHJJ, [In] NKNEHBBBKOO<JLBFOIDJJFC, TReceiver> DNGJMIINIKM, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, LLDGDOINCKI<BPPAIFNMLAH> FILKDPOEDAI, TAction CJDOILFHDJI)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x687DBC0", Offset = "0x687C1C0", VA = "0x18687DBC0")]
	public Task<FANMKCKHALG<object, GNLHMHNEEGO>> ANGIGKOKHEN(TRoot CMAFOEIBEKN, TNetSys NDLIFLFKGJD, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, TAction CJDOILFHDJI, bool PAIBICJIBKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x687E490", Offset = "0x687CA90", VA = "0x18687E490")]
	[AsyncStateMachine(typeof(CNLOLDMPOJP<, , , , , , , >.MGIGPNIIGNO))]
	public Task PLDMMMLFINN(TRoot CMAFOEIBEKN, TNetSys KMILKALDJJF, TReceiver GOFEAPECJPJ, LLDGDOINCKI<JLBFOIDJJFC> BBFFGKDJGGC, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, LLDGDOINCKI<BPPAIFNMLAH> FILKDPOEDAI, TAction CJDOILFHDJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x687DF60", Offset = "0x687C560", VA = "0x18687DF60")]
	public Task CPKLHLBEJCN(TRoot CMAFOEIBEKN, TNetSys KMILKALDJJF, TReceiver GOFEAPECJPJ, LLDGDOINCKI<JLBFOIDJJFC> BBFFGKDJGGC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct GINLCPGFHEO<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly LLDGDOINCKI<JLBFOIDJJFC> OJDCNHIBCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly LLDGDOINCKI<BPPAIFNMLAH> DDJOKNKNCKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction KFEKJNKABMM;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xCCC1D0", Offset = "0xCCA7D0", VA = "0x180CCC1D0")]
	public GINLCPGFHEO(LLDGDOINCKI<JLBFOIDJJFC> HFCJPLHKMHP, LLDGDOINCKI<BPPAIFNMLAH> FILKDPOEDAI, TAction CJDOILFHDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class NEHEBKIHBLK
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C93480", Offset = "0x3C91A80", VA = "0x183C93480")]
	public static GINLCPGFHEO<TAction> BFOPDLPDKBM<TAction>(LLDGDOINCKI<JLBFOIDJJFC> HFCJPLHKMHP, LLDGDOINCKI<BPPAIFNMLAH> FILKDPOEDAI, TAction CJDOILFHDJI) where TAction : notnull
	{
		return default(GINLCPGFHEO<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class DINCIKGDDAA<TRoot, TDeps> : JFHJAMGAEDI where TRoot : notnull where TDeps : notnull, GMKHGGAAKJH.DLOCJGNNMJF<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CGLKOLFHJLM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<FANMKCKHALG<object?, GNLHMHNEEGO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public DINCIKGDDAA<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public NFDDFNDENCJ action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<FANMKCKHALG<object?, GNLHMHNEEGO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67A3DF0", Offset = "0x67A23F0", VA = "0x1867A3DF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x67A41A0", Offset = "0x67A27A0", VA = "0x1867A41A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps ODPIHOLNHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot OCIKLMFNNKI;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public LLDGDOINCKI<JLBFOIDJJFC> ACPIGKODONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAB1080", Offset = "0xAAF680", VA = "0x180AB1080")]
		[CompilerGenerated]
		get
		{
			return default(LLDGDOINCKI<JLBFOIDJJFC>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2ED44E0", Offset = "0x2ED2AE0", VA = "0x182ED44E0")]
	public DINCIKGDDAA(TDeps GMIGKAKBDIM, TRoot CMAFOEIBEKN, LLDGDOINCKI<JLBFOIDJJFC> PLPCMHOEJHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D12B70", Offset = "0x6D11170", VA = "0x186D12B70", Slot = "4")]
	[AsyncStateMachine(typeof(DINCIKGDDAA<, >.CGLKOLFHJLM))]
	public Task<FANMKCKHALG<object, GNLHMHNEEGO>> ANGIGKOKHEN(NFDDFNDENCJ CJDOILFHDJI, bool PAIBICJIBKE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GMKHGGAAKJH
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface DLOCJGNNMJF<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<FANMKCKHALG<object, GNLHMHNEEGO>> ANGIGKOKHEN(TRoot CMAFOEIBEKN, LLDGDOINCKI<JLBFOIDJJFC> IDLICKGDHEK, NFDDFNDENCJ CJDOILFHDJI, bool PAIBICJIBKE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DLKNLKICMHB : LHIBCHHGDLN
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void DOEFMJOFBFA();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly DLKNLKICMHB FNIBPMLJKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly DOEFMJOFBFA? POEKIPGKEHO;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA4B570", Offset = "0xA49B70", VA = "0x180A4B570")]
	public DLKNLKICMHB([Optional] DOEFMJOFBFA? BKNCBDGJPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1209A10", Offset = "0x1208010", VA = "0x181209A10", Slot = "4")]
	public void MEELLNFODEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class FMPGKNILEBO : BHDGKCLAPGO
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void BNNLANPLCKD(LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<PMIFBODKNMJ> BDINIIJPKNG, LLDGDOINCKI<KHPCHGHJGBM> DCPLOEHACMA);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void FLGFGGIIKLI(LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<PMIFBODKNMJ> BDINIIJPKNG, LLDGDOINCKI<KHPCHGHJGBM> DCPLOEHACMA);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void CNNLKOMGPHG(LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<FELJLHNDBFC> OEEANCBNNKB);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly FMPGKNILEBO FNIBPMLJKFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly BNNLANPLCKD? CAAPPNPJKJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly FLGFGGIIKLI? JHELGJNNCKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly CNNLKOMGPHG? MDDOIADGDLH;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xCFEAB0", Offset = "0xCFD0B0", VA = "0x180CFEAB0")]
	public FMPGKNILEBO([Optional] BNNLANPLCKD? CAMPNHLMLCI, [Optional] FLGFGGIIKLI? FONNPGDEMMC, [Optional] CNNLKOMGPHG? EEFGHDPLFIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29B8830", Offset = "0x29B6E30", VA = "0x1829B8830", Slot = "4")]
	public void OnEdgeDidAdd(LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<PMIFBODKNMJ> BDINIIJPKNG, LLDGDOINCKI<KHPCHGHJGBM> DCPLOEHACMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29B8850", Offset = "0x29B6E50", VA = "0x1829B8850", Slot = "5")]
	public void OnEdgeWillRemove(LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<PMIFBODKNMJ> BDINIIJPKNG, LLDGDOINCKI<KHPCHGHJGBM> DCPLOEHACMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29B8810", Offset = "0x29B6E10", VA = "0x1829B8810", Slot = "6")]
	public void GKOFNJOAEOD(LLDGDOINCKI<DMMBIHDCELP> CIKIEGMNCAF, LLDGDOINCKI<FELJLHNDBFC> OEEANCBNNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "11")]
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
