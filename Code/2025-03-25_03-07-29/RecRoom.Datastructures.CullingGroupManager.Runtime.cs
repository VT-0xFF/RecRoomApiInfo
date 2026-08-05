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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, NACLFHGEHGD, OKEGJBDPDCK
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct EMLAKLENJKG : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> AMHCLKHIFKH;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x77D4E70", Offset = "0x77D4270", VA = "0x1877D4E70", Slot = "4")]
			public void Execute(int KDCAMOIGIMA, TransformAccess NPHMCHFKJHC)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct KBIDNJEGGEE : IEquatable<KBIDNJEGGEE>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort NGIOJCJJONO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type JKHDENOAMHN;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x77D4FE0", Offset = "0x77D43E0", VA = "0x1877D4FE0", Slot = "4")]
			public bool Equals(KBIDNJEGGEE JAPIEEBOJEA)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x77D4EF0", Offset = "0x77D42F0", VA = "0x1877D4EF0", Slot = "0")]
			public override bool Equals(object HAPOBHMBDHP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x77D5060", Offset = "0x77D4460", VA = "0x1877D5060", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class CKGBDEMHANG<T> : NCBOALHIBNP, BOCNGNOCJKI<T>, OIAJDJPLGCF where T : class, LALFMDHBCFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x620F3C0", Offset = "0x620E7C0", VA = "0x18620F3C0")]
			internal CKGBDEMHANG(int CPIFMNKEFNA, float[] IMEKMKOJOMB, OJFDLCOPANK JPDDCMJLBOA = OJFDLCOPANK.PlayerHead, bool MBNAELKIMGC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x620F390", Offset = "0x620E790", VA = "0x18620F390", Slot = "12")]
			public void LLICHLCEEGA(T HAPOBHMBDHP, float MCIPFGHOGIP, GDMNGFOCBGE NNHEAKGNGDH = GDMNGFOCBGE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x620F360", Offset = "0x620E760", VA = "0x18620F360", Slot = "13")]
			public void LLICHLCEEGA(T HAPOBHMBDHP, Transform CBKMKILAOAA, float MCIPFGHOGIP, GDMNGFOCBGE NNHEAKGNGDH = GDMNGFOCBGE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x620F320", Offset = "0x620E720", VA = "0x18620F320", Slot = "14")]
			public void FBDLIPAFCGJ(T LPNAGNAKPIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x620F340", Offset = "0x620E740", VA = "0x18620F340", Slot = "15")]
			public bool IKPJMLCCAKP(T HAPOBHMBDHP)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class NCBOALHIBNP : IDisposable, OIAJDJPLGCF
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct IFFJEMPNPLG
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum FCHIFFLILOE : byte
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
				public LALFMDHBCFM NIIDGBCBCIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform GFBMHFBKABC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float NHGCPPGEOLG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public GDMNGFOCBGE EIBPLEFJNMC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public FCHIFFLILOE PONMJFHCNDE;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum OJFDLCOPANK : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class ECAJHLJKIEE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public LALFMDHBCFM NIIDGBCBCIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public GDMNGFOCBGE NMBIJHIPGAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action IEGBDDJJABH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool KPMOMFFAEDP;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
				public ECAJHLJKIEE()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int LAIMGLECPGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool MBNAELKIMGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool AOPCOJBCAIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup GILMMDEEPGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] ALPBPHKJFFG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly IKBBLDIENHM MFCHJJKNFDE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly OJFDLCOPANK JPDDCMJLBOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<LALFMDHBCFM, int> ODCHPPOKILJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, ECAJHLJKIEE> GGPAOFPPPLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray FNNDDJIIJMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> DHBKGBLIOIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<IFFJEMPNPLG> GMJFNDEEIPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool MFAFPLLAAML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle HJLNHNDMBAK;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int HEEHEKNCLFE
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9901A0", Offset = "0x98F5A0", VA = "0x1809901A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x9A02E0", Offset = "0x99F6E0", VA = "0x1809A02E0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int KBMJIFIPJPL
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xADD770", Offset = "0xADCB70", VA = "0x180ADD770", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xBBDA10", Offset = "0xBBCE10", VA = "0x180BBDA10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x77D6D10", Offset = "0x77D6110", VA = "0x1877D6D10")]
			internal NCBOALHIBNP(int CPIFMNKEFNA, float[] IMEKMKOJOMB, OJFDLCOPANK JPDDCMJLBOA = OJFDLCOPANK.PlayerHead, bool MBNAELKIMGC = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x77D60B0", Offset = "0x77D54B0", VA = "0x1877D60B0")]
			public void IHDJEOCAHDG(bool CIHAFFHCONE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x77D6240", Offset = "0x77D5640", VA = "0x1877D6240", Slot = "5")]
			public void LLICHLCEEGA(LALFMDHBCFM HAPOBHMBDHP, float MCIPFGHOGIP, GDMNGFOCBGE NNHEAKGNGDH = GDMNGFOCBGE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x77D61A0", Offset = "0x77D55A0", VA = "0x1877D61A0", Slot = "10")]
			public void LLICHLCEEGA(LALFMDHBCFM HAPOBHMBDHP, Transform CBKMKILAOAA, float MCIPFGHOGIP, GDMNGFOCBGE NNHEAKGNGDH = GDMNGFOCBGE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x77D6340", Offset = "0x77D5740", VA = "0x1877D6340")]
			private void MGDBONNELMI(LALFMDHBCFM HAPOBHMBDHP, Transform CBKMKILAOAA, float MCIPFGHOGIP, GDMNGFOCBGE NNHEAKGNGDH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x77D5B60", Offset = "0x77D4F60", VA = "0x1877D5B60", Slot = "6")]
			public void FBDLIPAFCGJ(LALFMDHBCFM LPNAGNAKPIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x77D5BC0", Offset = "0x77D4FC0", VA = "0x1877D5BC0")]
			private void FFOJIDJGHDC(LALFMDHBCFM LPNAGNAKPIC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x77D6730", Offset = "0x77D5B30", VA = "0x1877D6730")]
			private void OKKGKGKPFKC(LALFMDHBCFM HAPOBHMBDHP, [Optional] float? MCIPFGHOGIP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x77D60E0", Offset = "0x77D54E0", VA = "0x1877D60E0", Slot = "11")]
			public bool IKPJMLCCAKP(LALFMDHBCFM HAPOBHMBDHP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "7")]
			public void ONLOKEMKFLE(LALFMDHBCFM HAPOBHMBDHP, GDMNGFOCBGE GHLNEPNJEJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x77D6000", Offset = "0x77D5400", VA = "0x1877D6000")]
			private void IDIGFBJLANG(LALFMDHBCFM HAPOBHMBDHP, GDMNGFOCBGE GHLNEPNJEJF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x77D5850", Offset = "0x77D4C50", VA = "0x1877D5850")]
			public void DCKLJHNPEJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x77D6B00", Offset = "0x77D5F00", VA = "0x1877D6B00")]
			public void PHJFNODIEPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x77D50D0", Offset = "0x77D44D0", VA = "0x1877D50D0")]
			private void AFJFHAIANAO(IFFJEMPNPLG AMLIHKJCCAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x77D53D0", Offset = "0x77D47D0", VA = "0x1877D53D0")]
			private void BCFANAFOGOH(int LAKEOKAMKDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x77D5920", Offset = "0x77D4D20", VA = "0x1877D5920", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x77D5910", Offset = "0x77D4D10", VA = "0x1877D5910")]
			private void DLFLPGNKDPK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x77D5B50", Offset = "0x77D4F50", VA = "0x1877D5B50")]
			private void EPDGLEJKAFH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x77D5520", Offset = "0x77D4920", VA = "0x1877D5520")]
			private void CNMPFDMJICF(CullingGroupEvent JLBJFBIBGLI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x77D6990", Offset = "0x77D5D90", VA = "0x1877D6990")]
			private void OOCJKCNJDIE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float NABHDDBLPOB = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OLMACFFDGON = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float OFDENKPNOJI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float DNJBMMOBFPB = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float OKHNKOANPNG = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PEMBDPEOGCC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float KJLFKOGGDMJ = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<KBIDNJEGGEE, NCBOALHIBNP> PNMCLBFOBKC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PPPGBKCNMAL;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable IKBDIKMMEGO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static OLDENIALAEA IOIDJKDCBOC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static OLDENIALAEA OCHOMDEECED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly OLDENIALAEA JNNHEIIGJHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OLDENIALAEA MGBHKOIKMJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly OLDENIALAEA DMJALANPFFO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker MHMILHLKPKP;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker IGFDNIEENBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private INGHODAMJIF LEFNOJADHHC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool CIHAFFHCONE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OENONAGGDKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9932A0", Offset = "0x9926A0", VA = "0x1809932A0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x993530", Offset = "0x992930", VA = "0x180993530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OLDENIALAEA KJFDFIHFPMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x993260", Offset = "0x992660", VA = "0x180993260", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OLDENIALAEA EFJBPEMFPDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x992540", Offset = "0x991940", VA = "0x180992540", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public OLDENIALAEA MNNNEBKONFF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x993450", Offset = "0x992850", VA = "0x180993450", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MEBELHELFKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9BDB30", Offset = "0x9BCF30", VA = "0x1809BDB30", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ACKAKCAFIFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB54C50", Offset = "0xB54050", VA = "0x180B54C50", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xC46830", Offset = "0xC45C30", VA = "0x180C46830")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77D39A0", Offset = "0x77D2DA0", VA = "0x1877D39A0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77D4590", Offset = "0x77D3990", VA = "0x1877D4590")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1D199E0", Offset = "0x1D18DE0", VA = "0x181D199E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xB40C80", Offset = "0xB40080", VA = "0x180B40C80")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77D3BD0", Offset = "0x77D2FD0", VA = "0x1877D3BD0")]
		private void FMDLOCKLLAA(Scene MILOFGFNFDO, LoadSceneMode MBENOAGKGBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77D44B0", Offset = "0x77D38B0", VA = "0x1877D44B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77D4840", Offset = "0x77D3C40", VA = "0x1877D4840")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77D40D0", Offset = "0x77D34D0", VA = "0x1877D40D0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77D3F70", Offset = "0x77D3370", VA = "0x1877D3F70")]
		private void ICJNAPMBMPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77D45B0", Offset = "0x77D39B0", VA = "0x1877D45B0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77D3A60", Offset = "0x77D2E60", VA = "0x1877D3A60")]
		private void BHNPECEGCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77D3D90", Offset = "0x77D3190", VA = "0x1877D3D90")]
		public OIAJDJPLGCF GetOrCreateCullingGroup(Type KOOGEALPKDC, int MLGJJPPPBCG, ushort DOLIJGEMACE = 0, bool MBNAELKIMGC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x33FE4F0", Offset = "0x33FD8F0", VA = "0x1833FE4F0")]
		public BOCNGNOCJKI<T> GetOrCreateCullingGroup<T>(int MLGJJPPPBCG, ushort DOLIJGEMACE = 0, bool MBNAELKIMGC = false) where T : class, LALFMDHBCFM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x77D4320", Offset = "0x77D3720", VA = "0x1877D4320")]
		private OIAJDJPLGCF NIMDCJBMJLO(Type KOOGEALPKDC, int MLGJJPPPBCG, float[] IMEKMKOJOMB, ushort DOLIJGEMACE = 0, bool MBNAELKIMGC = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x33FE5B0", Offset = "0x33FD9B0", VA = "0x1833FE5B0")]
		private BOCNGNOCJKI<T> NIMDCJBMJLO<T>(int MLGJJPPPBCG, float[] IMEKMKOJOMB, ushort DOLIJGEMACE = 0, bool MBNAELKIMGC = false) where T : class, LALFMDHBCFM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77D3C30", Offset = "0x77D3030", VA = "0x1877D3C30")]
		public static GPKPAEJIOJM FindClosestDefaultUpdateLod(float NJKCCGPHANB)
		{
			return default(GPKPAEJIOJM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9BF2B0", Offset = "0x9BE6B0", VA = "0x1809BF2B0")]
		public static GPKPAEJIOJM MinUpdateLod(GPKPAEJIOJM CFBEPHFMFJP, GPKPAEJIOJM OALJJACCOND)
		{
			return default(GPKPAEJIOJM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x77D4310", Offset = "0x77D3710", VA = "0x1877D4310")]
		public static GPKPAEJIOJM MaxUpdateLod(GPKPAEJIOJM CFBEPHFMFJP, GPKPAEJIOJM OALJJACCOND)
		{
			return default(GPKPAEJIOJM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x77D4D20", Offset = "0x77D4120", VA = "0x1877D4D20")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9BDB30", Offset = "0x9BCF30", VA = "0x1809BDB30", Slot = "11")]
		private bool DBFPPDPFIPJ()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IKBBLDIENHM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool IOMKONBMILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera GGCOCEJJEFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	OLDENIALAEA AAHMKOCCFMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool IBMPLHDLMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	OLDENIALAEA AGJHLBGFENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform CFKGHABOCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OIAJDJPLGCF
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLICHLCEEGA(LALFMDHBCFM HAPOBHMBDHP, float MCIPFGHOGIP, GDMNGFOCBGE NNHEAKGNGDH = GDMNGFOCBGE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBDLIPAFCGJ(LALFMDHBCFM LPNAGNAKPIC);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ONLOKEMKFLE(LALFMDHBCFM HAPOBHMBDHP, GDMNGFOCBGE CFBBAAEBBFB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface BOCNGNOCJKI<T> : OIAJDJPLGCF where T : class, LALFMDHBCFM
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLICHLCEEGA(T HAPOBHMBDHP, float MCIPFGHOGIP, GDMNGFOCBGE NNHEAKGNGDH = GDMNGFOCBGE.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLICHLCEEGA(T HAPOBHMBDHP, Transform CBKMKILAOAA, float MCIPFGHOGIP, GDMNGFOCBGE NNHEAKGNGDH = GDMNGFOCBGE.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBDLIPAFCGJ(T LPNAGNAKPIC);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IKPJMLCCAKP(T HAPOBHMBDHP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LALFMDHBCFM
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform NPHMCHFKJHC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GPKPAEJIOJM CIOPJANLAMG, GPKPAEJIOJM CKDFMHIEDPI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BCMJICCFPOB);
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
