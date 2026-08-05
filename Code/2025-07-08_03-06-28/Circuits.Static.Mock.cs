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
		[Cpp2IlInjected.Address(RVA = "0xA82AE0", Offset = "0xA818E0", VA = "0x180A82AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x29FB0E0", Offset = "0x29F9EE0", VA = "0x1829FB0E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA838A0", Offset = "0xA826A0", VA = "0x180A838A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA838E0", Offset = "0xA826E0", VA = "0x180A838E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class AIPIIEPHOJC<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, FLJPFJJIPIO.MOLBIDAGNEO<TAction, TNetSys> where TReceiverDeps : notnull, FLJPFJJIPIO.JLALEFLLJJB<TAction, TReceiver> where TRootDeps : notnull, FLJPFJJIPIO.HILJKOIILHM<KNKENLOFJIA, TAction, TRoot> where TRoot : notnull where TDeps : notnull, FLJPFJJIPIO.EMHNMLPCNBD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class EFILELAMKDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? NNOGKOGJKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<OAFACNPKKHB<TAction>> IDCCCGFMFKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool DBFBAFCAHEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> DDBMNOJHMCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool BLJNLANCIPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? DNFEHJHBMNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly NECBJNNNOFJ<KNKENLOFJIA, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> OPIFCGCLMCE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool BHHCHBEIJNE
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x48205D0", Offset = "0x481F3D0", VA = "0x1848205D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4820B00", Offset = "0x481F900", VA = "0x184820B00")]
		public EFILELAMKDN(int? EINIOGHFNAC, List<OAFACNPKKHB<TAction>> POJEFKFFHCH, bool JMKDFABGFCO, List<Func<Task>> EFELIDFBGEN, bool MFACMEIGHMO, TAction[]? CNOEDFLBLLI, NECBJNNNOFJ<KNKENLOFJIA, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> PBMKOGGPJGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4820890", Offset = "0x481F690", VA = "0x184820890")]
		public static AIPIIEPHOJC<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.EFILELAMKDN OGAKBGHEIKK(TDeps FEBHHEFFJMB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class FMDNBLCIDFM
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
			public FMDNBLCIDFM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<CKPFCFEHEPP<object?, FCJOMJLBDOM>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x438F4C0", Offset = "0x438E2C0", VA = "0x18438F4C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x438F860", Offset = "0x438E660", VA = "0x18438F860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public EFILELAMKDN client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HBBCPCNIOON<MLFFMCDFHFO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<CKPFCFEHEPP<object?, FCJOMJLBDOM>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public FMDNBLCIDFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4CCCF50", Offset = "0x4CCBD50", VA = "0x184CCCF50")]
		[AsyncStateMachine(typeof(AIPIIEPHOJC<, , , , , , , >.FMDNBLCIDFM.<<SendActionToAll>b__0>d))]
		internal Task GIIMMEGEHBE()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LEIMDMHIHHH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AIPIIEPHOJC<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public HBBCPCNIOON<MLFFMCDFHFO> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HBBCPCNIOON<MLFFMCDFHFO> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public HBBCPCNIOON<KNKENLOFJIA> requestId;

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
		private TaskAwaiter<CKPFCFEHEPP<object, FCJOMJLBDOM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5412CE0", Offset = "0x5411AE0", VA = "0x185412CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5413650", Offset = "0x5412450", VA = "0x185413650", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private GHBIFODMAFN<MLFFMCDFHFO, EFILELAMKDN> MKIEHFLADHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<OAFACNPKKHB<TAction>> DINMLHLACLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int ALILJIAAEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int PBCOLHBFHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int FGIKEDEKDLC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4FE3130", Offset = "0x4FE1F30", VA = "0x184FE3130")]
	public AIPIIEPHOJC(int OAJKIHIFMKP, int CLJCNAIPGDK, int MAMKKDEENPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1A40", Offset = "0x4FE0840", VA = "0x184FE1A40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4FE2290", Offset = "0x4FE1090", VA = "0x184FE2290")]
	public void IPIFJLHDOPJ(HBBCPCNIOON<MLFFMCDFHFO> KLGOHLFABCA, TDeps FEBHHEFFJMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1D10", Offset = "0x4FE0B10", VA = "0x184FE1D10")]
	public void IJJFICAPIGN(HBBCPCNIOON<MLFFMCDFHFO> KLGOHLFABCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4FE2310", Offset = "0x4FE1110", VA = "0x184FE2310")]
	public void MFDFGPDOIJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4FE2340", Offset = "0x4FE1140", VA = "0x184FE2340")]
	public (Task, Task[]) NGBHNIDGECG(TRoot EGPDFGOHLFM, [In] NMOEICHMKDD<MLFFMCDFHFO> FGFKCLKLCOO, [In] GHBIFODMAFN<MLFFMCDFHFO, TNetSys> EGJFDPPJGHO, [In] GHBIFODMAFN<MLFFMCDFHFO, TReceiver> PGHGELKICNP, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, HBBCPCNIOON<KNKENLOFJIA> PGNFEHAOEME, TAction LJIGAFKJJAI)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4FE27B0", Offset = "0x4FE15B0", VA = "0x184FE27B0")]
	public Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> NGBHNIDGECG(TRoot EGPDFGOHLFM, TNetSys DFODLDMBKGD, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, TAction LJIGAFKJJAI, bool CNJBMAGKMLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1BC0", Offset = "0x4FE09C0", VA = "0x184FE1BC0")]
	[AsyncStateMachine(typeof(AIPIIEPHOJC<, , , , , , , >.LEIMDMHIHHH))]
	public Task FDKCEDNIALC(TRoot EGPDFGOHLFM, TNetSys BCKIHKBGACN, TReceiver JBODBHEGPEF, HBBCPCNIOON<MLFFMCDFHFO> PJLCJPFBGGH, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, HBBCPCNIOON<KNKENLOFJIA> PGNFEHAOEME, TAction LJIGAFKJJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FE1D30", Offset = "0x4FE0B30", VA = "0x184FE1D30")]
	public Task IMJBPKDGIMB(TRoot EGPDFGOHLFM, TNetSys BCKIHKBGACN, TReceiver JBODBHEGPEF, HBBCPCNIOON<MLFFMCDFHFO> PJLCJPFBGGH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct OAFACNPKKHB<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly HBBCPCNIOON<MLFFMCDFHFO> LJECFIAEENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly HBBCPCNIOON<KNKENLOFJIA> ONLOPDAPFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction GIAAFHDEFJA;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xD244A0", Offset = "0xD232A0", VA = "0x180D244A0")]
	public OAFACNPKKHB(HBBCPCNIOON<MLFFMCDFHFO> FLHCGDNOCHL, HBBCPCNIOON<KNKENLOFJIA> PGNFEHAOEME, TAction LJIGAFKJJAI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class LMJDHAGCFJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C5F500", Offset = "0x3C5E300", VA = "0x183C5F500")]
	public static OAFACNPKKHB<TAction> OGAKBGHEIKK<TAction>(HBBCPCNIOON<MLFFMCDFHFO> FLHCGDNOCHL, HBBCPCNIOON<KNKENLOFJIA> PGNFEHAOEME, TAction LJIGAFKJJAI) where TAction : notnull
	{
		return default(OAFACNPKKHB<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class OKJOJBMKOAG<TRoot, TDeps> : CLCDEAIIMGG where TRoot : notnull where TDeps : notnull, GCEEEHAIGNJ.MCHOLBBMODB<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct OAFBIIPCJAA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<CKPFCFEHEPP<object?, FCJOMJLBDOM>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public OKJOJBMKOAG<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EOEHBAGJMDO action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<CKPFCFEHEPP<object?, FCJOMJLBDOM>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5840220", Offset = "0x583F020", VA = "0x185840220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5840560", Offset = "0x583F360", VA = "0x185840560", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps IHILFMGFJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot FLPNIJEGLKO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public HBBCPCNIOON<MLFFMCDFHFO> HHOMEEOCALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xAAEA50", Offset = "0xAAD850", VA = "0x180AAEA50")]
		[CompilerGenerated]
		get
		{
			return default(HBBCPCNIOON<MLFFMCDFHFO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2F076C0", Offset = "0x2F064C0", VA = "0x182F076C0")]
	public OKJOJBMKOAG(TDeps FEBHHEFFJMB, TRoot EGPDFGOHLFM, HBBCPCNIOON<MLFFMCDFHFO> IJADKGMCKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x58638B0", Offset = "0x58626B0", VA = "0x1858638B0", Slot = "4")]
	[AsyncStateMachine(typeof(OKJOJBMKOAG<, >.OAFBIIPCJAA))]
	public Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> NGBHNIDGECG(EOEHBAGJMDO LJIGAFKJJAI, bool CNJBMAGKMLK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class GCEEEHAIGNJ
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MCHOLBBMODB<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<CKPFCFEHEPP<object, FCJOMJLBDOM>> NGBHNIDGECG(TRoot EGPDFGOHLFM, HBBCPCNIOON<MLFFMCDFHFO> MELALKCBPCC, EOEHBAGJMDO LJIGAFKJJAI, bool CNJBMAGKMLK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PKKLCNJKKIP : LMDLAGMAFCJ
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void PKOJIKHEGOH();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly PKKLCNJKKIP ODAOEPEFKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly PKOJIKHEGOH? MHHOFJGNJGH;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA665B0", Offset = "0xA653B0", VA = "0x180A665B0")]
	public PKKLCNJKKIP([Optional] PKOJIKHEGOH? DCLHHMMMOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x128D320", Offset = "0x128C120", VA = "0x18128D320", Slot = "4")]
	public void GEAOFDBKGJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class CMKHIBIFOIP : JANLJBLGDGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void JBNEHJJDAKO(HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KJOAJLIJKDJ> OJBPNAOGCLO, HBBCPCNIOON<CJCPCFJCIBN> EHLMMBEGIAN);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void LPFPNKFCOGO(HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KJOAJLIJKDJ> OJBPNAOGCLO, HBBCPCNIOON<CJCPCFJCIBN> EHLMMBEGIAN);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void IILIAPPBJBD(HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KNPFHPANEIM> BPBNOKKGEDO);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly CMKHIBIFOIP ODAOEPEFKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly JBNEHJJDAKO? NCHICKBMJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly LPFPNKFCOGO? HGDLGIMBEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly IILIAPPBJBD? FCAHDOKEJAN;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xD42A30", Offset = "0xD41830", VA = "0x180D42A30")]
	public CMKHIBIFOIP([Optional] JBNEHJJDAKO? AIJGAOIFJDK, [Optional] LPFPNKFCOGO? LBJMFIAGMHK, [Optional] IILIAPPBJBD? HDLGBDGHGLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x29FAEE0", Offset = "0x29F9CE0", VA = "0x1829FAEE0", Slot = "4")]
	public void OnEdgeDidAdd(HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KJOAJLIJKDJ> OJBPNAOGCLO, HBBCPCNIOON<CJCPCFJCIBN> EHLMMBEGIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29FAF00", Offset = "0x29F9D00", VA = "0x1829FAF00", Slot = "5")]
	public void OnEdgeWillRemove(HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KJOAJLIJKDJ> OJBPNAOGCLO, HBBCPCNIOON<CJCPCFJCIBN> EHLMMBEGIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29FAF20", Offset = "0x29F9D20", VA = "0x1829FAF20", Slot = "6")]
	public void PMAKFPHOKIK(HBBCPCNIOON<KDGLCMHKHGO> AIHPKIPEANN, HBBCPCNIOON<KNPFHPANEIM> BPBNOKKGEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "11")]
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
