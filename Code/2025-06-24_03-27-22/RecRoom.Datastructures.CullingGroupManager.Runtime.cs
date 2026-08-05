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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OHAAOAKGENJ, MIGNIEJDGMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct FGJDGCCEKME : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> PEDMEJIDLNB;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7D878F0", Offset = "0x7D864F0", VA = "0x187D878F0", Slot = "4")]
			public void Execute(int EMMACFPOKFB, TransformAccess NMIBCHFJGAE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct CPEPEIGPAHM : IEquatable<CPEPEIGPAHM>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort AIHGAGAHPFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type ONLEFBOFDOC;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7D86240", Offset = "0x7D84E40", VA = "0x187D86240", Slot = "4")]
			public bool Equals(CPEPEIGPAHM GMNGNCHKEBK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7D862C0", Offset = "0x7D84EC0", VA = "0x187D862C0", Slot = "0")]
			public override bool Equals(object KDKJDFFGNJJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7D863B0", Offset = "0x7D84FB0", VA = "0x187D863B0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class AOMLENKJCCF<T> : JKLCODPAKAM, DKMOICDFJFL<T>, NDEAHNEBJHO where T : class, CBIBIMNKCPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5070B40", Offset = "0x506F740", VA = "0x185070B40")]
			internal AOMLENKJCCF(int AGFNENCOPCD, float[] GCBACLOJBHL, MKIFMBOCKOO GELGBCEAEGA = MKIFMBOCKOO.PlayerHead, bool GHEPNBHCGJB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5070AC0", Offset = "0x506F6C0", VA = "0x185070AC0", Slot = "12")]
			public void NKAMMCABBBC(T KDKJDFFGNJJ, float HPDHPFDMAAO, FDCMEMEDMHG NFJHKIHIFNO = FDCMEMEDMHG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5070AF0", Offset = "0x506F6F0", VA = "0x185070AF0", Slot = "13")]
			public void NKAMMCABBBC(T KDKJDFFGNJJ, Transform KOPOODDFHEE, float HPDHPFDMAAO, FDCMEMEDMHG NFJHKIHIFNO = FDCMEMEDMHG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5070AA0", Offset = "0x506F6A0", VA = "0x185070AA0", Slot = "14")]
			public void HMCNGGMNMHK(T ABFJHPAPNOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5070B20", Offset = "0x506F720", VA = "0x185070B20", Slot = "15")]
			public bool PHOIIPPCIKP(T KDKJDFFGNJJ)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class JKLCODPAKAM : IDisposable, NDEAHNEBJHO
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct NOEFPCMCFGO
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum MEKPONBIMHB : byte
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
				public CBIBIMNKCPL HOFAHNGFIIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform FPIONCNEDML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float IPENPJMNGEH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public FDCMEMEDMHG LMIKCCMBOIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public MEKPONBIMHB JKOHHHGJLLP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum MKIFMBOCKOO : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class MHOINGCJNCJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public CBIBIMNKCPL HOFAHNGFIIG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public FDCMEMEDMHG KCOJJPFKPJB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action PEGHMDJBGAP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool NBMAENELHLE;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
				public MHOINGCJNCJ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int NAFCJAHNOKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool GHEPNBHCGJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool OCBGCPNOEJE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup CCDNCEPPLHJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] KMAPCCANNNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly LCOHMGAJFOE ECPFHMDENEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly MKIFMBOCKOO GELGBCEAEGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<CBIBIMNKCPL, int> DABMAGGPFGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, MHOINGCJNCJ> CPNAJAFNJIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray JFMFDKFLDDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> PDEFFCNPHLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<NOEFPCMCFGO> IDELJJCEAEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool GAAADPBKJPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle DJIBHNIMKKB;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int NPDKFFMNGJL
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xA1C110", Offset = "0xA1AD10", VA = "0x180A1C110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xA20EC0", Offset = "0xA1FAC0", VA = "0x180A20EC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int CAOPKOIEBOE
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA6B430", Offset = "0xA6A030", VA = "0x180A6B430", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAC4340", Offset = "0xAC2F40", VA = "0x180AC4340")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7D895A0", Offset = "0x7D881A0", VA = "0x187D895A0")]
			internal JKLCODPAKAM(int AGFNENCOPCD, float[] GCBACLOJBHL, MKIFMBOCKOO GELGBCEAEGA = MKIFMBOCKOO.PlayerHead, bool GHEPNBHCGJB = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7D87A20", Offset = "0x7D86620", VA = "0x187D87A20")]
			public void DKIKOEAPPGM(bool KFEPOMDHEBM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D890D0", Offset = "0x7D87CD0", VA = "0x187D890D0", Slot = "5")]
			public void NKAMMCABBBC(CBIBIMNKCPL KDKJDFFGNJJ, float HPDHPFDMAAO, FDCMEMEDMHG NFJHKIHIFNO = FDCMEMEDMHG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D89030", Offset = "0x7D87C30", VA = "0x187D89030", Slot = "10")]
			public void NKAMMCABBBC(CBIBIMNKCPL KDKJDFFGNJJ, Transform KOPOODDFHEE, float HPDHPFDMAAO, FDCMEMEDMHG NFJHKIHIFNO = FDCMEMEDMHG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D88660", Offset = "0x7D87260", VA = "0x187D88660")]
			private void ICDMEOHGKJM(CBIBIMNKCPL KDKJDFFGNJJ, Transform KOPOODDFHEE, float HPDHPFDMAAO, FDCMEMEDMHG NFJHKIHIFNO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D88100", Offset = "0x7D86D00", VA = "0x187D88100", Slot = "6")]
			public void HMCNGGMNMHK(CBIBIMNKCPL ABFJHPAPNOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D88160", Offset = "0x7D86D60", VA = "0x187D88160")]
			private void HOHKBGDILFH(CBIBIMNKCPL ABFJHPAPNOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7D88DD0", Offset = "0x7D879D0", VA = "0x187D88DD0")]
			private void NDOPNDJMHHO(CBIBIMNKCPL KDKJDFFGNJJ, [Optional] float? HPDHPFDMAAO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7D891E0", Offset = "0x7D87DE0", VA = "0x187D891E0", Slot = "11")]
			public bool PHOIIPPCIKP(CBIBIMNKCPL KDKJDFFGNJJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA1DE80", Offset = "0xA1CA80", VA = "0x180A1DE80", Slot = "7")]
			public void CJMJNCFBPEB(CBIBIMNKCPL KDKJDFFGNJJ, FDCMEMEDMHG NCIEEPHJPJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7D87970", Offset = "0x7D86570", VA = "0x187D87970")]
			private void AEHHIJGPAMF(CBIBIMNKCPL KDKJDFFGNJJ, FDCMEMEDMHG NCIEEPHJPJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7D885A0", Offset = "0x7D871A0", VA = "0x187D885A0")]
			public void IBJGNLLPDEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7D88A50", Offset = "0x7D87650", VA = "0x187D88A50")]
			public void KKCJKCMAHIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7D892A0", Offset = "0x7D87EA0", VA = "0x187D892A0")]
			private void PKICLMMDPFN(NOEFPCMCFGO OFHHGNENJGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7D87FB0", Offset = "0x7D86BB0", VA = "0x187D87FB0")]
			private void HDLBBLBIHNC(int OFIBPADMOCF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7D87A50", Offset = "0x7D86650", VA = "0x187D87A50", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7D89590", Offset = "0x7D88190", VA = "0x187D89590")]
			private void PONKEBALOBP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7D891D0", Offset = "0x7D87DD0", VA = "0x187D891D0")]
			private void OKOCMNBAKAF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7D87C80", Offset = "0x7D86880", VA = "0x187D87C80")]
			private void GMBPLGEBLPC(CullingGroupEvent GNPCKCFAIGD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7D88C60", Offset = "0x7D87860", VA = "0x187D88C60")]
			private void KPNLHCIOAGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float MFGKFIGOMFH = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float NPHBJHPLEBH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float IAIIJCABGIJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float AELAOMGHNLM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LPBDIABNBFN = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float LGIONPKBNNO = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float AOJBAJIIGKM = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<CPEPEIGPAHM, JKLCODPAKAM> BIDFPGHEMBM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable KPBDIIBJOML;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable PKAIENBDFBO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static HBAAEHCBNNO PLICIPCMBOC;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static HBAAEHCBNNO AINCBDLFPMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HBAAEHCBNNO MNHAGLFGHDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HBAAEHCBNNO GHGOODNPGFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly HBAAEHCBNNO DOOLOMGLAOM;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker DHMCJPJAOLF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker OPNKJCPFKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private GCBFJNEKOIO KBKOAGEBHFD;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool KFEPOMDHEBM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool FOFOENEBAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA247B0", Offset = "0xA233B0", VA = "0x180A247B0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA24660", Offset = "0xA23260", VA = "0x180A24660")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HBAAEHCBNNO PPJCGJPFKNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA246B0", Offset = "0xA232B0", VA = "0x180A246B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HBAAEHCBNNO PJFMDDDHJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public HBAAEHCBNNO EGCGHMDAOLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA24650", Offset = "0xA23250", VA = "0x180A24650", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LOHACKGDPPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA4B1A0", Offset = "0xA49DA0", VA = "0x180A4B1A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KPJCJJMKALE
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCBAD70", Offset = "0xCB9970", VA = "0x180CBAD70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xDAFB70", Offset = "0xDAE770", VA = "0x180DAFB70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D86480", Offset = "0x7D85080", VA = "0x187D86480", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B4F4D0", Offset = "0x7B4E0D0", VA = "0x187B4F4D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7D86E80", Offset = "0x7D85A80", VA = "0x187D86E80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xCAB820", Offset = "0xCAA420", VA = "0x180CAB820")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D86420", Offset = "0x7D85020", VA = "0x187D86420")]
		private void AJINLIEDPNM(Scene IPOHHENOLFI, LoadSceneMode KEGLMDPKKID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D86DA0", Offset = "0x7D859A0", VA = "0x187D86DA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D872C0", Offset = "0x7D85EC0", VA = "0x187D872C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D86B50", Offset = "0x7D85750", VA = "0x187D86B50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D869F0", Offset = "0x7D855F0", VA = "0x187D869F0")]
		private void KDKFDOEBMBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D87030", Offset = "0x7D85C30", VA = "0x187D87030")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D86540", Offset = "0x7D85140", VA = "0x187D86540")]
		private void CAJPOHPAJIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D86810", Offset = "0x7D85410", VA = "0x187D86810")]
		public NDEAHNEBJHO GetOrCreateCullingGroup(Type DDNNIKKLKBO, int HMHHBKJGDPC, ushort DGONEHGIAIG = 0, bool GHEPNBHCGJB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x38DFA00", Offset = "0x38DE600", VA = "0x1838DFA00")]
		public DKMOICDFJFL<T> GetOrCreateCullingGroup<T>(int HMHHBKJGDPC, ushort DGONEHGIAIG = 0, bool GHEPNBHCGJB = false) where T : class, CBIBIMNKCPL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D86EA0", Offset = "0x7D85AA0", VA = "0x187D86EA0")]
		private NDEAHNEBJHO PJNGEAMBFFE(Type DDNNIKKLKBO, int HMHHBKJGDPC, float[] GCBACLOJBHL, ushort DGONEHGIAIG = 0, bool GHEPNBHCGJB = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x38DFAA0", Offset = "0x38DE6A0", VA = "0x1838DFAA0")]
		private DKMOICDFJFL<T> PJNGEAMBFFE<T>(int HMHHBKJGDPC, float[] GCBACLOJBHL, ushort DGONEHGIAIG = 0, bool GHEPNBHCGJB = false) where T : class, CBIBIMNKCPL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D866B0", Offset = "0x7D852B0", VA = "0x187D866B0")]
		public static OEENMKMDDDK FindClosestDefaultUpdateLod(float KKPBFHPGJPB)
		{
			return default(OEENMKMDDDK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA4B660", Offset = "0xA4A260", VA = "0x180A4B660")]
		public static OEENMKMDDDK MinUpdateLod(OEENMKMDDDK BBOOKOLLADG, OEENMKMDDDK KIFNLLIFCIJ)
		{
			return default(OEENMKMDDDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D86D90", Offset = "0x7D85990", VA = "0x187D86D90")]
		public static OEENMKMDDDK MaxUpdateLod(OEENMKMDDDK BBOOKOLLADG, OEENMKMDDDK KIFNLLIFCIJ)
		{
			return default(OEENMKMDDDK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7D877A0", Offset = "0x7D863A0", VA = "0x187D877A0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA4B1A0", Offset = "0xA49DA0", VA = "0x180A4B1A0", Slot = "11")]
		private bool PNAGGHBGEHF()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LCOHMGAJFOE
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool MGIBJOOKMGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera IHMAGCIEKOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HBAAEHCBNNO OOCABLJKAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool PBMFEHPFDOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	HBAAEHCBNNO BGBLBHAGPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform MINKJFPFGPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NDEAHNEBJHO
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKAMMCABBBC(CBIBIMNKCPL KDKJDFFGNJJ, float HPDHPFDMAAO, FDCMEMEDMHG NFJHKIHIFNO = FDCMEMEDMHG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMCNGGMNMHK(CBIBIMNKCPL ABFJHPAPNOK);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJMJNCFBPEB(CBIBIMNKCPL KDKJDFFGNJJ, FDCMEMEDMHG EHIGFGKNDHP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface DKMOICDFJFL<T> : NDEAHNEBJHO where T : class, CBIBIMNKCPL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NKAMMCABBBC(T KDKJDFFGNJJ, float HPDHPFDMAAO, FDCMEMEDMHG NFJHKIHIFNO = FDCMEMEDMHG.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NKAMMCABBBC(T KDKJDFFGNJJ, Transform KOPOODDFHEE, float HPDHPFDMAAO, FDCMEMEDMHG NFJHKIHIFNO = FDCMEMEDMHG.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HMCNGGMNMHK(T ABFJHPAPNOK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PHOIIPPCIKP(T KDKJDFFGNJJ);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CBIBIMNKCPL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform NMIBCHFJGAE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(OEENMKMDDDK ABLDLIKEDBP, OEENMKMDDDK MBGHCHMLFND);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IBOKCFEKOPO);
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
