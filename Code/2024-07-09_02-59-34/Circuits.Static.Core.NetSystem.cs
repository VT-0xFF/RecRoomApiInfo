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
public struct DBHFDDFANKO<TPartialAction, TFullAction, TDeps> where TDeps : IKLHJGLPADG.AFFAKDHDBGN<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] GGIDEDFGLIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int ALEHDIFPOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps PLLBOMGPHPP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x407C9E0", Offset = "0x407B5E0", VA = "0x18407C9E0")]
	internal DBHFDDFANKO(TPartialAction[] NDCNLMFKINK, int HCKBCMGEKIA, TDeps EIDBKEEIBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x407C980", Offset = "0x407B580", VA = "0x18407C980")]
	public static DBHFDDFANKO<TPartialAction, TFullAction, TDeps> FCDPFGJNKNI(TDeps EIDBKEEIBKK)
	{
		return default(DBHFDDFANKO<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IKLHJGLPADG
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface AFFAKDHDBGN<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PFDEKIBGEMK([In] TPartialAction BKPAMHNLFOB);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction AKGHPOLCIPH(TPartialAction[] ENINHHNNIPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B7E270", Offset = "0x2B7CE70", VA = "0x182B7E270")]
	public static FLLFKKECNDP<TFullAction> HAMGMNABIBF<TFullAction, TPartialAction, TDeps>(this DBHFDDFANKO<TPartialAction, TFullAction, TDeps> ENEDBNLKLJL, TPartialAction BKPAMHNLFOB) where TDeps : AFFAKDHDBGN<TPartialAction, TFullAction>
	{
		return default(FLLFKKECNDP<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct JBOGJACPOFH<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : CDFNFECOIID.JHHBEHCDPFA<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] GDCMIOBMBKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int IAMNONOHHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps PLLBOMGPHPP;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x407C9E0", Offset = "0x407B5E0", VA = "0x18407C9E0")]
	internal JBOGJACPOFH(TPartialSnapshot[] DNBFEPNODCD, int JALJPHHDBJL, TDeps EIDBKEEIBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x407C980", Offset = "0x407B580", VA = "0x18407C980")]
	public static JBOGJACPOFH<TPartialSnapshot, TFullSnapshot, TDeps> FCDPFGJNKNI(TDeps EIDBKEEIBKK)
	{
		return default(JBOGJACPOFH<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CDFNFECOIID
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JHHBEHCDPFA<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GBKHOFENNID([In] TPartialSnapshot AJFJDBINGIM);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot IHDCEBKCOJB(TPartialSnapshot[] NAFMEDMCLEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2951EE0", Offset = "0x2950AE0", VA = "0x182951EE0")]
	public static FLLFKKECNDP<TFullSnapshot> HAMGMNABIBF<TFullSnapshot, TPartialSnapshot, TDeps>(this JBOGJACPOFH<TPartialSnapshot, TFullSnapshot, TDeps> ENEDBNLKLJL, TPartialSnapshot AJFJDBINGIM) where TDeps : JHHBEHCDPFA<TPartialSnapshot, TFullSnapshot>
	{
		return default(FLLFKKECNDP<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2951DA0", Offset = "0x29509A0", VA = "0x182951DA0")]
	public static bool FIALMNNMIMB<TPartialSnapshot, TFullSnapshot, TDeps>(this JBOGJACPOFH<TPartialSnapshot, TFullSnapshot, TDeps> ENEDBNLKLJL, TPartialSnapshot AJFJDBINGIM) where TDeps : JHHBEHCDPFA<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HPMBMFDNAHE : BCBJAFAHBED
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FF0270", Offset = "0x1FEEE70", VA = "0x181FF0270", Slot = "7")]
	public override string FGIPLPDCCEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FF02A0", Offset = "0x1FEEEA0", VA = "0x181FF02A0")]
	public HPMBMFDNAHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class AECKEDIJACC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : FNJFCDFFKGL.AJIHNGEMDHF<TAction, TNetSys> where TReceiverDeps : FNJFCDFFKGL.KJFBBPPCJMC<TAction, TReceiver> where TRootDeps : FNJFCDFFKGL.NJJHICJBGCL<TMRequest, TAction, TRoot> where TDeps : FNJFCDFFKGL.KOEFNOLCFMD<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface JIFFNDHBILM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LEKPBEPNBPK([In] NLDGPBPIIJN<object, MFMODGJHEIL> KKIOBLFFGJH);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BJFPEBGJJCO();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		NLDGPBPIIJN<object, MFMODGJHEIL> HPINLEJLOLH();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void IBIHANALJOD(Exception GKFNJIBGPDM);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class JHECFMONPDN : JIFFNDHBILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<NLDGPBPIIJN<object, MFMODGJHEIL>> EAANOIMOJGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<NLDGPBPIIJN<object, MLPOHKBMKMA>> ECCKPBHHLDJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x4092A50", Offset = "0x4091650", VA = "0x184092A50")]
		private JHECFMONPDN(TaskCompletionSource<NLDGPBPIIJN<object, MFMODGJHEIL>> BIIFJEGEEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x4092510", Offset = "0x4091110", VA = "0x184092510")]
		public static JHECFMONPDN FCDPFGJNKNI(TaskCompletionSource<NLDGPBPIIJN<object, MFMODGJHEIL>> BIIFJEGEEHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x4092810", Offset = "0x4091410", VA = "0x184092810")]
		public void LEKPBEPNBPK([In] NLDGPBPIIJN<object, MFMODGJHEIL> KKIOBLFFGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x4092430", Offset = "0x4091030", VA = "0x184092430", Slot = "5")]
		public void BJFPEBGJJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x40925F0", Offset = "0x40911F0", VA = "0x1840925F0", Slot = "6")]
		public NLDGPBPIIJN<object, MFMODGJHEIL> HPINLEJLOLH()
		{
			return default(NLDGPBPIIJN<object, MFMODGJHEIL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x40927B0", Offset = "0x40913B0", VA = "0x1840927B0", Slot = "7")]
		public void IBIHANALJOD(Exception GKFNJIBGPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AA40", Offset = "0x3D49640", VA = "0x183D4AA40", Slot = "4")]
		private void GDHOKNBNFEP([In] NLDGPBPIIJN<object, MFMODGJHEIL> KKIOBLFFGJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class LIKNPKDCHIO : JIFFNDHBILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<NLDGPBPIIJN<object, MFMODGJHEIL>> EAANOIMOJGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private NLDGPBPIIJN<object, MFMODGJHEIL> GBDACPOJIJM;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x86E850", Offset = "0x86D450", VA = "0x18086E850")]
		private LIKNPKDCHIO(TaskCompletionSource<NLDGPBPIIJN<object, MFMODGJHEIL>> BIIFJEGEEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x4092510", Offset = "0x4091110", VA = "0x184092510")]
		public static LIKNPKDCHIO FCDPFGJNKNI(TaskCompletionSource<NLDGPBPIIJN<object, MFMODGJHEIL>> BIIFJEGEEHG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x427A210", Offset = "0x4278E10", VA = "0x18427A210")]
		public void LEKPBEPNBPK([In] NLDGPBPIIJN<object, MFMODGJHEIL> KKIOBLFFGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x427A0F0", Offset = "0x4278CF0", VA = "0x18427A0F0", Slot = "5")]
		public void BJFPEBGJJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC487C0", Offset = "0xC473C0", VA = "0x180C487C0", Slot = "6")]
		public NLDGPBPIIJN<object, MFMODGJHEIL> HPINLEJLOLH()
		{
			return default(NLDGPBPIIJN<object, MFMODGJHEIL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x427A1B0", Offset = "0x4278DB0", VA = "0x18427A1B0", Slot = "7")]
		public void IBIHANALJOD(Exception GKFNJIBGPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AA40", Offset = "0x3D49640", VA = "0x183D4AA40", Slot = "4")]
		private void GDHOKNBNFEP([In] NLDGPBPIIJN<object, MFMODGJHEIL> KKIOBLFFGJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class INDMBHHOPAG : JIFFNDHBILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<NLDGPBPIIJN<object, MFMODGJHEIL>> ECCKPBHHLDJ;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8F60", Offset = "0x3EB7B60", VA = "0x183EB8F60")]
		private INDMBHHOPAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A970", Offset = "0x3D49570", VA = "0x183D4A970")]
		public static INDMBHHOPAG FCDPFGJNKNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8DF0", Offset = "0x3EB79F0", VA = "0x183EB8DF0")]
		public void LEKPBEPNBPK([In] NLDGPBPIIJN<object, MFMODGJHEIL> KKIOBLFFGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void BJFPEBGJJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8C10", Offset = "0x3EB7810", VA = "0x183EB8C10", Slot = "6")]
		public NLDGPBPIIJN<object, MFMODGJHEIL> HPINLEJLOLH()
		{
			return default(NLDGPBPIIJN<object, MFMODGJHEIL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3EB8CC0", Offset = "0x3EB78C0", VA = "0x183EB8CC0", Slot = "7")]
		[ENAFOIIGLJJ("This may be terminal and should probably do more than discarding the exception.")]
		public void IBIHANALJOD(Exception GKFNJIBGPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AA40", Offset = "0x3D49640", VA = "0x183D4AA40", Slot = "4")]
		private void GDHOKNBNFEP([In] NLDGPBPIIJN<object, MFMODGJHEIL> KKIOBLFFGJH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class GFJHJFFEEDB : JIFFNDHBILM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NLDGPBPIIJN<object, MFMODGJHEIL> GBDACPOJIJM;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		private GFJHJFFEEDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3D4A970", Offset = "0x3D49570", VA = "0x183D4A970")]
		public static GFJHJFFEEDB FCDPFGJNKNI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x170BBC0", Offset = "0x170A7C0", VA = "0x18170BBC0")]
		public void LEKPBEPNBPK([In] NLDGPBPIIJN<object, MFMODGJHEIL> KKIOBLFFGJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void BJFPEBGJJCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8DA100", Offset = "0x8D8D00", VA = "0x1808DA100", Slot = "6")]
		public NLDGPBPIIJN<object, MFMODGJHEIL> HPINLEJLOLH()
		{
			return default(NLDGPBPIIJN<object, MFMODGJHEIL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AA80", Offset = "0x3D49680", VA = "0x183D4AA80", Slot = "7")]
		[ENAFOIIGLJJ("This may be terminal and should probably do more than discarding the exception.")]
		public void IBIHANALJOD(Exception GKFNJIBGPDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AA40", Offset = "0x3D49640", VA = "0x183D4AA40", Slot = "4")]
		private void GDHOKNBNFEP([In] NLDGPBPIIJN<object, MFMODGJHEIL> KKIOBLFFGJH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct DCLIAAHFNPN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AECKEDIJACC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JCIKKDEFAFO<GKGNBEOPDJJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<NLDGPBPIIJN<object, MFMODGJHEIL>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x587FB60", Offset = "0x587E760", VA = "0x18587FB60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5880060", Offset = "0x587EC60", VA = "0x185880060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct PDCDPOJLPGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public AECKEDIJACC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JCIKKDEFAFO<GKGNBEOPDJJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x475B750", Offset = "0x475A350", VA = "0x18475B750", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x475C0C0", Offset = "0x475ACC0", VA = "0x18475C0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NMEJLBPACEC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public AECKEDIJACC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JCIKKDEFAFO<GKGNBEOPDJJ> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JCIKKDEFAFO<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x452CE50", Offset = "0x452BA50", VA = "0x18452CE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x452D240", Offset = "0x452BE40", VA = "0x18452D240", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct HONPFPPBPEH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<NLDGPBPIIJN<object, MFMODGJHEIL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public AECKEDIJACC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public JCIKKDEFAFO<GKGNBEOPDJJ> senderId;

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
		public JCIKKDEFAFO<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private JIFFNDHBILM <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3DEE2E0", Offset = "0x3DECEE0", VA = "0x183DEE2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3DEEFF0", Offset = "0x3DEDBF0", VA = "0x183DEEFF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct HIPMOIFGHKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public AECKEDIJACC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JIFFNDHBILM completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private JIFFNDHBILM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<NLDGPBPIIJN<object, MFMODGJHEIL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3DBBD00", Offset = "0x3DBA900", VA = "0x183DBBD00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3DBFED0", Offset = "0x3DBEAD0", VA = "0x183DBFED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps PLLBOMGPHPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<JCIKKDEFAFO<TMRequest>, TaskCompletionSource<NLDGPBPIIJN<object, MFMODGJHEIL>>> IFAANHKIGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private ODGLEGJHCIM<TMRequest> DBEPLGKABGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int FFDAMJFJLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task FLECAJFAGOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps NACGPPKIGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB330", Offset = "0x3CE9F30", VA = "0x183CEB330")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps HPJOFMIOAGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB260", Offset = "0x3CE9E60", VA = "0x183CEB260")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps PJOGBBEBHCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3CEB660", Offset = "0x3CEA260", VA = "0x183CEB660")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool AKJLLHDIJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x932FC0", Offset = "0x931BC0", VA = "0x180932FC0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x13A1080", Offset = "0x139FC80", VA = "0x1813A1080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OKLFPNNPHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF43130", Offset = "0xF41D30", VA = "0x180F43130")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E96120", Offset = "0x1E94D20", VA = "0x181E96120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KKGFLHBKPHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x867CE0", Offset = "0x8668E0", VA = "0x180867CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3CECAD0", Offset = "0x3CEB6D0", VA = "0x183CECAD0")]
	public AECKEDIJACC(TDeps EIDBKEEIBKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC060", Offset = "0x3CEAC60", VA = "0x183CEC060")]
	public Task<NLDGPBPIIJN<object, MFMODGJHEIL>> NEDBFDFJGHM(TRoot LNPGMAMPBAC, TNetSys OBHOMPMMCPK, JCIKKDEFAFO<GKGNBEOPDJJ> AHCALNILMPH, TAction OBNFAOABLKL, bool AJEJMPLGBCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CEBDA0", Offset = "0x3CEA9A0", VA = "0x183CEBDA0")]
	[AsyncStateMachine(typeof(AECKEDIJACC<, , , , , , , , >.DCLIAAHFNPN))]
	private Task<NLDGPBPIIJN<object, MFMODGJHEIL>> NEDBFDFJGHM(TRoot LNPGMAMPBAC, JCIKKDEFAFO<GKGNBEOPDJJ> AHCALNILMPH, TAction OBNFAOABLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3CEADF0", Offset = "0x3CE99F0", VA = "0x183CEADF0")]
	[AsyncStateMachine(typeof(AECKEDIJACC<, , , , , , , , >.PDCDPOJLPGM))]
	private Task<NLDGPBPIIJN<object, MFMODGJHEIL>> EECDCAMMBCE(TRoot LNPGMAMPBAC, JCIKKDEFAFO<GKGNBEOPDJJ> AHCALNILMPH, TAction[] KFCIDPMFGKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3CEAB20", Offset = "0x3CE9720", VA = "0x183CEAB20")]
	[AsyncStateMachine(typeof(AECKEDIJACC<, , , , , , , , >.NMEJLBPACEC))]
	public Task<NLDGPBPIIJN<object, MFMODGJHEIL>> BHJJDLJNIJH(TRoot LNPGMAMPBAC, TNetSys DLLGACGEFND, TReceiver LFPNEAKNDGE, JCIKKDEFAFO<GKGNBEOPDJJ> AHCALNILMPH, JCIKKDEFAFO<TMRequest> MBDHAMANMBF, TAction OBNFAOABLKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3CEAF50", Offset = "0x3CE9B50", VA = "0x183CEAF50")]
	[AsyncStateMachine(typeof(AECKEDIJACC<, , , , , , , , >.HONPFPPBPEH))]
	private Task<NLDGPBPIIJN<object, MFMODGJHEIL>> GBFOKHFCFEF(TRoot LNPGMAMPBAC, TNetSys DLLGACGEFND, TReceiver LFPNEAKNDGE, JCIKKDEFAFO<GKGNBEOPDJJ> AHCALNILMPH, JCIKKDEFAFO<TMRequest> MBDHAMANMBF, TAction OBNFAOABLKL, Task EKKAJDBGEJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB4C0", Offset = "0x3CEA0C0", VA = "0x183CEB4C0")]
	[AsyncStateMachine(typeof(AECKEDIJACC<, , , , , , , , >.HIPMOIFGHKB))]
	private Task JBIFIBONAJM(TRoot LNPGMAMPBAC, TNetSys DLLGACGEFND, TReceiver LFPNEAKNDGE, TAction OBNFAOABLKL, JIFFNDHBILM NEIOMAJKNNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3CEB690", Offset = "0x3CEA290", VA = "0x183CEB690")]
	private void NBAIKIJNKNB(TRoot LNPGMAMPBAC, TNetSys DLLGACGEFND, TReceiver LFPNEAKNDGE, JCIKKDEFAFO<GKGNBEOPDJJ> AHCALNILMPH, TAction OBNFAOABLKL, bool PPPFPFCIPGN, bool MIPJMDKPANG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FNJFCDFFKGL
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface AJIHNGEMDHF<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int PIEIDLPDHBL(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction EMMFGIGIHPF(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction NKJNCDBAEPG(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> CBJGGEJDADK(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] BCCLKNMEHAL(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL, int BBKJFLOMIFH);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool EPJFJFLHLBA(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CNCMEBKKMIA(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool PIGBKKPHFMH(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool IDBCECOKEGH(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FAEFENLHEFG(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool NFDGNNHECJF(TNetSys ECIHEOBBGIJ, TAction OBNFAOABLKL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KOEFNOLCFMD<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps NACGPPKIGOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps PJOGBBEBHCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps HPJOFMIOAGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface KJFBBPPCJMC<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JCIKKDEFAFO<GKGNBEOPDJJ> LKNIIMAOCAA(TReceiver LFPNEAKNDGE);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<NLDGPBPIIJN<object, MFMODGJHEIL>> BHJJDLJNIJH(TReceiver LFPNEAKNDGE, TAction OBNFAOABLKL);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] BCNPLPMIIMF(TReceiver LFPNEAKNDGE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface NJJHICJBGCL<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GHEOFEEHAMF(TRoot LNPGMAMPBAC);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int NDLNLEPNFKJ(TRoot LNPGMAMPBAC);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int LIDJLKPPBEK(TRoot LNPGMAMPBAC);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int HPGMKKIAACK(TRoot LNPGMAMPBAC);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GDFNFGFCBEC(TRoot LNPGMAMPBAC);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task NEDBFDFJGHM(TRoot LNPGMAMPBAC, JCIKKDEFAFO<GKGNBEOPDJJ> AHCALNILMPH, JCIKKDEFAFO<TMRequest> MBDHAMANMBF, TAction OBNFAOABLKL, bool HKPGEBLHCEI = true);
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
