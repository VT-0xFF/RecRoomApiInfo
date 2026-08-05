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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, MNPMACNNAFB, OAGHPAJECPH
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct JIHGDLLFCPO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> BOIPFNOKGBJ;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x807A8F0", Offset = "0x80796F0", VA = "0x18807A8F0", Slot = "4")]
			public void Execute(int CKFKPOAGPKN, TransformAccess OLPMPAIMKPI)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct ANNPJJLALOJ : IEquatable<ANNPJJLALOJ>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort AKPPKINIPBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type IPOCDOHBGNJ;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8079390", Offset = "0x8078190", VA = "0x188079390", Slot = "4")]
			public bool Equals(ANNPJJLALOJ LOKLFHKEJPC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x80792A0", Offset = "0x80780A0", VA = "0x1880792A0", Slot = "0")]
			public override bool Equals(object MKPNGAKJFMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8079410", Offset = "0x8078210", VA = "0x188079410", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class GAIOEFMNOJF<T> : PKJKNMJHELE, DFIIHHDEFCP<T>, MHLDPIEPPBM where T : class, PLEJMOEMKPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4D717B0", Offset = "0x4D705B0", VA = "0x184D717B0")]
			internal GAIOEFMNOJF(int BPEJHDHPEFG, float[] IIJAHEPCOFD, CHNNACMELGL FMEIPELPHPA = CHNNACMELGL.PlayerHead, bool EPKPBIKDEDH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4D71760", Offset = "0x4D70560", VA = "0x184D71760", Slot = "12")]
			public void OLHPIGGMIDE(T MKPNGAKJFMP, float LNLGAMEGNNM, CBJAHEEHPCM ELCEOJFJBNE = CBJAHEEHPCM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4D71730", Offset = "0x4D70530", VA = "0x184D71730", Slot = "13")]
			public void OLHPIGGMIDE(T MKPNGAKJFMP, Transform CONLNGNAGHF, float LNLGAMEGNNM, CBJAHEEHPCM ELCEOJFJBNE = CBJAHEEHPCM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4D71710", Offset = "0x4D70510", VA = "0x184D71710", Slot = "14")]
			public void EBNLHEFHMEO(T KEAELNPIDBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4D71790", Offset = "0x4D70590", VA = "0x184D71790", Slot = "15")]
			public bool POMBAFGNLIP(T MKPNGAKJFMP)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class PKJKNMJHELE : IDisposable, MHLDPIEPPBM
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct MCKGHOKMABM
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum EGAFHDKLHEL : byte
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
				public PLEJMOEMKPB FNKEDPICBEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform HBAFPBAGLCP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float EPJCPHOJPNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public CBJAHEEHPCM OAAAMHPNBCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public EGAFHDKLHEL KICDHMJGHJC;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum CHNNACMELGL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class PKFCAAEFBFF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public PLEJMOEMKPB FNKEDPICBEL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public CBJAHEEHPCM IMENMPPECAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action BJIBBGOKOCI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool JJNEHJEOGIF;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
				public PKFCAAEFBFF()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int NMCMGBJLDBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool EPKPBIKDEDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool FOABPIBDEDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup FGPHAOJKKHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] NDNBCEBOGMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly IECHNAPLMLI JBNGHMBPLHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly CHNNACMELGL FMEIPELPHPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<PLEJMOEMKPB, int> ENCBBJGJJAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, PKFCAAEFBFF> BPIOEKDCHLL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray GFJMKLECLPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> MFMMLOGDMGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<MCKGHOKMABM> GPCAANPDFBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool NFPDEBDEEDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle BNNGADNDJHP;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int OOLKBPNCEFC
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xA57180", Offset = "0xA55F80", VA = "0x180A57180", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xA5A3F0", Offset = "0xA591F0", VA = "0x180A5A3F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int HJDLNBOJBON
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAAA750", Offset = "0xAA9550", VA = "0x180AAA750", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xB28270", Offset = "0xB27070", VA = "0x180B28270")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x807C5A0", Offset = "0x807B3A0", VA = "0x18807C5A0")]
			internal PKJKNMJHELE(int BPEJHDHPEFG, float[] IIJAHEPCOFD, CHNNACMELGL FMEIPELPHPA = CHNNACMELGL.PlayerHead, bool EPKPBIKDEDH = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x807C4B0", Offset = "0x807B2B0", VA = "0x18807C4B0")]
			public void OOBNIGHEICL(bool EKEBHDLGILC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x807C310", Offset = "0x807B110", VA = "0x18807C310", Slot = "5")]
			public void OLHPIGGMIDE(PLEJMOEMKPB MKPNGAKJFMP, float LNLGAMEGNNM, CBJAHEEHPCM ELCEOJFJBNE = CBJAHEEHPCM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x807C410", Offset = "0x807B210", VA = "0x18807C410", Slot = "10")]
			public void OLHPIGGMIDE(PLEJMOEMKPB MKPNGAKJFMP, Transform CONLNGNAGHF, float LNLGAMEGNNM, CBJAHEEHPCM ELCEOJFJBNE = CBJAHEEHPCM.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x807AB00", Offset = "0x8079900", VA = "0x18807AB00")]
			private void APEJCMJLNDG(PLEJMOEMKPB MKPNGAKJFMP, Transform CONLNGNAGHF, float LNLGAMEGNNM, CBJAHEEHPCM ELCEOJFJBNE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x807B120", Offset = "0x8079F20", VA = "0x18807B120", Slot = "6")]
			public void EBNLHEFHMEO(PLEJMOEMKPB KEAELNPIDBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x807B570", Offset = "0x807A370", VA = "0x18807B570")]
			private void HKNDOMLDKOA(PLEJMOEMKPB KEAELNPIDBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x807C0B0", Offset = "0x807AEB0", VA = "0x18807C0B0")]
			private void NNMBLFOHJMF(PLEJMOEMKPB MKPNGAKJFMP, [Optional] float? LNLGAMEGNNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x807C4E0", Offset = "0x807B2E0", VA = "0x18807C4E0", Slot = "11")]
			public bool POMBAFGNLIP(PLEJMOEMKPB MKPNGAKJFMP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA58410", Offset = "0xA57210", VA = "0x180A58410", Slot = "7")]
			public void OAAAJKKCBAC(PLEJMOEMKPB MKPNGAKJFMP, CBJAHEEHPCM DNFBIGOFJNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x807B9B0", Offset = "0x807A7B0", VA = "0x18807B9B0")]
			private void HMNGENLGFOK(PLEJMOEMKPB MKPNGAKJFMP, CBJAHEEHPCM DNFBIGOFJNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x807B4B0", Offset = "0x807A2B0", VA = "0x18807B4B0")]
			public void FANACCCPJJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x807BA60", Offset = "0x807A860", VA = "0x18807BA60")]
			public void JFKKHEDOCOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x807BC70", Offset = "0x807AA70", VA = "0x18807BC70")]
			private void KJMJNCLKANP(MCKGHOKMABM BEIDDJJHBIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x807BF60", Offset = "0x807AD60", VA = "0x18807BF60")]
			private void MNGENEILNKK(int FKJAILBOBGF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x807AEF0", Offset = "0x8079CF0", VA = "0x18807AEF0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x807AAF0", Offset = "0x80798F0", VA = "0x18807AAF0")]
			private void AJAHKHFDMFM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x807A970", Offset = "0x8079770", VA = "0x18807A970")]
			private void AHGFOHPHPLK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x807B180", Offset = "0x8079F80", VA = "0x18807B180")]
			private void ECICAMEHDDD(CullingGroupEvent IIBEEPEKFAH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x807A980", Offset = "0x8079780", VA = "0x18807A980")]
			private void AIICFIICLDM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float NKEHFGMMKJK = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float IJDLJMPGOOI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float PPGIEBIIEPL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float MJHEOMBLGAF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float EDKGHKNODLL = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GGMLFAMJANI = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float AKOFHGOMOOG = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<ANNPJJLALOJ, PKJKNMJHELE> EPICACBCIMG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable DCOAEDHNLHK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable CECHBDICNGP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static EPBKGABEMJJ NIJLNEDEEPO;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static EPBKGABEMJJ LBFLPDJBMGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EPBKGABEMJJ KCJIKPGIJIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EPBKGABEMJJ DMOJJLOBGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly EPBKGABEMJJ EKBOOFODHFE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker KBHIHCBNMDI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker FCFJGMGGBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IHBKINGAIAD OMBEMGMLKFB;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool EKEBHDLGILC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool MFHPJONMPOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA60460", Offset = "0xA5F260", VA = "0x180A60460", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA60450", Offset = "0xA5F250", VA = "0x180A60450")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EPBKGABEMJJ FKIGPDCEBOO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA59880", Offset = "0xA58680", VA = "0x180A59880", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EPBKGABEMJJ AMHCGIONPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA59850", Offset = "0xA58650", VA = "0x180A59850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public EPBKGABEMJJ JBNHDEOFFHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA5C130", Offset = "0xA5AF30", VA = "0x180A5C130", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MEAKJBECIAC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA85C10", Offset = "0xA84A10", VA = "0x180A85C10", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GCDODLLDCJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD238E0", Offset = "0xD226E0", VA = "0x180D238E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDD6110", Offset = "0xDD4F10", VA = "0x180DD6110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8079610", Offset = "0x8078410", VA = "0x188079610", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7E44620", Offset = "0x7E43420", VA = "0x187E44620")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x807A030", Offset = "0x8078E30", VA = "0x18807A030")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xD12BD0", Offset = "0xD119D0", VA = "0x180D12BD0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8079A10", Offset = "0x8078810", VA = "0x188079A10")]
		private void IMAJBNMHEBP(Scene DHLFBBHICBC, LoadSceneMode ICPOMAFNIKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8079F50", Offset = "0x8078D50", VA = "0x188079F50", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x807A2F0", Offset = "0x80790F0", VA = "0x18807A2F0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8079D40", Offset = "0x8078B40", VA = "0x188079D40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8079BE0", Offset = "0x80789E0", VA = "0x188079BE0")]
		private void LEDKBPGKFFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x807A050", Offset = "0x8078E50", VA = "0x18807A050")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8079A70", Offset = "0x8078870", VA = "0x188079A70")]
		private void LANMJKIJAMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8079830", Offset = "0x8078630", VA = "0x188079830")]
		public MHLDPIEPPBM GetOrCreateCullingGroup(Type HHCAMFHFHNI, int ANPHOPCGPLG, ushort EKLOJDKNOMF = 0, bool EPKPBIKDEDH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x39D5B20", Offset = "0x39D4920", VA = "0x1839D5B20")]
		public DFIIHHDEFCP<T> GetOrCreateCullingGroup<T>(int ANPHOPCGPLG, ushort EKLOJDKNOMF = 0, bool EPKPBIKDEDH = false) where T : class, PLEJMOEMKPB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8079480", Offset = "0x8078280", VA = "0x188079480")]
		private MHLDPIEPPBM AJBHHLELOFI(Type HHCAMFHFHNI, int ANPHOPCGPLG, float[] IIJAHEPCOFD, ushort EKLOJDKNOMF = 0, bool EPKPBIKDEDH = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x39D58F0", Offset = "0x39D46F0", VA = "0x1839D58F0")]
		private DFIIHHDEFCP<T> AJBHHLELOFI<T>(int ANPHOPCGPLG, float[] IIJAHEPCOFD, ushort EKLOJDKNOMF = 0, bool EPKPBIKDEDH = false) where T : class, PLEJMOEMKPB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80796D0", Offset = "0x80784D0", VA = "0x1880796D0")]
		public static CNPJGKPMCGN FindClosestDefaultUpdateLod(float LLGMMMONOPO)
		{
			return default(CNPJGKPMCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA865B0", Offset = "0xA853B0", VA = "0x180A865B0")]
		public static CNPJGKPMCGN MinUpdateLod(CNPJGKPMCGN KDNAAKKBJGO, CNPJGKPMCGN JCBFFFHPNBB)
		{
			return default(CNPJGKPMCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8079F40", Offset = "0x8078D40", VA = "0x188079F40")]
		public static CNPJGKPMCGN MaxUpdateLod(CNPJGKPMCGN KDNAAKKBJGO, CNPJGKPMCGN JCBFFFHPNBB)
		{
			return default(CNPJGKPMCGN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x807A7A0", Offset = "0x80795A0", VA = "0x18807A7A0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA85C10", Offset = "0xA84A10", VA = "0x180A85C10", Slot = "11")]
		private bool JGCGIJJFOGK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface IECHNAPLMLI
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool EOMDKMADLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera PGMILJHCGON
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EPBKGABEMJJ JAGAOFIGKID
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool MDJJPHJAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	EPBKGABEMJJ AKEKBIPKFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform FPCNHLBKEFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface MHLDPIEPPBM
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLHPIGGMIDE(PLEJMOEMKPB MKPNGAKJFMP, float LNLGAMEGNNM, CBJAHEEHPCM ELCEOJFJBNE = CBJAHEEHPCM.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EBNLHEFHMEO(PLEJMOEMKPB KEAELNPIDBJ);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OAAAJKKCBAC(PLEJMOEMKPB MKPNGAKJFMP, CBJAHEEHPCM GDHJCNKPAHL);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DFIIHHDEFCP<T> : MHLDPIEPPBM where T : class, PLEJMOEMKPB
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OLHPIGGMIDE(T MKPNGAKJFMP, float LNLGAMEGNNM, CBJAHEEHPCM ELCEOJFJBNE = CBJAHEEHPCM.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLHPIGGMIDE(T MKPNGAKJFMP, Transform CONLNGNAGHF, float LNLGAMEGNNM, CBJAHEEHPCM ELCEOJFJBNE = CBJAHEEHPCM.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EBNLHEFHMEO(T KEAELNPIDBJ);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool POMBAFGNLIP(T MKPNGAKJFMP);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PLEJMOEMKPB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform OLPMPAIMKPI
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CNPJGKPMCGN BPJAEOCDPBE, CNPJGKPMCGN NCHCOBIEDPJ);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool ELBEIBGFCLG);
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
