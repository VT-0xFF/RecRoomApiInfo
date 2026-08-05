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
		[Cpp2IlInjected.Address(RVA = "0xA3CC060", Offset = "0xA3CAA60", VA = "0x18A3CC060", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A16AE0", Offset = "0x2A154E0", VA = "0x182A16AE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class CPXUZBTKRLJ : NSEJPLSROWY
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Regex AFAHUGAXVHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly KJSSLRVSDKB FFKOLHXIAUM;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1080", Offset = "0xA3BFA80", VA = "0x18A3C1080")]
		[ONTQUCAGRJW.Root.GameOnly]
		[UsedImplicitly]
		internal static void ONTQUCAGRJW(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1430", Offset = "0xA3BFE30", VA = "0x18A3C1430")]
		[UsedImplicitly]
		internal static void WVHSDSASQMN(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		[RecRoom.NoEngine.Common.Preserve]
		public CPXUZBTKRLJ([Inject(null)] KJSSLRVSDKB runtimeMapperProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA3C10F0", Offset = "0xA3BFAF0", VA = "0x18A3C10F0", Slot = "4")]
		public string Serialize(AvatarItemDesc input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0BC0", Offset = "0xA3BF5C0", VA = "0x18A3C0BC0", Slot = "5")]
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
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, OGLKUHQWZMN
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
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220")]
		public AvatarItemId Deserialize()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770", Slot = "4")]
		public bool Equals(SerializedAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA6D0", Offset = "0xA3C90D0", VA = "0x18A3CA6D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA790", Offset = "0xA3C9190", VA = "0x18A3CA790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, OGLKUHQWZMN
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
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220")]
		public BodyShapeId Deserialize()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770", Slot = "4")]
		public bool Equals(SerializedBodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA800", Offset = "0xA3C9200", VA = "0x18A3CA800", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA8A0", Offset = "0xA3C92A0", VA = "0x18A3CA8A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, OGLKUHQWZMN
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
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220")]
		public ColorId Deserialize()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770", Slot = "4")]
		public bool Equals(SerializedColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA910", Offset = "0xA3C9310", VA = "0x18A3CA910", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA9B0", Offset = "0xA3C93B0", VA = "0x18A3CA9B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, OGLKUHQWZMN, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF2A7E0", Offset = "0xF291E0", VA = "0x180F2A7E0")]
		public CombinationId Deserialize()
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA257D20", Offset = "0xA256720", VA = "0x18A257D20", Slot = "4")]
		public bool Equals(SerializedCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAA20", Offset = "0xA3C9420", VA = "0x18A3CAA20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedCombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAAE0", Offset = "0xA3C94E0", VA = "0x18A3CAAE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD0A4C0", Offset = "0xD08EC0", VA = "0x180D0A4C0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAAD0", Offset = "0xA3C94D0", VA = "0x18A3CAAD0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, OGLKUHQWZMN
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
		public bool GFOEGTWSQZD
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA3CAC10", Offset = "0xA3C9610", VA = "0x18A3CAC10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x154D400", Offset = "0x154BE00", VA = "0x18154D400")]
		public SerializedCustomAvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220")]
		public static SerializedCustomAvatarItemId TRPQHDIZKEJ(Guid a)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAB50", Offset = "0xA3C9550", VA = "0x18A3CAB50", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770")]
		public static bool OTUOIXXRZSY(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CABF0", Offset = "0xA3C95F0", VA = "0x18A3CABF0")]
		public static bool JSGIPYLAFHN(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAC70", Offset = "0xA3C9670", VA = "0x18A3CAC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, OGLKUHQWZMN
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
		[Cpp2IlInjected.Address(RVA = "0xA3CAD80", Offset = "0xA3C9780", VA = "0x18A3CAD80")]
		public static SerializedEquipmentSkinId NTNUOLKTPET()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220")]
		public EquipmentSkinId Deserialize()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA3CACE0", Offset = "0xA3C96E0", VA = "0x18A3CACE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA3CADB0", Offset = "0xA3C97B0", VA = "0x18A3CADB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, OGLKUHQWZMN
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
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220")]
		public FaceFeatureId Deserialize()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAE20", Offset = "0xA3C9820", VA = "0x18A3CAE20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAEC0", Offset = "0xA3C98C0", VA = "0x18A3CAEC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, OGLKUHQWZMN
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
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220")]
		public FaceShapeId Deserialize()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770", Slot = "4")]
		public bool Equals(SerializedFaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAF30", Offset = "0xA3C9930", VA = "0x18A3CAF30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA3CAFD0", Offset = "0xA3C99D0", VA = "0x18A3CAFD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, OGLKUHQWZMN
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
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220")]
		public HairPatternId Deserialize()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770", Slot = "4")]
		public bool Equals(SerializedHairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedHairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB040", Offset = "0xA3C9A40", VA = "0x18A3CB040", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA770", Offset = "0xA3C9170", VA = "0x18A3CA770")]
		public static bool OTUOIXXRZSY(SerializedHairPatternId a, SerializedHairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB0E0", Offset = "0xA3C9AE0", VA = "0x18A3CB0E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, OGLKUHQWZMN
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
		[Cpp2IlInjected.Address(RVA = "0xDD1220", Offset = "0xDCFC20", VA = "0x180DD1220", Slot = "6")]
		public Guid JGYQFEXULHX()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA257D20", Offset = "0xA256720", VA = "0x18A257D20", Slot = "4")]
		public bool Equals(SerializedMaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB150", Offset = "0xA3C9B50", VA = "0x18A3CB150", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9802FB0", Offset = "0x98019B0", VA = "0x189802FB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9802E20", Offset = "0x9801820", VA = "0x189802E20", Slot = "5")]
		public int CompareTo(SerializedMaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB1F0", Offset = "0xA3C9BF0", VA = "0x18A3CB1F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class ZYKDPBMXBJN : KJSSLRVSDKB
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static ZYKDPBMXBJN IWMDTGRRYAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA3CBE30", Offset = "0xA3CA830", VA = "0x18A3CBE30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BCENNHMJVRK<AvatarItemId> PNTJDDTYGLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA3CC010", Offset = "0xA3CAA10", VA = "0x18A3CC010", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public BCENNHMJVRK<EquipmentSkinId> SNSBLSAVHYK
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA3CBF70", Offset = "0xA3CA970", VA = "0x18A3CBF70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public BCENNHMJVRK<HairPatternId> KKWRBTDGHUB
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA3CBE80", Offset = "0xA3CA880", VA = "0x18A3CBE80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public BCENNHMJVRK<CombinationId> PSMTFPWCUYY
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA3CBF20", Offset = "0xA3CA920", VA = "0x18A3CBF20", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public BCENNHMJVRK<ColorId> EIZDYPEQQJG
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA3CBD90", Offset = "0xA3CA790", VA = "0x18A3CBD90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BCENNHMJVRK<FaceShapeId> WWUZRHGWSUR
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA3CBFC0", Offset = "0xA3CA9C0", VA = "0x18A3CBFC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BCENNHMJVRK<BodyShapeId> GJUNRCVWDNQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA3CBED0", Offset = "0xA3CA8D0", VA = "0x18A3CBED0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BCENNHMJVRK<FaceFeatureId> YKNPAWWXJZA
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA3CBDE0", Offset = "0xA3CA7E0", VA = "0x18A3CBDE0", Slot = "11")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class RLPQHTMKWCU
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA550", Offset = "0xA3C8F50", VA = "0x18A3CA550")]
		public static Guid SFOBPJGNQIL(string a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA600", Offset = "0xA3C9000", VA = "0x18A3CA600")]
		public static bool UHOISVLTFML(string a, [Out] Guid b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class KUXLDXKJSME : EDQXMXBSLFW<AvatarItemId>, HGRLZWGQDDA<AvatarItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5560", Offset = "0xA3C3F60", VA = "0x18A3C5560", Slot = "4")]
		public IEnumerable<(AvatarItemId, string)> DMUKERTQNVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5540", Offset = "0xA3C3F40", VA = "0x18A3C5540", Slot = "5")]
		public string ABOMGGAREAZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B10", Offset = "0xA3BF510", VA = "0x18A3C0B10", Slot = "6")]
		public AvatarItemId DOTSORMNZIG(string a)
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public KUXLDXKJSME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class MLGVQNJXIWT : EDQXMXBSLFW<BodyShapeId>, HGRLZWGQDDA<BodyShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA3CA1B0", Offset = "0xA3C8BB0", VA = "0x18A3CA1B0", Slot = "4")]
		public IEnumerable<(BodyShapeId, string)> DMUKERTQNVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5E0", Offset = "0xD6DFE0", VA = "0x180D6F5E0", Slot = "5")]
		public string ABOMGGAREAZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B10", Offset = "0xA3BF510", VA = "0x18A3C0B10", Slot = "6")]
		public BodyShapeId DOTSORMNZIG(string a)
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public MLGVQNJXIWT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CXBIVQEUYLT : EDQXMXBSLFW<ColorId>, HGRLZWGQDDA<ColorId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA3C1520", Offset = "0xA3BFF20", VA = "0x18A3C1520", Slot = "4")]
		public IEnumerable<(ColorId, string)> DMUKERTQNVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5E0", Offset = "0xD6DFE0", VA = "0x180D6F5E0", Slot = "5")]
		public string ABOMGGAREAZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B10", Offset = "0xA3BF510", VA = "0x18A3C0B10", Slot = "6")]
		public ColorId DOTSORMNZIG(string a)
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public CXBIVQEUYLT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class KQAZVUSIAAJ : EDQXMXBSLFW<CombinationId>, HGRLZWGQDDA<CombinationId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HGRLZWGQDDA<MaterialId> ZMVJLRJCAWK;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xD13870", Offset = "0xD12270", VA = "0x180D13870")]
		public KQAZVUSIAAJ(HGRLZWGQDDA<MaterialId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA258B40", Offset = "0xA257540", VA = "0x18A258B40", Slot = "4")]
		public IEnumerable<(CombinationId, string)> DMUKERTQNVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C5300", Offset = "0xA3C3D00", VA = "0x18A3C5300", Slot = "6")]
		public CombinationId DOTSORMNZIG(string a)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA3C52C0", Offset = "0xA3C3CC0", VA = "0x18A3C52C0", Slot = "5")]
		public string ABOMGGAREAZ(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class AUXTDUQBOGL : EDQXMXBSLFW<EquipmentSkinId>, HGRLZWGQDDA<EquipmentSkinId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA3B8F00", Offset = "0xA3B7900", VA = "0x18A3B8F00", Slot = "4")]
		public IEnumerable<(EquipmentSkinId, string)> DMUKERTQNVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5E0", Offset = "0xD6DFE0", VA = "0x180D6F5E0", Slot = "5")]
		public string ABOMGGAREAZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B10", Offset = "0xA3BF510", VA = "0x18A3C0B10", Slot = "6")]
		public EquipmentSkinId DOTSORMNZIG(string a)
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public AUXTDUQBOGL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class HJZQFOTNQOL : EDQXMXBSLFW<FaceFeatureId>, HGRLZWGQDDA<FaceFeatureId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3C3A00", Offset = "0xA3C2400", VA = "0x18A3C3A00", Slot = "4")]
		public IEnumerable<(FaceFeatureId, string)> DMUKERTQNVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5E0", Offset = "0xD6DFE0", VA = "0x180D6F5E0", Slot = "5")]
		public string ABOMGGAREAZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B10", Offset = "0xA3BF510", VA = "0x18A3C0B10", Slot = "6")]
		public FaceFeatureId DOTSORMNZIG(string a)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public HJZQFOTNQOL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class EEIUMOPWTNW : EDQXMXBSLFW<FaceShapeId>, HGRLZWGQDDA<FaceShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA3C35E0", Offset = "0xA3C1FE0", VA = "0x18A3C35E0", Slot = "4")]
		public IEnumerable<(FaceShapeId, string)> DMUKERTQNVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5E0", Offset = "0xD6DFE0", VA = "0x180D6F5E0", Slot = "5")]
		public string ABOMGGAREAZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B10", Offset = "0xA3BF510", VA = "0x18A3C0B10", Slot = "6")]
		public FaceShapeId DOTSORMNZIG(string a)
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public EEIUMOPWTNW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class UJZPETPTDPO : EDQXMXBSLFW<HairPatternId>, HGRLZWGQDDA<HairPatternId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB710", Offset = "0xA3CA110", VA = "0x18A3CB710", Slot = "4")]
		public IEnumerable<(HairPatternId, string)> DMUKERTQNVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5E0", Offset = "0xD6DFE0", VA = "0x180D6F5E0", Slot = "5")]
		public string ABOMGGAREAZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B10", Offset = "0xA3BF510", VA = "0x18A3C0B10", Slot = "6")]
		public HairPatternId DOTSORMNZIG(string a)
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public UJZPETPTDPO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface EDQXMXBSLFW<a> : HGRLZWGQDDA<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<(a, string)> DMUKERTQNVB();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string ABOMGGAREAZ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class DIYAMVQVEKT : EDQXMXBSLFW<MaterialId>, HGRLZWGQDDA<MaterialId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA30DC60", Offset = "0xA30C660", VA = "0x18A30DC60", Slot = "4")]
		public IEnumerable<(MaterialId, string)> DMUKERTQNVB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xD6F5E0", Offset = "0xD6DFE0", VA = "0x180D6F5E0", Slot = "5")]
		public string ABOMGGAREAZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3C0B10", Offset = "0xA3BF510", VA = "0x18A3C0B10", Slot = "6")]
		public MaterialId DOTSORMNZIG(string a)
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
		public DIYAMVQVEKT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class BWCPWVETPNT<a> : BCENNHMJVRK<a>, HGRLZWGQDDA<a> where a : IEquatable<a>, OGLKUHQWZMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<a, string> WCBAFWHYYXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Dictionary<string, a> FRNSUIOSSFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly EDQXMXBSLFW<a> GFCVMKUACSD;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x4F125D0", Offset = "0x4F10FD0", VA = "0x184F125D0")]
		public BWCPWVETPNT(EDQXMXBSLFW<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x4F0FDB0", Offset = "0x4F0E7B0", VA = "0x184F0FDB0", Slot = "5")]
		public a DOTSORMNZIG(string a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4F10380", Offset = "0x4F0ED80", VA = "0x184F10380", Slot = "4")]
		public string QAIDCZYXHZQ(a a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class TKVUXJMTREH : KJSSLRVSDKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private BWCPWVETPNT<AvatarItemId> JMCAWIZOOLT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private BWCPWVETPNT<EquipmentSkinId> UZDNZZDZJIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private BWCPWVETPNT<HairPatternId> BXJWUAOXIFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private BWCPWVETPNT<MaterialId> ZMVJLRJCAWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private BWCPWVETPNT<CombinationId> CQOFXVZUKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private BWCPWVETPNT<ColorId> QMJNWCWCKZO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private BWCPWVETPNT<FaceShapeId> NNEPWFWSRMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private BWCPWVETPNT<BodyShapeId> SVMMCTZBEWK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private BWCPWVETPNT<FaceFeatureId> GPPMDVCBGIW;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BCENNHMJVRK<AvatarItemId> PNTJDDTYGLD
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCC0", Offset = "0xD0B6C0", VA = "0x180D0CCC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BCENNHMJVRK<EquipmentSkinId> SNSBLSAVHYK
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xD11A70", Offset = "0xD10470", VA = "0x180D11A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BCENNHMJVRK<HairPatternId> KKWRBTDGHUB
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCB0", Offset = "0xD0B6B0", VA = "0x180D0CCB0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BCENNHMJVRK<CombinationId> PSMTFPWCUYY
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xD0CCD0", Offset = "0xD0B6D0", VA = "0x180D0CCD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BCENNHMJVRK<ColorId> EIZDYPEQQJG
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD14330", Offset = "0xD12D30", VA = "0x180D14330", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BCENNHMJVRK<FaceShapeId> WWUZRHGWSUR
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD14260", Offset = "0xD12C60", VA = "0x180D14260", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BCENNHMJVRK<BodyShapeId> GJUNRCVWDNQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD10CF0", Offset = "0xD0F6F0", VA = "0x180D10CF0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public BCENNHMJVRK<FaceFeatureId> YKNPAWWXJZA
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD0E930", Offset = "0xD0D330", VA = "0x180D0E930", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB260", Offset = "0xA3C9C60", VA = "0x18A3CB260")]
		[ONTQUCAGRJW.Root.GameOnly]
		[UsedImplicitly]
		internal static void YITSWWEJPVO(KLUMUBWDFVY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA3CB2D0", Offset = "0xA3C9CD0", VA = "0x18A3CB2D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public TKVUXJMTREH()
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
