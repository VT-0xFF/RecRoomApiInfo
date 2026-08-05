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
public struct IKNEJNHIFEK<TPartialAction, TFullAction, TDeps> where TDeps : HAHECDGCELM.PFODLDCDPNA<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] JELKMKAOIBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int OFEFABFILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps ACLONILLIHG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4215150", Offset = "0x4214550", VA = "0x184215150")]
	internal IKNEJNHIFEK(TPartialAction[] HPJFJFODICL, int MIHDNPEFABB, TDeps PJBENGOCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4215030", Offset = "0x4214430", VA = "0x184215030")]
	public static IKNEJNHIFEK<TPartialAction, TFullAction, TDeps> GIIIFAJNKEL(TDeps PJBENGOCCDF)
	{
		return default(IKNEJNHIFEK<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HAHECDGCELM
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PFODLDCDPNA<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GPAPKEECFFO([In] TPartialAction GFBBNMFNOED);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction PEELDLFKBAC(TPartialAction[] PKCEBELHPII);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2EC5410", Offset = "0x2EC4810", VA = "0x182EC5410")]
	public static BLOKLLOGIFH<TFullAction> HLLBGNGFFJN<TFullAction, TPartialAction, TDeps>(this IKNEJNHIFEK<TPartialAction, TFullAction, TDeps> EAFEIEDNLNL, TPartialAction GFBBNMFNOED) where TDeps : PFODLDCDPNA<TPartialAction, TFullAction>
	{
		return default(BLOKLLOGIFH<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct KLMCKAINDOO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : IKKOOFBGGIE.HBOFKJJFKCP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] OOFGHMCLLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int KFBBIKOPLDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps ACLONILLIHG;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4215150", Offset = "0x4214550", VA = "0x184215150")]
	internal KLMCKAINDOO(TPartialSnapshot[] MNILLOMCLLP, int MHEIJGHJAHE, TDeps PJBENGOCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4215030", Offset = "0x4214430", VA = "0x184215030")]
	public static KLMCKAINDOO<TPartialSnapshot, TFullSnapshot, TDeps> GIIIFAJNKEL(TDeps PJBENGOCCDF)
	{
		return default(KLMCKAINDOO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IKKOOFBGGIE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface HBOFKJJFKCP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EFBPPDFGEKL([In] TPartialSnapshot EFDDMAFCIKF);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot JEEIFHKBFIK(TPartialSnapshot[] AOFJHMJLIED);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2EEC510", Offset = "0x2EEB910", VA = "0x182EEC510")]
	public static BLOKLLOGIFH<TFullSnapshot> HLLBGNGFFJN<TFullSnapshot, TPartialSnapshot, TDeps>(this KLMCKAINDOO<TPartialSnapshot, TFullSnapshot, TDeps> EAFEIEDNLNL, TPartialSnapshot EFDDMAFCIKF) where TDeps : HBOFKJJFKCP<TPartialSnapshot, TFullSnapshot>
	{
		return default(BLOKLLOGIFH<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2EEC3C0", Offset = "0x2EEB7C0", VA = "0x182EEC3C0")]
	public static bool DFNEIPKFGBF<TPartialSnapshot, TFullSnapshot, TDeps>(this KLMCKAINDOO<TPartialSnapshot, TFullSnapshot, TDeps> EAFEIEDNLNL, TPartialSnapshot EFDDMAFCIKF) where TDeps : HBOFKJJFKCP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class LNENENBIFOC : PBKMDGOJDEJ
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2292D90", Offset = "0x2292190", VA = "0x182292D90", Slot = "7")]
	public override string ECJFEDANMLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2292DC0", Offset = "0x22921C0", VA = "0x182292DC0")]
	public LNENENBIFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class FJENEOBEPBC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : DMHNFCBKGOM.CBAFNPOPFMN<TAction, TNetSys> where TReceiverDeps : DMHNFCBKGOM.BJABKOFPGKF<TAction, TReceiver> where TRootDeps : DMHNFCBKGOM.IGHBDNHKLDI<TMRequest, TAction, TRoot> where TDeps : DMHNFCBKGOM.AOBELAMNHIE<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface FIBMNNHBNOC
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PDFKNALEJCK([In] BMFECDODLAB<object, JLOPLHOLGBP> HCMJFDLGOJF);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ILNHMHDLOEI();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		BMFECDODLAB<object, JLOPLHOLGBP> DFKLCJOGGEC();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void KKBHPADPDGC(Exception BDBOMDMKJJK);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class FGFEFLHMPGK : FIBMNNHBNOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<BMFECDODLAB<object, JLOPLHOLGBP>> JPANHEJPOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<BMFECDODLAB<object, JPIHCAEEFCD>> NCKCGKIHEAH;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3F3CC90", Offset = "0x3F3C090", VA = "0x183F3CC90")]
		private FGFEFLHMPGK(TaskCompletionSource<BMFECDODLAB<object, JLOPLHOLGBP>> AEJJDMNDMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C620", Offset = "0x3F3BA20", VA = "0x183F3C620")]
		public static FGFEFLHMPGK GIIIFAJNKEL(TaskCompletionSource<BMFECDODLAB<object, JLOPLHOLGBP>> AEJJDMNDMNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C9B0", Offset = "0x3F3BDB0", VA = "0x183F3C9B0")]
		public void PDFKNALEJCK([In] BMFECDODLAB<object, JLOPLHOLGBP> HCMJFDLGOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C7D0", Offset = "0x3F3BBD0", VA = "0x183F3C7D0", Slot = "5")]
		public void ILNHMHDLOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C570", Offset = "0x3F3B970", VA = "0x183F3C570", Slot = "6")]
		public BMFECDODLAB<object, JLOPLHOLGBP> DFKLCJOGGEC()
		{
			return default(BMFECDODLAB<object, JLOPLHOLGBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C8B0", Offset = "0x3F3BCB0", VA = "0x183F3C8B0", Slot = "7")]
		public void KKBHPADPDGC(Exception BDBOMDMKJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C970", Offset = "0x3F3BD70", VA = "0x183F3C970", Slot = "4")]
		private void LHLFFJIBNLN([In] BMFECDODLAB<object, JLOPLHOLGBP> HCMJFDLGOJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class HAHHOMNFLBB : FIBMNNHBNOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<BMFECDODLAB<object, JLOPLHOLGBP>> JPANHEJPOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private BMFECDODLAB<object, JLOPLHOLGBP> LMEEDPOOJOB;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x89A2A0", Offset = "0x8996A0", VA = "0x18089A2A0")]
		private HAHHOMNFLBB(TaskCompletionSource<BMFECDODLAB<object, JLOPLHOLGBP>> AEJJDMNDMNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C620", Offset = "0x3F3BA20", VA = "0x183F3C620")]
		public static HAHHOMNFLBB GIIIFAJNKEL(TaskCompletionSource<BMFECDODLAB<object, JLOPLHOLGBP>> AEJJDMNDMNA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x40430F0", Offset = "0x40424F0", VA = "0x1840430F0")]
		public void PDFKNALEJCK([In] BMFECDODLAB<object, JLOPLHOLGBP> HCMJFDLGOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x41203B0", Offset = "0x411F7B0", VA = "0x1841203B0", Slot = "5")]
		public void ILNHMHDLOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x96D130", Offset = "0x96C530", VA = "0x18096D130", Slot = "6")]
		public BMFECDODLAB<object, JLOPLHOLGBP> DFKLCJOGGEC()
		{
			return default(BMFECDODLAB<object, JLOPLHOLGBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x4120410", Offset = "0x411F810", VA = "0x184120410", Slot = "7")]
		public void KKBHPADPDGC(Exception BDBOMDMKJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C970", Offset = "0x3F3BD70", VA = "0x183F3C970", Slot = "4")]
		private void LHLFFJIBNLN([In] BMFECDODLAB<object, JLOPLHOLGBP> HCMJFDLGOJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class NAGDBHMNOJJ : FIBMNNHBNOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<BMFECDODLAB<object, JLOPLHOLGBP>> NCKCGKIHEAH;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x492DDD0", Offset = "0x492D1D0", VA = "0x18492DDD0")]
		private NAGDBHMNOJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x492DAB0", Offset = "0x492CEB0", VA = "0x18492DAB0")]
		public static NAGDBHMNOJJ GIIIFAJNKEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x492DC10", Offset = "0x492D010", VA = "0x18492DC10")]
		public void PDFKNALEJCK([In] BMFECDODLAB<object, JLOPLHOLGBP> HCMJFDLGOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void ILNHMHDLOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x492D9F0", Offset = "0x492CDF0", VA = "0x18492D9F0", Slot = "6")]
		public BMFECDODLAB<object, JLOPLHOLGBP> DFKLCJOGGEC()
		{
			return default(BMFECDODLAB<object, JLOPLHOLGBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x492DB70", Offset = "0x492CF70", VA = "0x18492DB70", Slot = "7")]
		[GDCDIKCGJKC("This may be terminal and should probably do more than discarding the exception.")]
		public void KKBHPADPDGC(Exception BDBOMDMKJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C970", Offset = "0x3F3BD70", VA = "0x183F3C970", Slot = "4")]
		private void LHLFFJIBNLN([In] BMFECDODLAB<object, JLOPLHOLGBP> HCMJFDLGOJF)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class BANOGIKAMEP : FIBMNNHBNOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BMFECDODLAB<object, JLOPLHOLGBP> LMEEDPOOJOB;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		private BANOGIKAMEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x492DAB0", Offset = "0x492CEB0", VA = "0x18492DAB0")]
		public static BANOGIKAMEP GIIIFAJNKEL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1B9E240", Offset = "0x1B9D640", VA = "0x181B9E240")]
		public void PDFKNALEJCK([In] BMFECDODLAB<object, JLOPLHOLGBP> HCMJFDLGOJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void ILNHMHDLOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xAE8210", Offset = "0xAE7610", VA = "0x180AE8210", Slot = "6")]
		public BMFECDODLAB<object, JLOPLHOLGBP> DFKLCJOGGEC()
		{
			return default(BMFECDODLAB<object, JLOPLHOLGBP>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x52175D0", Offset = "0x52169D0", VA = "0x1852175D0", Slot = "7")]
		[GDCDIKCGJKC("This may be terminal and should probably do more than discarding the exception.")]
		public void KKBHPADPDGC(Exception BDBOMDMKJJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3F3C970", Offset = "0x3F3BD70", VA = "0x183F3C970", Slot = "4")]
		private void LHLFFJIBNLN([In] BMFECDODLAB<object, JLOPLHOLGBP> HCMJFDLGOJF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct DLGKJEGKNLK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public FJENEOBEPBC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public KENIFKLGBBB<IKBGAEAMJPD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<BMFECDODLAB<object, JLOPLHOLGBP>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5C02B10", Offset = "0x5C01F10", VA = "0x185C02B10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5C035F0", Offset = "0x5C029F0", VA = "0x185C035F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct MJALLJIAKEA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public FJENEOBEPBC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public KENIFKLGBBB<IKBGAEAMJPD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x48CF370", Offset = "0x48CE770", VA = "0x1848CF370", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x48CF840", Offset = "0x48CEC40", VA = "0x1848CF840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct JMAAJDGGFMI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public FJENEOBEPBC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public KENIFKLGBBB<IKBGAEAMJPD> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public KENIFKLGBBB<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4438D60", Offset = "0x4438160", VA = "0x184438D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x44394A0", Offset = "0x44388A0", VA = "0x1844394A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MJAELFECPDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<BMFECDODLAB<object, JLOPLHOLGBP>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public FJENEOBEPBC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public KENIFKLGBBB<IKBGAEAMJPD> senderId;

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
		public KENIFKLGBBB<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private FIBMNNHBNOC <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x48CE200", Offset = "0x48CD600", VA = "0x1848CE200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x48CEE30", Offset = "0x48CE230", VA = "0x1848CEE30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct JBODLDBAPJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public FJENEOBEPBC<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FIBMNNHBNOC completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FIBMNNHBNOC <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<BMFECDODLAB<object, JLOPLHOLGBP>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x43D4D70", Offset = "0x43D4170", VA = "0x1843D4D70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x43D8C30", Offset = "0x43D8030", VA = "0x1843D8C30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps ACLONILLIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<KENIFKLGBBB<TMRequest>, TaskCompletionSource<BMFECDODLAB<object, JLOPLHOLGBP>>> OJPBFCGBCCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KGILIAOOMJK<TMRequest> PIANIMHEJDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int OEAHPJBCICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task GBNKIFBFHKN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps FBDAPLBGCIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3F4AA70", Offset = "0x3F49E70", VA = "0x183F4AA70")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps OKNNDHPKCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3F4BEE0", Offset = "0x3F4B2E0", VA = "0x183F4BEE0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps KOFGJEGGEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3F4BB80", Offset = "0x3F4AF80", VA = "0x183F4BB80")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool PLABHPODLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xC4FFD0", Offset = "0xC4F3D0", VA = "0x180C4FFD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x17FDFD0", Offset = "0x17FD3D0", VA = "0x1817FDFD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool BJFCAFFAPEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x128E930", Offset = "0x128DD30", VA = "0x18128E930")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x21375D0", Offset = "0x21369D0", VA = "0x1821375D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DJPGNCGLDEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8A6040", Offset = "0x8A5440", VA = "0x1808A6040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x3F4C270", Offset = "0x3F4B670", VA = "0x183F4C270")]
	public FJENEOBEPBC(TDeps PJBENGOCCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3F4B1C0", Offset = "0x3F4A5C0", VA = "0x183F4B1C0")]
	public Task<BMFECDODLAB<object, JLOPLHOLGBP>> IENABDLHCLG(TRoot DADDPLMNJHB, TNetSys HLEFLGHKMNJ, KENIFKLGBBB<IKBGAEAMJPD> DOJPOBHEMAE, TAction LLIKOHELCCA, bool PFAJPHGPIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3F4B060", Offset = "0x3F4A460", VA = "0x183F4B060")]
	[AsyncStateMachine(typeof(FJENEOBEPBC<, , , , , , , , >.DLGKJEGKNLK))]
	private Task<BMFECDODLAB<object, JLOPLHOLGBP>> IENABDLHCLG(TRoot DADDPLMNJHB, KENIFKLGBBB<IKBGAEAMJPD> DOJPOBHEMAE, TAction LLIKOHELCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3F4AAF0", Offset = "0x3F49EF0", VA = "0x183F4AAF0")]
	[AsyncStateMachine(typeof(FJENEOBEPBC<, , , , , , , , >.MJALLJIAKEA))]
	private Task<BMFECDODLAB<object, JLOPLHOLGBP>> EHIPINPMEDE(TRoot DADDPLMNJHB, KENIFKLGBBB<IKBGAEAMJPD> DOJPOBHEMAE, TAction[] FJHJEKPJEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3F4BD70", Offset = "0x3F4B170", VA = "0x183F4BD70")]
	[AsyncStateMachine(typeof(FJENEOBEPBC<, , , , , , , , >.JMAAJDGGFMI))]
	public Task<BMFECDODLAB<object, JLOPLHOLGBP>> LLGNKLNMIFH(TRoot DADDPLMNJHB, TNetSys ICLJBILNALC, TReceiver PDCCDIALKJH, KENIFKLGBBB<IKBGAEAMJPD> DOJPOBHEMAE, KENIFKLGBBB<TMRequest> DCJGAMKMPOI, TAction LLIKOHELCCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3F4C0F0", Offset = "0x3F4B4F0", VA = "0x183F4C0F0")]
	[AsyncStateMachine(typeof(FJENEOBEPBC<, , , , , , , , >.MJAELFECPDB))]
	private Task<BMFECDODLAB<object, JLOPLHOLGBP>> OIMLHFHNFMD(TRoot DADDPLMNJHB, TNetSys ICLJBILNALC, TReceiver PDCCDIALKJH, KENIFKLGBBB<IKBGAEAMJPD> DOJPOBHEMAE, KENIFKLGBBB<TMRequest> DCJGAMKMPOI, TAction LLIKOHELCCA, Task MMKNGPENPFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3F4AF10", Offset = "0x3F4A310", VA = "0x183F4AF10")]
	[AsyncStateMachine(typeof(FJENEOBEPBC<, , , , , , , , >.JBODLDBAPJK))]
	private Task GBNLHCHIECM(TRoot DADDPLMNJHB, TNetSys ICLJBILNALC, TReceiver PDCCDIALKJH, TAction LLIKOHELCCA, FIBMNNHBNOC CFFNAELHFLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3F4A3B0", Offset = "0x3F497B0", VA = "0x183F4A3B0")]
	private void AENFJKKMPKH(TRoot DADDPLMNJHB, TNetSys ICLJBILNALC, TReceiver PDCCDIALKJH, KENIFKLGBBB<IKBGAEAMJPD> DOJPOBHEMAE, TAction LLIKOHELCCA, bool MEIJJENBGFE, bool DNDPMLMFFIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DMHNFCBKGOM
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface CBAFNPOPFMN<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LGJJFOOBKAC(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction AFCDHLBHDOJ(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction OEOHJLDHJEG(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> IAHBODCLPOH(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] CDPMCPOJPHM(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA, int KHMIHCMKKEI);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool OPFFEIMPPAN(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool CNMJFLKIHGD(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool OBDOBPLEAPB(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LPOPIEIHKMB(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool CKFLGAEOCJJ(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool DDCHHLOHJGD(TNetSys EFLFHDNJFEB, TAction LLIKOHELCCA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface AOBELAMNHIE<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps FBDAPLBGCIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps KOFGJEGGEDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps OKNNDHPKCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface BJABKOFPGKF<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		KENIFKLGBBB<IKBGAEAMJPD> EELNOPJGOGE(TReceiver PDCCDIALKJH);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<BMFECDODLAB<object, JLOPLHOLGBP>> LLGNKLNMIFH(TReceiver PDCCDIALKJH, TAction LLIKOHELCCA);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] NNGMOJEDNCN(TReceiver PDCCDIALKJH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface IGHBDNHKLDI<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EKAMFNLDHKN(TRoot DADDPLMNJHB);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int KKBPBLDNOIN(TRoot DADDPLMNJHB);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int IKAIBEECNKB(TRoot DADDPLMNJHB);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int LNPKJBJDMPB(TRoot DADDPLMNJHB);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void COIGBFNONDO(TRoot DADDPLMNJHB);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task IENABDLHCLG(TRoot DADDPLMNJHB, KENIFKLGBBB<IKBGAEAMJPD> DOJPOBHEMAE, KENIFKLGBBB<TMRequest> DCJGAMKMPOI, TAction LLIKOHELCCA, bool LNOFHBHDIMF = true);
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
