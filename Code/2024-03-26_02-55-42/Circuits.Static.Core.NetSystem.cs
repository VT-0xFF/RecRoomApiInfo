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
public struct HKGHNKNFBHF<TPartialAction, TFullAction, TDeps> where TDeps : CJMGOJIKHLB.JOMMKENCBLN<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] FHBBMCJBOIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int ODLPLDMOJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps ECGBFCNDIAL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x386E400", Offset = "0x386D800", VA = "0x18386E400")]
	internal HKGHNKNFBHF(TPartialAction[] CJLGNOINNBN, int EDLFKKPBIHL, TDeps IGMHAFBOHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x386E350", Offset = "0x386D750", VA = "0x18386E350")]
	public static HKGHNKNFBHF<TPartialAction, TFullAction, TDeps> HGJFOBLHCKL(TDeps IGMHAFBOHAM)
	{
		return default(HKGHNKNFBHF<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CJMGOJIKHLB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface JOMMKENCBLN<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FLOGMABBOJN([In] TPartialAction JFFPBGPLCNH);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction MBGBAGLEGEA(TPartialAction[] CEJGACAHINI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26237A0", Offset = "0x2622BA0", VA = "0x1826237A0")]
	public static LDJGEBAMNJP<TFullAction> CFEPMBDLPHI<TFullAction, TPartialAction, TDeps>(this HKGHNKNFBHF<TPartialAction, TFullAction, TDeps> MEEBIDIALDO, TPartialAction JFFPBGPLCNH) where TDeps : JOMMKENCBLN<TPartialAction, TFullAction>
	{
		return default(LDJGEBAMNJP<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KIMJEHMJDMB<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : PONFGFLELMB.CCMLOEMNHAH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] CKADOINAEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int AEMLIIIBBJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps ECGBFCNDIAL;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x386E400", Offset = "0x386D800", VA = "0x18386E400")]
	internal KIMJEHMJDMB(TPartialSnapshot[] CPGFGKLLOAG, int IEHKHAPJBHG, TDeps IGMHAFBOHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x386E350", Offset = "0x386D750", VA = "0x18386E350")]
	public static KIMJEHMJDMB<TPartialSnapshot, TFullSnapshot, TDeps> HGJFOBLHCKL(TDeps IGMHAFBOHAM)
	{
		return default(KIMJEHMJDMB<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class PONFGFLELMB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface CCMLOEMNHAH<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PJJPBHOJKBF([In] TPartialSnapshot BLPBKJHNEIG);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot OIHKODJMMPN(TPartialSnapshot[] BNMKOGAKDIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2962140", Offset = "0x2961540", VA = "0x182962140")]
	public static LDJGEBAMNJP<TFullSnapshot> CFEPMBDLPHI<TFullSnapshot, TPartialSnapshot, TDeps>(this KIMJEHMJDMB<TPartialSnapshot, TFullSnapshot, TDeps> MEEBIDIALDO, TPartialSnapshot BLPBKJHNEIG) where TDeps : CCMLOEMNHAH<TPartialSnapshot, TFullSnapshot>
	{
		return default(LDJGEBAMNJP<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29622A0", Offset = "0x29616A0", VA = "0x1829622A0")]
	public static bool KGMKDJANNDG<TPartialSnapshot, TFullSnapshot, TDeps>(this KIMJEHMJDMB<TPartialSnapshot, TFullSnapshot, TDeps> MEEBIDIALDO, TPartialSnapshot BLPBKJHNEIG) where TDeps : CCMLOEMNHAH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class KDADNDIBJEG : LPMKDKJGPIA
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1B10", Offset = "0x1DF0F10", VA = "0x181DF1B10", Slot = "7")]
	public override string PEMDIIHBGJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DF1B40", Offset = "0x1DF0F40", VA = "0x181DF1B40")]
	public KDADNDIBJEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DBFFNHIJHAF<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : PFGNPGOLPOF.HGANJBJCAMM<TAction, TNetSys> where TReceiverDeps : PFGNPGOLPOF.HHAGGEFICPH<TMActor, TAction, TReceiver> where TRootDeps : PFGNPGOLPOF.IDLKHFGEPOP<TMRequest, TMActor, TAction, TRoot> where TDeps : PFGNPGOLPOF.PIMILHGPNOE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface AJKAMKCOCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NNFCMJCPPKD([In] OJIJNKCPBAD<object, DMJBJKNNALA> FEADNEEPDLO);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AFHGAHHOLDN();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		OJIJNKCPBAD<object, DMJBJKNNALA> DKDHMBEDFNJ();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KNMHFEIAHOO(Exception DAAIKNOAPFE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class CHCJGLCOFCN : AJKAMKCOCLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<OJIJNKCPBAD<object, DMJBJKNNALA>> BGMIIBLMDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<OJIJNKCPBAD<object, BJDMIMOJLDG>> CEAHDCGHAPA;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4AED520", Offset = "0x4AEC920", VA = "0x184AED520")]
		private CHCJGLCOFCN(TaskCompletionSource<OJIJNKCPBAD<object, DMJBJKNNALA>> IHMOPGFBBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x37C9700", Offset = "0x37C8B00", VA = "0x1837C9700")]
		public static CHCJGLCOFCN HGJFOBLHCKL(TaskCompletionSource<OJIJNKCPBAD<object, DMJBJKNNALA>> IHMOPGFBBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4AED320", Offset = "0x4AEC720", VA = "0x184AED320")]
		public void NNFCMJCPPKD([In] OJIJNKCPBAD<object, DMJBJKNNALA> FEADNEEPDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4AED020", Offset = "0x4AEC420", VA = "0x184AED020", Slot = "5")]
		public void AFHGAHHOLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4AED1B0", Offset = "0x4AEC5B0", VA = "0x184AED1B0", Slot = "6")]
		public OJIJNKCPBAD<object, DMJBJKNNALA> DKDHMBEDFNJ()
		{
			return default(OJIJNKCPBAD<object, DMJBJKNNALA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x4AED260", Offset = "0x4AEC660", VA = "0x184AED260", Slot = "7")]
		public void KNMHFEIAHOO(Exception DAAIKNOAPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37DB5C0", Offset = "0x37DA9C0", VA = "0x1837DB5C0", Slot = "4")]
		private void OHJFOFPBLNF([In] OJIJNKCPBAD<object, DMJBJKNNALA> FEADNEEPDLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class JJIMDIIBODN : AJKAMKCOCLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<OJIJNKCPBAD<object, DMJBJKNNALA>> BGMIIBLMDGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private OJIJNKCPBAD<object, DMJBJKNNALA> EIHCKEDJIKI;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7CA5D0", Offset = "0x7C99D0", VA = "0x1807CA5D0")]
		private JJIMDIIBODN(TaskCompletionSource<OJIJNKCPBAD<object, DMJBJKNNALA>> IHMOPGFBBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x37C9700", Offset = "0x37C8B00", VA = "0x1837C9700")]
		public static JJIMDIIBODN HGJFOBLHCKL(TaskCompletionSource<OJIJNKCPBAD<object, DMJBJKNNALA>> IHMOPGFBBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x36AE320", Offset = "0x36AD720", VA = "0x1836AE320")]
		public void NNFCMJCPPKD([In] OJIJNKCPBAD<object, DMJBJKNNALA> FEADNEEPDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x3BA4930", Offset = "0x3BA3D30", VA = "0x183BA4930", Slot = "5")]
		public void AFHGAHHOLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAE23A0", Offset = "0xAE17A0", VA = "0x180AE23A0", Slot = "6")]
		public OJIJNKCPBAD<object, DMJBJKNNALA> DKDHMBEDFNJ()
		{
			return default(OJIJNKCPBAD<object, DMJBJKNNALA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3BA49F0", Offset = "0x3BA3DF0", VA = "0x183BA49F0", Slot = "7")]
		public void KNMHFEIAHOO(Exception DAAIKNOAPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x37DB5C0", Offset = "0x37DA9C0", VA = "0x1837DB5C0", Slot = "4")]
		private void OHJFOFPBLNF([In] OJIJNKCPBAD<object, DMJBJKNNALA> FEADNEEPDLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class GMOGCLLNPMN : AJKAMKCOCLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<OJIJNKCPBAD<object, DMJBJKNNALA>> CEAHDCGHAPA;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x37E7F40", Offset = "0x37E7340", VA = "0x1837E7F40")]
		private GMOGCLLNPMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x37DB460", Offset = "0x37DA860", VA = "0x1837DB460")]
		public static GMOGCLLNPMN HGJFOBLHCKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x37E7D10", Offset = "0x37E7110", VA = "0x1837E7D10")]
		public void NNFCMJCPPKD([In] OJIJNKCPBAD<object, DMJBJKNNALA> FEADNEEPDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		public void AFHGAHHOLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x37E7BB0", Offset = "0x37E6FB0", VA = "0x1837E7BB0", Slot = "6")]
		public OJIJNKCPBAD<object, DMJBJKNNALA> DKDHMBEDFNJ()
		{
			return default(OJIJNKCPBAD<object, DMJBJKNNALA>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x37E7CC0", Offset = "0x37E70C0", VA = "0x1837E7CC0", Slot = "7")]
		[OAKOKOJNDPP("This may be terminal and should probably do more than discarding the exception.")]
		public void KNMHFEIAHOO(Exception DAAIKNOAPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x37DB5C0", Offset = "0x37DA9C0", VA = "0x1837DB5C0", Slot = "4")]
		private void OHJFOFPBLNF([In] OJIJNKCPBAD<object, DMJBJKNNALA> FEADNEEPDLO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class GLCIBLFGJGK : AJKAMKCOCLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private OJIJNKCPBAD<object, DMJBJKNNALA> EIHCKEDJIKI;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		private GLCIBLFGJGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x37DB460", Offset = "0x37DA860", VA = "0x1837DB460")]
		public static GLCIBLFGJGK HGJFOBLHCKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x15334E0", Offset = "0x15328E0", VA = "0x1815334E0")]
		public void NNFCMJCPPKD([In] OJIJNKCPBAD<object, DMJBJKNNALA> FEADNEEPDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BD300", Offset = "0x7BC700", VA = "0x1807BD300", Slot = "5")]
		public void AFHGAHHOLDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8516A0", Offset = "0x850AA0", VA = "0x1808516A0", Slot = "6")]
		public OJIJNKCPBAD<object, DMJBJKNNALA> DKDHMBEDFNJ()
		{
			return default(OJIJNKCPBAD<object, DMJBJKNNALA>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x37DB520", Offset = "0x37DA920", VA = "0x1837DB520", Slot = "7")]
		[OAKOKOJNDPP("This may be terminal and should probably do more than discarding the exception.")]
		public void KNMHFEIAHOO(Exception DAAIKNOAPFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37DB5C0", Offset = "0x37DA9C0", VA = "0x1837DB5C0", Slot = "4")]
		private void OHJFOFPBLNF([In] OJIJNKCPBAD<object, DMJBJKNNALA> FEADNEEPDLO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct GAOKJMOEJFF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::DBFFNHIJHAF<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public CEECNPFCENP<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<OJIJNKCPBAD<object, DMJBJKNNALA>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3799C10", Offset = "0x3799010", VA = "0x183799C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x379A6C0", Offset = "0x3799AC0", VA = "0x18379A6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PPEMFLMHILD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::DBFFNHIJHAF<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public CEECNPFCENP<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x41CA2A0", Offset = "0x41C96A0", VA = "0x1841CA2A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x41CA6E0", Offset = "0x41C9AE0", VA = "0x1841CA6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MKCBHKHHPFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::DBFFNHIJHAF<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public CEECNPFCENP<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CEECNPFCENP<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3F099A0", Offset = "0x3F08DA0", VA = "0x183F099A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3F0A050", Offset = "0x3F09450", VA = "0x183F0A050", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct JDPPEDEFONG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<OJIJNKCPBAD<object, DMJBJKNNALA>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::DBFFNHIJHAF<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public CEECNPFCENP<TMActor> senderId;

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
		public CEECNPFCENP<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private AJKAMKCOCLM <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3B59140", Offset = "0x3B58540", VA = "0x183B59140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3B5AA40", Offset = "0x3B59E40", VA = "0x183B5AA40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct NFENKJDKAJB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::DBFFNHIJHAF<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public AJKAMKCOCLM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private AJKAMKCOCLM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<OJIJNKCPBAD<object, DMJBJKNNALA>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3FA64D0", Offset = "0x3FA58D0", VA = "0x183FA64D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA1F0", Offset = "0x3FA95F0", VA = "0x183FAA1F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps ECGBFCNDIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<CEECNPFCENP<TMRequest>, TaskCompletionSource<OJIJNKCPBAD<object, DMJBJKNNALA>>> LBADMIEFFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private ECOMKNNIKHA<TMRequest> AJOOAPKLNKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int APCDOOPKFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task BAGIDGLCNFG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps LDHNJCNBCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x50E29C0", Offset = "0x50E1DC0", VA = "0x1850E29C0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps EHJPBJMLEPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x50E4480", Offset = "0x50E3880", VA = "0x1850E4480")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps KCIEJIGCABH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x50E4400", Offset = "0x50E3800", VA = "0x1850E4400")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool NKCIJPIEBPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDE9350", Offset = "0xDE8750", VA = "0x180DE9350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11CCCB0", Offset = "0x11CC0B0", VA = "0x1811CCCB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HCJKJAHBJKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDECB90", Offset = "0xDEBF90", VA = "0x180DECB90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1CBD900", Offset = "0x1CBCD00", VA = "0x181CBD900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KCNLKPNKADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C6760", Offset = "0x7C5B60", VA = "0x1807C6760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x50E4760", Offset = "0x50E3B60", VA = "0x1850E4760")]
	public DBFFNHIJHAF(TDeps IGMHAFBOHAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x50E3150", Offset = "0x50E2550", VA = "0x1850E3150")]
	public Task<OJIJNKCPBAD<object, DMJBJKNNALA>> FHBGOKOMFMP(TRoot BEOJJJNJFFJ, TNetSys AMIDAHBEHNP, CEECNPFCENP<TMActor> OJFHGENBFGL, TAction PNAPELFIIEJ, bool CKPPLEAGEAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x50E3920", Offset = "0x50E2D20", VA = "0x1850E3920")]
	[AsyncStateMachine(typeof(global::DBFFNHIJHAF<, , , , , , , , , >.GAOKJMOEJFF))]
	private Task<OJIJNKCPBAD<object, DMJBJKNNALA>> FHBGOKOMFMP(TRoot BEOJJJNJFFJ, CEECNPFCENP<TMActor> OJFHGENBFGL, TAction PNAPELFIIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x50E4250", Offset = "0x50E3650", VA = "0x1850E4250")]
	[AsyncStateMachine(typeof(global::DBFFNHIJHAF<, , , , , , , , , >.PPEMFLMHILD))]
	private Task<OJIJNKCPBAD<object, DMJBJKNNALA>> HGIGKFEKNDG(TRoot BEOJJJNJFFJ, CEECNPFCENP<TMActor> OJFHGENBFGL, TAction[] NMFCBCGLEJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x50E2E80", Offset = "0x50E2280", VA = "0x1850E2E80")]
	[AsyncStateMachine(typeof(global::DBFFNHIJHAF<, , , , , , , , , >.MKCBHKHHPFB))]
	public Task<OJIJNKCPBAD<object, DMJBJKNNALA>> ENKNHNGIKLG(TRoot BEOJJJNJFFJ, TNetSys GPGEDBLGNPL, TReceiver MDOBDPHHONK, CEECNPFCENP<TMActor> OJFHGENBFGL, CEECNPFCENP<TMRequest> NEDDKOPOKPN, TAction PNAPELFIIEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x50E2B80", Offset = "0x50E1F80", VA = "0x1850E2B80")]
	[AsyncStateMachine(typeof(global::DBFFNHIJHAF<, , , , , , , , , >.JDPPEDEFONG))]
	private Task<OJIJNKCPBAD<object, DMJBJKNNALA>> EINPLOIBJJK(TRoot BEOJJJNJFFJ, TNetSys GPGEDBLGNPL, TReceiver MDOBDPHHONK, CEECNPFCENP<TMActor> OJFHGENBFGL, CEECNPFCENP<TMRequest> NEDDKOPOKPN, TAction PNAPELFIIEJ, Task CIDIBBKCJCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x50E44B0", Offset = "0x50E38B0", VA = "0x1850E44B0")]
	[AsyncStateMachine(typeof(global::DBFFNHIJHAF<, , , , , , , , , >.NFENKJDKAJB))]
	private Task OCAGDLJPMAB(TRoot BEOJJJNJFFJ, TNetSys GPGEDBLGNPL, TReceiver MDOBDPHHONK, TAction PNAPELFIIEJ, AJKAMKCOCLM PEHPLGIFMAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x50E3E10", Offset = "0x50E3210", VA = "0x1850E3E10")]
	private void GFIAIKGNOHL(TRoot BEOJJJNJFFJ, TNetSys GPGEDBLGNPL, TReceiver MDOBDPHHONK, CEECNPFCENP<TMActor> OJFHGENBFGL, TAction PNAPELFIIEJ, bool CBCEFDPEMNI, bool AADBMOAGFIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PFGNPGOLPOF
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface HGANJBJCAMM<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GEIAHHMGKHA(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction GHHNBLBBLHB(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction IIOCBCPAMNI(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> OJPAEJELGCB(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] BAEFMLLMION(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ, int IJGEGHCDOHB);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool CBGAOLHFDMN(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CNFECDNIDCG(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool GHNANKEBGBA(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool DEJOGDJAJNI(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PJIFHNOBGDD(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool LKAPIBNPNDH(TNetSys DHCPEELKIPN, TAction PNAPELFIIEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface PIMILHGPNOE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps LDHNJCNBCGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps KCIEJIGCABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps EHJPBJMLEPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface HHAGGEFICPH<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		CEECNPFCENP<TMActor> IFKEMEILGEI(TReceiver MDOBDPHHONK);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<OJIJNKCPBAD<object, DMJBJKNNALA>> ENKNHNGIKLG(TReceiver MDOBDPHHONK, TAction PNAPELFIIEJ);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] POECGCCOJMN(TReceiver MDOBDPHHONK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IDLKHFGEPOP<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IBCCLFECPIJ(TRoot BEOJJJNJFFJ);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int HJMFBABEDGD(TRoot BEOJJJNJFFJ);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int JAGDDEFIKJP(TRoot BEOJJJNJFFJ);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int PMMLPDNNIGD(TRoot BEOJJJNJFFJ);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JNGPJHKAOAA(TRoot BEOJJJNJFFJ);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task FHBGOKOMFMP(TRoot BEOJJJNJFFJ, CEECNPFCENP<TMActor> OJFHGENBFGL, CEECNPFCENP<TMRequest> NEDDKOPOKPN, TAction PNAPELFIIEJ, bool NDGKHGOEOIA = true);
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
