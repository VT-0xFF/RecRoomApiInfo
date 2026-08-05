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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, BHKHEGBAOJA, FAMNLLOHBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct HHOCJPIMIDK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NativeArray<BoundingSphere> JGCOLLOOLHL;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9530", Offset = "0x6FB8930", VA = "0x186FB9530", Slot = "4")]
			public void Execute(int IIACLAMOIEE, TransformAccess KELFOJAPBEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct FMEDLDGNMAE : IEquatable<FMEDLDGNMAE>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public ushort LCGGLAMBOLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public Type IDHJDAIJAKJ;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9440", Offset = "0x6FB8840", VA = "0x186FB9440", Slot = "4")]
			public bool Equals(FMEDLDGNMAE BMKPAKCEMFK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9350", Offset = "0x6FB8750", VA = "0x186FB9350", Slot = "0")]
			public override bool Equals(object NCHBKHMIMGJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6FB94C0", Offset = "0x6FB88C0", VA = "0x186FB94C0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class PIGAMIJELMK<T> : IACKPFNLIIF, MLNCGIGMDGP<T>, POJBILGPAFB where T : class, NKAHIGEFOEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4C6E540", Offset = "0x4C6D940", VA = "0x184C6E540")]
			internal PIGAMIJELMK(int CFNFECMLPMJ, float[] BGPLAHBBHHB, FBEDMNCBIMJ HHDMJKAECMC = FBEDMNCBIMJ.PlayerHead, bool JFCOAIJDCAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4C6E4F0", Offset = "0x4C6D8F0", VA = "0x184C6E4F0", Slot = "12")]
			public void EBDKDKCDLND(T NCHBKHMIMGJ, float NCJKDICMFFP, NCPKOJCDALC GHIOODFMOOM = NCPKOJCDALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4C6E4C0", Offset = "0x4C6D8C0", VA = "0x184C6E4C0", Slot = "13")]
			public void EBDKDKCDLND(T NCHBKHMIMGJ, Transform BIPKJBBLIAD, float NCJKDICMFFP, NCPKOJCDALC GHIOODFMOOM = NCPKOJCDALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4C6E4A0", Offset = "0x4C6D8A0", VA = "0x184C6E4A0", Slot = "14")]
			public void BDKJEBALGLD(T OOEOPDBEGEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4C6E520", Offset = "0x4C6D920", VA = "0x184C6E520", Slot = "15")]
			public bool GDGKNLFMPLP(T NCHBKHMIMGJ)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class IACKPFNLIIF : IDisposable, POJBILGPAFB
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct NEFJGMFGDNP
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum BKDGHBBKBKD : byte
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
				public NKAHIGEFOEF FPOFEBBOGOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public Transform DCIPDEOFAEP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public float KOFPJFICEPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public NCPKOJCDALC CMNGKOEEHDO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public BKDGHBBKBKD KBPCMAIENME;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum FBEDMNCBIMJ : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class GFNNIOBLNOF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public NKAHIGEFOEF FPOFEBBOGOJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public NCPKOJCDALC JOMLBGEALMA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public Action BECMJANOFFK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public bool HMJGAKHJHFA;

				[Cpp2IlInjected.Token(Token = "0x6000044")]
				[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
				public GFNNIOBLNOF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class DPNIFHBNJEO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public IACKPFNLIIF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				public GFNNIOBLNOF trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
				public DPNIFHBNJEO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000046")]
				[Cpp2IlInjected.Address(RVA = "0x6FB92D0", Offset = "0x6FB86D0", VA = "0x186FB92D0")]
				internal void LNMMLGHAOOI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly int FDBBIFPCBFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool JFCOAIJDCAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private bool NDHHFMKHGIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly CullingGroup KILBODCGJFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private BoundingSphere[] EDBLMPIEDJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly HFFONHFCHLJ IHMGMGMEKPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly FBEDMNCBIMJ HHDMJKAECMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<NKAHIGEFOEF, int> FNLKOFIPFCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private readonly Dictionary<int, GFNNIOBLNOF> KOODPIJJHNE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private TransformAccessArray BDAHNFLLPOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private NativeList<BoundingSphere> FMMJGFLJPGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private readonly List<NEFJGMFGDNP> JMBACEDILDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private bool FKEBHKPJBIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private JobHandle ILDCEBCINIL;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int MAMANFBCOFA
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D2190", VA = "0x1808D2D90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int CJIBCCECCNP
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA9C950", Offset = "0xA9BD50", VA = "0x180A9C950", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xA9C960", Offset = "0xA9BD60", VA = "0x180A9C960")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6FBBCD0", Offset = "0x6FBB0D0", VA = "0x186FBBCD0")]
			internal IACKPFNLIIF(int CFNFECMLPMJ, float[] BGPLAHBBHHB, FBEDMNCBIMJ HHDMJKAECMC = FBEDMNCBIMJ.PlayerHead, bool JFCOAIJDCAA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6FBAD60", Offset = "0x6FBA160", VA = "0x186FBAD60")]
			public void LMFBILKBFGN(bool DGOLCPKLMFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9F60", Offset = "0x6FB9360", VA = "0x186FB9F60", Slot = "5")]
			public void EBDKDKCDLND(NKAHIGEFOEF NCHBKHMIMGJ, float NCJKDICMFFP, NCPKOJCDALC GHIOODFMOOM = NCPKOJCDALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9EC0", Offset = "0x6FB92C0", VA = "0x186FB9EC0", Slot = "10")]
			public void EBDKDKCDLND(NKAHIGEFOEF NCHBKHMIMGJ, Transform BIPKJBBLIAD, float NCJKDICMFFP, NCPKOJCDALC GHIOODFMOOM = NCPKOJCDALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6FBB140", Offset = "0x6FBA540", VA = "0x186FBB140")]
			private void OCCDJLLMHOA(NKAHIGEFOEF NCHBKHMIMGJ, Transform BIPKJBBLIAD, float NCJKDICMFFP, NCPKOJCDALC GHIOODFMOOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6FB95B0", Offset = "0x6FB89B0", VA = "0x186FB95B0", Slot = "6")]
			public void BDKJEBALGLD(NKAHIGEFOEF OOEOPDBEGEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6FBA060", Offset = "0x6FB9460", VA = "0x186FBA060")]
			private void ELBALNIIOIC(NKAHIGEFOEF OOEOPDBEGEC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9950", Offset = "0x6FB8D50", VA = "0x186FB9950")]
			private void DPMHLFCLPLB(NKAHIGEFOEF NCHBKHMIMGJ, [Optional] float? NCJKDICMFFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6FBA4B0", Offset = "0x6FB98B0", VA = "0x186FBA4B0", Slot = "11")]
			public bool GDGKNLFMPLP(NKAHIGEFOEF NCHBKHMIMGJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6FBBC00", Offset = "0x6FBB000", VA = "0x186FBBC00", Slot = "7")]
			public void PMOIDBNIGIJ(NKAHIGEFOEF NCHBKHMIMGJ, NCPKOJCDALC HFINHDEEEIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9670", Offset = "0x6FB8A70", VA = "0x186FB9670")]
			private void DDECMHNMFFJ(NKAHIGEFOEF NCHBKHMIMGJ, NCPKOJCDALC HFINHDEEEIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6FBA570", Offset = "0x6FB9970", VA = "0x186FBA570")]
			public void IHEGFKKNOOH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9740", Offset = "0x6FB8B40", VA = "0x186FB9740")]
			public void DEJJMMNHEKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6FBAA30", Offset = "0x6FB9E30", VA = "0x186FBAA30")]
			private void LJCGLDKIBGO(NEFJGMFGDNP DGDCPDOCKCI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6FBBAB0", Offset = "0x6FBAEB0", VA = "0x186FBBAB0")]
			private void PMLKPLDMGCE(int ANJOCGBBLCD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9B90", Offset = "0x6FB8F90", VA = "0x186FB9B90", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6FBB710", Offset = "0x6FBAB10", VA = "0x186FBB710")]
			private void ONMCBMDBHJA(GFNNIOBLNOF BHBGNNMEELB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6FBA790", Offset = "0x6FB9B90", VA = "0x186FBA790")]
			private static void JEILDLNGDNH(GFNNIOBLNOF BHBGNNMEELB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6FBADA0", Offset = "0x6FBA1A0", VA = "0x186FBADA0")]
			private void NCHDCNJPEJC(GFNNIOBLNOF BHBGNNMEELB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6FBB6B0", Offset = "0x6FBAAB0", VA = "0x186FBB6B0")]
			private static void OKNKOFAOADA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6FB9610", Offset = "0x6FB8A10", VA = "0x186FB9610")]
			private static void CAKICIIOAKK(float GNOIEGLKNOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6FBAD90", Offset = "0x6FBA190", VA = "0x186FBAD90")]
			private void MBNCMDHLINE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x6FBAA20", Offset = "0x6FB9E20", VA = "0x186FBAA20")]
			private void KJEJDLBJDNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x6FBAE10", Offset = "0x6FBA210", VA = "0x186FBAE10")]
			private void NNAGIIIDNJP(CullingGroupEvent GJNLOBAAEEO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x6FBB540", Offset = "0x6FBA940", VA = "0x186FBB540")]
			private void ODGBOMPKGFH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float KFJGGAELCOE = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float ONCBFCNDALD = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float ECAIFCGDKEC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float BLJDHAFMPNI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BLDLEOGPEHF = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JBBDHKIEJPG = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float EAJGBAPBPKJ = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<FMEDLDGNMAE, IACKPFNLIIF> PMLNCJFOHIH;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable CAODABAAGML;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable PCLAIGMOKJO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static MIPKPFFHABJ HAIDOJNDAHM;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static MIPKPFFHABJ KOOFNHDNHBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MIPKPFFHABJ LMONKMIIIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MIPKPFFHABJ KPICEIHHNLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MIPKPFFHABJ OLFCHINMHHA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public static bool UseJobs;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker MGMLPOHOPAD;

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static ProfilerMarker NBEMDCENJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private GLHJGEGNDCM GKCCOCHBDCK;

		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private static bool DGOLCPKLMFP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BBLEIKONDCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8D0DA0", Offset = "0x8D01A0", VA = "0x1808D0DA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8D0DF0", Offset = "0x8D01F0", VA = "0x1808D0DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MIPKPFFHABJ IIDEMFJHNBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8C7960", Offset = "0x8C6D60", VA = "0x1808C7960", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MIPKPFFHABJ LFMONFAHCNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x8C8C70", Offset = "0x8C8070", VA = "0x1808C8C70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MIPKPFFHABJ IBGKPKHGMEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8C7970", Offset = "0x8C6D70", VA = "0x1808C7970", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DOFEHGDOEDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8F2B70", Offset = "0x8F1F70", VA = "0x1808F2B70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool OIDHMNOAGEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x942EF0", Offset = "0x9422F0", VA = "0x180942EF0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x942390", Offset = "0x941790", VA = "0x180942390")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FB7F50", Offset = "0x6FB7350", VA = "0x186FB7F50", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8B40", Offset = "0x6FB7F40", VA = "0x186FB8B40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1848DB0", Offset = "0x18481B0", VA = "0x181848DB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDD9040", Offset = "0xDD8440", VA = "0x180DD9040")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8010", Offset = "0x6FB7410", VA = "0x186FB8010")]
		private void EFBBOBKDNMF(Scene BOFPDPJECEF, LoadSceneMode BGFBLNEGPHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8A60", Offset = "0x6FB7E60", VA = "0x186FB8A60", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8D80", Offset = "0x6FB8180", VA = "0x186FB8D80")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6FB86A0", Offset = "0x6FB7AA0", VA = "0x186FB86A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6FB83B0", Offset = "0x6FB77B0", VA = "0x186FB83B0")]
		private void ICPOJDEOPBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8B60", Offset = "0x6FB7F60", VA = "0x186FB8B60")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6FB88F0", Offset = "0x6FB7CF0", VA = "0x186FB88F0")]
		private void NAPOAKHHEAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6FB81D0", Offset = "0x6FB75D0", VA = "0x186FB81D0")]
		public POJBILGPAFB GetOrCreateCullingGroup(Type MOBIPEFEMKJ, int GEBGIEBEFMO, ushort FGIDMIMJKJK = 0, bool JFCOAIJDCAA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x2E90EC0", Offset = "0x2E902C0", VA = "0x182E90EC0")]
		public MLNCGIGMDGP<T> GetOrCreateCullingGroup<T>(int GEBGIEBEFMO, ushort FGIDMIMJKJK = 0, bool JFCOAIJDCAA = false) where T : class, NKAHIGEFOEF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8510", Offset = "0x6FB7910", VA = "0x186FB8510")]
		private POJBILGPAFB KGAIKPDFJAO(Type MOBIPEFEMKJ, int GEBGIEBEFMO, float[] BGPLAHBBHHB, ushort FGIDMIMJKJK = 0, bool JFCOAIJDCAA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2E90F80", Offset = "0x2E90380", VA = "0x182E90F80")]
		private MLNCGIGMDGP<T> KGAIKPDFJAO<T>(int GEBGIEBEFMO, float[] BGPLAHBBHHB, ushort FGIDMIMJKJK = 0, bool JFCOAIJDCAA = false) where T : class, NKAHIGEFOEF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6FB8070", Offset = "0x6FB7470", VA = "0x186FB8070")]
		public static HODEOENILDN FindClosestDefaultUpdateLod(float FKOMFLKMKLA)
		{
			return default(HODEOENILDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F4160", Offset = "0x8F3560", VA = "0x1808F4160")]
		public static HODEOENILDN MinUpdateLod(HODEOENILDN ANJDLCNCHLF, HODEOENILDN NJADGMDLNMA)
		{
			return default(HODEOENILDN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FB88E0", Offset = "0x6FB7CE0", VA = "0x186FB88E0")]
		public static HODEOENILDN MaxUpdateLod(HODEOENILDN ANJDLCNCHLF, HODEOENILDN NJADGMDLNMA)
		{
			return default(HODEOENILDN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FB9180", Offset = "0x6FB8580", VA = "0x186FB9180")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F2B70", Offset = "0x8F1F70", VA = "0x1808F2B70", Slot = "11")]
		private bool HKCAABAJPPK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HFFONHFCHLJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MCNKDLICFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera LPKOKANOIHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MIPKPFFHABJ BBLFEOBNPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool OFMBNEHKNGH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MIPKPFFHABJ FHHMMPGJHHE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform KHCOMGDLLIG
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface POJBILGPAFB
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBDKDKCDLND(NKAHIGEFOEF NCHBKHMIMGJ, float NCJKDICMFFP, NCPKOJCDALC GHIOODFMOOM = NCPKOJCDALC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDKJEBALGLD(NKAHIGEFOEF OOEOPDBEGEC);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PMOIDBNIGIJ(NKAHIGEFOEF NCHBKHMIMGJ, NCPKOJCDALC HIIHBAOBODE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MLNCGIGMDGP<T> : POJBILGPAFB where T : class, NKAHIGEFOEF
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EBDKDKCDLND(T NCHBKHMIMGJ, float NCJKDICMFFP, NCPKOJCDALC GHIOODFMOOM = NCPKOJCDALC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBDKDKCDLND(T NCHBKHMIMGJ, Transform BIPKJBBLIAD, float NCJKDICMFFP, NCPKOJCDALC GHIOODFMOOM = NCPKOJCDALC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BDKJEBALGLD(T OOEOPDBEGEC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GDGKNLFMPLP(T NCHBKHMIMGJ);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NKAHIGEFOEF
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform KELFOJAPBEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(HODEOENILDN LJCAHCOMFIN, HODEOENILDN PHBLAEIFEBC);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GMHKIAOJLFJ);
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
