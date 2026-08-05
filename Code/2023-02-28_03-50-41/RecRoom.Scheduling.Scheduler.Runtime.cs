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
public class CDKKMCIAJAD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority PEDPACJHMBB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x55C7F50", Offset = "0x55C6950", VA = "0x1855C7F50")]
	public CDKKMCIAJAD(ThreadPriority BOAELONBAGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x55C7F40", Offset = "0x55C6940", VA = "0x1855C7F40", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> NAMGIJBPMPB(List<PlayerLoopSystem> DBKMNLNGAJC, int IIAGCBLANFL);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct ECBALELCEMC
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OJCHKOBDPMH
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static JCAAIAKPOCC GOENKPIMAJC;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x55DB930", Offset = "0x55DA330", VA = "0x1855DB930")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct BJFMOAEALEA
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static JCAAIAKPOCC LAIGKHANEBD;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x55C6C90", Offset = "0x55C5690", VA = "0x1855C6C90")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct MNLAFGCLIID
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static JCAAIAKPOCC LEKAPCLKDCC;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x55D9F70", Offset = "0x55D8970", VA = "0x1855D9F70")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct EOCOIBLOGAC
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static JCAAIAKPOCC JIBDEHPOGNH;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static JCAAIAKPOCC IHNNMAENKIH;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static JCAAIAKPOCC EMLGCDKEOLK;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static JCAAIAKPOCC ODGPIDBELEE;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x55D2E20", Offset = "0x55D1820", VA = "0x1855D2E20")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct OCPEJBPLPNC
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static JCAAIAKPOCC NOPMOAHJCEO;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x55DB5B0", Offset = "0x55D9FB0", VA = "0x1855DB5B0")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct BDIFOBOLFHM
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static JCAAIAKPOCC JIBDEHPOGNH;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static JCAAIAKPOCC IHNNMAENKIH;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static JCAAIAKPOCC EMLGCDKEOLK;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static JCAAIAKPOCC ODGPIDBELEE;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x55C6720", Offset = "0x55C5120", VA = "0x1855C6720")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct HHNIMIDBOEL
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static JCAAIAKPOCC FHHFIAOBLMC;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x55D5220", Offset = "0x55D3C20", VA = "0x1855D5220")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct OLCPLIBHBHM
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static JCAAIAKPOCC HCDNLPJPCEI;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x55DBB10", Offset = "0x55DA510", VA = "0x1855DBB10")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct BHIAEFBADJP
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static JCAAIAKPOCC NNOHACHCNFC;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x55C69B0", Offset = "0x55C53B0", VA = "0x1855C69B0")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct FFBJCPCMGLG
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static JCAAIAKPOCC BPBJDDBHIHI;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x55D3A40", Offset = "0x55D2440", VA = "0x1855D3A40")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct NCHIIFFCFCA
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static JCAAIAKPOCC FJHMECDLHHB;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x55DA720", Offset = "0x55D9120", VA = "0x1855DA720")]
				public static PlayerLoopSystem IGOGJJJBMEH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct CBMBEKPCAPD
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class LKFFEIAMLNH
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public BNGNBFCLLID.OPCOCDPJBOF key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
					public LKFFEIAMLNH()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x55D94E0", Offset = "0x55D7EE0", VA = "0x1855D94E0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable KGKBGCONKGO;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x55C7E10", Offset = "0x55C6810", VA = "0x1855C7E10")]
				public static PlayerLoopSystem INMPDFHGMAM(BNGNBFCLLID.OPCOCDPJBOF AJPNMLHDHNM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct JKFALAHFFIE
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class CNPDCOBCJAP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public BNGNBFCLLID.OPCOCDPJBOF key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
					public CNPDCOBCJAP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x55C80B0", Offset = "0x55C6AB0", VA = "0x1855C80B0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x55D5CE0", Offset = "0x55D46E0", VA = "0x1855D5CE0")]
				public static PlayerLoopSystem INMPDFHGMAM(BNGNBFCLLID.OPCOCDPJBOF AJPNMLHDHNM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class CJMACKBBHBG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
			public CJMACKBBHBG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x55C7F90", Offset = "0x55C6990", VA = "0x1855C7F90")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool DPMEJDIJMEE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool BMOAOELIFKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x55CB730", Offset = "0x55CA130", VA = "0x1855CB730")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x55C8570", Offset = "0x55C6F70", VA = "0x1855C8570")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x55C8AD0", Offset = "0x55C74D0", VA = "0x1855C8AD0")]
		private static void JOFGAAEAOHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x55CAE60", Offset = "0x55C9860", VA = "0x1855CAE60")]
		private static void NIIMIPIIELA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x55CAB30", Offset = "0x55C9530", VA = "0x1855CAB30")]
		private static void MAFBACDGHON(string CEODEHPBABN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x55C8340", Offset = "0x55C6D40", VA = "0x1855C8340")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x55CA970", Offset = "0x55C9370", VA = "0x1855CA970")]
		private static void LCALMGOFONP(BNGNBFCLLID.OPCOCDPJBOF AJPNMLHDHNM, ref PlayerLoopSystem BPAMGJDEHGP, Type NKGJGKEBEOF, Type JFKIAEAEMOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x55C86E0", Offset = "0x55C70E0", VA = "0x1855C86E0")]
		private static void GFNFEJPAHCP(ref PlayerLoopSystem BPAMGJDEHGP, Type NKGJGKEBEOF, Type JFKIAEAEMOP, NAMGIJBPMPB KDPHPEPIOKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x55C85B0", Offset = "0x55C6FB0", VA = "0x1855C85B0")]
		private static void EGDHGOLHIKD(ref PlayerLoopSystem BPAMGJDEHGP, Type NKGJGKEBEOF, Type JFKIAEAEMOP, PlayerLoopSystem? KNNMMJLAAAA, PlayerLoopSystem? MAMCCEABAIH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class BNGNBFCLLID
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum OPCOCDPJBOF
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
	public class HKANDAALJMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly OPCOCDPJBOF BKIPOGEEJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly FLBIACPAIHG GKODOCCLPJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long MMNLBEPFGGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long KGEMOGANDNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long OLKODLAKFKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int LDKOBMDMGPL;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x55D56D0", Offset = "0x55D40D0", VA = "0x1855D56D0")]
		public HKANDAALJMG(OPCOCDPJBOF CGDOJHHIBLD, int DHDLIAJPAGK = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x55D5460", Offset = "0x55D3E60", VA = "0x1855D5460")]
		public void GDGNOLIICMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x55D5400", Offset = "0x55D3E00", VA = "0x1855D5400")]
		public void DHONLJPALDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x55D54D0", Offset = "0x55D3ED0", VA = "0x1855D54D0")]
		public void MCKHDICKBBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static OPCOCDPJBOF[] NCJIEDNDPHO;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static HKANDAALJMG[] LPDBFFMDFOM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x55C7220", Offset = "0x55C5C20", VA = "0x1855C7220")]
	public static HKANDAALJMG JIPMBCOMFMD(OPCOCDPJBOF AJPNMLHDHNM, int DHDLIAJPAGK = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x55C73F0", Offset = "0x55C5DF0", VA = "0x1855C73F0")]
	public static HKANDAALJMG NHMOPCBAAAO(OPCOCDPJBOF AJPNMLHDHNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x55C7480", Offset = "0x55C5E80", VA = "0x1855C7480")]
	public static void OKPEJJABMNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class FLBIACPAIHG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int DOLIDCDPCOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> HOGDMDMNJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double MMCAICBMAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double OPOPHNBOOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double GADLJBPPLKB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double OFHOGINIIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x55D3ED0", Offset = "0x55D28D0", VA = "0x1855D3ED0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x55D3FA0", Offset = "0x55D29A0", VA = "0x1855D3FA0")]
	public FLBIACPAIHG(int GFKNPNNCNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x55D3DA0", Offset = "0x55D27A0", VA = "0x1855D3DA0", Slot = "4")]
	public void BLNGBMCILJP(double NJHLDPLGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55D3F30", Offset = "0x55D2930", VA = "0x1855D3F30", Slot = "5")]
	public void KNCDGFAKBDH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OINJNAJECMN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long JOBJIONNEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double NIDKNGEDLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double DBCADLIALCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double MPAPBNHHFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double ONCFFBPLNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double MMCAICBMAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double OPOPHNBOOKJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long HPEOPAJJAFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double GHHEHNKJJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x375ED00", Offset = "0x375D700", VA = "0x18375ED00", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double JBCFPMBGPEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA31E70", Offset = "0xA30870", VA = "0x180A31E70", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double FHEPEIFJBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x33C10D0", Offset = "0x33BFAD0", VA = "0x1833C10D0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double OFHOGINIIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x375EC30", Offset = "0x375D630", VA = "0x18375EC30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x55DB790", Offset = "0x55DA190", VA = "0x1855DB790", Slot = "7")]
	public void BLNGBMCILJP(double NJHLDPLGBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x55DB8C0", Offset = "0x55DA2C0", VA = "0x1855DB8C0", Slot = "8")]
	public void KNCDGFAKBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x55DB900", Offset = "0x55DA300", VA = "0x1855DB900")]
	public OINJNAJECMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DNPOEOFBBOI
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private interface FMHFBFGCMJC
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool FACNMOELOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void MILDGAMNMFE();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private abstract class JCCFINKPDJE<TPromise, TMainThreadPromise> : FMHFBFGCMJC where TPromise : GPMDAFELAJF where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly TPromise ONGOBPMOEPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected readonly TMainThreadPromise CENGKFLMINL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise GJBKNGOFMBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x30B1670", Offset = "0x30B0070", VA = "0x1830B1670")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FACNMOELOBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x30B1620", Offset = "0x30B0020", VA = "0x1830B1620", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2764360", Offset = "0x2762D60", VA = "0x182764360")]
		protected JCCFINKPDJE(TPromise ONGOBPMOEPA, TMainThreadPromise BEJEBNGGPPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x30B16D0", Offset = "0x30B00D0", VA = "0x1830B16D0", Slot = "5")]
		public void MILDGAMNMFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void DLCNDJAIBHK(TPromise ONGOBPMOEPA);
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private class HJFAMHANHNA<T> : JCCFINKPDJE<global::OHPLDOPGNGG<T>, global::MECOGDILELM<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3BA5650", Offset = "0x3BA4050", VA = "0x183BA5650")]
		public HJFAMHANHNA(global::OHPLDOPGNGG<T> ONGOBPMOEPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3BA54C0", Offset = "0x3BA3EC0", VA = "0x183BA54C0", Slot = "6")]
		protected override void DLCNDJAIBHK(global::OHPLDOPGNGG<T> ONGOBPMOEPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3BA5620", Offset = "0x3BA4020", VA = "0x183BA5620")]
		[CompilerGenerated]
		private void LEAIGCLFJEB(T OAFMFLFMLNI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x17A7EB0", Offset = "0x17A68B0", VA = "0x1817A7EB0")]
		[CompilerGenerated]
		private void LCAEAIJNBHP(string IMHLNJJFNDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class JKDGCEDDMPK : FMHFBFGCMJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly Action CKAPOBIDCEI;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FACNMOELOBG
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
		public JKDGCEDDMPK(Action CKAPOBIDCEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x101B410", Offset = "0x1019E10", VA = "0x18101B410", Slot = "5")]
		public void MILDGAMNMFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<FMHFBFGCMJC> CHBCENAIDOO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x22E36F0", Offset = "0x22E20F0", VA = "0x1822E36F0")]
	public static global::OHPLDOPGNGG<T> FIHMNHEIGKF<T>(this global::OHPLDOPGNGG<T> ONGOBPMOEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x55CD520", Offset = "0x55CBF20", VA = "0x1855CD520")]
	public static void FIHMNHEIGKF(Action CKAPOBIDCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x22E3760", Offset = "0x22E2160", VA = "0x1822E3760")]
	private static global::OHPLDOPGNGG<T> HGEMOMNLFJO<T>(global::OHPLDOPGNGG<T> ONGOBPMOEPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x55CD5B0", Offset = "0x55CBFB0", VA = "0x1855CD5B0")]
	private static void JOIACNHNJIJ(FMHFBFGCMJC MDDBFKGKOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x55CD130", Offset = "0x55CBB30", VA = "0x1855CD130")]
	private static void BLMIADJGIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x55CD420", Offset = "0x55CBE20", VA = "0x1855CD420")]
	private static void CGEGNBFNINL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x55CD060", Offset = "0x55CBA60", VA = "0x1855CD060")]
	private static void ACNJBCODAJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class LHOFGBMNJJO
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct INFHLKPKDJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TaskCompletionSource<Scene> JAFNAEGNCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly string DHEPJJLJLLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly LoadSceneMode NLLGNHIGHCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool BOHHGFEMLNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly PPKCEHBLCJE IFNGEGAGDGH;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x55D59B0", Offset = "0x55D43B0", VA = "0x1855D59B0")]
		public INFHLKPKDJG(TaskCompletionSource<Scene> AJHPOFPBMEJ, string DHEPJJLJLLD, LoadSceneMode NLLGNHIGHCO, bool BOHHGFEMLNH, PPKCEHBLCJE IFNGEGAGDGH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct GLMHANMNBOI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public PPKCEHBLCJE stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::CLGKLANEGOH<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x55D49A0", Offset = "0x55D33A0", VA = "0x1855D49A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x55D5010", Offset = "0x55D3A10", VA = "0x1855D5010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct BMBKPAPLPAE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x55C6E70", Offset = "0x55C5870", VA = "0x1855C6E70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct KHCMACMNHAD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private INFHLKPKDJG <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x55D68D0", Offset = "0x55D52D0", VA = "0x1855D68D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class PMCDKOJLPBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public global::MECOGDILELM<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public PMCDKOJLPBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x55DBE80", Offset = "0x55DA880", VA = "0x1855DBE80")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct KLAIEPIGDAK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private PMCDKOJLPBL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private PPKCEHBLCJE <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private PPKCEHBLCJE <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x55D6CA0", Offset = "0x55D56A0", VA = "0x1855D6CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x55D7620", Offset = "0x55D6020", VA = "0x1855D7620", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct DNAKKEICLNK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PPKCEHBLCJE stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private PPKCEHBLCJE <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private PPKCEHBLCJE <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x55CC7D0", Offset = "0x55CB1D0", VA = "0x1855CC7D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x55CD010", Offset = "0x55CBA10", VA = "0x1855CD010", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class FKIGIGPFLCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FKIGIGPFLCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x55D3D70", Offset = "0x55D2770", VA = "0x1855D3D70")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class EKNNKMJOCNN : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public AMHJHFKKEOP onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public EKNNKMJOCNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x55D14B0", Offset = "0x55CFEB0", VA = "0x1855D14B0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x55D1150", Offset = "0x55CFB50", VA = "0x1855D1150", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x55D1540", Offset = "0x55CFF40", VA = "0x1855D1540")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x55D1470", Offset = "0x55CFE70", VA = "0x1855D1470", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class JCAGKKBGCIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::MECOGDILELM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public JCAGKKBGCIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class EILONENNLAD : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public global::MECOGDILELM<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private JCAGKKBGCIO <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public EILONENNLAD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x55D0CC0", Offset = "0x55CF6C0", VA = "0x1855D0CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x55D1110", Offset = "0x55CFB10", VA = "0x1855D1110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static GPMDAFELAJF MNJIBGGMCEO;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation OHPOAMEBPOA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static GPMDAFELAJF FLHNNOBIJJO;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string EDJNFKIGFAN;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority BOOACCOMFAH;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task GIBNPGBEHNH;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Queue<INFHLKPKDJG> OEAEPPKHIPP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Task PJIBBDGLBKM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool FOOHGKBJPLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x55D8DF0", Offset = "0x55D77F0", VA = "0x1855D8DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool NCCHPFPOEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x55D9210", Offset = "0x55D7C10", VA = "0x1855D9210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool LPLCHCJNKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x55D82B0", Offset = "0x55D6CB0", VA = "0x1855D82B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> FHOKMOONGBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x55D8710", Offset = "0x55D7110", VA = "0x1855D8710")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x55D8540", Offset = "0x55D6F40", VA = "0x1855D8540")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x55D8640", Offset = "0x55D7040", VA = "0x1855D8640")]
	[KCBPKDKAKIN(AJCDLBPHHHC.EnteredEditModeNextFrame, 0)]
	private static void FGLJOOLMKNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x55D92C0", Offset = "0x55D7CC0", VA = "0x1855D92C0")]
	[AsyncStateMachine(typeof(GLMHANMNBOI))]
	public static Task<Scene> ONBKHOLJIHN(string DHEPJJLJLLD, LoadSceneMode NLLGNHIGHCO = LoadSceneMode.Single, bool BOHHGFEMLNH = false, [Optional] PPKCEHBLCJE IBHNCIKHFOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x55D9050", Offset = "0x55D7A50", VA = "0x1855D9050")]
	[AsyncStateMachine(typeof(BMBKPAPLPAE))]
	private static Task LAJKKIKPCOO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x55D9120", Offset = "0x55D7B20", VA = "0x1855D9120")]
	[AsyncStateMachine(typeof(KHCMACMNHAD))]
	private static Task NLCDNHJBBDA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x55D89B0", Offset = "0x55D73B0", VA = "0x1855D89B0")]
	[AsyncStateMachine(typeof(KLAIEPIGDAK))]
	private static Task<Scene> JPKCAPEADHH(string DHEPJJLJLLD, LoadSceneMode NLLGNHIGHCO, bool BOHHGFEMLNH, PPKCEHBLCJE IFNGEGAGDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x55D8370", Offset = "0x55D6D70", VA = "0x1855D8370")]
	[AsyncStateMachine(typeof(DNAKKEICLNK))]
	private static Task<Scene> DKOEHJCDCLA(PPKCEHBLCJE IFNGEGAGDGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x55D8810", Offset = "0x55D7210", VA = "0x1855D8810")]
	public static global::OHPLDOPGNGG<Scene> JDNHCLLGLAL(string DHEPJJLJLLD, LoadSceneMode NLLGNHIGHCO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x55D8B10", Offset = "0x55D7510", VA = "0x1855D8B10")]
	public static GPMDAFELAJF KGAHMIHKJME(string DHEPJJLJLLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x55D84B0", Offset = "0x55D6EB0", VA = "0x1855D84B0")]
	[IteratorStateMachine(typeof(EKNNKMJOCNN))]
	private static IEnumerator<MJOGGKCIPED> EJCNNNCKBGG(string DHEPJJLJLLD, AMHJHFKKEOP BLDBLMIKLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x55D8FB0", Offset = "0x55D79B0", VA = "0x1855D8FB0")]
	[IteratorStateMachine(typeof(EILONENNLAD))]
	private static IEnumerator<MJOGGKCIPED> KPDHIMDEIAE(string DHEPJJLJLLD, LoadSceneMode NLLGNHIGHCO, global::MECOGDILELM<Scene> BLDBLMIKLCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x55D8150", Offset = "0x55D6B50", VA = "0x1855D8150")]
	public static bool AMOIHHOOIOI(out string GDPBBALNCOK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class HGHGHAIKNJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x55D51A0", Offset = "0x55D3BA0", VA = "0x1855D51A0")]
	public static IDisposable HNGLGAJJJKN(this JBECHHDAGEL CGFEOLDGFLJ, float GGFOILMAOPH, Action<float> JHMHIFHEEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x55D5120", Offset = "0x55D3B20", VA = "0x1855D5120")]
	public static IDisposable EMAAFJHNJIM(this JBECHHDAGEL CGFEOLDGFLJ, Action<float> JHMHIFHEEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x55D50A0", Offset = "0x55D3AA0", VA = "0x1855D50A0")]
	public static IDisposable ADNAAGCBIBM(this JBECHHDAGEL CGFEOLDGFLJ, Action<float> JHMHIFHEEJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KLGAHNBNNMP
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x55D7AE0", Offset = "0x55D64E0", VA = "0x1855D7AE0")]
	public static IDisposable FHAENDJMMCF(this MonoBehaviour AADBINKEJCM, Action JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x55D7A60", Offset = "0x55D6460", VA = "0x1855D7A60")]
	public static IDisposable FHAENDJMMCF(this MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x55D77A0", Offset = "0x55D61A0", VA = "0x1855D77A0")]
	public static IDisposable BBFMMOJDOFP(this MonoBehaviour AADBINKEJCM, Action JHMHIFHEEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x55D7F30", Offset = "0x55D6930", VA = "0x1855D7F30")]
	public static IDisposable NKDDKEPLNOK(this MonoBehaviour AADBINKEJCM, Action JHMHIFHEEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x55D7810", Offset = "0x55D6210", VA = "0x1855D7810")]
	public static IDisposable BEPDGBEFKOG(this MonoBehaviour AADBINKEJCM, Action JHMHIFHEEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x55D7D10", Offset = "0x55D6710", VA = "0x1855D7D10")]
	public static IDisposable HFHOEBEEBFE(this MonoBehaviour AADBINKEJCM, Action JHMHIFHEEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x55D7EB0", Offset = "0x55D68B0", VA = "0x1855D7EB0")]
	public static IDisposable KGANOIMGCFP(this MonoBehaviour AADBINKEJCM, Action JHMHIFHEEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x55D7700", Offset = "0x55D6100", VA = "0x1855D7700")]
	public static IDisposable ANGGKJHGJGD(this MonoBehaviour AADBINKEJCM, float GGFOILMAOPH, Action<float> JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x55D7930", Offset = "0x55D6330", VA = "0x1855D7930")]
	public static IDisposable DPOFABHICPG(this MonoBehaviour AADBINKEJCM, float GGFOILMAOPH, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x55D7E20", Offset = "0x55D6820", VA = "0x1855D7E20")]
	public static IDisposable HMMOIBEGIGD(this MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x55D7C80", Offset = "0x55D6680", VA = "0x1855D7C80")]
	public static IDisposable GFGHJPIPECP(this MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x55D7D90", Offset = "0x55D6790", VA = "0x1855D7D90")]
	public static IDisposable HLIJHMPKOHG(this MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x55D79D0", Offset = "0x55D63D0", VA = "0x1855D79D0")]
	public static IDisposable EFCGNMCNOPJ(this MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x55D7FB0", Offset = "0x55D69B0", VA = "0x1855D7FB0")]
	public static IDisposable POOAGPCHNHC(this MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x55D7B60", Offset = "0x55D6560", VA = "0x1855D7B60")]
	public static IDisposable FNNIHBNKPHI(this MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x55D7670", Offset = "0x55D6070", VA = "0x1855D7670")]
	public static IDisposable AEMCPMONEMC(this MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x55D7890", Offset = "0x55D6290", VA = "0x1855D7890")]
	public static IDisposable DGMMBNLEKGN(this MonoBehaviour AADBINKEJCM, float GGFOILMAOPH, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x55D7BF0", Offset = "0x55D65F0", VA = "0x1855D7BF0")]
	public static IDisposable GDNOFOLIHCP(this MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class NPEJPJIMFLP
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class HPFFCIPKPKI : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public BDFIBPFAIEE.LPALJPJOHND queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private JDFMHBPCIBN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public HPFFCIPKPKI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x55D58B0", Offset = "0x55D42B0", VA = "0x1855D58B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x55D5970", Offset = "0x55D4370", VA = "0x1855D5970", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class DMDEPNCHHLG : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public BDFIBPFAIEE.LPALJPJOHND queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private JDFMHBPCIBN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public DMDEPNCHHLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x55CC6A0", Offset = "0x55CB0A0", VA = "0x1855CC6A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x55CC790", Offset = "0x55CB190", VA = "0x1855CC790", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x55DB440", Offset = "0x55D9E40", VA = "0x1855DB440")]
	public static KLOMPNKHCCP FHAENDJMMCF(Action JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x55DB4F0", Offset = "0x55D9EF0", VA = "0x1855DB4F0")]
	public static KLOMPNKHCCP FHAENDJMMCF(Behaviour CGFEOLDGFLJ, Action JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x55DB330", Offset = "0x55D9D30", VA = "0x1855DB330")]
	public static KLOMPNKHCCP FHAENDJMMCF(Behaviour CGFEOLDGFLJ, Action<float> JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x55DB230", Offset = "0x55D9C30", VA = "0x1855DB230")]
	[IteratorStateMachine(typeof(HPFFCIPKPKI))]
	private static IEnumerator<MJOGGKCIPED> BEEEAJEMBPC(BDFIBPFAIEE.LPALJPJOHND GNIBBBNGGIK, Action JHMHIFHEEJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x55DB2B0", Offset = "0x55D9CB0", VA = "0x1855DB2B0")]
	[IteratorStateMachine(typeof(DMDEPNCHHLG))]
	private static IEnumerator<MJOGGKCIPED> BEEEAJEMBPC(BDFIBPFAIEE.LPALJPJOHND GNIBBBNGGIK, Action<float> JHMHIFHEEJH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class EFIDCOMCBCF
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class EOPPPOABIAJ : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public LFIBLNHOCAM schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public BDFIBPFAIEE.LPALJPJOHND queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private FHKEINFAMEP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public EOPPPOABIAJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x55D30B0", Offset = "0x55D1AB0", VA = "0x1855D30B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x55D31F0", Offset = "0x55D1BF0", VA = "0x1855D31F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x55D0200", Offset = "0x55CEC00", VA = "0x1855D0200")]
	public static KLOMPNKHCCP FHAENDJMMCF(float GGFOILMAOPH, Action<float> JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, bool OCEKLIANECN = true, [Optional] ENCKEJCLIFL PHMHCJPIODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x55D0300", Offset = "0x55CED00", VA = "0x1855D0300")]
	public static KLOMPNKHCCP FHAENDJMMCF(MonoBehaviour AADBINKEJCM, float GGFOILMAOPH, Action<float> JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, bool OCEKLIANECN = true, [Optional] ENCKEJCLIFL PHMHCJPIODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x55D0410", Offset = "0x55CEE10", VA = "0x1855D0410")]
	public static KLOMPNKHCCP HPJGBAABNPF(JBECHHDAGEL CGFEOLDGFLJ, float GGFOILMAOPH, Action<float> JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, bool OCEKLIANECN = true, [Optional] ENCKEJCLIFL PHMHCJPIODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x55D0150", Offset = "0x55CEB50", VA = "0x1855D0150")]
	[IteratorStateMachine(typeof(EOPPPOABIAJ))]
	private static IEnumerator<MJOGGKCIPED> BEEEAJEMBPC(LFIBLNHOCAM ONLEPPECHNC, float GGFOILMAOPH, BDFIBPFAIEE.LPALJPJOHND GNIBBBNGGIK, Action<float> JHMHIFHEEJH, bool OCEKLIANECN = true, [Optional] ENCKEJCLIFL PHMHCJPIODC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class OONABAGABAE
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class PNIGCMCNNFL : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public BDFIBPFAIEE.LPALJPJOHND queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public PNIGCMCNNFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x55DBEE0", Offset = "0x55DA8E0", VA = "0x1855DBEE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x55DBF90", Offset = "0x55DA990", VA = "0x1855DBF90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x55DBCF0", Offset = "0x55DA6F0", VA = "0x1855DBCF0")]
	[IteratorStateMachine(typeof(PNIGCMCNNFL))]
	private static IEnumerator<MJOGGKCIPED> DDBDBENFNIL(BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, Func<bool> FMDBCAMNBCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x55DBD70", Offset = "0x55DA770", VA = "0x1855DBD70")]
	public static KLOMPNKHCCP OJFJCDBNJCM(this MonoBehaviour AADBINKEJCM, Func<bool> FMDBCAMNBCB, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN = BDFIBPFAIEE.LPALJPJOHND.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class GHDDLFFCELB
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class BJAOPPNFDPJ : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public BDFIBPFAIEE.LPALJPJOHND queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public BJAOPPNFDPJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x55C6B90", Offset = "0x55C5590", VA = "0x1855C6B90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x55C6C50", Offset = "0x55C5650", VA = "0x1855C6C50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x55D4810", Offset = "0x55D3210", VA = "0x1855D4810")]
	[IteratorStateMachine(typeof(BJAOPPNFDPJ))]
	private static IEnumerator<MJOGGKCIPED> JFKAJMEFILA(float JODKGBAPGIB, BDFIBPFAIEE.LPALJPJOHND GNIBBBNGGIK, Action BDHJENCECBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x55D4720", Offset = "0x55D3120", VA = "0x1855D4720")]
	public static KLOMPNKHCCP HGAPAIAPANO(this MonoBehaviour AADBINKEJCM, float JODKGBAPGIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x55D4700", Offset = "0x55D3100", VA = "0x1855D4700")]
	public static KLOMPNKHCCP HFBOFMCCLLA(this MonoBehaviour AADBINKEJCM, Action BDHJENCECBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x55D4460", Offset = "0x55D2E60", VA = "0x1855D4460")]
	public static KLOMPNKHCCP CKCACGDNIJO(this MonoBehaviour AADBINKEJCM, Action BDHJENCECBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x55D4350", Offset = "0x55D2D50", VA = "0x1855D4350")]
	public static KLOMPNKHCCP BJMDCHGMLAP(this MonoBehaviour AADBINKEJCM, Action BDHJENCECBN, [Optional] ENCKEJCLIFL PHMHCJPIODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x55D4970", Offset = "0x55D3370", VA = "0x1855D4970")]
	public static KLOMPNKHCCP OECLNCPLIGH(this MonoBehaviour AADBINKEJCM, Action BDHJENCECBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x55D47E0", Offset = "0x55D31E0", VA = "0x1855D47E0")]
	public static KLOMPNKHCCP HPPAHMBBAKA(this MonoBehaviour AADBINKEJCM, Action BDHJENCECBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x55D4430", Offset = "0x55D2E30", VA = "0x1855D4430")]
	public static KLOMPNKHCCP CHHLJDOMHJD(this MonoBehaviour AADBINKEJCM, Action BDHJENCECBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x55D4560", Offset = "0x55D2F60", VA = "0x1855D4560")]
	private static KLOMPNKHCCP GOIHLEDPOHJ(MonoBehaviour AADBINKEJCM, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, Action BDHJENCECBN, [Optional] ENCKEJCLIFL PHMHCJPIODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x55D4630", Offset = "0x55D3030", VA = "0x1855D4630")]
	public static KLOMPNKHCCP HBJHCJOMLIB(this MonoBehaviour AADBINKEJCM, float HPLMBOPJJBD, Action BDHJENCECBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x55D48A0", Offset = "0x55D32A0", VA = "0x1855D48A0")]
	public static KLOMPNKHCCP MFJLNJALJLO(this MonoBehaviour AADBINKEJCM, float HPLMBOPJJBD, Action BDHJENCECBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x55D4490", Offset = "0x55D2E90", VA = "0x1855D4490")]
	public static KLOMPNKHCCP GJLNNMGPOAH(this MonoBehaviour AADBINKEJCM, float HPLMBOPJJBD, Action BDHJENCECBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x55D4280", Offset = "0x55D2C80", VA = "0x1855D4280")]
	public static KLOMPNKHCCP ALBIOAOLNKI(this MonoBehaviour AADBINKEJCM, float HPLMBOPJJBD, Action BDHJENCECBN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class NJDEIKNAJDP : ICHFFIPCEGN, IEnumerable<ICHFFIPCEGN>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly List<ICHFFIPCEGN> BCHICAPMGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool MGEABAEECJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Action JPHAMIGINPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool HAGCOCNEALL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool PPLHDAILGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x55DAD60", Offset = "0x55D9760", VA = "0x1855DAD60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action MPKANLODJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x55DAB50", Offset = "0x55D9550", VA = "0x1855DAB50", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x55DAA30", Offset = "0x55D9430", VA = "0x1855DAA30", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x55DB190", Offset = "0x55D9B90", VA = "0x1855DB190")]
	public NJDEIKNAJDP([Optional] Action JPHAMIGINPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x55DA900", Offset = "0x55D9300", VA = "0x1855DA900")]
	public void CPLOAHMOJFD(ICHFFIPCEGN OHMPFKHIEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x55DABF0", Offset = "0x55D95F0", VA = "0x1855DABF0")]
	private void KCIIPJNOOPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x55DB180", Offset = "0x55D9B80", VA = "0x1855DB180", Slot = "7")]
	public bool OBBIJPGMFAI(bool GONNPACEKOP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x55DAEA0", Offset = "0x55D98A0", VA = "0x1855DAEA0", Slot = "8")]
	public bool OBBIJPGMFAI(Action CKAPOBIDCEI, bool GONNPACEKOP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x55DAAD0", Offset = "0x55D94D0", VA = "0x1855DAAD0", Slot = "9")]
	public IEnumerator<ICHFFIPCEGN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x55DAAD0", Offset = "0x55D94D0", VA = "0x1855DAAD0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class FELDLIANHHH : KABKCIHPCOH
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class NFCIALOFICC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public FELDLIANHHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public NFCIALOFICC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x55D3D40", Offset = "0x55D2740", VA = "0x1855D3D40")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class FILIKDNJLBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public FELDLIANHHH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public FILIKDNJLBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x55D3D40", Offset = "0x55D2740", VA = "0x1855D3D40")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float BKPPOOCMMJO;

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x55D3430", Offset = "0x55D1E30", VA = "0x1855D3430")]
	public FELDLIANHHH(Behaviour CGFEOLDGFLJ, float BKPPOOCMMJO, [Optional] Action JPHAMIGINPM, [Optional] ENCKEJCLIFL PHMHCJPIODC, [Optional] LFIBLNHOCAM ONLEPPECHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x55D3330", Offset = "0x55D1D30", VA = "0x1855D3330", Slot = "9")]
	protected override bool PDBLFBDCAIA(Action CKAPOBIDCEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x55D3230", Offset = "0x55D1C30", VA = "0x1855D3230", Slot = "10")]
	protected override bool HKIBPDLLHMP(Action CKAPOBIDCEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface ICHFFIPCEGN
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool PPLHDAILGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action MPKANLODJPJ;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OBBIJPGMFAI(bool GONNPACEKOP = false);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OBBIJPGMFAI(Action CKAPOBIDCEI, bool GONNPACEKOP = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class KABKCIHPCOH : ICHFFIPCEGN
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class KPHEJIMGKBO : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public KABKCIHPCOH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public KPHEJIMGKBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x55D8040", Offset = "0x55D6A40", VA = "0x1855D8040", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x55D8110", Offset = "0x55D6B10", VA = "0x1855D8110", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Behaviour CGFEOLDGFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Action JPHAMIGINPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private NPKEGPKMBCL LFDBDHIIAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly ENCKEJCLIFL PHMHCJPIODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	protected readonly LFIBLNHOCAM ONLEPPECHNC;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool PPLHDAILGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x712910", Offset = "0x711310", VA = "0x180712910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action MPKANLODJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x55D6420", Offset = "0x55D4E20", VA = "0x1855D6420", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x55D6380", Offset = "0x55D4D80", VA = "0x1855D6380", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x55D67D0", Offset = "0x55D51D0", VA = "0x1855D67D0")]
	protected KABKCIHPCOH(Behaviour CGFEOLDGFLJ, [Optional] Action JPHAMIGINPM, [Optional] ENCKEJCLIFL PHMHCJPIODC, [Optional] LFIBLNHOCAM ONLEPPECHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x55D6700", Offset = "0x55D5100", VA = "0x1855D6700", Slot = "7")]
	public bool OBBIJPGMFAI(bool GONNPACEKOP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x55D6760", Offset = "0x55D5160", VA = "0x1855D6760", Slot = "8")]
	public bool OBBIJPGMFAI(Action CKAPOBIDCEI, bool GONNPACEKOP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool PDBLFBDCAIA(Action CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool HKIBPDLLHMP(Action CKAPOBIDCEI);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x55D67B0", Offset = "0x55D51B0", VA = "0x1855D67B0")]
	protected void OPPFCAMJIID(Action CKAPOBIDCEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x55D6500", Offset = "0x55D4F00", VA = "0x1855D6500")]
	protected GPMDAFELAJF IAPIGMEBBLC(float NNKPALPMOPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x55D6280", Offset = "0x55D4C80", VA = "0x1855D6280")]
	private void BLLDABNHLMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x55D6300", Offset = "0x55D4D00", VA = "0x1855D6300")]
	[IteratorStateMachine(typeof(KPHEJIMGKBO))]
	private IEnumerator<MJOGGKCIPED> DJOAAMFCCAO(float NNKPALPMOPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x55D64C0", Offset = "0x55D4EC0", VA = "0x1855D64C0")]
	[CompilerGenerated]
	private void HMJODDCJDFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class JOFIMLLHLBM : KABKCIHPCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float EICCILDHNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly int LJFDCKODCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float KJINAHBPFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float[] IIMJPLNBLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int HGFHCDIIFLO;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x55D60D0", Offset = "0x55D4AD0", VA = "0x1855D60D0")]
	public JOFIMLLHLBM(Behaviour CGFEOLDGFLJ, float PNFFIIBIHEB, int LJFDCKODCHM, [Optional] Action JPHAMIGINPM, float KJINAHBPFNI = 0f, [Optional] ENCKEJCLIFL PHMHCJPIODC, [Optional] LFIBLNHOCAM ONLEPPECHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "9")]
	protected override bool PDBLFBDCAIA(Action CKAPOBIDCEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x55D5E10", Offset = "0x55D4810", VA = "0x1855D5E10", Slot = "10")]
	protected override bool HKIBPDLLHMP(Action CKAPOBIDCEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x55D6040", Offset = "0x55D4A40", VA = "0x1855D6040")]
	private void PHGNKFFLAAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LMAANOGCLGC : KABKCIHPCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly float BKPPOOCMMJO;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x55D3430", Offset = "0x55D1E30", VA = "0x1855D3430")]
	public LMAANOGCLGC(Behaviour CGFEOLDGFLJ, float BKPPOOCMMJO, [Optional] Action JPHAMIGINPM, [Optional] ENCKEJCLIFL PHMHCJPIODC, [Optional] LFIBLNHOCAM ONLEPPECHNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6C4D00", Offset = "0x6C3700", VA = "0x1806C4D00", Slot = "9")]
	protected override bool PDBLFBDCAIA(Action CKAPOBIDCEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x55D9750", Offset = "0x55D8150", VA = "0x1855D9750", Slot = "10")]
	protected override bool HKIBPDLLHMP(Action CKAPOBIDCEI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class BOGPCDCFPKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class HNMHEIHJPHN : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public HNMHEIHJPHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x55D57D0", Offset = "0x55D41D0", VA = "0x1855D57D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x55D5870", Offset = "0x55D4270", VA = "0x1855D5870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private KLOMPNKHCCP DODIEHLEIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private JBECHHDAGEL CGFEOLDGFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action<float> MGJGJHEFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float FJOFGHJEOGG;

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x55C7C20", Offset = "0x55C6620", VA = "0x1855C7C20")]
	public BOGPCDCFPKO(JBECHHDAGEL CGFEOLDGFLJ, float GGFOILMAOPH, Action<float> JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x55C7A70", Offset = "0x55C6470", VA = "0x1855C7A70")]
	private void PIMENDHFAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x55C7910", Offset = "0x55C6310", VA = "0x1855C7910")]
	private void HDJBKFMGLBD(string IMHLNJJFNDD, Action DLHFHMKHOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x55C78A0", Offset = "0x55C62A0", VA = "0x1855C78A0")]
	[IteratorStateMachine(typeof(HNMHEIHJPHN))]
	private IEnumerator<MJOGGKCIPED> GHBJDIJEIAG(Action DLHFHMKHOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x55C7840", Offset = "0x55C6240", VA = "0x1855C7840", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x55C7690", Offset = "0x55C6090", VA = "0x1855C7690")]
	[CompilerGenerated]
	private void DNFFDAIHFFM(string NJOLKOHDHLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class DGFBOGEFMHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class GFPBMFBCIIH : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private MJOGGKCIPED <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
		[DebuggerHidden]
		public GFPBMFBCIIH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x55D41A0", Offset = "0x55D2BA0", VA = "0x1855D41A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x55D4240", Offset = "0x55D2C40", VA = "0x1855D4240", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private KLOMPNKHCCP DODIEHLEIKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MonoBehaviour AADBINKEJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Action JHMHIFHEEJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action<float> MGJGJHEFKMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float FJOFGHJEOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool OCEKLIANECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly ENCKEJCLIFL PHMHCJPIODC;

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x55CC4A0", Offset = "0x55CAEA0", VA = "0x1855CC4A0")]
	public DGFBOGEFMHC(MonoBehaviour AADBINKEJCM, Action JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, [Optional] ENCKEJCLIFL PHMHCJPIODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x55CC260", Offset = "0x55CAC60", VA = "0x1855CC260")]
	public DGFBOGEFMHC(MonoBehaviour AADBINKEJCM, Action<float> JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, [Optional] ENCKEJCLIFL PHMHCJPIODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x55CC000", Offset = "0x55CAA00", VA = "0x1855CC000")]
	public DGFBOGEFMHC(MonoBehaviour AADBINKEJCM, float GGFOILMAOPH, Action<float> JHMHIFHEEJH, BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN, bool OCEKLIANECN = true, [Optional] ENCKEJCLIFL PHMHCJPIODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x55CB7D0", Offset = "0x55CA1D0", VA = "0x1855CB7D0")]
	private void FHAENDJMMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x55CBC90", Offset = "0x55CA690", VA = "0x1855CBC90")]
	private void NIKMAOLABAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x55CBE40", Offset = "0x55CA840", VA = "0x1855CBE40")]
	private void PIMENDHFAMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x55CBA40", Offset = "0x55CA440", VA = "0x1855CBA40")]
	private void HDJBKFMGLBD(string IMHLNJJFNDD, Action DLHFHMKHOPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x55CB940", Offset = "0x55CA340", VA = "0x1855CB940")]
	[IteratorStateMachine(typeof(GFPBMFBCIIH))]
	private IEnumerator<MJOGGKCIPED> GHBJDIJEIAG(Action DLHFHMKHOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x55CB770", Offset = "0x55CA170", VA = "0x1855CB770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x55CB9B0", Offset = "0x55CA3B0", VA = "0x1855CB9B0")]
	[CompilerGenerated]
	private void GKBLMPIALKH(string NJOLKOHDHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x55CBB70", Offset = "0x55CA570", VA = "0x1855CBB70")]
	[CompilerGenerated]
	private void HJGKHGNFDAJ(string NJOLKOHDHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x55CBC00", Offset = "0x55CA600", VA = "0x1855CBC00")]
	[CompilerGenerated]
	private void MMGOMKCMFJM(string NJOLKOHDHLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum IGMAHLMEMPO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class BMKCDIGEKPK : LFIBLNHOCAM
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float NDICEIPHCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x55C71E0", Offset = "0x55C5BE0", VA = "0x1855C71E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float ADKFABKLJLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x55C7210", Offset = "0x55C5C10", VA = "0x1855C7210", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double PEJJDLPCLAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x55C71F0", Offset = "0x55C5BF0", VA = "0x1855C71F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x55C7170", Offset = "0x55C5B70", VA = "0x1855C7170")]
	[CJJNALDLMHL(HFKENCJEONK.None)]
	private static void AMHBNEJDOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	[Preserve]
	internal BMKCDIGEKPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface LJHEOHEDDMP
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLGOKPJJEMM(string ANJJEPIBAGI);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BEMMCEGDDBH();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface MLIPBCFGDAN
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MDKBHHJGOBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool AADMBCLJKHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class NBKNOKFLHJK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public EADAPIIFBAB HEBHEMJIKFL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int FOHLPAKJEGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F30", Offset = "0x6E0930", VA = "0x1806E1F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x55DA490", Offset = "0x55D8E90", VA = "0x1855DA490")]
	public static MJOGGKCIPED NLGPOKOPKDN(IEnumerator<MJOGGKCIPED> HLOHODILCKL, EGBOBAAIKPH IOHGIBCLENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x55DA640", Offset = "0x55D9040", VA = "0x1855DA640")]
	public MJOGGKCIPED NLGPOKOPKDN(EGBOBAAIKPH[] MFJAOOMLHFC, IEnumerator<MJOGGKCIPED>[] NKFKBODDLJI, MJOGGKCIPED[] CJBPOKKKEHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x55DA320", Offset = "0x55D8D20", VA = "0x1855DA320")]
	public void MCCCPMLJKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x55DA1E0", Offset = "0x55D8BE0", VA = "0x1855DA1E0")]
	public void HLLGMEMMIBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x55DA350", Offset = "0x55D8D50", VA = "0x1855DA350")]
	public void MIKDMKPHIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x55DA320", Offset = "0x55D8D20", VA = "0x1855DA320")]
	public void IAHAIEIHBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public NBKNOKFLHJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class EADAPIIFBAB
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct GEJNEINJCDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public NBKNOKFLHJK DFGGEEKEBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public JBECHHDAGEL OMALEDNDHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public EGBOBAAIKPH PKJCBGFLBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IEnumerator<MJOGGKCIPED> HMJHIPKLIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public MJOGGKCIPED PMGOPBAMFOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public IGMAHLMEMPO LIMINDNBJMK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct GKGDIPGJKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public BDFIBPFAIEE.LPALJPJOHND FOPJEAKPKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<GEJNEINJCDK> AIIFOGNKCOE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LNGKOBMNHIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public EGBOBAAIKPH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public EADAPIIFBAB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public JBECHHDAGEL context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public NBKNOKFLHJK routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public IGMAHLMEMPO coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public MJOGGKCIPED currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IEnumerator<MJOGGKCIPED> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public LNGKOBMNHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x55D9790", Offset = "0x55D8190", VA = "0x1855D9790")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class HGELNDKNMMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public NBKNOKFLHJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public EADAPIIFBAB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HGELNDKNMMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x55D5060", Offset = "0x55D3A60", VA = "0x1855D5060")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KIFNANBACPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public NBKNOKFLHJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public EADAPIIFBAB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public KIFNANBACPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x55D6C60", Offset = "0x55D5660", VA = "0x1855D6C60")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GBHHCDGOPEM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public NBKNOKFLHJK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public EADAPIIFBAB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public GBHHCDGOPEM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x55D4050", Offset = "0x55D2A50", VA = "0x1855D4050")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const IGMAHLMEMPO BPELKDABJPK = IGMAHLMEMPO.Cancelled | IGMAHLMEMPO.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool[] PBCFCEKKPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<IGMAHLMEMPO> OBGCGPHFPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float> DDDOHKKBDFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> PLJKAOGFEFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> HONBPINONBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<int> JMFHNIONGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> IAMIGHOCKIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> LNFEDMFNAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private NBKNOKFLHJK[] JACFKAPCPDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private EGBOBAAIKPH[] MFJAOOMLHFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private JBECHHDAGEL[] KOBHIFLBHBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IEnumerator<MJOGGKCIPED>[] NACCDJHFDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private MJOGGKCIPED[] DFABLBNDEIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int DBDANHEEJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int ADCMDGEMNDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int OEJLGALKADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float BMJBHCDDLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private FEOGNFLLKFK DPLDKABPEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private JobHandle HNEGJNIFMBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<NBKNOKFLHJK> KFBOPCHGMMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool HGLOPKHHNMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private List<Action> EDAJNFCIDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<Action> JJCNEEBPNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool HKEJNNACMBI;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GKGDIPGJKDK[] KMDGOGFPIKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xF544C0", Offset = "0xF52EC0", VA = "0x180F544C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x55CF2C0", Offset = "0x55CDCC0", VA = "0x1855CF2C0")]
	private static int ODDKNHJFOOM(BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x55CFB50", Offset = "0x55CE550", VA = "0x1855CFB50")]
	public EADAPIIFBAB(BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x55CE720", Offset = "0x55CD120", VA = "0x1855CE720")]
	private void IOFFMCGDFEI(ref int OIIHNGKPNHG, int JFEIFHCCKAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x55CE5A0", Offset = "0x55CCFA0", VA = "0x1855CE5A0")]
	public void IHEOLLMEKCD(JBECHHDAGEL CGFEOLDGFLJ, MJOGGKCIPED NGEHLJHDNPE, IEnumerator<MJOGGKCIPED> HLOHODILCKL, EGBOBAAIKPH IOHGIBCLENJ, [Optional] NBKNOKFLHJK FMJJNLDNNEF, IGMAHLMEMPO CGJHDLJAGDB = IGMAHLMEMPO.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x55CEE20", Offset = "0x55CD820", VA = "0x1855CEE20")]
	public void MALJADFLDGA(IEnumerable<GEJNEINJCDK> CBBKHCDGIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x55CD830", Offset = "0x55CC230", VA = "0x1855CD830")]
	private GEJNEINJCDK DFAFEGGCOLN(int AKICBJPNJAH)
	{
		return default(GEJNEINJCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x55CDD40", Offset = "0x55CC740", VA = "0x1855CDD40")]
	private void EIBAFCAOIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x22EB720", Offset = "0x22EA120", VA = "0x1822EB720")]
	private static void BJNDMDDCPNP<T>(int AKICBJPNJAH, T[] LJFLOEJOBOA, int HGBOOPNCHBL, [Optional] T BBAKHJFIPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x22EB700", Offset = "0x22EA100", VA = "0x1822EB700")]
	private static void BJNDMDDCPNP<T>(int AKICBJPNJAH, NativeArray<T> LJFLOEJOBOA, int HGBOOPNCHBL, [Optional] T BBAKHJFIPAC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x55CF010", Offset = "0x55CDA10", VA = "0x1855CF010")]
	private void NMMJLHCKHFE(IEnumerable<GEJNEINJCDK> CBBKHCDGIGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x55CE0E0", Offset = "0x55CCAE0", VA = "0x1855CE0E0")]
	private void EMPLEBAEOAO(GEJNEINJCDK EALFPPGNADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x55CE1B0", Offset = "0x55CCBB0", VA = "0x1855CE1B0")]
	private KHIEMHCBLMK GJBKLJFBKIL(int HPNPGJHCJKP)
	{
		return default(KHIEMHCBLMK);
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x55CEA90", Offset = "0x55CD490", VA = "0x1855CEA90")]
	public void LGNDGGIDBPM(float HLFIGFHLOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x55CEA10", Offset = "0x55CD410", VA = "0x1855CEA10")]
	private void KBKFJBLHAJA(Action PKEMCIANHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x55CEDA0", Offset = "0x55CD7A0", VA = "0x1855CEDA0")]
	private void LPDBHGPFICB(Action PKEMCIANHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x55CF420", Offset = "0x55CDE20", VA = "0x1855CF420")]
	public void PBPDBHLOLBK(float HLFIGFHLOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x55CE910", Offset = "0x55CD310", VA = "0x1855CE910")]
	public void JGBMECMGNKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x55CE470", Offset = "0x55CCE70", VA = "0x1855CE470")]
	public void IAHAIEIHBPC(NBKNOKFLHJK NKLINDOCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x55CF2F0", Offset = "0x55CDCF0", VA = "0x1855CF2F0")]
	public void OPBOCGOCLAI(NBKNOKFLHJK NKLINDOCOOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x55CEC70", Offset = "0x55CD670", VA = "0x1855CEC70")]
	public void LOOFIPMHMLE(NBKNOKFLHJK NKLINDOCOOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class FGCJFEHFFCC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static readonly FGCJFEHFFCC FHLENDJALHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Action OANBHJODCBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool IAFLCEPGHIO;

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	public FGCJFEHFFCC(Action OANBHJODCBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x55D3C20", Offset = "0x55D2620", VA = "0x1855D3C20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface IMFABFEEENB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GJPLOFCJGAA(UnityEngine.Object CGFEOLDGFLJ, Action<T> INJHNKMAADI);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface IJKELJMONGP<T> : global::IMFABFEEENB<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class IJFBOJDBBCL<T> : global::IJKELJMONGP<T>, global::IMFABFEEENB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class HJIHCKLGHOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public global::IJFBOJDBBCL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public global::JEMIEBFNHFJ<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0xF581E0", Offset = "0xF56BE0", VA = "0x180F581E0")]
		public HJIHCKLGHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x3BA5EF0", Offset = "0x3BA48F0", VA = "0x183BA5EF0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static GameObject GAHNDCBFLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<global::JEMIEBFNHFJ<UnityEngine.Object, Action<T>>> GEGOPPIOBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private T BAPDBGANFLL;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T ACPLDDIHALN
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6DB8D0", Offset = "0x6DA2D0", VA = "0x1806DB8D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x22201A0", Offset = "0x221EBA0", VA = "0x1822201A0", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x221FDB0", Offset = "0x221E7B0", VA = "0x18221FDB0")]
	private static bool GGGDBDIONOA(T PKEMCIANHMO, T DLAMIJMLOOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x22202A0", Offset = "0x221ECA0", VA = "0x1822202A0")]
	public IJFBOJDBBCL(T ALDFDMJACLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x221FFB0", Offset = "0x221E9B0", VA = "0x18221FFB0", Slot = "6")]
	public IDisposable GJPLOFCJGAA(UnityEngine.Object CGFEOLDGFLJ, Action<T> INJHNKMAADI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x221F6F0", Offset = "0x221E0F0", VA = "0x18221F6F0")]
	private void FIDBKGOFHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class GDKGOMJCFBO : IIFNDEHHOAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly ENCKEJCLIFL PHMHCJPIODC;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x55D4090", Offset = "0x55D2A90", VA = "0x1855D4090")]
	[CJJNALDLMHL(HFKENCJEONK.None)]
	private static void AMHBNEJDOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	[Preserve]
	internal GDKGOMJCFBO([HGGCKJALFAG(null)] ENCKEJCLIFL PHMHCJPIODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x55D4100", Offset = "0x55D2B00", VA = "0x1855D4100", Slot = "4")]
	public IDisposable DPOFABHICPG(float GGFOILMAOPH, Action<float> JOIALDGLEAK, bool OCEKLIANECN = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct FEOGNFLLKFK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[ReadOnly]
	public float KOCNGFGFLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ReadOnly]
	public int NGBLMDBBFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeArray<int> HONBGANEEOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeArray<int> LFMHOGPNJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> FPHHPKPAHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[ReadOnly]
	public NativeArray<IGMAHLMEMPO> NHJCACILNJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	public NativeArray<float> DHEOBAEKKNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[WriteOnly]
	public NativeArray<int> JMFHNIONGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[WriteOnly]
	public NativeArray<int> PLJKAOGFEFF;

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x55D3870", Offset = "0x55D2270", VA = "0x1855D3870")]
	public static FEOGNFLLKFK GANMJPNFBJN(int OPMELLIAFNC, float HLFIGFHLOJN, NativeArray<IGMAHLMEMPO> JAMFONHPNJD, NativeArray<float> HFGIKIFLIFC, NativeArray<int> OHLNNIKLJGN, NativeArray<int> CIBALIOFIDF, NativeArray<int> CPKPMLJACGN, NativeArray<int> LFMHOGPNJKI, NativeArray<int> FPHHPKPAHIK)
	{
		return default(FEOGNFLLKFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x55D3790", Offset = "0x55D2190", VA = "0x1855D3790", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x55D3930", Offset = "0x55D2330", VA = "0x1855D3930")]
	private bool MNONEDJCLHB(int GFDMFLGCBKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x55D3760", Offset = "0x55D2160", VA = "0x1855D3760")]
	private void CJLDLDLOBDC(NativeArray<int> KDBKOGJPJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x55D38D0", Offset = "0x55D22D0", VA = "0x1855D38D0")]
	private int GIBBGNCJIGI(int MIDPGNKBPGJ, int PECJMDLPMKH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x55D3970", Offset = "0x55D2370", VA = "0x1855D3970")]
	private void OOPEAJINDFC(NativeArray<int> KDBKOGJPJOL, int IPNLNIMMJIO, int CBKOMEMMCDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x55D3530", Offset = "0x55D1F30", VA = "0x1855D3530")]
	private void ALGHFJAENLO(NativeArray<int> KDBKOGJPJOL, int IOJDDFKFPBH, int CKKFMEDKKMG, int IFCNDIPENDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class AGPBJHJFDJC : POKDIAMLJHG, ENCKEJCLIFL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private EADAPIIFBAB[] ADMPEMNJLHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private LJHEOHEDDMP PENDEBDAACF;

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x55C5C00", Offset = "0x55C4600", VA = "0x1855C5C00")]
	[CJJNALDLMHL(HFKENCJEONK.None)]
	private static void AMHBNEJDOHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x55C6650", Offset = "0x55C5050", VA = "0x1855C6650")]
	[Preserve]
	public AGPBJHJFDJC([HGGCKJALFAG(null)] IJDFDJPODLE ALKIDPJPODP, [HGGCKJALFAG(null)] LFIBLNHOCAM ONLEPPECHNC, [HGGCKJALFAG(null)] GHHBCHHFFKD AFHBEGAMCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x55C61F0", Offset = "0x55C4BF0", VA = "0x1855C61F0", Slot = "12")]
	public override KLOMPNKHCCP IMFCMJBCNLP(JBECHHDAGEL CGFEOLDGFLJ, IEnumerator<MJOGGKCIPED> EHCNIODEPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x55C6330", Offset = "0x55C4D30", VA = "0x1855C6330", Slot = "13")]
	public override void KNCDGFAKBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x55C6010", Offset = "0x55C4A10", VA = "0x1855C6010", Slot = "15")]
	public override void HEPCCBGBOEJ(BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x55C5C70", Offset = "0x55C4670", VA = "0x1855C5C70", Slot = "14")]
	protected override void BBFMMOJDOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x55C6610", Offset = "0x55C5010", VA = "0x1855C6610")]
	private EADAPIIFBAB MGJNEKBKLIF(BDFIBPFAIEE.LPALJPJOHND MAHAMGBPDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x55C5EF0", Offset = "0x55C48F0", VA = "0x1855C5EF0", Slot = "16")]
	internal override EHFPGNIEADF CBADGHHHOGP(IEnumerator<MJOGGKCIPED> EHCNIODEPKP, Behaviour CGFEOLDGFLJ, EGBOBAAIKPH IOHGIBCLENJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x55C5E80", Offset = "0x55C4880", VA = "0x1855C5E80", Slot = "17")]
	internal override EMALEDHJEBF BDFMKMMOEFN(BDFIBPFAIEE.LPALJPJOHND GNIBBBNGGIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x55C5D50", Offset = "0x55C4750", VA = "0x1855C5D50")]
	private void BCDHCPIMBNE(EADAPIIFBAB DCEPNIIKPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x55C5FA0", Offset = "0x55C49A0", VA = "0x1855C5FA0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class POKDIAMLJHG : ENCKEJCLIFL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly IJDFDJPODLE ALKIDPJPODP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	protected readonly LFIBLNHOCAM ONLEPPECHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly GHHBCHHFFKD AFHBEGAMCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private EMALEDHJEBF[] NGKJGNGAIHD;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static ENCKEJCLIFL FMAHKEPPCOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x55DC8B0", Offset = "0x55DB2B0", VA = "0x1855DC8B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool HNCHBAEIKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E2020", Offset = "0x6E0A20", VA = "0x1806E2020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BDFIBPFAIEE.LPALJPJOHND OEIFLMKMCPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6C1040", Offset = "0x6BFA40", VA = "0x1806C1040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(BDFIBPFAIEE.LPALJPJOHND);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x6E1F30", Offset = "0x6E0930", VA = "0x1806E1F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public LFIBLNHOCAM HCKOOEGMGPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x6C2120", Offset = "0x6C0B20", VA = "0x1806C2120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x55DCCB0", Offset = "0x55DB6B0", VA = "0x1855DCCB0")]
	public static KLOMPNKHCCP KPOHBFHCHAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x55DCDD0", Offset = "0x55DB7D0", VA = "0x1855DCDD0")]
	[Preserve]
	protected POKDIAMLJHG([HGGCKJALFAG(null)] IJDFDJPODLE ALKIDPJPODP, [HGGCKJALFAG(null)] LFIBLNHOCAM ONLEPPECHNC, [HGGCKJALFAG(null)] GHHBCHHFFKD AFHBEGAMCGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x55DC670", Offset = "0x55DB070", VA = "0x1855DC670", Slot = "6")]
	public KLOMPNKHCCP HHNJFAHFJBP(IEnumerator<MJOGGKCIPED> EHCNIODEPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x55DC680", Offset = "0x55DB080", VA = "0x1855DC680", Slot = "7")]
	public KLOMPNKHCCP HHNJFAHFJBP(Behaviour CGFEOLDGFLJ, IEnumerator<MJOGGKCIPED> EHCNIODEPKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract KLOMPNKHCCP IMFCMJBCNLP(JBECHHDAGEL CGFEOLDGFLJ, IEnumerator<MJOGGKCIPED> EHCNIODEPKP);

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x55DCAD0", Offset = "0x55DB4D0", VA = "0x1855DCAD0", Slot = "13")]
	public virtual void KNCDGFAKBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x55DC010", Offset = "0x55DAA10", VA = "0x1855DC010", Slot = "9")]
	public void DEPMAFFIJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x55DBFD0", Offset = "0x55DA9D0", VA = "0x1855DBFD0", Slot = "14")]
	protected virtual void BBFMMOJDOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x55DCD50", Offset = "0x55DB750", VA = "0x1855DCD50")]
	private void LAIGKHANEBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x55DCD70", Offset = "0x55DB770", VA = "0x1855DCD70")]
	private void LEKAPCLKDCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x55DCDB0", Offset = "0x55DB7B0", VA = "0x1855DCDB0")]
	private void NKDDKEPLNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x55DBFF0", Offset = "0x55DA9F0", VA = "0x1855DBFF0")]
	private void BEPDGBEFKOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x55DC3F0", Offset = "0x55DADF0", VA = "0x1855DC3F0")]
	private void FHHFIAOBLMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x55DC410", Offset = "0x55DAE10", VA = "0x1855DC410")]
	private void HCDNLPJPCEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x55DCD90", Offset = "0x55DB790", VA = "0x1855DCD90")]
	private void NJOBMGEPOCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x55DC430", Offset = "0x55DAE30", VA = "0x1855DC430", Slot = "15")]
	public virtual void HEPCCBGBOEJ(BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x55DC900", Offset = "0x55DB300", VA = "0x1855DC900")]
	private void IJPLGHNAJEI(EMALEDHJEBF DCEPNIIKPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0xB84650", Offset = "0xB83050", VA = "0x180B84650")]
	private EMALEDHJEBF BEKICHNEDFN(BDFIBPFAIEE.LPALJPJOHND MAHAMGBPDNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract EHFPGNIEADF CBADGHHHOGP(IEnumerator<MJOGGKCIPED> EHCNIODEPKP, Behaviour AADBINKEJCM, EGBOBAAIKPH FFDILIFDLAP);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract EMALEDHJEBF BDFMKMMOEFN(BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x55DC070", Offset = "0x55DAA70", VA = "0x1855DC070", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class EHFPGNIEADF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly EGBOBAAIKPH IOHGIBCLENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly MLIPBCFGDAN CGFEOLDGFLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly bool PEFCACCJADK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<MJOGGKCIPED> HMJHIPKLIFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6C2AC0", Offset = "0x6C14C0", VA = "0x1806C2AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E1130", Offset = "0x6DFB30", VA = "0x1806E1130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public MJOGGKCIPED PMGOPBAMFOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E1140", Offset = "0x6DFB40", VA = "0x1806E1140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool HFLNMOAEPIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x55D05B0", Offset = "0x55CEFB0", VA = "0x1855D05B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool GEPLLEJBFDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0xA43DA0", Offset = "0xA427A0", VA = "0x180A43DA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x2220C20", Offset = "0x221F620", VA = "0x182220C20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C8590", Offset = "0x6C6F90", VA = "0x1806C8590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float GIBIAIIGJFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x11375E0", Offset = "0x1135FE0", VA = "0x1811375E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x1137460", Offset = "0x1135E60", VA = "0x181137460")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x55D0AA0", Offset = "0x55CF4A0", VA = "0x1855D0AA0")]
	public EHFPGNIEADF(IEnumerator<MJOGGKCIPED> HLOHODILCKL, MLIPBCFGDAN CGFEOLDGFLJ, EGBOBAAIKPH IOHGIBCLENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x55D0720", Offset = "0x55CF120", VA = "0x1855D0720")]
	public MJOGGKCIPED NLGPOKOPKDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x55D06B0", Offset = "0x55CF0B0", VA = "0x1855D06B0")]
	public bool NFOILLEBAEJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x55D0630", Offset = "0x55CF030", VA = "0x1855D0630")]
	public void IAHAIEIHBPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x55D09E0", Offset = "0x55CF3E0", VA = "0x1855D09E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1645C50", Offset = "0x1644650", VA = "0x181645C50")]
	[CompilerGenerated]
	private void FIFDJINKPPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class EGBOBAAIKPH : HOFOKIAIKFO, KLOMPNKHCCP, NPKEGPKMBCL, GPMDAFELAJF, IEnumerator, MJOGGKCIPED, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private BDFIBPFAIEE.LPALJPJOHND EHMAGGADPJM;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private BDFIBPFAIEE.LPALJPJOHND HGIFMDANIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x765510", Offset = "0x763F10", VA = "0x180765510", Slot = "23")]
		get
		{
			return default(BDFIBPFAIEE.LPALJPJOHND);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public BDFIBPFAIEE.LPALJPJOHND HEBHEMJIKFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0xA2A1F0", Offset = "0xA28BF0", VA = "0x180A2A1F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float GOMNDPMAHCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x100C4C0", Offset = "0x100AEC0", VA = "0x18100C4C0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x55D0530", Offset = "0x55CEF30", VA = "0x1855D0530", Slot = "24")]
	private bool HHKCICFJDOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x55D0520", Offset = "0x55CEF20", VA = "0x1855D0520", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x55D0550", Offset = "0x55CEF50", VA = "0x1855D0550")]
	public EGBOBAAIKPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum KHIEMHCBLMK : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal sealed class EMALEDHJEBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum MBEJEPDLDLO
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct IOHHBFGGPBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public BDFIBPFAIEE.LPALJPJOHND FOPJEAKPKPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public MBEJEPDLDLO DFGIEACLOLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public List<EHFPGNIEADF> LILLEEEGIIM;
	}

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly MBEJEPDLDLO[] IMDAGJDCIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly BDFIBPFAIEE.LPALJPJOHND PIBNIFEHKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool BDKBICFPBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly EHFPGNIEADF[] FOEFNHGPANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<EHFPGNIEADF> MMLPJEMGJHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Stack<int> KCKECGNBLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly List<EHFPGNIEADF> EGLJODDMMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Stack<int> JPHCINPGDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly LJHEOHEDDMP GBGJJFCGBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool HKEJNNACMBI;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IOHHBFGGPBP[,] EAKJBALMHDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x6C10D0", Offset = "0x6BFAD0", VA = "0x1806C10D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x55D2950", Offset = "0x55D1350", VA = "0x1855D2950")]
	public EMALEDHJEBF(BDFIBPFAIEE.LPALJPJOHND GNIBBBNGGIK, LJHEOHEDDMP GBGJJFCGBPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x55D19A0", Offset = "0x55D03A0", VA = "0x1855D19A0")]
	public void BHEEEFHNFKP(EHFPGNIEADF HLOHODILCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x55D2350", Offset = "0x55D0D50", VA = "0x1855D2350")]
	public void NLPOLOCINMB(IList<EHFPGNIEADF> NKFKBODDLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x55D1590", Offset = "0x55CFF90", VA = "0x1855D1590")]
	public void ANGCEBDLNCO(IList<EHFPGNIEADF> NKFKBODDLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x55D1E10", Offset = "0x55D0810", VA = "0x1855D1E10")]
	private void ENGJCDIDDEH(EHFPGNIEADF HLOHODILCKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x55D1F10", Offset = "0x55D0910", VA = "0x1855D1F10")]
	private void FDCBFCHIFMA(IList<EHFPGNIEADF> NKFKBODDLJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x55D2090", Offset = "0x55D0A90", VA = "0x1855D2090")]
	private KHIEMHCBLMK HGALNHHBIOI(EHFPGNIEADF HLOHODILCKL)
	{
		return default(KHIEMHCBLMK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x55D1860", Offset = "0x55D0260", VA = "0x1855D1860")]
	public void BBFMMOJDOFP(float HLFIGFHLOJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x55D1AC0", Offset = "0x55D04C0", VA = "0x1855D1AC0")]
	public void DEPMAFFIJBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x55D2620", Offset = "0x55D1020", VA = "0x1855D2620")]
	private void PDHHLADBCME(List<EHFPGNIEADF> NKFKBODDLJI, Stack<int> COFMJHPNBFH, bool KNIDGBKEPKM, float DBJPCPHABNF = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x55D1CD0", Offset = "0x55D06D0", VA = "0x1855D1CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x55D2230", Offset = "0x55D0C30", VA = "0x1855D2230")]
	private void LBFKEHIOENA(List<EHFPGNIEADF> NKFKBODDLJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class FPJDFHLANIP : LJHEOHEDDMP
{
	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "4")]
	public void NLGOKPJJEMM(string ANJJEPIBAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
	public void BEMMCEGDDBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public FPJDFHLANIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class AGGNEGFHKOB : MLIPBCFGDAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Behaviour AADBINKEJCM;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string AECGGMKOOEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x55C5AF0", Offset = "0x55C44F0", VA = "0x1855C5AF0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MDKBHHJGOBH
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x55C5BA0", Offset = "0x55C45A0", VA = "0x1855C5BA0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool AADMBCLJKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x55C5B80", Offset = "0x55C4580", VA = "0x1855C5B80", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F40", Offset = "0x6C0940", VA = "0x1806C1F40")]
	public AGGNEGFHKOB(Behaviour AADBINKEJCM)
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
