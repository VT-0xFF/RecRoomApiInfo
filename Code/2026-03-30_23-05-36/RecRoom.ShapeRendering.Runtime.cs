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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x903D3F0", Offset = "0x903C1F0", VA = "0x18903D3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF1840", Offset = "0xAF0640", VA = "0x180AF1840")]
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
		[Cpp2IlInjected.Address(RVA = "0x90382D0", Offset = "0x90370D0", VA = "0x1890382D0", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
		[Cpp2IlInjected.Address(RVA = "0x9048230", Offset = "0x9047030", VA = "0x189048230", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27B5590", Offset = "0x27B4390", VA = "0x1827B5590")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ClusterLODSkinnedRenderer : XHCVUMJKWOC, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private byte FETFOCZNDLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<SkinnedShapeRenderer>[] NOQLLMCPEAU;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int YVRACLLZQRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAD8650", Offset = "0xAD7450", VA = "0x180AD8650", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB27AC0", Offset = "0xB268C0", VA = "0x180B27AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int LZHCZMRWONA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAEF9B0", Offset = "0xAEE7B0", VA = "0x180AEF9B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCE0B40", Offset = "0xCDF940", VA = "0x180CE0B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float GPBPJVDWQVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE8FBD0", Offset = "0xE8E9D0", VA = "0x180E8FBD0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1126B60", Offset = "0x1125960", VA = "0x181126B60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float NODNQBOGHKN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC43180", Offset = "0xC41F80", VA = "0x180C43180", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCDB8B0", Offset = "0xCDA6B0", VA = "0x180CDB8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public List<SkinnedShapeRenderer> HCJUVTZRSYR
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9033660", Offset = "0x9032460", VA = "0x189033660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<SkinnedShapeRenderer> XBDYMLZCWOR
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9033A80", Offset = "0x9032880", VA = "0x189033A80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GameObject JNMQCQBFHQM
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAD0080", Offset = "0xACEE80", VA = "0x180AD0080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public byte BZOJCINQXPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9033610", Offset = "0x9032410", VA = "0x189033610", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9033AF0", Offset = "0x90328F0", VA = "0x189033AF0")]
		public ClusterLODSkinnedRenderer(List<FJSCEDAUSMQ> lod0Meshes, List<FJSCEDAUSMQ> lod1Meshes, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x90336B0", Offset = "0x90324B0", VA = "0x1890336B0")]
		private int HGGOQWBPRJT(List<FJSCEDAUSMQ> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x90337D0", Offset = "0x90325D0", VA = "0x1890337D0")]
		private void LFEGKZBLBTS(int a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9033930", Offset = "0x9032730", VA = "0x189033930")]
		public void LWCOWUAAVRD(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9033510", Offset = "0x9032310", VA = "0x189033510", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9033AB0", Offset = "0x90328B0", VA = "0x189033AB0")]
		public void UCZYDVISRLK(Transform a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class PQJTISCWVKI : FUNITHRAGUD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class IYLXODVXADW : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Renderer LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PQJTISCWVKI FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private List<ClusterMeshRenderer>.Enumerator NUQJCBGEMQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private IEnumerator<Renderer> NVGDTVNWOYJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private IEnumerator<MeshRenderer> NVAWWOTZFNA;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private Renderer QLENFZPUQNR
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public IYLXODVXADW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x90365A0", Offset = "0x90353A0", VA = "0x1890365A0", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9036090", Offset = "0x9034E90", VA = "0x189036090", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9035FA0", Offset = "0x9034DA0", VA = "0x189035FA0")]
			private void GWSJMPTZZMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9035F00", Offset = "0x9034D00", VA = "0x189035F00")]
			private void GWCOUVMHXEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9035F50", Offset = "0x9034D50", VA = "0x189035F50")]
			private void GWHVSCGFGPJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9036790", Offset = "0x9035590", VA = "0x189036790", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9035FF0", Offset = "0x9034DF0", VA = "0x189035FF0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> VQMZAWKUYJW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x9035FF0", Offset = "0x9034DF0", VA = "0x189035FF0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class FJSRXIGEEFM : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private Renderer LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public PQJTISCWVKI FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<Renderer> NUQJCBGEMQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private List<SkinnedShapeRenderer>.Enumerator NVGDTVNWOYJ;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private Renderer QLENFZPUQNR
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public FJSRXIGEEFM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9035660", Offset = "0x9034460", VA = "0x189035660", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x90352F0", Offset = "0x90340F0", VA = "0x1890352F0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9035200", Offset = "0x9034000", VA = "0x189035200")]
			private void GWSJMPTZZMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x90351B0", Offset = "0x9033FB0", VA = "0x1890351B0")]
			private void GWCOUVMHXEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x9035790", Offset = "0x9034590", VA = "0x189035790", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x9035250", Offset = "0x9034050", VA = "0x189035250", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> VQMZAWKUYJW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9035250", Offset = "0x9034050", VA = "0x189035250", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SDKELXFZQNN LXZNZYBMMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<NEWUKPKZPBI> FPZDUTBRAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private List<ClusterMeshRenderer> YDSPDMPHSJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BatchedMeshRenderer IPAHNSSVTDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool YXRZDJELIYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly bool QTYTTWCTFLS;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IEnumerable<ETBTAFPVNAW> ORENXXULNTB
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int TMEZBMAOGOX
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x903E6A0", Offset = "0x903D4A0", VA = "0x18903E6A0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RRTransform AJODMAGUTWE
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x903DBB0", Offset = "0x903C9B0", VA = "0x18903DBB0", Slot = "8")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public List<SkinnedShapeRenderer> ZSOTOAGGIUT
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xACC8A0", Offset = "0xACB6A0", VA = "0x180ACC8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x903E520", Offset = "0x903D320", VA = "0x18903E520")]
		private bool OICIDBVMIXO(NEWUKPKZPBI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x903DAB0", Offset = "0x903C8B0", VA = "0x18903DAB0")]
		private static bool HBGQPCSCVZS(NEWUKPKZPBI a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x903EE70", Offset = "0x903DC70", VA = "0x18903EE70")]
		public PQJTISCWVKI(SDKELXFZQNN a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x903D730", Offset = "0x903C530", VA = "0x18903D730", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x903D470", Offset = "0x903C270", VA = "0x18903D470")]
		public void Add(NEWUKPKZPBI shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x903E540", Offset = "0x903D340", VA = "0x18903E540")]
		public void Remove(NEWUKPKZPBI shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x903E6E0", Offset = "0x903D4E0", VA = "0x18903E6E0", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x903EC00", Offset = "0x903DA00", VA = "0x18903EC00")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x903DC70", Offset = "0x903CA70", VA = "0x18903DC70")]
		private void KFMXJSZYLRA(List<NEWUKPKZPBI> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x903DAD0", Offset = "0x903C8D0", VA = "0x18903DAD0")]
		private static Material HXFKULBKKIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x903DE30", Offset = "0x903CC30", VA = "0x18903DE30")]
		private void KFMXJSZYLRA(NEWUKPKZPBI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x903D920", Offset = "0x903C720", VA = "0x18903D920")]
		private void EJRCEBXANCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x903DEE0", Offset = "0x903CCE0", VA = "0x18903DEE0")]
		public void MFBBNYIPQGN(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x903D9F0", Offset = "0x903C7F0", VA = "0x18903D9F0")]
		protected void EURCUPZCXJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x903D6B0", Offset = "0x903C4B0", VA = "0x18903D6B0")]
		public void BGIFKBYCIMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x903DB30", Offset = "0x903C930", VA = "0x18903DB30")]
		[IteratorStateMachine(typeof(IYLXODVXADW))]
		public IEnumerable<Renderer> IDLWKSSANHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x903E4A0", Offset = "0x903D2A0", VA = "0x18903E4A0")]
		[IteratorStateMachine(typeof(FJSRXIGEEFM))]
		public IEnumerable<Renderer> MQMYJAULSRJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[BurstCompile]
	internal class UESRXCIVIGI : NEWUKPKZPBI
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct CurveToken : DPDFPPKVLXI, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x9033E80", Offset = "0x9032C80", VA = "0x189033E80")]
			public CurveToken(NativeMesh mesh, JobHandle jobHandle, CurveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9033E00", Offset = "0x9032C00", VA = "0x189033E00", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9033E30", Offset = "0x9032C30", VA = "0x189033E30", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void CalculateFastCurveBounds_00000039$PostfixBurstDelegate([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class LCUBVZPRQLY
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9037FC0", Offset = "0x9036DC0", VA = "0x189037FC0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9038150", Offset = "0x9036F50", VA = "0x189038150")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9037C10", Offset = "0x9036A10", VA = "0x189037C10")]
			public unsafe static void Invoke([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal readonly JOZWRWUOZRE MLHCBFBYKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float GJLEQSQOGGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Hash128 DYHZWEKKLRF;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override Hash128 EYHRYQGVWNL
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x90455F0", Offset = "0x90443F0", VA = "0x1890455F0", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9045710", Offset = "0x9044510", VA = "0x189045710")]
		public UESRXCIVIGI(PQJTISCWVKI a, JOZWRWUOZRE b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "18")]
		public override bool SSEEGSAGPYK(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9044920", Offset = "0x9043720", VA = "0x189044920", Slot = "19")]
		public override int HGGOQWBPRJT(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9045060", Offset = "0x9043E60", VA = "0x189045060", Slot = "20")]
		public override int RXLYRFNGEVN(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9044DC0", Offset = "0x9043BC0", VA = "0x189044DC0", Slot = "21")]
		public override RRBounds MVCHAGPMVNR()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9044910", Offset = "0x9043710", VA = "0x189044910")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastCurveBounds_00000039$PostfixBurstDelegate))]
		private unsafe static void GINJNBXGQPK([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB8DB10", Offset = "0xB8C910", VA = "0x180B8DB10", Slot = "22")]
		public override float ALNVHGRDZYV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x90443D0", Offset = "0x90431D0", VA = "0x1890443D0", Slot = "23")]
		public override void FXFMSTEEJGN(SystemLOD a, JCDQRFWUBJO b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9045400", Offset = "0x9044200", VA = "0x189045400")]
		private int XZBCYGUJKTO(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9044B00", Offset = "0x9043900", VA = "0x189044B00", Slot = "24")]
		public override RRTransform HYYSHIJFGDC()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9045240", Offset = "0x9044040", VA = "0x189045240", Slot = "26")]
		public override MaterialInfo XAJBTQFDIGJ()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9043C20", Offset = "0x9042A20", VA = "0x189043C20", Slot = "27")]
		public override DPDFPPKVLXI BWFPVZGVJNL(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9044BD0", Offset = "0x90439D0", VA = "0x189044BD0")]
		[BurstCompile]
		internal unsafe static void IMKWMKSILHV([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FUKXSQRFXYF
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		PQJTISCWVKI this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		NEWUKPKZPBI this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		IZPYIUEDRXX this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class UKQEZFJWXPE : ACAHWUFRZUW, IDisposable, FUKXSQRFXYF
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
			public UKQEZFJWXPE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x9042F50", Offset = "0x9041D50", VA = "0x189042F50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x90434C0", Offset = "0x90422C0", VA = "0x1890434C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly XGHJRIVYYBV<RootHandle, PQJTISCWVKI> DIODKPRYJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly XGHJRIVYYBV<ShapeHandle, NEWUKPKZPBI> FPZDUTBRAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly XGHJRIVYYBV<SkinnedCostumeHandle, IZPYIUEDRXX> TOYZGCXCFLJ;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PQJTISCWVKI this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9047D40", Offset = "0x9046B40", VA = "0x189047D40", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public NEWUKPKZPBI this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x9047DA0", Offset = "0x9046BA0", VA = "0x189047DA0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public IZPYIUEDRXX this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9047CE0", Offset = "0x9046AE0", VA = "0x189047CE0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool EQLAOVLSEYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB5E570", Offset = "0xB5D370", VA = "0x180B5E570", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB5E580", Offset = "0xB5D380", VA = "0x180B5E580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9047860", Offset = "0x9046660", VA = "0x189047860")]
		public UKQEZFJWXPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9045B70", Offset = "0x9044970", VA = "0x189045B70", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9046CB0", Offset = "0x9045AB0", VA = "0x189046CB0", Slot = "4")]
		public RootHandle PIFQKEJTLYT(SDKELXFZQNN a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9046A40", Offset = "0x9045840", VA = "0x189046A40", Slot = "5")]
		public RootHandle PIFQKEJTLYT(SDKELXFZQNN a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9045890", Offset = "0x9044690", VA = "0x189045890", Slot = "6")]
		public void CMFDPEJBDBK(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9046440", Offset = "0x9045240", VA = "0x189046440", Slot = "7")]
		public void HPPIOOTXAFH(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9047330", Offset = "0x9046130", VA = "0x189047330", Slot = "8")]
		public ShapeHandle UEDNGIDYAWM(RootHandle a, DFVSLTKZIQA b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9045D40", Offset = "0x9044B40", VA = "0x189045D40", Slot = "9")]
		public ShapeHandle EIHPEJMMWWG(RootHandle a, JOZWRWUOZRE b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9046D20", Offset = "0x9045B20", VA = "0x189046D20", Slot = "11")]
		public void RJZQKSOQXJU(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x90470D0", Offset = "0x9045ED0", VA = "0x1890470D0", Slot = "10")]
		public void TZVJHXPBMZT(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x90477F0", Offset = "0x90465F0", VA = "0x1890477F0", Slot = "20")]
		public IEnumerable<Renderer> UNLSUPWAILQ(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9045AF0", Offset = "0x90448F0", VA = "0x189045AF0", Slot = "12")]
		public SkinnedCostumeHandle CVZRNZAHNLA(SCNCYCSHXRT a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9046210", Offset = "0x9045010", VA = "0x189046210", Slot = "14")]
		public void ENISFLKRDPR(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9046790", Offset = "0x9045590", VA = "0x189046790", Slot = "16")]
		public Task LJXZXDXEZGV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9046280", Offset = "0x9045080", VA = "0x189046280", Slot = "17")]
		public Task GYNGRYZVDOX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x90457C0", Offset = "0x90445C0", VA = "0x1890457C0", Slot = "18")]
		[AsyncStateMachine(typeof(<EndRoomLoad>d__28))]
		public Task BUKNRSYYWTE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9046950", Offset = "0x9045750", VA = "0x189046950", Slot = "19")]
		public void PHTLEYLOGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9046CC0", Offset = "0x9045AC0", VA = "0x189046CC0", Slot = "13")]
		public void PUCOYCTOQQS(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[BurstCompile]
	internal class NDWUTZAYNBM : NEWUKPKZPBI
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct PrimitiveToken : DPDFPPKVLXI, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x903F060", Offset = "0x903DE60", VA = "0x18903F060")]
			public PrimitiveToken(NativeMesh mesh, NativeArray<int> vertCollapseTarget, JobHandle jobHandle, PrimitiveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x903EF60", Offset = "0x903DD60", VA = "0x18903EF60", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x903EFC0", Offset = "0x903DDC0", VA = "0x18903EFC0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class ISHSFLCTKKK
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private static IntPtr GGXPGEGMCOV;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x9035BF0", Offset = "0x90349F0", VA = "0x189035BF0")]
			[BurstDiscard]
			private static void WMZYLIMDVLX(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x9035D80", Offset = "0x9034B80", VA = "0x189035D80")]
			private static IntPtr ZNUOOURKYIV()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x90359D0", Offset = "0x90347D0", VA = "0x1890359D0")]
			public static void Invoke([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly DFVSLTKZIQA FFDULGKWPQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int[] EKGATXTDDQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Hash128 DYHZWEKKLRF;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector3 EHYWIKBAKHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x9039660", Offset = "0x9038460", VA = "0x189039660")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override Hash128 EYHRYQGVWNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x903A700", Offset = "0x9039500", VA = "0x18903A700", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x903A820", Offset = "0x9039620", VA = "0x18903A820")]
		public NDWUTZAYNBM(PQJTISCWVKI a, DFVSLTKZIQA b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x903A1F0", Offset = "0x9038FF0", VA = "0x18903A1F0", Slot = "18")]
		public override bool SSEEGSAGPYK(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9039DB0", Offset = "0x9038BB0", VA = "0x189039DB0", Slot = "21")]
		public override RRBounds MVCHAGPMVNR()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9039DF0", Offset = "0x9038BF0", VA = "0x189039DF0")]
		private RRBounds MVCHAGPMVNR(RRTransform a)
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9039A10", Offset = "0x9038810", VA = "0x189039A10")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate))]
		private static void LRUNDHKCWUS([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9038C10", Offset = "0x9037A10", VA = "0x189038C10")]
		private OcclusionData EQLYIGLRKJD([In] UniformTRS worldFromLocalUniformTRS, [In] float3 worldScale)
		{
			return default(OcclusionData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9039890", Offset = "0x9038690", VA = "0x189039890", Slot = "19")]
		public override int HGGOQWBPRJT(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x903A140", Offset = "0x9038F40", VA = "0x18903A140", Slot = "20")]
		public override int RXLYRFNGEVN(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9038390", Offset = "0x9037190", VA = "0x189038390", Slot = "22")]
		public override float ALNVHGRDZYV()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x903A2C0", Offset = "0x90390C0", VA = "0x18903A2C0")]
		private int UEBKCYFPGOR(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9038E10", Offset = "0x9037C10", VA = "0x189038E10", Slot = "23")]
		public override void FXFMSTEEJGN(SystemLOD a, JCDQRFWUBJO b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9039940", Offset = "0x9038740", VA = "0x189039940", Slot = "24")]
		public override RRTransform HYYSHIJFGDC()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x903A540", Offset = "0x9039340", VA = "0x18903A540", Slot = "26")]
		public override MaterialInfo XAJBTQFDIGJ()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9038480", Offset = "0x9037280", VA = "0x189038480", Slot = "27")]
		public override DPDFPPKVLXI BWFPVZGVJNL(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9039A20", Offset = "0x9038820", VA = "0x189039A20")]
		[BurstCompile]
		internal static void MMEOEBRZOKN([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface MYKIMNEYXUY
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DBNYSLEXGFJ(SelectionEffectType a, Renderer b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ORFGDHRAJWI(Renderer a, IgnoreEffectType b, Vector3 c, Vector3 d, Vector3 e, float f, float g, float h = -1f, [Optional] Color? i, [Optional] IReadOnlyList<Camera> j);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ODXJGJUBPXV(Renderer a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int JFAQOTUHYLI();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void FBUTNJETOTF(int a, OutlineEffectType b, Renderer c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class NHXATLOIFZV : DQOPNYHMTEI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class YANNIYRCNCU : BXUFFBZWZKB<int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x9047E00", Offset = "0x9046C00", VA = "0x189047E00")]
			public YANNIYRCNCU(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly MYKIMNEYXUY YSKCICNTGFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly FUKXSQRFXYF VEHCNNNOZXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MeshRenderer KQFOKQZSXRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private YANNIYRCNCU UPVEIONADJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool FLXPQPGFRBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MeshRenderer PCTURCLKBEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private YANNIYRCNCU ZRGMTQYCPJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool JEYBKLLXGFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MeshRenderer OZNUISXIHYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private YANNIYRCNCU LDQLSPIHCWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool PEMXGBGLFBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool BRKISHTLOGT;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAD31B0", Offset = "0xAD1FB0", VA = "0x180AD31B0")]
		public NHXATLOIFZV(MYKIMNEYXUY a, FUKXSQRFXYF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x903ADB0", Offset = "0x9039BB0", VA = "0x18903ADB0", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x903C830", Offset = "0x903B630", VA = "0x18903C830")]
		private void VFVOCXWURUJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x903C520", Offset = "0x903B320", VA = "0x18903C520", Slot = "4")]
		public void UVIOXFKTMWW(RootHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x903C300", Offset = "0x903B100", VA = "0x18903C300", Slot = "5")]
		public void UVIOXFKTMWW(ShapeHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x903BE70", Offset = "0x903AC70", VA = "0x18903BE70", Slot = "6")]
		public void RZGPRJWKMWG(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x903AF60", Offset = "0x9039D60", VA = "0x18903AF60", Slot = "7")]
		public void FABBWVCFZRK(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x903BE30", Offset = "0x903AC30", VA = "0x18903BE30", Slot = "24")]
		public void RLUITZNOQSJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x123D980", Offset = "0x123C780", VA = "0x18123D980", Slot = "8")]
		public void VGYPVPPTYQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x903BCC0", Offset = "0x903AAC0", VA = "0x18903BCC0", Slot = "9")]
		public void LZOYAAQCJNC(OutlineEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x903B310", Offset = "0x903A110", VA = "0x18903B310", Slot = "10")]
		public void ITEBYBWEYBZ(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x903B5E0", Offset = "0x903A3E0", VA = "0x18903B5E0", Slot = "11")]
		public void ITEBYBWEYBZ(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x903BAD0", Offset = "0x903A8D0", VA = "0x18903BAD0", Slot = "12")]
		public void LCCKHEOGMIK(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x903BFD0", Offset = "0x903ADD0", VA = "0x18903BFD0", Slot = "13")]
		public void RZLRZGUUBZK(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x903C0A0", Offset = "0x903AEA0", VA = "0x18903C0A0")]
		private void TUUEMIJZUUZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x16BA3E0", Offset = "0x16B91E0", VA = "0x1816BA3E0", Slot = "14")]
		public void PFWUCUKXLHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x903BBA0", Offset = "0x903A9A0", VA = "0x18903BBA0", Slot = "15")]
		public void LSJKVWMOFWQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x903AAD0", Offset = "0x90398D0", VA = "0x18903AAD0", Slot = "16")]
		public void BPTCDWEFAIS(RootHandle a, SelectionEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x903BA00", Offset = "0x903A800", VA = "0x18903BA00", Slot = "17")]
		public void JQHCICNQVDA(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x903B930", Offset = "0x903A730", VA = "0x18903B930", Slot = "18")]
		public void JGNSRRWTMMY(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCF03D0", Offset = "0xCEF1D0", VA = "0x180CF03D0", Slot = "19")]
		public void YNAQWSOMTJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x903D2C0", Offset = "0x903C0C0", VA = "0x18903D2C0", Slot = "20")]
		public void YAXGGRJASYI(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x903B0B0", Offset = "0x9039EB0", VA = "0x18903B0B0")]
		private void IEGRSNCJTLL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x903CF00", Offset = "0x903BD00", VA = "0x18903CF00", Slot = "21")]
		public void XKAEBFEIXSY(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<Camera> g, IgnoreEffectType h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x903CA90", Offset = "0x903B890", VA = "0x18903CA90", Slot = "22")]
		public void XKAEBFEIXSY(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class NEWUKPKZPBI : KEJWIFKWHUJ, ETBTAFPVNAW, JTQCRBQVPIY, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly PQJTISCWVKI JNMQCQBFHQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int WZYYXPHHMLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected Bounds ZDAQTTXEXAQ;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Bounds QZRNTIBBSXG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x903AAB0", Offset = "0x90398B0", VA = "0x18903AAB0", Slot = "4")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool QTYTTWCTFLS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xCEB9C0", Offset = "0xCEA7C0", VA = "0x180CEB9C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xCEB990", Offset = "0xCEA790", VA = "0x180CEB990")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected abstract Hash128 EYHRYQGVWNL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int WZBLNRDMIUG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xB33C40", Offset = "0xB32A40", VA = "0x180B33C40", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public PGLTCIOZDIV WWSHXXQTXMK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xACC8A0", Offset = "0xACB6A0", VA = "0x180ACC8A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool ENZNISZYXWQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x18C0310", Offset = "0x18BF110", VA = "0x1818C0310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		protected NEWUKPKZPBI(PQJTISCWVKI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x903A8D0", Offset = "0x90396D0", VA = "0x18903A8D0", Slot = "17")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960", Slot = "18")]
		public virtual bool SSEEGSAGPYK(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x903AA40", Offset = "0x9039840", VA = "0x18903AA40", Slot = "10")]
		public int HRNBNWMJWXV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract int HGGOQWBPRJT(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract int RXLYRFNGEVN(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract RRBounds MVCHAGPMVNR();

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract float ALNVHGRDZYV();

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		public abstract void FXFMSTEEJGN(SystemLOD a, JCDQRFWUBJO b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract RRTransform HYYSHIJFGDC();

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x903AA80", Offset = "0x9039880", VA = "0x18903AA80", Slot = "13")]
		public Hash128 RWIQKTDYYNS(int a)
		{
			return default(Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract MaterialInfo XAJBTQFDIGJ();

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract DPDFPPKVLXI BWFPVZGVJNL(SystemLOD a, JobHandle b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x903AA50", Offset = "0x9039850", VA = "0x18903AA50", Slot = "12")]
		public DPDFPPKVLXI IRKEFYJPAFA(int a)
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
		[Cpp2IlInjected.Address(RVA = "0x903F660", Offset = "0x903E460", VA = "0x18903F660")]
		public ShapeRendererConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class ShapeRendererSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class QPDXHLTRHBH : IEnumerable<YTDFHYODQIT>, IEnumerable, IEnumerator<YTDFHYODQIT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private YTDFHYODQIT LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int WBPHLKTAFYD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int RSJIBSJWQLK;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private YTDFHYODQIT WOPCPKMRJDX
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public QPDXHLTRHBH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x903F550", Offset = "0x903E350", VA = "0x18903F550", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x903F620", Offset = "0x903E420", VA = "0x18903F620", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x903F4C0", Offset = "0x903E2C0", VA = "0x18903F4C0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<YTDFHYODQIT> KCQLQAELARQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x903F4C0", Offset = "0x903E2C0", VA = "0x18903F4C0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static YTDFHYODQIT[][] XHXLULWBQJJ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static OAXZEIEXIZW UZVBZQEMLUZ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static ShapeRendererConfig HBAFRMHYDPQ;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static ComputeShader KMBQSRDMTZK
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9042050", Offset = "0x9040E50", VA = "0x189042050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static SkinnedShapeRenderer JMBAROICGYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x9040650", Offset = "0x903F450", VA = "0x189040650")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9041B80", Offset = "0x9040980", VA = "0x189041B80")]
		[RRRuntimeInitializeMethod]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x90405B0", Offset = "0x903F3B0", VA = "0x1890405B0")]
		public static Mesh BKKERVOKIEM(PrimitiveShapeMeshType a, int b = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x9040710", Offset = "0x903F510", VA = "0x189040710")]
		public static int CORTAIHGHWD(PrimitiveShapeMeshType a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x90417B0", Offset = "0x90405B0", VA = "0x1890417B0")]
		public static OAXZEIEXIZW DTHGIRLVAWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x90406B0", Offset = "0x903F4B0", VA = "0x1890406B0")]
		[IteratorStateMachine(typeof(QPDXHLTRHBH))]
		private static IEnumerable<YTDFHYODQIT> CFVRJVUHKSI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x9040720", Offset = "0x903F520", VA = "0x189040720")]
		public static YTDFHYODQIT CPYRJQRXCZH(PrimitiveShapeMeshType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9042030", Offset = "0x9040E30", VA = "0x189042030")]
		public static bool PRWYFHZVKYN(this PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x90419D0", Offset = "0x90407D0", VA = "0x1890419D0")]
		public static void EXLSYHCOOKX(PrimitiveShapeMeshType a, float3 b, [Out] BevelScalingMode c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9041C70", Offset = "0x9040A70", VA = "0x189041C70")]
		public static void PHYUHHEWIXK(Vector3 a, PrimitiveShapeMeshType b, [Out] Vector3 c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x90420B0", Offset = "0x9040EB0", VA = "0x1890420B0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void UYKQWKNKRRA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x90415D0", Offset = "0x90403D0", VA = "0x1890415D0")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void DNZCCULRZRE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ShapeRendererManager : ACAHWUFRZUW, IDisposable, FUKXSQRFXYF
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log VYIZTFKBMQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly XGHJRIVYYBV<RootHandle, PQJTISCWVKI> DIODKPRYJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly XGHJRIVYYBV<ShapeHandle, NEWUKPKZPBI> FPZDUTBRAJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly XGHJRIVYYBV<SkinnedCostumeHandle, IZPYIUEDRXX> TOYZGCXCFLJ;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public PQJTISCWVKI this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x90404F0", Offset = "0x903F2F0", VA = "0x1890404F0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public NEWUKPKZPBI this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9040490", Offset = "0x903F290", VA = "0x189040490", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public IZPYIUEDRXX this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x9040550", Offset = "0x903F350", VA = "0x189040550", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool EQLAOVLSEYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xB5E570", Offset = "0xB5D370", VA = "0x180B5E570", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xB5E580", Offset = "0xB5D380", VA = "0x180B5E580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x90400E0", Offset = "0x903EEE0", VA = "0x1890400E0")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x903F840", Offset = "0x903E640", VA = "0x18903F840", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x903FC40", Offset = "0x903EA40", VA = "0x18903FC40", Slot = "4")]
		public RootHandle PIFQKEJTLYT(SDKELXFZQNN a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x903FC40", Offset = "0x903EA40", VA = "0x18903FC40", Slot = "5")]
		public RootHandle PIFQKEJTLYT(SDKELXFZQNN a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x903F760", Offset = "0x903E560", VA = "0x18903F760", Slot = "6")]
		public void CMFDPEJBDBK(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x903FB20", Offset = "0x903E920", VA = "0x18903FB20", Slot = "7")]
		public void HPPIOOTXAFH(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x903FEA0", Offset = "0x903ECA0", VA = "0x18903FEA0", Slot = "8")]
		public ShapeHandle UEDNGIDYAWM(RootHandle a, DFVSLTKZIQA b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x903F8D0", Offset = "0x903E6D0", VA = "0x18903F8D0", Slot = "9")]
		public ShapeHandle EIHPEJMMWWG(RootHandle a, JOZWRWUOZRE b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x903FDB0", Offset = "0x903EBB0", VA = "0x18903FDB0", Slot = "11")]
		public void RJZQKSOQXJU(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x903FE40", Offset = "0x903EC40", VA = "0x18903FE40", Slot = "10")]
		public void TZVJHXPBMZT(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x903FFE0", Offset = "0x903EDE0", VA = "0x18903FFE0", Slot = "20")]
		public IEnumerable<Renderer> UNLSUPWAILQ(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x903F7C0", Offset = "0x903E5C0", VA = "0x18903F7C0", Slot = "12")]
		public SkinnedCostumeHandle CVZRNZAHNLA(SCNCYCSHXRT a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x903FA10", Offset = "0x903E810", VA = "0x18903FA10", Slot = "14")]
		public void ENISFLKRDPR(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x903FBA0", Offset = "0x903E9A0", VA = "0x18903FBA0", Slot = "16")]
		public Task LJXZXDXEZGV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x903FA80", Offset = "0x903E880", VA = "0x18903FA80", Slot = "17")]
		public Task GYNGRYZVDOX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x903F6C0", Offset = "0x903E4C0", VA = "0x18903F6C0", Slot = "18")]
		public Task BUKNRSYYWTE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x16B9780", Offset = "0x16B8580", VA = "0x1816B9780", Slot = "19")]
		public void PHTLEYLOGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x903FD50", Offset = "0x903EB50", VA = "0x18903FD50", Slot = "13")]
		public void PUCOYCTOQQS(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface HVWYYLCDXJM
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool DPCKZZKCNOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Material FKMDAEYKSHK();

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material HXFKULBKKIM();

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Material FBGQWMCQBEO();

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int CPLNUWYLBZL(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int VTMLMSQAKVZ(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void DKKBDONOPQJ(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void LDKFIBNLPKC(GameObject a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class QMFMQVCSJTB
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static HVWYYLCDXJM FJGVDYCXDJI;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static bool DPCKZZKCNOY
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x903F0B0", Offset = "0x903DEB0", VA = "0x18903F0B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x903F3F0", Offset = "0x903E1F0", VA = "0x18903F3F0")]
		public static void NFUJJIFFSFD(HVWYYLCDXJM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x903F2B0", Offset = "0x903E0B0", VA = "0x18903F2B0")]
		public static Material FKMDAEYKSHK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x903DAD0", Offset = "0x903C8D0", VA = "0x18903DAD0")]
		public static Material HXFKULBKKIM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x903F250", Offset = "0x903E050", VA = "0x18903F250")]
		public static Material FBGQWMCQBEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x903F110", Offset = "0x903DF10", VA = "0x18903F110")]
		public static int CPLNUWYLBZL(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x903F450", Offset = "0x903E250", VA = "0x18903F450")]
		public static int VTMLMSQAKVZ(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x903F180", Offset = "0x903DF80", VA = "0x18903F180")]
		public static void DKKBDONOPQJ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x903F310", Offset = "0x903E110", VA = "0x18903F310")]
		public static void LDKFIBNLPKC(GameObject a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class IZPYIUEDRXX : FUNITHRAGUD
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class YVNSZFEQSBF : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private int GTWEEXJFPKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Renderer LBVZGXVZPSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int DGBKDPSSRXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public IZPYIUEDRXX FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private List<SkinnedShapeRenderer>.Enumerator NUQJCBGEMQI;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private Renderer QLENFZPUQNR
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private object UUTAULZFDNA
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xDE87C0", Offset = "0xDE75C0", VA = "0x180DE87C0")]
			[DebuggerHidden]
			public YVNSZFEQSBF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x9048160", Offset = "0x9046F60", VA = "0x189048160", Slot = "7")]
			[DebuggerHidden]
			private void NFYYAPEFSFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x9047F40", Offset = "0x9046D40", VA = "0x189047F40", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9047E50", Offset = "0x9046C50", VA = "0x189047E50")]
			private void GWSJMPTZZMB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x90481F0", Offset = "0x9046FF0", VA = "0x1890481F0", Slot = "10")]
			[DebuggerHidden]
			private void USEBYPNATQY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x9047EA0", Offset = "0x9046CA0", VA = "0x189047EA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> VQMZAWKUYJW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x9047EA0", Offset = "0x9046CA0", VA = "0x189047EA0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HTHYFOXNRHD()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly SCNCYCSHXRT PKPCQIZSBPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly FUKXSQRFXYF VEHCNNNOZXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private ClusterLODSkinnedRenderer RRLYMIGUHIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<FJSCEDAUSMQ> SLEVROPENZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private List<FJSCEDAUSMQ> XRBFGPHDOAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private GameObject RAZCGEFMODW;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9036CD0", Offset = "0x9035AD0", VA = "0x189036CD0")]
		public static IZPYIUEDRXX ILZREXUUVOB(SCNCYCSHXRT a, FUKXSQRFXYF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x9037B30", Offset = "0x9036930", VA = "0x189037B30")]
		private IZPYIUEDRXX(SCNCYCSHXRT a, FUKXSQRFXYF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x90367D0", Offset = "0x90355D0", VA = "0x1890367D0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9036C50", Offset = "0x9035A50", VA = "0x189036C50")]
		[IteratorStateMachine(typeof(YVNSZFEQSBF))]
		public IEnumerable<Renderer> IDLWKSSANHG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9036E10", Offset = "0x9035C10", VA = "0x189036E10", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x90378B0", Offset = "0x90366B0", VA = "0x1890378B0")]
		private void TPEXDPUXLLC(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x90378E0", Offset = "0x90366E0", VA = "0x1890378E0")]
		public void Update()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class FJSCEDAUSMQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private struct BoneMeshInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public JCDQRFWUBJO Generator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public RRTransform BoneTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int BoneIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class HENKAPLGKWX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public FJSCEDAUSMQ FNBWZDPUGEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int QRBUQVHGWTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int YJCXTJQJHYR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public SystemLOD VYDSVYQEDET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public List<BoneMeshInfo> XARIMAFDKPS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public NativeMesh AMXDVPCJDEG;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
			public HENKAPLGKWX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x9035940", Offset = "0x9034740", VA = "0x189035940")]
			internal JobHandle OVTIKBAUHFU()
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x90359A0", Offset = "0x90347A0", VA = "0x1890359A0")]
			internal void OVYPHHURQRD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x90357D0", Offset = "0x90345D0", VA = "0x1890357D0")]
			internal void OVIUPNMZOJC()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int[] WWSFTFECXWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private JWNOONHIMOK BGGLIQFATPU;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Matrix4x4 LTIMKSXBRKC;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Mesh IOTWTOZJGBT
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xACA8C0", Offset = "0xAC96C0", VA = "0x180ACA8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int PMEIJCAKRNP
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xAD4260", Offset = "0xAD3060", VA = "0x180AD4260")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xAD4960", Offset = "0xAD3760", VA = "0x180AD4960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x90346C0", Offset = "0x90334C0", VA = "0x1890346C0")]
		public void IFLIXLVZEEI(List<RRTransform> a, Matrix4x4[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x9033EE0", Offset = "0x9032CE0", VA = "0x189033EE0")]
		public static List<FJSCEDAUSMQ> Create(List<PQJTISCWVKI> collections, SystemLOD lod, Bounds bounds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x90348B0", Offset = "0x90336B0", VA = "0x1890348B0")]
		private JobHandle ZHLIDGSRIWD(NativeMesh a, int b, int c, SystemLOD d, List<BoneMeshInfo> e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x90345E0", Offset = "0x90333E0", VA = "0x1890345E0")]
		private void FWADYGKVBFR(List<BoneMeshInfo> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x9034DB0", Offset = "0x9033BB0", VA = "0x189034DB0")]
		private FJSCEDAUSMQ(List<BoneMeshInfo> a, int b, int c, SystemLOD d, Bounds e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x9034540", Offset = "0x9033340", VA = "0x189034540", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MaterialPropertyBlock TIZVGHEMQWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private FJSCEDAUSMQ YWJJZPRDXCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<RRTransform> TXVEEKWNJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private RenderTexture IRKHYWFFJWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private ComputeBuffer NKMYMTHXFOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private ComputeShader VOEIMBNLZBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Matrix4x4[] OQDNSKLAKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int DPDIGUGLUET;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer GPUJZEAJSUO
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAC8C30", Offset = "0xAC7A30", VA = "0x180AC8C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int EMQHNYDCYFN
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x9042ED0", Offset = "0x9041CD0", VA = "0x189042ED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x90421C0", Offset = "0x9040FC0", VA = "0x1890421C0")]
		public static List<SkinnedShapeRenderer> Create(GameObject root, List<FJSCEDAUSMQ> meshes, List<RRTransform> bones, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x90428F0", Offset = "0x90416F0", VA = "0x1890428F0")]
		public void Init(FJSCEDAUSMQ mesh, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x9042E40", Offset = "0x9041C40", VA = "0x189042E40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x9042DB0", Offset = "0x9041BB0", VA = "0x189042DB0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x9042D70", Offset = "0x9041B70", VA = "0x189042D70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x90424C0", Offset = "0x90412C0", VA = "0x1890424C0")]
		private void FKCXFIXZEVG(ScriptableRenderContext a, Camera[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9042580", Offset = "0x9041380", VA = "0x189042580")]
		private void IFLIXLVZEEI(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xAC7A90", Offset = "0xAC6890", VA = "0x180AC7A90")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x9042F10", Offset = "0x9041D10", VA = "0x189042F10")]
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
