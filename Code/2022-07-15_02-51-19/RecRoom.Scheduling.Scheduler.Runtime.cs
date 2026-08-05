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
public class BMFPAHKEANM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority KHIALAHBKPP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4722F60", Offset = "0x4721F60", VA = "0x184722F60")]
	public BMFPAHKEANM(ThreadPriority OJOECCMFGMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4722F50", Offset = "0x4721F50", VA = "0x184722F50", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> JCJNKMGKEMK(List<PlayerLoopSystem> CEECPPFMAHJ, int FOMJJIMCNKO);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct FNGHOFGKGKA
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct OCBKHAHLKHH
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static KADOKFFMEKA BJJBOPCHBAJ;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x4733380", Offset = "0x4732380", VA = "0x184733380")]
				public static PlayerLoopSystem EMODJNFNDBH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct IEJKJMEHPPM
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static KADOKFFMEKA EJBJBNHHKGH;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x472BDD0", Offset = "0x472ADD0", VA = "0x18472BDD0")]
				public static PlayerLoopSystem EMODJNFNDBH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct GJAPBNLIKBP
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static KADOKFFMEKA DGKLPDFPHBP;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x4729BC0", Offset = "0x4728BC0", VA = "0x184729BC0")]
				public static PlayerLoopSystem EMODJNFNDBH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct LDOEJNGJNPM
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static KADOKFFMEKA EJKHKELDABG;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x47303C0", Offset = "0x472F3C0", VA = "0x1847303C0")]
				public static PlayerLoopSystem EMODJNFNDBH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct KFAPMIMBKPI
			{
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static KADOKFFMEKA GNCBMFLGCBL;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x472F8E0", Offset = "0x472E8E0", VA = "0x18472F8E0")]
				public static PlayerLoopSystem EMODJNFNDBH()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			internal struct FJJDMFKJCNK
			{
				[Cpp2IlInjected.Token(Token = "0x2000011")]
				[CompilerGenerated]
				private sealed class DCNGAFEMCBC
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public AJOHKOJINKP.PCPMDKIMMHF key;

					[Cpp2IlInjected.Token(Token = "0x6000027")]
					[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
					public DCNGAFEMCBC()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x4725F20", Offset = "0x4724F20", VA = "0x184725F20")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static IDisposable CPFGFGKCEEK;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x4728CF0", Offset = "0x4727CF0", VA = "0x184728CF0")]
				public static PlayerLoopSystem CNICFOKDKBO(AJOHKOJINKP.PCPMDKIMMHF GLMMMFPEBHE)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000012")]
			internal struct HEJMPLFKBBC
			{
				[Cpp2IlInjected.Token(Token = "0x2000013")]
				[CompilerGenerated]
				private sealed class MIPODOGDKPL
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000014")]
					public AJOHKOJINKP.PCPMDKIMMHF key;

					[Cpp2IlInjected.Token(Token = "0x600002A")]
					[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
					public MIPODOGDKPL()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600002B")]
					[Cpp2IlInjected.Address(RVA = "0x4732D20", Offset = "0x4731D20", VA = "0x184732D20")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x472A980", Offset = "0x4729980", VA = "0x18472A980")]
				public static PlayerLoopSystem CNICFOKDKBO(AJOHKOJINKP.PCPMDKIMMHF GLMMMFPEBHE)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class JCBHBIFAKKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
			public JCBHBIFAKKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x472BFA0", Offset = "0x472AFA0", VA = "0x18472BFA0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KNMMPKMNBFO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool LEOACCKFNNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x4725EE0", Offset = "0x4724EE0", VA = "0x184725EE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4725950", Offset = "0x4724950", VA = "0x184725950")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x47243E0", Offset = "0x47233E0", VA = "0x1847243E0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4725D10", Offset = "0x4724D10", VA = "0x184725D10")]
		private static void KKCLEMBNOAB(AJOHKOJINKP.PCPMDKIMMHF GLMMMFPEBHE, ref PlayerLoopSystem IOCFNGEAMKL, Type BAKHEPJPACB, Type BLDHJKKLBMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4725990", Offset = "0x4724990", VA = "0x184725990")]
		private static void KFBMNGNICJM(ref PlayerLoopSystem IOCFNGEAMKL, Type BAKHEPJPACB, Type BLDHJKKLBMB, JCJNKMGKEMK PDDECKAKHAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x4725830", Offset = "0x4724830", VA = "0x184725830")]
		private static void EIJHAOKGEEG(ref PlayerLoopSystem IOCFNGEAMKL, Type BAKHEPJPACB, Type BLDHJKKLBMB, PlayerLoopSystem? DKOOPBBJMID, PlayerLoopSystem? AKHHLAIPMFN)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class AJOHKOJINKP
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum PCPMDKIMMHF
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
	public class ACKIHINHFNN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly PCPMDKIMMHF PHHDCOMCLDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly FMCOHEPLFOL LJLIKMPHAEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long PAJBPLFEEAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long BDBLDNPNDHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public long OFOFMBNCMLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int HIBODAFCLBM;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4720DA0", Offset = "0x471FDA0", VA = "0x184720DA0")]
		public ACKIHINHFNN(PCPMDKIMMHF DPEIPOKHBJG, int BOJPFKJHAJC = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4720D30", Offset = "0x471FD30", VA = "0x184720D30")]
		public void MOLMJKNKJCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x4720CD0", Offset = "0x471FCD0", VA = "0x184720CD0")]
		public void MJLAHODGHKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4720B00", Offset = "0x471FB00", VA = "0x184720B00")]
		public void DEIFAFNJBGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static PCPMDKIMMHF[] MALNFMPEDFL;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static ACKIHINHFNN[] HCMCLDMDDFP;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x47216C0", Offset = "0x47206C0", VA = "0x1847216C0")]
	public static ACKIHINHFNN KHLPONGLJEI(PCPMDKIMMHF GLMMMFPEBHE, int BOJPFKJHAJC = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x4721630", Offset = "0x4720630", VA = "0x184721630")]
	public static ACKIHINHFNN FOCFGDGAFFK(PCPMDKIMMHF GLMMMFPEBHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x4721580", Offset = "0x4720580", VA = "0x184721580")]
	public static void ALMBAKFDDAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class FMCOHEPLFOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int LHHHJHDJCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Queue<double> KOPECELNMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double HKAKKDBNNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double OBPPMPNHIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double GFNEBLDCLLB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double EHPBMLMLEKK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x4728E10", Offset = "0x4727E10", VA = "0x184728E10", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4728FE0", Offset = "0x4727FE0", VA = "0x184728FE0")]
	public FMCOHEPLFOL(int JPLHKMNLOJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4728EE0", Offset = "0x4727EE0", VA = "0x184728EE0", Slot = "4")]
	public void MPGCPFCBHOE(double LBEFLEJKHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4728E70", Offset = "0x4727E70", VA = "0x184728E70", Slot = "5")]
	public void MIGBKHAMFOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class JJPMCMINHEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private long GLCMJLMDOEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double JELEBNBCKAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double LIDDGEHHCGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double OMFMMPEIFAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double BAJFMHHLLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double HKAKKDBNNKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double OBPPMPNHIIG;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long MMNJCBPCOIK
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double PDBCIPPFHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3A6ED70", Offset = "0x3A6DD70", VA = "0x183A6ED70", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double MMJBFNEOMFL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9D3380", Offset = "0x9D2380", VA = "0x1809D3380", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double PBPIIALBJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x35EFF60", Offset = "0x35EEF60", VA = "0x1835EFF60")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double EHPBMLMLEKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3A6ECA0", Offset = "0x3A6DCA0", VA = "0x183A6ECA0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x472E470", Offset = "0x472D470", VA = "0x18472E470", Slot = "7")]
	public void MPGCPFCBHOE(double LBEFLEJKHJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x472E430", Offset = "0x472D430", VA = "0x18472E430", Slot = "8")]
	public void MIGBKHAMFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x472E590", Offset = "0x472D590", VA = "0x18472E590")]
	public JJPMCMINHEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class DFBMJHIDNED
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface GEDDBGMBKJH
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool HMJLBIBAGGB
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JHIPCMEIJDH();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private abstract class AIHICLMEGFG<TPromise, TMainThreadPromise> : GEDDBGMBKJH where TPromise : GNLNKOKJLFP where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly TPromise AGDHMBDPAMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected readonly TMainThreadPromise MOOOFFPLAMK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise CIPDFDEBABE
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x3A183F0", Offset = "0x3A173F0", VA = "0x183A183F0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HMJLBIBAGGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x3A18450", Offset = "0x3A17450", VA = "0x183A18450", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2188EE0", Offset = "0x2187EE0", VA = "0x182188EE0")]
		protected AIHICLMEGFG(TPromise AGDHMBDPAMP, TMainThreadPromise BJNHDCANNEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x3A184A0", Offset = "0x3A174A0", VA = "0x183A184A0", Slot = "5")]
		public void JHIPCMEIJDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void KDLIGEEHNON(TPromise AGDHMBDPAMP);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class JBDGCLLHPNJ<T> : AIHICLMEGFG<global::BDGKEGGAANF<T>, global::ADIAEJHDLBD<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x3A34280", Offset = "0x3A33280", VA = "0x183A34280")]
		public JBDGCLLHPNJ(global::BDGKEGGAANF<T> AGDHMBDPAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x3A34050", Offset = "0x3A33050", VA = "0x183A34050", Slot = "6")]
		protected override void KDLIGEEHNON(global::BDGKEGGAANF<T> AGDHMBDPAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x3A34020", Offset = "0x3A33020", VA = "0x183A34020")]
		[CompilerGenerated]
		private void CFPHDHKIBNL(T CLNIDHLHIFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x3A34250", Offset = "0x3A33250", VA = "0x183A34250")]
		[CompilerGenerated]
		private void MILCMBCCMIJ(string BCELONFJGJN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class FGOAPKIKMHA : GEDDBGMBKJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Action HCHPGKLEJDC;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HMJLBIBAGGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x58DFE0", Offset = "0x58CFE0", VA = "0x18058DFE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6C2360", Offset = "0x6C1360", VA = "0x1806C2360")]
		public FGOAPKIKMHA(Action HCHPGKLEJDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1427BE0", Offset = "0x1426BE0", VA = "0x181427BE0", Slot = "5")]
		public void JHIPCMEIJDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly List<GEDDBGMBKJH> LBMABMDFJNE;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1EDD7A0", Offset = "0x1EDC7A0", VA = "0x181EDD7A0")]
	public static global::BDGKEGGAANF<T> BACMECIHDEO<T>(this global::BDGKEGGAANF<T> AGDHMBDPAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x4725FD0", Offset = "0x4724FD0", VA = "0x184725FD0")]
	public static void BACMECIHDEO(Action HCHPGKLEJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x1EDD810", Offset = "0x1EDC810", VA = "0x181EDD810")]
	private static global::BDGKEGGAANF<T> OJKANFJAGIP<T>(global::BDGKEGGAANF<T> AGDHMBDPAMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4726060", Offset = "0x4725060", VA = "0x184726060")]
	private static void CIPMDCKLFBH(GEDDBGMBKJH FJILMILJHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4726320", Offset = "0x4725320", VA = "0x184726320")]
	private static void GBAOMKMCALE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4726250", Offset = "0x4725250", VA = "0x184726250")]
	private static void DEFAFIJGGFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4726640", Offset = "0x4725640", VA = "0x184726640")]
	private static void NDJEJACDJDN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class DJGJKGKOFOO
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct HIDCLLOPOBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public TaskCompletionSource<Scene> GIJMJCCBNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public readonly string EFOJHKPKFDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly LoadSceneMode FMJFMJEDFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly bool JDLCNPPCHID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly IDCNIFDHJNO NOFLFLCNPPD;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x472B150", Offset = "0x472A150", VA = "0x18472B150")]
		public HIDCLLOPOBD(TaskCompletionSource<Scene> PCFIHJJEBPI, string EFOJHKPKFDD, LoadSceneMode FMJFMJEDFAO, bool JDLCNPPCHID, IDCNIFDHJNO NOFLFLCNPPD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private struct CDMEKIAOAOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public IDCNIFDHJNO stackTimerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private global::IKBIJKLPGMJ<string> <toDispose>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskCompletionSource<Scene> <taskCompletionSource>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		private TaskAwaiter<Scene> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x4723110", Offset = "0x4722110", VA = "0x184723110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x4723670", Offset = "0x4722670", VA = "0x184723670", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct EFPECJKAHCI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x4727DE0", Offset = "0x4726DE0", VA = "0x184727DE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7EEFE0", Offset = "0x7EDFE0", VA = "0x1807EEFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct APDNBPPKEHF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private HIDCLLOPOBD <dequeued>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x4721990", Offset = "0x4720990", VA = "0x184721990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7EEFE0", Offset = "0x7EDFE0", VA = "0x1807EEFE0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class NKKMIMDNPOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public global::ADIAEJHDLBD<Scene> promise;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public NKKMIMDNPOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x4733110", Offset = "0x4732110", VA = "0x184733110")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct HNIFBOBEMCF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public IDCNIFDHJNO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private NKKMIMDNPOH <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private IDCNIFDHJNO <loadSceneTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private IDCNIFDHJNO <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x472B1B0", Offset = "0x472A1B0", VA = "0x18472B1B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x472B970", Offset = "0x472A970", VA = "0x18472B970", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct LDJGBJJKDEK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public AsyncTaskMethodBuilder<Scene> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public IDCNIFDHJNO stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private Scene <emptyScene>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private IDCNIFDHJNO <emptySceneRoutineTimer>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private IDCNIFDHJNO <emptySceneTimer>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TaskAwaiter<Scene> <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x472FC70", Offset = "0x472EC70", VA = "0x18472FC70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4730370", Offset = "0x472F370", VA = "0x184730370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class ACBMPJMMDEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public ACBMPJMMDEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4720AD0", Offset = "0x471FAD0", VA = "0x184720AD0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class CPFJBINCPBB : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public IHNBEKDFILG onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public CPFJBINCPBB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x47242E0", Offset = "0x47232E0", VA = "0x1847242E0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x4723FA0", Offset = "0x4722FA0", VA = "0x184723FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x4724390", Offset = "0x4723390", VA = "0x184724390")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x4724290", Offset = "0x4723290", VA = "0x184724290", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class BJEHFEHOFKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public global::ADIAEJHDLBD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public BJEHFEHOFKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class LIBFLKLFJJG : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public global::ADIAEJHDLBD<Scene> onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private BJEHFEHOFKH <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public LIBFLKLFJJG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4730590", Offset = "0x472F590", VA = "0x184730590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x47309A0", Offset = "0x472F9A0", VA = "0x1847309A0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static GNLNKOKJLFP ELIPNCFLJCA;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation FOKKAOEKOPJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static GNLNKOKJLFP IPNANCFLBDA;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string JAJOHGFGDBF;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority POLDLJHDPBD;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static Task MJKFCJDDLIA;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Queue<HIDCLLOPOBD> MBDFFNNJGKA;

	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private static Task FOMAMAGJCKI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool OBDDAEGCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x4726AA0", Offset = "0x4725AA0", VA = "0x184726AA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool NHACPOLMAIE
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x4726910", Offset = "0x4725910", VA = "0x184726910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool DFFNNLEMDEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x4727B10", Offset = "0x4726B10", VA = "0x184727B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> CNODLOGCGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x4726C50", Offset = "0x4725C50", VA = "0x184726C50")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x4726E90", Offset = "0x4725E90", VA = "0x184726E90")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47275B0", Offset = "0x47265B0", VA = "0x1847275B0")]
	[LEDBAOJCIJA(NOJCFKMJDIB.EnteredEditModeNextFrame, 0)]
	private static void IJGAENBPPLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4726D50", Offset = "0x4725D50", VA = "0x184726D50")]
	[AsyncStateMachine(typeof(CDMEKIAOAOB))]
	public static Task<Scene> DGFPMJIHHJP(string EFOJHKPKFDD, LoadSceneMode FMJFMJEDFAO = LoadSceneMode.Single, bool JDLCNPPCHID = false, [Optional] IDCNIFDHJNO AFJOJGANNGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x47273B0", Offset = "0x47263B0", VA = "0x1847273B0")]
	[AsyncStateMachine(typeof(EFPECJKAHCI))]
	private static Task GHEDJEBHAPJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x47269C0", Offset = "0x47259C0", VA = "0x1847269C0")]
	[AsyncStateMachine(typeof(APDNBPPKEHF))]
	private static Task BHDJFOEHDMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x47277D0", Offset = "0x47267D0", VA = "0x1847277D0")]
	[AsyncStateMachine(typeof(HNIFBOBEMCF))]
	private static Task<Scene> JPKPNLNNNCC(string EFOJHKPKFDD, LoadSceneMode FMJFMJEDFAO, bool JDLCNPPCHID, IDCNIFDHJNO NOFLFLCNPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4727490", Offset = "0x4726490", VA = "0x184727490")]
	[AsyncStateMachine(typeof(LDJGBJJKDEK))]
	private static Task<Scene> HJOLJIAEJAB(IDCNIFDHJNO NOFLFLCNPPD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x47279A0", Offset = "0x47269A0", VA = "0x1847279A0")]
	public static global::BDGKEGGAANF<Scene> OIIMCGIEFBL(string EFOJHKPKFDD, LoadSceneMode FMJFMJEDFAO = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4726F90", Offset = "0x4725F90", VA = "0x184726F90")]
	public static GNLNKOKJLFP EBFNDAGDBAK(string EFOJHKPKFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4727910", Offset = "0x4726910", VA = "0x184727910")]
	[IteratorStateMachine(typeof(CPFJBINCPBB))]
	private static IEnumerator<HGLMJIKIMPH> MPEPKCCLANF(string EFOJHKPKFDD, IHNBEKDFILG BDDNIAFKJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4726880", Offset = "0x4725880", VA = "0x184726880")]
	[IteratorStateMachine(typeof(LIBFLKLFJJG))]
	private static IEnumerator<HGLMJIKIMPH> BEKNKCLLNHB(string EFOJHKPKFDD, LoadSceneMode FMJFMJEDFAO, global::ADIAEJHDLBD<Scene> BDDNIAFKJHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4727680", Offset = "0x4726680", VA = "0x184727680")]
	public static bool IOAEDIIFKDE(out string ENOCDLIJJLC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class NIGDJPBLDLN
{
	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4733090", Offset = "0x4732090", VA = "0x184733090")]
	public static IDisposable JHLMNLEGIAN(this AGFHDCKDPDI NPAGOMGBIJA, float JDBFBFAEGJB, Action<float> PKJACDPGIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4732F90", Offset = "0x4731F90", VA = "0x184732F90")]
	public static IDisposable AGDKLCJNPHJ(this AGFHDCKDPDI NPAGOMGBIJA, Action<float> PKJACDPGIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4733010", Offset = "0x4732010", VA = "0x184733010")]
	public static IDisposable HBLBLMCEDCP(this AGFHDCKDPDI NPAGOMGBIJA, Action<float> PKJACDPGIHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class HCPPJMAFCOP
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x472A6A0", Offset = "0x47296A0", VA = "0x18472A6A0")]
	public static IDisposable NGDHHKBACBE(this MonoBehaviour MADHPHKBBEN, Action PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x472A720", Offset = "0x4729720", VA = "0x18472A720")]
	public static IDisposable NGDHHKBACBE(this MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x472A130", Offset = "0x4729130", VA = "0x18472A130")]
	public static IDisposable HFCDGCMEJPN(this MonoBehaviour MADHPHKBBEN, Action PKJACDPGIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x472A0C0", Offset = "0x47290C0", VA = "0x18472A0C0")]
	public static IDisposable HACHGPIJOGH(this MonoBehaviour MADHPHKBBEN, Action PKJACDPGIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4729F40", Offset = "0x4728F40", VA = "0x184729F40")]
	public static IDisposable DDMICJGFALP(this MonoBehaviour MADHPHKBBEN, Action PKJACDPGIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4729FB0", Offset = "0x4728FB0", VA = "0x184729FB0")]
	public static IDisposable EMBODCDHMNH(this MonoBehaviour MADHPHKBBEN, Action PKJACDPGIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x472A3E0", Offset = "0x47293E0", VA = "0x18472A3E0")]
	public static IDisposable IHJBKIPPOPK(this MonoBehaviour MADHPHKBBEN, Action PKJACDPGIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x472A600", Offset = "0x4729600", VA = "0x18472A600")]
	public static IDisposable NGAJDCGNNAB(this MonoBehaviour MADHPHKBBEN, float JDBFBFAEGJB, Action<float> PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x472A020", Offset = "0x4729020", VA = "0x18472A020")]
	public static IDisposable GJPGGDHAEME(this MonoBehaviour MADHPHKBBEN, float JDBFBFAEGJB, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x472A230", Offset = "0x4729230", VA = "0x18472A230")]
	public static IDisposable HONDOCOLNPC(this MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x472A350", Offset = "0x4729350", VA = "0x18472A350")]
	public static IDisposable IBKKBOEGFDD(this MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x472A450", Offset = "0x4729450", VA = "0x18472A450")]
	public static IDisposable INAPFAMHMHE(this MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x472A1A0", Offset = "0x47291A0", VA = "0x18472A1A0")]
	public static IDisposable HKOJANFIBDC(this MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x472A570", Offset = "0x4729570", VA = "0x18472A570")]
	public static IDisposable MDKJLEOGKML(this MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x472A4E0", Offset = "0x47294E0", VA = "0x18472A4E0")]
	public static IDisposable MBJGFFNIEDE(this MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x472A2C0", Offset = "0x47292C0", VA = "0x18472A2C0")]
	public static IDisposable IAGOPGHCGIB(this MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4729EA0", Offset = "0x4728EA0", VA = "0x184729EA0")]
	public static IDisposable CHAKKFKGJGO(this MonoBehaviour MADHPHKBBEN, float JDBFBFAEGJB, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x472A8F0", Offset = "0x47298F0", VA = "0x18472A8F0")]
	public static IDisposable PAGKKGDDCPE(this MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class JKGOHLCMHGP
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OBDIKFALNJD : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public DJIMLFADNNM.NNFKCEBEIKK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private LIOCGLFKFEH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AA")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public OBDIKFALNJD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4733160", Offset = "0x4732160", VA = "0x184733160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x4733220", Offset = "0x4732220", VA = "0x184733220", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class DNMKAMLCEJN : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public DJIMLFADNNM.NNFKCEBEIKK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private LIOCGLFKFEH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public DNMKAMLCEJN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x4727C70", Offset = "0x4726C70", VA = "0x184727C70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x4727D50", Offset = "0x4726D50", VA = "0x184727D50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x472E6C0", Offset = "0x472D6C0", VA = "0x18472E6C0")]
	public static ELHLMKINOCP NGDHHKBACBE(Action PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x472E7A0", Offset = "0x472D7A0", VA = "0x18472E7A0")]
	public static ELHLMKINOCP NGDHHKBACBE(Behaviour NPAGOMGBIJA, Action PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x472E830", Offset = "0x472D830", VA = "0x18472E830")]
	public static ELHLMKINOCP NGDHHKBACBE(Behaviour NPAGOMGBIJA, Action<float> PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x472E5C0", Offset = "0x472D5C0", VA = "0x18472E5C0")]
	[IteratorStateMachine(typeof(OBDIKFALNJD))]
	private static IEnumerator<HGLMJIKIMPH> BMGBDKMNKOK(DJIMLFADNNM.NNFKCEBEIKK EFDLAJEDOPC, Action PKJACDPGIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x472E640", Offset = "0x472D640", VA = "0x18472E640")]
	[IteratorStateMachine(typeof(DNMKAMLCEJN))]
	private static IEnumerator<HGLMJIKIMPH> BMGBDKMNKOK(DJIMLFADNNM.NNFKCEBEIKK EFDLAJEDOPC, Action<float> PKJACDPGIHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public static class BKNOCKOEAIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[CompilerGenerated]
	private sealed class OHJLFKGJPEO : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public PHFCPBFIOHJ schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public DJIMLFADNNM.NNFKCEBEIKK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private ENMIIOBMEBB <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public OHJLFKGJPEO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4733550", Offset = "0x4732550", VA = "0x184733550", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4733680", Offset = "0x4732680", VA = "0x184733680", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4722860", Offset = "0x4721860", VA = "0x184722860")]
	public static ELHLMKINOCP NGDHHKBACBE(MonoBehaviour MADHPHKBBEN, float JDBFBFAEGJB, Action<float> PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO, bool BDHJAADJCMC = true, [Optional] HDOKLIGPDIG JNMHFJMLAFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4722780", Offset = "0x4721780", VA = "0x184722780")]
	public static ELHLMKINOCP EONLMBOKJCB(AGFHDCKDPDI NPAGOMGBIJA, float JDBFBFAEGJB, Action<float> PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO, bool BDHJAADJCMC = true, [Optional] HDOKLIGPDIG JNMHFJMLAFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x47226D0", Offset = "0x47216D0", VA = "0x1847226D0")]
	[IteratorStateMachine(typeof(OHJLFKGJPEO))]
	private static IEnumerator<HGLMJIKIMPH> BMGBDKMNKOK(PHFCPBFIOHJ PLLBODOMIMI, float JDBFBFAEGJB, DJIMLFADNNM.NNFKCEBEIKK EFDLAJEDOPC, Action<float> PKJACDPGIHH, bool BDHJAADJCMC = true, [Optional] HDOKLIGPDIG JNMHFJMLAFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public static class AELOAOPDOBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class DIHHDAABAGO : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public DJIMLFADNNM.NNFKCEBEIKK queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public DIHHDAABAGO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4726780", Offset = "0x4725780", VA = "0x184726780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4726830", Offset = "0x4725830", VA = "0x184726830", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4720F70", Offset = "0x471FF70", VA = "0x184720F70")]
	[IteratorStateMachine(typeof(DIHHDAABAGO))]
	private static IEnumerator<HGLMJIKIMPH> KBPGHONGMKG(DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO, Func<bool> IBMKCLDDNND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4720E90", Offset = "0x471FE90", VA = "0x184720E90")]
	public static ELHLMKINOCP EJCFBAEGMGD(this MonoBehaviour MADHPHKBBEN, Func<bool> IBMKCLDDNND, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO = DJIMLFADNNM.NNFKCEBEIKK.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class BGOBINBLHMM
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class GKBHPBCJLIG : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public DJIMLFADNNM.NNFKCEBEIKK queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public GKBHPBCJLIG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4729D90", Offset = "0x4728D90", VA = "0x184729D90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x4729E50", Offset = "0x4728E50", VA = "0x184729E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4722270", Offset = "0x4721270", VA = "0x184722270")]
	[IteratorStateMachine(typeof(GKBHPBCJLIG))]
	private static IEnumerator<HGLMJIKIMPH> OFMIGEIJLIH(float LMBPHJCDHKC, DJIMLFADNNM.NNFKCEBEIKK EFDLAJEDOPC, Action CHPMNENLADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4722090", Offset = "0x4721090", VA = "0x184722090")]
	public static ELHLMKINOCP JBNHKJIGHJH(this MonoBehaviour MADHPHKBBEN, float LMBPHJCDHKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4721EC0", Offset = "0x4720EC0", VA = "0x184721EC0")]
	public static ELHLMKINOCP DJOHANIBBGM(this MonoBehaviour MADHPHKBBEN, Action CHPMNENLADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x47223A0", Offset = "0x47213A0", VA = "0x1847223A0")]
	public static ELHLMKINOCP OOAIEEEMKGA(this MonoBehaviour MADHPHKBBEN, Action CHPMNENLADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4722120", Offset = "0x4721120", VA = "0x184722120")]
	public static ELHLMKINOCP KBKAMPAFIMC(this MonoBehaviour MADHPHKBBEN, Action CHPMNENLADO, [Optional] HDOKLIGPDIG JNMHFJMLAFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4722300", Offset = "0x4721300", VA = "0x184722300")]
	public static ELHLMKINOCP ONMEHGACDEI(this MonoBehaviour MADHPHKBBEN, Action CHPMNENLADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4721E20", Offset = "0x4720E20", VA = "0x184721E20")]
	public static ELHLMKINOCP CKMICHOKNDG(this MonoBehaviour MADHPHKBBEN, Action CHPMNENLADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4721F60", Offset = "0x4720F60", VA = "0x184721F60")]
	private static ELHLMKINOCP FJFLGDJCHGM(MonoBehaviour MADHPHKBBEN, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO, Action CHPMNENLADO, [Optional] HDOKLIGPDIG JNMHFJMLAFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4722000", Offset = "0x4721000", VA = "0x184722000")]
	public static ELHLMKINOCP JADLGKNGGIH(this MonoBehaviour MADHPHKBBEN, float BDHBGMGEKME, Action CHPMNENLADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4722150", Offset = "0x4721150", VA = "0x184722150")]
	public static ELHLMKINOCP KMPAGPABIBL(this MonoBehaviour MADHPHKBBEN, float BDHBGMGEKME, Action CHPMNENLADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x47221E0", Offset = "0x47211E0", VA = "0x1847221E0")]
	public static ELHLMKINOCP NFKHHDFPKOL(this MonoBehaviour MADHPHKBBEN, float BDHBGMGEKME, Action CHPMNENLADO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4721D90", Offset = "0x4720D90", VA = "0x184721D90")]
	public static ELHLMKINOCP ALDJBGMPOPL(this MonoBehaviour MADHPHKBBEN, float BDHBGMGEKME, Action CHPMNENLADO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class KLFBPBBLKEC : CJBBNDNKBIC
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class DFOLAMMDDIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public KLFBPBBLKEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public DFOLAMMDDIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4726750", Offset = "0x4725750", VA = "0x184726750")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class LCBIGDFNKJI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public KLFBPBBLKEC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public LCBIGDFNKJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x4726750", Offset = "0x4725750", VA = "0x184726750")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly float HFFPJGNGGED;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4723F50", Offset = "0x4722F50", VA = "0x184723F50")]
	public KLFBPBBLKEC(Behaviour NPAGOMGBIJA, float HFFPJGNGGED, [Optional] Action KIPHNMLPBLO, [Optional] HDOKLIGPDIG JNMHFJMLAFF, [Optional] PHFCPBFIOHJ PLLBODOMIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x472FAB0", Offset = "0x472EAB0", VA = "0x18472FAB0", Slot = "9")]
	protected override bool KHEAGCDDOLG(Action HCHPGKLEJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x472FB90", Offset = "0x472EB90", VA = "0x18472FB90", Slot = "10")]
	protected override bool KKKILDNODEO(Action HCHPGKLEJDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IDBHPIBFPEL
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool IJHELABMILI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action PNLLBCFDLMF;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ODMLDAIMEEA(bool FHPGFPLPMCG = false);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ODMLDAIMEEA(Action HCHPGKLEJDC, bool FHPGFPLPMCG = false);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class CJBBNDNKBIC : IDBHPIBFPEL
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private sealed class MJIPNDBGPIF : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public CJBBNDNKBIC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public MJIPNDBGPIF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x4732DE0", Offset = "0x4731DE0", VA = "0x184732DE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4732EB0", Offset = "0x4731EB0", VA = "0x184732EB0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly Behaviour NPAGOMGBIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly Action KIPHNMLPBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private HJIBPKGDMBM BHHEJIJGLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly HDOKLIGPDIG JNMHFJMLAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	protected readonly PHFCPBFIOHJ PLLBODOMIMI;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool IJHELABMILI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x759DF0", Offset = "0x758DF0", VA = "0x180759DF0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action PNLLBCFDLMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x47239A0", Offset = "0x47229A0", VA = "0x1847239A0", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4723850", Offset = "0x4722850", VA = "0x184723850", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4723D40", Offset = "0x4722D40", VA = "0x184723D40")]
	protected CJBBNDNKBIC(Behaviour NPAGOMGBIJA, [Optional] Action KIPHNMLPBLO, [Optional] HDOKLIGPDIG JNMHFJMLAFF, [Optional] PHFCPBFIOHJ PLLBODOMIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4723C90", Offset = "0x4722C90", VA = "0x184723C90", Slot = "7")]
	public bool ODMLDAIMEEA(bool FHPGFPLPMCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4723CF0", Offset = "0x4722CF0", VA = "0x184723CF0", Slot = "8")]
	public bool ODMLDAIMEEA(Action HCHPGKLEJDC, bool FHPGFPLPMCG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool KHEAGCDDOLG(Action HCHPGKLEJDC);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool KKKILDNODEO(Action HCHPGKLEJDC);

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x4723830", Offset = "0x4722830", VA = "0x184723830")]
	protected void FBMJLBECMGF(Action HCHPGKLEJDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4723AC0", Offset = "0x4722AC0", VA = "0x184723AC0")]
	protected GNLNKOKJLFP NKNKLCMAFAC(float JAHEPLOODHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x47238F0", Offset = "0x47228F0", VA = "0x1847238F0")]
	private void KDJPPKKJHNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4723A40", Offset = "0x4722A40", VA = "0x184723A40")]
	[IteratorStateMachine(typeof(MJIPNDBGPIF))]
	private IEnumerator<HGLMJIKIMPH> MHCIAHODLFN(float JAHEPLOODHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4723960", Offset = "0x4722960", VA = "0x184723960")]
	[CompilerGenerated]
	private void KNGJMBINCFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class GEFJLAHMDGA : CJBBNDNKBIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly float BOPPBLKLAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly int NMCIJGPAKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly float CBDGCDDHHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly float[] CGDLBOBFMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private int KOAOCJJJKMG;

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x4729AB0", Offset = "0x4728AB0", VA = "0x184729AB0")]
	public GEFJLAHMDGA(Behaviour NPAGOMGBIJA, float IBNFEHDKJCP, int NMCIJGPAKNA, [Optional] Action KIPHNMLPBLO, float CBDGCDDHHMB = 0f, [Optional] HDOKLIGPDIG JNMHFJMLAFF, [Optional] PHFCPBFIOHJ PLLBODOMIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x58DEC0", Offset = "0x58CEC0", VA = "0x18058DEC0", Slot = "9")]
	protected override bool KHEAGCDDOLG(Action HCHPGKLEJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x4729890", Offset = "0x4728890", VA = "0x184729890", Slot = "10")]
	protected override bool KKKILDNODEO(Action HCHPGKLEJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x4729800", Offset = "0x4728800", VA = "0x184729800")]
	private void ADLFHBJJNBB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class CMPOHNJNLNM : CJBBNDNKBIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly float HFFPJGNGGED;

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x4723F50", Offset = "0x4722F50", VA = "0x184723F50")]
	public CMPOHNJNLNM(Behaviour NPAGOMGBIJA, float HFFPJGNGGED, [Optional] Action KIPHNMLPBLO, [Optional] HDOKLIGPDIG JNMHFJMLAFF, [Optional] PHFCPBFIOHJ PLLBODOMIMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x58DEC0", Offset = "0x58CEC0", VA = "0x18058DEC0", Slot = "9")]
	protected override bool KHEAGCDDOLG(Action HCHPGKLEJDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x4723F10", Offset = "0x4722F10", VA = "0x184723F10", Slot = "10")]
	protected override bool KKKILDNODEO(Action HCHPGKLEJDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public sealed class BLOBKMKBLJB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private sealed class BDKGEEGBIGP : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public BDKGEEGBIGP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4721CA0", Offset = "0x4720CA0", VA = "0x184721CA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4721D40", Offset = "0x4720D40", VA = "0x184721D40", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private ELHLMKINOCP CCGLOFNLFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private AGFHDCKDPDI NPAGOMGBIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private Action<float> ODFFNGEKAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private float OOAAEFBKBDA;

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x4722DC0", Offset = "0x4721DC0", VA = "0x184722DC0")]
	public BLOBKMKBLJB(AGFHDCKDPDI NPAGOMGBIJA, float JDBFBFAEGJB, Action<float> PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x4722B60", Offset = "0x4721B60", VA = "0x184722B60")]
	private void GCAFIBFHDLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4722CB0", Offset = "0x4721CB0", VA = "0x184722CB0")]
	private void PCADGAMMPII(string BCELONFJGJN, Action IJNLMJJCLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x4722940", Offset = "0x4721940", VA = "0x184722940")]
	[IteratorStateMachine(typeof(BDKGEEGBIGP))]
	private IEnumerator<HGLMJIKIMPH> BJBCKPMLCPA(Action IJNLMJJCLEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x4722B00", Offset = "0x4721B00", VA = "0x184722B00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x47229B0", Offset = "0x47219B0", VA = "0x1847229B0")]
	[CompilerGenerated]
	private void BOMOBBBFJFI(string MMICFFPKPAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class EPOPGKPCDBP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BPJEDKIPLKA : IEnumerator<HGLMJIKIMPH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private HGLMJIKIMPH <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private HGLMJIKIMPH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D0", Offset = "0x69D7D0", VA = "0x18069E7D0")]
		[DebuggerHidden]
		public BPJEDKIPLKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4722FE0", Offset = "0x4721FE0", VA = "0x184722FE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4723080", Offset = "0x4722080", VA = "0x184723080", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private ELHLMKINOCP CCGLOFNLFGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private MonoBehaviour MADHPHKBBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Action PKJACDPGIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Action<float> ODFFNGEKAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private float OOAAEFBKBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private bool BDHJAADJCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly HDOKLIGPDIG JNMHFJMLAFF;

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x4728B80", Offset = "0x4727B80", VA = "0x184728B80")]
	public EPOPGKPCDBP(MonoBehaviour MADHPHKBBEN, Action PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO, [Optional] HDOKLIGPDIG JNMHFJMLAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x4728800", Offset = "0x4727800", VA = "0x184728800")]
	public EPOPGKPCDBP(MonoBehaviour MADHPHKBBEN, Action<float> PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO, [Optional] HDOKLIGPDIG JNMHFJMLAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x47289B0", Offset = "0x47279B0", VA = "0x1847289B0")]
	public EPOPGKPCDBP(MonoBehaviour MADHPHKBBEN, float JDBFBFAEGJB, Action<float> PKJACDPGIHH, DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO, bool BDHJAADJCMC = true, [Optional] HDOKLIGPDIG JNMHFJMLAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x47285D0", Offset = "0x47275D0", VA = "0x1847285D0")]
	private void NGDHHKBACBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x4728140", Offset = "0x4727140", VA = "0x184728140")]
	private void CKHAONCBEKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x47282F0", Offset = "0x47272F0", VA = "0x1847282F0")]
	private void GCAFIBFHDLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x47286F0", Offset = "0x47276F0", VA = "0x1847286F0")]
	private void PCADGAMMPII(string BCELONFJGJN, Action IJNLMJJCLEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x47280D0", Offset = "0x47270D0", VA = "0x1847280D0")]
	[IteratorStateMachine(typeof(BPJEDKIPLKA))]
	private IEnumerator<HGLMJIKIMPH> BJBCKPMLCPA(Action IJNLMJJCLEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4728290", Offset = "0x4727290", VA = "0x184728290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x4728450", Offset = "0x4727450", VA = "0x184728450")]
	[CompilerGenerated]
	private void HEGOCCPJDBG(string MMICFFPKPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x47284D0", Offset = "0x47274D0", VA = "0x1847284D0")]
	[CompilerGenerated]
	private void JNFBPBFCDPK(string MMICFFPKPAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x4728550", Offset = "0x4727550", VA = "0x184728550")]
	[CompilerGenerated]
	private void KKFJFMNPNDL(string MMICFFPKPAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[Flags]
internal enum AFNPHEEPEOO : byte
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Inactive = 0,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Running = 1,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	Cancelled = 2,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	Paused = 4
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal sealed class OBHOILICBDJ : PHFCPBFIOHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public float PALNMDANGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4733270", Offset = "0x4732270", VA = "0x184733270", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float DNMHGDOPIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4733280", Offset = "0x4732280", VA = "0x184733280", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public double DLCLKNAIKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4733290", Offset = "0x4732290", VA = "0x184733290", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x47332B0", Offset = "0x47322B0", VA = "0x1847332B0")]
	[LPDKEEGEILI]
	private static void HILKDBELOLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	[Preserve]
	internal OBHOILICBDJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal interface LLLFAODFFNC
{
	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BLJONJKJJDK(string IPJBPCNNBIO);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INHHOJJAPHI();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
internal interface IMFOHEEFPHJ
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	string ADLJMBIPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool CIEELFOLIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool ANDDNOCFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal class IEEIPFFJKAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public LLPOFLBIGHO MCFLHLJCGIM;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int LDLBNOKJCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x58DED0", Offset = "0x58CED0", VA = "0x18058DED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x58DEE0", Offset = "0x58CEE0", VA = "0x18058DEE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x472BB90", Offset = "0x472AB90", VA = "0x18472BB90")]
	public static HGLMJIKIMPH PNJBELMNALH(IEnumerator<HGLMJIKIMPH> GMCJGBKABEH, NFCBKFPHLJD FPFKOMFNPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x472BCF0", Offset = "0x472ACF0", VA = "0x18472BCF0")]
	public HGLMJIKIMPH PNJBELMNALH(NFCBKFPHLJD[] LEJGHPBLJII, IEnumerator<HGLMJIKIMPH>[] PPBIGLNDNMI, HGLMJIKIMPH[] KOIPKOGHNLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x472B9C0", Offset = "0x472A9C0", VA = "0x18472B9C0")]
	public void EPPJJLMPILP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x472B9F0", Offset = "0x472A9F0", VA = "0x18472B9F0")]
	public void JEMIMKNEPID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x472BAC0", Offset = "0x472AAC0", VA = "0x18472BAC0")]
	public void MKIDFNHOHJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x472B9C0", Offset = "0x472A9C0", VA = "0x18472B9C0")]
	public void ACMHOECMAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public IEEIPFFJKAH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
internal sealed class LLPOFLBIGHO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct IOEOINMMADG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public IEEIPFFJKAH EGJFBFIFEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public AGFHDCKDPDI LBGHBHKFMBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public NFCBKFPHLJD NIIHLAHDPDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public IEnumerator<HGLMJIKIMPH> HBFKMDGIBKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public HGLMJIKIMPH JOAODMJJIPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public AFNPHEEPEOO ABCNMECHLBD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public struct KEBLDCBMHMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public DJIMLFADNNM.NNFKCEBEIKK BLKBLKOGFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public List<IOEOINMMADG> JFMMFOFJBJI;
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class HFLPEFMAKGO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public LLPOFLBIGHO <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public AGFHDCKDPDI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public IEEIPFFJKAH routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public AFNPHEEPEOO coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public NFCBKFPHLJD promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public HGLMJIKIMPH currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public IEnumerator<HGLMJIKIMPH> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public HFLPEFMAKGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x472AAA0", Offset = "0x4729AA0", VA = "0x18472AAA0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[CompilerGenerated]
	private sealed class BOPIMHFIPAM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public IEEIPFFJKAH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public LLPOFLBIGHO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public BOPIMHFIPAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4722FA0", Offset = "0x4721FA0", VA = "0x184722FA0")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[CompilerGenerated]
	private sealed class EDCBOEINLNJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public IEEIPFFJKAH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public LLPOFLBIGHO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public EDCBOEINLNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4727DA0", Offset = "0x4726DA0", VA = "0x184727DA0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class BPLDCEMCGAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public IEEIPFFJKAH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public LLPOFLBIGHO <>4__this;

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
		public BPLDCEMCGAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x47230D0", Offset = "0x47220D0", VA = "0x1847230D0")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private const AFNPHEEPEOO MHGKKFNGPDB = AFNPHEEPEOO.Cancelled | AFNPHEEPEOO.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool[] GHGKPJJLMOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private NativeArray<AFNPHEEPEOO> GLNADGDJFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private NativeArray<float> OLNLAKOLCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private NativeArray<int> PFMCDMGLJHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private NativeArray<int> KDDKCIHGFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private NativeArray<int> CPIIBCHAPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NativeArray<int> CHKGIBEJMIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private NativeArray<int> EDHAFHEJPCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private IEEIPFFJKAH[] LCJAMJPMPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private NFCBKFPHLJD[] LEJGHPBLJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private AGFHDCKDPDI[] FODBDLNMLCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private IEnumerator<HGLMJIKIMPH>[] MCNJGANEMHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private HGLMJIKIMPH[] PPNFJOKCFEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private int JNAEIIFGDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int PGIGOJJPHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly int OCMMJPKGCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private float AEJNDIFCFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private AJOGCNOGLGB PABLLJNHLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private JobHandle PLHOIANGOMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private List<IEEIPFFJKAH> MPGJKONPHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool DIGOJGCLNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private List<Action> FKHEKOPDLLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private List<Action> ADPPFOHLMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool ACGHMPMBCHH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public KEBLDCBMHMM[] PHACOCODHOD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0xE97980", Offset = "0xE96980", VA = "0x180E97980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4731EE0", Offset = "0x4730EE0", VA = "0x184731EE0")]
	private static int NCGPMNKCNOP(DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x47327C0", Offset = "0x47317C0", VA = "0x1847327C0")]
	public LLPOFLBIGHO(DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4730C50", Offset = "0x472FC50", VA = "0x184730C50")]
	private void EFDNKAHJONF(ref int EGHNEKBGHAG, int EPMPKJHEBIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x47317D0", Offset = "0x47307D0", VA = "0x1847317D0")]
	public void IDBOCOBOLNK(AGFHDCKDPDI NPAGOMGBIJA, HGLMJIKIMPH AAGJACEFOJG, IEnumerator<HGLMJIKIMPH> GMCJGBKABEH, NFCBKFPHLJD FPFKOMFNPJC, [Optional] IEEIPFFJKAH AJMNMEFDCJM, AFNPHEEPEOO AKAOILOMOEB = AFNPHEEPEOO.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4731340", Offset = "0x4730340", VA = "0x184731340")]
	public void GFECPOHOPOO(IEnumerable<IOEOINMMADG> BMCHIKCBOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4731F10", Offset = "0x4730F10", VA = "0x184731F10")]
	private IOEOINMMADG NILMNOLFIIA(int IOFHFBENJHP)
	{
		return default(IOEOINMMADG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4732450", Offset = "0x4731450", VA = "0x184732450")]
	private void ODOKAIBJLNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2C63590", Offset = "0x2C62590", VA = "0x182C63590")]
	private static void BHCGDPOJLLO<T>(int IOFHFBENJHP, T[] DMPNBNDGBHP, int GGOGIDMAHAL, [Optional] T JGOOBCIMMPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2C63570", Offset = "0x2C62570", VA = "0x182C63570")]
	private static void BHCGDPOJLLO<T>(int IOFHFBENJHP, NativeArray<T> DMPNBNDGBHP, int GGOGIDMAHAL, [Optional] T JGOOBCIMMPM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x4731530", Offset = "0x4730530", VA = "0x184731530")]
	private void HJEFFOIAPAI(IEnumerable<IOEOINMMADG> BMCHIKCBOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4731280", Offset = "0x4730280", VA = "0x184731280")]
	private void FMMOJBBIALO(IOEOINMMADG IJOFFNIHNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4731BA0", Offset = "0x4730BA0", VA = "0x184731BA0")]
	private CDNPFBPGOIO KPLJPMHFPKB(int JIIKLLFNFJE)
	{
		return default(CDNPFBPGOIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x47319B0", Offset = "0x47309B0", VA = "0x1847319B0")]
	public void KNMKAGONOHP(float KHCFNKECNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4731E60", Offset = "0x4730E60", VA = "0x184731E60")]
	private void MMOCMOEBPEN(Action INIPPOEHOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x4731930", Offset = "0x4730930", VA = "0x184731930")]
	private void JFJAHEIPBFH(Action INIPPOEHOLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x4730DE0", Offset = "0x472FDE0", VA = "0x184730DE0")]
	public void ELBGHFMOBKK(float KHCFNKECNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x4730AB0", Offset = "0x472FAB0", VA = "0x184730AB0")]
	public void ALEEKPJPLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x47309F0", Offset = "0x472F9F0", VA = "0x1847309F0")]
	public void ACMHOECMAKL(IEEIPFFJKAH MKLDCLBFBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x4730B90", Offset = "0x472FB90", VA = "0x184730B90")]
	public void DCEAMMEMNDC(IEEIPFFJKAH MKLDCLBFBPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x4732390", Offset = "0x4731390", VA = "0x184732390")]
	public void NLFAEOPBGOG(IEEIPFFJKAH MKLDCLBFBPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class JFIJOEMNBAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public static readonly JFIJOEMNBAJ NJGNJIEBDOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly Action IJKKFBJJLKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private bool CKJDBNBCJDN;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6C2360", Offset = "0x6C1360", VA = "0x1806C2360")]
	public JFIJOEMNBAJ(Action IJKKFBJJLKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x472D810", Offset = "0x472C810", VA = "0x18472D810", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JGJELJAMDCH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	T PDFBALCEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable GHEFFKLEJPH(UnityEngine.Object NPAGOMGBIJA, Action<T> HCLNDPFJDEJ);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface JDBHEBLHKIO<T> : global::JGJELJAMDCH<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	new T PDFBALCEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class FHDDOCPIBBG<T> : global::JDBHEBLHKIO<T>, global::JGJELJAMDCH<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JCNFOKOBMEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public global::FHDDOCPIBBG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public global::IGNDLNHHCFB<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x1D166C0", Offset = "0x1D156C0", VA = "0x181D166C0")]
		public JCNFOKOBMEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x2313430", Offset = "0x2312430", VA = "0x182313430")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private static GameObject ONHJCBFLDKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly List<global::IGNDLNHHCFB<UnityEngine.Object, Action<T>>> BMJJPKDDEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private T KHBNPJDBOKN;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T PDFBALCEGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x6BBC80", Offset = "0x6BAC80", VA = "0x1806BBC80", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x2310C70", Offset = "0x230FC70", VA = "0x182310C70", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x23115D0", Offset = "0x23105D0", VA = "0x1823115D0")]
	private static bool KOBDAGDGEFH(T INIPPOEHOLP, T BMEGDOGJIKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x2311700", Offset = "0x2310700", VA = "0x182311700")]
	public FHDDOCPIBBG(T ACLFMGDLFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2311310", Offset = "0x2310310", VA = "0x182311310", Slot = "6")]
	public IDisposable GHEFFKLEJPH(UnityEngine.Object NPAGOMGBIJA, Action<T> HCLNDPFJDEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x2310CD0", Offset = "0x230FCD0", VA = "0x182310CD0")]
	private void CAHKOLDGMMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal class CFCKAFDIDFP : GBJAHHELJIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private readonly HDOKLIGPDIG JNMHFJMLAFF;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4723760", Offset = "0x4722760", VA = "0x184723760")]
	[LPDKEEGEILI]
	private static void HILKDBELOLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2360", Offset = "0x6C1360", VA = "0x1806C2360")]
	[Preserve]
	internal CFCKAFDIDFP([ANHJONHGEFO(null)] HDOKLIGPDIG JNMHFJMLAFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x47236C0", Offset = "0x47226C0", VA = "0x1847236C0", Slot = "4")]
	public IDisposable GJPGGDHAEME(float JDBFBFAEGJB, Action<float> ONMGDGLPLME, bool BDHJAADJCMC = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[BurstCompile]
internal struct AJOGCNOGLGB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	[ReadOnly]
	public float BFNCGNHAKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	[ReadOnly]
	public int AAPEOFPFKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private NativeArray<int> AJACOEFCNOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NativeArray<int> PDNEOAADJNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private NativeArray<int> OOOELIAGOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	[ReadOnly]
	public NativeArray<AFNPHEEPEOO> AOEFKPJJPOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	[ReadOnly]
	public NativeArray<float> JNMNIEEAIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	[WriteOnly]
	public NativeArray<int> CPIIBCHAPFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	[WriteOnly]
	public NativeArray<int> PFMCDMGLJHM;

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4721480", Offset = "0x4720480", VA = "0x184721480")]
	public static AJOGCNOGLGB NPKHJENBLIG(int LHOJJACJDPC, float KHCFNKECNAD, NativeArray<AFNPHEEPEOO> DCLGCNCDABA, NativeArray<float> MLNECBJGGIM, NativeArray<int> CBHCFHCFNDO, NativeArray<int> BAEMLGFDMIA, NativeArray<int> OLGNDKJKJBN, NativeArray<int> PDNEOAADJNP, NativeArray<int> OOOELIAGOIC)
	{
		return default(AJOGCNOGLGB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4721260", Offset = "0x4720260", VA = "0x184721260", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x4721220", Offset = "0x4720220", VA = "0x184721220")]
	private bool BHHKEKOPDBF(int GPNCGBOOKKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x4721550", Offset = "0x4720550", VA = "0x184721550")]
	private void PMJOINHKHEP(NativeArray<int> MIIHPJCJNIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x4721340", Offset = "0x4720340", VA = "0x184721340")]
	private int KEJMKJLOMBP(int PONIBFGELNP, int CKPEEFNNAGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x47213B0", Offset = "0x47203B0", VA = "0x1847213B0")]
	private void MHDHJJCODPO(NativeArray<int> MIIHPJCJNIL, int ONODPIHIGLF, int OHDPFMIHLCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4720FF0", Offset = "0x471FFF0", VA = "0x184720FF0")]
	private void ANPLBDGDNMA(NativeArray<int> MIIHPJCJNIL, int KCFGHPJKFBI, int GFIBPGDPIOF, int PAAFIDBJNEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class JIPPLBBGNJH : KCMIKABOAOP, HDOKLIGPDIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private LLPOFLBIGHO[] HOLOGGGJJKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private LLLFAODFFNC AGPDKOLMLJF;

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x472DD50", Offset = "0x472CD50", VA = "0x18472DD50")]
	[LPDKEEGEILI]
	private static void HILKDBELOLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x472E370", Offset = "0x472D370", VA = "0x18472E370")]
	[Preserve]
	public JIPPLBBGNJH([ANHJONHGEFO(null)] PGGKCAJIBHL FFODKFEANGN, [ANHJONHGEFO(null)] PHFCPBFIOHJ PLLBODOMIMI, [ANHJONHGEFO(null)] BDNEKFCKFLB MIMKNFCHIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x472DE20", Offset = "0x472CE20", VA = "0x18472DE20", Slot = "12")]
	public override ELHLMKINOCP LFEMKFFJCHI(AGFHDCKDPDI NPAGOMGBIJA, IEnumerator<HGLMJIKIMPH> NEJNLNLPGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x472E000", Offset = "0x472D000", VA = "0x18472E000", Slot = "13")]
	public override void MIGBKHAMFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x472D980", Offset = "0x472C980", VA = "0x18472D980", Slot = "15")]
	public override void EOOOJDAFFHB(DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x472DC70", Offset = "0x472CC70", VA = "0x18472DC70", Slot = "14")]
	protected override void HFCDGCMEJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x472DF50", Offset = "0x472CF50", VA = "0x18472DF50")]
	private LLPOFLBIGHO LPPFFJKDFLI(DJIMLFADNNM.NNFKCEBEIKK JFEPPDBLNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x472E2C0", Offset = "0x472D2C0", VA = "0x18472E2C0", Slot = "16")]
	internal override FPMHHJHKBGG OJMDCFCHBAO(IEnumerator<HGLMJIKIMPH> NEJNLNLPGHI, Behaviour NPAGOMGBIJA, NFCBKFPHLJD FPFKOMFNPJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x472DF90", Offset = "0x472CF90", VA = "0x18472DF90", Slot = "17")]
	internal override JDFAHLBGBCF MGOJPGHCCNO(DJIMLFADNNM.NNFKCEBEIKK EFDLAJEDOPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x472DB50", Offset = "0x472CB50", VA = "0x18472DB50")]
	private void GOGJNIFLFON(LLPOFLBIGHO BCBBAOLHCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x472D910", Offset = "0x472C910", VA = "0x18472D910", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class KCMIKABOAOP : HDOKLIGPDIG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly PGGKCAJIBHL FFODKFEANGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	protected readonly PHFCPBFIOHJ PLLBODOMIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly BDNEKFCKFLB MIMKNFCHIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private JDFAHLBGBCF[] EEPPECMJLDP;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static HDOKLIGPDIG AOMOPIPEMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x472F570", Offset = "0x472E570", VA = "0x18472F570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool LGGFCEFDDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x58DFE0", Offset = "0x58CFE0", VA = "0x18058DFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public DJIMLFADNNM.NNFKCEBEIKK JCALFCFLDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x58DED0", Offset = "0x58CED0", VA = "0x18058DED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(DJIMLFADNNM.NNFKCEBEIKK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x58DEE0", Offset = "0x58CEE0", VA = "0x18058DEE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PHFCPBFIOHJ IIOMGJGNBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x58FDF0", Offset = "0x58EDF0", VA = "0x18058FDF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x472F0D0", Offset = "0x472E0D0", VA = "0x18472F0D0")]
	public static ELHLMKINOCP HHEHBFNBFLN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x472F630", Offset = "0x472E630", VA = "0x18472F630")]
	[Preserve]
	protected KCMIKABOAOP([ANHJONHGEFO(null)] PGGKCAJIBHL FFODKFEANGN, [ANHJONHGEFO(null)] PHFCPBFIOHJ PLLBODOMIMI, [ANHJONHGEFO(null)] BDNEKFCKFLB MIMKNFCHIOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x472E970", Offset = "0x472D970", VA = "0x18472E970", Slot = "6")]
	public ELHLMKINOCP DLDMICFJCKI(IEnumerator<HGLMJIKIMPH> NEJNLNLPGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x472E980", Offset = "0x472D980", VA = "0x18472E980", Slot = "7")]
	public ELHLMKINOCP DLDMICFJCKI(Behaviour NPAGOMGBIJA, IEnumerator<HGLMJIKIMPH> NEJNLNLPGHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract ELHLMKINOCP LFEMKFFJCHI(AGFHDCKDPDI NPAGOMGBIJA, IEnumerator<HGLMJIKIMPH> NEJNLNLPGHI);

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x472F390", Offset = "0x472E390", VA = "0x18472F390", Slot = "13")]
	public virtual void MIGBKHAMFOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x472F330", Offset = "0x472E330", VA = "0x18472F330", Slot = "9")]
	public void KEBFEOKOJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x472F0B0", Offset = "0x472E0B0", VA = "0x18472F0B0", Slot = "14")]
	protected virtual void HFCDGCMEJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x472E910", Offset = "0x472D910", VA = "0x18472E910")]
	private void BJJBOPCHBAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x472EE20", Offset = "0x472DE20", VA = "0x18472EE20")]
	private void EJBJBNHHKGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x472F090", Offset = "0x472E090", VA = "0x18472F090")]
	private void HACHGPIJOGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x472E930", Offset = "0x472D930", VA = "0x18472E930")]
	private void DDMICJGFALP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x472E950", Offset = "0x472D950", VA = "0x18472E950")]
	private void DGKLPDFPHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x472F070", Offset = "0x472E070", VA = "0x18472F070")]
	private void FKPECDIIENL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x472EE40", Offset = "0x472DE40", VA = "0x18472EE40", Slot = "15")]
	public virtual void EOOOJDAFFHB(DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x472F170", Offset = "0x472E170", VA = "0x18472F170")]
	private void HNGKKMMAMMP(JDFAHLBGBCF BCBBAOLHCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8E00", VA = "0x1807D9E00")]
	private JDFAHLBGBCF COGMPEPOIAH(DJIMLFADNNM.NNFKCEBEIKK JFEPPDBLNIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract FPMHHJHKBGG OJMDCFCHBAO(IEnumerator<HGLMJIKIMPH> NEJNLNLPGHI, Behaviour MADHPHKBBEN, NFCBKFPHLJD NNPNBCEEPBH);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract JDFAHLBGBCF MGOJPGHCCNO(DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x472EBA0", Offset = "0x472DBA0", VA = "0x18472EBA0", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
internal sealed class FPMHHJHKBGG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly NFCBKFPHLJD FPFKOMFNPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly IMFOHEEFPHJ NPAGOMGBIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly bool MFANKMDHPFA;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerator<HGLMJIKIMPH> HBFKMDGIBKF
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x58D1D0", Offset = "0x58C1D0", VA = "0x18058D1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x58D490", Offset = "0x58C490", VA = "0x18058D490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public HGLMJIKIMPH JOAODMJJIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x58D1C0", Offset = "0x58C1C0", VA = "0x18058D1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x58D4A0", Offset = "0x58C4A0", VA = "0x18058D4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool LFALHNGCLFI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x4729290", Offset = "0x4728290", VA = "0x184729290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool COMPOMNDFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x843AD0", Offset = "0x842AD0", VA = "0x180843AD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x25AB850", Offset = "0x25AA850", VA = "0x1825AB850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string ADLJMBIPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x58E010", Offset = "0x58D010", VA = "0x18058E010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x58E020", Offset = "0x58D020", VA = "0x18058E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float MHDJEHMLBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x10D4F30", Offset = "0x10D3F30", VA = "0x1810D4F30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x13D50A0", Offset = "0x13D40A0", VA = "0x1813D50A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4729610", Offset = "0x4728610", VA = "0x184729610")]
	public FPMHHJHKBGG(IEnumerator<HGLMJIKIMPH> GMCJGBKABEH, IMFOHEEFPHJ NPAGOMGBIJA, NFCBKFPHLJD FPFKOMFNPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4729310", Offset = "0x4728310", VA = "0x184729310")]
	public HGLMJIKIMPH PNJBELMNALH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4729220", Offset = "0x4728220", VA = "0x184729220")]
	public bool ALEDAMDAHGK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4729190", Offset = "0x4728190", VA = "0x184729190")]
	public void ACMHOECMAKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4729580", Offset = "0x4728580", VA = "0x184729580", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x18F1DE0", Offset = "0x18F0DE0", VA = "0x1818F1DE0")]
	[CompilerGenerated]
	private void NFJLJBKILGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
internal sealed class NFCBKFPHLJD : BKNEEBKMCON, ELHLMKINOCP, HJIBPKGDMBM, GNLNKOKJLFP, IEnumerator, HGLMJIKIMPH, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private DJIMLFADNNM.NNFKCEBEIKK LBBMAJPDKGB;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private DJIMLFADNNM.NNFKCEBEIKK EIKLBJAAPLP
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x5B2180", Offset = "0x5B1180", VA = "0x1805B2180", Slot = "23")]
		get
		{
			return default(DJIMLFADNNM.NNFKCEBEIKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public DJIMLFADNNM.NNFKCEBEIKK MCFLHLJCGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x77D5C0", Offset = "0x77C5C0", VA = "0x18077D5C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private float PJKPKMBJMAK
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xF18840", Offset = "0xF17840", VA = "0x180F18840", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4732F10", Offset = "0x4731F10", VA = "0x184732F10", Slot = "24")]
	private bool JCIEIFILJBO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4732F00", Offset = "0x4731F00", VA = "0x184732F00", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4732F30", Offset = "0x4731F30", VA = "0x184732F30")]
	public NFCBKFPHLJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal enum CDNPFBPGOIO : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Remove,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Reinsert,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	NextUpdateChanged
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal sealed class JDFAHLBGBCF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public enum FIFDBDCMOIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct IBGJGDIAPOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public DJIMLFADNNM.NNFKCEBEIKK BLKBLKOGFLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public FIFDBDCMOIF ABBBLIMMMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public List<FPMHHJHKBGG> LDMFGOAGDHB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly FIFDBDCMOIF[] HMOALBGKCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private readonly DJIMLFADNNM.NNFKCEBEIKK IKMPFNGMCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private bool OBFILBHLGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly FPMHHJHKBGG[] MAGCPMNGNBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly List<FPMHHJHKBGG> DIBMHMJKJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private readonly Stack<int> LGFGLIIMJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly List<FPMHHJHKBGG> BHNCJLGDJIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private readonly Stack<int> IFLMFACLAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly LLLFAODFFNC NILBHLIDFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private bool ACGHMPMBCHH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public IBGJGDIAPOF[,] BILFLMLIIIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E0130", Offset = "0x5DF130", VA = "0x1805E0130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x472D3A0", Offset = "0x472C3A0", VA = "0x18472D3A0")]
	public JDFAHLBGBCF(DJIMLFADNNM.NNFKCEBEIKK EFDLAJEDOPC, LLLFAODFFNC NILBHLIDFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x472C610", Offset = "0x472B610", VA = "0x18472C610")]
	public void FJEOIFJNEGD(FPMHHJHKBGG GMCJGBKABEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x472C250", Offset = "0x472B250", VA = "0x18472C250")]
	public void DONHKOAANFJ(IList<FPMHHJHKBGG> PPBIGLNDNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x472C730", Offset = "0x472B730", VA = "0x18472C730")]
	public void HBLBJLLDKJH(IList<FPMHHJHKBGG> PPBIGLNDNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x472CB00", Offset = "0x472BB00", VA = "0x18472CB00")]
	private void HLFNLGMABID(FPMHHJHKBGG GMCJGBKABEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x472CDD0", Offset = "0x472BDD0", VA = "0x18472CDD0")]
	private void JLIHBDFPEBO(IList<FPMHHJHKBGG> PPBIGLNDNMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x472D140", Offset = "0x472C140", VA = "0x18472D140")]
	private CDNPFBPGOIO LJBAAFDAMIB(FPMHHJHKBGG GMCJGBKABEH)
	{
		return default(CDNPFBPGOIO);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x472C9B0", Offset = "0x472B9B0", VA = "0x18472C9B0")]
	public void HFCDGCMEJPN(float KHCFNKECNAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x472CF40", Offset = "0x472BF40", VA = "0x18472CF40")]
	public void KEBFEOKOJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x472CBF0", Offset = "0x472BBF0", VA = "0x18472CBF0")]
	private void HMINFJBEHKB(List<FPMHHJHKBGG> PPBIGLNDNMI, Stack<int> AOMEMKAOBAN, bool ICNHDJGJKKG, float LOFGGCNKJLI = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x472C4D0", Offset = "0x472B4D0", VA = "0x18472C4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x472C130", Offset = "0x472B130", VA = "0x18472C130")]
	private void AGPDEBLLBLG(List<FPMHHJHKBGG> PPBIGLNDNMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
internal class KDICFPNOOBL : LLLFAODFFNC
{
	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "4")]
	public void BLJONJKJJDK(string IPJBPCNNBIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x58DE80", Offset = "0x58CE80", VA = "0x18058DE80", Slot = "5")]
	public void INHHOJJAPHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x58FAB0", Offset = "0x58EAB0", VA = "0x18058FAB0")]
	public KDICFPNOOBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
internal class FODFDNCNBBN : IMFOHEEFPHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly Behaviour MADHPHKBBEN;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string ADLJMBIPGDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4729100", Offset = "0x4728100", VA = "0x184729100", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool CIEELFOLIDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4729080", Offset = "0x4728080", VA = "0x184729080", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool ANDDNOCFENJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x47290E0", Offset = "0x47280E0", VA = "0x1847290E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C2360", Offset = "0x6C1360", VA = "0x1806C2360")]
	public FODFDNCNBBN(Behaviour MADHPHKBBEN)
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
