using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _AssemblyRegistry.RecRoom_RRAssetRemapping_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x82B3310", Offset = "0x82B1D10", VA = "0x1882B3310", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2571680", Offset = "0x2570080", VA = "0x182571680")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class FFDCGOIKAPF : PDGGKLGBFNJ
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex ECMAIHNGBGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly BFKGFOMADKP AGBDDDDLENG;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x82A1560", Offset = "0x829FF60", VA = "0x1882A1560")]
	[EFEOGKEOEKD.IHENNBHNBPA.IFPBCNBMCDE]
	[UsedImplicitly]
	internal static void LMIBOGDHNKD(LKOLOODKMPF JACGBGKJHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x82A0D00", Offset = "0x829F700", VA = "0x1882A0D00")]
	[UsedImplicitly]
	internal static void BPLMLCBLOKP(LKOLOODKMPF JACGBGKJHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	[RecRoom.NoEngine.Common.Preserve]
	public FFDCGOIKAPF([GJJKIKPKKBJ(null)] BFKGFOMADKP AGBDDDDLENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x82A0D60", Offset = "0x829F760", VA = "0x1882A0D60", Slot = "4")]
	public string CFLEALCFLNK(FPDCEKEDCDG OBMEHBOBMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x82A10A0", Offset = "0x829FAA0", VA = "0x1882A10A0", Slot = "5")]
	public FPDCEKEDCDG DHOLDBOACBA(string OBMEHBOBMDK)
	{
		return default(FPDCEKEDCDG);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, NBFPJEEGCEI
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
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public MCOHPILBDMI DHOLDBOACBA()
		{
			return default(MCOHPILBDMI);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880", Slot = "4")]
		public bool Equals(SerializedAvatarItemId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82B27E0", Offset = "0x82B11E0", VA = "0x1882B27E0", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x82B28A0", Offset = "0x82B12A0", VA = "0x1882B28A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, NBFPJEEGCEI
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
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public GNGAKHCDFCP DHOLDBOACBA()
		{
			return default(GNGAKHCDFCP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880", Slot = "4")]
		public bool Equals(SerializedBodyShapeId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x82B2910", Offset = "0x82B1310", VA = "0x1882B2910", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x82B29B0", Offset = "0x82B13B0", VA = "0x1882B29B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, NBFPJEEGCEI
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
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public HNEGNIKOBIL DHOLDBOACBA()
		{
			return default(HNEGNIKOBIL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880", Slot = "4")]
		public bool Equals(SerializedColorId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedColorId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82B2A20", Offset = "0x82B1420", VA = "0x1882B2A20", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82B2AC0", Offset = "0x82B14C0", VA = "0x1882B2AC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, NBFPJEEGCEI, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xEC09F0", Offset = "0xEBF3F0", VA = "0x180EC09F0")]
		public BEAKLKOGAHD DHOLDBOACBA()
		{
			return default(BEAKLKOGAHD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x813E470", Offset = "0x813CE70", VA = "0x18813E470", Slot = "4")]
		public bool Equals(SerializedCombinationId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82B2B30", Offset = "0x82B1530", VA = "0x1882B2B30", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedCombinationId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x82B2BF0", Offset = "0x82B15F0", VA = "0x1882B2BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AE060", Offset = "0x9ACA60", VA = "0x1809AE060", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x82B2BE0", Offset = "0x82B15E0", VA = "0x1882B2BE0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, NBFPJEEGCEI
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

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1136320", Offset = "0x1134D20", VA = "0x181136320")]
		public SerializedCustomAvatarItemId(Guid BIGAPECKJPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public static SerializedCustomAvatarItemId KEOOPHOGIBH(Guid BIGAPECKJPI)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82B2C80", Offset = "0x82B1680", VA = "0x1882B2C80", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880")]
		public static bool HFGMMLFJJJB(SerializedCustomAvatarItemId AKJAPDOPIOF, SerializedCustomAvatarItemId CPKHJEJFIJK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82B2C60", Offset = "0x82B1660", VA = "0x1882B2C60")]
		public static bool BDABLEIINAG(SerializedCustomAvatarItemId AKJAPDOPIOF, SerializedCustomAvatarItemId CPKHJEJFIJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82B2D20", Offset = "0x82B1720", VA = "0x1882B2D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, NBFPJEEGCEI
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

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x82B2E30", Offset = "0x82B1830", VA = "0x1882B2E30")]
		public static SerializedEquipmentSkinId HLLCPJCEJEP()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public IAIAOHGCJGA DHOLDBOACBA()
		{
			return default(IAIAOHGCJGA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x82B2D90", Offset = "0x82B1790", VA = "0x1882B2D90", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x82B2E60", Offset = "0x82B1860", VA = "0x1882B2E60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, NBFPJEEGCEI
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

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public FLDKPNGONNC DHOLDBOACBA()
		{
			return default(FLDKPNGONNC);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x82B2ED0", Offset = "0x82B18D0", VA = "0x1882B2ED0", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x82B2F70", Offset = "0x82B1970", VA = "0x1882B2F70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, NBFPJEEGCEI
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

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public BLIIEFBMILH DHOLDBOACBA()
		{
			return default(BLIIEFBMILH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880", Slot = "4")]
		public bool Equals(SerializedFaceShapeId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x82B2FE0", Offset = "0x82B19E0", VA = "0x1882B2FE0", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x82B3080", Offset = "0x82B1A80", VA = "0x1882B3080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, NBFPJEEGCEI
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

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330")]
		public NNFFMGJCAON DHOLDBOACBA()
		{
			return default(NNFFMGJCAON);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880", Slot = "4")]
		public bool Equals(SerializedHairPatternId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x82B30F0", Offset = "0x82B1AF0", VA = "0x1882B30F0", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x82B2880", Offset = "0x82B1280", VA = "0x1882B2880")]
		public static bool HFGMMLFJJJB(SerializedHairPatternId AKJAPDOPIOF, SerializedHairPatternId CPKHJEJFIJK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x82B3190", Offset = "0x82B1B90", VA = "0x1882B3190", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, NBFPJEEGCEI
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

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1136330", Offset = "0x1134D30", VA = "0x181136330", Slot = "6")]
		public Guid BIKPNAIIBLG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x813E470", Offset = "0x813CE70", VA = "0x18813E470", Slot = "4")]
		public bool Equals(SerializedMaterialId OLKLGHOAKNE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x82B3200", Offset = "0x82B1C00", VA = "0x1882B3200", Slot = "0")]
		public override bool Equals(object OIIGDBLKEDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x778CF70", Offset = "0x778B970", VA = "0x18778CF70", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x778CDE0", Offset = "0x778B7E0", VA = "0x18778CDE0", Slot = "5")]
		public int CompareTo(SerializedMaterialId OLKLGHOAKNE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x82B32A0", Offset = "0x82B1CA0", VA = "0x1882B32A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AKDBDCKPCFL : BFKGFOMADKP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AKDBDCKPCFL LALLOKGAEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x82A0240", Offset = "0x829EC40", VA = "0x1882A0240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public ACONCFPALJC<MCOHPILBDMI> GCDPOJFINAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x82A0120", Offset = "0x829EB20", VA = "0x1882A0120", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public ACONCFPALJC<IAIAOHGCJGA> GFIOJKOPION
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x82A03C0", Offset = "0x829EDC0", VA = "0x1882A03C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ACONCFPALJC<NNFFMGJCAON> CBJNHHKLGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82A00C0", Offset = "0x829EAC0", VA = "0x1882A00C0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public ACONCFPALJC<BEAKLKOGAHD> HIKPIBFCEPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82A0360", Offset = "0x829ED60", VA = "0x1882A0360", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public ACONCFPALJC<HNEGNIKOBIL> ENDAILEFABB
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x82A01E0", Offset = "0x829EBE0", VA = "0x1882A01E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public ACONCFPALJC<BLIIEFBMILH> MNCHDBLNAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x82A0180", Offset = "0x829EB80", VA = "0x1882A0180", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public ACONCFPALJC<GNGAKHCDFCP> FJDJPHLELFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x82A0300", Offset = "0x829ED00", VA = "0x1882A0300", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public ACONCFPALJC<FLDKPNGONNC> JBDPJHFGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x82A02A0", Offset = "0x829ECA0", VA = "0x1882A02A0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BJILJOLOGBI
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x82A04F0", Offset = "0x829EEF0", VA = "0x1882A04F0")]
	public static Guid JKKPCFOMELJ(string IANKFDHMOGI)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x82A0420", Offset = "0x829EE20", VA = "0x1882A0420")]
	public static bool CMFMJKMJEKA(string IANKFDHMOGI, [Out] Guid BIGAPECKJPI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LIMDEAGHGKB : IHIADCCKHHC<MCOHPILBDMI>, NOILDNDGELG<MCOHPILBDMI>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x82ABAD0", Offset = "0x82AA4D0", VA = "0x1882ABAD0", Slot = "4")]
	public IEnumerable<(MCOHPILBDMI, string)> GJEBAMDFIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x82ABAB0", Offset = "0x82AA4B0", VA = "0x1882ABAB0", Slot = "5")]
	public string AFNHJIEIMAP(string JDBODLGJMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x82A0820", Offset = "0x829F220", VA = "0x1882A0820", Slot = "6")]
	public MCOHPILBDMI DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return default(MCOHPILBDMI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LIMDEAGHGKB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GPEDODGIPPE : IHIADCCKHHC<GNGAKHCDFCP>, NOILDNDGELG<GNGAKHCDFCP>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x82A1670", Offset = "0x82A0070", VA = "0x1882A1670", Slot = "4")]
	public IEnumerable<(GNGAKHCDFCP, string)> GJEBAMDFIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA2E020", Offset = "0xA2CA20", VA = "0x180A2E020", Slot = "5")]
	public string AFNHJIEIMAP(string JDBODLGJMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x82A0820", Offset = "0x829F220", VA = "0x1882A0820", Slot = "6")]
	public GNGAKHCDFCP DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return default(GNGAKHCDFCP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public GPEDODGIPPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class PMMAPMANICJ : IHIADCCKHHC<HNEGNIKOBIL>, NOILDNDGELG<HNEGNIKOBIL>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x82B0720", Offset = "0x82AF120", VA = "0x1882B0720", Slot = "4")]
	public IEnumerable<(HNEGNIKOBIL, string)> GJEBAMDFIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA2E020", Offset = "0xA2CA20", VA = "0x180A2E020", Slot = "5")]
	public string AFNHJIEIMAP(string JDBODLGJMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x82A0820", Offset = "0x829F220", VA = "0x1882A0820", Slot = "6")]
	public HNEGNIKOBIL DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return default(HNEGNIKOBIL);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public PMMAPMANICJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EBAICKMHPNP : IHIADCCKHHC<BEAKLKOGAHD>, NOILDNDGELG<BEAKLKOGAHD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly NOILDNDGELG<CLEGOBMMEGH> LJHNHADAEON;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9B0720", Offset = "0x9AF120", VA = "0x1809B0720")]
	public EBAICKMHPNP(NOILDNDGELG<CLEGOBMMEGH> LJHNHADAEON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x813FD00", Offset = "0x813E700", VA = "0x18813FD00", Slot = "4")]
	public IEnumerable<(BEAKLKOGAHD, string)> GJEBAMDFIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x82A05E0", Offset = "0x829EFE0", VA = "0x1882A05E0", Slot = "6")]
	public BEAKLKOGAHD DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return default(BEAKLKOGAHD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82A05A0", Offset = "0x829EFA0", VA = "0x1882A05A0", Slot = "5")]
	public string AFNHJIEIMAP(string JDBODLGJMCB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KBFHHCJHCII : IHIADCCKHHC<IAIAOHGCJGA>, NOILDNDGELG<IAIAOHGCJGA>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x82A1A10", Offset = "0x82A0410", VA = "0x1882A1A10", Slot = "4")]
	public IEnumerable<(IAIAOHGCJGA, string)> GJEBAMDFIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xA2E020", Offset = "0xA2CA20", VA = "0x180A2E020", Slot = "5")]
	public string AFNHJIEIMAP(string JDBODLGJMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x82A0820", Offset = "0x829F220", VA = "0x1882A0820", Slot = "6")]
	public IAIAOHGCJGA DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return default(IAIAOHGCJGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public KBFHHCJHCII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LFJDLOFNJNH : IHIADCCKHHC<FLDKPNGONNC>, NOILDNDGELG<FLDKPNGONNC>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x82AA1F0", Offset = "0x82A8BF0", VA = "0x1882AA1F0", Slot = "4")]
	public IEnumerable<(FLDKPNGONNC, string)> GJEBAMDFIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA2E020", Offset = "0xA2CA20", VA = "0x180A2E020", Slot = "5")]
	public string AFNHJIEIMAP(string JDBODLGJMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82A0820", Offset = "0x829F220", VA = "0x1882A0820", Slot = "6")]
	public FLDKPNGONNC DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return default(FLDKPNGONNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LFJDLOFNJNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EJNOMMNIICH : IHIADCCKHHC<BLIIEFBMILH>, NOILDNDGELG<BLIIEFBMILH>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x82A08E0", Offset = "0x829F2E0", VA = "0x1882A08E0", Slot = "4")]
	public IEnumerable<(BLIIEFBMILH, string)> GJEBAMDFIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA2E020", Offset = "0xA2CA20", VA = "0x180A2E020", Slot = "5")]
	public string AFNHJIEIMAP(string JDBODLGJMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82A0820", Offset = "0x829F220", VA = "0x1882A0820", Slot = "6")]
	public BLIIEFBMILH DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return default(BLIIEFBMILH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public EJNOMMNIICH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class LBMKOFKNLKO : IHIADCCKHHC<NNFFMGJCAON>, NOILDNDGELG<NNFFMGJCAON>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82A9B70", Offset = "0x82A8570", VA = "0x1882A9B70", Slot = "4")]
	public IEnumerable<(NNFFMGJCAON, string)> GJEBAMDFIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA2E020", Offset = "0xA2CA20", VA = "0x180A2E020", Slot = "5")]
	public string AFNHJIEIMAP(string JDBODLGJMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82A0820", Offset = "0x829F220", VA = "0x1882A0820", Slot = "6")]
	public NNFFMGJCAON DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return default(NNFFMGJCAON);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public LBMKOFKNLKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface IHIADCCKHHC<TModern> : NOILDNDGELG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> GJEBAMDFIHH();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string AFNHJIEIMAP(string JDBODLGJMCB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JLNLNAGCEKF : IHIADCCKHHC<CLEGOBMMEGH>, NOILDNDGELG<CLEGOBMMEGH>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x81F4E20", Offset = "0x81F3820", VA = "0x1881F4E20", Slot = "4")]
	public IEnumerable<(CLEGOBMMEGH, string)> GJEBAMDFIHH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA2E020", Offset = "0xA2CA20", VA = "0x180A2E020", Slot = "5")]
	public string AFNHJIEIMAP(string JDBODLGJMCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x82A0820", Offset = "0x829F220", VA = "0x1882A0820", Slot = "6")]
	public CLEGOBMMEGH DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return default(CLEGOBMMEGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9B1770", Offset = "0x9B0170", VA = "0x1809B1770")]
	public JLNLNAGCEKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NAMGLPCKOHD<TModern> : ACONCFPALJC<TModern>, NOILDNDGELG<TModern> where TModern : IEquatable<TModern>, NBFPJEEGCEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> ODCJCAFGKMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> DBOLFGJCLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly IHIADCCKHHC<TModern> GCPDDMEBANA;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5188130", Offset = "0x5186B30", VA = "0x185188130")]
	public NAMGLPCKOHD(IHIADCCKHHC<TModern> GCPDDMEBANA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5184A10", Offset = "0x5183410", VA = "0x185184A10", Slot = "5")]
	public TModern DHIOAMEGEMH(string JDBODLGJMCB)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5185D40", Offset = "0x5184740", VA = "0x185185D40", Slot = "4")]
	public string ONGIDONMJCK(TModern EJEFCKDEDAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class KMJEKPNFBFI : BFKGFOMADKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NAMGLPCKOHD<MCOHPILBDMI> LIAKPOLNPJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NAMGLPCKOHD<IAIAOHGCJGA> GMHFGACJAMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NAMGLPCKOHD<NNFFMGJCAON> IIGKONPJEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NAMGLPCKOHD<CLEGOBMMEGH> LJHNHADAEON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NAMGLPCKOHD<BEAKLKOGAHD> LGLAOOFEECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NAMGLPCKOHD<HNEGNIKOBIL> CJLGNHDFFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NAMGLPCKOHD<BLIIEFBMILH> FJKBLCFHIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NAMGLPCKOHD<GNGAKHCDFCP> ILJDDHNAGPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NAMGLPCKOHD<FLDKPNGONNC> MCEFLJLEFMN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public ACONCFPALJC<MCOHPILBDMI> GCDPOJFINAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFD0", Offset = "0x9AD9D0", VA = "0x1809AEFD0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public ACONCFPALJC<IAIAOHGCJGA> GFIOJKOPION
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9ACED0", Offset = "0x9AB8D0", VA = "0x1809ACED0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public ACONCFPALJC<NNFFMGJCAON> CBJNHHKLGMD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9B5560", Offset = "0x9B3F60", VA = "0x1809B5560", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public ACONCFPALJC<BEAKLKOGAHD> HIKPIBFCEPH
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFC0", Offset = "0x9AD9C0", VA = "0x1809AEFC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ACONCFPALJC<HNEGNIKOBIL> ENDAILEFABB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9AF000", Offset = "0x9ADA00", VA = "0x1809AF000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ACONCFPALJC<BLIIEFBMILH> MNCHDBLNAEE
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9B22C0", Offset = "0x9B0CC0", VA = "0x1809B22C0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public ACONCFPALJC<GNGAKHCDFCP> FJDJPHLELFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9AEFF0", Offset = "0x9AD9F0", VA = "0x1809AEFF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public ACONCFPALJC<FLDKPNGONNC> JBDPJHFGCEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4F0", Offset = "0x9AAEF0", VA = "0x1809AC4F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x82A9620", Offset = "0x82A8020", VA = "0x1882A9620")]
	[EFEOGKEOEKD.IHENNBHNBPA.IFPBCNBMCDE]
	[UsedImplicitly]
	internal static void OFOBEAIFMFF(LKOLOODKMPF JACGBGKJHKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x82A9690", Offset = "0x82A8090", VA = "0x1882A9690")]
	[RecRoom.NoEngine.Common.Preserve]
	public KMJEKPNFBFI()
	{
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
