using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Datastructures_CullingGroupManager_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Preserve]
	public class LogRegistrationIndex : GDJKPKDCEIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x83433D0", Offset = "0x83421D0", VA = "0x1883433D0", Slot = "4")]
		public override void FAIIODDINIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, LFEBOEMIPAD, HNBEDMLJAOM
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct FACKICCBAMK : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> KANAIIDGHCH;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8343350", Offset = "0x8342150", VA = "0x188343350", Slot = "4")]
			public void Execute(int JJJJBEGKNIN, TransformAccess DNNOOFELIOA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct CMCNFCCHFJI : IEquatable<CMCNFCCHFJI>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort GLKJNLOJNMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type LMIKBHMJNAE;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8341CE0", Offset = "0x8340AE0", VA = "0x188341CE0", Slot = "4")]
			public bool Equals(CMCNFCCHFJI FGAEAFBDBPK)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8341D60", Offset = "0x8340B60", VA = "0x188341D60", Slot = "0")]
			public override bool Equals(object ALGAKMGCCLO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x8341E50", Offset = "0x8340C50", VA = "0x188341E50", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class MDGCIPANDBJ<T> : NKGGOJBCOCK, HCKBAGKLCPJ<T>, CABGLNELPPL where T : class, MNPDKOKJDGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x58941B0", Offset = "0x5892FB0", VA = "0x1858941B0")]
			internal MDGCIPANDBJ(int AOOOAPLLIDM, float[] JKNFOHAOBOB, DCDPHJKMGMA AEDPBFOCKAJ = DCDPHJKMGMA.PlayerHead, bool MLNCDCLABEA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5894110", Offset = "0x5892F10", VA = "0x185894110", Slot = "12")]
			public void DPHJBDIDPOG(T ALGAKMGCCLO, float GDMMFIOGDOL, CNIFHCNMKAP GOLKGOAHKDB = CNIFHCNMKAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5894140", Offset = "0x5892F40", VA = "0x185894140", Slot = "13")]
			public void DPHJBDIDPOG(T ALGAKMGCCLO, Transform LDDKLJOLMKO, float GDMMFIOGDOL, CNIFHCNMKAP GOLKGOAHKDB = CNIFHCNMKAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5894190", Offset = "0x5892F90", VA = "0x185894190", Slot = "14")]
			public void MDNHCHGJFLC(T IDIMHHPODPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5894170", Offset = "0x5892F70", VA = "0x185894170", Slot = "15")]
			public bool HPDFDCGJNGF(T ALGAKMGCCLO)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class NKGGOJBCOCK : IDisposable, CABGLNELPPL
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct FLONLEKGBEM
			{
				[Cpp2IlInjected.Token(Token = "0x2000009")]
				public enum BPKGFAJDOEG : byte
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
				public MNPDKOKJDGI DJIEKFAGKOO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform DGABKBJAOAH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float OMNLGPDGNFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public CNIFHCNMKAP DCBKFIFGIKJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public BPKGFAJDOEG FOJLLEMFFFA;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public enum DCDPHJKMGMA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class IOGCHHEDFCB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public MNPDKOKJDGI DJIEKFAGKOO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public CNIFHCNMKAP MIMEOFONPGB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action EGIGHAGMDII;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool IBMPOGJMJJK;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
				public IOGCHHEDFCB()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int LABFPKGJNOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool MLNCDCLABEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool PJLPIIDDCCN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup DPLHENMJKML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] MMJLDDKHBMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly LKDBHNELIDF OLPMMDDOCOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly DCDPHJKMGMA AEDPBFOCKAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<MNPDKOKJDGI, int> NMKINCFHGLA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, IOGCHHEDFCB> IAAPAJMOPJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray EHONHMBCDFB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> EPOAKLFNNNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<FLONLEKGBEM> CPGCPLPDPGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool OICDKFDHIPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle CNIEIMLLGJC;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int PFGAHFCEJID
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xA93180", Offset = "0xA91F80", VA = "0x180A93180", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xA99D30", Offset = "0xA98B30", VA = "0x180A99D30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int PJBNGEHMKED
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xAE1B10", Offset = "0xAE0910", VA = "0x180AE1B10", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB8DFD0", Offset = "0xB8CDD0", VA = "0x180B8DFD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8344CF0", Offset = "0x8343AF0", VA = "0x188344CF0")]
			internal NKGGOJBCOCK(int AOOOAPLLIDM, float[] JKNFOHAOBOB, DCDPHJKMGMA AEDPBFOCKAJ = DCDPHJKMGMA.PlayerHead, bool MLNCDCLABEA = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x83436C0", Offset = "0x83424C0", VA = "0x1883436C0")]
			public void CBNLLFHCDBO(bool DFFKDOKNAJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x8343A90", Offset = "0x8342890", VA = "0x188343A90", Slot = "5")]
			public void DPHJBDIDPOG(MNPDKOKJDGI ALGAKMGCCLO, float GDMMFIOGDOL, CNIFHCNMKAP GOLKGOAHKDB = CNIFHCNMKAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x83439F0", Offset = "0x83427F0", VA = "0x1883439F0", Slot = "10")]
			public void DPHJBDIDPOG(MNPDKOKJDGI ALGAKMGCCLO, Transform LDDKLJOLMKO, float GDMMFIOGDOL, CNIFHCNMKAP GOLKGOAHKDB = CNIFHCNMKAP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8344790", Offset = "0x8343590", VA = "0x188344790")]
			private void NBKNIPHBEDP(MNPDKOKJDGI ALGAKMGCCLO, Transform LDDKLJOLMKO, float GDMMFIOGDOL, CNIFHCNMKAP GOLKGOAHKDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8344730", Offset = "0x8343530", VA = "0x188344730", Slot = "6")]
			public void MDNHCHGJFLC(MNPDKOKJDGI IDIMHHPODPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8343DD0", Offset = "0x8342BD0", VA = "0x188343DD0")]
			private void GFEJAGFLEFF(MNPDKOKJDGI IDIMHHPODPK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8343460", Offset = "0x8342260", VA = "0x188343460")]
			private void BEMFKJOHMGC(MNPDKOKJDGI ALGAKMGCCLO, [Optional] float? GDMMFIOGDOL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8344430", Offset = "0x8343230", VA = "0x188344430", Slot = "11")]
			public bool HPDFDCGJNGF(MNPDKOKJDGI ALGAKMGCCLO)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA969F0", Offset = "0xA957F0", VA = "0x180A969F0", Slot = "7")]
			public void LFFNJJAKCNJ(MNPDKOKJDGI ALGAKMGCCLO, CNIFHCNMKAP MGBLKLLNAII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8344A30", Offset = "0x8343830", VA = "0x188344A30")]
			private void NOLBOJDPBAI(MNPDKOKJDGI ALGAKMGCCLO, CNIFHCNMKAP MGBLKLLNAII)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8344AE0", Offset = "0x83438E0", VA = "0x188344AE0")]
			public void OBGEKHANCOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8344220", Offset = "0x8343020", VA = "0x188344220")]
			public void HOOLJKJBFNI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8343700", Offset = "0x8342500", VA = "0x188343700")]
			private void CHEHEPEFEOP(FLONLEKGBEM JMOOEAFLFLP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8344BA0", Offset = "0x83439A0", VA = "0x188344BA0")]
			private void PDGHEGCKBLJ(int LFFLNFPOCOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x8343B90", Offset = "0x8342990", VA = "0x188343B90", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8343DC0", Offset = "0x8342BC0", VA = "0x188343DC0")]
			private void FIJINGPNAIB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x83436F0", Offset = "0x83424F0", VA = "0x1883436F0")]
			private void CFNCGGNKCPE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x83444F0", Offset = "0x83432F0", VA = "0x1883444F0")]
			private void JLNBMGLFDMG(CullingGroupEvent JNJJKJEHCIE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x83440B0", Offset = "0x8342EB0", VA = "0x1883440B0")]
			private void GICIKNPBLOM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static ALMLLDBPKBM IPEKLICENHF;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static ALMLLDBPKBM OBJALLDCJEM;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LBNHPBBEOGG = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float FLHBGHCMLPA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float KHAJPECGAEB = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OCCEMFHNAOI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float HEFPNBHMFKA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float OFBIJPNNIBK = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float HOMOCHENKMD = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<CMCNFCCHFJI, NKGGOJBCOCK> CILNCDALFHL;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable KAPIAAJMMGH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable DCPKNIOJBKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MKAEDPHCCBC BOLMLDABLEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MKAEDPHCCBC FHELDDGIBOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly MKAEDPHCCBC HBODHMFNAIJ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker CAELMKCPJLB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker DFENELNAFJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private GMJHELKMAKL ELGPFKEHKOC;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool DFFKDOKNAJN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool GFIKDCHCPJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA98D20", Offset = "0xA97B20", VA = "0x180A98D20", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA98C40", Offset = "0xA97A40", VA = "0x180A98C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MKAEDPHCCBC IJEIOMEHJFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA98AE0", Offset = "0xA978E0", VA = "0x180A98AE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MKAEDPHCCBC BJECEHOEHEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA94B70", Offset = "0xA93970", VA = "0x180A94B70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public MKAEDPHCCBC NOHPPCJPEDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA98B10", Offset = "0xA97910", VA = "0x180A98B10", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool MIEEPFGDAKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAC1030", Offset = "0xABFE30", VA = "0x180AC1030", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ODDLEODHFFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD913C0", Offset = "0xD901C0", VA = "0x180D913C0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE7F1E0", Offset = "0xE7DFE0", VA = "0x180E7F1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8341EC0", Offset = "0x8340CC0", VA = "0x188341EC0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x80F5A40", Offset = "0x80F4840", VA = "0x1880F5A40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8342AB0", Offset = "0x83418B0", VA = "0x188342AB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD60980", Offset = "0xD5F780", VA = "0x180D60980")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8341F80", Offset = "0x8340D80", VA = "0x188341F80")]
		private void CMGHKNLCKJG(Scene OKCGKPEIJGC, LoadSceneMode KJLMJGOOKJM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x83429D0", Offset = "0x83417D0", VA = "0x1883429D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8342D60", Offset = "0x8341B60", VA = "0x188342D60")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8342480", Offset = "0x8341280", VA = "0x188342480")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8341FE0", Offset = "0x8340DE0", VA = "0x188341FE0")]
		private void DEEBJGNHMCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8342AD0", Offset = "0x83418D0", VA = "0x188342AD0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83426D0", Offset = "0x83414D0", VA = "0x1883426D0")]
		private void NGBBCEDFCHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x83422A0", Offset = "0x83410A0", VA = "0x1883422A0")]
		public CABGLNELPPL GetOrCreateCullingGroup(Type MIMMMLPGBBP, int GOJOKLHCJIH, ushort HDODCCEKPBF = 0, bool MLNCDCLABEA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C7B0", Offset = "0x3B4B5B0", VA = "0x183B4C7B0")]
		public HCKBAGKLCPJ<T> GetOrCreateCullingGroup<T>(int GOJOKLHCJIH, ushort HDODCCEKPBF = 0, bool MLNCDCLABEA = false) where T : class, MNPDKOKJDGI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8342840", Offset = "0x8341640", VA = "0x188342840")]
		private CABGLNELPPL OGEKGNMEFKM(Type MIMMMLPGBBP, int GOJOKLHCJIH, float[] JKNFOHAOBOB, ushort HDODCCEKPBF = 0, bool MLNCDCLABEA = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B4C850", Offset = "0x3B4B650", VA = "0x183B4C850")]
		private HCKBAGKLCPJ<T> OGEKGNMEFKM<T>(int GOJOKLHCJIH, float[] JKNFOHAOBOB, ushort HDODCCEKPBF = 0, bool MLNCDCLABEA = false) where T : class, MNPDKOKJDGI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8342140", Offset = "0x8340F40", VA = "0x188342140")]
		public static MJNFJJNDMDN FindClosestDefaultUpdateLod(float KEGBHPLAEPL)
		{
			return default(MJNFJJNDMDN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAC2700", Offset = "0xAC1500", VA = "0x180AC2700")]
		public static MJNFJJNDMDN MinUpdateLod(MJNFJJNDMDN FMOGOADLEAD, MJNFJJNDMDN BMLILHKNBEM)
		{
			return default(MJNFJJNDMDN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83426C0", Offset = "0x83414C0", VA = "0x1883426C0")]
		public static MJNFJJNDMDN MaxUpdateLod(MJNFJJNDMDN FMOGOADLEAD, MJNFJJNDMDN BMLILHKNBEM)
		{
			return default(MJNFJJNDMDN);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8343200", Offset = "0x8342000", VA = "0x188343200")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAC1030", Offset = "0xABFE30", VA = "0x180AC1030", Slot = "11")]
		private bool DOPDOPHOHMN()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface LKDBHNELIDF
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool GDENGIKGMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera AKCEOGFGOEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MKAEDPHCCBC HIPDIPJJGIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool GNDNFAAMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	MKAEDPHCCBC BHJBBBENKIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform NBIIDLLGMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface CABGLNELPPL
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPHJBDIDPOG(MNPDKOKJDGI ALGAKMGCCLO, float GDMMFIOGDOL, CNIFHCNMKAP GOLKGOAHKDB = CNIFHCNMKAP.Off);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDNHCHGJFLC(MNPDKOKJDGI IDIMHHPODPK);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LFFNJJAKCNJ(MNPDKOKJDGI ALGAKMGCCLO, CNIFHCNMKAP CHEMKBBOABD);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface HCKBAGKLCPJ<T> : CABGLNELPPL where T : class, MNPDKOKJDGI
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DPHJBDIDPOG(T ALGAKMGCCLO, float GDMMFIOGDOL, CNIFHCNMKAP GOLKGOAHKDB = CNIFHCNMKAP.Off);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPHJBDIDPOG(T ALGAKMGCCLO, Transform LDDKLJOLMKO, float GDMMFIOGDOL, CNIFHCNMKAP GOLKGOAHKDB = CNIFHCNMKAP.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDNHCHGJFLC(T IDIMHHPODPK);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HPDFDCGJNGF(T ALGAKMGCCLO);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface MNPDKOKJDGI
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform DNNOOFELIOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MJNFJJNDMDN PDIFOFGFMHL, MJNFJJNDMDN BBLONHDPPFO);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool KNNGNJNFEBM);
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
