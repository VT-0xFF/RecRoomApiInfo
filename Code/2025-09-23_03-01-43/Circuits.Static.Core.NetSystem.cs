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
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
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
		[Cpp2IlInjected.Address(RVA = "0x2B78990", Offset = "0x2B76F90", VA = "0x182B78990")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HGOBCNOHHOA : MMOOADNOMBF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B78960", Offset = "0x2B76F60", VA = "0x182B78960", Slot = "7")]
	public override string GAEFJPMCOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B78900", Offset = "0x2B76F00", VA = "0x182B78900")]
	private HGOBCNOHHOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2B78910", Offset = "0x2B76F10", VA = "0x182B78910")]
	public static HGOBCNOHHOA CPNHECDILPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GPNKENAJNNP<TPartialAction, TPartialActionId, TFullAction, TDeps> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull where TDeps : notnull, GMCLLMLEGAB.FOJLJAIELDE<TPartialAction, TPartialActionId, TFullAction>
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BBIHNCCDCML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private readonly TPartialAction?[] GHNOCFLGMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private int OPLDEBEKAAI;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x10379A0", Offset = "0x1035FA0", VA = "0x1810379A0")]
		private BBIHNCCDCML(TPartialAction[] LDLNLNMMJFJ, int KGPOGCGKIHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A09DC0", Offset = "0x6A083C0", VA = "0x186A09DC0")]
		public static GPNKENAJNNP<TPartialAction, TPartialActionId, TFullAction, TDeps>.BBIHNCCDCML CPNHECDILPK(int JJLCMPKDMAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A0A0E0", Offset = "0x6A086E0", VA = "0x186A0A0E0")]
		public GAKPFAEKJAN<TFullAction> IBBJPLDDPAA(TPartialAction EJFICFKJOMK, TDeps NBGHBGMICNM)
		{
			return default(GAKPFAEKJAN<TFullAction>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private Dictionary<TPartialActionId, BBIHNCCDCML>? DMANAFMHAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private TDeps EHPINPNKKID;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private Dictionary<TPartialActionId, BBIHNCCDCML> HMADBAMDPNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5109E70", Offset = "0x5108470", VA = "0x185109E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x510AEB0", Offset = "0x51094B0", VA = "0x18510AEB0")]
	private GPNKENAJNNP(Dictionary<TPartialActionId, BBIHNCCDCML>? KAJLGDECLPL, TDeps NBGHBGMICNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5109F50", Offset = "0x5108550", VA = "0x185109F50")]
	public static GPNKENAJNNP<TPartialAction, TPartialActionId, TFullAction, TDeps> CPNHECDILPK(TDeps NBGHBGMICNM)
	{
		return default(GPNKENAJNNP<TPartialAction, TPartialActionId, TFullAction, TDeps>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x510A7D0", Offset = "0x5108DD0", VA = "0x18510A7D0")]
	public CKPAOGHIJHA<GAKPFAEKJAN<TFullAction>, HCKLGFJODKO> IBBJPLDDPAA(TPartialAction EJFICFKJOMK)
	{
		return default(CKPAOGHIJHA<GAKPFAEKJAN<TFullAction>, HCKLGFJODKO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x510AE00", Offset = "0x5109400", VA = "0x18510AE00")]
	public void MGGKLOCJECI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class GMCLLMLEGAB
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public interface FOJLJAIELDE<TPartialAction, out TPartialActionId, out TFullAction> where TPartialAction : notnull where TPartialActionId : notnull where TFullAction : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BCJPAPMKJGP([In] TPartialAction EJFICFKJOMK);

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int OJMHALJFEAN([In] TPartialAction EJFICFKJOMK);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TPartialActionId AKFDJGNINNA([In] TPartialAction EJFICFKJOMK);

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TFullAction HNCLKHPDIPN(TPartialAction[] IIEILFOEEHF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct KIDOLMLGHGL<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : FHHMPONOHMG.NEGBAFAKCPD<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	internal TPartialSnapshot[] DKPLKMEAJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	internal int GHHBAODBPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	internal TDeps EHPINPNKKID;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x567A280", Offset = "0x5678880", VA = "0x18567A280")]
	internal KIDOLMLGHGL(TPartialSnapshot[] BKLAMFPFKAI, int NBNJOJMHGKJ, TDeps NBGHBGMICNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x567A1D0", Offset = "0x56787D0", VA = "0x18567A1D0")]
	public static KIDOLMLGHGL<TPartialSnapshot, TFullSnapshot, TDeps> CPNHECDILPK(TDeps NBGHBGMICNM)
	{
		return default(KIDOLMLGHGL<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class FHHMPONOHMG
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface NEGBAFAKCPD<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LNGFECICKJC([In] TPartialSnapshot PGMMIHFOOMP);

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot IPJBHNDFLIP(TPartialSnapshot[] IMGPECLHEDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1270", Offset = "0x3DBF870", VA = "0x183DC1270")]
	public static GAKPFAEKJAN<TFullSnapshot> IBBJPLDDPAA<TFullSnapshot, TPartialSnapshot, TDeps>(this KIDOLMLGHGL<TPartialSnapshot, TFullSnapshot, TDeps> JNMMMBJNOND, TPartialSnapshot PGMMIHFOOMP) where TDeps : NEGBAFAKCPD<TPartialSnapshot, TFullSnapshot>
	{
		return default(GAKPFAEKJAN<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3DC1620", Offset = "0x3DBFC20", VA = "0x183DC1620")]
	public static bool OFJJDCICFKF<TPartialSnapshot, TFullSnapshot, TDeps>(this KIDOLMLGHGL<TPartialSnapshot, TFullSnapshot, TDeps> JNMMMBJNOND, TPartialSnapshot PGMMIHFOOMP) where TDeps : NEGBAFAKCPD<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public sealed class ABLMHJDNEIA : MMOOADNOMBF
{
	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x2B788D0", Offset = "0x2B76ED0", VA = "0x182B788D0", Slot = "7")]
	public override string GAEFJPMCOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x2B78900", Offset = "0x2B76F00", VA = "0x182B78900")]
	public ABLMHJDNEIA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public sealed class FMIKDPEJFFM<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FIALGKODHLN.LCMBIHMJOMM<TAction, TNetSys> where TReceiverDeps : FIALGKODHLN.IOPBFLBAGIP<TAction, TReceiver> where TRootDeps : FIALGKODHLN.FHCOPNFILFJ<TAction, TRoot> where TDeps : FIALGKODHLN.HBFAKLAGGFA<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private interface FBOGGFAMPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AOICDMDNEEK([In] CKPAOGHIJHA<object, HCKLGFJODKO> FAKHJBCPGHO);

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		CKPAOGHIJHA<object, HCKLGFJODKO> KAOJHDIEGKH();
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private sealed class FHAAHLPIDGE : FBOGGFAMPMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly List<CKPAOGHIJHA<object, EHNKGHFFBGH>> GIMAAEFCPAF;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x4FFD850", Offset = "0x4FFBE50", VA = "0x184FFD850")]
		public static FHAAHLPIDGE CPNHECDILPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4FFD750", Offset = "0x4FFBD50", VA = "0x184FFD750")]
		public void AOICDMDNEEK([In] CKPAOGHIJHA<object, HCKLGFJODKO> FAKHJBCPGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4FFD910", Offset = "0x4FFBF10", VA = "0x184FFD910", Slot = "5")]
		public CKPAOGHIJHA<object, HCKLGFJODKO> KAOJHDIEGKH()
		{
			return default(CKPAOGHIJHA<object, HCKLGFJODKO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4FFDB40", Offset = "0x4FFC140", VA = "0x184FFDB40")]
		public FHAAHLPIDGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4FFDB20", Offset = "0x4FFC120", VA = "0x184FFDB20", Slot = "4")]
		private void NAMLHNAHLIM([In] CKPAOGHIJHA<object, HCKLGFJODKO> FAKHJBCPGHO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private sealed class JMEFHJFGEGA : FBOGGFAMPMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private CKPAOGHIJHA<object, HCKLGFJODKO> KHKAAMBLFDN;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4FFD850", Offset = "0x4FFBE50", VA = "0x184FFD850")]
		public static JMEFHJFGEGA CPNHECDILPK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x273B760", Offset = "0x2739D60", VA = "0x18273B760")]
		public void AOICDMDNEEK([In] CKPAOGHIJHA<object, HCKLGFJODKO> FAKHJBCPGHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xECC1B0", Offset = "0xECA7B0", VA = "0x180ECC1B0", Slot = "5")]
		public CKPAOGHIJHA<object, HCKLGFJODKO> KAOJHDIEGKH()
		{
			return default(CKPAOGHIJHA<object, HCKLGFJODKO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public JMEFHJFGEGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4FFDB20", Offset = "0x4FFC120", VA = "0x184FFDB20", Slot = "4")]
		private void NAMLHNAHLIM([In] CKPAOGHIJHA<object, HCKLGFJODKO> FAKHJBCPGHO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MGFFPCJPFFC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<object, HCKLGFJODKO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public FMIKDPEJFFM<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AIOJMGEOJFK<CKBMIONDKJJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private TaskAwaiter<CKPAOGHIJHA<object, HCKLGFJODKO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x5A03360", Offset = "0x5A01960", VA = "0x185A03360", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5A03610", Offset = "0x5A01C10", VA = "0x185A03610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HKAOIEOCNLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<object, HCKLGFJODKO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public FMIKDPEJFFM<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AIOJMGEOJFK<CKBMIONDKJJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private TaskAwaiter<CKPAOGHIJHA<object, HCKLGFJODKO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x516C030", Offset = "0x516A630", VA = "0x18516C030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x516C470", Offset = "0x516AA70", VA = "0x18516C470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[CompilerGenerated]
	private struct GDAIPHDMMOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<object, HCKLGFJODKO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public FMIKDPEJFFM<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AIOJMGEOJFK<CKBMIONDKJJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private TaskAwaiter<CKPAOGHIJHA<object, HCKLGFJODKO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x50E4780", Offset = "0x50E2D80", VA = "0x1850E4780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x50E4BB0", Offset = "0x50E31B0", VA = "0x1850E4BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private struct LAAPBGPIMJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public AsyncTaskMethodBuilder<CKPAOGHIJHA<object, HCKLGFJODKO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public FMIKDPEJFFM<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AIOJMGEOJFK<CKBMIONDKJJ> senderId;

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
		private FBOGGFAMPMI <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x57B5E10", Offset = "0x57B4410", VA = "0x1857B5E10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x57B75F0", Offset = "0x57B5BF0", VA = "0x1857B75F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private struct EABKENPJNKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public FMIKDPEJFFM<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FBOGGFAMPMI completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private FBOGGFAMPMI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private TaskAwaiter<CKPAOGHIJHA<object?, HCKLGFJODKO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4AF0380", Offset = "0x4AEE980", VA = "0x184AF0380", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4AF5E10", Offset = "0x4AF4410", VA = "0x184AF5E10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private struct LNLJGJKABDA : IAsyncStateMachine
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
		public FMIKDPEJFFM<TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public AIOJMGEOJFK<CKBMIONDKJJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x57E3090", Offset = "0x57E1690", VA = "0x1857E3090", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x57E34C0", Offset = "0x57E1AC0", VA = "0x1857E34C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly TDeps EHPINPNKKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private bool IDFJBCGJMPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private int CDOGMCJIBGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private Task PPHKFGMHHHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private int AOFHAPAEEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private int KPCGPPKCPBB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TActionDeps EALMKOCLKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x5022AE0", Offset = "0x50210E0", VA = "0x185022AE0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TRootDeps OEDHGPHHFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x5022B10", Offset = "0x5021110", VA = "0x185022B10")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private TReceiverDeps BNDAGLNKIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x50231C0", Offset = "0x50217C0", VA = "0x1850231C0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool IPMPPGIKHBD
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xB82BB0", Offset = "0xB811B0", VA = "0x180B82BB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xB82BA0", Offset = "0xB811A0", VA = "0x180B82BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JKOKCLCANOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int FIDAPDLNDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int FKNCFGBOLOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xC582A0", Offset = "0xC568A0", VA = "0x180C582A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x50235D0", Offset = "0x5021BD0", VA = "0x1850235D0")]
	public FMIKDPEJFFM(TDeps NBGHBGMICNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5022800", Offset = "0x5020E00", VA = "0x185022800")]
	public Task<CKPAOGHIJHA<object, HCKLGFJODKO>> DKOGDCBNOAB(TRoot BOCNDANOLJJ, TNetSys JLDDLIKCFFK, AIOJMGEOJFK<CKBMIONDKJJ> KLCPNOJDGDA, TAction PMBBLAOPHON, bool IOKFGJFNCKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x50226A0", Offset = "0x5020CA0", VA = "0x1850226A0")]
	[AsyncStateMachine(typeof(FMIKDPEJFFM<, , , , , , , >.MGFFPCJPFFC))]
	private Task<CKPAOGHIJHA<object, HCKLGFJODKO>> DKOGDCBNOAB(TRoot BOCNDANOLJJ, AIOJMGEOJFK<CKBMIONDKJJ> KLCPNOJDGDA, TAction PMBBLAOPHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x50231F0", Offset = "0x50217F0", VA = "0x1850231F0")]
	[AsyncStateMachine(typeof(FMIKDPEJFFM<, , , , , , , >.HKAOIEOCNLI))]
	private Task<CKPAOGHIJHA<object, HCKLGFJODKO>> NPBIDKNLJBM(TRoot BOCNDANOLJJ, AIOJMGEOJFK<CKBMIONDKJJ> KLCPNOJDGDA, TAction[] LHJMGFMLGMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5022B40", Offset = "0x5021140", VA = "0x185022B40")]
	[AsyncStateMachine(typeof(FMIKDPEJFFM<, , , , , , , >.GDAIPHDMMOI))]
	public Task<CKPAOGHIJHA<object, HCKLGFJODKO>> HLPMFHDAFPI(TRoot BOCNDANOLJJ, TNetSys CENMKCNFHAM, TReceiver BOBOBLMDHCP, AIOJMGEOJFK<CKBMIONDKJJ> KLCPNOJDGDA, TAction PMBBLAOPHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x50223D0", Offset = "0x50209D0", VA = "0x1850223D0")]
	[AsyncStateMachine(typeof(FMIKDPEJFFM<, , , , , , , >.LAAPBGPIMJA))]
	private Task<CKPAOGHIJHA<object, HCKLGFJODKO>> BBOFIOCODHO(TRoot BOCNDANOLJJ, TNetSys CENMKCNFHAM, TReceiver BOBOBLMDHCP, AIOJMGEOJFK<CKBMIONDKJJ> KLCPNOJDGDA, TAction PMBBLAOPHON, Task ACNPDBNHGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5022550", Offset = "0x5020B50", VA = "0x185022550")]
	[AsyncStateMachine(typeof(FMIKDPEJFFM<, , , , , , , >.EABKENPJNKE))]
	private Task BGJDFOGIBAK(TRoot BOCNDANOLJJ, TNetSys CENMKCNFHAM, TReceiver BOBOBLMDHCP, TAction PMBBLAOPHON, FBOGGFAMPMI KJEFJLLJPLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5023350", Offset = "0x5021950", VA = "0x185023350")]
	private void NPKDNPPJDNP(TReceiver BOBOBLMDHCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5022DF0", Offset = "0x50213F0", VA = "0x185022DF0")]
	private void KEIEHPAJLJN(TRoot BOCNDANOLJJ, TNetSys CENMKCNFHAM, TReceiver BOBOBLMDHCP, AIOJMGEOJFK<CKBMIONDKJJ> KLCPNOJDGDA, TAction PMBBLAOPHON, bool GNLFCCKIHNO, bool JCEKBOMIEAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5022CB0", Offset = "0x50212B0", VA = "0x185022CB0")]
	[AsyncStateMachine(typeof(FMIKDPEJFFM<, , , , , , , >.LNLJGJKABDA))]
	public Task IOBGHHGIFAK(TRoot BOCNDANOLJJ, TNetSys CENMKCNFHAM, AIOJMGEOJFK<CKBMIONDKJJ> KLCPNOJDGDA, TAction[] FAIOIGHEMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x50233C0", Offset = "0x50219C0", VA = "0x1850233C0")]
	private (TAction, int) PPICJDGNJDH(TRoot BOCNDANOLJJ, TNetSys LBCBBKJABHJ, TAction PMBBLAOPHON)
	{
		return default((TAction, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public static class FIALGKODHLN
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface LCMBIHMJOMM<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MKFJIFCCHMK(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction GGBICNPBOIG(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction BOINCMFOPEM(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> OAJJKMEDMJG(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] KLINFHCPGOC(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON, int NBNNGBCLNMD);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool MKJAJGOFIOO(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool OKEJAMOIKLD(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool NOPGIFKLDBL(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool FEMJGHLLMJK(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool MFFJOIHPAGO(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool OCHFEHDGPIN(TNetSys LKLGCCANBKL, TAction PMBBLAOPHON);
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface HBFAKLAGGFA<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TActionDeps EALMKOCLKPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		TReceiverDeps BNDAGLNKIKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		TRootDeps OEDHGPHHFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface IOPBFLBAGIP<TAction, TReceiver> where TAction : notnull where TReceiver : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		AIOJMGEOJFK<CKBMIONDKJJ> HGLBPBFPIBL(TReceiver BOBOBLMDHCP);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HNFDBHFLBOD(TReceiver BOBOBLMDHCP);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<CKPAOGHIJHA<object, HCKLGFJODKO>> HLPMFHDAFPI(TReceiver BOBOBLMDHCP, TAction PMBBLAOPHON);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		TAction[] KACGNDGBOEC(TReceiver BOBOBLMDHCP);
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface FHCOPNFILFJ<TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int DJMMKPDPPHK(TRoot BOCNDANOLJJ);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int JBNDPHJEDCI(TRoot BOCNDANOLJJ);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int LCEIFIMEKOA(TRoot BOCNDANOLJJ);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int FJPPJNAJFFP(TRoot BOCNDANOLJJ);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void IIEKNHABJBP(TRoot BOCNDANOLJJ);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool NEEIEELDPGP(TRoot BOCNDANOLJJ, AIOJMGEOJFK<CKBMIONDKJJ> KLCPNOJDGDA, TAction[] LHJMGFMLGMH);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool OGOMGDLGPJN(TRoot BOCNDANOLJJ, int DKPEABDNEMB);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "7")]
		Task<CKPAOGHIJHA<object, HCKLGFJODKO>> DKOGDCBNOAB(TRoot BOCNDANOLJJ, AIOJMGEOJFK<CKBMIONDKJJ> KLCPNOJDGDA, TAction PMBBLAOPHON, bool PECIAGHAGNN = true);
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
