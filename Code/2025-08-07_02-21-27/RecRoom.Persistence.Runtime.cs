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
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E33FD0", Offset = "0x8E32BD0", VA = "0x188E33FD0", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E3ADF0", Offset = "0x8E399F0", VA = "0x188E3ADF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8E394C0", Offset = "0x8E380C0", VA = "0x188E394C0")]
		public RoomAssetData(SpawnableTemplateData assetData, byte type, Guid originId)
		{
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task DeserializationPhaseHandler(APQTHAEMUEW args, CancellationToken cancellationToken);
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class APQTHAEMUEW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private RoomOperationState UNXPXOZMRVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<(PersistenceView, ABLNPBVPOUZ)> LTBOCGJYTCO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[NotNull]
		public RoomDetailsDTO YCEKEYMUJZK
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[NotNull]
		public SubRoomDTO JNTYDLEFCQK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HLVGJCQLOVH UIJLTAXEFRX
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<HLVGJCQLOVH> EACHIBWTZZI
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<HLVGJCQLOVH> XVGGGQESFBY
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DEPRECATED_RoomPersistenceVersion OMRAAKMHLWJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB447A0", Offset = "0xB433A0", VA = "0x180B447A0")]
			[CompilerGenerated]
			get
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[NotNull]
		public PersistedRoomData UQESQALFUQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public SuperRoomData ARGBBBMPVMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IEnumerable<RoomAssetData> MLUCOIMRQAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public VMMHASWVFTD RGBJCLFOTTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xB13180", Offset = "0xB11D80", VA = "0x180B13180")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DTWWVVUESAG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB13150", Offset = "0xB11D50", VA = "0x180B13150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8E32F30", Offset = "0x8E31B30", VA = "0x188E32F30")]
		public APQTHAEMUEW(RoomDetailsDTO a, SubRoomDTO b, HLVGJCQLOVH c, IReadOnlyList<HLVGJCQLOVH> d, IReadOnlyList<HLVGJCQLOVH> e, DEPRECATED_RoomPersistenceVersion f, bool g, PersistedRoomData h, SuperRoomData i, IEnumerable<RoomAssetData> j, VMMHASWVFTD k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E32F10", Offset = "0x8E31B10", VA = "0x188E32F10")]
		public void LXOLAZACPWO(RoomOperationState a, List<(PersistenceView, ABLNPBVPOUZ)> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E32EA0", Offset = "0x8E31AA0", VA = "0x188E32EA0")]
		public List<(PersistenceView, ABLNPBVPOUZ)> EPNIRHSIWUL(RoomOperationState a)
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
	public interface HLVGJCQLOVH
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Guid CFIPSIJIVUX
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AssetBundle> FZBMXSOLYKF();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZBZXEVEDZSY();

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool AZWBXYCYPHK(bool a);
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PersistableDeserializeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public ABLNPBVPOUZ viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool isRuntimeCreated;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ELUDPWHKJWU : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public List<string> WMMAAZRHMTZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public StringBuilder CQHEGAPZZOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public XENDOMYJTLX RDFAVEMXSWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int SEWVUSYGHFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Vector3 KZRDDGSQZNV;

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8E331E0", Offset = "0x8E31DE0", VA = "0x188E331E0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8E33230", Offset = "0x8E31E30", VA = "0x188E33230")]
		public ELUDPWHKJWU()
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
	public interface FQKDMWGFUYZ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface NBHPAMELQIM : FQKDMWGFUYZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PersistableRunFor PXBDTAZEQLU
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool XSAILZKMOBW
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void DeserializeFrom(PersistableDeserializeParams deserializeParams);

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void SerializeTo(ABLNPBVPOUZ viewData, ELUDPWHKJWU transientData, StringBuilder outputLog);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface AABEZYLUPCZ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		PersistableRunFor OKQFBCSCDDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task DeserializeFrom(PersistedRoomData roomData, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x6000024")]
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
	public interface UVZRTBSUJCJ : NBHPAMELQIM, FQKDMWGFUYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PostDeserialize(PersistablePostDeserializeParams postDeserializeParams);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface TKNWONPDGSW : NBHPAMELQIM, FQKDMWGFUYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PreDeserialize(DEPRECATED_RoomPersistenceVersion DEPRECATED_version, ABLNPBVPOUZ viewData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface HTFTVXVCVYB : FQKDMWGFUYZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task PreSerializeAsync(StringBuilder outputLog, SerializeType serializeType, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface BFGWYOYOWEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<FDPRMABNSIO> SNXMYJUCNJD();

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable ASDQKKPVUON(object a, FDPRMABNSIO b);

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IReadOnlyList<EmptySceneHandler> QPRNBJYKBNB();

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		IDisposable ILLFBOYHTRB(EmptySceneHandler a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, PTPJAIETWZR
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
		private class GJLNASKCMDB
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			[CompilerGenerated]
			private sealed class KARREFIMYYH<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : NBHPAMELQIM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				private int JEOGOPMUBAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				private a DPUPDOXIACG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				private int RPOQDRFWNXK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				private HashSet<NBHPAMELQIM> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public HashSet<NBHPAMELQIM> RIUPEYJNTOK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000059")]
				private HashSet<NBHPAMELQIM>.Enumerator OKMXNYRHUZP;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				private a FDHIIGDLEVW
				{
					[Cpp2IlInjected.Token(Token = "0x600005C")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return (a)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				private object APIHCGBOWUL
				{
					[Cpp2IlInjected.Token(Token = "0x600005E")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x110D170", Offset = "0x110BD70", VA = "0x18110D170")]
				[DebuggerHidden]
				public KARREFIMYYH(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0x57EF6B0", Offset = "0x57EE2B0", VA = "0x1857EF6B0", Slot = "7")]
				[DebuggerHidden]
				private void YLGUCQLHQAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x57EEE10", Offset = "0x57EDA10", VA = "0x1857EEE10", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0x57EF660", Offset = "0x57EE260", VA = "0x1857EF660")]
				private void QCWGZBRZQOC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x4381FB0", Offset = "0x4380BB0", VA = "0x184381FB0", Slot = "10")]
				[DebuggerHidden]
				private void RALPBKOBMUN()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005F")]
				[Cpp2IlInjected.Address(RVA = "0x449B830", Offset = "0x449A430", VA = "0x18449B830", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<a> HTXNERKIEJN()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x6000060")]
				[Cpp2IlInjected.Address(RVA = "0x53831A0", Offset = "0x5381DA0", VA = "0x1853831A0", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator ZFHLTDQPCLO()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<NBHPAMELQIM> KLUJVDZOLNZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private HashSet<NBHPAMELQIM> PAOSFXEJAYZ;

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8E33C00", Offset = "0x8E32800", VA = "0x188E33C00")]
			public void IJXEYTQOUZP(PersistableRunFor a, NBHPAMELQIM b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8E33D50", Offset = "0x8E32950", VA = "0x188E33D50")]
			private static void LXMWSTHUWFJ(HashSet<NBHPAMELQIM> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x4209B10", Offset = "0x4208710", VA = "0x184209B10")]
			public IEnumerable<a> KNRDMOCVDAM<a>(bool a) where a : NBHPAMELQIM
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x3B35C90", Offset = "0x3B34890", VA = "0x183B35C90")]
			[IteratorStateMachine(typeof(KARREFIMYYH<>))]
			private static IEnumerable<b> RJPBSBBTRSP<b>(HashSet<NBHPAMELQIM> a) where b : NBHPAMELQIM
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GJLNASKCMDB()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class XBXPCOCNZHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public ChildViewReference EFMODQRZQTH;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public XBXPCOCNZHZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x8E3AD90", Offset = "0x8E39990", VA = "0x188E3AD90")]
			internal bool USQQLLMRCCZ(WWFYHFIJXPP a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly HashSet<PersistenceView> UBLKKDYMVLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool VRXTCEUYVSF;

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
		private XSMAWYYPPRM<Guid> ZRWHRHVGXDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<NBHPAMELQIM> HJYMMVOYOWH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private List<HTFTVXVCVYB> EEFALEEBVJU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private GJLNASKCMDB PHPZJLKOOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid EHKVDFNLQKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid IAUCBHUKMKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private SVJYJIPYDON CUHFHDJQDXW;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> TIPSFDKGHGV
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8E38EE0", Offset = "0x8E37AE0", VA = "0x188E38EE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid AXUVQJAOTPO
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x8E38AA0", Offset = "0x8E376A0", VA = "0x188E38AA0")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x8E39030", Offset = "0x8E37C30", VA = "0x188E39030")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool MFDIBVIHAHY
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x166EB60", Offset = "0x166D760", VA = "0x18166EB60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x166EB50", Offset = "0x166D750", VA = "0x18166EB50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool DYVEALXTMAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x8E38B80", Offset = "0x8E37780", VA = "0x188E38B80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool YCTJJKDHNRS
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x8E38020", Offset = "0x8E36C20", VA = "0x188E38020")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView VNRIPRFDJRK
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xB13190", Offset = "0xB11D90", VA = "0x180B13190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool RLGOJQAUOXS
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8E38B30", Offset = "0x8E37730", VA = "0x188E38B30")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool GFZVVVKEOVP
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x8E37FB0", Offset = "0x8E36BB0", VA = "0x188E37FB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PersistenceIdChanged QLUPOLZXAHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x8E389F0", Offset = "0x8E375F0", VA = "0x188E389F0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8E38F80", Offset = "0x8E37B80", VA = "0x188E38F80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8E34340", Offset = "0x8E32F40", VA = "0x188E34340", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8E35F00", Offset = "0x8E34B00", VA = "0x188E35F00")]
		private bool JZXOUZAERUL([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x8E36760", Offset = "0x8E35360", VA = "0x188E36760")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8E36330", Offset = "0x8E34F30", VA = "0x188E36330", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E38260", Offset = "0x8E36E60", VA = "0x188E38260")]
		private void XCXHWNRFFIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8E36760", Offset = "0x8E35360", VA = "0x188E36760")]
		private void OnMasterClientSwitched(WJBKOLNRRJE player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8E36220", Offset = "0x8E34E20", VA = "0x188E36220")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8E37100", Offset = "0x8E35D00", VA = "0x188E37100")]
		public void PreSerializeAsync(ZOKMZDQINFS<Task> tasks, StringBuilder outputLog, SerializeType serializeType, CancellationToken cancellationToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8E37520", Offset = "0x8E36120", VA = "0x188E37520")]
		public ABLNPBVPOUZ Serialize(ELUDPWHKJWU transientData, StringBuilder outputLog)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8E35CB0", Offset = "0x8E348B0", VA = "0x188E35CB0")]
		public void InitializeDeserialization(ABLNPBVPOUZ viewData, bool checkTransform = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8E36BE0", Offset = "0x8E357E0", VA = "0x188E36BE0")]
		public void PreDeserialize(bool isSpawnAuthority, DEPRECATED_RoomPersistenceVersion DEPRECATED_version, ABLNPBVPOUZ viewData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8E34E50", Offset = "0x8E33A50", VA = "0x188E34E50")]
		public void Deserialize(bool isSpawnAuthority, PersistableDeserializeParams deserializeParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8E36770", Offset = "0x8E35370", VA = "0x188E36770")]
		public void PostDeserialize(bool isSpawnAuthority, PersistablePostDeserializeParams postDeserializeParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8E354F0", Offset = "0x8E340F0", VA = "0x188E354F0")]
		private void ECIBXUBSAOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8E340F0", Offset = "0x8E32CF0", VA = "0x188E340F0")]
		private ABLNPBVPOUZ AXGFKQDEHZJ(ABLNPBVPOUZ a, ChildViewReference b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x8E36150", Offset = "0x8E34D50", VA = "0x188E36150")]
		public void MarkExcludedFromRoomSave(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8E38180", Offset = "0x8E36D80", VA = "0x188E38180")]
		public void UnmarkExcludedFromRoomSave(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E34C60", Offset = "0x8E33860", VA = "0x188E34C60", Slot = "14")]
		public void Bake(XWQWSOJWOPS context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8E38910", Offset = "0x8E37510", VA = "0x188E38910")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8E36010", Offset = "0x8E34C10", VA = "0x188E36010")]
		[CompilerGenerated]
		private bool MWSMVMEZMPY(ChildViewReference a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8E36070", Offset = "0x8E34C70", VA = "0x188E36070")]
		[CompilerGenerated]
		private object MWXTSSYWWBH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8E34DD0", Offset = "0x8E339D0", VA = "0x188E34DD0")]
		[CompilerGenerated]
		private object CCBDAWJTLRX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8E35BF0", Offset = "0x8E347F0", VA = "0x188E35BF0")]
		[CompilerGenerated]
		private object EUKARGNNXUD()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class FDPRMABNSIO
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate bool ExtraShouldRunFunc(APQTHAEMUEW data);

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class PYHWMDJZEDC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public Action DPPPSFEEQDV;

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public PYHWMDJZEDC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x8E34050", Offset = "0x8E32C50", VA = "0x188E34050")]
			internal Task SNKOAYKMPOB(APQTHAEMUEW a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class BZLIFPWZYIV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Action<APQTHAEMUEW> DPPPSFEEQDV;

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public BZLIFPWZYIV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8E33070", Offset = "0x8E31C70", VA = "0x188E33070")]
			internal Task SNKOAYKMPOB(APQTHAEMUEW a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class GLPIMGKKXXA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public RunFor TYIYLVESSZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public FDPRMABNSIO VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public GLPIMGKKXXA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8E33DD0", Offset = "0x8E329D0", VA = "0x188E33DD0")]
			internal object BQSKTBLBPEL()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private readonly Dictionary<RoomOperationState, HashSet<(RunFor, ExtraShouldRunFunc, DeserializationPhaseHandler)>> BGHBWJAHHVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly Guid ENYTBNZFPDM;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8E33B70", Offset = "0x8E32770", VA = "0x188E33B70")]
		public FDPRMABNSIO(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8E33430", Offset = "0x8E32030", VA = "0x188E33430")]
		public FDPRMABNSIO BUZCXMXEWYV(RoomOperationState a, RunFor b, DeserializationPhaseHandler c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8E33660", Offset = "0x8E32260", VA = "0x188E33660")]
		public FDPRMABNSIO BUZCXMXEWYV(RoomOperationState a, RunFor b, Action c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8E332E0", Offset = "0x8E31EE0", VA = "0x188E332E0")]
		public FDPRMABNSIO BUZCXMXEWYV(RoomOperationState a, RunFor b, Action<APQTHAEMUEW> c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8E337B0", Offset = "0x8E323B0", VA = "0x188E337B0")]
		public Dictionary<RunFor, List<DeserializationPhaseHandler>> MPBIROOZIGR(RoomOperationState a, APQTHAEMUEW b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task EmptySceneHandler(CancellationToken cancellationToken);
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomLoader : BFGWYOYOWEM
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum RoomLoadStates
		{
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			Start,
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			LoadingScene,
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			LoadingSubScenes,
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			LoadingPersistence,
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			PersistenceLoadComplete
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class ZXMDJFZWYEP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private readonly EmptySceneHandler DPPPSFEEQDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private readonly Action<EmptySceneHandler> ZYJSAKIAVSR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000071")]
			private bool DDIOUOLRIDQ;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
			public ZXMDJFZWYEP(EmptySceneHandler a, Action<EmptySceneHandler> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8E3ADB0", Offset = "0x8E399B0", VA = "0x188E3ADB0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		private class AKPPVYFQNCP : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private readonly object KEBYUPXJULG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private readonly FDPRMABNSIO DPPPSFEEQDV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			private readonly Action<object> HVPXRLIYVHQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			private bool DDIOUOLRIDQ;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xE3EF80", Offset = "0xE3DB80", VA = "0x180E3EF80")]
			public AKPPVYFQNCP(object a, FDPRMABNSIO b, Action<object> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x8E32E60", Offset = "0x8E31A60", VA = "0x188E32E60", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly Dictionary<object, FDPRMABNSIO> LHNGEYOQFJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly List<EmptySceneHandler> BRMJJEBLVGO;

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8E39D50", Offset = "0x8E38950", VA = "0x188E39D50")]
		[IFIZWETSKCB.Root]
		internal static void KQEBINAABYI(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A040", Offset = "0x8E38C40", VA = "0x188E3A040", Slot = "4")]
		public IReadOnlyList<FDPRMABNSIO> SNXMYJUCNJD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8E39500", Offset = "0x8E38100", VA = "0x188E39500", Slot = "5")]
		public IDisposable ASDQKKPVUON(object a, FDPRMABNSIO b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A000", Offset = "0x8E38C00", VA = "0x188E3A000", Slot = "6")]
		public IReadOnlyList<EmptySceneHandler> QPRNBJYKBNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8E398F0", Offset = "0x8E384F0", VA = "0x188E398F0", Slot = "7")]
		public IDisposable ILLFBOYHTRB(EmptySceneHandler a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8E39E40", Offset = "0x8E38A40", VA = "0x188E39E40")]
		[Conditional("DEBUG_BUILD")]
		[Conditional("UNITY_EDITOR")]
		private void OXBZGWUHBQT(FDPRMABNSIO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8E39BB0", Offset = "0x8E387B0", VA = "0x188E39BB0")]
		private void KGTFVNGJRKM(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A170", Offset = "0x8E38D70", VA = "0x188E3A170")]
		private void VPZPHZQQXKQ(EmptySceneHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A0A0", Offset = "0x8E38CA0", VA = "0x188E3A0A0")]
		[RRRuntimeInitializeMethod]
		internal static void UOYLZEXSXHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8E397A0", Offset = "0x8E383A0", VA = "0x188E397A0")]
		internal static void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A310", Offset = "0x8E38F10", VA = "0x188E3A310")]
		internal void VRGISHGZGXK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8E3A400", Offset = "0x8E39000", VA = "0x188E3A400")]
		public RoomLoader()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public static class TMUTYIUWKBH
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private static readonly List<RoomOperationState> SNSDOLDQCZB;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static IReadOnlyList<RoomOperationState> YZGFHNNFNEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8E3A4C0", Offset = "0x8E390C0", VA = "0x188E3A4C0")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class HSQOIPLQDEG
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct <YieldIfRequired>d__3 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public HSQOIPLQDEG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x8E3AB00", Offset = "0x8E39700", VA = "0x188E3AB00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x8E3AD30", Offset = "0x8E39930", VA = "0x188E3AD30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private float WUMWWVAOXMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private readonly float LFFPOJECJOM;

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8E33F90", Offset = "0x8E32B90", VA = "0x188E33F90")]
		public HSQOIPLQDEG(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8E33E80", Offset = "0x8E32A80", VA = "0x188E33E80")]
		[AsyncStateMachine(typeof(<YieldIfRequired>d__3))]
		public Task JYFRYXPBHSM(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x8E33F70", Offset = "0x8E32B70", VA = "0x188E33F70")]
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
