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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B89620", Offset = "0x2B88020", VA = "0x182B89620")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public sealed class BKJMIMBBIIK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> : IDisposable where TAction : notnull where TNetSys : notnull where TReceiver : notnull where TActionDeps : notnull, IIGAKIFKCLP.JEPPMGHICLP<TAction, TNetSys> where TReceiverDeps : notnull, IIGAKIFKCLP.HBMHBDGGBED<TAction, TReceiver> where TRootDeps : notnull, IIGAKIFKCLP.POHCMDEJCHM<TAction, TRoot> where TRoot : notnull where TDeps : notnull, IIGAKIFKCLP.KACJPEEEGBG<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	internal sealed class KONKJPALGEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal int? FBCOLIPEFBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		internal readonly List<Func<Task>> GHIFAHDOMPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		internal bool DCHHOOAKEHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		internal readonly List<Func<Task>> DGCJLPDOOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		internal bool HAIGOKGNGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		internal TAction[]? LDMHCNEBAOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		internal readonly IGDGMNGOELK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> FDINEDBHNHO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		internal bool FMMCENLBICD
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x5680750", Offset = "0x567F150", VA = "0x185680750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5680BA0", Offset = "0x567F5A0", VA = "0x185680BA0")]
		public KONKJPALGEE(int? IPAMFJLIOCE, List<Func<Task>> GMAFLNPEBMP, bool OMCMEMHBEHA, List<Func<Task>> GHKHONGDPGM, bool KNFOKGDFFAG, TAction[]? DCFJKKHIHEK, IGDGMNGOELK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> DMDKJHFAHAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x56807A0", Offset = "0x567F1A0", VA = "0x1856807A0")]
		public static BKJMIMBBIIK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps>.KONKJPALGEE KDBDJPAJKDJ(TDeps KPEJCAGFLDG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class IBIPGKHFDGA
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
			public IBIPGKHFDGA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private TaskCompletionSource<FEENKEDBOAD<object?, DDLDMBFFDDA>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private TaskAwaiter<FEENKEDBOAD<object, DDLDMBFFDDA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x45A4930", Offset = "0x45A3330", VA = "0x1845A4930", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x45A4D30", Offset = "0x45A3730", VA = "0x1845A4D30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public KONKJPALGEE client;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public TNetSys sender;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public HOHDPLDONAJ<DLMHCPGAPLL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public TaskCompletionSource<FEENKEDBOAD<object?, DDLDMBFFDDA>> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public TAction actionCopy;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public IBIPGKHFDGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x52CE220", Offset = "0x52CCC20", VA = "0x1852CE220")]
		[AsyncStateMachine(typeof(BKJMIMBBIIK<, , , , , , , >.IBIPGKHFDGA.<<SendActionToAll>b__0>d))]
		internal Task CEIHEBDCFPL()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class DAJOODELLBA
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
			public DAJOODELLBA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private TaskCompletionSource<FEENKEDBOAD<object, DDLDMBFFDDA>> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TaskAwaiter<FEENKEDBOAD<object, DDLDMBFFDDA>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x45A2A00", Offset = "0x45A1400", VA = "0x1845A2A00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x45A31A0", Offset = "0x45A1BA0", VA = "0x1845A31A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KONKJPALGEE client;

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
		public HOHDPLDONAJ<DLMHCPGAPLL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TaskCompletionSource<FEENKEDBOAD<object, DDLDMBFFDDA>> tcs;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DAJOODELLBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x45D2270", Offset = "0x45D0C70", VA = "0x1845D2270")]
		[AsyncStateMachine(typeof(BKJMIMBBIIK<, , , , , , , >.DAJOODELLBA.<<ReceiveAction>b__0>d))]
		internal Task NDGDFNKELGI()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private LGCELBLJKFI<DLMHCPGAPLL, KONKJPALGEE> CHJLGJGFDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly List<EHOJFGIPNKJ<TAction>> JBIPDMKKKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public readonly int CJHBLBKCDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly int EPCJNLABBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly int JJJKKBKMMMI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67784A0", Offset = "0x6776EA0", VA = "0x1867784A0")]
	public BKJMIMBBIIK(int EKBDMDDCHNL, int AMHCLELFEBI, int IIIJLONDJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67772F0", Offset = "0x6775CF0", VA = "0x1867772F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6777330", Offset = "0x6775D30", VA = "0x186777330")]
	public void FBFKLIHCGBN(HOHDPLDONAJ<DLMHCPGAPLL> KAJNACGJJJD, TDeps KPEJCAGFLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6777310", Offset = "0x6775D10", VA = "0x186777310")]
	public void ECENPKBLIIN(HOHDPLDONAJ<DLMHCPGAPLL> KAJNACGJJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6777430", Offset = "0x6775E30", VA = "0x186777430")]
	public void GFCEFKFOEMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67776E0", Offset = "0x67760E0", VA = "0x1867776E0")]
	public Task<FEENKEDBOAD<object, DDLDMBFFDDA>> JDIGHGLHMJP(TRoot FAIGKPPBFHA, [In] MBIENDFFGHC<DLMHCPGAPLL> LHKEJDCLFFC, [In] LGCELBLJKFI<DLMHCPGAPLL, TNetSys> APJJHKMCNNK, [In] LGCELBLJKFI<DLMHCPGAPLL, TReceiver> GDCLGIJLDLN, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction FCCCPABHDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6777D60", Offset = "0x6776760", VA = "0x186777D60")]
	public Task<FEENKEDBOAD<object, DDLDMBFFDDA>> JDIGHGLHMJP(TRoot FAIGKPPBFHA, TNetSys FPJMIEGHFGE, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction FCCCPABHDPG, bool HGJNBDAKLCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6776C70", Offset = "0x6775670", VA = "0x186776C70")]
	public Task<FEENKEDBOAD<object, DDLDMBFFDDA>> BJNOIEGMLCC(TRoot FAIGKPPBFHA, TNetSys OKJPEBONPFA, TReceiver DCNLFPCOIJG, HOHDPLDONAJ<DLMHCPGAPLL> NGLFNJMHHAL, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction FCCCPABHDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6777FE0", Offset = "0x67769E0", VA = "0x186777FE0")]
	public Task KOJMIHAKBAI(TRoot FAIGKPPBFHA, TNetSys OKJPEBONPFA, TReceiver DCNLFPCOIJG, HOHDPLDONAJ<DLMHCPGAPLL> NGLFNJMHHAL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
internal readonly struct EHOJFGIPNKJ<TAction> where TAction : notnull
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly HOHDPLDONAJ<DLMHCPGAPLL> ODKNGAAOEGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly TAction EPLOLGABFPJ;

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x199CE10", Offset = "0x199B810", VA = "0x18199CE10")]
	public EHOJFGIPNKJ(HOHDPLDONAJ<DLMHCPGAPLL> JIHMJMCIFOI, TAction FCCCPABHDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
internal static class OAHFCBOOIGG
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3E69F00", Offset = "0x3E68900", VA = "0x183E69F00")]
	public static EHOJFGIPNKJ<TAction> KDBDJPAJKDJ<TAction>(HOHDPLDONAJ<DLMHCPGAPLL> JIHMJMCIFOI, TAction FCCCPABHDPG) where TAction : notnull
	{
		return default(EHOJFGIPNKJ<TAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class IJIKKCJODED<TRoot, TDeps> : BMLIMCAGNIH where TRoot : notnull where TDeps : notnull, HLNJDFLPDFI.MGMNGBIPOPN<TRoot>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct IHIOJAHEIPP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<object?, DDLDMBFFDDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public IJIKKCJODED<TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public LAKDBINPNIP action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public bool clearBufferedRpcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private TaskAwaiter<FEENKEDBOAD<object?, DDLDMBFFDDA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x52ECC80", Offset = "0x52EB680", VA = "0x1852ECC80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x52ECFC0", Offset = "0x52EB9C0", VA = "0x1852ECFC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly TDeps KLALHCJBOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly TRoot OCJAEDFNDEL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public HOHDPLDONAJ<DLMHCPGAPLL> LHMDPJLLDNL
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		[CompilerGenerated]
		get
		{
			return default(HOHDPLDONAJ<DLMHCPGAPLL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x30F90A0", Offset = "0x30F7AA0", VA = "0x1830F90A0")]
	public IJIKKCJODED(TDeps KPEJCAGFLDG, TRoot FAIGKPPBFHA, HOHDPLDONAJ<DLMHCPGAPLL> EJNGNNODNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF80", Offset = "0x52EE980", VA = "0x1852EFF80", Slot = "4")]
	[AsyncStateMachine(typeof(IJIKKCJODED<, >.IHIOJAHEIPP))]
	public Task<FEENKEDBOAD<object, DDLDMBFFDDA>> JDIGHGLHMJP(LAKDBINPNIP FCCCPABHDPG, bool HGJNBDAKLCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class HLNJDFLPDFI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface MGMNGBIPOPN<TRoot> where TRoot : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task<FEENKEDBOAD<object, DDLDMBFFDDA>> JDIGHGLHMJP(TRoot FAIGKPPBFHA, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, LAKDBINPNIP FCCCPABHDPG, bool HGJNBDAKLCK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class LHKPEGNDGBH : HDIFNEDPOIF
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public delegate void KILDFFDEOPO(HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<DIHEINFKHHL> DCCNHMEJDHI, HOHDPLDONAJ<MGHIDEJBICM> HGKDIFGCPAM);

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate void EOHMGEAIGDH(HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<DIHEINFKHHL> DCCNHMEJDHI, HOHDPLDONAJ<MGHIDEJBICM> HGKDIFGCPAM);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public delegate void IKIEHINIJKN(HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<IOBEEHHAIPN> DKOKOBIEBLC);

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly LHKPEGNDGBH FLGHCDNLMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly KILDFFDEOPO? FEEMGPNOFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly EOHMGEAIGDH? GLFMPPIOMLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IKIEHINIJKN? OLLEMBMGGNN;

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0xE09BE0", Offset = "0xE085E0", VA = "0x180E09BE0")]
	public LHKPEGNDGBH([Optional] KILDFFDEOPO? JIMJPONCLEG, [Optional] EOHMGEAIGDH? KIGBOKLFOIN, [Optional] IKIEHINIJKN? GFMCOGIDJEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x2B89530", Offset = "0x2B87F30", VA = "0x182B89530", Slot = "4")]
	public void OnEdgeDidAdd(HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<DIHEINFKHHL> DCCNHMEJDHI, HOHDPLDONAJ<MGHIDEJBICM> HGKDIFGCPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2B89550", Offset = "0x2B87F50", VA = "0x182B89550", Slot = "5")]
	public void OnEdgeWillRemove(HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<DIHEINFKHHL> DCCNHMEJDHI, HOHDPLDONAJ<MGHIDEJBICM> HGKDIFGCPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2B89510", Offset = "0x2B87F10", VA = "0x182B89510", Slot = "6")]
	public void ELELNCEMEBH(HOHDPLDONAJ<NJOGNKEOOCE> ABIELIKPOOO, HOHDPLDONAJ<IOBEEHHAIPN> DKOKOBIEBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
	public void OnFunctionDeclsRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
	public void OnObjectPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "11")]
	public void OnPlayerPropertiesRefreshed()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "12")]
	public void OnEditGraphDidPush()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "13")]
	public void OnEditGraphDidPop()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "8")]
	public void IIJJEPOAACA(HOHDPLDONAJ<ADKGNHDKCOC> PNAGKDODKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "9")]
	public void CGMLGLKFAIB(HOHDPLDONAJ<ADKGNHDKCOC> PNAGKDODKAN)
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
