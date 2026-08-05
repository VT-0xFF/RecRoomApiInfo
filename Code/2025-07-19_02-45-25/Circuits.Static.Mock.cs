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
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
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
		[Cpp2IlInjected.Address(RVA = "0x2A6D1A0", Offset = "0x2A6C1A0", VA = "0x182A6D1A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA8B7C0", Offset = "0xA8A7C0", VA = "0x180A8B7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA8B800", Offset = "0xA8A800", VA = "0x180A8B800")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class DDMIKGDFDID<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, CMJLOOFPGDI.NGNHNCCHOKL<TAction, TNetSys> where TReceiverDeps : notnull, CMJLOOFPGDI.POMDOJCFFOI<TAction, TReceiver> where TRootDeps : notnull, CMJLOOFPGDI.IMFJKNHCPNM<TAction, TRoot> where TRoot : notnull where TDeps : notnull, CMJLOOFPGDI.KGPAJJPHDDD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class CJMBLGFHEHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? OPGOGGPOADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<Func<Task>> PFFLJGHKMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool CGDAPIIJLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> MADKKOHJDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool IGPJMFJELCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? IJKAIDHJOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly FOOMECEDINO<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> GHKGCMFJNHF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool JNEIIHAKJEM
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x68C1A90", Offset = "0x68C0A90", VA = "0x1868C1A90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68C1EC0", Offset = "0x68C0EC0", VA = "0x1868C1EC0")]
		public CJMBLGFHEHL(int? EBPGGNGODMA, List<Func<Task>> ALIACAHNEAA, bool LEDONKJDCAH, List<Func<Task>> PNDMPKKOHGL, bool OEPCLPICDGJ, TAction[]? JELONAJMODP, FOOMECEDINO<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> GHNJPIOLDDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68C1AE0", Offset = "0x68C0AE0", VA = "0x1868C1AE0")]
		public static DDMIKGDFDID<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.CJMBLGFHEHL MPFKOOIPONO(TDeps APEKGFIAPNC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class OLKNPKNOMHO
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
			public OLKNPKNOMHO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<DAFIFKKNPFP<object?, AGMCGONFHKP>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<DAFIFKKNPFP<object, AGMCGONFHKP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4458060", Offset = "0x4457060", VA = "0x184458060", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4458460", Offset = "0x4457460", VA = "0x184458460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CJMBLGFHEHL client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public OCIDMCEKJIP<HHMPHBFPOIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<DAFIFKKNPFP<object?, AGMCGONFHKP>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public OLKNPKNOMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x594AD90", Offset = "0x5949D90", VA = "0x18594AD90")]
		[AsyncStateMachine(typeof(DDMIKGDFDID<, , , , , , , >.OLKNPKNOMHO.<<SendActionToAll>b__0>d))]
		internal Task DACHIIPMFFM()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class BHJCFAGHOLJ
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
			public BHJCFAGHOLJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskCompletionSource<DAFIFKKNPFP<object, AGMCGONFHKP>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<DAFIFKKNPFP<object, AGMCGONFHKP>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4456190", Offset = "0x4455190", VA = "0x184456190", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4456920", Offset = "0x4455920", VA = "0x184456920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public CJMBLGFHEHL client;

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
		public OCIDMCEKJIP<HHMPHBFPOIN> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TaskCompletionSource<DAFIFKKNPFP<object, AGMCGONFHKP>> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public BHJCFAGHOLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x643B950", Offset = "0x643A950", VA = "0x18643B950")]
		[AsyncStateMachine(typeof(DDMIKGDFDID<, , , , , , , >.BHJCFAGHOLJ.<<ReceiveAction>b__0>d))]
		internal Task NHDBJGNIECL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private OPOENCIBKDO<HHMPHBFPOIN, CJMBLGFHEHL> ILLPGMDEIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<PHGIDOLDDGB<TAction>> IIGEEBOCKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int NICBGODKLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int OGPOCCLGMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int NINHOCHGMFG;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E84990", Offset = "0x6E83990", VA = "0x186E84990")]
	public DDMIKGDFDID(int CPEEKLGAPKH, int PGEJPGKHGEI, int FAAOILGACJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E83230", Offset = "0x6E82230", VA = "0x186E83230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E83D60", Offset = "0x6E82D60", VA = "0x186E83D60")]
	public void JHDAJAIEIKG(OCIDMCEKJIP<HHMPHBFPOIN> AEOGCMBMFHO, TDeps APEKGFIAPNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E83210", Offset = "0x6E82210", VA = "0x186E83210")]
	public void CGFBBNMJKFF(OCIDMCEKJIP<HHMPHBFPOIN> AEOGCMBMFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E83E40", Offset = "0x6E82E40", VA = "0x186E83E40")]
	public void LIEDGHBCDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E84670", Offset = "0x6E83670", VA = "0x186E84670")]
	public Task<DAFIFKKNPFP<object, AGMCGONFHKP>> LOHHICJOBBB(TRoot NKBKNNLLHKF, [In] ILEMODONLAI<HHMPHBFPOIN> HMKMBDKIIEK, [In] OPOENCIBKDO<HHMPHBFPOIN, TNetSys> IDFDPEEODBM, [In] OPOENCIBKDO<HHMPHBFPOIN, TReceiver> EFKILOEPCFD, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction DMHPHEGJKMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E83E70", Offset = "0x6E82E70", VA = "0x186E83E70")]
	public Task<DAFIFKKNPFP<object, AGMCGONFHKP>> LOHHICJOBBB(TRoot NKBKNNLLHKF, TNetSys JLNNGEFEACL, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction DMHPHEGJKMB, bool HANGNDPHGHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E83A40", Offset = "0x6E82A40", VA = "0x186E83A40")]
	public Task<DAFIFKKNPFP<object, AGMCGONFHKP>> IBLOHAMGFPN(TRoot NKBKNNLLHKF, TNetSys JNPMELKEIHO, TReceiver GEBKONJKJPJ, OCIDMCEKJIP<HHMPHBFPOIN> MEDFMOCHKAP, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, TAction DMHPHEGJKMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E834B0", Offset = "0x6E824B0", VA = "0x186E834B0")]
	public Task FDLHBJFMAEJ(TRoot NKBKNNLLHKF, TNetSys JNPMELKEIHO, TReceiver GEBKONJKJPJ, OCIDMCEKJIP<HHMPHBFPOIN> MEDFMOCHKAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal readonly struct PHGIDOLDDGB<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly OCIDMCEKJIP<HHMPHBFPOIN> NKLJHIGAMHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction PGGIDMMHNCB;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x188EFE0", Offset = "0x188DFE0", VA = "0x18188EFE0")]
	public PHGIDOLDDGB(OCIDMCEKJIP<HHMPHBFPOIN> NFDMOMMJDAE, TAction DMHPHEGJKMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class EJMODEHCCHI
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3AD1310", Offset = "0x3AD0310", VA = "0x183AD1310")]
	public static PHGIDOLDDGB<TAction> MPFKOOIPONO<TAction>(OCIDMCEKJIP<HHMPHBFPOIN> NFDMOMMJDAE, TAction DMHPHEGJKMB) where TAction : notnull
	{
		return default(PHGIDOLDDGB<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class PDPOIFNLMMD<TRoot, TDeps> : CGNLMLIMDDN where TRoot : notnull where TDeps : notnull, MIIPEFKGINO.GJGLACPCBJM<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct PCAJJDLBCBD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<DAFIFKKNPFP<object?, AGMCGONFHKP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public PDPOIFNLMMD<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public GDKEFPLLLGH action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<DAFIFKKNPFP<object?, AGMCGONFHKP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5A21EE0", Offset = "0x5A20EE0", VA = "0x185A21EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5A22210", Offset = "0x5A21210", VA = "0x185A22210", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps AEIHNHECOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot EAGMJMHJCOH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public OCIDMCEKJIP<HHMPHBFPOIN> HAONMFFGJOL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAAD1A0", VA = "0x180AAE1A0")]
		[CompilerGenerated]
		get
		{
			return default(OCIDMCEKJIP<HHMPHBFPOIN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x2FA58A0", Offset = "0x2FA48A0", VA = "0x182FA58A0")]
	public PDPOIFNLMMD(TDeps APEKGFIAPNC, TRoot NKBKNNLLHKF, OCIDMCEKJIP<HHMPHBFPOIN> CDDLENPDBMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5A38610", Offset = "0x5A37610", VA = "0x185A38610", Slot = "4")]
	[AsyncStateMachine(typeof(PDPOIFNLMMD<, >.PCAJJDLBCBD))]
	public Task<DAFIFKKNPFP<object, AGMCGONFHKP>> LOHHICJOBBB(GDKEFPLLLGH DMHPHEGJKMB, bool HANGNDPHGHG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class MIIPEFKGINO
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface GJGLACPCBJM<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<DAFIFKKNPFP<object, AGMCGONFHKP>> LOHHICJOBBB(TRoot NKBKNNLLHKF, OCIDMCEKJIP<HHMPHBFPOIN> JJOPMFIJCCI, GDKEFPLLLGH DMHPHEGJKMB, bool HANGNDPHGHG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class ANCHPGEPJHC : FDFLHLPAOHN
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void LMIOBHMJEJL();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly ANCHPGEPJHC KONBGMLOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly LMIOBHMJEJL? JIMEMDFHNJD;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xA6BBE0", Offset = "0xA6ABE0", VA = "0x180A6BBE0")]
	public ANCHPGEPJHC([Optional] LMIOBHMJEJL? CAGMPADHFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1297C10", Offset = "0x1296C10", VA = "0x181297C10", Slot = "4")]
	public void DMCGIEDAKMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class EEPHOFOBABB : CFIEHPLJFBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void EPILBIFHHKJ(OCIDMCEKJIP<FJLLKPMEKPL> GLBONDOGBDB, OCIDMCEKJIP<EIFBEOKBLEN> LNDCHJCNNAP, OCIDMCEKJIP<MCJPDJDJIKJ> OHIPIPFCNFF);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void NNMHGEACCAE(OCIDMCEKJIP<FJLLKPMEKPL> GLBONDOGBDB, OCIDMCEKJIP<EIFBEOKBLEN> LNDCHJCNNAP, OCIDMCEKJIP<MCJPDJDJIKJ> OHIPIPFCNFF);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public delegate void JJCIBAMJDMO(OCIDMCEKJIP<FJLLKPMEKPL> GLBONDOGBDB, OCIDMCEKJIP<HENCEPHGHEP> OMEKNOMEFGA);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly EEPHOFOBABB KONBGMLOLPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EPILBIFHHKJ? KEKOLALHNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly NNMHGEACCAE? AKGEECELAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly JJCIBAMJDMO? NNHHAEHMDHG;

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xD64110", Offset = "0xD63110", VA = "0x180D64110")]
	public EEPHOFOBABB([Optional] EPILBIFHHKJ? LMODAHBFHPF, [Optional] NNMHGEACCAE? EOFDFBMIMNN, [Optional] JJCIBAMJDMO? OFNKFDBMMGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CFC0", Offset = "0x2A6BFC0", VA = "0x182A6CFC0", Slot = "4")]
	public void OnEdgeDidAdd(OCIDMCEKJIP<FJLLKPMEKPL> GLBONDOGBDB, OCIDMCEKJIP<EIFBEOKBLEN> LNDCHJCNNAP, OCIDMCEKJIP<MCJPDJDJIKJ> OHIPIPFCNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CFE0", Offset = "0x2A6BFE0", VA = "0x182A6CFE0", Slot = "5")]
	public void OnEdgeWillRemove(OCIDMCEKJIP<FJLLKPMEKPL> GLBONDOGBDB, OCIDMCEKJIP<EIFBEOKBLEN> LNDCHJCNNAP, OCIDMCEKJIP<MCJPDJDJIKJ> OHIPIPFCNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x2A6CFA0", Offset = "0x2A6BFA0", VA = "0x182A6CFA0", Slot = "6")]
	public void BCLCHKGINGH(OCIDMCEKJIP<FJLLKPMEKPL> GLBONDOGBDB, OCIDMCEKJIP<HENCEPHGHEP> OMEKNOMEFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "11")]
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
