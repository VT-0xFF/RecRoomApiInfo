using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using AOT;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.ClusterLODs;
using RecRoom.Configs;
using RecRoom.Core.Creation;
using RecRoom.Core.Creation.Shapes;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Collections;
using RecRoom.Foundation.Mathematics;
using RecRoom.Foundation.Transforms;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.MCluster;
using RecRoom.RendererV1;
using RecRoom.RendererV1.DataProviders;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8E41940", Offset = "0x8E40340", VA = "0x188E41940")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAE09F0", Offset = "0xADF3F0", VA = "0x180AE09F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E41880", Offset = "0x8E40280", VA = "0x188E41880", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_ShapeRendering_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E4C6A0", Offset = "0x8E4B0A0", VA = "0x188E4C6A0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2748530", Offset = "0x2746F30", VA = "0x182748530")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ClusterLODSkinnedRenderer : GUNFFEPKLLT, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private byte OBMCOJBSXUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<SkinnedShapeRenderer>[] LCKWUQPGELB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int TQJBYHKBBBW
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAC76A0", Offset = "0xAC60A0", VA = "0x180AC76A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB11380", Offset = "0xB0FD80", VA = "0x180B11380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int CZCIVVLHOFT
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xADEA30", Offset = "0xADD430", VA = "0x180ADEA30", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xC2ACC0", Offset = "0xC296C0", VA = "0x180C2ACC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float AMSUKLLUEAS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE03BE0", Offset = "0xE025E0", VA = "0x180E03BE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x111E240", Offset = "0x111CC40", VA = "0x18111E240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float COBMKUVTPGS
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xBC1CF0", Offset = "0xBC06F0", VA = "0x180BC1CF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xC3E210", Offset = "0xC3CC10", VA = "0x180C3E210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public List<SkinnedShapeRenderer> GLDMFAFPEMQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8E3A7B0", Offset = "0x8E391B0", VA = "0x188E3A7B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<SkinnedShapeRenderer> GMJYJBWJTDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8E3A590", Offset = "0x8E38F90", VA = "0x188E3A590")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GameObject XQVYPEOBNLV
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAB85F0", Offset = "0xAB6FF0", VA = "0x180AB85F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAB85C0", Offset = "0xAB6FC0", VA = "0x180AB85C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public byte AVSZTEAHMXC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8E3A720", Offset = "0x8E39120", VA = "0x188E3A720", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A800", Offset = "0x8E39200", VA = "0x188E3A800")]
		public ClusterLODSkinnedRenderer(List<OWSADHSJZFB> lod0Meshes, List<OWSADHSJZFB> lod1Meshes, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A320", Offset = "0x8E38D20", VA = "0x188E3A320")]
		private int FMOQZRAEDJA(List<OWSADHSJZFB> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A5C0", Offset = "0x8E38FC0", VA = "0x188E3A5C0")]
		private void QLQDVZCWJXT(int a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A440", Offset = "0x8E38E40", VA = "0x188E3A440")]
		public void HGHHFQXGGTO(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A220", Offset = "0x8E38C20", VA = "0x188E3A220", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A770", Offset = "0x8E39170", VA = "0x188E3A770")]
		public void XRMKIAITSVB(Transform a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class PTGLBXQZGYV : EVOEIDSSYTG, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class YVPWJNYIRXL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Renderer YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PTGLBXQZGYV VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private List<ClusterMeshRenderer>.Enumerator RECIBZUSAYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private IEnumerator<Renderer> REHOZGOPKJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private IEnumerator<MeshRenderer> REMVWNIMTVH;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private Renderer EGIRMPLZYNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
			[DebuggerHidden]
			public YVPWJNYIRXL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8E4C380", Offset = "0x8E4AD80", VA = "0x188E4C380", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8E4BE70", Offset = "0x8E4A870", VA = "0x188E4BE70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8E4C570", Offset = "0x8E4AF70", VA = "0x188E4C570")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8E4C610", Offset = "0x8E4B010", VA = "0x188E4C610")]
			private void SONMORMKPTT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8E4C5C0", Offset = "0x8E4AFC0", VA = "0x188E4C5C0")]
			private void SOIFRKSNGIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8E4C660", Offset = "0x8E4B060", VA = "0x188E4C660", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8E4BDD0", Offset = "0x8E4A7D0", VA = "0x188E4BDD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> BEJAIZOJMCP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8E4BDD0", Offset = "0x8E4A7D0", VA = "0x188E4BDD0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DTJGBYMSJXD : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private Renderer YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public PTGLBXQZGYV VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<Renderer> RECIBZUSAYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private List<SkinnedShapeRenderer>.Enumerator REHOZGOPKJY;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private Renderer EGIRMPLZYNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
			[DebuggerHidden]
			public DTJGBYMSJXD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B1F0", Offset = "0x8E39BF0", VA = "0x188E3B1F0", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8E3AE80", Offset = "0x8E39880", VA = "0x188E3AE80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B320", Offset = "0x8E39D20", VA = "0x188E3B320")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B370", Offset = "0x8E39D70", VA = "0x188E3B370")]
			private void SONMORMKPTT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B3C0", Offset = "0x8E39DC0", VA = "0x188E3B3C0", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8E3ADE0", Offset = "0x8E397E0", VA = "0x188E3ADE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> BEJAIZOJMCP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8E3ADE0", Offset = "0x8E397E0", VA = "0x188E3ADE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SSHTJQDXJWC CRTIVEXUBQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<DBBPVSJUAQL> JRDOOKUTDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private List<ClusterMeshRenderer> EFKHSJIVBMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BatchedMeshRenderer AMDZMVBAJHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool XLHUXDYQVCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly bool EGIAPAVMLGN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IEnumerable<PIVAIXQLOVL> IRIQIHCDKUA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int VLSNYNNZCRI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8E431E0", Offset = "0x8E41BE0", VA = "0x188E431E0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RRTransform SFBSZHZNLLP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8E43590", Offset = "0x8E41F90", VA = "0x188E43590", Slot = "8")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public List<SkinnedShapeRenderer> TUTWGBAALMG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8E431C0", Offset = "0x8E41BC0", VA = "0x188E431C0")]
		private bool ICDQVIIEHUF(DBBPVSJUAQL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8E43120", Offset = "0x8E41B20", VA = "0x188E43120")]
		private static bool GNKRYBTDWZR(DBBPVSJUAQL a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8E44600", Offset = "0x8E43000", VA = "0x188E44600")]
		public PTGLBXQZGYV(SSHTJQDXJWC a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8E42F30", Offset = "0x8E41930", VA = "0x188E42F30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E42C70", Offset = "0x8E41670", VA = "0x188E42C70")]
		public void Add(DBBPVSJUAQL shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8E43430", Offset = "0x8E41E30", VA = "0x188E43430")]
		public void Remove(DBBPVSJUAQL shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E43660", Offset = "0x8E42060", VA = "0x188E43660", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8E43DE0", Offset = "0x8E427E0", VA = "0x188E43DE0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8E43B70", Offset = "0x8E42570", VA = "0x188E43B70")]
		private void TKHAQAQLNYN(List<DBBPVSJUAQL> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8E3FA40", Offset = "0x8E3E440", VA = "0x188E3FA40")]
		private static Material GAEPZLIDCNR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E43D30", Offset = "0x8E42730", VA = "0x188E43D30")]
		private void TKHAQAQLNYN(DBBPVSJUAQL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8E43220", Offset = "0x8E41C20", VA = "0x188E43220")]
		private void JPHFNWSRHCP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E44050", Offset = "0x8E42A50", VA = "0x188E44050")]
		public void VHXJMDWTXMC(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8E432F0", Offset = "0x8E41CF0", VA = "0x188E432F0")]
		protected void LOJOTNGTRRE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8E433B0", Offset = "0x8E41DB0", VA = "0x188E433B0")]
		public void OCMQKZHZDGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E42EB0", Offset = "0x8E418B0", VA = "0x188E42EB0")]
		[IteratorStateMachine(typeof(YVPWJNYIRXL))]
		public IEnumerable<Renderer> BYMKSPLRDGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8E43140", Offset = "0x8E41B40", VA = "0x188E43140")]
		[IteratorStateMachine(typeof(DTJGBYMSJXD))]
		public IEnumerable<Renderer> GXGHXFKQPMW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[BurstCompile]
	internal class LSWWQEYRNYF : DBBPVSJUAQL
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct CurveToken : WLNUANDGASB, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private NativeMesh mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private JobHandle jobHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private CurveMeshGeneratorData genData;

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8E3AB90", Offset = "0x8E39590", VA = "0x188E3AB90")]
			public CurveToken(NativeMesh mesh, JobHandle jobHandle, CurveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8E3AB10", Offset = "0x8E39510", VA = "0x188E3AB10", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8E3AB40", Offset = "0x8E39540", VA = "0x188E3AB40", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate void CalculateFastCurveBounds_00000039$PostfixBurstDelegate([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class GNARUWBJOGT
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr NBMNCECCVPO;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8E3BD20", Offset = "0x8E3A720", VA = "0x188E3BD20")]
			[BurstDiscard]
			private static void SEPJJVIVUGU(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8E3BEB0", Offset = "0x8E3A8B0", VA = "0x188E3BEB0")]
			private static IntPtr XCHCCHVYGKC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B980", Offset = "0x8E3A380", VA = "0x188E3B980")]
			public unsafe static void Invoke([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal readonly SKIPEFDZDRT QODGAZOBYCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float GSDMOYTRPFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Hash128 NQOPFNLAJDS;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override Hash128 PPRVZNFSWOG
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8E41190", Offset = "0x8E3FB90", VA = "0x188E41190", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8E417D0", Offset = "0x8E401D0", VA = "0x188E417D0")]
		public LSWWQEYRNYF(PTGLBXQZGYV a, SKIPEFDZDRT b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "18")]
		public override bool UQNRHUMYPUF(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8E3FF20", Offset = "0x8E3E920", VA = "0x188E3FF20", Slot = "19")]
		public override int FMOQZRAEDJA(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8E40AC0", Offset = "0x8E3F4C0", VA = "0x188E40AC0", Slot = "20")]
		public override int OMKJOQUGFSK(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E40F60", Offset = "0x8E3F960", VA = "0x188E40F60", Slot = "21")]
		public override RRBounds RIJMDGUOIAC()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8E40AB0", Offset = "0x8E3F4B0", VA = "0x188E40AB0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastCurveBounds_00000039$PostfixBurstDelegate))]
		private unsafe static void NYSFXUHYOFZ([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB8F570", Offset = "0xB8DF70", VA = "0x180B8F570", Slot = "22")]
		public override float TMYZYPVBZLA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8E412C0", Offset = "0x8E3FCC0", VA = "0x188E412C0", Slot = "23")]
		public override void YTXGIISJFDA(SystemLOD a, PGMWEXGQDYL b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8E40100", Offset = "0x8E3EB00", VA = "0x188E40100")]
		private int GOXGRQJXJJJ(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8E40E90", Offset = "0x8E3F890", VA = "0x188E40E90", Slot = "24")]
		public override RRTransform QTGQHTXHILN()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8E3FD70", Offset = "0x8E3E770", VA = "0x188E3FD70", Slot = "26")]
		public override MaterialInfo CDUAHSCRRSU()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8E402F0", Offset = "0x8E3ECF0", VA = "0x188E402F0", Slot = "27")]
		public override WLNUANDGASB HHHGRNQUQZA(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8E40CA0", Offset = "0x8E3F6A0", VA = "0x188E40CA0")]
		[BurstCompile]
		public unsafe static void QRTYPQMNJKC([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OKMQDIYWSJS
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		PTGLBXQZGYV this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		DBBPVSJUAQL this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		JURPSZYUJWC this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AJUKXUBBJHH : NUOTBWOORLZ, IDisposable, OKMQDIYWSJS
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private struct <EndRoomLoad>d__28 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AJUKXUBBJHH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8E4A9B0", Offset = "0x8E493B0", VA = "0x188E4A9B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8E4AF00", Offset = "0x8E49900", VA = "0x188E4AF00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly HDOIECNDPJE<RootHandle, PTGLBXQZGYV> XWFQATULCTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HDOIECNDPJE<ShapeHandle, DBBPVSJUAQL> JRDOOKUTDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly HDOIECNDPJE<SkinnedCostumeHandle, JURPSZYUJWC> ECNKSSNLJDM;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PTGLBXQZGYV this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8E3A100", Offset = "0x8E38B00", VA = "0x188E3A100", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DBBPVSJUAQL this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8E3A040", Offset = "0x8E38A40", VA = "0x188E3A040", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public JURPSZYUJWC this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8E3A0A0", Offset = "0x8E38AA0", VA = "0x188E3A0A0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool ATDNGVGKYWA
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F20", Offset = "0xCB1920", VA = "0x180CB2F20", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F30", Offset = "0xCB1930", VA = "0x180CB2F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8E39BF0", Offset = "0x8E385F0", VA = "0x188E39BF0")]
		public AJUKXUBBJHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8E381B0", Offset = "0x8E36BB0", VA = "0x188E381B0", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E39980", Offset = "0x8E38380", VA = "0x188E39980", Slot = "4")]
		public RootHandle XUEFKLSFKJI(SSHTJQDXJWC a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8E39990", Offset = "0x8E38390", VA = "0x188E39990", Slot = "5")]
		public RootHandle XUEFKLSFKJI(SSHTJQDXJWC a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8E394E0", Offset = "0x8E37EE0", VA = "0x188E394E0", Slot = "6")]
		public void UAYGAGJLKKP(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8E38E20", Offset = "0x8E37820", VA = "0x188E38E20", Slot = "7")]
		public void TAPWDQGXPOG(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8E37C20", Offset = "0x8E36620", VA = "0x188E37C20", Slot = "8")]
		public ShapeHandle AKPSPPBTYIT(RootHandle a, KXLVYSPVNJF b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8E38590", Offset = "0x8E36F90", VA = "0x188E38590", Slot = "9")]
		public ShapeHandle KYSVMZUAWYR(RootHandle a, SKIPEFDZDRT b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8E39150", Offset = "0x8E37B50", VA = "0x188E39150", Slot = "11")]
		public void TLLRUYRZBRZ(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8E39730", Offset = "0x8E38130", VA = "0x188E39730", Slot = "10")]
		public void WLANAKXPQUY(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8E38DB0", Offset = "0x8E377B0", VA = "0x188E38DB0", Slot = "20")]
		public IEnumerable<Renderer> RQHHWDLBXRJ(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8E38440", Offset = "0x8E36E40", VA = "0x188E38440", Slot = "12")]
		public SkinnedCostumeHandle FIVYVKCEEGZ(WFKEISUZKLO a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8E38520", Offset = "0x8E36F20", VA = "0x188E38520", Slot = "14")]
		public void ITSOWJXZLRC(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8E38A40", Offset = "0x8E37440", VA = "0x188E38A40", Slot = "16")]
		public Task MIPMDLVTVBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8E38C00", Offset = "0x8E37600", VA = "0x188E38C00", Slot = "17")]
		public Task OWHPVTJDAQW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8E38370", Offset = "0x8E36D70", VA = "0x188E38370", Slot = "18")]
		[AsyncStateMachine(typeof(<EndRoomLoad>d__28))]
		public Task EZRSXWIMOFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8E380C0", Offset = "0x8E36AC0", VA = "0x188E380C0", Slot = "19")]
		public void BFWMVIVQVBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8E384C0", Offset = "0x8E36EC0", VA = "0x188E384C0", Slot = "13")]
		public void GAFJFUUKORD(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[BurstCompile]
	internal class HGZIMOSHMSL : DBBPVSJUAQL
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct PrimitiveToken : WLNUANDGASB, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private NativeMesh mesh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private NativeArray<int> vertCollapseTarget;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private JobHandle jobHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			private PrimitiveMeshGeneratorData genData;

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8E447F0", Offset = "0x8E431F0", VA = "0x188E447F0")]
			public PrimitiveToken(NativeMesh mesh, NativeArray<int> vertCollapseTarget, JobHandle jobHandle, PrimitiveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8E446F0", Offset = "0x8E430F0", VA = "0x188E446F0", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8E44750", Offset = "0x8E43150", VA = "0x188E44750", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public delegate void CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class XRNPLIFMKTR
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private static IntPtr NBMNCECCVPO;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8E4BAC0", Offset = "0x8E4A4C0", VA = "0x188E4BAC0")]
			[BurstDiscard]
			private static void SEPJJVIVUGU(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8E4BC50", Offset = "0x8E4A650", VA = "0x188E4BC50")]
			private static IntPtr XCHCCHVYGKC()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8E4B8B0", Offset = "0x8E4A2B0", VA = "0x188E4B8B0")]
			public static void Invoke([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly KXLVYSPVNJF DQYIQAERBXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int[] ECUVDHXIAZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Hash128 NQOPFNLAJDS;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector3 JWFYYFHAPMW
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8E3D0E0", Offset = "0x8E3BAE0", VA = "0x188E3D0E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override Hash128 PPRVZNFSWOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8E3DA00", Offset = "0x8E3C400", VA = "0x188E3DA00", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E450", Offset = "0x8E3CE50", VA = "0x188E3E450")]
		public HGZIMOSHMSL(PTGLBXQZGYV a, KXLVYSPVNJF b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8E3DB30", Offset = "0x8E3C530", VA = "0x188E3DB30", Slot = "18")]
		public override bool UQNRHUMYPUF(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8E3D6C0", Offset = "0x8E3C0C0", VA = "0x188E3D6C0", Slot = "21")]
		public override RRBounds RIJMDGUOIAC()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8E3D3E0", Offset = "0x8E3BDE0", VA = "0x188E3D3E0")]
		private RRBounds RIJMDGUOIAC(RRTransform a)
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8E3D900", Offset = "0x8E3C300", VA = "0x188E3D900")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate))]
		private static void SWOAYUGOFWR([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8E3D700", Offset = "0x8E3C100", VA = "0x188E3D700")]
		private OcclusionData ROWOBBEOXEW([In] UniformTRS worldFromLocalUniformTRS, [In] float3 worldScale)
		{
			return default(OcclusionData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8E3C570", Offset = "0x8E3AF70", VA = "0x188E3C570", Slot = "19")]
		public override int FMOQZRAEDJA(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8E3D030", Offset = "0x8E3BA30", VA = "0x188E3D030", Slot = "20")]
		public override int OMKJOQUGFSK(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8E3D910", Offset = "0x8E3C310", VA = "0x188E3D910", Slot = "22")]
		public override float TMYZYPVBZLA()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8E3CDB0", Offset = "0x8E3B7B0", VA = "0x188E3CDB0")]
		private int MIBVJPBXPYA(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8E3DC00", Offset = "0x8E3C600", VA = "0x188E3DC00", Slot = "23")]
		public override void YTXGIISJFDA(SystemLOD a, PGMWEXGQDYL b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8E3D310", Offset = "0x8E3BD10", VA = "0x188E3D310", Slot = "24")]
		public override RRTransform QTGQHTXHILN()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8E3C030", Offset = "0x8E3AA30", VA = "0x188E3C030", Slot = "26")]
		public override MaterialInfo CDUAHSCRRSU()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8E3C620", Offset = "0x8E3B020", VA = "0x188E3C620", Slot = "27")]
		public override WLNUANDGASB HHHGRNQUQZA(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8E3C1E0", Offset = "0x8E3ABE0", VA = "0x188E3C1E0")]
		[BurstCompile]
		public static void DWANYHRCAXS([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface VLMDKIBTKFZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void SQDJWGEZOLY(SelectionEffectType a, Renderer b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void IXWJCXJQMQV(Renderer a, IgnoreEffectType b, Vector3 c, Vector3 d, Vector3 e, float f, float g, float h = -1f, [Optional] Color? i, [Optional] IReadOnlyList<Camera> j);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void YPYIGPKAVRU(Renderer a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int BALEWSBSHVF();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HTEATCWRQZE(int a, OutlineEffectType b, Renderer c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class RTFKLEJHCYM : WLURUBZSQIN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class VLSTTBEVNQH : IRTSNEDWQBE<int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8E4B660", Offset = "0x8E4A060", VA = "0x188E4B660")]
			public VLSTTBEVNQH(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly VLMDKIBTKFZ VOFETSRSQWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly OKMQDIYWSJS QREMSOBTJAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MeshRenderer QTDLEUFCERZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private VLSTTBEVNQH AQMQVMQDNRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool FTQINZEEGGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MeshRenderer KPIMUHUAJST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private VLSTTBEVNQH QBWTIRVSUML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool FVROIYZBXEV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MeshRenderer MXSFNPNBDTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private VLSTTBEVNQH UVXITZXSXJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool VPAGAFRFERH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool VACBKMVGOGA;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xABE110", Offset = "0xABCB10", VA = "0x180ABE110")]
		public RTFKLEJHCYM(VLMDKIBTKFZ a, OKMQDIYWSJS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8E44D80", Offset = "0x8E43780", VA = "0x188E44D80", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8E44B20", Offset = "0x8E43520", VA = "0x188E44B20")]
		private void DVHJHMKBESU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8E46D70", Offset = "0x8E45770", VA = "0x188E46D70", Slot = "4")]
		public void KSYKFOAQHGR(RootHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8E46B50", Offset = "0x8E45550", VA = "0x188E46B50", Slot = "5")]
		public void KSYKFOAQHGR(ShapeHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8E469F0", Offset = "0x8E453F0", VA = "0x188E469F0", Slot = "6")]
		public void KMRESIPDWDR(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8E45AC0", Offset = "0x8E444C0", VA = "0x188E45AC0", Slot = "7")]
		public void GWANHILQNKP(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8E47080", Offset = "0x8E45A80", VA = "0x188E47080", Slot = "24")]
		public void SQDKMXHCOTW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x11ADA00", Offset = "0x11AC400", VA = "0x1811ADA00", Slot = "8")]
		public void ZUJNKYJSDRF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8E45620", Offset = "0x8E44020", VA = "0x188E45620", Slot = "9")]
		public void FMWUKTXGNHB(OutlineEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8E45350", Offset = "0x8E43D50", VA = "0x188E45350", Slot = "10")]
		public void FKNHIEPHBQA(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8E45000", Offset = "0x8E43A00", VA = "0x188E45000", Slot = "11")]
		public void FKNHIEPHBQA(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8E470C0", Offset = "0x8E45AC0", VA = "0x188E470C0", Slot = "12")]
		public void ZXMNFOTSHPJ(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8E459F0", Offset = "0x8E443F0", VA = "0x188E459F0", Slot = "13")]
		public void GIRJXVHYAID(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8E45790", Offset = "0x8E44190", VA = "0x188E45790")]
		private void GGXWCJNBCUQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x16027C0", Offset = "0x16011C0", VA = "0x1816027C0", Slot = "14")]
		public void FHFMRXYHYVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8E45C10", Offset = "0x8E44610", VA = "0x188E45C10", Slot = "15")]
		public void HAOTGBIABLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8E44840", Offset = "0x8E43240", VA = "0x188E44840", Slot = "16")]
		public void ANKOWPTOIBH(RootHandle a, SelectionEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8E44F30", Offset = "0x8E43930", VA = "0x188E44F30", Slot = "17")]
		public void FIJLAHDCKKL(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8E45E60", Offset = "0x8E44860", VA = "0x188E45E60", Slot = "18")]
		public void ISLKOMTYLTF(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xC80AE0", Offset = "0xC7F4E0", VA = "0x180C80AE0", Slot = "19")]
		public void XWHQCPBWAUT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8E45D30", Offset = "0x8E44730", VA = "0x188E45D30", Slot = "20")]
		public void ICDXGTJBBDZ(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8E46790", Offset = "0x8E45190", VA = "0x188E46790")]
		private void KMNDQOUGAVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8E463C0", Offset = "0x8E44DC0", VA = "0x188E463C0", Slot = "21")]
		public void JCVYVGHIICF(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<Camera> g, IgnoreEffectType h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8E45F30", Offset = "0x8E44930", VA = "0x188E45F30", Slot = "22")]
		public void JCVYVGHIICF(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class DBBPVSJUAQL : GLXIBWBWYLE, PIVAIXQLOVL, ZZKLHWPVANX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly PTGLBXQZGYV XQVYPEOBNLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int MFWJSKJJSEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected Bounds PCKFEKVOQMX;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Bounds CJPBEDVOTIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8E3ADC0", Offset = "0x8E397C0", VA = "0x188E3ADC0", Slot = "4")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool EGIAPAVMLGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xC6BF00", Offset = "0xC6A900", VA = "0x180C6BF00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xC6BF10", Offset = "0xC6A910", VA = "0x180C6BF10")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected abstract Hash128 PPRVZNFSWOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int XMIZZRIXMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xB9BF10", Offset = "0xB9A910", VA = "0x180B9BF10", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public PRTCQWAIIGM MHKLRXYUDLX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xABEC90", Offset = "0xABD690", VA = "0x180ABEC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool NFVCXYWCQPR
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1823A10", Offset = "0x1822410", VA = "0x181823A10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xAC57A0", Offset = "0xAC41A0", VA = "0x180AC57A0")]
		protected DBBPVSJUAQL(PTGLBXQZGYV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8E3AC20", Offset = "0x8E39620", VA = "0x188E3AC20", Slot = "17")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "18")]
		public virtual bool UQNRHUMYPUF(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8E3ADB0", Offset = "0x8E397B0", VA = "0x188E3ADB0", Slot = "10")]
		public int MEXKOVIGRKE(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract int FMOQZRAEDJA(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract int OMKJOQUGFSK(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract RRBounds RIJMDGUOIAC();

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract float TMYZYPVBZLA();

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		public abstract void YTXGIISJFDA(SystemLOD a, PGMWEXGQDYL b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract RRTransform QTGQHTXHILN();

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8E3AD80", Offset = "0x8E39780", VA = "0x188E3AD80", Slot = "13")]
		public Hash128 INMISEPZWFX(int a)
		{
			return default(Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract MaterialInfo CDUAHSCRRSU();

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract WLNUANDGASB HHHGRNQUQZA(SystemLOD a, JobHandle b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8E3ABF0", Offset = "0x8E395F0", VA = "0x188E3ABF0", Slot = "12")]
		public WLNUANDGASB BKAJUTRFFKR(int a)
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class ShapeRendererConfig : SingletonScriptableObject<ShapeRendererConfig>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct ShapeMeshConfigData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			[HideInInspector]
			public string EditorLabel;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Mesh[] Meshes;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ShapeMeshConfigData[] MeshConfigs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		[Header("Bevels")]
		public float SmallBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public float RoundedBevelSizeMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float BoxAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public float WedgeAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float PyramidAuthoredBevelPercent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[Tooltip("Smaller dimensions will not exceed sqrt(bevel percent) percent")]
		public bool BevelSizeBasedOnLargestPossibleDimension;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public ComputeShader CopyBonesComputeShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public SkinnedShapeRenderer SkinnedRendererPrefab;

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x8E47190", Offset = "0x8E45B90", VA = "0x188E47190")]
		public ShapeRendererConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class ShapeRendererSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class EXSYPSJWGUO : IEnumerable<RCYGLRQUKLO>, IEnumerable, IEnumerator<RCYGLRQUKLO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private RCYGLRQUKLO YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int AWORTFEGJOW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int ZWHOMDLOJQZ;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private RCYGLRQUKLO FTIRQEBPPYG
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
			[DebuggerHidden]
			public EXSYPSJWGUO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B870", Offset = "0x8E3A270", VA = "0x188E3B870", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B940", Offset = "0x8E3A340", VA = "0x188E3B940", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B7E0", Offset = "0x8E3A1E0", VA = "0x188E3B7E0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<RCYGLRQUKLO> GIKWNHGFDBL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B7E0", Offset = "0x8E3A1E0", VA = "0x188E3B7E0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static RCYGLRQUKLO[][] AYNGQSQJQWQ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static FILJAWCRXWD YHOPMVYNDQY;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static ShapeRendererConfig TPDVHFPUXTV;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static ComputeShader CBXIXILMYIL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8E49AE0", Offset = "0x8E484E0", VA = "0x188E49AE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static SkinnedShapeRenderer ISRVQQYOWHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x8E49600", Offset = "0x8E48000", VA = "0x188E49600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8E49370", Offset = "0x8E47D70", VA = "0x188E49370")]
		[RRRuntimeInitializeMethod]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8E49A10", Offset = "0x8E48410", VA = "0x188E49A10")]
		public static Mesh QVLSBDPVPKP(PrimitiveShapeMeshType a, int b = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8E49B40", Offset = "0x8E48540", VA = "0x188E49B40")]
		public static int YOYPKNTKRJC(PrimitiveShapeMeshType a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8E48F50", Offset = "0x8E47950", VA = "0x188E48F50")]
		public static FILJAWCRXWD BJJFNKQKIJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8E49310", Offset = "0x8E47D10", VA = "0x188E49310")]
		[IteratorStateMachine(typeof(EXSYPSJWGUO))]
		private static IEnumerable<RCYGLRQUKLO> IPEKHACKNGZ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8E480B0", Offset = "0x8E46AB0", VA = "0x188E480B0")]
		public static RCYGLRQUKLO AAXCAOQBWLO(PrimitiveShapeMeshType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8E49AC0", Offset = "0x8E484C0", VA = "0x188E49AC0")]
		public static bool UZDHSZYYJUM(this PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8E49450", Offset = "0x8E47E50", VA = "0x188E49450")]
		public static void JIZFCDGYZYM(PrimitiveShapeMeshType a, float3 b, [Out] BevelScalingMode c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8E49660", Offset = "0x8E48060", VA = "0x188E49660")]
		public static void PHVRDJAHMVV(Vector3 a, PrimitiveShapeMeshType b, [Out] Vector3 c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8E49AB0", Offset = "0x8E484B0", VA = "0x188E49AB0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void RMODOYZJKUF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8E49150", Offset = "0x8E47B50", VA = "0x188E49150")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void CHHYRXEPMAF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ShapeRendererManager : NUOTBWOORLZ, IDisposable, OKMQDIYWSJS
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly HDOIECNDPJE<RootHandle, PTGLBXQZGYV> XWFQATULCTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly HDOIECNDPJE<ShapeHandle, DBBPVSJUAQL> JRDOOKUTDHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly HDOIECNDPJE<SkinnedCostumeHandle, JURPSZYUJWC> ECNKSSNLJDM;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public PTGLBXQZGYV this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8E48050", Offset = "0x8E46A50", VA = "0x188E48050", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public DBBPVSJUAQL this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8E47F90", Offset = "0x8E46990", VA = "0x188E47F90", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public JURPSZYUJWC this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8E47FF0", Offset = "0x8E469F0", VA = "0x188E47FF0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool ATDNGVGKYWA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F20", Offset = "0xCB1920", VA = "0x180CB2F20", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCB2F30", Offset = "0xCB1930", VA = "0x180CB2F30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8E47C00", Offset = "0x8E46600", VA = "0x188E47C00")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8E47330", Offset = "0x8E45D30", VA = "0x188E47330", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8E47A70", Offset = "0x8E46470", VA = "0x188E47A70", Slot = "4")]
		public RootHandle XUEFKLSFKJI(SSHTJQDXJWC a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8E47A70", Offset = "0x8E46470", VA = "0x188E47A70", Slot = "5")]
		public RootHandle XUEFKLSFKJI(SSHTJQDXJWC a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8E479B0", Offset = "0x8E463B0", VA = "0x188E479B0", Slot = "6")]
		public void UAYGAGJLKKP(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8E478A0", Offset = "0x8E462A0", VA = "0x188E478A0", Slot = "7")]
		public void TAPWDQGXPOG(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8E471F0", Offset = "0x8E45BF0", VA = "0x188E471F0", Slot = "8")]
		public ShapeHandle AKPSPPBTYIT(RootHandle a, KXLVYSPVNJF b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8E475B0", Offset = "0x8E45FB0", VA = "0x188E475B0", Slot = "9")]
		public ShapeHandle KYSVMZUAWYR(RootHandle a, SKIPEFDZDRT b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8E47920", Offset = "0x8E46320", VA = "0x188E47920", Slot = "11")]
		public void TLLRUYRZBRZ(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8E47A10", Offset = "0x8E46410", VA = "0x188E47A10", Slot = "10")]
		public void WLANAKXPQUY(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8E47830", Offset = "0x8E46230", VA = "0x188E47830", Slot = "20")]
		public IEnumerable<Renderer> RQHHWDLBXRJ(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8E47460", Offset = "0x8E45E60", VA = "0x188E47460", Slot = "12")]
		public SkinnedCostumeHandle FIVYVKCEEGZ(WFKEISUZKLO a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8E47540", Offset = "0x8E45F40", VA = "0x188E47540", Slot = "14")]
		public void ITSOWJXZLRC(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8E476F0", Offset = "0x8E460F0", VA = "0x188E476F0", Slot = "16")]
		public Task MIPMDLVTVBA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8E47790", Offset = "0x8E46190", VA = "0x188E47790", Slot = "17")]
		public Task OWHPVTJDAQW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8E473C0", Offset = "0x8E45DC0", VA = "0x188E473C0", Slot = "18")]
		public Task EZRSXWIMOFJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1601D30", Offset = "0x1600730", VA = "0x181601D30", Slot = "19")]
		public void BFWMVIVQVBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8E474E0", Offset = "0x8E45EE0", VA = "0x188E474E0", Slot = "13")]
		public void GAFJFUUKORD(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface PACVMXZBVND
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool QDLSBSQKJDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Material BSBLJGGJDSF();

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material GAEPZLIDCNR();

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Material RJYXXXYIULL();

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int VGPBZCDPBCC(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int EOGZQABNXHA(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void WEKQOKVMDRA(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void IAQQGNRNICF(GameObject a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class KRQGFXJZAFQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static PACVMXZBVND KYGTMORJDLD;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static bool QDLSBSQKJDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8E3F970", Offset = "0x8E3E370", VA = "0x188E3F970")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8E3FB80", Offset = "0x8E3E580", VA = "0x188E3FB80")]
		public static void OSSZGZRPCLK(PACVMXZBVND a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8E3F910", Offset = "0x8E3E310", VA = "0x188E3F910")]
		public static Material BSBLJGGJDSF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8E3FA40", Offset = "0x8E3E440", VA = "0x188E3FA40")]
		public static Material GAEPZLIDCNR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8E3FBD0", Offset = "0x8E3E5D0", VA = "0x188E3FBD0")]
		public static Material RJYXXXYIULL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8E3FC30", Offset = "0x8E3E630", VA = "0x188E3FC30")]
		public static int VGPBZCDPBCC(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8E3F9D0", Offset = "0x8E3E3D0", VA = "0x188E3F9D0")]
		public static int EOGZQABNXHA(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8E3FCA0", Offset = "0x8E3E6A0", VA = "0x188E3FCA0")]
		public static void WEKQOKVMDRA(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8E3FAA0", Offset = "0x8E3E4A0", VA = "0x188E3FAA0")]
		public static void IAQQGNRNICF(GameObject a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class JURPSZYUJWC : EVOEIDSSYTG
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class DVKEGHUXGSE : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Renderer YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public JURPSZYUJWC VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private List<SkinnedShapeRenderer>.Enumerator RECIBZUSAYP;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private Renderer EGIRMPLZYNG
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xAB85D0", Offset = "0xAB6FD0", VA = "0x180AB85D0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xD50190", Offset = "0xD4EB90", VA = "0x180D50190")]
			[DebuggerHidden]
			public DVKEGHUXGSE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B6C0", Offset = "0x8E3A0C0", VA = "0x188E3B6C0", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B4A0", Offset = "0x8E39EA0", VA = "0x188E3B4A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B750", Offset = "0x8E3A150", VA = "0x188E3B750")]
			private void SNXRWXESNLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B7A0", Offset = "0x8E3A1A0", VA = "0x188E3B7A0", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B400", Offset = "0x8E39E00", VA = "0x188E3B400", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> BEJAIZOJMCP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8E3B400", Offset = "0x8E39E00", VA = "0x188E3B400", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly WFKEISUZKLO XUANLSMPFAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly OKMQDIYWSJS QREMSOBTJAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private ClusterLODSkinnedRenderer QKJIJPOYMLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<OWSADHSJZFB> ADIGTFKRAGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private List<OWSADHSJZFB> SALKBXRMMWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private GameObject UARIOGEHMPX;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8E3EA30", Offset = "0x8E3D430", VA = "0x188E3EA30")]
		public static JURPSZYUJWC ECEWZYOHCVO(WFKEISUZKLO a, OKMQDIYWSJS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8E3F830", Offset = "0x8E3E230", VA = "0x188E3F830")]
		private JURPSZYUJWC(WFKEISUZKLO a, OKMQDIYWSJS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E5B0", Offset = "0x8E3CFB0", VA = "0x188E3E5B0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E500", Offset = "0x8E3CF00", VA = "0x188E3E500")]
		[IteratorStateMachine(typeof(DVKEGHUXGSE))]
		public IEnumerable<Renderer> BYMKSPLRDGP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8E3EB70", Offset = "0x8E3D570", VA = "0x188E3EB70", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8E3E580", Offset = "0x8E3CF80", VA = "0x188E3E580")]
		private void CDXAVBONFTH(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8E3F5E0", Offset = "0x8E3DFE0", VA = "0x188E3F5E0")]
		public void Update()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class OWSADHSJZFB : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private struct BoneMeshInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public PGMWEXGQDYL Generator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public RRTransform BoneTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int BoneIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class WKDHTAWVSFY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public OWSADHSJZFB VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int JCVJGXDAWKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int QXKPBVRFUHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public SystemLOD RKOBHVMXKVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public List<BoneMeshInfo> FMOMBPTCRMZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public NativeMesh UNZEEMSPWSR;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public WKDHTAWVSFY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8E4B6E0", Offset = "0x8E4A0E0", VA = "0x188E4B6E0")]
			internal JobHandle IEPWQYBNDHN()
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8E4B6B0", Offset = "0x8E4A0B0", VA = "0x188E4B6B0")]
			internal void IEKPTRHPTWE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8E4B740", Offset = "0x8E4A140", VA = "0x188E4B740")]
			internal void IFAKLLPHWEF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int[] SHJXAJFCCQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private VAZRZAFQGPV XYKPKSOPQGP;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Matrix4x4 AKBOAKBFVUN;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Mesh FVOMDDIMNCO
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xAB85E0", Offset = "0xAB6FE0", VA = "0x180AB85E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int THGMVPMUQFS
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xABA120", Offset = "0xAB8B20", VA = "0x180ABA120")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xABBD60", Offset = "0xABA760", VA = "0x180ABBD60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8E42500", Offset = "0x8E40F00", VA = "0x188E42500")]
		public void XWJDHEPRVYJ(List<RRTransform> a, Matrix4x4[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8E419C0", Offset = "0x8E403C0", VA = "0x188E419C0")]
		public static List<OWSADHSJZFB> Create(List<PTGLBXQZGYV> collections, SystemLOD lod, Bounds bounds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8E420C0", Offset = "0x8E40AC0", VA = "0x188E420C0")]
		private JobHandle JCYEAFQYOVW(NativeMesh a, int b, int c, SystemLOD d, List<BoneMeshInfo> e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8E42420", Offset = "0x8E40E20", VA = "0x188E42420")]
		private void MKFGSRGWTNW(List<BoneMeshInfo> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8E42870", Offset = "0x8E41270", VA = "0x188E42870")]
		private OWSADHSJZFB(List<BoneMeshInfo> a, int b, int c, SystemLOD d, Bounds e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8E42020", Offset = "0x8E40A20", VA = "0x188E42020", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MaterialPropertyBlock XQDHZIHNMAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private OWSADHSJZFB RNUVXSOSTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<RRTransform> SAWKERUODVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private RenderTexture CYKMVDRUDKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private ComputeBuffer ZGFXGEFEPXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private ComputeShader NOEWYKYAQQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Matrix4x4[] VOFSCAUGEVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int COJRTSRXRZY;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer PXCJSZIAKMN
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8330", Offset = "0xAB6D30", VA = "0x180AB8330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int OXTHISMUMQQ
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8E4A930", Offset = "0x8E49330", VA = "0x188E4A930")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8E49C40", Offset = "0x8E48640", VA = "0x188E49C40")]
		public static List<SkinnedShapeRenderer> Create(GameObject root, List<OWSADHSJZFB> meshes, List<RRTransform> bones, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8E49F30", Offset = "0x8E48930", VA = "0x188E49F30")]
		public void Init(OWSADHSJZFB mesh, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A470", Offset = "0x8E48E70", VA = "0x188E4A470")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A3E0", Offset = "0x8E48DE0", VA = "0x188E4A3E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A3A0", Offset = "0x8E48DA0", VA = "0x188E4A3A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A500", Offset = "0x8E48F00", VA = "0x188E4A500")]
		private void UMTAHMTIKND(ScriptableRenderContext a, Camera[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8E4A5C0", Offset = "0x8E48FC0", VA = "0x188E4A5C0")]
		private void XWJDHEPRVYJ(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xAB6960", Offset = "0xAB5360", VA = "0x180AB6960")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8E4A970", Offset = "0x8E49370", VA = "0x188E4A970")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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
