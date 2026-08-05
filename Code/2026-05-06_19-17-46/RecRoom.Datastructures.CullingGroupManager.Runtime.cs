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
		[Cpp2IlInjected.Address(RVA = "0x9810D70", Offset = "0x980F770", VA = "0x189810D70", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OHMKRHMOYNJ, PBUFILHXHAU
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct UpdateBoundingSpherePositionsJob : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> data;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9810DF0", Offset = "0x980F7F0", VA = "0x189810DF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x980F860", Offset = "0x980E260", VA = "0x18980F860", Slot = "4")]
			public bool Equals(CullingGroupKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x980F8C0", Offset = "0x980E2C0", VA = "0x18980F8C0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x980F980", Offset = "0x980E380", VA = "0x18980F980", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class MQJJBDVJNYP<a> : ZVCPRDSUAKE, UOQKMQLKXMA<a>, BXGMNKSANBR where a : class, GZDKSJNECPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x702FA30", Offset = "0x702E430", VA = "0x18702FA30")]
			internal MQJJBDVJNYP(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x702F9C0", Offset = "0x702E3C0", VA = "0x18702F9C0", Slot = "12")]
			public void Add(a obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x702F990", Offset = "0x702E390", VA = "0x18702F990", Slot = "13")]
			public void Add(a obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x702F9F0", Offset = "0x702E3F0", VA = "0x18702F9F0", Slot = "14")]
			public void Remove(a objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x702FA10", Offset = "0x702E410", VA = "0x18702FA10", Slot = "15")]
			public bool UNGFHTMXQPV(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class ZVCPRDSUAKE : IDisposable, BXGMNKSANBR
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
				public GZDKSJNECPI Object;

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
			private class YQTQNASGVYH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public GZDKSJNECPI IBHQKDSXUOB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public TransformTrackRate CFHJNJKMUJH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action LJQAESSTAWY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool COEZVTHJHJD;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
				public YQTQNASGVYH()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int KNSYMVHLHKW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool WPFPFMSJTEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool PRGHQFJWEHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup IHIUATLIXXD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] FKACVQINSOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly IQONFBYBPFU YTLVACUUSYW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly DistanceRelativeTo AYGQCTXAGUE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<GZDKSJNECPI, int> UCVSCMAHVHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, YQTQNASGVYH> AMVKNYEANWR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray KUNMSACOGXG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> UMNPNAJBJHL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<Change> QVESHJGYEHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool KRQJDCTISEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle UQRSIJKHIJV;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int LAONVUOCLMA
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xCDD360", Offset = "0xCDBD60", VA = "0x180CDD360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int MKHDQSMMXKJ
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xDF2410", Offset = "0xDF0E10", VA = "0x180DF2410", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xDF2300", Offset = "0xDF0D00", VA = "0x180DF2300")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9812740", Offset = "0x9811140", VA = "0x189812740")]
			internal ZVCPRDSUAKE(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9811430", Offset = "0x980FE30", VA = "0x189811430")]
			public void EUBWUXRNNII(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9810F10", Offset = "0x980F910", VA = "0x189810F10", Slot = "5")]
			public void Add(GZDKSJNECPI obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9810E70", Offset = "0x980F870", VA = "0x189810E70", Slot = "10")]
			public void Add(GZDKSJNECPI obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9811460", Offset = "0x980FE60", VA = "0x189811460")]
			private void FGIOVTWFTMO(GZDKSJNECPI a, Transform b, float c, TransformTrackRate d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9812290", Offset = "0x9810C90", VA = "0x189812290", Slot = "6")]
			public void Remove(GZDKSJNECPI objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9811CC0", Offset = "0x98106C0", VA = "0x189811CC0")]
			private void PFEHYMMTNIH(GZDKSJNECPI a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9812010", Offset = "0x9810A10", VA = "0x189812010")]
			private void RKMXZRUGFQT(GZDKSJNECPI a, [Optional] float? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x98125D0", Offset = "0x9810FD0", VA = "0x1898125D0", Slot = "11")]
			public bool UNGFHTMXQPV(GZDKSJNECPI a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "7")]
			public void LJIZTJPCTXJ(GZDKSJNECPI a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9812690", Offset = "0x9811090", VA = "0x189812690")]
			private void ZUHSUSUHSGA(GZDKSJNECPI a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9811A90", Offset = "0x9810490", VA = "0x189811A90")]
			public void KQXUYSMBCYT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9811010", Offset = "0x980FA10", VA = "0x189811010")]
			public void CQCGVTJYTDI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x98122F0", Offset = "0x9810CF0", VA = "0x1898122F0")]
			private void SBPIQJBNOGO(Change a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9811710", Offset = "0x9810110", VA = "0x189811710")]
			private void FNLPYYWIAGM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x9811220", Offset = "0x980FC20", VA = "0x189811220", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9811CB0", Offset = "0x98106B0", VA = "0x189811CB0")]
			private void OnLocalPlayerCreated()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9811A80", Offset = "0x9810480", VA = "0x189811A80")]
			private void JEFPBOCWFHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9811840", Offset = "0x9810240", VA = "0x189811840")]
			private void FVBIRPWVJJM(CullingGroupEvent a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9811B40", Offset = "0x9810540", VA = "0x189811B40")]
			private void NJBRFERRGUB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Log CTEEAXXCAHA;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float DNAAXYEDPUN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float QYUYHSVRAQB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float QBIOAMBOGYU = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float TQHIHYGUNDQ = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float WGYWGQQIJKD = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float BBHINAWOCDL = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float MXLIJILZKBS = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<CullingGroupKey, ZVCPRDSUAKE> DGKDWSUDOIB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable QTICKAUEGRL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable NLOSDEWZWNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly PZVGSBFXRHS DGSCLTYJPYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PZVGSBFXRHS NSEVHAVCQTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly PZVGSBFXRHS CWUEKUSAMAO;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker NJAEKLCEPHK;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker LPQDHEMKZIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private NDLSPIRTFEP QVUOXYJDBYK;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool WPEPJUDVYJK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xD69260", Offset = "0xD67C60", VA = "0x180D69260", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD69270", Offset = "0xD67C70", VA = "0x180D69270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PZVGSBFXRHS OTGNTRCPKRE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public PZVGSBFXRHS RHNCBWPRCQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public PZVGSBFXRHS PUQDSKDNUPR
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BQPURYLUXMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD03250", Offset = "0xD01C50", VA = "0x180D03250", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ZSDNRDOGIKR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD7B880", Offset = "0xD7A280", VA = "0x180D7B880", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xE700D0", Offset = "0xE6EAD0", VA = "0x180E700D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x980F9F0", Offset = "0x980E3F0", VA = "0x18980F9F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9810250", Offset = "0x980EC50", VA = "0x189810250")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x23CCB80", Offset = "0x23CB580", VA = "0x1823CCB80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xD69250", Offset = "0xD67C50", VA = "0x180D69250")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x980FC00", Offset = "0x980E600", VA = "0x18980FC00")]
		private void ENJAVFGUXAM(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9810180", Offset = "0x980EB80", VA = "0x189810180", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9810500", Offset = "0x980EF00", VA = "0x189810500")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x980FF90", Offset = "0x980E990", VA = "0x18980FF90")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x980FAA0", Offset = "0x980E4A0", VA = "0x18980FAA0")]
		private void DXYTWAAVXAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9810270", Offset = "0x980EC70", VA = "0x189810270")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9810930", Offset = "0x980F330", VA = "0x189810930")]
		private void ZGIJYEVULON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x980FDC0", Offset = "0x980E7C0", VA = "0x18980FDC0")]
		public BXGMNKSANBR GetOrCreateCullingGroup(Type internalType, int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x38BCA30", Offset = "0x38BB430", VA = "0x1838BCA30")]
		public UOQKMQLKXMA<T> GetOrCreateCullingGroup<T>(int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false) where T : class, GZDKSJNECPI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x98107B0", Offset = "0x980F1B0", VA = "0x1898107B0")]
		private BXGMNKSANBR XQBJZDXWDSU(Type a, int b, float[] c, ushort d = 0, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x38BCAF0", Offset = "0x38BB4F0", VA = "0x1838BCAF0")]
		private UOQKMQLKXMA<a> XQBJZDXWDSU<a>(int a, float[] b, ushort c = 0, bool d = false) where a : class, GZDKSJNECPI
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x980FC60", Offset = "0x980E660", VA = "0x18980FC60")]
		public static UpdateLOD FindClosestDefaultUpdateLod(float origValue)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD03930", Offset = "0xD02330", VA = "0x180D03930")]
		public static UpdateLOD MinUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9810170", Offset = "0x980EB70", VA = "0x189810170")]
		public static UpdateLOD MaxUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9810C40", Offset = "0x980F640", VA = "0x189810C40")]
		public CullingGroupManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD03250", Offset = "0xD01C50", VA = "0x180D03250", Slot = "11")]
		private bool XZHRBZXTEGD()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface IQONFBYBPFU
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool OPWTTOZIYDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Camera RIVLLOJQUUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		PZVGSBFXRHS CUTTOXCUMVH
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool EXAFXLBPVME
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PZVGSBFXRHS KZAKGWDHGLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Transform IBROWWPLJMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface BXGMNKSANBR
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(GZDKSJNECPI obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(GZDKSJNECPI objectToRemove);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LJIZTJPCTXJ(GZDKSJNECPI a, TransformTrackRate b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface UOQKMQLKXMA<a> : BXGMNKSANBR where a : class, GZDKSJNECPI
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
		bool UNGFHTMXQPV(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface GZDKSJNECPI
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Transform YMEIVUOXKZE
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
internal class __JobReflectionRegistrationOutput__948341991
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9812BF0", Offset = "0x98115F0", VA = "0x189812BF0")]
	public static void ZGEXVVNGJIY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9812BE0", Offset = "0x98115E0", VA = "0x189812BE0")]
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
