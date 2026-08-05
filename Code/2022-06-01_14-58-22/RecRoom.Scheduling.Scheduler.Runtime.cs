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
public class FHPNNJDDLAE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority MFONIDFECAD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x499F150", Offset = "0x499DB50", VA = "0x18499F150")]
	public FHPNNJDDLAE(ThreadPriority PJBFNLBBGGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x499F140", Offset = "0x499DB40", VA = "0x18499F140", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> OAJGBEPBKMK(List<PlayerLoopSystem> FGEBAPJFDIK, int DGOJKPJBMOA);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct EPBOBPNFKNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct EPDGCLDLNID
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static HDFEEIPOLMP JCMNHHFEMCO;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x499D8F0", Offset = "0x499C2F0", VA = "0x18499D8F0")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct EJLONAKLOKC
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static HDFEEIPOLMP NJCPONLACGE;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x499D6F0", Offset = "0x499C0F0", VA = "0x18499D6F0")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct DGACKOBLPLP
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static HDFEEIPOLMP OBNGKJHBPHF;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x499C6A0", Offset = "0x499B0A0", VA = "0x18499C6A0")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct GGJNBCCDFPO
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static HDFEEIPOLMP POMFHIFLAOI;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x499F8F0", Offset = "0x499E2F0", VA = "0x18499F8F0")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct EGDNBPGBKHC
			{
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static HDFEEIPOLMP AGFHCIMHIPC;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x499D0E0", Offset = "0x499BAE0", VA = "0x18499D0E0")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			internal struct GKENPDLFPFH
			{
				[Cpp2IlInjected.Token(Token = "0x2000011")]
				[CompilerGenerated]
				private sealed class NNFLKOEEGDB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public FPIJLJDGAOF.PBMPAOCEGLM key;

					[Cpp2IlInjected.Token(Token = "0x6000027")]
					[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
					public NNFLKOEEGDB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x49A8C20", Offset = "0x49A7620", VA = "0x1849A8C20")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static IDisposable LDKBNLNPNDJ;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x499FAC0", Offset = "0x499E4C0", VA = "0x18499FAC0")]
				public static PlayerLoopSystem IIHIAPNGFIL(FPIJLJDGAOF.PBMPAOCEGLM IPKOPOLJGIA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000012")]
			internal struct MGLHCNINKJM
			{
				[Cpp2IlInjected.Token(Token = "0x2000013")]
				[CompilerGenerated]
				private sealed class OMAKPHGKFKD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000014")]
					public FPIJLJDGAOF.PBMPAOCEGLM key;

					[Cpp2IlInjected.Token(Token = "0x600002A")]
					[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
					public OMAKPHGKFKD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600002B")]
					[Cpp2IlInjected.Address(RVA = "0x49A8EF0", Offset = "0x49A78F0", VA = "0x1849A8EF0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x49A4430", Offset = "0x49A2E30", VA = "0x1849A4430")]
				public static PlayerLoopSystem IIHIAPNGFIL(FPIJLJDGAOF.PBMPAOCEGLM IPKOPOLJGIA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class MIDECNMIFEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public MIDECNMIFEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x49A4550", Offset = "0x49A2F50", VA = "0x1849A4550")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool CINKGNCGENI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool GAOJJDJEHAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x499AC80", Offset = "0x4999680", VA = "0x18499AC80")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x499AFB0", Offset = "0x49999B0", VA = "0x18499AFB0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4999830", Offset = "0x4998230", VA = "0x184999830")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x499ADE0", Offset = "0x49997E0", VA = "0x18499ADE0")]
		private static void JOOFDHPDCPJ(FPIJLJDGAOF.PBMPAOCEGLM IPKOPOLJGIA, ref PlayerLoopSystem IHAPCONAEJB, Type PDPOLJOKFPN, Type MPAFEJDEADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x499AFF0", Offset = "0x49999F0", VA = "0x18499AFF0")]
		private static void OOIPOLBJJGN(ref PlayerLoopSystem IHAPCONAEJB, Type PDPOLJOKFPN, Type MPAFEJDEADG, OAJGBEPBKMK MCCCAAGOKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x499ACC0", Offset = "0x49996C0", VA = "0x18499ACC0")]
		private static void GIKOLAAKJMD(ref PlayerLoopSystem IHAPCONAEJB, Type PDPOLJOKFPN, Type MPAFEJDEADG, PlayerLoopSystem? OOOMDGNDLCI, PlayerLoopSystem? BNDJCDBBJPE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class FPIJLJDGAOF
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum PBMPAOCEGLM
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class MFAAFGLJPEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly PBMPAOCEGLM ILIEDFOCEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly PKNBLIKMBHM OMFJOMKBMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long GPINJOAMPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long IJBOCKEINAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public long KFNIELCHNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int AENJIGLJMPA;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x49A4250", Offset = "0x49A2C50", VA = "0x1849A4250")]
		public MFAAFGLJPEK(PBMPAOCEGLM OPBHABOPBLF, int FHKCKGPHGKL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x49A4180", Offset = "0x49A2B80", VA = "0x1849A4180")]
		public void MNKJBOHKEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x49A41F0", Offset = "0x49A2BF0", VA = "0x1849A41F0")]
		public void OJGAJDCGJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x49A3FB0", Offset = "0x49A29B0", VA = "0x1849A3FB0")]
		public void CMGJBLEPJKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static PBMPAOCEGLM[] HJBGKLEKCCE;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static MFAAFGLJPEK[] ECBEHNINDKH;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x499F570", Offset = "0x499DF70", VA = "0x18499F570")]
	public static MFAAFGLJPEK NFEAPJOFCBL(PBMPAOCEGLM IPKOPOLJGIA, int FHKCKGPHGKL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x499F4E0", Offset = "0x499DEE0", VA = "0x18499F4E0")]
	public static MFAAFGLJPEK KDMBHGPCAJJ(PBMPAOCEGLM IPKOPOLJGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x499F720", Offset = "0x499E120", VA = "0x18499F720")]
	public static void PCPILADEMAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PKNBLIKMBHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int EJAGBFMDHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Queue<double> MEBHNEJKLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double CJILIEPCADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double AOLLHLFGLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double LOBMKBCDPPN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JDAKIMNLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x49A9CC0", Offset = "0x49A86C0", VA = "0x1849A9CC0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x49A9E20", Offset = "0x49A8820", VA = "0x1849A9E20")]
	public PKNBLIKMBHM(int GNLACGIKOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x49A9D20", Offset = "0x49A8720", VA = "0x1849A9D20", Slot = "4")]
	public void LOOBHGGGILA(double LFNNMJBIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x49A9C50", Offset = "0x49A8650", VA = "0x1849A9C50", Slot = "5")]
	public void HEPELHGAALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MLNNOIKGIAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private long LKEJFKMJCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double KDHOJDDPLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double AGMFEPNIIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double LCEPFBAAPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double HENHPAEIELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double CJILIEPCADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double AOLLHLFGLAP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KIDCNAFIEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x123D000", Offset = "0x123BA00", VA = "0x18123D000", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double PPNBKFKKGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xED7120", Offset = "0xED5B20", VA = "0x180ED7120", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double PMJFNDEJFBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xFCE450", Offset = "0xFCCE50", VA = "0x180FCE450")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JDAKIMNLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x123CF30", Offset = "0x123B930", VA = "0x18123CF30", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x49A4CA0", Offset = "0x49A36A0", VA = "0x1849A4CA0", Slot = "7")]
	public void LOOBHGGGILA(double LFNNMJBIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x49A4C60", Offset = "0x49A3660", VA = "0x1849A4C60", Slot = "8")]
	public void HEPELHGAALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x49A4DC0", Offset = "0x49A37C0", VA = "0x1849A4DC0")]
	public MLNNOIKGIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class NIABOFLJIJO
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface BJEKEBKBOOA
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool BMJJMEHBJOA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DCGILHLCDMK();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private abstract class JAEHHKGHJOP<TPromise, TMainThreadPromise> : BJEKEBKBOOA where TPromise : LCANMJCMFMC where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly TPromise NBHEGMIKKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected readonly TMainThreadPromise MGGFLKEOJLC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise OJCIIKLEPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3DFD950", Offset = "0x3DFC350", VA = "0x183DFD950")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BMJJMEHBJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3DFD9B0", Offset = "0x3DFC3B0", VA = "0x183DFD9B0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x178AD30", Offset = "0x1789730", VA = "0x18178AD30")]
		protected JAEHHKGHJOP(TPromise NBHEGMIKKIG, TMainThreadPromise DOFLMEJFHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3DFD920", Offset = "0x3DFC320", VA = "0x183DFD920", Slot = "5")]
		public void DCGILHLCDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void LPLCLJJOFPD(TPromise NBHEGMIKKIG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class JOOOPCNOHDF<T> : JAEHHKGHJOP<global::HJGFLNHHJHD<T>, global::EJMKJFHGFHJ<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3E01230", Offset = "0x3DFFC30", VA = "0x183E01230")]
		public JOOOPCNOHDF(global::HJGFLNHHJHD<T> NBHEGMIKKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3E01030", Offset = "0x3DFFA30", VA = "0x183E01030", Slot = "6")]
		protected override void LPLCLJJOFPD(global::HJGFLNHHJHD<T> NBHEGMIKKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3E01000", Offset = "0x3DFFA00", VA = "0x183E01000")]
		[CompilerGenerated]
		private void FHGDONPMEJH(T HEMKPPOPDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x392B700", Offset = "0x392A100", VA = "0x18392B700")]
		[CompilerGenerated]
		private void EAOKBGDNPBC(string EPHLCEKHMCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class DEOMFFBJFPO : BJEKEBKBOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Action APBFEHIGAIL;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BMJJMEHBJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x588CA0", Offset = "0x5876A0", VA = "0x180588CA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5DEFD0", Offset = "0x5DD9D0", VA = "0x1805DEFD0")]
		public DEOMFFBJFPO(Action APBFEHIGAIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x124CF40", Offset = "0x124B940", VA = "0x18124CF40", Slot = "5")]
		public void DCGILHLCDMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly List<BJEKEBKBOOA> PEKDFOMDLGA;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0xC02A30", Offset = "0xC01430", VA = "0x180C02A30")]
	public static global::HJGFLNHHJHD<T> NHKHHAOCNCP<T>(this global::HJGFLNHHJHD<T> NBHEGMIKKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x49A8A20", Offset = "0x49A7420", VA = "0x1849A8A20")]
	public static void NHKHHAOCNCP(Action APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0xC02970", Offset = "0xC01370", VA = "0x180C02970")]
	private static global::HJGFLNHHJHD<T> EBDDFMLEDNB<T>(global::HJGFLNHHJHD<T> NBHEGMIKKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x49A8390", Offset = "0x49A6D90", VA = "0x1849A8390")]
	private static void BLADIKCDCGM(BJEKEBKBOOA KNDAJEJHAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x49A8700", Offset = "0x49A7100", VA = "0x1849A8700")]
	private static void KDICEJNPFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x49A8580", Offset = "0x49A6F80", VA = "0x1849A8580")]
	private static void EJFJJFIGIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49A8650", Offset = "0x49A7050", VA = "0x1849A8650")]
	private static void FGLDLPJONBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class KPCMHGIPDIM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct NCPFMAAPPNA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public BDMELKPFPFB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private global::ELGBDNPDGLF<BDMELKPFPFB, string> <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x49A7280", Offset = "0x49A5C80", VA = "0x1849A7280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class LFCOJIBCNHL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public FLCLHLLPKNN promise;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public LFCOJIBCNHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x49A3DB0", Offset = "0x49A27B0", VA = "0x1849A3DB0")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct CHDPJPDNPGE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public BDMELKPFPFB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private LFCOJIBCNHL <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private NGLMAFJFDEM <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4999030", Offset = "0x4997A30", VA = "0x184999030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct DDFOEJNHIGN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public BDMELKPFPFB stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private NGLMAFJFDEM <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private NGLMAFJFDEM <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x499BFE0", Offset = "0x499A9E0", VA = "0x18499BFE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x70FEF0", Offset = "0x70E8F0", VA = "0x18070FEF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class LGJGOOENPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public LGJGOOENPKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x49A3E00", Offset = "0x49A2800", VA = "0x1849A3E00")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class EHOEAPPDDLI : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public FLCLHLLPKNN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public EHOEAPPDDLI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x499D5F0", Offset = "0x499BFF0", VA = "0x18499D5F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x499D2B0", Offset = "0x499BCB0", VA = "0x18499D2B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x499D6A0", Offset = "0x499C0A0", VA = "0x18499D6A0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x499D5A0", Offset = "0x499BFA0", VA = "0x18499D5A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class LFBPCPENOCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public FLCLHLLPKNN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public LFBPCPENOCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class ECBDGFAFLMJ : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public FLCLHLLPKNN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private LFBPCPENOCI <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public ECBDGFAFLMJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x499CBF0", Offset = "0x499B5F0", VA = "0x18499CBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x499CF90", Offset = "0x499B990", VA = "0x18499CF90", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static LCANMJCMFMC JDNBDKHAKJK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation GLOODFLAEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static LCANMJCMFMC PMIINOGPPNH;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string EGPJMBPJBPI;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority GHHBILOKKAE;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static Task OJCFJOCNBOH;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Queue<(string sceneName, LoadSceneMode loadSceneMode, bool stopOnEmptyScene, BDMELKPFPFB stackTimer)> HKAAIFEKDDI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool MKCOIMNNCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x49A2B00", Offset = "0x49A1500", VA = "0x1849A2B00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool OIJGJLPBENA
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x49A37B0", Offset = "0x49A21B0", VA = "0x1849A37B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool IFOBFHEIFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x49A39B0", Offset = "0x49A23B0", VA = "0x1849A39B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> HCKOJDKLMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x49A2A00", Offset = "0x49A1400", VA = "0x1849A2A00")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x49A36B0", Offset = "0x49A20B0", VA = "0x1849A36B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x49A2EE0", Offset = "0x49A18E0", VA = "0x1849A2EE0")]
	[FJOEOFBCKFM(DEGJMHBBGDK.EnteredEditModeNextFrame, 0)]
	private static void ENLEHHANJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x49A2FB0", Offset = "0x49A19B0", VA = "0x1849A2FB0")]
	[AsyncStateMachine(typeof(NCPFMAAPPNA))]
	public static Task GDGJOKEICCO(string JEOEEAOHALB, LoadSceneMode HGHKAHMJDPM = LoadSceneMode.Single, bool LHMAJLKAIIL = false, [Optional] BDMELKPFPFB BCIAJNNCADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30")]
	private static void JGMAANBEALL(BDMELKPFPFB FBOGCDJOCBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x49A2CB0", Offset = "0x49A16B0", VA = "0x1849A2CB0")]
	[AsyncStateMachine(typeof(CHDPJPDNPGE))]
	private static Task EGKCNBAFNCN(string JEOEEAOHALB, LoadSceneMode HGHKAHMJDPM, bool LHMAJLKAIIL, BDMELKPFPFB BCIAJNNCADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x49A2DF0", Offset = "0x49A17F0", VA = "0x1849A2DF0")]
	[AsyncStateMachine(typeof(DDFOEJNHIGN))]
	private static Task EIHAILANHLH(BDMELKPFPFB BCIAJNNCADP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x49A3630", Offset = "0x49A2030", VA = "0x1849A3630")]
	public static LCANMJCMFMC KPOBLBHFKHJ(string JEOEEAOHALB, LoadSceneMode HGHKAHMJDPM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x49A3180", Offset = "0x49A1B80", VA = "0x1849A3180")]
	public static LCANMJCMFMC HHCAPNJPKHD(string JEOEEAOHALB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x49A30F0", Offset = "0x49A1AF0", VA = "0x1849A30F0")]
	[IteratorStateMachine(typeof(EHOEAPPDDLI))]
	private static IEnumerator<CBGPFCCMDJP> HAKLCHFCHAL(string JEOEEAOHALB, FLCLHLLPKNN ONADGBDMLKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x49A35A0", Offset = "0x49A1FA0", VA = "0x1849A35A0")]
	[IteratorStateMachine(typeof(ECBDGFAFLMJ))]
	private static IEnumerator<CBGPFCCMDJP> IILFGCCFIOE(string JEOEEAOHALB, LoadSceneMode HGHKAHMJDPM, FLCLHLLPKNN ONADGBDMLKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x49A3860", Offset = "0x49A2260", VA = "0x1849A3860")]
	public static bool OKHGJFAIDKF(out string LJFEMDGCAMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class PBGPJDCOLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x49A9BD0", Offset = "0x49A85D0", VA = "0x1849A9BD0")]
	public static IDisposable LJKIHPPLBEJ(this JGALIOBJCGI PHFLFPJELLC, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x49A9B50", Offset = "0x49A8550", VA = "0x1849A9B50")]
	public static IDisposable IAEILIPBKFD(this JGALIOBJCGI PHFLFPJELLC, Action<float> OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x49A9AD0", Offset = "0x49A84D0", VA = "0x1849A9AD0")]
	public static IDisposable CPIJCDNACMN(this JGALIOBJCGI PHFLFPJELLC, Action<float> OJLMNNBAEBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class JPIJFGKNPAD
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x49A1DB0", Offset = "0x49A07B0", VA = "0x1849A1DB0")]
	public static IDisposable EFPOPPMGPPM(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x49A1E30", Offset = "0x49A0830", VA = "0x1849A1E30")]
	public static IDisposable EFPOPPMGPPM(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x49A2310", Offset = "0x49A0D10", VA = "0x1849A2310")]
	public static IDisposable JCPEDGKMAKO(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x49A2180", Offset = "0x49A0B80", VA = "0x1849A2180")]
	public static IDisposable GNIIKDLBAAE(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x49A2110", Offset = "0x49A0B10", VA = "0x1849A2110")]
	public static IDisposable FOCHHCGPBDF(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x49A1D40", Offset = "0x49A0740", VA = "0x1849A1D40")]
	public static IDisposable CKFNHFCOCKK(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x49A2410", Offset = "0x49A0E10", VA = "0x1849A2410")]
	public static IDisposable LFPIFLGOGGF(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x49A1FE0", Offset = "0x49A09E0", VA = "0x1849A1FE0")]
	public static IDisposable EPDIIBIKNIH(this MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x49A26C0", Offset = "0x49A10C0", VA = "0x1849A26C0")]
	public static IDisposable PCMILIDINFC(this MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x49A2380", Offset = "0x49A0D80", VA = "0x1849A2380")]
	public static IDisposable JGDJMFOIGMH(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x49A21F0", Offset = "0x49A0BF0", VA = "0x1849A21F0")]
	public static IDisposable IIFOHJEKGDN(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x49A2630", Offset = "0x49A1030", VA = "0x1849A2630")]
	public static IDisposable OPJLKLGLJOO(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x49A2480", Offset = "0x49A0E80", VA = "0x1849A2480")]
	public static IDisposable MHCCBGHIHIC(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x49A25A0", Offset = "0x49A0FA0", VA = "0x1849A25A0")]
	public static IDisposable OOPDHIAAPMI(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x49A2510", Offset = "0x49A0F10", VA = "0x1849A2510")]
	public static IDisposable MPLDBPHJBGJ(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x49A2080", Offset = "0x49A0A80", VA = "0x1849A2080")]
	public static IDisposable FEMAKBGNFOA(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x49A2750", Offset = "0x49A1150", VA = "0x1849A2750")]
	public static IDisposable PPIFMGFMEAJ(this MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x49A2280", Offset = "0x49A0C80", VA = "0x1849A2280")]
	public static IDisposable IKKOAAFOPLF(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class FIMNOHNKPOF
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class NLNLKLEGNCE : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public CHHGIHFBDMH.FDLFDEJDCEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private NHMDDCEBCAF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public NLNLKLEGNCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x49A8B10", Offset = "0x49A7510", VA = "0x1849A8B10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x49A8BD0", Offset = "0x49A75D0", VA = "0x1849A8BD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class DGMNOGABOEC : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public CHHGIHFBDMH.FDLFDEJDCEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private NHMDDCEBCAF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public DGMNOGABOEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x499C870", Offset = "0x499B270", VA = "0x18499C870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x499C950", Offset = "0x499B350", VA = "0x18499C950", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x499F300", Offset = "0x499DD00", VA = "0x18499F300")]
	public static LMANBCGFHOA EFPOPPMGPPM(Action OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x499F190", Offset = "0x499DB90", VA = "0x18499F190")]
	public static LMANBCGFHOA EFPOPPMGPPM(Behaviour PHFLFPJELLC, Action OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x499F220", Offset = "0x499DC20", VA = "0x18499F220")]
	public static LMANBCGFHOA EFPOPPMGPPM(Behaviour PHFLFPJELLC, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x499F3E0", Offset = "0x499DDE0", VA = "0x18499F3E0")]
	[IteratorStateMachine(typeof(NLNLKLEGNCE))]
	private static IEnumerator<CBGPFCCMDJP> OKKBMACFNEJ(CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x499F460", Offset = "0x499DE60", VA = "0x18499F460")]
	[IteratorStateMachine(typeof(DGMNOGABOEC))]
	private static IEnumerator<CBGPFCCMDJP> OKKBMACFNEJ(CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action<float> OJLMNNBAEBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class DLAKKJGNJGM
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class LLKPAFEAHLC : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public NKBFLNAENPC schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public CHHGIHFBDMH.FDLFDEJDCEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private PKLKGFCCNOO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public LLKPAFEAHLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x49A3E30", Offset = "0x49A2830", VA = "0x1849A3E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x49A3F60", Offset = "0x49A2960", VA = "0x1849A3F60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x499CA70", Offset = "0x499B470", VA = "0x18499CA70")]
	public static LMANBCGFHOA EFPOPPMGPPM(MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x499C9A0", Offset = "0x499B3A0", VA = "0x18499C9A0")]
	public static LMANBCGFHOA AOHOPNJOEHC(JGALIOBJCGI PHFLFPJELLC, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x499CB40", Offset = "0x499B540", VA = "0x18499CB40")]
	[IteratorStateMachine(typeof(LLKPAFEAHLC))]
	private static IEnumerator<CBGPFCCMDJP> OKKBMACFNEJ(NKBFLNAENPC HLHAMGEKDJK, float DNLOJCHBPLN, CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class IPIAJJPLMFP
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KHFIPODOJDA : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public CHHGIHFBDMH.FDLFDEJDCEE queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public KHFIPODOJDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x49A27F0", Offset = "0x49A11F0", VA = "0x1849A27F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x49A28A0", Offset = "0x49A12A0", VA = "0x1849A28A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x49A1A10", Offset = "0x49A0410", VA = "0x1849A1A10")]
	[IteratorStateMachine(typeof(KHFIPODOJDA))]
	private static IEnumerator<CBGPFCCMDJP> CLLJGEFNGMD(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, Func<bool> DMNFPOCCJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x49A1930", Offset = "0x49A0330", VA = "0x1849A1930")]
	public static LMANBCGFHOA CGEIJJDIFMM(this MonoBehaviour FNPLMBBLDCM, Func<bool> DMNFPOCCJPC, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC = CHHGIHFBDMH.FDLFDEJDCEE.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class PPAMCJACMIO
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class NOPABGGDKDC : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public CHHGIHFBDMH.FDLFDEJDCEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public NOPABGGDKDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x49A8D10", Offset = "0x49A7710", VA = "0x1849A8D10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x49A8DD0", Offset = "0x49A77D0", VA = "0x1849A8DD0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x49AA410", Offset = "0x49A8E10", VA = "0x1849AA410")]
	[IteratorStateMachine(typeof(NOPABGGDKDC))]
	private static IEnumerator<CBGPFCCMDJP> NMDLEMGHEKJ(float CIGDJIOGKIP, CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x49A9FE0", Offset = "0x49A89E0", VA = "0x1849A9FE0")]
	public static LMANBCGFHOA EDNNNJHMCMD(this MonoBehaviour FNPLMBBLDCM, float CIGDJIOGKIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x49AA070", Offset = "0x49A8A70", VA = "0x1849AA070")]
	public static LMANBCGFHOA FCPLFFEMJOB(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x49AA4D0", Offset = "0x49A8ED0", VA = "0x1849AA4D0")]
	public static LMANBCGFHOA PBEKADIGECC(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x49AA4A0", Offset = "0x49A8EA0", VA = "0x1849AA4A0")]
	public static LMANBCGFHOA OLGGPIHKEHE(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB, [Optional] IMNPHPKLLEB IIAHJAPPDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x49AA110", Offset = "0x49A8B10", VA = "0x1849AA110")]
	public static LMANBCGFHOA FPBOJIIABMC(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x49AA2E0", Offset = "0x49A8CE0", VA = "0x1849AA2E0")]
	public static LMANBCGFHOA MHKJFJPLADN(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x49AA240", Offset = "0x49A8C40", VA = "0x1849AA240")]
	private static LMANBCGFHOA HGPMGDOICHP(MonoBehaviour FNPLMBBLDCM, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, Action IAMHMHMHKFB, [Optional] IMNPHPKLLEB IIAHJAPPDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x49A9F50", Offset = "0x49A8950", VA = "0x1849A9F50")]
	public static LMANBCGFHOA EAFIAMLHCBK(this MonoBehaviour FNPLMBBLDCM, float GPFDIFFEJNB, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x49AA1B0", Offset = "0x49A8BB0", VA = "0x1849AA1B0")]
	public static LMANBCGFHOA FPOEHBAJGBM(this MonoBehaviour FNPLMBBLDCM, float GPFDIFFEJNB, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x49A9EC0", Offset = "0x49A88C0", VA = "0x1849A9EC0")]
	public static LMANBCGFHOA BOMGFOPOHNP(this MonoBehaviour FNPLMBBLDCM, float GPFDIFFEJNB, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x49AA380", Offset = "0x49A8D80", VA = "0x1849AA380")]
	public static LMANBCGFHOA NIPNEILHNEH(this MonoBehaviour FNPLMBBLDCM, float GPFDIFFEJNB, Action IAMHMHMHKFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class JPHOFLANPKF : DCMHDCPMEBE
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class ELAONHIOLOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public JPHOFLANPKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public ELAONHIOLOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x499D8C0", Offset = "0x499C2C0", VA = "0x18499D8C0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class LAMDKDCKLDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public JPHOFLANPKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public LAMDKDCKLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x499D8C0", Offset = "0x499C2C0", VA = "0x18499D8C0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly float HGMBNJKAALE;

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x49997E0", Offset = "0x49981E0", VA = "0x1849997E0")]
	public JPHOFLANPKF(Behaviour PHFLFPJELLC, float HGMBNJKAALE, [Optional] Action EIJJDBDCGDH, [Optional] IMNPHPKLLEB IIAHJAPPDMI, [Optional] NKBFLNAENPC HLHAMGEKDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x49A1C60", Offset = "0x49A0660", VA = "0x1849A1C60", Slot = "9")]
	protected override bool OFNCDGPKIGJ(Action APBFEHIGAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x49A1B80", Offset = "0x49A0580", VA = "0x1849A1B80", Slot = "10")]
	protected override bool LGHOAFNGKBL(Action APBFEHIGAIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PGEAJDKEMOK
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool JKICMMOOGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ELKGADEJFDO;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AHMAMNMLLGB(bool BKLDBHLOPOM = false);

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AHMAMNMLLGB(Action APBFEHIGAIL, bool BKLDBHLOPOM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class DCMHDCPMEBE : PGEAJDKEMOK
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class NACOOLJMPDP : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public DCMHDCPMEBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public NACOOLJMPDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x49A7160", Offset = "0x49A5B60", VA = "0x1849A7160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x49A7230", Offset = "0x49A5C30", VA = "0x1849A7230", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Behaviour PHFLFPJELLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Action EIJJDBDCGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private BEIOIJBLHOA BONKFLIMBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly IMNPHPKLLEB IIAHJAPPDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	protected readonly NKBFLNAENPC HLHAMGEKDJK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool JKICMMOOGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x9F2A50", Offset = "0x9F1450", VA = "0x1809F2A50", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ELKGADEJFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x499B900", Offset = "0x499A300", VA = "0x18499B900", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x499BBA0", Offset = "0x499A5A0", VA = "0x18499BBA0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x499BE10", Offset = "0x499A810", VA = "0x18499BE10")]
	protected DCMHDCPMEBE(Behaviour PHFLFPJELLC, [Optional] Action EIJJDBDCGDH, [Optional] IMNPHPKLLEB IIAHJAPPDMI, [Optional] NKBFLNAENPC HLHAMGEKDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x499B9A0", Offset = "0x499A3A0", VA = "0x18499B9A0", Slot = "7")]
	public bool AHMAMNMLLGB(bool BKLDBHLOPOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x499BA00", Offset = "0x499A400", VA = "0x18499BA00", Slot = "8")]
	public bool AHMAMNMLLGB(Action APBFEHIGAIL, bool BKLDBHLOPOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OFNCDGPKIGJ(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LGHOAFNGKBL(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x499BB80", Offset = "0x499A580", VA = "0x18499BB80")]
	protected void IDGEJFKFINA(Action APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x499BC40", Offset = "0x499A640", VA = "0x18499BC40")]
	protected LCANMJCMFMC PBJALPPEEHN(float HKANIFIKHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x499BA50", Offset = "0x499A450", VA = "0x18499BA50")]
	private void CHFCHIFKFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x499BAC0", Offset = "0x499A4C0", VA = "0x18499BAC0")]
	[IteratorStateMachine(typeof(NACOOLJMPDP))]
	private IEnumerator<CBGPFCCMDJP> EDAAAEMOCJN(float HKANIFIKHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x499BB40", Offset = "0x499A540", VA = "0x18499BB40")]
	[CompilerGenerated]
	private void HAFPCHONHHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class AJIENPIAFBI : DCMHDCPMEBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly float KCEPDDBIFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly int DPJHPONFNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly float PCFGAPJOEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly float[] KFCNMHPCNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int CABKNPNBPGE;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4998E90", Offset = "0x4997890", VA = "0x184998E90")]
	public AJIENPIAFBI(Behaviour PHFLFPJELLC, float EGINGMLIOIG, int DPJHPONFNOB, [Optional] Action EIJJDBDCGDH, float PCFGAPJOEFN = 0f, [Optional] IMNPHPKLLEB IIAHJAPPDMI, [Optional] NKBFLNAENPC HLHAMGEKDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x588B90", Offset = "0x587590", VA = "0x180588B90", Slot = "9")]
	protected override bool OFNCDGPKIGJ(Action APBFEHIGAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4998C70", Offset = "0x4997670", VA = "0x184998C70", Slot = "10")]
	protected override bool LGHOAFNGKBL(Action APBFEHIGAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4998BE0", Offset = "0x49975E0", VA = "0x184998BE0")]
	private void FCFABOGPEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class CKFIALJIHJN : DCMHDCPMEBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly float HGMBNJKAALE;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x49997E0", Offset = "0x49981E0", VA = "0x1849997E0")]
	public CKFIALJIHJN(Behaviour PHFLFPJELLC, float HGMBNJKAALE, [Optional] Action EIJJDBDCGDH, [Optional] IMNPHPKLLEB IIAHJAPPDMI, [Optional] NKBFLNAENPC HLHAMGEKDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x588B90", Offset = "0x587590", VA = "0x180588B90", Slot = "9")]
	protected override bool OFNCDGPKIGJ(Action APBFEHIGAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x49997A0", Offset = "0x49981A0", VA = "0x1849997A0", Slot = "10")]
	protected override bool LGHOAFNGKBL(Action APBFEHIGAIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class MLGGMILOINJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class JKKGKOOMIEL : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public JKKGKOOMIEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x49A1A90", Offset = "0x49A0490", VA = "0x1849A1A90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x49A1B30", Offset = "0x49A0530", VA = "0x1849A1B30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private LMANBCGFHOA AGMFHMMFCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private JGALIOBJCGI PHFLFPJELLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Action<float> OCKPMICIICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float OLCOEEMGNDB;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x49A4AD0", Offset = "0x49A34D0", VA = "0x1849A4AD0")]
	public MLGGMILOINJ(JGALIOBJCGI PHFLFPJELLC, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x49A4910", Offset = "0x49A3310", VA = "0x1849A4910")]
	private void FHKNPCHEADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x49A4650", Offset = "0x49A3050", VA = "0x1849A4650")]
	private void CHLANEDCFAI(string EPHLCEKHMCH, Action LDPEPOJJLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x49A4A60", Offset = "0x49A3460", VA = "0x1849A4A60")]
	[IteratorStateMachine(typeof(JKKGKOOMIEL))]
	private IEnumerator<CBGPFCCMDJP> MDJPIKCEKBP(Action LDPEPOJJLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x49A48B0", Offset = "0x49A32B0", VA = "0x1849A48B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x49A4760", Offset = "0x49A3160", VA = "0x1849A4760")]
	[CompilerGenerated]
	private void CMOJMPGFMLI(string OIFFLJDLBAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class NEKOOEHDIBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class MFNEKEIBKMO : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x587C50", Offset = "0x586650", VA = "0x180587C50")]
		[DebuggerHidden]
		public MFNEKEIBKMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x49A4340", Offset = "0x49A2D40", VA = "0x1849A4340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x49A43E0", Offset = "0x49A2DE0", VA = "0x1849A43E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private LMANBCGFHOA AGMFHMMFCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private MonoBehaviour FNPLMBBLDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Action OJLMNNBAEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Action<float> OCKPMICIICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private float OLCOEEMGNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool JKDPAGNEDCG;

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x49A80B0", Offset = "0x49A6AB0", VA = "0x1849A80B0")]
	public NEKOOEHDIBK(MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x49A8200", Offset = "0x49A6C00", VA = "0x1849A8200")]
	public NEKOOEHDIBK(MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x49A7F10", Offset = "0x49A6910", VA = "0x1849A7F10")]
	public NEKOOEHDIBK(MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, bool JKDPAGNEDCG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x49A79E0", Offset = "0x49A63E0", VA = "0x1849A79E0")]
	private void EFPOPPMGPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x49A7DC0", Offset = "0x49A67C0", VA = "0x1849A7DC0")]
	private void PNOJGBJCIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x49A7B00", Offset = "0x49A6500", VA = "0x1849A7B00")]
	private void FHKNPCHEADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x49A77E0", Offset = "0x49A61E0", VA = "0x1849A77E0")]
	private void CHLANEDCFAI(string EPHLCEKHMCH, Action LDPEPOJJLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x49A7D50", Offset = "0x49A6750", VA = "0x1849A7D50")]
	[IteratorStateMachine(typeof(MFNEKEIBKMO))]
	private IEnumerator<CBGPFCCMDJP> MDJPIKCEKBP(Action LDPEPOJJLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x49A7980", Offset = "0x49A6380", VA = "0x1849A7980", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x49A7CD0", Offset = "0x49A66D0", VA = "0x1849A7CD0")]
	[CompilerGenerated]
	private void KDLBFDJMMEL(string OIFFLJDLBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x49A7900", Offset = "0x49A6300", VA = "0x1849A7900")]
	[CompilerGenerated]
	private void CPDBJKLKDFN(string OIFFLJDLBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x49A7C50", Offset = "0x49A6650", VA = "0x1849A7C50")]
	[CompilerGenerated]
	private void JMAGLCAIEGH(string OIFFLJDLBAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Flags]
internal enum OBECAMIBEEH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal sealed class LAMCEHPDNJJ : NKBFLNAENPC
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public float GOMAEIIMMPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x49A3AF0", Offset = "0x49A24F0", VA = "0x1849A3AF0", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float GALJJDDLDOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x49A3BF0", Offset = "0x49A25F0", VA = "0x1849A3BF0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public double KPLIEDHLNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x49A3BD0", Offset = "0x49A25D0", VA = "0x1849A3BD0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x49A3B00", Offset = "0x49A2500", VA = "0x1849A3B00")]
	[OCMHJDCAMOC]
	private static void CKOGABKKNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	[Preserve]
	internal LAMCEHPDNJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal interface JJJJIFJLAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMAOAGKLBAN(string JMIBJFINBJD);

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHKMOBFGFFA();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal interface CAMBLBEJCOH
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	string ABDPDPAGECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CGBMGJHDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool MELNBBBOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class AAGOBNEJKEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public MMPOKDBEDMJ EMHEOENAECA;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x560010", Offset = "0x55EA10", VA = "0x180560010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x588BA0", Offset = "0x5875A0", VA = "0x180588BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x49987D0", Offset = "0x49971D0", VA = "0x1849987D0")]
	public static CBGPFCCMDJP ADGBBJACDFC(IEnumerator<CBGPFCCMDJP> CGKBPDEICKH, AOICLLJCBMF NFMNDONCHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4998930", Offset = "0x4997330", VA = "0x184998930")]
	public CBGPFCCMDJP ADGBBJACDFC(AOICLLJCBMF[] JOGPJODFGMD, IEnumerator<CBGPFCCMDJP>[] OAJLFEMGKNP, CBGPFCCMDJP[] LCAJHHOIMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4998AE0", Offset = "0x49974E0", VA = "0x184998AE0")]
	public void OEPKHJFLJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x4998B10", Offset = "0x4997510", VA = "0x184998B10")]
	public void PPACHOKAOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4998A10", Offset = "0x4997410", VA = "0x184998A10")]
	public void DILLKNEEJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4998AE0", Offset = "0x49974E0", VA = "0x184998AE0")]
	public void KLAMBKCHHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public AAGOBNEJKEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class MMPOKDBEDMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct EEHNACLJNNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public AAGOBNEJKEK OFJDKJHKIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public JGALIOBJCGI JEINMAEPCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AOICLLJCBMF KJHMDIECKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public IEnumerator<CBGPFCCMDJP> BILPNEMLDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public CBGPFCCMDJP JCCHPCFJJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public OBECAMIBEEH JHECACCJMFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct LIICOANCHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public CHHGIHFBDMH.FDLFDEJDCEE JHPHPIDJHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public List<EEHNACLJNNC> KFAPBMIFLDF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class FBHLCAMKKCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public MMPOKDBEDMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public JGALIOBJCGI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public AAGOBNEJKEK routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public OBECAMIBEEH coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public AOICLLJCBMF promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public CBGPFCCMDJP currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public IEnumerator<CBGPFCCMDJP> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public FBHLCAMKKCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x499DAC0", Offset = "0x499C4C0", VA = "0x18499DAC0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class NOIAJLIJHBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public AAGOBNEJKEK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public MMPOKDBEDMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public NOIAJLIJHBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x49A8CD0", Offset = "0x49A76D0", VA = "0x1849A8CD0")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class MPPMHGHIFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AAGOBNEJKEK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public MMPOKDBEDMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public MPPMHGHIFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x49A7120", Offset = "0x49A5B20", VA = "0x1849A7120")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class OEMEHCMAGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public AAGOBNEJKEK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public MMPOKDBEDMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
		public OEMEHCMAGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x49A8EB0", Offset = "0x49A78B0", VA = "0x1849A8EB0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private const OBECAMIBEEH JHIMLEBNPDI = OBECAMIBEEH.Cancelled | OBECAMIBEEH.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool[] PKLEDKGEMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NativeArray<OBECAMIBEEH> HNIEFDFAJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeArray<float> KIICICADNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeArray<int> DDFKMMMAAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private NativeArray<int> GDCLNGLKOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private NativeArray<int> ALOMAEFEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private NativeArray<int> EIJKEHLNOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<int> CHIGGIHOEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private AAGOBNEJKEK[] OLNJCJNLAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private AOICLLJCBMF[] JOGPJODFGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private JGALIOBJCGI[] AKBDFIPOKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private IEnumerator<CBGPFCCMDJP>[] HLBFEOJPCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private CBGPFCCMDJP[] NEEOAICAAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int DGNEGNFAEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int POIIDIEGIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly int MJJGNEHCLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float PFFDNBEDDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private DCGFEFIAKLL LPEBEAAPDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private JobHandle LGDGIMBIFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private List<AAGOBNEJKEK> EKAAEEGHCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool NPKJDAPGDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private List<Action> GOCEODPBFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private List<Action> BPKAEEGDKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool HKDOILKDBCB;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public LIICOANCHOL[] EACGPAADDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x637B20", Offset = "0x636520", VA = "0x180637B20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x49A6970", Offset = "0x49A5370", VA = "0x1849A6970")]
	private static int MJNGPFNLJGH(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x49A6BC0", Offset = "0x49A55C0", VA = "0x1849A6BC0")]
	public MMPOKDBEDMJ(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x49A5DE0", Offset = "0x49A47E0", VA = "0x1849A5DE0")]
	private void HGIFDMNOEEI(ref int GDJMMOEDFCO, int NADLHCEDJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x49A64E0", Offset = "0x49A4EE0", VA = "0x1849A64E0")]
	public void JMEOCBHJBLH(JGALIOBJCGI PHFLFPJELLC, CBGPFCCMDJP KELJCMHFDCP, IEnumerator<CBGPFCCMDJP> CGKBPDEICKH, AOICLLJCBMF NFMNDONCHFK, [Optional] AAGOBNEJKEK NHNFJNLOEHP, OBECAMIBEEH APKBFECJKBD = OBECAMIBEEH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x49A6030", Offset = "0x49A4A30", VA = "0x1849A6030")]
	public void IEFJNFALMBK(IEnumerable<EEHNACLJNNC> KDDNJPJGJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x49A5350", Offset = "0x49A3D50", VA = "0x1849A5350")]
	private EEHNACLJNNC BPHFMLMLABH(int IPCBNIFLNFB)
	{
		return default(EEHNACLJNNC);
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x49A5A70", Offset = "0x49A4470", VA = "0x1849A5A70")]
	private void FFKGCFKJGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C700", Offset = "0x3A3B100", VA = "0x183A3C700")]
	private static void JGJPKFLCPPD<T>(int IPCBNIFLNFB, T[] GMBKDDBJEHJ, int OCEBHFCGEGN, [Optional] T NFLJJNEBHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C6E0", Offset = "0x3A3B0E0", VA = "0x183A3C6E0")]
	private static void JGJPKFLCPPD<T>(int IPCBNIFLNFB, NativeArray<T> GMBKDDBJEHJ, int OCEBHFCGEGN, [Optional] T NFLJJNEBHIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x49A57D0", Offset = "0x49A41D0", VA = "0x1849A57D0")]
	private void CDHADGFDJEH(IEnumerable<EEHNACLJNNC> KDDNJPJGJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x49A5F70", Offset = "0x49A4970", VA = "0x1849A5F70")]
	private void HPDFDHNHFFO(EEHNACLJNNC JLAEFNNPNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x49A6220", Offset = "0x49A4C20", VA = "0x1849A6220")]
	private OEBLMLKOBLH JFBBIEMIOCJ(int BKEFJMGIGNE)
	{
		return default(OEBLMLKOBLH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x49A6640", Offset = "0x49A5040", VA = "0x1849A6640")]
	public void KJIHKDJOIAK(float HAJHGHLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x49A68F0", Offset = "0x49A52F0", VA = "0x1849A68F0")]
	private void KOFHDKJJMBH(Action MMADIBJKHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x49A6B40", Offset = "0x49A5540", VA = "0x1849A6B40")]
	private void OLBLBNLEEBE(Action MMADIBJKHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x49A4EB0", Offset = "0x49A38B0", VA = "0x1849A4EB0")]
	public void ACMLOAAMJCD(float HAJHGHLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x49A6A60", Offset = "0x49A5460", VA = "0x1849A6A60")]
	public void OHNGCEIGACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x49A6830", Offset = "0x49A5230", VA = "0x1849A6830")]
	public void KLAMBKCHHCD(AAGOBNEJKEK EJOCEJFEMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x49A69A0", Offset = "0x49A53A0", VA = "0x1849A69A0")]
	public void MLNBNOFGFDO(AAGOBNEJKEK EJOCEJFEMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x49A4DF0", Offset = "0x49A37F0", VA = "0x1849A4DF0")]
	public void ABOAMGDGLDJ(AAGOBNEJKEK EJOCEJFEMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class EFPIDICMOIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly EFPIDICMOIP FKDJNNEDMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action BAADPJOHFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private bool NPBJPMMAPDK;

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFD0", Offset = "0x5DD9D0", VA = "0x1805DEFD0")]
	public EFPIDICMOIP(Action BAADPJOHFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x499CFE0", Offset = "0x499B9E0", VA = "0x18499CFE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface MHNBHIOMLON<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OIFDGDNEOBM(UnityEngine.Object PHFLFPJELLC, Action<T> DNNBOCBHJEB);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface LGACDJEENGF<T> : global::MHNBHIOMLON<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	new T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class EGAGEHAJNME<T> : global::LGACDJEENGF<T>, global::MHNBHIOMLON<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class OEPFPGEKJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public global::EGAGEHAJNME<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public global::GHPCCKONNPP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
		public OEPFPGEKJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x3ACD9D0", Offset = "0x3ACC3D0", VA = "0x183ACD9D0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static GameObject PMKFHILKGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<global::GHPCCKONNPP<UnityEngine.Object, Action<T>>> PEFIGNIIKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private T AKPNAFIBLJO;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x82D430", Offset = "0x82BE30", VA = "0x18082D430", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3AC6920", Offset = "0x3AC5320", VA = "0x183AC6920", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3AC68C0", Offset = "0x3AC52C0", VA = "0x183AC68C0")]
	private static bool IJNGLPBIIKI(T MMADIBJKHHM, T ODMIEFIFOGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6CC0", Offset = "0x3AC56C0", VA = "0x183AC6CC0")]
	public EGAGEHAJNME(T FIILIHCKJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6A00", Offset = "0x3AC5400", VA = "0x183AC6A00", Slot = "6")]
	public IDisposable OIFDGDNEOBM(UnityEngine.Object PHFLFPJELLC, Action<T> DNNBOCBHJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3AC6570", Offset = "0x3AC4F70", VA = "0x183AC6570")]
	private void DGPGPEKPMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
internal struct DCGFEFIAKLL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[ReadOnly]
	public float BGCNGHINFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[ReadOnly]
	public int ACNOLLDHCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<int> KIJKMCMINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<int> LPGOLCJHANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> GKDFIKEPGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[ReadOnly]
	public NativeArray<OBECAMIBEEH> IJBCFCFPBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[ReadOnly]
	public NativeArray<float> ICMBNJMLKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[WriteOnly]
	public NativeArray<int> ALOMAEFEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[WriteOnly]
	public NativeArray<int> DDFKMMMAAMC;

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x499B370", Offset = "0x4999D70", VA = "0x18499B370")]
	public static DCGFEFIAKLL AEEGCHIFHAD(int PNCGFDDIBNC, float HAJHGHLMDGM, NativeArray<OBECAMIBEEH> BCIFDIHPHNB, NativeArray<float> KFCLMEOHNPO, NativeArray<int> CNPDLPHFOCH, NativeArray<int> BLDDEEDEDCD, NativeArray<int> CFBCJOHJEOA, NativeArray<int> LPGOLCJHANL, NativeArray<int> GKDFIKEPGBG)
	{
		return default(DCGFEFIAKLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x499B740", Offset = "0x499A140", VA = "0x18499B740", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x499B850", Offset = "0x499A250", VA = "0x18499B850")]
	private bool KHLKFEEDMDA(int LGBFGOJBLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x499B820", Offset = "0x499A220", VA = "0x18499B820")]
	private void KDPGPNPFINH(NativeArray<int> OLMEAFCLMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x499B890", Offset = "0x499A290", VA = "0x18499B890")]
	private int KMILIJHNBOG(int IHGJGFPGOOI, int OECLLAGFDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x499B670", Offset = "0x499A070", VA = "0x18499B670")]
	private void DOECJEAABDA(NativeArray<int> OLMEAFCLMCF, int LDALNAELKEC, int PFIJFDKPLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x499B440", Offset = "0x4999E40", VA = "0x18499B440")]
	private void BDCKHDMMMAF(NativeArray<int> OLMEAFCLMCF, int IIFJHDHCECH, int GMBGJMDAJGJ, int PPNGMNDLDCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class OMKIBIOOPMK : FBNEDECMBIO, IMNPHPKLLEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private MMPOKDBEDMJ[] FBACAPEBIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private JJJJIFJLAMF ANOLLPHNPED;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x49A8FB0", Offset = "0x49A79B0", VA = "0x1849A8FB0")]
	[OCMHJDCAMOC]
	private static void CKOGABKKNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x49A9A10", Offset = "0x49A8410", VA = "0x1849A9A10")]
	[Preserve]
	public OMKIBIOOPMK([GEKAHLKFDNK(null)] GLEOEPJCKCE LBLOGGBPOJG, [GEKAHLKFDNK(null)] NKBFLNAENPC HLHAMGEKDJK, [GEKAHLKFDNK(null)] HDELCEADFJL KBIJLPBAPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x49A9630", Offset = "0x49A8030", VA = "0x1849A9630", Slot = "12")]
	public override LMANBCGFHOA ICACDCCPDOG(JGALIOBJCGI PHFLFPJELLC, IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x49A92C0", Offset = "0x49A7CC0", VA = "0x1849A92C0", Slot = "13")]
	public override void HEPELHGAALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x49A90F0", Offset = "0x49A7AF0", VA = "0x1849A90F0", Slot = "15")]
	public override void FHCKENKHJGA(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x49A9760", Offset = "0x49A8160", VA = "0x1849A9760", Slot = "14")]
	protected override void JCPEDGKMAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x49A99D0", Offset = "0x49A83D0", VA = "0x1849A99D0")]
	private MMPOKDBEDMJ LOJCBPMFGFO(CHHGIHFBDMH.FDLFDEJDCEE IEADHAAGEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x49A9580", Offset = "0x49A7F80", VA = "0x1849A9580", Slot = "16")]
	internal override HMABABAFBMO HJFJJOBJLEE(IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP, Behaviour PHFLFPJELLC, AOICLLJCBMF NFMNDONCHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x49A9960", Offset = "0x49A8360", VA = "0x1849A9960", Slot = "17")]
	internal override GMJANBADOEI KHCFFPCEFLG(CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x49A9840", Offset = "0x49A8240", VA = "0x1849A9840")]
	private void KBPDALBDOBH(MMPOKDBEDMJ EIFHFDIIAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x49A9080", Offset = "0x49A7A80", VA = "0x1849A9080", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class FBNEDECMBIO : IMNPHPKLLEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly GLEOEPJCKCE LBLOGGBPOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	protected readonly NKBFLNAENPC HLHAMGEKDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly HDELCEADFJL KBIJLPBAPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private GMJANBADOEI[] JEFAGLOMPDG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static IMNPHPKLLEB JMMDLCEKNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x499E3C0", Offset = "0x499CDC0", VA = "0x18499E3C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool EDGADGDFGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x588CA0", Offset = "0x5876A0", VA = "0x180588CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CHHGIHFBDMH.FDLFDEJDCEE HEDNABKPHMN
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x560010", Offset = "0x55EA10", VA = "0x180560010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CHHGIHFBDMH.FDLFDEJDCEE);
		}
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x588BA0", Offset = "0x5875A0", VA = "0x180588BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NKBFLNAENPC MLFMKCDNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x499EC10", Offset = "0x499D610", VA = "0x18499EC10")]
	public static LMANBCGFHOA NKLBBCADBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x499EE90", Offset = "0x499D890", VA = "0x18499EE90")]
	[Preserve]
	protected FBNEDECMBIO([GEKAHLKFDNK(null)] GLEOEPJCKCE LBLOGGBPOJG, [GEKAHLKFDNK(null)] NKBFLNAENPC HLHAMGEKDJK, [GEKAHLKFDNK(null)] HDELCEADFJL KBIJLPBAPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x499E170", Offset = "0x499CB70", VA = "0x18499E170", Slot = "6")]
	public LMANBCGFHOA ADLAMHIBLDH(IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x499E180", Offset = "0x499CB80", VA = "0x18499E180", Slot = "7")]
	public LMANBCGFHOA ADLAMHIBLDH(Behaviour PHFLFPJELLC, IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract LMANBCGFHOA ICACDCCPDOG(JGALIOBJCGI PHFLFPJELLC, IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP);

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x499E970", Offset = "0x499D370", VA = "0x18499E970", Slot = "13")]
	public virtual void HEPELHGAALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x499EB90", Offset = "0x499D590", VA = "0x18499EB90", Slot = "9")]
	public void JJNFIEEAGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x499EB70", Offset = "0x499D570", VA = "0x18499EB70", Slot = "14")]
	protected virtual void JCPEDGKMAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x499EB50", Offset = "0x499D550", VA = "0x18499EB50")]
	private void JCMNHHFEMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x499EBF0", Offset = "0x499D5F0", VA = "0x18499EBF0")]
	private void NJCPONLACGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x499E950", Offset = "0x499D350", VA = "0x18499E950")]
	private void GNIIKDLBAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x499E930", Offset = "0x499D330", VA = "0x18499E930")]
	private void FOCHHCGPBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x499ECB0", Offset = "0x499D6B0", VA = "0x18499ECB0")]
	private void OBNGKJHBPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x499E3A0", Offset = "0x499CDA0", VA = "0x18499E3A0")]
	private void CPJPBODONAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x499E700", Offset = "0x499D100", VA = "0x18499E700", Slot = "15")]
	public virtual void FHCKENKHJGA(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x499ECD0", Offset = "0x499D6D0", VA = "0x18499ECD0")]
	private void PLHMDKLBDDH(GMJANBADOEI EIFHFDIIAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0xA75380", Offset = "0xA73D80", VA = "0x180A75380")]
	private GMJANBADOEI ALEGCAIJAMO(CHHGIHFBDMH.FDLFDEJDCEE IEADHAAGEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract HMABABAFBMO HJFJJOBJLEE(IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP, Behaviour FNPLMBBLDCM, AOICLLJCBMF FGCBFENHCKO);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract GMJANBADOEI KHCFFPCEFLG(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC);

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x499E480", Offset = "0x499CE80", VA = "0x18499E480", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class HMABABAFBMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly AOICLLJCBMF NFMNDONCHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly CAMBLBEJCOH PHFLFPJELLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly bool CDKCGOOPDOG;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerator<CBGPFCCMDJP> BILPNEMLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x564480", Offset = "0x562E80", VA = "0x180564480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x588180", Offset = "0x586B80", VA = "0x180588180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public CBGPFCCMDJP JCCHPCFJJDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x567460", Offset = "0x565E60", VA = "0x180567460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool OOFADGAHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x49A1630", Offset = "0x49A0030", VA = "0x1849A1630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool GODLOIOEDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0xA93A90", Offset = "0xA92490", VA = "0x180A93A90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0xB0C2B0", Offset = "0xB0ACB0", VA = "0x180B0C2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string ABDPDPAGECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x5644A0", Offset = "0x562EA0", VA = "0x1805644A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x588CD0", Offset = "0x5876D0", VA = "0x180588CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float HCLPBHFBLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x98E940", Offset = "0x98D340", VA = "0x18098E940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xC9D760", Offset = "0xC9C160", VA = "0x180C9D760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x49A1740", Offset = "0x49A0140", VA = "0x1849A1740")]
	public HMABABAFBMO(IEnumerator<CBGPFCCMDJP> CGKBPDEICKH, CAMBLBEJCOH PHFLFPJELLC, AOICLLJCBMF NFMNDONCHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x49A12C0", Offset = "0x499FCC0", VA = "0x1849A12C0")]
	public CBGPFCCMDJP ADGBBJACDFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x49A15C0", Offset = "0x499FFC0", VA = "0x1849A15C0")]
	public bool NDOKFJFJNEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x49A1530", Offset = "0x499FF30", VA = "0x1849A1530")]
	public void KLAMBKCHHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x49A16B0", Offset = "0x49A00B0", VA = "0x1849A16B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x20DB380", Offset = "0x20D9D80", VA = "0x1820DB380")]
	[CompilerGenerated]
	private void OFFMBNKLDBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class AOICLLJCBMF : LHMIGDECHKK, LMANBCGFHOA, BEIOIJBLHOA, LCANMJCMFMC, IEnumerator, CBGPFCCMDJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private CHHGIHFBDMH.FDLFDEJDCEE KLMMAPEDMCN;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private CHHGIHFBDMH.FDLFDEJDCEE DMLEJOAIDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x5ACDE0", Offset = "0x5AB7E0", VA = "0x1805ACDE0", Slot = "23")]
		get
		{
			return default(CHHGIHFBDMH.FDLFDEJDCEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public CHHGIHFBDMH.FDLFDEJDCEE EMHEOENAECA
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x7883B0", Offset = "0x786DB0", VA = "0x1807883B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private float GFNGLJBGFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x746D40", Offset = "0x745740", VA = "0x180746D40", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4998FB0", Offset = "0x49979B0", VA = "0x184998FB0", Slot = "24")]
	private bool NBGAFDOMCPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4998FA0", Offset = "0x49979A0", VA = "0x184998FA0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4998FD0", Offset = "0x49979D0", VA = "0x184998FD0")]
	public AOICLLJCBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal enum OEBLMLKOBLH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal sealed class GMJANBADOEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum IJGHKOFIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct DOHGHCGCFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public CHHGIHFBDMH.FDLFDEJDCEE JHPHPIDJHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public IJGHKOFIMOG IPDJMIHKKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public List<HMABABAFBMO> EFPGGBHLPFC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly IJGHKOFIMOG[] AGPNPACLGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool IMHPJKFJLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly HMABABAFBMO[] PGCNNELKIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly List<HMABABAFBMO> LEFPIPHHDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly Stack<int> EGCKNBKOLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly List<HMABABAFBMO> LGJKNEABAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Stack<int> JAPAIAMHKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly JJJJIFJLAMF LBGDIKLDLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool HKDOILKDBCB;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public DOHGHCGCFID[,] AHDMOEGBBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x61EF90", Offset = "0x61D990", VA = "0x18061EF90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x49A0E50", Offset = "0x499F850", VA = "0x1849A0E50")]
	public GMJANBADOEI(CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, JJJJIFJLAMF LBGDIKLDLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x49A0510", Offset = "0x499EF10", VA = "0x1849A0510")]
	public void GIEGEAHHGEB(HMABABAFBMO CGKBPDEICKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x499FBE0", Offset = "0x499E5E0", VA = "0x18499FBE0")]
	public void BIMAAALBIMG(IList<HMABABAFBMO> OAJLFEMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x49A0150", Offset = "0x499EB50", VA = "0x1849A0150")]
	public void DNFPGKHCPJI(IList<HMABABAFBMO> OAJLFEMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x49A0C80", Offset = "0x499F680", VA = "0x1849A0C80")]
	private void KMMJMLMJEFE(HMABABAFBMO CGKBPDEICKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x499FFE0", Offset = "0x499E9E0", VA = "0x18499FFE0")]
	private void DEGBNBDGMAD(IList<HMABABAFBMO> OAJLFEMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x499FE60", Offset = "0x499E860", VA = "0x18499FE60")]
	private OEBLMLKOBLH BMBODJMCCOH(HMABABAFBMO CGKBPDEICKH)
	{
		return default(OEBLMLKOBLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x49A0810", Offset = "0x499F210", VA = "0x1849A0810")]
	public void JCPEDGKMAKO(float HAJHGHLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x49A0960", Offset = "0x499F360", VA = "0x1849A0960")]
	public void JJNFIEEAGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x49A0630", Offset = "0x499F030", VA = "0x1849A0630")]
	private void HIKDGAPPOHG(List<HMABABAFBMO> OAJLFEMGKNP, Stack<int> FAKKLJDJJOA, bool ODPPNGHOMHI, float BOFIBNEEHOG = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x49A03D0", Offset = "0x499EDD0", VA = "0x1849A03D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x49A0B60", Offset = "0x499F560", VA = "0x1849A0B60")]
	private void JNPCLIFMNIN(List<HMABABAFBMO> OAJLFEMGKNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class FINELEEPAOI : JJJJIFJLAMF
{
	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "4")]
	public void CMAOAGKLBAN(string JMIBJFINBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x560B30", Offset = "0x55F530", VA = "0x180560B30", Slot = "5")]
	public void DHKMOBFGFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public FINELEEPAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class KIMEBIKAMAO : CAMBLBEJCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Behaviour FNPLMBBLDCM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string ABDPDPAGECL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x49A28F0", Offset = "0x49A12F0", VA = "0x1849A28F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool CGBMGJHDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x49A29A0", Offset = "0x49A13A0", VA = "0x1849A29A0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool MELNBBBOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x49A2980", Offset = "0x49A1380", VA = "0x1849A2980", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5DEFD0", Offset = "0x5DD9D0", VA = "0x1805DEFD0")]
	public KIMEBIKAMAO(Behaviour FNPLMBBLDCM)
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
