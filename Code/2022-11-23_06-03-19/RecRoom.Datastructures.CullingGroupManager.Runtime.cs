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
			[Cpp2IlInjected.Address(RVA = "0x3320BD0", Offset = "0x331F9D0", VA = "0x183320BD0")]
			internal ELDBNNGFJNG(int GINOCKMKOHK, float[] NMAGFOPBGBC, MGJBMAHCIEI CNAMDLBJFBP = MGJBMAHCIEI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3320B10", Offset = "0x331F910", VA = "0x183320B10", Slot = "15")]
			public void ELGBPIMHCCH(T KMFLGGMLFJA, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3320B40", Offset = "0x331F940", VA = "0x183320B40", Slot = "16")]
			public void ELGBPIMHCCH(T KMFLGGMLFJA, Transform LJJGANGBOHF, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3320BB0", Offset = "0x331F9B0", VA = "0x183320BB0", Slot = "17")]
			public void OCEMNFBGMIO(T KMFLGGMLFJA, [Optional] float? HENIEIDEPFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x3320AF0", Offset = "0x331F8F0", VA = "0x183320AF0", Slot = "18")]
			public void DOHHNJJEEIG(T EAPIELJEFKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x3320B70", Offset = "0x331F970", VA = "0x183320B70", Slot = "19")]
			public MBINJNPIMDE LDGHCKEOING(T KMFLGGMLFJA)
			{
				return default(MBINJNPIMDE);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3320AD0", Offset = "0x331F8D0", VA = "0x183320AD0", Slot = "20")]
			public bool BJEBDAEBFJN(T KMFLGGMLFJA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3320B90", Offset = "0x331F990", VA = "0x183320B90", Slot = "21")]
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
				[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int GEHJNLDIIDD
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x6C1B90", Offset = "0x6C0990", VA = "0x1806C1B90", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5E86660", Offset = "0x5E85460", VA = "0x185E86660")]
			internal JGLKIEHHLED(int GINOCKMKOHK, float[] NMAGFOPBGBC, MGJBMAHCIEI CNAMDLBJFBP = MGJBMAHCIEI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5E84E60", Offset = "0x5E83C60", VA = "0x185E84E60")]
			public void ELFNFNBIHLG(bool PDAPDNOJLDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5E85520", Offset = "0x5E84320", VA = "0x185E85520", Slot = "7")]
			public MBINJNPIMDE IEGIKFMMJNF(float NPMPDKEHKDP)
			{
				return default(MBINJNPIMDE);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5E84E90", Offset = "0x5E83C90", VA = "0x185E84E90", Slot = "8")]
			public void ELGBPIMHCCH(JIECKEOOMNK KMFLGGMLFJA, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5E84F20", Offset = "0x5E83D20", VA = "0x185E84F20", Slot = "9")]
			public void ELGBPIMHCCH(JIECKEOOMNK KMFLGGMLFJA, Transform LJJGANGBOHF, float HENIEIDEPFD, NFAKFNEDOAM JHHDECFFMAM = NFAKFNEDOAM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5E853A0", Offset = "0x5E841A0", VA = "0x185E853A0")]
			public void IBAPAJALPLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5E861B0", Offset = "0x5E84FB0", VA = "0x185E861B0", Slot = "10")]
			public void OCEMNFBGMIO(JIECKEOOMNK KMFLGGMLFJA, [Optional] float? HENIEIDEPFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5E85880", Offset = "0x5E84680", VA = "0x185E85880")]
			private void JKMGPLCCGDB(int BNNEENLPEFO, [Optional] float? HENIEIDEPFD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5E84790", Offset = "0x5E83590", VA = "0x185E84790", Slot = "11")]
			public void DOHHNJJEEIG(JIECKEOOMNK EAPIELJEFKO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5E859E0", Offset = "0x5E847E0", VA = "0x185E859E0", Slot = "12")]
			public MBINJNPIMDE LDGHCKEOING(JIECKEOOMNK KMFLGGMLFJA)
			{
				return default(MBINJNPIMDE);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5E84670", Offset = "0x5E83470", VA = "0x185E84670", Slot = "13")]
			public bool BJEBDAEBFJN(JIECKEOOMNK KMFLGGMLFJA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5E85E30", Offset = "0x5E84C30", VA = "0x185E85E30", Slot = "14")]
			public void NJDLDIOONIF(JIECKEOOMNK KMFLGGMLFJA, NFAKFNEDOAM BPIADKEHMEK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5E84BC0", Offset = "0x5E839C0", VA = "0x185E84BC0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5E862A0", Offset = "0x5E850A0", VA = "0x185E862A0")]
			private void PHPLCMAPKAD(MBGGHAKMMBP FKOGPNFNKNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5E85F20", Offset = "0x5E84D20", VA = "0x185E85F20")]
			private void NMGKCKLGNAK(MBGGHAKMMBP FKOGPNFNKNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5E84600", Offset = "0x5E83400", VA = "0x185E84600")]
			private void BAFNDLPJFDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5E86230", Offset = "0x5E85030", VA = "0x185E86230")]
			private void OOAFFGGHBHL(float JPDJAOGGHAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5E85370", Offset = "0x5E84170", VA = "0x185E85370")]
			private void GIBKCOFOCHE(MBGGHAKMMBP FKOGPNFNKNB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5E84780", Offset = "0x5E83580", VA = "0x185E84780")]
			private void DKNNFDKGBKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5E84770", Offset = "0x5E83570", VA = "0x185E84770")]
			private void BOHNMHDHOEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5E85AF0", Offset = "0x5E848F0", VA = "0x185E85AF0")]
			private void MFPLCGIJCEN(CullingGroupEvent CIEIOCKJHLA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5E85700", Offset = "0x5E84500", VA = "0x185E85700")]
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
			[Cpp2IlInjected.Address(RVA = "0x6529F0", Offset = "0x6517F0", VA = "0x1806529F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DEFJOCBMFPI BNLCFAMFKPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6529E0", Offset = "0x6517E0", VA = "0x1806529E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DEFJOCBMFPI FGLGPMLNEGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x652B80", Offset = "0x651980", VA = "0x180652B80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool JABBODADOPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x11B7D70", Offset = "0x11B6B70", VA = "0x1811B7D70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JCCHGFHFEPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6EDE20", Offset = "0x6ECC20", VA = "0x1806EDE20", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x895130", Offset = "0x893F30", VA = "0x180895130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E833B0", Offset = "0x5E821B0", VA = "0x185E833B0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x15C2760", Offset = "0x15C1560", VA = "0x1815C2760")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E83E30", Offset = "0x5E82C30", VA = "0x185E83E30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E83B50", Offset = "0x5E82950", VA = "0x185E83B50")]
		private void MGKOJIMGGHG(Scene IEGFBJCKFAP, LoadSceneMode GGBPGDBFPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E83D50", Offset = "0x5E82B50", VA = "0x185E83D50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E84080", Offset = "0x5E82E80", VA = "0x185E84080")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E839B0", Offset = "0x5E827B0", VA = "0x185E839B0")]
		private void ICIGJOGNFJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E83E50", Offset = "0x5E82C50", VA = "0x185E83E50")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E83BD0", Offset = "0x5E829D0", VA = "0x185E83BD0")]
		private void NDEALBIBBME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E837C0", Offset = "0x5E825C0", VA = "0x185E837C0")]
		public JINLEILKFAG GetOrCreateCullingGroup(Type GJDCMEJLKAE, int EHPBMPHGFCP, ushort KEACJFJFILB = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x273BAE0", Offset = "0x273A8E0", VA = "0x18273BAE0")]
		public global::HEPKJGFEMOO<T> GetOrCreateCullingGroup<T>(int EHPBMPHGFCP, ushort KEACJFJFILB = 0) where T : class, JIECKEOOMNK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E83480", Offset = "0x5E82280", VA = "0x185E83480")]
		private JINLEILKFAG BOKGELJIEMG(Type GJDCMEJLKAE, int EHPBMPHGFCP, float[] NMAGFOPBGBC, ushort KEACJFJFILB = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x273B8B0", Offset = "0x273A6B0", VA = "0x18273B8B0")]
		private global::HEPKJGFEMOO<T> BOKGELJIEMG<T>(int EHPBMPHGFCP, float[] NMAGFOPBGBC, ushort KEACJFJFILB = 0) where T : class, JIECKEOOMNK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E83620", Offset = "0x5E82420", VA = "0x185E83620")]
		public static MBINJNPIMDE FindClosestDefaultUpdateLod(float HINPEHLHFBD)
		{
			return default(MBINJNPIMDE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E83BC0", Offset = "0x5E829C0", VA = "0x185E83BC0")]
		public static MBINJNPIMDE MinUpdateLod(MBINJNPIMDE GNJOEJJGHJJ, MBINJNPIMDE FJIDKBGMFNB)
		{
			return default(MBINJNPIMDE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5E83BB0", Offset = "0x5E829B0", VA = "0x185E83BB0")]
		public static MBINJNPIMDE MaxUpdateLod(MBINJNPIMDE GNJOEJJGHJJ, MBINJNPIMDE FJIDKBGMFNB)
		{
			return default(MBINJNPIMDE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E844B0", Offset = "0x5E832B0", VA = "0x185E844B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E83110", Offset = "0x5E81F10", VA = "0x185E83110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MBINJNPIMDE HEOKBALJGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6695E0", Offset = "0x6683E0", VA = "0x1806695E0")]
		get
		{
			return default(MBINJNPIMDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MBINJNPIMDE MBMCOHMELON
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B90", Offset = "0x6C0990", VA = "0x1806C1B90")]
		get
		{
			return default(MBINJNPIMDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E83160", Offset = "0x5E81F60", VA = "0x185E83160")]
	public bool KBFHBLDHILI(object JJFHDFJGCDG, MBINJNPIMDE GKFICKKHACC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5E830B0", Offset = "0x5E81EB0", VA = "0x185E830B0")]
	public bool GBACKLPKCJF(object JJFHDFJGCDG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5E831D0", Offset = "0x5E81FD0", VA = "0x185E831D0")]
	private bool LFMJOJGMHKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5E83330", Offset = "0x5E82130", VA = "0x185E83330")]
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
	[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
	public KEJBIFLOMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E86A20", Offset = "0x5E85820", VA = "0x185E86A20")]
	private static string EBPBHFJLCAL(byte[] GHDGKPNPOBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E86B30", Offset = "0x5E85930", VA = "0x185E86B30")]
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
		[Cpp2IlInjected.Address(RVA = "0x66D7A0", Offset = "0x66C5A0", VA = "0x18066D7A0")]
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
