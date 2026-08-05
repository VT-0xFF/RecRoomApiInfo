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
public class NHNCGDEOBBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority JNANNCJDEFN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x52FCBE0", Offset = "0x52FBFE0", VA = "0x1852FCBE0")]
	public NHNCGDEOBBP(ThreadPriority GICMAOGPEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x52FCBD0", Offset = "0x52FBFD0", VA = "0x1852FCBD0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> BCBCPMHFPOC(List<PlayerLoopSystem> FCGMOLCPBPL, int PMPEMEKOHHL);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct INJLMFPLHJF
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct ABJGGFBAOCF
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static PENMMECJMBL NFMEBHEOFMA;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x52E7930", Offset = "0x52E6D30", VA = "0x1852E7930")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct BDFDONNNFPP
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static PENMMECJMBL AEBIPCKHMOH;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x52E9100", Offset = "0x52E8500", VA = "0x1852E9100")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct PMMJBNHFFPG
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static PENMMECJMBL JDEEPOAOJEM;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x52FE680", Offset = "0x52FDA80", VA = "0x1852FE680")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct ODFGCPIMIHP
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static PENMMECJMBL FCHEHHOHLOE;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static PENMMECJMBL IMMFHKMIIFJ;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static PENMMECJMBL CDMOPGKIFKC;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static PENMMECJMBL ELHPKHJANJM;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x52FD120", Offset = "0x52FC520", VA = "0x1852FD120")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct IAPMDCLLONJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static PENMMECJMBL LEDIPOJJKJN;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x52F45C0", Offset = "0x52F39C0", VA = "0x1852F45C0")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct GMCJJPNIPGH
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static PENMMECJMBL FCHEHHOHLOE;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static PENMMECJMBL IMMFHKMIIFJ;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static PENMMECJMBL CDMOPGKIFKC;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static PENMMECJMBL ELHPKHJANJM;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x52F2D70", Offset = "0x52F2170", VA = "0x1852F2D70")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct MHOCEMAEFJM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static PENMMECJMBL ABIKFHCCIHK;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x52FADB0", Offset = "0x52FA1B0", VA = "0x1852FADB0")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct OFJCKGBDNAB
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static PENMMECJMBL BIAEMNDKHJK;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x52FD3B0", Offset = "0x52FC7B0", VA = "0x1852FD3B0")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct GDCDBMAHEJJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static PENMMECJMBL DCEIJFJAOBJ;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x52F1860", Offset = "0x52F0C60", VA = "0x1852F1860")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct JPCHJKOLDAP
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static PENMMECJMBL NJPDJBOGGCJ;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x52F99C0", Offset = "0x52F8DC0", VA = "0x1852F99C0")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct BINJOJMLEFN
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static PENMMECJMBL EGDDDKJNLPF;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x52E92E0", Offset = "0x52E86E0", VA = "0x1852E92E0")]
				public static PlayerLoopSystem BKNLFJIAJNP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct FKDFCEBJAPG
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class BLFNDDDAHMB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public MJIOHGFMBDB.MJPBOAKNBFD key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
					public BLFNDDDAHMB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x52E95D0", Offset = "0x52E89D0", VA = "0x1852E95D0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable EAGMOMPKNME;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x52F1610", Offset = "0x52F0A10", VA = "0x1852F1610")]
				public static PlayerLoopSystem LBJMNBKHHDO(MJIOHGFMBDB.MJPBOAKNBFD FOJIGKKHICE)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct AMKKNEBNNAA
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class DEGOJJNLNFK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public MJIOHGFMBDB.MJPBOAKNBFD key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
					public DEGOJJNLNFK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x52EDB00", Offset = "0x52ECF00", VA = "0x1852EDB00")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x52E8660", Offset = "0x52E7A60", VA = "0x1852E8660")]
				public static PlayerLoopSystem LBJMNBKHHDO(MJIOHGFMBDB.MJPBOAKNBFD FOJIGKKHICE)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class GIAIHLNJKJG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public GIAIHLNJKJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x52F1BD0", Offset = "0x52F0FD0", VA = "0x1852F1BD0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool PCLJCBNGHNK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool HFINIBIOBGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x52ECF30", Offset = "0x52EC330", VA = "0x1852ECF30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x52ECBC0", Offset = "0x52EBFC0", VA = "0x1852ECBC0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x52EA320", Offset = "0x52E9720", VA = "0x1852EA320")]
		private static void BHACMICHJBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x52EC2F0", Offset = "0x52EB6F0", VA = "0x1852EC2F0")]
		private static void HBFDCFDEEID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x52ECC00", Offset = "0x52EC000", VA = "0x1852ECC00")]
		private static void LKFBPEIIELH(string ALNJKNLANLD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x52EA0F0", Offset = "0x52E94F0", VA = "0x1852EA0F0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x52ECF70", Offset = "0x52EC370", VA = "0x1852ECF70")]
		private static void OCKMODMPBFL(MJIOHGFMBDB.MJPBOAKNBFD FOJIGKKHICE, ref PlayerLoopSystem NNJGKOIKNDP, Type DIOHCNOFAFH, Type NFDBJBGIDPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x52E9D00", Offset = "0x52E9100", VA = "0x1852E9D00")]
		private static void AAFCACMCBBH(ref PlayerLoopSystem NNJGKOIKNDP, Type DIOHCNOFAFH, Type NFDBJBGIDPE, BCBCPMHFPOC KGOKBKBPJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x52EC1C0", Offset = "0x52EB5C0", VA = "0x1852EC1C0")]
		private static void GEEELPEOEIL(ref PlayerLoopSystem NNJGKOIKNDP, Type DIOHCNOFAFH, Type NFDBJBGIDPE, PlayerLoopSystem? LJFPBLMCNPB, PlayerLoopSystem? CFNDEJBALGN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MJIOHGFMBDB
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum MJPBOAKNBFD
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
	public class EPFIGHHJODM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly MJPBOAKNBFD HAGKBAIPIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly KKGDMKAKBOG LOHBIILODOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long CFDEGGGMMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long ANGHPGOALEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long MGAIKEBOLME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int CPIDJKEKNMJ;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x52F1180", Offset = "0x52F0580", VA = "0x1852F1180")]
		public EPFIGHHJODM(MJPBOAKNBFD IJJOPELKGKL, int FNHMJEEJEJE = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x52F1110", Offset = "0x52F0510", VA = "0x1852F1110")]
		public void MPFNDMALMIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x52F0EB0", Offset = "0x52F02B0", VA = "0x1852F0EB0")]
		public void AJFMBDPHJEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x52F0F10", Offset = "0x52F0310", VA = "0x1852F0F10")]
		public void CNHKFKBDBJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static MJPBOAKNBFD[] PECENBBMDAJ;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static EPFIGHHJODM[] NHMJKELIKAM;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x52FB1B0", Offset = "0x52FA5B0", VA = "0x1852FB1B0")]
	public static EPFIGHHJODM KALIMPOCIBI(MJPBOAKNBFD FOJIGKKHICE, int FNHMJEEJEJE = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x52FB120", Offset = "0x52FA520", VA = "0x1852FB120")]
	public static EPFIGHHJODM FKFMIFMFPFD(MJPBOAKNBFD FOJIGKKHICE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x52FB070", Offset = "0x52FA470", VA = "0x1852FB070")]
	public static void AIGEMBCKNGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class KKGDMKAKBOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int GCIBGGDAMAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> KKNKEHDBHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double CMBNEELHPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double HKHDBDONGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double AEFBEPDLOAD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JEMIMJCCNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x52F9E70", Offset = "0x52F9270", VA = "0x1852F9E70", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x52FA000", Offset = "0x52F9400", VA = "0x1852FA000")]
	public KKGDMKAKBOG(int DKEHBFBCIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x52F9ED0", Offset = "0x52F92D0", VA = "0x1852F9ED0", Slot = "4")]
	public void KGNEOJADMDE(double NGJFGGENEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x52F9E00", Offset = "0x52F9200", VA = "0x1852F9E00", Slot = "5")]
	public void DKMEPNBBIOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class CFLNPPFNBMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long LKJCGNNPEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double KOPNBJBNLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double IPEODOFJHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double DLHHIEFFCKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double CJDOLOJMEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double CMBNEELHPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double HKHDBDONGCO;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long IGGNICCPKKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double AAMDLDKMNMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x3683710", Offset = "0x3682B10", VA = "0x183683710", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double ENFBCNJPLIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA9EE20", Offset = "0xA9E220", VA = "0x180A9EE20", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double DEAJOICIKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x32BBA00", Offset = "0x32BAE00", VA = "0x1832BBA00")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JEMIMJCCNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x3683640", Offset = "0x3682A40", VA = "0x183683640", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x52E98D0", Offset = "0x52E8CD0", VA = "0x1852E98D0", Slot = "7")]
	public void KGNEOJADMDE(double NGJFGGENEKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x52E9890", Offset = "0x52E8C90", VA = "0x1852E9890", Slot = "8")]
	public void DKMEPNBBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x52E9A00", Offset = "0x52E8E00", VA = "0x1852E9A00")]
	public CFLNPPFNBMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BBCNMOKMOJB
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private interface MIAINLOFIJM
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool NCLNHAEFNII
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBGGPPJCKMP();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private abstract class KOFCDPIPLAE<TPromise, TMainThreadPromise> : MIAINLOFIJM where TPromise : JLFOFKFALKJ where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly TPromise DKHBMICPOPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected readonly TMainThreadPromise IBPFODMBFLA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise EJCMGMOKALA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x296B530", Offset = "0x296A930", VA = "0x18296B530")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool NCLNHAEFNII
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x296B590", Offset = "0x296A990", VA = "0x18296B590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x296B610", Offset = "0x296AA10", VA = "0x18296B610")]
		protected KOFCDPIPLAE(TPromise DKHBMICPOPD, TMainThreadPromise ENPBNGHCLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x296B5E0", Offset = "0x296A9E0", VA = "0x18296B5E0", Slot = "5")]
		public void OBGGPPJCKMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void CEOKHBEDNFJ(TPromise DKHBMICPOPD);
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private class AMKGIODFCHE<T> : KOFCDPIPLAE<global::JENPMPFICOP<T>, global::AHANDFLOFLD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x30FDFC0", Offset = "0x30FD3C0", VA = "0x1830FDFC0")]
		public AMKGIODFCHE(global::JENPMPFICOP<T> DKHBMICPOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x30FDD80", Offset = "0x30FD180", VA = "0x1830FDD80", Slot = "6")]
		protected override void CEOKHBEDNFJ(global::JENPMPFICOP<T> DKHBMICPOPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x30FDF90", Offset = "0x30FD390", VA = "0x1830FDF90")]
		[CompilerGenerated]
		private void IGPKKCNHKDH(T MHKNFNJAIIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x110EEE0", Offset = "0x110E2E0", VA = "0x18110EEE0")]
		[CompilerGenerated]
		private void EFPALKFCIHE(string CIMKHIELLCI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class ENICHJBBCIO : MIAINLOFIJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly Action LECDCDLGAEL;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NCLNHAEFNII
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
		public ENICHJBBCIO(Action LECDCDLGAEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x100B810", Offset = "0x100AC10", VA = "0x18100B810", Slot = "5")]
		public void OBGGPPJCKMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<MIAINLOFIJM> HJBNBMIOAME;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x2A183F0", Offset = "0x2A177F0", VA = "0x182A183F0")]
	public static global::JENPMPFICOP<T> LHINDPBDIFF<T>(this global::JENPMPFICOP<T> DKHBMICPOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x52E8D60", Offset = "0x52E8160", VA = "0x1852E8D60")]
	public static void LHINDPBDIFF(Action LECDCDLGAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2A18460", Offset = "0x2A17860", VA = "0x182A18460")]
	private static global::JENPMPFICOP<T> MCBFKBOAGIA<T>(global::JENPMPFICOP<T> DKHBMICPOPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x52E8DF0", Offset = "0x52E81F0", VA = "0x1852E8DF0")]
	private static void NAIAHEFPMBI(MIAINLOFIJM IMGDIJPOIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x52E8A70", Offset = "0x52E7E70", VA = "0x1852E8A70")]
	private static void KKGFOJIPBKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x52E8970", Offset = "0x52E7D70", VA = "0x1852E8970")]
	private static void BBIAHPEENDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x52E88A0", Offset = "0x52E7CA0", VA = "0x1852E88A0")]
	private static void AJMKMKPOJKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class IFMMDFHFAKH
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct KILMKIBLNNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TaskCompletionSource<Scene> CMLBHCGDDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly string JAOGIFGAJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly LoadSceneMode DHIHHBLIILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool FPOOHKFBODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly IKIBJCADMMP LNACOMDLNOJ;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x52F9DA0", Offset = "0x52F91A0", VA = "0x1852F9DA0")]
		public KILMKIBLNNN(TaskCompletionSource<Scene> KICLMEDDHKN, string JAOGIFGAJOA, LoadSceneMode DHIHHBLIILJ, bool FPOOHKFBODH, IKIBJCADMMP LNACOMDLNOJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct JIEDGJJCIHC : IAsyncStateMachine
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
		public IKIBJCADMMP stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::DGKJHGKIMMO<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x52F7A70", Offset = "0x52F6E70", VA = "0x1852F7A70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x52F80E0", Offset = "0x52F74E0", VA = "0x1852F80E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct DKOIGFHIGBA : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x52F05F0", Offset = "0x52EF9F0", VA = "0x1852F05F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct FIKACEBLDMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private KILMKIBLNNN <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x52F1280", Offset = "0x52F0680", VA = "0x1852F1280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x680320", Offset = "0x67F720", VA = "0x180680320", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class BPDGKLHCKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public global::AHANDFLOFLD<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public BPDGKLHCKME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x52E9830", Offset = "0x52E8C30", VA = "0x1852E9830")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct DDKCBOPMFGL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public IKIBJCADMMP stackTimer;

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
		private BPDGKLHCKME <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IKIBJCADMMP <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IKIBJCADMMP <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x52ED130", Offset = "0x52EC530", VA = "0x1852ED130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x52EDAB0", Offset = "0x52ECEB0", VA = "0x1852EDAB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct PDGEDKDOCIC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IKIBJCADMMP stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private IKIBJCADMMP <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private IKIBJCADMMP <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x52FDDF0", Offset = "0x52FD1F0", VA = "0x1852FDDF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x52FE630", Offset = "0x52FDA30", VA = "0x1852FE630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LGIJIGFFGPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LGIJIGFFGPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x52FA1F0", Offset = "0x52F95F0", VA = "0x1852FA1F0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class ACDAJGEFFII : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public HADFCENGJKO onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public ACDAJGEFFII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x52E7E70", Offset = "0x52E7270", VA = "0x1852E7E70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x52E7B10", Offset = "0x52E6F10", VA = "0x1852E7B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x52E7F00", Offset = "0x52E7300", VA = "0x1852E7F00")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x52E7E30", Offset = "0x52E7230", VA = "0x1852E7E30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NKDDDEJLPFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::AHANDFLOFLD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public NKDDDEJLPFE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class IGNDANIBMKA : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public global::AHANDFLOFLD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private NKDDDEJLPFE <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public IGNDANIBMKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x52F7460", Offset = "0x52F6860", VA = "0x1852F7460", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x52F78B0", Offset = "0x52F6CB0", VA = "0x1852F78B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static JLFOFKFALKJ ODJPFFOPPCK;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation GGABNMPEPMA;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static JLFOFKFALKJ EAFILONPOEN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string HHGMDLGHPKF;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority JAPBCFJEJCF;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task NKIIIKAKEJP;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Queue<KILMKIBLNNN> BALLMHIIAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Task FLBMACEAHGF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool HCEPDPPAMBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x52F6E60", Offset = "0x52F6260", VA = "0x1852F6E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool AGCEKCLENEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x52F7220", Offset = "0x52F6620", VA = "0x1852F7220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool GPIAOIKIBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x52F6C60", Offset = "0x52F6060", VA = "0x1852F6C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> ODOHNHPKPIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x52F63B0", Offset = "0x52F57B0", VA = "0x1852F63B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x52F6970", Offset = "0x52F5D70", VA = "0x1852F6970")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x52F6700", Offset = "0x52F5B00", VA = "0x1852F6700")]
	[BPHOCBKBMCO(JFHBHDNAPPN.EnteredEditModeNextFrame, 0)]
	private static void JKLOPGJACOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x52F6A70", Offset = "0x52F5E70", VA = "0x1852F6A70")]
	[AsyncStateMachine(typeof(JIEDGJJCIHC))]
	public static Task<Scene> MCFHPCLDFPC(string JAOGIFGAJOA, LoadSceneMode DHIHHBLIILJ = LoadSceneMode.Single, bool FPOOHKFBODH = false, [Optional] IKIBJCADMMP MGDBJBJNJPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x52F72D0", Offset = "0x52F66D0", VA = "0x1852F72D0")]
	[AsyncStateMachine(typeof(DKOIGFHIGBA))]
	private static Task PMPKNKKEBKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x52F6610", Offset = "0x52F5A10", VA = "0x1852F6610")]
	[AsyncStateMachine(typeof(FIKACEBLDMM))]
	private static Task ICPNAGPFMEB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x52F64B0", Offset = "0x52F58B0", VA = "0x1852F64B0")]
	[AsyncStateMachine(typeof(DDKCBOPMFGL))]
	private static Task<Scene> GOHFODNKKNG(string JAOGIFGAJOA, LoadSceneMode DHIHHBLIILJ, bool FPOOHKFBODH, IKIBJCADMMP LNACOMDLNOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x52F6D20", Offset = "0x52F6120", VA = "0x1852F6D20")]
	[AsyncStateMachine(typeof(PDGEDKDOCIC))]
	private static Task<Scene> NBAMMKAINDI(IKIBJCADMMP LNACOMDLNOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x52F67D0", Offset = "0x52F5BD0", VA = "0x1852F67D0")]
	public static global::JENPMPFICOP<Scene> KLCCMCMJIAK(string JAOGIFGAJOA, LoadSceneMode DHIHHBLIILJ = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x52F60D0", Offset = "0x52F54D0", VA = "0x1852F60D0")]
	public static JLFOFKFALKJ AIMLLIPAPHC(string JAOGIFGAJOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x52F6BD0", Offset = "0x52F5FD0", VA = "0x1852F6BD0")]
	[IteratorStateMachine(typeof(ACDAJGEFFII))]
	private static IEnumerator<NCBIOOCDIOA> MJBJGNGDDDG(string JAOGIFGAJOA, HADFCENGJKO IMJHDMGEKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x52F7020", Offset = "0x52F6420", VA = "0x1852F7020")]
	[IteratorStateMachine(typeof(IGNDANIBMKA))]
	private static IEnumerator<NCBIOOCDIOA> OBFJPBNLLNF(string JAOGIFGAJOA, LoadSceneMode DHIHHBLIILJ, global::AHANDFLOFLD<Scene> IMJHDMGEKNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x52F70C0", Offset = "0x52F64C0", VA = "0x1852F70C0")]
	public static bool OOADJFPEFMJ(out string ALCHJFOECAN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class NJFINKFCCPN
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x52FCDD0", Offset = "0x52FC1D0", VA = "0x1852FCDD0")]
	public static IDisposable MCCIHGIGGFB(this BODFKLNNGKK GKMHGIGLKCO, float CBENHIMNKJF, Action<float> BLADCNLMNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x52FCCD0", Offset = "0x52FC0D0", VA = "0x1852FCCD0")]
	public static IDisposable HPPIOGAMMEP(this BODFKLNNGKK GKMHGIGLKCO, Action<float> BLADCNLMNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x52FCD50", Offset = "0x52FC150", VA = "0x1852FCD50")]
	public static IDisposable LHLCFEGAFNL(this BODFKLNNGKK GKMHGIGLKCO, Action<float> BLADCNLMNHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class NFJBEMCIBHB
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x52FBD40", Offset = "0x52FB140", VA = "0x1852FBD40")]
	public static IDisposable CAFKGMJFCIG(this MonoBehaviour PJKDAPHKFLG, Action BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x52FBCC0", Offset = "0x52FB0C0", VA = "0x1852FBCC0")]
	public static IDisposable CAFKGMJFCIG(this MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x52FBF60", Offset = "0x52FB360", VA = "0x1852FBF60")]
	public static IDisposable FHBKGIAODCG(this MonoBehaviour PJKDAPHKFLG, Action BLADCNLMNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x52FBDC0", Offset = "0x52FB1C0", VA = "0x1852FBDC0")]
	public static IDisposable DIIDILKFGEG(this MonoBehaviour PJKDAPHKFLG, Action BLADCNLMNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x52FC220", Offset = "0x52FB620", VA = "0x1852FC220")]
	public static IDisposable ILJIPJDOPCJ(this MonoBehaviour PJKDAPHKFLG, Action BLADCNLMNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x52FBC40", Offset = "0x52FB040", VA = "0x1852FBC40")]
	public static IDisposable BMJGGLPFECJ(this MonoBehaviour PJKDAPHKFLG, Action BLADCNLMNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x52FB9F0", Offset = "0x52FADF0", VA = "0x1852FB9F0")]
	public static IDisposable AALILPHEMPC(this MonoBehaviour PJKDAPHKFLG, Action BLADCNLMNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x52FBA70", Offset = "0x52FAE70", VA = "0x1852FBA70")]
	public static IDisposable ABONDPPLGPE(this MonoBehaviour PJKDAPHKFLG, float CBENHIMNKJF, Action<float> BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x52FC0F0", Offset = "0x52FB4F0", VA = "0x1852FC0F0")]
	public static IDisposable IAJNMIBHLJF(this MonoBehaviour PJKDAPHKFLG, float CBENHIMNKJF, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x52FBED0", Offset = "0x52FB2D0", VA = "0x1852FBED0")]
	public static IDisposable FGAOAGNGBPK(this MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x52FC060", Offset = "0x52FB460", VA = "0x1852FC060")]
	public static IDisposable GHFHDIIFGLN(this MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x52FBBB0", Offset = "0x52FAFB0", VA = "0x1852FBBB0")]
	public static IDisposable BFGGAKJHOGP(this MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x52FBFD0", Offset = "0x52FB3D0", VA = "0x1852FBFD0")]
	public static IDisposable FKBGFMGHHLJ(this MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x52FBE40", Offset = "0x52FB240", VA = "0x1852FBE40")]
	public static IDisposable ELJGCNLJEKD(this MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x52FC330", Offset = "0x52FB730", VA = "0x1852FC330")]
	public static IDisposable NKDEEMMBOAB(this MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x52FC2A0", Offset = "0x52FB6A0", VA = "0x1852FC2A0")]
	public static IDisposable LPGCEFFGNLL(this MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x52FBB10", Offset = "0x52FAF10", VA = "0x1852FBB10")]
	public static IDisposable ACCCMHEBMIL(this MonoBehaviour PJKDAPHKFLG, float CBENHIMNKJF, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x52FC190", Offset = "0x52FB590", VA = "0x1852FC190")]
	public static IDisposable IHNGAAIBKDK(this MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class EJLEJMNEJLP
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class EEHLNMMFCNE : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AGOCJKKDJDJ.IBDEPOFHPGH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private BKGJNNCGHCO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public EEHLNMMFCNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x52F0930", Offset = "0x52EFD30", VA = "0x1852F0930", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x52F09F0", Offset = "0x52EFDF0", VA = "0x1852F09F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class IFMJNIMPMLB : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public AGOCJKKDJDJ.IBDEPOFHPGH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private BKGJNNCGHCO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public IFMJNIMPMLB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x52F5FA0", Offset = "0x52F53A0", VA = "0x1852F5FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x52F6090", Offset = "0x52F5490", VA = "0x1852F6090", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x52F0B40", Offset = "0x52EFF40", VA = "0x1852F0B40")]
	public static OFJDMAJBJNN CAFKGMJFCIG(Action BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x52F0C60", Offset = "0x52F0060", VA = "0x1852F0C60")]
	public static OFJDMAJBJNN CAFKGMJFCIG(Behaviour GKMHGIGLKCO, Action BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x52F0A30", Offset = "0x52EFE30", VA = "0x1852F0A30")]
	public static OFJDMAJBJNN CAFKGMJFCIG(Behaviour GKMHGIGLKCO, Action<float> BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x52F0D20", Offset = "0x52F0120", VA = "0x1852F0D20")]
	[IteratorStateMachine(typeof(EEHLNMMFCNE))]
	private static IEnumerator<NCBIOOCDIOA> OPLHDAFLABG(AGOCJKKDJDJ.IBDEPOFHPGH LGFABECCLDM, Action BLADCNLMNHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x52F0DA0", Offset = "0x52F01A0", VA = "0x1852F0DA0")]
	[IteratorStateMachine(typeof(IFMJNIMPMLB))]
	private static IEnumerator<NCBIOOCDIOA> OPLHDAFLABG(AGOCJKKDJDJ.IBDEPOFHPGH LGFABECCLDM, Action<float> BLADCNLMNHE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CHHNIBFBDGI
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class JFFGNOGJIHF : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public NINALIAJMPM schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public AGOCJKKDJDJ.IBDEPOFHPGH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private CEENEHBKILI <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public JFFGNOGJIHF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x52F78F0", Offset = "0x52F6CF0", VA = "0x1852F78F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x52F7A30", Offset = "0x52F6E30", VA = "0x1852F7A30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x52E9B40", Offset = "0x52E8F40", VA = "0x1852E9B40")]
	public static OFJDMAJBJNN CAFKGMJFCIG(MonoBehaviour PJKDAPHKFLG, float CBENHIMNKJF, Action<float> BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM, bool DONBHDHNEGK = true, [Optional] HBCNMLGDFMK PLKLDFDIELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x52E9A30", Offset = "0x52E8E30", VA = "0x1852E9A30")]
	public static OFJDMAJBJNN BMADNPPAJGN(BODFKLNNGKK GKMHGIGLKCO, float CBENHIMNKJF, Action<float> BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM, bool DONBHDHNEGK = true, [Optional] HBCNMLGDFMK PLKLDFDIELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x52E9C50", Offset = "0x52E9050", VA = "0x1852E9C50")]
	[IteratorStateMachine(typeof(JFFGNOGJIHF))]
	private static IEnumerator<NCBIOOCDIOA> OPLHDAFLABG(NINALIAJMPM NIPEPNCJGAI, float CBENHIMNKJF, AGOCJKKDJDJ.IBDEPOFHPGH LGFABECCLDM, Action<float> BLADCNLMNHE, bool DONBHDHNEGK = true, [Optional] HBCNMLGDFMK PLKLDFDIELA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GDCKOPGGLEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class NHIDPBOHJPI : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public AGOCJKKDJDJ.IBDEPOFHPGH queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public NHIDPBOHJPI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x52FCAE0", Offset = "0x52FBEE0", VA = "0x1852FCAE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x52FCB90", Offset = "0x52FBF90", VA = "0x1852FCB90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x52F1B50", Offset = "0x52F0F50", VA = "0x1852F1B50")]
	[IteratorStateMachine(typeof(NHIDPBOHJPI))]
	private static IEnumerator<NCBIOOCDIOA> MPPFBMACPCF(AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM, Func<bool> FJOJFHIJGLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x52F1A40", Offset = "0x52F0E40", VA = "0x1852F1A40")]
	public static OFJDMAJBJNN HFNADIIGBFK(this MonoBehaviour PJKDAPHKFLG, Func<bool> FJOJFHIJGLJ, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM = AGOCJKKDJDJ.IBDEPOFHPGH.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class NHEGLADGEHC
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class LCPJPMGFNNP : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public AGOCJKKDJDJ.IBDEPOFHPGH queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public LCPJPMGFNNP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x52FA0F0", Offset = "0x52F94F0", VA = "0x1852FA0F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x52FA1B0", Offset = "0x52F95B0", VA = "0x1852FA1B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x52FCA50", Offset = "0x52FBE50", VA = "0x1852FCA50")]
	[IteratorStateMachine(typeof(LCPJPMGFNNP))]
	private static IEnumerator<NCBIOOCDIOA> NLHBANJGDDL(float PJBNNMAFOBD, AGOCJKKDJDJ.IBDEPOFHPGH LGFABECCLDM, Action JLCMJEMLFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x52FC7C0", Offset = "0x52FBBC0", VA = "0x1852FC7C0")]
	public static OFJDMAJBJNN GOGDDBELHDE(this MonoBehaviour PJKDAPHKFLG, float PJBNNMAFOBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x52FC670", Offset = "0x52FBA70", VA = "0x1852FC670")]
	public static OFJDMAJBJNN EJKHOMCHPEO(this MonoBehaviour PJKDAPHKFLG, Action JLCMJEMLFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x52FCA20", Offset = "0x52FBE20", VA = "0x1852FCA20")]
	public static OFJDMAJBJNN NLBOAPMJLJA(this MonoBehaviour PJKDAPHKFLG, Action JLCMJEMLFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x52FC560", Offset = "0x52FB960", VA = "0x1852FC560")]
	public static OFJDMAJBJNN DALHFCPIILB(this MonoBehaviour PJKDAPHKFLG, Action JLCMJEMLFDK, [Optional] HBCNMLGDFMK PLKLDFDIELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x52FC690", Offset = "0x52FBA90", VA = "0x1852FC690")]
	public static OFJDMAJBJNN EMNNECDDEBG(this MonoBehaviour PJKDAPHKFLG, Action JLCMJEMLFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x52FC640", Offset = "0x52FBA40", VA = "0x1852FC640")]
	public static OFJDMAJBJNN EEMDDGDABCC(this MonoBehaviour PJKDAPHKFLG, Action JLCMJEMLFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x52FC790", Offset = "0x52FBB90", VA = "0x1852FC790")]
	public static OFJDMAJBJNN FMCGKEJHBID(this MonoBehaviour PJKDAPHKFLG, Action JLCMJEMLFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x52FC880", Offset = "0x52FBC80", VA = "0x1852FC880")]
	private static OFJDMAJBJNN GPODPALJJBK(MonoBehaviour PJKDAPHKFLG, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM, Action JLCMJEMLFDK, [Optional] HBCNMLGDFMK PLKLDFDIELA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x52FC490", Offset = "0x52FB890", VA = "0x1852FC490")]
	public static OFJDMAJBJNN CINHLJKDCJP(this MonoBehaviour PJKDAPHKFLG, float GFALLLMJOPO, Action JLCMJEMLFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x52FC3C0", Offset = "0x52FB7C0", VA = "0x1852FC3C0")]
	public static OFJDMAJBJNN BJMJLMGHGNI(this MonoBehaviour PJKDAPHKFLG, float GFALLLMJOPO, Action JLCMJEMLFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x52FC950", Offset = "0x52FBD50", VA = "0x1852FC950")]
	public static OFJDMAJBJNN KCLACKONJIJ(this MonoBehaviour PJKDAPHKFLG, float GFALLLMJOPO, Action JLCMJEMLFDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x52FC6C0", Offset = "0x52FBAC0", VA = "0x1852FC6C0")]
	public static OFJDMAJBJNN FMAHFCAJJBF(this MonoBehaviour PJKDAPHKFLG, float GFALLLMJOPO, Action JLCMJEMLFDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class HOMCOHDDOPB : JKMCAEFHKBD, IEnumerable<JKMCAEFHKBD>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly List<JKMCAEFHKBD> JMHEPELEPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool OAHGJJHOFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Action PCEENCLILGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool EODBAAECNLP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool CABOGCNAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x52F43E0", Offset = "0x52F37E0", VA = "0x1852F43E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action FJBLGFCJBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x52F3FB0", Offset = "0x52F33B0", VA = "0x1852F3FB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x52F4340", Offset = "0x52F3740", VA = "0x1852F4340", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x52F4520", Offset = "0x52F3920", VA = "0x1852F4520")]
	public HOMCOHDDOPB([Optional] Action PCEENCLILGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x52F3C90", Offset = "0x52F3090", VA = "0x1852F3C90")]
	public void AKBMAMDKLNI(JKMCAEFHKBD HBNGLIDIHEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x52F3DC0", Offset = "0x52F31C0", VA = "0x1852F3DC0")]
	private void DCKGKFNIPNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x52F4050", Offset = "0x52F3450", VA = "0x1852F4050", Slot = "7")]
	public bool MDJDJAEMOII(bool POKKNFLDEOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x52F4060", Offset = "0x52F3460", VA = "0x1852F4060", Slot = "8")]
	public bool MDJDJAEMOII(Action LECDCDLGAEL, bool POKKNFLDEOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x52F3F30", Offset = "0x52F3330", VA = "0x1852F3F30", Slot = "9")]
	public IEnumerator<JKMCAEFHKBD> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x52F3F30", Offset = "0x52F3330", VA = "0x1852F3F30", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class JPGLMGAIOJC : IBMLJGCNFHA
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class HELIINNBFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public JPGLMGAIOJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public HELIINNBFCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x52F3000", Offset = "0x52F2400", VA = "0x1852F3000")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class HAMAGELLPLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public JPGLMGAIOJC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public HAMAGELLPLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x52F3000", Offset = "0x52F2400", VA = "0x1852F3000")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float GHBPFPFAFKA;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x52F3B90", Offset = "0x52F2F90", VA = "0x1852F3B90")]
	public JPGLMGAIOJC(Behaviour GKMHGIGLKCO, float GHBPFPFAFKA, [Optional] Action PCEENCLILGL, [Optional] HBCNMLGDFMK PLKLDFDIELA, [Optional] NINALIAJMPM NIPEPNCJGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x52F9CA0", Offset = "0x52F90A0", VA = "0x1852F9CA0", Slot = "9")]
	protected override bool HEEBNAACMLL(Action LECDCDLGAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x52F9BA0", Offset = "0x52F8FA0", VA = "0x1852F9BA0", Slot = "10")]
	protected override bool EDBGFKOCFJH(Action LECDCDLGAEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface JKMCAEFHKBD
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool CABOGCNAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action FJBLGFCJBCP;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MDJDJAEMOII(bool POKKNFLDEOM = false);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MDJDJAEMOII(Action LECDCDLGAEL, bool POKKNFLDEOM = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class IBMLJGCNFHA : JKMCAEFHKBD
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class APJIJNCNALC : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public IBMLJGCNFHA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public APJIJNCNALC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x52E8790", Offset = "0x52E7B90", VA = "0x1852E8790", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x52E8860", Offset = "0x52E7C60", VA = "0x1852E8860", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Behaviour GKMHGIGLKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Action PCEENCLILGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private PCNIEINKAMN HFJEMEGHGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly HBCNMLGDFMK PLKLDFDIELA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	protected readonly NINALIAJMPM NIPEPNCJGAI;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool CABOGCNAHJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6C9910", Offset = "0x6C8D10", VA = "0x1806C9910", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action FJBLGFCJBCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x52F4860", Offset = "0x52F3C60", VA = "0x1852F4860", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x52F4C50", Offset = "0x52F4050", VA = "0x1852F4C50", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x52F4CF0", Offset = "0x52F40F0", VA = "0x1852F4CF0")]
	protected IBMLJGCNFHA(Behaviour GKMHGIGLKCO, [Optional] Action PCEENCLILGL, [Optional] HBCNMLGDFMK PLKLDFDIELA, [Optional] NINALIAJMPM NIPEPNCJGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x52F4900", Offset = "0x52F3D00", VA = "0x1852F4900", Slot = "7")]
	public bool MDJDJAEMOII(bool POKKNFLDEOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x52F4960", Offset = "0x52F3D60", VA = "0x1852F4960", Slot = "8")]
	public bool MDJDJAEMOII(Action LECDCDLGAEL, bool POKKNFLDEOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HEEBNAACMLL(Action LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool EDBGFKOCFJH(Action LECDCDLGAEL);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x52F49B0", Offset = "0x52F3DB0", VA = "0x1852F49B0")]
	protected void MJGAAOEDDFL(Action LECDCDLGAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x52F49D0", Offset = "0x52F3DD0", VA = "0x1852F49D0")]
	protected JLFOFKFALKJ MNDKLIPLEDP(float IFDELLDHIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x52F4BD0", Offset = "0x52F3FD0", VA = "0x1852F4BD0")]
	private void OGCFDIJCDFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x52F47E0", Offset = "0x52F3BE0", VA = "0x1852F47E0")]
	[IteratorStateMachine(typeof(APJIJNCNALC))]
	private IEnumerator<NCBIOOCDIOA> KHNIPJHAPAA(float IFDELLDHIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x52F47A0", Offset = "0x52F3BA0", VA = "0x1852F47A0")]
	[CompilerGenerated]
	private void FANPFEJOHEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class MDKBBDOGNJA : IBMLJGCNFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float NAEBLGNMPPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly int NINDPFJJKGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float MLGMCNONOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float[] NJOOJLGHEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int IDOELHMOKIP;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x52FAC00", Offset = "0x52FA000", VA = "0x1852FAC00")]
	public MDKBBDOGNJA(Behaviour GKMHGIGLKCO, float OJCGNFAMDPL, int NINDPFJJKGB, [Optional] Action PCEENCLILGL, float MLGMCNONOKC = 0f, [Optional] HBCNMLGDFMK PLKLDFDIELA, [Optional] NINALIAJMPM NIPEPNCJGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "9")]
	protected override bool HEEBNAACMLL(Action LECDCDLGAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x52FA940", Offset = "0x52F9D40", VA = "0x1852FA940", Slot = "10")]
	protected override bool EDBGFKOCFJH(Action LECDCDLGAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x52FAB70", Offset = "0x52F9F70", VA = "0x1852FAB70")]
	private void LADJJKLDEAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class HIDDLPFNFEN : IBMLJGCNFHA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly float GHBPFPFAFKA;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x52F3B90", Offset = "0x52F2F90", VA = "0x1852F3B90")]
	public HIDDLPFNFEN(Behaviour GKMHGIGLKCO, float GHBPFPFAFKA, [Optional] Action PCEENCLILGL, [Optional] HBCNMLGDFMK PLKLDFDIELA, [Optional] NINALIAJMPM NIPEPNCJGAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x67BD00", Offset = "0x67B100", VA = "0x18067BD00", Slot = "9")]
	protected override bool HEEBNAACMLL(Action LECDCDLGAEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x52F3B50", Offset = "0x52F2F50", VA = "0x1852F3B50", Slot = "10")]
	protected override bool EDBGFKOCFJH(Action LECDCDLGAEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class OLDGAIMPKMI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class MJBADDJEJAG : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public MJBADDJEJAG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x52FAF90", Offset = "0x52FA390", VA = "0x1852FAF90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x52FB030", Offset = "0x52FA430", VA = "0x1852FB030", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private OFJDMAJBJNN LLKKODNBGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private BODFKLNNGKK GKMHGIGLKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action<float> KENEDOAIOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float ADICKMJCEJJ;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x52FDC00", Offset = "0x52FD000", VA = "0x1852FDC00")]
	public OLDGAIMPKMI(BODFKLNNGKK GKMHGIGLKCO, float CBENHIMNKJF, Action<float> BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x52FD670", Offset = "0x52FCA70", VA = "0x1852FD670")]
	private void CJMCIIFLHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x52FDA30", Offset = "0x52FCE30", VA = "0x1852FDA30")]
	private void EOHFOMHGLNG(string CIMKHIELLCI, Action OOABEMJMIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x52FDB90", Offset = "0x52FCF90", VA = "0x1852FDB90")]
	[IteratorStateMachine(typeof(MJBADDJEJAG))]
	private IEnumerator<NCBIOOCDIOA> NJOGGDNOMJN(Action OOABEMJMIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x52FD9D0", Offset = "0x52FCDD0", VA = "0x1852FD9D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x52FD820", Offset = "0x52FCC20", VA = "0x1852FD820")]
	[CompilerGenerated]
	private void CPFICACMCGH(string PNJNNEOHMAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class GIMHKMHGOME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class OIOKOGGHMGF : IEnumerator<NCBIOOCDIOA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private NCBIOOCDIOA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private NCBIOOCDIOA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x67C200", Offset = "0x67B600", VA = "0x18067C200")]
		[DebuggerHidden]
		public OIOKOGGHMGF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x52FD590", Offset = "0x52FC990", VA = "0x1852FD590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x52FD630", Offset = "0x52FCA30", VA = "0x1852FD630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private OFJDMAJBJNN LLKKODNBGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MonoBehaviour PJKDAPHKFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Action BLADCNLMNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action<float> KENEDOAIOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float ADICKMJCEJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool DONBHDHNEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly HBCNMLGDFMK PLKLDFDIELA;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x52F25C0", Offset = "0x52F19C0", VA = "0x1852F25C0")]
	public GIMHKMHGOME(MonoBehaviour PJKDAPHKFLG, Action BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM, [Optional] HBCNMLGDFMK PLKLDFDIELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x52F2A20", Offset = "0x52F1E20", VA = "0x1852F2A20")]
	public GIMHKMHGOME(MonoBehaviour PJKDAPHKFLG, Action<float> BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM, [Optional] HBCNMLGDFMK PLKLDFDIELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x52F27C0", Offset = "0x52F1BC0", VA = "0x1852F27C0")]
	public GIMHKMHGOME(MonoBehaviour PJKDAPHKFLG, float CBENHIMNKJF, Action<float> BLADCNLMNHE, AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM, bool DONBHDHNEGK = true, [Optional] HBCNMLGDFMK PLKLDFDIELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x52F1D30", Offset = "0x52F1130", VA = "0x1852F1D30")]
	private void CAFKGMJFCIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x52F2280", Offset = "0x52F1680", VA = "0x1852F2280")]
	private void GKJCGBHHMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x52F1EA0", Offset = "0x52F12A0", VA = "0x1852F1EA0")]
	private void CJMCIIFLHGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x52F2150", Offset = "0x52F1550", VA = "0x1852F2150")]
	private void EOHFOMHGLNG(string CIMKHIELLCI, Action OOABEMJMIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x52F24C0", Offset = "0x52F18C0", VA = "0x1852F24C0")]
	[IteratorStateMachine(typeof(OIOKOGGHMGF))]
	private IEnumerator<NCBIOOCDIOA> NJOGGDNOMJN(Action OOABEMJMIHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x52F20F0", Offset = "0x52F14F0", VA = "0x1852F20F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x52F2530", Offset = "0x52F1930", VA = "0x1852F2530")]
	[CompilerGenerated]
	private void ONGMBNBIPIK(string PNJNNEOHMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x52F2430", Offset = "0x52F1830", VA = "0x1852F2430")]
	[CompilerGenerated]
	private void MECLJNCFCMC(string PNJNNEOHMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x52F2060", Offset = "0x52F1460", VA = "0x1852F2060")]
	[CompilerGenerated]
	private void DKIPLOCBAHH(string PNJNNEOHMAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum DAMAHHJDNBL : byte
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
internal sealed class NIKPFNAFOKH : NINALIAJMPM
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float IFLDGIEJEEO
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x52FCC90", Offset = "0x52FC090", VA = "0x1852FCC90", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float NBGMDIGHNIG
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x52FCCC0", Offset = "0x52FC0C0", VA = "0x1852FCCC0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double NCAOKEEFNCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x52FCCA0", Offset = "0x52FC0A0", VA = "0x1852FCCA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x52FCC20", Offset = "0x52FC020", VA = "0x1852FCC20")]
	[PCIIMDKJBPO(GGLAACLIDJL.None)]
	private static void DLEDFLHHMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	[Preserve]
	internal NIKPFNAFOKH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface ONABPBHBGOO
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JDLICCKBJOE(string DHKKANIEGMN);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGLLCCNBMGG();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface MDPKHEFNNAM
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string GAELEJJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OFCIHJFJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool AMJCOALAMOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class PNEKEAOIKPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public DGHMBMIEMFB PCKPCNJIOAM;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int IJHDILKKDIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x698F30", Offset = "0x698330", VA = "0x180698F30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x52FEB10", Offset = "0x52FDF10", VA = "0x1852FEB10")]
	public static NCBIOOCDIOA IJGEMOLPHJC(IEnumerator<NCBIOOCDIOA> KIMMLAPEPGL, EKJFJBBDNFN AEEFFNAAFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x52FECC0", Offset = "0x52FE0C0", VA = "0x1852FECC0")]
	public NCBIOOCDIOA IJGEMOLPHJC(EKJFJBBDNFN[] CNFPNIKCECI, IEnumerator<NCBIOOCDIOA>[] FJPKIOLHEJO, NCBIOOCDIOA[] OBFGCLDBPJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x52FE860", Offset = "0x52FDC60", VA = "0x1852FE860")]
	public void GPIEDEKMEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x52FE890", Offset = "0x52FDC90", VA = "0x1852FE890")]
	public void CCKAFDHGING()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x52FE9D0", Offset = "0x52FDDD0", VA = "0x1852FE9D0")]
	public void IACKNCIEFPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x52FE860", Offset = "0x52FDC60", VA = "0x1852FE860")]
	public void AMIEDNHLJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public PNEKEAOIKPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class DGHMBMIEMFB
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct IDPILLFDCEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public PNEKEAOIKPA CBGMDCGCOCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public BODFKLNNGKK PFGJKMKBHDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public EKJFJBBDNFN IBKLPADLJGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IEnumerator<NCBIOOCDIOA> BLFJEOEKKLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public NCBIOOCDIOA DBALFFNMJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public DAMAHHJDNBL DCNDFPCKJCG;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct ACAHKPHPMBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AGOCJKKDJDJ.IBDEPOFHPGH OMHPLAKGLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<IDPILLFDCEP> JMKNAKCALMN;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LNNJGNMHJLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public DGHMBMIEMFB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public BODFKLNNGKK context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public PNEKEAOIKPA routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public DAMAHHJDNBL coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public EKJFJBBDNFN promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public NCBIOOCDIOA currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IEnumerator<NCBIOOCDIOA> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LNNJGNMHJLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x52FA220", Offset = "0x52F9620", VA = "0x1852FA220")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LAFCEMIGLEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public PNEKEAOIKPA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public DGHMBMIEMFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public LAFCEMIGLEK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x52FA0B0", Offset = "0x52F94B0", VA = "0x1852FA0B0")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class DPHCIELJGLJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public PNEKEAOIKPA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public DGHMBMIEMFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public DPHCIELJGLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x52F08F0", Offset = "0x52EFCF0", VA = "0x1852F08F0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class GIBNBFCAKFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public PNEKEAOIKPA schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public DGHMBMIEMFB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
		public GIBNBFCAKFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x52F1CF0", Offset = "0x52F10F0", VA = "0x1852F1CF0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const DAMAHHJDNBL NIHNGCFHPIB = DAMAHHJDNBL.Cancelled | DAMAHHJDNBL.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool[] MCAEODCPGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<DAMAHHJDNBL> KIKAJHGPOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float> IDFIEMKMMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> OOALCCFNAOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> KCLIFPMLEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<int> OIBJGAHELLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> FEKOFBPCNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> LKNPNABDDNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private PNEKEAOIKPA[] FOHBEACPPOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private EKJFJBBDNFN[] CNFPNIKCECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private BODFKLNNGKK[] ILKKADHCDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IEnumerator<NCBIOOCDIOA>[] EGBGMECOAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private NCBIOOCDIOA[] EEEIBMMCFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int DIOINGPKKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int OAKAJHNNELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int BAFJBCBEPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float EOFAGEHECLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private MPNFMDLNOIK KFJJPPMKDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private JobHandle JPGLCEEBHGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<PNEKEAOIKPA> PHIDBGHAGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool FKMAMDOFKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private List<Action> FNAJPDHEHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<Action> HECCHNFFOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool DKIONMGCALL;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public ACAHKPHPMBI[] FMIMCNKLELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x101E400", Offset = "0x101D800", VA = "0x18101E400")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x52EF5C0", Offset = "0x52EE9C0", VA = "0x1852EF5C0")]
	private static int LEAGPKGHOLB(AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x52EFFF0", Offset = "0x52EF3F0", VA = "0x1852EFFF0")]
	public DGHMBMIEMFB(AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x52EEAC0", Offset = "0x52EDEC0", VA = "0x1852EEAC0")]
	private void GAHMHMHOHLJ(ref int KPGNMFEKDIG, int LFJCDPAMLMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x52EE300", Offset = "0x52ED700", VA = "0x1852EE300")]
	public void CANBJPFMOFL(BODFKLNNGKK GKMHGIGLKCO, NCBIOOCDIOA EPGMEBKJKIC, IEnumerator<NCBIOOCDIOA> KIMMLAPEPGL, EKJFJBBDNFN AEEFFNAAFFK, [Optional] PNEKEAOIKPA MAEFLFMFBPK, DAMAHHJDNBL BCBHEGAABIJ = DAMAHHJDNBL.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x52EDF60", Offset = "0x52ED360", VA = "0x1852EDF60")]
	public void ALACLPOFPEF(IEnumerable<IDPILLFDCEP> PPKOLEGEEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x52EE5B0", Offset = "0x52ED9B0", VA = "0x1852EE5B0")]
	private IDPILLFDCEP DMNPJHIAGCH(int HIMHCJABCFL)
	{
		return default(IDPILLFDCEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x52EEF70", Offset = "0x52EE370", VA = "0x1852EEF70")]
	private void JNIDLJOCPNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x26C0170", Offset = "0x26BF570", VA = "0x1826C0170")]
	private static void BMHFBJGFPBP<T>(int HIMHCJABCFL, T[] JPJFIDOLDLN, int DEBAMGFBJEH, [Optional] T BHLEDAANKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x26C0150", Offset = "0x26BF550", VA = "0x1826C0150")]
	private static void BMHFBJGFPBP<T>(int HIMHCJABCFL, NativeArray<T> JPJFIDOLDLN, int DEBAMGFBJEH, [Optional] T BHLEDAANKDN) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x52EF310", Offset = "0x52EE710", VA = "0x1852EF310")]
	private void LCPPHBBAGDF(IEnumerable<IDPILLFDCEP> PPKOLEGEEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x52EF5F0", Offset = "0x52EE9F0", VA = "0x1852EF5F0")]
	private void MBHBOMADDGE(IDPILLFDCEP FFHJHHCGMGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x52EECB0", Offset = "0x52EE0B0", VA = "0x1852EECB0")]
	private PKJBAGADLHI GJOKKHDFDDC(int ABPADPKFLLL)
	{
		return default(PKJBAGADLHI);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x52EDD80", Offset = "0x52ED180", VA = "0x1852EDD80")]
	public void ADNGEODPCEF(float KGHFLCHJHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x52EE280", Offset = "0x52ED680", VA = "0x1852EE280")]
	private void BFLECLCCHGJ(Action GHJDMBPGMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x52EFF70", Offset = "0x52EF370", VA = "0x1852EFF70")]
	private void PCDBCIMOKKC(Action GHJDMBPGMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x52EF6C0", Offset = "0x52EEAC0", VA = "0x1852EF6C0")]
	public void MNAOFINIDKO(float KGHFLCHJHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x52EFE70", Offset = "0x52EF270", VA = "0x1852EFE70")]
	public void NPNFNKBABCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x52EE150", Offset = "0x52ED550", VA = "0x1852EE150")]
	public void AMIEDNHLJHM(PNEKEAOIKPA DDEMJLDNAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x52EE480", Offset = "0x52ED880", VA = "0x1852EE480")]
	public void DELKNCOMIBM(PNEKEAOIKPA DDEMJLDNAFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x52EFD40", Offset = "0x52EF140", VA = "0x1852EFD40")]
	public void NEBOIOCDBCF(PNEKEAOIKPA DDEMJLDNAFM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class GCLFJKHDANB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static readonly GCLFJKHDANB PIHAGFGPKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Action KOPONCCMLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool DAIKPAIAHEO;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	public GCLFJKHDANB(Action KOPONCCMLBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x52F1740", Offset = "0x52F0B40", VA = "0x1852F1740", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface ACMDBEJKMPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OJPMPJIDGKJ(UnityEngine.Object GKMHGIGLKCO, Action<T> FEIBIBHEAKF);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface LLAGALODEPM<T> : global::ACMDBEJKMPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class ODKACAFOJPL<T> : global::LLAGALODEPM<T>, global::ACMDBEJKMPE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class HCIBGMKJEPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public global::ODKACAFOJPL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public global::NGHPEIAIIKD<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1111180", Offset = "0x1110580", VA = "0x181111180")]
		public HCIBGMKJEPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC7F50", Offset = "0x2FC7350", VA = "0x182FC7F50")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static GameObject BNHCJHAFIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<global::NGHPEIAIIKD<UnityEngine.Object, Action<T>>> JAJNHPMMADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private T MPJBAPNGOEN;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T KGOGAJOHGBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6928D0", Offset = "0x691CD0", VA = "0x1806928D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3A51780", Offset = "0x3A50B80", VA = "0x183A51780", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3A516A0", Offset = "0x3A50AA0", VA = "0x183A516A0")]
	private static bool NKMNICANCDK(T GHJDMBPGMHF, T IKDBBHHKFLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3A51B60", Offset = "0x3A50F60", VA = "0x183A51B60")]
	public ODKACAFOJPL(T MPOOIBLACPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3A517E0", Offset = "0x3A50BE0", VA = "0x183A517E0", Slot = "6")]
	public IDisposable OJPMPJIDGKJ(UnityEngine.Object GKMHGIGLKCO, Action<T> FEIBIBHEAKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3A50FB0", Offset = "0x3A503B0", VA = "0x183A50FB0")]
	private void MFNKJBKHCGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class BJMEAGHNOIJ : CHPOGAMKFEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly HBCNMLGDFMK PLKLDFDIELA;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x52E94C0", Offset = "0x52E88C0", VA = "0x1852E94C0")]
	[PCIIMDKJBPO(GGLAACLIDJL.None)]
	private static void DLEDFLHHMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	[Preserve]
	internal BJMEAGHNOIJ([IMNCNOGBAJI(null)] HBCNMLGDFMK PLKLDFDIELA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x52E9530", Offset = "0x52E8930", VA = "0x1852E9530", Slot = "4")]
	public IDisposable IAJNMIBHLJF(float CBENHIMNKJF, Action<float> MCFINHLOBAO, bool DONBHDHNEGK = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct MPNFMDLNOIK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[ReadOnly]
	public float LPCHNENOGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ReadOnly]
	public int IHGPFEHGNFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeArray<int> HHKMPMPNAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeArray<int> JJCHHFACLCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> PGIMEKCIFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[ReadOnly]
	public NativeArray<DAMAHHJDNBL> EFEEDMFGDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	public NativeArray<float> PLDFNILKGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[WriteOnly]
	public NativeArray<int> OIBJGAHELLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[WriteOnly]
	public NativeArray<int> OOALCCFNAOA;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x52FB7F0", Offset = "0x52FABF0", VA = "0x1852FB7F0")]
	public static MPNFMDLNOIK FNICMNFMKAL(int FPNBEHEMPFE, float KGHFLCHJHIA, NativeArray<DAMAHHJDNBL> EOBEJMAKBJI, NativeArray<float> JENDOALKABJ, NativeArray<int> BLHNPOPGLOP, NativeArray<int> PECBMDOEICF, NativeArray<int> HILAODGNOPA, NativeArray<int> JJCHHFACLCL, NativeArray<int> PGIMEKCIFKC)
	{
		return default(MPNFMDLNOIK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x52FB710", Offset = "0x52FAB10", VA = "0x1852FB710", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x52FB9B0", Offset = "0x52FADB0", VA = "0x1852FB9B0")]
	private bool LLFNLDKMJBF(int HMJKJGLHFKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x52FB920", Offset = "0x52FAD20", VA = "0x1852FB920")]
	private void HLOKKDALIPL(NativeArray<int> BMNPCBNGHJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x52FB950", Offset = "0x52FAD50", VA = "0x1852FB950")]
	private int JKGGJLJMNFP(int CDPDNJKIMOA, int IBLJKMMAOCD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x52FB850", Offset = "0x52FAC50", VA = "0x1852FB850")]
	private void HLLIFLEPFAF(NativeArray<int> BMNPCBNGHJG, int GFGCCMPKPJF, int HMKELCEODPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x52FB4E0", Offset = "0x52FA8E0", VA = "0x1852FB4E0")]
	private void BLDPLIJCNCM(NativeArray<int> BMNPCBNGHJG, int JNIIDACLJNN, int EGLLBFDNDAD, int MEMGNOOBHHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class HBDPDAMCGMB : ICFGDDDAPMH, HBCNMLGDFMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private DGHMBMIEMFB[] MCBKBBFKOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private ONABPBHBGOO NIKEIMFBMML;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x52F3470", Offset = "0x52F2870", VA = "0x1852F3470")]
	[PCIIMDKJBPO(GGLAACLIDJL.None)]
	private static void DLEDFLHHMLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x52F3A80", Offset = "0x52F2E80", VA = "0x1852F3A80")]
	[Preserve]
	public HBDPDAMCGMB([IMNCNOGBAJI(null)] OCOPPLPHDMI GIGFIGLLJKI, [IMNCNOGBAJI(null)] NINALIAJMPM NIPEPNCJGAI, [IMNCNOGBAJI(null)] JGHLLOPGDFG BMMIPIJHHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x52F3550", Offset = "0x52F2950", VA = "0x1852F3550", Slot = "12")]
	public override OFJDMAJBJNN FDAEAIJLHBK(BODFKLNNGKK GKMHGIGLKCO, IEnumerator<NCBIOOCDIOA> FIKMGGECPBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x52F3190", Offset = "0x52F2590", VA = "0x1852F3190", Slot = "13")]
	public override void DKMEPNBBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x52F38A0", Offset = "0x52F2CA0", VA = "0x1852F38A0", Slot = "15")]
	public override void LFCHAGHIMKN(AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x52F3690", Offset = "0x52F2A90", VA = "0x1852F3690", Slot = "14")]
	protected override void FHBKGIAODCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x52F30A0", Offset = "0x52F24A0", VA = "0x1852F30A0")]
	private DGHMBMIEMFB BJILFABCCJI(AGOCJKKDJDJ.IBDEPOFHPGH FPPBLNEEHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x52F30E0", Offset = "0x52F24E0", VA = "0x1852F30E0", Slot = "16")]
	internal override AFGDPFJPEGJ DEACFKPACPN(IEnumerator<NCBIOOCDIOA> FIKMGGECPBI, Behaviour GKMHGIGLKCO, EKJFJBBDNFN AEEFFNAAFFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x52F3030", Offset = "0x52F2430", VA = "0x1852F3030", Slot = "17")]
	internal override JKMGJJBCEKJ AONKIJEJNMF(AGOCJKKDJDJ.IBDEPOFHPGH LGFABECCLDM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x52F3770", Offset = "0x52F2B70", VA = "0x1852F3770")]
	private void HGPKAOAIFGF(DGHMBMIEMFB MKHNLBOIOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x52F34E0", Offset = "0x52F28E0", VA = "0x1852F34E0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class ICFGDDDAPMH : HBCNMLGDFMK, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly OCOPPLPHDMI GIGFIGLLJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	protected readonly NINALIAJMPM NIPEPNCJGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly JGHLLOPGDFG BMMIPIJHHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private JKMGJJBCEKJ[] GELNMJGDEAF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static HBCNMLGDFMK KGKEDLDKCKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x52F5800", Offset = "0x52F4C00", VA = "0x1852F5800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool MMIGCPEOPKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public AGOCJKKDJDJ.IBDEPOFHPGH ONCEKHELKFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(AGOCJKKDJDJ.IBDEPOFHPGH);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x698F30", Offset = "0x698330", VA = "0x180698F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public NINALIAJMPM BEEOPPCLEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x52F58F0", Offset = "0x52F4CF0", VA = "0x1852F58F0")]
	public static OFJDMAJBJNN JFKCJEMGBPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x52F5BF0", Offset = "0x52F4FF0", VA = "0x1852F5BF0")]
	[Preserve]
	protected ICFGDDDAPMH([IMNCNOGBAJI(null)] OCOPPLPHDMI GIGFIGLLJKI, [IMNCNOGBAJI(null)] NINALIAJMPM NIPEPNCJGAI, [IMNCNOGBAJI(null)] JGHLLOPGDFG BMMIPIJHHID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x52F5250", Offset = "0x52F4650", VA = "0x1852F5250", Slot = "6")]
	public OFJDMAJBJNN CECDLANABFD(IEnumerator<NCBIOOCDIOA> FIKMGGECPBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x52F5020", Offset = "0x52F4420", VA = "0x1852F5020", Slot = "7")]
	public OFJDMAJBJNN CECDLANABFD(Behaviour GKMHGIGLKCO, IEnumerator<NCBIOOCDIOA> FIKMGGECPBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract OFJDMAJBJNN FDAEAIJLHBK(BODFKLNNGKK GKMHGIGLKCO, IEnumerator<NCBIOOCDIOA> FIKMGGECPBI);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x52F5280", Offset = "0x52F4680", VA = "0x1852F5280", Slot = "13")]
	public virtual void DKMEPNBBIOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x52F5850", Offset = "0x52F4C50", VA = "0x1852F5850", Slot = "9")]
	public void IILMDEDIOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x52F57E0", Offset = "0x52F4BE0", VA = "0x1852F57E0", Slot = "14")]
	protected virtual void FHBKGIAODCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x52F4FE0", Offset = "0x52F43E0", VA = "0x1852F4FE0")]
	private void AEBIPCKHMOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x52F58D0", Offset = "0x52F4CD0", VA = "0x1852F58D0")]
	private void JDEEPOAOJEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x52F5260", Offset = "0x52F4660", VA = "0x1852F5260")]
	private void DIIDILKFGEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x52F58B0", Offset = "0x52F4CB0", VA = "0x1852F58B0")]
	private void ILJIPJDOPCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x52F4DF0", Offset = "0x52F41F0", VA = "0x1852F4DF0")]
	private void ABIKFHCCIHK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x52F5000", Offset = "0x52F4400", VA = "0x1852F5000")]
	private void BIAEMNDKHJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x52F5BD0", Offset = "0x52F4FD0", VA = "0x1852F5BD0")]
	private void NHJFJDEBOKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x52F5990", Offset = "0x52F4D90", VA = "0x1852F5990", Slot = "15")]
	public virtual void LFCHAGHIMKN(AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x52F4E10", Offset = "0x52F4210", VA = "0x1852F4E10")]
	private void ACFFICOKJPE(JKMGJJBCEKJ MKHNLBOIOBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0xC237B0", Offset = "0xC22BB0", VA = "0x180C237B0")]
	private JKMGJJBCEKJ LPPFBHPKKMF(AGOCJKKDJDJ.IBDEPOFHPGH FPPBLNEEHBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract AFGDPFJPEGJ DEACFKPACPN(IEnumerator<NCBIOOCDIOA> FIKMGGECPBI, Behaviour PJKDAPHKFLG, EKJFJBBDNFN KDNMJJPGCKF);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract JKMGJJBCEKJ AONKIJEJNMF(AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x52F5460", Offset = "0x52F4860", VA = "0x1852F5460", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class AFGDPFJPEGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly EKJFJBBDNFN AEEFFNAAFFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly MDPKHEFNNAM GKMHGIGLKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly bool KEMBMIJOJMK;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<NCBIOOCDIOA> BLFJEOEKKLE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x679AC0", Offset = "0x678EC0", VA = "0x180679AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x697530", VA = "0x180698130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public NCBIOOCDIOA DBALFFNMJBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x697540", VA = "0x180698140")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool DLLCDGOKPJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x52E7FD0", Offset = "0x52E73D0", VA = "0x1852E7FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool LKEKKAAAIBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x8742B0", Offset = "0x8736B0", VA = "0x1808742B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x8136F0", Offset = "0x812AF0", VA = "0x1808136F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string GAELEJJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x67F570", Offset = "0x67E970", VA = "0x18067F570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x67F590", Offset = "0x67E990", VA = "0x18067F590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float MOKIKIOFLPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x11F1B40", Offset = "0x11F0F40", VA = "0x1811F1B40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x11F1810", Offset = "0x11F0C10", VA = "0x1811F1810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x52E8440", Offset = "0x52E7840", VA = "0x1852E8440")]
	public AFGDPFJPEGJ(IEnumerator<NCBIOOCDIOA> KIMMLAPEPGL, MDPKHEFNNAM GKMHGIGLKCO, EKJFJBBDNFN AEEFFNAAFFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x52E80C0", Offset = "0x52E74C0", VA = "0x1852E80C0")]
	public NCBIOOCDIOA IJGEMOLPHJC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x52E8050", Offset = "0x52E7450", VA = "0x1852E8050")]
	public bool CDINNPMDBJG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x52E7F50", Offset = "0x52E7350", VA = "0x1852E7F50")]
	public void AMIEDNHLJHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x52E8380", Offset = "0x52E7780", VA = "0x1852E8380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x19A5980", Offset = "0x19A4D80", VA = "0x1819A5980")]
	[CompilerGenerated]
	private void BFPLKJNBJMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class EKJFJBBDNFN : MKBPBBENCLA, OFJDMAJBJNN, PCNIEINKAMN, JLFOFKFALKJ, IEnumerator, NCBIOOCDIOA, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private AGOCJKKDJDJ.IBDEPOFHPGH JJMKMKMIIBB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private AGOCJKKDJDJ.IBDEPOFHPGH HLENPEJFNAB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x71C510", Offset = "0x71B910", VA = "0x18071C510", Slot = "23")]
		get
		{
			return default(AGOCJKKDJDJ.IBDEPOFHPGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public AGOCJKKDJDJ.IBDEPOFHPGH PCKPCNJIOAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x81DB40", Offset = "0x81CF40", VA = "0x18081DB40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float GDDNILAEMLF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xFFA5D0", Offset = "0xFF99D0", VA = "0x180FFA5D0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x52F0E30", Offset = "0x52F0230", VA = "0x1852F0E30", Slot = "24")]
	private bool JGDNGABJPAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x52F0E20", Offset = "0x52F0220", VA = "0x1852F0E20", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x52F0E50", Offset = "0x52F0250", VA = "0x1852F0E50")]
	public EKJFJBBDNFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum PKJBAGADLHI : byte
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
internal sealed class JKMGJJBCEKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum APKGMMNOIFI
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct JAMBBLOPECK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public AGOCJKKDJDJ.IBDEPOFHPGH OMHPLAKGLEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public APKGMMNOIFI BGKKKCAJMAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public List<AFGDPFJPEGJ> OJFEOJJONGF;
	}

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly APKGMMNOIFI[] OMKGPELNJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly AGOCJKKDJDJ.IBDEPOFHPGH CHKNAIONAKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool FCNOGPLJIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly AFGDPFJPEGJ[] CCCILEBGNBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<AFGDPFJPEGJ> NOBKGBACPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Stack<int> NHNBPAFLMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly List<AFGDPFJPEGJ> GBGPFJICKHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Stack<int> CKNLGHMIFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly ONABPBHBGOO NLHPGIMKPAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool DKIONMGCALL;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public JAMBBLOPECK[,] KFIBDNCOFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x6780D0", Offset = "0x6774D0", VA = "0x1806780D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x52F94F0", Offset = "0x52F88F0", VA = "0x1852F94F0")]
	public JKMGJJBCEKJ(AGOCJKKDJDJ.IBDEPOFHPGH LGFABECCLDM, ONABPBHBGOO NLHPGIMKPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x52F8780", Offset = "0x52F7B80", VA = "0x1852F8780")]
	public void GOKBPAGAKHB(AFGDPFJPEGJ KIMMLAPEPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x52F9110", Offset = "0x52F8510", VA = "0x1852F9110")]
	public void OLMMJJEIHOK(IList<AFGDPFJPEGJ> FJPKIOLHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x52F8130", Offset = "0x52F7530", VA = "0x1852F8130")]
	public void BIONMOCBBOL(IList<AFGDPFJPEGJ> FJPKIOLHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x52F8400", Offset = "0x52F7800", VA = "0x1852F8400")]
	private void BPKPODDOIAG(AFGDPFJPEGJ KIMMLAPEPGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x52F8CD0", Offset = "0x52F80D0", VA = "0x1852F8CD0")]
	private void MFIJNHBPINA(IList<AFGDPFJPEGJ> FJPKIOLHEJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x52F8F70", Offset = "0x52F8370", VA = "0x1852F8F70")]
	private PKJBAGADLHI NGEGFADIDEO(AFGDPFJPEGJ KIMMLAPEPGL)
	{
		return default(PKJBAGADLHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x52F8640", Offset = "0x52F7A40", VA = "0x1852F8640")]
	public void FHBKGIAODCG(float KGHFLCHJHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x52F88A0", Offset = "0x52F7CA0", VA = "0x1852F88A0")]
	public void IILMDEDIOMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x52F8AB0", Offset = "0x52F7EB0", VA = "0x1852F8AB0")]
	private void KBOOLFGDLDK(List<AFGDPFJPEGJ> FJPKIOLHEJO, Stack<int> FBKPLKIBHAG, bool BJNHKGFIBFL, float BJFHFNBAABC = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x52F8500", Offset = "0x52F7900", VA = "0x1852F8500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x52F8E50", Offset = "0x52F8250", VA = "0x1852F8E50")]
	private void NCKCBOBOIIJ(List<AFGDPFJPEGJ> FJPKIOLHEJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class NMGPDBDKPFJ : ONABPBHBGOO
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "4")]
	public void JDLICCKBJOE(string DHKKANIEGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x691EB0", Offset = "0x6912B0", VA = "0x180691EB0", Slot = "5")]
	public void AGLLCCNBMGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NMGPDBDKPFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class GKOICHGHBBK : MDPKHEFNNAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Behaviour PJKDAPHKFLG;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string GAELEJJHLDP
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x52F2CE0", Offset = "0x52F20E0", VA = "0x1852F2CE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OFCIHJFJKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x52F2C60", Offset = "0x52F2060", VA = "0x1852F2C60", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool AMJCOALAMOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x52F2CC0", Offset = "0x52F20C0", VA = "0x1852F2CC0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x678F40", Offset = "0x678340", VA = "0x180678F40")]
	public GKOICHGHBBK(Behaviour PJKDAPHKFLG)
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
