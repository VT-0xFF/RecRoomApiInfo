using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, BNDKJFEMLMG
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class MHHLNIPJNDN<T> : ILNPDCACAKK, FCPNDDIKHNJ<T>, PPLBJOKIONH where T : class, BKOBFDPOEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x44926F0", Offset = "0x4490EF0", VA = "0x1844926F0")]
			internal MHHLNIPJNDN(int IEIPGGCDLNL, float[] NGCODDKBBBN, DKGJJEKABFA ANCJOHPJOEI = DKGJJEKABFA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x44926C0", Offset = "0x4490EC0", VA = "0x1844926C0", Slot = "10")]
			public void PBLNBBGFGAP(T MEAFIMADMKA, float EOGPEOAFBNO, EEPBOLJHLNK FLIFHKNLBPM = EEPBOLJHLNK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4492690", Offset = "0x4490E90", VA = "0x184492690", Slot = "11")]
			public void PBLNBBGFGAP(T MEAFIMADMKA, Transform ELPIBAHOAEL, float EOGPEOAFBNO, EEPBOLJHLNK FLIFHKNLBPM = EEPBOLJHLNK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4492670", Offset = "0x4490E70", VA = "0x184492670", Slot = "12")]
			public void MFKDEBIIBOM(T AFBHNEJJKJE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class ILNPDCACAKK : IDisposable, PPLBJOKIONH
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum DKGJJEKABFA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class NKLMLNCKLBH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public BKOBFDPOEOJ NLHCDOOPPMO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public EEPBOLJHLNK FLEJKMDALAK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action DPLHFFPNLCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool HJKMNHCJPCM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int LINJEMEJAMF;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
				public NKLMLNCKLBH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class OGJDDGPBCNN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public ILNPDCACAKK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public NKLMLNCKLBH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859580", VA = "0x18085AD80")]
				public OGJDDGPBCNN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x68A5E80", Offset = "0x68A4680", VA = "0x1868A5E80")]
				internal void KDGPHPIIPHJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int NIDLKMGCHKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int IEIPGGCDLNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int AHECCPJHEFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool MAFFMBBADNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup NFLDBIEMONH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] IJFMMKGMGOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] ICEIHHPADNM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly DLFLNJGJAPB EKMGPIDNBAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<BKOBFDPOEOJ, int> GCMFOCILOOH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, NKLMLNCKLBH> HHCEKGOKNCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly DKGJJEKABFA ANCJOHPJOEI;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool MACBJJDFLOJ
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xF3FD80", Offset = "0xF3E580", VA = "0x180F3FD80")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x44E91B0", Offset = "0x44E79B0", VA = "0x1844E91B0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x68A5A90", Offset = "0x68A4290", VA = "0x1868A5A90")]
			internal ILNPDCACAKK(int IEIPGGCDLNL, float[] NGCODDKBBBN, DKGJJEKABFA ANCJOHPJOEI = DKGJJEKABFA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x68A3ED0", Offset = "0x68A26D0", VA = "0x1868A3ED0")]
			public void ABBJIIAADJO(bool HNBFKCCDJOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x68A5680", Offset = "0x68A3E80", VA = "0x1868A5680", Slot = "6")]
			public void PBLNBBGFGAP(BKOBFDPOEOJ MEAFIMADMKA, float EOGPEOAFBNO, EEPBOLJHLNK FLIFHKNLBPM = EEPBOLJHLNK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x68A5280", Offset = "0x68A3A80", VA = "0x1868A5280", Slot = "9")]
			public void PBLNBBGFGAP(BKOBFDPOEOJ MEAFIMADMKA, Transform ELPIBAHOAEL, float EOGPEOAFBNO, EEPBOLJHLNK FLIFHKNLBPM = EEPBOLJHLNK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x68A5000", Offset = "0x68A3800", VA = "0x1868A5000")]
			public void MICJLJFDDLA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x68A5150", Offset = "0x68A3950", VA = "0x1868A5150")]
			private void NAHPBOMMBJE(int DHNLEFJCEAH, [Optional] float? EOGPEOAFBNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x68A4C10", Offset = "0x68A3410", VA = "0x1868A4C10", Slot = "7")]
			public void MFKDEBIIBOM(BKOBFDPOEOJ AFBHNEJJKJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x68A43E0", Offset = "0x68A2BE0", VA = "0x1868A43E0", Slot = "8")]
			public void DMJHDGIMMEF(BKOBFDPOEOJ MEAFIMADMKA, EEPBOLJHLNK MMODONALMBA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x68A44D0", Offset = "0x68A2CD0", VA = "0x1868A44D0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x68A4050", Offset = "0x68A2850", VA = "0x1868A4050")]
			private void DGMAEFGLIMP(NKLMLNCKLBH MCJNNJBOIJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x68A47F0", Offset = "0x68A2FF0", VA = "0x1868A47F0")]
			private void JGKGEBBJPJO(NKLMLNCKLBH MCJNNJBOIJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x68A5710", Offset = "0x68A3F10", VA = "0x1868A5710")]
			private void PJBIIBBHCBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x68A4790", Offset = "0x68A2F90", VA = "0x1868A4790")]
			private void GMNCPEEEPIM(float LDGBKFKPDEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x68A3F00", Offset = "0x68A2700", VA = "0x1868A3F00")]
			private void APFGLMDENCC(NKLMLNCKLBH MCJNNJBOIJL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x68A4C00", Offset = "0x68A3400", VA = "0x1868A4C00")]
			private void MAIIPKAAIPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x68A4040", Offset = "0x68A2840", VA = "0x1868A4040")]
			private void BCDGKIBKBHD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x68A5770", Offset = "0x68A3F70", VA = "0x1868A5770")]
			private void POCJAGIDGGC(CullingGroupEvent GKJFFOLIEND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x68A4A90", Offset = "0x68A3290", VA = "0x1868A4A90")]
			private void LOLLICNKKLE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct HIKEDLFAPAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort MFADMLPJFHG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type LGFLFIIFHBC;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float BAEDHHCKDOO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float CKIDJKGMDAI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float GAFFAGPECIM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float MIAPAEBJNDO = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float AGFFBKIHJBN = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float HOKJFAKKOIL = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float CPNEEOEKKNH = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<HIKEDLFAPAC, ILNPDCACAKK> NDPBLILAGIF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable CFCOKFNDGJK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable HCBCAFHMAPP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static EHODCIMNDCH GONNLLMJCDK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static EHODCIMNDCH PGLNFJHJKKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly EHODCIMNDCH DKIAOAAACDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EHODCIMNDCH LEFIGBFKIPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EHODCIMNDCH MNJNHLDABBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GOOHGCNPLOF EOCDEEAKCLI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool HNBFKCCDJOF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EHODCIMNDCH GKIGGFJDMLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851100", VA = "0x180852900", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EHODCIMNDCH FIGLCEOOFAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x8510A0", VA = "0x1808528A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EHODCIMNDCH AJHGCMMHKAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855140", VA = "0x180856940", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool EMICDMPMLKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF851D0", Offset = "0xF839D0", VA = "0x180F851D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IJLFBIHLLKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9C0720", Offset = "0x9BEF20", VA = "0x1809C0720", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA16600", Offset = "0xA14E00", VA = "0x180A16600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x68A2C50", Offset = "0x68A1450", VA = "0x1868A2C50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x68A3520", Offset = "0x68A1D20", VA = "0x1868A3520")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68A3500", Offset = "0x68A1D00", VA = "0x1868A3500")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x68A33B0", Offset = "0x68A1BB0", VA = "0x1868A33B0")]
		private void LCINGKGFHKD(Scene AFMLKNOAEHD, LoadSceneMode DNCAOAEPAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x68A3420", Offset = "0x68A1C20", VA = "0x1868A3420", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68A3960", Offset = "0x68A2160", VA = "0x1868A3960")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x68A3090", Offset = "0x68A1890", VA = "0x1868A3090")]
		private void IDGLGABCLCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x68A3720", Offset = "0x68A1F20", VA = "0x1868A3720")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68A3230", Offset = "0x68A1A30", VA = "0x1868A3230")]
		private void IIMLOOAAINK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68A2E70", Offset = "0x68A1670", VA = "0x1868A2E70")]
		public PPLBJOKIONH GetOrCreateCullingGroup(Type NKMJCPILFOK, int CFBHNCHPCCF, ushort GPADPJFCFBN = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2966B80", Offset = "0x2965380", VA = "0x182966B80")]
		public FCPNDDIKHNJ<T> GetOrCreateCullingGroup<T>(int CFBHNCHPCCF, ushort GPADPJFCFBN = 0) where T : class, BKOBFDPOEOJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68A3540", Offset = "0x68A1D40", VA = "0x1868A3540")]
		private PPLBJOKIONH PKHLDNDKAPD(Type NKMJCPILFOK, int CFBHNCHPCCF, float[] NGCODDKBBBN, ushort GPADPJFCFBN = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2966C30", Offset = "0x2965430", VA = "0x182966C30")]
		private FCPNDDIKHNJ<T> PKHLDNDKAPD<T>(int CFBHNCHPCCF, float[] NGCODDKBBBN, ushort GPADPJFCFBN = 0) where T : class, BKOBFDPOEOJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x68A2D10", Offset = "0x68A1510", VA = "0x1868A2D10")]
		public static FHBBMPGGCGD FindClosestDefaultUpdateLod(float PHMNIBMFPJB)
		{
			return default(FHBBMPGGCGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x880430", Offset = "0x87EC30", VA = "0x180880430")]
		public static FHBBMPGGCGD MinUpdateLod(FHBBMPGGCGD LFJLABEONEO, FHBBMPGGCGD NGFNPGNMFNM)
		{
			return default(FHBBMPGGCGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68A3410", Offset = "0x68A1C10", VA = "0x1868A3410")]
		public static FHBBMPGGCGD MaxUpdateLod(FHBBMPGGCGD LFJLABEONEO, FHBBMPGGCGD NGFNPGNMFNM)
		{
			return default(FHBBMPGGCGD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68A3DD0", Offset = "0x68A25D0", VA = "0x1868A3DD0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DLFLNJGJAPB
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool NBLLMOBJCNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera KBLLALGJDMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	EHODCIMNDCH ABBEPJJJKPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IOIPMPKKEHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EHODCIMNDCH DMJEDKEPEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform GIJAFHOEICP
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PPLBJOKIONH
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool MACBJJDFLOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBLNBBGFGAP(BKOBFDPOEOJ MEAFIMADMKA, float EOGPEOAFBNO, EEPBOLJHLNK FLIFHKNLBPM = EEPBOLJHLNK.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFKDEBIIBOM(BKOBFDPOEOJ AFBHNEJJKJE);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DMJHDGIMMEF(BKOBFDPOEOJ MEAFIMADMKA, EEPBOLJHLNK ACMMKFGJHKK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface FCPNDDIKHNJ<T> : PPLBJOKIONH where T : class, BKOBFDPOEOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBLNBBGFGAP(T MEAFIMADMKA, float EOGPEOAFBNO, EEPBOLJHLNK FLIFHKNLBPM = EEPBOLJHLNK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBLNBBGFGAP(T MEAFIMADMKA, Transform ELPIBAHOAEL, float EOGPEOAFBNO, EEPBOLJHLNK FLIFHKNLBPM = EEPBOLJHLNK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MFKDEBIIBOM(T AFBHNEJJKJE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BKOBFDPOEOJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform FMAJPAMCPCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FHBBMPGGCGD KMCHIMPGNCP, FHBBMPGGCGD BNADEAHLELH);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool ILLAIMLPMFK);
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
