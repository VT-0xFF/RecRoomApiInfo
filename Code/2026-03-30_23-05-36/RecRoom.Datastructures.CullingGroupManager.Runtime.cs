using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.DataLayer;
using RecRoom.Logging;
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
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x84DF3E0", Offset = "0x84DE1E0", VA = "0x1884DF3E0", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, QXWEXSDXBNL, ZICDSLSKRWK
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct UpdateBoundingSpherePositionsJob : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> data;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x84E11D0", Offset = "0x84DFFD0", VA = "0x1884E11D0", Slot = "4")]
			public void Execute(int index, TransformAccess transform)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private struct CullingGroupKey : IEquatable<CullingGroupKey>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort CullingGroupId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type CullingGroupInternalType;

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x84DDED0", Offset = "0x84DCCD0", VA = "0x1884DDED0", Slot = "4")]
			public bool Equals(CullingGroupKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x84DDF30", Offset = "0x84DCD30", VA = "0x1884DDF30", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x84DDFF0", Offset = "0x84DCDF0", VA = "0x1884DDFF0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class AJVKATFKZSV<a> : UYYXVJDRKXE, XZCOHOMEONQ<a>, IMYMLYJLOCB where a : class, YYJRABEDHZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5667630", Offset = "0x5666430", VA = "0x185667630")]
			internal AJVKATFKZSV(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x56675C0", Offset = "0x56663C0", VA = "0x1856675C0", Slot = "12")]
			public void Add(a obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5667590", Offset = "0x5666390", VA = "0x185667590", Slot = "13")]
			public void Add(a obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5667610", Offset = "0x5666410", VA = "0x185667610", Slot = "14")]
			public void Remove(a objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x56675F0", Offset = "0x56663F0", VA = "0x1856675F0", Slot = "15")]
			public bool IPVDNLDIUWJ(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class UYYXVJDRKXE : IDisposable, IMYMLYJLOCB
		{
			[Cpp2IlInjected.Token(Token = "0x2000008")]
			private struct Change
			{
				[Cpp2IlInjected.Token(Token = "0x2000009")]
				public enum Types : byte
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
				public YYJRABEDHZK Object;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform Transform;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float Radius;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public TransformTrackRate TrackRate;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public Types Type;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public enum DistanceRelativeTo : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			private class CHOSPIACGDX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public YYJRABEDHZK AFUAIGRNCSL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public TransformTrackRate QTZQCSVHLVN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action EUHMTEHOSOC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool IXUGUBTXDKH;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
				public CHOSPIACGDX()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int FIIOFXIYAXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool EVKPOCANRES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool ROXLLTQYQAX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup CSFBKNTFPYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] DOKZYBQTHYV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly FUHCBYEKBWY FDATSQVYVNK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly DistanceRelativeTo CHIRPOSRFUC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<YYJRABEDHZK, int> IYAZWTHBPEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, CHOSPIACGDX> KFIWKEQELWT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray ODUGCFPJDQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> CAAIPKFSMJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<Change> WKOPDQOXXEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool GEUSASGQPDY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle HFXKFSCXBIR;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int UZHSTRSKCVE
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAC6110", Offset = "0xAC4F10", VA = "0x180AC6110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAD3D80", Offset = "0xAD2B80", VA = "0x180AD3D80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int WIGCXOFLSVB
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xBD3950", Offset = "0xBD2750", VA = "0x180BD3950", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xBD3960", Offset = "0xBD2760", VA = "0x180BD3960")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x84E0D30", Offset = "0x84DFB30", VA = "0x1884E0D30")]
			internal UYYXVJDRKXE(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x84E0030", Offset = "0x84DEE30", VA = "0x1884E0030")]
			public void QLVZDKUAHMW(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x84DF740", Offset = "0x84DE540", VA = "0x1884DF740", Slot = "5")]
			public void Add(YYJRABEDHZK obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x84DF6A0", Offset = "0x84DE4A0", VA = "0x1884DF6A0", Slot = "10")]
			public void Add(YYJRABEDHZK obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x84E02D0", Offset = "0x84DF0D0", VA = "0x1884E02D0")]
			private void SECDGIHTRJW(YYJRABEDHZK a, Transform b, float c, TransformTrackRate d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x84E0060", Offset = "0x84DEE60", VA = "0x1884E0060", Slot = "6")]
			public void Remove(YYJRABEDHZK objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x84E06B0", Offset = "0x84DF4B0", VA = "0x1884E06B0")]
			private void VTOWZNCIPAJ(YYJRABEDHZK a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x84E0A00", Offset = "0x84DF800", VA = "0x1884E0A00")]
			private void VYCWROKCHND(YYJRABEDHZK a, [Optional] float? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x84DFB10", Offset = "0x84DE910", VA = "0x1884DFB10", Slot = "11")]
			public bool IPVDNLDIUWJ(YYJRABEDHZK a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			public void NUUGPFTAPZT(YYJRABEDHZK a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x84E0C80", Offset = "0x84DFA80", VA = "0x1884E0C80")]
			private void WJVKLAOZYJU(YYJRABEDHZK a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x84DFA60", Offset = "0x84DE860", VA = "0x1884DFA60")]
			public void IGVCFWVFMGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x84E00C0", Offset = "0x84DEEC0", VA = "0x1884E00C0")]
			public void SBPHZBWTPQA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x84DFBD0", Offset = "0x84DE9D0", VA = "0x1884DFBD0")]
			private void KUDRTDSIZEQ(Change a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x84E0580", Offset = "0x84DF380", VA = "0x1884E0580")]
			private void SVKAHGPCLWC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x84DF840", Offset = "0x84DE640", VA = "0x1884DF840", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x84E0020", Offset = "0x84DEE20", VA = "0x1884E0020")]
			private void OnLocalPlayerCreated()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84DFA50", Offset = "0x84DE850", VA = "0x1884DFA50")]
			private void GGEPXOLCNBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x84DF460", Offset = "0x84DE260", VA = "0x1884DF460")]
			private void AFKADOXSRRS(CullingGroupEvent a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x84DFEB0", Offset = "0x84DECB0", VA = "0x1884DFEB0")]
			private void LKIOBGMTQCP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Log CKPMOULXTMY;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float DICZKEDKGBZ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float ZFBGKABDLYP = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float FDMBSRHSLJY = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float MRRPLCCIHMI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float YBFMAPAJXIV = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float ONPZQQDQMVV = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float TDDLBKQTOKG = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<CullingGroupKey, UYYXVJDRKXE> ZYWXAHUFHYX;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable OSFZNVYELIH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable IQPQHPXWLTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly KMRHHFCXZOG HOOYNXRATAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KMRHHFCXZOG DZIEILQYDWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly KMRHHFCXZOG YIYRXMAPRMU;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker XHPEJWVQNFI;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker OIONHIBMPWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private JHHJDZQKJVL YSZMXCJLTCM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool XLXBOHDWKIS;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB5E570", Offset = "0xB5D370", VA = "0x180B5E570", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xB5E580", Offset = "0xB5D380", VA = "0x180B5E580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KMRHHFCXZOG ZHDCDOSDQUQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KMRHHFCXZOG ZDVERNBTDRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public KMRHHFCXZOG MXZKJZHQMWV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool ELZDVARIWWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAF3460", Offset = "0xAF2260", VA = "0x180AF3460", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GPWBJASFKJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB6CC80", Offset = "0xB6BA80", VA = "0x180B6CC80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC4E250", Offset = "0xC4D050", VA = "0x180C4E250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84DE060", Offset = "0x84DCE60", VA = "0x1884DE060", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84DE8C0", Offset = "0x84DD6C0", VA = "0x1884DE8C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x21934A0", Offset = "0x21922A0", VA = "0x1821934A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xB5E560", Offset = "0xB5D360", VA = "0x180B5E560")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84DE5A0", Offset = "0x84DD3A0", VA = "0x1884DE5A0")]
		private void HIXCOXQLWXQ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84DE7F0", Offset = "0x84DD5F0", VA = "0x1884DE7F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84DECF0", Offset = "0x84DDAF0", VA = "0x1884DECF0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84DE600", Offset = "0x84DD400", VA = "0x1884DE600")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84DE110", Offset = "0x84DCF10", VA = "0x1884DE110")]
		private void DTLRBMLSENB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84DE8E0", Offset = "0x84DD6E0", VA = "0x1884DE8E0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84DEFA0", Offset = "0x84DDDA0", VA = "0x1884DEFA0")]
		private void WZBFPXSIAYX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84DE3D0", Offset = "0x84DD1D0", VA = "0x1884DE3D0")]
		public IMYMLYJLOCB GetOrCreateCullingGroup(Type internalType, int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x35EBD90", Offset = "0x35EAB90", VA = "0x1835EBD90")]
		public XZCOHOMEONQ<T> GetOrCreateCullingGroup<T>(int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false) where T : class, YYJRABEDHZK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84DEB70", Offset = "0x84DD970", VA = "0x1884DEB70")]
		private IMYMLYJLOCB RFRJPMDLDOG(Type a, int b, float[] c, ushort d = 0, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x35EBE50", Offset = "0x35EAC50", VA = "0x1835EBE50")]
		private XZCOHOMEONQ<a> RFRJPMDLDOG<a>(int a, float[] b, ushort c = 0, bool d = false) where a : class, YYJRABEDHZK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84DE270", Offset = "0x84DD070", VA = "0x1884DE270")]
		public static UpdateLOD FindClosestDefaultUpdateLod(float origValue)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAF4990", Offset = "0xAF3790", VA = "0x180AF4990")]
		public static UpdateLOD MinUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x84DE7E0", Offset = "0x84DD5E0", VA = "0x1884DE7E0")]
		public static UpdateLOD MaxUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84DF2B0", Offset = "0x84DE0B0", VA = "0x1884DF2B0")]
		public CullingGroupManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAF3460", Offset = "0xAF2260", VA = "0x180AF3460", Slot = "11")]
		private bool QTWCUGTDLUJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface FUHCBYEKBWY
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool MQCLRBTFKLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Camera HPMTAYYUMYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		KMRHHFCXZOG XZPSCGGCUDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool INJXDTBQBRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		KMRHHFCXZOG ODWTBJKPDDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Transform WJTPCYZYPCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface IMYMLYJLOCB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(YYJRABEDHZK obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(YYJRABEDHZK objectToRemove);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NUUGPFTAPZT(YYJRABEDHZK a, TransformTrackRate b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface XZCOHOMEONQ<a> : IMYMLYJLOCB where a : class, YYJRABEDHZK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(a obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off);

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Add(a obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off);

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void Remove(a objectToRemove);

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool IPVDNLDIUWJ(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface YYJRABEDHZK
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Transform SKWHCKDVCZK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OnChangedDistanceBand(UpdateLOD oldDistanceBand, UpdateLOD newDistanceBand);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void OnChangedVisibility(bool isVisible);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__955869941
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x84E1260", Offset = "0x84E0060", VA = "0x1884E1260")]
	public static void UVBMKKQUWLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x84E1250", Offset = "0x84E0050", VA = "0x1884E1250")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
	}
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
