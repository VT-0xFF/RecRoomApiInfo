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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4E4CA0", Offset = "0xA4E36A0", VA = "0x18A4E4CA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4E4520", Offset = "0xA4E2F20", VA = "0x18A4E4520", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4EE3F0", Offset = "0xA4ECDF0", VA = "0x18A4EE3F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A2D0B0", Offset = "0x2A2BAB0", VA = "0x182A2D0B0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ClusterLODSkinnedRenderer : YXLXKGSOLSD, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private byte OMBSWFEPZAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<SkinnedShapeRenderer>[] XSLINIPFWIN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int TUQJDUIQMTI
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD215F0", Offset = "0xD1FFF0", VA = "0x180D215F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD682F0", Offset = "0xD66CF0", VA = "0x180D682F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int MMEBSCUNCBV
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float TIQQKYGTMSM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x10DD6F0", Offset = "0x10DC0F0", VA = "0x1810DD6F0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1368DF0", Offset = "0x13677F0", VA = "0x181368DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float QFZCUJXQKUI
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xE9AEF0", Offset = "0xE998F0", VA = "0x180E9AEF0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xF35800", Offset = "0xF34200", VA = "0x180F35800")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public List<SkinnedShapeRenderer> OSMONUGGFES
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4DA1F0", Offset = "0xA4D8BF0", VA = "0x18A4DA1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<SkinnedShapeRenderer> KQMQOFGEFIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA4DA1C0", Offset = "0xA4D8BC0", VA = "0x18A4DA1C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GameObject YXDZNKGUVHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public byte XDJBMZTZJPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA4D9C60", Offset = "0xA4D8660", VA = "0x18A4D9C60", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA240", Offset = "0xA4D8C40", VA = "0x18A4DA240")]
		public ClusterLODSkinnedRenderer(List<GMQKHTTVWCJ> lod0Meshes, List<GMQKHTTVWCJ> lod1Meshes, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9DF0", Offset = "0xA4D87F0", VA = "0x18A4D9DF0")]
		private int EPZVEPTFZMI(List<GMQKHTTVWCJ> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA060", Offset = "0xA4D8A60", VA = "0x18A4DA060")]
		private void KOQBVTHXFIX(int a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9F10", Offset = "0xA4D8910", VA = "0x18A4D9F10")]
		public void ERTSNASSFFU(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9CF0", Offset = "0xA4D86F0", VA = "0x18A4D9CF0", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9CB0", Offset = "0xA4D86B0", VA = "0x18A4D9CB0")]
		public void CVKRLHOTCRH(Transform a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class FACAKZSYWOH : HKZQFTQGNDU, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class LGJHLEAZFBJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Renderer OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public FACAKZSYWOH XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private List<ClusterMeshRenderer>.Enumerator ULWCKXMDKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private IEnumerator<Renderer> ULGHTDELHUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private IEnumerator<MeshRenderer> ULLOQJYIRFJ;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private Renderer BGATZTEBJIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1031740", Offset = "0x1030140", VA = "0x181031740")]
			[DebuggerHidden]
			public LGJHLEAZFBJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4200", Offset = "0xA4E2C00", VA = "0x18A4E4200", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA4E3CF0", Offset = "0xA4E26F0", VA = "0x18A4E3CF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA4E44D0", Offset = "0xA4E2ED0", VA = "0x18A4E44D0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4480", Offset = "0xA4E2E80", VA = "0x18A4E4480")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4430", Offset = "0xA4E2E30", VA = "0x18A4E4430")]
			private void RHCPKCUTVHS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA4E43F0", Offset = "0xA4E2DF0", VA = "0x18A4E43F0", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E3C50", Offset = "0xA4E2650", VA = "0x18A4E3C50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> IXMASTLZJTH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E3C50", Offset = "0xA4E2650", VA = "0x18A4E3C50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ICLQMLGISDV : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private Renderer OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public FACAKZSYWOH XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<Renderer> ULWCKXMDKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private List<SkinnedShapeRenderer>.Enumerator ULGHTDELHUA;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private Renderer BGATZTEBJIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1031740", Offset = "0x1030140", VA = "0x181031740")]
			[DebuggerHidden]
			public ICLQMLGISDV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E10F0", Offset = "0xA4DFAF0", VA = "0x18A4E10F0", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0D80", Offset = "0xA4DF780", VA = "0x18A4E0D80", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E12B0", Offset = "0xA4DFCB0", VA = "0x18A4E12B0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1260", Offset = "0xA4DFC60", VA = "0x18A4E1260")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1220", Offset = "0xA4DFC20", VA = "0x18A4E1220", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0CE0", Offset = "0xA4DF6E0", VA = "0x18A4E0CE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> IXMASTLZJTH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0CE0", Offset = "0xA4DF6E0", VA = "0x18A4E0CE0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly CGCJIYDJKJG IPHWRJNSFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<WSMUKLCXCIZ> JWIMQSBXLXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private List<ClusterMeshRenderer> LKZCTXVERVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BatchedMeshRenderer SOWUIOYAGGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool PWWTAEICIBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly bool QUXYCRNLBUX;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IEnumerable<WAZRGGGQMHN> MPRNDYDHBUG
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int ITRTXBOZKNK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA4DE2D0", Offset = "0xA4DCCD0", VA = "0x18A4DE2D0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RRTransform AIPOMGXLXTV
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA4DD540", Offset = "0xA4DBF40", VA = "0x18A4DD540", Slot = "8")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public List<SkinnedShapeRenderer> XYDNCFOBAUE
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD610", Offset = "0xA4DC010", VA = "0x18A4DD610")]
		private bool OAPOMLIJHXR(WSMUKLCXCIZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD330", Offset = "0xA4DBD30", VA = "0x18A4DD330")]
		private static bool BDDLIYBAOOR(WSMUKLCXCIZ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE4E0", Offset = "0xA4DCEE0", VA = "0x18A4DE4E0")]
		public FACAKZSYWOH(CGCJIYDJKJG a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD350", Offset = "0xA4DBD50", VA = "0x18A4DD350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD0F0", Offset = "0xA4DBAF0", VA = "0x18A4DD0F0")]
		public void Add(WSMUKLCXCIZ shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD9E0", Offset = "0xA4DC3E0", VA = "0x18A4DD9E0")]
		public void Remove(WSMUKLCXCIZ shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA4DDB40", Offset = "0xA4DC540", VA = "0x18A4DDB40", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE060", Offset = "0xA4DCA60", VA = "0x18A4DE060")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD6B0", Offset = "0xA4DC0B0", VA = "0x18A4DD6B0")]
		private void PWJDHIVDNTN(List<WSMUKLCXCIZ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9980", Offset = "0xA4D8380", VA = "0x18A4D9980")]
		private static Material NSFBGGCCMRT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD870", Offset = "0xA4DC270", VA = "0x18A4DD870")]
		private void PWJDHIVDNTN(WSMUKLCXCIZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE310", Offset = "0xA4DCD10", VA = "0x18A4DE310")]
		private void VKYYAJFZVMZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA4DCB30", Offset = "0xA4DB530", VA = "0x18A4DCB30")]
		public void ASGUHQYUCZS(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD920", Offset = "0xA4DC320", VA = "0x18A4DD920")]
		protected void RQXYVECJBOU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE460", Offset = "0xA4DCE60", VA = "0x18A4DE460")]
		public void ZEYLDTBBYYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE3E0", Offset = "0xA4DCDE0", VA = "0x18A4DE3E0")]
		[IteratorStateMachine(typeof(LGJHLEAZFBJ))]
		public IEnumerable<Renderer> ZCPTTLDTLIR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA4DD630", Offset = "0xA4DC030", VA = "0x18A4DD630")]
		[IteratorStateMachine(typeof(ICLQMLGISDV))]
		public IEnumerable<Renderer> PIWKJTUZXIU()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[BurstCompile]
	internal class UZSJIHQQLWH : WSMUKLCXCIZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct CurveToken : SXBUBUENJRV, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA4DA5E0", Offset = "0xA4D8FE0", VA = "0x18A4DA5E0")]
			public CurveToken(NativeMesh mesh, JobHandle jobHandle, CurveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA4DA560", Offset = "0xA4D8F60", VA = "0x18A4DA560", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA4DA590", Offset = "0xA4D8F90", VA = "0x18A4DA590", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void CalculateFastCurveBounds_00000039$PostfixBurstDelegate([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class MXTSYNCMRHT
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4B10", Offset = "0xA4E3510", VA = "0x18A4E4B10")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E45E0", Offset = "0xA4E2FE0", VA = "0x18A4E45E0")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4760", Offset = "0xA4E3160", VA = "0x18A4E4760")]
			public unsafe static void Invoke([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal readonly DPZTBLGRSDV UAVZJMELYGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float HXNQVVYLGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Hash128 ZFZMXDJJQPI;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override Hash128 IVQAFFFESRC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA4EA330", Offset = "0xA4E8D30", VA = "0x18A4EA330", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB4D0", Offset = "0xA4E9ED0", VA = "0x18A4EB4D0")]
		public UZSJIHQQLWH(FACAKZSYWOH a, DPZTBLGRSDV b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "18")]
		public override bool UBCWHELFYGH(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA150", Offset = "0xA4E8B50", VA = "0x18A4EA150", Slot = "19")]
		public override int EPZVEPTFZMI(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9F70", Offset = "0xA4E8970", VA = "0x18A4E9F70", Slot = "20")]
		public override int DLBQBPSNMMY(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA460", Offset = "0xA4E8E60", VA = "0x18A4EA460", Slot = "21")]
		public override RRBounds IWKMUIZEZJW()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB010", Offset = "0xA4E9A10", VA = "0x18A4EB010")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastCurveBounds_00000039$PostfixBurstDelegate))]
		private unsafe static void QQWZEFVXLGN([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xDBC640", Offset = "0xDBB040", VA = "0x180DBC640", Slot = "22")]
		public override float HTLQNANTEDG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9B00", Offset = "0xA4E8500", VA = "0x18A4E9B00", Slot = "23")]
		public override void BDENLGPIWYQ(SystemLOD a, JOBQCDJAIKZ b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB2E0", Offset = "0xA4E9CE0", VA = "0x18A4EB2E0")]
		private int ZDDOVHTMDOR(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB020", Offset = "0xA4E9A20", VA = "0x18A4EB020", Slot = "24")]
		public override RRTransform UHMCLBWVBGF()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAE50", Offset = "0xA4E9850", VA = "0x18A4EAE50", Slot = "26")]
		public override MaterialInfo ORHUULRZWQK()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA690", Offset = "0xA4E9090", VA = "0x18A4EA690", Slot = "27")]
		public override SXBUBUENJRV JKBIJWSWTOQ(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB0F0", Offset = "0xA4E9AF0", VA = "0x18A4EB0F0")]
		[BurstCompile]
		internal unsafe static void YWAGTRQAXHK([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface FMMNRNZBALM
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		FACAKZSYWOH this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		WSMUKLCXCIZ this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		HFAWZTYWLEA this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class XQHMRPJWPXB : BHNMHOQGZYJ, IDisposable, FMMNRNZBALM
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
			public XQHMRPJWPXB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA4E8E30", Offset = "0xA4E7830", VA = "0x18A4E8E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA4E93A0", Offset = "0xA4E7DA0", VA = "0x18A4E93A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly CTZCGZZPIFO<RootHandle, FACAKZSYWOH> LJWQOVHQURT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly CTZCGZZPIFO<ShapeHandle, WSMUKLCXCIZ> JWIMQSBXLXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly CTZCGZZPIFO<SkinnedCostumeHandle, HFAWZTYWLEA> TMAYLFNFEPK;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public FACAKZSYWOH this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA4EDF60", Offset = "0xA4EC960", VA = "0x18A4EDF60", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public WSMUKLCXCIZ this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA4EDF00", Offset = "0xA4EC900", VA = "0x18A4EDF00", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HFAWZTYWLEA this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA4EDEA0", Offset = "0xA4EC8A0", VA = "0x18A4EDEA0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool EGVNOCNLNRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xDA36F0", Offset = "0xDA20F0", VA = "0x180DA36F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDA20", Offset = "0xA4EC420", VA = "0x18A4EDA20")]
		public XQHMRPJWPXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBBB0", Offset = "0xA4EA5B0", VA = "0x18A4EBBB0", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECFD0", Offset = "0xA4EB9D0", VA = "0x18A4ECFD0", Slot = "4")]
		public RootHandle TDYGBHDSYCE(CGCJIYDJKJG a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECD60", Offset = "0xA4EB760", VA = "0x18A4ECD60", Slot = "5")]
		public RootHandle TDYGBHDSYCE(CGCJIYDJKJG a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECB00", Offset = "0xA4EB500", VA = "0x18A4ECB00", Slot = "6")]
		public void PEAYHSAEDRL(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECFE0", Offset = "0xA4EB9E0", VA = "0x18A4ECFE0", Slot = "7")]
		public void TKQXXGUKMKM(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED330", Offset = "0xA4EBD30", VA = "0x18A4ED330", Slot = "8")]
		public ShapeHandle VMHZGZNZYQJ(RootHandle a, DCTACMKMUBX b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC630", Offset = "0xA4EB030", VA = "0x18A4EC630", Slot = "9")]
		public ShapeHandle LBXUWQXQIPF(RootHandle a, DPZTBLGRSDV b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC040", Offset = "0xA4EAA40", VA = "0x18A4EC040", Slot = "11")]
		public void JWYTTELPWQN(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBD80", Offset = "0xA4EA780", VA = "0x18A4EBD80", Slot = "10")]
		public void EBEHFKCMBOK(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBA50", Offset = "0xA4EA450", VA = "0x18A4EBA50", Slot = "20")]
		public IEnumerable<Renderer> DCGGTDMDHGB(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC3F0", Offset = "0xA4EADF0", VA = "0x18A4EC3F0", Slot = "12")]
		public SkinnedCostumeHandle KGLFPHHZHKT(BYSVQDWALNE a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED7F0", Offset = "0xA4EC1F0", VA = "0x18A4ED7F0", Slot = "14")]
		public void WHDZEFBWOXM(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC470", Offset = "0xA4EAE70", VA = "0x18A4EC470", Slot = "16")]
		public Task KLGPOANTOMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED860", Offset = "0xA4EC260", VA = "0x18A4ED860", Slot = "17")]
		public Task ZZAKSZGRECU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB980", Offset = "0xA4EA380", VA = "0x18A4EB980", Slot = "18")]
		[AsyncStateMachine(typeof(<EndRoomLoad>d__28))]
		public Task CFOIZPZTWKV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBAC0", Offset = "0xA4EA4C0", VA = "0x18A4EBAC0", Slot = "19")]
		public void DONFOCCVTLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBFE0", Offset = "0xA4EA9E0", VA = "0x18A4EBFE0", Slot = "13")]
		public void ELJOYMQZBLB(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[BurstCompile]
	internal class DCPKCIXTGLT : WSMUKLCXCIZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct PrimitiveToken : SXBUBUENJRV, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA4E5350", Offset = "0xA4E3D50", VA = "0x18A4E5350")]
			public PrimitiveToken(NativeMesh mesh, NativeArray<int> vertCollapseTarget, JobHandle jobHandle, PrimitiveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E5250", Offset = "0xA4E3C50", VA = "0x18A4E5250", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA4E52B0", Offset = "0xA4E3CB0", VA = "0x18A4E52B0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class OFMNFVEKQSN
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private static IntPtr NXTBSNZLRPU;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E50C0", Offset = "0xA4E3AC0", VA = "0x18A4E50C0")]
			[BurstDiscard]
			private static void SQHJXJSJTLI(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4D20", Offset = "0xA4E3720", VA = "0x18A4E4D20")]
			private static IntPtr GPQTKUFLJJK()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4EA0", Offset = "0xA4E38A0", VA = "0x18A4E4EA0")]
			public static void Invoke([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly DCTACMKMUBX PXUWVBIVPWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int[] OWFXBHXXTVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Hash128 ZFZMXDJJQPI;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector3 KONUXDLHTEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA4DA640", Offset = "0xA4D9040", VA = "0x18A4DA640")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override Hash128 IVQAFFFESRC
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA4DB440", Offset = "0xA4D9E40", VA = "0x18A4DB440", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA4DCA80", Offset = "0xA4DB480", VA = "0x18A4DCA80")]
		public DCPKCIXTGLT(FACAKZSYWOH a, DCTACMKMUBX b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC550", Offset = "0xA4DAF50", VA = "0x18A4DC550", Slot = "18")]
		public override bool UBCWHELFYGH(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB660", Offset = "0xA4DA060", VA = "0x18A4DB660", Slot = "21")]
		public override RRBounds IWKMUIZEZJW()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB6A0", Offset = "0xA4DA0A0", VA = "0x18A4DB6A0")]
		private RRBounds IWKMUIZEZJW(RRTransform a)
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB0D0", Offset = "0xA4D9AD0", VA = "0x18A4DB0D0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate))]
		private static void DCJARQAMUNN([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB190", Offset = "0xA4D9B90", VA = "0x18A4DB190")]
		private OcclusionData DZWHRJKUEQU([In] UniformTRS worldFromLocalUniformTRS, [In] float3 worldScale)
		{
			return default(OcclusionData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB390", Offset = "0xA4D9D90", VA = "0x18A4DB390", Slot = "19")]
		public override int EPZVEPTFZMI(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB0E0", Offset = "0xA4D9AE0", VA = "0x18A4DB0E0", Slot = "20")]
		public override int DLBQBPSNMMY(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB570", Offset = "0xA4D9F70", VA = "0x18A4DB570", Slot = "22")]
		public override float HTLQNANTEDG()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA4DB980", Offset = "0xA4DA380", VA = "0x18A4DB980")]
		private int JHLMTBYVCDY(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA4DA870", Offset = "0xA4D9270", VA = "0x18A4DA870", Slot = "23")]
		public override void BDENLGPIWYQ(SystemLOD a, JOBQCDJAIKZ b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC620", Offset = "0xA4DB020", VA = "0x18A4DC620", Slot = "24")]
		public override RRTransform UHMCLBWVBGF()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC390", Offset = "0xA4DAD90", VA = "0x18A4DC390", Slot = "26")]
		public override MaterialInfo ORHUULRZWQK()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA4DBC00", Offset = "0xA4DA600", VA = "0x18A4DBC00", Slot = "27")]
		public override SXBUBUENJRV JKBIJWSWTOQ(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA4DC6F0", Offset = "0xA4DB0F0", VA = "0x18A4DC6F0")]
		[BurstCompile]
		internal static void YETGNGFQEFU([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface LBUKWRLLAAZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OTQAHRGGERW(SelectionEffectType a, Renderer b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void UNMERPDACHJ(Renderer a, IgnoreEffectType b, Vector3 c, Vector3 d, Vector3 e, float f, float g, float h = -1f, [Optional] Color? i, [Optional] IReadOnlyList<Camera> j);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XCGZMARECMU(Renderer a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int SBTOCOUBYUJ();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void HFIZMCQVEQQ(int a, OutlineEffectType b, Renderer c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class JHMEEZUXCHI : UECLNUSSBAX, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class ZQBFXDDMKGB : FMWJFGANWSA<int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA4EDFC0", Offset = "0xA4EC9C0", VA = "0x18A4EDFC0")]
			public ZQBFXDDMKGB(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly LBUKWRLLAAZ EWRBNGQWQPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly FMMNRNZBALM OUUTWGJTCLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MeshRenderer DNBVZOEVDLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private ZQBFXDDMKGB DLMJQKWWAYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool CWLNFAJVSVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MeshRenderer DLMZTHYXJSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private ZQBFXDDMKGB HQKQHFYDFSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool WSUVVJLQZPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MeshRenderer VHEAJRDJTLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private ZQBFXDDMKGB YSIRISRHUJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool HIXBUOZJZAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xD13C40", Offset = "0xD12640", VA = "0x180D13C40")]
		public JHMEEZUXCHI(LBUKWRLLAAZ a, FMMNRNZBALM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1300", Offset = "0xA4DFD00", VA = "0x18A4E1300", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2AB0", Offset = "0xA4E14B0", VA = "0x18A4E2AB0")]
		private void PWSRDATZTHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2050", Offset = "0xA4E0A50", VA = "0x18A4E2050", Slot = "4")]
		public void KBWUWPJHBMH(RootHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1E30", Offset = "0xA4E0830", VA = "0x18A4E1E30", Slot = "5")]
		public void KBWUWPJHBMH(ShapeHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2880", Offset = "0xA4E1280", VA = "0x18A4E2880", Slot = "6")]
		public void NUJZNXGZCAB(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2DE0", Offset = "0xA4E17E0", VA = "0x18A4E2DE0", Slot = "7")]
		public void XDJTGUYXGSV(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2710", Offset = "0xA4E1110", VA = "0x18A4E2710", Slot = "24")]
		public void MGWOIBQURKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x148BF50", Offset = "0x148A950", VA = "0x18148BF50", Slot = "8")]
		public void DMGXGTQRPDX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA4E34C0", Offset = "0xA4E1EC0", VA = "0x18A4E34C0", Slot = "9")]
		public void ZVHROTHJFUF(OutlineEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3980", Offset = "0xA4E2380", VA = "0x18A4E3980", Slot = "10")]
		public void ZYGWBRZULEG(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3630", Offset = "0xA4E2030", VA = "0x18A4E3630", Slot = "11")]
		public void ZYGWBRZULEG(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2360", Offset = "0xA4E0D60", VA = "0x18A4E2360", Slot = "12")]
		public void LVFVCOZZMGJ(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2D10", Offset = "0xA4E1710", VA = "0x18A4E2D10", Slot = "13")]
		public void QTRLFNHOVJX(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3000", Offset = "0xA4E1A00", VA = "0x18A4E3000")]
		private void YSEIWMXHKUK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x1915BD0", Offset = "0x19145D0", VA = "0x181915BD0", Slot = "14")]
		public void SWLOGTRHCCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1D10", Offset = "0xA4E0710", VA = "0x18A4E1D10", Slot = "15")]
		public void ITTZMBDAYQF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2430", Offset = "0xA4E0E30", VA = "0x18A4E2430", Slot = "16")]
		public void LXWLBJCVLTB(RootHandle a, SelectionEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E29E0", Offset = "0xA4E13E0", VA = "0x18A4E29E0", Slot = "17")]
		public void PPNOYWMGOQB(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2F30", Offset = "0xA4E1930", VA = "0x18A4E2F30", Slot = "18")]
		public void XNDTHJZMVBT(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xF3B310", Offset = "0xF39D10", VA = "0x180F3B310", Slot = "19")]
		public void PDDARXEAQTT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2750", Offset = "0xA4E1150", VA = "0x18A4E2750", Slot = "20")]
		public void MRGTRXHVRSB(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3260", Offset = "0xA4E1C60", VA = "0x18A4E3260")]
		private void ZGCHHZKLIBY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1940", Offset = "0xA4E0340", VA = "0x18A4E1940", Slot = "21")]
		public void HWEKXPHYMNN(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<Camera> g, IgnoreEffectType h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E14B0", Offset = "0xA4DFEB0", VA = "0x18A4E14B0", Slot = "22")]
		public void HWEKXPHYMNN(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class WSMUKLCXCIZ : NAKPMUOOPUY, WAZRGGGQMHN, HQSVNXCIFNJ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly FACAKZSYWOH YXDZNKGUVHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int RJNDYAMIOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected Bounds TXTNDJRGMZD;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Bounds YFDFXIVJKPX
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xA4EB760", Offset = "0xA4EA160", VA = "0x18A4EB760", Slot = "4")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool QUXYCRNLBUX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xF432C0", Offset = "0xF41CC0", VA = "0x180F432C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xF432E0", Offset = "0xF41CE0", VA = "0x180F432E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected abstract Hash128 IVQAFFFESRC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int TDVPAZNIRCL
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xD7C720", Offset = "0xD7B120", VA = "0x180D7C720", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NXKMOIHTDOC SGXPKKQFKYD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool RVFUDXEMPIZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1B1D3C0", Offset = "0x1B1BDC0", VA = "0x181B1D3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		protected WSMUKLCXCIZ(FACAKZSYWOH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB5B0", Offset = "0xA4E9FB0", VA = "0x18A4EB5B0", Slot = "17")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "18")]
		public virtual bool UBCWHELFYGH(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB720", Offset = "0xA4EA120", VA = "0x18A4EB720", Slot = "10")]
		public int HMRUVRWOATM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract int EPZVEPTFZMI(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract int DLBQBPSNMMY(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract RRBounds IWKMUIZEZJW();

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract float HTLQNANTEDG();

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		public abstract void BDENLGPIWYQ(SystemLOD a, JOBQCDJAIKZ b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract RRTransform UHMCLBWVBGF();

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB580", Offset = "0xA4E9F80", VA = "0x18A4EB580", Slot = "13")]
		public Hash128 BJXMFTMPPLJ(int a)
		{
			return default(Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract MaterialInfo ORHUULRZWQK();

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract SXBUBUENJRV JKBIJWSWTOQ(SystemLOD a, JobHandle b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB730", Offset = "0xA4EA130", VA = "0x18A4EB730", Slot = "12")]
		public SXBUBUENJRV TWOYLGEJXAL(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xA4E53A0", Offset = "0xA4E3DA0", VA = "0x18A4E53A0")]
		public ShapeRendererConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class ShapeRendererSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class TWDSAMJYLWY : IEnumerable<BWYSXFJXQJQ>, IEnumerable, IEnumerator<BWYSXFJXQJQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private BWYSXFJXQJQ OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int YLTZVVYULVK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int OWPMOQHMFJR;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private BWYSXFJXQJQ STELXPARAFO
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1031740", Offset = "0x1030140", VA = "0x181031740")]
			[DebuggerHidden]
			public TWDSAMJYLWY(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA4E8CE0", Offset = "0xA4E76E0", VA = "0x18A4E8CE0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA4E8DB0", Offset = "0xA4E77B0", VA = "0x18A4E8DB0", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA4E8C50", Offset = "0xA4E7650", VA = "0x18A4E8C50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<BWYSXFJXQJQ> FWMRTRNPDJR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA4E8C50", Offset = "0xA4E7650", VA = "0x18A4E8C50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static BWYSXFJXQJQ[][] GJHDREVEHJM;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IABYZCDZYMJ DUFFDARQAKS;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static ShapeRendererConfig EBJVLIWAOQV;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static ComputeShader VJGMMWTTLXH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA4E62F0", Offset = "0xA4E4CF0", VA = "0x18A4E62F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static SkinnedShapeRenderer WWVXYKDPGJI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xA4E7D90", Offset = "0xA4E6790", VA = "0x18A4E7D90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7820", Offset = "0xA4E6220", VA = "0x18A4E7820")]
		[RRRuntimeInitializeMethod]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7910", Offset = "0xA4E6310", VA = "0x18A4E7910")]
		public static Mesh JHXTUPPVISB(PrimitiveShapeMeshType a, int b = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7DF0", Offset = "0xA4E67F0", VA = "0x18A4E7DF0")]
		public static int QVWSPMONLDQ(PrimitiveShapeMeshType a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7450", Offset = "0xA4E5E50", VA = "0x18A4E7450")]
		public static IABYZCDZYMJ HOBONZTZFLR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E73F0", Offset = "0xA4E5DF0", VA = "0x18A4E73F0")]
		[IteratorStateMachine(typeof(TWDSAMJYLWY))]
		private static IEnumerable<BWYSXFJXQJQ> HLKZEJNSABJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E6540", Offset = "0xA4E4F40", VA = "0x18A4E6540")]
		public static BWYSXFJXQJQ FPQICOAZXLI(PrimitiveShapeMeshType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7D70", Offset = "0xA4E6770", VA = "0x18A4E7D70")]
		public static bool PXJJUXERPXM(this PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7670", Offset = "0xA4E6070", VA = "0x18A4E7670")]
		public static void IPNBNYVYSTU(PrimitiveShapeMeshType a, float3 b, [Out] BevelScalingMode c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA4E79B0", Offset = "0xA4E63B0", VA = "0x18A4E79B0")]
		public static void LZKUVDBLPGB(Vector3 a, PrimitiveShapeMeshType b, [Out] Vector3 c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E6530", Offset = "0xA4E4F30", VA = "0x18A4E6530")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void FEIFLZEDREP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E6350", Offset = "0xA4E4D50", VA = "0x18A4E6350")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void EWKLUTXPTCD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ShapeRendererManager : BHNMHOQGZYJ, IDisposable, FMMNRNZBALM
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly CTZCGZZPIFO<RootHandle, FACAKZSYWOH> LJWQOVHQURT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly CTZCGZZPIFO<ShapeHandle, WSMUKLCXCIZ> JWIMQSBXLXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly CTZCGZZPIFO<SkinnedCostumeHandle, HFAWZTYWLEA> TMAYLFNFEPK;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public FACAKZSYWOH this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xA4E6290", Offset = "0xA4E4C90", VA = "0x18A4E6290", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public WSMUKLCXCIZ this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xA4E6230", Offset = "0xA4E4C30", VA = "0x18A4E6230", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public HFAWZTYWLEA this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xA4E61D0", Offset = "0xA4E4BD0", VA = "0x18A4E61D0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool EGVNOCNLNRU
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xDA36E0", Offset = "0xDA20E0", VA = "0x180DA36E0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xDA36F0", Offset = "0xDA20F0", VA = "0x180DA36F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5E20", Offset = "0xA4E4820", VA = "0x18A4E5E20")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5510", Offset = "0xA4E3F10", VA = "0x18A4E5510", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA4E59B0", Offset = "0xA4E43B0", VA = "0x18A4E59B0", Slot = "4")]
		public RootHandle TDYGBHDSYCE(CGCJIYDJKJG a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA4E59B0", Offset = "0xA4E43B0", VA = "0x18A4E59B0", Slot = "5")]
		public RootHandle TDYGBHDSYCE(CGCJIYDJKJG a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5950", Offset = "0xA4E4350", VA = "0x18A4E5950", Slot = "6")]
		public void PEAYHSAEDRL(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5AC0", Offset = "0xA4E44C0", VA = "0x18A4E5AC0", Slot = "7")]
		public void TKQXXGUKMKM(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5B40", Offset = "0xA4E4540", VA = "0x18A4E5B40", Slot = "8")]
		public ShapeHandle VMHZGZNZYQJ(RootHandle a, DCTACMKMUBX b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5810", Offset = "0xA4E4210", VA = "0x18A4E5810", Slot = "9")]
		public ShapeHandle LBXUWQXQIPF(RootHandle a, DPZTBLGRSDV b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5660", Offset = "0xA4E4060", VA = "0x18A4E5660", Slot = "11")]
		public void JWYTTELPWQN(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA4E55A0", Offset = "0xA4E3FA0", VA = "0x18A4E55A0", Slot = "10")]
		public void EBEHFKCMBOK(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA4E54A0", Offset = "0xA4E3EA0", VA = "0x18A4E54A0", Slot = "20")]
		public IEnumerable<Renderer> DCGGTDMDHGB(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA4E56F0", Offset = "0xA4E40F0", VA = "0x18A4E56F0", Slot = "12")]
		public SkinnedCostumeHandle KGLFPHHZHKT(BYSVQDWALNE a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5C80", Offset = "0xA4E4680", VA = "0x18A4E5C80", Slot = "14")]
		public void WHDZEFBWOXM(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5770", Offset = "0xA4E4170", VA = "0x18A4E5770", Slot = "16")]
		public Task KLGPOANTOMA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5CF0", Offset = "0xA4E46F0", VA = "0x18A4E5CF0", Slot = "17")]
		public Task ZZAKSZGRECU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5400", Offset = "0xA4E3E00", VA = "0x18A4E5400", Slot = "18")]
		public Task CFOIZPZTWKV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x19151C0", Offset = "0x1913BC0", VA = "0x1819151C0", Slot = "19")]
		public void DONFOCCVTLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5600", Offset = "0xA4E4000", VA = "0x18A4E5600", Slot = "13")]
		public void ELJOYMQZBLB(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface OHJLTXNSGCP
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool PGUOSCUGJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Material MKYCSRJPJVV();

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material NSFBGGCCMRT();

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Material UBWCLLPOFQH();

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int CYAIDUJLFCM(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int PBQFUXOJPLS(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void BVFGIVBLZNW(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RMPEFIQHCJZ(GameObject a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class BIFQBBTWWXC
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static OHJLTXNSGCP XDDWHOQIEJB;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static bool PGUOSCUGJMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA4D98C0", Offset = "0xA4D82C0", VA = "0x18A4D98C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA4D97F0", Offset = "0xA4D81F0", VA = "0x18A4D97F0")]
		public static void CLPDWCIHFDE(OHJLTXNSGCP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9920", Offset = "0xA4D8320", VA = "0x18A4D9920")]
		public static Material MKYCSRJPJVV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9980", Offset = "0xA4D8380", VA = "0x18A4D9980")]
		public static Material NSFBGGCCMRT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9B40", Offset = "0xA4D8540", VA = "0x18A4D9B40")]
		public static Material UBWCLLPOFQH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9850", Offset = "0xA4D8250", VA = "0x18A4D9850")]
		public static int CYAIDUJLFCM(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA4D99E0", Offset = "0xA4D83E0", VA = "0x18A4D99E0")]
		public static int PBQFUXOJPLS(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9720", Offset = "0xA4D8120", VA = "0x18A4D9720")]
		public static void BVFGIVBLZNW(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA4D9A50", Offset = "0xA4D8450", VA = "0x18A4D9A50")]
		public static void RMPEFIQHCJZ(GameObject a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class HFAWZTYWLEA : HKZQFTQGNDU
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class ZZQHFJZTYMC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Renderer OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public HFAWZTYWLEA XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private List<SkinnedShapeRenderer>.Enumerator ULWCKXMDKCB;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private Renderer BGATZTEBJIK
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x1031740", Offset = "0x1030140", VA = "0x181031740")]
			[DebuggerHidden]
			public ZZQHFJZTYMC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA4EE2D0", Offset = "0xA4ECCD0", VA = "0x18A4EE2D0", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA4EE0B0", Offset = "0xA4ECAB0", VA = "0x18A4EE0B0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA4EE3A0", Offset = "0xA4ECDA0", VA = "0x18A4EE3A0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA4EE360", Offset = "0xA4ECD60", VA = "0x18A4EE360", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA4EE010", Offset = "0xA4ECA10", VA = "0x18A4EE010", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> IXMASTLZJTH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xA4EE010", Offset = "0xA4ECA10", VA = "0x18A4EE010", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly BYSVQDWALNE JTESAUNOTFV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly FMMNRNZBALM OUUTWGJTCLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private ClusterLODSkinnedRenderer EPTWKPTEWZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<GMQKHTTVWCJ> XVTTQSSERKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private List<GMQKHTTVWCJ> AHTIRRDVOHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private GameObject XYQSGQVVMVZ;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA4DFD20", Offset = "0xA4DE720", VA = "0x18A4DFD20")]
		public static HFAWZTYWLEA RDSVRUMUEDI(BYSVQDWALNE a, FMMNRNZBALM b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E0C00", Offset = "0xA4DF600", VA = "0x18A4E0C00")]
		private HFAWZTYWLEA(BYSVQDWALNE a, FMMNRNZBALM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF8A0", Offset = "0xA4DE2A0", VA = "0x18A4DF8A0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E0B80", Offset = "0xA4DF580", VA = "0x18A4E0B80")]
		[IteratorStateMachine(typeof(ZZQHFJZTYMC))]
		public IEnumerable<Renderer> ZCPTTLDTLIR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA4DFE60", Offset = "0xA4DE860", VA = "0x18A4DFE60", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA4E0B50", Offset = "0xA4DF550", VA = "0x18A4E0B50")]
		private void XPIPZWQQMLB(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA4E0900", Offset = "0xA4DF300", VA = "0x18A4E0900")]
		public void Update()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class GMQKHTTVWCJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private struct BoneMeshInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public JOBQCDJAIKZ Generator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public RRTransform BoneTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int BoneIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class XCEEGWYISVS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public GMQKHTTVWCJ XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int DMGFRYMTHPT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int HJESZVCBFXC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public SystemLOD KMTJUSMUYLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public List<BoneMeshInfo> DZZOVWHBSPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public NativeMesh QQHJXOBSSST;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public XCEEGWYISVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA4EB920", Offset = "0xA4EA320", VA = "0x18A4EB920")]
			internal JobHandle ACZJUZCAUSN()
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA4EB8F0", Offset = "0xA4EA2F0", VA = "0x18A4EB8F0")]
			internal void ACUCXSIDLHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA4EB780", Offset = "0xA4EA180", VA = "0x18A4EB780")]
			internal void ACOWALOGBVV()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int[] UNFDWKCHCBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private JNJOMIJPACJ LBYHAVVIOUV;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Matrix4x4 KTKOHYKOWLB;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Mesh WSNDFSGATGI
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int RKAGDTTMNQW
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xD17340", Offset = "0xD15D40", VA = "0x180D17340")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15D60", VA = "0x180D17360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE5D0", Offset = "0xA4DCFD0", VA = "0x18A4DE5D0")]
		public void BAFPLMEJWEH(List<RRTransform> a, Matrix4x4[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA4DE7C0", Offset = "0xA4DD1C0", VA = "0x18A4DE7C0")]
		public static List<GMQKHTTVWCJ> Create(List<FACAKZSYWOH> collections, SystemLOD lod, Bounds bounds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA4DEEC0", Offset = "0xA4DD8C0", VA = "0x18A4DEEC0")]
		private JobHandle FEFTNOHMLLM(NativeMesh a, int b, int c, SystemLOD d, List<BoneMeshInfo> e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF220", Offset = "0xA4DDC20", VA = "0x18A4DF220")]
		private void VCXFVNZVGKO(List<BoneMeshInfo> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA4DF4A0", Offset = "0xA4DDEA0", VA = "0x18A4DF4A0")]
		private GMQKHTTVWCJ(List<BoneMeshInfo> a, int b, int c, SystemLOD d, Bounds e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA4DEE20", Offset = "0xA4DD820", VA = "0x18A4DEE20", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MaterialPropertyBlock LYCJDJJCEGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private GMQKHTTVWCJ NACQLSXVKGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<RRTransform> DNTKFGAGDUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private RenderTexture IIBBEGAACAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private ComputeBuffer MSXJNBSOATA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private ComputeShader NBVXTEOHCGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Matrix4x4[] LXIPHTTHDTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int UBPOTVYDPLW;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer PGJHXAFVVFJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int NNVPVLAQKVA
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xA4E8C10", Offset = "0xA4E7610", VA = "0x18A4E8C10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8270", Offset = "0xA4E6C70", VA = "0x18A4E8270")]
		public static List<SkinnedShapeRenderer> Create(GameObject root, List<GMQKHTTVWCJ> meshes, List<RRTransform> bones, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8630", Offset = "0xA4E7030", VA = "0x18A4E8630")]
		public void Init(GMQKHTTVWCJ mesh, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8B80", Offset = "0xA4E7580", VA = "0x18A4E8B80")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8AF0", Offset = "0xA4E74F0", VA = "0x18A4E8AF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8AB0", Offset = "0xA4E74B0", VA = "0x18A4E8AB0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8570", Offset = "0xA4E6F70", VA = "0x18A4E8570")]
		private void GROLLYRBVIT(ScriptableRenderContext a, Camera[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7F00", Offset = "0xA4E6900", VA = "0x18A4E7F00")]
		private void BAFPLMEJWEH(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xD10140", Offset = "0xD0EB40", VA = "0x180D10140")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xA4E8DF0", Offset = "0xA4E77F0", VA = "0x18A4E8DF0")]
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
