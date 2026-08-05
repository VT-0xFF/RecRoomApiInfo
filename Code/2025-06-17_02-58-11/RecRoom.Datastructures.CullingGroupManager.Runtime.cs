using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, DJGCAAKJKKI, INBJDGLCFFF
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct PGPIECOFKFK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> HPGIDELCODH;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7D0AEA0", Offset = "0x7D098A0", VA = "0x187D0AEA0", Slot = "4")]
			public void Execute(int MNFHMLCLFEB, TransformAccess MNINMACDPEC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct BCLJPJNLNGM : IEquatable<BCLJPJNLNGM>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort BJPHABEEOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type CAKDGDPPNHH;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7D076E0", Offset = "0x7D060E0", VA = "0x187D076E0", Slot = "4")]
			public bool Equals(BCLJPJNLNGM NDNHELJMDCG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7D07760", Offset = "0x7D06160", VA = "0x187D07760", Slot = "0")]
			public override bool Equals(object OJDHMKOBKLD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7D07850", Offset = "0x7D06250", VA = "0x187D07850", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class AHKDGEGDAPG<T> : DGJNLKKPMKL, PMKGJNJHJLK<T>, GCANPHFAGBD where T : class, LLOHDJMHBHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4D945F0", Offset = "0x4D92FF0", VA = "0x184D945F0")]
			internal AHKDGEGDAPG(int JACEJEBHHID, float[] OGJJFMMDHNA, NCCOJPJCEAN LDLDPBBLDJM = NCCOJPJCEAN.PlayerHead, bool OHANBHHDPHP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4D94590", Offset = "0x4D92F90", VA = "0x184D94590", Slot = "12")]
			public void PBDMKLNODMP(T OJDHMKOBKLD, float BGJJMJPDNJC, BJFKEGNANDB DMIJAOMFNMO = BJFKEGNANDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4D945C0", Offset = "0x4D92FC0", VA = "0x184D945C0", Slot = "13")]
			public void PBDMKLNODMP(T OJDHMKOBKLD, Transform EGLNJLGBKNH, float BGJJMJPDNJC, BJFKEGNANDB DMIJAOMFNMO = BJFKEGNANDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4D94550", Offset = "0x4D92F50", VA = "0x184D94550", Slot = "14")]
			public void DAAFLACHELB(T CHJHBNIDAIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4D94570", Offset = "0x4D92F70", VA = "0x184D94570", Slot = "15")]
			public bool LBCLDGGIFAD(T OJDHMKOBKLD)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class DGJNLKKPMKL : IDisposable, GCANPHFAGBD
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct NNENOJBNOML
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum JPDEEFBMAOM : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000031")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public LLOHDJMHBHM PCJJLOCHOCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform OIBPIKEGOHJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float NGEMMPELKAO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public BJFKEGNANDB LHGOJMDKGGM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public JPDEEFBMAOM GLEDFKBBOKL;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum NCCOJPJCEAN : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class NBAMBELFHFO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public LLOHDJMHBHM PCJJLOCHOCD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public BJFKEGNANDB GHFOOILKHDC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action BHDHFGGCGCA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool JIBIGGKAMLP;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
				public NBAMBELFHFO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int MJKAOEIBCPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool OHANBHHDPHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool CDPHAALIFLC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup NNJCLJCFILJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] EJGHAMBFEAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly ODBDIELCILJ FLJMNPJIKOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly NCCOJPJCEAN LDLDPBBLDJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<LLOHDJMHBHM, int> EANGOMMKEFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, NBAMBELFHFO> KKCFCOMNFGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray ODAPCNFNMGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> JEOKPPOLKEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<NNENOJBNOML> FOMONFDAJBL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool KEDJPPDGHPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle IGNDKHDOGPP;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int OAKJKJKBMBN
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xA09110", Offset = "0xA07B10", VA = "0x180A09110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xA155F0", Offset = "0xA13FF0", VA = "0x180A155F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int PGEOOCGNNOM
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA627B0", Offset = "0xA611B0", VA = "0x180A627B0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAB8FF0", Offset = "0xAB79F0", VA = "0x180AB8FF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A9C0", Offset = "0x7D093C0", VA = "0x187D0A9C0")]
			internal DGJNLKKPMKL(int JACEJEBHHID, float[] OGJJFMMDHNA, NCCOJPJCEAN LDLDPBBLDJM = NCCOJPJCEAN.PlayerHead, bool OHANBHHDPHP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A1A0", Offset = "0x7D08BA0", VA = "0x187D0A1A0")]
			public void KPPKAKDLCFM(bool EIOLKALMPEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A820", Offset = "0x7D09220", VA = "0x187D0A820", Slot = "5")]
			public void PBDMKLNODMP(LLOHDJMHBHM OJDHMKOBKLD, float BGJJMJPDNJC, BJFKEGNANDB DMIJAOMFNMO = BJFKEGNANDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A920", Offset = "0x7D09320", VA = "0x187D0A920", Slot = "10")]
			public void PBDMKLNODMP(LLOHDJMHBHM OJDHMKOBKLD, Transform EGLNJLGBKNH, float BGJJMJPDNJC, BJFKEGNANDB DMIJAOMFNMO = BJFKEGNANDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D09D90", Offset = "0x7D08790", VA = "0x187D09D90")]
			private void FGHABGOFANL(LLOHDJMHBHM OJDHMKOBKLD, Transform EGLNJLGBKNH, float BGJJMJPDNJC, BJFKEGNANDB DMIJAOMFNMO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D09840", Offset = "0x7D08240", VA = "0x187D09840", Slot = "6")]
			public void DAAFLACHELB(LLOHDJMHBHM CHJHBNIDAIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D091F0", Offset = "0x7D07BF0", VA = "0x187D091F0")]
			private void BJCKCIKFMLF(LLOHDJMHBHM CHJHBNIDAIB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A290", Offset = "0x7D08C90", VA = "0x187D0A290")]
			private void MDCBOBJFGJB(LLOHDJMHBHM OJDHMKOBKLD, [Optional] float? BGJJMJPDNJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A1D0", Offset = "0x7D08BD0", VA = "0x187D0A1D0", Slot = "11")]
			public bool LBCLDGGIFAD(LLOHDJMHBHM OJDHMKOBKLD)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "7")]
			public void DNBDOJJMLOM(LLOHDJMHBHM OJDHMKOBKLD, BJFKEGNANDB DKIEMKCNNNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7D08E50", Offset = "0x7D07850", VA = "0x187D08E50")]
			private void BGACAFCPLKO(LLOHDJMHBHM OJDHMKOBKLD, BJFKEGNANDB DKIEMKCNNNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7D08D90", Offset = "0x7D07790", VA = "0x187D08D90")]
			public void BFAFEJOEHDK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7D09630", Offset = "0x7D08030", VA = "0x187D09630")]
			public void CBAGGIIHHLC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7D08F00", Offset = "0x7D07900", VA = "0x187D08F00")]
			private void BIKOGCPGFCC(NNENOJBNOML CIBCGCDEGFN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7D098A0", Offset = "0x7D082A0", VA = "0x187D098A0")]
			private void DKBGELEABEF(int IJGMOIHJEDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7D099F0", Offset = "0x7D083F0", VA = "0x187D099F0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A180", Offset = "0x7D08B80", VA = "0x187D0A180")]
			private void IKJMCOKMBJP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A190", Offset = "0x7D08B90", VA = "0x187D0A190")]
			private void JGKABDKMOKN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7D0A4F0", Offset = "0x7D08EF0", VA = "0x187D0A4F0")]
			private void ODDKPHAPMHE(CullingGroupEvent BHPBMPKOLOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7D09C20", Offset = "0x7D08620", VA = "0x187D09C20")]
			private void EGBOLJLMPDK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LNNLJLNJEIJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float DHELFPMILFH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float OEPCFNHEHMJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float PLGBOHGKEDF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JKHBNHOOMFF = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float BKMGNOKDNGG = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float IPJJAHMLCBP = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<BCLJPJNLNGM, DGJNLKKPMKL> GOLDJNECNKD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable EPENAGCLGAM;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable PPBMCDKKIMO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static CNBOOGKDGFE IFIPGEPJBKB;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static CNBOOGKDGFE NNHJDKJHAHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly CNBOOGKDGFE ICILEPCFAIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly CNBOOGKDGFE GDKFKCCCCBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly CNBOOGKDGFE ELHCCIKNLPF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker DBOFNIIBABB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker AILBKAAPPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IDJIHHOMEIC BFIMBDJEAMN;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool EIOLKALMPEC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool JBBKFJFGMPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA10D60", Offset = "0xA0F760", VA = "0x180A10D60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CNBOOGKDGFE MBJLKNMBOEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public CNBOOGKDGFE DBCKBNELGON
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public CNBOOGKDGFE ECBDGNNBJAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ADHBCGMAABM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA37E00", Offset = "0xA36800", VA = "0x180A37E00", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool OOFAJKPAOKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCA7120", Offset = "0xCA5B20", VA = "0x180CA7120", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD9EDB0", Offset = "0xD9D7B0", VA = "0x180D9EDB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D078C0", Offset = "0x7D062C0", VA = "0x187D078C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD2970", Offset = "0x7AD1370", VA = "0x187AD2970")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D084B0", Offset = "0x7D06EB0", VA = "0x187D084B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC95E70", Offset = "0xC94870", VA = "0x180C95E70")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D08370", Offset = "0x7D06D70", VA = "0x187D08370")]
		private void OLIIEKDHNJP(Scene JGPHIOPNBKA, LoadSceneMode KMALIDMGEMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D083D0", Offset = "0x7D06DD0", VA = "0x187D083D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D08760", Offset = "0x7D07160", VA = "0x187D08760")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D07FB0", Offset = "0x7D069B0", VA = "0x187D07FB0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D07980", Offset = "0x7D06380", VA = "0x187D07980")]
		private void FHPONHIEFJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D084D0", Offset = "0x7D06ED0", VA = "0x187D084D0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D08200", Offset = "0x7D06C00", VA = "0x187D08200")]
		private void NCGFPFBDMEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D07C40", Offset = "0x7D06640", VA = "0x187D07C40")]
		public GCANPHFAGBD GetOrCreateCullingGroup(Type ALFHDJLOCEF, int BBKCNNCCGCO, ushort LOMKBDHPMIG = 0, bool OHANBHHDPHP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3891960", Offset = "0x3890360", VA = "0x183891960")]
		public PMKGJNJHJLK<T> GetOrCreateCullingGroup<T>(int BBKCNNCCGCO, ushort LOMKBDHPMIG = 0, bool OHANBHHDPHP = false) where T : class, LLOHDJMHBHM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D07E20", Offset = "0x7D06820", VA = "0x187D07E20")]
		private GCANPHFAGBD HCBCKDOOLFM(Type ALFHDJLOCEF, int BBKCNNCCGCO, float[] OGJJFMMDHNA, ushort LOMKBDHPMIG = 0, bool OHANBHHDPHP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3891A00", Offset = "0x3890400", VA = "0x183891A00")]
		private PMKGJNJHJLK<T> HCBCKDOOLFM<T>(int BBKCNNCCGCO, float[] OGJJFMMDHNA, ushort LOMKBDHPMIG = 0, bool OHANBHHDPHP = false) where T : class, LLOHDJMHBHM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D07AE0", Offset = "0x7D064E0", VA = "0x187D07AE0")]
		public static AMDCJLIPDMO FindClosestDefaultUpdateLod(float FEEMNBBIGHG)
		{
			return default(AMDCJLIPDMO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA38790", Offset = "0xA37190", VA = "0x180A38790")]
		public static AMDCJLIPDMO MinUpdateLod(AMDCJLIPDMO LMNFCGAPLCB, AMDCJLIPDMO MALFAKANMME)
		{
			return default(AMDCJLIPDMO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D081F0", Offset = "0x7D06BF0", VA = "0x187D081F0")]
		public static AMDCJLIPDMO MaxUpdateLod(AMDCJLIPDMO LMNFCGAPLCB, AMDCJLIPDMO MALFAKANMME)
		{
			return default(AMDCJLIPDMO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7D08C40", Offset = "0x7D07640", VA = "0x187D08C40")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA37E00", Offset = "0xA36800", VA = "0x180A37E00", Slot = "11")]
		private bool KOELFKEGDPC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ODBDIELCILJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GJGHNFFMOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera KNOGCAAGPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	CNBOOGKDGFE FGAKNLEELGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool JNJLFOCMABD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	CNBOOGKDGFE DDHPHCFDDLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform BLDKNCALJFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GCANPHFAGBD
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBDMKLNODMP(LLOHDJMHBHM OJDHMKOBKLD, float BGJJMJPDNJC, BJFKEGNANDB DMIJAOMFNMO = BJFKEGNANDB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DAAFLACHELB(LLOHDJMHBHM CHJHBNIDAIB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DNBDOJJMLOM(LLOHDJMHBHM OJDHMKOBKLD, BJFKEGNANDB FCCCLFGKDCK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface PMKGJNJHJLK<T> : GCANPHFAGBD where T : class, LLOHDJMHBHM
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PBDMKLNODMP(T OJDHMKOBKLD, float BGJJMJPDNJC, BJFKEGNANDB DMIJAOMFNMO = BJFKEGNANDB.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PBDMKLNODMP(T OJDHMKOBKLD, Transform EGLNJLGBKNH, float BGJJMJPDNJC, BJFKEGNANDB DMIJAOMFNMO = BJFKEGNANDB.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DAAFLACHELB(T CHJHBNIDAIB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LBCLDGGIFAD(T OJDHMKOBKLD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LLOHDJMHBHM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform MNINMACDPEC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(AMDCJLIPDMO LKNJCDIIPPG, AMDCJLIPDMO IIGJNJIHOEN);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool NKJLCDEGCON);
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
