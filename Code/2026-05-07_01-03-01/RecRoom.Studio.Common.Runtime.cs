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
		[Cpp2IlInjected.Address(RVA = "0xCD14B0", Offset = "0xCCFEB0", VA = "0x180CD14B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA387DD0", Offset = "0xA3867D0", VA = "0x18A387DD0")]
		public MaterialMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MaterialMapAsset : MaterialMapAssetBase<MaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA387D90", Offset = "0xA386790", VA = "0x18A387D90")]
		public MaterialMapAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu("/")]
	public sealed class RecRoomAudioClipRegistry : RecRoomAudioClipRegistryBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA388120", Offset = "0xA386B20", VA = "0x18A388120")]
		public RecRoomAudioClipRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA3880E0", Offset = "0xA386AE0", VA = "0x18A3880E0")]
		public RecRoomAudioClipRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AddComponentMenu("/")]
	public sealed class RecRoomAudioMixerRegistry : RecRoomAudioMixerRegistryBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecRoomAudioMixerRegistryAsset : RecRoomAudioMixerRegistryAssetBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xEFA4D0", Offset = "0xEF8ED0", VA = "0x180EFA4D0")]
		public RecRoomAudioMixerRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AddComponentMenu("/")]
	public sealed class RecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public sealed class RecRoomBuiltInObjectEntry : RecRoomBuiltInObjectEntryBase<RecRoomBuiltInObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA3881A0", Offset = "0xA386BA0", VA = "0x18A3881A0")]
		public RecRoomBuiltInObjectEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomBuiltInObjectData : RecRoomBuiltInObjectDataBase<RecRoomBuiltInObject, RecRoomBuiltInObjectEntry>
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA388160", Offset = "0xA386B60", VA = "0x18A388160")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3881E0", Offset = "0xA386BE0", VA = "0x18A3881E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA388410", Offset = "0xA386E10", VA = "0x18A388410")]
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
		[Cpp2IlInjected.Address(RVA = "0xA387E60", Offset = "0xA386860", VA = "0x18A387E60")]
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
		[Cpp2IlInjected.Address(RVA = "0xA387E10", Offset = "0xA386810", VA = "0x18A387E10")]
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
		[Cpp2IlInjected.Address(RVA = "0xA387EB0", Offset = "0xA3868B0", VA = "0x18A387EB0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA387F00", Offset = "0xA386900", VA = "0x18A387F00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA387FA0", Offset = "0xA3869A0", VA = "0x18A387FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA387F50", Offset = "0xA386950", VA = "0x18A387F50")]
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
		[Cpp2IlInjected.Address(RVA = "0xA387FF0", Offset = "0xA3869F0", VA = "0x18A387FF0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA388040", Offset = "0xA386A40", VA = "0x18A388040")]
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
		[Cpp2IlInjected.Address(RVA = "0xA388090", Offset = "0xA386A90", VA = "0x18A388090")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AddComponentMenu("/")]
	public sealed class RecRoomObjectPrefabRegistry : RecRoomObjectPrefabRegistryBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA3883D0", Offset = "0xA386DD0", VA = "0x18A3883D0")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public sealed class RecRoomObjectPrefabEntry : RecRoomObjectPrefabEntryBase<RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xA388230", Offset = "0xA386C30", VA = "0x18A388230", Slot = "10")]
		public override IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA388350", Offset = "0xA386D50", VA = "0x18A388350")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public sealed class RecRoomObjectPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA388390", Offset = "0xA386D90", VA = "0x18A388390")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("Particle VFX (Rec Room Studio)")]
	public class RecRoomParticleVfx : RecRoomParticleVfxBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA3884A0", Offset = "0xA386EA0", VA = "0x18A3884A0")]
		public RecRoomParticleVfx()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[AddComponentMenu("/")]
	public sealed class RecRoomParticleVfxRegistry : RecRoomParticleVfxRegistryBase<RecRoomParticleVfxRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA388460", Offset = "0xA386E60", VA = "0x18A388460")]
		public RecRoomParticleVfxRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class RecRoomParticleVfxRegistryAsset : RecRoomParticleVfxRegistryAssetBase<RecRoomParticleVfxRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA388420", Offset = "0xA386E20", VA = "0x18A388420")]
		public RecRoomParticleVfxRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AddComponentMenu("Player Collision Handler (Rec Room Studio)")]
	public class RecRoomPlayerCollisionHandler : RecRoomPlayerCollisionHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA3884B0", Offset = "0xA386EB0", VA = "0x18A3884B0")]
		public RecRoomPlayerCollisionHandler()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AddComponentMenu("Projectile (Rec Room Studio)")]
	public class RecRoomProjectile : RecRoomProjectileBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA388540", Offset = "0xA386F40", VA = "0x18A388540")]
		public RecRoomProjectile()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[AddComponentMenu("/")]
	public sealed class RecRoomProjectileRegistry : RecRoomProjectileRegistryBase<RecRoomProjectileRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA388500", Offset = "0xA386F00", VA = "0x18A388500")]
		public RecRoomProjectileRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class RecRoomProjectileRegistryAsset : RecRoomProjectileRegistryAssetBase<RecRoomProjectileRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA3884C0", Offset = "0xA386EC0", VA = "0x18A3884C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
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
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
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
		[Cpp2IlInjected.Address(RVA = "0xA388550", Offset = "0xA386F50", VA = "0x18A388550")]
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
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
		public RecRoomStudioCanvasInteraction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[AddComponentMenu("Consumable Item (Rec Room Studio)")]
	public class RecRoomStudioConsumableItem : RecRoomStudioConsumableItemBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA3885E0", Offset = "0xA386FE0", VA = "0x18A3885E0")]
		public RecRoomStudioConsumableItem()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[AddComponentMenu("/")]
	public sealed class RecRoomStudioConsumableItemRegistry : RecRoomStudioConsumableItemRegistryBase<RecRoomStudioConsumableItemRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA3885A0", Offset = "0xA386FA0", VA = "0x18A3885A0")]
		public RecRoomStudioConsumableItemRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class RecRoomStudioConsumableItemRegistryAsset : RecRoomStudioConsumableItemRegistryAssetBase<RecRoomStudioConsumableItemRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA388560", Offset = "0xA386F60", VA = "0x18A388560")]
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
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
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
		[Cpp2IlInjected.Address(RVA = "0xA388410", Offset = "0xA386E10", VA = "0x18A388410")]
		public RecRoomStudioFunctionContainer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[AddComponentMenu("Studio Function Container List (Rec Room Studio)")]
	public class RecRoomStudioFunctionContainerList : RecRoomStudioFunctionContainerListBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
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
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
		public RecRoomStudioHudCanvas()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	[AddComponentMenu("Rec Room Studio/Instance Recolor (Rec Room Studio)")]
	public sealed class RecRoomStudioInstanceRecolor : RecRoomStudioInstanceRecolorBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA388630", Offset = "0xA387030", VA = "0x18A388630")]
		public RecRoomStudioInstanceRecolor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioNavMeshCut : RecRoomStudioNavMeshCutBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA388680", Offset = "0xA387080", VA = "0x18A388680")]
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
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
		public RecRoomStudioPlatformTextFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[AddComponentMenu("Primary Interaction Handler (Rec Room Studio)")]
	public class RecRoomStudioPrimaryInteractionHandler : RecRoomStudioInteractionHandlerBase
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA388690", Offset = "0xA387090", VA = "0x18A388690")]
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
		[Cpp2IlInjected.Address(RVA = "0xA3886A0", Offset = "0xA3870A0", VA = "0x18A3886A0")]
		public RecRoomStudioRecNetImage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[AddComponentMenu("/")]
	public sealed class RecRoomVisualPostProcessing : RecRoomVisualPostProcessingBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
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
		[Cpp2IlInjected.Address(RVA = "0xCED750", Offset = "0xCEC150", VA = "0x180CED750")]
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
