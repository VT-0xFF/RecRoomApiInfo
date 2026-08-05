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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, ANFPAPNNIFP, ONOIHDMEOKA
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct OADMLADLKHG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NativeArray<BoundingSphere> LFDKFEEPNFP;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x71E6CC0", Offset = "0x71E5EC0", VA = "0x1871E6CC0", Slot = "4")]
			public void Execute(int CPLNODNGKGB, TransformAccess MCPAEAAAAAM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct IMKCJEMOHDD : IEquatable<IMKCJEMOHDD>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ushort NLNPNJALJHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Type PNNKMHJAACJ;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x71E6BD0", Offset = "0x71E5DD0", VA = "0x1871E6BD0", Slot = "4")]
			public bool Equals(IMKCJEMOHDD JAINJPLCLDO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x71E6AE0", Offset = "0x71E5CE0", VA = "0x1871E6AE0", Slot = "0")]
			public override bool Equals(object LCACGJDNDHA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x71E6C50", Offset = "0x71E5E50", VA = "0x1871E6C50", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class GLAKJAOOKAA<T> : AKHIHCGKDII, EJMLBMGJBCP<T>, FNBLBCIINCH where T : class, AADLJHJNJJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x445BFB0", Offset = "0x445B1B0", VA = "0x18445BFB0")]
			internal GLAKJAOOKAA(int NLBJGFFJBOB, float[] CJNGOMDGGGK, HABECFLGOID KKBOGPFIKJD = HABECFLGOID.PlayerHead, bool MBDLFHCAFOE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x445BF10", Offset = "0x445B110", VA = "0x18445BF10", Slot = "12")]
			public void CKLHJOINNOK(T LCACGJDNDHA, float COBBNHPDFBH, NEGICDPELDL HFMCOPOHOGF = NEGICDPELDL.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x445BF40", Offset = "0x445B140", VA = "0x18445BF40", Slot = "13")]
			public void CKLHJOINNOK(T LCACGJDNDHA, Transform OHGPEOCLNML, float COBBNHPDFBH, NEGICDPELDL HFMCOPOHOGF = NEGICDPELDL.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x445BF70", Offset = "0x445B170", VA = "0x18445BF70", Slot = "14")]
			public void GMODDBABBFK(T FIBCHAPHPJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x445BF90", Offset = "0x445B190", VA = "0x18445BF90", Slot = "15")]
			public bool LBKAHOMODEB(T LCACGJDNDHA)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class AKHIHCGKDII : IDisposable, FNBLBCIINCH
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct OHOMAOOIBDH
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum DCJEDJEIGON : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000036")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public AADLJHJNJJK COLLFNBHNEO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public Transform JICGKLMMHCG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public float LCLNBBEBIBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public NEGICDPELDL ELCJEMALBEE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public DCJEDJEIGON BLFPNJPCADF;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum HABECFLGOID : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class NOPNNJMEJEI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public AADLJHJNJJK COLLFNBHNEO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public NEGICDPELDL OAJOFPFMLKE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public Action HMOKEBCMGOC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public bool JCEIHCMAMBO;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
				public NOPNNJMEJEI()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class CDBOCDKKCOP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public AKHIHCGKDII <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				public NOPNNJMEJEI trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
				public CDBOCDKKCOP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x71E5740", Offset = "0x71E4940", VA = "0x1871E5740")]
				internal void EFLANMCCIEE()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly int AOACOFFBGKJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool MBDLFHCAFOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private bool CLAMDNBMMAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly CullingGroup IFJPGLDOEFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private BoundingSphere[] FHHCEGGIPGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly DICLOKBIGIG CKNLAJJPLCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly HABECFLGOID KKBOGPFIKJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<AADLJHJNJJK, int> HOLCEGJKMOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly Dictionary<int, NOPNNJMEJEI> ADJDJAIOOAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TransformAccessArray CPHPPNLCLJO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private NativeList<BoundingSphere> PJNAOONGCMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<OHOMAOOIBDH> DDBEPEBAMPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private bool JCMFMJLDKPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private JobHandle DLGFKNLCAHD;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int HDCAINGGHJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x8F21A0", Offset = "0x8F13A0", VA = "0x1808F21A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8FEBC0", Offset = "0x8FDDC0", VA = "0x1808FEBC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int PJGHLEDEJHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA3D4D0", Offset = "0xA3C6D0", VA = "0x180A3D4D0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB32D40", Offset = "0xB31F40", VA = "0x180B32D40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x71E5260", Offset = "0x71E4460", VA = "0x1871E5260")]
			internal AKHIHCGKDII(int NLBJGFFJBOB, float[] CJNGOMDGGGK, HABECFLGOID KKBOGPFIKJD = HABECFLGOID.PlayerHead, bool MBDLFHCAFOE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x71E3C70", Offset = "0x71E2E70", VA = "0x1871E3C70")]
			public void EGABFLINKNE(bool DKNDJLELOCP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x71E3440", Offset = "0x71E2640", VA = "0x1871E3440", Slot = "5")]
			public void CKLHJOINNOK(AADLJHJNJJK LCACGJDNDHA, float COBBNHPDFBH, NEGICDPELDL HFMCOPOHOGF = NEGICDPELDL.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x71E33A0", Offset = "0x71E25A0", VA = "0x1871E33A0", Slot = "10")]
			public void CKLHJOINNOK(AADLJHJNJJK LCACGJDNDHA, Transform OHGPEOCLNML, float COBBNHPDFBH, NEGICDPELDL HFMCOPOHOGF = NEGICDPELDL.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x71E3870", Offset = "0x71E2A70", VA = "0x1871E3870")]
			private void EEGAACPLPFH(AADLJHJNJJK LCACGJDNDHA, Transform OHGPEOCLNML, float COBBNHPDFBH, NEGICDPELDL HFMCOPOHOGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x71E4280", Offset = "0x71E3480", VA = "0x1871E4280", Slot = "6")]
			public void GMODDBABBFK(AADLJHJNJJK FIBCHAPHPJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x71E2AF0", Offset = "0x71E1CF0", VA = "0x1871E2AF0")]
			private void BFJOJFPFLOM(AADLJHJNJJK FIBCHAPHPJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x71E2F40", Offset = "0x71E2140", VA = "0x1871E2F40")]
			private void BHIEBBPOBND(AADLJHJNJJK LCACGJDNDHA, [Optional] float? COBBNHPDFBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x71E4350", Offset = "0x71E3550", VA = "0x1871E4350", Slot = "11")]
			public bool LBKAHOMODEB(AADLJHJNJJK LCACGJDNDHA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x71E4BC0", Offset = "0x71E3DC0", VA = "0x1871E4BC0", Slot = "7")]
			public void NELLJHEIAFB(AADLJHJNJJK LCACGJDNDHA, NEGICDPELDL IIEJHALPCKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x71E4C90", Offset = "0x71E3E90", VA = "0x1871E4C90")]
			private void NKNGKOIIBKN(AADLJHJNJJK LCACGJDNDHA, NEGICDPELDL IIEJHALPCKH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71E3CA0", Offset = "0x71E2EA0", VA = "0x1871E3CA0")]
			public void GEHNFOKDANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x71E3190", Offset = "0x71E2390", VA = "0x1871E3190")]
			public void CHDOJEFINPA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x71E4ED0", Offset = "0x71E40D0", VA = "0x1871E4ED0")]
			private void OONPGAIOGJO(OHOMAOOIBDH FDEJAKKFLHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x71E46D0", Offset = "0x71E38D0", VA = "0x1871E46D0")]
			private void MAMFABMCBDH(int GFLDHPCEABD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x71E3540", Offset = "0x71E2740", VA = "0x1871E3540", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x71E3EC0", Offset = "0x71E30C0", VA = "0x1871E3EC0")]
			private void GLMPPILBMML(NOPNNJMEJEI GLMCEJHNMAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x71E4410", Offset = "0x71E3610", VA = "0x1871E4410")]
			private static void LMLLMHBCDMH(NOPNNJMEJEI GLMCEJHNMAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x71E4820", Offset = "0x71E3A20", VA = "0x1871E4820")]
			private void MMOEEJKNPGO(NOPNNJMEJEI GLMCEJHNMAL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x71E5200", Offset = "0x71E4400", VA = "0x1871E5200")]
			private static void PFONOFECPKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x71E42E0", Offset = "0x71E34E0", VA = "0x1871E42E0")]
			private static void JKBDFKKJAGL(float NIMHBLEHMBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x71E3180", Offset = "0x71E2380", VA = "0x1871E3180")]
			private void CFAPBBKBGKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x71E4340", Offset = "0x71E3540", VA = "0x1871E4340")]
			private void LBFFACAEHAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x71E4890", Offset = "0x71E3A90", VA = "0x1871E4890")]
			private void MNBIJCOIBGL(CullingGroupEvent DKEEJILOAMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x71E4D60", Offset = "0x71E3F60", VA = "0x1871E4D60")]
			private void OMPLJKJOLJK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float KHODMLMPMEL = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float IDBEHLIDDOG = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float KEHDACCDDEK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float LBJFHCMHKGC = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float DMPCKNNMHAG = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float BGNEKJGBDNF = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float LCAFFNNJEEP = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<IMKCJEMOHDD, AKHIHCGKDII> DCFLOOPAGKB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable HBIOJJHDBBJ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable FHOJJBABEAF;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static AEJLNDNFINA HAAMLNECEOD;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static AEJLNDNFINA KNBKGOAJPHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly AEJLNDNFINA AFLBBGPJPKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly AEJLNDNFINA PEMJKJPCDLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly AEJLNDNFINA HEMNJNHPLIN;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static bool UseJobs;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker EEBJNOKNAOO;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static ProfilerMarker FGLMICGEAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private GFDHFLBBFKF ILNPOCHLOEG;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static bool DKNDJLELOCP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool AJJHDKJICFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0D0", Offset = "0x8FA2D0", VA = "0x1808FB0D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8FB090", Offset = "0x8FA290", VA = "0x1808FB090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public AEJLNDNFINA FBJEIBHECPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8F85D0", Offset = "0x8F77D0", VA = "0x1808F85D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public AEJLNDNFINA OIDOOIMMNOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8F4D20", Offset = "0x8F3F20", VA = "0x1808F4D20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AEJLNDNFINA COIPEHHNJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8FB0E0", Offset = "0x8FA2E0", VA = "0x1808FB0E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ONMKEEDCDJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x920810", Offset = "0x91FA10", VA = "0x180920810", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool EIOCMOMCNDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xABD7A0", Offset = "0xABC9A0", VA = "0x180ABD7A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xB35480", Offset = "0xB34680", VA = "0x180B35480")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71E57C0", Offset = "0x71E49C0", VA = "0x1871E57C0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x71E6370", Offset = "0x71E5570", VA = "0x1871E6370")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1BC74B0", Offset = "0x1BC66B0", VA = "0x181BC74B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA85040", Offset = "0xA84240", VA = "0x180A85040")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x71E6220", Offset = "0x71E5420", VA = "0x1871E6220")]
		private void MJIFBAOAFPD(Scene PLMFADGOOMM, LoadSceneMode EKEGOHBHLFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x71E6290", Offset = "0x71E5490", VA = "0x1871E6290", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71E65C0", Offset = "0x71E57C0", VA = "0x1871E65C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x71E6020", Offset = "0x71E5220", VA = "0x1871E6020")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71E5D30", Offset = "0x71E4F30", VA = "0x1871E5D30")]
		private void IGMHJJDNHJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71E6390", Offset = "0x71E5590", VA = "0x1871E6390")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71E5880", Offset = "0x71E4A80", VA = "0x1871E5880")]
		private void CGACBFPNELN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x71E5B50", Offset = "0x71E4D50", VA = "0x1871E5B50")]
		public FNBLBCIINCH GetOrCreateCullingGroup(Type ELPGHBGOEBH, int ACKHDFKHJBI, ushort FNAHJKHKIIE = 0, bool MBDLFHCAFOE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x30EA090", Offset = "0x30E9290", VA = "0x1830EA090")]
		public EJMLBMGJBCP<T> GetOrCreateCullingGroup<T>(int ACKHDFKHJBI, ushort FNAHJKHKIIE = 0, bool MBDLFHCAFOE = false) where T : class, AADLJHJNJJK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71E5E90", Offset = "0x71E5090", VA = "0x1871E5E90")]
		private FNBLBCIINCH LDLCHCIDGNO(Type ELPGHBGOEBH, int ACKHDFKHJBI, float[] CJNGOMDGGGK, ushort FNAHJKHKIIE = 0, bool MBDLFHCAFOE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x30EA150", Offset = "0x30E9350", VA = "0x1830EA150")]
		private EJMLBMGJBCP<T> LDLCHCIDGNO<T>(int ACKHDFKHJBI, float[] CJNGOMDGGGK, ushort FNAHJKHKIIE = 0, bool MBDLFHCAFOE = false) where T : class, AADLJHJNJJK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71E59F0", Offset = "0x71E4BF0", VA = "0x1871E59F0")]
		public static MICCOKKHGKO FindClosestDefaultUpdateLod(float DGAIDAKPAFO)
		{
			return default(MICCOKKHGKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x920FB0", Offset = "0x9201B0", VA = "0x180920FB0")]
		public static MICCOKKHGKO MinUpdateLod(MICCOKKHGKO HEKIFCDANOO, MICCOKKHGKO APCOKBBFJKG)
		{
			return default(MICCOKKHGKO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71E6280", Offset = "0x71E5480", VA = "0x1871E6280")]
		public static MICCOKKHGKO MaxUpdateLod(MICCOKKHGKO HEKIFCDANOO, MICCOKKHGKO APCOKBBFJKG)
		{
			return default(MICCOKKHGKO);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x71E6990", Offset = "0x71E5B90", VA = "0x1871E6990")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x920810", Offset = "0x91FA10", VA = "0x180920810", Slot = "11")]
		private bool LCNMGJMBHCF()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DICLOKBIGIG
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LMPAACMPANN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera AIBPIKKKAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	AEJLNDNFINA OFBLJBKKGGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool FPIMEJONMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	AEJLNDNFINA FPPNAHDNCGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform DONMOMFEBPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FNBLBCIINCH
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKLHJOINNOK(AADLJHJNJJK LCACGJDNDHA, float COBBNHPDFBH, NEGICDPELDL HFMCOPOHOGF = NEGICDPELDL.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GMODDBABBFK(AADLJHJNJJK FIBCHAPHPJI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NELLJHEIAFB(AADLJHJNJJK LCACGJDNDHA, NEGICDPELDL BECDMILEFGN);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EJMLBMGJBCP<T> : FNBLBCIINCH where T : class, AADLJHJNJJK
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKLHJOINNOK(T LCACGJDNDHA, float COBBNHPDFBH, NEGICDPELDL HFMCOPOHOGF = NEGICDPELDL.Off);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKLHJOINNOK(T LCACGJDNDHA, Transform OHGPEOCLNML, float COBBNHPDFBH, NEGICDPELDL HFMCOPOHOGF = NEGICDPELDL.Off);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GMODDBABBFK(T FIBCHAPHPJI);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LBKAHOMODEB(T LCACGJDNDHA);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AADLJHJNJJK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform MCPAEAAAAAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MICCOKKHGKO FEFDOAKPMBJ, MICCOKKHGKO DAEFLBNGHOM);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool DGANKCELALD);
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
