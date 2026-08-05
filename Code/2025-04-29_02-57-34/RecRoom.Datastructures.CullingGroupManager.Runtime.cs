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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OIIOMECAMMK, AHODEOBLEAO
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct PLBCLEDKLLO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> AOFGGGKINCN;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7ABF330", Offset = "0x7ABE730", VA = "0x187ABF330", Slot = "4")]
			public void Execute(int COPLIEINKOF, TransformAccess NIBJBBEPHBE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct LALPHFNICLH : IEquatable<LALPHFNICLH>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort IGFBKHOEGEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type BODMIHEMADK;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD030", Offset = "0x7ABC430", VA = "0x187ABD030", Slot = "4")]
			public bool Equals(LALPHFNICLH DMMBOHMLHLF)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD0B0", Offset = "0x7ABC4B0", VA = "0x187ABD0B0", Slot = "0")]
			public override bool Equals(object KLANNNFBLNB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD1A0", Offset = "0x7ABC5A0", VA = "0x187ABD1A0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class EOLNLFFOJAP<T> : PHCGIEMGBEJ, FPLIJICOIEI<T>, APLIPBJIGME where T : class, ADBBNFIBLNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x43BAD50", Offset = "0x43BA150", VA = "0x1843BAD50")]
			internal EOLNLFFOJAP(int HPGMNCMNBII, float[] GKGCJINAKGE, ABNENKEDJHL DMBENCFNFAH = ABNENKEDJHL.PlayerHead, bool DMEFAECOCDG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x43BACE0", Offset = "0x43BA0E0", VA = "0x1843BACE0", Slot = "12")]
			public void FGAAHPGCDNG(T KLANNNFBLNB, float PPFBOIIFNHM, OJCAHADJONK FDDMODILEFA = OJCAHADJONK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x43BACB0", Offset = "0x43BA0B0", VA = "0x1843BACB0", Slot = "13")]
			public void FGAAHPGCDNG(T KLANNNFBLNB, Transform NIMBEJMGDKD, float PPFBOIIFNHM, OJCAHADJONK FDDMODILEFA = OJCAHADJONK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x43BAD30", Offset = "0x43BA130", VA = "0x1843BAD30", Slot = "14")]
			public void NMPKBAOEGPN(T MOMKMPNIJPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x43BAD10", Offset = "0x43BA110", VA = "0x1843BAD10", Slot = "15")]
			public bool LEFNOINLPFA(T KLANNNFBLNB)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class PHCGIEMGBEJ : IDisposable, APLIPBJIGME
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct GPMFIPDDLKB
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum EIIKMAMPFNL : byte
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
				public ADBBNFIBLNJ HGPAKJHEINP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform ACIFLJLGGLL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float HBPCAGLAIKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public OJCAHADJONK PFOENGKBIPK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public EIIKMAMPFNL PLJKCMOLLLF;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum ABNENKEDJHL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class HDMNBIIDBIL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public ADBBNFIBLNJ HGPAKJHEINP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public OJCAHADJONK NDJGHBIAIOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action JOCJHEIAJPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool APLMPEPBOPL;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
				public HDMNBIIDBIL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int LFOHOAHFJHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool DMEFAECOCDG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool FJEDLGBMFFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup BLJCODAODOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] JDBEAEIJBHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly KEMPLKKCKNO HLIKBEKBJPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly ABNENKEDJHL DMBENCFNFAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<ADBBNFIBLNJ, int> GEIOPFGKAIJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, HDMNBIIDBIL> OHDEHNJNHEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray MCCEIHELBBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> EBNGDNFKGGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<GPMFIPDDLKB> FFAAFEGLJBK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool CKGGGGFPFGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle KAKLANICLFE;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int MKBPCNPDPFG
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9C91A0", Offset = "0x9C85A0", VA = "0x1809C91A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x9CFCE0", Offset = "0x9CF0E0", VA = "0x1809CFCE0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int PKFHLNOGOCB
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xB52460", Offset = "0xB51860", VA = "0x180B52460", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xC35ED0", Offset = "0xC352D0", VA = "0x180C35ED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7ABEE50", Offset = "0x7ABE250", VA = "0x187ABEE50")]
			internal PHCGIEMGBEJ(int HPGMNCMNBII, float[] GKGCJINAKGE, ABNENKEDJHL DMBENCFNFAH = ABNENKEDJHL.PlayerHead, bool DMEFAECOCDG = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD210", Offset = "0x7ABC610", VA = "0x187ABD210")]
			public void BMOHFNGMPHA(bool BJODENMJKHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD9A0", Offset = "0x7ABCDA0", VA = "0x187ABD9A0", Slot = "5")]
			public void FGAAHPGCDNG(ADBBNFIBLNJ KLANNNFBLNB, float PPFBOIIFNHM, OJCAHADJONK FDDMODILEFA = OJCAHADJONK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDAA0", Offset = "0x7ABCEA0", VA = "0x187ABDAA0", Slot = "10")]
			public void FGAAHPGCDNG(ADBBNFIBLNJ KLANNNFBLNB, Transform NIMBEJMGDKD, float PPFBOIIFNHM, OJCAHADJONK FDDMODILEFA = OJCAHADJONK.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE020", Offset = "0x7ABD420", VA = "0x187ABE020")]
			private void MEKDNDDCIAA(ADBBNFIBLNJ KLANNNFBLNB, Transform NIMBEJMGDKD, float PPFBOIIFNHM, OJCAHADJONK FDDMODILEFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE670", Offset = "0x7ABDA70", VA = "0x187ABE670", Slot = "6")]
			public void NMPKBAOEGPN(ADBBNFIBLNJ MOMKMPNIJPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE6E0", Offset = "0x7ABDAE0", VA = "0x187ABE6E0")]
			private void OPAEGDOBEPF(ADBBNFIBLNJ MOMKMPNIJPJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE410", Offset = "0x7ABD810", VA = "0x187ABE410")]
			private void NECGFFAOBLC(ADBBNFIBLNJ KLANNNFBLNB, [Optional] float? PPFBOIIFNHM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDF60", Offset = "0x7ABD360", VA = "0x187ABDF60", Slot = "11")]
			public bool LEFNOINLPFA(ADBBNFIBLNJ KLANNNFBLNB)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "7")]
			public void KKIFKBNDPBP(ADBBNFIBLNJ KLANNNFBLNB, OJCAHADJONK PJGEDGPOPKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD6B0", Offset = "0x7ABCAB0", VA = "0x187ABD6B0")]
			private void DKBKIBJGAJH(ADBBNFIBLNJ KLANNNFBLNB, OJCAHADJONK PJGEDGPOPKG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDC90", Offset = "0x7ABD090", VA = "0x187ABDC90")]
			public void IOANOOCALAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDD50", Offset = "0x7ABD150", VA = "0x187ABDD50")]
			public void LBECFOCILOD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD3B0", Offset = "0x7ABC7B0", VA = "0x187ABD3B0")]
			private void DDFIKCFHADO(GPMFIPDDLKB NEIELBLPLNK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7ABDB40", Offset = "0x7ABCF40", VA = "0x187ABDB40")]
			private void GBKJOBFLFBC(int JLGCIBOFIIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD760", Offset = "0x7ABCB60", VA = "0x187ABD760", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD990", Offset = "0x7ABCD90", VA = "0x187ABD990")]
			private void EEICNACBAEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7ABE6D0", Offset = "0x7ABDAD0", VA = "0x187ABE6D0")]
			private void OFFJCJOPMCG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7ABEB20", Offset = "0x7ABDF20", VA = "0x187ABEB20")]
			private void PICLIMEAHIN(CullingGroupEvent FHJJAHCIFJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7ABD240", Offset = "0x7ABC640", VA = "0x187ABD240")]
			private void CILIJGPEANA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float ONFIPMBPGCJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float GHNIMHLGGHI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float CLCNGKGGCIG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float MBCBNKBIOLA = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float ALLPHDMENAJ = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float CAGOIKDPGLN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float PCOHHAGLINK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<LALPHFNICLH, PHCGIEMGBEJ> NPKJFKPDEOF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable MINNMNFCIJF;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable BKFEKGANFIE;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static KFBDEOPEKLE FFDFIEBBAOA;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static KFBDEOPEKLE HLBDAOAGKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly KFBDEOPEKLE DMJNLJKDAFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KFBDEOPEKLE HMCKNPGDKPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KFBDEOPEKLE MBFKKECNAPH;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker JOCLOOOHKII;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker DBMKGMLPNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private DGHHBAELICH NDIAFDPLDMO;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool BJODENMJKHA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool HFNAFNGMPCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x9C91C0", Offset = "0x9C85C0", VA = "0x1809C91C0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9C9250", Offset = "0x9C8650", VA = "0x1809C9250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KFBDEOPEKLE BPDFAJGBINP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KFBDEOPEKLE EGIKKIACDCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public KFBDEOPEKLE KOKMGPJLDNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LIGHCIEMCEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9F69F0", Offset = "0x9F5DF0", VA = "0x1809F69F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HGODLBLJMLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xBEB250", Offset = "0xBEA650", VA = "0x180BEB250", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xCB8310", Offset = "0xCB7710", VA = "0x180CB8310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBBE0", Offset = "0x7ABAFE0", VA = "0x187ABBBE0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x78A54D0", Offset = "0x78A48D0", VA = "0x1878A54D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1DD9E40", Offset = "0x1DD9240", VA = "0x181DD9E40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xBB5670", Offset = "0xBB4A70", VA = "0x180BB5670")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBCA0", Offset = "0x7ABB0A0", VA = "0x187ABBCA0")]
		private void CBKONOINHAH(Scene GCOBHCDOBIL, LoadSceneMode FDNGPAPMHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC6B0", Offset = "0x7ABBAB0", VA = "0x187ABC6B0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCA30", Offset = "0x7ABBE30", VA = "0x187ABCA30")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC4A0", Offset = "0x7ABB8A0", VA = "0x187ABC4A0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBFD0", Offset = "0x7ABB3D0", VA = "0x187ABBFD0")]
		private void GCFLHNCIBPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC790", Offset = "0x7ABBB90", VA = "0x187ABC790")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBD00", Offset = "0x7ABB100", VA = "0x187ABBD00")]
		private void CNJKDEAHEBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC2C0", Offset = "0x7ABB6C0", VA = "0x187ABC2C0")]
		public APLIPBJIGME GetOrCreateCullingGroup(Type LBLKGPIFCMJ, int KDAJJJJOBCB, ushort GCJEMHFIKAC = 0, bool DMEFAECOCDG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x34FA050", Offset = "0x34F9450", VA = "0x1834FA050")]
		public FPLIJICOIEI<T> GetOrCreateCullingGroup<T>(int KDAJJJJOBCB, ushort GCJEMHFIKAC = 0, bool DMEFAECOCDG = false) where T : class, ADBBNFIBLNJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC130", Offset = "0x7ABB530", VA = "0x187ABC130")]
		private APLIPBJIGME GOAELHIOEJO(Type LBLKGPIFCMJ, int KDAJJJJOBCB, float[] GKGCJINAKGE, ushort GCJEMHFIKAC = 0, bool DMEFAECOCDG = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x34F9E10", Offset = "0x34F9210", VA = "0x1834F9E10")]
		private FPLIJICOIEI<T> GOAELHIOEJO<T>(int KDAJJJJOBCB, float[] GKGCJINAKGE, ushort GCJEMHFIKAC = 0, bool DMEFAECOCDG = false) where T : class, ADBBNFIBLNJ
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7ABBE70", Offset = "0x7ABB270", VA = "0x187ABBE70")]
		public static BAJKLLBGNIN FindClosestDefaultUpdateLod(float ODHCJALIMPE)
		{
			return default(BAJKLLBGNIN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9F8080", Offset = "0x9F7480", VA = "0x1809F8080")]
		public static BAJKLLBGNIN MinUpdateLod(BAJKLLBGNIN CJJJNLLCIKM, BAJKLLBGNIN HBDMOMKDCJE)
		{
			return default(BAJKLLBGNIN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7ABC6A0", Offset = "0x7ABBAA0", VA = "0x187ABC6A0")]
		public static BAJKLLBGNIN MaxUpdateLod(BAJKLLBGNIN CJJJNLLCIKM, BAJKLLBGNIN HBDMOMKDCJE)
		{
			return default(BAJKLLBGNIN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7ABCEE0", Offset = "0x7ABC2E0", VA = "0x187ABCEE0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9F69F0", Offset = "0x9F5DF0", VA = "0x1809F69F0", Slot = "11")]
		private bool LDCBNFHEIEE()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KEMPLKKCKNO
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DPLHAHFICAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera HPCJBGJIDPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KFBDEOPEKLE FHCJEJFMGGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool HENCGAIAADI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	KFBDEOPEKLE LHBNDLDKDBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform GLCFPLPPOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface APLIPBJIGME
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGAAHPGCDNG(ADBBNFIBLNJ KLANNNFBLNB, float PPFBOIIFNHM, OJCAHADJONK FDDMODILEFA = OJCAHADJONK.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NMPKBAOEGPN(ADBBNFIBLNJ MOMKMPNIJPJ);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KKIFKBNDPBP(ADBBNFIBLNJ KLANNNFBLNB, OJCAHADJONK IONLNLAHNII);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FPLIJICOIEI<T> : APLIPBJIGME where T : class, ADBBNFIBLNJ
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FGAAHPGCDNG(T KLANNNFBLNB, float PPFBOIIFNHM, OJCAHADJONK FDDMODILEFA = OJCAHADJONK.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FGAAHPGCDNG(T KLANNNFBLNB, Transform NIMBEJMGDKD, float PPFBOIIFNHM, OJCAHADJONK FDDMODILEFA = OJCAHADJONK.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NMPKBAOEGPN(T MOMKMPNIJPJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LEFNOINLPFA(T KLANNNFBLNB);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ADBBNFIBLNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform NIBJBBEPHBE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(BAJKLLBGNIN BEBNGOBPDJN, BAJKLLBGNIN DLPLDDMBNPC);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool CADKGLGHDBD);
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
