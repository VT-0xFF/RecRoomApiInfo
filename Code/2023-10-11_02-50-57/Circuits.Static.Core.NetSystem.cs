using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct CBDLKKIKOHL<TPartialAction, TFullAction, TDeps> where TDeps : IMKOEAIDKNB.AMNHBLGNDFF<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] JNOKKGEGEHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int JNCHAKGKPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps FCPNPAIPIMN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EB90", Offset = "0x3D2D990", VA = "0x183D2EB90")]
	internal CBDLKKIKOHL(TPartialAction[] FPGEJFIKAKH, int EIPBCONGLKK, TDeps NIPJNEHNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EAE0", Offset = "0x3D2D8E0", VA = "0x183D2EAE0")]
	public static CBDLKKIKOHL<TPartialAction, TFullAction, TDeps> NPAOPBPEFCO(TDeps NIPJNEHNMFI)
	{
		return default(CBDLKKIKOHL<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IMKOEAIDKNB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface AMNHBLGNDFF<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CPNDGFKGCME([In] TPartialAction AKFKKEALFCD);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction FANBJPKIDCL(TPartialAction[] OHKMPDKPEMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23A91B0", Offset = "0x23A7FB0", VA = "0x1823A91B0")]
	public static HLJMMMGEILL<TFullAction> LGFCIMAFAAF<TFullAction, TPartialAction, TDeps>(this CBDLKKIKOHL<TPartialAction, TFullAction, TDeps> LNKCIHFCLHG, TPartialAction AKFKKEALFCD) where TDeps : AMNHBLGNDFF<TPartialAction, TFullAction>
	{
		return default(HLJMMMGEILL<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct OLALGKEHMOI<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : AHHHODNPCDB.DMGOMCONGDH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] PHMFAHMMMAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int IPIANGKJDAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps FCPNPAIPIMN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EB90", Offset = "0x3D2D990", VA = "0x183D2EB90")]
	internal OLALGKEHMOI(TPartialSnapshot[] HAPEEMPEFJE, int ODOGMHJFNCL, TDeps NIPJNEHNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EAE0", Offset = "0x3D2D8E0", VA = "0x183D2EAE0")]
	public static OLALGKEHMOI<TPartialSnapshot, TFullSnapshot, TDeps> NPAOPBPEFCO(TDeps NIPJNEHNMFI)
	{
		return default(OLALGKEHMOI<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class AHHHODNPCDB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DMGOMCONGDH<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int HGOPOIDNNCN([In] TPartialSnapshot HCGEJOGLILO);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot LAPKHEJCAJE(TPartialSnapshot[] KGMELAPFILA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29B0D30", Offset = "0x29AFB30", VA = "0x1829B0D30")]
	public static HLJMMMGEILL<TFullSnapshot> LGFCIMAFAAF<TFullSnapshot, TPartialSnapshot, TDeps>(this OLALGKEHMOI<TPartialSnapshot, TFullSnapshot, TDeps> LNKCIHFCLHG, TPartialSnapshot HCGEJOGLILO) where TDeps : DMGOMCONGDH<TPartialSnapshot, TFullSnapshot>
	{
		return default(HLJMMMGEILL<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29B0BE0", Offset = "0x29AF9E0", VA = "0x1829B0BE0")]
	public static bool IGJMPJFCDHP<TPartialSnapshot, TFullSnapshot, TDeps>(this OLALGKEHMOI<TPartialSnapshot, TFullSnapshot, TDeps> LNKCIHFCLHG, TPartialSnapshot HCGEJOGLILO) where TDeps : DMGOMCONGDH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HDNNDCIOEKL : HJEACDGALLJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1C31CE0", Offset = "0x1C30AE0", VA = "0x181C31CE0", Slot = "7")]
	public override string FIDCKDNNLBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1C31D10", Offset = "0x1C30B10", VA = "0x181C31D10")]
	public HDNNDCIOEKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class AMGHHEKHGNL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : BHKFCFJBHIN.CMPLGNJFMGD<TAction, TNetSys> where TReceiverDeps : BHKFCFJBHIN.NGKGJMHDFAB<TMActor, TAction, TReceiver> where TRootDeps : BHKFCFJBHIN.HEKHILOPEGI<TMRequest, TMActor, TAction, TRoot> where TDeps : BHKFCFJBHIN.DIDLFFAPAIB<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface CBDNIBBIPJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IHOMHFIKMFL([In] IHFDHMKEEAA<object, BENEMAACKKC> EKOLPKLNMBD);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LJMPOBDKJKO();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IHFDHMKEEAA<object, BENEMAACKKC> LILMIKFDDIM();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void PBOLBKOMEJC(Exception AOBBDNCEPBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class GECHJKICOCF : CBDNIBBIPJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<IHFDHMKEEAA<object, BENEMAACKKC>> MNAPMCLEAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<IHFDHMKEEAA<object, IABAFDHJPAP>> AJDOPBAHPMB;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x34A40C0", Offset = "0x34A2EC0", VA = "0x1834A40C0")]
		private GECHJKICOCF(TaskCompletionSource<IHFDHMKEEAA<object, BENEMAACKKC>> LKHHMKEMOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x305A3E0", Offset = "0x30591E0", VA = "0x18305A3E0")]
		public static GECHJKICOCF NPAOPBPEFCO(TaskCompletionSource<IHFDHMKEEAA<object, BENEMAACKKC>> LKHHMKEMOPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x34A3B40", Offset = "0x34A2940", VA = "0x1834A3B40")]
		public void IHOMHFIKMFL([In] IHFDHMKEEAA<object, BENEMAACKKC> EKOLPKLNMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x34A3E80", Offset = "0x34A2C80", VA = "0x1834A3E80", Slot = "5")]
		public void LJMPOBDKJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x34A3CF0", Offset = "0x34A2AF0", VA = "0x1834A3CF0", Slot = "6")]
		public IHFDHMKEEAA<object, BENEMAACKKC> LILMIKFDDIM()
		{
			return default(IHFDHMKEEAA<object, BENEMAACKKC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x34A3F60", Offset = "0x34A2D60", VA = "0x1834A3F60", Slot = "7")]
		public void PBOLBKOMEJC(Exception AOBBDNCEPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3083650", Offset = "0x3082450", VA = "0x183083650", Slot = "4")]
		private void ACAEECIPJOF([In] IHFDHMKEEAA<object, BENEMAACKKC> EKOLPKLNMBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class IMBGAIMKMBH : CBDNIBBIPJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<IHFDHMKEEAA<object, BENEMAACKKC>> MNAPMCLEAIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private IHFDHMKEEAA<object, BENEMAACKKC> PGNLGEKPJJA;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x763A40", Offset = "0x762840", VA = "0x180763A40")]
		private IMBGAIMKMBH(TaskCompletionSource<IHFDHMKEEAA<object, BENEMAACKKC>> LKHHMKEMOPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x305A3E0", Offset = "0x30591E0", VA = "0x18305A3E0")]
		public static IMBGAIMKMBH NPAOPBPEFCO(TaskCompletionSource<IHFDHMKEEAA<object, BENEMAACKKC>> LKHHMKEMOPL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x33D9510", Offset = "0x33D8310", VA = "0x1833D9510")]
		public void IHOMHFIKMFL([In] IHFDHMKEEAA<object, BENEMAACKKC> EKOLPKLNMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3690E40", Offset = "0x368FC40", VA = "0x183690E40", Slot = "5")]
		public void LJMPOBDKJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x955D30", Offset = "0x954B30", VA = "0x180955D30", Slot = "6")]
		public IHFDHMKEEAA<object, BENEMAACKKC> LILMIKFDDIM()
		{
			return default(IHFDHMKEEAA<object, BENEMAACKKC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3690F00", Offset = "0x368FD00", VA = "0x183690F00", Slot = "7")]
		public void PBOLBKOMEJC(Exception AOBBDNCEPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3083650", Offset = "0x3082450", VA = "0x183083650", Slot = "4")]
		private void ACAEECIPJOF([In] IHFDHMKEEAA<object, BENEMAACKKC> EKOLPKLNMBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class EOGMBPCCLMN : CBDNIBBIPJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<IHFDHMKEEAA<object, BENEMAACKKC>> AJDOPBAHPMB;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3083A20", Offset = "0x3082820", VA = "0x183083A20")]
		private EOGMBPCCLMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x30838D0", Offset = "0x30826D0", VA = "0x1830838D0")]
		public static EOGMBPCCLMN NPAOPBPEFCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3083740", Offset = "0x3082540", VA = "0x183083740")]
		public void IHOMHFIKMFL([In] IHFDHMKEEAA<object, BENEMAACKKC> EKOLPKLNMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		public void LJMPOBDKJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3083810", Offset = "0x3082610", VA = "0x183083810", Slot = "6")]
		public IHFDHMKEEAA<object, BENEMAACKKC> LILMIKFDDIM()
		{
			return default(IHFDHMKEEAA<object, BENEMAACKKC>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		public void PBOLBKOMEJC(Exception AOBBDNCEPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3083650", Offset = "0x3082450", VA = "0x183083650", Slot = "4")]
		private void ACAEECIPJOF([In] IHFDHMKEEAA<object, BENEMAACKKC> EKOLPKLNMBD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class PHEIFOOOCHA : CBDNIBBIPJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IHFDHMKEEAA<object, BENEMAACKKC> PGNLGEKPJJA;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x76E9D0", Offset = "0x76D7D0", VA = "0x18076E9D0")]
		private PHEIFOOOCHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x30838D0", Offset = "0x30826D0", VA = "0x1830838D0")]
		public static PHEIFOOOCHA NPAOPBPEFCO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3C60B70", Offset = "0x3C5F970", VA = "0x183C60B70")]
		public void IHOMHFIKMFL([In] IHFDHMKEEAA<object, BENEMAACKKC> EKOLPKLNMBD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "5")]
		public void LJMPOBDKJKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xA8D850", Offset = "0xA8C650", VA = "0x180A8D850", Slot = "6")]
		public IHFDHMKEEAA<object, BENEMAACKKC> LILMIKFDDIM()
		{
			return default(IHFDHMKEEAA<object, BENEMAACKKC>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x762EE0", Offset = "0x761CE0", VA = "0x180762EE0", Slot = "7")]
		public void PBOLBKOMEJC(Exception AOBBDNCEPBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3083650", Offset = "0x3082450", VA = "0x183083650", Slot = "4")]
		private void ACAEECIPJOF([In] IHFDHMKEEAA<object, BENEMAACKKC> EKOLPKLNMBD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct FNEFIDANNFA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<IHFDHMKEEAA<object, BENEMAACKKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::AMGHHEKHGNL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JJOPOCFIJLE<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<IHFDHMKEEAA<object, BENEMAACKKC>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<IHFDHMKEEAA<object, BENEMAACKKC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x34091B0", Offset = "0x3407FB0", VA = "0x1834091B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3409680", Offset = "0x3408480", VA = "0x183409680", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct IGOLPLNCDHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<IHFDHMKEEAA<object, BENEMAACKKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::AMGHHEKHGNL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JJOPOCFIJLE<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<IHFDHMKEEAA<object, BENEMAACKKC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3659AD0", Offset = "0x36588D0", VA = "0x183659AD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x365A350", Offset = "0x3659150", VA = "0x18365A350", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GOJCIGNADEN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<IHFDHMKEEAA<object, BENEMAACKKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::AMGHHEKHGNL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public JJOPOCFIJLE<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JJOPOCFIJLE<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<IHFDHMKEEAA<object, BENEMAACKKC>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x34E0780", Offset = "0x34DF580", VA = "0x1834E0780", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x34E0B50", Offset = "0x34DF950", VA = "0x1834E0B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct GIFEIEIMOOC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<IHFDHMKEEAA<object, BENEMAACKKC>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::AMGHHEKHGNL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public JJOPOCFIJLE<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public JJOPOCFIJLE<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private CBDNIBBIPJH <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x34BAA30", Offset = "0x34B9830", VA = "0x1834BAA30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x34BB660", Offset = "0x34BA460", VA = "0x1834BB660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct PALFGDAPMPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::AMGHHEKHGNL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public TNetSys receiverNetSys;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public TReceiver receiver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public CBDNIBBIPJH completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private CBDNIBBIPJH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<IHFDHMKEEAA<object, BENEMAACKKC>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3DC5DC0", Offset = "0x3DC4BC0", VA = "0x183DC5DC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3DC9A80", Offset = "0x3DC8880", VA = "0x183DC9A80", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps FCPNPAIPIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<JJOPOCFIJLE<TMRequest>, TaskCompletionSource<IHFDHMKEEAA<object, BENEMAACKKC>>> GAPFCKFHDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private OEMGHCKOLCL<TMRequest> HGJAGOCJBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int JENFIAABPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task DMCBFIBBAOI;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps FEDKOOCBCLA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3523560", Offset = "0x3522360", VA = "0x183523560")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps IILEEMGCGAD
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3524180", Offset = "0x3522F80", VA = "0x183524180")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps PPKJIFGABGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3523BE0", Offset = "0x35229E0", VA = "0x183523BE0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KKOIGMCAJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10092D0", Offset = "0x10080D0", VA = "0x1810092D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10092E0", Offset = "0x10080E0", VA = "0x1810092E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool KAOGDGGJJMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B1F7A0", Offset = "0x1B1E5A0", VA = "0x181B1F7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1B1FA80", Offset = "0x1B1E880", VA = "0x181B1FA80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HHPPEHPALLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x761620", Offset = "0x760420", VA = "0x180761620")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3524E60", Offset = "0x3523C60", VA = "0x183524E60")]
	public AMGHHEKHGNL(TDeps NIPJNEHNMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3524200", Offset = "0x3523000", VA = "0x183524200")]
	public Task<IHFDHMKEEAA<object, BENEMAACKKC>> MNNLLDJIMMP(TRoot JKEBPOPHOPF, TNetSys MIPOMBBGPCH, JJOPOCFIJLE<TMActor> NPLAPBCLCFM, TAction HMHDIIODGFG, bool ONKGDBCMHLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3524520", Offset = "0x3523320", VA = "0x183524520")]
	[AsyncStateMachine(typeof(global::AMGHHEKHGNL<, , , , , , , , , >.FNEFIDANNFA))]
	private Task<IHFDHMKEEAA<object, BENEMAACKKC>> MNNLLDJIMMP(TRoot JKEBPOPHOPF, JJOPOCFIJLE<TMActor> NPLAPBCLCFM, TAction HMHDIIODGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3524020", Offset = "0x3522E20", VA = "0x183524020")]
	[AsyncStateMachine(typeof(global::AMGHHEKHGNL<, , , , , , , , , >.IGOLPLNCDHE))]
	private Task<IHFDHMKEEAA<object, BENEMAACKKC>> KPHLGNDNOOJ(TRoot JKEBPOPHOPF, JJOPOCFIJLE<TMActor> NPLAPBCLCFM, TAction[] OKAKIDANIAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3523A20", Offset = "0x3522820", VA = "0x183523A20")]
	[AsyncStateMachine(typeof(global::AMGHHEKHGNL<, , , , , , , , , >.GOJCIGNADEN))]
	public Task<IHFDHMKEEAA<object, BENEMAACKKC>> GILBJKAPIBJ(TRoot JKEBPOPHOPF, TNetSys JIAFMDOIINM, TReceiver ACKIIDNLPEH, JJOPOCFIJLE<TMActor> NPLAPBCLCFM, JJOPOCFIJLE<TMRequest> NCLNGNKCOBO, TAction HMHDIIODGFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3523720", Offset = "0x3522520", VA = "0x183523720")]
	[AsyncStateMachine(typeof(global::AMGHHEKHGNL<, , , , , , , , , >.GIFEIEIMOOC))]
	private Task<IHFDHMKEEAA<object, BENEMAACKKC>> FPFLFOEHHCI(TRoot JKEBPOPHOPF, TNetSys JIAFMDOIINM, TReceiver ACKIIDNLPEH, JJOPOCFIJLE<TMActor> NPLAPBCLCFM, JJOPOCFIJLE<TMRequest> NCLNGNKCOBO, TAction HMHDIIODGFG, Task HGLNANMGFEK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3523D70", Offset = "0x3522B70", VA = "0x183523D70")]
	[AsyncStateMachine(typeof(global::AMGHHEKHGNL<, , , , , , , , , >.PALFGDAPMPN))]
	private Task HIMPGFKOKEN(TRoot JKEBPOPHOPF, TNetSys JIAFMDOIINM, TReceiver ACKIIDNLPEH, TAction HMHDIIODGFG, CBDNIBBIPJH PDGFHBPFAMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3522F00", Offset = "0x3521D00", VA = "0x183522F00")]
	private void CACOPLEKFII(TRoot JKEBPOPHOPF, TNetSys JIAFMDOIINM, TReceiver ACKIIDNLPEH, JJOPOCFIJLE<TMActor> NPLAPBCLCFM, TAction HMHDIIODGFG, bool JGHCJCCJGKF, bool LBFHDJAINOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BHKFCFJBHIN
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface CMPLGNJFMGD<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JBJHPGGEOHO(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction NPOHLDDCALA(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction GPABGNNJHGD(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> DKGDNKPNFPE(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] NFPGJEIMHKM(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG, int JOIIAFPMPHM);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JGMINCDKNIP(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DCGJJFABPLF(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool MDEEDGCKNHG(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool DBJNEFIPIFH(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool DFJFDBCGBGB(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool HECKGLPJLBD(TNetSys FEFGEMMIDHA, TAction HMHDIIODGFG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface DIDLFFAPAIB<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps FEDKOOCBCLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps PPKJIFGABGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps IILEEMGCGAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface NGKGJMHDFAB<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JJOPOCFIJLE<TMActor> JJGJAJKDGKN(TReceiver ACKIIDNLPEH);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<IHFDHMKEEAA<object, BENEMAACKKC>> GILBJKAPIBJ(TReceiver ACKIIDNLPEH, TAction HMHDIIODGFG);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] DIDGPGDPOHK(TReceiver ACKIIDNLPEH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface HEKHILOPEGI<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GPBBAKGJMMD(TRoot JKEBPOPHOPF);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int COLDBHMGOHM(TRoot JKEBPOPHOPF);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int BCCCCMDFLFL(TRoot JKEBPOPHOPF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JNKCKHOKACG(TRoot JKEBPOPHOPF);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DNOBIPNELGA(TRoot JKEBPOPHOPF);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task MNNLLDJIMMP(TRoot JKEBPOPHOPF, JJOPOCFIJLE<TMActor> NPLAPBCLCFM, JJOPOCFIJLE<TMRequest> NCLNGNKCOBO, TAction HMHDIIODGFG, bool EHKEOKNMPID = true);
	}
}
namespace Cpp2IlInjected;

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
