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
	[Cpp2IlInjected.Address(RVA = "0x56AF650", Offset = "0x56AEA50", VA = "0x1856AF650")]
	public DNNODMLIEOK(ThreadPriority KACGJFGJHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x56AF640", Offset = "0x56AEA40", VA = "0x1856AF640", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x56BF640", Offset = "0x56BEA40", VA = "0x1856BF640")]
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
				[Cpp2IlInjected.Address(RVA = "0x56B5AE0", Offset = "0x56B4EE0", VA = "0x1856B5AE0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56B14E0", Offset = "0x56B08E0", VA = "0x1856B14E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56B9C60", Offset = "0x56B9060", VA = "0x1856B9C60")]
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
				[Cpp2IlInjected.Address(RVA = "0x56BF340", Offset = "0x56BE740", VA = "0x1856BF340")]
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
				[Cpp2IlInjected.Address(RVA = "0x56AF3B0", Offset = "0x56AE7B0", VA = "0x1856AF3B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56AF1D0", Offset = "0x56AE5D0", VA = "0x1856AF1D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56B1100", Offset = "0x56B0500", VA = "0x1856B1100")]
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
				[Cpp2IlInjected.Address(RVA = "0x56AA6D0", Offset = "0x56A9AD0", VA = "0x1856AA6D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56AA8E0", Offset = "0x56A9CE0", VA = "0x1856AA8E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x56ABA00", Offset = "0x56AAE00", VA = "0x1856ABA00")]
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
					[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
					public PPNMJOIBCFG()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x56C1E40", Offset = "0x56C1240", VA = "0x1856C1E40")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable FBJCJMLLPLH;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x56BBBE0", Offset = "0x56BAFE0", VA = "0x1856BBBE0")]
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
					[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
					public GKMOGEHKJMO()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x56B6BA0", Offset = "0x56B5FA0", VA = "0x1856B6BA0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x56B12E0", Offset = "0x56B06E0", VA = "0x1856B12E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public IKMJKFIDKFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x56B9A30", Offset = "0x56B8E30", VA = "0x1856B9A30")]
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
			[Cpp2IlInjected.Address(RVA = "0x56ACF70", Offset = "0x56AC370", VA = "0x1856ACF70")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x56ABE10", Offset = "0x56AB210", VA = "0x1856ABE10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x56AD170", Offset = "0x56AC570", VA = "0x1856AD170")]
		private static void ONMKOACHOFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x56AC2B0", Offset = "0x56AB6B0", VA = "0x1856AC2B0")]
		private static void FJKLFPCEHMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x56ABE50", Offset = "0x56AB250", VA = "0x1856ABE50")]
		private static void DPHAKHOEGCL(string ABECJBOAJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x56ABBE0", Offset = "0x56AAFE0", VA = "0x1856ABBE0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x56ACFB0", Offset = "0x56AC3B0", VA = "0x1856ACFB0")]
		private static void GHNPLJIBLIP(HENMDCADECJ.FIJJGIGAEDM EBOIOCBODNI, ref PlayerLoopSystem BHDBDABFNLD, Type MLLAPDIOPCE, Type PKCGAKAPAOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x56ACB80", Offset = "0x56ABF80", VA = "0x1856ACB80")]
		private static void FODNMICIAJI(ref PlayerLoopSystem BHDBDABFNLD, Type MLLAPDIOPCE, Type PKCGAKAPAOL, EPABBABOMOA JFFGLOCNOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x56AC180", Offset = "0x56AB580", VA = "0x1856AC180")]
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
		[Cpp2IlInjected.Address(RVA = "0x56BCA20", Offset = "0x56BBE20", VA = "0x1856BCA20")]
		public LNLJOCIKFNK(FIJJGIGAEDM OMBLODAMGIE, int NHMBMIDCCEJ = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x56BC950", Offset = "0x56BBD50", VA = "0x1856BC950")]
		public void OALOBLPHMGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x56BC9C0", Offset = "0x56BBDC0", VA = "0x1856BC9C0")]
		public void ONKJHEMGFEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x56BC750", Offset = "0x56BBB50", VA = "0x1856BC750")]
		public void JMJIJHIIEHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static FIJJGIGAEDM[] GGGMFCOKMBA;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static LNLJOCIKFNK[] CIKJEADJLGE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x56B6F40", Offset = "0x56B6340", VA = "0x1856B6F40")]
	public static LNLJOCIKFNK FONONLJMKAP(FIJJGIGAEDM EBOIOCBODNI, int NHMBMIDCCEJ = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x56B71C0", Offset = "0x56B65C0", VA = "0x1856B71C0")]
	public static LNLJOCIKFNK KPBDBKOJMMH(FIJJGIGAEDM EBOIOCBODNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x56B7110", Offset = "0x56B6510", VA = "0x1856B7110")]
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
		[Cpp2IlInjected.Address(RVA = "0x56C1D30", Offset = "0x56C1130", VA = "0x1856C1D30", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double MHLDKBGDLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x1EF3B90", Offset = "0x1EF2F90", VA = "0x181EF3B90", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double BEDFHIHFBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3586B50", Offset = "0x3585F50", VA = "0x183586B50", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x56C1D90", Offset = "0x56C1190", VA = "0x1856C1D90")]
	public PMOLBFDOCCP(int IPBHMLBJKHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x56C1C00", Offset = "0x56C1000", VA = "0x1856C1C00", Slot = "7")]
	public void KFAAAFDIAME(double LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x56C1B90", Offset = "0x56C0F90", VA = "0x1856C1B90", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double MHLDKBGDLND
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x3966330", Offset = "0x3965730", VA = "0x183966330", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BEDFHIHFBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA50E30", Offset = "0xA50230", VA = "0x180A50E30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double MJLKMGPGGKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x3586B40", Offset = "0x3585F40", VA = "0x183586B40")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double FEBKMEKDEHG
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x354F3F0", Offset = "0x354E7F0", VA = "0x18354F3F0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x56BBA80", Offset = "0x56BAE80", VA = "0x1856BBA80", Slot = "7")]
	public virtual void KFAAAFDIAME(double LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x56BBA40", Offset = "0x56BAE40", VA = "0x1856BBA40", Slot = "8")]
	public virtual void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x56BBBB0", Offset = "0x56BAFB0", VA = "0x1856BBBB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x56BF0B0", Offset = "0x56BE4B0", VA = "0x1856BF0B0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x56BF240", Offset = "0x56BE640", VA = "0x1856BF240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x56BF100", Offset = "0x56BE500", VA = "0x1856BF100", Slot = "7")]
	public override void KFAAAFDIAME(double LGHMENDDLFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x56BF0C0", Offset = "0x56BE4C0", VA = "0x1856BF0C0", Slot = "8")]
	public override void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x56BBBB0", Offset = "0x56BAFB0", VA = "0x1856BBBB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x31B3AC0", Offset = "0x31B2EC0", VA = "0x1831B3AC0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool EEPIMGJCMOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x31B3A70", Offset = "0x31B2E70", VA = "0x1831B3A70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x2742CD0", Offset = "0x27420D0", VA = "0x182742CD0")]
		protected MOOOCEMALOO(TPromise JCEJHOGHOPG, TMainThreadPromise BFJFHBDIGAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x31B3B20", Offset = "0x31B2F20", VA = "0x1831B3B20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x2DC3EE0", Offset = "0x2DC32E0", VA = "0x182DC3EE0")]
		public PIGJCAHCOHE(global::MLDKKGKEACN<T> JCEJHOGHOPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3D50", Offset = "0x2DC3150", VA = "0x182DC3D50", Slot = "6")]
		protected override void EAHEIPPGIGM(global::MLDKKGKEACN<T> JCEJHOGHOPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x2DC3EB0", Offset = "0x2DC32B0", VA = "0x182DC3EB0")]
		[CompilerGenerated]
		private void MHPHDKCGFIK(T GPPHCPBMODE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x14FE630", Offset = "0x14FDA30", VA = "0x1814FE630")]
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
			[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
		public FCCPHALNKCG(Action FFBLFKDINEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x12008A0", Offset = "0x11FFCA0", VA = "0x1812008A0", Slot = "5")]
		public void OIEKBFPKDBB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static readonly List<EBLALNEJKAB> PKCJJEFLCJB;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x23DAC40", Offset = "0x23DA040", VA = "0x1823DAC40")]
	public static global::MLDKKGKEACN<T> PLDPIMEGHCB<T>(this global::MLDKKGKEACN<T> JCEJHOGHOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x56B94B0", Offset = "0x56B88B0", VA = "0x1856B94B0")]
	public static void PLDPIMEGHCB(Action FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x23DAB80", Offset = "0x23D9F80", VA = "0x1823DAB80")]
	private static global::MLDKKGKEACN<T> IILLCLGHHHM<T>(global::MLDKKGKEACN<T> JCEJHOGHOPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x56B90E0", Offset = "0x56B84E0", VA = "0x1856B90E0")]
	private static void GLFCJJIIEOO(EBLALNEJKAB LCMEIMAGMKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x56B8DF0", Offset = "0x56B81F0", VA = "0x1856B8DF0")]
	private static void EGLBBHLEDHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x56B93B0", Offset = "0x56B87B0", VA = "0x1856B93B0")]
	private static void OLKOKJNFOCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x56B92E0", Offset = "0x56B86E0", VA = "0x1856B92E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x56BFE00", Offset = "0x56BF200", VA = "0x1856BFE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x56BBD10", Offset = "0x56BB110", VA = "0x1856BBD10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x56BC380", Offset = "0x56BB780", VA = "0x1856BC380", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x56AB220", Offset = "0x56AA620", VA = "0x1856AB220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x56AB670", Offset = "0x56AAA70", VA = "0x1856AB670", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6E8320", Offset = "0x6E7720", VA = "0x1806E8320", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public NECFMJLNAMJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x56BEED0", Offset = "0x56BE2D0", VA = "0x1856BEED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x56A9D00", Offset = "0x56A9100", VA = "0x1856A9D00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x56AA680", Offset = "0x56A9A80", VA = "0x1856AA680", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x56BD1F0", Offset = "0x56BC5F0", VA = "0x1856BD1F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x56BDA30", Offset = "0x56BCE30", VA = "0x1856BDA30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public AJDIJFNPGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x56AA8B0", Offset = "0x56A9CB0", VA = "0x1856AA8B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public DNOOOLOMEGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x56AF9F0", Offset = "0x56AEDF0", VA = "0x1856AF9F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x56AF690", Offset = "0x56AEA90", VA = "0x1856AF690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x56AFA80", Offset = "0x56AEE80", VA = "0x1856AFA80")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x56AF9B0", Offset = "0x56AEDB0", VA = "0x1856AF9B0", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public KJCBHDFBAMG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x56BB5B0", Offset = "0x56BA9B0", VA = "0x1856BB5B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x56BBA00", Offset = "0x56BAE00", VA = "0x1856BBA00", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x56B16C0", Offset = "0x56B0AC0", VA = "0x1856B16C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private static bool CMDIHJGMBJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x56B2820", Offset = "0x56B1C20", VA = "0x1856B2820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool PGFNPCICEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x56B28D0", Offset = "0x56B1CD0", VA = "0x1856B28D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> PIBJJFAKEDO
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x56B20B0", Offset = "0x56B14B0", VA = "0x1856B20B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x56B1DB0", Offset = "0x56B11B0", VA = "0x1856B1DB0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x56B21B0", Offset = "0x56B15B0", VA = "0x1856B21B0")]
	[DFDEPFOCOOG(GCCGOPEBDFE.EnteredEditModeNextFrame, 0)]
	private static void KCBABHGPKJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x56B2280", Offset = "0x56B1680", VA = "0x1856B2280")]
	[AsyncStateMachine(typeof(LGMFJDNDGAP))]
	public static Task<Scene> KDGJDALOEAA(string CICEEKFBKIJ, LoadSceneMode BMGAIMADGNG = LoadSceneMode.Single, bool IFMOLNHDDCB = false, [Optional] OEPFOLMCINK PNAMKBJBLBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x56B2750", Offset = "0x56B1B50", VA = "0x1856B2750")]
	[AsyncStateMachine(typeof(BOJBCBEIOBC))]
	private static Task OGGCJOHKDKP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x56B19E0", Offset = "0x56B0DE0", VA = "0x1856B19E0")]
	[AsyncStateMachine(typeof(CCDPKEGJEAE))]
	private static Task BOFLJNOMOCA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x56B1880", Offset = "0x56B0C80", VA = "0x1856B1880")]
	[AsyncStateMachine(typeof(ABDJKNLGMAF))]
	private static Task<Scene> BJIKNCCIAEF(string CICEEKFBKIJ, LoadSceneMode BMGAIMADGNG, bool IFMOLNHDDCB, OEPFOLMCINK OKOAEEBPCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x56B1C70", Offset = "0x56B1070", VA = "0x1856B1C70")]
	[AsyncStateMachine(typeof(MABFMMEDMHB))]
	private static Task<Scene> CLHHEBHHFAO(OEPFOLMCINK OKOAEEBPCIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x56B1AD0", Offset = "0x56B0ED0", VA = "0x1856B1AD0")]
	public static global::MLDKKGKEACN<Scene> CIOCCDPNOBF(string CICEEKFBKIJ, LoadSceneMode BMGAIMADGNG = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x56B23E0", Offset = "0x56B17E0", VA = "0x1856B23E0")]
	public static LLEFGLIPMKI MOJJCPIICKE(string CICEEKFBKIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x56B26C0", Offset = "0x56B1AC0", VA = "0x1856B26C0")]
	[IteratorStateMachine(typeof(DNOOOLOMEGI))]
	private static IEnumerator<FEEMOJCDGJP> ODBJIHCGNIG(string CICEEKFBKIJ, LCFGHKNEPEI JFNHMEJJEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x56B1EB0", Offset = "0x56B12B0", VA = "0x1856B1EB0")]
	[IteratorStateMachine(typeof(KJCBHDFBAMG))]
	private static IEnumerator<FEEMOJCDGJP> GHDCIINHFIF(string CICEEKFBKIJ, LoadSceneMode BMGAIMADGNG, global::BLIGMBCADIE<Scene> JFNHMEJJEHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x56B1F50", Offset = "0x56B1350", VA = "0x1856B1F50")]
	public static bool IFHEEONJJPE(out string GHBFBMNCBKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NFOFMHFNDGP
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x56BF030", Offset = "0x56BE430", VA = "0x1856BF030")]
	public static IDisposable NGODGBPOHNK(this ADIFEAAPNPC MFEOJPNCOBA, float FOOKFHONNOI, Action<float> CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x56BEF30", Offset = "0x56BE330", VA = "0x1856BEF30")]
	public static IDisposable AGEHEIHDNGD(this ADIFEAAPNPC MFEOJPNCOBA, Action<float> CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x56BEFB0", Offset = "0x56BE3B0", VA = "0x1856BEFB0")]
	public static IDisposable MPMAJAGOMNC(this ADIFEAAPNPC MFEOJPNCOBA, Action<float> CHENOCAGDJL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EAHKBJPIPDE
{
	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x56AFC60", Offset = "0x56AF060", VA = "0x1856AFC60")]
	public static IDisposable CMNJABNFFNL(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x56AFBE0", Offset = "0x56AEFE0", VA = "0x1856AFBE0")]
	public static IDisposable CMNJABNFFNL(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x56AFFF0", Offset = "0x56AF3F0", VA = "0x1856AFFF0")]
	public static IDisposable HMNCABBCMFO(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x56AFE40", Offset = "0x56AF240", VA = "0x1856AFE40")]
	public static IDisposable EJBOICBIHAK(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x56B0290", Offset = "0x56AF690", VA = "0x1856B0290")]
	public static IDisposable KEICLDDDMEI(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x56AFB60", Offset = "0x56AEF60", VA = "0x1856AFB60")]
	public static IDisposable CJDMNCIGNKG(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x56B00F0", Offset = "0x56AF4F0", VA = "0x1856B00F0")]
	public static IDisposable IMKBOAAGOGO(this MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x56AFF50", Offset = "0x56AF350", VA = "0x1856AFF50")]
	public static IDisposable GFEHAEBONFM(this MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x56AFD80", Offset = "0x56AF180", VA = "0x1856AFD80")]
	public static IDisposable DPCGJHHKGEG(this MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x56AFCE0", Offset = "0x56AF0E0", VA = "0x1856AFCE0")]
	public static IDisposable DCNAHEKJLMF(this MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x56AFAD0", Offset = "0x56AEED0", VA = "0x1856AFAD0")]
	public static IDisposable APAFEHHJPFA(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x56B0200", Offset = "0x56AF600", VA = "0x1856B0200")]
	public static IDisposable JJKEHJJEDNN(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x56B0170", Offset = "0x56AF570", VA = "0x1856B0170")]
	public static IDisposable JCLDGHMABKK(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x56B0060", Offset = "0x56AF460", VA = "0x1856B0060")]
	public static IDisposable IBEAFFDLKBL(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x56B03A0", Offset = "0x56AF7A0", VA = "0x1856B03A0")]
	public static IDisposable OJMBPOGJMPA(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x56AFEC0", Offset = "0x56AF2C0", VA = "0x1856AFEC0")]
	public static IDisposable FPLKEFKFFHL(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x56B0310", Offset = "0x56AF710", VA = "0x1856B0310")]
	public static IDisposable MDDMKKIGCMB(this MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x56B0430", Offset = "0x56AF830", VA = "0x1856B0430")]
	public static IDisposable OMAABBAPGLF(this MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x56AFDB0", Offset = "0x56AF1B0", VA = "0x1856AFDB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public EDLCMBAFKBH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x56B0E40", Offset = "0x56B0240", VA = "0x1856B0E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x56B0F00", Offset = "0x56B0300", VA = "0x1856B0F00", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public DHNCMDHDEJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x56AF0A0", Offset = "0x56AE4A0", VA = "0x1856AF0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x56AF190", Offset = "0x56AE590", VA = "0x1856AF190", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x56BC5A0", Offset = "0x56BB9A0", VA = "0x1856BC5A0")]
	public static ALMNDBMKBBN CMNJABNFFNL(Action CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x56BC3D0", Offset = "0x56BB7D0", VA = "0x1856BC3D0")]
	public static ALMNDBMKBBN CMNJABNFFNL(Behaviour MFEOJPNCOBA, Action CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x56BC490", Offset = "0x56BB890", VA = "0x1856BC490")]
	public static ALMNDBMKBBN CMNJABNFFNL(Behaviour MFEOJPNCOBA, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x56BC650", Offset = "0x56BBA50", VA = "0x1856BC650")]
	[IteratorStateMachine(typeof(EDLCMBAFKBH))]
	private static IEnumerator<FEEMOJCDGJP> CPEMHMEKMCE(FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action CHENOCAGDJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x56BC6D0", Offset = "0x56BBAD0", VA = "0x1856BC6D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public EGAFCKHOOND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x56B1020", Offset = "0x56B0420", VA = "0x1856B1020", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x56B10C0", Offset = "0x56B04C0", VA = "0x1856B10C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x56BF820", Offset = "0x56BEC20", VA = "0x1856BF820")]
	public static ALMNDBMKBBN CMNJABNFFNL(float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x56BF920", Offset = "0x56BED20", VA = "0x1856BF920")]
	public static ALMNDBMKBBN CMNJABNFFNL(MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x56BFB40", Offset = "0x56BEF40", VA = "0x1856BFB40")]
	public static ALMNDBMKBBN JOHBDFNDMHL(MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x56BFCF0", Offset = "0x56BF0F0", VA = "0x1856BFCF0")]
	public static ALMNDBMKBBN LEMECCIBKNI(ADIFEAAPNPC MFEOJPNCOBA, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x56BFA30", Offset = "0x56BEE30", VA = "0x1856BFA30")]
	private static IEnumerator<FEEMOJCDGJP> CPEMHMEKMCE(JAOAOODOEOH GCDMKDMAPNJ, float FOOKFHONNOI, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x56BFAE0", Offset = "0x56BEEE0", VA = "0x1856BFAE0")]
	private static IEnumerator<FEEMOJCDGJP> JKEDNIALJMN(JAOAOODOEOH GCDMKDMAPNJ, float FOOKFHONNOI, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action<float> CHENOCAGDJL, bool MPEGNHBLLBF = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x56BFC60", Offset = "0x56BF060", VA = "0x1856BFC60")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public OACHBMMCLGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x56BF250", Offset = "0x56BE650", VA = "0x1856BF250", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x56BF300", Offset = "0x56BE700", VA = "0x1856BF300", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x56BCB20", Offset = "0x56BBF20", VA = "0x1856BCB20")]
	[IteratorStateMachine(typeof(OACHBMMCLGE))]
	private static IEnumerator<FEEMOJCDGJP> EIEKJNELLBO(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, Func<bool> MLBBCPJIFOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x56BCBA0", Offset = "0x56BBFA0", VA = "0x1856BCBA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public PHDJJCLHBCA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x56C1A90", Offset = "0x56C0E90", VA = "0x1856C1A90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x56C1B50", Offset = "0x56C0F50", VA = "0x1856C1B50", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public AKPOIDGHEKE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x56AAAC0", Offset = "0x56A9EC0", VA = "0x1856AAAC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x56AAB90", Offset = "0x56A9F90", VA = "0x1856AAB90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x56C07A0", Offset = "0x56BFBA0", VA = "0x1856C07A0")]
	[IteratorStateMachine(typeof(PHDJJCLHBCA))]
	private static IEnumerator<FEEMOJCDGJP> LBHDJPDENOC(float FCCAADEIJOC, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x56C02D0", Offset = "0x56BF6D0", VA = "0x1856C02D0")]
	[IteratorStateMachine(typeof(AKPOIDGHEKE))]
	private static IEnumerator<FEEMOJCDGJP> EFHPCGNOHLE(float FCCAADEIJOC, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x56C0580", Offset = "0x56BF980", VA = "0x1856C0580")]
	public static IDisposable GOEHLJBPOGP(this MonoBehaviour GKLOBNBPFOD, float FCCAADEIJOC, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x56C0360", Offset = "0x56BF760", VA = "0x1856C0360")]
	public static ALMNDBMKBBN GIKJCFKECNJ(this MonoBehaviour GKLOBNBPFOD, float FCCAADEIJOC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x56C0450", Offset = "0x56BF850", VA = "0x1856C0450")]
	public static ALMNDBMKBBN GOEHLJBPOGP(this MonoBehaviour GKLOBNBPFOD, float FCCAADEIJOC, FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x56C00E0", Offset = "0x56BF4E0", VA = "0x1856C00E0")]
	public static ALMNDBMKBBN COFJFOJAHKP(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x56C0830", Offset = "0x56BFC30", VA = "0x1856C0830")]
	public static ALMNDBMKBBN POPBNCLFNNL(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x56C0000", Offset = "0x56BF400", VA = "0x1856C0000")]
	public static ALMNDBMKBBN CNGLKIGMEHA(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x56C0420", Offset = "0x56BF820", VA = "0x1856C0420")]
	public static ALMNDBMKBBN GLNEMACPFLH(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x56C0770", Offset = "0x56BFB70", VA = "0x1856C0770")]
	public static ALMNDBMKBBN KPJFIAPJHAP(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x56C01D0", Offset = "0x56BF5D0", VA = "0x1856C01D0")]
	public static ALMNDBMKBBN DPLMGBEDKNG(this MonoBehaviour GKLOBNBPFOD, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x56BFE60", Offset = "0x56BF260", VA = "0x1856BFE60")]
	private static ALMNDBMKBBN BAPAIMFINGN(MonoBehaviour GKLOBNBPFOD, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, Action EGHDMBPEGFF, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x56C0200", Offset = "0x56BF600", VA = "0x1856C0200")]
	public static ALMNDBMKBBN EFGHNHLKPIJ(this MonoBehaviour GKLOBNBPFOD, float BGOCLIOFNII, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x56BFF30", Offset = "0x56BF330", VA = "0x1856BFF30")]
	public static ALMNDBMKBBN CJNNFDLJFEO(this MonoBehaviour GKLOBNBPFOD, float BGOCLIOFNII, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x56C06A0", Offset = "0x56BFAA0", VA = "0x1856C06A0")]
	public static ALMNDBMKBBN IOMBCJBIELM(this MonoBehaviour GKLOBNBPFOD, float BGOCLIOFNII, Action EGHDMBPEGFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x56C0100", Offset = "0x56BF500", VA = "0x1856C0100")]
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
		[Cpp2IlInjected.Address(RVA = "0x56B0760", Offset = "0x56AFB60", VA = "0x1856B0760", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action ACBCKAMKFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x56B0510", Offset = "0x56AF910", VA = "0x1856B0510", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x56B0D00", Offset = "0x56B0100", VA = "0x1856B0D00", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x56B0DA0", Offset = "0x56B01A0", VA = "0x1856B0DA0")]
	public EDBJFMEKDOE([Optional] Action LEDGIFFFLHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x56B05B0", Offset = "0x56AF9B0", VA = "0x1856B05B0")]
	public void GBJBCHALJOG(KBHCDJBOPJL BBGPBJMDIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x56B0B90", Offset = "0x56AFF90", VA = "0x1856B0B90")]
	private void MOGOMAMCBOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x56B08A0", Offset = "0x56AFCA0", VA = "0x1856B08A0", Slot = "7")]
	public bool LLJKEGONCBN(bool AKNNPOEHKML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x56B08B0", Offset = "0x56AFCB0", VA = "0x1856B08B0", Slot = "8")]
	public bool LLJKEGONCBN(Action FFBLFKDINEA, bool AKNNPOEHKML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x56B06E0", Offset = "0x56AFAE0", VA = "0x1856B06E0", Slot = "9")]
	public IEnumerator<KBHCDJBOPJL> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x56B06E0", Offset = "0x56AFAE0", VA = "0x1856B06E0", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public CCCABKKLBJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x56AB640", Offset = "0x56AAA40", VA = "0x1856AB640")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public DKFFIKIAKOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x56AB640", Offset = "0x56AAA40", VA = "0x1856AB640")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly float CJDHBKDNNCE;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x56B6AA0", Offset = "0x56B5EA0", VA = "0x1856B6AA0")]
	public GKHIBDBPEBK(Behaviour MFEOJPNCOBA, float CJDHBKDNNCE, [Optional] Action LEDGIFFFLHA, [Optional] AICFMGNKEOP IJGKMHNCIAI, [Optional] JAOAOODOEOH GCDMKDMAPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x56B68A0", Offset = "0x56B5CA0", VA = "0x1856B68A0", Slot = "9")]
	protected override bool CPKFMFOAEPP(Action FFBLFKDINEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x56B69A0", Offset = "0x56B5DA0", VA = "0x1856B69A0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public IPGGPDMLIIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x56B9B50", Offset = "0x56B8F50", VA = "0x1856B9B50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x56B9C20", Offset = "0x56B9020", VA = "0x1856B9C20", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x731650", Offset = "0x730A50", VA = "0x180731650", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action ACBCKAMKFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x56AABF0", Offset = "0x56A9FF0", VA = "0x1856AABF0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x56AB080", Offset = "0x56AA480", VA = "0x1856AB080", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x56AB120", Offset = "0x56AA520", VA = "0x1856AB120")]
	protected BHEHDMKHJBI(Behaviour MFEOJPNCOBA, [Optional] Action LEDGIFFFLHA, [Optional] AICFMGNKEOP IJGKMHNCIAI, [Optional] JAOAOODOEOH GCDMKDMAPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x56AAFE0", Offset = "0x56AA3E0", VA = "0x1856AAFE0", Slot = "7")]
	public bool LLJKEGONCBN(bool AKNNPOEHKML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x56AAF90", Offset = "0x56AA390", VA = "0x1856AAF90", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x56AABD0", Offset = "0x56A9FD0", VA = "0x1856AABD0")]
	protected void AIELLDGHKIF(Action FFBLFKDINEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x56AAC90", Offset = "0x56AA090", VA = "0x1856AAC90")]
	protected LLEFGLIPMKI ECABNPAFOFG(float LABHGKFLOGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x56AAE90", Offset = "0x56AA290", VA = "0x1856AAE90")]
	private void GJKEEGIKBNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x56AAF10", Offset = "0x56AA310", VA = "0x1856AAF10")]
	[IteratorStateMachine(typeof(IPGGPDMLIIL))]
	private IEnumerator<FEEMOJCDGJP> IGJKNKJLMPA(float LABHGKFLOGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x56AB040", Offset = "0x56AA440", VA = "0x1856AB040")]
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
	[Cpp2IlInjected.Address(RVA = "0x56B9880", Offset = "0x56B8C80", VA = "0x1856B9880")]
	public IFKJGOLDBHO(Behaviour MFEOJPNCOBA, float MONEAPEHKKH, int EIMKAJDOILD, [Optional] Action LEDGIFFFLHA, float ACMPCCELHHG = 0f, [Optional] AICFMGNKEOP IJGKMHNCIAI, [Optional] JAOAOODOEOH GCDMKDMAPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "9")]
	protected override bool CPKFMFOAEPP(Action FFBLFKDINEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x56B95C0", Offset = "0x56B89C0", VA = "0x1856B95C0", Slot = "10")]
	protected override bool LAGIOPJKIOB(Action FFBLFKDINEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x56B97F0", Offset = "0x56B8BF0", VA = "0x1856B97F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x56B6AA0", Offset = "0x56B5EA0", VA = "0x1856B6AA0")]
	public MOMKBILHJJA(Behaviour MFEOJPNCOBA, float CJDHBKDNNCE, [Optional] Action LEDGIFFFLHA, [Optional] AICFMGNKEOP IJGKMHNCIAI, [Optional] JAOAOODOEOH GCDMKDMAPNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "9")]
	protected override bool CPKFMFOAEPP(Action FFBLFKDINEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x56BEE90", Offset = "0x56BE290", VA = "0x1856BEE90", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public OBBJGBBBMDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x56BF520", Offset = "0x56BE920", VA = "0x1856BF520", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x56BF5C0", Offset = "0x56BE9C0", VA = "0x1856BF5C0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x56B2FE0", Offset = "0x56B23E0", VA = "0x1856B2FE0")]
	public FKCPFAGPDOK(ADIFEAAPNPC MFEOJPNCOBA, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x56B2E30", Offset = "0x56B2230", VA = "0x1856B2E30")]
	private void PNOAIAGGNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x56B2CD0", Offset = "0x56B20D0", VA = "0x1856B2CD0")]
	private void OENEBNFFMKP(string CNMFEBEOFOM, Action AHFEMKBPEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x56B2C60", Offset = "0x56B2060", VA = "0x1856B2C60")]
	[IteratorStateMachine(typeof(OBBJGBBBMDB))]
	private IEnumerator<FEEMOJCDGJP> MBBMPJEADMP(Action AHFEMKBPEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x56B2A50", Offset = "0x56B1E50", VA = "0x1856B2A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x56B2AB0", Offset = "0x56B1EB0", VA = "0x1856B2AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x6E4200", Offset = "0x6E3600", VA = "0x1806E4200")]
		[DebuggerHidden]
		public EFDKNAGPBEF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x56B0F40", Offset = "0x56B0340", VA = "0x1856B0F40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x56B0FE0", Offset = "0x56B03E0", VA = "0x1856B0FE0", Slot = "8")]
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
	[Cpp2IlInjected.Address(RVA = "0x56BEC90", Offset = "0x56BE090", VA = "0x1856BEC90")]
	public MLJCMBIBDPN(MonoBehaviour GKLOBNBPFOD, Action CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x56BEA50", Offset = "0x56BDE50", VA = "0x1856BEA50")]
	public MLJCMBIBDPN(MonoBehaviour GKLOBNBPFOD, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x56BE800", Offset = "0x56BDC00", VA = "0x1856BE800")]
	public MLJCMBIBDPN(MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x42DC450", Offset = "0x42DB850", VA = "0x1842DC450")]
	private MLJCMBIBDPN(AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x56BDA80", Offset = "0x56BCE80", VA = "0x1856BDA80")]
	internal static MLJCMBIBDPN ANECANOBCDK(MonoBehaviour GKLOBNBPFOD, float FOOKFHONNOI, Action<float> CHENOCAGDJL, FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM, bool MPEGNHBLLBF = true, [Optional] AICFMGNKEOP IJGKMHNCIAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x56BDD20", Offset = "0x56BD120", VA = "0x1856BDD20")]
	private void CMNJABNFFNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x56BE410", Offset = "0x56BD810", VA = "0x1856BE410")]
	private void ONHAGIOADNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x56BE650", Offset = "0x56BDA50", VA = "0x1856BE650")]
	private void PNOAIAGGNGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x56BDEF0", Offset = "0x56BD2F0", VA = "0x1856BDEF0")]
	private void FGBMGIHGMCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x56BE2E0", Offset = "0x56BD6E0", VA = "0x1856BE2E0")]
	private void OENEBNFFMKP(string CNMFEBEOFOM, Action AHFEMKBPEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x56BE150", Offset = "0x56BD550", VA = "0x1856BE150")]
	[IteratorStateMachine(typeof(EFDKNAGPBEF))]
	private IEnumerator<FEEMOJCDGJP> MBBMPJEADMP(Action AHFEMKBPEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x56BDE90", Offset = "0x56BD290", VA = "0x1856BDE90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x56BE0C0", Offset = "0x56BD4C0", VA = "0x1856BE0C0")]
	[CompilerGenerated]
	private void KPEIPDDGDPN(string CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x56BE250", Offset = "0x56BD650", VA = "0x1856BE250")]
	[CompilerGenerated]
	private void NDPCPMCHJKH(string CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x56BE5C0", Offset = "0x56BD9C0", VA = "0x1856BE5C0")]
	[CompilerGenerated]
	private void OPHDCEKJIFP(string CJDLKEIECEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x56BE1C0", Offset = "0x56BD5C0", VA = "0x1856BE1C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x56B8DE0", Offset = "0x56B81E0", VA = "0x1856B8DE0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public float APJLDCLNPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x56B8D60", Offset = "0x56B8160", VA = "0x1856B8D60", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public double AIHJKLDBDGB
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x56B8D40", Offset = "0x56B8140", VA = "0x1856B8D40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x56B8D70", Offset = "0x56B8170", VA = "0x1856B8D70")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void KFLICAKIADO(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x700F30", Offset = "0x700330", VA = "0x180700F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x56BCCB0", Offset = "0x56BC0B0", VA = "0x1856BCCB0")]
	public static FEEMOJCDGJP AMLGIIENCIE(IEnumerator<FEEMOJCDGJP> DFCONPKBPHE, DDELICCCDIK LHCEHKBEGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x56BCE60", Offset = "0x56BC260", VA = "0x1856BCE60")]
	public FEEMOJCDGJP AMLGIIENCIE(DDELICCCDIK[] DBKOPDANJGN, IEnumerator<FEEMOJCDGJP>[] PCJMBONPKDC, FEEMOJCDGJP[] OEOIIILFJJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x56BCF40", Offset = "0x56BC340", VA = "0x1856BCF40")]
	public void EOJHBCLCBNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x56BD0B0", Offset = "0x56BC4B0", VA = "0x1856BD0B0")]
	public void KLGGPOBMEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x56BCF70", Offset = "0x56BC370", VA = "0x1856BCF70")]
	public void FJIGKMOIOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x56BCF40", Offset = "0x56BC340", VA = "0x1856BCF40")]
	public void DAMKNHMBEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public GDNLHKPPCLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x56B5CC0", Offset = "0x56B50C0", VA = "0x1856B5CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public OBKJFBPKOMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x56BF600", Offset = "0x56BEA00", VA = "0x1856BF600")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EBOLKMJMLAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x56B04D0", Offset = "0x56AF8D0", VA = "0x1856B04D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
		public EPBAAJANLLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x56B14A0", Offset = "0x56B08A0", VA = "0x1856B14A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x10E0820", Offset = "0x10DFC20", VA = "0x1810E0820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x56B33B0", Offset = "0x56B27B0", VA = "0x1856B33B0")]
	private static int AJGJHBDECKP(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x56B54E0", Offset = "0x56B48E0", VA = "0x1856B54E0")]
	public FNKHGEGIKDO(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x56B31C0", Offset = "0x56B25C0", VA = "0x1856B31C0")]
	private void AEMFIHOLJOD(ref int PFDMFFDIHPJ, int DHPEOIEBOID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x56B4F80", Offset = "0x56B4380", VA = "0x1856B4F80")]
	public void LCMIJEIOMGK(ADIFEAAPNPC MFEOJPNCOBA, FEEMOJCDGJP EIKEGOMHMAF, IEnumerator<FEEMOJCDGJP> DFCONPKBPHE, DDELICCCDIK LHCEHKBEGOH, [Optional] LPHPICONGPB KDNELECCAJA, JADEDNNEEGN LEJGLEKCADN = JADEDNNEEGN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x56B3B10", Offset = "0x56B2F10", VA = "0x1856B3B10")]
	public void AJKNHJEFJIF(IEnumerable<GLKJIGLCOGN> AKJLLPOBNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x56B44A0", Offset = "0x56B38A0", VA = "0x1856B44A0")]
	private GLKJIGLCOGN IKHPBFLCGEA(int NAIHMNOEADG)
	{
		return default(GLKJIGLCOGN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x56B49B0", Offset = "0x56B3DB0", VA = "0x1856B49B0")]
	private void JCJICFGGAKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x23891A0", Offset = "0x23885A0", VA = "0x1823891A0")]
	private static void CAKDOENPPBL<T>(int NAIHMNOEADG, T[] MGNKPLJLGNB, int MKMGHJFMNMB, [Optional] T JDMBMLBMPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x2389180", Offset = "0x2388580", VA = "0x182389180")]
	private static void CAKDOENPPBL<T>(int NAIHMNOEADG, NativeArray<T> MGNKPLJLGNB, int MKMGHJFMNMB, [Optional] T JDMBMLBMPAL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x56B5100", Offset = "0x56B4500", VA = "0x1856B5100")]
	private void NJCJLFOBDNM(IEnumerable<GLKJIGLCOGN> AKJLLPOBNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x56B41F0", Offset = "0x56B35F0", VA = "0x1856B41F0")]
	private void HLAKBBMMPDP(GLKJIGLCOGN JCPDBIPDDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x56B3F30", Offset = "0x56B3330", VA = "0x1856B3F30")]
	private HMMECMONAPF EEPGEBPADOB(int HFHPPDEEGDF)
	{
		return default(HMMECMONAPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x56B42C0", Offset = "0x56B36C0", VA = "0x1856B42C0")]
	public void IHAMIGPHEFD(float GIGIGOCEOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x56B3E30", Offset = "0x56B3230", VA = "0x1856B3E30")]
	private void DCBOEAGHFJD(Action BECDKHGLGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x56B3EB0", Offset = "0x56B32B0", VA = "0x1856B3EB0")]
	private void EALKAIIOEAA(Action BECDKHGLGNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x56B33E0", Offset = "0x56B27E0", VA = "0x1856B33E0")]
	public void AJHEANEMIJJ(float GIGIGOCEOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x56B4E80", Offset = "0x56B4280", VA = "0x1856B4E80")]
	public void KKNPGIAABIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x56B3D00", Offset = "0x56B3100", VA = "0x1856B3D00")]
	public void DAMKNHMBEAM(LPHPICONGPB BOKAHCFBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x56B4D50", Offset = "0x56B4150", VA = "0x1856B4D50")]
	public void JIGPOMNNKDI(LPHPICONGPB BOKAHCFBBLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x56B53B0", Offset = "0x56B47B0", VA = "0x1856B53B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
	public CCAFLGPMEIK(Action PECNBFJIPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x56AB520", Offset = "0x56AA920", VA = "0x1856AB520", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x14CA560", Offset = "0x14C9960", VA = "0x1814CA560")]
		public CBDOFFDNNOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x23F0CD0", Offset = "0x23F00D0", VA = "0x1823F0CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6FA8D0", Offset = "0x6F9CD0", VA = "0x1806FA8D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x2FF2C10", Offset = "0x2FF2010", VA = "0x182FF2C10", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x2FF3640", Offset = "0x2FF2A40", VA = "0x182FF3640")]
	private static bool PCJLNJJODLM(T BECDKHGLGNB, T ICPOAGANOLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x2FF36A0", Offset = "0x2FF2AA0", VA = "0x182FF36A0")]
	public DGHLNMJLKBF(T FLKCFPCNOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x2FF34A0", Offset = "0x2FF28A0", VA = "0x182FF34A0", Slot = "6")]
	public IDisposable MMGFILENFNB(UnityEngine.Object MFEOJPNCOBA, Action<T> FABMJAKDJBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2FD0", Offset = "0x2FF23D0", VA = "0x182FF2FD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x56B6ED0", Offset = "0x56B62D0", VA = "0x1856B6ED0")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void KFLICAKIADO(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
	[Preserve]
	internal HAKOLFLOFJL([KCHLPHCLLFB(null)] AICFMGNKEOP IJGKMHNCIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x56B6E30", Offset = "0x56B6230", VA = "0x1856B6E30", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x56BB0A0", Offset = "0x56BA4A0", VA = "0x1856BB0A0")]
	public static KEELEOHAFAO BMDGCEOIEEG(int LGMJBPFILHN, float GIGIGOCEOOM, NativeArray<JADEDNNEEGN> PLGELLNPOIO, NativeArray<float> LBHDNOKBOCO, NativeArray<int> DGEBKGKHHNC, NativeArray<int> HKPMCPEAFKI, NativeArray<int> AJCJMPEDKGE, NativeArray<int> BIBBNDLDMHP, NativeArray<int> IFHCFFHBMIM)
	{
		return default(KEELEOHAFAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x56BB100", Offset = "0x56BA500", VA = "0x1856BB100", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x56BB4A0", Offset = "0x56BA8A0", VA = "0x1856BB4A0")]
	private bool LNBJMHACDIO(int EGBCAPEEJBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x56BB470", Offset = "0x56BA870", VA = "0x1856BB470")]
	private void KNNGDNFHHFC(NativeArray<int> CGKFGHEEOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x56BB1E0", Offset = "0x56BA5E0", VA = "0x1856BB1E0")]
	private int FEAEKPMPNOA(int JFOFFBJLNON, int CEGDEMKCCLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x56BB4E0", Offset = "0x56BA8E0", VA = "0x1856BB4E0")]
	private void NGAACNFCNOH(NativeArray<int> CGKFGHEEOGG, int FKKIIOKEOFL, int ANOKHAKIKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x56BB240", Offset = "0x56BA640", VA = "0x1856BB240")]
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
	[Cpp2IlInjected.Address(RVA = "0x56C1050", Offset = "0x56C0450", VA = "0x1856C1050")]
	[JDLBAGCFHIO(MEDANDNEHIF.None)]
	private static void KFLICAKIADO(DDFGGHLLPGI MBIOGPPGEOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x56C12B0", Offset = "0x56C06B0", VA = "0x1856C12B0")]
	[Preserve]
	public PAIMOIHBPMD([KCHLPHCLLFB(null)] JCBLIDPOHJF OEPOKHPMPLF, [KCHLPHCLLFB(null)] JAOAOODOEOH GCDMKDMAPNJ, [KCHLPHCLLFB(null)] AINCEMGEEDM NOJAJGKADCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x56C1170", Offset = "0x56C0570", VA = "0x1856C1170", Slot = "12")]
	public override ALMNDBMKBBN PGCHPKMGCOO(ADIFEAAPNPC MFEOJPNCOBA, IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x56C0B90", Offset = "0x56BFF90", VA = "0x1856C0B90", Slot = "13")]
	public override void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x56C0E70", Offset = "0x56C0270", VA = "0x1856C0E70", Slot = "15")]
	public override void JBCGNJHFECP(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x56C0AB0", Offset = "0x56BFEB0", VA = "0x1856C0AB0", Slot = "14")]
	protected override void HMNCABBCMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x56C0A70", Offset = "0x56BFE70", VA = "0x1856C0A70")]
	private FNKHGEGIKDO HFCIIEODLEI(FEILFOOICNG.KEGPNCJFLFJ HAOFNDAEGFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x56C10C0", Offset = "0x56C04C0", VA = "0x1856C10C0", Slot = "16")]
	internal override PENLMKCOHMB NIHCPMEDDED(IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ, Behaviour MFEOJPNCOBA, DDELICCCDIK LHCEHKBEGOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x56C0860", Offset = "0x56BFC60", VA = "0x1856C0860", Slot = "17")]
	internal override HOMGBNCPHJC ANEHHKANACK(FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x56C08D0", Offset = "0x56BFCD0", VA = "0x1856C08D0")]
	private void ANFFNCBBGEG(FNKHGEGIKDO NLLENCMNHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x56C0A00", Offset = "0x56BFE00", VA = "0x1856C0A00", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x56BAC60", Offset = "0x56BA060", VA = "0x1856BAC60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static bool LCLDHDEMAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public FEILFOOICNG.KEGPNCJFLFJ MJFAKMBBGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6E0040", Offset = "0x6DF440", VA = "0x1806E0040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(FEILFOOICNG.KEGPNCJFLFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x700F30", Offset = "0x700330", VA = "0x180700F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public JAOAOODOEOH HONBHIFJHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E1120", Offset = "0x6E0520", VA = "0x1806E1120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x56BA290", Offset = "0x56B9690", VA = "0x1856BA290")]
	public static ALMNDBMKBBN FAABJPIHHKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x56BACF0", Offset = "0x56BA0F0", VA = "0x1856BACF0")]
	[Preserve]
	protected JHKJKEKEDBJ([KCHLPHCLLFB(null)] JCBLIDPOHJF OEPOKHPMPLF, [KCHLPHCLLFB(null)] JAOAOODOEOH GCDMKDMAPNJ, [KCHLPHCLLFB(null)] AINCEMGEEDM NOJAJGKADCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x56BAA20", Offset = "0x56B9E20", VA = "0x1856BAA20", Slot = "6")]
	public ALMNDBMKBBN LDGDMJHFFKN(IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x56BAA30", Offset = "0x56B9E30", VA = "0x1856BAA30", Slot = "7")]
	public ALMNDBMKBBN LDGDMJHFFKN(Behaviour MFEOJPNCOBA, IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract ALMNDBMKBBN PGCHPKMGCOO(ADIFEAAPNPC MFEOJPNCOBA, IEnumerator<FEEMOJCDGJP> CLKCONDBDNJ);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x56BA560", Offset = "0x56B9960", VA = "0x1856BA560", Slot = "13")]
	public virtual void IKINEIFADPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x56BA9A0", Offset = "0x56B9DA0", VA = "0x1856BA9A0", Slot = "9")]
	public void JFEJCMBFABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x56BA540", Offset = "0x56B9940", VA = "0x1856BA540", Slot = "14")]
	protected virtual void HMNCABBCMFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x56BA330", Offset = "0x56B9730", VA = "0x1856BA330")]
	private void FMBIKGIEHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x56BA740", Offset = "0x56B9B40", VA = "0x1856BA740")]
	private void INOEJILCGHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x56BA270", Offset = "0x56B9670", VA = "0x1856BA270")]
	private void EJBOICBIHAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x56BAA00", Offset = "0x56B9E00", VA = "0x1856BAA00")]
	private void KEICLDDDMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x56BACD0", Offset = "0x56BA0D0", VA = "0x1856BACD0")]
	private void MOJBGLABFIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x56BACB0", Offset = "0x56BA0B0", VA = "0x1856BACB0")]
	private void MLEAECJPDAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x56BA350", Offset = "0x56B9750", VA = "0x1856BA350")]
	private void FNLJFFNKACF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x56BA760", Offset = "0x56B9B60", VA = "0x1856BA760", Slot = "15")]
	public virtual void JBCGNJHFECP(FEILFOOICNG.KEGPNCJFLFJ NFIPLCLBABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x56BA370", Offset = "0x56B9770", VA = "0x1856BA370")]
	private void GGLPHLMBPFE(HOMGBNCPHJC NLLENCMNHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0xBA3610", Offset = "0xBA2A10", VA = "0x180BA3610")]
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
	[Cpp2IlInjected.Address(RVA = "0x56B9EF0", Offset = "0x56B92F0", VA = "0x1856B9EF0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E1AC0", Offset = "0x6E0EC0", VA = "0x1806E1AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x700130", Offset = "0x6FF530", VA = "0x180700130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public FEEMOJCDGJP CAFAPJAOHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x700140", Offset = "0x6FF540", VA = "0x180700140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool PJLBBMNHAHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x56C1640", Offset = "0x56C0A40", VA = "0x1856C1640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool CHBCKGCFLHG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0xA62D60", Offset = "0xA62160", VA = "0x180A62D60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x24088F0", Offset = "0x2407CF0", VA = "0x1824088F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public string DBDKMHBCKAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x6E7570", Offset = "0x6E6970", VA = "0x1806E7570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x6E7590", Offset = "0x6E6990", VA = "0x1806E7590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public float GIGLFAAHIEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x112D660", Offset = "0x112CA60", VA = "0x18112D660")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x112D650", Offset = "0x112CA50", VA = "0x18112D650")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x56C1870", Offset = "0x56C0C70", VA = "0x1856C1870")]
	public PENLMKCOHMB(IEnumerator<FEEMOJCDGJP> DFCONPKBPHE, POHJDCGNHFF MFEOJPNCOBA, DDELICCCDIK LHCEHKBEGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x56C1380", Offset = "0x56C0780", VA = "0x1856C1380")]
	public FEEMOJCDGJP AMLGIIENCIE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x56C1740", Offset = "0x56C0B40", VA = "0x1856C1740")]
	public bool LEPNINLOPJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x56C16C0", Offset = "0x56C0AC0", VA = "0x1856C16C0")]
	public void DAMKNHMBEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x56C17B0", Offset = "0x56C0BB0", VA = "0x1856C17B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x14D6A50", Offset = "0x14D5E50", VA = "0x1814D6A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x784530", Offset = "0x783930", VA = "0x180784530", Slot = "23")]
		get
		{
			return default(FEILFOOICNG.KEGPNCJFLFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public FEILFOOICNG.KEGPNCJFLFJ APCNPIOJPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA491B0", Offset = "0xA485B0", VA = "0x180A491B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private float MFEEAIKOFAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1222300", Offset = "0x1221700", VA = "0x181222300", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public bool NIIDNGHHBHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6E3D00", Offset = "0x6E3100", VA = "0x1806E3D00", Slot = "26")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x56AF020", Offset = "0x56AE420", VA = "0x1856AF020", Slot = "24")]
	private bool PMAAAEKNGKD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x56AF010", Offset = "0x56AE410", VA = "0x1856AF010", Slot = "27")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x56AF040", Offset = "0x56AE440", VA = "0x1856AF040")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E00D0", Offset = "0x6DF4D0", VA = "0x1806E00D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x56B8870", Offset = "0x56B7C70", VA = "0x1856B8870")]
	public HOMGBNCPHJC(FEILFOOICNG.KEGPNCJFLFJ FBAFAIACKJJ, JJKHFFLGAFJ ACLHDGGPIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x56B7610", Offset = "0x56B6A10", VA = "0x1856B7610")]
	public void EKKOPHAELNL(PENLMKCOHMB DFCONPKBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x56B8390", Offset = "0x56B7790", VA = "0x1856B8390")]
	public void JJLHKLCKCMO(IList<PENLMKCOHMB> PCJMBONPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x56B7730", Offset = "0x56B6B30", VA = "0x1856B7730")]
	public void FLCJBALPADD(IList<PENLMKCOHMB> PCJMBONPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x56B8660", Offset = "0x56B7A60", VA = "0x1856B8660")]
	private void OEDJADBCKMJ(PENLMKCOHMB DFCONPKBPHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x56B7CE0", Offset = "0x56B70E0", VA = "0x1856B7CE0")]
	private void HNEJEJCBGBB(IList<PENLMKCOHMB> PCJMBONPKDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x56B7A00", Offset = "0x56B6E00", VA = "0x1856B7A00")]
	private HMMECMONAPF GLILPCBCBDA(PENLMKCOHMB DFCONPKBPHE)
	{
		return default(HMMECMONAPF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x56B7BA0", Offset = "0x56B6FA0", VA = "0x1856B7BA0")]
	public void HMNCABBCMFO(float GIGIGOCEOOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x56B8180", Offset = "0x56B7580", VA = "0x1856B8180")]
	public void JFEJCMBFABG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x56B7E60", Offset = "0x56B7260", VA = "0x1856B7E60")]
	private void IBFKIIPJCLM(List<PENLMKCOHMB> PCJMBONPKDC, Stack<int> CGPABOMCFBL, bool GMLFIMIHBCD, float NDLLDDCLBCC = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x56B73B0", Offset = "0x56B67B0", VA = "0x1856B73B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x56B74F0", Offset = "0x56B68F0", VA = "0x1856B74F0")]
	private void EDIEAIGICNM(List<PENLMKCOHMB> PCJMBONPKDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
internal class DFLEBBHAALO : JJKHFFLGAFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "4")]
	public void KLGJENPDLEM(string GOENAEMJAON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x6F9EB0", Offset = "0x6F92B0", VA = "0x1806F9EB0", Slot = "5")]
	public void IPJKCDIIPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x56B6790", Offset = "0x56B5B90", VA = "0x1856B6790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public bool APJNBIELNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x56B6820", Offset = "0x56B5C20", VA = "0x1856B6820", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool KGFFDKBPMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x56B6880", Offset = "0x56B5C80", VA = "0x1856B6880", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6E0F40", Offset = "0x6E0340", VA = "0x1806E0F40")]
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
