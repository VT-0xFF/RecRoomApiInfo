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
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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
				[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x20274D0", Offset = "0x2025CD0", VA = "0x1820274D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x648800", VA = "0x18064A000", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int MANNLODECFD
			{
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x7CB550", Offset = "0x7C9D50", VA = "0x1807CB550", Slot = "10")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x3F724F0", Offset = "0x3F70CF0", VA = "0x183F724F0")]
			internal MKBLMCEKLMP(int MLKPMCEMAKO, float[] AELLHEMFPDD, BOLNDMICJNI CCHCNBGJDDG = BOLNDMICJNI.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x3F72400", Offset = "0x3F70C00", VA = "0x183F72400", Slot = "11")]
			public override void MGDGBEDNAEP(bool AHLKJDPDAGK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x3F72430", Offset = "0x3F70C30", VA = "0x183F72430", Slot = "12")]
			public GOIALGGLHEJ MPHJIKBJAAM(float FPFJOGLJCJM)
			{
				return default(GOIALGGLHEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3F70D70", Offset = "0x3F6F570", VA = "0x183F70D70", Slot = "13")]
			public void CEMPCIEDPMO(T ODMJCJPGHNI, float OPIDCADEIBF, BFFBMBJKIAA FIOENBOKFMB = BFFBMBJKIAA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x3F708E0", Offset = "0x3F6F0E0", VA = "0x183F708E0", Slot = "14")]
			public void CEMPCIEDPMO(T ODMJCJPGHNI, Transform FLDLDGPIECE, float OPIDCADEIBF, BFFBMBJKIAA FIOENBOKFMB = BFFBMBJKIAA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3F71270", Offset = "0x3F6FA70", VA = "0x183F71270", Slot = "8")]
			public override void EAHNPLGDJMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3F71500", Offset = "0x3F6FD00", VA = "0x183F71500", Slot = "15")]
			public void EPBNEFBCFPM(T ODMJCJPGHNI, [Optional] float? OPIDCADEIBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3F72230", Offset = "0x3F70A30", VA = "0x183F72230")]
			private void LHECPCPKCCL(int MMABPPDCBIB, [Optional] float? OPIDCADEIBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3F704B0", Offset = "0x3F6ECB0", VA = "0x183F704B0", Slot = "16")]
			public void ADDEDGCCJIP(T EPAAEECBAPM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3F70E40", Offset = "0x3F6F640", VA = "0x183F70E40", Slot = "17")]
			public GOIALGGLHEJ CMELMADHHKA(T ODMJCJPGHNI)
			{
				return default(GOIALGGLHEJ);
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x3F72120", Offset = "0x3F70920", VA = "0x183F72120", Slot = "18")]
			public bool KPLEEJIAJOK(T ODMJCJPGHNI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x3F713F0", Offset = "0x3F6FBF0", VA = "0x183F713F0", Slot = "19")]
			public void EAIGOPMDLIN(T ODMJCJPGHNI, BFFBMBJKIAA KCHANHJDBIL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x3F70F60", Offset = "0x3F6F760", VA = "0x183F70F60", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x3F71770", Offset = "0x3F6FF70", VA = "0x183F71770")]
			private void IEMPLEMHHLF(GOJDDNBALHG ENCAJAOPEEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x3F71B50", Offset = "0x3F70350", VA = "0x183F71B50")]
			private void JFHEKLHHHLA(GOJDDNBALHG ENCAJAOPEEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x3F72390", Offset = "0x3F70B90", VA = "0x183F72390")]
			private void MBCNNLCNOLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x3F71700", Offset = "0x3F6FF00", VA = "0x183F71700")]
			private void HFOJFDAOBDC(float AJEJHMBOGME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x3F724B0", Offset = "0x3F70CB0", VA = "0x183F724B0")]
			private void NNOGAJCAPBE(GOJDDNBALHG ENCAJAOPEEN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x3F72490", Offset = "0x3F70C90", VA = "0x183F72490")]
			private void NJBNMIEJCGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x3F70E10", Offset = "0x3F6F610", VA = "0x183F70E10")]
			private void CIHJANHOECN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x3F71DE0", Offset = "0x3F705E0", VA = "0x183F71DE0")]
			private void JNHGDJDMHAA(CullingGroupEvent MEHIIMDCBMB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x3F71580", Offset = "0x3F6FD80", VA = "0x183F71580")]
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
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CMOPDACJGKG FOEBIAMOKKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x667140", Offset = "0x665940", VA = "0x180667140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CMOPDACJGKG DOIDKGBGCDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6F5FE0", Offset = "0x6F47E0", VA = "0x1806F5FE0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OFOMNFICCGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1AA9E80", Offset = "0x1AA8680", VA = "0x181AA9E80", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LOPGOMIEPNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x71C510", Offset = "0x71AD10", VA = "0x18071C510", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x71C530", Offset = "0x71AD30", VA = "0x18071C530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5E478D0", Offset = "0x5E460D0", VA = "0x185E478D0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2009C80", Offset = "0x2008480", VA = "0x182009C80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E47FC0", Offset = "0x5E467C0", VA = "0x185E47FC0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E47E80", Offset = "0x5E46680", VA = "0x185E47E80")]
		private void OFGECPOLPOL(Scene CDOCHABCOEI, LoadSceneMode PDFIDNNGANB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E47EE0", Offset = "0x5E466E0", VA = "0x185E47EE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E48280", Offset = "0x5E46A80", VA = "0x185E48280")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E47CB0", Offset = "0x5E464B0", VA = "0x185E47CB0")]
		private void MECGNIMHJJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5E47FE0", Offset = "0x5E467E0", VA = "0x185E47FE0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5E47B40", Offset = "0x5E46340", VA = "0x185E47B40")]
		private void HEICNIFMKIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x36A2F20", Offset = "0x36A1720", VA = "0x1836A2F20")]
		public global::GCBONDFDEGL<T> GetOrCreateCullingGroup<T>(int PABEMEDPOBE, ushort PPNJEBCOLJN = 0) where T : NDAIJGGCDNM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x36A2CF0", Offset = "0x36A14F0", VA = "0x1836A2CF0")]
		private global::GCBONDFDEGL<T> CMPADKAAEIM<T>(int PABEMEDPOBE, float[] AELLHEMFPDD, ushort PPNJEBCOLJN = 0) where T : NDAIJGGCDNM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5E479A0", Offset = "0x5E461A0", VA = "0x185E479A0")]
		public static GOIALGGLHEJ FindClosestDefaultUpdateLod(float PPKAOEIBKJD)
		{
			return default(GOIALGGLHEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5E47E70", Offset = "0x5E46670", VA = "0x185E47E70")]
		public static GOIALGGLHEJ MinUpdateLod(GOIALGGLHEJ MFBLEKOPGMD, GOIALGGLHEJ NLFLGABDHOC)
		{
			return default(GOIALGGLHEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5E47E60", Offset = "0x5E46660", VA = "0x185E47E60")]
		public static GOIALGGLHEJ MaxUpdateLod(GOIALGGLHEJ MFBLEKOPGMD, GOIALGGLHEJ NLFLGABDHOC)
		{
			return default(GOIALGGLHEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5E48550", Offset = "0x5E46D50", VA = "0x185E48550")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E48830", Offset = "0x5E47030", VA = "0x185E48830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public GOIALGGLHEJ GBFEHMAFOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x64A000", Offset = "0x648800", VA = "0x18064A000")]
		get
		{
			return default(GOIALGGLHEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GOIALGGLHEJ KCLHOHMJOEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x7CB550", Offset = "0x7C9D50", VA = "0x1807CB550")]
		get
		{
			return default(GOIALGGLHEJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5E487C0", Offset = "0x5E46FC0", VA = "0x185E487C0")]
	public bool DIBDKEEBIJK(object FDKCIGPLPAB, GOIALGGLHEJ CCIMHDCKHOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5E48880", Offset = "0x5E47080", VA = "0x185E48880")]
	public bool NOCLIFBDPIH(object FDKCIGPLPAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5E48660", Offset = "0x5E46E60", VA = "0x185E48660")]
	private bool AKMAGOPOHEE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5E488E0", Offset = "0x5E470E0", VA = "0x185E488E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
	public BAADKGJHJEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5E472A0", Offset = "0x5E45AA0", VA = "0x185E472A0")]
	private static string DPBKDPCCPCK(byte[] ENHIJCCJFBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5E473B0", Offset = "0x5E45BB0", VA = "0x185E473B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
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
