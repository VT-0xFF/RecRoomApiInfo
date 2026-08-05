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
		[Cpp2IlInjected.Address(RVA = "0x82BC750", Offset = "0x82BAF50", VA = "0x1882BC750", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, ZGOKOJVGGLG, UUABPUADKWL
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct UpdateBoundingSpherePositionsJob : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> data;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x82BC7D0", Offset = "0x82BAFD0", VA = "0x1882BC7D0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x82B94F0", Offset = "0x82B7CF0", VA = "0x1882B94F0", Slot = "4")]
			public bool Equals(CullingGroupKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x82B9550", Offset = "0x82B7D50", VA = "0x1882B9550", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x82B9620", Offset = "0x82B7E20", VA = "0x1882B9620", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class KZTSDTHGPTI<a> : DQFYCKSBLSF, DBLJZMSDVPJ<a>, QVTUMJXBDFS where a : class, QKLXQYHXXNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x523CB80", Offset = "0x523B380", VA = "0x18523CB80")]
			internal KZTSDTHGPTI(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x523CB10", Offset = "0x523B310", VA = "0x18523CB10", Slot = "12")]
			public void Add(a obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x523CAE0", Offset = "0x523B2E0", VA = "0x18523CAE0", Slot = "13")]
			public void Add(a obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x523CB60", Offset = "0x523B360", VA = "0x18523CB60", Slot = "14")]
			public void Remove(a objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x523CB40", Offset = "0x523B340", VA = "0x18523CB40", Slot = "15")]
			public bool FJATVQFDFJM(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class DQFYCKSBLSF : IDisposable, QVTUMJXBDFS
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
				public QKLXQYHXXNL Object;

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
			private class WYFBUDDVUXS
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public QKLXQYHXXNL SFCABSVYSFG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public TransformTrackRate WDXXTAUXDPW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action STNKOTXJCTT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool GSDCIQUXIZK;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
				public WYFBUDDVUXS()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int BHIUXNADORL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool ABUTKGCWXHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool EWAJJDIHWIY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup MLJYJNIZGCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] XMGFIYEMZAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly KTQVHSSPLHF UBLEZUXYRFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly DistanceRelativeTo QHFCHBQBGWB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<QKLXQYHXXNL, int> WVNOFNIBJIL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, WYFBUDDVUXS> EUSDLCOHOPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray ACUMASURZGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> FTLOVLIFETO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<Change> RGTQFBLQRFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool ANJORCYHKCR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle WIMDERECOKQ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int GFPQVJXZLTF
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAAC110", Offset = "0xAAA910", VA = "0x180AAC110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAB2560", Offset = "0xAB0D60", VA = "0x180AB2560")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int PREPQZMEIXG
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB5F300", Offset = "0xB5DB00", VA = "0x180B5F300", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB5F310", Offset = "0xB5DB10", VA = "0x180B5F310")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82BC2B0", Offset = "0x82BAAB0", VA = "0x1882BC2B0")]
			internal DQFYCKSBLSF(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x82BAF00", Offset = "0x82B9700", VA = "0x1882BAF00")]
			public void ERXYTHYEADZ(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x82BA9E0", Offset = "0x82B91E0", VA = "0x1882BA9E0", Slot = "5")]
			public void Add(QKLXQYHXXNL obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x82BAAE0", Offset = "0x82B92E0", VA = "0x1882BAAE0", Slot = "10")]
			public void Add(QKLXQYHXXNL obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x82BB210", Offset = "0x82B9A10", VA = "0x1882BB210")]
			private void IDSHWKXAZPN(QKLXQYHXXNL a, Transform b, float c, TransformTrackRate d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x82BB600", Offset = "0x82B9E00", VA = "0x1882BB600", Slot = "6")]
			public void Remove(QKLXQYHXXNL objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x82BB660", Offset = "0x82B9E60", VA = "0x1882BB660")]
			private void TAYQZJLMHIE(QKLXQYHXXNL a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x82BBF80", Offset = "0x82BA780", VA = "0x1882BBF80")]
			private void VQYFAEEFWTG(QKLXQYHXXNL a, [Optional] float? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x82BAF30", Offset = "0x82B9730", VA = "0x1882BAF30", Slot = "11")]
			public bool FJATVQFDFJM(QKLXQYHXXNL a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			public void CMPNRRUPXQW(QKLXQYHXXNL a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x82BB9B0", Offset = "0x82BA1B0", VA = "0x1882BB9B0")]
			private void UBGKYPBREWH(QKLXQYHXXNL a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x82BC200", Offset = "0x82BAA00", VA = "0x1882BC200")]
			public void WZRFKEOHZEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x82BAFF0", Offset = "0x82B97F0", VA = "0x1882BAFF0")]
			public void HFBAAZXIJPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x82BBA60", Offset = "0x82BA260", VA = "0x1882BBA60")]
			private void USYTIXYBMLP(Change a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x82BB4C0", Offset = "0x82B9CC0", VA = "0x1882BB4C0")]
			private void IHPTKXBDVSB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x82BACF0", Offset = "0x82B94F0", VA = "0x1882BACF0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x82BB5F0", Offset = "0x82B9DF0", VA = "0x1882BB5F0")]
			private void OnLocalPlayerCreated()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x82BB200", Offset = "0x82B9A00", VA = "0x1882BB200")]
			private void HGVOPPWHQUN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x82BBD40", Offset = "0x82BA540", VA = "0x1882BBD40")]
			private void UUAMNPRTUHF(CullingGroupEvent a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x82BAB80", Offset = "0x82B9380", VA = "0x1882BAB80")]
			private void BYQYJRLYXHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Log KCMMMQRMHEP;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float TEAOUZUGNJY = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float AUKESJCZZRU = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BVZXVNMNYHX = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float JWFCASKFYYR = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float ANGSONZRQMC = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float IRMGKIOTCSY = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float ZWDDOCHIHNF = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<CullingGroupKey, DQFYCKSBLSF> QWTJMDWPBSK;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable FRTMMIICVDC;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable FJVSHVBJRHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly XOOCNKBZGKP PBMIAQCZYCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly XOOCNKBZGKP MRXBTUTCZES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly XOOCNKBZGKP HQYOIBURBAZ;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker FXGRVZOXIKJ;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker NVHLOHJCAXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private BFFPISQCYKM UGWSGCBEHJJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool BMPAJDUBYCJ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCD7980", Offset = "0xCD6180", VA = "0x180CD7980", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCD79B0", Offset = "0xCD61B0", VA = "0x180CD79B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public XOOCNKBZGKP GRTJEBNKDXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public XOOCNKBZGKP RVFCRDRXZPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public XOOCNKBZGKP FQQSQPTMRCW
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BGIQKZOWPXV
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xADA470", Offset = "0xAD8C70", VA = "0x180ADA470", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool WBLMYOMIWFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB9D590", Offset = "0xB9BD90", VA = "0x180B9D590", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xBF0AE0", Offset = "0xBEF2E0", VA = "0x180BF0AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82B9690", Offset = "0x82B7E90", VA = "0x1882B9690", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82B9EF0", Offset = "0x82B86F0", VA = "0x1882B9EF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x20DD780", Offset = "0x20DBF80", VA = "0x1820DD780")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1268930", Offset = "0x1267130", VA = "0x181268930")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82B9BD0", Offset = "0x82B83D0", VA = "0x1882B9BD0")]
		private void KVXENKFHIEX(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82B9E20", Offset = "0x82B8620", VA = "0x1882B9E20", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x82BA320", Offset = "0x82B8B20", VA = "0x1882BA320")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82B9C30", Offset = "0x82B8430", VA = "0x1882B9C30")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82B98A0", Offset = "0x82B80A0", VA = "0x1882B98A0")]
		private void GXSJQLNVSOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82B9F10", Offset = "0x82B8710", VA = "0x1882B9F10")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82BA5C0", Offset = "0x82B8DC0", VA = "0x1882BA5C0")]
		private void YECTUVWFBAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82B9A00", Offset = "0x82B8200", VA = "0x1882B9A00")]
		public QVTUMJXBDFS GetOrCreateCullingGroup(Type internalType, int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x356FB30", Offset = "0x356E330", VA = "0x18356FB30")]
		public DBLJZMSDVPJ<T> GetOrCreateCullingGroup<T>(int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false) where T : class, QKLXQYHXXNL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82BA1A0", Offset = "0x82B89A0", VA = "0x1882BA1A0")]
		private QVTUMJXBDFS RQNIXSMHGWT(Type a, int b, float[] c, ushort d = 0, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x356FBE0", Offset = "0x356E3E0", VA = "0x18356FBE0")]
		private DBLJZMSDVPJ<a> RQNIXSMHGWT<a>(int a, float[] b, ushort c = 0, bool d = false) where a : class, QKLXQYHXXNL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82B9740", Offset = "0x82B7F40", VA = "0x1882B9740")]
		public static UpdateLOD FindClosestDefaultUpdateLod(float origValue)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xADAB20", Offset = "0xAD9320", VA = "0x180ADAB20")]
		public static UpdateLOD MinUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82B9E10", Offset = "0x82B8610", VA = "0x1882B9E10")]
		public static UpdateLOD MaxUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82BA8B0", Offset = "0x82B90B0", VA = "0x1882BA8B0")]
		public CullingGroupManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xADA470", Offset = "0xAD8C70", VA = "0x180ADA470", Slot = "11")]
		private bool VJMNVISDHZK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface KTQVHSSPLHF
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool JZDVQOOCZTE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Camera MGIDHHHZLEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		XOOCNKBZGKP KYKJZRXUGKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool PJJUNOSRQUT
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		XOOCNKBZGKP EVSXBCRIPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Transform TDWVWDHNHSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface QVTUMJXBDFS
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(QKLXQYHXXNL obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(QKLXQYHXXNL objectToRemove);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void CMPNRRUPXQW(QKLXQYHXXNL a, TransformTrackRate b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface DBLJZMSDVPJ<a> : QVTUMJXBDFS where a : class, QKLXQYHXXNL
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
		bool FJATVQFDFJM(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface QKLXQYHXXNL
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Transform IBPLMINYERD
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
internal class __JobReflectionRegistrationOutput__3032719733
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x82BC850", Offset = "0x82BB050", VA = "0x1882BC850")]
	public static void AXVIOBQOKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x82BC8C0", Offset = "0x82BB0C0", VA = "0x1882BC8C0")]
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
