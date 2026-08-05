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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, NFOEPLCKIPF
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class IHIMLFDOCEN<T> : JCJKHBEJPGK, BKAFNKAGABP<T>, INIJIIICIKE where T : class, OBKCDKHLKCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3737070", Offset = "0x3735C70", VA = "0x183737070")]
			internal IHIMLFDOCEN(int GOKPEHPJGMO, float[] ICBEHMCDOMF, MGPKIFKFPHE OJFPFFFEODJ = MGPKIFKFPHE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3737020", Offset = "0x3735C20", VA = "0x183737020", Slot = "10")]
			public void HFMDKEOMMOI(T IIFJCGIHMIN, float JBOECICKFAJ, LGAAKFHBOCB FCBOHCCAPCL = LGAAKFHBOCB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3736FF0", Offset = "0x3735BF0", VA = "0x183736FF0", Slot = "11")]
			public void HFMDKEOMMOI(T IIFJCGIHMIN, Transform ILOIMFIAJEE, float JBOECICKFAJ, LGAAKFHBOCB FCBOHCCAPCL = LGAAKFHBOCB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3737050", Offset = "0x3735C50", VA = "0x183737050", Slot = "12")]
			public void IFJPOCDCFNK(T FKCEBDIPNDC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class JCJKHBEJPGK : IDisposable, INIJIIICIKE
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum MGPKIFKFPHE : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BPLNLEMAFCA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public OBKCDKHLKCL IHJIEFCHNFL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public LGAAKFHBOCB PEKHJHIPAPM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action CGENGKIGIAN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool HDIDMHMLCIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int EJAAMOHLDLD;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
				public BPLNLEMAFCA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class FOHNNHIJACL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public JCJKHBEJPGK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public BPLNLEMAFCA trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
				public FOHNNHIJACL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5DDD520", Offset = "0x5DDC120", VA = "0x185DDD520")]
				internal void KGNCMGPHMJP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HEPCKGDAJKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GOKPEHPJGMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int DEABFAKKFBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool OCFIKJIDDDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup NHHEEAEOOFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] KOFPPHLANOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] KOMABBDPKGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly MPAHOJHPMFG IENMGICDHEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<OBKCDKHLKCL, int> DEJGPNJMAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, BPLNLEMAFCA> JDHJEPAPFPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly MGPKIFKFPHE OJFPFFFEODJ;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool CDPJPBLMILB
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x1ABC700", Offset = "0x1ABB300", VA = "0x181ABC700")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3CF0B00", Offset = "0x3CEF700", VA = "0x183CF0B00", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5DDF210", Offset = "0x5DDDE10", VA = "0x185DDF210")]
			internal JCJKHBEJPGK(int GOKPEHPJGMO, float[] ICBEHMCDOMF, MGPKIFKFPHE OJFPFFFEODJ = MGPKIFKFPHE.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDB30", Offset = "0x5DDC730", VA = "0x185DDDB30")]
			public void DELJCFJPHOJ(bool ICDAOHGNDMF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE1A0", Offset = "0x5DDCDA0", VA = "0x185DDE1A0", Slot = "6")]
			public void HFMDKEOMMOI(OBKCDKHLKCL IIFJCGIHMIN, float JBOECICKFAJ, LGAAKFHBOCB FCBOHCCAPCL = LGAAKFHBOCB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE230", Offset = "0x5DDCE30", VA = "0x185DDE230", Slot = "9")]
			public void HFMDKEOMMOI(OBKCDKHLKCL IIFJCGIHMIN, Transform ILOIMFIAJEE, float JBOECICKFAJ, LGAAKFHBOCB FCBOHCCAPCL = LGAAKFHBOCB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE620", Offset = "0x5DDD220", VA = "0x185DDE620")]
			public void HMPHKCJBCOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD670", Offset = "0x5DDC270", VA = "0x185DDD670")]
			private void AGPPKCKLBPD(int DCGGFHOCGGH, [Optional] float? JBOECICKFAJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE770", Offset = "0x5DDD370", VA = "0x185DDE770", Slot = "7")]
			public void IFJPOCDCFNK(OBKCDKHLKCL FKCEBDIPNDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5DDEB50", Offset = "0x5DDD750", VA = "0x185DDEB50", Slot = "8")]
			public void KFBHFMNEINC(OBKCDKHLKCL IIFJCGIHMIN, LGAAKFHBOCB FCIMMDKIFBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDB60", Offset = "0x5DDC760", VA = "0x185DDDB60", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD7A0", Offset = "0x5DDC3A0", VA = "0x185DDD7A0")]
			private void CJHNIKFLCHI(BPLNLEMAFCA FDMNEGALJOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5DDEF10", Offset = "0x5DDDB10", VA = "0x185DDEF10")]
			private void NPGKNICGBHE(BPLNLEMAFCA FDMNEGALJOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5DDF1B0", Offset = "0x5DDDDB0", VA = "0x185DDF1B0")]
			private void ODLIBGBAPAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDE20", Offset = "0x5DDCA20", VA = "0x185DDDE20")]
			private void GAALABKFCEN(float MMHFADIOONC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5DDEDD0", Offset = "0x5DDD9D0", VA = "0x185DDEDD0")]
			private void NLJALMKPJCI(BPLNLEMAFCA FDMNEGALJOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5DDEDC0", Offset = "0x5DDD9C0", VA = "0x185DDEDC0")]
			private void LCLPNNMDMFK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5DDEDB0", Offset = "0x5DDD9B0", VA = "0x185DDEDB0")]
			private void KIDFMGKGFMK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDE80", Offset = "0x5DDCA80", VA = "0x185DDDE80")]
			private void HFBJJOABKBD(CullingGroupEvent LIHBKJPIOBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5DDEC40", Offset = "0x5DDD840", VA = "0x185DDEC40")]
			private void KGDBBOADPDN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct INNJINOLDDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort INHCBBGGDHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type HCHFGKJBFIF;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float PLIFANOFJHM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float DGKCDJKGKJG = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float NIJMCKMOFKN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float IJNKIEMIONF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float OKKHDEBOLFN = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PCMJBNMDJIJ = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float APHBDMJHKNE = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<INNJINOLDDC, JCJKHBEJPGK> JOHCJKGDCKM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable AEGNIOBAIAK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable HAFMNOIKACP;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static NGHNHLLDGBJ JCGCJAKFHNE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static NGHNHLLDGBJ MLAIBKHPAII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly NGHNHLLDGBJ JFAINNIOCAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly NGHNHLLDGBJ DCPOMDGKALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly NGHNHLLDGBJ ENMAADHJCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IHPHLOENKON OMBMOBBCBOC;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool ICDAOHGNDMF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public NGHNHLLDGBJ FLPPMLNBCBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NGHNHLLDGBJ MHAFBHKGOOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x773630", Offset = "0x772230", VA = "0x180773630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NGHNHLLDGBJ LGNCEBKFEAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x773600", Offset = "0x772200", VA = "0x180773600", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IGCJDBMBFHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBFA0F0", Offset = "0xBF8CF0", VA = "0x180BFA0F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EKCJCDLNAFB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C74D0", Offset = "0x7C60D0", VA = "0x1807C74D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7C7B90", Offset = "0x7C6790", VA = "0x1807C7B90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC2A0", Offset = "0x5DDAEA0", VA = "0x185DDC2A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCD50", Offset = "0x5DDB950", VA = "0x185DDCD50")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCD30", Offset = "0x5DDB930", VA = "0x185DDCD30")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC360", Offset = "0x5DDAF60", VA = "0x185DDC360")]
		private void BEKODHKNPGP(Scene LLAJBOAGJHA, LoadSceneMode BBGPDHGEJDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCC50", Offset = "0x5DDB850", VA = "0x185DDCC50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCFB0", Offset = "0x5DDBBB0", VA = "0x185DDCFB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCAA0", Offset = "0x5DDB6A0", VA = "0x185DDCAA0")]
		private void MCPIJMNDDIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCD70", Offset = "0x5DDB970", VA = "0x185DDCD70")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC3C0", Offset = "0x5DDAFC0", VA = "0x185DDC3C0")]
		private void FCNAINBJDAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC880", Offset = "0x5DDB480", VA = "0x185DDC880")]
		public INIJIIICIKE GetOrCreateCullingGroup(Type AEPEBAFNEFP, int IFEKHAOMKEG, ushort PDGNJIHMHOG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x237EF00", Offset = "0x237DB00", VA = "0x18237EF00")]
		public BKAFNKAGABP<T> GetOrCreateCullingGroup<T>(int IFEKHAOMKEG, ushort PDGNJIHMHOG = 0) where T : class, OBKCDKHLKCL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC6A0", Offset = "0x5DDB2A0", VA = "0x185DDC6A0")]
		private INIJIIICIKE GKFLLFDODIJ(Type AEPEBAFNEFP, int IFEKHAOMKEG, float[] ICBEHMCDOMF, ushort PDGNJIHMHOG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x237EC90", Offset = "0x237D890", VA = "0x18237EC90")]
		private BKAFNKAGABP<T> GKFLLFDODIJ<T>(int IFEKHAOMKEG, float[] ICBEHMCDOMF, ushort PDGNJIHMHOG = 0) where T : class, OBKCDKHLKCL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC540", Offset = "0x5DDB140", VA = "0x185DDC540")]
		public static HHMPBKNCJLA FindClosestDefaultUpdateLod(float EJPEEHCGJFO)
		{
			return default(HHMPBKNCJLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x79F040", Offset = "0x79DC40", VA = "0x18079F040")]
		public static HHMPBKNCJLA MinUpdateLod(HHMPBKNCJLA OGNLJDPFFOK, HHMPBKNCJLA MMICGKMMDMG)
		{
			return default(HHMPBKNCJLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCC40", Offset = "0x5DDB840", VA = "0x185DDCC40")]
		public static HHMPBKNCJLA MaxUpdateLod(HHMPBKNCJLA OGNLJDPFFOK, HHMPBKNCJLA MMICGKMMDMG)
		{
			return default(HHMPBKNCJLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DDD420", Offset = "0x5DDC020", VA = "0x185DDD420")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MPAHOJHPMFG
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KIHIFKFNCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera CBGPHMJAJFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	NGHNHLLDGBJ HAHLMFFBJAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool PBMFDNCAIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NGHNHLLDGBJ CLLBJLAPEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform NNKPEADDPDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface INIJIIICIKE
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool CDPJPBLMILB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFMDKEOMMOI(OBKCDKHLKCL IIFJCGIHMIN, float JBOECICKFAJ, LGAAKFHBOCB FCBOHCCAPCL = LGAAKFHBOCB.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFJPOCDCFNK(OBKCDKHLKCL FKCEBDIPNDC);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFBHFMNEINC(OBKCDKHLKCL IIFJCGIHMIN, LGAAKFHBOCB OPKMBJCNJPD);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface BKAFNKAGABP<T> : INIJIIICIKE where T : class, OBKCDKHLKCL
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFMDKEOMMOI(T IIFJCGIHMIN, float JBOECICKFAJ, LGAAKFHBOCB FCBOHCCAPCL = LGAAKFHBOCB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFMDKEOMMOI(T IIFJCGIHMIN, Transform ILOIMFIAJEE, float JBOECICKFAJ, LGAAKFHBOCB FCBOHCCAPCL = LGAAKFHBOCB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFJPOCDCFNK(T FKCEBDIPNDC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OBKCDKHLKCL
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform CAHHGMHAMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(HHMPBKNCJLA NLGHKNJEOOP, HHMPBKNCJLA BOKAPIHJLIJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool EBLHCGOJIAG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum LGAAKFHBOCB : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum HHMPBKNCJLA
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
