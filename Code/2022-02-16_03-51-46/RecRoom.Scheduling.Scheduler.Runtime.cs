using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> KHHEOFJCNJN(List<PlayerLoopSystem> LCIKPJLCODN, int PIIMBLJDMJO);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct NEJCBOIPGOE
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct HDENLNPLPJO
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static JCOGEPDMPJF KCMOGHDBIMB;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x4630860", Offset = "0x462F060", VA = "0x184630860")]
				public static PlayerLoopSystem GLAHDLHDNGL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct KHOAJABEIHJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static JCOGEPDMPJF IIFCLMAFLBO;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4636370", Offset = "0x4634B70", VA = "0x184636370")]
				public static PlayerLoopSystem GLAHDLHDNGL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct ICBICPELEJG
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static JCOGEPDMPJF CNFLKHJLMPE;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4631440", Offset = "0x462FC40", VA = "0x184631440")]
				public static PlayerLoopSystem GLAHDLHDNGL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct NJAHLNLPNBI
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static JCOGEPDMPJF PBODJCAMCBB;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4636A90", Offset = "0x4635290", VA = "0x184636A90")]
				public static PlayerLoopSystem GLAHDLHDNGL()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			internal struct EANOAOCKMCB
			{
				[Cpp2IlInjected.Token(Token = "0x200000E")]
				[CompilerGenerated]
				private sealed class MFIHOGAJJNJ
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400000F")]
					public BCNKBBOAGCG.HCIDEAJJJII key;

					[Cpp2IlInjected.Token(Token = "0x6000020")]
					[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
					public MFIHOGAJJNJ()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000021")]
					[Cpp2IlInjected.Address(RVA = "0x4636670", Offset = "0x4634E70", VA = "0x184636670")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IDisposable GABDCHLOENA;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x462F0B0", Offset = "0x462D8B0", VA = "0x18462F0B0")]
				public static PlayerLoopSystem CINCGDCOFGH(BCNKBBOAGCG.HCIDEAJJJII DOMICNELCFM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct OODKPPCMPPH
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class MHNLKFKHNHN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000010")]
					public BCNKBBOAGCG.HCIDEAJJJII key;

					[Cpp2IlInjected.Token(Token = "0x6000023")]
					[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
					public MHNLKFKHNHN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000024")]
					[Cpp2IlInjected.Address(RVA = "0x4636720", Offset = "0x4634F20", VA = "0x184636720")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x46393C0", Offset = "0x4637BC0", VA = "0x1846393C0")]
				public static PlayerLoopSystem CINCGDCOFGH(BCNKBBOAGCG.HCIDEAJJJII DOMICNELCFM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class OPIIAMGGNIF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public OPIIAMGGNIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x46394E0", Offset = "0x4637CE0", VA = "0x1846394E0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool FNHKBDJOBCC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool NPOGGCJFMIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x462D890", Offset = "0x462C090", VA = "0x18462D890")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x462D850", Offset = "0x462C050", VA = "0x18462D850")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x462C5D0", Offset = "0x462ADD0", VA = "0x18462C5D0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x462D8D0", Offset = "0x462C0D0", VA = "0x18462D8D0")]
		private static void FNJHPEAMFBE(BCNKBBOAGCG.HCIDEAJJJII DOMICNELCFM, ref PlayerLoopSystem IOJCPINMFNP, Type FIIKCBMAJKO, Type MHJLFNOHNCI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x462DBC0", Offset = "0x462C3C0", VA = "0x18462DBC0")]
		private static void KOBPHOHLGCE(ref PlayerLoopSystem IOJCPINMFNP, Type FIIKCBMAJKO, Type MHJLFNOHNCI, KHHEOFJCNJN MJLCFINKJGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x462DAA0", Offset = "0x462C2A0", VA = "0x18462DAA0")]
		private static void GGGFJOEKOAB(ref PlayerLoopSystem IOJCPINMFNP, Type FIIKCBMAJKO, Type MHJLFNOHNCI, PlayerLoopSystem? FCEFJKCMMLJ, PlayerLoopSystem? AEDGALNDKLJ)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BCNKBBOAGCG
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public enum HCIDEAJJJII
	{
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class DDGAACIILCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public readonly HCIDEAJJJII KOBOHLJLGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public readonly MJMJNKAOAEG AMKKCFAFFKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private long IHBKLEMDNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private long ECAKKMLOELB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public long EIEHFCBNIGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public int NCCCBLFLCEI;

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x462E2A0", Offset = "0x462CAA0", VA = "0x18462E2A0")]
		public DDGAACIILCI(HCIDEAJJJII MGMKEFAFHNG, int IFLLGLHPJNA = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x462DF40", Offset = "0x462C740", VA = "0x18462DF40")]
		public void DGLBBPAGKOM(int NLFBAJDAOIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x462DFC0", Offset = "0x462C7C0", VA = "0x18462DFC0")]
		public void HEGMMPPNLMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x462DF60", Offset = "0x462C760", VA = "0x18462DF60")]
		public void EBEDIKMEHNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x462E030", Offset = "0x462C830", VA = "0x18462E030")]
		public void HNGEFBOLFJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x462E200", Offset = "0x462CA00", VA = "0x18462E200")]
		public double OKFLFBFJONL(int DBEAJLDECPI)
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const int LBCBNNAGCEL = 90;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static HCIDEAJJJII[] AKNHENCLBDJ;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static DDGAACIILCI[] ECFBPGDMIEP;

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4629930", Offset = "0x4628130", VA = "0x184629930")]
	public static DDGAACIILCI OLKGEOLGNAA(HCIDEAJJJII DOMICNELCFM, int IFLLGLHPJNA = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x46298A0", Offset = "0x46280A0", VA = "0x1846298A0")]
	public static DDGAACIILCI HOHDJDGAJDD(HCIDEAJJJII DOMICNELCFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x46297F0", Offset = "0x4627FF0", VA = "0x1846297F0")]
	public static void GOIDFKCBMEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MJMJNKAOAEG : DKNGBNGLNNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public int LCECPHHMCJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Queue<double> JPEAPDABNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private double HCNLLMNMBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private double GLCPDOBBLPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double JMIFKHPKLFH;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JOAMBHLONBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4636950", Offset = "0x4635150", VA = "0x184636950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public double MPIMAGHLGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4636990", Offset = "0x4635190", VA = "0x184636990", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double GLCDJHJKOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x14FC240", Offset = "0x14FAA40", VA = "0x1814FC240", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double HIIKJJLACEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x123E130", Offset = "0x123C930", VA = "0x18123E130", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x46369F0", Offset = "0x46351F0", VA = "0x1846369F0")]
	public MJMJNKAOAEG(int JBCFOJNJKOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4636850", Offset = "0x4635050", VA = "0x184636850", Slot = "4")]
	public void IGCILBOEKJM(double JLCAKPLDGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x46367E0", Offset = "0x4634FE0", VA = "0x1846367E0", Slot = "5")]
	public void GPIBBPKOIDG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class GHLKNOOLOLB : DKNGBNGLNNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private long BPCIMPGFHBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double PPDLIGNEAFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double BGAMFJNNGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double MDIDKMMFEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double LPCGPIIIPKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double HCNLLMNMBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double GLCPDOBBLPE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public long DEPGKLODCFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double GLCDJHJKOBD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x14FC230", Offset = "0x14FAA30", VA = "0x1814FC230", Slot = "7")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public double HIIKJJLACEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x112D340", Offset = "0x112BB40", VA = "0x18112D340", Slot = "8")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public double ADFDAHNGIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x123E130", Offset = "0x123C930", VA = "0x18123E130")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public double CPCDCPILDDN
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x123E120", Offset = "0x123C920", VA = "0x18123E120")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public double MPIMAGHLGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x14FC160", Offset = "0x14FA960", VA = "0x1814FC160", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4630710", Offset = "0x462EF10", VA = "0x184630710", Slot = "4")]
	public void IGCILBOEKJM(double JLCAKPLDGCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x46306D0", Offset = "0x462EED0", VA = "0x1846306D0", Slot = "5")]
	public void GPIBBPKOIDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4630830", Offset = "0x462F030", VA = "0x184630830")]
	public GHLKNOOLOLB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface DKNGBNGLNNO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	double MPIMAGHLGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	double GLCDJHJKOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	double HIIKJJLACEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IGCILBOEKJM(double JLCAKPLDGCF);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GPIBBPKOIDG();
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CGNJMMKICOF
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private interface KDJFHPGAFOF
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		bool IEJHCBAICNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BDHAHGNBAKP();

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CHLJJDFPGFN();
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private abstract class HBBPCJLDBEE<TPromise, TMainThreadPromise> : KDJFHPGAFOF where TPromise : LFPFPAAINHE where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly TPromise AJIJJPAAMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		protected readonly TMainThreadPromise GKKOJKDPAOI;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public TPromise KDBDIJDNOPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x2AD6EF0", Offset = "0x2AD56F0", VA = "0x182AD6EF0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool IEJHCBAICNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x2AD6EA0", Offset = "0x2AD56A0", VA = "0x182AD6EA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6F50", Offset = "0x2AD5750", VA = "0x182AD6F50")]
		protected HBBPCJLDBEE(TPromise AJIJJPAAMFK, TMainThreadPromise OPJOPCAAAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x2AD6E70", Offset = "0x2AD5670", VA = "0x182AD6E70", Slot = "5")]
		public void BDHAHGNBAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xB6B7A0", Offset = "0xB69FA0", VA = "0x180B6B7A0", Slot = "6")]
		public void CHLJJDFPGFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		protected abstract void EHKCBGHKOHL(TPromise AJIJJPAAMFK);

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		protected abstract void ADCKHHBMLJI();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private class IIHMCBDKFHE<T> : HBBPCJLDBEE<global::KGPLAJBADNH<T>, global::LDBFBIJENBI<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7310", Offset = "0x2AD5B10", VA = "0x182AD7310")]
		public IIHMCBDKFHE(global::KGPLAJBADNH<T> AJIJJPAAMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x2AD70B0", Offset = "0x2AD58B0", VA = "0x182AD70B0", Slot = "7")]
		protected override void EHKCBGHKOHL(global::KGPLAJBADNH<T> AJIJJPAAMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x2AD7050", Offset = "0x2AD5850", VA = "0x182AD7050", Slot = "8")]
		protected override void ADCKHHBMLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x2AD72E0", Offset = "0x2AD5AE0", VA = "0x182AD72E0")]
		[CompilerGenerated]
		private void NPKFIFGCFGB(T HMCKBHOBBJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x2AD72B0", Offset = "0x2AD5AB0", VA = "0x182AD72B0")]
		[CompilerGenerated]
		private void LONDKNJMOPI(string CAPFNHGLOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class GEFPNKJHMNL : HBBPCJLDBEE<LFPFPAAINHE, NNILOECJPKH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x4630660", Offset = "0x462EE60", VA = "0x184630660")]
		public GEFPNKJHMNL(LFPFPAAINHE AJIJJPAAMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x4630590", Offset = "0x462ED90", VA = "0x184630590", Slot = "7")]
		protected override void EHKCBGHKOHL(LFPFPAAINHE AJIJJPAAMFK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x4630540", Offset = "0x462ED40", VA = "0x184630540", Slot = "8")]
		protected override void ADCKHHBMLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x740570", Offset = "0x73ED70", VA = "0x180740570")]
		[CompilerGenerated]
		private void NPKFIFGCFGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x1B888A0", Offset = "0x1B870A0", VA = "0x181B888A0")]
		[CompilerGenerated]
		private void LONDKNJMOPI(string CAPFNHGLOFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class FLABEGNDECJ : KDJFHPGAFOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly Action HPPFCEEDPMJ;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool IEJHCBAICNO
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x52F9B0", Offset = "0x52E1B0", VA = "0x18052F9B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6B5950", Offset = "0x6B4150", VA = "0x1806B5950")]
		public FLABEGNDECJ(Action HPPFCEEDPMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x150C170", Offset = "0x150A970", VA = "0x18150C170", Slot = "5")]
		public void BDHAHGNBAKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "6")]
		public void CHLJJDFPGFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private static readonly List<KDJFHPGAFOF> PMDDGOOGKMM;

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x2D81050", Offset = "0x2D7F850", VA = "0x182D81050")]
	public static global::KGPLAJBADNH<T> IPHIJOBFKEO<T>(this global::KGPLAJBADNH<T> AJIJJPAAMFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x462BC60", Offset = "0x462A460", VA = "0x18462BC60")]
	public static LFPFPAAINHE IPHIJOBFKEO(this LFPFPAAINHE AJIJJPAAMFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x462BD70", Offset = "0x462A570", VA = "0x18462BD70")]
	public static void IPHIJOBFKEO(Action HPPFCEEDPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x2D80F90", Offset = "0x2D7F790", VA = "0x182D80F90")]
	private static global::KGPLAJBADNH<T> IDHGHHCEJDB<T>(global::KGPLAJBADNH<T> AJIJJPAAMFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x462BB80", Offset = "0x462A380", VA = "0x18462BB80")]
	private static LFPFPAAINHE IDHGHHCEJDB(LFPFPAAINHE AJIJJPAAMFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x462B990", Offset = "0x462A190", VA = "0x18462B990")]
	private static void EJADCOKHCIL(KDJFHPGAFOF AIKNEELLFMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x462B5C0", Offset = "0x4629DC0", VA = "0x18462B5C0")]
	private static void AKKGDFFHDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x462BE00", Offset = "0x462A600", VA = "0x18462BE00")]
	private static void PDGJDGCKHEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x462B8E0", Offset = "0x462A0E0", VA = "0x18462B8E0")]
	private static void BHCPGJBBNDI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class KECJAFBGOBK
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class FPJFDGCHKHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NNILOECJPKH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public FPJFDGCHKHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x46301F0", Offset = "0x462E9F0", VA = "0x1846301F0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x46301E0", Offset = "0x462E9E0", VA = "0x1846301E0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LNJDGAENIGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public LNJDGAENIGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4636640", Offset = "0x4634E40", VA = "0x184636640")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PKENHFLOEHE : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public NNILOECJPKH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public PKENHFLOEHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x4639BB0", Offset = "0x46383B0", VA = "0x184639BB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x4639890", Offset = "0x4638090", VA = "0x184639890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4639C60", Offset = "0x4638460", VA = "0x184639C60")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x4639B60", Offset = "0x4638360", VA = "0x184639B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class GBBOAIALMMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public NNILOECJPKH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public GBBOAIALMMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class IIPPJJHOFBO : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public NNILOECJPKH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private GBBOAIALMMD <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public IIPPJJHOFBO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x46324B0", Offset = "0x4630CB0", VA = "0x1846324B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4632840", Offset = "0x4631040", VA = "0x184632840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public const string JEGCLBHMCBD = "empty";

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public const string PCHOMJEHPMO = "moderator";

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public const string JPGFJLBOEED = "main_root";

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public const string EIEGAHCCBAK = "late_main_root";

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public const string OLLIFAIKIEK = "LogoutScene";

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private const float BMDGLECKHGH = 0.9f;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static LFPFPAAINHE MCJNAGCMNMJ;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static AsyncOperation KHECLNHLLBC;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static LFPFPAAINHE OJGLFEJHCOI;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static string LMBOIMGPIJB;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static ThreadPriority CFMFCGHGMPK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static bool DFGAELGFPOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4635FD0", Offset = "0x46347D0", VA = "0x184635FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private static bool NCOHIOFIKEC
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4636070", Offset = "0x4634870", VA = "0x184636070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private static bool MPINNBOCKFM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4635B70", Offset = "0x4634370", VA = "0x184635B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> JAHCJBLFAMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4635C60", Offset = "0x4634460", VA = "0x184635C60")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4636230", Offset = "0x4634A30", VA = "0x184636230")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x46360D0", Offset = "0x46348D0", VA = "0x1846360D0")]
	public static LFPFPAAINHE OLFMLOFEJKM(string GOFCKBDFAEC, LoadSceneMode ANDCLPFHFOK = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4635DA0", Offset = "0x46345A0", VA = "0x184635DA0")]
	public static LFPFPAAINHE JKIBEAHMFAI(string GOFCKBDFAEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4635D10", Offset = "0x4634510", VA = "0x184635D10")]
	[IteratorStateMachine(typeof(PKENHFLOEHE))]
	private static IEnumerator<AAPMNJMBGEO> IFOAJLIHKGB(string GOFCKBDFAEC, NNILOECJPKH AGLAICCOPDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4635BD0", Offset = "0x46343D0", VA = "0x184635BD0")]
	[IteratorStateMachine(typeof(IIPPJJHOFBO))]
	private static IEnumerator<AAPMNJMBGEO> FHMHCOEOGJD(string GOFCKBDFAEC, LoadSceneMode ANDCLPFHFOK, NNILOECJPKH AGLAICCOPDN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class OAACNLDILHG
{
	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4637850", Offset = "0x4636050", VA = "0x184637850")]
	public static IDisposable CNIBBNLIBHJ(this BOFBKAOKBGK OJAOPEPLKMN, Action DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x46377D0", Offset = "0x4635FD0", VA = "0x1846377D0")]
	public static IDisposable CNIBBNLIBHJ(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4637E50", Offset = "0x4636650", VA = "0x184637E50")]
	public static IDisposable MGLALAIDCKC(this BOFBKAOKBGK OJAOPEPLKMN, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4637760", Offset = "0x4635F60", VA = "0x184637760")]
	public static IDisposable BKMKPLDHDLJ(this BOFBKAOKBGK OJAOPEPLKMN, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4637EC0", Offset = "0x46366C0", VA = "0x184637EC0")]
	public static IDisposable NBFBHEJOHHM(this BOFBKAOKBGK OJAOPEPLKMN, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4637CE0", Offset = "0x46364E0", VA = "0x184637CE0")]
	public static IDisposable LCOCLOOIGHL(this BOFBKAOKBGK OJAOPEPLKMN, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4637660", Offset = "0x4635E60", VA = "0x184637660")]
	public static IDisposable APFEHKJHJOE(this BOFBKAOKBGK OJAOPEPLKMN, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4637FB0", Offset = "0x46367B0", VA = "0x184637FB0")]
	public static IDisposable PMDPANKHCFJ(this BOFBKAOKBGK OJAOPEPLKMN, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4637BD0", Offset = "0x46363D0", VA = "0x184637BD0")]
	public static IDisposable IHAJKCLLIHC(this BOFBKAOKBGK OJAOPEPLKMN, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4637950", Offset = "0x4636150", VA = "0x184637950")]
	public static IDisposable DHODNJHLBAL(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4637D50", Offset = "0x4636550", VA = "0x184637D50")]
	public static IDisposable LJEKKAOMELG(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4637A50", Offset = "0x4636250", VA = "0x184637A50")]
	public static IDisposable GKBKHDFLNFJ(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x46376D0", Offset = "0x4635ED0", VA = "0x1846376D0")]
	public static IDisposable BJIOINEJDLG(this BOFBKAOKBGK OJAOPEPLKMN, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4637F30", Offset = "0x4636730", VA = "0x184637F30")]
	public static IDisposable NJIFNEDEPNP(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x4637AD0", Offset = "0x46362D0", VA = "0x184637AD0")]
	public static IDisposable GLNMECIENOB(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x46379D0", Offset = "0x46361D0", VA = "0x1846379D0")]
	public static IDisposable EADCMOJCKFC(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4637C50", Offset = "0x4636450", VA = "0x184637C50")]
	public static IDisposable KLMFMIJLNOE(this BOFBKAOKBGK OJAOPEPLKMN, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x46378D0", Offset = "0x46360D0", VA = "0x1846378D0")]
	public static IDisposable DEFKBKACPNA(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4637B50", Offset = "0x4636350", VA = "0x184637B50")]
	public static IDisposable GMCHKFPLPJE(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4637DD0", Offset = "0x46365D0", VA = "0x184637DD0")]
	public static IDisposable LMLMLOABLII(this BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class OGOKDHBJABC
{
	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4638210", Offset = "0x4636A10", VA = "0x184638210")]
	public static IDisposable BHGFDPGMMCF(this MonoBehaviour LFJLAAMAILB, Action DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4638290", Offset = "0x4636A90", VA = "0x184638290")]
	public static IDisposable BHGFDPGMMCF(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4638750", Offset = "0x4636F50", VA = "0x184638750")]
	public static IDisposable GMABKAMPIOF(this MonoBehaviour LFJLAAMAILB, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x46386E0", Offset = "0x4636EE0", VA = "0x1846386E0")]
	public static IDisposable FPAMHDFLJBH(this MonoBehaviour LFJLAAMAILB, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x46383A0", Offset = "0x4636BA0", VA = "0x1846383A0")]
	public static IDisposable BPGBBAANFLN(this MonoBehaviour LFJLAAMAILB, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x4638C30", Offset = "0x4637430", VA = "0x184638C30")]
	public static IDisposable MDFDEBBNFIA(this MonoBehaviour LFJLAAMAILB, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x46388E0", Offset = "0x46370E0", VA = "0x1846388E0")]
	public static IDisposable IHHIOOOJOJF(this MonoBehaviour LFJLAAMAILB, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x4638B90", Offset = "0x4637390", VA = "0x184638B90")]
	public static IDisposable KKEOGNLMKIK(this MonoBehaviour LFJLAAMAILB, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x4638410", Offset = "0x4636C10", VA = "0x184638410")]
	public static IDisposable CBHEMICBBJF(this MonoBehaviour LFJLAAMAILB, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x46389E0", Offset = "0x46371E0", VA = "0x1846389E0")]
	public static IDisposable IOADAKAMACG(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4638950", Offset = "0x4637150", VA = "0x184638950")]
	public static IDisposable IJDGINCAJEE(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4638650", Offset = "0x4636E50", VA = "0x184638650")]
	public static IDisposable FKFBLEDFDOK(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4638180", Offset = "0x4636980", VA = "0x184638180")]
	public static IDisposable AOCKGMEHJAF(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x46387C0", Offset = "0x4636FC0", VA = "0x1846387C0")]
	public static IDisposable HDGAPJPEAKB(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4638310", Offset = "0x4636B10", VA = "0x184638310")]
	public static IDisposable BJEGOBGDIOJ(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x46380E0", Offset = "0x46368E0", VA = "0x1846380E0")]
	public static IDisposable AMGEOJPNBEG(this MonoBehaviour LFJLAAMAILB, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x46385C0", Offset = "0x4636DC0", VA = "0x1846385C0")]
	public static IDisposable DOONHCDIGAD(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4638A70", Offset = "0x4637270", VA = "0x184638A70")]
	public static IDisposable JKKGNNMJJGE(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4638B00", Offset = "0x4637300", VA = "0x184638B00")]
	public static IDisposable KHHIBCGJPAE(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4638040", Offset = "0x4636840", VA = "0x184638040")]
	public static IDisposable AACNODFBDDO(this MonoBehaviour LFJLAAMAILB, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46384A0", Offset = "0x4636CA0", VA = "0x1846384A0")]
	public static IDisposable CDIJJPELNDG(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4638850", Offset = "0x4637050", VA = "0x184638850")]
	public static IDisposable HJCONCKFAJO(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4638530", Offset = "0x4636D30", VA = "0x184638530")]
	public static IDisposable DAPMNOAJDLO(this MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class OMNHFHDALGO
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class PJAFADPDBPF : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public JFFPMPEEBJD.PIDJAKONCNG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private CMJNDJMPPCA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public PJAFADPDBPF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4639780", Offset = "0x4637F80", VA = "0x184639780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4639840", Offset = "0x4638040", VA = "0x184639840", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class ALPLHKBMODD : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public JFFPMPEEBJD.PIDJAKONCNG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private CMJNDJMPPCA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public ALPLHKBMODD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x4629660", Offset = "0x4627E60", VA = "0x184629660", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4629740", Offset = "0x4627F40", VA = "0x184629740", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4638D90", Offset = "0x4637590", VA = "0x184638D90")]
	public static JEOMIDCJMHN BHGFDPGMMCF(Action DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4638CA0", Offset = "0x46374A0", VA = "0x184638CA0")]
	public static JEOMIDCJMHN BHGFDPGMMCF(Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4638F90", Offset = "0x4637790", VA = "0x184638F90")]
	public static JEOMIDCJMHN BHGFDPGMMCF(Behaviour OJAOPEPLKMN, Action DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4638E80", Offset = "0x4637680", VA = "0x184638E80")]
	public static JEOMIDCJMHN BHGFDPGMMCF(Behaviour OJAOPEPLKMN, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x46391B0", Offset = "0x46379B0", VA = "0x1846391B0")]
	public static JEOMIDCJMHN CNIBBNLIBHJ(BOFBKAOKBGK OJAOPEPLKMN, Action DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x46390A0", Offset = "0x46378A0", VA = "0x1846390A0")]
	public static JEOMIDCJMHN CNIBBNLIBHJ(BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x46392C0", Offset = "0x4637AC0", VA = "0x1846392C0")]
	[IteratorStateMachine(typeof(PJAFADPDBPF))]
	private static IEnumerator<AAPMNJMBGEO> JPMDHNFNFAA(JFFPMPEEBJD.PIDJAKONCNG FEEFFCNAHOA, Action DPFEMJKOPCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4639340", Offset = "0x4637B40", VA = "0x184639340")]
	[IteratorStateMachine(typeof(ALPLHKBMODD))]
	private static IEnumerator<AAPMNJMBGEO> JPMDHNFNFAA(JFFPMPEEBJD.PIDJAKONCNG FEEFFCNAHOA, Action<float> DPFEMJKOPCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class JOIOBPBAIEI
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class PCFPDDGCKND : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public JFFPMPEEBJD.PIDJAKONCNG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private HJBGMBLLEIA <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public PCFPDDGCKND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x46395E0", Offset = "0x4637DE0", VA = "0x1846395E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x46396F0", Offset = "0x4637EF0", VA = "0x1846396F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x46334A0", Offset = "0x4631CA0", VA = "0x1846334A0")]
	public static JEOMIDCJMHN BHGFDPGMMCF(float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4633560", Offset = "0x4631D60", VA = "0x184633560")]
	public static JEOMIDCJMHN BHGFDPGMMCF(MonoBehaviour LFJLAAMAILB, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4633620", Offset = "0x4631E20", VA = "0x184633620")]
	public static JEOMIDCJMHN FKKNOEKFNCJ(BOFBKAOKBGK OJAOPEPLKMN, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM, bool HDNDMPKPOIG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x46336E0", Offset = "0x4631EE0", VA = "0x1846336E0")]
	[IteratorStateMachine(typeof(PCFPDDGCKND))]
	private static IEnumerator<AAPMNJMBGEO> JPMDHNFNFAA(float OJIDKEMMHLC, JFFPMPEEBJD.PIDJAKONCNG FEEFFCNAHOA, Action<float> DPFEMJKOPCB, bool HDNDMPKPOIG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EDMOLKOCNPI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DGMCPIHLKJO : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public JFFPMPEEBJD.PIDJAKONCNG queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public DGMCPIHLKJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x462EF10", Offset = "0x462D710", VA = "0x18462EF10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x462EFC0", Offset = "0x462D7C0", VA = "0x18462EFC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x462F330", Offset = "0x462DB30", VA = "0x18462F330")]
	[IteratorStateMachine(typeof(DGMCPIHLKJO))]
	private static IEnumerator<AAPMNJMBGEO> NJAFMEBCDAL(JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM, Func<bool> ODJIFODEFBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x462F1D0", Offset = "0x462D9D0", VA = "0x18462F1D0")]
	public static JEOMIDCJMHN BMKOEJMNONI(this MonoBehaviour LFJLAAMAILB, Func<bool> ODJIFODEFBD, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM = JFFPMPEEBJD.PIDJAKONCNG.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class DFDIPNJGCIE
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class CBLFIICFJEG : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public JFFPMPEEBJD.PIDJAKONCNG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public CBLFIICFJEG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4629C00", Offset = "0x4628400", VA = "0x184629C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x4629CC0", Offset = "0x46284C0", VA = "0x184629CC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class IFHCNMEPPPH : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public JFFPMPEEBJD.PIDJAKONCNG queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private AAPMNJMBGEO <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public IFHCNMEPPPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x46316A0", Offset = "0x462FEA0", VA = "0x1846316A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4631770", Offset = "0x462FF70", VA = "0x184631770", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x462E4C0", Offset = "0x462CCC0", VA = "0x18462E4C0")]
	[IteratorStateMachine(typeof(CBLFIICFJEG))]
	private static IEnumerator<AAPMNJMBGEO> DIMFIGMFJLA(float DFNJJNIDPFH, JFFPMPEEBJD.PIDJAKONCNG FEEFFCNAHOA, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x462E550", Offset = "0x462CD50", VA = "0x18462E550")]
	[IteratorStateMachine(typeof(IFHCNMEPPPH))]
	private static IEnumerator<AAPMNJMBGEO> DJBEOGGJNBA(float DFNJJNIDPFH, JFFPMPEEBJD.PIDJAKONCNG FEEFFCNAHOA, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x462E990", Offset = "0x462D190", VA = "0x18462E990")]
	public static IDisposable KPACHOLAMNE(this MonoBehaviour LFJLAAMAILB, float DFNJJNIDPFH, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x462EBF0", Offset = "0x462D3F0", VA = "0x18462EBF0")]
	public static JEOMIDCJMHN MOOHJODNGDD(this MonoBehaviour LFJLAAMAILB, float DFNJJNIDPFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x462E830", Offset = "0x462D030", VA = "0x18462E830")]
	public static JEOMIDCJMHN KPACHOLAMNE(this MonoBehaviour LFJLAAMAILB, float DFNJJNIDPFH, JFFPMPEEBJD.PIDJAKONCNG FEEFFCNAHOA, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x462E810", Offset = "0x462D010", VA = "0x18462E810")]
	public static JEOMIDCJMHN JBGDIEHCJDB(this MonoBehaviour LFJLAAMAILB, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x462E390", Offset = "0x462CB90", VA = "0x18462E390")]
	public static JEOMIDCJMHN ABGBEAFPPOB(this MonoBehaviour LFJLAAMAILB, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x462E4B0", Offset = "0x462CCB0", VA = "0x18462E4B0")]
	public static JEOMIDCJMHN BCBFEJDPLCF(this MonoBehaviour LFJLAAMAILB, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x462E820", Offset = "0x462D020", VA = "0x18462E820")]
	public static JEOMIDCJMHN KIABACJFFHB(this MonoBehaviour LFJLAAMAILB, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x462E6F0", Offset = "0x462CEF0", VA = "0x18462E6F0")]
	public static JEOMIDCJMHN GODPJGNGCEB(this MonoBehaviour LFJLAAMAILB, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x462E700", Offset = "0x462CF00", VA = "0x18462E700")]
	private static JEOMIDCJMHN HMNAIPBMEGG(MonoBehaviour LFJLAAMAILB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x462E3A0", Offset = "0x462CBA0", VA = "0x18462E3A0")]
	public static JEOMIDCJMHN AGCINGMFFEL(this MonoBehaviour LFJLAAMAILB, float DABADBHNBNF, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x462EE00", Offset = "0x462D600", VA = "0x18462EE00")]
	public static JEOMIDCJMHN PFHKCOHJBCI(this MonoBehaviour LFJLAAMAILB, float DABADBHNBNF, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x462ECF0", Offset = "0x462D4F0", VA = "0x18462ECF0")]
	public static JEOMIDCJMHN NDBDOFBNPFA(this MonoBehaviour LFJLAAMAILB, float DABADBHNBNF, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x462EAE0", Offset = "0x462D2E0", VA = "0x18462EAE0")]
	public static JEOMIDCJMHN LIOJDCGJHFF(this MonoBehaviour LFJLAAMAILB, float DABADBHNBNF, Action GECDBHMLNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x462E5E0", Offset = "0x462CDE0", VA = "0x18462E5E0")]
	public static JEOMIDCJMHN EKOJGBHEAKJ(this MonoBehaviour LFJLAAMAILB, float DABADBHNBNF, Action GECDBHMLNPB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class NOFILMNOPEA : CPINBHEGAEL
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class FMCNCAFGNJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public NOFILMNOPEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public FMCNCAFGNJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x46301B0", Offset = "0x462E9B0", VA = "0x1846301B0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FIILDFNDFBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public NOFILMNOPEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public FIILDFNDFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x46301B0", Offset = "0x462E9B0", VA = "0x1846301B0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly float JFOEEELFJHO;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x462F050", Offset = "0x462D850", VA = "0x18462F050")]
	public NOFILMNOPEA(Behaviour OJAOPEPLKMN, float JFOEEELFJHO, [Optional] Action FJABEFBPODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x46373F0", Offset = "0x4635BF0", VA = "0x1846373F0", Slot = "9")]
	protected override bool JOJDLKJLBMG(Action HPPFCEEDPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4637310", Offset = "0x4635B10", VA = "0x184637310", Slot = "10")]
	protected override bool BKDEHECFBLI(Action HPPFCEEDPMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface GALPNGJNDAG
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	bool ODDLBHOALLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action LNOPOADABKJ;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JDGEHDLLCJD(bool MIEPOKNFBKA = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool JDGEHDLLCJD(Action HPPFCEEDPMJ, bool MIEPOKNFBKA = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class CPINBHEGAEL : GALPNGJNDAG
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class EIONHJKDCAF : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public EIONHJKDCAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x462F3B0", Offset = "0x462DBB0", VA = "0x18462F3B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x462F450", Offset = "0x462DC50", VA = "0x18462F450", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly Behaviour OJAOPEPLKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly Action FJABEFBPODL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private OGFAMIOFHHH IKKALGABCEB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool ODDLBHOALLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xB78EB0", Offset = "0xB776B0", VA = "0x180B78EB0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action LNOPOADABKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x462C480", Offset = "0x462AC80", VA = "0x18462C480", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x462C110", Offset = "0x462A910", VA = "0x18462C110", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x462C580", Offset = "0x462AD80", VA = "0x18462C580")]
	protected CPINBHEGAEL(Behaviour OJAOPEPLKMN, [Optional] Action FJABEFBPODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x462C420", Offset = "0x462AC20", VA = "0x18462C420", Slot = "7")]
	public bool JDGEHDLLCJD(bool MIEPOKNFBKA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x462C3D0", Offset = "0x462ABD0", VA = "0x18462C3D0", Slot = "8")]
	public bool JDGEHDLLCJD(Action HPPFCEEDPMJ, bool MIEPOKNFBKA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool JOJDLKJLBMG(Action HPPFCEEDPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool BKDEHECFBLI(Action HPPFCEEDPMJ);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x462C080", Offset = "0x462A880", VA = "0x18462C080")]
	protected void AGELNGBHJKJ(Action HPPFCEEDPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x462C1F0", Offset = "0x462A9F0", VA = "0x18462C1F0")]
	protected LFPFPAAINHE HKOGONDGNEG(float GMBHNIJPDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x462C0A0", Offset = "0x462A8A0", VA = "0x18462C0A0")]
	private void CMDNBOBDDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x462C520", Offset = "0x462AD20", VA = "0x18462C520")]
	[IteratorStateMachine(typeof(EIONHJKDCAF))]
	private static IEnumerator<AAPMNJMBGEO> NOADLNJNNBA(float GMBHNIJPDBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x462C1B0", Offset = "0x462A9B0", VA = "0x18462C1B0")]
	[CompilerGenerated]
	private void GBMACEELOHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class IAHPNLPPEAO : CPINBHEGAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly float LMMFKHPFMIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly int AMLPICELFKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float OFMJKDDLBCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly float[] CBLCHPDPMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private int HKNEOMCMCDM;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EHMBKCMMNDP GGALNJNKLNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x50A9E0", Offset = "0x5091E0", VA = "0x18050A9E0")]
		[CompilerGenerated]
		private get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5C33B0", Offset = "0x5C1BB0", VA = "0x1805C33B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4631310", Offset = "0x462FB10", VA = "0x184631310")]
	public IAHPNLPPEAO(Behaviour OJAOPEPLKMN, float NOJJJBDAKJL, int AMLPICELFKI, [Optional] Action FJABEFBPODL, float OFMJKDDLBCI = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x52F8A0", Offset = "0x52E0A0", VA = "0x18052F8A0", Slot = "9")]
	protected override bool JOJDLKJLBMG(Action HPPFCEEDPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4631060", Offset = "0x462F860", VA = "0x184631060", Slot = "10")]
	protected override bool BKDEHECFBLI(Action HPPFCEEDPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4631280", Offset = "0x462FA80", VA = "0x184631280")]
	private void PEEOGLCMNAK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class DKNBKLFOMFJ : CPINBHEGAEL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly float JFOEEELFJHO;

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x462F050", Offset = "0x462D850", VA = "0x18462F050")]
	public DKNBKLFOMFJ(Behaviour OJAOPEPLKMN, float JFOEEELFJHO, [Optional] Action FJABEFBPODL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x52F8A0", Offset = "0x52E0A0", VA = "0x18052F8A0", Slot = "9")]
	protected override bool JOJDLKJLBMG(Action HPPFCEEDPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x462F010", Offset = "0x462D810", VA = "0x18462F010", Slot = "10")]
	protected override bool BKDEHECFBLI(Action HPPFCEEDPMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class IFJIBNONNDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class NOFJHKANBCJ : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public NOFJHKANBCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x46374D0", Offset = "0x4635CD0", VA = "0x1846374D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x46375D0", Offset = "0x4635DD0", VA = "0x1846375D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JEOMIDCJMHN FMHGOIMINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private BOFBKAOKBGK OJAOPEPLKMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Action DPFEMJKOPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Action<float> OOFMIPDEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private float FGEBAAEKJPH;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4632130", Offset = "0x4630930", VA = "0x184632130")]
	public IFJIBNONNDK(BOFBKAOKBGK OJAOPEPLKMN, Action DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x46322F0", Offset = "0x4630AF0", VA = "0x1846322F0")]
	public IFJIBNONNDK(BOFBKAOKBGK OJAOPEPLKMN, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4631FB0", Offset = "0x46307B0", VA = "0x184631FB0")]
	public IFJIBNONNDK(BOFBKAOKBGK OJAOPEPLKMN, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x46317C0", Offset = "0x462FFC0", VA = "0x1846317C0")]
	private void BHGFDPGMMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4631C60", Offset = "0x4630460", VA = "0x184631C60")]
	private void KCFAPEILDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4631DF0", Offset = "0x46305F0", VA = "0x184631DF0")]
	private void NJGBODLGADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4631B30", Offset = "0x4630330", VA = "0x184631B30")]
	private void JLBCLEHELOE(string CAPFNHGLOFN, Action MEMEBKLJDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4631F40", Offset = "0x4630740", VA = "0x184631F40")]
	[IteratorStateMachine(typeof(NOFJHKANBCJ))]
	private IEnumerator<AAPMNJMBGEO> PDEJHGEILEP(Action MEMEBKLJDEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4631A50", Offset = "0x4630250", VA = "0x184631A50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4631950", Offset = "0x4630150", VA = "0x184631950")]
	[CompilerGenerated]
	private void CGFAGFBMAMN(string BCENOHLAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x46319D0", Offset = "0x46301D0", VA = "0x1846319D0")]
	[CompilerGenerated]
	private void DKPBHJHDPPL(string BCENOHLAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4631AB0", Offset = "0x46302B0", VA = "0x184631AB0")]
	[CompilerGenerated]
	private void HADEMKIGOCN(string BCENOHLAIEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class ELBHDPFLNPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class CHBECHFNNJA : IEnumerator<AAPMNJMBGEO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private AAPMNJMBGEO <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private AAPMNJMBGEO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
		[DebuggerHidden]
		public CHBECHFNNJA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x462BF30", Offset = "0x462A730", VA = "0x18462BF30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x462C030", Offset = "0x462A830", VA = "0x18462C030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private JEOMIDCJMHN FMHGOIMINLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private MonoBehaviour LFJLAAMAILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private Action DPFEMJKOPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Action<float> OOFMIPDEGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private float FGEBAAEKJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private bool HDNDMPKPOIG;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x462FFF0", Offset = "0x462E7F0", VA = "0x18462FFF0")]
	public ELBHDPFLNPI(MonoBehaviour LFJLAAMAILB, Action DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x462FC90", Offset = "0x462E490", VA = "0x18462FC90")]
	public ELBHDPFLNPI(MonoBehaviour LFJLAAMAILB, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x462FE50", Offset = "0x462E650", VA = "0x18462FE50")]
	public ELBHDPFLNPI(MonoBehaviour LFJLAAMAILB, float OJIDKEMMHLC, Action<float> DPFEMJKOPCB, JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM, bool HDNDMPKPOIG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x462F4A0", Offset = "0x462DCA0", VA = "0x18462F4A0")]
	private void BHGFDPGMMCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x462F840", Offset = "0x462E040", VA = "0x18462F840")]
	private void KCFAPEILDDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x462FAD0", Offset = "0x462E2D0", VA = "0x18462FAD0")]
	private void NJGBODLGADN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x462F710", Offset = "0x462DF10", VA = "0x18462F710")]
	private void JLBCLEHELOE(string CAPFNHGLOFN, Action MEMEBKLJDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x462FC20", Offset = "0x462E420", VA = "0x18462FC20")]
	[IteratorStateMachine(typeof(CHBECHFNNJA))]
	private IEnumerator<AAPMNJMBGEO> PDEJHGEILEP(Action MEMEBKLJDEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x462F6B0", Offset = "0x462DEB0", VA = "0x18462F6B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x462F630", Offset = "0x462DE30", VA = "0x18462F630")]
	[CompilerGenerated]
	private void CFJDFGOGPEF(string BCENOHLAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x462F9D0", Offset = "0x462E1D0", VA = "0x18462F9D0")]
	[CompilerGenerated]
	private void KCPMMFIAJAC(string BCENOHLAIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x462FA50", Offset = "0x462E250", VA = "0x18462FA50")]
	[CompilerGenerated]
	private void KFKGGENICIH(string BCENOHLAIEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface KJIHPPMDCCF
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	int GECCAHDKELF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class LGOMIDGAPBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public static readonly LGOMIDGAPBD NLDMJHCNCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Action DDNEGOGHMAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private bool CEBFLEDNJML;

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6B5950", Offset = "0x6B4150", VA = "0x1806B5950")]
	public LGOMIDGAPBD(Action DDNEGOGHMAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x4636540", Offset = "0x4634D40", VA = "0x184636540", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ILIJJHIJLFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	T FPOHGGJHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable LIGGCDEAGAF(Action<T> FONIHGDLIEE);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IDisposable LIGGCDEAGAF(UnityEngine.Object OJAOPEPLKMN, Action<T> FONIHGDLIEE);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FFBCIHCHFKP<T> : global::ILIJJHIJLFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000031")]
	new T FPOHGGJHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class PCIIBAIKNBB<T> : global::FFBCIHCHFKP<T>, global::ILIJJHIJLFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[CompilerGenerated]
	private sealed class GGOHLABFOPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public global::PCIIBAIKNBB<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::MKCPCJMPKBK<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2720C80", Offset = "0x271F480", VA = "0x182720C80")]
		public GGOHLABFOPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x3579DD0", Offset = "0x35785D0", VA = "0x183579DD0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private static GameObject PIKAOILDBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private readonly List<global::MKCPCJMPKBK<UnityEngine.Object, Action<T>>> NBNAABACNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private T MJHOCJOPLHF;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private static UnityEngine.Object MHCIBJFNNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x35823A0", Offset = "0x3580BA0", VA = "0x1835823A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public T FPOHGGJHLDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7DDC00", Offset = "0x7DC400", VA = "0x1807DDC00", Slot = "6")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x3582AF0", Offset = "0x35812F0", VA = "0x183582AF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3582300", Offset = "0x3580B00", VA = "0x183582300")]
	private static bool HMGGAAJKMLC(T LNIJHEMDGEF, T LANKPNEAHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x3583230", Offset = "0x3581A30", VA = "0x183583230")]
	public PCIIBAIKNBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x3583260", Offset = "0x3581A60", VA = "0x183583260")]
	public PCIIBAIKNBB(T FLDNHPHLFKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x35822A0", Offset = "0x3580AA0", VA = "0x1835822A0")]
	public void AAJHDNHLHBJ(T EACOKIMHCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x35827C0", Offset = "0x3580FC0", VA = "0x1835827C0", Slot = "7")]
	public IDisposable LIGGCDEAGAF(Action<T> FONIHGDLIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3582830", Offset = "0x3581030", VA = "0x183582830", Slot = "8")]
	public IDisposable LIGGCDEAGAF(UnityEngine.Object OJAOPEPLKMN, Action<T> FONIHGDLIEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3582BD0", Offset = "0x35813D0", VA = "0x183582BD0")]
	private void MBCGOFPHKOE()
	{
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class Scheduler : InjectedSingletonMonoBehaviour<GMFIOIJLBAL, Scheduler>, GMFIOIJLBAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class AGGGNFKLFPG : KJIHPPMDCCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public KDPBPFHHJJM OCIACKFPAOO;

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			public int GECCAHDKELF
			{
				[Cpp2IlInjected.Token(Token = "0x6000179")]
				[Cpp2IlInjected.Address(RVA = "0x507010", Offset = "0x505810", VA = "0x180507010", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600017A")]
				[Cpp2IlInjected.Address(RVA = "0x52F8B0", Offset = "0x52E0B0", VA = "0x18052F8B0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x4629430", Offset = "0x4627C30", VA = "0x184629430")]
			public static AAPMNJMBGEO HLFIGLJAMCD(IEnumerator<AAPMNJMBGEO> FLKAKOGKABG, IDAKACFJNOB CDJCNKAFMIO)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x4629350", Offset = "0x4627B50", VA = "0x184629350")]
			public AAPMNJMBGEO HLFIGLJAMCD(IDAKACFJNOB[] DHGIDDDBHCB, IEnumerator<AAPMNJMBGEO>[] JIMKKIAOFAC, AAPMNJMBGEO[] MOPLGBKCPAA)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x4629320", Offset = "0x4627B20", VA = "0x184629320")]
			public void LJNANLIMIHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0x4629250", Offset = "0x4627A50", VA = "0x184629250")]
			public void AAGMEAFPHHB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x4629590", Offset = "0x4627D90", VA = "0x184629590")]
			public void PEAHPDCDGIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x4629320", Offset = "0x4627B20", VA = "0x184629320")]
			public void CHLJJDFPGFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
			public AGGGNFKLFPG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class KDPBPFHHJJM
		{
			[Cpp2IlInjected.Token(Token = "0x2000048")]
			public struct AKPEBEGPMHE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public AGGGNFKLFPG JFBFDHGFFHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public BOFBKAOKBGK HKPEJLFLPHJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public IDAKACFJNOB EDPNMDDPFLP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public IEnumerator<AAPMNJMBGEO> NAIJBGDEOGA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public AAPMNJMBGEO KCJMDAEHJMH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public CGOOGGOFOCN NAECOJHEADD;
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			public struct JFNECHLBFNH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				public JFFPMPEEBJD.PIDJAKONCNG HDJAINNOAMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public List<AKPEBEGPMHE> KFPFGEFGHIN;
			}

			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private sealed class NNEKBIHJIFH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public KDPBPFHHJJM <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public BOFBKAOKBGK context;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public AGGGNFKLFPG routine;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public CGOOGGOFOCN coroutineState;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public IDAKACFJNOB promise;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public AAPMNJMBGEO currentSchedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public IEnumerator<AAPMNJMBGEO> coroutine;

				[Cpp2IlInjected.Token(Token = "0x6000198")]
				[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
				public NNEKBIHJIFH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000199")]
				[Cpp2IlInjected.Address(RVA = "0x4636C60", Offset = "0x4635460", VA = "0x184636C60")]
				internal void <InsertJobbedSchedulerCoroutine>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class PEODIBGPGDP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				public AGGGNFKLFPG schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				public KDPBPFHHJJM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019A")]
				[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
				public PEODIBGPGDP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0x4639740", Offset = "0x4637F40", VA = "0x184639740")]
				internal void <Cancel>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class HJOLEOCAIGD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				public AGGGNFKLFPG schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				public KDPBPFHHJJM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019C")]
				[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
				public HJOLEOCAIGD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0x4630A30", Offset = "0x462F230", VA = "0x184630A30")]
				internal void <Pause>b__0()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004D")]
			[CompilerGenerated]
			private sealed class NPJCEEPPLFL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				public AGGGNFKLFPG schedule;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				public KDPBPFHHJJM <>4__this;

				[Cpp2IlInjected.Token(Token = "0x600019E")]
				[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
				public NPJCEEPPLFL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600019F")]
				[Cpp2IlInjected.Address(RVA = "0x4637620", Offset = "0x4635E20", VA = "0x184637620")]
				internal void <Unpause>b__0()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			private bool[] MHOAPGJEIMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			private NativeArray<CGOOGGOFOCN> NOCPLNMAPLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private NativeArray<float> COMGIINANNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private NativeArray<int> OPICJPLGNJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			private NativeArray<int> GEIIFJDLBPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			private NativeArray<int> NAFNDPJOHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private NativeArray<int> BFHJPAJOJAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private NativeArray<int> LBJPLDGMJFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private AGGGNFKLFPG[] LEFBFDBNHLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			private IDAKACFJNOB[] DHGIDDDBHCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			private BOFBKAOKBGK[] IONIPPGBKKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private IEnumerator<AAPMNJMBGEO>[] MNGANDDIBAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private AAPMNJMBGEO[] JDKMJCPEPPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			private int APJLMLIDNLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			private int IBEBPLKPLGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private readonly int MCOLBCKGGFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private float JLFEFEOPIKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			private JBKABKNLEEP KENLDGMFFAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			private JobHandle NJLJMNHOGNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			private List<AGGGNFKLFPG> DKOKEHPFAGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private bool JDHGMPMKLJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			private List<Action> AGLLGPNIEJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			private List<Action> CFMDHJOALDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			private bool ICCHDJCGODG;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			public JFNECHLBFNH[] NAILANJKFIP
			{
				[Cpp2IlInjected.Token(Token = "0x6000183")]
				[Cpp2IlInjected.Address(RVA = "0x5C24D0", Offset = "0x5C0CD0", VA = "0x1805C24D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			public int COABFEKOLFM
			{
				[Cpp2IlInjected.Token(Token = "0x6000184")]
				[Cpp2IlInjected.Address(RVA = "0x946D30", Offset = "0x945530", VA = "0x180946D30")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x46345C0", Offset = "0x4632DC0", VA = "0x1846345C0")]
			private static int DPGFHCEDNJL(JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x4635620", Offset = "0x4633E20", VA = "0x184635620")]
			public KDPBPFHHJJM(JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x4635490", Offset = "0x4633C90", VA = "0x184635490")]
			private void PNFCJFOIHCK(ref int JJMEANLPDIJ, int DNAMHCCJKDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0x4635190", Offset = "0x4633990", VA = "0x184635190")]
			public void JKGCIGPDKCM(BOFBKAOKBGK OJAOPEPLKMN, AAPMNJMBGEO CKEJPHCGFAF, IEnumerator<AAPMNJMBGEO> FLKAKOGKABG, IDAKACFJNOB CDJCNKAFMIO, [Optional] AGGGNFKLFPG EKMNCLFJOAL, CGOOGGOFOCN OLNNKMFPBOA = CGOOGGOFOCN.Running)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x46349E0", Offset = "0x46331E0", VA = "0x1846349E0")]
			public void GAABJENKJHD(IEnumerable<AKPEBEGPMHE> LHKALCOAMKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0x4634C50", Offset = "0x4633450", VA = "0x184634C50")]
			private AKPEBEGPMHE HGBFCOFKJAP(int KLMDJCJICBN)
			{
				return default(AKPEBEGPMHE);
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x46345F0", Offset = "0x4632DF0", VA = "0x1846345F0")]
			private void FABGNLOHFBI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x29640D0", Offset = "0x29628D0", VA = "0x1829640D0")]
			private static void CKBLJGLHDCG<T>(int KLMDJCJICBN, T[] JHEPDJBBAPC, int GDBDJPILDNP, [Optional] T MECONNPEGDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0x29640B0", Offset = "0x29628B0", VA = "0x1829640B0")]
			private static void CKBLJGLHDCG<T>(int KLMDJCJICBN, NativeArray<T> JHEPDJBBAPC, int GDBDJPILDNP, [Optional] T MECONNPEGDH) where T : struct
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x4634320", Offset = "0x4632B20", VA = "0x184634320")]
			private void DFKFMOOEFKJ(IEnumerable<AKPEBEGPMHE> LHKALCOAMKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x46350D0", Offset = "0x46338D0", VA = "0x1846350D0")]
			private void HHDAFMEJAOE(AKPEBEGPMHE JMCHODKCIKC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0x4633FA0", Offset = "0x46327A0", VA = "0x184633FA0")]
			private KMJDKCHGCMA CBJAOIFJLEH(int FEIFBLIMOBK)
			{
				return default(KMJDKCHGCMA);
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x4633910", Offset = "0x4632110", VA = "0x184633910")]
			public void BACCKJABPIC(float MCPCEPNBPPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x4634960", Offset = "0x4633160", VA = "0x184634960")]
			private void FACELBJGBJN(Action LNIJHEMDGEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0x4634BD0", Offset = "0x46333D0", VA = "0x184634BD0")]
			private void GDGPMBPHAJC(Action LNIJHEMDGEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x4633B00", Offset = "0x4632300", VA = "0x184633B00")]
			public void BAIMIGNIMOI(float MCPCEPNBPPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x46353B0", Offset = "0x4633BB0", VA = "0x1846353B0")]
			public void MIJAAKNMDAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0x4634260", Offset = "0x4632A60", VA = "0x184634260")]
			public void CHLJJDFPGFN(AGGGNFKLFPG OKFPACOAKPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x4633850", Offset = "0x4632050", VA = "0x184633850")]
			public void ACLJIOCHFOL(AGGGNFKLFPG OKFPACOAKPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x46352F0", Offset = "0x4633AF0", VA = "0x1846352F0")]
			public void KHPHNBKAGEH(AGGGNFKLFPG OKFPACOAKPE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[BurstCompile]
		public struct JBKABKNLEEP : IJob
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			[ReadOnly]
			public float MIALDAAIBMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			[ReadOnly]
			public int PPEHBGOGMBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			private NativeArray<int> CMEBJKEKFBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			private NativeArray<int> KHPLJDHOBJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			private NativeArray<int> KIEPLMIGGAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			[ReadOnly]
			public NativeArray<CGOOGGOFOCN> OEDPOBIGJCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			[ReadOnly]
			public NativeArray<float> AILKIAHGOFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			[WriteOnly]
			public NativeArray<int> NAFNDPJOHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			[WriteOnly]
			public NativeArray<int> OPICJPLGNJA;

			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0x4632BB0", Offset = "0x46313B0", VA = "0x184632BB0")]
			public static JBKABKNLEEP OALNFBLCHMK(int MEOOCIFMECE, float MCPCEPNBPPE, NativeArray<CGOOGGOFOCN> NOEBFNJAOGC, NativeArray<float> ICIGGMPGBPB, NativeArray<int> DDFACOHIOFD, NativeArray<int> LAIDKNHJNLH, NativeArray<int> IONELMONFME, NativeArray<int> KHPLJDHOBJD, NativeArray<int> KIEPLMIGGAP)
			{
				return default(JBKABKNLEEP);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x4632AA0", Offset = "0x46312A0", VA = "0x184632AA0", Slot = "4")]
			public void Execute()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x4632A60", Offset = "0x4631260", VA = "0x184632A60")]
			private bool CHMEHEKFOOC(int INFKIDFCOKN)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x4632B80", Offset = "0x4631380", VA = "0x184632B80")]
			private void FHHFLFFFGPO(NativeArray<int> HKGEGLHHOPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x46329F0", Offset = "0x46311F0", VA = "0x1846329F0")]
			private int BNDOHLNCICH(int ENIPILMIGCP, int HKEAGPJPNNE)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x4632920", Offset = "0x4631120", VA = "0x184632920")]
			private void ABEAOPOCAMO(NativeArray<int> HKGEGLHHOPE, int MIHCKDECKBA, int LECCKCEMEIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x4632C80", Offset = "0x4631480", VA = "0x184632C80")]
			private void OCLEMLMGILP(NativeArray<int> HKGEGLHHOPE, int IJLPOCJHLBK, int NAIACLLIJOL, int LIIIBMGPELN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private sealed class JMOAEIOBAAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			private readonly IDAKACFJNOB CDJCNKAFMIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			private readonly Behaviour OJAOPEPLKMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			private readonly bool MIGCJAKNGGL;

			[Cpp2IlInjected.Token(Token = "0x1700003A")]
			public IEnumerator<AAPMNJMBGEO> NAIJBGDEOGA
			{
				[Cpp2IlInjected.Token(Token = "0x60001A7")]
				[Cpp2IlInjected.Address(RVA = "0x50B450", Offset = "0x509C50", VA = "0x18050B450")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001A8")]
				[Cpp2IlInjected.Address(RVA = "0x52EE90", Offset = "0x52D690", VA = "0x18052EE90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003B")]
			public AAPMNJMBGEO KCJMDAEHJMH
			{
				[Cpp2IlInjected.Token(Token = "0x60001A9")]
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AA")]
				[Cpp2IlInjected.Address(RVA = "0x50E430", Offset = "0x50CC30", VA = "0x18050E430")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public bool NOBEPEDCHCC
			{
				[Cpp2IlInjected.Token(Token = "0x60001AB")]
				[Cpp2IlInjected.Address(RVA = "0x46331E0", Offset = "0x46319E0", VA = "0x1846331E0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool ODEEPKDODEO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AC")]
				[Cpp2IlInjected.Address(RVA = "0x946E20", Offset = "0x945620", VA = "0x180946E20")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x60001AD")]
				[Cpp2IlInjected.Address(RVA = "0x947450", Offset = "0x945C50", VA = "0x180947450")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003E")]
			public string PNDBGHBJEKO
			{
				[Cpp2IlInjected.Token(Token = "0x60001AE")]
				[Cpp2IlInjected.Address(RVA = "0x50B470", Offset = "0x509C70", VA = "0x18050B470")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001AF")]
				[Cpp2IlInjected.Address(RVA = "0x52F9E0", Offset = "0x52E1E0", VA = "0x18052F9E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003F")]
			public float KDNNJKOJAKF
			{
				[Cpp2IlInjected.Token(Token = "0x60001B0")]
				[Cpp2IlInjected.Address(RVA = "0x9FB1D0", Offset = "0x9F99D0", VA = "0x1809FB1D0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x60001B1")]
				[Cpp2IlInjected.Address(RVA = "0xEF1460", Offset = "0xEEFC60", VA = "0x180EF1460")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x4633300", Offset = "0x4631B00", VA = "0x184633300")]
			public JMOAEIOBAAC(IEnumerator<AAPMNJMBGEO> FLKAKOGKABG, Behaviour OJAOPEPLKMN, IDAKACFJNOB CDJCNKAFMIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x4632F40", Offset = "0x4631740", VA = "0x184632F40")]
			public AAPMNJMBGEO HLFIGLJAMCD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x4633150", Offset = "0x4631950", VA = "0x184633150")]
			public bool KBBNJNOFMMF()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x4632EB0", Offset = "0x46316B0", VA = "0x184632EB0")]
			public void CHLJJDFPGFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(RVA = "0x4633270", Offset = "0x4631A70", VA = "0x184633270", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(RVA = "0x24BFCE0", Offset = "0x24BE4E0", VA = "0x1824BFCE0")]
			[CompilerGenerated]
			private void ANHINOEJJKD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private sealed class IDAKACFJNOB : CFJBFILDGHC, JEOMIDCJMHN, OGFAMIOFHHH, LFPFPAAINHE, IEnumerator, AAPMNJMBGEO, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private JFFPMPEEBJD.PIDJAKONCNG GBKILBGKJGD;

			[Cpp2IlInjected.Token(Token = "0x17000040")]
			private JFFPMPEEBJD.PIDJAKONCNG EJJMCANOBNE
			{
				[Cpp2IlInjected.Token(Token = "0x60001B8")]
				[Cpp2IlInjected.Address(RVA = "0x553AF0", Offset = "0x5522F0", VA = "0x180553AF0", Slot = "23")]
				get
				{
					return default(JFFPMPEEBJD.PIDJAKONCNG);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public JFFPMPEEBJD.PIDJAKONCNG OCIACKFPAOO
			{
				[Cpp2IlInjected.Token(Token = "0x60001B9")]
				[Cpp2IlInjected.Address(RVA = "0x553AF0", Offset = "0x5522F0", VA = "0x180553AF0")]
				get
				{
					return default(JFFPMPEEBJD.PIDJAKONCNG);
				}
				[Cpp2IlInjected.Token(Token = "0x60001BA")]
				[Cpp2IlInjected.Address(RVA = "0x6FFF30", Offset = "0x6FE730", VA = "0x1806FFF30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			private float HHBMFFBBCHN
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(RVA = "0x6E1BF0", Offset = "0x6E03F0", VA = "0x1806E1BF0", Slot = "25")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0x4631610", Offset = "0x462FE10", VA = "0x184631610", Slot = "24")]
			private bool AGLJOOHMFGP()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x4631630", Offset = "0x462FE30", VA = "0x184631630", Slot = "26")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x4631640", Offset = "0x462FE40", VA = "0x184631640")]
			public IDAKACFJNOB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000051")]
		private enum KMJDKCHGCMA : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			Remove,
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			Reinsert,
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			NextUpdateChanged
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		private sealed class CDAOMCDNIJB : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000053")]
			public enum PLGBOLCGIBL
			{
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				Immediate,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				Future
			}

			[Cpp2IlInjected.Token(Token = "0x2000054")]
			public struct MELBJMKMKIE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				public JFFPMPEEBJD.PIDJAKONCNG HDJAINNOAMG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				public PLGBOLCGIBL BCMPPGBHKBC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				public List<JMOAEIOBAAC> ENLLHJJNAIO;
			}

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			private static readonly PLGBOLCGIBL[] OKJNANHIBCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private readonly JFFPMPEEBJD.PIDJAKONCNG KGADMPJKABM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private bool COOFIBLHLMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			private readonly JMOAEIOBAAC[] CIFFHGBPOLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private readonly List<JMOAEIOBAAC> LLIANNMJMCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			private readonly Stack<int> KLANAFDBFOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private readonly List<JMOAEIOBAAC> MLANICJDMNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private readonly Stack<int> JJFJDIJFPBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private bool ICCHDJCGODG;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public MELBJMKMKIE[,] FMKFCCJLKJA
			{
				[Cpp2IlInjected.Token(Token = "0x60001BF")]
				[Cpp2IlInjected.Address(RVA = "0x50A7D0", Offset = "0x508FD0", VA = "0x18050A7D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public int COABFEKOLFM
			{
				[Cpp2IlInjected.Token(Token = "0x60001C0")]
				[Cpp2IlInjected.Address(RVA = "0x462AF20", Offset = "0x4629720", VA = "0x18462AF20")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x462B170", Offset = "0x4629970", VA = "0x18462B170")]
			public CDAOMCDNIJB(JFFPMPEEBJD.PIDJAKONCNG FEEFFCNAHOA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x4629F90", Offset = "0x4628790", VA = "0x184629F90")]
			public void BCONLKFHBPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x462AB20", Offset = "0x4629320", VA = "0x18462AB20")]
			public void JAEAAPKABKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x462A550", Offset = "0x4628D50", VA = "0x18462A550")]
			private void FFBGIBMECME(IReadOnlyList<JMOAEIOBAAC> FHDNIIHOPMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x462A430", Offset = "0x4628C30", VA = "0x18462A430")]
			public void EHAAHHAHOKN(JMOAEIOBAAC FLKAKOGKABG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4629D10", Offset = "0x4628510", VA = "0x184629D10")]
			public void AFCNMPLBKEM(IList<JMOAEIOBAAC> JIMKKIAOFAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x462AB30", Offset = "0x4629330", VA = "0x18462AB30")]
			public void KJDKDILNAHD(IList<JMOAEIOBAAC> JIMKKIAOFAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x462A850", Offset = "0x4629050", VA = "0x18462A850")]
			private void IFEHJJDEPMF(JMOAEIOBAAC FLKAKOGKABG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x462ADB0", Offset = "0x46295B0", VA = "0x18462ADB0")]
			private void LFCKOJEPGDP(IList<JMOAEIOBAAC> JIMKKIAOFAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x4629FA0", Offset = "0x46287A0", VA = "0x184629FA0")]
			private KMJDKCHGCMA BHLABOKEPEK(JMOAEIOBAAC FLKAKOGKABG)
			{
				return default(KMJDKCHGCMA);
			}

			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x462A7A0", Offset = "0x4628FA0", VA = "0x18462A7A0")]
			public void GMABKAMPIOF(float MCPCEPNBPPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x462A230", Offset = "0x4628A30", VA = "0x18462A230")]
			public void EAJLJOOIKBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x462A940", Offset = "0x4629140", VA = "0x18462A940")]
			private void ILJBHDIFADJ(List<JMOAEIOBAAC> JIMKKIAOFAC, Stack<int> JNBJLFAKKGK, bool HMMNFPLCJBA, float PFCPONIEPPM = -1f)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x462A0F0", Offset = "0x46288F0", VA = "0x18462A0F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x462A680", Offset = "0x4628E80", VA = "0x18462A680")]
			private void FODLMABDMJC(List<JMOAEIOBAAC> JIMKKIAOFAC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
		[Flags]
		public enum CGOOGGOFOCN : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			Inactive = 0,
			[Cpp2IlInjected.Token(Token = "0x400010F")]
			Running = 1,
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			Cancelled = 2,
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			Paused = 4
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class KAAHNCMOBJD : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private object <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public Scheduler <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000045")]
			object IEnumerator<object>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D7")]
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001D9")]
				[Cpp2IlInjected.Address(RVA = "0x50B050", Offset = "0x509850", VA = "0x18050B050", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x52E960", Offset = "0x52D160", VA = "0x18052E960")]
			[DebuggerHidden]
			public KAAHNCMOBJD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x507B30", Offset = "0x506330", VA = "0x180507B30", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x4633780", Offset = "0x4631F80", VA = "0x184633780", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x4633800", Offset = "0x4632000", VA = "0x184633800", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private const CGOOGGOFOCN ILGNDHGNECG = CGOOGGOFOCN.Cancelled | CGOOGGOFOCN.Paused;

		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private static readonly JFFPMPEEBJD.PIDJAKONCNG[] AINKPODMCIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private CDAOMCDNIJB[] OGCBJPELBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private KDPBPFHHJJM[] IKNCCPOFFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private Coroutine FGEIDFPGCLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private WaitForEndOfFrame JCCPFMHEOHE;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public JFFPMPEEBJD.PIDJAKONCNG DDJGHCBICGI
		{
			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x50B440", Offset = "0x509C40", VA = "0x18050B440")]
			[CompilerGenerated]
			get
			{
				return default(JFFPMPEEBJD.PIDJAKONCNG);
			}
			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x5C71C0", Offset = "0x5C59C0", VA = "0x1805C71C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool JOPGBFCDGLC
		{
			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x942840", Offset = "0x941040", VA = "0x180942840", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x717950", Offset = "0x716150", VA = "0x180717950")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public int COABFEKOLFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x463B5E0", Offset = "0x4639DE0", VA = "0x18463B5E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x463A4B0", Offset = "0x4638CB0", VA = "0x18463A4B0")]
		public static JEOMIDCJMHN GetImmediatePromise()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4639CB0", Offset = "0x46384B0", VA = "0x184639CB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x463A630", Offset = "0x4638E30", VA = "0x18463A630", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x463A560", Offset = "0x4638D60", VA = "0x18463A560")]
		private CDAOMCDNIJB JJEGEECMLLC(JFFPMPEEBJD.PIDJAKONCNG BJNLFFPNEBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1016E00", Offset = "0x1015600", VA = "0x181016E00")]
		private KDPBPFHHJJM OJIDDOCIMNK(JFFPMPEEBJD.PIDJAKONCNG BJNLFFPNEBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x463AAF0", Offset = "0x46392F0", VA = "0x18463AAF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x463AAB0", Offset = "0x46392B0", VA = "0x18463AAB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x463B3B0", Offset = "0x4639BB0", VA = "0x18463B3B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x463A5A0", Offset = "0x4638DA0", VA = "0x18463A5A0")]
		private void KCMOGHDBIMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x463A550", Offset = "0x4638D50", VA = "0x18463A550")]
		private void IIFCLMAFLBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x463A4A0", Offset = "0x4638CA0", VA = "0x18463A4A0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x463A5B0", Offset = "0x4638DB0", VA = "0x18463A5B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x463A150", Offset = "0x4638950", VA = "0x18463A150")]
		private void CNFLKHJLMPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x463A5C0", Offset = "0x4638DC0", VA = "0x18463A5C0")]
		[IteratorStateMachine(typeof(KAAHNCMOBJD))]
		private IEnumerator ODPIPOCGNCA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x463AED0", Offset = "0x46396D0", VA = "0x18463AED0", Slot = "7")]
		public JEOMIDCJMHN Run(IEnumerator<AAPMNJMBGEO> EDNDNGDMENI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x463ACA0", Offset = "0x46394A0", VA = "0x18463ACA0", Slot = "8")]
		public JEOMIDCJMHN Run(Behaviour OJAOPEPLKMN, IEnumerator<AAPMNJMBGEO> EDNDNGDMENI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x463AB70", Offset = "0x4639370", VA = "0x18463AB70", Slot = "9")]
		public JEOMIDCJMHN RunJobbed(BOFBKAOKBGK OJAOPEPLKMN, IEnumerator<AAPMNJMBGEO> EDNDNGDMENI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x463A320", Offset = "0x4638B20", VA = "0x18463A320", Slot = "10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x463AEE0", Offset = "0x46396E0", VA = "0x18463AEE0")]
		public void UpdateQueue(JFFPMPEEBJD.PIDJAKONCNG IMCHEKHBGIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x463A160", Offset = "0x4638960", VA = "0x18463A160")]
		private void COIPPIDIIBI(CDAOMCDNIJB DLIHOBFPPFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x463A380", Offset = "0x4638B80", VA = "0x18463A380")]
		private void FIKBBOCDJBI(KDPBPFHHJJM DLIHOBFPPFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x463B570", Offset = "0x4639D70", VA = "0x18463B570")]
		public Scheduler()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal static class JAKOKDJNJGG
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4632890", Offset = "0x4631090", VA = "0x184632890")]
	[PDLJDMPPJFF]
	private static void PJKFEDAIHFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public sealed class BCIIHHJBPHK : EHMBKCMMNDP
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public float OBEGEBOIBBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x46297E0", Offset = "0x4627FE0", VA = "0x1846297E0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public float IAOFHGFOHBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x46297B0", Offset = "0x4627FB0", VA = "0x1846297B0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public float KJOIGKDFCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x46297A0", Offset = "0x4627FA0", VA = "0x1846297A0", Slot = "7")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int EDFGCAPGKPK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x4629790", Offset = "0x4627F90", VA = "0x184629790", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public double HFEDDANBICM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x46297C0", Offset = "0x4627FC0", VA = "0x1846297C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public BCIIHHJBPHK()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class IAGGKLCNKGJ
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private static byte[] LHMKKNGADDJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static int MGOKGGCOJHO;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static int FHPCKBOKGPL;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static BigInteger KMAGGJIIKDL;

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
	public IAGGKLCNKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4630DA0", Offset = "0x462F5A0", VA = "0x184630DA0")]
	private static string POIGIBFCCMB(byte[] LANKPNEAHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4630A70", Offset = "0x462F270", VA = "0x184630A70")]
	public static string MHKKELLNKIL(byte[] OCICGABDCEM, bool MDIDJMNJINP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200005C")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000119")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x507000", Offset = "0x505800", VA = "0x180507000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
