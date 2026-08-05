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
		[Cpp2IlInjected.Address(RVA = "0x81D1480", Offset = "0x81D0880", VA = "0x1881D1480", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, TSWIBNBNYUH, BOJTUJLTPPK
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[BurstCompile]
		private struct UpdateBoundingSpherePositionsJob : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> data;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x81D1500", Offset = "0x81D0900", VA = "0x1881D1500", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x81CE220", Offset = "0x81CD620", VA = "0x1881CE220", Slot = "4")]
			public bool Equals(CullingGroupKey other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x81CE280", Offset = "0x81CD680", VA = "0x1881CE280", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x81CE350", Offset = "0x81CD750", VA = "0x1881CE350", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class XZESTRLFYVF<a> : JAMHUEMZMLG, PZEFPBMBSWE<a>, VXLRQMMFLYX where a : class, VBOHQQBGZUW
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0310", Offset = "0x3DDF710", VA = "0x183DE0310")]
			internal XZESTRLFYVF(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x3DE0270", Offset = "0x3DDF670", VA = "0x183DE0270", Slot = "12")]
			public void Add(a obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x3DE02A0", Offset = "0x3DDF6A0", VA = "0x183DE02A0", Slot = "13")]
			public void Add(a obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x3DE02F0", Offset = "0x3DDF6F0", VA = "0x183DE02F0", Slot = "14")]
			public void Remove(a objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x3DE02D0", Offset = "0x3DDF6D0", VA = "0x183DE02D0", Slot = "15")]
			public bool FYIXIFOARZB(a a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		private class JAMHUEMZMLG : IDisposable, VXLRQMMFLYX
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
				public VBOHQQBGZUW Object;

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
			private class SDMNSNUNMLZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public VBOHQQBGZUW WQEGLNTSVEN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public TransformTrackRate BEOPATQACRL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action BEBJRYOWKTS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool RUZGASCTJWN;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
				public SDMNSNUNMLZ()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int JLBIMWTRCJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool PNXSWPZAXLK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool TEMRMIPWZPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup QCZJGXXEVNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] EPFBCXZKJXN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly QHISNLUDLFQ NLKAWVWHGGW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly DistanceRelativeTo QRWOMFAOBKQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<VBOHQQBGZUW, int> NCKXSNIOIUO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, SDMNSNUNMLZ> CMWPGYOAHON;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray ENOHGZGYSIA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> CIYRUGFXIWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<Change> OJHKZFAFRVO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool TJWYGQWLYXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle TLDZVZKMJXZ;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int EUWTVARZZNK
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xAA2110", Offset = "0xAA1510", VA = "0x180AA2110", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xAA5C90", Offset = "0xAA5090", VA = "0x180AA5C90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int MKBDZLPKCND
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0xB2FE10", Offset = "0xB2F210", VA = "0x180B2FE10", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xB2FE20", Offset = "0xB2F220", VA = "0x180B2FE20")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x81D0FE0", Offset = "0x81D03E0", VA = "0x1881D0FE0")]
			internal JAMHUEMZMLG(int a, float[] b, DistanceRelativeTo c = DistanceRelativeTo.PlayerHead, bool d = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x81CFEE0", Offset = "0x81CF2E0", VA = "0x1881CFEE0")]
			public void CONLUUPVWFO(bool a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x81CFB00", Offset = "0x81CEF00", VA = "0x1881CFB00", Slot = "5")]
			public void Add(VBOHQQBGZUW obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x81CFA60", Offset = "0x81CEE60", VA = "0x1881CFA60", Slot = "10")]
			public void Add(VBOHQQBGZUW obj, Transform objTransform, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x81D0120", Offset = "0x81CF520", VA = "0x1881D0120")]
			private void EXOGCICJKOK(VBOHQQBGZUW a, Transform b, float c, TransformTrackRate d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x81D0F70", Offset = "0x81D0370", VA = "0x1881D0F70", Slot = "6")]
			public void Remove(VBOHQQBGZUW objectToRemove)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x81CF710", Offset = "0x81CEB10", VA = "0x1881CF710")]
			private void AIYWEAJTTFZ(VBOHQQBGZUW a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x81D0B70", Offset = "0x81CFF70", VA = "0x1881D0B70")]
			private void NCKVWEQOMHF(VBOHQQBGZUW a, [Optional] float? b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x81D0610", Offset = "0x81CFA10", VA = "0x1881D0610", Slot = "11")]
			public bool FYIXIFOARZB(VBOHQQBGZUW a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xAA3150", Offset = "0xAA2550", VA = "0x180AA3150", Slot = "7")]
			public void ATBYVZKLMHR(VBOHQQBGZUW a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x81D0A10", Offset = "0x81CFE10", VA = "0x1881D0A10")]
			private void JADFSTBEZKQ(VBOHQQBGZUW a, TransformTrackRate b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x81D0AC0", Offset = "0x81CFEC0", VA = "0x1881D0AC0")]
			public void LZKBRHXPUOT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x81D0800", Offset = "0x81CFC00", VA = "0x1881D0800")]
			public void IGIFKLPLKZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x81CFC00", Offset = "0x81CF000", VA = "0x1881CFC00")]
			private void BUDRRCVWCFE(Change a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x81D06D0", Offset = "0x81CFAD0", VA = "0x1881D06D0")]
			private void HVBJNFEIXNW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x81CFF10", Offset = "0x81CF310", VA = "0x1881CFF10", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x81D0DF0", Offset = "0x81D01F0", VA = "0x1881D0DF0")]
			private void OnLocalPlayerCreated()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x81D0FD0", Offset = "0x81D03D0", VA = "0x1881D0FD0")]
			private void ZVWTIGRKODU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x81D03D0", Offset = "0x81CF7D0", VA = "0x1881D03D0")]
			private void FNNPTYKEUFM(CullingGroupEvent a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x81D0E00", Offset = "0x81D0200", VA = "0x1881D0E00")]
			private void RLPHOEIHDBX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static Log UMMIJRFVMAQ;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static Log YFVQIGEGCGG;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LVCWNNDHDYJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float RTUNPZOOZVH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float ELTDOQSTTVS = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float VYUTTFPJHUK = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GPPAFWTGYAH = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private const float MXHIZIVZSEF = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private const float WAVNCQIUULC = 500f;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private readonly Dictionary<CullingGroupKey, JAMHUEMZMLG> AFQRTDLIKIV;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static IDisposable ADNYTWJBVRD;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static IDisposable PXVTDXMKLAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly OAGBKHNZSHS SYTLZZBPATX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly OAGBKHNZSHS MRKUZMHKOVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly OAGBKHNZSHS QFCNEUACUHU;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker WHFWFMZYBUU;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker UZRLXFVMOUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private ARAECGCQSWT MZBVZAQRPAW;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool ESMGWEYJPPG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCA7840", Offset = "0xCA6C40", VA = "0x180CA7840", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCA7820", Offset = "0xCA6C20", VA = "0x180CA7820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OAGBKHNZSHS RSZIFHCGBSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public OAGBKHNZSHS MPAIPODYEBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public OAGBKHNZSHS EQTQGIRZKMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HZQXUDUTWXM
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAD03D0", Offset = "0xACF7D0", VA = "0x180AD03D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool ZFSCXWLJPEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB70030", Offset = "0xB6F430", VA = "0x180B70030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xBB9E40", Offset = "0xBB9240", VA = "0x180BB9E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x81CE530", Offset = "0x81CD930", VA = "0x1881CE530", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81CEEB0", Offset = "0x81CE2B0", VA = "0x1881CEEB0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x209F630", Offset = "0x209EA30", VA = "0x18209F630")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x12225B0", Offset = "0x12219B0", VA = "0x1812225B0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x81CF400", Offset = "0x81CE800", VA = "0x1881CF400")]
		private void WVBIKHFQAKY(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x81CEDE0", Offset = "0x81CE1E0", VA = "0x1881CEDE0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x81CF160", Offset = "0x81CE560", VA = "0x1881CF160")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x81CEA70", Offset = "0x81CDE70", VA = "0x1881CEA70")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x81CE910", Offset = "0x81CDD10", VA = "0x1881CE910")]
		private void KEIUWNWMPAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x81CEED0", Offset = "0x81CE2D0", VA = "0x1881CEED0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x81CE3C0", Offset = "0x81CD7C0", VA = "0x1881CE3C0")]
		private void AEISKEHYBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x81CE740", Offset = "0x81CDB40", VA = "0x1881CE740")]
		public VXLRQMMFLYX GetOrCreateCullingGroup(Type internalType, int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3568B80", Offset = "0x3567F80", VA = "0x183568B80")]
		public PZEFPBMBSWE<T> GetOrCreateCullingGroup<T>(int cullingGroupArraySize, ushort cullingGroupId = 0, bool isStatic = false) where T : class, VBOHQQBGZUW
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x81CEC60", Offset = "0x81CE060", VA = "0x1881CEC60")]
		private VXLRQMMFLYX NZTPNMSMEMI(Type a, int b, float[] c, ushort d = 0, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3568C30", Offset = "0x3568030", VA = "0x183568C30")]
		private PZEFPBMBSWE<a> NZTPNMSMEMI<a>(int a, float[] b, ushort c = 0, bool d = false) where a : class, VBOHQQBGZUW
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x81CE5E0", Offset = "0x81CD9E0", VA = "0x1881CE5E0")]
		public static UpdateLOD FindClosestDefaultUpdateLod(float origValue)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xAD0A00", Offset = "0xACFE00", VA = "0x180AD0A00")]
		public static UpdateLOD MinUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81CEC50", Offset = "0x81CE050", VA = "0x1881CEC50")]
		public static UpdateLOD MaxUpdateLod(UpdateLOD lod1, UpdateLOD lod2)
		{
			return default(UpdateLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81CF5E0", Offset = "0x81CE9E0", VA = "0x1881CF5E0")]
		public CullingGroupManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xAD03D0", Offset = "0xACF7D0", VA = "0x180AD03D0", Slot = "11")]
		private bool WNYETKALIBJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface QHISNLUDLFQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		bool RIKLGGUTZYB
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		Camera NPUJSEHVOBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		OAGBKHNZSHS VAZZSIWQMVD
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		bool EPFMNLMLFZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		OAGBKHNZSHS ZXMJEYOJSGY
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(Slot = "6")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		Transform NPRAJQZZGJE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(Slot = "7")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface VXLRQMMFLYX
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Add(VBOHQQBGZUW obj, float radius, TransformTrackRate transformTrackRate = TransformTrackRate.Off);

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Remove(VBOHQQBGZUW objectToRemove);

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ATBYVZKLMHR(VBOHQQBGZUW a, TransformTrackRate b);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface PZEFPBMBSWE<a> : VXLRQMMFLYX where a : class, VBOHQQBGZUW
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
		bool FYIXIFOARZB(a a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface VBOHQQBGZUW
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		Transform FSOLSSJPOTM
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
internal class __JobReflectionRegistrationOutput__1552506904
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x81D1590", Offset = "0x81D0990", VA = "0x1881D1590")]
	public static void JRNZJIULILS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x81D1580", Offset = "0x81D0980", VA = "0x1881D1580")]
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
