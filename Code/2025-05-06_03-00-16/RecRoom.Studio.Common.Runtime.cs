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
		[Cpp2IlInjected.Address(RVA = "0x9DECA0", Offset = "0x9DD4A0", VA = "0x1809DECA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFC70", Offset = "0x85DE470", VA = "0x1885DFC70")]
		public MaterialMap()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class MaterialMapAsset : MaterialMapAssetBase<MaterialMapAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85DFC30", Offset = "0x85DE430", VA = "0x1885DFC30")]
		public MaterialMapAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[AddComponentMenu(null)]
	public sealed class RecRoomAudioClipRegistry : RecRoomAudioClipRegistryBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x85DFFC0", Offset = "0x85DE7C0", VA = "0x1885DFFC0")]
		public RecRoomAudioClipRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecRoomAudioClipRegistryAsset : RecRoomAudioClipRegistryAssetBase<RecRoomAudioClipRegistryAsset>
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85DFF80", Offset = "0x85DE780", VA = "0x1885DFF80")]
		public RecRoomAudioClipRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[AddComponentMenu(null)]
	public sealed class RecRoomAudioMixerRegistry : RecRoomAudioMixerRegistryBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
		public RecRoomAudioMixerRegistry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class RecRoomAudioMixerRegistryAsset : RecRoomAudioMixerRegistryAssetBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD58E20", Offset = "0xD57620", VA = "0x180D58E20")]
		public RecRoomAudioMixerRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[AddComponentMenu(null)]
	public sealed class RecRoomBuiltInObject : RecRoomBuiltInObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
		public RecRoomBuiltInObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RecRoomBuiltInObjectData : RecRoomBuiltInObjectDataBase<RecRoomBuiltInObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85E0000", Offset = "0x85DE800", VA = "0x1885E0000")]
		public RecRoomBuiltInObjectData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DisallowMultipleComponent]
	[SerializedTypeName]
	[AddComponentMenu("Rec Room Studio/Studio Object (Rec Room Studio)")]
	public sealed class RecRoomObject : RecRoomObjectBase
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85E0100", Offset = "0x85DE900", VA = "0x1885E0100")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFD00", Offset = "0x85DE500", VA = "0x1885DFD00")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFCB0", Offset = "0x85DE4B0", VA = "0x1885DFCB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFD50", Offset = "0x85DE550", VA = "0x1885DFD50")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFDA0", Offset = "0x85DE5A0", VA = "0x1885DFDA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFE40", Offset = "0x85DE640", VA = "0x1885DFE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFDF0", Offset = "0x85DE5F0", VA = "0x1885DFDF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFE90", Offset = "0x85DE690", VA = "0x1885DFE90")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFEE0", Offset = "0x85DE6E0", VA = "0x1885DFEE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DFF30", Offset = "0x85DE730", VA = "0x1885DFF30")]
		public NamedUnityStringStringEvent()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[AddComponentMenu(null)]
	public sealed class RecRoomObjectPrefabRegistry : RecRoomObjectPrefabRegistryBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x85E00C0", Offset = "0x85DE8C0", VA = "0x1885E00C0")]
		public RecRoomObjectPrefabRegistry()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public sealed class RecRoomObjectPrefabEntry : RecRoomObjectPrefabEntryBase<RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85E0040", Offset = "0x85DE840", VA = "0x1885E0040")]
		public RecRoomObjectPrefabEntry()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public sealed class RecRoomObjectPrefabRegistryAsset : RecRoomObjectPrefabRegistryAssetBase<RecRoomObjectPrefabRegistryAsset, RecRoomObjectPrefabEntry, RecRoomObject>
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85E0080", Offset = "0x85DE880", VA = "0x1885E0080")]
		public RecRoomObjectPrefabRegistryAsset()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[AddComponentMenu("Rec Room Studio/Animator Synchronizer (Rec Room Studio)")]
	[RequireComponent(typeof(Animator))]
	public class RecRoomStudioAnimatorSynchronizer : RecRoomStudioAnimatorSynchronizerBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
		public RecRoomStudioAnimatorSynchronizer()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[AddComponentMenu("Rec Room Studio/Billboard (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioBillboard : RecRoomStudioBillboardBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x85E0110", Offset = "0x85DE910", VA = "0x1885E0110")]
		public RecRoomStudioBillboard()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Rec Room Studio/Canvas Interaction (Rec Room Studio)")]
	public sealed class RecRoomStudioCanvasInteraction : RecRoomStudioCanvasInteractionBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
		public RecRoomStudioCanvasInteraction()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[AddComponentMenu("Rec Room Studio/Disable Render In Share Camera Photo (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioDisableRenderInShareCamPhoto : RecRoomStudioDisableRenderInShareCamPhotoBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
		public RecRoomStudioDisableRenderInShareCamPhoto()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RequireComponent(typeof(Canvas))]
	[AddComponentMenu("Rec Room Studio/HUD Canvas (Rec Room Studio)")]
	public sealed class RecRoomStudioHudCanvas : RecRoomStudioHudCanvasBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
		public RecRoomStudioHudCanvas()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[AddComponentMenu("Rec Room Studio/Instance Recolor (Rec Room Studio)")]
	public sealed class RecRoomStudioInstanceRecolor : RecRoomStudioInstanceRecolorBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85E0120", Offset = "0x85DE920", VA = "0x1885E0120")]
		public RecRoomStudioInstanceRecolor()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioNavMeshCut : RecRoomStudioNavMeshCutBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x85E0170", Offset = "0x85DE970", VA = "0x1885E0170")]
		public RecRoomStudioNavMeshCut()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[AddComponentMenu(null)]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioPlatformTextFilter : RecRoomStudioPlatformTextFilterBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
		public RecRoomStudioPlatformTextFilter()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[AddComponentMenu("Rec Room Studio/Rec Net Image (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioRecNetImage : RecRoomStudioRecNetImageBase
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85E0180", Offset = "0x85DE980", VA = "0x1885E0180")]
		public RecRoomStudioRecNetImage()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[AddComponentMenu(null)]
	public sealed class RecRoomVisualPostProcessing : RecRoomVisualPostProcessingBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
		public RecRoomVisualPostProcessing()
		{
		}
	}
}
namespace RecRoom.Core.Studio.AvatarItems
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[AddComponentMenu("Rec Room Studio/Avatar Item (Rec Room Studio)")]
	[DisallowMultipleComponent]
	public sealed class RecRoomStudioAvatarItem : RecRoomStudioAvatarItemBase
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9FB990", Offset = "0x9FA190", VA = "0x1809FB990")]
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
