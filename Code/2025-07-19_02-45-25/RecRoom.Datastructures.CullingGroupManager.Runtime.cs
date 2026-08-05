using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Datastructures_CullingGroupManager_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : AOMECLICLPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x812CF40", Offset = "0x812BF40", VA = "0x18812CF40", Slot = "4")]
		public override void AMNFOKHCMAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA8A800", Offset = "0xA89800", VA = "0x180A8A800")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, NDHKHPJDAHA, BDBAOHOAIEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct HJBHPFDAIJD : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> INCJDDLACNP;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x812CEC0", Offset = "0x812BEC0", VA = "0x18812CEC0", Slot = "4")]
			public void Execute(int HLGKMAPOEBE, TransformAccess PLPGMCABFBF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct GGHFMMBDFBA : IEquatable<GGHFMMBDFBA>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort HGPGNFEKBBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type ECPKMHHJPAA;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x812CDD0", Offset = "0x812BDD0", VA = "0x18812CDD0", Slot = "4")]
			public bool Equals(GGHFMMBDFBA EDJHHGMLKFA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x812CCE0", Offset = "0x812BCE0", VA = "0x18812CCE0", Slot = "0")]
			public override bool Equals(object PGIOEBKALDP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x812CE50", Offset = "0x812BE50", VA = "0x18812CE50", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class CNKHGFDNEMF<T> : EHNCJGFABDC, ECEEJIIMEOD<T>, GJPKPACEBLN where T : class, CGNFKEMEDPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6990410", Offset = "0x698F410", VA = "0x186990410")]
			internal CNKHGFDNEMF(int PPNEMHBOOPF, float[] HCACAEADOOH, MKMONEAHJGI MAPHDFHHMBN = MKMONEAHJGI.PlayerHead, bool CGNADOPFLCI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69903C0", Offset = "0x698F3C0", VA = "0x1869903C0", Slot = "12")]
			public void DOPEKGIEJEC(T PGIOEBKALDP, float MGJGIJAADIJ, JEHFMNHABAI LHNEAEECJOF = JEHFMNHABAI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6990390", Offset = "0x698F390", VA = "0x186990390", Slot = "13")]
			public void DOPEKGIEJEC(T PGIOEBKALDP, Transform GDECIBBBOLG, float MGJGIJAADIJ, JEHFMNHABAI LHNEAEECJOF = JEHFMNHABAI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x69903F0", Offset = "0x698F3F0", VA = "0x1869903F0", Slot = "14")]
			public void LKIPLGLLFFP(T JJAPNCKAABJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6990370", Offset = "0x698F370", VA = "0x186990370", Slot = "15")]
			public bool BAHCPFDAECJ(T PGIOEBKALDP)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class EHNCJGFABDC : IDisposable, GJPKPACEBLN
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct HAJFLFIPAMH
			{
				[Cpp2IlInjected.Token(Token = "0x2000009")]
				public enum GDGLCFMMLHI : byte
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
				public CGNFKEMEDPA PFIIBPNOJDH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform DBHNDLPLFNO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float OPLEFDPFCJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public JEHFMNHABAI GEPDHFNPDKP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public GDGLCFMMLHI HHDOJPCILPE;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public enum MKMONEAHJGI : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class AAPOODNGFFJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public CGNFKEMEDPA PFIIBPNOJDH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public JEHFMNHABAI EDCNPINKADF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action OPMGEEEFFEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool LJDOOCPGEAG;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
				public AAPOODNGFFJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int NHNOMPICMAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool CGNADOPFLCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool BFHCDNIGCPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup GPLEDHFPCLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] BEBKEDPBGHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly APONKNMGFHM JMDACFLNFAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly MKMONEAHJGI MAPHDFHHMBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<CGNFKEMEDPA, int> NILEEMAILMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, AAPOODNGFFJ> AFDAJODKLCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray FDADMBMDEFA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> GFKOKBPALBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<HAJFLFIPAMH> BCIGKJBAAHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool MCICHEJBDMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle BPLCOHHKDGG;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int DCPIGHGBJME
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA5F110", Offset = "0xA5E110", VA = "0x180A5F110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xA65550", Offset = "0xA64550", VA = "0x180A65550")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int JKEDFIBMPBH
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAB81E0", Offset = "0xAB71E0", VA = "0x180AB81E0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB3D500", Offset = "0xB3C500", VA = "0x180B3D500")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x812C800", Offset = "0x812B800", VA = "0x18812C800")]
			internal EHNCJGFABDC(int PPNEMHBOOPF, float[] HCACAEADOOH, MKMONEAHJGI MAPHDFHHMBN = MKMONEAHJGI.PlayerHead, bool CGNADOPFLCI = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x812C040", Offset = "0x812B040", VA = "0x18812C040")]
			public void KLBDMHBIJBP(bool CJMFBAFNMBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x812B030", Offset = "0x812A030", VA = "0x18812B030", Slot = "5")]
			public void DOPEKGIEJEC(CGNFKEMEDPA PGIOEBKALDP, float MGJGIJAADIJ, JEHFMNHABAI LHNEAEECJOF = JEHFMNHABAI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x812B130", Offset = "0x812A130", VA = "0x18812B130", Slot = "10")]
			public void DOPEKGIEJEC(CGNFKEMEDPA PGIOEBKALDP, Transform GDECIBBBOLG, float MGJGIJAADIJ, JEHFMNHABAI LHNEAEECJOF = JEHFMNHABAI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x812B620", Offset = "0x812A620", VA = "0x18812B620")]
			private void GFIIDOHNLAM(CGNFKEMEDPA PGIOEBKALDP, Transform GDECIBBBOLG, float MGJGIJAADIJ, JEHFMNHABAI LHNEAEECJOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x812C570", Offset = "0x812B570", VA = "0x18812C570", Slot = "6")]
			public void LKIPLGLLFFP(CGNFKEMEDPA JJAPNCKAABJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x812B8C0", Offset = "0x812A8C0", VA = "0x18812B8C0")]
			private void GOFPILEAPBD(CGNFKEMEDPA JJAPNCKAABJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x812BBA0", Offset = "0x812ABA0", VA = "0x18812BBA0")]
			private void HFGLALFAPLP(CGNFKEMEDPA PGIOEBKALDP, [Optional] float? MGJGIJAADIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x812AF70", Offset = "0x8129F70", VA = "0x18812AF70", Slot = "11")]
			public bool BAHCPFDAECJ(CGNFKEMEDPA PGIOEBKALDP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA60520", Offset = "0xA5F520", VA = "0x180A60520", Slot = "7")]
			public void ADJMAFPAHKC(CGNFKEMEDPA PGIOEBKALDP, JEHFMNHABAI FLHIMDCKLBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x812B400", Offset = "0x812A400", VA = "0x18812B400")]
			private void EFGEJKEIJAB(CGNFKEMEDPA PGIOEBKALDP, JEHFMNHABAI FLHIMDCKLBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x812C4B0", Offset = "0x812B4B0", VA = "0x18812C4B0")]
			public void LIEMJOHPAEB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x812C5E0", Offset = "0x812B5E0", VA = "0x18812C5E0")]
			public void MHIGOKBFBGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x812C1C0", Offset = "0x812B1C0", VA = "0x18812C1C0")]
			private void LHAHLEKNFEM(HAJFLFIPAMH JKODNDABGFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x812C070", Offset = "0x812B070", VA = "0x18812C070")]
			private void LEJGPCJMMAE(int ICAJGDDGLJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x812B1D0", Offset = "0x812A1D0", VA = "0x18812B1D0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x812C5D0", Offset = "0x812B5D0", VA = "0x18812C5D0")]
			private void MCACJEHLNDL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x812C7F0", Offset = "0x812B7F0", VA = "0x18812C7F0")]
			private void MIMGIDDEPDG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x812BE00", Offset = "0x812AE00", VA = "0x18812BE00")]
			private void IKNLPAMOAME(CullingGroupEvent BIHGHMLGCIK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x812B4B0", Offset = "0x812A4B0", VA = "0x18812B4B0")]
			private void EILONDLANIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ONIHMLNNEEF EFJNGOKNPIL;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static ONIHMLNNEEF BDLPFDPFJIL;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float GDBMAJKIIKL = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NJKBIOCLOMP = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float ELPBMMNHKDM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PJGAABMJNCA = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float NMPPBPGOKLI = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float HIEEEDPDEEM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float PHKHIKHNAIF = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<GGHFMMBDFBA, EHNCJGFABDC> EACONLBPMIG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable BNAPKACMEDK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable NPHLCNMDCMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LELKCPPPMEI OKKMDJOFMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LELKCPPPMEI NDEOJMPLMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly LELKCPPPMEI MNANKIOBHII;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker DFAAFJGJBAP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker NJLLLMCIKCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HHGNPNNJJPG PDCHFAJMPNF;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool CJMFBAFNMBJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LIBBMOMCAPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA68390", Offset = "0xA67390", VA = "0x180A68390", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA68440", Offset = "0xA67440", VA = "0x180A68440")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LELKCPPPMEI ABCKBOHNIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA63FE0", Offset = "0xA62FE0", VA = "0x180A63FE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LELKCPPPMEI KKDKAIEFBFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA63FC0", Offset = "0xA62FC0", VA = "0x180A63FC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public LELKCPPPMEI HCALJMIGLCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA674D0", Offset = "0xA664D0", VA = "0x180A674D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DKINADHBDMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA8DCB0", Offset = "0xA8CCB0", VA = "0x180A8DCB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool AIFLLPDOOLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD243D0", Offset = "0xD233D0", VA = "0x180D243D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xDCFD40", Offset = "0xDCED40", VA = "0x180DCFD40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8129B30", Offset = "0x8128B30", VA = "0x188129B30", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE2300", Offset = "0x7EE1300", VA = "0x187EE2300")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x812A6E0", Offset = "0x81296E0", VA = "0x18812A6E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD12B60", Offset = "0xD11B60", VA = "0x180D12B60")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x812A410", Offset = "0x8129410", VA = "0x18812A410")]
		private void NIFEDIAIEHP(Scene KJIOEGBKNOL, LoadSceneMode PBBNDGKGPAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x812A600", Offset = "0x8129600", VA = "0x18812A600", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x812A9A0", Offset = "0x81299A0", VA = "0x18812A9A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x812A0A0", Offset = "0x81290A0", VA = "0x18812A0A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x812A2A0", Offset = "0x81292A0", VA = "0x18812A2A0")]
		private void MEDDJPCKLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x812A700", Offset = "0x8129700", VA = "0x18812A700")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8129F30", Offset = "0x8128F30", VA = "0x188129F30")]
		private void IKOEILHGABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8129D50", Offset = "0x8128D50", VA = "0x188129D50")]
		public GJPKPACEBLN GetOrCreateCullingGroup(Type MENBKKGLMBG, int GANHMJAHCGA, ushort BDLFLLPHBGM = 0, bool CGNADOPFLCI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3A789C0", Offset = "0x3A779C0", VA = "0x183A789C0")]
		public ECEEJIIMEOD<T> GetOrCreateCullingGroup<T>(int GANHMJAHCGA, ushort BDLFLLPHBGM = 0, bool CGNADOPFLCI = false) where T : class, CGNFKEMEDPA
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x812A470", Offset = "0x8129470", VA = "0x18812A470")]
		private GJPKPACEBLN OIBFHKCMIKI(Type MENBKKGLMBG, int GANHMJAHCGA, float[] HCACAEADOOH, ushort BDLFLLPHBGM = 0, bool CGNADOPFLCI = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3A78A70", Offset = "0x3A77A70", VA = "0x183A78A70")]
		private ECEEJIIMEOD<T> OIBFHKCMIKI<T>(int GANHMJAHCGA, float[] HCACAEADOOH, ushort BDLFLLPHBGM = 0, bool CGNADOPFLCI = false) where T : class, CGNFKEMEDPA
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8129BF0", Offset = "0x8128BF0", VA = "0x188129BF0")]
		public static FECJOJFDCBL FindClosestDefaultUpdateLod(float CPHPPMAJMNB)
		{
			return default(FECJOJFDCBL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA8E5D0", Offset = "0xA8D5D0", VA = "0x180A8E5D0")]
		public static FECJOJFDCBL MinUpdateLod(FECJOJFDCBL LKJCGNHDJIC, FECJOJFDCBL KNOOBOJGGFL)
		{
			return default(FECJOJFDCBL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x812A400", Offset = "0x8129400", VA = "0x18812A400")]
		public static FECJOJFDCBL MaxUpdateLod(FECJOJFDCBL LKJCGNHDJIC, FECJOJFDCBL KNOOBOJGGFL)
		{
			return default(FECJOJFDCBL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x812AE20", Offset = "0x8129E20", VA = "0x18812AE20")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA8DCB0", Offset = "0xA8CCB0", VA = "0x180A8DCB0", Slot = "11")]
		private bool NGEOPDNHGCK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface APONKNMGFHM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool IMEDHPONHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera IKLEHCKGJCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LELKCPPPMEI OLJAIDCDNBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OJDJMIHDMCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LELKCPPPMEI DILLALLJDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform LGMPAEIFEMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GJPKPACEBLN
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOPEKGIEJEC(CGNFKEMEDPA PGIOEBKALDP, float MGJGIJAADIJ, JEHFMNHABAI LHNEAEECJOF = JEHFMNHABAI.Off);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKIPLGLLFFP(CGNFKEMEDPA JJAPNCKAABJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ADJMAFPAHKC(CGNFKEMEDPA PGIOEBKALDP, JEHFMNHABAI POKBJGNEOPB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ECEEJIIMEOD<T> : GJPKPACEBLN where T : class, CGNFKEMEDPA
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOPEKGIEJEC(T PGIOEBKALDP, float MGJGIJAADIJ, JEHFMNHABAI LHNEAEECJOF = JEHFMNHABAI.Off);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOPEKGIEJEC(T PGIOEBKALDP, Transform GDECIBBBOLG, float MGJGIJAADIJ, JEHFMNHABAI LHNEAEECJOF = JEHFMNHABAI.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKIPLGLLFFP(T JJAPNCKAABJ);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BAHCPFDAECJ(T PGIOEBKALDP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface CGNFKEMEDPA
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform PLPGMCABFBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FECJOJFDCBL FEONOEDNHCA, FECJOJFDCBL HEBEBNMJNIK);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool CMNHCHIKDKP);
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
