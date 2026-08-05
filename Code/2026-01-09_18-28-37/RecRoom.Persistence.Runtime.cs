using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecNet.Rooms;
using RecRoom.Build;
using RecRoom.DataLayer;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Collections;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.Networking.DataTypes;
using RecRoom.Networking.SynchronizedFields;
using RecRoom.NoEngine.DataStructures.Tokens;
using RecRoom.ObjectModel.Serialization;
using RecRoom.Protobuf;
using RecRoom.RoomLoading.RoomOperation;
using UJect;
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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACDB00", Offset = "0xACCF00", VA = "0x180ACDB00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85E8310", Offset = "0x85E7710", VA = "0x1885E8310", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x85EE040", Offset = "0x85ED440", VA = "0x1885EE040", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x273B290", Offset = "0x273A690", VA = "0x18273B290")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.RoomLoading.RoomOperation
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct RoomAssetData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly SpawnableTemplateData assetData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public readonly byte type;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public readonly Guid originId;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x85ED3A0", Offset = "0x85EC7A0", VA = "0x1885ED3A0")]
		public RoomAssetData(SpawnableTemplateData assetData, byte type, Guid originId)
		{
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task DeserializationPhaseHandler(GUOEAOLRSCD args, CancellationToken cancellationToken);
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class GUOEAOLRSCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private RoomOperationState ROFEGERXBOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<(PersistenceView, PJGKUFHRWDW)> COBFTDWDBSN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[NotNull]
		public RoomDetailsDTO OCFBKBDYPWR
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[NotNull]
		public SubRoomDTO PQIJWIYGHWL
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KOIFJTXXCTU CDTEXEZIYVK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<KOIFJTXXCTU> KZGZWPSROOP
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BE0", Offset = "0xAA2FE0", VA = "0x180AA3BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<KOIFJTXXCTU> ANLGULWWECX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BC0", Offset = "0xAA2FC0", VA = "0x180AA3BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DEPRECATED_RoomPersistenceVersion IPDUITSSAPA
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAD3250", Offset = "0xAD2650", VA = "0x180AD3250")]
			[CompilerGenerated]
			get
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[NotNull]
		public PersistedRoomData JCJZBCJGXMY
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xAA9FA0", Offset = "0xAA93A0", VA = "0x180AA9FA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public SuperRoomData TWFTQFWANDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IEnumerable<RoomAssetData> RYMRKQVOQQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xAA6650", Offset = "0xAA5A50", VA = "0x180AA6650")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ZBEHYKVOKWC SXLGPRZHOLZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAA6680", Offset = "0xAA5A80", VA = "0x180AA6680")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UCXLBCFGLHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xAAF030", Offset = "0xAAE430", VA = "0x180AAF030")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85E74D0", Offset = "0x85E68D0", VA = "0x1885E74D0")]
		public GUOEAOLRSCD(RoomDetailsDTO a, SubRoomDTO b, KOIFJTXXCTU c, IReadOnlyList<KOIFJTXXCTU> d, IReadOnlyList<KOIFJTXXCTU> e, DEPRECATED_RoomPersistenceVersion f, bool g, PersistedRoomData h, SuperRoomData i, IEnumerable<RoomAssetData> j, ZBEHYKVOKWC k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85E7440", Offset = "0x85E6840", VA = "0x1885E7440")]
		public void JQDJGRCQMVL(RoomOperationState a, List<(PersistenceView, PJGKUFHRWDW)> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x85E7460", Offset = "0x85E6860", VA = "0x1885E7460")]
		public List<(PersistenceView, PJGKUFHRWDW)> VZGRNJXCWQA(RoomOperationState a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum AutosaveType
	{
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		Incremental,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		Recovery
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum SerializeType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		CloudSave,
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		AutosaveRecovery,
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		AutosaveIncremental
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[DisallowSerialization]
	public enum RoomOperationState
	{
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		NOT_STARTED = 0,
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		DOWNLOADING_DETAILS = 1,
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		DETAILS_DOWNLOADED = 2,
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		DOWNLOADING_DATA = 3,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		DATA_DOWNLOADED = 4,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		SCENE_LOADED = 5,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		STUDIO_ASSET_BUNDLE_PROCESSED = 6,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		SETUP_ROOM_OBJECTS = 7,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		RUN_MIGRATIONS = 8,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		PRE_DESTROY_OLD_OBJECTS = 9,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		POST_DESTROY_OLD_OBJECTS = 10,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		DESERIALIZE_SETTINGS = 10,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		PRE_INSTANTIATE_OBJECTS = 11,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		POST_INSTANTIATE_OBJECTS = 12,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		PRE_DESERIALIZE_OBJECTS = 13,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		DESERIALIZE_OBJECTS = 14,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		DESERIALIZE_CONNECTABLES = 15,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		POST_DESERIALIZE_OBJECTS = 16,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		DESERIALIZE_OBJECTS_COMPLETE = 17,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		PRE_COMPLETE = 18,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		COMPLETE = 19
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum RunFor : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Invalid,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		NonAuthority,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		Authority,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		All
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public interface KOIFJTXXCTU
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Guid XUDXWLJMVIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AssetBundle> CMYZYSOLMBA();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void LEWUTJKREUN();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PersistableDeserializeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public PJGKUFHRWDW viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool isRuntimeCreated;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class WWUYBTQTWED : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public List<string> FYBSKFXFSJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public StringBuilder ZOFPURYMHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public CJNVXMDJBEE LGFBZWNUJRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int XMNFDOXGKNS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Vector3 XNKTONOPCCO;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x85EDF20", Offset = "0x85ED320", VA = "0x1885EDF20", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x85EDF70", Offset = "0x85ED370", VA = "0x1885EDF70")]
		public WWUYBTQTWED()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum PersistableRunFor
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		RunForAuthorityOnly,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		RunForAllDuringRoomPersistence
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public interface ZBUNOKRQNLM
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface ENPRTVPTPPZ : ZBUNOKRQNLM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PersistableRunFor FHGWWTCJJQH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool KXHEAETAOKL
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DeserializeFrom(PersistableDeserializeParams deserializeParams);

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SerializeTo(PJGKUFHRWDW viewData, WWUYBTQTWED transientData, StringBuilder outputLog);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface SESGYBGXEMO
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		PersistableRunFor DYOCBCPYEBI
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task DeserializeFrom(PersistedRoomData roomData, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SerializeTo(PersistedRoomData roomData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct PersistablePostDeserializeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public bool isRuntimeCreated;
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public interface ZCBPSFGMYBS : ENPRTVPTPPZ, ZBUNOKRQNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PostDeserialize(PersistablePostDeserializeParams postDeserializeParams);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface NNQYJDLAERT : ENPRTVPTPPZ, ZBUNOKRQNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PreDeserialize(DEPRECATED_RoomPersistenceVersion DEPRECATED_version, PJGKUFHRWDW viewData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface XWBSRPTKUZI : ZBUNOKRQNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task PreSerializeAsync(StringBuilder outputLog, SerializeType serializeType, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface JBSOKQZPLLX
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<KPYHBJIKHZT> ZVYTJBEMYBG();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable NCCPPVSUEPO(object a, KPYHBJIKHZT b);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IReadOnlyList<EmptySceneHandler> SHBHGVHVQWA();
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, JLRXPIRKBHM
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public struct ChildViewReference
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public int childId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public PersistenceView persistenceView;
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public delegate void PersistenceIdChanged(Guid oldId, Guid newId);

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		private class JNTIANGGLUS
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			[CompilerGenerated]
			private sealed class SEAXBHQUJWG<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : ENPRTVPTPPZ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				private int HEQVXHRXEOS;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				private a FKBMGWISUJL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				private int QYTMAKYNUQD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				private HashSet<ENPRTVPTPPZ> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public HashSet<ENPRTVPTPPZ> GUYFFREVTOT;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000059")]
				private HashSet<ENPRTVPTPPZ>.Enumerator DJOJRFZZVTY;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				private a YCZVSCZNOBH
				{
					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return (a)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				private object HOQQBVEZJSM
				{
					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0xAA3C20", Offset = "0xAA3020", VA = "0x180AA3C20", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xD3EE90", Offset = "0xD3E290", VA = "0x180D3EE90")]
				[DebuggerHidden]
				public SEAXBHQUJWG(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x5DACEB0", Offset = "0x5DAC2B0", VA = "0x185DACEB0", Slot = "7")]
				[DebuggerHidden]
				private void HQQAIWMTMBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x5DACF50", Offset = "0x5DAC350", VA = "0x185DACF50", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x5DAD6F0", Offset = "0x5DACAF0", VA = "0x185DAD6F0")]
				private void UOGOWTTYZFR()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x3CC4DC0", Offset = "0x3CC41C0", VA = "0x183CC4DC0", Slot = "10")]
				[DebuggerHidden]
				private void IWYQKYBWKKW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x4D63380", Offset = "0x4D62780", VA = "0x184D63380", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<a> WHBKGZWPAXY()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x4E1B5C0", Offset = "0x4E1A9C0", VA = "0x184E1B5C0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator KHITEENQWKX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<ENPRTVPTPPZ> LXWCRVCYZEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private HashSet<ENPRTVPTPPZ> GRITSRJWHYI;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x85E76D0", Offset = "0x85E6AD0", VA = "0x1885E76D0")]
			public void LETSAFWSNLS(PersistableRunFor a, ENPRTVPTPPZ b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x85E7650", Offset = "0x85E6A50", VA = "0x1885E7650")]
			private static void GHCNGCZDEEE(HashSet<ENPRTVPTPPZ> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x3C2ACA0", Offset = "0x3C2A0A0", VA = "0x183C2ACA0")]
			public IEnumerable<a> LCFJMKSNXGX<a>(bool a) where a : ENPRTVPTPPZ
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x3626FD0", Offset = "0x36263D0", VA = "0x183626FD0")]
			[IteratorStateMachine(typeof(SEAXBHQUJWG<>))]
			private static IEnumerable<b> PFKWGSDKSHE<b>(HashSet<ENPRTVPTPPZ> a) where b : ENPRTVPTPPZ
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public JNTIANGGLUS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class YWCFBMPXSXY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public ChildViewReference LXQTDGNSLMU;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public YWCFBMPXSXY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x85EE020", Offset = "0x85ED420", VA = "0x1885EE020")]
			internal bool PBEXBTZLYZU(CSOXGNYFZQG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly HashSet<PersistenceView> JTJJLJKDKWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool IFEKDDOOYPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		[SerializeField]
		private ChildViewReference[] childViews;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		[SerializeField]
		private int highestChildIdAssigned;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		[SerializeField]
		public bool explicitlyBlockPersistence;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private WQHXCYICOSP<Guid> MHEPBGPINJW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<ENPRTVPTPPZ> ODZBDCWGSLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private List<XWBSRPTKUZI> ASGLEXFMZBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private JNTIANGGLUS TFAWIBZSCJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid BVBZURJFIJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid UBBUALKHEHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private JGNLWQGOMVG JXGKCLQIXMX;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> UHRFMNVCRLW
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x85ECDC0", Offset = "0x85EC1C0", VA = "0x1885ECDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid KVDFRQPXLVJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x85EC980", Offset = "0x85EBD80", VA = "0x1885EC980")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x85ECF10", Offset = "0x85EC310", VA = "0x1885ECF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool BKEIUCQIHRJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x12DED60", Offset = "0x12DE160", VA = "0x1812DED60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x12DE820", Offset = "0x12DDC20", VA = "0x1812DE820")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DXELZRXHYEK
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x85ECA60", Offset = "0x85EBE60", VA = "0x1885ECA60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool LCGIYSJUMPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x85EB940", Offset = "0x85EAD40", VA = "0x1885EB940")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView RPNEHKKDTHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8F0", Offset = "0xAADCF0", VA = "0x180AAE8F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xAAE8C0", Offset = "0xAADCC0", VA = "0x180AAE8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool YCIDTJZQXTT
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x85ECA10", Offset = "0x85EBE10", VA = "0x1885ECA10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool FZDOQAFSBFU
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x85EC6A0", Offset = "0x85EBAA0", VA = "0x1885EC6A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PersistenceIdChanged EVUYXHRRRAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x85EC8D0", Offset = "0x85EBCD0", VA = "0x1885EC8D0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x85ECE60", Offset = "0x85EC260", VA = "0x1885ECE60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85E8390", Offset = "0x85E7790", VA = "0x1885E8390", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85E9270", Offset = "0x85E8670", VA = "0x1885E9270")]
		private bool EPBVLUZNDVC([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85EA930", Offset = "0x85E9D30", VA = "0x1885EA930")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85EA510", Offset = "0x85E9910", VA = "0x1885EA510", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x85E9380", Offset = "0x85E8780", VA = "0x1885E9380")]
		private void GLBKZAHOUIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x85EA930", Offset = "0x85E9D30", VA = "0x1885EA930")]
		private void OnMasterClientSwitched(JDMCEZTJJPL player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85EA400", Offset = "0x85E9800", VA = "0x1885EA400")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x85EB2D0", Offset = "0x85EA6D0", VA = "0x1885EB2D0")]
		public void PreSerializeAsync(XRLYKJIRFVJ<Task> tasks, StringBuilder outputLog, SerializeType serializeType, CancellationToken cancellationToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85EBAA0", Offset = "0x85EAEA0", VA = "0x1885EBAA0")]
		public PJGKUFHRWDW Serialize(WWUYBTQTWED transientData, StringBuilder outputLog)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x85E9A00", Offset = "0x85E8E00", VA = "0x1885E9A00")]
		public void InitializeDeserialization(PJGKUFHRWDW viewData, bool checkTransform = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x85EADB0", Offset = "0x85EA1B0", VA = "0x1885EADB0")]
		public void PreDeserialize(bool isSpawnAuthority, DEPRECATED_RoomPersistenceVersion DEPRECATED_version, PJGKUFHRWDW viewData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85E8BD0", Offset = "0x85E7FD0", VA = "0x1885E8BD0")]
		public void Deserialize(bool isSpawnAuthority, PersistableDeserializeParams deserializeParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85EA940", Offset = "0x85E9D40", VA = "0x1885EA940")]
		public void PostDeserialize(bool isSpawnAuthority, PersistablePostDeserializeParams postDeserializeParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85E9C40", Offset = "0x85E9040", VA = "0x1885E9C40")]
		private void JKHTPNVVBGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85EB6F0", Offset = "0x85EAAF0", VA = "0x1885EB6F0")]
		private PJGKUFHRWDW QKQRDEUXMRC(PJGKUFHRWDW a, ChildViewReference b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85EA340", Offset = "0x85E9740", VA = "0x1885EA340")]
		public void MarkExcludedFromRoomSave(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85EC5C0", Offset = "0x85EB9C0", VA = "0x1885EC5C0")]
		public void UnmarkExcludedFromRoomSave(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85E8A60", Offset = "0x85E7E60", VA = "0x1885E8A60", Slot = "14")]
		public void Bake(WOSVSDXEFID context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x85EC7F0", Offset = "0x85EBBF0", VA = "0x1885EC7F0")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85E9930", Offset = "0x85E8D30", VA = "0x1885E9930")]
		[CompilerGenerated]
		private object INYRBEQLFZE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85EC540", Offset = "0x85EB940", VA = "0x1885EC540")]
		[CompilerGenerated]
		private object UHNKDDLFAGS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85E89A0", Offset = "0x85E7DA0", VA = "0x1885E89A0")]
		[CompilerGenerated]
		private object BWASLTVUBRM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class KPYHBJIKHZT
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate bool ExtraShouldRunFunc(GUOEAOLRSCD data);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class KTYJSXNJOKL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Action RVSGLQERCAK;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public KTYJSXNJOKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x85E8270", Offset = "0x85E7670", VA = "0x1885E8270")]
			internal Task XGHQYOTTRZK(GUOEAOLRSCD a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class GARRZFFJODA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Action<GUOEAOLRSCD> RVSGLQERCAK;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public GARRZFFJODA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x85E7390", Offset = "0x85E6790", VA = "0x1885E7390")]
			internal Task XGHQYOTTRZK(GUOEAOLRSCD a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class BHFVTANVIEJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public RunFor PFCLGJEULBY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public KPYHBJIKHZT ZFLSXXSLHFA;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public BHFVTANVIEJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x85E6FC0", Offset = "0x85E63C0", VA = "0x1885E6FC0")]
			internal object FETBEQNWUJI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly Dictionary<RoomOperationState, HashSet<(RunFor, ExtraShouldRunFunc, DeserializationPhaseHandler)>> WLQTRQARUZC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly Guid MMJCYQRINZJ;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x85E81E0", Offset = "0x85E75E0", VA = "0x1885E81E0")]
		public KPYHBJIKHZT(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x85E7FC0", Offset = "0x85E73C0", VA = "0x1885E7FC0")]
		public KPYHBJIKHZT ZSNFKRJPAFW(RoomOperationState a, RunFor b, DeserializationPhaseHandler c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x85E7E70", Offset = "0x85E7270", VA = "0x1885E7E70")]
		public KPYHBJIKHZT ZSNFKRJPAFW(RoomOperationState a, RunFor b, Action c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x85E7D20", Offset = "0x85E7120", VA = "0x1885E7D20")]
		public KPYHBJIKHZT ZSNFKRJPAFW(RoomOperationState a, RunFor b, Action<GUOEAOLRSCD> c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x85E7970", Offset = "0x85E6D70", VA = "0x1885E7970")]
		public Dictionary<RunFor, List<DeserializationPhaseHandler>> RYYLWQAUETS(RoomOperationState a, GUOEAOLRSCD b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate Task EmptySceneHandler(CancellationToken cancellationToken);
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomLoader : JBSOKQZPLLX
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public enum RoomLoadStates
		{
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			Start,
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			LoadingScene,
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			LoadingSubScenes,
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			LoadingPersistence,
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			PersistenceLoadComplete
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		private class CCYUFSVMKUW
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class IVRKQHTZXLC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private readonly object OELTKTIMQDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private readonly KPYHBJIKHZT RVSGLQERCAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private readonly Action<object> UINWKKXZUWD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private bool TEMRMIPWZPT;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xB2DA60", Offset = "0xB2CE60", VA = "0x180B2DA60")]
			public IVRKQHTZXLC(object a, KPYHBJIKHZT b, Action<object> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x85E7610", Offset = "0x85E6A10", VA = "0x1885E7610", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly Dictionary<object, KPYHBJIKHZT> LAOKSQHYYKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly List<EmptySceneHandler> LTTQYTNNCRB;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x85ED5A0", Offset = "0x85EC9A0", VA = "0x1885ED5A0")]
		[JKCTBFVRGVY.Root]
		internal static void ICBJJQORUJZ(NAWAUUZVKFS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x85ED960", Offset = "0x85ECD60", VA = "0x1885ED960", Slot = "4")]
		public IReadOnlyList<KPYHBJIKHZT> ZVYTJBEMYBG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x85ED690", Offset = "0x85ECA90", VA = "0x1885ED690", Slot = "5")]
		public IDisposable NCCPPVSUEPO(object a, KPYHBJIKHZT b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x85ED920", Offset = "0x85ECD20", VA = "0x1885ED920", Slot = "6")]
		public IReadOnlyList<EmptySceneHandler> SHBHGVHVQWA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x85ED7F0", Offset = "0x85ECBF0", VA = "0x1885ED7F0")]
		private void QVAAEXQFXWF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x85ED850", Offset = "0x85ECC50", VA = "0x1885ED850")]
		[RRRuntimeInitializeMethod]
		internal static void RILMXWJZBNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x85ED3E0", Offset = "0x85EC7E0", VA = "0x1885ED3E0")]
		internal static void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x85ED520", Offset = "0x85EC920", VA = "0x1885ED520")]
		internal void DIFVJFVEOOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x85EDA30", Offset = "0x85ECE30", VA = "0x1885EDA30")]
		public RoomLoader()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class EALMFKBNJGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly List<RoomOperationState> KZLQWLFCPGK;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static IReadOnlyList<RoomOperationState> QOAABBCZFAG
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x85E7130", Offset = "0x85E6530", VA = "0x1885E7130")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class JXECSDBJIUJ
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002D")]
		[CompilerGenerated]
		private struct <YieldIfRequired>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public JXECSDBJIUJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x85EDC90", Offset = "0x85ED090", VA = "0x1885EDC90", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x85EDEC0", Offset = "0x85ED2C0", VA = "0x1885EDEC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private float CNYZEILBPMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly float VWZBCXOPYAL;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x85E7930", Offset = "0x85E6D30", VA = "0x1885E7930")]
		public JXECSDBJIUJ(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x85E7820", Offset = "0x85E6C20", VA = "0x1885E7820")]
		[AsyncStateMachine(typeof(<YieldIfRequired>d__3))]
		public Task BNFDNFNCGXX(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x85E7910", Offset = "0x85E6D10", VA = "0x1885E7910")]
		public void Reset()
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
