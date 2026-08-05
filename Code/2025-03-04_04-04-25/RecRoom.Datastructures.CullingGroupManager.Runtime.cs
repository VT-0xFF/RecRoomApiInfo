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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, BMCDILGALJB, NFEDKEMNHKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct BNOCCDNDEKA : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> GIDGOODJFLJ;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x74C14C0", Offset = "0x74BFAC0", VA = "0x1874C14C0", Slot = "4")]
			public void Execute(int EAHKFAJBNDN, TransformAccess EJNLPEDOMDD)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct MKHKHCLDFOA : IEquatable<MKHKHCLDFOA>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort FLAINBDOFHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type BELALMGIKPN;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x74C4BC0", Offset = "0x74C31C0", VA = "0x1874C4BC0", Slot = "4")]
			public bool Equals(MKHKHCLDFOA OKCHLIEAIJP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x74C4AD0", Offset = "0x74C30D0", VA = "0x1874C4AD0", Slot = "0")]
			public override bool Equals(object GMFKPONAANG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x74C4C40", Offset = "0x74C3240", VA = "0x1874C4C40", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class PIGLCMILLAO<T> : IIPDAPONCPL, IEHEEHPIHAN<T>, HIMACGGEFAK where T : class, BOJOEJKGENO
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5104C30", Offset = "0x5103230", VA = "0x185104C30")]
			internal PIGLCMILLAO(int LAPIPHFCIIN, float[] CEDFONGHNCB, NMKPCKOELFE GMPNFGDFDEC = NMKPCKOELFE.PlayerHead, bool COCPFEBMFCP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5104BE0", Offset = "0x51031E0", VA = "0x185104BE0", Slot = "12")]
			public void HBHDBABAKDP(T GMFKPONAANG, float PMGAIALCDAG, GPBDIJCMDDB KALKFBFMMEI = GPBDIJCMDDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5104BB0", Offset = "0x51031B0", VA = "0x185104BB0", Slot = "13")]
			public void HBHDBABAKDP(T GMFKPONAANG, Transform BJPFBGKEJJC, float PMGAIALCDAG, GPBDIJCMDDB KALKFBFMMEI = GPBDIJCMDDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5104C10", Offset = "0x5103210", VA = "0x185104C10", Slot = "14")]
			public void OCDDHDAHAOD(T EAGNCHAAGEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5104B90", Offset = "0x5103190", VA = "0x185104B90", Slot = "15")]
			public bool CIJJKLLOJMG(T GMFKPONAANG)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class IIPDAPONCPL : IDisposable, HIMACGGEFAK
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct MLFJHKNCAIF
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum JGHFPNIBEAC : byte
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
				public BOJOEJKGENO EJODNIKFKNF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform KECLKMNFMIH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float GKIFEDCHHOE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public GPBDIJCMDDB HACOFIIPNIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public JGHFPNIBEAC LNMDBHDAJAC;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum NMKPCKOELFE : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class BJLJGMIHECA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public BOJOEJKGENO EJODNIKFKNF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public GPBDIJCMDDB HEEBJBLHDIK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action DOEFPNMPCIE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool CMHNKKNKHLO;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
				public BJLJGMIHECA()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int ALOJAOINMGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool COCPFEBMFCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool LIABCKHNDHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup EJJOACMGLDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] EAOPJMGCFLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly POCEOCJDGIK MOKEOOADLAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly NMKPCKOELFE GMPNFGDFDEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<BOJOEJKGENO, int> JEFBCNHILFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, BJLJGMIHECA> FFDLEAJMNNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray HIANFFMGJEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> GPBOLLIFEAP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<MLFJHKNCAIF> HJCKNGLFNMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool GNDNMDDMGOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle NIJHHKONNDH;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int EKBCDBMLOBA
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9501A0", Offset = "0x94E7A0", VA = "0x1809501A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x959480", Offset = "0x957A80", VA = "0x180959480")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int LJJBLEKDHDA
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA35E20", Offset = "0xA34420", VA = "0x180A35E20", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAF2900", Offset = "0xAF0F00", VA = "0x180AF2900")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x74C45F0", Offset = "0x74C2BF0", VA = "0x1874C45F0")]
			internal IIPDAPONCPL(int LAPIPHFCIIN, float[] CEDFONGHNCB, NMKPCKOELFE GMPNFGDFDEC = NMKPCKOELFE.PlayerHead, bool COCPFEBMFCP = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x74C45C0", Offset = "0x74C2BC0", VA = "0x1874C45C0")]
			public void OLCPOCOMBIE(bool LGLLAKCPHMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x74C3370", Offset = "0x74C1970", VA = "0x1874C3370", Slot = "5")]
			public void HBHDBABAKDP(BOJOEJKGENO GMFKPONAANG, float PMGAIALCDAG, GPBDIJCMDDB KALKFBFMMEI = GPBDIJCMDDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x74C32D0", Offset = "0x74C18D0", VA = "0x1874C32D0", Slot = "10")]
			public void HBHDBABAKDP(BOJOEJKGENO GMFKPONAANG, Transform BJPFBGKEJJC, float PMGAIALCDAG, GPBDIJCMDDB KALKFBFMMEI = GPBDIJCMDDB.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x74C3470", Offset = "0x74C1A70", VA = "0x1874C3470")]
			private void IBFKDMIKHBJ(BOJOEJKGENO GMFKPONAANG, Transform BJPFBGKEJJC, float PMGAIALCDAG, GPBDIJCMDDB KALKFBFMMEI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x74C4560", Offset = "0x74C2B60", VA = "0x1874C4560", Slot = "6")]
			public void OCDDHDAHAOD(BOJOEJKGENO EAGNCHAAGEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x74C3B90", Offset = "0x74C2190", VA = "0x1874C3B90")]
			private void KDEJKOIOLKF(BOJOEJKGENO EAGNCHAAGEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x74C2D60", Offset = "0x74C1360", VA = "0x1874C2D60")]
			private void EHALJKNEFEK(BOJOEJKGENO GMFKPONAANG, [Optional] float? PMGAIALCDAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x74C29B0", Offset = "0x74C0FB0", VA = "0x1874C29B0", Slot = "11")]
			public bool CIJJKLLOJMG(BOJOEJKGENO GMFKPONAANG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x951A60", Offset = "0x950060", VA = "0x180951A60", Slot = "7")]
			public void MLIAPPANLDO(BOJOEJKGENO GMFKPONAANG, GPBDIJCMDDB EFJNJCHKAKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x74C2CB0", Offset = "0x74C12B0", VA = "0x1874C2CB0")]
			private void EFBFLGDLPJE(BOJOEJKGENO GMFKPONAANG, GPBDIJCMDDB EFJNJCHKAKD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x74C41E0", Offset = "0x74C27E0", VA = "0x1874C41E0")]
			public void LJHDECMAKEF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x74C3FD0", Offset = "0x74C25D0", VA = "0x1874C3FD0")]
			public void KFIPNPAJCMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x74C2FC0", Offset = "0x74C15C0", VA = "0x1874C2FC0")]
			private void EHCDPIMDCFB(MLFJHKNCAIF OPLPABIPAJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x74C4410", Offset = "0x74C2A10", VA = "0x1874C4410")]
			private void MPBFGJPIAIH(int FAEMGGEHCKJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x74C2A80", Offset = "0x74C1080", VA = "0x1874C2A80", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x74C32C0", Offset = "0x74C18C0", VA = "0x1874C32C0")]
			private void FBCELDCHBMO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x74C2A70", Offset = "0x74C1070", VA = "0x1874C2A70")]
			private void CJILGPMAHOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x74C3860", Offset = "0x74C1E60", VA = "0x1874C3860")]
			private void JPCFCLJBGEK(CullingGroupEvent BDLOGBBJFOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x74C42A0", Offset = "0x74C28A0", VA = "0x1874C42A0")]
			private void MNIIIAFJPGH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float PCFAEFPKCIP = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OLFEHLEJOAD = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FCFOJEJAEHM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NKBOOLALCFP = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float NAHECCGHMAP = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float DLNCBJLLHJD = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float KKKDEPPIDDN = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<MKHKHCLDFOA, IIPDAPONCPL> HCBPFDMKECI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable HLOOGAGLDPP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable CEEDLAPNNDC;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static FKDOIPNGGAF JBEBFPEDNAE;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static FKDOIPNGGAF FLBCJGPGPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly FKDOIPNGGAF MAICAEGDIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FKDOIPNGGAF GKNMLIDMEKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly FKDOIPNGGAF GKNFHMONFFF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker EAKAPEPEEIL;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker CMAMHBCMCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private HPLGDNGCOKN KBGENNAFOPP;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool LGLLAKCPHMM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool KOOLCCHMOJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x956CE0", Offset = "0x9552E0", VA = "0x180956CE0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x956CA0", Offset = "0x9552A0", VA = "0x180956CA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public FKDOIPNGGAF GFIEEFDKPBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9529E0", Offset = "0x950FE0", VA = "0x1809529E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public FKDOIPNGGAF DHAGLKEKPCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x954BC0", Offset = "0x9531C0", VA = "0x180954BC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public FKDOIPNGGAF PHIPHINBGOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x952DD0", Offset = "0x9513D0", VA = "0x180952DD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NDMNAAJJLNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HNFPFBKFAKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAAE930", Offset = "0xAACF30", VA = "0x180AAE930", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBA6DE0", Offset = "0xBA53E0", VA = "0x180BA6DE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x74C1540", Offset = "0x74BFB40", VA = "0x1874C1540", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x74C20F0", Offset = "0x74C06F0", VA = "0x1874C20F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1C06110", Offset = "0x1C04710", VA = "0x181C06110")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA9A340", Offset = "0xA98940", VA = "0x180A9A340")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x74C1FB0", Offset = "0x74C05B0", VA = "0x1874C1FB0")]
		private void NNBNPIGDEMK(Scene BKPGIELGADI, LoadSceneMode OALDHMLLKME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x74C2010", Offset = "0x74C0610", VA = "0x1874C2010", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x74C23B0", Offset = "0x74C09B0", VA = "0x1874C23B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x74C1DA0", Offset = "0x74C03A0", VA = "0x1874C1DA0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x74C1600", Offset = "0x74BFC00", VA = "0x1874C1600")]
		private void DCPDGMDHLMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x74C2110", Offset = "0x74C0710", VA = "0x1874C2110")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x74C1760", Offset = "0x74BFD60", VA = "0x1874C1760")]
		private void EFFNJABHBLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x74C1BC0", Offset = "0x74C01C0", VA = "0x1874C1BC0")]
		public HIMACGGEFAK GetOrCreateCullingGroup(Type BAJNLMJCMOE, int GPONADPFNIG, ushort HOBBIJIGGNB = 0, bool COCPFEBMFCP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3240FB0", Offset = "0x323F5B0", VA = "0x183240FB0")]
		public IEHEEHPIHAN<T> GetOrCreateCullingGroup<T>(int GPONADPFNIG, ushort HOBBIJIGGNB = 0, bool COCPFEBMFCP = false) where T : class, BOJOEJKGENO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74C18D0", Offset = "0x74BFED0", VA = "0x1874C18D0")]
		private HIMACGGEFAK EHNEALAIGLI(Type BAJNLMJCMOE, int GPONADPFNIG, float[] CEDFONGHNCB, ushort HOBBIJIGGNB = 0, bool COCPFEBMFCP = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3240D70", Offset = "0x323F370", VA = "0x183240D70")]
		private IEHEEHPIHAN<T> EHNEALAIGLI<T>(int GPONADPFNIG, float[] CEDFONGHNCB, ushort HOBBIJIGGNB = 0, bool COCPFEBMFCP = false) where T : class, BOJOEJKGENO
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74C1A60", Offset = "0x74C0060", VA = "0x1874C1A60")]
		public static OINJBHOKJEJ FindClosestDefaultUpdateLod(float JAPGCENNKHC)
		{
			return default(OINJBHOKJEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x97F2D0", Offset = "0x97D8D0", VA = "0x18097F2D0")]
		public static OINJBHOKJEJ MinUpdateLod(OINJBHOKJEJ BBNIOGCFOHA, OINJBHOKJEJ HFCGLOIIGCD)
		{
			return default(OINJBHOKJEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x74C1FA0", Offset = "0x74C05A0", VA = "0x1874C1FA0")]
		public static OINJBHOKJEJ MaxUpdateLod(OINJBHOKJEJ BBNIOGCFOHA, OINJBHOKJEJ HFCGLOIIGCD)
		{
			return default(OINJBHOKJEJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x74C2860", Offset = "0x74C0E60", VA = "0x1874C2860")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0", Slot = "11")]
		private bool GIDEPICAEBC()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface POCEOCJDGIK
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool APHEGLPDMMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera JJPEBOBNDFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FKDOIPNGGAF AMAOIHONDEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool KEKPPOPBDNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	FKDOIPNGGAF BGHOOKICAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform DJCAGNJFBGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HIMACGGEFAK
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBHDBABAKDP(BOJOEJKGENO GMFKPONAANG, float PMGAIALCDAG, GPBDIJCMDDB KALKFBFMMEI = GPBDIJCMDDB.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OCDDHDAHAOD(BOJOEJKGENO EAGNCHAAGEM);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MLIAPPANLDO(BOJOEJKGENO GMFKPONAANG, GPBDIJCMDDB IFNKKLJIGAD);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IEHEEHPIHAN<T> : HIMACGGEFAK where T : class, BOJOEJKGENO
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBHDBABAKDP(T GMFKPONAANG, float PMGAIALCDAG, GPBDIJCMDDB KALKFBFMMEI = GPBDIJCMDDB.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBHDBABAKDP(T GMFKPONAANG, Transform BJPFBGKEJJC, float PMGAIALCDAG, GPBDIJCMDDB KALKFBFMMEI = GPBDIJCMDDB.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCDDHDAHAOD(T EAGNCHAAGEM);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CIJJKLLOJMG(T GMFKPONAANG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface BOJOEJKGENO
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform EJNLPEDOMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(OINJBHOKJEJ AGJLPBJDELI, OINJBHOKJEJ JONIHAOOOCH);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IGJKIMIMKAB);
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
