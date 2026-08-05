using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public static class CustomPlayerLoopInjector
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private delegate List<PlayerLoopSystem> OAJGBEPBKMK(List<PlayerLoopSystem> FGEBAPJFDIK, int DGOJKPJBMOA);

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct EPBOBPNFKNN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public struct EPDGCLDLNID
			{
				[Cpp2IlInjected.Token(Token = "0x4000002")]
				public static HDFEEIPOLMP JCMNHHFEMCO;

				[Cpp2IlInjected.Token(Token = "0x600000B")]
				[Cpp2IlInjected.Address(RVA = "0x4C90110", Offset = "0x4C8EB10", VA = "0x184C90110")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public struct EJLONAKLOKC
			{
				[Cpp2IlInjected.Token(Token = "0x4000005")]
				public static HDFEEIPOLMP NJCPONLACGE;

				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x4C8FF10", Offset = "0x4C8E910", VA = "0x184C8FF10")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public struct DGACKOBLPLP
			{
				[Cpp2IlInjected.Token(Token = "0x4000008")]
				public static HDFEEIPOLMP OBNGKJHBPHF;

				[Cpp2IlInjected.Token(Token = "0x6000015")]
				[Cpp2IlInjected.Address(RVA = "0x4C8F6F0", Offset = "0x4C8E0F0", VA = "0x184C8F6F0")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public struct GGJNBCCDFPO
			{
				[Cpp2IlInjected.Token(Token = "0x400000B")]
				public static HDFEEIPOLMP POMFHIFLAOI;

				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(RVA = "0x4C920C0", Offset = "0x4C90AC0", VA = "0x184C920C0")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000D")]
			public struct EGDNBPGBKHC
			{
				[Cpp2IlInjected.Token(Token = "0x400000E")]
				public static HDFEEIPOLMP AGFHCIMHIPC;

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x4C8FD40", Offset = "0x4C8E740", VA = "0x184C8FD40")]
				public static PlayerLoopSystem OLCLHMNPNOD()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000F")]
			internal struct GKENPDLFPFH
			{
				[Cpp2IlInjected.Token(Token = "0x2000010")]
				[CompilerGenerated]
				private sealed class NNFLKOEEGDB
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000012")]
					public FPIJLJDGAOF.PBMPAOCEGLM key;

					[Cpp2IlInjected.Token(Token = "0x6000025")]
					[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
					public NNFLKOEEGDB()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000026")]
					[Cpp2IlInjected.Address(RVA = "0x4C9A910", Offset = "0x4C99310", VA = "0x184C9A910")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000011")]
				public static IDisposable LDKBNLNPNDJ;

				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x4C92290", Offset = "0x4C90C90", VA = "0x184C92290")]
				public static PlayerLoopSystem IIHIAPNGFIL(FPIJLJDGAOF.PBMPAOCEGLM IPKOPOLJGIA)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000011")]
			internal struct MGLHCNINKJM
			{
				[Cpp2IlInjected.Token(Token = "0x2000012")]
				[CompilerGenerated]
				private sealed class OMAKPHGKFKD
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public FPIJLJDGAOF.PBMPAOCEGLM key;

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
					public OMAKPHGKFKD()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000029")]
					[Cpp2IlInjected.Address(RVA = "0x4C9ABE0", Offset = "0x4C995E0", VA = "0x184C9ABE0")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x4C96680", Offset = "0x4C95080", VA = "0x184C96680")]
				public static PlayerLoopSystem IIHIAPNGFIL(FPIJLJDGAOF.PBMPAOCEGLM IPKOPOLJGIA)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		[CompilerGenerated]
		private sealed class MIDECNMIFEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
			public MIDECNMIFEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x4C967A0", Offset = "0x4C951A0", VA = "0x184C967A0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool CINKGNCGENI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool GAOJJDJEHAI
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x4C8E390", Offset = "0x4C8CD90", VA = "0x184C8E390")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x4C8E6C0", Offset = "0x4C8D0C0", VA = "0x184C8E6C0")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x4C8CF40", Offset = "0x4C8B940", VA = "0x184C8CF40")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4C8E4F0", Offset = "0x4C8CEF0", VA = "0x184C8E4F0")]
		private static void JOOFDHPDCPJ(FPIJLJDGAOF.PBMPAOCEGLM IPKOPOLJGIA, ref PlayerLoopSystem IHAPCONAEJB, Type PDPOLJOKFPN, Type MPAFEJDEADG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x4C8E700", Offset = "0x4C8D100", VA = "0x184C8E700")]
		private static void OOIPOLBJJGN(ref PlayerLoopSystem IHAPCONAEJB, Type PDPOLJOKFPN, Type MPAFEJDEADG, OAJGBEPBKMK MCCCAAGOKPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4C8E3D0", Offset = "0x4C8CDD0", VA = "0x184C8E3D0")]
		private static void GIKOLAAKJMD(ref PlayerLoopSystem IHAPCONAEJB, Type PDPOLJOKFPN, Type MPAFEJDEADG, PlayerLoopSystem? OOOMDGNDLCI, PlayerLoopSystem? BNDJCDBBJPE)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class FPIJLJDGAOF
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum PBMPAOCEGLM
	{
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		Update,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		SchedulerUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		PostUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		FixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		RigidbodyExLateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		LateUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		PreRenderUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		PhysicsFixedUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		PhysicsUpdate,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		SendFrameStarted,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		FinishFrameRendering,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		PhysicsResetInterpolatedPosition,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		FullPlayerLoop
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class MFAAFGLJPEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public readonly PBMPAOCEGLM ILIEDFOCEFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly PKNBLIKMBHM OMFJOMKBMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private long GPINJOAMPBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long IJBOCKEINAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public long KFNIELCHNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public int AENJIGLJMPA;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4C964A0", Offset = "0x4C94EA0", VA = "0x184C964A0")]
		public MFAAFGLJPEK(PBMPAOCEGLM OPBHABOPBLF, int FHKCKGPHGKL = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4C963D0", Offset = "0x4C94DD0", VA = "0x184C963D0")]
		public void MNKJBOHKEAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4C96440", Offset = "0x4C94E40", VA = "0x184C96440")]
		public void OJGAJDCGJIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4C96200", Offset = "0x4C94C00", VA = "0x184C96200")]
		public void CMGJBLEPJKI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public static PBMPAOCEGLM[] HJBGKLEKCCE;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private static MFAAFGLJPEK[] ECBEHNINDKH;

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4C91D40", Offset = "0x4C90740", VA = "0x184C91D40")]
	public static MFAAFGLJPEK NFEAPJOFCBL(PBMPAOCEGLM IPKOPOLJGIA, int FHKCKGPHGKL = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C91CB0", Offset = "0x4C906B0", VA = "0x184C91CB0")]
	public static MFAAFGLJPEK KDMBHGPCAJJ(PBMPAOCEGLM IPKOPOLJGIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4C91EF0", Offset = "0x4C908F0", VA = "0x184C91EF0")]
	public static void PCPILADEMAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PKNBLIKMBHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public int EJAGBFMDHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Queue<double> MEBHNEJKLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private double CJILIEPCADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double AOLLHLFGLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double LOBMKBCDPPN;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double JDAKIMNLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4C9B9B0", Offset = "0x4C9A3B0", VA = "0x184C9B9B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4C9BB10", Offset = "0x4C9A510", VA = "0x184C9BB10")]
	public PKNBLIKMBHM(int GNLACGIKOGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4C9BA10", Offset = "0x4C9A410", VA = "0x184C9BA10", Slot = "4")]
	public void LOOBHGGGILA(double LFNNMJBIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B940", Offset = "0x4C9A340", VA = "0x184C9B940", Slot = "5")]
	public void HEPELHGAALN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MLNNOIKGIAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private long LKEJFKMJCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private double KDHOJDDPLON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double AGMFEPNIIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double LCEPFBAAPNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double HENHPAEIELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double CJILIEPCADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double AOLLHLFGLAP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long HEBEBONJJIP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KIDCNAFIEEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xF384D0", Offset = "0xF36ED0", VA = "0x180F384D0", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double PPNBKFKKGMO
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0xCC0FF0", Offset = "0xCBF9F0", VA = "0x180CC0FF0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double PMJFNDEJFBG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xD938E0", Offset = "0xD922E0", VA = "0x180D938E0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double JDAKIMNLGKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF383F0", Offset = "0xF36DF0", VA = "0x180F383F0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4C96EF0", Offset = "0x4C958F0", VA = "0x184C96EF0", Slot = "7")]
	public void LOOBHGGGILA(double LFNNMJBIDMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4C96EB0", Offset = "0x4C958B0", VA = "0x184C96EB0", Slot = "8")]
	public void HEPELHGAALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4C97010", Offset = "0x4C95A10", VA = "0x184C97010")]
	public MLNNOIKGIAJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public static class NIABOFLJIJO
{
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private interface BJEKEBKBOOA
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool BMJJMEHBJOA
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DCGILHLCDMK();
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private abstract class JAEHHKGHJOP<TPromise, TMainThreadPromise> : BJEKEBKBOOA where TPromise : LCANMJCMFMC where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private readonly TPromise NBHEGMIKKIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		protected readonly TMainThreadPromise MGGFLKEOJLC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise OJCIIKLEPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x3E18830", Offset = "0x3E17230", VA = "0x183E18830")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BMJJMEHBJOA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x3E18890", Offset = "0x3E17290", VA = "0x183E18890", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1203C00", Offset = "0x1202600", VA = "0x181203C00")]
		protected JAEHHKGHJOP(TPromise NBHEGMIKKIG, TMainThreadPromise DOFLMEJFHLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x3E18800", Offset = "0x3E17200", VA = "0x183E18800", Slot = "5")]
		public void DCGILHLCDMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void LPLCLJJOFPD(TPromise NBHEGMIKKIG);
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class JOOOPCNOHDF<T> : JAEHHKGHJOP<global::HJGFLNHHJHD<T>, global::EJMKJFHGFHJ<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B930", Offset = "0x3E1A330", VA = "0x183E1B930")]
		public JOOOPCNOHDF(global::HJGFLNHHJHD<T> NBHEGMIKKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B730", Offset = "0x3E1A130", VA = "0x183E1B730", Slot = "6")]
		protected override void LPLCLJJOFPD(global::HJGFLNHHJHD<T> NBHEGMIKKIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3E1B700", Offset = "0x3E1A100", VA = "0x183E1B700")]
		[CompilerGenerated]
		private void FHGDONPMEJH(T HEMKPPOPDKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x34C5720", Offset = "0x34C4120", VA = "0x1834C5720")]
		[CompilerGenerated]
		private void EAOKBGDNPBC(string EPHLCEKHMCH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class DEOMFFBJFPO : BJEKEBKBOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly Action APBFEHIGAIL;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BMJJMEHBJOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5766A0", VA = "0x180577CA0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7078F0", Offset = "0x7062F0", VA = "0x1807078F0")]
		public DEOMFFBJFPO(Action APBFEHIGAIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xF48450", Offset = "0xF46E50", VA = "0x180F48450", Slot = "5")]
		public void DCGILHLCDMK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private static readonly List<BJEKEBKBOOA> PEKDFOMDLGA;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3222040", Offset = "0x3220A40", VA = "0x183222040")]
	public static global::HJGFLNHHJHD<T> NHKHHAOCNCP<T>(this global::HJGFLNHHJHD<T> NBHEGMIKKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4C9A710", Offset = "0x4C99110", VA = "0x184C9A710")]
	public static void NHKHHAOCNCP(Action APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x3221F80", Offset = "0x3220980", VA = "0x183221F80")]
	private static global::HJGFLNHHJHD<T> EBDDFMLEDNB<T>(global::HJGFLNHHJHD<T> NBHEGMIKKIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4C9A080", Offset = "0x4C98A80", VA = "0x184C9A080")]
	private static void BLADIKCDCGM(BJEKEBKBOOA KNDAJEJHAFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x4C9A3F0", Offset = "0x4C98DF0", VA = "0x184C9A3F0")]
	private static void KDICEJNPFPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4C9A270", Offset = "0x4C98C70", VA = "0x184C9A270")]
	private static void EJFJJFIGIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4C9A340", Offset = "0x4C98D40", VA = "0x184C9A340")]
	private static void FGLDLPJONBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class KPCMHGIPDIM
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class CJBBBMPBAEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public FLCLHLLPKNN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public CJBBBMPBAEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x4C8CCC0", Offset = "0x4C8B6C0", VA = "0x184C8CCC0")]
		internal void <LoadScene>b__2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x4C8CCB0", Offset = "0x4C8B6B0", VA = "0x184C8CCB0")]
		internal void <LoadScene>b__1()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class LHDJADBLKCC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public LHDJADBLKCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x4C96050", Offset = "0x4C94A50", VA = "0x184C96050")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class GPGHDDLHLFA : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public FLCLHLLPKNN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public GPGHDDLHLFA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x4C93F00", Offset = "0x4C92900", VA = "0x184C93F00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x4C93BE0", Offset = "0x4C925E0", VA = "0x184C93BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4C93FB0", Offset = "0x4C929B0", VA = "0x184C93FB0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4C93EB0", Offset = "0x4C928B0", VA = "0x184C93EB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class GLLOINPLJJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public FLCLHLLPKNN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public GLLOINPLJJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class PKOBMICKLNB : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FLCLHLLPKNN onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private GLLOINPLJJP <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public PKOBMICKLNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4C9BBB0", Offset = "0x4C9A5B0", VA = "0x184C9BBB0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x4C9BEF0", Offset = "0x4C9A8F0", VA = "0x184C9BEF0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static LCANMJCMFMC JDNBDKHAKJK;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static AsyncOperation GLOODFLAEPJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static LCANMJCMFMC PMIINOGPPNH;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static string EGPJMBPJBPI;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static ThreadPriority GHHBILOKKAE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool MKCOIMNNCHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4C957F0", Offset = "0x4C941F0", VA = "0x184C957F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool OIJGJLPBENA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4C95E80", Offset = "0x4C94880", VA = "0x184C95E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool IFOBFHEIFOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4C95EE0", Offset = "0x4C948E0", VA = "0x184C95EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> HCKOJDKLMFH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x4C95740", Offset = "0x4C94140", VA = "0x184C95740")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x4C95DD0", Offset = "0x4C947D0", VA = "0x184C95DD0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4C95890", Offset = "0x4C94290", VA = "0x184C95890")]
	[FJOEOFBCKFM(DEGJMHBBGDK.EnteredEditModeNextFrame, 0)]
	private static void ENLEHHANJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4C95C70", Offset = "0x4C94670", VA = "0x184C95C70")]
	public static LCANMJCMFMC KPOBLBHFKHJ(string JEOEEAOHALB, LoadSceneMode HGHKAHMJDPM = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4C959D0", Offset = "0x4C943D0", VA = "0x184C959D0")]
	public static LCANMJCMFMC HHCAPNJPKHD(string JEOEEAOHALB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4C95940", Offset = "0x4C94340", VA = "0x184C95940")]
	[IteratorStateMachine(typeof(GPGHDDLHLFA))]
	private static IEnumerator<CBGPFCCMDJP> HAKLCHFCHAL(string JEOEEAOHALB, FLCLHLLPKNN ONADGBDMLKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x4C95BE0", Offset = "0x4C945E0", VA = "0x184C95BE0")]
	[IteratorStateMachine(typeof(PKOBMICKLNB))]
	private static IEnumerator<CBGPFCCMDJP> IILFGCCFIOE(string JEOEEAOHALB, LoadSceneMode HGHKAHMJDPM, FLCLHLLPKNN ONADGBDMLKD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PBGPJDCOLGH
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B8C0", Offset = "0x4C9A2C0", VA = "0x184C9B8C0")]
	public static IDisposable LJKIHPPLBEJ(this JGALIOBJCGI PHFLFPJELLC, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B840", Offset = "0x4C9A240", VA = "0x184C9B840")]
	public static IDisposable IAEILIPBKFD(this JGALIOBJCGI PHFLFPJELLC, Action<float> OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B7C0", Offset = "0x4C9A1C0", VA = "0x184C9B7C0")]
	public static IDisposable CPIJCDNACMN(this JGALIOBJCGI PHFLFPJELLC, Action<float> OJLMNNBAEBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class JPIJFGKNPAD
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x4C94AF0", Offset = "0x4C934F0", VA = "0x184C94AF0")]
	public static IDisposable EFPOPPMGPPM(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x4C94B70", Offset = "0x4C93570", VA = "0x184C94B70")]
	public static IDisposable EFPOPPMGPPM(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x4C95050", Offset = "0x4C93A50", VA = "0x184C95050")]
	public static IDisposable JCPEDGKMAKO(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x4C94EC0", Offset = "0x4C938C0", VA = "0x184C94EC0")]
	public static IDisposable GNIIKDLBAAE(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4C94E50", Offset = "0x4C93850", VA = "0x184C94E50")]
	public static IDisposable FOCHHCGPBDF(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4C94A80", Offset = "0x4C93480", VA = "0x184C94A80")]
	public static IDisposable CKFNHFCOCKK(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4C95150", Offset = "0x4C93B50", VA = "0x184C95150")]
	public static IDisposable LFPIFLGOGGF(this MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4C94D20", Offset = "0x4C93720", VA = "0x184C94D20")]
	public static IDisposable EPDIIBIKNIH(this MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4C95400", Offset = "0x4C93E00", VA = "0x184C95400")]
	public static IDisposable PCMILIDINFC(this MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4C950C0", Offset = "0x4C93AC0", VA = "0x184C950C0")]
	public static IDisposable JGDJMFOIGMH(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4C94F30", Offset = "0x4C93930", VA = "0x184C94F30")]
	public static IDisposable IIFOHJEKGDN(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4C95370", Offset = "0x4C93D70", VA = "0x184C95370")]
	public static IDisposable OPJLKLGLJOO(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4C951C0", Offset = "0x4C93BC0", VA = "0x184C951C0")]
	public static IDisposable MHCCBGHIHIC(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4C952E0", Offset = "0x4C93CE0", VA = "0x184C952E0")]
	public static IDisposable OOPDHIAAPMI(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4C95250", Offset = "0x4C93C50", VA = "0x184C95250")]
	public static IDisposable MPLDBPHJBGJ(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4C94DC0", Offset = "0x4C937C0", VA = "0x184C94DC0")]
	public static IDisposable FEMAKBGNFOA(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4C95490", Offset = "0x4C93E90", VA = "0x184C95490")]
	public static IDisposable PPIFMGFMEAJ(this MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4C94FC0", Offset = "0x4C939C0", VA = "0x184C94FC0")]
	public static IDisposable IKKOAAFOPLF(this MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class FIMNOHNKPOF
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class NLNLKLEGNCE : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public CHHGIHFBDMH.FDLFDEJDCEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private NHMDDCEBCAF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public NLNLKLEGNCE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A800", Offset = "0x4C99200", VA = "0x184C9A800", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A8C0", Offset = "0x4C992C0", VA = "0x184C9A8C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class DGMNOGABOEC : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public CHHGIHFBDMH.FDLFDEJDCEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private NHMDDCEBCAF <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public DGMNOGABOEC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F8C0", Offset = "0x4C8E2C0", VA = "0x184C8F8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F9A0", Offset = "0x4C8E3A0", VA = "0x184C8F9A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4C91AD0", Offset = "0x4C904D0", VA = "0x184C91AD0")]
	public static LMANBCGFHOA EFPOPPMGPPM(Action OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4C91960", Offset = "0x4C90360", VA = "0x184C91960")]
	public static LMANBCGFHOA EFPOPPMGPPM(Behaviour PHFLFPJELLC, Action OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4C919F0", Offset = "0x4C903F0", VA = "0x184C919F0")]
	public static LMANBCGFHOA EFPOPPMGPPM(Behaviour PHFLFPJELLC, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4C91BB0", Offset = "0x4C905B0", VA = "0x184C91BB0")]
	[IteratorStateMachine(typeof(NLNLKLEGNCE))]
	private static IEnumerator<CBGPFCCMDJP> OKKBMACFNEJ(CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action OJLMNNBAEBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4C91C30", Offset = "0x4C90630", VA = "0x184C91C30")]
	[IteratorStateMachine(typeof(DGMNOGABOEC))]
	private static IEnumerator<CBGPFCCMDJP> OKKBMACFNEJ(CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action<float> OJLMNNBAEBD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DLAKKJGNJGM
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LLKPAFEAHLC : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public NKBFLNAENPC schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public CHHGIHFBDMH.FDLFDEJDCEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private PKLKGFCCNOO <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public LLKPAFEAHLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4C96080", Offset = "0x4C94A80", VA = "0x184C96080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4C961B0", Offset = "0x4C94BB0", VA = "0x184C961B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FAC0", Offset = "0x4C8E4C0", VA = "0x184C8FAC0")]
	public static LMANBCGFHOA EFPOPPMGPPM(MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F9F0", Offset = "0x4C8E3F0", VA = "0x184C8F9F0")]
	public static LMANBCGFHOA AOHOPNJOEHC(JGALIOBJCGI PHFLFPJELLC, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, bool JKDPAGNEDCG = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FB90", Offset = "0x4C8E590", VA = "0x184C8FB90")]
	[IteratorStateMachine(typeof(LLKPAFEAHLC))]
	private static IEnumerator<CBGPFCCMDJP> OKKBMACFNEJ(NKBFLNAENPC HLHAMGEKDJK, float DNLOJCHBPLN, CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action<float> OJLMNNBAEBD, bool JKDPAGNEDCG = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class IPIAJJPLMFP
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class KHFIPODOJDA : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public CHHGIHFBDMH.FDLFDEJDCEE queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public KHFIPODOJDA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x4C95530", Offset = "0x4C93F30", VA = "0x184C95530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4C955E0", Offset = "0x4C93FE0", VA = "0x184C955E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x4C94750", Offset = "0x4C93150", VA = "0x184C94750")]
	[IteratorStateMachine(typeof(KHFIPODOJDA))]
	private static IEnumerator<CBGPFCCMDJP> CLLJGEFNGMD(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, Func<bool> DMNFPOCCJPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4C94670", Offset = "0x4C93070", VA = "0x184C94670")]
	public static LMANBCGFHOA CGEIJJDIFMM(this MonoBehaviour FNPLMBBLDCM, Func<bool> DMNFPOCCJPC, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC = CHHGIHFBDMH.FDLFDEJDCEE.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class PPAMCJACMIO
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NOPABGGDKDC : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public CHHGIHFBDMH.FDLFDEJDCEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public NOPABGGDKDC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4C9AA00", Offset = "0x4C99400", VA = "0x184C9AA00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4C9AAC0", Offset = "0x4C994C0", VA = "0x184C9AAC0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class PONEABKBGKP : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public CHHGIHFBDMH.FDLFDEJDCEE queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public Action function;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private CBGPFCCMDJP <wait>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public PONEABKBGKP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4C9BF40", Offset = "0x4C9A940", VA = "0x184C9BF40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4C9C010", Offset = "0x4C9AA10", VA = "0x184C9C010", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C810", Offset = "0x4C9B210", VA = "0x184C9C810")]
	[IteratorStateMachine(typeof(NOPABGGDKDC))]
	private static IEnumerator<CBGPFCCMDJP> NMDLEMGHEKJ(float CIGDJIOGKIP, CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C5B0", Offset = "0x4C9AFB0", VA = "0x184C9C5B0")]
	[IteratorStateMachine(typeof(PONEABKBGKP))]
	private static IEnumerator<CBGPFCCMDJP> GPDCKNEFMHG(float CIGDJIOGKIP, CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C2B0", Offset = "0x4C9ACB0", VA = "0x184C9C2B0")]
	public static IDisposable FMLMNPCECGH(this MonoBehaviour FNPLMBBLDCM, float CIGDJIOGKIP, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C180", Offset = "0x4C9AB80", VA = "0x184C9C180")]
	public static LMANBCGFHOA EDNNNJHMCMD(this MonoBehaviour FNPLMBBLDCM, float CIGDJIOGKIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C390", Offset = "0x4C9AD90", VA = "0x184C9C390")]
	public static LMANBCGFHOA FMLMNPCECGH(this MonoBehaviour FNPLMBBLDCM, float CIGDJIOGKIP, CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C210", Offset = "0x4C9AC10", VA = "0x184C9C210")]
	public static LMANBCGFHOA FCPLFFEMJOB(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C8D0", Offset = "0x4C9B2D0", VA = "0x184C9C8D0")]
	public static LMANBCGFHOA PBEKADIGECC(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C8A0", Offset = "0x4C9B2A0", VA = "0x184C9C8A0")]
	public static LMANBCGFHOA OLGGPIHKEHE(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB, [Optional] IMNPHPKLLEB IIAHJAPPDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C480", Offset = "0x4C9AE80", VA = "0x184C9C480")]
	public static LMANBCGFHOA FPBOJIIABMC(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C6E0", Offset = "0x4C9B0E0", VA = "0x184C9C6E0")]
	public static LMANBCGFHOA MHKJFJPLADN(this MonoBehaviour FNPLMBBLDCM, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C640", Offset = "0x4C9B040", VA = "0x184C9C640")]
	private static LMANBCGFHOA HGPMGDOICHP(MonoBehaviour FNPLMBBLDCM, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, Action IAMHMHMHKFB, [Optional] IMNPHPKLLEB IIAHJAPPDMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C0F0", Offset = "0x4C9AAF0", VA = "0x184C9C0F0")]
	public static LMANBCGFHOA EAFIAMLHCBK(this MonoBehaviour FNPLMBBLDCM, float GPFDIFFEJNB, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C520", Offset = "0x4C9AF20", VA = "0x184C9C520")]
	public static LMANBCGFHOA FPOEHBAJGBM(this MonoBehaviour FNPLMBBLDCM, float GPFDIFFEJNB, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C060", Offset = "0x4C9AA60", VA = "0x184C9C060")]
	public static LMANBCGFHOA BOMGFOPOHNP(this MonoBehaviour FNPLMBBLDCM, float GPFDIFFEJNB, Action IAMHMHMHKFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4C9C780", Offset = "0x4C9B180", VA = "0x184C9C780")]
	public static LMANBCGFHOA NIPNEILHNEH(this MonoBehaviour FNPLMBBLDCM, float GPFDIFFEJNB, Action IAMHMHMHKFB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class JPHOFLANPKF : DCMHDCPMEBE
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class ELAONHIOLOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public JPHOFLANPKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public ELAONHIOLOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4C900E0", Offset = "0x4C8EAE0", VA = "0x184C900E0")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class LAMDKDCKLDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public JPHOFLANPKF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public LAMDKDCKLDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4C900E0", Offset = "0x4C8EAE0", VA = "0x184C900E0")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly float HGMBNJKAALE;

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CEF0", Offset = "0x4C8B8F0", VA = "0x184C8CEF0")]
	public JPHOFLANPKF(Behaviour PHFLFPJELLC, float HGMBNJKAALE, [Optional] Action EIJJDBDCGDH, [Optional] IMNPHPKLLEB IIAHJAPPDMI, [Optional] NKBFLNAENPC HLHAMGEKDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4C949A0", Offset = "0x4C933A0", VA = "0x184C949A0", Slot = "9")]
	protected override bool OFNCDGPKIGJ(Action APBFEHIGAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4C948C0", Offset = "0x4C932C0", VA = "0x184C948C0", Slot = "10")]
	protected override bool LGHOAFNGKBL(Action APBFEHIGAIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface PGEAJDKEMOK
{
	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	bool JKICMMOOGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action ELKGADEJFDO;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool AHMAMNMLLGB(bool BKLDBHLOPOM = false);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool AHMAMNMLLGB(Action APBFEHIGAIL, bool BKLDBHLOPOM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class DCMHDCPMEBE : PGEAJDKEMOK
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class NACOOLJMPDP : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public DCMHDCPMEBE <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public NACOOLJMPDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x4C993B0", Offset = "0x4C97DB0", VA = "0x184C993B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4C99480", Offset = "0x4C97E80", VA = "0x184C99480", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly Behaviour PHFLFPJELLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly Action EIJJDBDCGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private BEIOIJBLHOA BONKFLIMBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly IMNPHPKLLEB IIAHJAPPDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	protected readonly NKBFLNAENPC HLHAMGEKDJK;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool JKICMMOOGFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8E75C0", Offset = "0x8E5FC0", VA = "0x1808E75C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action ELKGADEJFDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F010", Offset = "0x4C8DA10", VA = "0x184C8F010", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x4C8F2B0", Offset = "0x4C8DCB0", VA = "0x184C8F2B0", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F520", Offset = "0x4C8DF20", VA = "0x184C8F520")]
	protected DCMHDCPMEBE(Behaviour PHFLFPJELLC, [Optional] Action EIJJDBDCGDH, [Optional] IMNPHPKLLEB IIAHJAPPDMI, [Optional] NKBFLNAENPC HLHAMGEKDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F0B0", Offset = "0x4C8DAB0", VA = "0x184C8F0B0", Slot = "7")]
	public bool AHMAMNMLLGB(bool BKLDBHLOPOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F110", Offset = "0x4C8DB10", VA = "0x184C8F110", Slot = "8")]
	public bool AHMAMNMLLGB(Action APBFEHIGAIL, bool BKLDBHLOPOM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OFNCDGPKIGJ(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool LGHOAFNGKBL(Action APBFEHIGAIL);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F290", Offset = "0x4C8DC90", VA = "0x184C8F290")]
	protected void IDGEJFKFINA(Action APBFEHIGAIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F350", Offset = "0x4C8DD50", VA = "0x184C8F350")]
	protected LCANMJCMFMC PBJALPPEEHN(float HKANIFIKHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F160", Offset = "0x4C8DB60", VA = "0x184C8F160")]
	private void CHFCHIFKFII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F1D0", Offset = "0x4C8DBD0", VA = "0x184C8F1D0")]
	[IteratorStateMachine(typeof(NACOOLJMPDP))]
	private IEnumerator<CBGPFCCMDJP> EDAAAEMOCJN(float HKANIFIKHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4C8F250", Offset = "0x4C8DC50", VA = "0x184C8F250")]
	[CompilerGenerated]
	private void HAFPCHONHHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class AJIENPIAFBI : DCMHDCPMEBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly float KCEPDDBIFJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private readonly int DPJHPONFNOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private readonly float PCFGAPJOEFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly float[] KFCNMHPCNBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private int CABKNPNBPGE;

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CB10", Offset = "0x4C8B510", VA = "0x184C8CB10")]
	public AJIENPIAFBI(Behaviour PHFLFPJELLC, float EGINGMLIOIG, int DPJHPONFNOB, [Optional] Action EIJJDBDCGDH, float PCFGAPJOEFN = 0f, [Optional] IMNPHPKLLEB IIAHJAPPDMI, [Optional] NKBFLNAENPC HLHAMGEKDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576590", VA = "0x180577B90", Slot = "9")]
	protected override bool OFNCDGPKIGJ(Action APBFEHIGAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C8F0", Offset = "0x4C8B2F0", VA = "0x184C8C8F0", Slot = "10")]
	protected override bool LGHOAFNGKBL(Action APBFEHIGAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C860", Offset = "0x4C8B260", VA = "0x184C8C860")]
	private void FCFABOGPEAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class CKFIALJIHJN : DCMHDCPMEBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly float HGMBNJKAALE;

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CEF0", Offset = "0x4C8B8F0", VA = "0x184C8CEF0")]
	public CKFIALJIHJN(Behaviour PHFLFPJELLC, float HGMBNJKAALE, [Optional] Action EIJJDBDCGDH, [Optional] IMNPHPKLLEB IIAHJAPPDMI, [Optional] NKBFLNAENPC HLHAMGEKDJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x577B90", Offset = "0x576590", VA = "0x180577B90", Slot = "9")]
	protected override bool OFNCDGPKIGJ(Action APBFEHIGAIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CEB0", Offset = "0x4C8B8B0", VA = "0x184C8CEB0", Slot = "10")]
	protected override bool LGHOAFNGKBL(Action APBFEHIGAIL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class MLGGMILOINJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JKKGKOOMIEL : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public JKKGKOOMIEL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C947D0", Offset = "0x4C931D0", VA = "0x184C947D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4C94870", Offset = "0x4C93270", VA = "0x184C94870", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private LMANBCGFHOA AGMFHMMFCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private JGALIOBJCGI PHFLFPJELLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Action<float> OCKPMICIICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private float OLCOEEMGNDB;

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4C96D20", Offset = "0x4C95720", VA = "0x184C96D20")]
	public MLGGMILOINJ(JGALIOBJCGI PHFLFPJELLC, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x4C96B60", Offset = "0x4C95560", VA = "0x184C96B60")]
	private void FHKNPCHEADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x4C968A0", Offset = "0x4C952A0", VA = "0x184C968A0")]
	private void CHLANEDCFAI(string EPHLCEKHMCH, Action LDPEPOJJLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4C96CB0", Offset = "0x4C956B0", VA = "0x184C96CB0")]
	[IteratorStateMachine(typeof(JKKGKOOMIEL))]
	private IEnumerator<CBGPFCCMDJP> MDJPIKCEKBP(Action LDPEPOJJLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x4C96B00", Offset = "0x4C95500", VA = "0x184C96B00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4C969B0", Offset = "0x4C953B0", VA = "0x184C969B0")]
	[CompilerGenerated]
	private void CMOJMPGFMLI(string OIFFLJDLBAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public sealed class NEKOOEHDIBK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MFNEKEIBKMO : IEnumerator<CBGPFCCMDJP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private CBGPFCCMDJP <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private CBGPFCCMDJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x576C50", Offset = "0x575650", VA = "0x180576C50")]
		[DebuggerHidden]
		public MFNEKEIBKMO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4C96590", Offset = "0x4C94F90", VA = "0x184C96590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4C96630", Offset = "0x4C95030", VA = "0x184C96630", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private LMANBCGFHOA AGMFHMMFCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private MonoBehaviour FNPLMBBLDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private Action OJLMNNBAEBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private Action<float> OCKPMICIICB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private float OLCOEEMGNDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private bool JKDPAGNEDCG;

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4C99DA0", Offset = "0x4C987A0", VA = "0x184C99DA0")]
	public NEKOOEHDIBK(MonoBehaviour FNPLMBBLDCM, Action OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4C99EF0", Offset = "0x4C988F0", VA = "0x184C99EF0")]
	public NEKOOEHDIBK(MonoBehaviour FNPLMBBLDCM, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4C99C00", Offset = "0x4C98600", VA = "0x184C99C00")]
	public NEKOOEHDIBK(MonoBehaviour FNPLMBBLDCM, float DNLOJCHBPLN, Action<float> OJLMNNBAEBD, CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC, bool JKDPAGNEDCG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x4C996D0", Offset = "0x4C980D0", VA = "0x184C996D0")]
	private void EFPOPPMGPPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x4C99AB0", Offset = "0x4C984B0", VA = "0x184C99AB0")]
	private void PNOJGBJCIHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x4C997F0", Offset = "0x4C981F0", VA = "0x184C997F0")]
	private void FHKNPCHEADI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x4C994D0", Offset = "0x4C97ED0", VA = "0x184C994D0")]
	private void CHLANEDCFAI(string EPHLCEKHMCH, Action LDPEPOJJLBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x4C99A40", Offset = "0x4C98440", VA = "0x184C99A40")]
	[IteratorStateMachine(typeof(MFNEKEIBKMO))]
	private IEnumerator<CBGPFCCMDJP> MDJPIKCEKBP(Action LDPEPOJJLBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x4C99670", Offset = "0x4C98070", VA = "0x184C99670", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x4C999C0", Offset = "0x4C983C0", VA = "0x184C999C0")]
	[CompilerGenerated]
	private void KDLBFDJMMEL(string OIFFLJDLBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4C995F0", Offset = "0x4C97FF0", VA = "0x184C995F0")]
	[CompilerGenerated]
	private void CPDBJKLKDFN(string OIFFLJDLBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4C99940", Offset = "0x4C98340", VA = "0x184C99940")]
	[CompilerGenerated]
	private void JMAGLCAIEGH(string OIFFLJDLBAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[Flags]
internal enum OBECAMIBEEH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
internal sealed class LAMCEHPDNJJ : NKBFLNAENPC
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public float GOMAEIIMMPO
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4C95F40", Offset = "0x4C94940", VA = "0x184C95F40", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public float GALJJDDLDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4C96040", Offset = "0x4C94A40", VA = "0x184C96040", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public double KPLIEDHLNOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4C96020", Offset = "0x4C94A20", VA = "0x184C96020", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4C95F50", Offset = "0x4C94950", VA = "0x184C95F50")]
	[OCMHJDCAMOC]
	private static void CKOGABKKNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	[Preserve]
	internal LAMCEHPDNJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
internal interface JJJJIFJLAMF
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMAOAGKLBAN(string JMIBJFINBJD);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DHKMOBFGFFA();
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
internal interface CAMBLBEJCOH
{
	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	string ABDPDPAGECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	bool CGBMGJHDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	bool MELNBBBOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
internal class AAGOBNEJKEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public MMPOKDBEDMJ EMHEOENAECA;

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public int LJFCMJHPBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DA10", VA = "0x18054F010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x577BA0", Offset = "0x5765A0", VA = "0x180577BA0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C450", Offset = "0x4C8AE50", VA = "0x184C8C450")]
	public static CBGPFCCMDJP ADGBBJACDFC(IEnumerator<CBGPFCCMDJP> CGKBPDEICKH, AOICLLJCBMF NFMNDONCHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C5B0", Offset = "0x4C8AFB0", VA = "0x184C8C5B0")]
	public CBGPFCCMDJP ADGBBJACDFC(AOICLLJCBMF[] JOGPJODFGMD, IEnumerator<CBGPFCCMDJP>[] OAJLFEMGKNP, CBGPFCCMDJP[] LCAJHHOIMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C760", Offset = "0x4C8B160", VA = "0x184C8C760")]
	public void OEPKHJFLJIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C790", Offset = "0x4C8B190", VA = "0x184C8C790")]
	public void PPACHOKAOFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C690", Offset = "0x4C8B090", VA = "0x184C8C690")]
	public void DILLKNEEJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4C8C760", Offset = "0x4C8B160", VA = "0x184C8C760")]
	public void KLAMBKCHHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public AAGOBNEJKEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal sealed class MMPOKDBEDMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public struct EEHNACLJNNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public AAGOBNEJKEK OFJDKJHKIGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public JGALIOBJCGI JEINMAEPCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public AOICLLJCBMF KJHMDIECKAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public IEnumerator<CBGPFCCMDJP> BILPNEMLDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public CBGPFCCMDJP JCCHPCFJJDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public OBECAMIBEEH JHECACCJMFL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public struct LIICOANCHOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public CHHGIHFBDMH.FDLFDEJDCEE JHPHPIDJHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public List<EEHNACLJNNC> KFAPBMIFLDF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private sealed class FBHLCAMKKCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public MMPOKDBEDMJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public JGALIOBJCGI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public AAGOBNEJKEK routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public OBECAMIBEEH coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public AOICLLJCBMF promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public CBGPFCCMDJP currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public IEnumerator<CBGPFCCMDJP> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public FBHLCAMKKCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4C902E0", Offset = "0x4C8ECE0", VA = "0x184C902E0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[CompilerGenerated]
	private sealed class NOIAJLIJHBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public AAGOBNEJKEK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public MMPOKDBEDMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public NOIAJLIJHBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x4C9A9C0", Offset = "0x4C993C0", VA = "0x184C9A9C0")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class MPPMHGHIFKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public AAGOBNEJKEK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public MMPOKDBEDMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public MPPMHGHIFKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4C99370", Offset = "0x4C97D70", VA = "0x184C99370")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class OEMEHCMAGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public AAGOBNEJKEK schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public MMPOKDBEDMJ <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
		public OEMEHCMAGIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4C9ABA0", Offset = "0x4C995A0", VA = "0x184C9ABA0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private const OBECAMIBEEH JHIMLEBNPDI = OBECAMIBEEH.Cancelled | OBECAMIBEEH.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool[] PKLEDKGEMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private NativeArray<OBECAMIBEEH> HNIEFDFAJMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private NativeArray<float> KIICICADNPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private NativeArray<int> DDFKMMMAAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private NativeArray<int> GDCLNGLKOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private NativeArray<int> ALOMAEFEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private NativeArray<int> EIJKEHLNOPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private NativeArray<int> CHIGGIHOEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private AAGOBNEJKEK[] OLNJCJNLAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private AOICLLJCBMF[] JOGPJODFGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private JGALIOBJCGI[] AKBDFIPOKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private IEnumerator<CBGPFCCMDJP>[] HLBFEOJPCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private CBGPFCCMDJP[] NEEOAICAAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int DGNEGNFAEBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private int POIIDIEGIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly int MJJGNEHCLBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private float PFFDNBEDDFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private DCGFEFIAKLL LPEBEAAPDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private JobHandle LGDGIMBIFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private List<AAGOBNEJKEK> EKAAEEGHCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool NPKJDAPGDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private List<Action> GOCEODPBFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private List<Action> BPKAEEGDKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool HKDOILKDBCB;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public LIICOANCHOL[] EACGPAADDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x60AD00", Offset = "0x609700", VA = "0x18060AD00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4C98BC0", Offset = "0x4C975C0", VA = "0x184C98BC0")]
	private static int MJNGPFNLJGH(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4C98E10", Offset = "0x4C97810", VA = "0x184C98E10")]
	public MMPOKDBEDMJ(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4C98030", Offset = "0x4C96A30", VA = "0x184C98030")]
	private void HGIFDMNOEEI(ref int GDJMMOEDFCO, int NADLHCEDJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4C98730", Offset = "0x4C97130", VA = "0x184C98730")]
	public void JMEOCBHJBLH(JGALIOBJCGI PHFLFPJELLC, CBGPFCCMDJP KELJCMHFDCP, IEnumerator<CBGPFCCMDJP> CGKBPDEICKH, AOICLLJCBMF NFMNDONCHFK, [Optional] AAGOBNEJKEK NHNFJNLOEHP, OBECAMIBEEH APKBFECJKBD = OBECAMIBEEH.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4C98280", Offset = "0x4C96C80", VA = "0x184C98280")]
	public void IEFJNFALMBK(IEnumerable<EEHNACLJNNC> KDDNJPJGJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4C975A0", Offset = "0x4C95FA0", VA = "0x184C975A0")]
	private EEHNACLJNNC BPHFMLMLABH(int IPCBNIFLNFB)
	{
		return default(EEHNACLJNNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4C97CC0", Offset = "0x4C966C0", VA = "0x184C97CC0")]
	private void FFKGCFKJGJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2569A80", Offset = "0x2568480", VA = "0x182569A80")]
	private static void JGJPKFLCPPD<T>(int IPCBNIFLNFB, T[] GMBKDDBJEHJ, int OCEBHFCGEGN, [Optional] T NFLJJNEBHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2569A60", Offset = "0x2568460", VA = "0x182569A60")]
	private static void JGJPKFLCPPD<T>(int IPCBNIFLNFB, NativeArray<T> GMBKDDBJEHJ, int OCEBHFCGEGN, [Optional] T NFLJJNEBHIF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4C97A20", Offset = "0x4C96420", VA = "0x184C97A20")]
	private void CDHADGFDJEH(IEnumerable<EEHNACLJNNC> KDDNJPJGJBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x4C981C0", Offset = "0x4C96BC0", VA = "0x184C981C0")]
	private void HPDFDHNHFFO(EEHNACLJNNC JLAEFNNPNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4C98470", Offset = "0x4C96E70", VA = "0x184C98470")]
	private OEBLMLKOBLH JFBBIEMIOCJ(int BKEFJMGIGNE)
	{
		return default(OEBLMLKOBLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4C98890", Offset = "0x4C97290", VA = "0x184C98890")]
	public void KJIHKDJOIAK(float HAJHGHLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4C98B40", Offset = "0x4C97540", VA = "0x184C98B40")]
	private void KOFHDKJJMBH(Action MMADIBJKHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4C98D90", Offset = "0x4C97790", VA = "0x184C98D90")]
	private void OLBLBNLEEBE(Action MMADIBJKHHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4C97100", Offset = "0x4C95B00", VA = "0x184C97100")]
	public void ACMLOAAMJCD(float HAJHGHLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4C98CB0", Offset = "0x4C976B0", VA = "0x184C98CB0")]
	public void OHNGCEIGACM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x4C98A80", Offset = "0x4C97480", VA = "0x184C98A80")]
	public void KLAMBKCHHCD(AAGOBNEJKEK EJOCEJFEMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4C98BF0", Offset = "0x4C975F0", VA = "0x184C98BF0")]
	public void MLNBNOFGFDO(AAGOBNEJKEK EJOCEJFEMCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4C97040", Offset = "0x4C95A40", VA = "0x184C97040")]
	public void ABOAMGDGLDJ(AAGOBNEJKEK EJOCEJFEMCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EFPIDICMOIP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	public static readonly EFPIDICMOIP FKDJNNEDMJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private readonly Action BAADPJOHFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private bool NPBJPMMAPDK;

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7078F0", Offset = "0x7062F0", VA = "0x1807078F0")]
	public EFPIDICMOIP(Action BAADPJOHFCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4C8FC40", Offset = "0x4C8E640", VA = "0x184C8FC40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public interface MHNBHIOMLON<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable OIFDGDNEOBM(UnityEngine.Object PHFLFPJELLC, Action<T> DNNBOCBHJEB);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface LGACDJEENGF<T> : global::MHNBHIOMLON<T>
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	new T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class EGAGEHAJNME<T> : global::LGACDJEENGF<T>, global::MHNBHIOMLON<T>
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OEPFPGEKJFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public global::EGAGEHAJNME<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public global::GHPCCKONNPP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
		public OEPFPGEKJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x37E6890", Offset = "0x37E5290", VA = "0x1837E6890")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static GameObject PMKFHILKGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private readonly List<global::GHPCCKONNPP<UnityEngine.Object, Action<T>>> PEFIGNIIKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private T AKPNAFIBLJO;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public T CKLNJLLILCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x789B40", Offset = "0x788540", VA = "0x180789B40", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x37DFA80", Offset = "0x37DE480", VA = "0x1837DFA80", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x37DFA20", Offset = "0x37DE420", VA = "0x1837DFA20")]
	private static bool IJNGLPBIIKI(T MMADIBJKHHM, T ODMIEFIFOGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x37DFE20", Offset = "0x37DE820", VA = "0x1837DFE20")]
	public EGAGEHAJNME(T FIILIHCKJEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x37DFB60", Offset = "0x37DE560", VA = "0x1837DFB60", Slot = "6")]
	public IDisposable OIFDGDNEOBM(UnityEngine.Object PHFLFPJELLC, Action<T> DNNBOCBHJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x37DF6D0", Offset = "0x37DE0D0", VA = "0x1837DF6D0")]
	private void DGPGPEKPMPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[BurstCompile]
internal struct DCGFEFIAKLL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[ReadOnly]
	public float BGCNGHINFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[ReadOnly]
	public int ACNOLLDHCIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private NativeArray<int> KIJKMCMINNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private NativeArray<int> LPGOLCJHANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private NativeArray<int> GKDFIKEPGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	[ReadOnly]
	public NativeArray<OBECAMIBEEH> IJBCFCFPBOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	[ReadOnly]
	public NativeArray<float> ICMBNJMLKHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	[WriteOnly]
	public NativeArray<int> ALOMAEFEELN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	[WriteOnly]
	public NativeArray<int> DDFKMMMAAMC;

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EA80", Offset = "0x4C8D480", VA = "0x184C8EA80")]
	public static DCGFEFIAKLL AEEGCHIFHAD(int PNCGFDDIBNC, float HAJHGHLMDGM, NativeArray<OBECAMIBEEH> BCIFDIHPHNB, NativeArray<float> KFCLMEOHNPO, NativeArray<int> CNPDLPHFOCH, NativeArray<int> BLDDEEDEDCD, NativeArray<int> CFBCJOHJEOA, NativeArray<int> LPGOLCJHANL, NativeArray<int> GKDFIKEPGBG)
	{
		return default(DCGFEFIAKLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EE50", Offset = "0x4C8D850", VA = "0x184C8EE50", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EF60", Offset = "0x4C8D960", VA = "0x184C8EF60")]
	private bool KHLKFEEDMDA(int LGBFGOJBLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EF30", Offset = "0x4C8D930", VA = "0x184C8EF30")]
	private void KDPGPNPFINH(NativeArray<int> OLMEAFCLMCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EFA0", Offset = "0x4C8D9A0", VA = "0x184C8EFA0")]
	private int KMILIJHNBOG(int IHGJGFPGOOI, int OECLLAGFDCG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4C8ED80", Offset = "0x4C8D780", VA = "0x184C8ED80")]
	private void DOECJEAABDA(NativeArray<int> OLMEAFCLMCF, int LDALNAELKEC, int PFIJFDKPLKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4C8EB50", Offset = "0x4C8D550", VA = "0x184C8EB50")]
	private void BDCKHDMMMAF(NativeArray<int> OLMEAFCLMCF, int IIFJHDHCECH, int GMBGJMDAJGJ, int PPNGMNDLDCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class OMKIBIOOPMK : FBNEDECMBIO, IMNPHPKLLEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private MMPOKDBEDMJ[] FBACAPEBIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private JJJJIFJLAMF ANOLLPHNPED;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4C9ACA0", Offset = "0x4C996A0", VA = "0x184C9ACA0")]
	[OCMHJDCAMOC]
	private static void CKOGABKKNDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B700", Offset = "0x4C9A100", VA = "0x184C9B700")]
	[Preserve]
	public OMKIBIOOPMK([GEKAHLKFDNK(null)] GLEOEPJCKCE LBLOGGBPOJG, [GEKAHLKFDNK(null)] NKBFLNAENPC HLHAMGEKDJK, [GEKAHLKFDNK(null)] HDELCEADFJL KBIJLPBAPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B320", Offset = "0x4C99D20", VA = "0x184C9B320", Slot = "12")]
	public override LMANBCGFHOA ICACDCCPDOG(JGALIOBJCGI PHFLFPJELLC, IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4C9AFB0", Offset = "0x4C999B0", VA = "0x184C9AFB0", Slot = "13")]
	public override void HEPELHGAALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4C9ADE0", Offset = "0x4C997E0", VA = "0x184C9ADE0", Slot = "15")]
	public override void FHCKENKHJGA(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B450", Offset = "0x4C99E50", VA = "0x184C9B450", Slot = "14")]
	protected override void JCPEDGKMAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B6C0", Offset = "0x4C9A0C0", VA = "0x184C9B6C0")]
	private MMPOKDBEDMJ LOJCBPMFGFO(CHHGIHFBDMH.FDLFDEJDCEE IEADHAAGEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B270", Offset = "0x4C99C70", VA = "0x184C9B270", Slot = "16")]
	internal override HMABABAFBMO HJFJJOBJLEE(IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP, Behaviour PHFLFPJELLC, AOICLLJCBMF NFMNDONCHFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B650", Offset = "0x4C9A050", VA = "0x184C9B650", Slot = "17")]
	internal override GMJANBADOEI KHCFFPCEFLG(CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4C9B530", Offset = "0x4C99F30", VA = "0x184C9B530")]
	private void KBPDALBDOBH(MMPOKDBEDMJ EIFHFDIIAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4C9AD70", Offset = "0x4C99770", VA = "0x184C9AD70", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class FBNEDECMBIO : IMNPHPKLLEB, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private readonly GLEOEPJCKCE LBLOGGBPOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly NKBFLNAENPC HLHAMGEKDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly HDELCEADFJL KBIJLPBAPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private GMJANBADOEI[] JEFAGLOMPDG;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public static IMNPHPKLLEB JMMDLCEKNJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x4C90BE0", Offset = "0x4C8F5E0", VA = "0x184C90BE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static bool EDGADGDFGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5766A0", VA = "0x180577CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public CHHGIHFBDMH.FDLFDEJDCEE HEDNABKPHMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DA10", VA = "0x18054F010", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(CHHGIHFBDMH.FDLFDEJDCEE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x577BA0", Offset = "0x5765A0", VA = "0x180577BA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public NKBFLNAENPC MLFMKCDNDNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4C91430", Offset = "0x4C8FE30", VA = "0x184C91430")]
	public static LMANBCGFHOA NKLBBCADBOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4C916B0", Offset = "0x4C900B0", VA = "0x184C916B0")]
	[Preserve]
	protected FBNEDECMBIO([GEKAHLKFDNK(null)] GLEOEPJCKCE LBLOGGBPOJG, [GEKAHLKFDNK(null)] NKBFLNAENPC HLHAMGEKDJK, [GEKAHLKFDNK(null)] HDELCEADFJL KBIJLPBAPIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x4C90990", Offset = "0x4C8F390", VA = "0x184C90990", Slot = "6")]
	public LMANBCGFHOA ADLAMHIBLDH(IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x4C909A0", Offset = "0x4C8F3A0", VA = "0x184C909A0", Slot = "7")]
	public LMANBCGFHOA ADLAMHIBLDH(Behaviour PHFLFPJELLC, IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract LMANBCGFHOA ICACDCCPDOG(JGALIOBJCGI PHFLFPJELLC, IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP);

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4C91190", Offset = "0x4C8FB90", VA = "0x184C91190", Slot = "13")]
	public virtual void HEPELHGAALN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4C913B0", Offset = "0x4C8FDB0", VA = "0x184C913B0", Slot = "9")]
	public void JJNFIEEAGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4C91390", Offset = "0x4C8FD90", VA = "0x184C91390", Slot = "14")]
	protected virtual void JCPEDGKMAKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x4C91370", Offset = "0x4C8FD70", VA = "0x184C91370")]
	private void JCMNHHFEMCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x4C91410", Offset = "0x4C8FE10", VA = "0x184C91410")]
	private void NJCPONLACGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4C91170", Offset = "0x4C8FB70", VA = "0x184C91170")]
	private void GNIIKDLBAAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4C91150", Offset = "0x4C8FB50", VA = "0x184C91150")]
	private void FOCHHCGPBDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4C914D0", Offset = "0x4C8FED0", VA = "0x184C914D0")]
	private void OBNGKJHBPHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4C90BC0", Offset = "0x4C8F5C0", VA = "0x184C90BC0")]
	private void CPJPBODONAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4C90F20", Offset = "0x4C8F920", VA = "0x184C90F20", Slot = "15")]
	public virtual void FHCKENKHJGA(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4C914F0", Offset = "0x4C8FEF0", VA = "0x184C914F0")]
	private void PLHMDKLBDDH(GMJANBADOEI EIFHFDIIAPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x920C80", Offset = "0x91F680", VA = "0x180920C80")]
	private GMJANBADOEI ALEGCAIJAMO(CHHGIHFBDMH.FDLFDEJDCEE IEADHAAGEDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract HMABABAFBMO HJFJJOBJLEE(IEnumerator<CBGPFCCMDJP> CCKCPEEEIKP, Behaviour FNPLMBBLDCM, AOICLLJCBMF FGCBFENHCKO);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract GMJANBADOEI KHCFFPCEFLG(CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC);

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4C90CA0", Offset = "0x4C8F6A0", VA = "0x184C90CA0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
internal sealed class HMABABAFBMO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly AOICLLJCBMF NFMNDONCHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly CAMBLBEJCOH PHFLFPJELLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly bool CDKCGOOPDOG;

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public IEnumerator<CBGPFCCMDJP> BILPNEMLDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x553480", Offset = "0x551E80", VA = "0x180553480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x577180", Offset = "0x575B80", VA = "0x180577180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public CBGPFCCMDJP JCCHPCFJJDD
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x556460", Offset = "0x554E60", VA = "0x180556460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool OOFADGAHEKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x4C94370", Offset = "0x4C92D70", VA = "0x184C94370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool GODLOIOEDDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x958420", Offset = "0x956E20", VA = "0x180958420")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x9976C0", Offset = "0x9960C0", VA = "0x1809976C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public string ABDPDPAGECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5534A0", Offset = "0x551EA0", VA = "0x1805534A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x577CD0", Offset = "0x5766D0", VA = "0x180577CD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public float HCLPBHFBLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x883520", Offset = "0x881F20", VA = "0x180883520")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x1376C10", Offset = "0x1375610", VA = "0x181376C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x4C94480", Offset = "0x4C92E80", VA = "0x184C94480")]
	public HMABABAFBMO(IEnumerator<CBGPFCCMDJP> CGKBPDEICKH, CAMBLBEJCOH PHFLFPJELLC, AOICLLJCBMF NFMNDONCHFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x4C94000", Offset = "0x4C92A00", VA = "0x184C94000")]
	public CBGPFCCMDJP ADGBBJACDFC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x4C94300", Offset = "0x4C92D00", VA = "0x184C94300")]
	public bool NDOKFJFJNEN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x4C94270", Offset = "0x4C92C70", VA = "0x184C94270")]
	public void KLAMBKCHHCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x4C943F0", Offset = "0x4C92DF0", VA = "0x184C943F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x1ADCF50", Offset = "0x1ADB950", VA = "0x181ADCF50")]
	[CompilerGenerated]
	private void OFFMBNKLDBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
internal sealed class AOICLLJCBMF : LHMIGDECHKK, LMANBCGFHOA, BEIOIJBLHOA, LCANMJCMFMC, IEnumerator, CBGPFCCMDJP, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private CHHGIHFBDMH.FDLFDEJDCEE KLMMAPEDMCN;

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private CHHGIHFBDMH.FDLFDEJDCEE DMLEJOAIDAG
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x59BDE0", Offset = "0x59A7E0", VA = "0x18059BDE0", Slot = "23")]
		get
		{
			return default(CHHGIHFBDMH.FDLFDEJDCEE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public CHHGIHFBDMH.FDLFDEJDCEE EMHEOENAECA
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x718FE0", Offset = "0x7179E0", VA = "0x180718FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private float GFNGLJBGFJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6FAC90", Offset = "0x6F9690", VA = "0x1806FAC90", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CC30", Offset = "0x4C8B630", VA = "0x184C8CC30", Slot = "24")]
	private bool NBGAFDOMCPA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CC20", Offset = "0x4C8B620", VA = "0x184C8CC20", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x4C8CC50", Offset = "0x4C8B650", VA = "0x184C8CC50")]
	public AOICLLJCBMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
internal enum OEBLMLKOBLH : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class GMJANBADOEI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum IJGHKOFIMOG
	{
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public struct DOHGHCGCFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public CHHGIHFBDMH.FDLFDEJDCEE JHPHPIDJHEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public IJGHKOFIMOG IPDJMIHKKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public List<HMABABAFBMO> EFPGGBHLPFC;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static readonly IJGHKOFIMOG[] AGPNPACLGHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly CHHGIHFBDMH.FDLFDEJDCEE GJLIHHNFODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private bool IMHPJKFJLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly HMABABAFBMO[] PGCNNELKIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<HMABABAFBMO> LEFPIPHHDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly Stack<int> EGCKNBKOLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly List<HMABABAFBMO> LGJKNEABAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly Stack<int> JAPAIAMHKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly JJJJIFJLAMF LBGDIKLDLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private bool HKDOILKDBCB;

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public DOHGHCGCFID[,] AHDMOEGBBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5F2180", Offset = "0x5F0B80", VA = "0x1805F2180")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4C93770", Offset = "0x4C92170", VA = "0x184C93770")]
	public GMJANBADOEI(CHHGIHFBDMH.FDLFDEJDCEE CIJHEHLCGIG, JJJJIFJLAMF LBGDIKLDLLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4C92E30", Offset = "0x4C91830", VA = "0x184C92E30")]
	public void GIEGEAHHGEB(HMABABAFBMO CGKBPDEICKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4C92500", Offset = "0x4C90F00", VA = "0x184C92500")]
	public void BIMAAALBIMG(IList<HMABABAFBMO> OAJLFEMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4C92A70", Offset = "0x4C91470", VA = "0x184C92A70")]
	public void DNFPGKHCPJI(IList<HMABABAFBMO> OAJLFEMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4C935A0", Offset = "0x4C91FA0", VA = "0x184C935A0")]
	private void KMMJMLMJEFE(HMABABAFBMO CGKBPDEICKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4C92900", Offset = "0x4C91300", VA = "0x184C92900")]
	private void DEGBNBDGMAD(IList<HMABABAFBMO> OAJLFEMGKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4C92780", Offset = "0x4C91180", VA = "0x184C92780")]
	private OEBLMLKOBLH BMBODJMCCOH(HMABABAFBMO CGKBPDEICKH)
	{
		return default(OEBLMLKOBLH);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4C93130", Offset = "0x4C91B30", VA = "0x184C93130")]
	public void JCPEDGKMAKO(float HAJHGHLMDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4C93280", Offset = "0x4C91C80", VA = "0x184C93280")]
	public void JJNFIEEAGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4C92F50", Offset = "0x4C91950", VA = "0x184C92F50")]
	private void HIKDGAPPOHG(List<HMABABAFBMO> OAJLFEMGKNP, Stack<int> FAKKLJDJJOA, bool ODPPNGHOMHI, float BOFIBNEEHOG = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4C92CF0", Offset = "0x4C916F0", VA = "0x184C92CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4C93480", Offset = "0x4C91E80", VA = "0x184C93480")]
	private void JNPCLIFMNIN(List<HMABABAFBMO> OAJLFEMGKNP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
internal class FINELEEPAOI : JJJJIFJLAMF
{
	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "4")]
	public void CMAOAGKLBAN(string JMIBJFINBJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x54FB30", Offset = "0x54E530", VA = "0x18054FB30", Slot = "5")]
	public void DHKMOBFGFFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public FINELEEPAOI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal class KIMEBIKAMAO : CAMBLBEJCOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Behaviour FNPLMBBLDCM;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public string ABDPDPAGECL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4C95630", Offset = "0x4C94030", VA = "0x184C95630", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool CGBMGJHDAAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x4C956E0", Offset = "0x4C940E0", VA = "0x184C956E0", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool MELNBBBOHKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x4C956C0", Offset = "0x4C940C0", VA = "0x184C956C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x7078F0", Offset = "0x7062F0", VA = "0x1807078F0")]
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
