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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F38110", Offset = "0x8F37310", VA = "0x188F38110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE0A80", Offset = "0xADFC80", VA = "0x180AE0A80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F38050", Offset = "0x8F37250", VA = "0x188F38050", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F43E20", Offset = "0x8F43020", VA = "0x188F43E20", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27815F0", Offset = "0x27807F0", VA = "0x1827815F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ShapeRendering
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class ClusterLODSkinnedRenderer : FJFWPYKHBFE, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private byte COAPZQVXRQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private readonly List<SkinnedShapeRenderer>[] CEBYOYTCQCE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int KUKHAMHJHSH
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xAC7520", Offset = "0xAC6720", VA = "0x180AC7520", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB0EDE0", Offset = "0xB0DFE0", VA = "0x180B0EDE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int SWRGGQFTPYC
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xADEA60", Offset = "0xADDC60", VA = "0x180ADEA60", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCAE8D0", Offset = "0xCADAD0", VA = "0x180CAE8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float OXRIPBFOHXV
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xE5DE80", Offset = "0xE5D080", VA = "0x180E5DE80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1110E20", Offset = "0x1110020", VA = "0x181110E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float CXCINPVVJAF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xC10800", Offset = "0xC0FA00", VA = "0x180C10800", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCAA5F0", Offset = "0xCA97F0", VA = "0x180CAA5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public List<SkinnedShapeRenderer> GBSXPINQPDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8F2F8E0", Offset = "0x8F2EAE0", VA = "0x188F2F8E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public List<SkinnedShapeRenderer> WWAWCBCSMOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8F2F790", Offset = "0x8F2E990", VA = "0x188F2F790")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public GameObject YEFNNEOPVAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xABA460", Offset = "0xAB9660", VA = "0x180ABA460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xABA420", Offset = "0xAB9620", VA = "0x180ABA420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public byte ZYOEHJYLIRZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8F2F4F0", Offset = "0x8F2E6F0", VA = "0x188F2F4F0", Slot = "8")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F930", Offset = "0x8F2EB30", VA = "0x188F2F930")]
		public ClusterLODSkinnedRenderer(List<GFBRMNPTITW> lod0Meshes, List<GFBRMNPTITW> lod1Meshes, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F7C0", Offset = "0x8F2E9C0", VA = "0x188F2F7C0")]
		private int JJOOJCERKLX(List<GFBRMNPTITW> a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F390", Offset = "0x8F2E590", VA = "0x188F2F390")]
		private void BJWCJKVGHTG(int a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F640", Offset = "0x8F2E840", VA = "0x188F2F640")]
		public void ECLLMPIYFON(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F540", Offset = "0x8F2E740", VA = "0x188F2F540", Slot = "9")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8F2F350", Offset = "0x8F2E550", VA = "0x188F2F350")]
		public void ARVQWUWRBLW(Transform a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class OEGJZWZFOXW : SMOTOSVMBZR, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class QXHXRUCLTTO : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private Renderer HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public OEGJZWZFOXW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private List<ClusterMeshRenderer>.Enumerator XORIMGFAPUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private IEnumerator<Renderer> XPHDEAMSSCZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private IEnumerator<MeshRenderer> XPBWGTSVIRQ;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private Renderer CWWIMCMCSZN
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public QXHXRUCLTTO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8F39DB0", Offset = "0x8F38FB0", VA = "0x188F39DB0", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x8F3A040", Offset = "0x8F39240", VA = "0x188F3A040", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8F3A5F0", Offset = "0x8F397F0", VA = "0x188F3A5F0")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8F3A550", Offset = "0x8F39750", VA = "0x188F3A550")]
			private void RJYPYWGNHOQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8F3A5A0", Offset = "0x8F397A0", VA = "0x188F3A5A0")]
			private void RKDWWDAKQZZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8F3A640", Offset = "0x8F39840", VA = "0x188F3A640", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x8F39FA0", Offset = "0x8F391A0", VA = "0x188F39FA0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> WLIYPXTYRMA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x8F39FA0", Offset = "0x8F391A0", VA = "0x188F39FA0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class EBKFEONFMKG : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private Renderer HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public OEGJZWZFOXW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private IEnumerator<Renderer> XORIMGFAPUY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private List<SkinnedShapeRenderer>.Enumerator XPHDEAMSSCZ;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private Renderer CWWIMCMCSZN
			{
				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public EBKFEONFMKG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x8F2FD20", Offset = "0x8F2EF20", VA = "0x188F2FD20", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8F2FEF0", Offset = "0x8F2F0F0", VA = "0x188F2FEF0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8F302B0", Offset = "0x8F2F4B0", VA = "0x188F302B0")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8F30260", Offset = "0x8F2F460", VA = "0x188F30260")]
			private void RJYPYWGNHOQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x8F30300", Offset = "0x8F2F500", VA = "0x188F30300", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8F2FE50", Offset = "0x8F2F050", VA = "0x188F2FE50", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> WLIYPXTYRMA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x8F2FE50", Offset = "0x8F2F050", VA = "0x188F2FE50", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly DIBJWOXKFQX JUUCCYCYTKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly List<KKUVUMIVIJA> DEQTWYOVIMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private List<ClusterMeshRenderer> HDQPMHBFNSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private BatchedMeshRenderer VEQEHYPAIZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool EDQUWBVFFPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly bool YKBDJZMOCQY;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IEnumerable<QYOPAQDEOCK> HBRUUDEXOXJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int NYBEKZFSLXN
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8F38B80", Offset = "0x8F37D80", VA = "0x188F38B80", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RRTransform KKSOMQCUUKU
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8F38450", Offset = "0x8F37650", VA = "0x188F38450", Slot = "8")]
			get
			{
				return default(RRTransform);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public List<SkinnedShapeRenderer> NADOJVQMBNR
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xABEC10", Offset = "0xABDE10", VA = "0x180ABEC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8F39540", Offset = "0x8F38740", VA = "0x188F39540")]
		private bool WWWNEUGQSRG(KKUVUMIVIJA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F392B0", Offset = "0x8F384B0", VA = "0x188F392B0")]
		private static bool UOSEMHJMGGQ(KKUVUMIVIJA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8F39B70", Offset = "0x8F38D70", VA = "0x188F39B70")]
		public OEGJZWZFOXW(DIBJWOXKFQX a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8F38650", Offset = "0x8F37850", VA = "0x188F38650", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8F38210", Offset = "0x8F37410", VA = "0x188F38210")]
		public void Add(KKUVUMIVIJA shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8F38C40", Offset = "0x8F37E40", VA = "0x188F38C40")]
		public void Remove(KKUVUMIVIJA shape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8F38DA0", Offset = "0x8F37FA0", VA = "0x188F38DA0", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8F392D0", Offset = "0x8F384D0", VA = "0x188F392D0")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8F388F0", Offset = "0x8F37AF0", VA = "0x188F388F0")]
		private void HGPEKNXQUFA(List<KKUVUMIVIJA> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8F39B10", Offset = "0x8F38D10", VA = "0x188F39B10")]
		private static Material YIGZDOVGKFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8F38840", Offset = "0x8F37A40", VA = "0x188F38840")]
		private void HGPEKNXQUFA(KKUVUMIVIJA a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8F38AB0", Offset = "0x8F37CB0", VA = "0x188F38AB0")]
		private void HWCRJSAMQDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8F39560", Offset = "0x8F38760", VA = "0x188F39560")]
		public void XFZFVWQQGIF(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8F38510", Offset = "0x8F37710", VA = "0x188F38510")]
		protected void CFZJDXJHKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F385D0", Offset = "0x8F377D0", VA = "0x188F385D0")]
		public void CVSMCIDNREL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F38BC0", Offset = "0x8F37DC0", VA = "0x188F38BC0")]
		[IteratorStateMachine(typeof(QXHXRUCLTTO))]
		public IEnumerable<Renderer> QRABWTSXJDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8F38190", Offset = "0x8F37390", VA = "0x188F38190")]
		[IteratorStateMachine(typeof(EBKFEONFMKG))]
		public IEnumerable<Renderer> ANVKFJKUZSP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[BurstCompile]
	internal class JPPHQIMLEUY : KKUVUMIVIJA
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private struct CurveToken : COVNYYGEIDY, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8F2FCC0", Offset = "0x8F2EEC0", VA = "0x188F2FCC0")]
			public CurveToken(NativeMesh mesh, JobHandle jobHandle, CurveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x8F2FC40", Offset = "0x8F2EE40", VA = "0x188F2FC40", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8F2FC70", Offset = "0x8F2EE70", VA = "0x188F2FC70", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal unsafe delegate void CalculateFastCurveBounds_00000039$PostfixBurstDelegate([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints);

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		internal static class SRGNZAYCERI
		{
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static IntPtr EXWIVAKGKCJ;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8F3ADA0", Offset = "0x8F39FA0", VA = "0x188F3ADA0")]
			[BurstDiscard]
			private static void SJMJWHMCWZD(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8F3AC20", Offset = "0x8F39E20", VA = "0x188F3AC20")]
			private static IntPtr NGUJNXDQPEN()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8F3A880", Offset = "0x8F39A80", VA = "0x188F3A880")]
			public unsafe static void Invoke([NoAlias] RRBounds outBounds, int curvePointCount, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		internal readonly CRNVMCMPREK TQTBSCITKGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private float NSUYLMABRZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private Hash128 GWHHIVYTRFJ;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		protected override Hash128 TPLYZGXQTOB
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8F35710", Offset = "0x8F34910", VA = "0x188F35710", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8F35840", Offset = "0x8F34A40", VA = "0x188F35840")]
		public JPPHQIMLEUY(OEGJZWZFOXW a, CRNVMCMPREK b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "18")]
		public override bool TSFLZWJOLHQ(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8F34750", Offset = "0x8F33950", VA = "0x188F34750", Slot = "19")]
		public override int JJOOJCERKLX(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8F35530", Offset = "0x8F34730", VA = "0x188F35530", Slot = "20")]
		public override int VAXEAUBQSJJ(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8F34930", Offset = "0x8F33B30", VA = "0x188F34930", Slot = "21")]
		public override RRBounds LCNCBZTRUCH()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8F35830", Offset = "0x8F34A30", VA = "0x188F35830")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastCurveBounds_00000039$PostfixBurstDelegate))]
		private unsafe static void WXTPOENSZGE([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xB421E0", Offset = "0xB413E0", VA = "0x180B421E0", Slot = "22")]
		public override float PSGJRMNPVPT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8F33F80", Offset = "0x8F33180", VA = "0x188F33F80", Slot = "23")]
		public override void HOLJDKDVABP(SystemLOD a, NXROTKIAFQE b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8F33CC0", Offset = "0x8F32EC0", VA = "0x188F33CC0")]
		private int DAVAWCIJGRW(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8F33EB0", Offset = "0x8F330B0", VA = "0x188F33EB0", Slot = "24")]
		public override RRTransform GEZDDCJFIGQ()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8F35380", Offset = "0x8F34580", VA = "0x188F35380", Slot = "26")]
		public override MaterialInfo UWSJKZYPUBX()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8F34BD0", Offset = "0x8F33DD0", VA = "0x188F34BD0", Slot = "27")]
		public override COVNYYGEIDY NWSQNCUGPIR(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8F34560", Offset = "0x8F33760", VA = "0x188F34560")]
		[BurstCompile]
		internal unsafe static void IXYRERWAAOX([NoAlias] RRBounds outBounds, int a, [In][NoAlias] UniformTRS worldFromLocal, [In][NoAlias] CurvePointData* curvePoints)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface ZXRXHSFXBEZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		OEGJZWZFOXW this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		KKUVUMIVIJA this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		TPZICPQTLGN this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class HSJRKZZOXHA : YLWLCIILLTE, IDisposable, ZXRXHSFXBEZ
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
			public HSJRKZZOXHA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8F3FF50", Offset = "0x8F3F150", VA = "0x188F3FF50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x8F404A0", Offset = "0x8F3F6A0", VA = "0x188F404A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private readonly AHMNDGFWVUP<RootHandle, OEGJZWZFOXW> SUXIDOCHESU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly AHMNDGFWVUP<ShapeHandle, KKUVUMIVIJA> DEQTWYOVIMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private readonly AHMNDGFWVUP<SkinnedCostumeHandle, TPZICPQTLGN> PQIDCCSJBRZ;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public OEGJZWZFOXW this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8F33A00", Offset = "0x8F32C00", VA = "0x188F33A00", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public KKUVUMIVIJA this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x8F33AC0", Offset = "0x8F32CC0", VA = "0x188F33AC0", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public TPZICPQTLGN this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x8F33A60", Offset = "0x8F32C60", VA = "0x188F33A60", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public bool YFLRLTUQTAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xB2D260", Offset = "0xB2C460", VA = "0x180B2D260", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xB2D270", Offset = "0xB2C470", VA = "0x180B2D270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8F335B0", Offset = "0x8F327B0", VA = "0x188F335B0")]
		public HSJRKZZOXHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8F31970", Offset = "0x8F30B70", VA = "0x188F31970", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8F335A0", Offset = "0x8F327A0", VA = "0x188F335A0", Slot = "4")]
		public RootHandle YYQESCTWZHB(DIBJWOXKFQX a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8F33340", Offset = "0x8F32540", VA = "0x188F33340", Slot = "5")]
		public RootHandle YYQESCTWZHB(DIBJWOXKFQX a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8F31DC0", Offset = "0x8F30FC0", VA = "0x188F31DC0", Slot = "6")]
		public void HGGDFJYLGPW(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F32CF0", Offset = "0x8F31EF0", VA = "0x188F32CF0", Slot = "7")]
		public void VIVJQVLUYPX(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8F32760", Offset = "0x8F31960", VA = "0x188F32760", Slot = "8")]
		public ShapeHandle TOVEDWFZDAY(RootHandle a, YPZMSKMMKIE b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8F322B0", Offset = "0x8F314B0", VA = "0x188F322B0", Slot = "9")]
		public ShapeHandle SRQHGWFORFQ(RootHandle a, CRNVMCMPREK b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8F315E0", Offset = "0x8F307E0", VA = "0x188F315E0", Slot = "11")]
		public void BLJRUYCSNHU(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8F33080", Offset = "0x8F32280", VA = "0x188F33080", Slot = "10")]
		public void VVAGJPQRHXX(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8F32010", Offset = "0x8F31210", VA = "0x188F32010", Slot = "20")]
		public IEnumerable<Renderer> JHAHSQULRCC(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8F32230", Offset = "0x8F31430", VA = "0x188F32230", Slot = "12")]
		public SkinnedCostumeHandle PWKSRGJSOXA(DHTRMRENJQZ a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8F332D0", Offset = "0x8F324D0", VA = "0x188F332D0", Slot = "14")]
		public void XDBSFUHCYLJ(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8F31C00", Offset = "0x8F30E00", VA = "0x188F31C00", Slot = "16")]
		public Task GHQYYSXGNLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8F32080", Offset = "0x8F31280", VA = "0x188F32080", Slot = "17")]
		public Task KJMNUZXUPAX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8F31B30", Offset = "0x8F30D30", VA = "0x188F31B30", Slot = "18")]
		[AsyncStateMachine(typeof(<EndRoomLoad>d__28))]
		public Task GGHGBVXZTES()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8F32C00", Offset = "0x8F31E00", VA = "0x188F32C00", Slot = "19")]
		public void UPBMWRKKZIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F33020", Offset = "0x8F32220", VA = "0x188F33020", Slot = "13")]
		public void VLQOPLOSVXM(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[BurstCompile]
	internal class JPQCUJGLSLQ : KKUVUMIVIJA
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct PrimitiveToken : COVNYYGEIDY, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x8F39D60", Offset = "0x8F38F60", VA = "0x188F39D60")]
			public PrimitiveToken(NativeMesh mesh, NativeArray<int> vertCollapseTarget, JobHandle jobHandle, PrimitiveMeshGeneratorData genData)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8F39C60", Offset = "0x8F38E60", VA = "0x188F39C60", Slot = "4")]
			public NativeMesh Complete()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8F39CC0", Offset = "0x8F38EC0", VA = "0x188F39CC0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		internal delegate void CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS);

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		internal static class UROEZGHYMKO
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private static IntPtr EXWIVAKGKCJ;

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8F40F90", Offset = "0x8F40190", VA = "0x188F40F90")]
			[BurstDiscard]
			private static void SJMJWHMCWZD(IntPtr a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8F40E10", Offset = "0x8F40010", VA = "0x188F40E10")]
			private static IntPtr NGUJNXDQPEN()
			{
				return default(IntPtr);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8F40C00", Offset = "0x8F3FE00", VA = "0x188F40C00")]
			public static void Invoke([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly YPZMSKMMKIE KHVUALCSJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int[] AUGKBSKWRJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Hash128 GWHHIVYTRFJ;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private Vector3 BRDNIGZHGHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8F36640", Offset = "0x8F35840", VA = "0x188F36640")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		protected override Hash128 TPLYZGXQTOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x8F37C40", Offset = "0x8F36E40", VA = "0x188F37C40", Slot = "25")]
			get
			{
				return default(Hash128);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8F37D60", Offset = "0x8F36F60", VA = "0x188F37D60")]
		public JPQCUJGLSLQ(OEGJZWZFOXW a, YPZMSKMMKIE b, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8F37690", Offset = "0x8F36890", VA = "0x188F37690", Slot = "18")]
		public override bool TSFLZWJOLHQ(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8F36BC0", Offset = "0x8F35DC0", VA = "0x188F36BC0", Slot = "21")]
		public override RRBounds LCNCBZTRUCH()
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8F36870", Offset = "0x8F35A70", VA = "0x188F36870")]
		private RRBounds LCNCBZTRUCH(RRTransform a)
		{
			return default(RRBounds);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8F36C00", Offset = "0x8F35E00", VA = "0x188F36C00")]
		[BurstCompile]
		[MonoPInvokeCallback(typeof(RecRoom.ShapeRendering.CalculateFastPrimitiveBounds_00000060$PostfixBurstDelegate))]
		private static void NMGIHSTZIVU([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x8F37490", Offset = "0x8F36690", VA = "0x188F37490")]
		private OcclusionData QFSPSBDEMLT([In] UniformTRS worldFromLocalUniformTRS, [In] float3 worldScale)
		{
			return default(OcclusionData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F36590", Offset = "0x8F35790", VA = "0x188F36590", Slot = "19")]
		public override int JJOOJCERKLX(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x8F37910", Offset = "0x8F36B10", VA = "0x188F37910", Slot = "20")]
		public override int VAXEAUBQSJJ(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8F373A0", Offset = "0x8F365A0", VA = "0x188F373A0", Slot = "22")]
		public override float PSGJRMNPVPT()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8F379C0", Offset = "0x8F36BC0", VA = "0x188F379C0")]
		private int VNRZPAYMRJD(SystemLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8F35D50", Offset = "0x8F34F50", VA = "0x188F35D50", Slot = "23")]
		public override void HOLJDKDVABP(SystemLOD a, NXROTKIAFQE b, int c = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8F358F0", Offset = "0x8F34AF0", VA = "0x188F358F0", Slot = "24")]
		public override RRTransform GEZDDCJFIGQ()
		{
			return default(RRTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8F37760", Offset = "0x8F36960", VA = "0x188F37760", Slot = "26")]
		public override MaterialInfo UWSJKZYPUBX()
		{
			return default(MaterialInfo);
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8F36C10", Offset = "0x8F35E10", VA = "0x188F36C10", Slot = "27")]
		public override COVNYYGEIDY NWSQNCUGPIR(SystemLOD a, JobHandle b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x8F359C0", Offset = "0x8F34BC0", VA = "0x188F359C0")]
		[BurstCompile]
		internal static void GJSUNZZWNOF([NoAlias] RRBounds outBounds, [In] float3 deformationRatio, [In][NoAlias] Bounds meshBounds, [In][NoAlias] UniformTRS rootFromLocalTRS)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface NNWGUUYMYYQ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JUHJYKTHIDJ(SelectionEffectType a, Renderer b, int c);

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void VSLSPXJELUI(Renderer a, IgnoreEffectType b, Vector3 c, Vector3 d, Vector3 e, float f, float g, float h = -1f, [Optional] Color? i, [Optional] IReadOnlyList<Camera> j);

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WUQKKLMDEJR(Renderer a, int b);

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int RUQGKTLOIWO();

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void DXUVWTSUFRZ(int a, OutlineEffectType b, Renderer c, int d);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class VLYIQNVXPZZ : VABGMBEORDW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private class KQOHDZZXDQU : YBKMXZBDOWR<int>
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x8F38000", Offset = "0x8F37200", VA = "0x188F38000")]
			public KQOHDZZXDQU(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private readonly NNWGUUYMYYQ BUETLMJRTZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private readonly ZXRXHSFXBEZ MKUEJRKDEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private MeshRenderer PWMAWLOFWMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private KQOHDZZXDQU GJTGCLSYVXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private bool AOINNMTHKLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private MeshRenderer ADSCIFTZQKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private KQOHDZZXDQU VOCJKGCZRLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private bool FGLVCUAWKWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private MeshRenderer FUZFPFJYTYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private KQOHDZZXDQU FPJPHHVTXIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private bool INNPNZFROUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x61")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private bool WCTMPOAJLBF;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xAC0F90", Offset = "0xAC0190", VA = "0x180AC0F90")]
		public VLYIQNVXPZZ(NNWGUUYMYYQ a, ZXRXHSFXBEZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8F41510", Offset = "0x8F40710", VA = "0x188F41510", Slot = "23")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8F42F80", Offset = "0x8F42180", VA = "0x188F42F80")]
		private void TOQPLVIAGYZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8F42A50", Offset = "0x8F41C50", VA = "0x188F42A50", Slot = "4")]
		public void TCETIUXCXDM(RootHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8F42D60", Offset = "0x8F41F60", VA = "0x188F42D60", Slot = "5")]
		public void TCETIUXCXDM(ShapeHandle a, OutlineEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8F419F0", Offset = "0x8F40BF0", VA = "0x188F419F0", Slot = "6")]
		public void GPEXYPYINLM(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x8F42710", Offset = "0x8F41910", VA = "0x188F42710", Slot = "7")]
		public void POHJVXZNDGU(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8F41120", Offset = "0x8F40320", VA = "0x188F41120", Slot = "24")]
		public void AELEHLJZFQN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x1203010", Offset = "0x1202210", VA = "0x181203010", Slot = "8")]
		public void CRKJHWTLUPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x8F438D0", Offset = "0x8F42AD0", VA = "0x188F438D0", Slot = "9")]
		public void ZOUJIWZDPEQ(OutlineEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x8F43530", Offset = "0x8F42730", VA = "0x188F43530", Slot = "10")]
		public void WKIZTNUPGUP(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x8F431E0", Offset = "0x8F423E0", VA = "0x188F431E0", Slot = "11")]
		public void WKIZTNUPGUP(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8F41440", Offset = "0x8F40640", VA = "0x188F41440", Slot = "12")]
		public void CLBPJBAJDFI(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8F42860", Offset = "0x8F41A60", VA = "0x188F42860", Slot = "13")]
		public void QNOFELWXMPG(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C80", Offset = "0x8F40E80", VA = "0x188F41C80")]
		private void JLIENEPRPPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x167BC50", Offset = "0x167AE50", VA = "0x18167BC50", Slot = "14")]
		public void EERHVWYIIJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x8F42930", Offset = "0x8F41B30", VA = "0x188F42930", Slot = "15")]
		public void QOUUGSTEERC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x8F41160", Offset = "0x8F40360", VA = "0x188F41160", Slot = "16")]
		public void AMUYFPYEIVU(RootHandle a, SelectionEffectType b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8F416C0", Offset = "0x8F408C0", VA = "0x188F416C0", Slot = "17")]
		public void EVSOCBTSWTY(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x8F43800", Offset = "0x8F42A00", VA = "0x188F43800", Slot = "18")]
		public void XWACRVMHEXO(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0xCB31D0", Offset = "0xCB23D0", VA = "0x180CB31D0", Slot = "19")]
		public void DKZVWJWTUTO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8F41B50", Offset = "0x8F40D50", VA = "0x188F41B50", Slot = "20")]
		public void HFJXISBCFNO(SelectionEffectType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8F41790", Offset = "0x8F40990", VA = "0x188F41790")]
		private void FKMYNRWMVSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x8F42350", Offset = "0x8F41550", VA = "0x188F42350", Slot = "21")]
		public void MKPUHDDNWMU(RootHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f, IReadOnlyList<Camera> g, IgnoreEffectType h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8F41EE0", Offset = "0x8F410E0", VA = "0x188F41EE0", Slot = "22")]
		public void MKPUHDDNWMU(SkinnedCostumeHandle a, Vector3 b, Vector3 c, Vector3 d, float e, float f)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public abstract class KKUVUMIVIJA : ENGYMDZCYUJ, QYOPAQDEOCK, FHGEEIWNDXW, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public readonly OEGJZWZFOXW YEFNNEOPVAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		private int VSLMXBNYPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		protected Bounds ODCMKTOUQLK;

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Bounds UFSXILVHLNC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x8F37FB0", Offset = "0x8F371B0", VA = "0x188F37FB0", Slot = "4")]
			get
			{
				return default(Bounds);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool YKBDJZMOCQY
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xCB6200", Offset = "0xCB5400", VA = "0x180CB6200")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0xCB6220", Offset = "0xCB5420", VA = "0x180CB6220")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		protected abstract Hash128 TPLYZGXQTOB
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(Slot = "25")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int OTPYSUHSYEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0xBE8350", Offset = "0xBE7550", VA = "0x180BE8350", Slot = "11")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public BAIGSCMJKOR ZCELXMONRFU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0xABEC10", Offset = "0xABDE10", VA = "0x180ABEC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GIBBLDUZEVS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x1880780", Offset = "0x187F980", VA = "0x181880780")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xABCFC0", Offset = "0xABC1C0", VA = "0x180ABCFC0")]
		protected KKUVUMIVIJA(OEGJZWZFOXW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x8F37E10", Offset = "0x8F37010", VA = "0x188F37E10", Slot = "17")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "18")]
		public virtual bool TSFLZWJOLHQ(RRTransform a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8F37FA0", Offset = "0x8F371A0", VA = "0x188F37FA0", Slot = "10")]
		public int OJHFPKEBHCP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract int JJOOJCERKLX(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract int VAXEAUBQSJJ(SystemLOD a);

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(Slot = "21")]
		public abstract RRBounds LCNCBZTRUCH();

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "22")]
		public abstract float PSGJRMNPVPT();

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "23")]
		public abstract void HOLJDKDVABP(SystemLOD a, NXROTKIAFQE b, int c = -1);

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "24")]
		public abstract RRTransform GEZDDCJFIGQ();

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x8F37FD0", Offset = "0x8F371D0", VA = "0x188F37FD0", Slot = "13")]
		public Hash128 SILQMTLYHIM(int a)
		{
			return default(Hash128);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "26")]
		public abstract MaterialInfo UWSJKZYPUBX();

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "27")]
		public abstract COVNYYGEIDY NWSQNCUGPIR(SystemLOD a, JobHandle b);

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8F37F70", Offset = "0x8F37170", VA = "0x188F37F70", Slot = "12")]
		public COVNYYGEIDY HONCKZCAYMG(int a)
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
		[Cpp2IlInjected.Address(RVA = "0x8F3B330", Offset = "0x8F3A530", VA = "0x188F3B330")]
		public ShapeRendererConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class ShapeRendererSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class JAOTTDILGWV : IEnumerable<IIDHTZITABV>, IEnumerable, IEnumerator<IIDHTZITABV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private IIDHTZITABV HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int AEVHPULYWGH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int MDNJMWGFBMQ;

			[Cpp2IlInjected.Token(Token = "0x17000023")]
			private IIDHTZITABV UHQMPLQKNIZ
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000024")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public JAOTTDILGWV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x8F33BB0", Offset = "0x8F32DB0", VA = "0x188F33BB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x8F33C80", Offset = "0x8F32E80", VA = "0x188F33C80", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x8F33B20", Offset = "0x8F32D20", VA = "0x188F33B20", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<IIDHTZITABV> VVATFKPNPEC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x8F33B20", Offset = "0x8F32D20", VA = "0x188F33B20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IIDHTZITABV[][] SNAMZPJIXVZ;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static YYSQMCGUKJK CXBYBDBSZWZ;

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public static ShapeRendererConfig UKIVWIIHBUK;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public static ComputeShader KJXFEBVKSUM
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x8F3DC80", Offset = "0x8F3CE80", VA = "0x188F3DC80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public static SkinnedShapeRenderer SWNCUVTWGYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x8F3CD70", Offset = "0x8F3BF70", VA = "0x188F3CD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x8F3CA80", Offset = "0x8F3BC80", VA = "0x188F3CA80")]
		[RRRuntimeInitializeMethod]
		internal static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x8F3C7D0", Offset = "0x8F3B9D0", VA = "0x188F3C7D0")]
		public static Mesh DMQFOSWNIJO(PrimitiveShapeMeshType a, int b = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x8F3C870", Offset = "0x8F3BA70", VA = "0x188F3C870")]
		public static int EJIARRQPYAH(PrimitiveShapeMeshType a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8F3C880", Offset = "0x8F3BA80", VA = "0x188F3C880")]
		public static YYSQMCGUKJK HSBQNKBUIXC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8F3CD10", Offset = "0x8F3BF10", VA = "0x188F3CD10")]
		[IteratorStateMachine(typeof(JAOTTDILGWV))]
		private static IEnumerable<IIDHTZITABV> QRPABRHGQZG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8F3CDF0", Offset = "0x8F3BFF0", VA = "0x188F3CDF0")]
		public static IIDHTZITABV XVWKCTNUQSZ(PrimitiveShapeMeshType a, int b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8F3CDD0", Offset = "0x8F3BFD0", VA = "0x188F3CDD0")]
		public static bool SRAAGJBZTSR(this PrimitiveShapeMeshType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8F3CB60", Offset = "0x8F3BD60", VA = "0x188F3CB60")]
		public static void NDZQUMQYBUT(PrimitiveShapeMeshType a, float3 b, [Out] BevelScalingMode c, [Out] float3 d, [Out] float e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8F3C260", Offset = "0x8F3B460", VA = "0x188F3C260")]
		public static void BGVMFAVJQCA(Vector3 a, PrimitiveShapeMeshType b, [Out] Vector3 c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8F3C250", Offset = "0x8F3B450", VA = "0x188F3C250")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void BEPJGTOOUXU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x8F3C610", Offset = "0x8F3B810", VA = "0x188F3C610")]
		[RRPostPlayModeMethod(PostPlayModePhase.ExitingPlayMode, 0)]
		[RRBeforeAssemblyReloadMethod(0)]
		private static void CFPUPOLONOW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ShapeRendererManager : YLWLCIILLTE, IDisposable, ZXRXHSFXBEZ
	{
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly AHMNDGFWVUP<RootHandle, OEGJZWZFOXW> SUXIDOCHESU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly AHMNDGFWVUP<ShapeHandle, KKUVUMIVIJA> DEQTWYOVIMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly AHMNDGFWVUP<SkinnedCostumeHandle, TPZICPQTLGN> PQIDCCSJBRZ;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public OEGJZWZFOXW this[RootHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x8F3C1F0", Offset = "0x8F3B3F0", VA = "0x188F3C1F0", Slot = "22")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public KKUVUMIVIJA this[ShapeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x8F3C190", Offset = "0x8F3B390", VA = "0x188F3C190", Slot = "23")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public TPZICPQTLGN this[SkinnedCostumeHandle handle]
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x8F3C130", Offset = "0x8F3B330", VA = "0x188F3C130", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool YFLRLTUQTAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xB2D260", Offset = "0xB2C460", VA = "0x180B2D260", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xB2D270", Offset = "0xB2C470", VA = "0x180B2D270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x8F3BDA0", Offset = "0x8F3AFA0", VA = "0x188F3BDA0")]
		public ShapeRendererManager()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B420", Offset = "0x8F3A620", VA = "0x188F3B420", Slot = "21")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8F3BC10", Offset = "0x8F3AE10", VA = "0x188F3BC10", Slot = "4")]
		public RootHandle YYQESCTWZHB(DIBJWOXKFQX a)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8F3BC10", Offset = "0x8F3AE10", VA = "0x188F3BC10", Slot = "5")]
		public RootHandle YYQESCTWZHB(DIBJWOXKFQX a, bool b)
		{
			return default(RootHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B5F0", Offset = "0x8F3A7F0", VA = "0x188F3B5F0", Slot = "6")]
		public void HGGDFJYLGPW(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x8F3BA60", Offset = "0x8F3AC60", VA = "0x188F3BA60", Slot = "7")]
		public void VIVJQVLUYPX(RootHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B920", Offset = "0x8F3AB20", VA = "0x188F3B920", Slot = "8")]
		public ShapeHandle TOVEDWFZDAY(RootHandle a, YPZMSKMMKIE b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B7E0", Offset = "0x8F3A9E0", VA = "0x188F3B7E0", Slot = "9")]
		public ShapeHandle SRQHGWFORFQ(RootHandle a, CRNVMCMPREK b)
		{
			return default(ShapeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B390", Offset = "0x8F3A590", VA = "0x188F3B390", Slot = "11")]
		public void BLJRUYCSNHU(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8F3BB40", Offset = "0x8F3AD40", VA = "0x188F3BB40", Slot = "10")]
		public void VVAGJPQRHXX(ShapeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B650", Offset = "0x8F3A850", VA = "0x188F3B650", Slot = "20")]
		public IEnumerable<Renderer> JHAHSQULRCC(RootHandle a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B760", Offset = "0x8F3A960", VA = "0x188F3B760", Slot = "12")]
		public SkinnedCostumeHandle PWKSRGJSOXA(DHTRMRENJQZ a)
		{
			return default(SkinnedCostumeHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x8F3BBA0", Offset = "0x8F3ADA0", VA = "0x188F3BBA0", Slot = "14")]
		public void XDBSFUHCYLJ(SkinnedCostumeHandle a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B550", Offset = "0x8F3A750", VA = "0x188F3B550", Slot = "16")]
		public Task GHQYYSXGNLP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B6C0", Offset = "0x8F3A8C0", VA = "0x188F3B6C0", Slot = "17")]
		public Task KJMNUZXUPAX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B4B0", Offset = "0x8F3A6B0", VA = "0x188F3B4B0", Slot = "18")]
		public Task GGHGBVXZTES()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x167AF80", Offset = "0x167A180", VA = "0x18167AF80", Slot = "19")]
		public void UPBMWRKKZIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x8F3BAE0", Offset = "0x8F3ACE0", VA = "0x188F3BAE0", Slot = "13")]
		public void VLQOPLOSVXM(SkinnedCostumeHandle a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public interface JGVWDJBCGLY
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		bool WKQKKIAZKOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Material WGPHOBRHXJW();

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Material YIGZDOVGKFO();

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Material EMRIDILVLKW();

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		int PEWBGIBUAPH(ShapeColor a);

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		int VZTZJQGDDCH(ShapeMaterial a);

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void RSSEYLDESVX(GameObject a);

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "7")]
		void XEQLNZFRELY(GameObject a, bool b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class SYWAJEDBKLR
	{
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private static JGVWDJBCGLY LPFPSWARXTI;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static bool WKQKKIAZKOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x8F3AFE0", Offset = "0x8F3A1E0", VA = "0x188F3AFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x8F3AF90", Offset = "0x8F3A190", VA = "0x188F3AF90")]
		public static void GPOYQGLBFBL(JGVWDJBCGLY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B1F0", Offset = "0x8F3A3F0", VA = "0x188F3B1F0")]
		public static Material WGPHOBRHXJW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x8F39B10", Offset = "0x8F38D10", VA = "0x188F39B10")]
		public static Material YIGZDOVGKFO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x8F3AF30", Offset = "0x8F3A130", VA = "0x188F3AF30")]
		public static Material EMRIDILVLKW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B040", Offset = "0x8F3A240", VA = "0x188F3B040")]
		public static int PEWBGIBUAPH(ShapeColor a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B180", Offset = "0x8F3A380", VA = "0x188F3B180")]
		public static int VZTZJQGDDCH(ShapeMaterial a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B0B0", Offset = "0x8F3A2B0", VA = "0x188F3B0B0")]
		public static void RSSEYLDESVX(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8F3B250", Offset = "0x8F3A450", VA = "0x188F3B250")]
		public static void XEQLNZFRELY(GameObject a, bool b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class TPZICPQTLGN : SMOTOSVMBZR
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class XHWXOGVPRQH : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			private int HDIOWKWRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private Renderer HVLGGEUBMPZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private int SQEAAJZHTMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public TPZICPQTLGN LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400007E")]
			private List<SkinnedShapeRenderer>.Enumerator XORIMGFAPUY;

			[Cpp2IlInjected.Token(Token = "0x1700002B")]
			private Renderer CWWIMCMCSZN
			{
				[Cpp2IlInjected.Token(Token = "0x6000127")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700002C")]
			private object CVJXXTOQWTE
			{
				[Cpp2IlInjected.Token(Token = "0x6000129")]
				[Cpp2IlInjected.Address(RVA = "0xABA450", Offset = "0xAB9650", VA = "0x180ABA450", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xDC8510", Offset = "0xDC7710", VA = "0x180DC8510")]
			[DebuggerHidden]
			public XHWXOGVPRQH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0x8F43A40", Offset = "0x8F42C40", VA = "0x188F43A40", Slot = "7")]
			[DebuggerHidden]
			private void JZSTYLGWFSV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x8F43B70", Offset = "0x8F42D70", VA = "0x188F43B70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x8F43D90", Offset = "0x8F42F90", VA = "0x188F43D90")]
			private void RKOKQQOFJWR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x8F43DE0", Offset = "0x8F42FE0", VA = "0x188F43DE0", Slot = "10")]
			[DebuggerHidden]
			private void ZJSIHLTIANO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600012A")]
			[Cpp2IlInjected.Address(RVA = "0x8F43AD0", Offset = "0x8F42CD0", VA = "0x188F43AD0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<Renderer> WLIYPXTYRMA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600012B")]
			[Cpp2IlInjected.Address(RVA = "0x8F43AD0", Offset = "0x8F42CD0", VA = "0x188F43AD0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator KRQKAOMZCCF()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly DHTRMRENJQZ SPPLRDGVQBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly ZXRXHSFXBEZ MKUEJRKDEPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private ClusterLODSkinnedRenderer FGSZNLXOMCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private List<GFBRMNPTITW> LGGKNPCZZUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private List<GFBRMNPTITW> KOCEXRGYXGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private GameObject XLADZOKUAEI;

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x8F3F030", Offset = "0x8F3E230", VA = "0x188F3F030")]
		public static TPZICPQTLGN QZWBCNMCYTP(DHTRMRENJQZ a, ZXRXHSFXBEZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3FE30", Offset = "0x8F3F030", VA = "0x188F3FE30")]
		private TPZICPQTLGN(DHTRMRENJQZ a, ZXRXHSFXBEZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB30", Offset = "0x8F3DD30", VA = "0x188F3EB30")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EFB0", Offset = "0x8F3E1B0", VA = "0x188F3EFB0")]
		[IteratorStateMachine(typeof(XHWXOGVPRQH))]
		public IEnumerable<Renderer> QRABWTSXJDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8F3F170", Offset = "0x8F3E370", VA = "0x188F3F170", Slot = "4")]
		public void SetupClusterLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB00", Offset = "0x8F3DD00", VA = "0x188F3EB00")]
		private void AWQLLRLBBCI(Vector3 a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8F3FBE0", Offset = "0x8F3EDE0", VA = "0x188F3FBE0")]
		public void Update()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class GFBRMNPTITW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		private struct BoneMeshInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public NXROTKIAFQE Generator;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public RRTransform BoneTransform;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public int BoneIndex;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class RTZKRWAPXNJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public GFBRMNPTITW LQBDIDDTHZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int YRITAJKVDTK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public int VKFVTTRPUTD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public SystemLOD JXAFPHHLEAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public List<BoneMeshInfo> ZEROCGUOTGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public NativeMesh XGDEBDQBOKK;

			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public RTZKRWAPXNJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x8F3A7F0", Offset = "0x8F399F0", VA = "0x188F3A7F0")]
			internal JobHandle FQHMAMHPQLA()
			{
				return default(JobHandle);
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x8F3A850", Offset = "0x8F39A50", VA = "0x188F3A850")]
			internal void FQMSXTBMZWJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x8F3A680", Offset = "0x8F39880", VA = "0x188F3A680")]
			internal void FPWYFYTUXOI()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int[] SLOKHTZLQPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private XTYJPWRJUGO HGIZDLWASPE;

		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private static Matrix4x4 EIGLJWEAVMC;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Mesh EOGPRLIWWNX
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(RVA = "0xABA430", Offset = "0xAB9630", VA = "0x180ABA430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int ELSFXMNYHZL
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0xAB92E0", Offset = "0xAB84E0", VA = "0x180AB92E0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xABB640", Offset = "0xABA840", VA = "0x180ABB640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8F30E80", Offset = "0x8F30080", VA = "0x188F30E80")]
		public void KTXMTWFXAQE(List<RRTransform> a, Matrix4x4[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8F30420", Offset = "0x8F2F620", VA = "0x188F30420")]
		public static List<GFBRMNPTITW> Create(List<OEGJZWZFOXW> collections, SystemLOD lod, Bounds bounds)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8F30A80", Offset = "0x8F2FC80", VA = "0x188F30A80")]
		private JobHandle DIIURRIAJEP(NativeMesh a, int b, int c, SystemLOD d, List<BoneMeshInfo> e)
		{
			return default(JobHandle);
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8F30340", Offset = "0x8F2F540", VA = "0x188F30340")]
		private void BXMLJTRSMDN(List<BoneMeshInfo> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8F311F0", Offset = "0x8F303F0", VA = "0x188F311F0")]
		private GFBRMNPTITW(List<BoneMeshInfo> a, int b, int c, SystemLOD d, Bounds e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8F30DE0", Offset = "0x8F2FFE0", VA = "0x188F30DE0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class SkinnedShapeRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MaterialPropertyBlock ASHQZLXRHHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private GFBRMNPTITW PYZSUPBLCMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private List<RRTransform> OIRNTHLSZTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private RenderTexture PVBFZZHRCWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private ComputeBuffer NRAXBZSCRYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private ComputeShader XAGSNOISMTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private Matrix4x4[] BNYNAPAXIWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private int NMHHLSEZIWT;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public MeshRenderer RKBKPQQRRCC
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0xAB8160", Offset = "0xAB7360", VA = "0x180AB8160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public int XTRLYCDPTDR
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8F3EAC0", Offset = "0x8F3DCC0", VA = "0x188F3EAC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8F3DDD0", Offset = "0x8F3CFD0", VA = "0x188F3DDD0")]
		public static List<SkinnedShapeRenderer> Create(GameObject root, List<GFBRMNPTITW> meshes, List<RRTransform> bones, Material material)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8F3E180", Offset = "0x8F3D380", VA = "0x188F3E180")]
		public void Init(GFBRMNPTITW mesh, List<RRTransform> bones, Material material)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EA30", Offset = "0x8F3DC30", VA = "0x188F3EA30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8F3E9A0", Offset = "0x8F3DBA0", VA = "0x188F3E9A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8F3E960", Offset = "0x8F3DB60", VA = "0x188F3E960")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8F3E0C0", Offset = "0x8F3D2C0", VA = "0x188F3E0C0")]
		private void IZIYJPHAUGI(ScriptableRenderContext a, Camera[] b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8F3E5F0", Offset = "0x8F3D7F0", VA = "0x188F3E5F0")]
		private void KTXMTWFXAQE(CommandBuffer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0xAB6170", Offset = "0xAB5370", VA = "0x180AB6170")]
		public SkinnedShapeRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x8F3FF10", Offset = "0x8F3F110", VA = "0x188F3FF10")]
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
