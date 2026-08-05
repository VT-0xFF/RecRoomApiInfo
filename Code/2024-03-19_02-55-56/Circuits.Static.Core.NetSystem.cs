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
public struct PKMDFGAIIKB<TPartialAction, TFullAction, TDeps> where TDeps : INBNDDOPJOA.AOKHMKDDCAN<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] PBMPCAJEJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int HNMBJNLEENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps KFNEOPKPPMN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x37AD0C0", Offset = "0x37AC0C0", VA = "0x1837AD0C0")]
	internal PKMDFGAIIKB(TPartialAction[] OCCMDDFJOEE, int OGKMLJLKHHN, TDeps DGILCEAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x37AD060", Offset = "0x37AC060", VA = "0x1837AD060")]
	public static PKMDFGAIIKB<TPartialAction, TFullAction, TDeps> NAJBLLJFKKI(TDeps DGILCEAPJEB)
	{
		return default(PKMDFGAIIKB<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class INBNDDOPJOA
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface AOKHMKDDCAN<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NDJFJACJLJL([In] TPartialAction GAJMMLHGDEF);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction DLNNKIMGDCP(TPartialAction[] HHEBLBBJLDN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27E44B0", Offset = "0x27E34B0", VA = "0x1827E44B0")]
	public static DCPPBKBIMOM<TFullAction> OKNFFDCNPBK<TFullAction, TPartialAction, TDeps>(this PKMDFGAIIKB<TPartialAction, TFullAction, TDeps> AOFEPADBPDL, TPartialAction GAJMMLHGDEF) where TDeps : AOKHMKDDCAN<TPartialAction, TFullAction>
	{
		return default(DCPPBKBIMOM<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct AKKCPNOIPOG<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : ABBFGNEEKLJ.FKNDIMPJDKP<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] DNPMCBOPMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int FOHMFCLMNIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps KFNEOPKPPMN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x37AD0C0", Offset = "0x37AC0C0", VA = "0x1837AD0C0")]
	internal AKKCPNOIPOG(TPartialSnapshot[] MIFEOMEKNDA, int AJEAOCBDGNI, TDeps DGILCEAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37AD060", Offset = "0x37AC060", VA = "0x1837AD060")]
	public static AKKCPNOIPOG<TPartialSnapshot, TFullSnapshot, TDeps> NAJBLLJFKKI(TDeps DGILCEAPJEB)
	{
		return default(AKKCPNOIPOG<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ABBFGNEEKLJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface FKNDIMPJDKP<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FEBBHAABEHD([In] TPartialSnapshot KNCNEEKLJHG);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot NKCBOEGAPNJ(TPartialSnapshot[] PILIOOGMMMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CE90", Offset = "0x2D7BE90", VA = "0x182D7CE90")]
	public static DCPPBKBIMOM<TFullSnapshot> OKNFFDCNPBK<TFullSnapshot, TPartialSnapshot, TDeps>(this AKKCPNOIPOG<TPartialSnapshot, TFullSnapshot, TDeps> AOFEPADBPDL, TPartialSnapshot KNCNEEKLJHG) where TDeps : FKNDIMPJDKP<TPartialSnapshot, TFullSnapshot>
	{
		return default(DCPPBKBIMOM<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2D7CD40", Offset = "0x2D7BD40", VA = "0x182D7CD40")]
	public static bool JIKKJFBBHIA<TPartialSnapshot, TFullSnapshot, TDeps>(this AKKCPNOIPOG<TPartialSnapshot, TFullSnapshot, TDeps> AOFEPADBPDL, TPartialSnapshot KNCNEEKLJHG) where TDeps : FKNDIMPJDKP<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class DJJOMKHDIIP : PHBMKBALCLH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7000", Offset = "0x1DE6000", VA = "0x181DE7000", Slot = "7")]
	public override string OJGKBMCMILI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DE7030", Offset = "0x1DE6030", VA = "0x181DE7030")]
	public DJJOMKHDIIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class PNNPHBHKBJP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : MNHPADLFMBH.NFNGKBOCLKH<TAction, TNetSys> where TReceiverDeps : MNHPADLFMBH.ELBMJLJLHFD<TMActor, TAction, TReceiver> where TRootDeps : MNHPADLFMBH.DKCOLKHHEGC<TMRequest, TMActor, TAction, TRoot> where TDeps : MNHPADLFMBH.KDINFPOFKDI<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface PANOFJGNLFN
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GFPEPECFICE([In] PBAOJGOHCMJ<object, OAAMPDEOGNE> HEOGODCLBDD);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OALAFIKALMK();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		PBAOJGOHCMJ<object, OAAMPDEOGNE> LNGCCEGGDLD();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void JKDPHDHDAKD(Exception NNMGILNOFJH);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class JJAOBCLHEOG : PANOFJGNLFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<PBAOJGOHCMJ<object, OAAMPDEOGNE>> BOOLAHNCPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<PBAOJGOHCMJ<object, BOFJPOKAPAE>> DIFFIFAGELI;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3B436F0", Offset = "0x3B426F0", VA = "0x183B436F0")]
		private JJAOBCLHEOG(TaskCompletionSource<PBAOJGOHCMJ<object, OAAMPDEOGNE>> BEBOGKEEMEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x33193D0", Offset = "0x33183D0", VA = "0x1833193D0")]
		public static JJAOBCLHEOG NAJBLLJFKKI(TaskCompletionSource<PBAOJGOHCMJ<object, OAAMPDEOGNE>> BEBOGKEEMEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3B43110", Offset = "0x3B42110", VA = "0x183B43110")]
		public void GFPEPECFICE([In] PBAOJGOHCMJ<object, OAAMPDEOGNE> HEOGODCLBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3B43610", Offset = "0x3B42610", VA = "0x183B43610", Slot = "5")]
		public void OALAFIKALMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3B433D0", Offset = "0x3B423D0", VA = "0x183B433D0", Slot = "6")]
		public PBAOJGOHCMJ<object, OAAMPDEOGNE> LNGCCEGGDLD()
		{
			return default(PBAOJGOHCMJ<object, OAAMPDEOGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3B43310", Offset = "0x3B42310", VA = "0x183B43310", Slot = "7")]
		public void JKDPHDHDAKD(Exception NNMGILNOFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3317130", Offset = "0x3316130", VA = "0x183317130", Slot = "4")]
		private void JLGMBBCCOMB([In] PBAOJGOHCMJ<object, OAAMPDEOGNE> HEOGODCLBDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class EIEDMNFEGBB : PANOFJGNLFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<PBAOJGOHCMJ<object, OAAMPDEOGNE>> BOOLAHNCPBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private PBAOJGOHCMJ<object, OAAMPDEOGNE> PJCNFIHEMCA;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C3080", Offset = "0x7C2080", VA = "0x1807C3080")]
		private EIEDMNFEGBB(TaskCompletionSource<PBAOJGOHCMJ<object, OAAMPDEOGNE>> BEBOGKEEMEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x33193D0", Offset = "0x33183D0", VA = "0x1833193D0")]
		public static EIEDMNFEGBB NAJBLLJFKKI(TaskCompletionSource<PBAOJGOHCMJ<object, OAAMPDEOGNE>> BEBOGKEEMEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x33192F0", Offset = "0x33182F0", VA = "0x1833192F0")]
		public void GFPEPECFICE([In] PBAOJGOHCMJ<object, OAAMPDEOGNE> HEOGODCLBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x33194A0", Offset = "0x33184A0", VA = "0x1833194A0", Slot = "5")]
		public void OALAFIKALMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xAE3DA0", Offset = "0xAE2DA0", VA = "0x180AE3DA0", Slot = "6")]
		public PBAOJGOHCMJ<object, OAAMPDEOGNE> LNGCCEGGDLD()
		{
			return default(PBAOJGOHCMJ<object, OAAMPDEOGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x3319310", Offset = "0x3318310", VA = "0x183319310", Slot = "7")]
		public void JKDPHDHDAKD(Exception NNMGILNOFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x3317130", Offset = "0x3316130", VA = "0x183317130", Slot = "4")]
		private void JLGMBBCCOMB([In] PBAOJGOHCMJ<object, OAAMPDEOGNE> HEOGODCLBDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class KJJMPEHFBLD : PANOFJGNLFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<PBAOJGOHCMJ<object, OAAMPDEOGNE>> DIFFIFAGELI;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x3C24120", Offset = "0x3C23120", VA = "0x183C24120")]
		private KJJMPEHFBLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3317150", Offset = "0x3316150", VA = "0x183317150")]
		public static KJJMPEHFBLD NAJBLLJFKKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3C23E60", Offset = "0x3C22E60", VA = "0x183C23E60")]
		public void GFPEPECFICE([In] PBAOJGOHCMJ<object, OAAMPDEOGNE> HEOGODCLBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public void OALAFIKALMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3C24030", Offset = "0x3C23030", VA = "0x183C24030", Slot = "6")]
		public PBAOJGOHCMJ<object, OAAMPDEOGNE> LNGCCEGGDLD()
		{
			return default(PBAOJGOHCMJ<object, OAAMPDEOGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3C23F80", Offset = "0x3C22F80", VA = "0x183C23F80", Slot = "7")]
		[HGNKAKLJIMO("This may be terminal and should probably do more than discarding the exception.")]
		public void JKDPHDHDAKD(Exception NNMGILNOFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3317130", Offset = "0x3316130", VA = "0x183317130", Slot = "4")]
		private void JLGMBBCCOMB([In] PBAOJGOHCMJ<object, OAAMPDEOGNE> HEOGODCLBDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class EFMGJCDNGCI : PANOFJGNLFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PBAOJGOHCMJ<object, OAAMPDEOGNE> PJCNFIHEMCA;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		private EFMGJCDNGCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3317150", Offset = "0x3316150", VA = "0x183317150")]
		public static EFMGJCDNGCI NAJBLLJFKKI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1512640", Offset = "0x1511640", VA = "0x181512640")]
		public void GFPEPECFICE([In] PBAOJGOHCMJ<object, OAAMPDEOGNE> HEOGODCLBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BB280", Offset = "0x7BA280", VA = "0x1807BB280", Slot = "5")]
		public void OALAFIKALMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x844EC0", Offset = "0x843EC0", VA = "0x180844EC0", Slot = "6")]
		public PBAOJGOHCMJ<object, OAAMPDEOGNE> LNGCCEGGDLD()
		{
			return default(PBAOJGOHCMJ<object, OAAMPDEOGNE>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x33170E0", Offset = "0x33160E0", VA = "0x1833170E0", Slot = "7")]
		[HGNKAKLJIMO("This may be terminal and should probably do more than discarding the exception.")]
		public void JKDPHDHDAKD(Exception NNMGILNOFJH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3317130", Offset = "0x3316130", VA = "0x183317130", Slot = "4")]
		private void JLGMBBCCOMB([In] PBAOJGOHCMJ<object, OAAMPDEOGNE> HEOGODCLBDD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct AOKLPBIOHGK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public global::PNNPHBHKBJP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public ADHLEPAMMHK<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x38DEA20", Offset = "0x38DDA20", VA = "0x1838DEA20", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x38DF4D0", Offset = "0x38DE4D0", VA = "0x1838DF4D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct LFKMAPJBILO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public global::PNNPHBHKBJP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public ADHLEPAMMHK<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3CE7A10", Offset = "0x3CE6A10", VA = "0x183CE7A10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8290", Offset = "0x3CE7290", VA = "0x183CE8290", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct ILFNHMCLLGO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public global::PNNPHBHKBJP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public ADHLEPAMMHK<TMActor> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ADHLEPAMMHK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x395C890", Offset = "0x395B890", VA = "0x18395C890", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x395CBF0", Offset = "0x395BBF0", VA = "0x18395CBF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct AMPFPGCHMBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public global::PNNPHBHKBJP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public ADHLEPAMMHK<TMActor> senderId;

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
		public ADHLEPAMMHK<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private PANOFJGNLFN <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x38D00D0", Offset = "0x38CF0D0", VA = "0x1838D00D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x38D0D00", Offset = "0x38CFD00", VA = "0x1838D0D00", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct NONJBOMGNKC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public global::PNNPHBHKBJP<TMRequest, TMActor, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public PANOFJGNLFN completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PANOFJGNLFN <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<PBAOJGOHCMJ<object, OAAMPDEOGNE>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1AC0", Offset = "0x3FA0AC0", VA = "0x183FA1AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3FA5780", Offset = "0x3FA4780", VA = "0x183FA5780", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps KFNEOPKPPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<ADHLEPAMMHK<TMRequest>, TaskCompletionSource<PBAOJGOHCMJ<object, OAAMPDEOGNE>>> BDABEKLOLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HIMHKENEPLA<TMRequest> PKBMPEKGEBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int EALGMPBHEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task NCEPDFKLBOF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps NLPLKFBLJBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4162E30", Offset = "0x4161E30", VA = "0x184162E30")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps LJOOBDFLDFN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x41627B0", Offset = "0x41617B0", VA = "0x1841627B0")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps NFPHJAOIJHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4162F00", Offset = "0x4161F00", VA = "0x184162F00")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FPLAGNJDOGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDD7F20", Offset = "0xDD6F20", VA = "0x180DD7F20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x11C3810", Offset = "0x11C2810", VA = "0x1811C3810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool AAPOIAFJDOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xDD7F30", Offset = "0xDD6F30", VA = "0x180DD7F30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1CB5C10", Offset = "0x1CB4C10", VA = "0x181CB5C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NIBDBMAHKGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BD950", Offset = "0x7BC950", VA = "0x1807BD950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x4162F30", Offset = "0x4161F30", VA = "0x184162F30")]
	public PNNPHBHKBJP(TDeps DGILCEAPJEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x4161B70", Offset = "0x4160B70", VA = "0x184161B70")]
	public Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> DHGOGDAMKMO(TRoot HLMIIECLDOF, TNetSys DEPELAGMNNF, ADHLEPAMMHK<TMActor> MCANCGADKBN, TAction DFHNKDINOMO, bool BCMNHKGIIHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x41618B0", Offset = "0x41608B0", VA = "0x1841618B0")]
	[AsyncStateMachine(typeof(global::PNNPHBHKBJP<, , , , , , , , , >.AOKLPBIOHGK))]
	private Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> DHGOGDAMKMO(TRoot HLMIIECLDOF, ADHLEPAMMHK<TMActor> MCANCGADKBN, TAction DFHNKDINOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4161230", Offset = "0x4160230", VA = "0x184161230")]
	[AsyncStateMachine(typeof(global::PNNPHBHKBJP<, , , , , , , , , >.LFKMAPJBILO))]
	private Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> BALLJOGJPDE(TRoot HLMIIECLDOF, ADHLEPAMMHK<TMActor> MCANCGADKBN, TAction[] MLHDOGCFLPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4162CC0", Offset = "0x4161CC0", VA = "0x184162CC0")]
	[AsyncStateMachine(typeof(global::PNNPHBHKBJP<, , , , , , , , , >.ILFNHMCLLGO))]
	public Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> LMJJFPKLIAG(TRoot HLMIIECLDOF, TNetSys FBNBMHCOFBF, TReceiver ACNOIKBCAAG, ADHLEPAMMHK<TMActor> MCANCGADKBN, ADHLEPAMMHK<TMRequest> MKGJPBKIBBD, TAction DFHNKDINOMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4162830", Offset = "0x4161830", VA = "0x184162830")]
	[AsyncStateMachine(typeof(global::PNNPHBHKBJP<, , , , , , , , , >.AMPFPGCHMBC))]
	private Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> KPIHHPJEOOJ(TRoot HLMIIECLDOF, TNetSys FBNBMHCOFBF, TReceiver ACNOIKBCAAG, ADHLEPAMMHK<TMActor> MCANCGADKBN, ADHLEPAMMHK<TMRequest> MKGJPBKIBBD, TAction DFHNKDINOMO, Task BFMDELIMLHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4161E90", Offset = "0x4160E90", VA = "0x184161E90")]
	[AsyncStateMachine(typeof(global::PNNPHBHKBJP<, , , , , , , , , >.NONJBOMGNKC))]
	private Task DPOAJDDEENE(TRoot HLMIIECLDOF, TNetSys FBNBMHCOFBF, TReceiver ACNOIKBCAAG, TAction DFHNKDINOMO, PANOFJGNLFN ONMHBEDAMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x41624D0", Offset = "0x41614D0", VA = "0x1841624D0")]
	private void HIFJOJMPKBF(TRoot HLMIIECLDOF, TNetSys FBNBMHCOFBF, TReceiver ACNOIKBCAAG, ADHLEPAMMHK<TMActor> MCANCGADKBN, TAction DFHNKDINOMO, bool GEHPIIDDAGG, bool FABHAMDNKFL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class MNHPADLFMBH
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface NFNGKBOCLKH<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int KPJALKOACKL(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction FKKLCECNADG(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction IMEEIOFGHJM(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> IPCALDPHOJP(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] AGEHOILIPBL(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO, int BIDOIIHAAOF);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool HGKKPHNCFKK(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool POJFJJPCOGH(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool LMBGEHNFOJF(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool LLLOGBKOBDJ(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool GNJKEKAGKDL(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool KJCLAPNLFGK(TNetSys PJJHCBPGJMO, TAction DFHNKDINOMO);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KDINFPOFKDI<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps NLPLKFBLJBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps NFPHJAOIJHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps LJOOBDFLDFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface ELBMJLJLHFD<TMActor, TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		ADHLEPAMMHK<TMActor> JCCKHMCJIIJ(TReceiver ACNOIKBCAAG);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<PBAOJGOHCMJ<object, OAAMPDEOGNE>> LMJJFPKLIAG(TReceiver ACNOIKBCAAG, TAction DFHNKDINOMO);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] GICPALJNOKF(TReceiver ACNOIKBCAAG);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface DKCOLKHHEGC<TMRequest, TMActor, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int BNLFDEEMJJF(TRoot HLMIIECLDOF);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int NPBFGHKKBOP(TRoot HLMIIECLDOF);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int HEBFJHEMNIB(TRoot HLMIIECLDOF);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int PAJDKEMJEMN(TRoot HLMIIECLDOF);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DJGHLPFMHHL(TRoot HLMIIECLDOF);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task DHGOGDAMKMO(TRoot HLMIIECLDOF, ADHLEPAMMHK<TMActor> MCANCGADKBN, ADHLEPAMMHK<TMRequest> MKGJPBKIBBD, TAction DFHNKDINOMO, bool FJCAKJALEIP = true);
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
