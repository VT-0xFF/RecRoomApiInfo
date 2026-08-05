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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JHMNCBGMHEA
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class HJKANDGPPIK<T> : NPIECNEHLHG, BDDDLGCPFDF<T>, GHJCIMDKCIA where T : class, OLBCLCMIHIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3756660", Offset = "0x3755460", VA = "0x183756660")]
			internal HJKANDGPPIK(int MNOFFCNAMIG, float[] CKIJEKFGNIE, NEJDOKBDGIL OJELBIIMMEL = NEJDOKBDGIL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3756600", Offset = "0x3755400", VA = "0x183756600", Slot = "10")]
			public void EHPBILHDFGD(T FGANJEAKCMA, float GBGAAPIAACD, IJDELAFHAFH DOAAOHBJAML = IJDELAFHAFH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3756630", Offset = "0x3755430", VA = "0x183756630", Slot = "11")]
			public void EHPBILHDFGD(T FGANJEAKCMA, Transform EIJJLIIMIGO, float GBGAAPIAACD, IJDELAFHAFH DOAAOHBJAML = IJDELAFHAFH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x37565E0", Offset = "0x37553E0", VA = "0x1837565E0", Slot = "12")]
			public void CPMMAHJGJAD(T FIAHOLCAICH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NPIECNEHLHG : IDisposable, GHJCIMDKCIA
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum NEJDOKBDGIL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class KBOBMGMFLHA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public OLBCLCMIHIN GNHBMIBMJPC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public IJDELAFHAFH PKHBOMKIBNL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action KEPOBEJGHGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool PINOGMKDBEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int IMILALJBIFL;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
				public KBOBMGMFLHA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class AFAAFJFINAB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public NPIECNEHLHG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public KBOBMGMFLHA trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
				public AFAAFJFINAB()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5F9E8D0", Offset = "0x5F9D6D0", VA = "0x185F9E8D0")]
				internal void LPFKIDHNGDC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int NONIAGLDGJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int MNOFFCNAMIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int OMLLNNICHGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool FHCLJNNFIBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup ICKMHIBBNFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] EGDLBIGKHCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] IFGHFFEHFKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly JOGCGGADBBI KJKENJAPKJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<OLBCLCMIHIN, int> IBJLBCANLKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, KBOBMGMFLHA> HLLDIHIFGOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly NEJDOKBDGIL OJELBIIMMEL;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool CGIGJAGDMMK
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x1B09E30", Offset = "0x1B08C30", VA = "0x181B09E30")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3DD7A80", Offset = "0x3DD6880", VA = "0x183DD7A80", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5FA1840", Offset = "0x5FA0640", VA = "0x185FA1840")]
			internal NPIECNEHLHG(int MNOFFCNAMIG, float[] CKIJEKFGNIE, NEJDOKBDGIL OJELBIIMMEL = NEJDOKBDGIL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0B50", Offset = "0x5F9F950", VA = "0x185FA0B50")]
			public void FKFPOOIIPNL(bool IALKBCGPCCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5FA06D0", Offset = "0x5F9F4D0", VA = "0x185FA06D0", Slot = "6")]
			public void EHPBILHDFGD(OLBCLCMIHIN FGANJEAKCMA, float GBGAAPIAACD, IJDELAFHAFH DOAAOHBJAML = IJDELAFHAFH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0760", Offset = "0x5F9F560", VA = "0x185FA0760", Slot = "9")]
			public void EHPBILHDFGD(OLBCLCMIHIN FGANJEAKCMA, Transform EIJJLIIMIGO, float GBGAAPIAACD, IJDELAFHAFH DOAAOHBJAML = IJDELAFHAFH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5FA16E0", Offset = "0x5FA04E0", VA = "0x185FA16E0")]
			public void PHNANOONJHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5FA02E0", Offset = "0x5F9F0E0", VA = "0x185FA02E0")]
			private void DHBCFFOLDBH(int HPLKFBKKIBG, [Optional] float? GBGAAPIAACD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5F9FF00", Offset = "0x5F9ED00", VA = "0x185F9FF00", Slot = "7")]
			public void CPMMAHJGJAD(OLBCLCMIHIN FIAHOLCAICH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5F9FCA0", Offset = "0x5F9EAA0", VA = "0x185F9FCA0", Slot = "8")]
			public void AFFDPCJMEAI(OLBCLCMIHIN FGANJEAKCMA, IJDELAFHAFH FAAPMLLKNHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0410", Offset = "0x5F9F210", VA = "0x185FA0410", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0B80", Offset = "0x5F9F980", VA = "0x185FA0B80")]
			private void GJFPHCOKOBB(KBOBMGMFLHA ADJCDDODAOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5FA1430", Offset = "0x5FA0230", VA = "0x185FA1430")]
			private void MDAFFGIJBMM(KBOBMGMFLHA ADJCDDODAOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5FA13D0", Offset = "0x5FA01D0", VA = "0x185FA13D0")]
			private void LNDLOLEHJMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5FA1050", Offset = "0x5F9FE50", VA = "0x185FA1050")]
			private void IMJNFIIMKLB(float BLFDEPDEIPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5FA0F10", Offset = "0x5F9FD10", VA = "0x185FA0F10")]
			private void HIFOCMIFIID(KBOBMGMFLHA ADJCDDODAOC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5FA1830", Offset = "0x5FA0630", VA = "0x185FA1830")]
			private void POALLJHLDAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5FA16D0", Offset = "0x5FA04D0", VA = "0x185FA16D0")]
			private void MLNHCDLMENO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5FA10B0", Offset = "0x5F9FEB0", VA = "0x185FA10B0")]
			private void IMLKJJEEDNA(CullingGroupEvent GCOBBJBCGGC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5F9FD90", Offset = "0x5F9EB90", VA = "0x185F9FD90")]
			private void BDIADIIPNJO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct GNOMNFJNOIG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort DOLDLPKGGLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type EHPJKAAMPLP;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float HLFAPKAODCJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float DMIPJOHPIFM = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float HMOCLEGMPIE = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float EPGIHGHKPGF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FOEEOMECJOA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float KBBBJBPMEOG = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GOOIPHKOGFK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<GNOMNFJNOIG, NPIECNEHLHG> OGHLBKKOHCO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PJEKPIKJPIH;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable KOLFJCFANFH;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static AHOMABILGKI NHCPCOJAPPK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static AHOMABILGKI JHBIPGNANJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly AHOMABILGKI NGOJDJIIMDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly AHOMABILGKI OPOLMPDMEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AHOMABILGKI MLNJFOCGGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private KPDMKFJCEFL JPBAGKOENCF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool IALKBCGPCCD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public AHOMABILGKI KDNNIDEAAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AHOMABILGKI PKJKNCODGJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x794480", Offset = "0x793280", VA = "0x180794480", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AHOMABILGKI JGHHIPMLFDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x78E2A0", Offset = "0x78D0A0", VA = "0x18078E2A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MINCHLKLAMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBF9E30", Offset = "0xBF8C30", VA = "0x180BF9E30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool PCIADGLFEKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7E2E10", Offset = "0x7E1C10", VA = "0x1807E2E10", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7E2B80", Offset = "0x7E1980", VA = "0x1807E2B80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EA20", Offset = "0x5F9D820", VA = "0x185F9EA20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F4D0", Offset = "0x5F9E2D0", VA = "0x185F9F4D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F4B0", Offset = "0x5F9E2B0", VA = "0x185F9F4B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EAE0", Offset = "0x5F9D8E0", VA = "0x185F9EAE0")]
		private void EIKLKIJPAJB(Scene JCMAKMKHHNL, LoadSceneMode HFILCPIGNLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F3D0", Offset = "0x5F9E1D0", VA = "0x185F9F3D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F730", Offset = "0x5F9E530", VA = "0x185F9F730")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F220", Offset = "0x5F9E020", VA = "0x185F9F220")]
		private void LPHIDBKLNAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F4F0", Offset = "0x5F9E2F0", VA = "0x185F9F4F0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F0A0", Offset = "0x5F9DEA0", VA = "0x185F9F0A0")]
		private void LBGOENNCCDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5F9ECA0", Offset = "0x5F9DAA0", VA = "0x185F9ECA0")]
		public GHJCIMDKCIA GetOrCreateCullingGroup(Type MKLBMMIDKKJ, int JDBAJOKHBAO, ushort JHNHGNDLCCK = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2462FE0", Offset = "0x2461DE0", VA = "0x182462FE0")]
		public BDDDLGCPFDF<T> GetOrCreateCullingGroup<T>(int JDBAJOKHBAO, ushort JHNHGNDLCCK = 0) where T : class, OLBCLCMIHIN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EEC0", Offset = "0x5F9DCC0", VA = "0x185F9EEC0")]
		private GHJCIMDKCIA KCGFILMKHBJ(Type MKLBMMIDKKJ, int JDBAJOKHBAO, float[] CKIJEKFGNIE, ushort JHNHGNDLCCK = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2463080", Offset = "0x2461E80", VA = "0x182463080")]
		private BDDDLGCPFDF<T> KCGFILMKHBJ<T>(int JDBAJOKHBAO, float[] CKIJEKFGNIE, ushort JHNHGNDLCCK = 0) where T : class, OLBCLCMIHIN
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5F9EB40", Offset = "0x5F9D940", VA = "0x185F9EB40")]
		public static DBLNOAOKDFO FindClosestDefaultUpdateLod(float OFJHOFEBIJI)
		{
			return default(DBLNOAOKDFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7BBFB0", Offset = "0x7BADB0", VA = "0x1807BBFB0")]
		public static DBLNOAOKDFO MinUpdateLod(DBLNOAOKDFO HKOJHHCGPEH, DBLNOAOKDFO BEKHBPFFHED)
		{
			return default(DBLNOAOKDFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F9F3C0", Offset = "0x5F9E1C0", VA = "0x185F9F3C0")]
		public static DBLNOAOKDFO MaxUpdateLod(DBLNOAOKDFO HKOJHHCGPEH, DBLNOAOKDFO BEKHBPFFHED)
		{
			return default(DBLNOAOKDFO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F9FBA0", Offset = "0x5F9E9A0", VA = "0x185F9FBA0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JOGCGGADBBI
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool MIBIGOKEKFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera AGMIDEDEBLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	AHOMABILGKI AAHLOEIMKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool COKPCOJNGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AHOMABILGKI MANNLHCBHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform PIDOLPDNEDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GHJCIMDKCIA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CGIGJAGDMMK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHPBILHDFGD(OLBCLCMIHIN FGANJEAKCMA, float GBGAAPIAACD, IJDELAFHAFH DOAAOHBJAML = IJDELAFHAFH.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPMMAHJGJAD(OLBCLCMIHIN FIAHOLCAICH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AFFDPCJMEAI(OLBCLCMIHIN FGANJEAKCMA, IJDELAFHAFH COGNGKCBKNL);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BDDDLGCPFDF<T> : GHJCIMDKCIA where T : class, OLBCLCMIHIN
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHPBILHDFGD(T FGANJEAKCMA, float GBGAAPIAACD, IJDELAFHAFH DOAAOHBJAML = IJDELAFHAFH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EHPBILHDFGD(T FGANJEAKCMA, Transform EIJJLIIMIGO, float GBGAAPIAACD, IJDELAFHAFH DOAAOHBJAML = IJDELAFHAFH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPMMAHJGJAD(T FIAHOLCAICH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OLBCLCMIHIN
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform OKMCACLMLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(DBLNOAOKDFO HKNGEMLKFBK, DBLNOAOKDFO JCBPPFJLBAJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool ELJJPHIJEBH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum IJDELAFHAFH : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum DBLNOAOKDFO
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Invalid = -1
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
