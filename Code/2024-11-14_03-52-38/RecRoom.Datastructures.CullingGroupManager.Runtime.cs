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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PDFFNCFJIFE
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct LNGLINPBIBP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> EIFGKHNPLEK;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6D12F00", Offset = "0x6D12300", VA = "0x186D12F00", Slot = "4")]
			public void Execute(int OBFJPFHENMC, TransformAccess JGDFNKEDOMO)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct ACFHHHOKDID : IEquatable<ACFHHHOKDID>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort KFLMJDLNDNB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type NPKFOLIHAND;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6D11A50", Offset = "0x6D10E50", VA = "0x186D11A50", Slot = "4")]
			public bool Equals(ACFHHHOKDID OGKFFDCECEL)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6D11960", Offset = "0x6D10D60", VA = "0x186D11960", Slot = "0")]
			public override bool Equals(object FAKGLFFOLFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6D11AD0", Offset = "0x6D10ED0", VA = "0x186D11AD0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class APEBLECFFBL<T> : NCGLEMMHCJH, MJAMCBLOIFA<T>, HNMHPBPNEPL where T : class, EJMLOLLHGGF
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x421B420", Offset = "0x421A820", VA = "0x18421B420")]
			internal APEBLECFFBL(int JMODAPPMNFM, float[] KIFECHAJEOJ, GIENFIBOABF LIKOCHAJKBB = GIENFIBOABF.PlayerHead, bool MEJHLOBHJCE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x421B3F0", Offset = "0x421A7F0", VA = "0x18421B3F0", Slot = "12")]
			public void FNBCENOGBNB(T FAKGLFFOLFI, float JBJFBPBLEOH, ANFACPGMLCA KGMJEBPKOCA = ANFACPGMLCA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x421B3C0", Offset = "0x421A7C0", VA = "0x18421B3C0", Slot = "13")]
			public void FNBCENOGBNB(T FAKGLFFOLFI, Transform LPIJPNFHHEA, float JBJFBPBLEOH, ANFACPGMLCA KGMJEBPKOCA = ANFACPGMLCA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x421B380", Offset = "0x421A780", VA = "0x18421B380", Slot = "14")]
			public void BIJNEFLCHFA(T IECFICFNKDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x421B3A0", Offset = "0x421A7A0", VA = "0x18421B3A0", Slot = "15")]
			public bool EHMDELLFCLE(T FAKGLFFOLFI)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class NCGLEMMHCJH : IDisposable, HNMHPBPNEPL
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct DPGFHCABLLH
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum LIINHNJFHFM : byte
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
				public EJMLOLLHGGF LCJKLBHDHIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform IMDABJDPEJO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float JOFDGLPGGDF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public ANFACPGMLCA PFFAFHIMOJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public LIINHNJFHFM LLHMNEIJLPP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum GIENFIBOABF : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class PEOPIIEFEIL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public EJMLOLLHGGF LCJKLBHDHIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public ANFACPGMLCA HBGDEGBBHJM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action HEKJNONNONF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool PEDKEBAHNJJ;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
				public PEOPIIEFEIL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class KAALEKOPIKL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public NCGLEMMHCJH <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public PEOPIIEFEIL trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
				public KAALEKOPIKL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x6D12E80", Offset = "0x6D12280", VA = "0x186D12E80")]
				internal void GMNGFPIINNN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int FFMIFKEEDNO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool MEJHLOBHJCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool MPIODIOKEMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup FCFDLFLDHJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] GIEFCCPBIIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly KNHBCAJCKOM OJNJHJENDCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly GIENFIBOABF LIKOCHAJKBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<EJMLOLLHGGF, int> JKJPMLOCKMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, PEOPIIEFEIL> FBJFGKPJNOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray JIMEDHGMADI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> APHGBPJONIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<DPGFHCABLLH> GCJMHKFLDKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool BBIOKMPICOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle NCIJHBALCJA;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int AHKBIIDHGAA
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int ILIJOJBMIHO
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0xA02AE0", Offset = "0xA01EE0", VA = "0x180A02AE0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xA02AF0", Offset = "0xA01EF0", VA = "0x180A02AF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6D156E0", Offset = "0x6D14AE0", VA = "0x186D156E0")]
			internal NCGLEMMHCJH(int JMODAPPMNFM, float[] KIFECHAJEOJ, GIENFIBOABF LIKOCHAJKBB = GIENFIBOABF.PlayerHead, bool MEJHLOBHJCE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6D136D0", Offset = "0x6D12AD0", VA = "0x186D136D0")]
			public void FCNDDAJAOHG(bool FNMNDADODKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6D13910", Offset = "0x6D12D10", VA = "0x186D13910", Slot = "5")]
			public void FNBCENOGBNB(EJMLOLLHGGF FAKGLFFOLFI, float JBJFBPBLEOH, ANFACPGMLCA KGMJEBPKOCA = ANFACPGMLCA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6D13870", Offset = "0x6D12C70", VA = "0x186D13870", Slot = "10")]
			public void FNBCENOGBNB(EJMLOLLHGGF FAKGLFFOLFI, Transform LPIJPNFHHEA, float JBJFBPBLEOH, ANFACPGMLCA KGMJEBPKOCA = ANFACPGMLCA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6D14310", Offset = "0x6D13710", VA = "0x186D14310")]
			private void INGANNHOEDD(EJMLOLLHGGF FAKGLFFOLFI, Transform LPIJPNFHHEA, float JBJFBPBLEOH, ANFACPGMLCA KGMJEBPKOCA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6D12F80", Offset = "0x6D12380", VA = "0x186D12F80", Slot = "6")]
			public void BIJNEFLCHFA(EJMLOLLHGGF IECFICFNKDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6D13A70", Offset = "0x6D12E70", VA = "0x186D13A70")]
			private void GOILBMBFKFJ(EJMLOLLHGGF IECFICFNKDJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6D13EC0", Offset = "0x6D132C0", VA = "0x186D13EC0")]
			private void HBILMJMCPLJ(EJMLOLLHGGF FAKGLFFOLFI, [Optional] float? JBJFBPBLEOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6D133F0", Offset = "0x6D127F0", VA = "0x186D133F0", Slot = "11")]
			public bool EHMDELLFCLE(EJMLOLLHGGF FAKGLFFOLFI)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6D149D0", Offset = "0x6D13DD0", VA = "0x186D149D0", Slot = "7")]
			public void LKMMANBBCDD(EJMLOLLHGGF FAKGLFFOLFI, ANFACPGMLCA ELPOJFNBIEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6D12FE0", Offset = "0x6D123E0", VA = "0x186D12FE0")]
			private void BPHNFIBFCMJ(EJMLOLLHGGF FAKGLFFOLFI, ANFACPGMLCA ELPOJFNBIEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6D134B0", Offset = "0x6D128B0", VA = "0x186D134B0")]
			public void EHPIDHDHEFC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6D14100", Offset = "0x6D13500", VA = "0x186D14100")]
			public void HLPDEBDLPDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6D14F30", Offset = "0x6D14330", VA = "0x186D14F30")]
			private void PFEDNLNKHIO(DPGFHCABLLH JPCJICGNBND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6D15590", Offset = "0x6D14990", VA = "0x186D15590")]
			private void PNEIKEMFJLE(int KOAMIEHPLIF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6D130C0", Offset = "0x6D124C0", VA = "0x186D130C0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6D14AA0", Offset = "0x6D13EA0", VA = "0x186D14AA0")]
			private void MCAEFGIHAJO(PEOPIIEFEIL ELALPGOOLPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6D14710", Offset = "0x6D13B10", VA = "0x186D14710")]
			private static void LADAPCFMJBI(PEOPIIEFEIL ELALPGOOLPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6D14EC0", Offset = "0x6D142C0", VA = "0x186D14EC0")]
			private void OGPBOBLNJCH(PEOPIIEFEIL ELALPGOOLPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6D14E60", Offset = "0x6D14260", VA = "0x186D14E60")]
			private static void OBFIEDOIOJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6D13A10", Offset = "0x6D12E10", VA = "0x186D13A10")]
			private static void GDNOIBMLANK(float FDMAJNEEBEL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6D14E50", Offset = "0x6D14250", VA = "0x186D14E50")]
			private void NJNAJPGHBOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6D130B0", Offset = "0x6D124B0", VA = "0x186D130B0")]
			private void DMCINFLDHOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6D15260", Offset = "0x6D14660", VA = "0x186D15260")]
			private void PKBJKFIJDPC(CullingGroupEvent HCLPCKBPEFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6D13700", Offset = "0x6D12B00", VA = "0x186D13700")]
			private void FKPLJMPFGOI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float HPNMPGPNLLK = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float MMJKGOMPHGE = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float CMLCHPOBIJF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float DEKMDDFDPPJ = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float IPPOCBBNNNM = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float BNBLBLGIKID = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float NCNJLBNKNBN = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<ACFHHHOKDID, NCGLEMMHCJH> IAEAGEFAIBD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable DAHFOOFCLCD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EBABBHLFAHJ;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static BDDIJCFMLKF JFMFANLOBCG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static BDDIJCFMLKF NDPMAIIBPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly BDDIJCFMLKF HOLOADAPPPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly BDDIJCFMLKF CDIMHDLEEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BDDIJCFMLKF FPDOBMLAIFA;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool UseJobs;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker OJEOCGDEDAN;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker EBGNBJGNOLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IDFKLKAPHIN BFJLJICEKPH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool FNMNDADODKG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BDDIJCFMLKF EODBBOBBJIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BDDIJCFMLKF GNCJHKICNOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BDDIJCFMLKF ABENLHGLBIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool NILKMNDFNCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x979F90", Offset = "0x979390", VA = "0x180979F90", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JNDBDEMGHNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x979FA0", Offset = "0x9793A0", VA = "0x180979FA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x979B50", Offset = "0x978F50", VA = "0x180979B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6D11B40", Offset = "0x6D10F40", VA = "0x186D11B40", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D12580", Offset = "0x6D11980", VA = "0x186D12580")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6D12560", Offset = "0x6D11960", VA = "0x186D12560")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6D11EC0", Offset = "0x6D112C0", VA = "0x186D11EC0")]
		private void GKFLADLDFKK(Scene JFMDCCFECCK, LoadSceneMode CFINOJHBLLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6D12480", Offset = "0x6D11880", VA = "0x186D12480", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D12960", Offset = "0x6D11D60", VA = "0x186D12960")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6D12270", Offset = "0x6D11670", VA = "0x186D12270")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6D11C00", Offset = "0x6D11000", VA = "0x186D11C00")]
		private void CAIJPGOABNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6D12730", Offset = "0x6D11B30", VA = "0x186D12730")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D12100", Offset = "0x6D11500", VA = "0x186D12100")]
		private void IMPOLPDJMJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D11F20", Offset = "0x6D11320", VA = "0x186D11F20")]
		public HNMHPBPNEPL GetOrCreateCullingGroup(Type FCAOMIDFDCD, int LBDHMPONDAH, ushort FOLFPNDFAHH = 0, bool MEJHLOBHJCE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCE00", Offset = "0x2CDC200", VA = "0x182CDCE00")]
		public MJAMCBLOIFA<T> GetOrCreateCullingGroup<T>(int LBDHMPONDAH, ushort FOLFPNDFAHH = 0, bool MEJHLOBHJCE = false) where T : class, EJMLOLLHGGF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D125A0", Offset = "0x6D119A0", VA = "0x186D125A0")]
		private HNMHPBPNEPL PKLHFKPHHFB(Type FCAOMIDFDCD, int LBDHMPONDAH, float[] KIFECHAJEOJ, ushort FOLFPNDFAHH = 0, bool MEJHLOBHJCE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2CDCEC0", Offset = "0x2CDC2C0", VA = "0x182CDCEC0")]
		private MJAMCBLOIFA<T> PKLHFKPHHFB<T>(int LBDHMPONDAH, float[] KIFECHAJEOJ, ushort FOLFPNDFAHH = 0, bool MEJHLOBHJCE = false) where T : class, EJMLOLLHGGF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6D11D60", Offset = "0x6D11160", VA = "0x186D11D60")]
		public static IHJDLPBPHOK FindClosestDefaultUpdateLod(float BJNADLMKIIA)
		{
			return default(IHJDLPBPHOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DC0", Offset = "0x8C81C0", VA = "0x1808C8DC0")]
		public static IHJDLPBPHOK MinUpdateLod(IHJDLPBPHOK ACLOBCLBLMB, IHJDLPBPHOK DPNHGIKBFKM)
		{
			return default(IHJDLPBPHOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D12470", Offset = "0x6D11870", VA = "0x186D12470")]
		public static IHJDLPBPHOK MaxUpdateLod(IHJDLPBPHOK ACLOBCLBLMB, IHJDLPBPHOK DPNHGIKBFKM)
		{
			return default(IHJDLPBPHOK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6D12D30", Offset = "0x6D12130", VA = "0x186D12D30")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface KNHBCAJCKOM
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool INJMJMMAEGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera AIHHHPPIBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	BDDIJCFMLKF BGGBHFALKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EKIBPCDIIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	BDDIJCFMLKF EHLBFCDHEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform MAIJLPHHIBF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HNMHPBPNEPL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNBCENOGBNB(EJMLOLLHGGF FAKGLFFOLFI, float JBJFBPBLEOH, ANFACPGMLCA KGMJEBPKOCA = ANFACPGMLCA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIJNEFLCHFA(EJMLOLLHGGF IECFICFNKDJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKMMANBBCDD(EJMLOLLHGGF FAKGLFFOLFI, ANFACPGMLCA NBANJHKGLKM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface MJAMCBLOIFA<T> : HNMHPBPNEPL where T : class, EJMLOLLHGGF
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNBCENOGBNB(T FAKGLFFOLFI, float JBJFBPBLEOH, ANFACPGMLCA KGMJEBPKOCA = ANFACPGMLCA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FNBCENOGBNB(T FAKGLFFOLFI, Transform LPIJPNFHHEA, float JBJFBPBLEOH, ANFACPGMLCA KGMJEBPKOCA = ANFACPGMLCA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BIJNEFLCHFA(T IECFICFNKDJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EHMDELLFCLE(T FAKGLFFOLFI);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EJMLOLLHGGF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform JGDFNKEDOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(IHJDLPBPHOK LCGLMMBJDEL, IHJDLPBPHOK HLJFBPAIAOD);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool ALGCKDBOIEI);
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
