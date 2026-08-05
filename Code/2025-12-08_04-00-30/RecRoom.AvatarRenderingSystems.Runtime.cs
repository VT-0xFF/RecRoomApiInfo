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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9A60", Offset = "0xAC8260", VA = "0x180AC9A60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAC9AA0", Offset = "0xAC82A0", VA = "0x180AC9AA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8078930", Offset = "0x8077130", VA = "0x188078930", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		private RecNetCDNKey UWHDEJCLXLY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RecNetCDNKey TypedRuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAA3250", Offset = "0xAA1A50", VA = "0x180AA3250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xC2CFC0", Offset = "0xC2B7C0", VA = "0x180C2CFC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8079250", Offset = "0x8077A50", VA = "0x188079250", Slot = "19")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8079280", Offset = "0x8077A80", VA = "0x188079280")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1640", Offset = "0xA9FE40", VA = "0x180AA1640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA1370", Offset = "0xA9FB70", VA = "0x180AA1370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAA15F0", Offset = "0xA9FDF0", VA = "0x180AA15F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAA1380", Offset = "0xA9FB80", VA = "0x180AA1380")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB02810", Offset = "0xB01010", VA = "0x180B02810")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB03320", Offset = "0xB01B20", VA = "0x180B03320")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ItemPathHint PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC8B640", Offset = "0xC89E40", VA = "0x180C8B640")]
			[CompilerGenerated]
			get
			{
				return default(ItemPathHint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCD61F0", Offset = "0xCD49F0", VA = "0x180CD61F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8079390", Offset = "0x8077B90", VA = "0x188079390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8079310", Offset = "0x8077B10", VA = "0x188079310")]
		public static RecNetCDNKey QSLJNGOLGNF(string a, ItemPathHint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x80792C0", Offset = "0x8077AC0", VA = "0x1880792C0")]
		public void LPOEZFQLWNG(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public RecNetCDNKey()
		{
		}
	}
}
namespace RecRoom.AI.RoomieAI
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomieAvatarDisplay : AvatarDisplayBase, FDAAWKBDLQS
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct EquipResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public IEnumerable<DZJZUXSMRLS> equippedItems;

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
				[Cpp2IlInjected.Address(RVA = "0xC27030", Offset = "0xC25830", VA = "0x180C27030")]
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
				[Cpp2IlInjected.Address(RVA = "0xAB0800", Offset = "0xAAF000", VA = "0x180AB0800")]
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
				[Cpp2IlInjected.Address(RVA = "0xBBE9C0", Offset = "0xBBD1C0", VA = "0x180BBE9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x8078910", Offset = "0x8077110", VA = "0x188078910")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x80788B0", Offset = "0x80770B0", VA = "0x1880788B0")]
			public DisplayItemData(Guid customAvatarItemId, Vector3? rotation, Color? color, RoomieBodyPart part)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <AvatarRuntimeBuildMeshRoutine>d__125 : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private YTAMKWOJLST <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public List<HMAQRAUSQTD> parts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public RoomieAvatarDisplay <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public List<IHSGGRZWIQF> innerPromises;

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
			private YTAMKWOJLST System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public <AvatarRuntimeBuildMeshRoutine>d__125(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x807EC60", Offset = "0x807D460", VA = "0x18807EC60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x807EE90", Offset = "0x807D690", VA = "0x18807EE90", Slot = "8")]
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
		private readonly List<BRTZTUAOXLG> _nextPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<BRTZTUAOXLG> _currentPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<BRTZTUAOXLG> _nextMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<BRTZTUAOXLG> _currentMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<DisplayItemData> _EquippedDisplayItemOutfitSelections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly IList<DZJZUXSMRLS> _currentEquippedOutfitSelections;

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
		private readonly MWKYWAOJZRV _buildCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly MWKYWAOJZRV _buildCancelled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private SkinnedMeshRenderer[] _cachedBuiltBodySkinMeshes;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public MWKYWAOJZRV DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xBF04D0", Offset = "0xBEECD0", VA = "0x180BF04D0", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public MWKYWAOJZRV DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xC98170", Offset = "0xC96970", VA = "0x180C98170", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xABD680", Offset = "0xABBE80", VA = "0x180ABD680", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x807EC40", Offset = "0x807D440", VA = "0x18807EC40", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xC98160", Offset = "0xC96960", VA = "0x180C98160", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xB84D70", Offset = "0xB83570", VA = "0x180B84D70", Slot = "35")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform HatBone
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "51")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public MWKYWAOJZRV OnAnimationCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x807EC00", Offset = "0x807D400", VA = "0x18807EC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x807EAF0", Offset = "0x807D2F0", VA = "0x18807EAF0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PositionAndRotation HatPivotLocalPosAndRot
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x807EB30", Offset = "0x807D330", VA = "0x18807EB30", Slot = "56")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ZOFPULOBJQZ.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x807EAA0", Offset = "0x807D2A0", VA = "0x18807EAA0", Slot = "32")]
			get
			{
				return default(ZOFPULOBJQZ.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x80799F0", Offset = "0x80781F0", VA = "0x1880799F0", Slot = "50")]
		protected virtual DZJZUXSMRLS AvatarItemDefinitionFromDisplayItemDefinition(DisplayItemData displayItemData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x807C170", Offset = "0x807A970", VA = "0x18807C170")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x807E3D0", Offset = "0x807CBD0", VA = "0x18807E3D0")]
		private void _UpdateManualLod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x807C710", Offset = "0x807AF10", VA = "0x18807C710")]
		private void QueuePostBuiltAvatarCustomizationUpdate(Action updateMatPropertAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8079920", Offset = "0x8078120", VA = "0x188079920")]
		private void ApplyQueuedCustomizationUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8079400", Offset = "0x8077C00", VA = "0x188079400")]
		private void ApplyColorsToInstances()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x807BB00", Offset = "0x807A300", VA = "0x18807BB00", Slot = "28")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x807C060", Offset = "0x807A860", VA = "0x18807C060")]
		private PositionAndRotation GetHatAdjustmentOrDefault()
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x80797C0", Offset = "0x8077FC0", VA = "0x1880797C0", Slot = "44")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x807C140", Offset = "0x807A940", VA = "0x18807C140", Slot = "47")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x807C510", Offset = "0x807AD10", VA = "0x18807C510")]
		public Task PlayAnimation(string animationName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x807DBC0", Offset = "0x807C3C0", VA = "0x18807DBC0", Slot = "17")]
		public void SetUgcItemVisualOverrides(DZJZUXSMRLS overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x807DC40", Offset = "0x807C440", VA = "0x18807DC40", Slot = "18")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x807DC00", Offset = "0x807C400", VA = "0x18807DC00", Slot = "19")]
		public void SetUgcTextureParameters(VPCNPKAGHQN parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x807E290", Offset = "0x807CA90", VA = "0x18807E290", Slot = "48")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x807E390", Offset = "0x807CB90", VA = "0x18807E390", Slot = "49")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties effectFloat4Properties, TextureEffectMaterialTextures effectTexture2DProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x807CA20", Offset = "0x807B220", VA = "0x18807CA20", Slot = "45")]
		public void SetHatAnchorParams(SSHQATTNPKI anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x807E310", Offset = "0x807CB10", VA = "0x18807E310", Slot = "46")]
		public void UpdateHatPivot([Optional] SSHQATTNPKI anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x80799B0", Offset = "0x80781B0", VA = "0x1880799B0", Slot = "23")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x807DDB0", Offset = "0x807C5B0", VA = "0x18807DDB0")]
		public void Setup([In] AvatarDisplaySetupState _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x807C860", Offset = "0x807B060", VA = "0x18807C860", Slot = "33")]
		public bool SetBaseSkinCullingMask(ZOFPULOBJQZ.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x807C920", Offset = "0x807B120", VA = "0x18807C920", Slot = "20")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x807DB40", Offset = "0x807C340", VA = "0x18807DB40", Slot = "21")]
		public void SetSkinColors(Color skinColor, Color? skinEmissiveColor, float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x807B850", Offset = "0x807A050", VA = "0x18807B850", Slot = "27")]
		public IHSGGRZWIQF BuildPotatoAvatar(GXUGUISWSPC avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x807DB80", Offset = "0x807C380", VA = "0x18807DB80", Slot = "22")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x807C9E0", Offset = "0x807B1E0", VA = "0x18807C9E0")]
		public void SetFaceShape(AvatarFaceShape faceShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x807C8E0", Offset = "0x807B0E0", VA = "0x18807C8E0")]
		public void SetBodyShape(AvatarBodyShape bodyShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x807C8A0", Offset = "0x807B0A0", VA = "0x18807C8A0", Slot = "37")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x80793C0", Offset = "0x8077BC0", VA = "0x1880793C0", Slot = "38")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x807C9A0", Offset = "0x807B1A0", VA = "0x18807C9A0", Slot = "39")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x807CA80", Offset = "0x807B280", VA = "0x18807CA80", Slot = "40")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8079780", Offset = "0x8077F80", VA = "0x188079780", Slot = "41")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x80798E0", Offset = "0x80780E0", VA = "0x1880798E0", Slot = "42")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x807CAC0", Offset = "0x807B2C0", VA = "0x18807CAC0")]
		public void SetNoseType(NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x807C960", Offset = "0x807B160", VA = "0x18807C960", Slot = "43")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x807E2D0", Offset = "0x807CAD0", VA = "0x18807E2D0", Slot = "52")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x807E350", Offset = "0x807CB50", VA = "0x18807E350", Slot = "53")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x807BB00", Offset = "0x807A300", VA = "0x18807BB00")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xC98310", Offset = "0xC96B10", VA = "0x180C98310", Slot = "54")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayThirdPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "55")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayFirstPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x80797C0", Offset = "0x8077FC0", VA = "0x1880797C0")]
		public void OnLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x807C570", Offset = "0x807AD70", VA = "0x18807C570")]
		private void PostOutfitUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x807C550", Offset = "0x807AD50", VA = "0x18807C550")]
		private void PostMeshBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x807CA60", Offset = "0x807B260", VA = "0x18807CA60", Slot = "16")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x807D9B0", Offset = "0x807C1B0", VA = "0x18807D9B0")]
		public void SetRoomieBoostCustomizationFloat(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x807DA40", Offset = "0x807C240", VA = "0x18807DA40")]
		public void SetRoomiePrimarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x807DAC0", Offset = "0x807C2C0", VA = "0x18807DAC0")]
		public void SetRoomieSecondarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x807CB00", Offset = "0x807B300", VA = "0x18807CB00")]
		public Task<EquipResult> SetOutfitSelection(IReadOnlyList<DisplayItemData> displayItemDatas, bool forceBuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x807B890", Offset = "0x807A090", VA = "0x18807B890")]
		private List<DZJZUXSMRLS> CreateEquippedItemsFrorOutfitSelection(IReadOnlyList<Guid> customAvatarItemIds, IReadOnlyList<DisplayItemData> correspondingDADs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x807A430", Offset = "0x8078C30", VA = "0x18807A430", Slot = "26")]
		public IHSGGRZWIQF BuildAvatarMeshes(GXUGUISWSPC avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, DZJZUXSMRLS>, (IHSGGRZWIQF, PVOPFDWRLHK<Dictionary<string, TNVOTOCMHUP<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x807BF60", Offset = "0x807A760", VA = "0x18807BF60")]
		private bool GetCustomizationRequiresMeshBuild(List<DisplayItemData> newItemSelections)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x807E110", Offset = "0x807C910", VA = "0x18807E110")]
		private void TeardownInProgressBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8079E80", Offset = "0x8078680", VA = "0x188079E80")]
		public IHSGGRZWIQF BuildAvatarMeshesInternal(GXUGUISWSPC avatarBuildParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x807DDF0", Offset = "0x807C5F0", VA = "0x18807DDF0")]
		private void SwapActiveResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x807C810", Offset = "0x807B010", VA = "0x18807C810")]
		private void ReleasePrefabs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x807BDE0", Offset = "0x807A5E0", VA = "0x18807BDE0")]
		private void FinalizeRoomieDisplayUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x807C4B0", Offset = "0x807ACB0", VA = "0x18807C4B0")]
		private bool IsReadyToBuildLODMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x807BBD0", Offset = "0x807A3D0", VA = "0x18807BBD0")]
		private IHSGGRZWIQF EditorBuildMeshes(bool isFirstPerson, List<HMAQRAUSQTD> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x807DC80", Offset = "0x807C480", VA = "0x18807DC80")]
		private void SetupNewlyCreatedMesh(SkinnedMeshRenderer lodRenderer, int lod, Mesh mesh, List<Material> newUniqueMaterials)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x807A440", Offset = "0x8078C40", VA = "0x18807A440")]
		private XEXLSJPFYXK BuildLODMesh(List<HMAQRAUSQTD> parts, int lod, bool isFirstPerson, Layers layer, bool IsSpreadAcrossFrames = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8079DA0", Offset = "0x80785A0", VA = "0x188079DA0")]
		[IteratorStateMachine(typeof(<AvatarRuntimeBuildMeshRoutine>d__125))]
		private IEnumerator<YTAMKWOJLST> AvatarRuntimeBuildMeshRoutine(bool isFirstPerson, List<HMAQRAUSQTD> parts, int[] LODs, Func<int, Layers> getLayer, List<IHSGGRZWIQF> innerPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x807B590", Offset = "0x8079D90", VA = "0x18807B590")]
		private IHSGGRZWIQF BuildLODMeshes(bool isFirstPerson, List<HMAQRAUSQTD> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x807E600", Offset = "0x807CE00", VA = "0x18807E600")]
		public RoomieAvatarDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x807C7F0", Offset = "0x807AFF0", VA = "0x18807C7F0", Slot = "14")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x807C800", Offset = "0x807B000", VA = "0x18807C800", Slot = "15")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Setup([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Tested]
	public class QMDFTXJWWJP : MZVAGZVGOLT
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly List<Mesh> ZBLZXCFEBNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		protected readonly List<IReadOnlyList<byte>> BFFMRBIIKCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		protected readonly List<Matrix4x4> HLVGPINVEUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly List<bool> KGWVIIROBTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly List<long> ZZMBXHZGEHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		protected readonly List<bool> NBJTYBDXLVB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		protected readonly List<int> QIOJOXOKSMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected Allocator VLNPFXQFAEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected MeshMergeModes DBHZNAPMPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected byte SZXNEMRDOKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected IList<int> JQIOYWWDRSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected IList<int> YDROQDXWWTF;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8078C50", Offset = "0x8077450", VA = "0x188078C50", Slot = "4")]
		public void LZKGZEVKKNF(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, ZOFPULOBJQZ.SkinCullingMask e = (ZOFPULOBJQZ.SkinCullingMask)0L, int f = -1, bool g = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8079000", Offset = "0x8077800", VA = "0x188079000", Slot = "5")]
		public void WPENSCRTCNV(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x80789F0", Offset = "0x80771F0", VA = "0x1880789F0")]
		private static void BDVEYGGWXWH(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8079040", Offset = "0x8077840", VA = "0x188079040")]
		public QMDFTXJWWJP()
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
		[Cpp2IlInjected.Address(RVA = "0x8067C70", Offset = "0x8066470", VA = "0x188067C70", Slot = "4")]
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
		public int HYCUGVMNLHX
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8063490", Offset = "0x8061C90", VA = "0x188063490")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x8064AB0", Offset = "0x80632B0", VA = "0x188064AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int MNRKLQHREOP
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x8063770", Offset = "0x8061F70", VA = "0x188063770")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x8063BB0", Offset = "0x80623B0", VA = "0x188063BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int UFZYWISAMMV
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x8063480", Offset = "0x8061C80", VA = "0x188063480")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x8063700", Offset = "0x8061F00", VA = "0x188063700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int UVIEXZVOVLI
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8063CB0", Offset = "0x80624B0", VA = "0x188063CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x8065B20", Offset = "0x8064320", VA = "0x188065B20")]
		public AvatarCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels, FPOPNCQVAGN systemInfoAccess, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x8064AD0", Offset = "0x80632D0", VA = "0x188064AD0")]
		public void RVCNJFCHYXX(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8063780", Offset = "0x8061F80", VA = "0x188063780")]
		public void JJEXDQVFGDX(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x8064790", Offset = "0x8062F90", VA = "0x188064790")]
		public Color OVCMFBNQHBY(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x8063D20", Offset = "0x8062520", VA = "0x188063D20")]
		public void NFHMXQPJQMC(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x8063BC0", Offset = "0x80623C0", VA = "0x188063BC0")]
		public void MYVAHJDWKBA(int a, Vector3 b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x8063330", Offset = "0x8061B30", VA = "0x188063330")]
		public void AUHDOXDCQVO(int a, half4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x8064160", Offset = "0x8062960", VA = "0x188064160")]
		public void NOKDWSALYZY(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x80643B0", Offset = "0x8062BB0", VA = "0x1880643B0")]
		public void NUMRZRBPODG(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x8064AC0", Offset = "0x80632C0", VA = "0x188064AC0")]
		public void RCJRACGMPWX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8063710", Offset = "0x8061F10", VA = "0x188063710")]
		public bool FUVMCALNIQE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x8065A60", Offset = "0x8064260", VA = "0x188065A60")]
		public void VLLAKFCYDVC(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x80634A0", Offset = "0x8061CA0", VA = "0x1880634A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x8064B60", Offset = "0x8063360", VA = "0x188064B60")]
		public Mesh TCQTLQJVNYL([Optional] string a)
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
		public int QESGTWEFGIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8066920", Offset = "0x8065120", VA = "0x188066920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int VAHFNNLPTNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x8066550", Offset = "0x8064D50", VA = "0x188066550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int LMJNSRRWMLG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8066720", Offset = "0x8064F20", VA = "0x188066720")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int LINGYLJSLHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8066800", Offset = "0x8065000", VA = "0x188066800")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x8066810", Offset = "0x8065010", VA = "0x188066810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int HYCUGVMNLHX
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x8066560", Offset = "0x8064D60", VA = "0x188066560")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8066820", Offset = "0x8065020", VA = "0x188066820")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int CVMEOTKLULK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x80667F0", Offset = "0x8064FF0", VA = "0x1880667F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x8066710", Offset = "0x8064F10", VA = "0x188066710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MeshMergeModes GNRPHDVBUNT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x8066830", Offset = "0x8065030", VA = "0x188066830")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x8066840", Offset = "0x8065040", VA = "0x188066840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public byte HPFGGCPDRAM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x8066700", Offset = "0x8064F00", VA = "0x188066700")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8066570", Offset = "0x8064D70", VA = "0x188066570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public AvatarCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8067A20", Offset = "0x8066220", VA = "0x188067A20")]
			get
			{
				return default(AvatarCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x8066930", Offset = "0x8065130", VA = "0x188066930")]
		public AvatarCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x8066850", Offset = "0x8065050", VA = "0x188066850")]
		public AvatarCullAndCombineMeshJobContainer XQIBLGXQDLR(Allocator a, FPOPNCQVAGN b)
		{
			return default(AvatarCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x8066580", Offset = "0x8064D80", VA = "0x188066580", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Tested]
	public class WHUNBFRWURQ : QMDFTXJWWJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool GQWHXSXGXCD;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly ProfilerMarker SKZLKXLVQLY;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x807FE70", Offset = "0x807E670", VA = "0x18807FE70")]
		public AvatarCullAndCombineMeshJobGroup XADGQOHYFUR()
		{
			return default(AvatarCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x8080100", Offset = "0x807E900", VA = "0x188080100")]
		public WHUNBFRWURQ()
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
		protected LODSelection DROIIKCAUPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		protected int[] REBIHUOVTIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int requestedLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		protected int ZBVKWOGOMHL;

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
		protected FDAAWKBDLQS SSLUKZISXLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		protected IHSGGRZWIQF UVDGVEBTMWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		protected (bool isLodForced, int forcedLOD) KJDUSFFVQTE;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public virtual int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xABD680", Offset = "0xABBE80", VA = "0x180ABD680", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD25E60", Offset = "0xD24660", VA = "0x180D25E60", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool SBKDAPQIZBK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x806A0E0", Offset = "0x80688E0", VA = "0x18806A0E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public virtual bool LOWOSAUNCAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static bool XKGJSJHWGZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x806A0A0", Offset = "0x80688A0", VA = "0x18806A0A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public FDAAWKBDLQS ZRBXMJPGBSS
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xA9E130", Offset = "0xA9C930", VA = "0x180A9E130")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x806A190", Offset = "0x8068990", VA = "0x18806A190")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected IHSGGRZWIQF SICITPCZOTX
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xAA32E0", Offset = "0xAA1AE0", VA = "0x180AA32E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x8069C00", Offset = "0x8068400", VA = "0x188069C00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int QBFRAUZFZDD
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x806A490", Offset = "0x8068C90", VA = "0x18806A490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AvatarBodyType ROWPTLUQSTN
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x806A050", Offset = "0x8068850", VA = "0x18806A050")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public virtual event Action ZOZRRISAHCW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x8069FB0", Offset = "0x80687B0", VA = "0x188069FB0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x806A0F0", Offset = "0x80688F0", VA = "0x18806A0F0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x8069C90", Offset = "0x8068490", VA = "0x188069C90", Slot = "8")]
		public virtual (bool, bool, bool) WhichLodsAreResident()
		{
			return default((bool, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "9")]
		public virtual void CheckMeshesAgainstDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x8069A30", Offset = "0x8068230", VA = "0x188069A30", Slot = "10")]
		public virtual (int, long, int) GetDisplayedLodInfo()
		{
			return default((int, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0xDDE2E0", Offset = "0xDDCAE0", VA = "0x180DDE2E0")]
		protected void WLDYFRKVMJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x8069A90", Offset = "0x8068290", VA = "0x188069A90")]
		protected void MMVMVWLXACP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1305230", Offset = "0x1303A30", VA = "0x181305230")]
		protected void AMLGLTAJNDJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x8069910", Offset = "0x8068110", VA = "0x188069910", Slot = "12")]
		public virtual Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x80699C0", Offset = "0x80681C0", VA = "0x1880699C0")]
		protected void GWOLOQEBCOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x8069B50", Offset = "0x8068350", VA = "0x188069B50", Slot = "13")]
		protected virtual void NNHGREWKAWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x8069AA0", Offset = "0x80682A0", VA = "0x188069AA0")]
		public int MeshesAtLODCount(int LOD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x8069EB0", Offset = "0x80686B0", VA = "0x188069EB0")]
		public AvatarDisplayBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarDisplaySystem : FDAAWKBDLQS
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class COOZCTXJEWE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public AvatarDisplaySystem VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public Color GKLAHHFUBLT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Color? TMIGDCFLZTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public float? IXAXQHZSVPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public Action<CICQGWOTETU> VRRWHNGOOMF;

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public COOZCTXJEWE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x808BFD0", Offset = "0x808A7D0", VA = "0x18808BFD0")]
			internal void FYTRJZFTLHW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x808C120", Offset = "0x808A920", VA = "0x18808C120")]
			internal void FYYYHFZQUTF(CICQGWOTETU a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class BXAPWFAQUBV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public bool AJUBLEAUPYC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public bool UBNVNHWPOUR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public AvatarDisplaySystem VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public IHSGGRZWIQF KRYMYZLDLCR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public Action<KeyValuePair<string, TNVOTOCMHUP<Texture2D>>> ZXIQVBDBDRW;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public BXAPWFAQUBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x80893E0", Offset = "0x8087BE0", VA = "0x1880893E0")]
			internal bool XFZZFBHJXPZ(DZJZUXSMRLS a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x8089160", Offset = "0x8087960", VA = "0x188089160")]
			internal bool BEGTPPSIUGN(DZJZUXSMRLS a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x8089140", Offset = "0x8087940", VA = "0x188089140")]
			internal void XHFOOPWUCGB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x8089250", Offset = "0x8087A50", VA = "0x188089250")]
			internal void XHKVLWQRLRK(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x8089140", Offset = "0x8087940", VA = "0x188089140")]
			internal void BDQYXVKQRYM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x8089250", Offset = "0x8087A50", VA = "0x188089250")]
			internal void BFBVEQTYFZX(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x8089220", Offset = "0x8087A20", VA = "0x188089220")]
			internal void BEWOHKAAWOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x80891F0", Offset = "0x80879F0", VA = "0x1880891F0")]
			internal void BERHKDGDNDF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x8089270", Offset = "0x8087A70", VA = "0x188089270")]
			internal void BFWWTRVNRTH(Dictionary<string, TNVOTOCMHUP<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x8089320", Offset = "0x8087B20", VA = "0x188089320")]
			internal void IEXYOIALJYW(KeyValuePair<string, TNVOTOCMHUP<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0")]
			internal DNXWICJZUNF BFRPWLBQIHY()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class BWVIYYGTKQM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public int RENPZDMNBPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public BXAPWFAQUBV MNSDRRJEMWM;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public BWVIYYGTKQM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x80890E0", Offset = "0x80878E0", VA = "0x1880890E0")]
			internal Layers XHQCJDKOVCT(int a)
			{
				return default(Layers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class BXLDQSOLMYN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public PVOPFDWRLHK<Dictionary<string, TNVOTOCMHUP<Texture2D>>> JKZHRLTAHSE;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public BXLDQSOLMYN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			internal PVOPFDWRLHK<Dictionary<string, TNVOTOCMHUP<Texture2D>>> BEMAMWMGDRW()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class BLVYFERPJXG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public AvatarDisplaySystem VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public float ZAHITTMJUHW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public Color QUVGLXTQQBI;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public BLVYFERPJXG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x80890A0", Offset = "0x80878A0", VA = "0x1880890A0")]
			internal void HOMFVZSDSEM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class PDQLYVSWNTX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public List<IHSGGRZWIQF> KPGHXXYXEBJ;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public PDQLYVSWNTX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x8091D60", Offset = "0x8090560", VA = "0x188091D60")]
			internal void QFWAPOWHEHV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class IOGDOXXVJEU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public string BIWCCEYYUTR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AvatarBodyPart KMQFTBGSMSK;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public IOGDOXXVJEU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x808DCF0", Offset = "0x808C4F0", VA = "0x18808DCF0")]
			internal bool JJVHLYZEWXM(KeyValuePair<string, DZJZUXSMRLS> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class XMGNVDOHJZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public List<BRTZTUAOXLG> MPOUHMAJVUW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public List<BRTZTUAOXLG> XTSQHJTUXNZ;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public XMGNVDOHJZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x8093EB0", Offset = "0x80926B0", VA = "0x188093EB0")]
			internal DNXWICJZUNF VDWRUBUKPAS(HMAQRAUSQTD a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class XMBGXWUKAOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public DKIBBYYTMUS JOHNMWEAZOV;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public XMBGXWUKAOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xB82450", Offset = "0xB80C50", VA = "0x180B82450")]
			internal void VDMDZOGPWEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xB82430", Offset = "0xB80C30", VA = "0x180B82430")]
			internal void VDRKWVANFPJ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class KGVLLPNPACW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public DKIBBYYTMUS JOHNMWEAZOV;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KGVLLPNPACW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xB82450", Offset = "0xB80C50", VA = "0x180B82450")]
			internal void VDMDZOGPWEA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xB82430", Offset = "0xB80C30", VA = "0x180B82430")]
			internal void VDRKWVANFPJ(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class ZDSZPQQFFBB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public long BANNASUAREF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public Stopwatch CTBRCSQGXUG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public SkinnedMeshRenderer URWSYDWLJZX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public long DRINNPZTRMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public string FGIRRROLISJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public long BZULDPEKOVO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public AvatarDisplaySystem VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public int RKOBHVMXKVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public List<Material> JWSWBDISYOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public List<(int mat, int part)> SZDWYLONCQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public List<Bounds> HUNESCMBHKX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public int RFVULPPPVXS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public long JIRRRZIJGUG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public long FTSXKSXEZDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public long UDNSPOWAXRL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public Action OFPBNUQGXFD;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ZDSZPQQFFBB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class ZDNSSJWHVPS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public bool ZJAYWLSHJWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public JobHandle AYSIZRYAZUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AvatarCullAndCombineMeshJobContainer JDNPPOHLYBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AvatarCullAndCombineMeshJobGroup HOFFZVRJEVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public ZDSZPQQFFBB MNSDRRJEMWM;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ZDNSSJWHVPS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x8093F30", Offset = "0x8092730", VA = "0x188093F30")]
			internal void MMQYEVOSKZJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x807F9B0", Offset = "0x807E1B0", VA = "0x18807F9B0")]
			internal void MMLRHOUVBOA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class ZEDNKEDZXXT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public bool ZJAYWLSHJWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public JobHandle AYSIZRYAZUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public AvatarLegacyCullAndCombineMeshJobContainer JDBTOPLJUOD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public AvatarLegacyCullAndCombineMeshJobGroup KNXWYYKMFEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public ZDSZPQQFFBB MOHYJLQWPEN;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ZEDNKEDZXXT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x80944F0", Offset = "0x8092CF0", VA = "0x1880944F0")]
			internal void MNBLZJCNDWB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x807FC60", Offset = "0x807E460", VA = "0x18807FC60")]
			internal void MMWFCCIPUKS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class BBIHVCZSIJH : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public bool TBSWLSCTQKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public AvatarDisplaySystem VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public List<HMAQRAUSQTD> ROUJWUGXNUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public List<IHSGGRZWIQF> KPGHXXYXEBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int[] FZFSFECZDTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public bool EXOVHYBDVRI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public Func<int, Layers> UOBBNLTSFCW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public CICQGWOTETU XQDHZIHNMAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public Material SLFMAFHCSUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private int WJCGQMISPIT;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public BBIHVCZSIJH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x8088700", Offset = "0x8086F00", VA = "0x188088700", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x8088990", Offset = "0x8087190", VA = "0x188088990", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly Log IUBZTJNGVTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly MWKYWAOJZRV SMXAOCCIOLX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly MWKYWAOJZRV YADQBRRBUKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Dictionary<BodyProperty, float> CTCQFEDRATJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Dictionary<FaceProperty, float> ZPVBRFPTKWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<NoseProperty, float> VDJKQRDKHXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IReadOnlyDictionary<string, BoneLocalInfo> WMQEYVDPLFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private Dictionary<string, BoneLocalInfo> YSDCQLTJMTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Dictionary<string, BoneLocalInfo> IXFODSHSAAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Dictionary<string, BoneLocalInfo> RMHQKVZDYFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private AvatarBuildType TTVTNZMZXUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private AvatarBuildType SUTMSESCVLS;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static float AYFQVISNDKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private AvatarConfiguration ZBNSFPQBEZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private Transform BURFEPUFKIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private AvatarSkinAssetItem JQZPMDWMQSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private AssetReference HBZVNYZPBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private AssetReference WWBGBUBOSUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private AssetReference MWPVICUISDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private AssetReference QHTMAQKMFMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private GameObject UUOQLMWJYYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private GameObject RFCZDIZXCUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private GameObject GKGGYSUYHPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private SkinnedMeshRenderer KXTYOFGDSUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private AvatarSkinnedMeshBoneOrderRemapsData BNPQJRPPSKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private Transform[] IBKEYCNJNXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Matrix4x4[] ACOWMNOVMDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private Material VHQTINLLKYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Material LTUIIVPXMUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Texture2D ECHXUQYUUUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Material VFSEFYTJQAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Material ZVTSCXKCAIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Material VASLHNUKNMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Shader KTIWPARWWQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Shader LMDCKLWOBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Animator JCGUFMNMOLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Renderer[] OMDGZRBRGOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private ZOFPULOBJQZ.SkinCullingMask JJNUPWIDOVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private AvatarBodyPartShapesManager SZIVHMOSPAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private IReadOnlyDictionary<string, Transform> XGTTCUBMFOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private bool TVKRGGBHDZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private bool GYAHQJYFTXL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Color MHLFHLIJRQM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Color? BHKGUZGNCJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Texture2D DDVEHHKJAIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float? DAZPAVWZRTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private Color PGZZVVDSDBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Color RJJMPIRHFPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Color? DIXLANMAVST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Color? PJEFRJVDYLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Color? PLFJRADYZAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Color? JJTUIWLIWFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Texture2D CITSPCXYZFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Texture2D QSQTAAFGOGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[CanBeNull]
		private DZJZUXSMRLS IFJKMNCKROW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Texture PUPMETJGHUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Color BBVSPMCPLJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Dictionary<Renderer, CICQGWOTETU> YMWQFBDBXLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Dictionary<Renderer, CICQGWOTETU> NAQZLZSEJMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Dictionary<string, List<AvatarMaterialKey>> OZIAULOZKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private Dictionary<string, List<AvatarMaterialKey>> FMSRCASSPYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly List<BRTZTUAOXLG> MPOUHMAJVUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly List<BRTZTUAOXLG> HSSIKVJEJRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly List<BRTZTUAOXLG> XTSQHJTUXNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly List<BRTZTUAOXLG> COYNQCTNLBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Dictionary<AvatarMaterialKey, Material> CJQULSQOVWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Dictionary<AvatarMaterialKey, Material> KNZOSUTNAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private SkinnedMeshRenderer[] IMTTCWDCHJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private SkinnedMeshRenderer[] HDILEJUGWVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private SkinnedMeshRenderer[] IQTYHEZCAMW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private SkinnedMeshRenderer[] EPQXYEQMRJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly Dictionary<string, TNVOTOCMHUP<Texture2D>> ELDNIFLUXMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly Dictionary<string, TNVOTOCMHUP<Texture2D>> JHTOMOADSQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private AdditionalHatData DGTSBHBTOKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private AdditionalHatData XHJLJWCAXUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private RecRoom.Avatars.Data.Shared.HairData PGXRPMXWQXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private RecRoom.Avatars.Data.Shared.HairData MYQPGRXQAMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private SSHQATTNPKI JOBCJCMUMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private bool? BKSMEXGMILA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private PositionAndRotation TLFARDSXFCW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Transform HODRITJXNVQ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Material LAHSUQLVUUZ;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Material KSSETOVGUHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private Dictionary<string, DZJZUXSMRLS> HZVFOJFHBGY;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly int WULIGLIDONJ;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly int TKFLWHJUMTT;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly int IMZLCOXQQLP;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly int VRAJLBCKMJA;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly int DLPEDEOYJCC;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly int JBRFAHPVOYZ;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly int BFISWMQMYSE;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int SEGHMWQPSJM;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int GBSEONWLIFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private bool XVWXKFHVDGY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F9")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private bool UIYAVNZBQFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private List<Action> PPXKCOZIFAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private VPCNPKAGHQN JJLCXJCJCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private SkinnedMeshRenderer[] QECZTUDNMBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int IIDJDNGXTZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool UJMAIZJWOGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int ZBVKWOGOMHL;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MWKYWAOJZRV DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public MWKYWAOJZRV DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xA9E170", Offset = "0xA9C970", VA = "0x180A9E170", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool RKNOEOJENFU
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x8070FB0", Offset = "0x806F7B0", VA = "0x188070FB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x806F470", Offset = "0x806DC70", VA = "0x18806F470")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private Material QFYVQCEYBKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x8072620", Offset = "0x8070E20", VA = "0x188072620")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private Material URCGAVLYOKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x806FDB0", Offset = "0x806E5B0", VA = "0x18806FDB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool KCQGYWXGZIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x8078720", Offset = "0x8076F20", VA = "0x188078720", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(AvatarBodyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x80788A0", Offset = "0x80770A0", VA = "0x1880788A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xC98320", Offset = "0xC96B20", VA = "0x180C98320", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x220E420", Offset = "0x220CC20", VA = "0x18220E420", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xC982A0", Offset = "0xC96AA0", VA = "0x180C982A0", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x8078730", Offset = "0x8076F30", VA = "0x188078730", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ZOFPULOBJQZ.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xBED0A0", Offset = "0xBEB8A0", VA = "0x180BED0A0", Slot = "22")]
			get
			{
				return default(ZOFPULOBJQZ.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int PLKZORKOSVO
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x8070FC0", Offset = "0x806F7C0", VA = "0x188070FC0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x806D570", Offset = "0x806BD70", VA = "0x18806D570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool CPLWMYQSVQE
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x80714B0", Offset = "0x806FCB0", VA = "0x1880714B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private static bool GABPGEWLOHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x806CDC0", Offset = "0x806B5C0", VA = "0x18806CDC0", Slot = "17")]
		public IHSGGRZWIQF BuildPotatoAvatar(GXUGUISWSPC avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x806CD90", Offset = "0x806B590", VA = "0x18806CD90", Slot = "16")]
		public IHSGGRZWIQF BuildAvatarMeshes(GXUGUISWSPC avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, DZJZUXSMRLS>, (IHSGGRZWIQF, PVOPFDWRLHK<Dictionary<string, TNVOTOCMHUP<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x806A630", Offset = "0x8068E30", VA = "0x18806A630")]
		public IHSGGRZWIQF AQLJKXVIFXK(GXUGUISWSPC a, bool b, int[] c, bool d, AvatarBuildType e, [Optional] Func<Dictionary<string, DZJZUXSMRLS>, (IHSGGRZWIQF, PVOPFDWRLHK<Dictionary<string, TNVOTOCMHUP<Texture2D>>>)> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8071550", Offset = "0x806FD50", VA = "0x188071550")]
		public static void PUOQDPPSZCF(Log a, string b, AssetReference c, AssetReference[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x8077660", Offset = "0x8075E60", VA = "0x188077660")]
		private bool YWLHQRWQASB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8076930", Offset = "0x8075130", VA = "0x188076930")]
		private IHSGGRZWIQF WQZRFNZNVAR(bool a, List<HMAQRAUSQTD> b, int[] c, Func<int, Layers> d, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x806CDF0", Offset = "0x806B5F0", VA = "0x18806CDF0")]
		[IteratorStateMachine(typeof(BBIHVCZSIJH))]
		private IEnumerator<YTAMKWOJLST> CDAXIBLKIDT(bool a, List<HMAQRAUSQTD> b, int[] c, Func<int, Layers> d, CICQGWOTETU e, Material f, List<IHSGGRZWIQF> g, bool h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x806F480", Offset = "0x806DC80", VA = "0x18806F480")]
		public static void LXENZYXJMGY(List<HMAQRAUSQTD> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x8072C00", Offset = "0x8071400", VA = "0x188072C00")]
		public static IHSGGRZWIQF SRRNEUMJGSO(List<HMAQRAUSQTD> a, List<BRTZTUAOXLG> b, List<BRTZTUAOXLG> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x80729E0", Offset = "0x80711E0", VA = "0x1880729E0")]
		public IHSGGRZWIQF SRRNEUMJGSO(List<HMAQRAUSQTD> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x80756D0", Offset = "0x8073ED0", VA = "0x1880756D0")]
		private XEXLSJPFYXK WQGGVIMKFLP(List<HMAQRAUSQTD> a, int b, bool c, Layers d, bool e, CICQGWOTETU f, Material g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8072FB0", Offset = "0x80717B0", VA = "0x188072FB0", Slot = "27")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x80734E0", Offset = "0x8071CE0", VA = "0x1880734E0", Slot = "29")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x8073670", Offset = "0x8071E70", VA = "0x188073670", Slot = "30")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x806C9D0", Offset = "0x806B1D0", VA = "0x18806C9D0", Slot = "28")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x806CA30", Offset = "0x806B230", VA = "0x18806CA30", Slot = "31")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x806CAF0", Offset = "0x806B2F0", VA = "0x18806CAF0", Slot = "32")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8073C60", Offset = "0x8072460", VA = "0x188073C60")]
		private void TWCQRYMVEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x806D4F0", Offset = "0x806BCF0", VA = "0x18806D4F0")]
		private void EJNHIVJELHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x806EEF0", Offset = "0x806D6F0", VA = "0x18806EEF0")]
		private void JXEKLCZQJAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x8074370", Offset = "0x8072B70", VA = "0x188074370", Slot = "40")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x80752D0", Offset = "0x8073AD0", VA = "0x1880752D0", Slot = "41")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x80734D0", Offset = "0x8071CD0", VA = "0x1880734D0", Slot = "33")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x806FB10", Offset = "0x806E310", VA = "0x18806FB10")]
		private void MCXVEZRDFKK(SkinnedMeshRenderer a, int b, Mesh c, List<Material> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x80722A0", Offset = "0x8070AA0", VA = "0x1880722A0")]
		public static Material RORKQQQQQAT(Dictionary<AvatarMaterialKey, Material> a, Material b, UpdatableColorType c, UpdatableTextureType d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x8072E90", Offset = "0x8071690", VA = "0x188072E90")]
		public static UpdatableColorType STKQOAHTRZW(HMAQRAUSQTD a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x806FE90", Offset = "0x806E690", VA = "0x18806FE90")]
		private void MKRRLLRBZUJ(int a, Material b, HMAQRAUSQTD c, [Out] Texture2D d, [Out] Vector4 e, [Out] Texture2D f, [Out] Texture2D g, [Out] Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x806E030", Offset = "0x806C830", VA = "0x18806E030")]
		private void IATLTZWYOSN(int a, Material b, HMAQRAUSQTD c, [Out] Color d, [Out] Color e, [Out] Color f, [Out] Color g, [Out] Color h, [Out] Color i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x806D280", Offset = "0x806BA80", VA = "0x18806D280")]
		private bool CFFVKVBOJXA(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x8077470", Offset = "0x8075C70", VA = "0x188077470")]
		private static Material YTAVLBGQLXK(int a, PDGVJWHLMJX b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x806D8E0", Offset = "0x806C0E0", VA = "0x18806D8E0")]
		public static UpdatableTextureType GROGPQVZIGE(HMAQRAUSQTD a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x8077730", Offset = "0x8075F30", VA = "0x188077730")]
		private static void YYESCZDDIYH(Dictionary<string, List<AvatarMaterialKey>> a, HMAQRAUSQTD b, Material c, UpdatableColorType d, UpdatableTextureType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x80779E0", Offset = "0x80761E0", VA = "0x1880779E0")]
		public static SkinnedMeshRenderer ZFXZSIGEGZX(Transform a, Transform b, SkinnedMeshRenderer[] c, int d, Layers e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x8077E40", Offset = "0x8076640", VA = "0x188077E40")]
		public AvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x806EAD0", Offset = "0x806D2D0", VA = "0x18806EAD0")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x806F020", Offset = "0x806D820", VA = "0x18806F020")]
		public void LIRQLNOTZSE([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x806D570", Offset = "0x806BD70", VA = "0x18806D570", Slot = "6")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x8073860", Offset = "0x8072060", VA = "0x188073860", Slot = "12")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
		public static bool RUNSVVBHFWD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x806CB50", Offset = "0x806B350", VA = "0x18806CB50", Slot = "13")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x80730A0", Offset = "0x80718A0", VA = "0x1880730A0", Slot = "10")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x8073760", Offset = "0x8071F60", VA = "0x188073760", Slot = "11")]
		public void SetSkinColors(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x806D800", Offset = "0x806C000", VA = "0x18806D800")]
		private void GFIPEYGRTYL(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x8073A40", Offset = "0x8072240", VA = "0x188073A40", Slot = "7")]
		public void SetUgcItemVisualOverrides(DZJZUXSMRLS overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x806F470", Offset = "0x806DC70", VA = "0x18806F470", Slot = "8")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x220E440", Offset = "0x220CC40", VA = "0x18220E440", Slot = "9")]
		public void SetUgcTextureParameters(VPCNPKAGHQN parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x8073CE0", Offset = "0x80724E0", VA = "0x188073CE0", Slot = "18")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x806CA90", Offset = "0x806B290", VA = "0x18806CA90", Slot = "34")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x80735D0", Offset = "0x8071DD0", VA = "0x1880735D0", Slot = "35")]
		public void SetHatAnchorParams(SSHQATTNPKI anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x80744B0", Offset = "0x8072CB0", VA = "0x1880744B0", Slot = "36")]
		public void UpdateHatPivot([Optional] SSHQATTNPKI anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x8077200", Offset = "0x8075A00", VA = "0x188077200")]
		private bool YETQSNMDCHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x8072F90", Offset = "0x8071790", VA = "0x188072F90", Slot = "23")]
		public bool SetBaseSkinCullingMask(ZOFPULOBJQZ.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8074260", Offset = "0x8072A60", VA = "0x188074260", Slot = "38")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x806CF00", Offset = "0x806B700", VA = "0x18806CF00")]
		public void CDHPMIGNFNP(float a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x8073AB0", Offset = "0x80722B0", VA = "0x188073AB0")]
		private static bool TBGWZJQOPGW(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8075320", Offset = "0x8073B20", VA = "0x188075320", Slot = "39")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties materialProperties, TextureEffectMaterialTextures materialTextures)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x80773D0", Offset = "0x8075BD0", VA = "0x1880773D0")]
		private static bool YISHUGFNARA(AvatarMaterialKey a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x80727C0", Offset = "0x8070FC0", VA = "0x1880727C0")]
		public void SNHOKWDKNXT(TextureEffectMaterialProperties a, TextureEffectMaterialTextures b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x806DF00", Offset = "0x806C700", VA = "0x18806DF00", Slot = "37")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x80740A0", Offset = "0x80728A0", VA = "0x1880740A0")]
		private void UVUGTAAYDLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x806FAC0", Offset = "0x806E2C0", VA = "0x18806FAC0")]
		private void LZWRFXZBNBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x339D2C0", Offset = "0x339BAC0", VA = "0x18339D2C0")]
		public static void QZCJICTASBL<a>(Dictionary<a, Material> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x8076E90", Offset = "0x8075690", VA = "0x188076E90")]
		private static void WULGXZWCMLR(Dictionary<Renderer, CICQGWOTETU> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x806FC60", Offset = "0x806E460", VA = "0x18806FC60")]
		public static void MEGWUWNRWCU(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x8077160", Offset = "0x8075960", VA = "0x188077160")]
		public static void YELGJYBDORB(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8073ED0", Offset = "0x80726D0", VA = "0x188073ED0")]
		public static void UBPYIWSOPRD(List<BRTZTUAOXLG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x806A4B0", Offset = "0x8068CB0", VA = "0x18806A4B0")]
		private void AGEPXLNBKGC(Dictionary<string, TNVOTOCMHUP<Texture2D>> a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x806DEB0", Offset = "0x806C6B0", VA = "0x18806DEB0")]
		private void HZFOZKZKXVV(Dictionary<string, List<AvatarMaterialKey>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x806E5D0", Offset = "0x806CDD0", VA = "0x18806E5D0")]
		private void IKCYRVZFMHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x80704D0", Offset = "0x806ECD0", VA = "0x1880704D0")]
		private void NNHGREWKAWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x8070660", Offset = "0x806EE60", VA = "0x188070660")]
		private void NRJFPEQIJFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x8072560", Offset = "0x8070D60", VA = "0x188072560")]
		private void RSXHKRDMIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x8077340", Offset = "0x8075B40", VA = "0x188077340")]
		private void YIJTVJRWFEJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x8070E60", Offset = "0x806F660", VA = "0x188070E60")]
		private void OAKDKCORHUG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x806E550", Offset = "0x806CD50", VA = "0x18806E550")]
		private void IHRLSEQJSXV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x806CCC0", Offset = "0x806B4C0", VA = "0x18806CCC0")]
		private void BMKOVSZXCSB(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x80773F0", Offset = "0x8075BF0", VA = "0x1880773F0")]
		private void YLVJDDXDGJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x8073B90", Offset = "0x8072390", VA = "0x188073B90")]
		private void THVFEZGOMYJ(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x80753B0", Offset = "0x8073BB0", VA = "0x1880753B0")]
		private void VIQDVASZOVG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x8070FD0", Offset = "0x806F7D0", VA = "0x188070FD0")]
		private void OOWYPVRUMUO(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x806D690", Offset = "0x806BE90", VA = "0x18806D690")]
		private void GECYRTLAPPQ(Material a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x806D9C0", Offset = "0x806C1C0", VA = "0x18806D9C0")]
		private void HGZBTIUOCYS(Material a, Color b, Texture2D c, Color? d, float? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8070C20", Offset = "0x806F420", VA = "0x188070C20")]
		private void NXTRISKBQZF(Material a, Color b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x80702D0", Offset = "0x806EAD0", VA = "0x1880702D0")]
		private void NIXCTWHXTNY(Material a, Texture2D b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8077500", Offset = "0x8075D00", VA = "0x188077500")]
		private void YWKJTBSCTTG(Material a, Texture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8072400", Offset = "0x8070C00", VA = "0x188072400")]
		private void RSNOGUVYXPM(Action<CICQGWOTETU> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8076FE0", Offset = "0x80757E0", VA = "0x188076FE0")]
		private void XZEUAWQKOOQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8071A70", Offset = "0x8070270", VA = "0x188071A70")]
		private void PWBKLTXMDTI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x806F0A0", Offset = "0x806D8A0", VA = "0x18806F0A0")]
		private void LPLJCTZNGDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x8071EF0", Offset = "0x80706F0", VA = "0x188071EF0")]
		public void RDBSBAPWEYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x806D4E0", Offset = "0x806BCE0", VA = "0x18806D4E0", Slot = "4")]
		private void DFEMIIHEHUZ([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x806F020", Offset = "0x806D820", VA = "0x18806F020", Slot = "5")]
		private void KDKZBWGGDRC([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x806D650", Offset = "0x806BE50", VA = "0x18806D650")]
		[CompilerGenerated]
		private DNXWICJZUNF GADDFWRMQNA(HMAQRAUSQTD a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x806E8B0", Offset = "0x806D0B0", VA = "0x18806E8B0")]
		[CompilerGenerated]
		private void ITBTQGTXYQB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x806E950", Offset = "0x806D150", VA = "0x18806E950")]
		[CompilerGenerated]
		private void ITMHKUHSRMT(CICQGWOTETU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x806E830", Offset = "0x806D030", VA = "0x18806E830")]
		[CompilerGenerated]
		private void ISWMTAAAPES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x806E930", Offset = "0x806D130", VA = "0x18806E930")]
		[CompilerGenerated]
		private void ITHANNNVIBK(CICQGWOTETU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x806E7B0", Offset = "0x806CFB0", VA = "0x18806E7B0")]
		[CompilerGenerated]
		private void ISRFVTGDFTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x806EAA0", Offset = "0x806D2A0", VA = "0x18806EAA0")]
		[CompilerGenerated]
		private void IURWUIXCWCV(CICQGWOTETU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x806E730", Offset = "0x806CF30", VA = "0x18806E730")]
		[CompilerGenerated]
		private void ISLYYMMFWIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x806EA70", Offset = "0x806D270", VA = "0x18806EA70")]
		[CompilerGenerated]
		private void IUMPXCDFMRM(CICQGWOTETU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x806E9F0", Offset = "0x806D1F0", VA = "0x18806E9F0")]
		[CompilerGenerated]
		private void ITWVFHVNKJL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x8071E90", Offset = "0x8070690", VA = "0x188071E90")]
		[CompilerGenerated]
		private void QEDSPJHYKIK(CICQGWOTETU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x806E970", Offset = "0x806D170", VA = "0x18806E970")]
		[CompilerGenerated]
		private void ITROIBBQAYC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x8071EC0", Offset = "0x80706C0", VA = "0x188071EC0")]
		[CompilerGenerated]
		private void QEIZMQBVTTT(CICQGWOTETU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x806EF70", Offset = "0x806D770", VA = "0x18806EF70")]
		[CompilerGenerated]
		private void KBVWHBVIHXH(KeyValuePair<string, TNVOTOCMHUP<Texture2D>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x806C910", Offset = "0x806B110", VA = "0x18806C910")]
		[CompilerGenerated]
		private void AVGTOFMMTES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x806EFF0", Offset = "0x806D7F0", VA = "0x18806EFF0")]
		[CompilerGenerated]
		private void KCKBGNCAVHP(CICQGWOTETU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x806D590", Offset = "0x806BD90", VA = "0x18806D590")]
		[CompilerGenerated]
		private void FKKSCATPNHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x806E520", Offset = "0x806CD20", VA = "0x18806E520")]
		[CompilerGenerated]
		private void IGLCLYSDPGX(CICQGWOTETU a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, GXRHCUSEJGW
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
		private Vector3? SGMSLVILWGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool GCAKEDEDFUR;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x80801B0", Offset = "0x807E9B0", VA = "0x1880801B0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x80807D0", Offset = "0x807EFD0", VA = "0x1880807D0", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB203F0", Offset = "0xB1EBF0", VA = "0x180B203F0", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x8080290", Offset = "0x807EA90", VA = "0x188080290")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x8080BF0", Offset = "0x807F3F0", VA = "0x188080BF0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, GXRHCUSEJGW
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private const float FYVBXVGDVXT = 45f;

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
		private Vector3 FGBRKDEFYGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private Vector3 YJTDBQRMQTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool GCAKEDEDFUR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private float LFGDXKCDDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private float TYUXWPJDOHQ;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8080F70", Offset = "0x807F770", VA = "0x188080F70", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xCDFB20", Offset = "0xCDE320", VA = "0x180CDFB20", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x8080C90", Offset = "0x807F490", VA = "0x188080C90")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8081A30", Offset = "0x8080230", VA = "0x188081A30")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class LDDAUTHBROC : YRJXBVVDOHH, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private static readonly int KDEZHBRUTZI;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private static readonly int BNIZEVEQSTB;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly int FYFXZRBKBPS;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly int WDIYJECQSSE;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private static readonly int DZLAGVVXZLO;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly int DKBUISFWUVI;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private static readonly int OLBNRHOQSFC;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private static readonly int XJQIQFOSDWW;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private static readonly int SPQXMVMQQOU;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly int MPOJOCNCCHF;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly int WFOFMATKPAN;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static readonly int FCNBKCZXVAZ;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static readonly int AJUMORGMNKH;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static readonly int WJNVFOJKHVF;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static readonly int DQGMNZQLPZF;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static readonly int UVYDZCHLRVP;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private static readonly int KCOZOBSOPPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private Transform ALPPWLXMBEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private Transform MLVURGYKZIY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private Transform YZXFKMFLPQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private Transform TSYYKZWCHEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Transform HUYMBZSIGYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private Transform RHJRGEFLYFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private AvatarFaceDisplayInitState ZJWVMFMIVLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private Material HLKUNRNNDHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private SkinnedMeshRenderer[] CYYJLLOOWHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private readonly List<Material> GZGTZAZCYXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private CKBEUXGGNTF OLWCIJXKCHG;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public MWKYWAOJZRV KGIXMVKFIFP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private CKBEUXGGNTF KRRZDWFMRYJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x808E320", Offset = "0x808CB20", VA = "0x18808E320")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool BXPTSGXIQZR
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x808F7E0", Offset = "0x808DFE0", VA = "0x18808F7E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x808E7A0", Offset = "0x808CFA0", VA = "0x18808E7A0")]
		public void Initialize([In] AvatarFaceDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x808E850", Offset = "0x808D050", VA = "0x18808E850")]
		public void XBYYWYINSWZ([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x808FCF0", Offset = "0x808E4F0", VA = "0x18808FCF0", Slot = "6")]
		public void SLOKFBZSYFI(AvatarFaceDisplayUpdateFeatureSelectionState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x808E3B0", Offset = "0x808CBB0", VA = "0x18808E3B0")]
		private Vector2 DZPLXTKNWKK(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x808E8F0", Offset = "0x808D0F0", VA = "0x18808E8F0")]
		public void OIJEQTTETPK([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x808F930", Offset = "0x808E130", VA = "0x18808F930")]
		private void RATPEOCXQGD(FaceFeaturesInUVSpace a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x808E490", Offset = "0x808CC90", VA = "0x18808E490")]
		private void IWOFBKCRRJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x808E410", Offset = "0x808CC10", VA = "0x18808E410")]
		private void IGMYSACDAXF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x808E410", Offset = "0x808CC10", VA = "0x18808E410", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x8090600", Offset = "0x808EE00", VA = "0x188090600")]
		public LDDAUTHBROC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x808E850", Offset = "0x808D050", VA = "0x18808E850", Slot = "5")]
		private void KLYAEFAJLKC([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x808E3A0", Offset = "0x808CBA0", VA = "0x18808E3A0", Slot = "7")]
		private void AURQWLLCBFT([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x808E480", Offset = "0x808CC80", VA = "0x18808E480")]
		[CompilerGenerated]
		internal static float FHBNDOYDITW(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x8090200", Offset = "0x808EA00", VA = "0x188090200")]
		[CompilerGenerated]
		internal static void TELMMIZMRDH(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x80902F0", Offset = "0x808EAF0", VA = "0x1880902F0")]
		[CompilerGenerated]
		internal static Vector4 YMVHCIKXNTE(Vector2 a, Vector2 b)
		{
			return default(Vector4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class AvatarForearmRollController : MonoBehaviour, GXRHCUSEJGW
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
		private float LFGDXKCDDLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private bool GCAKEDEDFUR;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x8081A60", Offset = "0x8080260", VA = "0x188081A60", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xAA7DD0", Offset = "0xAA65D0", VA = "0x180AA7DD0", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x80822C0", Offset = "0x8080AC0", VA = "0x1880822C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
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
		private Dictionary<int, int> VXPTNMJXHNF;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x80822F0", Offset = "0x8080AF0", VA = "0x1880822F0")]
		public void BDNHZJHRRDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x8082400", Offset = "0x8080C00", VA = "0x188082400")]
		public int BGLLNEJBSML(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public AvatarHandDisplaySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class WPILVJNIXJQ : FFLWCNYNDHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x80936C0", Offset = "0x8091EC0", VA = "0x1880936C0", Slot = "24")]
		public override float RTOMBPBDFZC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8093710", Offset = "0x8091F10", VA = "0x188093710")]
		public WPILVJNIXJQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class FFLWCNYNDHP : ODVOAWIYQTP
	{
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static int CIXPBSPSFEU;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static int OEZHFAHYQBA;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static int ZLEPWGWOPAQ;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static int MZUDZHZJIRB;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static int QXMXVKLPIGF;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static int NMQPRPKCWXK;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static int FWCEMCGPMVI;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static int[] OENTLVVVWAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private AvatarHandDisplayInitState ZJWVMFMIVLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private AvatarHandDisplaySetupState DMUECITOJDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private int HQHMCGAUFTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private float PASUNFVLHPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		protected Animator JCGUFMNMOLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		protected AvatarConfiguration SHIMCNARYTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		protected int PCWRYCBHARZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private int YYNMPVBXMGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private int BNTVDQTNVVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private bool TNOULKVHADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private HandAnimationOverrideState VTJYRYTHNBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private int QOVCDQWWSWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private float ANTCMXXGBNQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private AvatarHandDisplaySettings CLJTIYSRFPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private AvatarBodyType MZXGPCFTIQA;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Transform GUDPCVFUCBS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xAA1620", Offset = "0xA9FE20", VA = "0x180AA1620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector3 RJBZPLWQNJS
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x16E8C00", Offset = "0x16E7400", VA = "0x1816E8C00")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x16E8C60", Offset = "0x16E7460", VA = "0x1816E8C60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Quaternion WTJICUFOCNJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xBBE9C0", Offset = "0xBBD1C0", VA = "0x180BBE9C0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xBBE840", Offset = "0xBBD040", VA = "0x180BBE840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool MWVUOTSUCYT
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x808CAC0", Offset = "0x808B2C0", VA = "0x18808CAC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x808CA80", Offset = "0x808B280", VA = "0x18808CA80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool QLAGHALKKPQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xAB1020", Offset = "0xAAF820", VA = "0x180AB1020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 OCAKHHOSGBZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x122DAE0", Offset = "0x122C2E0", VA = "0x18122DAE0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x122A3F0", Offset = "0x1228BF0", VA = "0x18122A3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Quaternion EXSWOXPJWJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xFECD20", Offset = "0xFEB520", VA = "0x180FECD20", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x808C6E0", Offset = "0x808AEE0", VA = "0x18808C6E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HandVisualState VKMEXYALKDI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xDF55E0", Offset = "0xDF3DE0", VA = "0x180DF55E0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xDF61F0", Offset = "0xDF49F0", VA = "0x180DF61F0", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public HandVisualState WJWOBNIROWR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x10012B0", Offset = "0xFFFAB0", VA = "0x1810012B0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x1E89E60", Offset = "0x1E88660", VA = "0x181E89E60", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float SVFASFNPRGB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x12874B0", Offset = "0x1285CB0", VA = "0x1812874B0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0xDF5580", Offset = "0xDF3D80", VA = "0x180DF5580", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool KSLXFWGMIND
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x2248420", Offset = "0x2246C20", VA = "0x182248420", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x2248470", Offset = "0x2246C70", VA = "0x182248470", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool ILXKSTQGGAR
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x808C6D0", Offset = "0x808AED0", VA = "0x18808C6D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool XXOEIBKLFUO
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x808C440", Offset = "0x808AC40", VA = "0x18808C440")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool ZANGSZANTVZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x808CAB0", Offset = "0x808B2B0", VA = "0x18808CAB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool PRUJRZYNSOL
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x808C3E0", Offset = "0x808ABE0", VA = "0x18808C3E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x808C4A0", Offset = "0x808ACA0", VA = "0x18808C4A0", Slot = "23")]
		public void Initialize(AvatarHandDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x808C3F0", Offset = "0x808ABF0", VA = "0x18808C3F0")]
		public void HUTPVRMKOAE(AvatarHandDisplaySetupState a, AvatarHandDisplaySettings b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x808C640", Offset = "0x808AE40", VA = "0x18808C640", Slot = "14")]
		public void JOSZPDDLJSV(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x808C6F0", Offset = "0x808AEF0", VA = "0x18808C6F0", Slot = "13")]
		public void OJINHIPLZLV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x12874B0", Offset = "0x1285CB0", VA = "0x1812874B0", Slot = "24")]
		public virtual float RTOMBPBDFZC()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x808CB00", Offset = "0x808B300", VA = "0x18808CB00")]
		private int WALSHXRXKVD(HandVisualState a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x808C220", Offset = "0x808AA20", VA = "0x18808C220")]
		private void DWUUOYVONWJ(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x808C200", Offset = "0x808AA00", VA = "0x18808C200", Slot = "15")]
		public bool BCZMJWOIBRL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x808CAF0", Offset = "0x808B2F0", VA = "0x18808CAF0", Slot = "16")]
		public bool SVPADQYOWWH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x808CC90", Offset = "0x808B490", VA = "0x18808CC90")]
		private HandVisualState ZUJYEDVMNHY()
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1544DA0", Offset = "0x15435A0", VA = "0x181544DA0", Slot = "17")]
		public void CNNFYCSICHK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x808C1C0", Offset = "0x808A9C0", VA = "0x18808C1C0", Slot = "12")]
		public void AZZFGCXMGNH(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x808CA60", Offset = "0x808B260", VA = "0x18808CA60", Slot = "10")]
		public void QQRVENWAESD(HandAnimationOverrideState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x808CC80", Offset = "0x808B480", VA = "0x18808CC80", Slot = "11")]
		public void ZOPCFXZWRPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x808C450", Offset = "0x808AC50", VA = "0x18808C450", Slot = "18")]
		public void IGOCADZVJCZ(Transform a, Vector3 b, Quaternion c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x808CF70", Offset = "0x808B770", VA = "0x18808CF70")]
		public FFLWCNYNDHP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class PDGVJWHLMJX : HMAQRAUSQTD
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class XHDCJOGKBMU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public PDGVJWHLMJX VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public List<BRTZTUAOXLG> ZRYZQGTGNZK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public List<BRTZTUAOXLG> WECACINQTGN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public TNVOTOCMHUP<Material[]> FKPXXFNJGSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public TNVOTOCMHUP<LoadedAvatarItemPrefabHolder> HYSYZVLDTKT;

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public XHDCJOGKBMU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x80938B0", Offset = "0x80920B0", VA = "0x1880938B0")]
			internal DNXWICJZUNF EUMGCVEWOOY(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public DZJZUXSMRLS DZJZUXSMRLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public LoadedAvatarItemPrefabHolder WWKTHZEYVFW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private TNVOTOCMHUP<LoadedAvatarItemPrefabHolder> QDSEYISBEOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private TNVOTOCMHUP<Material[]> FKPXXFNJGSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Material[] KSVKBFIHJWE;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool CQXNSUFTZTW
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xACC8C0", Offset = "0xACB0C0", VA = "0x180ACC8C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xACC8D0", Offset = "0xACB0D0", VA = "0x180ACC8D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ZOFPULOBJQZ.SkinCullingMask NTGQEXHPRYX
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xAA8580", Offset = "0xAA6D80", VA = "0x180AA8580")]
			[CompilerGenerated]
			get
			{
				return default(ZOFPULOBJQZ.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xCFAAC0", Offset = "0xCF92C0", VA = "0x180CFAAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x8091CF0", Offset = "0x80904F0", VA = "0x188091CF0")]
		public PDGVJWHLMJX(ItemDefinitionBodyPart a, DZJZUXSMRLS b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8090F40", Offset = "0x808F740", VA = "0x188090F40", Slot = "6")]
		public override DNXWICJZUNF MBYCOVUECYJ(List<BRTZTUAOXLG> a, List<BRTZTUAOXLG> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x80908C0", Offset = "0x808F0C0", VA = "0x1880908C0")]
		public DNXWICJZUNF AJCVNSWLQAA(List<BRTZTUAOXLG> a, List<BRTZTUAOXLG> b, TNVOTOCMHUP<Material[]> c, [Optional] TNVOTOCMHUP<LoadedAvatarItemPrefabHolder> d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x80918F0", Offset = "0x80900F0", VA = "0x1880918F0")]
		public (TNVOTOCMHUP<Material[]>, TNVOTOCMHUP<LoadedAvatarItemPrefabHolder>) UBDQZUECPWM(List<BRTZTUAOXLG> a, List<BRTZTUAOXLG> b)
		{
			return default((TNVOTOCMHUP<Material[]>, TNVOTOCMHUP<LoadedAvatarItemPrefabHolder>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x80913E0", Offset = "0x808FBE0", VA = "0x1880913E0", Slot = "7")]
		public override HONFXOMRDRL QFWDADPYCBW(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x80916A0", Offset = "0x808FEA0", VA = "0x1880916A0")]
		public HONFXOMRDRL TKYYOGCRMJF(GameObject a, uint b, bool c, bool d, AvatarSkinnedMeshBoneOrderRemapsData e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x8090BC0", Offset = "0x808F3C0", VA = "0x188090BC0")]
		public static bool CPMYIFIEKPE(Renderer[] a, string b, [Out] Renderer c, [Out] Renderer d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x80918A0", Offset = "0x80900A0", VA = "0x1880918A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x80915E0", Offset = "0x808FDE0", VA = "0x1880915E0")]
		private (TNVOTOCMHUP<LoadedAvatarItemPrefabHolder>, TNVOTOCMHUP<Material[]>) RJVDLBGVSGA()
		{
			return default((TNVOTOCMHUP<LoadedAvatarItemPrefabHolder>, TNVOTOCMHUP<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x8090F20", Offset = "0x808F720", VA = "0x188090F20")]
		[CompilerGenerated]
		private void KFOJDXLITTG(LoadedAvatarItemPrefabHolder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xA9E420", Offset = "0xA9CC20", VA = "0x180A9E420")]
		[CompilerGenerated]
		private void KFTQBEFGDEP(Material[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class AvatarKneeBendTargetController : MonoBehaviour, GXRHCUSEJGW
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
		private Vector3 FGBRKDEFYGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private Vector3 JIIXYAGSVOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private Vector3 PPROOGGXEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private Matrix4x4 HKNDCYIPBNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private bool GCAKEDEDFUR;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x80828D0", Offset = "0x80810D0", VA = "0x1880828D0", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x80828C0", Offset = "0x80810C0", VA = "0x1880828C0", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x8082470", Offset = "0x8080C70", VA = "0x188082470")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x8082F90", Offset = "0x8081790", VA = "0x188082F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8085EF0", Offset = "0x80846F0", VA = "0x188085EF0", Slot = "4")]
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
		public int HYCUGVMNLHX
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x8083040", Offset = "0x8081840", VA = "0x188083040")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x8083540", Offset = "0x8081D40", VA = "0x188083540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public int MNRKLQHREOP
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x80832F0", Offset = "0x8081AF0", VA = "0x1880832F0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x80834A0", Offset = "0x8081CA0", VA = "0x1880834A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int UFZYWISAMMV
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x8083030", Offset = "0x8081830", VA = "0x188083030")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x8083200", Offset = "0x8081A00", VA = "0x188083200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x80839E0", Offset = "0x80821E0", VA = "0x1880839E0")]
		public AvatarLegacyCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8083560", Offset = "0x8081D60", VA = "0x188083560")]
		public void RVCNJFCHYXX(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x8083300", Offset = "0x8081B00", VA = "0x188083300")]
		public void JJEXDQVFGDX(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x8083520", Offset = "0x8081D20", VA = "0x188083520")]
		public Color OVCMFBNQHBY(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x80834B0", Offset = "0x8081CB0", VA = "0x1880834B0")]
		public void NFHMXQPJQMC(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x80834D0", Offset = "0x8081CD0", VA = "0x1880834D0")]
		public void NUMRZRBPODG(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x8083550", Offset = "0x8081D50", VA = "0x188083550")]
		public void RCJRACGMPWX(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x8083210", Offset = "0x8081A10", VA = "0x188083210")]
		public bool FUVMCALNIQE(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8083920", Offset = "0x8082120", VA = "0x188083920")]
		public void VLLAKFCYDVC(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x8083240", Offset = "0x8081A40", VA = "0x188083240")]
		public int[] GHPLNMEMUIM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x8082FA0", Offset = "0x80817A0", VA = "0x188082FA0")]
		private NativeSlice<int> AEFSQJBYUKD(int a)
		{
			return default(NativeSlice<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8083050", Offset = "0x8081850", VA = "0x188083050", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x80835D0", Offset = "0x8081DD0", VA = "0x1880835D0")]
		public Mesh TCQTLQJVNYL([Optional] string a)
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
		public int QESGTWEFGIT
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xC9D230", Offset = "0xC9BA30", VA = "0x180C9D230")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int VAHFNNLPTNF
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xCA9660", Offset = "0xCA7E60", VA = "0x180CA9660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int LMJNSRRWMLG
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x80840F0", Offset = "0x80828F0", VA = "0x1880840F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int LINGYLJSLHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x8084130", Offset = "0x8082930", VA = "0x188084130")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x8084140", Offset = "0x8082940", VA = "0x188084140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public int HYCUGVMNLHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x8083E40", Offset = "0x8082640", VA = "0x188083E40")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x8084150", Offset = "0x8082950", VA = "0x188084150")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int CVMEOTKLULK
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x8084120", Offset = "0x8082920", VA = "0x188084120")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x80840E0", Offset = "0x80828E0", VA = "0x1880840E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public MeshMergeModes GNRPHDVBUNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x8084160", Offset = "0x8082960", VA = "0x188084160")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x8084170", Offset = "0x8082970", VA = "0x188084170")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public byte HPFGGCPDRAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x80840D0", Offset = "0x80828D0", VA = "0x1880840D0")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x8083E50", Offset = "0x8082650", VA = "0x188083E50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public AvatarLegacyCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x80859C0", Offset = "0x80841C0", VA = "0x1880859C0")]
			get
			{
				return default(AvatarLegacyCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8084250", Offset = "0x8082A50", VA = "0x188084250")]
		public AvatarLegacyCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x8084180", Offset = "0x8082980", VA = "0x188084180")]
		public AvatarLegacyCullAndCombineMeshJobContainer XQIBLGXQDLR(Allocator a)
		{
			return default(AvatarLegacyCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8083E60", Offset = "0x8082660", VA = "0x188083E60", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[Tested]
	public class MUYIFPXOMFB : QMDFTXJWWJP
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x80907D0", Offset = "0x808EFD0", VA = "0x1880907D0")]
		public AvatarLegacyCullAndCombineMeshJobGroup XADGQOHYFUR()
		{
			return default(AvatarLegacyCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8080100", Offset = "0x807E900", VA = "0x188080100")]
		public MUYIFPXOMFB()
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
		[Cpp2IlInjected.Address(RVA = "0x80873A0", Offset = "0x8085BA0", VA = "0x1880873A0")]
		public AvatarMaterialKey(Material material, UpdatableColorType updatableColorType, UpdatableTextureType updatableTextureType, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8087100", Offset = "0x8085900", VA = "0x188087100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x8086E70", Offset = "0x8085670", VA = "0x188086E70", Slot = "4")]
		public bool Equals(AvatarMaterialKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x8086F00", Offset = "0x8085700", VA = "0x188086F00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x8087000", Offset = "0x8085800", VA = "0x188087000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, FFOXVJRCTHT
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
		private FDAAWKBDLQS ZVFKFEOJFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private YRJXBVVDOHH OAUJSAATIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private ODVOAWIYQTP OGTNHRUJYLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private ODVOAWIYQTP YYHDTRBISFA;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public FDAAWKBDLQS WDBNZYCCZEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x80885A0", Offset = "0x8086DA0", VA = "0x1880885A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public YRJXBVVDOHH SAKJTZRMXAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x80885F0", Offset = "0x8086DF0", VA = "0x1880885F0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public ODVOAWIYQTP WMMRPMSGNNA
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x8088640", Offset = "0x8086E40", VA = "0x188088640", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public ODVOAWIYQTP YNMZOPBRLYB
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x8088690", Offset = "0x8086E90", VA = "0x188088690", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Transform XFYEFJNPMTN
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x80886E0", Offset = "0x8086EE0", VA = "0x1880886E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public AvatarBodyType SLBMMOGYYYO
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xACF250", Offset = "0xACDA50", VA = "0x180ACF250", Slot = "12")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x8087910", Offset = "0x8086110", VA = "0x188087910")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x80880C0", Offset = "0x80868C0", VA = "0x1880880C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x8088080", Offset = "0x8086880", VA = "0x188088080", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x80880C0", Offset = "0x80868C0", VA = "0x1880880C0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x8087950", Offset = "0x8086150", VA = "0x188087950", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x80884B0", Offset = "0x8086CB0", VA = "0x1880884B0")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x80883F0", Offset = "0x8086BF0", VA = "0x1880883F0")]
		private void RXYYQPFKVJV(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x80874E0", Offset = "0x8085CE0", VA = "0x1880874E0")]
		private FDAAWKBDLQS AFQOCBYYJRT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x8087D80", Offset = "0x8086580", VA = "0x188087D80")]
		private YRJXBVVDOHH ILHIVITLHZT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x8088170", Offset = "0x8086970", VA = "0x188088170")]
		private ODVOAWIYQTP RQELMSWQALD(HandType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8088590", Offset = "0x8086D90", VA = "0x188088590")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class CICQGWOTETU : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private MaterialPropertyBlock JDICSGUZVDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public Color? XCYCUUYXSMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public Color? DSGGXRRQBJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public Color? OHYUPFCNWAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Color? KPGHLQGKLUW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Color VFHFVPILOVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public Color TWPTVAEPXDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public Color YYTFPQASJJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public Color? JWRKNBGNWUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public Texture2D JGTCYUJZZCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public float? QJVXZBJJKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public float NVCFXVOHCNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public Texture2D HAEDRBPKNLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Texture2D VLPQYKFHISD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private Dictionary<AvatarMaterialKey, int> OLYYUSLPMNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private UpdatableColorType[] FDDMCPTIRVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private UpdatableTextureType[] YQXPMLBUQCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public Vector4[] WKOFHACCDDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Vector4[] QTARCMNXPSK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public Vector4[] XHHTZWLWQTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public Vector4[] XIMPVMYUDYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public Vector4[] OCNJHYZDFLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public Vector4[] SOGNJKJCTYM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private List<Texture2D> VCOLPDBVCGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private Vector4[] EFUHVGWSMOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private List<Texture2D> MBYLFDICCYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private float[] WHSELKLVAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private Vector4[] KVQFBIBYMON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private float[] VFKIYUKMVTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public float[] BLWCJFGNHWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private List<Texture2D> ZMDLKZBFDJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private float[] HOIDKTKWFTL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private List<Texture2D> UTUHAXPDLHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private Vector4[] AGGCMLNGRWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private float[] CPQCSHKJIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private Vector4[] WMLUWWJUFGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public float[] YHVCBHYGZLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public Texture2DArray GBNRYCTDBYT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public Texture2DArray KVELHOMVXPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public Texture2DArray KDSVSJQJCIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public Texture2DArray AYRZYXHMTFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private bool DMFONZYIYGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private int TRNRVQXECMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private Vector2? FUIPIJYQLPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private TextureFormat CRXQJKKVRYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private Vector2? RVCZDAOWNEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TextureFormat FGLENXFDZZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private Vector2? BTTCSHKHPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private TextureFormat SDKQKGDTCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private Vector2? WGECQCYYFJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private TextureFormat JRBCROQGYPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private bool IWZTIHAPXBS;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static int WEFNKVJCESO;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private static int VLJSGSQIKTQ;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private static int QVKANQGDTQC;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static int HQHQFVIACKL;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static int HXFCUCBWADY;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static int SFAEZSMJXAB;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private static int HVYMUJJELNC;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private static int LVSVTAHIWIN;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private static int CFRARLQJEIN;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private static int QPXMCPQIMVO;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private static int BMBRQUTRCJO;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private static int FJQEYFNBGTC;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private static int RBUEZNISJNK;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private static int JUCVKRLGAXC;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private static int CJTSBKRUSTL;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private static int HBQIZAFKXRF;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private static int OKPXYKZNIKF;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private static int IVTEXBXKXBG;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private static int AFDAHTBKRUO;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private static int EHTMRBWHLGP;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x808BA50", Offset = "0x808A250", VA = "0x18808BA50")]
		private CICQGWOTETU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x808BF10", Offset = "0x808A710", VA = "0x18808BF10")]
		public CICQGWOTETU(Color a, Color b, Color c, Color? d, Color? e, Color? f, Texture2D g, Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x80899F0", Offset = "0x80881F0", VA = "0x1880899F0")]
		internal int OZZTKHANFGY(Material a, UpdatableColorType b, UpdatableTextureType c, AvatarBodyPart d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x8089AC0", Offset = "0x80882C0", VA = "0x188089AC0")]
		private int OZZTKHANFGY(AvatarMaterialKey a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x8089B50", Offset = "0x8088350", VA = "0x188089B50")]
		internal int PUEULTXDUHR(Material a, Color b, Color c, Color d, Color e, Color f, Texture2D g, Vector4 h, Texture2D i, Vector4 j, float k, float l, Texture2D m, Vector4 n, float o, Texture2D p, Color q, Vector4 r, UpdatableColorType s, UpdatableTextureType t, AvatarBodyPart u)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x808B540", Offset = "0x8089D40", VA = "0x18808B540")]
		private void WMBZZGRLSGQ(List<Texture2D> a, [Out] Texture2DArray b, [Out] Texture2DArray c, [Out] Texture2DArray d, [Out] Texture2DArray e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x8089550", Offset = "0x8087D50", VA = "0x188089550")]
		public void GFWGQRDUOVF(Shader a, Renderer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x808A730", Offset = "0x8088F30", VA = "0x18808A730")]
		private void SKUWLDLBYCY(Shader a, Renderer b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x80897F0", Offset = "0x8087FF0", VA = "0x1880897F0")]
		private Color ORLXYGGRDZN(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x80896A0", Offset = "0x8087EA0", VA = "0x1880896A0")]
		private Color KVUTBSCVCPF(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x808B3E0", Offset = "0x8089BE0", VA = "0x18808B3E0")]
		private bool SWPVQPFKWUI(Texture2D a, UpdatableTextureType b, [Out] Texture2D c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x8089460", Offset = "0x8087C60", VA = "0x188089460")]
		private void BPDMCSKEAXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x8089510", Offset = "0x8087D10", VA = "0x188089510", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class HMAQRAUSQTD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public readonly ItemDefinitionBodyPart WTYYBECUAKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool NUMUCRXFTYM;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool UXMQDUKUHRX
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xAF3180", Offset = "0xAF1980", VA = "0x180AF3180")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xB39DA0", Offset = "0xB385A0", VA = "0x180B39DA0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool BLNGOMNHNID
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xB391B0", Offset = "0xB379B0", VA = "0x180B391B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xB391C0", Offset = "0xB379C0", VA = "0x180B391C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual ZOFPULOBJQZ.SkinCullingMask VSOSQWLEDJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ZOFPULOBJQZ.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xB447B0", Offset = "0xB42FB0", VA = "0x180B447B0", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool RFVJYCECVKZ
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xC9BBE0", Offset = "0xC9A3E0", VA = "0x180C9BBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool HZKTQFWTIQW
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x808D3D0", Offset = "0x808BBD0", VA = "0x18808D3D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool AUQANCRTHQD
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x808D450", Offset = "0x808BC50", VA = "0x18808D450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool HZMBRCNSDRS
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x808D2E0", Offset = "0x808BAE0", VA = "0x18808D2E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x808D4D0", Offset = "0x808BCD0", VA = "0x18808D4D0")]
		protected HMAQRAUSQTD(ItemDefinitionBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract DNXWICJZUNF MBYCOVUECYJ(List<BRTZTUAOXLG> a, List<BRTZTUAOXLG> b);

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract HONFXOMRDRL QFWDADPYCBW(uint a, AvatarSkinnedMeshBoneOrderRemapsData b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class VOUYXYEKINI : HVYZSAICTZJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private AvatarSkinAssetItem JQZPMDWMQSK;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x80935C0", Offset = "0x8091DC0", VA = "0x1880935C0")]
		public VOUYXYEKINI(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, ItemDefinitionBodyPart c, [Optional] FaceFeatureId? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x8093480", Offset = "0x8091C80", VA = "0x188093480")]
		public VOUYXYEKINI(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, AvatarBodyPart c, ZOFPULOBJQZ.SkinCullingMask d, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x8093220", Offset = "0x8091A20", VA = "0x188093220", Slot = "6")]
		public override DNXWICJZUNF MBYCOVUECYJ(List<BRTZTUAOXLG> a, List<BRTZTUAOXLG> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class TINWBTVLXTY
	{
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly int[] EWTAKDFPWTT;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly int[] CXILQWVCPIZ;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public static int[] HAWQJIUPBLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x8091FD0", Offset = "0x80907D0", VA = "0x188091FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x8091EA0", Offset = "0x80906A0", VA = "0x188091EA0")]
		public static int[] LCPLLVMCNBX(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x8091F40", Offset = "0x8090740", VA = "0x188091F40")]
		public static int QNLYOLJZFDI(UpdateLOD a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x8091E90", Offset = "0x8090690", VA = "0x188091E90")]
		private static int GZNEBKUQBHQ(UpdateLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8091F20", Offset = "0x8090720", VA = "0x188091F20")]
		private static int QKXOWCHIZZT(UpdateLOD a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class IQUKAPHLDOW
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class YNUHWYDQRNP : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public JobHandle UVUXKOWBHPL;

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public YNUHWYDQRNP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x12967A0", Offset = "0x1294FA0", VA = "0x1812967A0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x8093EF0", Offset = "0x80926F0", VA = "0x188093EF0", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public static void PNVVCBDJGJA(string a, int b, long c, long d, long e, long f, long g, long h, long i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x808DD90", Offset = "0x808C590", VA = "0x18808DD90")]
		public static XEXLSJPFYXK BIXEQVLUBJQ(JobHandle a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x808DED0", Offset = "0x808C6D0", VA = "0x18808DED0")]
		[IteratorStateMachine(typeof(YNUHWYDQRNP))]
		private static IEnumerator<YTAMKWOJLST> SXLSZHWHBHN(JobHandle a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class FJJICYERPYW
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
		public static readonly int AZJGMBFGMRK;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly int PZRHAOKXYUF;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly int UVUQEFLAVND;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly int DSXURLTZIKA;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly int KSMJUWAEUJH;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly int BBZRJGCQXMV;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly int XHZEASNQCHB;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly int QMCHNDKHYEG;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly int TQBXFKRIAUP;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly int LDCBVJHUUGI;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly int RVLPVLJUORM;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly int SEECOMAFVQH;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly int XVCJSSKMHKM;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x808CF90", Offset = "0x808B790", VA = "0x18808CF90")]
		public static bool QXFJQALWAQE(Material a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class HVYZSAICTZJ : HMAQRAUSQTD
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class XHDCJOGKBMU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public TNVOTOCMHUP<GameObject> LJBCHQTYTVC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public HVYZSAICTZJ VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Action<string> VRRWHNGOOMF;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public XHDCJOGKBMU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x8093AF0", Offset = "0x80922F0", VA = "0x188093AF0")]
			internal void EURNABYTYAH(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x8093770", Offset = "0x8091F70", VA = "0x188093770")]
			internal void EUMGCVEWOOY(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected AvatarSkinAssetItem MMKQWFIAKTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Material[] IASJDWVRRTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly AvatarSkinAssetItem.SkinBodyMeshType SEKXURMPZZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private readonly AssetReference HBZVNYZPBDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private readonly FaceFeatureId? FTONDPSSXKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private SkinnedMeshRenderer[] BQRBPYXZKYR;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override ZOFPULOBJQZ.SkinCullingMask VSOSQWLEDJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xAA1630", Offset = "0xA9FE30", VA = "0x180AA1630", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ZOFPULOBJQZ.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xAA7D90", Offset = "0xAA6590", VA = "0x180AA7D90", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x808DBC0", Offset = "0x808C3C0", VA = "0x18808DBC0")]
		public HVYZSAICTZJ(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, ItemDefinitionBodyPart d, ZOFPULOBJQZ.SkinCullingMask e = (ZOFPULOBJQZ.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x808DA60", Offset = "0x808C260", VA = "0x18808DA60")]
		public HVYZSAICTZJ(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, ZOFPULOBJQZ.SkinCullingMask d = (ZOFPULOBJQZ.SkinCullingMask)0L, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x808D9C0", Offset = "0x808C1C0", VA = "0x18808D9C0")]
		public HVYZSAICTZJ(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material[] c, ItemDefinitionBodyPart d, ZOFPULOBJQZ.SkinCullingMask e = (ZOFPULOBJQZ.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x808D500", Offset = "0x808BD00", VA = "0x18808D500", Slot = "6")]
		public override DNXWICJZUNF MBYCOVUECYJ(List<BRTZTUAOXLG> a, List<BRTZTUAOXLG> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x808D760", Offset = "0x808BF60", VA = "0x18808D760", Slot = "7")]
		public override HONFXOMRDRL QFWDADPYCBW(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x808D950", Offset = "0x808C150", VA = "0x18808D950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x808D710", Offset = "0x808BF10", VA = "0x18808D710")]
		protected void NKUDZBWRKDN()
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
		[Cpp2IlInjected.Address(RVA = "0x808D280", Offset = "0x808BA80", VA = "0x18808D280")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface MZVAGZVGOLT
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LZKGZEVKKNF(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, ZOFPULOBJQZ.SkinCullingMask e = (ZOFPULOBJQZ.SkinCullingMask)0L, int f = -1, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WPENSCRTCNV(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e);
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
		[Cpp2IlInjected.Address(RVA = "0xE12FC0", Offset = "0xE117C0", VA = "0x180E12FC0")]
		public LoadedAvatarItemPrefabHolder(GameObject outfitObject, AvatarItemMaterial avatarItemMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x8090740", Offset = "0x808EF40", VA = "0x188090740")]
		public void OLCYIWRNUEQ(Material a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class BBTTNUKQUGP : ATAJBJCUIIC<Task<(GameObject, AvatarItemMaterial)>, LoadedAvatarItemPrefabHolder>
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
			[Cpp2IlInjected.Address(RVA = "0x8092CB0", Offset = "0x80914B0", VA = "0x188092CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x80931B0", Offset = "0x80919B0", VA = "0x1880931B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private TNVOTOCMHUP<GameObject> QRZLVZFGSDQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private TNVOTOCMHUP<AvatarItemMaterial> ZWQOYGJSKWO;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x8089010", Offset = "0x8087810", VA = "0x188089010")]
		private BBTTNUKQUGP(Task<(GameObject, AvatarItemMaterial)> a, TNVOTOCMHUP<GameObject> b, TNVOTOCMHUP<AvatarItemMaterial> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x80889D0", Offset = "0x80871D0", VA = "0x1880889D0")]
		public static BBTTNUKQUGP Create(AssetReference outfitPrefabReference, [Optional] AssetReference combinationReference)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x8088DC0", Offset = "0x80875C0", VA = "0x188088DC0", Slot = "11")]
		protected override LoadedAvatarItemPrefabHolder JUWLZWAUYFT(Task<(GameObject, AvatarItemMaterial)> a)
		{
			return default(LoadedAvatarItemPrefabHolder);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x8088E60", Offset = "0x8087660", VA = "0x188088E60", Slot = "12")]
		protected override void PBTIRVZZULO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x8088EE0", Offset = "0x80876E0", VA = "0x188088EE0")]
		[AsyncStateMachine(typeof(<WhenAllAvatarComponents>d__6))]
		private static Task<(GameObject, AvatarItemMaterial)> ZONRAWCFVGH(Task<GameObject> a, Task<AvatarItemMaterial> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class JRJRWDQZFGE
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		private class HJXCWJYGKMO : ATAJBJCUIIC<Task<MaterialMapAsset>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			private TNVOTOCMHUP<MaterialMapAsset> UVUXKOWBHPL;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x8095D20", Offset = "0x8094520", VA = "0x188095D20")]
			public HJXCWJYGKMO(TNVOTOCMHUP<MaterialMapAsset> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x80958A0", Offset = "0x80940A0", VA = "0x1880958A0", Slot = "11")]
			protected override Material[] JUWLZWAUYFT(Task<MaterialMapAsset> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x8095CC0", Offset = "0x80944C0", VA = "0x188095CC0", Slot = "12")]
			protected override void PBTIRVZZULO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		private class OCXPTBGMXEO : ATAJBJCUIIC<Task<Material[]>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			private List<TNVOTOCMHUP<Material>> EJRIYCUKJWC;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x80965E0", Offset = "0x8094DE0", VA = "0x1880965E0")]
			public OCXPTBGMXEO(Task<Material[]> a, List<TNVOTOCMHUP<Material>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x8096450", Offset = "0x8094C50", VA = "0x188096450", Slot = "11")]
			protected override Material[] JUWLZWAUYFT(Task<Material[]> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x80964A0", Offset = "0x8094CA0", VA = "0x1880964A0", Slot = "12")]
			protected override void PBTIRVZZULO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x808DF30", Offset = "0x808C730", VA = "0x18808DF30")]
		public static TNVOTOCMHUP<Material[]> STVRZBYLCHP(AssetReference[] a)
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
			[Cpp2IlInjected.Token(Token = "0x4000392")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000393")]
			TeamItem,
			[Cpp2IlInjected.Token(Token = "0x4000394")]
			SkinColor,
			[Cpp2IlInjected.Token(Token = "0x4000395")]
			HairColor,
			[Cpp2IlInjected.Token(Token = "0x4000396")]
			BeardColor,
			[Cpp2IlInjected.Token(Token = "0x4000397")]
			UGCShirtColor
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public enum UpdatableTextureType
		{
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			None,
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			HairTexture,
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			BeardTexture,
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			UGCShirtTexture
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		protected class DBGDJAUHOIY : IComparable<DBGDJAUHOIY>, IEquatable<DBGDJAUHOIY>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public int UTVZAWBBXNW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public PlayerAvatarDisplayBase UKZMUZLAWHF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public IList<AvatarItemSelection> ZXGRTEKMLIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public AvatarItemBodyType KRBLTPLIIZP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public AvatarBuildType JSWHESNQQAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public bool HARYQSPJVKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x40003A3")]
			public bool ASJLBAPBAKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public int[] FZFSFECZDTN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public float LNOFDQHNALF;

			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x80955C0", Offset = "0x8093DC0", VA = "0x1880955C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000329")]
			[Cpp2IlInjected.Address(RVA = "0x8095470", Offset = "0x8093C70", VA = "0x188095470", Slot = "4")]
			public int CompareTo(DBGDJAUHOIY other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x80954A0", Offset = "0x8093CA0", VA = "0x1880954A0", Slot = "5")]
			public bool Equals(DBGDJAUHOIY other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600032B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public DBGDJAUHOIY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		protected abstract class HMAQRAUSQTD
		{
			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public virtual bool UXMQDUKUHRX
			{
				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		protected class SXQDHCFAWQH : HMAQRAUSQTD
		{
			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public MVIYUYYKFIE MYKWUVZYCYJ
			{
				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public class VLNRXYLOOHY
		{
			[Cpp2IlInjected.Token(Token = "0x200006A")]
			public enum HandVisualStatePriority
			{
				[Cpp2IlInjected.Token(Token = "0x40003B7")]
				PLAYER_PUPPET,
				[Cpp2IlInjected.Token(Token = "0x40003B8")]
				PLAYER_DISPLAY_POSER,
				[Cpp2IlInjected.Token(Token = "0x40003B9")]
				PLAYER_HAND,
				[Cpp2IlInjected.Token(Token = "0x40003BA")]
				STNMONSTERCOSTUME_OPTION_HIDE_EXCEPT_UI,
				[Cpp2IlInjected.Token(Token = "0x40003BB")]
				PLAYER_HAND_POINTING,
				[Cpp2IlInjected.Token(Token = "0x40003BC")]
				STNMONSTERCOSTUME_OPTION_ALWAYS_HIDE,
				[Cpp2IlInjected.Token(Token = "0x40003BD")]
				EDITOR
			}

			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			public static readonly int OFJCBKVGORK;

			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			public static readonly int ELKFYMROZNZ;

			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			public static readonly int SOCFYSTRIWE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected readonly HandType FMBURXGETDQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected readonly NQPRPAKLGMK VKYIJHKSHIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected readonly Animator QGUDKHEHPLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected readonly Transform JUNETPIJEUU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			public Vector3 PPKTWRNVRJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected readonly Transform TCGOQJPFRAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			public Vector3 LZPOUHMYGAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected bool LYCPXUFERJM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected ODVOAWIYQTP KPZTMMPSVEQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003B3")]
			protected bool PYMBDIBQAQP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003B4")]
			protected float TOOZYIVDLUJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003B5")]
			protected QRRCQEKUKQZ<HandVisualState> GUPLUCGBBHZ;

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public ODVOAWIYQTP LTNDAEPWBFL
			{
				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0xA9E400", Offset = "0xA9CC00", VA = "0x180A9E400")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0xA9E150", Offset = "0xA9C950", VA = "0x180A9E150")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool PCAAHGUAWVT
			{
				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0x1342630", Offset = "0x1340E30", VA = "0x181342630")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000331")]
				[Cpp2IlInjected.Address(RVA = "0x80ADE50", Offset = "0x80AC650", VA = "0x1880ADE50")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public bool BSSLFPIBTIC
			{
				[Cpp2IlInjected.Token(Token = "0x6000332")]
				[Cpp2IlInjected.Address(RVA = "0xAA7D60", Offset = "0xAA6560", VA = "0x180AA7D60")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000333")]
				[Cpp2IlInjected.Address(RVA = "0x80AE030", Offset = "0x80AC830", VA = "0x1880AE030")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public float ZTCGOIPYLWG
			{
				[Cpp2IlInjected.Token(Token = "0x6000334")]
				[Cpp2IlInjected.Address(RVA = "0xB39D90", Offset = "0xB38590", VA = "0x180B39D90")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000335")]
				[Cpp2IlInjected.Address(RVA = "0x80ADCE0", Offset = "0x80AC4E0", VA = "0x1880ADCE0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			public HandVisualState CQNZCQLTNGJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000336")]
				[Cpp2IlInjected.Address(RVA = "0x80ADBB0", Offset = "0x80AC3B0", VA = "0x1880ADBB0")]
				get
				{
					return default(HandVisualState);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x80AE100", Offset = "0x80AC900", VA = "0x1880AE100")]
			public bool UOGHRSPWGTH(HandVisualState a, object b, HandVisualStatePriority c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x80AE3C0", Offset = "0x80ACBC0", VA = "0x1880AE3C0")]
			public bool XYAHAQMBEWQ(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x80AEB80", Offset = "0x80AD380", VA = "0x1880AEB80")]
			protected VLNRXYLOOHY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x80AE620", Offset = "0x80ACE20", VA = "0x1880AE620")]
			public VLNRXYLOOHY(HandType a, ODVOAWIYQTP b, Animator c, Transform d, Transform e, Vector3 f, Vector3 g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x80AE310", Offset = "0x80ACB10", VA = "0x1880AE310")]
			private void XFXKGONLCQH(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x80ADBF0", Offset = "0x80AC3F0", VA = "0x1880ADBF0")]
			protected void DNNEKBITXPX(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x80AE4C0", Offset = "0x80ACCC0", VA = "0x1880AE4C0")]
			protected void ZHIHEVUTWFQ(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x80ADA90", Offset = "0x80AC290", VA = "0x1880ADA90")]
			protected void BIGBRKNCUWQ(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x80ADF20", Offset = "0x80AC720", VA = "0x1880ADF20")]
			protected void HJJARBVPHWH(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000340")]
			[Cpp2IlInjected.Address(RVA = "0x80AE210", Offset = "0x80ACA10", VA = "0x1880AE210")]
			protected void VGOGJHHGRWW(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000341")]
			[Cpp2IlInjected.Address(RVA = "0x80AE270", Offset = "0x80ACA70", VA = "0x1880AE270")]
			protected void VTZWQMDETHB(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000342")]
			[Cpp2IlInjected.Address(RVA = "0x80AE2C0", Offset = "0x80ACAC0", VA = "0x1880AE2C0")]
			protected void VUJCKOZGCEK(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000343")]
			[Cpp2IlInjected.Address(RVA = "0x80AD970", Offset = "0x80AC170", VA = "0x1880AD970")]
			protected void AWCADGNAFRI(ushort a, ushort b)
			{
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct PlayerHandBones
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003BE")]
			public Transform[] LeftHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003BF")]
			public Transform LeftHandRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C0")]
			public Transform[] RightHandBones;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C1")]
			public Transform RightHandRoot;
		}

		[Cpp2IlInjected.Token(Token = "0x200006D")]
		[CompilerGenerated]
		private sealed class TMJXQGPAXFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public PlayerAvatarDisplayBase MLFZDZFTBVV;

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public TMJXQGPAXFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x80AB340", Offset = "0x80A9B40", VA = "0x1880AB340")]
			internal bool FHMSBQGBFHC()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class CBPUNEFGCAQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C8")]
			public PlayerAvatarDisplayBase VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C9")]
			public AvatarItemBodyType ZWNJYBYOJSB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CA")]
			public Func<PVOPFDWRLHK<Dictionary<string, TNVOTOCMHUP<Texture2D>>>> VRCBPSYWMEE;

			[Cpp2IlInjected.Token(Token = "0x600034D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CBPUNEFGCAQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x8095210", Offset = "0x8093A10", VA = "0x188095210")]
			internal (IHSGGRZWIQF, PVOPFDWRLHK<Dictionary<string, TNVOTOCMHUP<Texture2D>>>) ZPUWYHBIDNJ(Dictionary<string, DZJZUXSMRLS> a)
			{
				return default((IHSGGRZWIQF, PVOPFDWRLHK<Dictionary<string, TNVOTOCMHUP<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0x8095400", Offset = "0x8093C00", VA = "0x188095400")]
			internal PVOPFDWRLHK<Dictionary<string, TNVOTOCMHUP<Texture2D>>> ZQFKSUPCWKB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0x8095130", Offset = "0x8093930", VA = "0x188095130")]
			internal void ZPPQBAHKUCA()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct <CompleteBuildAsync>d__227 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003CE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x80ABCD0", Offset = "0x80AA4D0", VA = "0x1880ABCD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000352")]
			[Cpp2IlInjected.Address(RVA = "0x80ABF30", Offset = "0x80AA730", VA = "0x1880ABF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class HOPIPNOTTAQ : IEnumerator<YTAMKWOJLST>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CF")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D0")]
			private YTAMKWOJLST YDRMGGSTAGM;

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private YTAMKWOJLST DOMZTRRLMSO
			{
				[Cpp2IlInjected.Token(Token = "0x6000356")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000358")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0xAAC620", Offset = "0xAAAE20", VA = "0x180AAC620")]
			[DebuggerHidden]
			public HOPIPNOTTAQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000354")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "5")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000355")]
			[Cpp2IlInjected.Address(RVA = "0x8095E00", Offset = "0x8094600", VA = "0x188095E00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x8096120", Offset = "0x8094920", VA = "0x188096120", Slot = "8")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct <SetFaceCustomizationSettings>d__134 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40003D1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D3")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			private bool <forceRebuild>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x80AC1A0", Offset = "0x80AA9A0", VA = "0x1880AC1A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0x80AC540", Offset = "0x80AAD40", VA = "0x1880AC540", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000072")]
		[CompilerGenerated]
		private sealed class AHZZMGSDEEU : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			private int ILQFHFJYACP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private SkinnedMeshRenderer YDRMGGSTAGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private int XJERYWNBAAG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			public PlayerAvatarDisplayBase VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private SkinnedMeshRenderer[] RECIBZUSAYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private int REHOZGOPKJY;

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			private SkinnedMeshRenderer DHVQRDIDGMP
			{
				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A0")]
			private object IDRIDRBRWXH
			{
				[Cpp2IlInjected.Token(Token = "0x6000360")]
				[Cpp2IlInjected.Address(RVA = "0xAA1610", Offset = "0xA9FE10", VA = "0x180AA1610", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0xD38BD0", Offset = "0xD373D0", VA = "0x180D38BD0")]
			[DebuggerHidden]
			public AHZZMGSDEEU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035C")]
			[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990", Slot = "7")]
			[DebuggerHidden]
			private void QBKHVLXPXWS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x80947C0", Offset = "0x8092FC0", VA = "0x1880947C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x8094A30", Offset = "0x8093230", VA = "0x188094A30", Slot = "10")]
			[DebuggerHidden]
			private void VXYFNEQVOKT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x8094990", Offset = "0x8093190", VA = "0x188094990", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<SkinnedMeshRenderer> UHDRSDLRSRS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x8094990", Offset = "0x8093190", VA = "0x188094990", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator WFEYQSZVQHA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected static List<PlayerAvatarDisplayBase> LMGUXAEWONK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected HelmetHairState IGJXKCHAJVR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected bool QQFBQNJCVOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected bool GXCATPYAEQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		protected static readonly int[] DGMXPHOYEKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private bool ACOTHJOTJFR;

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
		private ODVOAWIYQTP OGTNHRUJYLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private ODVOAWIYQTP YYHDTRBISFA;

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
		protected Collider[] ZKBODLBHDXW;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		protected Collider[] QVIPAOIKLLN;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		protected VLNRXYLOOHY[] FIATADFAKEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public bool meshDataStructUseSemioptimizedBoneWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		protected QRRCQEKUKQZ<NQPRPAKLGMK> GUPLUCGBBHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		protected readonly Dictionary<string, TNVOTOCMHUP<Texture2D>> DBMAPUSNBDT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x191")]
		[Cpp2IlInjected.Token(Token = "0x400036C")]
		protected bool RTKTYZNHPGL;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		protected static int XUMTBNHMDKX;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		protected static List<DBGDJAUHOIY> YUOOCTUKEDD;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		protected static List<DBGDJAUHOIY> FWMTSAUBPLG;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		protected static XEXLSJPFYXK EKLZWISSJNC;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		protected static Func<List<DBGDJAUHOIY>, DBGDJAUHOIY> WLLXGJPEPNJ;

		[Cpp2IlInjected.Token(Token = "0x4000373")]
		protected static bool YLGWPBSAHXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		protected Color? UCZXLTJIOWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		protected bool TZPRHHCARRY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		protected Color UOTFJNEFVZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		protected Color EJAMXXHEHWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		protected Color UPIIQBFOOTK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		protected AvatarHairPattern ZOFBRPPCWJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		protected MVIYUYYKFIE FHLFFXKOVUL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		protected Color TLLBTWZPDKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		protected Color OFJWHTCTLWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		protected AvatarHairPattern EVACZJSYPBT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		protected MVIYUYYKFIE MEJUCYMSXHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		protected MVIYUYYKFIE OIFOIIBUXTJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		protected Color WSCVEFPTYJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private AdditionalFeetData LRBFKQUHWMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		protected readonly IList<AvatarItemSelection> BKVFBXIADMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		protected readonly IList<AvatarItemSelection> NSKBYVCDAEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private AvatarItemBodyType CSMNLUUTCGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		[SerializeField]
		protected AvatarFaceShape _currentFaceShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		[SerializeField]
		protected AvatarBodyShape _currentBodyShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		[SerializeField]
		protected NoseType _currentNoseType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x275")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		protected bool GWEVBHJXOZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400038A")]
		protected int[] EDGZOLRNZJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		protected bool RJHAEDVCUDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x281")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		protected bool CBFJWJNUEQZ;

		[Cpp2IlInjected.Token(Token = "0x400038D")]
		private static readonly ZOFPULOBJQZ.SkinCullingMask OYMMYJFJEJN;

		[Cpp2IlInjected.Token(Token = "0x400038E")]
		private static readonly ZOFPULOBJQZ.SkinCullingMask AFENIOTSASI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x282")]
		[Cpp2IlInjected.Token(Token = "0x400038F")]
		protected bool CVIMMMJVMAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x4000390")]
		protected VPCNPKAGHQN JJLCXJCJCFN;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string ENVOSYWTGGX
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xBB29C0", Offset = "0xBB11C0", VA = "0x180BB29C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xBB1AB0", Offset = "0xBB02B0", VA = "0x180BB1AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool WWSKWNYHMYB
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool BELOVKJYJPD
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x809DF80", Offset = "0x809C780", VA = "0x18809DF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool IDGSUWZHLFZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool CDKMQVBZWGK
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool SZDZQYSODVA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xB385E0", Offset = "0xB36DE0", VA = "0x180B385E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x809E530", Offset = "0x809CD30", VA = "0x18809E530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public ODVOAWIYQTP WMMRPMSGNNA
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xC98310", Offset = "0xC96B10", VA = "0x180C98310")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x809E550", Offset = "0x809CD50", VA = "0x18809E550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public ODVOAWIYQTP YNMZOPBRLYB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xC98320", Offset = "0xC96B20", VA = "0x180C98320")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x809E7F0", Offset = "0x809CFF0", VA = "0x18809E7F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public PlayerFacialAnimatorBase IRUUMGYHGFN
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xB9D430", Offset = "0xB9BC30", VA = "0x180B9D430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public VLNRXYLOOHY[] CNDXPLJWITB
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x809DB10", Offset = "0x809C310", VA = "0x18809DB10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public VLNRXYLOOHY LIPYIIMBQQX
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x809DFF0", Offset = "0x809C7F0", VA = "0x18809DFF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VLNRXYLOOHY REXQNOOFZDQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x809E020", Offset = "0x809C820", VA = "0x18809E020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected bool KCQGYWXGZIX
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xABD680", Offset = "0xABBE80", VA = "0x180ABD680", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x809E760", Offset = "0x809CF60", VA = "0x18809E760", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected virtual bool TITDXXFAXKF
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected virtual int[] EPTGSRXCFDB
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x8097580", Offset = "0x8095D80", VA = "0x188097580", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected bool CPLWMYQSVQE
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x8099160", Offset = "0x8097960", VA = "0x188099160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		protected static bool GABPGEWLOHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public IEnumerable<SkinnedMeshRenderer> ESZEJROOJFG
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x809DA00", Offset = "0x809C200", VA = "0x18809DA00")]
			[IteratorStateMachine(typeof(AHZZMGSDEEU))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public bool BXPTSGXIQZR
		{
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x221A950", Offset = "0x2219150", VA = "0x18221A950")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0x221B540", Offset = "0x2219D40", VA = "0x18221B540")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public new static bool XKGJSJHWGZH
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x809DEB0", Offset = "0x809C6B0", VA = "0x18809DEB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected static XEXLSJPFYXK AWZIUDIMUCL
		{
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x8097C50", Offset = "0x8096450", VA = "0x188097C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002DA")]
			[Cpp2IlInjected.Address(RVA = "0x809D180", Offset = "0x809B980", VA = "0x18809D180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		protected Color OHYUPFCNWAO
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x809BF90", Offset = "0x809A790", VA = "0x18809BF90")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected Color KPGHLQGKLUW
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x80978F0", Offset = "0x80960F0", VA = "0x1880978F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		protected Texture2D IOKCFTEMQLA
		{
			[Cpp2IlInjected.Token(Token = "0x60002EA")]
			[Cpp2IlInjected.Address(RVA = "0x8097800", Offset = "0x8096000", VA = "0x188097800")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Color VFHFVPILOVI
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x809DAC0", Offset = "0x809C2C0", VA = "0x18809DAC0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		protected Color TWPTVAEPXDM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x8096FB0", Offset = "0x80957B0", VA = "0x188096FB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public MVIYUYYKFIE IOGYFGWCXFM
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x809DA80", Offset = "0x809C280", VA = "0x18809DA80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		protected Texture2D FNNHADZRKRQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002F3")]
			[Cpp2IlInjected.Address(RVA = "0x8097700", Offset = "0x8095F00", VA = "0x188097700")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public float JYJYXBWIQOH
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x809DAA0", Offset = "0x809C2A0", VA = "0x18809DAA0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public float ODNZLRXSQJO
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x809DF60", Offset = "0x809C760", VA = "0x18809DF60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		public bool OBLKFBWLMXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000320")]
			[Cpp2IlInjected.Address(RVA = "0x13BDF60", Offset = "0x13BC760", VA = "0x1813BDF60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000321")]
			[Cpp2IlInjected.Address(RVA = "0x809E320", Offset = "0x809CB20", VA = "0x18809E320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action YNZXKEGGUPH
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x809D730", Offset = "0x809BF30", VA = "0x18809D730")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x809E050", Offset = "0x809C850", VA = "0x18809E050")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action FSJSNKQHMDI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x809D7E0", Offset = "0x809BFE0", VA = "0x18809D7E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x809E100", Offset = "0x809C900", VA = "0x18809E100")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action GDRKINMNSMA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x809D890", Offset = "0x809C090", VA = "0x18809D890")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x809E1B0", Offset = "0x809C9B0", VA = "0x18809E1B0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HandType, HandVisualState> TPZJBSOPRUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x809D940", Offset = "0x809C140", VA = "0x18809D940")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x809E260", Offset = "0x809CA60", VA = "0x18809E260")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x809A5E0", Offset = "0x8098DE0", VA = "0x18809A5E0")]
		public bool SetDeformation(bool deformBody, bool deformHead)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x8096810", Offset = "0x8095010", VA = "0x188096810")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x8099330", Offset = "0x8097B30", VA = "0x188099330")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x8097CA0", Offset = "0x80964A0", VA = "0x188097CA0")]
		protected void MEGWUWNRWCU(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x809D0E0", Offset = "0x809B8E0", VA = "0x18809D0E0")]
		protected void YELGJYBDORB(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x809D010", Offset = "0x809B810", VA = "0x18809D010")]
		protected void YELGJYBDORB(MeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x8097450", Offset = "0x8095C50", VA = "0x188097450")]
		public float GetHandOpenClosedAxis(HandType handType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x809AC20", Offset = "0x8099420", VA = "0x18809AC20")]
		public void SetHandOpenClosedAxis(HandType handType, float openClosedAxis)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x8097490", Offset = "0x8095C90", VA = "0x188097490")]
		public HandVisualState GetHandVisualState(HandType handType)
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x8096660", Offset = "0x8094E60", VA = "0x188096660")]
		public bool AddHandVisualStateToken(HandType handType, HandVisualState handVisualState, object token, VLNRXYLOOHY.HandVisualStatePriority priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x809B940", Offset = "0x809A140", VA = "0x18809B940")]
		public void SetWatchHand(HandType handType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x809BA00", Offset = "0x809A200", VA = "0x18809BA00")]
		public void SetWatchHands(bool showLeftHand, bool showRightHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x8099CE0", Offset = "0x80984E0", VA = "0x188099CE0")]
		public bool RemoveHandVisualStateToken(HandType handType, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x8097540", Offset = "0x8095D40", VA = "0x188097540")]
		public bool GetThumbsUpActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x809B3E0", Offset = "0x8099BE0", VA = "0x18809B3E0")]
		public void SetThumbsUpActive(HandType handType, bool thumbsUpActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x8097500", Offset = "0x8095D00", VA = "0x188097500")]
		public bool GetHandshakeActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x809ADB0", Offset = "0x80995B0", VA = "0x18809ADB0")]
		public void SetHandshakeActive(HandType handType, bool handshakeActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x8097000", Offset = "0x8095800", VA = "0x188097000")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0x809B850", Offset = "0x809A050", VA = "0x18809B850")]
		public void SetUseClassicBeanHandScale(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x8096960", Offset = "0x8095160", VA = "0x188096960")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x8097FA0", Offset = "0x80967A0", VA = "0x188097FA0")]
		private static void NBPPKCADDIG(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x8096EB0", Offset = "0x80956B0", VA = "0x188096EB0")]
		protected static void FJDUFLNCYZE(PlayerAvatarDisplayBase a, List<DBGDJAUHOIY> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x8099B30", Offset = "0x8098330", VA = "0x188099B30")]
		public DNXWICJZUNF Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x809BD80", Offset = "0x809A580", VA = "0x18809BD80")]
		protected DNXWICJZUNF TGHTAGARYLE(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x809BC50", Offset = "0x809A450", VA = "0x18809BC50", Slot = "19")]
		protected virtual DNXWICJZUNF TGHTAGARYLE(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x809C910", Offset = "0x809B110", VA = "0x18809C910")]
		protected static DNXWICJZUNF XXMDRGLOUGZ(DBGDJAUHOIY a, List<DBGDJAUHOIY> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x8097F50", Offset = "0x8096750", VA = "0x188097F50")]
		[IteratorStateMachine(typeof(HOPIPNOTTAQ))]
		protected static IEnumerator<YTAMKWOJLST> MXXPUTHIZHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x809BEA0", Offset = "0x809A6A0", VA = "0x18809BEA0")]
		protected static DBGDJAUHOIY TWPFXTJTWTM(List<DBGDJAUHOIY> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x809A6B0", Offset = "0x8098EB0", VA = "0x18809A6B0")]
		[AsyncStateMachine(typeof(<SetFaceCustomizationSettings>d__134))]
		public Task SetFaceCustomizationSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x809BFE0", Offset = "0x809A7E0", VA = "0x18809BFE0")]
		public bool UpdateFaceAndBodyCustomizationSettings(AvatarData avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x8097610", Offset = "0x8095E10", VA = "0x188097610")]
		public void InitializeFaceFeatures(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(RVA = "0x809B1D0", Offset = "0x80999D0", VA = "0x18809B1D0")]
		public void SetTeamColors(Color? teamColor, bool teamOutfitColorEmissionEnabled, Color emissiveColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x809A2A0", Offset = "0x8098AA0", VA = "0x18809A2A0")]
		public void SetBeardPrimaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x809A440", Offset = "0x8098C40", VA = "0x18809A440")]
		public void SetBeardSecondaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x809A140", Offset = "0x8098940", VA = "0x18809A140")]
		public void SetBeardPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x809C710", Offset = "0x809AF10", VA = "0x18809C710")]
		private void VPWXGBXGUDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x8099EF0", Offset = "0x80986F0", VA = "0x188099EF0")]
		private bool SJLBVXXIQUG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x809A920", Offset = "0x8099120", VA = "0x18809A920")]
		public void SetHairPrimaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x809AAA0", Offset = "0x80992A0", VA = "0x18809AAA0")]
		public void SetHairSecondaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x809A7B0", Offset = "0x8098FB0", VA = "0x18809A7B0")]
		public void SetHairPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x8099C80", Offset = "0x8098480", VA = "0x188099C80")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x809BDE0", Offset = "0x809A5E0", VA = "0x18809BDE0")]
		private bool TSFXVQCRKYK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x809B0D0", Offset = "0x80998D0", VA = "0x18809B0D0")]
		public void SetSkinColor(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x809B4F0", Offset = "0x8099CF0", VA = "0x18809B4F0")]
		public void SetUgcItemVisualOverrides(AvatarItemSelection overrideItem, AvatarBodyType avatarBodyType, Texture textureOverride, Color colorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xE49900", Offset = "0xE48100", VA = "0x180E49900")]
		public void SetFaceShape(AvatarFaceShape faceShape, bool forceRebuild = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x809CF70", Offset = "0x809B770", VA = "0x18809CF70")]
		private void XZKZCJJBTKU(BodyProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x8099470", Offset = "0x8097C70", VA = "0x188099470")]
		private void QTZPCOBWLPH(BodyPropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x809BBB0", Offset = "0x809A3B0", VA = "0x18809BBB0")]
		private void TFVWSTPOJRD(FaceProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x8097BB0", Offset = "0x80963B0", VA = "0x188097BB0")]
		private void LCVAWEPQXJV(NoseProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x809C800", Offset = "0x809B000", VA = "0x18809C800")]
		private void XHSLXKBKHUM(FacePropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x8099200", Offset = "0x8097A00", VA = "0x188099200")]
		private void OYNUPHENGRY(NosePropertyData a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0xE54820", Offset = "0xE53020", VA = "0x180E54820")]
		public void SetBodyShape(AvatarBodyShape bodyShape, bool forceRebuild = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x809AFD0", Offset = "0x80997D0", VA = "0x18809AFD0")]
		public void SetNoseType(NoseType noseType, bool forceRebuild = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x809C6C0", Offset = "0x809AEC0", VA = "0x18809C6C0")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x809AFB0", Offset = "0x80997B0", VA = "0x18809AFB0")]
		public bool SetHideEars(bool hideEars)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x809AF90", Offset = "0x8099790", VA = "0x18809AF90")]
		public bool SetHelmetHair(HelmetHairState helmetHairState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x809AEC0", Offset = "0x80996C0", VA = "0x18809AEC0")]
		public void SetHatAnchorParameters(SSHQATTNPKI newAnchorParams, bool useParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x809B0B0", Offset = "0x80998B0", VA = "0x18809B0B0")]
		public bool SetShowModestyAndValidationGuidelines(bool showModestyAndValidationGuidelines)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x809BAD0", Offset = "0x809A2D0", VA = "0x18809BAD0")]
		public void SetupDisplayLODs(LODSelection lodSelection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x8097DC0", Offset = "0x80965C0", VA = "0x188097DC0")]
		protected int[] MXRIOPTPKYG(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x809B030", Offset = "0x8099830", VA = "0x18809B030")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x809AFE0", Offset = "0x80997E0", VA = "0x18809AFE0")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool isFirstPerson, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x809B070", Offset = "0x8099870", VA = "0x18809B070")]
		public DNXWICJZUNF SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, LODSelection lodSelection, bool isFirstPerson, bool usesBodyPaint, bool forceRebuild = false, bool shouldBuildPotatoAvatar = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x8096C00", Offset = "0x8095400", VA = "0x188096C00", Slot = "20")]
		protected virtual DNXWICJZUNF EADNMCHYFAJ(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, LODSelection e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x8096B00", Offset = "0x8095300", VA = "0x188096B00")]
		protected int[] DVZHIQZSKOD(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "21")]
		protected virtual IHSGGRZWIQF EJUBJJNGXME(AvatarItemBodyType a, Dictionary<string, DZJZUXSMRLS> b, Dictionary<string, TNVOTOCMHUP<Texture2D>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x8097940", Offset = "0x8096140", VA = "0x188097940", Slot = "22")]
		protected virtual void KHEKGFMVGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x8097050", Offset = "0x8095850", VA = "0x188097050", Slot = "23")]
		protected virtual DNXWICJZUNF GJFDODSWKHT(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, AvatarBuildType f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x8099620", Offset = "0x8097E20", VA = "0x188099620", Slot = "24")]
		protected virtual DZJZUXSMRLS QWNNSTLWORE(MVIYUYYKFIE a, AvatarItemBodyType b, AvatarBodyPart c, DZJZUXSMRLS d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0xA9F9A0", Offset = "0xA9E1A0", VA = "0x180A9F9A0", Slot = "25")]
		protected virtual DZJZUXSMRLS WWRMPSMIKGA(AvatarItemBodyType a, AvatarBodyPart b, WHSITFMKFBQ c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x809C780", Offset = "0x809AF80", VA = "0x18809C780")]
		protected void VUNEGJZFIHS(GXUGUISWSPC a, ZOFPULOBJQZ.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x8097B30", Offset = "0x8096330", VA = "0x188097B30")]
		protected void KZQVWDDYKDI(GXUGUISWSPC a, ZOFPULOBJQZ.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0xB00F50", Offset = "0xAFF750", VA = "0x180B00F50", Slot = "26")]
		protected virtual GXUGUISWSPC CRNVXQBTLLV(GXUGUISWSPC a, HelmetHairStyle b, bool c, AvatarItemBodyType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x80980D0", Offset = "0x80968D0", VA = "0x1880980D0")]
		protected GXUGUISWSPC OFKZGAJVENV(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x809BB00", Offset = "0x809A300", VA = "0x18809BB00")]
		protected ZOFPULOBJQZ.SkinCullingMask TCNZVWGBFFD(ZOFPULOBJQZ.SkinCullingMask a, AvatarBodyPart b)
		{
			return default(ZOFPULOBJQZ.SkinCullingMask);
		}

		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x8096A30", Offset = "0x8095230", VA = "0x188096A30", Slot = "12")]
		[AsyncStateMachine(typeof(<CompleteBuildAsync>d__227))]
		public override Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x8099FA0", Offset = "0x80987A0", VA = "0x188099FA0")]
		protected static UpdatableColorType STKQOAHTRZW(HMAQRAUSQTD a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x8097300", Offset = "0x8095B00", VA = "0x188097300")]
		protected static UpdatableTextureType GROGPQVZIGE(HMAQRAUSQTD a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x809BF30", Offset = "0x809A730", VA = "0x18809BF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x809B8E0", Offset = "0x809A0E0", VA = "0x18809B8E0")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x809B7A0", Offset = "0x8099FA0", VA = "0x18809B7A0")]
		public void SetUgcTextureParameters(VPCNPKAGHQN parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x809D580", Offset = "0x809BD80", VA = "0x18809D580")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x8096650", Offset = "0x8094E50", VA = "0x188096650")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task APRODGIGFSB()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, POKLIYYXBNR
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		[CompilerGenerated]
		private struct <BuildFaceFeatureStyle>d__171 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000449")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044A")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400044B")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400044C")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044D")]
			private TaskAwaiter<NEQJFGHULVB> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x80AB410", Offset = "0x80A9C10", VA = "0x1880AB410", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x80AB840", Offset = "0x80AA040", VA = "0x1880AB840", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400044E")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x80AB8A0", Offset = "0x80AA0A0", VA = "0x1880AB8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x80ABC70", Offset = "0x80AA470", VA = "0x1880ABC70", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x80ABF90", Offset = "0x80AA790", VA = "0x1880ABF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x80AC140", Offset = "0x80AA940", VA = "0x1880AC140", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x80AC5A0", Offset = "0x80AADA0", VA = "0x1880AC5A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x80AC810", Offset = "0x80AB010", VA = "0x1880AC810", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x80AC870", Offset = "0x80AB070", VA = "0x1880AC870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x80ACA50", Offset = "0x80AB250", VA = "0x1880ACA50", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x80ACAB0", Offset = "0x80AB2B0", VA = "0x1880ACAB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x80ACC50", Offset = "0x80AB450", VA = "0x1880ACC50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DD")]
		protected const float GAUEGIGYBWJ = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		protected const int GDAUOVEJOAP = 5;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		protected static readonly Dictionary<ERYHJVYWLIK.Emote, int> IDNULXAYJYA;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> WNSNXKMQLXH;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static Vector2 ECSKYGIEUJL;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected static Vector2 GDFNPJEVTUS;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 CQNLBUCKVKV;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 LFFKLMBISDD;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 PJCMUOAPQTE;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static Vector2 SYSFJUORSDD;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static Vector2 ESGQFFRVMWX;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static Vector2 SYMZXWLVYQI;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static Vector2 KDVFEUQYCJZ;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static Vector2 AKHJXGMDDNJ;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static Vector2 LSJSISFHZYA;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static Vector2 FMPMUXBXQNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040A")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040B")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		private AvatarBodyType NWEBAGTEQSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		private FaceStyleSet HSQZPSEJOCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000412")]
		protected const int PGIOGRJYIQM = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected int UVGMCGNHEWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected int OFMTKPNYOUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected int FKGNKDSBIRN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected int JWRUIAPOPZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected Vector2 OZBRDTZHLJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected float VCVOXZJONFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected float PHQPVBDONGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected float FTDTOQEQNMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected Vector2 UMQEBAICGWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected float QNMJAQLODUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected float MSUQWQCZEJT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected float LFFLOMOSFTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected Vector2 KOUGTAQNSBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected float MNZGXWGADTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected float MVHBYFJEWPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected float VIUCCBZDGHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected Vector2 VZKEFAWQAKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected float RZHQEOWTHRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected float ERRLMKBZLET;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected float HSXIKSHBAMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected List<SelectableFaceOption> NGMWNZXSWFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected List<SelectableFaceOption> VJNHYYMAKTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected List<SelectableFaceOption> WURDASAHSWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected List<SelectableFaceOption> RHHYMOOWGRT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected int? UZGOODSUDSC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected int ZXSWYXUEXGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected int UDKSRHMQUCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected int MLZTQLEPJJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected int KBWGPXUILLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected Sprite MHHMGAXLBXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected Sprite DOKKXFOILSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected Sprite AYPJHNOLVSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Sprite CTWYNPAWFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected bool UZSMKRWTZHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected string YPGXQVXBWUP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected string GBJNEBTZHVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected string RRIWOTXIBDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected string HYMPQTGDPUH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000445")]
		protected AvatarConfiguration GAXFOJGVBTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000446")]
		protected NEQJFGHULVB ODGNBHOFFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected Dictionary<string, int> LULASELHZNL;

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public FaceStyleSet ZUPDEYRLWAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x80A4100", Offset = "0x80A2900", VA = "0x1880A4100")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0x80A4150", Offset = "0x80A2950", VA = "0x1880A4150", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0x1938AF0", Offset = "0x19372F0", VA = "0x181938AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected virtual bool DIWHQBBCRWN
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected virtual bool GGKHMFGAKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0xABA4D0", Offset = "0xAB8CD0", VA = "0x180ABA4D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		protected int DVOOBHEHJMI
		{
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x80A0470", Offset = "0x809EC70", VA = "0x1880A0470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public bool UWBWYQWYKLB
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xC46CD0", Offset = "0xC454D0", VA = "0x180C46CD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x1938AE0", Offset = "0x19372E0", VA = "0x181938AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public Renderer[] DSOPEVEGTKM
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		public bool ZJAXGPEYRZB
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x80A4160", Offset = "0x80A2960", VA = "0x1880A4160")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x80A4320", Offset = "0x80A2B20", VA = "0x1880A4320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int TEPBTUDNVSC
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x80A10D0", Offset = "0x809F8D0", VA = "0x1880A10D0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		protected int KQTBDEVLDTW
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x80A11C0", Offset = "0x809F9C0", VA = "0x1880A11C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public float GDTKJSOPYLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0x80A4130", Offset = "0x80A2930", VA = "0x1880A4130")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x80A4300", Offset = "0x80A2B00", VA = "0x1880A4300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public YRJXBVVDOHH SAKJTZRMXAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000374")]
			[Cpp2IlInjected.Address(RVA = "0xC98460", Offset = "0xC96C60", VA = "0x180C98460")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000375")]
			[Cpp2IlInjected.Address(RVA = "0x124E850", Offset = "0x124D050", VA = "0x18124E850")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NEQJFGHULVB VAUSDRUTRPX
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xC98440", Offset = "0xC96C40", VA = "0x180C98440")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x80A4280", Offset = "0x80A2A80", VA = "0x1880A4280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public NoseFaceOption BOTAORNQFDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000393")]
			[Cpp2IlInjected.Address(RVA = "0xC98430", Offset = "0xC96C30", VA = "0x180C98430")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000394")]
			[Cpp2IlInjected.Address(RVA = "0x144B320", Offset = "0x1449B20", VA = "0x18144B320")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action WACSAWBNLZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x80A4050", Offset = "0x80A2850", VA = "0x1880A4050")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x80A41D0", Offset = "0x80A29D0", VA = "0x1880A41D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x80A0C30", Offset = "0x809F430", VA = "0x1880A0C30")]
		public void LocalPlayEmote(ERYHJVYWLIK.Emote emote, float normalizedTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x80A0360", Offset = "0x809EB60", VA = "0x1880A0360")]
		public bool IsEmotePlaying(ERYHJVYWLIK.Emote emote)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x80A1C20", Offset = "0x80A0420", VA = "0x1880A1C20")]
		public void SetIdleHappy(bool happy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x80A0F60", Offset = "0x809F760", VA = "0x1880A0F60")]
		protected void OODMQZAJAND(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x80A0E00", Offset = "0x809F600", VA = "0x1880A0E00")]
		protected void OBBNRVOTWFC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x80A0FE0", Offset = "0x809F7E0", VA = "0x1880A0FE0")]
		protected void OOOTFMLJPAI(AvatarBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x80A1150", Offset = "0x809F950", VA = "0x1880A1150")]
		protected void QPFPRQRXUVX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x80A1130", Offset = "0x809F930", VA = "0x1880A1130")]
		public void PlayExpression(int hashID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x809FDC0", Offset = "0x809E5C0", VA = "0x18809FDC0")]
		protected void HLOFRQKXZXE(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x809FC00", Offset = "0x809E400", VA = "0x18809FC00")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType featureType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x809FE70", Offset = "0x809E670", VA = "0x18809FE70")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x80A18C0", Offset = "0x80A00C0", VA = "0x1880A18C0")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__147))]
		public Task SetFaceSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x80A19B0", Offset = "0x80A01B0", VA = "0x1880A19B0")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__148))]
		public Task SetFaceSettings(int eyeSelection, int eyeBrowSelection, int noseSelection, int mouthSelection, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x80A1CA0", Offset = "0x80A04A0", VA = "0x1880A1CA0")]
		[AsyncStateMachine(typeof(<SetSelectedFaceFeatureAndBuildFaceStyle>d__149))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType featureType, int selectionIndex, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x80A0720", Offset = "0x809EF20", VA = "0x1880A0720")]
		protected void KUGGLSDEVSB(FaceFeatureType a, FaceFeatureId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x80A2C80", Offset = "0x80A1480", VA = "0x1880A2C80")]
		protected void ZSNSTVORSSY(FaceFeatureType a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x809FA50", Offset = "0x809E250", VA = "0x18809FA50")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x80A1DB0", Offset = "0x80A05B0", VA = "0x1880A1DB0")]
		[AsyncStateMachine(typeof(<SetAllFaceFeatureSettings>d__153))]
		protected Task TCAXKQRLUYU(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x809EA00", Offset = "0x809D200", VA = "0x18809EA00")]
		protected void AEJYNZTBLIT(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x80A1EA0", Offset = "0x80A06A0", VA = "0x1880A1EA0")]
		protected static void UVAGSIMLBCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x809EF40", Offset = "0x809D740", VA = "0x18809EF40")]
		private void EJHHTUHFYQR(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x80A08A0", Offset = "0x809F0A0", VA = "0x1880A08A0")]
		protected void LTYOUILZWVM(FaceFeatureType a, Vector2 b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x80A1310", Offset = "0x809FB10", VA = "0x1880A1310")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType featureType, Vector2 normalizedPositionOffset, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x809FC40", Offset = "0x809E440", VA = "0x18809FC40")]
		protected void HBRCZSRBFGH(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x80A05A0", Offset = "0x809EDA0", VA = "0x1880A05A0")]
		protected void KFOAYRXLXDK(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x809F980", Offset = "0x809E180", VA = "0x18809F980")]
		protected void FUSDLXFTHPE(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x80A16A0", Offset = "0x809FEA0", VA = "0x1880A16A0")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType featureType, float normalizedScale, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x809F8A0", Offset = "0x809E0A0", VA = "0x18809F8A0")]
		[AsyncStateMachine(typeof(<BuildFaceFeatureStyle>d__171))]
		protected Task EUYYFDZIIWX(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x80A0170", Offset = "0x809E970", VA = "0x1880A0170")]
		public void InitializeFaceFeatureStyleSet(AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x80A0D20", Offset = "0x809F520", VA = "0x1880A0D20")]
		protected bool MLXTZONCVLO(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x809ED00", Offset = "0x809D500", VA = "0x18809ED00")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x1594070", Offset = "0x1592870", VA = "0x181594070", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x80A1050", Offset = "0x809F850", VA = "0x1880A1050")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x809EE40", Offset = "0x809D640", VA = "0x18809EE40")]
		[AsyncStateMachine(typeof(<BuildFaceStyleAsyncIfChanged>d__178))]
		public Task BuildFaceStyleAsyncIfChanged(AvatarBodyType avatarBodyType, bool forceRebuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x80A2910", Offset = "0x80A1110", VA = "0x1880A2910")]
		public void UpdateFaceDisplays(bool forceUpdateFaceTextures = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x809F1A0", Offset = "0x809D9A0", VA = "0x18809F1A0")]
		protected void ENIRXTLVWFZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x80A2670", Offset = "0x80A0E70", VA = "0x1880A2670")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x80A1AE0", Offset = "0x80A02E0", VA = "0x1880A1AE0")]
		public void SetFaceSpriteIndices(string leftEyeName, string rightEyeName, string mouthName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x80A2010", Offset = "0x80A0810", VA = "0x1880A2010")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x80A2A90", Offset = "0x80A1290", VA = "0x1880A2A90")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x80A1220", Offset = "0x809FA20", VA = "0x1880A1220")]
		protected void RCUUSHLNFGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x80A3E60", Offset = "0x80A2660", VA = "0x1880A3E60")]
		public PlayerFacialAnimatorBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0xACB290", Offset = "0xAC9A90", VA = "0x180ACB290", Slot = "4")]
		private bool DRKPYICDKEI()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	public struct ModernBodyFacialExpression
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400046F")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000470")]
		public int Id;
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200007D")]
		[CompilerGenerated]
		private sealed class ISSKOPPZXFU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004D8")]
			public PlayerModernBodyEditorAvatarValidator VIXLAPAPYNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004D9")]
			public GameObject WHBDDYNVKGU;

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ISSKOPPZXFU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x8096280", Offset = "0x8094A80", VA = "0x188096280")]
			internal void SLFPVOCLDFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x8096250", Offset = "0x8094A50", VA = "0x188096250")]
			internal void SLAIYHINTTW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x80962E0", Offset = "0x8094AE0", VA = "0x1880962E0")]
			internal void SLQDQBQFWBX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x80962B0", Offset = "0x8094AB0", VA = "0x1880962B0")]
			internal void SLKWSUWIMQO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x8096340", Offset = "0x8094B40", VA = "0x188096340")]
			internal void SMARKPEAOYP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x8096310", Offset = "0x8094B10", VA = "0x188096310")]
			internal void SLVKNIKDFNG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x80963A0", Offset = "0x8094BA0", VA = "0x1880963A0")]
			internal void SMLFFCRVHVH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x8096370", Offset = "0x8094B70", VA = "0x188096370")]
			internal void SMFYHVXXYJY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x8096220", Offset = "0x8094A20", VA = "0x188096220")]
			internal void SJPMRLZGFSL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x80961F0", Offset = "0x80949F0", VA = "0x1880961F0")]
			internal void SJKFUFFIWHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x8096160", Offset = "0x8094960", VA = "0x188096160")]
			internal void COLFFYLBVSY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x8096190", Offset = "0x8094990", VA = "0x188096190")]
			internal void COQMDFEZFEH()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private struct <UpdateFaceFeatures>d__135 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004DB")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004DC")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004DD")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x80AD770", Offset = "0x80ABF70", VA = "0x1880AD770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0xAFF690", Offset = "0xAFDE90", VA = "0x180AFF690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private struct <UpdateFaceFeaturesInternal>d__136 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x80AD220", Offset = "0x80ABA20", VA = "0x1880AD220", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0x80AD710", Offset = "0x80ABF10", VA = "0x1880AD710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public AvatarBodyType avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000477")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		public HelmetHairState useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public SSHQATTNPKI hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public TZRRXNXICLM HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public GameObject torsoModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public GameObject legsModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public GameObject validationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public bool showModestyAndValidationGuidelines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		private FFOXVJRCTHT ZQZTRFUCHVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		private AnimatorOverrideController NOUWRADRLWG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> YJYUMKGZEKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public readonly ModernBodyFacialExpression[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public readonly (string, HandVisualState)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x251")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x252")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		protected bool QESNNZNLTIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x254")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		protected Guid DLGRRKNQMWQ;

		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		protected static Guid MYAZDZOODRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		private FDAAWKBDLQS ZVFKFEOJFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		private YRJXBVVDOHH OAUJSAATIMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		private ODVOAWIYQTP OGTNHRUJYLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		private ODVOAWIYQTP YYHDTRBISFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		private AdditionalHatData AQIIFQQTGFU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private readonly Dictionary<GameObject, MVIYUYYKFIE> THAUQKJTOQY;

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public static Func<WHSITFMKFBQ> HLIPGVMTEEY
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x80A9E50", Offset = "0x80A8650", VA = "0x1880A9E50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x80AA490", Offset = "0x80A8C90", VA = "0x1880AA490")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool TSFXVQCRKYK
		{
			[Cpp2IlInjected.Token(Token = "0x60003B5")]
			[Cpp2IlInjected.Address(RVA = "0x80A9FB0", Offset = "0x80A87B0", VA = "0x1880A9FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public bool SJLBVXXIQUG
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0x80A9EA0", Offset = "0x80A86A0", VA = "0x1880A9EA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		public PlayerAvatarDisplayBase ZBMJWKKBAUQ
		{
			[Cpp2IlInjected.Token(Token = "0x60003B8")]
			[Cpp2IlInjected.Address(RVA = "0xC98400", Offset = "0xC96C00", VA = "0x180C98400")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		protected static Guid FMVRWSVLCZW
		{
			[Cpp2IlInjected.Token(Token = "0x60003B9")]
			[Cpp2IlInjected.Address(RVA = "0x80A6060", Offset = "0x80A4860", VA = "0x1880A6060")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public (GameObject prefab, AvatarBodyPart part)[] FYGFWJIWXRH
		{
			[Cpp2IlInjected.Token(Token = "0x60003CF")]
			[Cpp2IlInjected.Address(RVA = "0x80AA0C0", Offset = "0x80A88C0", VA = "0x1880AA0C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x80A7620", Offset = "0x80A5E20", VA = "0x1880A7620")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x80A5C10", Offset = "0x80A4410", VA = "0x1880A5C10")]
		private IEnumerable<GameObject> DSEKUEDUWRI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x80A7B40", Offset = "0x80A6340", VA = "0x1880A7B40")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x80A7540", Offset = "0x80A5D40", VA = "0x1880A7540")]
		private void REBUTMWGNIU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x128F040", Offset = "0x128D840", VA = "0x18128F040")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x80A6220", Offset = "0x80A4A20", VA = "0x1880A6220")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x80A7B50", Offset = "0x80A6350", VA = "0x1880A7B50")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x80A7960", Offset = "0x80A6160", VA = "0x1880A7960")]
		public void ShowPose(AnimationClip pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x80A7B10", Offset = "0x80A6310", VA = "0x1880A7B10")]
		public void ShowPose(string poseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x80A7790", Offset = "0x80A5F90", VA = "0x1880A7790")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x80A7630", Offset = "0x80A5E30", VA = "0x1880A7630")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x80A8670", Offset = "0x80A6E70", VA = "0x1880A8670")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		public void UpdateFaceAndBodyShapes(bool forceRebuild = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x80A8A90", Offset = "0x80A7290", VA = "0x1880A8A90")]
		public void UpdateNoseShape(NoseType noseType, bool forceRebuild = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x80A8A50", Offset = "0x80A7250", VA = "0x1880A8A50")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x80A8AC0", Offset = "0x80A72C0", VA = "0x1880A8AC0", Slot = "4")]
		protected virtual void WPTKYFEQDZT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x80A4950", Offset = "0x80A3150", VA = "0x1880A4950", Slot = "5")]
		protected virtual void BJPBEBYOFXN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x80A4580", Offset = "0x80A2D80", VA = "0x1880A4580")]
		public void ApplyHatData(AdditionalHatData hatData, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x80A43C0", Offset = "0x80A2BC0", VA = "0x1880A43C0")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x80A48E0", Offset = "0x80A30E0", VA = "0x1880A48E0")]
		public void ApplyHatUVOverride(Vector2 UVOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x80A4800", Offset = "0x80A3000", VA = "0x1880A4800")]
		public void ApplyHatPositionAdjustment(Vector3 positionAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x80A4870", Offset = "0x80A3070", VA = "0x1880A4870")]
		public void ApplyHatRotationAdjustment(Vector3 rotationAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x80A4BC0", Offset = "0x80A33C0", VA = "0x1880A4BC0")]
		public AvatarItemSelection BuildAvatarItemSelection(GameObject selection, AvatarBodyType bodyType, AvatarBodyPart part)
		{
			return default(AvatarItemSelection);
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x80A4C60", Offset = "0x80A3460", VA = "0x1880A4C60")]
		public void BuildAvatar(bool forceRebuild = false, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x80A7F20", Offset = "0x80A6720", VA = "0x1880A7F20")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x80A4500", Offset = "0x80A2D00", VA = "0x1880A4500")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x80A88A0", Offset = "0x80A70A0", VA = "0x1880A88A0")]
		public void UpdateHatAnchor(bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x80A85C0", Offset = "0x80A6DC0", VA = "0x1880A85C0")]
		[AsyncStateMachine(typeof(<UpdateFaceFeatures>d__135))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x80A6150", Offset = "0x80A4950", VA = "0x1880A6150")]
		[AsyncStateMachine(typeof(<UpdateFaceFeaturesInternal>d__136))]
		private Task FGOSFBHLXRP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x80A6A60", Offset = "0x80A5260", VA = "0x1880A6A60")]
		private void PCOIBDTSHNZ(FaceFeatureType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x80A7E90", Offset = "0x80A6690", VA = "0x1880A7E90")]
		private void UZQJPOYPXGD(FaceFeatureType a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x80A8480", Offset = "0x80A6C80", VA = "0x1880A8480")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x80A8700", Offset = "0x80A6F00", VA = "0x1880A8700")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x80A5370", Offset = "0x80A3B70", VA = "0x1880A5370")]
		private void CTLJVSZXHEW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		private void SMRUDCWMSJU(MVIYUYYKFIE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0xA9F990", Offset = "0xA9E190", VA = "0x180A9F990")]
		private void CNIUMFSDRAK(MVIYUYYKFIE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x80A5890", Offset = "0x80A4090", VA = "0x1880A5890")]
		private void DLOBPFKYEZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x80A6D20", Offset = "0x80A5520", VA = "0x1880A6D20")]
		public void PopulatePrefabSlotsByGuid(List<Guid> guids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x80A5DF0", Offset = "0x80A45F0", VA = "0x1880A5DF0")]
		private void EMQYYMHHUDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x80A8DD0", Offset = "0x80A75D0", VA = "0x1880A8DD0")]
		private void ZDTRMQVZHBH(OutfitType a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x80A91B0", Offset = "0x80A79B0", VA = "0x1880A91B0")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x80A69B0", Offset = "0x80A51B0", VA = "0x1880A69B0")]
		[CompilerGenerated]
		private AvatarItemSelection MUJYYRPCJHN((GameObject prefab, AvatarBodyPart part) h)
		{
			return default(AvatarItemSelection);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[AddComponentMenu("/")]
	public class RoomiePuppet : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000081")]
		public class RoomieAvatarReferences
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			public Transform hatAnchorBone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			public AvatarSkinnedMeshBoneOrderRemapsData boneOrderRemap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			public SkinnedMeshRenderer roomieBaseSkinnedMeshRenderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public Material[] roomieBaseMaterials;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			public AssetReference roomieBodyAssetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			public Transform deformRigRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004EA")]
			public GameObject generatedMeshContainer;

			[Cpp2IlInjected.Token(Token = "0x6000400")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public RoomieAvatarReferences()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004E2")]
		public RoomieAvatarDisplay avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004E3")]
		[SerializeField]
		private RoomieAvatarReferences _references;

		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(RVA = "0x80AA6B0", Offset = "0x80A8EB0", VA = "0x1880AA6B0")]
		public void SetOutfitItems(IEnumerable<Guid> avatarItemGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FE")]
		[Cpp2IlInjected.Address(RVA = "0x80AA500", Offset = "0x80A8D00", VA = "0x1880AA500")]
		public void InitializeAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
		public RoomiePuppet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EF")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F0")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004F1")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000406")]
		[Cpp2IlInjected.Address(RVA = "0xA9F980", Offset = "0xA9E180", VA = "0x180A9F980")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	public struct AvatarItemSelection
	{
		[Cpp2IlInjected.Token(Token = "0x2000085")]
		[CompilerGenerated]
		private sealed class CAOYPSXYHLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F4")]
			public IEnumerable<OutfitType> MNXYZKECWFH;

			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CAOYPSXYHLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x80950B0", Offset = "0x80938B0", VA = "0x1880950B0")]
			internal bool BSTEDTJFAXM(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F2")]
		private MVIYUYYKFIE _avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004F3")]
		private AvatarBodyPart _bodyPart;

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public MVIYUYYKFIE MYKWUVZYCYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000407")]
			[Cpp2IlInjected.Address(RVA = "0xBE9B80", Offset = "0xBE8380", VA = "0x180BE9B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public AvatarBodyPart WTYYBECUAKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000408")]
			[Cpp2IlInjected.Address(RVA = "0xBE9B90", Offset = "0xBE8390", VA = "0x180BE9B90")]
			get
			{
				return default(AvatarBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public string MUWKTGFIPSI
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0x8094F70", Offset = "0x8093770", VA = "0x188094F70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool EVZUBAWTJHE
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0x8095060", Offset = "0x8093860", VA = "0x188095060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool EMRMPPQSSMF
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x8094F20", Offset = "0x8093720", VA = "0x188094F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public bool IBYHYOZVYBN
		{
			[Cpp2IlInjected.Token(Token = "0x600040C")]
			[Cpp2IlInjected.Address(RVA = "0x8094A70", Offset = "0x8093270", VA = "0x188094A70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x181E680", Offset = "0x181CE80", VA = "0x18181E680")]
		public AvatarItemSelection(MVIYUYYKFIE avatarItem, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x8094CA0", Offset = "0x80934A0", VA = "0x188094CA0")]
		public bool REZHQPOBIJP(OutfitType a, AvatarBodyPart b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040F")]
		[Cpp2IlInjected.Address(RVA = "0x8094AC0", Offset = "0x80932C0", VA = "0x188094AC0")]
		public bool KPTHPGVRZOS(AvatarItemSelection a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	public class ERLNNXNKNNO
	{
		[Cpp2IlInjected.Token(Token = "0x2000087")]
		[CompilerGenerated]
		private sealed class KMOETCHCLJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004F9")]
			public IEnumerable<OutfitType> MNXYZKECWFH;

			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KMOETCHCLJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0x80963D0", Offset = "0x8094BD0", VA = "0x1880963D0")]
			internal bool BSTEDTJFAXM(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004F5")]
		private MVIYUYYKFIE PKQSLTLBGJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004F6")]
		private RoomieBodyPart IGIGYKZFLJH;

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public MVIYUYYKFIE MYKWUVZYCYJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000412")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public RoomieBodyPart WTYYBECUAKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000413")]
			[Cpp2IlInjected.Address(RVA = "0xAA3180", Offset = "0xAA1980", VA = "0x180AA3180")]
			get
			{
				return default(RoomieBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Color? CWTSHUVBTEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000414")]
			[Cpp2IlInjected.Address(RVA = "0xAA31B0", Offset = "0xAA19B0", VA = "0x180AA31B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xAA3940", Offset = "0xAA2140", VA = "0x180AA3940")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BE")]
		public Vector3? UWXJAJSPRJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0xC8EEA0", Offset = "0xC8D6A0", VA = "0x180C8EEA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xC8EEB0", Offset = "0xC8D6B0", VA = "0x180C8EEB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(RVA = "0x8095830", Offset = "0x8094030", VA = "0x188095830")]
		public ERLNNXNKNNO(MVIYUYYKFIE a, RoomieBodyPart b, Color? c, Vector3? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(RVA = "0x8095710", Offset = "0x8093F10", VA = "0x188095710")]
		public bool KPTHPGVRZOS(ERLNNXNKNNO a)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__724601961
{
	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x80AEC10", Offset = "0x80AD410", VA = "0x1880AEC10")]
	public static void JTEJSBRAGJR()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x80AEC00", Offset = "0x80AD400", VA = "0x1880AEC00")]
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
