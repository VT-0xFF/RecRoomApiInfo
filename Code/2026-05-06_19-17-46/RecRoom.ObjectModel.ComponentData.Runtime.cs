using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation;
using RecRoom.Foundation.Collections;
using RecRoom.ObjectModel.Attributes;
using RecRoom.ObjectModel.Systems;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Properties;
using UnityEngine;
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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class CWHGVYTHLWE
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
	[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
	public CWHGVYTHLWE()
	{
	}
}
namespace _AssemblyRegistry.RecRoom_ObjectModel_ComponentData_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A12990", Offset = "0x9A11390", VA = "0x189A12990", Slot = "9")]
		public override void RegisterComponentDefaults(IComponentDefaultRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9A12D40", Offset = "0x9A11740", VA = "0x189A12D40", Slot = "7")]
		public override void RegisterTypes(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Systems
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[TypeManager.ForcedStableTypeHash(1586941204353847852uL)]
	public struct EmbodiedTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[TypeManager.ForcedStableTypeHash(1730701010008160003uL)]
	public struct ImmutableCreationInstantiationDataTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[TypeManager.ForcedStableTypeHash(3399609037308777919uL)]
	public struct ImmutableNetworkComponentsTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[TypeManager.ForcedStableTypeHash(18083619841998483100uL)]
	public struct ObjectBoardGraphIdMayBeEmptyTag : IComponentData
	{
	}
}
namespace RecRoom.ObjectModel.RendererV1
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[TypeManager.ForcedStableTypeHash(12361415346715948123uL)]
	public struct CanHaveRenderRootHandleTag : IComponentData
	{
	}
}
namespace RecRoom.Components
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[InternalBufferCapacity(8)]
	[Obfuscation(Exclude = true)]
	[TypeManager.ForcedStableTypeHash(15820941866177188261uL)]
	public struct AuthoredChildBuffer : IBufferElementData, IEquatable<AuthoredChildBuffer>, CSMHBJFDSWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A11740", Offset = "0x9A10140", VA = "0x189A11740", Slot = "4")]
		public bool Equals(AuthoredChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750")]
		public AuthoredChildBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDF8EF0", Offset = "0xDF78F0", VA = "0x180DF8EF0")]
		public static implicit operator AuthoredChildBuffer(Entity entity)
		{
			return default(AuthoredChildBuffer);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[TypeManager.ForcedStableTypeHash(7794731847884836165uL)]
	public struct ConnectableTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[TypeManager.ForcedStableTypeHash(16414266906034106824uL)]
	public struct ReplicatedSceneTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[TypeManager.ForcedStableTypeHash(1525018888797798356uL)]
	public struct CollisionIslandRootData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Entity islandRoot;
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[TypeManager.ForcedStableTypeHash(6294257411443737851uL)]
	public struct CollisionIslandRootSystemData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public Entity islandRoot;
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct CollisionIslandGeneratorState : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private NativeList<CollisionIslandHandle> roots;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private NativeList<Entity> islandComponentsBuffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private JobHandle jobHandle;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool LRUHMFXBSGC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x9A11A00", Offset = "0x9A10400", VA = "0x189A11A00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public int AGNSAISSRJH
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x9A117B0", Offset = "0x9A101B0", VA = "0x189A117B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9A11A50", Offset = "0x9A10450", VA = "0x189A11A50")]
		public CollisionIslandGeneratorState(NativeList<CollisionIslandHandle> roots, NativeList<Entity> islandComponentsBuffer, JobHandle jobHandle)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9A11810", Offset = "0x9A10210", VA = "0x189A11810")]
		public (Entity, NativeSlice<Entity>) SDOSLICFETR(int a)
		{
			return default((Entity, NativeSlice<Entity>));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9A11750", Offset = "0x9A10150", VA = "0x189A11750", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct CollisionIslandHandle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public Entity root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public int length;
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface URKKLPUAJNQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GBQJILOSSHD(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public readonly struct ObjectLocomotionSettings : IEquatable<ObjectLocomotionSettings>
	{
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public delegate bool SupportsLocomotionForActorId(int actorId);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly bool canClimb;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly bool canWallRun;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly bool canClamber;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly bool canTeleport;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly SupportsLocomotionForActorId supportsLocomotionForActorId;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9A12110", Offset = "0x9A10B10", VA = "0x189A12110")]
		public ObjectLocomotionSettings(PhysicsModelEnumFlags flags, SupportsLocomotionForActorId supportsLocomotionForActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9A120E0", Offset = "0x9A10AE0", VA = "0x189A120E0")]
		public ObjectLocomotionSettings(bool canClimb, bool canWallRun, bool canClamber, bool canTeleport, SupportsLocomotionForActorId supportsLocomotionForActorId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9A11E50", Offset = "0x9A10850", VA = "0x189A11E50")]
		public bool EOUXKPUXMYS(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A11DF0", Offset = "0x9A107F0", VA = "0x189A11DF0")]
		public bool CLCBESJFVAO(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9A12020", Offset = "0x9A10A20", VA = "0x189A12020")]
		public bool PSDDBYXRQUF(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9A11E20", Offset = "0x9A10820", VA = "0x189A11E20")]
		public bool DEOGOJKXNYC(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9A11F30", Offset = "0x9A10930", VA = "0x189A11F30", Slot = "4")]
		public bool Equals(ObjectLocomotionSettings other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9A11E80", Offset = "0x9A10880", VA = "0x189A11E80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9A11F80", Offset = "0x9A10980", VA = "0x189A11F80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9A11F60", Offset = "0x9A10960", VA = "0x189A11F60")]
		private bool GEOJWAUJPRV(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9A12050", Offset = "0x9A10A50", VA = "0x189A12050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class KVNOZWUNFHB : ICleanupComponentData, IComponentData, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EEKXAPFIXBA TCJWCANQZKT;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A11BD0", Offset = "0x9A105D0", VA = "0x189A11BD0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		[UnityEngine.Scripting.Preserve]
		public KVNOZWUNFHB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface EEKXAPFIXBA
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[TypeManager.ForcedStableTypeHash(8332665118338960440uL)]
	public struct ElementGroupData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public Entity groupEntity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[TypeManager.ForcedStableTypeHash(8981907371573408222uL)]
	public struct ElementGroupConnectedSetBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public Entity connectedElement;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[TypeManager.ForcedStableTypeHash(17354288130755581458uL)]
	public struct ElementGroupStaticRootData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Entity staticRoot;
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[TypeManager.ForcedStableTypeHash(10748250521618087564uL)]
	public struct ElementGroupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public bool isHeld;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public bool isEdited;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int editedBy;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[TypeManager.ForcedStableTypeHash(3379294255511517190uL)]
	public struct ElementPropagateFromLastTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(4520164298937563310uL)]
	public struct ElementSnappedCallbackQueue : ICleanupBufferElementData, IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public Entity prevSnap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Entity currSnap;
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[TypeManager.ForcedStableTypeHash(8968007509158485045uL)]
	public struct ElementSnapPointBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Entity snapPoint;
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[TypeManager.ForcedStableTypeHash(4138010451634514615uL)]
	public struct ElementSnapPointPreviousWorldPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public quaternion rotation;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[TypeManager.ForcedStableTypeHash(1690080301203719739uL)]
	public struct AlwaysEmbodiedScopeTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[TypeManager.ForcedStableTypeHash(13667964378929084748uL)]
	public readonly struct DesiredEmbodimentStateData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public readonly EmbodimentReasonFlags embodimentReasonFlags;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x328D560", Offset = "0x328BF60", VA = "0x18328D560")]
		public DesiredEmbodimentStateData(EmbodimentReasonFlags embodimentReasonFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A11AD0", Offset = "0x9A104D0", VA = "0x189A11AD0")]
		public DesiredEmbodimentStateData DPIZRAVCPJM(EmbodimentReasonFlags a)
		{
			return default(DesiredEmbodimentStateData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A11AE0", Offset = "0x9A104E0", VA = "0x189A11AE0")]
		public DesiredEmbodimentStateData JKLMZWFBUPY(EmbodimentReasonFlags a)
		{
			return default(DesiredEmbodimentStateData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A11AF0", Offset = "0x9A104F0", VA = "0x189A11AF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[Flags]
	public enum EmbodimentReasonFlags : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		HasShapeChildren = 1,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		HasEmbodiedChildren = 2,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		HasColliders = 4,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		HasObjectBoard = 8,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		HasUserTags = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		IsInScope = 0x20,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		IsScopeRoot = 0x40,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		IsRootObject = 0x80,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		TestEmbodiment = 0x100,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		ReferredToByGroup = 0x200,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		All = 0xFFFF
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class TXBHFUCSHGB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(1995886936411817354uL)]
	public struct EmbodimentReasonCheckerData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public EmbodimentReasonFlags ignoreFlags;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x328D560", Offset = "0x328BF60", VA = "0x18328D560")]
		public EmbodimentReasonCheckerData(EmbodimentReasonFlags ignore)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A11B50", Offset = "0x9A10550", VA = "0x189A11B50")]
		public bool AWROTWQUOCR(DesiredEmbodimentStateData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9A11B60", Offset = "0x9A10560", VA = "0x189A11B60")]
		public bool VNYTLYKTZIG(DesiredEmbodimentStateData a, EmbodimentReasonFlags b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Flags]
	public enum GlobalEmbodimentReason : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		MakerPenOut = 1
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(12096894998449299302uL)]
	public struct GlobalForceEmbodimentState : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public GlobalEmbodimentReason embodimentReasonFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool globalEmbodimentActive;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool XKBCRAWDOHR
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8C31FF0", Offset = "0x8C309F0", VA = "0x188C31FF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A11BC0", Offset = "0x9A105C0", VA = "0x189A11BC0")]
		private GlobalForceEmbodimentState(GlobalEmbodimentReason embodimentReasonFlags)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9A11B80", Offset = "0x9A10580", VA = "0x189A11B80")]
		public GlobalForceEmbodimentState DPIZRAVCPJM(GlobalEmbodimentReason a)
		{
			return default(GlobalForceEmbodimentState);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9A11BA0", Offset = "0x9A105A0", VA = "0x189A11BA0")]
		public GlobalForceEmbodimentState JKLMZWFBUPY(GlobalEmbodimentReason a)
		{
			return default(GlobalForceEmbodimentState);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[TypeManager.ForcedStableTypeHash(3210980466644930997uL)]
	public struct TestEmbodimentTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[InternalBufferCapacity(1)]
	[Obfuscation(Exclude = true)]
	[TypeManager.ForcedStableTypeHash(8887160633523457935uL)]
	public struct NetworkedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[TypeManager.ForcedStableTypeHash(2308769520679974324uL)]
	public struct SocketBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public Entity socketEntity;
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[InternalBufferCapacity(8)]
	[Obfuscation(Exclude = true)]
	[TypeManager.ForcedStableTypeHash(2803523268494646145uL)]
	public struct ChildBuffer : IBufferElementData, IEquatable<ChildBuffer>, CSMHBJFDSWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750")]
		public ChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9A11740", Offset = "0x9A10140", VA = "0x189A11740", Slot = "4")]
		public bool Equals(ChildBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xDF8EF0", Offset = "0xDF78F0", VA = "0x180DF8EF0")]
		public static implicit operator ChildBuffer(Entity entity)
		{
			return default(ChildBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(6734819606313844273uL)]
	public struct InteractionFilterCallbackQueue : ICleanupBufferElementData, IBufferElementData, CSMHBJFDSWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public Entity YUXUKOOMEGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[TypeManager.ForcedStableTypeHash(10606242260416974827uL)]
	public struct InteractionFilterSystemStateData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public Entity allTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public Entity anyTags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Entity noneTags;
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct VersionedComponent<T> : IComponentData where T : struct
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private static readonly bool IsValid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public uint VersionAtLastSet;

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8438FA0", Offset = "0x84379A0", VA = "0x188438FA0")]
		private static bool AZFXOVRUEYL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84390F0", Offset = "0x8437AF0", VA = "0x1884390F0")]
		public VersionedComponent(uint newVersion, T newValue)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[TypeManager.ForcedStableTypeHash(8255844827150930234uL)]
	public struct MagneticAnchorBuffer : IBufferElementData, IEquatable<MagneticAnchorBuffer>, CSMHBJFDSWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public Entity anchor;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		private Entity OOGKWEPWTHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750")]
		public MagneticAnchorBuffer(Entity anchor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A11740", Offset = "0x9A10140", VA = "0x189A11740", Slot = "4")]
		public bool Equals(MagneticAnchorBuffer other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[TypeManager.TypeVersion(2)]
	[TypeManager.ForcedStableTypeHash(14518013333183728344uL)]
	public struct ObjectNetworkIdComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public uint networkIdBytes;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[CreateProperty]
		public string TXCGYKEAUJI
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x9A12160", Offset = "0x9A10B60", VA = "0x189A12160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
		public ObjectNetworkIdComponentData(ObjectNetworkId networkId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x15B3200", Offset = "0x15B1C00", VA = "0x1815B3200")]
		public ObjectNetworkIdComponentData(uint networkIdBytes)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9A12160", Offset = "0x9A10B60", VA = "0x189A12160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1CBBD50", Offset = "0x1CBA750", VA = "0x181CBBD50")]
		public static implicit operator ObjectNetworkIdComponentData(ObjectNetworkId networkId)
		{
			return default(ObjectNetworkIdComponentData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[TypeManager.ForcedStableTypeHash(12631852336897389638uL)]
	public struct SceneInstantiatedEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[TypeManager.ForcedStableTypeHash(8586426759787957142uL)]
	public struct SceneInstantiatedNetworkIdBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public ObjectNetworkId value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[TypeManager.ForcedStableTypeHash(3916218676170013300uL)]
	public struct SceneInstantiatedRootEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[TypeManager.ForcedStableTypeHash(3395423174463894753uL)]
	public struct SceneInvalidItemBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[TypeManager.ForcedStableTypeHash(13485578171010875955uL)]
	public struct SceneRetainRemapBufferData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public int value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[TypeManager.ForcedStableTypeHash(11182407275731589027uL)]
	public struct SceneSourceEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	[TypeManager.ForcedStableTypeHash(238571310055566811uL)]
	public struct SceneSourceNetworkIdBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ObjectNetworkId value;
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[TypeManager.ForcedStableTypeHash(17943708062286791581uL)]
	public struct SceneSourceRootEntityBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Entity entity;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[TypeManager.ForcedStableTypeHash(17717774548790709874uL)]
	public struct IsMineTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(1628423395607207516uL)]
	public struct MasterClientData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int masterClientId;
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[TypeManager.ForcedStableTypeHash(6255673600552782006uL)]
	public struct PhotonOwnerData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int playerId;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public PlayerId DEFXUMZPRAG
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50")]
			get
			{
				return default(PlayerId);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[TypeManager.ForcedStableTypeHash(7921165883083593916uL)]
	public struct PhotonOwnerWatcherData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public GCHandle callbackToken;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[TypeManager.ForcedStableTypeHash(14965811366685608319uL)]
	public struct LocalPlayerTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[TypeManager.ForcedStableTypeHash(8376615066990205632uL)]
	public struct PlayerTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[TypeManager.ForcedStableTypeHash(7273320061473429398uL)]
	public struct PlayerPrefabTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[TypeManager.ForcedStableTypeHash(15140206241145976177uL)]
	public struct PlayerTrackingSpaceTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[TypeManager.ForcedStableTypeHash(15969631250552901108uL)]
	public struct RemotePlayerTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[TypeManager.ForcedStableTypeHash(9353178840587053763uL)]
	public struct PlaceholderReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public int version;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9A12190", Offset = "0x9A10B90", VA = "0x189A12190")]
		public PlaceholderReferenceData(Entity entity)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[TypeManager.ForcedStableTypeHash(16229383422209788655uL)]
	public struct RbexCollisionDetectionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public CollisionDetectionMode desiredCollisionDetectionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(5173865590150727846uL)]
	public struct RbexCullingData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public UpdateLOD updateLOD;

		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public static readonly RbexCullingData Default;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	[TypeManager.ForcedStableTypeHash(7051356195299730219uL)]
	public struct RbexCullingFullRateTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[TypeManager.ForcedStableTypeHash(780557526766205634uL)]
	public struct RbexCullingLimitedRateTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[TypeManager.ForcedStableTypeHash(16413322458062516985uL)]
	public struct RbexUseGravityTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[InternalBufferCapacity(0)]
	[TypeManager.ForcedStableTypeHash(8350832327674051347uL)]
	public struct RbexHierarchyChildBuffer : IBufferElementData, IEquatable<RbexHierarchyChildBuffer>, CSMHBJFDSWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Entity child;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private Entity OOGKWEPWTHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "5")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "6")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750")]
		public RbexHierarchyChildBuffer(Entity child)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9A11740", Offset = "0x9A10140", VA = "0x189A11740", Slot = "4")]
		public bool Equals(RbexHierarchyChildBuffer other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[TypeManager.ForcedStableTypeHash(3503423083784418805uL)]
	public struct RbexHierarchyParentData : IComponentData, CSMHBJFDSWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		private Entity OOGKWEPWTHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "5")]
			set
			{
			}
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[TypeManager.ForcedStableTypeHash(14551834985136520975uL)]
	public struct RbexHierarchyIsRootTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[TypeManager.ForcedStableTypeHash(4388378139562737487uL)]
	public struct RbexHierarchyRootData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Entity root;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct RbexHierarchyVelocityParentOverrideTokenData : HNJIRITICBZ, IComponentData
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public TokenHandle TokenHandle
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "4")]
			[CompilerGenerated]
			readonly get
			{
				return default(TokenHandle);
			}
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[TypeManager.ForcedStableTypeHash(769086036388751339uL)]
	public struct RbexCustomCenterOfMassData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public float3 customCenterOfMass;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[TypeManager.ForcedStableTypeHash(15638082890667179775uL)]
	public struct RbexInertialPropertiesDirtyTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(7040629969868025973uL)]
	public struct RbexInertiaTensorOfHierarchyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float3x3 inertiaTensor;

		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public static readonly RbexInertiaTensorOfHierarchyData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(1290915447730818204uL)]
	public struct RbexInertiaTensorOfSelfData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public float3x3 inertiaTensor;

		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public static readonly RbexInertiaTensorOfSelfData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[TypeManager.ForcedStableTypeHash(7667208078276643555uL)]
	public struct RbexLocalCenterOfMassOfHierarchyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public float3 localCenterOfMassOfHierarchy;
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[TypeManager.ForcedStableTypeHash(11475279934298573286uL)]
	public struct RbexLocalCenterOfMassOfSelfData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float3 localCenterOfMassOfSelf;
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(18413785019621221410uL)]
	public struct RbexMassOfHierarchyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public float massOfHierarchy;

		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public static readonly RbexMassOfHierarchyData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(16788150452972582455uL)]
	public struct RbexMassOfSelfData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public float massOfSelf;

		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public static readonly RbexMassOfSelfData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[TypeManager.ForcedStableTypeHash(971312552983123380uL)]
	public struct RbexPrecomputedCenterOfMassData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public float3 precomputedCenterOfMass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[TypeManager.ForcedStableTypeHash(361641396811542242uL)]
	public struct RbexInterpolationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public RbexInterpolationMode physicsInterpolation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(7520974846918069913uL)]
	public struct RbexKinematicChangeSystemStateBuffer : ICleanupBufferElementData, IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Entity entity;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[TypeManager.ForcedStableTypeHash(9260549625364734686uL)]
	public struct RbexHasUnityRigidbodyByDefaultTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[TypeManager.ForcedStableTypeHash(469905343419662571uL)]
	public struct RbexKeepUnityRigidbodyWhileParentedTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[TypeManager.ForcedStableTypeHash(7865784707562564105uL)]
	public struct RbexRigidbodyConstraintsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public RigidbodyConstraints constraints;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(7877027338327956319uL)]
	public struct RbexResistanceAngularDragData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float angularDrag;

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public static readonly RbexResistanceAngularDragData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[TypeManager.ForcedStableTypeHash(935406425377786813uL)]
	public struct RbexResistanceDragData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float drag;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public class OSBYZELNRGA : ICleanupComponentData, IComponentData, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public GameObject OTFFOMNHMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public object WSPELDIEDCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public object MZDJLQSJNPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public RLCLHHZLKYQ XDJKGBXTLOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public Delegate UEUQYYNCGKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public Delegate KABSDIDFPUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public TTRPJPMYOCH<Delegate> SPNUHFMUYDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public TTRPJPMYOCH<Delegate> YOWVJIIQHNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public TTRPJPMYOCH<Delegate> PMOOMCEBTOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public TTRPJPMYOCH<Delegate> MHEPBZTZCDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public TTRPJPMYOCH<Delegate> UCQKWYQKKZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public TTRPJPMYOCH<Delegate> OFSSFTKWTCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public TTRPJPMYOCH<Delegate> PRCEAHAZXRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public TTRPJPMYOCH<Delegate> YDCBMBMUKKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public TTRPJPMYOCH<Delegate> RAUIWSFNORQ;

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9A11DA0", Offset = "0x9A107A0", VA = "0x189A11DA0", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		[UnityEngine.Scripting.Preserve]
		public OSBYZELNRGA()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[TypeManager.ForcedStableTypeHash(9555099704367481551uL)]
	public struct RbexEmbodimentInProgressTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[TypeManager.ForcedStableTypeHash(18165447863202358792uL)]
	public struct RbexIsSleepingKinematicTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[TypeManager.ForcedStableTypeHash(10810926406358250264uL)]
	public struct RbexNumFramesKinematicSleepData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public int numFramesKinematicSleep;

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1CBBD50", Offset = "0x1CBA750", VA = "0x181CBBD50")]
		public static implicit operator RbexNumFramesKinematicSleepData(int value)
		{
			return default(RbexNumFramesKinematicSleepData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class QDHJXMNZFMK : IComponentData, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Rigidbody DXWALJYSDQJ;

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9A12230", Offset = "0x9A10C30", VA = "0x189A12230", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		[UnityEngine.Scripting.Preserve]
		public QDHJXMNZFMK()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[TypeManager.ForcedStableTypeHash(12765569839950265583uL)]
	public struct RbexWasAsleepTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[TypeManager.ForcedStableTypeHash(17236748096909814533uL)]
	public struct PendingRigidbodyLocalAngularVelocityData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float3 angularVelocity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[TypeManager.ForcedStableTypeHash(1288392478539867023uL)]
	public struct PendingRigidbodyLocalVelocityData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public float3 velocity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(15102898512288820575uL)]
	public struct RbexMaxAngularVelocityData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float maxAngularVelocity;

		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public static readonly RbexMaxAngularVelocityData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class WITREFIKVXC : IComponentData, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public object GSETPZIVTPZ;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9A12790", Offset = "0x9A11190", VA = "0x189A12790", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		[UnityEngine.Scripting.Preserve]
		public WITREFIKVXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class DPPBFVCCESB : IComponentData, ICloneable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public object SNVJIKMXWGQ;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9A11A60", Offset = "0x9A10460", VA = "0x189A11A60", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		[UnityEngine.Scripting.Preserve]
		public DPPBFVCCESB()
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[TypeManager.ForcedStableTypeHash(3505189951659289292uL)]
	public struct BakeableTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[TypeManager.ForcedStableTypeHash(16217323095468023009uL)]
	public struct ContainerWrapperProxyIsAttachedTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[TypeManager.ForcedStableTypeHash(12880717127246424414uL)]
	public struct PreviewEntityTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[TypeManager.ForcedStableTypeHash(12942629461400744171uL)]
	public struct PreviewReadyToEmbodyTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[TypeManager.ForcedStableTypeHash(10226241216405964379uL)]
	public struct ActiveSceneTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[TypeManager.ForcedStableTypeHash(12400259538654257671uL)]
	public struct ExcludeFromSceneTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[TypeManager.ForcedStableTypeHash(12731949941800560397uL)]
	public struct LoadInstanceLifetimeTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[TypeManager.ForcedStableTypeHash(16270799832065682331uL)]
	public struct LocalCreationSceneTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[TypeManager.ForcedStableTypeHash(9395080039644288849uL)]
	public struct LocalPlayerSceneTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[TypeManager.ForcedStableTypeHash(15229363233412980908uL)]
	public struct LocalTransientSceneTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[TypeManager.ForcedStableTypeHash(282623311697096978uL)]
	public struct SceneCreatorIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NetworkCreatorId creatorId;

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9A12720", Offset = "0x9A11120", VA = "0x189A12720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[TypeManager.ForcedStableTypeHash(10395819776101408141uL)]
	public struct SceneDestroyWhenCreatorLeavesTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[TypeManager.ForcedStableTypeHash(375953524326549120uL)]
	public struct SceneDontDestroyBetweenLoadInstancesTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[TypeManager.ForcedStableTypeHash(14259779488802476986uL)]
	public struct SceneEntityTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	[TypeManager.ForcedStableTypeHash(15330221065042235480uL)]
	public struct SceneNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public FixedString32Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(5162925656869367991uL)]
	public struct SingletonSceneEntitiesData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public UnsafeParallelHashMap<NetworkCreatorId, Entity> entityFromCreatorId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[TypeManager.ForcedStableTypeHash(9841032716800521808uL)]
	public struct SourceSceneTag : ISharedComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public Entity SceneEntity;
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[TypeManager.ForcedStableTypeHash(154813247653871879uL)]
	internal struct PlayerScopeSystemData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public Entity entity;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0xDF8EF0", Offset = "0xDF78F0", VA = "0x180DF8EF0")]
		public static implicit operator PlayerScopeSystemData(Entity entity)
		{
			return default(PlayerScopeSystemData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[TypeManager.ForcedStableTypeHash(11656653634719673845uL)]
	public struct ScopeInForwardingData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public Entity forwardTo;
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[TypeManager.ForcedStableTypeHash(1837719173092935466uL)]
	public struct ScopeOutForwardingData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public Entity forwardTo;
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[TypeManager.ForcedStableTypeHash(17382237360022739174uL)]
	internal struct ScopePivotSystemData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public Entity pivotEntity;

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0xDF8EF0", Offset = "0xDF78F0", VA = "0x180DF8EF0")]
		public static implicit operator ScopePivotSystemData(Entity entity)
		{
			return default(ScopePivotSystemData);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[TypeManager.ForcedStableTypeHash(15858722173278118533uL)]
	internal struct ScopeRootTag : ICleanupComponentData, IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[TypeManager.ForcedStableTypeHash(10313790595830381076uL)]
	public struct PrimitiveColliderAttachedBuffer : IBufferElementData, IEquatable<PrimitiveColliderAttachedBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public Entity primitive;

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x97FC360", Offset = "0x97FAD60", VA = "0x1897FC360", Slot = "4")]
		public bool Equals(PrimitiveColliderAttachedBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9A121A0", Offset = "0x9A10BA0", VA = "0x189A121A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	[TypeManager.ForcedStableTypeHash(10169361040328370708uL)]
	public struct SplineGeometryVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public uint version;
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(11536226225076729790uL)]
	internal struct SplinePointIndexChangeSystemStateBuffer : ICleanupBufferElementData, IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public Entity splinePoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public int index;
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[TypeManager.ForcedStableTypeHash(8309037880064337491uL)]
	internal struct SplinePointParentSystemData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Entity spline;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[TypeManager.ForcedStableTypeHash(5891816987223099091uL)]
	public struct CreationObjectLockHeldTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[TypeManager.ForcedStableTypeHash(17289298604600812224uL)]
	public struct CreationObjectSynchedLockData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public uint VersionAtLastSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public int LockOwner;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xEAEB30", Offset = "0xEAD530", VA = "0x180EAEB30")]
		public CreationObjectSynchedLockData(uint versionNumber, int lockOwner)
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[TypeManager.ForcedStableTypeHash(12258100538258701401uL)]
	public struct AwaitingEmbodimentTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[TypeManager.ForcedStableTypeHash(3081870877980445988uL)]
	public struct CanContainChildrenTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[TypeManager.ForcedStableTypeHash(15554741495161407507uL)]
	public struct CanScopeIntoTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[TypeManager.ForcedStableTypeHash(17684057078056878475uL)]
	public struct ContainerCollisionIslandRootTag : ICleanupComponentData, IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[TypeManager.ForcedStableTypeHash(10023455309444528896uL)]
	public struct ContainerPivotTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[TypeManager.ForcedStableTypeHash(14403752119546393228uL)]
	public struct ContainerTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[TypeManager.ForcedStableTypeHash(9219181242087356214uL)]
	public struct CreatedRemotelyTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[TypeManager.ForcedStableTypeHash(12371658133244024718uL)]
	public struct DontPropagateOwnershipTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[TypeManager.ForcedStableTypeHash(9351414359236295489uL)]
	public struct DontPropagatePhysicsPropertiesTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[TypeManager.ForcedStableTypeHash(12796707860320869007uL)]
	internal struct EmbodiedHiddenSystemTag : ICleanupComponentData, IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[TypeManager.ForcedStableTypeHash(13367368557807690484uL)]
	public struct EntityPrefabRootTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[TypeManager.ForcedStableTypeHash(7193071459223094579uL)]
	public struct ExcludeFromUserTagsQueryTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[TypeManager.ForcedStableTypeHash(17039127292426947163uL)]
	public struct HasCustomInertialPropertiesWhenRootTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[TypeManager.ForcedStableTypeHash(15247343901949961769uL)]
	public struct HasSiblingIndexTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	[TypeManager.ForcedStableTypeHash(5381043565870728787uL)]
	public struct HiddenTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[TypeManager.ForcedStableTypeHash(11597028615900234104uL)]
	internal struct HoverDescendantTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[TypeManager.ForcedStableTypeHash(1907494159895213433uL)]
	internal struct HoverRootTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	[TypeManager.ForcedStableTypeHash(3955886960983597628uL)]
	public struct IgnoreParentPolicyValidationTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000095")]
	[TypeManager.ForcedStableTypeHash(480620745253244652uL)]
	public struct IsHeldTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000096")]
	[TypeManager.ForcedStableTypeHash(8253675824478287824uL)]
	public struct LegacyGizmoTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[TypeManager.ForcedStableTypeHash(8855488771047251567uL)]
	public struct MustBeRootTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	[TypeManager.ForcedStableTypeHash(8375777954271012995uL)]
	public struct NeverSceneRootTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[TypeManager.ForcedStableTypeHash(16778215356980427836uL)]
	public struct PersistenceViewIsNotSerializedTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[TypeManager.ForcedStableTypeHash(16444804027614993581uL)]
	public struct PhysicsModelDisabledTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	[TypeManager.ForcedStableTypeHash(16177323740107409537uL)]
	public struct PreventSerializationTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[TypeManager.ForcedStableTypeHash(11049752089067741804uL)]
	public struct RecRoomStudioObjectEmbodiedTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[TypeManager.ForcedStableTypeHash(1453937769327886583uL)]
	public struct RecRoomStudioObjectTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[TypeManager.ForcedStableTypeHash(800754555681830909uL)]
	public struct RenderLegacyGameObjectTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[TypeManager.ForcedStableTypeHash(3336901602667819150uL)]
	public struct ReplicatorNeedsCircuitsUpdateTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[TypeManager.ForcedStableTypeHash(11809750536411032401uL)]
	public struct RequiredEmbodiedTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[TypeManager.ForcedStableTypeHash(6387004770090400669uL)]
	public struct CanEmbodyTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[TypeManager.ForcedStableTypeHash(2223159712203397538uL)]
	internal struct SelectionDescendantTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[TypeManager.ForcedStableTypeHash(10153397523300334327uL)]
	public struct SelectionRootTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[TypeManager.ForcedStableTypeHash(12983102201306073842uL)]
	public struct ShapeRuntimeTransformableTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[DontRemoveDuringBulkRemoveComponents]
	[TypeManager.ForcedStableTypeHash(15398959433761599914uL)]
	public struct SocketTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(6605318152550716456uL)]
	public struct TagManagerSerializedTagBuffer : ICleanupBufferElementData, IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public FixedString32Bytes tag;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[TypeManager.ForcedStableTypeHash(10065634662848845784uL)]
	public struct UserTagNameStateTag : ICleanupComponentData, IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[TypeManager.ForcedStableTypeHash(15062299176839263439uL)]
	public struct VisibleInHierarchyTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[TypeManager.ForcedStableTypeHash(3596269116834888123uL)]
	internal struct WillBeDestroyedTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[TypeManager.ForcedStableTypeHash(4402941654898007496uL)]
	internal struct WorldFadeScopeDescendantTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[TypeManager.ForcedStableTypeHash(12682474121528142025uL)]
	internal struct WorldFadeScopeRootTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[TypeManager.ForcedStableTypeHash(1840266485562743455uL)]
	public struct WriteOnceDeduplicatableRecordTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[TypeManager.ForcedStableTypeHash(15820134490602808056uL)]
	public struct LastTerrainGeneratedHashData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public int LastHash;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[TypeManager.ForcedStableTypeHash(4772574226205567794uL)]
	public struct ForceToolCleanupTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[TypeManager.ForcedStableTypeHash(17642911464827038147uL)]
	public struct OverrideLocalToolCleanupPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public quaternion rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public float3 position;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[TypeManager.ForcedStableTypeHash(9066921186040058989uL)]
	public struct OverrideToolCleanupPrefabData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public float minRotationAngleBeforeCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public float minDisplacementBeforeCleanup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public float minPlayerDistanceBeforeCleanup;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[TypeManager.ForcedStableTypeHash(3328998613642473514uL)]
	public struct ToolCleanupEnabledTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[TypeManager.ForcedStableTypeHash(151116349382904900uL)]
	public struct ToolCleanupHasMovedTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[TypeManager.ForcedStableTypeHash(8067675582152570601uL)]
	public struct ToolCleanupOverrideDisableTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[TypeManager.ForcedStableTypeHash(4522686316477281096uL)]
	public struct ToolCleanupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public int playerId;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B5")]
	[SingletonComponent]
	[TypeManager.ForcedStableTypeHash(6216404920432680992uL)]
	public struct ToolCleanupQueueBuffer : ICleanupBufferElementData, IBufferElementData, CSMHBJFDSWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public Entity element;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public Entity YUXUKOOMEGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(419884688393735449uL)]
	public struct LocalToParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public float4x4 localToParent;

		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public static readonly LocalToParentData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(1954795745923300919uL)]
	public struct LocalToWorldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public float4x4 localToWorld;

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static readonly LocalToWorldData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[TypeManager.ForcedStableTypeHash(2447627752265109178uL)]
	public struct TransformAccessArrayIndexData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private int complementOfIndex;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int ONJFVMMXRGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x9A12770", Offset = "0x9A11170", VA = "0x189A12770")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x9A12780", Offset = "0x9A11180", VA = "0x189A12780")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(13706996280046618062uL)]
	public struct WorldPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public float3 position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public quaternion rotation;

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public static readonly WorldPoseData Default;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9A12930", Offset = "0x9A11330", VA = "0x189A12930")]
		public WorldPoseData(quaternion rotation, float3 position)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	public static class MLJRYQZOLGB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x20000BB")]
	[RegisterComponentDefault]
	[TypeManager.ForcedStableTypeHash(77694943841979493uL)]
	public struct WorldUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public float worldUniformScale;

		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public static readonly WorldUniformScaleData Default;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	[TypeManager.ForcedStableTypeHash(6537711325103434903uL)]
	public struct ReferenceGroupBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public Entity group;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public ReferenceGroupKind kind;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BD")]
	[TypeManager.ForcedStableTypeHash(5471640964865828061uL)]
	public struct ReferenceGroupKindSystemStateData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public ReferenceGroupKind kind;
	}
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
	[TypeManager.ForcedStableTypeHash(16527934868211432802uL)]
	public struct ReferenceGroupOwnerSystemStateData : ICleanupComponentData, IComponentData, CSMHBJFDSWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public Entity owner;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Entity YUXUKOOMEGZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000BF")]
	[TypeManager.ForcedStableTypeHash(15310407062508355916uL)]
	public struct ReferenceGroupReferenceSystemStateBuffer : ICleanupBufferElementData, IBufferElementData, CSMHBJFDSWV, IEquatable<ReferenceGroupReferenceSystemStateBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public Entity YUXUKOOMEGZ
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x97FC360", Offset = "0x97FAD60", VA = "0x1897FC360", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceSystemStateBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9A125E0", Offset = "0x9A10FE0", VA = "0x189A125E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xF55B50", Offset = "0xF54550", VA = "0x180F55B50", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C0")]
	[TypeManager.ForcedStableTypeHash(11786768220100978132uL)]
	public struct ReferredToByBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Entity group;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public ReferenceGroupKind kind;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x20000C1")]
	public struct ReferredToByEqualityComparer : IEqualityComparer<ReferredToByBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public static ReferredToByEqualityComparer Default;

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9A12670", Offset = "0x9A11070", VA = "0x189A12670", Slot = "4")]
		public bool Equals(ReferredToByBuffer x, ReferredToByBuffer y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9A126C0", Offset = "0x9A110C0", VA = "0x189A126C0", Slot = "5")]
		public int GetHashCode(ReferredToByBuffer obj)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000C2")]
	[TypeManager.ForcedStableTypeHash(8981997360983277121uL)]
	public struct InteractionFilterTagSystemStateData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000C3")]
	[TypeManager.ForcedStableTypeHash(2801212869002544047uL)]
	public struct PersistentUserTagSystemStateData : ICleanupComponentData, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		public FixedList32Bytes<int> tags;
	}
	[Cpp2IlInjected.Token(Token = "0x20000C4")]
	[TypeManager.ForcedStableTypeHash(16455485691096333919uL)]
	public struct UserTagStateBuffer : ICleanupBufferElementData, IBufferElementData, CSMHBJFDSWV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Entity OOGKWEPWTHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xEC0C10", Offset = "0xEBF610", VA = "0x180EC0C10", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x13EE750", Offset = "0x13ED150", VA = "0x1813EE750", Slot = "5")]
			set
			{
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000C8")]
[BurstCompile]
internal class RGBFDSRGMKF
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
