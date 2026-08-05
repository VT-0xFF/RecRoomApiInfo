using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JDCOGGPNAAC
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class MJCCFKAGDGF<T> : IGAEIAFOIBP, global::BFADBPJDLAH<T>, BIMAPNIOJCG where T : class, HPAPBLHEBJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3A6DA50", Offset = "0x3A6C850", VA = "0x183A6DA50")]
			internal MJCCFKAGDGF(int JDHDDHPFDML, float[] LOLGICGNOOB, AMADPDJKMGF EEJLDMLFCEO = AMADPDJKMGF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3A6D970", Offset = "0x3A6C770", VA = "0x183A6D970", Slot = "15")]
			public void EKGLGHAFJEH(T LOPIEGGIDMF, float BEMOEKLKIOI, KLLJPNNJGOE NAAKKCJMKLG = KLLJPNNJGOE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3A6D9A0", Offset = "0x3A6C7A0", VA = "0x183A6D9A0", Slot = "16")]
			public void EKGLGHAFJEH(T LOPIEGGIDMF, Transform FAAEINOMLPL, float BEMOEKLKIOI, KLLJPNNJGOE NAAKKCJMKLG = KLLJPNNJGOE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3A6DA10", Offset = "0x3A6C810", VA = "0x183A6DA10", Slot = "17")]
			public void NKPFDMKNLAC(T LOPIEGGIDMF, [Optional] float? BEMOEKLKIOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3A6DA30", Offset = "0x3A6C830", VA = "0x183A6DA30", Slot = "18")]
			public void PPEAGPDBOCM(T LOGEIOOHCBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3A6D9F0", Offset = "0x3A6C7F0", VA = "0x183A6D9F0", Slot = "19")]
			public PHFLBMKFMEM KPBGHHHLLDO(T LOPIEGGIDMF)
			{
				return default(PHFLBMKFMEM);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3A6D9D0", Offset = "0x3A6C7D0", VA = "0x183A6D9D0", Slot = "20")]
			public bool ENDCIFHJHKK(T LOPIEGGIDMF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3A6D950", Offset = "0x3A6C750", VA = "0x183A6D950", Slot = "21")]
			public void EBCFIOIGBFD(T LOPIEGGIDMF, KLLJPNNJGOE IKNBDFILOEB)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class IGAEIAFOIBP : IDisposable, BIMAPNIOJCG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum AMADPDJKMGF : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class HHFGGNIKFJL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public HPAPBLHEBJK FPPNINBECNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public KLLJPNNJGOE ECDICFAGGFO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action FGJLGOGGCBE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool ECCDPMCHNIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int NCHPHHOHCKF;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
				public HHFGGNIKFJL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class HPFFFOGKEAM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public IGAEIAFOIBP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public HHFGGNIKFJL trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
				public HPFFFOGKEAM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int NMMCLEKDEOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int JDHDDHPFDML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int JKNNMEEOCFD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool CGEHGMDPJKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup BMCOBMEOFOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] COHHHPDDECG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] BBMDAGCFJML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly MEOPCOJFPFH IDFDCEEBKGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<HPAPBLHEBJK, int> GGLDPEIMCDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, HHFGGNIKFJL> KJCIKOPPMHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly AMADPDJKMGF EEJLDMLFCEO;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int DHIIHDBDNDO
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int PPIDAHAFMGE
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x8E1D20", Offset = "0x8E0B20", VA = "0x1808E1D20", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2169F40", Offset = "0x2168D40", VA = "0x182169F40")]
			internal IGAEIAFOIBP(int JDHDDHPFDML, float[] LOLGICGNOOB, AMADPDJKMGF EEJLDMLFCEO = AMADPDJKMGF.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2169AE0", Offset = "0x21688E0", VA = "0x182169AE0")]
			public void OHMLALKAKCO(bool LAPLFEPOKDF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2168220", Offset = "0x2167020", VA = "0x182168220", Slot = "7")]
			public PHFLBMKFMEM AOJGBAJOIAB(float ABDDCFFHFLB)
			{
				return default(PHFLBMKFMEM);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2169000", Offset = "0x2167E00", VA = "0x182169000", Slot = "8")]
			public void EKGLGHAFJEH(HPAPBLHEBJK LOPIEGGIDMF, float BEMOEKLKIOI, KLLJPNNJGOE NAAKKCJMKLG = KLLJPNNJGOE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2168BB0", Offset = "0x21679B0", VA = "0x182168BB0", Slot = "9")]
			public void EKGLGHAFJEH(HPAPBLHEBJK LOPIEGGIDMF, Transform FAAEINOMLPL, float BEMOEKLKIOI, KLLJPNNJGOE NAAKKCJMKLG = KLLJPNNJGOE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2168410", Offset = "0x2167210", VA = "0x182168410")]
			public void CHOCMBCGEAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2169A60", Offset = "0x2168860", VA = "0x182169A60", Slot = "10")]
			public void NKPFDMKNLAC(HPAPBLHEBJK LOPIEGGIDMF, [Optional] float? BEMOEKLKIOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2169900", Offset = "0x2168700", VA = "0x182169900")]
			private void MHGOBAFOLJI(int DJIEOHJNDEK, [Optional] float? BEMOEKLKIOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2169B10", Offset = "0x2168910", VA = "0x182169B10", Slot = "11")]
			public void PPEAGPDBOCM(HPAPBLHEBJK LOGEIOOHCBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x21697B0", Offset = "0x21685B0", VA = "0x1821697B0", Slot = "12")]
			public PHFLBMKFMEM KPBGHHHLLDO(HPAPBLHEBJK LOPIEGGIDMF)
			{
				return default(PHFLBMKFMEM);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x2169090", Offset = "0x2167E90", VA = "0x182169090", Slot = "13")]
			public bool ENDCIFHJHKK(HPAPBLHEBJK LOPIEGGIDMF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2168AC0", Offset = "0x21678C0", VA = "0x182168AC0", Slot = "14")]
			public void EBCFIOIGBFD(HPAPBLHEBJK LOPIEGGIDMF, KLLJPNNJGOE AFEANPLMPGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2168820", Offset = "0x2167620", VA = "0x182168820", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2169190", Offset = "0x2167F90", VA = "0x182169190")]
			private void FGIGMHEDBAH(HHFGGNIKFJL IDBLAEBCIIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2168590", Offset = "0x2167390", VA = "0x182168590")]
			private void DLKNDLBLLFM(HHFGGNIKFJL IDBLAEBCIIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x2169740", Offset = "0x2168540", VA = "0x182169740")]
			private void JCLPLNBBGPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x2169550", Offset = "0x2168350", VA = "0x182169550")]
			private void HDPLMCJCODC(float FAMHMKFHFGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x21698D0", Offset = "0x21686D0", VA = "0x1821698D0")]
			private void MAMEHLFDIFC(HHFGGNIKFJL IDBLAEBCIIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x21698C0", Offset = "0x21686C0", VA = "0x1821698C0")]
			private void KPINBKOCFLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x2168400", Offset = "0x2167200", VA = "0x182168400")]
			private void BDBOLEBNPMI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x2167EE0", Offset = "0x2166CE0", VA = "0x182167EE0")]
			private void AFDCLBKGCHE(CullingGroupEvent GINNCOPDEBD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x21695C0", Offset = "0x21683C0", VA = "0x1821695C0")]
			private void HFBALKOACND()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct KMEMPBKGOGG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort IFGPJKHGKEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type OOGDGIFKHHJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LFHBNBFJEJK = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float GIBNHMLHDFA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float AJPLJCGDBHJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float ALGLHNDNDEO = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float KLMDGNHFGLO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float KCAFADKEJJB = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float AAINICHIMGH = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<KMEMPBKGOGG, IGAEIAFOIBP> DLCKNMKDKDJ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable IEDLMGMABGL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable FAKJFPEINFK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static EEDHONDEDDI MFPJCIPGHEG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static EEDHONDEDDI BEPGEHGAOMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly EEDHONDEDDI FAENGAGAOON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EEDHONDEDDI ABBDNDHJPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EEDHONDEDDI LJCPOADJJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HDOELFFLJBF EPNKMMCGDDM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool LAPLFEPOKDF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EEDHONDEDDI AGCHFBDGOAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EEDHONDEDDI LMGBCBBOBJD
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6C5D30", Offset = "0x6C4B30", VA = "0x1806C5D30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EEDHONDEDDI CAOLFPOFMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6D0BB0", Offset = "0x6CF9B0", VA = "0x1806D0BB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CDIILINIEHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1C6C9F0", Offset = "0x1C6B7F0", VA = "0x181C6C9F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NHGPLOCHGAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x98D710", Offset = "0x98C510", VA = "0x18098D710", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x98D4F0", Offset = "0x98C2F0", VA = "0x18098D4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2166C90", Offset = "0x2165A90", VA = "0x182166C90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DF77F0", Offset = "0x1DF65F0", VA = "0x181DF77F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2167710", Offset = "0x2166510", VA = "0x182167710")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2167410", Offset = "0x2166210", VA = "0x182167410")]
		private void LLDNEMOOJCO(Scene LICHDNGOEKH, LoadSceneMode LBPMHDKPAGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2167630", Offset = "0x2166430", VA = "0x182167630", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2167960", Offset = "0x2166760", VA = "0x182167960")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2167270", Offset = "0x2166070", VA = "0x182167270")]
		private void HNEIBFJJBDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2167730", Offset = "0x2166530", VA = "0x182167730")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2166F00", Offset = "0x2165D00", VA = "0x182166F00")]
		private void GNPPKJMLMML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2167080", Offset = "0x2165E80", VA = "0x182167080")]
		public BIMAPNIOJCG GetOrCreateCullingGroup(Type JIOLHHJBFEJ, int JBMBDPLCFBE, ushort HIIEGNKACMD = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CA60", Offset = "0x3C1B860", VA = "0x183C1CA60")]
		public global::BFADBPJDLAH<T> GetOrCreateCullingGroup<T>(int JBMBDPLCFBE, ushort HIIEGNKACMD = 0) where T : class, HPAPBLHEBJK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2167490", Offset = "0x2166290", VA = "0x182167490")]
		private BIMAPNIOJCG NMKIHFGDMHO(Type JIOLHHJBFEJ, int JBMBDPLCFBE, float[] LOLGICGNOOB, ushort HIIEGNKACMD = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3C1CB10", Offset = "0x3C1B910", VA = "0x183C1CB10")]
		private global::BFADBPJDLAH<T> NMKIHFGDMHO<T>(int JBMBDPLCFBE, float[] LOLGICGNOOB, ushort HIIEGNKACMD = 0) where T : class, HPAPBLHEBJK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2166D60", Offset = "0x2165B60", VA = "0x182166D60")]
		public static PHFLBMKFMEM FindClosestDefaultUpdateLod(float KCFFMFMNHKC)
		{
			return default(PHFLBMKFMEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2167480", Offset = "0x2166280", VA = "0x182167480")]
		public static PHFLBMKFMEM MinUpdateLod(PHFLBMKFMEM DGBHCKGJKLC, PHFLBMKFMEM CNPLFPBICGN)
		{
			return default(PHFLBMKFMEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2167470", Offset = "0x2166270", VA = "0x182167470")]
		public static PHFLBMKFMEM MaxUpdateLod(PHFLBMKFMEM DGBHCKGJKLC, PHFLBMKFMEM CNPLFPBICGN)
		{
			return default(PHFLBMKFMEM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2167D90", Offset = "0x2166B90", VA = "0x182167D90")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MEOPCOJFPFH
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool LFOJCCDBBHO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera GHLNKNEKPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	EEDHONDEDDI FGEIKCJGJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool CAEFPKCOANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EEDHONDEDDI GAEDOLLLOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform OLCLGNECJEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface BIMAPNIOJCG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int DHIIHDBDNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int PPIDAHAFMGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	PHFLBMKFMEM AOJGBAJOIAB(float ABDDCFFHFLB);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EKGLGHAFJEH(HPAPBLHEBJK LOPIEGGIDMF, float BEMOEKLKIOI, KLLJPNNJGOE NAAKKCJMKLG = KLLJPNNJGOE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKGLGHAFJEH(HPAPBLHEBJK LOPIEGGIDMF, Transform FAAEINOMLPL, float BEMOEKLKIOI, KLLJPNNJGOE NAAKKCJMKLG = KLLJPNNJGOE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NKPFDMKNLAC(HPAPBLHEBJK LOPIEGGIDMF, [Optional] float? BEMOEKLKIOI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void PPEAGPDBOCM(HPAPBLHEBJK LOGEIOOHCBB);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	PHFLBMKFMEM KPBGHHHLLDO(HPAPBLHEBJK LOPIEGGIDMF);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool ENDCIFHJHKK(HPAPBLHEBJK LOPIEGGIDMF);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBCFIOIGBFD(HPAPBLHEBJK LOPIEGGIDMF, KLLJPNNJGOE IKNBDFILOEB);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BFADBPJDLAH<T> : BIMAPNIOJCG where T : class, HPAPBLHEBJK
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EKGLGHAFJEH(T LOPIEGGIDMF, float BEMOEKLKIOI, KLLJPNNJGOE NAAKKCJMKLG = KLLJPNNJGOE.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EKGLGHAFJEH(T LOPIEGGIDMF, Transform FAAEINOMLPL, float BEMOEKLKIOI, KLLJPNNJGOE NAAKKCJMKLG = KLLJPNNJGOE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NKPFDMKNLAC(T LOPIEGGIDMF, [Optional] float? BEMOEKLKIOI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PPEAGPDBOCM(T LOGEIOOHCBB);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PHFLBMKFMEM KPBGHHHLLDO(T LOPIEGGIDMF);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool ENDCIFHJHKK(T LOPIEGGIDMF);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EBCFIOIGBFD(T LOPIEGGIDMF, KLLJPNNJGOE IKNBDFILOEB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HPAPBLHEBJK
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform HAFNICDKMAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(PHFLBMKFMEM CLCPFJKOPEE, PHFLBMKFMEM HEODPPKGDHM);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool INJIBCINCGO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum KLLJPNNJGOE : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum PHFLBMKFMEM
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BMBINBEALHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private PHFLBMKFMEM CDJGLGILJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private PHFLBMKFMEM KIDJEKPKJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, PHFLBMKFMEM> IMFPGMMCDCH;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool MHDOAJCEAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x2166BC0", Offset = "0x21659C0", VA = "0x182166BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public PHFLBMKFMEM NPBFMGFIAEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6BF380", Offset = "0x6BE180", VA = "0x1806BF380")]
		get
		{
			return default(PHFLBMKFMEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public PHFLBMKFMEM NOLJPDCFLHL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8E1D20", Offset = "0x8E0B20", VA = "0x1808E1D20")]
		get
		{
			return default(PHFLBMKFMEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x2166990", Offset = "0x2165790", VA = "0x182166990")]
	public bool KEKCLMKGJCF(object DPODOOAHECI, PHFLBMKFMEM DPJGMDFEIDL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x2166B60", Offset = "0x2165960", VA = "0x182166B60")]
	public bool LOFEFNLJCIF(object DPODOOAHECI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2166A00", Offset = "0x2165800", VA = "0x182166A00")]
	private bool KFPPBHMMKAK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2166C10", Offset = "0x2165A10", VA = "0x182166C10")]
	public BMBINBEALHC()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NCKGPBKGCOP
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] EALBAFGLJIB;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int HJJBAIGPCIK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int DMHGBIHBKDJ;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger HJDFPPAMGPN;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
	public NCKGPBKGCOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x216A650", Offset = "0x2169450", VA = "0x18216A650")]
	private static string NEFLGCBJNIO(byte[] BFLEMGIJKLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x216A300", Offset = "0x2169100", VA = "0x18216A300")]
	public static string BMCDLAKFGCG(byte[] GACPBGKAIDC, bool DFCFJJAKINH)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
