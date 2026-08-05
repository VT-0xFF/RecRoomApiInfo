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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OAHFCFHHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class INJFDOBLMPE<T> : EPDMADFBDDN, global::IIAOOANLMKM<T>, CECADINGKLP where T : class, ENDCOPPFPED
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x1A60100", Offset = "0x1A5EB00", VA = "0x181A60100")]
			internal INJFDOBLMPE(int JGFLHBOAFAP, float[] NLDLFKJOALC, EOEJIBOJNFC IDLDMDMOEJD = EOEJIBOJNFC.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x1A600B0", Offset = "0x1A5EAB0", VA = "0x181A600B0", Slot = "15")]
			public void MJIKPLNABDE(T PDHKCBEBPNG, float MLNGHLOODFP, NCGGNJKJMDB NJAGKLEEFOP = NCGGNJKJMDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x1A60080", Offset = "0x1A5EA80", VA = "0x181A60080", Slot = "16")]
			public void MJIKPLNABDE(T PDHKCBEBPNG, Transform JJPFAMMIDEJ, float MLNGHLOODFP, NCGGNJKJMDB NJAGKLEEFOP = NCGGNJKJMDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1A60020", Offset = "0x1A5EA20", VA = "0x181A60020", Slot = "17")]
			public void FNGKKCCPCHO(T PDHKCBEBPNG, [Optional] float? MLNGHLOODFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1A600E0", Offset = "0x1A5EAE0", VA = "0x181A600E0", Slot = "18")]
			public void OMBMHDCIFDM(T KJKMKHEJHCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1A60060", Offset = "0x1A5EA60", VA = "0x181A60060", Slot = "19")]
			public MBDIBEKIJCI HKLOHBPDLOB(T PDHKCBEBPNG)
			{
				return default(MBDIBEKIJCI);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1A60000", Offset = "0x1A5EA00", VA = "0x181A60000", Slot = "20")]
			public bool BODLMMMKHPH(T PDHKCBEBPNG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1A60040", Offset = "0x1A5EA40", VA = "0x181A60040", Slot = "21")]
			public void GOMDNFHNHME(T PDHKCBEBPNG, NCGGNJKJMDB DLLPLAKBHJD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class EPDMADFBDDN : IDisposable, CECADINGKLP
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum EOEJIBOJNFC : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BCCPODHDJDN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public ENDCOPPFPED HLMDGOMGGOC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public NCGGNJKJMDB IKOGPCHJFJC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action DHNJDEIJDAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool JDGOECJBMEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int HMIPEGLEEME;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
				public BCCPODHDJDN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class OPBGDOIOPEC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public EPDMADFBDDN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public BCCPODHDJDN trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
				public OPBGDOIOPEC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int NPCOLJAHHOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int JGFLHBOAFAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int AGPBFEDGALB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KHOMFNMOLBI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup NKLOPGIAINN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] AAHKIDJMOCH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] KNJDBNEDDFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly NHIGBHBDCIO MGOGCFMPFGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<ENDCOPPFPED, int> IEHPEKNCCOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, BCCPODHDJDN> JDBKMIAEOPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly EOEJIBOJNFC IDLDMDMOEJD;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int FOPLDDNEDPH
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x6983B0", Offset = "0x696DB0", VA = "0x1806983B0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int OODLJJGACOL
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x7DBB10", Offset = "0x7DA510", VA = "0x1807DBB10", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5FF8C00", Offset = "0x5FF7600", VA = "0x185FF8C00")]
			internal EPDMADFBDDN(int JGFLHBOAFAP, float[] NLDLFKJOALC, EOEJIBOJNFC IDLDMDMOEJD = EOEJIBOJNFC.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5FF87A0", Offset = "0x5FF71A0", VA = "0x185FF87A0")]
			public void OIHOJNABBFI(bool BNMPPAOOPGI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5FF6E90", Offset = "0x5FF5890", VA = "0x185FF6E90", Slot = "7")]
			public MBDIBEKIJCI CKPPPIMNGFI(float CCDMPAFJAFJ)
			{
				return default(MBDIBEKIJCI);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5FF8710", Offset = "0x5FF7110", VA = "0x185FF8710", Slot = "8")]
			public void MJIKPLNABDE(ENDCOPPFPED PDHKCBEBPNG, float MLNGHLOODFP, NCGGNJKJMDB NJAGKLEEFOP = NCGGNJKJMDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5FF82C0", Offset = "0x5FF6CC0", VA = "0x185FF82C0", Slot = "9")]
			public void MJIKPLNABDE(ENDCOPPFPED PDHKCBEBPNG, Transform JJPFAMMIDEJ, float MLNGHLOODFP, NCGGNJKJMDB NJAGKLEEFOP = NCGGNJKJMDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5FF7070", Offset = "0x5FF5A70", VA = "0x185FF7070")]
			public void DFLFBAFHNIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5FF78D0", Offset = "0x5FF62D0", VA = "0x185FF78D0", Slot = "10")]
			public void FNGKKCCPCHO(ENDCOPPFPED PDHKCBEBPNG, [Optional] float? MLNGHLOODFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5FF7EA0", Offset = "0x5FF68A0", VA = "0x185FF7EA0")]
			private void INBGNAJEKHN(int NENMOOINMCH, [Optional] float? MLNGHLOODFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5FF87D0", Offset = "0x5FF71D0", VA = "0x185FF87D0", Slot = "11")]
			public void OMBMHDCIFDM(ENDCOPPFPED KJKMKHEJHCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5FF7D90", Offset = "0x5FF6790", VA = "0x185FF7D90", Slot = "12")]
			public MBDIBEKIJCI HKLOHBPDLOB(ENDCOPPFPED PDHKCBEBPNG)
			{
				return default(MBDIBEKIJCI);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5FF6C10", Offset = "0x5FF5610", VA = "0x185FF6C10", Slot = "13")]
			public bool BODLMMMKHPH(ENDCOPPFPED PDHKCBEBPNG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5FF7960", Offset = "0x5FF6360", VA = "0x185FF7960", Slot = "14")]
			public void GOMDNFHNHME(ENDCOPPFPED PDHKCBEBPNG, NCGGNJKJMDB HLGHMAGDGGO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5FF75B0", Offset = "0x5FF5FB0", VA = "0x185FF75B0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5FF71F0", Offset = "0x5FF5BF0", VA = "0x185FF71F0")]
			private void DJHPLDKFGMP(BCCPODHDJDN ANFEAOMNLNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x5FF8000", Offset = "0x5FF6A00", VA = "0x185FF8000")]
			private void LMBNFJPBFME(BCCPODHDJDN ANFEAOMNLNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x5FF6BA0", Offset = "0x5FF55A0", VA = "0x185FF6BA0")]
			private void BGDIKLAPLGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x5FF7860", Offset = "0x5FF6260", VA = "0x185FF7860")]
			private void FJDJACKLIAF(float PKCGFMPPPAN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x5FF8290", Offset = "0x5FF6C90", VA = "0x185FF8290")]
			private void MEIAEEFOLBJ(BCCPODHDJDN ANFEAOMNLNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x5FF7850", Offset = "0x5FF6250", VA = "0x185FF7850")]
			private void EBIOFMAOAJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5FF7950", Offset = "0x5FF6350", VA = "0x185FF7950")]
			private void GHDHCPBMFIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5FF7A50", Offset = "0x5FF6450", VA = "0x185FF7A50")]
			private void HDENKMNFDNO(CullingGroupEvent POKGBHIOFGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x5FF6D10", Offset = "0x5FF5710", VA = "0x185FF6D10")]
			private void CFCPGDPILKM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct JGFJNMLMHHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort DNOBMKHEOAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type HCCIDPLCLAM;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float OCCNHEHEAFE = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float EILNKALIOEP = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float NANJCODICAA = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float ANEPHCINCND = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float CLNCJDDDOFG = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OJGNPOPMBNH = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float CPADFHFGMLL = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<JGFJNMLMHHL, EPDMADFBDDN> FHDJIBMBLKP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable CBKJCKONNEG;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable NIDIDBACCLO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static HOEGAMEJKFN EHKECAPPAJI;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static HOEGAMEJKFN KFECBJDCPKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly HOEGAMEJKFN BCEOGIDPIHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HOEGAMEJKFN NFNGIBBIBOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HOEGAMEJKFN OLADPGAEOBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GJINICPNEFL MJIBJNDGEMA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool BNMPPAOOPGI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HOEGAMEJKFN NNABIOJANEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HOEGAMEJKFN IKHOOJMPLAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x697FE0", Offset = "0x6969E0", VA = "0x180697FE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HOEGAMEJKFN GLBFJECIAKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6AEB10", Offset = "0x6AD510", VA = "0x1806AEB10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool CEEGNLKCGDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF08BA0", Offset = "0xF075A0", VA = "0x180F08BA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BHMIFAPIIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x69FE40", Offset = "0x69E840", VA = "0x18069FE40", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x69FF10", Offset = "0x69E910", VA = "0x18069FF10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5990", Offset = "0x5FF4390", VA = "0x185FF5990", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B0E30", Offset = "0x7AF830", VA = "0x1807B0E30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6410", Offset = "0x5FF4E10", VA = "0x185FF6410")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5DF0", Offset = "0x5FF47F0", VA = "0x185FF5DF0")]
		private void IHPFKKBEBHJ(Scene HJLNDBMKNHI, LoadSceneMode CCHMICPAKBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6330", Offset = "0x5FF4D30", VA = "0x185FF6330", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6660", Offset = "0x5FF5060", VA = "0x185FF6660")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6190", Offset = "0x5FF4B90", VA = "0x185FF6190")]
		private void NCHCFMNDPKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6430", Offset = "0x5FF4E30", VA = "0x185FF6430")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5FF0", Offset = "0x5FF49F0", VA = "0x185FF5FF0")]
		private void KCPHGMAFDKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5C00", Offset = "0x5FF4600", VA = "0x185FF5C00")]
		public CECADINGKLP GetOrCreateCullingGroup(Type AFDFELCLJIK, int FOHOCFNCIFD, ushort PAJFFNOGIMM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x21609A0", Offset = "0x215F3A0", VA = "0x1821609A0")]
		public global::IIAOOANLMKM<T> GetOrCreateCullingGroup<T>(int FOHOCFNCIFD, ushort PAJFFNOGIMM = 0) where T : class, ENDCOPPFPED
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5E50", Offset = "0x5FF4850", VA = "0x185FF5E50")]
		private CECADINGKLP JNAEONAIPPD(Type AFDFELCLJIK, int FOHOCFNCIFD, float[] NLDLFKJOALC, ushort PAJFFNOGIMM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2160A50", Offset = "0x215F450", VA = "0x182160A50")]
		private global::IIAOOANLMKM<T> JNAEONAIPPD<T>(int FOHOCFNCIFD, float[] NLDLFKJOALC, ushort PAJFFNOGIMM = 0) where T : class, ENDCOPPFPED
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5FF5A60", Offset = "0x5FF4460", VA = "0x185FF5A60")]
		public static MBDIBEKIJCI FindClosestDefaultUpdateLod(float AEMJDJHACOA)
		{
			return default(MBDIBEKIJCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6180", Offset = "0x5FF4B80", VA = "0x185FF6180")]
		public static MBDIBEKIJCI MinUpdateLod(MBDIBEKIJCI GKMGHNFJHPE, MBDIBEKIJCI AAKMDPBGEJC)
		{
			return default(MBDIBEKIJCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6170", Offset = "0x5FF4B70", VA = "0x185FF6170")]
		public static MBDIBEKIJCI MaxUpdateLod(MBDIBEKIJCI GKMGHNFJHPE, MBDIBEKIJCI AAKMDPBGEJC)
		{
			return default(MBDIBEKIJCI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5FF6A90", Offset = "0x5FF5490", VA = "0x185FF6A90")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NHIGBHBDCIO
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool OMMJMOHJKNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera EJCFFICLPDL
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HOEGAMEJKFN GPNGJJAENDF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool MNKNJGJPGBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HOEGAMEJKFN FEMMLBHGCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform LOBGEALAPFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface CECADINGKLP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int FOPLDDNEDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int OODLJJGACOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MBDIBEKIJCI CKPPPIMNGFI(float CCDMPAFJAFJ);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MJIKPLNABDE(ENDCOPPFPED PDHKCBEBPNG, float MLNGHLOODFP, NCGGNJKJMDB NJAGKLEEFOP = NCGGNJKJMDB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MJIKPLNABDE(ENDCOPPFPED PDHKCBEBPNG, Transform JJPFAMMIDEJ, float MLNGHLOODFP, NCGGNJKJMDB NJAGKLEEFOP = NCGGNJKJMDB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FNGKKCCPCHO(ENDCOPPFPED PDHKCBEBPNG, [Optional] float? MLNGHLOODFP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OMBMHDCIFDM(ENDCOPPFPED KJKMKHEJHCL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	MBDIBEKIJCI HKLOHBPDLOB(ENDCOPPFPED PDHKCBEBPNG);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool BODLMMMKHPH(ENDCOPPFPED PDHKCBEBPNG);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void GOMDNFHNHME(ENDCOPPFPED PDHKCBEBPNG, NCGGNJKJMDB DLLPLAKBHJD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IIAOOANLMKM<T> : CECADINGKLP where T : class, ENDCOPPFPED
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJIKPLNABDE(T PDHKCBEBPNG, float MLNGHLOODFP, NCGGNJKJMDB NJAGKLEEFOP = NCGGNJKJMDB.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJIKPLNABDE(T PDHKCBEBPNG, Transform JJPFAMMIDEJ, float MLNGHLOODFP, NCGGNJKJMDB NJAGKLEEFOP = NCGGNJKJMDB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNGKKCCPCHO(T PDHKCBEBPNG, [Optional] float? MLNGHLOODFP);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OMBMHDCIFDM(T KJKMKHEJHCL);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MBDIBEKIJCI HKLOHBPDLOB(T PDHKCBEBPNG);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BODLMMMKHPH(T PDHKCBEBPNG);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOMDNFHNHME(T PDHKCBEBPNG, NCGGNJKJMDB DLLPLAKBHJD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ENDCOPPFPED
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform MLMJNFGMBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MBDIBEKIJCI MBLJJEDHFIJ, MBDIBEKIJCI AIHDKFPKDOC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GOLBEBPEBNE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum NCGGNJKJMDB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum MBDIBEKIJCI
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
public class LEPCICBAJPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private MBDIBEKIJCI IGJJHEFOMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private MBDIBEKIJCI FMFHKMBBDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, MBDIBEKIJCI> HMBJNCBJNLC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JOCENPKCKJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5FF91F0", Offset = "0x5FF7BF0", VA = "0x185FF91F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public MBDIBEKIJCI KAPDFDAEKNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6983B0", Offset = "0x696DB0", VA = "0x1806983B0")]
		get
		{
			return default(MBDIBEKIJCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public MBDIBEKIJCI NILIBJDOOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7DBB10", Offset = "0x7DA510", VA = "0x1807DBB10")]
		get
		{
			return default(MBDIBEKIJCI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5FF8FC0", Offset = "0x5FF79C0", VA = "0x185FF8FC0")]
	public bool AMDGDCEIFKL(object KBCPLDFOJJL, MBDIBEKIJCI NKJMIDIDBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9030", Offset = "0x5FF7A30", VA = "0x185FF9030")]
	public bool DEIALELIJGP(object KBCPLDFOJJL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9090", Offset = "0x5FF7A90", VA = "0x185FF9090")]
	private bool DJNBBGOHCIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5FF9240", Offset = "0x5FF7C40", VA = "0x185FF9240")]
	public LEPCICBAJPD()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LHIPOBGMLKE
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] PNBNOGIJBMC;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int DGEFGPNJFGJ;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int GBGLKCBJBIA;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger EPCGLFJDNLL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LHIPOBGMLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5FF92C0", Offset = "0x5FF7CC0", VA = "0x185FF92C0")]
	private static string GKOJACPJHAL(byte[] KCHCODPDAGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5FF93D0", Offset = "0x5FF7DD0", VA = "0x185FF93D0")]
	public static string MEDIDALCMKC(byte[] GHEBPHBJKNK, bool FPEGHFMMINI)
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
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
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
