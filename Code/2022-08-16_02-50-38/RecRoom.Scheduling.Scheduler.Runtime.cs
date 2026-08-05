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
public class FLACBGEIPHO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority BPCDDLDIBIF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x478FD70", Offset = "0x478E970", VA = "0x18478FD70")]
	public FLACBGEIPHO(ThreadPriority GGCJPFHHPEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x478FD60", Offset = "0x478E960", VA = "0x18478FD60", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> AOHGOPOBMHE(List<PlayerLoopSystem> KIMBEGNMEAJ, int KLDALJBAGCE);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct HLBMHKPCNHH
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OMFMCFJOEHF
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static COJGPCFANME FNLOLPHBJKM;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x47983E0", Offset = "0x4796FE0", VA = "0x1847983E0")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct NCOKPLOIHFM
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static COJGPCFANME JMDIGPDMDOK;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4795BB0", Offset = "0x47947B0", VA = "0x184795BB0")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct PBLBLCCBBFI
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static COJGPCFANME OENOJJFIBCM;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x47994E0", Offset = "0x47980E0", VA = "0x1847994E0")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct MHHMCAJMOIN
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static COJGPCFANME MMBCHOAOJMJ;

				[Cpp2IlInjected.Token(Token = "0x400000D")]
				public static COJGPCFANME CGLEKLMPLMM;

				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static COJGPCFANME EJLONJOKLEP;

				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static COJGPCFANME EDNIONLIGAJ;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4795810", Offset = "0x4794410", VA = "0x184795810")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct AMDHPMBFFCL
			{
				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static COJGPCFANME PCHMANCLNIA;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x47882F0", Offset = "0x4786EF0", VA = "0x1847882F0")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct IKBIBHLIPPE
			{
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public static COJGPCFANME MMBCHOAOJMJ;

				[Cpp2IlInjected.Token(Token = "0x4000016")]
				public static COJGPCFANME CGLEKLMPLMM;

				[Cpp2IlInjected.Token(Token = "0x4000017")]
				public static COJGPCFANME EJLONJOKLEP;

				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public static COJGPCFANME EDNIONLIGAJ;

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x47941F0", Offset = "0x4792DF0", VA = "0x1847941F0")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct BDIMANBODMM
			{
				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static COJGPCFANME NLPECKGIALA;

				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0x4788D60", Offset = "0x4787960", VA = "0x184788D60")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct GJAICAFMJON
			{
				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static COJGPCFANME CAKAMMFMGAJ;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x4790500", Offset = "0x478F100", VA = "0x184790500")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct BBAPAOJGFBL
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				public static COJGPCFANME NCGOPHMFGMF;

				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x4788A60", Offset = "0x4787660", VA = "0x184788A60")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct HMEMPCCKMKJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static COJGPCFANME AOIHJBDDNLG;

				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x4793EB0", Offset = "0x4792AB0", VA = "0x184793EB0")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct IMCKGAHENMD
			{
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static COJGPCFANME PGDJGMIIEBH;

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x4794480", Offset = "0x4793080", VA = "0x184794480")]
				public static PlayerLoopSystem EMFAAHJBDJA()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001C")]
			internal struct AAPLIHOKOKD
			{
				[Cpp2IlInjected.Token(Token = "0x200001D")]
				[CompilerGenerated]
				private sealed class DFPBPJKFHHN
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002B")]
					public OECBLGAIEHH.HDAPOFMFMPK key;

					[Cpp2IlInjected.Token(Token = "0x6000048")]
					[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
					public DFPBPJKFHHN()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000049")]
					[Cpp2IlInjected.Address(RVA = "0x478D440", Offset = "0x478C040", VA = "0x18478D440")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static IDisposable IMHPDEANNAI;

				[Cpp2IlInjected.Token(Token = "0x6000047")]
				[Cpp2IlInjected.Address(RVA = "0x4787B30", Offset = "0x4786730", VA = "0x184787B30")]
				public static PlayerLoopSystem BEBCDCGMKCO(OECBLGAIEHH.HDAPOFMFMPK IHPCMBAPNMC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			internal struct KDJNGGLOGJM
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				[CompilerGenerated]
				private sealed class FFHNHJPCOEL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x400002C")]
					public OECBLGAIEHH.HDAPOFMFMPK key;

					[Cpp2IlInjected.Token(Token = "0x600004B")]
					[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
					public FFHNHJPCOEL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600004C")]
					[Cpp2IlInjected.Address(RVA = "0x478FB90", Offset = "0x478E790", VA = "0x18478FB90")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600004A")]
				[Cpp2IlInjected.Address(RVA = "0x4794650", Offset = "0x4793250", VA = "0x184794650")]
				public static PlayerLoopSystem BEBCDCGMKCO(OECBLGAIEHH.HDAPOFMFMPK IHPCMBAPNMC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class BCMACIFKOHA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
			public BCMACIFKOHA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x4788C60", Offset = "0x4787860", VA = "0x184788C60")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool OFHHHAJDHML;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool HMFPIFHPKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x478A5D0", Offset = "0x47891D0", VA = "0x18478A5D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x478C990", Offset = "0x478B590", VA = "0x18478C990")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x478A7E0", Offset = "0x47893E0", VA = "0x18478A7E0")]
		private static void HLFMMLIALEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x478C9D0", Offset = "0x478B5D0", VA = "0x18478C9D0")]
		private static void MNBKEFKBNEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x478D170", Offset = "0x478BD70", VA = "0x18478D170")]
		private static void PCOCNDLFPHJ(string JENKLDNJHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x478A3E0", Offset = "0x4788FE0", VA = "0x18478A3E0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x478A610", Offset = "0x4789210", VA = "0x18478A610")]
		private static void FILPIMHDMOJ(OECBLGAIEHH.HDAPOFMFMPK IHPCMBAPNMC, ref PlayerLoopSystem JOIEPHJBAII, Type ICILHDNJKCK, Type KCBLENGPFNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x478C4F0", Offset = "0x478B0F0", VA = "0x18478C4F0")]
		private static void KFKGBFNEMFK(ref PlayerLoopSystem JOIEPHJBAII, Type ICILHDNJKCK, Type KCBLENGPFNH, AOHGOPOBMHE AGFDPJKPEMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x478C870", Offset = "0x478B470", VA = "0x18478C870")]
		private static void LEEOIBKEEOF(ref PlayerLoopSystem JOIEPHJBAII, Type ICILHDNJKCK, Type KCBLENGPFNH, PlayerLoopSystem? IJMMCNLOJNL, PlayerLoopSystem? CMNINPKBLKG)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class OECBLGAIEHH
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum HDAPOFMFMPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		NetworkSendRecieve,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		LatePreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		FullPlayerLoop,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		OMPostGameplayUpdateSystem,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		OMPreRenderSystem,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		OMPostPhysicsFixedUpdateSystem
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class NFOCLGNGODC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly HDAPOFMFMPK GDICHOIJHAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public readonly OGPCKKMADLF AOJFMDBDCPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private long GHEBKHBNNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private long BONPBAMKKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public long HMKIHIKJOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int IJJKAJAJNJB;

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x4796020", Offset = "0x4794C20", VA = "0x184796020")]
		public NFOCLGNGODC(HDAPOFMFMPK KELMJIPNNIN, int KPIHKGGLAPH = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x4795D80", Offset = "0x4794980", VA = "0x184795D80")]
		public void AILPMGOIAAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x4795DF0", Offset = "0x47949F0", VA = "0x184795DF0")]
		public void GGAGAFFHFBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x4795E50", Offset = "0x4794A50", VA = "0x184795E50")]
		public void MKFJLLFANNJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static HDAPOFMFMPK[] ACPLJANFPBD;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static NFOCLGNGODC[] JDMOBMNKFJA;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4796F00", Offset = "0x4795B00", VA = "0x184796F00")]
	public static NFOCLGNGODC DCFBLNFPDPD(HDAPOFMFMPK IHPCMBAPNMC, int KPIHKGGLAPH = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x47970B0", Offset = "0x4795CB0", VA = "0x1847970B0")]
	public static NFOCLGNGODC DIDHMFHMKFD(HDAPOFMFMPK IHPCMBAPNMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4796E50", Offset = "0x4795A50", VA = "0x184796E50")]
	public static void AICKLHDPOMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class OGPCKKMADLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public int NEDHGNNNNBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private readonly Queue<double> DKEMACDKONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private double LAKDIHOJGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private double COIOJNIHJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private double LKKDDFPCGIM;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double BLDICJLDCFG
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4797A40", Offset = "0x4796640", VA = "0x184797A40", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4797B10", Offset = "0x4796710", VA = "0x184797B10")]
	public OGPCKKMADLF(int ILFAFMABHFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4797940", Offset = "0x4796540", VA = "0x184797940", Slot = "4")]
	public void CAKKHBCNKFN(double OFLCHCPLOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4797AA0", Offset = "0x47966A0", VA = "0x184797AA0", Slot = "5")]
	public void GGCMIAHONCL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public class PKCKNDEPBIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private long GCKMDOIKFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private double JBGPICEACEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private double LPDGDECNEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private double OHKDABBGEIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private double BLHIDMOONEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private double LAKDIHOJGNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private double COIOJNIHJPJ;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long JFMPCJJIJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double AMEJPMEIJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x3D77B50", Offset = "0x3D76750", VA = "0x183D77B50", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double KNNFMANCDDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA2A680", Offset = "0xA29280", VA = "0x180A2A680", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double BHEHOKJKGMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x38639B0", Offset = "0x38625B0", VA = "0x1838639B0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double BLDICJLDCFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x3CD2390", Offset = "0x3CD0F90", VA = "0x183CD2390", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x479A300", Offset = "0x4798F00", VA = "0x18479A300", Slot = "7")]
	public void CAKKHBCNKFN(double OFLCHCPLOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x479A420", Offset = "0x4799020", VA = "0x18479A420", Slot = "8")]
	public void GGCMIAHONCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x479A460", Offset = "0x4799060", VA = "0x18479A460")]
	public PKCKNDEPBIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class CHNHMGPLKKK
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	private interface OCOJHCJLGGP
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool KLFJDJHPADN
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HLHCNOFHMCO();
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private abstract class OAIOCBNLKKF<TPromise, TMainThreadPromise> : OCOJHCJLGGP where TPromise : IHEBICEMHFG where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly TPromise KPNHIGHCNPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		protected readonly TMainThreadPromise OCCBFOHKOKH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise ECENJKPGFAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x2CF7290", Offset = "0x2CF5E90", VA = "0x182CF7290")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KLFJDJHPADN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x2CF72F0", Offset = "0x2CF5EF0", VA = "0x182CF72F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x22B4380", Offset = "0x22B2F80", VA = "0x1822B4380")]
		protected OAIOCBNLKKF(TPromise KPNHIGHCNPB, TMainThreadPromise GJKGJFFCNIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7260", Offset = "0x2CF5E60", VA = "0x182CF7260", Slot = "5")]
		public void HLHCNOFHMCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void IGPEOEBAEIK(TPromise KPNHIGHCNPB);
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	private class NCPHLNGAPAN<T> : OAIOCBNLKKF<global::OEKDNOIOMEB<T>, global::DDFBBDKIGCD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2CF71C0", Offset = "0x2CF5DC0", VA = "0x182CF71C0")]
		public NCPHLNGAPAN(global::OEKDNOIOMEB<T> KPNHIGHCNPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6F90", Offset = "0x2CF5B90", VA = "0x182CF6F90", Slot = "6")]
		protected override void IGPEOEBAEIK(global::OEKDNOIOMEB<T> KPNHIGHCNPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2CF6F60", Offset = "0x2CF5B60", VA = "0x182CF6F60")]
		[CompilerGenerated]
		private void HNMBBDBODDP(T FADBLLIMALF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x2CF7190", Offset = "0x2CF5D90", VA = "0x182CF7190")]
		[CompilerGenerated]
		private void MGMCIJOKKCJ(string PBNGOGFENBC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	private class KIIJMIMLPJB : OCOJHCJLGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly Action FHCMCNABNIM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KLFJDJHPADN
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x719660", Offset = "0x718260", VA = "0x180719660")]
		public KIIJMIMLPJB(Action FHCMCNABNIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xE834A0", Offset = "0xE820A0", VA = "0x180E834A0", Slot = "5")]
		public void HLHCNOFHMCO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static readonly List<OCOJHCJLGGP> NLHGABDDJBE;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4F80", Offset = "0x1DF3B80", VA = "0x181DF4F80")]
	public static global::OEKDNOIOMEB<T> BMFLGEEELBN<T>(this global::OEKDNOIOMEB<T> KPNHIGHCNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4789430", Offset = "0x4788030", VA = "0x184789430")]
	public static void BMFLGEEELBN(Action FHCMCNABNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1DF4EC0", Offset = "0x1DF3AC0", VA = "0x181DF4EC0")]
	private static global::OEKDNOIOMEB<T> ANCAHMCGOIO<T>(global::OEKDNOIOMEB<T> KPNHIGHCNPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x47894C0", Offset = "0x47880C0", VA = "0x1847894C0")]
	private static void FMNAPMGPALL(OCOJHCJLGGP MFGBPMLBJHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x47896B0", Offset = "0x47882B0", VA = "0x1847896B0")]
	private static void JFAHAHHBPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4789A80", Offset = "0x4788680", VA = "0x184789A80")]
	private static void OCABHGELKOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x47899D0", Offset = "0x47885D0", VA = "0x1847899D0")]
	private static void JOOFKIPOLDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class EGBCGIJAKFI
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	private struct LMHKLALJMHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public TaskCompletionSource<Scene> AIEEKGPJFIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public readonly string FBFFICDCBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly LoadSceneMode IINLPKNMHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly bool IIDKEDHKCDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly JPHACOIJIFD NJKJPCGAGLF;

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x47951D0", Offset = "0x4793DD0", VA = "0x1847951D0")]
		public LMHKLALJMHE(TaskCompletionSource<Scene> CLJNKKJMBPK, string FBFFICDCBMO, LoadSceneMode IINLPKNMHCD, bool IIDKEDHKCDG, JPHACOIJIFD NJKJPCGAGLF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[CompilerGenerated]
	private struct CPIGOJIMBBC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public JPHACOIJIFD stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private global::BPGDCCMFEJP<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4789E30", Offset = "0x4788A30", VA = "0x184789E30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x478A390", Offset = "0x4788F90", VA = "0x18478A390", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private struct BKNMFCHELKE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x4789140", Offset = "0x4787D40", VA = "0x184789140", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8462E0", Offset = "0x844EE0", VA = "0x1808462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private struct AKHGBFEKGJO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private LMHKLALJMHE <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4787FE0", Offset = "0x4786BE0", VA = "0x184787FE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8462E0", Offset = "0x844EE0", VA = "0x1808462E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PIFHFPFCBPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public global::DDFBBDKIGCD<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public PIFHFPFCBPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x479A190", Offset = "0x4798D90", VA = "0x18479A190")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private struct GKMEEJAMENL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public JPHACOIJIFD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private PIFHFPFCBPF <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private JPHACOIJIFD <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private JPHACOIJIFD <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x47906D0", Offset = "0x478F2D0", VA = "0x1847906D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4790E90", Offset = "0x478FA90", VA = "0x184790E90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private struct PPAIAEGMBOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public JPHACOIJIFD stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private JPHACOIJIFD <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private JPHACOIJIFD <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x479A490", Offset = "0x4799090", VA = "0x18479A490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x479AB90", Offset = "0x4799790", VA = "0x18479AB90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class LHLEMFPPKCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public LHLEMFPPKCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x47951A0", Offset = "0x4793DA0", VA = "0x1847951A0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class MEPOMBDIBKP : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public DLLPNBKFAHM onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public MEPOMBDIBKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x4795570", Offset = "0x4794170", VA = "0x184795570", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x4795230", Offset = "0x4793E30", VA = "0x184795230", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x4795620", Offset = "0x4794220", VA = "0x184795620")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x4795520", Offset = "0x4794120", VA = "0x184795520", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ABMJHFLLMJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public global::DDFBBDKIGCD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public ABMJHFLLMJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class HCHIDMOAFIO : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public global::DDFBBDKIGCD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private ABMJHFLLMJP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public HCHIDMOAFIO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4792210", Offset = "0x4790E10", VA = "0x184792210", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x4792620", Offset = "0x4791220", VA = "0x184792620", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private static IHEBICEMHFG IJIBONAIBPP;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private static AsyncOperation JEJKAMCPCNP;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private static IHEBICEMHFG HHDCKDKNGGG;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private static string IHBGKOFLMJB;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private static ThreadPriority IEKJINAJOPG;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static Task PIOBIIAGFDA;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static readonly Queue<LMHKLALJMHE> CMPCPAFJMGI;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static Task KAINHFEFDCG;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool LDCLNMENHKM
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x478F6A0", Offset = "0x478E2A0", VA = "0x18478F6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool FLFCLFCDLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x478EEC0", Offset = "0x478DAC0", VA = "0x18478EEC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool BNIFLJMEGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x478E930", Offset = "0x478D530", VA = "0x18478E930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> IKGEOOCDCBM
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x478F180", Offset = "0x478DD80", VA = "0x18478F180")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x478E830", Offset = "0x478D430", VA = "0x18478E830")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x478F0B0", Offset = "0x478DCB0", VA = "0x18478F0B0")]
	[MLLBDNCHPEI(LJIBMCNOLHI.EnteredEditModeNextFrame, 0)]
	private static void IBOAGLFOFEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x478EF70", Offset = "0x478DB70", VA = "0x18478EF70")]
	[AsyncStateMachine(typeof(CPIGOJIMBBC))]
	public static Task<Scene> HNCMHIHGMNL(string FBFFICDCBMO, LoadSceneMode IINLPKNMHCD = LoadSceneMode.Single, bool IIDKEDHKCDG = false, [Optional] JPHACOIJIFD OOJOFPLGCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x478EC70", Offset = "0x478D870", VA = "0x18478EC70")]
	[AsyncStateMachine(typeof(BKNMFCHELKE))]
	private static Task EPKCIIHIGLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x478FA00", Offset = "0x478E600", VA = "0x18478FA00")]
	[AsyncStateMachine(typeof(AKHGBFEKGJO))]
	private static Task PNEBHPBGJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x478EB30", Offset = "0x478D730", VA = "0x18478EB30")]
	[AsyncStateMachine(typeof(GKMEEJAMENL))]
	private static Task<Scene> EOBODFEELFJ(string FBFFICDCBMO, LoadSceneMode IINLPKNMHCD, bool IIDKEDHKCDG, JPHACOIJIFD NJKJPCGAGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x478F8E0", Offset = "0x478E4E0", VA = "0x18478F8E0")]
	[AsyncStateMachine(typeof(PPAIAEGMBOB))]
	private static Task<Scene> PEEEAJOIHLK(JPHACOIJIFD NJKJPCGAGLF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x478ED50", Offset = "0x478D950", VA = "0x18478ED50")]
	public static global::OEKDNOIOMEB<Scene> FAPLCKPBGHA(string FBFFICDCBMO, LoadSceneMode IINLPKNMHCD = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x478F280", Offset = "0x478DE80", VA = "0x18478F280")]
	public static IHEBICEMHFG NLDNKELKINH(string FBFFICDCBMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x478E7A0", Offset = "0x478D3A0", VA = "0x18478E7A0")]
	[IteratorStateMachine(typeof(MEPOMBDIBKP))]
	private static IEnumerator<GGCFHHNCLAL> AHHEHOKJLIG(string FBFFICDCBMO, DLLPNBKFAHM NDPFDCHHCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x478F850", Offset = "0x478E450", VA = "0x18478F850")]
	[IteratorStateMachine(typeof(HCHIDMOAFIO))]
	private static IEnumerator<GGCFHHNCLAL> PDAMCKBPDNA(string FBFFICDCBMO, LoadSceneMode IINLPKNMHCD, global::DDFBBDKIGCD<Scene> NDPFDCHHCCI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x478E9E0", Offset = "0x478D5E0", VA = "0x18478E9E0")]
	public static bool DIECFIGCFIO(out string BLPFAJCDCMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public static class GLIEJPAFPDG
{
	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4790FE0", Offset = "0x478FBE0", VA = "0x184790FE0")]
	public static IDisposable JCICJAGBFKE(this MLNBJLGNJGF BGDHIGEIIHJ, float ONLHDKDKOLE, Action<float> OGFPOEEEHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4790F60", Offset = "0x478FB60", VA = "0x184790F60")]
	public static IDisposable HKAIKCKHNCB(this MLNBJLGNJGF BGDHIGEIIHJ, Action<float> OGFPOEEEHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4790EE0", Offset = "0x478FAE0", VA = "0x184790EE0")]
	public static IDisposable AGJJLAPMANG(this MLNBJLGNJGF BGDHIGEIIHJ, Action<float> OGFPOEEEHND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public static class PFFJLKJFJLO
{
	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4799EB0", Offset = "0x4798AB0", VA = "0x184799EB0")]
	public static IDisposable NNMPJKODFPC(this MonoBehaviour NMCNJGIBDPP, Action OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4799F30", Offset = "0x4798B30", VA = "0x184799F30")]
	public static IDisposable NNMPJKODFPC(this MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4799720", Offset = "0x4798320", VA = "0x184799720")]
	public static IDisposable ADGIMOCDCAK(this MonoBehaviour NMCNJGIBDPP, Action OGFPOEEEHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4799920", Offset = "0x4798520", VA = "0x184799920")]
	public static IDisposable DEBIHCNHLKN(this MonoBehaviour NMCNJGIBDPP, Action OGFPOEEEHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x47996B0", Offset = "0x47982B0", VA = "0x1847996B0")]
	public static IDisposable ABDMBINNLGJ(this MonoBehaviour NMCNJGIBDPP, Action OGFPOEEEHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x47998B0", Offset = "0x47984B0", VA = "0x1847998B0")]
	public static IDisposable CEBFNOEFDGF(this MonoBehaviour NMCNJGIBDPP, Action OGFPOEEEHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4799B40", Offset = "0x4798740", VA = "0x184799B40")]
	public static IDisposable JPECCCJKFMB(this MonoBehaviour NMCNJGIBDPP, Action OGFPOEEEHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4799E10", Offset = "0x4798A10", VA = "0x184799E10")]
	public static IDisposable NGBNKNAAAEA(this MonoBehaviour NMCNJGIBDPP, float ONLHDKDKOLE, Action<float> OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4799BB0", Offset = "0x47987B0", VA = "0x184799BB0")]
	public static IDisposable KDLCIGJCHJI(this MonoBehaviour NMCNJGIBDPP, float ONLHDKDKOLE, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4799C50", Offset = "0x4798850", VA = "0x184799C50")]
	public static IDisposable LCDJJOJJGNC(this MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x479A100", Offset = "0x4798D00", VA = "0x18479A100")]
	public static IDisposable PIKLCEAKOIF(this MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4799820", Offset = "0x4798420", VA = "0x184799820")]
	public static IDisposable BAADEDLCPFH(this MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4799790", Offset = "0x4798390", VA = "0x184799790")]
	public static IDisposable APFPDBBNENO(this MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4799A20", Offset = "0x4798620", VA = "0x184799A20")]
	public static IDisposable GLIJFALJEFF(this MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4799D80", Offset = "0x4798980", VA = "0x184799D80")]
	public static IDisposable MFCIIILADLE(this MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4799990", Offset = "0x4798590", VA = "0x184799990")]
	public static IDisposable EOBBNMPNOBD(this MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4799CE0", Offset = "0x47988E0", VA = "0x184799CE0")]
	public static IDisposable MAMJOMDNLEJ(this MonoBehaviour NMCNJGIBDPP, float ONLHDKDKOLE, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4799AB0", Offset = "0x47986B0", VA = "0x184799AB0")]
	public static IDisposable JHPJJEHPBCH(this MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class NILJBHPLJBN
{
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private sealed class MPBPCAFEICK : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public CCDBLMPDMPL.HICMAFGGBNF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private BAAACECKCJG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public MPBPCAFEICK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4795AA0", Offset = "0x47946A0", VA = "0x184795AA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4795B60", Offset = "0x4794760", VA = "0x184795B60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class HPNEHMCGPOD : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public CCDBLMPDMPL.HICMAFGGBNF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private BAAACECKCJG <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public HPNEHMCGPOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4794080", Offset = "0x4792C80", VA = "0x184794080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4794160", Offset = "0x4792D60", VA = "0x184794160", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x47962A0", Offset = "0x4794EA0", VA = "0x1847962A0")]
	public static ILEKNFOCKKN NNMPJKODFPC(Action OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4796210", Offset = "0x4794E10", VA = "0x184796210")]
	public static ILEKNFOCKKN NNMPJKODFPC(Behaviour BGDHIGEIIHJ, Action OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4796380", Offset = "0x4794F80", VA = "0x184796380")]
	public static ILEKNFOCKKN NNMPJKODFPC(Behaviour BGDHIGEIIHJ, Action<float> OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4796190", Offset = "0x4794D90", VA = "0x184796190")]
	[IteratorStateMachine(typeof(MPBPCAFEICK))]
	private static IEnumerator<GGCFHHNCLAL> LJNLNHIGPIO(CCDBLMPDMPL.HICMAFGGBNF CKOLLHBNDLG, Action OGFPOEEEHND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4796110", Offset = "0x4794D10", VA = "0x184796110")]
	[IteratorStateMachine(typeof(HPNEHMCGPOD))]
	private static IEnumerator<GGCFHHNCLAL> LJNLNHIGPIO(CCDBLMPDMPL.HICMAFGGBNF CKOLLHBNDLG, Action<float> OGFPOEEEHND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class OAAIDPONCAB
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class OHIOBGBKLGA : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public HLNLPBOKMBE schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public CCDBLMPDMPL.HICMAFGGBNF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private NOOIJBBHCGH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public OHIOBGBKLGA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4797BB0", Offset = "0x47967B0", VA = "0x184797BB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x4797CE0", Offset = "0x47968E0", VA = "0x184797CE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4796D70", Offset = "0x4795970", VA = "0x184796D70")]
	public static ILEKNFOCKKN NNMPJKODFPC(MonoBehaviour NMCNJGIBDPP, float ONLHDKDKOLE, Action<float> OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO, bool APIAPBHNNOP = true, [Optional] JPEKEAOOAPG JAOJAIJFNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4796BE0", Offset = "0x47957E0", VA = "0x184796BE0")]
	public static ILEKNFOCKKN JBIBNEBFPNK(MLNBJLGNJGF BGDHIGEIIHJ, float ONLHDKDKOLE, Action<float> OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO, bool APIAPBHNNOP = true, [Optional] JPEKEAOOAPG JAOJAIJFNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4796CC0", Offset = "0x47958C0", VA = "0x184796CC0")]
	[IteratorStateMachine(typeof(OHIOBGBKLGA))]
	private static IEnumerator<GGCFHHNCLAL> LJNLNHIGPIO(HLNLPBOKMBE IJACGBLKAEL, float ONLHDKDKOLE, CCDBLMPDMPL.HICMAFGGBNF CKOLLHBNDLG, Action<float> OGFPOEEEHND, bool APIAPBHNNOP = true, [Optional] JPEKEAOOAPG JAOJAIJFNGG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HGNLKOKKPHL
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class ADAKMEGJPJO : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public CCDBLMPDMPL.HICMAFGGBNF queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public ADAKMEGJPJO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x4787EE0", Offset = "0x4786AE0", VA = "0x184787EE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4787F90", Offset = "0x4786B90", VA = "0x184787F90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4793E30", Offset = "0x4792A30", VA = "0x184793E30")]
	[IteratorStateMachine(typeof(ADAKMEGJPJO))]
	private static IEnumerator<GGCFHHNCLAL> OPEKJALKJEL(CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO, Func<bool> IOMIFGMCDDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4793D50", Offset = "0x4792950", VA = "0x184793D50")]
	public static ILEKNFOCKKN GOOJAIMEMHM(this MonoBehaviour NMCNJGIBDPP, Func<bool> IOMIFGMCDDA, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO = CCDBLMPDMPL.HICMAFGGBNF.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class GGNJIEFAIEG
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class FFPFBAODOHE : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public CCDBLMPDMPL.HICMAFGGBNF queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public FFPFBAODOHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x478FC50", Offset = "0x478E850", VA = "0x18478FC50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x478FD10", Offset = "0x478E910", VA = "0x18478FD10", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x47903D0", Offset = "0x478EFD0", VA = "0x1847903D0")]
	[IteratorStateMachine(typeof(FFPFBAODOHE))]
	private static IEnumerator<GGCFHHNCLAL> NJNOOHFMDEN(float AKKLDMADENF, CCDBLMPDMPL.HICMAFGGBNF CKOLLHBNDLG, Action FOANONGBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4790210", Offset = "0x478EE10", VA = "0x184790210")]
	public static ILEKNFOCKKN MABDIPGDDCA(this MonoBehaviour NMCNJGIBDPP, float AKKLDMADENF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x478FEE0", Offset = "0x478EAE0", VA = "0x18478FEE0")]
	public static ILEKNFOCKKN ECBIDICLCBN(this MonoBehaviour NMCNJGIBDPP, Action FOANONGBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x47902A0", Offset = "0x478EEA0", VA = "0x1847902A0")]
	public static ILEKNFOCKKN MFCBLNAAFFD(this MonoBehaviour NMCNJGIBDPP, Action FOANONGBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4790010", Offset = "0x478EC10", VA = "0x184790010")]
	public static ILEKNFOCKKN HFCLJKKKBPE(this MonoBehaviour NMCNJGIBDPP, Action FOANONGBKAC, [Optional] JPEKEAOOAPG JAOJAIJFNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4790460", Offset = "0x478F060", VA = "0x184790460")]
	public static ILEKNFOCKKN OGECCJEPFAG(this MonoBehaviour NMCNJGIBDPP, Action FOANONGBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4790040", Offset = "0x478EC40", VA = "0x184790040")]
	public static ILEKNFOCKKN HKHDICFJBPA(this MonoBehaviour NMCNJGIBDPP, Action FOANONGBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4790170", Offset = "0x478ED70", VA = "0x184790170")]
	public static ILEKNFOCKKN LOBCCILNCED(this MonoBehaviour NMCNJGIBDPP, Action FOANONGBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x478FE40", Offset = "0x478EA40", VA = "0x18478FE40")]
	private static ILEKNFOCKKN BKIGINFPABK(MonoBehaviour NMCNJGIBDPP, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO, Action FOANONGBKAC, [Optional] JPEKEAOOAPG JAOJAIJFNGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4790340", Offset = "0x478EF40", VA = "0x184790340")]
	public static ILEKNFOCKKN MLBGKLJINJC(this MonoBehaviour NMCNJGIBDPP, float AGJHFEDINKB, Action FOANONGBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x478FF80", Offset = "0x478EB80", VA = "0x18478FF80")]
	public static ILEKNFOCKKN FIOGMLDADGB(this MonoBehaviour NMCNJGIBDPP, float AGJHFEDINKB, Action FOANONGBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x478FDB0", Offset = "0x478E9B0", VA = "0x18478FDB0")]
	public static ILEKNFOCKKN BFANHLKGKIA(this MonoBehaviour NMCNJGIBDPP, float AGJHFEDINKB, Action FOANONGBKAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x47900E0", Offset = "0x478ECE0", VA = "0x1847900E0")]
	public static ILEKNFOCKKN KPEPAHNLHNC(this MonoBehaviour NMCNJGIBDPP, float AGJHFEDINKB, Action FOANONGBKAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public class BKCGIBGDEKH : OGAPMMJLPKO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[CompilerGenerated]
	private sealed class BBDLEFNGNDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public BKCGIBGDEKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public BBDLEFNGNDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4788C30", Offset = "0x4787830", VA = "0x184788C30")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class FDCNICBJGLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public BKCGIBGDEKH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public FDCNICBJGLF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4788C30", Offset = "0x4787830", VA = "0x184788C30")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly float KKNFOKDLLIJ;

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x47890F0", Offset = "0x4787CF0", VA = "0x1847890F0")]
	public BKCGIBGDEKH(Behaviour BGDHIGEIIHJ, float KKNFOKDLLIJ, [Optional] Action ODNOFPGCAFI, [Optional] JPEKEAOOAPG JAOJAIJFNGG, [Optional] HLNLPBOKMBE IJACGBLKAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4789010", Offset = "0x4787C10", VA = "0x184789010", Slot = "9")]
	protected override bool HBIDALJHJNG(Action FHCMCNABNIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x4788F30", Offset = "0x4787B30", VA = "0x184788F30", Slot = "10")]
	protected override bool GHNPPEHPKAG(Action FHCMCNABNIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface DDGHNJPAGEF
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool CDNLEBHIKIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action BNLLDJGFFKD;

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HMALGIMIMCI(bool PPDFINNPBCJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HMALGIMIMCI(Action FHCMCNABNIM, bool PPDFINNPBCJ = false);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public abstract class OGAPMMJLPKO : DDGHNJPAGEF
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class PJBOMDHPHNN : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OGAPMMJLPKO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public PJBOMDHPHNN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x479A1E0", Offset = "0x4798DE0", VA = "0x18479A1E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x479A2B0", Offset = "0x4798EB0", VA = "0x18479A2B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private readonly Behaviour BGDHIGEIIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly Action ODNOFPGCAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private GLOMMMCGKDN JJEAOLIFIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly JPEKEAOOAPG JAOJAIJFNGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	protected readonly HLNLPBOKMBE IJACGBLKAEL;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool CDNLEBHIKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x7B10F0", Offset = "0x7AFCF0", VA = "0x1807B10F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action BNLLDJGFFKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4797260", Offset = "0x4795E60", VA = "0x184797260", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4797660", Offset = "0x4796260", VA = "0x184797660", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4797770", Offset = "0x4796370", VA = "0x184797770")]
	protected OGAPMMJLPKO(Behaviour BGDHIGEIIHJ, [Optional] Action ODNOFPGCAFI, [Optional] JPEKEAOOAPG JAOJAIJFNGG, [Optional] HLNLPBOKMBE IJACGBLKAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x47975C0", Offset = "0x47961C0", VA = "0x1847975C0", Slot = "7")]
	public bool HMALGIMIMCI(bool PPDFINNPBCJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4797570", Offset = "0x4796170", VA = "0x184797570", Slot = "8")]
	public bool HMALGIMIMCI(Action FHCMCNABNIM, bool PPDFINNPBCJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool HBIDALJHJNG(Action FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool GHNPPEHPKAG(Action FHCMCNABNIM);

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x47974D0", Offset = "0x47960D0", VA = "0x1847974D0")]
	protected void BFLIOCOOPBH(Action FHCMCNABNIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x4797300", Offset = "0x4795F00", VA = "0x184797300")]
	protected IHEBICEMHFG AOACFFNOBEI(float IFKOCEIICKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4797700", Offset = "0x4796300", VA = "0x184797700")]
	private void NAALJNIGOLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x47974F0", Offset = "0x47960F0", VA = "0x1847974F0")]
	[IteratorStateMachine(typeof(PJBOMDHPHNN))]
	private IEnumerator<GGCFHHNCLAL> EPHKJIADDNA(float IFKOCEIICKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4797620", Offset = "0x4796220", VA = "0x184797620")]
	[CompilerGenerated]
	private void JJCLKMMBMBP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class LBMNDPDAOIA : OGAPMMJLPKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private readonly float JBAHHNKCNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly int NOBLPKHDOMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private readonly float OOGDFHHFFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly float[] MLBPKFKAMAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private int IDNBLHDLLLC;

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4794A20", Offset = "0x4793620", VA = "0x184794A20")]
	public LBMNDPDAOIA(Behaviour BGDHIGEIIHJ, float POFANCNDDMP, int NOBLPKHDOMP, [Optional] Action ODNOFPGCAFI, float OOGDFHHFFKB = 0f, [Optional] JPEKEAOOAPG JAOJAIJFNGG, [Optional] HLNLPBOKMBE IJACGBLKAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "9")]
	protected override bool HBIDALJHJNG(Action FHCMCNABNIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4794800", Offset = "0x4793400", VA = "0x184794800", Slot = "10")]
	protected override bool GHNPPEHPKAG(Action FHCMCNABNIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x4794770", Offset = "0x4793370", VA = "0x184794770")]
	private void DIGCCJEPANI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class CLLBCFMJMEJ : OGAPMMJLPKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly float KKNFOKDLLIJ;

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x47890F0", Offset = "0x4787CF0", VA = "0x1847890F0")]
	public CLLBCFMJMEJ(Behaviour BGDHIGEIIHJ, float KKNFOKDLLIJ, [Optional] Action ODNOFPGCAFI, [Optional] JPEKEAOOAPG JAOJAIJFNGG, [Optional] HLNLPBOKMBE IJACGBLKAEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x5E4EC0", Offset = "0x5E3AC0", VA = "0x1805E4EC0", Slot = "9")]
	protected override bool HBIDALJHJNG(Action FHCMCNABNIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4789DF0", Offset = "0x47889F0", VA = "0x184789DF0", Slot = "10")]
	protected override bool GHNPPEHPKAG(Action FHCMCNABNIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public sealed class NLPOLEINPLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class CLDMPKONAFL : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public CLDMPKONAFL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4789CC0", Offset = "0x47888C0", VA = "0x184789CC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4789D60", Offset = "0x4788960", VA = "0x184789D60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private ILEKNFOCKKN ENEFJEIIJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private MLNBJLGNJGF BGDHIGEIIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Action<float> LBMBPJKKPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private float INFAENDFDJB;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x47968E0", Offset = "0x47954E0", VA = "0x1847968E0")]
	public NLPOLEINPLE(MLNBJLGNJGF BGDHIGEIIHJ, float ONLHDKDKOLE, Action<float> OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4796790", Offset = "0x4795390", VA = "0x184796790")]
	private void KAJJKDHJCJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4796680", Offset = "0x4795280", VA = "0x184796680")]
	private void IMIKKFEAPOH(string PBNGOGFENBC, Action CFCPCKAPNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4796460", Offset = "0x4795060", VA = "0x184796460")]
	[IteratorStateMachine(typeof(CLDMPKONAFL))]
	private IEnumerator<GGCFHHNCLAL> DFCGMLHJGPM(Action CFCPCKAPNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x47964D0", Offset = "0x47950D0", VA = "0x1847964D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4796530", Offset = "0x4795130", VA = "0x184796530")]
	[CompilerGenerated]
	private void FOAIFOLBONB(string NDHKDNBHBLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public sealed class GOKDFNNMCPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class EFCGKLKEFBI : IEnumerator<GGCFHHNCLAL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private GGCFHHNCLAL <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private GGCFHHNCLAL System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6F57D0", Offset = "0x6F43D0", VA = "0x1806F57D0")]
		[DebuggerHidden]
		public EFCGKLKEFBI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x478E6B0", Offset = "0x478D2B0", VA = "0x18478E6B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x478E750", Offset = "0x478D350", VA = "0x18478E750", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private ILEKNFOCKKN ENEFJEIIJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private MonoBehaviour NMCNJGIBDPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Action OGFPOEEEHND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private Action<float> LBMBPJKKPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private float INFAENDFDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool APIAPBHNNOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly JPEKEAOOAPG JAOJAIJFNGG;

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4791B10", Offset = "0x4790710", VA = "0x184791B10")]
	public GOKDFNNMCPK(MonoBehaviour NMCNJGIBDPP, Action OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO, [Optional] JPEKEAOOAPG JAOJAIJFNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4791960", Offset = "0x4790560", VA = "0x184791960")]
	public GOKDFNNMCPK(MonoBehaviour NMCNJGIBDPP, Action<float> OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO, [Optional] JPEKEAOOAPG JAOJAIJFNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4791790", Offset = "0x4790390", VA = "0x184791790")]
	public GOKDFNNMCPK(MonoBehaviour NMCNJGIBDPP, float ONLHDKDKOLE, Action<float> OGFPOEEEHND, CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO, bool APIAPBHNNOP = true, [Optional] JPEKEAOOAPG JAOJAIJFNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4791670", Offset = "0x4790270", VA = "0x184791670")]
	private void NNMPJKODFPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x47912B0", Offset = "0x478FEB0", VA = "0x1847912B0")]
	private void FCNMLOENHCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4791510", Offset = "0x4790110", VA = "0x184791510")]
	private void KAJJKDHJCJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4791400", Offset = "0x4790000", VA = "0x184791400")]
	private void IMIKKFEAPOH(string PBNGOGFENBC, Action CFCPCKAPNAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4791160", Offset = "0x478FD60", VA = "0x184791160")]
	[IteratorStateMachine(typeof(EFCGKLKEFBI))]
	private IEnumerator<GGCFHHNCLAL> DFCGMLHJGPM(Action CFCPCKAPNAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4791250", Offset = "0x478FE50", VA = "0x184791250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x47910E0", Offset = "0x478FCE0", VA = "0x1847910E0")]
	[CompilerGenerated]
	private void CNLCFGDAOGE(string NDHKDNBHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4791060", Offset = "0x478FC60", VA = "0x184791060")]
	[CompilerGenerated]
	private void CGOHCFJOAHI(string NDHKDNBHBLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x47911D0", Offset = "0x478FDD0", VA = "0x1847911D0")]
	[CompilerGenerated]
	private void DLGJGKHPNAF(string NDHKDNBHBLL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[Flags]
internal enum EMNHNDJFCGC : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
internal sealed class CJGNDEOEBBA : HLNLPBOKMBE
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public float AAJCKAGDMDG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x4789C90", Offset = "0x4788890", VA = "0x184789C90", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float KKGDKCKDPJI
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4789C80", Offset = "0x4788880", VA = "0x184789C80", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public double PFJEFBHGPPK
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4789CA0", Offset = "0x47888A0", VA = "0x184789CA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x4789BB0", Offset = "0x47887B0", VA = "0x184789BB0")]
	[DHIFEAMMLEG]
	private static void BCNEMBPOOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	[Preserve]
	internal CJGNDEOEBBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
internal interface IKFEKALLCMI
{
	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDEAIKCFFPB(string AMDKCMALAFD);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GDAKAOOGHNM();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
internal interface AEOGBAAFNFD
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	string JHKHALMBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool DIKPGGBGHKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool OLKPOPGECDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal class OMIMFJHDFEJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public AAJDGIGLCPN PMDABFBOJCI;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LEADIMEMNFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5E4ED0", Offset = "0x5E3AD0", VA = "0x1805E4ED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EE0", Offset = "0x5E3AE0", VA = "0x1805E4EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x47985B0", Offset = "0x47971B0", VA = "0x1847985B0")]
	public static GGCFHHNCLAL BLKPOEKJAGI(IEnumerator<GGCFHHNCLAL> NFNDCLNLNMD, MFGMINCEOLH FPDFPEPCDEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x4798710", Offset = "0x4797310", VA = "0x184798710")]
	public GGCFHHNCLAL BLKPOEKJAGI(MFGMINCEOLH[] POBLDOMPLAD, IEnumerator<GGCFHHNCLAL>[] IGCPEHGJPDP, GGCFHHNCLAL[] JCDNOEHFELD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x47988C0", Offset = "0x47974C0", VA = "0x1847988C0")]
	public void ENFCDJAEPLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x47987F0", Offset = "0x47973F0", VA = "0x1847987F0")]
	public void CGMNKODKJGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x47988F0", Offset = "0x47974F0", VA = "0x1847988F0")]
	public void ONPDGOMJJNH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x47988C0", Offset = "0x47974C0", VA = "0x1847988C0")]
	public void IADDGBBLMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public OMIMFJHDFEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class AAJDGIGLCPN
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public struct BEKANBIIJHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public OMIMFJHDFEJ OLBODBIGJBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public MLNBJLGNJGF AFIMKBBDAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public MFGMINCEOLH IAJPBKAIKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public IEnumerator<GGCFHHNCLAL> CBOHAIOBKLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public GGCFHHNCLAL KHONKNLIKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public EMNHNDJFCGC PKBPHINHELD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct IOPCCCPMOMI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public CCDBLMPDMPL.HICMAFGGBNF LDMGBGAPOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public List<BEKANBIIJHF> EOAFEGPHFCL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class OLCCDIDOODD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public AAJDGIGLCPN <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public MLNBJLGNJGF context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public OMIMFJHDFEJ routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public EMNHNDJFCGC coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public MFGMINCEOLH promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public GGCFHHNCLAL currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public IEnumerator<GGCFHHNCLAL> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public OLCCDIDOODD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x4797D30", Offset = "0x4796930", VA = "0x184797D30")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class EEAJONDHGDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public OMIMFJHDFEJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public AAJDGIGLCPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public EEAJONDHGDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x478E670", Offset = "0x478D270", VA = "0x18478E670")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[CompilerGenerated]
	private sealed class CLKMIFKHEAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public OMIMFJHDFEJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public AAJDGIGLCPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public CLKMIFKHEAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x4789DB0", Offset = "0x47889B0", VA = "0x184789DB0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class IFAHFABFMGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public OMIMFJHDFEJ schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public AAJDGIGLCPN <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
		public IFAHFABFMGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x47941B0", Offset = "0x4792DB0", VA = "0x1847941B0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const EMNHNDJFCGC HCNCOCBIKAA = EMNHNDJFCGC.Cancelled | EMNHNDJFCGC.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private bool[] CMMCADEDKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<EMNHNDJFCGC> MJCAHJAAHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeArray<float> MBIAGBJJCNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NativeArray<int> MOGKNOGFHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> CPJLELLLDEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private NativeArray<int> LAOKCCHKING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private NativeArray<int> JCDNDJMKNBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private NativeArray<int> EFFHNGPOBKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private OMIMFJHDFEJ[] AFIKFEGAKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private MFGMINCEOLH[] POBLDOMPLAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private MLNBJLGNJGF[] EANPAJAECAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private IEnumerator<GGCFHHNCLAL>[] EILMGFABFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private GGCFHHNCLAL[] GADCGJHEOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private int FINBOMOFIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int EFOLPOOCAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly int MOEHNNDFGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float MHIHLAOMEHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private HCFAOHEPNCG FCINHFMODEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private JobHandle NKPFNEFEGFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private List<OMIMFJHDFEJ> HPCEIKOGIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private bool DBPIBFEHKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private List<Action> BBABHCPJMNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private List<Action> PDKDEKMPNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private bool NAAGAJOPHGM;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public IOPCCCPMOMI[] IECINDFOCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x12139F0", Offset = "0x12125F0", VA = "0x1812139F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4787300", Offset = "0x4785F00", VA = "0x184787300")]
	private static int LBNENFGAHHD(CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x47875D0", Offset = "0x47861D0", VA = "0x1847875D0")]
	public AAJDGIGLCPN(CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x4786200", Offset = "0x4784E00", VA = "0x184786200")]
	private void BDANGHNNMFD(ref int BAMCJKHOOMH, int DHMHIDKNGBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x4787330", Offset = "0x4785F30", VA = "0x184787330")]
	public void MNPLPCDAOGM(MLNBJLGNJGF BGDHIGEIIHJ, GGCFHHNCLAL GKMNGPBKLGO, IEnumerator<GGCFHHNCLAL> NFNDCLNLNMD, MFGMINCEOLH FPDFPEPCDEA, [Optional] OMIMFJHDFEJ LBMKFMKBBDC, EMNHNDJFCGC AFCDDLAIDAJ = EMNHNDJFCGC.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x4786710", Offset = "0x4785310", VA = "0x184786710")]
	public void FFCBNOPDCNH(IEnumerable<BEKANBIIJHF> GDNBMCKJDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4786DA0", Offset = "0x47859A0", VA = "0x184786DA0")]
	private BEKANBIIJHF JMCIONKFJIF(int EACOFFFKJEM)
	{
		return default(BEKANBIIJHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4785CA0", Offset = "0x47848A0", VA = "0x184785CA0")]
	private void AMMGJOJKIGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x1F91FF0", Offset = "0x1F90BF0", VA = "0x181F91FF0")]
	private static void DKAJEIKHKLI<T>(int EACOFFFKJEM, T[] FHDELKKNHEL, int AABEJHHLOHL, [Optional] T DELFDEMCEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x1F91FD0", Offset = "0x1F90BD0", VA = "0x181F91FD0")]
	private static void DKAJEIKHKLI<T>(int EACOFFFKJEM, NativeArray<T> FHDELKKNHEL, int AABEJHHLOHL, [Optional] T DELFDEMCEDL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x47869C0", Offset = "0x47855C0", VA = "0x1847869C0")]
	private void HJDBCPBNNBA(IEnumerable<BEKANBIIJHF> GDNBMCKJDMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4786650", Offset = "0x4785250", VA = "0x184786650")]
	private void CNKPBJPIEGJ(BEKANBIIJHF NPCCOEFDBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4786390", Offset = "0x4784F90", VA = "0x184786390")]
	private DALOIIFCJFC BOHKHDIMHFM(int COEDMNNIJFB)
	{
		return default(DALOIIFCJFC);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4786010", Offset = "0x4784C10", VA = "0x184786010")]
	public void ANFDECHBKHM(float IHCDICENJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4786D20", Offset = "0x4785920", VA = "0x184786D20")]
	private void JLIFCLJPKKB(Action GBHOMBFJPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4787490", Offset = "0x4786090", VA = "0x184787490")]
	private void OJDGONANCLJ(Action GBHOMBFJPAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4785800", Offset = "0x4784400", VA = "0x184785800")]
	public void AGBGHHOGPIE(float IHCDICENJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4787220", Offset = "0x4785E20", VA = "0x184787220")]
	public void KHFNNCAMANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4786C60", Offset = "0x4785860", VA = "0x184786C60")]
	public void IADDGBBLMIP(OMIMFJHDFEJ ECIKODLJAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4786900", Offset = "0x4785500", VA = "0x184786900")]
	public void HBOKHJIOCFA(OMIMFJHDFEJ ECIKODLJAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4787510", Offset = "0x4786110", VA = "0x184787510")]
	public void OOHELDENFOF(OMIMFJHDFEJ ECIKODLJAKA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DMLNIANFMFA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static readonly DMLNIANFMFA INHNAJHBIEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly Action KKPNMHGEAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private bool KCKLADPBJBF;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x719660", Offset = "0x718260", VA = "0x180719660")]
	public DMLNIANFMFA(Action KKPNMHGEAJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x478E570", Offset = "0x478D170", VA = "0x18478E570", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public interface GKGIAPFPENI<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	T CFABBBMGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable HDKDFBNPDDM(UnityEngine.Object BGDHIGEIIHJ, Action<T> ADIMPGCEHAM);
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public interface JMFKMFMBFIN<T> : global::GKGIAPFPENI<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	new T CFABBBMGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class LLAJJCNNJAE<T> : global::JMFKMFMBFIN<T>, global::GKGIAPFPENI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[CompilerGenerated]
	private sealed class PKLDKNANDDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public global::LLAJJCNNJAE<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public global::GGFBDHJCLEA<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1E1EC80", Offset = "0x1E1D880", VA = "0x181E1EC80")]
		public PKLDKNANDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x34EFCB0", Offset = "0x34EE8B0", VA = "0x1834EFCB0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static GameObject PHJMCKCCHMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly List<global::GGFBDHJCLEA<UnityEngine.Object, Action<T>>> DDOGKIGAHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private T HPDABEOKPOH;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T CFABBBMGOIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x712FE0", Offset = "0x711BE0", VA = "0x180712FE0", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x34E7530", Offset = "0x34E6130", VA = "0x1834E7530", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x34E7880", Offset = "0x34E6480", VA = "0x1834E7880")]
	private static bool IABLBMJCANF(T GBHOMBFJPAG, T DBJNEGCCKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x34E78E0", Offset = "0x34E64E0", VA = "0x1834E78E0")]
	public LLAJJCNNJAE(T NKGJGLOCODP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x34E76F0", Offset = "0x34E62F0", VA = "0x1834E76F0", Slot = "6")]
	public IDisposable HDKDFBNPDDM(UnityEngine.Object BGDHIGEIIHJ, Action<T> ADIMPGCEHAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x34E6E70", Offset = "0x34E5A70", VA = "0x1834E6E70")]
	private void ACBBHEGEFHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
internal class NNPECLGCMNE : FBBJHDNOHJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private readonly JPEKEAOOAPG JAOJAIJFNGG;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4796A70", Offset = "0x4795670", VA = "0x184796A70")]
	[DHIFEAMMLEG]
	private static void BCNEMBPOOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x719660", Offset = "0x718260", VA = "0x180719660")]
	[Preserve]
	internal NNPECLGCMNE([MKAKJMIGCBM(null)] JPEKEAOOAPG JAOJAIJFNGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4796B40", Offset = "0x4795740", VA = "0x184796B40", Slot = "4")]
	public IDisposable KDLCIGJCHJI(float ONLHDKDKOLE, Action<float> HGFJMMOGKFF, bool APIAPBHNNOP = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[BurstCompile]
internal struct HCFAOHEPNCG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	[ReadOnly]
	public float NJEABOIEGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	[ReadOnly]
	public int MPCGLMIPAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private NativeArray<int> LHLGEMNIGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private NativeArray<int> FOMFFBBJGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private NativeArray<int> CPAIHJNHIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	[ReadOnly]
	public NativeArray<EMNHNDJFCGC> GCJMFBOAKKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	[ReadOnly]
	public NativeArray<float> JMDDOENICLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	[WriteOnly]
	public NativeArray<int> LAOKCCHKING;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	[WriteOnly]
	public NativeArray<int> MOGKNOGFHCN;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4792140", Offset = "0x4790D40", VA = "0x184792140")]
	public static HCFAOHEPNCG NEKFKHFNPIG(int CEJEHOMCONJ, float IHCDICENJEH, NativeArray<EMNHNDJFCGC> DMIFKHNKCHM, NativeArray<float> HPPHDMMMBON, NativeArray<int> MHJCGEBDJGF, NativeArray<int> OEDNPMGPPJM, NativeArray<int> EPODGBFPCFH, NativeArray<int> FOMFFBBJGEF, NativeArray<int> CPAIHJNHIIM)
	{
		return default(HCFAOHEPNCG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4791EE0", Offset = "0x4790AE0", VA = "0x184791EE0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4792090", Offset = "0x4790C90", VA = "0x184792090")]
	private bool IHFHEONIGOJ(int BAOHKIGDOBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4791C80", Offset = "0x4790880", VA = "0x184791C80")]
	private void AJKLLPEHADN(NativeArray<int> IEJJMAPBINM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x47920D0", Offset = "0x4790CD0", VA = "0x1847920D0")]
	private int KOMCPAKJPOG(int NHMEFHPMNFG, int NNAJLJGODKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4791FC0", Offset = "0x4790BC0", VA = "0x184791FC0")]
	private void FBNPHDMLKPC(NativeArray<int> IEJJMAPBINM, int OPGHPKNAGGI, int AMIMMKNIBKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x4791CB0", Offset = "0x47908B0", VA = "0x184791CB0")]
	private void BMFGACCADHF(NativeArray<int> IEJJMAPBINM, int OJOIFEBCMLM, int DJLABONCAIA, int AHEFBOGLHMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class PADPKJECKPP : DLEOMJPCNCB, JPEKEAOOAPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private AAJDGIGLCPN[] MODNPLBODHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private IKFEKALLCMI NEJLNNKDDCC;

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4798AA0", Offset = "0x47976A0", VA = "0x184798AA0")]
	[DHIFEAMMLEG]
	private static void BCNEMBPOOBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4799420", Offset = "0x4798020", VA = "0x184799420")]
	[Preserve]
	public PADPKJECKPP([MKAKJMIGCBM(null)] FBPFPJOENID NLOJFDIBFIN, [MKAKJMIGCBM(null)] HLNLPBOKMBE IJACGBLKAEL, [MKAKJMIGCBM(null)] OIECEJFFEHK NFDECNEMLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x47990E0", Offset = "0x4797CE0", VA = "0x1847990E0", Slot = "12")]
	public override ILEKNFOCKKN LIECFMEKMFK(MLNBJLGNJGF BGDHIGEIIHJ, IEnumerator<GGCFHHNCLAL> ENKECIKCHDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4798C50", Offset = "0x4797850", VA = "0x184798C50", Slot = "13")]
	public override void GGCMIAHONCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4798F10", Offset = "0x4797B10", VA = "0x184798F10", Slot = "15")]
	public override void IIHCEGMLGDE(CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x47989C0", Offset = "0x47975C0", VA = "0x1847989C0", Slot = "14")]
	protected override void ADGIMOCDCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x47992C0", Offset = "0x4797EC0", VA = "0x1847992C0")]
	private AAJDGIGLCPN NICAIGPOBAA(CCDBLMPDMPL.HICMAFGGBNF HCPDGKICMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x4799210", Offset = "0x4797E10", VA = "0x184799210", Slot = "16")]
	internal override LCNJCLIBDCI LKMHLNCJJPP(IEnumerator<GGCFHHNCLAL> ENKECIKCHDG, Behaviour BGDHIGEIIHJ, MFGMINCEOLH FPDFPEPCDEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4798B70", Offset = "0x4797770", VA = "0x184798B70", Slot = "17")]
	internal override HGCIDHFAAAE DFJLMOKLBBH(CCDBLMPDMPL.HICMAFGGBNF CKOLLHBNDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x4799300", Offset = "0x4797F00", VA = "0x184799300")]
	private void NOCELEPIIJN(AAJDGIGLCPN FPCECKGMHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4798BE0", Offset = "0x47977E0", VA = "0x184798BE0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public abstract class DLEOMJPCNCB : JPEKEAOOAPG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly FBPFPJOENID NLOJFDIBFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	protected readonly HLNLPBOKMBE IJACGBLKAEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private readonly OIECEJFFEHK NFDECNEMLAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private HGCIDHFAAAE[] DGCMGMMLGIM;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static JPEKEAOOAPG PPLIIACIKDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x478D8A0", Offset = "0x478C4A0", VA = "0x18478D8A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool MNFBOODMLPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5E4FE0", Offset = "0x5E3BE0", VA = "0x1805E4FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CCDBLMPDMPL.HICMAFGGBNF AENEGBGENCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5E4ED0", Offset = "0x5E3AD0", VA = "0x1805E4ED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CCDBLMPDMPL.HICMAFGGBNF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5E4EE0", Offset = "0x5E3AE0", VA = "0x1805E4EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public HLNLPBOKMBE CKLEEMNMNAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DF0", Offset = "0x5E59F0", VA = "0x1805E6DF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x478DD00", Offset = "0x478C900", VA = "0x18478DD00")]
	public static ILEKNFOCKKN IBMEFNLADNL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x478E280", Offset = "0x478CE80", VA = "0x18478E280")]
	[Preserve]
	protected DLEOMJPCNCB([MKAKJMIGCBM(null)] FBPFPJOENID NLOJFDIBFIN, [MKAKJMIGCBM(null)] HLNLPBOKMBE IJACGBLKAEL, [MKAKJMIGCBM(null)] OIECEJFFEHK NFDECNEMLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x478E010", Offset = "0x478CC10", VA = "0x18478E010", Slot = "6")]
	public ILEKNFOCKKN LOAMCCKKBNA(IEnumerator<GGCFHHNCLAL> ENKECIKCHDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x478E020", Offset = "0x478CC20", VA = "0x18478E020", Slot = "7")]
	public ILEKNFOCKKN LOAMCCKKBNA(Behaviour BGDHIGEIIHJ, IEnumerator<GGCFHHNCLAL> ENKECIKCHDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract ILEKNFOCKKN LIECFMEKMFK(MLNBJLGNJGF BGDHIGEIIHJ, IEnumerator<GGCFHHNCLAL> ENKECIKCHDG);

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x478D960", Offset = "0x478C560", VA = "0x18478D960", Slot = "13")]
	public virtual void GGCMIAHONCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x478D530", Offset = "0x478C130", VA = "0x18478D530", Slot = "9")]
	public void AMDIPKFFIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x478D510", Offset = "0x478C110", VA = "0x18478D510", Slot = "14")]
	protected virtual void ADGIMOCDCAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x478DFD0", Offset = "0x478CBD0", VA = "0x18478DFD0")]
	private void JMDIGPDMDOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x478E260", Offset = "0x478CE60", VA = "0x18478E260")]
	private void OENOJJFIBCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x478D5B0", Offset = "0x478C1B0", VA = "0x18478D5B0")]
	private void DEBIHCNHLKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x478D4F0", Offset = "0x478C0F0", VA = "0x18478D4F0")]
	private void ABDMBINNLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x478E240", Offset = "0x478CE40", VA = "0x18478E240")]
	private void NLPECKGIALA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x478D590", Offset = "0x478C190", VA = "0x18478D590")]
	private void CAKAMMFMGAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x478DFF0", Offset = "0x478CBF0", VA = "0x18478DFF0")]
	private void LJEPFOIPNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x478DDA0", Offset = "0x478C9A0", VA = "0x18478DDA0", Slot = "15")]
	public virtual void IIHCEGMLGDE(CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x478DB40", Offset = "0x478C740", VA = "0x18478DB40")]
	private void HBBCEJLAMMD(HGCIDHFAAAE FPCECKGMHLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x831100", Offset = "0x82FD00", VA = "0x180831100")]
	private HGCIDHFAAAE PJMFGKABJMP(CCDBLMPDMPL.HICMAFGGBNF HCPDGKICMEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract LCNJCLIBDCI LKMHLNCJJPP(IEnumerator<GGCFHHNCLAL> ENKECIKCHDG, Behaviour NMCNJGIBDPP, MFGMINCEOLH OOIJGOECNPN);

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract HGCIDHFAAAE DFJLMOKLBBH(CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO);

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x478D5D0", Offset = "0x478C1D0", VA = "0x18478D5D0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
internal sealed class LCNJCLIBDCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly MFGMINCEOLH FPDFPEPCDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly AEOGBAAFNFD BGDHIGEIIHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private readonly bool FDPLDDEDGID;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerator<GGCFHHNCLAL> CBOHAIOBKLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E41D0", Offset = "0x5E2DD0", VA = "0x1805E41D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E4490", Offset = "0x5E3090", VA = "0x1805E4490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public GGCFHHNCLAL KHONKNLIKIO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E41C0", Offset = "0x5E2DC0", VA = "0x1805E41C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E44A0", Offset = "0x5E30A0", VA = "0x1805E44A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool HLMICCJNPGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4794EA0", Offset = "0x4793AA0", VA = "0x184794EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool PENCHDCCCPL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x89ADD0", Offset = "0x8999D0", VA = "0x18089ADD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x27B3530", Offset = "0x27B2130", VA = "0x1827B3530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string JHKHALMBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5E5010", Offset = "0x5E3C10", VA = "0x1805E5010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5E5020", Offset = "0x5E3C20", VA = "0x1805E5020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float BJNDPIKCLCH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x1086F40", Offset = "0x1085B40", VA = "0x181086F40")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x1087350", Offset = "0x1085F50", VA = "0x181087350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4794FB0", Offset = "0x4793BB0", VA = "0x184794FB0")]
	public LCNJCLIBDCI(IEnumerator<GGCFHHNCLAL> NFNDCLNLNMD, AEOGBAAFNFD BGDHIGEIIHJ, MFGMINCEOLH FPDFPEPCDEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4794B30", Offset = "0x4793730", VA = "0x184794B30")]
	public GGCFHHNCLAL BLKPOEKJAGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4794E30", Offset = "0x4793A30", VA = "0x184794E30")]
	public bool INJPHCKEFKF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4794DA0", Offset = "0x47939A0", VA = "0x184794DA0")]
	public void IADDGBBLMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4794F20", Offset = "0x4793B20", VA = "0x184794F20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x1298090", Offset = "0x1296C90", VA = "0x181298090")]
	[CompilerGenerated]
	private void HFOIPKLPEIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
internal sealed class MFGMINCEOLH : NLEELMBLJPA, ILEKNFOCKKN, GLOMMMCGKDN, IHEBICEMHFG, IEnumerator, GGCFHHNCLAL, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private CCDBLMPDMPL.HICMAFGGBNF EGOEDAGCCLM;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private CCDBLMPDMPL.HICMAFGGBNF ONIMIAICJAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x609180", Offset = "0x607D80", VA = "0x180609180", Slot = "23")]
		get
		{
			return default(CCDBLMPDMPL.HICMAFGGBNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public CCDBLMPDMPL.HICMAFGGBNF PMDABFBOJCI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x7D48C0", Offset = "0x7D34C0", VA = "0x1807D48C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private float LEAEBKPICAE
	{
		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x10DBAF0", Offset = "0x10DA6F0", VA = "0x1810DBAF0", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4795670", Offset = "0x4794270", VA = "0x184795670", Slot = "24")]
	private bool DKAJIPPEAMG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4795690", Offset = "0x4794290", VA = "0x184795690", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x47956A0", Offset = "0x47942A0", VA = "0x1847956A0")]
	public MFGMINCEOLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
internal enum DALOIIFCJFC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
internal sealed class HGCIDHFAAAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum NBJCAMFHFBK
	{
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public struct OGPNLHLPDIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public CCDBLMPDMPL.HICMAFGGBNF LDMGBGAPOOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public NBJCAMFHFBK HDIEKLAAGBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public List<LCNJCLIBDCI> CKIDHCOIKGM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private static readonly NBJCAMFHFBK[] GCEJBELKGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private readonly CCDBLMPDMPL.HICMAFGGBNF BEOHEPJKIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private bool DIEBLKKCHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private readonly LCNJCLIBDCI[] FKJENFIOBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private readonly List<LCNJCLIBDCI> BLHNCLPDIED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Stack<int> ICJIOFOAOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly List<LCNJCLIBDCI> NPICCIDCIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private readonly Stack<int> PLIEABFLNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private readonly IKFEKALLCMI GGDKKELDDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private bool NAAGAJOPHGM;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public OGPNLHLPDIJ[,] NPACABPDGAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x637130", Offset = "0x635D30", VA = "0x180637130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x47938E0", Offset = "0x47924E0", VA = "0x1847938E0")]
	public HGCIDHFAAAE(CCDBLMPDMPL.HICMAFGGBNF CKOLLHBNDLG, IKFEKALLCMI GGDKKELDDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4792F40", Offset = "0x4791B40", VA = "0x184792F40")]
	public void INAGLANDPKJ(LCNJCLIBDCI NFNDCLNLNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4793180", Offset = "0x4791D80", VA = "0x184793180")]
	public void KNDMBABJDNK(IList<LCNJCLIBDCI> IGCPEHGJPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x4793400", Offset = "0x4792000", VA = "0x184793400")]
	public void OHIHJKBNAHC(IList<LCNJCLIBDCI> IGCPEHGJPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4792670", Offset = "0x4791270", VA = "0x184792670")]
	private void AAJOBGJBJCD(LCNJCLIBDCI NFNDCLNLNMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4792DD0", Offset = "0x47919D0", VA = "0x184792DD0")]
	private void IBLNFEKNMJH(IList<LCNJCLIBDCI> IGCPEHGJPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4793680", Offset = "0x4792280", VA = "0x184793680")]
	private DALOIIFCJFC OPHOKJFGOIB(LCNJCLIBDCI NFNDCLNLNMD)
	{
		return default(DALOIIFCJFC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4792760", Offset = "0x4791360", VA = "0x184792760")]
	public void ADGIMOCDCAK(float IHCDICENJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x47928B0", Offset = "0x47914B0", VA = "0x1847928B0")]
	public void AMDIPKFFIJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4792AB0", Offset = "0x47916B0", VA = "0x184792AB0")]
	private void DNEEIJFBOAJ(List<LCNJCLIBDCI> IGCPEHGJPDP, Stack<int> CLEJPCAMICP, bool MNGACMDKKAJ, float EBENKDJIIIN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4792C90", Offset = "0x4791890", VA = "0x184792C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4793060", Offset = "0x4791C60", VA = "0x184793060")]
	private void KEKBNIGNALB(List<LCNJCLIBDCI> IGCPEHGJPDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
internal class CNPHKLEHDCK : IKFEKALLCMI
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "4")]
	public void GDEAIKCFFPB(string AMDKCMALAFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E4E80", Offset = "0x5E3A80", VA = "0x1805E4E80", Slot = "5")]
	public void GDAKAOOGHNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AB0", Offset = "0x5E56B0", VA = "0x1805E6AB0")]
	public CNPHKLEHDCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
internal class MHECLJEINMD : AEOGBAAFNFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	private readonly Behaviour NMCNJGIBDPP;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string JHKHALMBKHF
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x4795760", Offset = "0x4794360", VA = "0x184795760", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool DIKPGGBGHKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x4795700", Offset = "0x4794300", VA = "0x184795700", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool OLKPOPGECDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x47957F0", Offset = "0x47943F0", VA = "0x1847957F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x719660", Offset = "0x718260", VA = "0x180719660")]
	public MHECLJEINMD(Behaviour NMCNJGIBDPP)
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
