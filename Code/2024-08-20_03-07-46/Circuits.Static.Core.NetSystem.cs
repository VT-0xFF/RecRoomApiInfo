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
public struct JODAHGKHIGK<TPartialAction, TFullAction, TDeps> where TDeps : MGCGLEKEGMJ.FDMABEBONLD<TPartialAction, TFullAction>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	internal TPartialAction[] MPANKBCDNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	internal int ACNDNIJGOJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	internal TDeps OMOPLBNHPIH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC710", Offset = "0x3CEB710", VA = "0x183CEC710")]
	internal JODAHGKHIGK(TPartialAction[] DJGCNAHPAJJ, int GIFODCIKENK, TDeps HPGJLJLFPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC6B0", Offset = "0x3CEB6B0", VA = "0x183CEC6B0")]
	public static JODAHGKHIGK<TPartialAction, TFullAction, TDeps> GAKCNKPJGEK(TDeps HPGJLJLFPIH)
	{
		return default(JODAHGKHIGK<TPartialAction, TFullAction, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MGCGLEKEGMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface FDMABEBONLD<TPartialAction, TFullAction>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int APPKNMBAHFA([In] TPartialAction CKDLHIGKMND);

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullAction CHODIIAOOOB(TPartialAction[] ODFGEPEOENL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2CA2DB0", Offset = "0x2CA1DB0", VA = "0x182CA2DB0")]
	public static IHMGDPHFMFJ<TFullAction> MFOJGLPJLBJ<TFullAction, TPartialAction, TDeps>(this JODAHGKHIGK<TPartialAction, TFullAction, TDeps> KALCJEIICGB, TPartialAction CKDLHIGKMND) where TDeps : FDMABEBONLD<TPartialAction, TFullAction>
	{
		return default(IHMGDPHFMFJ<TFullAction>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct ACFKJEJKBHI<TPartialSnapshot, TFullSnapshot, TDeps> where TDeps : BNLGCIGJNKB.PNOMGFGLABG<TPartialSnapshot, TFullSnapshot>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	internal TPartialSnapshot[] CPPKNKMPNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	internal int HCJBILEGLHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	internal TDeps OMOPLBNHPIH;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC710", Offset = "0x3CEB710", VA = "0x183CEC710")]
	internal ACFKJEJKBHI(TPartialSnapshot[] HGCLAPPELDD, int MGHKOMCIECM, TDeps HPGJLJLFPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3CEC6B0", Offset = "0x3CEB6B0", VA = "0x183CEC6B0")]
	public static ACFKJEJKBHI<TPartialSnapshot, TFullSnapshot, TDeps> GAKCNKPJGEK(TDeps HPGJLJLFPIH)
	{
		return default(ACFKJEJKBHI<TPartialSnapshot, TFullSnapshot, TDeps>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class BNLGCIGJNKB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PNOMGFGLABG<TPartialSnapshot, TFullSnapshot>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int FFKEICBFAAP([In] TPartialSnapshot GDJPJALDDDJ);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TFullSnapshot LKBPOFLIODJ(TPartialSnapshot[] MCAMIHCICOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x292F320", Offset = "0x292E320", VA = "0x18292F320")]
	public static IHMGDPHFMFJ<TFullSnapshot> MFOJGLPJLBJ<TFullSnapshot, TPartialSnapshot, TDeps>(this ACFKJEJKBHI<TPartialSnapshot, TFullSnapshot, TDeps> KALCJEIICGB, TPartialSnapshot GDJPJALDDDJ) where TDeps : PNOMGFGLABG<TPartialSnapshot, TFullSnapshot>
	{
		return default(IHMGDPHFMFJ<TFullSnapshot>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x292F1E0", Offset = "0x292E1E0", VA = "0x18292F1E0")]
	public static bool FIMPJGBAILF<TPartialSnapshot, TFullSnapshot, TDeps>(this ACFKJEJKBHI<TPartialSnapshot, TFullSnapshot, TDeps> KALCJEIICGB, TPartialSnapshot GDJPJALDDDJ) where TDeps : PNOMGFGLABG<TPartialSnapshot, TFullSnapshot>
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public sealed class HMFCIBPJLLJ : LPIPGCLHAKC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2022410", Offset = "0x2021410", VA = "0x182022410", Slot = "7")]
	public override string DODDKOCHLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2022440", Offset = "0x2021440", VA = "0x182022440")]
	public HMFCIBPJLLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class LEPAAGGGLBG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> where TActionDeps : BEHAKNDEKHC.FEJJICLFGLD<TAction, TNetSys> where TReceiverDeps : BEHAKNDEKHC.KDFDHDDJNMA<TAction, TReceiver> where TRootDeps : BEHAKNDEKHC.JFFMODGMGOA<TMRequest, TAction, TRoot> where TDeps : BEHAKNDEKHC.KBJCMEDIPHL<TActionDeps, TReceiverDeps, TRootDeps>
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private interface PFLMNPELCJH
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MLPOEPBHKGJ([In] DFAHBLOKBPH<object, CKBHMJGLAPL> KNFGDDANCCK);

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AACNDOKCKBF();

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		DFAHBLOKBPH<object, CKBHMJGLAPL> AGOONGKGKGL();

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void CACBELAPAFI(Exception APIEMOLNMPG);
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private sealed class PLKCHLDKOGJ : PFLMNPELCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private readonly TaskCompletionSource<DFAHBLOKBPH<object, CKBHMJGLAPL>> KKNHAPHJPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly List<DFAHBLOKBPH<object, GFEHMFEELCO>> OIHCHCBOIFE;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x47AD570", Offset = "0x47AC570", VA = "0x1847AD570")]
		private PLKCHLDKOGJ(TaskCompletionSource<DFAHBLOKBPH<object, CKBHMJGLAPL>> BCPBDDPEGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x38AC320", Offset = "0x38AB320", VA = "0x1838AC320")]
		public static PLKCHLDKOGJ GAKCNKPJGEK(TaskCompletionSource<DFAHBLOKBPH<object, CKBHMJGLAPL>> BCPBDDPEGFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x47AD2B0", Offset = "0x47AC2B0", VA = "0x1847AD2B0")]
		public void MLPOEPBHKGJ([In] DFAHBLOKBPH<object, CKBHMJGLAPL> KNFGDDANCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x47ACFB0", Offset = "0x47ABFB0", VA = "0x1847ACFB0", Slot = "5")]
		public void AACNDOKCKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x47AD090", Offset = "0x47AC090", VA = "0x1847AD090", Slot = "6")]
		public DFAHBLOKBPH<object, CKBHMJGLAPL> AGOONGKGKGL()
		{
			return default(DFAHBLOKBPH<object, CKBHMJGLAPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x47AD1F0", Offset = "0x47AC1F0", VA = "0x1847AD1F0", Slot = "7")]
		public void CACBELAPAFI(Exception APIEMOLNMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x38AC410", Offset = "0x38AB410", VA = "0x1838AC410", Slot = "4")]
		private void OEFEAIBJIKC([In] DFAHBLOKBPH<object, CKBHMJGLAPL> KNFGDDANCCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private sealed class EMFACAJMECH : PFLMNPELCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly TaskCompletionSource<DFAHBLOKBPH<object, CKBHMJGLAPL>> KKNHAPHJPJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private DFAHBLOKBPH<object, CKBHMJGLAPL> HEOPKIDINGH;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x858C30", Offset = "0x857C30", VA = "0x180858C30")]
		private EMFACAJMECH(TaskCompletionSource<DFAHBLOKBPH<object, CKBHMJGLAPL>> BCPBDDPEGFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x38AC320", Offset = "0x38AB320", VA = "0x1838AC320")]
		public static EMFACAJMECH GAKCNKPJGEK(TaskCompletionSource<DFAHBLOKBPH<object, CKBHMJGLAPL>> BCPBDDPEGFL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x38AC3F0", Offset = "0x38AB3F0", VA = "0x1838AC3F0")]
		public void MLPOEPBHKGJ([In] DFAHBLOKBPH<object, CKBHMJGLAPL> KNFGDDANCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x38AC1A0", Offset = "0x38AB1A0", VA = "0x1838AC1A0", Slot = "5")]
		public void AACNDOKCKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xD382A0", Offset = "0xD372A0", VA = "0x180D382A0", Slot = "6")]
		public DFAHBLOKBPH<object, CKBHMJGLAPL> AGOONGKGKGL()
		{
			return default(DFAHBLOKBPH<object, CKBHMJGLAPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x38AC260", Offset = "0x38AB260", VA = "0x1838AC260", Slot = "7")]
		public void CACBELAPAFI(Exception APIEMOLNMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x38AC410", Offset = "0x38AB410", VA = "0x1838AC410", Slot = "4")]
		private void OEFEAIBJIKC([In] DFAHBLOKBPH<object, CKBHMJGLAPL> KNFGDDANCCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private sealed class JAFCNOIIMJB : PFLMNPELCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly List<DFAHBLOKBPH<object, CKBHMJGLAPL>> OIHCHCBOIFE;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x40FBBF0", Offset = "0x40FABF0", VA = "0x1840FBBF0")]
		private JAFCNOIIMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8490", Offset = "0x3EC7490", VA = "0x183EC8490")]
		public static JAFCNOIIMJB GAKCNKPJGEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x40FBA80", Offset = "0x40FAA80", VA = "0x1840FBA80")]
		public void MLPOEPBHKGJ([In] DFAHBLOKBPH<object, CKBHMJGLAPL> KNFGDDANCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void AACNDOKCKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x40FB840", Offset = "0x40FA840", VA = "0x1840FB840", Slot = "6")]
		public DFAHBLOKBPH<object, CKBHMJGLAPL> AGOONGKGKGL()
		{
			return default(DFAHBLOKBPH<object, CKBHMJGLAPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x40FB950", Offset = "0x40FA950", VA = "0x1840FB950", Slot = "7")]
		[KLDKOFJPICD("This may be terminal and should probably do more than discarding the exception.")]
		public void CACBELAPAFI(Exception APIEMOLNMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x38AC410", Offset = "0x38AB410", VA = "0x1838AC410", Slot = "4")]
		private void OEFEAIBJIKC([In] DFAHBLOKBPH<object, CKBHMJGLAPL> KNFGDDANCCK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private sealed class IFHCBCILELD : PFLMNPELCJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private DFAHBLOKBPH<object, CKBHMJGLAPL> HEOPKIDINGH;

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
		private IFHCBCILELD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8490", Offset = "0x3EC7490", VA = "0x183EC8490")]
		public static IFHCBCILELD GAKCNKPJGEK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x17E9810", Offset = "0x17E8810", VA = "0x1817E9810")]
		public void MLPOEPBHKGJ([In] DFAHBLOKBPH<object, CKBHMJGLAPL> KNFGDDANCCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "5")]
		public void AACNDOKCKBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9A27D0", Offset = "0x9A17D0", VA = "0x1809A27D0", Slot = "6")]
		public DFAHBLOKBPH<object, CKBHMJGLAPL> AGOONGKGKGL()
		{
			return default(DFAHBLOKBPH<object, CKBHMJGLAPL>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3EC8440", Offset = "0x3EC7440", VA = "0x183EC8440", Slot = "7")]
		[KLDKOFJPICD("This may be terminal and should probably do more than discarding the exception.")]
		public void CACBELAPAFI(Exception APIEMOLNMPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x38AC410", Offset = "0x38AB410", VA = "0x1838AC410", Slot = "4")]
		private void OEFEAIBJIKC([In] DFAHBLOKBPH<object, CKBHMJGLAPL> KNFGDDANCCK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private struct MJJPCIOFHDB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public LEPAAGGGLBG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public BGKDPCAKPBJ<GODBFGGEJLK> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private TaskCompletionSource<DFAHBLOKBPH<object, CKBHMJGLAPL>> <tcs>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x44EBC90", Offset = "0x44EAC90", VA = "0x1844EBC90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x44EC760", Offset = "0x44EB760", VA = "0x1844EC760", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[CompilerGenerated]
	private struct BOCOAOLLLCL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public TAction[] actions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public LEPAAGGGLBG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public BGKDPCAKPBJ<GODBFGGEJLK> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <i>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5350", Offset = "0x4EA4350", VA = "0x184EA5350", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4EA5820", Offset = "0x4EA4820", VA = "0x184EA5820", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct NAAFNEBOHHE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public LEPAAGGGLBG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public BGKDPCAKPBJ<GODBFGGEJLK> senderId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public BGKDPCAKPBJ<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public TAction action;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x45C1650", Offset = "0x45C0650", VA = "0x1845C1650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x45C1D20", Offset = "0x45C0D20", VA = "0x1845C1D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private struct OKIAFJLKJIO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public AsyncTaskMethodBuilder<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public LEPAAGGGLBG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public TRoot root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public Task lastReceive;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public BGKDPCAKPBJ<GODBFGGEJLK> senderId;

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
		public BGKDPCAKPBJ<TMRequest> requestId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private bool <wasWaitingForSnapshot>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool <isMyAction>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private PFLMNPELCJH <completion>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x46F60F0", Offset = "0x46F50F0", VA = "0x1846F60F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x46F7A20", Offset = "0x46F6A20", VA = "0x1846F7A20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private struct GGLACPKEPDJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public LEPAAGGGLBG<TMRequest, TAction, TNetSys, TReceiver, TActionDeps, TReceiverDeps, TRootDeps, TRoot, TDeps> <>4__this;

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
		public PFLMNPELCJH completionSink;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private IEnumerator<TAction> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private PFLMNPELCJH <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private TaskAwaiter<DFAHBLOKBPH<object, CKBHMJGLAPL>> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3D65D00", Offset = "0x3D64D00", VA = "0x183D65D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3D69CC0", Offset = "0x3D68CC0", VA = "0x183D69CC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly TDeps OMOPLBNHPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly Dictionary<BGKDPCAKPBJ<TMRequest>, TaskCompletionSource<DFAHBLOKBPH<object, CKBHMJGLAPL>>> ABJBLENNOCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MMPAGBKNNLI<TMRequest> BGIOCODOENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private int HPIAJCMKGHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private Task OOMKGBDJODE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private TActionDeps HAAIEEOHADF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x42E5310", Offset = "0x42E4310", VA = "0x1842E5310")]
		get
		{
			return (TActionDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private TRootDeps FCAHJFFHIED
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x42E6310", Offset = "0x42E5310", VA = "0x1842E6310")]
		get
		{
			return (TRootDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	private TReceiverDeps ILCGAAABOBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x42E62E0", Offset = "0x42E52E0", VA = "0x1842E62E0")]
		get
		{
			return (TReceiverDeps)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KFLPILCIKJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9F21D0", Offset = "0x9F11D0", VA = "0x1809F21D0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x147E480", Offset = "0x147D480", VA = "0x18147E480")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public bool PHGIGKFNCBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1039630", Offset = "0x1038630", VA = "0x181039630")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1EC7B20", Offset = "0x1EC6B20", VA = "0x181EC7B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BFCPLGKICBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x854630", Offset = "0x853630", VA = "0x180854630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x42E7180", Offset = "0x42E6180", VA = "0x1842E7180")]
	public LEPAAGGGLBG(TDeps HPGJLJLFPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x42E6930", Offset = "0x42E5930", VA = "0x1842E6930")]
	public Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> PJEFKDMKKLN(TRoot JMCFDCHCIPI, TNetSys EJDMMGDCLAB, BGKDPCAKPBJ<GODBFGGEJLK> OIGBOPKMBBG, TAction JFOAFIPDIOA, bool AMHHLKAOAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x42E6670", Offset = "0x42E5670", VA = "0x1842E6670")]
	[AsyncStateMachine(typeof(LEPAAGGGLBG<, , , , , , , , >.MJJPCIOFHDB))]
	private Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> PJEFKDMKKLN(TRoot JMCFDCHCIPI, BGKDPCAKPBJ<GODBFGGEJLK> OIGBOPKMBBG, TAction JFOAFIPDIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x42E5B70", Offset = "0x42E4B70", VA = "0x1842E5B70")]
	[AsyncStateMachine(typeof(LEPAAGGGLBG<, , , , , , , , >.BOCOAOLLLCL))]
	private Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> FNPHACBPBJH(TRoot JMCFDCHCIPI, BGKDPCAKPBJ<GODBFGGEJLK> OIGBOPKMBBG, TAction[] CECLMDMADKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x42E6500", Offset = "0x42E5500", VA = "0x1842E6500")]
	[AsyncStateMachine(typeof(LEPAAGGGLBG<, , , , , , , , >.NAAFNEBOHHE))]
	public Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> PGLNJIEHCFO(TRoot JMCFDCHCIPI, TNetSys KGIGMMEFBBL, TReceiver PPGNDOHCHFE, BGKDPCAKPBJ<GODBFGGEJLK> OIGBOPKMBBG, BGKDPCAKPBJ<TMRequest> PCIJBABFLNO, TAction JFOAFIPDIOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x42E6110", Offset = "0x42E5110", VA = "0x1842E6110")]
	[AsyncStateMachine(typeof(LEPAAGGGLBG<, , , , , , , , >.OKIAFJLKJIO))]
	private Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> JILCOMCAEIN(TRoot JMCFDCHCIPI, TNetSys KGIGMMEFBBL, TReceiver PPGNDOHCHFE, BGKDPCAKPBJ<GODBFGGEJLK> OIGBOPKMBBG, BGKDPCAKPBJ<TMRequest> PCIJBABFLNO, TAction JFOAFIPDIOA, Task LPACCGMIGIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x42E5E30", Offset = "0x42E4E30", VA = "0x1842E5E30")]
	[AsyncStateMachine(typeof(LEPAAGGGLBG<, , , , , , , , >.GGLACPKEPDJ))]
	private Task GJNGNKBNEKE(TRoot JMCFDCHCIPI, TNetSys KGIGMMEFBBL, TReceiver PPGNDOHCHFE, TAction JFOAFIPDIOA, PFLMNPELCJH JGNCABGBIHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x42E5340", Offset = "0x42E4340", VA = "0x1842E5340")]
	private void FFABLFFENBK(TRoot JMCFDCHCIPI, TNetSys KGIGMMEFBBL, TReceiver PPGNDOHCHFE, BGKDPCAKPBJ<GODBFGGEJLK> OIGBOPKMBBG, TAction JFOAFIPDIOA, bool NAAOLKLAGEF, bool ADHOECEJHEI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BEHAKNDEKHC
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface FEJJICLFGLD<TAction, TNetSys>
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int NEAFFGOCCCG(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		TAction MJFBIHKLOPF(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction LIBHGGLDGNJ(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IReadOnlyList<TAction> ONPLNENAKIA(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		TAction[] MNGOGIGJEDF(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA, int FFDAJIKOHDC);

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		bool KACKIDCEHPA(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		bool HLCKDDNADKF(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool BLJFBMJPGJN(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "8")]
		bool BPNAPBEIJPE(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "9")]
		bool PMJCBEBMLAL(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "10")]
		bool OECHDOKJCAI(TNetSys KHPBGKMELMP, TAction JFOAFIPDIOA);
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface KBJCMEDIPHL<TActionDeps, TReceiverDeps, TRootDeps>
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		TActionDeps HAAIEEOHADF
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		TReceiverDeps ILCGAAABOBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		TRootDeps FCAHJFFHIED
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface KDFDHDDJNMA<TAction, TReceiver>
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		BGKDPCAKPBJ<GODBFGGEJLK> OIICCBHPNAN(TReceiver PPGNDOHCHFE);

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<DFAHBLOKBPH<object, CKBHMJGLAPL>> PGLNJIEHCFO(TReceiver PPGNDOHCHFE, TAction JFOAFIPDIOA);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "2")]
		TAction[] GIGPIMECHJC(TReceiver PPGNDOHCHFE);
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface JFFMODGMGOA<TMRequest, TAction, TRoot>
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int IHBAFAEGAIE(TRoot JMCFDCHCIPI);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		int FCKLKFJDGLD(TRoot JMCFDCHCIPI);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		int GEKMGIGIACD(TRoot JMCFDCHCIPI);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int PDPFPFFKCIK(TRoot JMCFDCHCIPI);

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void LFKNDFBGOEN(TRoot JMCFDCHCIPI);

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		Task PJEFKDMKKLN(TRoot JMCFDCHCIPI, BGKDPCAKPBJ<GODBFGGEJLK> OIGBOPKMBBG, BGKDPCAKPBJ<TMRequest> PCIJBABFLNO, TAction JFOAFIPDIOA, bool PJKKONMHOBG = true);
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
