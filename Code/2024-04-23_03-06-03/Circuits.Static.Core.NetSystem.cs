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
public struct APNIJPPCFEG<TPartialAction, TFullAction, TDeps> where TDeps : CDBEEEPBPDM.PDCEGMLCCAE<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] EKFCOHCBLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int PKMLEFFHCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps KOPMBDPCNDC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3B796E0", Offset = "0x3B786E0", VA = "0x183B796E0")]
	internal APNIJPPCFEG(TPartialAction[] EBNMNBIBCNP, int OOEKHGKMPAA, TDeps AKOGIKBAMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B79610", Offset = "0x3B78610", VA = "0x183B79610")]
	public static APNIJPPCFEG<TPartialAction, TFullAction, TDeps> MGIIAIMPALM(TDeps AKOGIKBAMPF)
	{
		return default(APNIJPPCFEG<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CDBEEEPBPDM
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface PDCEGMLCCAE<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int EMGDPNFMMIF([In] TPartialAction HBFCNHNFFJK);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction KHCDGNEHBGC(TPartialAction[] JIGCHIFJPAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27165D0", Offset = "0x27155D0", VA = "0x1827165D0")]
	public static HLIMGIIJKHF<TFullAction> KJGKKOMLPGF<TFullAction, TPartialAction, TDeps>(this APNIJPPCFEG<TPartialAction, TFullAction, TDeps> HFLBADIEKAM, TPartialAction HBFCNHNFFJK) where TDeps : PDCEGMLCCAE<TPartialAction, TFullAction>
	{
		return default(HLIMGIIJKHF<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LHEEGJKKNFO<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : GGLGLEILEOB.DDHPGJCGFAM<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] ANKICGFPEBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int NPPCICPHAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps KOPMBDPCNDC;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B796E0", Offset = "0x3B786E0", VA = "0x183B796E0")]
	internal LHEEGJKKNFO(TPartialSnapshot[] DFODIFJGNDD, int JGJCMAMGKIE, TDeps AKOGIKBAMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B79610", Offset = "0x3B78610", VA = "0x183B79610")]
	public static LHEEGJKKNFO<TPartialSnapshot, TFullSnapshot, TDeps> MGIIAIMPALM(TDeps AKOGIKBAMPF)
	{
		return default(LHEEGJKKNFO<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GGLGLEILEOB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface DDHPGJCGFAM<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MCDGFKPIOGK([In] TPartialSnapshot MIKACEEKFPN);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot ONKDELKGFKO(TPartialSnapshot[] PBFOFJKBGEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28B9020", Offset = "0x28B8020", VA = "0x1828B9020")]
	public static HLIMGIIJKHF<TFullSnapshot> KJGKKOMLPGF<TFullSnapshot, TPartialSnapshot, TDeps>(this LHEEGJKKNFO<TPartialSnapshot, TFullSnapshot, TDeps> HFLBADIEKAM, TPartialSnapshot MIKACEEKFPN) where TDeps : DDHPGJCGFAM<TPartialSnapshot, TFullSnapshot>
	{
		return default(HLIMGIIJKHF<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28B8ED0", Offset = "0x28B7ED0", VA = "0x1828B8ED0")]
	public static bool JKBJCJAJMOL<TPartialSnapshot, TFullSnapshot, TDeps>(this LHEEGJKKNFO<TPartialSnapshot, TFullSnapshot, TDeps> HFLBADIEKAM, TPartialSnapshot MIKACEEKFPN) where TDeps : DDHPGJCGFAM<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class OODCHIKANEG : AKCFNDEBMDK
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E53280", Offset = "0x1E52280", VA = "0x181E53280", Slot = "7")]
	public override string MGJEJBNDCKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1E532B0", Offset = "0x1E522B0", VA = "0x181E532B0")]
	public OODCHIKANEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class NBKDFPIFALM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : PANFIKCELOA.JFENMMDKPJE<TAction, TNetSys> where TReceiverDeps : PANFIKCELOA.HGLACLICILB<TAction, TReceiver> where TRootDeps : PANFIKCELOA.NIACGPIKPAN<TMRequest, TAction, TRoot> where TDeps : PANFIKCELOA.BGPIBJKKPNL<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface FGNMFJONLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FJMPDCHHEMO([In] PGLGENBDGKP<object, AABLFGLHLFL> NIKEINPNLMA);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBLGIJGFGKB();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PGLGENBDGKP<object, AABLFGLHLFL> AKBMLEEIDOF();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JHOHHNIJFKP(Exception DNFOGIGBCCD);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class LHGNDAKHAPG : FGNMFJONLKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<PGLGENBDGKP<object, AABLFGLHLFL>> OBHPMKMADBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<PGLGENBDGKP<object, HHPFBBGIKCL>> EDIMMICHDNP;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E34860", Offset = "0x3E33860", VA = "0x183E34860")]
		private LHGNDAKHAPG(TaskCompletionSource<PGLGENBDGKP<object, AABLFGLHLFL>> JOFPLCMGHII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E16EC0", Offset = "0x3E15EC0", VA = "0x183E16EC0")]
		public static LHGNDAKHAPG MGIIAIMPALM(TaskCompletionSource<PGLGENBDGKP<object, AABLFGLHLFL>> JOFPLCMGHII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E34340", Offset = "0x3E33340", VA = "0x183E34340")]
		public void FJMPDCHHEMO([In] PGLGENBDGKP<object, AABLFGLHLFL> NIKEINPNLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3E346E0", Offset = "0x3E336E0", VA = "0x183E346E0", Slot = "5")]
		public void OBLGIJGFGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E341E0", Offset = "0x3E331E0", VA = "0x183E341E0", Slot = "6")]
		public PGLGENBDGKP<object, AABLFGLHLFL> AKBMLEEIDOF()
		{
			return default(PGLGENBDGKP<object, AABLFGLHLFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3E34540", Offset = "0x3E33540", VA = "0x183E34540", Slot = "7")]
		public void JHOHHNIJFKP(Exception DNFOGIGBCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B200", Offset = "0x3A2A200", VA = "0x183A2B200", Slot = "4")]
		private void EEKGEIGGCFA([In] PGLGENBDGKP<object, AABLFGLHLFL> NIKEINPNLMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class DMNCHGGJNFE : FGNMFJONLKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<PGLGENBDGKP<object, AABLFGLHLFL>> OBHPMKMADBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private PGLGENBDGKP<object, AABLFGLHLFL> OCHFCILEMEH;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C50", Offset = "0x7C8C50", VA = "0x1807C9C50")]
		private DMNCHGGJNFE(TaskCompletionSource<PGLGENBDGKP<object, AABLFGLHLFL>> JOFPLCMGHII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3E16EC0", Offset = "0x3E15EC0", VA = "0x183E16EC0")]
		public static DMNCHGGJNFE MGIIAIMPALM(TaskCompletionSource<PGLGENBDGKP<object, AABLFGLHLFL>> JOFPLCMGHII)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x399DEA0", Offset = "0x399CEA0", VA = "0x18399DEA0")]
		public void FJMPDCHHEMO([In] PGLGENBDGKP<object, AABLFGLHLFL> NIKEINPNLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5212790", Offset = "0x5211790", VA = "0x185212790", Slot = "5")]
		public void OBLGIJGFGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAE6AD0", Offset = "0xAE5AD0", VA = "0x180AE6AD0", Slot = "6")]
		public PGLGENBDGKP<object, AABLFGLHLFL> AKBMLEEIDOF()
		{
			return default(PGLGENBDGKP<object, AABLFGLHLFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5212670", Offset = "0x5211670", VA = "0x185212670", Slot = "7")]
		public void JHOHHNIJFKP(Exception DNFOGIGBCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B200", Offset = "0x3A2A200", VA = "0x183A2B200", Slot = "4")]
		private void EEKGEIGGCFA([In] PGLGENBDGKP<object, AABLFGLHLFL> NIKEINPNLMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class AIPIKDCELOO : FGNMFJONLKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<PGLGENBDGKP<object, AABLFGLHLFL>> EDIMMICHDNP;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B520", Offset = "0x3A2A520", VA = "0x183A2B520")]
		private AIPIKDCELOO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B460", Offset = "0x3A2A460", VA = "0x183A2B460")]
		public static AIPIKDCELOO MGIIAIMPALM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B220", Offset = "0x3A2A220", VA = "0x183A2B220")]
		public void FJMPDCHHEMO([In] PGLGENBDGKP<object, AABLFGLHLFL> NIKEINPNLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		public void OBLGIJGFGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B140", Offset = "0x3A2A140", VA = "0x183A2B140", Slot = "6")]
		public PGLGENBDGKP<object, AABLFGLHLFL> AKBMLEEIDOF()
		{
			return default(PGLGENBDGKP<object, AABLFGLHLFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B410", Offset = "0x3A2A410", VA = "0x183A2B410", Slot = "7")]
		[HHGFKKBEMKA("This may be terminal and should probably do more than discarding the exception.")]
		public void JHOHHNIJFKP(Exception DNFOGIGBCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B200", Offset = "0x3A2A200", VA = "0x183A2B200", Slot = "4")]
		private void EEKGEIGGCFA([In] PGLGENBDGKP<object, AABLFGLHLFL> NIKEINPNLMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class MMFJPLKGNEA : FGNMFJONLKG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PGLGENBDGKP<object, AABLFGLHLFL> OCHFCILEMEH;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		private MMFJPLKGNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B460", Offset = "0x3A2A460", VA = "0x183A2B460")]
		public static MMFJPLKGNEA MGIIAIMPALM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1562C40", Offset = "0x1561C40", VA = "0x181562C40")]
		public void FJMPDCHHEMO([In] PGLGENBDGKP<object, AABLFGLHLFL> NIKEINPNLMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C0", Offset = "0x7BF6C0", VA = "0x1807C06C0", Slot = "5")]
		public void OBLGIJGFGKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85B1E0", Offset = "0x85A1E0", VA = "0x18085B1E0", Slot = "6")]
		public PGLGENBDGKP<object, AABLFGLHLFL> AKBMLEEIDOF()
		{
			return default(PGLGENBDGKP<object, AABLFGLHLFL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x40532C0", Offset = "0x40522C0", VA = "0x1840532C0", Slot = "7")]
		[HHGFKKBEMKA("This may be terminal and should probably do more than discarding the exception.")]
		public void JHOHHNIJFKP(Exception DNFOGIGBCCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3A2B200", Offset = "0x3A2A200", VA = "0x183A2B200", Slot = "4")]
		private void EEKGEIGGCFA([In] PGLGENBDGKP<object, AABLFGLHLFL> NIKEINPNLMA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct EIKBPLFFILI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public NBKDFPIFALM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public JLADLGKIDDG<CEBMMKCJHFK> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<PGLGENBDGKP<object, AABLFGLHLFL>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3511550", Offset = "0x3510550", VA = "0x183511550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3511A90", Offset = "0x3510A90", VA = "0x183511A90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct DANMHAJNPIE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public NBKDFPIFALM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public JLADLGKIDDG<CEBMMKCJHFK> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x51E3710", Offset = "0x51E2710", VA = "0x1851E3710", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51E3F90", Offset = "0x51E2F90", VA = "0x1851E3F90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct IBACOPPCCED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public NBKDFPIFALM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public JLADLGKIDDG<CEBMMKCJHFK> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public JLADLGKIDDG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3AC81D0", Offset = "0x3AC71D0", VA = "0x183AC81D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3AC8530", Offset = "0x3AC7530", VA = "0x183AC8530", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct JFDBJGJDIAN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<PGLGENBDGKP<object, AABLFGLHLFL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public NBKDFPIFALM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public JLADLGKIDDG<CEBMMKCJHFK> senderId;

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
		public JLADLGKIDDG<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private FGNMFJONLKG <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3CCD520", Offset = "0x3CCC520", VA = "0x183CCD520", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE0B0", Offset = "0x3CCD0B0", VA = "0x183CCE0B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct EBOLHNFHHLI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public NBKDFPIFALM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public FGNMFJONLKG completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private FGNMFJONLKG <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<PGLGENBDGKP<object, AABLFGLHLFL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x34E14D0", Offset = "0x34E04D0", VA = "0x1834E14D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x34E3290", Offset = "0x34E2290", VA = "0x1834E3290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps KOPMBDPCNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<JLADLGKIDDG<TMRequest>, TaskCompletionSource<PGLGENBDGKP<object, AABLFGLHLFL>>> MMJNMPGOOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private BFOCNJPLFGH<TMRequest> OHPMENBMMGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int JPKDIJNCHME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task CPOELMAAPMO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps HGOFKJNNKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x40A7A10", Offset = "0x40A6A10", VA = "0x1840A7A10")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps CENMONGNENA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x40A7A90", Offset = "0x40A6A90", VA = "0x1840A7A90")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps DFBIGDGGAIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x40A6A70", Offset = "0x40A5A70", VA = "0x1840A6A70")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool ODCFOGNNDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDFAE80", Offset = "0xDF9E80", VA = "0x180DFAE80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11EEAE0", Offset = "0x11EDAE0", VA = "0x1811EEAE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool CFGMBKKOAMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDFE910", Offset = "0xDFD910", VA = "0x180DFE910")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BEF0", Offset = "0x1D1AEF0", VA = "0x181D1BEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AGCFBECGKHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D80", Offset = "0x7C1D80", VA = "0x1807C2D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x40A7C70", Offset = "0x40A6C70", VA = "0x1840A7C70")]
	public NBKDFPIFALM(TDeps AKOGIKBAMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x40A6750", Offset = "0x40A5750", VA = "0x1840A6750")]
	public Task<PGLGENBDGKP<object, AABLFGLHLFL>> EFJMJBOLMPC(TRoot OPFDMIOAEHD, TNetSys OKIEBCDCDHI, JLADLGKIDDG<CEBMMKCJHFK> JHPCJGNGKKC, TAction LNMJHEPMAAO, bool NELCJLCCKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x40A5FE0", Offset = "0x40A4FE0", VA = "0x1840A5FE0")]
	[AsyncStateMachine(typeof(NBKDFPIFALM<, , , , , , , , >.EIKBPLFFILI))]
	private Task<PGLGENBDGKP<object, AABLFGLHLFL>> EFJMJBOLMPC(TRoot OPFDMIOAEHD, JLADLGKIDDG<CEBMMKCJHFK> JHPCJGNGKKC, TAction LNMJHEPMAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x40A5D20", Offset = "0x40A4D20", VA = "0x1840A5D20")]
	[AsyncStateMachine(typeof(NBKDFPIFALM<, , , , , , , , >.DANMHAJNPIE))]
	private Task<PGLGENBDGKP<object, AABLFGLHLFL>> CJKOMDBAJEM(TRoot OPFDMIOAEHD, JLADLGKIDDG<CEBMMKCJHFK> JHPCJGNGKKC, TAction[] IBDAFFKKFFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x40A6AF0", Offset = "0x40A5AF0", VA = "0x1840A6AF0")]
	[AsyncStateMachine(typeof(NBKDFPIFALM<, , , , , , , , >.IBACOPPCCED))]
	public Task<PGLGENBDGKP<object, AABLFGLHLFL>> HJHJPPHLNNE(TRoot OPFDMIOAEHD, TNetSys LKLBIOHNOCC, TReceiver DKHAKCOFILG, JLADLGKIDDG<CEBMMKCJHFK> JHPCJGNGKKC, JLADLGKIDDG<TMRequest> CFKKHALFKIN, TAction LNMJHEPMAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x40A7890", Offset = "0x40A6890", VA = "0x1840A7890")]
	[AsyncStateMachine(typeof(NBKDFPIFALM<, , , , , , , , >.JFDBJGJDIAN))]
	private Task<PGLGENBDGKP<object, AABLFGLHLFL>> LCBELGEDNFO(TRoot OPFDMIOAEHD, TNetSys LKLBIOHNOCC, TReceiver DKHAKCOFILG, JLADLGKIDDG<CEBMMKCJHFK> JHPCJGNGKKC, JLADLGKIDDG<TMRequest> CFKKHALFKIN, TAction LNMJHEPMAAO, Task KPEMEIEKKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x40A7450", Offset = "0x40A6450", VA = "0x1840A7450")]
	[AsyncStateMachine(typeof(NBKDFPIFALM<, , , , , , , , >.EBOLHNFHHLI))]
	private Task IDJJNCNNHNF(TRoot OPFDMIOAEHD, TNetSys LKLBIOHNOCC, TReceiver DKHAKCOFILG, TAction LNMJHEPMAAO, FGNMFJONLKG CLPDDBBIJOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x40A6DE0", Offset = "0x40A5DE0", VA = "0x1840A6DE0")]
	private void HPOKLJGJIIC(TRoot OPFDMIOAEHD, TNetSys LKLBIOHNOCC, TReceiver DKHAKCOFILG, JLADLGKIDDG<CEBMMKCJHFK> JHPCJGNGKKC, TAction LNMJHEPMAAO, bool NJINCIOPLLK, bool GPMCDDDLBNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PANFIKCELOA
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface JFENMMDKPJE<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NLCKFPIPCLN(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction AFPEKIHPFIA(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction LIKIDGPCLFH(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> NOCLOJCOFJK(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] DPNHIBJMLDP(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO, int JHEAFPECNBF);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool MGKNJMOOMDI(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool EOFLJGNLOFA(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool JLDHKFMNEAE(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool CNIHGDEOGJB(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool KGLCIFHGHOJ(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool JNLIILBEGLG(TNetSys EICMBJAKFOM, TAction LNMJHEPMAAO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface BGPIBJKKPNL<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps HGOFKJNNKAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps DFBIGDGGAIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps CENMONGNENA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface HGLACLICILB<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		JLADLGKIDDG<CEBMMKCJHFK> NCNLCJFHPOL(TReceiver DKHAKCOFILG);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<PGLGENBDGKP<object, AABLFGLHLFL>> HJHJPPHLNNE(TReceiver DKHAKCOFILG, TAction LNMJHEPMAAO);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] AMGECOOEAHN(TReceiver DKHAKCOFILG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface NIACGPIKPAN<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MCEHINGHNDP(TRoot OPFDMIOAEHD);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int ILJKMCLBBPE(TRoot OPFDMIOAEHD);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MLDIMIGPNKE(TRoot OPFDMIOAEHD);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int OOCPONDDGJD(TRoot OPFDMIOAEHD);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void PPENEABGKHK(TRoot OPFDMIOAEHD);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task EFJMJBOLMPC(TRoot OPFDMIOAEHD, JLADLGKIDDG<CEBMMKCJHFK> JHPCJGNGKKC, JLADLGKIDDG<TMRequest> CFKKHALFKIN, TAction LNMJHEPMAAO, bool CKHNMCMHFHA = true);
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
