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
		[Cpp2IlInjected.Address(RVA = "0x8EAA390", Offset = "0x8EA9190", VA = "0x188EAA390", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2993B20", Offset = "0x2992920", VA = "0x182993B20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Avatars.Serialization
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class IEBSRQNUNCU : HSZUHTJTGSV
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static readonly Regex DOWSQSKQXGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private readonly NFVQCOGXZQO NJAFZPURYPL;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A4D0", Offset = "0x8E992D0", VA = "0x188E9A4D0")]
		[XNELNNYDNRZ.Root.GameOnly]
		[UsedImplicitly]
		internal static void XNELNNYDNRZ(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8E99C60", Offset = "0x8E98A60", VA = "0x188E99C60")]
		[UsedImplicitly]
		internal static void CZIBQCNELBE(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		[RecRoom.NoEngine.Common.Preserve]
		public IEBSRQNUNCU([Inject(null)] NFVQCOGXZQO runtimeMapperProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A190", Offset = "0x8E98F90", VA = "0x188E9A190", Slot = "4")]
		public string Serialize(AvatarItemDesc input)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8E99CC0", Offset = "0x8E98AC0", VA = "0x188E99CC0", Slot = "5")]
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
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, UDQHUHYEIZA
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
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
		public AvatarItemId Deserialize()
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900", Slot = "4")]
		public bool Equals(SerializedAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F860", Offset = "0x8E9E660", VA = "0x188E9F860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F920", Offset = "0x8E9E720", VA = "0x188E9F920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, UDQHUHYEIZA
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
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
		public BodyShapeId Deserialize()
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900", Slot = "4")]
		public bool Equals(SerializedBodyShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F990", Offset = "0x8E9E790", VA = "0x188E9F990", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FA30", Offset = "0x8E9E830", VA = "0x188E9FA30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, UDQHUHYEIZA
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
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
		public ColorId Deserialize()
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900", Slot = "4")]
		public bool Equals(SerializedColorId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedColorId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FAA0", Offset = "0x8E9E8A0", VA = "0x188E9FAA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FB40", Offset = "0x8E9E940", VA = "0x188E9FB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, UDQHUHYEIZA, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF319E0", Offset = "0xF307E0", VA = "0x180F319E0")]
		public CombinationId Deserialize()
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8D35F30", Offset = "0x8D34D30", VA = "0x188D35F30", Slot = "4")]
		public bool Equals(SerializedCombinationId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FBB0", Offset = "0x8E9E9B0", VA = "0x188E9FBB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedCombinationId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FC70", Offset = "0x8E9EA70", VA = "0x188E9FC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA9E180", Offset = "0xA9CF80", VA = "0x180A9E180", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FC60", Offset = "0x8E9EA60", VA = "0x188E9FC60", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, UDQHUHYEIZA
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
		public bool ARWUUGAYCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8E9FE10", Offset = "0x8E9EC10", VA = "0x188E9FE10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x157DE80", Offset = "0x157CC80", VA = "0x18157DE80")]
		public SerializedCustomAvatarItemId(Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
		public static SerializedCustomAvatarItemId LTBLGYNEGHY(Guid a)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FCE0", Offset = "0x8E9EAE0", VA = "0x188E9FCE0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900")]
		public static bool TRHVNHMHPTX(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FDF0", Offset = "0x8E9EBF0", VA = "0x188E9FDF0")]
		public static bool VVLYKZHTTRM(SerializedCustomAvatarItemId a, SerializedCustomAvatarItemId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FD80", Offset = "0x8E9EB80", VA = "0x188E9FD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, UDQHUHYEIZA
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
		[Cpp2IlInjected.Address(RVA = "0x8E9FF80", Offset = "0x8E9ED80", VA = "0x188E9FF80")]
		public static SerializedEquipmentSkinId WXNKIGMKVOS()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
		public EquipmentSkinId Deserialize()
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FE70", Offset = "0x8E9EC70", VA = "0x188E9FE70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FF10", Offset = "0x8E9ED10", VA = "0x188E9FF10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, UDQHUHYEIZA
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
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
		public FaceFeatureId Deserialize()
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8E9FFB0", Offset = "0x8E9EDB0", VA = "0x188E9FFB0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0050", Offset = "0x8E9EE50", VA = "0x188EA0050", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, UDQHUHYEIZA
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
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
		public FaceShapeId Deserialize()
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900", Slot = "4")]
		public bool Equals(SerializedFaceShapeId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8EA00C0", Offset = "0x8E9EEC0", VA = "0x188EA00C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0160", Offset = "0x8E9EF60", VA = "0x188EA0160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, UDQHUHYEIZA
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
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0")]
		public HairPatternId Deserialize()
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900", Slot = "4")]
		public bool Equals(SerializedHairPatternId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedHairPatternId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8EA01D0", Offset = "0x8E9EFD0", VA = "0x188EA01D0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F900", Offset = "0x8E9E700", VA = "0x188E9F900")]
		public static bool TRHVNHMHPTX(SerializedHairPatternId a, SerializedHairPatternId b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0270", Offset = "0x8E9F070", VA = "0x188EA0270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, UDQHUHYEIZA
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
		[Cpp2IlInjected.Address(RVA = "0x13131F0", Offset = "0x1311FF0", VA = "0x1813131F0", Slot = "6")]
		public Guid SEQIZJLYXAS()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8D35F30", Offset = "0x8D34D30", VA = "0x188D35F30", Slot = "4")]
		public bool Equals(SerializedMaterialId other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x8EA02E0", Offset = "0x8E9F0E0", VA = "0x188EA02E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x82F09B0", Offset = "0x82EF7B0", VA = "0x1882F09B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82F0820", Offset = "0x82EF620", VA = "0x1882F0820", Slot = "5")]
		public int CompareTo(SerializedMaterialId other)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8EA0380", Offset = "0x8E9F180", VA = "0x188EA0380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class WSTCVOJYVUQ : NFVQCOGXZQO
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static WSTCVOJYVUQ VDCQJFYBFAQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0440", Offset = "0x8E9F240", VA = "0x188EA0440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LMGFQYJWXTN<AvatarItemId> SULONBCGPZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0490", Offset = "0x8E9F290", VA = "0x188EA0490", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public LMGFQYJWXTN<EquipmentSkinId> UPQPRCSWLMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8EA05D0", Offset = "0x8E9F3D0", VA = "0x188EA05D0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public LMGFQYJWXTN<HairPatternId> CZAQQPSNWNK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0620", Offset = "0x8E9F420", VA = "0x188EA0620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public LMGFQYJWXTN<CombinationId> XFPRFUIXTHX
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0580", Offset = "0x8E9F380", VA = "0x188EA0580", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public LMGFQYJWXTN<ColorId> RHSTVLRKDMV
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0670", Offset = "0x8E9F470", VA = "0x188EA0670", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public LMGFQYJWXTN<FaceShapeId> JPEBXZMGXBC
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8EA0530", Offset = "0x8E9F330", VA = "0x188EA0530", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public LMGFQYJWXTN<BodyShapeId> XCYKTVEPLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8EA04E0", Offset = "0x8E9F2E0", VA = "0x188EA04E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public LMGFQYJWXTN<FaceFeatureId> YVSSYHYYIKL
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8EA03F0", Offset = "0x8E9F1F0", VA = "0x188EA03F0", Slot = "11")]
			get
			{
				return null;
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class CEVGQXMSNET
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8E976F0", Offset = "0x8E964F0", VA = "0x188E976F0")]
		public static Guid QZBNELKQAGU(string a)
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8E977A0", Offset = "0x8E965A0", VA = "0x188E977A0")]
		public static bool TNFTFOAHUEY(string a, [Out] Guid b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class PINKNWVXIPJ : RMJCSFEWACN<AvatarItemId>, HNSGOQNSBSP<AvatarItemId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A990", Offset = "0x8E99790", VA = "0x188E9A990", Slot = "4")]
		public IEnumerable<(AvatarItemId, string)> DLFPIXTYZSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A970", Offset = "0x8E99770", VA = "0x188E9A970", Slot = "5")]
		public string BUJZLVRJHEQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8E97640", Offset = "0x8E96440", VA = "0x188E97640", Slot = "6")]
		public AvatarItemId MXIMGTNABID(string a)
		{
			return default(AvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public PINKNWVXIPJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class JYFPNQYYGSO : RMJCSFEWACN<BodyShapeId>, HNSGOQNSBSP<BodyShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8E9A5D0", Offset = "0x8E993D0", VA = "0x188E9A5D0", Slot = "4")]
		public IEnumerable<(BodyShapeId, string)> DLFPIXTYZSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAFDDA0", Offset = "0xAFCBA0", VA = "0x180AFDDA0", Slot = "5")]
		public string BUJZLVRJHEQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8E97640", Offset = "0x8E96440", VA = "0x188E97640", Slot = "6")]
		public BodyShapeId MXIMGTNABID(string a)
		{
			return default(BodyShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public JYFPNQYYGSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ZDHZAJPQYRS : RMJCSFEWACN<ColorId>, HNSGOQNSBSP<ColorId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8EA06C0", Offset = "0x8E9F4C0", VA = "0x188EA06C0", Slot = "4")]
		public IEnumerable<(ColorId, string)> DLFPIXTYZSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xAFDDA0", Offset = "0xAFCBA0", VA = "0x180AFDDA0", Slot = "5")]
		public string BUJZLVRJHEQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8E97640", Offset = "0x8E96440", VA = "0x188E97640", Slot = "6")]
		public ColorId MXIMGTNABID(string a)
		{
			return default(ColorId);
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ZDHZAJPQYRS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class QPPHHGMSGPG : RMJCSFEWACN<CombinationId>, HNSGOQNSBSP<CombinationId>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly HNSGOQNSBSP<MaterialId> KPPTATTASQZ;

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xAAA590", Offset = "0xAA9390", VA = "0x180AAA590")]
		public QPPHHGMSGPG(HNSGOQNSBSP<MaterialId> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8D36E60", Offset = "0x8D35C60", VA = "0x188D36E60", Slot = "4")]
		public IEnumerable<(CombinationId, string)> DLFPIXTYZSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F620", Offset = "0x8E9E420", VA = "0x188E9F620", Slot = "6")]
		public CombinationId MXIMGTNABID(string a)
		{
			return default(CombinationId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8E9F5E0", Offset = "0x8E9E3E0", VA = "0x188E9F5E0", Slot = "5")]
		public string BUJZLVRJHEQ(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ZVZKSHPQQSC : RMJCSFEWACN<EquipmentSkinId>, HNSGOQNSBSP<EquipmentSkinId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8EA2780", Offset = "0x8EA1580", VA = "0x188EA2780", Slot = "4")]
		public IEnumerable<(EquipmentSkinId, string)> DLFPIXTYZSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0xAFDDA0", Offset = "0xAFCBA0", VA = "0x180AFDDA0", Slot = "5")]
		public string BUJZLVRJHEQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8E97640", Offset = "0x8E96440", VA = "0x188E97640", Slot = "6")]
		public EquipmentSkinId MXIMGTNABID(string a)
		{
			return default(EquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ZVZKSHPQQSC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class IAKAQMDXSRY : RMJCSFEWACN<FaceFeatureId>, HNSGOQNSBSP<FaceFeatureId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8E983A0", Offset = "0x8E971A0", VA = "0x188E983A0", Slot = "4")]
		public IEnumerable<(FaceFeatureId, string)> DLFPIXTYZSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xAFDDA0", Offset = "0xAFCBA0", VA = "0x180AFDDA0", Slot = "5")]
		public string BUJZLVRJHEQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8E97640", Offset = "0x8E96440", VA = "0x188E97640", Slot = "6")]
		public FaceFeatureId MXIMGTNABID(string a)
		{
			return default(FaceFeatureId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public IAKAQMDXSRY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class ABLIXOABBKZ : RMJCSFEWACN<FaceShapeId>, HNSGOQNSBSP<FaceShapeId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8E97220", Offset = "0x8E96020", VA = "0x188E97220", Slot = "4")]
		public IEnumerable<(FaceShapeId, string)> DLFPIXTYZSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xAFDDA0", Offset = "0xAFCBA0", VA = "0x180AFDDA0", Slot = "5")]
		public string BUJZLVRJHEQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8E97640", Offset = "0x8E96440", VA = "0x188E97640", Slot = "6")]
		public FaceShapeId MXIMGTNABID(string a)
		{
			return default(FaceShapeId);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public ABLIXOABBKZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class HIPACJJVCCJ : RMJCSFEWACN<HairPatternId>, HNSGOQNSBSP<HairPatternId>
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8E97D20", Offset = "0x8E96B20", VA = "0x188E97D20", Slot = "4")]
		public IEnumerable<(HairPatternId, string)> DLFPIXTYZSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAFDDA0", Offset = "0xAFCBA0", VA = "0x180AFDDA0", Slot = "5")]
		public string BUJZLVRJHEQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8E97640", Offset = "0x8E96440", VA = "0x188E97640", Slot = "6")]
		public HairPatternId MXIMGTNABID(string a)
		{
			return default(HairPatternId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public HIPACJJVCCJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public interface RMJCSFEWACN<a> : HNSGOQNSBSP<a>
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(Slot = "0")]
		IEnumerable<(a, string)> DLFPIXTYZSG();

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(Slot = "1")]
		string BUJZLVRJHEQ(string a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PTJUZAOKHEA : RMJCSFEWACN<MaterialId>, HNSGOQNSBSP<MaterialId>
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x8DEBF80", Offset = "0x8DEAD80", VA = "0x188DEBF80", Slot = "4")]
		public IEnumerable<(MaterialId, string)> DLFPIXTYZSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0xAFDDA0", Offset = "0xAFCBA0", VA = "0x180AFDDA0", Slot = "5")]
		public string BUJZLVRJHEQ(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8E97640", Offset = "0x8E96440", VA = "0x188E97640", Slot = "6")]
		public MaterialId MXIMGTNABID(string a)
		{
			return default(MaterialId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xAA9350", Offset = "0xAA8150", VA = "0x180AA9350")]
		public PTJUZAOKHEA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class YCUZRUBZHMC<a> : LMGFQYJWXTN<a>, HNSGOQNSBSP<a> where a : IEquatable<a>, UDQHUHYEIZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private readonly Dictionary<a, string> QHSBOYNPZAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private readonly Dictionary<string, a> LLUJFBGVAZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private readonly RMJCSFEWACN<a> BVUHCCEIUUK;

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x40AEEC0", Offset = "0x40ADCC0", VA = "0x1840AEEC0")]
		public YCUZRUBZHMC(RMJCSFEWACN<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x40ACE20", Offset = "0x40ABC20", VA = "0x1840ACE20", Slot = "5")]
		public a MXIMGTNABID(string a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x40AE950", Offset = "0x40AD750", VA = "0x1840AE950", Slot = "4")]
		public string USHFLIDQGPN(a a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class FDLYESTQANU : NFVQCOGXZQO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private YCUZRUBZHMC<AvatarItemId> AYPZLMEKPSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private YCUZRUBZHMC<EquipmentSkinId> WVLKKMBQKHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private YCUZRUBZHMC<HairPatternId> YIPVYDHWYME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private YCUZRUBZHMC<MaterialId> KPPTATTASQZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private YCUZRUBZHMC<CombinationId> IUWYYFXYOQJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private YCUZRUBZHMC<ColorId> REJREXWQUKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private YCUZRUBZHMC<FaceShapeId> ZZOGSNMOAHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private YCUZRUBZHMC<BodyShapeId> MIEUMONMYPR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private YCUZRUBZHMC<FaceFeatureId> UMFXZHSBDDN;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public LMGFQYJWXTN<AvatarItemId> SULONBCGPZY
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BE0", Offset = "0xA9F9E0", VA = "0x180AA0BE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public LMGFQYJWXTN<EquipmentSkinId> UPQPRCSWLMP
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xAA0BA0", Offset = "0xA9F9A0", VA = "0x180AA0BA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public LMGFQYJWXTN<HairPatternId> CZAQQPSNWNK
		{
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xAA45D0", Offset = "0xAA33D0", VA = "0x180AA45D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public LMGFQYJWXTN<CombinationId> XFPRFUIXTHX
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xAA0F80", Offset = "0xA9FD80", VA = "0x180AA0F80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public LMGFQYJWXTN<ColorId> RHSTVLRKDMV
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xAA0930", Offset = "0xA9F730", VA = "0x180AA0930", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public LMGFQYJWXTN<FaceShapeId> JPEBXZMGXBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xAA2210", Offset = "0xAA1010", VA = "0x180AA2210", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public LMGFQYJWXTN<BodyShapeId> XCYKTVEPLJZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA9EC80", Offset = "0xA9DA80", VA = "0x180A9EC80", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public LMGFQYJWXTN<FaceFeatureId> YVSSYHYYIKL
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAA19A0", Offset = "0xAA07A0", VA = "0x180AA19A0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8E97870", Offset = "0x8E96670", VA = "0x188E97870")]
		[XNELNNYDNRZ.Root.GameOnly]
		[UsedImplicitly]
		internal static void XENUMWLENJR(MQNVASDZCUX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8E978E0", Offset = "0x8E966E0", VA = "0x188E978E0")]
		[RecRoom.NoEngine.Common.Preserve]
		public FDLYESTQANU()
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
