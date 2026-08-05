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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LINGKPHABBI, PMHAEKLGAHN
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct NNHNKPHIOLO : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> LLDJIJICLJF;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7471010", Offset = "0x746FC10", VA = "0x187471010", Slot = "4")]
			public void Execute(int BIEEMEKMINN, TransformAccess FDCDPIOJPOG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct IIJNFEPHAFK : IEquatable<IIJNFEPHAFK>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort NJKGALKANCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type PJEOPJKGAPH;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7470E30", Offset = "0x746FA30", VA = "0x187470E30", Slot = "4")]
			public bool Equals(IIJNFEPHAFK PELBNOCGOOJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7470EB0", Offset = "0x746FAB0", VA = "0x187470EB0", Slot = "0")]
			public override bool Equals(object CFMCKCBBBKK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7470FA0", Offset = "0x746FBA0", VA = "0x187470FA0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class NEJCDMFGHAB<T> : EHCMCEIPOAD, CLKBOBLDCDA<T>, HNBIKALEBEL where T : class, KOBEPGCLKJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4DF2C90", Offset = "0x4DF1890", VA = "0x184DF2C90")]
			internal NEJCDMFGHAB(int HEFOGNNAIDE, float[] JBLGEFCFANO, LOGCCKDFKNL OPPHPMELEKF = LOGCCKDFKNL.PlayerHead, bool CLGLKAKCJEL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4DF2C10", Offset = "0x4DF1810", VA = "0x184DF2C10", Slot = "12")]
			public void GFCJDEIJPEO(T CFMCKCBBBKK, float GHONGHPPDGL, INJLACPLDPA NIHBICJNGEM = INJLACPLDPA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4DF2C40", Offset = "0x4DF1840", VA = "0x184DF2C40", Slot = "13")]
			public void GFCJDEIJPEO(T CFMCKCBBBKK, Transform LHIBLDBDDKA, float GHONGHPPDGL, INJLACPLDPA NIHBICJNGEM = INJLACPLDPA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4DF2BF0", Offset = "0x4DF17F0", VA = "0x184DF2BF0", Slot = "14")]
			public void BLAPNJAELFA(T NNDCJJGEBKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4DF2C70", Offset = "0x4DF1870", VA = "0x184DF2C70", Slot = "15")]
			public bool PFJKOHCACDK(T CFMCKCBBBKK)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class EHCMCEIPOAD : IDisposable, HNBIKALEBEL
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct GPPOMBACKCI
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum IINCLAPIAHE : byte
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
				public KOBEPGCLKJL GGPPCPGJBHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform DKANJPNMCLP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float FCKKJPHCMOL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public INJLACPLDPA INPHIEIJAEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public IINCLAPIAHE JCIALHFDOME;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum LOGCCKDFKNL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class JAPFHFDIPGM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public KOBEPGCLKJL GGPPCPGJBHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public INJLACPLDPA LHJMPHBOHIP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action IENPIDIFLON;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool KOIOFNMALPC;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
				public JAPFHFDIPGM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int OKJDDIBBPHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool CLGLKAKCJEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool BPEPOBJKFCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup HLGCCLDPFID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] CIBCCABEIJD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly DPBFAOMNPBP JOHAHHCBBCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly LOGCCKDFKNL OPPHPMELEKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<KOBEPGCLKJL, int> NCCMHJGGBBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, JAPFHFDIPGM> DCPDOKONADC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray DMDOENLEKPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> HFOIFBGEODL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<GPPOMBACKCI> IJBLCNAGHCC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool OHDIGAHOGJN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle IEMHNEHKIEH;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int MCMFPEEFLFM
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x9571A0", Offset = "0x955DA0", VA = "0x1809571A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x95DED0", Offset = "0x95CAD0", VA = "0x18095DED0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int NBHECLPNFPA
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA3A0A0", Offset = "0xA38CA0", VA = "0x180A3A0A0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAFA930", Offset = "0xAF9530", VA = "0x180AFA930")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7470950", Offset = "0x746F550", VA = "0x187470950")]
			internal EHCMCEIPOAD(int HEFOGNNAIDE, float[] JBLGEFCFANO, LOGCCKDFKNL OPPHPMELEKF = LOGCCKDFKNL.PlayerHead, bool CLGLKAKCJEL = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x746ED10", Offset = "0x746D910", VA = "0x18746ED10")]
			public void ANGJEKNCNDD(bool BLDCPMNMFCH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x746F4B0", Offset = "0x746E0B0", VA = "0x18746F4B0", Slot = "5")]
			public void GFCJDEIJPEO(KOBEPGCLKJL CFMCKCBBBKK, float GHONGHPPDGL, INJLACPLDPA NIHBICJNGEM = INJLACPLDPA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x746F410", Offset = "0x746E010", VA = "0x18746F410", Slot = "10")]
			public void GFCJDEIJPEO(KOBEPGCLKJL CFMCKCBBBKK, Transform LHIBLDBDDKA, float GHONGHPPDGL, INJLACPLDPA NIHBICJNGEM = INJLACPLDPA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x74703D0", Offset = "0x746EFD0", VA = "0x1874703D0")]
			private void MAGLCJDMEFG(KOBEPGCLKJL CFMCKCBBBKK, Transform LHIBLDBDDKA, float GHONGHPPDGL, INJLACPLDPA NIHBICJNGEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x746ED40", Offset = "0x746D940", VA = "0x18746ED40", Slot = "6")]
			public void BLAPNJAELFA(KOBEPGCLKJL NNDCJJGEBKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x746F5B0", Offset = "0x746E1B0", VA = "0x18746F5B0")]
			private void JCKDLPJMBCE(KOBEPGCLKJL NNDCJJGEBKP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7470170", Offset = "0x746ED70", VA = "0x187470170")]
			private void LJKBJDECOIH(KOBEPGCLKJL CFMCKCBBBKK, [Optional] float? GHONGHPPDGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7470890", Offset = "0x746F490", VA = "0x187470890", Slot = "11")]
			public bool PFJKOHCACDK(KOBEPGCLKJL CFMCKCBBBKK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9595A0", Offset = "0x9581A0", VA = "0x1809595A0", Slot = "7")]
			public void GDIFHPBBDBD(KOBEPGCLKJL CFMCKCBBBKK, INJLACPLDPA LPBHNJGNABP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x74707C0", Offset = "0x746F3C0", VA = "0x1874707C0")]
			private void MKKFLHFDGLB(KOBEPGCLKJL CFMCKCBBBKK, INJLACPLDPA LPBHNJGNABP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x746F350", Offset = "0x746DF50", VA = "0x18746F350")]
			public void EPDDIPNDHNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x746EFD0", Offset = "0x746DBD0", VA = "0x18746EFD0")]
			public void EGHFHLGNBNE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x746FB40", Offset = "0x746E740", VA = "0x18746FB40")]
			private void JKHFEPCGMDI(GPPOMBACKCI NFEBCHCLBIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x746F9F0", Offset = "0x746E5F0", VA = "0x18746F9F0")]
			private void JEDEDKMIGGH(int NPJHHCLMPCE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x746EDA0", Offset = "0x746D9A0", VA = "0x18746EDA0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7470870", Offset = "0x746F470", VA = "0x187470870")]
			private void MONJPKBHECC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7470880", Offset = "0x746F480", VA = "0x187470880")]
			private void OEDGALOAMEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x746FE40", Offset = "0x746EA40", VA = "0x18746FE40")]
			private void KAKHDICLPFD(CullingGroupEvent KCJBDMFIPCC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x746F1E0", Offset = "0x746DDE0", VA = "0x18746F1E0")]
			private void EJKILHHMFNI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float GNIINAJIENJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float BKIAECAONDJ = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float JAPDBJDMGBN = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float EEAJGBJOGNH = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float HICPHHPADMJ = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JEMPINFLBJG = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GILNEAIBHHL = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<IIJNFEPHAFK, EHCMCEIPOAD> PGKDNIBIFOK;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable LAIIMDFDIDP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable IOPACACMPGD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static NCEKLMPIJLO KIANPLAOEPN;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static NCEKLMPIJLO APEJBKBIJIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly NCEKLMPIJLO DFGJIOKLGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly NCEKLMPIJLO HHFJGOMKFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly NCEKLMPIJLO JBECKIGPBGF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker ALONKPPNFFN;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker PNFEOFFDNGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NAEMDCMJKFJ GEIANNKBEFL;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool BLDCPMNMFCH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool OHHMMIABLJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x95D150", Offset = "0x95BD50", VA = "0x18095D150", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x95CF00", Offset = "0x95BB00", VA = "0x18095CF00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public NCEKLMPIJLO FODEPAFDICP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x9574C0", Offset = "0x9560C0", VA = "0x1809574C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public NCEKLMPIJLO FDDIOMLHFHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x9574D0", Offset = "0x9560D0", VA = "0x1809574D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public NCEKLMPIJLO LLINJOKALNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x95CEF0", Offset = "0x95BAF0", VA = "0x18095CEF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LLNLEDEKFGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x985A00", Offset = "0x984600", VA = "0x180985A00", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NJHJOCODALD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAB3FC0", Offset = "0xAB2BC0", VA = "0x180AB3FC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xBAC4A0", Offset = "0xBAB0A0", VA = "0x180BAC4A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x746D840", Offset = "0x746C440", VA = "0x18746D840", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x746E430", Offset = "0x746D030", VA = "0x18746E430")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1BDE8A0", Offset = "0x1BDD4A0", VA = "0x181BDE8A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA34A0", Offset = "0xAA20A0", VA = "0x180AA34A0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x746D900", Offset = "0x746C500", VA = "0x18746D900")]
		private void EBCMKLGDDIA(Scene GEINBKBBJLL, LoadSceneMode GLPFCMCNEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x746E350", Offset = "0x746CF50", VA = "0x18746E350", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x746E6E0", Offset = "0x746D2E0", VA = "0x18746E6E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x746E100", Offset = "0x746CD00", VA = "0x18746E100")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x746DFA0", Offset = "0x746CBA0", VA = "0x18746DFA0")]
		private void IEDJMGEHNOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x746E450", Offset = "0x746D050", VA = "0x18746E450")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x746DAF0", Offset = "0x746C6F0", VA = "0x18746DAF0")]
		private void FHBNGFFPAHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x746DDC0", Offset = "0x746C9C0", VA = "0x18746DDC0")]
		public HNBIKALEBEL GetOrCreateCullingGroup(Type DAMMBCMMGMM, int POBNPDPKKEK, ushort IGFLDPABIHK = 0, bool CLGLKAKCJEL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x319CC10", Offset = "0x319B810", VA = "0x18319CC10")]
		public CLKBOBLDCDA<T> GetOrCreateCullingGroup<T>(int POBNPDPKKEK, ushort IGFLDPABIHK = 0, bool CLGLKAKCJEL = false) where T : class, KOBEPGCLKJL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x746D960", Offset = "0x746C560", VA = "0x18746D960")]
		private HNBIKALEBEL EKFNMJLGIMA(Type DAMMBCMMGMM, int POBNPDPKKEK, float[] JBLGEFCFANO, ushort IGFLDPABIHK = 0, bool CLGLKAKCJEL = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x319C9D0", Offset = "0x319B5D0", VA = "0x18319C9D0")]
		private CLKBOBLDCDA<T> EKFNMJLGIMA<T>(int POBNPDPKKEK, float[] JBLGEFCFANO, ushort IGFLDPABIHK = 0, bool CLGLKAKCJEL = false) where T : class, KOBEPGCLKJL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x746DC60", Offset = "0x746C860", VA = "0x18746DC60")]
		public static CKBJHKOEDDL FindClosestDefaultUpdateLod(float HBLKFIGGFDL)
		{
			return default(CKBJHKOEDDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x986360", Offset = "0x984F60", VA = "0x180986360")]
		public static CKBJHKOEDDL MinUpdateLod(CKBJHKOEDDL KCLMHHGPGHP, CKBJHKOEDDL GNPJCDNDPDN)
		{
			return default(CKBJHKOEDDL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x746E340", Offset = "0x746CF40", VA = "0x18746E340")]
		public static CKBJHKOEDDL MaxUpdateLod(CKBJHKOEDDL KCLMHHGPGHP, CKBJHKOEDDL GNPJCDNDPDN)
		{
			return default(CKBJHKOEDDL);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x746EBC0", Offset = "0x746D7C0", VA = "0x18746EBC0")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x985A00", Offset = "0x984600", VA = "0x180985A00", Slot = "11")]
		private bool DGIDCMLKFAK()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DPBFAOMNPBP
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool DMKKDCMPDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera HPAMBKDEBFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	NCEKLMPIJLO BJJBNEMDHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool IILDCCGCFAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	NCEKLMPIJLO DCFNDCNOFMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform EAEBOFEPIJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface HNBIKALEBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFCJDEIJPEO(KOBEPGCLKJL CFMCKCBBBKK, float GHONGHPPDGL, INJLACPLDPA NIHBICJNGEM = INJLACPLDPA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BLAPNJAELFA(KOBEPGCLKJL NNDCJJGEBKP);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDIFHPBBDBD(KOBEPGCLKJL CFMCKCBBBKK, INJLACPLDPA EIKNBIDGLIC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CLKBOBLDCDA<T> : HNBIKALEBEL where T : class, KOBEPGCLKJL
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GFCJDEIJPEO(T CFMCKCBBBKK, float GHONGHPPDGL, INJLACPLDPA NIHBICJNGEM = INJLACPLDPA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFCJDEIJPEO(T CFMCKCBBBKK, Transform LHIBLDBDDKA, float GHONGHPPDGL, INJLACPLDPA NIHBICJNGEM = INJLACPLDPA.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BLAPNJAELFA(T NNDCJJGEBKP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PFJKOHCACDK(T CFMCKCBBBKK);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KOBEPGCLKJL
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform FDCDPIOJPOG
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(CKBJHKOEDDL FIABLBDDJHG, CKBJHKOEDDL IKECMDPKBFI);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BCGLHGDCEPK);
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
