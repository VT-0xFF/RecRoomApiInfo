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
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2B7A9F0", Offset = "0x2B793F0", VA = "0x182B7A9F0")]
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
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
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
public class JAMNOKPJCJD : ICFOIJPFHAE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A9B0", Offset = "0x2B793B0", VA = "0x182B7A9B0", Slot = "7")]
	public override string NGBNCIGPFCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A9E0", Offset = "0x2B793E0", VA = "0x182B7A9E0")]
	private JAMNOKPJCJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A960", Offset = "0x2B79360", VA = "0x182B7A960")]
	public static JAMNOKPJCJD KDBDJPAJKDJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GFIOMNAGIJO<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, MCFGDNBGDDN.FMBEFDDDMDH<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NJAJBDMGMGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] KOKOICCDNIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int MHCGHHDHAMM;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x103FB90", Offset = "0x103E590", VA = "0x18103FB90")]
		private NJAJBDMGMGO(TPartialAction[] NDCFCPPAAAI, int EFAGJIJBKGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5A5FF30", Offset = "0x5A5E930", VA = "0x185A5FF30")]
		public static GFIOMNAGIJO<TPartialAction, TPartialActionId, TFullAction, TDeps>.NJAJBDMGMGO KDBDJPAJKDJ(int IGHNNBCJFFC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5A5FBF0", Offset = "0x5A5E5F0", VA = "0x185A5FBF0")]
		public DBCJPOJBOOF<TFullAction> DJLFIODPNEI(TPartialAction PCKHPJMCNPJ, TDeps KPEJCAGFLDG)
		{
			return default(DBCJPOJBOOF<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, NJAJBDMGMGO>? AEJDCNJLGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps KLALHCJBOKG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, NJAJBDMGMGO> GKJKHJHDIOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x51286E0", Offset = "0x51270E0", VA = "0x1851286E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5129660", Offset = "0x5128060", VA = "0x185129660")]
	private GFIOMNAGIJO(Dictionary<TPartialActionId, NJAJBDMGMGO>? PDGCNFBBJKJ, TDeps KPEJCAGFLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x51295B0", Offset = "0x5127FB0", VA = "0x1851295B0")]
	public static GFIOMNAGIJO<TPartialAction, TPartialActionId, TFullAction, TDeps> KDBDJPAJKDJ(TDeps KPEJCAGFLDG)
	{
		return default(GFIOMNAGIJO<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x51287C0", Offset = "0x51271C0", VA = "0x1851287C0")]
	public FEENKEDBOAD<DBCJPOJBOOF<TFullAction>, DDLDMBFFDDA> DJLFIODPNEI(TPartialAction PCKHPJMCNPJ)
	{
		return default(FEENKEDBOAD<DBCJPOJBOOF<TFullAction>, DDLDMBFFDDA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5128630", Offset = "0x5127030", VA = "0x185128630")]
	public void CABOEHDFDFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class MCFGDNBGDDN
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface FMBEFDDDMDH<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GCKNOJDFDJK([In] TPartialAction PCKHPJMCNPJ);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int GHNNAOPEOKM([In] TPartialAction PCKHPJMCNPJ);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId CCDKKGKGNLN([In] TPartialAction PCKHPJMCNPJ);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction JJHHHEHEFNN(TPartialAction[] OGCAIDFMIKK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BKIDBJEKILL<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : DCJCFNMIIHI.NLKFOGPFOOD<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] NOIKCGIPOJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int NAHPIFFOLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps KLALHCJBOKG;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x67761A0", Offset = "0x6774BA0", VA = "0x1867761A0")]
	internal BKIDBJEKILL(TPartialSnapshot[] CJGKDANMCIH, int GPNCBDCELHN, TDeps KPEJCAGFLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x67760D0", Offset = "0x6774AD0", VA = "0x1867760D0")]
	public static BKIDBJEKILL<TPartialSnapshot, TFullSnapshot, TDeps> KDBDJPAJKDJ(TDeps KPEJCAGFLDG)
	{
		return default(BKIDBJEKILL<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class DCJCFNMIIHI
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface NLKFOGPFOOD<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PPLLFPIEIKN([In] TPartialSnapshot CLECCPILALA);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot PMLOCKGBNMN(TPartialSnapshot[] GAGBHCEFCDP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD0B0", Offset = "0x3BCBAB0", VA = "0x183BCD0B0")]
	public static DBCJPOJBOOF<TFullSnapshot> DJLFIODPNEI<TFullSnapshot, TPartialSnapshot, TDeps>(this BKIDBJEKILL<TPartialSnapshot, TFullSnapshot, TDeps> DKGBCFDLMOI, TPartialSnapshot CLECCPILALA) where TDeps : NLKFOGPFOOD<TPartialSnapshot, TFullSnapshot>
	{
		return default(DBCJPOJBOOF<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3BCD460", Offset = "0x3BCBE60", VA = "0x183BCD460")]
	public static bool GLLGNHJCCOH<TPartialSnapshot, TFullSnapshot, TDeps>(this BKIDBJEKILL<TPartialSnapshot, TFullSnapshot, TDeps> DKGBCFDLMOI, TPartialSnapshot CLECCPILALA) where TDeps : NLKFOGPFOOD<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class OCAOCFCHPEL : ICFOIJPFHAE
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B7AA70", Offset = "0x2B79470", VA = "0x182B7AA70", Slot = "7")]
	public override string NGBNCIGPFCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B7A9E0", Offset = "0x2B793E0", VA = "0x182B7A9E0")]
	public OCAOCFCHPEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class IGDGMNGOELK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : IIGAKIFKCLP.JEPPMGHICLP<TAction, TNetSys> where TReceiverDeps : IIGAKIFKCLP.HBMHBDGGBED<TAction, TReceiver> where TRootDeps : IIGAKIFKCLP.POHCMDEJCHM<TAction, TRoot> where TDeps : IIGAKIFKCLP.KACJPEEEGBG<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface IEMPBOLGLEE
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CMLDGNLGCJD([In] FEENKEDBOAD<object, DDLDMBFFDDA> GGIKEMCHAAA);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		FEENKEDBOAD<object, DDLDMBFFDDA> FCDEDIHLONB();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class HDNCHKDGMNJ : IEMPBOLGLEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly List<FEENKEDBOAD<object, NKNFPHMKKGH>> KANCJDEMAAF;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5189F80", Offset = "0x5188980", VA = "0x185189F80")]
		public static HDNCHKDGMNJ KDBDJPAJKDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x51AA080", Offset = "0x51A8A80", VA = "0x1851AA080")]
		public void CMLDGNLGCJD([In] FEENKEDBOAD<object, DDLDMBFFDDA> GGIKEMCHAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x51AA280", Offset = "0x51A8C80", VA = "0x1851AA280", Slot = "5")]
		public FEENKEDBOAD<object, DDLDMBFFDDA> FCDEDIHLONB()
		{
			return default(FEENKEDBOAD<object, DDLDMBFFDDA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x51AA490", Offset = "0x51A8E90", VA = "0x1851AA490")]
		public HDNCHKDGMNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x500E280", Offset = "0x500CC80", VA = "0x18500E280", Slot = "4")]
		private void MGMDEHFCLEL([In] FEENKEDBOAD<object, DDLDMBFFDDA> GGIKEMCHAAA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class HABJOKNGEFE : IEMPBOLGLEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private FEENKEDBOAD<object, DDLDMBFFDDA> CLJBHFDMLFH;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5189F80", Offset = "0x5188980", VA = "0x185189F80")]
		public static HABJOKNGEFE KDBDJPAJKDJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2730030", Offset = "0x272EA30", VA = "0x182730030")]
		public void CMLDGNLGCJD([In] FEENKEDBOAD<object, DDLDMBFFDDA> GGIKEMCHAAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xED14F0", Offset = "0xECFEF0", VA = "0x180ED14F0", Slot = "5")]
		public FEENKEDBOAD<object, DDLDMBFFDDA> FCDEDIHLONB()
		{
			return default(FEENKEDBOAD<object, DDLDMBFFDDA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HABJOKNGEFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x500E280", Offset = "0x500CC80", VA = "0x18500E280", Slot = "4")]
		private void MGMDEHFCLEL([In] FEENKEDBOAD<object, DDLDMBFFDDA> GGIKEMCHAAA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct BHOLCDOMGPK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<object, DDLDMBFFDDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public IGDGMNGOELK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public HOHDPLDONAJ<DLMHCPGAPLL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter<FEENKEDBOAD<object, DDLDMBFFDDA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x676F880", Offset = "0x676E280", VA = "0x18676F880", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x676FE50", Offset = "0x676E850", VA = "0x18676FE50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct MENFMENKPCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<object, DDLDMBFFDDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public IGDGMNGOELK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public HOHDPLDONAJ<DLMHCPGAPLL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<FEENKEDBOAD<object, DDLDMBFFDDA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5936530", Offset = "0x5934F30", VA = "0x185936530", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5937260", Offset = "0x5935C60", VA = "0x185937260", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct IFJIDINMLMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<object, DDLDMBFFDDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public IGDGMNGOELK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public HOHDPLDONAJ<DLMHCPGAPLL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<FEENKEDBOAD<object, DDLDMBFFDDA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x52E1D20", Offset = "0x52E0720", VA = "0x1852E1D20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x52E20E0", Offset = "0x52E0AE0", VA = "0x1852E20E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct HIILJDOADNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<FEENKEDBOAD<object, DDLDMBFFDDA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public IGDGMNGOELK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public HOHDPLDONAJ<DLMHCPGAPLL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private IEMPBOLGLEE <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51B7F20", Offset = "0x51B6920", VA = "0x1851B7F20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x51B96D0", Offset = "0x51B80D0", VA = "0x1851B96D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct HCNMPPGHOPG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public IGDGMNGOELK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public IEMPBOLGLEE completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private IEMPBOLGLEE <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<FEENKEDBOAD<object?, DDLDMBFFDDA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5194780", Offset = "0x5193180", VA = "0x185194780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x519A180", Offset = "0x5198B80", VA = "0x18519A180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct HIHNPHPAKDO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public TAction[] snapshotActions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public IGDGMNGOELK<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public HOHDPLDONAJ<DLMHCPGAPLL> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x51B6660", Offset = "0x51B5060", VA = "0x1851B6660", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x51B7090", Offset = "0x51B5A90", VA = "0x1851B7090", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps KLALHCJBOKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool BEMMLKCABBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int FNHCLHEJNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Task HKCBEFGFPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int DMIPAODOJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private int GKEKJJDDDOJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps DDGEMLAKCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x52E4FD0", Offset = "0x52E39D0", VA = "0x1852E4FD0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps JFIGBCCAMOF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x52E45F0", Offset = "0x52E2FF0", VA = "0x1852E45F0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps GHOMHKBGCGG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x52E5530", Offset = "0x52E3F30", VA = "0x1852E5530")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IDIEFEGAIDB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA70", Offset = "0xB8A470", VA = "0x180B8BA70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA50", Offset = "0xB8A450", VA = "0x180B8BA50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JHBJMJKABNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xBAD7D0", Offset = "0xBAC1D0", VA = "0x180BAD7D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int MFBFOCNGPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xB0E380", Offset = "0xB0CD80", VA = "0x180B0E380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int MAMMIKFJHHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x52E56A0", Offset = "0x52E40A0", VA = "0x1852E56A0")]
	public IGDGMNGOELK(TDeps KPEJCAGFLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x52E4AE0", Offset = "0x52E34E0", VA = "0x1852E4AE0")]
	public Task<FEENKEDBOAD<object, DDLDMBFFDDA>> JDIGHGLHMJP(TRoot FAIGKPPBFHA, TNetSys FNKFJCFBOMB, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction FCCCPABHDPG, bool HGJNBDAKLCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x52E4980", Offset = "0x52E3380", VA = "0x1852E4980")]
	[AsyncStateMachine(typeof(IGDGMNGOELK<, , , , , , , >.BHOLCDOMGPK))]
	private Task<FEENKEDBOAD<object, DDLDMBFFDDA>> JDIGHGLHMJP(TRoot FAIGKPPBFHA, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction FCCCPABHDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x52E53D0", Offset = "0x52E3DD0", VA = "0x1852E53D0")]
	[AsyncStateMachine(typeof(IGDGMNGOELK<, , , , , , , >.MENFMENKPCF))]
	private Task<FEENKEDBOAD<object, DDLDMBFFDDA>> NHADOBHPHKO(TRoot FAIGKPPBFHA, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction[] AIJHDJPNLNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x52E4690", Offset = "0x52E3090", VA = "0x1852E4690")]
	[AsyncStateMachine(typeof(IGDGMNGOELK<, , , , , , , >.IFJIDINMLMN))]
	public Task<FEENKEDBOAD<object, DDLDMBFFDDA>> BJNOIEGMLCC(TRoot FAIGKPPBFHA, TNetSys OKJPEBONPFA, TReceiver DCNLFPCOIJG, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction FCCCPABHDPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x52E4800", Offset = "0x52E3200", VA = "0x1852E4800")]
	[AsyncStateMachine(typeof(IGDGMNGOELK<, , , , , , , >.HIILJDOADNA))]
	private Task<FEENKEDBOAD<object, DDLDMBFFDDA>> JBMIKCJMGGG(TRoot FAIGKPPBFHA, TNetSys OKJPEBONPFA, TReceiver DCNLFPCOIJG, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction FCCCPABHDPG, Task CLACHABAPNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x52E44A0", Offset = "0x52E2EA0", VA = "0x1852E44A0")]
	[AsyncStateMachine(typeof(IGDGMNGOELK<, , , , , , , >.HCNMPPGHOPG))]
	private Task AAJMMMPMAHA(TRoot FAIGKPPBFHA, TNetSys OKJPEBONPFA, TReceiver DCNLFPCOIJG, TAction FCCCPABHDPG, IEMPBOLGLEE NELJECJLMAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x52E4620", Offset = "0x52E3020", VA = "0x1852E4620")]
	private void ANKEMHBCEBM(TReceiver DCNLFPCOIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x52E5000", Offset = "0x52E3A00", VA = "0x1852E5000")]
	private void NALKPKELGOJ(TRoot FAIGKPPBFHA, TNetSys OKJPEBONPFA, TReceiver DCNLFPCOIJG, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction FCCCPABHDPG, bool NMHEAMMNDOH, bool FNOEFKEKMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x52E5560", Offset = "0x52E3F60", VA = "0x1852E5560")]
	[AsyncStateMachine(typeof(IGDGMNGOELK<, , , , , , , >.HIHNPHPAKDO))]
	public Task PNOOAPAKIFO(TRoot FAIGKPPBFHA, TNetSys OKJPEBONPFA, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction[] GEOJEEGMKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x52E4DC0", Offset = "0x52E37C0", VA = "0x1852E4DC0")]
	private (TAction, int) JDJPJBONAHL(TRoot FAIGKPPBFHA, TNetSys CHKCFPLGKKD, TAction FCCCPABHDPG)
	{
		return default((TAction, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class IIGAKIFKCLP
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface JEPPMGHICLP<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MMMPMAKBGOM(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction OGDDBIFDBAO(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction KAODKCKAGLN(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> BLFICKFBDDE(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] PLOEBJDOKHA(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG, int LCMCGOEFKBC);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OPDDHPBCGDB(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool FJHHPNCKPHI(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool AECDBBDMKNP(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool BAPDNNANCDK(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool AHDEKDBAFDA(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool ACFKECOKHBD(TNetSys JJKGNBHNOOC, TAction FCCCPABHDPG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface KACJPEEEGBG<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TActionDeps DDGEMLAKCFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TReceiverDeps GHOMHKBGCGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		TRootDeps JFIGBCCAMOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface HBMHBDGGBED<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		HOHDPLDONAJ<DLMHCPGAPLL> OHPMEFILDMG(TReceiver DCNLFPCOIJG);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EJKJIJBOMGF(TReceiver DCNLFPCOIJG);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<FEENKEDBOAD<object, DDLDMBFFDDA>> BJNOIEGMLCC(TReceiver DCNLFPCOIJG, TAction FCCCPABHDPG);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] NANACLLIKDH(TReceiver DCNLFPCOIJG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface POHCMDEJCHM<TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BHBEGOEFIKF(TRoot FAIGKPPBFHA);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int CIPMKDDFEJF(TRoot FAIGKPPBFHA);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int KPMBGGKEOIP(TRoot FAIGKPPBFHA);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int CELFIAFDAGO(TRoot FAIGKPPBFHA);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GFCEFKFOEMK(TRoot FAIGKPPBFHA);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool FPNIABOEMKL(TRoot FAIGKPPBFHA, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction[] AIJHDJPNLNM);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool KAIIJENCHLA(TRoot FAIGKPPBFHA, int LAGEKNGNKAO);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<FEENKEDBOAD<object, DDLDMBFFDDA>> JDIGHGLHMJP(TRoot FAIGKPPBFHA, HOHDPLDONAJ<DLMHCPGAPLL> KLADJKIHFLF, TAction FCCCPABHDPG, bool BIHGBIJPICD = true);
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
