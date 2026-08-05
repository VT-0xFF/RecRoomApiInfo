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
		[Cpp2IlInjected.Address(RVA = "0xA97AB0", Offset = "0xA960B0", VA = "0x180A97AB0")]
		public RecRoomProBuilderOptimization()
		{
		}
	}
}
namespace RecRoom.Core.Studio
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[AddComponentMenu(null)]
	public class MaterialMap : MaterialMapBase<MaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9000780", Offset = "0x8FFED80", VA = "0x189000780")]
		public MaterialMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MaterialMapAsset : MaterialMapAssetBase<MaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9000740", Offset = "0x8FFED40", VA = "0x189000740")]
		public MaterialMapAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu(null)]
	public sealed class RecRoomAudioClipRegistry : RecRoomAudioClipRegistryBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9000AD0", Offset = "0x8FFF0D0", VA = "0x189000AD0")]
		public RecRoomAudioClipRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9000A90", Offset = "0x8FFF090", VA = "0x189000A90")]
		public RecRoomAudioClipRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AddComponentMenu(null)]
	public sealed class RecRoomAudioMixerRegistry : RecRoomAudioMixerRegistryBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecRoomAudioMixerRegistryAsset : RecRoomAudioMixerRegistryAssetBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xF0F950", Offset = "0xF0DF50", VA = "0x180F0F950")]
		public RecRoomAudioMixerRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AddComponentMenu(null)]
	public sealed class RecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RecRoomBuiltInObjectData : RecRoomBuiltInObjectDataBase<RecRoomBuiltInObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9000B10", Offset = "0x8FFF110", VA = "0x189000B10")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[AddComponentMenu("Rec Room Studio/Studio Object (Rec Room Studio)")]
	[DisallowMultipleComponent]
	[SerializedTypeName]
	public sealed class RecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9000D30", Offset = "0x8FFF330", VA = "0x189000D30")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityParameterlessEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9000810", Offset = "0x8FFEE10", VA = "0x189000810")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityBooleanEvent : NamedUnityBooleanEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x90007C0", Offset = "0x8FFEDC0", VA = "0x1890007C0")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityFloatEvent : NamedUnityFloatEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9000860", Offset = "0x8FFEE60", VA = "0x189000860")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityIntEvent : NamedUnityIntEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x90008B0", Offset = "0x8FFEEB0", VA = "0x1890008B0")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringEvent : NamedUnityStringEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9000950", Offset = "0x8FFEF50", VA = "0x189000950")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityStringBooleanEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9000900", Offset = "0x8FFEF00", VA = "0x189000900")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityStringFloatEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x90009A0", Offset = "0x8FFEFA0", VA = "0x1890009A0")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityStringIntEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x90009F0", Offset = "0x8FFEFF0", VA = "0x1890009F0")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringStringEvent : NamedUnityStringStringEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9000A40", Offset = "0x8FFF040", VA = "0x189000A40")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[AddComponentMenu(null)]
	public sealed class RecRoomObjectPrefabRegistry : RecRoomObjectPrefabRegistryBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9000CF0", Offset = "0x8FFF2F0", VA = "0x189000CF0")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class RecRoomObjectPrefabEntry : RecRoomObjectPrefabEntryBase<RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9000B50", Offset = "0x8FFF150", VA = "0x189000B50", Slot = "10")]
		public override IStudioUnityAssetRegistrationEntry ToUnityAssetRegistrationEntry()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9000C70", Offset = "0x8FFF270", VA = "0x189000C70")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class RecRoomObjectPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9000CB0", Offset = "0x8FFF2B0", VA = "0x189000CB0")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AddComponentMenu("Particle VFX (Rec Room Studio)")]
	public class RecRoomParticleVfx : RecRoomParticleVfxBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9000DC0", Offset = "0x8FFF3C0", VA = "0x189000DC0")]
		public RecRoomParticleVfx()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[AddComponentMenu(null)]
	public sealed class RecRoomParticleVfxRegistry : RecRoomParticleVfxRegistryBase<RecRoomParticleVfxRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9000D80", Offset = "0x8FFF380", VA = "0x189000D80")]
		public RecRoomParticleVfxRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class RecRoomParticleVfxRegistryAsset : RecRoomParticleVfxRegistryAssetBase<RecRoomParticleVfxRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9000D40", Offset = "0x8FFF340", VA = "0x189000D40")]
		public RecRoomParticleVfxRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[AddComponentMenu("Projectile (Rec Room Studio)")]
	public class RecRoomProjectile : RecRoomProjectileBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9000E50", Offset = "0x8FFF450", VA = "0x189000E50")]
		public RecRoomProjectile()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[AddComponentMenu(null)]
	public sealed class RecRoomProjectileRegistry : RecRoomProjectileRegistryBase<RecRoomProjectileRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9000E10", Offset = "0x8FFF410", VA = "0x189000E10")]
		public RecRoomProjectileRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class RecRoomProjectileRegistryAsset : RecRoomProjectileRegistryAssetBase<RecRoomProjectileRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9000DD0", Offset = "0x8FFF3D0", VA = "0x189000DD0")]
		public RecRoomProjectileRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AddComponentMenu("Rec Room Studio/Animator Synchronizer (Rec Room Studio)")]
	[RequireComponent(typeof(Animator))]
	public class RecRoomStudioAnimatorSynchronizer : RecRoomStudioAnimatorSynchronizerBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
		public RecRoomStudioAnimatorSynchronizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[AddComponentMenu("Rec Room Studio/Billboard (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioBillboard : RecRoomStudioBillboardBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9000E60", Offset = "0x8FFF460", VA = "0x189000E60")]
		public RecRoomStudioBillboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Rec Room Studio/Canvas Interaction (Rec Room Studio)")]
	public sealed class RecRoomStudioCanvasInteraction : RecRoomStudioCanvasInteractionBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
		public RecRoomStudioCanvasInteraction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[AddComponentMenu("Rec Room Studio/Disable Render In Share Camera Photo (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioDisableRenderInShareCamPhoto : RecRoomStudioDisableRenderInShareCamPhotoBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
		public RecRoomStudioDisableRenderInShareCamPhoto()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Rec Room Studio/HUD Canvas (Rec Room Studio)")]
	public sealed class RecRoomStudioHudCanvas : RecRoomStudioHudCanvasBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
		public RecRoomStudioHudCanvas()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[AddComponentMenu("Rec Room Studio/Instance Recolor (Rec Room Studio)")]
	public sealed class RecRoomStudioInstanceRecolor : RecRoomStudioInstanceRecolorBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9000E70", Offset = "0x8FFF470", VA = "0x189000E70")]
		public RecRoomStudioInstanceRecolor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioNavMeshCut : RecRoomStudioNavMeshCutBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9000EC0", Offset = "0x8FFF4C0", VA = "0x189000EC0")]
		public RecRoomStudioNavMeshCut()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[AddComponentMenu(null)]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioPlatformTextFilter : RecRoomStudioPlatformTextFilterBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
		public RecRoomStudioPlatformTextFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[AddComponentMenu("Rec Room Studio/Rec Net Image (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioRecNetImage : RecRoomStudioRecNetImageBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9000ED0", Offset = "0x8FFF4D0", VA = "0x189000ED0")]
		public RecRoomStudioRecNetImage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[AddComponentMenu(null)]
	public sealed class RecRoomVisualPostProcessing : RecRoomVisualPostProcessingBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
		public RecRoomVisualPostProcessing()
		{
		}
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[AddComponentMenu("Rec Room Studio/Avatar Item (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioAvatarItem : RecRoomStudioAvatarItemBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xAB2290", Offset = "0xAB0890", VA = "0x180AB2290")]
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
