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
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F350", Offset = "0xD1E350", VA = "0x180D1F350")]
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
		[Cpp2IlInjected.Address(RVA = "0xD1F390", Offset = "0xD1E390", VA = "0x180D1F390")]
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
		[Cpp2IlInjected.Address(RVA = "0x97D9710", Offset = "0x97D8710", VA = "0x1897D9710", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
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
		private RecNetCDNKey QMCRYWZIPRP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RecNetCDNKey TypedRuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCFC340", Offset = "0xCFB340", VA = "0x180CFC340")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xEFCFC0", Offset = "0xEFBFC0", VA = "0x180EFCFC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97D97D0", Offset = "0x97D87D0", VA = "0x1897D97D0", Slot = "19")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x97D9800", Offset = "0x97D8800", VA = "0x1897D9800")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A30", Offset = "0xCF3A30", VA = "0x180CF4A30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCF4850", Offset = "0xCF3850", VA = "0x180CF4850")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCF4880", Offset = "0xCF3880", VA = "0x180CF4880")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD4F720", Offset = "0xD4E720", VA = "0x180D4F720")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD4F620", Offset = "0xD4E620", VA = "0x180D4F620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ItemPathHint PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF4DE70", Offset = "0xF4CE70", VA = "0x180F4DE70")]
			[CompilerGenerated]
			get
			{
				return default(ItemPathHint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF93080", Offset = "0xF92080", VA = "0x180F93080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x97D9910", Offset = "0x97D8910", VA = "0x1897D9910")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97D9890", Offset = "0x97D8890", VA = "0x1897D9890")]
		public static RecNetCDNKey UIDQRIQCTDU(string a, ItemPathHint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97D9840", Offset = "0x97D8840", VA = "0x1897D9840")]
		public void RPCYTFSCQNX(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public RecNetCDNKey()
		{
		}
	}
}
namespace RecRoom.AI.RoomieAI
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomieAvatarDisplay : AvatarDisplayBase, RHGOFRPLRDZ
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct EquipResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public IEnumerable<UZMMDXOYMGN> equippedItems;

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
				[Cpp2IlInjected.Address(RVA = "0xF07D00", Offset = "0xF06D00", VA = "0x180F07D00")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart Bodypart
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xD066A0", Offset = "0xD056A0", VA = "0x180D066A0")]
				[CompilerGenerated]
				get
				{
					return default(OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Vector3? Rotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xE839A0", Offset = "0xE829A0", VA = "0x180E839A0")]
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
				[Cpp2IlInjected.Address(RVA = "0x97D8E80", Offset = "0x97D7E80", VA = "0x1897D8E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x97D8E20", Offset = "0x97D7E20", VA = "0x1897D8E20")]
			public DisplayItemData(Guid customAvatarItemId, Vector3? rotation, Color? color, OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart part)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <AvatarRuntimeBuildMeshRoutine>d__125 : IEnumerator<BFNVKIYRTEQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private BFNVKIYRTEQ <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public List<CEQNQOATLVM> parts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public RoomieAvatarDisplay <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public List<GNSIOEMYZIQ> innerPromises;

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
			private BFNVKIYRTEQ System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public <AvatarRuntimeBuildMeshRoutine>d__125(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x97DF5D0", Offset = "0x97DE5D0", VA = "0x1897DF5D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x97DF800", Offset = "0x97DE800", VA = "0x1897DF800", Slot = "8")]
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
		private readonly List<GZZZBPLOCOP> _nextPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<GZZZBPLOCOP> _currentPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<GZZZBPLOCOP> _nextMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<GZZZBPLOCOP> _currentMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<DisplayItemData> _EquippedDisplayItemOutfitSelections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly IList<UZMMDXOYMGN> _currentEquippedOutfitSelections;

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
		private readonly Dictionary<(OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart bodyPart, Material sharedMaterial), Material> _currentSharedToInstanceLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Dictionary<(OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart bodyPart, Material sharedMaterial), Material> _nextSharedToInstanceLookup;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Dictionary<OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart, Color> RoomieCustomizedColors;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Dictionary<OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart, PositionAndRotation> RoomieCustomizedTransformPerPart;

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
		private readonly FYRDCSIKYKI _buildCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly FYRDCSIKYKI _buildCancelled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private SkinnedMeshRenderer[] _cachedBuiltBodySkinMeshes;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public FYRDCSIKYKI DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xDBC250", Offset = "0xDBB250", VA = "0x180DBC250", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public FYRDCSIKYKI DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xF71130", Offset = "0xF70130", VA = "0x180F71130", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xD13000", Offset = "0xD12000", VA = "0x180D13000", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x97DF300", Offset = "0x97DE300", VA = "0x1897DF300", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xF71120", Offset = "0xF70120", VA = "0x180F71120", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD618E0", Offset = "0xD608E0", VA = "0x180D618E0", Slot = "35")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform HatBone
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public FYRDCSIKYKI OnAnimationCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x97DF2C0", Offset = "0x97DE2C0", VA = "0x1897DF2C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x97DF1B0", Offset = "0x97DE1B0", VA = "0x1897DF1B0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PositionAndRotation HatPivotLocalPosAndRot
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x97DF1F0", Offset = "0x97DE1F0", VA = "0x1897DF1F0", Slot = "56")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public ZQRJPWYXNPA.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x97DF160", Offset = "0x97DE160", VA = "0x1897DF160", Slot = "32")]
			get
			{
				return default(ZQRJPWYXNPA.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x97D9F80", Offset = "0x97D8F80", VA = "0x1897D9F80", Slot = "51")]
		protected virtual UZMMDXOYMGN AvatarItemDefinitionFromDisplayItemDefinition(DisplayItemData displayItemData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x97DC740", Offset = "0x97DB740", VA = "0x1897DC740")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x97DEA80", Offset = "0x97DDA80", VA = "0x1897DEA80")]
		private void _UpdateManualLod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x97DCCF0", Offset = "0x97DBCF0", VA = "0x1897DCCF0")]
		private void QueuePostBuiltAvatarCustomizationUpdate(Action updateMatPropertAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x97D9EB0", Offset = "0x97D8EB0", VA = "0x1897D9EB0")]
		private void ApplyQueuedCustomizationUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x97D9980", Offset = "0x97D8980", VA = "0x1897D9980")]
		private void ApplyColorsToInstances()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x97DC0C0", Offset = "0x97DB0C0", VA = "0x1897DC0C0", Slot = "28")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x97DC630", Offset = "0x97DB630", VA = "0x1897DC630")]
		private PositionAndRotation GetHatAdjustmentOrDefault()
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x97D9D50", Offset = "0x97D8D50", VA = "0x1897D9D50", Slot = "45")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x97DC710", Offset = "0x97DB710", VA = "0x1897DC710", Slot = "48")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x97DCAE0", Offset = "0x97DBAE0", VA = "0x1897DCAE0")]
		public Task PlayAnimation(string animationName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x97DE270", Offset = "0x97DD270", VA = "0x1897DE270", Slot = "17")]
		public void SetUgcItemVisualOverrides(UZMMDXOYMGN overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97DE2F0", Offset = "0x97DD2F0", VA = "0x1897DE2F0", Slot = "18")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97DE2B0", Offset = "0x97DD2B0", VA = "0x1897DE2B0", Slot = "19")]
		public void SetUgcTextureParameters(PIVOXJSXBJE parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x97DE940", Offset = "0x97DD940", VA = "0x1897DE940", Slot = "49")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x97DEA40", Offset = "0x97DDA40", VA = "0x1897DEA40", Slot = "50")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties effectFloat4Properties, TextureEffectMaterialTextures effectTexture2DProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x97DCFA0", Offset = "0x97DBFA0", VA = "0x1897DCFA0", Slot = "46")]
		public void SetHatAnchorParams(NDDYXKDLQRL anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x97DE9C0", Offset = "0x97DD9C0", VA = "0x1897DE9C0", Slot = "47")]
		public void UpdateHatPivot([Optional] NDDYXKDLQRL anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x97D9F40", Offset = "0x97D8F40", VA = "0x1897D9F40", Slot = "23")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x97DE460", Offset = "0x97DD460", VA = "0x1897DE460")]
		public void Setup([In] AvatarDisplaySetupState _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x97DCDE0", Offset = "0x97DBDE0", VA = "0x1897DCDE0", Slot = "33")]
		public bool SetBaseSkinCullingMask(ZQRJPWYXNPA.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x97DCEA0", Offset = "0x97DBEA0", VA = "0x1897DCEA0", Slot = "20")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x97DE1F0", Offset = "0x97DD1F0", VA = "0x1897DE1F0", Slot = "21")]
		public void SetSkinColors(Color skinColor, Color? skinEmissiveColor, float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x97DBE10", Offset = "0x97DAE10", VA = "0x1897DBE10", Slot = "27")]
		public GNSIOEMYZIQ BuildPotatoAvatar(MCDWSPYDUYL avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x97DE230", Offset = "0x97DD230", VA = "0x1897DE230", Slot = "22")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x97DCF60", Offset = "0x97DBF60", VA = "0x1897DCF60")]
		public void SetFaceShape(AvatarFaceShape faceShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x97DCE60", Offset = "0x97DBE60", VA = "0x1897DCE60")]
		public void SetBodyShape(AvatarBodyShape bodyShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x97DCE20", Offset = "0x97DBE20", VA = "0x1897DCE20", Slot = "37")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x97D9940", Offset = "0x97D8940", VA = "0x1897D9940", Slot = "38")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x97DCF20", Offset = "0x97DBF20", VA = "0x1897DCF20", Slot = "39")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x97DD000", Offset = "0x97DC000", VA = "0x1897DD000", Slot = "40")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x97D9D10", Offset = "0x97D8D10", VA = "0x1897D9D10", Slot = "41")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x97D9E70", Offset = "0x97D8E70", VA = "0x1897D9E70", Slot = "42")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x97DD040", Offset = "0x97DC040", VA = "0x1897DD040")]
		public void SetNoseType(NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x97DCEE0", Offset = "0x97DBEE0", VA = "0x1897DCEE0", Slot = "43")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x97DE980", Offset = "0x97DD980", VA = "0x1897DE980", Slot = "44")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x97DEA00", Offset = "0x97DDA00", VA = "0x1897DEA00", Slot = "53")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x97DC0C0", Offset = "0x97DB0C0", VA = "0x1897DC0C0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xF712B0", Offset = "0xF702B0", VA = "0x180F712B0", Slot = "54")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayThirdPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "55")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayFirstPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x97D9D50", Offset = "0x97D8D50", VA = "0x1897D9D50")]
		public void OnLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x97DCB40", Offset = "0x97DBB40", VA = "0x1897DCB40")]
		private void PostOutfitUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x97DCB20", Offset = "0x97DBB20", VA = "0x1897DCB20")]
		private void PostMeshBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x97DCFE0", Offset = "0x97DBFE0", VA = "0x1897DCFE0", Slot = "16")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x97DDF40", Offset = "0x97DCF40", VA = "0x1897DDF40")]
		public void SetRoomieBoostCustomizationFloat(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x97DE030", Offset = "0x97DD030", VA = "0x1897DE030")]
		public void SetRoomiePrimarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x97DE110", Offset = "0x97DD110", VA = "0x1897DE110")]
		public void SetRoomieSecondarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x97DD080", Offset = "0x97DC080", VA = "0x1897DD080")]
		public Task<EquipResult> SetOutfitSelection(IReadOnlyList<DisplayItemData> displayItemDatas, bool forceBuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x97DBE50", Offset = "0x97DAE50", VA = "0x1897DBE50")]
		private List<UZMMDXOYMGN> CreateEquippedItemsFrorOutfitSelection(IReadOnlyList<Guid> customAvatarItemIds, IReadOnlyList<DisplayItemData> correspondingDADs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x97DA9E0", Offset = "0x97D99E0", VA = "0x1897DA9E0", Slot = "26")]
		public GNSIOEMYZIQ BuildAvatarMeshes(MCDWSPYDUYL avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, UZMMDXOYMGN>, (GNSIOEMYZIQ, DLXOODTYWKJ<Dictionary<string, VDJWASGHCNG<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x97DC530", Offset = "0x97DB530", VA = "0x1897DC530")]
		private bool GetCustomizationRequiresMeshBuild(List<DisplayItemData> newItemSelections)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x97DE7C0", Offset = "0x97DD7C0", VA = "0x1897DE7C0")]
		private void TeardownInProgressBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x97DA410", Offset = "0x97D9410", VA = "0x1897DA410")]
		public GNSIOEMYZIQ BuildAvatarMeshesInternal(MCDWSPYDUYL avatarBuildParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x97DE4A0", Offset = "0x97DD4A0", VA = "0x1897DE4A0")]
		private void SwapActiveResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x97DCD90", Offset = "0x97DBD90", VA = "0x1897DCD90")]
		private void ReleasePrefabs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x97DC3A0", Offset = "0x97DB3A0", VA = "0x1897DC3A0")]
		private void FinalizeRoomieDisplayUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x97DCA80", Offset = "0x97DBA80", VA = "0x1897DCA80")]
		private bool IsReadyToBuildLODMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x97DC190", Offset = "0x97DB190", VA = "0x1897DC190")]
		private GNSIOEMYZIQ EditorBuildMeshes(bool isFirstPerson, List<CEQNQOATLVM> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x97DE330", Offset = "0x97DD330", VA = "0x1897DE330")]
		private void SetupNewlyCreatedMesh(SkinnedMeshRenderer lodRenderer, int lod, Mesh mesh, List<Material> newUniqueMaterials)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x97DA9F0", Offset = "0x97D99F0", VA = "0x1897DA9F0")]
		private TUMXXHBUICX BuildLODMesh(List<CEQNQOATLVM> parts, int lod, bool isFirstPerson, Layers layer, bool IsSpreadAcrossFrames = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x97DA330", Offset = "0x97D9330", VA = "0x1897DA330")]
		[IteratorStateMachine(typeof(<AvatarRuntimeBuildMeshRoutine>d__125))]
		private IEnumerator<BFNVKIYRTEQ> AvatarRuntimeBuildMeshRoutine(bool isFirstPerson, List<CEQNQOATLVM> parts, int[] LODs, Func<int, Layers> getLayer, List<GNSIOEMYZIQ> innerPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x97DBB50", Offset = "0x97DAB50", VA = "0x1897DBB50")]
		private GNSIOEMYZIQ BuildLODMeshes(bool isFirstPerson, List<CEQNQOATLVM> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x97DECC0", Offset = "0x97DDCC0", VA = "0x1897DECC0")]
		public RoomieAvatarDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x97DCD70", Offset = "0x97DBD70", VA = "0x1897DCD70", Slot = "14")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x97DCD80", Offset = "0x97DBD80", VA = "0x1897DCD80", Slot = "15")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Setup([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Tested]
	public class EVERSYEAYIC : MYVERUYOFTS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly List<Mesh> IZVZPRVAKKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		protected readonly List<IReadOnlyList<byte>> ZZZDDGPJPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		protected readonly List<Matrix4x4> NGBECKMSLDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly List<bool> QNMSCGZDPYY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly List<long> EESCCJSQDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		protected readonly List<bool> ZXFMTVJRQUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		protected readonly List<int> DFDXBYRNGXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected Allocator VYDLTIYINYV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected MeshMergeModes AXQODLEBYDW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected byte EQGFRTOTFIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected IList<int> EVVSJEBVIEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected IList<int> ADITHYXMQJC;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x97D9100", Offset = "0x97D8100", VA = "0x1897D9100", Slot = "4")]
		public void OCZNDJRKROU(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, ZQRJPWYXNPA.SkinCullingMask e = (ZQRJPWYXNPA.SkinCullingMask)0L, int f = -1, bool g = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x97D94C0", Offset = "0x97D84C0", VA = "0x1897D94C0", Slot = "5")]
		public void TIONHWXXXQS(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x97D8EA0", Offset = "0x97D7EA0", VA = "0x1897D8EA0")]
		private static void ABPPWZBIGYG(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x97D9500", Offset = "0x97D8500", VA = "0x1897D9500")]
		public EVERSYEAYIC()
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
		[Cpp2IlInjected.Address(RVA = "0x97C7E90", Offset = "0x97C6E90", VA = "0x1897C7E90", Slot = "4")]
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
		public int DCSCRZYIGHK
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x97C5330", Offset = "0x97C4330", VA = "0x1897C5330")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x97C5360", Offset = "0x97C4360", VA = "0x1897C5360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int ARKLYUDVSYW
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x97C3FF0", Offset = "0x97C2FF0", VA = "0x1897C3FF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x97C5340", Offset = "0x97C4340", VA = "0x1897C5340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int YPEVNLREUKY
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x97C3530", Offset = "0x97C2530", VA = "0x1897C3530")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x97C5350", Offset = "0x97C4350", VA = "0x1897C5350")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int QREIKNIUXSZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x97C5460", Offset = "0x97C4460", VA = "0x1897C5460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x97C5D40", Offset = "0x97C4D40", VA = "0x1897C5D40")]
		public AvatarCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels, IDVMVYZVLAO systemInfoAccess, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x97C4000", Offset = "0x97C3000", VA = "0x1897C4000")]
		public void IPXJMSCMLNO(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x97C54D0", Offset = "0x97C44D0", VA = "0x1897C54D0")]
		public void WAXJDVHTGBY(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x97C4090", Offset = "0x97C3090", VA = "0x1897C4090")]
		public Color JBHREGIOSIX(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x97C5900", Offset = "0x97C4900", VA = "0x1897C5900")]
		public void ZDYPSENWLDR(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x97C5370", Offset = "0x97C4370", VA = "0x1897C5370")]
		public void SSRGHABAFGP(int a, Vector3 b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x97C3540", Offset = "0x97C2540", VA = "0x1897C3540")]
		public void AUSSZXCHUSR(int a, half4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x97C3DA0", Offset = "0x97C2DA0", VA = "0x1897C3DA0")]
		public void FBATIWZJWAB(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x97C39C0", Offset = "0x97C29C0", VA = "0x1897C39C0")]
		public void FADZURZGUPB(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x97C3750", Offset = "0x97C2750", VA = "0x1897C3750")]
		public void DSAFILXMVXQ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x97C43B0", Offset = "0x97C33B0", VA = "0x1897C43B0")]
		public bool KCWPVYTSXDV(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x97C3690", Offset = "0x97C2690", VA = "0x1897C3690")]
		public void DIQQVNFXGMN(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x97C3760", Offset = "0x97C2760", VA = "0x1897C3760", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x97C4410", Offset = "0x97C3410", VA = "0x1897C4410")]
		public Mesh NCPTIUAOFPM([Optional] string a)
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
		public int IWTGKFXUEGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x97C6AC0", Offset = "0x97C5AC0", VA = "0x1897C6AC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int MIBQATFYZPE
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x97C6B30", Offset = "0x97C5B30", VA = "0x1897C6B30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int WQILUPKWMLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x97C6780", Offset = "0x97C5780", VA = "0x1897C6780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int EYRAGCYGQMG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x97C6B00", Offset = "0x97C5B00", VA = "0x1897C6B00")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x97C6B20", Offset = "0x97C5B20", VA = "0x1897C6B20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int DCSCRZYIGHK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x97C6AF0", Offset = "0x97C5AF0", VA = "0x1897C6AF0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x97C6B10", Offset = "0x97C5B10", VA = "0x1897C6B10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int PRMLTTITKMT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x97C6770", Offset = "0x97C5770", VA = "0x1897C6770")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x97C6AD0", Offset = "0x97C5AD0", VA = "0x1897C6AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MeshMergeModes OXPRKCSEVSS
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x97C6AE0", Offset = "0x97C5AE0", VA = "0x1897C6AE0")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x97C6850", Offset = "0x97C5850", VA = "0x1897C6850")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public byte THRWAUKCPRR
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x97C6B40", Offset = "0x97C5B40", VA = "0x1897C6B40")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x97C6AB0", Offset = "0x97C5AB0", VA = "0x1897C6AB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public AvatarCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x97C7C40", Offset = "0x97C6C40", VA = "0x1897C7C40")]
			get
			{
				return default(AvatarCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x97C6B50", Offset = "0x97C5B50", VA = "0x1897C6B50")]
		public AvatarCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x97C69E0", Offset = "0x97C59E0", VA = "0x1897C69E0")]
		public AvatarCullAndCombineMeshJobContainer GOMXJEJRBRY(Allocator a, IDVMVYZVLAO b)
		{
			return default(AvatarCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x97C6860", Offset = "0x97C5860", VA = "0x1897C6860", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Tested]
	public class SFLTDDWVUUJ : EVERSYEAYIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool BKGIURRTVYW;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly ProfilerMarker GTSLCRQUSST;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x97DF320", Offset = "0x97DE320", VA = "0x1897DF320")]
		public AvatarCullAndCombineMeshJobGroup JLMFGOPPTYO()
		{
			return default(AvatarCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x97DF5C0", Offset = "0x97DE5C0", VA = "0x1897DF5C0")]
		public SFLTDDWVUUJ()
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
		protected LODSelection NQTBQPJWRWP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		protected int[] MLFOQYBBXCQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int requestedLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		protected int KKJFPKPRCJO;

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
		protected RHGOFRPLRDZ HZODWTWDUGW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		protected GNSIOEMYZIQ WVTHUHTKNMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		protected (bool isLodForced, int forcedLOD) HENIWEWQGRL;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public virtual int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD13000", Offset = "0xD12000", VA = "0x180D13000", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD675E0", Offset = "0xD665E0", VA = "0x180D675E0", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool IARRGGLOPTT
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x97CA300", Offset = "0x97C9300", VA = "0x1897CA300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public virtual bool TYFLHIYJSPX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static bool RQSNFWSTSBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x97CA2C0", Offset = "0x97C92C0", VA = "0x1897CA2C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public RHGOFRPLRDZ OJHTFZSZOND
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B60", Offset = "0xCF6B60", VA = "0x180CF7B60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x97CA3B0", Offset = "0x97C93B0", VA = "0x1897CA3B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected GNSIOEMYZIQ BPNNYZCRGTW
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xD01A50", Offset = "0xD00A50", VA = "0x180D01A50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x97C9C40", Offset = "0x97C8C40", VA = "0x1897C9C40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int WWXGOAGZXHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x97CA6B0", Offset = "0x97C96B0", VA = "0x1897CA6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AvatarBodyType UPKJCZUOTFU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x97CA270", Offset = "0x97C9270", VA = "0x1897CA270")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public virtual event Action LJILKYDRVSL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x97CA1D0", Offset = "0x97C91D0", VA = "0x1897CA1D0", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x97CA310", Offset = "0x97C9310", VA = "0x1897CA310", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x97C9EB0", Offset = "0x97C8EB0", VA = "0x1897C9EB0", Slot = "8")]
		public virtual (bool, bool, bool) WhichLodsAreResident()
		{
			return default((bool, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "9")]
		public virtual void CheckMeshesAgainstDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x97C9BE0", Offset = "0x97C8BE0", VA = "0x1897C9BE0", Slot = "10")]
		public virtual (int, long, int) GetDisplayedLodInfo()
		{
			return default((int, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x1097590", Offset = "0x1096590", VA = "0x181097590")]
		protected void XGCZKJXOGZZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x97C9EA0", Offset = "0x97C8EA0", VA = "0x1897C9EA0")]
		protected void VACVXKPUAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x15FD970", Offset = "0x15FC970", VA = "0x1815FD970")]
		protected void SGJILEZSVFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x97C9B30", Offset = "0x97C8B30", VA = "0x1897C9B30", Slot = "12")]
		public virtual Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x97C9CD0", Offset = "0x97C8CD0", VA = "0x1897C9CD0")]
		protected void HUIWWTIXCPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x97C9DF0", Offset = "0x97C8DF0", VA = "0x1897C9DF0", Slot = "13")]
		protected virtual void OZTMWTGQNZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x97C9D40", Offset = "0x97C8D40", VA = "0x1897C9D40")]
		public int MeshesAtLODCount(int LOD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x97CA0D0", Offset = "0x97C90D0", VA = "0x1897CA0D0")]
		public AvatarDisplayBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarDisplaySystem : RHGOFRPLRDZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class CFHNWXHLDZT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public AvatarDisplaySystem NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public Color SAAAGTGPUTE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Color? JXIGOBDMSTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public float? WAEQWDPRLMP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public Action<IMXEHHBCYAF> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public CFHNWXHLDZT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x97E97A0", Offset = "0x97E87A0", VA = "0x1897E97A0")]
			internal void FJOUTKUAYLR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x97E9700", Offset = "0x97E8700", VA = "0x1897E9700")]
			internal void FJJNWEADPAI(IMXEHHBCYAF a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class UUTSZHQDVWE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public bool XLFEKSJIXML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public bool IWRWZTFJJXK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public AvatarDisplaySystem NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public GNSIOEMYZIQ CNAKXVRPDUA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public Action<KeyValuePair<string, VDJWASGHCNG<Texture2D>>> CDRDZQJBJTR;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public UUTSZHQDVWE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x97F3160", Offset = "0x97F2160", VA = "0x1897F3160")]
			internal bool WBRTEIBBFLW(UZMMDXOYMGN a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x97F2F80", Offset = "0x97F1F80", VA = "0x1897F2F80")]
			internal bool EGHPORDFAFW(UZMMDXOYMGN a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x97F3010", Offset = "0x97F2010", VA = "0x1897F3010")]
			internal void WCXINWQLKBY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x97F3030", Offset = "0x97F2030", VA = "0x1897F3030")]
			internal void WDNDFQYDMJZ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x97F3010", Offset = "0x97F2010", VA = "0x1897F3010")]
			internal void EGXKGLKXCNX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x97F3030", Offset = "0x97F2030", VA = "0x1897F3030")]
			internal void EHCRDSEULZG(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x97F3050", Offset = "0x97F2050", VA = "0x1897F3050")]
			internal void EHHYAYYRVKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x97F3080", Offset = "0x97F2080", VA = "0x1897F3080")]
			internal void EHNEYFSPEVY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x97F30B0", Offset = "0x97F20B0", VA = "0x1897F30B0")]
			internal void EHXSSTGJXSQ(Dictionary<string, VDJWASGHCNG<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x97F31E0", Offset = "0x97F21E0", VA = "0x1897F31E0")]
			internal void YIJFXMCMJMP(KeyValuePair<string, VDJWASGHCNG<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4150", Offset = "0xCF3150", VA = "0x180CF4150")]
			internal UXDBKRJQXAW EICZQAAHHDZ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class UUYZWOKBFHN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public int CFAWYNYHUWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public UUTSZHQDVWE LWPGXDDEGGX;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public UUYZWOKBFHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x97F32A0", Offset = "0x97F22A0", VA = "0x1897F32A0")]
			internal Layers WDHWIKEGCYQ(int a)
			{
				return default(Layers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class UVEGTVDYOSW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public DLXOODTYWKJ<Dictionary<string, VDJWASGHCNG<Texture2D>>> HBCGYDHZRIL;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public UVEGTVDYOSW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			internal DLXOODTYWKJ<Dictionary<string, VDJWASGHCNG<Texture2D>>> EHSLVMMMOHH()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class KAXSKBNSNUL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public AvatarDisplaySystem NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public float JUQIPXIPMLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public Color LIIEPYIPHRD;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public KAXSKBNSNUL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x97F1010", Offset = "0x97F0010", VA = "0x1897F1010")]
			internal void JUWRDIWILQR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class OWXPRIASNUK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public List<GNSIOEMYZIQ> KFNZGLUCOVK;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public OWXPRIASNUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x97F1D10", Offset = "0x97F0D10", VA = "0x1897F1D10")]
			internal void IAMLBBDYEHE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class IITLKTVXODB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public string TTDKBMGQGTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public AvatarBodyPart LDXFCWQJHCL;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public IITLKTVXODB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x97EE2D0", Offset = "0x97ED2D0", VA = "0x1897EE2D0")]
			internal bool UKKFRZKSPUZ(KeyValuePair<string, UZMMDXOYMGN> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class HKFUDESVLQW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public List<GZZZBPLOCOP> LDBDWDTPVHV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public List<GZZZBPLOCOP> UONMPZZYCGS;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public HKFUDESVLQW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x97EE290", Offset = "0x97ED290", VA = "0x1897EE290")]
			internal UXDBKRJQXAW GQTLPWDMIJN(CEQNQOATLVM a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class HKLBALMSVCF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public KRXQQLTPXIR FFUFYNSIHEY;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public HKLBALMSVCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xE80580", Offset = "0xE7F580", VA = "0x180E80580")]
			internal void GRDZKJRHBGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xE805A0", Offset = "0xE7F5A0", VA = "0x180E805A0")]
			internal void GQYSNCXJRUW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class DRNFTNRRHZX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public KRXQQLTPXIR FFUFYNSIHEY;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public DRNFTNRRHZX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xE80580", Offset = "0xE7F580", VA = "0x180E80580")]
			internal void GRDZKJRHBGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xE805A0", Offset = "0xE7F5A0", VA = "0x180E805A0")]
			internal void GQYSNCXJRUW(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class HGRLJQVNYHG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public long WNMHPNHLCWS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public Stopwatch ULXOPSMISSJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public SkinnedMeshRenderer GPVHBYIVDWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public long BYYBBHEIAWY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public string RZWJOSBDPJG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public long EUNOGONSUFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public AvatarDisplaySystem NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public int NTJPBYNYJEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public List<Material> ZCHSZJAYJUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public List<(int mat, int part)> BJEIICUIUGZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public List<Bounds> BPHIVRMQPYK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public int YODLIWYTXZX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public long EYJOUEJUDRT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public long HWXVGQVNXXA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public long JYTKNEJLBMY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public Action OEWDZVBYLMK;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public HGRLJQVNYHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class HGWSGXPLHSP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public bool ZTSOWUXNNCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public JobHandle RYNXBUROOYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public AvatarCullAndCombineMeshJobContainer SRZGFPXFNIQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AvatarCullAndCombineMeshJobGroup CERTEOWOCVD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public HGRLJQVNYHG LWPGXDDEGGX;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public HGWSGXPLHSP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x97EDA50", Offset = "0x97ECA50", VA = "0x1897EDA50")]
			internal void LERRDLXRYYG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x97E0320", Offset = "0x97DF320", VA = "0x1897E0320")]
			internal void LEWYASRPIJP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class HHBZEEJIRDY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public bool ZTSOWUXNNCX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public JobHandle RYNXBUROOYU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public AvatarLegacyCullAndCombineMeshJobContainer CPRIZZMEBAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public AvatarLegacyCullAndCombineMeshJobGroup SRUYACKYSQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public HGRLJQVNYHG LWUNUJXBPSG;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public HHBZEEJIRDY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x97EE010", Offset = "0x97ED010", VA = "0x1897EE010")]
			internal void LEHDIYJXGBO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x97E05D0", Offset = "0x97DF5D0", VA = "0x1897E05D0")]
			internal void LEMKGFDUPMX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class GDDBOBJIFDG : IEnumerator<BFNVKIYRTEQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private BFNVKIYRTEQ NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			public bool RTALURCJHCE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public AvatarDisplaySystem NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public List<CEQNQOATLVM> HIPVERIALLS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public List<GNSIOEMYZIQ> KFNZGLUCOVK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public int[] NLJLRBVKVYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public bool NUVQXKTUHYR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public Func<int, Layers> VFNRQEBAAHR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public IMXEHHBCYAF ZPGOYZSRONN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public Material WUBFVCBZNLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			private int LGPIFPFIKSW;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			private BFNVKIYRTEQ NHKNBMQLZLJ
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public GDDBOBJIFDG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x97ED770", Offset = "0x97EC770", VA = "0x1897ED770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x97EDA10", Offset = "0x97ECA10", VA = "0x1897EDA10", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly Log YWJLEKBSJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly FYRDCSIKYKI GEGOLAYMYVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly FYRDCSIKYKI RDQBGQNTMTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private Dictionary<BodyProperty, float> UNVIXSGJKXE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Dictionary<FaceProperty, float> JHRALDBZEOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<NoseProperty, float> AKOPSLYGKJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private IReadOnlyDictionary<string, BoneLocalInfo> NJVQZDCRLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private Dictionary<string, BoneLocalInfo> VMRPWLTCIKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Dictionary<string, BoneLocalInfo> QBFHCKNGHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Dictionary<string, BoneLocalInfo> FTHCRSXWDRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private AvatarBuildType UOACYLUMDUX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private AvatarBuildType JMAVAOGTPDH;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static float EDQVREKQBCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private AvatarConfiguration LTPCVRNKZIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private Transform DXGOCISVLPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private AvatarSkinAssetItem LLURKQEIXZF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private AssetReference OCKSSKNTQRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private AssetReference HFOANTHDUJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private AssetReference CWVVSVSYNLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private AssetReference YDOMCGRLRZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private GameObject IZBCQWVOVRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private GameObject UBQVGSYEAJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private GameObject GATWLJPGASL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private SkinnedMeshRenderer IQNPSVBZAWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private AvatarSkinnedMeshBoneOrderRemapsData XUXWAIDKWGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private Transform[] YZGNCNPSQUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Matrix4x4[] OQNRWEHCNOT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private Material KCNZHWJZCVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Material LUJYUHBDSWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Texture2D VVSHGOSCOZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Material XWJDMQTXYCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Material EULKYVWXJCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Material FGDUOYKBPWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Shader UAELGTUEGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Shader EVAAJLYKTAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Animator TTQCHSUMUCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Renderer[] CALYYNKQKBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private ZQRJPWYXNPA.SkinCullingMask LFBQTSVOFAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private AvatarBodyPartShapesManager HJNNMWAFLGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private IReadOnlyDictionary<string, Transform> SADAYIQYKBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private bool JLMOSMAQQFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private bool JQPQLDFMFEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private Color VGUDJGNFFRP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Color? HSEQOBPIZGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Texture2D XFRVFDHULNT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private float? RRKCHXPVWCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private Color HAALNEEJZEW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Color OLVAWKNGQHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Color? MBJSEKTCCUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Color? ZHQFVBLDTGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Color? IXIFZAUKXEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Color? EDHCDQZXONO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Texture2D QZRZIWUQLEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Texture2D GVABKIKGANM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[CanBeNull]
		private UZMMDXOYMGN UYTADSRMRTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Texture UFPJJJYSNUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Color CDCKVNWBPBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public Dictionary<Renderer, IMXEHHBCYAF> CERPINRDSYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private Dictionary<Renderer, IMXEHHBCYAF> KPLYPHCOPMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Dictionary<string, List<AvatarMaterialKey>> TTPCUACBEZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private Dictionary<string, List<AvatarMaterialKey>> GZFWTFAYYEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private readonly List<GZZZBPLOCOP> LDBDWDTPVHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly List<GZZZBPLOCOP> QEEXYQEOPFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly List<GZZZBPLOCOP> UONMPZZYCGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly List<GZZZBPLOCOP> UPBDYLAEMQQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private Dictionary<AvatarMaterialKey, Material> UQYCVFNRUWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Dictionary<AvatarMaterialKey, Material> AZWMYEUKGGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private SkinnedMeshRenderer[] RVNKXNJMMVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private SkinnedMeshRenderer[] NQCJLSQIKUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private SkinnedMeshRenderer[] VLKWIWVMKFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private SkinnedMeshRenderer[] MQKRXXJOGYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly Dictionary<string, VDJWASGHCNG<Texture2D>> DWYTSQHFHRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly Dictionary<string, VDJWASGHCNG<Texture2D>> UBIULJDSEGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private AdditionalHatData YDNUCWLQYVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private AdditionalHatData LAKWQHZUASS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private RecRoom.Avatars.Data.Shared.HairData NLDMHEQNFTF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private RecRoom.Avatars.Data.Shared.HairData JGXKMSRKZPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private NDDYXKDLQRL MMIEGEXBDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private bool? NGJSXKYUTBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private PositionAndRotation YCECSBRYAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private Transform IEHQCYIYQVF;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Material MMQGEWHLMVU;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Material RYFVBUBHGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private Dictionary<string, UZMMDXOYMGN> CRFPSSWDYRF;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly int DFYGSLGXUPC;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly int HIKYZUXVHCU;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly int TOCVXGSMSWY;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly int KMIYZTVQABX;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly int DOENNEZYLSF;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly int DVCTVFLVMTE;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly int VVSBVWGYRXR;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int ZHALLGTZBCN;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int MIHLIQLRXKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private bool FICECZVCPLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F9")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private bool ZETBOLIMYKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private List<Action> RTKIPXAQEPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private PIVOXJSXBJE UFMTBJRQBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private SkinnedMeshRenderer[] PGTLDWDGDUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int SBTAVETKNOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private bool DLPMJONNTAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private int KKJFPKPRCJO;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public FYRDCSIKYKI DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public FYRDCSIKYKI DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B90", Offset = "0xCF6B90", VA = "0x180CF7B90", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool EITZAXWQBQP
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x97D3DB0", Offset = "0x97D2DB0", VA = "0x1897D3DB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x97D4CD0", Offset = "0x97D3CD0", VA = "0x1897D4CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private Material LZMDMLHGVJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x97D3C10", Offset = "0x97D2C10", VA = "0x1897D3C10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private Material ZCSKHWUHHCT
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x97D4FA0", Offset = "0x97D3FA0", VA = "0x1897D4FA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool SRXEBRAJJKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x97D8C90", Offset = "0x97D7C90", VA = "0x1897D8C90", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(AvatarBodyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x97D8E10", Offset = "0x97D7E10", VA = "0x1897D8E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xF712C0", Offset = "0xF702C0", VA = "0x180F712C0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2531450", Offset = "0x2530450", VA = "0x182531450", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xF71260", Offset = "0xF70260", VA = "0x180F71260", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x97D8CA0", Offset = "0x97D7CA0", VA = "0x1897D8CA0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ZQRJPWYXNPA.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD70640", Offset = "0xD6F640", VA = "0x180D70640", Slot = "22")]
			get
			{
				return default(ZQRJPWYXNPA.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int UHFTMMCALQD
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x97D3570", Offset = "0x97D2570", VA = "0x1897D3570")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x97D3BF0", Offset = "0x97D2BF0", VA = "0x1897D3BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool PSPKCSVLDCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x97D3580", Offset = "0x97D2580", VA = "0x1897D3580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private static bool NGZGKHKSOCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x97CB940", Offset = "0x97CA940", VA = "0x1897CB940", Slot = "17")]
		public GNSIOEMYZIQ BuildPotatoAvatar(MCDWSPYDUYL avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x97CB910", Offset = "0x97CA910", VA = "0x1897CB910", Slot = "16")]
		public GNSIOEMYZIQ BuildAvatarMeshes(MCDWSPYDUYL avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, UZMMDXOYMGN>, (GNSIOEMYZIQ, DLXOODTYWKJ<Dictionary<string, VDJWASGHCNG<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x97CF470", Offset = "0x97CE470", VA = "0x1897CF470")]
		public GNSIOEMYZIQ KMRNYUAVORN(MCDWSPYDUYL a, bool b, int[] c, bool d, AvatarBuildType e, [Optional] Func<Dictionary<string, UZMMDXOYMGN>, (GNSIOEMYZIQ, DLXOODTYWKJ<Dictionary<string, VDJWASGHCNG<Texture2D>>>)> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x97CA790", Offset = "0x97C9790", VA = "0x1897CA790")]
		public static void AOVKMHSQRGE(Log a, string b, AssetReference c, AssetReference[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x97CC0E0", Offset = "0x97CB0E0", VA = "0x1897CC0E0")]
		private bool CRNJMLOVWBA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x97D2DC0", Offset = "0x97D1DC0", VA = "0x1897D2DC0")]
		private GNSIOEMYZIQ MLFIVXZEIDK(bool a, List<CEQNQOATLVM> b, int[] c, Func<int, Layers> d, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x97CDF90", Offset = "0x97CCF90", VA = "0x1897CDF90")]
		[IteratorStateMachine(typeof(GDDBOBJIFDG))]
		private IEnumerator<BFNVKIYRTEQ> IAQWKEZZPZM(bool a, List<CEQNQOATLVM> b, int[] c, Func<int, Layers> d, IMXEHHBCYAF e, Material f, List<GNSIOEMYZIQ> g, bool h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x97CE0A0", Offset = "0x97CD0A0", VA = "0x1897CE0A0")]
		public static void ICJUJFQGSZP(List<CEQNQOATLVM> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x97CC670", Offset = "0x97CB670", VA = "0x1897CC670")]
		public static GNSIOEMYZIQ EOWCQNTGYBB(List<CEQNQOATLVM> a, List<GZZZBPLOCOP> b, List<GZZZBPLOCOP> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x97CC910", Offset = "0x97CB910", VA = "0x1897CC910")]
		public GNSIOEMYZIQ EOWCQNTGYBB(List<CEQNQOATLVM> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x97D1B50", Offset = "0x97D0B50", VA = "0x1897D1B50")]
		private TUMXXHBUICX MEYHXENWPTC(List<CEQNQOATLVM> a, int b, bool c, Layers d, bool e, IMXEHHBCYAF f, Material g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x97D4110", Offset = "0x97D3110", VA = "0x1897D4110", Slot = "27")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x97D4690", Offset = "0x97D3690", VA = "0x1897D4690", Slot = "29")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x97D4820", Offset = "0x97D3820", VA = "0x1897D4820", Slot = "30")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x97CAFD0", Offset = "0x97C9FD0", VA = "0x1897CAFD0", Slot = "28")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x97CB030", Offset = "0x97CA030", VA = "0x1897CB030", Slot = "31")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x97CB0F0", Offset = "0x97CA0F0", VA = "0x1897CB0F0", Slot = "32")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x97D3DC0", Offset = "0x97D2DC0", VA = "0x1897D3DC0")]
		private void RZHIARAXXFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x97D5080", Offset = "0x97D4080", VA = "0x1897D5080")]
		private void TLTHINPNCHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x97D34F0", Offset = "0x97D24F0", VA = "0x1897D34F0")]
		private void NXWXIXXCJWC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x97D5980", Offset = "0x97D4980", VA = "0x1897D5980", Slot = "34")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x97D68F0", Offset = "0x97D58F0", VA = "0x1897D68F0", Slot = "41")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x97D4680", Offset = "0x97D3680", VA = "0x1897D4680", Slot = "33")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x97D79E0", Offset = "0x97D69E0", VA = "0x1897D79E0")]
		private void YMWVASPFUXD(SkinnedMeshRenderer a, int b, Mesh c, List<Material> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x97D7B30", Offset = "0x97D6B30", VA = "0x1897D7B30")]
		public static Material YTIHKKSYIDO(Dictionary<AvatarMaterialKey, Material> a, Material b, UpdatableColorType c, UpdatableTextureType d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x97CE6E0", Offset = "0x97CD6E0", VA = "0x1897CE6E0")]
		public static UpdatableColorType IGYEKMLXMFB(CEQNQOATLVM a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x97CB320", Offset = "0x97CA320", VA = "0x1897CB320")]
		private void BKXPFAFKFCS(int a, Material b, CEQNQOATLVM c, [Out] Texture2D d, [Out] Vector4 e, [Out] Texture2D f, [Out] Texture2D g, [Out] Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x97CD040", Offset = "0x97CC040", VA = "0x1897CD040")]
		private void FXDDFXEVTHQ(int a, Material b, CEQNQOATLVM c, [Out] Color d, [Out] Color e, [Out] Color f, [Out] Color g, [Out] Color h, [Out] Color i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x97D1850", Offset = "0x97D0850", VA = "0x1897D1850")]
		private bool LISUAAAYDBN(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x97CCBA0", Offset = "0x97CBBA0", VA = "0x1897CCBA0")]
		private static Material ESUBLFUDPSR(int a, ZIQDTJWNQUK b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x97D3E40", Offset = "0x97D2E40", VA = "0x1897D3E40")]
		public static UpdatableTextureType SKQLVAEBBIT(CEQNQOATLVM a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x97D7350", Offset = "0x97D6350", VA = "0x1897D7350")]
		private static void WHQQFIYCQVQ(Dictionary<string, List<AvatarMaterialKey>> a, CEQNQOATLVM b, Material c, UpdatableColorType d, UpdatableTextureType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x97D39C0", Offset = "0x97D29C0", VA = "0x1897D39C0")]
		public static SkinnedMeshRenderer PYEZNYBWPFK(Transform a, Transform b, SkinnedMeshRenderer[] c, int d, Layers e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x97D83B0", Offset = "0x97D73B0", VA = "0x1897D83B0")]
		public AvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x97CE9B0", Offset = "0x97CD9B0", VA = "0x1897CE9B0")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x97D17D0", Offset = "0x97D07D0", VA = "0x1897D17D0")]
		public void VGDZOOCCQMD([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x97D3BF0", Offset = "0x97D2BF0", VA = "0x1897D3BF0", Slot = "6")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x97D4A50", Offset = "0x97D3A50", VA = "0x1897D4A50", Slot = "12")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
		public static bool HPBRFJITLYI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x97CB150", Offset = "0x97CA150", VA = "0x1897CB150", Slot = "13")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x97D4200", Offset = "0x97D3200", VA = "0x1897D4200", Slot = "10")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x97D4910", Offset = "0x97D3910", VA = "0x1897D4910", Slot = "11")]
		public void SetSkinColors(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x97D3470", Offset = "0x97D2470", VA = "0x1897D3470")]
		private void NRZOJYKDRBE(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x97D4C60", Offset = "0x97D3C60", VA = "0x1897D4C60", Slot = "7")]
		public void SetUgcItemVisualOverrides(UZMMDXOYMGN overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x97D4CD0", Offset = "0x97D3CD0", VA = "0x1897D4CD0", Slot = "8")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x247E7D0", Offset = "0x247D7D0", VA = "0x18247E7D0", Slot = "9")]
		public void SetUgcTextureParameters(PIVOXJSXBJE parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x97D5100", Offset = "0x97D4100", VA = "0x1897D5100", Slot = "18")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x97CB090", Offset = "0x97CA090", VA = "0x1897CB090", Slot = "35")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x97D4780", Offset = "0x97D3780", VA = "0x1897D4780", Slot = "36")]
		public void SetHatAnchorParams(NDDYXKDLQRL anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x97D5AC0", Offset = "0x97D4AC0", VA = "0x1897D5AC0", Slot = "37")]
		public void UpdateHatPivot([Optional] NDDYXKDLQRL anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x97D3320", Offset = "0x97D2320", VA = "0x1897D3320")]
		private bool NBBSEHZFJAY()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x97D40F0", Offset = "0x97D30F0", VA = "0x1897D40F0", Slot = "23")]
		public bool SetBaseSkinCullingMask(ZQRJPWYXNPA.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x97D5830", Offset = "0x97D4830", VA = "0x1897D5830", Slot = "39")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x97D6A50", Offset = "0x97D5A50", VA = "0x1897D6A50")]
		public void VWNDPNXMBAM(float a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x97CBAF0", Offset = "0x97CAAF0", VA = "0x1897CBAF0")]
		private static bool CCLKFUAUIXF(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x97D6940", Offset = "0x97D5940", VA = "0x1897D6940", Slot = "40")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties materialProperties, TextureEffectMaterialTextures materialTextures)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x97CCC30", Offset = "0x97CBC30", VA = "0x1897CCC30")]
		private static bool EXSJDXFEFZZ(AvatarMaterialKey a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x97CDC40", Offset = "0x97CCC40", VA = "0x1897CDC40")]
		public void HURWFPEPGPE(TextureEffectMaterialProperties a, TextureEffectMaterialTextures b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x97CDE60", Offset = "0x97CCE60", VA = "0x1897CDE60", Slot = "38")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x97CE7F0", Offset = "0x97CD7F0", VA = "0x1897CE7F0")]
		private void IUERFVNQEZJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x97CB2D0", Offset = "0x97CA2D0", VA = "0x1897CB2D0")]
		private void BJXMZQVEMOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3726180", Offset = "0x3725180", VA = "0x183726180")]
		public static void XZLMPQNAVWO<a>(Dictionary<a, Material> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x97CACF0", Offset = "0x97C9CF0", VA = "0x1897CACF0")]
		private static void APUUOIZKZXK(Dictionary<Renderer, IMXEHHBCYAF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x97D6DE0", Offset = "0x97D5DE0", VA = "0x1897D6DE0")]
		public static void VZJNRKLSNVD(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x97D1AB0", Offset = "0x97D0AB0", VA = "0x1897D1AB0")]
		public static void MBFCFOCTCTC(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x97D3F20", Offset = "0x97D2F20", VA = "0x1897D3F20")]
		public static void SOLKCHDAFJK(List<GZZZBPLOCOP> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x97CF2F0", Offset = "0x97CE2F0", VA = "0x1897CF2F0")]
		private void KHYYUCUFOAP(Dictionary<string, VDJWASGHCNG<Texture2D>> a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x97D69D0", Offset = "0x97D59D0", VA = "0x1897D69D0")]
		private void VGUQFWWMMXE(Dictionary<string, List<AvatarMaterialKey>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x97D4E40", Offset = "0x97D3E40", VA = "0x1897D4E40")]
		private void TGEGJBNAQAQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x97D3830", Offset = "0x97D2830", VA = "0x1897D3830")]
		private void OZTMWTGQNZO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x97CD530", Offset = "0x97CC530", VA = "0x1897CD530")]
		private void GWETQZPFAGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x97CA6D0", Offset = "0x97C96D0", VA = "0x1897CA6D0")]
		private void AEDRBHASNDH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x97CC2A0", Offset = "0x97CB2A0", VA = "0x1897CC2A0")]
		private void EDXWJEFRPLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x97CB760", Offset = "0x97CA760", VA = "0x1897CB760")]
		private void BVOZGLGKRLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x97CAF00", Offset = "0x97C9F00", VA = "0x1897CAF00")]
		private void AWDSCFIHKHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x97CDAF0", Offset = "0x97CCAF0", VA = "0x1897CDAF0")]
		private void GZBHCQOMCHO(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x97D8080", Offset = "0x97D7080", VA = "0x1897D8080")]
		private void ZXCVZWOZMWZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x97D7FB0", Offset = "0x97D6FB0", VA = "0x1897D7FB0")]
		private void ZFFXJXQNGCW(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x97D7C90", Offset = "0x97D6C90", VA = "0x1897D7C90")]
		private void YZMEHEPQOEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x97CBBE0", Offset = "0x97CABE0", VA = "0x1897CBBE0")]
		private void CGHWVCXIFQJ(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x97D7610", Offset = "0x97D6610", VA = "0x1897D7610")]
		private void WWHSXGYIDAZ(Material a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x97CEDD0", Offset = "0x97CDDD0", VA = "0x1897CEDD0")]
		private void JFFIKPJNKWN(Material a, Color b, Texture2D c, Color? d, float? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x97D7790", Offset = "0x97D6790", VA = "0x1897D7790")]
		private void XIGZTFUNSXS(Material a, Color b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x97D3620", Offset = "0x97D2620", VA = "0x1897D3620")]
		private void OWYSVQESBMP(Material a, Texture2D b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x97D56C0", Offset = "0x97D46C0", VA = "0x1897D56C0")]
		private void UYCQNKWVXYV(Material a, Texture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x97D4CE0", Offset = "0x97D3CE0", VA = "0x1897D4CE0")]
		private void TDXNQMWSXZH(Action<IMXEHHBCYAF> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x97CB970", Offset = "0x97CA970", VA = "0x1897CB970")]
		private void CAIZKZNFYKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x97D6F30", Offset = "0x97D5F30", VA = "0x1897D6F30")]
		private void WEZSFBMAPOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x97D52F0", Offset = "0x97D42F0", VA = "0x1897D52F0")]
		private void URVZPJWAACH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x97CCC50", Offset = "0x97CBC50", VA = "0x1897CCC50")]
		public void FNSWGMYESFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x97D3460", Offset = "0x97D2460", VA = "0x1897D3460", Slot = "4")]
		private void NLQVMHEVBCG([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x97D17D0", Offset = "0x97D07D0", VA = "0x1897D17D0", Slot = "5")]
		private void KNMDDYSUAWB([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x97CD000", Offset = "0x97CC000", VA = "0x1897CD000")]
		[CompilerGenerated]
		private UXDBKRJQXAW FOUBVAYJEKN(CEQNQOATLVM a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x97CC430", Offset = "0x97CB430", VA = "0x1897CC430")]
		[CompilerGenerated]
		private void ENHFKXIBDIS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x97CC530", Offset = "0x97CB530", VA = "0x1897CC530")]
		[CompilerGenerated]
		private void ENRTFKVVWFK(IMXEHHBCYAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x97CC4B0", Offset = "0x97CB4B0", VA = "0x1897CC4B0")]
		[CompilerGenerated]
		private void ENMMIEBYMUB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x97CC550", Offset = "0x97CB550", VA = "0x1897CC550")]
		[CompilerGenerated]
		private void ENXACRPTFQT(IMXEHHBCYAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x97CC330", Offset = "0x97CB330", VA = "0x1897CC330")]
		[CompilerGenerated]
		private void EMWRQJUGKMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x97CCB40", Offset = "0x97CBB40", VA = "0x1897CCB40")]
		[CompilerGenerated]
		private void EOXIOZLGAVM(IMXEHHBCYAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x97CC3B0", Offset = "0x97CB3B0", VA = "0x1897CC3B0")]
		[CompilerGenerated]
		private void ENBYNQODTXJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x97CCB70", Offset = "0x97CBB70", VA = "0x1897CCB70")]
		[CompilerGenerated]
		private void EPCPMGFDKGV(IMXEHHBCYAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x97CC570", Offset = "0x97CB570", VA = "0x1897CC570")]
		[CompilerGenerated]
		private void EOCGZYJQPCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x97CB8E0", Offset = "0x97CA8E0", VA = "0x1897CB8E0")]
		[CompilerGenerated]
		private void BXZSVYPEGLV(IMXEHHBCYAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x97CC5F0", Offset = "0x97CB5F0", VA = "0x1897CC5F0")]
		[CompilerGenerated]
		private void EOHNXFDNYNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x97CB8B0", Offset = "0x97CA8B0", VA = "0x1897CB8B0")]
		[CompilerGenerated]
		private void BXULYRVGXAM(IMXEHHBCYAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x97CDBC0", Offset = "0x97CCBC0", VA = "0x1897CDBC0")]
		[CompilerGenerated]
		private void HAIDYZDWAWM(KeyValuePair<string, VDJWASGHCNG<Texture2D>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x97CAE40", Offset = "0x97C9E40", VA = "0x1897CAE40")]
		[CompilerGenerated]
		private void AQBVDEMCRIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x97D6A20", Offset = "0x97D5A20", VA = "0x1897D6A20")]
		[CompilerGenerated]
		private void VRIXEJAGPQD(IMXEHHBCYAF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x97CC1E0", Offset = "0x97CB1E0", VA = "0x1897CC1E0")]
		[CompilerGenerated]
		private void DHAXXKZYLVO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x97CC1B0", Offset = "0x97CB1B0", VA = "0x1897CC1B0")]
		[CompilerGenerated]
		private void DEPMNNJJHAO(IMXEHHBCYAF a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, WWAUVEVWRHD
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
		private Vector3? CSGYDCEODDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private bool HCDLZRUYTSY;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x97E0880", Offset = "0x97DF880", VA = "0x1897E0880", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x97E0EB0", Offset = "0x97DFEB0", VA = "0x1897E0EB0", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xDCC340", Offset = "0xDCB340", VA = "0x180DCC340", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x97E0960", Offset = "0x97DF960", VA = "0x1897E0960")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x97E12D0", Offset = "0x97E02D0", VA = "0x1897E12D0")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, WWAUVEVWRHD
	{
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private const float MKGIDGLSIEU = 45f;

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
		private Vector3 SLLORKNFVID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private Vector3 JCXURSHWRTY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private bool HCDLZRUYTSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private float BLRSYKTQFAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private float SYXBNGCEPLT;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x97E1660", Offset = "0x97E0660", VA = "0x1897E1660", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xFA9B50", Offset = "0xFA8B50", VA = "0x180FA9B50", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x97E1380", Offset = "0x97E0380", VA = "0x1897E1380")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x97E2120", Offset = "0x97E1120", VA = "0x1897E2120")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class CJSRHFOTYXP : AIVOINEFDMQ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private static readonly int EBVKSXBGTOV;

		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private static readonly int EFHVTFJRXRU;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly int OOVNSRVMTGZ;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly int HQUFVOPBNAB;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private static readonly int LMEYATYFNCH;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly int CJSRYMDBAGZ;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private static readonly int RVPHZXOBRND;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private static readonly int LSOMITPPJTB;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private static readonly int RDALIJYDKUP;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly int CLGZEWERFIC;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly int GHXZGDMMUQY;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static readonly int SKWCMFTHCRQ;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static readonly int WSWQWYROMHO;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static readonly int QQDPYTGQOIG;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static readonly int INYLLEETEBG;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static readonly int CRXUNSSDKDA;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private static readonly int EUPMKZJECSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private Transform JDXNLQKBJDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private Transform OONBXTATFXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private Transform CZQOACZMSPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private Transform YCETOLNVZSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Transform FCKJRTQBGBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private Transform EMNFFRHBSBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private AvatarFaceDisplayInitState ZCVPTZBVHHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private Material RUEPAFQRFSE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private SkinnedMeshRenderer[] PJLYQSCMNXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private readonly List<Material> MNRLUGVYJTC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private KVBUIVKABDY BDLPSSFANNH;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public FYRDCSIKYKI KSQXTONOXLA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private KVBUIVKABDY LRCKJCTWZOS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x97EA9C0", Offset = "0x97E99C0", VA = "0x1897EA9C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x97EA490", Offset = "0x97E9490", VA = "0x1897EA490", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x97EA2B0", Offset = "0x97E92B0", VA = "0x1897EA2B0")]
		public void Initialize([In] AvatarFaceDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x97E9C00", Offset = "0x97E8C00", VA = "0x1897E9C00")]
		public void BRQTPRNEFMW([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x97E9D70", Offset = "0x97E8D70", VA = "0x1897E9D70", Slot = "6")]
		public void GJKINOXFTET(AvatarFaceDisplayUpdateFeatureSelectionState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x97E9D10", Offset = "0x97E8D10", VA = "0x1897E9D10")]
		private Vector2 FHYIWUHMVCH(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x97EAA40", Offset = "0x97E9A40", VA = "0x1897EAA40")]
		public void ZGLEPLEUXNT([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x97EA5F0", Offset = "0x97E95F0", VA = "0x1897EA5F0")]
		private void SYJECXOVGRM(FaceFeaturesInUVSpace a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x97E98F0", Offset = "0x97E88F0", VA = "0x1897E98F0")]
		private void APUIDTRDIWA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x97E9CA0", Offset = "0x97E8CA0", VA = "0x1897E9CA0")]
		private void EDFWZJMVYCK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x97E9CA0", Offset = "0x97E8CA0", VA = "0x1897E9CA0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x97EBC40", Offset = "0x97EAC40", VA = "0x1897EBC40")]
		public CJSRHFOTYXP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x97E9C00", Offset = "0x97E8C00", VA = "0x1897E9C00", Slot = "5")]
		private void TEHDECCRYHF([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x97EA5E0", Offset = "0x97E95E0", VA = "0x1897EA5E0", Slot = "7")]
		private void PBJNFCNJLFY([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x97EA2A0", Offset = "0x97E92A0", VA = "0x1897EA2A0")]
		[CompilerGenerated]
		internal static float HLKKWRLUETV(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x97EA3A0", Offset = "0x97E93A0", VA = "0x1897EA3A0")]
		[CompilerGenerated]
		internal static void JTVEQNJTIZU(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x97EA360", Offset = "0x97E9360", VA = "0x1897EA360")]
		[CompilerGenerated]
		internal static Vector4 JGADILFXKRJ(Vector2 a, Vector2 b)
		{
			return default(Vector4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class AvatarForearmRollController : MonoBehaviour, WWAUVEVWRHD
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
		private float BLRSYKTQFAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private bool HCDLZRUYTSY;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x97E2150", Offset = "0x97E1150", VA = "0x1897E2150", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xCFCB50", Offset = "0xCFBB50", VA = "0x180CFCB50", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x97E29C0", Offset = "0x97E19C0", VA = "0x1897E29C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
		private Dictionary<int, int> XKDMBONZNOY;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x97E29F0", Offset = "0x97E19F0", VA = "0x1897E29F0")]
		public void KWSQHQMQIDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x97E2B00", Offset = "0x97E1B00", VA = "0x1897E2B00")]
		public int ZQMRWLMOCCQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class IPVEYGAIQZT : CXRZZMMNSLQ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x97F0F60", Offset = "0x97EFF60", VA = "0x1897F0F60", Slot = "24")]
		public override float EBFIEWKKZIR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x97F0FB0", Offset = "0x97EFFB0", VA = "0x1897F0FB0")]
		public IPVEYGAIQZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class CXRZZMMNSLQ : WYAYCZTEQEU
	{
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		private static int JJWRRONYCTX;

		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static int ZVZNEQOHZVX;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static int HPAVLOIQLUN;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static int HVMIABDJMQE;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static int RSRBEEYXUIG;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static int BYBIRWZVQKP;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static int IYNJTIGVSTH;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static int[] AHPHQVQDDCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		private AvatarHandDisplayInitState ZCVPTZBVHHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private AvatarHandDisplaySetupState CDELWTSGDNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private int MZRRKBJTIVW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private float IUHACTJGJPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		protected Animator TTQCHSUMUCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		protected AvatarConfiguration RVRVXUJADCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		protected int XAQOXTABIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		private int TYMPIVHCTSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private int UBIHAEJOPGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private bool SPPTJTLRASY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private HandAnimationOverrideState VXUNVZOJGXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private int PNNUPKQQCXN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private float DQBKHOJYGQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private AvatarHandDisplaySettings LITOXAVRPZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private AvatarBodyType NHAKYIYLBHB;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Transform QZDBYCHQZNN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xCF4160", Offset = "0xCF3160", VA = "0x180CF4160")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector3 KXDKOUSWRLR
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x19C8E30", Offset = "0x19C7E30", VA = "0x1819C8E30")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x19C8E00", Offset = "0x19C7E00", VA = "0x1819C8E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Quaternion NLFXFCZWXYE
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xE839A0", Offset = "0xE829A0", VA = "0x180E839A0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xE83820", Offset = "0xE82820", VA = "0x180E83820")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool RZTQYOJXEEM
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x97EC330", Offset = "0x97EB330", VA = "0x1897EC330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x97EC360", Offset = "0x97EB360", VA = "0x1897EC360")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool UVHQWPDHMZX
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD06EC0", Offset = "0xD05EC0", VA = "0x180D06EC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 ZPJBWRXJAPG
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x1497C90", Offset = "0x1496C90", VA = "0x181497C90", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x1493EC0", Offset = "0x1492EC0", VA = "0x181493EC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Quaternion OAVPDTSHZEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x12BF610", Offset = "0x12BE610", VA = "0x1812BF610", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x97EC390", Offset = "0x97EB390", VA = "0x1897EC390")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HandVisualState ZOZWEHKJHJR
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x10C8D00", Offset = "0x10C7D00", VA = "0x1810C8D00", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x10C77C0", Offset = "0x10C67C0", VA = "0x1810C77C0", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public HandVisualState MPBEYEOQDHQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x12D4580", Offset = "0x12D3580", VA = "0x1812D4580", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x21943A0", Offset = "0x21933A0", VA = "0x1821943A0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float FLEBWYPHNSG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x1560540", Offset = "0x155F540", VA = "0x181560540", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x10C88E0", Offset = "0x10C78E0", VA = "0x1810C88E0", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool SWAAIANVACC
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x256C890", Offset = "0x256B890", VA = "0x18256C890", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x256C8E0", Offset = "0x256B8E0", VA = "0x18256C8E0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool HTFLPEYQTPS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x97EBDC0", Offset = "0x97EADC0", VA = "0x1897EBDC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool ZBBIGWFBRKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x97EC160", Offset = "0x97EB160", VA = "0x1897EC160")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool FWQWKSCLWVM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x97EBDD0", Offset = "0x97EADD0", VA = "0x1897EBDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool WVYCYVKLKMS
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x97EBDE0", Offset = "0x97EADE0", VA = "0x1897EBDE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x97EBDF0", Offset = "0x97EADF0", VA = "0x1897EBDF0", Slot = "23")]
		public void Initialize(AvatarHandDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x97EBF90", Offset = "0x97EAF90", VA = "0x1897EBF90")]
		public void JEKFUGORJMH(AvatarHandDisplaySetupState a, AvatarHandDisplaySettings b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x97EBFE0", Offset = "0x97EAFE0", VA = "0x1897EBFE0", Slot = "14")]
		public void MEFVWEDAIQY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x97EC3A0", Offset = "0x97EB3A0", VA = "0x1897EC3A0", Slot = "13")]
		public void UJSUGMYJJMY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x1560540", Offset = "0x155F540", VA = "0x181560540", Slot = "24")]
		public virtual float EBFIEWKKZIR()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x97EC720", Offset = "0x97EB720", VA = "0x1897EC720")]
		private int XRSBTTRHWFU(HandVisualState a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x97EC170", Offset = "0x97EB170", VA = "0x1897EC170")]
		private void QKPZKXHGUQE(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x97EC0F0", Offset = "0x97EB0F0", VA = "0x1897EC0F0", Slot = "15")]
		public bool PJYYYUZELDK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x97EC0E0", Offset = "0x97EB0E0", VA = "0x1897EC0E0", Slot = "16")]
		public bool OYVEUGDZJJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x97EC090", Offset = "0x97EB090", VA = "0x1897EC090")]
		private HandVisualState OIEEJQFNZLP()
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1826810", Offset = "0x1825810", VA = "0x181826810", Slot = "17")]
		public void QPIKWHBFWTT(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x97EBD80", Offset = "0x97EAD80", VA = "0x1897EBD80", Slot = "12")]
		public void ABRRHWZUBWK(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x97EC070", Offset = "0x97EB070", VA = "0x1897EC070", Slot = "10")]
		public void MFPBILTPRXK(HandAnimationOverrideState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x97EC710", Offset = "0x97EB710", VA = "0x1897EC710", Slot = "11")]
		public void WBBDATLAWKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x97EC110", Offset = "0x97EB110", VA = "0x1897EC110", Slot = "18")]
		public void POMJXVOTDUC(Transform a, Vector3 b, Quaternion c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x97ECB80", Offset = "0x97EBB80", VA = "0x1897ECB80")]
		public CXRZZMMNSLQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class ZIQDTJWNQUK : CEQNQOATLVM
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class FEFOLURSPJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000232")]
			public ZIQDTJWNQUK NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public List<GZZZBPLOCOP> ZEAFFQHVMSX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public List<GZZZBPLOCOP> CXZWXHCOALE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public VDJWASGHCNG<Material[]> GQIUUZBHQXI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public VDJWASGHCNG<LoadedAvatarItemPrefabHolder> BYGOWVKDLFM;

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public FEFOLURSPJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x97ED4C0", Offset = "0x97EC4C0", VA = "0x1897ED4C0")]
			internal UXDBKRJQXAW DDASFRLPDJZ(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		public UZMMDXOYMGN UZMMDXOYMGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		public LoadedAvatarItemPrefabHolder IGZTKTTDQSZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		private VDJWASGHCNG<LoadedAvatarItemPrefabHolder> EZLSNXMJOYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private VDJWASGHCNG<Material[]> GQIUUZBHQXI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		public Material[] ZAHKPZCMCQX;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool XDXOCDRZTKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xD22900", Offset = "0xD21900", VA = "0x180D22900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xD22910", Offset = "0xD21910", VA = "0x180D22910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ZQRJPWYXNPA.SkinCullingMask BQDXVIYBEUE
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF3350", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return default(ZQRJPWYXNPA.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xFC9E90", Offset = "0xFC8E90", VA = "0x180FC9E90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x97F5000", Offset = "0x97F4000", VA = "0x1897F5000")]
		public ZIQDTJWNQUK(ItemDefinitionBodyPart a, UZMMDXOYMGN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x97F4740", Offset = "0x97F3740", VA = "0x1897F4740", Slot = "6")]
		public override UXDBKRJQXAW UDISKTQPLUK(List<GZZZBPLOCOP> a, List<GZZZBPLOCOP> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x97F43F0", Offset = "0x97F33F0", VA = "0x1897F43F0")]
		public UXDBKRJQXAW TBUKWXBAYWX(List<GZZZBPLOCOP> a, List<GZZZBPLOCOP> b, VDJWASGHCNG<Material[]> c, [Optional] VDJWASGHCNG<LoadedAvatarItemPrefabHolder> d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x97F4C00", Offset = "0x97F3C00", VA = "0x1897F4C00")]
		public (VDJWASGHCNG<Material[]>, VDJWASGHCNG<LoadedAvatarItemPrefabHolder>) ZZTVGCCDHQF(List<GZZZBPLOCOP> a, List<GZZZBPLOCOP> b)
		{
			return default((VDJWASGHCNG<Material[]>, VDJWASGHCNG<LoadedAvatarItemPrefabHolder>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x97F4130", Offset = "0x97F3130", VA = "0x1897F4130", Slot = "7")]
		public override ITEZXNHVTZE IMBECJIXILD(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x97F3F30", Offset = "0x97F2F30", VA = "0x1897F3F30")]
		public ITEZXNHVTZE GFEQMKWAYXS(GameObject a, uint b, bool c, bool d, AvatarSkinnedMeshBoneOrderRemapsData e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x97F3BC0", Offset = "0x97F2BC0", VA = "0x1897F3BC0")]
		public static bool EJBRAOLYIJX(Renderer[] a, string b, [Out] Renderer c, [Out] Renderer d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x97F46F0", Offset = "0x97F36F0", VA = "0x1897F46F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x97F4330", Offset = "0x97F3330", VA = "0x1897F4330")]
		private (VDJWASGHCNG<LoadedAvatarItemPrefabHolder>, VDJWASGHCNG<Material[]>) QEBONTMVGDT()
		{
			return default((VDJWASGHCNG<LoadedAvatarItemPrefabHolder>, VDJWASGHCNG<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x97F4BE0", Offset = "0x97F3BE0", VA = "0x1897F4BE0")]
		[CompilerGenerated]
		private void ZOGYEYDCUOD(LoadedAvatarItemPrefabHolder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xCF7B80", Offset = "0xCF6B80", VA = "0x180CF7B80")]
		[CompilerGenerated]
		private void ZOBRHRJFLCU(Material[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class AvatarKneeBendTargetController : MonoBehaviour, WWAUVEVWRHD
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
		private Vector3 SLLORKNFVID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private Vector3 FKPOIIVPJYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private Vector3 ZPQAKJVETFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private Matrix4x4 ECKKLOGSZUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private bool HCDLZRUYTSY;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x97E2FD0", Offset = "0x97E1FD0", VA = "0x1897E2FD0", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x97E2FC0", Offset = "0x97E1FC0", VA = "0x1897E2FC0", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x97E2B70", Offset = "0x97E1B70", VA = "0x1897E2B70")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x97E3690", Offset = "0x97E2690", VA = "0x1897E3690")]
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
		[Cpp2IlInjected.Address(RVA = "0x97E65F0", Offset = "0x97E55F0", VA = "0x1897E65F0", Slot = "4")]
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
		public int DCSCRZYIGHK
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x97E3EE0", Offset = "0x97E2EE0", VA = "0x1897E3EE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x97E3F10", Offset = "0x97E2F10", VA = "0x1897E3F10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public int ARKLYUDVSYW
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x97E3A30", Offset = "0x97E2A30", VA = "0x1897E3A30")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x97E3EF0", Offset = "0x97E2EF0", VA = "0x1897E3EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int YPEVNLREUKY
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x97E36A0", Offset = "0x97E26A0", VA = "0x1897E36A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x97E3F00", Offset = "0x97E2F00", VA = "0x1897E3F00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x97E40E0", Offset = "0x97E30E0", VA = "0x1897E40E0")]
		public AvatarLegacyCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x97E3A40", Offset = "0x97E2A40", VA = "0x1897E3A40")]
		public void IPXJMSCMLNO(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x97E3F20", Offset = "0x97E2F20", VA = "0x1897E3F20")]
		public void WAXJDVHTGBY(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x97E3AB0", Offset = "0x97E2AB0", VA = "0x1897E3AB0")]
		public Color JBHREGIOSIX(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x97E40C0", Offset = "0x97E30C0", VA = "0x1897E40C0")]
		public void ZDYPSENWLDR(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x97E39E0", Offset = "0x97E29E0", VA = "0x1897E39E0")]
		public void FADZURZGUPB(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x97E3820", Offset = "0x97E2820", VA = "0x1897E3820")]
		public void DSAFILXMVXQ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x97E3AD0", Offset = "0x97E2AD0", VA = "0x1897E3AD0")]
		public bool KCWPVYTSXDV(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x97E36B0", Offset = "0x97E26B0", VA = "0x1897E36B0")]
		public void DIQQVNFXGMN(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x97E3770", Offset = "0x97E2770", VA = "0x1897E3770")]
		public int[] DOCDLFQTHDH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x97E3B00", Offset = "0x97E2B00", VA = "0x1897E3B00")]
		private NativeSlice<int> KPIGKYKGYQS(int a)
		{
			return default(NativeSlice<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x97E3830", Offset = "0x97E2830", VA = "0x1897E3830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x97E3B90", Offset = "0x97E2B90", VA = "0x1897E3B90")]
		public Mesh NCPTIUAOFPM([Optional] string a)
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
		public int IWTGKFXUEGA
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xF584A0", Offset = "0xF574A0", VA = "0x180F584A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int MIBQATFYZPE
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xD92F00", Offset = "0xD91F00", VA = "0x180D92F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int WQILUPKWMLF
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x97E4550", Offset = "0x97E3550", VA = "0x1897E4550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int EYRAGCYGQMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x97E4910", Offset = "0x97E3910", VA = "0x1897E4910")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x97E4930", Offset = "0x97E3930", VA = "0x1897E4930")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public int DCSCRZYIGHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x97E4900", Offset = "0x97E3900", VA = "0x1897E4900")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x97E4920", Offset = "0x97E3920", VA = "0x1897E4920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int PRMLTTITKMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x97E4540", Offset = "0x97E3540", VA = "0x1897E4540")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x97E48E0", Offset = "0x97E38E0", VA = "0x1897E48E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public MeshMergeModes OXPRKCSEVSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x97E48F0", Offset = "0x97E38F0", VA = "0x1897E48F0")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x97E4580", Offset = "0x97E3580", VA = "0x1897E4580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public byte THRWAUKCPRR
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x97E4940", Offset = "0x97E3940", VA = "0x1897E4940")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x97E48D0", Offset = "0x97E38D0", VA = "0x1897E48D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public AvatarLegacyCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x97E60C0", Offset = "0x97E50C0", VA = "0x1897E60C0")]
			get
			{
				return default(AvatarLegacyCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x97E4950", Offset = "0x97E3950", VA = "0x1897E4950")]
		public AvatarLegacyCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x97E4800", Offset = "0x97E3800", VA = "0x1897E4800")]
		public AvatarLegacyCullAndCombineMeshJobContainer GOMXJEJRBRY(Allocator a)
		{
			return default(AvatarLegacyCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x97E4590", Offset = "0x97E3590", VA = "0x1897E4590", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[Tested]
	public class VHYTMCQENJK : EVERSYEAYIC
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x97F3300", Offset = "0x97F2300", VA = "0x1897F3300")]
		public AvatarLegacyCullAndCombineMeshJobGroup JLMFGOPPTYO()
		{
			return default(AvatarLegacyCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x97DF5C0", Offset = "0x97DE5C0", VA = "0x1897DF5C0")]
		public VHYTMCQENJK()
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
		[Cpp2IlInjected.Address(RVA = "0x97E7AA0", Offset = "0x97E6AA0", VA = "0x1897E7AA0")]
		public AvatarMaterialKey(Material material, UpdatableColorType updatableColorType, UpdatableTextureType updatableTextureType, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x97E7800", Offset = "0x97E6800", VA = "0x1897E7800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x97E7570", Offset = "0x97E6570", VA = "0x1897E7570", Slot = "4")]
		public bool Equals(AvatarMaterialKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x97E7600", Offset = "0x97E6600", VA = "0x1897E7600", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x97E7700", Offset = "0x97E6700", VA = "0x1897E7700", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, WGLTLEWCJPM
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
		private RHGOFRPLRDZ LXVHSAFNCWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private AIVOINEFDMQ EOCTZMLTTGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private WYAYCZTEQEU MPECKYMHLIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private WYAYCZTEQEU ESIWMFXFPGV;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public RHGOFRPLRDZ DKZKZDSMAHQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x97E8CB0", Offset = "0x97E7CB0", VA = "0x1897E8CB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public AIVOINEFDMQ IDVCXKIDCOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x97E8D00", Offset = "0x97E7D00", VA = "0x1897E8D00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public WYAYCZTEQEU LDBZIPVZTQV
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x97E8D50", Offset = "0x97E7D50", VA = "0x1897E8D50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public WYAYCZTEQEU PPSNOEIFXRO
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x97E8DA0", Offset = "0x97E7DA0", VA = "0x1897E8DA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Transform DIGBFXZAUYO
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x97E8DF0", Offset = "0x97E7DF0", VA = "0x1897E8DF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public AvatarBodyType PNOOXXARWWT
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xD24DA0", Offset = "0xD23DA0", VA = "0x180D24DA0", Slot = "12")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x97E7BE0", Offset = "0x97E6BE0", VA = "0x1897E7BE0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x97E84D0", Offset = "0x97E74D0", VA = "0x1897E84D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x97E8490", Offset = "0x97E7490", VA = "0x1897E8490", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x97E84D0", Offset = "0x97E74D0", VA = "0x1897E84D0", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x97E7C20", Offset = "0x97E6C20", VA = "0x1897E7C20", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x97E8880", Offset = "0x97E7880", VA = "0x1897E8880")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x97E8BE0", Offset = "0x97E7BE0", VA = "0x1897E8BE0")]
		private void XCQSJXBBQPG(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x97E8060", Offset = "0x97E7060", VA = "0x1897E8060")]
		private RHGOFRPLRDZ FLWTZOTLOOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x97E8580", Offset = "0x97E7580", VA = "0x1897E8580")]
		private AIVOINEFDMQ RRFPXSQUOZY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x97E8960", Offset = "0x97E7960", VA = "0x1897E8960")]
		private WYAYCZTEQEU VEDNRHJJRBA(HandType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x97E8CA0", Offset = "0x97E7CA0", VA = "0x1897E8CA0")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class IMXEHHBCYAF : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private MaterialPropertyBlock GTQEBGICFZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		public Color? KXINXWTLBNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public Color? WCMAQBZPSML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public Color? MSNEWNREKUJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Color? NRYQPHUNGLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Color ADRDVMEWILR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public Color ZBDPXRXGNMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public Color BPDDRWMQIIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public Color? OVLTTRBPUTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public Texture2D DLGBUHJLPPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public float? KYLNKVCBPST;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public float CIHGYBMDVXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public Texture2D MKHLSFLLUVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Texture2D KPQWOSZFTTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		private Dictionary<AvatarMaterialKey, int> URAPJGWMDKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private UpdatableColorType[] YNUMDYAYHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private UpdatableTextureType[] SENKXXKIPUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		public Vector4[] FTCNUDQWFMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Vector4[] LIIUZEHCBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public Vector4[] MSATTTNCJVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public Vector4[] TODXSSPPLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public Vector4[] TUEDQFCZIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public Vector4[] QSWHGBYCHXP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		private List<Texture2D> DTCTRWIULQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private Vector4[] KDWTDQLIRIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private List<Texture2D> VYLNRNZSTRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private float[] TKPTUWWJKMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private Vector4[] XRXAHQQBOHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private float[] GGOPTHTJOAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		public float[] IMYGBELGXHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		private List<Texture2D> TMLBODCIDWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private float[] KCQWIXISBNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private List<Texture2D> TQUMPNOMWLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private Vector4[] EPCLFYVIAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private float[] JXYKTBCFMOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private Vector4[] YXIJLHJXYLS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		public float[] PQBXWVNVMOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public Texture2DArray JXGHPQIYZAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public Texture2DArray KJVDPDDNKDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public Texture2DArray QNHYQQDAKCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public Texture2DArray WHQDNBUKGDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		private bool FKTNRHKTXGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private int IZRSENMJFTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private Vector2? CUHDGBUURWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private TextureFormat OIQDUQJXHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private Vector2? RODODUKYHWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private TextureFormat LHJCBAPUIHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private Vector2? NIFUSIZMISB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private TextureFormat MHPDVHJBPUD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private Vector2? LFIQYJRLSMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private TextureFormat ASSYQALJEWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private bool BBOLEABAMSV;

		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private static int MICAJVQRDGT;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private static int VJPATBTWKSN;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private static int ETFRJJCPXNH;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static int RGZXXTWVOBA;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static int MTBLZWGPYUT;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static int ZARTZCOEGTG;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private static int GJJMYHQCJAJ;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private static int GIEHOLAVKYK;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private static int KSPGGRAHSAW;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private static int RCTUKVEDPKH;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private static int CMINWFWEFLT;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private static int DCXQKOMDIKZ;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private static int HETLCAHAJFN;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private static int NLSMFMGUSOJ;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private static int KAOXXLXLGCS;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private static int RORSFQYGBQK;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private static int DBTLXJUADMK;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private static int KYCMEKKLWPT;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private static int VSOSZTKUXZN;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private static int BNMAKWOVCCM;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x97F0AA0", Offset = "0x97EFAA0", VA = "0x1897F0AA0")]
		private IMXEHHBCYAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x97F09E0", Offset = "0x97EF9E0", VA = "0x1897F09E0")]
		public IMXEHHBCYAF(Color a, Color b, Color c, Color? d, Color? e, Color? f, Texture2D g, Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x97EE370", Offset = "0x97ED370", VA = "0x1897EE370")]
		internal int BUZDZEMFFDP(Material a, UpdatableColorType b, UpdatableTextureType c, AvatarBodyPart d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x97EE440", Offset = "0x97ED440", VA = "0x1897EE440")]
		private int BUZDZEMFFDP(AvatarMaterialKey a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x97EF7C0", Offset = "0x97EE7C0", VA = "0x1897EF7C0")]
		internal int SEWDNSHACUE(Material a, Color b, Color c, Color d, Color e, Color f, Texture2D g, Vector4 h, Texture2D i, Vector4 j, float k, float l, Texture2D m, Vector4 n, float o, Texture2D p, Color q, Vector4 r, UpdatableColorType s, UpdatableTextureType t, AvatarBodyPart u)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x97EE4D0", Offset = "0x97ED4D0", VA = "0x1897EE4D0")]
		private void DYAUTYQLRYH(List<Texture2D> a, [Out] Texture2DArray b, [Out] Texture2DArray c, [Out] Texture2DArray d, [Out] Texture2DArray e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x97EF510", Offset = "0x97EE510", VA = "0x1897EF510")]
		public void GBWMLKBAOUQ(Shader a, Renderer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x97EE6D0", Offset = "0x97ED6D0", VA = "0x1897EE6D0")]
		private void ESHZRQJGFDJ(Shader a, Renderer b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x97F0450", Offset = "0x97EF450", VA = "0x1897F0450")]
		private Color XYSYTSAEKFS(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x97EF3C0", Offset = "0x97EE3C0", VA = "0x1897EF3C0")]
		private Color FLCHPSXAWSU(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x97EF660", Offset = "0x97EE660", VA = "0x1897EF660")]
		private bool IACWUKMTEIR(Texture2D a, UpdatableTextureType b, [Out] Texture2D c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x97F03A0", Offset = "0x97EF3A0", VA = "0x1897F03A0")]
		private void VRJQYOCSORC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x97EE690", Offset = "0x97ED690", VA = "0x1897EE690", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class CEQNQOATLVM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000304")]
		public readonly ItemDefinitionBodyPart ZLWKVDUZEJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		protected bool PZGBLQYRZXP;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool DPZXFCQTPZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xD4AD80", Offset = "0xD49D80", VA = "0x180D4AD80")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xE0C750", Offset = "0xE0B750", VA = "0x180E0C750")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool LXKAYSRLZPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xE0B760", Offset = "0xE0A760", VA = "0x180E0B760")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xE0B750", Offset = "0xE0A750", VA = "0x180E0B750")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual ZQRJPWYXNPA.SkinCullingMask WOBSJZSDZRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ZQRJPWYXNPA.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xE01B00", Offset = "0xE00B00", VA = "0x180E01B00", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool CHYRWUFMSSK
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xD8C020", Offset = "0xD8B020", VA = "0x180D8C020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool QHLMIOASSVF
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x97E9650", Offset = "0x97E8650", VA = "0x1897E9650")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool YBKFAZNQKAS
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x97E94E0", Offset = "0x97E84E0", VA = "0x1897E94E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool XSUMNJPRZUR
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x97E9560", Offset = "0x97E8560", VA = "0x1897E9560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x97E96D0", Offset = "0x97E86D0", VA = "0x1897E96D0")]
		protected CEQNQOATLVM(ItemDefinitionBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract UXDBKRJQXAW UDISKTQPLUK(List<GZZZBPLOCOP> a, List<GZZZBPLOCOP> b);

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract ITEZXNHVTZE IMBECJIXILD(uint a, AvatarSkinnedMeshBoneOrderRemapsData b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class VIVKZIXFSQN : OGRXVHWBRTG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		private AvatarSkinAssetItem LLURKQEIXZF;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x97F3660", Offset = "0x97F2660", VA = "0x1897F3660")]
		public VIVKZIXFSQN(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, ItemDefinitionBodyPart c, [Optional] FaceFeatureId? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x97F3760", Offset = "0x97F2760", VA = "0x1897F3760")]
		public VIVKZIXFSQN(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, AvatarBodyPart c, ZQRJPWYXNPA.SkinCullingMask d, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x97F33F0", Offset = "0x97F23F0", VA = "0x1897F33F0", Slot = "6")]
		public override UXDBKRJQXAW UDISKTQPLUK(List<GZZZBPLOCOP> a, List<GZZZBPLOCOP> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class OBSPEMSYTLJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private static readonly int[] GZCQLPLOSIG;

		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly int[] SJHOWGNRYII;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public static int[] RFHEHVAQUSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x97F1220", Offset = "0x97F0220", VA = "0x1897F1220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x97F1100", Offset = "0x97F0100", VA = "0x1897F1100")]
		public static int[] GDGSNBCSYBM(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x97F1190", Offset = "0x97F0190", VA = "0x1897F1190")]
		public static int GMURBWCIBDP(UpdateLOD a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x97F1270", Offset = "0x97F0270", VA = "0x1897F1270")]
		private static int ZKHSQBGLLDN(UpdateLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x97F10E0", Offset = "0x97F00E0", VA = "0x1897F10E0")]
		private static int BJJOKGSGCSI(UpdateLOD a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class OVQCGNXQMUX
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class QTIAOMMNVTI : IEnumerator<BFNVKIYRTEQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000309")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private BFNVKIYRTEQ NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			public JobHandle SSRHZIQAGHK;

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			private BFNVKIYRTEQ NHKNBMQLZLJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public QTIAOMMNVTI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1555520", Offset = "0x1554520", VA = "0x181555520", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x97F1E40", Offset = "0x97F0E40", VA = "0x1897F1E40", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public static void CFXUKDGMFPD(string a, int b, long c, long d, long e, long f, long g, long h, long i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x97F1BD0", Offset = "0x97F0BD0", VA = "0x1897F1BD0")]
		public static TUMXXHBUICX USGNBZQNPRL(JobHandle a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x97F1B70", Offset = "0x97F0B70", VA = "0x1897F1B70")]
		[IteratorStateMachine(typeof(QTIAOMMNVTI))]
		private static IEnumerator<BFNVKIYRTEQ> HHABIUPRXIY(JobHandle a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class WMQSEYOGKRV
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
		public static readonly int DUKJZFNYVOP;

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly int UMJUXGHDRXW;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly int YJCGTLDRIWU;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly int RWAIJXZUNBL;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly int ZDXWAVKRMDU;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly int AHXODKXSUWQ;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly int FXEAMZIMDCW;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly int ZGBDWDHXUUF;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly int OJKHFXGMPHS;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly int WJSYSKUUJFL;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly int ZJSEHWCVUQL;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly int JWMPSSXZCNW;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly int SDTGGHVMZKF;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x97F38A0", Offset = "0x97F28A0", VA = "0x1897F38A0")]
		public static bool VZQHNJHZEVV(Material a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class OGRXVHWBRTG : CEQNQOATLVM
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class FEFOLURSPJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000323")]
			public VDJWASGHCNG<GameObject> ZUGUSPRMRYV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public OGRXVHWBRTG NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public Action<string> CTSYIVUDKAQ;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public FEFOLURSPJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x97ECFB0", Offset = "0x97EBFB0", VA = "0x1897ECFB0")]
			internal void DCVLIKRRTYQ(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x97ED380", Offset = "0x97EC380", VA = "0x1897ED380")]
			internal void DDASFRLPDJZ(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031D")]
		protected AvatarSkinAssetItem NVWPFOJOQAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected Material[] CODHRZYUGWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		private readonly AvatarSkinAssetItem.SkinBodyMeshType XIVEKFNBCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private readonly AssetReference OCKSSKNTQRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private readonly FaceFeatureId? ZXSKLLQXGWL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private SkinnedMeshRenderer[] YTAWEXHLIMC;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override ZQRJPWYXNPA.SkinCullingMask WOBSJZSDZRT
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xCFC320", Offset = "0xCFB320", VA = "0x180CFC320", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ZQRJPWYXNPA.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xCFC430", Offset = "0xCFB430", VA = "0x180CFC430", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x97F1840", Offset = "0x97F0840", VA = "0x1897F1840")]
		public OGRXVHWBRTG(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, ItemDefinitionBodyPart d, ZQRJPWYXNPA.SkinCullingMask e = (ZQRJPWYXNPA.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x97F1970", Offset = "0x97F0970", VA = "0x1897F1970")]
		public OGRXVHWBRTG(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, ZQRJPWYXNPA.SkinCullingMask d = (ZQRJPWYXNPA.SkinCullingMask)0L, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x97F1AD0", Offset = "0x97F0AD0", VA = "0x1897F1AD0")]
		public OGRXVHWBRTG(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material[] c, ItemDefinitionBodyPart d, ZQRJPWYXNPA.SkinCullingMask e = (ZQRJPWYXNPA.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x97F15E0", Offset = "0x97F05E0", VA = "0x1897F15E0", Slot = "6")]
		public override UXDBKRJQXAW UDISKTQPLUK(List<GZZZBPLOCOP> a, List<GZZZBPLOCOP> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x97F1380", Offset = "0x97F0380", VA = "0x1897F1380", Slot = "7")]
		public override ITEZXNHVTZE IMBECJIXILD(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x97F1570", Offset = "0x97F0570", VA = "0x1897F1570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x97F17F0", Offset = "0x97F07F0", VA = "0x1897F17F0")]
		protected void WTFDPATOYUG()
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
		[Cpp2IlInjected.Address(RVA = "0x97ED700", Offset = "0x97EC700", VA = "0x1897ED700")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface MYVERUYOFTS
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OCZNDJRKROU(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, ZQRJPWYXNPA.SkinCullingMask e = (ZQRJPWYXNPA.SkinCullingMask)0L, int f = -1, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void TIONHWXXXQS(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e);
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
		[Cpp2IlInjected.Address(RVA = "0x10E4A80", Offset = "0x10E3A80", VA = "0x1810E4A80")]
		public LoadedAvatarItemPrefabHolder(GameObject outfitObject, AvatarItemMaterial avatarItemMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x97F1050", Offset = "0x97F0050", VA = "0x1897F1050")]
		public void ANRLXYCAZGB(Material a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class CCWNWISQQLM : GDDZCQUXVYL<Task<(GameObject, AvatarItemMaterial)>, LoadedAvatarItemPrefabHolder>
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
			[Cpp2IlInjected.Address(RVA = "0x97F2A10", Offset = "0x97F1A10", VA = "0x1897F2A10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x97F2F10", Offset = "0x97F1F10", VA = "0x1897F2F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private VDJWASGHCNG<GameObject> CILVMGRTWQB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private VDJWASGHCNG<AvatarItemMaterial> EDUTMDXHLJR;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x97E9450", Offset = "0x97E8450", VA = "0x1897E9450")]
		private CCWNWISQQLM(Task<(GameObject, AvatarItemMaterial)> a, VDJWASGHCNG<GameObject> b, VDJWASGHCNG<AvatarItemMaterial> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x97E8E10", Offset = "0x97E7E10", VA = "0x1897E8E10")]
		public static CCWNWISQQLM Create(AssetReference outfitPrefabReference, [Optional] AssetReference combinationReference)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x97E9200", Offset = "0x97E8200", VA = "0x1897E9200", Slot = "11")]
		protected override LoadedAvatarItemPrefabHolder IHEUBIYOTFU(Task<(GameObject, AvatarItemMaterial)> a)
		{
			return default(LoadedAvatarItemPrefabHolder);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x97E93D0", Offset = "0x97E83D0", VA = "0x1897E93D0", Slot = "12")]
		protected override void YTMUBOVDQFZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x97E92A0", Offset = "0x97E82A0", VA = "0x1897E92A0")]
		[AsyncStateMachine(typeof(<WhenAllAvatarComponents>d__6))]
		private static Task<(GameObject, AvatarItemMaterial)> SRZHIQHZJBS(Task<GameObject> a, Task<AvatarItemMaterial> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class DYCUUCKQOKR
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		private class XOJPLTVZPQD : GDDZCQUXVYL<Task<MaterialMapAsset>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000340")]
			private VDJWASGHCNG<MaterialMapAsset> SSRHZIQAGHK;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x98106E0", Offset = "0x980F6E0", VA = "0x1898106E0")]
			public XOJPLTVZPQD(VDJWASGHCNG<MaterialMapAsset> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x9810230", Offset = "0x980F230", VA = "0x189810230", Slot = "11")]
			protected override Material[] IHEUBIYOTFU(Task<MaterialMapAsset> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9810680", Offset = "0x980F680", VA = "0x189810680", Slot = "12")]
			protected override void YTMUBOVDQFZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		private class RKTIWKKKYYR : GDDZCQUXVYL<Task<Material[]>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000345")]
			private List<VDJWASGHCNG<Material>> SZNJIHYMJUF;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x980B360", Offset = "0x980A360", VA = "0x18980B360")]
			public RKTIWKKKYYR(Task<Material[]> a, List<VDJWASGHCNG<Material>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x980B1D0", Offset = "0x980A1D0", VA = "0x18980B1D0", Slot = "11")]
			protected override Material[] IHEUBIYOTFU(Task<Material[]> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x980B220", Offset = "0x980A220", VA = "0x18980B220", Slot = "12")]
			protected override void YTMUBOVDQFZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400033F")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x97ECBA0", Offset = "0x97EBBA0", VA = "0x1897ECBA0")]
		public static VDJWASGHCNG<Material[]> AATPSAVFTJG(AssetReference[] a)
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
		protected class LPYUDGITEOR : IComparable<LPYUDGITEOR>, IEquatable<LPYUDGITEOR>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000399")]
			public int ZXNQXVAIDNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public PlayerAvatarDisplayBase RSPIWWGHEZK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public IList<AvatarItemSelection> BAQYEVTRWJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public AvatarItemBodyType YWWZWZVJXYI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public AvatarBuildType WDDCXBCFUMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public bool ZPANERAHXER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public bool NIHFVHOSPDU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public int[] NLJLRBVKVYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public float CVUUFVLHWUK;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x97F6030", Offset = "0x97F5030", VA = "0x1897F6030", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x97F5EE0", Offset = "0x97F4EE0", VA = "0x1897F5EE0", Slot = "4")]
			public int CompareTo(LPYUDGITEOR other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x97F5F10", Offset = "0x97F4F10", VA = "0x1897F5F10", Slot = "5")]
			public bool Equals(LPYUDGITEOR other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public LPYUDGITEOR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		protected abstract class CEQNQOATLVM
		{
			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public virtual bool DPZXFCQTPZW
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		protected class EMBJNBESGBW : CEQNQOATLVM
		{
			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public MSYSPFPFNBV YGDCJSOIJDG
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public class VICRJAYXVCT
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
			public static readonly int ZFFTXGQSQUD;

			[Cpp2IlInjected.Token(Token = "0x40003A4")]
			public static readonly int EAXOKHUPNGK;

			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public static readonly int QZPEAJFCZUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			protected readonly HandType CFYFYXQYOFR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected readonly ZJQJFOJAWPN NSELODYSRVT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected readonly Animator YZNWESBUDMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected readonly Transform CQBOQUSZOKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			public Vector3 VDHLRZCSSJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			protected readonly Transform ZXUFKNWOYRW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			public Vector3 DFGVMXUQNYG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			protected bool QPPLIQVQAPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected WYAYCZTEQEU NSZWQWOYLSB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected bool ZPRYCTUWNRY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected float SUCRFZTHPLM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected DBOGXFFQRGI<HandVisualState> GBGQFCLUETI;

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public WYAYCZTEQEU UYQALCYMMYK
			{
				[Cpp2IlInjected.Token(Token = "0x600032A")]
				[Cpp2IlInjected.Address(RVA = "0xCF7BB0", Offset = "0xCF6BB0", VA = "0x180CF7BB0")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xCF7E60", Offset = "0xCF6E60", VA = "0x180CF7E60")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool KDOBYPVDXJG
			{
				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x166C530", Offset = "0x166B530", VA = "0x18166C530")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x980F130", Offset = "0x980E130", VA = "0x18980F130")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool RLREUDTSQVP
			{
				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0xCFC310", Offset = "0xCFB310", VA = "0x180CFC310")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x980F060", Offset = "0x980E060", VA = "0x18980F060")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public float OVBOWRULWTB
			{
				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0xE0C730", Offset = "0xE0B730", VA = "0x180E0C730")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000331")]
				[Cpp2IlInjected.Address(RVA = "0x980F6F0", Offset = "0x980E6F0", VA = "0x18980F6F0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public HandVisualState CVAOGBCQVFS
			{
				[Cpp2IlInjected.Token(Token = "0x6000332")]
				[Cpp2IlInjected.Address(RVA = "0x980F2C0", Offset = "0x980E2C0", VA = "0x18980F2C0")]
				get
				{
					return default(HandVisualState);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x980EE30", Offset = "0x980DE30", VA = "0x18980EE30")]
			public bool ELZKUOHJIJM(HandVisualState a, object b, HandVisualStatePriority c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x980EC40", Offset = "0x980DC40", VA = "0x18980EC40")]
			public bool CPMZUMSSLYV(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x980F910", Offset = "0x980E910", VA = "0x18980F910")]
			protected VICRJAYXVCT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x980F990", Offset = "0x980E990", VA = "0x18980F990")]
			public VICRJAYXVCT(HandType a, WYAYCZTEQEU b, Animator c, Transform d, Transform e, Vector3 f, Vector3 g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x980F5F0", Offset = "0x980E5F0", VA = "0x18980F5F0")]
			private void WHPHWQPSVPQ(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x980ED40", Offset = "0x980DD40", VA = "0x18980ED40")]
			protected void DKCIPAZYUOE(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x980F200", Offset = "0x980E200", VA = "0x18980F200")]
			protected void QQIHQTVGFRL(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x980F3B0", Offset = "0x980E3B0", VA = "0x18980F3B0")]
			protected void TBNFYSTGQDZ(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x980F4E0", Offset = "0x980E4E0", VA = "0x18980F4E0")]
			protected void VREBMELSSKS(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x980F350", Offset = "0x980E350", VA = "0x18980F350")]
			protected void RLDGRQJTJSR(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x980F300", Offset = "0x980E300", VA = "0x18980F300")]
			protected void RIULFYZIVCC(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x980F6A0", Offset = "0x980E6A0", VA = "0x18980F6A0")]
			protected void XERZGQPKIHD(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x980EF40", Offset = "0x980DF40", VA = "0x18980EF40")]
			protected void PLOKMIZFMPL(ushort a, ushort b)
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
		private sealed class XHYFYCMXBFX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C3")]
			public PlayerAvatarDisplayBase VVXRKZBRNFO;

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public XHYFYCMXBFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x9810160", Offset = "0x980F160", VA = "0x189810160")]
			internal bool NGDTKKJCKHN()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class ZVSIRWUPSMT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public PlayerAvatarDisplayBase NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public AvatarItemBodyType DYXATSNPHYY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public Func<DLXOODTYWKJ<Dictionary<string, VDJWASGHCNG<Texture2D>>>> CUITAQBVMIR;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public ZVSIRWUPSMT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x9810830", Offset = "0x980F830", VA = "0x189810830")]
			internal (GNSIOEMYZIQ, DLXOODTYWKJ<Dictionary<string, VDJWASGHCNG<Texture2D>>>) NOVXBJGMBIW(Dictionary<string, UZMMDXOYMGN> a)
			{
				return default((GNSIOEMYZIQ, DLXOODTYWKJ<Dictionary<string, VDJWASGHCNG<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x98107C0", Offset = "0x980F7C0", VA = "0x1898107C0")]
			internal DLXOODTYWKJ<Dictionary<string, VDJWASGHCNG<Texture2D>>> NOLJGVSRIME()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x9810A20", Offset = "0x980FA20", VA = "0x189810A20")]
			internal void NPBDYQAJKUF()
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
			[Cpp2IlInjected.Address(RVA = "0x980CB10", Offset = "0x980BB10", VA = "0x18980CB10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x980CD70", Offset = "0x980BD70", VA = "0x18980CD70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class DPBBKXMEUYU : IEnumerator<BFNVKIYRTEQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CB")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private BFNVKIYRTEQ NNNUNWANACF;

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			private BFNVKIYRTEQ NHKNBMQLZLJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000354")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public DPBBKXMEUYU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x97F5B70", Offset = "0x97F4B70", VA = "0x1897F5B70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x97F5EA0", Offset = "0x97F4EA0", VA = "0x1897F5EA0", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
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
			[Cpp2IlInjected.Address(RVA = "0x980CFE0", Offset = "0x980BFE0", VA = "0x18980CFE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x980D380", Offset = "0x980C380", VA = "0x18980D380", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x980D8F0", Offset = "0x980C8F0", VA = "0x18980D8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x980DCB0", Offset = "0x980CCB0", VA = "0x18980DCB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class MOOURPTNAZE : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private SkinnedMeshRenderer NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private int LNNEGLEATET;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			public PlayerAvatarDisplayBase NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			private SkinnedMeshRenderer[] PQBFSTXQTPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private int PPVYVNDTKED;

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			private SkinnedMeshRenderer LIGNNXSOBGY
			{
				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x1024650", Offset = "0x1023650", VA = "0x181024650")]
			[DebuggerHidden]
			public MOOURPTNAZE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "7")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x97F6220", Offset = "0x97F5220", VA = "0x1897F6220", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x97F63F0", Offset = "0x97F53F0", VA = "0x1897F63F0", Slot = "10")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x97F6180", Offset = "0x97F5180", VA = "0x1897F6180", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<SkinnedMeshRenderer> HMTFAZDNRVZ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x97F6180", Offset = "0x97F5180", VA = "0x1897F6180", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator YIRXJWVWWXR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000348")]
		protected static List<PlayerAvatarDisplayBase> FUXMWCRRNJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400034D")]
		protected HelmetHairState MECICIEIFQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected bool WUCKPNXQJDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected bool AACDKZNNBEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x4000352")]
		protected static readonly int[] CGGBONLFPCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000353")]
		private bool ADRLDAJEVVI;

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
		private WYAYCZTEQEU MPECKYMHLIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private WYAYCZTEQEU ESIWMFXFPGV;

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
		protected Collider[] STTDACGORYX;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		protected Collider[] SDZJWKNAGHM;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		protected VICRJAYXVCT[] KMGSNXTPLCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		public bool meshDataStructUseSemioptimizedBoneWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		protected readonly Dictionary<string, VDJWASGHCNG<Texture2D>> VRZGRTOPDPE;

		[Cpp2IlInjected.Token(Token = "0x400036C")]
		protected static int AGRIYRUMICE;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		protected static List<LPYUDGITEOR> NYJHMICHHQO;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		protected static List<LPYUDGITEOR> FKAIJLNLYBL;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		protected static TUMXXHBUICX HKXLNQMEMMX;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		protected static Func<List<LPYUDGITEOR>, LPYUDGITEOR> VOELCYMVMQI;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		protected static bool OSOLOXUUEMX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000372")]
		protected Color? XNEFMUAUVDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		protected Color CCRYTKKDXDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		protected Color MCJQMXDVMFR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		protected Color EHOVZNGHVST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		protected AvatarHairPattern QHLCIWLIKAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		protected Texture2D KVXHKDVTJNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		protected MSYSPFPFNBV DTJRSLBQUVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		protected Color JVBNNIQOQZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		protected Color EQNZDSLLPSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		protected AvatarHairPattern JMDPCNPPCFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		protected Texture2D GWIRCDEPUQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		protected MSYSPFPFNBV FBCXVFZSCAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		protected MSYSPFPFNBV QVWVBALPDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		protected Color CBXFXLSBXMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		private AdditionalFeetData ZLNJRTPODIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		protected readonly IList<AvatarItemSelection> DHHCQWNXASZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		protected readonly IList<AvatarItemSelection> MREBWDPABZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		private AvatarItemBodyType DZMJYLYJHWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x265")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		protected bool WYDIJIHBUZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		protected int[] OFIKQSEOATX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		protected bool WXYLUYDVQIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		protected bool YERWOEDHAZI;

		[Cpp2IlInjected.Token(Token = "0x4000389")]
		private static readonly ZQRJPWYXNPA.SkinCullingMask RSEYJTYKKEI;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private static readonly ZQRJPWYXNPA.SkinCullingMask QZHYYZQXEXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x272")]
		[Cpp2IlInjected.Token(Token = "0x400038B")]
		protected bool UDITCGEPDVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		protected PIVOXJSXBJE UFMTBJRQBCC;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string KVWWMRUTFFY
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xDD3B70", Offset = "0xDD2B70", VA = "0x180DD3B70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xE94400", Offset = "0xE93400", VA = "0x180E94400")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool OOTYQWNEGMG
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool PLJBQRZTSXE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x97FE070", Offset = "0x97FD070", VA = "0x1897FE070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool VUKNNCVAPSA
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool DKQFSYNBRYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool PKUTVEFFOGR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xDF18E0", Offset = "0xDF08E0", VA = "0x180DF18E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x97FE620", Offset = "0x97FD620", VA = "0x1897FE620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public WYAYCZTEQEU LDBZIPVZTQV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xF712B0", Offset = "0xF702B0", VA = "0x180F712B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x97FE640", Offset = "0x97FD640", VA = "0x1897FE640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public WYAYCZTEQEU PPSNOEIFXRO
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xF712C0", Offset = "0xF702C0", VA = "0x180F712C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x97FE8E0", Offset = "0x97FD8E0", VA = "0x1897FE8E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public PlayerFacialAnimatorBase KFPAPXIIKFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xE61930", Offset = "0xE60930", VA = "0x180E61930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public VICRJAYXVCT[] AHGNBAWWAPK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x97FDC00", Offset = "0x97FCC00", VA = "0x1897FDC00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public VICRJAYXVCT BUOOIHSDRDU
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x97FE0E0", Offset = "0x97FD0E0", VA = "0x1897FE0E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public VICRJAYXVCT BIRFEYALKGR
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x97FE110", Offset = "0x97FD110", VA = "0x1897FE110")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected bool SRXEBRAJJKK
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xD13000", Offset = "0xD12000", VA = "0x180D13000", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x97FE850", Offset = "0x97FD850", VA = "0x1897FE850", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected virtual bool YCVWTJWCUCY
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected virtual int[] YSIRVEOKFQO
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x97FA300", Offset = "0x97F9300", VA = "0x1897FA300", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected bool PSPKCSVLDCF
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x97F95A0", Offset = "0x97F85A0", VA = "0x1897F95A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IEnumerable<SkinnedMeshRenderer> XNPSFPHAAGB
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x97FDAE0", Offset = "0x97FCAE0", VA = "0x1897FDAE0")]
			[IteratorStateMachine(typeof(MOOURPTNAZE))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool CCWOSPTXWCA
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x24C35F0", Offset = "0x24C25F0", VA = "0x1824C35F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x24C3650", Offset = "0x24C2650", VA = "0x1824C3650")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public new static bool RQSNFWSTSBA
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x97FDFA0", Offset = "0x97FCFA0", VA = "0x1897FDFA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		protected static TUMXXHBUICX DZLDFKWIIMC
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x97F97D0", Offset = "0x97F87D0", VA = "0x1897F97D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x97F9200", Offset = "0x97F8200", VA = "0x1897F9200")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Color MSNEWNREKUJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x97FD250", Offset = "0x97FC250", VA = "0x1897FD250")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		protected Color NRYQPHUNGLP
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x97F9E80", Offset = "0x97F8E80", VA = "0x1897F9E80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected Texture2D HZVYOIOGMEL
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x97F8020", Offset = "0x97F7020", VA = "0x1897F8020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Color ADRDVMEWILR
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x97FDBB0", Offset = "0x97FCBB0", VA = "0x1897FDBB0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		protected Color ZBDPXRXGNMD
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x97F9550", Offset = "0x97F8550", VA = "0x1897F9550")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public MSYSPFPFNBV VLARMHRGDCB
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x97FDB70", Offset = "0x97FCB70", VA = "0x1897FDB70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected Texture2D WBMJQBCMQFX
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x97F8D60", Offset = "0x97F7D60", VA = "0x1897F8D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public float EINYKQUNTXI
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x97FDB90", Offset = "0x97FCB90", VA = "0x1897FDB90")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public float DFSOAGURMOL
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x97FE050", Offset = "0x97FD050", VA = "0x1897FE050")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public bool UTKMHNWRXDU
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x97FDB60", Offset = "0x97FCB60", VA = "0x1897FDB60")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x97FE410", Offset = "0x97FD410", VA = "0x1897FE410")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action HNUTQNXFJFI
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x97FD810", Offset = "0x97FC810", VA = "0x1897FD810")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x97FE140", Offset = "0x97FD140", VA = "0x1897FE140")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action KRPTDNOCCON
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x97FD8C0", Offset = "0x97FC8C0", VA = "0x1897FD8C0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x97FE1F0", Offset = "0x97FD1F0", VA = "0x1897FE1F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action BMGSPDXCLDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x97FD970", Offset = "0x97FC970", VA = "0x1897FD970")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x97FE2A0", Offset = "0x97FD2A0", VA = "0x1897FE2A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HandType, HandVisualState> PHNOCQOJZXD
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x97FDA20", Offset = "0x97FCA20", VA = "0x1897FDA20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x97FE350", Offset = "0x97FD350", VA = "0x1897FE350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x97FAB10", Offset = "0x97F9B10", VA = "0x1897FAB10")]
		public bool SetDeformation(bool deformBody, bool deformHead)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x97F6930", Offset = "0x97F5930", VA = "0x1897F6930")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x97F9640", Offset = "0x97F8640", VA = "0x1897F9640")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x97FCE90", Offset = "0x97FBE90", VA = "0x1897FCE90")]
		protected void VZJNRKLSNVD(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x97F94A0", Offset = "0x97F84A0", VA = "0x1897F94A0")]
		protected void MBFCFOCTCTC(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x97F93D0", Offset = "0x97F83D0", VA = "0x1897F93D0")]
		protected void MBFCFOCTCTC(MeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x97F89D0", Offset = "0x97F79D0", VA = "0x1897F89D0")]
		public float GetHandOpenClosedAxis(HandType handType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x97FB310", Offset = "0x97FA310", VA = "0x1897FB310")]
		public void SetHandOpenClosedAxis(HandType handType, float openClosedAxis)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x97F8A10", Offset = "0x97F7A10", VA = "0x1897F8A10")]
		public HandVisualState GetHandVisualState(HandType handType)
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x97F6780", Offset = "0x97F5780", VA = "0x1897F6780")]
		public bool AddHandVisualStateToken(HandType handType, HandVisualState handVisualState, object token, VICRJAYXVCT.HandVisualStatePriority priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x97FC020", Offset = "0x97FB020", VA = "0x1897FC020")]
		public void SetWatchHand(HandType handType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x97FC0E0", Offset = "0x97FB0E0", VA = "0x1897FC0E0")]
		public void SetWatchHands(bool showLeftHand, bool showRightHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x97FA0F0", Offset = "0x97F90F0", VA = "0x1897FA0F0")]
		public bool RemoveHandVisualStateToken(HandType handType, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x97F8AC0", Offset = "0x97F7AC0", VA = "0x1897F8AC0")]
		public bool GetThumbsUpActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x97FBAC0", Offset = "0x97FAAC0", VA = "0x1897FBAC0")]
		public void SetThumbsUpActive(HandType handType, bool thumbsUpActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x97F8A80", Offset = "0x97F7A80", VA = "0x1897F8A80")]
		public bool GetHandshakeActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x97FB4B0", Offset = "0x97FA4B0", VA = "0x1897FB4B0")]
		public void SetHandshakeActive(HandType handType, bool handshakeActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x97F8980", Offset = "0x97F7980", VA = "0x1897F8980")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x97FBF30", Offset = "0x97FAF30", VA = "0x1897FBF30")]
		public void SetUseClassicBeanHandScale(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x97F7E80", Offset = "0x97F6E80", VA = "0x1897F7E80")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x97F86D0", Offset = "0x97F76D0", VA = "0x1897F86D0")]
		private static void EMOEEETUVYT(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x97F6B00", Offset = "0x97F5B00", VA = "0x1897F6B00")]
		protected static void BGYAEBNAAGF(PlayerAvatarDisplayBase a, List<LPYUDGITEOR> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x97F9ED0", Offset = "0x97F8ED0", VA = "0x1897F9ED0")]
		public UXDBKRJQXAW Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x97FD2A0", Offset = "0x97FC2A0", VA = "0x1897FD2A0")]
		protected UXDBKRJQXAW ZITRTHIQZHN(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x97FD300", Offset = "0x97FC300", VA = "0x1897FD300", Slot = "19")]
		protected virtual UXDBKRJQXAW ZITRTHIQZHN(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x97F9820", Offset = "0x97F8820", VA = "0x1897F9820")]
		protected static UXDBKRJQXAW RERRNGPEEDO(LPYUDGITEOR a, List<LPYUDGITEOR> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x97F9780", Offset = "0x97F8780", VA = "0x1897F9780")]
		[IteratorStateMachine(typeof(DPBBKXMEUYU))]
		protected static IEnumerator<BFNVKIYRTEQ> QRGWPMDPKEX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x97F9170", Offset = "0x97F8170", VA = "0x1897F9170")]
		protected static LPYUDGITEOR JXVZGYIGVVP(List<LPYUDGITEOR> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x97FABE0", Offset = "0x97F9BE0", VA = "0x1897FABE0")]
		[AsyncStateMachine(typeof(<SetFaceCustomizationSettings>d__130))]
		public Task SetFaceCustomizationSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x97FC730", Offset = "0x97FB730", VA = "0x1897FC730")]
		public bool UpdateFaceAndBodyCustomizationSettings(AvatarData avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x97F8F00", Offset = "0x97F7F00", VA = "0x1897F8F00")]
		public void InitializeFaceFeatures(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x97FB8C0", Offset = "0x97FA8C0", VA = "0x1897FB8C0")]
		public void SetTeamColors(Color? teamColor, bool teamOutfitColorEmissionEnabled, Color emissiveColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x97FA7D0", Offset = "0x97F97D0", VA = "0x1897FA7D0")]
		public void SetBeardPrimaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x97FA970", Offset = "0x97F9970", VA = "0x1897FA970")]
		public void SetBeardSecondaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x97FA5A0", Offset = "0x97F95A0", VA = "0x1897FA5A0")]
		public void SetBeardPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x97FA020", Offset = "0x97F9020", VA = "0x1897FA020")]
		public void RefreshBeard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x97FCFB0", Offset = "0x97FBFB0", VA = "0x1897FCFB0")]
		private bool WLLUYOJGRLN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x97FB010", Offset = "0x97FA010", VA = "0x1897FB010")]
		public void SetHairPrimaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x97FB190", Offset = "0x97FA190", VA = "0x1897FB190")]
		public void SetHairSecondaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x97FACE0", Offset = "0x97F9CE0", VA = "0x1897FACE0")]
		[AsyncStateMachine(typeof(<SetHairPatternAsync>d__168))]
		public Task SetHairPatternAsync([Optional] AvatarHairPattern pattern)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x97FADD0", Offset = "0x97F9DD0", VA = "0x1897FADD0")]
		public void SetHairPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x97FA090", Offset = "0x97F9090", VA = "0x1897FA090")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x97F8B00", Offset = "0x97F7B00", VA = "0x1897F8B00")]
		private bool HTWXFOSSOOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x97FB7C0", Offset = "0x97FA7C0", VA = "0x1897FB7C0")]
		public void SetSkinColor(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x97FBBD0", Offset = "0x97FABD0", VA = "0x1897FBBD0")]
		public void SetUgcItemVisualOverrides(AvatarItemSelection overrideItem, AvatarBodyType avatarBodyType, Texture textureOverride, Color colorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x97FC380", Offset = "0x97FB380", VA = "0x1897FC380")]
		private void TVZUCTDZXNZ(BodyProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x97F8FC0", Offset = "0x97F7FC0", VA = "0x1897F8FC0")]
		private void JFBSDGYABII(BodyPropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x97F7DE0", Offset = "0x97F6DE0", VA = "0x1897F7DE0")]
		private void CHNDQSGARUC(FaceProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x97F66E0", Offset = "0x97F56E0", VA = "0x1897F66E0")]
		private void AGWPTQIFLZK(NoseProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x97FCD80", Offset = "0x97FBD80", VA = "0x1897FCD80")]
		private void VSGXQGOTLLP(FacePropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x97F6C00", Offset = "0x97F5C00", VA = "0x1897F6C00")]
		private void BHGUQATOHCX(NosePropertyData a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x97FB6B0", Offset = "0x97FA6B0", VA = "0x1897FB6B0")]
		public bool SetHideEars(bool hideEars)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x97FB690", Offset = "0x97FA690", VA = "0x1897FB690")]
		public bool SetHelmetHair(HelmetHairState helmetHairState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x97FB5C0", Offset = "0x97FA5C0", VA = "0x1897FB5C0")]
		public void SetHatAnchorParameters(NDDYXKDLQRL newAnchorParams, bool useParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x97FB7A0", Offset = "0x97FA7A0", VA = "0x1897FB7A0")]
		public bool SetShowModestyAndValidationGuidelines(bool showModestyAndValidationGuidelines)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x97FC1B0", Offset = "0x97FB1B0", VA = "0x1897FC1B0")]
		public void SetupDisplayLODs(LODSelection lodSelection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x97FC1E0", Offset = "0x97FB1E0", VA = "0x1897FC1E0")]
		protected int[] TJKNDKAWGGT(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x97FB720", Offset = "0x97FA720", VA = "0x1897FB720")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x97FB6D0", Offset = "0x97FA6D0", VA = "0x1897FB6D0")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool isFirstPerson, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x97FB760", Offset = "0x97FA760", VA = "0x1897FB760")]
		public UXDBKRJQXAW SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, LODSelection lodSelection, bool isFirstPerson, bool usesBodyPaint, bool forceRebuild = false, bool shouldBuildPotatoAvatar = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x97FC480", Offset = "0x97FB480", VA = "0x1897FC480", Slot = "20")]
		protected virtual UXDBKRJQXAW UUBLQOBUXTM(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, LODSelection e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x97F8800", Offset = "0x97F7800", VA = "0x1897F8800")]
		protected int[] EYWLPHNFIVA(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "21")]
		protected virtual GNSIOEMYZIQ XNOIYJFNZMH(AvatarItemBodyType a, Dictionary<string, UZMMDXOYMGN> b, Dictionary<string, VDJWASGHCNG<Texture2D>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x97FD060", Offset = "0x97FC060", VA = "0x1897FD060", Slot = "22")]
		protected virtual void WXNETCOJGDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x97F6430", Offset = "0x97F5430", VA = "0x1897F6430", Slot = "23")]
		protected virtual UXDBKRJQXAW AEDBDTRCTME(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, AvatarBuildType f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x97F81C0", Offset = "0x97F71C0", VA = "0x1897F81C0", Slot = "24")]
		protected virtual UZMMDXOYMGN DKMIIDFTCPV(MSYSPFPFNBV a, AvatarItemBodyType b, AvatarBodyPart c, UZMMDXOYMGN d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xCF6210", Offset = "0xCF5210", VA = "0x180CF6210", Slot = "25")]
		protected virtual UZMMDXOYMGN UMYVPIJYTDB(AvatarItemBodyType a, AvatarBodyPart b, TRCJRGINRMT c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x97F8900", Offset = "0x97F7900", VA = "0x1897F8900")]
		protected void FMFJFHAIZTD(MCDWSPYDUYL a, ZQRJPWYXNPA.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x97F6A80", Offset = "0x97F5A80", VA = "0x1897F6A80")]
		protected void BFJPNXDOFTN(MCDWSPYDUYL a, ZQRJPWYXNPA.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xD5A530", Offset = "0xD59530", VA = "0x180D5A530", Slot = "26")]
		protected virtual MCDWSPYDUYL VDHCDWARGXO(MCDWSPYDUYL a, HelmetHairStyle b, bool c, AvatarItemBodyType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x97F6D30", Offset = "0x97F5D30", VA = "0x1897F6D30")]
		protected MCDWSPYDUYL BJLITTCNUXY(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x97FA4E0", Offset = "0x97F94E0", VA = "0x1897FA4E0")]
		protected ZQRJPWYXNPA.SkinCullingMask SZSUXJVXGQU(ZQRJPWYXNPA.SkinCullingMask a, AvatarBodyPart b)
		{
			return default(ZQRJPWYXNPA.SkinCullingMask);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x97F7F50", Offset = "0x97F6F50", VA = "0x1897F7F50", Slot = "12")]
		[AsyncStateMachine(typeof(<CompleteBuildAsync>d__218))]
		public override Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x97F8BC0", Offset = "0x97F7BC0", VA = "0x1897F8BC0")]
		protected static UpdatableColorType IGYEKMLXMFB(CEQNQOATLVM a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x97FA390", Offset = "0x97F9390", VA = "0x1897FA390")]
		protected static UpdatableTextureType SKQLVAEBBIT(CEQNQOATLVM a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x97FC420", Offset = "0x97FB420", VA = "0x1897FC420", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x97FBFC0", Offset = "0x97FAFC0", VA = "0x1897FBFC0")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x97FBE80", Offset = "0x97FAE80", VA = "0x1897FBE80")]
		public void SetUgcTextureParameters(PIVOXJSXBJE parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x97FD6B0", Offset = "0x97FC6B0", VA = "0x1897FD6B0")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x97F9540", Offset = "0x97F8540", VA = "0x1897F9540")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task MQAUJQNNROA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, AQNYQLPECPC
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
			private TaskAwaiter<YPNWLXWSRSA> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x980C240", Offset = "0x980B240", VA = "0x18980C240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x980C680", Offset = "0x980B680", VA = "0x18980C680", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x980C6E0", Offset = "0x980B6E0", VA = "0x18980C6E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x980CAB0", Offset = "0x980BAB0", VA = "0x18980CAB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x980CDD0", Offset = "0x980BDD0", VA = "0x18980CDD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x980CF80", Offset = "0x980BF80", VA = "0x18980CF80", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x980D3E0", Offset = "0x980C3E0", VA = "0x18980D3E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x980D650", Offset = "0x980C650", VA = "0x18980D650", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x980D6B0", Offset = "0x980C6B0", VA = "0x18980D6B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x980D890", Offset = "0x980C890", VA = "0x18980D890", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x980DD10", Offset = "0x980CD10", VA = "0x18980DD10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x980DEB0", Offset = "0x980CEB0", VA = "0x18980DEB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DE")]
		protected const float HOISVNTSGCA = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		protected const int SMKVEOLHNYO = 5;

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
		protected static readonly Dictionary<IADZKPDCHAT.Emote, int> ENRPEZFIOQN;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> CBYUKMLBKCE;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		protected static Vector2 CALTDZEPDEU;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 UDNXBWRVTSH;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 PGVNCAGRVCA;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 MARNDBXBSDI;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static Vector2 SBPOHSPTXOJ;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static Vector2 LIYGEIZZLZQ;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static Vector2 ISVSFBTSQGW;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static Vector2 EGDKTDSDNBX;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static Vector2 AJMRUIWQHUW;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static Vector2 QOAVYIYKAQK;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static Vector2 BZXFRTJCZRX;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static Vector2 FXNXEVYVWEK;

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
		private AvatarBodyType MOPFXTXZLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private FaceStyleSet RDSBJOXWUOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000413")]
		protected const int BOXANZFLJTL = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected int HRNFXJAYVLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected int MBTKKEDOBKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected int LJSWJGQJJLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected int PJZWOXYKFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected Vector2 QCNYNBRAWVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected float WVDFPBNCSTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected float NHRBYXSALVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected float CVOQJEJVFMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected Vector2 QBCSZCEGIKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected float WVJTKDTXGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected float FICGWSJPGOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected float GHIITEMHYPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected Vector2 LSJDWCEZWQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected float PWIPUAZBFQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected float QAKXQXOPWYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected float HKCJXEDVHUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected Vector2 XSNDRRQOBVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected float CMJIQIVJYEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected float KYEQEZKODJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected float OKQYTOOSZMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected List<SelectableFaceOption> ULLAXDWHYIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected List<SelectableFaceOption> MFFVPFODZNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected List<SelectableFaceOption> HBUNIQNRRTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected List<SelectableFaceOption> CJEVWQMRJIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected int? CSVMVXZSBDV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected int NSEFHAQRLHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected int MOYUPJMRYNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected int WWOYJWIZLQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected int ZBIZAYXCWZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected Sprite PTIKGXHNXQA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected Sprite VRXYWUCBFSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Sprite MGCFJZFKMFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected Sprite ONFHNIXRUFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected bool OCWRLMVGMHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000437")]
		protected string XQMJBKRMEZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected string GRAJICTRCBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected string LXAILMAMRVC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected string CNVSTSLZAAG;

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
		protected AvatarConfiguration DULRMRPPBKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected YPNWLXWSRSA JKGQBYHATVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x4000449")]
		protected Dictionary<string, int> KBZLAKMDZIS;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public FaceStyleSet MEJNTZRAJWK
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x9804380", Offset = "0x9803380", VA = "0x189804380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x98043D0", Offset = "0x98033D0", VA = "0x1898043D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x1C1BA70", Offset = "0x1C1AA70", VA = "0x181C1BA70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool YGAXGCNBXYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xD405E0", Offset = "0xD3F5E0", VA = "0x180D405E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected virtual bool SVUJWMZASMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xD0FC20", Offset = "0xD0EC20", VA = "0x180D0FC20", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected int GEOIPBENZKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x9800F80", Offset = "0x97FFF80", VA = "0x189800F80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool FCECJBSTRRY
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x1C195A0", Offset = "0x1C185A0", VA = "0x181C195A0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x1C1BA60", Offset = "0x1C1AA60", VA = "0x181C1BA60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] FBRYMGPBSZD
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4A40", Offset = "0xCF3A40", VA = "0x180CF4A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool SWIBAJGGNLO
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x98043E0", Offset = "0x98033E0", VA = "0x1898043E0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x98045A0", Offset = "0x98035A0", VA = "0x1898045A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int TQKGHGGVBGV
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x9800BD0", Offset = "0x97FFBD0", VA = "0x189800BD0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int XVJAXZTRPZT
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x9800470", Offset = "0x97FF470", VA = "0x189800470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float KPARHFGVBWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x98043B0", Offset = "0x98033B0", VA = "0x1898043B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x9804580", Offset = "0x9803580", VA = "0x189804580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public AIVOINEFDMQ IDVCXKIDCOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xF713B0", Offset = "0xF703B0", VA = "0x180F713B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x1524990", Offset = "0x1523990", VA = "0x181524990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public YPNWLXWSRSA RUDJAQGJYYC
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xF71390", Offset = "0xF70390", VA = "0x180F71390")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x9804500", Offset = "0x9803500", VA = "0x189804500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption XIGNLFWZFQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xF71380", Offset = "0xF70380", VA = "0x180F71380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x1725FF0", Offset = "0x1724FF0", VA = "0x181725FF0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action OPOPLWKTOHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x98042D0", Offset = "0x98032D0", VA = "0x1898042D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9804450", Offset = "0x9803450", VA = "0x189804450")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9800370", Offset = "0x97FF370", VA = "0x189800370")]
		public void LocalPlayEmote(IADZKPDCHAT.Emote emote, float normalizedTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x97FFEA0", Offset = "0x97FEEA0", VA = "0x1897FFEA0")]
		public bool IsEmotePlaying(IADZKPDCHAT.Emote emote)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x9802110", Offset = "0x9801110", VA = "0x189802110")]
		public void SetIdleHappy(bool happy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x9803160", Offset = "0x9802160", VA = "0x189803160")]
		protected void WPTMTARNBYC(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x9800140", Offset = "0x97FF140", VA = "0x189800140")]
		protected void LBWEYKXGBGN(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x97FEAF0", Offset = "0x97FDAF0", VA = "0x1897FEAF0")]
		protected void AVTPSNLGVEZ(AvatarBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x97FF0A0", Offset = "0x97FE0A0", VA = "0x1897FF0A0")]
		protected void EJCLWQDTHRC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x9800E70", Offset = "0x97FFE70", VA = "0x189800E70")]
		public void PlayExpression(int hashID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x98030A0", Offset = "0x98020A0", VA = "0x1898030A0")]
		protected void VDCPDWKQXBR(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x97FF560", Offset = "0x97FE560", VA = "0x1897FF560")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType featureType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x97FF990", Offset = "0x97FE990", VA = "0x1897FF990")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x9801DB0", Offset = "0x9800DB0", VA = "0x189801DB0")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__147))]
		public Task SetFaceSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x9801EA0", Offset = "0x9800EA0", VA = "0x189801EA0")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__148))]
		public Task SetFaceSettings(int eyeSelection, int eyeBrowSelection, int noseSelection, int mouthSelection, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x9802190", Offset = "0x9801190", VA = "0x189802190")]
		[AsyncStateMachine(typeof(<SetSelectedFaceFeatureAndBuildFaceStyle>d__149))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType featureType, int selectionIndex, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x97FFFC0", Offset = "0x97FEFC0", VA = "0x1897FFFC0")]
		protected void JITILGSALVK(FaceFeatureType a, FaceFeatureId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x98010B0", Offset = "0x98000B0", VA = "0x1898010B0")]
		protected void SUKKNGZENZL(FaceFeatureType a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x97FF3A0", Offset = "0x97FE3A0", VA = "0x1897FF3A0")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x97FF8A0", Offset = "0x97FE8A0", VA = "0x1897FF8A0")]
		[AsyncStateMachine(typeof(<SetAllFaceFeatureSettings>d__153))]
		protected Task IQFRCZYSGFV(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x97FEDA0", Offset = "0x97FDDA0", VA = "0x1897FEDA0")]
		protected void CUPPKKLCUIY(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x97FF720", Offset = "0x97FE720", VA = "0x1897FF720")]
		protected static void INSKWTRTJLQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x97FF110", Offset = "0x97FE110", VA = "0x1897FF110")]
		private void GHVQIONHFPW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x98031E0", Offset = "0x98021E0", VA = "0x1898031E0")]
		protected void XDBGNEDHKQD(FaceFeatureType a, Vector2 b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x9801800", Offset = "0x9800800", VA = "0x189801800")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType featureType, Vector2 normalizedPositionOffset, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x9802F20", Offset = "0x9801F20", VA = "0x189802F20")]
		protected void VBJSUXJOXZS(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x97FF5A0", Offset = "0x97FE5A0", VA = "0x1897FF5A0")]
		protected void IDPHEFMZKGR(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x98002A0", Offset = "0x97FF2A0", VA = "0x1898002A0")]
		protected void LCOIJHLKTGH(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x9801B90", Offset = "0x9800B90", VA = "0x189801B90")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType featureType, float normalizedScale, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x9800C30", Offset = "0x97FFC30", VA = "0x189800C30")]
		[AsyncStateMachine(typeof(<BuildFaceFeatureStyle>d__171))]
		protected Task OOSBMIFHUYM(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x97FFCB0", Offset = "0x97FECB0", VA = "0x1897FFCB0")]
		public void InitializeFaceFeatureStyleSet(AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9800D90", Offset = "0x97FFD90", VA = "0x189800D90")]
		protected bool PPEGDYFAUBX(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x97FEB60", Offset = "0x97FDB60", VA = "0x1897FEB60")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x1877FE0", Offset = "0x1876FE0", VA = "0x181877FE0", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x9800D10", Offset = "0x97FFD10", VA = "0x189800D10")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x97FECA0", Offset = "0x97FDCA0", VA = "0x1897FECA0")]
		[AsyncStateMachine(typeof(<BuildFaceStyleAsyncIfChanged>d__178))]
		public Task BuildFaceStyleAsyncIfChanged(AvatarBodyType avatarBodyType, bool forceRebuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9802BB0", Offset = "0x9801BB0", VA = "0x189802BB0")]
		public void UpdateFaceDisplays(bool forceUpdateFaceTextures = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x98004D0", Offset = "0x97FF4D0", VA = "0x1898004D0")]
		protected void MZRYGLBFOUO(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x9802910", Offset = "0x9801910", VA = "0x189802910")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x9801FD0", Offset = "0x9800FD0", VA = "0x189801FD0")]
		public void SetFaceSpriteIndices(string leftEyeName, string rightEyeName, string mouthName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x98022A0", Offset = "0x98012A0", VA = "0x1898022A0")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9802D30", Offset = "0x9801D30", VA = "0x189802D30")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9800E90", Offset = "0x97FFE90", VA = "0x189800E90")]
		protected void QJUMZZOCIGR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x98040D0", Offset = "0x98030D0", VA = "0x1898040D0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xD212D0", Offset = "0xD202D0", VA = "0x180D212D0", Slot = "4")]
		private bool EPQPELERXNZ()
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
		private sealed class VEPJTPLNNOQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DE")]
			public NoseType PXCFQYBWOPX;

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public VEPJTPLNNOQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xE73370", Offset = "0xE72370", VA = "0x180E73370")]
			internal bool BBPRJVWYQOZ(NoseShapePropertyData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class WGXDDJCTGVE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public PlayerModernBodyEditorAvatarValidator NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public GameObject ZRDYZWJLLET;

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public WGXDDJCTGVE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x980FEF0", Offset = "0x980EEF0", VA = "0x18980FEF0")]
			internal void IYQQJDKXDUE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x980FF20", Offset = "0x980EF20", VA = "0x18980FF20")]
			internal void IYVXGKEUNFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x980FF50", Offset = "0x980EF50", VA = "0x18980FF50")]
			internal void IZBEDQYRWQW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x980FF80", Offset = "0x980EF80", VA = "0x18980FF80")]
			internal void IZGLAXSPGCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x980FFB0", Offset = "0x980EFB0", VA = "0x18980FFB0")]
			internal void IZLRYEMMPNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x980FFE0", Offset = "0x980EFE0", VA = "0x18980FFE0")]
			internal void IZQYVLGJYYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9810010", Offset = "0x980F010", VA = "0x189810010")]
			internal void IZWFSSAHIKG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x9810040", Offset = "0x980F040", VA = "0x189810040")]
			internal void JABMPYUERVP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x9810070", Offset = "0x980F070", VA = "0x189810070")]
			internal void JAGTNFOCBGY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x98100A0", Offset = "0x980F0A0", VA = "0x1898100A0")]
			internal void JAMAKMHZKSH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9810130", Offset = "0x980F130", VA = "0x189810130")]
			internal void KOFBTBXZVTP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x98100D0", Offset = "0x980F0D0", VA = "0x1898100D0")]
			internal void KNZUVVECMIG()
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
			[Cpp2IlInjected.Address(RVA = "0x980EA40", Offset = "0x980DA40", VA = "0x18980EA40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xD58E90", Offset = "0xD57E90", VA = "0x180D58E90", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x980E480", Offset = "0x980D480", VA = "0x18980E480", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x980E9E0", Offset = "0x980D9E0", VA = "0x18980E9E0", Slot = "5")]
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
		public NDDYXKDLQRL hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public XYVPUOFWTEB HatAnchorRestrictions;

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
		private WGLTLEWCJPM EEHDNFDJIND;

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
		private AnimatorOverrideController PADMTZCBXJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> HBJOSOJWKPH;

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
		protected bool DJIMAMMKTTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		protected Guid BDIRFCACLCZ;

		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		protected static Guid VTLLHUIIBSI;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		private static readonly int KKLKPFMFJVJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private RHGOFRPLRDZ LXVHSAFNCWV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private AIVOINEFDMQ EOCTZMLTTGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private WYAYCZTEQEU MPECKYMHLIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private WYAYCZTEQEU ESIWMFXFPGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private AdditionalHatData JTKRUJOFOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private readonly Dictionary<GameObject, MSYSPFPFNBV> APGQILXWNOP;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public static Func<TRCJRGINRMT> TLXKGVZEBWH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x980AB20", Offset = "0x9809B20", VA = "0x18980AB20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x980B160", Offset = "0x980A160", VA = "0x18980B160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool HTWXFOSSOOF
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x980AC80", Offset = "0x9809C80", VA = "0x18980AC80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool WLLUYOJGRLN
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x980AB70", Offset = "0x9809B70", VA = "0x18980AB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public PlayerAvatarDisplayBase HXLHWLCDYZF
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xDBC1E0", Offset = "0xDBB1E0", VA = "0x180DBC1E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		protected static Guid ZFHGOCLCQKF
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x98073F0", Offset = "0x98063F0", VA = "0x1898073F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public (GameObject prefab, AvatarBodyPart part)[] PNJRWBAJQKO
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x980AD90", Offset = "0x9809D90", VA = "0x18980AD90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x9807E50", Offset = "0x9806E50", VA = "0x189807E50")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x9805CF0", Offset = "0x9804CF0", VA = "0x189805CF0")]
		private IEnumerable<GameObject> IMVUFVFRPCT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x9808370", Offset = "0x9807370", VA = "0x189808370")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x9809CC0", Offset = "0x9808CC0", VA = "0x189809CC0")]
		private void ZIVTLQRGWWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x1585E60", Offset = "0x1584E60", VA = "0x181585E60")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x9805ED0", Offset = "0x9804ED0", VA = "0x189805ED0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x9808380", Offset = "0x9807380", VA = "0x189808380")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x9808190", Offset = "0x9807190", VA = "0x189808190")]
		public void ShowPose(AnimationClip pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x9808340", Offset = "0x9807340", VA = "0x189808340")]
		public void ShowPose(string poseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x9807FC0", Offset = "0x9806FC0", VA = "0x189807FC0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x9807E60", Offset = "0x9806E60", VA = "0x189807E60")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x98093F0", Offset = "0x98083F0", VA = "0x1898093F0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x9808D60", Offset = "0x9807D60", VA = "0x189808D60")]
		public void UpdateFaceAndBodyShapes(bool forceRebuild = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x9809810", Offset = "0x9808810", VA = "0x189809810")]
		public void UpdateNoseShape(NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x98097D0", Offset = "0x98087D0", VA = "0x1898097D0")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x9806630", Offset = "0x9805630", VA = "0x189806630", Slot = "4")]
		protected virtual void KJKFRPQSTIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x9804BD0", Offset = "0x9803BD0", VA = "0x189804BD0", Slot = "5")]
		protected virtual void BRBKWLFFPAW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9804800", Offset = "0x9803800", VA = "0x189804800")]
		public void ApplyHatData(AdditionalHatData hatData, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x9804640", Offset = "0x9803640", VA = "0x189804640")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x9804B60", Offset = "0x9803B60", VA = "0x189804B60")]
		public void ApplyHatUVOverride(Vector2 UVOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9804A80", Offset = "0x9803A80", VA = "0x189804A80")]
		public void ApplyHatPositionAdjustment(Vector3 positionAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x9804AF0", Offset = "0x9803AF0", VA = "0x189804AF0")]
		public void ApplyHatRotationAdjustment(Vector3 rotationAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x9804E40", Offset = "0x9803E40", VA = "0x189804E40")]
		public AvatarItemSelection BuildAvatarItemSelection(GameObject selection, AvatarBodyType bodyType, AvatarBodyPart part)
		{
			return default(AvatarItemSelection);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x9804EE0", Offset = "0x9803EE0", VA = "0x189804EE0")]
		public void BuildAvatar(bool forceRebuild = false, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x98086C0", Offset = "0x98076C0", VA = "0x1898086C0")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x9804780", Offset = "0x9803780", VA = "0x189804780")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x9809620", Offset = "0x9808620", VA = "0x189809620")]
		public void UpdateHatAnchor(bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x9809340", Offset = "0x9808340", VA = "0x189809340")]
		[AsyncStateMachine(typeof(<UpdateFaceFeatures>d__140))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x9807D80", Offset = "0x9806D80", VA = "0x189807D80")]
		[AsyncStateMachine(typeof(<UpdateFaceFeaturesInternal>d__141))]
		private Task RSRLHJYDWGQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9805680", Offset = "0x9804680", VA = "0x189805680")]
		private void GZFGUSNMTFI(FaceFeatureType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x9809BF0", Offset = "0x9808BF0", VA = "0x189809BF0")]
		private void WLLTGXERJHK(FaceFeatureType a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x9808C20", Offset = "0x9807C20", VA = "0x189808C20")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x9809B40", Offset = "0x9808B40", VA = "0x189809B40")]
		public void UpdatePosingProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x9809480", Offset = "0x9808480", VA = "0x189809480")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x9807860", Offset = "0x9806860", VA = "0x189807860")]
		private void RHMGTHZPHIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private void PNGEILRIYWR(MSYSPFPFNBV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200")]
		private void GRJNZTWACCB(MSYSPFPFNBV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x98074E0", Offset = "0x98064E0", VA = "0x1898074E0")]
		private void RDENKOYBRHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9806BB0", Offset = "0x9805BB0", VA = "0x189806BB0")]
		public void PopulatePrefabSlotsByGuid(List<Guid> guids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x9806940", Offset = "0x9805940", VA = "0x189806940")]
		private void PDZFSJZXVBZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x9805950", Offset = "0x9804950", VA = "0x189805950")]
		private void HALTLWNMDXA(OutfitType a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x9809E40", Offset = "0x9808E40", VA = "0x189809E40")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x9809C80", Offset = "0x9808C80", VA = "0x189809C80")]
		[CompilerGenerated]
		private bool XCAUYVDNRZH(FaceShapePropertyData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x98055D0", Offset = "0x98045D0", VA = "0x1898055D0")]
		[CompilerGenerated]
		private AvatarItemSelection DUUFHCMVGHP((GameObject prefab, AvatarBodyPart part) h)
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
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x980B580", Offset = "0x980A580", VA = "0x18980B580")]
		public void SetOutfitItems(IEnumerable<Guid> avatarItemGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x980B3D0", Offset = "0x980A3D0", VA = "0x18980B3D0")]
		public void InitializeAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xCF61F0", Offset = "0xCF51F0", VA = "0x180CF61F0")]
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
		private sealed class OWXPRIASNUK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004FB")]
			public IEnumerable<OutfitType> TACFSJNKPBG;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public OWXPRIASNUK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x9810B80", Offset = "0x980FB80", VA = "0x189810B80")]
			internal bool EBSLNAUGZZT(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		private MSYSPFPFNBV _avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private AvatarBodyPart _bodyPart;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public MSYSPFPFNBV YGDCJSOIJDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xECDF60", Offset = "0xECCF60", VA = "0x180ECDF60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public AvatarBodyPart ZLWKVDUZEJB
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xECDF70", Offset = "0xECCF70", VA = "0x180ECDF70")]
			get
			{
				return default(AvatarBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public string ALWALAWXEVT
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x97F50C0", Offset = "0x97F40C0", VA = "0x1897F50C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public bool SSUIMQLSMGF
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x97F5A80", Offset = "0x97F4A80", VA = "0x1897F5A80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool QRNWFSKSNLS
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x97F5AD0", Offset = "0x97F4AD0", VA = "0x1897F5AD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool NFEDDQIHTNW
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x97F5B20", Offset = "0x97F4B20", VA = "0x1897F5B20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x97F5390", Offset = "0x97F4390", VA = "0x1897F5390", Slot = "4")]
		public bool Equals(AvatarItemSelection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x97F55F0", Offset = "0x97F45F0", VA = "0x1897F55F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x97F5690", Offset = "0x97F4690", VA = "0x1897F5690", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1B05980", Offset = "0x1B04980", VA = "0x181B05980")]
		public AvatarItemSelection(MSYSPFPFNBV avatarItem, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x97F57F0", Offset = "0x97F47F0", VA = "0x1897F57F0")]
		public bool SOEEBGVXDRO(OutfitType a, AvatarBodyPart b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x97F51B0", Offset = "0x97F41B0", VA = "0x1897F51B0")]
		public bool BORABZQCNDX(AvatarItemSelection a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class THOEBQKNLLV
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class KXPJFHIHHEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000500")]
			public IEnumerable<OutfitType> TACFSJNKPBG;

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public KXPJFHIHHEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x9810B00", Offset = "0x980FB00", VA = "0x189810B00")]
			internal bool EBSLNAUGZZT(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FC")]
		private MSYSPFPFNBV WCERCGITGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart YKDKRMYMUIG;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public MSYSPFPFNBV YGDCJSOIJDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xCF4120", Offset = "0xCF3120", VA = "0x180CF4120")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart ZLWKVDUZEJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xD01380", Offset = "0xD00380", VA = "0x180D01380")]
			get
			{
				return default(OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Color? OCTDXXQMYUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xD01340", Offset = "0xD00340", VA = "0x180D01340")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xD01330", Offset = "0xD00330", VA = "0x180D01330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3? CDENTUISUSA
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xF71A20", Offset = "0xF70A20", VA = "0x180F71A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xF72420", Offset = "0xF71420", VA = "0x180F72420")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x9810D20", Offset = "0x980FD20", VA = "0x189810D20")]
		public THOEBQKNLLV(MSYSPFPFNBV a, OWJJZEABANY.SVFNYUIHGCD.RoomieBodyPart b, Color? c, Vector3? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9810C00", Offset = "0x980FC00", VA = "0x189810C00")]
		public bool BORABZQCNDX(THOEBQKNLLV a)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__2126450803
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x9810DA0", Offset = "0x980FDA0", VA = "0x189810DA0")]
	public static void PQMGTAMPKVS()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x9810D90", Offset = "0x980FD90", VA = "0x189810D90")]
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
