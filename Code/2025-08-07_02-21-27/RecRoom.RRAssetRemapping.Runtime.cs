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
		[Cpp2IlInjected.Address(RVA = "0x9464F80", Offset = "0x9463B80", VA = "0x189464F80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class ESETIVBZAJQ : GRHCPIWZEJZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Regex AUNUXEVUJSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly HYEGHIFALXC IHGWLTZMHJB;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x94525B0", Offset = "0x94511B0", VA = "0x1894525B0")]
		[IFIZWETSKCB.Root.GameOnly]
		[UsedImplicitly]
		internal static void IFIZWETSKCB(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9452550", Offset = "0x9451150", VA = "0x189452550")]
		[UsedImplicitly]
		internal static void FXKIFRRQOCU(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		[RecRoom.NoEngine.Common.Preserve]
		public ESETIVBZAJQ([Inject(null)] HYEGHIFALXC runtimeMapperProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9452620", Offset = "0x9451220", VA = "0x189452620", Slot = "4")]
		public string Serialize(AvatarItemDesc input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9452080", Offset = "0x9450C80", VA = "0x189452080", Slot = "5")]
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
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, YGKPYJREKUM
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
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
		public AvatarItemId Deserialize()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240", Slot = "4")]
		public bool Equals(SerializedAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x94621A0", Offset = "0x9460DA0", VA = "0x1894621A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9462260", Offset = "0x9460E60", VA = "0x189462260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, YGKPYJREKUM
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
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
		public BodyShapeId Deserialize()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240", Slot = "4")]
		public bool Equals(SerializedBodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x94622D0", Offset = "0x9460ED0", VA = "0x1894622D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9462370", Offset = "0x9460F70", VA = "0x189462370", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, YGKPYJREKUM
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
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
		public ColorId Deserialize()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240", Slot = "4")]
		public bool Equals(SerializedColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x94623E0", Offset = "0x9460FE0", VA = "0x1894623E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9462480", Offset = "0x9461080", VA = "0x189462480", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, YGKPYJREKUM, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF21280", Offset = "0xF1FE80", VA = "0x180F21280")]
		public CombinationId Deserialize()
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x92F0A10", Offset = "0x92EF610", VA = "0x1892F0A10", Slot = "4")]
		public bool Equals(SerializedCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x94624F0", Offset = "0x94610F0", VA = "0x1894624F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedCombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x94625B0", Offset = "0x94611B0", VA = "0x1894625B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x94625A0", Offset = "0x94611A0", VA = "0x1894625A0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, YGKPYJREKUM
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
		public bool HJSDDFNTWQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x94626C0", Offset = "0x94612C0", VA = "0x1894626C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x15B6DB0", Offset = "0x15B59B0", VA = "0x1815B6DB0")]
		public SerializedCustomAvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
		public static SerializedCustomAvatarItemId NLZMZNFSGSA(Guid a)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9462620", Offset = "0x9461220", VA = "0x189462620", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240")]
		public static bool EOXNKNKFOQL(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9462720", Offset = "0x9461320", VA = "0x189462720")]
		public static bool SZMIMWEVICM(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9462740", Offset = "0x9461340", VA = "0x189462740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, YGKPYJREKUM
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
		[Cpp2IlInjected.Address(RVA = "0x9462850", Offset = "0x9461450", VA = "0x189462850")]
		public static SerializedEquipmentSkinId LQQZLPINUTO()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
		public EquipmentSkinId Deserialize()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x94627B0", Offset = "0x94613B0", VA = "0x1894627B0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9462880", Offset = "0x9461480", VA = "0x189462880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, YGKPYJREKUM
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
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
		public FaceFeatureId Deserialize()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x94628F0", Offset = "0x94614F0", VA = "0x1894628F0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9462990", Offset = "0x9461590", VA = "0x189462990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, YGKPYJREKUM
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
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
		public FaceShapeId Deserialize()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240", Slot = "4")]
		public bool Equals(SerializedFaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9462A00", Offset = "0x9461600", VA = "0x189462A00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9462AA0", Offset = "0x94616A0", VA = "0x189462AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, YGKPYJREKUM
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
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0")]
		public HairPatternId Deserialize()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240", Slot = "4")]
		public bool Equals(SerializedHairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9462B10", Offset = "0x9461710", VA = "0x189462B10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9462240", Offset = "0x9460E40", VA = "0x189462240")]
		public static bool EOXNKNKFOQL(SerializedHairPatternId a, SerializedHairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9462BB0", Offset = "0x94617B0", VA = "0x189462BB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, YGKPYJREKUM
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
		[Cpp2IlInjected.Address(RVA = "0x13722A0", Offset = "0x1370EA0", VA = "0x1813722A0", Slot = "6")]
		public Guid HHCSOIALONS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x92F0A10", Offset = "0x92EF610", VA = "0x1892F0A10", Slot = "4")]
		public bool Equals(SerializedMaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9462C20", Offset = "0x9461820", VA = "0x189462C20", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x885B260", Offset = "0x8859E60", VA = "0x18885B260", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x885B0D0", Offset = "0x8859CD0", VA = "0x18885B0D0", Slot = "5")]
		public int CompareTo(SerializedMaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9462CD0", Offset = "0x94618D0", VA = "0x189462CD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KLSCKQSEVEO : HYEGHIFALXC
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static KLSCKQSEVEO CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x9453000", Offset = "0x9451C00", VA = "0x189453000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public ZOQURIDNNYB<AvatarItemId> WOFAJJFLLTO
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x9452FB0", Offset = "0x9451BB0", VA = "0x189452FB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public ZOQURIDNNYB<EquipmentSkinId> CBMNUZXBVEV
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x94530A0", Offset = "0x9451CA0", VA = "0x1894530A0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public ZOQURIDNNYB<HairPatternId> KIAUFGESKAW
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x94530F0", Offset = "0x9451CF0", VA = "0x1894530F0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ZOQURIDNNYB<CombinationId> HGYQOYNPSPR
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9452F60", Offset = "0x9451B60", VA = "0x189452F60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public ZOQURIDNNYB<ColorId> EREDFGFYXNB
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9453140", Offset = "0x9451D40", VA = "0x189453140", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public ZOQURIDNNYB<FaceShapeId> SIKBHRSRYKO
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9452EC0", Offset = "0x9451AC0", VA = "0x189452EC0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public ZOQURIDNNYB<BodyShapeId> MZPBAKHBNEN
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9453050", Offset = "0x9451C50", VA = "0x189453050", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ZOQURIDNNYB<FaceFeatureId> IVBLTEKXNAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9452F10", Offset = "0x9451B10", VA = "0x189452F10", Slot = "11")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class ZDUMGGWUAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9464E00", Offset = "0x9463A00", VA = "0x189464E00")]
		public static Guid JVZROTFDWOC(string a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9464EB0", Offset = "0x9463AB0", VA = "0x189464EB0")]
		public static bool TVPDPXOEFRI(string a, [Out] Guid b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class QYFIQXSNHPH : GGJAEQJBOKH<AvatarItemId>, AJFUZAFNJLT<AvatarItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x945D530", Offset = "0x945C130", VA = "0x18945D530", Slot = "4")]
		public IEnumerable<(AvatarItemId, string)> GGUHOZZEACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9462180", Offset = "0x9460D80", VA = "0x189462180", Slot = "5")]
		public string UDNYSSWCWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9452E10", Offset = "0x9451A10", VA = "0x189452E10", Slot = "6")]
		public AvatarItemId YYFWOTTQBRP(string a)
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public QYFIQXSNHPH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class PCVUKAOJQXG : GGJAEQJBOKH<BodyShapeId>, AJFUZAFNJLT<BodyShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9455580", Offset = "0x9454180", VA = "0x189455580", Slot = "4")]
		public IEnumerable<(BodyShapeId, string)> GGUHOZZEACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "5")]
		public string UDNYSSWCWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9452E10", Offset = "0x9451A10", VA = "0x189452E10", Slot = "6")]
		public BodyShapeId YYFWOTTQBRP(string a)
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public PCVUKAOJQXG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class UWOGRZTKYFQ : GGJAEQJBOKH<ColorId>, AJFUZAFNJLT<ColorId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9462D40", Offset = "0x9461940", VA = "0x189462D40", Slot = "4")]
		public IEnumerable<(ColorId, string)> GGUHOZZEACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "5")]
		public string UDNYSSWCWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9452E10", Offset = "0x9451A10", VA = "0x189452E10", Slot = "6")]
		public ColorId YYFWOTTQBRP(string a)
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public UWOGRZTKYFQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class AVGZCARUCOW : GGJAEQJBOKH<CombinationId>, AJFUZAFNJLT<CombinationId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly AJFUZAFNJLT<MaterialId> PCNDQJGFMGT;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public AVGZCARUCOW(AJFUZAFNJLT<MaterialId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x92F1A40", Offset = "0x92F0640", VA = "0x1892F1A40", Slot = "4")]
		public IEnumerable<(CombinationId, string)> GGUHOZZEACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9451E40", Offset = "0x9450A40", VA = "0x189451E40", Slot = "6")]
		public CombinationId YYFWOTTQBRP(string a)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9451E00", Offset = "0x9450A00", VA = "0x189451E00", Slot = "5")]
		public string UDNYSSWCWNM(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class QQCLXYAZMTG : GGJAEQJBOKH<EquipmentSkinId>, AJFUZAFNJLT<EquipmentSkinId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9455920", Offset = "0x9454520", VA = "0x189455920", Slot = "4")]
		public IEnumerable<(EquipmentSkinId, string)> GGUHOZZEACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "5")]
		public string UDNYSSWCWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9452E10", Offset = "0x9451A10", VA = "0x189452E10", Slot = "6")]
		public EquipmentSkinId YYFWOTTQBRP(string a)
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public QQCLXYAZMTG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class LPRJBHGTKXC : GGJAEQJBOKH<FaceFeatureId>, AJFUZAFNJLT<FaceFeatureId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9453190", Offset = "0x9451D90", VA = "0x189453190", Slot = "4")]
		public IEnumerable<(FaceFeatureId, string)> GGUHOZZEACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "5")]
		public string UDNYSSWCWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9452E10", Offset = "0x9451A10", VA = "0x189452E10", Slot = "6")]
		public FaceFeatureId YYFWOTTQBRP(string a)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public LPRJBHGTKXC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class JOFYJELAIOX : GGJAEQJBOKH<FaceShapeId>, AJFUZAFNJLT<FaceShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x94529F0", Offset = "0x94515F0", VA = "0x1894529F0", Slot = "4")]
		public IEnumerable<(FaceShapeId, string)> GGUHOZZEACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "5")]
		public string UDNYSSWCWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9452E10", Offset = "0x9451A10", VA = "0x189452E10", Slot = "6")]
		public FaceShapeId YYFWOTTQBRP(string a)
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public JOFYJELAIOX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class OFNEXGNJRBB : GGJAEQJBOKH<HairPatternId>, AJFUZAFNJLT<HairPatternId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9454F00", Offset = "0x9453B00", VA = "0x189454F00", Slot = "4")]
		public IEnumerable<(HairPatternId, string)> GGUHOZZEACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "5")]
		public string UDNYSSWCWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9452E10", Offset = "0x9451A10", VA = "0x189452E10", Slot = "6")]
		public HairPatternId YYFWOTTQBRP(string a)
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public OFNEXGNJRBB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface GGJAEQJBOKH<a> : AJFUZAFNJLT<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<(a, string)> GGUHOZZEACE();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string UDNYSSWCWNM(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class JPRPJSBIQLM : GGJAEQJBOKH<MaterialId>, AJFUZAFNJLT<MaterialId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x93A6B60", Offset = "0x93A5760", VA = "0x1893A6B60", Slot = "4")]
		public IEnumerable<(MaterialId, string)> GGUHOZZEACE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xB7C8B0", Offset = "0xB7B4B0", VA = "0x180B7C8B0", Slot = "5")]
		public string UDNYSSWCWNM(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9452E10", Offset = "0x9451A10", VA = "0x189452E10", Slot = "6")]
		public MaterialId YYFWOTTQBRP(string a)
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public JPRPJSBIQLM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class PZUIEBODYDG<a> : ZOQURIDNNYB<a>, AJFUZAFNJLT<a> where a : IEquatable<a>, YGKPYJREKUM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<a, string> GQWABAVEYZH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Dictionary<string, a> GEPSRKBRZYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly GGJAEQJBOKH<a> IIIJYFSSULO;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x619B400", Offset = "0x619A000", VA = "0x18619B400")]
		public PZUIEBODYDG(GGJAEQJBOKH<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x61990A0", Offset = "0x6197CA0", VA = "0x1861990A0", Slot = "5")]
		public a YYFWOTTQBRP(string a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6198640", Offset = "0x6197240", VA = "0x186198640", Slot = "4")]
		public string DGPIQGAMHGZ(a a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class MUCIOZZQZUU : HYEGHIFALXC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private PZUIEBODYDG<AvatarItemId> OBMKAMOEVSI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private PZUIEBODYDG<EquipmentSkinId> LWUILSWXZKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private PZUIEBODYDG<HairPatternId> KVSLWTXYHSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private PZUIEBODYDG<MaterialId> PCNDQJGFMGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private PZUIEBODYDG<CombinationId> LTOUKEMZZRB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private PZUIEBODYDG<ColorId> JLPEFSMELWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private PZUIEBODYDG<FaceShapeId> OJNQRBKZZFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private PZUIEBODYDG<BodyShapeId> QIUNXLQNUUB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private PZUIEBODYDG<FaceFeatureId> NTODJMARJUB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public ZOQURIDNNYB<AvatarItemId> WOFAJJFLLTO
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ZOQURIDNNYB<EquipmentSkinId> CBMNUZXBVEV
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ZOQURIDNNYB<HairPatternId> KIAUFGESKAW
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ZOQURIDNNYB<CombinationId> HGYQOYNPSPR
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ZOQURIDNNYB<ColorId> EREDFGFYXNB
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A50", Offset = "0xB12650", VA = "0x180B13A50", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ZOQURIDNNYB<FaceShapeId> SIKBHRSRYKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ZOQURIDNNYB<BodyShapeId> MZPBAKHBNEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ZOQURIDNNYB<FaceFeatureId> IVBLTEKXNAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9454A50", Offset = "0x9453650", VA = "0x189454A50")]
		[IFIZWETSKCB.Root.GameOnly]
		[UsedImplicitly]
		internal static void QPCYIHMTSNL(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9454AC0", Offset = "0x94536C0", VA = "0x189454AC0")]
		[RecRoom.NoEngine.Common.Preserve]
		public MUCIOZZQZUU()
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
