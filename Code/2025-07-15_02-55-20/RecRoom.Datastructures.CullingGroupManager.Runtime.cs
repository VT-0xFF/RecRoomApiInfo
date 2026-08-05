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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, PAHIIACJDAI, HKJBNPOGLFP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct BKDILEMCCDJ : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> CBCNBAPLLJM;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x80B6270", Offset = "0x80B4E70", VA = "0x1880B6270", Slot = "4")]
			public void Execute(int LCCBBMBENOH, TransformAccess LMGPODOPMIJ)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct LKMCKNBJKCG : IEquatable<LKMCKNBJKCG>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort AOABAPDBNAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type ACKPCCKLDFD;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x80B9960", Offset = "0x80B8560", VA = "0x1880B9960", Slot = "4")]
			public bool Equals(LKMCKNBJKCG IIOGPDPGOLB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x80B9870", Offset = "0x80B8470", VA = "0x1880B9870", Slot = "0")]
			public override bool Equals(object KOJLNGLNBMH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x80B99E0", Offset = "0x80B85E0", VA = "0x1880B99E0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class MBIEHJNGENH<T> : FDADLKMKEGG, HOLLKCILJEI<T>, DOKHKFPJPGF where T : class, FPMLDBOMIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x564C0A0", Offset = "0x564ACA0", VA = "0x18564C0A0")]
			internal MBIEHJNGENH(int OAIFCPDMEGB, float[] JKDKBMPFKCP, MBFDMLFAKBN CPBMOJAHLPL = MBFDMLFAKBN.PlayerHead, bool NBNOGHHMMDH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x564C050", Offset = "0x564AC50", VA = "0x18564C050", Slot = "12")]
			public void NDGLNAHKHEG(T KOJLNGLNBMH, float BNDEJLLMNLK, CFBMCAPEOOJ FKMLMPMPBPH = CFBMCAPEOOJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x564C020", Offset = "0x564AC20", VA = "0x18564C020", Slot = "13")]
			public void NDGLNAHKHEG(T KOJLNGLNBMH, Transform HIFEDDBKMHN, float BNDEJLLMNLK, CFBMCAPEOOJ FKMLMPMPBPH = CFBMCAPEOOJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x564C000", Offset = "0x564AC00", VA = "0x18564C000", Slot = "14")]
			public void ENKPLOICKCM(T DOKCCDMGLHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x564C080", Offset = "0x564AC80", VA = "0x18564C080", Slot = "15")]
			public bool OAFIKPJOCCP(T KOJLNGLNBMH)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class FDADLKMKEGG : IDisposable, DOKHKFPJPGF
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct KDHAMANHGNM
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum NKGGECKNEKI : byte
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
				public FPMLDBOMIMK ACNBOEGLBCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform AJOIPBDPHOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float INHNPLLHFOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public CFBMCAPEOOJ GAHMOOFOCDE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public NKGGECKNEKI GJCIAOMMHGH;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum MBFDMLFAKBN : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class CLKDGIJKACF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public FPMLDBOMIMK ACNBOEGLBCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public CFBMCAPEOOJ EKACOIMCABA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action KHBFCNNDEHF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool DKMMFNFMDJG;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
				public CLKDGIJKACF()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int FIDAAGJHPMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool NBNOGHHMMDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool KBLIMDOOPKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup JLAJCFDPBBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] ICHEIAGJANF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly DIGAGDHHHNF FFBAIGJFNPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly MBFDMLFAKBN CPBMOJAHLPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<FPMLDBOMIMK, int> FHBEEIGNIEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, CLKDGIJKACF> PCKOAHAPOLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray BFDAJFNHHGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> BLMHLNIEMDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<KDHAMANHGNM> FNOFDAIHIHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool KHKBKNKJKBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle GPAFPAOOIJM;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int OOFFKLDEEJN
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xA5B110", Offset = "0xA59D10", VA = "0x180A5B110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xA5C7B0", Offset = "0xA5B3B0", VA = "0x180A5C7B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int LHACELPNJFP
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAB4D50", Offset = "0xAB3950", VA = "0x180AB4D50", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB31C80", Offset = "0xB30880", VA = "0x180B31C80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x80B9390", Offset = "0x80B7F90", VA = "0x1880B9390")]
			internal FDADLKMKEGG(int OAIFCPDMEGB, float[] JKDKBMPFKCP, MBFDMLFAKBN CPBMOJAHLPL = MBFDMLFAKBN.PlayerHead, bool NBNOGHHMMDH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x80B80C0", Offset = "0x80B6CC0", VA = "0x1880B80C0")]
			public void EMKKCLIALAI(bool NCBIFKMHDAB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x80B8A10", Offset = "0x80B7610", VA = "0x1880B8A10", Slot = "5")]
			public void NDGLNAHKHEG(FPMLDBOMIMK KOJLNGLNBMH, float BNDEJLLMNLK, CFBMCAPEOOJ FKMLMPMPBPH = CFBMCAPEOOJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x80B8970", Offset = "0x80B7570", VA = "0x1880B8970", Slot = "10")]
			public void NDGLNAHKHEG(FPMLDBOMIMK KOJLNGLNBMH, Transform HIFEDDBKMHN, float BNDEJLLMNLK, CFBMCAPEOOJ FKMLMPMPBPH = CFBMCAPEOOJ.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x80B7A90", Offset = "0x80B6690", VA = "0x1880B7A90")]
			private void CLDDEBGINBI(FPMLDBOMIMK KOJLNGLNBMH, Transform HIFEDDBKMHN, float BNDEJLLMNLK, CFBMCAPEOOJ FKMLMPMPBPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x80B80F0", Offset = "0x80B6CF0", VA = "0x1880B80F0", Slot = "6")]
			public void ENKPLOICKCM(FPMLDBOMIMK DOKCCDMGLHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x80B8D20", Offset = "0x80B7920", VA = "0x1880B8D20")]
			private void OCAGGIBKBEG(FPMLDBOMIMK DOKCCDMGLHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x80B8710", Offset = "0x80B7310", VA = "0x1880B8710")]
			private void KPNOHDDKPAC(FPMLDBOMIMK KOJLNGLNBMH, [Optional] float? BNDEJLLMNLK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x80B8C60", Offset = "0x80B7860", VA = "0x1880B8C60", Slot = "11")]
			public bool OAFIKPJOCCP(FPMLDBOMIMK KOJLNGLNBMH)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "7")]
			public void CIFIJNDLLJJ(FPMLDBOMIMK KOJLNGLNBMH, CFBMCAPEOOJ JCOOMNDFNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x80B8660", Offset = "0x80B7260", VA = "0x1880B8660")]
			private void KKJHBIFKFFE(FPMLDBOMIMK KOJLNGLNBMH, CFBMCAPEOOJ JCOOMNDFNNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x80B9160", Offset = "0x80B7D60", VA = "0x1880B9160")]
			public void OHPDIKOFMFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x80B8160", Offset = "0x80B6D60", VA = "0x1880B8160")]
			public void GIDKBOBDIGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x80B8370", Offset = "0x80B6F70", VA = "0x1880B8370")]
			private void IKFLLOFMBKF(KDHAMANHGNM FBNAMAEDFNA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x80B8B10", Offset = "0x80B7710", VA = "0x1880B8B10")]
			private void OAEDCKGPCEJ(int HMEOHLIMBNN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x80B7E90", Offset = "0x80B6A90", VA = "0x1880B7E90", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x80B8150", Offset = "0x80B6D50", VA = "0x1880B8150")]
			private void EOPGLIHJIDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x80B7E80", Offset = "0x80B6A80", VA = "0x1880B7E80")]
			private void DEJMEJLBEOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x80B7760", Offset = "0x80B6360", VA = "0x1880B7760")]
			private void ACIFFPMJINJ(CullingGroupEvent CIBPLNEFMHE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x80B9220", Offset = "0x80B7E20", VA = "0x1880B9220")]
			private void PPLENMFCPJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float LHMOIGPBJKE = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float INDPJJJNEPB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float DMEOFEEBPAL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float KIAEGONFNJJ = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float NJHPNEFJJMN = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float KOFHMNNMMOI = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float BBOPNPBCPHI = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<LKMCKNBJKCG, FDADLKMKEGG> DKLBCPOMNIL;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable IOGJEINMPHF;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LJLPOCJFMAI;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static LKKDMOCNJPN PCEOMIBKLKK;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static LKKDMOCNJPN EAIMEOKACDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LKKDMOCNJPN CGCOHIEMOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LKKDMOCNJPN BCGJAHAHKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly LKKDMOCNJPN LJKDPLLDLOD;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker BLMPPKBCPBK;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker KHNLAEJEMDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private CCGDPHBOCPE CHJLBNFDFFH;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool NCBIFKMHDAB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool LODEDLFDNDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA5B750", Offset = "0xA5A350", VA = "0x180A5B750", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA5B510", Offset = "0xA5A110", VA = "0x180A5B510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LKKDMOCNJPN KOEFBENGEHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LKKDMOCNJPN HLHDCLEOCHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public LKKDMOCNJPN MFHNHJCFCGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JLLIEGGNPIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA89010", Offset = "0xA87C10", VA = "0x180A89010", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool CDEKABIGDBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD297E0", Offset = "0xD283E0", VA = "0x180D297E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDDA030", Offset = "0xDD8C30", VA = "0x180DDA030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x80B62F0", Offset = "0x80B4EF0", VA = "0x1880B62F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E70EC0", Offset = "0x7E6FAC0", VA = "0x187E70EC0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x80B6EA0", Offset = "0x80B5AA0", VA = "0x1880B6EA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD18A30", Offset = "0xD17630", VA = "0x180D18A30")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x80B6860", Offset = "0x80B5460", VA = "0x1880B6860")]
		private void JDIDABCKABM(Scene CMBCIMNOCEH, LoadSceneMode CEBNHJNKAJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x80B6DC0", Offset = "0x80B59C0", VA = "0x1880B6DC0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x80B7160", Offset = "0x80B5D60", VA = "0x1880B7160")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x80B6A50", Offset = "0x80B5650", VA = "0x1880B6A50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x80B6C60", Offset = "0x80B5860", VA = "0x1880B6C60")]
		private void NAALFIMJJMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x80B6EC0", Offset = "0x80B5AC0", VA = "0x1880B6EC0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x80B63B0", Offset = "0x80B4FB0", VA = "0x1880B63B0")]
		private void CIEEAJFPOIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x80B6680", Offset = "0x80B5280", VA = "0x1880B6680")]
		public DOKHKFPJPGF GetOrCreateCullingGroup(Type JBPIIOKEBGG, int LODCHNMACOF, ushort FLBMJBPNDIF = 0, bool NBNOGHHMMDH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3A79850", Offset = "0x3A78450", VA = "0x183A79850")]
		public HOLLKCILJEI<T> GetOrCreateCullingGroup<T>(int LODCHNMACOF, ushort FLBMJBPNDIF = 0, bool NBNOGHHMMDH = false) where T : class, FPMLDBOMIMK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x80B68C0", Offset = "0x80B54C0", VA = "0x1880B68C0")]
		private DOKHKFPJPGF KLEGJJFAFAF(Type JBPIIOKEBGG, int LODCHNMACOF, float[] JKDKBMPFKCP, ushort FLBMJBPNDIF = 0, bool NBNOGHHMMDH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3A798F0", Offset = "0x3A784F0", VA = "0x183A798F0")]
		private HOLLKCILJEI<T> KLEGJJFAFAF<T>(int LODCHNMACOF, float[] JKDKBMPFKCP, ushort FLBMJBPNDIF = 0, bool NBNOGHHMMDH = false) where T : class, FPMLDBOMIMK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80B6520", Offset = "0x80B5120", VA = "0x1880B6520")]
		public static AFJPHDDPDEH FindClosestDefaultUpdateLod(float MKAGHPLBFOA)
		{
			return default(AFJPHDDPDEH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA8A670", Offset = "0xA89270", VA = "0x180A8A670")]
		public static AFJPHDDPDEH MinUpdateLod(AFJPHDDPDEH KEMHCAGKNOE, AFJPHDDPDEH AINDEOEFAGJ)
		{
			return default(AFJPHDDPDEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x80B6C50", Offset = "0x80B5850", VA = "0x1880B6C50")]
		public static AFJPHDDPDEH MaxUpdateLod(AFJPHDDPDEH KEMHCAGKNOE, AFJPHDDPDEH AINDEOEFAGJ)
		{
			return default(AFJPHDDPDEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x80B7610", Offset = "0x80B6210", VA = "0x1880B7610")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA89010", Offset = "0xA87C10", VA = "0x180A89010", Slot = "11")]
		private bool JHHMLKIFGCE()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DIGAGDHHHNF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool JDMIDJHINGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera HIAMLDNBIEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LKKDMOCNJPN GKDJIMIPIPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KKDPJIGJFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LKKDMOCNJPN CBJIMNJDJFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform JIMAADKBLDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DOKHKFPJPGF
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDGLNAHKHEG(FPMLDBOMIMK KOJLNGLNBMH, float BNDEJLLMNLK, CFBMCAPEOOJ FKMLMPMPBPH = CFBMCAPEOOJ.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ENKPLOICKCM(FPMLDBOMIMK DOKCCDMGLHI);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CIFIJNDLLJJ(FPMLDBOMIMK KOJLNGLNBMH, CFBMCAPEOOJ JBJGENCDKKP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface HOLLKCILJEI<T> : DOKHKFPJPGF where T : class, FPMLDBOMIMK
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDGLNAHKHEG(T KOJLNGLNBMH, float BNDEJLLMNLK, CFBMCAPEOOJ FKMLMPMPBPH = CFBMCAPEOOJ.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NDGLNAHKHEG(T KOJLNGLNBMH, Transform HIFEDDBKMHN, float BNDEJLLMNLK, CFBMCAPEOOJ FKMLMPMPBPH = CFBMCAPEOOJ.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ENKPLOICKCM(T DOKCCDMGLHI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OAFIKPJOCCP(T KOJLNGLNBMH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface FPMLDBOMIMK
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform LMGPODOPMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(AFJPHDDPDEH KJMHACFAJAA, AFJPHDDPDEH JDEINKMLEPI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool JOGHHJHGGAG);
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
