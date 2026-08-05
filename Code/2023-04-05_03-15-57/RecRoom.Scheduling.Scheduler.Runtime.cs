using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DNNODMLIEOK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority FOPJJMAAEKP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5610940", Offset = "0x560F940", VA = "0x185610940")]
	public DNNODMLIEOK(ThreadPriority KACGJFGJHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5610930", Offset = "0x560F930", VA = "0x185610930", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private delegate List<PlayerLoopSystem> EPABBABOMOA(List<PlayerLoopSystem> FGEEBMNILFP, int KBGCDDFLFHH);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct JGBLOCODHOF
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OGHCPPCNBCB
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static AMNHKKJOBOK FNPIHAKEOJD;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5620930", Offset = "0x561F930", VA = "0x185620930")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct GCHDNLLKLFK
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static AMNHKKJOBOK FMBIKGIEHCG;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x5616DD0", Offset = "0x5615DD0", VA = "0x185616DD0")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct FHIEIEHBHJN
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static AMNHKKJOBOK INOEJILCGHJ;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x56127D0", Offset = "0x56117D0", VA = "0x1856127D0")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct JFHOEKPGOIH
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static AMNHKKJOBOK ACHDONNEMGJ;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static AMNHKKJOBOK IHFHNBFHPJI;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static AMNHKKJOBOK IIKCICOKIHD;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static AMNHKKJOBOK OLBHGADBGFE;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x561AF50", Offset = "0x5619F50", VA = "0x18561AF50")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct OAHCFBMCFNG
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static AMNHKKJOBOK PGIEIBFCDEG;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5620630", Offset = "0x561F630", VA = "0x185620630")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct DMIGJHFEPKN
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static AMNHKKJOBOK ACHDONNEMGJ;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static AMNHKKJOBOK IHFHNBFHPJI;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static AMNHKKJOBOK IIKCICOKIHD;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static AMNHKKJOBOK OLBHGADBGFE;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x56106A0", Offset = "0x560F6A0", VA = "0x1856106A0")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct DJNJDHHINPH
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static AMNHKKJOBOK MOJBGLABFIA;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x56104C0", Offset = "0x560F4C0", VA = "0x1856104C0")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct EKHOBIAJAEK
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static AMNHKKJOBOK MLEAECJPDAP;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x56123F0", Offset = "0x56113F0", VA = "0x1856123F0")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct ADDGPIPFECC
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static AMNHKKJOBOK BNCMLNBEKAH;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x560B9C0", Offset = "0x560A9C0", VA = "0x18560B9C0")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct AKFCKDFAPLD
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static AMNHKKJOBOK MPFPIJBIDFC;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x560BBD0", Offset = "0x560ABD0", VA = "0x18560BBD0")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct CJKHHDDNLPJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static AMNHKKJOBOK LKIHLKIOEHD;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x560CCF0", Offset = "0x560BCF0", VA = "0x18560CCF0")]
				public static PlayerLoopSystem HHHFIOBLNLN()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct LDJJCKMDMCO
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class PPNMJOIBCFG
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public HENMDCADECJ.FIJJGIGAEDM key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
					public PPNMJOIBCFG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x5623130", Offset = "0x5622130", VA = "0x185623130")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable FBJCJMLLPLH;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x561CED0", Offset = "0x561BED0", VA = "0x18561CED0")]
				public static PlayerLoopSystem DBAKJPKCNBO(HENMDCADECJ.FIJJGIGAEDM EBOIOCBODNI)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct EMBHPAMINLH
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class GKMOGEHKJMO
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public HENMDCADECJ.FIJJGIGAEDM key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
					public GKMOGEHKJMO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x5617E90", Offset = "0x5616E90", VA = "0x185617E90")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x56125D0", Offset = "0x56115D0", VA = "0x1856125D0")]
				public static PlayerLoopSystem DBAKJPKCNBO(HENMDCADECJ.FIJJGIGAEDM EBOIOCBODNI)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class IKMJKFIDKFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public IKMJKFIDKFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x561AD20", Offset = "0x5619D20", VA = "0x18561AD20")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool NJMHICBJADG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool LAKIGKLJDPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x560E260", Offset = "0x560D260", VA = "0x18560E260")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x560D100", Offset = "0x560C100", VA = "0x18560D100")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x560E460", Offset = "0x560D460", VA = "0x18560E460")]
		private static void ONMKOACHOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x560D5A0", Offset = "0x560C5A0", VA = "0x18560D5A0")]
		private static void FJKLFPCEHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x560D140", Offset = "0x560C140", VA = "0x18560D140")]
		private static void DPHAKHOEGCL(string ABECJBOAJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x560CED0", Offset = "0x560BED0", VA = "0x18560CED0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x560E2A0", Offset = "0x560D2A0", VA = "0x18560E2A0")]
		private static void GHNPLJIBLIP(HENMDCADECJ.FIJJGIGAEDM EBOIOCBODNI, ref PlayerLoopSystem BHDBDABFNLD, Type MLLAPDIOPCE, Type PKCGAKAPAOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x560DE70", Offset = "0x560CE70", VA = "0x18560DE70")]
		private static void FODNMICIAJI(ref PlayerLoopSystem BHDBDABFNLD, Type MLLAPDIOPCE, Type PKCGAKAPAOL, EPABBABOMOA JFFGLOCNOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x560D470", Offset = "0x560C470", VA = "0x18560D470")]
		private static void EDPELEJKIFF(ref PlayerLoopSystem BHDBDABFNLD, Type MLLAPDIOPCE, Type PKCGAKAPAOL, PlayerLoopSystem? HOJMJOLGPCG, PlayerLoopSystem? EAFEMILBLDE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class HENMDCADECJ
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum FIJJGIGAEDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class LNLJOCIKFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly FIJJGIGAEDM GOAALMPKPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly PMOLBFDOCCP DJJHNHMKCLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long DFAJCDNCKCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long ACGICELBFMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long GICBDLDGMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int IFPIMCJKPGP;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x561DD10", Offset = "0x561CD10", VA = "0x18561DD10")]
		public LNLJOCIKFNK(FIJJGIGAEDM OMBLODAMGIE, int NHMBMIDCCEJ = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x561DC40", Offset = "0x561CC40", VA = "0x18561DC40")]
		public void OALOBLPHMGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x561DCB0", Offset = "0x561CCB0", VA = "0x18561DCB0")]
		public void ONKJHEMGFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x561DA40", Offset = "0x561CA40", VA = "0x18561DA40")]
		public void JMJIJHIIEHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static FIJJGIGAEDM[] GGGMFCOKMBA;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static LNLJOCIKFNK[] CIKJEADJLGE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5618230", Offset = "0x5617230", VA = "0x185618230")]
	public static LNLJOCIKFNK FONONLJMKAP(FIJJGIGAEDM EBOIOCBODNI, int NHMBMIDCCEJ = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x56184B0", Offset = "0x56174B0", VA = "0x1856184B0")]
	public static LNLJOCIKFNK KPBDBKOJMMH(FIJJGIGAEDM EBOIOCBODNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5618400", Offset = "0x5617400", VA = "0x185618400")]
	public static void HGLBKMIPBPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class PMOLBFDOCCP : LGJGLFOBOFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int GGKOFELOHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> JEEEGEGKGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double EKDCKLAKFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double IBFPNBPAEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double JKALNBNADJG;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double FEBKMEKDEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5623020", Offset = "0x5622020", VA = "0x185623020", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double MHLDKBGDLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1ED61E0", Offset = "0x1ED51E0", VA = "0x181ED61E0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BEDFHIHFBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x33FA550", Offset = "0x33F9550", VA = "0x1833FA550", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5623080", Offset = "0x5622080", VA = "0x185623080")]
	public PMOLBFDOCCP(int IPBHMLBJKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5622EF0", Offset = "0x5621EF0", VA = "0x185622EF0", Slot = "7")]
	public void KFAAAFDIAME(double LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5622E80", Offset = "0x5621E80", VA = "0x185622E80", Slot = "8")]
	public void IKINEIFADPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class LBBJHPIOOBH : LGJGLFOBOFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long KJAHKKMJHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double DJDOIHJLEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double KFFHFCIPCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double JOJGGIHCMCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double FIOODIGBGHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double EKDCKLAKFJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double IBFPNBPAEOD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public long IIEJMBAKGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double MHLDKBGDLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x388DF20", Offset = "0x388CF20", VA = "0x18388DF20", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BEDFHIHFBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA4FE30", Offset = "0xA4EE30", VA = "0x180A4FE30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MJLKMGPGGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x33FA540", Offset = "0x33F9540", VA = "0x1833FA540")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FEBKMEKDEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x388DE50", Offset = "0x388CE50", VA = "0x18388DE50", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x561CD70", Offset = "0x561BD70", VA = "0x18561CD70", Slot = "7")]
	public virtual void KFAAAFDIAME(double LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x561CD30", Offset = "0x561BD30", VA = "0x18561CD30", Slot = "8")]
	public virtual void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x561CEA0", Offset = "0x561BEA0", VA = "0x18561CEA0")]
	public LBBJHPIOOBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class NHDCBDIACKO : LBBJHPIOOBH
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double CAOPPAICFBM
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x56203A0", Offset = "0x561F3A0", VA = "0x1856203A0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5620530", Offset = "0x561F530", VA = "0x185620530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56203F0", Offset = "0x561F3F0", VA = "0x1856203F0", Slot = "7")]
	public override void KFAAAFDIAME(double LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56203B0", Offset = "0x561F3B0", VA = "0x1856203B0", Slot = "8")]
	public override void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x561CEA0", Offset = "0x561BEA0", VA = "0x18561CEA0")]
	public NHDCBDIACKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface LGJGLFOBOFF
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	double FEBKMEKDEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double MHLDKBGDLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double BEDFHIHFBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class IDNOGMLLNKM
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private interface EBLALNEJKAB
	{
		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool EEPIMGJCMOD
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OIEKBFPKDBB();
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private abstract class MOOOCEMALOO<TPromise, TMainThreadPromise> : EBLALNEJKAB where TPromise : LLEFGLIPMKI where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private readonly TPromise JCEJHOGHOPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		protected readonly TMainThreadPromise DEMIODPPMGP;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public TPromise NKHOKBCPGFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x356C0D0", Offset = "0x356B0D0", VA = "0x18356C0D0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EEPIMGJCMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x356C080", Offset = "0x356B080", VA = "0x18356C080", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2708F80", Offset = "0x2707F80", VA = "0x182708F80")]
		protected MOOOCEMALOO(TPromise JCEJHOGHOPG, TMainThreadPromise BFJFHBDIGAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x356C130", Offset = "0x356B130", VA = "0x18356C130", Slot = "5")]
		public void OIEKBFPKDBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void EAHEIPPGIGM(TPromise JCEJHOGHOPG);
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class PIGJCAHCOHE<T> : MOOOCEMALOO<global::MLDKKGKEACN<T>, global::BLIGMBCADIE<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x2B33F20", Offset = "0x2B32F20", VA = "0x182B33F20")]
		public PIGJCAHCOHE(global::MLDKKGKEACN<T> JCEJHOGHOPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2B33D90", Offset = "0x2B32D90", VA = "0x182B33D90", Slot = "6")]
		protected override void EAHEIPPGIGM(global::MLDKKGKEACN<T> JCEJHOGHOPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2B33EF0", Offset = "0x2B32EF0", VA = "0x182B33EF0")]
		[CompilerGenerated]
		private void MHPHDKCGFIK(T GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x14A7C90", Offset = "0x14A6C90", VA = "0x1814A7C90")]
		[CompilerGenerated]
		private void DFBFFHCKHPE(string CNMFEBEOFOM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private class FCCPHALNKCG : EBLALNEJKAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private readonly Action FFBLFKDINEA;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool EEPIMGJCMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
		public FCCPHALNKCG(Action FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x14624E0", Offset = "0x14614E0", VA = "0x1814624E0", Slot = "5")]
		public void OIEKBFPKDBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<EBLALNEJKAB> PKCJJEFLCJB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x22C9680", Offset = "0x22C8680", VA = "0x1822C9680")]
	public static global::MLDKKGKEACN<T> PLDPIMEGHCB<T>(this global::MLDKKGKEACN<T> JCEJHOGHOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x561A7A0", Offset = "0x56197A0", VA = "0x18561A7A0")]
	public static void PLDPIMEGHCB(Action FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x22C95C0", Offset = "0x22C85C0", VA = "0x1822C95C0")]
	private static global::MLDKKGKEACN<T> IILLCLGHHHM<T>(global::MLDKKGKEACN<T> JCEJHOGHOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x561A3D0", Offset = "0x56193D0", VA = "0x18561A3D0")]
	private static void GLFCJJIIEOO(EBLALNEJKAB LCMEIMAGMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x561A0E0", Offset = "0x56190E0", VA = "0x18561A0E0")]
	private static void EGLBBHLEDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x561A6A0", Offset = "0x56196A0", VA = "0x18561A6A0")]
	private static void OLKOKJNFOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x561A5D0", Offset = "0x56195D0", VA = "0x18561A5D0")]
	private static void OCAJIBLMBKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FJIPPGCOILP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private struct OMHMGNEEEFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public TaskCompletionSource<Scene> DHBAGLNJJOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly string CICEEKFBKIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly LoadSceneMode BMGAIMADGNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly bool IFMOLNHDDCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly OEPFOLMCINK OKOAEEBPCIH;

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x56210F0", Offset = "0x56200F0", VA = "0x1856210F0")]
		public OMHMGNEEEFH(TaskCompletionSource<Scene> LOGPJLDPMEJ, string CICEEKFBKIJ, LoadSceneMode BMGAIMADGNG, bool IFMOLNHDDCB, OEPFOLMCINK OKOAEEBPCIH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct LGMFJDNDGAP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public OEPFOLMCINK stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private global::AOKCPNNMNJG<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x561D000", Offset = "0x561C000", VA = "0x18561D000", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x561D670", Offset = "0x561C670", VA = "0x18561D670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct BOJBCBEIOBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x560C510", Offset = "0x560B510", VA = "0x18560C510", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct CCDPKEGJEAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private OMHMGNEEEFH <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x560C960", Offset = "0x560B960", VA = "0x18560C960", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E7320", Offset = "0x6E6320", VA = "0x1806E7320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class NECFMJLNAMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public global::BLIGMBCADIE<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public NECFMJLNAMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x56201C0", Offset = "0x561F1C0", VA = "0x1856201C0")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private struct ABDJKNLGMAF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private NECFMJLNAMJ <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private OEPFOLMCINK <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private OEPFOLMCINK <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x560AFF0", Offset = "0x5609FF0", VA = "0x18560AFF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x560B970", Offset = "0x560A970", VA = "0x18560B970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private struct MABFMMEDMHB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public OEPFOLMCINK stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private OEPFOLMCINK <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private OEPFOLMCINK <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x561E4E0", Offset = "0x561D4E0", VA = "0x18561E4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x561ED20", Offset = "0x561DD20", VA = "0x18561ED20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class AJDIJFNPGGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public AJDIJFNPGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x560BBA0", Offset = "0x560ABA0", VA = "0x18560BBA0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class DNOOOLOMEGI : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public LCFGHKNEPEI onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public DNOOOLOMEGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5610CE0", Offset = "0x560FCE0", VA = "0x185610CE0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5610980", Offset = "0x560F980", VA = "0x185610980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5610D70", Offset = "0x560FD70", VA = "0x185610D70")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5610CA0", Offset = "0x560FCA0", VA = "0x185610CA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class GGBCNNHDALL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public global::BLIGMBCADIE<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public GGBCNNHDALL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class KJCBHDFBAMG : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public global::BLIGMBCADIE<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private GGBCNNHDALL <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public KJCBHDFBAMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x561C8A0", Offset = "0x561B8A0", VA = "0x18561C8A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x561CCF0", Offset = "0x561BCF0", VA = "0x18561CCF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static LLEFGLIPMKI BGGFBACLFFN;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static AsyncOperation CAGOJFLJPEC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static LLEFGLIPMKI OGFDKIEFGDI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static string LFIIJPOPMGG;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static ThreadPriority DMIKMNAJNPL;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static Task MNDGCKDNGJM;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static readonly Queue<OMHMGNEEEFH> GMOMMCBEJOC;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private static Task LOHBABMDBOH;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool IGFCOPPDNML
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x56129B0", Offset = "0x56119B0", VA = "0x1856129B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool CMDIHJGMBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5613B10", Offset = "0x5612B10", VA = "0x185613B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool PGFNPCICEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5613BC0", Offset = "0x5612BC0", VA = "0x185613BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> PIBJJFAKEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x56133A0", Offset = "0x56123A0", VA = "0x1856133A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x56130A0", Offset = "0x56120A0", VA = "0x1856130A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x56134A0", Offset = "0x56124A0", VA = "0x1856134A0")]
	[DFDEPFOCOOG(GCCGOPEBDFE.EnteredEditModeNextFrame, 0)]
	private static void KCBABHGPKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5613570", Offset = "0x5612570", VA = "0x185613570")]
	[AsyncStateMachine(typeof(LGMFJDNDGAP))]
	public static Task<Scene> KDGJDALOEAA(string CICEEKFBKIJ, LoadSceneMode BMGAIMADGNG = LoadSceneMode.Single, bool IFMOLNHDDCB = false, [Optional] OEPFOLMCINK PNAMKBJBLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5613A40", Offset = "0x5612A40", VA = "0x185613A40")]
	[AsyncStateMachine(typeof(BOJBCBEIOBC))]
	private static Task OGGCJOHKDKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x5612CD0", Offset = "0x5611CD0", VA = "0x185612CD0")]
	[AsyncStateMachine(typeof(CCDPKEGJEAE))]
	private static Task BOFLJNOMOCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5612B70", Offset = "0x5611B70", VA = "0x185612B70")]
	[AsyncStateMachine(typeof(ABDJKNLGMAF))]
	private static Task<Scene> BJIKNCCIAEF(string CICEEKFBKIJ, LoadSceneMode BMGAIMADGNG, bool IFMOLNHDDCB, OEPFOLMCINK OKOAEEBPCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5612F60", Offset = "0x5611F60", VA = "0x185612F60")]
	[AsyncStateMachine(typeof(MABFMMEDMHB))]
	private static Task<Scene> CLHHEBHHFAO(OEPFOLMCINK OKOAEEBPCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5612DC0", Offset = "0x5611DC0", VA = "0x185612DC0")]
	public static global::MLDKKGKEACN<Scene> CIOCCDPNOBF(string CICEEKFBKIJ, LoadSceneMode BMGAIMADGNG = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x56136D0", Offset = "0x56126D0", VA = "0x1856136D0")]
	public static LLEFGLIPMKI MOJJCPIICKE(string CICEEKFBKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x56139B0", Offset = "0x56129B0", VA = "0x1856139B0")]
	[IteratorStateMachine(typeof(DNOOOLOMEGI))]
	private static IEnumerator<FEEMOJCDGJP> ODBJIHCGNIG(string CICEEKFBKIJ, LCFGHKNEPEI JFNHMEJJEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x56131A0", Offset = "0x56121A0", VA = "0x1856131A0")]
	[IteratorStateMachine(typeof(KJCBHDFBAMG))]
	private static IEnumerator<FEEMOJCDGJP> GHDCIINHFIF(string CICEEKFBKIJ, LoadSceneMode BMGAIMADGNG, global::BLIGMBCADIE<Scene> JFNHMEJJEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x5613240", Offset = "0x5612240", VA = "0x185613240")]
	public static bool IFHEEONJJPE(out string GHBFBMNCBKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NFOFMHFNDGP
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5620320", Offset = "0x561F320", VA = "0x185620320")]
	public static IDisposable NGODGBPOHNK(this ADIFEAAPNPC MFEOJPNCOBA, float FOOKFHONNOI, Action<float> CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5620220", Offset = "0x561F220", VA = "0x185620220")]
	public static IDisposable AGEHEIHDNGD(this ADIFEAAPNPC MFEOJPNCOBA, Action<float> CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x56202A0", Offset = "0x561F2A0", VA = "0x1856202A0")]
	public static IDisposable MPMAJAGOMNC(this ADIFEAAPNPC MFEOJPNCOBA, Action<float> CHENOCAGDJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EAHKBJPIPDE
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5610F50", Offset = "0x560FF50", VA = "0x185610F50")]
	public static IDisposable CMNJABNFFNL(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5610ED0", Offset = "0x560FED0", VA = "0x185610ED0")]
	public static IDisposable CMNJABNFFNL(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x56112E0", Offset = "0x56102E0", VA = "0x1856112E0")]
	public static IDisposable HMNCABBCMFO(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5611130", Offset = "0x5610130", VA = "0x185611130")]
	public static IDisposable EJBOICBIHAK(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5611580", Offset = "0x5610580", VA = "0x185611580")]
	public static IDisposable KEICLDDDMEI(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5610E50", Offset = "0x560FE50", VA = "0x185610E50")]
	public static IDisposable CJDMNCIGNKG(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x56113E0", Offset = "0x56103E0", VA = "0x1856113E0")]
	public static IDisposable IMKBOAAGOGO(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5611240", Offset = "0x5610240", VA = "0x185611240")]
	public static IDisposable GFEHAEBONFM(this MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5611070", Offset = "0x5610070", VA = "0x185611070")]
	public static IDisposable DPCGJHHKGEG(this MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5610FD0", Offset = "0x560FFD0", VA = "0x185610FD0")]
	public static IDisposable DCNAHEKJLMF(this MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5610DC0", Offset = "0x560FDC0", VA = "0x185610DC0")]
	public static IDisposable APAFEHHJPFA(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x56114F0", Offset = "0x56104F0", VA = "0x1856114F0")]
	public static IDisposable JJKEHJJEDNN(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5611460", Offset = "0x5610460", VA = "0x185611460")]
	public static IDisposable JCLDGHMABKK(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5611350", Offset = "0x5610350", VA = "0x185611350")]
	public static IDisposable IBEAFFDLKBL(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x5611690", Offset = "0x5610690", VA = "0x185611690")]
	public static IDisposable OJMBPOGJMPA(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x56111B0", Offset = "0x56101B0", VA = "0x1856111B0")]
	public static IDisposable FPLKEFKFFHL(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x5611600", Offset = "0x5610600", VA = "0x185611600")]
	public static IDisposable MDDMKKIGCMB(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x5611720", Offset = "0x5610720", VA = "0x185611720")]
	public static IDisposable OMAABBAPGLF(this MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x56110A0", Offset = "0x56100A0", VA = "0x1856110A0")]
	public static IDisposable EBGFCKLNCIF(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public static class LKJBINPINFJ
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class EDLCMBAFKBH : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public FEILFOOICNG.KEGPNCJFLFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private JFPHAJDACKP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public EDLCMBAFKBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x5612130", Offset = "0x5611130", VA = "0x185612130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x56121F0", Offset = "0x56111F0", VA = "0x1856121F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class DHNCMDHDEJA : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public FEILFOOICNG.KEGPNCJFLFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private JFPHAJDACKP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public DHNCMDHDEJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5610390", Offset = "0x560F390", VA = "0x185610390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5610480", Offset = "0x560F480", VA = "0x185610480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x561D890", Offset = "0x561C890", VA = "0x18561D890")]
	public static ALMNDBMKBBN CMNJABNFFNL(Action CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x561D6C0", Offset = "0x561C6C0", VA = "0x18561D6C0")]
	public static ALMNDBMKBBN CMNJABNFFNL(Behaviour MFEOJPNCOBA, Action CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x561D780", Offset = "0x561C780", VA = "0x18561D780")]
	public static ALMNDBMKBBN CMNJABNFFNL(Behaviour MFEOJPNCOBA, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x561D940", Offset = "0x561C940", VA = "0x18561D940")]
	[IteratorStateMachine(typeof(EDLCMBAFKBH))]
	private static IEnumerator<FEEMOJCDGJP> CPEMHMEKMCE(FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x561D9C0", Offset = "0x561C9C0", VA = "0x18561D9C0")]
	[IteratorStateMachine(typeof(DHNCMDHDEJA))]
	private static IEnumerator<FEEMOJCDGJP> CPEMHMEKMCE(FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action<float> CHENOCAGDJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OLHFFDPNDEL
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class EGAFCKHOOND : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public ELJBFCFFPBH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public Action<float> update;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public EGAFCKHOOND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5612310", Offset = "0x5611310", VA = "0x185612310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x56123B0", Offset = "0x56113B0", VA = "0x1856123B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5620B10", Offset = "0x561FB10", VA = "0x185620B10")]
	public static ALMNDBMKBBN CMNJABNFFNL(float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5620C10", Offset = "0x561FC10", VA = "0x185620C10")]
	public static ALMNDBMKBBN CMNJABNFFNL(MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5620E30", Offset = "0x561FE30", VA = "0x185620E30")]
	public static ALMNDBMKBBN JOHBDFNDMHL(MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5620FE0", Offset = "0x561FFE0", VA = "0x185620FE0")]
	public static ALMNDBMKBBN LEMECCIBKNI(ADIFEAAPNPC MFEOJPNCOBA, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5620D20", Offset = "0x561FD20", VA = "0x185620D20")]
	private static IEnumerator<FEEMOJCDGJP> CPEMHMEKMCE(JAOAOODOEOH GCDMKDMAPNJ, float FOOKFHONNOI, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5620DD0", Offset = "0x561FDD0", VA = "0x185620DD0")]
	private static IEnumerator<FEEMOJCDGJP> JKEDNIALJMN(JAOAOODOEOH GCDMKDMAPNJ, float FOOKFHONNOI, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5620F50", Offset = "0x561FF50", VA = "0x185620F50")]
	[IteratorStateMachine(typeof(EGAFCKHOOND))]
	private static IEnumerator<FEEMOJCDGJP> JPODFEPCOEG(ELJBFCFFPBH BOKAHCFBBLC, float FOOKFHONNOI, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action<float> CHENOCAGDJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LPFFEIKJBDO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class OACHBMMCLGE : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public FEILFOOICNG.KEGPNCJFLFJ queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public OACHBMMCLGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5620540", Offset = "0x561F540", VA = "0x185620540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x56205F0", Offset = "0x561F5F0", VA = "0x1856205F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x561DE10", Offset = "0x561CE10", VA = "0x18561DE10")]
	[IteratorStateMachine(typeof(OACHBMMCLGE))]
	private static IEnumerator<FEEMOJCDGJP> EIEKJNELLBO(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, Func<bool> MLBBCPJIFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x561DE90", Offset = "0x561CE90", VA = "0x18561DE90")]
	public static ALMNDBMKBBN PGABGCGAEPB(this MonoBehaviour GKLOBNBPFOD, Func<bool> MLBBCPJIFOJ, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM = FEILFOOICNG.KEGPNCJFLFJ.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public static class OOGNFNGJNDB
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class PHDJJCLHBCA : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public FEILFOOICNG.KEGPNCJFLFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public PHDJJCLHBCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5622D80", Offset = "0x5621D80", VA = "0x185622D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5622E40", Offset = "0x5621E40", VA = "0x185622E40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class AKPOIDGHEKE : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public FEILFOOICNG.KEGPNCJFLFJ queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private FEEMOJCDGJP <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public AKPOIDGHEKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x560BDB0", Offset = "0x560ADB0", VA = "0x18560BDB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x560BE80", Offset = "0x560AE80", VA = "0x18560BE80", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x5621A90", Offset = "0x5620A90", VA = "0x185621A90")]
	[IteratorStateMachine(typeof(PHDJJCLHBCA))]
	private static IEnumerator<FEEMOJCDGJP> LBHDJPDENOC(float FCCAADEIJOC, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x56215C0", Offset = "0x56205C0", VA = "0x1856215C0")]
	[IteratorStateMachine(typeof(AKPOIDGHEKE))]
	private static IEnumerator<FEEMOJCDGJP> EFHPCGNOHLE(float FCCAADEIJOC, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x5621870", Offset = "0x5620870", VA = "0x185621870")]
	public static IDisposable GOEHLJBPOGP(this MonoBehaviour GKLOBNBPFOD, float FCCAADEIJOC, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x5621650", Offset = "0x5620650", VA = "0x185621650")]
	public static ALMNDBMKBBN GIKJCFKECNJ(this MonoBehaviour GKLOBNBPFOD, float FCCAADEIJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5621740", Offset = "0x5620740", VA = "0x185621740")]
	public static ALMNDBMKBBN GOEHLJBPOGP(this MonoBehaviour GKLOBNBPFOD, float FCCAADEIJOC, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x56213D0", Offset = "0x56203D0", VA = "0x1856213D0")]
	public static ALMNDBMKBBN COFJFOJAHKP(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5621B20", Offset = "0x5620B20", VA = "0x185621B20")]
	public static ALMNDBMKBBN POPBNCLFNNL(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x56212F0", Offset = "0x56202F0", VA = "0x1856212F0")]
	public static ALMNDBMKBBN CNGLKIGMEHA(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5621710", Offset = "0x5620710", VA = "0x185621710")]
	public static ALMNDBMKBBN GLNEMACPFLH(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x5621A60", Offset = "0x5620A60", VA = "0x185621A60")]
	public static ALMNDBMKBBN KPJFIAPJHAP(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x56214C0", Offset = "0x56204C0", VA = "0x1856214C0")]
	public static ALMNDBMKBBN DPLMGBEDKNG(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x5621150", Offset = "0x5620150", VA = "0x185621150")]
	private static ALMNDBMKBBN BAPAIMFINGN(MonoBehaviour GKLOBNBPFOD, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, Action EGHDMBPEGFF, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x56214F0", Offset = "0x56204F0", VA = "0x1856214F0")]
	public static ALMNDBMKBBN EFGHNHLKPIJ(this MonoBehaviour GKLOBNBPFOD, float BGOCLIOFNII, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x5621220", Offset = "0x5620220", VA = "0x185621220")]
	public static ALMNDBMKBBN CJNNFDLJFEO(this MonoBehaviour GKLOBNBPFOD, float BGOCLIOFNII, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5621990", Offset = "0x5620990", VA = "0x185621990")]
	public static ALMNDBMKBBN IOMBCJBIELM(this MonoBehaviour GKLOBNBPFOD, float BGOCLIOFNII, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x56213F0", Offset = "0x56203F0", VA = "0x1856213F0")]
	public static ALMNDBMKBBN DIPENFLENBO(this MonoBehaviour GKLOBNBPFOD, float BGOCLIOFNII, Action EGHDMBPEGFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public class EDBJFMEKDOE : KBHCDJBOPJL, IEnumerable<KBHCDJBOPJL>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly List<KBHCDJBOPJL> CDFGGDOMEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool MNANDAKHMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private Action LEDGIFFFLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private bool MLCMKGGOKFH;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool MEBOGEFMKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5611A50", Offset = "0x5610A50", VA = "0x185611A50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action ACBCKAMKFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5611800", Offset = "0x5610800", VA = "0x185611800", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5611FF0", Offset = "0x5610FF0", VA = "0x185611FF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x5612090", Offset = "0x5611090", VA = "0x185612090")]
	public EDBJFMEKDOE([Optional] Action LEDGIFFFLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x56118A0", Offset = "0x56108A0", VA = "0x1856118A0")]
	public void GBJBCHALJOG(KBHCDJBOPJL BBGPBJMDIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5611E80", Offset = "0x5610E80", VA = "0x185611E80")]
	private void MOGOMAMCBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5611B90", Offset = "0x5610B90", VA = "0x185611B90", Slot = "7")]
	public bool LLJKEGONCBN(bool AKNNPOEHKML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5611BA0", Offset = "0x5610BA0", VA = "0x185611BA0", Slot = "8")]
	public bool LLJKEGONCBN(Action FFBLFKDINEA, bool AKNNPOEHKML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x56119D0", Offset = "0x56109D0", VA = "0x1856119D0", Slot = "9")]
	public IEnumerator<KBHCDJBOPJL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x56119D0", Offset = "0x56109D0", VA = "0x1856119D0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class GKHIBDBPEBK : BHEHDMKHJBI
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class CCCABKKLBJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public GKHIBDBPEBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public CCCABKKLBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x560C930", Offset = "0x560B930", VA = "0x18560C930")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class DKFFIKIAKOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public GKHIBDBPEBK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public DKFFIKIAKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x560C930", Offset = "0x560B930", VA = "0x18560C930")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly float CJDHBKDNNCE;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5617D90", Offset = "0x5616D90", VA = "0x185617D90")]
	public GKHIBDBPEBK(Behaviour MFEOJPNCOBA, float CJDHBKDNNCE, [Optional] Action LEDGIFFFLHA, [Optional] AICFMGNKEOP IJGKMHNCIAI, [Optional] JAOAOODOEOH GCDMKDMAPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5617B90", Offset = "0x5616B90", VA = "0x185617B90", Slot = "9")]
	protected override bool CPKFMFOAEPP(Action FFBLFKDINEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5617C90", Offset = "0x5616C90", VA = "0x185617C90", Slot = "10")]
	protected override bool LAGIOPJKIOB(Action FFBLFKDINEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface KBHCDJBOPJL
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool MEBOGEFMKHI
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action ACBCKAMKFJG;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LLJKEGONCBN(bool AKNNPOEHKML = false);

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LLJKEGONCBN(Action FFBLFKDINEA, bool AKNNPOEHKML = false);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class BHEHDMKHJBI : KBHCDJBOPJL
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class IPGGPDMLIIL : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public BHEHDMKHJBI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public IPGGPDMLIIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x561AE40", Offset = "0x5619E40", VA = "0x18561AE40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x561AF10", Offset = "0x5619F10", VA = "0x18561AF10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Behaviour MFEOJPNCOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action LEDGIFFFLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private GKOIHBKMELE NFPNNHCIGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly AICFMGNKEOP IJGKMHNCIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	protected readonly JAOAOODOEOH GCDMKDMAPNJ;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MEBOGEFMKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x730650", Offset = "0x72F650", VA = "0x180730650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action ACBCKAMKFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x560BEE0", Offset = "0x560AEE0", VA = "0x18560BEE0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x560C370", Offset = "0x560B370", VA = "0x18560C370", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x560C410", Offset = "0x560B410", VA = "0x18560C410")]
	protected BHEHDMKHJBI(Behaviour MFEOJPNCOBA, [Optional] Action LEDGIFFFLHA, [Optional] AICFMGNKEOP IJGKMHNCIAI, [Optional] JAOAOODOEOH GCDMKDMAPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x560C2D0", Offset = "0x560B2D0", VA = "0x18560C2D0", Slot = "7")]
	public bool LLJKEGONCBN(bool AKNNPOEHKML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x560C280", Offset = "0x560B280", VA = "0x18560C280", Slot = "8")]
	public bool LLJKEGONCBN(Action FFBLFKDINEA, bool AKNNPOEHKML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool CPKFMFOAEPP(Action FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LAGIOPJKIOB(Action FFBLFKDINEA);

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x560BEC0", Offset = "0x560AEC0", VA = "0x18560BEC0")]
	protected void AIELLDGHKIF(Action FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x560BF80", Offset = "0x560AF80", VA = "0x18560BF80")]
	protected LLEFGLIPMKI ECABNPAFOFG(float LABHGKFLOGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x560C180", Offset = "0x560B180", VA = "0x18560C180")]
	private void GJKEEGIKBNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x560C200", Offset = "0x560B200", VA = "0x18560C200")]
	[IteratorStateMachine(typeof(IPGGPDMLIIL))]
	private IEnumerator<FEEMOJCDGJP> IGJKNKJLMPA(float LABHGKFLOGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x560C330", Offset = "0x560B330", VA = "0x18560C330")]
	[CompilerGenerated]
	private void OJBBHDNHNMM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class IFKJGOLDBHO : BHEHDMKHJBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float INAGFHIJNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly int EIMKAJDOILD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly float ACMPCCELHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private readonly float[] AMHFFLIODOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int BGIPKJEACKO;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x561AB70", Offset = "0x5619B70", VA = "0x18561AB70")]
	public IFKJGOLDBHO(Behaviour MFEOJPNCOBA, float MONEAPEHKKH, int EIMKAJDOILD, [Optional] Action LEDGIFFFLHA, float ACMPCCELHHG = 0f, [Optional] AICFMGNKEOP IJGKMHNCIAI, [Optional] JAOAOODOEOH GCDMKDMAPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "9")]
	protected override bool CPKFMFOAEPP(Action FFBLFKDINEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x561A8B0", Offset = "0x56198B0", VA = "0x18561A8B0", Slot = "10")]
	protected override bool LAGIOPJKIOB(Action FFBLFKDINEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x561AAE0", Offset = "0x5619AE0", VA = "0x18561AAE0")]
	private void OBGDIBJLHPJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class MOMKBILHJJA : BHEHDMKHJBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly float CJDHBKDNNCE;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5617D90", Offset = "0x5616D90", VA = "0x185617D90")]
	public MOMKBILHJJA(Behaviour MFEOJPNCOBA, float CJDHBKDNNCE, [Optional] Action LEDGIFFFLHA, [Optional] AICFMGNKEOP IJGKMHNCIAI, [Optional] JAOAOODOEOH GCDMKDMAPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "9")]
	protected override bool CPKFMFOAEPP(Action FFBLFKDINEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5620180", Offset = "0x561F180", VA = "0x185620180", Slot = "10")]
	protected override bool LAGIOPJKIOB(Action FFBLFKDINEA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class FKCPFAGPDOK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class OBBJGBBBMDB : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public OBBJGBBBMDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x5620810", Offset = "0x561F810", VA = "0x185620810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x56208B0", Offset = "0x561F8B0", VA = "0x1856208B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private ALMNDBMKBBN NLALAINMGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private ADIFEAAPNPC MFEOJPNCOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Action<float> GIIBOHCLAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private float AIAEHOKMDBJ;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x56142D0", Offset = "0x56132D0", VA = "0x1856142D0")]
	public FKCPFAGPDOK(ADIFEAAPNPC MFEOJPNCOBA, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5614120", Offset = "0x5613120", VA = "0x185614120")]
	private void PNOAIAGGNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x5613FC0", Offset = "0x5612FC0", VA = "0x185613FC0")]
	private void OENEBNFFMKP(string CNMFEBEOFOM, Action AHFEMKBPEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x5613F50", Offset = "0x5612F50", VA = "0x185613F50")]
	[IteratorStateMachine(typeof(OBBJGBBBMDB))]
	private IEnumerator<FEEMOJCDGJP> MBBMPJEADMP(Action AHFEMKBPEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5613D40", Offset = "0x5612D40", VA = "0x185613D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5613DA0", Offset = "0x5612DA0", VA = "0x185613DA0")]
	[CompilerGenerated]
	private void INIHJCANKLA(string CJDLKEIECEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public sealed class MLJCMBIBDPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[CompilerGenerated]
	private sealed class EFDKNAGPBEF : IEnumerator<FEEMOJCDGJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private FEEMOJCDGJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private FEEMOJCDGJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6E3200", Offset = "0x6E2200", VA = "0x1806E3200")]
		[DebuggerHidden]
		public EFDKNAGPBEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5612230", Offset = "0x5611230", VA = "0x185612230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x56122D0", Offset = "0x56112D0", VA = "0x1856122D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private ALMNDBMKBBN NLALAINMGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private MonoBehaviour GKLOBNBPFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Action CHENOCAGDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private Action<float> GIIBOHCLAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private float AIAEHOKMDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool MPEGNHBLLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private readonly AICFMGNKEOP IJGKMHNCIAI;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x561FF80", Offset = "0x561EF80", VA = "0x18561FF80")]
	public MLJCMBIBDPN(MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x561FD40", Offset = "0x561ED40", VA = "0x18561FD40")]
	public MLJCMBIBDPN(MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x561FAF0", Offset = "0x561EAF0", VA = "0x18561FAF0")]
	public MLJCMBIBDPN(MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4316590", Offset = "0x4315590", VA = "0x184316590")]
	private MLJCMBIBDPN(AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x561ED70", Offset = "0x561DD70", VA = "0x18561ED70")]
	internal static MLJCMBIBDPN ANECANOBCDK(MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x561F010", Offset = "0x561E010", VA = "0x18561F010")]
	private void CMNJABNFFNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x561F700", Offset = "0x561E700", VA = "0x18561F700")]
	private void ONHAGIOADNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x561F940", Offset = "0x561E940", VA = "0x18561F940")]
	private void PNOAIAGGNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x561F1E0", Offset = "0x561E1E0", VA = "0x18561F1E0")]
	private void FGBMGIHGMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x561F5D0", Offset = "0x561E5D0", VA = "0x18561F5D0")]
	private void OENEBNFFMKP(string CNMFEBEOFOM, Action AHFEMKBPEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x561F440", Offset = "0x561E440", VA = "0x18561F440")]
	[IteratorStateMachine(typeof(EFDKNAGPBEF))]
	private IEnumerator<FEEMOJCDGJP> MBBMPJEADMP(Action AHFEMKBPEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x561F180", Offset = "0x561E180", VA = "0x18561F180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x561F3B0", Offset = "0x561E3B0", VA = "0x18561F3B0")]
	[CompilerGenerated]
	private void KPEIPDDGDPN(string CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x561F540", Offset = "0x561E540", VA = "0x18561F540")]
	[CompilerGenerated]
	private void NDPCPMCHJKH(string CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x561F8B0", Offset = "0x561E8B0", VA = "0x18561F8B0")]
	[CompilerGenerated]
	private void OPHDCEKJIFP(string CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x561F4B0", Offset = "0x561E4B0", VA = "0x18561F4B0")]
	[CompilerGenerated]
	private void NDECIBKLCPB(string CJDLKEIECEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[Flags]
internal enum JADEDNNEEGN : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class IBIPOEDIABF : JAOAOODOEOH
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public float OKADPEMLCJG
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x561A0D0", Offset = "0x56190D0", VA = "0x18561A0D0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public float APJLDCLNPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x561A050", Offset = "0x5619050", VA = "0x18561A050", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public double AIHJKLDBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x561A030", Offset = "0x5619030", VA = "0x18561A030", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x561A060", Offset = "0x5619060", VA = "0x18561A060")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void KFLICAKIADO(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	[Preserve]
	internal IBIPOEDIABF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal interface JJKHFFLGAFJ
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KLGJENPDLEM(string GOENAEMJAON);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IPJKCDIIPJD();
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal interface POHJDCGNHFF
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	string DBDKMHBCKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	bool APJNBIELNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool KGFFDKBPMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class LPHPICONGPB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public FNKHGEGIKDO APCNPIOJPFK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int NOAKOLDJPCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF30", Offset = "0x6FEF30", VA = "0x1806FFF30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x561DFA0", Offset = "0x561CFA0", VA = "0x18561DFA0")]
	public static FEEMOJCDGJP AMLGIIENCIE(IEnumerator<FEEMOJCDGJP> DFCONPKBPHE, DDELICCCDIK LHCEHKBEGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x561E150", Offset = "0x561D150", VA = "0x18561E150")]
	public FEEMOJCDGJP AMLGIIENCIE(DDELICCCDIK[] DBKOPDANJGN, IEnumerator<FEEMOJCDGJP>[] PCJMBONPKDC, FEEMOJCDGJP[] OEOIIILFJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x561E230", Offset = "0x561D230", VA = "0x18561E230")]
	public void EOJHBCLCBNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x561E3A0", Offset = "0x561D3A0", VA = "0x18561E3A0")]
	public void KLGGPOBMEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x561E260", Offset = "0x561D260", VA = "0x18561E260")]
	public void FJIGKMOIOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x561E230", Offset = "0x561D230", VA = "0x18561E230")]
	public void DAMKNHMBEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public LPHPICONGPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class FNKHGEGIKDO
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct GLKJIGLCOGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public LPHPICONGPB JBNGKGDECHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ADIFEAAPNPC IGIFCKBDGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public DDELICCCDIK OABFIAGMPHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public IEnumerator<FEEMOJCDGJP> HBPFBDCNKNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public FEEMOJCDGJP CAFAPJAOHLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public JADEDNNEEGN GNFDBPCFIHN;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public struct AGBADAMBLJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public FEILFOOICNG.KEGPNCJFLFJ LAHBKKMIDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public List<GLKJIGLCOGN> KKILMFPJAFJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GDNLHKPPCLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public DDELICCCDIK promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public FNKHGEGIKDO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public ADIFEAAPNPC context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public LPHPICONGPB routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public JADEDNNEEGN coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public FEEMOJCDGJP currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public IEnumerator<FEEMOJCDGJP> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public GDNLHKPPCLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5616FB0", Offset = "0x5615FB0", VA = "0x185616FB0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[CompilerGenerated]
	private sealed class OBKJFBPKOMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public LPHPICONGPB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public FNKHGEGIKDO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public OBKJFBPKOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x56208F0", Offset = "0x561F8F0", VA = "0x1856208F0")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class EBOLKMJMLAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public LPHPICONGPB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public FNKHGEGIKDO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EBOLKMJMLAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x56117C0", Offset = "0x56107C0", VA = "0x1856117C0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[CompilerGenerated]
	private sealed class EPBAAJANLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public LPHPICONGPB schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public FNKHGEGIKDO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
		public EPBAAJANLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x5612790", Offset = "0x5611790", VA = "0x185612790")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const JADEDNNEEGN FEKKPEHBOEE = JADEDNNEEGN.Cancelled | JADEDNNEEGN.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private bool[] DCBECIGNCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<JADEDNNEEGN> KLIDOEJNFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<float> PCFAGMOMJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> KMLCBDBLJCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> IPJBIDCPGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NativeArray<int> CLMFIHBMNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeArray<int> PKHGPPEKCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NativeArray<int> FIPFIDNDHFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private LPHPICONGPB[] CBLAECACEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private DDELICCCDIK[] DBKOPDANJGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ADIFEAAPNPC[] LNIBJHFLMBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private IEnumerator<FEEMOJCDGJP>[] BHMNDAPKANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private FEEMOJCDGJP[] FEPKKPPOJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private int GDEDCAFOANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private int KNECCHHDDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly int OOBCJODNMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private float JJLHGJFKCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private KEELEOHAFAO AEOOGPOOKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private JobHandle CAPHIPKKKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<LPHPICONGPB> JPCPGHILDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool ONFBIAMFAEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private List<Action> LEAOIAMNBOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private List<Action> GHPCIIPOOMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private bool AMIOLLDGCAD;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public AGBADAMBLJD[] AMMODBIAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x115F140", Offset = "0x115E140", VA = "0x18115F140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x56146A0", Offset = "0x56136A0", VA = "0x1856146A0")]
	private static int AJGJHBDECKP(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x56167D0", Offset = "0x56157D0", VA = "0x1856167D0")]
	public FNKHGEGIKDO(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x56144B0", Offset = "0x56134B0", VA = "0x1856144B0")]
	private void AEMFIHOLJOD(ref int PFDMFFDIHPJ, int DHPEOIEBOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5616270", Offset = "0x5615270", VA = "0x185616270")]
	public void LCMIJEIOMGK(ADIFEAAPNPC MFEOJPNCOBA, FEEMOJCDGJP EIKEGOMHMAF, IEnumerator<FEEMOJCDGJP> DFCONPKBPHE, DDELICCCDIK LHCEHKBEGOH, [Optional] LPHPICONGPB KDNELECCAJA, JADEDNNEEGN LEJGLEKCADN = JADEDNNEEGN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5614E00", Offset = "0x5613E00", VA = "0x185614E00")]
	public void AJKNHJEFJIF(IEnumerable<GLKJIGLCOGN> AKJLLPOBNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5615790", Offset = "0x5614790", VA = "0x185615790")]
	private GLKJIGLCOGN IKHPBFLCGEA(int NAIHMNOEADG)
	{
		return default(GLKJIGLCOGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x5615CA0", Offset = "0x5614CA0", VA = "0x185615CA0")]
	private void JCJICFGGAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x2358DE0", Offset = "0x2357DE0", VA = "0x182358DE0")]
	private static void CAKDOENPPBL<T>(int NAIHMNOEADG, T[] MGNKPLJLGNB, int MKMGHJFMNMB, [Optional] T JDMBMLBMPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2358DC0", Offset = "0x2357DC0", VA = "0x182358DC0")]
	private static void CAKDOENPPBL<T>(int NAIHMNOEADG, NativeArray<T> MGNKPLJLGNB, int MKMGHJFMNMB, [Optional] T JDMBMLBMPAL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x56163F0", Offset = "0x56153F0", VA = "0x1856163F0")]
	private void NJCJLFOBDNM(IEnumerable<GLKJIGLCOGN> AKJLLPOBNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x56154E0", Offset = "0x56144E0", VA = "0x1856154E0")]
	private void HLAKBBMMPDP(GLKJIGLCOGN JCPDBIPDDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x5615220", Offset = "0x5614220", VA = "0x185615220")]
	private HMMECMONAPF EEPGEBPADOB(int HFHPPDEEGDF)
	{
		return default(HMMECMONAPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x56155B0", Offset = "0x56145B0", VA = "0x1856155B0")]
	public void IHAMIGPHEFD(float GIGIGOCEOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x5615120", Offset = "0x5614120", VA = "0x185615120")]
	private void DCBOEAGHFJD(Action BECDKHGLGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x56151A0", Offset = "0x56141A0", VA = "0x1856151A0")]
	private void EALKAIIOEAA(Action BECDKHGLGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x56146D0", Offset = "0x56136D0", VA = "0x1856146D0")]
	public void AJHEANEMIJJ(float GIGIGOCEOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x5616170", Offset = "0x5615170", VA = "0x185616170")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x5614FF0", Offset = "0x5613FF0", VA = "0x185614FF0")]
	public void DAMKNHMBEAM(LPHPICONGPB BOKAHCFBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x5616040", Offset = "0x5615040", VA = "0x185616040")]
	public void JIGPOMNNKDI(LPHPICONGPB BOKAHCFBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x56166A0", Offset = "0x56156A0", VA = "0x1856166A0")]
	public void OHBKAKPGIEC(LPHPICONGPB BOKAHCFBBLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CCAFLGPMEIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static readonly CCAFLGPMEIK CKOAHOIJBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly Action PECNBFJIPAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private bool LJINJAFAKDG;

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	public CCAFLGPMEIK(Action PECNBFJIPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x560C810", Offset = "0x560B810", VA = "0x18560C810", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public interface BNPLJJKDELG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MMGFILENFNB(UnityEngine.Object MFEOJPNCOBA, Action<T> FABMJAKDJBF);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public interface MEHKBICOFBB<T> : global::BNPLJJKDELG<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	new T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class DGHLNMJLKBF<T> : global::MEHKBICOFBB<T>, global::BNPLJJKDELG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class CBDOFFDNNOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public global::DGHLNMJLKBF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public global::LPBEACKBGAJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x10FDE40", Offset = "0x10FCE40", VA = "0x1810FDE40")]
		public CBDOFFDNNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x2214B60", Offset = "0x2213B60", VA = "0x182214B60")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private static GameObject OJLCELFOEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly List<global::LPBEACKBGAJ<UnityEngine.Object, Action<T>>> MHHNHHHDBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private T MPCOEEBDOCG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public T KMEGGOIFMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F98D0", Offset = "0x6F88D0", VA = "0x1806F98D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x29A7070", Offset = "0x29A6070", VA = "0x1829A7070", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x29A7AA0", Offset = "0x29A6AA0", VA = "0x1829A7AA0")]
	private static bool PCJLNJJODLM(T BECDKHGLGNB, T ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x29A7B00", Offset = "0x29A6B00", VA = "0x1829A7B00")]
	public DGHLNMJLKBF(T FLKCFPCNOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x29A7900", Offset = "0x29A6900", VA = "0x1829A7900", Slot = "6")]
	public IDisposable MMGFILENFNB(UnityEngine.Object MFEOJPNCOBA, Action<T> FABMJAKDJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x29A7430", Offset = "0x29A6430", VA = "0x1829A7430")]
	private void DLMBKJDINDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal class HAKOLFLOFJL : GELMFPINIAK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly AICFMGNKEOP IJGKMHNCIAI;

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x56181C0", Offset = "0x56171C0", VA = "0x1856181C0")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void KFLICAKIADO(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	[Preserve]
	internal HAKOLFLOFJL([KCHLPHCLLFB(null)] AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5618120", Offset = "0x5617120", VA = "0x185618120", Slot = "4")]
	public IDisposable DCNAHEKJLMF(float FOOKFHONNOI, Action<float> PEPHBHFBJFE, bool MPEGNHBLLBF = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[BurstCompile]
internal struct KEELEOHAFAO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	[ReadOnly]
	public float DHIFFJLCEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	[ReadOnly]
	public int FNJJCCJGELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private NativeArray<int> JKPMAJBGMIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private NativeArray<int> BIBBNDLDMHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private NativeArray<int> IFHCFFHBMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[ReadOnly]
	public NativeArray<JADEDNNEEGN> PBIADKHBGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	[ReadOnly]
	public NativeArray<float> CFGEEEDOKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	[WriteOnly]
	public NativeArray<int> CLMFIHBMNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	[WriteOnly]
	public NativeArray<int> KMLCBDBLJCD;

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x561C390", Offset = "0x561B390", VA = "0x18561C390")]
	public static KEELEOHAFAO BMDGCEOIEEG(int LGMJBPFILHN, float GIGIGOCEOOM, NativeArray<JADEDNNEEGN> PLGELLNPOIO, NativeArray<float> LBHDNOKBOCO, NativeArray<int> DGEBKGKHHNC, NativeArray<int> HKPMCPEAFKI, NativeArray<int> AJCJMPEDKGE, NativeArray<int> BIBBNDLDMHP, NativeArray<int> IFHCFFHBMIM)
	{
		return default(KEELEOHAFAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x561C3F0", Offset = "0x561B3F0", VA = "0x18561C3F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x561C790", Offset = "0x561B790", VA = "0x18561C790")]
	private bool LNBJMHACDIO(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x561C760", Offset = "0x561B760", VA = "0x18561C760")]
	private void KNNGDNFHHFC(NativeArray<int> CGKFGHEEOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x561C4D0", Offset = "0x561B4D0", VA = "0x18561C4D0")]
	private int FEAEKPMPNOA(int JFOFFBJLNON, int CEGDEMKCCLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x561C7D0", Offset = "0x561B7D0", VA = "0x18561C7D0")]
	private void NGAACNFCNOH(NativeArray<int> CGKFGHEEOGG, int FKKIIOKEOFL, int ANOKHAKIKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x561C530", Offset = "0x561B530", VA = "0x18561C530")]
	private void HDJIBMJJHEA(NativeArray<int> CGKFGHEEOGG, int AGJGGDJPHLO, int BGFGKPDOHDM, int HAGCPHDOLON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PAIMOIHBPMD : JHKJKEKEDBJ, AICFMGNKEOP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private FNKHGEGIKDO[] KJOLLCLPHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private JJKHFFLGAFJ GHCNIMDMENK;

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5622340", Offset = "0x5621340", VA = "0x185622340")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void KFLICAKIADO(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x56225A0", Offset = "0x56215A0", VA = "0x1856225A0")]
	[Preserve]
	public PAIMOIHBPMD([KCHLPHCLLFB(null)] JCBLIDPOHJF OEPOKHPMPLF, [KCHLPHCLLFB(null)] JAOAOODOEOH GCDMKDMAPNJ, [KCHLPHCLLFB(null)] AINCEMGEEDM NOJAJGKADCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5622460", Offset = "0x5621460", VA = "0x185622460", Slot = "12")]
	public override ALMNDBMKBBN PGCHPKMGCOO(ADIFEAAPNPC MFEOJPNCOBA, IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5621E80", Offset = "0x5620E80", VA = "0x185621E80", Slot = "13")]
	public override void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5622160", Offset = "0x5621160", VA = "0x185622160", Slot = "15")]
	public override void JBCGNJHFECP(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5621DA0", Offset = "0x5620DA0", VA = "0x185621DA0", Slot = "14")]
	protected override void HMNCABBCMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5621D60", Offset = "0x5620D60", VA = "0x185621D60")]
	private FNKHGEGIKDO HFCIIEODLEI(FEILFOOICNG.KEGPNCJFLFJ HAOFNDAEGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x56223B0", Offset = "0x56213B0", VA = "0x1856223B0", Slot = "16")]
	internal override PENLMKCOHMB NIHCPMEDDED(IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ, Behaviour MFEOJPNCOBA, DDELICCCDIK LHCEHKBEGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5621B50", Offset = "0x5620B50", VA = "0x185621B50", Slot = "17")]
	internal override HOMGBNCPHJC ANEHHKANACK(FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x5621BC0", Offset = "0x5620BC0", VA = "0x185621BC0")]
	private void ANFFNCBBGEG(FNKHGEGIKDO NLLENCMNHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5621CF0", Offset = "0x5620CF0", VA = "0x185621CF0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public abstract class JHKJKEKEDBJ : AICFMGNKEOP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private readonly JCBLIDPOHJF OEPOKHPMPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	protected readonly JAOAOODOEOH GCDMKDMAPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private readonly AINCEMGEEDM NOJAJGKADCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private HOMGBNCPHJC[] MADKPAIKFMC;

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public static AICFMGNKEOP FDNKALDKIIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x561BF50", Offset = "0x561AF50", VA = "0x18561BF50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static bool LCLDHDEMAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public FEILFOOICNG.KEGPNCJFLFJ MJFAKMBBGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6DF040", Offset = "0x6DE040", VA = "0x1806DF040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FEILFOOICNG.KEGPNCJFLFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6FFF30", Offset = "0x6FEF30", VA = "0x1806FFF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JAOAOODOEOH HONBHIFJHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E0120", Offset = "0x6DF120", VA = "0x1806E0120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x561B580", Offset = "0x561A580", VA = "0x18561B580")]
	public static ALMNDBMKBBN FAABJPIHHKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x561BFE0", Offset = "0x561AFE0", VA = "0x18561BFE0")]
	[Preserve]
	protected JHKJKEKEDBJ([KCHLPHCLLFB(null)] JCBLIDPOHJF OEPOKHPMPLF, [KCHLPHCLLFB(null)] JAOAOODOEOH GCDMKDMAPNJ, [KCHLPHCLLFB(null)] AINCEMGEEDM NOJAJGKADCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x561BD10", Offset = "0x561AD10", VA = "0x18561BD10", Slot = "6")]
	public ALMNDBMKBBN LDGDMJHFFKN(IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x561BD20", Offset = "0x561AD20", VA = "0x18561BD20", Slot = "7")]
	public ALMNDBMKBBN LDGDMJHFFKN(Behaviour MFEOJPNCOBA, IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract ALMNDBMKBBN PGCHPKMGCOO(ADIFEAAPNPC MFEOJPNCOBA, IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x561B850", Offset = "0x561A850", VA = "0x18561B850", Slot = "13")]
	public virtual void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x561BC90", Offset = "0x561AC90", VA = "0x18561BC90", Slot = "9")]
	public void JFEJCMBFABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x561B830", Offset = "0x561A830", VA = "0x18561B830", Slot = "14")]
	protected virtual void HMNCABBCMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x561B620", Offset = "0x561A620", VA = "0x18561B620")]
	private void FMBIKGIEHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x561BA30", Offset = "0x561AA30", VA = "0x18561BA30")]
	private void INOEJILCGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x561B560", Offset = "0x561A560", VA = "0x18561B560")]
	private void EJBOICBIHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x561BCF0", Offset = "0x561ACF0", VA = "0x18561BCF0")]
	private void KEICLDDDMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x561BFC0", Offset = "0x561AFC0", VA = "0x18561BFC0")]
	private void MOJBGLABFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x561BFA0", Offset = "0x561AFA0", VA = "0x18561BFA0")]
	private void MLEAECJPDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x561B640", Offset = "0x561A640", VA = "0x18561B640")]
	private void FNLJFFNKACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x561BA50", Offset = "0x561AA50", VA = "0x18561BA50", Slot = "15")]
	public virtual void JBCGNJHFECP(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x561B660", Offset = "0x561A660", VA = "0x18561B660")]
	private void GGLPHLMBPFE(HOMGBNCPHJC NLLENCMNHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0xBA2610", Offset = "0xBA1610", VA = "0x180BA2610")]
	private HOMGBNCPHJC LABLAHMNEAB(FEILFOOICNG.KEGPNCJFLFJ HAOFNDAEGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract PENLMKCOHMB NIHCPMEDDED(IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ, Behaviour GKLOBNBPFOD, DDELICCCDIK AIKCBNDJHJH);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract HOMGBNCPHJC ANEHHKANACK(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x561B1E0", Offset = "0x561A1E0", VA = "0x18561B1E0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class PENLMKCOHMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly DDELICCCDIK LHCEHKBEGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly POHJDCGNHFF MFEOJPNCOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly bool ACJENNBPJGG;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IEnumerator<FEEMOJCDGJP> HBPFBDCNKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E0AC0", Offset = "0x6DFAC0", VA = "0x1806E0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x6FF130", Offset = "0x6FE130", VA = "0x1806FF130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FEEMOJCDGJP CAFAPJAOHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x6FF140", Offset = "0x6FE140", VA = "0x1806FF140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool PJLBBMNHAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x5622930", Offset = "0x5621930", VA = "0x185622930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CHBCKGCFLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA61D60", Offset = "0xA60D60", VA = "0x180A61D60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x222C6A0", Offset = "0x222B6A0", VA = "0x18222C6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string DBDKMHBCKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E6570", Offset = "0x6E5570", VA = "0x1806E6570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E6590", Offset = "0x6E5590", VA = "0x1806E6590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public float GIGLFAAHIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x1012170", Offset = "0x1011170", VA = "0x181012170")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x11C4D30", Offset = "0x11C3D30", VA = "0x1811C4D30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5622B60", Offset = "0x5621B60", VA = "0x185622B60")]
	public PENLMKCOHMB(IEnumerator<FEEMOJCDGJP> DFCONPKBPHE, POHJDCGNHFF MFEOJPNCOBA, DDELICCCDIK LHCEHKBEGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5622670", Offset = "0x5621670", VA = "0x185622670")]
	public FEEMOJCDGJP AMLGIIENCIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5622A30", Offset = "0x5621A30", VA = "0x185622A30")]
	public bool LEPNINLOPJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x56229B0", Offset = "0x56219B0", VA = "0x1856229B0")]
	public void DAMKNHMBEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5622AA0", Offset = "0x5621AA0", VA = "0x185622AA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x14B4900", Offset = "0x14B3900", VA = "0x1814B4900")]
	[CompilerGenerated]
	private void NJAJFFEDKLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
internal sealed class DDELICCCDIK : MLFAMGPIOIC, ALMNDBMKBBN, GKOIHBKMELE, LLEFGLIPMKI, IEnumerator, FEEMOJCDGJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private FEILFOOICNG.KEGPNCJFLFJ AOCBPAGEFFL;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	private FEILFOOICNG.KEGPNCJFLFJ DELBMBLDGEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x783530", Offset = "0x782530", VA = "0x180783530", Slot = "23")]
		get
		{
			return default(FEILFOOICNG.KEGPNCJFLFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public FEILFOOICNG.KEGPNCJFLFJ APCNPIOJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA481B0", Offset = "0xA471B0", VA = "0x180A481B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float MFEEAIKOFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x130EAF0", Offset = "0x130DAF0", VA = "0x18130EAF0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool NIIDNGHHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E2D00", Offset = "0x6E1D00", VA = "0x1806E2D00", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x5610310", Offset = "0x560F310", VA = "0x185610310", Slot = "24")]
	private bool PMAAAEKNGKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x5610300", Offset = "0x560F300", VA = "0x185610300", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x5610330", Offset = "0x560F330", VA = "0x185610330")]
	public DDELICCCDIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
internal enum HMMECMONAPF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal sealed class HOMGBNCPHJC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public enum EDPHPBALOMG
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public struct GODHOADNMFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public FEILFOOICNG.KEGPNCJFLFJ LAHBKKMIDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public EDPHPBALOMG KDOCKCBJKMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public List<PENLMKCOHMB> LDGKEJDEFDL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private static readonly EDPHPBALOMG[] LEMOBEFLAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private bool IHKFBNAAGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly PENLMKCOHMB[] FDHMBBLLGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly List<PENLMKCOHMB> HCHPJBBOHNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly Stack<int> MEKLJHMNGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly List<PENLMKCOHMB> MJPMMBMLLCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private readonly Stack<int> PPOOLNMAOEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private readonly JJKHFFLGAFJ ACLHDGGPIOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private bool AMIOLLDGCAD;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public GODHOADNMFK[,] KIIKCINICLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x6DF0D0", Offset = "0x6DE0D0", VA = "0x1806DF0D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x5619B60", Offset = "0x5618B60", VA = "0x185619B60")]
	public HOMGBNCPHJC(FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, JJKHFFLGAFJ ACLHDGGPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5618900", Offset = "0x5617900", VA = "0x185618900")]
	public void EKKOPHAELNL(PENLMKCOHMB DFCONPKBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5619680", Offset = "0x5618680", VA = "0x185619680")]
	public void JJLHKLCKCMO(IList<PENLMKCOHMB> PCJMBONPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5618A20", Offset = "0x5617A20", VA = "0x185618A20")]
	public void FLCJBALPADD(IList<PENLMKCOHMB> PCJMBONPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5619950", Offset = "0x5618950", VA = "0x185619950")]
	private void OEDJADBCKMJ(PENLMKCOHMB DFCONPKBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5618FD0", Offset = "0x5617FD0", VA = "0x185618FD0")]
	private void HNEJEJCBGBB(IList<PENLMKCOHMB> PCJMBONPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x5618CF0", Offset = "0x5617CF0", VA = "0x185618CF0")]
	private HMMECMONAPF GLILPCBCBDA(PENLMKCOHMB DFCONPKBPHE)
	{
		return default(HMMECMONAPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5618E90", Offset = "0x5617E90", VA = "0x185618E90")]
	public void HMNCABBCMFO(float GIGIGOCEOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5619470", Offset = "0x5618470", VA = "0x185619470")]
	public void JFEJCMBFABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5619150", Offset = "0x5618150", VA = "0x185619150")]
	private void IBFKIIPJCLM(List<PENLMKCOHMB> PCJMBONPKDC, Stack<int> CGPABOMCFBL, bool GMLFIMIHBCD, float NDLLDDCLBCC = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x56186A0", Offset = "0x56176A0", VA = "0x1856186A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x56187E0", Offset = "0x56177E0", VA = "0x1856187E0")]
	private void EDIEAIGICNM(List<PENLMKCOHMB> PCJMBONPKDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class DFLEBBHAALO : JJKHFFLGAFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "4")]
	public void KLGJENPDLEM(string GOENAEMJAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6F8EB0", Offset = "0x6F7EB0", VA = "0x1806F8EB0", Slot = "5")]
	public void IPJKCDIIPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
	public DFLEBBHAALO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal class GJMICENJNMP : POHJDCGNHFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private readonly Behaviour GKLOBNBPFOD;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string DBDKMHBCKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5617A80", Offset = "0x5616A80", VA = "0x185617A80", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool APJNBIELNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5617B10", Offset = "0x5616B10", VA = "0x185617B10", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KGFFDKBPMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5617B70", Offset = "0x5616B70", VA = "0x185617B70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6DFF40", Offset = "0x6DEF40", VA = "0x1806DFF40")]
	public GJMICENJNMP(Behaviour GKLOBNBPFOD)
	{
	}
}
namespace Cpp2IlInjected
{
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
}
