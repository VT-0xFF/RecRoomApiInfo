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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C3FCE0", Offset = "0x9C3E8E0", VA = "0x189C3FCE0", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C46660", Offset = "0x9C45260", VA = "0x189C46660", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29F8180", Offset = "0x29F6D80", VA = "0x1829F8180")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C44EB0", Offset = "0x9C43AB0", VA = "0x189C44EB0")]
		public RoomAssetData(SpawnableTemplateData assetData, byte type, Guid originId)
		{
		}
	}
}
namespace RecRoom.Persistence
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public delegate Task DeserializationPhaseHandler(EICHPLWXAPH args, CancellationToken cancellationToken);
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public sealed class EICHPLWXAPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private RoomOperationState OHXHUAEVOPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private List<(PersistenceView, YMQXVRQNJLQ)> JVJGIZOIARN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		[NotNull]
		public RoomDetailsDTO XGBXKXDQBCL
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		[NotNull]
		public SubRoomDTO DCTFRHDMSZP
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public MIASAYJVEEA DVPJOGIWZVM
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public IReadOnlyList<MIASAYJVEEA> DSFUZAGTQHH
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2F50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public IReadOnlyList<MIASAYJVEEA> VNWAEZTWKSJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public DEPRECATED_RoomPersistenceVersion RNIWCZKHAFW
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD1EF90", Offset = "0xD1DB90", VA = "0x180D1EF90")]
			[CompilerGenerated]
			get
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[NotNull]
		public PersistedRoomData GIZVZINZBQS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public SuperRoomData ORWZRVATRSD
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public IEnumerable<RoomAssetData> XJBBPUZBBWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0xCEE120", Offset = "0xCECD20", VA = "0x180CEE120")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public WTDQFLYTVGY WMYKOMFJJWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECD50", VA = "0x180CEE150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool OGNFPKQSKFT
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCF4380", Offset = "0xCF2F80", VA = "0x180CF4380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F8D0", Offset = "0x9C3E4D0", VA = "0x189C3F8D0")]
		public EICHPLWXAPH(RoomDetailsDTO a, SubRoomDTO b, MIASAYJVEEA c, IReadOnlyList<MIASAYJVEEA> d, IReadOnlyList<MIASAYJVEEA> e, DEPRECATED_RoomPersistenceVersion f, bool g, PersistedRoomData h, SuperRoomData i, IEnumerable<RoomAssetData> j, WTDQFLYTVGY k)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F840", Offset = "0x9C3E440", VA = "0x189C3F840")]
		public void BLCJBAFRRAT(RoomOperationState a, List<(PersistenceView, YMQXVRQNJLQ)> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F860", Offset = "0x9C3E460", VA = "0x189C3F860")]
		public List<(PersistenceView, YMQXVRQNJLQ)> NOMKPMCSCZM(RoomOperationState a)
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
	public interface MIASAYJVEEA
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		Guid MRBCXADOTUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task<AssetBundle> RNJBQNVYCEY();

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UVCPJHKGJMP();
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PersistableDeserializeParams
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public DEPRECATED_RoomPersistenceVersion DEPRECATED_version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public YMQXVRQNJLQ viewData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public bool isRuntimeCreated;
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ESSCGNBYKXL : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public List<string> TZQGZVNGOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public StringBuilder XIPGVGOOFLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public JKOGGPGPVBA UTJKKXDMJOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public int GBYQQFADKUC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public Vector3 XKSCQTQIBJK;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FA10", Offset = "0x9C3E610", VA = "0x189C3FA10", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FA60", Offset = "0x9C3E660", VA = "0x189C3FA60")]
		public ESSCGNBYKXL()
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
	public interface MLLYHBGJZYQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public interface QNHLYSAKMIR : MLLYHBGJZYQ
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		PersistableRunFor OQDSZSLRFQZ
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		bool CPFLGDCASAZ
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
		void SerializeTo(YMQXVRQNJLQ viewData, ESSCGNBYKXL transientData, StringBuilder outputLog);
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public interface DMIMLPOICKA
	{
		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		PersistableRunFor YMQRZEEIAWM
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
	public interface VGGOEXYWFXA : QNHLYSAKMIR, MLLYHBGJZYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PostDeserialize(PersistablePostDeserializeParams postDeserializeParams);
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public interface CANBRMCOLFN : QNHLYSAKMIR, MLLYHBGJZYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PreDeserialize(DEPRECATED_RoomPersistenceVersion DEPRECATED_version, YMQXVRQNJLQ viewData);
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public interface SGAVPFDBWII : MLLYHBGJZYQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		Task PreSerializeAsync(StringBuilder outputLog, SerializeType serializeType, CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ZJTKXXHCJZZ
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IReadOnlyList<UELIVBOERHZ> KEUYAMJDVCC();

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable PJKLHLJWOYW(object a, UELIVBOERHZ b);

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "2")]
		IReadOnlyList<EmptySceneHandler> GFNIOEWPHRE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[DisallowMultipleComponent]
	public class PersistenceView : RRNetworkBehavior, SZLHTNPOQJO
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
		private class LBBVTANAPUQ
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			[CompilerGenerated]
			private sealed class KAJDYQASBCU<a> : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable where a : QNHLYSAKMIR
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				private int NSYFVIOVDQI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				private a PGYMGSMZHLZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				private int DQGTEBFWJSV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				private HashSet<QNHLYSAKMIR> collection;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				public HashSet<QNHLYSAKMIR> PTJUDOBRAYJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000059")]
				private HashSet<QNHLYSAKMIR>.Enumerator MOIGOWZIHVC;

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				private a AREJNBRCORV
				{
					[Cpp2IlInjected.Token(Token = "0x6000059")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "6")]
					[DebuggerHidden]
					get
					{
						return (a)null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				private object RTHQPUQEOJM
				{
					[Cpp2IlInjected.Token(Token = "0x600005B")]
					[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "9")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0x1010DF0", Offset = "0x100F9F0", VA = "0x181010DF0")]
				[DebuggerHidden]
				public KAJDYQASBCU(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000056")]
				[Cpp2IlInjected.Address(RVA = "0x679D540", Offset = "0x679C140", VA = "0x18679D540", Slot = "7")]
				[DebuggerHidden]
				private void PEABEYBFILL()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000057")]
				[Cpp2IlInjected.Address(RVA = "0x679D2B0", Offset = "0x679BEB0", VA = "0x18679D2B0", Slot = "8")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000058")]
				[Cpp2IlInjected.Address(RVA = "0x679D690", Offset = "0x679C290", VA = "0x18679D690")]
				private void SYBUDUAVPHD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005A")]
				[Cpp2IlInjected.Address(RVA = "0x4FADEE0", Offset = "0x4FACAE0", VA = "0x184FADEE0", Slot = "10")]
				[DebuggerHidden]
				private void KTHCATTUQZC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600005C")]
				[Cpp2IlInjected.Address(RVA = "0x64DC030", Offset = "0x64DAC30", VA = "0x1864DC030", Slot = "4")]
				[DebuggerHidden]
				private IEnumerator<a> CTAZIZCYNRG()
				{
					return null;
				}

				[Cpp2IlInjected.Token(Token = "0x600005D")]
				[Cpp2IlInjected.Address(RVA = "0x64DC500", Offset = "0x64DB100", VA = "0x1864DC500", Slot = "5")]
				[DebuggerHidden]
				private IEnumerator IEVKUCCAWWZ()
				{
					return null;
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private HashSet<QNHLYSAKMIR> SCBMIVTTDQA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private HashSet<QNHLYSAKMIR> VPTYPPMGBUC;

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9C3FB10", Offset = "0x9C3E710", VA = "0x189C3FB10")]
			public void JFQCFLMMGXY(PersistableRunFor a, QNHLYSAKMIR b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9C3FC60", Offset = "0x9C3E860", VA = "0x189C3FC60")]
			private static void LDWPNHZBLKW(HashSet<QNHLYSAKMIR> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x415A9A0", Offset = "0x41595A0", VA = "0x18415A9A0")]
			public IEnumerable<a> ORYNHOKMQPT<a>(bool a) where a : QNHLYSAKMIR
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x338F480", Offset = "0x338E080", VA = "0x18338F480")]
			[IteratorStateMachine(typeof(KAJDYQASBCU<>))]
			private static IEnumerable<b> VBNTJIBSANC<b>(HashSet<QNHLYSAKMIR> a) where b : QNHLYSAKMIR
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public LBBVTANAPUQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PBPURXZCVDW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public ChildViewReference VJELHHXYECC;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public PBPURXZCVDW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9C3FE10", Offset = "0x9C3EA10", VA = "0x189C3FE10")]
			internal bool DVDXEZPHHJO(XPGFTCFPQSU a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public static readonly Dictionary<Guid, PersistenceView> AllViews;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly HashSet<PersistenceView> RFUIBPSDIJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private bool UIPPTXUSRDM;

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
		private MRXGQCQLMGZ<Guid> THLMWYTYPIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private List<QNHLYSAKMIR> VSZPQEEDKSY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private List<SGAVPFDBWII> KOWVWPEFXUZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		private LBBVTANAPUQ DHZAJCMFWGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		private Guid ZEGDBETFUPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		private Guid CLFDZLGTNWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private SMMLEVHGFEC PSFTTCYRBQF;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public static IEnumerable<PersistenceView> UHHELKDVQNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9C448D0", Offset = "0x9C434D0", VA = "0x189C448D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public Guid JQCTFOCWOYF
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9C44490", Offset = "0x9C43090", VA = "0x189C44490")]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9C44A20", Offset = "0x9C43620", VA = "0x189C44A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool EBZTOANKMTX
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x15AD730", Offset = "0x15AC330", VA = "0x1815AD730")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x15AD060", Offset = "0x15ABC60", VA = "0x1815AD060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public bool LHJOCSANFVC
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x9C44570", Offset = "0x9C43170", VA = "0x189C44570")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private bool TSHHPMOKASN
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9C41E10", Offset = "0x9C40A10", VA = "0x189C41E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public PersistenceView GAHTDQNDJBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCF42E0", Offset = "0xCF2EE0", VA = "0x180CF42E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0xCF4510", Offset = "0xCF3110", VA = "0x180CF4510")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public bool PQHOQABESXR
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9C44520", Offset = "0x9C43120", VA = "0x189C44520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private bool HKHAZQMEZRS
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x9C44120", Offset = "0x9C42D20", VA = "0x189C44120")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event PersistenceIdChanged USUPEPJFSUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9C443E0", Offset = "0x9C42FE0", VA = "0x189C443E0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9C44970", Offset = "0x9C43570", VA = "0x189C44970")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FF10", Offset = "0x9C3EB10", VA = "0x189C3FF10", Slot = "11")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9C41430", Offset = "0x9C40030", VA = "0x189C41430")]
		private bool FHVZJSGOGRU([Out] Guid a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C42580", Offset = "0x9C41180", VA = "0x189C42580")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9C42150", Offset = "0x9C40D50", VA = "0x189C42150", Slot = "12")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9C41850", Offset = "0x9C40450", VA = "0x189C41850")]
		private void JPMFIVAFRVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x9C42580", Offset = "0x9C41180", VA = "0x189C42580")]
		private void OnMasterClientSwitched(DDFOJMMWCEL player)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9C42040", Offset = "0x9C40C40", VA = "0x189C42040")]
		public void MasterEnsureValidID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9C42F20", Offset = "0x9C41B20", VA = "0x189C42F20")]
		public void PreSerializeAsync(WRLHKUPPYHT<Task> tasks, StringBuilder outputLog, SerializeType serializeType, CancellationToken cancellationToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9C43590", Offset = "0x9C42190", VA = "0x189C43590")]
		public YMQXVRQNJLQ Serialize(ESSCGNBYKXL transientData, StringBuilder outputLog)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9C41600", Offset = "0x9C40200", VA = "0x189C41600")]
		public void InitializeDeserialization(YMQXVRQNJLQ viewData, bool checkTransform = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9C42A00", Offset = "0x9C41600", VA = "0x189C42A00")]
		public void PreDeserialize(bool isSpawnAuthority, DEPRECATED_RoomPersistenceVersion DEPRECATED_version, YMQXVRQNJLQ viewData)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9C40D90", Offset = "0x9C3F990", VA = "0x189C40D90")]
		public void Deserialize(bool isSpawnAuthority, PersistableDeserializeParams deserializeParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9C42590", Offset = "0x9C41190", VA = "0x189C42590")]
		public void PostDeserialize(bool isSpawnAuthority, PersistablePostDeserializeParams postDeserializeParams)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C40690", Offset = "0x9C3F290", VA = "0x189C40690")]
		private void CSNEIWDNSRQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9C43340", Offset = "0x9C41F40", VA = "0x189C43340")]
		private YMQXVRQNJLQ QFNRJBXRTLY(YMQXVRQNJLQ a, ChildViewReference b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9C41F70", Offset = "0x9C40B70", VA = "0x189C41F70")]
		public void MarkExcludedFromRoomSave(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9C44040", Offset = "0x9C42C40", VA = "0x189C44040")]
		public void UnmarkExcludedFromRoomSave(object token)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C40530", Offset = "0x9C3F130", VA = "0x189C40530", Slot = "14")]
		public void Bake(NSNTXJAOJGZ context)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9C44300", Offset = "0x9C42F00", VA = "0x189C44300")]
		public PersistenceView()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C3FE30", Offset = "0x9C3EA30", VA = "0x189C3FE30")]
		[CompilerGenerated]
		private object AVHSJBTVMFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C44190", Offset = "0x9C42D90", VA = "0x189C44190")]
		[CompilerGenerated]
		private object WZILICDBSJC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9C41540", Offset = "0x9C40140", VA = "0x189C41540")]
		[CompilerGenerated]
		private object GEEVCGGMKZW()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class UELIVBOERHZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public delegate bool ExtraShouldRunFunc(EICHPLWXAPH data);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class YYTPHXDUXQN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public Action ZCXUQBFOEZC;

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public YYTPHXDUXQN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x9C46350", Offset = "0x9C44F50", VA = "0x189C46350")]
			internal Task WYXGBXEGFYG(EICHPLWXAPH a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class MDJIIFNDRCE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public Action<EICHPLWXAPH> ZCXUQBFOEZC;

			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public MDJIIFNDRCE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x9C3FD60", Offset = "0x9C3E960", VA = "0x189C3FD60")]
			internal Task WYXGBXEGFYG(EICHPLWXAPH a, CancellationToken b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class ACFWOTACWWL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public RunFor PGDGQTNWSKQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public UELIVBOERHZ DIJXGYBMMZW;

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ACFWOTACWWL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9C3F540", Offset = "0x9C3E140", VA = "0x189C3F540")]
			internal object RBPAYYQILXG()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private readonly Dictionary<RoomOperationState, HashSet<(RunFor, ExtraShouldRunFunc, DeserializationPhaseHandler)>> OWJCYECQSVY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public readonly Guid MFQNNXUWFVL;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C462C0", Offset = "0x9C44EC0", VA = "0x189C462C0")]
		public UELIVBOERHZ(Guid a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C45CD0", Offset = "0x9C448D0", VA = "0x189C45CD0")]
		public UELIVBOERHZ LXTYOZBHNVA(RoomOperationState a, RunFor b, DeserializationPhaseHandler c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C45B80", Offset = "0x9C44780", VA = "0x189C45B80")]
		public UELIVBOERHZ LXTYOZBHNVA(RoomOperationState a, RunFor b, Action c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C45A30", Offset = "0x9C44630", VA = "0x189C45A30")]
		public UELIVBOERHZ LXTYOZBHNVA(RoomOperationState a, RunFor b, Action<EICHPLWXAPH> c, [Optional] ExtraShouldRunFunc d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C45F00", Offset = "0x9C44B00", VA = "0x189C45F00")]
		public Dictionary<RunFor, List<DeserializationPhaseHandler>> QDUHOIUWGWS(RoomOperationState a, EICHPLWXAPH b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public delegate Task EmptySceneHandler(CancellationToken cancellationToken);
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[UnityEngine.Scripting.Preserve]
	internal class RoomLoader : ZJTKXXHCJZZ
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
		private class NGQHTMEXFOM
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		private class BGYXVZDEPDM : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private readonly object SZKFOUDUREX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			private readonly UELIVBOERHZ ZCXUQBFOEZC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			private readonly Action<object> WNLHAHDLVIV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000070")]
			private bool INFOAPNSOCD;

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xDD8300", Offset = "0xDD6F00", VA = "0x180DD8300")]
			public BGYXVZDEPDM(object a, UELIVBOERHZ b, Action<object> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x9C3F5F0", Offset = "0x9C3E1F0", VA = "0x189C3F5F0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private readonly Dictionary<object, UELIVBOERHZ> CXDJLIUEKGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private readonly List<EmptySceneHandler> QVWFMFXRAFT;

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9C45290", Offset = "0x9C43E90", VA = "0x189C45290")]
		[GEPWJNEAFDW.Root]
		internal static void RDUKEQTCCWZ(VIGMLMXVCUS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9C45070", Offset = "0x9C43C70", VA = "0x189C45070", Slot = "4")]
		public IReadOnlyList<UELIVBOERHZ> KEUYAMJDVCC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9C45130", Offset = "0x9C43D30", VA = "0x189C45130", Slot = "5")]
		public IDisposable PJKLHLJWOYW(object a, UELIVBOERHZ b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9C45030", Offset = "0x9C43C30", VA = "0x189C45030", Slot = "6")]
		public IReadOnlyList<EmptySceneHandler> GFNIOEWPHRE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9C450D0", Offset = "0x9C43CD0", VA = "0x189C450D0")]
		private void MUNWVCBYFVF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9C45380", Offset = "0x9C43F80", VA = "0x189C45380")]
		[RRRuntimeInitializeMethod]
		internal static void UBYRWVAVOXQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9C44EF0", Offset = "0x9C43AF0", VA = "0x189C44EF0")]
		internal static void Cleanup()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9C45450", Offset = "0x9C44050", VA = "0x189C45450")]
		internal void XODQBCLBFMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9C45540", Offset = "0x9C44140", VA = "0x189C45540")]
		public RoomLoader()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public static class ZJPUDXAKJDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private static readonly List<RoomOperationState> BNLXFLZVASY;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public static IReadOnlyList<RoomOperationState> OEDTAIDPATO
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x9C463F0", Offset = "0x9C44FF0", VA = "0x189C463F0")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class BQPRVKKJFCT
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
			public BQPRVKKJFCT <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9C457A0", Offset = "0x9C443A0", VA = "0x189C457A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9C459D0", Offset = "0x9C445D0", VA = "0x189C459D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private float RTKJSQIJAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private readonly float SLFBZPONOCN;

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F740", Offset = "0x9C3E340", VA = "0x189C3F740")]
		public BQPRVKKJFCT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F630", Offset = "0x9C3E230", VA = "0x189C3F630")]
		[AsyncStateMachine(typeof(<YieldIfRequired>d__3))]
		public Task PEDQBZUVZUP(CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9C3F720", Offset = "0x9C3E320", VA = "0x189C3F720")]
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
