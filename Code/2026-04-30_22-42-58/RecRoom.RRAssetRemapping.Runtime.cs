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
		[Cpp2IlInjected.Address(RVA = "0xA1C0500", Offset = "0xA1BF900", VA = "0x18A1C0500", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x29FCDD0", Offset = "0x29FC1D0", VA = "0x1829FCDD0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class NXNRYMJMPXL : RJUWTNXTRHI
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Regex QQPFLACLMAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly LMTDDQUYOYX MQDLOJPXENU;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC670", Offset = "0xA1BBA70", VA = "0x18A1BC670")]
		[BQDQKYYGTTM.Root.GameOnly]
		[UsedImplicitly]
		internal static void BQDQKYYGTTM(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA1BCEF0", Offset = "0xA1BC2F0", VA = "0x18A1BCEF0")]
		[UsedImplicitly]
		internal static void VNUUEZIIQDJ(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		[RecRoom.NoEngine.Common.Preserve]
		public NXNRYMJMPXL([Inject(null)] LMTDDQUYOYX runtimeMapperProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1BCBB0", Offset = "0xA1BBFB0", VA = "0x18A1BCBB0", Slot = "4")]
		public string Serialize(AvatarItemDesc input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1BC6E0", Offset = "0xA1BBAE0", VA = "0x18A1BC6E0", Slot = "5")]
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
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, CHXXZBQJFDN
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
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public AvatarItemId Deserialize()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDF30", Offset = "0xA1BD330", VA = "0x18A1BDF30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFF0", Offset = "0xA1BD3F0", VA = "0x18A1BDFF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, CHXXZBQJFDN
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
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public BodyShapeId Deserialize()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE060", Offset = "0xA1BD460", VA = "0x18A1BE060", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE100", Offset = "0xA1BD500", VA = "0x18A1BE100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, CHXXZBQJFDN
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
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public ColorId Deserialize()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0", Slot = "4")]
		public bool Equals(SerializedColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE170", Offset = "0xA1BD570", VA = "0x18A1BE170", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE210", Offset = "0xA1BD610", VA = "0x18A1BE210", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, CHXXZBQJFDN, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF151B0", Offset = "0xF145B0", VA = "0x180F151B0")]
		public CombinationId Deserialize()
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA04C080", Offset = "0xA04B480", VA = "0x18A04C080", Slot = "4")]
		public bool Equals(SerializedCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE280", Offset = "0xA1BD680", VA = "0x18A1BE280", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedCombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE340", Offset = "0xA1BD740", VA = "0x18A1BE340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE330", Offset = "0xA1BD730", VA = "0x18A1BE330", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, CHXXZBQJFDN
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
		public bool OMTUQXOFEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA1BE4E0", Offset = "0xA1BD8E0", VA = "0x18A1BE4E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x15214C0", Offset = "0x15208C0", VA = "0x1815214C0")]
		public SerializedCustomAvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public static SerializedCustomAvatarItemId NZZTGVZRQBB(Guid a)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE3D0", Offset = "0xA1BD7D0", VA = "0x18A1BE3D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0")]
		public static bool VPGVCSNEDTU(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE3B0", Offset = "0xA1BD7B0", VA = "0x18A1BE3B0")]
		public static bool AIMXGJJQCKF(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE470", Offset = "0xA1BD870", VA = "0x18A1BE470", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, CHXXZBQJFDN
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
		[Cpp2IlInjected.Address(RVA = "0xA1BE5E0", Offset = "0xA1BD9E0", VA = "0x18A1BE5E0")]
		public static SerializedEquipmentSkinId FQHIAUYLJUZ()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public EquipmentSkinId Deserialize()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE540", Offset = "0xA1BD940", VA = "0x18A1BE540", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE610", Offset = "0xA1BDA10", VA = "0x18A1BE610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, CHXXZBQJFDN
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
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public FaceFeatureId Deserialize()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE680", Offset = "0xA1BDA80", VA = "0x18A1BE680", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE720", Offset = "0xA1BDB20", VA = "0x18A1BE720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, CHXXZBQJFDN
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
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public FaceShapeId Deserialize()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE790", Offset = "0xA1BDB90", VA = "0x18A1BE790", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE830", Offset = "0xA1BDC30", VA = "0x18A1BE830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, CHXXZBQJFDN
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
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400")]
		public HairPatternId Deserialize()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0", Slot = "4")]
		public bool Equals(SerializedHairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedHairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE8A0", Offset = "0xA1BDCA0", VA = "0x18A1BE8A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDFD0", Offset = "0xA1BD3D0", VA = "0x18A1BDFD0")]
		public static bool VPGVCSNEDTU(SerializedHairPatternId a, SerializedHairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE940", Offset = "0xA1BDD40", VA = "0x18A1BE940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, CHXXZBQJFDN
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
		[Cpp2IlInjected.Address(RVA = "0x12C9400", Offset = "0x12C8800", VA = "0x1812C9400", Slot = "6")]
		public Guid YULQDUGBQGP()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA04C080", Offset = "0xA04B480", VA = "0x18A04C080", Slot = "4")]
		public bool Equals(SerializedMaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE9B0", Offset = "0xA1BDDB0", VA = "0x18A1BE9B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x95FD190", Offset = "0x95FC590", VA = "0x1895FD190", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x95FD000", Offset = "0x95FC400", VA = "0x1895FD000", Slot = "5")]
		public int CompareTo(SerializedMaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEA50", Offset = "0xA1BDE50", VA = "0x18A1BEA50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class BVMCGRECXDT : LMTDDQUYOYX
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static BVMCGRECXDT LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA1B2470", Offset = "0xA1B1870", VA = "0x18A1B2470")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BQMUUIWNQLM<AvatarItemId> PQYCMVKTDAT
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA1B25B0", Offset = "0xA1B19B0", VA = "0x18A1B25B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public BQMUUIWNQLM<EquipmentSkinId> VVOUOEKBOEY
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA1B2420", Offset = "0xA1B1820", VA = "0x18A1B2420", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public BQMUUIWNQLM<HairPatternId> RYCKANJWAPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA1B23D0", Offset = "0xA1B17D0", VA = "0x18A1B23D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public BQMUUIWNQLM<CombinationId> TQEEVUXSEXU
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA1B2330", Offset = "0xA1B1730", VA = "0x18A1B2330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public BQMUUIWNQLM<ColorId> IPCMYBNMGAK
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA1B2380", Offset = "0xA1B1780", VA = "0x18A1B2380", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public BQMUUIWNQLM<FaceShapeId> FZSZANAURHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA1B2510", Offset = "0xA1B1910", VA = "0x18A1B2510", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public BQMUUIWNQLM<BodyShapeId> ONFKRODHXUA
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA1B24C0", Offset = "0xA1B18C0", VA = "0x18A1B24C0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public BQMUUIWNQLM<FaceFeatureId> VZEIRXMJTLW
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA1B2560", Offset = "0xA1B1960", VA = "0x18A1B2560", Slot = "11")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class XJGWTITTCBI
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEAC0", Offset = "0xA1BDEC0", VA = "0x18A1BEAC0")]
		public static Guid DZQZOZEMVLT(string a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEB70", Offset = "0xA1BDF70", VA = "0x18A1BEB70")]
		public static bool NYIJGCENVDH(string a, [Out] Guid b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class BSABKYDRJQO : GSQAOMFBPYO<AvatarItemId>, KIEHURZTEFC<AvatarItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA1AD630", Offset = "0xA1ACA30", VA = "0x18A1AD630", Slot = "4")]
		public IEnumerable<(AvatarItemId, string)> CNHNXTNWUUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA1AD610", Offset = "0xA1ACA10", VA = "0x18A1AD610", Slot = "5")]
		public string AAQZIZSKUXB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2280", Offset = "0xA1B1680", VA = "0x18A1B2280", Slot = "6")]
		public AvatarItemId VXTZWTANNVO(string a)
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public BSABKYDRJQO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class CVUCJHIYWVT : GSQAOMFBPYO<BodyShapeId>, KIEHURZTEFC<BodyShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA1B46C0", Offset = "0xA1B3AC0", VA = "0x18A1B46C0", Slot = "4")]
		public IEnumerable<(BodyShapeId, string)> CNHNXTNWUUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD59C20", Offset = "0xD59020", VA = "0x180D59C20", Slot = "5")]
		public string AAQZIZSKUXB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2280", Offset = "0xA1B1680", VA = "0x18A1B2280", Slot = "6")]
		public BodyShapeId VXTZWTANNVO(string a)
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public CVUCJHIYWVT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class CNDDOXGLZHZ : GSQAOMFBPYO<ColorId>, KIEHURZTEFC<ColorId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2600", Offset = "0xA1B1A00", VA = "0x18A1B2600", Slot = "4")]
		public IEnumerable<(ColorId, string)> CNHNXTNWUUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD59C20", Offset = "0xD59020", VA = "0x180D59C20", Slot = "5")]
		public string AAQZIZSKUXB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2280", Offset = "0xA1B1680", VA = "0x18A1B2280", Slot = "6")]
		public ColorId VXTZWTANNVO(string a)
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public CNDDOXGLZHZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class ADACQIRPDIP : GSQAOMFBPYO<CombinationId>, KIEHURZTEFC<CombinationId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly KIEHURZTEFC<MaterialId> WJUPWTJNLWQ;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xD01400", Offset = "0xD00800", VA = "0x180D01400")]
		public ADACQIRPDIP(KIEHURZTEFC<MaterialId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA04CFD0", Offset = "0xA04C3D0", VA = "0x18A04CFD0", Slot = "4")]
		public IEnumerable<(CombinationId, string)> CNHNXTNWUUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA1AD3D0", Offset = "0xA1AC7D0", VA = "0x18A1AD3D0", Slot = "6")]
		public CombinationId VXTZWTANNVO(string a)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA1AD390", Offset = "0xA1AC790", VA = "0x18A1AD390", Slot = "5")]
		public string AAQZIZSKUXB(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class JIEVXOAAKNH : GSQAOMFBPYO<EquipmentSkinId>, KIEHURZTEFC<EquipmentSkinId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4A60", Offset = "0xA1B3E60", VA = "0x18A1B4A60", Slot = "4")]
		public IEnumerable<(EquipmentSkinId, string)> CNHNXTNWUUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD59C20", Offset = "0xD59020", VA = "0x180D59C20", Slot = "5")]
		public string AAQZIZSKUXB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2280", Offset = "0xA1B1680", VA = "0x18A1B2280", Slot = "6")]
		public EquipmentSkinId VXTZWTANNVO(string a)
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public JIEVXOAAKNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class YFMCSEYHKGN : GSQAOMFBPYO<FaceFeatureId>, KIEHURZTEFC<FaceFeatureId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA1BEC40", Offset = "0xA1BE040", VA = "0x18A1BEC40", Slot = "4")]
		public IEnumerable<(FaceFeatureId, string)> CNHNXTNWUUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xD59C20", Offset = "0xD59020", VA = "0x180D59C20", Slot = "5")]
		public string AAQZIZSKUXB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2280", Offset = "0xA1B1680", VA = "0x18A1B2280", Slot = "6")]
		public FaceFeatureId VXTZWTANNVO(string a)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public YFMCSEYHKGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class SKPNQTKQQZI : GSQAOMFBPYO<FaceShapeId>, KIEHURZTEFC<FaceShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA1BDB10", Offset = "0xA1BCF10", VA = "0x18A1BDB10", Slot = "4")]
		public IEnumerable<(FaceShapeId, string)> CNHNXTNWUUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD59C20", Offset = "0xD59020", VA = "0x180D59C20", Slot = "5")]
		public string AAQZIZSKUXB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2280", Offset = "0xA1B1680", VA = "0x18A1B2280", Slot = "6")]
		public FaceShapeId VXTZWTANNVO(string a)
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public SKPNQTKQQZI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class NZCJBFSFEMG : GSQAOMFBPYO<HairPatternId>, KIEHURZTEFC<HairPatternId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA1BCFE0", Offset = "0xA1BC3E0", VA = "0x18A1BCFE0", Slot = "4")]
		public IEnumerable<(HairPatternId, string)> CNHNXTNWUUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xD59C20", Offset = "0xD59020", VA = "0x180D59C20", Slot = "5")]
		public string AAQZIZSKUXB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2280", Offset = "0xA1B1680", VA = "0x18A1B2280", Slot = "6")]
		public HairPatternId VXTZWTANNVO(string a)
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public NZCJBFSFEMG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface GSQAOMFBPYO<a> : KIEHURZTEFC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<(a, string)> CNHNXTNWUUN();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string AAQZIZSKUXB(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PALUWXAMMXL : GSQAOMFBPYO<MaterialId>, KIEHURZTEFC<MaterialId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA1020F0", Offset = "0xA1014F0", VA = "0x18A1020F0", Slot = "4")]
		public IEnumerable<(MaterialId, string)> CNHNXTNWUUN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xD59C20", Offset = "0xD59020", VA = "0x180D59C20", Slot = "5")]
		public string AAQZIZSKUXB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2280", Offset = "0xA1B1680", VA = "0x18A1B2280", Slot = "6")]
		public MaterialId VXTZWTANNVO(string a)
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		public PALUWXAMMXL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class DGPQXOSMMWP<a> : BQMUUIWNQLM<a>, KIEHURZTEFC<a> where a : IEquatable<a>, CHXXZBQJFDN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<a, string> SJYQRUMUJRA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Dictionary<string, a> PBQFGLFNPLI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly GSQAOMFBPYO<a> XZKVVSWZYRD;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x53346A0", Offset = "0x5333AA0", VA = "0x1853346A0")]
		public DGPQXOSMMWP(GSQAOMFBPYO<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x53327F0", Offset = "0x5331BF0", VA = "0x1853327F0", Slot = "5")]
		public a VXTZWTANNVO(string a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x53324C0", Offset = "0x53318C0", VA = "0x1853324C0", Slot = "4")]
		public string UQKFWNXPNDO(a a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class QMEGDDMUPCZ : LMTDDQUYOYX
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private DGPQXOSMMWP<AvatarItemId> IRRFBTRERNR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private DGPQXOSMMWP<EquipmentSkinId> BDQHUTCCNTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private DGPQXOSMMWP<HairPatternId> FJGRUQTYHGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private DGPQXOSMMWP<MaterialId> WJUPWTJNLWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private DGPQXOSMMWP<CombinationId> OOSGCZXFUTE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private DGPQXOSMMWP<ColorId> OSOTLSTXAAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private DGPQXOSMMWP<FaceShapeId> SHEYYRWMOIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private DGPQXOSMMWP<BodyShapeId> CJNVGSKVIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private DGPQXOSMMWP<FaceFeatureId> IXIHIBREUEA;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public BQMUUIWNQLM<AvatarItemId> PQYCMVKTDAT
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public BQMUUIWNQLM<EquipmentSkinId> VVOUOEKBOEY
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CD0", Offset = "0xCF40D0", VA = "0x180CF4CD0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public BQMUUIWNQLM<HairPatternId> RYCKANJWAPN
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public BQMUUIWNQLM<CombinationId> TQEEVUXSEXU
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C60", Offset = "0xCF4060", VA = "0x180CF4C60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public BQMUUIWNQLM<ColorId> IPCMYBNMGAK
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public BQMUUIWNQLM<FaceShapeId> FZSZANAURHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DB0", Offset = "0xCF41B0", VA = "0x180CF4DB0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public BQMUUIWNQLM<BodyShapeId> ONFKRODHXUA
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xCF5500", Offset = "0xCF4900", VA = "0x180CF5500", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public BQMUUIWNQLM<FaceFeatureId> VZEIRXMJTLW
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xCF4DF0", Offset = "0xCF41F0", VA = "0x180CF4DF0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD660", Offset = "0xA1BCA60", VA = "0x18A1BD660")]
		[BQDQKYYGTTM.Root.GameOnly]
		[UsedImplicitly]
		internal static void WDKFBDGKYRM(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA1BD6D0", Offset = "0xA1BCAD0", VA = "0x18A1BD6D0")]
		[RecRoom.NoEngine.Common.Preserve]
		public QMEGDDMUPCZ()
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
