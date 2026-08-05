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
public struct LCDHFFEMPIL<TPartialAction, TFullAction, TDeps> where TDeps : ABEGAJGMHGL.OPLFJMEGPEP<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] PBMCKNOGGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int GPAJHAFEGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps LPEEHBCIPOH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x36B8A20", Offset = "0x36B7220", VA = "0x1836B8A20")]
	internal LCDHFFEMPIL(TPartialAction[] HAGDJHOBGPK, int INBMLMMMPLD, TDeps JFHMOFHDJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x36B8970", Offset = "0x36B7170", VA = "0x1836B8970")]
	public static LCDHFFEMPIL<TPartialAction, TFullAction, TDeps> AKKFLOCCMNP(TDeps JFHMOFHDJOF)
	{
		return default(LCDHFFEMPIL<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ABEGAJGMHGL
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface OPLFJMEGPEP<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int JJCJMMKFOML([In] TPartialAction GLIIJNNPABI);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction DOMCEGGKMHA(TPartialAction[] LLIBKNAANIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B07C60", Offset = "0x2B06460", VA = "0x182B07C60")]
	public static JLEEOCGECPK<TFullAction> PFJOJAJIPBO<TFullAction, TPartialAction, TDeps>(this LCDHFFEMPIL<TPartialAction, TFullAction, TDeps> PIEBBHMNEOG, TPartialAction GLIIJNNPABI) where TDeps : OPLFJMEGPEP<TPartialAction, TFullAction>
	{
		return default(JLEEOCGECPK<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct IHOOPPDBILK<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : IALEEAEPEOE.HBJIJGBGCHN<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] BJBOGKKKOOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int LALAKPPNHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps LPEEHBCIPOH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x36B8A20", Offset = "0x36B7220", VA = "0x1836B8A20")]
	internal IHOOPPDBILK(TPartialSnapshot[] CCLGFKDIJOF, int LFKNCMELEJI, TDeps JFHMOFHDJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x36B8970", Offset = "0x36B7170", VA = "0x1836B8970")]
	public static IHOOPPDBILK<TPartialSnapshot, TFullSnapshot, TDeps> AKKFLOCCMNP(TDeps JFHMOFHDJOF)
	{
		return default(IHOOPPDBILK<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IALEEAEPEOE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HBJIJGBGCHN<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LDCFIFIFANN([In] TPartialSnapshot KFFJPJKDHFB);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot OHMOJHJCINJ(TPartialSnapshot[] ENBLNNAEMNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x24FF5F0", Offset = "0x24FDDF0", VA = "0x1824FF5F0")]
	public static JLEEOCGECPK<TFullSnapshot> PFJOJAJIPBO<TFullSnapshot, TPartialSnapshot, TDeps>(this IHOOPPDBILK<TPartialSnapshot, TFullSnapshot, TDeps> PIEBBHMNEOG, TPartialSnapshot KFFJPJKDHFB) where TDeps : HBJIJGBGCHN<TPartialSnapshot, TFullSnapshot>
	{
		return default(JLEEOCGECPK<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x24FF4A0", Offset = "0x24FDCA0", VA = "0x1824FF4A0")]
	public static bool CMKJLBNGFDJ<TPartialSnapshot, TFullSnapshot, TDeps>(this IHOOPPDBILK<TPartialSnapshot, TFullSnapshot, TDeps> PIEBBHMNEOG, TPartialSnapshot KFFJPJKDHFB) where TDeps : HBJIJGBGCHN<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class KGCODCCKKCN : IJJELFILJOP
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1CCFBB0", Offset = "0x1CCE3B0", VA = "0x181CCFBB0", Slot = "7")]
	public override string PJMGMONBGLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1CCFBE0", Offset = "0x1CCE3E0", VA = "0x181CCFBE0")]
	public KGCODCCKKCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FJHNCEEOJFL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : KOMEMKOANCL.PMLMJGJOPJO<TAction, TNetSys> where TReceiverDeps : KOMEMKOANCL.MPCKIPFFDGD<TMActor, TAction, TReceiver> where TRootDeps : KOMEMKOANCL.FDKOPCJBAIM<TMRequest, TMActor, TAction, TRoot> where TDeps : KOMEMKOANCL.CLNBGFBJEKP<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface OOILLAPDKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BILJCNIFHEM([In] LBFOJMHFNLD<object, AABCOILMPHO> MLABNLLFODC);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CHHKHCEEOOO();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		LBFOJMHFNLD<object, AABCOILMPHO> BCFKCACDNFD();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void BNMAPNFAFEN(Exception IOPFKNIOMEG);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class CEJKNJNPPPE : OOILLAPDKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<LBFOJMHFNLD<object, AABCOILMPHO>> BDFBANGALLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<LBFOJMHFNLD<object, NFLDLKGILAB>> EDCBIAIOHFJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x48F3840", Offset = "0x48F2040", VA = "0x1848F3840")]
		private CEJKNJNPPPE(TaskCompletionSource<LBFOJMHFNLD<object, AABCOILMPHO>> MJGKNEPNLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x345CE30", Offset = "0x345B630", VA = "0x18345CE30")]
		public static CEJKNJNPPPE AKKFLOCCMNP(TaskCompletionSource<LBFOJMHFNLD<object, AABCOILMPHO>> MJGKNEPNLPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x48F3420", Offset = "0x48F1C20", VA = "0x1848F3420")]
		public void BILJCNIFHEM([In] LBFOJMHFNLD<object, AABCOILMPHO> MLABNLLFODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x48F36C0", Offset = "0x48F1EC0", VA = "0x1848F36C0", Slot = "5")]
		public void CHHKHCEEOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x48F31C0", Offset = "0x48F19C0", VA = "0x1848F31C0", Slot = "6")]
		public LBFOJMHFNLD<object, AABCOILMPHO> BCFKCACDNFD()
		{
			return default(LBFOJMHFNLD<object, AABCOILMPHO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x48F3520", Offset = "0x48F1D20", VA = "0x1848F3520", Slot = "7")]
		public void BNMAPNFAFEN(Exception IOPFKNIOMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x38B03B0", Offset = "0x38AEBB0", VA = "0x1838B03B0", Slot = "4")]
		private void BLAMEHINAAH([In] LBFOJMHFNLD<object, AABCOILMPHO> MLABNLLFODC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class KGJMFCNJFLF : OOILLAPDKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<LBFOJMHFNLD<object, AABCOILMPHO>> BDFBANGALLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private LBFOJMHFNLD<object, AABCOILMPHO> HHKPMPOLMHB;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x775290", Offset = "0x773A90", VA = "0x180775290")]
		private KGJMFCNJFLF(TaskCompletionSource<LBFOJMHFNLD<object, AABCOILMPHO>> MJGKNEPNLPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x345CE30", Offset = "0x345B630", VA = "0x18345CE30")]
		public static KGJMFCNJFLF AKKFLOCCMNP(TaskCompletionSource<LBFOJMHFNLD<object, AABCOILMPHO>> MJGKNEPNLPB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x354FB00", Offset = "0x354E300", VA = "0x18354FB00")]
		public void BILJCNIFHEM([In] LBFOJMHFNLD<object, AABCOILMPHO> MLABNLLFODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x38F87F0", Offset = "0x38F6FF0", VA = "0x1838F87F0", Slot = "5")]
		public void CHHKHCEEOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9FDA30", Offset = "0x9FC230", VA = "0x1809FDA30", Slot = "6")]
		public LBFOJMHFNLD<object, AABCOILMPHO> BCFKCACDNFD()
		{
			return default(LBFOJMHFNLD<object, AABCOILMPHO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x38F8730", Offset = "0x38F6F30", VA = "0x1838F8730", Slot = "7")]
		public void BNMAPNFAFEN(Exception IOPFKNIOMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x38B03B0", Offset = "0x38AEBB0", VA = "0x1838B03B0", Slot = "4")]
		private void BLAMEHINAAH([In] LBFOJMHFNLD<object, AABCOILMPHO> MLABNLLFODC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class JMBEEHAPBDE : OOILLAPDKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<LBFOJMHFNLD<object, AABCOILMPHO>> EDCBIAIOHFJ;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x38B0470", Offset = "0x38AEC70", VA = "0x1838B0470")]
		private JMBEEHAPBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x38B0090", Offset = "0x38AE890", VA = "0x1838B0090")]
		public static JMBEEHAPBDE AKKFLOCCMNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x38B02E0", Offset = "0x38AEAE0", VA = "0x1838B02E0")]
		public void BILJCNIFHEM([In] LBFOJMHFNLD<object, AABCOILMPHO> MLABNLLFODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		public void CHHKHCEEOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x38B01B0", Offset = "0x38AE9B0", VA = "0x1838B01B0", Slot = "6")]
		public LBFOJMHFNLD<object, AABCOILMPHO> BCFKCACDNFD()
		{
			return default(LBFOJMHFNLD<object, AABCOILMPHO>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x38B03D0", Offset = "0x38AEBD0", VA = "0x1838B03D0", Slot = "7")]
		[FJDOMJOPJJA("This may be terminal and should probably do more than discarding the exception.")]
		public void BNMAPNFAFEN(Exception IOPFKNIOMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x38B03B0", Offset = "0x38AEBB0", VA = "0x1838B03B0", Slot = "4")]
		private void BLAMEHINAAH([In] LBFOJMHFNLD<object, AABCOILMPHO> MLABNLLFODC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class PBNGEOFKPGB : OOILLAPDKBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LBFOJMHFNLD<object, AABCOILMPHO> HHKPMPOLMHB;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		private PBNGEOFKPGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x38B0090", Offset = "0x38AE890", VA = "0x1838B0090")]
		public static PBNGEOFKPGB AKKFLOCCMNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3DB4A20", Offset = "0x3DB3220", VA = "0x183DB4A20")]
		public void BILJCNIFHEM([In] LBFOJMHFNLD<object, AABCOILMPHO> MLABNLLFODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x772200", Offset = "0x770A00", VA = "0x180772200", Slot = "5")]
		public void CHHKHCEEOOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xB2AA00", Offset = "0xB29200", VA = "0x180B2AA00", Slot = "6")]
		public LBFOJMHFNLD<object, AABCOILMPHO> BCFKCACDNFD()
		{
			return default(LBFOJMHFNLD<object, AABCOILMPHO>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3EE2F40", Offset = "0x3EE1740", VA = "0x183EE2F40", Slot = "7")]
		[FJDOMJOPJJA("This may be terminal and should probably do more than discarding the exception.")]
		public void BNMAPNFAFEN(Exception IOPFKNIOMEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x38B03B0", Offset = "0x38AEBB0", VA = "0x1838B03B0", Slot = "4")]
		private void BLAMEHINAAH([In] LBFOJMHFNLD<object, AABCOILMPHO> MLABNLLFODC)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct BNHDEKOHJMB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<LBFOJMHFNLD<object, AABCOILMPHO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::FJHNCEEOJFL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BIAFJNPKHBL<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<LBFOJMHFNLD<object, AABCOILMPHO>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<LBFOJMHFNLD<object, AABCOILMPHO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4606520", Offset = "0x4604D20", VA = "0x184606520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4606F60", Offset = "0x4605760", VA = "0x184606F60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LMAANKDABMN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<LBFOJMHFNLD<object, AABCOILMPHO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::FJHNCEEOJFL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BIAFJNPKHBL<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<LBFOJMHFNLD<object, AABCOILMPHO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3A6F850", Offset = "0x3A6E050", VA = "0x183A6F850", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3A6FD00", Offset = "0x3A6E500", VA = "0x183A6FD00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JNELGIELOCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<LBFOJMHFNLD<object, AABCOILMPHO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::FJHNCEEOJFL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public BIAFJNPKHBL<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public BIAFJNPKHBL<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<LBFOJMHFNLD<object, AABCOILMPHO>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x38B1FE0", Offset = "0x38B07E0", VA = "0x1838B1FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x38B2690", Offset = "0x38B0E90", VA = "0x1838B2690", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OFIJEJPPELO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<LBFOJMHFNLD<object, AABCOILMPHO>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::FJHNCEEOJFL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public BIAFJNPKHBL<TMActor> senderId;

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
		public BIAFJNPKHBL<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private OOILLAPDKBI <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3E0DEF0", Offset = "0x3E0C6F0", VA = "0x183E0DEF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3E0EAB0", Offset = "0x3E0D2B0", VA = "0x183E0EAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct NBINCJOFKJD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::FJHNCEEOJFL<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public OOILLAPDKBI completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private OOILLAPDKBI <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<LBFOJMHFNLD<object, AABCOILMPHO>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3CF1950", Offset = "0x3CF0150", VA = "0x183CF1950", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3CF5610", Offset = "0x3CF3E10", VA = "0x183CF5610", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps LPEEHBCIPOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<BIAFJNPKHBL<TMRequest>, TaskCompletionSource<LBFOJMHFNLD<object, AABCOILMPHO>>> PLHDHLNPOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private IGPCCHOFAAB<TMRequest> HEHAALINFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int MKDBPPDOEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task KFEHMPHDDFJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps EIDECFAODOG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x346A5B0", Offset = "0x3468DB0", VA = "0x18346A5B0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps ECKINDCKLJC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x346BF60", Offset = "0x346A760", VA = "0x18346BF60")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps LACLBLJLIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x346BFE0", Offset = "0x346A7E0", VA = "0x18346BFE0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool CNCJAMMLLEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10CF380", Offset = "0x10CDB80", VA = "0x1810CF380")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x10CF390", Offset = "0x10CDB90", VA = "0x1810CF390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool COGLILNJFCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1BBA7D0", Offset = "0x1BB8FD0", VA = "0x181BBA7D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1BBAAB0", Offset = "0x1BB92B0", VA = "0x181BBAAB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BMHBNIABBED
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7733B0", Offset = "0x771BB0", VA = "0x1807733B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x346C060", Offset = "0x346A860", VA = "0x18346C060")]
	public FJHNCEEOJFL(TDeps JFHMOFHDJOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x346B1C0", Offset = "0x34699C0", VA = "0x18346B1C0")]
	public Task<LBFOJMHFNLD<object, AABCOILMPHO>> MFJCJOEJHGF(TRoot PHEKGOFMNOB, TNetSys LONODELELOK, BIAFJNPKHBL<TMActor> MFBGJFAHOLK, TAction KJDOCFCKCJE, bool JHPDADAFFCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x346B4E0", Offset = "0x3469CE0", VA = "0x18346B4E0")]
	[AsyncStateMachine(typeof(global::FJHNCEEOJFL<, , , , , , , , , >.BNHDEKOHJMB))]
	private Task<LBFOJMHFNLD<object, AABCOILMPHO>> MFJCJOEJHGF(TRoot PHEKGOFMNOB, BIAFJNPKHBL<TMActor> MFBGJFAHOLK, TAction KJDOCFCKCJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x346AA50", Offset = "0x3469250", VA = "0x18346AA50")]
	[AsyncStateMachine(typeof(global::FJHNCEEOJFL<, , , , , , , , , >.LMAANKDABMN))]
	private Task<LBFOJMHFNLD<object, AABCOILMPHO>> JDPKMMHDFEN(TRoot PHEKGOFMNOB, BIAFJNPKHBL<TMActor> MFBGJFAHOLK, TAction[] BJCOMLCLKAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x346A3F0", Offset = "0x3468BF0", VA = "0x18346A3F0")]
	[AsyncStateMachine(typeof(global::FJHNCEEOJFL<, , , , , , , , , >.JNELGIELOCI))]
	public Task<LBFOJMHFNLD<object, AABCOILMPHO>> AHHLACMDHOC(TRoot PHEKGOFMNOB, TNetSys IOHDENDDMLJ, TReceiver ALHPLCFGAFB, BIAFJNPKHBL<TMActor> MFBGJFAHOLK, BIAFJNPKHBL<TMRequest> IBNIEKLBGGD, TAction KJDOCFCKCJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x346A770", Offset = "0x3468F70", VA = "0x18346A770")]
	[AsyncStateMachine(typeof(global::FJHNCEEOJFL<, , , , , , , , , >.OFIJEJPPELO))]
	private Task<LBFOJMHFNLD<object, AABCOILMPHO>> BFPOPEFOOPI(TRoot PHEKGOFMNOB, TNetSys IOHDENDDMLJ, TReceiver ALHPLCFGAFB, BIAFJNPKHBL<TMActor> MFBGJFAHOLK, BIAFJNPKHBL<TMRequest> IBNIEKLBGGD, TAction KJDOCFCKCJE, Task IPPFDJALDFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x346BCB0", Offset = "0x346A4B0", VA = "0x18346BCB0")]
	[AsyncStateMachine(typeof(global::FJHNCEEOJFL<, , , , , , , , , >.NBINCJOFKJD))]
	private Task MOOOEOBHCOK(TRoot PHEKGOFMNOB, TNetSys IOHDENDDMLJ, TReceiver ALHPLCFGAFB, TAction KJDOCFCKCJE, OOILLAPDKBI IGPEANGJPAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x346B640", Offset = "0x3469E40", VA = "0x18346B640")]
	private void MFKMMLADGPH(TRoot PHEKGOFMNOB, TNetSys IOHDENDDMLJ, TReceiver ALHPLCFGAFB, BIAFJNPKHBL<TMActor> MFBGJFAHOLK, TAction KJDOCFCKCJE, bool HAFGOGNEDGM, bool JOONJCOPPKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KOMEMKOANCL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface PMLMJGJOPJO<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int CHONOLKGDLA(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction COCJEKIOLNN(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction HBKPBKPKPCG(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> BFPAFFLIBCN(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] MIEMOFMJMJH(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE, int NEKLOMEODOH);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool JDNOCJKAEOF(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool DPADEJNFOIC(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LIIDOFDPEEJ(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool OEAFAIGGHHM(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool OOIKFDLMMLI(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool GGNAMINGBII(TNetSys KIBGBCJBFKO, TAction KJDOCFCKCJE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface CLNBGFBJEKP<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps EIDECFAODOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps LACLBLJLIFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps ECKINDCKLJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MPCKIPFFDGD<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BIAFJNPKHBL<TMActor> ILBIICFKHBP(TReceiver ALHPLCFGAFB);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<LBFOJMHFNLD<object, AABCOILMPHO>> AHHLACMDHOC(TReceiver ALHPLCFGAFB, TAction KJDOCFCKCJE);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] HAFNBMLJNFM(TReceiver ALHPLCFGAFB);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface FDKOPCJBAIM<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MENLLFNHHKI(TRoot PHEKGOFMNOB);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int GBDCADEJOIA(TRoot PHEKGOFMNOB);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int LFDBDFJIAPL(TRoot PHEKGOFMNOB);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int OCMJBJAMEMK(TRoot PHEKGOFMNOB);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CDNOAIPFPLK(TRoot PHEKGOFMNOB);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task MFJCJOEJHGF(TRoot PHEKGOFMNOB, BIAFJNPKHBL<TMActor> MFBGJFAHOLK, BIAFJNPKHBL<TMRequest> IBNIEKLBGGD, TAction KJDOCFCKCJE, bool DOMHDAMCFAB = true);
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
