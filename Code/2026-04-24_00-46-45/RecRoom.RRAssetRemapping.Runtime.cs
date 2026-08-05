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
		[Cpp2IlInjected.Address(RVA = "0xA4012B0", Offset = "0xA3FFCB0", VA = "0x18A4012B0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2A2E140", Offset = "0x2A2CB40", VA = "0x182A2E140")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class MVRUHGOKZAR : AQCBHTVLMCW
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Regex PDKVQCZWXGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly UMTIQQCLLAD AFEZWNCRZRA;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA3F9FE0", Offset = "0xA3F89E0", VA = "0x18A3F9FE0")]
		[BRMSZAJTATI.Root.GameOnly]
		[UsedImplicitly]
		internal static void BRMSZAJTATI(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA860", Offset = "0xA3F9260", VA = "0x18A3FA860")]
		[UsedImplicitly]
		internal static void VIVLFHBGNKH(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		[RecRoom.NoEngine.Common.Preserve]
		public MVRUHGOKZAR([Inject(null)] UMTIQQCLLAD runtimeMapperProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA520", Offset = "0xA3F8F20", VA = "0x18A3FA520", Slot = "4")]
		public string Serialize(AvatarItemDesc input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA050", Offset = "0xA3F8A50", VA = "0x18A3FA050", Slot = "5")]
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
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, RJEIXZTKTCP
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
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public AvatarItemId Deserialize()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA400710", Offset = "0xA3FF110", VA = "0x18A400710", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0xA4007D0", Offset = "0xA3FF1D0", VA = "0x18A4007D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, RJEIXZTKTCP
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
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public BodyShapeId Deserialize()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA400840", Offset = "0xA3FF240", VA = "0x18A400840", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA4008E0", Offset = "0xA3FF2E0", VA = "0x18A4008E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, RJEIXZTKTCP
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
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public ColorId Deserialize()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0", Slot = "4")]
		public bool Equals(SerializedColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA400950", Offset = "0xA3FF350", VA = "0x18A400950", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA4009F0", Offset = "0xA3FF3F0", VA = "0x18A4009F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, RJEIXZTKTCP, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF35A80", Offset = "0xF34480", VA = "0x180F35A80")]
		public CombinationId Deserialize()
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA28CDC0", Offset = "0xA28B7C0", VA = "0x18A28CDC0", Slot = "4")]
		public bool Equals(SerializedCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA400A60", Offset = "0xA3FF460", VA = "0x18A400A60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedCombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0xA400B20", Offset = "0xA3FF520", VA = "0x18A400B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA400B10", Offset = "0xA3FF510", VA = "0x18A400B10", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, RJEIXZTKTCP
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
		public bool RQLJIMEKAHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0xA400B90", Offset = "0xA3FF590", VA = "0x18A400B90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1546FD0", Offset = "0x15459D0", VA = "0x181546FD0")]
		public SerializedCustomAvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public static SerializedCustomAvatarItemId GISNPOCMMED(Guid a)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA400C10", Offset = "0xA3FF610", VA = "0x18A400C10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0")]
		public static bool SHHUBVCQRYC(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA400BF0", Offset = "0xA3FF5F0", VA = "0x18A400BF0")]
		public static bool ENWYWLXFHXP(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0xA400CB0", Offset = "0xA3FF6B0", VA = "0x18A400CB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, RJEIXZTKTCP
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
		[Cpp2IlInjected.Address(RVA = "0xA400E30", Offset = "0xA3FF830", VA = "0x18A400E30")]
		public static SerializedEquipmentSkinId WVBBLDDLGRL()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public EquipmentSkinId Deserialize()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0xA400D20", Offset = "0xA3FF720", VA = "0x18A400D20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xA400DC0", Offset = "0xA3FF7C0", VA = "0x18A400DC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, RJEIXZTKTCP
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
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public FaceFeatureId Deserialize()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xA400E60", Offset = "0xA3FF860", VA = "0x18A400E60", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA400F00", Offset = "0xA3FF900", VA = "0x18A400F00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, RJEIXZTKTCP
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
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public FaceShapeId Deserialize()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA400F70", Offset = "0xA3FF970", VA = "0x18A400F70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA401010", Offset = "0xA3FFA10", VA = "0x18A401010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, RJEIXZTKTCP
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
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0")]
		public HairPatternId Deserialize()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0", Slot = "4")]
		public bool Equals(SerializedHairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedHairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA401080", Offset = "0xA3FFA80", VA = "0x18A401080", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA4007B0", Offset = "0xA3FF1B0", VA = "0x18A4007B0")]
		public static bool SHHUBVCQRYC(SerializedHairPatternId a, SerializedHairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA401120", Offset = "0xA3FFB20", VA = "0x18A401120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, RJEIXZTKTCP
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
		[Cpp2IlInjected.Address(RVA = "0x12ECCF0", Offset = "0x12EB6F0", VA = "0x1812ECCF0", Slot = "6")]
		public Guid CAJIFQLNWQL()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0xA28CDC0", Offset = "0xA28B7C0", VA = "0x18A28CDC0", Slot = "4")]
		public bool Equals(SerializedMaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0xA401190", Offset = "0xA3FFB90", VA = "0x18A401190", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9828EC0", Offset = "0x98278C0", VA = "0x189828EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9828D30", Offset = "0x9827730", VA = "0x189828D30", Slot = "5")]
		public int CompareTo(SerializedMaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xA401240", Offset = "0xA3FFC40", VA = "0x18A401240", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CZJDVAHCRGV : UMTIQQCLLAD
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static CZJDVAHCRGV UIOXUQVVXGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFCD0", Offset = "0xA3EE6D0", VA = "0x18A3EFCD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RVMVPQNDFZE<AvatarItemId> HWXKYVFIWQH
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFB90", Offset = "0xA3EE590", VA = "0x18A3EFB90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RVMVPQNDFZE<EquipmentSkinId> VLGSARDSTBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFD20", Offset = "0xA3EE720", VA = "0x18A3EFD20", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public RVMVPQNDFZE<HairPatternId> QSYYJWGBSCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFB40", Offset = "0xA3EE540", VA = "0x18A3EFB40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public RVMVPQNDFZE<CombinationId> SKGGRQFBLDA
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFAA0", Offset = "0xA3EE4A0", VA = "0x18A3EFAA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public RVMVPQNDFZE<ColorId> IJTFLUFMXBE
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFC30", Offset = "0xA3EE630", VA = "0x18A3EFC30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public RVMVPQNDFZE<FaceShapeId> USVSNYZOMIX
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFBE0", Offset = "0xA3EE5E0", VA = "0x18A3EFBE0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public RVMVPQNDFZE<BodyShapeId> HVLXDFSOWBC
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFC80", Offset = "0xA3EE680", VA = "0x18A3EFC80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public RVMVPQNDFZE<FaceFeatureId> JRUDLVQABWQ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA3EFAF0", Offset = "0xA3EE4F0", VA = "0x18A3EFAF0", Slot = "11")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class GXGWKDOQNYW
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1F00", Offset = "0xA3F0900", VA = "0x18A3F1F00")]
		public static Guid WBLCZSYRDRP(string a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1E30", Offset = "0xA3F0830", VA = "0x18A3F1E30")]
		public static bool HFGIXACLMXL(string a, [Out] Guid b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class SIDVMOZCQQC : KWENJCKHAAS<AvatarItemId>, ACCUDNQYGCY<AvatarItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA3FBAA0", Offset = "0xA3FA4A0", VA = "0x18A3FBAA0", Slot = "4")]
		public IEnumerable<(AvatarItemId, string)> WJQNPPONEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA4006F0", Offset = "0xA3FF0F0", VA = "0x18A4006F0", Slot = "5")]
		public string ZLXTBPPRCPZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE130", Offset = "0xA3ECB30", VA = "0x18A3EE130", Slot = "6")]
		public AvatarItemId AQDLHQRZWIU(string a)
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public SIDVMOZCQQC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class RUZVMVIQOLP : KWENJCKHAAS<BodyShapeId>, ACCUDNQYGCY<BodyShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB700", Offset = "0xA3FA100", VA = "0x18A3FB700", Slot = "4")]
		public IEnumerable<(BodyShapeId, string)> WJQNPPONEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xD76D40", Offset = "0xD75740", VA = "0x180D76D40", Slot = "5")]
		public string ZLXTBPPRCPZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE130", Offset = "0xA3ECB30", VA = "0x18A3EE130", Slot = "6")]
		public BodyShapeId AQDLHQRZWIU(string a)
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public RUZVMVIQOLP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class DLPOBHBDDRV : KWENJCKHAAS<ColorId>, ACCUDNQYGCY<ColorId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA3EFD70", Offset = "0xA3EE770", VA = "0x18A3EFD70", Slot = "4")]
		public IEnumerable<(ColorId, string)> WJQNPPONEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xD76D40", Offset = "0xD75740", VA = "0x180D76D40", Slot = "5")]
		public string ZLXTBPPRCPZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE130", Offset = "0xA3ECB30", VA = "0x18A3EE130", Slot = "6")]
		public ColorId AQDLHQRZWIU(string a)
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public DLPOBHBDDRV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class RKUZIZBEEFJ : KWENJCKHAAS<CombinationId>, ACCUDNQYGCY<CombinationId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly ACCUDNQYGCY<MaterialId> HGJQGIMKGMY;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xD1D300", Offset = "0xD1BD00", VA = "0x180D1D300")]
		public RKUZIZBEEFJ(ACCUDNQYGCY<MaterialId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA28DD70", Offset = "0xA28C770", VA = "0x18A28DD70", Slot = "4")]
		public IEnumerable<(CombinationId, string)> WJQNPPONEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB480", Offset = "0xA3F9E80", VA = "0x18A3FB480", Slot = "6")]
		public CombinationId AQDLHQRZWIU(string a)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB6C0", Offset = "0xA3FA0C0", VA = "0x18A3FB6C0", Slot = "5")]
		public string ZLXTBPPRCPZ(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class LMMRHMUZBNL : KWENJCKHAAS<EquipmentSkinId>, ACCUDNQYGCY<EquipmentSkinId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0xA3F23D0", Offset = "0xA3F0DD0", VA = "0x18A3F23D0", Slot = "4")]
		public IEnumerable<(EquipmentSkinId, string)> WJQNPPONEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xD76D40", Offset = "0xD75740", VA = "0x180D76D40", Slot = "5")]
		public string ZLXTBPPRCPZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE130", Offset = "0xA3ECB30", VA = "0x18A3EE130", Slot = "6")]
		public EquipmentSkinId AQDLHQRZWIU(string a)
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LMMRHMUZBNL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class CGSRMSDZXZT : KWENJCKHAAS<FaceFeatureId>, ACCUDNQYGCY<FaceFeatureId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE1E0", Offset = "0xA3ECBE0", VA = "0x18A3EE1E0", Slot = "4")]
		public IEnumerable<(FaceFeatureId, string)> WJQNPPONEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xD76D40", Offset = "0xD75740", VA = "0x180D76D40", Slot = "5")]
		public string ZLXTBPPRCPZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE130", Offset = "0xA3ECB30", VA = "0x18A3EE130", Slot = "6")]
		public FaceFeatureId AQDLHQRZWIU(string a)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public CGSRMSDZXZT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class LFRJEHAJIAC : KWENJCKHAAS<FaceShapeId>, ACCUDNQYGCY<FaceShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA3F1FB0", Offset = "0xA3F09B0", VA = "0x18A3F1FB0", Slot = "4")]
		public IEnumerable<(FaceShapeId, string)> WJQNPPONEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xD76D40", Offset = "0xD75740", VA = "0x180D76D40", Slot = "5")]
		public string ZLXTBPPRCPZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE130", Offset = "0xA3ECB30", VA = "0x18A3EE130", Slot = "6")]
		public FaceShapeId AQDLHQRZWIU(string a)
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LFRJEHAJIAC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class OOLFBDIHDKG : KWENJCKHAAS<HairPatternId>, ACCUDNQYGCY<HairPatternId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA3FA950", Offset = "0xA3F9350", VA = "0x18A3FA950", Slot = "4")]
		public IEnumerable<(HairPatternId, string)> WJQNPPONEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xD76D40", Offset = "0xD75740", VA = "0x180D76D40", Slot = "5")]
		public string ZLXTBPPRCPZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE130", Offset = "0xA3ECB30", VA = "0x18A3EE130", Slot = "6")]
		public HairPatternId AQDLHQRZWIU(string a)
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public OOLFBDIHDKG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface KWENJCKHAAS<a> : ACCUDNQYGCY<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<(a, string)> WJQNPPONEMN();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string ZLXTBPPRCPZ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class XUQXBLXZWEB : KWENJCKHAAS<MaterialId>, ACCUDNQYGCY<MaterialId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA342E90", Offset = "0xA341890", VA = "0x18A342E90", Slot = "4")]
		public IEnumerable<(MaterialId, string)> WJQNPPONEMN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xD76D40", Offset = "0xD75740", VA = "0x180D76D40", Slot = "5")]
		public string ZLXTBPPRCPZ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3EE130", Offset = "0xA3ECB30", VA = "0x18A3EE130", Slot = "6")]
		public MaterialId AQDLHQRZWIU(string a)
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public XUQXBLXZWEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class HOOIZDNBZFV<a> : RVMVPQNDFZE<a>, ACCUDNQYGCY<a> where a : IEquatable<a>, RJEIXZTKTCP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<a, string> YGEDYMAWEXQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Dictionary<string, a> DMIOJNJFYWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly KWENJCKHAAS<a> XXMKJPRFDCF;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6527710", Offset = "0x6526110", VA = "0x186527710")]
		public HOOIZDNBZFV(KWENJCKHAAS<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6525AC0", Offset = "0x65244C0", VA = "0x186525AC0", Slot = "5")]
		public a AQDLHQRZWIU(string a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6526750", Offset = "0x6525150", VA = "0x186526750", Slot = "4")]
		public string JWHHXIDWDYE(a a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class QVEZVBJBGKN : UMTIQQCLLAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private HOOIZDNBZFV<AvatarItemId> OSJJPJEJAYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private HOOIZDNBZFV<EquipmentSkinId> BEHLLSWRKUQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private HOOIZDNBZFV<HairPatternId> UVVWGFYNACP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private HOOIZDNBZFV<MaterialId> HGJQGIMKGMY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private HOOIZDNBZFV<CombinationId> IUGHSSOSMNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private HOOIZDNBZFV<ColorId> XXHWXTAPZGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private HOOIZDNBZFV<FaceShapeId> DJDFXCLUQVF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private HOOIZDNBZFV<BodyShapeId> CYAUZPOPJSU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private HOOIZDNBZFV<FaceFeatureId> BAIOAIUDLQM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public RVMVPQNDFZE<AvatarItemId> HWXKYVFIWQH
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public RVMVPQNDFZE<EquipmentSkinId> VLGSARDSTBC
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public RVMVPQNDFZE<HairPatternId> QSYYJWGBSCH
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public RVMVPQNDFZE<CombinationId> SKGGRQFBLDA
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public RVMVPQNDFZE<ColorId> IJTFLUFMXBE
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public RVMVPQNDFZE<FaceShapeId> USVSNYZOMIX
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public RVMVPQNDFZE<BodyShapeId> HVLXDFSOWBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xD159A0", Offset = "0xD143A0", VA = "0x180D159A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public RVMVPQNDFZE<FaceFeatureId> JRUDLVQABWQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xD141D0", Offset = "0xD12BD0", VA = "0x180D141D0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0xA3FAFD0", Offset = "0xA3F99D0", VA = "0x18A3FAFD0")]
		[BRMSZAJTATI.Root.GameOnly]
		[UsedImplicitly]
		internal static void RVLHKCZZZLE(ZUKUOYIIEVW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0xA3FB040", Offset = "0xA3F9A40", VA = "0x18A3FB040")]
		[RecRoom.NoEngine.Common.Preserve]
		public QVEZVBJBGKN()
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
