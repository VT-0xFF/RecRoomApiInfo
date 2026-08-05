using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EGONGPAFGMC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FNBHECJIIFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Camera OHKLKOGIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	HFMPGNIBJKD AOBFMICCAII
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IDNLGCKKAFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HFMPGNIBJKD IGHLCLNGCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Transform HOFBALHDOLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LLMOJONNGLL
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class DBKMJIMHOHE<T> : KDJLKHBIEGI, CFLCBPDNHOF<T>, MCBHBLDEFKB where T : class, JLGODPLKKFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x29921D0", Offset = "0x29913D0", VA = "0x1829921D0")]
			internal DBKMJIMHOHE(int FPIFAJLCMHH, float[] GDDPIMEFCDI, EFICKGKLMGC PDCCGAECPKG = EFICKGKLMGC.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2992180", Offset = "0x2991380", VA = "0x182992180", Slot = "10")]
			public void CKPKOIJGHLD(T PPNJOAJJOFF, float ADBNNNLLGEN, EIEHKGHKNNG BADNIJEHLFA = EIEHKGHKNNG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2992150", Offset = "0x2991350", VA = "0x182992150", Slot = "11")]
			public void CKPKOIJGHLD(T PPNJOAJJOFF, Transform HKHCELMDEHM, float ADBNNNLLGEN, EIEHKGHKNNG BADNIJEHLFA = EIEHKGHKNNG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x29921B0", Offset = "0x29913B0", VA = "0x1829921B0", Slot = "12")]
			public void HCICIMHFKFM(T FNOBHEODGJP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class KDJLKHBIEGI : IDisposable, MCBHBLDEFKB
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public enum EFICKGKLMGC : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private class GKJJMCOEPHK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public JLGODPLKKFG GCHLLMNMNPD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public EIEHKGHKNNG ICGCBNBEKFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action IDDJLOLGHCA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool IGOHMLBHJGG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int BBOMBIMAMPK;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
				public GKJJMCOEPHK()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[CompilerGenerated]
			private sealed class MNHKCAPJHGO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public KDJLKHBIEGI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public GKJJMCOEPHK trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
				public MNHKCAPJHGO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x6F04400", Offset = "0x6F03600", VA = "0x186F04400")]
				internal void KEBPIAONLNC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int IMJFLGKBPJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int FPIFAJLCMHH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BAHCKHJIKGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool IFCDFOBKGCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup PFKOHCEDHGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] DJFNGLNJMEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] BBHAKGANPDF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly EGONGPAFGMC LJKHADFBIKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<JLGODPLKKFG, int> IGODIPMOKGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, GKJJMCOEPHK> FLHJCHCFJCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly EFICKGKLMGC PDCCGAECPKG;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool KGJFMDHFCCL
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x1C48FD0", Offset = "0x1C481D0", VA = "0x181C48FD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x1C48FE0", Offset = "0x1C481E0", VA = "0x181C48FE0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F04030", Offset = "0x6F03230", VA = "0x186F04030")]
			internal KDJLKHBIEGI(int FPIFAJLCMHH, float[] GDDPIMEFCDI, EFICKGKLMGC PDCCGAECPKG = EFICKGKLMGC.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F03F90", Offset = "0x6F03190", VA = "0x186F03F90")]
			public void OFFOPBBHBFA(bool EDMIOIOHODA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F02780", Offset = "0x6F01980", VA = "0x186F02780", Slot = "6")]
			public void CKPKOIJGHLD(JLGODPLKKFG PPNJOAJJOFF, float ADBNNNLLGEN, EIEHKGHKNNG BADNIJEHLFA = EIEHKGHKNNG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F02310", Offset = "0x6F01510", VA = "0x186F02310", Slot = "9")]
			public void CKPKOIJGHLD(JLGODPLKKFG PPNJOAJJOFF, Transform HKHCELMDEHM, float ADBNNNLLGEN, EIEHKGHKNNG BADNIJEHLFA = EIEHKGHKNNG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F034D0", Offset = "0x6F026D0", VA = "0x186F034D0")]
			public void JKICHDDHKFP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F02AD0", Offset = "0x6F01CD0", VA = "0x186F02AD0")]
			private void GPPHAOMHLDP(int NNAODBDJDNJ, [Optional] float? ADBNNNLLGEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F02C40", Offset = "0x6F01E40", VA = "0x186F02C40", Slot = "7")]
			public void HCICIMHFKFM(JLGODPLKKFG FNOBHEODGJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F033E0", Offset = "0x6F025E0", VA = "0x186F033E0", Slot = "8")]
			public void HOFEEIOKFMC(JLGODPLKKFG PPNJOAJJOFF, EIEHKGHKNNG HJMGBBKGMCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F02810", Offset = "0x6F01A10", VA = "0x186F02810", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F03070", Offset = "0x6F02270", VA = "0x186F03070")]
			private void HHAMLKFKKHH(GKJJMCOEPHK OACEDOPFPIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F03650", Offset = "0x6F02850", VA = "0x186F03650")]
			private void JOBMLLKNJPC(GKJJMCOEPHK OACEDOPFPIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F03F20", Offset = "0x6F03120", VA = "0x186F03F20")]
			private void OCPNENJOJFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F03FC0", Offset = "0x6F031C0", VA = "0x186F03FC0")]
			private void OGNBFDLPOIF(float JEBAFBJDHNC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F03A60", Offset = "0x6F02C60", VA = "0x186F03A60")]
			private void MNGOKLDJGPP(GKJJMCOEPHK OACEDOPFPIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F02AC0", Offset = "0x6F01CC0", VA = "0x186F02AC0")]
			private void EKHLODHMPCA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F02C30", Offset = "0x6F01E30", VA = "0x186F02C30")]
			private void HAEHEOLLADD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F03BE0", Offset = "0x6F02DE0", VA = "0x186F03BE0")]
			private void NIGMNCJGCFA(CullingGroupEvent ELNOILOKFJD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F038E0", Offset = "0x6F02AE0", VA = "0x186F038E0")]
			private void KKIPDPPOLNL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private struct HNOBMMCCKEI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort JAHFOKBGEPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type LFCEFCABPBC;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float JDPNGEGMCPJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float MFGDNDOILJJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float BAMCHFFILDD = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float LMDGCOJJDFP = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BDDNFDPOMOO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float NIJMIFIPPFE = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GAIDGPDBFBP = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<HNOBMMCCKEI, KDJLKHBIEGI> JNJHMKGGLJA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PIJBHLPEMDN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable IJNHIJDHIHB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static HFMPGNIBJKD MGADPGLHFGN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static HFMPGNIBJKD OEJOHAODNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly HFMPGNIBJKD MJNPJGJDEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HFMPGNIBJKD EHIIHBGHACH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HFMPGNIBJKD MJKMCGOAPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NHIOCEAPLGE OOIFJDCCLDB;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool EDMIOIOHODA;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public HFMPGNIBJKD ECJMPLHBEBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public HFMPGNIBJKD CMIKMDCLHOF
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7EBAE0", Offset = "0x7EACE0", VA = "0x1807EBAE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public HFMPGNIBJKD INBPLHCJCNK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LBOKBNIOFJL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x11215F0", Offset = "0x11207F0", VA = "0x1811215F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OIEAALJCNHP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x929880", Offset = "0x928A80", VA = "0x180929880", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9298C0", Offset = "0x928AC0", VA = "0x1809298C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F01140", Offset = "0x6F00340", VA = "0x186F01140", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1A27330", Offset = "0x1A26530", VA = "0x181A27330")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F01BB0", Offset = "0x6F00DB0", VA = "0x186F01BB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F01550", Offset = "0x6F00750", VA = "0x186F01550")]
		private void FGJEHHIIJII(Scene IBENPLAEBFE, LoadSceneMode KEDBGMBBPLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F01AD0", Offset = "0x6F00CD0", VA = "0x186F01AD0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F01E00", Offset = "0x6F01000", VA = "0x186F01E00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F013B0", Offset = "0x6F005B0", VA = "0x186F013B0")]
		private void EEANDKAEIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F01BD0", Offset = "0x6F00DD0", VA = "0x186F01BD0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F01930", Offset = "0x6F00B30", VA = "0x186F01930")]
		private void MPMFLADLAOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F01740", Offset = "0x6F00940", VA = "0x186F01740")]
		public MCBHBLDEFKB GetOrCreateCullingGroup(Type PNNCBDKBABN, int EJMCPCNIONL, ushort PMMGLNGAOOG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1CC4D20", Offset = "0x1CC3F20", VA = "0x181CC4D20")]
		public CFLCBPDNHOF<T> GetOrCreateCullingGroup<T>(int EJMCPCNIONL, ushort PMMGLNGAOOG = 0) where T : class, JLGODPLKKFG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F01210", Offset = "0x6F00410", VA = "0x186F01210")]
		private MCBHBLDEFKB CKHIJIFLLNK(Type PNNCBDKBABN, int EJMCPCNIONL, float[] GDDPIMEFCDI, ushort PMMGLNGAOOG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1CC4AF0", Offset = "0x1CC3CF0", VA = "0x181CC4AF0")]
		private CFLCBPDNHOF<T> CKHIJIFLLNK<T>(int EJMCPCNIONL, float[] GDDPIMEFCDI, ushort PMMGLNGAOOG = 0) where T : class, JLGODPLKKFG
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F015B0", Offset = "0x6F007B0", VA = "0x186F015B0")]
		public static LOHCJBKKAAK FindClosestDefaultUpdateLod(float ECKEMBBNGEA)
		{
			return default(LOHCJBKKAAK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F01AC0", Offset = "0x6F00CC0", VA = "0x186F01AC0")]
		public static LOHCJBKKAAK MinUpdateLod(LOHCJBKKAAK AHDHOJOJBFP, LOHCJBKKAAK JDLOKANCHJI)
		{
			return default(LOHCJBKKAAK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F01AB0", Offset = "0x6F00CB0", VA = "0x186F01AB0")]
		public static LOHCJBKKAAK MaxUpdateLod(LOHCJBKKAAK AHDHOJOJBFP, LOHCJBKKAAK JDLOKANCHJI)
		{
			return default(LOHCJBKKAAK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F02230", Offset = "0x6F01430", VA = "0x186F02230")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum LOHCJBKKAAK
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface JLGODPLKKFG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform LNNHFELGMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(LOHCJBKKAAK JIDECECIIFE, LOHCJBKKAAK EBJPGOJMKLG);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool CPOAPAFNIPD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MCBHBLDEFKB
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KGJFMDHFCCL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKPKOIJGHLD(JLGODPLKKFG PPNJOAJJOFF, float ADBNNNLLGEN, EIEHKGHKNNG BADNIJEHLFA = EIEHKGHKNNG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCICIMHFKFM(JLGODPLKKFG FNOBHEODGJP);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HOFEEIOKFMC(JLGODPLKKFG PPNJOAJJOFF, EIEHKGHKNNG NIEIBGHBLIE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CFLCBPDNHOF<T> : MCBHBLDEFKB where T : class, JLGODPLKKFG
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKPKOIJGHLD(T PPNJOAJJOFF, float ADBNNNLLGEN, EIEHKGHKNNG BADNIJEHLFA = EIEHKGHKNNG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKPKOIJGHLD(T PPNJOAJJOFF, Transform HKHCELMDEHM, float ADBNNNLLGEN, EIEHKGHKNNG BADNIJEHLFA = EIEHKGHKNNG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HCICIMHFKFM(T FNOBHEODGJP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum EIEHKGHKNNG : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Full
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
