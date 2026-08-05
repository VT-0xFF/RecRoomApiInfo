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
		[Cpp2IlInjected.Address(RVA = "0x99772A0", Offset = "0x9975CA0", VA = "0x1899772A0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, VILITDXWSLN, TVCKQLHYVUU
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct UpdateBoundingSpherePositionsJob : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> data;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9977320", Offset = "0x9975D20", VA = "0x189977320", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x9975D80", Offset = "0x9974780", VA = "0x189975D80", Slot = "4")]
			public bool Equals(CullingGroupKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9975DE0", Offset = "0x99747E0", VA = "0x189975DE0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9975EB0", Offset = "0x99748B0", VA = "0x189975EB0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class TVBYBEYAIDV<a> : VPDLKMNYVDO, MEIMSPWPREI<a>, FSSDWGGYWWD where a : class, PCQSWXWWJPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x7A62800", Offset = "0x7A61200", VA = "0x187A62800")]
			internal TVBYBEYAIDV(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7A62790", Offset = "0x7A61190", VA = "0x187A62790", Slot = "12")]
			public void Add(a obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x7A62760", Offset = "0x7A61160", VA = "0x187A62760", Slot = "13")]
			public void Add(a obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7A627E0", Offset = "0x7A611E0", VA = "0x187A627E0", Slot = "14")]
			public void Remove(a objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7A627C0", Offset = "0x7A611C0", VA = "0x187A627C0", Slot = "15")]
			public bool EBPLIWGGJKT(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class VPDLKMNYVDO : IDisposable, FSSDWGGYWWD
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
				public PCQSWXWWJPE Object;

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
			private class JBYZRCRAYML
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public PCQSWXWWJPE KDWALXIIQHX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public TransformTrackRate TUHTIGKCYYZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action EVENWNKNHTS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool QSYMESDQYTL;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
				public JBYZRCRAYML()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int LXIYDIJQFVQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool KEJEZIAAGAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool WQKINWPMPUV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup QHDOIZBRVGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] GKTMQQVKWKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly LUIZRJMCROC XYPHPWBDKDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly DistanceRelativeTo IVGWZNVNTOM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<PCQSWXWWJPE, int> SIVRDXQIEFI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, JBYZRCRAYML> WVTEUVZHOYZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray AAUZVQQXTPS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> PRCWFPSTVMB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<Change> JYIIXCKBKZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool AWUXHLZCANK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle MJOEAOJBRKP;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int TJROVJCICVC
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xD10110", Offset = "0xD0EB10", VA = "0x180D10110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xD1C790", Offset = "0xD1B190", VA = "0x180D1C790")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int AFZABBIUYWV
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xDF7E00", Offset = "0xDF6800", VA = "0x180DF7E00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9978C70", Offset = "0x9977670", VA = "0x189978C70")]
			internal VPDLKMNYVDO(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x9977C70", Offset = "0x9976670", VA = "0x189977C70")]
			public void IMRZUVVHPPC(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9977730", Offset = "0x9976130", VA = "0x189977730", Slot = "5")]
			public void Add(PCQSWXWWJPE obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9977690", Offset = "0x9976090", VA = "0x189977690", Slot = "10")]
			public void Add(PCQSWXWWJPE obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x9977EE0", Offset = "0x99768E0", VA = "0x189977EE0")]
			private void OGXZJSENEDM(PCQSWXWWJPE a, Transform b, float c, TransformTrackRate d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x99781A0", Offset = "0x9976BA0", VA = "0x1899781A0", Slot = "6")]
			public void Remove(PCQSWXWWJPE objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x99782B0", Offset = "0x9976CB0", VA = "0x1899782B0")]
			private void UTCTMURTDDJ(PCQSWXWWJPE a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9978600", Offset = "0x9977000", VA = "0x189978600")]
			private void WDYXJFMRADZ(PCQSWXWWJPE a, [Optional] float? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9977BB0", Offset = "0x99765B0", VA = "0x189977BB0", Slot = "11")]
			public bool EBPLIWGGJKT(PCQSWXWWJPE a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			public void AIYPRMMKRZF(PCQSWXWWJPE a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9978200", Offset = "0x9976C00", VA = "0x189978200")]
			private void UOCRAEQAKBC(PCQSWXWWJPE a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9978880", Offset = "0x9977280", VA = "0x189978880")]
			public void WXPLSONQQFZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9978A60", Offset = "0x9977460", VA = "0x189978A60")]
			public void XVMISMYOLYO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x99773B0", Offset = "0x9975DB0", VA = "0x1899773B0")]
			private void AKYPLUFDMXU(Change a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9978930", Offset = "0x9977330", VA = "0x189978930")]
			private void XRVKUVLZELK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x99779A0", Offset = "0x99763A0", VA = "0x1899779A0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9978190", Offset = "0x9976B90", VA = "0x189978190")]
			private void OnLocalPlayerCreated()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x99773A0", Offset = "0x9975DA0", VA = "0x1899773A0")]
			private void AIXBAPMUDVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9977CA0", Offset = "0x99766A0", VA = "0x189977CA0")]
			private void IRXNHEDIEXU(CullingGroupEvent a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x9977830", Offset = "0x9976230", VA = "0x189977830")]
			private void DBVQYNBZHPH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Log KFJXTYLZRDU;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float UOPKXEQNXBD = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float AOXXMTUWDND = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float EJJUINMYMPO = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float BZHXLTYWLXI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float MNXMPZEEKFZ = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float XVOCDRGXESN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float YMCDOBQZZRO = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<CullingGroupKey, VPDLKMNYVDO> NQSRUGEMGLT;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable RNDRDTIYYBL;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable OHCIXPLFZSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly JOLHGBMRDLK UJFOTMAMNBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly JOLHGBMRDLK WASRHVWFKUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly JOLHGBMRDLK YMCHKPLKAFU;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker FWXHPHEJCQU;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker RUQMWDGZAHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private OVUANEJXOET UOBQDBCSCIG;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool PZFXEJETDOU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xDA45D0", Offset = "0xDA2FD0", VA = "0x180DA45D0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xDA45E0", Offset = "0xDA2FE0", VA = "0x180DA45E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public JOLHGBMRDLK RSJAHYWHNSG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public JOLHGBMRDLK UOCESGFHYWY
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public JOLHGBMRDLK LARAEMHJGBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool AUNVJFOOYZE
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD3D320", Offset = "0xD3BD20", VA = "0x180D3D320", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool HEYYGZFGLIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xDB5E60", Offset = "0xDB4860", VA = "0x180DB5E60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEAB150", Offset = "0xEA9B50", VA = "0x180EAB150")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9975F20", Offset = "0x9974920", VA = "0x189975F20", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9976720", Offset = "0x9975120", VA = "0x189976720")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x2400ED0", Offset = "0x23FF8D0", VA = "0x182400ED0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xDA45C0", Offset = "0xDA2FC0", VA = "0x180DA45C0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9976CC0", Offset = "0x99756C0", VA = "0x189976CC0")]
		private void SSNBVFQMBYM(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9976650", Offset = "0x9975050", VA = "0x189976650", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9976D20", Offset = "0x9975720", VA = "0x189976D20")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9976460", Offset = "0x9974E60", VA = "0x189976460")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9975FD0", Offset = "0x99749D0", VA = "0x189975FD0")]
		private void DNAZCHUHVBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x99768C0", Offset = "0x99752C0", VA = "0x1899768C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9976B50", Offset = "0x9975550", VA = "0x189976B50")]
		private void QGIUEBIDJYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9976290", Offset = "0x9974C90", VA = "0x189976290")]
		public FSSDWGGYWWD GetOrCreateCullingGroup(Type internalType, int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x38FFB90", Offset = "0x38FE590", VA = "0x1838FFB90")]
		public MEIMSPWPREI<T> GetOrCreateCullingGroup<T>(int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false) where T : class, PCQSWXWWJPE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9976740", Offset = "0x9975140", VA = "0x189976740")]
		private FSSDWGGYWWD PLUPQZNSWTW(Type a, int b, float[] c, ushort d = 0, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x38FFC50", Offset = "0x38FE650", VA = "0x1838FFC50")]
		private MEIMSPWPREI<a> PLUPQZNSWTW<a>(int a, float[] b, ushort c = 0, bool d = false) where a : class, PCQSWXWWJPE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9976130", Offset = "0x9974B30", VA = "0x189976130")]
		public static UpdateLOD FindClosestDefaultUpdateLod(float origValue)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xD3E930", Offset = "0xD3D330", VA = "0x180D3E930")]
		public static UpdateLOD MinUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9976640", Offset = "0x9975040", VA = "0x189976640")]
		public static UpdateLOD MaxUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9977170", Offset = "0x9975B70", VA = "0x189977170")]
		public CullingGroupManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xD3D320", Offset = "0xD3BD20", VA = "0x180D3D320", Slot = "11")]
		private bool KGHEHBIBOPJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface LUIZRJMCROC
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool YDRLRSHTHND
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Camera HSPNOYJGVRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		JOLHGBMRDLK MDDJBSYXZJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool IBEGJENHBDW
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		JOLHGBMRDLK ORENZUIXRGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Transform COJYSHEWKXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface FSSDWGGYWWD
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(PCQSWXWWJPE obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(PCQSWXWWJPE objectToRemove);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AIYPRMMKRZF(PCQSWXWWJPE a, TransformTrackRate b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface MEIMSPWPREI<a> : FSSDWGGYWWD where a : class, PCQSWXWWJPE
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
		bool EBPLIWGGJKT(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface PCQSWXWWJPE
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Transform AAKCKIFEUAG
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
internal class __JobReflectionRegistrationOutput__2034404287
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x9979120", Offset = "0x9977B20", VA = "0x189979120")]
	public static void WMDBIFXPSXO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x9979110", Offset = "0x9977B10", VA = "0x189979110")]
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
