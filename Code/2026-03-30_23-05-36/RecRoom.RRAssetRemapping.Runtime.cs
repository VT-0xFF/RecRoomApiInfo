using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Initialization;
using RecRoom.NoEngine.Common;
using UJect;
using UJect.Injection;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RRAssetRemapping_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8F53D90", Offset = "0x8F52B90", VA = "0x188F53D90", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x27B5590", Offset = "0x27B4390", VA = "0x1827B5590")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class WKCMXKTYZXV : HLVTPNALQCU
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Regex LQCLUUOIIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly OBYGOLPQHAR WKIPSZOUBKA;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8F53150", Offset = "0x8F51F50", VA = "0x188F53150")]
		[AUEAKLYJEMA.Root.GameOnly]
		[UsedImplicitly]
		internal static void AUEAKLYJEMA(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8F53690", Offset = "0x8F52490", VA = "0x188F53690")]
		[UsedImplicitly]
		internal static void JHRDTHGNZVT(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public WKCMXKTYZXV([Inject(null)] OBYGOLPQHAR runtimeMapperProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8F536F0", Offset = "0x8F524F0", VA = "0x188F536F0", Slot = "4")]
		public string Serialize(AvatarItemDesc input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F531C0", Offset = "0x8F51FC0", VA = "0x188F531C0", Slot = "5")]
		public AvatarItemDesc Deserialize(string input)
		{
			return default(AvatarItemDesc);
		}
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660")]
		public AvatarItemId Deserialize()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8F52220", Offset = "0x8F51020", VA = "0x188F52220", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8F522E0", Offset = "0x8F510E0", VA = "0x188F522E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660")]
		public BodyShapeId Deserialize()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8F52350", Offset = "0x8F51150", VA = "0x188F52350", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8F523F0", Offset = "0x8F511F0", VA = "0x188F523F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660")]
		public ColorId Deserialize()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0", Slot = "4")]
		public bool Equals(SerializedColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8F52460", Offset = "0x8F51260", VA = "0x188F52460", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8F52500", Offset = "0x8F51300", VA = "0x188F52500", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, NVQGEFUYTGF, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xCDB8A0", Offset = "0xCDA6A0", VA = "0x180CDB8A0")]
		public CombinationId Deserialize()
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF8D0", Offset = "0x8DDE6D0", VA = "0x188DDF8D0", Slot = "4")]
		public bool Equals(SerializedCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8F52570", Offset = "0x8F51370", VA = "0x188F52570", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedCombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8F52630", Offset = "0x8F51430", VA = "0x188F52630", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8F52620", Offset = "0x8F51420", VA = "0x188F52620", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool SBSQVTEZLGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8F526A0", Offset = "0x8F514A0", VA = "0x188F526A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1300B60", Offset = "0x12FF960", VA = "0x181300B60")]
		public SerializedCustomAvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660")]
		public static SerializedCustomAvatarItemId HAZYFHUGAMN(Guid a)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8F52700", Offset = "0x8F51500", VA = "0x188F52700", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0")]
		public static bool QIDDWXQJPGU(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8F527A0", Offset = "0x8F515A0", VA = "0x188F527A0")]
		public static bool OLTCZZLLQGX(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8F527C0", Offset = "0x8F515C0", VA = "0x188F527C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8F52940", Offset = "0x8F51740", VA = "0x188F52940")]
		public static SerializedEquipmentSkinId XPWIBGMUVRN()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660")]
		public EquipmentSkinId Deserialize()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8F52830", Offset = "0x8F51630", VA = "0x188F52830", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8F528D0", Offset = "0x8F516D0", VA = "0x188F528D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660")]
		public FaceFeatureId Deserialize()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8F52970", Offset = "0x8F51770", VA = "0x188F52970", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F52A10", Offset = "0x8F51810", VA = "0x188F52A10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660")]
		public FaceShapeId Deserialize()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8F52A80", Offset = "0x8F51880", VA = "0x188F52A80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8F52B20", Offset = "0x8F51920", VA = "0x188F52B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660")]
		public HairPatternId Deserialize()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0", Slot = "4")]
		public bool Equals(SerializedHairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedHairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8F52B90", Offset = "0x8F51990", VA = "0x188F52B90", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8F522C0", Offset = "0x8F510C0", VA = "0x188F522C0")]
		public static bool QIDDWXQJPGU(SerializedHairPatternId a, SerializedHairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8F52C30", Offset = "0x8F51A30", VA = "0x188F52C30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1090660", Offset = "0x108F460", VA = "0x181090660", Slot = "6")]
		public Guid VDGSZNPDKKR()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8DDF8D0", Offset = "0x8DDE6D0", VA = "0x188DDF8D0", Slot = "4")]
		public bool Equals(SerializedMaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8F52CA0", Offset = "0x8F51AA0", VA = "0x188F52CA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x83909F0", Offset = "0x838F7F0", VA = "0x1883909F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8390860", Offset = "0x838F660", VA = "0x188390860", Slot = "5")]
		public int CompareTo(SerializedMaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F52D40", Offset = "0x8F51B40", VA = "0x188F52D40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ZSEDNHKRLKP : OBYGOLPQHAR
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ZSEDNHKRLKP PKFRARWZTTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8F53D40", Offset = "0x8F52B40", VA = "0x188F53D40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public XPNTWMODFOM<AvatarItemId> PJXFHGSNMYN
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8F53B60", Offset = "0x8F52960", VA = "0x188F53B60", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public XPNTWMODFOM<EquipmentSkinId> AGZMDHBXIZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8F53C00", Offset = "0x8F52A00", VA = "0x188F53C00", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public XPNTWMODFOM<HairPatternId> OQADZPZDAXD
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8F53C50", Offset = "0x8F52A50", VA = "0x188F53C50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public XPNTWMODFOM<CombinationId> VNLSNPEWORC
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8F53B10", Offset = "0x8F52910", VA = "0x188F53B10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public XPNTWMODFOM<ColorId> QIAWUDZIRBW
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8F53BB0", Offset = "0x8F529B0", VA = "0x188F53BB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public XPNTWMODFOM<FaceShapeId> DDXYIPJYBEZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8F53AC0", Offset = "0x8F528C0", VA = "0x188F53AC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public XPNTWMODFOM<BodyShapeId> DUICDCKPZIW
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8F53CA0", Offset = "0x8F52AA0", VA = "0x188F53CA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public XPNTWMODFOM<FaceFeatureId> RWBJBFFLWQK
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8F53CF0", Offset = "0x8F52AF0", VA = "0x188F53CF0", Slot = "11")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class KPWHKHLWPNG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8F4ADA0", Offset = "0x8F49BA0", VA = "0x188F4ADA0")]
		public static Guid WMELOUQOGLR(string a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8F4ACD0", Offset = "0x8F49AD0", VA = "0x188F4ACD0")]
		public static bool OOYRVEMZBAP(string a, [Out] Guid b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class MZOCBLWGLWA : ZFSMLUBFCCM<AvatarItemId>, WTZVETWARLM<AvatarItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8F4B0F0", Offset = "0x8F49EF0", VA = "0x188F4B0F0", Slot = "4")]
		public IEnumerable<(AvatarItemId, string)> ZJCQIFQPRJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8F4B0D0", Offset = "0x8F49ED0", VA = "0x188F4B0D0", Slot = "5")]
		public string NDKKRQVUWMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8F40C20", Offset = "0x8F3FA20", VA = "0x188F40C20", Slot = "6")]
		public AvatarItemId HUQCZCRGBZI(string a)
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public MZOCBLWGLWA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class VBVQJQEZKKH : ZFSMLUBFCCM<BodyShapeId>, WTZVETWARLM<BodyShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8F52DB0", Offset = "0x8F51BB0", VA = "0x188F52DB0", Slot = "4")]
		public IEnumerable<(BodyShapeId, string)> ZJCQIFQPRJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB2C9D0", Offset = "0xB2B7D0", VA = "0x180B2C9D0", Slot = "5")]
		public string NDKKRQVUWMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8F40C20", Offset = "0x8F3FA20", VA = "0x188F40C20", Slot = "6")]
		public BodyShapeId HUQCZCRGBZI(string a)
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public VBVQJQEZKKH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PWHSLBKNLWV : ZFSMLUBFCCM<ColorId>, WTZVETWARLM<ColorId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8F4FD40", Offset = "0x8F4EB40", VA = "0x188F4FD40", Slot = "4")]
		public IEnumerable<(ColorId, string)> ZJCQIFQPRJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB2C9D0", Offset = "0xB2B7D0", VA = "0x180B2C9D0", Slot = "5")]
		public string NDKKRQVUWMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8F40C20", Offset = "0x8F3FA20", VA = "0x188F40C20", Slot = "6")]
		public ColorId HUQCZCRGBZI(string a)
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public PWHSLBKNLWV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class MHJMWKLXRHD : ZFSMLUBFCCM<CombinationId>, WTZVETWARLM<CombinationId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly WTZVETWARLM<MaterialId> QHINBSPMYMC;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xACA8D0", Offset = "0xAC96D0", VA = "0x180ACA8D0")]
		public MHJMWKLXRHD(WTZVETWARLM<MaterialId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8DE0860", Offset = "0x8DDF660", VA = "0x188DE0860", Slot = "4")]
		public IEnumerable<(CombinationId, string)> ZJCQIFQPRJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8F4AE50", Offset = "0x8F49C50", VA = "0x188F4AE50", Slot = "6")]
		public CombinationId HUQCZCRGBZI(string a)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8F4B090", Offset = "0x8F49E90", VA = "0x188F4B090", Slot = "5")]
		public string NDKKRQVUWMF(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ICMOVDLVABJ : ZFSMLUBFCCM<EquipmentSkinId>, WTZVETWARLM<EquipmentSkinId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8F42C10", Offset = "0x8F41A10", VA = "0x188F42C10", Slot = "4")]
		public IEnumerable<(EquipmentSkinId, string)> ZJCQIFQPRJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xB2C9D0", Offset = "0xB2B7D0", VA = "0x180B2C9D0", Slot = "5")]
		public string NDKKRQVUWMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8F40C20", Offset = "0x8F3FA20", VA = "0x188F40C20", Slot = "6")]
		public EquipmentSkinId HUQCZCRGBZI(string a)
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public ICMOVDLVABJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class FDXCLGBHYTN : ZFSMLUBFCCM<FaceFeatureId>, WTZVETWARLM<FaceFeatureId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8F41350", Offset = "0x8F40150", VA = "0x188F41350", Slot = "4")]
		public IEnumerable<(FaceFeatureId, string)> ZJCQIFQPRJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB2C9D0", Offset = "0xB2B7D0", VA = "0x180B2C9D0", Slot = "5")]
		public string NDKKRQVUWMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8F40C20", Offset = "0x8F3FA20", VA = "0x188F40C20", Slot = "6")]
		public FaceFeatureId HUQCZCRGBZI(string a)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public FDXCLGBHYTN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class QPAZYCJIMYI : ZFSMLUBFCCM<FaceShapeId>, WTZVETWARLM<FaceShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8F51E00", Offset = "0x8F50C00", VA = "0x188F51E00", Slot = "4")]
		public IEnumerable<(FaceShapeId, string)> ZJCQIFQPRJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB2C9D0", Offset = "0xB2B7D0", VA = "0x180B2C9D0", Slot = "5")]
		public string NDKKRQVUWMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8F40C20", Offset = "0x8F3FA20", VA = "0x188F40C20", Slot = "6")]
		public FaceShapeId HUQCZCRGBZI(string a)
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public QPAZYCJIMYI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class CIGKVOLZMRC : ZFSMLUBFCCM<HairPatternId>, WTZVETWARLM<HairPatternId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8F40CD0", Offset = "0x8F3FAD0", VA = "0x188F40CD0", Slot = "4")]
		public IEnumerable<(HairPatternId, string)> ZJCQIFQPRJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB2C9D0", Offset = "0xB2B7D0", VA = "0x180B2C9D0", Slot = "5")]
		public string NDKKRQVUWMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8F40C20", Offset = "0x8F3FA20", VA = "0x188F40C20", Slot = "6")]
		public HairPatternId HUQCZCRGBZI(string a)
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public CIGKVOLZMRC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface ZFSMLUBFCCM<a> : WTZVETWARLM<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<(a, string)> ZJCQIFQPRJN();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string NDKKRQVUWMF(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class LULALWSEQGH : ZFSMLUBFCCM<MaterialId>, WTZVETWARLM<MaterialId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8E95980", Offset = "0x8E94780", VA = "0x188E95980", Slot = "4")]
		public IEnumerable<(MaterialId, string)> ZJCQIFQPRJN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB2C9D0", Offset = "0xB2B7D0", VA = "0x180B2C9D0", Slot = "5")]
		public string NDKKRQVUWMF(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8F40C20", Offset = "0x8F3FA20", VA = "0x188F40C20", Slot = "6")]
		public MaterialId HUQCZCRGBZI(string a)
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		public LULALWSEQGH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class NURNLXUURHL<a> : XPNTWMODFOM<a>, WTZVETWARLM<a> where a : IEquatable<a>, NVQGEFUYTGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<a, string> VBYZEOLOIBS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Dictionary<string, a> QGLCDMEIOGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly ZFSMLUBFCCM<a> UCLAHYXVRHB;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x5A09F20", Offset = "0x5A08D20", VA = "0x185A09F20")]
		public NURNLXUURHL(ZFSMLUBFCCM<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5A09B90", Offset = "0x5A08990", VA = "0x185A09B90", Slot = "5")]
		public a HUQCZCRGBZI(string a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5A09E00", Offset = "0x5A08C00", VA = "0x185A09E00", Slot = "4")]
		public string MHTQDVEHNSS(a a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class JADSKUYNJJB : OBYGOLPQHAR
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private NURNLXUURHL<AvatarItemId> QGVHCGAUQDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private NURNLXUURHL<EquipmentSkinId> BNLRDBVRDNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private NURNLXUURHL<HairPatternId> NRTMVJHALMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private NURNLXUURHL<MaterialId> QHINBSPMYMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private NURNLXUURHL<CombinationId> FNMVPGZXFAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NURNLXUURHL<ColorId> OBFELYZZJBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NURNLXUURHL<FaceShapeId> BALTBRWFRAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private NURNLXUURHL<BodyShapeId> DOJWYHFNZMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private NURNLXUURHL<FaceFeatureId> VEBIDDEUXPI;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public XPNTWMODFOM<AvatarItemId> PJXFHGSNMYN
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xACA860", Offset = "0xAC9660", VA = "0x180ACA860", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public XPNTWMODFOM<EquipmentSkinId> AGZMDHBXIZQ
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAC91C0", Offset = "0xAC7FC0", VA = "0x180AC91C0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public XPNTWMODFOM<HairPatternId> OQADZPZDAXD
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xACEB70", Offset = "0xACD970", VA = "0x180ACEB70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public XPNTWMODFOM<CombinationId> VNLSNPEWORC
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xACC880", Offset = "0xACB680", VA = "0x180ACC880", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public XPNTWMODFOM<ColorId> QIAWUDZIRBW
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xACCC20", Offset = "0xACBA20", VA = "0x180ACCC20", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public XPNTWMODFOM<FaceShapeId> DDXYIPJYBEZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xACE6F0", Offset = "0xACD4F0", VA = "0x180ACE6F0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public XPNTWMODFOM<BodyShapeId> DUICDCKPZIW
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xACC850", Offset = "0xACB650", VA = "0x180ACC850", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public XPNTWMODFOM<FaceFeatureId> RWBJBFFLWQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAC63E0", Offset = "0xAC51E0", VA = "0x180AC63E0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8F4A820", Offset = "0x8F49620", VA = "0x188F4A820")]
		[AUEAKLYJEMA.Root.GameOnly]
		[UsedImplicitly]
		internal static void JAVWNHKOPGI(TNEKCCANHHI a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8F4A890", Offset = "0x8F49690", VA = "0x188F4A890")]
		[RecRoom.NoEngine.Common.Preserve]
		public JADSKUYNJJB()
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
