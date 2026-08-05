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
public class ONHJIBBGPNO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly ThreadPriority DMMICFADLAP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x48A6C70", Offset = "0x48A5270", VA = "0x1848A6C70")]
	public ONHJIBBGPNO(ThreadPriority JFMKAGJCGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x48A6C60", Offset = "0x48A5260", VA = "0x1848A6C60", Slot = "4")]
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
		private delegate List<PlayerLoopSystem> AFDBEINBBPL(List<PlayerLoopSystem> HENADCLOLED, int HCNCJEEPEGC);

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct HAICBPKLENM
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public struct IMKHAMNKEDJ
			{
				[Cpp2IlInjected.Token(Token = "0x4000003")]
				public static DMENMFODFLB CBGLDJLNBCK;

				[Cpp2IlInjected.Token(Token = "0x600000D")]
				[Cpp2IlInjected.Address(RVA = "0x48A1EC0", Offset = "0x48A04C0", VA = "0x1848A1EC0")]
				public static PlayerLoopSystem EFCHBGEPCGB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			public struct MPAAEOJPDGF
			{
				[Cpp2IlInjected.Token(Token = "0x4000006")]
				public static DMENMFODFLB GHPCNJCPJPI;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x48A5B00", Offset = "0x48A4100", VA = "0x1848A5B00")]
				public static PlayerLoopSystem EFCHBGEPCGB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public struct LOLFEIBMFLK
			{
				[Cpp2IlInjected.Token(Token = "0x4000009")]
				public static DMENMFODFLB LEFFLNGMKEG;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0x48A47E0", Offset = "0x48A2DE0", VA = "0x1848A47E0")]
				public static PlayerLoopSystem EFCHBGEPCGB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000C")]
			public struct OAIIFJDNLLJ
			{
				[Cpp2IlInjected.Token(Token = "0x400000C")]
				public static DMENMFODFLB DOOLOCEFJLJ;

				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x48A62E0", Offset = "0x48A48E0", VA = "0x1848A62E0")]
				public static PlayerLoopSystem EFCHBGEPCGB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000E")]
			public struct HDIJLGMOMLH
			{
				[Cpp2IlInjected.Token(Token = "0x400000F")]
				public static DMENMFODFLB FCELFCGBFPD;

				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x48A0610", Offset = "0x489EC10", VA = "0x1848A0610")]
				public static PlayerLoopSystem EFCHBGEPCGB()
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000010")]
			internal struct HKHJECODEIC
			{
				[Cpp2IlInjected.Token(Token = "0x2000011")]
				[CompilerGenerated]
				private sealed class JOLIAELAOOA
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000013")]
					public KAOMHILPOIC.CPJOONJCBLA key;

					[Cpp2IlInjected.Token(Token = "0x6000027")]
					[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
					public JOLIAELAOOA()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x6000028")]
					[Cpp2IlInjected.Address(RVA = "0x48A3980", Offset = "0x48A1F80", VA = "0x1848A3980")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x4000012")]
				public static IDisposable DBAKDEOCPPB;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x48A08E0", Offset = "0x489EEE0", VA = "0x1848A08E0")]
				public static PlayerLoopSystem PBCMAONOLGM(KAOMHILPOIC.CPJOONJCBLA MKDJIBNCKNC)
				{
					return default(PlayerLoopSystem);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000012")]
			internal struct ENBBBFIDONO
			{
				[Cpp2IlInjected.Token(Token = "0x2000013")]
				[CompilerGenerated]
				private sealed class PDNCKFOHNHI
				{
					[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
					[Cpp2IlInjected.Token(Token = "0x4000014")]
					public KAOMHILPOIC.CPJOONJCBLA key;

					[Cpp2IlInjected.Token(Token = "0x600002A")]
					[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
					public PDNCKFOHNHI()
					{
					}

					[Cpp2IlInjected.Token(Token = "0x600002B")]
					[Cpp2IlInjected.Address(RVA = "0x48A7760", Offset = "0x48A5D60", VA = "0x1848A7760")]
					internal void <GetNewSystem>b__0()
					{
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x489E7E0", Offset = "0x489CDE0", VA = "0x18489E7E0")]
				public static PlayerLoopSystem PBCMAONOLGM(KAOMHILPOIC.CPJOONJCBLA MKDJIBNCKNC)
				{
					return default(PlayerLoopSystem);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class MGHFPHMEEEF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public PlayerLoopSystem? after;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public PlayerLoopSystem? before;

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
			public MGHFPHMEEEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x48A55C0", Offset = "0x48A3BC0", VA = "0x1848A55C0")]
			internal List<PlayerLoopSystem> <TryInsertSystems>b__0(List<PlayerLoopSystem> newSubsystemList, int subSystemIndex)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static bool KIMOBIJJJOD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static bool GIHNDEIIMPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x489C0D0", Offset = "0x489A6D0", VA = "0x18489C0D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x489BD10", Offset = "0x489A310", VA = "0x18489BD10")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x489A5D0", Offset = "0x4898BD0", VA = "0x18489A5D0")]
		[RuntimeInitializeOnLoadMethod]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x489BA20", Offset = "0x489A020", VA = "0x18489BA20")]
		private static void DLKDGHBCJJB(KAOMHILPOIC.CPJOONJCBLA MKDJIBNCKNC, ref PlayerLoopSystem OKNCIIMDMFN, Type FLDKHEDDCJG, Type POABGDOMNHN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x489BD50", Offset = "0x489A350", VA = "0x18489BD50")]
		private static void JIBHJIHJOIP(ref PlayerLoopSystem OKNCIIMDMFN, Type FLDKHEDDCJG, Type POABGDOMNHN, AFDBEINBBPL MOHMENALPPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x489BBF0", Offset = "0x489A1F0", VA = "0x18489BBF0")]
		private static void ECBNINMKECA(ref PlayerLoopSystem OKNCIIMDMFN, Type FLDKHEDDCJG, Type POABGDOMNHN, PlayerLoopSystem? PAHKNKHHGLK, PlayerLoopSystem? HIKAHIGLBFP)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public static class KAOMHILPOIC
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public enum CPJOONJCBLA
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
	public class ALGBENENGDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public readonly CPJOONJCBLA KFBBCFONKJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public readonly KLDKFJCICEI KCNKPHEEFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private long LEOAIGPGPAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private long HLPNNHOGLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public long GCIDECDJJKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public int NCNDHDEIGPB;

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4896A10", Offset = "0x4895010", VA = "0x184896A10")]
		public ALGBENENGDO(CPJOONJCBLA LBLJBOKJCCG, int EOADDPLOJHN = 90)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4896770", Offset = "0x4894D70", VA = "0x184896770")]
		public void GEPDBIOGPIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x48969B0", Offset = "0x4894FB0", VA = "0x1848969B0")]
		public void OOLMDEDPCDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x48967E0", Offset = "0x4894DE0", VA = "0x1848967E0")]
		public void MPAPLMLAJFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static CPJOONJCBLA[] KMPLLGKJNBG;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private static ALGBENENGDO[] AGJPPFLDAGM;

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x48A40D0", Offset = "0x48A26D0", VA = "0x1848A40D0")]
	public static ALGBENENGDO HOHPIDGDIME(CPJOONJCBLA MKDJIBNCKNC, int EOADDPLOJHN = 90)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x48A4040", Offset = "0x48A2640", VA = "0x1848A4040")]
	public static ALGBENENGDO FEFBMDKKBMI(CPJOONJCBLA MKDJIBNCKNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x48A3F90", Offset = "0x48A2590", VA = "0x1848A3F90")]
	public static void BPNANAMHBBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KLDKFJCICEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public int IHJMHACOMFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly Queue<double> EDOKHFABNNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private double EEIGLGPCDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private double GPKLECHELAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private double LCLNABDMKEA;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public double EAHNEFDCIEK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x48A4670", Offset = "0x48A2C70", VA = "0x1848A4670", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x48A4740", Offset = "0x48A2D40", VA = "0x1848A4740")]
	public KLDKFJCICEI(int LJCAJKAPJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x48A4570", Offset = "0x48A2B70", VA = "0x1848A4570", Slot = "4")]
	public void DGKDGDACLKI(double GBDFHGIMHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x48A46D0", Offset = "0x48A2CD0", VA = "0x1848A46D0", Slot = "5")]
	public void NFEMDFDACGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class KDDGMFBPJJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private long DHNBJNKGAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private double LKDBPNEALJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private double PINGGLODDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private double AECBENLIMNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private double HAJMAEJDNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private double EEIGLGPCDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private double GPKLECHELAE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public long LLHHHCBKNJN
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public double KHNLPEPOGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37F2380", Offset = "0x37F0980", VA = "0x1837F2380", Slot = "4")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public double LNFJFBLJGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9521A0", Offset = "0x9507A0", VA = "0x1809521A0", Slot = "5")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public double EFNLMMFBEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3386EF0", Offset = "0x33854F0", VA = "0x183386EF0")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public double EAHNEFDCIEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x37F22B0", Offset = "0x37F08B0", VA = "0x1837F22B0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x48A43A0", Offset = "0x48A29A0", VA = "0x1848A43A0", Slot = "7")]
	public void DGKDGDACLKI(double GBDFHGIMHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x48A44C0", Offset = "0x48A2AC0", VA = "0x1848A44C0", Slot = "8")]
	public void NFEMDFDACGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x48A4500", Offset = "0x48A2B00", VA = "0x1848A4500")]
	public KDDGMFBPJJC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class PKDAMECFBEH
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private interface CKPJDBGFJAG
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		bool ONFAAGNHHLP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AKPIIOLAJBO();
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private abstract class ACNONFMCOKL<TPromise, TMainThreadPromise> : CKPJDBGFJAG where TPromise : APPFHLGLKJA where TMainThreadPromise : TPromise
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly TPromise BEAPAMNKBIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		protected readonly TMainThreadPromise GADKCHOPLAK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public TPromise EBGEKDBCCKA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x30A4CA0", Offset = "0x30A32A0", VA = "0x1830A4CA0")]
			get
			{
				return (TPromise)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ONFAAGNHHLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x30A4C20", Offset = "0x30A3220", VA = "0x1830A4C20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2122870", Offset = "0x2120E70", VA = "0x182122870")]
		protected ACNONFMCOKL(TPromise BEAPAMNKBIE, TMainThreadPromise FGBCMBKAHDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x30A4C70", Offset = "0x30A3270", VA = "0x1830A4C70", Slot = "5")]
		public void AKPIIOLAJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void MOPLNJFDNBP(TPromise BEAPAMNKBIE);
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	private class JMHBBBKENLA<T> : ACNONFMCOKL<global::DBIKMJJJBLJ<T>, global::GKABJNPDFNH<T>>
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x30A70A0", Offset = "0x30A56A0", VA = "0x1830A70A0")]
		public JMHBBBKENLA(global::DBIKMJJJBLJ<T> BEAPAMNKBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x30A6F00", Offset = "0x30A5500", VA = "0x1830A6F00", Slot = "6")]
		protected override void MOPLNJFDNBP(global::DBIKMJJJBLJ<T> BEAPAMNKBIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x30A6EA0", Offset = "0x30A54A0", VA = "0x1830A6EA0")]
		[CompilerGenerated]
		private void DJBODLLIKGH(T AEOILPMENGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x30A6ED0", Offset = "0x30A54D0", VA = "0x1830A6ED0")]
		[CompilerGenerated]
		private void FDNBHIMONHK(string IOBNDAKOHMA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	private class CAIDILHDBDN : CKPJDBGFJAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly Action BKCLKIJOKLP;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ONFAAGNHHLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x560FE0", Offset = "0x55F5E0", VA = "0x180560FE0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69EFB0", Offset = "0x69D5B0", VA = "0x18069EFB0")]
		public CAIDILHDBDN(Action BKCLKIJOKLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x1310E70", Offset = "0x130F470", VA = "0x181310E70", Slot = "5")]
		public void AKPIIOLAJBO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private static readonly List<CKPJDBGFJAG> NEPCOPANPDB;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x262B200", Offset = "0x2629800", VA = "0x18262B200")]
	public static global::DBIKMJJJBLJ<T> BKCCMKJEPCK<T>(this global::DBIKMJJJBLJ<T> BEAPAMNKBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x48A7B90", Offset = "0x48A6190", VA = "0x1848A7B90")]
	public static void BKCCMKJEPCK(Action BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x262B270", Offset = "0x2629870", VA = "0x18262B270")]
	private static global::DBIKMJJJBLJ<T> HCECDEDOMOP<T>(global::DBIKMJJJBLJ<T> BEAPAMNKBIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x48A7C20", Offset = "0x48A6220", VA = "0x1848A7C20")]
	private static void IKOPJLEBEEN(CKPJDBGFJAG BAKDAGLAGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x48A7870", Offset = "0x48A5E70", VA = "0x1848A7870")]
	private static void AINDMHMNLGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x48A7EC0", Offset = "0x48A64C0", VA = "0x1848A7EC0")]
	private static void PPJFFFBMBLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x48A7E10", Offset = "0x48A6410", VA = "0x1848A7E10")]
	private static void LCCGCMANPAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class DDFMJJLCIGL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private struct KAGCCDLPDAI : IAsyncStateMachine
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
		public BJHOOGFBDGF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public bool stopOnEmptyScene;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private global::EJAKMHICFJG<BJHOOGFBDGF, string> <timerScope>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x48A3A30", Offset = "0x48A2030", VA = "0x1848A3A30", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class PIJHFFMIKNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public BNGELMJMADH promise;

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public PIJHFFMIKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x48A7820", Offset = "0x48A5E20", VA = "0x1848A7820")]
		internal void <LoadSceneInternal>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private struct DMEPJFKFPMM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public BJHOOGFBDGF stackTimer;

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
		private PIJHFFMIKNB <>8__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private GAAMEIHCBEJ <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x489DAE0", Offset = "0x489C0E0", VA = "0x18489DAE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private struct GPPMEFBAJNC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public BJHOOGFBDGF stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private GAAMEIHCBEJ <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private GAAMEIHCBEJ <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x489FF50", Offset = "0x489E550", VA = "0x18489FF50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6FF6D0", Offset = "0x6FDCD0", VA = "0x1806FF6D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class DPJAAODEKEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public AsyncOperation sceneLoadOperation;

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public DPJAAODEKEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x489E3B0", Offset = "0x489C9B0", VA = "0x18489E3B0")]
		internal bool <PreloadSceneRoutine>b__0()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class MOFCMNCMICD : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public BNGELMJMADH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public MOFCMNCMICD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x48A5A00", Offset = "0x48A4000", VA = "0x1848A5A00", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x48A56C0", Offset = "0x48A3CC0", VA = "0x1848A56C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x48A5AB0", Offset = "0x48A40B0", VA = "0x1848A5AB0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x48A59B0", Offset = "0x48A3FB0", VA = "0x1848A59B0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class IGEHAMJPMAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public BNGELMJMADH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public IDisposable sample;

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public IGEHAMJPMAH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class CPELJDFOENP : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public string sceneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public BNGELMJMADH onCompletePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public LoadSceneMode loadSceneMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private IGEHAMJPMAH <>8__1;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public CPELJDFOENP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x489A1E0", Offset = "0x48987E0", VA = "0x18489A1E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x489A580", Offset = "0x4898B80", VA = "0x18489A580", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static APPFHLGLKJA DJGOMFJOELM;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static AsyncOperation HJFJJIDNGHM;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static APPFHLGLKJA PAHKGAOPJOM;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static string KKOGNPNJOCD;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static ThreadPriority BKIBGLFNNPN;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static Task NOMBJKHIOOJ;

	[Cpp2IlInjected.Token(Token = "0x4000046")]
	private static readonly Queue<(string sceneName, LoadSceneMode loadSceneMode, bool stopOnEmptyScene, BJHOOGFBDGF stackTimer)> EBKIDGLOBJB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool NBELNHEMEID
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x489C9F0", Offset = "0x489AFF0", VA = "0x18489C9F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private static bool NKFAOPABHFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x489C6F0", Offset = "0x489ACF0", VA = "0x18489C6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private static bool KKHBKGGHDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x489CE30", Offset = "0x489B430", VA = "0x18489CE30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public static event Action<string, LoadSceneMode> HGFIHICCIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x489CBA0", Offset = "0x489B1A0", VA = "0x18489CBA0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x489CD30", Offset = "0x489B330", VA = "0x18489CD30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x489C200", Offset = "0x489A800", VA = "0x18489C200")]
	[NAOLMNKNAMK(DKCHBDLNPEE.EnteredEditModeNextFrame, 0)]
	private static void DBIHAMFEJOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x489C830", Offset = "0x489AE30", VA = "0x18489C830")]
	[AsyncStateMachine(typeof(KAGCCDLPDAI))]
	public static Task FEHLFEAHJAD(string NLEHPBOLMFJ, LoadSceneMode HAKBFPEGGGC = LoadSceneMode.Single, bool JBAGLFBFICM = false, [Optional] BJHOOGFBDGF OADNBMGMCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80")]
	private static void EBNJOBFOANJ(BJHOOGFBDGF FIEDOLNFNLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x489CEE0", Offset = "0x489B4E0", VA = "0x18489CEE0")]
	[AsyncStateMachine(typeof(DMEPJFKFPMM))]
	private static Task NOMPHOLDIKA(string NLEHPBOLMFJ, LoadSceneMode HAKBFPEGGGC, bool JBAGLFBFICM, BJHOOGFBDGF OADNBMGMCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x489C110", Offset = "0x489A710", VA = "0x18489C110")]
	[AsyncStateMachine(typeof(GPPMEFBAJNC))]
	private static Task AGIENKKIBAA(BJHOOGFBDGF OADNBMGMCGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x489C970", Offset = "0x489AF70", VA = "0x18489C970")]
	public static APPFHLGLKJA FNCDHFNBPPP(string NLEHPBOLMFJ, LoadSceneMode HAKBFPEGGGC = LoadSceneMode.Single)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x489C2D0", Offset = "0x489A8D0", VA = "0x18489C2D0")]
	public static APPFHLGLKJA DKODIOLBFGB(string NLEHPBOLMFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x489CCA0", Offset = "0x489B2A0", VA = "0x18489CCA0")]
	[IteratorStateMachine(typeof(MOFCMNCMICD))]
	private static IEnumerator<MCOOOHEMEPE> HIHDILNHGGO(string NLEHPBOLMFJ, BNGELMJMADH DBFGPAJMMDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x489C7A0", Offset = "0x489ADA0", VA = "0x18489C7A0")]
	[IteratorStateMachine(typeof(CPELJDFOENP))]
	private static IEnumerator<MCOOOHEMEPE> FCNILJACPDH(string NLEHPBOLMFJ, LoadSceneMode HAKBFPEGGGC, BNGELMJMADH DBFGPAJMMDA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GPBNLAMKINH
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x489F7E0", Offset = "0x489DDE0", VA = "0x18489F7E0")]
	public static IDisposable BDGNJBDEOPN(this OILEMCJJFLI GCLGODGIPBD, float DMKBBJPNHDB, Action<float> MIMODPGCKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x489F860", Offset = "0x489DE60", VA = "0x18489F860")]
	public static IDisposable KOAFOMHDPFL(this OILEMCJJFLI GCLGODGIPBD, Action<float> MIMODPGCKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x489F760", Offset = "0x489DD60", VA = "0x18489F760")]
	public static IDisposable APLHLBOICPI(this OILEMCJJFLI GCLGODGIPBD, Action<float> MIMODPGCKAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class OPMCCEMOAII
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x48A76E0", Offset = "0x48A5CE0", VA = "0x1848A76E0")]
	public static IDisposable NNBCMDNEKLO(this MonoBehaviour KGOEDNFCCJL, Action MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x48A7530", Offset = "0x48A5B30", VA = "0x1848A7530")]
	public static IDisposable NNBCMDNEKLO(this MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x48A7150", Offset = "0x48A5750", VA = "0x1848A7150")]
	public static IDisposable IFFNNMKLCCI(this MonoBehaviour KGOEDNFCCJL, Action MIMODPGCKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x48A6FC0", Offset = "0x48A55C0", VA = "0x1848A6FC0")]
	public static IDisposable GFBMFMEHLCJ(this MonoBehaviour KGOEDNFCCJL, Action MIMODPGCKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x48A6E50", Offset = "0x48A5450", VA = "0x1848A6E50")]
	public static IDisposable FALPMDMPBEL(this MonoBehaviour KGOEDNFCCJL, Action MIMODPGCKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x48A6CB0", Offset = "0x48A52B0", VA = "0x1848A6CB0")]
	public static IDisposable ABEEGEPPHOO(this MonoBehaviour KGOEDNFCCJL, Action MIMODPGCKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x48A6F50", Offset = "0x48A5550", VA = "0x1848A6F50")]
	public static IDisposable GDABLGCLPIJ(this MonoBehaviour KGOEDNFCCJL, Action MIMODPGCKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x48A7400", Offset = "0x48A5A00", VA = "0x1848A7400")]
	public static IDisposable NACPLBHOAED(this MonoBehaviour KGOEDNFCCJL, float DMKBBJPNHDB, Action<float> MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x48A72E0", Offset = "0x48A58E0", VA = "0x1848A72E0")]
	public static IDisposable JGJKLMJIOKP(this MonoBehaviour KGOEDNFCCJL, float DMKBBJPNHDB, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x48A6EC0", Offset = "0x48A54C0", VA = "0x1848A6EC0")]
	public static IDisposable FFKENFKLJIE(this MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x48A6DC0", Offset = "0x48A53C0", VA = "0x1848A6DC0")]
	public static IDisposable FABKLLKKKME(this MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x48A71C0", Offset = "0x48A57C0", VA = "0x1848A71C0")]
	public static IDisposable IFNMBINPNPM(this MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x48A7250", Offset = "0x48A5850", VA = "0x1848A7250")]
	public static IDisposable ILDALIGHGGP(this MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x48A7370", Offset = "0x48A5970", VA = "0x1848A7370")]
	public static IDisposable KDIONNGHNOA(this MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x48A74A0", Offset = "0x48A5AA0", VA = "0x1848A74A0")]
	public static IDisposable NEDGHNBHMEB(this MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x48A7030", Offset = "0x48A5630", VA = "0x1848A7030")]
	public static IDisposable HHLGFKOLDGM(this MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x48A6D20", Offset = "0x48A5320", VA = "0x1848A6D20")]
	public static IDisposable ENOFONPNCCO(this MonoBehaviour KGOEDNFCCJL, float DMKBBJPNHDB, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x48A70C0", Offset = "0x48A56C0", VA = "0x1848A70C0")]
	public static IDisposable HJPCEAACMLM(this MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public static class DLEMNCJCGDB
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[CompilerGenerated]
	private sealed class FIMHCKFJILP : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public NLKBGIPIPAN.OLLNHPNJKPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public Action update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private IDMMCBJEILH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public FIMHCKFJILP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x489E900", Offset = "0x489CF00", VA = "0x18489E900", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x489E9C0", Offset = "0x489CFC0", VA = "0x18489E9C0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[CompilerGenerated]
	private sealed class HLIOHMPMBOO : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public NLKBGIPIPAN.OLLNHPNJKPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private IDMMCBJEILH <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public HLIOHMPMBOO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x48A0A00", Offset = "0x489F000", VA = "0x1848A0A00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x48A0AE0", Offset = "0x489F0E0", VA = "0x1848A0AE0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x489D900", Offset = "0x489BF00", VA = "0x18489D900")]
	public static JPGLPKCHKEM NNBCMDNEKLO(Action MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x489D790", Offset = "0x489BD90", VA = "0x18489D790")]
	public static JPGLPKCHKEM NNBCMDNEKLO(Behaviour GCLGODGIPBD, Action MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x489D820", Offset = "0x489BE20", VA = "0x18489D820")]
	public static JPGLPKCHKEM NNBCMDNEKLO(Behaviour GCLGODGIPBD, Action<float> MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x489DA60", Offset = "0x489C060", VA = "0x18489DA60")]
	[IteratorStateMachine(typeof(FIMHCKFJILP))]
	private static IEnumerator<MCOOOHEMEPE> NOABBKKGDLO(NLKBGIPIPAN.OLLNHPNJKPB KDFMIEPKJEM, Action MIMODPGCKAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x489D9E0", Offset = "0x489BFE0", VA = "0x18489D9E0")]
	[IteratorStateMachine(typeof(HLIOHMPMBOO))]
	private static IEnumerator<MCOOOHEMEPE> NOABBKKGDLO(NLKBGIPIPAN.OLLNHPNJKPB KDFMIEPKJEM, Action<float> MIMODPGCKAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class BDEJIOCMNIF
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class JGANLAEFJDD : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public BMCLGOCGNKP schedulerTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public float hz;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NLKBGIPIPAN.OLLNHPNJKPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public bool stagger;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public Action<float> update;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private PABKEPOHGFN <schedule>5__2;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public JGANLAEFJDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x48A2120", Offset = "0x48A0720", VA = "0x1848A2120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x48A2250", Offset = "0x48A0850", VA = "0x1848A2250", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4897B50", Offset = "0x4896150", VA = "0x184897B50")]
	public static JPGLPKCHKEM NNBCMDNEKLO(MonoBehaviour KGOEDNFCCJL, float DMKBBJPNHDB, Action<float> MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4897CD0", Offset = "0x48962D0", VA = "0x184897CD0")]
	public static JPGLPKCHKEM OMGLBEPDBKE(OILEMCJJFLI GCLGODGIPBD, float DMKBBJPNHDB, Action<float> MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM, bool NLCNLIDOHJE = true)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4897C20", Offset = "0x4896220", VA = "0x184897C20")]
	[IteratorStateMachine(typeof(JGANLAEFJDD))]
	private static IEnumerator<MCOOOHEMEPE> NOABBKKGDLO(BMCLGOCGNKP BOIANAJLMPJ, float DMKBBJPNHDB, NLKBGIPIPAN.OLLNHPNJKPB KDFMIEPKJEM, Action<float> MIMODPGCKAO, bool NLCNLIDOHJE = true)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class DNMEHIKPHJG
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class HFCNJJKANNG : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NLKBGIPIPAN.OLLNHPNJKPB queueType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Func<bool> condition;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public HFCNJJKANNG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x48A07E0", Offset = "0x489EDE0", VA = "0x1848A07E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x48A0890", Offset = "0x489EE90", VA = "0x1848A0890", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x489E250", Offset = "0x489C850", VA = "0x18489E250")]
	[IteratorStateMachine(typeof(HFCNJJKANNG))]
	private static IEnumerator<MCOOOHEMEPE> FDJECKDKCJD(NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM, Func<bool> JFOHMDJAGHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x489E2D0", Offset = "0x489C8D0", VA = "0x18489E2D0")]
	public static JPGLPKCHKEM OFKICKELCPJ(this MonoBehaviour KGOEDNFCCJL, Func<bool> JFOHMDJAGHO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM = NLKBGIPIPAN.OLLNHPNJKPB.Update)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class APEBADAEKEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class ADKMNMOBFFC : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public float seconds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NLKBGIPIPAN.OLLNHPNJKPB queue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public Action function;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public ADKMNMOBFFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x48964B0", Offset = "0x4894AB0", VA = "0x1848964B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4896570", Offset = "0x4894B70", VA = "0x184896570", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4896FF0", Offset = "0x48955F0", VA = "0x184896FF0")]
	[IteratorStateMachine(typeof(ADKMNMOBFFC))]
	private static IEnumerator<MCOOOHEMEPE> HKBCHHJBJKG(float IMIFELBEFMN, NLKBGIPIPAN.OLLNHPNJKPB KDFMIEPKJEM, Action PMOCGMLKNMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4896B90", Offset = "0x4895190", VA = "0x184896B90")]
	public static JPGLPKCHKEM AJPAIMJFBJP(this MonoBehaviour KGOEDNFCCJL, float IMIFELBEFMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4896C20", Offset = "0x4895220", VA = "0x184896C20")]
	public static JPGLPKCHKEM ALIIJIMEIGN(this MonoBehaviour KGOEDNFCCJL, Action PMOCGMLKNMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4896CC0", Offset = "0x48952C0", VA = "0x184896CC0")]
	public static JPGLPKCHKEM BKEGIFMJEMO(this MonoBehaviour KGOEDNFCCJL, Action PMOCGMLKNMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4896E90", Offset = "0x4895490", VA = "0x184896E90")]
	public static JPGLPKCHKEM FCCBBIJLIEH(this MonoBehaviour KGOEDNFCCJL, Action PMOCGMLKNMF, [Optional] NIECEGPGMIC GILKIBNHGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4896D60", Offset = "0x4895360", VA = "0x184896D60")]
	public static JPGLPKCHKEM DKANDOAKHOD(this MonoBehaviour KGOEDNFCCJL, Action PMOCGMLKNMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4896EC0", Offset = "0x48954C0", VA = "0x184896EC0")]
	public static JPGLPKCHKEM FEJCKGAMIIN(this MonoBehaviour KGOEDNFCCJL, Action PMOCGMLKNMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4897110", Offset = "0x4895710", VA = "0x184897110")]
	private static JPGLPKCHKEM JKFLIDONAOL(MonoBehaviour KGOEDNFCCJL, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM, Action PMOCGMLKNMF, [Optional] NIECEGPGMIC GILKIBNHGOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4896B00", Offset = "0x4895100", VA = "0x184896B00")]
	public static JPGLPKCHKEM AJGMGGINAAC(this MonoBehaviour KGOEDNFCCJL, float IIICNGNAECN, Action PMOCGMLKNMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4896F60", Offset = "0x4895560", VA = "0x184896F60")]
	public static JPGLPKCHKEM GCBIGEDKMLM(this MonoBehaviour KGOEDNFCCJL, float IIICNGNAECN, Action PMOCGMLKNMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4896E00", Offset = "0x4895400", VA = "0x184896E00")]
	public static JPGLPKCHKEM DPELFLFOPEA(this MonoBehaviour KGOEDNFCCJL, float IIICNGNAECN, Action PMOCGMLKNMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4897080", Offset = "0x4895680", VA = "0x184897080")]
	public static JPGLPKCHKEM IADCAMAHEMK(this MonoBehaviour KGOEDNFCCJL, float IIICNGNAECN, Action PMOCGMLKNMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class IGPFPAINJNJ : DJMNNNFDGGJ
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class GMGGNPIIPMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public IGPFPAINJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public GMGGNPIIPMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x489F730", Offset = "0x489DD30", VA = "0x18489F730")]
		internal void <TryInvokeDuringActiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[CompilerGenerated]
	private sealed class ONHLOINDGHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public IGPFPAINJNJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public Action action;

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ONHLOINDGHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x489F730", Offset = "0x489DD30", VA = "0x18489F730")]
		internal void <TryInvokeDuringInactiveCooldown>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly float NLDOKEICBEG;

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x48A0EA0", Offset = "0x489F4A0", VA = "0x1848A0EA0")]
	public IGPFPAINJNJ(Behaviour GCLGODGIPBD, float NLDOKEICBEG, [Optional] Action LFOPKMIANPK, [Optional] NIECEGPGMIC GILKIBNHGOO, [Optional] BMCLGOCGNKP BOIANAJLMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x48A0DC0", Offset = "0x489F3C0", VA = "0x1848A0DC0", Slot = "9")]
	protected override bool OPLGMDIDNHG(Action BKCLKIJOKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x48A0CE0", Offset = "0x489F2E0", VA = "0x1848A0CE0", Slot = "10")]
	protected override bool JOFDHEFCBFJ(Action BKCLKIJOKLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface PMCHFGACKFG
{
	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	bool PEGNEFCLPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action JFLDAHCOIKL;

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FBJIALFKIHL(bool LLLNICPNHJM = false);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool FBJIALFKIHL(Action BKCLKIJOKLP, bool LLLNICPNHJM = false);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public abstract class DJMNNNFDGGJ : PMCHFGACKFG
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class AIKPGIBOICL : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public DJMNNNFDGGJ <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public float duration;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public AIKPGIBOICL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4896650", Offset = "0x4894C50", VA = "0x184896650", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4896720", Offset = "0x4894D20", VA = "0x184896720", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly Behaviour GCLGODGIPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly Action LFOPKMIANPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private JIGNBICHMOJ IKOPECKBBDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private readonly NIECEGPGMIC GILKIBNHGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	protected readonly BMCLGOCGNKP BOIANAJLMPJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool PEGNEFCLPNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x7704E0", Offset = "0x76EAE0", VA = "0x1807704E0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event Action JFLDAHCOIKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x489D500", Offset = "0x489BB00", VA = "0x18489D500", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x489D300", Offset = "0x489B900", VA = "0x18489D300", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x489D5C0", Offset = "0x489BBC0", VA = "0x18489D5C0")]
	protected DJMNNNFDGGJ(Behaviour GCLGODGIPBD, [Optional] Action LFOPKMIANPK, [Optional] NIECEGPGMIC GILKIBNHGOO, [Optional] BMCLGOCGNKP BOIANAJLMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x489D410", Offset = "0x489BA10", VA = "0x18489D410", Slot = "7")]
	public bool FBJIALFKIHL(bool LLLNICPNHJM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x489D470", Offset = "0x489BA70", VA = "0x18489D470", Slot = "8")]
	public bool FBJIALFKIHL(Action BKCLKIJOKLP, bool LLLNICPNHJM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract bool OPLGMDIDNHG(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract bool JOFDHEFCBFJ(Action BKCLKIJOKLP);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x489D5A0", Offset = "0x489BBA0", VA = "0x18489D5A0")]
	protected void LMDEDMMCEBC(Action BKCLKIJOKLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x489D130", Offset = "0x489B730", VA = "0x18489D130")]
	protected APPFHLGLKJA DOCMCKHLAGA(float ABEGJDMHCHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x489D3A0", Offset = "0x489B9A0", VA = "0x18489D3A0")]
	private void EOJFHDNFDAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x489D0B0", Offset = "0x489B6B0", VA = "0x18489D0B0")]
	[IteratorStateMachine(typeof(AIKPGIBOICL))]
	private IEnumerator<MCOOOHEMEPE> CCJOHEEEFEL(float ABEGJDMHCHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x489D4C0", Offset = "0x489BAC0", VA = "0x18489D4C0")]
	[CompilerGenerated]
	private void IAPKKDMAHLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class EJOEAFIHFBF : DJMNNNFDGGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private readonly float CCLAFOHJHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly int MMAGFNGPCBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private readonly float AJLBKOHIFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private readonly float[] MBJMBBJELPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private int CCAADDHHJIC;

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x489E6D0", Offset = "0x489CCD0", VA = "0x18489E6D0")]
	public EJOEAFIHFBF(Behaviour GCLGODGIPBD, float ICGHPBBMFGP, int MMAGFNGPCBB, [Optional] Action LFOPKMIANPK, float AJLBKOHIFEG = 0f, [Optional] NIECEGPGMIC GILKIBNHGOO, [Optional] BMCLGOCGNKP BOIANAJLMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0", Slot = "9")]
	protected override bool OPLGMDIDNHG(Action BKCLKIJOKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x489E4B0", Offset = "0x489CAB0", VA = "0x18489E4B0", Slot = "10")]
	protected override bool JOFDHEFCBFJ(Action BKCLKIJOKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x489E420", Offset = "0x489CA20", VA = "0x18489E420")]
	private void HHINHLCKJCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class KFEMOFJKKFJ : DJMNNNFDGGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly float NLDOKEICBEG;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x48A0EA0", Offset = "0x489F4A0", VA = "0x1848A0EA0")]
	public KFEMOFJKKFJ(Behaviour GCLGODGIPBD, float NLDOKEICBEG, [Optional] Action LFOPKMIANPK, [Optional] NIECEGPGMIC GILKIBNHGOO, [Optional] BMCLGOCGNKP BOIANAJLMPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x560EC0", Offset = "0x55F4C0", VA = "0x180560EC0", Slot = "9")]
	protected override bool OPLGMDIDNHG(Action BKCLKIJOKLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x48A4530", Offset = "0x48A2B30", VA = "0x1848A4530", Slot = "10")]
	protected override bool JOFDHEFCBFJ(Action BKCLKIJOKLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class NEDFONOIPAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class GLONHFMBFPE : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public GLONHFMBFPE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x489F640", Offset = "0x489DC40", VA = "0x18489F640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x489F6E0", Offset = "0x489DCE0", VA = "0x18489F6E0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private JPGLPKCHKEM PBJMPKEJCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private OILEMCJJFLI GCLGODGIPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private Action<float> AFIAFHCILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private float NHPDKHLFEID;

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x48A6150", Offset = "0x48A4750", VA = "0x1848A6150")]
	public NEDFONOIPAA(OILEMCJJFLI GCLGODGIPBD, float DMKBBJPNHDB, Action<float> MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x48A6000", Offset = "0x48A4600", VA = "0x1848A6000")]
	private void ODNNPGEEADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x48A5D30", Offset = "0x48A4330", VA = "0x1848A5D30")]
	private void HJIANCEHBNJ(string IOBNDAKOHMA, Action JGJHHIBDMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x48A5F90", Offset = "0x48A4590", VA = "0x1848A5F90")]
	[IteratorStateMachine(typeof(GLONHFMBFPE))]
	private IEnumerator<MCOOOHEMEPE> JNNBCKDFDMK(Action JGJHHIBDMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x48A5CD0", Offset = "0x48A42D0", VA = "0x1848A5CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x48A5E40", Offset = "0x48A4440", VA = "0x1848A5E40")]
	[CompilerGenerated]
	private void IOFFBBANHGD(string BACBMFCMEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public sealed class GEKMLELKKHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private sealed class MBMNLBNAHLC : IEnumerator<MCOOOHEMEPE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private MCOOOHEMEPE <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		public Action requeueAction;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private MCOOOHEMEPE System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x6717D0", Offset = "0x66FDD0", VA = "0x1806717D0")]
		[DebuggerHidden]
		public MBMNLBNAHLC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x48A54D0", Offset = "0x48A3AD0", VA = "0x1848A54D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x48A5570", Offset = "0x48A3B70", VA = "0x1848A5570", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private JPGLPKCHKEM PBJMPKEJCGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private MonoBehaviour KGOEDNFCCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private Action MIMODPGCKAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private Action<float> AFIAFHCILHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private float NHPDKHLFEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private bool NLCNLIDOHJE;

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x489F1C0", Offset = "0x489D7C0", VA = "0x18489F1C0")]
	public GEKMLELKKHA(MonoBehaviour KGOEDNFCCJL, Action MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x489F310", Offset = "0x489D910", VA = "0x18489F310")]
	public GEKMLELKKHA(MonoBehaviour KGOEDNFCCJL, Action<float> MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x489F4A0", Offset = "0x489DAA0", VA = "0x18489F4A0")]
	public GEKMLELKKHA(MonoBehaviour KGOEDNFCCJL, float DMKBBJPNHDB, Action<float> MIMODPGCKAO, NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM, bool NLCNLIDOHJE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x489EF50", Offset = "0x489D550", VA = "0x18489EF50")]
	private void NNBCMDNEKLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x489EAF0", Offset = "0x489D0F0", VA = "0x18489EAF0")]
	private void GHCBOADLACD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x489F070", Offset = "0x489D670", VA = "0x18489F070")]
	private void ODNNPGEEADG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x489EC40", Offset = "0x489D240", VA = "0x18489EC40")]
	private void HJIANCEHBNJ(string IOBNDAKOHMA, Action JGJHHIBDMIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x489EDE0", Offset = "0x489D3E0", VA = "0x18489EDE0")]
	[IteratorStateMachine(typeof(MBMNLBNAHLC))]
	private IEnumerator<MCOOOHEMEPE> JNNBCKDFDMK(Action JGJHHIBDMIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x489EA90", Offset = "0x489D090", VA = "0x18489EA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x489EE50", Offset = "0x489D450", VA = "0x18489EE50")]
	[CompilerGenerated]
	private void NHAJJMDKFKF(string BACBMFCMEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x489EED0", Offset = "0x489D4D0", VA = "0x18489EED0")]
	[CompilerGenerated]
	private void NIJGHAFBHFJ(string BACBMFCMEGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x489ED60", Offset = "0x489D360", VA = "0x18489ED60")]
	[CompilerGenerated]
	private void HNNADJOFLOF(string BACBMFCMEGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[Flags]
internal enum OHOEGKIJDMN : byte
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
internal sealed class PKMIEDNBCFB : BMCLGOCGNKP
{
	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public float FNGIEGBLJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x48A8010", Offset = "0x48A6610", VA = "0x1848A8010", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public float JMJFFHKAEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x48A80F0", Offset = "0x48A66F0", VA = "0x1848A80F0", Slot = "5")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public double NOLLPMMLKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x48A7FF0", Offset = "0x48A65F0", VA = "0x1848A7FF0", Slot = "6")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x48A8020", Offset = "0x48A6620", VA = "0x1848A8020")]
	[MBNOPHMLNBM]
	private static void JONMGHBDFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	[Preserve]
	internal PKMIEDNBCFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
internal interface HCMGAPMENDA
{
	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BBLHCHOPGJG(string MONHCMBIJIP);

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EINHKCCCDGF();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
internal interface DKGCPKCNHBB
{
	[Cpp2IlInjected.Token(Token = "0x17000028")]
	string KKHBICLGHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	bool ELPPJMJNBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	bool AHDPOHKLKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
internal class APFFGEMFCPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public BHNDAPMCHIM EAMDMGBEDAE;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public int OOODCJOIDPB
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x560ED0", Offset = "0x55F4D0", VA = "0x180560ED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x560EE0", Offset = "0x55F4E0", VA = "0x180560EE0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4897390", Offset = "0x4895990", VA = "0x184897390")]
	public static MCOOOHEMEPE DPHLNEHOLLF(IEnumerator<MCOOOHEMEPE> GBLEGCCOFFF, JAACHPBFEIB PNEBNJNAOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x48972B0", Offset = "0x48958B0", VA = "0x1848972B0")]
	public MCOOOHEMEPE DPHLNEHOLLF(JAACHPBFEIB[] NEPDEDPKKLI, IEnumerator<MCOOOHEMEPE>[] HPMEHBJLMIN, MCOOOHEMEPE[] FKNCINDMNEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4897280", Offset = "0x4895880", VA = "0x184897280")]
	public void ELMHLALHANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x48971B0", Offset = "0x48957B0", VA = "0x1848971B0")]
	public void CGPPAEAKIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x48974F0", Offset = "0x4895AF0", VA = "0x1848974F0")]
	public void NGAMIPFIOKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x4897280", Offset = "0x4895880", VA = "0x184897280")]
	public void DDPMPAFGPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public APFFGEMFCPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
internal sealed class BHNDAPMCHIM
{
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public struct BAMDABNCLMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public APFFGEMFCPH EEKKFAKHAAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public OILEMCJJFLI HGJNEAFKMAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public JAACHPBFEIB LKNHLIONGOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public IEnumerator<MCOOOHEMEPE> CBHLKPFHGMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public MCOOOHEMEPE HFKBLOKNELM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public OHOEGKIJDMN IGCPLMGNBOI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public struct MLFDBAAIKOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public NLKBGIPIPAN.OLLNHPNJKPB AFKNALDOKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		public List<BAMDABNCLMJ> IKPGIEONBKC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private sealed class ONDOHMHMFCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public BHNDAPMCHIM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public OILEMCJJFLI context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public APFFGEMFCPH routine;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public OHOEGKIJDMN coroutineState;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public JAACHPBFEIB promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public MCOOOHEMEPE currentSchedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public IEnumerator<MCOOOHEMEPE> coroutine;

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public ONDOHMHMFCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x48A65B0", Offset = "0x48A4BB0", VA = "0x1848A65B0")]
		internal void <InsertJobbedSchedulerCoroutine>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private sealed class FIPGPCHFFFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public APFFGEMFCPH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public BHNDAPMCHIM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FIPGPCHFFFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x489EA10", Offset = "0x489D010", VA = "0x18489EA10")]
		internal void <Cancel>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class EBCEMBIBPEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public APFFGEMFCPH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public BHNDAPMCHIM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public EBCEMBIBPEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x489E3E0", Offset = "0x489C9E0", VA = "0x18489E3E0")]
		internal void <Pause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class FKHCMACAFPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public APFFGEMFCPH schedule;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public BHNDAPMCHIM <>4__this;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
		public FKHCMACAFPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x489EA50", Offset = "0x489D050", VA = "0x18489EA50")]
		internal void <Unpause>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private const OHOEGKIJDMN DLKPPBFIDBD = OHOEGKIJDMN.Cancelled | OHOEGKIJDMN.Paused;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private readonly NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private bool[] BNONDLNAGIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private NativeArray<OHOEGKIJDMN> NAIEPOGNFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private NativeArray<float> GEEHGJOFAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private NativeArray<int> NMOBBOAFNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private NativeArray<int> HNBDJJNCBCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private NativeArray<int> LOGJPCJAELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private NativeArray<int> FECEACAMEGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private NativeArray<int> JEHICFLHKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private APFFGEMFCPH[] NOBLFJCNLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private JAACHPBFEIB[] NEPDEDPKKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private OILEMCJJFLI[] EHPKLCEDNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private IEnumerator<MCOOOHEMEPE>[] APKNHPJEGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private MCOOOHEMEPE[] PKDLDCHNEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private int EPBFONCFCOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private int NKJBJGFALMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly int GDOOAMMGBMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private float OAEJOBLGKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private BBGNCENKCOH BPMLPABHIOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private JobHandle CMKHGEJJHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private List<APFFGEMFCPH> BHFJJPCHJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private bool CHBFJKJFJNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private List<Action> MCDBCLKKIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private List<Action> FPKMFMMEKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private bool NMGGJHAEIOL;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public MLFDBAAIKOK[] AENBJPEPPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8B05E0", Offset = "0x8AEBE0", VA = "0x1808B05E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4899400", Offset = "0x4897A00", VA = "0x184899400")]
	private static int MJHOCKHKLGL(NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4899B70", Offset = "0x4898170", VA = "0x184899B70")]
	public BHNDAPMCHIM(NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x48990F0", Offset = "0x48976F0", VA = "0x1848990F0")]
	private void ICLOOIJOLJB(ref int BDLMEAOECKG, int IEFCOCDJPPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4897DA0", Offset = "0x48963A0", VA = "0x184897DA0")]
	public void AEIIADHPGME(OILEMCJJFLI GCLGODGIPBD, MCOOOHEMEPE DCPFAJBOOHE, IEnumerator<MCOOOHEMEPE> GBLEGCCOFFF, JAACHPBFEIB PNEBNJNAOIA, [Optional] APFFGEMFCPH PNCLOCCOIKB, OHOEGKIJDMN DECOIPGBCMK = OHOEGKIJDMN.Running)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4897F00", Offset = "0x4896500", VA = "0x184897F00")]
	public void AMHOGIPPKGE(IEnumerable<BAMDABNCLMJ> LDPMGDIHLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x48985E0", Offset = "0x4896BE0", VA = "0x1848985E0")]
	private BAMDABNCLMJ EHFBPAPPBJN(int NEIGECBHEIG)
	{
		return default(BAMDABNCLMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4898270", Offset = "0x4896870", VA = "0x184898270")]
	private void DOFHHFHNHBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1F59DE0", Offset = "0x1F583E0", VA = "0x181F59DE0")]
	private static void AAICLLGNCBN<T>(int NEIGECBHEIG, T[] JOCJCIJGIJF, int KMCJMFPOINP, [Optional] T LLKNEEMEIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1F59DC0", Offset = "0x1F583C0", VA = "0x181F59DC0")]
	private static void AAICLLGNCBN<T>(int NEIGECBHEIG, NativeArray<T> JOCJCIJGIJF, int KMCJMFPOINP, [Optional] T LLKNEEMEIBK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4899430", Offset = "0x4897A30", VA = "0x184899430")]
	private void MMENOOKKJEM(IEnumerable<BAMDABNCLMJ> LDPMGDIHLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x4899280", Offset = "0x4897880", VA = "0x184899280")]
	private void IEICOIMFDJL(BAMDABNCLMJ OFHLMNKJJBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x4898AE0", Offset = "0x48970E0", VA = "0x184898AE0")]
	private EHCLIKMKBLL FDEICFBGKDK(int PBGMJOPMLAG)
	{
		return default(EHCLIKMKBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x4898F00", Offset = "0x4897500", VA = "0x184898F00")]
	public void HNLLCJPGONE(float LKPEHAOLPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x4898A60", Offset = "0x4897060", VA = "0x184898A60")]
	private void EKBGHDHFLGF(Action NCGEKBENJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x4898DA0", Offset = "0x48973A0", VA = "0x184898DA0")]
	private void HBFJIJLHEDN(Action NCGEKBENJBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x48996D0", Offset = "0x4897CD0", VA = "0x1848996D0")]
	public void OKDJPGBEIAM(float LKPEHAOLPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x4898E20", Offset = "0x4897420", VA = "0x184898E20")]
	public void HLHLNLIFMIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x48981B0", Offset = "0x48967B0", VA = "0x1848981B0")]
	public void DDPMPAFGPGL(APFFGEMFCPH ODBMGGBCNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4899340", Offset = "0x4897940", VA = "0x184899340")]
	public void KBOJIKDOCLA(APFFGEMFCPH ODBMGGBCNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x48980F0", Offset = "0x48966F0", VA = "0x1848980F0")]
	public void BNKDLMJONGC(APFFGEMFCPH ODBMGGBCNLA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public class OEOKMOCBJHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public static readonly OEOKMOCBJHA PGNEIIMMCHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly Action KAMGPGJJLAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private bool PGGNJMMOIKA;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x69EFB0", Offset = "0x69D5B0", VA = "0x18069EFB0")]
	public OEOKMOCBJHA(Action KAMGPGJJLAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x48A64B0", Offset = "0x48A4AB0", VA = "0x1848A64B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public interface NHLJPJJHDMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	T NLLJAAOBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable PMBHNGPHPJL(UnityEngine.Object GCLGODGIPBD, Action<T> EEKLANBKNGM);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public interface PHJDBCNFKOD<T> : global::NHLJPJJHDMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	new T NLLJAAOBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class KKBBGOFDFGI<T> : global::PHJDBCNFKOD<T>, global::NHLJPJJHDMF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[CompilerGenerated]
	private sealed class JOOKBNDDDEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public global::KKBBGOFDFGI<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public global::JHJGCPBBALP<UnityEngine.Object, Action<T>> tup;

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x1C61870", Offset = "0x1C5FE70", VA = "0x181C61870")]
		public JOOKBNDDDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x3F99CF0", Offset = "0x3F982F0", VA = "0x183F99CF0")]
		internal void <Observe>b__0()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static GameObject PBNFEGKDBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly List<global::JHJGCPBBALP<UnityEngine.Object, Action<T>>> DKMNOEDBBMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private T NMJMGACLPIA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public T NLLJAAOBNLN
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x687F70", Offset = "0x686570", VA = "0x180687F70", Slot = "5")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3FA4810", Offset = "0x3FA2E10", VA = "0x183FA4810", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3FA48F0", Offset = "0x3FA2EF0", VA = "0x183FA48F0")]
	private static bool CFELAHANAGE(T NCGEKBENJBA, T IIFMPDAMAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3FA4CE0", Offset = "0x3FA32E0", VA = "0x183FA4CE0")]
	public KKBBGOFDFGI(T AFMKJJPGFNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3FA4980", Offset = "0x3FA2F80", VA = "0x183FA4980", Slot = "6")]
	public IDisposable PMBHNGPHPJL(UnityEngine.Object GCLGODGIPBD, Action<T> EEKLANBKNGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3FA44F0", Offset = "0x3FA2AF0", VA = "0x183FA44F0")]
	private void AGCMGACANPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
[BurstCompile]
internal struct BBGNCENKCOH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	[ReadOnly]
	public float DFDLHLMCONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	[ReadOnly]
	public int HOFNDILMMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<int> NCGEHEEAFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<int> AKBEICPBCLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<int> MMDENOJAIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	[ReadOnly]
	public NativeArray<OHOEGKIJDMN> KPCGPCGGMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	[ReadOnly]
	public NativeArray<float> KNAPLEELLHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[WriteOnly]
	public NativeArray<int> LOGJPCJAELO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[WriteOnly]
	public NativeArray<int> NMOBBOAFNLK;

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x4897780", Offset = "0x4895D80", VA = "0x184897780")]
	public static BBGNCENKCOH GPCBEJLMGEM(int PIMIEIEAMCB, float LKPEHAOLPBI, NativeArray<OHOEGKIJDMN> KPJHBDIFDJE, NativeArray<float> BDNNFFIBIHH, NativeArray<int> FBHHMNDGBJP, NativeArray<int> OEACNMOAEJE, NativeArray<int> KOCFKFNDGAB, NativeArray<int> AKBEICPBCLE, NativeArray<int> MMDENOJAIDO)
	{
		return default(BBGNCENKCOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x48976A0", Offset = "0x4895CA0", VA = "0x1848976A0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x48975C0", Offset = "0x4895BC0", VA = "0x1848975C0")]
	private bool AHPCAJEHJID(int HOOANEAGKNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x4897670", Offset = "0x4895C70", VA = "0x184897670")]
	private void EPPFPDEMNMB(NativeArray<int> IJGPJNHNECL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x4897600", Offset = "0x4895C00", VA = "0x184897600")]
	private int ELHAMLBPMFJ(int AHNAAOBDIIK, int BCNEDINGPCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x4897A80", Offset = "0x4896080", VA = "0x184897A80")]
	private void LBFFDDIGMFL(NativeArray<int> IJGPJNHNECL, int JAMCMBENHJM, int LNGICMIIKHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x4897850", Offset = "0x4895E50", VA = "0x184897850")]
	private void JCMNJEGKNDF(NativeArray<int> IJGPJNHNECL, int AAMBAEJBMJP, int IGPPGIPJEPJ, int AABLIKACKPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public class MBHNFDOCNFI : ILGMKJBPMCG, NIECEGPGMIC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private BHNDAPMCHIM[] NFCJEDCKBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private HCMGAPMENDA MNDNKGFMDBL;

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x48A5080", Offset = "0x48A3680", VA = "0x1848A5080")]
	[MBNOPHMLNBM]
	private static void JONMGHBDFJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x48A5410", Offset = "0x48A3A10", VA = "0x1848A5410")]
	[Preserve]
	public MBHNFDOCNFI([IOLMGJIHJFK(null)] GOIPPPJLIMK ACDFMFDNLOA, [IOLMGJIHJFK(null)] BMCLGOCGNKP BOIANAJLMPJ, [IOLMGJIHJFK(null)] PLDCHBHOJKC GJANGJNFOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x48A4E30", Offset = "0x48A3430", VA = "0x1848A4E30", Slot = "12")]
	public override JPGLPKCHKEM JDOLIDLBHOO(OILEMCJJFLI GCLGODGIPBD, IEnumerator<MCOOOHEMEPE> HADPKCKFELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x48A5150", Offset = "0x48A3750", VA = "0x1848A5150", Slot = "13")]
	public override void NFEMDFDACGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x48A4B10", Offset = "0x48A3110", VA = "0x1848A4B10", Slot = "15")]
	public override void IDABLPJMKJJ(NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x48A4CE0", Offset = "0x48A32E0", VA = "0x1848A4CE0", Slot = "14")]
	protected override void IFFNNMKLCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x48A4AD0", Offset = "0x48A30D0", VA = "0x1848A4AD0")]
	private BHNDAPMCHIM HIGHFMHJGIO(NLKBGIPIPAN.OLLNHPNJKPB ONIHNDBDHGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x48A4A20", Offset = "0x48A3020", VA = "0x1848A4A20", Slot = "16")]
	internal override GPDEKMAFDNH GJPCOECNAOH(IEnumerator<MCOOOHEMEPE> HADPKCKFELJ, Behaviour GCLGODGIPBD, JAACHPBFEIB PNEBNJNAOIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x48A4DC0", Offset = "0x48A33C0", VA = "0x1848A4DC0", Slot = "17")]
	internal override JHGADFFLELD IFMLDNHLKMH(NLKBGIPIPAN.OLLNHPNJKPB KDFMIEPKJEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x48A4F60", Offset = "0x48A3560", VA = "0x1848A4F60")]
	private void JHFFPDDLDCJ(BHNDAPMCHIM GNEBKNDOIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x48A49B0", Offset = "0x48A2FB0", VA = "0x1848A49B0", Slot = "18")]
	public override void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public abstract class ILGMKJBPMCG : NIECEGPGMIC, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly GOIPPPJLIMK ACDFMFDNLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	protected readonly BMCLGOCGNKP BOIANAJLMPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly PLDCHBHOJKC GJANGJNFOJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private JHGADFFLELD[] CNFBEMOAPDG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public static NIECEGPGMIC NNHENCBEIJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x48A1B50", Offset = "0x48A0150", VA = "0x1848A1B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static bool KGCMJKPIFNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x560FE0", Offset = "0x55F5E0", VA = "0x180560FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public NLKBGIPIPAN.OLLNHPNJKPB LBKNCBDOAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x560ED0", Offset = "0x55F4D0", VA = "0x180560ED0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(NLKBGIPIPAN.OLLNHPNJKPB);
		}
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x560EE0", Offset = "0x55F4E0", VA = "0x180560EE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public BMCLGOCGNKP EDLAIOGHJEM
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x562DF0", Offset = "0x5613F0", VA = "0x180562DF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x48A14E0", Offset = "0x489FAE0", VA = "0x1848A14E0")]
	public static JPGLPKCHKEM MKOCNFHHLPN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x48A1C10", Offset = "0x48A0210", VA = "0x1848A1C10")]
	[Preserve]
	protected ILGMKJBPMCG([IOLMGJIHJFK(null)] GOIPPPJLIMK ACDFMFDNLOA, [IOLMGJIHJFK(null)] BMCLGOCGNKP BOIANAJLMPJ, [IOLMGJIHJFK(null)] PLDCHBHOJKC GJANGJNFOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x48A1980", Offset = "0x489FF80", VA = "0x1848A1980", Slot = "6")]
	public JPGLPKCHKEM OBHHENOOAOJ(IEnumerator<MCOOOHEMEPE> HADPKCKFELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x48A1760", Offset = "0x489FD60", VA = "0x1848A1760", Slot = "7")]
	public JPGLPKCHKEM OBHHENOOAOJ(Behaviour GCLGODGIPBD, IEnumerator<MCOOOHEMEPE> HADPKCKFELJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract JPGLPKCHKEM JDOLIDLBHOO(OILEMCJJFLI GCLGODGIPBD, IEnumerator<MCOOOHEMEPE> HADPKCKFELJ);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x48A1580", Offset = "0x489FB80", VA = "0x1848A1580", Slot = "13")]
	public virtual void NFEMDFDACGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x48A1480", Offset = "0x489FA80", VA = "0x1848A1480", Slot = "9")]
	public void MCNKEPPEMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x48A1440", Offset = "0x489FA40", VA = "0x1848A1440", Slot = "14")]
	protected virtual void IFFNNMKLCCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x48A0F10", Offset = "0x489F510", VA = "0x1848A0F10")]
	private void CBGLDJLNBCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x48A11F0", Offset = "0x489F7F0", VA = "0x1848A11F0")]
	private void GHPCNJCPJPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x48A11D0", Offset = "0x489F7D0", VA = "0x1848A11D0")]
	private void GFBMFMEHLCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x48A11B0", Offset = "0x489F7B0", VA = "0x1848A11B0")]
	private void FALPMDMPBEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x48A1460", Offset = "0x489FA60", VA = "0x1848A1460")]
	private void LEFFLNGMKEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x48A0EF0", Offset = "0x489F4F0", VA = "0x1848A0EF0")]
	private void AKKNPOANOBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x48A1210", Offset = "0x489F810", VA = "0x1848A1210", Slot = "15")]
	public virtual void IDABLPJMKJJ(NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x48A1990", Offset = "0x489FF90", VA = "0x1848A1990")]
	private void OIEOKEIGOFN(JHGADFFLELD GNEBKNDOIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7AA610", Offset = "0x7A8C10", VA = "0x1807AA610")]
	private JHGADFFLELD HHBBPNMMAPA(NLKBGIPIPAN.OLLNHPNJKPB ONIHNDBDHGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	internal abstract GPDEKMAFDNH GJPCOECNAOH(IEnumerator<MCOOOHEMEPE> HADPKCKFELJ, Behaviour KGOEDNFCCJL, JAACHPBFEIB JAFHJOLBJHJ);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	internal abstract JHGADFFLELD IFMLDNHLKMH(NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM);

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x48A0F30", Offset = "0x489F530", VA = "0x1848A0F30", Slot = "18")]
	public virtual void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
internal sealed class GPDEKMAFDNH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly JAACHPBFEIB PNEBNJNAOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly DKGCPKCNHBB GCLGODGIPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly bool AMBCDHIOBIK;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerator<MCOOOHEMEPE> CBHLKPFHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x5601D0", Offset = "0x55E7D0", VA = "0x1805601D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x560490", Offset = "0x55EA90", VA = "0x180560490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public MCOOOHEMEPE HFKBLOKNELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x5601C0", Offset = "0x55E7C0", VA = "0x1805601C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x5604A0", Offset = "0x55EAA0", VA = "0x1805604A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public bool JJFFGOJHKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x489F8E0", Offset = "0x489DEE0", VA = "0x18489F8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public bool AMODDOAFPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x7C8D30", Offset = "0x7C7330", VA = "0x1807C8D30")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x23C4E50", Offset = "0x23C3450", VA = "0x1823C4E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public string KKHBICLGHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x561010", Offset = "0x55F610", VA = "0x180561010")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x561020", Offset = "0x55F620", VA = "0x180561020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public float LOOGHHFLDIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xFE3030", Offset = "0xFE1630", VA = "0x180FE3030")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x10C7C10", Offset = "0x10C6210", VA = "0x1810C7C10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x489FD60", Offset = "0x489E360", VA = "0x18489FD60")]
	public GPDEKMAFDNH(IEnumerator<MCOOOHEMEPE> GBLEGCCOFFF, DKGCPKCNHBB GCLGODGIPBD, JAACHPBFEIB PNEBNJNAOIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x489F9F0", Offset = "0x489DFF0", VA = "0x18489F9F0")]
	public MCOOOHEMEPE DPHLNEHOLLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x489FC60", Offset = "0x489E260", VA = "0x18489FC60")]
	public bool PCBFDCEMJOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x489F960", Offset = "0x489DF60", VA = "0x18489F960")]
	public void DDPMPAFGPGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x489FCD0", Offset = "0x489E2D0", VA = "0x18489FCD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x12F5280", Offset = "0x12F3880", VA = "0x1812F5280")]
	[CompilerGenerated]
	private void FHHBIOOCPGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
internal sealed class JAACHPBFEIB : NDAHIPBIKFG, JPGLPKCHKEM, JIGNBICHMOJ, APPFHLGLKJA, IEnumerator, MCOOOHEMEPE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private NLKBGIPIPAN.OLLNHPNJKPB HJECNDPFDPD;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private NLKBGIPIPAN.OLLNHPNJKPB EDMBCFBBAGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x585180", Offset = "0x583780", VA = "0x180585180", Slot = "23")]
		get
		{
			return default(NLKBGIPIPAN.OLLNHPNJKPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public NLKBGIPIPAN.OLLNHPNJKPB EAMDMGBEDAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x704E20", Offset = "0x703420", VA = "0x180704E20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private float CPMGEBKEBLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0xDB6200", Offset = "0xDB4800", VA = "0x180DB6200", Slot = "25")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x48A2090", Offset = "0x48A0690", VA = "0x1848A2090", Slot = "24")]
	private bool AKABCEBLLID()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x48A20B0", Offset = "0x48A06B0", VA = "0x1848A20B0", Slot = "26")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x48A20C0", Offset = "0x48A06C0", VA = "0x1848A20C0")]
	public JAACHPBFEIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
internal enum EHCLIKMKBLL : byte
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
internal sealed class JHGADFFLELD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public enum OEAOCKADLEC
	{
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		Immediate,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		Future
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public struct BLMBKHJDLDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public NLKBGIPIPAN.OLLNHPNJKPB AFKNALDOKKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public OEAOCKADLEC FDLOKCODOCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public List<GPDEKMAFDNH> AIJKNDEOOLO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static readonly OEAOCKADLEC[] HPFBKDCBIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly NLKBGIPIPAN.OLLNHPNJKPB FBJDGFPPDCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private bool DGEJDKIAJEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly GPDEKMAFDNH[] PHPNBLOGEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly List<GPDEKMAFDNH> BIMBLDEHNFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private readonly Stack<int> NLPPJPEDIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly List<GPDEKMAFDNH> PMDHJEGGCAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private readonly Stack<int> KDELFDPKAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly HCMGAPMENDA CFMLCPFIIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private bool NMGGJHAEIOL;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public BLMBKHJDLDK[,] HHEJIIIMDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5B3130", Offset = "0x5B1730", VA = "0x1805B3130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x48A3510", Offset = "0x48A1B10", VA = "0x1848A3510")]
	public JHGADFFLELD(NLKBGIPIPAN.OLLNHPNJKPB KDFMIEPKJEM, HCMGAPMENDA CFMLCPFIIOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x48A2E70", Offset = "0x48A1470", VA = "0x1848A2E70")]
	public void KNDBBELMCNK(GPDEKMAFDNH GBLEGCCOFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x48A25F0", Offset = "0x48A0BF0", VA = "0x1848A25F0")]
	public void DBIOECKOMLF(IList<GPDEKMAFDNH> HPMEHBJLMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x48A2BF0", Offset = "0x48A11F0", VA = "0x1848A2BF0")]
	public void JFEKBDBIBDP(IList<GPDEKMAFDNH> HPMEHBJLMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x48A29B0", Offset = "0x48A0FB0", VA = "0x1848A29B0")]
	private void EPANIBDMIED(GPDEKMAFDNH GBLEGCCOFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x48A2480", Offset = "0x48A0A80", VA = "0x1848A2480")]
	private void CJCAJNEELKB(IList<GPDEKMAFDNH> HPMEHBJLMIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x48A32B0", Offset = "0x48A18B0", VA = "0x1848A32B0")]
	private EHCLIKMKBLL PLDDLIHMFMN(GPDEKMAFDNH GBLEGCCOFFF)
	{
		return default(EHCLIKMKBLL);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x48A2AA0", Offset = "0x48A10A0", VA = "0x1848A2AA0")]
	public void IFFNNMKLCCI(float LKPEHAOLPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x48A2F90", Offset = "0x48A1590", VA = "0x1848A2F90")]
	public void MCNKEPPEMHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x48A22A0", Offset = "0x48A08A0", VA = "0x1848A22A0")]
	private void BOJBKCDFLCF(List<GPDEKMAFDNH> HPMEHBJLMIN, Stack<int> GLLLGCMCPBB, bool IAMBLHNAONH, float LHIFMPHJFIN = -1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x48A2870", Offset = "0x48A0E70", VA = "0x1848A2870", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x48A3190", Offset = "0x48A1790", VA = "0x1848A3190")]
	private void MKLAHKJHLEI(List<GPDEKMAFDNH> HPMEHBJLMIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
internal class EKGCHFCMNJB : HCMGAPMENDA
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "4")]
	public void BBLHCHOPGJG(string MONHCMBIJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x560E80", Offset = "0x55F480", VA = "0x180560E80", Slot = "5")]
	public void EINHKCCCDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x562AB0", Offset = "0x5610B0", VA = "0x180562AB0")]
	public EKGCHFCMNJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
internal class CIPKLAAJAFG : DKGCPKCNHBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Behaviour KGOEDNFCCJL;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public string KKHBICLGHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x489A0F0", Offset = "0x48986F0", VA = "0x18489A0F0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool ELPPJMJNBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x489A180", Offset = "0x4898780", VA = "0x18489A180", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool AHDPOHKLKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x489A0D0", Offset = "0x48986D0", VA = "0x18489A0D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x69EFB0", Offset = "0x69D5B0", VA = "0x18069EFB0")]
	public CIPKLAAJAFG(Behaviour KGOEDNFCCJL)
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
