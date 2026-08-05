using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Foundation;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Scripting;

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
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_DataLayer_Interfaces_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9960FD0", Offset = "0x995F9D0", VA = "0x189960FD0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct PartialViewId
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private bool isPartial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ViewId viewId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private int offset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private bool destroyOnLeave;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9961A30", Offset = "0x9960430", VA = "0x189961A30")]
		public PartialViewId(ViewId viewId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x99619F0", Offset = "0x99603F0", VA = "0x1899619F0")]
		public PartialViewId(int offset, bool destroyOnLeave = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9961910", Offset = "0x9960310", VA = "0x189961910")]
		public ViewId BAHYJLZUFXE([Optional] ViewId a)
		{
			return default(ViewId);
		}
	}
}
namespace RecRoom.DataLayer
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public static class FOEWVARTSRH
	{
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public static readonly Guid LWPEJHCDBUK;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public static readonly Guid XDTQPALMNNK;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly Guid LVWKQPWBUJN;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public static readonly Guid MGKCAYBPIKF;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly Guid BHUGSBFJYBM;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public static readonly Dictionary<string, Guid> GLSWGCWFBVV;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static readonly RRObjectPrefabData KLISXMJOCHD;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public static readonly RRObjectPrefabData CNEKHUVGOCQ;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static readonly RRObjectPrefabData ZSIJODWUIUT;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x995FE40", Offset = "0x995E840", VA = "0x18995FE40")]
		public static Guid DIBMWRNUJOZ(string a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x995FE70", Offset = "0x995E870", VA = "0x18995FE70")]
		public static RRObjectPrefabData DNNNISKDOMD(ObjectPrefabType a)
		{
			return default(RRObjectPrefabData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x995FEE0", Offset = "0x995E8E0", VA = "0x18995FEE0")]
		public static RRObjectPrefabData ESUYXAXGMUU(ObjectPrefabType a)
		{
			return default(RRObjectPrefabData);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x995FF30", Offset = "0x995E930", VA = "0x18995FF30")]
		public static RRObjectPrefabData HBTSVIHGGLX(Guid a)
		{
			return default(RRObjectPrefabData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KJJWDQPGUGI : IComponentData, ICloneable, CDCTYFLOLXP
	{
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly Dictionary<int, object> WWGTSSQWUTA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public Dictionary<int, object> IONDNHXDBLE
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public object this[CreationInstantiationKey key]
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9960F10", Offset = "0x995F910", VA = "0x189960F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9960E90", Offset = "0x995F890", VA = "0x189960E90")]
		[UnityEngine.Scripting.Preserve]
		public KJJWDQPGUGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public KJJWDQPGUGI(Dictionary<int, object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9960D10", Offset = "0x995F710", VA = "0x189960D10", Slot = "5")]
		public bool AAGASPOJQKW(CreationInstantiationKey a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C012C0", Offset = "0x3BFFCC0", VA = "0x183C012C0")]
		public void AYTQOMWSJRN<b>(CreationInstantiationKey a, b b, [Optional] b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3C01DD0", Offset = "0x3C007D0", VA = "0x183C01DD0")]
		public void Set<T>(CreationInstantiationKey key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9960DE0", Offset = "0x995F7E0", VA = "0x189960DE0")]
		public void Remove(CreationInstantiationKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9960D70", Offset = "0x995F770", VA = "0x189960D70", Slot = "4")]
		public object Clone()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum CreationInstantiationKey : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		ColorOverride,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		TeamOverride,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		MakerPenInteractionFilter,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		PersistenceViewId,
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		R1ControlPanelCircuitContextId,
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		R1ControlPanelIsDeserializeId,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		R1ControlPanelParentCircuitContextId,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		PreviewCircuitContextId,
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		PreviewCircuitContextIsDeserializeId,
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		CircuitNodeKey,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		SpawnableToolType,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		ObjectPickupLockedByKeyId,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		CostumeEquipLockedByKeyId,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		PreviewOnly,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		CardBoxViewId,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		RoleId,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		WearerId,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		PlayerSpawnedEquipmentPurpose,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		PlayerSpawnedEquipmentColorGuid,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		PlayerSpawnedEquipmentModificationGuid,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		BagId,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		Tag,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		SuppressCleanupTool,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		SuppressAnimateInParticlesTool,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		SuppressSkinsTool,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		SuppressAnimInOut,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		IgnoreDynamicCollisionsTool,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		RuntimeSpawn,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		OwnerPlayerId,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		SpawnTags,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		ExcludeFromRoomSave,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		AvatarItem,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		ConsumableType,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		ConsumableId,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		GiftJson,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		PlayerRootNetworkId,
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		Source,
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		UnitySubAssets,
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		IsCompanion,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		IsForCompanion,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		ConsumableSeed,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		ConsumableIsRRO,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		AmmoLimit,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		StudioConsumableUnityAssetId
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct CreationInstantiationKey<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public readonly CreationInstantiationKey key;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public readonly T defaultValue;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5373EA0", Offset = "0x53728A0", VA = "0x185373EA0")]
		public CreationInstantiationKey(CreationInstantiationKey key, T defaultValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x53741A0", Offset = "0x5372BA0", VA = "0x1853741A0")]
		public static implicit operator CreationInstantiationKey<T>(CreationInstantiationKey key)
		{
			return default(CreationInstantiationKey<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x53740D0", Offset = "0x5372AD0", VA = "0x1853740D0")]
		public static implicit operator CreationInstantiationKey<T>((CreationInstantiationKey key, T value) a)
		{
			return default(CreationInstantiationKey<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public interface CDCTYFLOLXP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool AAGASPOJQKW(CreationInstantiationKey a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DebuggerTypeProxy(typeof(DebugView))]
	[DebuggerDisplay("Count = {Count}")]
	public struct CreationInstantiationParameters : IEnumerable<object>, IEnumerable, CDCTYFLOLXP
	{
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		private class DebugView : Dictionary<string, object>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Dictionary<int, object> parameters;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool PXKBWMNHSTY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1ABA340", Offset = "0x1AB8D40", VA = "0x181ABA340")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public int DJHUXMLNUTX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x995FCC0", Offset = "0x995E6C0", VA = "0x18995FCC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x995FAF0", Offset = "0x995E4F0", VA = "0x18995FAF0")]
		public static CreationInstantiationParameters Create()
		{
			return default(CreationInstantiationParameters);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		public CreationInstantiationParameters([Optional] Dictionary<int, object> parameters)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x38FAF70", Offset = "0x38F9970", VA = "0x1838FAF70")]
		public void Add<T>(CreationInstantiationKey<T> key, T? value) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x38FAEF0", Offset = "0x38F98F0", VA = "0x1838FAEF0")]
		public void Add<T>((CreationInstantiationKey<T> key, T value) pair)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x38FACA0", Offset = "0x38F96A0", VA = "0x1838FACA0")]
		public void Add<T>(CreationInstantiationKey<T> key, T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x995F8E0", Offset = "0x995E2E0", VA = "0x18995F8E0")]
		public void AFBDVCGAZZM(CreationInstantiationParameters a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x995FC00", Offset = "0x995E600", VA = "0x18995FC00")]
		private void SRPDLCJVRSE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x38FD290", Offset = "0x38FBC90", VA = "0x1838FD290")]
		public bool MAVXVFMPMHQ<a>(CreationInstantiationKey<a> a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x38FCEF0", Offset = "0x38FB8F0", VA = "0x1838FCEF0", Slot = "7")]
		public bool MAVXVFMPMHQ<b>(CreationInstantiationKey a, [Out] b b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x38FCA20", Offset = "0x38FB420", VA = "0x1838FCA20")]
		public c IBWZVIWROFO<c>(CreationInstantiationKey<c> a)
		{
			return (c)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x38FAB00", Offset = "0x38F9500", VA = "0x1838FAB00")]
		public bool AAGASPOJQKW<e>(CreationInstantiationKey<e> a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x995F880", Offset = "0x995E280", VA = "0x18995F880", Slot = "6")]
		public bool AAGASPOJQKW(CreationInstantiationKey a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x38FE970", Offset = "0x38FD370", VA = "0x1838FE970")]
		public void Remove<T>(CreationInstantiationKey<T> key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x995FBB0", Offset = "0x995E5B0", VA = "0x18995FBB0")]
		public void Remove(CreationInstantiationKey key)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560")]
		public Dictionary<int, object> YWIQIJIGNVI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x995FB60", Offset = "0x995E560", VA = "0x18995FB60", Slot = "4")]
		public IEnumerator<object> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x995FC80", Offset = "0x995E680", VA = "0x18995FC80", Slot = "5")]
		private IEnumerator XDTPACFLBGX()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum BakeComponentGroups
	{
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		PrefabComponents,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		LocalObjectComponents,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		NetworkedObjectComponents,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PolicyComponents,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		ConnectableComponents,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		RbexComponents,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		TransformPoseComponents,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		UniformTransformComponents,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		DeformableSizeComponents,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		ShapeComponents,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		PrimitiveComponents,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		SplineComponents,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		SplinePointComponents,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		ContainerComponents,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		ContainerLikeComponents,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		ReplicatorComponents,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		ContainerPivotComponents,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		ShapeContainerComponents,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		CostumePieceComponents,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PreventSerializationComponent,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		DontPropagatePhysicsComponent,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		DontPropagateOwnershipComponent,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		LegacyGameObjectComponents,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		GameObjectLegacyGizmoComponents,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		GameObjectCostumeDummyPropComponents,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		PlayerComponents,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		PlayerRbexComponents,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		PlayerTransformComponents,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		RequireEmbodiedComponents,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		EntityPrefabRootComponents,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		EntityPrefabPartComponents,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		SocketComponents,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		VisibleInHierarchyComponents,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		ToolCleanupComponents,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		TagComponents,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		InteractionFilterTagComponents,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		AutoEmbodimentComponents,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		ReferenceGroupComponents,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		UserTagStorageComponents,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		ReplicatedObjectComponents,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		InteractionFilteringSettingsComponents,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		InventionTrackingComponents,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		ObjectBoardComponents,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		NetworkTransformComponents,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		AlwaysEmbodiedScopeComponents,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		LoadInstanceLifetimeComponents,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		PhysicsModelComponents,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		StudioPropObjectComponents,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		AnimationControllerComponents,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		StudioObjectComponents,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		DesyncNetworkObjectComponents,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		AuthoredPoseComponents,
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		HasCustomInertialPropertiesWhenRootComponents,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		MagneticAnchorComponents,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		SnapPointComponents,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		TerrainGeneratorComponents
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public interface QQYPAOLAOXV
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			Entity,
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			Prefab
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		LocalId UFAJJZRBPJS
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		RRObjectPrefabData CGXMOEOGPZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void AQQFUHUIFWC(params string[] tags);

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void GSGNWBXTPPX(BakeComponentGroups a, Mode b = Mode.Entity);

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void GINVABIMGZO(Type a, ReadOnlySpan<byte> b, int c, Mode d = Mode.Entity);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "5")]
		void QMERDKJVAYB(Type a, Mode b = Mode.Entity);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "6")]
		void EXLFUXIIMCK(BakeComponentGroups a, Mode b = Mode.Entity);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "7")]
		bool YUCCNFWGQBA(BakeComponentGroups a);

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "8")]
		void MIQXSTUOASV(bool a, Mode b = Mode.Entity);

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "9")]
		void RBKHCGFAKFC();

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "10")]
		void MISVRHAUHIO(Type a);

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "11")]
		MQWRQJUBHHL DGUFPUFCIPH(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class QLXUAKBASCZ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9961B10", Offset = "0x9960510", VA = "0x189961B10")]
		public static bool WWGCGGUPXYS(this QQYPAOLAOXV a, BakeComponentGroups b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9961A50", Offset = "0x9960450", VA = "0x189961A50")]
		public static void GENEKESPZMZ(this QQYPAOLAOXV a, QQYPAOLAOXV.Mode b = QQYPAOLAOXV.Mode.Entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9961AB0", Offset = "0x99604B0", VA = "0x189961AB0")]
		public static void IIOWHXRTTKU(this QQYPAOLAOXV a, QQYPAOLAOXV.Mode b = QQYPAOLAOXV.Mode.Entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3E43860", Offset = "0x3E42260", VA = "0x183E43860")]
		public static void OAYTHOYEOVR<T>(this QQYPAOLAOXV a, QQYPAOLAOXV.Mode b = QQYPAOLAOXV.Mode.Entity) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3E42120", Offset = "0x3E40B20", VA = "0x183E42120")]
		public static void FRITHXUFILM<T>(this QQYPAOLAOXV a, QQYPAOLAOXV.Mode b = QQYPAOLAOXV.Mode.Entity) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3E43780", Offset = "0x3E42180", VA = "0x183E43780")]
		public static void MJSCXWFPLEK<T>(this QQYPAOLAOXV a, bool b, QQYPAOLAOXV.Mode c = QQYPAOLAOXV.Mode.Entity) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3E42170", Offset = "0x3E40B70", VA = "0x183E42170")]
		public static void GINVABIMGZO<T>(this QQYPAOLAOXV a, T b, QQYPAOLAOXV.Mode c = QQYPAOLAOXV.Mode.Entity) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3E43A10", Offset = "0x3E42410", VA = "0x183E43A10")]
		public static void QMERDKJVAYB<T>(this QQYPAOLAOXV a, QQYPAOLAOXV.Mode b = QQYPAOLAOXV.Mode.Entity) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x3E43570", Offset = "0x3E41F70", VA = "0x183E43570")]
		public static void MISVRHAUHIO<c>(this QQYPAOLAOXV a) where c : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x3E43AB0", Offset = "0x3E424B0", VA = "0x183E43AB0")]
		public static void VCPHPWBZRLL<T>(this QQYPAOLAOXV a, LocalId b, QQYPAOLAOXV.Mode c = QQYPAOLAOXV.Mode.Entity) where T : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x3E42310", Offset = "0x3E40D10", VA = "0x183E42310")]
		private static void GINVABIMGZO<T>(this QQYPAOLAOXV a, Type b, T c, QQYPAOLAOXV.Mode d = QQYPAOLAOXV.Mode.Entity) where T : struct
		{
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct ConvertVector3ToFloat3
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface QCDBQGRLTCB
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		Entity SNGRHQFBRFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface PVNROETDIYK
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "0")]
		void PreBake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void Bake(QQYPAOLAOXV context);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public interface UMARBKWCPBW
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		MQWRQJUBHHL KMXRSINHMHS(Type a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class BZWYZDNQMNE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x3767AC0", Offset = "0x37664C0", VA = "0x183767AC0")]
		public static void KMXRSINHMHS<a>(this UMARBKWCPBW a, [Out] a b) where a : MQWRQJUBHHL
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface MQWRQJUBHHL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class QWVCOWAXKJB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x3E44420", Offset = "0x3E42E20", VA = "0x183E44420")]
		public static void RCFUOXWHVGD<a>(this QQYPAOLAOXV a) where a : MQWRQJUBHHL, YVPDMNLMUSD, new()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x3E44060", Offset = "0x3E42A60", VA = "0x183E44060")]
		public static void PJRORJFMAWP<b>(this b a, QQYPAOLAOXV b) where b : MQWRQJUBHHL, YVPDMNLMUSD
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x3E441D0", Offset = "0x3E42BD0", VA = "0x183E441D0")]
		public static bool QGMPAPDBSHU<d>(this d a) where d : MQWRQJUBHHL
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface YVPDMNLMUSD
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		Type LSYIPULAZUL
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void CopyTo(MQWRQJUBHHL networkData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface JEWUORBUSNK : PVNROETDIYK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void InitNetworkData(UMARBKWCPBW context);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public interface LXILQCSFSDD : MQWRQJUBHHL
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public interface GGZHMBVCVIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RCEDQIXRAJQ(PlayerId a);

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JLJIALTQBKN(PlayerId a);
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public interface UOKKAIDFHVP
	{
		[Cpp2IlInjected.Token(Token = "0x17000009")]
		ViewId BXSDRUYDYGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public interface DOIVUUSAOOU : UOKKAIDFHVP, CGZDUARXCHU
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(ViewId subViewId, ViewId rootViewId, Dictionary<int, object> dictionary, PlayerId owner);

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		new string ToString();
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public interface QTFSKXYNRUH : UOKKAIDFHVP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void Initialize(ObjectNetworkId parent, Vector3 localPosition, Quaternion localRotation, Vector3 worldScale, bool isSpawnLocation);

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void SetTransformData(Vector3 localPosition, Quaternion localRotation, Vector3 worldScale);

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SetParent(ViewId parent);

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SetWantsToBePhysicsDriven(bool wantsToBePhysicsDriven);

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void SetIsNearPositionBounds(bool isNearPositionBounds);
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public interface CGZDUARXCHU
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnWillDestroy();
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface CAMXWFZJLNX
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		NativeArray<Guid> IIPNYZQGEYU(World a, NativeArray<Entity> b, Allocator c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[ServiceLifetime(Lifetime.OMRoom)]
	public interface UDFHODPEWWA
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool XBTCUMNTFBN(Entity a, int b);

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		ReadOnlySpan<byte> JFANDFWOVYH(Entity a, int b);

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NSDBHUIKQDJ(Entity a, int b, ReadOnlySpan<byte> c);

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void XPEUSRSNYIG(Entity a, int b, Action c);

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void JPTJDSBTIQF(Entity a, int b, Action c);
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public static class CSGJHDUFWGS
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x3821210", Offset = "0x381FC10", VA = "0x183821210")]
		public static a RPKOTXPZTFR<a>(this UDFHODPEWWA a, Entity b, int c) where a : struct
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x38216F0", Offset = "0x38200F0", VA = "0x1838216F0")]
		public static void YSDLNJXHSZR<T>(this UDFHODPEWWA a, Entity b, int c, T d) where T : struct
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("6241769E-7423-45E5-B125-9F7EAA5D5232")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9635027148749164348uL)]
	public struct AiCodeGenIdData : IComponentData, IEquatable<AiCodeGenIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x995F600", Offset = "0x995E000", VA = "0x18995F600")]
		public AiCodeGenIdData(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x995F4F0", Offset = "0x995DEF0", VA = "0x18995F4F0", Slot = "4")]
		public bool Equals(AiCodeGenIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x995F530", Offset = "0x995DF30", VA = "0x18995F530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x995F5F0", Offset = "0x995DFF0", VA = "0x18995F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("399DD840-DE45-43FA-9EB0-5E80BC93C8CB")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3758703684052595571uL)]
	public struct AiCodeGenNameData : IComponentData, IEquatable<AiCodeGenNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString64Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x995F600", Offset = "0x995E000", VA = "0x18995F600")]
		public AiCodeGenNameData(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x995F4F0", Offset = "0x995DEF0", VA = "0x18995F4F0", Slot = "4")]
		public bool Equals(AiCodeGenNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x995F640", Offset = "0x995E040", VA = "0x18995F640", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x995F5F0", Offset = "0x995DFF0", VA = "0x18995F5F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct AiIdData : IComponentData, IEquatable<AiIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
		public AiIdData(uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x995F700", Offset = "0x995E100", VA = "0x18995F700", Slot = "4")]
		public bool Equals(AiIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x995F710", Offset = "0x995E110", VA = "0x18995F710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x1645620", Offset = "0x1644020", VA = "0x181645620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[RecRoom.DataLayer.RRGuid("A8D1A28C-A057-4DF1-B0CF-22A81E217E19")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11317457978519712368uL)]
	public struct AuthoredAIIdData : IComponentData, IEquatable<AuthoredAIIdData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint Value;

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
		public AuthoredAIIdData(uint value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x995F700", Offset = "0x995E100", VA = "0x18995F700", Slot = "4")]
		public bool Equals(AuthoredAIIdData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x995F7A0", Offset = "0x995E1A0", VA = "0x18995F7A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x1645620", Offset = "0x1644020", VA = "0x181645620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("650DAD22-E465-4BF2-9A09-076774E09A3E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3063687516547021329uL)]
	public struct AuthoredLocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x2E08DF0", Offset = "0x2E077F0", VA = "0x182E08DF0")]
		public AuthoredLocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B7CEB5B9-453F-4712-B833-27D907AA13E2")]
	[RecRoom.DataLayer.StableTypeHash(11505792609904010668uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11505792609904010668uL)]
	public struct AuthoredLocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(new float4(float.NaN))")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new float3(float.NaN)")]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public readonly bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x995F830", Offset = "0x995E230", VA = "0x18995F830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x68B1940", Offset = "0x68B0340", VA = "0x1868B1940")]
		public AuthoredLocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x995F840", Offset = "0x995E240", VA = "0x18995F840")]
		public static implicit operator RigidTransform(AuthoredLocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x995F840", Offset = "0x995E240", VA = "0x18995F840")]
		public static implicit operator AuthoredLocalPoseData(RigidTransform pose)
		{
			return default(AuthoredLocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class LFOBDCEPSKE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9960F70", Offset = "0x995F970", VA = "0x189960F70")]
		public static AuthoredLocalPoseData AJCRRVCQKHT([In] this RigidTransform value)
		{
			return default(AuthoredLocalPoseData);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static RigidTransform LFRKGRIXWXR(this AuthoredLocalPoseData a)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9960FA0", Offset = "0x995F9A0", VA = "0x189960FA0")]
		public static RigidTransform GVHDUNBCCLK([In] this AuthoredLocalPoseData value)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C26C4B4E-5EF3-4F81-87C8-FED8EAD37242")]
	[RecRoom.DataLayer.StableTypeHash(9088562008033959482uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(9088562008033959482uL)]
	public struct AuthoredLocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public readonly bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x995F860", Offset = "0x995E260", VA = "0x18995F860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x188D340", Offset = "0x188BD40", VA = "0x18188D340")]
		public AuthoredLocalUniformScaleData(float localUniformScale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("7B1B8635-3FA9-4ADC-922B-3C25CE0C7E7D")]
	[RecRoom.DataLayer.StableTypeHash(10137300772124140051uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10137300772124140051uL)]
	public struct AuthoredParentData : IComponentData, QCDBQGRLTCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private Entity UYWDSBCMMOS
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80")]
		public AuthoredParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x995F870", Offset = "0x995E270", VA = "0x18995F870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public struct AuthoredParentRemovedTag : IComponentData
	{
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[TypeManager.ForcedStableTypeHash(11776442497872827640uL)]
	public struct NetworkTransformTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2631F4C3-DBC5-43A2-9257-7D51063B5B82")]
	[RecRoom.DataLayer.StableTypeHash(14109680383450184248uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14109680383450184248uL)]
	public struct OwnedByTerrainTag : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(true)]
		public bool isOwnedByTerrain;
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B9A63EF5-66A5-463C-8385-A7DC7CE137C3")]
	[RecRoom.DataLayer.StableTypeHash(8594223769175916906uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8594223769175916906uL)]
	public struct ObjectBoardNodeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid nodeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid graphId;
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B26EF01D-F674-4506-80B7-5345391A097E")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5933855128949143734uL)]
	public struct ReplicatedObjectActiveStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(true)]
		public bool active;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("E9BA10A4-4EE9-431D-BD7F-FF2008ABFA03")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16338184133650423946uL)]
	public struct ReplicatedObjectOwnedByPlayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public int actorId;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public struct ReplicatedObjectPendingUnpoolTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("46C500A2-9991-4987-B1AA-66E5C3D8E371")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16223816226138460552uL)]
	public struct ReplicatedObjectTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("5ED157AA-488F-453A-A986-594595B8D777")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17912083982325865811uL)]
	public struct ReplicatorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Target;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool NeedsCircuitUpdate;
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RuntimeOnly]
	[RecRoom.DataLayer.RRGuid("72F1ABE4-CB5D-4809-8C6D-BC4D800D9E30")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11840542726010018465uL)]
	public struct ReplicatorExpectedCircuitsRevisionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint ExpectedRevision;
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public struct ReplicatorHasChildrenTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("AEA4D222-29BA-462F-9C0A-AA2063671C68")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8691279933813304851uL)]
	public struct ReplicatorMaxObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10)]
		public int count;
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("400790C1-E8D9-4779-A549-3780DAEC2FDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16379995002884076574uL)]
	public struct ReplicatorPreallocatedObjectCountData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0)]
		public int preallocatedCopies;
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("6A82044A-E392-4DCD-B4BC-A120E58334EA")]
	[RecRoom.DataLayer.StableTypeHash(8536678595025273356uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8536678595025273356uL)]
	public struct EntityPrefabPartData : IComponentData, IComparable<EntityPrefabPartData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity prefabRoot;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public uint partId;

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x995FD60", Offset = "0x995E760", VA = "0x18995FD60", Slot = "4")]
		public readonly int CompareTo(EntityPrefabPartData other)
		{
			return default(int);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct EntityPrefabPartId : IEquatable<EntityPrefabPartId>, IComparable<EntityPrefabPartId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		[SerializeField]
		private uint id;

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
		internal EntityPrefabPartId(uint id)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xF8BD10", Offset = "0xF8A710", VA = "0x180F8BD10")]
		internal uint BTMACOKOTYL()
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x23BD780", Offset = "0x23BC180", VA = "0x1823BD780", Slot = "4")]
		public bool Equals(EntityPrefabPartId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x995FDB0", Offset = "0x995E7B0", VA = "0x18995FDB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x1645620", Offset = "0x1644020", VA = "0x181645620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x23BD6E0", Offset = "0x23BC0E0", VA = "0x1823BD6E0", Slot = "5")]
		public int CompareTo(EntityPrefabPartId other)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[TypeManager.ForcedStableTypeHash(15026348711748810383uL)]
	public struct EntityPrefabPartsBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public Entity part;
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("F74D558B-BDCC-48C8-A8EF-1F7559E5EAA0")]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2330616907306882483uL)]
	public struct PhysicsModelCollisionModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(CollisionMode.Children)]
		[Config(null, 0)]
		public CollisionMode collisionMode;
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("8A12EB45-2A15-41CE-AFF7-90A9F984D3A2")]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11125590729425051511uL)]
	public struct ContainerIsRecolorableData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public bool IsRecolorable;
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("55EAB643-95BB-4C3A-832C-798EBCD95AD5")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14800424556151816553uL)]
	public struct ContainerNameBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public byte data;

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x2757BF0", Offset = "0x27565F0", VA = "0x182757BF0")]
		public ContainerNameBuffer(byte data)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("89708D57-D027-494A-A159-221E6C643B6B")]
	[RecRoom.DataLayer.StableTypeHash(13657791279235747653uL, 0u)]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13657791279235747653uL)]
	public struct ContainerNameData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public FixedString64Bytes name;
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("CA023286-E0F6-4DA9-A346-94E86B93977C")]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13904209480152351845uL)]
	public struct PhysicsModelGrabbableModeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public GrabbableMode grabbableMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("84485C1B-18ED-4D4A-86A4-34CEED482615")]
	[RecRoom.DataLayer.StableTypeHash(16485879999901987510uL, 0u)]
	[ConfigGroup("Container", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16485879999901987510uL)]
	public struct NavMeshGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(NavMeshGenerationMode.NavMeshGenerator)]
		[Config(null, 0)]
		public NavMeshGenerationMode mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("C5BCE8B3-6E69-41D4-921A-BE2E3E0A4DAB")]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1954118413118190521uL)]
	public struct PhysicsModelCollisionLayerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(CollisionLayerEnum.IsDynamicEnvironment)]
		[Config(null, 0)]
		public CollisionLayerEnum collisionLayer;
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class YUWAYBJQFHV
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public enum Category
		{
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			Dynamic,
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			Static,
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			Enemy,
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			Vehicle
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public enum Subtype
		{
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			Default,
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			Environmental,
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			IgnoreStaticGeometry,
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			IgnoreOtherDynamic,
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			IgnorePlayers,
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			IgnoreMost,
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			Projectile
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9962DA0", Offset = "0x99617A0", VA = "0x189962DA0")]
		public static (Category, Subtype) HOKYSYPFAQD(this CollisionLayerEnum a)
		{
			return default((Category, Subtype));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	[RecRoom.DataLayer.NetworkComponent(4, false)]
	[RecRoom.DataLayer.RRGuid("F63AA9EA-6191-4DE9-BB18-1F049F432124")]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16462677563651546047uL)]
	public struct PhysicsModelFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(PhysicsModelEnumFlags.DEFAULT)]
		[Config(null, 0)]
		public PhysicsModelEnumFlags flags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("B6D08147-6AEA-4270-BDC4-8CF68662318D")]
	[RecRoom.DataLayer.StableTypeHash(1094837642118998916uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1094837642118998916uL)]
	public struct PhysicsModelMassOverrideData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0f)]
		[Config(null, 0)]
		public float mass;
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("17799917-98EE-4D9A-A8D1-B0BE5F7316E3")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10518841812724430444uL)]
	public struct InventionIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0L)]
		public long inventionId;

		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public const long INVALID_INVENTION_ID = 0L;

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static implicit operator InventionIdData(long value)
		{
			return default(InventionIdData);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9960D00", Offset = "0x995F700", VA = "0x189960D00")]
		public readonly bool LSNNFMTCECL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x96058D0", Offset = "0x96042D0", VA = "0x1896058D0")]
		public static bool LSNNFMTCECL(long a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("629F0A56-C478-4353-BBDA-8A8BB5FEE478")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(14338988155392421373uL)]
	public struct InventionInstanceIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public NetworkGuid instanceId;

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public static implicit operator InventionInstanceIdData(Guid value)
		{
			return default(InventionInstanceIdData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5D26C8C6-7B5E-481E-B31E-6F30BE69D3C9")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(7796256876318585598uL)]
	public struct DesyncEntityReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("AFCA5CDE-FE11-4D4A-BBC6-32EE1D254891")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3111430309403391054uL)]
	public struct DesyncNetworkEntityBackReferenceData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity entity;
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F1D14C4E-5388-4D7C-B641-5E79453B80AB")]
	[SerializationOnly]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(3936130774074738641uL)]
	public struct DesyncNetworkComponentsData : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("04FC082C-DAD0-45B5-A3EF-F042100BAF0F")]
	[RuntimeOnly]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16880504271670651740uL)]
	public struct ElementSnapPointData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity snappedTo;
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C9620D1E-DE40-4530-954E-90760F1B7A41")]
	[RuntimeOnly]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12457040547531531440uL)]
	public struct ElementSnapPointRuntimeFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(ElementSnapPointRuntimeFlags.None)]
		public ElementSnapPointRuntimeFlags flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("A3B27452-BD6C-43B2-BAFF-CF885EB1608B")]
	[RuntimeOnly]
	[RecRoom.DataLayer.StableTypeHash(12111354511484844847uL, 0u)]
	[Obfuscation(Exclude = true)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12111354511484844847uL)]
	public struct ParentData : IComponentData, QCDBQGRLTCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity parent;

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		private Entity RecRoom.DataLayer.IEntityComponentData.Entity
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80")]
		public ParentData(Entity parent)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static implicit operator ParentData(Entity entity)
		{
			return default(ParentData);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public struct ParentRemovedTag : IComponentData
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("c886150a-7231-4cc5-a2b2-f222500e6960")]
	[RecRoom.DataLayer.StableTypeHash(1950029632769634832uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1950029632769634832uL)]
	public struct SiblingSortOrderData : IEquatable<SiblingSortOrderData>, IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FractionalIndex order;

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static implicit operator SiblingSortOrderData(FractionalIndex value)
		{
			return default(SiblingSortOrderData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99604E0", Offset = "0x995EEE0", VA = "0x1899604E0", Slot = "4")]
		public bool Equals(SiblingSortOrderData other)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("46CEA601-8AA7-423D-B1EA-EEABAE73413F")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6217116203744017593uL)]
	public struct InteractionFilterAllTagsData : IComponentData, QCDBQGRLTCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity allTags;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private Entity UYWDSBCMMOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("49CEFD0F-3A38-4A9B-835E-10B4C2D08392")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6215026851838101933uL)]
	public struct InteractionFilterAnyTagsData : IComponentData, QCDBQGRLTCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity anyTags;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private Entity UYWDSBCMMOS
		{
			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("11CE457F-4366-4AAD-B7E3-28D82B4FAFCF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6780642047612598977uL)]
	public struct InteractionFilterEnabledData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(InteractionFilterMode.Disabled)]
		public InteractionFilterMode filterMode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F7789094-7D82-4D27-B805-2CC1B8C0A538")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(6642820932987006861uL)]
	public struct InteractionFilterEntityRefData : IComponentData, QCDBQGRLTCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity filterEntity;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private Entity UYWDSBCMMOS
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C7E95AF7-DB7D-4432-8DAA-8F36EC6C4308")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15467295871228743847uL)]
	public struct InteractionFilterNoneTagsData : IComponentData, QCDBQGRLTCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity noneTags;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private Entity UYWDSBCMMOS
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C0280102-4D0D-4960-B108-E59CAE468710")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15820415814547747176uL)]
	public struct ObjectInteractionFilterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity entity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(InteractionFilterMode.EnabledForRole)]
		public InteractionFilterMode mode;
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("A5E08071-6B43-446F-A542-878B31E43736")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10435757312402473454uL)]
	public struct MagneticAnchorData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity connectedAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float snappingDistanceMultiplier;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("007F8815-C87C-4E6B-BC56-3BA0C4888E3D")]
	[RecRoom.DataLayer.StableTypeHash(15012400804589552708uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15012400804589552708uL)]
	public struct OverrideObjectNetworkIdData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public uint networkIdBits;
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("9B8A289B-7511-48FB-9C5A-3202C6AD5185")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(764574820961958276uL)]
	public struct PlayerRoleComponentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public AccountRoleTypeNetworked RoleType;
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("30228348-77DF-48F6-B2EF-B0883D3E10CA")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4540375434353162791uL)]
	public struct MakerPenHeldData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public bool makerPenHeld;
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[RecRoom.DataLayer.NetworkComponent(6, false)]
	[RecRoom.DataLayer.RRGuid("FB9853D6-6231-43FD-A754-00105DC30880")]
	[ConfigGroup("Object", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8459715919607487693uL)]
	public struct ObjectPolicyData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default("new ScaleRestriction(1,1)")]
		public ScaleRestriction scaleRestriction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default("ObjectPolicyUserConfigurableFlags.DEFAULT")]
		[Config(null, 0)]
		public ObjectPolicyUserConfigurableFlags userConfigurableFlags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(CircuitsTransformBehavior.Default)]
		[Config(null, 0)]
		public CircuitsTransformBehavior circuitsTransformBehavior;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("ObjectPolicyEnumFlags.Default")]
		public ObjectPolicyEnumFlags flags;
	}
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("01AEEF22-2473-4505-A473-0BBF009690B3")]
	[SerializationOnly]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2965180940795077803uL)]
	public struct RemovedNetworkComponentsBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ulong stableTypeHash;
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("617A903E-C2C2-467C-A138-287FDB487645")]
	[RecRoom.DataLayer.StableTypeHash(17708500325183871236uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17708500325183871236uL)]
	public struct PlayerScopeData : IComponentData, QCDBQGRLTCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity playerScope;

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Entity SNGRHQFBRFP
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static implicit operator PlayerScopeData(Entity entity)
		{
			return default(PlayerScopeData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F945B699-C9E5-4634-9F64-831484F4F3BD")]
	[RecRoom.DataLayer.StableTypeHash(16642773407304133105uL, 0u)]
	[ConfigGroup("Physics", 0)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16642773407304133105uL)]
	public struct PhysicsMaterialData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(10f)]
		[Config(null, 0)]
		public float density;
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("A2E0AF0F-C284-47E6-9535-A67A29BF5730")]
	[RecRoom.DataLayer.StableTypeHash(10537432342869025182uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10537432342869025182uL)]
	public struct ShapeConfigData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(ShapeConfigFlags.None)]
		public ShapeConfigFlags flags;

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool MMQPWYVGQGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x8CDF070", Offset = "0x8CDDA70", VA = "0x188CDF070")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public bool DYCKKDZFRXS
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x8CDF060", Offset = "0x8CDDA60", VA = "0x188CDF060")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool UWSSZMLEXOX
		{
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x9962190", Offset = "0x9960B90", VA = "0x189962190")]
			get
			{
				return default(bool);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5C706BF1-9D50-456A-B974-521E8E2CC660")]
	[RecRoom.DataLayer.StableTypeHash(10917729582819845312uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(10917729582819845312uL)]
	public struct ShapeTypeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public EShapeType shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("36418781-DB47-4DE7-A138-CC88D1D795C0")]
	[RecRoom.DataLayer.StableTypeHash(5298506180484533559uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5298506180484533559uL)]
	public struct SplinePointOrderData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FractionalIndex order;

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static implicit operator SplinePointOrderData(FractionalIndex value)
		{
			return default(SplinePointOrderData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FCEE3BCD-9C10-4BF4-954A-0DCFE8810227")]
	[RecRoom.DataLayer.StableTypeHash(16368389834000856208uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(16368389834000856208uL)]
	public struct SplinePointParentData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity spline;
	}
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5A6D38A4-1A58-4EB4-9C1B-06ADA0D44AFA")]
	[RecRoom.DataLayer.StableTypeHash(18095612727592564636uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18095612727592564636uL)]
	public struct SplinePointPositionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;
	}
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("433F66B6-CC1C-4A8A-BF73-2B797440A8DB")]
	[RecRoom.DataLayer.StableTypeHash(1429513518619209486uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1429513518619209486uL)]
	public struct SplinePointRotationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0, 0, 0, 1f)")]
		public quaternion localRotation;
	}
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("04CA3CCE-F121-4B5B-BC56-FE8E9C77F0F4")]
	[RecRoom.DataLayer.StableTypeHash(1238044349990854547uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1238044349990854547uL)]
	public struct SplinePointScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("E0610986-0F8F-494A-8C6E-8A2D2491B088")]
	[RecRoom.DataLayer.StableTypeHash(4657247877648983868uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(4657247877648983868uL)]
	public struct SplineShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public SplineParameters parameters;
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("73C344D9-D535-4753-9D9A-B6DEDE4079B0")]
	[RecRoom.DataLayer.StableTypeHash(12332323170023439017uL, 0u)]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 1 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12332323170023439017uL)]
	public struct OMShapeContainerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(true)]
		public bool canModifyWithCircuits;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(true)]
		public bool optimizedCollidersEnabled;
	}
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("2B5C4208-9113-4F65-B3A6-18EAE1FF3937")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17673274643717888315uL)]
	public struct SerializedDataLayerVersionData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public int version;
	}
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("530E7647-9756-405B-8F83-554B2251FEA9")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2300229493044241130uL)]
	public struct TerrainGenerationData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(0u)]
		public uint Seed;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(1f)]
		public float BaseTerrainHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(1f)]
		public float BaseTerrainFeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public TerrainPlayAreaShape PlayAreaShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[RecRoom.DataLayer.Field(5)]
		[RecRoom.DataLayer.Default]
		public TerrainLayerRoughness BaseTerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[RecRoom.DataLayer.Field(6)]
		[RecRoom.DataLayer.Default]
		public TerrainLayerHeightFunction BaseTerrainHeightFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[RecRoom.DataLayer.Field(7)]
		[RecRoom.DataLayer.Default(0.75f)]
		public float PlayAreaOpacity;
	}
	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("207C2E2E-B1B0-4A2B-8A14-9651A907CBC6")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2736085529679546037uL)]
	public struct TerrainLayerBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public TerrainGenerationLayer layer;
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("557221B3-5BED-456A-8B42-A8D934D18103")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17384573708384647569uL)]
	public struct TerrainMaterialLayerBuffer : IBufferElementData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public TerrainCustomMaterialLayer layer;
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	[RecRoom.DataLayer.NetworkComponent(3, false)]
	[RecRoom.DataLayer.RRGuid("6BA5DFA9-9617-4782-A765-0DD5898267E0")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(15803773606093998129uL)]
	public struct TerrainWaterData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(-1)]
		public float waterHeight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(0.25f)]
		public float waterChop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default(0.25f)]
		public float waterAlpha;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default(RenderableColor.Invalid)]
		public RenderableColor waterColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		[RecRoom.DataLayer.Field(5)]
		[RecRoom.DataLayer.Default(RenderableColor.Invalid)]
		public RenderableColor deepColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		[RecRoom.DataLayer.Field(6)]
		[RecRoom.DataLayer.Default(1)]
		public float emissiveStrength;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		[RecRoom.DataLayer.Field(7)]
		[RecRoom.DataLayer.Default(TerrainWaterMaterial.Generic)]
		public TerrainWaterMaterial waterMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		[RecRoom.DataLayer.Field(8)]
		[RecRoom.DataLayer.Default(WaterOverrides.None)]
		public WaterOverrides overrides;
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("ABD4C098-3F5F-4A65-A22B-6A381A859646")]
	[Flags]
	[RecRoom.DataLayer.Range(WaterOverrides.None, WaterOverrides.All)]
	public enum WaterOverrides : byte
	{
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		Chop = 1,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		Alpha = 2,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Color = 4,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		DeepColor = 8,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		EmissiveStrength = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		All = 0x1F
	}
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("CC657074-87FD-47F7-A7B0-F5CCE922A9D0")]
	[RecRoom.DataLayer.Range(ToolCleanupFlags.MIN, ToolCleanupFlags.ALL)]
	[Flags]
	public enum ToolCleanupFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		IsAllowed = 1,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		UseDefaultVisualEffects = 2,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		DEFAULT = 2,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		ALL = 3,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		MAX = 3
	}
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("34BA53CB-16FB-45DB-AA25-293CE7C8DAE4")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5328722791392374178uL)]
	public struct ToolCleanupSettingsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(15f)]
		public float delay;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(ToolCleanupFlags.UseDefaultVisualEffects)]
		public ToolCleanupFlags toolCleanupFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("48C72ABE-383D-45C6-9610-773F2B4F84C6")]
	[RecRoom.DataLayer.TombstonedFields(new int[] { 2, 3 })]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(13768238190614302474uL)]
	public struct ToolCleanupStatusData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public float cleanupStartTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		public ToolCleanupStatusFlags statusFlags;
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("E63050BA-D087-4027-99F8-4AFDEA229CD8")]
	[RecRoom.DataLayer.Range(ToolCleanupStatusFlags.None, ToolCleanupStatusFlags.ALL)]
	[Flags]
	public enum ToolCleanupStatusFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		ForceCleanup = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		CleanupDone = 2,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		CleanupPaused = 4,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		ALL = 7,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		MAX = 7
	}
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("021E8703-AAFD-4965-8C38-FF86663126D2")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(463077377357487319uL)]
	public struct LocalDeformableScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new float3(1)")]
		public float3 localDeformationScale;

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x2E08DF0", Offset = "0x2E077F0", VA = "0x182E08DF0")]
		public LocalDeformableScaleData(float3 scale)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("38AA9F1D-FD16-4B56-917C-3341D0EB1DF2")]
	[RecRoom.DataLayer.StableTypeHash(1369925932270831712uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1369925932270831712uL)]
	public struct LocalPoseData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default("new quaternion(0,0,0,1)")]
		public quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public float3 localPosition;

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x68B1940", Offset = "0x68B0340", VA = "0x1868B1940")]
		public LocalPoseData(quaternion localRotation, float3 localPosition)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x995F840", Offset = "0x995E240", VA = "0x18995F840")]
		public static implicit operator RigidTransform(LocalPoseData poseData)
		{
			return default(RigidTransform);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x995F840", Offset = "0x995E240", VA = "0x18995F840")]
		public static implicit operator LocalPoseData(RigidTransform pose)
		{
			return default(LocalPoseData);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public static class HCOPZEQDEOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x9960BB0", Offset = "0x995F5B0", VA = "0x189960BB0")]
		public static LocalPoseData ONTNTZZLNDB([In] this RigidTransform value)
		{
			return default(LocalPoseData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x9960B80", Offset = "0x995F580", VA = "0x189960B80")]
		public static RigidTransform GVHDUNBCCLK([In] this LocalPoseData value)
		{
			return default(RigidTransform);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("0E9FADE9-751A-4A53-B455-4F8EA675754D")]
	[RecRoom.DataLayer.StableTypeHash(2720902521635056246uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2720902521635056246uL)]
	public struct LocalUniformScaleData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default(1f)]
		public float localUniformScale;
	}
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("F01774C0-98E7-491E-AAA5-85B64AFFA182")]
	[RecRoom.DataLayer.StableTypeHash(5730545663584378555uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(5730545663584378555uL)]
	public struct TransformFlagsData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public TransformHint transformHint;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public TransformPriority transformPriority;
	}
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[RecRoom.DataLayer.NetworkComponent(3, false)]
	[RecRoom.DataLayer.RRGuid("392BF0C9-F464-491A-8725-E4B5E5C4ECD4")]
	[RecRoom.DataLayer.DoNotGenerateComponentProperties]
	[Obfuscation(Exclude = true)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12583993171946896369uL)]
	public struct RRObjectPrefabData : ISharedComponentData, IEquatable<RRObjectPrefabData>, IComparable<RRObjectPrefabData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ObjectPrefabType prefabType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		public Guid prefabGuid;

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x9962050", Offset = "0x9960A50", VA = "0x189962050")]
		public RRObjectPrefabData(Guid prefabGuid, ObjectPrefabType prefabType)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x9961F50", Offset = "0x9960950", VA = "0x189961F50", Slot = "4")]
		public readonly bool Equals(RRObjectPrefabData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x9961E90", Offset = "0x9960890", VA = "0x189961E90", Slot = "0")]
		public override readonly bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x9962060", Offset = "0x9960A60", VA = "0x189962060")]
		public static bool operator ==(RRObjectPrefabData a, RRObjectPrefabData b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x9961890", Offset = "0x9960290", VA = "0x189961890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x99616A0", Offset = "0x99600A0", VA = "0x1899616A0", Slot = "5")]
		public readonly int CompareTo(RRObjectPrefabData other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x9961FB0", Offset = "0x99609B0", VA = "0x189961FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x9961F50", Offset = "0x9960950", VA = "0x189961F50")]
		[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
		[UnityEngine.Scripting.Preserve]
		public unsafe static bool __codegen__Equals(void* self, void* P_1)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x9961890", Offset = "0x9960290", VA = "0x189961890")]
		[Unity.Entities.MonoPInvokeCallback(typeof(SystemBaseDelegates.Function))]
		[UnityEngine.Scripting.Preserve]
		public unsafe static int __codegen__GetHashCode(void* self)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000079")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("FF90B503-A0B5-4B3D-BACF-046FA1456FBD")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17550159503907726442uL)]
	public struct ReferenceGroupKindData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public ReferenceGroupKind kind;
	}
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("2C78EEBE-6DD9-44FF-A70D-6C2EE9BB8FB3")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(18363292822319307914uL)]
	public struct ReferenceGroupOwnerData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity owner;
	}
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("177498E9-83A6-4C2E-A8C1-B1951B47E74D")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(11947588904347318594uL)]
	public struct ReferenceGroupReferenceBuffer : IBufferElementData, QCDBQGRLTCB, IEquatable<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity reference;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public Entity SNGRHQFBRFP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x9962170", Offset = "0x9960B70", VA = "0x189962170", Slot = "6")]
		public bool Equals(ReferenceGroupReferenceBuffer other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x99620E0", Offset = "0x9960AE0", VA = "0x1899620E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0xF8BD10", Offset = "0xF8A710", VA = "0x180F8BD10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	public struct ReferenceGroupReferenceBufferDataEqualityComparer : IEqualityComparer<ReferenceGroupReferenceBuffer>
	{
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public static ReferenceGroupReferenceBufferDataEqualityComparer Default;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x99620C0", Offset = "0x9960AC0", VA = "0x1899620C0", Slot = "4")]
		public bool Equals(ReferenceGroupReferenceBuffer x, ReferenceGroupReferenceBuffer y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xD76900", Offset = "0xD75300", VA = "0x180D76900", Slot = "5")]
		public int GetHashCode(ReferenceGroupReferenceBuffer obj)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007D")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("DE12A401-BD29-4B00-A629-7EFBECEDCFDF")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(17466046755328781668uL)]
	public struct AuthoredUserTagReferenceBuffer : YRGNUVNSVGK, IBufferElementData, QCDBQGRLTCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private Entity UYWDSBCMMOS
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80")]
		public AuthoredUserTagReferenceBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static implicit operator AuthoredUserTagReferenceBuffer(Entity entity)
		{
			return default(AuthoredUserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200007E")]
	public interface YRGNUVNSVGK : IBufferElementData, QCDBQGRLTCB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200007F")]
	[RecRoom.DataLayer.NetworkComponent(2, false)]
	[RecRoom.DataLayer.RRGuid("00B7CB5E-4C0C-4D2C-AC95-78529EE58768")]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(12148147190301245780uL)]
	public struct PersistentUserTagData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedList32BytesLegacy<int> tags;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default(false)]
		public bool initalizedDefaults;
	}
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("80D85A55-B2F6-4860-A851-62973DC10940")]
	[RecRoom.DataLayer.StableTypeHash(1859693175312uL, 0u)]
	[SwatchPrimaryKey]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1859693175312uL)]
	public struct UserTagNameData : IComponentData, IEquatable<UserTagNameData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public FixedString32Bytes Value;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9962310", Offset = "0x9960D10", VA = "0x189962310")]
		public UserTagNameData(string value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9962340", Offset = "0x9960D40", VA = "0x189962340")]
		public static implicit operator UserTagNameData(string value)
		{
			return default(UserTagNameData);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9962230", Offset = "0x9960C30", VA = "0x189962230", Slot = "4")]
		public bool Equals(UserTagNameData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9962260", Offset = "0x9960C60", VA = "0x189962260", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x9962300", Offset = "0x9960D00", VA = "0x189962300", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000081")]
	[InternalBufferCapacity(0)]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("1E609F72-38C4-433D-BB17-B718F89DF446")]
	[RuntimeOnly]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(2039749658960193818uL)]
	public struct UserTagReferenceBuffer : YRGNUVNSVGK, IBufferElementData, QCDBQGRLTCB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public Entity Child;

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private Entity UYWDSBCMMOS
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xEF9560", Offset = "0xEF7F60", VA = "0x180EF9560", Slot = "4")]
			get
			{
				return default(Entity);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x1425C80", Offset = "0x1424680", VA = "0x181425C80")]
		public UserTagReferenceBuffer(Entity entity)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xE354B0", Offset = "0xE33EB0", VA = "0x180E354B0")]
		public static implicit operator UserTagReferenceBuffer(Entity entity)
		{
			return default(UserTagReferenceBuffer);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000082")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("C36DDF08-CA52-4E33-8078-2F6E915D4FDA")]
	[RecRoom.DataLayer.StableTypeHash(1591066774816564574uL, 0u)]
	[ConfigGroup("Visual", 0)]
	[CanDesync]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(1591066774816564574uL)]
	public struct StandardRenderableVisualData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public RenderableColor color;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public RenderableMaterial material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[RecRoom.DataLayer.Field(3)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public float uvScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[RecRoom.DataLayer.Field(4)]
		[RecRoom.DataLayer.Default]
		[Config(null, 0)]
		public float3 uvOffset;
	}
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("8D4C776C-B7A8-44BD-9901-159E4D1928F9")]
	[RecRoom.DataLayer.Range(0, 255)]
	public enum AccountRoleTypeNetworked : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		Banned = 1,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		Host = 10,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		Moderator = 20,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		Contributor = 25,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		CoOwner = 30,
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		TemporaryCoOwner = 31,
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		Creator = 255
	}
	[Cpp2IlInjected.Token(Token = "0x2000084")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("6B598497-D68A-4CC9-9D41-09EF6B966499")]
	[RecRoom.DataLayer.Range(CircuitsTransformBehavior.NONE, CircuitsTransformBehavior.COUNT)]
	public enum CircuitsTransformBehavior
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[Config("Default (can transform roots, children are static)", 0)]
		Default = 1,
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[Config("Can Transform (chips like SetPosition can modify)", 0)]
		CircuitsCanTransform = 2,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		[Config("Always Static (chips cannot modify transform)", 0)]
		AlwaysStatic = 3,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		COUNT = 4,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		MAX = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000085")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("17517E1A-CF1A-48C9-B6A5-F9E42C1B9E96")]
	[RecRoom.DataLayer.Range(0, 4)]
	public enum ColliderType
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Box = 1,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Sphere = 2,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Capsule = 3,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		Mesh = 4,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		COUNT = 5,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		MAX = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000086")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("A13F5102-9259-42B9-B782-BB7CC33A0C4F")]
	[RecRoom.DataLayer.Range(CollidesWith.NONE, CollidesWith.ALL)]
	[Flags]
	public enum CollidesWith
	{
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Object = 1,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Player = 2,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Projectile = 4,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Vehicle = 8,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		ALL = 0xF
	}
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	[RecRoom.DataLayer.NetworkEnum(2, false)]
	[RecRoom.DataLayer.RRGuid("F843A776-E042-43B7-8167-0C7A421062F8")]
	[RecRoom.DataLayer.Range(0, 127)]
	public enum CollisionLayerEnum : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[Config("Dynamic (Environment)", 0)]
		[@Tooltip("Indicating it can be walked on and moved")]
		IsDynamicEnvironment = 0,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		[Config("Dynamic", -1)]
		IsDynamic = 10,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		[Config("Dynamic (Ignore Static Geometry)", 0)]
		IsDynamicIgnoreStaticGeometry = 11,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		[Config("Dynamic (Ignore Other Dynamic)", 0)]
		IsDynamicIgnoreOtherDynamic = 12,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		[Config("Dynamic (Ignore Players)", 0)]
		IsDynamicIgnorePlayers = 13,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		[Config("Dynamic (Ignore Most)", 0)]
		IsDynamicIgnoreMost = 14,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[Config("Enemy Collision", 0)]
		IsEnemyCollision = 30,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[Config("Enemy Projectile", 0)]
		IsEnemyProjectile = 31,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		[Config("Vehicle Physics", 0)]
		IsVehicleCollision = 40,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[ConfigIgnore]
		STATIC = 100,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		[ConfigIgnore]
		DECORATION = 101,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		MAX = 127
	}
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	[RecRoom.DataLayer.NetworkEnum(2, false)]
	[RecRoom.DataLayer.RRGuid("9ADF7A0D-D808-48A7-BFCB-3272FB5D8A52")]
	[RecRoom.DataLayer.Range(CollisionMode.Off, CollisionMode.COUNT)]
	public enum CollisionMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		Off = 0,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		Children = 1,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Hull = 2,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		COUNT = 3,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		MAX = 2
	}
	[Cpp2IlInjected.Token(Token = "0x2000089")]
	[Flags]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("0E5141AE-23E1-45A5-8BB0-04CC01E925E2")]
	[RecRoom.DataLayer.Range(ElementSnapPointRuntimeFlags.None, ElementSnapPointRuntimeFlags.SnapLocked)]
	public enum ElementSnapPointRuntimeFlags : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		SnapLocked = 1,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		All = 1,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Default = 0
	}
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("3B156405-5769-4DB2-87EA-2B846AC4E584")]
	[RecRoom.DataLayer.Range(0, 2)]
	public enum EShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		Primitive = 1,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Spline = 2,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		COUNT = 3,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		MAX = 2
	}
	[Cpp2IlInjected.Token(Token = "0x200008B")]
	[RecRoom.DataLayer.NetworkEnum(2, false)]
	[RecRoom.DataLayer.RRGuid("61EFE94A-235A-4281-B938-1A5BE32A18B1")]
	[RecRoom.DataLayer.Range(GrabbableMode.Pivot, GrabbableMode.COUNT)]
	public enum GrabbableMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Pivot = 0,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Bounds = 1,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		MAX = 1
	}
	[Cpp2IlInjected.Token(Token = "0x200008C")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("95D8649F-566A-409B-8090-61DA57EE41CC")]
	[RecRoom.DataLayer.Range(HeightMapBiomeType.Canyon, HeightMapBiomeType.Random)]
	public enum HeightMapBiomeType
	{
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Canyon,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Moon,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Bowl,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Hills,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Island,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		Desert,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		Random
	}
	[Cpp2IlInjected.Token(Token = "0x200008D")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("c0973732-e735-44cd-9727-a9a79bad01e3")]
	[RecRoom.DataLayer.Range(InteractionFilterMode.EnabledForRole, InteractionFilterMode.Disabled)]
	public enum InteractionFilterMode : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		EnabledForRole,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		DisabledForRole,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Disabled
	}
	[Cpp2IlInjected.Token(Token = "0x200008E")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("7E7D5AA1-2EC9-488B-8AB2-703F13BCB8CF")]
	[RecRoom.DataLayer.Range(NavMeshGenerationMode.NavMeshGenerator, NavMeshGenerationMode.NavMeshBlocker)]
	public enum NavMeshGenerationMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		NavMeshGenerator = 0,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		NavMeshIgnored = 1,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		NavMeshBlocker = 2,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		MAX = 2
	}
	[Cpp2IlInjected.Token(Token = "0x200008F")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("7B493897-FE06-4FC8-AB72-8B7BF5A313D3")]
	[RecRoom.DataLayer.Range(ObjectPolicyEnumFlags.None, ObjectPolicyEnumFlags.All)]
	[Flags]
	public enum ObjectPolicyEnumFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		All = 0x3FFF,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		Default = 0x3FFF
	}
	[Cpp2IlInjected.Token(Token = "0x2000090")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("4427686F-E636-4F43-91F7-6BC74DEC584E")]
	[RecRoom.DataLayer.Range(0, ObjectPolicyEnum.COUNT)]
	public enum ObjectPolicyEnum
	{
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		SupportsRotation,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		SupportsDeformation,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		SupportsScaling,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		SupportsMirroring,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		SupportsCloning,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		SupportsRecoloring,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		CanDestroy,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		CanSaveIntoInventions,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		SupportsRespawn,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		SupportsMerging,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		SupportsSplitting,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		SupportsKeys,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		CanEditWithMakerPen,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		DEPRECATED_IsGrabbable,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		COUNT
	}
	[Cpp2IlInjected.Token(Token = "0x2000091")]
	public static class VPMFOXMOWMZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x99623A0", Offset = "0x9960DA0", VA = "0x1899623A0")]
		public static void Set(this ObjectPolicyEnumFlags flags, ObjectPolicyEnum setting, bool enable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x9962380", Offset = "0x9960D80", VA = "0x189962380")]
		public static bool Has(this ObjectPolicyEnumFlags flags, ObjectPolicyEnum setting)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0xF89040", Offset = "0xF87A40", VA = "0x180F89040")]
		public static ObjectPolicyEnumFlags OTHVOHSASMU(this ObjectPolicyEnum a)
		{
			return default(ObjectPolicyEnumFlags);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	[RecRoom.DataLayer.NetworkEnum(2, false)]
	[RecRoom.DataLayer.RRGuid("E3C51303-32F0-4EF4-8A66-C814E323653D")]
	[RecRoom.DataLayer.Range(ObjectPolicyUserConfigurableFlags.NONE, ObjectPolicyUserConfigurableFlags.COUNT)]
	[Flags]
	public enum ObjectPolicyUserConfigurableFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		IsFrozen = 1,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		IsGrabbable = 2,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		PickUpDefaultToPlaceIfPhysical = 4,
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		COUNT = 5,
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		ALL = 5,
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		DEFAULT = 0
	}
	[Cpp2IlInjected.Token(Token = "0x2000093")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("777AD204-3AC0-41CE-BDC0-894C5821B3B9")]
	[RecRoom.DataLayer.Range(ObjectPrefabType.None, 8000)]
	public enum ObjectPrefabType
	{
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[Config("Container", 0)]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[Config("Container", 0)]
		LegacyShapeContainer = 1001,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[Config("Container", 0)]
		CreationShapeContainer = 1002,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[Config("Empty", 0)]
		Empty = 4000,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[Config("Legacy Box", 0)]
		Shape_Primitive_LegacyBox = 2000,
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		[Config("Sphere", 0)]
		Shape_Primitive_Sphere = 2001,
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		[Config("Cylinder", 0)]
		Shape_Primitive_Cylinder = 2002,
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		[Config("Legacy Wedge", 0)]
		Shape_Primitive_LegacyWedge = 2003,
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		[Config("Legacy Pyramid", 0)]
		Shape_Primitive_LegacyPyramid = 2004,
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		[Config("Trigger Volume Box", 0)]
		Shape_Primitive_TriggerVolumeBox = 2005,
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		[Config("Box", 0)]
		Shape_Primitive_Box = 2006,
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[Config("Rounded Box", 0)]
		Shape_Primitive_RoundedBox = 2007,
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[Config("Wedge", 0)]
		Shape_Primitive_Wedge = 2008,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[Config("Pyramid", 0)]
		Shape_Primitive_Pyramid = 2009,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[Config("Half Sphere", 0)]
		Shape_Primitive_HalfSphere = 2010,
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		[Config("Cone", 0)]
		Shape_Primitive_Cone = 2011,
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		[Config("Pipe", 0)]
		Shape_Primitive_Pipe = 2012,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		[Config("Donut", 0)]
		Shape_Primitive_Donut = 2013,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		[Config("Half Pipe", 0)]
		Shape_Primitive_HalfPipe = 2014,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		[Config("Diamond", 0)]
		Shape_Primitive_Diamond = 2015,
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		[Config("Mound", 0)]
		Shape_Primitive_Mound = 2016,
		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		[Config("Cube (Simple)", 0)]
		Shape_Primitive_ADVANCED_Cube = 2017,
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[Config("Sphere (Simple)", 0)]
		Shape_Primitive_ADVANCED_Sphere = 2018,
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[Config("Cylinder (Simple)", 0)]
		Shape_Primitive_ADVANCED_Cylinder = 2019,
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		[Config("Cone (Simple)", 0)]
		Shape_Primitive_ADVANCED_Cone = 2020,
		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		[Config("Pyramid (Simple)", 0)]
		Shape_Primitive_ADVANCED_Pyramid = 2021,
		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		[Config("Octagon (Simple)", 0)]
		Shape_Primitive_ADVANCED_Octagon = 2022,
		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		[Config("Triangle (Simple)", 0)]
		Shape_Primitive_ADVANCED_Triangle = 2023,
		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		[Config("Hexagon (Simple)", 0)]
		Shape_Primitive_ADVANCED_Hexagon = 2024,
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[Config("Quarter Pipe", 0)]
		Shape_Primitive_ADVANCED_QuarterPipe = 2025,
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[Config("Pentagon (Simple)", 0)]
		Shape_Primitive_ADVANCED_Pentagon = 2026,
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		[Config("Dodecahedron", 0)]
		Shape_Primitive_ADVANCED_Dodecahedron = 2027,
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		[Config("Icosahedron", 0)]
		Shape_Primitive_ADVANCED_Trihedron = 2028,
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		[Config("Octahedron", 0)]
		Shape_Primitive_ADVANCED_Octahedron = 2029,
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		[Config("Quarter Cylinder", 0)]
		Shape_Primitive_RR_QuarterCylinder = 2030,
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		[Config("Pentagon", 0)]
		Shape_Primitive_RR_Pentagon = 2031,
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		[Config("Quarter Sphere", 0)]
		Shape_Primitive_RR_QuarterSphere = 2032,
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		[Config("Wedge (Simple)", 0)]
		Shape_Primitive_ADVANCED_Wedge = 2033,
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		[Config("Hexagon", 0)]
		Shape_Primitive_RR_Hexagon = 2034,
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		[Config("Octagon", 0)]
		Shape_Primitive_RR_Octagon = 2035,
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		[Config("Triangle", 0)]
		Shape_Primitive_RR_Triangle = 2036,
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		[Config("Spline", 0)]
		Shape_Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		[Config("Container Pivot", 0)]
		Other_ContainerPivot = 6000,
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		[Config("Spine Point", 0)]
		Other_SplinePoint = 6001,
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		[Config("Reference Point", 0)]
		Other_ReferencePoint = 6002,
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		[Config("UserTags", 0)]
		Other_UserTag = 6003,
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		[Config("Reference Group", 0)]
		Other_ReferenceGroup = 6004,
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[Config("Interaction Filter", 0)]
		Other_InteractionFilterTags = 6005,
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[ConfigIgnore]
		Other_DesyncNetworkObject = 6006,
		[Cpp2IlInjected.Token(Token = "0x40001BC")]
		[ConfigIgnore]
		NativeObject_SnapPoint = 5000,
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		[Config("Object", 0)]
		PrefabRootGameObject = 7000,
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		[Config("PrefabInternal", 0)]
		PrefabInternalGameObject = 7001,
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		[Config("Player", 0)]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	public static class HFFUJQSLHZK
	{
		[Cpp2IlInjected.Token(Token = "0x2000095")]
		[CompilerGenerated]
		private sealed class WXTMQGHKLDA : IEnumerable<ObjectPrefabType>, IEnumerable, IEnumerator<ObjectPrefabType>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C0")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C1")]
			private ObjectPrefabType RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C2")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			private IEnumerator<ObjectPrefabType> IRFNBWFCZWO;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private ObjectPrefabType YGBRCAVNWWW
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ObjectPrefabType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000D4")]
				[Cpp2IlInjected.Address(RVA = "0x99627B0", Offset = "0x99611B0", VA = "0x1899627B0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0x15E64E0", Offset = "0x15E4EE0", VA = "0x1815E64E0")]
			[DebuggerHidden]
			public WXTMQGHKLDA(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x99623D0", Offset = "0x9960DD0", VA = "0x1899623D0", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0x99624A0", Offset = "0x9960EA0", VA = "0x1899624A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x9962800", Offset = "0x9961200", VA = "0x189962800")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x9962460", Offset = "0x9960E60", VA = "0x189962460", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x9962720", Offset = "0x9961120", VA = "0x189962720", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ObjectPrefabType> NQYWXDTZCTH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x9962720", Offset = "0x9961120", VA = "0x189962720", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000096")]
		[CompilerGenerated]
		private sealed class XNTLXFMFEYF : IEnumerable<ObjectPrefabType>, IEnumerable, IEnumerator<ObjectPrefabType>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			private ObjectPrefabType RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C7")]
			private IEnumerator IRFNBWFCZWO;

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private ObjectPrefabType YGBRCAVNWWW
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ObjectPrefabType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0x9962CF0", Offset = "0x99616F0", VA = "0x189962CF0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x15E64E0", Offset = "0x15E4EE0", VA = "0x1815E64E0")]
			[DebuggerHidden]
			public XNTLXFMFEYF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x9962960", Offset = "0x9961360", VA = "0x189962960", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x9962A00", Offset = "0x9961400", VA = "0x189962A00", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x9962D40", Offset = "0x9961740", VA = "0x189962D40")]
			private void XNJKRYGWMCP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x99629C0", Offset = "0x99613C0", VA = "0x1899629C0", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x9962C60", Offset = "0x9961660", VA = "0x189962C60", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ObjectPrefabType> NQYWXDTZCTH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x9962C60", Offset = "0x9961660", VA = "0x189962C60", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000097")]
		[CompilerGenerated]
		private sealed class QWNHQEDLDYN : IEnumerable<ObjectPrefabType>, IEnumerable, IEnumerator<ObjectPrefabType>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40001C8")]
			private int EQRCVSNPEJY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40001C9")]
			private ObjectPrefabType RIDNXCOLQWN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40001CA")]
			private int QBMVXUNSGXZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40001CB")]
			private ObjectPrefabType ORZANQTLNKB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001CC")]
			private ObjectPrefabType XBVIABZLQWX;

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private ObjectPrefabType YGBRCAVNWWW
			{
				[Cpp2IlInjected.Token(Token = "0x60000E3")]
				[Cpp2IlInjected.Address(RVA = "0xDF7E10", Offset = "0xDF6810", VA = "0x180DF7E10", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default(ObjectPrefabType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private object IFKDFAMTOCU
			{
				[Cpp2IlInjected.Token(Token = "0x60000E5")]
				[Cpp2IlInjected.Address(RVA = "0x9961E40", Offset = "0x9960840", VA = "0x189961E40", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x15E64E0", Offset = "0x15E4EE0", VA = "0x1815E64E0")]
			[DebuggerHidden]
			public QWNHQEDLDYN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
			[DebuggerHidden]
			private void GWJQUAHXPBV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x9961D50", Offset = "0x9960750", VA = "0x189961D50", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x9961D10", Offset = "0x9960710", VA = "0x189961D10", Slot = "10")]
			[DebuggerHidden]
			private void JNSYTSSCILY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x9961DB0", Offset = "0x99607B0", VA = "0x189961DB0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<ObjectPrefabType> NQYWXDTZCTH()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9961DB0", Offset = "0x99607B0", VA = "0x189961DB0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator XDTPACFLBGX()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x9960C40", Offset = "0x995F640", VA = "0x189960C40")]
		[IteratorStateMachine(typeof(XNTLXFMFEYF))]
		public static IEnumerable<ObjectPrefabType> SSXODTSRBAQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x9960CA0", Offset = "0x995F6A0", VA = "0x189960CA0")]
		[IteratorStateMachine(typeof(QWNHQEDLDYN))]
		public static IEnumerable<ObjectPrefabType> XSPVCWZASCH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x9960BE0", Offset = "0x995F5E0", VA = "0x189960BE0")]
		[IteratorStateMachine(typeof(WXTMQGHKLDA))]
		public static IEnumerable<ObjectPrefabType> KMYNLJNXLMJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000098")]
	public static class XFRGAYEKCBT
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x99628B0", Offset = "0x99612B0", VA = "0x1899628B0")]
		public static bool HEHAXBXQBSF(this RRObjectPrefabData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x9962880", Offset = "0x9961280", VA = "0x189962880")]
		public static bool HEHAXBXQBSF(this ObjectPrefabType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x9962930", Offset = "0x9961330", VA = "0x189962930")]
		public static bool ZXIUHOHKPEF(this RRObjectPrefabData a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x9962900", Offset = "0x9961300", VA = "0x189962900")]
		public static bool ZXIUHOHKPEF(this ObjectPrefabType a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x99628E0", Offset = "0x99612E0", VA = "0x1899628E0")]
		public static ObjectType KSUBKOAWOMZ(this ObjectPrefabType a)
		{
			return default(ObjectType);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x9962850", Offset = "0x9961250", VA = "0x189962850")]
		internal static ObjectPrefabTypeCategory EHORPLSJQCZ(this ObjectType a)
		{
			return default(ObjectPrefabTypeCategory);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x9962860", Offset = "0x9961260", VA = "0x189962860")]
		internal static ObjectPrefabTypeCategory EHORPLSJQCZ(this ObjectPrefabType a)
		{
			return default(ObjectPrefabTypeCategory);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	internal enum ObjectPrefabTypeCategory
	{
		[Cpp2IlInjected.Token(Token = "0x40001CE")]
		Container = 1000,
		[Cpp2IlInjected.Token(Token = "0x40001CF")]
		Empty = 4000,
		[Cpp2IlInjected.Token(Token = "0x40001D0")]
		Primitive = 2000,
		[Cpp2IlInjected.Token(Token = "0x40001D1")]
		Spline = 3000,
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		Other = 6000,
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		NativeObject = 5000,
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		GameObject = 7000,
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		Player = 8000
	}
	[Cpp2IlInjected.Token(Token = "0x200009A")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("A32413BC-21F3-4F7C-84B0-37724A854A67")]
	[RecRoom.DataLayer.Range(0, 8)]
	public enum ObjectType
	{
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		Container,
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		Primitive,
		[Cpp2IlInjected.Token(Token = "0x40001DA")]
		Spline,
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		NativeObject,
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		Other,
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		GameObject,
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		Player
	}
	[Cpp2IlInjected.Token(Token = "0x200009B")]
	public static class SJLUNUUQOBZ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x9962180", Offset = "0x9960B80", VA = "0x189962180")]
		public static bool QAVSEFNDCTB(this ObjectType a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200009C")]
	[RecRoom.DataLayer.NetworkEnum(3, false)]
	[RecRoom.DataLayer.RRGuid("7A0D34B5-FFE5-4C21-BB0C-CB3EBA34C797")]
	[RecRoom.DataLayer.Range(0, PhysicsModelEnumFlags.ALL)]
	[Flags]
	public enum PhysicsModelEnumFlags : ushort
	{
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		NONE = 0,
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		PhysicsEnabled = 1,
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		GravityEnabled = 2,
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		HasCustomMass = 4,
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		CollisionEvent = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		CanUse = 0x200,
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		CanClimb = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		CanWallRun = 0x800,
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		CanClamber = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		CanTeleport = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		SuppressCollision = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		DEFAULT = 0x3800,
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		ALL = 0x7E47,
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		MAX = 0x7E47
	}
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	[RecRoom.DataLayer.NetworkComponent(1, false)]
	[RecRoom.DataLayer.RRGuid("5D4503E7-6CC4-4938-8840-1B859C391878")]
	[RecRoom.DataLayer.StableTypeHash(8060729269509364919uL, 0u)]
	[CompilerGenerated]
	[TypeManager.ForcedStableTypeHash(8060729269509364919uL)]
	public struct PrimitiveShapeData : IComponentData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		public PrimitiveShapeType shapeType;
	}
	[Cpp2IlInjected.Token(Token = "0x200009E")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("517224CC-0A79-4FE9-B048-53C37955D823")]
	[RecRoom.DataLayer.Range(-1, 38)]
	public enum PrimitiveShapeType
	{
		[Cpp2IlInjected.Token(Token = "0x40001F2")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40001F3")]
		LegacyBox = 2,
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		RR_Sphere = 3,
		[Cpp2IlInjected.Token(Token = "0x40001F5")]
		RR_Cylinder = 4,
		[Cpp2IlInjected.Token(Token = "0x40001F6")]
		LEGACY_Wedge = 5,
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		LEGACY_Pyramid = 6,
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		LEGACY_TriggerVolumeBox = 7,
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		RR_Box = 8,
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		LEGACY_RoundedBox = 9,
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		RR_Wedge = 10,
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		RR_Pyramid = 11,
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		RR_HalfSphere = 12,
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		RR_Cone = 13,
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		RR_Pipe = 14,
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		RR_Donut = 15,
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		RR_HalfPipe = 16,
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		RR_Diamond = 17,
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		ADVANCED_Mound = 18,
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		ADVANCED_Cube = 19,
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		ADVANCED_Sphere = 20,
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		ADVANCED_Cylinder = 21,
		[Cpp2IlInjected.Token(Token = "0x4000207")]
		ADVANCED_Cone = 22,
		[Cpp2IlInjected.Token(Token = "0x4000208")]
		ADVANCED_Pyramid = 23,
		[Cpp2IlInjected.Token(Token = "0x4000209")]
		ADVANCED_Octagon = 24,
		[Cpp2IlInjected.Token(Token = "0x400020A")]
		ADVANCED_Triangle = 25,
		[Cpp2IlInjected.Token(Token = "0x400020B")]
		ADVANCED_Hexagon = 26,
		[Cpp2IlInjected.Token(Token = "0x400020C")]
		ADVANCED_QuarterPipe = 27,
		[Cpp2IlInjected.Token(Token = "0x400020D")]
		ADVANCED_Pentagon = 28,
		[Cpp2IlInjected.Token(Token = "0x400020E")]
		ADVANCED_Dodecahedron = 29,
		[Cpp2IlInjected.Token(Token = "0x400020F")]
		ADVANCED_Trihedron = 30,
		[Cpp2IlInjected.Token(Token = "0x4000210")]
		ADVANCED_Octahedron = 31,
		[Cpp2IlInjected.Token(Token = "0x4000211")]
		RR_QuarterCylinder = 32,
		[Cpp2IlInjected.Token(Token = "0x4000212")]
		RR_Pentagon = 33,
		[Cpp2IlInjected.Token(Token = "0x4000213")]
		RR_QuarterSphere = 34,
		[Cpp2IlInjected.Token(Token = "0x4000214")]
		ADVANCED_Wedge = 35,
		[Cpp2IlInjected.Token(Token = "0x4000215")]
		RR_Hexagon = 36,
		[Cpp2IlInjected.Token(Token = "0x4000216")]
		RR_Octagon = 37,
		[Cpp2IlInjected.Token(Token = "0x4000217")]
		RR_Triangle = 38,
		[Cpp2IlInjected.Token(Token = "0x4000218")]
		COUNT = 39,
		[Cpp2IlInjected.Token(Token = "0x4000219")]
		MIN_VALUE = -1,
		[Cpp2IlInjected.Token(Token = "0x400021A")]
		MAX_VALUE = 38
	}
	[Cpp2IlInjected.Token(Token = "0x200009F")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("3D27DF09-CAE2-4C3F-B808-03AD605F8E98")]
	[RecRoom.DataLayer.Range(ReferenceGroupKind.None, ReferenceGroupKind.COUNT)]
	public enum ReferenceGroupKind : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400021C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400021D")]
		AnimationGroup = 1,
		[Cpp2IlInjected.Token(Token = "0x400021E")]
		COUNT = 2,
		[Cpp2IlInjected.Token(Token = "0x400021F")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000220")]
		MAX = 2
	}
	[Cpp2IlInjected.Token(Token = "0x20000A0")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("1829B7EA-C0EA-4E77-8EB2-BA23E995C860")]
	[RecRoom.DataLayer.Range(0, 7)]
	[Flags]
	public enum ShapeConfigFlags
	{
		[Cpp2IlInjected.Token(Token = "0x4000222")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000223")]
		DynamicUVProjection = 1,
		[Cpp2IlInjected.Token(Token = "0x4000224")]
		PreventInvertedCreation = 2,
		[Cpp2IlInjected.Token(Token = "0x4000225")]
		NewBendLogic = 4,
		[Cpp2IlInjected.Token(Token = "0x4000226")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000227")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000228")]
		MAX = 7
	}
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("CCB58F66-EF02-476E-820F-9D593E2C3DE5")]
	[RecRoom.DataLayer.Range(0, 7)]
	[Flags]
	public enum SplineParameterFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400022A")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400022B")]
		IsRibbon = 1,
		[Cpp2IlInjected.Token(Token = "0x400022C")]
		RoundedTubes = 2,
		[Cpp2IlInjected.Token(Token = "0x400022D")]
		OldStyleCaps = 4,
		[Cpp2IlInjected.Token(Token = "0x400022E")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x400022F")]
		MIN = 0,
		[Cpp2IlInjected.Token(Token = "0x4000230")]
		MAX = 7
	}
	[Cpp2IlInjected.Token(Token = "0x20000A2")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("97516D96-FDF4-4ECC-881B-57A014A7D805")]
	[RecRoom.DataLayer.Range(TerrainColorMode.Default, TerrainColorMode.Count)]
	public enum TerrainColorMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000232")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000233")]
		Import,
		[Cpp2IlInjected.Token(Token = "0x4000234")]
		Generate,
		[Cpp2IlInjected.Token(Token = "0x4000235")]
		Ignore,
		[Cpp2IlInjected.Token(Token = "0x4000236")]
		Count
	}
	[Cpp2IlInjected.Token(Token = "0x20000A3")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("4913AA4C-C771-455C-AF49-938E5DEA653E")]
	[RecRoom.DataLayer.Range(TerrainLayerDistribution.Everywhere, TerrainLayerDistribution.MAX)]
	public enum TerrainLayerDistribution : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000238")]
		Everywhere,
		[Cpp2IlInjected.Token(Token = "0x4000239")]
		Center,
		[Cpp2IlInjected.Token(Token = "0x400023A")]
		Edges,
		[Cpp2IlInjected.Token(Token = "0x400023B")]
		North,
		[Cpp2IlInjected.Token(Token = "0x400023C")]
		South,
		[Cpp2IlInjected.Token(Token = "0x400023D")]
		East,
		[Cpp2IlInjected.Token(Token = "0x400023E")]
		West,
		[Cpp2IlInjected.Token(Token = "0x400023F")]
		RandomLines,
		[Cpp2IlInjected.Token(Token = "0x4000240")]
		RandomBlobs,
		[Cpp2IlInjected.Token(Token = "0x4000241")]
		MAX
	}
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("4AD21D91-EFC4-4DAD-863D-4014EB5AB12D")]
	[RecRoom.DataLayer.Range(TerrainLayerHeightFunction.Normal, TerrainLayerHeightFunction.MAX)]
	public enum TerrainLayerHeightFunction : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000243")]
		Normal,
		[Cpp2IlInjected.Token(Token = "0x4000244")]
		Steep,
		[Cpp2IlInjected.Token(Token = "0x4000245")]
		Mesa,
		[Cpp2IlInjected.Token(Token = "0x4000246")]
		MAX
	}
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("4DAD40E0-53B5-4B82-B53A-BC3E96F9B507")]
	[RecRoom.DataLayer.Range(TerrainLayerRoughness.GentleSlopes, TerrainLayerRoughness.MAX)]
	public enum TerrainLayerRoughness : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000248")]
		GentleSlopes,
		[Cpp2IlInjected.Token(Token = "0x4000249")]
		RuggedSlopes,
		[Cpp2IlInjected.Token(Token = "0x400024A")]
		Flat,
		[Cpp2IlInjected.Token(Token = "0x400024B")]
		MediumSlopes,
		[Cpp2IlInjected.Token(Token = "0x400024C")]
		RiverBed,
		[Cpp2IlInjected.Token(Token = "0x400024D")]
		MAX
	}
	[Cpp2IlInjected.Token(Token = "0x20000A6")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("966E2586-2CE9-4280-898A-894565917A54")]
	[RecRoom.DataLayer.Range(TerrainPlayAreaShape.Circle, TerrainPlayAreaShape.MAX)]
	public enum TerrainPlayAreaShape : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400024F")]
		Circle,
		[Cpp2IlInjected.Token(Token = "0x4000250")]
		Square,
		[Cpp2IlInjected.Token(Token = "0x4000251")]
		MAX
	}
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	[RecRoom.DataLayer.NetworkEnum(2, false)]
	[RecRoom.DataLayer.RRGuid("1B5DCD13-7CE8-459C-9A2B-3DC9135708CD")]
	[RecRoom.DataLayer.Range(TerrainWaterMaterial.Generic, TerrainWaterMaterial.Shoreline)]
	public enum TerrainWaterMaterial : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000253")]
		Generic,
		[Cpp2IlInjected.Token(Token = "0x4000254")]
		Ocean,
		[Cpp2IlInjected.Token(Token = "0x4000255")]
		River,
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		Lava,
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		Oil,
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		Alien,
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		Blood,
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		Radioactive,
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		Slime,
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		Swamp,
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		Shoreline
	}
	[Cpp2IlInjected.Token(Token = "0x20000A8")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("72742F9B-D48E-4CED-B403-444201FFEE66")]
	[RecRoom.DataLayer.Range(0, 1)]
	[Flags]
	public enum TransformHint
	{
		[Cpp2IlInjected.Token(Token = "0x400025F")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		Static = 0,
		[Cpp2IlInjected.Token(Token = "0x4000261")]
		Dynamic = 1,
		[Cpp2IlInjected.Token(Token = "0x4000262")]
		All = 1
	}
	[Cpp2IlInjected.Token(Token = "0x20000A9")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("C5BE1CDA-5EF5-4EBF-BC7E-3E3510C68A7F")]
	[RecRoom.DataLayer.Range(-2, 2)]
	public enum TransformPriority
	{
		[Cpp2IlInjected.Token(Token = "0x4000264")]
		Frozen = -2,
		[Cpp2IlInjected.Token(Token = "0x4000265")]
		Low = -1,
		[Cpp2IlInjected.Token(Token = "0x4000266")]
		Normal = 0,
		[Cpp2IlInjected.Token(Token = "0x4000267")]
		High = 1,
		[Cpp2IlInjected.Token(Token = "0x4000268")]
		Realtime = 2,
		[Cpp2IlInjected.Token(Token = "0x4000269")]
		Default = 0,
		[Cpp2IlInjected.Token(Token = "0x400026A")]
		MIN = -2,
		[Cpp2IlInjected.Token(Token = "0x400026B")]
		MAX = 2
	}
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("D6AFAFED-8BAA-4499-9696-9CBB716EF514")]
	[RecRoom.DataLayer.Range(-2147483648, 2147483647)]
	public enum RenderableColor
	{
		[Cpp2IlInjected.Token(Token = "0x400026D")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x400026E")]
		Red = 0,
		[Cpp2IlInjected.Token(Token = "0x400026F")]
		Orange = 1,
		[Cpp2IlInjected.Token(Token = "0x4000270")]
		Yellow = 2,
		[Cpp2IlInjected.Token(Token = "0x4000271")]
		LightGreen = 3,
		[Cpp2IlInjected.Token(Token = "0x4000272")]
		Blue = 4,
		[Cpp2IlInjected.Token(Token = "0x4000273")]
		LightBlue = 5,
		[Cpp2IlInjected.Token(Token = "0x4000274")]
		Teal = 6,
		[Cpp2IlInjected.Token(Token = "0x4000275")]
		Green = 7,
		[Cpp2IlInjected.Token(Token = "0x4000276")]
		Purple = 8,
		[Cpp2IlInjected.Token(Token = "0x4000277")]
		LightPink = 9,
		[Cpp2IlInjected.Token(Token = "0x4000278")]
		Pink = 10,
		[Cpp2IlInjected.Token(Token = "0x4000279")]
		Brown = 11,
		[Cpp2IlInjected.Token(Token = "0x400027A")]
		Tan = 12,
		[Cpp2IlInjected.Token(Token = "0x400027B")]
		White = 13,
		[Cpp2IlInjected.Token(Token = "0x400027C")]
		Grey = 14,
		[Cpp2IlInjected.Token(Token = "0x400027D")]
		DarkGrey = 15,
		[Cpp2IlInjected.Token(Token = "0x400027E")]
		DarkBrown = 16,
		[Cpp2IlInjected.Token(Token = "0x400027F")]
		LightBrown = 17,
		[Cpp2IlInjected.Token(Token = "0x4000280")]
		LightGrey = 18,
		[Cpp2IlInjected.Token(Token = "0x4000281")]
		Black = 19,
		[Cpp2IlInjected.Token(Token = "0x4000282")]
		DarkRed = 20,
		[Cpp2IlInjected.Token(Token = "0x4000283")]
		DarkOrange = 21,
		[Cpp2IlInjected.Token(Token = "0x4000284")]
		DarkYellow = 22,
		[Cpp2IlInjected.Token(Token = "0x4000285")]
		DarkGreen = 23,
		[Cpp2IlInjected.Token(Token = "0x4000286")]
		DarkTeal = 24,
		[Cpp2IlInjected.Token(Token = "0x4000287")]
		DarkBlue = 25,
		[Cpp2IlInjected.Token(Token = "0x4000288")]
		DarkPurple = 26,
		[Cpp2IlInjected.Token(Token = "0x4000289")]
		DarkPink = 27,
		[Cpp2IlInjected.Token(Token = "0x400028A")]
		LightRed = 28,
		[Cpp2IlInjected.Token(Token = "0x400028B")]
		LightOrange = 29,
		[Cpp2IlInjected.Token(Token = "0x400028C")]
		LightYellow = 30,
		[Cpp2IlInjected.Token(Token = "0x400028D")]
		Cyan = 31,
		[Cpp2IlInjected.Token(Token = "0x400028E")]
		LightPurple = 32,
		[Cpp2IlInjected.Token(Token = "0x400028F")]
		DarkTan = 33,
		[Cpp2IlInjected.Token(Token = "0x4000290")]
		NewColor1 = 34,
		[Cpp2IlInjected.Token(Token = "0x4000291")]
		NewColor2 = 35,
		[Cpp2IlInjected.Token(Token = "0x4000292")]
		NewColor3 = 36,
		[Cpp2IlInjected.Token(Token = "0x4000293")]
		NewColor4 = 37,
		[Cpp2IlInjected.Token(Token = "0x4000294")]
		NewColor5 = 38,
		[Cpp2IlInjected.Token(Token = "0x4000295")]
		NewColor6 = 39,
		[Cpp2IlInjected.Token(Token = "0x4000296")]
		NewColor7 = 40,
		[Cpp2IlInjected.Token(Token = "0x4000297")]
		NewColor8 = 41,
		[Cpp2IlInjected.Token(Token = "0x4000298")]
		NewColor9 = 42,
		[Cpp2IlInjected.Token(Token = "0x4000299")]
		NewColor10 = 43,
		[Cpp2IlInjected.Token(Token = "0x400029A")]
		NewColor11 = 44,
		[Cpp2IlInjected.Token(Token = "0x400029B")]
		NewColor12 = 45,
		[Cpp2IlInjected.Token(Token = "0x400029C")]
		NewColor13 = 46,
		[Cpp2IlInjected.Token(Token = "0x400029D")]
		NewColor14 = 47,
		[Cpp2IlInjected.Token(Token = "0x400029E")]
		NewColor15 = 48,
		[Cpp2IlInjected.Token(Token = "0x400029F")]
		NewColor16 = 49,
		[Cpp2IlInjected.Token(Token = "0x40002A0")]
		NewColor17 = 50,
		[Cpp2IlInjected.Token(Token = "0x40002A1")]
		NewColor18 = 51,
		[Cpp2IlInjected.Token(Token = "0x40002A2")]
		NewColor19 = 52,
		[Cpp2IlInjected.Token(Token = "0x40002A3")]
		NewColor20 = 53,
		[Cpp2IlInjected.Token(Token = "0x40002A4")]
		NewColor21 = 54,
		[Cpp2IlInjected.Token(Token = "0x40002A5")]
		NewColor22 = 55,
		[Cpp2IlInjected.Token(Token = "0x40002A6")]
		NewColor23 = 56,
		[Cpp2IlInjected.Token(Token = "0x40002A7")]
		NewColor24 = 57,
		[Cpp2IlInjected.Token(Token = "0x40002A8")]
		NewColor25 = 58,
		[Cpp2IlInjected.Token(Token = "0x40002A9")]
		NewColor26 = 59,
		[Cpp2IlInjected.Token(Token = "0x40002AA")]
		NewColor27 = 60,
		[Cpp2IlInjected.Token(Token = "0x40002AB")]
		Default = 0
	}
	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	[RecRoom.DataLayer.NetworkEnum(1, false)]
	[RecRoom.DataLayer.RRGuid("C57BE511-BA1A-4D83-BA58-303F34F4DE74")]
	[RecRoom.DataLayer.Range(-1, 31)]
	public enum RenderableMaterial
	{
		[Cpp2IlInjected.Token(Token = "0x40002AD")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x40002AE")]
		Cardboard = 0,
		[Cpp2IlInjected.Token(Token = "0x40002AF")]
		Neon = 1,
		[Cpp2IlInjected.Token(Token = "0x40002B0")]
		Brick = 2,
		[Cpp2IlInjected.Token(Token = "0x40002B1")]
		Carpet = 3,
		[Cpp2IlInjected.Token(Token = "0x40002B2")]
		Dirt = 4,
		[Cpp2IlInjected.Token(Token = "0x40002B3")]
		Grass = 5,
		[Cpp2IlInjected.Token(Token = "0x40002B4")]
		MetalReflective = 6,
		[Cpp2IlInjected.Token(Token = "0x40002B5")]
		Concrete = 7,
		[Cpp2IlInjected.Token(Token = "0x40002B6")]
		Linoleum = 8,
		[Cpp2IlInjected.Token(Token = "0x40002B7")]
		Plaster = 9,
		[Cpp2IlInjected.Token(Token = "0x40002B8")]
		WoodLogs = 10,
		[Cpp2IlInjected.Token(Token = "0x40002B9")]
		WoodBoards = 11,
		[Cpp2IlInjected.Token(Token = "0x40002BA")]
		WoodGrain = 12,
		[Cpp2IlInjected.Token(Token = "0x40002BB")]
		WoodFloor = 13,
		[Cpp2IlInjected.Token(Token = "0x40002BC")]
		Sand = 14,
		[Cpp2IlInjected.Token(Token = "0x40002BD")]
		GlossyPlastic = 15,
		[Cpp2IlInjected.Token(Token = "0x40002BE")]
		Cloth = 16,
		[Cpp2IlInjected.Token(Token = "0x40002BF")]
		RubberFloor = 17,
		[Cpp2IlInjected.Token(Token = "0x40002C0")]
		MetalFloorTread = 18,
		[Cpp2IlInjected.Token(Token = "0x40002C1")]
		PaintedBrick = 19,
		[Cpp2IlInjected.Token(Token = "0x40002C2")]
		Crashpad = 20,
		[Cpp2IlInjected.Token(Token = "0x40002C3")]
		PaintedWood = 21,
		[Cpp2IlInjected.Token(Token = "0x40002C4")]
		GripTape = 22,
		[Cpp2IlInjected.Token(Token = "0x40002C5")]
		GalvanizedMetal = 23,
		[Cpp2IlInjected.Token(Token = "0x40002C6")]
		ParticleBoard = 24,
		[Cpp2IlInjected.Token(Token = "0x40002C7")]
		CheckeredFloor = 25,
		[Cpp2IlInjected.Token(Token = "0x40002C8")]
		SparklyVinyl = 26,
		[Cpp2IlInjected.Token(Token = "0x40002C9")]
		Gravel = 27,
		[Cpp2IlInjected.Token(Token = "0x40002CA")]
		Rock = 28,
		[Cpp2IlInjected.Token(Token = "0x40002CB")]
		Placeholder29 = 29,
		[Cpp2IlInjected.Token(Token = "0x40002CC")]
		Placeholder30 = 30,
		[Cpp2IlInjected.Token(Token = "0x40002CD")]
		Placeholder31 = 31,
		[Cpp2IlInjected.Token(Token = "0x40002CE")]
		COUNT = 32,
		[Cpp2IlInjected.Token(Token = "0x40002CF")]
		MIN = -1,
		[Cpp2IlInjected.Token(Token = "0x40002D0")]
		MAX = 31,
		[Cpp2IlInjected.Token(Token = "0x40002D1")]
		Default = 0
	}
	[Cpp2IlInjected.Token(Token = "0x20000AC")]
	[RecRoom.DataLayer.NetworkInterface(1, false)]
	[RecRoom.DataLayer.RRGuid("CEFA84DC-B72D-4313-B0DB-FDFF30A6FCDC")]
	public interface KQYBLTVRUZI : MQWRQJUBHHL
	{
		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Key("MP_MSF")]
		[Set.Any]
		[CanDesync]
		FixedString32Bytes NVCHIRANWUZ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		[RecRoom.DataLayer.Field(2)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Key("MP_MGR")]
		[Set.Any]
		[CanDesync]
		[RuntimeOnly]
		(long RequestId, int ActorNumber, int ServerTimestamp) YNESMFFPPHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(Slot = "3")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		event Action QKHSVEHNZIV;

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action DBBRJNBGNHE;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	[RecRoom.DataLayer.NetworkInterface(1, false)]
	[RecRoom.DataLayer.RRGuid("B23E7E5C-828C-4A29-9AB2-774DFC53D18E")]
	public interface QXNTSGUTMLW : MQWRQJUBHHL
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		[RecRoom.DataLayer.Field(1)]
		[RecRoom.DataLayer.Default]
		[RecRoom.DataLayer.Key("SBDScale")]
		[Set.Auth]
		[ProtoProp("PersistenceViewData.SandboxDeformationData.Deformation", typeof(ConvertVector3ToFloat3))]
		float3 OHFXQNDZZMY
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		event Action BHUOLJQVLHS;
	}
	[Cpp2IlInjected.Token(Token = "0x20000AE")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("112F004A-C92F-4055-99F9-D430EC13FE3C")]
	public struct FractionalIndex : IComparable<FractionalIndex>, IEquatable<FractionalIndex>
	{
		[Cpp2IlInjected.Token(Token = "0x40002D2")]
		public static readonly FractionalIndex Empty;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D3")]
		[RecRoom.DataLayer.Field(1)]
		public uint nom;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002D4")]
		[RecRoom.DataLayer.Field(2)]
		public uint denomMinusOne;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private readonly uint AVSKNHHYBJD
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x9960A90", Offset = "0x995F490", VA = "0x189960A90")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public readonly bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x9960670", Offset = "0x995F070", VA = "0x189960670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x9960AA0", Offset = "0x995F4A0", VA = "0x189960AA0")]
		public FractionalIndex(int nom, int denom)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9960AA0", Offset = "0x995F4A0", VA = "0x189960AA0")]
		public FractionalIndex(uint nom, uint denom)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9960B00", Offset = "0x995F500", VA = "0x189960B00")]
		private FractionalIndex(uint nom, uint denom, bool reduce)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x9960600", Offset = "0x995F000", VA = "0x189960600")]
		public FractionalIndex OPETIGBQAFX(int a = 1)
		{
			return default(FractionalIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x9960500", Offset = "0x995EF00", VA = "0x189960500")]
		public FractionalIndex FZDVBFMHILO(int a = 1)
		{
			return default(FractionalIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x99606C0", Offset = "0x995F0C0", VA = "0x1899606C0")]
		public static FractionalIndex TGICKHTBVUI(FractionalIndex a, FractionalIndex b)
		{
			return default(FractionalIndex);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x9960570", Offset = "0x995EF70", VA = "0x189960570")]
		private static ulong GCD(ulong a, ulong b)
		{
			return default(ulong);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x9960400", Offset = "0x995EE00", VA = "0x189960400", Slot = "4")]
		public int CompareTo(FractionalIndex other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x9960440", Offset = "0x995EE40", VA = "0x189960440", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x99609B0", Offset = "0x995F3B0", VA = "0x1899609B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x99604E0", Offset = "0x995EEE0", VA = "0x1899604E0", Slot = "5")]
		public bool Equals(FractionalIndex other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x99605B0", Offset = "0x995EFB0", VA = "0x1899605B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9960680", Offset = "0x995F080", VA = "0x189960680")]
		public static bool SHHUBVCQRYC(FractionalIndex a, FractionalIndex b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x9960420", Offset = "0x995EE20", VA = "0x189960420")]
		public static bool ENWYWLXFHXP(FractionalIndex a, FractionalIndex b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x9960A70", Offset = "0x995F470", VA = "0x189960A70")]
		public static bool VRRKGKYQOGX(FractionalIndex a, FractionalIndex b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x99606A0", Offset = "0x995F0A0", VA = "0x1899606A0")]
		public static bool SULUQBRBHKE(FractionalIndex a, FractionalIndex b)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AF")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("D3AB0F52-EA41-4891-9470-6E945A9D6583")]
	public struct NetworkGuid : IEquatable<NetworkGuid>, IComparable<NetworkGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D5")]
		[RecRoom.DataLayer.Field(1)]
		public int4 data;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Guid TYJOXAKCMXB
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public static implicit operator Guid(NetworkGuid guid)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public static implicit operator NetworkGuid(Guid guid)
		{
			return default(NetworkGuid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x9961090", Offset = "0x995FA90", VA = "0x189961090", Slot = "4")]
		public bool Equals(NetworkGuid other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x660A2A0", Offset = "0x6608CA0", VA = "0x18660A2A0", Slot = "5")]
		public int CompareTo(NetworkGuid other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x99610C0", Offset = "0x995FAC0", VA = "0x1899610C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B0")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("9F5F33BE-7C0A-4870-9CE0-BA79440E7F98")]
	public struct ScaleRestriction
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D6")]
		[RecRoom.DataLayer.Field(1)]
		public bool enabled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002D7")]
		[RecRoom.DataLayer.Field(2)]
		public float3 minScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002D8")]
		[RecRoom.DataLayer.Field(3)]
		public float3 maxScale;

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x995DCB0", Offset = "0x995C6B0", VA = "0x18995DCB0")]
		public ScaleRestriction(float min, float max)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("35984D5B-ACBD-4389-A94B-840070A871E2")]
	public struct SplineParameters
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002D9")]
		[RecRoom.DataLayer.Field(1)]
		public float tubeHeightScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002DA")]
		[RecRoom.DataLayer.Field(2)]
		public int tubeRingPoints;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DB")]
		[RecRoom.DataLayer.Field(3)]
		public SplineParameterFlags flags;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public bool DFLNFXPFZOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x99621A0", Offset = "0x9960BA0", VA = "0x1899621A0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x99621B0", Offset = "0x9960BB0", VA = "0x1899621B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public bool PQHUVSTATUJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x99621F0", Offset = "0x9960BF0", VA = "0x1899621F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x9962210", Offset = "0x9960C10", VA = "0x189962210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public bool DHISKTIMNHM
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x9962200", Offset = "0x9960C00", VA = "0x189962200")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0x99621D0", Offset = "0x9960BD0", VA = "0x1899621D0")]
			set
			{
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("88EB8A39-C735-43FA-8414-C0B7AEEF4FF6")]
	public struct TerrainCustomMaterialLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002DC")]
		[RecRoom.DataLayer.Field(1)]
		public RenderableColor flatsColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002DD")]
		[RecRoom.DataLayer.Field(2)]
		public RenderableMaterial flatsMaterial;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002DE")]
		[RecRoom.DataLayer.Field(3)]
		public RenderableColor steepsColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002DF")]
		[RecRoom.DataLayer.Field(4)]
		public RenderableMaterial steepsMaterial;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[RecRoom.DataLayer.NetworkStruct(1, false)]
	[RecRoom.DataLayer.RRGuid("CE1911D2-B422-4E58-B0D6-2474AEA69D41")]
	public struct TerrainGenerationLayer
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002E0")]
		[RecRoom.DataLayer.Field(1)]
		public TerrainLayerRoughness TerrainRoughness;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
		[Cpp2IlInjected.Token(Token = "0x40002E1")]
		[RecRoom.DataLayer.Field(2)]
		public TerrainLayerDistribution TerrainShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x40002E2")]
		[RecRoom.DataLayer.Field(3)]
		public TerrainLayerHeightFunction HeightFunction;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40002E3")]
		[RecRoom.DataLayer.Field(4)]
		public float FeatureScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002E4")]
		[RecRoom.DataLayer.Field(5)]
		public float Height;
	}
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	[ServiceLifetime(Lifetime.Application)]
	public interface STPLUVMNOTV
	{
		[Cpp2IlInjected.Token(Token = "0x20000B5")]
		public enum League
		{
			[Cpp2IlInjected.Token(Token = "0x40002E6")]
			TheAmazings,
			[Cpp2IlInjected.Token(Token = "0x40002E7")]
			ValorSociety,
			[Cpp2IlInjected.Token(Token = "0x40002E8")]
			LeagueOfDefenders,
			[Cpp2IlInjected.Token(Token = "0x40002E9")]
			MasterMinds,
			[Cpp2IlInjected.Token(Token = "0x40002EA")]
			TheUnripened,
			[Cpp2IlInjected.Token(Token = "0x40002EB")]
			TheRootforged,
			[Cpp2IlInjected.Token(Token = "0x40002EC")]
			TheVineguard
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int WSLXXFBFGRQ(int a);

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool RVTMOTGEUIL();
	}
	[Cpp2IlInjected.Token(Token = "0x20000B6")]
	public struct NetworkTransformSyncData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002ED")]
		public QTFSKXYNRUH Context;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40002EE")]
		public int ContinuousMovementID;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40002EF")]
		public bool IsSleeping;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD")]
		[Cpp2IlInjected.Token(Token = "0x40002F0")]
		public bool CompressedRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE")]
		[Cpp2IlInjected.Token(Token = "0x40002F1")]
		public bool CompressedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40002F2")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40002F3")]
		public Quaternion Rotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40002F4")]
		public bool HasDeformationScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40002F5")]
		public Vector3 Scale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40002F6")]
		public Vector3 Velocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40002F7")]
		public Vector3 AngularVelocity;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40002F8")]
		public bool SyncIsRedundantResend;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40002F9")]
		public ViewId ParentView;

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x99610E0", Offset = "0x995FAE0", VA = "0x1899610E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x20000B7")]
	public struct ObjectCreationData : IEquatable<ObjectCreationData>, IComparable<ObjectCreationData>
	{
		[Cpp2IlInjected.Token(Token = "0x40002FA")]
		public static readonly int MaxSerializedSizeInBytes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40002FB")]
		public RRObjectPrefabData prefab;

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x99618C0", Offset = "0x99602C0", VA = "0x1899618C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9961720", Offset = "0x9960120", VA = "0x189961720", Slot = "4")]
		public bool Equals(ObjectCreationData other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9961790", Offset = "0x9960190", VA = "0x189961790", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x9961890", Offset = "0x9960290", VA = "0x189961890", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x99616A0", Offset = "0x99600A0", VA = "0x1899616A0", Slot = "5")]
		public int CompareTo(ObjectCreationData other)
		{
			return default(int);
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
