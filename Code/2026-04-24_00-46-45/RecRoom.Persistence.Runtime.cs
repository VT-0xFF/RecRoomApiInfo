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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB0F50", Offset = "0x9DAF950", VA = "0x189DB0F50", Slot = "4")]
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
namespace _AssemblyRegistry.RecRoom_Persistence_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7980", Offset = "0x9DB6380", VA = "0x189DB7980", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
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
		[Cpp2IlInjected.Address(RVA = "0x9DB6AD0", Offset = "0x9DB54D0", VA = "0x189DB6AD0")]
		public RoomAssetData(SpawnableTemplateData assetData, byte type, Guid originId)
		{
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task DeserializationPhaseHandler(UIQXDPLZUVZ args, CancellationToken cancellationToken);
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class UIQXDPLZUVZ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private RoomOperationState ZGOLMMURASP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<(PersistenceView, FKWMEATAMCU)> TOQFWKKKXVD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[NotNull]
		public RoomDetailsDTO AKCKXSVJFVX
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[NotNull]
		public SubRoomDTO UXOKOQNFBPF
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public XCERHBOQSJM WTIDRKWMBFC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<XCERHBOQSJM> OGUQQEZPTKX
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<XCERHBOQSJM> FUFTUGHZKFN
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DEPRECATED_RoomPersistenceVersion YWBWZIZWOGG
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD40BE0", Offset = "0xD3F5E0", VA = "0x180D40BE0")]
			[CompilerGenerated]
			get
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[NotNull]
		public PersistedRoomData YNTLELKMYWM
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public SuperRoomData IQXXLRVPAPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IEnumerable<RoomAssetData> EOOGWEGHVGQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public MFIDGFMFPEG RSFOOSVXCMT
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD14480", Offset = "0xD12E80", VA = "0x180D14480")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool UWNIGMCWSZV
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xD15970", Offset = "0xD14370", VA = "0x180D15970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7840", Offset = "0x9DB6240", VA = "0x189DB7840")]
		public UIQXDPLZUVZ(RoomDetailsDTO a, SubRoomDTO b, XCERHBOQSJM c, IReadOnlyList<XCERHBOQSJM> d, IReadOnlyList<XCERHBOQSJM> e, DEPRECATED_RoomPersistenceVersion f, bool g, PersistedRoomData h, SuperRoomData i, IEnumerable<RoomAssetData> j, MFIDGFMFPEG k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9DB77B0", Offset = "0x9DB61B0", VA = "0x189DB77B0")]
		public void CSPQYVKEDHX(RoomOperationState a, List<(PersistenceView, FKWMEATAMCU)> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9DB77D0", Offset = "0x9DB61D0", VA = "0x189DB77D0")]
		public List<(PersistenceView, FKWMEATAMCU)> CZCMHXQTXAI(RoomOperationState a)
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
	public interface XCERHBOQSJM
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Guid ROSJEGTEYEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AssetBundle> NFNKRUIOJBI();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void VQZYJXZRHQV();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PersistableDeserializeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public FKWMEATAMCU viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool isRuntimeCreated;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class TWEFHYFYUNN : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public List<string> QQWELNYADZG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public StringBuilder BIIBYSMABHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public JFGLASFVBKM CTXWIGOTFFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int MNWLMKKBCPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Vector3 YVKUGLOHYLQ;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7280", Offset = "0x9DB5C80", VA = "0x189DB7280", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB72D0", Offset = "0x9DB5CD0", VA = "0x189DB72D0")]
		public TWEFHYFYUNN()
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
	public interface XTRKVOBNKZY
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface DFRCIGMNTWP : XTRKVOBNKZY
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PersistableRunFor CQYUOQEVOBF
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool FKRPLYIOOLF
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
		void SerializeTo(FKWMEATAMCU viewData, TWEFHYFYUNN transientData, StringBuilder outputLog);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface GZEKTOUEWVY
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		PersistableRunFor NJOIYGKEVGW
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
	public interface DORVVBLFWYY : DFRCIGMNTWP, XTRKVOBNKZY
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PostDeserialize(PersistablePostDeserializeParams postDeserializeParams);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface FAFGCCHIMJP : DFRCIGMNTWP, XTRKVOBNKZY
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PreDeserialize(DEPRECATED_RoomPersistenceVersion DEPRECATED_version, FKWMEATAMCU viewData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface RFGUQEMLDCW : XTRKVOBNKZY
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task PreSerializeAsync(StringBuilder outputLog, SerializeType serializeType, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface EVOGHOZEDAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<OZMADHOTIYF> RGYVDPOJKJS();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable QWYTQBALJAM(object a, OZMADHOTIYF b);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IReadOnlyList<EmptySceneHandler> SLVDCALGSOM();
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, PVNROETDIYK
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
		private class DGZBXPKKNHY
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			[CompilerGenerated]
			private sealed class JQYVOYRMQVQ<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : DFRCIGMNTWP
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				private int EQRCVSNPEJY;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				private a RIDNXCOLQWN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				private int QBMVXUNSGXZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				private HashSet<DFRCIGMNTWP> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public HashSet<DFRCIGMNTWP> CBRJUMZUANN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000059")]
				private HashSet<DFRCIGMNTWP>.Enumerator IRFNBWFCZWO;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				private a KCZFSMOPHDD
				{
					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return (a)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				private object IFKDFAMTOCU
				{
					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x1040930", Offset = "0x103F330", VA = "0x181040930")]
				[DebuggerHidden]
				public JQYVOYRMQVQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x66E16D0", Offset = "0x66E00D0", VA = "0x1866E16D0", Slot = "7")]
				[DebuggerHidden]
				private void GWJQUAHXPBV()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x66E1CD0", Offset = "0x66E06D0", VA = "0x1866E1CD0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x66E2030", Offset = "0x66E0A30", VA = "0x1866E2030")]
				private void XNJKRYGWMCP()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x4F33510", Offset = "0x4F31F10", VA = "0x184F33510", Slot = "10")]
				[DebuggerHidden]
				private void JNSYTSSCILY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x511A880", Offset = "0x5119280", VA = "0x18511A880", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<a> EZYGKGYZAUK()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x656FFE0", Offset = "0x656E9E0", VA = "0x18656FFE0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator XDTPACFLBGX()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<DFRCIGMNTWP> VNONQASPBIK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private HashSet<DFRCIGMNTWP> ATVGHTKLOGM;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9DB0900", Offset = "0x9DAF300", VA = "0x189DB0900")]
			public void GHRGSZHLFWI(PersistableRunFor a, DFRCIGMNTWP b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9DB0A50", Offset = "0x9DAF450", VA = "0x189DB0A50")]
			private static void HGGARQCHAAQ(HashSet<DFRCIGMNTWP> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x4193DC0", Offset = "0x41927C0", VA = "0x184193DC0")]
			public IEnumerable<a> CBACDOUUGTV<a>(bool a) where a : DFRCIGMNTWP
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x33CACE0", Offset = "0x33C96E0", VA = "0x1833CACE0")]
			[IteratorStateMachine(typeof(JQYVOYRMQVQ<>))]
			private static IEnumerable<b> DIJJDCLYRRQ<b>(HashSet<DFRCIGMNTWP> a) where b : DFRCIGMNTWP
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public DGZBXPKKNHY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class TATDWYKRKHU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public ChildViewReference XPPBUWYUJUA;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public TATDWYKRKHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9DB7220", Offset = "0x9DB5C20", VA = "0x189DB7220")]
			internal bool QACMAMYVIYS(QWUDFIGOEPY a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly HashSet<PersistenceView> ZFQWEJMWJCU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool DEDWVCSRHPG;

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
		private CAAVBGFGJFR<Guid> BXCJVYTNPSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<DFRCIGMNTWP> CLSSRRDDPWW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private List<RFGUQEMLDCW> XZAPRGQUXFZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private DGZBXPKKNHY OKAIUXESACG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid SEYLIGSTYRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid WCJWPWSVZKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private HFGUPORPTXK QBKHYGMVGFN;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> CGXMSKRDEJK
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9DB64F0", Offset = "0x9DB4EF0", VA = "0x189DB64F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid JQHSIUZOJPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9DB60B0", Offset = "0x9DB4AB0", VA = "0x189DB60B0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9DB6640", Offset = "0x9DB5040", VA = "0x189DB6640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool FNJWBTVKCHV
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x15DCB40", Offset = "0x15DB540", VA = "0x1815DCB40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x15DCB30", Offset = "0x15DB530", VA = "0x1815DCB30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool ZDOREZZJINE
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9DB6190", Offset = "0x9DB4B90", VA = "0x189DB6190")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool SQBBKYAJZLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9DB3120", Offset = "0x9DB1B20", VA = "0x189DB3120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView TFJRPRCVXET
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xD159C0", Offset = "0xD143C0", VA = "0x180D159C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool ZLFDSGEKDHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9DB6140", Offset = "0x9DB4B40", VA = "0x189DB6140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool OHUOXHLLGWK
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9DB2860", Offset = "0x9DB1260", VA = "0x189DB2860")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PersistenceIdChanged EWUWJGYUEEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9DB6000", Offset = "0x9DB4A00", VA = "0x189DB6000")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9DB6590", Offset = "0x9DB4F90", VA = "0x189DB6590")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1A40", Offset = "0x9DB0440", VA = "0x189DB1A40", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9DB2D70", Offset = "0x9DB1770", VA = "0x189DB2D70")]
		private bool LZSDNKOEWLO([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9DB36B0", Offset = "0x9DB20B0", VA = "0x189DB36B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3280", Offset = "0x9DB1C80", VA = "0x189DB3280", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4480", Offset = "0x9DB2E80", VA = "0x189DB4480")]
		private void SNEYEAMKLSU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB36B0", Offset = "0x9DB20B0", VA = "0x189DB36B0")]
		private void OnMasterClientSwitched(KDSOOWCXYNX player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3010", Offset = "0x9DB1A10", VA = "0x189DB3010")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4050", Offset = "0x9DB2A50", VA = "0x189DB4050")]
		public void PreSerializeAsync(RSEYNVEGUBB<Task> tasks, StringBuilder outputLog, SerializeType serializeType, CancellationToken cancellationToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9DB4A40", Offset = "0x9DB3440", VA = "0x189DB4A40")]
		public FKWMEATAMCU Serialize(TWEFHYFYUNN transientData, StringBuilder outputLog)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9DB28D0", Offset = "0x9DB12D0", VA = "0x189DB28D0")]
		public void InitializeDeserialization(FKWMEATAMCU viewData, bool checkTransform = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9DB3B30", Offset = "0x9DB2530", VA = "0x189DB3B30")]
		public void PreDeserialize(bool isSpawnAuthority, DEPRECATED_RoomPersistenceVersion DEPRECATED_version, FKWMEATAMCU viewData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9DB21C0", Offset = "0x9DB0BC0", VA = "0x189DB21C0")]
		public void Deserialize(bool isSpawnAuthority, PersistableDeserializeParams deserializeParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9DB36C0", Offset = "0x9DB20C0", VA = "0x189DB36C0")]
		public void PostDeserialize(bool isSpawnAuthority, PersistablePostDeserializeParams postDeserializeParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9DB55D0", Offset = "0x9DB3FD0", VA = "0x189DB55D0")]
		private void UQCJEYUURWM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9DB2B20", Offset = "0x9DB1520", VA = "0x189DB2B20")]
		private FKWMEATAMCU KHVUVGQDOOM(FKWMEATAMCU a, ChildViewReference b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9DB2F40", Offset = "0x9DB1940", VA = "0x189DB2F40")]
		public void MarkExcludedFromRoomSave(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5CD0", Offset = "0x9DB46D0", VA = "0x189DB5CD0")]
		public void UnmarkExcludedFromRoomSave(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9DB2060", Offset = "0x9DB0A60", VA = "0x189DB2060", Slot = "14")]
		public void Bake(QQYPAOLAOXV context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5F20", Offset = "0x9DB4920", VA = "0x189DB5F20")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB54F0", Offset = "0x9DB3EF0", VA = "0x189DB54F0")]
		[CompilerGenerated]
		private object TWWAQLMJIHY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9DB5DB0", Offset = "0x9DB47B0", VA = "0x189DB5DB0")]
		[CompilerGenerated]
		private object ZRACTLWKDGK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9DB2E80", Offset = "0x9DB1880", VA = "0x189DB2E80")]
		[CompilerGenerated]
		private object MWOQSCQPODI()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class OZMADHOTIYF
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate bool ExtraShouldRunFunc(UIQXDPLZUVZ data);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Action FSGGDHDJDUS;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9DB0EB0", Offset = "0x9DAF8B0", VA = "0x189DB0EB0")]
			internal Task ZLUWCFGLKAM(UIQXDPLZUVZ a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class EPVSEXAORWC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Action<UIQXDPLZUVZ> FSGGDHDJDUS;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EPVSEXAORWC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9DB0E00", Offset = "0x9DAF800", VA = "0x189DB0E00")]
			internal Task ZLUWCFGLKAM(UIQXDPLZUVZ a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class ACWIPAVUBWN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public RunFor WHAACINNXTA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public OZMADHOTIYF TICTAVAJHVE;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public ACWIPAVUBWN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9DB0850", Offset = "0x9DAF250", VA = "0x189DB0850")]
			internal object WSPTAFZHCAG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly Dictionary<RoomOperationState, HashSet<(RunFor, ExtraShouldRunFunc, DeserializationPhaseHandler)>> WSQRKOOSDNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly Guid VHSXPYSQREX;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9DB19B0", Offset = "0x9DB03B0", VA = "0x189DB19B0")]
		public OZMADHOTIYF(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9DB13C0", Offset = "0x9DAFDC0", VA = "0x189DB13C0")]
		public OZMADHOTIYF SNCEACPYIJC(RoomOperationState a, RunFor b, DeserializationPhaseHandler c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1270", Offset = "0x9DAFC70", VA = "0x189DB1270")]
		public OZMADHOTIYF SNCEACPYIJC(RoomOperationState a, RunFor b, Action c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9DB1120", Offset = "0x9DAFB20", VA = "0x189DB1120")]
		public OZMADHOTIYF SNCEACPYIJC(RoomOperationState a, RunFor b, Action<UIQXDPLZUVZ> c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9DB15F0", Offset = "0x9DAFFF0", VA = "0x189DB15F0")]
		public Dictionary<RunFor, List<DeserializationPhaseHandler>> UTVQHHRWRJW(RoomOperationState a, UIQXDPLZUVZ b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate Task EmptySceneHandler(CancellationToken cancellationToken);
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomLoader : EVOGHOZEDAJ
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
		private class KCLITLLKUEK
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class TQUESYGNPOQ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private readonly object LTCUZYHUHUF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private readonly OZMADHOTIYF FSGGDHDJDUS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private readonly Action<object> WRBIGPCZZGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private bool WQKINWPMPUV;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xE09060", Offset = "0xE07A60", VA = "0x180E09060")]
			public TQUESYGNPOQ(object a, OZMADHOTIYF b, Action<object> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9DB7240", Offset = "0x9DB5C40", VA = "0x189DB7240", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly Dictionary<object, OZMADHOTIYF> YSKRGMMJGQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly List<EmptySceneHandler> AIQQKJTYJVR;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6B10", Offset = "0x9DB5510", VA = "0x189DB6B10")]
		[BRMSZAJTATI.Root]
		internal static void BZJNQHTNBAL(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6F80", Offset = "0x9DB5980", VA = "0x189DB6F80", Slot = "4")]
		public IReadOnlyList<OZMADHOTIYF> RGYVDPOJKJS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6E20", Offset = "0x9DB5820", VA = "0x189DB6E20", Slot = "5")]
		public IDisposable QWYTQBALJAM(object a, OZMADHOTIYF b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9DB70B0", Offset = "0x9DB5AB0", VA = "0x189DB70B0", Slot = "6")]
		public IReadOnlyList<EmptySceneHandler> SLVDCALGSOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6DC0", Offset = "0x9DB57C0", VA = "0x189DB6DC0")]
		private void LOEMJIIALKZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6FE0", Offset = "0x9DB59E0", VA = "0x189DB6FE0")]
		[RRRuntimeInitializeMethod]
		internal static void SDSAAHOEYJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6C00", Offset = "0x9DB5600", VA = "0x189DB6C00")]
		internal static void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9DB6D40", Offset = "0x9DB5740", VA = "0x189DB6D40")]
		internal void FOSPRZYHWCV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9DB7160", Offset = "0x9DB5B60", VA = "0x189DB7160")]
		public RoomLoader()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class DWBGOSQMUAE
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly List<RoomOperationState> EQALOMIDUTI;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static IReadOnlyList<RoomOperationState> JZEITOHIHGW
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9DB0AD0", Offset = "0x9DAF4D0", VA = "0x189DB0AD0")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class NVNLSDBNUUF
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
			public NVNLSDBNUUF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9DB7520", Offset = "0x9DB5F20", VA = "0x189DB7520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9DB7750", Offset = "0x9DB6150", VA = "0x189DB7750", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private float DZYDATQSGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly float CYWWKAAHRCP;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9DB10E0", Offset = "0x9DAFAE0", VA = "0x189DB10E0")]
		public NVNLSDBNUUF(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0FF0", Offset = "0x9DAF9F0", VA = "0x189DB0FF0")]
		[AsyncStateMachine(typeof(<YieldIfRequired>d__3))]
		public Task SPLHQHAZMCN(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9DB0FD0", Offset = "0x9DAF9D0", VA = "0x189DB0FD0")]
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
