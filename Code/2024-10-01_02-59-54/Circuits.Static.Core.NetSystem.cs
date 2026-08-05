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
public struct JKAHICBEDBK<TPartialAction, TFullAction, TDeps> where TDeps : KFCOPENCPOJ.NMEEHGFAPKD<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] NABKPMAGLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int CEJHHJOAACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps DILMOBAKENH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4438E00", Offset = "0x4438200", VA = "0x184438E00")]
	internal JKAHICBEDBK(TPartialAction[] FFGAGKHMBBJ, int IEEDEABEMGE, TDeps ICFGLKCGHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4438D90", Offset = "0x4438190", VA = "0x184438D90")]
	public static JKAHICBEDBK<TPartialAction, TFullAction, TDeps> AALKPJMFIHM(TDeps ICFGLKCGHOG)
	{
		return default(JKAHICBEDBK<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KFCOPENCPOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface NMEEHGFAPKD<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GLDEJJFNBPI([In] TPartialAction ANGIAFOLOMG);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction HBOFNMAIGPJ(TPartialAction[] PAJCECKOKNF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2C56FB0", Offset = "0x2C563B0", VA = "0x182C56FB0")]
	public static JEJCONLJHLG<TFullAction> NDIMMFIEEHC<TFullAction, TPartialAction, TDeps>(this JKAHICBEDBK<TPartialAction, TFullAction, TDeps> MBGHIKEGJAA, TPartialAction ANGIAFOLOMG) where TDeps : NMEEHGFAPKD<TPartialAction, TFullAction>
	{
		return default(JEJCONLJHLG<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MCIKJAKKLLL<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : CNMJHEJFONM.JMELFGFLDAH<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] PDNNHGEHGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int FGBLGBKMOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps DILMOBAKENH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4438E50", Offset = "0x4438250", VA = "0x184438E50")]
	internal MCIKJAKKLLL(TPartialSnapshot[] HNEHDPKEAHN, int GKOHKOBOKNE, TDeps ICFGLKCGHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4438D30", Offset = "0x4438130", VA = "0x184438D30")]
	public static MCIKJAKKLLL<TPartialSnapshot, TFullSnapshot, TDeps> AALKPJMFIHM(TDeps ICFGLKCGHOG)
	{
		return default(MCIKJAKKLLL<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CNMJHEJFONM
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface JMELFGFLDAH<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int OJACEPJDOPD([In] TPartialSnapshot LPFLJGNNGIF);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot MLNPIBEGOHN(TPartialSnapshot[] KNAGKAMJEDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C56E30", Offset = "0x2C56230", VA = "0x182C56E30")]
	public static JEJCONLJHLG<TFullSnapshot> NDIMMFIEEHC<TFullSnapshot, TPartialSnapshot, TDeps>(this MCIKJAKKLLL<TPartialSnapshot, TFullSnapshot, TDeps> MBGHIKEGJAA, TPartialSnapshot LPFLJGNNGIF) where TDeps : JMELFGFLDAH<TPartialSnapshot, TFullSnapshot>
	{
		return default(JEJCONLJHLG<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C56CF0", Offset = "0x2C560F0", VA = "0x182C56CF0")]
	public static bool CDABMEKLLHN<TPartialSnapshot, TFullSnapshot, TDeps>(this MCIKJAKKLLL<TPartialSnapshot, TFullSnapshot, TDeps> MBGHIKEGJAA, TPartialSnapshot LPFLJGNNGIF) where TDeps : JMELFGFLDAH<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class EBABBOCEINM : FLDDNKNCPHH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x224B710", Offset = "0x224AB10", VA = "0x18224B710", Slot = "7")]
	public override string KIGPPELGDEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x224B740", Offset = "0x224AB40", VA = "0x18224B740")]
	public EBABBOCEINM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class DKLFPCEKPLJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : OOFFKPOODLA.MEHBAPENJOF<TAction, TNetSys> where TReceiverDeps : OOFFKPOODLA.KJKFABBFMEB<TAction, TReceiver> where TRootDeps : OOFFKPOODLA.LICNJNMMGBP<TMRequest, TAction, TRoot> where TDeps : OOFFKPOODLA.HEHCAFIPINL<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface BJAJHGENIAG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BLIOPJGEBNL([In] MLIDCCDLMIE<object, FNDOAGAGANG> CIFMGKBFCHA);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FKLNECJLLFK();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		MLIDCCDLMIE<object, FNDOAGAGANG> OENNGPGPGBB();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void MPIPDGFDKMJ(Exception JFJOELAOBOE);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class CIEBCHAAMCG : BJAJHGENIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<MLIDCCDLMIE<object, FNDOAGAGANG>> INGFOFJBILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<MLIDCCDLMIE<object, JPHFAKFKMJL>> HDPBPLFNHGJ;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x531E8D0", Offset = "0x531DCD0", VA = "0x18531E8D0")]
		private CIEBCHAAMCG(TaskCompletionSource<MLIDCCDLMIE<object, FNDOAGAGANG>> DEEDJNIJDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x41669F0", Offset = "0x4165DF0", VA = "0x1841669F0")]
		public static CIEBCHAAMCG AALKPJMFIHM(TaskCompletionSource<MLIDCCDLMIE<object, FNDOAGAGANG>> DEEDJNIJDCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x531E210", Offset = "0x531D610", VA = "0x18531E210")]
		public void BLIOPJGEBNL([In] MLIDCCDLMIE<object, FNDOAGAGANG> CIFMGKBFCHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x531E530", Offset = "0x531D930", VA = "0x18531E530", Slot = "5")]
		public void FKLNECJLLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x531E6D0", Offset = "0x531DAD0", VA = "0x18531E6D0", Slot = "6")]
		public MLIDCCDLMIE<object, FNDOAGAGANG> OENNGPGPGBB()
		{
			return default(MLIDCCDLMIE<object, FNDOAGAGANG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x531E610", Offset = "0x531DA10", VA = "0x18531E610", Slot = "7")]
		public void MPIPDGFDKMJ(Exception JFJOELAOBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8590", Offset = "0x3EF7990", VA = "0x183EF8590", Slot = "4")]
		private void GOBIDDJIFLC([In] MLIDCCDLMIE<object, FNDOAGAGANG> CIFMGKBFCHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class IBKCCHPCHJH : BJAJHGENIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<MLIDCCDLMIE<object, FNDOAGAGANG>> INGFOFJBILH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private MLIDCCDLMIE<object, FNDOAGAGANG> PEKEIFKEFEP;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8AF9B0", Offset = "0x8AEDB0", VA = "0x1808AF9B0")]
		private IBKCCHPCHJH(TaskCompletionSource<MLIDCCDLMIE<object, FNDOAGAGANG>> DEEDJNIJDCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x41669F0", Offset = "0x4165DF0", VA = "0x1841669F0")]
		public static IBKCCHPCHJH AALKPJMFIHM(TaskCompletionSource<MLIDCCDLMIE<object, FNDOAGAGANG>> DEEDJNIJDCK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x3B263F0", Offset = "0x3B257F0", VA = "0x183B263F0")]
		public void BLIOPJGEBNL([In] MLIDCCDLMIE<object, FNDOAGAGANG> CIFMGKBFCHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4166B30", Offset = "0x4165F30", VA = "0x184166B30", Slot = "5")]
		public void FKLNECJLLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x95E950", Offset = "0x95DD50", VA = "0x18095E950", Slot = "6")]
		public MLIDCCDLMIE<object, FNDOAGAGANG> OENNGPGPGBB()
		{
			return default(MLIDCCDLMIE<object, FNDOAGAGANG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4166B90", Offset = "0x4165F90", VA = "0x184166B90", Slot = "7")]
		public void MPIPDGFDKMJ(Exception JFJOELAOBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8590", Offset = "0x3EF7990", VA = "0x183EF8590", Slot = "4")]
		private void GOBIDDJIFLC([In] MLIDCCDLMIE<object, FNDOAGAGANG> CIFMGKBFCHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class KBNFBCAIHPM : BJAJHGENIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<MLIDCCDLMIE<object, FNDOAGAGANG>> HDPBPLFNHGJ;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x451E8C0", Offset = "0x451DCC0", VA = "0x18451E8C0")]
		private KBNFBCAIHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3EF84C0", Offset = "0x3EF78C0", VA = "0x183EF84C0")]
		public static KBNFBCAIHPM AALKPJMFIHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x451E5F0", Offset = "0x451D9F0", VA = "0x18451E5F0")]
		public void BLIOPJGEBNL([In] MLIDCCDLMIE<object, FNDOAGAGANG> CIFMGKBFCHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void FKLNECJLLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x451E770", Offset = "0x451DB70", VA = "0x18451E770", Slot = "6")]
		public MLIDCCDLMIE<object, FNDOAGAGANG> OENNGPGPGBB()
		{
			return default(MLIDCCDLMIE<object, FNDOAGAGANG>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x451E720", Offset = "0x451DB20", VA = "0x18451E720", Slot = "7")]
		[EAFJAFLMLNJ("This may be terminal and should probably do more than discarding the exception.")]
		public void MPIPDGFDKMJ(Exception JFJOELAOBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8590", Offset = "0x3EF7990", VA = "0x183EF8590", Slot = "4")]
		private void GOBIDDJIFLC([In] MLIDCCDLMIE<object, FNDOAGAGANG> CIFMGKBFCHA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class FEJHDLKNNMM : BJAJHGENIAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private MLIDCCDLMIE<object, FNDOAGAGANG> PEKEIFKEFEP;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		private FEJHDLKNNMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3EF84C0", Offset = "0x3EF78C0", VA = "0x183EF84C0")]
		public static FEJHDLKNNMM AALKPJMFIHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1C065F0", Offset = "0x1C059F0", VA = "0x181C065F0")]
		public void BLIOPJGEBNL([In] MLIDCCDLMIE<object, FNDOAGAGANG> CIFMGKBFCHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void FKLNECJLLFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xACF380", Offset = "0xACE780", VA = "0x180ACF380", Slot = "6")]
		public MLIDCCDLMIE<object, FNDOAGAGANG> OENNGPGPGBB()
		{
			return default(MLIDCCDLMIE<object, FNDOAGAGANG>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8620", Offset = "0x3EF7A20", VA = "0x183EF8620", Slot = "7")]
		[EAFJAFLMLNJ("This may be terminal and should probably do more than discarding the exception.")]
		public void MPIPDGFDKMJ(Exception JFJOELAOBOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8590", Offset = "0x3EF7990", VA = "0x183EF8590", Slot = "4")]
		private void GOBIDDJIFLC([In] MLIDCCDLMIE<object, FNDOAGAGANG> CIFMGKBFCHA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct DKGHLAAEPCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public DKLFPCEKPLJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public FGLBFCBPBCD<FFADPJAABGA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<MLIDCCDLMIE<object, FNDOAGAGANG>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F4D0", Offset = "0x5C4E8D0", VA = "0x185C4F4D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5C4F9D0", Offset = "0x5C4EDD0", VA = "0x185C4F9D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BNFPLDCAEHP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public DKLFPCEKPLJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public FGLBFCBPBCD<FFADPJAABGA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x527E2E0", Offset = "0x527D6E0", VA = "0x18527E2E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x527EBE0", Offset = "0x527DFE0", VA = "0x18527EBE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EKKCNCMOGKI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public DKLFPCEKPLJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FGLBFCBPBCD<FFADPJAABGA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public FGLBFCBPBCD<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3B41150", Offset = "0x3B40550", VA = "0x183B41150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3B41530", Offset = "0x3B40930", VA = "0x183B41530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct CGBHLPFFKAB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<MLIDCCDLMIE<object, FNDOAGAGANG>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public DKLFPCEKPLJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public FGLBFCBPBCD<FFADPJAABGA> senderId;

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
		public FGLBFCBPBCD<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private BJAJHGENIAG <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x531C2D0", Offset = "0x531B6D0", VA = "0x18531C2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x531CFE0", Offset = "0x531C3E0", VA = "0x18531CFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct IFHLAHCCGFB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public DKLFPCEKPLJ<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public BJAJHGENIAG completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private BJAJHGENIAG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<MLIDCCDLMIE<object, FNDOAGAGANG>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x41DCF30", Offset = "0x41DC330", VA = "0x1841DCF30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x41E1140", Offset = "0x41E0540", VA = "0x1841E1140", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps DILMOBAKENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<FGLBFCBPBCD<TMRequest>, TaskCompletionSource<MLIDCCDLMIE<object, FNDOAGAGANG>>> GPJCJBHDNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NIODEGMNGOF<TMRequest> OEKJAGMFGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int JANPDFMGPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task GICADFHBJNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps KKHLJHNLING
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5C516E0", Offset = "0x5C50AE0", VA = "0x185C516E0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps AKLLBONPAMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C51590", Offset = "0x5C50990", VA = "0x185C51590")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps HBHCGDGJMHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C51660", Offset = "0x5C50A60", VA = "0x185C51660")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool OFPLDGEPKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xC209F0", Offset = "0xC1FDF0", VA = "0x180C209F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1848E60", Offset = "0x1848260", VA = "0x181848E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool HGCKLCAAMEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x12677F0", Offset = "0x1266BF0", VA = "0x1812677F0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x20F1080", Offset = "0x20F0480", VA = "0x1820F1080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EIEEIJKOODL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC60", Offset = "0x8AE060", VA = "0x1808AEC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5C51CB0", Offset = "0x5C510B0", VA = "0x185C51CB0")]
	public DKLFPCEKPLJ(TDeps ICFGLKCGHOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5C509F0", Offset = "0x5C4FDF0", VA = "0x185C509F0")]
	public Task<MLIDCCDLMIE<object, FNDOAGAGANG>> KGKGPMCBPAO(TRoot FINELPFBLOK, TNetSys IGGGDDFGMNG, FGLBFCBPBCD<FFADPJAABGA> MKFGJOHIBBM, TAction MDOOJHKFGMP, bool COINEAOGNMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5C51430", Offset = "0x5C50830", VA = "0x185C51430")]
	[AsyncStateMachine(typeof(DKLFPCEKPLJ<, , , , , , , , >.DKGHLAAEPCM))]
	private Task<MLIDCCDLMIE<object, FNDOAGAGANG>> KGKGPMCBPAO(TRoot FINELPFBLOK, FGLBFCBPBCD<FFADPJAABGA> MKFGJOHIBBM, TAction MDOOJHKFGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5C50890", Offset = "0x5C4FC90", VA = "0x185C50890")]
	[AsyncStateMachine(typeof(DKLFPCEKPLJ<, , , , , , , , >.BNFPLDCAEHP))]
	private Task<MLIDCCDLMIE<object, FNDOAGAGANG>> IHMKEDOKCNG(TRoot FINELPFBLOK, FGLBFCBPBCD<FFADPJAABGA> MKFGJOHIBBM, TAction[] LEPHFNPNBLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5C51B40", Offset = "0x5C50F40", VA = "0x185C51B40")]
	[AsyncStateMachine(typeof(DKLFPCEKPLJ<, , , , , , , , >.EKKCNCMOGKI))]
	public Task<MLIDCCDLMIE<object, FNDOAGAGANG>> NKCJLKLGGBG(TRoot FINELPFBLOK, TNetSys MHABDCABNEI, TReceiver HBMDFELGEPK, FGLBFCBPBCD<FFADPJAABGA> MKFGJOHIBBM, FGLBFCBPBCD<TMRequest> DFGKNBACFBF, TAction MDOOJHKFGMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5C50420", Offset = "0x5C4F820", VA = "0x185C50420")]
	[AsyncStateMachine(typeof(DKLFPCEKPLJ<, , , , , , , , >.CGBHLPFFKAB))]
	private Task<MLIDCCDLMIE<object, FNDOAGAGANG>> ENAKDCKLILJ(TRoot FINELPFBLOK, TNetSys MHABDCABNEI, TReceiver HBMDFELGEPK, FGLBFCBPBCD<FFADPJAABGA> MKFGJOHIBBM, FGLBFCBPBCD<TMRequest> DFGKNBACFBF, TAction MDOOJHKFGMP, Task OANENAFOJEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5C51870", Offset = "0x5C50C70", VA = "0x185C51870")]
	[AsyncStateMachine(typeof(DKLFPCEKPLJ<, , , , , , , , >.IFHLAHCCGFB))]
	private Task NGGNABJAGHD(TRoot FINELPFBLOK, TNetSys MHABDCABNEI, TReceiver HBMDFELGEPK, TAction MDOOJHKFGMP, BJAJHGENIAG NIFFLAOBIOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5C4FD20", Offset = "0x5C4F120", VA = "0x185C4FD20")]
	private void DLMLDKAFOOH(TRoot FINELPFBLOK, TNetSys MHABDCABNEI, TReceiver HBMDFELGEPK, FGLBFCBPBCD<FFADPJAABGA> MKFGJOHIBBM, TAction MDOOJHKFGMP, bool NKLJJAJJOFF, bool GADNDNOCOJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OOFFKPOODLA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface MEHBAPENJOF<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MOFLKHLNIAJ(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction LKHMBHMKAAB(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction BNFFOPDJGBC(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> DOMIIFFMJDO(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] IGLBLEAAJIC(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP, int BLCFINBJLND);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OHLCCLGDMLF(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool MKPBADFDIJK(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool JKJLFJJAGHH(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool AEAKBEBNFED(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool FJALDLBCPBA(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool OOICEPJLAPA(TNetSys FMEBGPNKMAK, TAction MDOOJHKFGMP);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface HEHCAFIPINL<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps KKHLJHNLING
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps HBHCGDGJMHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps AKLLBONPAMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface KJKFABBFMEB<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		FGLBFCBPBCD<FFADPJAABGA> PCMDNOPOOOJ(TReceiver HBMDFELGEPK);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<MLIDCCDLMIE<object, FNDOAGAGANG>> NKCJLKLGGBG(TReceiver HBMDFELGEPK, TAction MDOOJHKFGMP);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] LLNBKPFGGFI(TReceiver HBMDFELGEPK);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface LICNJNMMGBP<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int ABHAELPOHAP(TRoot FINELPFBLOK);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int LJPAAHGFGDB(TRoot FINELPFBLOK);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int DNBEBBJECCM(TRoot FINELPFBLOK);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int EKFFBCCLCPP(TRoot FINELPFBLOK);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void BPBGKCDLDLC(TRoot FINELPFBLOK);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task KGKGPMCBPAO(TRoot FINELPFBLOK, FGLBFCBPBCD<FFADPJAABGA> MKFGJOHIBBM, FGLBFCBPBCD<TMRequest> DFGKNBACFBF, TAction MDOOJHKFGMP, bool CHPJDNJJNDN = true);
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
