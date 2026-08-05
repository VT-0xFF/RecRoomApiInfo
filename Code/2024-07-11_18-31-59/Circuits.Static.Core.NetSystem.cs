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
public struct NNALBMOAPEL<TPartialAction, TFullAction, TDeps> where TDeps : GPIBJEINBNB.IBFEJCMJKFF<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] LANJJNPDEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int ONGPODKGJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps NMBACBFNMGF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x452D3D0", Offset = "0x452BDD0", VA = "0x18452D3D0")]
	internal NNALBMOAPEL(TPartialAction[] NEEFNDHHDAC, int JMBNCDFNBHF, TDeps HDLOJHGAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x452D320", Offset = "0x452BD20", VA = "0x18452D320")]
	public static NNALBMOAPEL<TPartialAction, TFullAction, TDeps> FJAAFKPDAIA(TDeps HDLOJHGAFKF)
	{
		return default(NNALBMOAPEL<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GPIBJEINBNB
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface IBFEJCMJKFF<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GEOIAHKMJPE([In] TPartialAction EBPHBAJHNIM);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction CAIEFBPKLDE(TPartialAction[] BEICJDDBGNE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B37190", Offset = "0x2B35B90", VA = "0x182B37190")]
	public static PLBAMKEJCKB<TFullAction> PJJDGIFDOLF<TFullAction, TPartialAction, TDeps>(this NNALBMOAPEL<TPartialAction, TFullAction, TDeps> HIKEOGPAJAF, TPartialAction EBPHBAJHNIM) where TDeps : IBFEJCMJKFF<TPartialAction, TFullAction>
	{
		return default(PLBAMKEJCKB<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DKAGDPKCHEF<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : EJBFEDDIODK.NJPJNNKBBFL<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] BNMGGCFEEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int KIHCDFGEKMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps NMBACBFNMGF;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x452D3D0", Offset = "0x452BDD0", VA = "0x18452D3D0")]
	internal DKAGDPKCHEF(TPartialSnapshot[] BHGMNBCHAMC, int IODHLICCBPA, TDeps HDLOJHGAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x452D320", Offset = "0x452BD20", VA = "0x18452D320")]
	public static DKAGDPKCHEF<TPartialSnapshot, TFullSnapshot, TDeps> FJAAFKPDAIA(TDeps HDLOJHGAFKF)
	{
		return default(DKAGDPKCHEF<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EJBFEDDIODK
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface NJPJNNKBBFL<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int MNKCPHGODIC([In] TPartialSnapshot DEIICICJMCN);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot NGMHHADMOED(TPartialSnapshot[] CJPEDMBAKEN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x29AC400", Offset = "0x29AAE00", VA = "0x1829AC400")]
	public static PLBAMKEJCKB<TFullSnapshot> PJJDGIFDOLF<TFullSnapshot, TPartialSnapshot, TDeps>(this DKAGDPKCHEF<TPartialSnapshot, TFullSnapshot, TDeps> HIKEOGPAJAF, TPartialSnapshot DEIICICJMCN) where TDeps : NJPJNNKBBFL<TPartialSnapshot, TFullSnapshot>
	{
		return default(PLBAMKEJCKB<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x29AC2C0", Offset = "0x29AACC0", VA = "0x1829AC2C0")]
	public static bool NLFFDBHDIAE<TPartialSnapshot, TFullSnapshot, TDeps>(this DKAGDPKCHEF<TPartialSnapshot, TFullSnapshot, TDeps> HIKEOGPAJAF, TPartialSnapshot DEIICICJMCN) where TDeps : NJPJNNKBBFL<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class MOGLHPMGFHC : DOBPMPCGNAB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD200", Offset = "0x1FDBC00", VA = "0x181FDD200", Slot = "7")]
	public override string AGNLMABPEGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1FDD230", Offset = "0x1FDBC30", VA = "0x181FDD230")]
	public MOGLHPMGFHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class PPBKEIKDHJM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : HJHGMLKHPOE.KHKCBMHCLGM<TAction, TNetSys> where TReceiverDeps : HJHGMLKHPOE.DKDDLAMNMLD<TAction, TReceiver> where TRootDeps : HJHGMLKHPOE.BEEJLLGGPFN<TMRequest, TAction, TRoot> where TDeps : HJHGMLKHPOE.NLLCDGOKJBK<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface DKBLHAABJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void NLBFIOIHIMJ([In] CIKECDEKJAI<object, JPLAIBFIFBK> ADPMAHMCGNH);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IMMLLGAJLGD();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		CIKECDEKJAI<object, JPLAIBFIFBK> JFGDGLFIMOB();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void OPDCOOFJOKK(Exception PBAHBFAICPK);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class HECILKPPFGH : DKBLHAABJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<CIKECDEKJAI<object, JPLAIBFIFBK>> ODJECDNPNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<CIKECDEKJAI<object, IKKDIOOIDLA>> MPGFKLKAFOO;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D062E0", Offset = "0x3D04CE0", VA = "0x183D062E0")]
		private HECILKPPFGH(TaskCompletionSource<CIKECDEKJAI<object, JPLAIBFIFBK>> HGLIGDFKLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D05B30", Offset = "0x3D04530", VA = "0x183D05B30")]
		public static HECILKPPFGH FJAAFKPDAIA(TaskCompletionSource<CIKECDEKJAI<object, JPLAIBFIFBK>> HGLIGDFKLOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D05F60", Offset = "0x3D04960", VA = "0x183D05F60")]
		public void NLBFIOIHIMJ([In] CIKECDEKJAI<object, JPLAIBFIFBK> ADPMAHMCGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D05D20", Offset = "0x3D04720", VA = "0x183D05D20", Slot = "5")]
		public void IMMLLGAJLGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D05EB0", Offset = "0x3D048B0", VA = "0x183D05EB0", Slot = "6")]
		public CIKECDEKJAI<object, JPLAIBFIFBK> JFGDGLFIMOB()
		{
			return default(CIKECDEKJAI<object, JPLAIBFIFBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D06180", Offset = "0x3D04B80", VA = "0x183D06180", Slot = "7")]
		public void OPDCOOFJOKK(Exception PBAHBFAICPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3D05C00", Offset = "0x3D04600", VA = "0x183D05C00", Slot = "4")]
		private void GLBEEOCEFFE([In] CIKECDEKJAI<object, JPLAIBFIFBK> ADPMAHMCGNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class OIBJCKMOALL : DKBLHAABJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<CIKECDEKJAI<object, JPLAIBFIFBK>> ODJECDNPNBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private CIKECDEKJAI<object, JPLAIBFIFBK> BIEOIMEAKNF;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8531E0", Offset = "0x851BE0", VA = "0x1808531E0")]
		private OIBJCKMOALL(TaskCompletionSource<CIKECDEKJAI<object, JPLAIBFIFBK>> HGLIGDFKLOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x3D05B30", Offset = "0x3D04530", VA = "0x183D05B30")]
		public static OIBJCKMOALL FJAAFKPDAIA(TaskCompletionSource<CIKECDEKJAI<object, JPLAIBFIFBK>> HGLIGDFKLOI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x46368A0", Offset = "0x46352A0", VA = "0x1846368A0")]
		public void NLBFIOIHIMJ([In] CIKECDEKJAI<object, JPLAIBFIFBK> ADPMAHMCGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x4636840", Offset = "0x4635240", VA = "0x184636840", Slot = "5")]
		public void IMMLLGAJLGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xC35880", Offset = "0xC34280", VA = "0x180C35880", Slot = "6")]
		public CIKECDEKJAI<object, JPLAIBFIFBK> JFGDGLFIMOB()
		{
			return default(CIKECDEKJAI<object, JPLAIBFIFBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x46368C0", Offset = "0x46352C0", VA = "0x1846368C0", Slot = "7")]
		public void OPDCOOFJOKK(Exception PBAHBFAICPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3D05C00", Offset = "0x3D04600", VA = "0x183D05C00", Slot = "4")]
		private void GLBEEOCEFFE([In] CIKECDEKJAI<object, JPLAIBFIFBK> ADPMAHMCGNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class IJJHAHBBMOF : DKBLHAABJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<CIKECDEKJAI<object, JPLAIBFIFBK>> MPGFKLKAFOO;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2540", Offset = "0x3EC0F40", VA = "0x183EC2540")]
		private IJJHAHBBMOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3EC20D0", Offset = "0x3EC0AD0", VA = "0x183EC20D0")]
		public static IJJHAHBBMOF FJAAFKPDAIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2250", Offset = "0x3EC0C50", VA = "0x183EC2250")]
		public void NLBFIOIHIMJ([In] CIKECDEKJAI<object, JPLAIBFIFBK> ADPMAHMCGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		public void IMMLLGAJLGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3EC21F0", Offset = "0x3EC0BF0", VA = "0x183EC21F0", Slot = "6")]
		public CIKECDEKJAI<object, JPLAIBFIFBK> JFGDGLFIMOB()
		{
			return default(CIKECDEKJAI<object, JPLAIBFIFBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2460", Offset = "0x3EC0E60", VA = "0x183EC2460", Slot = "7")]
		[EGHHEKDFLLK("This may be terminal and should probably do more than discarding the exception.")]
		public void OPDCOOFJOKK(Exception PBAHBFAICPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3D05C00", Offset = "0x3D04600", VA = "0x183D05C00", Slot = "4")]
		private void GLBEEOCEFFE([In] CIKECDEKJAI<object, JPLAIBFIFBK> ADPMAHMCGNH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class NHIIMMHJLFN : DKBLHAABJIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CIKECDEKJAI<object, JPLAIBFIFBK> BIEOIMEAKNF;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859780", VA = "0x18085AD80")]
		private NHIIMMHJLFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3EC20D0", Offset = "0x3EC0AD0", VA = "0x183EC20D0")]
		public static NHIIMMHJLFN FJAAFKPDAIA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x16F8A90", Offset = "0x16F7490", VA = "0x1816F8A90")]
		public void NLBFIOIHIMJ([In] CIKECDEKJAI<object, JPLAIBFIFBK> ADPMAHMCGNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x852C90", VA = "0x180854290", Slot = "5")]
		public void IMMLLGAJLGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8C9DB0", Offset = "0x8C87B0", VA = "0x1808C9DB0", Slot = "6")]
		public CIKECDEKJAI<object, JPLAIBFIFBK> JFGDGLFIMOB()
		{
			return default(CIKECDEKJAI<object, JPLAIBFIFBK>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x450B5B0", Offset = "0x4509FB0", VA = "0x18450B5B0", Slot = "7")]
		[EGHHEKDFLLK("This may be terminal and should probably do more than discarding the exception.")]
		public void OPDCOOFJOKK(Exception PBAHBFAICPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D05C00", Offset = "0x3D04600", VA = "0x183D05C00", Slot = "4")]
		private void GLBEEOCEFFE([In] CIKECDEKJAI<object, JPLAIBFIFBK> ADPMAHMCGNH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct AKDIILCNADC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<object, JPLAIBFIFBK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public PPBKEIKDHJM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public OMNCLBBEMMM<CPLLDAKAGLA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<CIKECDEKJAI<object, JPLAIBFIFBK>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<CIKECDEKJAI<object, JPLAIBFIFBK>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C7D2D0", Offset = "0x3C7BCD0", VA = "0x183C7D2D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3C7DD30", Offset = "0x3C7C730", VA = "0x183C7DD30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct KBCKACJBNKB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<object, JPLAIBFIFBK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public PPBKEIKDHJM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public OMNCLBBEMMM<CPLLDAKAGLA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<CIKECDEKJAI<object, JPLAIBFIFBK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x41615F0", Offset = "0x415FFF0", VA = "0x1841615F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4161EB0", Offset = "0x41608B0", VA = "0x184161EB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct BEFHNPDCKCB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<object, JPLAIBFIFBK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public PPBKEIKDHJM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public OMNCLBBEMMM<CPLLDAKAGLA> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public OMNCLBBEMMM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<CIKECDEKJAI<object, JPLAIBFIFBK>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4E02010", Offset = "0x4E00A10", VA = "0x184E02010", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4E026E0", Offset = "0x4E010E0", VA = "0x184E026E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct MOHDJKMMBPM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<CIKECDEKJAI<object, JPLAIBFIFBK>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public PPBKEIKDHJM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OMNCLBBEMMM<CPLLDAKAGLA> senderId;

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
		public OMNCLBBEMMM<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private DKBLHAABJIB <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x44AFDB0", Offset = "0x44AE7B0", VA = "0x1844AFDB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x44B0A40", Offset = "0x44AF440", VA = "0x1844B0A40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct LFKCIMLIMIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public PPBKEIKDHJM<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public DKBLHAABJIB completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private DKBLHAABJIB <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<CIKECDEKJAI<object, JPLAIBFIFBK>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4233940", Offset = "0x4232340", VA = "0x184233940", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4235890", Offset = "0x4234290", VA = "0x184235890", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps NMBACBFNMGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<OMNCLBBEMMM<TMRequest>, TaskCompletionSource<CIKECDEKJAI<object, JPLAIBFIFBK>>> HFANNHLAKNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KLMBMPAMAJD<TMRequest> JGFNPBCMFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int KKKKDMEBCOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task CGLDGLIACFF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps NGFLOGGNBAG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4774DB0", Offset = "0x47737B0", VA = "0x184774DB0")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps BFPBHECDOFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4775190", Offset = "0x4773B90", VA = "0x184775190")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps HNKGMLAHEFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x47750C0", Offset = "0x4773AC0", VA = "0x1847750C0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool JHIFHMLJGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x91F510", Offset = "0x91DF10", VA = "0x18091F510")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x138D830", Offset = "0x138C230", VA = "0x18138D830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool OPHDPPHDGBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xF30070", Offset = "0xF2EA70", VA = "0x180F30070")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1E83430", Offset = "0x1E81E30", VA = "0x181E83430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GKPHPPHMGPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x852880", Offset = "0x851280", VA = "0x180852880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4776D40", Offset = "0x4775740", VA = "0x184776D40")]
	public PPBKEIKDHJM(TDeps HDLOJHGAFKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4775930", Offset = "0x4774330", VA = "0x184775930")]
	public Task<CIKECDEKJAI<object, JPLAIBFIFBK>> JDILNABPKMM(TRoot GFFCILHEGII, TNetSys EAIOFODMLHP, OMNCLBBEMMM<CPLLDAKAGLA> OHGHBMACDMM, TAction ENGMCBPHJGL, bool HHAONNAJEPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x47751C0", Offset = "0x4773BC0", VA = "0x1847751C0")]
	[AsyncStateMachine(typeof(PPBKEIKDHJM<, , , , , , , , >.AKDIILCNADC))]
	private Task<CIKECDEKJAI<object, JPLAIBFIFBK>> JDILNABPKMM(TRoot GFFCILHEGII, OMNCLBBEMMM<CPLLDAKAGLA> OHGHBMACDMM, TAction ENGMCBPHJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4775C70", Offset = "0x4774670", VA = "0x184775C70")]
	[AsyncStateMachine(typeof(PPBKEIKDHJM<, , , , , , , , >.KBCKACJBNKB))]
	private Task<CIKECDEKJAI<object, JPLAIBFIFBK>> MEFOAINIGMJ(TRoot GFFCILHEGII, OMNCLBBEMMM<CPLLDAKAGLA> OHGHBMACDMM, TAction[] AEGEDHFMEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4774DE0", Offset = "0x47737E0", VA = "0x184774DE0")]
	[AsyncStateMachine(typeof(PPBKEIKDHJM<, , , , , , , , >.BEFHNPDCKCB))]
	public Task<CIKECDEKJAI<object, JPLAIBFIFBK>> HONNAGCNNPF(TRoot GFFCILHEGII, TNetSys GKFFCIFEHJP, TReceiver JGBHEKHPCJH, OMNCLBBEMMM<CPLLDAKAGLA> OHGHBMACDMM, OMNCLBBEMMM<TMRequest> BPFNHEMHBMJ, TAction ENGMCBPHJGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4775F30", Offset = "0x4774930", VA = "0x184775F30")]
	[AsyncStateMachine(typeof(PPBKEIKDHJM<, , , , , , , , >.MOHDJKMMBPM))]
	private Task<CIKECDEKJAI<object, JPLAIBFIFBK>> MLPJBHINHDE(TRoot GFFCILHEGII, TNetSys GKFFCIFEHJP, TReceiver JGBHEKHPCJH, OMNCLBBEMMM<CPLLDAKAGLA> OHGHBMACDMM, OMNCLBBEMMM<TMRequest> BPFNHEMHBMJ, TAction ENGMCBPHJGL, Task IIFBHCBCLPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4776240", Offset = "0x4774C40", VA = "0x184776240")]
	[AsyncStateMachine(typeof(PPBKEIKDHJM<, , , , , , , , >.LFKCIMLIMIO))]
	private Task NDEDEGNDGMA(TRoot GFFCILHEGII, TNetSys GKFFCIFEHJP, TReceiver JGBHEKHPCJH, TAction ENGMCBPHJGL, DKBLHAABJIB KBCNPHGBDBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x47768B0", Offset = "0x47752B0", VA = "0x1847768B0")]
	private void PBLEHGPAEID(TRoot GFFCILHEGII, TNetSys GKFFCIFEHJP, TReceiver JGBHEKHPCJH, OMNCLBBEMMM<CPLLDAKAGLA> OHGHBMACDMM, TAction ENGMCBPHJGL, bool BIALPGIILEO, bool LBMBEDOFGMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HJHGMLKHPOE
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface KHKCBMHCLGM<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BMJGKLMMDOP(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction PILNAPLBMAK(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction PJPJOGJHKHO(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> OCCFEBBCDIH(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] HJOFJIIAFHM(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL, int BPBLDMFACIA);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool LHHLGELECBG(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool LCGIAALICAG(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool EIMJECAMFKH(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool NJLNPHBFPMM(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool BLCHFKEHLBM(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool CMHGCEOKDNF(TNetSys PEDLJBODJFP, TAction ENGMCBPHJGL);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface NLLCDGOKJBK<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps NGFLOGGNBAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps HNKGMLAHEFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps BFPBHECDOFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface DKDDLAMNMLD<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		OMNCLBBEMMM<CPLLDAKAGLA> KLBJCNKKFAC(TReceiver JGBHEKHPCJH);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<CIKECDEKJAI<object, JPLAIBFIFBK>> HONNAGCNNPF(TReceiver JGBHEKHPCJH, TAction ENGMCBPHJGL);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] IGNHIMONNAA(TReceiver JGBHEKHPCJH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface BEEJLLGGPFN<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int LIEPDEGIDBD(TRoot GFFCILHEGII);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int GGFBBDAJGMB(TRoot GFFCILHEGII);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int MFLKNPFDMFA(TRoot GFFCILHEGII);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int DFDCGCGGOJG(TRoot GFFCILHEGII);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HPJKBHDDFNL(TRoot GFFCILHEGII);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task JDILNABPKMM(TRoot GFFCILHEGII, OMNCLBBEMMM<CPLLDAKAGLA> OHGHBMACDMM, OMNCLBBEMMM<TMRequest> BPFNHEMHBMJ, TAction ENGMCBPHJGL, bool GBGBADDPMEI = true);
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
