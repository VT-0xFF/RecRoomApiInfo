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
		[Cpp2IlInjected.Address(RVA = "0xA530A0", Offset = "0xA518A0", VA = "0x180A530A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x28B8BE0", Offset = "0x28B73E0", VA = "0x1828B8BE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA536D0", Offset = "0xA51ED0", VA = "0x180A536D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA53710", Offset = "0xA51F10", VA = "0x180A53710")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class GMHCINCHCHH<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, MEMILIKICDN.CMIKHOHAFFF<TAction, TNetSys> where TReceiverDeps : notnull, MEMILIKICDN.JOMOLGMOOAM<TAction, TReceiver> where TRootDeps : notnull, MEMILIKICDN.KOABMAACOIK<OPHGODHGBFL, TAction, TRoot> where TRoot : notnull where TDeps : notnull, MEMILIKICDN.ADIKCNKHIIB<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class BJFAEJLFICG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? EMPIDJEKPDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<PBJLOBOFOFF<TAction>> NHMLCGDKDNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool HEHILBCPDIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> LFOODMCGFNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool GACNAHJAGCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? HJMKADNNDIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly LCAFEICIBNF<OPHGODHGBFL, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> HPPPIODGOBI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool FMPEBLFPLEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6176C30", Offset = "0x6175430", VA = "0x186176C30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6176CD0", Offset = "0x61754D0", VA = "0x186176CD0")]
		public BJFAEJLFICG(int? NDEBGPCHIHG, List<PBJLOBOFOFF<TAction>> AJOJHNMKIKL, bool BAKDKBJFGCL, List<Func<Task>> GKKKFBOOBKC, bool ABHMIAIJLJP, TAction[]? DAPKAOKFDDG, LCAFEICIBNF<OPHGODHGBFL, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> OEHDGLIEHLE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61766F0", Offset = "0x6174EF0", VA = "0x1861766F0")]
		public static GMHCINCHCHH<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.BJFAEJLFICG CCPKJDCALBG(TDeps GGLINDGLEPB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class NKNIFIHNCLK
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
			public NKNIFIHNCLK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<AOGODOAGAAO<object?, DLBBNMCGCPF>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<AOGODOAGAAO<object, DLBBNMCGCPF>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x42353F0", Offset = "0x4233BF0", VA = "0x1842353F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x4235B60", Offset = "0x4234360", VA = "0x184235B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public BJFAEJLFICG client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public DPJIAIFILPM<KEINJKHIFPI> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<AOGODOAGAAO<object?, DLBBNMCGCPF>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public NKNIFIHNCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x55D6400", Offset = "0x55D4C00", VA = "0x1855D6400")]
		[AsyncStateMachine(typeof(GMHCINCHCHH<, , , , , , , >.NKNIFIHNCLK.<<SendActionToAll>b__0>d))]
		internal Task IEGNGMLBLJH()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LLBONGBHIIM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public GMHCINCHCHH<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public DPJIAIFILPM<KEINJKHIFPI> receiverId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public DPJIAIFILPM<KEINJKHIFPI> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DPJIAIFILPM<OPHGODHGBFL> requestId;

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
		private TaskAwaiter<AOGODOAGAAO<object, DLBBNMCGCPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5308370", Offset = "0x5306B70", VA = "0x185308370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5308D60", Offset = "0x5307560", VA = "0x185308D60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private HFOFBJNAOJN<KEINJKHIFPI, BJFAEJLFICG> IJKHOMMNKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<PBJLOBOFOFF<TAction>> FHDNKELJJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int HADLIEMGEOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int PEHADNHMGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int HKFBFEHOBGM;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4CA9DF0", Offset = "0x4CA85F0", VA = "0x184CA9DF0")]
	public GMHCINCHCHH(int MBHGDJJPJDE, int IBNKNADDIGI, int JCPBDJKFPHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8D60", Offset = "0x4CA7560", VA = "0x184CA8D60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4CA9D70", Offset = "0x4CA8570", VA = "0x184CA9D70")]
	public void OGFNAKAAHEJ(DPJIAIFILPM<KEINJKHIFPI> MAGIPLDDFJB, TDeps GGLINDGLEPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4CA9CD0", Offset = "0x4CA84D0", VA = "0x184CA9CD0")]
	public void IEEKMCEGOPC(DPJIAIFILPM<KEINJKHIFPI> MAGIPLDDFJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8DA0", Offset = "0x4CA75A0", VA = "0x184CA8DA0")]
	public void EPMPBBGIACL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4CA9560", Offset = "0x4CA7D60", VA = "0x184CA9560")]
	public (Task, Task[]) HMBDKOOMFEL(TRoot MJAMEBJFAIN, [In] BDIOPMMDPBG<KEINJKHIFPI> JHEDOJLPGBG, [In] HFOFBJNAOJN<KEINJKHIFPI, TNetSys> GGFFOFPIJFD, [In] HFOFBJNAOJN<KEINJKHIFPI, TReceiver> NMJOBBDBJBN, DPJIAIFILPM<KEINJKHIFPI> EIKFCLBNLII, DPJIAIFILPM<OPHGODHGBFL> DPIIAJNIKCJ, TAction AMNCPNDDCLP)
	{
		return default((Task, Task[]));
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4CA9A10", Offset = "0x4CA8210", VA = "0x184CA9A10")]
	public Task<AOGODOAGAAO<object, DLBBNMCGCPF>> HMBDKOOMFEL(TRoot MJAMEBJFAIN, TNetSys OHCFIGMIAEM, DPJIAIFILPM<KEINJKHIFPI> EIKFCLBNLII, TAction AMNCPNDDCLP, bool HJFJGIBACEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4CA86D0", Offset = "0x4CA6ED0", VA = "0x184CA86D0")]
	[AsyncStateMachine(typeof(GMHCINCHCHH<, , , , , , , >.LLBONGBHIIM))]
	public Task BCDAIPOJCNP(TRoot MJAMEBJFAIN, TNetSys JMPHDMGFAII, TReceiver HCJKOGOOPMP, DPJIAIFILPM<KEINJKHIFPI> MEFECJAOCPH, DPJIAIFILPM<KEINJKHIFPI> EIKFCLBNLII, DPJIAIFILPM<OPHGODHGBFL> DPIIAJNIKCJ, TAction AMNCPNDDCLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4CA8820", Offset = "0x4CA7020", VA = "0x184CA8820")]
	public Task CAFOKOBBHDD(TRoot MJAMEBJFAIN, TNetSys JMPHDMGFAII, TReceiver HCJKOGOOPMP, DPJIAIFILPM<KEINJKHIFPI> MEFECJAOCPH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal readonly struct PBJLOBOFOFF<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly DPJIAIFILPM<KEINJKHIFPI> JLGPGJOAPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly DPJIAIFILPM<OPHGODHGBFL> GHNKKMOPFBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction DECDKLECEJH;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xC9D630", Offset = "0xC9BE30", VA = "0x180C9D630")]
	public PBJLOBOFOFF(DPJIAIFILPM<KEINJKHIFPI> LFGOLEKPJOL, DPJIAIFILPM<OPHGODHGBFL> DPIIAJNIKCJ, TAction AMNCPNDDCLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal static class CHPPBDJFNMG
{
	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x37B7FD0", Offset = "0x37B67D0", VA = "0x1837B7FD0")]
	public static PBJLOBOFOFF<TAction> CCPKJDCALBG<TAction>(DPJIAIFILPM<KEINJKHIFPI> LFGOLEKPJOL, DPJIAIFILPM<OPHGODHGBFL> DPIIAJNIKCJ, TAction AMNCPNDDCLP) where TAction : notnull
	{
		return default(PBJLOBOFOFF<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public sealed class KAEMDFODDAP<TRoot, TDeps> : HEOECENJGAN where TRoot : notnull where TDeps : notnull, IDNMDPIIOON.GMEAJIMIHEC<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CHGIMHIJKGH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<AOGODOAGAAO<object?, DLBBNMCGCPF>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public KAEMDFODDAP<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public OBFJFFGOJGF action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<AOGODOAGAAO<object?, DLBBNMCGCPF>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x66A1AC0", Offset = "0x66A02C0", VA = "0x1866A1AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x66A2150", Offset = "0x66A0950", VA = "0x1866A2150", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps OFNAGCEIFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot CHELFLCELJO;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DPJIAIFILPM<KEINJKHIFPI> ILLBEGJBGAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
		[CompilerGenerated]
		get
		{
			return default(DPJIAIFILPM<KEINJKHIFPI>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2D99D50", Offset = "0x2D98550", VA = "0x182D99D50")]
	public KAEMDFODDAP(TDeps GGLINDGLEPB, TRoot MJAMEBJFAIN, DPJIAIFILPM<KEINJKHIFPI> ABHMJDPBNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5188890", Offset = "0x5187090", VA = "0x185188890", Slot = "4")]
	[AsyncStateMachine(typeof(KAEMDFODDAP<, >.CHGIMHIJKGH))]
	public Task<AOGODOAGAAO<object, DLBBNMCGCPF>> HMBDKOOMFEL(OBFJFFGOJGF AMNCPNDDCLP, bool HJFJGIBACEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class IDNMDPIIOON
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GMEAJIMIHEC<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<AOGODOAGAAO<object, DLBBNMCGCPF>> HMBDKOOMFEL(TRoot MJAMEBJFAIN, DPJIAIFILPM<KEINJKHIFPI> EIKFCLBNLII, OBFJFFGOJGF AMNCPNDDCLP, bool HJFJGIBACEG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class AKPHKENCJMF : KPENNDOGGML
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public delegate void DEJEGCIMPJE();

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly AKPHKENCJMF HPECEAELCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly DEJEGCIMPJE? LKEOPMJKOGE;

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0xA2D2A0", Offset = "0xA2BAA0", VA = "0x180A2D2A0")]
	public AKPHKENCJMF([Optional] DEJEGCIMPJE? BBECFNBACIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x119A3C0", Offset = "0x1198BC0", VA = "0x18119A3C0", Slot = "4")]
	public void IHDMNBIFJBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class AGLDNLIBHHH : NDKILPFMJOK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void FHIAILLAIAN(DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<PFIGHJMHNHG> GALMFPHHMLF, DPJIAIFILPM<GNMEFCOMPFO> APEPEJLODCI);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void DKMGBIPDLLB(DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<PFIGHJMHNHG> GALMFPHHMLF, DPJIAIFILPM<GNMEFCOMPFO> APEPEJLODCI);

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate void GAOLLEIIMIE(DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<NCBBKKLBDCC> IBMDEKLDACD);

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly AGLDNLIBHHH HPECEAELCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly FHIAILLAIAN? LAFCHGPNNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly DKMGBIPDLLB? CEECPJOAHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly GAOLLEIIMIE? CMDMPBBCFIF;

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0xCC0080", Offset = "0xCBE880", VA = "0x180CC0080")]
	public AGLDNLIBHHH([Optional] FHIAILLAIAN? DOCNPPPAKCC, [Optional] DKMGBIPDLLB? JBFPECEIKCO, [Optional] GAOLLEIIMIE? MKBNHNEFBFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x28B8960", Offset = "0x28B7160", VA = "0x1828B8960", Slot = "4")]
	public void OnEdgeDidAdd(DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<PFIGHJMHNHG> GALMFPHHMLF, DPJIAIFILPM<GNMEFCOMPFO> APEPEJLODCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x28B8980", Offset = "0x28B7180", VA = "0x1828B8980", Slot = "5")]
	public void OnEdgeWillRemove(DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<PFIGHJMHNHG> GALMFPHHMLF, DPJIAIFILPM<GNMEFCOMPFO> APEPEJLODCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x28B89A0", Offset = "0x28B71A0", VA = "0x1828B89A0", Slot = "6")]
	public void PGBFFHELNMB(DPJIAIFILPM<NIMKICIFGFC> MFJIMNDMCML, DPJIAIFILPM<NCBBKKLBDCC> IBMDEKLDACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "8")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "9")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "10")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0xA28D40", Offset = "0xA27540", VA = "0x180A28D40", Slot = "11")]
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
