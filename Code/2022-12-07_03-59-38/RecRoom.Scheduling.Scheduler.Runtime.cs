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
public class FBHHEJIEPKI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority CAIFIALMCDJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5424500", Offset = "0x5423100", VA = "0x185424500")]
	public FBHHEJIEPKI(ThreadPriority OJGMMLBOFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x54244F0", Offset = "0x54230F0", VA = "0x1854244F0", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> CIFDGDDLKHM(List<PlayerLoopSystem> OAMEEAPEBME, int OIMHHEFPAJL);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct IEGFBFIHIDC
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct KJFFDMGIDHD
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static IOJAEKNEPPN CBBNHKOLOHC;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x5427F10", Offset = "0x5426B10", VA = "0x185427F10")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct DGPIDBGJFNK
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static IOJAEKNEPPN LJDEHFEJEPL;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x5422440", Offset = "0x5421040", VA = "0x185422440")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct EFJGKNJAKNO
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static IOJAEKNEPPN MKPMKJCKMEL;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x54242E0", Offset = "0x5422EE0", VA = "0x1854242E0")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct DOBGCKJJAKF
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static IOJAEKNEPPN GECKMDEEDKK;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static IOJAEKNEPPN IMIGLFOCHIJ;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static IOJAEKNEPPN ACLNLJNOGGN;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static IOJAEKNEPPN CJKJFEHACHP;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x5423240", Offset = "0x5421E40", VA = "0x185423240")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct GMBCODMIKEI
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static IOJAEKNEPPN KLNKOOBOINL;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x5425A20", Offset = "0x5424620", VA = "0x185425A20")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct OCLEHAEMLDD
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static IOJAEKNEPPN GECKMDEEDKK;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static IOJAEKNEPPN IMIGLFOCHIJ;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static IOJAEKNEPPN ACLNLJNOGGN;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static IOJAEKNEPPN CJKJFEHACHP;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x542D150", Offset = "0x542BD50", VA = "0x18542D150")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct DAKPDDEABGI
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static IOJAEKNEPPN EKOGNHMMCEL;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x5421520", Offset = "0x5420120", VA = "0x185421520")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct DEGDCJPDKLL
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static IOJAEKNEPPN GCJOHHPGKJM;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5421ED0", Offset = "0x5420AD0", VA = "0x185421ED0")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct AGAJABDECJG
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static IOJAEKNEPPN EEGGJMFFLAA;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x54171D0", Offset = "0x5415DD0", VA = "0x1854171D0")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct FLOGLMCFDDM
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static IOJAEKNEPPN NKDEGMCLOFG;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x5425570", Offset = "0x5424170", VA = "0x185425570")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct INNABPIMMHJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static IOJAEKNEPPN DINPAFBKOJO;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x5426350", Offset = "0x5424F50", VA = "0x185426350")]
				public static PlayerLoopSystem BLLCIGIENMP()
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct BBAGFIGPFJC
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class GMBOPLOBJGK
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public MCKPPDDHGLA.MIHMGPDEOMF key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
					public GMBOPLOBJGK()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x5425C00", Offset = "0x5424800", VA = "0x185425C00")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable AHMIIDKLHIB;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x5417D80", Offset = "0x5416980", VA = "0x185417D80")]
				public static PlayerLoopSystem DILINAMBPOI(MCKPPDDHGLA.MIHMGPDEOMF NANBEBOOGPM)
				{
					return default(PlayerLoopSystem);
				}
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			internal struct KLEMFANHLIG
			{
				[Cpp2IlInjected.Token(Token = "0x2000020")]
				[CompilerGenerated]
				private sealed class PAEDJHNNBBP
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002E")]
					public MCKPPDDHGLA.MIHMGPDEOMF key;

					[Cpp2IlInjected.Token(Token = "0x600004E")]
					[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
					public PAEDJHNNBBP()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004F")]
					[Cpp2IlInjected.Address(RVA = "0x542D8B0", Offset = "0x542C4B0", VA = "0x18542D8B0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0x5428AC0", Offset = "0x54276C0", VA = "0x185428AC0")]
				public static PlayerLoopSystem DILINAMBPOI(MCKPPDDHGLA.MIHMGPDEOMF NANBEBOOGPM)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class IMIPAKGPCJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
			public IMIPAKGPCJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5426230", Offset = "0x5424E30", VA = "0x185426230")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool MIGICNJDFMK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool LGMOCLNGBEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x5421050", Offset = "0x541FC50", VA = "0x185421050")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x541FD30", Offset = "0x541E930", VA = "0x18541FD30")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x541DC60", Offset = "0x541C860", VA = "0x18541DC60")]
		private static void AKOOJOBAAFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x5420650", Offset = "0x541F250", VA = "0x185420650")]
		private static void LOJAHBGFNCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5420320", Offset = "0x541EF20", VA = "0x185420320")]
		private static void JCOANJCPJDL(string ECOONNBPHCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x541FB00", Offset = "0x541E700", VA = "0x18541FB00")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5420160", Offset = "0x541ED60", VA = "0x185420160")]
		private static void GMDKHONNBFJ(MCKPPDDHGLA.MIHMGPDEOMF NANBEBOOGPM, ref PlayerLoopSystem MGIFNIAFAFK, Type OKPALAGCLAG, Type JKMAECBHMPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x541FD70", Offset = "0x541E970", VA = "0x18541FD70")]
		private static void EHNLDLIKMLA(ref PlayerLoopSystem MGIFNIAFAFK, Type OKPALAGCLAG, Type JKMAECBHMPK, CIFDGDDLKHM MKIGFALGOCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5420F20", Offset = "0x541FB20", VA = "0x185420F20")]
		private static void MHAHPBMHLDG(ref PlayerLoopSystem MGIFNIAFAFK, Type OKPALAGCLAG, Type JKMAECBHMPK, PlayerLoopSystem? NFOABMJOFMD, PlayerLoopSystem? JBIBKBOFMHH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class MCKPPDDHGLA
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public enum MIHMGPDEOMF
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
	public class HIGGDNIGCHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly MIHMGPDEOMF EEMKEKICEOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly AGALDAELNBL DPHDECOCEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private long PGHNOFMKLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private long CKIALCAOOAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public long CBKKFONEEDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public int NCDMCDNEOBB;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5426130", Offset = "0x5424D30", VA = "0x185426130")]
		public HIGGDNIGCHI(MIHMGPDEOMF NONNMGOEIDN, int DNCBGKBJOLG = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5425EC0", Offset = "0x5424AC0", VA = "0x185425EC0")]
		public void GHEBNHOJMCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5425E60", Offset = "0x5424A60", VA = "0x185425E60")]
		public void CNKGIJOJCDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5425F30", Offset = "0x5424B30", VA = "0x185425F30")]
		public void LIEEDCGGMGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static MIHMGPDEOMF[] DKDLAMLEJPL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static HIGGDNIGCHI[] ICALAHFIDNE;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x542A770", Offset = "0x5429370", VA = "0x18542A770")]
	public static HIGGDNIGCHI BCDNFMMKLHO(MIHMGPDEOMF NANBEBOOGPM, int DNCBGKBJOLG = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x542A940", Offset = "0x5429540", VA = "0x18542A940")]
	public static HIGGDNIGCHI CMAMOECKGBB(MIHMGPDEOMF NANBEBOOGPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x542A9D0", Offset = "0x54295D0", VA = "0x18542A9D0")]
	public static void DECPELHGCMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public class AGALDAELNBL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public int EAIJIMPMCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly Queue<double> GCEHLCLEFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double OMNMFNNFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double CCAKNLFDCEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double EAECGGCDAFL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double MEGCIIJMJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x54173B0", Offset = "0x5415FB0", VA = "0x1854173B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x54175B0", Offset = "0x54161B0", VA = "0x1854175B0")]
	public AGALDAELNBL(int LIOIIOKMIFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5417480", Offset = "0x5416080", VA = "0x185417480", Slot = "4")]
	public void PGIJPPOJIMA(double IAFIPJAFKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5417410", Offset = "0x5416010", VA = "0x185417410", Slot = "5")]
	public void PACBOHNGOLL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class GEPOOCPKDGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private long GGKDNLHEHMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double JAMMIFMKDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double NEGGEDBOLIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private double KNEAPLJMCON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private double BOFNGCAGDNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private double OMNMFNNFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private double CCAKNLFDCEM;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long GEHHFJONLGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double FLAJCIMKCCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8312B0", Offset = "0x82FEB0", VA = "0x1808312B0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double KEBDANKPIHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x831330", Offset = "0x82FF30", VA = "0x180831330", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double KLNMEGGBEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x749E60", Offset = "0x748A60", VA = "0x180749E60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double MEGCIIJMJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8311C0", Offset = "0x82FDC0", VA = "0x1808311C0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5425790", Offset = "0x5424390", VA = "0x185425790", Slot = "7")]
	public void PGIJPPOJIMA(double IAFIPJAFKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5425750", Offset = "0x5424350", VA = "0x185425750", Slot = "8")]
	public void PACBOHNGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x54258C0", Offset = "0x54244C0", VA = "0x1854258C0")]
	public GEPOOCPKDGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class DALJLCNNFCB
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private interface JILFPFEILIL
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool LOOFLFKGDGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OAIJALNIHHK();
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private abstract class KKICKOALLJJ<TPromise, TMainThreadPromise> : JILFPFEILIL where TPromise : CKHAEIDHOPE where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly TPromise KAPPHIMDABE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		protected readonly TMainThreadPromise GKJJGBNFGEJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise IIKDEFNICLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x37C13E0", Offset = "0x37BFFE0", VA = "0x1837C13E0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LOOFLFKGDGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x37C1360", Offset = "0x37BFF60", VA = "0x1837C1360", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x270DD20", Offset = "0x270C920", VA = "0x18270DD20")]
		protected KKICKOALLJJ(TPromise KAPPHIMDABE, TMainThreadPromise PJCGOBEFCBH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x37C13B0", Offset = "0x37BFFB0", VA = "0x1837C13B0", Slot = "5")]
		public void OAIJALNIHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void OAELLPFCDCC(TPromise KAPPHIMDABE);
	}

	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private class HGAMILKMDNL<T> : KKICKOALLJJ<global::GANDAICPPHN<T>, global::NMCHCEAGLKO<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x3915C80", Offset = "0x3914880", VA = "0x183915C80")]
		public HGAMILKMDNL(global::GANDAICPPHN<T> KAPPHIMDABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x3915A70", Offset = "0x3914670", VA = "0x183915A70", Slot = "6")]
		protected override void OAELLPFCDCC(global::GANDAICPPHN<T> KAPPHIMDABE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x3915A40", Offset = "0x3914640", VA = "0x183915A40")]
		[CompilerGenerated]
		private void LMOAIGGEKMA(T HJIMPKKMPML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA180", Offset = "0x1DC8D80", VA = "0x181DCA180")]
		[CompilerGenerated]
		private void MJEKFLPOAGO(string CHGFDAMICCB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private class ANLOIHHOFHP : JILFPFEILIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly Action MNJNLIAKBME;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LOOFLFKGDGO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
		public ANLOIHHOFHP(Action MNJNLIAKBME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x15E2E00", Offset = "0x15E1A00", VA = "0x1815E2E00", Slot = "5")]
		public void OAIJALNIHHK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static readonly List<JILFPFEILIL> HFJEFHLELHA;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x25538B0", Offset = "0x25524B0", VA = "0x1825538B0")]
	public static global::GANDAICPPHN<T> NGALEKFHCPN<T>(this global::GANDAICPPHN<T> KAPPHIMDABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x5421BC0", Offset = "0x54207C0", VA = "0x185421BC0")]
	public static void NGALEKFHCPN(Action MNJNLIAKBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x25537F0", Offset = "0x25523F0", VA = "0x1825537F0")]
	private static global::GANDAICPPHN<T> EAJKLKEDFEE<T>(global::GANDAICPPHN<T> KAPPHIMDABE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5421C50", Offset = "0x5420850", VA = "0x185421C50")]
	private static void OFPLFOCKHDL(JILFPFEILIL CLFFJFIKNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5421700", Offset = "0x5420300", VA = "0x185421700")]
	private static void BKJNBNEHNKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x54219F0", Offset = "0x54205F0", VA = "0x1854219F0")]
	private static void DOBPFKOMIIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5421AF0", Offset = "0x54206F0", VA = "0x185421AF0")]
	private static void EJDIIINJPPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NDJOENJIJJM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	private struct CHMPIFINAJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public TaskCompletionSource<Scene> IPJEGEIBPHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly string AAACHMNNIGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly LoadSceneMode HFMPFDPBGEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool AFIOACOFFOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly IFANLHMJJPA DHJIFBEMLMJ;

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x541AD10", Offset = "0x5419910", VA = "0x18541AD10")]
		public CHMPIFINAJE(TaskCompletionSource<Scene> OAMBOBJCFBA, string AAACHMNNIGK, LoadSceneMode HFMPFDPBGEH, bool AFIOACOFFOM, IFANLHMJJPA DHJIFBEMLMJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct BFEIMBFKFJG : IAsyncStateMachine
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
		public IFANLHMJJPA stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private global::EOHJIFBBDNE<string> <toDispose>5__2;

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
		[Cpp2IlInjected.Address(RVA = "0x5419160", Offset = "0x5417D60", VA = "0x185419160", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x54197D0", Offset = "0x54183D0", VA = "0x1854197D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private struct NJIFCAJMFED : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x542CE50", Offset = "0x542BA50", VA = "0x18542CE50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct DFPEIPNGJBO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private CHMPIFINAJE <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x54220B0", Offset = "0x5420CB0", VA = "0x1854220B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x73B6E0", Offset = "0x73A2E0", VA = "0x18073B6E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class OGDAPDGDOPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public global::NMCHCEAGLKO<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public OGDAPDGDOPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x542D3E0", Offset = "0x542BFE0", VA = "0x18542D3E0")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private struct EBJMGBCLIIK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public IFANLHMJJPA stackTimer;

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
		private OGDAPDGDOPH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IFANLHMJJPA <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private IFANLHMJJPA <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x54234D0", Offset = "0x54220D0", VA = "0x1854234D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5423E50", Offset = "0x5422A50", VA = "0x185423E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private struct BJADFHIMFED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IFANLHMJJPA stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private IFANLHMJJPA <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private IFANLHMJJPA <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5419820", Offset = "0x5418420", VA = "0x185419820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x541A060", Offset = "0x5418C60", VA = "0x18541A060", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ELNAECMMLIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public ELNAECMMLIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x54244C0", Offset = "0x54230C0", VA = "0x1854244C0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class EDMPFFMIFHE : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public OBDOOKDFCDE onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public EDMPFFMIFHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5424200", Offset = "0x5422E00", VA = "0x185424200", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x5423EA0", Offset = "0x5422AA0", VA = "0x185423EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x5424290", Offset = "0x5422E90", VA = "0x185424290")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x54241C0", Offset = "0x5422DC0", VA = "0x1854241C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class NCFCCOJFABP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public global::NMCHCEAGLKO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public NCFCCOJFABP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class DAHOPIEBHFJ : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public global::NMCHCEAGLKO<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private NCFCCOJFABP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public DAHOPIEBHFJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5421090", Offset = "0x541FC90", VA = "0x185421090", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x54214E0", Offset = "0x54200E0", VA = "0x1854214E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static CKHAEIDHOPE MFBCMDDBBFP;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private static AsyncOperation BEGHNCDGHJJ;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static CKHAEIDHOPE PPBGIMMHLFC;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static string PAPNDBEBAKO;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static ThreadPriority NOHDEJIDGJJ;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static Task OCDIMGMEJEJ;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private static readonly Queue<CHMPIFINAJE> DBCECNHBHAD;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private static Task FFOFDPECEBO;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool BBFIGIAMBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x542C530", Offset = "0x542B130", VA = "0x18542C530")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool BFHFBKFFDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x542C2F0", Offset = "0x542AEF0", VA = "0x18542C2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool GFEBFKFLODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x542C790", Offset = "0x542B390", VA = "0x18542C790")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> GINOBJKGPGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x542B9A0", Offset = "0x542A5A0", VA = "0x18542B9A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x542C430", Offset = "0x542B030", VA = "0x18542C430")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x542BE90", Offset = "0x542AA90", VA = "0x18542BE90")]
	[AKLMCCEMLAH(OAKCDKKFGKB.EnteredEditModeNextFrame, 0)]
	private static void CLEBFONCGIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x542C190", Offset = "0x542AD90", VA = "0x18542C190")]
	[AsyncStateMachine(typeof(BFEIMBFKFJG))]
	public static Task<Scene> ECJGEKMCGJE(string AAACHMNNIGK, LoadSceneMode HFMPFDPBGEH = LoadSceneMode.Single, bool AFIOACOFFOM = false, [Optional] IFANLHMJJPA GFHKBIGFBNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x542C0C0", Offset = "0x542ACC0", VA = "0x18542C0C0")]
	[AsyncStateMachine(typeof(NJIFCAJMFED))]
	private static Task DKJGBFFIMIK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x542BAA0", Offset = "0x542A6A0", VA = "0x18542BAA0")]
	[AsyncStateMachine(typeof(DFPEIPNGJBO))]
	private static Task AKBFDPLDLBN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x542BB90", Offset = "0x542A790", VA = "0x18542BB90")]
	[AsyncStateMachine(typeof(EBJMGBCLIIK))]
	private static Task<Scene> BBMAGNBBNAG(string AAACHMNNIGK, LoadSceneMode HFMPFDPBGEH, bool AFIOACOFFOM, IFANLHMJJPA DHJIFBEMLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x542C850", Offset = "0x542B450", VA = "0x18542C850")]
	[AsyncStateMachine(typeof(BJADFHIMFED))]
	private static Task<Scene> PMLGPPIFPMD(IFANLHMJJPA DHJIFBEMLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x542BCF0", Offset = "0x542A8F0", VA = "0x18542BCF0")]
	public static global::GANDAICPPHN<Scene> BFNPGDLKIIG(string AAACHMNNIGK, LoadSceneMode HFMPFDPBGEH = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x542C990", Offset = "0x542B590", VA = "0x18542C990")]
	public static CKHAEIDHOPE PNFEBKGKAMD(string AAACHMNNIGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x542C3A0", Offset = "0x542AFA0", VA = "0x18542C3A0")]
	[IteratorStateMachine(typeof(EDMPFFMIFHE))]
	private static IEnumerator<FEPBFCLHFNJ> KNCHFBNEALH(string AAACHMNNIGK, OBDOOKDFCDE BEKNABOKAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x542C6F0", Offset = "0x542B2F0", VA = "0x18542C6F0")]
	[IteratorStateMachine(typeof(DAHOPIEBHFJ))]
	private static IEnumerator<FEPBFCLHFNJ> NIPPNBOBAPA(string AAACHMNNIGK, LoadSceneMode HFMPFDPBGEH, global::NMCHCEAGLKO<Scene> BEKNABOKAPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x542BF60", Offset = "0x542AB60", VA = "0x18542BF60")]
	public static bool DDCIDCDHDDA(out string FOLEOJPMMLE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class LFNEFLFGDGK
{
	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5428C70", Offset = "0x5427870", VA = "0x185428C70")]
	public static IDisposable JLCJHKNBFBB(this JPAFKFIHEAB MAMKOIKAADI, float NPFOCICFAEC, Action<float> KLNFHKKKGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5428BF0", Offset = "0x54277F0", VA = "0x185428BF0")]
	public static IDisposable HEMIIEJJEHC(this JPAFKFIHEAB MAMKOIKAADI, Action<float> KLNFHKKKGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5428CF0", Offset = "0x54278F0", VA = "0x185428CF0")]
	public static IDisposable KGMCKGOGAHE(this JPAFKFIHEAB MAMKOIKAADI, Action<float> KLNFHKKKGLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public static class KKOHICBFCBK
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5428390", Offset = "0x5426F90", VA = "0x185428390")]
	public static IDisposable GKKNFBBCPMA(this MonoBehaviour HFNAEFAFGBI, Action KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5428310", Offset = "0x5426F10", VA = "0x185428310")]
	public static IDisposable GKKNFBBCPMA(this MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x54285B0", Offset = "0x54271B0", VA = "0x1854285B0")]
	public static IDisposable KLLCLICJMAF(this MonoBehaviour HFNAEFAFGBI, Action KLNFHKKKGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5428530", Offset = "0x5427130", VA = "0x185428530")]
	public static IDisposable IELHGHIGLPB(this MonoBehaviour HFNAEFAFGBI, Action KLNFHKKKGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5428200", Offset = "0x5426E00", VA = "0x185428200")]
	public static IDisposable FELMNNCJDGP(this MonoBehaviour HFNAEFAFGBI, Action KLNFHKKKGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5428890", Offset = "0x5427490", VA = "0x185428890")]
	public static IDisposable NEECBIIPJIF(this MonoBehaviour HFNAEFAFGBI, Action KLNFHKKKGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5428180", Offset = "0x5426D80", VA = "0x185428180")]
	public static IDisposable EJGEMDPHOBG(this MonoBehaviour HFNAEFAFGBI, Action KLNFHKKKGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x5428620", Offset = "0x5427220", VA = "0x185428620")]
	public static IDisposable LNEJDBNNJGC(this MonoBehaviour HFNAEFAFGBI, float NPFOCICFAEC, Action<float> KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x54286C0", Offset = "0x54272C0", VA = "0x1854286C0")]
	public static IDisposable MHBKIGNJLNP(this MonoBehaviour HFNAEFAFGBI, float NPFOCICFAEC, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x54284A0", Offset = "0x54270A0", VA = "0x1854284A0")]
	public static IDisposable HKBODOMECIC(this MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5428410", Offset = "0x5427010", VA = "0x185428410")]
	public static IDisposable HICJIFKHNHJ(this MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5428A30", Offset = "0x5427630", VA = "0x185428A30")]
	public static IDisposable PNOMIKLDIDJ(this MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5428800", Offset = "0x5427400", VA = "0x185428800")]
	public static IDisposable MJKIHLKFMGD(this MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x54289A0", Offset = "0x54275A0", VA = "0x1854289A0")]
	public static IDisposable PGIBIFGPLOK(this MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5428910", Offset = "0x5427510", VA = "0x185428910")]
	public static IDisposable OFLBLOHHOBK(this MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5428280", Offset = "0x5426E80", VA = "0x185428280")]
	public static IDisposable FPHPECFDPNA(this MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5428760", Offset = "0x5427360", VA = "0x185428760")]
	public static IDisposable MJHAJIOMFEC(this MonoBehaviour HFNAEFAFGBI, float NPFOCICFAEC, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x54280F0", Offset = "0x5426CF0", VA = "0x1854280F0")]
	public static IDisposable EDGNGMGPEBJ(this MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class CIKEDFBIDHJ
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class FJCDFJKBMFD : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public LIIOGLHABAB.LCGNFGNPAPE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private GDBBFEFLIEP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public FJCDFJKBMFD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x5425470", Offset = "0x5424070", VA = "0x185425470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x5425530", Offset = "0x5424130", VA = "0x185425530", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class GHHFEPGGGED : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public LIIOGLHABAB.LCGNFGNPAPE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private GDBBFEFLIEP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public GHHFEPGGGED(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x54258F0", Offset = "0x54244F0", VA = "0x1854258F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x54259E0", Offset = "0x54245E0", VA = "0x1854259E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x541AEC0", Offset = "0x5419AC0", VA = "0x18541AEC0")]
	public static GMBEEMHKFHH GKKNFBBCPMA(Action KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x541AE00", Offset = "0x5419A00", VA = "0x18541AE00")]
	public static GMBEEMHKFHH GKKNFBBCPMA(Behaviour MAMKOIKAADI, Action KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x541AFE0", Offset = "0x5419BE0", VA = "0x18541AFE0")]
	public static GMBEEMHKFHH GKKNFBBCPMA(Behaviour MAMKOIKAADI, Action<float> KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x541B0F0", Offset = "0x5419CF0", VA = "0x18541B0F0")]
	[IteratorStateMachine(typeof(FJCDFJKBMFD))]
	private static IEnumerator<FEPBFCLHFNJ> GNEAHNCFIIK(LIIOGLHABAB.LCGNFGNPAPE FFDFLABPLPF, Action KLNFHKKKGLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x541B170", Offset = "0x5419D70", VA = "0x18541B170")]
	[IteratorStateMachine(typeof(GHHFEPGGGED))]
	private static IEnumerator<FEPBFCLHFNJ> GNEAHNCFIIK(LIIOGLHABAB.LCGNFGNPAPE FFDFLABPLPF, Action<float> KLNFHKKKGLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class MJBCOELENMG
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ACKENPLBJAO : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public KMFBLJKPAFJ schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		public LIIOGLHABAB.LCGNFGNPAPE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private JDAPFDHDNGP <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public ACKENPLBJAO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x5416A00", Offset = "0x5415600", VA = "0x185416A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x5416B40", Offset = "0x5415740", VA = "0x185416B40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x542ABE0", Offset = "0x54297E0", VA = "0x18542ABE0")]
	public static GMBEEMHKFHH GKKNFBBCPMA(MonoBehaviour HFNAEFAFGBI, float NPFOCICFAEC, Action<float> KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL, bool HMLFFCMJDCH = true, [Optional] DNDKFEJOEAD LIAFCDFOAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x542ADA0", Offset = "0x54299A0", VA = "0x18542ADA0")]
	public static GMBEEMHKFHH GNKDJEHPDNO(JPAFKFIHEAB MAMKOIKAADI, float NPFOCICFAEC, Action<float> KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL, bool HMLFFCMJDCH = true, [Optional] DNDKFEJOEAD LIAFCDFOAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x542ACF0", Offset = "0x54298F0", VA = "0x18542ACF0")]
	[IteratorStateMachine(typeof(ACKENPLBJAO))]
	private static IEnumerator<FEPBFCLHFNJ> GNEAHNCFIIK(KMFBLJKPAFJ HOHDFBKAGBM, float NPFOCICFAEC, LIIOGLHABAB.LCGNFGNPAPE FFDFLABPLPF, Action<float> KLNFHKKKGLI, bool HMLFFCMJDCH = true, [Optional] DNDKFEJOEAD LIAFCDFOAIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class ABNEDPPMNJP
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class CPFMGHMACLF : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public LIIOGLHABAB.LCGNFGNPAPE queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public CPFMGHMACLF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x541DB70", Offset = "0x541C770", VA = "0x18541DB70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x541DC20", Offset = "0x541C820", VA = "0x18541DC20", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5416870", Offset = "0x5415470", VA = "0x185416870")]
	[IteratorStateMachine(typeof(CPFMGHMACLF))]
	private static IEnumerator<FEPBFCLHFNJ> DCLLJNMPFGH(LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL, Func<bool> MDACOFICNCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x54168F0", Offset = "0x54154F0", VA = "0x1854168F0")]
	public static GMBEEMHKFHH HJFOEFPDMLJ(this MonoBehaviour HFNAEFAFGBI, Func<bool> MDACOFICNCL, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL = LIIOGLHABAB.LCGNFGNPAPE.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class AOEDJAOIBJI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class BDIMDDDBEEA : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public LIIOGLHABAB.LCGNFGNPAPE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public BDIMDDDBEEA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5419060", Offset = "0x5417C60", VA = "0x185419060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5419120", Offset = "0x5417D20", VA = "0x185419120", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x54178F0", Offset = "0x54164F0", VA = "0x1854178F0")]
	[IteratorStateMachine(typeof(BDIMDDDBEEA))]
	private static IEnumerator<FEPBFCLHFNJ> GPKJMNEAOFN(float IEKGNIDOFPP, LIIOGLHABAB.LCGNFGNPAPE FFDFLABPLPF, Action LHPENGCHIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5417660", Offset = "0x5416260", VA = "0x185417660")]
	public static GMBEEMHKFHH AKLHNHKPJDG(this MonoBehaviour HFNAEFAFGBI, float IEKGNIDOFPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5417980", Offset = "0x5416580", VA = "0x185417980")]
	public static GMBEEMHKFHH HPEOJKBFAHM(this MonoBehaviour HFNAEFAFGBI, Action LHPENGCHIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x54177F0", Offset = "0x54163F0", VA = "0x1854177F0")]
	public static GMBEEMHKFHH GACNFFGIDLM(this MonoBehaviour HFNAEFAFGBI, Action LHPENGCHIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5417B40", Offset = "0x5416740", VA = "0x185417B40")]
	public static GMBEEMHKFHH LJPCLGICELF(this MonoBehaviour HFNAEFAFGBI, Action LHPENGCHIMB, [Optional] DNDKFEJOEAD LIAFCDFOAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5417C50", Offset = "0x5416850", VA = "0x185417C50")]
	public static GMBEEMHKFHH PCPJBNDHJEM(this MonoBehaviour HFNAEFAFGBI, Action LHPENGCHIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5417C20", Offset = "0x5416820", VA = "0x185417C20")]
	public static GMBEEMHKFHH MEDOBPPGIOJ(this MonoBehaviour HFNAEFAFGBI, Action LHPENGCHIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x5417C80", Offset = "0x5416880", VA = "0x185417C80")]
	public static GMBEEMHKFHH PHHPDLDCKNL(this MonoBehaviour HFNAEFAFGBI, Action LHPENGCHIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5417CB0", Offset = "0x54168B0", VA = "0x185417CB0")]
	private static GMBEEMHKFHH PPFNBLDHIHJ(MonoBehaviour HFNAEFAFGBI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL, Action LHPENGCHIMB, [Optional] DNDKFEJOEAD LIAFCDFOAIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x54179A0", Offset = "0x54165A0", VA = "0x1854179A0")]
	public static GMBEEMHKFHH KFHCGJKHOGJ(this MonoBehaviour HFNAEFAFGBI, float GKGAHFIHJON, Action LHPENGCHIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5417820", Offset = "0x5416420", VA = "0x185417820")]
	public static GMBEEMHKFHH GBLFLDMEOGN(this MonoBehaviour HFNAEFAFGBI, float GKGAHFIHJON, Action LHPENGCHIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5417720", Offset = "0x5416320", VA = "0x185417720")]
	public static GMBEEMHKFHH DKKMJNJOLHN(this MonoBehaviour HFNAEFAFGBI, float GKGAHFIHJON, Action LHPENGCHIMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5417A70", Offset = "0x5416670", VA = "0x185417A70")]
	public static GMBEEMHKFHH KPAKJCELMHA(this MonoBehaviour HFNAEFAFGBI, float GKGAHFIHJON, Action LHPENGCHIMB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public class BONDCCODACB : FDCAIGAABKH, IEnumerable<FDCAIGAABKH>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private readonly List<FDCAIGAABKH> LMHEPMHDAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private bool LPBKIMFDGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private Action PPJCHNHCKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool AMBENJLJONK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public bool INAEPMBANEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x541A4E0", Offset = "0x54190E0", VA = "0x18541A4E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action NFNHDJGJIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x541A620", Offset = "0x5419220", VA = "0x18541A620", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x541A740", Offset = "0x5419340", VA = "0x18541A740", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x541AC40", Offset = "0x5419840", VA = "0x18541AC40")]
	public BONDCCODACB([Optional] Action PPJCHNHCKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x541A3B0", Offset = "0x5418FB0", VA = "0x18541A3B0")]
	public void AABPNGPFBPJ(FDCAIGAABKH OEBHEJEJFHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x541A7E0", Offset = "0x54193E0", VA = "0x18541A7E0")]
	private void PDLDPELEDOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x541A950", Offset = "0x5419550", VA = "0x18541A950", Slot = "7")]
	public bool PLFPLIPCKDC(bool HLLKIIKCMBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x541A960", Offset = "0x5419560", VA = "0x18541A960", Slot = "8")]
	public bool PLFPLIPCKDC(Action MNJNLIAKBME, bool HLLKIIKCMBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x541A6C0", Offset = "0x54192C0", VA = "0x18541A6C0", Slot = "9")]
	public IEnumerator<FDCAIGAABKH> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x541A6C0", Offset = "0x54192C0", VA = "0x18541A6C0", Slot = "10")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public class BOEDGDBPNDF : MJCFJGCEFDA
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class CBMFBALJKKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public BOEDGDBPNDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public CBMFBALJKKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x541ACE0", Offset = "0x54198E0", VA = "0x18541ACE0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class DPMHHBGOEIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public BOEDGDBPNDF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public DPMHHBGOEIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x541ACE0", Offset = "0x54198E0", VA = "0x18541ACE0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly float CGDHGIFHMNB;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x541A2B0", Offset = "0x5418EB0", VA = "0x18541A2B0")]
	public BOEDGDBPNDF(Behaviour MAMKOIKAADI, float CGDHGIFHMNB, [Optional] Action PPJCHNHCKEJ, [Optional] DNDKFEJOEAD LIAFCDFOAIB, [Optional] KMFBLJKPAFJ HOHDFBKAGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x541A0B0", Offset = "0x5418CB0", VA = "0x18541A0B0", Slot = "9")]
	protected override bool GIIBICOPAOF(Action MNJNLIAKBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x541A1B0", Offset = "0x5418DB0", VA = "0x18541A1B0", Slot = "10")]
	protected override bool PPENDOONOPK(Action MNJNLIAKBME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public interface FDCAIGAABKH
{
	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	bool INAEPMBANEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action NFNHDJGJIKL;

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PLFPLIPCKDC(bool HLLKIIKCMBO = false);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool PLFPLIPCKDC(Action MNJNLIAKBME, bool HLLKIIKCMBO = false);
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public abstract class MJCFJGCEFDA : FDCAIGAABKH
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class COLBCHELBGD : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public MJCFJGCEFDA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public COLBCHELBGD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x541DA60", Offset = "0x541C660", VA = "0x18541DA60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x541DB30", Offset = "0x541C730", VA = "0x18541DB30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Behaviour MAMKOIKAADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly Action PPJCHNHCKEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private OOMGGIELMEK LDGKGEEEFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly DNDKFEJOEAD LIAFCDFOAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	protected readonly KMFBLJKPAFJ HOHDFBKAGBM;

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool INAEPMBANEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7E1990", Offset = "0x7E0590", VA = "0x1807E1990", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	public event Action NFNHDJGJIKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x542AEB0", Offset = "0x5429AB0", VA = "0x18542AEB0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x542AFF0", Offset = "0x5429BF0", VA = "0x18542AFF0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x542B400", Offset = "0x542A000", VA = "0x18542B400")]
	protected MJCFJGCEFDA(Behaviour MAMKOIKAADI, [Optional] Action PPJCHNHCKEJ, [Optional] DNDKFEJOEAD LIAFCDFOAIB, [Optional] KMFBLJKPAFJ HOHDFBKAGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x542B350", Offset = "0x5429F50", VA = "0x18542B350", Slot = "7")]
	public bool PLFPLIPCKDC(bool HLLKIIKCMBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x542B3B0", Offset = "0x5429FB0", VA = "0x18542B3B0", Slot = "8")]
	public bool PLFPLIPCKDC(Action MNJNLIAKBME, bool HLLKIIKCMBO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool GIIBICOPAOF(Action MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool PPENDOONOPK(Action MNJNLIAKBME);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x542AFD0", Offset = "0x5429BD0", VA = "0x18542AFD0")]
	protected void KHPNGAEDBEE(Action MNJNLIAKBME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x542B090", Offset = "0x5429C90", VA = "0x18542B090")]
	protected CKHAEIDHOPE NIALOJGJDHH(float FNJNHCECBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x542B2D0", Offset = "0x5429ED0", VA = "0x18542B2D0")]
	private void PJKGIOJAPNL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x542AF50", Offset = "0x5429B50", VA = "0x18542AF50")]
	[IteratorStateMachine(typeof(COLBCHELBGD))]
	private IEnumerator<FEPBFCLHFNJ> GNHCELIDFJO(float FNJNHCECBOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x542B290", Offset = "0x5429E90", VA = "0x18542B290")]
	[CompilerGenerated]
	private void NJMFGHIIGLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class OPFFPHILPFP : MJCFJGCEFDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly float JDLNMPJCGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly int FCNDMBDDKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private readonly float NNDNONKDNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly float[] HIHMPJDAEMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int CGIOFDLGMEM;

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x542D700", Offset = "0x542C300", VA = "0x18542D700")]
	public OPFFPHILPFP(Behaviour MAMKOIKAADI, float ADELCNJEOBG, int FCNDMBDDKON, [Optional] Action PPJCHNHCKEJ, float NNDNONKDNLN = 0f, [Optional] DNDKFEJOEAD LIAFCDFOAIB, [Optional] KMFBLJKPAFJ HOHDFBKAGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "9")]
	protected override bool GIIBICOPAOF(Action MNJNLIAKBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x542D4D0", Offset = "0x542C0D0", VA = "0x18542D4D0", Slot = "10")]
	protected override bool PPENDOONOPK(Action MNJNLIAKBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x542D440", Offset = "0x542C040", VA = "0x18542D440")]
	private void LOJOIKFCGPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public class LHNAOGFAJFJ : MJCFJGCEFDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private readonly float CGDHGIFHMNB;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x541A2B0", Offset = "0x5418EB0", VA = "0x18541A2B0")]
	public LHNAOGFAJFJ(Behaviour MAMKOIKAADI, float CGDHGIFHMNB, [Optional] Action PPJCHNHCKEJ, [Optional] DNDKFEJOEAD LIAFCDFOAIB, [Optional] KMFBLJKPAFJ HOHDFBKAGBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6AD8E0", Offset = "0x6AC4E0", VA = "0x1806AD8E0", Slot = "9")]
	protected override bool GIIBICOPAOF(Action MNJNLIAKBME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5428D70", Offset = "0x5427970", VA = "0x185428D70", Slot = "10")]
	protected override bool PPENDOONOPK(Action MNJNLIAKBME)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public sealed class LJNEFLLKIIH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[CompilerGenerated]
	private sealed class MOHHKKCCNBI : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public MOHHKKCCNBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x542B540", Offset = "0x542A140", VA = "0x18542B540", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x542B5E0", Offset = "0x542A1E0", VA = "0x18542B5E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private GMBEEMHKFHH DJLFOFKGDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private JPAFKFIHEAB MAMKOIKAADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private Action<float> EFFHGLJIBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private float ACMEBMPGGOI;

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5429A60", Offset = "0x5428660", VA = "0x185429A60")]
	public LJNEFLLKIIH(JPAFKFIHEAB MAMKOIKAADI, float NPFOCICFAEC, Action<float> KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x54298B0", Offset = "0x54284B0", VA = "0x1854298B0")]
	private void OMBIAFNIOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x54294D0", Offset = "0x54280D0", VA = "0x1854294D0")]
	private void AEIIEOJHACP(string CHGFDAMICCB, Action KCJLBLHOLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x5429840", Offset = "0x5428440", VA = "0x185429840")]
	[IteratorStateMachine(typeof(MOHHKKCCNBI))]
	private IEnumerator<FEPBFCLHFNJ> IKBMACEBLBG(Action KCJLBLHOLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x54297E0", Offset = "0x54283E0", VA = "0x1854297E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x5429630", Offset = "0x5428230", VA = "0x185429630")]
	[CompilerGenerated]
	private void AEKEIKKNFLA(string MPIBPKBJNBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public sealed class FIEELKIJNDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[CompilerGenerated]
	private sealed class PELDNCEMDIC : IEnumerator<FEPBFCLHFNJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private FEPBFCLHFNJ <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private FEPBFCLHFNJ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x737640", Offset = "0x736240", VA = "0x180737640")]
		[DebuggerHidden]
		public PELDNCEMDIC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x542DC00", Offset = "0x542C800", VA = "0x18542DC00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x542DCA0", Offset = "0x542C8A0", VA = "0x18542DCA0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private GMBEEMHKFHH DJLFOFKGDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private MonoBehaviour HFNAEFAFGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private Action KLNFHKKKGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private Action<float> EFFHGLJIBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private float ACMEBMPGGOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private bool HMLFFCMJDCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly DNDKFEJOEAD LIAFCDFOAIB;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5425270", Offset = "0x5423E70", VA = "0x185425270")]
	public FIEELKIJNDC(MonoBehaviour HFNAEFAFGBI, Action KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL, [Optional] DNDKFEJOEAD LIAFCDFOAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5425030", Offset = "0x5423C30", VA = "0x185425030")]
	public FIEELKIJNDC(MonoBehaviour HFNAEFAFGBI, Action<float> KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL, [Optional] DNDKFEJOEAD LIAFCDFOAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5424DD0", Offset = "0x54239D0", VA = "0x185424DD0")]
	public FIEELKIJNDC(MonoBehaviour HFNAEFAFGBI, float NPFOCICFAEC, Action<float> KLNFHKKKGLI, LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL, bool HMLFFCMJDCH = true, [Optional] DNDKFEJOEAD LIAFCDFOAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x54247F0", Offset = "0x54233F0", VA = "0x1854247F0")]
	private void GKKNFBBCPMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x5424960", Offset = "0x5423560", VA = "0x185424960")]
	private void HIPCHLGPMAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5424C10", Offset = "0x5423810", VA = "0x185424C10")]
	private void OMBIAFNIOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5424540", Offset = "0x5423140", VA = "0x185424540")]
	private void AEIIEOJHACP(string CHGFDAMICCB, Action KCJLBLHOLFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5424B10", Offset = "0x5423710", VA = "0x185424B10")]
	[IteratorStateMachine(typeof(PELDNCEMDIC))]
	private IEnumerator<FEPBFCLHFNJ> IKBMACEBLBG(Action KCJLBLHOLFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x5424790", Offset = "0x5423390", VA = "0x185424790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x5424670", Offset = "0x5423270", VA = "0x185424670")]
	[CompilerGenerated]
	private void BBLMJIBGEFH(string MPIBPKBJNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x5424B80", Offset = "0x5423780", VA = "0x185424B80")]
	[CompilerGenerated]
	private void NNDEKCCDDEB(string MPIBPKBJNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x5424700", Offset = "0x5423300", VA = "0x185424700")]
	[CompilerGenerated]
	private void BEIAOGIKCNC(string MPIBPKBJNBB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[Flags]
internal enum PGFPNLDIGMP : byte
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
internal sealed class NCMKCACFKKC : KMFBLJKPAFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float HIIDLCINHIN
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x542B960", Offset = "0x542A560", VA = "0x18542B960", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float EIMECFALHGM
	{
		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x542B970", Offset = "0x542A570", VA = "0x18542B970", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public double EDHPFDNJIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x542B980", Offset = "0x542A580", VA = "0x18542B980", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x542B8F0", Offset = "0x542A4F0", VA = "0x18542B8F0")]
	[JGJJPBKAAKL(HKPPGBCDEPD.None)]
	private static void CCOFINLLKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	[Preserve]
	internal NCMKCACFKKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal interface PPLNIDHELEF
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBNECJBFNMN(string MKPDFAEIFFO);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FFOEAMFLDDM();
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal interface KEOKHJGDMCK
{
	[Cpp2IlInjected.Token(Token = "0x17000029")]
	string JBHHONFDCDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OACPAKOIBBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool DOBODOKJDLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal class ACPMFABEJEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public COAMBHMGCAL AEEDJLHBODI;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public int KLCIKJBGNKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x7072B0", Offset = "0x705EB0", VA = "0x1807072B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x5416B80", Offset = "0x5415780", VA = "0x185416B80")]
	public static FEPBFCLHFNJ EIHKAKGPOHL(IEnumerator<FEPBFCLHFNJ> MGADLCLJIEF, PDAFNHLGDGC HJIKPPAKAGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x5416D30", Offset = "0x5415930", VA = "0x185416D30")]
	public FEPBFCLHFNJ EIHKAKGPOHL(PDAFNHLGDGC[] IDAEMNPFJIH, IEnumerator<FEPBFCLHFNJ>[] MINGDJHLCOL, FEPBFCLHFNJ[] JDBFLPFNCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x5416E10", Offset = "0x5415A10", VA = "0x185416E10")]
	public void JGIFJJGELKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5416F80", Offset = "0x5415B80", VA = "0x185416F80")]
	public void PNELHGGDDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5416E40", Offset = "0x5415A40", VA = "0x185416E40")]
	public void MACGGOBKBIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5416E10", Offset = "0x5415A10", VA = "0x185416E10")]
	public void OICILAKIGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public ACPMFABEJEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal sealed class COAMBHMGCAL
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public struct CMAJDOCPPPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public ACPMFABEJEM GHCPFILGDJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public JPAFKFIHEAB OLMLPIJJKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public PDAFNHLGDGC HLIOBLIGJGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public IEnumerator<FEPBFCLHFNJ> DDFJBCBFCPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public FEPBFCLHFNJ CJEOOJKEKON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public PGFPNLDIGMP DDGDPCIFAAL;
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct HPPPONKDMHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public LIIOGLHABAB.LCGNFGNPAPE JABOLFHOOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<CMAJDOCPPPA> FNDNBGOGNKA;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[CompilerGenerated]
	private sealed class LIMLCDJNBOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public COAMBHMGCAL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public JPAFKFIHEAB context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public ACPMFABEJEM routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public PGFPNLDIGMP coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public PDAFNHLGDGC promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public FEPBFCLHFNJ currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public IEnumerator<FEPBFCLHFNJ> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public LIMLCDJNBOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x5428DB0", Offset = "0x54279B0", VA = "0x185428DB0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class PBDAFGKLBDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public ACPMFABEJEM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public COAMBHMGCAL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public PBDAFGKLBDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x542DB30", Offset = "0x542C730", VA = "0x18542DB30")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class KCKFADHLLDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public ACPMFABEJEM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public COAMBHMGCAL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public KCKFADHLLDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5427ED0", Offset = "0x5426AD0", VA = "0x185427ED0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[CompilerGenerated]
	private sealed class MKKCGMFIDKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public ACPMFABEJEM schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public COAMBHMGCAL <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
		public MKKCGMFIDKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x542B500", Offset = "0x542A100", VA = "0x18542B500")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private const PGFPNLDIGMP ICCILCILJDO = PGFPNLDIGMP.Cancelled | PGFPNLDIGMP.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private bool[] AHGILGCIGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<PGFPNLDIGMP> NKPDEGFGBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float> EFCKDLIOBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> HNEKEOBBFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<int> JCIHJHFKIEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeArray<int> FMJMMLHEOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private NativeArray<int> AJKEOMAAGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private NativeArray<int> JGDEICPNHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private ACPMFABEJEM[] NCBAIKLEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private PDAFNHLGDGC[] IDAEMNPFJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private JPAFKFIHEAB[] HMLEAFNHIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private IEnumerator<FEPBFCLHFNJ>[] OHKJKPOKEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private FEPBFCLHFNJ[] ALMPIJFKHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private int OJKAFMBICFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private int KOHJKAOCDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly int ABEGDLHOKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private float GADCGEFLIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private DHEDNPNPDID OEAHBHGPNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private JobHandle JGDEIACLNED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private List<ACPMFABEJEM> DDJIGNJLFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private bool ADINCHNFMAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private List<Action> JLJNPGIPNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private List<Action> DHIJFAKHDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private bool LAGHJKIFGCF;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public HPPPONKDMHL[] LBKAIBCEICD
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x6DD2D0", Offset = "0x6DBED0", VA = "0x1806DD2D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x541D300", Offset = "0x541BF00", VA = "0x18541D300")]
	private static int MJEAJAPCJMH(LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x541D460", Offset = "0x541C060", VA = "0x18541D460")]
	public COAMBHMGCAL(LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x541C380", Offset = "0x541AF80", VA = "0x18541C380")]
	private void IHEOHGBGPEE(ref int FJJDBPJLPHI, int PBAHAOFGKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x541D100", Offset = "0x541BD00", VA = "0x18541D100")]
	public void KIFIFEOHBNA(JPAFKFIHEAB MAMKOIKAADI, FEPBFCLHFNJ HGMIJNNADPN, IEnumerator<FEPBFCLHFNJ> MGADLCLJIEF, PDAFNHLGDGC HJIKPPAKAGC, [Optional] ACPMFABEJEM BEALIFDMPGJ, PGFPNLDIGMP CFFFICGONFL = PGFPNLDIGMP.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x541BCC0", Offset = "0x541A8C0", VA = "0x18541BCC0")]
	public void FLGEOLMPKHB(IEnumerable<CMAJDOCPPPA> FFMOIBEEIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x541CBF0", Offset = "0x541B7F0", VA = "0x18541CBF0")]
	private CMAJDOCPPPA JFKKDDKDOAN(int JMFJPAACJJN)
	{
		return default(CMAJDOCPPPA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x541BFE0", Offset = "0x541ABE0", VA = "0x18541BFE0")]
	private void GPDMCKFCGNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x253C9D0", Offset = "0x253B5D0", VA = "0x18253C9D0")]
	private static void LAADMLLHAPO<T>(int JMFJPAACJJN, T[] NLFCPPMGIPB, int PJGFFECCBBF, [Optional] T DNGAAMGFIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x253C9B0", Offset = "0x253B5B0", VA = "0x18253C9B0")]
	private static void LAADMLLHAPO<T>(int JMFJPAACJJN, NativeArray<T> NLFCPPMGIPB, int PJGFFECCBBF, [Optional] T DNGAAMGFIHH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x541B3D0", Offset = "0x5419FD0", VA = "0x18541B3D0")]
	private void ANDGGPNOPGD(IEnumerable<CMAJDOCPPPA> FFMOIBEEIDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x541B9C0", Offset = "0x541A5C0", VA = "0x18541B9C0")]
	private void DNJPFOMIBML(CMAJDOCPPPA DCAGHBHCEHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x541B680", Offset = "0x541A280", VA = "0x18541B680")]
	private AMHELBELOII CCLBONBNBAN(int KKJPFCAOGEA)
	{
		return default(AMHELBELOII);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x541B1F0", Offset = "0x5419DF0", VA = "0x18541B1F0")]
	public void ADBAJIBKABO(float OMJIBKCGBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x541B940", Offset = "0x541A540", VA = "0x18541B940")]
	private void CGHHPFPBFGI(Action APGJBFJMIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x541D280", Offset = "0x541BE80", VA = "0x18541D280")]
	private void LECJFBPLOEC(Action APGJBFJMIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x541C570", Offset = "0x541B170", VA = "0x18541C570")]
	public void JAMBPKOGDAO(float OMJIBKCGBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x541BA90", Offset = "0x541A690", VA = "0x18541BA90")]
	public void EKCDHDCHCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x541D330", Offset = "0x541BF30", VA = "0x18541D330")]
	public void OICILAKIGII(ACPMFABEJEM OGEOADGLAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x541BEB0", Offset = "0x541AAB0", VA = "0x18541BEB0")]
	public void FLNABJMEOBF(ACPMFABEJEM OGEOADGLAKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x541BB90", Offset = "0x541A790", VA = "0x18541BB90")]
	public void FCIFOPLGOCF(ACPMFABEJEM OGEOADGLAKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class NGKKIHGEAJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static readonly NGKKIHGEAJP DIPMMBHCBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly Action EODOBJALAJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private bool LNPINMMGACJ;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	public NGKKIHGEAJP(Action EODOBJALAJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x542CD30", Offset = "0x542B930", VA = "0x18542CD30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public interface AGCJGNOCLOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	T FGHAAIAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GNEBEJIMGHF(UnityEngine.Object MAMKOIKAADI, Action<T> JGGAPCKMFNI);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public interface ICNMJGHKHAD<T> : global::AGCJGNOCLOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	new T FGHAAIAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PGMBNILFLIO<T> : global::ICNMJGHKHAD<T>, global::AGCJGNOCLOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private sealed class KHBMGIANEKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public global::PGMBNILFLIO<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public global::LBIBBDKENBP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x1C2A480", Offset = "0x1C29080", VA = "0x181C2A480")]
		public KHBMGIANEKM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x2D035D0", Offset = "0x2D021D0", VA = "0x182D035D0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private static GameObject DDEHPFKLHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<global::LBIBBDKENBP<UnityEngine.Object, Action<T>>> OMLLFIGLPHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private T GCPPGJJEKOO;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public T FGHAAIAMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x76C5D0", Offset = "0x76B1D0", VA = "0x18076C5D0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB460", Offset = "0x2DDA060", VA = "0x182DDB460", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB4C0", Offset = "0x2DDA0C0", VA = "0x182DDB4C0")]
	private static bool GFMHLPMNDGC(T APGJBFJMIBK, T APLKEMLCGID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBF90", Offset = "0x2DDAB90", VA = "0x182DDBF90")]
	public PGMBNILFLIO(T DANBIDJNNCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB6C0", Offset = "0x2DDA2C0", VA = "0x182DDB6C0", Slot = "6")]
	public IDisposable GNEBEJIMGHF(UnityEngine.Object MAMKOIKAADI, Action<T> JGGAPCKMFNI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBB90", Offset = "0x2DDA790", VA = "0x182DDBB90")]
	private void KGBAGIAAGAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal class JKJLCMKGDNF : KCHJNIMEJNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private readonly DNDKFEJOEAD LIAFCDFOAIB;

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x5427DC0", Offset = "0x54269C0", VA = "0x185427DC0")]
	[JGJJPBKAAKL(HKPPGBCDEPD.None)]
	private static void CCOFINLLKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	[Preserve]
	internal JKJLCMKGDNF([MLOIHELMKFH(null)] DNDKFEJOEAD LIAFCDFOAIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5427E30", Offset = "0x5426A30", VA = "0x185427E30", Slot = "4")]
	public IDisposable MHBKIGNJLNP(float NPFOCICFAEC, Action<float> JGLIBPMCCNL, bool HMLFFCMJDCH = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[BurstCompile]
internal struct DHEDNPNPDID : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	[ReadOnly]
	public float MNCOFONKOMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	[ReadOnly]
	public int MKAOHLBBFKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private NativeArray<int> IIIGHJCJFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private NativeArray<int> OGNKEEHCLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private NativeArray<int> ECLNHOHBCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	[ReadOnly]
	public NativeArray<PGFPNLDIGMP> GFFICCEBEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	[ReadOnly]
	public NativeArray<float> KPAOCCFKAAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	[WriteOnly]
	public NativeArray<int> FMJMMLHEOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	[WriteOnly]
	public NativeArray<int> HNEKEOBBFJD;

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5422AD0", Offset = "0x54216D0", VA = "0x185422AD0")]
	public static DHEDNPNPDID NBONEDNFGGC(int PCJELPMKCLK, float OMJIBKCGBMN, NativeArray<PGFPNLDIGMP> MBDIKGCNHNK, NativeArray<float> PDMAONJHEFO, NativeArray<int> DFJFDBCIELM, NativeArray<int> PHMMDMPPMFF, NativeArray<int> ABEBMJPJCDL, NativeArray<int> OGNKEEHCLKF, NativeArray<int> ECLNHOHBCOK)
	{
		return default(DHEDNPNPDID);
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x54228B0", Offset = "0x54214B0", VA = "0x1854228B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5422990", Offset = "0x5421590", VA = "0x185422990")]
	private bool GJJGIECJDHG(int KLEGICPDLIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x5422AA0", Offset = "0x54216A0", VA = "0x185422AA0")]
	private void IFDPFCDFECB(NativeArray<int> ICCAHAPBJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5422620", Offset = "0x5421220", VA = "0x185422620")]
	private int CDEHKDKHFLM(int MBOPGCEBHGD, int MEPKNANJOLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x54229D0", Offset = "0x54215D0", VA = "0x1854229D0")]
	private void IBANIKMMIJO(NativeArray<int> ICCAHAPBJMJ, int AOMALPIOKAM, int LGPJJHODLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5422680", Offset = "0x5421280", VA = "0x185422680")]
	private void DIDKAPLNBHD(NativeArray<int> ICCAHAPBJMJ, int MIIMFDDCJPN, int CKBLELMGAJG, int OGDKOAANAGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class LOHLGGGNNDN : BBMEHDOHKAG, DNDKFEJOEAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private COAMBHMGCAL[] OCBNCAIBANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private PPLNIDHELEF KNNDENMBJND;

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5429C50", Offset = "0x5428850", VA = "0x185429C50")]
	[JGJJPBKAAKL(HKPPGBCDEPD.None)]
	private static void CCOFINLLKDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x542A6A0", Offset = "0x54292A0", VA = "0x18542A6A0")]
	[Preserve]
	public LOHLGGGNNDN([MLOIHELMKFH(null)] IJLPCNEGILL FFANBMNOPBN, [MLOIHELMKFH(null)] KMFBLJKPAFJ HOHDFBKAGBM, [MLOIHELMKFH(null)] OJPMONPPFJB FFAMENHDMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x542A030", Offset = "0x5428C30", VA = "0x18542A030", Slot = "12")]
	public override GMBEEMHKFHH LJPABAOGCMI(JPAFKFIHEAB MAMKOIKAADI, IEnumerator<FEPBFCLHFNJ> EIAMDOLFJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x542A3C0", Offset = "0x5428FC0", VA = "0x18542A3C0", Slot = "13")]
	public override void PACBOHNGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5429D70", Offset = "0x5428970", VA = "0x185429D70", Slot = "15")]
	public override void FDPMLANDAPA(LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5429F50", Offset = "0x5428B50", VA = "0x185429F50", Slot = "14")]
	protected override void KLLCLICJMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5429CC0", Offset = "0x54288C0", VA = "0x185429CC0")]
	private COAMBHMGCAL DEJGAGPCCDI(LIIOGLHABAB.LCGNFGNPAPE JMPEGNOKOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x542A310", Offset = "0x5428F10", VA = "0x18542A310", Slot = "16")]
	internal override DKFCBPHAPHC OACPLAJAHKD(IEnumerator<FEPBFCLHFNJ> EIAMDOLFJPL, Behaviour MAMKOIKAADI, PDAFNHLGDGC HJIKPPAKAGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x542A2A0", Offset = "0x5428EA0", VA = "0x18542A2A0", Slot = "17")]
	internal override JEDPOHFDLLL NFOJACGDMEE(LIIOGLHABAB.LCGNFGNPAPE FFDFLABPLPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x542A170", Offset = "0x5428D70", VA = "0x18542A170")]
	private void LKHELOGFHEG(COAMBHMGCAL MMDBKEDOEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x5429D00", Offset = "0x5428900", VA = "0x185429D00", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class BBMEHDOHKAG : DNDKFEJOEAD, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly IJLPCNEGILL FFANBMNOPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	protected readonly KMFBLJKPAFJ HOHDFBKAGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly OJPMONPPFJB FFAMENHDMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private JEDPOHFDLLL[] FLHECBPDCKP;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static DNDKFEJOEAD OHEGMANNBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x5418810", Offset = "0x5417410", VA = "0x185418810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static bool MCPCPIJGIOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x6AD850", Offset = "0x6AC450", VA = "0x1806AD850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LIIOGLHABAB.LCGNFGNPAPE KMBLFMLHDJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x678060", Offset = "0x676C60", VA = "0x180678060", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(LIIOGLHABAB.LCGNFGNPAPE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x7072B0", Offset = "0x705EB0", VA = "0x1807072B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public KMFBLJKPAFJ ELPGPEBKLFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x698130", Offset = "0x696D30", VA = "0x180698130", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x54184B0", Offset = "0x54170B0", VA = "0x1854184B0")]
	public static GMBEEMHKFHH FKNHCELBMEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5418CB0", Offset = "0x54178B0", VA = "0x185418CB0")]
	[Preserve]
	protected BBMEHDOHKAG([MLOIHELMKFH(null)] IJLPCNEGILL FFANBMNOPBN, [MLOIHELMKFH(null)] KMFBLJKPAFJ HOHDFBKAGBM, [MLOIHELMKFH(null)] OJPMONPPFJB FFAMENHDMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x54185D0", Offset = "0x54171D0", VA = "0x1854185D0", Slot = "6")]
	public GMBEEMHKFHH LDJEMKIKHJD(IEnumerator<FEPBFCLHFNJ> EIAMDOLFJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x54185E0", Offset = "0x54171E0", VA = "0x1854185E0", Slot = "7")]
	public GMBEEMHKFHH LDJEMKIKHJD(Behaviour MAMKOIKAADI, IEnumerator<FEPBFCLHFNJ> EIAMDOLFJPL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract GMBEEMHKFHH LJPABAOGCMI(JPAFKFIHEAB MAMKOIKAADI, IEnumerator<FEPBFCLHFNJ> EIAMDOLFJPL);

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x5418900", Offset = "0x5417500", VA = "0x185418900", Slot = "13")]
	public virtual void PACBOHNGOLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x54188A0", Offset = "0x54174A0", VA = "0x1854188A0", Slot = "9")]
	public void OBMLHIDJAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x54185B0", Offset = "0x54171B0", VA = "0x1854185B0", Slot = "14")]
	protected virtual void KLLCLICJMAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5418860", Offset = "0x5417460", VA = "0x185418860")]
	private void LJDEHFEJEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x5418880", Offset = "0x5417480", VA = "0x185418880")]
	private void MKPMKJCKMEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5418570", Offset = "0x5417170", VA = "0x185418570")]
	private void IELHGHIGLPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5418490", Offset = "0x5417090", VA = "0x185418490")]
	private void FELMNNCJDGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5418230", Offset = "0x5416E30", VA = "0x185418230")]
	private void EKOGNHMMCEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5418550", Offset = "0x5417150", VA = "0x185418550")]
	private void GCJOHHPGKJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5418590", Offset = "0x5417190", VA = "0x185418590")]
	private void JDAEFDMBOFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5418250", Offset = "0x5416E50", VA = "0x185418250", Slot = "15")]
	public virtual void FDPMLANDAPA(LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5418AE0", Offset = "0x54176E0", VA = "0x185418AE0")]
	private void PBNGIDNBNEE(JEDPOHFDLLL MMDBKEDOEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1153520", Offset = "0x1152120", VA = "0x181153520")]
	private JEDPOHFDLLL NABNLLGGCJN(LIIOGLHABAB.LCGNFGNPAPE JMPEGNOKOOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract DKFCBPHAPHC OACPLAJAHKD(IEnumerator<FEPBFCLHFNJ> EIAMDOLFJPL, Behaviour HFNAEFAFGBI, PDAFNHLGDGC BFEGMAHNLIN);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract JEDPOHFDLLL NFOJACGDMEE(LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x5417EB0", Offset = "0x5416AB0", VA = "0x185417EB0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
internal sealed class DKFCBPHAPHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private readonly PDAFNHLGDGC HJIKPPAKAGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly KEOKHJGDMCK MAMKOIKAADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private readonly bool ODLOENFAJCO;

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerator<FEPBFCLHFNJ> DDFJBCBFCPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x695E40", Offset = "0x694A40", VA = "0x180695E40")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x695F10", Offset = "0x694B10", VA = "0x180695F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public FEPBFCLHFNJ CJEOOJKEKON
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x698140", Offset = "0x696D40", VA = "0x180698140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x69FA00", Offset = "0x69E600", VA = "0x18069FA00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool JEFMEHEDOHE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5422DF0", Offset = "0x54219F0", VA = "0x185422DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool CJAAGGEEEGG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x9461E0", Offset = "0x944DE0", VA = "0x1809461E0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x946240", Offset = "0x944E40", VA = "0x180946240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public string JBHHONFDCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x694E70", Offset = "0x693A70", VA = "0x180694E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x695830", Offset = "0x694430", VA = "0x180695830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public float DCMOEIBPFND
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x74B650", Offset = "0x74A250", VA = "0x18074B650")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x126A880", Offset = "0x1269480", VA = "0x18126A880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5423020", Offset = "0x5421C20", VA = "0x185423020")]
	public DKFCBPHAPHC(IEnumerator<FEPBFCLHFNJ> MGADLCLJIEF, KEOKHJGDMCK MAMKOIKAADI, PDAFNHLGDGC HJIKPPAKAGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5422B30", Offset = "0x5421730", VA = "0x185422B30")]
	public FEPBFCLHFNJ EIHKAKGPOHL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5422EF0", Offset = "0x5421AF0", VA = "0x185422EF0")]
	public bool PBHGIPMLFAG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5422E70", Offset = "0x5421A70", VA = "0x185422E70")]
	public void OICILAKIGII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5422F60", Offset = "0x5421B60", VA = "0x185422F60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x21A86B0", Offset = "0x21A72B0", VA = "0x1821A86B0")]
	[CompilerGenerated]
	private void PMDMACDINDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
internal sealed class PDAFNHLGDGC : JAMPPAHMOCC, GMBEEMHKFHH, OOMGGIELMEK, CKHAEIDHOPE, IEnumerator, FEPBFCLHFNJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private LIIOGLHABAB.LCGNFGNPAPE PGKDFPOHKDA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private LIIOGLHABAB.LCGNFGNPAPE HEBBAGJMAIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x731680", Offset = "0x730280", VA = "0x180731680", Slot = "23")]
		get
		{
			return default(LIIOGLHABAB.LCGNFGNPAPE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public LIIOGLHABAB.LCGNFGNPAPE AEEDJLHBODI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x77FBA0", Offset = "0x77E7A0", VA = "0x18077FBA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private float FKNLEABCGKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8311F0", Offset = "0x82FDF0", VA = "0x1808311F0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x542DB80", Offset = "0x542C780", VA = "0x18542DB80", Slot = "24")]
	private bool JOEMOGHNCFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x542DB70", Offset = "0x542C770", VA = "0x18542DB70", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x542DBA0", Offset = "0x542C7A0", VA = "0x18542DBA0")]
	public PDAFNHLGDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal enum AMHELBELOII : byte
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
internal sealed class JEDPOHFDLLL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public enum JCNNLCOGGJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public struct EOOEDDAHIMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		public LIIOGLHABAB.LCGNFGNPAPE JABOLFHOOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public JCNNLCOGGJB LHGFKLPANOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public List<DKFCBPHAPHC> NDDABFLEOED;
	}

	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private static readonly JCNNLCOGGJB[] PJKJPCOHBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private readonly LIIOGLHABAB.LCGNFGNPAPE IGFPHEFHIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool NMLINCHKDGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private readonly DKFCBPHAPHC[] ICHKEGECGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private readonly List<DKFCBPHAPHC> PFFCCFGFMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Stack<int> MPOJDAOCKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private readonly List<DKFCBPHAPHC> NCMGDOAFDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private readonly Stack<int> JLKFFDHEOJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private readonly PPLNIDHELEF NPAIGLNJLDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private bool LAGHJKIFGCF;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public EOOEDDAHIMA[,] BHNDLJPCPKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x69B9C0", Offset = "0x69A5C0", VA = "0x18069B9C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x54278F0", Offset = "0x54264F0", VA = "0x1854278F0")]
	public JEDPOHFDLLL(LIIOGLHABAB.LCGNFGNPAPE FFDFLABPLPF, PPLNIDHELEF NPAIGLNJLDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x54270B0", Offset = "0x5425CB0", VA = "0x1854270B0")]
	public void JANEFMIMCAH(DKFCBPHAPHC MGADLCLJIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x5426BC0", Offset = "0x54257C0", VA = "0x185426BC0")]
	public void GEFOELAFBEO(IList<DKFCBPHAPHC> MINGDJHLCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x54268F0", Offset = "0x54254F0", VA = "0x1854268F0")]
	public void FOOOPAIGLCJ(IList<DKFCBPHAPHC> MINGDJHLCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x54267F0", Offset = "0x54253F0", VA = "0x1854267F0")]
	private void FNOMCKDPFLO(DKFCBPHAPHC MGADLCLJIEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5426530", Offset = "0x5425130", VA = "0x185426530")]
	private void AAFJABJLAKF(IList<DKFCBPHAPHC> MINGDJHLCOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x54271D0", Offset = "0x5425DD0", VA = "0x1854271D0")]
	private AMHELBELOII JPPOMAOEPGK(DKFCBPHAPHC MGADLCLJIEF)
	{
		return default(AMHELBELOII);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5427370", Offset = "0x5425F70", VA = "0x185427370")]
	public void KLLCLICJMAF(float OMJIBKCGBMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x54274B0", Offset = "0x54260B0", VA = "0x1854274B0")]
	public void OBMLHIDJAKK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5426E90", Offset = "0x5425A90", VA = "0x185426E90")]
	private void IGHKJFDBOCM(List<DKFCBPHAPHC> MINGDJHLCOL, Stack<int> FFNLABPNINO, bool BECPJOAMPPB, float DKHPNBEHPDP = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x54266B0", Offset = "0x54252B0", VA = "0x1854266B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x54276C0", Offset = "0x54262C0", VA = "0x1854276C0")]
	private void OEALMKPJMGH(List<DKFCBPHAPHC> MINGDJHLCOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
internal class IIIAFEHKJAE : PPLNIDHELEF
{
	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "4")]
	public void CBNECJBFNMN(string MKPDFAEIFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x68B320", Offset = "0x689F20", VA = "0x18068B320", Slot = "5")]
	public void FFOEAMFLDDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x68ACD0", Offset = "0x6898D0", VA = "0x18068ACD0")]
	public IIIAFEHKJAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
internal class AFFAJOMEEJM : KEOKHJGDMCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	private readonly Behaviour HFNAEFAFGBI;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public string JBHHONFDCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5417120", Offset = "0x5415D20", VA = "0x185417120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OACPAKOIBBB
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x54170C0", Offset = "0x5415CC0", VA = "0x1854170C0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool DOBODOKJDLM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x54171B0", Offset = "0x5415DB0", VA = "0x1854171B0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x7343F0", Offset = "0x732FF0", VA = "0x1807343F0")]
	public AFFAJOMEEJM(Behaviour HFNAEFAFGBI)
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
