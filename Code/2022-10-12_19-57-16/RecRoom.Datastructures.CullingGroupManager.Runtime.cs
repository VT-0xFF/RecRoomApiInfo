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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JOLKFPIPKMP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class IILOGCOICFF : IDisposable, DLLJCHLOEHL
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int KLGHBGGJPHG
			{
				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int MANNLODECFD
			{
				[Cpp2IlInjected.Token(Token = "0x600001A")]
				[Cpp2IlInjected.Address(Slot = "10")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "8")]
			public abstract void EAHNPLGDJMA();

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "11")]
			public abstract void MGDGBEDNAEP(bool AHLKJDPDAGK);

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			protected IILOGCOICFF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MKBLMCEKLMP<T> : IILOGCOICFF, global::GCBONDFDEGL<T>, DLLJCHLOEHL where T : NDAIJGGCDNM
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum BOLNDMICJNI : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GOJDDNBALHG
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T EHOCHHJECJA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public BFFBMBJKIAA EFPGBFFOPHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action PPGENOCOAMM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool IHNANBOGHCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int DCEMEBHPCBK;

				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
				public GOJDDNBALHG()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class NAJIGCGNJGL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public MKBLMCEKLMP<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public GOJDDNBALHG trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0x10AE470", Offset = "0x10AD470", VA = "0x1810AE470")]
				public NAJIGCGNJGL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int LHKDPBOJBAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int MLKPMCEMAKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int EJADEEOGECD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool GPOGJJAECEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup HILGHGPBNND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] CFFGFGHNOMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] AIPAGCIEJKG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly EGKGHAGMOEK OHLAEPJHHCL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> KMINIHCBBFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, GOJDDNBALHG> ELFKDPJBICO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly BOLNDMICJNI CCHCNBGJDDG;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int KLGHBGGJPHG
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int MANNLODECFD
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x660790", Offset = "0x65F790", VA = "0x180660790", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3329BD0", Offset = "0x3328BD0", VA = "0x183329BD0")]
			internal MKBLMCEKLMP(int MLKPMCEMAKO, float[] AELLHEMFPDD, BOLNDMICJNI CCHCNBGJDDG = BOLNDMICJNI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3329AE0", Offset = "0x3328AE0", VA = "0x183329AE0", Slot = "11")]
			public override void MGDGBEDNAEP(bool AHLKJDPDAGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3329B10", Offset = "0x3328B10", VA = "0x183329B10", Slot = "12")]
			public GOIALGGLHEJ MPHJIKBJAAM(float FPFJOGLJCJM)
			{
				return default(GOIALGGLHEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3328450", Offset = "0x3327450", VA = "0x183328450", Slot = "13")]
			public void CEMPCIEDPMO(T ODMJCJPGHNI, float OPIDCADEIBF, BFFBMBJKIAA FIOENBOKFMB = BFFBMBJKIAA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3327FC0", Offset = "0x3326FC0", VA = "0x183327FC0", Slot = "14")]
			public void CEMPCIEDPMO(T ODMJCJPGHNI, Transform FLDLDGPIECE, float OPIDCADEIBF, BFFBMBJKIAA FIOENBOKFMB = BFFBMBJKIAA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3328950", Offset = "0x3327950", VA = "0x183328950", Slot = "8")]
			public override void EAHNPLGDJMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3328BE0", Offset = "0x3327BE0", VA = "0x183328BE0", Slot = "15")]
			public void EPBNEFBCFPM(T ODMJCJPGHNI, [Optional] float? OPIDCADEIBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3329910", Offset = "0x3328910", VA = "0x183329910")]
			private void LHECPCPKCCL(int MMABPPDCBIB, [Optional] float? OPIDCADEIBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3327B90", Offset = "0x3326B90", VA = "0x183327B90", Slot = "16")]
			public void ADDEDGCCJIP(T EPAAEECBAPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3328520", Offset = "0x3327520", VA = "0x183328520", Slot = "17")]
			public GOIALGGLHEJ CMELMADHHKA(T ODMJCJPGHNI)
			{
				return default(GOIALGGLHEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3329800", Offset = "0x3328800", VA = "0x183329800", Slot = "18")]
			public bool KPLEEJIAJOK(T ODMJCJPGHNI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3328AD0", Offset = "0x3327AD0", VA = "0x183328AD0", Slot = "19")]
			public void EAIGOPMDLIN(T ODMJCJPGHNI, BFFBMBJKIAA KCHANHJDBIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x3328640", Offset = "0x3327640", VA = "0x183328640", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x3328E50", Offset = "0x3327E50", VA = "0x183328E50")]
			private void IEMPLEMHHLF(GOJDDNBALHG ENCAJAOPEEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x3329230", Offset = "0x3328230", VA = "0x183329230")]
			private void JFHEKLHHHLA(GOJDDNBALHG ENCAJAOPEEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3329A70", Offset = "0x3328A70", VA = "0x183329A70")]
			private void MBCNNLCNOLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3328DE0", Offset = "0x3327DE0", VA = "0x183328DE0")]
			private void HFOJFDAOBDC(float AJEJHMBOGME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3329B90", Offset = "0x3328B90", VA = "0x183329B90")]
			private void NNOGAJCAPBE(GOJDDNBALHG ENCAJAOPEEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3329B70", Offset = "0x3328B70", VA = "0x183329B70")]
			private void NJBNMIEJCGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x33284F0", Offset = "0x33274F0", VA = "0x1833284F0")]
			private void CIHJANHOECN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x33294C0", Offset = "0x33284C0", VA = "0x1833294C0")]
			private void JNHGDJDMHAA(CullingGroupEvent MEHIIMDCBMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x3328C60", Offset = "0x3327C60", VA = "0x183328C60")]
			private void FGJHLPOBCDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct GHNHBBIKKBA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort DBPBJCPNKIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type BGDIIFOGHPF;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float DLDLCOEHCGE = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float HBMEGPHOCDJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float OOEDNCPICDB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float AIOBOAILDPK = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BILLDPHODPB = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OPIJCFEDECL = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float CEGEJDIPKFG = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<GHNHBBIKKBA, IILOGCOICFF> OHDAMMBJDFF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PLILNPIGANC;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable PMDIHHNFEMK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static CMOPDACJGKG GAFCHBMGCKO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static CMOPDACJGKG LDKPMBIGAPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly CMOPDACJGKG PMJLMFIGAHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CMOPDACJGKG OLBEKCOCJDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CMOPDACJGKG KBMFAJHDNEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private PKIGMKLPPJG BJKFGJAMMNN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool AHLKJDPDAGK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public CMOPDACJGKG BPBAHOMGAGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x64A0C0", Offset = "0x6490C0", VA = "0x18064A0C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CMOPDACJGKG FOEBIAMOKKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x64B120", Offset = "0x64A120", VA = "0x18064B120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CMOPDACJGKG DOIDKGBGCDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6648E0", Offset = "0x6638E0", VA = "0x1806648E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OFOMNFICCGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1474D70", Offset = "0x1473D70", VA = "0x181474D70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LOPGOMIEPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x64A030", Offset = "0x649030", VA = "0x18064A030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x800230", Offset = "0x7FF230", VA = "0x180800230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E29FB0", Offset = "0x5E28FB0", VA = "0x185E29FB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1090B50", Offset = "0x108FB50", VA = "0x181090B50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A6A0", Offset = "0x5E296A0", VA = "0x185E2A6A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A560", Offset = "0x5E29560", VA = "0x185E2A560")]
		private void OFGECPOLPOL(Scene CDOCHABCOEI, LoadSceneMode PDFIDNNGANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A5C0", Offset = "0x5E295C0", VA = "0x185E2A5C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A960", Offset = "0x5E29960", VA = "0x185E2A960")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A390", Offset = "0x5E29390", VA = "0x185E2A390")]
		private void MECGNIMHJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A6C0", Offset = "0x5E296C0", VA = "0x185E2A6C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A220", Offset = "0x5E29220", VA = "0x185E2A220")]
		private void HEICNIFMKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x27B5130", Offset = "0x27B4130", VA = "0x1827B5130")]
		public global::GCBONDFDEGL<T> GetOrCreateCullingGroup<T>(int PABEMEDPOBE, ushort PPNJEBCOLJN = 0) where T : NDAIJGGCDNM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x27B4F00", Offset = "0x27B3F00", VA = "0x1827B4F00")]
		private global::GCBONDFDEGL<T> CMPADKAAEIM<T>(int PABEMEDPOBE, float[] AELLHEMFPDD, ushort PPNJEBCOLJN = 0) where T : NDAIJGGCDNM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A080", Offset = "0x5E29080", VA = "0x185E2A080")]
		public static GOIALGGLHEJ FindClosestDefaultUpdateLod(float PPKAOEIBKJD)
		{
			return default(GOIALGGLHEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A550", Offset = "0x5E29550", VA = "0x185E2A550")]
		public static GOIALGGLHEJ MinUpdateLod(GOIALGGLHEJ MFBLEKOPGMD, GOIALGGLHEJ NLFLGABDHOC)
		{
			return default(GOIALGGLHEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E2A540", Offset = "0x5E29540", VA = "0x185E2A540")]
		public static GOIALGGLHEJ MaxUpdateLod(GOIALGGLHEJ MFBLEKOPGMD, GOIALGGLHEJ NLFLGABDHOC)
		{
			return default(GOIALGGLHEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AC30", Offset = "0x5E29C30", VA = "0x185E2AC30")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EGKGHAGMOEK
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool GLLDIPEPJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera OMKMFLLFJMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CMOPDACJGKG FANOGDIBLFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool LDIJBIAPALG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	CMOPDACJGKG AEPEEHFCMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform BPFJAMHDELL
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface DLLJCHLOEHL
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int KLGHBGGJPHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int MANNLODECFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GCBONDFDEGL<T> : DLLJCHLOEHL where T : NDAIJGGCDNM
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GOIALGGLHEJ MPHJIKBJAAM(float FPFJOGLJCJM);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEMPCIEDPMO(T ODMJCJPGHNI, float OPIDCADEIBF, BFFBMBJKIAA FIOENBOKFMB = BFFBMBJKIAA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEMPCIEDPMO(T ODMJCJPGHNI, Transform FLDLDGPIECE, float OPIDCADEIBF, BFFBMBJKIAA FIOENBOKFMB = BFFBMBJKIAA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPBNEFBCFPM(T ODMJCJPGHNI, [Optional] float? OPIDCADEIBF);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void ADDEDGCCJIP(T EPAAEECBAPM);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GOIALGGLHEJ CMELMADHHKA(T ODMJCJPGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KPLEEJIAJOK(T ODMJCJPGHNI);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EAIGOPMDLIN(T ODMJCJPGHNI, BFFBMBJKIAA MNLBBBANLEK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NDAIJGGCDNM
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform JDMGKLHBDHC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GOIALGGLHEJ EHKEHKKBMBK, GOIALGGLHEJ NHOJBNJNMAH);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GHHNHKHEEHH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum BFFBMBJKIAA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GOIALGGLHEJ
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
public class IJAFLECEJHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private GOIALGGLHEJ BNIGPLBPEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private GOIALGGLHEJ EJIIEDBELNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, GOIALGGLHEJ> KGEIGKFJFBB;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BPPCHEPEICL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5E2AF10", Offset = "0x5E29F10", VA = "0x185E2AF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public GOIALGGLHEJ GBFEHMAFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64A040", Offset = "0x649040", VA = "0x18064A040")]
		get
		{
			return default(GOIALGGLHEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GOIALGGLHEJ KCLHOHMJOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x660790", Offset = "0x65F790", VA = "0x180660790")]
		get
		{
			return default(GOIALGGLHEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AEA0", Offset = "0x5E29EA0", VA = "0x185E2AEA0")]
	public bool DIBDKEEBIJK(object FDKCIGPLPAB, GOIALGGLHEJ CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AF60", Offset = "0x5E29F60", VA = "0x185E2AF60")]
	public bool NOCLIFBDPIH(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AD40", Offset = "0x5E29D40", VA = "0x185E2AD40")]
	private bool AKMAGOPOHEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E2AFC0", Offset = "0x5E29FC0", VA = "0x185E2AFC0")]
	public IJAFLECEJHO()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BAADKGJHJEL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] ANBHIGGKLGA;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int CIBDKMIJIHM;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int HHBBDHEOEDG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger JHIBJFGIFBI;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E29980", Offset = "0x5E28980", VA = "0x185E29980")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E29A90", Offset = "0x5E28A90", VA = "0x185E29A90")]
	public static string NNIAAAJCFNJ(byte[] CDDAIIMDJCN, bool FNAKCEJPGOO)
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

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
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
