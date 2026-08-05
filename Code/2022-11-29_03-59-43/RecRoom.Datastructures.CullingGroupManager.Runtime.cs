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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PMNJCJEPGMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class ELDBNNGFJNG<T> : JGLKIEHHLED, global::HEPKJGFEMOO<T>, JINLEILKFAG where T : class, JIECKEOOMNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x48E2820", Offset = "0x48E1420", VA = "0x1848E2820")]
			internal ELDBNNGFJNG(int GINOCKMKOHK, float[] NMAGFOPBGBC, MGJBMAHCIEI CNAMDLBJFBP = MGJBMAHCIEI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x48E2760", Offset = "0x48E1360", VA = "0x1848E2760", Slot = "15")]
			public void ELGBPIMHCCH(T KMFLGGMLFJA, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x48E2790", Offset = "0x48E1390", VA = "0x1848E2790", Slot = "16")]
			public void ELGBPIMHCCH(T KMFLGGMLFJA, Transform LJJGANGBOHF, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x48E2800", Offset = "0x48E1400", VA = "0x1848E2800", Slot = "17")]
			public void OCEMNFBGMIO(T KMFLGGMLFJA, [Optional] float? HENIEIDEPFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x48E2740", Offset = "0x48E1340", VA = "0x1848E2740", Slot = "18")]
			public void DOHHNJJEEIG(T EAPIELJEFKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x48E27C0", Offset = "0x48E13C0", VA = "0x1848E27C0", Slot = "19")]
			public MBINJNPIMDE LDGHCKEOING(T KMFLGGMLFJA)
			{
				return default(MBINJNPIMDE);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x48E2720", Offset = "0x48E1320", VA = "0x1848E2720", Slot = "20")]
			public bool BJEBDAEBFJN(T KMFLGGMLFJA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x48E27E0", Offset = "0x48E13E0", VA = "0x1848E27E0", Slot = "21")]
			public void NJDLDIOONIF(T KMFLGGMLFJA, NFAKFNEDOAM KIOEODKEKHJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class JGLKIEHHLED : IDisposable, JINLEILKFAG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum MGJBMAHCIEI : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class MBGGHAKMMBP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public JIECKEOOMNK DPFBOJFINBN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public NFAKFNEDOAM CPFPBMDKMDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action MAJLAIKGNAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool JIKKDIDALJE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int OMNKALCAHCP;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
				public MBGGHAKMMBP()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class DHKKIHOAIMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public JGLKIEHHLED <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public MBGGHAKMMBP trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
				public DHKKIHOAIMO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int GGMPMILJLDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GINOCKMKOHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int FLELPJPPFKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool LFPHADEPEGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup LHLGFBIAJMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] MLCJEMIEOBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] POAHEDHPMOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly DCOOALADEFG KNPPOFLONHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<JIECKEOOMNK, int> LHLKNOLPKFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, MBGGHAKMMBP> DKCKDACDHKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly MGJBMAHCIEI CNAMDLBJFBP;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int LBFIKMPLMPB
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int GEHJNLDIIDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x68D790", Offset = "0x68C390", VA = "0x18068D790", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x604F360", Offset = "0x604DF60", VA = "0x18604F360")]
			internal JGLKIEHHLED(int GINOCKMKOHK, float[] NMAGFOPBGBC, MGJBMAHCIEI CNAMDLBJFBP = MGJBMAHCIEI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x604DB60", Offset = "0x604C760", VA = "0x18604DB60")]
			public void ELFNFNBIHLG(bool PDAPDNOJLDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x604E220", Offset = "0x604CE20", VA = "0x18604E220", Slot = "7")]
			public MBINJNPIMDE IEGIKFMMJNF(float NPMPDKEHKDP)
			{
				return default(MBINJNPIMDE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x604DB90", Offset = "0x604C790", VA = "0x18604DB90", Slot = "8")]
			public void ELGBPIMHCCH(JIECKEOOMNK KMFLGGMLFJA, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x604DC20", Offset = "0x604C820", VA = "0x18604DC20", Slot = "9")]
			public void ELGBPIMHCCH(JIECKEOOMNK KMFLGGMLFJA, Transform LJJGANGBOHF, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x604E0A0", Offset = "0x604CCA0", VA = "0x18604E0A0")]
			public void IBAPAJALPLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x604EEB0", Offset = "0x604DAB0", VA = "0x18604EEB0", Slot = "10")]
			public void OCEMNFBGMIO(JIECKEOOMNK KMFLGGMLFJA, [Optional] float? HENIEIDEPFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x604E580", Offset = "0x604D180", VA = "0x18604E580")]
			private void JKMGPLCCGDB(int BNNEENLPEFO, [Optional] float? HENIEIDEPFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x604D490", Offset = "0x604C090", VA = "0x18604D490", Slot = "11")]
			public void DOHHNJJEEIG(JIECKEOOMNK EAPIELJEFKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x604E6E0", Offset = "0x604D2E0", VA = "0x18604E6E0", Slot = "12")]
			public MBINJNPIMDE LDGHCKEOING(JIECKEOOMNK KMFLGGMLFJA)
			{
				return default(MBINJNPIMDE);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x604D370", Offset = "0x604BF70", VA = "0x18604D370", Slot = "13")]
			public bool BJEBDAEBFJN(JIECKEOOMNK KMFLGGMLFJA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x604EB30", Offset = "0x604D730", VA = "0x18604EB30", Slot = "14")]
			public void NJDLDIOONIF(JIECKEOOMNK KMFLGGMLFJA, NFAKFNEDOAM BPIADKEHMEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x604D8C0", Offset = "0x604C4C0", VA = "0x18604D8C0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x604EFA0", Offset = "0x604DBA0", VA = "0x18604EFA0")]
			private void PHPLCMAPKAD(MBGGHAKMMBP FKOGPNFNKNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x604EC20", Offset = "0x604D820", VA = "0x18604EC20")]
			private void NMGKCKLGNAK(MBGGHAKMMBP FKOGPNFNKNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x604D300", Offset = "0x604BF00", VA = "0x18604D300")]
			private void BAFNDLPJFDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x604EF30", Offset = "0x604DB30", VA = "0x18604EF30")]
			private void OOAFFGGHBHL(float JPDJAOGGHAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x604E070", Offset = "0x604CC70", VA = "0x18604E070")]
			private void GIBKCOFOCHE(MBGGHAKMMBP FKOGPNFNKNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x604D480", Offset = "0x604C080", VA = "0x18604D480")]
			private void DKNNFDKGBKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x604D470", Offset = "0x604C070", VA = "0x18604D470")]
			private void BOHNMHDHOEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x604E7F0", Offset = "0x604D3F0", VA = "0x18604E7F0")]
			private void MFPLCGIJCEN(CullingGroupEvent CIEIOCKJHLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x604E400", Offset = "0x604D000", VA = "0x18604E400")]
			private void JCAMFLAMGAF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct IIALOBENMEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort JOPIMMBBFCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type PLBKGPAKFGA;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float NMOLGHMNIHC = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float LFDOLJHAOPK = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float DIENHHMJLDJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CBOBIEJMLNG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float MFNJCKAJGNH = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float BBAPKAAFPFH = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float FGLHKEDNFBA = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<IIALOBENMEG, JGLKIEHHLED> CLFIJEBFNPD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable LJHKPLOHGIP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable KKNPPMCHNDG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DEFJOCBMFPI KGLEFOFOKAG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DEFJOCBMFPI JDHPKCPHDHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DEFJOCBMFPI AHDCIEKPFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DEFJOCBMFPI JIJJIMMIPAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DEFJOCBMFPI OMIAMFINKNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LOGJIJEEBDN MMLFFPGADOO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool PDAPDNOJLDJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DEFJOCBMFPI KPMPFEGBHGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6770C0", Offset = "0x675CC0", VA = "0x1806770C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DEFJOCBMFPI BNLCFAMFKPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x678120", Offset = "0x676D20", VA = "0x180678120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DEFJOCBMFPI FGLGPMLNEGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6918E0", Offset = "0x6904E0", VA = "0x1806918E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JABBODADOPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x18387C0", Offset = "0x18373C0", VA = "0x1818387C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JCCHGFHFEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x677030", Offset = "0x675C30", VA = "0x180677030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x812720", Offset = "0x811320", VA = "0x180812720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x604C0B0", Offset = "0x604ACB0", VA = "0x18604C0B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1037EF0", Offset = "0x1036AF0", VA = "0x181037EF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x604CB30", Offset = "0x604B730", VA = "0x18604CB30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x604C850", Offset = "0x604B450", VA = "0x18604C850")]
		private void MGKOJIMGGHG(Scene IEGFBJCKFAP, LoadSceneMode GGBPGDBFPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x604CA50", Offset = "0x604B650", VA = "0x18604CA50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x604CD80", Offset = "0x604B980", VA = "0x18604CD80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x604C6B0", Offset = "0x604B2B0", VA = "0x18604C6B0")]
		private void ICIGJOGNFJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x604CB50", Offset = "0x604B750", VA = "0x18604CB50")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x604C8D0", Offset = "0x604B4D0", VA = "0x18604C8D0")]
		private void NDEALBIBBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x604C4C0", Offset = "0x604B0C0", VA = "0x18604C4C0")]
		public JINLEILKFAG GetOrCreateCullingGroup(Type GJDCMEJLKAE, int EHPBMPHGFCP, ushort KEACJFJFILB = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x22F9370", Offset = "0x22F7F70", VA = "0x1822F9370")]
		public global::HEPKJGFEMOO<T> GetOrCreateCullingGroup<T>(int EHPBMPHGFCP, ushort KEACJFJFILB = 0) where T : class, JIECKEOOMNK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x604C180", Offset = "0x604AD80", VA = "0x18604C180")]
		private JINLEILKFAG BOKGELJIEMG(Type GJDCMEJLKAE, int EHPBMPHGFCP, float[] NMAGFOPBGBC, ushort KEACJFJFILB = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x22F9140", Offset = "0x22F7D40", VA = "0x1822F9140")]
		private global::HEPKJGFEMOO<T> BOKGELJIEMG<T>(int EHPBMPHGFCP, float[] NMAGFOPBGBC, ushort KEACJFJFILB = 0) where T : class, JIECKEOOMNK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x604C320", Offset = "0x604AF20", VA = "0x18604C320")]
		public static MBINJNPIMDE FindClosestDefaultUpdateLod(float HINPEHLHFBD)
		{
			return default(MBINJNPIMDE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x604C8C0", Offset = "0x604B4C0", VA = "0x18604C8C0")]
		public static MBINJNPIMDE MinUpdateLod(MBINJNPIMDE GNJOEJJGHJJ, MBINJNPIMDE FJIDKBGMFNB)
		{
			return default(MBINJNPIMDE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x604C8B0", Offset = "0x604B4B0", VA = "0x18604C8B0")]
		public static MBINJNPIMDE MaxUpdateLod(MBINJNPIMDE GNJOEJJGHJJ, MBINJNPIMDE FJIDKBGMFNB)
		{
			return default(MBINJNPIMDE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x604D1B0", Offset = "0x604BDB0", VA = "0x18604D1B0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface DCOOALADEFG
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool KHOBCMKGOEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera CEBPFBDOIOE
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	DEFJOCBMFPI KKPDENAKCHL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool PNFEMECJCGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	DEFJOCBMFPI DLCKGKPOLOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform DJDPEAPKPPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface JINLEILKFAG
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int LBFIKMPLMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int GEHJNLDIIDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MBINJNPIMDE IEGIKFMMJNF(float NPMPDKEHKDP);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ELGBPIMHCCH(JIECKEOOMNK KMFLGGMLFJA, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ELGBPIMHCCH(JIECKEOOMNK KMFLGGMLFJA, Transform LJJGANGBOHF, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCEMNFBGMIO(JIECKEOOMNK KMFLGGMLFJA, [Optional] float? HENIEIDEPFD);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DOHHNJJEEIG(JIECKEOOMNK EAPIELJEFKO);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MBINJNPIMDE LDGHCKEOING(JIECKEOOMNK KMFLGGMLFJA);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BJEBDAEBFJN(JIECKEOOMNK KMFLGGMLFJA);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NJDLDIOONIF(JIECKEOOMNK KMFLGGMLFJA, NFAKFNEDOAM KIOEODKEKHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HEPKJGFEMOO<T> : JINLEILKFAG where T : class, JIECKEOOMNK
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELGBPIMHCCH(T KMFLGGMLFJA, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELGBPIMHCCH(T KMFLGGMLFJA, Transform LJJGANGBOHF, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCEMNFBGMIO(T KMFLGGMLFJA, [Optional] float? HENIEIDEPFD);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DOHHNJJEEIG(T EAPIELJEFKO);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MBINJNPIMDE LDGHCKEOING(T KMFLGGMLFJA);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BJEBDAEBFJN(T KMFLGGMLFJA);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NJDLDIOONIF(T KMFLGGMLFJA, NFAKFNEDOAM KIOEODKEKHJ);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface JIECKEOOMNK
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform KAMDPLLJPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MBINJNPIMDE NNJGEKJDMHG, MBINJNPIMDE LPNMOACCMHK);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool EAFALPGNJIO);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum NFAKFNEDOAM : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MBINJNPIMDE
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
public class BPJAGPFPEAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private MBINJNPIMDE HKPINKIDAGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private MBINJNPIMDE MFHJKPMAGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, MBINJNPIMDE> MHEDOABGNOG;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NEPGOCILDIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x604BE10", Offset = "0x604AA10", VA = "0x18604BE10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MBINJNPIMDE HEOKBALJGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x677040", Offset = "0x675C40", VA = "0x180677040")]
		get
		{
			return default(MBINJNPIMDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MBINJNPIMDE MBMCOHMELON
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68D790", Offset = "0x68C390", VA = "0x18068D790")]
		get
		{
			return default(MBINJNPIMDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x604BE60", Offset = "0x604AA60", VA = "0x18604BE60")]
	public bool KBFHBLDHILI(object JJFHDFJGCDG, MBINJNPIMDE GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x604BDB0", Offset = "0x604A9B0", VA = "0x18604BDB0")]
	public bool GBACKLPKCJF(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x604BED0", Offset = "0x604AAD0", VA = "0x18604BED0")]
	private bool LFMJOJGMHKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x604C030", Offset = "0x604AC30", VA = "0x18604C030")]
	public BPJAGPFPEAC()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KEJBIFLOMJJ
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] POAMPPAGKIJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int DNBFJGDJLJG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int JPELDCGMMIM;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger LIKOKONEDPL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x604F720", Offset = "0x604E320", VA = "0x18604F720")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x604F830", Offset = "0x604E430", VA = "0x18604F830")]
	public static string HPJOPLJIOMI(byte[] EHAMCGPFFID, bool BLMJHFAPIFG)
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
		[Cpp2IlInjected.Address(RVA = "0x678B30", Offset = "0x677730", VA = "0x180678B30")]
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
