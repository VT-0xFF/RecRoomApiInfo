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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x97EAB70", Offset = "0x97E9570", VA = "0x1897EAB70", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		private RecNetCDNKey ZOYFTTVDVER;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public RecNetCDNKey TypedRuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xF312F0", Offset = "0xF2FCF0", VA = "0x180F312F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97EAEE0", Offset = "0x97E98E0", VA = "0x1897EAEE0", Slot = "19")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x97EAF10", Offset = "0x97E9910", VA = "0x1897EAF10")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RecNetCDNKey Dependency
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool AttemptPrecacheLookup
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD6FAC0", Offset = "0xD6E4C0", VA = "0x180D6FAC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD70630", Offset = "0xD6F030", VA = "0x180D70630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ItemPathHint PathHint
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF88D10", Offset = "0xF87710", VA = "0x180F88D10")]
			[CompilerGenerated]
			get
			{
				return default(ItemPathHint);
			}
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xFC4750", Offset = "0xFC3150", VA = "0x180FC4750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public string ItemPath
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x97EB020", Offset = "0x97E9A20", VA = "0x1897EB020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x97EAFA0", Offset = "0x97E99A0", VA = "0x1897EAFA0")]
		public static RecNetCDNKey PETYNNKSTOW(string a, ItemPathHint b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x97EAF50", Offset = "0x97E9950", VA = "0x1897EAF50")]
		public void BAREWBVJIGF(string a, string b, bool c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public RecNetCDNKey()
		{
		}
	}
}
namespace RecRoom.AI.RoomieAI
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class RoomieAvatarDisplay : AvatarDisplayBase, FQMRJXVJOSP
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct EquipResult
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public IEnumerable<GOVRREGVIBX> equippedItems;

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
				[Cpp2IlInjected.Address(RVA = "0xF35A80", Offset = "0xF34480", VA = "0x180F35A80")]
				[CompilerGenerated]
				get
				{
					return default(Guid);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			public SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart Bodypart
			{
				[Cpp2IlInjected.Token(Token = "0x6000071")]
				[Cpp2IlInjected.Address(RVA = "0xD224F0", Offset = "0xD20EF0", VA = "0x180D224F0")]
				[CompilerGenerated]
				get
				{
					return default(SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			public Vector3? Rotation
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xE948D0", Offset = "0xE932D0", VA = "0x180E948D0")]
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
				[Cpp2IlInjected.Address(RVA = "0x97EA2E0", Offset = "0x97E8CE0", VA = "0x1897EA2E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x97EA280", Offset = "0x97E8C80", VA = "0x1897EA280")]
			public DisplayItemData(Guid customAvatarItemId, Vector3? rotation, Color? color, SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart part)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		[CompilerGenerated]
		private sealed class <AvatarRuntimeBuildMeshRoutine>d__125 : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private OSEXMMYDSBS <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public List<UXMOFXXDVIG> parts;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public RoomieAvatarDisplay <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public List<PGLTTIWTYKI> innerPromises;

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
			private OSEXMMYDSBS System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public <AvatarRuntimeBuildMeshRoutine>d__125(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x97F0A50", Offset = "0x97EF450", VA = "0x1897F0A50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x97F0C80", Offset = "0x97EF680", VA = "0x1897F0C80", Slot = "8")]
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
		private readonly List<OVEKQGJRAJB> _nextPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly List<OVEKQGJRAJB> _currentPrefabHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly List<OVEKQGJRAJB> _nextMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly List<OVEKQGJRAJB> _currentMaterialHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly List<DisplayItemData> _EquippedDisplayItemOutfitSelections;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly IList<GOVRREGVIBX> _currentEquippedOutfitSelections;

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
		private readonly Dictionary<(SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart bodyPart, Material sharedMaterial), Material> _currentSharedToInstanceLookup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Dictionary<(SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart bodyPart, Material sharedMaterial), Material> _nextSharedToInstanceLookup;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private readonly Dictionary<SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart, Color> RoomieCustomizedColors;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private readonly Dictionary<SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart, PositionAndRotation> RoomieCustomizedTransformPerPart;

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
		private readonly JOLHGBMRDLK _buildCompleted;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private readonly JOLHGBMRDLK _buildCancelled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private SkinnedMeshRenderer[] _cachedBuiltBodySkinMeshes;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public JOLHGBMRDLK DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xDD8020", Offset = "0xDD6A20", VA = "0x180DD8020", Slot = "24")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public JOLHGBMRDLK DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xF86B50", Offset = "0xF85550", VA = "0x180F86B50", Slot = "25")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xD2ED50", Offset = "0xD2D750", VA = "0x180D2ED50", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x97F0A30", Offset = "0x97EF430", VA = "0x1897F0A30", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xF86B40", Offset = "0xF85540", VA = "0x180F86B40", Slot = "29")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "34")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xD7D950", Offset = "0xD7C350", VA = "0x180D7D950", Slot = "35")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Transform HatBone
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "52")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public JOLHGBMRDLK OnAnimationCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x97F09F0", Offset = "0x97EF3F0", VA = "0x1897F09F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x97F08E0", Offset = "0x97EF2E0", VA = "0x1897F08E0", Slot = "36")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "31")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public PositionAndRotation HatPivotLocalPosAndRot
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x97F0920", Offset = "0x97EF320", VA = "0x1897F0920", Slot = "56")]
			get
			{
				return default(PositionAndRotation);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public UHAZOTSKNQO.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x97F0890", Offset = "0x97EF290", VA = "0x1897F0890", Slot = "32")]
			get
			{
				return default(UHAZOTSKNQO.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x97EB690", Offset = "0x97EA090", VA = "0x1897EB690", Slot = "51")]
		protected virtual GOVRREGVIBX AvatarItemDefinitionFromDisplayItemDefinition(DisplayItemData displayItemData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x97EDE70", Offset = "0x97EC870", VA = "0x1897EDE70")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x97F01B0", Offset = "0x97EEBB0", VA = "0x1897F01B0")]
		private void _UpdateManualLod()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x97EE420", Offset = "0x97ECE20", VA = "0x1897EE420")]
		private void QueuePostBuiltAvatarCustomizationUpdate(Action updateMatPropertAction)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x97EB5C0", Offset = "0x97E9FC0", VA = "0x1897EB5C0")]
		private void ApplyQueuedCustomizationUpdates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x97EB090", Offset = "0x97E9A90", VA = "0x1897EB090")]
		private void ApplyColorsToInstances()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x97ED7F0", Offset = "0x97EC1F0", VA = "0x1897ED7F0", Slot = "28")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x97EDD60", Offset = "0x97EC760", VA = "0x1897EDD60")]
		private PositionAndRotation GetHatAdjustmentOrDefault()
		{
			return default(PositionAndRotation);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x97EB460", Offset = "0x97E9E60", VA = "0x1897EB460", Slot = "45")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x97EDE40", Offset = "0x97EC840", VA = "0x1897EDE40", Slot = "48")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x97EE210", Offset = "0x97ECC10", VA = "0x1897EE210")]
		public Task PlayAnimation(string animationName)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x97EF9A0", Offset = "0x97EE3A0", VA = "0x1897EF9A0", Slot = "17")]
		public void SetUgcItemVisualOverrides(GOVRREGVIBX overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x97EFA20", Offset = "0x97EE420", VA = "0x1897EFA20", Slot = "18")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x97EF9E0", Offset = "0x97EE3E0", VA = "0x1897EF9E0", Slot = "19")]
		public void SetUgcTextureParameters(ZCEWZQPGOQS parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x97F0070", Offset = "0x97EEA70", VA = "0x1897F0070", Slot = "49")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x97F0170", Offset = "0x97EEB70", VA = "0x1897F0170", Slot = "50")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties effectFloat4Properties, TextureEffectMaterialTextures effectTexture2DProperties)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x97EE6D0", Offset = "0x97ED0D0", VA = "0x1897EE6D0", Slot = "46")]
		public void SetHatAnchorParams(KUFLWHMRCEV anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x97F00F0", Offset = "0x97EEAF0", VA = "0x1897F00F0", Slot = "47")]
		public void UpdateHatPivot([Optional] KUFLWHMRCEV anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x97EB650", Offset = "0x97EA050", VA = "0x1897EB650", Slot = "23")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x97EFB90", Offset = "0x97EE590", VA = "0x1897EFB90")]
		public void Setup([In] AvatarDisplaySetupState _)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x97EE510", Offset = "0x97ECF10", VA = "0x1897EE510", Slot = "33")]
		public bool SetBaseSkinCullingMask(UHAZOTSKNQO.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x97EE5D0", Offset = "0x97ECFD0", VA = "0x1897EE5D0", Slot = "20")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x97EF920", Offset = "0x97EE320", VA = "0x1897EF920", Slot = "21")]
		public void SetSkinColors(Color skinColor, Color? skinEmissiveColor, float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x97ED530", Offset = "0x97EBF30", VA = "0x1897ED530", Slot = "27")]
		public PGLTTIWTYKI BuildPotatoAvatar(VKTBDUIEYOX avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x97EF960", Offset = "0x97EE360", VA = "0x1897EF960", Slot = "22")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x97EE690", Offset = "0x97ED090", VA = "0x1897EE690")]
		public void SetFaceShape(AvatarFaceShape faceShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x97EE590", Offset = "0x97ECF90", VA = "0x1897EE590")]
		public void SetBodyShape(AvatarBodyShape bodyShape)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x97EE550", Offset = "0x97ECF50", VA = "0x1897EE550", Slot = "37")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x97EB050", Offset = "0x97E9A50", VA = "0x1897EB050", Slot = "38")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x97EE650", Offset = "0x97ED050", VA = "0x1897EE650", Slot = "39")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x97EE730", Offset = "0x97ED130", VA = "0x1897EE730", Slot = "40")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x97EB420", Offset = "0x97E9E20", VA = "0x1897EB420", Slot = "41")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x97EB580", Offset = "0x97E9F80", VA = "0x1897EB580", Slot = "42")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x97EE770", Offset = "0x97ED170", VA = "0x1897EE770")]
		public void SetNoseType(NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x97EE610", Offset = "0x97ED010", VA = "0x1897EE610", Slot = "43")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x97F00B0", Offset = "0x97EEAB0", VA = "0x1897F00B0", Slot = "44")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x97F0130", Offset = "0x97EEB30", VA = "0x1897F0130", Slot = "53")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x97ED7F0", Offset = "0x97EC1F0", VA = "0x1897ED7F0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0", Slot = "54")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayThirdPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "55")]
		public SkinnedMeshRenderer[] GetSkinnedMeshRendererArrayFirstPerson()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x97EB460", Offset = "0x97E9E60", VA = "0x1897EB460")]
		public void OnLateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x97EE270", Offset = "0x97ECC70", VA = "0x1897EE270")]
		private void PostOutfitUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x97EE250", Offset = "0x97ECC50", VA = "0x1897EE250")]
		private void PostMeshBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x97EE710", Offset = "0x97ED110", VA = "0x1897EE710", Slot = "16")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x97EF670", Offset = "0x97EE070", VA = "0x1897EF670")]
		public void SetRoomieBoostCustomizationFloat(float f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x97EF760", Offset = "0x97EE160", VA = "0x1897EF760")]
		public void SetRoomiePrimarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x97EF840", Offset = "0x97EE240", VA = "0x1897EF840")]
		public void SetRoomieSecondarySkinColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x97EE7B0", Offset = "0x97ED1B0", VA = "0x1897EE7B0")]
		public Task<EquipResult> SetOutfitSelection(IReadOnlyList<DisplayItemData> displayItemDatas, bool forceBuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x97ED570", Offset = "0x97EBF70", VA = "0x1897ED570")]
		private List<GOVRREGVIBX> CreateEquippedItemsFrorOutfitSelection(IReadOnlyList<Guid> customAvatarItemIds, IReadOnlyList<DisplayItemData> correspondingDADs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x97EC100", Offset = "0x97EAB00", VA = "0x1897EC100", Slot = "26")]
		public PGLTTIWTYKI BuildAvatarMeshes(VKTBDUIEYOX avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, GOVRREGVIBX>, (PGLTTIWTYKI, AUAMWGBNBSF<Dictionary<string, ZTZZICZDYWU<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x97EDC60", Offset = "0x97EC660", VA = "0x1897EDC60")]
		private bool GetCustomizationRequiresMeshBuild(List<DisplayItemData> newItemSelections)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x97EFEF0", Offset = "0x97EE8F0", VA = "0x1897EFEF0")]
		private void TeardownInProgressBuild()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x97EBB30", Offset = "0x97EA530", VA = "0x1897EBB30")]
		public PGLTTIWTYKI BuildAvatarMeshesInternal(VKTBDUIEYOX avatarBuildParams)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x97EFBD0", Offset = "0x97EE5D0", VA = "0x1897EFBD0")]
		private void SwapActiveResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x97EE4C0", Offset = "0x97ECEC0", VA = "0x1897EE4C0")]
		private void ReleasePrefabs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x97EDAD0", Offset = "0x97EC4D0", VA = "0x1897EDAD0")]
		private void FinalizeRoomieDisplayUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x97EE1B0", Offset = "0x97ECBB0", VA = "0x1897EE1B0")]
		private bool IsReadyToBuildLODMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x97ED8C0", Offset = "0x97EC2C0", VA = "0x1897ED8C0")]
		private PGLTTIWTYKI EditorBuildMeshes(bool isFirstPerson, List<UXMOFXXDVIG> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x97EFA60", Offset = "0x97EE460", VA = "0x1897EFA60")]
		private void SetupNewlyCreatedMesh(SkinnedMeshRenderer lodRenderer, int lod, Mesh mesh, List<Material> newUniqueMaterials)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x97EC110", Offset = "0x97EAB10", VA = "0x1897EC110")]
		private OVUANEJXOET BuildLODMesh(List<UXMOFXXDVIG> parts, int lod, bool isFirstPerson, Layers layer, bool IsSpreadAcrossFrames = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x97EBA50", Offset = "0x97EA450", VA = "0x1897EBA50")]
		[IteratorStateMachine(typeof(<AvatarRuntimeBuildMeshRoutine>d__125))]
		private IEnumerator<OSEXMMYDSBS> AvatarRuntimeBuildMeshRoutine(bool isFirstPerson, List<UXMOFXXDVIG> parts, int[] LODs, Func<int, Layers> getLayer, List<PGLTTIWTYKI> innerPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x97ED270", Offset = "0x97EBC70", VA = "0x1897ED270")]
		private PGLTTIWTYKI BuildLODMeshes(bool isFirstPerson, List<UXMOFXXDVIG> parts, int[] LODs, Func<int, Layers> getLayer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x97F03F0", Offset = "0x97EEDF0", VA = "0x1897F03F0")]
		public RoomieAvatarDisplay()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x97EE4A0", Offset = "0x97ECEA0", VA = "0x1897EE4A0", Slot = "14")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x97EE4B0", Offset = "0x97ECEB0", VA = "0x1897EE4B0", Slot = "15")]
		private void RecRoom.Avatars.IAvatarDisplaySystem.Setup([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[Tested]
	public class JWBTZWUEFOS : BLYMWIUNTWU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		protected readonly List<Mesh> XUQSINXVGLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		protected readonly List<IReadOnlyList<byte>> PFDXXFSZMVQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		protected readonly List<Matrix4x4> NDIKWBUAOCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		protected readonly List<bool> JVLSINSVRNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly List<long> KLCLNPKEDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		protected readonly List<bool> SITPKSEMXVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		protected readonly List<int> UMCUJPRIQOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		protected Allocator XNBYPPDWUBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		protected MeshMergeModes BCKPDEMRIIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		protected byte VQMSVBOIFJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		protected IList<int> YHDBBEXNYEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		protected IList<int> CYIDJDKLAVC;

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x97EA300", Offset = "0x97E8D00", VA = "0x1897EA300", Slot = "4")]
		public void EXNGROUQKPW(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, UHAZOTSKNQO.SkinCullingMask e = (UHAZOTSKNQO.SkinCullingMask)0L, int f = -1, bool g = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x97EA920", Offset = "0x97E9320", VA = "0x1897EA920", Slot = "5")]
		public void SMCGHCRCHTM(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x97EA6C0", Offset = "0x97E90C0", VA = "0x1897EA6C0")]
		private static void QXOPPUKPZSO(Mesh a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x97EA960", Offset = "0x97E9360", VA = "0x1897EA960")]
		public JWBTZWUEFOS()
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
		[Cpp2IlInjected.Address(RVA = "0x97D92C0", Offset = "0x97D7CC0", VA = "0x1897D92C0", Slot = "4")]
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
		public int SCHASULYQQI
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x97D64E0", Offset = "0x97D4EE0", VA = "0x1897D64E0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x97D64F0", Offset = "0x97D4EF0", VA = "0x1897D64F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int ITYWRWRUGNM
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x97D5B20", Offset = "0x97D4520", VA = "0x1897D5B20")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x97D64D0", Offset = "0x97D4ED0", VA = "0x1897D64D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public int YOGNTJDZKHG
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x97D5B10", Offset = "0x97D4510", VA = "0x1897D5B10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x97D5B30", Offset = "0x97D4530", VA = "0x1897D5B30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int SWNXCRHMZIF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x97D4920", Offset = "0x97D3320", VA = "0x1897D4920")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x97D7130", Offset = "0x97D5B30", VA = "0x1897D7130")]
		public AvatarCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels, RSABMSGSPPA systemInfoAccess, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x97D6380", Offset = "0x97D4D80", VA = "0x1897D6380")]
		public void RDPTPQYKNEA(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x97D5F50", Offset = "0x97D4950", VA = "0x1897D5F50")]
		public void RDDHPDQHZJM(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x97D69D0", Offset = "0x97D53D0", VA = "0x1897D69D0")]
		public Color YRFCBIPALCP(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x97D6CF0", Offset = "0x97D56F0", VA = "0x1897D6CF0")]
		public void ZABBMFBKHFN(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x97D6500", Offset = "0x97D4F00", VA = "0x1897D6500")]
		public void VDXASUJPNDF(int a, Vector3 b, Vector3 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x97D5B40", Offset = "0x97D4540", VA = "0x1897D5B40")]
		public void MTTMXVMZNDD(int a, half4 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x97D5C90", Offset = "0x97D4690", VA = "0x1897D5C90")]
		public void ONIGKPNSLGJ(int a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x97D65F0", Offset = "0x97D4FF0", VA = "0x1897D65F0")]
		public void VZVPPJKXQRF(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x97D5F40", Offset = "0x97D4940", VA = "0x1897D5F40")]
		public void PZZXZKGVNVM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x97D5EE0", Offset = "0x97D48E0", VA = "0x1897D5EE0")]
		public bool OVKMMORVBCP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x97D6410", Offset = "0x97D4E10", VA = "0x1897D6410")]
		public void SDHDAJUVQIN(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x97D4990", Offset = "0x97D3390", VA = "0x1897D4990", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x97D4BF0", Offset = "0x97D35F0", VA = "0x1897D4BF0")]
		public Mesh EQOEBDUNDFA([Optional] string a)
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
		public int UGOTSXZDVXK
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x97D7E10", Offset = "0x97D6810", VA = "0x1897D7E10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int QJHKOBOYSUO
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x97D7F00", Offset = "0x97D6900", VA = "0x1897D7F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int KKFOQSLMMIT
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x97D7D30", Offset = "0x97D6730", VA = "0x1897D7D30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public int DTRUCGXTMLY
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x97D7B70", Offset = "0x97D6570", VA = "0x1897D7B70")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x97D7F20", Offset = "0x97D6920", VA = "0x1897D7F20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int SCHASULYQQI
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x97D7F10", Offset = "0x97D6910", VA = "0x1897D7F10")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x97D7F30", Offset = "0x97D6930", VA = "0x1897D7F30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public int VHBINUKZITV
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x97D7B60", Offset = "0x97D6560", VA = "0x1897D7B60")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x97D7EF0", Offset = "0x97D68F0", VA = "0x1897D7EF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public MeshMergeModes UFNSNIMFXYG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x97D7D20", Offset = "0x97D6720", VA = "0x1897D7D20")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x97D7B80", Offset = "0x97D6580", VA = "0x1897D7B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public byte WDTFEXMLVSX
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x97D7E00", Offset = "0x97D6800", VA = "0x1897D7E00")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x97D7D10", Offset = "0x97D6710", VA = "0x1897D7D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public AvatarCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x97D9070", Offset = "0x97D7A70", VA = "0x1897D9070")]
			get
			{
				return default(AvatarCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x97D7F40", Offset = "0x97D6940", VA = "0x1897D7F40")]
		public AvatarCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode, bool semiOptimizedBoneWeight = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x97D7E20", Offset = "0x97D6820", VA = "0x1897D7E20")]
		public AvatarCullAndCombineMeshJobContainer RUAWSLWOBES(Allocator a, RSABMSGSPPA b)
		{
			return default(AvatarCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x97D7B90", Offset = "0x97D6590", VA = "0x1897D7B90", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Tested]
	public class OYPCZYGQOEJ : JWBTZWUEFOS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool RIRXHMQPRWK;

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly ProfilerMarker ZJPNFMBVPKX;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x97EAC30", Offset = "0x97E9630", VA = "0x1897EAC30")]
		public AvatarCullAndCombineMeshJobGroup RMNTKSHLUSG()
		{
			return default(AvatarCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x97EAED0", Offset = "0x97E98D0", VA = "0x1897EAED0")]
		public OYPCZYGQOEJ()
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
			EditorToolAll,
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			BestLODOnly
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public struct LodInfo
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public bool knownGoodData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public long bytes;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public int numTris;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
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
		protected LODSelection EOTGVNLTOLR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		protected int[] NOZFGJNWHCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public int requestedLod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		protected int ZTRMCPTWOCM;

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
		protected FQMRJXVJOSP MBZEKSIGZDY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		protected PGLTTIWTYKI NKGAKRSUWUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		protected (bool isLodForced, int forcedLOD) XQRGOCJGWTX;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public virtual int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0xD2ED50", Offset = "0xD2D750", VA = "0x180D2ED50", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD83C10", Offset = "0xD82610", VA = "0x180D83C10", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public bool GAEIDLXYWTH
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x97DB740", Offset = "0x97DA140", VA = "0x1897DB740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public virtual bool ZTRGCTEPFJX
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static bool YXHXKAXXYOG
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x97DB700", Offset = "0x97DA100", VA = "0x1897DB700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public FQMRJXVJOSP SDZOJFBZQOR
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xD14190", Offset = "0xD12B90", VA = "0x180D14190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x97DB800", Offset = "0x97DA200", VA = "0x1897DB800")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		protected PGLTTIWTYKI GZBDTZJXNRO
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xD1DDA0", Offset = "0xD1C7A0", VA = "0x180D1DDA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x97DB260", Offset = "0x97D9C60", VA = "0x1897DB260")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public int UTAYKQSLUTS
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x97DBB00", Offset = "0x97DA500", VA = "0x1897DBB00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public AvatarBodyType DJVMGMQSDYG
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x97DB6B0", Offset = "0x97DA0B0", VA = "0x1897DB6B0")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public virtual event Action RSBLZEPLZZV
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x97DB610", Offset = "0x97DA010", VA = "0x1897DB610", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x97DB760", Offset = "0x97DA160", VA = "0x1897DB760", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x97DB2F0", Offset = "0x97D9CF0", VA = "0x1897DB2F0", Slot = "8")]
		public virtual (bool, bool, bool) WhichLodsAreResident()
		{
			return default((bool, bool, bool));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "9")]
		public virtual void CheckMeshesAgainstDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x97DB080", Offset = "0x97D9A80", VA = "0x1897DB080", Slot = "10")]
		public virtual (int, long, int) GetDisplayedLodInfo()
		{
			return default((int, long, int));
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x10BC520", Offset = "0x10BAF20", VA = "0x1810BC520")]
		protected void YYRTUPYATHZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x97DB190", Offset = "0x97D9B90", VA = "0x1897DB190")]
		protected void SIOEQNJYGYG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x1626920", Offset = "0x1625320", VA = "0x181626920")]
		protected void MYFBNNUQGKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x97DAFD0", Offset = "0x97D99D0", VA = "0x1897DAFD0", Slot = "12")]
		public virtual Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x97DAF60", Offset = "0x97D9960", VA = "0x1897DAF60")]
		protected void BEVYBFUWZSW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x97DB1A0", Offset = "0x97D9BA0", VA = "0x1897DB1A0", Slot = "13")]
		protected virtual void UNIUBMGECCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x97DB0E0", Offset = "0x97D9AE0", VA = "0x1897DB0E0")]
		public int MeshesAtLODCount(int LOD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x97DB510", Offset = "0x97D9F10", VA = "0x1897DB510")]
		public AvatarDisplayBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class AvatarDisplaySystem : FQMRJXVJOSP
	{
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private sealed class IGXBGQIOYBH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			public AvatarDisplaySystem TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000181")]
			public Color ATZLCCYQEVI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000182")]
			public Color? MKLYTSAJJUT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x4000183")]
			public float? PDMSDVZLRLB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000184")]
			public Action<ODHBISUOWWB> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public IGXBGQIOYBH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x97FBB90", Offset = "0x97FA590", VA = "0x1897FBB90")]
			internal void UQQUAXFUDLV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0x97FBAF0", Offset = "0x97FA4F0", VA = "0x1897FBAF0")]
			internal void UQLNDQLWUAM(ODHBISUOWWB a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class BXAAERVMRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000185")]
			public bool BBDSQGXSDOX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
			[Cpp2IlInjected.Token(Token = "0x4000186")]
			public bool UGOYWPCAQGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000187")]
			public AvatarDisplaySystem TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000188")]
			public PGLTTIWTYKI WLAMSNVNPYY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000189")]
			public Action<KeyValuePair<string, ZTZZICZDYWU<Texture2D>>> WXHZXFKWKCP;

			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BXAAERVMRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000174")]
			[Cpp2IlInjected.Address(RVA = "0x97FAA50", Offset = "0x97F9450", VA = "0x1897FAA50")]
			internal bool LOIEJAARYVW(GOVRREGVIBX a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000175")]
			[Cpp2IlInjected.Address(RVA = "0x97FAB10", Offset = "0x97F9510", VA = "0x1897FAB10")]
			internal bool RHOKUNOSQEY(GOVRREGVIBX a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000176")]
			[Cpp2IlInjected.Address(RVA = "0x97FAAD0", Offset = "0x97F94D0", VA = "0x1897FAAD0")]
			internal void LPNTSOQCDLY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000177")]
			[Cpp2IlInjected.Address(RVA = "0x97FAAF0", Offset = "0x97F94F0", VA = "0x1897FAAF0")]
			internal void LQDOKIXUFTZ(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000178")]
			[Cpp2IlInjected.Address(RVA = "0x97FAAD0", Offset = "0x97F94D0", VA = "0x1897FAAD0")]
			internal void RIEFMHWKSMZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000179")]
			[Cpp2IlInjected.Address(RVA = "0x97FAAF0", Offset = "0x97F94F0", VA = "0x1897FAAF0")]
			internal void RIJMJOQIBYI(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x97FABA0", Offset = "0x97F95A0", VA = "0x1897FABA0")]
			internal void RIOTGVKFLJR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x97FABD0", Offset = "0x97F95D0", VA = "0x1897FABD0")]
			internal void RIUAECECUVA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x97FAC00", Offset = "0x97F9600", VA = "0x1897FAC00")]
			internal void RJENYPRXNRS(Dictionary<string, ZTZZICZDYWU<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x97FA990", Offset = "0x97F9390", VA = "0x1897FA990")]
			internal void LJQBDINZZLR(KeyValuePair<string, ZTZZICZDYWU<Texture2D>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			internal LTBUWQFXCGW RJJUVWLUXDB()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class BXFHBYPKANN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018A")]
			public int KWZLIHFAOOS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018B")]
			public BXAAERVMRCE UZNLTVLUBPB;

			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BXFHBYPKANN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x97FACB0", Offset = "0x97F96B0", VA = "0x1897FACB0")]
			internal Layers LPYHNCDWWIQ(int a)
			{
				return default(Layers);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		[CompilerGenerated]
		private sealed class BXKNZFJHJYW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018C")]
			public AUAMWGBNBSF<Dictionary<string, ZTZZICZDYWU<Texture2D>>> OHLWCPSBOYH;

			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public BXKNZFJHJYW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			internal AUAMWGBNBSF<Dictionary<string, ZTZZICZDYWU<Texture2D>>> RIZHBIYAEGJ()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class EBSCOOQWIJN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400018D")]
			public AvatarDisplaySystem TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400018E")]
			public float NLBMGUDNKUX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400018F")]
			public Color MNJUFNZIYGF;

			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EBSCOOQWIJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0x97FAE40", Offset = "0x97F9840", VA = "0x1897FAE40")]
			internal void KVAQPFQHUEN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class EAFIVIHKRYC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000190")]
			public List<PGLTTIWTYKI> XLJXXFAKPBO;

			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EAFIVIHKRYC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x97FAD10", Offset = "0x97F9710", VA = "0x1897FAD10")]
			internal void SQPBUBMMGBI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class FGOIROAGWBN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000191")]
			public string NAHWNLLIZQS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000192")]
			public AvatarBodyPart MHJMVDETNZN;

			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public FGOIROAGWBN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0x97FAE80", Offset = "0x97F9880", VA = "0x1897FAE80")]
			internal bool NMFQVTRVPDL(KeyValuePair<string, GOVRREGVIBX> a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class WNNNHEZNPUO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000193")]
			public List<OVEKQGJRAJB> YIYIHSBPXZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000194")]
			public List<OVEKQGJRAJB> SRVJOLRFZZA;

			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNNNHEZNPUO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0x9805D00", Offset = "0x9804700", VA = "0x189805D00")]
			internal LTBUWQFXCGW RRRUQXHGXAL(UXMOFXXDVIG a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class WNSUELTKZFX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000195")]
			public ZJNBIUQLBKF NQUAZMADPAI;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public WNSUELTKZFX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xE920E0", Offset = "0xE90AE0", VA = "0x180E920E0")]
			internal void RSCILKVBPXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0xE92100", Offset = "0xE90B00", VA = "0x180E92100")]
			internal void RRXBOEBEGLU(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		[CompilerGenerated]
		private sealed class CDZEDXAQFAB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000196")]
			public ZJNBIUQLBKF NQUAZMADPAI;

			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public CDZEDXAQFAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xE920E0", Offset = "0xE90AE0", VA = "0x180E920E0")]
			internal void RSCILKVBPXD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xE92100", Offset = "0xE90B00", VA = "0x180E92100")]
			internal void RRXBOEBEGLU(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private sealed class FTDJUAEMVHK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000197")]
			public long RDVOKSVYCBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000198")]
			public Stopwatch ZJYACGJELHT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000199")]
			public SkinnedMeshRenderer VCVPMMISPOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400019A")]
			public long MMNVAVDEHGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400019B")]
			public string BPVBUCSRQLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400019C")]
			public long TRXCDUVTPER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400019D")]
			public AvatarDisplaySystem TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400019E")]
			public int WWFCWVJTORD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400019F")]
			public List<Material> HQAUJCTTWGD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001A0")]
			public List<(int mat, int part)> GKMVKLSSOXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001A1")]
			public List<Bounds> CTKAIFXIYQG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001A2")]
			public int WTZZKYIFMMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x40001A3")]
			public long KTITKIFAZYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			public long RKTPKZUNEWW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			public long VNIXNZEYYSI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			public Action ZQHOOLBDIFU;

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public FTDJUAEMVHK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private sealed class FTIQRGYKEST
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			public bool TIDVTJVEITZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			public JobHandle OQQDCDLCMKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001A9")]
			public AvatarCullAndCombineMeshJobContainer WVKFTQPOXKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
			[Cpp2IlInjected.Token(Token = "0x40001AA")]
			public AvatarCullAndCombineMeshJobGroup TNCKBISCNKV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
			[Cpp2IlInjected.Token(Token = "0x40001AB")]
			public FTDJUAEMVHK UZNLTVLUBPB;

			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public FTIQRGYKEST()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x97FAF20", Offset = "0x97F9920", VA = "0x1897FAF20")]
			internal void DZLQVSXTCJU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0x97F17A0", Offset = "0x97F01A0", VA = "0x1897F17A0")]
			internal void DZQXSZRQLVD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		[CompilerGenerated]
		private sealed class FTNXONSHOEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001AC")]
			public bool TIDVTJVEITZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001AD")]
			public JobHandle OQQDCDLCMKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001AE")]
			public AvatarLegacyCullAndCombineMeshJobContainer AAXIMVFMSHE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
			[Cpp2IlInjected.Token(Token = "0x40001AF")]
			public AvatarLegacyCullAndCombineMeshJobGroup UHEIMQKYDTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
			[Cpp2IlInjected.Token(Token = "0x40001B0")]
			public FTDJUAEMVHK UZSSRCFRLAK;

			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public FTNXONSHOEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0x97FB4E0", Offset = "0x97F9EE0", VA = "0x1897FB4E0")]
			internal void DZBDBFJYJNC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0x97F1A50", Offset = "0x97F0450", VA = "0x1897F1A50")]
			internal void DZGJYMDVSYL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class IBOKDPVVYOU : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001B1")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001B2")]
			private OSEXMMYDSBS RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001B3")]
			public bool RHXYVSIDQCQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001B4")]
			public AvatarDisplaySystem TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40001B5")]
			public List<UXMOFXXDVIG> ADZGRDCMLZG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40001B6")]
			public List<PGLTTIWTYKI> XLJXXFAKPBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40001B7")]
			public int[] YSZJDZCLAPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40001B8")]
			public bool HYYCDKJNRVP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x40001B9")]
			public Func<int, Layers> COOACLVFWST;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40001BA")]
			public ODHBISUOWWB RQTSZPMHCXJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40001BB")]
			public Material CKAJBYUGHLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40001BC")]
			private int FWXGQTJIIDE;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			private OSEXMMYDSBS XMCHSAEGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x600019B")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600019D")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public IBOKDPVVYOU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0x97FB850", Offset = "0x97FA250", VA = "0x1897FB850", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0x97FB810", Offset = "0x97FA210", VA = "0x1897FB810", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private static readonly Log BVZAKVSMYEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly JOLHGBMRDLK WWPRPOPSGJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly JOLHGBMRDLK UVFIEQNOTGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private Dictionary<BodyProperty, float> DKRLWQXJKNY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<FaceProperty, float> FUVTKFGRNRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private Dictionary<NoseProperty, float> TQFGJYSYPFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private IReadOnlyDictionary<string, BoneLocalInfo> XVLGJPFMYYU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private Dictionary<string, BoneLocalInfo> IDEIPQBVQZW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private Dictionary<string, BoneLocalInfo> PKCEUKLTPKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private Dictionary<string, BoneLocalInfo> QZKGSKABKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private AvatarBuildType MQAWDKMIDJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private AvatarBuildType ZBDXDUBPTUN;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private static float NSHUJBEPKRV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private AvatarConfiguration REMNHYYCGZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private Transform BKFQBLZNLOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private AvatarSkinAssetItem ZXIYSCJATJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private AssetReference CBHOFRWOVDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private AssetReference TGEUVJUQIOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private AssetReference DGYHBJBWYLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private AssetReference TCTHNCFDFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private GameObject ZXSQFVHXNQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private GameObject CFAOWYIMFKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private GameObject ULWVUSOIZUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private SkinnedMeshRenderer VOORHMGKQWM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private AvatarSkinnedMeshBoneOrderRemapsData TBLWLRKFAUN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Transform[] MTQXDABUMQR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private Matrix4x4[] LWWFQOCTFST;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private Material BIOYHZYIDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Material PLJRGJKSEOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private Texture2D UOMOILBRHFT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private Material RPCKOGACKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private Material LBQMXRCDZTV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		private Material QUGYAKVPTTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private Shader BVPMKFAYLDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private Shader FXEWVNIIQVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		private Animator BNZNVMXOUUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Renderer[] MMNKNIZLBJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private UHAZOTSKNQO.SkinCullingMask PDUYMGRZGBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		private AvatarBodyPartShapesManager RWKAQWYNITC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		private IReadOnlyDictionary<string, Transform> LBRZKTPTKRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		private bool PXGAIEQVZIU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x139")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		private bool ZJWOOTPFAHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13C")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		private Color CZOLMJZCYAV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14C")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		private Color? MVYNBJPBZDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		private Texture2D OQXEFKAKEZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private float? HFWGRCJVOEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		private Color KZNNFBHFPDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		private Color ALKPFTFXZUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Color? TMMYPLTLUSS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Color? ZUTMMUOJFYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Color? RQYNGEBFJOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Color? BOJWWCKOJZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		private Texture2D FMWCTMDZZHQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		private Texture2D NVQTCJQYKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[CanBeNull]
		private GOVRREGVIBX RVBQSCXCOTN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		private Texture TTJWVGLXNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private Color FFMYTYKXMZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public Dictionary<Renderer, ODHBISUOWWB> ISDAMCGBOFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private Dictionary<Renderer, ODHBISUOWWB> UAADYDWKPOR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private Dictionary<string, List<AvatarMaterialKey>> TFHQWIOJMUT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private Dictionary<string, List<AvatarMaterialKey>> PUESKIGRVGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		private readonly List<OVEKQGJRAJB> YIYIHSBPXZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private readonly List<OVEKQGJRAJB> IRJRKXSRTSJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		private readonly List<OVEKQGJRAJB> SRVJOLRFZZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		private readonly List<OVEKQGJRAJB> WZMGBWPZAQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		private Dictionary<AvatarMaterialKey, Material> GRKJEDKCFFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		private Dictionary<AvatarMaterialKey, Material> FOUBFFZSQOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private SkinnedMeshRenderer[] CDMKQIMPTSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private SkinnedMeshRenderer[] GLRLNRCPVNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		private SkinnedMeshRenderer[] SJOIICBIVRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private SkinnedMeshRenderer[] ROALHPAWVZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		private readonly Dictionary<string, ZTZZICZDYWU<Texture2D>> HPRCIXRYWXJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private readonly Dictionary<string, ZTZZICZDYWU<Texture2D>> WMVKAMPAOWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private AdditionalHatData MFXHLKAFWAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private AdditionalHatData OJMFKSMLHLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private RecRoom.Avatars.Data.Shared.HairData DHBWWORSWKT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private RecRoom.Avatars.Data.Shared.HairData VUANIQPHVIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private KUFLWHMRCEV YGRGENUSYZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private bool? CWOCJOSAPZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2BC")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private PositionAndRotation PUGFYWLXSTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private Transform PDTZHMRRKNV;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private Material FLXSUEJYHIS;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private Material KFMXCLLWAML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private Dictionary<string, GOVRREGVIBX> APRLVPMVVMD;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly int LBFKTUIRHLO;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly int GNQCPJWTGUE;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly int NOPIMXFUNUQ;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly int TKTLFAANCYB;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly int XTAPEKPYPFH;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly int HJGTDKVWGCO;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly int OEUULEHGSQD;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly int BVAXFMRHVAB;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly int VYFENZUSEAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private bool BHTPGYJJZJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2F9")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private bool FXTDWIOJOAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private List<Action> GLYLJCUQYPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private ZCEWZQPGOQS EPBEQIFDWFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private SkinnedMeshRenderer[] YTQHFKRRVPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private int UTTMYJAVVNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31C")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private bool DYGVKLRGMSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private int ZTRMCPTWOCM;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public JOLHGBMRDLK DisplayBuildCompleted
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "14")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public JOLHGBMRDLK DisplayBuildCancelled
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "15")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public AvatarConfiguration Configuration
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0xD14490", Offset = "0xD12E90", VA = "0x180D14490", Slot = "26")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public bool AKEFTMEMVNN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x97E8980", Offset = "0x97E7380", VA = "0x1897E8980")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x97E3610", Offset = "0x97E2010", VA = "0x1897E3610")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private Material SGCLHABWEFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x97E6EC0", Offset = "0x97E58C0", VA = "0x1897E6EC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private Material JNJGXQFUHUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x97E9380", Offset = "0x97E7D80", VA = "0x1897E9380")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private bool ZVGDMYRJYGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public AvatarBodyType DisplayBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x97EA0F0", Offset = "0x97E8AF0", VA = "0x1897EA0F0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return default(AvatarBodyType);
			}
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x97EA270", Offset = "0x97E8C70", VA = "0x1897EA270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Material FaceSharedMaterial
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0xF86CE0", Offset = "0xF856E0", VA = "0x180F86CE0", Slot = "20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public SkinnedMeshRenderer[] BuiltBodySkinMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x2566880", Offset = "0x2565280", VA = "0x182566880", Slot = "19")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public Renderer[] WatchMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0xF86C80", Offset = "0xF85680", VA = "0x180F86C80", Slot = "21")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool IsVisibleInCamera
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x97EA100", Offset = "0x97E8B00", VA = "0x1897EA100", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public UHAZOTSKNQO.SkinCullingMask BaseSkinCullingMask
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0xD8BD50", Offset = "0xD8A750", VA = "0x180D8BD50", Slot = "22")]
			get
			{
				return default(UHAZOTSKNQO.SkinCullingMask);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public int BXJVRDBGZUD
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0x97E5920", Offset = "0x97E4320", VA = "0x1897E5920")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x97E69A0", Offset = "0x97E53A0", VA = "0x1897E69A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		private bool JENJUCTYQGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x97E8A20", Offset = "0x97E7420", VA = "0x1897E8A20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		private static bool MLXZUKWBDYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x97DD440", Offset = "0x97DBE40", VA = "0x1897DD440", Slot = "17")]
		public PGLTTIWTYKI BuildPotatoAvatar(VKTBDUIEYOX avatarBuildParams, bool isFirstPerson, int[] LODs)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x97DD410", Offset = "0x97DBE10", VA = "0x1897DD410", Slot = "16")]
		public PGLTTIWTYKI BuildAvatarMeshes(VKTBDUIEYOX avatarBuildParams, bool isFirstPerson, int[] LODs, Func<Dictionary<string, GOVRREGVIBX>, (PGLTTIWTYKI, AUAMWGBNBSF<Dictionary<string, ZTZZICZDYWU<Texture2D>>>)> getDownloadUgcTexturesPromises)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x97E1190", Offset = "0x97DFB90", VA = "0x1897E1190")]
		public PGLTTIWTYKI JEVIDADNDFB(VKTBDUIEYOX a, bool b, int[] c, bool d, AvatarBuildType e, [Optional] Func<Dictionary<string, GOVRREGVIBX>, (PGLTTIWTYKI, AUAMWGBNBSF<Dictionary<string, ZTZZICZDYWU<Texture2D>>>)> f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x97E4D60", Offset = "0x97E3760", VA = "0x1897E4D60")]
		public static void OISKFKRKVPK(Log a, string b, AssetReference c, AssetReference[] d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x97E6050", Offset = "0x97E4A50", VA = "0x1897E6050")]
		private bool STHITMBPMMK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x97E4680", Offset = "0x97E3080", VA = "0x1897E4680")]
		private PGLTTIWTYKI NOBDZOVUQQY(bool a, List<UXMOFXXDVIG> b, int[] c, Func<int, Layers> d, bool e = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x97E3500", Offset = "0x97E1F00", VA = "0x1897E3500")]
		[IteratorStateMachine(typeof(IBOKDPVVYOU))]
		private IEnumerator<OSEXMMYDSBS> JTFZVNPXFGS(bool a, List<UXMOFXXDVIG> b, int[] c, Func<int, Layers> d, ODHBISUOWWB e, Material f, List<PGLTTIWTYKI> g, bool h)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x97DBB20", Offset = "0x97DA520", VA = "0x1897DBB20")]
		public static void AARXOHWHOTT(List<UXMOFXXDVIG> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x97E5B80", Offset = "0x97E4580", VA = "0x1897E5B80")]
		public static PGLTTIWTYKI SFBRGYRVXTZ(List<UXMOFXXDVIG> a, List<OVEKQGJRAJB> b, List<OVEKQGJRAJB> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x97E5E20", Offset = "0x97E4820", VA = "0x1897E5E20")]
		public PGLTTIWTYKI SFBRGYRVXTZ(List<UXMOFXXDVIG> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x97DD470", Offset = "0x97DBE70", VA = "0x1897DD470")]
		private OVUANEJXOET CYQTTBNPJSM(List<UXMOFXXDVIG> a, int b, bool c, Layers d, bool e, ODHBISUOWWB f, Material g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x97E6290", Offset = "0x97E4C90", VA = "0x1897E6290", Slot = "27")]
		public void SetBodyProperty(BodyProperty bodyProperty, float value, bool refreshBodyPropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x97E6810", Offset = "0x97E5210", VA = "0x1897E6810", Slot = "29")]
		public void SetFaceProperty(FaceProperty faceProperty, float value, bool refreshFacePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x97E69C0", Offset = "0x97E53C0", VA = "0x1897E69C0", Slot = "30")]
		public void SetNoseProperty(NoseProperty noseProperty, float value, bool refreshNosePropertyState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x97DCAE0", Offset = "0x97DB4E0", VA = "0x1897DCAE0", Slot = "28")]
		public void ApplyBodyProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x97DCB40", Offset = "0x97DB540", VA = "0x1897DCB40", Slot = "31")]
		public void ApplyFaceProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x97DCC00", Offset = "0x97DB600", VA = "0x1897DCC00", Slot = "32")]
		public void ApplyNoseProperties(bool forceUpdate = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x97DCA60", Offset = "0x97DB460", VA = "0x1897DCA60")]
		private void ALKBWUCHYWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x97E3620", Offset = "0x97E2020", VA = "0x1897E3620")]
		private void LLZBUDLOEGQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x97DE710", Offset = "0x97DD110", VA = "0x1897DE710")]
		private void DNAUREGXXZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x97E7930", Offset = "0x97E6330", VA = "0x1897E7930", Slot = "34")]
		public void UpdateFaceAndBodyShapes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x97E88A0", Offset = "0x97E72A0", VA = "0x1897E88A0", Slot = "41")]
		public void UpdateNoseShape()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x97E6800", Offset = "0x97E5200", VA = "0x1897E6800", Slot = "33")]
		public void SetDeformation(bool deformBody, bool deformHead)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x97E8BA0", Offset = "0x97E75A0", VA = "0x1897E8BA0")]
		private void YFOMSPPMKSV(SkinnedMeshRenderer a, int b, Mesh c, List<Material> d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x97E7390", Offset = "0x97E5D90", VA = "0x1897E7390")]
		public static Material UAGSPIEETYA(Dictionary<AvatarMaterialKey, Material> a, Material b, UpdatableColorType c, UpdatableTextureType d, AvatarBodyPart e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x97DFAA0", Offset = "0x97DE4A0", VA = "0x1897DFAA0")]
		public static UpdatableColorType HUJBCRUPOVJ(UXMOFXXDVIG a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x97DEED0", Offset = "0x97DD8D0", VA = "0x1897DEED0")]
		private void ETDAVCCDJGC(int a, Material b, UXMOFXXDVIG c, [Out] Texture2D d, [Out] Vector4 e, [Out] Texture2D f, [Out] Texture2D g, [Out] Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x97E00F0", Offset = "0x97DEAF0", VA = "0x1897E00F0")]
		private void IQUKWOOZCBQ(int a, Material b, UXMOFXXDVIG c, [Out] Color d, [Out] Color e, [Out] Color f, [Out] Color g, [Out] Color h, [Out] Color i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x97DCDE0", Offset = "0x97DB7E0", VA = "0x1897DCDE0")]
		private bool BEKBJXCCVXZ(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x97E8990", Offset = "0x97E7390", VA = "0x1897E8990")]
		private static Material XGOUMIEHICN(int a, SENPQXIUYUS b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x97E8AC0", Offset = "0x97E74C0", VA = "0x1897E8AC0")]
		public static UpdatableTextureType YBSIEUZIRDN(UXMOFXXDVIG a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x97E9060", Offset = "0x97E7A60", VA = "0x1897E9060")]
		private static void ZDZKXLCNPOS(Dictionary<string, List<AvatarMaterialKey>> a, UXMOFXXDVIG b, Material c, UpdatableColorType d, UpdatableTextureType e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x97E8CF0", Offset = "0x97E76F0", VA = "0x1897E8CF0")]
		public static SkinnedMeshRenderer YKIGRGHHUBW(Transform a, Transform b, SkinnedMeshRenderer[] c, int d, Layers e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x97E9810", Offset = "0x97E8210", VA = "0x1897E9810")]
		public AvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x97E06F0", Offset = "0x97DF0F0", VA = "0x1897E06F0")]
		public void Initialize([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x97DEAC0", Offset = "0x97DD4C0", VA = "0x1897DEAC0")]
		public void ZFDZXDNFWTN([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x97E69A0", Offset = "0x97E53A0", VA = "0x1897E69A0", Slot = "6")]
		public void SetManualLOD(int lod)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x97E6BF0", Offset = "0x97E55F0", VA = "0x1897E6BF0", Slot = "12")]
		public void SetTexture(AvatarTextureType textureType, Texture2D texture)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
		public static bool GYDEDJFVKSI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x97DCC60", Offset = "0x97DB660", VA = "0x1897DCC60", Slot = "13")]
		public bool AreMeshesBuilt()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x97E6380", Offset = "0x97E4D80", VA = "0x1897E6380", Slot = "10")]
		public void SetColor(AvatarColorType colorType, Color? color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x97E6AB0", Offset = "0x97E54B0", VA = "0x1897E6AB0", Slot = "11")]
		public void SetSkinColors(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x97E8F20", Offset = "0x97E7920", VA = "0x1897E8F20")]
		private void YLJUYKVDZVM(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x97E6E00", Offset = "0x97E5800", VA = "0x1897E6E00", Slot = "7")]
		public void SetUgcItemVisualOverrides(GOVRREGVIBX overrideItem, Texture ugcTextureOverride, Color ugcColorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x97E3610", Offset = "0x97E2010", VA = "0x1897E3610", Slot = "8")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x24B3A50", Offset = "0x24B2450", VA = "0x1824B3A50", Slot = "9")]
		public void SetUgcTextureParameters(ZCEWZQPGOQS parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x97E71A0", Offset = "0x97E5BA0", VA = "0x1897E71A0", Slot = "18")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x97DCBA0", Offset = "0x97DB5A0", VA = "0x1897DCBA0", Slot = "35")]
		public void ApplyHatAdjustments()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x97E6900", Offset = "0x97E5300", VA = "0x1897E6900", Slot = "36")]
		public void SetHatAnchorParams(KUFLWHMRCEV anchorParamsData, bool useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x97E7A70", Offset = "0x97E6470", VA = "0x1897E7A70", Slot = "37")]
		public void UpdateHatPivot([Optional] KUFLWHMRCEV anchorParamsData, [Optional] bool? useHairFitMeshHemisphere)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x97E7060", Offset = "0x97E5A60", VA = "0x1897E7060")]
		private bool TPMEFIDRZFW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x97E6270", Offset = "0x97E4C70", VA = "0x1897E6270", Slot = "23")]
		public bool SetBaseSkinCullingMask(UHAZOTSKNQO.SkinCullingMask cullingMask)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x97E77E0", Offset = "0x97E61E0", VA = "0x1897E77E0", Slot = "39")]
		public void UpdateEmissiveEffect(float power, Color color, bool reliable = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x97DC160", Offset = "0x97DAB60", VA = "0x1897DC160")]
		public void ACQEQODCCMA(float a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x97E59B0", Offset = "0x97E43B0", VA = "0x1897E59B0")]
		private static bool RCXYYIDZTQX(Material a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x97E88F0", Offset = "0x97E72F0", VA = "0x1897E88F0", Slot = "40")]
		public void UpdateTextureEffect(TextureEffectMaterialProperties materialProperties, TextureEffectMaterialTextures materialTextures)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x97E5B60", Offset = "0x97E4560", VA = "0x1897E5B60")]
		private static bool RYTBOXMWJLV(AvatarMaterialKey a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x97DF400", Offset = "0x97DDE00", VA = "0x1897DF400")]
		public void FWDYIAKQXBE(TextureEffectMaterialProperties a, TextureEffectMaterialTextures b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x97DFBF0", Offset = "0x97DE5F0", VA = "0x1897DFBF0", Slot = "38")]
		public void HideAvatarMeshes(bool hide)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x97DFF30", Offset = "0x97DE930", VA = "0x1897DFF30")]
		private void IPQKSDLXDPZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x97DFBA0", Offset = "0x97DE5A0", VA = "0x1897DFBA0")]
		private void HYLTUJGYGUW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x3762840", Offset = "0x3761240", VA = "0x183762840")]
		public static void ZWDYCPCLGNM<a>(Dictionary<a, Material> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x97E9460", Offset = "0x97E7E60", VA = "0x1897E9460")]
		private static void ZQULAYOTIJC(Dictionary<Renderer, ODHBISUOWWB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x97DE790", Offset = "0x97DD190", VA = "0x1897DE790")]
		public static void DOPMIIQOHBT(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x97E3D10", Offset = "0x97E2710", VA = "0x1897E3D10")]
		public static void MNNJTNVJSUI(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x97DE8E0", Offset = "0x97DD2E0", VA = "0x1897DE8E0")]
		public static void DVFNXEHBVRS(List<OVEKQGJRAJB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x97E3770", Offset = "0x97E2170", VA = "0x1897E3770")]
		private void MHEQUOKUKKD(Dictionary<string, ZTZZICZDYWU<Texture2D>> a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x97E6E70", Offset = "0x97E5870", VA = "0x1897E6E70")]
		private void TCXNGLZPFBU(Dictionary<string, List<AvatarMaterialKey>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x97DF940", Offset = "0x97DE340", VA = "0x1897DF940")]
		private void HKJKEYOXLXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x97E75C0", Offset = "0x97E5FC0", VA = "0x1897E75C0")]
		private void UNIUBMGECCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x97E0B10", Offset = "0x97DF510", VA = "0x1897E0B10")]
		private void JDMPXWUNWME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x97E10D0", Offset = "0x97DFAD0", VA = "0x1897E10D0")]
		private void JEPDFLDUEER()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x97E7750", Offset = "0x97E6150", VA = "0x1897E7750")]
		private void UPRVADPZRHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x97E6120", Offset = "0x97E4B20", VA = "0x1897E6120")]
		private void SUDYEDKXLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x97DEB40", Offset = "0x97DD540", VA = "0x1897DEB40")]
		private void EJHXTOYMILY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x97E74F0", Offset = "0x97E5EF0", VA = "0x1897E74F0")]
		private void UCJTLYLWWJK(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x97E05E0", Offset = "0x97DEFE0", VA = "0x1897E05E0")]
		private void IROZPZVYQWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x97E36A0", Offset = "0x97E20A0", VA = "0x1897E36A0")]
		private void LUJWQKUQBCS(bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x97DC740", Offset = "0x97DB140", VA = "0x1897DC740")]
		private void AIIIRXJVUCN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x97E5420", Offset = "0x97E3E20", VA = "0x1897E5420")]
		private void PVASFVJETYB(Material a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x97E4BE0", Offset = "0x97E35E0", VA = "0x1897E4BE0")]
		private void NZHHKEJMSOB(Material a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x97E3DB0", Offset = "0x97E27B0", VA = "0x1897E3DB0")]
		private void MRHYGQSBBXH(Material a, Color b, Texture2D c, Color? d, float? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x97DC4F0", Offset = "0x97DAEF0", VA = "0x1897DC4F0")]
		private void AHJOZBETPFC(Material a, Color b, Color c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x97DFD20", Offset = "0x97DE720", VA = "0x1897DFD20")]
		private void IJPJZOEYGJZ(Material a, Texture2D b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x97DF650", Offset = "0x97DE050", VA = "0x1897DF650")]
		private void HEARQKAUIHT(Material a, Texture b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x97E52C0", Offset = "0x97E3CC0", VA = "0x1897E52C0")]
		private void OPLCVSOAPZX(Action<ODHBISUOWWB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x97DF7C0", Offset = "0x97DE1C0", VA = "0x1897DF7C0")]
		private void HIKSJTHOWBX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x97E38F0", Offset = "0x97E22F0", VA = "0x1897E38F0")]
		private void MMLZXBJAXUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x97DD040", Offset = "0x97DBA40", VA = "0x1897DD040")]
		private void BFWUMGUQXIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x97E42D0", Offset = "0x97E2CD0", VA = "0x1897E42D0")]
		public void NLNZRZYTBPT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x97DF3F0", Offset = "0x97DDDF0", VA = "0x1897DF3F0", Slot = "4")]
		private void FBXMNEUJSLY([In] AvatarDisplayInitState avatarDisplayInitState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x97DEAC0", Offset = "0x97DD4C0", VA = "0x1897DEAC0", Slot = "5")]
		private void EESFINJFNMZ([In] AvatarDisplaySetupState avatarDisplaySetupState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x97E06B0", Offset = "0x97DF0B0", VA = "0x1897E06B0")]
		[CompilerGenerated]
		private LTBUWQFXCGW IVOIUQQMQMR(UXMOFXXDVIG a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x97DED10", Offset = "0x97DD710", VA = "0x1897DED10")]
		[CompilerGenerated]
		private void ESDJVJDEOHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x97DEE10", Offset = "0x97DD810", VA = "0x1897DEE10")]
		[CompilerGenerated]
		private void ESNXPWQZHEQ(ODHBISUOWWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x97DED90", Offset = "0x97DD790", VA = "0x1897DED90")]
		[CompilerGenerated]
		private void ESIQSPXBXTH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x97DEE30", Offset = "0x97DD830", VA = "0x1897DEE30")]
		[CompilerGenerated]
		private void ESTENDKWQPZ(ODHBISUOWWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x97DEC10", Offset = "0x97DD610", VA = "0x1897DEC10")]
		[CompilerGenerated]
		private void ERSWAVPJVLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x97DF390", Offset = "0x97DDD90", VA = "0x1897DF390")]
		[CompilerGenerated]
		private void ETTMZLGJLUS(ODHBISUOWWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x97DEC90", Offset = "0x97DD690", VA = "0x1897DEC90")]
		[CompilerGenerated]
		private void ERYCYCJHEWP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x97DF3C0", Offset = "0x97DDDC0", VA = "0x1897DF3C0")]
		[CompilerGenerated]
		private void ETYTWSAGVGB(ODHBISUOWWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x97DEE50", Offset = "0x97DD850", VA = "0x1897DEE50")]
		[CompilerGenerated]
		private void ESYLKKEUABI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x97E9350", Offset = "0x97E7D50", VA = "0x1897E9350")]
		[CompilerGenerated]
		private void ZESEIREHGQL(ODHBISUOWWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x97DF310", Offset = "0x97DDD10", VA = "0x1897DF310")]
		[CompilerGenerated]
		private void ETDSHQYRJMR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x97E9320", Offset = "0x97E7D20", VA = "0x1897E9320")]
		[CompilerGenerated]
		private void ZEMXLKKJXFC(ODHBISUOWWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x97E5930", Offset = "0x97E4330", VA = "0x1897E5930")]
		[CompilerGenerated]
		private void QCZBSEFCAUA(KeyValuePair<string, ZTZZICZDYWU<Texture2D>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x97E5AA0", Offset = "0x97E44A0", VA = "0x1897E5AA0")]
		[CompilerGenerated]
		private void RVZYMUUHJKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x97DE6E0", Offset = "0x97DD0E0", VA = "0x1897DE6E0")]
		[CompilerGenerated]
		private void DGNTOKHTGQP(ODHBISUOWWB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x97E8FA0", Offset = "0x97E79A0", VA = "0x1897E8FA0")]
		[CompilerGenerated]
		private void YXDCFQFGAJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x97DF620", Offset = "0x97DE020", VA = "0x1897DF620")]
		[CompilerGenerated]
		private void GFDJKOPKOFI(ODHBISUOWWB a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class AvatarElbowBendHelperController : MonoBehaviour, RBPBGEOLJBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform ElbowHelperBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[SerializeField]
		private Transform LowerArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001C0")]
		[SerializeField]
		private float MinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001C1")]
		[SerializeField]
		private float MaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001C2")]
		[Header("Scale")]
		[FormerlySerializedAs("MinScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		[FormerlySerializedAs("MaxScaleValues")]
		[SerializeField]
		private Vector3 ScaleValuesAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		[Header("Positional Offset")]
		[FormerlySerializedAs("MinLocalPositionalOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMinAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		[FormerlySerializedAs("MaxLocalPositionOffset")]
		[SerializeField]
		private Vector3 PositionalOffsetAtMaxAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001C6")]
		private Vector3? CXWKPZHFIXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001C7")]
		private bool NXKYHFHIOAQ;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x97F23E0", Offset = "0x97F0DE0", VA = "0x1897F23E0", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x97F2A10", Offset = "0x97F1410", VA = "0x1897F2A10", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xDE22D0", Offset = "0xDE0CD0", VA = "0x180DE22D0", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x97F24C0", Offset = "0x97F0EC0", VA = "0x1897F24C0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x97F2E30", Offset = "0x97F1830", VA = "0x1897F2E30")]
		public AvatarElbowBendHelperController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class AvatarElbowBendTargetController : MonoBehaviour, RBPBGEOLJBH
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		private const float SPZYJTBEVMA = 45f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform ElbowBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		[SerializeField]
		private Transform NeckBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		[SerializeField]
		private Transform UpperArmBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001CC")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001CD")]
		[SerializeField]
		private bool Left;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		[SerializeField]
		private float MinTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		[SerializeField]
		private float MaxTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		[SerializeField]
		private float TwistWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		[SerializeField]
		private float ElbowSmoothTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		[SerializeField]
		private float RestTwist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		[SerializeField]
		private float RestTwistWhenClose;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		[SerializeField]
		private float RestTwistDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		private Vector3 ZAVRGJZOSDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		private Vector3 LKVWWKJCKSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private bool NXKYHFHIOAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private float UJLOBEQZLXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		private float TKCVWUXFWZT;

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x97F31C0", Offset = "0x97F1BC0", VA = "0x1897F31C0", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xFD06A0", Offset = "0xFCF0A0", VA = "0x180FD06A0", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x97F2EE0", Offset = "0x97F18E0", VA = "0x1897F2EE0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x97F3C80", Offset = "0x97F2680", VA = "0x1897F3C80")]
		public AvatarElbowBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class JHIMSIMLGPH : EROHEZQIFNW, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		private static readonly int AQZQMPNELMZ;

		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		private static readonly int KSRUTRKKABY;

		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		private static readonly int ZOHLYUFPFEN;

		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		private static readonly int VNAJOLQUJKF;

		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		private static readonly int BBIMFUDKFLF;

		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		private static readonly int WRGFOIFTXEB;

		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		private static readonly int DKKDOQQKOYJ;

		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		private static readonly int XIJYCZRONYX;

		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		private static readonly int QACIKTNKBID;

		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private static readonly int YRMCCTWWWAG;

		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private static readonly int BFXTAORNBEE;

		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private static readonly int NCEHSAGKDCK;

		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private static readonly int APBZYGIKJJW;

		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private static readonly int OUTGQGBYGMO;

		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private static readonly int DGLZJHEHFUU;

		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private static readonly int NNBOIJTQMBU;

		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private static readonly int EOATCOBNTSD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private Transform XPOQSHXICVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private Transform XQWNXEAZTJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private Transform CNOLFULDRXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private Transform BKXXLQEUDJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private Transform GKFRBEEEIJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F1")]
		private Transform WSBXBUTSELW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		private AvatarFaceDisplayInitState PHVIXSQMRPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		private Material ZTDGALGZODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private SkinnedMeshRenderer[] ADCAEDONPYK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		private readonly List<Material> VYTZHGUFYEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		private SCRQULTBQGW MZZABFOLNFP;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public JOLHGBMRDLK EQSAYOVPGJQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		private SCRQULTBQGW QOMEZUAQVUG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x97FC470", Offset = "0x97FAE70", VA = "0x1897FC470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x97FC210", Offset = "0x97FAC10", VA = "0x1897FC210", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x97FC3C0", Offset = "0x97FADC0", VA = "0x1897FC3C0")]
		public void Initialize([In] AvatarFaceDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x97FBDA0", Offset = "0x97FA7A0", VA = "0x1897FBDA0")]
		public void FCOTKEYIDWK([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x97FD4D0", Offset = "0x97FBED0", VA = "0x1897FD4D0", Slot = "6")]
		public void XTYCTAPPUQH(AvatarFaceDisplayUpdateFeatureSelectionState a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x97FC360", Offset = "0x97FAD60", VA = "0x1897FC360")]
		private Vector2 IGCOOMYDSIP(Vector2 a)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x97FC4F0", Offset = "0x97FAEF0", VA = "0x1897FC4F0")]
		public void NDOWDTSFPKZ([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x97FBE40", Offset = "0x97FA840", VA = "0x1897FBE40")]
		private void FJVAONSVQCK(FaceFeaturesInUVSpace a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x97FDA00", Offset = "0x97FC400", VA = "0x1897FDA00")]
		private void YACUJGNYXAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x97FBCF0", Offset = "0x97FA6F0", VA = "0x1897FBCF0")]
		private void URQWHJUFGXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x97FBCF0", Offset = "0x97FA6F0", VA = "0x1897FBCF0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x97FE030", Offset = "0x97FCA30", VA = "0x1897FE030")]
		public JHIMSIMLGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x97FBDA0", Offset = "0x97FA7A0", VA = "0x1897FBDA0", Slot = "5")]
		private void GCXWCSGAFTB([In] AvatarFaceDisplayUpdateRenderersState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x97FDD10", Offset = "0x97FC710", VA = "0x1897FDD10", Slot = "7")]
		private void YLVKLGZCCNE([In] AvatarFaceDisplayUpdateFeaturePositionsState updateState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x97FBCE0", Offset = "0x97FA6E0", VA = "0x1897FBCE0")]
		[CompilerGenerated]
		internal static float DRLIBTVNUKX(float a, float b)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x97FD3E0", Offset = "0x97FBDE0", VA = "0x1897FD3E0")]
		[CompilerGenerated]
		internal static void XOAUMTOUWAO(Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x97FBD60", Offset = "0x97FA760", VA = "0x1897FBD60")]
		[CompilerGenerated]
		internal static Vector4 ELTZWKNVCBZ(Vector2 a, Vector2 b)
		{
			return default(Vector4);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class AvatarForearmRollController : MonoBehaviour, RBPBGEOLJBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[SerializeField]
		private Transform TwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private Transform HandBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private Transform LowerArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		[SerializeField]
		private Transform UpperArmTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		[SerializeField]
		private Transform ElbowTwistBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		[SerializeField]
		private float RollTowardsWristAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		[SerializeField]
		private float RollSoftMin;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[SerializeField]
		private float RollSoftMax;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		[SerializeField]
		private float LowerArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		[SerializeField]
		private float UpperArmTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		[SerializeField]
		private float ElbowTwistAmount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private float UJLOBEQZLXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private bool NXKYHFHIOAQ;

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x97F3CB0", Offset = "0x97F26B0", VA = "0x1897F3CB0", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0xD15A00", Offset = "0xD14400", VA = "0x180D15A00", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x97F4520", Offset = "0x97F2F20", VA = "0x1897F4520")]
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
			[Cpp2IlInjected.Token(Token = "0x4000206")]
			[Tooltip("Name of animation original state to override")]
			public string OriginalName;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			[Tooltip("Name of animation state to use as an override")]
			public string OverrideName;

			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public AnimationOverride()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		[SerializeField]
		private AnimationOverride[] HandStateOverrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private Dictionary<int, int> DRJFNTHCWTK;

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x97F4550", Offset = "0x97F2F50", VA = "0x1897F4550")]
		public void SRPDLCJVRSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x97F4660", Offset = "0x97F3060", VA = "0x1897F4660")]
		public int TGADSWBUMBC(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public AvatarHandDisplaySettings()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class YTUDRJAGJBP : SLJYCASULPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x9806490", Offset = "0x9804E90", VA = "0x189806490", Slot = "24")]
		public override float KRCSSSIWZWF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x98064E0", Offset = "0x9804EE0", VA = "0x1898064E0")]
		public YTUDRJAGJBP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class SLJYCASULPM : OCCDOUHRKRS
	{
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		private static int OIIBHWKHHPD;

		[Cpp2IlInjected.Token(Token = "0x4000209")]
		private static int AENFUQPKQUN;

		[Cpp2IlInjected.Token(Token = "0x400020A")]
		private static int BUKMVEWMTDH;

		[Cpp2IlInjected.Token(Token = "0x400020B")]
		private static int QVOPKQAGKDG;

		[Cpp2IlInjected.Token(Token = "0x400020C")]
		private static int YIXFMCNEEPY;

		[Cpp2IlInjected.Token(Token = "0x400020D")]
		private static int GFOYIFQEJHR;

		[Cpp2IlInjected.Token(Token = "0x400020E")]
		private static int SNVCXZZNHPL;

		[Cpp2IlInjected.Token(Token = "0x400020F")]
		private static int[] YATJRNXOFVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		private AvatarHandDisplayInitState PHVIXSQMRPU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		private AvatarHandDisplaySetupState SUJFNGTAESF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		private int ACOAESUYHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		private float TDBVUMFJRCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		protected Animator BNZNVMXOUUO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		protected AvatarConfiguration FCVDCWUTEZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		protected int RKGCEUNDRZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		private int QCWCZFPVJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400021B")]
		private int KADBEGAFNOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		private bool ITHWQRUUNEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		private HandAnimationOverrideState NBBZFKNREME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		private int JNSJTCDDNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		private float FNXWMFAUKMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		private AvatarHandDisplaySettings MQNYTTREZQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000221")]
		private AvatarBodyType LCIOIHCPXSL;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public Transform AMAMZYJXPXZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Vector3 FYIGHTBPMFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x19EB4B0", Offset = "0x19E9EB0", VA = "0x1819EB4B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x19EB500", Offset = "0x19E9F00", VA = "0x1819EB500")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Quaternion QIMQRLBNXIM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xE948D0", Offset = "0xE932D0", VA = "0x180E948D0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xE94750", Offset = "0xE93150", VA = "0x180E94750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool QDEDTBGPJGU
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x9804530", Offset = "0x9802F30", VA = "0x189804530")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CC")]
			[Cpp2IlInjected.Address(RVA = "0x98044E0", Offset = "0x9802EE0", VA = "0x1898044E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public bool ADCZBTDQEER
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0xD22D10", Offset = "0xD21710", VA = "0x180D22D10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector3 PFBFUHIGRJG
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x14B22E0", Offset = "0x14B0CE0", VA = "0x1814B22E0", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x14ACC90", Offset = "0x14AB690", VA = "0x1814ACC90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Quaternion NMMTAUBUPBH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x12EC6D0", Offset = "0x12EB0D0", VA = "0x1812EC6D0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9804230", Offset = "0x9802C30", VA = "0x189804230")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public HandVisualState DXITQVJWQLB
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x10FA780", Offset = "0x10F9180", VA = "0x1810FA780", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x10FB800", Offset = "0x10FA200", VA = "0x1810FB800", Slot = "4")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public HandVisualState ZVRQTDPMLYG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x12FECA0", Offset = "0x12FD6A0", VA = "0x1812FECA0", Slot = "22")]
			[CompilerGenerated]
			get
			{
				return default(HandVisualState);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x21C0010", Offset = "0x21BEA10", VA = "0x1821C0010", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float BSLUEVRVCKS
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x159FD90", Offset = "0x159E790", VA = "0x18159FD90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x10FB840", Offset = "0x10FA240", VA = "0x1810FB840", Slot = "6")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public bool XRYYKOGKQEW
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x25A1190", Offset = "0x259FB90", VA = "0x1825A1190", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x25A11E0", Offset = "0x259FBE0", VA = "0x1825A11E0", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public bool PLRUHFPGNIA
		{
			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0x9804130", Offset = "0x9802B30", VA = "0x189804130")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool LDELFEXJGNB
		{
			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x9803BC0", Offset = "0x98025C0", VA = "0x189803BC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public bool FGJTWOIBANE
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x9804430", Offset = "0x9802E30", VA = "0x189804430")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public bool JDTERMXRNNM
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x98044D0", Offset = "0x9802ED0", VA = "0x1898044D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x9803F90", Offset = "0x9802990", VA = "0x189803F90", Slot = "23")]
		public void Initialize(AvatarHandDisplayInitState initState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x9804190", Offset = "0x9802B90", VA = "0x189804190")]
		public void OEKXMGMPIJJ(AvatarHandDisplaySetupState a, AvatarHandDisplaySettings b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x9804440", Offset = "0x9802E40", VA = "0x189804440", Slot = "14")]
		public void VFBBMXOOWZW(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x9803BE0", Offset = "0x98025E0", VA = "0x189803BE0", Slot = "13")]
		public void GOVWSFFDKRS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x159FD90", Offset = "0x159E790", VA = "0x18159FD90", Slot = "24")]
		public virtual float KRCSSSIWZWF()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x9804560", Offset = "0x9802F60", VA = "0x189804560")]
		private int ZYJWRMECXFI(HandVisualState a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x9804250", Offset = "0x9802C50", VA = "0x189804250")]
		private void QPMBUDBDTTS(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x9804510", Offset = "0x9802F10", VA = "0x189804510", Slot = "15")]
		public bool ZJUKDHFDCRK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x9804240", Offset = "0x9802C40", VA = "0x189804240", Slot = "16")]
		public bool QCOJELEHCSW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x98041E0", Offset = "0x9802BE0", VA = "0x1898041E0")]
		private HandVisualState ONPFRZUPEZX()
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x184FD20", Offset = "0x184E720", VA = "0x18184FD20", Slot = "17")]
		public void VZXACBFMDGZ(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x9803F50", Offset = "0x9802950", VA = "0x189803F50", Slot = "12")]
		public void GTWYYEIOFXA(int a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x9804410", Offset = "0x9802E10", VA = "0x189804410", Slot = "10")]
		public void RNJTDHTOTUY(HandAnimationOverrideState a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x9803BD0", Offset = "0x98025D0", VA = "0x189803BD0", Slot = "11")]
		public void EGMQSBOBJJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x9804140", Offset = "0x9802B40", VA = "0x189804140", Slot = "18")]
		public void MMLZUGDNXNI(Transform a, Vector3 b, Quaternion c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x98049C0", Offset = "0x98033C0", VA = "0x1898049C0")]
		public SLJYCASULPM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public class SENPQXIUYUS : UXMOFXXDVIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private sealed class YMQNZVANQVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000233")]
			public SENPQXIUYUS TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000234")]
			public List<OVEKQGJRAJB> LVVKJZMAPYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000235")]
			public List<OVEKQGJRAJB> NMPQYEANWZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000236")]
			public ZTZZICZDYWU<Material[]> XRJTOLPLORM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000237")]
			public ZTZZICZDYWU<LoadedAvatarItemPrefabHolder> DINJLGRXEJQ;

			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public YMQNZVANQVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x9806250", Offset = "0x9804C50", VA = "0x189806250")]
			internal LTBUWQFXCGW QKOMFDWDJTN(string a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000229")]
		public GOVRREGVIBX GOVRREGVIBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		public LoadedAvatarItemPrefabHolder GZZEVZXXNZP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		private ZTZZICZDYWU<LoadedAvatarItemPrefabHolder> SOCGESIKZAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		private ZTZZICZDYWU<Material[]> XRJTOLPLORM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		public Material[] TUJXONSZSFN;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public bool VFOXJGRHYNR
		{
			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0xD3E900", Offset = "0xD3D300", VA = "0x180D3E900")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0xD3E910", Offset = "0xD3D310", VA = "0x180D3E910")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public UHAZOTSKNQO.SkinCullingMask YAWRMKGWILW
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			[CompilerGenerated]
			get
			{
				return default(UHAZOTSKNQO.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xFFCBC0", Offset = "0xFFB5C0", VA = "0x180FFCBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x9803B50", Offset = "0x9802550", VA = "0x189803B50")]
		public SENPQXIUYUS(ItemDefinitionBodyPart a, GOVRREGVIBX b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x98027D0", Offset = "0x98011D0", VA = "0x1898027D0", Slot = "6")]
		public override LTBUWQFXCGW BACMGKPQZAC(List<OVEKQGJRAJB> a, List<OVEKQGJRAJB> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9803400", Offset = "0x9801E00", VA = "0x189803400")]
		public LTBUWQFXCGW RZGDLOZMCZB(List<OVEKQGJRAJB> a, List<OVEKQGJRAJB> b, ZTZZICZDYWU<Material[]> c, [Optional] ZTZZICZDYWU<LoadedAvatarItemPrefabHolder> d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x9803700", Offset = "0x9802100", VA = "0x189803700")]
		public (ZTZZICZDYWU<Material[]>, ZTZZICZDYWU<LoadedAvatarItemPrefabHolder>) TGOTZUHSJDH(List<OVEKQGJRAJB> a, List<OVEKQGJRAJB> b)
		{
			return default((ZTZZICZDYWU<Material[]>, ZTZZICZDYWU<LoadedAvatarItemPrefabHolder>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x9803200", Offset = "0x9801C00", VA = "0x189803200", Slot = "7")]
		public override QJAYBBQNYGO OBAULQQDWRP(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x9802FE0", Offset = "0x98019E0", VA = "0x189802FE0")]
		public QJAYBBQNYGO LKDINWMDAZG(GameObject a, uint b, bool c, bool d, AvatarSkinnedMeshBoneOrderRemapsData e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x9802C70", Offset = "0x9801670", VA = "0x189802C70")]
		public static bool FIZMZYJJVMN(Renderer[] a, string b, [Out] Renderer c, [Out] Renderer d)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x9803B00", Offset = "0x9802500", VA = "0x189803B00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9802710", Offset = "0x9801110", VA = "0x189802710")]
		private (ZTZZICZDYWU<LoadedAvatarItemPrefabHolder>, ZTZZICZDYWU<Material[]>) AXGQBXKESNH()
		{
			return default((ZTZZICZDYWU<LoadedAvatarItemPrefabHolder>, ZTZZICZDYWU<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x98031E0", Offset = "0x9801BE0", VA = "0x1898031E0")]
		[CompilerGenerated]
		private void NEZUKLVXSRV(LoadedAvatarItemPrefabHolder a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xD141B0", Offset = "0xD12BB0", VA = "0x180D141B0")]
		[CompilerGenerated]
		private void NEUNNFCAJGM(Material[] a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public class AvatarKneeBendTargetController : MonoBehaviour, RBPBGEOLJBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform KneeBendTarget;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		[SerializeField]
		private Transform RootSpineBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		[SerializeField]
		private Transform ThighBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		[SerializeField]
		private Transform FootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		[SerializeField]
		private float WeightToFootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		[SerializeField]
		private Vector3 BendTargetOffsetFromHipToFootMidPoint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		[SerializeField]
		private Bounds KneeTargetConstrainedBox;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		private Vector3 ZAVRGJZOSDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		private Vector3 QMDYZYKKKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		private Vector3 MPNZLHDWEBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000242")]
		private Matrix4x4 BCKUWLHTSAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		private bool NXKYHFHIOAQ;

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x97F4B30", Offset = "0x97F3530", VA = "0x1897F4B30", Slot = "4")]
		public void UpdateController(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x97F4B20", Offset = "0x97F3520", VA = "0x1897F4B20", Slot = "6")]
		public void SetEnabled(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x97F46D0", Offset = "0x97F30D0", VA = "0x1897F46D0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x97F51F0", Offset = "0x97F3BF0", VA = "0x1897F51F0")]
		public AvatarKneeBendTargetController()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[Tested]
	public struct AvatarLegacyCullAndCombineMeshJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		[ReadOnly]
		public AvatarLegacyCullAndCombineMeshJobGroup JobMeshesGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		[ReadOnly]
		public int MaxUberIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		public AvatarLegacyCullAndCombineMeshJobContainer CulledAndCombinedMesh;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x97F8170", Offset = "0x97F6B70", VA = "0x1897F8170", Slot = "4")]
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
		[Cpp2IlInjected.Token(Token = "0x4000247")]
		public NativeArray<Vector3> vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		public NativeArray<Vector3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		public NativeArray<Vector4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		public NativeArray<Vector2> uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		public NativeArray<Vector2> uv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		public NativeArray<Vector2> uv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		public NativeArray<Vector2> uv4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400024E")]
		public NativeArray<Color> colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		public NativeArray<int> culledAndCombinedTriangles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		public NativeArray<int> culledMeshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		private NativeArray<int> postMergeSubMeshTriOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private NativeArray<int> postMergeSubMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		public NativeArray<int> culledSubMeshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		public NativeArray<int> culledSubMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		public NativeArray<int> vertexCullingIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		public NativeArray<BoneWeight> culledAndCombinedBoneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private NativeArray<int> parameters;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		private bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public int SCHASULYQQI
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x97F5AE0", Offset = "0x97F44E0", VA = "0x1897F5AE0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x97F5AF0", Offset = "0x97F44F0", VA = "0x1897F5AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public int ITYWRWRUGNM
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x97F5710", Offset = "0x97F4110", VA = "0x1897F5710")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x97F5AD0", Offset = "0x97F44D0", VA = "0x1897F5AD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public int YOGNTJDZKHG
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x97F5700", Offset = "0x97F4100", VA = "0x1897F5700")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x97F5720", Offset = "0x97F4120", VA = "0x1897F5720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x97F5C40", Offset = "0x97F4640", VA = "0x1897F5C40")]
		public AvatarLegacyCullAndCombineMeshJobContainer(int totalVerts, int totalTriangles, int totalOriginalMeshCount, int maxSubMeshCount, Allocator allocator, int numActiveUVChannels)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x97F59A0", Offset = "0x97F43A0", VA = "0x1897F59A0")]
		public void RDPTPQYKNEA(int a, Vector3 b, Vector3 c, Vector4 d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x97F5800", Offset = "0x97F4200", VA = "0x1897F5800")]
		public void RDDHPDQHZJM(int a, BoneWeight b, NativeSlice<byte> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x97F5C00", Offset = "0x97F4600", VA = "0x1897F5C00")]
		public Color YRFCBIPALCP(int a)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x97F5C20", Offset = "0x97F4620", VA = "0x1897F5C20")]
		public void ZABBMFBKHFN(int a, Color b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x97F5BB0", Offset = "0x97F45B0", VA = "0x1897F5BB0")]
		public void VZVPPJKXQRF(byte a, int b, Vector2 c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x97F5760", Offset = "0x97F4160", VA = "0x1897F5760")]
		public void PZZXZKGVNVM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x97F5730", Offset = "0x97F4130", VA = "0x1897F5730")]
		public bool OVKMMORVBCP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x97F5A10", Offset = "0x97F4410", VA = "0x1897F5A10")]
		public void SDHDAJUVQIN(int a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x97F5B00", Offset = "0x97F4500", VA = "0x1897F5B00")]
		public int[] TVDMVSDERSB(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x97F5770", Offset = "0x97F4170", VA = "0x1897F5770")]
		private NativeSlice<int> QDVJXOLNKZY(int a)
		{
			return default(NativeSlice<int>);
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x97F5200", Offset = "0x97F3C00", VA = "0x1897F5200", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x97F53B0", Offset = "0x97F3DB0", VA = "0x1897F53B0")]
		public Mesh EQOEBDUNDFA([Optional] string a)
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
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public NativeArray<Vector3> vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		public NativeArray<Vector3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		public NativeArray<Vector4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		public NativeArray<Vector2> uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		public NativeArray<Vector2> uv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400025E")]
		public NativeArray<Vector2> uv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		public NativeArray<Vector2> uv4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public NativeArray<Color> colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		public NativeArray<int> triangles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		public NativeArray<int> meshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000263")]
		public NativeArray<int> subMeshTriStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		public NativeArray<int> subMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		public NativeArray<bool> flipTris;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		public NativeArray<int> boneWeightOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		public NativeArray<int> meshVertStarts;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		public NativeArray<BoneWeight> boneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		private NativeArray<Matrix4x4> meshTransforms;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		private NativeArray<long> meshCullingBitMasks;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		private NativeArray<byte> meshRemapBoneOrderArrays;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x400026C")]
		private NativeArray<int> meshNumSubMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		private NativeArray<int> meshGlobalSubMeshIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		public NativeArray<sbyte> subMeshUberMaterialIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		public NativeArray<byte> subMeshMaterialIds;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		private NativeArray<int> Params;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		private bool _isInitialized;

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public int UGOTSXZDVXK
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0xF8BE60", Offset = "0xF8A860", VA = "0x180F8BE60")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int QJHKOBOYSUO
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0xDAEDB0", Offset = "0xDAD7B0", VA = "0x180DAEDB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public int KKFOQSLMMIT
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x97F6360", Offset = "0x97F4D60", VA = "0x1897F6360")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public int DTRUCGXTMLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x97F60B0", Offset = "0x97F4AB0", VA = "0x1897F60B0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x97F6490", Offset = "0x97F4E90", VA = "0x1897F6490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public int SCHASULYQQI
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x97F6480", Offset = "0x97F4E80", VA = "0x1897F6480")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x97F64A0", Offset = "0x97F4EA0", VA = "0x1897F64A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public int VHBINUKZITV
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x97F60A0", Offset = "0x97F4AA0", VA = "0x1897F60A0")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x97F6470", Offset = "0x97F4E70", VA = "0x1897F6470")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public MeshMergeModes UFNSNIMFXYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000226")]
			[Cpp2IlInjected.Address(RVA = "0x97F6350", Offset = "0x97F4D50", VA = "0x1897F6350")]
			get
			{
				return default(MeshMergeModes);
			}
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x97F60C0", Offset = "0x97F4AC0", VA = "0x1897F60C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public byte WDTFEXMLVSX
		{
			[Cpp2IlInjected.Token(Token = "0x6000228")]
			[Cpp2IlInjected.Address(RVA = "0x97F6390", Offset = "0x97F4D90", VA = "0x1897F6390")]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(RVA = "0x97F6340", Offset = "0x97F4D40", VA = "0x1897F6340")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public AvatarLegacyCullAndCombineMeshSlice this[int meshIndex]
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x97F7C40", Offset = "0x97F6640", VA = "0x1897F7C40")]
			get
			{
				return default(AvatarLegacyCullAndCombineMeshSlice);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x97F64B0", Offset = "0x97F4EB0", VA = "0x1897F64B0")]
		public AvatarLegacyCullAndCombineMeshJobGroup(IList<Mesh> jobMeshes, IList<Matrix4x4> partTransforms, IList<bool> flipTris, byte boneCount, IList<IReadOnlyList<byte>> remapBoneOrderArrays, IList<long> cullingBitMasks, IList<bool> isBaseSkinMeshes, IList<int> boneWeightOverride, IList<int> materialIndexLookup, IList<int> globalSubMeshUberIndices, Allocator allocator, MeshMergeModes meshMergeMode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x97F63A0", Offset = "0x97F4DA0", VA = "0x1897F63A0")]
		public AvatarLegacyCullAndCombineMeshJobContainer RUAWSLWOBES(Allocator a)
		{
			return default(AvatarLegacyCullAndCombineMeshJobContainer);
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x97F60D0", Offset = "0x97F4AD0", VA = "0x1897F60D0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[Tested]
	public class RUMPVFDDTAU : JWBTZWUEFOS
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9802620", Offset = "0x9801020", VA = "0x189802620")]
		public AvatarLegacyCullAndCombineMeshJobGroup RMNTKSHLUSG()
		{
			return default(AvatarLegacyCullAndCombineMeshJobGroup);
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x97EAED0", Offset = "0x97E98D0", VA = "0x1897EAED0")]
		public RUMPVFDDTAU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public struct AvatarLegacyCullAndCombineMeshSlice
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		public NativeSlice<Vector3> vertices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		public NativeSlice<Vector3> normals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		public NativeSlice<Vector4> tangents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		public NativeSlice<Vector2> uv;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		public NativeSlice<Vector2> uv2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		public NativeSlice<Vector2> uv3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		public NativeSlice<Vector2> uv4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		public NativeSlice<Color> colors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		public NativeSlice<int> subMeshTriOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		public NativeSlice<int> subMeshTriLengths;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		public NativeSlice<BoneWeight> boneWeights;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		public NativeSlice<byte> materialIDs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		public int NumSubMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		public Matrix4x4 MeshTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		public long CullingBitMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		public NativeSlice<byte> remapBoneOrderArray;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		public bool FlipTris;

		[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		public int BoneWeightOverride;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public readonly struct AvatarMaterialKey : IEquatable<AvatarMaterialKey>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		internal readonly Material Material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		internal readonly UpdatableColorType UpdatableColorType;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		internal readonly UpdatableTextureType UpdatableTextureType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		internal readonly AvatarBodyPart BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		internal readonly bool UseBuiltInEmissive;

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x97F9620", Offset = "0x97F8020", VA = "0x1897F9620")]
		public AvatarMaterialKey(Material material, UpdatableColorType updatableColorType, UpdatableTextureType updatableTextureType, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x97F9380", Offset = "0x97F7D80", VA = "0x1897F9380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x97F90F0", Offset = "0x97F7AF0", VA = "0x1897F90F0", Slot = "4")]
		public bool Equals(AvatarMaterialKey other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x97F9180", Offset = "0x97F7B80", VA = "0x1897F9180", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x97F9280", Offset = "0x97F7C80", VA = "0x1897F9280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyDisplayBehaviour : MonoBehaviour, NHAJMTHYQKS
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		[Header("Configuration")]
		[SerializeField]
		protected AvatarConfiguration configuration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		[SerializeField]
		protected Animator skeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		[SerializeField]
		protected Renderer[] watchRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		[Header("Configuration")]
		[SerializeField]
		private AvatarBodyType avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		[SerializeField]
		private AvatarSkinAssetItem potatoAvatarSkinAssetItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		[SerializeField]
		[FormerlySerializedAs("avatarSkinAsset")]
		private AssetReference avatarSkinAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		[SerializeField]
		private AssetReference torsoModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		[SerializeField]
		private AssetReference legsModestyAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		[SerializeField]
		private AssetReference torsoValidationAssetReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		[SerializeField]
		private GameObject allBodyMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		[SerializeField]
		private GameObject firstPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		[SerializeField]
		public GameObject thirdPersonMeshContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		[SerializeField]
		private GameObject[] hideInFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		[SerializeField]
		protected Transform headAdditiveBaseBoneTransform;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		[SerializeField]
		[FormerlySerializedAs("BodyMaterial")]
		private Material BodyMaterialSkinGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		[SerializeField]
		private Material BodyMaterialNonGradient;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		[SerializeField]
		private Texture2D BodyEmissiveSkinMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		[SerializeField]
		private Material ModestyAndValidationMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		[SerializeField]
		private Material FaceMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		[SerializeField]
		private Material DefaultAvatarItemMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		[SerializeField]
		private Shader AvatarDefaultShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		[SerializeField]
		private Shader AvatarUberShader;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		[SerializeField]
		private Transform DeformRigRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		[SerializeField]
		private SkinnedMeshRenderer BaseSkinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		[SerializeField]
		protected AvatarSkinnedMeshBoneOrderRemapsData BoneOrderRemapsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		[Header("Arm Animation Controllers")]
		[SerializeField]
		private AvatarForearmRollController LeftForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		[SerializeField]
		private AvatarElbowBendHelperController LeftElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		[SerializeField]
		private AvatarElbowBendTargetController LeftElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		[SerializeField]
		private AvatarKneeBendTargetController LeftKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		[SerializeField]
		private AvatarForearmRollController RightForearmRollController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		[SerializeField]
		private AvatarElbowBendHelperController RightElbowBendHelperController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		[SerializeField]
		private AvatarElbowBendTargetController RightElbowBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		[SerializeField]
		private AvatarKneeBendTargetController RightKneeBendTargetController;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		[SerializeField]
		private Transform LeftEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		[SerializeField]
		private Transform LeftEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002AC")]
		[SerializeField]
		private Transform RightEyeBrowBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		[SerializeField]
		private Transform RightEyeBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		[SerializeField]
		private Transform NoseMoveTweakBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		[SerializeField]
		private Transform MouthBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		[SerializeField]
		private AvatarBodyPartShapesManager avatarBodyPartShapesManager;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		[SerializeField]
		private Transform HatAnchorBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		[SerializeField]
		private Transform LeftHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		[SerializeField]
		private Transform RightHandWatchAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		[SerializeField]
		private GameObject LeftHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		[SerializeField]
		private GameObject RightHandWatchVisuals;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		private FQMRJXVJOSP ZJLVYDSEXQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		private EROHEZQIFNW OLNWYRZHPYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		private OCCDOUHRKRS XIZXWOBSCWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		private OCCDOUHRKRS CIQYEAKOGXH;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public FQMRJXVJOSP FCKHZQLTLFQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x97FA830", Offset = "0x97F9230", VA = "0x1897FA830", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public EROHEZQIFNW VQKKOCGVPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x97FA880", Offset = "0x97F9280", VA = "0x1897FA880", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public OCCDOUHRKRS ZCSXJIEIFNT
		{
			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x97FA8D0", Offset = "0x97F92D0", VA = "0x1897FA8D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public OCCDOUHRKRS SBPPBNZESKQ
		{
			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x97FA920", Offset = "0x97F9320", VA = "0x1897FA920", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Transform YZCBKSRCBBA
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x97FA970", Offset = "0x97F9370", VA = "0x1897FA970", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public AvatarBodyType HOXYRSBDOMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0xD40BE0", Offset = "0xD3F5E0", VA = "0x180D40BE0", Slot = "12")]
			get
			{
				return default(AvatarBodyType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x97F9760", Offset = "0x97F8160", VA = "0x1897F9760")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x97FA260", Offset = "0x97F8C60", VA = "0x1897FA260")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x97F9BE0", Offset = "0x97F85E0", VA = "0x1897F9BE0", Slot = "8")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x97FA260", Offset = "0x97F8C60", VA = "0x1897FA260", Slot = "9")]
		public void TeardownAvatarDisplaySystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x97F97A0", Offset = "0x97F81A0", VA = "0x1897F97A0", Slot = "10")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x97FA310", Offset = "0x97F8D10", VA = "0x1897FA310")]
		public void UpdatePostIKAnimControllers(float deltaTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x97F9C20", Offset = "0x97F8620", VA = "0x1897F9C20")]
		private void KDPLIKGXSWI(GameObject a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x97FA3F0", Offset = "0x97F8DF0", VA = "0x1897FA3F0")]
		private FQMRJXVJOSP VTWBTPNXNNE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x97F9CE0", Offset = "0x97F86E0", VA = "0x1897F9CE0")]
		private EROHEZQIFNW LLSGCWAAUAK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x97F9FE0", Offset = "0x97F89E0", VA = "0x1897F9FE0")]
		private OCCDOUHRKRS NKVIUSIROZM(HandType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x97FA820", Offset = "0x97F9220", VA = "0x1897FA820")]
		public AvatarModernBodyDisplayBehaviour()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public class ODHBISUOWWB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		private MaterialPropertyBlock NKZAGESCIQE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		public Color? YEGQAZKXOPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		public Color? HJRKGIIWZYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		public Color? EZLFCLKJNQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		public Color? OOROMDLCLUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		public Color JRIJVQBGTYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		public Color QHHIVEXSPDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		public Color SUCECVQBSRQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		public Color? OHGNXNCLDWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		public Texture2D GGNMQCTCLVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		public float? CSWDWZCRYHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		public float EAEHCMKFIES;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		public Texture2D GJCPGKPENMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		public Texture2D AGPDIGDISDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		private Dictionary<AvatarMaterialKey, int> AYJIJHYIDOY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		private UpdatableColorType[] ZRMUJEGIKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		private UpdatableTextureType[] FKTZFMSEJHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		public Vector4[] ABCKKVBDEVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		public Vector4[] YXPBDWBHVWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		public Vector4[] BVPGDCLKBJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		public Vector4[] MVCAJDIYKEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		public Vector4[] UITVTXRUVJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		public Vector4[] QHUNLTJIHOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		private List<Texture2D> CMTXJDSCKQU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		private Vector4[] NOVIRFSDITJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		private List<Texture2D> WWVTJVUOSQP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		private float[] YLBKFGLZXCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		private Vector4[] TCWPGRLSEAU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		private float[] AJQGWUPHNJQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		public float[] QMXXJNDBAWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		private List<Texture2D> BWDIBVKVULV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		private float[] XLLGSBNNRJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		private List<Texture2D> JBMEQNFMXVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		private Vector4[] OMJMNRNCSLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		private float[] BQDKGGIFYQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		private Vector4[] GQMJIPSMQXC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		public float[] FMQUXTJGSHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		public Texture2DArray DILCVRWBVUG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		public Texture2DArray HUQQYTWXLAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		public Texture2DArray YVVNCRADYYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		public Texture2DArray HTZHXLQVYCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		private bool HRDSHCLFQWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		private int ESVMWRRNXLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40002E5")]
		private Vector2? NBWAGAYROYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
		[Cpp2IlInjected.Token(Token = "0x40002E6")]
		private TextureFormat YUCWERMDLDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40002E7")]
		private Vector2? BJYKMQACHTP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D4")]
		[Cpp2IlInjected.Token(Token = "0x40002E8")]
		private TextureFormat ISAGFZQGBLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40002E9")]
		private Vector2? FNNMYEIZQPX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40002EA")]
		private TextureFormat URZMFCWBNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40002EB")]
		private Vector2? LJBPCGQTEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40002EC")]
		private TextureFormat SGTMDKRLTID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		private bool WQKINWPMPUV;

		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		private static int RZKRONAWYKP;

		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		private static int IWESLTASGIR;

		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		private static int SDCXJNABXYZ;

		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		private static int CEGUIWVPQZI;

		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		private static int JFQRBCLNQUT;

		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		private static int JCRPNMVYFXS;

		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		private static int XCXBIRQZFQB;

		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		private static int SUURJSQCIJQ;

		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		private static int HCGQYJRYOWS;

		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		private static int CDHJUOQUDDF;

		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		private static int OJKUGWYMRZX;

		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		private static int RYVTFMOMGYN;

		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		private static int ILMIGPPJJIX;

		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		private static int VVAHVUVIIQN;

		[Cpp2IlInjected.Token(Token = "0x40002FC")]
		private static int PVZFVJJFWTI;

		[Cpp2IlInjected.Token(Token = "0x40002FD")]
		private static int CSIFYNTPGPY;

		[Cpp2IlInjected.Token(Token = "0x40002FE")]
		private static int QOFDHKHPGMW;

		[Cpp2IlInjected.Token(Token = "0x40002FF")]
		private static int YVUWNVPYQIJ;

		[Cpp2IlInjected.Token(Token = "0x4000300")]
		private static int OTRBFTUJXWT;

		[Cpp2IlInjected.Token(Token = "0x4000301")]
		private static int RLQQJKSNKOU;

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x9800EF0", Offset = "0x97FF8F0", VA = "0x189800EF0")]
		private ODHBISUOWWB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x9800E30", Offset = "0x97FF830", VA = "0x189800E30")]
		public ODHBISUOWWB(Color a, Color b, Color c, Color? d, Color? e, Color? f, Texture2D g, Texture2D h)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x97FF670", Offset = "0x97FE070", VA = "0x1897FF670")]
		internal int OCDFOMOPDAV(Material a, UpdatableColorType b, UpdatableTextureType c, AvatarBodyPart d)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x97FF5E0", Offset = "0x97FDFE0", VA = "0x1897FF5E0")]
		private int OCDFOMOPDAV(AvatarMaterialKey a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x97FEA00", Offset = "0x97FD400", VA = "0x1897FEA00")]
		internal int MMWHAXRFXOE(Material a, Color b, Color c, Color d, Color e, Color f, Texture2D g, Vector4 h, Texture2D i, Vector4 j, float k, float l, Texture2D m, Vector4 n, float o, Texture2D p, Color q, Vector4 r, UpdatableColorType s, UpdatableTextureType t, AvatarBodyPart u)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x97FF740", Offset = "0x97FE140", VA = "0x1897FF740")]
		private void POHPWBPLDOT(List<Texture2D> a, [Out] Texture2DArray b, [Out] Texture2DArray c, [Out] Texture2DArray d, [Out] Texture2DArray e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x97FE8B0", Offset = "0x97FD2B0", VA = "0x1897FE8B0")]
		public void JEOSWCTERZC(Shader a, Renderer b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x97FF900", Offset = "0x97FE300", VA = "0x1897FF900")]
		private void VSBNCZOTLVF(Shader a, Renderer b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x98008A0", Offset = "0x97FF2A0", VA = "0x1898008A0")]
		private Color XKZLAYBSWWI(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x98005F0", Offset = "0x97FEFF0", VA = "0x1898005F0")]
		private Color WEHSSYSJCWE(Color a, UpdatableColorType b)
		{
			return default(Color);
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x9800740", Offset = "0x97FF140", VA = "0x189800740")]
		private bool WOUEIXRLSKV(Texture2D a, UpdatableTextureType b, [Out] Texture2D c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x97FE800", Offset = "0x97FD200", VA = "0x1897FE800")]
		private void GUHKVMAQWVK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x97FE7C0", Offset = "0x97FD1C0", VA = "0x1897FE7C0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public abstract class UXMOFXXDVIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000305")]
		public readonly ItemDefinitionBodyPart KWNAOCSXIZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000306")]
		protected bool BLJMSQYMIOF;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool OZTYOESMGOQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0xD68210", Offset = "0xD66C10", VA = "0x180D68210")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0xE28730", Offset = "0xE27130", VA = "0x180E28730")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public bool ZUVZGCMUMJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000256")]
			[Cpp2IlInjected.Address(RVA = "0xE281C0", Offset = "0xE26BC0", VA = "0x180E281C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0xE27880", Offset = "0xE26280", VA = "0x180E27880")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public virtual UHAZOTSKNQO.SkinCullingMask JJUXLSOSMYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(UHAZOTSKNQO.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0xDF7E20", Offset = "0xDF6820", VA = "0x180DF7E20", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public bool PKRPEGLVDZI
		{
			[Cpp2IlInjected.Token(Token = "0x600025A")]
			[Cpp2IlInjected.Address(RVA = "0xDA45D0", Offset = "0xDA2FD0", VA = "0x180DA45D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public bool JHQBOQMLJXN
		{
			[Cpp2IlInjected.Token(Token = "0x600025B")]
			[Cpp2IlInjected.Address(RVA = "0x9805C50", Offset = "0x9804650", VA = "0x189805C50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool VUMIBHTRTLI
		{
			[Cpp2IlInjected.Token(Token = "0x600025C")]
			[Cpp2IlInjected.Address(RVA = "0x9805AE0", Offset = "0x98044E0", VA = "0x189805AE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool NAAKBMZZTPL
		{
			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x9805B60", Offset = "0x9804560", VA = "0x189805B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600025E")]
		[Cpp2IlInjected.Address(RVA = "0x9805CD0", Offset = "0x98046D0", VA = "0x189805CD0")]
		protected UXMOFXXDVIG(ItemDefinitionBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600025F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract LTBUWQFXCGW BACMGKPQZAC(List<OVEKQGJRAJB> a, List<OVEKQGJRAJB> b);

		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract QJAYBBQNYGO OBAULQQDWRP(uint a, AvatarSkinnedMeshBoneOrderRemapsData b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public class OJCZFXSLCKJ : QPLENPCTRWI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000307")]
		private AvatarSkinAssetItem ZXIYSCJATJF;

		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x9801620", Offset = "0x9800020", VA = "0x189801620")]
		public OJCZFXSLCKJ(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, ItemDefinitionBodyPart c, [Optional] FaceFeatureId? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x9801720", Offset = "0x9800120", VA = "0x189801720")]
		public OJCZFXSLCKJ(AvatarSkinAssetItem a, AvatarSkinAssetItem.SkinBodyMeshType b, AvatarBodyPart c, UHAZOTSKNQO.SkinCullingMask d, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x98013B0", Offset = "0x97FFDB0", VA = "0x1898013B0", Slot = "6")]
		public override LTBUWQFXCGW BACMGKPQZAC(List<OVEKQGJRAJB> a, List<OVEKQGJRAJB> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public static class NZQVRJIFVTJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000308")]
		private static readonly int[] BYTHWELXGBE;

		[Cpp2IlInjected.Token(Token = "0x4000309")]
		private static readonly int[] QCNITTJVJFS;

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public static int[] BFUNHSNRXOZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x97FE520", Offset = "0x97FCF20", VA = "0x1897FE520")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0x97FE620", Offset = "0x97FD020", VA = "0x1897FE620")]
		public static int[] NOCSOUJYRJY(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x97FE590", Offset = "0x97FCF90", VA = "0x1897FE590")]
		public static int LBSIOENICEB(UpdateLOD a, bool b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x97FE6B0", Offset = "0x97FD0B0", VA = "0x1897FE6B0")]
		private static int PTSOKXTXMXR(UpdateLOD a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x97FE570", Offset = "0x97FCF70", VA = "0x1897FE570")]
		private static int KLCURVKFQFK(UpdateLOD a)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class QCMJOZBPCGT
	{
		[Cpp2IlInjected.Token(Token = "0x2000053")]
		[CompilerGenerated]
		private sealed class GONCBFLYTZM : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400030A")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400030B")]
			private OSEXMMYDSBS RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400030C")]
			public JobHandle MXPCHWUAPNK;

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			private OSEXMMYDSBS XMCHSAEGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000270")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000074")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000272")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600026D")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public GONCBFLYTZM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026E")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600026F")]
			[Cpp2IlInjected.Address(RVA = "0x1586D70", Offset = "0x1585770", VA = "0x181586D70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000271")]
			[Cpp2IlInjected.Address(RVA = "0x97FB7D0", Offset = "0x97FA1D0", VA = "0x1897FB7D0", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public static void YKMVZIDVUYF(string a, int b, long c, long d, long e, long f, long g, long h, long i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x9801CD0", Offset = "0x98006D0", VA = "0x189801CD0")]
		public static OVUANEJXOET OFWSWSWQBIV(JobHandle a, bool b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x9801C70", Offset = "0x9800670", VA = "0x189801C70")]
		[IteratorStateMachine(typeof(GONCBFLYTZM))]
		private static IEnumerator<OSEXMMYDSBS> LWZUBFRXOBC(JobHandle a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class NYXTPKEIPUD
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum MaterialMode
		{
			[Cpp2IlInjected.Token(Token = "0x400031B")]
			General,
			[Cpp2IlInjected.Token(Token = "0x400031C")]
			ColoredHair
		}

		[Cpp2IlInjected.Token(Token = "0x400030D")]
		public static readonly int TBAFCTLOYDR;

		[Cpp2IlInjected.Token(Token = "0x400030E")]
		public static readonly int HFCUBSTRPLG;

		[Cpp2IlInjected.Token(Token = "0x400030F")]
		public static readonly int QYVQNUPRKAI;

		[Cpp2IlInjected.Token(Token = "0x4000310")]
		public static readonly int PLDOHUKPYRX;

		[Cpp2IlInjected.Token(Token = "0x4000311")]
		public static readonly int KXJNDOIXQMK;

		[Cpp2IlInjected.Token(Token = "0x4000312")]
		public static readonly int GYEDMHYDREY;

		[Cpp2IlInjected.Token(Token = "0x4000313")]
		public static readonly int UIRMDZPTBNY;

		[Cpp2IlInjected.Token(Token = "0x4000314")]
		public static readonly int EKJHITATIJD;

		[Cpp2IlInjected.Token(Token = "0x4000315")]
		public static readonly int EOUVACRXPNO;

		[Cpp2IlInjected.Token(Token = "0x4000316")]
		public static readonly int FKPKHGSBLJT;

		[Cpp2IlInjected.Token(Token = "0x4000317")]
		public static readonly int SIBLNMWKFNN;

		[Cpp2IlInjected.Token(Token = "0x4000318")]
		public static readonly int MAULWANBRZC;

		[Cpp2IlInjected.Token(Token = "0x4000319")]
		public static readonly int FDJNKDRATBH;

		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x97FE200", Offset = "0x97FCC00", VA = "0x1897FE200")]
		public static bool DWSOPBJPTNZ(Material a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public class QPLENPCTRWI : UXMOFXXDVIG
	{
		[Cpp2IlInjected.Token(Token = "0x2000057")]
		[CompilerGenerated]
		private sealed class YMQNZVANQVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000324")]
			public ZTZZICZDYWU<GameObject> VSSUKWNXKFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000325")]
			public QPLENPCTRWI TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000326")]
			public Action<string> XYXNEHMLNOY;

			[Cpp2IlInjected.Token(Token = "0x600027E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public YMQNZVANQVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600027F")]
			[Cpp2IlInjected.Address(RVA = "0x9805D40", Offset = "0x9804740", VA = "0x189805D40")]
			internal void QKJFHXCGAIE(GameObject a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000280")]
			[Cpp2IlInjected.Address(RVA = "0x9806110", Offset = "0x9804B10", VA = "0x189806110")]
			internal void QKOMFDWDJTN(string a)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400031E")]
		protected AvatarSkinAssetItem EJWSMMXXIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400031F")]
		protected Material[] KCCOHCMXPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000320")]
		private readonly AvatarSkinAssetItem.SkinBodyMeshType VHOZRJKGFSW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000321")]
		private readonly AssetReference CBHOFRWOVDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000322")]
		private readonly FaceFeatureId? KNPZLIAESKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000323")]
		private SkinnedMeshRenderer[] LVFQKFQMCCG;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public override UHAZOTSKNQO.SkinCullingMask JJUXLSOSMYZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000275")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(UHAZOTSKNQO.SkinCullingMask);
			}
			[Cpp2IlInjected.Token(Token = "0x6000276")]
			[Cpp2IlInjected.Address(RVA = "0xD15A20", Offset = "0xD14420", VA = "0x180D15A20", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000277")]
		[Cpp2IlInjected.Address(RVA = "0x9802390", Offset = "0x9800D90", VA = "0x189802390")]
		public QPLENPCTRWI(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, ItemDefinitionBodyPart d, UHAZOTSKNQO.SkinCullingMask e = (UHAZOTSKNQO.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000278")]
		[Cpp2IlInjected.Address(RVA = "0x98024C0", Offset = "0x9800EC0", VA = "0x1898024C0")]
		public QPLENPCTRWI(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material c, UHAZOTSKNQO.SkinCullingMask d = (UHAZOTSKNQO.SkinCullingMask)0L, [Optional] FaceFeatureId? e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x98022F0", Offset = "0x9800CF0", VA = "0x1898022F0")]
		public QPLENPCTRWI(AvatarSkinAssetItem.SkinBodyMeshType a, AssetReference b, Material[] c, ItemDefinitionBodyPart d, UHAZOTSKNQO.SkinCullingMask e = (UHAZOTSKNQO.SkinCullingMask)0L, [Optional] FaceFeatureId? f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x9801E20", Offset = "0x9800820", VA = "0x189801E20", Slot = "6")]
		public override LTBUWQFXCGW BACMGKPQZAC(List<OVEKQGJRAJB> a, List<OVEKQGJRAJB> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x9802040", Offset = "0x9800A40", VA = "0x189802040", Slot = "7")]
		public override QJAYBBQNYGO OBAULQQDWRP(uint a, AvatarSkinnedMeshBoneOrderRemapsData b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x9802280", Offset = "0x9800C80", VA = "0x189802280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x9802230", Offset = "0x9800C30", VA = "0x189802230")]
		protected void SQLTYPWHGOS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	public class FitMeshHemisphereUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000327")]
		public const float DEFAULT_Y_POSITION_OFFSET = 0.04f;

		[Cpp2IlInjected.Token(Token = "0x4000328")]
		public const float MAX_HEMISPHERE_POSITION_OFFSET = 0.05f;

		[Cpp2IlInjected.Token(Token = "0x4000329")]
		public const float MAX_HEMISPHERE_ROTATION_OFFSET = 45f;

		[Cpp2IlInjected.Token(Token = "0x400032A")]
		public const float MAX_HEMISPHERE_SCALE = 2f;

		[Cpp2IlInjected.Token(Token = "0x400032B")]
		public const float MIN_HEMISPHERE_SCALE = 0.75f;

		[Cpp2IlInjected.Token(Token = "0x400032C")]
		public const float MAX_HEMISPHERE_RADIUS = 0.25f;

		[Cpp2IlInjected.Token(Token = "0x400032D")]
		public const float MIN_HEMISPHERE_RADIUS = 0.125f;

		[Cpp2IlInjected.Token(Token = "0x400032E")]
		public static GameObject ContainerGO;

		[Cpp2IlInjected.Token(Token = "0x400032F")]
		public static GameObject CurrentHairHemisphereGO;

		[Cpp2IlInjected.Token(Token = "0x4000330")]
		public static Transform CurrentHairHemisphereMeshTransform;

		[Cpp2IlInjected.Token(Token = "0x4000331")]
		public static FitMeshHemisphereUpdater CurrentHairHemisphereUpdater;

		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x97FB760", Offset = "0x97FA160", VA = "0x1897FB760")]
		public static void DespawnHairHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public void UpdateValues()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public FitMeshHemisphereUpdater()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public interface BLYMWIUNTWU
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EXNGROUQKPW(Mesh a, Matrix4x4 b, IReadOnlyList<byte> c, bool d = false, UHAZOTSKNQO.SkinCullingMask e = (UHAZOTSKNQO.SkinCullingMask)0L, int f = -1, bool g = false);

		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SMCGHCRCHTM(Allocator a, MeshMergeModes b, byte c, [Optional] IList<int> d, [Optional] IList<int> e);
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public readonly struct LoadedAvatarItemPrefabHolder
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000332")]
		public readonly GameObject outfitObject;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000333")]
		private readonly AvatarItemMaterial avatarItemMaterial;

		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x111A430", Offset = "0x1118E30", VA = "0x18111A430")]
		public LoadedAvatarItemPrefabHolder(GameObject outfitObject, AvatarItemMaterial avatarItemMaterial)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x97FE170", Offset = "0x97FCB70", VA = "0x1897FE170")]
		public void HAJETNCGNGB(Material a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class AVXURZFYCBY : CKRHURCXJMT<Task<(GameObject, AvatarItemMaterial)>, LoadedAvatarItemPrefabHolder>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private struct <WhenAllAvatarComponents>d__6 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000338")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000339")]
			public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400033A")]
			public Task<GameObject> goTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400033B")]
			public Task<AvatarItemMaterial> materialTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400033C")]
			private GameObject <go>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400033D")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400033E")]
			private TaskAwaiter<GameObject> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400033F")]
			private TaskAwaiter<AvatarItemMaterial> <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000291")]
			[Cpp2IlInjected.Address(RVA = "0x9805570", Offset = "0x9803F70", VA = "0x189805570", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000292")]
			[Cpp2IlInjected.Address(RVA = "0x9805A70", Offset = "0x9804470", VA = "0x189805A70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000334")]
		private ZTZZICZDYWU<GameObject> NVKFTHRIUGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000335")]
		private ZTZZICZDYWU<AvatarItemMaterial> FAUOVZYAAVN;

		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x97F2350", Offset = "0x97F0D50", VA = "0x1897F2350")]
		private AVXURZFYCBY(Task<(GameObject, AvatarItemMaterial)> a, ZTZZICZDYWU<GameObject> b, ZTZZICZDYWU<AvatarItemMaterial> c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028A")]
		[Cpp2IlInjected.Address(RVA = "0x97F1D80", Offset = "0x97F0780", VA = "0x1897F1D80")]
		public static AVXURZFYCBY Create(AssetReference outfitPrefabReference, [Optional] AssetReference combinationReference)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x97F2180", Offset = "0x97F0B80", VA = "0x1897F2180", Slot = "11")]
		protected override LoadedAvatarItemPrefabHolder LRZDFQUXBZM(Task<(GameObject, AvatarItemMaterial)> a)
		{
			return default(LoadedAvatarItemPrefabHolder);
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x97F1D00", Offset = "0x97F0700", VA = "0x1897F1D00", Slot = "12")]
		protected override void COVDAMWMAWH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x97F2220", Offset = "0x97F0C20", VA = "0x1897F2220")]
		[AsyncStateMachine(typeof(<WhenAllAvatarComponents>d__6))]
		private static Task<(GameObject, AvatarItemMaterial)> WZXGHWBPJEU(Task<GameObject> a, Task<AvatarItemMaterial> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public static class PINXCSIKTPL
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		private class FARLONFIMIH : CKRHURCXJMT<Task<MaterialMapAsset>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000341")]
			private ZTZZICZDYWU<MaterialMapAsset> MXPCHWUAPNK;

			[Cpp2IlInjected.Token(Token = "0x6000295")]
			[Cpp2IlInjected.Address(RVA = "0x98074E0", Offset = "0x9805EE0", VA = "0x1898074E0")]
			public FARLONFIMIH(ZTZZICZDYWU<MaterialMapAsset> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000296")]
			[Cpp2IlInjected.Address(RVA = "0x9807090", Offset = "0x9805A90", VA = "0x189807090", Slot = "11")]
			protected override Material[] LRZDFQUXBZM(Task<MaterialMapAsset> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000297")]
			[Cpp2IlInjected.Address(RVA = "0x9807030", Offset = "0x9805A30", VA = "0x189807030", Slot = "12")]
			protected override void COVDAMWMAWH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000061")]
		private class NEVIPZJMBEV : CKRHURCXJMT<Task<Material[]>, Material[]>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000346")]
			private List<ZTZZICZDYWU<Material>> FSLNANXGNGB;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0x9808FB0", Offset = "0x98079B0", VA = "0x189808FB0")]
			public NEVIPZJMBEV(Task<Material[]> a, List<ZTZZICZDYWU<Material>> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600029E")]
			[Cpp2IlInjected.Address(RVA = "0x9808F60", Offset = "0x9807960", VA = "0x189808F60", Slot = "11")]
			protected override Material[] LRZDFQUXBZM(Task<Material[]> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0x9808E20", Offset = "0x9807820", VA = "0x189808E20", Slot = "12")]
			protected override void COVDAMWMAWH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000340")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x9801860", Offset = "0x9800260", VA = "0x189801860")]
		public static ZTZZICZDYWU<Material[]> UOZINPQMPOM(AssetReference[] a)
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
		protected class QXJZEZMDYEF : IComparable<QXJZEZMDYEF>, IEquatable<QXJZEZMDYEF>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400039A")]
			public int BDPZRELGSSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400039B")]
			public PlayerAvatarDisplayBase SXWIGZZWDTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400039C")]
			public IList<AvatarItemSelection> GOGYGNUPSNX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400039D")]
			public AvatarItemBodyType RRACHLPDUZK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400039E")]
			public AvatarBuildType AEBINIGRHOW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400039F")]
			public bool KGFFBQGREQV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
			[Cpp2IlInjected.Token(Token = "0x40003A0")]
			public bool YWUCAKTZIEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003A1")]
			public int[] YSZJDZCLAPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003A2")]
			public float SBZLMLZQFMW;

			[Cpp2IlInjected.Token(Token = "0x6000324")]
			[Cpp2IlInjected.Address(RVA = "0x981E440", Offset = "0x981CE40", VA = "0x18981E440", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000325")]
			[Cpp2IlInjected.Address(RVA = "0x981E2F0", Offset = "0x981CCF0", VA = "0x18981E2F0", Slot = "4")]
			public int CompareTo(QXJZEZMDYEF other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x6000326")]
			[Cpp2IlInjected.Address(RVA = "0x981E320", Offset = "0x981CD20", VA = "0x18981E320", Slot = "5")]
			public bool Equals(QXJZEZMDYEF other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000327")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public QXJZEZMDYEF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		protected abstract class UXMOFXXDVIG
		{
			[Cpp2IlInjected.Token(Token = "0x17000095")]
			public virtual bool OZTYOESMGOQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000328")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "4")]
				get
				{
					return default(bool);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000068")]
		protected class HVDTQKTUDBC : UXMOFXXDVIG
		{
			[Cpp2IlInjected.Token(Token = "0x17000096")]
			public MYSATOAIQVZ EZCLKFGQYQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000329")]
				[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public class GQTFHDYZZGL
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
			public static readonly int TFLXQHOPBJV;

			[Cpp2IlInjected.Token(Token = "0x40003A5")]
			public static readonly int FKULIKZTISW;

			[Cpp2IlInjected.Token(Token = "0x40003A6")]
			public static readonly int OXWXBZBDGLV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003A7")]
			protected readonly HandType BREVOTLUNRN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003A8")]
			protected readonly KJXDSNOYYOP UMVDSYCRAIR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003A9")]
			protected readonly Animator REOBLALUSGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003AA")]
			protected readonly Transform YJGXDPVQUEH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003AB")]
			public Vector3 LLYJTQGPLNV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40003AC")]
			protected readonly Transform HFDRNOAXGFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40003AD")]
			public Vector3 YGYLCKFYDRU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
			[Cpp2IlInjected.Token(Token = "0x40003AE")]
			protected bool LBYOALRIKIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x40003AF")]
			protected OCCDOUHRKRS IEQQEWXQUDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
			[Cpp2IlInjected.Token(Token = "0x40003B0")]
			protected bool VRWOWPJQVGW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
			[Cpp2IlInjected.Token(Token = "0x40003B1")]
			protected float DCZLNPBWSIW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x40003B2")]
			protected QXQDNGXEBQE<HandVisualState> HGRZGVGIIUO;

			[Cpp2IlInjected.Token(Token = "0x17000097")]
			public OCCDOUHRKRS SZKYQPSJLQW
			{
				[Cpp2IlInjected.Token(Token = "0x600032A")]
				[Cpp2IlInjected.Address(RVA = "0xD14480", Offset = "0xD12E80", VA = "0x180D14480")]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600032B")]
				[Cpp2IlInjected.Address(RVA = "0xD141C0", Offset = "0xD12BC0", VA = "0x180D141C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000098")]
			public bool WMUDHMDYJJW
			{
				[Cpp2IlInjected.Token(Token = "0x600032C")]
				[Cpp2IlInjected.Address(RVA = "0x1695C20", Offset = "0x1694620", VA = "0x181695C20")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032D")]
				[Cpp2IlInjected.Address(RVA = "0x98075C0", Offset = "0x9805FC0", VA = "0x1898075C0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000099")]
			public bool UCYBLORETIF
			{
				[Cpp2IlInjected.Token(Token = "0x600032E")]
				[Cpp2IlInjected.Address(RVA = "0xD15970", Offset = "0xD14370", VA = "0x180D15970")]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600032F")]
				[Cpp2IlInjected.Address(RVA = "0x9807C30", Offset = "0x9806630", VA = "0x189807C30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009A")]
			public float UNEOIFRIVIL
			{
				[Cpp2IlInjected.Token(Token = "0x6000330")]
				[Cpp2IlInjected.Address(RVA = "0xE277E0", Offset = "0xE261E0", VA = "0x180E277E0")]
				get
				{
					return default(float);
				}
				[Cpp2IlInjected.Token(Token = "0x6000331")]
				[Cpp2IlInjected.Address(RVA = "0x9807D00", Offset = "0x9806700", VA = "0x189807D00")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009B")]
			public HandVisualState TVZAMQPBOFW
			{
				[Cpp2IlInjected.Token(Token = "0x6000332")]
				[Cpp2IlInjected.Address(RVA = "0x98080E0", Offset = "0x9806AE0", VA = "0x1898080E0")]
				get
				{
					return default(HandVisualState);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000333")]
			[Cpp2IlInjected.Address(RVA = "0x9807B20", Offset = "0x9806520", VA = "0x189807B20")]
			public bool KRTWIIAWUZE(HandVisualState a, object b, HandVisualStatePriority c)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000334")]
			[Cpp2IlInjected.Address(RVA = "0x9807E70", Offset = "0x9806870", VA = "0x189807E70")]
			public bool PRPCRETBZFD(object a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000335")]
			[Cpp2IlInjected.Address(RVA = "0x9808290", Offset = "0x9806C90", VA = "0x189808290")]
			protected GQTFHDYZZGL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000336")]
			[Cpp2IlInjected.Address(RVA = "0x9808310", Offset = "0x9806D10", VA = "0x189808310")]
			public GQTFHDYZZGL(HandType a, OCCDOUHRKRS b, Animator c, Transform d, Transform e, Vector3 f, Vector3 g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000337")]
			[Cpp2IlInjected.Address(RVA = "0x98078E0", Offset = "0x98062E0", VA = "0x1898078E0")]
			private void FZVEFWYAIKG(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000338")]
			[Cpp2IlInjected.Address(RVA = "0x9807990", Offset = "0x9806390", VA = "0x189807990")]
			protected void HWRCEZUKEEI(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000339")]
			[Cpp2IlInjected.Address(RVA = "0x9808120", Offset = "0x9806B20", VA = "0x189808120")]
			protected void ZQVJZQHKULL(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033A")]
			[Cpp2IlInjected.Address(RVA = "0x9807690", Offset = "0x9806090", VA = "0x189807690")]
			protected void DTAJTLCBFCX(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033B")]
			[Cpp2IlInjected.Address(RVA = "0x9807F70", Offset = "0x9806970", VA = "0x189807F70")]
			protected void PTPZKDIYHIS(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033C")]
			[Cpp2IlInjected.Address(RVA = "0x9808080", Offset = "0x9806A80", VA = "0x189808080")]
			protected void UPDEXKCKDEN(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033D")]
			[Cpp2IlInjected.Address(RVA = "0x9807A80", Offset = "0x9806480", VA = "0x189807A80")]
			protected void JGTEQKUYNMO(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033E")]
			[Cpp2IlInjected.Address(RVA = "0x9807AD0", Offset = "0x98064D0", VA = "0x189807AD0")]
			protected void JPHRBZBUUPT(ushort a, ushort b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600033F")]
			[Cpp2IlInjected.Address(RVA = "0x98077C0", Offset = "0x98061C0", VA = "0x1898077C0")]
			protected void FOESCBUJYDD(ushort a, ushort b)
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
		private sealed class EJLRVDNBHDT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C4")]
			public PlayerAvatarDisplayBase RQCPREGEBHC;

			[Cpp2IlInjected.Token(Token = "0x6000347")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EJLRVDNBHDT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000348")]
			[Cpp2IlInjected.Address(RVA = "0x9806F60", Offset = "0x9805960", VA = "0x189806F60")]
			internal bool EBLXDSQMBNV()
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		[CompilerGenerated]
		private sealed class KNINQAVMUFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003C5")]
			public PlayerAvatarDisplayBase TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003C6")]
			public AvatarItemBodyType ONGXFTCTYGY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003C7")]
			public Func<AUAMWGBNBSF<Dictionary<string, ZTZZICZDYWU<Texture2D>>>> XZNHWBUDPWZ;

			[Cpp2IlInjected.Token(Token = "0x6000349")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KNINQAVMUFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034A")]
			[Cpp2IlInjected.Address(RVA = "0x98088E0", Offset = "0x98072E0", VA = "0x1898088E0")]
			internal (PGLTTIWTYKI, AUAMWGBNBSF<Dictionary<string, ZTZZICZDYWU<Texture2D>>>) WXVBSOLTMGW(Dictionary<string, GOVRREGVIBX> a)
			{
				return default((PGLTTIWTYKI, AUAMWGBNBSF<Dictionary<string, ZTZZICZDYWU<Texture2D>>>));
			}

			[Cpp2IlInjected.Token(Token = "0x600034B")]
			[Cpp2IlInjected.Address(RVA = "0x9808870", Offset = "0x9807270", VA = "0x189808870")]
			internal AUAMWGBNBSF<Dictionary<string, ZTZZICZDYWU<Texture2D>>> WXKNYAXYTKE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600034C")]
			[Cpp2IlInjected.Address(RVA = "0x9808AD0", Offset = "0x98074D0", VA = "0x189808AD0")]
			internal void WYAIPVFQVSF()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		[CompilerGenerated]
		private struct <CompleteBuildAsync>d__218 : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x981FCD0", Offset = "0x981E6D0", VA = "0x18981FCD0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600034E")]
			[Cpp2IlInjected.Address(RVA = "0x981FF30", Offset = "0x981E930", VA = "0x18981FF30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000070")]
		[CompilerGenerated]
		private sealed class OMMLTIDYXMQ : IEnumerator<OSEXMMYDSBS>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003CC")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003CD")]
			private OSEXMMYDSBS RIDNXCOLQWN;

			[Cpp2IlInjected.Token(Token = "0x1700009C")]
			private OSEXMMYDSBS XMCHSAEGAKP
			{
				[Cpp2IlInjected.Token(Token = "0x6000352")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009D")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x6000354")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600034F")]
			[Cpp2IlInjected.Address(RVA = "0xD1D960", Offset = "0xD1C360", VA = "0x180D1D960")]
			[DebuggerHidden]
			public OMMLTIDYXMQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000350")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "5")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000351")]
			[Cpp2IlInjected.Address(RVA = "0x9809060", Offset = "0x9807A60", VA = "0x189809060", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000353")]
			[Cpp2IlInjected.Address(RVA = "0x9809020", Offset = "0x9807A20", VA = "0x189809020", Slot = "8")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000071")]
		[CompilerGenerated]
		private struct <SetFaceCustomizationSettings>d__130 : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x98201A0", Offset = "0x981EBA0", VA = "0x1898201A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000356")]
			[Cpp2IlInjected.Address(RVA = "0x9820540", Offset = "0x981EF40", VA = "0x189820540", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40003D4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40003D5")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003D6")]
			public AvatarHairPattern pattern;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003D7")]
			public PlayerAvatarDisplayBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003D8")]
			private TaskAwaiter<Texture2D> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000357")]
			[Cpp2IlInjected.Address(RVA = "0x9820AB0", Offset = "0x981F4B0", VA = "0x189820AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000358")]
			[Cpp2IlInjected.Address(RVA = "0x9820E70", Offset = "0x981F870", VA = "0x189820E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000073")]
		[CompilerGenerated]
		private sealed class YHIOIHNXLJI : IEnumerable<SkinnedMeshRenderer>, IEnumerable, IEnumerator<SkinnedMeshRenderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40003D9")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40003DA")]
			private SkinnedMeshRenderer RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40003DB")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40003DC")]
			public PlayerAvatarDisplayBase TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40003DD")]
			private SkinnedMeshRenderer[] IRFNBWFCZWO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40003DE")]
			private int IRAGEPLFQLF;

			[Cpp2IlInjected.Token(Token = "0x1700009E")]
			private SkinnedMeshRenderer QEKIFRFIDFK
			{
				[Cpp2IlInjected.Token(Token = "0x600035C")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700009F")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x600035E")]
				[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000359")]
			[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
			[DebuggerHidden]
			public YHIOIHNXLJI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035A")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035B")]
			[Cpp2IlInjected.Address(RVA = "0x9821E70", Offset = "0x9820870", VA = "0x189821E70", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600035D")]
			[Cpp2IlInjected.Address(RVA = "0x9821E30", Offset = "0x9820830", VA = "0x189821E30", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600035F")]
			[Cpp2IlInjected.Address(RVA = "0x9822040", Offset = "0x9820A40", VA = "0x189822040", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<SkinnedMeshRenderer> VDHBNCEFYOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000360")]
			[Cpp2IlInjected.Address(RVA = "0x9822040", Offset = "0x9820A40", VA = "0x189822040", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000349")]
		protected static List<PlayerAvatarDisplayBase> RTNPMRIIHCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400034E")]
		protected HelmetHairState TBEMUWCVXNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400034F")]
		protected bool PKYRNHFSMGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAD")]
		[Cpp2IlInjected.Token(Token = "0x4000350")]
		protected bool DMACNDWBCCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000351")]
		[SerializeField]
		public AvatarBodyShapeVault BodyShapeVault;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000352")]
		[SerializeField]
		public AvatarFaceShapeVault FaceShapeVault;

		[Cpp2IlInjected.Token(Token = "0x4000353")]
		protected static readonly int[] WPLWWFXBHBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000354")]
		private bool KCYKCDHFNYS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC1")]
		[Cpp2IlInjected.Token(Token = "0x4000355")]
		[SerializeField]
		protected bool ignorePlayerMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000356")]
		[SerializeField]
		public PlayerHandBones HandBones;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000357")]
		private OCCDOUHRKRS XIZXWOBSCWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000358")]
		private OCCDOUHRKRS CIQYEAKOGXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000359")]
		[SerializeField]
		[Autofill(AutofillType.SelfAndChildren, false, false, false)]
		protected PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x400035A")]
		[SerializeField]
		protected Transform torsoPropAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x400035B")]
		[SerializeField]
		protected Transform torsoRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x400035C")]
		[SerializeField]
		protected Transform headRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x400035D")]
		[SerializeField]
		protected Transform leftHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x400035E")]
		[SerializeField]
		protected Transform leftHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x400035F")]
		[SerializeField]
		protected Transform rightHandRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000360")]
		[SerializeField]
		protected Transform rightHandDefaultScaleRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x4000361")]
		[SerializeField]
		protected Animator leftHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000362")]
		[SerializeField]
		protected Animator rightHandAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x4000363")]
		[SerializeField]
		protected Transform leftHandPointingRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x4000364")]
		[SerializeField]
		protected Transform rightHandPointingRoot;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x4000365")]
		protected Collider[] IUJQNPVWLVN;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x4000366")]
		protected Collider[] SPIIRIAHSQK;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x4000367")]
		protected GQTFHDYZZGL[] WDGCSGZLYJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000368")]
		[SerializeField]
		protected Mesh faceMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x4000369")]
		public bool meshDataStructUseSemioptimizedBoneWeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x400036A")]
		protected readonly Dictionary<string, ZTZZICZDYWU<Texture2D>> FQMZGQUOOWK;

		[Cpp2IlInjected.Token(Token = "0x400036D")]
		protected static int XTUYJACOWZG;

		[Cpp2IlInjected.Token(Token = "0x400036E")]
		protected static List<QXJZEZMDYEF> YYXIWAMVPZU;

		[Cpp2IlInjected.Token(Token = "0x400036F")]
		protected static List<QXJZEZMDYEF> NPTYDOUEMYN;

		[Cpp2IlInjected.Token(Token = "0x4000370")]
		protected static OVUANEJXOET QKFAWXLKZFZ;

		[Cpp2IlInjected.Token(Token = "0x4000371")]
		protected static Func<List<QXJZEZMDYEF>, QXJZEZMDYEF> PAFLLNXEAUI;

		[Cpp2IlInjected.Token(Token = "0x4000372")]
		protected static bool MLQXCARRIXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x4000373")]
		protected Color? JBJOXHEWDSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1AC")]
		[Cpp2IlInjected.Token(Token = "0x4000374")]
		protected Color CTGJADFJARI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1BC")]
		[Cpp2IlInjected.Token(Token = "0x4000375")]
		protected Color PXQQVUOKLMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1CC")]
		[Cpp2IlInjected.Token(Token = "0x4000376")]
		protected Color AFKGYRGJHGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x4000377")]
		protected AvatarHairPattern LVHSQSLVOPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x4000378")]
		protected Texture2D MIQWKSWIAZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x4000379")]
		protected MYSATOAIQVZ OBSQIXNDVTM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x400037A")]
		protected Color GTWEBJMOWRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x400037B")]
		protected Color ILAYOQBEDLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x400037C")]
		protected AvatarHairPattern IHQIXAXRKAS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x400037D")]
		protected Texture2D SKQKOORQKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x400037E")]
		protected MYSATOAIQVZ GECBBSHZWWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x400037F")]
		protected MYSATOAIQVZ NJBQBHCLNLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
		[Cpp2IlInjected.Token(Token = "0x4000380")]
		protected Color NQCPHYWDGBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
		[Cpp2IlInjected.Token(Token = "0x4000381")]
		private AdditionalFeetData RYXLYOYAFYD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x4000382")]
		protected readonly IList<AvatarItemSelection> UWGETEKDZAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x4000383")]
		protected readonly IList<AvatarItemSelection> OSQWWZSJZVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x4000384")]
		private AvatarItemBodyType JILXMVKBLHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x264")]
		[Cpp2IlInjected.Token(Token = "0x4000385")]
		[SerializeField]
		protected bool _hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x265")]
		[Cpp2IlInjected.Token(Token = "0x4000386")]
		protected bool MRZUZYFYFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x4000387")]
		protected int[] ROVXUKNZFXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x4000388")]
		protected bool WEXVHMLGMXO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
		[Cpp2IlInjected.Token(Token = "0x4000389")]
		protected bool WSIKVSMLMDE;

		[Cpp2IlInjected.Token(Token = "0x400038A")]
		private static readonly UHAZOTSKNQO.SkinCullingMask BNHKIBZRHNC;

		[Cpp2IlInjected.Token(Token = "0x400038B")]
		private static readonly UHAZOTSKNQO.SkinCullingMask GMSNORAWLVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x272")]
		[Cpp2IlInjected.Token(Token = "0x400038C")]
		protected bool JGGANSSGSCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400038D")]
		protected ZCEWZQPGOQS EPBEQIFDWFI;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public string ZDUTLVHBGCC
		{
			[Cpp2IlInjected.Token(Token = "0x60002A9")]
			[Cpp2IlInjected.Address(RVA = "0xDE9810", Offset = "0xDE8210", VA = "0x180DE9810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002AA")]
			[Cpp2IlInjected.Address(RVA = "0xEA3500", Offset = "0xEA1F00", VA = "0x180EA3500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual bool HGKYXWRRPRY
		{
			[Cpp2IlInjected.Token(Token = "0x60002AC")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool ARPFMWXLXMO
		{
			[Cpp2IlInjected.Token(Token = "0x60002AD")]
			[Cpp2IlInjected.Address(RVA = "0x9811140", Offset = "0x980FB40", VA = "0x189811140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public virtual bool GVXIFIJPYSE
		{
			[Cpp2IlInjected.Token(Token = "0x60002AE")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public virtual bool SXBURRTXBJP
		{
			[Cpp2IlInjected.Token(Token = "0x60002AF")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public bool HNLAHDWSFNH
		{
			[Cpp2IlInjected.Token(Token = "0x60002B0")]
			[Cpp2IlInjected.Address(RVA = "0xE271D0", Offset = "0xE25BD0", VA = "0x180E271D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002B1")]
			[Cpp2IlInjected.Address(RVA = "0x9811700", Offset = "0x9810100", VA = "0x189811700")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public OCCDOUHRKRS ZCSXJIEIFNT
		{
			[Cpp2IlInjected.Token(Token = "0x60002B2")]
			[Cpp2IlInjected.Address(RVA = "0xF86CD0", Offset = "0xF856D0", VA = "0x180F86CD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B3")]
			[Cpp2IlInjected.Address(RVA = "0x9811720", Offset = "0x9810120", VA = "0x189811720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public OCCDOUHRKRS SBPPBNZESKQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002B4")]
			[Cpp2IlInjected.Address(RVA = "0xF86CE0", Offset = "0xF856E0", VA = "0x180F86CE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002B5")]
			[Cpp2IlInjected.Address(RVA = "0x98119F0", Offset = "0x98103F0", VA = "0x1898119F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public PlayerFacialAnimatorBase LQSSMYFFVDY
		{
			[Cpp2IlInjected.Token(Token = "0x60002B6")]
			[Cpp2IlInjected.Address(RVA = "0xE90C20", Offset = "0xE8F620", VA = "0x180E90C20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public GQTFHDYZZGL[] HUHCVQERVBK
		{
			[Cpp2IlInjected.Token(Token = "0x60002B7")]
			[Cpp2IlInjected.Address(RVA = "0x9810CD0", Offset = "0x980F6D0", VA = "0x189810CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public GQTFHDYZZGL LBBUMUYNQDI
		{
			[Cpp2IlInjected.Token(Token = "0x60002B8")]
			[Cpp2IlInjected.Address(RVA = "0x98111B0", Offset = "0x980FBB0", VA = "0x1898111B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public GQTFHDYZZGL MSAGUSLCZSV
		{
			[Cpp2IlInjected.Token(Token = "0x60002B9")]
			[Cpp2IlInjected.Address(RVA = "0x98111E0", Offset = "0x980FBE0", VA = "0x1898111E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		protected bool ZVGDMYRJYGG
		{
			[Cpp2IlInjected.Token(Token = "0x60002BA")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public override int ManualLod
		{
			[Cpp2IlInjected.Token(Token = "0x60002BB")]
			[Cpp2IlInjected.Address(RVA = "0xD2ED50", Offset = "0xD2D750", VA = "0x180D2ED50", Slot = "6")]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60002BC")]
			[Cpp2IlInjected.Address(RVA = "0x9811930", Offset = "0x9810330", VA = "0x189811930", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		protected virtual bool OGLAOKAMLZW
		{
			[Cpp2IlInjected.Token(Token = "0x60002BD")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		protected virtual int[] BHBSEKNARRE
		{
			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0x98103C0", Offset = "0x980EDC0", VA = "0x1898103C0", Slot = "18")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		protected bool JENJUCTYQGB
		{
			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0x980FEA0", Offset = "0x980E8A0", VA = "0x18980FEA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public IEnumerable<SkinnedMeshRenderer> GOTLKCXUGGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x9810BB0", Offset = "0x980F5B0", VA = "0x189810BB0")]
			[IteratorStateMachine(typeof(YHIOIHNXLJI))]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public bool QWVJKLTWNYQ
		{
			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x24F7C20", Offset = "0x24F6620", VA = "0x1824F7C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0x24F7C80", Offset = "0x24F6680", VA = "0x1824F7C80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public new static bool YXHXKAXXYOG
		{
			[Cpp2IlInjected.Token(Token = "0x60002D7")]
			[Cpp2IlInjected.Address(RVA = "0x9811070", Offset = "0x980FA70", VA = "0x189811070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		protected static OVUANEJXOET UQUNZEVYMFY
		{
			[Cpp2IlInjected.Token(Token = "0x60002D8")]
			[Cpp2IlInjected.Address(RVA = "0x9809A30", Offset = "0x9808430", VA = "0x189809A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002D9")]
			[Cpp2IlInjected.Address(RVA = "0x9809860", Offset = "0x9808260", VA = "0x189809860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		protected Color EZLFCLKJNQN
		{
			[Cpp2IlInjected.Token(Token = "0x60002E7")]
			[Cpp2IlInjected.Address(RVA = "0x9809EF0", Offset = "0x98088F0", VA = "0x189809EF0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008C")]
		protected Color OOROMDLCLUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002E8")]
			[Cpp2IlInjected.Address(RVA = "0x980C7B0", Offset = "0x980B1B0", VA = "0x18980C7B0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008D")]
		protected Texture2D QJCPUNWWWHV
		{
			[Cpp2IlInjected.Token(Token = "0x60002E9")]
			[Cpp2IlInjected.Address(RVA = "0x9809BB0", Offset = "0x98085B0", VA = "0x189809BB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public Color JRIJVQBGTYD
		{
			[Cpp2IlInjected.Token(Token = "0x60002EF")]
			[Cpp2IlInjected.Address(RVA = "0x9810C80", Offset = "0x980F680", VA = "0x189810C80")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		protected Color QHHIVEXSPDF
		{
			[Cpp2IlInjected.Token(Token = "0x60002F0")]
			[Cpp2IlInjected.Address(RVA = "0x980A2F0", Offset = "0x9808CF0", VA = "0x18980A2F0")]
			get
			{
				return default(Color);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public MYSATOAIQVZ HILSMITHBJL
		{
			[Cpp2IlInjected.Token(Token = "0x60002F1")]
			[Cpp2IlInjected.Address(RVA = "0x9810C40", Offset = "0x980F640", VA = "0x189810C40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		protected Texture2D DFYGQBPQRXP
		{
			[Cpp2IlInjected.Token(Token = "0x60002F2")]
			[Cpp2IlInjected.Address(RVA = "0x9810220", Offset = "0x980EC20", VA = "0x189810220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000092")]
		public float TGVWWNWOGNY
		{
			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0x9810C60", Offset = "0x980F660", VA = "0x189810C60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000093")]
		public float IZJEKJOPICD
		{
			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x9811120", Offset = "0x980FB20", VA = "0x189811120")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public bool LBFMRSDTLBY
		{
			[Cpp2IlInjected.Token(Token = "0x600031C")]
			[Cpp2IlInjected.Address(RVA = "0x9810C30", Offset = "0x980F630", VA = "0x189810C30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600031D")]
			[Cpp2IlInjected.Address(RVA = "0x98114E0", Offset = "0x980FEE0", VA = "0x1898114E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		public event Action HJXYYKTTLNA
		{
			[Cpp2IlInjected.Token(Token = "0x60002A3")]
			[Cpp2IlInjected.Address(RVA = "0x98108E0", Offset = "0x980F2E0", VA = "0x1898108E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A4")]
			[Cpp2IlInjected.Address(RVA = "0x9811210", Offset = "0x980FC10", VA = "0x189811210")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action ZPEICZPPAYZ
		{
			[Cpp2IlInjected.Token(Token = "0x60002A5")]
			[Cpp2IlInjected.Address(RVA = "0x9810990", Offset = "0x980F390", VA = "0x189810990")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A6")]
			[Cpp2IlInjected.Address(RVA = "0x98112C0", Offset = "0x980FCC0", VA = "0x1898112C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000004")]
		public event Action RICVZUJVJOX
		{
			[Cpp2IlInjected.Token(Token = "0x60002A7")]
			[Cpp2IlInjected.Address(RVA = "0x9810A40", Offset = "0x980F440", VA = "0x189810A40")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002A8")]
			[Cpp2IlInjected.Address(RVA = "0x9811370", Offset = "0x980FD70", VA = "0x189811370")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000005")]
		public event Action<HandType, HandVisualState> QSXCQDHRDDT
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x9810AF0", Offset = "0x980F4F0", VA = "0x189810AF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60002CC")]
			[Cpp2IlInjected.Address(RVA = "0x9811420", Offset = "0x980FE20", VA = "0x189811420")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x980DC30", Offset = "0x980C630", VA = "0x18980DC30")]
		public bool SetDeformation(bool deformBody, bool deformHead)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x9809650", Offset = "0x9808050", VA = "0x189809650")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(RVA = "0x980CE30", Offset = "0x980B830", VA = "0x18980CE30")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x9809F40", Offset = "0x9808940", VA = "0x189809F40")]
		protected void DOPMIIQOHBT(SkinnedMeshRenderer[] a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0x980C8D0", Offset = "0x980B2D0", VA = "0x18980C8D0")]
		protected void MNNJTNVJSUI(SkinnedMeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0x980C800", Offset = "0x980B200", VA = "0x18980C800")]
		protected void MNNJTNVJSUI(MeshRenderer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x980A340", Offset = "0x9808D40", VA = "0x18980A340")]
		public float GetHandOpenClosedAxis(HandType handType)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x980E430", Offset = "0x980CE30", VA = "0x18980E430")]
		public void SetHandOpenClosedAxis(HandType handType, float openClosedAxis)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x980A380", Offset = "0x9808D80", VA = "0x18980A380")]
		public HandVisualState GetHandVisualState(HandType handType)
		{
			return default(HandVisualState);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x98094A0", Offset = "0x9807EA0", VA = "0x1898094A0")]
		public bool AddHandVisualStateToken(HandType handType, HandVisualState handVisualState, object token, GQTFHDYZZGL.HandVisualStatePriority priority)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0x980F150", Offset = "0x980DB50", VA = "0x18980F150")]
		public void SetWatchHand(HandType handType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x980F210", Offset = "0x980DC10", VA = "0x18980F210")]
		public void SetWatchHands(bool showLeftHand, bool showRightHand)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x980D4B0", Offset = "0x980BEB0", VA = "0x18980D4B0")]
		public bool RemoveHandVisualStateToken(HandType handType, object token)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0x980A430", Offset = "0x9808E30", VA = "0x18980A430")]
		public bool GetThumbsUpActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x980EBE0", Offset = "0x980D5E0", VA = "0x18980EBE0")]
		public void SetThumbsUpActive(HandType handType, bool thumbsUpActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x980A3F0", Offset = "0x9808DF0", VA = "0x18980A3F0")]
		public bool GetHandshakeActive(HandType handType)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x980E5D0", Offset = "0x980CFD0", VA = "0x18980E5D0")]
		public void SetHandshakeActive(HandType handType, bool handshakeActive)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x980A060", Offset = "0x9808A60", VA = "0x18980A060")]
		public void ForceUpdateHandsVisualState()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x980F060", Offset = "0x980DA60", VA = "0x18980F060")]
		public void SetUseClassicBeanHandScale(bool value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x9809D50", Offset = "0x9808750", VA = "0x189809D50")]
		public static void ClearQueuedBuilds()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x980A100", Offset = "0x9808B00", VA = "0x18980A100")]
		private static void GKHKPNBAOWD(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x980CD30", Offset = "0x980B730", VA = "0x18980CD30")]
		protected static void OUFGGROAIKN(PlayerAvatarDisplayBase a, List<QXJZEZMDYEF> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x980D290", Offset = "0x980BC90", VA = "0x18980D290")]
		public LTBUWQFXCGW Rebuild()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x980C970", Offset = "0x980B370", VA = "0x18980C970")]
		protected LTBUWQFXCGW MOJIRIHEXCH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x980C9D0", Offset = "0x980B3D0", VA = "0x18980C9D0", Slot = "19")]
		protected virtual LTBUWQFXCGW MOJIRIHEXCH(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, bool f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x980B990", Offset = "0x980A390", VA = "0x18980B990")]
		protected static LTBUWQFXCGW IZWDHBIINVG(QXJZEZMDYEF a, List<QXJZEZMDYEF> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x980A0B0", Offset = "0x9808AB0", VA = "0x18980A0B0")]
		[IteratorStateMachine(typeof(OMMLTIDYXMQ))]
		protected static IEnumerator<OSEXMMYDSBS> GADQYQWQAEH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(RVA = "0x980C200", Offset = "0x980AC00", VA = "0x18980C200")]
		protected static QXJZEZMDYEF JUXIOVVWRGV(List<QXJZEZMDYEF> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(RVA = "0x980DD00", Offset = "0x980C700", VA = "0x18980DD00")]
		[AsyncStateMachine(typeof(<SetFaceCustomizationSettings>d__130))]
		public Task SetFaceCustomizationSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(RVA = "0x980F3F0", Offset = "0x980DDF0", VA = "0x18980F3F0")]
		public bool UpdateFaceAndBodyCustomizationSettings(AvatarData avatarData)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0x980C000", Offset = "0x980AA00", VA = "0x18980C000")]
		public void InitializeFaceFeatures(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x980E9E0", Offset = "0x980D3E0", VA = "0x18980E9E0")]
		public void SetTeamColors(Color? teamColor, bool teamOutfitColorEmissionEnabled, Color emissiveColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(RVA = "0x980D8F0", Offset = "0x980C2F0", VA = "0x18980D8F0")]
		public void SetBeardPrimaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(RVA = "0x980DA90", Offset = "0x980C490", VA = "0x18980DA90")]
		public void SetBeardSecondaryColor([Optional] Color? beardColor, bool updateColor = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0x980D6C0", Offset = "0x980C0C0", VA = "0x18980D6C0")]
		public void SetBeardPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x980D3E0", Offset = "0x980BDE0", VA = "0x18980D3E0")]
		public void RefreshBeard()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x9810450", Offset = "0x980EE50", VA = "0x189810450")]
		private bool ZQWEDAXJUKD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x980E130", Offset = "0x980CB30", VA = "0x18980E130")]
		public void SetHairPrimaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x980E2B0", Offset = "0x980CCB0", VA = "0x18980E2B0")]
		public void SetHairSecondaryColor([Optional] Color? hairColor)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x980DE00", Offset = "0x980C800", VA = "0x18980DE00")]
		[AsyncStateMachine(typeof(<SetHairPatternAsync>d__168))]
		public Task SetHairPatternAsync([Optional] AvatarHairPattern pattern)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x980DEF0", Offset = "0x980C8F0", VA = "0x18980DEF0")]
		public void SetHairPattern([Optional] AvatarHairPattern pattern)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x980D450", Offset = "0x980BE50", VA = "0x18980D450")]
		public void RefreshHair()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x980A230", Offset = "0x9808C30", VA = "0x18980A230")]
		private bool GLJIPWCAZDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x980E8E0", Offset = "0x980D2E0", VA = "0x18980E8E0")]
		public void SetSkinColor(Color skinColor, [Optional] Color? skinEmissiveColorOverride, [Optional] float? skinGlossOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x980ECF0", Offset = "0x980D6F0", VA = "0x18980ECF0")]
		public void SetUgcItemVisualOverrides(AvatarItemSelection overrideItem, AvatarBodyType avatarBodyType, Texture textureOverride, Color colorOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x980CF70", Offset = "0x980B970", VA = "0x18980CF70")]
		private void PEUHSRKROIP(BodyProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x980FA40", Offset = "0x980E440", VA = "0x18980FA40")]
		private void WSCVWYDTOHG(BodyPropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x980C0C0", Offset = "0x980AAC0", VA = "0x18980C0C0")]
		private void JLJYJYSPNGG(FaceProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x980C160", Offset = "0x980AB60", VA = "0x18980C160")]
		private void JQVTGJMCRLW(NoseProperty a, float b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x9809390", Offset = "0x9807D90", VA = "0x189809390")]
		private void AALSLLGKZUV(FacePropertyData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x9809A80", Offset = "0x9808480", VA = "0x189809A80")]
		private void BYWDIZHIIUP(NosePropertyData a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x980E7D0", Offset = "0x980D1D0", VA = "0x18980E7D0")]
		public bool SetHideEars(bool hideEars)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x980E7B0", Offset = "0x980D1B0", VA = "0x18980E7B0")]
		public bool SetHelmetHair(HelmetHairState helmetHairState)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x980E6E0", Offset = "0x980D0E0", VA = "0x18980E6E0")]
		public void SetHatAnchorParameters(KUFLWHMRCEV newAnchorParams, bool useParameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x980E8C0", Offset = "0x980D2C0", VA = "0x18980E8C0")]
		public bool SetShowModestyAndValidationGuidelines(bool showModestyAndValidationGuidelines)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x980F2E0", Offset = "0x980DCE0", VA = "0x18980F2E0")]
		public void SetupDisplayLODs(LODSelection lodSelection)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x980CB00", Offset = "0x980B500", VA = "0x18980CB00")]
		protected int[] MVTJNFELXOX(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x980E880", Offset = "0x980D280", VA = "0x18980E880")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x980E7F0", Offset = "0x980D1F0", VA = "0x18980E7F0")]
		public void SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, bool isFirstPerson, bool usesBodyPaint, bool shouldBuildPotatoAvatar)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x980E840", Offset = "0x980D240", VA = "0x18980E840")]
		public LTBUWQFXCGW SetOutfitSelections(IList<AvatarItemSelection> pieces, AvatarItemBodyType avatarItemBodyType, LODSelection lodSelection, bool isFirstPerson, bool usesBodyPaint, bool forceRebuild = false, bool shouldBuildPotatoAvatar = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x980FBF0", Offset = "0x980E5F0", VA = "0x18980FBF0", Slot = "20")]
		protected virtual LTBUWQFXCGW XHUZIMXKIQG(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, LODSelection e, bool f, bool g)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x9810090", Offset = "0x980EA90", VA = "0x189810090")]
		protected int[] YCNGOACQWGG(LODSelection a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "21")]
		protected virtual PGLTTIWTYKI TFPKDCXJDPR(AvatarItemBodyType a, Dictionary<string, GOVRREGVIBX> b, Dictionary<string, ZTZZICZDYWU<Texture2D>> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x980D090", Offset = "0x980BA90", VA = "0x18980D090", Slot = "22")]
		protected virtual void PNZIRRLWPVS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x980B6E0", Offset = "0x980A0E0", VA = "0x18980B6E0", Slot = "23")]
		protected virtual LTBUWQFXCGW IPJXEKMWGCM(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c, bool d, int[] e, AvatarBuildType f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x980C290", Offset = "0x980AC90", VA = "0x18980C290", Slot = "24")]
		protected virtual GOVRREGVIBX LOHNFAKSVPB(MYSATOAIQVZ a, AvatarItemBodyType b, AvatarBodyPart c, GOVRREGVIBX d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "25")]
		protected virtual GOVRREGVIBX TYQHEOCRKCH(AvatarItemBodyType a, AvatarBodyPart b, GXYQXFYQCXZ c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x980D010", Offset = "0x980BA10", VA = "0x18980D010")]
		protected void PGVXYFKFRHT(VKTBDUIEYOX a, UHAZOTSKNQO.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x980F310", Offset = "0x980DD10", VA = "0x18980F310")]
		protected void TIAQLHTQZVZ(VKTBDUIEYOX a, UHAZOTSKNQO.SkinCullingMask b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0xD76D40", Offset = "0xD75740", VA = "0x180D76D40", Slot = "26")]
		protected virtual VKTBDUIEYOX LCSWZUIRSZK(VKTBDUIEYOX a, HelmetHairStyle b, bool c, AvatarItemBodyType d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x980A470", Offset = "0x9808E70", VA = "0x18980A470")]
		protected VKTBDUIEYOX HMHBHIWJCDI(IList<AvatarItemSelection> a, AvatarItemBodyType b, bool c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public void CleanupDisplayResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x98097A0", Offset = "0x98081A0", VA = "0x1898097A0")]
		protected UHAZOTSKNQO.SkinCullingMask BAQYSBXHJUA(UHAZOTSKNQO.SkinCullingMask a, AvatarBodyPart b)
		{
			return default(UHAZOTSKNQO.SkinCullingMask);
		}

		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x9809E20", Offset = "0x9808820", VA = "0x189809E20", Slot = "12")]
		[AsyncStateMachine(typeof(<CompleteBuildAsync>d__218))]
		public override Task CompleteBuildAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x980B540", Offset = "0x9809F40", VA = "0x18980B540")]
		protected static UpdatableColorType HUJBCRUPOVJ(UXMOFXXDVIG a, int b)
		{
			return default(UpdatableColorType);
		}

		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x980FF40", Offset = "0x980E940", VA = "0x18980FF40")]
		protected static UpdatableTextureType YBSIEUZIRDN(UXMOFXXDVIG a, int b)
		{
			return default(UpdatableTextureType);
		}

		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x980F390", Offset = "0x980DD90", VA = "0x18980F390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x980F0F0", Offset = "0x980DAF0", VA = "0x18980F0F0")]
		public void SetWaitForUgcTextureLoads(bool shouldWait)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x980EFA0", Offset = "0x980D9A0", VA = "0x18980EFA0")]
		public void SetUgcTextureParameters(ZCEWZQPGOQS parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x9810780", Offset = "0x980F180", VA = "0x189810780")]
		public PlayerAvatarDisplayBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x980CD20", Offset = "0x980B720", VA = "0x18980CD20")]
		[CompilerGenerated]
		[DebuggerHidden]
		private Task NTURLIZNVTO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[ExecuteAlways]
	public class PlayerFacialAnimatorBase : MonoBehaviour, TVCKQLHYVUU
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000075")]
		[CompilerGenerated]
		private struct <BuildFaceFeatureStyle>d__171 : IAsyncStateMachine
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
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400044F")]
			private TaskAwaiter<LPIOUHPGLKY> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A4")]
			[Cpp2IlInjected.Address(RVA = "0x981F400", Offset = "0x981DE00", VA = "0x18981F400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A5")]
			[Cpp2IlInjected.Address(RVA = "0x981F840", Offset = "0x981E240", VA = "0x18981F840", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000450")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000451")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000452")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000453")]
			public bool forceRebuild;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000454")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000455")]
			private FaceStyleSet <styleSet>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000456")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A6")]
			[Cpp2IlInjected.Address(RVA = "0x981F8A0", Offset = "0x981E2A0", VA = "0x18981F8A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A7")]
			[Cpp2IlInjected.Address(RVA = "0x981FC70", Offset = "0x981E670", VA = "0x18981FC70", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000457")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000458")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000459")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045A")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400045B")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003A8")]
			[Cpp2IlInjected.Address(RVA = "0x981FF90", Offset = "0x981E990", VA = "0x18981FF90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003A9")]
			[Cpp2IlInjected.Address(RVA = "0x9820140", Offset = "0x981EB40", VA = "0x189820140", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400045C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400045D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400045E")]
			public AvatarData avatarData;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400045F")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000460")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AA")]
			[Cpp2IlInjected.Address(RVA = "0x98205A0", Offset = "0x981EFA0", VA = "0x1898205A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x9820810", Offset = "0x981F210", VA = "0x189820810", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x4000461")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000462")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000463")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000464")]
			public int eyeSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x4000465")]
			public int eyeBrowSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000466")]
			public int noseSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000467")]
			public int mouthSelection;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000468")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000469")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x9820870", Offset = "0x981F270", VA = "0x189820870", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x9820A50", Offset = "0x981F450", VA = "0x189820A50", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x400046A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400046B")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400046C")]
			public PlayerFacialAnimatorBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400046D")]
			public FaceFeatureType featureType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400046E")]
			public int selectionIndex;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400046F")]
			public AvatarBodyType avatarBodyType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000470")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x9820ED0", Offset = "0x981F8D0", VA = "0x189820ED0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x9821070", Offset = "0x981FA70", VA = "0x189821070", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40003DF")]
		protected const float HYAYOAPZATG = 0.5f;

		[Cpp2IlInjected.Token(Token = "0x40003E0")]
		protected const int BVFGCLDPFZU = 5;

		[Cpp2IlInjected.Token(Token = "0x40003E1")]
		public static readonly int IdleID;

		[Cpp2IlInjected.Token(Token = "0x40003E2")]
		public static readonly int SmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E3")]
		public static readonly int HugeSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003E4")]
		public static readonly int ScoreID;

		[Cpp2IlInjected.Token(Token = "0x40003E5")]
		public static readonly int SadID;

		[Cpp2IlInjected.Token(Token = "0x40003E6")]
		public static readonly int DisgustID;

		[Cpp2IlInjected.Token(Token = "0x40003E7")]
		public static readonly int HitID;

		[Cpp2IlInjected.Token(Token = "0x40003E8")]
		public static readonly int ConcentrateID;

		[Cpp2IlInjected.Token(Token = "0x40003E9")]
		public static readonly int KissID;

		[Cpp2IlInjected.Token(Token = "0x40003EA")]
		public static readonly int TalkingID;

		[Cpp2IlInjected.Token(Token = "0x40003EB")]
		public static readonly int MuteID;

		[Cpp2IlInjected.Token(Token = "0x40003EC")]
		public static readonly int AFKID;

		[Cpp2IlInjected.Token(Token = "0x40003ED")]
		public static readonly int HappyID;

		[Cpp2IlInjected.Token(Token = "0x40003EE")]
		public static readonly int EmoteFlatID;

		[Cpp2IlInjected.Token(Token = "0x40003EF")]
		public static readonly int EmoteHappyID;

		[Cpp2IlInjected.Token(Token = "0x40003F0")]
		public static readonly int EmoteSadID;

		[Cpp2IlInjected.Token(Token = "0x40003F1")]
		public static readonly int EmoteLoveID;

		[Cpp2IlInjected.Token(Token = "0x40003F2")]
		public static readonly int EmoteAngryID;

		[Cpp2IlInjected.Token(Token = "0x40003F3")]
		public static readonly int EmoteLaughID;

		[Cpp2IlInjected.Token(Token = "0x40003F4")]
		public static readonly int EmoteTongueOutID;

		[Cpp2IlInjected.Token(Token = "0x40003F5")]
		public static readonly int EmoteGrimacingID;

		[Cpp2IlInjected.Token(Token = "0x40003F6")]
		public static readonly int EmoteWinkID;

		[Cpp2IlInjected.Token(Token = "0x40003F7")]
		public static readonly int EmoteShockedID;

		[Cpp2IlInjected.Token(Token = "0x40003F8")]
		public static readonly int EmoteNauseatedID;

		[Cpp2IlInjected.Token(Token = "0x40003F9")]
		public static readonly int EmoteSmileSweatID;

		[Cpp2IlInjected.Token(Token = "0x40003FA")]
		public static readonly int EmoteSleepingID;

		[Cpp2IlInjected.Token(Token = "0x40003FB")]
		public static readonly int EmoteThinkingID;

		[Cpp2IlInjected.Token(Token = "0x40003FC")]
		public static readonly int EmoteSmirkID;

		[Cpp2IlInjected.Token(Token = "0x40003FD")]
		public static readonly int EmoteSmileID;

		[Cpp2IlInjected.Token(Token = "0x40003FE")]
		protected static readonly Dictionary<BPEGSSXWFOP.Emote, int> YLVZTHFYVRX;

		[Cpp2IlInjected.Token(Token = "0x40003FF")]
		[CanBeNull]
		protected static IEnumerable<FaceFeatureType> PRMYASGWMPS;

		[Cpp2IlInjected.Token(Token = "0x4000400")]
		protected static Vector2 WMPGKUVCVVK;

		[Cpp2IlInjected.Token(Token = "0x4000401")]
		protected static Vector2 DSWZLXKRLCX;

		[Cpp2IlInjected.Token(Token = "0x4000402")]
		protected static Vector2 MAMULIMIGYI;

		[Cpp2IlInjected.Token(Token = "0x4000403")]
		protected static Vector2 CXVYFGRBQOS;

		[Cpp2IlInjected.Token(Token = "0x4000404")]
		protected static Vector2 QDXXJDSIWQB;

		[Cpp2IlInjected.Token(Token = "0x4000405")]
		protected static Vector2 RRPJVVNDURM;

		[Cpp2IlInjected.Token(Token = "0x4000406")]
		protected static Vector2 TNPDYBQVZWK;

		[Cpp2IlInjected.Token(Token = "0x4000407")]
		protected static Vector2 ONOSHRLQVAZ;

		[Cpp2IlInjected.Token(Token = "0x4000408")]
		protected static Vector2 NTRSTZOTJDQ;

		[Cpp2IlInjected.Token(Token = "0x4000409")]
		protected static Vector2 BSOOGGKSEXE;

		[Cpp2IlInjected.Token(Token = "0x400040A")]
		protected static Vector2 QVTEOFEYZUJ;

		[Cpp2IlInjected.Token(Token = "0x400040B")]
		protected static Vector2 LVYQMWPLVYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400040C")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400040D")]
		[Header("Rendering")]
		[SerializeField]
		public FaceStyleSet faceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400040E")]
		[SerializeField]
		protected float jitterFPS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400040F")]
		[Header("Emotes")]
		[SerializeField]
		public Renderer[] emoteEffectRenderers;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000410")]
		[FormerlySerializedAs("fullBodyFaceStyleSet")]
		[Header("Modern Avatar Facial Features")]
		[SerializeField]
		public FaceStyleSet modernBodyFaceStyleSet;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000411")]
		private AvatarBodyType KTUVLUPRUYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000412")]
		private FaceStyleSet YUEXQNWTEZB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000413")]
		[SerializeField]
		protected bool debugEyeJitterInEditor;

		[Cpp2IlInjected.Token(Token = "0x4000414")]
		protected const int PKDECTWJKOJ = -1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000415")]
		protected int PPVQNVZXFDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000416")]
		protected int BSQYUFCYYHW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000417")]
		protected int NJSYSSHOODY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000418")]
		protected int RKVACPWVICU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000419")]
		protected Vector2 LZLBEFGGLLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400041A")]
		protected float IDZCUSQZJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400041B")]
		protected float UNJBAQNUNUM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400041C")]
		protected float LXEHXTTREVI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400041D")]
		protected Vector2 OINMROOBDAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400041E")]
		protected float EOATNZDFLZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400041F")]
		protected float AXSSWRMXGAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000420")]
		protected float QCHBBOSHEUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000421")]
		protected Vector2 NEAOOHEQMYA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
		[Cpp2IlInjected.Token(Token = "0x4000422")]
		protected float JHYPJXXWCXX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000423")]
		protected float DJSNVWVBTEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000424")]
		protected float WPHEBILBNVS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000425")]
		protected Vector2 DCTBQIFKKQW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000426")]
		protected float CJAVIRXQBJR;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000427")]
		protected float OVCAUZOCDTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000428")]
		protected float BGLCGKHCERE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000429")]
		protected List<SelectableFaceOption> VWHAISYPAUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400042A")]
		protected List<SelectableFaceOption> XZAHERALEWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400042B")]
		protected List<SelectableFaceOption> OLKVPASXNUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400042C")]
		protected List<SelectableFaceOption> NXXHXNGAXQC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400042D")]
		protected int? MAMXFSJGRHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400042E")]
		protected int KSIFGKOMNHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400042F")]
		protected int LJXVYCNZKWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000430")]
		protected int WQMGTNSMSRS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
		[Cpp2IlInjected.Token(Token = "0x4000431")]
		protected int QLTLYZICQBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000432")]
		protected Sprite LROIEDSIVIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000433")]
		protected Sprite CXKUIGLIRVD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000434")]
		protected Sprite JPVUPSLXJWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000435")]
		protected Sprite MQKTUDPLIJA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000436")]
		protected bool CSCKWIICIZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000438")]
		protected string SJYLPXZBOOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000439")]
		protected string UUHFMJWNLFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400043A")]
		protected string UWGXCBEFTYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400043B")]
		protected string ESZWFVQFVXM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400043C")]
		[ReadOnlyField]
		public Sprite eyeSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400043D")]
		[ReadOnlyField]
		public Sprite leftEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400043E")]
		[ReadOnlyField]
		public Sprite rightEyeOnlySprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400043F")]
		public Color leftEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x4000440")]
		public Color leftEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x4000441")]
		public Color rightEyeColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x4000442")]
		public Color rightEyeGleamColorTint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x4000443")]
		[ReadOnlyField]
		public Sprite mouthSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x4000447")]
		protected AvatarConfiguration OONMROCHOPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x4000448")]
		protected LPIOUHPGLKY WVJXDXYNULT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x400044A")]
		protected Dictionary<string, int> PQNNWMTHDUC;

		[Cpp2IlInjected.Token(Token = "0x170000A0")]
		public FaceStyleSet UBHVJCEAZKS
		{
			[Cpp2IlInjected.Token(Token = "0x6000361")]
			[Cpp2IlInjected.Address(RVA = "0x9817490", Offset = "0x9815E90", VA = "0x189817490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A1")]
		public bool DidStart
		{
			[Cpp2IlInjected.Token(Token = "0x6000364")]
			[Cpp2IlInjected.Address(RVA = "0x98174E0", Offset = "0x9815EE0", VA = "0x1898174E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000365")]
			[Cpp2IlInjected.Address(RVA = "0x1C46550", Offset = "0x1C44F50", VA = "0x181C46550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A2")]
		protected virtual bool XZGFSSJDHRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000366")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A3")]
		protected virtual bool MGXWYSYQGGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000367")]
			[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A4")]
		protected int BZHOXFWANAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x9814470", Offset = "0x9812E70", VA = "0x189814470")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool GYCQRLTUZZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x1C44070", Offset = "0x1C42A70", VA = "0x181C44070")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036A")]
			[Cpp2IlInjected.Address(RVA = "0x1C46540", Offset = "0x1C44F40", VA = "0x181C46540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A6")]
		public Renderer[] YTCPVUNHYTX
		{
			[Cpp2IlInjected.Token(Token = "0x600036B")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A7")]
		public bool EIMDOHOZUAY
		{
			[Cpp2IlInjected.Token(Token = "0x600036C")]
			[Cpp2IlInjected.Address(RVA = "0x98174F0", Offset = "0x9815EF0", VA = "0x1898174F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x98176B0", Offset = "0x98160B0", VA = "0x1898176B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A8")]
		protected int HFKGPDECRWN
		{
			[Cpp2IlInjected.Token(Token = "0x600036E")]
			[Cpp2IlInjected.Address(RVA = "0x9812D40", Offset = "0x9811740", VA = "0x189812D40")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000A9")]
		protected int DUIJQSFFBND
		{
			[Cpp2IlInjected.Token(Token = "0x600036F")]
			[Cpp2IlInjected.Address(RVA = "0x9811F00", Offset = "0x9810900", VA = "0x189811F00")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AA")]
		public float YVCKSWMNHWX
		{
			[Cpp2IlInjected.Token(Token = "0x6000370")]
			[Cpp2IlInjected.Address(RVA = "0x98174C0", Offset = "0x9815EC0", VA = "0x1898174C0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x9817690", Offset = "0x9816090", VA = "0x189817690")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AB")]
		public EROHEZQIFNW VQKKOCGVPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000372")]
			[Cpp2IlInjected.Address(RVA = "0xF86DD0", Offset = "0xF857D0", VA = "0x180F86DD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000373")]
			[Cpp2IlInjected.Address(RVA = "0x15621F0", Offset = "0x1560BF0", VA = "0x1815621F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AC")]
		public LPIOUHPGLKY BCXSGPNJPFE
		{
			[Cpp2IlInjected.Token(Token = "0x600038F")]
			[Cpp2IlInjected.Address(RVA = "0xF86DB0", Offset = "0xF857B0", VA = "0x180F86DB0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000390")]
			[Cpp2IlInjected.Address(RVA = "0x9817610", Offset = "0x9816010", VA = "0x189817610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AD")]
		public NoseFaceOption ZAJHQPJGNGX
		{
			[Cpp2IlInjected.Token(Token = "0x6000391")]
			[Cpp2IlInjected.Address(RVA = "0xF86DA0", Offset = "0xF857A0", VA = "0x180F86DA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000392")]
			[Cpp2IlInjected.Address(RVA = "0x174E030", Offset = "0x174CA30", VA = "0x18174E030")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000006")]
		public event Action PTGHZQKWSFZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000362")]
			[Cpp2IlInjected.Address(RVA = "0x98173E0", Offset = "0x9815DE0", VA = "0x1898173E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000363")]
			[Cpp2IlInjected.Address(RVA = "0x9817560", Offset = "0x9815F60", VA = "0x189817560")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000374")]
		[Cpp2IlInjected.Address(RVA = "0x9813B90", Offset = "0x9812590", VA = "0x189813B90")]
		public void LocalPlayEmote(BPEGSSXWFOP.Emote emote, float normalizedTime = 0f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000375")]
		[Cpp2IlInjected.Address(RVA = "0x9813A70", Offset = "0x9812470", VA = "0x189813A70")]
		public bool IsEmotePlaying(BPEGSSXWFOP.Emote emote)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x9814EB0", Offset = "0x98138B0", VA = "0x189814EB0")]
		public void SetIdleHappy(bool happy)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x9811C70", Offset = "0x9810670", VA = "0x189811C70")]
		protected void ASKBRQXXRDU(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x9812060", Offset = "0x9810A60", VA = "0x189812060")]
		protected void CUCTZYBKYFL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x9814400", Offset = "0x9812E00", VA = "0x189814400")]
		protected void QNVNXATFHLD(AvatarBodyPart a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x9811C00", Offset = "0x9810600", VA = "0x189811C00")]
		protected void ANXGLXRSIQA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037B")]
		[Cpp2IlInjected.Address(RVA = "0x9814180", Offset = "0x9812B80", VA = "0x189814180")]
		public void PlayExpression(int hashID)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x98134A0", Offset = "0x9811EA0", VA = "0x1898134A0")]
		protected void IZJLRCDYEBN(bool a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x9812D00", Offset = "0x9811700", VA = "0x189812D00")]
		public List<SelectableFaceOption> GetAvailableFeatures(FaceFeatureType featureType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600037E")]
		[Cpp2IlInjected.Address(RVA = "0x9813560", Offset = "0x9811F60", VA = "0x189813560")]
		public void InitializeFaceFeatureRanges(AvatarConfiguration avatarConfiguration, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x9814B50", Offset = "0x9813550", VA = "0x189814B50")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__147))]
		public Task SetFaceSettings(AvatarData avatarData)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x9814C40", Offset = "0x9813640", VA = "0x189814C40")]
		[AsyncStateMachine(typeof(<SetFaceSettings>d__148))]
		public Task SetFaceSettings(int eyeSelection, int eyeBrowSelection, int noseSelection, int mouthSelection, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x9814F30", Offset = "0x9813930", VA = "0x189814F30")]
		[AsyncStateMachine(typeof(<SetSelectedFaceFeatureAndBuildFaceStyle>d__149))]
		public Task SetSelectedFaceFeatureAndBuildFaceStyle(FaceFeatureType featureType, int selectionIndex, AvatarBodyType avatarBodyType)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x9816500", Offset = "0x9814F00", VA = "0x189816500")]
		protected void ZIASLKXEDCI(FaceFeatureType a, FaceFeatureId b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x9815DB0", Offset = "0x98147B0", VA = "0x189815DB0")]
		protected void YNPFUMVBUYB(FaceFeatureType a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x9812B40", Offset = "0x9811540", VA = "0x189812B40")]
		public static IEnumerable<FaceFeatureType> GetAllFaceFeatureTypes()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x9812640", Offset = "0x9811040", VA = "0x189812640")]
		[AsyncStateMachine(typeof(<SetAllFaceFeatureSettings>d__153))]
		protected Task EIFAMZAVQDJ(AvatarData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x98121C0", Offset = "0x9810BC0", VA = "0x1898121C0")]
		protected void CYGKKRQWPQM(AvatarData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x9814280", Offset = "0x9812C80", VA = "0x189814280")]
		protected static void QGXRGWXRZSK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x98128B0", Offset = "0x98112B0", VA = "0x1898128B0")]
		private void GQDPHZYJHZK(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x9813D70", Offset = "0x9812770", VA = "0x189813D70")]
		protected void OKBHHCWFLYP(FaceFeatureType a, Vector2 b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x98145A0", Offset = "0x9812FA0", VA = "0x1898145A0")]
		public void SetFaceFeatureNormalizedPositionOffset(FaceFeatureType featureType, Vector2 normalizedPositionOffset, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x98124C0", Offset = "0x9810EC0", VA = "0x1898124C0")]
		protected void DRORKHCYDOA(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x9812730", Offset = "0x9811130", VA = "0x189812730")]
		protected void ERSIWSMGRXT(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x9811E30", Offset = "0x9810830", VA = "0x189811E30")]
		protected void BEFNGPWAVXF(FaceFeatureType a, float b, AvatarBodyType c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x9814930", Offset = "0x9813330", VA = "0x189814930")]
		public void SetFaceFeatureNormalizedScaleOffset(FaceFeatureType featureType, float normalizedScale, AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000393")]
		[Cpp2IlInjected.Address(RVA = "0x98141A0", Offset = "0x9812BA0", VA = "0x1898141A0")]
		[AsyncStateMachine(typeof(<BuildFaceFeatureStyle>d__171))]
		protected Task QFHRGPVNAIM(AvatarBodyType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000394")]
		[Cpp2IlInjected.Address(RVA = "0x9813880", Offset = "0x9812280", VA = "0x189813880")]
		public void InitializeFaceFeatureStyleSet(AvatarBodyType avatarBodyType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x9813C90", Offset = "0x9812690", VA = "0x189813C90")]
		protected bool MGBUGKLCGAZ(string a, [Out] int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x9811CF0", Offset = "0x98106F0", VA = "0x189811CF0")]
		protected void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x189DC20", Offset = "0x189C620", VA = "0x18189DC20", Slot = "8")]
		protected virtual void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x9814100", Offset = "0x9812B00", VA = "0x189814100")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x9811F60", Offset = "0x9810960", VA = "0x189811F60")]
		[AsyncStateMachine(typeof(<BuildFaceStyleAsyncIfChanged>d__178))]
		public Task BuildFaceStyleAsyncIfChanged(AvatarBodyType avatarBodyType, bool forceRebuild = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x9815950", Offset = "0x9814350", VA = "0x189815950")]
		public void UpdateFaceDisplays(bool forceUpdateFaceTextures = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x9812DA0", Offset = "0x98117A0", VA = "0x189812DA0")]
		protected void IJJTXNYJPYS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x98156B0", Offset = "0x98140B0", VA = "0x1898156B0")]
		public void UpdateFaceDisplayFeatureTextures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x9814D70", Offset = "0x9813770", VA = "0x189814D70")]
		public void SetFaceSpriteIndices(string leftEyeName, string rightEyeName, string mouthName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x9815040", Offset = "0x9813A40", VA = "0x189815040")]
		public void UpdateFaceDisplayFeaturePositions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x9815AD0", Offset = "0x98144D0", VA = "0x189815AD0")]
		public void UpdateFaceJitterMultiplier()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x9815CC0", Offset = "0x98146C0", VA = "0x189815CC0")]
		protected void YFFGDQEKWUN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x98171E0", Offset = "0x9815BE0", VA = "0x1898171E0")]
		public PlayerFacialAnimatorBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0xD3D320", Offset = "0xD3BD20", VA = "0x180D3D320", Slot = "4")]
		private bool KGHEHBIBOPJ()
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public struct ModernBodyFacialExpression
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000471")]
		public string Name;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000472")]
		public int Id;
	}
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	[ExecuteInEditMode]
	[SelectionBase]
	public class PlayerModernBodyEditorAvatarValidator : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200007E")]
		[CompilerGenerated]
		private sealed class PAAEUSJFBKI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004DF")]
			public NoseType UPLXPNRIBDT;

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public PAAEUSJFBKI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0xE9F980", Offset = "0xE9E380", VA = "0x180E9F980")]
			internal bool JYWVDMZNEOR(NoseShapePropertyData a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007F")]
		[CompilerGenerated]
		private sealed class LJMAZAEGVQS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004E0")]
			public PlayerModernBodyEditorAvatarValidator TICTAVAJHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004E1")]
			public GameObject LRHGTXAQZPF;

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LJMAZAEGVQS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EF")]
			[Cpp2IlInjected.Address(RVA = "0x9808C40", Offset = "0x9807640", VA = "0x189808C40")]
			internal void FCKFZLZQZJS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F0")]
			[Cpp2IlInjected.Address(RVA = "0x9808C70", Offset = "0x9807670", VA = "0x189808C70")]
			internal void FCPMWSTOIVB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F1")]
			[Cpp2IlInjected.Address(RVA = "0x9808CA0", Offset = "0x98076A0", VA = "0x189808CA0")]
			internal void FCUTTZNLSGK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F2")]
			[Cpp2IlInjected.Address(RVA = "0x9808CD0", Offset = "0x98076D0", VA = "0x189808CD0")]
			internal void FDAARGHJBRT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F3")]
			[Cpp2IlInjected.Address(RVA = "0x9808D00", Offset = "0x9807700", VA = "0x189808D00")]
			internal void FDFHONBGLDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F4")]
			[Cpp2IlInjected.Address(RVA = "0x9808D30", Offset = "0x9807730", VA = "0x189808D30")]
			internal void FDKOLTVDUOL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F5")]
			[Cpp2IlInjected.Address(RVA = "0x9808D60", Offset = "0x9807760", VA = "0x189808D60")]
			internal void FDPVJAPBDZU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F6")]
			[Cpp2IlInjected.Address(RVA = "0x9808D90", Offset = "0x9807790", VA = "0x189808D90")]
			internal void FDVCGHIYNLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F7")]
			[Cpp2IlInjected.Address(RVA = "0x9808DC0", Offset = "0x98077C0", VA = "0x189808DC0")]
			internal void FEAJDOCVWWM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F8")]
			[Cpp2IlInjected.Address(RVA = "0x9808DF0", Offset = "0x98077F0", VA = "0x189808DF0")]
			internal void FEFQAUWTGHV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003F9")]
			[Cpp2IlInjected.Address(RVA = "0x9808C10", Offset = "0x9807610", VA = "0x189808C10")]
			internal void CNTKQDMKJKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FA")]
			[Cpp2IlInjected.Address(RVA = "0x9808BB0", Offset = "0x98075B0", VA = "0x189808BB0")]
			internal void CNODSWSMZZI()
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000080")]
		[CompilerGenerated]
		private struct <UpdateFaceFeatures>d__140 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40004E2")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E3")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E4")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004E5")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FB")]
			[Cpp2IlInjected.Address(RVA = "0x9821C30", Offset = "0x9820630", VA = "0x189821C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FC")]
			[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
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
			[Cpp2IlInjected.Token(Token = "0x40004E6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40004E7")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004E8")]
			public PlayerModernBodyEditorAvatarValidator <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004E9")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60003FD")]
			[Cpp2IlInjected.Address(RVA = "0x9821660", Offset = "0x9820060", VA = "0x189821660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003FE")]
			[Cpp2IlInjected.Address(RVA = "0x9821BD0", Offset = "0x98205D0", VA = "0x189821BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000473")]
		public const string IDLE_ANIM_NAME = "Idle";

		[Cpp2IlInjected.Token(Token = "0x4000474")]
		public const string A_POSE_ANIM_NAME = "A Pose";

		[Cpp2IlInjected.Token(Token = "0x4000475")]
		public const string ANIMATION_OVERRIDE_STATE_NAME = "Override";

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000476")]
		public AvatarBodyType avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000478")]
		public Color hairPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000479")]
		public Color hairSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400047A")]
		public Color beardPrimaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400047B")]
		public Color beardSecondaryColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400047C")]
		public Color skinColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x400047D")]
		public int faceShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400047E")]
		public int bodyShapeIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400047F")]
		public int hairPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000480")]
		public int beardPatternIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000481")]
		public AvatarFaceShape[] faceShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000482")]
		public AvatarBodyShape[] bodyShapes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000483")]
		public AvatarHairPattern[] hairPatterns;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000484")]
		public float _avatarScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000485")]
		public bool enablePosing;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000486")]
		public int poseIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000487")]
		public AnimationClip animationOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000488")]
		[Range(0f, 4f)]
		public float animationSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000489")]
		public bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400048A")]
		public HelmetHairState useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400048B")]
		public KUFLWHMRCEV hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x400048C")]
		public KLKBFVTAEND HatAnchorRestrictions;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x400048D")]
		public bool UseHairFitMesh;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD9")]
		[Cpp2IlInjected.Token(Token = "0x400048E")]
		public bool usesHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x400048F")]
		public GameObject hatPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000490")]
		public GameObject hairPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
		[Cpp2IlInjected.Token(Token = "0x4000491")]
		public GameObject earPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
		[Cpp2IlInjected.Token(Token = "0x4000492")]
		public GameObject eyePrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
		[Cpp2IlInjected.Token(Token = "0x4000493")]
		public GameObject mouthPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
		[Cpp2IlInjected.Token(Token = "0x4000494")]
		public GameObject neckPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
		[Cpp2IlInjected.Token(Token = "0x4000495")]
		public GameObject shirtPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
		[Cpp2IlInjected.Token(Token = "0x4000496")]
		public GameObject beltPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
		[Cpp2IlInjected.Token(Token = "0x4000497")]
		public GameObject shoulderPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
		[Cpp2IlInjected.Token(Token = "0x4000498")]
		public GameObject rightHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
		[Cpp2IlInjected.Token(Token = "0x4000499")]
		public GameObject leftHandPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
		[Cpp2IlInjected.Token(Token = "0x400049A")]
		public GameObject legsPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x400049B")]
		public GameObject feetPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
		[Cpp2IlInjected.Token(Token = "0x400049C")]
		public GameObject torsoModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x400049D")]
		public GameObject legsModestyPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x400049E")]
		public GameObject validationPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x400049F")]
		public bool showModestyAndValidationGuidelines;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40004A0")]
		public long baseSkinCullingMask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40004A1")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public PlayerAvatarDisplayBase _avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
		[Cpp2IlInjected.Token(Token = "0x40004A2")]
		private NHAJMTHYQKS XUVGTGOUFAZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
		[Cpp2IlInjected.Token(Token = "0x40004A3")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		public PlayerFacialAnimatorBase facialAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x40004A4")]
		public Animator animator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
		[Cpp2IlInjected.Token(Token = "0x40004A5")]
		public BodyShapeConfiguration bodyShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
		[Cpp2IlInjected.Token(Token = "0x40004A6")]
		public FaceShapeConfiguration faceShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
		[Cpp2IlInjected.Token(Token = "0x40004A7")]
		public NoseShapeConfiguration noseShapeConfiguration;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
		[Cpp2IlInjected.Token(Token = "0x40004A8")]
		public AnimationClip animationClipToOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
		[Cpp2IlInjected.Token(Token = "0x40004A9")]
		private AnimatorOverrideController VZKWEFGJBGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
		[Cpp2IlInjected.Token(Token = "0x40004AA")]
		private List<KeyValuePair<AnimationClip, AnimationClip>> SAZIRSGHDEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
		[Cpp2IlInjected.Token(Token = "0x40004AB")]
		public Transform headIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
		[Cpp2IlInjected.Token(Token = "0x40004AC")]
		public Transform leftHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
		[Cpp2IlInjected.Token(Token = "0x40004AD")]
		public Transform rightHandIKEffector;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
		[Cpp2IlInjected.Token(Token = "0x40004AE")]
		[Range(0f, 2f)]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1DC")]
		[Cpp2IlInjected.Token(Token = "0x40004AF")]
		public int rightHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
		[Cpp2IlInjected.Token(Token = "0x40004B0")]
		[Range(0f, 1f)]
		public float rightHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E4")]
		[Cpp2IlInjected.Token(Token = "0x40004B1")]
		public int leftHandGestureStateIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
		[Cpp2IlInjected.Token(Token = "0x40004B2")]
		[Range(0f, 1f)]
		public float leftHandCurl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1EC")]
		[Cpp2IlInjected.Token(Token = "0x40004B3")]
		[Range(0f, 1f)]
		public float walkSpeed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
		[Cpp2IlInjected.Token(Token = "0x40004B4")]
		public int eyeBrowSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F4")]
		[Cpp2IlInjected.Token(Token = "0x40004B5")]
		public int eyeSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
		[Cpp2IlInjected.Token(Token = "0x40004B6")]
		public int noseSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1FC")]
		[Cpp2IlInjected.Token(Token = "0x40004B7")]
		public int mouthSelection;

		[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
		[Cpp2IlInjected.Token(Token = "0x40004B8")]
		public float eyeBrowPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x204")]
		[Cpp2IlInjected.Token(Token = "0x40004B9")]
		public float eyeBrowPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x208")]
		[Cpp2IlInjected.Token(Token = "0x40004BA")]
		public float eyeBrowScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20C")]
		[Cpp2IlInjected.Token(Token = "0x40004BB")]
		public float eyePositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x210")]
		[Cpp2IlInjected.Token(Token = "0x40004BC")]
		public float eyePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x214")]
		[Cpp2IlInjected.Token(Token = "0x40004BD")]
		public float eyeScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x218")]
		[Cpp2IlInjected.Token(Token = "0x40004BE")]
		public float nosePositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x21C")]
		[Cpp2IlInjected.Token(Token = "0x40004BF")]
		public float noseScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
		[Cpp2IlInjected.Token(Token = "0x40004C0")]
		public float mouthPositionOffsetHorizontal;

		[Cpp2IlInjected.FieldOffset(Offset = "0x224")]
		[Cpp2IlInjected.Token(Token = "0x40004C1")]
		public float mouthPositionOffsetVertical;

		[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
		[Cpp2IlInjected.Token(Token = "0x40004C2")]
		public float mouthScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x22C")]
		[Cpp2IlInjected.Token(Token = "0x40004C3")]
		public float hatNormalizedPositionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
		[Cpp2IlInjected.Token(Token = "0x40004C4")]
		public float hatNormalizedPositionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x234")]
		[Cpp2IlInjected.Token(Token = "0x40004C5")]
		public Vector3 hatHemispherePositionOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
		[Cpp2IlInjected.Token(Token = "0x40004C6")]
		public Vector3 hatHemisphereRotationOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24C")]
		[Cpp2IlInjected.Token(Token = "0x40004C7")]
		public int facialExpressionIndex;

		[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
		[Cpp2IlInjected.Token(Token = "0x40004C8")]
		[Range(0f, 1f)]
		public float normalizedTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
		[Cpp2IlInjected.Token(Token = "0x40004C9")]
		public readonly ModernBodyFacialExpression[] FacialExpressions;

		[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
		[Cpp2IlInjected.Token(Token = "0x40004CA")]
		public readonly string[] BodyPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
		[Cpp2IlInjected.Token(Token = "0x40004CB")]
		public readonly (string, HandVisualState)[] HandPoses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
		[Cpp2IlInjected.Token(Token = "0x40004CC")]
		public bool hideLeftWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x271")]
		[Cpp2IlInjected.Token(Token = "0x40004CD")]
		public bool hideRightWatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x272")]
		[Cpp2IlInjected.Token(Token = "0x40004CE")]
		protected bool BQVHFDRBTXB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x274")]
		[Cpp2IlInjected.Token(Token = "0x40004CF")]
		protected Guid TOKZQFMCUKF;

		[Cpp2IlInjected.Token(Token = "0x40004D0")]
		protected static Guid MYYAEXGLZXO;

		[Cpp2IlInjected.Token(Token = "0x40004D1")]
		private static readonly int LIHFWLLAHNZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
		[Cpp2IlInjected.Token(Token = "0x40004D2")]
		private FQMRJXVJOSP ZJLVYDSEXQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
		[Cpp2IlInjected.Token(Token = "0x40004D3")]
		private EROHEZQIFNW OLNWYRZHPYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
		[Cpp2IlInjected.Token(Token = "0x40004D4")]
		private OCCDOUHRKRS XIZXWOBSCWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
		[Cpp2IlInjected.Token(Token = "0x40004D5")]
		private OCCDOUHRKRS CIQYEAKOGXH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
		[Cpp2IlInjected.Token(Token = "0x40004D6")]
		private AdditionalHatData LMTFZDYBWKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
		[Cpp2IlInjected.Token(Token = "0x40004D7")]
		private readonly Dictionary<GameObject, MYSATOAIQVZ> KNWDPJGEECL;

		[Cpp2IlInjected.Token(Token = "0x170000AE")]
		public static Func<GXYQXFYQCXZ> TELSIRNCGJV
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x981DC40", Offset = "0x981C640", VA = "0x18981DC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60003B2")]
			[Cpp2IlInjected.Address(RVA = "0x981E280", Offset = "0x981CC80", VA = "0x18981E280")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000AF")]
		public bool GLJIPWCAZDH
		{
			[Cpp2IlInjected.Token(Token = "0x60003B3")]
			[Cpp2IlInjected.Address(RVA = "0x981DDA0", Offset = "0x981C7A0", VA = "0x18981DDA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B0")]
		public bool ZQWEDAXJUKD
		{
			[Cpp2IlInjected.Token(Token = "0x60003B4")]
			[Cpp2IlInjected.Address(RVA = "0x981DC90", Offset = "0x981C690", VA = "0x18981DC90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B1")]
		public PlayerAvatarDisplayBase PRBBKLSSFFB
		{
			[Cpp2IlInjected.Token(Token = "0x60003B6")]
			[Cpp2IlInjected.Address(RVA = "0xDD7FB0", Offset = "0xDD69B0", VA = "0x180DD7FB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B2")]
		protected static Guid HYCUOKQDHLX
		{
			[Cpp2IlInjected.Token(Token = "0x60003B7")]
			[Cpp2IlInjected.Address(RVA = "0x981C9A0", Offset = "0x981B3A0", VA = "0x18981C9A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B3")]
		public (GameObject prefab, AvatarBodyPart part)[] RGOJKUOUYSG
		{
			[Cpp2IlInjected.Token(Token = "0x60003CD")]
			[Cpp2IlInjected.Address(RVA = "0x981DEB0", Offset = "0x981C8B0", VA = "0x18981DEB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x981AB70", Offset = "0x9819570", VA = "0x18981AB70")]
		[ContextMenu("Refresh Avatar")]
		private void RebuildTestAvatarContextMenu()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x9817750", Offset = "0x9816150", VA = "0x189817750")]
		private IEnumerable<GameObject> ADATPRZNEKP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x981B090", Offset = "0x9819A90", VA = "0x18981B090")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x981CDE0", Offset = "0x981B7E0", VA = "0x18981CDE0")]
		private void YVAXDELODOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x15A7FD0", Offset = "0x15A69D0", VA = "0x1815A7FD0")]
		protected void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x9818AA0", Offset = "0x98174A0", VA = "0x189818AA0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x981B0A0", Offset = "0x9819AA0", VA = "0x18981B0A0")]
		public void Teardown()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x981AEB0", Offset = "0x98198B0", VA = "0x18981AEB0")]
		public void ShowPose(AnimationClip pose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x981B060", Offset = "0x9819A60", VA = "0x18981B060")]
		public void ShowPose(string poseName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x981ACE0", Offset = "0x98196E0", VA = "0x18981ACE0")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x981AB80", Offset = "0x9819580", VA = "0x18981AB80")]
		public void ResetHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x981C1A0", Offset = "0x981ABA0", VA = "0x18981C1A0")]
		public void UpdateHandAnimation()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x981BB10", Offset = "0x981A510", VA = "0x18981BB10")]
		public void UpdateFaceAndBodyShapes(bool forceRebuild = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x981C5C0", Offset = "0x981AFC0", VA = "0x18981C5C0")]
		public void UpdateNoseShape(NoseType noseType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x981C580", Offset = "0x981AF80", VA = "0x18981C580")]
		public void UpdateLODOverride()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x9819200", Offset = "0x9817C00", VA = "0x189819200", Slot = "4")]
		protected virtual void JCIHXGXEBBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x981A3E0", Offset = "0x9818DE0", VA = "0x18981A3E0", Slot = "5")]
		protected virtual void QGRYNWSYMES()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x9817AF0", Offset = "0x98164F0", VA = "0x189817AF0")]
		public void ApplyHatData(AdditionalHatData hatData, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x9817930", Offset = "0x9816330", VA = "0x189817930")]
		public void ApplyHatAdjustmentsToHatAnchorParams()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x9817E50", Offset = "0x9816850", VA = "0x189817E50")]
		public void ApplyHatUVOverride(Vector2 UVOverride)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x9817D70", Offset = "0x9816770", VA = "0x189817D70")]
		public void ApplyHatPositionAdjustment(Vector3 positionAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x9817DE0", Offset = "0x98167E0", VA = "0x189817DE0")]
		public void ApplyHatRotationAdjustment(Vector3 rotationAdjustment)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x9817EC0", Offset = "0x98168C0", VA = "0x189817EC0")]
		public AvatarItemSelection BuildAvatarItemSelection(GameObject selection, AvatarBodyType bodyType, AvatarBodyPart part)
		{
			return default(AvatarItemSelection);
		}

		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x9817F60", Offset = "0x9816960", VA = "0x189817F60")]
		public void BuildAvatar(bool forceRebuild = false, bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x981B470", Offset = "0x9819E70", VA = "0x18981B470")]
		public void UpdateColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x9817A70", Offset = "0x9816470", VA = "0x189817A70")]
		public void ApplyHatAnchor()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x981C3D0", Offset = "0x981ADD0", VA = "0x18981C3D0")]
		public void UpdateHatAnchor(bool resetHatAnchorParams = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x981C0F0", Offset = "0x981AAF0", VA = "0x18981C0F0")]
		[AsyncStateMachine(typeof(<UpdateFaceFeatures>d__140))]
		public void UpdateFaceFeatures()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x981CA90", Offset = "0x981B490", VA = "0x18981CA90")]
		[AsyncStateMachine(typeof(<UpdateFaceFeaturesInternal>d__141))]
		private Task VOFDJTCKTYQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x9819510", Offset = "0x9817F10", VA = "0x189819510")]
		private void KTYIHRTVUZU(FaceFeatureType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x981B3E0", Offset = "0x9819DE0", VA = "0x18981B3E0")]
		private void UWUTSIIDDCU(FaceFeatureType a, [Out] float b, [Out] float c, [Out] float d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x981B9D0", Offset = "0x981A3D0", VA = "0x18981B9D0")]
		public void UpdateEmote()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x981C8F0", Offset = "0x981B2F0", VA = "0x18981C8F0")]
		public void UpdatePosingProperties()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x981C230", Offset = "0x981AC30", VA = "0x18981C230")]
		public void UpdateHandPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x981A650", Offset = "0x9819050", VA = "0x18981A650")]
		private void QZRCEFGLBXL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void BSPRSGPCPUZ(MYSATOAIQVZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void YOTFHWHSFNX(MYSATOAIQVZ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x9819820", Offset = "0x9818220", VA = "0x189819820")]
		private void OOXOOXNAPQG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x9819BA0", Offset = "0x98185A0", VA = "0x189819BA0")]
		public void PopulatePrefabSlotsByGuid(List<Guid> guids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x981CB60", Offset = "0x981B560", VA = "0x18981CB60")]
		private void XZPWCGTFUCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x9818650", Offset = "0x9817050", VA = "0x189818650")]
		private void CQJTRWVXLIO(OutfitType a, GameObject b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x981CF60", Offset = "0x981B960", VA = "0x18981CF60")]
		public PlayerModernBodyEditorAvatarValidator()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x98197E0", Offset = "0x98181E0", VA = "0x1898197E0")]
		[CompilerGenerated]
		private bool OKFMEBZYSLX(FaceShapePropertyData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x98189F0", Offset = "0x98173F0", VA = "0x1898189F0")]
		[CompilerGenerated]
		private AvatarItemSelection EGEHNKRYKFL((GameObject prefab, AvatarBodyPart part) h)
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
			[Cpp2IlInjected.Token(Token = "0x40004EC")]
			public Transform hatAnchorBone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40004ED")]
			public AvatarSkinnedMeshBoneOrderRemapsData boneOrderRemap;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40004EE")]
			public SkinnedMeshRenderer roomieBaseSkinnedMeshRenderer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40004EF")]
			public Material[] roomieBaseMaterials;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40004F0")]
			public AssetReference roomieBodyAssetReference;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40004F1")]
			public Transform deformRigRoot;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40004F2")]
			public GameObject generatedMeshContainer;

			[Cpp2IlInjected.Token(Token = "0x6000402")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public RoomieAvatarReferences()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004EA")]
		public RoomieAvatarDisplay avatarDisplay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004EB")]
		[SerializeField]
		private RoomieAvatarReferences _references;

		[Cpp2IlInjected.Token(Token = "0x60003FF")]
		[Cpp2IlInjected.Address(RVA = "0x981E740", Offset = "0x981D140", VA = "0x18981E740")]
		public void SetOutfitItems(IEnumerable<Guid> avatarItemGuids)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x981E590", Offset = "0x981CF90", VA = "0x18981E590")]
		public void InitializeAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
		public RoomiePuppet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40004F7")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40004F8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40004F9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(RVA = "0xD11140", Offset = "0xD0FB40", VA = "0x180D11140")]
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
		private sealed class EAFIVIHKRYC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40004FC")]
			public IEnumerable<OutfitType> ZFCUQQTPFNO;

			[Cpp2IlInjected.Token(Token = "0x6000415")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EAFIVIHKRYC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000416")]
			[Cpp2IlInjected.Address(RVA = "0x98220E0", Offset = "0x9820AE0", VA = "0x1898220E0")]
			internal bool YFIXDLRDNGZ(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40004FA")]
		private MYSATOAIQVZ _avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40004FB")]
		private AvatarBodyPart _bodyPart;

		[Cpp2IlInjected.Token(Token = "0x170000B4")]
		public MYSATOAIQVZ EZCLKFGQYQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000409")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B5")]
		public AvatarBodyPart KWNAOCSXIZB
		{
			[Cpp2IlInjected.Token(Token = "0x600040A")]
			[Cpp2IlInjected.Address(RVA = "0xEF9570", Offset = "0xEF7F70", VA = "0x180EF9570")]
			get
			{
				return default(AvatarBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B6")]
		public string YUURIMMXEQV
		{
			[Cpp2IlInjected.Token(Token = "0x600040B")]
			[Cpp2IlInjected.Address(RVA = "0x9806E20", Offset = "0x9805820", VA = "0x189806E20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B7")]
		public bool ZYFWUSKRGAR
		{
			[Cpp2IlInjected.Token(Token = "0x600040F")]
			[Cpp2IlInjected.Address(RVA = "0x9806990", Offset = "0x9805390", VA = "0x189806990")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B8")]
		public bool DMBBOSEGEAU
		{
			[Cpp2IlInjected.Token(Token = "0x6000410")]
			[Cpp2IlInjected.Address(RVA = "0x9806B40", Offset = "0x9805540", VA = "0x189806B40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000B9")]
		public bool NCBGYBJILPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000411")]
			[Cpp2IlInjected.Address(RVA = "0x9806F10", Offset = "0x9805910", VA = "0x189806F10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x9806770", Offset = "0x9805170", VA = "0x189806770", Slot = "4")]
		public bool Equals(AvatarItemSelection other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040D")]
		[Cpp2IlInjected.Address(RVA = "0x98068F0", Offset = "0x98052F0", VA = "0x1898068F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600040E")]
		[Cpp2IlInjected.Address(RVA = "0x98069E0", Offset = "0x98053E0", VA = "0x1898069E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000412")]
		[Cpp2IlInjected.Address(RVA = "0x1B2BE00", Offset = "0x1B2A800", VA = "0x181B2BE00")]
		public AvatarItemSelection(MYSATOAIQVZ avatarItem, AvatarBodyPart bodyPart)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000413")]
		[Cpp2IlInjected.Address(RVA = "0x9806B90", Offset = "0x9805590", VA = "0x189806B90")]
		public bool KXVCEWCSHWU(OutfitType a, AvatarBodyPart b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x9806590", Offset = "0x9804F90", VA = "0x189806590")]
		public bool AMUTKCYWGEZ(AvatarItemSelection a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class IQVIZGJNUPZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000089")]
		[CompilerGenerated]
		private sealed class KNTZTHNOLBC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000501")]
			public IEnumerable<OutfitType> ZFCUQQTPFNO;

			[Cpp2IlInjected.Token(Token = "0x600041F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KNTZTHNOLBC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000420")]
			[Cpp2IlInjected.Address(RVA = "0x98222F0", Offset = "0x9820CF0", VA = "0x1898222F0")]
			internal bool YFIXDLRDNGZ(OutfitType a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40004FD")]
		private MYSATOAIQVZ CXGQTHNYCPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40004FE")]
		private SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart LKJVXACFSYG;

		[Cpp2IlInjected.Token(Token = "0x170000BA")]
		public MYSATOAIQVZ EZCLKFGQYQY
		{
			[Cpp2IlInjected.Token(Token = "0x6000417")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BB")]
		public SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart KWNAOCSXIZB
		{
			[Cpp2IlInjected.Token(Token = "0x6000418")]
			[Cpp2IlInjected.Address(RVA = "0xD1B420", Offset = "0xD19E20", VA = "0x180D1B420")]
			get
			{
				return default(SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BC")]
		public Color? SBTEGNBQFBT
		{
			[Cpp2IlInjected.Token(Token = "0x6000419")]
			[Cpp2IlInjected.Address(RVA = "0xD1DCE0", Offset = "0xD1C6E0", VA = "0x180D1DCE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041A")]
			[Cpp2IlInjected.Address(RVA = "0xD1DD90", Offset = "0xD1C790", VA = "0x180D1DD90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x170000BD")]
		public Vector3? MNYYIPRVPAA
		{
			[Cpp2IlInjected.Token(Token = "0x600041B")]
			[Cpp2IlInjected.Address(RVA = "0xF870D0", Offset = "0xF85AD0", VA = "0x180F870D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600041C")]
			[Cpp2IlInjected.Address(RVA = "0xF87A10", Offset = "0xF86410", VA = "0x180F87A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x9822280", Offset = "0x9820C80", VA = "0x189822280")]
		public IQVIZGJNUPZ(MYSATOAIQVZ a, SVGLTUPYHHQ.HDTPLDNTADR.RoomieBodyPart b, Color? c, Vector3? d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x9822160", Offset = "0x9820B60", VA = "0x189822160")]
		public bool AMUTKCYWGEZ(IQVIZGJNUPZ a)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__1517764575
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x9822380", Offset = "0x9820D80", VA = "0x189822380")]
	public static void WMDBIFXPSXO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x9822370", Offset = "0x9820D70", VA = "0x189822370")]
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
