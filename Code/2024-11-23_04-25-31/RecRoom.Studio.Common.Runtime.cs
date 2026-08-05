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
		[Cpp2IlInjected.Address(RVA = "0x8ACA40", Offset = "0x8AB440", VA = "0x1808ACA40")]
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
		[Cpp2IlInjected.Address(RVA = "0x77B5F80", Offset = "0x77B4980", VA = "0x1877B5F80")]
		public MaterialMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MaterialMapAsset : MaterialMapAssetBase<MaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x77B5F40", Offset = "0x77B4940", VA = "0x1877B5F40")]
		public MaterialMapAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu(null)]
	public sealed class RecRoomAudioClipRegistry : RecRoomAudioClipRegistryBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77B62D0", Offset = "0x77B4CD0", VA = "0x1877B62D0")]
		public RecRoomAudioClipRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x77B6290", Offset = "0x77B4C90", VA = "0x1877B6290")]
		public RecRoomAudioClipRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AddComponentMenu(null)]
	public sealed class RecRoomAudioMixerRegistry : RecRoomAudioMixerRegistryBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x77B6310", Offset = "0x77B4D10", VA = "0x1877B6310")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[AddComponentMenu(null)]
	public sealed class RecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RecRoomBuiltInObjectData : RecRoomBuiltInObjectDataBase<RecRoomBuiltInObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x77B6360", Offset = "0x77B4D60", VA = "0x1877B6360")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[DisallowMultipleComponent]
	[SerializedTypeName]
	[AddComponentMenu("Rec Room Studio/Studio Object (Rec Room Studio)")]
	public sealed class RecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x77B6460", Offset = "0x77B4E60", VA = "0x1877B6460")]
		public RecRoomObject()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityEvent : NamedUnityParameterlessEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x77B6010", Offset = "0x77B4A10", VA = "0x1877B6010")]
		public NamedUnityEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityBooleanEvent : NamedUnityBooleanEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x77B5FC0", Offset = "0x77B49C0", VA = "0x1877B5FC0")]
		public NamedUnityBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityFloatEvent : NamedUnityFloatEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77B6060", Offset = "0x77B4A60", VA = "0x1877B6060")]
		public NamedUnityFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityIntEvent : NamedUnityIntEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x77B60B0", Offset = "0x77B4AB0", VA = "0x1877B60B0")]
		public NamedUnityIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringEvent : NamedUnityStringEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77B6150", Offset = "0x77B4B50", VA = "0x1877B6150")]
		public NamedUnityStringEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringBooleanEvent : NamedUnityStringBooleanEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x77B6100", Offset = "0x77B4B00", VA = "0x1877B6100")]
		public NamedUnityStringBooleanEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringFloatEvent : NamedUnityStringFloatEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77B61A0", Offset = "0x77B4BA0", VA = "0x1877B61A0")]
		public NamedUnityStringFloatEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringIntEvent : NamedUnityStringIntEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x77B61F0", Offset = "0x77B4BF0", VA = "0x1877B61F0")]
		public NamedUnityStringIntEvent()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[SerializedTypeName]
	[Preserve]
	public sealed class NamedUnityStringStringEvent : NamedUnityStringStringEventBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x77B6240", Offset = "0x77B4C40", VA = "0x1877B6240")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	[AddComponentMenu(null)]
	public sealed class RecRoomObjectPrefabRegistry : RecRoomObjectPrefabRegistryBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x77B6420", Offset = "0x77B4E20", VA = "0x1877B6420")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public sealed class RecRoomObjectPrefabEntry : RecRoomObjectPrefabEntryBase<RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x77B63A0", Offset = "0x77B4DA0", VA = "0x1877B63A0")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class RecRoomObjectPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x77B63E0", Offset = "0x77B4DE0", VA = "0x1877B63E0")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[AddComponentMenu("Rec Room Studio/Animator Synchronizer (Rec Room Studio)")]
	[RequireComponent(typeof(Animator))]
	public class RecRoomStudioAnimatorSynchronizer : RecRoomStudioAnimatorSynchronizerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public RecRoomStudioAnimatorSynchronizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AddComponentMenu("Rec Room Studio/Billboard (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioBillboard : RecRoomStudioBillboardBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x77B6470", Offset = "0x77B4E70", VA = "0x1877B6470")]
		public RecRoomStudioBillboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Rec Room Studio/Canvas Interaction (Rec Room Studio)")]
	public sealed class RecRoomStudioCanvasInteraction : RecRoomStudioCanvasInteractionBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public RecRoomStudioCanvasInteraction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[AddComponentMenu("Rec Room Studio/Disable Render In Share Camera Photo (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioDisableRenderInShareCamPhoto : RecRoomStudioDisableRenderInShareCamPhotoBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public RecRoomStudioDisableRenderInShareCamPhoto()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Rec Room Studio/HUD Canvas (Rec Room Studio)")]
	public sealed class RecRoomStudioHudCanvas : RecRoomStudioHudCanvasBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public RecRoomStudioHudCanvas()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[AddComponentMenu("Rec Room Studio/Instance Recolor (Rec Room Studio)")]
	public sealed class RecRoomStudioInstanceRecolor : RecRoomStudioInstanceRecolorBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x77B6480", Offset = "0x77B4E80", VA = "0x1877B6480")]
		public RecRoomStudioInstanceRecolor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioNavMeshCut : RecRoomStudioNavMeshCutBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x77B64D0", Offset = "0x77B4ED0", VA = "0x1877B64D0")]
		public RecRoomStudioNavMeshCut()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[AddComponentMenu(null)]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioPlatformTextFilter : RecRoomStudioPlatformTextFilterBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public RecRoomStudioPlatformTextFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[AddComponentMenu("Rec Room Studio/Rec Net Image (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioRecNetImage : RecRoomStudioRecNetImageBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public RecRoomStudioRecNetImage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu(null)]
	public sealed class RecRoomVisualPostProcessing : RecRoomVisualPostProcessingBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
		public RecRoomVisualPostProcessing()
		{
		}
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[AddComponentMenu("Rec Room Studio/Avatar Item (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioAvatarItem : RecRoomStudioAvatarItemBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8C9250", Offset = "0x8C7C50", VA = "0x1808C9250")]
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
