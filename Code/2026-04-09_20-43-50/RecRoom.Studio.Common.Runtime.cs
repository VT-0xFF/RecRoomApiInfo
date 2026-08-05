using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.ProBuilder
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[AddComponentMenu("ProBuilder Optimization (Rec Room)")]
	public sealed class RecRoomProBuilderOptimization : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD0AF80", Offset = "0xD09F80", VA = "0x180D0AF80")]
		public RecRoomProBuilderOptimization()
		{
		}
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AddComponentMenu("/")]
	public class MaterialMap : MaterialMapBase<MaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA544210", Offset = "0xA543210", VA = "0x18A544210")]
		public MaterialMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MaterialMapAsset : MaterialMapAssetBase<MaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA5441D0", Offset = "0xA5431D0", VA = "0x18A5441D0")]
		public MaterialMapAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("/")]
	public sealed class RecRoomAudioClipRegistry : RecRoomAudioClipRegistryBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA544560", Offset = "0xA543560", VA = "0x18A544560")]
		public RecRoomAudioClipRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA544520", Offset = "0xA543520", VA = "0x18A544520")]
		public RecRoomAudioClipRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AddComponentMenu("/")]
	public sealed class RecRoomAudioMixerRegistry : RecRoomAudioMixerRegistryBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecRoomAudioMixerRegistryAsset : RecRoomAudioMixerRegistryAssetBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xF1FBA0", Offset = "0xF1EBA0", VA = "0x180F1FBA0")]
		public RecRoomAudioMixerRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AddComponentMenu("/")]
	public sealed class RecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class RecRoomBuiltInObjectEntry : RecRoomBuiltInObjectEntryBase<RecRoomBuiltInObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA5445E0", Offset = "0xA5435E0", VA = "0x18A5445E0")]
		public RecRoomBuiltInObjectEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomBuiltInObjectData : RecRoomBuiltInObjectDataBase<RecRoomBuiltInObject, RecRoomBuiltInObjectEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA5445A0", Offset = "0xA5435A0", VA = "0x18A5445A0")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[AddComponentMenu("Grip Options (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public class RecRoomGripOptions : RecRoomGripOptionsBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA544620", Offset = "0xA543620", VA = "0x18A544620")]
		public RecRoomGripOptions()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[AddComponentMenu("Rec Room Studio/Studio Object (Rec Room Studio)")]
	[DisallowMultipleComponent]
	[SerializedTypeName]
	public sealed class RecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA544850", Offset = "0xA543850", VA = "0x18A544850")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityParameterlessEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA5442A0", Offset = "0xA5432A0", VA = "0x18A5442A0")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityBooleanEvent : NamedUnityBooleanEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA544250", Offset = "0xA543250", VA = "0x18A544250")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityFloatEvent : NamedUnityFloatEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA5442F0", Offset = "0xA5432F0", VA = "0x18A5442F0")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityIntEvent : NamedUnityIntEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA544340", Offset = "0xA543340", VA = "0x18A544340")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringEvent : NamedUnityStringEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA5443E0", Offset = "0xA5433E0", VA = "0x18A5443E0")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityStringBooleanEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA544390", Offset = "0xA543390", VA = "0x18A544390")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityStringFloatEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA544430", Offset = "0xA543430", VA = "0x18A544430")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityStringIntEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA544480", Offset = "0xA543480", VA = "0x18A544480")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringStringEvent : NamedUnityStringStringEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA5444D0", Offset = "0xA5434D0", VA = "0x18A5444D0")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AddComponentMenu("/")]
	public sealed class RecRoomObjectPrefabRegistry : RecRoomObjectPrefabRegistryBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA544810", Offset = "0xA543810", VA = "0x18A544810")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class RecRoomObjectPrefabEntry : RecRoomObjectPrefabEntryBase<RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA544670", Offset = "0xA543670", VA = "0x18A544670", Slot = "10")]
		public override IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA544790", Offset = "0xA543790", VA = "0x18A544790")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class RecRoomObjectPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA5447D0", Offset = "0xA5437D0", VA = "0x18A5447D0")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("Particle VFX (Rec Room Studio)")]
	public class RecRoomParticleVfx : RecRoomParticleVfxBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA5448E0", Offset = "0xA5438E0", VA = "0x18A5448E0")]
		public RecRoomParticleVfx()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[AddComponentMenu("/")]
	public sealed class RecRoomParticleVfxRegistry : RecRoomParticleVfxRegistryBase<RecRoomParticleVfxRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA5448A0", Offset = "0xA5438A0", VA = "0x18A5448A0")]
		public RecRoomParticleVfxRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RecRoomParticleVfxRegistryAsset : RecRoomParticleVfxRegistryAssetBase<RecRoomParticleVfxRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA544860", Offset = "0xA543860", VA = "0x18A544860")]
		public RecRoomParticleVfxRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AddComponentMenu("Player Collision Handler (Rec Room Studio)")]
	public class RecRoomPlayerCollisionHandler : RecRoomPlayerCollisionHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA5448F0", Offset = "0xA5438F0", VA = "0x18A5448F0")]
		public RecRoomPlayerCollisionHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AddComponentMenu("Projectile (Rec Room Studio)")]
	public class RecRoomProjectile : RecRoomProjectileBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA544980", Offset = "0xA543980", VA = "0x18A544980")]
		public RecRoomProjectile()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[AddComponentMenu("/")]
	public sealed class RecRoomProjectileRegistry : RecRoomProjectileRegistryBase<RecRoomProjectileRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA544940", Offset = "0xA543940", VA = "0x18A544940")]
		public RecRoomProjectileRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RecRoomProjectileRegistryAsset : RecRoomProjectileRegistryAssetBase<RecRoomProjectileRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA544900", Offset = "0xA543900", VA = "0x18A544900")]
		public RecRoomProjectileRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[AddComponentMenu("Rec Room Studio/Animator Synchronizer (Rec Room Studio)")]
	[RequireComponent(typeof(Animator))]
	public class RecRoomStudioAnimatorSynchronizer : RecRoomStudioAnimatorSynchronizerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomStudioAnimatorSynchronizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[AddComponentMenu("Rec Room Studio/Audio Source Synchronizer (Rec Room Studio)")]
	[RequireComponent(typeof(AudioSource))]
	public class RecRoomStudioAudioSourceSynchronizer : RecRoomStudioAudioSourceSynchronizerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomStudioAudioSourceSynchronizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[AddComponentMenu("Rec Room Studio/Billboard (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioBillboard : RecRoomStudioBillboardBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA544990", Offset = "0xA543990", VA = "0x18A544990")]
		public RecRoomStudioBillboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Rec Room Studio/Canvas Interaction (Rec Room Studio)")]
	public sealed class RecRoomStudioCanvasInteraction : RecRoomStudioCanvasInteractionBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomStudioCanvasInteraction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[AddComponentMenu("Consumable Item (Rec Room Studio)")]
	public class RecRoomStudioConsumableItem : RecRoomStudioConsumableItemBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA544A20", Offset = "0xA543A20", VA = "0x18A544A20")]
		public RecRoomStudioConsumableItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[AddComponentMenu("/")]
	public sealed class RecRoomStudioConsumableItemRegistry : RecRoomStudioConsumableItemRegistryBase<RecRoomStudioConsumableItemRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA5449E0", Offset = "0xA5439E0", VA = "0x18A5449E0")]
		public RecRoomStudioConsumableItemRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RecRoomStudioConsumableItemRegistryAsset : RecRoomStudioConsumableItemRegistryAssetBase<RecRoomStudioConsumableItemRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA5449A0", Offset = "0xA5439A0", VA = "0x18A5449A0")]
		public RecRoomStudioConsumableItemRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[AddComponentMenu("Rec Room Studio/Disable Render In Share Camera Photo (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioDisableRenderInShareCamPhoto : RecRoomStudioDisableRenderInShareCamPhotoBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomStudioDisableRenderInShareCamPhoto()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[AddComponentMenu("Studio Function Container (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public class RecRoomStudioFunctionContainer : RecRoomStudioFunctionContainerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA544850", Offset = "0xA543850", VA = "0x18A544850")]
		public RecRoomStudioFunctionContainer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AddComponentMenu("Studio Function Container List (Rec Room Studio)")]
	public class RecRoomStudioFunctionContainerList : RecRoomStudioFunctionContainerListBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomStudioFunctionContainerList()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Rec Room Studio/HUD Canvas (Rec Room Studio)")]
	public sealed class RecRoomStudioHudCanvas : RecRoomStudioHudCanvasBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomStudioHudCanvas()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[AddComponentMenu("Rec Room Studio/Instance Recolor (Rec Room Studio)")]
	public sealed class RecRoomStudioInstanceRecolor : RecRoomStudioInstanceRecolorBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA544A70", Offset = "0xA543A70", VA = "0x18A544A70")]
		public RecRoomStudioInstanceRecolor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioNavMeshCut : RecRoomStudioNavMeshCutBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA544AC0", Offset = "0xA543AC0", VA = "0x18A544AC0")]
		public RecRoomStudioNavMeshCut()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[AddComponentMenu("/")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioPlatformTextFilter : RecRoomStudioPlatformTextFilterBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomStudioPlatformTextFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[AddComponentMenu("Primary Interaction Handler (Rec Room Studio)")]
	public class RecRoomStudioPrimaryInteractionHandler : RecRoomStudioInteractionHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA544AD0", Offset = "0xA543AD0", VA = "0x18A544AD0")]
		public RecRoomStudioPrimaryInteractionHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[AddComponentMenu("Rec Room Studio/Rec Net Image (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioRecNetImage : RecRoomStudioRecNetImageBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA544AE0", Offset = "0xA543AE0", VA = "0x18A544AE0")]
		public RecRoomStudioRecNetImage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[AddComponentMenu("/")]
	public sealed class RecRoomVisualPostProcessing : RecRoomVisualPostProcessingBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomVisualPostProcessing()
		{
		}
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[AddComponentMenu("Rec Room Studio/Avatar Item (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioAvatarItem : RecRoomStudioAvatarItemBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD26970", Offset = "0xD25970", VA = "0x180D26970")]
		public RecRoomStudioAvatarItem()
		{
		}
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
