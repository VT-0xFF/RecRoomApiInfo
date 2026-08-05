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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4E9790", Offset = "0xA4E8190", VA = "0x18A4E9790")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4E90B0", Offset = "0xA4E7AB0", VA = "0x18A4E90B0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4F5870", Offset = "0xA4F4270", VA = "0x18A4F5870", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ClusterLODSkinnedRenderer : NSXPXAFYTYQ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private byte GRBPCWFRCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<SkinnedShapeRenderer>[] MHHFRZDHVFM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int HRSMBEUOSCJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xD67210", Offset = "0xD65C10", VA = "0x180D67210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int TIOZFUUUZAY
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD39090", Offset = "0xD37A90", VA = "0x180D39090", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xF22B20", Offset = "0xF21520", VA = "0x180F22B20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float SYWJCUYIHBL
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x10DDB70", Offset = "0x10DC570", VA = "0x1810DDB70", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1369C30", Offset = "0x1368630", VA = "0x181369C30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float MBXKNKWIJQX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xE9D5D0", Offset = "0xE9BFD0", VA = "0x180E9D5D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xF35A90", Offset = "0xF34490", VA = "0x180F35A90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public List<SkinnedShapeRenderer> HWZTUECTYVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1840", Offset = "0xA4E0240", VA = "0x18A4E1840")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<SkinnedShapeRenderer> ZFTBNJIAXCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xA4E18D0", Offset = "0xA4E02D0", VA = "0x18A4E18D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GameObject DVPPDBTFFRU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public byte FBWLOCPCIXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA4E16F0", Offset = "0xA4E00F0", VA = "0x18A4E16F0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1900", Offset = "0xA4E0300", VA = "0x18A4E1900")]
		public ClusterLODSkinnedRenderer(List<TPXHBNOTAQW> lod0Meshes, List<TPXHBNOTAQW> lod1Meshes, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA4E15D0", Offset = "0xA4DFFD0", VA = "0x18A4E15D0")]
		private int DKNPCGGOGNN(List<TPXHBNOTAQW> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1320", Offset = "0xA4DFD20", VA = "0x18A4E1320")]
		private void ARCWAUORPZU(int a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1480", Offset = "0xA4DFE80", VA = "0x18A4E1480")]
		public void CCPPLZBOMUX(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1740", Offset = "0xA4E0140", VA = "0x18A4E1740", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E1890", Offset = "0xA4E0290", VA = "0x18A4E1890")]
		public void OIQTETKBAFY(Transform a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class XWMRCWSPJKG : LXKCGERYGLH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class DCIDAJNDYKS : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Renderer RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public XWMRCWSPJKG TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private List<ClusterMeshRenderer>.Enumerator IRFNBWFCZWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private IEnumerator<Renderer> IRAGEPLFQLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private IEnumerator<MeshRenderer> IQUZHIRIGZW;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private Renderer ONDYNZTZAXT
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public DCIDAJNDYKS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1D00", Offset = "0xA4E0700", VA = "0x18A4E1D00", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1F30", Offset = "0xA4E0930", VA = "0x18A4E1F30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA4E24E0", Offset = "0xA4E0EE0", VA = "0x18A4E24E0")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2530", Offset = "0xA4E0F30", VA = "0x18A4E2530")]
			private void XNORPFATVNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2580", Offset = "0xA4E0F80", VA = "0x18A4E2580")]
			private void XNTYMLUREZH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1EF0", Offset = "0xA4E08F0", VA = "0x18A4E1EF0", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2440", Offset = "0xA4E0E40", VA = "0x18A4E2440", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> PPGORENCSOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2440", Offset = "0xA4E0E40", VA = "0x18A4E2440", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class NCKYXQANVHS : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private Renderer RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public XWMRCWSPJKG TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<Renderer> IRFNBWFCZWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private List<SkinnedShapeRenderer>.Enumerator IRAGEPLFQLF;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private Renderer ONDYNZTZAXT
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public NCKYXQANVHS(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA4E9170", Offset = "0xA4E7B70", VA = "0x18A4E9170", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA4E92E0", Offset = "0xA4E7CE0", VA = "0x18A4E92E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E96F0", Offset = "0xA4E80F0", VA = "0x18A4E96F0")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA4E9740", Offset = "0xA4E8140", VA = "0x18A4E9740")]
			private void XNORPFATVNY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xA4E92A0", Offset = "0xA4E7CA0", VA = "0x18A4E92A0", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA4E9650", Offset = "0xA4E8050", VA = "0x18A4E9650", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> PPGORENCSOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xA4E9650", Offset = "0xA4E8050", VA = "0x18A4E9650", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly FUPABKJKCPX MYBKVZDSTSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<YNTWYRBJVPC> IZCQSECXPLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private List<ClusterMeshRenderer> AICQJTHZIVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BatchedMeshRenderer QCCHJOSEVGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool HNPANUHNEOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly bool HFMNWTIWADE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IEnumerable<MINJGALAJOY> STLUNAKEJCN
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int QURSUCCKJWN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA4F51E0", Offset = "0xA4F3BE0", VA = "0x18A4F51E0", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RRTransform WRFGSIFSNOC
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xA4F54B0", Offset = "0xA4F3EB0", VA = "0x18A4F54B0", Slot = "8")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public List<SkinnedShapeRenderer> PAUUDTSSSHX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xD15990", Offset = "0xD14390", VA = "0x180D15990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA4F47D0", Offset = "0xA4F31D0", VA = "0x18A4F47D0")]
		private bool NFPQNUKFFNI(YNTWYRBJVPC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5220", Offset = "0xA4F3C20", VA = "0x18A4F5220")]
		private static bool TXVHKMUVWOO(YNTWYRBJVPC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5580", Offset = "0xA4F3F80", VA = "0x18A4F5580")]
		public XWMRCWSPJKG(FUPABKJKCPX a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA4F3E10", Offset = "0xA4F2810", VA = "0x18A4F3E10", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA4F3BD0", Offset = "0xA4F25D0", VA = "0x18A4F3BD0")]
		public void Add(YNTWYRBJVPC shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4B60", Offset = "0xA4F3560", VA = "0x18A4F4B60")]
		public void Remove(YNTWYRBJVPC shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4CC0", Offset = "0xA4F36C0", VA = "0x18A4F4CC0", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5240", Offset = "0xA4F3C40", VA = "0x18A4F5240")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4870", Offset = "0xA4F3270", VA = "0x18A4F4870")]
		private void PNXGBSHHBLC(List<YNTWYRBJVPC> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2180", Offset = "0xA4F0B80", VA = "0x18A4F2180")]
		private static Material JRPHDNCWYXI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4A30", Offset = "0xA4F3430", VA = "0x18A4F4A30")]
		private void PNXGBSHHBLC(YNTWYRBJVPC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4000", Offset = "0xA4F2A00", VA = "0x18A4F4000")]
		private void FSPGJTQBXJY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4190", Offset = "0xA4F2B90", VA = "0x18A4F4190")]
		public void IPJUUZKOEDZ(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA4F40D0", Offset = "0xA4F2AD0", VA = "0x18A4F40D0")]
		protected void GNKKUXTAOEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA4F47F0", Offset = "0xA4F31F0", VA = "0x18A4F47F0")]
		public void PNKEZHFMMUR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4750", Offset = "0xA4F3150", VA = "0x18A4F4750")]
		[IteratorStateMachine(typeof(DCIDAJNDYKS))]
		public IEnumerable<Renderer> JDVTFVOPCCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA4F4AE0", Offset = "0xA4F34E0", VA = "0x18A4F4AE0")]
		[IteratorStateMachine(typeof(NCKYXQANVHS))]
		public IEnumerable<Renderer> RPITVRKLDLX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[BurstCompile]
	internal class LIDRTSFSTXQ : YNTWYRBJVPC
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct CurveToken : BAIPCUUHQHC, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA4E1CA0", Offset = "0xA4E06A0", VA = "0x18A4E1CA0")]
			public CurveToken(NativeMesh mesh, JobHandle jobHandle, CurveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1C20", Offset = "0xA4E0620", VA = "0x18A4E1C20", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA4E1C50", Offset = "0xA4E0650", VA = "0x18A4E1C50", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void CalculateFastCurveBounds_00000039$PostfixBurstDelegate([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class CGCBBBQFYRS
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0F50", Offset = "0xA4DF950", VA = "0x18A4E0F50")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E10E0", Offset = "0xA4DFAE0", VA = "0x18A4E10E0")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E0BA0", Offset = "0xA4DF5A0", VA = "0x18A4E0BA0")]
			public unsafe static void Invoke([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal readonly CCPIUGMOBRO FHSVSDRCXSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float UQNSVNNVQEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Hash128 PNVOKEEQUDP;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override Hash128 WTWHJGBNPRR
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E8C90", Offset = "0xA4E7690", VA = "0x18A4E8C90", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9000", Offset = "0xA4E7A00", VA = "0x18A4E9000")]
		public LIDRTSFSTXQ(XWMRCWSPJKG a, CCPIUGMOBRO b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "18")]
		public override bool KYYCMEQHLJS(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7700", Offset = "0xA4E6100", VA = "0x18A4E7700", Slot = "19")]
		public override int DKNPCGGOGNN(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7AD0", Offset = "0xA4E64D0", VA = "0x18A4E7AD0", Slot = "20")]
		public override int FHDZBSFPXMR(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8DD0", Offset = "0xA4E77D0", VA = "0x18A4E8DD0", Slot = "21")]
		public override RRBounds WQXSICQRBJL()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8DC0", Offset = "0xA4E77C0", VA = "0x18A4E8DC0")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastCurveBounds_00000039$PostfixBurstDelegate))]
		private unsafe static void QBIXWKHMFNM([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xDBDA60", Offset = "0xDBC460", VA = "0x180DBDA60", Slot = "22")]
		public override float CONJTODHEUD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8660", Offset = "0xA4E7060", VA = "0x18A4E8660", Slot = "23")]
		public override void OGJTSPDCCGH(SystemLOD a, JWLFCSSJZIO b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E78E0", Offset = "0xA4E62E0", VA = "0x18A4E78E0")]
		private int EXDVCDYQACK(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7630", Offset = "0xA4E6030", VA = "0x18A4E7630", Slot = "24")]
		public override RRTransform AQQHSGRHBFU()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA4E8AD0", Offset = "0xA4E74D0", VA = "0x18A4E8AD0", Slot = "26")]
		public override MaterialInfo PBSYIDEIQMT()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7EA0", Offset = "0xA4E68A0", VA = "0x18A4E7EA0", Slot = "27")]
		public override BAIPCUUHQHC KRKNCZBPEXR(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7CB0", Offset = "0xA4E66B0", VA = "0x18A4E7CB0")]
		[BurstCompile]
		internal unsafe static void JMFQWFELHXX([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NYMVAQBKJJR
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		XWMRCWSPJKG this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		YNTWYRBJVPC this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		VNTKASGSXKT this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class IBVCMJAPGKU : JQHWVSIEFUY, IDisposable, NYMVAQBKJJR
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
			public IBVCMJAPGKU <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA4F1250", Offset = "0xA4EFC50", VA = "0x18A4F1250", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA4F17C0", Offset = "0xA4F01C0", VA = "0x18A4F17C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly TRLKZXWGXSV<RootHandle, XWMRCWSPJKG> UBTADTFJNTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly TRLKZXWGXSV<ShapeHandle, YNTWYRBJVPC> IZCQSECXPLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly TRLKZXWGXSV<SkinnedCostumeHandle, VNTKASGSXKT> WZIKYGOYXNX;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public XWMRCWSPJKG this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E5080", Offset = "0xA4E3A80", VA = "0x18A4E5080", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public YNTWYRBJVPC this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xA4E5020", Offset = "0xA4E3A20", VA = "0x18A4E5020", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public VNTKASGSXKT this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA4E50E0", Offset = "0xA4E3AE0", VA = "0x18A4E50E0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool OQOQIHNMIML
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xDA45D0", Offset = "0xDA2FD0", VA = "0x180DA45D0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xDA45E0", Offset = "0xDA2FE0", VA = "0x180DA45E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4BA0", Offset = "0xA4E35A0", VA = "0x18A4E4BA0")]
		public IBVCMJAPGKU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2B70", Offset = "0xA4E1570", VA = "0x18A4E2B70", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4220", Offset = "0xA4E2C20", VA = "0x18A4E4220", Slot = "4")]
		public RootHandle OOZOTOCGBDL(FUPABKJKCPX a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4230", Offset = "0xA4E2C30", VA = "0x18A4E4230", Slot = "5")]
		public RootHandle OOZOTOCGBDL(FUPABKJKCPX a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4940", Offset = "0xA4E3340", VA = "0x18A4E4940", Slot = "6")]
		public void XTKMIMWAOCS(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA4E44A0", Offset = "0xA4E2EA0", VA = "0x18A4E44A0", Slot = "7")]
		public void UNPGWBJDNLB(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3890", Offset = "0xA4E2290", VA = "0x18A4E3890", Slot = "8")]
		public ShapeHandle NARGQPDDUQW(RootHandle a, PGCTFAKTRCG b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3D50", Offset = "0xA4E2750", VA = "0x18A4E3D50", Slot = "9")]
		public ShapeHandle NSDIUBLGEZS(RootHandle a, CCPIUGMOBRO b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2F60", Offset = "0xA4E1960", VA = "0x18A4E2F60", Slot = "11")]
		public void EYAETUDRNFS(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3310", Offset = "0xA4E1D10", VA = "0x18A4E3310", Slot = "10")]
		public void GOHJIDUUPMT(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3660", Offset = "0xA4E2060", VA = "0x18A4E3660", Slot = "20")]
		public IEnumerable<Renderer> KJZZECXTVGI(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E47F0", Offset = "0xA4E31F0", VA = "0x18A4E47F0", Slot = "12")]
		public SkinnedCostumeHandle UUMYPJNLMPS(DKWWUWVRRCX a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2B00", Offset = "0xA4E1500", VA = "0x18A4E2B00", Slot = "14")]
		public void BDSJDWMOQAN(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA4E36D0", Offset = "0xA4E20D0", VA = "0x18A4E36D0", Slot = "16")]
		public Task LPRGGCGVQWT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2DA0", Offset = "0xA4E17A0", VA = "0x18A4E2DA0", Slot = "17")]
		public Task EPXTAAYAREN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4870", Offset = "0xA4E3270", VA = "0x18A4E4870", Slot = "18")]
		[AsyncStateMachine(typeof(<EndRoomLoad>d__28))]
		public Task WKKTGGWUBZC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3570", Offset = "0xA4E1F70", VA = "0x18A4E3570", Slot = "19")]
		public void JEYSRBWRARV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA4E2D40", Offset = "0xA4E1740", VA = "0x18A4E2D40", Slot = "13")]
		public void EPNVUPWDJGA(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[BurstCompile]
	internal class KBBTVWNYQZS : YNTWYRBJVPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct PrimitiveToken : BAIPCUUHQHC, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA4EC640", Offset = "0xA4EB040", VA = "0x18A4EC640")]
			public PrimitiveToken(NativeMesh mesh, NativeArray<int> vertCollapseTarget, JobHandle jobHandle, PrimitiveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC540", Offset = "0xA4EAF40", VA = "0x18A4EC540", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xA4EC5A0", Offset = "0xA4EAFA0", VA = "0x18A4EC5A0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class FYNEYWAHOIA
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private static IntPtr WRXECCJXUEX;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA4E27F0", Offset = "0xA4E11F0", VA = "0x18A4E27F0")]
			[BurstDiscard]
			private static void LFOJSPAYAKH(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xA4E2980", Offset = "0xA4E1380", VA = "0x18A4E2980")]
			private static IntPtr MKZHJEVIWOD()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0xA4E25D0", Offset = "0xA4E0FD0", VA = "0x18A4E25D0")]
			public static void Invoke([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly PGCTFAKTRCG IONDNHXDBLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int[] NQWAVWYQTIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Hash128 PNVOKEEQUDP;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector3 GCHQIPTUEOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA4E7350", Offset = "0xA4E5D50", VA = "0x18A4E7350")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override Hash128 WTWHJGBNPRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA4E6B70", Offset = "0xA4E5570", VA = "0x18A4E6B70", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7580", Offset = "0xA4E5F80", VA = "0x18A4E7580")]
		public KBBTVWNYQZS(XWMRCWSPJKG a, PGCTFAKTRCG b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA4E6080", Offset = "0xA4E4A80", VA = "0x18A4E6080", Slot = "18")]
		public override bool KYYCMEQHLJS(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7310", Offset = "0xA4E5D10", VA = "0x18A4E7310", Slot = "21")]
		public override RRBounds WQXSICQRBJL()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA4E7030", Offset = "0xA4E5A30", VA = "0x18A4E7030")]
		private RRBounds WQXSICQRBJL(RRTransform a)
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5300", Offset = "0xA4E3D00", VA = "0x18A4E5300")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate))]
		private static void DBQHSIYKNTG([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5E80", Offset = "0xA4E4880", VA = "0x18A4E5E80")]
		private OcclusionData KXYNDPGXTXN([In] UniformTRS worldFromLocalUniformTRS, [In] float3 worldScale)
		{
			return default(OcclusionData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5310", Offset = "0xA4E3D10", VA = "0x18A4E5310", Slot = "19")]
		public override int DKNPCGGOGNN(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA4E53C0", Offset = "0xA4E3DC0", VA = "0x18A4E53C0", Slot = "20")]
		public override int FHDZBSFPXMR(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5210", Offset = "0xA4E3C10", VA = "0x18A4E5210", Slot = "22")]
		public override float CONJTODHEUD()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5470", Offset = "0xA4E3E70", VA = "0x18A4E5470")]
		private int IIXSRDHAYLB(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xA4E6150", Offset = "0xA4E4B50", VA = "0x18A4E6150", Slot = "23")]
		public override void OGJTSPDCCGH(SystemLOD a, JWLFCSSJZIO b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xA4E5140", Offset = "0xA4E3B40", VA = "0x18A4E5140", Slot = "24")]
		public override RRTransform AQQHSGRHBFU()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xA4E69B0", Offset = "0xA4E53B0", VA = "0x18A4E69B0", Slot = "26")]
		public override MaterialInfo PBSYIDEIQMT()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xA4E56F0", Offset = "0xA4E40F0", VA = "0x18A4E56F0", Slot = "27")]
		public override BAIPCUUHQHC KRKNCZBPEXR(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xA4E6CA0", Offset = "0xA4E56A0", VA = "0x18A4E6CA0")]
		[BurstCompile]
		internal static void UPOIDLFOIEH([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface WYLRRBDUQYK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VCJUYLUBXDL(SelectionEffectType a, Renderer b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void HDYVAFENIYC(Renderer a, IgnoreEffectType b, Vector3 c, Vector3 d, Vector3 e, float f, float g, float h = -1f, [Optional] Color? i, [Optional] IReadOnlyList<Camera> j);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UZMUCHFCXVT(Renderer a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int GUMVZDTAFUA();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void RENBYVYRMKJ(int a, OutlineEffectType b, Renderer c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PVJKROIHHAJ : ZLNHNDJSHXI, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class XHGJECLWBZA : LXOEYMKBHWP<int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0xA4F3980", Offset = "0xA4F2380", VA = "0x18A4F3980")]
			public XHGJECLWBZA(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly WYLRRBDUQYK GUJEOHSJNTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly NYMVAQBKJJR UUBESIFBBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MeshRenderer QNJHEZKITAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private XHGJECLWBZA IUDRLEPGNPQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool SSODJSELBUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MeshRenderer OJVLONNRZVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private XHGJECLWBZA LSWHSWUVJXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool FDJQJKVNATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MeshRenderer ONPZKVFVITS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private XHGJECLWBZA XAWCVZNQYMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool XHCVAUXKBQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool JHVCKNKMFHD;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xD13D90", Offset = "0xD12790", VA = "0x180D13D90")]
		public PVJKROIHHAJ(WYLRRBDUQYK a, NYMVAQBKJJR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA570", Offset = "0xA4E8F70", VA = "0x18A4EA570", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBE20", Offset = "0xA4EA820", VA = "0x18A4EBE20")]
		private void XWFJFBAAWCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB750", Offset = "0xA4EA150", VA = "0x18A4EB750", Slot = "4")]
		public void TTRDJCUOQVS(RootHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBA60", Offset = "0xA4EA460", VA = "0x18A4EBA60", Slot = "5")]
		public void TTRDJCUOQVS(ShapeHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9BF0", Offset = "0xA4E85F0", VA = "0x18A4E9BF0", Slot = "6")]
		public void ASFLBXHSSUM(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB330", Offset = "0xA4E9D30", VA = "0x18A4EB330", Slot = "7")]
		public void PABPDIYLWXE(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB710", Offset = "0xA4EA110", VA = "0x18A4EB710", Slot = "24")]
		public void TSLKFFWBKNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x148C670", Offset = "0x148B070", VA = "0x18148C670", Slot = "8")]
		public void MKQQZIKDGIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB5A0", Offset = "0xA4E9FA0", VA = "0x18A4EB5A0", Slot = "9")]
		public void RJZLYABSPSO(OutlineEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA4E9D50", Offset = "0xA4E8750", VA = "0x18A4E9D50", Slot = "10")]
		public void BZNEWBWLTTH(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA020", Offset = "0xA4E8A20", VA = "0x18A4EA020", Slot = "11")]
		public void BZNEWBWLTTH(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA4A0", Offset = "0xA4E8EA0", VA = "0x18A4EA4A0", Slot = "12")]
		public void DSCUWMQVVAA(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAA00", Offset = "0xA4E9400", VA = "0x18A4EAA00", Slot = "13")]
		public void NRYDAKNWAVA(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC2E0", Offset = "0xA4EACE0", VA = "0x18A4EC2E0")]
		private void ZFGAWPGELQP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x19165F0", Offset = "0x1914FF0", VA = "0x1819165F0", Slot = "14")]
		public void EKLSTCXTTMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0xA4EB480", Offset = "0xA4E9E80", VA = "0x18A4EB480", Slot = "15")]
		public void RJBIYSDLHXE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA720", Offset = "0xA4E9120", VA = "0x18A4EA720", Slot = "16")]
		public void GTXZCHGZKLO(RootHandle a, SelectionEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBD50", Offset = "0xA4EA750", VA = "0x18A4EBD50", Slot = "17")]
		public void XKUADZLKHMA(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xA4EBC80", Offset = "0xA4EA680", VA = "0x18A4EBC80", Slot = "18")]
		public void VFDKVOMHYDU(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xF5A8D0", Offset = "0xF592D0", VA = "0x180F5A8D0", Slot = "19")]
		public void HBERKHTKQTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0xA4EA370", Offset = "0xA4E8D70", VA = "0x18A4EA370", Slot = "20")]
		public void CDRPCCLWKVU(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC080", Offset = "0xA4EAA80", VA = "0x18A4EC080")]
		private void XYBJAZWWYXB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAF60", Offset = "0xA4E9960", VA = "0x18A4EAF60", Slot = "21")]
		public void OVRYJFOXAPA(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<Camera> g, IgnoreEffectType h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA4EAAD0", Offset = "0xA4E94D0", VA = "0x18A4EAAD0", Slot = "22")]
		public void OVRYJFOXAPA(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class YNTWYRBJVPC : UHPMWJCUHFB, MINJGALAJOY, XSAUWYWIRPA, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly XWMRCWSPJKG DVPPDBTFFRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int VNAZZMFGOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected Bounds XDJFKQTHPIO;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Bounds NGUORVHTOSO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xA4F57F0", Offset = "0xA4F41F0", VA = "0x18A4F57F0", Slot = "4")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool HFMNWTIWADE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xF59E30", Offset = "0xF58830", VA = "0x180F59E30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xF598E0", Offset = "0xF582E0", VA = "0x180F598E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected abstract Hash128 WTWHJGBNPRR
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int GFHXSGWGDMI
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public NUQJWRRUOHF CGAPYOCXRSA
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xD15990", Offset = "0xD14390", VA = "0x180D15990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool ZXWVSPKYUUO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1B1D550", Offset = "0x1B1BF50", VA = "0x181B1D550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		protected YNTWYRBJVPC(XWMRCWSPJKG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5670", Offset = "0xA4F4070", VA = "0x18A4F5670", Slot = "17")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "18")]
		public virtual bool KYYCMEQHLJS(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA4F57E0", Offset = "0xA4F41E0", VA = "0x18A4F57E0", Slot = "10")]
		public int LICKLOKGWTL(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract int DKNPCGGOGNN(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract int FHDZBSFPXMR(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract RRBounds WQXSICQRBJL();

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract float CONJTODHEUD();

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		public abstract void OGJTSPDCCGH(SystemLOD a, JWLFCSSJZIO b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract RRTransform AQQHSGRHBFU();

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5810", Offset = "0xA4F4210", VA = "0x18A4F5810", Slot = "13")]
		public Hash128 XTVDHZDSQDA(int a)
		{
			return default(Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract MaterialInfo PBSYIDEIQMT();

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract BAIPCUUHQHC KRKNCZBPEXR(SystemLOD a, JobHandle b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA4F5840", Offset = "0xA4F4240", VA = "0x18A4F5840", Slot = "12")]
		public BAIPCUUHQHC YMXXUUIMMNG(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xA4EC690", Offset = "0xA4EB090", VA = "0x18A4EC690")]
		public ShapeRendererConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class ShapeRendererSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class UBQFSUGYTAT : IEnumerable<VBBBIWSKPYV>, IEnumerable, IEnumerator<VBBBIWSKPYV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private VBBBIWSKPYV RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int GLWHOWWQFCR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int YWUSESGGSQC;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private VBBBIWSKPYV GVOISVEHADR
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public UBQFSUGYTAT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA4F1F60", Offset = "0xA4F0960", VA = "0x18A4F1F60", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA4F1F20", Offset = "0xA4F0920", VA = "0x18A4F1F20", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xA4F2030", Offset = "0xA4F0A30", VA = "0x18A4F2030", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<VBBBIWSKPYV> VATENUKJHAU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xA4F2030", Offset = "0xA4F0A30", VA = "0x18A4F2030", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static VBBBIWSKPYV[][] MPIYOVXUMKN;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static FTZIXOUXSTQ YKXSMOUKFDV;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static ShapeRendererConfig TDKUBDRZQTS;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static ComputeShader VCAPCFJGWJU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA4EEC20", Offset = "0xA4ED620", VA = "0x18A4EEC20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static SkinnedShapeRenderer KTQVLQTTLDR
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xA4EED80", Offset = "0xA4ED780", VA = "0x18A4EED80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEC80", Offset = "0xA4ED680", VA = "0x18A4EEC80")]
		[RRRuntimeInitializeMethod]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEE70", Offset = "0xA4ED870", VA = "0x18A4EEE70")]
		public static Mesh XORAKTNINKS(PrimitiveShapeMeshType a, int b = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEDE0", Offset = "0xA4ED7E0", VA = "0x18A4EEDE0")]
		public static int QPUBWLBFEKB(PrimitiveShapeMeshType a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDB50", Offset = "0xA4EC550", VA = "0x18A4EDB50")]
		public static FTZIXOUXSTQ FWVEFETZZNM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEDF0", Offset = "0xA4ED7F0", VA = "0x18A4EEDF0")]
		[IteratorStateMachine(typeof(UBQFSUGYTAT))]
		private static IEnumerable<VBBBIWSKPYV> SXAVYBAKHVQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xA4EDD70", Offset = "0xA4EC770", VA = "0x18A4EDD70")]
		public static VBBBIWSKPYV GPEDOGAPITZ(PrimitiveShapeMeshType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEE50", Offset = "0xA4ED850", VA = "0x18A4EEE50")]
		public static bool XGHYBLUUJIP(this PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED9A0", Offset = "0xA4EC3A0", VA = "0x18A4ED9A0")]
		public static void DXJHWYIBDNX(PrimitiveShapeMeshType a, float3 b, [Out] BevelScalingMode c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED5E0", Offset = "0xA4EBFE0", VA = "0x18A4ED5E0")]
		public static void AETPLQWVYMC(Vector3 a, PrimitiveShapeMeshType b, [Out] Vector3 c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA4EED70", Offset = "0xA4ED770", VA = "0x18A4EED70")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void LHFEUSKNJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA4EEF10", Offset = "0xA4ED910", VA = "0x18A4EEF10")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void YIQLULYRJJS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ShapeRendererManager : JQHWVSIEFUY, IDisposable, NYMVAQBKJJR
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly TRLKZXWGXSV<RootHandle, XWMRCWSPJKG> UBTADTFJNTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly TRLKZXWGXSV<ShapeHandle, YNTWYRBJVPC> IZCQSECXPLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly TRLKZXWGXSV<SkinnedCostumeHandle, VNTKASGSXKT> WZIKYGOYXNX;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public XWMRCWSPJKG this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED520", Offset = "0xA4EBF20", VA = "0x18A4ED520", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public YNTWYRBJVPC this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED580", Offset = "0xA4EBF80", VA = "0x18A4ED580", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public VNTKASGSXKT this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0xA4ED4C0", Offset = "0xA4EBEC0", VA = "0x18A4ED4C0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool OQOQIHNMIML
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xDA45D0", Offset = "0xDA2FD0", VA = "0x180DA45D0", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xDA45E0", Offset = "0xDA2FE0", VA = "0x180DA45E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED110", Offset = "0xA4EBB10", VA = "0x18A4ED110")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC760", Offset = "0xA4EB160", VA = "0x18A4EC760", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECD70", Offset = "0xA4EB770", VA = "0x18A4ECD70", Slot = "4")]
		public RootHandle OOZOTOCGBDL(FUPABKJKCPX a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECD70", Offset = "0xA4EB770", VA = "0x18A4ECD70", Slot = "5")]
		public RootHandle OOZOTOCGBDL(FUPABKJKCPX a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0xA4ED020", Offset = "0xA4EBA20", VA = "0x18A4ED020", Slot = "6")]
		public void XTKMIMWAOCS(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECE80", Offset = "0xA4EB880", VA = "0x18A4ECE80", Slot = "7")]
		public void UNPGWBJDNLB(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECAF0", Offset = "0xA4EB4F0", VA = "0x18A4ECAF0", Slot = "8")]
		public ShapeHandle NARGQPDDUQW(RootHandle a, PGCTFAKTRCG b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECC30", Offset = "0xA4EB630", VA = "0x18A4ECC30", Slot = "9")]
		public ShapeHandle NSDIUBLGEZS(RootHandle a, CCPIUGMOBRO b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC8F0", Offset = "0xA4EB2F0", VA = "0x18A4EC8F0", Slot = "11")]
		public void EYAETUDRNFS(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC980", Offset = "0xA4EB380", VA = "0x18A4EC980", Slot = "10")]
		public void GOHJIDUUPMT(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC9E0", Offset = "0xA4EB3E0", VA = "0x18A4EC9E0", Slot = "20")]
		public IEnumerable<Renderer> KJZZECXTVGI(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECF00", Offset = "0xA4EB900", VA = "0x18A4ECF00", Slot = "12")]
		public SkinnedCostumeHandle UUMYPJNLMPS(DKWWUWVRRCX a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC6F0", Offset = "0xA4EB0F0", VA = "0x18A4EC6F0", Slot = "14")]
		public void BDSJDWMOQAN(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECA50", Offset = "0xA4EB450", VA = "0x18A4ECA50", Slot = "16")]
		public Task LPRGGCGVQWT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC850", Offset = "0xA4EB250", VA = "0x18A4EC850", Slot = "17")]
		public Task EPXTAAYAREN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0xA4ECF80", Offset = "0xA4EB980", VA = "0x18A4ECF80", Slot = "18")]
		public Task WKKTGGWUBZC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x1915990", Offset = "0x1914390", VA = "0x181915990", Slot = "19")]
		public void JEYSRBWRARV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA4EC7F0", Offset = "0xA4EB1F0", VA = "0x18A4EC7F0", Slot = "13")]
		public void EPNVUPWDJGA(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface NKFEIXYGBRG
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool MDLNGVDVYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Material HJVZDIDORLE();

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material JRPHDNCWYXI();

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Material SKSTFLTKZXK();

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int RKGWSZDCMCP(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int ZGTUURXQRFX(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void JXUEBKZYUFZ(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void RMQERYCQHWU(GameObject a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class UVKCUKOAOHT
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static NKFEIXYGBRG VSOTKSEOWJK;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static bool MDLNGVDVYAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0xA4F20C0", Offset = "0xA4F0AC0", VA = "0x18A4F20C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0xA4F22B0", Offset = "0xA4F0CB0", VA = "0x18A4F22B0")]
		public static void NGCVKGSHGBJ(NKFEIXYGBRG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2120", Offset = "0xA4F0B20", VA = "0x18A4F2120")]
		public static Material HJVZDIDORLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2180", Offset = "0xA4F0B80", VA = "0x18A4F2180")]
		public static Material JRPHDNCWYXI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2470", Offset = "0xA4F0E70", VA = "0x18A4F2470")]
		public static Material SKSTFLTKZXK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2310", Offset = "0xA4F0D10", VA = "0x18A4F2310")]
		public static int RKGWSZDCMCP(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA4F24D0", Offset = "0xA4F0ED0", VA = "0x18A4F24D0")]
		public static int ZGTUURXQRFX(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA4F21E0", Offset = "0xA4F0BE0", VA = "0x18A4F21E0")]
		public static void JXUEBKZYUFZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2380", Offset = "0xA4F0D80", VA = "0x18A4F2380")]
		public static void RMQERYCQHWU(GameObject a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class VNTKASGSXKT : LXKCGERYGLH
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class ORZOXUHJCAJ : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Renderer RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public VNTKASGSXKT TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private List<SkinnedShapeRenderer>.Enumerator IRFNBWFCZWO;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private Renderer ONDYNZTZAXT
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public ORZOXUHJCAJ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA4E9810", Offset = "0xA4E8210", VA = "0x18A4E9810", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xA4E98E0", Offset = "0xA4E82E0", VA = "0x18A4E98E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA4E9BA0", Offset = "0xA4E85A0", VA = "0x18A4E9BA0")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0xA4E98A0", Offset = "0xA4E82A0", VA = "0x18A4E98A0", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0xA4E9B00", Offset = "0xA4E8500", VA = "0x18A4E9B00", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> PPGORENCSOS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0xA4E9B00", Offset = "0xA4E8500", VA = "0x18A4E9B00", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly DKWWUWVRRCX ZYYOOLODBHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly NYMVAQBKJJR UUBESIFBBED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private ClusterLODSkinnedRenderer ZQWZLYTEDKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<TPXHBNOTAQW> PAOPHASUIBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private List<TPXHBNOTAQW> PSYOWPIQVZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private GameObject KXBBXGDPZOK;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2540", Offset = "0xA4F0F40", VA = "0x18A4F2540")]
		public static VNTKASGSXKT DSZCJNGRLGP(DKWWUWVRRCX a, NYMVAQBKJJR b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA4F38A0", Offset = "0xA4F22A0", VA = "0x18A4F38A0")]
		private VNTKASGSXKT(DKWWUWVRRCX a, NYMVAQBKJJR b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2680", Offset = "0xA4F1080", VA = "0x18A4F2680")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2B30", Offset = "0xA4F1530", VA = "0x18A4F2B30")]
		[IteratorStateMachine(typeof(ORZOXUHJCAJ))]
		public IEnumerable<Renderer> JDVTFVOPCCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2BB0", Offset = "0xA4F15B0", VA = "0x18A4F2BB0", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0xA4F2B00", Offset = "0xA4F1500", VA = "0x18A4F2B00")]
		private void FOQDXJLJSPE(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0xA4F3650", Offset = "0xA4F2050", VA = "0x18A4F3650")]
		public void Update()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class TPXHBNOTAQW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private struct BoneMeshInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public JWLFCSSJZIO Generator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public RRTransform BoneTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int BoneIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class XPQTJHQZHON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public TPXHBNOTAQW TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int BBLBLTCFIMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int BBKCZCOANAX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public SystemLOD WWFCWVJTORD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public List<BoneMeshInfo> NZCBVHEVCIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public NativeMesh IYOKLOZDHUI;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public XPQTJHQZHON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0xA4F39D0", Offset = "0xA4F23D0", VA = "0x18A4F39D0")]
			internal JobHandle CMTNCYRJJNO()
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xA4F3A30", Offset = "0xA4F2430", VA = "0x18A4F3A30")]
			internal void CMYUAFLGSYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xA4F3A60", Offset = "0xA4F2460", VA = "0x18A4F3A60")]
			internal void CNEAXMFECKG()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int[] NPRRASGNEXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private FSHQKKTUMEA KJYLAVLXLNC;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Matrix4x4 FNJISRWFNJK;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Mesh GQBKHMYYRID
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int MMMFHYRJPPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xD1B430", Offset = "0xD19E30", VA = "0x180D1B430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0A80", Offset = "0xA4EF480", VA = "0x18A4F0A80")]
		public void KAHKBIIIUSG(List<RRTransform> a, Matrix4x4[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0020", Offset = "0xA4EEA20", VA = "0x18A4F0020")]
		public static List<TPXHBNOTAQW> Create(List<XWMRCWSPJKG> collections, SystemLOD lod, Bounds bounds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0720", Offset = "0xA4EF120", VA = "0x18A4F0720")]
		private JobHandle HDNWCEEWQVD(NativeMesh a, int b, int c, SystemLOD d, List<BoneMeshInfo> e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFF40", Offset = "0xA4EE940", VA = "0x18A4EFF40")]
		private void ARFZXJABEDP(List<BoneMeshInfo> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0E10", Offset = "0xA4EF810", VA = "0x18A4F0E10")]
		private TPXHBNOTAQW(List<BoneMeshInfo> a, int b, int c, SystemLOD d, Bounds e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA4F0680", Offset = "0xA4EF080", VA = "0x18A4F0680", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MaterialPropertyBlock RQTSZPMHCXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TPXHBNOTAQW CVWFPBRYVBZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<RRTransform> FIXKXLHZMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private RenderTexture GLNEGLIXLTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private ComputeBuffer YOMLORLCFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private ComputeShader CPFWVSYVSCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Matrix4x4[] KXBYQQDGSGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int QTWAZNOUQFL;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer VKOWHGLAJDW
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int CLACLEHXZWR
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0xA4EFF00", Offset = "0xA4EE900", VA = "0x18A4EFF00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF1F0", Offset = "0xA4EDBF0", VA = "0x18A4EF1F0")]
		public static List<SkinnedShapeRenderer> Create(GameObject root, List<TPXHBNOTAQW> meshes, List<RRTransform> bones, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF4F0", Offset = "0xA4EDEF0", VA = "0x18A4EF4F0")]
		public void Init(TPXHBNOTAQW mesh, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFE70", Offset = "0xA4EE870", VA = "0x18A4EFE70")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFDE0", Offset = "0xA4EE7E0", VA = "0x18A4EFDE0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFDA0", Offset = "0xA4EE7A0", VA = "0x18A4EFDA0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA4EFCE0", Offset = "0xA4EE6E0", VA = "0x18A4EFCE0")]
		private void MAGEBYLGLDY(ScriptableRenderContext a, Camera[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA4EF970", Offset = "0xA4EE370", VA = "0x18A4EF970")]
		private void KAHKBIIIUSG(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0xA4F1210", Offset = "0xA4EFC10", VA = "0x18A4F1210")]
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
