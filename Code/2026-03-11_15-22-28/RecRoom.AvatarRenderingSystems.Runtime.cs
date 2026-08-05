using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.AI.RoomieAI;
using RecRoom.AssetIds;
using RecRoom.Async;
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.AvatarEffectsDataTypes;
using RecRoom.Avatars.Data.Runtime;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Avatars.Face;
using RecRoom.Core;
using RecRoom.Core.DataStructures.Tokens;
using RecRoom.Core.Scripts.DataStructures;
using RecRoom.Core.Studio;
using RecRoom.DataLayer;
using RecRoom.DataStructures.ResourceHandles;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using RecRoom.Protobuf;
using RecRoom.Rendering;
using RecRoom.Utils.Image;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A10", Offset = "0xAF4A10", VA = "0x180AF5A10")]
		public NullableAttribute(byte[] P_0)
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
		[Cpp2IlInjected.Address(RVA = "0xAF5A50", Offset = "0xAF4A50", VA = "0x180AF5A50")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82CDE30", Offset = "0x82CCE30", VA = "0x1882CDE30", Slot = "4")]
		public override void BPSMAKIBARY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF57C0", Offset = "0xAF47C0", VA = "0x180AF57C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private RecNetCDNKey MFGYHTMRNRY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RecNetCDNKey TypedRuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F50", Offset = "0xAD1F50", VA = "0x180AD2F50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC94260", Offset = "0xC93260", VA = "0x180C94260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82CDEF0", Offset = "0x82CCEF0", VA = "0x1882CDEF0", Slot = "19")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82CDF20", Offset = "0x82CCF20", VA = "0x1882CDF20")]
		public RecNetCDNAssetReference(RecNetCDNKey key)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public enum ItemPathHint : byte
		{
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			Bundle,
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			Prefab,
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			MaterialMap
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string BundleFilename
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F60", Offset = "0xAD1F60", VA = "0x180AD2F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xACDA20", Offset = "0xACCA20", VA = "0x180ACDA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F30", Offset = "0xAD1F30", VA = "0x180AD2F30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xACDA30", Offset = "0xACCA30", VA = "0x180ACDA30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB25800", Offset = "0xB24800", VA = "0x180B25800")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB25890", Offset = "0xB24890", VA = "0x180B25890")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ItemPathHint PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCE9450", Offset = "0xCE8450", VA = "0x180CE9450")]
			[CompilerGenerated]
			get
			{
				return default(ItemPathHint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD233E0", Offset = "0xD223E0", VA = "0x180D233E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x82CE030", Offset = "0x82CD030", VA = "0x1882CE030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x82CDF60", Offset = "0x82CCF60", VA = "0x1882CDF60")]
		public static RecNetCDNKey QWNHZDODMQD(string a, ItemPathHint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x82CDFE0", Offset = "0x82CCFE0", VA = "0x1882CDFE0")]
		public void SUCABXLNNXC(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public RecNetCDNKey()
		{
		}
	}
}
namespace RecRoom.AI.RoomieAI
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomieAvatarDisplay : AvatarDisplayBase, NVMYCLIJNAG
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct EquipResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public IEnumerable<LOMDNFCRWZO> equippedItems;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public DisplayItemData roomieEquipment;
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public class DisplayItemData
		{
			[Cpp2IlInjected.Token(Token = "0x17000018")]
			public Guid CustomAvatarItemId
			{
				[Cpp2IlInjected.Token(Token = "0x6000070")]
				[Cpp2IlInjected.Address(RVA = "0xC9D7C0", Offset = "0xC9C7C0", VA = "0x180C9D7C0")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public RoomieBodyPart Bodypart
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xADC530", Offset = "0xADB530", VA = "0x180ADC530")]
				[CompilerGenerated]
				get
				{
					return default(RoomieBodyPart);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Vector3? Rotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xC16FD0", Offset = "0xC15FD0", VA = "0x180C16FD0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			public Color? Color
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(RVA = "0x82CDE10", Offset = "0x82CCE10", VA = "0x1882CDE10")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x82CDDB0", Offset = "0x82CCDB0", VA = "0x1882CDDB0")]
			public DisplayItemData(Guid customAvatarItemId, Vector3? rotation, Color? color, RoomieBodyPart part)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <AvatarRuntimeBuildMeshRoutine>d__125 : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private ADJUPIXYSVF <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public List<PLPNZYMYIXH> parts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public RoomieAvatarDisplay <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public List<LVFVDSAYAGN> innerPromises;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public int[] LODs;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public bool isFirstPerson;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public Func<int, Layers> getLayer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int <lodIndex>5__2;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private ADJUPIXYSVF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public <AvatarRuntimeBuildMeshRoutine>d__125(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x82D39D0", Offset = "0x82D29D0", VA = "0x1882D39D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x82D3C00", Offset = "0x82D2C00", VA = "0x1882D3C00", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static int[] RoomieLODLevels;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private Transform _hatBone;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Material[] _bodyMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private bool hideRoomieAvatar;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private GameObject _thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private AssetReference _skinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private SkinnedMeshRenderer _baseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private AvatarSkinnedMeshBoneOrderRemapsData _boneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private IReadOnlyDictionary<string, Transform> _boneNameMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Transform _deformRigRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private Transform[] _baseSkinnedBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Matrix4x4[] _baseSkinnedBindingPoses;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public bool _isLoading;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0xE1")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public bool _HasEverBeenBuilt;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private SkinnedMeshRenderer[] _currentThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private SkinnedMeshRenderer[] _nextThirdPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private readonly List<EUUFFSOTBPK> _nextPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<EUUFFSOTBPK> _currentPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<EUUFFSOTBPK> _nextMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<EUUFFSOTBPK> _currentMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<DisplayItemData> _EquippedDisplayItemOutfitSelections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly IList<LOMDNFCRWZO> _currentEquippedOutfitSelections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private List<Action> _queuedCustomizationActions;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly int RoomieMaterialBaseColorProperty;

		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private static readonly int RoomieEffectsBaseColorProperty;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static readonly int RoomieEffectsBoostIntensityProperty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private readonly Dictionary<(RoomieBodyPart bodyPart, Material sharedMaterial), Material> _currentSharedToInstanceLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Dictionary<(RoomieBodyPart bodyPart, Material sharedMaterial), Material> _nextSharedToInstanceLookup;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Dictionary<RoomieBodyPart, Color> RoomieCustomizedColors;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Dictionary<RoomieBodyPart, PositionAndRotation> RoomieCustomizedTransformPerPart;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private Color _RoomiePrimarySkinColor;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private Color _RoomieSecondarySkinColor;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private float _RoomieBoostPower;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private readonly ZUUFDARDSJN _buildCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly ZUUFDARDSJN _buildCancelled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private SkinnedMeshRenderer[] _cachedBuiltBodySkinMeshes;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ZUUFDARDSJN DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xB50C70", Offset = "0xB4FC70", VA = "0x180B50C70", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ZUUFDARDSJN DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xD06330", Offset = "0xD05330", VA = "0x180D06330", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xAE9570", Offset = "0xAE8570", VA = "0x180AE9570", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x82D39B0", Offset = "0x82D29B0", VA = "0x1882D39B0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xD06320", Offset = "0xD05320", VA = "0x180D06320", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBDC620", Offset = "0xBDB620", VA = "0x180BDC620", Slot = "35")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform HatBone
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ZUUFDARDSJN OnAnimationCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x82D3970", Offset = "0x82D2970", VA = "0x1882D3970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x82D3860", Offset = "0x82D2860", VA = "0x1882D3860", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PositionAndRotation HatPivotLocalPosAndRot
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x82D38A0", Offset = "0x82D28A0", VA = "0x1882D38A0", Slot = "56")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public BPYBHDTBBFD.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x82D3810", Offset = "0x82D2810", VA = "0x1882D3810", Slot = "32")]
			get
			{
				return default(BPYBHDTBBFD.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82CE690", Offset = "0x82CD690", VA = "0x1882CE690", Slot = "51")]
		protected virtual LOMDNFCRWZO AvatarItemDefinitionFromDisplayItemDefinition(DisplayItemData displayItemData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82D0E20", Offset = "0x82CFE20", VA = "0x1882D0E20")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82D3140", Offset = "0x82D2140", VA = "0x1882D3140")]
		private void _UpdateManualLod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82D13C0", Offset = "0x82D03C0", VA = "0x1882D13C0")]
		private void QueuePostBuiltAvatarCustomizationUpdate(Action updateMatPropertAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82CE5C0", Offset = "0x82CD5C0", VA = "0x1882CE5C0")]
		private void ApplyQueuedCustomizationUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82CE0A0", Offset = "0x82CD0A0", VA = "0x1882CE0A0")]
		private void ApplyColorsToInstances()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x82D07B0", Offset = "0x82CF7B0", VA = "0x1882D07B0", Slot = "28")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x82D0D10", Offset = "0x82CFD10", VA = "0x1882D0D10")]
		private PositionAndRotation GetHatAdjustmentOrDefault()
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82CE460", Offset = "0x82CD460", VA = "0x1882CE460", Slot = "45")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82D0DF0", Offset = "0x82CFDF0", VA = "0x1882D0DF0", Slot = "48")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82D11C0", Offset = "0x82D01C0", VA = "0x1882D11C0")]
		public Task PlayAnimation(string animationName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82D2930", Offset = "0x82D1930", VA = "0x1882D2930", Slot = "17")]
		public void SetUgcItemVisualOverrides(LOMDNFCRWZO overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82D29B0", Offset = "0x82D19B0", VA = "0x1882D29B0", Slot = "18")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82D2970", Offset = "0x82D1970", VA = "0x1882D2970", Slot = "19")]
		public void SetUgcTextureParameters(RHKGGBGWUKB parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x82D3000", Offset = "0x82D2000", VA = "0x1882D3000", Slot = "49")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x82D3100", Offset = "0x82D2100", VA = "0x1882D3100", Slot = "50")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties effectFloat4Properties, TextureEffectMaterialTextures effectTexture2DProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82D1670", Offset = "0x82D0670", VA = "0x1882D1670", Slot = "46")]
		public void SetHatAnchorParams(WPRKLXHPVNO anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82D3080", Offset = "0x82D2080", VA = "0x1882D3080", Slot = "47")]
		public void UpdateHatPivot([Optional] WPRKLXHPVNO anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82CE650", Offset = "0x82CD650", VA = "0x1882CE650", Slot = "23")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82D2B20", Offset = "0x82D1B20", VA = "0x1882D2B20")]
		public void Setup([In] AvatarDisplaySetupState _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x82D14B0", Offset = "0x82D04B0", VA = "0x1882D14B0", Slot = "33")]
		public bool SetBaseSkinCullingMask(BPYBHDTBBFD.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x82D1570", Offset = "0x82D0570", VA = "0x1882D1570", Slot = "20")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82D28B0", Offset = "0x82D18B0", VA = "0x1882D28B0", Slot = "21")]
		public void SetSkinColors(Color skinColor, Color? skinEmissiveColor, float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x82D0500", Offset = "0x82CF500", VA = "0x1882D0500", Slot = "27")]
		public LVFVDSAYAGN BuildPotatoAvatar(LSYZGHDZEVS avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82D28F0", Offset = "0x82D18F0", VA = "0x1882D28F0", Slot = "22")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x82D1630", Offset = "0x82D0630", VA = "0x1882D1630")]
		public void SetFaceShape(AvatarFaceShape faceShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x82D1530", Offset = "0x82D0530", VA = "0x1882D1530")]
		public void SetBodyShape(AvatarBodyShape bodyShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82D14F0", Offset = "0x82D04F0", VA = "0x1882D14F0", Slot = "37")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x82CE060", Offset = "0x82CD060", VA = "0x1882CE060", Slot = "38")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82D15F0", Offset = "0x82D05F0", VA = "0x1882D15F0", Slot = "39")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x82D16D0", Offset = "0x82D06D0", VA = "0x1882D16D0", Slot = "40")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82CE420", Offset = "0x82CD420", VA = "0x1882CE420", Slot = "41")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x82CE580", Offset = "0x82CD580", VA = "0x1882CE580", Slot = "42")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x82D1710", Offset = "0x82D0710", VA = "0x1882D1710")]
		public void SetNoseType(NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82D15B0", Offset = "0x82D05B0", VA = "0x1882D15B0", Slot = "43")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x82D3040", Offset = "0x82D2040", VA = "0x1882D3040", Slot = "44")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82D30C0", Offset = "0x82D20C0", VA = "0x1882D30C0", Slot = "53")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x82D07B0", Offset = "0x82CF7B0", VA = "0x1882D07B0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xD064B0", Offset = "0xD054B0", VA = "0x180D064B0", Slot = "54")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayThirdPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "55")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayFirstPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82CE460", Offset = "0x82CD460", VA = "0x1882CE460")]
		public void OnLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x82D1220", Offset = "0x82D0220", VA = "0x1882D1220")]
		private void PostOutfitUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82D1200", Offset = "0x82D0200", VA = "0x1882D1200")]
		private void PostMeshBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82D16B0", Offset = "0x82D06B0", VA = "0x1882D16B0", Slot = "16")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x82D2600", Offset = "0x82D1600", VA = "0x1882D2600")]
		public void SetRoomieBoostCustomizationFloat(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x82D26F0", Offset = "0x82D16F0", VA = "0x1882D26F0")]
		public void SetRoomiePrimarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82D27D0", Offset = "0x82D17D0", VA = "0x1882D27D0")]
		public void SetRoomieSecondarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82D1750", Offset = "0x82D0750", VA = "0x1882D1750")]
		public Task<EquipResult> SetOutfitSelection(IReadOnlyList<DisplayItemData> displayItemDatas, bool forceBuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82D0540", Offset = "0x82CF540", VA = "0x1882D0540")]
		private List<LOMDNFCRWZO> CreateEquippedItemsFrorOutfitSelection(IReadOnlyList<Guid> customAvatarItemIds, IReadOnlyList<DisplayItemData> correspondingDADs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x82CF0D0", Offset = "0x82CE0D0", VA = "0x1882CF0D0", Slot = "26")]
		public LVFVDSAYAGN BuildAvatarMeshes(LSYZGHDZEVS avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, LOMDNFCRWZO>, (LVFVDSAYAGN, VKQMZHJZWXK<Dictionary<string, TEHJZDMBIST<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x82D0C10", Offset = "0x82CFC10", VA = "0x1882D0C10")]
		private bool GetCustomizationRequiresMeshBuild(List<DisplayItemData> newItemSelections)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82D2E80", Offset = "0x82D1E80", VA = "0x1882D2E80")]
		private void TeardownInProgressBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82CEB20", Offset = "0x82CDB20", VA = "0x1882CEB20")]
		public LVFVDSAYAGN BuildAvatarMeshesInternal(LSYZGHDZEVS avatarBuildParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x82D2B60", Offset = "0x82D1B60", VA = "0x1882D2B60")]
		private void SwapActiveResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x82D1460", Offset = "0x82D0460", VA = "0x1882D1460")]
		private void ReleasePrefabs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x82D0A90", Offset = "0x82CFA90", VA = "0x1882D0A90")]
		private void FinalizeRoomieDisplayUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x82D1160", Offset = "0x82D0160", VA = "0x1882D1160")]
		private bool IsReadyToBuildLODMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x82D0880", Offset = "0x82CF880", VA = "0x1882D0880")]
		private LVFVDSAYAGN EditorBuildMeshes(bool isFirstPerson, List<PLPNZYMYIXH> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x82D29F0", Offset = "0x82D19F0", VA = "0x1882D29F0")]
		private void SetupNewlyCreatedMesh(SkinnedMeshRenderer lodRenderer, int lod, Mesh mesh, List<Material> newUniqueMaterials)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x82CF0E0", Offset = "0x82CE0E0", VA = "0x1882CF0E0")]
		private ALZORZCQSFK BuildLODMesh(List<PLPNZYMYIXH> parts, int lod, bool isFirstPerson, Layers layer, bool IsSpreadAcrossFrames = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x82CEA40", Offset = "0x82CDA40", VA = "0x1882CEA40")]
		[IteratorStateMachine(typeof(<AvatarRuntimeBuildMeshRoutine>d__125))]
		private IEnumerator<ADJUPIXYSVF> AvatarRuntimeBuildMeshRoutine(bool isFirstPerson, List<PLPNZYMYIXH> parts, int[] LODs, Func<int, Layers> getLayer, List<LVFVDSAYAGN> innerPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x82D0240", Offset = "0x82CF240", VA = "0x1882D0240")]
		private LVFVDSAYAGN BuildLODMeshes(bool isFirstPerson, List<PLPNZYMYIXH> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x82D3370", Offset = "0x82D2370", VA = "0x1882D3370")]
		public RoomieAvatarDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x82D1440", Offset = "0x82D0440", VA = "0x1882D1440", Slot = "14")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x82D1450", Offset = "0x82D0450", VA = "0x1882D1450", Slot = "15")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Setup([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Tested]
	public class UCDQZUWCUXH : TVEZBKWKSWB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly List<Mesh> AMNPAEAVATV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		protected readonly List<IReadOnlyList<byte>> AYHCIJZOORT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		protected readonly List<Matrix4x4> HCCAFHYCZBU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly List<bool> WKYVEENNLAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly List<long> QWMSCBJDXDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		protected readonly List<bool> CKXYNLBCMRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		protected readonly List<int> FZUNUZYMUIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected Allocator NHSLPICLOEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected MeshMergeModes BNUUVVROBXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected byte JIBSMUWLLVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected IList<int> ENXCEJUVJIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected IList<int> FNKQRFSJCOL;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x82D4E80", Offset = "0x82D3E80", VA = "0x1882D4E80", Slot = "4")]
		public void QCCDJGQMHEH(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, BPYBHDTBBFD.SkinCullingMask e = (BPYBHDTBBFD.SkinCullingMask)0L, int f = -1, bool g = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x82D4E40", Offset = "0x82D3E40", VA = "0x1882D4E40", Slot = "5")]
		public void CPOTQVXUPXZ(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x82D4BE0", Offset = "0x82D3BE0", VA = "0x1882D4BE0")]
		private static void AXMJNBHQJIX(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x82D5240", Offset = "0x82D4240", VA = "0x1882D5240")]
		public UCDQZUWCUXH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[Tested]
	public struct AvatarCullAndCombineMeshJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		[ReadOnly]
		public AvatarCullAndCombineMeshJobGroup JobMeshesGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		[ReadOnly]
		public int MaxUberIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public AvatarCullAndCombineMeshJobContainer CulledAndCombinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x82BCFE0", Offset = "0x82BBFE0", VA = "0x1882BCFE0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[Tested]
	[NativeContainer]
	public struct AvatarCullAndCombineMeshJobContainer : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public struct VertexVaryingData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			public Vector3 vertex;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x4000095")]
			public Vector3 normal;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000096")]
			public Vector4 tangent;
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct VertexBoneWeightSemioptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000097")]
			public float boneWeight0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000098")]
			public float boneWeight1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000099")]
			public float boneWeight2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public float boneWeight3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public byte boneIndex0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public byte boneIndex1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public byte boneIndex2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public byte boneIndex3;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public struct VertexBoneWeightOptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public half boneWeight0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public half boneWeight1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public half boneWeight2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public half boneWeight3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public byte boneIndex0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public byte boneIndex1;

			[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public byte boneIndex2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public byte boneIndex3;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public struct VertexUnvarying1UVsOptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public half4 color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public half2 uv0;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public half4 uv5;
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public struct VertexUnvarying2UVsOptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public half4 color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public half2 uv0;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public half2 uv1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public half4 uv5;
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public struct VertexUnvarying3UVsOptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public half4 color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public half2 uv0;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public half2 uv1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public half2 uv2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public half4 uv5;
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public struct VertexUnvarying4UVsOptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public half4 color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public half2 uv0;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public half2 uv1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public half2 uv2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public half2 uv3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public half4 uv5;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct VertexBoneWeightUnoptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public float boneWeight0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public float boneWeight1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public float boneWeight2;

			[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public float boneWeight3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int boneIndex0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public int boneIndex1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public int boneIndex2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public int boneIndex3;
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public struct VertexUnvarying1UVsUnoptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public Vector2 uv0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Vector4 uv5;
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public struct VertexUnvarying2UVsUnoptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public Vector2 uv0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public Vector2 uv1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public Vector4 uv5;
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct VertexUnvarying3UVsUnoptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public Vector2 uv0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public Vector2 uv1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000CB")]
			public Vector2 uv2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000CC")]
			public Vector4 uv5;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public struct VertexUnvarying4UVsUnoptimizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CD")]
			public Color color;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			public Vector2 uv0;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public Vector2 uv1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Vector2 uv2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public Vector2 uv3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public Vector4 uv5;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private bool _platformSupportsOptimizedVertexAttributes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public NativeArray<VertexVaryingData> culledAndCombinedVertexVaryingDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public NativeArray<VertexUnvarying1UVsOptimizedData> culledAndCombinedVertexUnvarying1UVsOptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public NativeArray<VertexUnvarying2UVsOptimizedData> culledAndCombinedVertexUnvarying2UVsOptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public NativeArray<VertexUnvarying3UVsOptimizedData> culledAndCombinedVertexUnvarying3UVsOptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public NativeArray<VertexUnvarying4UVsOptimizedData> culledAndCombinedVertexUnvarying4UVsOptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		public NativeArray<VertexBoneWeightOptimizedData> culledAndCombinedVertexBoneWeightOptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public NativeArray<VertexBoneWeightSemioptimizedData> culledAndCombinedVertexBoneWeightSemioptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		public NativeArray<VertexUnvarying1UVsUnoptimizedData> culledAndCombinedVertexUnvarying1UVsUnoptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NativeArray<VertexUnvarying2UVsUnoptimizedData> culledAndCombinedVertexUnvarying2UVsUnoptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NativeArray<VertexUnvarying3UVsUnoptimizedData> culledAndCombinedVertexUnvarying3UVsUnoptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public NativeArray<VertexUnvarying4UVsUnoptimizedData> culledAndCombinedVertexUnvarying4UVsUnoptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public NativeArray<VertexBoneWeightUnoptimizedData> culledAndCombinedVertexBoneWeightUnoptimizedDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public NativeArray<int> culledAndCombinedTriangles;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public NativeArray<int> culledMeshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private NativeArray<int> postMergeSubMeshTriOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private NativeArray<int> postMergeSubMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public NativeArray<int> culledSubMeshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public NativeArray<int> culledSubMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public NativeArray<int> vertexCullingIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public NativeArray<BoneWeight> boneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private NativeArray<int> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool semiOptimizedBoneWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public int EUAOWNQEFFH
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x82BADD0", Offset = "0x82B9DD0", VA = "0x1882BADD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x82BAE60", Offset = "0x82B9E60", VA = "0x1882BAE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int CZUTHNLJNSP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x82B8660", Offset = "0x82B7660", VA = "0x1882B8660")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x82BAD30", Offset = "0x82B9D30", VA = "0x1882BAD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int KDMXNYQYHBL
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x82BADF0", Offset = "0x82B9DF0", VA = "0x1882BADF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x82B93F0", Offset = "0x82B83F0", VA = "0x1882B93F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int DGHQFTWAATA
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x82BACC0", Offset = "0x82B9CC0", VA = "0x1882BACC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x82BAE70", Offset = "0x82B9E70", VA = "0x1882BAE70")]
		public AvatarCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels, WNKBMJSWCPH systemInfoAccess, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x82BAD40", Offset = "0x82B9D40", VA = "0x1882BAD40")]
		public void QORMHRKVCDD(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x82B9400", Offset = "0x82B8400", VA = "0x1882B9400")]
		public void KYGHMIHFBGB(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x82B9A80", Offset = "0x82B8A80", VA = "0x1882B9A80")]
		public Color LVIHGLKVGYS(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x82B8A50", Offset = "0x82B7A50", VA = "0x1882B8A50")]
		public void CDWGIMRFDRQ(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x82B90F0", Offset = "0x82B80F0", VA = "0x1882B90F0")]
		public void FMMKOZPQRRI(int a, Vector3 b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x82B92A0", Offset = "0x82B82A0", VA = "0x1882B92A0")]
		public void HWDZIQWSHOE(int a, half4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x82B9830", Offset = "0x82B8830", VA = "0x1882B9830")]
		public void LSAEOXXHOUG(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x82B8670", Offset = "0x82B7670", VA = "0x1882B8670")]
		public void BRPBWVXSFJC(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x82BADE0", Offset = "0x82B9DE0", VA = "0x1882BADE0")]
		public void SWGFMVYLKHF(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x82BAE00", Offset = "0x82B9E00", VA = "0x1882BAE00")]
		public bool WETXYCDSELK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x82B91E0", Offset = "0x82B81E0", VA = "0x1882B91E0")]
		public void FVVVKTFJOCY(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x82B8E90", Offset = "0x82B7E90", VA = "0x1882B8E90", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x82B9DA0", Offset = "0x82B8DA0", VA = "0x1882B9DA0")]
		public Mesh NBKQCMSBPPB([Optional] string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Tested]
	[NativeContainer]
	public struct AvatarCullAndCombineMeshJobGroup : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public Mesh.MeshDataArray meshDataArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public NativeArray<int> meshParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public NativeArray<int> meshVertStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public NativeArray<BoneWeight> boneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private NativeArray<Matrix4x4> meshTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private NativeArray<long> meshCullingBitMasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private NativeArray<byte> meshRemapBoneOrderArrays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private NativeArray<int> meshNumSubMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private NativeArray<int> meshGlobalSubMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public NativeArray<sbyte> subMeshUberMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		public NativeArray<byte> subMeshMaterialIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public NativeArray<bool> flipTris;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public NativeArray<int> boneWeightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private bool semiOptimizedBoneWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		private NativeArray<int> Params;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public int HULDQAKVTXV
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x82BBBF0", Offset = "0x82BABF0", VA = "0x1882BBBF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int WQGCCUUFQSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC70", Offset = "0x82BAC70", VA = "0x1882BBC70")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int VNLCTDPOUZW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x82BBB20", Offset = "0x82BAB20", VA = "0x1882BBB20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int MOBXNRXAHZL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC00", Offset = "0x82BAC00", VA = "0x1882BBC00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x82BB970", Offset = "0x82BA970", VA = "0x1882BB970")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int EUAOWNQEFFH
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC20", Offset = "0x82BAC20", VA = "0x1882BBC20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC60", Offset = "0x82BAC60", VA = "0x1882BBC60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int HDDXDZSRTLK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC40", Offset = "0x82BAC40", VA = "0x1882BBC40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC50", Offset = "0x82BAC50", VA = "0x1882BBC50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MeshMergeModes PDMLPYSECTD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x82BBB10", Offset = "0x82BAB10", VA = "0x1882BBB10")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC10", Offset = "0x82BAC10", VA = "0x1882BBC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public byte ZBPOOAMFTFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x82BBB00", Offset = "0x82BAB00", VA = "0x1882BBB00")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x82BBC30", Offset = "0x82BAC30", VA = "0x1882BBC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public AvatarCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x82BCD90", Offset = "0x82BBD90", VA = "0x1882BCD90")]
			get
			{
				return default(AvatarCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x82BBC80", Offset = "0x82BAC80", VA = "0x1882BBC80")]
		public AvatarCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x82BB8A0", Offset = "0x82BA8A0", VA = "0x1882BB8A0")]
		public AvatarCullAndCombineMeshJobContainer CGKUESNJNID(Allocator a, WNKBMJSWCPH b)
		{
			return default(AvatarCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x82BB980", Offset = "0x82BA980", VA = "0x1882BB980", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Tested]
	public class VZCVWOLDSOC : UCDQZUWCUXH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool HBEOALDUTCH;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly ProfilerMarker DHYTXMHPJHA;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x82D5450", Offset = "0x82D4450", VA = "0x1882D5450")]
		public AvatarCullAndCombineMeshJobGroup AHUIIXBMPZD()
		{
			return default(AvatarCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x82D56E0", Offset = "0x82D46E0", VA = "0x1882D56E0")]
		public VZCVWOLDSOC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct AvatarCullAndCombineMeshSlice
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Mesh.MeshData meshData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public NativeSlice<BoneWeight> boneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public NativeSlice<byte> materialIDs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public int NumSubMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public Matrix4x4 MeshTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public long CullingBitMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public NativeSlice<byte> remapBoneOrderArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public bool FlipTris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int BoneWeightOverride;
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[DisallowMultipleComponent]
	public class AvatarDisplayBase : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public enum LODSelection : byte
		{
			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			All,
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			LOD0Only,
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			EditorToolAll
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public struct LodInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public bool knownGoodData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public long bytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public int numTris;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public float errorInMeters;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public LodInfo[] lodInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public UpdateLOD DistanceBand;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		protected LODSelection NAJZSZUAFTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		protected int[] RWUALKKWOCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int requestedLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		protected int MCWUWTUDGOJ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public readonly SkinnedMeshRenderer[] CurrentDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public readonly SkinnedMeshRenderer[] NextDefaultSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public readonly SkinnedMeshRenderer[] CurrentVisibleInFirstPersonSkinnedMeshRenderers;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public readonly SkinnedMeshRenderer[] NextVisibleInFirstPersonSkinnedMeshRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public float bboxDiameterInMeters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		protected NVMYCLIJNAG IPOPGXVJDAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		protected LVFVDSAYAGN KMLWPCMZQUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		protected (bool isLodForced, int forcedLOD) TFCCOREWHRI;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public virtual int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xAE9570", Offset = "0xAE8570", VA = "0x180AE9570", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD90110", Offset = "0xD8F110", VA = "0x180D90110", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool SEYHMMULXXS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x82BF460", Offset = "0x82BE460", VA = "0x1882BF460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public virtual bool CLFJFGUGFXA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static bool UIJGGKWYFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x82BF420", Offset = "0x82BE420", VA = "0x1882BF420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public NVMYCLIJNAG WRHNTLAFNOW
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xACDCA0", Offset = "0xACCCA0", VA = "0x180ACDCA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x82BF510", Offset = "0x82BE510", VA = "0x1882BF510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected LVFVDSAYAGN WOWHEYIVKOV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xAD82C0", Offset = "0xAD72C0", VA = "0x180AD82C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x82BF1A0", Offset = "0x82BE1A0", VA = "0x1882BF1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int MXEOOQSKTYV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x82BF810", Offset = "0x82BE810", VA = "0x1882BF810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AvatarBodyType HLCXCUJQAGL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x82BF3D0", Offset = "0x82BE3D0", VA = "0x1882BF3D0")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public virtual event Action YVWJJKVKKIS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x82BF330", Offset = "0x82BE330", VA = "0x1882BF330", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x82BF470", Offset = "0x82BE470", VA = "0x1882BF470", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x82BEF80", Offset = "0x82BDF80", VA = "0x1882BEF80", Slot = "8")]
		public virtual (bool, bool, bool) WhichLodsAreResident()
		{
			return default((bool, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "9")]
		public virtual void CheckMeshesAgainstDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x82BEDB0", Offset = "0x82BDDB0", VA = "0x1882BEDB0", Slot = "10")]
		public virtual (int, long, int) GetDisplayedLodInfo()
		{
			return default((int, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xE2A830", Offset = "0xE29830", VA = "0x180E2A830")]
		protected void QJITAJUMICG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x82BED30", Offset = "0x82BDD30", VA = "0x1882BED30")]
		protected void EVEGGRCJZKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1368ED0", Offset = "0x1367ED0", VA = "0x181368ED0")]
		protected void IDDJWGNGGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x82BEC80", Offset = "0x82BDC80", VA = "0x1882BEC80", Slot = "12")]
		public virtual Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x82BED40", Offset = "0x82BDD40", VA = "0x1882BED40")]
		protected void FMULLOOIBTN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x82BEEC0", Offset = "0x82BDEC0", VA = "0x1882BEEC0", Slot = "13")]
		protected virtual void WXLAFGASATJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x82BEE10", Offset = "0x82BDE10", VA = "0x1882BEE10")]
		public int MeshesAtLODCount(int LOD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x82BF230", Offset = "0x82BE230", VA = "0x1882BF230")]
		public AvatarDisplayBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarDisplaySystem : NVMYCLIJNAG
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class MPCWLLDWKRG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public AvatarDisplaySystem SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public Color MXINCPOXHAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Color? HDHQXVANLUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public float? KFGTIZJBQAM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public Action<AVZQJDBFRMS> VCIXSNDKWEJ;

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MPCWLLDWKRG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x82E3F10", Offset = "0x82E2F10", VA = "0x1882E3F10")]
			internal void RIYHOPFCPKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x82E4060", Offset = "0x82E3060", VA = "0x1882E4060")]
			internal void RJDOLVYZYVV(AVZQJDBFRMS a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class CDVNMSUAISX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public bool OYKCDULICSO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public bool SSGYSDONVFX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public AvatarDisplaySystem SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public LVFVDSAYAGN LSZOKBYILAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public Action<KeyValuePair<string, TEHJZDMBIST<Texture2D>>> USFRCUNVNGY;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public CDVNMSUAISX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x82E1440", Offset = "0x82E0440", VA = "0x1882E1440")]
			internal bool YHBPYXXTXWH(LOMDNFCRWZO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x82E1240", Offset = "0x82E0240", VA = "0x1882E1240")]
			internal bool BPPOYYTMOGR(LOMDNFCRWZO a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x82E1220", Offset = "0x82E0220", VA = "0x1882E1220")]
			internal void YGRCEKJZEZP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x82E1200", Offset = "0x82E0200", VA = "0x1882E1200")]
			internal void YFGFXPARQYE(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x82E1220", Offset = "0x82E0220", VA = "0x1882E1220")]
			internal void BOZUHELULYQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x82E1200", Offset = "0x82E0200", VA = "0x1882E1200")]
			internal void BOUNJXRXCNH(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x82E11D0", Offset = "0x82E01D0", VA = "0x1882E11D0")]
			internal void BOPGMQXZTBY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x82E11A0", Offset = "0x82E01A0", VA = "0x1882E11A0")]
			internal void BOJZPKECJQP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x82E12D0", Offset = "0x82E02D0", VA = "0x1882E12D0")]
			internal void BRFSDAWRLTL(Dictionary<string, TEHJZDMBIST<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x82E1380", Offset = "0x82E0380", VA = "0x1882E1380")]
			internal void HQIVKJCOSCS(KeyValuePair<string, TEHJZDMBIST<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAD05E0", Offset = "0xACF5E0", VA = "0x180AD05E0")]
			internal YTAUUGIQSDF BRALFUCUCIC()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class CDQGPMACZHO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public int FKDILTOPGMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public CDVNMSUAISX PYDAXWOHYEE;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public CDQGPMACZHO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x82E1140", Offset = "0x82E0140", VA = "0x1882E1140")]
			internal Layers YFLMUVUPAJN(int a)
			{
				return default(Layers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class CEGBHGHVBPP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public VKQMZHJZWXK<Dictionary<string, TEHJZDMBIST<Texture2D>>> MFEGVYNAUBW;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public CEGBHGHVBPP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			internal VKQMZHJZWXK<Dictionary<string, TEHJZDMBIST<Texture2D>>> BOESSDKFAFG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class XYEQGFFLWZY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public AvatarDisplaySystem SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public float TXSHKGHIMMQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public Color FOCJUGHWQFE;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public XYEQGFFLWZY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x82E9D20", Offset = "0x82E8D20", VA = "0x1882E9D20")]
			internal void JZBBMJSTJTW()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class UGWSJTRGBHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public List<LVFVDSAYAGN> AQAZBDIJUIP;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public UGWSJTRGBHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x82E68B0", Offset = "0x82E58B0", VA = "0x1882E68B0")]
			internal void ZNLHRUCTRVR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class WTIKDFWBJHY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public string WXFASTLDPGT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AvatarBodyPart DJOHBHSHXLA;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public WTIKDFWBJHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x82E9530", Offset = "0x82E8530", VA = "0x1882E9530")]
			internal bool IDNOITTTYLI(KeyValuePair<string, LOMDNFCRWZO> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class IHUROFIIVUV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public List<EUUFFSOTBPK> KNVZHLQQVRA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public List<EUUFFSOTBPK> AEHNOTOOKQD;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public IHUROFIIVUV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x82E3B70", Offset = "0x82E2B70", VA = "0x1882E3B70")]
			internal YTAUUGIQSDF NWHSNHCPQBY(PLPNZYMYIXH a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class IHPKQYOLMJM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public MAMNDJOCSXA BFCCBLHSHND;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public IHPKQYOLMJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xBFDAF0", Offset = "0xBFCAF0", VA = "0x180BFDAF0")]
			internal void NVXESTOUXFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xBFDAD0", Offset = "0xBFCAD0", VA = "0x180BFDAD0")]
			internal void NWCLQAISGQP(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class MTYRUVVTVJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public MAMNDJOCSXA BFCCBLHSHND;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public MTYRUVVTVJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xBFDAF0", Offset = "0xBFCAF0", VA = "0x180BFDAF0")]
			internal void NVXESTOUXFG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xBFDAD0", Offset = "0xBFCAD0", VA = "0x180BFDAD0")]
			internal void NWCLQAISGQP(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class BESQZRMFRXB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public long VUBWNNDTGTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public Stopwatch DEWTEQXCTRA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public SkinnedMeshRenderer KLXGICOXXYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public long CTLRGSWHOLT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public string LMNDIPYALLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public long EPRRKDHJJDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public AvatarDisplaySystem SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public int HRTKIZWFXTY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public List<Material> HRCUBKSSVFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public List<(int mat, int part)> NGHJRTPBUIS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public List<Bounds> GWZIVCNNCBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public int PZPPSKYRMCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public long JCNNIUUYPXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public long PMHPZQPLEQF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public long CUJYSAMWPWF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public Action PURTUABVVQB;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public BESQZRMFRXB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class BENKCKSIILS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public bool FRYLDMQPNWG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public JobHandle MZZHMEAKDSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AvatarCullAndCombineMeshJobContainer GZZTFXAQEWX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AvatarCullAndCombineMeshJobGroup DBCMGHBHZXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public BESQZRMFRXB PYDAXWOHYEE;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public BENKCKSIILS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x82E0900", Offset = "0x82DF900", VA = "0x1882E0900")]
			internal void QIIQKBZWUHZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x82D4720", Offset = "0x82D3720", VA = "0x1882D4720")]
			internal void QIDJMVFZKWQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class BFDEUFAAKTT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public bool FRYLDMQPNWG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public JobHandle MZZHMEAKDSD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public AvatarLegacyCullAndCombineMeshJobContainer QPSJWKKCCSH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public AvatarLegacyCullAndCombineMeshJobGroup BQGFWQGFOSW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public BESQZRMFRXB PYSVPQWAAMF;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public BFDEUFAAKTT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x82E0EC0", Offset = "0x82DFEC0", VA = "0x1882E0EC0")]
			internal void QITEEPNRNER()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x82D49D0", Offset = "0x82D39D0", VA = "0x1882D49D0")]
			internal void QINXHITUDTI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class PUKPBAQVCGB : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public bool KGBNREKVGOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public AvatarDisplaySystem SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public List<PLPNZYMYIXH> AQZSMNAAHYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public List<LVFVDSAYAGN> AQAZBDIJUIP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int[] IWYMLSNWQYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public bool OXIAMSHXHOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public Func<int, Layers> NJYGIAERBXY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public AVZQJDBFRMS SZDDASFIVYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public Material TOOHHKZLBVL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private int QCXTIRPYWTF;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public PUKPBAQVCGB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x82E4320", Offset = "0x82E3320", VA = "0x1882E4320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x82E45B0", Offset = "0x82E35B0", VA = "0x1882E45B0", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly Log HSGNIBGQOMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly ZUUFDARDSJN JKYEZYOBYCV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly ZUUFDARDSJN QYFTNIVFLTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Dictionary<BodyProperty, float> RBCCJQARGJZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Dictionary<FaceProperty, float> OYUSQICUFWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<NoseProperty, float> WJZZRYXFVDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IReadOnlyDictionary<string, BoneLocalInfo> MTRSWQJSRZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private Dictionary<string, BoneLocalInfo> UCULPQPRGOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Dictionary<string, BoneLocalInfo> DHLXKVMIWTW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Dictionary<string, BoneLocalInfo> TBTSBGZPXBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private AvatarBuildType OOKKNYJRQBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private AvatarBuildType DYYCBMMTPRS;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static float XHWHKKCAMEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private AvatarConfiguration SESKXVEWCOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private Transform ZIMCDLSAYGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private AvatarSkinAssetItem JCJAHPOLMDU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private AssetReference BWKPPOCKLDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private AssetReference ZTYGABUEPGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private AssetReference XOUNVALLQVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private AssetReference ABEZMSFJDCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private GameObject LJHRZGFUTGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private GameObject GHNHTNOWTTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private GameObject TJXDTAINAXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private SkinnedMeshRenderer GTVTOCGUICR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private AvatarSkinnedMeshBoneOrderRemapsData IILOPDLEOFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private Transform[] UWLYIFMUBEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Matrix4x4[] WJZEDKRUVLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private Material FOQJNWKXLVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Material OMODEQATUKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Texture2D SZLCRAMOUTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Material KFEFGKXKEZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Material WKHYJWVNKVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Material XBGYIZRPBQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Shader KSYYDGVHUQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Shader PHBGNWLJSZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Animator SRMAJXBPOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Renderer[] APDQSFAPBTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private BPYBHDTBBFD.SkinCullingMask AXZWTWFOYUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private AvatarBodyPartShapesManager PXPEKZHRVTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private IReadOnlyDictionary<string, Transform> BCWKCYVWKUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private bool DEVVPJUOSMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private bool FKQSESZOEAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Color NVTEDPYDKPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Color? GXDCBJLNESZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Texture2D AXLYPISTAME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float? ETQFAGHENWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private Color KEXBJAFXPCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Color UFPXJJTAKPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Color? ZFYOGKMMHOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Color? NQGCIXZTLJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Color? JNAGHPLQVXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Color? QPWTODIWKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Texture2D ANHAPUCKNKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Texture2D FFSABXOPRID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[CanBeNull]
		private LOMDNFCRWZO GPRQZDMJIQK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Texture JOBYMONVEOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Color QXWQRGWUXAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Dictionary<Renderer, AVZQJDBFRMS> NJCODURKLTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Dictionary<Renderer, AVZQJDBFRMS> RMDIDSLLHCS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Dictionary<string, List<AvatarMaterialKey>> CTPVDPMZOPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private Dictionary<string, List<AvatarMaterialKey>> TTSKYZBOAGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly List<EUUFFSOTBPK> KNVZHLQQVRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly List<EUUFFSOTBPK> HXSUAVHKLRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly List<EUUFFSOTBPK> AEHNOTOOKQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly List<EUUFFSOTBPK> FIJDSSIPUGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Dictionary<AvatarMaterialKey, Material> XFGWXTJWSIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Dictionary<AvatarMaterialKey, Material> SBNNVLFEJSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private SkinnedMeshRenderer[] AUTBJCTTIAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private SkinnedMeshRenderer[] JGDLPIXWQRK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private SkinnedMeshRenderer[] QSKZEZIODCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private SkinnedMeshRenderer[] ZRUHEUOPLFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly Dictionary<string, TEHJZDMBIST<Texture2D>> BERZNMEQTAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly Dictionary<string, TEHJZDMBIST<Texture2D>> DNLCNXCWXLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private AdditionalHatData TWSDFKRTRKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private AdditionalHatData PUUIWYNFIRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private RecRoom.Avatars.Data.Shared.HairData XJGCDOLFDOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private RecRoom.Avatars.Data.Shared.HairData FXBUACPFCHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private WPRKLXHPVNO ZTIYGCMYESW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private bool? MSSWMJBHQTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private PositionAndRotation MFBULXHNNZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Transform BTTVVCPWRBM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Material ARMRZFZVDUB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Material VBDGVGLHOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private Dictionary<string, LOMDNFCRWZO> NZNNIUNRZMI;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly int TJXCALVEPET;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly int LVQCUSCGHUJ;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly int DNJCUPHLOTL;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly int YPXCZEZEZHM;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly int YTIUJDWYRLM;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly int BPGKOESQSEN;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly int YXSTTAFLONK;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int ANLSKDXWYCO;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int QNJQWMJGTLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private bool YQTFXOMFLNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F9")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private bool JKDPGOOXNHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private List<Action> MBNNHQAXNVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private RHKGGBGWUKB NLDRHWPYLKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private SkinnedMeshRenderer[] TCBXHVFEPHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int AWAIMCCNYKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool RIMKEVEUSOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int MCWUWTUDGOJ;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public ZUUFDARDSJN DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public ZUUFDARDSJN DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xACDF70", Offset = "0xACCF70", VA = "0x180ACDF70", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool SXPTGWGMNEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x82C10E0", Offset = "0x82C00E0", VA = "0x1882C10E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x82C30D0", Offset = "0x82C20D0", VA = "0x1882C30D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private Material AWNOLQWGXJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x82C1540", Offset = "0x82C0540", VA = "0x1882C1540")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private Material RYZCZEOQCWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x82C21F0", Offset = "0x82C11F0", VA = "0x1882C21F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool ITYYZGRBEWL
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x82CDC20", Offset = "0x82CCC20", VA = "0x1882CDC20", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(AvatarBodyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x82CDDA0", Offset = "0x82CCDA0", VA = "0x1882CDDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xD064C0", Offset = "0xD054C0", VA = "0x180D064C0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2298E20", Offset = "0x2297E20", VA = "0x182298E20", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xD06460", Offset = "0xD05460", VA = "0x180D06460", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x82CDC30", Offset = "0x82CCC30", VA = "0x1882CDC30", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public BPYBHDTBBFD.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xC68280", Offset = "0xC67280", VA = "0x180C68280", Slot = "22")]
			get
			{
				return default(BPYBHDTBBFD.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int MIFXFPXDCKY
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x82C20B0", Offset = "0x82C10B0", VA = "0x1882C20B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x82C49D0", Offset = "0x82C39D0", VA = "0x1882C49D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool ONRYGXTQUAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x82C2010", Offset = "0x82C1010", VA = "0x1882C2010")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private static bool XWZJGFXWHSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x82C02A0", Offset = "0x82BF2A0", VA = "0x1882C02A0", Slot = "17")]
		public LVFVDSAYAGN BuildPotatoAvatar(LSYZGHDZEVS avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x82C0270", Offset = "0x82BF270", VA = "0x1882C0270", Slot = "16")]
		public LVFVDSAYAGN BuildAvatarMeshes(LSYZGHDZEVS avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, LOMDNFCRWZO>, (LVFVDSAYAGN, VKQMZHJZWXK<Dictionary<string, TEHJZDMBIST<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x82C88A0", Offset = "0x82C78A0", VA = "0x1882C88A0")]
		public LVFVDSAYAGN WKSTILNVPQU(LSYZGHDZEVS a, bool b, int[] c, bool d, AvatarBuildType e, [Optional] Func<Dictionary<string, LOMDNFCRWZO>, (LVFVDSAYAGN, VKQMZHJZWXK<Dictionary<string, TEHJZDMBIST<Texture2D>>>)> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x82CBAB0", Offset = "0x82CAAB0", VA = "0x1882CBAB0")]
		public static void XRSWOBFYONH(Log a, string b, AssetReference c, AssetReference[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x82C1E00", Offset = "0x82C0E00", VA = "0x1882C1E00")]
		private bool JXQEKPJVVEV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x82CB330", Offset = "0x82CA330", VA = "0x1882CB330")]
		private LVFVDSAYAGN XGQMBELHAJH(bool a, List<PLPNZYMYIXH> b, int[] c, Func<int, Layers> d, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x82C10F0", Offset = "0x82C00F0", VA = "0x1882C10F0")]
		[IteratorStateMachine(typeof(PUKPBAQVCGB))]
		private IEnumerator<ADJUPIXYSVF> GMPFSNBBBAJ(bool a, List<PLPNZYMYIXH> b, int[] c, Func<int, Layers> d, AVZQJDBFRMS e, Material f, List<LVFVDSAYAGN> g, bool h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x82C71A0", Offset = "0x82C61A0", VA = "0x1882C71A0")]
		public static void VARUEUECYMA(List<PLPNZYMYIXH> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x82CABA0", Offset = "0x82C9BA0", VA = "0x1882CABA0")]
		public static LVFVDSAYAGN WNEDSDZGMSK(List<PLPNZYMYIXH> a, List<EUUFFSOTBPK> b, List<EUUFFSOTBPK> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x82CAE30", Offset = "0x82C9E30", VA = "0x1882CAE30")]
		public LVFVDSAYAGN WNEDSDZGMSK(List<PLPNZYMYIXH> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x82C3760", Offset = "0x82C2760", VA = "0x1882C3760")]
		private ALZORZCQSFK PFIEHIUUWNL(List<PLPNZYMYIXH> a, int b, bool c, Layers d, bool e, AVZQJDBFRMS f, Material g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x82C51B0", Offset = "0x82C41B0", VA = "0x1882C51B0", Slot = "27")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x82C5730", Offset = "0x82C4730", VA = "0x1882C5730", Slot = "29")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x82C58C0", Offset = "0x82C48C0", VA = "0x1882C58C0", Slot = "30")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x82BF830", Offset = "0x82BE830", VA = "0x1882BF830", Slot = "28")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x82BF890", Offset = "0x82BE890", VA = "0x1882BF890", Slot = "31")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x82BF950", Offset = "0x82BE950", VA = "0x1882BF950", Slot = "32")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x82C5D70", Offset = "0x82C4D70", VA = "0x1882C5D70")]
		private void TSZELTCYZXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x82C36A0", Offset = "0x82C26A0", VA = "0x1882C36A0")]
		private void OVIDSQEKALV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x82CC3D0", Offset = "0x82CB3D0", VA = "0x1882CC3D0")]
		private void YFUQSJHGTAR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x82C6160", Offset = "0x82C5160", VA = "0x1882C6160", Slot = "34")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x82C70C0", Offset = "0x82C60C0", VA = "0x1882C70C0", Slot = "41")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x82C5720", Offset = "0x82C4720", VA = "0x1882C5720", Slot = "33")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x82CB050", Offset = "0x82CA050", VA = "0x1882CB050")]
		private void WRXLHPJJTES(SkinnedMeshRenderer a, int b, Mesh c, List<Material> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x82C0EC0", Offset = "0x82BFEC0", VA = "0x1882C0EC0")]
		public static Material EXKRGKIJEJV(Dictionary<AvatarMaterialKey, Material> a, Material b, UpdatableColorType c, UpdatableTextureType d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x82C20C0", Offset = "0x82C10C0", VA = "0x1882C20C0")]
		public static UpdatableColorType KZAGQVMNMGM(PLPNZYMYIXH a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x82C02D0", Offset = "0x82BF2D0", VA = "0x1882C02D0")]
		private void CEBBDVVYOGV(int a, Material b, PLPNZYMYIXH c, [Out] Texture2D d, [Out] Vector4 e, [Out] Texture2D f, [Out] Texture2D g, [Out] Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x82CCC20", Offset = "0x82CBC20", VA = "0x1882CCC20")]
		private void ZUMFYACIJBX(int a, Material b, PLPNZYMYIXH c, [Out] Color d, [Out] Color e, [Out] Color f, [Out] Color g, [Out] Color h, [Out] Color i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x82BFB20", Offset = "0x82BEB20", VA = "0x1882BFB20")]
		private bool BMHNWVMLANU(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x82C86E0", Offset = "0x82C76E0", VA = "0x1882C86E0")]
		private static Material WBHUJCLFZOA(int a, DHAVQROOZXL b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x82C1F30", Offset = "0x82C0F30", VA = "0x1882C1F30")]
		public static UpdatableTextureType KIHZZRTWIPG(PLPNZYMYIXH a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x82CC450", Offset = "0x82CB450", VA = "0x1882CC450")]
		private static void YPQTCQVHJTR(Dictionary<string, List<AvatarMaterialKey>> a, PLPNZYMYIXH b, Material c, UpdatableColorType d, UpdatableTextureType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x82CB890", Offset = "0x82CA890", VA = "0x1882CB890")]
		public static SkinnedMeshRenderer XRBIWLFMOFT(Transform a, Transform b, SkinnedMeshRenderer[] c, int d, Layers e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x82CD340", Offset = "0x82CC340", VA = "0x1882CD340")]
		public AvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x82C1810", Offset = "0x82C0810", VA = "0x1882C1810")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x82C30E0", Offset = "0x82C20E0", VA = "0x1882C30E0")]
		public void VWDXMXENINO([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x82C49D0", Offset = "0x82C39D0", VA = "0x1882C49D0", Slot = "6")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x82C5AF0", Offset = "0x82C4AF0", VA = "0x1882C5AF0", Slot = "12")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390")]
		public static bool SPVUKXINULZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x82BF9B0", Offset = "0x82BE9B0", VA = "0x1882BF9B0", Slot = "13")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x82C52A0", Offset = "0x82C42A0", VA = "0x1882C52A0", Slot = "10")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x82C59B0", Offset = "0x82C49B0", VA = "0x1882C59B0", Slot = "11")]
		public void SetSkinColors(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x82C1D80", Offset = "0x82C0D80", VA = "0x1882C1D80")]
		private void JPUMEUXWDDB(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x82C5D00", Offset = "0x82C4D00", VA = "0x1882C5D00", Slot = "7")]
		public void SetUgcItemVisualOverrides(LOMDNFCRWZO overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x82C30D0", Offset = "0x82C20D0", VA = "0x1882C30D0", Slot = "8")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x21DE710", Offset = "0x21DD710", VA = "0x1821DE710", Slot = "9")]
		public void SetUgcTextureParameters(RHKGGBGWUKB parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x82C5DF0", Offset = "0x82C4DF0", VA = "0x1882C5DF0", Slot = "18")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x82BF8F0", Offset = "0x82BE8F0", VA = "0x1882BF8F0", Slot = "35")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x82C5820", Offset = "0x82C4820", VA = "0x1882C5820", Slot = "36")]
		public void SetHatAnchorParams(WPRKLXHPVNO anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x82C62A0", Offset = "0x82C52A0", VA = "0x1882C62A0", Slot = "37")]
		public void UpdateHatPivot([Optional] WPRKLXHPVNO anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x82C0C80", Offset = "0x82BFC80", VA = "0x1882C0C80")]
		private bool EGUQRPDPZAN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x82C5190", Offset = "0x82C4190", VA = "0x1882C5190", Slot = "23")]
		public bool SetBaseSkinCullingMask(BPYBHDTBBFD.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x82C6010", Offset = "0x82C5010", VA = "0x1882C6010", Slot = "39")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x82C7FB0", Offset = "0x82C6FB0", VA = "0x1882C7FB0")]
		public void VJXATOASZKJ(float a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x82C49F0", Offset = "0x82C39F0", VA = "0x1882C49F0")]
		private static bool QSFNTIKAGMS(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x82C7110", Offset = "0x82C6110", VA = "0x1882C7110", Slot = "40")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties materialProperties, TextureEffectMaterialTextures materialTextures)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x82C21D0", Offset = "0x82C11D0", VA = "0x1882C21D0")]
		private static bool KZTGFGOVAHQ(AvatarMaterialKey a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x82CBFE0", Offset = "0x82CAFE0", VA = "0x1882CBFE0")]
		public void XZQSKSALJXP(TextureEffectMaterialProperties a, TextureEffectMaterialTextures b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x82C16E0", Offset = "0x82C06E0", VA = "0x1882C16E0", Slot = "38")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x82C2BF0", Offset = "0x82C1BF0", VA = "0x1882C2BF0")]
		private void MSGDWQGSNHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x82C34D0", Offset = "0x82C24D0", VA = "0x1882C34D0")]
		private void OMJMDYSIHVJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x34292B0", Offset = "0x34282B0", VA = "0x1834292B0")]
		public static void HQXFUNMOXZD<a>(Dictionary<a, Material> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x82C77E0", Offset = "0x82C67E0", VA = "0x1882C77E0")]
		private static void VCEGRLWVGBR(Dictionary<Renderer, AVZQJDBFRMS> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x82C1C30", Offset = "0x82C0C30", VA = "0x1882C1C30")]
		public static void JACEVYXFCWI(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x82C8800", Offset = "0x82C7800", VA = "0x1882C8800")]
		public static void WKRZIASFRNB(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x82CC200", Offset = "0x82CB200", VA = "0x1882CC200")]
		public static void YDCUBSZBWNL(List<EUUFFSOTBPK> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x82CCAA0", Offset = "0x82CBAA0", VA = "0x1882CCAA0")]
		private void ZQLSRHJSRTA(Dictionary<string, TEHJZDMBIST<Texture2D>> a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x82C4FB0", Offset = "0x82C3FB0", VA = "0x1882C4FB0")]
		private void RRAOBJLDLEL(Dictionary<string, List<AvatarMaterialKey>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x82C1200", Offset = "0x82C0200", VA = "0x1882C1200")]
		private void GYTLWEZSZEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x82CB1A0", Offset = "0x82CA1A0", VA = "0x1882CB1A0")]
		private void WXLAFGASATJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x82C79F0", Offset = "0x82C69F0", VA = "0x1882C79F0")]
		private void VEDMMIWYINB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x82C7930", Offset = "0x82C6930", VA = "0x1882C7930")]
		private void VDUSJKPIOVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x82C8770", Offset = "0x82C7770", VA = "0x1882C8770")]
		private void WJSUNTRLAGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x82C0710", Offset = "0x82BF710", VA = "0x1882C0710")]
		private void DFPKSCDLSRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x82C2780", Offset = "0x82C1780", VA = "0x1882C2780")]
		private void MDGVVPPWLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x82C0DF0", Offset = "0x82BFDF0", VA = "0x1882C0DF0")]
		private void ETTLOVEMVSZ(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x82C26A0", Offset = "0x82C16A0", VA = "0x1882C26A0")]
		private void LUSKDNNWPIW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x82C5000", Offset = "0x82C4000", VA = "0x1882C5000")]
		private void RUWOQHPZTCV(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x82C2DB0", Offset = "0x82C1DB0", VA = "0x1882C2DB0")]
		private void MSHHTHBFZJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x82C4AD0", Offset = "0x82C3AD0", VA = "0x1882C4AD0")]
		private void RGKBMFJDGXU(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x82C3360", Offset = "0x82C2360", VA = "0x1882C3360")]
		private void OGUQOECFWYW(Material a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x82BFD80", Offset = "0x82BED80", VA = "0x1882BFD80")]
		private void BRQYXSVTTJQ(Material a, Color b, Texture2D c, Color? d, float? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x82C29B0", Offset = "0x82C19B0", VA = "0x1882C29B0")]
		private void MNOKXSCDJKT(Material a, Color b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x82C3160", Offset = "0x82C2160", VA = "0x1882C3160")]
		private void NBGOAPWFDDQ(Material a, Texture2D b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x82C1360", Offset = "0x82C0360", VA = "0x1882C1360")]
		private void HBLZFWCICIM(Material a, Texture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x82C2850", Offset = "0x82C1850", VA = "0x1882C2850")]
		private void MIUPAKZQWRY(Action<AVZQJDBFRMS> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x82C3520", Offset = "0x82C2520", VA = "0x1882C3520")]
		private void OSKIXEWBZUE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x82C0860", Offset = "0x82BF860", VA = "0x1882C0860")]
		private void EEHXOIHFBEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x82C22D0", Offset = "0x82C12D0", VA = "0x1882C22D0")]
		private void LSRVGLXJTGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x82C8330", Offset = "0x82C7330", VA = "0x1882C8330")]
		public void VQFTDFOUXDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x82C2770", Offset = "0x82C1770", VA = "0x1882C2770", Slot = "4")]
		private void LZQTRYBZVQN([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x82C30E0", Offset = "0x82C20E0", VA = "0x1882C30E0", Slot = "5")]
		private void MXSVHGQGXWM([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x82C3720", Offset = "0x82C2720", VA = "0x1882C3720")]
		[CompilerGenerated]
		private YTAUUGIQSDF PEQGBRWKPXU(PLPNZYMYIXH a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x82CC7E0", Offset = "0x82CB7E0", VA = "0x1882CC7E0")]
		[CompilerGenerated]
		private void ZMGQFCJFYVB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x82CCA80", Offset = "0x82CBA80", VA = "0x1882CCA80")]
		[CompilerGenerated]
		private void ZNMFOQYQDLD(AVZQJDBFRMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x82CC760", Offset = "0x82CB760", VA = "0x1882CC760")]
		[CompilerGenerated]
		private void ZMBJHVPIPJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x82CCA60", Offset = "0x82CBA60", VA = "0x1882CCA60")]
		[CompilerGenerated]
		private void ZNGYRKESTZU(AVZQJDBFRMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x82CC8E0", Offset = "0x82CB8E0", VA = "0x1882CC8E0")]
		[CompilerGenerated]
		private void ZMRDZPXARRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x82CC730", Offset = "0x82CB730", VA = "0x1882CC730")]
		[CompilerGenerated]
		private void ZKQNBAGBBIH(AVZQJDBFRMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x82CC860", Offset = "0x82CB860", VA = "0x1882CC860")]
		[CompilerGenerated]
		private void ZMLXCJDDIGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x82CC700", Offset = "0x82CB700", VA = "0x1882CC700")]
		[CompilerGenerated]
		private void ZKLGDTMDRWY(AVZQJDBFRMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x82CC9E0", Offset = "0x82CB9E0", VA = "0x1882CC9E0")]
		[CompilerGenerated]
		private void ZNBRUDKVKOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x82C1ED0", Offset = "0x82C0ED0", VA = "0x1882C1ED0")]
		[CompilerGenerated]
		private void JZDLAXACZFS(AVZQJDBFRMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x82CC960", Offset = "0x82CB960", VA = "0x1882CC960")]
		[CompilerGenerated]
		private void ZMWKWWQYBDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x82C1F00", Offset = "0x82C0F00", VA = "0x1882C1F00")]
		[CompilerGenerated]
		private void JZIRYDUAIRB(AVZQJDBFRMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x82C14C0", Offset = "0x82C04C0", VA = "0x1882C14C0")]
		[CompilerGenerated]
		private void HOBOHOONFZT(KeyValuePair<string, TEHJZDMBIST<Texture2D>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x82C50D0", Offset = "0x82C40D0", VA = "0x1882C50D0")]
		[CompilerGenerated]
		private void SDNONYRIPDR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x82C5FE0", Offset = "0x82C4FE0", VA = "0x1882C5FE0")]
		[CompilerGenerated]
		private void UBWVOHNTSPE(AVZQJDBFRMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x82C1020", Offset = "0x82C0020", VA = "0x1882C1020")]
		[CompilerGenerated]
		private void FCSQTTLLVJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x82C0DC0", Offset = "0x82BFDC0", VA = "0x1882C0DC0")]
		[CompilerGenerated]
		private void EPTWUIFNYKN(AVZQJDBFRMS a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, DZAMZICLHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private Vector3? BRDSOCLGBTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool BHHORIGZYIR;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x82D83B0", Offset = "0x82D73B0", VA = "0x1882D83B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x82D89D0", Offset = "0x82D79D0", VA = "0x1882D89D0", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB64000", Offset = "0xB63000", VA = "0x180B64000", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x82D8490", Offset = "0x82D7490", VA = "0x1882D8490")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x82D8DF0", Offset = "0x82D7DF0", VA = "0x1882D8DF0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, DZAMZICLHLI
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private const float ZPQFKKRFAYR = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		private Vector3 TIYOPHMORAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private Vector3 NOKCSSWCTWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool BHHORIGZYIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private float OAZSRIIEKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private float CZZFUBBJAQC;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x82D9170", Offset = "0x82D8170", VA = "0x1882D9170", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xD45AD0", Offset = "0xD44AD0", VA = "0x180D45AD0", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x82D8E90", Offset = "0x82D7E90", VA = "0x1882D8E90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x82D9C30", Offset = "0x82D8C30", VA = "0x1882D9C30")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class VXTCJSPUHAC : YQUMJVMQBIV, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private static readonly int LHEGJWTFTGK;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private static readonly int GQIXBNLOGPN;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly int FRIHAZTMMMI;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly int QQQZRXQXUGA;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private static readonly int OSWADMKZJIA;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly int QDXMVZISFPE;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private static readonly int CWWNNTHTOXC;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private static readonly int GBPONTTIOYC;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private static readonly int WCLUGYNSJWE;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly int DZXXJYVGUIP;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly int LYVKKVLOWXH;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static readonly int TFDBQOWUGOV;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static readonly int DLTKZMIKZTB;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static readonly int UVKJLIUBRYT;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static readonly int AKWTVOLQTOP;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static readonly int WYWVSDQRQZH;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private static readonly int USLWESSQGKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private Transform KDAIRYOMCDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private Transform WNPTSOVKPFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private Transform ZMXTNVLMGPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private Transform LPJCPQTHMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Transform NJPPSCSCYPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private Transform EBVSRVEZAKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private AvatarFaceDisplayInitState VTNVVPWHYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private Material EMLSXEQTPHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private SkinnedMeshRenderer[] AXPIJNEQGQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private readonly List<Material> EOJEMVEDCCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private GZOXYNQAEBR YWVOWVFAQLC;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public ZUUFDARDSJN SQVWBACRGFD
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private GZOXYNQAEBR UZJNNQOFYWV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x82E7450", Offset = "0x82E6450", VA = "0x1882E7450")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x82E8CF0", Offset = "0x82E7CF0", VA = "0x1882E8CF0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x82E73A0", Offset = "0x82E63A0", VA = "0x1882E73A0")]
		public void Initialize([In] AvatarFaceDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x82E7540", Offset = "0x82E6540", VA = "0x1882E7540")]
		public void MTPZNYWUKMJ([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x82E87E0", Offset = "0x82E77E0", VA = "0x1882E87E0", Slot = "6")]
		public void RUHWCBPDCVE(AvatarFaceDisplayUpdateFeatureSelectionState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x82E74D0", Offset = "0x82E64D0", VA = "0x1882E74D0")]
		private Vector2 KENIVDSQGBQ(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x82E75E0", Offset = "0x82E65E0", VA = "0x1882E75E0")]
		public void RRGCUDFZQPK([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x82E6FE0", Offset = "0x82E5FE0", VA = "0x1882E6FE0")]
		private void GTDMBECYMET(FaceFeaturesInUVSpace a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x82E84D0", Offset = "0x82E74D0", VA = "0x1882E84D0")]
		private void RRXZBCNZMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x82E6F70", Offset = "0x82E5F70", VA = "0x1882E6F70")]
		private void DMIOFIUOJKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x82E6F70", Offset = "0x82E5F70", VA = "0x1882E6F70", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x82E9160", Offset = "0x82E8160", VA = "0x1882E9160")]
		public VXTCJSPUHAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x82E7540", Offset = "0x82E6540", VA = "0x1882E7540", Slot = "5")]
		private void NGHLVWSRGSC([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x82E8E80", Offset = "0x82E7E80", VA = "0x1882E8E80", Slot = "7")]
		private void WPBOVTFLWWR([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x82E7530", Offset = "0x82E6530", VA = "0x1882E7530")]
		[CompilerGenerated]
		internal static float MNLMFQDBFLG(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x82E6E80", Offset = "0x82E5E80", VA = "0x1882E6E80")]
		[CompilerGenerated]
		internal static void ACICXZOATNH(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x82E8E40", Offset = "0x82E7E40", VA = "0x1882E8E40")]
		[CompilerGenerated]
		internal static Vector4 WMUTQWQTQJQ(Vector2 a, Vector2 b)
		{
			return default(Vector4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class AvatarForearmRollController : MonoBehaviour, DZAMZICLHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private float OAZSRIIEKFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private bool BHHORIGZYIR;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x82D9C60", Offset = "0x82D8C60", VA = "0x1882D9C60", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xAD5DD0", Offset = "0xAD4DD0", VA = "0x180AD5DD0", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x82DA4C0", Offset = "0x82D94C0", VA = "0x1882DA4C0")]
		public AvatarForearmRollController()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public class AvatarHandDisplaySettings
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public class AnimationOverride
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000205")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<int, int> OCDEDQZUCLJ;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x82DA4F0", Offset = "0x82D94F0", VA = "0x1882DA4F0")]
		public void GRLRHMOCTOZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x82DA600", Offset = "0x82D9600", VA = "0x1882DA600")]
		public int NGEAJBFUROP(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class AVODSAOTKKW : DVDTOZBMPJX
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x82D5790", Offset = "0x82D4790", VA = "0x1882D5790", Slot = "24")]
		public override float TXXRHLMGAFK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x82D57E0", Offset = "0x82D47E0", VA = "0x1882D57E0")]
		public AVODSAOTKKW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class DVDTOZBMPJX : MKOZOBXCSZX
	{
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static int FHZLTHFFBQA;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static int KLBNDOJEGVU;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static int UABREDUZOOU;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static int OYSFGNUMVWX;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static int XIYAFVRGQNL;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static int NHPHGYIRERC;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static int WWQKFFDATKO;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static int[] EXDNCOWJIQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private AvatarHandDisplayInitState VTNVVPWHYAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private AvatarHandDisplaySetupState HGWFWYGKXEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private int LBDIMSWLLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private float TXEQZONEDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		protected Animator SRMAJXBPOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		protected AvatarConfiguration HQNEDYHGHCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		protected int URJKWMXDYQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private int APPRKTRDZMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private int CUZYKSTGBZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private bool FUZDSEMGJVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private HandAnimationOverrideState KXLCJCHAHKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private int VJDUIPWIYNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private float PIHSKHGTUPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private AvatarHandDisplaySettings IUXHRRIAEYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private AvatarBodyType ZIMQCWVRQPO;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Transform PJIIMAMHNYU
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xACF6C0", Offset = "0xACE6C0", VA = "0x180ACF6C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector3 DGINCDEKBLC
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x17586A0", Offset = "0x17576A0", VA = "0x1817586A0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x17584F0", Offset = "0x17574F0", VA = "0x1817584F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Quaternion VTKQSSMPQRN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xC16FD0", Offset = "0xC15FD0", VA = "0x180C16FD0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xC16E50", Offset = "0xC15E50", VA = "0x180C16E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool WWODWBWEPIL
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x82E2A50", Offset = "0x82E1A50", VA = "0x1882E2A50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x82E29D0", Offset = "0x82E19D0", VA = "0x1882E29D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool LTOFMBVPLLI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xADD460", Offset = "0xADC460", VA = "0x180ADD460")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 WHXOJQAYYPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1258CB0", Offset = "0x1257CB0", VA = "0x181258CB0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1256950", Offset = "0x1255950", VA = "0x181256950")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Quaternion WRRYBDBVYHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x104D450", Offset = "0x104C450", VA = "0x18104D450", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x82E2960", Offset = "0x82E1960", VA = "0x1882E2960")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HandVisualState YZBOAUOLSTU
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xE599B0", Offset = "0xE589B0", VA = "0x180E599B0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xE5A650", Offset = "0xE59650", VA = "0x180E5A650", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public HandVisualState MHXDRNJSDYF
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1078DE0", Offset = "0x1077DE0", VA = "0x181078DE0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1F14120", Offset = "0x1F13120", VA = "0x181F14120", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float ZQXXIXDPVBX
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x12EAE20", Offset = "0x12E9E20", VA = "0x1812EAE20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xE59A60", Offset = "0xE58A60", VA = "0x180E59A60", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool SZUISBOFRTP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x22D5C30", Offset = "0x22D4C30", VA = "0x1822D5C30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x22D5C80", Offset = "0x22D4C80", VA = "0x1822D5C80", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool TWXYGEDQKPH
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x82E2950", Offset = "0x82E1950", VA = "0x1882E2950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool QXOQNJVIFIS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x82E3250", Offset = "0x82E2250", VA = "0x1882E3250")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool FKXNKLINMZZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x82E3260", Offset = "0x82E2260", VA = "0x1882E3260")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool JRYVGMGPBJV
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x82E2E20", Offset = "0x82E1E20", VA = "0x1882E2E20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x82E2A80", Offset = "0x82E1A80", VA = "0x1882E2A80", Slot = "23")]
		public void Initialize(AvatarHandDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x82E2980", Offset = "0x82E1980", VA = "0x1882E2980")]
		public void EUHFBUDFGNW(AvatarHandDisplaySetupState a, AvatarHandDisplaySettings b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x82E2E50", Offset = "0x82E1E50", VA = "0x1882E2E50", Slot = "14")]
		public void TCKNPBCLDCB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x82E2EE0", Offset = "0x82E1EE0", VA = "0x1882E2EE0", Slot = "13")]
		public void TOABFOVSDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x12EAE20", Offset = "0x12E9E20", VA = "0x1812EAE20", Slot = "24")]
		public virtual float TXXRHLMGAFK()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x82E2C20", Offset = "0x82E1C20", VA = "0x1882E2C20")]
		private int JYUJSQCVJSB(HandVisualState a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x82E32B0", Offset = "0x82E22B0", VA = "0x1882E32B0")]
		private void XJADFOUZDEZ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x82E2DA0", Offset = "0x82E1DA0", VA = "0x1882E2DA0", Slot = "15")]
		public bool MGTDHPMOBWF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x82E2970", Offset = "0x82E1970", VA = "0x1882E2970", Slot = "16")]
		public bool DJRGEHLQCEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x82E2DC0", Offset = "0x82E1DC0", VA = "0x1882E2DC0")]
		private HandVisualState NLOQDMNOVCO()
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x15ABC60", Offset = "0x15AAC60", VA = "0x1815ABC60", Slot = "17")]
		public void OAFKPNSHMDO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x82E3270", Offset = "0x82E2270", VA = "0x1882E3270", Slot = "12")]
		public void XGYNHWFXBVP(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x82E2E30", Offset = "0x82E1E30", VA = "0x1882E2E30", Slot = "10")]
		public void SKXZTRHBLVV(HandAnimationOverrideState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x82E2E10", Offset = "0x82E1E10", VA = "0x1882E2E10", Slot = "11")]
		public void PTYVHAJMVRV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x82E2A00", Offset = "0x82E1A00", VA = "0x1882E2A00", Slot = "18")]
		public void IEAFOGXSKBL(Transform a, Vector3 b, Quaternion c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x82E3700", Offset = "0x82E2700", VA = "0x1882E3700")]
		public DVDTOZBMPJX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class DHAVQROOZXL : PLPNZYMYIXH
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class XHAMZMOSVBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public DHAVQROOZXL SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public List<EUUFFSOTBPK> RUXJXPHSICA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public List<EUUFFSOTBPK> IINLFGERWJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public TEHJZDMBIST<Material[]> ZDOLVOJTIAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public TEHJZDMBIST<LoadedAvatarItemPrefabHolder> SFXCLRGJZKH;

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public XHAMZMOSVBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x82E9710", Offset = "0x82E8710", VA = "0x1882E9710")]
			internal YTAUUGIQSDF AHGRNKTPYOE(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public LOMDNFCRWZO LOMDNFCRWZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public LoadedAvatarItemPrefabHolder FXMMWURVZWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TEHJZDMBIST<LoadedAvatarItemPrefabHolder> OKCWCGQOFST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TEHJZDMBIST<Material[]> ZDOLVOJTIAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Material[] QSUFYDSSIOE;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool MFBOVOOPRUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xAF8B30", Offset = "0xAF7B30", VA = "0x180AF8B30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xAF8B40", Offset = "0xAF7B40", VA = "0x180AF8B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public BPYBHDTBBFD.SkinCullingMask MCNUHBNZYXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xAD5DE0", Offset = "0xAD4DE0", VA = "0x180AD5DE0")]
			[CompilerGenerated]
			get
			{
				return default(BPYBHDTBBFD.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xD77AB0", Offset = "0xD76AB0", VA = "0x180D77AB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x82E28E0", Offset = "0x82E18E0", VA = "0x1882E28E0")]
		public DHAVQROOZXL(ItemDefinitionBodyPart a, LOMDNFCRWZO b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x82E16E0", Offset = "0x82E06E0", VA = "0x1882E16E0", Slot = "6")]
		public override YTAUUGIQSDF FHSOCPTMHJH(List<EUUFFSOTBPK> a, List<EUUFFSOTBPK> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x82E1F70", Offset = "0x82E0F70", VA = "0x1882E1F70")]
		public YTAUUGIQSDF JPMPHCCMMWI(List<EUUFFSOTBPK> a, List<EUUFFSOTBPK> b, TEHJZDMBIST<Material[]> c, [Optional] TEHJZDMBIST<LoadedAvatarItemPrefabHolder> d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x82E1B70", Offset = "0x82E0B70", VA = "0x1882E1B70")]
		public (TEHJZDMBIST<Material[]>, TEHJZDMBIST<LoadedAvatarItemPrefabHolder>) JJZZUXLLUZW(List<EUUFFSOTBPK> a, List<EUUFFSOTBPK> b)
		{
			return default((TEHJZDMBIST<Material[]>, TEHJZDMBIST<LoadedAvatarItemPrefabHolder>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x82E14C0", Offset = "0x82E04C0", VA = "0x1882E14C0", Slot = "7")]
		public override LABMKAGJFZH DDYFEFGNWCY(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x82E2270", Offset = "0x82E1270", VA = "0x1882E2270")]
		public LABMKAGJFZH KDUZIYIGNHZ(GameObject a, uint b, bool c, bool d, AvatarSkinnedMeshBoneOrderRemapsData e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x82E2580", Offset = "0x82E1580", VA = "0x1882E2580")]
		public static bool VVQDRCGRBWG(Renderer[] a, string b, [Out] Renderer c, [Out] Renderer d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x82E2470", Offset = "0x82E1470", VA = "0x1882E2470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x82E24C0", Offset = "0x82E14C0", VA = "0x1882E24C0")]
		private (TEHJZDMBIST<LoadedAvatarItemPrefabHolder>, TEHJZDMBIST<Material[]>) UIGZTBZNIEQ()
		{
			return default((TEHJZDMBIST<LoadedAvatarItemPrefabHolder>, TEHJZDMBIST<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x82E16C0", Offset = "0x82E06C0", VA = "0x1882E16C0")]
		[CompilerGenerated]
		private void EWCSBGEZSKY(LoadedAvatarItemPrefabHolder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xACDF60", Offset = "0xACCF60", VA = "0x180ACDF60")]
		[CompilerGenerated]
		private void EWHYYMYXBWH(Material[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class AvatarKneeBendTargetController : MonoBehaviour, DZAMZICLHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000237")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		private Vector3 TIYOPHMORAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private Vector3 QZSSNUEJMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private Vector3 HKMUQGEDBBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private Matrix4x4 HZFEAOAPASF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private bool BHHORIGZYIR;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x82DAAD0", Offset = "0x82D9AD0", VA = "0x1882DAAD0", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x82DAAC0", Offset = "0x82D9AC0", VA = "0x1882DAAC0", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x82DA670", Offset = "0x82D9670", VA = "0x1882DA670")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x82DB190", Offset = "0x82DA190", VA = "0x1882DB190")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Tested]
	public struct AvatarLegacyCullAndCombineMeshJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		[ReadOnly]
		public AvatarLegacyCullAndCombineMeshJobGroup JobMeshesGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		[ReadOnly]
		public int MaxUberIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		public AvatarLegacyCullAndCombineMeshJobContainer CulledAndCombinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x82DE0F0", Offset = "0x82DD0F0", VA = "0x1882DE0F0", Slot = "4")]
		public void Execute()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[Tested]
	[NativeContainer]
	public struct AvatarLegacyCullAndCombineMeshJobContainer : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public NativeArray<Vector3> vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public NativeArray<Vector3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public NativeArray<Vector4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public NativeArray<Vector2> uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public NativeArray<Vector2> uv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public NativeArray<Vector2> uv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public NativeArray<Vector2> uv4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public NativeArray<Color> colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public NativeArray<int> culledAndCombinedTriangles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public NativeArray<int> culledMeshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private NativeArray<int> postMergeSubMeshTriOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private NativeArray<int> postMergeSubMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		public NativeArray<int> culledSubMeshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public NativeArray<int> culledSubMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public NativeArray<int> vertexCullingIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public NativeArray<BoneWeight> culledAndCombinedBoneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private NativeArray<int> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public int EUAOWNQEFFH
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x82DBB70", Offset = "0x82DAB70", VA = "0x1882DBB70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x82DBBD0", Offset = "0x82DABD0", VA = "0x1882DBBD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public int CZUTHNLJNSP
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x82DB1A0", Offset = "0x82DA1A0", VA = "0x1882DB1A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x82DBAF0", Offset = "0x82DAAF0", VA = "0x1882DBAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int KDMXNYQYHBL
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x82DBB90", Offset = "0x82DAB90", VA = "0x1882DBB90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x82DB490", Offset = "0x82DA490", VA = "0x1882DB490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x82DBBE0", Offset = "0x82DABE0", VA = "0x1882DBBE0")]
		public AvatarLegacyCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x82DBB00", Offset = "0x82DAB00", VA = "0x1882DBB00")]
		public void QORMHRKVCDD(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x82DB4A0", Offset = "0x82DA4A0", VA = "0x1882DB4A0")]
		public void KYGHMIHFBGB(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x82DB6F0", Offset = "0x82DA6F0", VA = "0x1882DB6F0")]
		public Color LVIHGLKVGYS(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x82DB200", Offset = "0x82DA200", VA = "0x1882DB200")]
		public void CDWGIMRFDRQ(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x82DB1B0", Offset = "0x82DA1B0", VA = "0x1882DB1B0")]
		public void BRPBWVXSFJC(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x82DBB80", Offset = "0x82DAB80", VA = "0x1882DBB80")]
		public void SWGFMVYLKHF(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x82DBBA0", Offset = "0x82DABA0", VA = "0x1882DBBA0")]
		public bool WETXYCDSELK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x82DB3D0", Offset = "0x82DA3D0", VA = "0x1882DB3D0")]
		public void FVVVKTFJOCY(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x82DB640", Offset = "0x82DA640", VA = "0x1882DB640")]
		public int[] LRZVSGPQVBC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x82DBA60", Offset = "0x82DAA60", VA = "0x1882DBA60")]
		private NativeSlice<int> NOQBVRUCDGL(int a)
		{
			return default(NativeSlice<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x82DB220", Offset = "0x82DA220", VA = "0x1882DB220", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x82DB710", Offset = "0x82DA710", VA = "0x1882DB710")]
		public Mesh NBKQCMSBPPB([Optional] string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[Tested]
	[NativeContainer]
	public struct AvatarLegacyCullAndCombineMeshJobGroup : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public NativeArray<Vector3> vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public NativeArray<Vector3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public NativeArray<Vector4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public NativeArray<Vector2> uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public NativeArray<Vector2> uv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public NativeArray<Vector2> uv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public NativeArray<Vector2> uv4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public NativeArray<Color> colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public NativeArray<int> triangles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public NativeArray<int> meshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public NativeArray<int> subMeshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public NativeArray<int> subMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public NativeArray<bool> flipTris;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NativeArray<int> boneWeightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public NativeArray<int> meshVertStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public NativeArray<BoneWeight> boneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		private NativeArray<Matrix4x4> meshTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private NativeArray<long> meshCullingBitMasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private NativeArray<byte> meshRemapBoneOrderArrays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private NativeArray<int> meshNumSubMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private NativeArray<int> meshGlobalSubMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		public NativeArray<sbyte> subMeshUberMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NativeArray<byte> subMeshMaterialIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		private NativeArray<int> Params;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int HULDQAKVTXV
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xCED200", Offset = "0xCEC200", VA = "0x180CED200")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int WQGCCUUFQSL
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xD1F8D0", Offset = "0xD1E8D0", VA = "0x180D1F8D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int VNLCTDPOUZW
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x82DC3B0", Offset = "0x82DB3B0", VA = "0x1882DC3B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int MOBXNRXAHZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x82DC3E0", Offset = "0x82DB3E0", VA = "0x1882DC3E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x82DC110", Offset = "0x82DB110", VA = "0x1882DC110")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public int EUAOWNQEFFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x82DC400", Offset = "0x82DB400", VA = "0x1882DC400")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x82DC440", Offset = "0x82DB440", VA = "0x1882DC440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int HDDXDZSRTLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x82DC420", Offset = "0x82DB420", VA = "0x1882DC420")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x82DC430", Offset = "0x82DB430", VA = "0x1882DC430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public MeshMergeModes PDMLPYSECTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x82DC3A0", Offset = "0x82DB3A0", VA = "0x1882DC3A0")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x82DC3F0", Offset = "0x82DB3F0", VA = "0x1882DC3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public byte ZBPOOAMFTFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x82DC390", Offset = "0x82DB390", VA = "0x1882DC390")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x82DC410", Offset = "0x82DB410", VA = "0x1882DC410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public AvatarLegacyCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x82DDBC0", Offset = "0x82DCBC0", VA = "0x1882DDBC0")]
			get
			{
				return default(AvatarLegacyCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x82DC450", Offset = "0x82DB450", VA = "0x1882DC450")]
		public AvatarLegacyCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x82DC040", Offset = "0x82DB040", VA = "0x1882DC040")]
		public AvatarLegacyCullAndCombineMeshJobContainer CGKUESNJNID(Allocator a)
		{
			return default(AvatarLegacyCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x82DC120", Offset = "0x82DB120", VA = "0x1882DC120", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[Tested]
	public class LFCLXMAMBXV : UCDQZUWCUXH
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x82E3D90", Offset = "0x82E2D90", VA = "0x1882E3D90")]
		public AvatarLegacyCullAndCombineMeshJobGroup AHUIIXBMPZD()
		{
			return default(AvatarLegacyCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x82D56E0", Offset = "0x82D46E0", VA = "0x1882D56E0")]
		public LFCLXMAMBXV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct AvatarLegacyCullAndCombineMeshSlice
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		public NativeSlice<Vector3> vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public NativeSlice<Vector3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public NativeSlice<Vector4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public NativeSlice<Vector2> uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public NativeSlice<Vector2> uv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public NativeSlice<Vector2> uv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public NativeSlice<Vector2> uv4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public NativeSlice<Color> colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public NativeSlice<int> subMeshTriOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NativeSlice<int> subMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public NativeSlice<BoneWeight> boneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public NativeSlice<byte> materialIDs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public int NumSubMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public Matrix4x4 MeshTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public long CullingBitMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public NativeSlice<byte> remapBoneOrderArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public bool FlipTris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public int BoneWeightOverride;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public readonly struct AvatarMaterialKey : IEquatable<AvatarMaterialKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		internal readonly Material Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		internal readonly UpdatableColorType UpdatableColorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		internal readonly UpdatableTextureType UpdatableTextureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		internal readonly AvatarBodyPart BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		internal readonly bool UseBuiltInEmissive;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x82DF590", Offset = "0x82DE590", VA = "0x1882DF590")]
		public AvatarMaterialKey(Material material, UpdatableColorType updatableColorType, UpdatableTextureType updatableTextureType, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x82DF300", Offset = "0x82DE300", VA = "0x1882DF300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x82DF070", Offset = "0x82DE070", VA = "0x1882DF070", Slot = "4")]
		public bool Equals(AvatarMaterialKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x82DF100", Offset = "0x82DE100", VA = "0x1882DF100", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x82DF200", Offset = "0x82DE200", VA = "0x1882DF200", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, CMVBAHPOEER
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarBodyType avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		[SerializeField]
		private AssetReference torsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		[SerializeField]
		private AssetReference legsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		[SerializeField]
		private AssetReference torsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		[SerializeField]
		private Texture2D BodyEmissiveSkinMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		[SerializeField]
		private Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		private NVMYCLIJNAG UADEHHLNZQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private YQUMJVMQBIV AXZDRFHEQYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private MKOZOBXCSZX FGMHTQLLERB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private MKOZOBXCSZX TEOIVEFDTAC;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public NVMYCLIJNAG QRUTVGTJUNL
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x82E07A0", Offset = "0x82DF7A0", VA = "0x1882E07A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public YQUMJVMQBIV KOMGWMIXKIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x82E07F0", Offset = "0x82DF7F0", VA = "0x1882E07F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public MKOZOBXCSZX DSDKIXLLLPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x82E0840", Offset = "0x82DF840", VA = "0x1882E0840", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public MKOZOBXCSZX RVFIZOXQUUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x82E0890", Offset = "0x82DF890", VA = "0x1882E0890", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Transform HLDWPFSXQPR
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x82E08E0", Offset = "0x82DF8E0", VA = "0x1882E08E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public AvatarBodyType SUILNBIGIBY
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xAFB170", Offset = "0xAFA170", VA = "0x180AFB170", Slot = "12")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x82DF6D0", Offset = "0x82DE6D0", VA = "0x1882DF6D0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x82E0110", Offset = "0x82DF110", VA = "0x1882E0110")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x82DFB50", Offset = "0x82DEB50", VA = "0x1882DFB50", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x82E0110", Offset = "0x82DF110", VA = "0x1882E0110", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x82DF710", Offset = "0x82DE710", VA = "0x1882DF710", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x82E06B0", Offset = "0x82DF6B0", VA = "0x1882E06B0")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x82E05F0", Offset = "0x82DF5F0", VA = "0x1882E05F0")]
		private void SFKPSEPYHTF(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x82E01C0", Offset = "0x82DF1C0", VA = "0x1882E01C0")]
		private NVMYCLIJNAG SBOKVMIKIGB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x82DFB90", Offset = "0x82DEB90", VA = "0x1882DFB90")]
		private YQUMJVMQBIV KKZKARZRKIN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x82DFE90", Offset = "0x82DEE90", VA = "0x1882DFE90")]
		private MKOZOBXCSZX MWWMFNDJLER(HandType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x82E0790", Offset = "0x82DF790", VA = "0x1882E0790")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class AVZQJDBFRMS : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private MaterialPropertyBlock EBXPYIDZXGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public Color? STNMALWWTBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public Color? MBTYRYIYMWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public Color? KWGKOCYEZTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Color? PNBJZAZBHFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Color MOULITDMJTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public Color TBGFQIRALWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public Color XOVWNZBKXYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public Color? ZXDIQIQQGFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public Texture2D JDTULPJYAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public float? UIHBOCATYLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public float TWQQJSMNNYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public Texture2D AHPPBOYYBCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Texture2D AYBXCGUCWJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private Dictionary<AvatarMaterialKey, int> DWVUGPCZTZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private UpdatableColorType[] OSTUVWJYNLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private UpdatableTextureType[] YXQVIUEWYNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public Vector4[] IHJPHILDBFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Vector4[] RIGJEATTMNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public Vector4[] RXXOREARUQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public Vector4[] DXMFDTIOZNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public Vector4[] TMJVJWGZIIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public Vector4[] QNDMCTIPWEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private List<Texture2D> VIOWFADZVMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private Vector4[] TKZKYQAMNIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private List<Texture2D> DOQAFGMJXFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private float[] AUQOJOXRQEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private Vector4[] KVTMCLCMEBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private float[] VLOKIPANLJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public float[] IJNBHAASPKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private List<Texture2D> IEZPPQTAIUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private float[] ZWWKACXTGOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private List<Texture2D> BNVNVUTQONI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private Vector4[] OXAXWZXOSRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private float[] YXHVDGRXDBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private Vector4[] TFGTMBMATWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public float[] XMLWBKLHYZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public Texture2DArray LOBFGMNWJIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public Texture2DArray WDTUYJBMJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public Texture2DArray TNYZCHFRYCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public Texture2DArray GKRZRUPHVQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private bool VBSKXCUIXTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private int TDZNYHBDUGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private Vector2? FQRRHCXPOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private TextureFormat NTEENCVVMXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private Vector2? FWHLXVCMYKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TextureFormat VBNSCBVGGOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private Vector2? PACGIYTCPJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private TextureFormat OTEMMSPJLHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private Vector2? YXZAWFYDTHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private TextureFormat TMMZENHIKOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private bool CKKXJOLCXCU;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static int XTSOZURSMFM;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private static int CDVGXQOLHSK;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private static int CVZMZGADYHU;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static int NXRKDISEZOT;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static int UFYMXVFYJIG;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static int NJTEYQCRRAF;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private static int VVNQJYWQKZC;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private static int VQCAZUBCKLL;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private static int FTUQKYSBEJP;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private static int XNQAAGCBGKQ;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private static int JHAUJERNYIE;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private static int EVQIYKAELJO;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private static int HVYARLZBIVS;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private static int ZLLYZYFOEZK;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private static int IXWUWULRVON;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private static int JDDKHDMKONF;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private static int KRBCWUTNSGR;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private static int AOAIGBUIEJW;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private static int ALWTVWXABOO;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private static int FTAEZEFSKVJ;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x82D7E30", Offset = "0x82D6E30", VA = "0x1882D7E30")]
		private AVZQJDBFRMS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x82D82F0", Offset = "0x82D72F0", VA = "0x1882D82F0")]
		public AVZQJDBFRMS(Color a, Color b, Color c, Color? d, Color? e, Color? f, Texture2D g, Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x82D6AC0", Offset = "0x82D5AC0", VA = "0x1882D6AC0")]
		internal int SSEKLJLFXDS(Material a, UpdatableColorType b, UpdatableTextureType c, AvatarBodyPart d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x82D6A30", Offset = "0x82D5A30", VA = "0x1882D6A30")]
		private int SSEKLJLFXDS(AvatarMaterialKey a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x82D5C90", Offset = "0x82D4C90", VA = "0x1882D5C90")]
		internal int FKVDJNGVOCH(Material a, Color b, Color c, Color d, Color e, Color f, Texture2D g, Vector4 h, Texture2D i, Vector4 j, float k, float l, Texture2D m, Vector4 n, float o, Texture2D p, Color q, Vector4 r, UpdatableColorType s, UpdatableTextureType t, AvatarBodyPart u)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x82D6870", Offset = "0x82D5870", VA = "0x1882D6870")]
		private void SFUYNWCSHJC(List<Texture2D> a, [Out] Texture2DArray b, [Out] Texture2DArray c, [Out] Texture2DArray d, [Out] Texture2DArray e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x82D6B90", Offset = "0x82D5B90", VA = "0x1882D6B90")]
		public void TTLWAWCFGQT(Shader a, Renderer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x82D6CE0", Offset = "0x82D5CE0", VA = "0x1882D6CE0")]
		private void UMDQGQDATSY(Shader a, Renderer b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x82D5840", Offset = "0x82D4840", VA = "0x1882D5840")]
		private Color BVLTUUIJRRR(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x82D7990", Offset = "0x82D6990", VA = "0x1882D7990")]
		private Color XROFOUARPZJ(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x82D5A40", Offset = "0x82D4A40", VA = "0x1882D5A40")]
		private bool BXEGWCQCGJK(Texture2D a, UpdatableTextureType b, [Out] Texture2D c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x82D5BA0", Offset = "0x82D4BA0", VA = "0x1882D5BA0")]
		private void BZVIAVNWIYB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x82D5C50", Offset = "0x82D4C50", VA = "0x1882D5C50", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class PLPNZYMYIXH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public readonly ItemDefinitionBodyPart CRBZSMAAHKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool BJTVIZMJRJG;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool JHDMWMBSDPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xB21140", Offset = "0xB20140", VA = "0x180B21140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xBA8E20", Offset = "0xBA7E20", VA = "0x180BA8E20")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool LWYHMWFKURZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xBA7FC0", Offset = "0xBA6FC0", VA = "0x180BA7FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xBA8680", Offset = "0xBA7680", VA = "0x180BA8680")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual BPYBHDTBBFD.SkinCullingMask PFWYMOUBSGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(BPYBHDTBBFD.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xB7CD80", Offset = "0xB7BD80", VA = "0x180B7CD80", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool TKFWFJKQDDD
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xCE16F0", Offset = "0xCE06F0", VA = "0x180CE16F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool UFOLAMENXKC
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x82E4100", Offset = "0x82E3100", VA = "0x1882E4100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool QHLCZMVANQP
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x82E4180", Offset = "0x82E3180", VA = "0x1882E4180")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool BPNBSYKBHDS
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x82E4200", Offset = "0x82E3200", VA = "0x1882E4200")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x82E42F0", Offset = "0x82E32F0", VA = "0x1882E42F0")]
		protected PLPNZYMYIXH(ItemDefinitionBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract YTAUUGIQSDF FHSOCPTMHJH(List<EUUFFSOTBPK> a, List<EUUFFSOTBPK> b);

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract LABMKAGJFZH DDYFEFGNWCY(uint a, AvatarSkinnedMeshBoneOrderRemapsData b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class UYBQOYGAYCC : RFLAQAKMSKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private AvatarSkinAssetItem JCJAHPOLMDU;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x82E6D80", Offset = "0x82E5D80", VA = "0x1882E6D80")]
		public UYBQOYGAYCC(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, ItemDefinitionBodyPart c, [Optional] FaceFeatureId? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x82E6C40", Offset = "0x82E5C40", VA = "0x1882E6C40")]
		public UYBQOYGAYCC(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, AvatarBodyPart c, BPYBHDTBBFD.SkinCullingMask d, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x82E69E0", Offset = "0x82E59E0", VA = "0x1882E69E0", Slot = "6")]
		public override YTAUUGIQSDF FHSOCPTMHJH(List<EUUFFSOTBPK> a, List<EUUFFSOTBPK> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class WCHGMENKIEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly int[] MNTCCQRKFGN;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly int[] CRHPQTUMBSR;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public static int[] NRDRTQTJAQA
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x82E93D0", Offset = "0x82E83D0", VA = "0x1882E93D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x82E92A0", Offset = "0x82E82A0", VA = "0x1882E92A0")]
		public static int[] CNVZEVZYGIJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x82E9340", Offset = "0x82E8340", VA = "0x1882E9340")]
		public static int NXTLHGFMXOO(UpdateLOD a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x82E9420", Offset = "0x82E8420", VA = "0x1882E9420")]
		private static int UUCXKDJRORM(UpdateLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x82E9320", Offset = "0x82E8320", VA = "0x1882E9320")]
		private static int FBBGZGKGXKN(UpdateLOD a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class KVVRYZUKQAK
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class JJRQMZMGMZP : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public JobHandle ECBWVPRWCFP;

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public JJRQMZMGMZP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x12F1010", Offset = "0x12F0010", VA = "0x1812F1010", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x82E3BB0", Offset = "0x82E2BB0", VA = "0x1882E3BB0", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public static void CHGJHLOJNWG(string a, int b, long c, long d, long e, long f, long g, long h, long i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x82E3C50", Offset = "0x82E2C50", VA = "0x1882E3C50")]
		public static ALZORZCQSFK DCNCVRCBFZU(JobHandle a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x82E3BF0", Offset = "0x82E2BF0", VA = "0x1882E3BF0")]
		[IteratorStateMachine(typeof(JJRQMZMGMZP))]
		private static IEnumerator<ADJUPIXYSVF> ABHQVMLVGNZ(JobHandle a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class SFJDCSQOQBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum MaterialMode
		{
			[Cpp2IlInjected.Token(Token = "0x400031A")]
			General,
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			ColoredHair
		}

		[Cpp2IlInjected.Token(Token = "0x400030C")]
		public static readonly int OAFCKCAMHRC;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly int YFJFMSXJJJT;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly int FAZJXXNRFPT;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly int KTWIPHOIBQU;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly int NVHKODOKCUF;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly int QEWYDZDKMJT;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly int NHGKUCFPJEX;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly int FNAVJTVLAGO;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly int XCPNNUFCMOH;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly int MPNWZLEWTYE;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly int WERVOFSFIOO;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly int IAQCUCXCHNZ;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly int ECVGQZVLSYQ;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x82E54C0", Offset = "0x82E44C0", VA = "0x1882E54C0")]
		public static bool HYUYMEEAZAE(Material a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class RFLAQAKMSKP : PLPNZYMYIXH
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class XHAMZMOSVBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public TEHJZDMBIST<GameObject> ZSOSKJOUPPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public RFLAQAKMSKP SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Action<string> VCIXSNDKWEJ;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public XHAMZMOSVBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x82E9950", Offset = "0x82E8950", VA = "0x1882E9950")]
			internal void AHLYKRNNHZN(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x82E95D0", Offset = "0x82E85D0", VA = "0x1882E95D0")]
			internal void AHGRNKTPYOE(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected AvatarSkinAssetItem CKLLLURXXED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Material[] LRYNOOBUXGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly AvatarSkinAssetItem.SkinBodyMeshType WOXJTVHROYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private readonly AssetReference BWKPPOCKLDS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private readonly FaceFeatureId? PUPOOPHUYAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private SkinnedMeshRenderer[] XKJJRGEBKNT;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override BPYBHDTBBFD.SkinCullingMask PFWYMOUBSGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xAD05B0", Offset = "0xACF5B0", VA = "0x180AD05B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(BPYBHDTBBFD.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F20", Offset = "0xAD1F20", VA = "0x180AD2F20", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x82E52F0", Offset = "0x82E42F0", VA = "0x1882E52F0")]
		public RFLAQAKMSKP(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, ItemDefinitionBodyPart d, BPYBHDTBBFD.SkinCullingMask e = (BPYBHDTBBFD.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x82E5190", Offset = "0x82E4190", VA = "0x1882E5190")]
		public RFLAQAKMSKP(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, BPYBHDTBBFD.SkinCullingMask d = (BPYBHDTBBFD.SkinCullingMask)0L, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x82E5420", Offset = "0x82E4420", VA = "0x1882E5420")]
		public RFLAQAKMSKP(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material[] c, ItemDefinitionBodyPart d, BPYBHDTBBFD.SkinCullingMask e = (BPYBHDTBBFD.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x82E4EC0", Offset = "0x82E3EC0", VA = "0x1882E4EC0", Slot = "6")]
		public override YTAUUGIQSDF FHSOCPTMHJH(List<EUUFFSOTBPK> a, List<EUUFFSOTBPK> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x82E4CD0", Offset = "0x82E3CD0", VA = "0x1882E4CD0", Slot = "7")]
		public override LABMKAGJFZH DDYFEFGNWCY(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x82E50D0", Offset = "0x82E40D0", VA = "0x1882E50D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x82E5140", Offset = "0x82E4140", VA = "0x1882E5140")]
		protected void VRQWNELDCEH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000326")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x82E3720", Offset = "0x82E2720", VA = "0x1882E3720")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface TVEZBKWKSWB
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void QCCDJGQMHEH(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, BPYBHDTBBFD.SkinCullingMask e = (BPYBHDTBBFD.SkinCullingMask)0L, int f = -1, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CPOTQVXUPXZ(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public readonly struct LoadedAvatarItemPrefabHolder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public readonly GameObject outfitObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		private readonly AvatarItemMaterial avatarItemMaterial;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0xE75140", Offset = "0xE74140", VA = "0x180E75140")]
		public LoadedAvatarItemPrefabHolder(GameObject outfitObject, AvatarItemMaterial avatarItemMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x82E3E80", Offset = "0x82E2E80", VA = "0x1882E3E80")]
		public void BGUZWTEGGVC(Material a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class REVVLKDYZZJ : CRPCAQXABTM<Task<(GameObject, AvatarItemMaterial)>, LoadedAvatarItemPrefabHolder>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct <WhenAllAvatarComponents>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000337")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public Task<GameObject> goTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public Task<AvatarItemMaterial> materialTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			private GameObject <go>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			private TaskAwaiter<AvatarItemMaterial> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x82E6340", Offset = "0x82E5340", VA = "0x1882E6340", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x82E6840", Offset = "0x82E5840", VA = "0x1882E6840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private TEHJZDMBIST<GameObject> EDUQWDWBCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private TEHJZDMBIST<AvatarItemMaterial> WWZMTOWFVIK;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x82E4C40", Offset = "0x82E3C40", VA = "0x1882E4C40")]
		private REVVLKDYZZJ(Task<(GameObject, AvatarItemMaterial)> a, TEHJZDMBIST<GameObject> b, TEHJZDMBIST<AvatarItemMaterial> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x82E4720", Offset = "0x82E3720", VA = "0x1882E4720")]
		public static REVVLKDYZZJ Create(AssetReference outfitPrefabReference, [Optional] AssetReference combinationReference)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x82E4B20", Offset = "0x82E3B20", VA = "0x1882E4B20", Slot = "11")]
		protected override LoadedAvatarItemPrefabHolder MJVNMYMIJMF(Task<(GameObject, AvatarItemMaterial)> a)
		{
			return default(LoadedAvatarItemPrefabHolder);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x82E4BC0", Offset = "0x82E3BC0", VA = "0x1882E4BC0", Slot = "12")]
		protected override void VITXQOERQFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x82E45F0", Offset = "0x82E35F0", VA = "0x1882E45F0")]
		[AsyncStateMachine(typeof(<WhenAllAvatarComponents>d__6))]
		private static Task<(GameObject, AvatarItemMaterial)> AQNGNIAJIWH(Task<GameObject> a, Task<AvatarItemMaterial> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class HMWHSJJBLSQ
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		private class WROAYVIPEGO : CRPCAQXABTM<Task<MaterialMapAsset>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			private TEHJZDMBIST<MaterialMapAsset> ECBWVPRWCFP;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x8305400", Offset = "0x8304400", VA = "0x188305400")]
			public WROAYVIPEGO(TEHJZDMBIST<MaterialMapAsset> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x8304F80", Offset = "0x8303F80", VA = "0x188304F80", Slot = "11")]
			protected override Material[] MJVNMYMIJMF(Task<MaterialMapAsset> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x83053A0", Offset = "0x83043A0", VA = "0x1883053A0", Slot = "12")]
			protected override void VITXQOERQFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		private class WJLGTEGWXYK : CRPCAQXABTM<Task<Material[]>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			private List<TEHJZDMBIST<Material>> QTSDCXPYZXU;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x8304F10", Offset = "0x8303F10", VA = "0x188304F10")]
			public WJLGTEGWXYK(Task<Material[]> a, List<TEHJZDMBIST<Material>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8304D80", Offset = "0x8303D80", VA = "0x188304D80", Slot = "11")]
			protected override Material[] MJVNMYMIJMF(Task<Material[]> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x8304DD0", Offset = "0x8303DD0", VA = "0x188304DD0", Slot = "12")]
			protected override void VITXQOERQFG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly Log HRODLTCIOIP;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x82E3780", Offset = "0x82E2780", VA = "0x1882E3780")]
		public static TEHJZDMBIST<Material[]> LZUXSDPKEGF(AssetReference[] a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[DisallowMultipleComponent]
	public class PlayerAvatarDisplayBase : AvatarDisplayBase
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public enum UpdatableColorType
		{
			[Cpp2IlInjected.Token(Token = "0x400038E")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public enum UpdatableTextureType
		{
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		protected class GCPSWEOHRQA : IComparable<GCPSWEOHRQA>, IEquatable<GCPSWEOHRQA>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public int BNWFALCXOMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public PlayerAvatarDisplayBase EONECDCPVLV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public IList<AvatarItemSelection> UZFOQXRGNBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public AvatarItemBodyType DNIHIDADQGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public AvatarBuildType UASKMQAFAZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool LWVIHXFNBRM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public bool EVADLKOUXEZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public int[] IWYMLSNWQYL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public float KJOSNZRFNVR;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x82EBC30", Offset = "0x82EAC30", VA = "0x1882EBC30", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x82EBAE0", Offset = "0x82EAAE0", VA = "0x1882EBAE0", Slot = "4")]
			public int CompareTo(GCPSWEOHRQA other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x82EBB10", Offset = "0x82EAB10", VA = "0x1882EBB10", Slot = "5")]
			public bool Equals(GCPSWEOHRQA other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public GCPSWEOHRQA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		protected abstract class PLPNZYMYIXH
		{
			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public virtual bool JHDMWMBSDPX
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		protected class NUTDONOSSNB : PLPNZYMYIXH
		{
			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public UYRLBEJRVWE UYLDUYJSOYV
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public class FVQBSQYSYIK
		{
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			public enum HandVisualStatePriority
			{
				[Cpp2IlInjected.Token(Token = "0x40003B3")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x40003B4")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x40003B5")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x40003B6")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x40003B7")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x40003B8")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x40003B9")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public static readonly int VBVWBIAAMAQ;

			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public static readonly int DFAQTWCUKYT;

			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public static readonly int RLMKKCTHEBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected readonly HandType SFLLKNCVQMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected readonly GRYQTPMPJES HHANYKXSGQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected readonly Animator TWLJVCQESUP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected readonly Transform GSLUJHSGUDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Vector3 IKLACDHXNQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected readonly Transform GHZNQVBCXVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Vector3 KGFVTLLMQLP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected bool KMVYTDTEKMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected MKOZOBXCSZX WSHXTDJTEMQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected bool KXDHIBMJMLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected float ATDTXMIGTTX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected HLOQONLCJDD<HandVisualState> TWYZZIWNZBR;

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public MKOZOBXCSZX KRYOXTOICUF
			{
				[Cpp2IlInjected.Token(Token = "0x600032A")]
				[Cpp2IlInjected.Address(RVA = "0xACDCF0", Offset = "0xACCCF0", VA = "0x180ACDCF0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xACDF80", Offset = "0xACCF80", VA = "0x180ACDF80")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool JBRUAGKCMKF
			{
				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x13F6890", Offset = "0x13F5890", VA = "0x1813F6890")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x82EAD10", Offset = "0x82E9D10", VA = "0x1882EAD10")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool QCLYCTIFASW
			{
				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0xAD5DC0", Offset = "0xAD4DC0", VA = "0x180AD5DC0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x82EB0D0", Offset = "0x82EA0D0", VA = "0x1882EB0D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public float HACCAONVIDE
			{
				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0xBA8E10", Offset = "0xBA7E10", VA = "0x180BA8E10")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000331")]
				[Cpp2IlInjected.Address(RVA = "0x82EB200", Offset = "0x82EA200", VA = "0x1882EB200")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public HandVisualState BFIYEJIRRQB
			{
				[Cpp2IlInjected.Token(Token = "0x6000332")]
				[Cpp2IlInjected.Address(RVA = "0x82EACD0", Offset = "0x82E9CD0", VA = "0x1882EACD0")]
				get
				{
					return default(HandVisualState);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x82EA8A0", Offset = "0x82E98A0", VA = "0x1882EA8A0")]
			public bool AUNISOWZYEZ(HandVisualState a, object b, HandVisualStatePriority c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x82EABD0", Offset = "0x82E9BD0", VA = "0x1882EABD0")]
			public bool EYRMHRKOHVS(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x82EBA60", Offset = "0x82EAA60", VA = "0x1882EBA60")]
			protected FVQBSQYSYIK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x82EB500", Offset = "0x82EA500", VA = "0x1882EB500")]
			public FVQBSQYSYIK(HandType a, MKOZOBXCSZX b, Animator c, Transform d, Transform e, Vector3 f, Vector3 g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x82EAAD0", Offset = "0x82E9AD0", VA = "0x1882EAAD0")]
			private void ENCZMKQGGOX(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x82EB370", Offset = "0x82EA370", VA = "0x1882EB370")]
			protected void ZGYUQCFXJGF(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x82EAEF0", Offset = "0x82E9EF0", VA = "0x1882EAEF0")]
			protected void LBWMLRMBKXY(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x82EA9B0", Offset = "0x82E99B0", VA = "0x1882EA9B0")]
			protected void AYSLNVKIDDW(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x82EADE0", Offset = "0x82E9DE0", VA = "0x1882EADE0")]
			protected void IFWBQBTFYHN(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x82EB1A0", Offset = "0x82EA1A0", VA = "0x1882EB1A0")]
			protected void TJRTZHBMHLQ(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x82EAB80", Offset = "0x82E9B80", VA = "0x1882EAB80")]
			protected void EXYCMMEGHRZ(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x82EA850", Offset = "0x82E9850", VA = "0x1882EA850")]
			protected void ATSYHZYFXXM(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x82EAFB0", Offset = "0x82E9FB0", VA = "0x1882EAFB0")]
			protected void LQTDYWYQDAO(ushort a, ushort b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BA")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Transform RightHandRoot;
		}

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class SNPMCGEPFUM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public PlayerAvatarDisplayBase TRTDIVWCNRB;

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public SNPMCGEPFUM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x8302030", Offset = "0x8301030", VA = "0x188302030")]
			internal bool YKFNISVZTXW()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class IDJZYJYOSHQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public PlayerAvatarDisplayBase SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public AvatarItemBodyType ULMUHEAHPOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public Func<VKQMZHJZWXK<Dictionary<string, TEHJZDMBIST<Texture2D>>>> VBTDASVSTWI;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public IDJZYJYOSHQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x82EBE60", Offset = "0x82EAE60", VA = "0x1882EBE60")]
			internal (LVFVDSAYAGN, VKQMZHJZWXK<Dictionary<string, TEHJZDMBIST<Texture2D>>>) VHJGKEYVHHB(Dictionary<string, LOMDNFCRWZO> a)
			{
				return default((LVFVDSAYAGN, VKQMZHJZWXK<Dictionary<string, TEHJZDMBIST<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x82EC050", Offset = "0x82EB050", VA = "0x1882EC050")]
			internal VKQMZHJZWXK<Dictionary<string, TEHJZDMBIST<Texture2D>>> VHTUESMQADT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x82EBD80", Offset = "0x82EAD80", VA = "0x1882EBD80")]
			internal void VHDZMYEXXVS()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct <CompleteBuildAsync>d__218 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8302C30", Offset = "0x8301C30", VA = "0x188302C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8302E90", Offset = "0x8301E90", VA = "0x188302E90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class QAKSHNEJJLV : IEnumerator<ADJUPIXYSVF>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private ADJUPIXYSVF GLROCXYMSEU;

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			private ADJUPIXYSVF ZVDSFAMUXCO
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x6000354")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xACFAD0", Offset = "0xACEAD0", VA = "0x180ACFAD0")]
			[DebuggerHidden]
			public QAKSHNEJJLV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "5")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x8300BB0", Offset = "0x82FFBB0", VA = "0x188300BB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x8300ED0", Offset = "0x82FFED0", VA = "0x188300ED0", Slot = "8")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct <SetFaceCustomizationSettings>d__130 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x8303100", Offset = "0x8302100", VA = "0x188303100", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x83034A0", Offset = "0x83024A0", VA = "0x1883034A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private struct <SetHairPatternAsync>d__168 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public AvatarHairPattern pattern;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x8303A10", Offset = "0x8302A10", VA = "0x188303A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x8303DD0", Offset = "0x8302DD0", VA = "0x188303DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class SGDGZOUFQDH : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private int NNYUMBTASKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private SkinnedMeshRenderer GLROCXYMSEU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private int CYUNKNWTKTU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public PlayerAvatarDisplayBase SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private SkinnedMeshRenderer[] NVXWRKLJBUP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private int NWDDORFGLFY;

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			private SkinnedMeshRenderer CKRRZTIZCGP
			{
				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			private object OPJHDGDZAVH
			{
				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0xACF7F0", Offset = "0xACE7F0", VA = "0x180ACF7F0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0xD9D550", Offset = "0xD9C550", VA = "0x180D9D550")]
			[DebuggerHidden]
			public SGDGZOUFQDH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80", Slot = "7")]
			[DebuggerHidden]
			private void FQZHCUDIKGC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x8301E20", Offset = "0x8300E20", VA = "0x188301E20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x8301FF0", Offset = "0x8300FF0", VA = "0x188301FF0", Slot = "10")]
			[DebuggerHidden]
			private void SEWTXRYPVUP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8301D80", Offset = "0x8300D80", VA = "0x188301D80", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<SkinnedMeshRenderer> EQBICNAFKDC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x8301D80", Offset = "0x8300D80", VA = "0x188301D80", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator HKYUJZELIWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected static List<PlayerAvatarDisplayBase> OPRICRLKYMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected HelmetHairState MPGMYWZTLHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected bool WOELLHJPAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected bool NYNZZZITADG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		protected static readonly int[] ZLFRPARQUEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private bool LTLSBKLQWPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		private MKOZOBXCSZX FGMHTQLLERB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private MKOZOBXCSZX TEOIVEFDTAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		[SerializeField]
		[Autofill(AutofillType.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		protected Collider[] HXICLMTOSSI;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		protected Collider[] TFNIDKHJCYT;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		protected FVQBSQYSYIK[] NTUKTRJNUQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public bool meshDataStructUseSemioptimizedBoneWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		protected readonly Dictionary<string, TEHJZDMBIST<Texture2D>> XKCAOWBFHMN;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		protected static int WRHVCDTOUFZ;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		protected static List<GCPSWEOHRQA> FOLQVMHJAHP;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		protected static List<GCPSWEOHRQA> DNGMUZFSEPW;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		protected static ALZORZCQSFK HPYHHVEQFDK;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		protected static Func<List<GCPSWEOHRQA>, GCPSWEOHRQA> UWMWFDWOEGX;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		protected static bool SDLAXGUOCQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		protected Color? EVVHEWYNMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		protected Color TPKECTKLVQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		protected Color DGQXNYPPESI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		protected Color AKTXMVRDIFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		protected AvatarHairPattern ZZVAWFMJPJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		protected Texture2D JUMSSRVPSJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		protected UYRLBEJRVWE JXPZXWNHEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		protected Color ODQAWCRXQXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		protected Color VEUORTQNXSQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		protected AvatarHairPattern RQQGZJHEKAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		protected Texture2D GDPZUWUWNGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		protected UYRLBEJRVWE DZZOBNBEMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		protected UYRLBEJRVWE HXTCQSFCAIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		protected Color JNKUVWBZWAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private AdditionalFeetData SGKNKWUBKYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		protected readonly IList<AvatarItemSelection> VIDMIUXNKCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		protected readonly IList<AvatarItemSelection> WLUNJUQWQFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private AvatarItemBodyType OGASPKFLZOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x265")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		protected bool BWTIACWEZPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		protected int[] KSDLBCIXUDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		protected bool PFBLDENDBJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		protected bool MESFQEFMZCV;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private static readonly BPYBHDTBBFD.SkinCullingMask JZLOFZZLLFV;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private static readonly BPYBHDTBBFD.SkinCullingMask IUCDTQMKPOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x272")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		protected bool NATDCIYXLZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		protected RHKGGBGWUKB NLDRHWPYLKT;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string JOBUUPUVYKT
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xB6B480", Offset = "0xB6A480", VA = "0x180B6B480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xC275A0", Offset = "0xC265A0", VA = "0x180C275A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool HXWBRQZGXTD
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool YPCPZXUAXIF
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x82F3C70", Offset = "0x82F2C70", VA = "0x1882F3C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool UFSAIHUBDIX
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool LBPNQDVOYDE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool LPLJTIDVLDA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xB85300", Offset = "0xB84300", VA = "0x180B85300")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x82F4220", Offset = "0x82F3220", VA = "0x1882F4220")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public MKOZOBXCSZX DSDKIXLLLPA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xD064B0", Offset = "0xD054B0", VA = "0x180D064B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x82F4240", Offset = "0x82F3240", VA = "0x1882F4240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public MKOZOBXCSZX RVFIZOXQUUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xD064C0", Offset = "0xD054C0", VA = "0x180D064C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x82F44E0", Offset = "0x82F34E0", VA = "0x1882F44E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public PlayerFacialAnimatorBase EEXGXMTUGAL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xBF5600", Offset = "0xBF4600", VA = "0x180BF5600")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public FVQBSQYSYIK[] DEJOSKXOSLV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x82F3810", Offset = "0x82F2810", VA = "0x1882F3810")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public FVQBSQYSYIK MBJKFAMBSEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x82F3CE0", Offset = "0x82F2CE0", VA = "0x1882F3CE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public FVQBSQYSYIK DAWCCVUSPSG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x82F3D10", Offset = "0x82F2D10", VA = "0x1882F3D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected bool ITYYZGRBEWL
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xAE9570", Offset = "0xAE8570", VA = "0x180AE9570", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x82F4450", Offset = "0x82F3450", VA = "0x1882F4450", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected virtual bool JWPIMGIJUFH
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected virtual int[] LAZAKPQXZID
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x82F25F0", Offset = "0x82F15F0", VA = "0x1882F25F0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected bool ONRYGXTQUAM
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x82EDC60", Offset = "0x82ECC60", VA = "0x1882EDC60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IEnumerable<SkinnedMeshRenderer> RAVTIAXGOYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x82F36F0", Offset = "0x82F26F0", VA = "0x1882F36F0")]
			[IteratorStateMachine(typeof(SGDGZOUFQDH))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool PGQOURIKEMH
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x223F0D0", Offset = "0x223E0D0", VA = "0x18223F0D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x223F130", Offset = "0x223E130", VA = "0x18223F130")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public new static bool UIJGGKWYFEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x82F3BA0", Offset = "0x82F2BA0", VA = "0x1882F3BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		protected static ALZORZCQSFK OYRCCKGGBRV
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x82ED6B0", Offset = "0x82EC6B0", VA = "0x1882ED6B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x82EC560", Offset = "0x82EB560", VA = "0x1882EC560")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Color KWGKOCYEZTY
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x82EE500", Offset = "0x82ED500", VA = "0x1882EE500")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		protected Color PNBJZAZBHFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x82F2330", Offset = "0x82F1330", VA = "0x1882F2330")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected Texture2D HUMYERMALVM
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x82EC0C0", Offset = "0x82EB0C0", VA = "0x1882EC0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Color MOULITDMJTM
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x82F37C0", Offset = "0x82F27C0", VA = "0x1882F37C0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		protected Color TBGFQIRALWC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x82F2380", Offset = "0x82F1380", VA = "0x1882F2380")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public UYRLBEJRVWE XDWXVUWFEJE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x82F3780", Offset = "0x82F2780", VA = "0x1882F3780")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected Texture2D NKKAIXYDIVE
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x82EDD00", Offset = "0x82ECD00", VA = "0x1882EDD00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public float JSBXCEIBBZR
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x82F37A0", Offset = "0x82F27A0", VA = "0x1882F37A0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public float GITBWKJOMFK
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x82F3C50", Offset = "0x82F2C50", VA = "0x1882F3C50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public bool IPJITSTAPUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x82F3770", Offset = "0x82F2770", VA = "0x1882F3770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x82F4010", Offset = "0x82F3010", VA = "0x1882F4010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action QNSFVWMBBRT
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x82F3420", Offset = "0x82F2420", VA = "0x1882F3420")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x82F3D40", Offset = "0x82F2D40", VA = "0x1882F3D40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action ICHXDFILRSK
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x82F34D0", Offset = "0x82F24D0", VA = "0x1882F34D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x82F3DF0", Offset = "0x82F2DF0", VA = "0x1882F3DF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GWOLVPSUFYY
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x82F3580", Offset = "0x82F2580", VA = "0x1882F3580")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x82F3EA0", Offset = "0x82F2EA0", VA = "0x1882F3EA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HandType, HandVisualState> IYUVGJCMTPG
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x82F3630", Offset = "0x82F2630", VA = "0x1882F3630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x82F3F50", Offset = "0x82F2F50", VA = "0x1882F3F50")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x82EEF50", Offset = "0x82EDF50", VA = "0x1882EEF50")]
		public bool SetDeformation(bool deformBody, bool deformHead)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x82EC410", Offset = "0x82EB410", VA = "0x1882EC410")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x82EE3C0", Offset = "0x82ED3C0", VA = "0x1882EE3C0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x82ED840", Offset = "0x82EC840", VA = "0x1882ED840")]
		protected void JACEVYXFCWI(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x82F24A0", Offset = "0x82F14A0", VA = "0x1882F24A0")]
		protected void WKRZIASFRNB(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x82F23D0", Offset = "0x82F13D0", VA = "0x1882F23D0")]
		protected void WKRZIASFRNB(MeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x82ED580", Offset = "0x82EC580", VA = "0x1882ED580")]
		public float GetHandOpenClosedAxis(HandType handType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x82EF750", Offset = "0x82EE750", VA = "0x1882EF750")]
		public void SetHandOpenClosedAxis(HandType handType, float openClosedAxis)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x82ED5C0", Offset = "0x82EC5C0", VA = "0x1882ED5C0")]
		public HandVisualState GetHandVisualState(HandType handType)
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x82EC260", Offset = "0x82EB260", VA = "0x1882EC260")]
		public bool AddHandVisualStateToken(HandType handType, HandVisualState handVisualState, object token, FVQBSQYSYIK.HandVisualStatePriority priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x82F0450", Offset = "0x82EF450", VA = "0x1882F0450")]
		public void SetWatchHand(HandType handType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x82F0510", Offset = "0x82EF510", VA = "0x1882F0510")]
		public void SetWatchHands(bool showLeftHand, bool showRightHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x82EE7D0", Offset = "0x82ED7D0", VA = "0x1882EE7D0")]
		public bool RemoveHandVisualStateToken(HandType handType, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x82ED670", Offset = "0x82EC670", VA = "0x1882ED670")]
		public bool GetThumbsUpActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x82EFEF0", Offset = "0x82EEEF0", VA = "0x1882EFEF0")]
		public void SetThumbsUpActive(HandType handType, bool thumbsUpActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x82ED630", Offset = "0x82EC630", VA = "0x1882ED630")]
		public bool GetHandshakeActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x82EF8E0", Offset = "0x82EE8E0", VA = "0x1882EF8E0")]
		public void SetHandshakeActive(HandType handType, bool handshakeActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x82ECD40", Offset = "0x82EBD40", VA = "0x1882ECD40")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x82F0360", Offset = "0x82EF360", VA = "0x1882F0360")]
		public void SetUseClassicBeanHandScale(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x82EC840", Offset = "0x82EB840", VA = "0x1882EC840")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x82F2F40", Offset = "0x82F1F40", VA = "0x1882F2F40")]
		private static void YWTZZKUSZRQ(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x82EC9E0", Offset = "0x82EB9E0", VA = "0x1882EC9E0")]
		protected static void DISQCDSZRQG(PlayerAvatarDisplayBase a, List<GCPSWEOHRQA> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x82EE5B0", Offset = "0x82ED5B0", VA = "0x1882EE5B0")]
		public YTAUUGIQSDF Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x82EE170", Offset = "0x82ED170", VA = "0x1882EE170")]
		protected YTAUUGIQSDF KZFEREDPRBA(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x82EE040", Offset = "0x82ED040", VA = "0x1882EE040", Slot = "19")]
		protected virtual YTAUUGIQSDF KZFEREDPRBA(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x82ECF20", Offset = "0x82EBF20", VA = "0x1882ECF20")]
		protected static YTAUUGIQSDF GRDVRBOPEFP(GCPSWEOHRQA a, List<GCPSWEOHRQA> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x82EE550", Offset = "0x82ED550", VA = "0x1882EE550")]
		[IteratorStateMachine(typeof(QAKSHNEJJLV))]
		protected static IEnumerator<ADJUPIXYSVF> PQNKBHDMCBS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x82EE290", Offset = "0x82ED290", VA = "0x1882EE290")]
		protected static GCPSWEOHRQA MACQBTNZDXE(List<GCPSWEOHRQA> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x82EF020", Offset = "0x82EE020", VA = "0x1882EF020")]
		[AsyncStateMachine(typeof(<SetFaceCustomizationSettings>d__130))]
		public Task SetFaceCustomizationSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x82F19B0", Offset = "0x82F09B0", VA = "0x1882F19B0")]
		public bool UpdateFaceAndBodyCustomizationSettings(AvatarData avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x82ED780", Offset = "0x82EC780", VA = "0x1882ED780")]
		public void InitializeFaceFeatures(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x82EFCF0", Offset = "0x82EECF0", VA = "0x1882EFCF0")]
		public void SetTeamColors(Color? teamColor, bool teamOutfitColorEmissionEnabled, Color emissiveColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x82EEC10", Offset = "0x82EDC10", VA = "0x1882EEC10")]
		public void SetBeardPrimaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x82EEDB0", Offset = "0x82EDDB0", VA = "0x1882EEDB0")]
		public void SetBeardSecondaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x82EE9E0", Offset = "0x82ED9E0", VA = "0x1882EE9E0")]
		public void SetBeardPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x82EE700", Offset = "0x82ED700", VA = "0x1882EE700")]
		public void RefreshBeard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x82ECB80", Offset = "0x82EBB80", VA = "0x1882ECB80")]
		private bool ETVNMTMTFJU()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x82EF450", Offset = "0x82EE450", VA = "0x1882EF450")]
		public void SetHairPrimaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x82EF5D0", Offset = "0x82EE5D0", VA = "0x1882EF5D0")]
		public void SetHairSecondaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x82EF120", Offset = "0x82EE120", VA = "0x1882EF120")]
		[AsyncStateMachine(typeof(<SetHairPatternAsync>d__168))]
		public Task SetHairPatternAsync([Optional] AvatarHairPattern pattern)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x82EF210", Offset = "0x82EE210", VA = "0x1882EF210")]
		public void SetHairPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x82EE770", Offset = "0x82ED770", VA = "0x1882EE770")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x82EE1D0", Offset = "0x82ED1D0", VA = "0x1882EE1D0")]
		private bool LXWFHBGQJCW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x82EFBF0", Offset = "0x82EEBF0", VA = "0x1882EFBF0")]
		public void SetSkinColor(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x82F0000", Offset = "0x82EF000", VA = "0x1882F0000")]
		public void SetUgcItemVisualOverrides(AvatarItemSelection overrideItem, AvatarBodyType avatarBodyType, Texture textureOverride, Color colorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x82ECAE0", Offset = "0x82EBAE0", VA = "0x1882ECAE0")]
		private void EGEMBVLMVKY(BodyProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x82ED960", Offset = "0x82EC960", VA = "0x1882ED960")]
		private void JAFMMICFMYV(BodyPropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x82EE320", Offset = "0x82ED320", VA = "0x1882EE320")]
		private void NBNEJCFIPMR(FaceProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x82F0860", Offset = "0x82EF860", VA = "0x1882F0860")]
		private void UKKFVWOQKLB(NoseProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x82ECC30", Offset = "0x82EBC30", VA = "0x1882ECC30")]
		private void FFMLPHFLADO(FacePropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x82EC710", Offset = "0x82EB710", VA = "0x1882EC710")]
		private void CDTRTGGHPWO(NosePropertyData a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x82EFAE0", Offset = "0x82EEAE0", VA = "0x1882EFAE0")]
		public bool SetHideEars(bool hideEars)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x82EFAC0", Offset = "0x82EEAC0", VA = "0x1882EFAC0")]
		public bool SetHelmetHair(HelmetHairState helmetHairState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x82EF9F0", Offset = "0x82EE9F0", VA = "0x1882EF9F0")]
		public void SetHatAnchorParameters(WPRKLXHPVNO newAnchorParams, bool useParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x82EFBD0", Offset = "0x82EEBD0", VA = "0x1882EFBD0")]
		public bool SetShowModestyAndValidationGuidelines(bool showModestyAndValidationGuidelines)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x82F05E0", Offset = "0x82EF5E0", VA = "0x1882F05E0")]
		public void SetupDisplayLODs(LODSelection lodSelection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x82ECD90", Offset = "0x82EBD90", VA = "0x1882ECD90")]
		protected int[] GGWWQOGXNZE(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x82EFB90", Offset = "0x82EEB90", VA = "0x1882EFB90")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x82EFB00", Offset = "0x82EEB00", VA = "0x1882EFB00")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool isFirstPerson, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x82EFB50", Offset = "0x82EEB50", VA = "0x1882EFB50")]
		public YTAUUGIQSDF SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, LODSelection lodSelection, bool isFirstPerson, bool usesBodyPaint, bool forceRebuild = false, bool shouldBuildPotatoAvatar = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x82F2780", Offset = "0x82F1780", VA = "0x1882F2780", Slot = "20")]
		protected virtual YTAUUGIQSDF XXLSUQUATBL(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, LODSelection e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x82F2680", Offset = "0x82F1680", VA = "0x1882F2680")]
		protected int[] XHVKTRLFNCL(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "21")]
		protected virtual LVFVDSAYAGN FSZKNETOYEM(AvatarItemBodyType a, Dictionary<string, LOMDNFCRWZO> b, Dictionary<string, TEHJZDMBIST<Texture2D>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x82F0610", Offset = "0x82EF610", VA = "0x1882F0610", Slot = "22")]
		protected virtual void TVTFLUKNPZL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x82F2080", Offset = "0x82F1080", VA = "0x1882F2080", Slot = "23")]
		protected virtual YTAUUGIQSDF VHOQNSWJXMJ(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, AvatarBuildType f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x82F2A30", Offset = "0x82F1A30", VA = "0x1882F2A30", Slot = "24")]
		protected virtual LOMDNFCRWZO YAFZALBNDTQ(UYRLBEJRVWE a, AvatarItemBodyType b, AvatarBodyPart c, LOMDNFCRWZO d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xACBA90", Offset = "0xACAA90", VA = "0x180ACBA90", Slot = "25")]
		protected virtual LOMDNFCRWZO UVRHSBSXMLK(AvatarItemBodyType a, AvatarBodyPart b, SRKMHFXZOIC c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x82ED700", Offset = "0x82EC700", VA = "0x1882ED700")]
		protected void IMNGVQTUEDW(LSYZGHDZEVS a, BPYBHDTBBFD.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x82F2000", Offset = "0x82F1000", VA = "0x1882F2000")]
		protected void VGOYAGYAOSW(LSYZGHDZEVS a, BPYBHDTBBFD.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xB310D0", Offset = "0xB300D0", VA = "0x180B310D0", Slot = "26")]
		protected virtual LSYZGHDZEVS SMRBDPAXMNJ(LSYZGHDZEVS a, HelmetHairStyle b, bool c, AvatarItemBodyType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x82F0900", Offset = "0x82EF900", VA = "0x1882F0900")]
		protected LSYZGHDZEVS USYKQTHFQPV(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x82F2540", Offset = "0x82F1540", VA = "0x1882F2540")]
		protected BPYBHDTBBFD.SkinCullingMask WPTSNHTNPYR(BPYBHDTBBFD.SkinCullingMask a, AvatarBodyPart b)
		{
			return default(BPYBHDTBBFD.SkinCullingMask);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x82EC910", Offset = "0x82EB910", VA = "0x1882EC910", Slot = "12")]
		[AsyncStateMachine(typeof(<CompleteBuildAsync>d__218))]
		public override Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x82EDEA0", Offset = "0x82ECEA0", VA = "0x1882EDEA0")]
		protected static UpdatableColorType KZAGQVMNMGM(PLPNZYMYIXH a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x82EDB10", Offset = "0x82ECB10", VA = "0x1882EDB10")]
		protected static UpdatableTextureType KIHZZRTWIPG(PLPNZYMYIXH a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x82F0800", Offset = "0x82EF800", VA = "0x1882F0800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x82F03F0", Offset = "0x82EF3F0", VA = "0x1882F03F0")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x82F02B0", Offset = "0x82EF2B0", VA = "0x1882F02B0")]
		public void SetUgcTextureParameters(RHKGGBGWUKB parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x82F32C0", Offset = "0x82F22C0", VA = "0x1882F32C0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x82EE5A0", Offset = "0x82ED5A0", VA = "0x1882EE5A0")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task RVDYCLSLTMZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, OLEOLWASEVR
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct <BuildFaceFeatureStyle>d__171 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			private TaskAwaiter<WSKMPNFCGWP> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x8302370", Offset = "0x8301370", VA = "0x188302370", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x83027A0", Offset = "0x83017A0", VA = "0x1883027A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct <BuildFaceStyleAsyncIfChanged>d__178 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x8302800", Offset = "0x8301800", VA = "0x188302800", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8302BD0", Offset = "0x8301BD0", VA = "0x188302BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct <SetAllFaceFeatureSettings>d__153 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x8302EF0", Offset = "0x8301EF0", VA = "0x188302EF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x83030A0", Offset = "0x83020A0", VA = "0x1883030A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <SetFaceSettings>d__147 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x8303500", Offset = "0x8302500", VA = "0x188303500", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x8303770", Offset = "0x8302770", VA = "0x188303770", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private struct <SetFaceSettings>d__148 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x83037D0", Offset = "0x83027D0", VA = "0x1883037D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x83039B0", Offset = "0x83029B0", VA = "0x1883039B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007A")]
		[CompilerGenerated]
		private struct <SetSelectedFaceFeatureAndBuildFaceStyle>d__149 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x8303E30", Offset = "0x8302E30", VA = "0x188303E30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x8303FD0", Offset = "0x8302FD0", VA = "0x188303FD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		protected const float HLKLWAKCYUF = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		protected const int AUMGQRRDPXJ = 5;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected static readonly Dictionary<WESRXDQNCZQ.Emote, int> KHGYHWONGUQ;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> JPTTBTYIGUN;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected static Vector2 TBEABPYQDZT;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 FYPPIVOUYZA;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 WUEBJKEFIVX;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 LXCRRYNRYKZ;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static Vector2 FELNGOYGOIG;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static Vector2 WVVYJHFOSMN;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static Vector2 QNQMQKFROPZ;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static Vector2 WDCYAFAATLC;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static Vector2 LBXBPTWZOTB;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static Vector2 XYHLKXDZFWL;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static Vector2 MLNUZEFEFKA;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static Vector2 XULZSJKEBZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private AvatarBodyType VILTCEOXGNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private FaceStyleSet HDZTJEANALO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected const int NNXUAACFDUM = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected int NHDUXEAHHFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected int ELQJXKWPQWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected int GZOVGLQZRVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected int LPLBBHTYSDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected Vector2 VQBNRCATPLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected float KYJQYGRBTPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected float XKSDQEYVVIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected float LOXJWMHYGXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected Vector2 GCSCCWXOJKX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected float IZHWFKSRWVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected float NUYKZWLGGRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected float NYDRVAOHTZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected Vector2 XZJYXUZQZFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected float RGURTQESLVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected float QWYRUPUTFVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected float UGWICCRCTWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected Vector2 NTOJBXKDTCZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected float KSYHEPXCUPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected float ALWLVUMPASH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected float KZFMNAKKVQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected List<SelectableFaceOption> CECKGYTZLBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected List<SelectableFaceOption> XHRNZUGSHYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected List<SelectableFaceOption> AZMUXKKHZTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected List<SelectableFaceOption> KFCBCNPXZKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected int? LXYMQAJZEAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected int UXXZWPMHYZK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected int ANOTGCGAMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected int DIZMOMLQXXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected int KTWSVRAMYYF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected Sprite TOEUMGGLGKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected Sprite JISQYSGTHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Sprite XTICGGYDRDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected Sprite GGVBZTKXTSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected bool PHTDWXHWAJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected string RWHBKJFUWPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected string ADZRBDBZIVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected string MMUMVTZWJRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected string IRIEXCPEWIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected AvatarConfiguration CLGWFLSCVKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected WSKMPNFCGWP EURMSOINIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Dictionary<string, int> DSQSQETZJQZ;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public FaceStyleSet BWEWGMZEDKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x82F9DF0", Offset = "0x82F8DF0", VA = "0x1882F9DF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x82F9E40", Offset = "0x82F8E40", VA = "0x1882F9E40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x19A23E0", Offset = "0x19A13E0", VA = "0x1819A23E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool LGNGYTYGOHT
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xB166F0", Offset = "0xB156F0", VA = "0x180B166F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected virtual bool CXEWGTMSEVP
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xAE6390", Offset = "0xAE5390", VA = "0x180AE6390", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected int NXWMWTPWCYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x82F7AD0", Offset = "0x82F6AD0", VA = "0x1882F7AD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool OMTSJCGBXZN
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xC84570", Offset = "0xC83570", VA = "0x180C84570")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x19A23D0", Offset = "0x19A13D0", VA = "0x1819A23D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] BTJTGQLMTYM
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xAD2F40", Offset = "0xAD1F40", VA = "0x180AD2F40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool BHAFZATXSCX
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x82F9E50", Offset = "0x82F8E50", VA = "0x1882F9E50")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x82FA010", Offset = "0x82F9010", VA = "0x1882FA010")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int OJCFLBLPBQK
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x82F6EF0", Offset = "0x82F5EF0", VA = "0x1882F6EF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int ZVQEZFJXPBO
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x82F6B00", Offset = "0x82F5B00", VA = "0x1882F6B00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float HUYNJTNXMYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x82F9E20", Offset = "0x82F8E20", VA = "0x1882F9E20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x82F9FF0", Offset = "0x82F8FF0", VA = "0x1882F9FF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public YQUMJVMQBIV KOMGWMIXKIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xD065B0", Offset = "0xD055B0", VA = "0x180D065B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x12AFCF0", Offset = "0x12AECF0", VA = "0x1812AFCF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public WSKMPNFCGWP RKIZPEPPUDP
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xD06590", Offset = "0xD05590", VA = "0x180D06590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x82F9F70", Offset = "0x82F8F70", VA = "0x1882F9F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption BSEKHHHRDIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xD06580", Offset = "0xD05580", VA = "0x180D06580")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x14B0CE0", Offset = "0x14AFCE0", VA = "0x1814B0CE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action NOVUMOWGBCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x82F9D40", Offset = "0x82F8D40", VA = "0x1882F9D40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x82F9EC0", Offset = "0x82F8EC0", VA = "0x1882F9EC0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x82F6430", Offset = "0x82F5430", VA = "0x1882F6430")]
		public void LocalPlayEmote(WESRXDQNCZQ.Emote emote, float normalizedTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x82F62B0", Offset = "0x82F52B0", VA = "0x1882F62B0")]
		public bool IsEmotePlaying(WESRXDQNCZQ.Emote emote)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x82F7940", Offset = "0x82F6940", VA = "0x1882F7940")]
		public void SetIdleHappy(bool happy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x82F4D10", Offset = "0x82F3D10", VA = "0x1882F4D10")]
		protected void FRCFGPGIZGJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x82F6720", Offset = "0x82F5720", VA = "0x1882F6720")]
		protected void PNUOAVOUNTG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x82F8E00", Offset = "0x82F7E00", VA = "0x1882F8E00")]
		protected void XXXGZZSBIEY(AvatarBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x82F63C0", Offset = "0x82F53C0", VA = "0x1882F63C0")]
		protected void JHIFQWJAMVT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x82F6AE0", Offset = "0x82F5AE0", VA = "0x1882F6AE0")]
		public void PlayExpression(int hashID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x82F8D50", Offset = "0x82F7D50", VA = "0x1882F8D50")]
		protected void WVTBVNFXEZI(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x82F5D80", Offset = "0x82F4D80", VA = "0x1882F5D80")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType featureType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x82F5DC0", Offset = "0x82F4DC0", VA = "0x1882F5DC0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x82F75E0", Offset = "0x82F65E0", VA = "0x1882F75E0")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__147))]
		public Task SetFaceSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x82F76D0", Offset = "0x82F66D0", VA = "0x1882F76D0")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__148))]
		public Task SetFaceSettings(int eyeSelection, int eyeBrowSelection, int noseSelection, int mouthSelection, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x82F79C0", Offset = "0x82F69C0", VA = "0x1882F79C0")]
		[AsyncStateMachine(typeof(<SetSelectedFaceFeatureAndBuildFaceStyle>d__149))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType featureType, int selectionIndex, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x82F4B90", Offset = "0x82F3B90", VA = "0x1882F4B90")]
		protected void FGANRDVYLRP(FaceFeatureType a, FaceFeatureId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x82F5490", Offset = "0x82F4490", VA = "0x1882F5490")]
		protected void GZGSJJQYRJS(FaceFeatureType a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x82F5BD0", Offset = "0x82F4BD0", VA = "0x1882F5BD0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x82F7CE0", Offset = "0x82F6CE0", VA = "0x1882F7CE0")]
		[AsyncStateMachine(typeof(<SetAllFaceFeatureSettings>d__153))]
		protected Task UFRMANCZWXC(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x82F8A50", Offset = "0x82F7A50", VA = "0x1882F8A50")]
		protected void WRYVFMCPOPF(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x82F4930", Offset = "0x82F3930", VA = "0x1882F4930")]
		protected static void DHPGSBAKPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x82F6880", Offset = "0x82F5880", VA = "0x1882F6880")]
		private void PQGKLGQRUSJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x82F6B60", Offset = "0x82F5B60", VA = "0x1882F6B60")]
		protected void RNUZHLLIVZE(FaceFeatureType a, Vector2 b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x82F7030", Offset = "0x82F6030", VA = "0x1882F7030")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType featureType, Vector2 normalizedPositionOffset, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x82F8F40", Offset = "0x82F7F40", VA = "0x1882F8F40")]
		protected void ZNPMJLDTVTB(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x82F6520", Offset = "0x82F5520", VA = "0x1882F6520")]
		protected void NVPRYTFLUZO(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x82F8E70", Offset = "0x82F7E70", VA = "0x1882F8E70")]
		protected void ZDPMDDRHXNU(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x82F73C0", Offset = "0x82F63C0", VA = "0x1882F73C0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType featureType, float normalizedScale, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x82F6F50", Offset = "0x82F5F50", VA = "0x1882F6F50")]
		[AsyncStateMachine(typeof(<BuildFaceFeatureStyle>d__171))]
		protected Task SSCNHDQFVYL(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x82F60C0", Offset = "0x82F50C0", VA = "0x1882F60C0")]
		public void InitializeFaceFeatureStyleSet(AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x82F7C00", Offset = "0x82F6C00", VA = "0x1882F7C00")]
		protected bool UBRGZYDKOSI(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x82F46F0", Offset = "0x82F36F0", VA = "0x1882F46F0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x15FF050", Offset = "0x15FE050", VA = "0x1815FF050", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x82F66A0", Offset = "0x82F56A0", VA = "0x1882F66A0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x82F4830", Offset = "0x82F3830", VA = "0x1882F4830")]
		[AsyncStateMachine(typeof(<BuildFaceStyleAsyncIfChanged>d__178))]
		public Task BuildFaceStyleAsyncIfChanged(AvatarBodyType avatarBodyType, bool forceRebuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x82F86E0", Offset = "0x82F76E0", VA = "0x1882F86E0")]
		public void UpdateFaceDisplays(bool forceUpdateFaceTextures = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x82F4D90", Offset = "0x82F3D90", VA = "0x1882F4D90")]
		protected void FYMBMYIATBB(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x82F8440", Offset = "0x82F7440", VA = "0x1882F8440")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x82F7800", Offset = "0x82F6800", VA = "0x1882F7800")]
		public void SetFaceSpriteIndices(string leftEyeName, string rightEyeName, string mouthName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x82F7DD0", Offset = "0x82F6DD0", VA = "0x1882F7DD0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x82F8860", Offset = "0x82F7860", VA = "0x1882F8860")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x82F4AA0", Offset = "0x82F3AA0", VA = "0x1882F4AA0")]
		protected void EFXXSMXHFOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x82F9B50", Offset = "0x82F8B50", VA = "0x1882F9B50")]
		public PlayerFacialAnimatorBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xAF83D0", Offset = "0xAF73D0", VA = "0x180AF83D0", Slot = "4")]
		private bool MYJWFGSQJIY()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct ModernBodyFacialExpression
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public int Id;
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class GECQAWRKPZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public NoseType VTHICBGGLNS;

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public GECQAWRKPZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xC0AEE0", Offset = "0xC09EE0", VA = "0x180C0AEE0")]
			internal bool UKPNNJJAERM(NoseShapePropertyData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class TTTRQEZRJXB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public PlayerModernBodyEditorAvatarValidator SULNKEFFSGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public GameObject XVWHNYMVRGE;

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public TTTRQEZRJXB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x83021F0", Offset = "0x83011F0", VA = "0x1883021F0")]
			internal void AKLLIDFCEXJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x83021C0", Offset = "0x83011C0", VA = "0x1883021C0")]
			internal void AKGEKWLEVMA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x8302250", Offset = "0x8301250", VA = "0x188302250")]
			internal void AKVZCQSWXUB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x8302220", Offset = "0x8301220", VA = "0x188302220")]
			internal void AKQSFJYZOIS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x8302130", Offset = "0x8301130", VA = "0x188302130")]
			internal void AJQJTCDMTDZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x8302100", Offset = "0x8301100", VA = "0x188302100")]
			internal void AJLCVVJPJSQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x8302190", Offset = "0x8301190", VA = "0x188302190")]
			internal void AKAXNPRHMAR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x8302160", Offset = "0x8301160", VA = "0x188302160")]
			internal void AJVQQIXKCPI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x83022B0", Offset = "0x83012B0", VA = "0x1883022B0")]
			internal void AMBOMFIHCKD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x8302280", Offset = "0x8301280", VA = "0x188302280")]
			internal void ALWHOYOJSYU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x83022E0", Offset = "0x83012E0", VA = "0x1883022E0")]
			internal void LRLMBJYVLLS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x8302310", Offset = "0x8301310", VA = "0x188302310")]
			internal void LRQSYQSSUXB()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private struct <UpdateFaceFeatures>d__140 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x8304B80", Offset = "0x8303B80", VA = "0x188304B80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xB2F8E0", Offset = "0xB2E8E0", VA = "0x180B2F8E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		[CompilerGenerated]
		private struct <UpdateFaceFeaturesInternal>d__141 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x83045C0", Offset = "0x83035C0", VA = "0x1883045C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x8304B20", Offset = "0x8303B20", VA = "0x188304B20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public AvatarBodyType avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public HelmetHairState useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public WPRKLXHPVNO hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public UDDQBRVVSHI HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public GameObject torsoModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public GameObject legsModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public GameObject validationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public bool showModestyAndValidationGuidelines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		private CMVBAHPOEER FZYPELEVNZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public BodyShapeConfiguration bodyShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public FaceShapeConfiguration faceShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public NoseShapeConfiguration noseShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		private AnimatorOverrideController JODKJXQSUBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> BDAAIGPJIKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public readonly ModernBodyFacialExpression[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public readonly (string, HandVisualState)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x272")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		protected bool QKPBFCCNDRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		protected Guid EOYCVFQWQHS;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		protected static Guid IDWCJLSQFXF;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private static readonly int JEBWTAGVOCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private NVMYCLIJNAG UADEHHLNZQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private YQUMJVMQBIV AXZDRFHEQYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private MKOZOBXCSZX FGMHTQLLERB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private MKOZOBXCSZX TEOIVEFDTAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private AdditionalHatData BVQUCDMHWNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private readonly Dictionary<GameObject, UYRLBEJRVWE> EVYYAONCUGI;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public static Func<SRKMHFXZOIC> MSXUEPFXEBK
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x8300500", Offset = "0x82FF500", VA = "0x188300500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x8300B40", Offset = "0x82FFB40", VA = "0x188300B40")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool LXWFHBGQJCW
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x8300660", Offset = "0x82FF660", VA = "0x188300660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool ETVNMTMTFJU
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x8300550", Offset = "0x82FF550", VA = "0x188300550")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public PlayerAvatarDisplayBase SRXUUKWXODO
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xB50C00", Offset = "0xB4FC00", VA = "0x180B50C00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		protected static Guid HLGTQOIYOHG
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x82FBC10", Offset = "0x82FAC10", VA = "0x1882FBC10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public (GameObject prefab, AvatarBodyPart part)[] EPADFCOCBEN
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x8300770", Offset = "0x82FF770", VA = "0x188300770")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x82FD7D0", Offset = "0x82FC7D0", VA = "0x1882FD7D0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x82FAE70", Offset = "0x82F9E70", VA = "0x1882FAE70")]
		private IEnumerable<GameObject> DJIJPXFZMCS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x82FDCF0", Offset = "0x82FCCF0", VA = "0x1882FDCF0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x82FB050", Offset = "0x82FA050", VA = "0x1882FB050")]
		private void DXOKDJFEJYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x130F420", Offset = "0x130E420", VA = "0x18130F420")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x82FB4B0", Offset = "0x82FA4B0", VA = "0x1882FB4B0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x82FDD00", Offset = "0x82FCD00", VA = "0x1882FDD00")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x82FDB10", Offset = "0x82FCB10", VA = "0x1882FDB10")]
		public void ShowPose(AnimationClip pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x82FDCC0", Offset = "0x82FCCC0", VA = "0x1882FDCC0")]
		public void ShowPose(string poseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x82FD940", Offset = "0x82FC940", VA = "0x1882FD940")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x82FD7E0", Offset = "0x82FC7E0", VA = "0x1882FD7E0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x82FED70", Offset = "0x82FDD70", VA = "0x1882FED70")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x82FE6E0", Offset = "0x82FD6E0", VA = "0x1882FE6E0")]
		public void UpdateFaceAndBodyShapes(bool forceRebuild = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x82FF190", Offset = "0x82FE190", VA = "0x1882FF190")]
		public void UpdateNoseShape(NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x82FF150", Offset = "0x82FE150", VA = "0x1882FF150")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x82FC090", Offset = "0x82FB090", VA = "0x1882FC090", Slot = "4")]
		protected virtual void KVATGNLVJDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x82FB150", Offset = "0x82FA150", VA = "0x1882FB150", Slot = "5")]
		protected virtual void EXSUPIDYJJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x82FA340", Offset = "0x82F9340", VA = "0x1882FA340")]
		public void ApplyHatData(AdditionalHatData hatData, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x82FA180", Offset = "0x82F9180", VA = "0x1882FA180")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x82FA6A0", Offset = "0x82F96A0", VA = "0x1882FA6A0")]
		public void ApplyHatUVOverride(Vector2 UVOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x82FA5C0", Offset = "0x82F95C0", VA = "0x1882FA5C0")]
		public void ApplyHatPositionAdjustment(Vector3 positionAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x82FA630", Offset = "0x82F9630", VA = "0x1882FA630")]
		public void ApplyHatRotationAdjustment(Vector3 rotationAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x82FA710", Offset = "0x82F9710", VA = "0x1882FA710")]
		public AvatarItemSelection BuildAvatarItemSelection(GameObject selection, AvatarBodyType bodyType, AvatarBodyPart part)
		{
			return default(AvatarItemSelection);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x82FA7B0", Offset = "0x82F97B0", VA = "0x1882FA7B0")]
		public void BuildAvatar(bool forceRebuild = false, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x82FE040", Offset = "0x82FD040", VA = "0x1882FE040")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x82FA2C0", Offset = "0x82F92C0", VA = "0x1882FA2C0")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x82FEFA0", Offset = "0x82FDFA0", VA = "0x1882FEFA0")]
		public void UpdateHatAnchor(bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x82FECC0", Offset = "0x82FDCC0", VA = "0x1882FECC0")]
		[AsyncStateMachine(typeof(<UpdateFaceFeatures>d__140))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x82FA0B0", Offset = "0x82F90B0", VA = "0x1882FA0B0")]
		[AsyncStateMachine(typeof(<UpdateFaceFeaturesInternal>d__141))]
		private Task AFSRJVLYMWF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x82FCC60", Offset = "0x82FBC60", VA = "0x1882FCC60")]
		private void MHSWOGBGJVN(FaceFeatureType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x82FD740", Offset = "0x82FC740", VA = "0x1882FD740")]
		private void QBNDKJVRECT(FaceFeatureType a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x82FE5A0", Offset = "0x82FD5A0", VA = "0x1882FE5A0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x82FF4D0", Offset = "0x82FE4D0", VA = "0x1882FF4D0")]
		public void UpdatePosingProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x82FEE00", Offset = "0x82FDE00", VA = "0x1882FEE00")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x82FC730", Offset = "0x82FB730", VA = "0x1882FC730")]
		private void LZAOYRDXTJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private void EKOVFAMJWJQ(UYRLBEJRVWE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xACBA80", Offset = "0xACAA80", VA = "0x180ACBA80")]
		private void LLENBERLOZY(UYRLBEJRVWE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x82FC3B0", Offset = "0x82FB3B0", VA = "0x1882FC3B0")]
		private void LEKBNDPXFNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x82FCF20", Offset = "0x82FBF20", VA = "0x1882FCF20")]
		public void PopulatePrefabSlotsByGuid(List<Guid> guids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x82FF570", Offset = "0x82FE570", VA = "0x1882FF570")]
		private void YMVZELFJMFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x82FBD00", Offset = "0x82FAD00", VA = "0x1882FBD00")]
		private void JYCRKVRQYUB(OutfitType a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x82FF860", Offset = "0x82FE860", VA = "0x1882FF860")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x82FB470", Offset = "0x82FA470", VA = "0x1882FB470")]
		[CompilerGenerated]
		private bool HPALDQUAQMS(FaceShapePropertyData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x82FB3C0", Offset = "0x82FA3C0", VA = "0x1882FB3C0")]
		[CompilerGenerated]
		private AvatarItemSelection GWBLKCBIEEG((GameObject prefab, AvatarBodyPart part) h)
		{
			return default(AvatarItemSelection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[AddComponentMenu("/")]
	public class RoomiePuppet : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000083")]
		public class RoomieAvatarReferences
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			public Transform hatAnchorBone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			public AvatarSkinnedMeshBoneOrderRemapsData boneOrderRemap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			public SkinnedMeshRenderer roomieBaseSkinnedMeshRenderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public Material[] roomieBaseMaterials;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public AssetReference roomieBodyAssetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public Transform deformRigRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public GameObject generatedMeshContainer;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public RoomieAvatarReferences()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E9")]
		public RoomieAvatarDisplay avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		[SerializeField]
		private RoomieAvatarReferences _references;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x83010C0", Offset = "0x83000C0", VA = "0x1883010C0")]
		public void SetOutfitItems(IEnumerable<Guid> avatarItemGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x8300F10", Offset = "0x82FFF10", VA = "0x188300F10")]
		public void InitializeAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public RoomiePuppet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xACBA70", Offset = "0xACAA70", VA = "0x180ACBA70")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public struct AvatarItemSelection : IEquatable<AvatarItemSelection>
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class UGWSJTRGBHL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public IEnumerable<OutfitType> ERIZMRUEVEJ;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public UGWSJTRGBHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x83056F0", Offset = "0x83046F0", VA = "0x1883056F0")]
			internal bool HZUTCTWAEAG(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private UYRLBEJRVWE _avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private AvatarBodyPart _bodyPart;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public UYRLBEJRVWE UYLDUYJSOYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xC41C30", Offset = "0xC40C30", VA = "0x180C41C30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public AvatarBodyPart CRBZSMAAHKC
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xC41C40", Offset = "0xC40C40", VA = "0x180C41C40")]
			get
			{
				return default(AvatarBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public string LFCZHHAXZHK
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x82EA580", Offset = "0x82E9580", VA = "0x1882EA580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public bool HHGZSIGFWAS
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x82EA2B0", Offset = "0x82E92B0", VA = "0x1882EA2B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool ABZMCWJOXSJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x82E9DB0", Offset = "0x82E8DB0", VA = "0x1882E9DB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool WDPUOFLDIBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x82EA100", Offset = "0x82E9100", VA = "0x1882EA100")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x82E9E00", Offset = "0x82E8E00", VA = "0x1882E9E00", Slot = "4")]
		public bool Equals(AvatarItemSelection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x82EA060", Offset = "0x82E9060", VA = "0x1882EA060", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x82EA150", Offset = "0x82E9150", VA = "0x1882EA150", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1887C40", Offset = "0x1886C40", VA = "0x181887C40")]
		public AvatarItemSelection(UYRLBEJRVWE avatarItem, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x82EA300", Offset = "0x82E9300", VA = "0x1882EA300")]
		public bool QZPNLWCNDXL(OutfitType a, AvatarBodyPart b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x82EA670", Offset = "0x82E9670", VA = "0x1882EA670")]
		public bool YOMQUMDFYSK(AvatarItemSelection a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class NVZKJTYIICM
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class TOHYPVNORKX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public IEnumerable<OutfitType> ERIZMRUEVEJ;

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xAD2EF0", Offset = "0xAD1EF0", VA = "0x180AD2EF0")]
			public TOHYPVNORKX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x8305670", Offset = "0x8304670", VA = "0x188305670")]
			internal bool HZUTCTWAEAG(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private UYRLBEJRVWE HDYKVDFWDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private RoomieBodyPart TABEEGNATNT;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public UYRLBEJRVWE UYLDUYJSOYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xACF720", Offset = "0xACE720", VA = "0x180ACF720")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public RoomieBodyPart CRBZSMAAHKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xAD05F0", Offset = "0xACF5F0", VA = "0x180AD05F0")]
			get
			{
				return default(RoomieBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Color? RQAVQDJHTIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xAD8A10", Offset = "0xAD7A10", VA = "0x180AD8A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xAD83F0", Offset = "0xAD73F0", VA = "0x180AD83F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3? YRTIXTFJRMF
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xCE1A80", Offset = "0xCE0A80", VA = "0x180CE1A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xCE1B60", Offset = "0xCE0B60", VA = "0x180CE1B60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x8305600", Offset = "0x8304600", VA = "0x188305600")]
		public NVZKJTYIICM(UYRLBEJRVWE a, RoomieBodyPart b, Color? c, Vector3? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x83054E0", Offset = "0x83044E0", VA = "0x1883054E0")]
		public bool YOMQUMDFYSK(NVZKJTYIICM a)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1757702127
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x8305780", Offset = "0x8304780", VA = "0x188305780")]
	public static void WGYJPSYGJZZ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x8305770", Offset = "0x8304770", VA = "0x188305770")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
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
