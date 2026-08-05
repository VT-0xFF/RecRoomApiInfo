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
public interface JJENGCAKDJI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FJFOLCABKMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Camera CDKFLHIBGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	LNCHJMFHBFC AHMFBDEIELM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BCNAGHCJMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	LNCHJMFHBFC GMNIFHJHBCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Transform BNMCCGGCCLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PBDLKNFALDI
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class FCOKNKDKOOK<T> : PEJBGJLCLMK, DIBNKOMPBME<T>, LDKPPGCLIKN where T : class, CAJOJINPBPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1940F90", Offset = "0x1940390", VA = "0x181940F90")]
			internal FCOKNKDKOOK(int JPHNMFCOOBF, float[] KBKPKFFAFBM, IEGFIMMDCNO JLBDKDCHPOB = IEGFIMMDCNO.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1940F10", Offset = "0x1940310", VA = "0x181940F10", Slot = "10")]
			public void EBOHBLNDMAL(T ICNDEPGFBMI, float IPHDKMMKPIL, IKCLPGCCHEM ENGMPOKGFGL = IKCLPGCCHEM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1940F40", Offset = "0x1940340", VA = "0x181940F40", Slot = "11")]
			public void EBOHBLNDMAL(T ICNDEPGFBMI, Transform GACMCFFBMNN, float IPHDKMMKPIL, IKCLPGCCHEM ENGMPOKGFGL = IKCLPGCCHEM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1940F70", Offset = "0x1940370", VA = "0x181940F70", Slot = "12")]
			public void PBDAKCGNFND(T IIKDBGMAHHI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class PEJBGJLCLMK : IDisposable, LDKPPGCLIKN
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public enum IEGFIMMDCNO : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private class BHLBENGBBDJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public CAJOJINPBPL BHABMIFKNBP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public IKCLPGCCHEM CBEDCOJNMCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action GIMFGIKJINA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool JELHKMODLKD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int BJNMAHEDMNC;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
				public BHLBENGBBDJ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[CompilerGenerated]
			private sealed class CLNCLNGHIHB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public PEJBGJLCLMK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public BHLBENGBBDJ trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
				public CLNCLNGHIHB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x6F2D7A0", Offset = "0x6F2CBA0", VA = "0x186F2D7A0")]
				internal void GPHOELPIDII()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int LILACEFDPOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int JPHNMFCOOBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int CEHBMIJFLHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool NEOLAOAJOPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup BGPECPMMKKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] HGBIKKCGGAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] PDDLCKIMPIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly JJENGCAKDJI LEGFAAONKIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<CAJOJINPBPL, int> EKFFJNEAOBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, BHLBENGBBDJ> LGEBNODLKIC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly IEGFIMMDCNO JLBDKDCHPOB;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool BPCFFGKCPLA
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x1F616B0", Offset = "0x1F60AB0", VA = "0x181F616B0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x1F616A0", Offset = "0x1F60AA0", VA = "0x181F616A0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6F30820", Offset = "0x6F2FC20", VA = "0x186F30820")]
			internal PEJBGJLCLMK(int JPHNMFCOOBF, float[] KBKPKFFAFBM, IEGFIMMDCNO JLBDKDCHPOB = IEGFIMMDCNO.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6F2F600", Offset = "0x6F2EA00", VA = "0x186F2F600")]
			public void FEKDKMBKAIG(bool IFJPDKPEEHJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6F2F100", Offset = "0x6F2E500", VA = "0x186F2F100", Slot = "6")]
			public void EBOHBLNDMAL(CAJOJINPBPL ICNDEPGFBMI, float IPHDKMMKPIL, IKCLPGCCHEM ENGMPOKGFGL = IKCLPGCCHEM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6F2F190", Offset = "0x6F2E590", VA = "0x186F2F190", Slot = "9")]
			public void EBOHBLNDMAL(CAJOJINPBPL ICNDEPGFBMI, Transform GACMCFFBMNN, float IPHDKMMKPIL, IKCLPGCCHEM ENGMPOKGFGL = IKCLPGCCHEM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6F2FFE0", Offset = "0x6F2F3E0", VA = "0x186F2FFE0")]
			public void MLAPMEEOGDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6F2ECF0", Offset = "0x6F2E0F0", VA = "0x186F2ECF0")]
			private void CMPAAGFNAHK(int NANJAGEOPJI, [Optional] float? IPHDKMMKPIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6F30160", Offset = "0x6F2F560", VA = "0x186F30160", Slot = "7")]
			public void PBDAKCGNFND(CAJOJINPBPL IIKDBGMAHHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6F2FB80", Offset = "0x6F2EF80", VA = "0x186F2FB80", Slot = "8")]
			public void JGIDNOCJALG(CAJOJINPBPL ICNDEPGFBMI, IKCLPGCCHEM MHKIALAHBDA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6F2EE50", Offset = "0x6F2E250", VA = "0x186F2EE50", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6F2FC70", Offset = "0x6F2F070", VA = "0x186F2FC70")]
			private void LLEEEDLFHAE(BHLBENGBBDJ HIGELGPGMAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6F30590", Offset = "0x6F2F990", VA = "0x186F30590")]
			private void PMCPPMDGGCJ(BHLBENGBBDJ HIGELGPGMAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6F2EB00", Offset = "0x6F2DF00", VA = "0x186F2EB00")]
			private void AHAAEOPIION()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6F2F7C0", Offset = "0x6F2EBC0", VA = "0x186F2F7C0")]
			private void GHMMKAJBPFG(float DOCNBLMOCCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6F2EB70", Offset = "0x6F2DF70", VA = "0x186F2EB70")]
			private void BPELBKLMPII(BHLBENGBBDJ HIGELGPGMAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6F2F7B0", Offset = "0x6F2EBB0", VA = "0x186F2F7B0")]
			private void FMKECLIIKOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F2FB70", Offset = "0x6F2EF70", VA = "0x186F2FB70")]
			private void IMIPFEILPIL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F2F830", Offset = "0x6F2EC30", VA = "0x186F2F830")]
			private void HIOBGMNODBN(CullingGroupEvent LBALAEMKFPP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6F2F630", Offset = "0x6F2EA30", VA = "0x186F2F630")]
			private void FKAPEFLGNJD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private struct DGICGDKNPCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort BHJEOHLKBLI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type PDKPCPBCHKC;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float OIKLOJOFNAJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float CMNMKMODFDL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float IFHOOAMPDBE = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GIDMBMHHELB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FFLIFMCNEGJ = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GFDACOPIJAC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float KEDFANDNIKL = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<DGICGDKNPCI, PEJBGJLCLMK> MFNOKECMPID;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable COIGNEAMAIN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LKLPEHCGLDO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static LNCHJMFHBFC LIFEBBGHAJG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static LNCHJMFHBFC MPAJJCPEHEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly LNCHJMFHBFC GMGANNIKJCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LNCHJMFHBFC CJMJHDGKCLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LNCHJMFHBFC BABEPEAEGCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private ODDHCGCOHBO CKNECILLIGF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool IFJPDKPEEHJ;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LNCHJMFHBFC MAALHDFCBDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LNCHJMFHBFC GEHMGACOGAN
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7E8120", Offset = "0x7E7520", VA = "0x1807E8120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LNCHJMFHBFC ONDCJOPEJNP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool AFHLCFJBLLE
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x1206B20", Offset = "0x1205F20", VA = "0x181206B20", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LGNOIFLOOLG
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x8FD060", Offset = "0x8FC460", VA = "0x1808FD060", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x8FD5F0", Offset = "0x8FC9F0", VA = "0x1808FD5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D930", Offset = "0x6F2CD30", VA = "0x186F2D930", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x19DDA80", Offset = "0x19DCE80", VA = "0x1819DDA80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E3A0", Offset = "0x6F2D7A0", VA = "0x186F2E3A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E240", Offset = "0x6F2D640", VA = "0x186F2E240")]
		private void MMIIJHDLPKN(Scene EOOPPEEEACO, LoadSceneMode MMGKIPGKNHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E2C0", Offset = "0x6F2D6C0", VA = "0x186F2E2C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E5F0", Offset = "0x6F2D9F0", VA = "0x186F2E5F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DB80", Offset = "0x6F2CF80", VA = "0x186F2DB80")]
		private void EDMDJAMEDOF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E3C0", Offset = "0x6F2D7C0", VA = "0x186F2E3C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DA00", Offset = "0x6F2CE00", VA = "0x186F2DA00")]
		private void DDEJCGHCPDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DEB0", Offset = "0x6F2D2B0", VA = "0x186F2DEB0")]
		public LDKPPGCLIKN GetOrCreateCullingGroup(Type PLBLLJIAAGM, int KAFOGPOLCDG, ushort AJPHLEFNFEA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x268B0C0", Offset = "0x268A4C0", VA = "0x18268B0C0")]
		public DIBNKOMPBME<T> GetOrCreateCullingGroup<T>(int KAFOGPOLCDG, ushort AJPHLEFNFEA = 0) where T : class, CAJOJINPBPL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E0A0", Offset = "0x6F2D4A0", VA = "0x186F2E0A0")]
		private LDKPPGCLIKN IHDKMGKLMBI(Type PLBLLJIAAGM, int KAFOGPOLCDG, float[] KBKPKFFAFBM, ushort AJPHLEFNFEA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x268B170", Offset = "0x268A570", VA = "0x18268B170")]
		private DIBNKOMPBME<T> IHDKMGKLMBI<T>(int KAFOGPOLCDG, float[] KBKPKFFAFBM, ushort AJPHLEFNFEA = 0) where T : class, CAJOJINPBPL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6F2DD20", Offset = "0x6F2D120", VA = "0x186F2DD20")]
		public static JCCBPCLKPNF FindClosestDefaultUpdateLod(float GCLKKIPBDIF)
		{
			return default(JCCBPCLKPNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E2B0", Offset = "0x6F2D6B0", VA = "0x186F2E2B0")]
		public static JCCBPCLKPNF MinUpdateLod(JCCBPCLKPNF EDFDAJIOOGA, JCCBPCLKPNF IPAAGPANNOO)
		{
			return default(JCCBPCLKPNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6F2E2A0", Offset = "0x6F2D6A0", VA = "0x186F2E2A0")]
		public static JCCBPCLKPNF MaxUpdateLod(JCCBPCLKPNF EDFDAJIOOGA, JCCBPCLKPNF IPAAGPANNOO)
		{
			return default(JCCBPCLKPNF);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F2EA20", Offset = "0x6F2DE20", VA = "0x186F2EA20")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum JCCBPCLKPNF
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
public interface CAJOJINPBPL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform FELEGEFPADK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(JCCBPCLKPNF NOHEHILFFFE, JCCBPCLKPNF BMNLJMGMOCE);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool FJINNNNEOHF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LDKPPGCLIKN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool BPCFFGKCPLA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBOHBLNDMAL(CAJOJINPBPL ICNDEPGFBMI, float IPHDKMMKPIL, IKCLPGCCHEM ENGMPOKGFGL = IKCLPGCCHEM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBDAKCGNFND(CAJOJINPBPL IIKDBGMAHHI);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JGIDNOCJALG(CAJOJINPBPL ICNDEPGFBMI, IKCLPGCCHEM LFLBMHLLEJB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DIBNKOMPBME<T> : LDKPPGCLIKN where T : class, CAJOJINPBPL
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBOHBLNDMAL(T ICNDEPGFBMI, float IPHDKMMKPIL, IKCLPGCCHEM ENGMPOKGFGL = IKCLPGCCHEM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBOHBLNDMAL(T ICNDEPGFBMI, Transform GACMCFFBMNN, float IPHDKMMKPIL, IKCLPGCCHEM ENGMPOKGFGL = IKCLPGCCHEM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBDAKCGNFND(T IIKDBGMAHHI);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum IKCLPGCCHEM : byte
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
