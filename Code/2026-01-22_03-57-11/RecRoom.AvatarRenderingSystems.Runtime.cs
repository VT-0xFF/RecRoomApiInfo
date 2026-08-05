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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7810", Offset = "0xAD6010", VA = "0x180AD7810")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD7850", Offset = "0xAD6050", VA = "0x180AD7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x8133A20", Offset = "0x8132220", VA = "0x188133A20", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		private RecNetCDNKey TVIXTBMOZHI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RecNetCDNKey TypedRuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0E0", Offset = "0xAAB8E0", VA = "0x180AAD0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC84C50", Offset = "0xC83450", VA = "0x180C84C50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8133D80", Offset = "0x8132580", VA = "0x188133D80", Slot = "19")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8133DB0", Offset = "0x81325B0", VA = "0x188133DB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAACB10", Offset = "0xAAB310", VA = "0x180AACB10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAB0160", Offset = "0xAAE960", VA = "0x180AB0160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAB0170", Offset = "0xAAE970", VA = "0x180AB0170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB046C0", Offset = "0xB02EC0", VA = "0x180B046C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB045B0", Offset = "0xB02DB0", VA = "0x180B045B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ItemPathHint PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCBFFA0", Offset = "0xCBE7A0", VA = "0x180CBFFA0")]
			[CompilerGenerated]
			get
			{
				return default(ItemPathHint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD06E10", Offset = "0xD05610", VA = "0x180D06E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8133EC0", Offset = "0x81326C0", VA = "0x188133EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8133E40", Offset = "0x8132640", VA = "0x188133E40")]
		public static RecNetCDNKey IXPUTZZMRBR(string a, ItemPathHint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8133DF0", Offset = "0x81325F0", VA = "0x188133DF0")]
		public void BAWBCWCIIUI(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public RecNetCDNKey()
		{
		}
	}
}
namespace RecRoom.AI.RoomieAI
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomieAvatarDisplay : AvatarDisplayBase, FPMWPTESEEW
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct EquipResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public IEnumerable<VLWQEDFNTAI> equippedItems;

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
				[Cpp2IlInjected.Address(RVA = "0xC7C0A0", Offset = "0xC7A8A0", VA = "0x180C7C0A0")]
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
				[Cpp2IlInjected.Address(RVA = "0xABE4C0", Offset = "0xABCCC0", VA = "0x180ABE4C0")]
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
				[Cpp2IlInjected.Address(RVA = "0xBF78B0", Offset = "0xBF60B0", VA = "0x180BF78B0")]
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
				[Cpp2IlInjected.Address(RVA = "0x8133A00", Offset = "0x8132200", VA = "0x188133A00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x81339A0", Offset = "0x81321A0", VA = "0x1881339A0")]
			public DisplayItemData(Guid customAvatarItemId, Vector3? rotation, Color? color, RoomieBodyPart part)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <AvatarRuntimeBuildMeshRoutine>d__125 : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private ZCECIALXIMT <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public List<EORTYFSETCJ> parts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public RoomieAvatarDisplay <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public List<MZYNOYQSBYJ> innerPromises;

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
			private ZCECIALXIMT System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public <AvatarRuntimeBuildMeshRoutine>d__125(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x81397A0", Offset = "0x8137FA0", VA = "0x1881397A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x81399D0", Offset = "0x81381D0", VA = "0x1881399D0", Slot = "8")]
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
		private readonly List<CVLYOHHWPFK> _nextPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<CVLYOHHWPFK> _currentPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<CVLYOHHWPFK> _nextMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<CVLYOHHWPFK> _currentMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<DisplayItemData> _EquippedDisplayItemOutfitSelections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly IList<VLWQEDFNTAI> _currentEquippedOutfitSelections;

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
		private readonly XOOCNKBZGKP _buildCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly XOOCNKBZGKP _buildCancelled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private SkinnedMeshRenderer[] _cachedBuiltBodySkinMeshes;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public XOOCNKBZGKP DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xB30720", Offset = "0xB2EF20", VA = "0x180B30720", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public XOOCNKBZGKP DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xCE6460", Offset = "0xCE4C60", VA = "0x180CE6460", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xACB460", Offset = "0xAC9C60", VA = "0x180ACB460", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8139780", Offset = "0x8137F80", VA = "0x188139780", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xCE6450", Offset = "0xCE4C50", VA = "0x180CE6450", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xBBCC60", Offset = "0xBBB460", VA = "0x180BBCC60", Slot = "35")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform HatBone
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public XOOCNKBZGKP OnAnimationCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8139740", Offset = "0x8137F40", VA = "0x188139740")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8139630", Offset = "0x8137E30", VA = "0x188139630", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PositionAndRotation HatPivotLocalPosAndRot
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8139670", Offset = "0x8137E70", VA = "0x188139670", Slot = "56")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public YUYCEVTIIQN.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x81395E0", Offset = "0x8137DE0", VA = "0x1881395E0", Slot = "32")]
			get
			{
				return default(YUYCEVTIIQN.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8134520", Offset = "0x8132D20", VA = "0x188134520", Slot = "51")]
		protected virtual VLWQEDFNTAI AvatarItemDefinitionFromDisplayItemDefinition(DisplayItemData displayItemData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8136CB0", Offset = "0x81354B0", VA = "0x188136CB0")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8138F10", Offset = "0x8137710", VA = "0x188138F10")]
		private void _UpdateManualLod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8137250", Offset = "0x8135A50", VA = "0x188137250")]
		private void QueuePostBuiltAvatarCustomizationUpdate(Action updateMatPropertAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8134450", Offset = "0x8132C50", VA = "0x188134450")]
		private void ApplyQueuedCustomizationUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8133F30", Offset = "0x8132730", VA = "0x188133F30")]
		private void ApplyColorsToInstances()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8136640", Offset = "0x8134E40", VA = "0x188136640", Slot = "28")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8136BA0", Offset = "0x81353A0", VA = "0x188136BA0")]
		private PositionAndRotation GetHatAdjustmentOrDefault()
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x81342F0", Offset = "0x8132AF0", VA = "0x1881342F0", Slot = "45")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8136C80", Offset = "0x8135480", VA = "0x188136C80", Slot = "48")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8137050", Offset = "0x8135850", VA = "0x188137050")]
		public Task PlayAnimation(string animationName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8138700", Offset = "0x8136F00", VA = "0x188138700", Slot = "17")]
		public void SetUgcItemVisualOverrides(VLWQEDFNTAI overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8138780", Offset = "0x8136F80", VA = "0x188138780", Slot = "18")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8138740", Offset = "0x8136F40", VA = "0x188138740", Slot = "19")]
		public void SetUgcTextureParameters(PCLHBEYKOMB parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8138DD0", Offset = "0x81375D0", VA = "0x188138DD0", Slot = "49")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8138ED0", Offset = "0x81376D0", VA = "0x188138ED0", Slot = "50")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties effectFloat4Properties, TextureEffectMaterialTextures effectTexture2DProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8137560", Offset = "0x8135D60", VA = "0x188137560", Slot = "46")]
		public void SetHatAnchorParams(SDZUMEDZFPG anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8138E50", Offset = "0x8137650", VA = "0x188138E50", Slot = "47")]
		public void UpdateHatPivot([Optional] SDZUMEDZFPG anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x81344E0", Offset = "0x8132CE0", VA = "0x1881344E0", Slot = "23")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x81388F0", Offset = "0x81370F0", VA = "0x1881388F0")]
		public void Setup([In] AvatarDisplaySetupState _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x81373A0", Offset = "0x8135BA0", VA = "0x1881373A0", Slot = "33")]
		public bool SetBaseSkinCullingMask(YUYCEVTIIQN.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8137460", Offset = "0x8135C60", VA = "0x188137460", Slot = "20")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8138680", Offset = "0x8136E80", VA = "0x188138680", Slot = "21")]
		public void SetSkinColors(Color skinColor, Color? skinEmissiveColor, float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8136380", Offset = "0x8134B80", VA = "0x188136380", Slot = "27")]
		public MZYNOYQSBYJ BuildPotatoAvatar(ZVZUWTELACM avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x81386C0", Offset = "0x8136EC0", VA = "0x1881386C0", Slot = "22")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8137520", Offset = "0x8135D20", VA = "0x188137520")]
		public void SetFaceShape(AvatarFaceShape faceShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8137420", Offset = "0x8135C20", VA = "0x188137420")]
		public void SetBodyShape(AvatarBodyShape bodyShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x81373E0", Offset = "0x8135BE0", VA = "0x1881373E0", Slot = "37")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8133EF0", Offset = "0x81326F0", VA = "0x188133EF0", Slot = "38")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x81374E0", Offset = "0x8135CE0", VA = "0x1881374E0", Slot = "39")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x81375C0", Offset = "0x8135DC0", VA = "0x1881375C0", Slot = "40")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x81342B0", Offset = "0x8132AB0", VA = "0x1881342B0", Slot = "41")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8134410", Offset = "0x8132C10", VA = "0x188134410", Slot = "42")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8137600", Offset = "0x8135E00", VA = "0x188137600")]
		public void SetNoseType(NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x81374A0", Offset = "0x8135CA0", VA = "0x1881374A0", Slot = "43")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8138E10", Offset = "0x8137610", VA = "0x188138E10", Slot = "44")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8138E90", Offset = "0x8137690", VA = "0x188138E90", Slot = "53")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8136640", Offset = "0x8134E40", VA = "0x188136640")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xCE65E0", Offset = "0xCE4DE0", VA = "0x180CE65E0", Slot = "54")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayThirdPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "55")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayFirstPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x81342F0", Offset = "0x8132AF0", VA = "0x1881342F0")]
		public void OnLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x81370B0", Offset = "0x81358B0", VA = "0x1881370B0")]
		private void PostOutfitUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x8137090", Offset = "0x8135890", VA = "0x188137090")]
		private void PostMeshBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x81375A0", Offset = "0x8135DA0", VA = "0x1881375A0", Slot = "16")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x81384F0", Offset = "0x8136CF0", VA = "0x1881384F0")]
		public void SetRoomieBoostCustomizationFloat(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8138580", Offset = "0x8136D80", VA = "0x188138580")]
		public void SetRoomiePrimarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8138600", Offset = "0x8136E00", VA = "0x188138600")]
		public void SetRoomieSecondarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8137640", Offset = "0x8135E40", VA = "0x188137640")]
		public Task<EquipResult> SetOutfitSelection(IReadOnlyList<DisplayItemData> displayItemDatas, bool forceBuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x81363C0", Offset = "0x8134BC0", VA = "0x1881363C0")]
		private List<VLWQEDFNTAI> CreateEquippedItemsFrorOutfitSelection(IReadOnlyList<Guid> customAvatarItemIds, IReadOnlyList<DisplayItemData> correspondingDADs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8134F60", Offset = "0x8133760", VA = "0x188134F60", Slot = "26")]
		public MZYNOYQSBYJ BuildAvatarMeshes(ZVZUWTELACM avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, VLWQEDFNTAI>, (MZYNOYQSBYJ, JIREGIBPOUE<Dictionary<string, XTMHCAFEIFZ<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8136AA0", Offset = "0x81352A0", VA = "0x188136AA0")]
		private bool GetCustomizationRequiresMeshBuild(List<DisplayItemData> newItemSelections)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8138C50", Offset = "0x8137450", VA = "0x188138C50")]
		private void TeardownInProgressBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x81349B0", Offset = "0x81331B0", VA = "0x1881349B0")]
		public MZYNOYQSBYJ BuildAvatarMeshesInternal(ZVZUWTELACM avatarBuildParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8138930", Offset = "0x8137130", VA = "0x188138930")]
		private void SwapActiveResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8137350", Offset = "0x8135B50", VA = "0x188137350")]
		private void ReleasePrefabs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8136920", Offset = "0x8135120", VA = "0x188136920")]
		private void FinalizeRoomieDisplayUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8136FF0", Offset = "0x81357F0", VA = "0x188136FF0")]
		private bool IsReadyToBuildLODMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8136710", Offset = "0x8134F10", VA = "0x188136710")]
		private MZYNOYQSBYJ EditorBuildMeshes(bool isFirstPerson, List<EORTYFSETCJ> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x81387C0", Offset = "0x8136FC0", VA = "0x1881387C0")]
		private void SetupNewlyCreatedMesh(SkinnedMeshRenderer lodRenderer, int lod, Mesh mesh, List<Material> newUniqueMaterials)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8134F70", Offset = "0x8133770", VA = "0x188134F70")]
		private BFFPISQCYKM BuildLODMesh(List<EORTYFSETCJ> parts, int lod, bool isFirstPerson, Layers layer, bool IsSpreadAcrossFrames = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x81348D0", Offset = "0x81330D0", VA = "0x1881348D0")]
		[IteratorStateMachine(typeof(<AvatarRuntimeBuildMeshRoutine>d__125))]
		private IEnumerator<ZCECIALXIMT> AvatarRuntimeBuildMeshRoutine(bool isFirstPerson, List<EORTYFSETCJ> parts, int[] LODs, Func<int, Layers> getLayer, List<MZYNOYQSBYJ> innerPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x81360C0", Offset = "0x81348C0", VA = "0x1881360C0")]
		private MZYNOYQSBYJ BuildLODMeshes(bool isFirstPerson, List<EORTYFSETCJ> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8139140", Offset = "0x8137940", VA = "0x188139140")]
		public RoomieAvatarDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8137330", Offset = "0x8135B30", VA = "0x188137330", Slot = "14")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8137340", Offset = "0x8135B40", VA = "0x188137340", Slot = "15")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Setup([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Tested]
	public class DAIQKIQXZRD : LOCLQRGJUUR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly List<Mesh> FUACSGWJQEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		protected readonly List<IReadOnlyList<byte>> MTCJLHYVJOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		protected readonly List<Matrix4x4> VTHMQMHXELY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly List<bool> DIPJVMYJUPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly List<long> GAANIDGTDXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		protected readonly List<bool> MRYONDGWOLZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		protected readonly List<int> ISHUAKZNQNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected Allocator OXBHRITZOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected MeshMergeModes GJUDEQNRJNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected byte PXGCEHPQBMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected IList<int> GBUILCTSLIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected IList<int> ZOUKBYQUPXR;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8133140", Offset = "0x8131940", VA = "0x188133140", Slot = "4")]
		public void CDOFWOHBHOH(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, YUYCEVTIIQN.SkinCullingMask e = (YUYCEVTIIQN.SkinCullingMask)0L, int f = -1, bool g = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x81334F0", Offset = "0x8131CF0", VA = "0x1881334F0", Slot = "5")]
		public void EKCFVGVZFQT(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8133530", Offset = "0x8131D30", VA = "0x188133530")]
		private static void SNDSERQDPWX(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8133790", Offset = "0x8131F90", VA = "0x188133790")]
		public DAIQKIQXZRD()
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
		[Cpp2IlInjected.Address(RVA = "0x81224E0", Offset = "0x8120CE0", VA = "0x1881224E0", Slot = "4")]
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
		public int KBJOFFEICEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8120340", Offset = "0x811EB40", VA = "0x188120340")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8120320", Offset = "0x811EB20", VA = "0x188120320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int NPCPOCAXUWH
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x811F4B0", Offset = "0x811DCB0", VA = "0x18811F4B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x811E0D0", Offset = "0x811C8D0", VA = "0x18811E0D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int CBQUJCNQNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x811F900", Offset = "0x811E100", VA = "0x18811F900")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x811F910", Offset = "0x811E110", VA = "0x18811F910")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int QGFHLUPTSBY
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x811DBF0", Offset = "0x811C3F0", VA = "0x18811DBF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8120350", Offset = "0x811EB50", VA = "0x188120350")]
		public AvatarCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels, BVBRHCZWKZH systemInfoAccess, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x811DB60", Offset = "0x811C360", VA = "0x18811DB60")]
		public void ANNCDQOFIND(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x811FEF0", Offset = "0x811E6F0", VA = "0x18811FEF0")]
		public void UGMKXZYXKWR(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x811F920", Offset = "0x811E120", VA = "0x18811F920")]
		public Color ODJKBOMVGLY(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x811F4C0", Offset = "0x811DCC0", VA = "0x18811F4C0")]
		public void KWBRTZSCBIG(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x811E0E0", Offset = "0x811C8E0", VA = "0x18811E0E0")]
		public void GSXMHKOUUFI(int a, Vector3 b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x811DF80", Offset = "0x811C780", VA = "0x18811DF80")]
		public void FGQRTPJUXME(int a, half4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x811FC40", Offset = "0x811E440", VA = "0x18811FC40")]
		public void PJZMIIHKKXE(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x811E1D0", Offset = "0x811C9D0", VA = "0x18811E1D0")]
		public void GXHWPWXOCYU(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8120330", Offset = "0x811EB30", VA = "0x188120330")]
		public void WGVBOYTELKX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x811FE90", Offset = "0x811E690", VA = "0x18811FE90")]
		public bool RYUYAWARNXS(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x811DEC0", Offset = "0x811C6C0", VA = "0x18811DEC0")]
		public void EXBNDCPLFDO(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x811DC60", Offset = "0x811C460", VA = "0x18811DC60", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x811E5B0", Offset = "0x811CDB0", VA = "0x18811E5B0")]
		public Mesh HDHCBEKLYYH([Optional] string a)
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
		public int YWNJTKGLJMH
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8121000", Offset = "0x811F800", VA = "0x188121000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int LHCWACYUJBV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8121150", Offset = "0x811F950", VA = "0x188121150")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int AWHUFEWQSTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8121050", Offset = "0x811F850", VA = "0x188121050")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int MQHDOULFQZL
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8121040", Offset = "0x811F840", VA = "0x188121040")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8120FD0", Offset = "0x811F7D0", VA = "0x188120FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int KBJOFFEICEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8121130", Offset = "0x811F930", VA = "0x188121130")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8121120", Offset = "0x811F920", VA = "0x188121120")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int KOAWXHJLUGU
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x8121010", Offset = "0x811F810", VA = "0x188121010")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8121020", Offset = "0x811F820", VA = "0x188121020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MeshMergeModes ZVLUIHLSUAV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8121030", Offset = "0x811F830", VA = "0x188121030")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8121140", Offset = "0x811F940", VA = "0x188121140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public byte WGVQYCQOMZW
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8120FF0", Offset = "0x811F7F0", VA = "0x188120FF0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8120FE0", Offset = "0x811F7E0", VA = "0x188120FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public AvatarCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8122290", Offset = "0x8120A90", VA = "0x188122290")]
			get
			{
				return default(AvatarCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8121160", Offset = "0x811F960", VA = "0x188121160")]
		public AvatarCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8120D80", Offset = "0x811F580", VA = "0x188120D80")]
		public AvatarCullAndCombineMeshJobContainer AFZFBKJJOGX(Allocator a, BVBRHCZWKZH b)
		{
			return default(AvatarCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8120E50", Offset = "0x811F650", VA = "0x188120E50", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Tested]
	public class OZXLWXECVTQ : DAIQKIQXZRD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool WXRWWDSGEFZ;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly ProfilerMarker CVWLESKVPWG;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x8133AE0", Offset = "0x81322E0", VA = "0x188133AE0")]
		public AvatarCullAndCombineMeshJobGroup BNHSNOCMCFL()
		{
			return default(AvatarCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8133D70", Offset = "0x8132570", VA = "0x188133D70")]
		public OZXLWXECVTQ()
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
		protected LODSelection AMRNSSGTVAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		protected int[] INXOMSNUMHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int requestedLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		protected int WJVCRAGPHXP;

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
		protected FPMWPTESEEW NRMYNRPYGRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		protected MZYNOYQSBYJ GPXAZDDDAHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		protected (bool isLodForced, int forcedLOD) RCRSFOJHYHU;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public virtual int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xACB460", Offset = "0xAC9C60", VA = "0x180ACB460", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD71610", Offset = "0xD6FE10", VA = "0x180D71610", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool LTAXYPKZZMM
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8124960", Offset = "0x8123160", VA = "0x188124960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public virtual bool LHORYKMNWBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static bool CMIMUFGQJEV
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8124920", Offset = "0x8123120", VA = "0x188124920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public FPMWPTESEEW JVBRKYHZWEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xAB4120", Offset = "0xAB2920", VA = "0x180AB4120")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x8124A10", Offset = "0x8123210", VA = "0x188124A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected MZYNOYQSBYJ HYISHVZJMVT
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xABA0A0", Offset = "0xAB88A0", VA = "0x180ABA0A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8124350", Offset = "0x8122B50", VA = "0x188124350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int HESHUYROXDL
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x8124D10", Offset = "0x8123510", VA = "0x188124D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AvatarBodyType XAKKLRJYZVV
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x81248D0", Offset = "0x81230D0", VA = "0x1881248D0")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public virtual event Action QTMORNRSFFY
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8124830", Offset = "0x8123030", VA = "0x188124830", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8124970", Offset = "0x8123170", VA = "0x188124970", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x81243E0", Offset = "0x8122BE0", VA = "0x1881243E0", Slot = "8")]
		public virtual (bool, bool, bool) WhichLodsAreResident()
		{
			return default((bool, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "9")]
		public virtual void CheckMeshesAgainstDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8124230", Offset = "0x8122A30", VA = "0x188124230", Slot = "10")]
		public virtual (int, long, int) GetDisplayedLodInfo()
		{
			return default((int, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xDFA700", Offset = "0xDF8F00", VA = "0x180DFA700")]
		protected void UZZINALRBNQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8124340", Offset = "0x8122B40", VA = "0x188124340")]
		protected void TYOYHDMMUFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x133C7E0", Offset = "0x133AFE0", VA = "0x18133C7E0")]
		protected void ZPDSZGEXRFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8124180", Offset = "0x8122980", VA = "0x188124180", Slot = "12")]
		public virtual Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x8124600", Offset = "0x8122E00", VA = "0x188124600")]
		protected void YHKYEIJGLDZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8124670", Offset = "0x8122E70", VA = "0x188124670", Slot = "13")]
		protected virtual void ZLZTLYIYXMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8124290", Offset = "0x8122A90", VA = "0x188124290")]
		public int MeshesAtLODCount(int LOD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8124730", Offset = "0x8122F30", VA = "0x188124730")]
		public AvatarDisplayBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarDisplaySystem : FPMWPTESEEW
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class FRSFBERFBUY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public AvatarDisplaySystem BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public Color NRAXDAECXOV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Color? IGMQMVRTKZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public float? YOECTGVRYHK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public Action<VHXVRFCGREG> HHORJCNVOZT;

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public FRSFBERFBUY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x81438F0", Offset = "0x81420F0", VA = "0x1881438F0")]
			internal void AYJRAVDHJDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x8143A40", Offset = "0x8142240", VA = "0x188143A40")]
			internal void AYOXYBXESOX(VHXVRFCGREG a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class VXXICVGINJJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public bool SCLXGQUVGJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public bool SPFPOZXZPWR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public AvatarDisplaySystem BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public MZYNOYQSBYJ FKBCLDOAIXL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public Action<KeyValuePair<string, XTMHCAFEIFZ<Texture2D>>> NSYCAMNJMMM;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VXXICVGINJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x814E6B0", Offset = "0x814CEB0", VA = "0x18814E6B0")]
			internal bool MEEXCFQRIZJ(VLWQEDFNTAI a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x814E4E0", Offset = "0x814CCE0", VA = "0x18814E4E0")]
			internal bool AMDTKUXYVHX(VLWQEDFNTAI a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x814E4C0", Offset = "0x814CCC0", VA = "0x18814E4C0")]
			internal void MFKMLUGBNPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x814E5D0", Offset = "0x814CDD0", VA = "0x18814E5D0")]
			internal void MCJNAWTPCBG(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x814E4C0", Offset = "0x814CCC0", VA = "0x18814E4C0")]
			internal void ALNYTAQGSZW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x814E5D0", Offset = "0x814CDD0", VA = "0x18814E5D0")]
			internal void AMYUZVZOHBH(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x814E5A0", Offset = "0x814CDA0", VA = "0x18814E5A0")]
			internal void AMTOCPFQXPY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x814E570", Offset = "0x814CD70", VA = "0x18814E570")]
			internal void AMOHFILTOEP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x814E410", Offset = "0x814CC10", VA = "0x18814E410")]
			internal void AKNQGSUTXVD(Dictionary<string, XTMHCAFEIFZ<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x814E5F0", Offset = "0x814CDF0", VA = "0x18814E5F0")]
			internal void HMUYJNGBLAG(KeyValuePair<string, XTMHCAFEIFZ<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210")]
			internal QNKHPYUXYMH AKIJJMAWOJU()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class VXSBFOMLDYA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public int UJBMCDBXUTL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public VXXICVGINJJ GPYHOBUULHO;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VXSBFOMLDYA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x814E3B0", Offset = "0x814CBB0", VA = "0x18814E3B0")]
			internal Layers MCOTYDNMLMP(int a)
			{
				return default(Layers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class VYHVXIUDGGB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public JIREGIBPOUE<Dictionary<string, XTMHCAFEIFZ<Texture2D>>> GMLRFAKAYEU;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public VYHVXIUDGGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			internal JIREGIBPOUE<Dictionary<string, XTMHCAFEIFZ<Texture2D>>> AMJAIBRWETG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class WMEJDNDLRJA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public AvatarDisplaySystem BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public float QFXQJGMXZBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public Color WYXNBYTABQW;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WMEJDNDLRJA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x814EF20", Offset = "0x814D720", VA = "0x18814EF20")]
			internal void ZRYBNJMCWPO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class NAFFDINEDQF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public List<MZYNOYQSBYJ> LLLHCYJLNHB;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public NAFFDINEDQF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8147580", Offset = "0x8145D80", VA = "0x188147580")]
			internal void FVEOIHZAUJB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class WWTUAHJFSSK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public string EYCKJOYUVVR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AvatarBodyPart SFFGIPJYSXI;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public WWTUAHJFSSK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x814EF60", Offset = "0x814D760", VA = "0x18814EF60")]
			internal bool YJDRVEOWNOC(KeyValuePair<string, VLWQEDFNTAI> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class UBPMMUFLHPL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public List<CVLYOHHWPFK> UOUUCQVVXPY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public List<CVLYOHHWPFK> FNCKGHPAMMH;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public UBPMMUFLHPL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x814B410", Offset = "0x8149C10", VA = "0x18814B410")]
			internal QNKHPYUXYMH JDAHUXGSYYW(EORTYFSETCJ a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class UBKFPNLNYEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public SUSCITIHQBY NJBLDIHLHGN;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public UBKFPNLNYEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xBE6C00", Offset = "0xBE5400", VA = "0x180BE6C00")]
			internal void JCPUAJSYGCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xBE6BE0", Offset = "0xBE53E0", VA = "0x180BE6BE0")]
			internal void JCVAXQMVPNN(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class HDMGCUIWECW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public SUSCITIHQBY NJBLDIHLHGN;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public HDMGCUIWECW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xBE6C00", Offset = "0xBE5400", VA = "0x180BE6C00")]
			internal void JCPUAJSYGCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xBE6BE0", Offset = "0xBE53E0", VA = "0x180BE6BE0")]
			internal void JCVAXQMVPNN(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class TYBDTGIDUFV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public long MSWCAQBJNXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public Stopwatch GJNTJFNIDFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public SkinnedMeshRenderer FNDXABDAUTH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public long SZOYUFQIXCF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public string UEIFONQHMIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public long WBEXUTVTKYA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public AvatarDisplaySystem BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public int WKQHCSFLVGW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public List<Material> GASGAGVELES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public List<(int mat, int part)> FLMMQQKJSPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public List<Bounds> MDKBJZHSJFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public int UBHRWZGGGGI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public long HQSANMCZSYW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public long HZENQSAMEHT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public long AYSHDEKDTFT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public Action FIPWSBHZKAJ;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TYBDTGIDUFV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class TXVWVZOGKUM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public bool BNNEUGRSHTY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public JobHandle BBJJUCLZAMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AvatarCullAndCombineMeshJobContainer RZGBPSVCVED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AvatarCullAndCombineMeshJobGroup NNJWAORFMQO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public TYBDTGIDUFV GPYHOBUULHO;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TXVWVZOGKUM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8149AD0", Offset = "0x81482D0", VA = "0x188149AD0")]
			internal void JGZKJFMDANZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x813A4F0", Offset = "0x8138CF0", VA = "0x18813A4F0")]
			internal void JGUDLYSFRCQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class TYLRNTVYNCN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public bool BNNEUGRSHTY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public JobHandle BBJJUCLZAMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public AvatarLegacyCullAndCombineMeshJobContainer YJEFBVLQYEX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public AvatarLegacyCullAndCombineMeshJobGroup HHLGRZXOCIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public TYBDTGIDUFV GQOCFWCMNPP;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TYLRNTVYNCN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x814A090", Offset = "0x8148890", VA = "0x18814A090")]
			internal void JHJYDSZXTKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x813A7A0", Offset = "0x8138FA0", VA = "0x18813A7A0")]
			internal void JHERGMGAJZI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class CXDWSMTNWPT : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public bool BVJBJATCWMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public AvatarDisplaySystem BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public List<EORTYFSETCJ> FENSRMQYHBZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public List<MZYNOYQSBYJ> LLLHCYJLNHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int[] GBYTWKBYXDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public bool YPLQUKGMFZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public Func<int, Layers> YUEXVJJCMYW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public VHXVRFCGREG DZOKQBZROQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public Material JSLIMGDPDAZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private int OEASEWDYHGP;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public CXDWSMTNWPT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8143000", Offset = "0x8141800", VA = "0x188143000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x8142FC0", Offset = "0x81417C0", VA = "0x188142FC0", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly Log QPPIFXWTGPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly XOOCNKBZGKP ZHZYEQETQOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly XOOCNKBZGKP MASLNMKVTIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Dictionary<BodyProperty, float> ZMCQTXBGATZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Dictionary<FaceProperty, float> OMFXPJCDZFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<NoseProperty, float> HDPVYZMNBOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IReadOnlyDictionary<string, BoneLocalInfo> SGJNNTYNEQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private Dictionary<string, BoneLocalInfo> TPMWWBWEGIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Dictionary<string, BoneLocalInfo> AOKHEJRWGQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Dictionary<string, BoneLocalInfo> XOAWVQRHBZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private AvatarBuildType YBRQTKTFYUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private AvatarBuildType IHPSANAIABS;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static float PSMFJFFCIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private AvatarConfiguration JGRUYKHFIDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private Transform TQHIPAKJPYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private AvatarSkinAssetItem UFHIQKCKXPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private AssetReference FKSIRRNJSFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private AssetReference VIAECVTFVUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private AssetReference ZSDJDCVXQTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private AssetReference ZGYJFLVAKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private GameObject CNHZIXPAUDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private GameObject WPBNFQOCKVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private GameObject ALMMSUJSUXK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private SkinnedMeshRenderer MZRCZOETSDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private AvatarSkinnedMeshBoneOrderRemapsData YEMVCEOKJRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private Transform[] OUYSWAKBDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Matrix4x4[] HAXLLWFUUEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private Material GFPJCEGKUXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Material TDQUZHBIDSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Texture2D DFYUDHHHGLY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Material UCLLVRNTAZE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Material TFRUCOSBLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Material VDAENSSYHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Shader GQLOEJQXWHR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Shader JEWHIITEGRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Animator VNNLFGUPAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Renderer[] DDKEHNDUIFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private YUYCEVTIIQN.SkinCullingMask MTHJEBAFYOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private AvatarBodyPartShapesManager WMMZSQQMWVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private IReadOnlyDictionary<string, Transform> XWTNFZQMEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private bool GPXGBFJSDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private bool ZFQQBKBTUSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Color XAMSBFHPNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Color? NOIVIKYOLRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Texture2D RTUJTMTGOAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float? YJNYGVRIGQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private Color RHMWMAESQND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Color ZHRLIDYKISN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Color? GSPSCQAANGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Color? HIMZQCGULXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Color? SLTRQNQILDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Color? KAFBMRXBRXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Texture2D FKMVXOWCSPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Texture2D OZAVVATWCVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[CanBeNull]
		private VLWQEDFNTAI ITJPQRCKUOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Texture NWKZIBSYPJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Color CAMWJULWOAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Dictionary<Renderer, VHXVRFCGREG> CAVWZCTYPFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Dictionary<Renderer, VHXVRFCGREG> QQTKFVXMWDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Dictionary<string, List<AvatarMaterialKey>> KYLOWBDVEQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private Dictionary<string, List<AvatarMaterialKey>> ZSACYYICMBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly List<CVLYOHHWPFK> UOUUCQVVXPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly List<CVLYOHHWPFK> FLVUNSUQYTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly List<CVLYOHHWPFK> FNCKGHPAMMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly List<CVLYOHHWPFK> BDABEXECKGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Dictionary<AvatarMaterialKey, Material> OHBZKQJOVEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Dictionary<AvatarMaterialKey, Material> GARYXCWRCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private SkinnedMeshRenderer[] QRJGOKSSNTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private SkinnedMeshRenderer[] HZRVYHZJADS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private SkinnedMeshRenderer[] TSTOBGIPJYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private SkinnedMeshRenderer[] NUSPZKBSXQG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly Dictionary<string, XTMHCAFEIFZ<Texture2D>> JWUONGWSKFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly Dictionary<string, XTMHCAFEIFZ<Texture2D>> OOWLLUOQIUI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private AdditionalHatData HIDHQBXZPLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private AdditionalHatData RKHGOMRNEHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private RecRoom.Avatars.Data.Shared.HairData HGNWEOYDSGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private RecRoom.Avatars.Data.Shared.HairData FQJRRUDITSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private SDZUMEDZFPG OYMAOAKNZZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private bool? JTSDUPOLCAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private PositionAndRotation GQDPTOSPDPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Transform TOZFGYCMQCC;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Material MZKUOUOVNCB;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Material LDKCSOFXDAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private Dictionary<string, VLWQEDFNTAI> APSKVTGSEAY;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly int TPQRLXNBHWD;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly int UJWVDNCHVKJ;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly int KWORGRMYSIN;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly int JUYWFQRJDMW;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly int JGTODURRHWS;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly int BYVFOGDDDYN;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly int DJLWKDNVTHW;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int GBFLXZQUQUW;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int ZOVLEWRDCAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private bool XMRRCENGSCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F9")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private bool GDHTZHIBBNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private List<Action> BIRLAOWYHRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private PCLHBEYKOMB ZIIHIOUXMQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private SkinnedMeshRenderer[] UWCEDKBTTVE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int VHBTWACQVND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool PCFYSJZIJXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int WJVCRAGPHXP;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public XOOCNKBZGKP DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public XOOCNKBZGKP DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xAB3270", Offset = "0xAB1A70", VA = "0x180AB3270", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool FGEWCALONMW
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x812DDE0", Offset = "0x812C5E0", VA = "0x18812DDE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x812E820", Offset = "0x812D020", VA = "0x18812E820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private Material SJOGVZICHUN
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8131A60", Offset = "0x8130260", VA = "0x188131A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private Material ZSRNFONXLNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x81323C0", Offset = "0x8130BC0", VA = "0x1881323C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool XPZYBNPQPRN
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8132FB0", Offset = "0x81317B0", VA = "0x188132FB0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(AvatarBodyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8133130", Offset = "0x8131930", VA = "0x188133130")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xCE65F0", Offset = "0xCE4DF0", VA = "0x180CE65F0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2255BA0", Offset = "0x22543A0", VA = "0x182255BA0", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xCE6590", Offset = "0xCE4D90", VA = "0x180CE6590", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8132FC0", Offset = "0x81317C0", VA = "0x188132FC0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public YUYCEVTIIQN.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xC47000", Offset = "0xC45800", VA = "0x180C47000", Slot = "22")]
			get
			{
				return default(YUYCEVTIIQN.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int SEACMEZSMMY
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8129D30", Offset = "0x8128530", VA = "0x188129D30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x812AD30", Offset = "0x8129530", VA = "0x18812AD30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool FHDMPBHJNFS
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8126D50", Offset = "0x8125550", VA = "0x188126D50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private static bool SSQYDHAGOFU
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x8125E80", Offset = "0x8124680", VA = "0x188125E80", Slot = "17")]
		public MZYNOYQSBYJ BuildPotatoAvatar(ZVZUWTELACM avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x8125E50", Offset = "0x8124650", VA = "0x188125E50", Slot = "16")]
		public MZYNOYQSBYJ BuildAvatarMeshes(ZVZUWTELACM avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, VLWQEDFNTAI>, (MZYNOYQSBYJ, JIREGIBPOUE<Dictionary<string, XTMHCAFEIFZ<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x812B760", Offset = "0x8129F60", VA = "0x18812B760")]
		public MZYNOYQSBYJ NJXVPWEQPEI(ZVZUWTELACM a, bool b, int[] c, bool d, AvatarBuildType e, [Optional] Func<Dictionary<string, VLWQEDFNTAI>, (MZYNOYQSBYJ, JIREGIBPOUE<Dictionary<string, XTMHCAFEIFZ<Texture2D>>>)> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x812B0E0", Offset = "0x81298E0", VA = "0x18812B0E0")]
		public static void NBGWWAXIJPL(Log a, string b, AssetReference c, AssetReference[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8131E80", Offset = "0x8130680", VA = "0x188131E80")]
		private bool XZWASOALDAJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8127550", Offset = "0x8125D50", VA = "0x188127550")]
		private MZYNOYQSBYJ ECPDKPWPNSV(bool a, List<EORTYFSETCJ> b, int[] c, Func<int, Layers> d, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x8131CF0", Offset = "0x81304F0", VA = "0x188131CF0")]
		[IteratorStateMachine(typeof(CXDWSMTNWPT))]
		private IEnumerator<ZCECIALXIMT> XTJIIQDZTTX(bool a, List<EORTYFSETCJ> b, int[] c, Func<int, Layers> d, VHXVRFCGREG e, Material f, List<MZYNOYQSBYJ> g, bool h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x81255D0", Offset = "0x8123DD0", VA = "0x1881255D0")]
		public static void BKTCKJHQXNW(List<EORTYFSETCJ> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x81267B0", Offset = "0x8124FB0", VA = "0x1881267B0")]
		public static MZYNOYQSBYJ CRNSKKLKVMO(List<EORTYFSETCJ> a, List<CVLYOHHWPFK> b, List<CVLYOHHWPFK> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x8126590", Offset = "0x8124D90", VA = "0x188126590")]
		public MZYNOYQSBYJ CRNSKKLKVMO(List<EORTYFSETCJ> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x8127D90", Offset = "0x8126590", VA = "0x188127D90")]
		private BFFPISQCYKM ESYMONDUPPX(List<EORTYFSETCJ> a, int b, bool c, Layers d, bool e, VHXVRFCGREG f, Material g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x812F320", Offset = "0x812DB20", VA = "0x18812F320", Slot = "27")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x812F850", Offset = "0x812E050", VA = "0x18812F850", Slot = "29")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x812F9E0", Offset = "0x812E1E0", VA = "0x18812F9E0", Slot = "30")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x8124F10", Offset = "0x8123710", VA = "0x188124F10", Slot = "28")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x8124F70", Offset = "0x8123770", VA = "0x188124F70", Slot = "31")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8125030", Offset = "0x8123830", VA = "0x188125030", Slot = "32")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x812E290", Offset = "0x812CA90", VA = "0x18812E290")]
		private void OFPMSWNUKCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x8126A40", Offset = "0x8125240", VA = "0x188126A40")]
		private void CRWOVETREZN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8126B10", Offset = "0x8125310", VA = "0x188126B10")]
		private void DFXRORFDCBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8130A20", Offset = "0x812F220", VA = "0x188130A20", Slot = "34")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x8131980", Offset = "0x8130180", VA = "0x188131980", Slot = "41")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x812F840", Offset = "0x812E040", VA = "0x18812F840", Slot = "33")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x81291C0", Offset = "0x81279C0", VA = "0x1881291C0")]
		private void GAIDRPNMDIW(SkinnedMeshRenderer a, int b, Mesh c, List<Material> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x8130270", Offset = "0x812EA70", VA = "0x188130270")]
		public static Material UABZVTDGZUP(Dictionary<AvatarMaterialKey, Material> a, Material b, UpdatableColorType c, UpdatableTextureType d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8127AB0", Offset = "0x81262B0", VA = "0x188127AB0")]
		public static UpdatableColorType EJCFKSFQNQA(EORTYFSETCJ a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x812EBE0", Offset = "0x812D3E0", VA = "0x18812EBE0")]
		private void QOZJIMAZCTH(int a, Material b, EORTYFSETCJ c, [Out] Texture2D d, [Out] Vector4 e, [Out] Texture2D f, [Out] Texture2D g, [Out] Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x812E310", Offset = "0x812CB10", VA = "0x18812E310")]
		private void OOAWTBCFDJT(int a, Material b, EORTYFSETCJ c, [Out] Color d, [Out] Color e, [Out] Color f, [Out] Color g, [Out] Color h, [Out] Color i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x812FE20", Offset = "0x812E620", VA = "0x18812FE20")]
		private bool TRPJPYOWPGK(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8124D30", Offset = "0x8123530", VA = "0x188124D30")]
		private static Material ALDVSOIWIHO(int a, PCECJQABPHH b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x8127470", Offset = "0x8125C70", VA = "0x188127470")]
		public static UpdatableTextureType ECLCHVXTOOE(EORTYFSETCJ a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8131F50", Offset = "0x8130750", VA = "0x188131F50")]
		private static void YATJPWXUXFJ(Dictionary<string, List<AvatarMaterialKey>> a, EORTYFSETCJ b, Material c, UpdatableColorType d, UpdatableTextureType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x812AEB0", Offset = "0x81296B0", VA = "0x18812AEB0")]
		public static SkinnedMeshRenderer MESNKWPAGCV(Transform a, Transform b, SkinnedMeshRenderer[] c, int d, Layers e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x81326D0", Offset = "0x8130ED0", VA = "0x1881326D0")]
		public AvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x812A200", Offset = "0x8128A00", VA = "0x18812A200")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x8128FF0", Offset = "0x81277F0", VA = "0x188128FF0")]
		public void ILPRDDMFTSU([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x812AD30", Offset = "0x8129530", VA = "0x18812AD30", Slot = "6")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x812FBD0", Offset = "0x812E3D0", VA = "0x18812FBD0", Slot = "12")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0")]
		public static bool LJBWCBKYQOH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x8125090", Offset = "0x8123890", VA = "0x188125090", Slot = "13")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x812F410", Offset = "0x812DC10", VA = "0x18812F410", Slot = "10")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x812FAD0", Offset = "0x812E2D0", VA = "0x18812FAD0", Slot = "11")]
		public void SetSkinColors(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x8127390", Offset = "0x8125B90", VA = "0x188127390")]
		private void DXCXHOGLEBV(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x812FDB0", Offset = "0x812E5B0", VA = "0x18812FDB0", Slot = "7")]
		public void SetUgcItemVisualOverrides(VLWQEDFNTAI overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x812E820", Offset = "0x812D020", VA = "0x18812E820", Slot = "8")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x2255BC0", Offset = "0x22543C0", VA = "0x182255BC0", Slot = "9")]
		public void SetUgcTextureParameters(PCLHBEYKOMB parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8130080", Offset = "0x812E880", VA = "0x188130080", Slot = "18")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8124FD0", Offset = "0x81237D0", VA = "0x188124FD0", Slot = "35")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x812F940", Offset = "0x812E140", VA = "0x18812F940", Slot = "36")]
		public void SetHatAnchorParams(SDZUMEDZFPG anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x8130B60", Offset = "0x812F360", VA = "0x188130B60", Slot = "37")]
		public void UpdateHatPivot([Optional] SDZUMEDZFPG anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x812F1C0", Offset = "0x812D9C0", VA = "0x18812F1C0")]
		private bool RKEOLRXNALP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x812F300", Offset = "0x812DB00", VA = "0x18812F300", Slot = "23")]
		public bool SetBaseSkinCullingMask(YUYCEVTIIQN.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8130910", Offset = "0x812F110", VA = "0x188130910", Slot = "39")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x81299B0", Offset = "0x81281B0", VA = "0x1881299B0")]
		public void HNHTWCEBYOR(float a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x812ADD0", Offset = "0x81295D0", VA = "0x18812ADD0")]
		private static bool LVEYPWQYOAO(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x81319D0", Offset = "0x81301D0", VA = "0x1881319D0", Slot = "40")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties materialProperties, TextureEffectMaterialTextures materialTextures)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x812E800", Offset = "0x812D000", VA = "0x18812E800")]
		private static bool OPKKSWTGGSO(AvatarMaterialKey a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x8129FE0", Offset = "0x81287E0", VA = "0x188129FE0")]
		public void IAROYPZQUWZ(TextureEffectMaterialProperties a, TextureEffectMaterialTextures b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x8129EB0", Offset = "0x81286B0", VA = "0x188129EB0", Slot = "38")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x8126B90", Offset = "0x8125390", VA = "0x188126B90")]
		private void DJSOIKSTNBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x8126AC0", Offset = "0x81252C0", VA = "0x188126AC0")]
		private void DEKIOKHYIWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x33D6EF0", Offset = "0x33D56F0", VA = "0x1833D6EF0")]
		public static void KCCMEHOQGLP<a>(Dictionary<a, Material> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8125F50", Offset = "0x8124750", VA = "0x188125F50")]
		private static void CLOOXFPFSCT(Dictionary<Renderer, VHXVRFCGREG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x812F020", Offset = "0x812D820", VA = "0x18812F020")]
		public static void QXPWKIHMIRG(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8125EB0", Offset = "0x81246B0", VA = "0x188125EB0")]
		public static void CGVFOXLPATN(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8127BB0", Offset = "0x81263B0", VA = "0x188127BB0")]
		public static void EJCHNGDHWBH(List<CVLYOHHWPFK> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x812E110", Offset = "0x812C910", VA = "0x18812E110")]
		private void OCNQYDOGRSO(Dictionary<string, XTMHCAFEIFZ<Texture2D>> a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x812F170", Offset = "0x812D970", VA = "0x18812F170")]
		private void QZNQKBWTWPF(Dictionary<string, List<AvatarMaterialKey>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x812B600", Offset = "0x8129E00", VA = "0x18812B600")]
		private void NFONVVOEWGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8132230", Offset = "0x8130A30", VA = "0x188132230")]
		private void ZLZTLYIYXMX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x812A770", Offset = "0x8128F70", VA = "0x18812A770")]
		private void JHWPUICEFBR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8124E50", Offset = "0x8123650", VA = "0x188124E50")]
		private void AZTPXHGPEHW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8124DC0", Offset = "0x81235C0", VA = "0x188124DC0")]
		private void ARPGDELQKLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x812A620", Offset = "0x8128E20", VA = "0x18812A620")]
		private void JGPDHIMNRTQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x8131E00", Offset = "0x8130600", VA = "0x188131E00")]
		private void XXNITZZDBLZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x81290F0", Offset = "0x81278F0", VA = "0x1881290F0")]
		private void FXGTUPNMFYZ(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8129070", Offset = "0x8127870", VA = "0x188129070")]
		private void FCHRRISGCLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8129470", Offset = "0x8127C70", VA = "0x188129470")]
		private void GPFYTNBRTGR(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x812DDF0", Offset = "0x812C5F0", VA = "0x18812DDF0")]
		private void OBCCLLOOGEA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8130430", Offset = "0x812EC30", VA = "0x188130430")]
		private void UOZEIVAGFFY(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8129D40", Offset = "0x8128540", VA = "0x188129D40")]
		private void HVHAOWJVFHI(Material a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x81260A0", Offset = "0x81248A0", VA = "0x1881260A0")]
		private void COFEGFIUWMS(Material a, Color b, Texture2D c, Color? d, float? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8125C10", Offset = "0x8124410", VA = "0x188125C10")]
		private void BYZAYWFABCH(Material a, Color b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x812E830", Offset = "0x812D030", VA = "0x18812E830")]
		private void PFJIXTKLVOO(Material a, Texture2D b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x812EA40", Offset = "0x812D240", VA = "0x18812EA40")]
		private void PWYXMZCOAAI(Material a, Texture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8129310", Offset = "0x8127B10", VA = "0x188129310")]
		private void GDXZEGTREPI(Action<VHXVRFCGREG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8126DF0", Offset = "0x81255F0", VA = "0x188126DF0")]
		private void DMXUERLFJRW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8126F70", Offset = "0x8125770", VA = "0x188126F70")]
		private void DVHIJUQNITE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x8125200", Offset = "0x8123A00", VA = "0x188125200")]
		private void BEAJCOCOMZQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8129540", Offset = "0x8127D40", VA = "0x188129540")]
		public void GZVQKQZJPWG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x812EA30", Offset = "0x812D230", VA = "0x18812EA30", Slot = "4")]
		private void PLSPEMMNLIB([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x8128FF0", Offset = "0x81277F0", VA = "0x188128FF0", Slot = "5")]
		private void FAESYTRGERG([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x812EBA0", Offset = "0x812D3A0", VA = "0x18812EBA0")]
		[CompilerGenerated]
		private QNKHPYUXYMH QDMNFQZPXPQ(EORTYFSETCJ a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x812DC00", Offset = "0x812C400", VA = "0x18812DC00")]
		[CompilerGenerated]
		private void NMOCCPHOVMT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x812DB60", Offset = "0x812C360", VA = "0x18812DB60")]
		[CompilerGenerated]
		private void NMDOIBTUCQB(VHXVRFCGREG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x812DB80", Offset = "0x812C380", VA = "0x18812DB80")]
		[CompilerGenerated]
		private void NMIVFINRMBK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x812DB40", Offset = "0x812C340", VA = "0x18812DB40")]
		[CompilerGenerated]
		private void NLYHKUZWTES(VHXVRFCGREG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x812DD00", Offset = "0x812C500", VA = "0x18812DD00")]
		[CompilerGenerated]
		private void NMYPXCVJOJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x812DDB0", Offset = "0x812C5B0", VA = "0x18812DDB0")]
		[CompilerGenerated]
		private void NOEFGRKTSZN(VHXVRFCGREG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x812DC80", Offset = "0x812C480", VA = "0x18812DC80")]
		[CompilerGenerated]
		private void NMTIZWBMEYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x812DD80", Offset = "0x812C580", VA = "0x18812DD80")]
		[CompilerGenerated]
		private void NNYYJKQWJOE(VHXVRFCGREG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x812DAC0", Offset = "0x812C2C0", VA = "0x18812DAC0")]
		[CompilerGenerated]
		private void NLTANOFZJTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x81303D0", Offset = "0x812EBD0", VA = "0x1881303D0")]
		[CompilerGenerated]
		private void UBLLGOBTMEU(VHXVRFCGREG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x812DA40", Offset = "0x812C240", VA = "0x18812DA40")]
		[CompilerGenerated]
		private void NLNTQHMCAIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8130400", Offset = "0x812EC00", VA = "0x188130400")]
		[CompilerGenerated]
		private void UBQSDUVQVQD(VHXVRFCGREG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x812AD50", Offset = "0x8129550", VA = "0x18812AD50")]
		[CompilerGenerated]
		private void JRFJLYFYXZH(KeyValuePair<string, XTMHCAFEIFZ<Texture2D>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x81298F0", Offset = "0x81280F0", VA = "0x1881298F0")]
		[CompilerGenerated]
		private void HAXBAEKNWLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8132200", Offset = "0x8130A00", VA = "0x188132200")]
		[CompilerGenerated]
		private void ZFOPIYCLJQC(VHXVRFCGREG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x8131C30", Offset = "0x8130430", VA = "0x188131C30")]
		[CompilerGenerated]
		private void XPLZPPVQNST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x8131C00", Offset = "0x8130400", VA = "0x188131C00")]
		[CompilerGenerated]
		private void XJREBSMEUVL(VHXVRFCGREG a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, LWBLBDRCTOW
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
		private Vector3? MUUQCOUMYIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool KBPUMSSHHKV;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x813AA50", Offset = "0x8139250", VA = "0x18813AA50", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x813B070", Offset = "0x8139870", VA = "0x18813B070", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB41140", Offset = "0xB3F940", VA = "0x180B41140", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x813AB30", Offset = "0x8139330", VA = "0x18813AB30")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x813B490", Offset = "0x8139C90", VA = "0x18813B490")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, LWBLBDRCTOW
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private const float WLBEAGWUGFT = 45f;

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
		private Vector3 XQLUWHTZNWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private Vector3 KMWDGRAFKJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool KBPUMSSHHKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private float YZJAWBFULXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private float BOARKFUQIPY;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x813B810", Offset = "0x813A010", VA = "0x18813B810", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xD25260", Offset = "0xD23A60", VA = "0x180D25260", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x813B530", Offset = "0x8139D30", VA = "0x18813B530")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x813C2D0", Offset = "0x813AAD0", VA = "0x18813C2D0")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class KEJUSOGABHI : JXZAHTZEYVD, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private static readonly int CTXPTLYQIDY;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private static readonly int INCXUBINZCP;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly int UNTLZEIJRFG;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly int IUGFCMQUDCI;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private static readonly int TPHXAHHQDWI;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly int ZPGYGCBOUDU;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private static readonly int DOLXBWWVMEU;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private static readonly int XDIDXJGXAKK;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private static readonly int XWRJTINOGPK;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly int DLDTQMHMEED;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly int RZQZRGQFGTT;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static readonly int TBDLGWHFNFP;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static readonly int CQGDBJGFQZF;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static readonly int JGFUKQFDFRV;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static readonly int NVJWOPTEVYX;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static readonly int GUOYIFWCOPX;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private static readonly int ZKASPUAQFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private Transform MVAJRAOSMJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private Transform DQDXBAICGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private Transform IJYFDHKIVKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private Transform XPYYJQPAJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Transform KEGVBZMOZXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private Transform IALWHWAZZWF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private AvatarFaceDisplayInitState LQHMCIBTOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private Material TJUPYYICWMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private SkinnedMeshRenderer[] LIVZHLZLVXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private readonly List<Material> FFVPKNQZUKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private ILZBYYPGIGD XYQYKLHHHXC;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public XOOCNKBZGKP DWVCPKOJCGV
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private ILZBYYPGIGD XPQBQXNQZFP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x81458D0", Offset = "0x81440D0", VA = "0x1881458D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x8144300", Offset = "0x8142B00", VA = "0x188144300", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x81459A0", Offset = "0x81441A0", VA = "0x1881459A0")]
		public void Initialize([In] AvatarFaceDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8145D60", Offset = "0x8144560", VA = "0x188145D60")]
		public void KRXDQXWYNSV([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8145E00", Offset = "0x8144600", VA = "0x188145E00", Slot = "6")]
		public void PXSKZTBKHYW(AvatarFaceDisplayUpdateFeatureSelectionState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8145870", Offset = "0x8144070", VA = "0x188145870")]
		private Vector2 ERZOAITSIZM(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x8144460", Offset = "0x8142C60", VA = "0x188144460")]
		public void BLFFZYUMAUM([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x8145440", Offset = "0x8143C40", VA = "0x188145440")]
		private void CJTUNBDOJQL(FaceFeaturesInUVSpace a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x8145A50", Offset = "0x8144250", VA = "0x188145A50")]
		private void KFYHXBZMKSJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x8145800", Offset = "0x8144000", VA = "0x188145800")]
		private void WCJJWBXDNUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x8145800", Offset = "0x8144000", VA = "0x188145800", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x81465E0", Offset = "0x8144DE0", VA = "0x1881465E0")]
		public KEJUSOGABHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8145D60", Offset = "0x8144560", VA = "0x188145D60", Slot = "5")]
		private void OSMRVTICQVQ([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x8144450", Offset = "0x8142C50", VA = "0x188144450", Slot = "7")]
		private void AYTLFMTSDAF([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x8145990", Offset = "0x8144190", VA = "0x188145990")]
		[CompilerGenerated]
		internal static float INKKBCSDDGE(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8145350", Offset = "0x8143B50", VA = "0x188145350")]
		[CompilerGenerated]
		internal static void BZUSLFDCUEZ(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x8145950", Offset = "0x8144150", VA = "0x188145950")]
		[CompilerGenerated]
		internal static Vector4 GIRMQNVJMUG(Vector2 a, Vector2 b)
		{
			return default(Vector4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class AvatarForearmRollController : MonoBehaviour, LWBLBDRCTOW
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
		private float YZJAWBFULXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private bool KBPUMSSHHKV;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x813C300", Offset = "0x813AB00", VA = "0x18813C300", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xAB4140", Offset = "0xAB2940", VA = "0x180AB4140", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x813CB60", Offset = "0x813B360", VA = "0x18813CB60")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
		private Dictionary<int, int> NLCHXDTJXIP;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x813CB90", Offset = "0x813B390", VA = "0x18813CB90")]
		public void RUCBQSMBUXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x813CCA0", Offset = "0x813B4A0", VA = "0x18813CCA0")]
		public int WHRCPWXYJSD(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public AvatarHandDisplaySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class QJNMADAOQZE : MAPEVKDZUCV
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8148B50", Offset = "0x8147350", VA = "0x188148B50", Slot = "24")]
		public override float RCISSJQOCVW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8148BA0", Offset = "0x81473A0", VA = "0x188148BA0")]
		public QJNMADAOQZE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class MAPEVKDZUCV : KBLIJBEPRHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static int LRTXJEYIVTW;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static int CVUVTDYBHTA;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static int DSLOWRNSYDG;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static int MAVKMLKELUH;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static int FZRNHPVAMIR;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static int CGPVYOWRDGA;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static int ISKCAWMCZHQ;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static int[] YCNDTMZXMRW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private AvatarHandDisplayInitState LQHMCIBTOID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private AvatarHandDisplaySetupState PAMNWMOGCAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private int AKIHEPIHNHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private float XHNFQWSGAYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		protected Animator VNNLFGUPAON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		protected AvatarConfiguration PLCGJPDOZKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		protected int SBVVAPMJAIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private int ARKPDFHDQFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private int TTQAADRVTCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private bool MQRXPFLPEVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private HandAnimationOverrideState ALNCEZIJWQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private int FGUNFBXQOFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private float GGDDEPHLHJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private AvatarHandDisplaySettings MPAZBXVOLXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private AvatarBodyType PCQEYLDYATS;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Transform AUTLLSAQIWA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xAACAF0", Offset = "0xAAB2F0", VA = "0x180AACAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector3 JQQLBLIYOAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x1726160", Offset = "0x1724960", VA = "0x181726160")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x17262C0", Offset = "0x1724AC0", VA = "0x1817262C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Quaternion TRBDSDPDJAP
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xBF78B0", Offset = "0xBF60B0", VA = "0x180BF78B0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xBF7730", Offset = "0xBF5F30", VA = "0x180BF7730")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool ZYAIBQRIPTZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x81467E0", Offset = "0x8144FE0", VA = "0x1881467E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x8146A20", Offset = "0x8145220", VA = "0x188146A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool GKPIKLTQATI
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xABECE0", Offset = "0xABD4E0", VA = "0x180ABECE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 BGZIJHPMPNF
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1240640", Offset = "0x123EE40", VA = "0x181240640", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x123D3A0", Offset = "0x123BBA0", VA = "0x18123D3A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Quaternion GFCAGBSGMAC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x102F110", Offset = "0x102D910", VA = "0x18102F110", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x81467D0", Offset = "0x8144FD0", VA = "0x1881467D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HandVisualState WXIRHYRBUHA
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xE40BA0", Offset = "0xE3F3A0", VA = "0x180E40BA0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xE40800", Offset = "0xE3F000", VA = "0x180E40800", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public HandVisualState NSTVFTJRMJD
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x1041450", Offset = "0x103FC50", VA = "0x181041450", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1ECFD40", Offset = "0x1ECE540", VA = "0x181ECFD40", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float KCCMNDXHGXL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x12DAF80", Offset = "0x12D9780", VA = "0x1812DAF80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xE3E950", Offset = "0xE3D150", VA = "0x180E3E950", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool RCYEFWMKGZL
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x22928F0", Offset = "0x22910F0", VA = "0x1822928F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2292940", Offset = "0x2291140", VA = "0x182292940", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool LZQTPWYYXOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x8146D20", Offset = "0x8145520", VA = "0x188146D20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool GNREBXHDAYS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x8146C60", Offset = "0x8145460", VA = "0x188146C60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool NVCMKPXEPET
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x8146C70", Offset = "0x8145470", VA = "0x188146C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool FUUZECULNWX
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x8146C10", Offset = "0x8145410", VA = "0x188146C10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x8146A50", Offset = "0x8145250", VA = "0x188146A50", Slot = "23")]
		public void Initialize(AvatarHandDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x81469D0", Offset = "0x81451D0", VA = "0x1881469D0")]
		public void EOWLHRJTNDK(AvatarHandDisplaySetupState a, AvatarHandDisplaySettings b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x8146C90", Offset = "0x8145490", VA = "0x188146C90", Slot = "14")]
		public void QNBYSMBAJHD(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8146EB0", Offset = "0x81456B0", VA = "0x188146EB0", Slot = "13")]
		public void UUDRAROMQPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x12DAF80", Offset = "0x12D9780", VA = "0x1812DAF80", Slot = "24")]
		public virtual float RCISSJQOCVW()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x8146D30", Offset = "0x8145530", VA = "0x188146D30")]
		private int TFJSQRDOFMB(HandVisualState a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x8146810", Offset = "0x8145010", VA = "0x188146810")]
		private void DWACHTZVRCB(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x8146BF0", Offset = "0x81453F0", VA = "0x188146BF0", Slot = "15")]
		public bool JIWGUVAHXDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8146C80", Offset = "0x8145480", VA = "0x188146C80", Slot = "16")]
		public bool OUQOPLKCXXR()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x8147270", Offset = "0x8145A70", VA = "0x188147270")]
		private HandVisualState VGQJGGCUSNQ()
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1581920", Offset = "0x1580120", VA = "0x181581920", Slot = "17")]
		public void TDODCSGHWAA(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8146C20", Offset = "0x8145420", VA = "0x188146C20", Slot = "12")]
		public void LNDGBELTEUZ(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x81467B0", Offset = "0x8144FB0", VA = "0x1881467B0", Slot = "10")]
		public void ALHFMENEGPB(HandAnimationOverrideState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x81472C0", Offset = "0x8145AC0", VA = "0x1881472C0", Slot = "11")]
		public void VQWROXMTDZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8147220", Offset = "0x8145A20", VA = "0x188147220", Slot = "18")]
		public void UWTFQXOHTPX(Transform a, Vector3 b, Quaternion c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8147560", Offset = "0x8145D60", VA = "0x188147560")]
		public MAPEVKDZUCV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class PCECJQABPHH : EORTYFSETCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class SJZNEKOBZSY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public PCECJQABPHH BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public List<CVLYOHHWPFK> MNCLEOXNHZC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public List<CVLYOHHWPFK> EPRHYQHNCMV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public XTMHCAFEIFZ<Material[]> CKIYDGUNBFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public XTMHCAFEIFZ<LoadedAvatarItemPrefabHolder> XHWAOMMCVOD;

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public SJZNEKOBZSY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x8148D40", Offset = "0x8147540", VA = "0x188148D40")]
			internal QNKHPYUXYMH VHHTWLBJPDS(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public VLWQEDFNTAI VLWQEDFNTAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public LoadedAvatarItemPrefabHolder KKTKXLOVVPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private XTMHCAFEIFZ<LoadedAvatarItemPrefabHolder> DZVNZXKXUFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private XTMHCAFEIFZ<Material[]> CKIYDGUNBFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Material[] EJYAGFVEDMA;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool DLEHWRUFMTS
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xADAAF0", Offset = "0xAD92F0", VA = "0x180ADAAF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xADAB00", Offset = "0xAD9300", VA = "0x180ADAB00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public YUYCEVTIIQN.SkinCullingMask GROHGDCRGVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xAB39E0", Offset = "0xAB21E0", VA = "0x180AB39E0")]
			[CompilerGenerated]
			get
			{
				return default(YUYCEVTIIQN.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xD40E30", Offset = "0xD3F630", VA = "0x180D40E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8148AE0", Offset = "0x81472E0", VA = "0x188148AE0")]
		public PCECJQABPHH(ItemDefinitionBodyPart a, VLWQEDFNTAI b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x81476B0", Offset = "0x8145EB0", VA = "0x1881476B0", Slot = "6")]
		public override QNKHPYUXYMH EKMATMXWRCR(List<CVLYOHHWPFK> a, List<CVLYOHHWPFK> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8147D70", Offset = "0x8146570", VA = "0x188147D70")]
		public QNKHPYUXYMH NWMHWHTZUPC(List<CVLYOHHWPFK> a, List<CVLYOHHWPFK> b, XTMHCAFEIFZ<Material[]> c, [Optional] XTMHCAFEIFZ<LoadedAvatarItemPrefabHolder> d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8148620", Offset = "0x8146E20", VA = "0x188148620")]
		public (XTMHCAFEIFZ<Material[]>, XTMHCAFEIFZ<LoadedAvatarItemPrefabHolder>) ZSUBJISEMFK(List<CVLYOHHWPFK> a, List<CVLYOHHWPFK> b)
		{
			return default((XTMHCAFEIFZ<Material[]>, XTMHCAFEIFZ<LoadedAvatarItemPrefabHolder>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x81483D0", Offset = "0x8146BD0", VA = "0x1881483D0", Slot = "7")]
		public override MPRYZNKLXLP TTCAFKXMOXC(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x8147B50", Offset = "0x8146350", VA = "0x188147B50")]
		public MPRYZNKLXLP FFXNAZIVUFF(GameObject a, uint b, bool c, bool d, AvatarSkinnedMeshBoneOrderRemapsData e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8148070", Offset = "0x8146870", VA = "0x188148070")]
		public static bool OOJEOCAWEXU(Renderer[] a, string b, [Out] Renderer c, [Out] Renderer d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x81485D0", Offset = "0x8146DD0", VA = "0x1881485D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x8148A20", Offset = "0x8147220", VA = "0x188148A20")]
		private (XTMHCAFEIFZ<LoadedAvatarItemPrefabHolder>, XTMHCAFEIFZ<Material[]>) ZTQHWOXPHOU()
		{
			return default((XTMHCAFEIFZ<LoadedAvatarItemPrefabHolder>, XTMHCAFEIFZ<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8147D50", Offset = "0x8146550", VA = "0x188147D50")]
		[CompilerGenerated]
		private void MUEPQKTFXCQ(LoadedAvatarItemPrefabHolder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xAB39D0", Offset = "0xAB21D0", VA = "0x180AB39D0")]
		[CompilerGenerated]
		private void MUJWNRNDGNZ(Material[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class AvatarKneeBendTargetController : MonoBehaviour, LWBLBDRCTOW
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
		private Vector3 XQLUWHTZNWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private Vector3 JYMMTTZEXDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private Vector3 QXBMSSCSHDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private Matrix4x4 DSUADGFHOOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private bool KBPUMSSHHKV;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x813D170", Offset = "0x813B970", VA = "0x18813D170", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x813D160", Offset = "0x813B960", VA = "0x18813D160", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x813CD10", Offset = "0x813B510", VA = "0x18813CD10")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x813D830", Offset = "0x813C030", VA = "0x18813D830")]
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
		[Cpp2IlInjected.Address(RVA = "0x81407B0", Offset = "0x813EFB0", VA = "0x1881407B0", Slot = "4")]
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
		public int KBJOFFEICEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x813E270", Offset = "0x813CA70", VA = "0x18813E270")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x813E1A0", Offset = "0x813C9A0", VA = "0x18813E1A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public int NPCPOCAXUWH
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x813DF60", Offset = "0x813C760", VA = "0x18813DF60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x813DB20", Offset = "0x813C320", VA = "0x18813DB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int CBQUJCNQNEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x813DF90", Offset = "0x813C790", VA = "0x18813DF90")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x813DFA0", Offset = "0x813C7A0", VA = "0x18813DFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x813E280", Offset = "0x813CA80", VA = "0x18813E280")]
		public AvatarLegacyCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x813D840", Offset = "0x813C040", VA = "0x18813D840")]
		public void ANNCDQOFIND(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x813E000", Offset = "0x813C800", VA = "0x18813E000")]
		public void UGMKXZYXKWR(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x813DFB0", Offset = "0x813C7B0", VA = "0x18813DFB0")]
		public Color ODJKBOMVGLY(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x813DF70", Offset = "0x813C770", VA = "0x18813DF70")]
		public void KWBRTZSCBIG(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x813DB30", Offset = "0x813C330", VA = "0x18813DB30")]
		public void GXHWPWXOCYU(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x813E1B0", Offset = "0x813C9B0", VA = "0x18813E1B0")]
		public void WGVBOYTELKX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x813DFD0", Offset = "0x813C7D0", VA = "0x18813DFD0")]
		public bool RYUYAWARNXS(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x813DA60", Offset = "0x813C260", VA = "0x18813DA60")]
		public void EXBNDCPLFDO(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x813E1C0", Offset = "0x813C9C0", VA = "0x18813E1C0")]
		public int[] XPYXUMUAXPS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x813DED0", Offset = "0x813C6D0", VA = "0x18813DED0")]
		private NativeSlice<int> HHXPFXUTVGH(int a)
		{
			return default(NativeSlice<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x813D8B0", Offset = "0x813C0B0", VA = "0x18813D8B0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x813DB80", Offset = "0x813C380", VA = "0x18813DB80")]
		public Mesh HDHCBEKLYYH([Optional] string a)
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
		public int YWNJTKGLJMH
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xCCA130", Offset = "0xCC8930", VA = "0x180CCA130")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int LHCWACYUJBV
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xD16190", Offset = "0xD14990", VA = "0x180D16190")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int AWHUFEWQSTW
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x813EA90", Offset = "0x813D290", VA = "0x18813EA90")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int MQHDOULFQZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x813EA80", Offset = "0x813D280", VA = "0x18813EA80")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x813EA20", Offset = "0x813D220", VA = "0x18813EA20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public int KBJOFFEICEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x813EAD0", Offset = "0x813D2D0", VA = "0x18813EAD0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x813EAC0", Offset = "0x813D2C0", VA = "0x18813EAC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int KOAWXHJLUGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x813EA50", Offset = "0x813D250", VA = "0x18813EA50")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x813EA60", Offset = "0x813D260", VA = "0x18813EA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public MeshMergeModes ZVLUIHLSUAV
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x813EA70", Offset = "0x813D270", VA = "0x18813EA70")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x813EAE0", Offset = "0x813D2E0", VA = "0x18813EAE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public byte WGVQYCQOMZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x813EA40", Offset = "0x813D240", VA = "0x18813EA40")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x813EA30", Offset = "0x813D230", VA = "0x18813EA30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public AvatarLegacyCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x8140280", Offset = "0x813EA80", VA = "0x188140280")]
			get
			{
				return default(AvatarLegacyCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x813EAF0", Offset = "0x813D2F0", VA = "0x18813EAF0")]
		public AvatarLegacyCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x813E6E0", Offset = "0x813CEE0", VA = "0x18813E6E0")]
		public AvatarLegacyCullAndCombineMeshJobContainer AFZFBKJJOGX(Allocator a)
		{
			return default(AvatarLegacyCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x813E7B0", Offset = "0x813CFB0", VA = "0x18813E7B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[Tested]
	public class JVMOMACBLBN : DAIQKIQXZRD
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8144210", Offset = "0x8142A10", VA = "0x188144210")]
		public AvatarLegacyCullAndCombineMeshJobGroup BNHSNOCMCFL()
		{
			return default(AvatarLegacyCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8133D70", Offset = "0x8132570", VA = "0x188133D70")]
		public JVMOMACBLBN()
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
		[Cpp2IlInjected.Address(RVA = "0x8141C60", Offset = "0x8140460", VA = "0x188141C60")]
		public AvatarMaterialKey(Material material, UpdatableColorType updatableColorType, UpdatableTextureType updatableTextureType, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x81419C0", Offset = "0x81401C0", VA = "0x1881419C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8141730", Offset = "0x813FF30", VA = "0x188141730", Slot = "4")]
		public bool Equals(AvatarMaterialKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x81417C0", Offset = "0x813FFC0", VA = "0x1881417C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x81418C0", Offset = "0x81400C0", VA = "0x1881418C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, EFSVVWFSLBH
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
		private FPMWPTESEEW OYCMEPMKKKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private JXZAHTZEYVD ZIFUNIPLXWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private KBLIJBEPRHD VPLVEVSZPTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private KBLIJBEPRHD OHHCYYVPKEK;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public FPMWPTESEEW TSRFLZEXDJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x8142E60", Offset = "0x8141660", VA = "0x188142E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public JXZAHTZEYVD RRYLYDLXOWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x8142EB0", Offset = "0x81416B0", VA = "0x188142EB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public KBLIJBEPRHD VLXVKVELDCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8142F00", Offset = "0x8141700", VA = "0x188142F00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public KBLIJBEPRHD ENZQYTQYOTX
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8142F50", Offset = "0x8141750", VA = "0x188142F50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Transform KQOEZFHDIGH
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x8142FA0", Offset = "0x81417A0", VA = "0x188142FA0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public AvatarBodyType MEUTGVGZYIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xADCDA0", Offset = "0xADB5A0", VA = "0x180ADCDA0", Slot = "12")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8141DA0", Offset = "0x81405A0", VA = "0x188141DA0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x8142250", Offset = "0x8140A50", VA = "0x188142250")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8142210", Offset = "0x8140A10", VA = "0x188142210", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x8142250", Offset = "0x8140A50", VA = "0x188142250", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8141DE0", Offset = "0x81405E0", VA = "0x188141DE0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x8142880", Offset = "0x8141080", VA = "0x188142880")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x8142960", Offset = "0x8141160", VA = "0x188142960")]
		private void XBQMLAOZXTZ(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x8142A20", Offset = "0x8141220", VA = "0x188142A20")]
		private FPMWPTESEEW XYZWAHQPVTP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8142300", Offset = "0x8140B00", VA = "0x188142300")]
		private JXZAHTZEYVD SSIJFPDOXUV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8142600", Offset = "0x8140E00", VA = "0x188142600")]
		private KBLIJBEPRHD TLQFWODWSIB(HandType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8142E50", Offset = "0x8141650", VA = "0x188142E50")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class VHXVRFCGREG : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private MaterialPropertyBlock SZICHUDELCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public Color? LYELKQDZFEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public Color? VZHRWAXAJYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public Color? NOCHBOXBWAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Color? BWQCKWNRIVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Color PGQIVYWXRTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public Color MLUSOERKNYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public Color RLXBSDRQWLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public Color? XMKBTYYZYCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public Texture2D ZERHMBHVYPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public float? QCBZHWNESJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public float KXZQAXFZFHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public Texture2D LPXYYEORQNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Texture2D PMVHTSCEGLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private Dictionary<AvatarMaterialKey, int> KMVLVWGPFWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private UpdatableColorType[] ARKFYPPBVID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private UpdatableTextureType[] DAHLCNZKBLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public Vector4[] RYELWTNQFSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Vector4[] IMPQJXXPTWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public Vector4[] UKQXGPETALU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public Vector4[] JLYFLBKJJSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public Vector4[] CKQDTQSYCUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public Vector4[] VOVTCISXTKY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private List<Texture2D> YQRMLHESFCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private Vector4[] CFFBLRGYTGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private List<Texture2D> QOPNQFCRVES;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private float[] ORXKDULVALQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private Vector4[] QLYKEJMMKKV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private float[] IGIZMQOMCYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public float[] DUWSRZXAODZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private List<Texture2D> QNSVEYIFQTI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private float[] WUERDAYTMSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private List<Texture2D> XDKEUCCMLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private Vector4[] TNOZHFGUKFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private float[] TJMFTBRLCKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private Vector4[] BNZZBJBGBVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public float[] NHGMKCAETXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public Texture2DArray ROFGFFHXTTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public Texture2DArray NGKJBXKNFSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public Texture2DArray XQNBRGJFNTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public Texture2DArray MGBWQGZIFRI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private bool NOVSOHUTVIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private int PBLTVDGKFAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private Vector2? HOQXHXIDABN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private TextureFormat WIARTDXJQLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private Vector2? NZYFCZUGIPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TextureFormat GXRRMAZHGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private Vector2? KTRFDWJCXLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private TextureFormat RJOWSDJJIEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private Vector2? UGLYHGEXKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private TextureFormat KFFORSUQCEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private bool EWAJJDIHWIY;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static int DDYPGIECFTI;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private static int OYXTIAQQXZY;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private static int AXRHYGQBZZY;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static int GRVLSNEJPPF;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static int LEDOKKJAQXY;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static int IZHQKNRLTMR;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private static int VHILXDKQWHK;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private static int XACNHXNNIMN;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private static int BRZCFDZQBWN;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private static int VOPFIHKPZOQ;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private static int LPIOIPCIGXC;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private static int NDBIWXMBUEI;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private static int YLCSDAKPLYU;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private static int NRXISADHKOU;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private static int VZIIJDQEJHP;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private static int QUQFLNKWKVJ;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private static int RESZUQLAYAJ;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private static int PRQYIAVLOLW;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private static int SXJOEATRDNM;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private static int QDQBDHSMKJV;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x814DEF0", Offset = "0x814C6F0", VA = "0x18814DEF0")]
		private VHXVRFCGREG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x814DE30", Offset = "0x814C630", VA = "0x18814DE30")]
		public VHXVRFCGREG(Color a, Color b, Color c, Color? d, Color? e, Color? f, Texture2D g, Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x814B840", Offset = "0x814A040", VA = "0x18814B840")]
		internal int ABVHJGRIPRC(Material a, UpdatableColorType b, UpdatableTextureType c, AvatarBodyPart d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x814B910", Offset = "0x814A110", VA = "0x18814B910")]
		private int ABVHJGRIPRC(AvatarMaterialKey a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x814CDB0", Offset = "0x814B5B0", VA = "0x18814CDB0")]
		internal int URCLHOKVFUT(Material a, Color b, Color c, Color d, Color e, Color f, Texture2D g, Vector4 h, Texture2D i, Vector4 j, float k, float l, Texture2D m, Vector4 n, float o, Texture2D p, Color q, Vector4 r, UpdatableColorType s, UpdatableTextureType t, AvatarBodyPart u)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x814BF40", Offset = "0x814A740", VA = "0x18814BF40")]
		private void RYUINPSRNMA(List<Texture2D> a, [Out] Texture2DArray b, [Out] Texture2DArray c, [Out] Texture2DArray d, [Out] Texture2DArray e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x814D990", Offset = "0x814C190", VA = "0x18814D990")]
		public void VTPNWMGLPBJ(Shader a, Renderer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x814C100", Offset = "0x814A900", VA = "0x18814C100")]
		private void TYBTKDXDEOY(Shader a, Renderer b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x814B9A0", Offset = "0x814A1A0", VA = "0x18814B9A0")]
		private Color DOEHTDFEVPZ(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x814BD40", Offset = "0x814A540", VA = "0x18814BD40")]
		private Color ITMXDVYMIVB(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x814BBE0", Offset = "0x814A3E0", VA = "0x18814BBE0")]
		private bool FRIBNOSJJEM(Texture2D a, UpdatableTextureType b, [Out] Texture2D c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x814BE90", Offset = "0x814A690", VA = "0x18814BE90")]
		private void PWMDULCNOSB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x814BBA0", Offset = "0x814A3A0", VA = "0x18814BBA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class EORTYFSETCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public readonly ItemDefinitionBodyPart RTJYXVDBNYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool HLPOWIUXWGM;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool KNCEXYKOIAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xB03560", Offset = "0xB01D60", VA = "0x180B03560")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xB857D0", Offset = "0xB83FD0", VA = "0x180B857D0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool WTTGKNVPETB
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xB85310", Offset = "0xB83B10", VA = "0x180B85310")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xB85B40", Offset = "0xB84340", VA = "0x180B85B40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual YUYCEVTIIQN.SkinCullingMask RIXBNWURNSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(YUYCEVTIIQN.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xB5F2F0", Offset = "0xB5DAF0", VA = "0x180B5F2F0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool QKJJLPUIDWR
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xCD7980", Offset = "0xCD6180", VA = "0x180CD7980")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool SEFPPXTQDUC
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x81436D0", Offset = "0x8141ED0", VA = "0x1881436D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool MOCHDBJDOPZ
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x8143840", Offset = "0x8142040", VA = "0x188143840")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool GBCPZYFQJOQ
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x8143750", Offset = "0x8141F50", VA = "0x188143750")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x81438C0", Offset = "0x81420C0", VA = "0x1881438C0")]
		protected EORTYFSETCJ(ItemDefinitionBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract QNKHPYUXYMH EKMATMXWRCR(List<CVLYOHHWPFK> a, List<CVLYOHHWPFK> b);

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract MPRYZNKLXLP TTCAFKXMOXC(uint a, AvatarSkinnedMeshBoneOrderRemapsData b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class SKKWZRNTODU : WELOEWBJDAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private AvatarSkinAssetItem UFHIQKCKXPE;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x81496E0", Offset = "0x8147EE0", VA = "0x1881496E0")]
		public SKKWZRNTODU(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, ItemDefinitionBodyPart c, [Optional] FaceFeatureId? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x81495A0", Offset = "0x8147DA0", VA = "0x1881495A0")]
		public SKKWZRNTODU(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, AvatarBodyPart c, YUYCEVTIIQN.SkinCullingMask d, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8149340", Offset = "0x8147B40", VA = "0x188149340", Slot = "6")]
		public override QNKHPYUXYMH EKMATMXWRCR(List<CVLYOHHWPFK> a, List<CVLYOHHWPFK> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class DNYSKDDQVDQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly int[] WPGROUXQONP;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly int[] ODZPKEXGYXX;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public static int[] QCTXLAMPZPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x8143290", Offset = "0x8141A90", VA = "0x188143290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x81433A0", Offset = "0x8141BA0", VA = "0x1881433A0")]
		public static int[] YJEZBWSUBAJ(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x81432F0", Offset = "0x8141AF0", VA = "0x1881432F0")]
		public static int OEHEZDKBZQO(UpdateLOD a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x81432E0", Offset = "0x8141AE0", VA = "0x1881432E0")]
		private static int FWLGFBEJGJI(UpdateLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8143380", Offset = "0x8141B80", VA = "0x188143380")]
		private static int PEUTPJTFQLT(UpdateLOD a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class EFYSTBFDFHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class ZAPBZCKLXIZ : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public JobHandle OYHCZLNYEBD;

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public ZAPBZCKLXIZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x12C7130", Offset = "0x12C5930", VA = "0x1812C7130", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x814F000", Offset = "0x814D800", VA = "0x18814F000", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public static void BWICQPTVWLE(string a, int b, long c, long d, long e, long f, long g, long h, long i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x8143520", Offset = "0x8141D20", VA = "0x188143520")]
		public static BFFPISQCYKM AGILZYAHIXI(JobHandle a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x8143670", Offset = "0x8141E70", VA = "0x188143670")]
		[IteratorStateMachine(typeof(ZAPBZCKLXIZ))]
		private static IEnumerator<ZCECIALXIMT> QOLSXGGKYFV(JobHandle a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class TQVQYJSYMYS
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
		public static readonly int ELIBATLQOGY;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly int SHVKVBXJCHH;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly int KCMKXKKGGHT;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly int GZPGLIVYLNG;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly int RIHAMIHVXYF;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly int KDXLUSNMTFT;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly int RRWOGKZTOKT;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly int FIGDDVHDUDY;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly int ANVHAIOGTYT;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly int KCROIMIEGFC;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly int CCFBBVEOJQS;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly int NOBAZMQLGNZ;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly int ZDDILMCTXDC;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x81497E0", Offset = "0x8147FE0", VA = "0x1881497E0")]
		public static bool NTEMAWUOQQM(Material a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class WELOEWBJDAD : EORTYFSETCJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class SJZNEKOBZSY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public XTMHCAFEIFZ<GameObject> QRUKNHJUWDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public WELOEWBJDAD BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Action<string> HHORJCNVOZT;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public SJZNEKOBZSY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8148F80", Offset = "0x8147780", VA = "0x188148F80")]
			internal void VHNATRVGYPB(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8148C00", Offset = "0x8147400", VA = "0x188148C00")]
			internal void VHHTWLBJPDS(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected AvatarSkinAssetItem NUXJIABWKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Material[] QLTZSMQMFPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly AvatarSkinAssetItem.SkinBodyMeshType ZMBJENVKYQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private readonly AssetReference FKSIRRNJSFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private readonly FaceFeatureId? JUYMGMEHDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private SkinnedMeshRenderer[] VFEAGFFYOFP;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override YUYCEVTIIQN.SkinCullingMask RIXBNWURNSM
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xAAD100", Offset = "0xAAB900", VA = "0x180AAD100", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(YUYCEVTIIQN.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xAAD110", Offset = "0xAAB910", VA = "0x180AAD110", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x814EBF0", Offset = "0x814D3F0", VA = "0x18814EBF0")]
		public WELOEWBJDAD(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, ItemDefinitionBodyPart d, YUYCEVTIIQN.SkinCullingMask e = (YUYCEVTIIQN.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x814EDC0", Offset = "0x814D5C0", VA = "0x18814EDC0")]
		public WELOEWBJDAD(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, YUYCEVTIIQN.SkinCullingMask d = (YUYCEVTIIQN.SkinCullingMask)0L, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x814ED20", Offset = "0x814D520", VA = "0x18814ED20")]
		public WELOEWBJDAD(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material[] c, ItemDefinitionBodyPart d, YUYCEVTIIQN.SkinCullingMask e = (YUYCEVTIIQN.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x814E730", Offset = "0x814CF30", VA = "0x18814E730", Slot = "6")]
		public override QNKHPYUXYMH EKMATMXWRCR(List<CVLYOHHWPFK> a, List<CVLYOHHWPFK> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x814E990", Offset = "0x814D190", VA = "0x18814E990", Slot = "7")]
		public override MPRYZNKLXLP TTCAFKXMOXC(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x814EB80", Offset = "0x814D380", VA = "0x18814EB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x814E940", Offset = "0x814D140", VA = "0x18814E940")]
		protected void SNCDEFVKYKP()
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
		[Cpp2IlInjected.Address(RVA = "0x8143AE0", Offset = "0x81422E0", VA = "0x188143AE0")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface LOCLQRGJUUR
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CDOFWOHBHOH(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, YUYCEVTIIQN.SkinCullingMask e = (YUYCEVTIIQN.SkinCullingMask)0L, int f = -1, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EKCFVGVZFQT(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e);
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
		[Cpp2IlInjected.Address(RVA = "0xE5D150", Offset = "0xE5B950", VA = "0x180E5D150")]
		public LoadedAvatarItemPrefabHolder(GameObject outfitObject, AvatarItemMaterial avatarItemMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8146720", Offset = "0x8144F20", VA = "0x188146720")]
		public void VGWPMJLIGJW(Material a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class GBBRUCZLZSD : OCWAATFYMKG<Task<(GameObject, AvatarItemMaterial)>, LoadedAvatarItemPrefabHolder>
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
			[Cpp2IlInjected.Address(RVA = "0x814AEA0", Offset = "0x81496A0", VA = "0x18814AEA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x814B3A0", Offset = "0x8149BA0", VA = "0x18814B3A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private XTMHCAFEIFZ<GameObject> TEQWNDENKWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private XTMHCAFEIFZ<AvatarItemMaterial> QAJHPRYJDMO;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8144180", Offset = "0x8142980", VA = "0x188144180")]
		private GBBRUCZLZSD(Task<(GameObject, AvatarItemMaterial)> a, XTMHCAFEIFZ<GameObject> b, XTMHCAFEIFZ<AvatarItemMaterial> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x8143B40", Offset = "0x8142340", VA = "0x188143B40")]
		public static GBBRUCZLZSD Create(AssetReference outfitPrefabReference, [Optional] AssetReference combinationReference)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x81440E0", Offset = "0x81428E0", VA = "0x1881440E0", Slot = "11")]
		protected override LoadedAvatarItemPrefabHolder WGNFKFYWELP(Task<(GameObject, AvatarItemMaterial)> a)
		{
			return default(LoadedAvatarItemPrefabHolder);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8143F30", Offset = "0x8142730", VA = "0x188143F30", Slot = "12")]
		protected override void JOFJRXPZIOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8143FB0", Offset = "0x81427B0", VA = "0x188143FB0")]
		[AsyncStateMachine(typeof(<WhenAllAvatarComponents>d__6))]
		private static Task<(GameObject, AvatarItemMaterial)> NPSLGJHKEIX(Task<GameObject> a, Task<AvatarItemMaterial> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class UDRYDXXRMZS
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		private class OQTYGFOZTLE : OCWAATFYMKG<Task<MaterialMapAsset>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			private XTMHCAFEIFZ<MaterialMapAsset> OYHCZLNYEBD;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x8150D80", Offset = "0x814F580", VA = "0x188150D80")]
			public OQTYGFOZTLE(XTMHCAFEIFZ<MaterialMapAsset> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x8150960", Offset = "0x814F160", VA = "0x188150960", Slot = "11")]
			protected override Material[] WGNFKFYWELP(Task<MaterialMapAsset> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8150900", Offset = "0x814F100", VA = "0x188150900", Slot = "12")]
			protected override void JOFJRXPZIOY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		private class BMHULTNONSS : OCWAATFYMKG<Task<Material[]>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			private List<XTMHCAFEIFZ<Material>> PGMJROGMAEC;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x814F860", Offset = "0x814E060", VA = "0x18814F860")]
			public BMHULTNONSS(Task<Material[]> a, List<XTMHCAFEIFZ<Material>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x814F810", Offset = "0x814E010", VA = "0x18814F810", Slot = "11")]
			protected override Material[] WGNFKFYWELP(Task<Material[]> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x814F6D0", Offset = "0x814DED0", VA = "0x18814F6D0", Slot = "12")]
			protected override void JOFJRXPZIOY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x814B450", Offset = "0x8149C50", VA = "0x18814B450")]
		public static XTMHCAFEIFZ<Material[]> JAONQCKCHRH(AssetReference[] a)
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
			[Cpp2IlInjected.Token(Token = "0x400038F")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000390")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000391")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public enum UpdatableTextureType
		{
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x4000398")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		protected class KSYZNEAUKZO : IComparable<KSYZNEAUKZO>, IEquatable<KSYZNEAUKZO>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public int PHTYRUHNLOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public PlayerAvatarDisplayBase WBBYRJPLBVN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public IList<AvatarItemSelection> RCRWGCEFGKE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public AvatarItemBodyType QQIDJVYPQER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public AvatarBuildType OZTAZPYQYBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public bool UKTXCZLUMPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public bool ZCBLCELAHZD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public int[] GBYTWKBYXDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public float YLTUWCBAOLN;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x8150470", Offset = "0x814EC70", VA = "0x188150470", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x8150320", Offset = "0x814EB20", VA = "0x188150320", Slot = "4")]
			public int CompareTo(KSYZNEAUKZO other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x8150350", Offset = "0x814EB50", VA = "0x188150350", Slot = "5")]
			public bool Equals(KSYZNEAUKZO other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public KSYZNEAUKZO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		protected abstract class EORTYFSETCJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public virtual bool KNCEXYKOIAF
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "4")]
				get
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		protected class EOLVNTMMUTZ : EORTYFSETCJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public STUBPTFTYRO CKEWUWDSDGB
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public class PHHWYPKGEUG
		{
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			public enum HandVisualStatePriority
			{
				[Cpp2IlInjected.Token(Token = "0x40003B4")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x40003B5")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x40003B6")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x40003B7")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x40003B8")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x40003B9")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x40003BA")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public static readonly int TVZNLZBATGM;

			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public static readonly int CSLWTPRHJWP;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public static readonly int JKVRMUQRJNS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected readonly HandType ZXARLAJYNLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected readonly INPVQZOHAWG RFXURRRLSPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected readonly Animator GNZPWFEWFQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected readonly Transform CRISJAFUGAE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Vector3 IXLENFBIRHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected readonly Transform WJDYMMUKNMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Vector3 VOMWUOXYTUN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool SCVBREZYHSS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected KBLIJBEPRHD UUVQFXLVQGQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected bool CGZCJLYAERN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected float EAMLNZMMUBT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected QTYJKGAEVFD<HandVisualState> XZDNNIOEDOL;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public KBLIJBEPRHD TAJNAXUEEON
			{
				[Cpp2IlInjected.Token(Token = "0x600032A")]
				[Cpp2IlInjected.Address(RVA = "0xAB3280", Offset = "0xAB1A80", VA = "0x180AB3280")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xAB32A0", Offset = "0xAB1AA0", VA = "0x180AB32A0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool PWAONMIUJPL
			{
				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x13CB7B0", Offset = "0x13C9FB0", VA = "0x1813CB7B0")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x8151560", Offset = "0x814FD60", VA = "0x188151560")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public bool LGQMLODKZXE
			{
				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0xAB4110", Offset = "0xAB2910", VA = "0x180AB4110")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x81513D0", Offset = "0x814FBD0", VA = "0x1881513D0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public float ZKWKVPXPJWO
			{
				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0xB84850", Offset = "0xB83050", VA = "0x180B84850")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000331")]
				[Cpp2IlInjected.Address(RVA = "0x8151260", Offset = "0x814FA60", VA = "0x188151260")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public HandVisualState DYDQHPJGKZX
			{
				[Cpp2IlInjected.Token(Token = "0x6000332")]
				[Cpp2IlInjected.Address(RVA = "0x8151820", Offset = "0x8150020", VA = "0x188151820")]
				get
				{
					return default(HandVisualState);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x8151960", Offset = "0x8150160", VA = "0x188151960")]
			public bool ZFUQUPONCCB(HandVisualState a, object b, HandVisualStatePriority c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x8151860", Offset = "0x8150060", VA = "0x188151860")]
			public bool YWXAQZEFTSE(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x8151B10", Offset = "0x8150310", VA = "0x188151B10")]
			protected PHHWYPKGEUG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x8151B90", Offset = "0x8150390", VA = "0x188151B90")]
			public PHHWYPKGEUG(HandType a, KBLIJBEPRHD b, Animator c, Transform d, Transform e, Vector3 f, Vector3 g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x8151720", Offset = "0x814FF20", VA = "0x188151720")]
			private void VPNRMRMRVJZ(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x8151630", Offset = "0x814FE30", VA = "0x188151630")]
			protected void TDMHFZGPGGN(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x81514A0", Offset = "0x814FCA0", VA = "0x1881514A0")]
			protected void RISWMMLCJNU(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x8150E60", Offset = "0x814F660", VA = "0x188150E60")]
			protected void EDGQATCEQRK(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x8150FE0", Offset = "0x814F7E0", VA = "0x188150FE0")]
			protected void IRHREPLTGYP(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x8150F80", Offset = "0x814F780", VA = "0x188150F80")]
			protected void IQYOOAPODSO(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x81510F0", Offset = "0x814F8F0", VA = "0x1881510F0")]
			protected void NFKJHZGLGXF(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x81517D0", Offset = "0x814FFD0", VA = "0x1881517D0")]
			protected void WYWBJKXUJIO(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x8151140", Offset = "0x814F940", VA = "0x188151140")]
			protected void OTISSLVUADQ(ushort a, ushort b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BB")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BC")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003BD")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public Transform RightHandRoot;
		}

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class OBIMTTVVZPB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public PlayerAvatarDisplayBase GXVZKQVYJQH;

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public OBIMTTVVZPB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x8150830", Offset = "0x814F030", VA = "0x188150830")]
			internal bool RVLGBEENETG()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class HDHDUAABDKM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public PlayerAvatarDisplayBase BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public AvatarItemBodyType DXNQVVHBLRT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public Func<JIREGIBPOUE<Dictionary<string, XTMHCAFEIFZ<Texture2D>>>> HGYWRIGDMRS;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public HDHDUAABDKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x814FD60", Offset = "0x814E560", VA = "0x18814FD60")]
			internal (MZYNOYQSBYJ, JIREGIBPOUE<Dictionary<string, XTMHCAFEIFZ<Texture2D>>>) NBXGEAEHYST(Dictionary<string, VLWQEDFNTAI> a)
			{
				return default((MZYNOYQSBYJ, JIREGIBPOUE<Dictionary<string, XTMHCAFEIFZ<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x814FF50", Offset = "0x814E750", VA = "0x18814FF50")]
			internal JIREGIBPOUE<Dictionary<string, XTMHCAFEIFZ<Texture2D>>> NCHTYNSCRPL()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x814FC80", Offset = "0x814E480", VA = "0x18814FC80")]
			internal void NBRZGTKKPHK()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct <CompleteBuildAsync>d__220 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0x8167FF0", Offset = "0x81667F0", VA = "0x188167FF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8168250", Offset = "0x8166A50", VA = "0x188168250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class IFCKQNXQQHG : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000354")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public IFCKQNXQQHG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x8150000", Offset = "0x814E800", VA = "0x188150000", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x814FFC0", Offset = "0x814E7C0", VA = "0x18814FFC0", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct <SetFaceCustomizationSettings>d__134 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x81684C0", Offset = "0x8166CC0", VA = "0x1881684C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x8168860", Offset = "0x8167060", VA = "0x188168860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class GPLAERLRHDK : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private SkinnedMeshRenderer VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private int AWPKGSEYDWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public PlayerAvatarDisplayBase BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private SkinnedMeshRenderer[] YLHXGKHQDKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private int YLNEDRBNMVQ;

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			private SkinnedMeshRenderer NSUVXBVHIFF
			{
				[Cpp2IlInjected.Token(Token = "0x600035A")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0xD7D9E0", Offset = "0xD7C1E0", VA = "0x180D7D9E0")]
			[DebuggerHidden]
			public GPLAERLRHDK(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "7")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x814FAB0", Offset = "0x814E2B0", VA = "0x18814FAB0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x814FA70", Offset = "0x814E270", VA = "0x18814FA70", Slot = "10")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x814F9D0", Offset = "0x814E1D0", VA = "0x18814F9D0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<SkinnedMeshRenderer> BVDROHFEIWY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600035E")]
			[Cpp2IlInjected.Address(RVA = "0x814F9D0", Offset = "0x814E1D0", VA = "0x18814F9D0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator LRASTPXJBWO()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected static List<PlayerAvatarDisplayBase> AVKREFKXCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected HelmetHairState HECPQMOKHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected bool ZODWRVFHVBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected bool PIVIPFHMFMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		protected static readonly int[] WRMNFXNVQWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private bool ISEEFRCHVUD;

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
		private KBLIJBEPRHD VPLVEVSZPTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private KBLIJBEPRHD OHHCYYVPKEK;

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
		protected Collider[] NLPVNLVADJS;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		protected Collider[] YZTBSBFNNGX;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		protected PHHWYPKGEUG[] USNJFQTYFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public bool meshDataStructUseSemioptimizedBoneWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		protected QTYJKGAEVFD<INPVQZOHAWG> XZDNNIOEDOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		protected readonly Dictionary<string, XTMHCAFEIFZ<Texture2D>> YQIGPGHUDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		protected bool ZZQZITJJPWT;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		protected static int ZCRSUXTYAOT;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		protected static List<KSYZNEAUKZO> FTXXNZXDEUJ;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		protected static List<KSYZNEAUKZO> XRJKUURCWSU;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		protected static BFFPISQCYKM KVOHHMMJVJK;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		protected static Func<List<KSYZNEAUKZO>, KSYZNEAUKZO> DESQNVGAFWP;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		protected static bool RCYGPAMOSNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		protected Color? CKBRNSDLDVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		protected bool PEGUUDDAZOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		protected Color DUYCNOXYOJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		protected Color BHNLHMMWQMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		protected Color BGNTLZCAQAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		protected AvatarHairPattern OMOAVYPBPPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		protected STUBPTFTYRO XHBFDLVFGUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		protected Color SBTQZXUTBII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		protected Color QTZJHGSJWKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		protected AvatarHairPattern KFZWICLVHRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		protected STUBPTFTYRO XYNBOPGZVNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		protected STUBPTFTYRO VRUTSOZPAOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		protected Color CKTNWYBQMRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private AdditionalFeetData OVKVLFXHZUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		protected readonly IList<AvatarItemSelection> OIWJQVZUFPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		protected readonly IList<AvatarItemSelection> XHTFPNSTFZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private AvatarItemBodyType ZKTRRMNDEMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25C")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x25D")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		protected bool RMUKYUWBDYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		protected int[] PAUINXUMAWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		protected bool CJNYTXMCDRJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		protected bool XCIFTZOIVFL;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private static readonly YUYCEVTIIQN.SkinCullingMask VVATYLLQVPN;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private static readonly YUYCEVTIIQN.SkinCullingMask GSEGCCNAEYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x26A")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		protected bool EMYGHCVSGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		protected PCLHBEYKOMB ZIIHIOUXMQP;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string KPNQXERYSQD
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xB48810", Offset = "0xB47010", VA = "0x180B48810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xC081D0", Offset = "0xC069D0", VA = "0x180C081D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool QXUAZQQJTWB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool WXOYAOGDEZD
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x8159960", Offset = "0x8158160", VA = "0x188159960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool JZXRXZPHSIX
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool HAMSVMQLGCK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool EPQGGKXYSFM
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xB63C20", Offset = "0xB62420", VA = "0x180B63C20")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x8159F20", Offset = "0x8158720", VA = "0x188159F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public KBLIJBEPRHD VLXVKVELDCG
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xCE65E0", Offset = "0xCE4DE0", VA = "0x180CE65E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x8159F40", Offset = "0x8158740", VA = "0x188159F40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public KBLIJBEPRHD ENZQYTQYOTX
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xCE65F0", Offset = "0xCE4DF0", VA = "0x180CE65F0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x815A1E0", Offset = "0x81589E0", VA = "0x18815A1E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public PlayerFacialAnimatorBase EBWTGFIOKNN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xBD5A60", Offset = "0xBD4260", VA = "0x180BD5A60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public PHHWYPKGEUG[] GPRWTLLPKXB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x81594F0", Offset = "0x8157CF0", VA = "0x1881594F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public PHHWYPKGEUG GAEFKTJJTTF
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x81599D0", Offset = "0x81581D0", VA = "0x1881599D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public PHHWYPKGEUG NGWUSFZUEZY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x8159A00", Offset = "0x8158200", VA = "0x188159A00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected bool XPZYBNPQPRN
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xACB460", Offset = "0xAC9C60", VA = "0x180ACB460", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x815A150", Offset = "0x8158950", VA = "0x18815A150", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected virtual bool DIZFOYMQAKZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected virtual int[] MGAHKTIJTLZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x8157450", Offset = "0x8155C50", VA = "0x188157450", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected bool FHDMPBHJNFS
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x8152C20", Offset = "0x8151420", VA = "0x188152C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected static bool SSQYDHAGOFU
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public IEnumerable<SkinnedMeshRenderer> YSGRVNRBDQQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x81593D0", Offset = "0x8157BD0", VA = "0x1881593D0")]
			[IteratorStateMachine(typeof(GPLAERLRHDK))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool XBJSXLTIPVF
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x21B23D0", Offset = "0x21B0BD0", VA = "0x1821B23D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x21B23E0", Offset = "0x21B0BE0", VA = "0x1821B23E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public new static bool CMIMUFGQJEV
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x8159890", Offset = "0x8158090", VA = "0x188159890")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected static BFFPISQCYKM WEJPSBGBBSX
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8153E20", Offset = "0x8152620", VA = "0x188153E20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x8154150", Offset = "0x8152950", VA = "0x188154150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		protected Color NOCHBOXBWAG
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x8153F70", Offset = "0x8152770", VA = "0x188153F70")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected Color BWQCKWNRIVI
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x8153290", Offset = "0x8151A90", VA = "0x188153290")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		protected Texture2D FZWLRCZLQDQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8152A20", Offset = "0x8151220", VA = "0x188152A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Color PGQIVYWXRTI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x81594A0", Offset = "0x8157CA0", VA = "0x1881594A0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		protected Color MLUSOERKNYC
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x8152830", Offset = "0x8151030", VA = "0x188152830")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public STUBPTFTYRO CAXFGHCCARI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x8159460", Offset = "0x8157C60", VA = "0x188159460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		protected Texture2D CCMYKFXQYWW
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x8153E70", Offset = "0x8152670", VA = "0x188153E70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public float ACYXGFCVINR
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x8159480", Offset = "0x8157C80", VA = "0x188159480")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float ZBQOSBPOSTK
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x8159940", Offset = "0x8158140", VA = "0x188159940")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool MCCYRGNDHFD
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x8159450", Offset = "0x8157C50", VA = "0x188159450")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x8159D00", Offset = "0x8158500", VA = "0x188159D00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action VMDFTKSXEHX
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x8159100", Offset = "0x8157900", VA = "0x188159100")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x8159A30", Offset = "0x8158230", VA = "0x188159A30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action IHSTAKVDLIC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x81591B0", Offset = "0x81579B0", VA = "0x1881591B0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x8159AE0", Offset = "0x81582E0", VA = "0x188159AE0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action DZSUSHRGNHG
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x8159260", Offset = "0x8157A60", VA = "0x188159260")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x8159B90", Offset = "0x8158390", VA = "0x188159B90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HandType, HandVisualState> MCJEIMTVZAQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x8159310", Offset = "0x8157B10", VA = "0x188159310")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x8159C40", Offset = "0x8158440", VA = "0x188159C40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x8155680", Offset = "0x8153E80", VA = "0x188155680")]
		public bool SetDeformation(bool deformBody, bool deformHead)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x81523D0", Offset = "0x8150BD0", VA = "0x1881523D0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8154850", Offset = "0x8153050", VA = "0x188154850")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8154D00", Offset = "0x8153500", VA = "0x188154D00")]
		protected void QXPWKIHMIRG(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x81526C0", Offset = "0x8150EC0", VA = "0x1881526C0")]
		protected void CGVFOXLPATN(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x8152760", Offset = "0x8150F60", VA = "0x188152760")]
		protected void CGVFOXLPATN(MeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8153A40", Offset = "0x8152240", VA = "0x188153A40")]
		public float GetHandOpenClosedAxis(HandType handType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x8155CC0", Offset = "0x81544C0", VA = "0x188155CC0")]
		public void SetHandOpenClosedAxis(HandType handType, float openClosedAxis)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8153A80", Offset = "0x8152280", VA = "0x188153A80")]
		public HandVisualState GetHandVisualState(HandType handType)
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8152220", Offset = "0x8150A20", VA = "0x188152220")]
		public bool AddHandVisualStateToken(HandType handType, HandVisualState handVisualState, object token, PHHWYPKGEUG.HandVisualStatePriority priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x81569E0", Offset = "0x81551E0", VA = "0x1881569E0")]
		public void SetWatchHand(HandType handType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x8156AA0", Offset = "0x81552A0", VA = "0x188156AA0")]
		public void SetWatchHands(bool showLeftHand, bool showRightHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8154FD0", Offset = "0x81537D0", VA = "0x188154FD0")]
		public bool RemoveHandVisualStateToken(HandType handType, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8153B30", Offset = "0x8152330", VA = "0x188153B30")]
		public bool GetThumbsUpActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x8156470", Offset = "0x8154C70", VA = "0x188156470")]
		public void SetThumbsUpActive(HandType handType, bool thumbsUpActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8153AF0", Offset = "0x81522F0", VA = "0x188153AF0")]
		public bool GetHandshakeActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x8155E50", Offset = "0x8154650", VA = "0x188155E50")]
		public void SetHandshakeActive(HandType handType, bool handshakeActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x81530C0", Offset = "0x81518C0", VA = "0x1881530C0")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x81568F0", Offset = "0x81550F0", VA = "0x1881568F0")]
		public void SetUseClassicBeanHandScale(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8152880", Offset = "0x8151080", VA = "0x188152880")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x81520F0", Offset = "0x81508F0", VA = "0x1881520F0")]
		private static void AHNFQMPXHBE(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8152520", Offset = "0x8150D20", VA = "0x188152520")]
		protected static void BDDJJCLPJPE(PlayerAvatarDisplayBase a, List<KSYZNEAUKZO> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8154E20", Offset = "0x8153620", VA = "0x188154E20")]
		public QNKHPYUXYMH Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x81547F0", Offset = "0x8152FF0", VA = "0x1881547F0")]
		protected QNKHPYUXYMH NRNLARAITNE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x81546C0", Offset = "0x8152EC0", VA = "0x1881546C0", Slot = "19")]
		protected virtual QNKHPYUXYMH NRNLARAITNE(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x81533E0", Offset = "0x8151BE0", VA = "0x1881533E0")]
		protected static QNKHPYUXYMH GVFTHDTOHBH(KSYZNEAUKZO a, List<KSYZNEAUKZO> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8153390", Offset = "0x8151B90", VA = "0x188153390")]
		[IteratorStateMachine(typeof(IFCKQNXQQHG))]
		protected static IEnumerator<ZCECIALXIMT> GQYUJFKEGEQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x8154300", Offset = "0x8152B00", VA = "0x188154300")]
		protected static KSYZNEAUKZO MEZFIPMXYPE(List<KSYZNEAUKZO> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x8155750", Offset = "0x8153F50", VA = "0x188155750")]
		[AsyncStateMachine(typeof(<SetFaceCustomizationSettings>d__134))]
		public Task SetFaceCustomizationSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x8156E00", Offset = "0x8155600", VA = "0x188156E00")]
		public bool UpdateFaceAndBodyCustomizationSettings(AvatarData avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8153D60", Offset = "0x8152560", VA = "0x188153D60")]
		public void InitializeFaceFeatures(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x8156260", Offset = "0x8154A60", VA = "0x188156260")]
		public void SetTeamColors(Color? teamColor, bool teamOutfitColorEmissionEnabled, Color emissiveColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x8155340", Offset = "0x8153B40", VA = "0x188155340")]
		public void SetBeardPrimaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x81554E0", Offset = "0x8153CE0", VA = "0x1881554E0")]
		public void SetBeardSecondaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x81551E0", Offset = "0x81539E0", VA = "0x1881551E0")]
		public void SetBeardPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x8152FB0", Offset = "0x81517B0", VA = "0x188152FB0")]
		private void ELMDTEXFBYM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8153CA0", Offset = "0x81524A0", VA = "0x188153CA0")]
		private bool HNTYLBFMMVE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x81559C0", Offset = "0x81541C0", VA = "0x1881559C0")]
		public void SetHairPrimaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x8155B40", Offset = "0x8154340", VA = "0x188155B40")]
		public void SetHairSecondaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x8155850", Offset = "0x8154050", VA = "0x188155850")]
		public void SetHairPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8154F70", Offset = "0x8153770", VA = "0x188154F70")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x8154990", Offset = "0x8153190", VA = "0x188154990")]
		private bool QEUYJNVSEWW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x8156160", Offset = "0x8154960", VA = "0x188156160")]
		public void SetSkinColor(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x8156580", Offset = "0x8154D80", VA = "0x188156580")]
		public void SetUgcItemVisualOverrides(AvatarItemSelection overrideItem, AvatarBodyType avatarBodyType, Texture textureOverride, Color colorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x8152620", Offset = "0x8150E20", VA = "0x188152620")]
		private void BHNIJZXUPJO(BodyProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x8158B50", Offset = "0x8157350", VA = "0x188158B50")]
		private void ZXECMBSBRHP(BodyPropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8153020", Offset = "0x8151820", VA = "0x188153020")]
		private void FRDIPZMMGGV(FaceProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x8158AB0", Offset = "0x81572B0", VA = "0x188158AB0")]
		private void YKOESQVXDNN(NoseProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8152B10", Offset = "0x8151310", VA = "0x188152B10")]
		private void DBIRKBGYZWI(FacePropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x8153B70", Offset = "0x8152370", VA = "0x188153B70")]
		private void HHMCOVUGCZI(NosePropertyData a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8156050", Offset = "0x8154850", VA = "0x188156050")]
		public bool SetHideEars(bool hideEars)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x8156030", Offset = "0x8154830", VA = "0x188156030")]
		public bool SetHelmetHair(HelmetHairState helmetHairState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x8155F60", Offset = "0x8154760", VA = "0x188155F60")]
		public void SetHatAnchorParameters(SDZUMEDZFPG newAnchorParams, bool useParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x8156140", Offset = "0x8154940", VA = "0x188156140")]
		public bool SetShowModestyAndValidationGuidelines(bool showModestyAndValidationGuidelines)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x8156B70", Offset = "0x8155370", VA = "0x188156B70")]
		public void SetupDisplayLODs(LODSelection lodSelection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x8153FC0", Offset = "0x81527C0", VA = "0x188153FC0")]
		protected int[] KPIBSVQNTBA(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x81560C0", Offset = "0x81548C0", VA = "0x1881560C0")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x8156070", Offset = "0x8154870", VA = "0x188156070")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool isFirstPerson, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x8156100", Offset = "0x8154900", VA = "0x188156100")]
		public QNKHPYUXYMH SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, LODSelection lodSelection, bool isFirstPerson, bool usesBodyPaint, bool forceRebuild = false, bool shouldBuildPotatoAvatar = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8154A50", Offset = "0x8153250", VA = "0x188154A50", Slot = "20")]
		protected virtual QNKHPYUXYMH QUDYDUGWHMR(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, LODSelection e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x8153190", Offset = "0x8151990", VA = "0x188153190")]
		protected int[] GDLXJBYNHSH(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "21")]
		protected virtual MZYNOYQSBYJ ZDAYBJAJPCY(AvatarItemBodyType a, Dictionary<string, VLWQEDFNTAI> b, Dictionary<string, XTMHCAFEIFZ<Texture2D>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x8156C00", Offset = "0x8155400", VA = "0x188156C00", Slot = "22")]
		protected virtual void UDGQFFKVUTX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8154410", Offset = "0x8152C10", VA = "0x188154410", Slot = "23")]
		protected virtual QNKHPYUXYMH NOLRKHIDGNH(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, AvatarBuildType f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x81574E0", Offset = "0x8155CE0", VA = "0x1881574E0", Slot = "24")]
		protected virtual VLWQEDFNTAI XTCINKWIOKS(STUBPTFTYRO a, AvatarItemBodyType b, AvatarBodyPart c, VLWQEDFNTAI d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAE0", Offset = "0xAAD2E0", VA = "0x180AAEAE0", Slot = "25")]
		protected virtual VLWQEDFNTAI MAPXJWGCNDK(AvatarItemBodyType a, AvatarBodyPart b, XUFRINPXUOC c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8153110", Offset = "0x8151910", VA = "0x188153110")]
		protected void GBZUDXLXDPO(ZVZUWTELACM a, YUYCEVTIIQN.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8154390", Offset = "0x8152B90", VA = "0x188154390")]
		protected void MVHWJEDBJOO(ZVZUWTELACM a, YUYCEVTIIQN.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xB10420", Offset = "0xB0EC20", VA = "0x180B10420", Slot = "26")]
		protected virtual ZVZUWTELACM JJQQVCBHDMT(ZVZUWTELACM a, HelmetHairStyle b, bool c, AvatarItemBodyType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x8157A00", Offset = "0x8156200", VA = "0x188157A00")]
		protected ZVZUWTELACM XYVOXRDZYOD(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x81532E0", Offset = "0x8151AE0", VA = "0x1881532E0")]
		protected YUYCEVTIIQN.SkinCullingMask GPFBTQDPGSF(YUYCEVTIIQN.SkinCullingMask a, AvatarBodyPart b)
		{
			return default(YUYCEVTIIQN.SkinCullingMask);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x8152950", Offset = "0x8151150", VA = "0x188152950", Slot = "12")]
		[AsyncStateMachine(typeof(<CompleteBuildAsync>d__220))]
		public override Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x8152E10", Offset = "0x8151610", VA = "0x188152E10")]
		protected static UpdatableColorType EJCFKSFQNQA(EORTYFSETCJ a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x8152CC0", Offset = "0x81514C0", VA = "0x188152CC0")]
		protected static UpdatableTextureType ECLCHVXTOOE(EORTYFSETCJ a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8156BA0", Offset = "0x81553A0", VA = "0x188156BA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8156980", Offset = "0x8155180", VA = "0x188156980")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x8156830", Offset = "0x8155030", VA = "0x188156830")]
		public void SetUgcTextureParameters(PCLHBEYKOMB parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x8158F50", Offset = "0x8157750", VA = "0x188158F50")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x8153D50", Offset = "0x8152550", VA = "0x188153D50")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task IAGLTHRFGYB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, UUABPUADKWL
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct <BuildFaceFeatureStyle>d__171 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000446")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000447")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000448")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			private TaskAwaiter<EMVQPZWRSOL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A2")]
			[Cpp2IlInjected.Address(RVA = "0x8167730", Offset = "0x8165F30", VA = "0x188167730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A3")]
			[Cpp2IlInjected.Address(RVA = "0x8167B60", Offset = "0x8166360", VA = "0x188167B60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct <BuildFaceStyleAsyncIfChanged>d__178 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x8167BC0", Offset = "0x81663C0", VA = "0x188167BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x8167F90", Offset = "0x8166790", VA = "0x188167F90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		[CompilerGenerated]
		private struct <SetAllFaceFeatureSettings>d__153 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x81682B0", Offset = "0x8166AB0", VA = "0x1881682B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x8168460", Offset = "0x8166C60", VA = "0x188168460", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000077")]
		[CompilerGenerated]
		private struct <SetFaceSettings>d__147 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x81688C0", Offset = "0x81670C0", VA = "0x1881688C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x8168B30", Offset = "0x8167330", VA = "0x188168B30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		[CompilerGenerated]
		private struct <SetFaceSettings>d__148 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x8168B90", Offset = "0x8167390", VA = "0x188168B90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x8168D70", Offset = "0x8167570", VA = "0x188168D70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000079")]
		[CompilerGenerated]
		private struct <SetSelectedFaceFeatureAndBuildFaceStyle>d__149 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x8168DD0", Offset = "0x81675D0", VA = "0x188168DD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x8168F70", Offset = "0x8167770", VA = "0x188168F70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DA")]
		protected const float WJBZLPDSFXX = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003DB")]
		protected const int NTSZMLOHQBV = 5;

		[Cpp2IlInjected.Token(Token = "0x40003DC")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		protected static readonly Dictionary<MJXUKRNIPEK.Emote, int> VFIPEQXFJLC;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> ZQGJDEINPTP;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		protected static Vector2 WLRJHDVIFNH;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected static Vector2 OFMRNGDQZGG;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		protected static Vector2 MGQYNEOQFGV;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static Vector2 JKPYVMNJXIN;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected static Vector2 BBCYQZGTFUO;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 XPLCVKJFIWF;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 JBDUYJSGCQL;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 WTCHRWFFDZK;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static Vector2 CCUGLFLRDTR;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static Vector2 UDYYJDOBLSP;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static Vector2 GSYFSHAQXKE;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static Vector2 AEPRETMQWQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000407")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000408")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000409")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		private AvatarBodyType SQDHNICJIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		private FaceStyleSet KWGZAVYGTUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x400040F")]
		protected const int KUDEKCDNKKQ = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		protected int OTYHSMJBUBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		protected int ZKJKSWZASON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected int WSWUFWZGZYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected int CZDLNTGZELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected Vector2 ULALUOIXFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected float QMOGWDVTIPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected float GXWHHQJHYDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected float HOOBNYSSUNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected Vector2 IYPPQMDYNYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected float PXPWLHERZTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected float QXEYCMNJICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected float CCXJJNVZKGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected Vector2 FFVZURCEGVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected float FUDEWRJRYBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected float URMDNKCNVFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected float QDIMIKUCUHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected Vector2 SFXBCJBYQVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected float RBCIUUQSAFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected float LFXGLASQZPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected float CEOJOQAXNSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected List<SelectableFaceOption> IWUMBZOUUJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected List<SelectableFaceOption> FYJORSBSJCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected List<SelectableFaceOption> NMFAMOFLNAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected List<SelectableFaceOption> TONJOLKHCOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected int? HSNCYOAISBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected int QWYXLYPLCAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected int RFLJHUEDWVM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected int JWATYOYQTDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected int CRGWMHDPHRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected Sprite CDEFCFKYWQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected Sprite NJCLNNBNOXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected Sprite HUCBVYRPMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected Sprite LHORTQBWWPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected bool EMFKXVKTWDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected string OOVOETDZGRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected string XWPJYLHQPLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected string MGHLXGHEQRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected string SQWJIEJCOBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		protected AvatarConfiguration OZAVRBIJWOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		protected EMVQPZWRSOL YGTCXDOPHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected Dictionary<string, int> GELNGXZWICN;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public FaceStyleSet THBPWSLVWKD
		{
			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x815FB00", Offset = "0x815E300", VA = "0x18815FB00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x815FB50", Offset = "0x815E350", VA = "0x18815FB50", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x19739F0", Offset = "0x19721F0", VA = "0x1819739F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected virtual bool JAJIXZKEGWB
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected virtual bool RBCQKBJROFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0xAC7BA0", Offset = "0xAC63A0", VA = "0x180AC7BA0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int ZXAHSGMMYAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x815E870", Offset = "0x815D070", VA = "0x18815E870")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public bool IEPVHWMLVAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xC56D00", Offset = "0xC55500", VA = "0x180C56D00")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x19739E0", Offset = "0x19721E0", VA = "0x1819739E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Renderer[] JKUTQQXMULW
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool HIABUCSDMTB
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x815FB60", Offset = "0x815E360", VA = "0x18815FB60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0x815FD20", Offset = "0x815E520", VA = "0x18815FD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int WLLUOCYRMAS
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x815C690", Offset = "0x815AE90", VA = "0x18815C690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		protected int KFALTSYFOZW
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x815BB60", Offset = "0x815A360", VA = "0x18815BB60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public float RITVHNJAQNM
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x815FB30", Offset = "0x815E330", VA = "0x18815FB30")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x815FD00", Offset = "0x815E500", VA = "0x18815FD00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public JXZAHTZEYVD RRYLYDLXOWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0xCE66E0", Offset = "0xCE4EE0", VA = "0x180CE66E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x12A0A20", Offset = "0x129F220", VA = "0x1812A0A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public EMVQPZWRSOL LFVOXZOKIHL
		{
			[Cpp2IlInjected.Token(Token = "0x600038D")]
			[Cpp2IlInjected.Address(RVA = "0xCE66C0", Offset = "0xCE4EC0", VA = "0x180CE66C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600038E")]
			[Cpp2IlInjected.Address(RVA = "0x815FC80", Offset = "0x815E480", VA = "0x18815FC80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public NoseFaceOption WFXLDUZOXGG
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xCE66B0", Offset = "0xCE4EB0", VA = "0x180CE66B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x1486EB0", Offset = "0x14856B0", VA = "0x181486EB0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action VHBUQSNHXHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x815FA50", Offset = "0x815E250", VA = "0x18815FA50")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x815FBD0", Offset = "0x815E3D0", VA = "0x18815FBD0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x815C5A0", Offset = "0x815ADA0", VA = "0x18815C5A0")]
		public void LocalPlayEmote(MJXUKRNIPEK.Emote emote, float normalizedTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x815C0B0", Offset = "0x815A8B0", VA = "0x18815C0B0")]
		public bool IsEmotePlaying(MJXUKRNIPEK.Emote emote)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x815D300", Offset = "0x815BB00", VA = "0x18815D300")]
		public void SetIdleHappy(bool happy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x815ECA0", Offset = "0x815D4A0", VA = "0x18815ECA0")]
		protected void YOCNPMJTKBL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x815D490", Offset = "0x815BC90", VA = "0x18815D490")]
		protected void TOBIGTLWZNG(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x815B790", Offset = "0x8159F90", VA = "0x18815B790")]
		protected void GBAWNYBIBRW(AvatarBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x815AE20", Offset = "0x8159620", VA = "0x18815AE20")]
		protected void EMRUNJRRTHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x815C9D0", Offset = "0x815B1D0", VA = "0x18815C9D0")]
		public void PlayExpression(int hashID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x815ED20", Offset = "0x815D520", VA = "0x18815ED20")]
		protected void ZDHZJMSYOIG(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x815B9B0", Offset = "0x815A1B0", VA = "0x18815B9B0")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType featureType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x815BBC0", Offset = "0x815A3C0", VA = "0x18815BBC0")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x815CFA0", Offset = "0x815B7A0", VA = "0x18815CFA0")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__147))]
		public Task SetFaceSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x815D090", Offset = "0x815B890", VA = "0x18815D090")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__148))]
		public Task SetFaceSettings(int eyeSelection, int eyeBrowSelection, int noseSelection, int mouthSelection, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x815D380", Offset = "0x815BB80", VA = "0x18815D380")]
		[AsyncStateMachine(typeof(<SetSelectedFaceFeatureAndBuildFaceStyle>d__149))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType featureType, int selectionIndex, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x815C6F0", Offset = "0x815AEF0", VA = "0x18815C6F0")]
		protected void NIJVHTQXKRH(FaceFeatureType a, FaceFeatureId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x815AE90", Offset = "0x8159690", VA = "0x18815AE90")]
		protected void FOZCXPUEQSQ(FaceFeatureType a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x815B800", Offset = "0x815A000", VA = "0x18815B800")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x815AD30", Offset = "0x8159530", VA = "0x18815AD30")]
		[AsyncStateMachine(typeof(<SetAllFaceFeatureSettings>d__153))]
		protected Task EKZWTBRYDIY(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x815E9A0", Offset = "0x815D1A0", VA = "0x18815E9A0")]
		protected void YDQBIHSPFFB(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x815B9F0", Offset = "0x815A1F0", VA = "0x18815B9F0")]
		protected static void IGSVWBEMBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x815C1C0", Offset = "0x815A9C0", VA = "0x18815C1C0")]
		private void KVDSFFITBGJ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x815E4E0", Offset = "0x815CCE0", VA = "0x18815E4E0")]
		protected void VBQOKYPGWLA(FaceFeatureType a, Vector2 b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x815C9F0", Offset = "0x815B1F0", VA = "0x18815C9F0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType featureType, Vector2 normalizedPositionOffset, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x815C420", Offset = "0x815AC20", VA = "0x18815C420")]
		protected void KZAOUWAOKOT(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x815D6E0", Offset = "0x815BEE0", VA = "0x18815D6E0")]
		protected void UVKUPJUZETO(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x815B6C0", Offset = "0x8159EC0", VA = "0x18815B6C0")]
		protected void FVSLDKBWYBM(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x815CD80", Offset = "0x815B580", VA = "0x18815CD80")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType featureType, float normalizedScale, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x815C8F0", Offset = "0x815B0F0", VA = "0x18815C8F0")]
		[AsyncStateMachine(typeof(<BuildFaceFeatureStyle>d__171))]
		protected Task PKAXCUDBTHR(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000392")]
		[Cpp2IlInjected.Address(RVA = "0x815BEC0", Offset = "0x815A6C0", VA = "0x18815BEC0")]
		public void InitializeFaceFeatureStyleSet(AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x815B5E0", Offset = "0x8159DE0", VA = "0x18815B5E0")]
		protected bool FUVXNFIIPDO(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x815A3F0", Offset = "0x8158BF0", VA = "0x18815A3F0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x15D2D80", Offset = "0x15D1580", VA = "0x1815D2D80", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x815C870", Offset = "0x815B070", VA = "0x18815C870")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x815AC30", Offset = "0x8159430", VA = "0x18815AC30")]
		[AsyncStateMachine(typeof(<BuildFaceStyleAsyncIfChanged>d__178))]
		public Task BuildFaceStyleAsyncIfChanged(AvatarBodyType avatarBodyType, bool forceRebuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x815E170", Offset = "0x815C970", VA = "0x18815E170")]
		public void UpdateFaceDisplays(bool forceUpdateFaceTextures = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x815A530", Offset = "0x8158D30", VA = "0x18815A530")]
		protected void BPIBPARRGLF(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x815DED0", Offset = "0x815C6D0", VA = "0x18815DED0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x815D1C0", Offset = "0x815B9C0", VA = "0x18815D1C0")]
		public void SetFaceSpriteIndices(string leftEyeName, string rightEyeName, string mouthName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x815D860", Offset = "0x815C060", VA = "0x18815D860")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x815E2F0", Offset = "0x815CAF0", VA = "0x18815E2F0")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x815D5F0", Offset = "0x815BDF0", VA = "0x18815D5F0")]
		protected void UDXOGDPZYYQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x815F860", Offset = "0x815E060", VA = "0x18815F860")]
		public PlayerFacialAnimatorBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0xADA470", Offset = "0xAD8C70", VA = "0x180ADA470", Slot = "4")]
		private bool VJMNVISDHZK()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct ModernBodyFacialExpression
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046C")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400046D")]
		public int Id;
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class ESCIYEPKKIZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			public NoseType SWXCOOZIWIE;

			[Cpp2IlInjected.Token(Token = "0x60003EA")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public ESCIYEPKKIZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EB")]
			[Cpp2IlInjected.Address(RVA = "0xBE80F0", Offset = "0xBE68F0", VA = "0x180BE80F0")]
			internal bool COQQZMUZLLQ(NoseShapePropertyData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class MOHSTOKXWDZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			public PlayerModernBodyEditorAvatarValidator BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public GameObject TNGWVLCUTUU;

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public MOHSTOKXWDZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x81505F0", Offset = "0x814EDF0", VA = "0x1881505F0")]
			internal void MHYFQAXJWTV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x81505C0", Offset = "0x814EDC0", VA = "0x1881505C0")]
			internal void MHSYSUDMNIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x8150650", Offset = "0x814EE50", VA = "0x188150650")]
			internal void MIITKOLEPQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x8150620", Offset = "0x814EE20", VA = "0x188150620")]
			internal void MIDMNHRHGFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x81506B0", Offset = "0x814EEB0", VA = "0x1881506B0")]
			internal void MITHFBYZINF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x8150680", Offset = "0x814EE80", VA = "0x188150680")]
			internal void MIOAHVFBZBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x8150710", Offset = "0x814EF10", VA = "0x188150710")]
			internal void MJDUZPMUBJX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x81506E0", Offset = "0x814EEE0", VA = "0x1881506E0")]
			internal void MIYOCISWRYO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x8150770", Offset = "0x814EF70", VA = "0x188150770")]
			internal void MJOIUDAOUGP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x8150740", Offset = "0x814EF40", VA = "0x188150740")]
			internal void MJJBWWGRKVG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x81507A0", Offset = "0x814EFA0", VA = "0x1881507A0")]
			internal void UOLYDFEJSRG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x81507D0", Offset = "0x814EFD0", VA = "0x1881507D0")]
			internal void UORFALYHCCP()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct <UpdateFaceFeatures>d__140 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x8169B30", Offset = "0x8168330", VA = "0x188169B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xB0EA50", Offset = "0xB0D250", VA = "0x180B0EA50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private struct <UpdateFaceFeaturesInternal>d__141 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x8169560", Offset = "0x8167D60", VA = "0x188169560", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x8169AD0", Offset = "0x81682D0", VA = "0x188169AD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400046E")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public AvatarBodyType avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public HelmetHairState useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public SDZUMEDZFPG hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public QSDEEDJHFEW HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GameObject torsoModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public GameObject legsModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GameObject validationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public bool showModestyAndValidationGuidelines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		private EFSVVWFSLBH FMHNTHVGGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public BodyShapeConfiguration bodyShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		public FaceShapeConfiguration faceShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public NoseShapeConfiguration noseShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private AnimatorOverrideController SPDBVISXYUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> BWTCTDWYGTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public readonly ModernBodyFacialExpression[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public readonly (string, HandVisualState)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x272")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		protected bool OQADPAZMCQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		protected Guid NNGROHTLGTW;

		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		protected static Guid VRUFYKTDNKD;

		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private static readonly int ZWPQSOORDZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private FPMWPTESEEW OYCMEPMKKKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private JXZAHTZEYVD ZIFUNIPLXWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private KBLIJBEPRHD VPLVEVSZPTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private KBLIJBEPRHD OHHCYYVPKEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private AdditionalHatData SHBFWUMGMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private readonly Dictionary<GameObject, STUBPTFTYRO> OLCXDJERUPC;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<XUFRINPXUOC> YRMSASTVTIM
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x8166240", Offset = "0x8164A40", VA = "0x188166240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x8166880", Offset = "0x8165080", VA = "0x188166880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool QEUYJNVSEWW
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x81663A0", Offset = "0x8164BA0", VA = "0x1881663A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool HNTYLBFMMVE
		{
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x8166290", Offset = "0x8164A90", VA = "0x188166290")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase UYCFLMUUKUI
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0xB306B0", Offset = "0xB2EEB0", VA = "0x180B306B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid SQLSYZLJWVW
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x81621B0", Offset = "0x81609B0", VA = "0x1881621B0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject prefab, AvatarBodyPart part)[] PSMTMEKGXDL
		{
			[Cpp2IlInjected.Token(Token = "0x60003CB")]
			[Cpp2IlInjected.Address(RVA = "0x81664B0", Offset = "0x8164CB0", VA = "0x1881664B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x81631D0", Offset = "0x81619D0", VA = "0x1881631D0")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x81626E0", Offset = "0x8160EE0", VA = "0x1881626E0")]
		private IEnumerable<GameObject> PNOHITTYKFI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x81636F0", Offset = "0x8161EF0", VA = "0x1881636F0")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x81628C0", Offset = "0x81610C0", VA = "0x1881628C0")]
		private void PUNKTIJTTPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x12E30C0", Offset = "0x12E18C0", VA = "0x1812E30C0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x8160B10", Offset = "0x815F310", VA = "0x188160B10")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x8163970", Offset = "0x8162170", VA = "0x188163970")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x8163510", Offset = "0x8161D10", VA = "0x188163510")]
		public void ShowPose(AnimationClip pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x81636C0", Offset = "0x8161EC0", VA = "0x1881636C0")]
		public void ShowPose(string poseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x8163340", Offset = "0x8161B40", VA = "0x188163340")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x81631E0", Offset = "0x81619E0", VA = "0x1881631E0")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x8164AB0", Offset = "0x81632B0", VA = "0x188164AB0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x8164420", Offset = "0x8162C20", VA = "0x188164420")]
		public void UpdateFaceAndBodyShapes(bool forceRebuild = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x8164ED0", Offset = "0x81636D0", VA = "0x188164ED0")]
		public void UpdateNoseShape(NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x8164E90", Offset = "0x8163690", VA = "0x188164E90")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x8161600", Offset = "0x815FE00", VA = "0x188161600", Slot = "4")]
		protected virtual void KYFKRUGLZIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x8163700", Offset = "0x8161F00", VA = "0x188163700", Slot = "5")]
		protected virtual void TMUXLYTAWNV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x815FF80", Offset = "0x815E780", VA = "0x18815FF80")]
		public void ApplyHatData(AdditionalHatData hatData, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x815FDC0", Offset = "0x815E5C0", VA = "0x18815FDC0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x81602E0", Offset = "0x815EAE0", VA = "0x1881602E0")]
		public void ApplyHatUVOverride(Vector2 UVOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x8160200", Offset = "0x815EA00", VA = "0x188160200")]
		public void ApplyHatPositionAdjustment(Vector3 positionAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x8160270", Offset = "0x815EA70", VA = "0x188160270")]
		public void ApplyHatRotationAdjustment(Vector3 rotationAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x8160350", Offset = "0x815EB50", VA = "0x188160350")]
		public AvatarItemSelection BuildAvatarItemSelection(GameObject selection, AvatarBodyType bodyType, AvatarBodyPart part)
		{
			return default(AvatarItemSelection);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x81603F0", Offset = "0x815EBF0", VA = "0x1881603F0")]
		public void BuildAvatar(bool forceRebuild = false, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x8163D80", Offset = "0x8162580", VA = "0x188163D80")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x815FF00", Offset = "0x815E700", VA = "0x18815FF00")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x8164CE0", Offset = "0x81634E0", VA = "0x188164CE0")]
		public void UpdateHatAnchor(bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x8164A00", Offset = "0x8163200", VA = "0x188164A00")]
		[AsyncStateMachine(typeof(<UpdateFaceFeatures>d__140))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x8163CB0", Offset = "0x81624B0", VA = "0x188163CB0")]
		[AsyncStateMachine(typeof(<UpdateFaceFeaturesInternal>d__141))]
		private Task UWWMXOUTLNP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x8161300", Offset = "0x815FB00", VA = "0x188161300")]
		private void JPHQXXUPFGH(FaceFeatureType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x8161270", Offset = "0x815FA70", VA = "0x188161270")]
		private void JOTNVNIDEFB(FaceFeatureType a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x81642E0", Offset = "0x8162AE0", VA = "0x1881642E0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x8165200", Offset = "0x8163A00", VA = "0x188165200")]
		public void UpdatePosingProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x8164B40", Offset = "0x8163340", VA = "0x188164B40")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x8161C90", Offset = "0x8160490", VA = "0x188161C90")]
		private void LULNRNPMTJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private void VAWCWRQMLXM(STUBPTFTYRO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		private void MKHTFKBDRVA(STUBPTFTYRO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x8161910", Offset = "0x8160110", VA = "0x188161910")]
		private void LJCZTNBPZDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x81629B0", Offset = "0x81611B0", VA = "0x1881629B0")]
		public void PopulatePrefabSlotsByGuid(List<Guid> guids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x81652A0", Offset = "0x8163AA0", VA = "0x1881652A0")]
		private void VOZPXGZIZQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x8162350", Offset = "0x8160B50", VA = "0x188162350")]
		private void PJNUGKHHOEV(OutfitType a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x81655A0", Offset = "0x8163DA0", VA = "0x1881655A0")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x81615C0", Offset = "0x815FDC0", VA = "0x1881615C0")]
		[CompilerGenerated]
		private bool JYPDGQLNANM(FaceShapePropertyData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x81622A0", Offset = "0x8160AA0", VA = "0x1881622A0")]
		[CompilerGenerated]
		private AvatarItemSelection PHIYGVLQFBE((GameObject prefab, AvatarBodyPart part) h)
		{
			return default(AvatarItemSelection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[AddComponentMenu("/")]
	public class RoomiePuppet : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000082")]
		public class RoomieAvatarReferences
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public Transform hatAnchorBone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			public AvatarSkinnedMeshBoneOrderRemapsData boneOrderRemap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			public SkinnedMeshRenderer roomieBaseSkinnedMeshRenderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			public Material[] roomieBaseMaterials;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004EB")]
			public AssetReference roomieBodyAssetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			public Transform deformRigRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			public GameObject generatedMeshContainer;

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public RoomieAvatarReferences()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E5")]
		public RoomieAvatarDisplay avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E6")]
		[SerializeField]
		private RoomieAvatarReferences _references;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x8166AA0", Offset = "0x81652A0", VA = "0x188166AA0")]
		public void SetOutfitItems(IEnumerable<Guid> avatarItemGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x81668F0", Offset = "0x81650F0", VA = "0x1881668F0")]
		public void InitializeAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
		public RoomiePuppet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004F4")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAC0", Offset = "0xAAD2C0", VA = "0x180AAEAC0")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public struct AvatarItemSelection
	{
		[Cpp2IlInjected.Token(Token = "0x2000086")]
		[CompilerGenerated]
		private sealed class ELCYXXBCTYR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F7")]
			public IEnumerable<OutfitType> YDOHGXLNGXT;

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public ELCYXXBCTYR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x814F8D0", Offset = "0x814E0D0", VA = "0x18814F8D0")]
			internal bool HHRVCMLOINQ(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private STUBPTFTYRO _avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private AvatarBodyPart _bodyPart;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public STUBPTFTYRO CKEWUWDSDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xC21660", Offset = "0xC1FE60", VA = "0x180C21660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public AvatarBodyPart RTJYXVDBNYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xC21670", Offset = "0xC1FE70", VA = "0x180C21670")]
			get
			{
				return default(AvatarBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public string GYKJPXPTTAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x814F130", Offset = "0x814D930", VA = "0x18814F130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool NSOJSFJFTMS
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x814F0E0", Offset = "0x814D8E0", VA = "0x18814F0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool SOLVRKBUDTD
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x814F090", Offset = "0x814D890", VA = "0x18814F090")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool GCYBLNNIIKD
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x814F220", Offset = "0x814DA20", VA = "0x18814F220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x185F380", Offset = "0x185DB80", VA = "0x18185F380")]
		public AvatarItemSelection(STUBPTFTYRO avatarItem, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x814F450", Offset = "0x814DC50", VA = "0x18814F450")]
		public bool WNKFKBNIVLX(OutfitType a, AvatarBodyPart b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x814F270", Offset = "0x814DA70", VA = "0x18814F270")]
		public bool UZAPVYPRDMG(AvatarItemSelection a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public class WJVGLUSVPJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000088")]
		[CompilerGenerated]
		private sealed class FICTOKKRDFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			public IEnumerable<OutfitType> YDOHGXLNGXT;

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public FICTOKKRDFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x814F950", Offset = "0x814E150", VA = "0x18814F950")]
			internal bool HHRVCMLOINQ(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		private STUBPTFTYRO MPBAOZQLRCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private RoomieBodyPart JUVNOZFQSDH;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public STUBPTFTYRO CKEWUWDSDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public RoomieBodyPart RTJYXVDBNYS
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xAB1200", Offset = "0xAAFA00", VA = "0x180AB1200")]
			get
			{
				return default(RoomieBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Color? MWUYGRPPWGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xABA040", Offset = "0xAB8840", VA = "0x180ABA040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xABA010", Offset = "0xAB8810", VA = "0x180ABA010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3? SOURHICWKCZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xCD8870", Offset = "0xCD7070", VA = "0x180CD8870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xCD7B20", Offset = "0xCD6320", VA = "0x180CD7B20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x8169E50", Offset = "0x8168650", VA = "0x188169E50")]
		public WJVGLUSVPJO(STUBPTFTYRO a, RoomieBodyPart b, Color? c, Vector3? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8169D30", Offset = "0x8168530", VA = "0x188169D30")]
		public bool UZAPVYPRDMG(WJVGLUSVPJO a)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1451682669
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x8169EC0", Offset = "0x81686C0", VA = "0x188169EC0")]
	public static void AXVIOBQOKOH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x8169F40", Offset = "0x8168740", VA = "0x188169F40")]
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
