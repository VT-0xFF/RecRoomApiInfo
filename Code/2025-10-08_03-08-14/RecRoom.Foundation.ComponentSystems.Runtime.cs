using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MUPXUODILAN
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
	public MUPXUODILAN()
	{
	}
}
namespace RecRoom.Foundation.ComponentSystems
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class NCUNXKORKMY : KEJQJNZDBNS
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x858F480", Offset = "0x858E280", VA = "0x18858F480", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract ComponentSystemBase UUTQWMVDQUH();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x858F3C0", Offset = "0x858E1C0", VA = "0x18858F3C0")]
		protected KEJQJNZDBNS Group(params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x858F430", Offset = "0x858E230", VA = "0x18858F430")]
		protected KEJQJNZDBNS Group(string name, params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF2D0", Offset = "0x3ACE0D0", VA = "0x183ACF2D0")]
		protected KEJQJNZDBNS Group<T>(params ComponentSystemBase[] systems) where T : KEJQJNZDBNS, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF270", Offset = "0x3ACE070", VA = "0x183ACF270")]
		protected b DVCMWUUJUKR<b>() where b : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3ACF3D0", Offset = "0x3ACE1D0", VA = "0x183ACF3D0")]
		protected c JLNLFTPYXCM<c>() where c : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x858F3B0", Offset = "0x858E1B0", VA = "0x18858F3B0")]
		[Preserve]
		protected NCUNXKORKMY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class IHCEXXDDTIQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface CRBWQEVUHJO
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class KEJQJNZDBNS : QNNMQQNSZUG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x858F380", Offset = "0x858E180", VA = "0x18858F380", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x858F3B0", Offset = "0x858E1B0", VA = "0x18858F3B0")]
		[Preserve]
		public KEJQJNZDBNS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class QNNMQQNSZUG : ComponentSystemGroup, CRBWQEVUHJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x858F3B0", Offset = "0x858E1B0", VA = "0x18858F3B0")]
		[Preserve]
		protected QNNMQQNSZUG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[SourceGenerate]
	[DebuggerTypeProxy(typeof(PNEKXYKWWVQ))]
	public abstract class PMIIJMLQMDK : SystemBase, CRBWQEVUHJO
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public struct System
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct Managed
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct Unmanaged
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public struct Group : IEnumerable<System>, IEnumerable
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x858F330", Offset = "0x858E130", VA = "0x18858F330", Slot = "4")]
			public IEnumerator<System> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x858F370", Offset = "0x858E170", VA = "0x18858F370", Slot = "5")]
			private IEnumerator UYQUPSIMXFE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		internal ComponentSystemBase[] STABWBOMYVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal UnsafeList<SystemHandle> GNPVRMFGJDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal UnsafeList<Unity.Entities.UpdateIndex> SMHXKUQLLFT;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool DMLJVVXZHSZ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB45FE0", Offset = "0xB44DE0", VA = "0x180B45FE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB45FD0", Offset = "0xB44DD0", VA = "0x180B45FD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ComponentSystemGroup IGSJTJYCBZZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAC3430", Offset = "0xAC2230", VA = "0x180AC3430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x858FBA0", Offset = "0x858E9A0", VA = "0x18858FBA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x858F720", Offset = "0x858E520", VA = "0x18858F720", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x858F750", Offset = "0x858E550", VA = "0x18858F750", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x858F7C0", Offset = "0x858E5C0", VA = "0x18858F7C0", Slot = "13")]
		[Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "6")]
		[Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "7")]
		[Preserve]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x858F690", Offset = "0x858E490", VA = "0x18858F690")]
		private void KUCBRWFUBBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x858F530", Offset = "0x858E330", VA = "0x18858F530")]
		protected void DNBEZIJWMRH(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x858FC50", Offset = "0x858EA50", VA = "0x18858FC50", Slot = "14")]
		protected virtual void UUTQWMVDQUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x858F4E0", Offset = "0x858E2E0", VA = "0x18858F4E0", Slot = "15")]
		protected virtual void ARRICNHCCZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F970", Offset = "0x3B1E770", VA = "0x183B1F970")]
		protected a WJKKONDUEET<a>(int a, int b, a c) where a : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F480", Offset = "0x3B1E280", VA = "0x183B1F480")]
		protected b ILVHRQPDQJD<b>(int a, int b) where b : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F690", Offset = "0x3B1E490", VA = "0x183B1F690")]
		protected void NXCLDFGNVMI<T>(int a, int b) where T : struct, ISystem
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		protected void AKDVRYBRPEP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		protected void CBCWKIUGCMH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3B1F780", Offset = "0x3B1E580", VA = "0x183B1F780")]
		public bool PIDUWUAZWFB<c>(int a, c b) where c : ComponentSystemBase
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x858F860", Offset = "0x858E660", VA = "0x18858F860")]
		public bool SOTZFASATGO(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2DBDFE0", Offset = "0x2DBCDE0", VA = "0x182DBDFE0")]
		[Preserve]
		protected PMIIJMLQMDK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class PNEKXYKWWVQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct FinalVersionData<T> : IDisposable where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private VersionData<T> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public VersionData<T> SEVTCHVEQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x12B3B60", Offset = "0x12B2960", VA = "0x1812B3B60")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x508B130", Offset = "0x5089F30", VA = "0x18508B130")]
		public FinalVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x50892B0", Offset = "0x50880B0", VA = "0x1850892B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FinalVersionInfo<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private VersionInfo<T> version;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x508BDE0", Offset = "0x508ABE0", VA = "0x18508BDE0")]
		public FinalVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x508B780", Offset = "0x508A580", VA = "0x18508B780")]
		public FinalVersionData<T> XSYINWZHIUE()
		{
			return default(FinalVersionData<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct IntermediateVersionData<T> : IDisposable where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private VersionData<T> version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private EntityCommandBuffer ecb;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public VersionData<T> SEVTCHVEQAZ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x12B3B60", Offset = "0x12B2960", VA = "0x1812B3B60")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x508B130", Offset = "0x5089F30", VA = "0x18508B130")]
		public IntermediateVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5368300", Offset = "0x5367100", VA = "0x185368300")]
		public void MEWNMFWUHDA(VersionInfo<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x53661C0", Offset = "0x5364FC0", VA = "0x1853661C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct IntermediateVersionInfo<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private VersionInfo<T> version;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x508BDE0", Offset = "0x508ABE0", VA = "0x18508BDE0")]
		public IntermediateVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x536A190", Offset = "0x5368F90", VA = "0x18536A190")]
		public IntermediateVersionData<T> KCIIAFJDVBB()
		{
			return default(IntermediateVersionData<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public abstract class RGARHZGRNUY : SystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EntityCommandBufferSystem OIZIABMLFCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private NativeList<EntityQuery> WAHHLQFFKAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private bool ARPLUBXTPWA;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public EntityCommandBufferSystem DUGYHMKFJRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAC0D20", Offset = "0xABFB20", VA = "0x180AC0D20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected bool UMHDIKUBNMU
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7C45840", Offset = "0x7C44640", VA = "0x187C45840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAC0D10", Offset = "0xABFB10", VA = "0x180AC0D10")]
		public void VZAXLHZJQYW(EntityCommandBufferSystem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x858FCA0", Offset = "0x858EAA0", VA = "0x18858FCA0", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x858FD80", Offset = "0x858EB80", VA = "0x18858FD80", Slot = "13")]
		[Preserve]
		protected sealed override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x858FD30", Offset = "0x858EB30", VA = "0x18858FD30", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void GFRUVQMUFPA();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E9B0", Offset = "0x3C2D7B0", VA = "0x183C2E9B0")]
		protected EntityQuery QJWZPUYSZDJ<T>() where T : struct, IComponentData
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E3D0", Offset = "0x3C2D1D0", VA = "0x183C2E3D0")]
		protected IntermediateVersionInfo<T> AMBPGPHTMPO<T>() where T : struct, IComponentData
		{
			return default(IntermediateVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DFF0", Offset = "0x3C2CDF0", VA = "0x183C2DFF0")]
		protected FinalVersionInfo<T> AAQZLJMAZRP<T>() where T : struct, IComponentData
		{
			return default(FinalVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2DBDFE0", Offset = "0x2DBCDE0", VA = "0x182DBDFE0")]
		[Preserve]
		protected RGARHZGRNUY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public struct VersionData<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public NativeList<Entity> entities;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public NativeList<T> data;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int UFYFSTWLMQP
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x68AC280", Offset = "0x68AB080", VA = "0x1868AC280")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public (Entity entity, T value) this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x68AEDA0", Offset = "0x68ADBA0", VA = "0x1868AEDA0")]
			get
			{
				return default((Entity, T));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68AAFB0", Offset = "0x68A9DB0", VA = "0x1868AAFB0")]
		public void Add(Entity entity, T value)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public struct VersionInfo<T> where T : struct, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[Unity.Collections.ReadOnly]
		public EntityQueryInJob query;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[Unity.Collections.ReadOnly]
		public EntityTypeHandle entityTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Unity.Collections.ReadOnly]
		public ComponentTypeHandle<T> componentTypeHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[WriteOnly]
		public EntityCommandBuffer ecb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public AllocatorManager.AllocatorHandle allocator;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x68B1AD0", Offset = "0x68B08D0", VA = "0x1868B1AD0")]
		public VersionData<T> XSYINWZHIUE()
		{
			return default(VersionData<T>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal class MQLPYAJJLBV
{
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
