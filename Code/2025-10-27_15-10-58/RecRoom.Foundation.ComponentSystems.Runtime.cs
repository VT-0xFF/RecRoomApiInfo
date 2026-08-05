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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MZHUOFNWOZJ
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
	[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
	public MZHUOFNWOZJ()
	{
	}
}
namespace RecRoom.Foundation.ComponentSystems
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class RIJMFRKDLTA : KITSGIANCNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8721A30", Offset = "0x8720A30", VA = "0x188721A30", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "15")]
		protected abstract ComponentSystemBase EJUJSYNPCCV();

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x87219C0", Offset = "0x87209C0", VA = "0x1887219C0")]
		protected KITSGIANCNE Group(params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8721970", Offset = "0x8720970", VA = "0x188721970")]
		protected KITSGIANCNE Group(string name, params ComponentSystemBase[] systems)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3CBC160", Offset = "0x3CBB160", VA = "0x183CBC160")]
		protected KITSGIANCNE Group<T>(params ComponentSystemBase[] systems) where T : KITSGIANCNE, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3CBC2D0", Offset = "0x3CBB2D0", VA = "0x183CBC2D0")]
		protected b TTMIZEEXMWX<b>() where b : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3CBC330", Offset = "0x3CBB330", VA = "0x183CBC330")]
		protected c VPQLCFSXGOO<c>() where c : ComponentSystemBase, new()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8721060", Offset = "0x8720060", VA = "0x188721060")]
		[Preserve]
		protected RIJMFRKDLTA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class NPCPEWFOTHQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface HOIVCNTBDBM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class KITSGIANCNE : XVXOUSDTWTO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8721030", Offset = "0x8720030", VA = "0x188721030", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8721060", Offset = "0x8720060", VA = "0x188721060")]
		[Preserve]
		public KITSGIANCNE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public abstract class XVXOUSDTWTO : ComponentSystemGroup, HOIVCNTBDBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8721060", Offset = "0x8720060", VA = "0x188721060")]
		[Preserve]
		protected XVXOUSDTWTO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[SourceGenerate]
	[DebuggerTypeProxy(typeof(UORPLIOVXBG))]
	public abstract class NPZFSEZIYDQ : SystemBase, HOIVCNTBDBM
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
			[Cpp2IlInjected.Address(RVA = "0x8720FE0", Offset = "0x871FFE0", VA = "0x188720FE0", Slot = "4")]
			public IEnumerator<System> GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8721020", Offset = "0x8720020", VA = "0x188721020", Slot = "5")]
			private IEnumerator JZJZEHYLQOE()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		internal ComponentSystemBase[] QBCFVYCHNRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		internal UnsafeList<SystemHandle> RYMQUPACGTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		internal UnsafeList<Unity.Entities.UpdateIndex> JQPYKEWQRZR;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool TORRFJEUUWD
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xBE8BA0", Offset = "0xBE7BA0", VA = "0x180BE8BA0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xBE8BE0", Offset = "0xBE7BE0", VA = "0x180BE8BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public ComponentSystemGroup JOFMWEARERP
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xACEE70", Offset = "0xACDE70", VA = "0x180ACEE70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8721780", Offset = "0x8720780", VA = "0x188721780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8721300", Offset = "0x8720300", VA = "0x188721300", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8721330", Offset = "0x8720330", VA = "0x188721330", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x87213A0", Offset = "0x87203A0", VA = "0x1887213A0", Slot = "13")]
		[Preserve]
		protected override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "6")]
		[Preserve]
		protected override void OnStartRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150", Slot = "7")]
		[Preserve]
		protected override void OnStopRunning()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8721070", Offset = "0x8720070", VA = "0x188721070")]
		private void DNWPRTHFLRX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8721150", Offset = "0x8720150", VA = "0x188721150")]
		protected void EXZYOLLIYQD(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8721100", Offset = "0x8720100", VA = "0x188721100", Slot = "14")]
		protected virtual void EJUJSYNPCCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x87212B0", Offset = "0x87202B0", VA = "0x1887212B0", Slot = "15")]
		protected virtual void HYCIUARNIXI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3B51390", Offset = "0x3B50390", VA = "0x183B51390")]
		protected a DBEVIGWBQYF<a>(int a, int b, a c) where a : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B514B0", Offset = "0x3B504B0", VA = "0x183B514B0")]
		protected b ETNBSQUTRCL<b>(int a, int b) where b : ComponentSystemBase
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x3B518B0", Offset = "0x3B508B0", VA = "0x183B518B0")]
		protected void YRLCYYNHRVQ<T>(int a, int b) where T : struct, ISystem
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		protected void WKESIRTVKHH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xACE150", Offset = "0xACD150", VA = "0x180ACE150")]
		protected void MRAVGBVIKAB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3B515D0", Offset = "0x3B505D0", VA = "0x183B515D0")]
		public bool HDBEBOXFJXX<c>(int a, c b) where c : ComponentSystemBase
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8721440", Offset = "0x8720440", VA = "0x188721440")]
		public bool RSQGISUNWXK(int a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2E50040", Offset = "0x2E4F040", VA = "0x182E50040")]
		[Preserve]
		protected NPZFSEZIYDQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	internal sealed class UORPLIOVXBG
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
		public VersionData<T> DVFZSGMWEID
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x137A0E0", Offset = "0x13790E0", VA = "0x18137A0E0")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5109A50", Offset = "0x5108A50", VA = "0x185109A50")]
		public FinalVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5107BD0", Offset = "0x5106BD0", VA = "0x185107BD0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x510A700", Offset = "0x5109700", VA = "0x18510A700")]
		public FinalVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5109A70", Offset = "0x5108A70", VA = "0x185109A70")]
		public FinalVersionData<T> GAAVKUQIGOS()
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
		public VersionData<T> DVFZSGMWEID
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x137A0E0", Offset = "0x13790E0", VA = "0x18137A0E0")]
			get
			{
				return default(VersionData<T>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5109A50", Offset = "0x5108A50", VA = "0x185109A50")]
		public IntermediateVersionData(VersionData<T> version, EntityCommandBuffer ecb)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x53ACB20", Offset = "0x53ABB20", VA = "0x1853ACB20")]
		public void JZGSHQDTJDS(VersionInfo<T> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x53AC7D0", Offset = "0x53AB7D0", VA = "0x1853AC7D0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x510A700", Offset = "0x5109700", VA = "0x18510A700")]
		public IntermediateVersionInfo(VersionInfo<T> version)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x53B19A0", Offset = "0x53B09A0", VA = "0x1853B19A0")]
		public IntermediateVersionData<T> SWFEYLQQKBD()
		{
			return default(IntermediateVersionData<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	public abstract class RCZOELPCTQO : SystemBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private EntityCommandBufferSystem LKKDEBZOKWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private NativeList<EntityQuery> CIHVGVICVHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private bool XYFOJDYEAEO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public EntityCommandBufferSystem KXGMHZITHZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAD02B0", Offset = "0xACF2B0", VA = "0x180AD02B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		protected bool TECFEJJOIIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xC763E0", Offset = "0xC753E0", VA = "0x180C763E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xAD0490", Offset = "0xACF490", VA = "0x180AD0490")]
		public void TVQOBDHQONC(EntityCommandBufferSystem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8721830", Offset = "0x8720830", VA = "0x188721830", Slot = "5")]
		[Preserve]
		protected override void OnCreate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8721910", Offset = "0x8720910", VA = "0x188721910", Slot = "13")]
		[Preserve]
		protected sealed override void OnUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x87218C0", Offset = "0x87208C0", VA = "0x1887218C0", Slot = "9")]
		[Preserve]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "14")]
		protected abstract void HSNGWZGAHYE();

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9B50", Offset = "0x3CB8B50", VA = "0x183CB9B50")]
		protected EntityQuery STKBDMBAJFD<T>() where T : struct, IComponentData
		{
			return default(EntityQuery);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9DD0", Offset = "0x3CB8DD0", VA = "0x183CB9DD0")]
		protected IntermediateVersionInfo<T> USSJPFMDKXQ<T>() where T : struct, IComponentData
		{
			return default(IntermediateVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3CB9630", Offset = "0x3CB8630", VA = "0x183CB9630")]
		protected FinalVersionInfo<T> DZNSZVGOUAD<T>() where T : struct, IComponentData
		{
			return default(FinalVersionInfo<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2E50040", Offset = "0x2E4F040", VA = "0x182E50040")]
		[Preserve]
		protected RCZOELPCTQO()
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
		public int YUAPMLUENDX
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6A2AC60", Offset = "0x6A29C60", VA = "0x186A2AC60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public (Entity entity, T value) this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6A2C2F0", Offset = "0x6A2B2F0", VA = "0x186A2C2F0")]
			get
			{
				return default((Entity, T));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A2A2A0", Offset = "0x6A292A0", VA = "0x186A2A2A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A31630", Offset = "0x6A30630", VA = "0x186A31630")]
		public VersionData<T> GAAVKUQIGOS()
		{
			return default(VersionData<T>);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[BurstCompile]
internal class IMNJEYWKCOT
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
