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
		[Cpp2IlInjected.Address(RVA = "0x822CBD0", Offset = "0x822BFD0", VA = "0x18822CBD0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x254E750", Offset = "0x254DB50", VA = "0x18254E750")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EJJEJKAFFIP : FNKIDNDFNMM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex GMJPGOAOEDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly IKKNLBGAIJE JJHCKCDCEDH;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x821ABE0", Offset = "0x8219FE0", VA = "0x18821ABE0")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	[UsedImplicitly]
	internal static void FJKHLPMEJLC(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x821AC50", Offset = "0x821A050", VA = "0x18821AC50")]
	[UsedImplicitly]
	internal static void FOMJPOKODJK(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EJJEJKAFFIP([CMKKAFOAFJE(null)] IKKNLBGAIJE JJHCKCDCEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x821B180", Offset = "0x821A580", VA = "0x18821B180", Slot = "4")]
	public string PELCBGJOJPC(FEJKALOKOAI PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x821ACB0", Offset = "0x821A0B0", VA = "0x18821ACB0", Slot = "5")]
	public FEJKALOKOAI HFAEDKNMEEN(string PJCOHHCODGF)
	{
		return default(FEJKALOKOAI);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, OOBOEDGJKIN
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
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public LALAGECKOGA HFAEDKNMEEN()
		{
			return default(LALAGECKOGA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140", Slot = "4")]
		public bool Equals(SerializedAvatarItemId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x822C0A0", Offset = "0x822B4A0", VA = "0x18822C0A0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x822C160", Offset = "0x822B560", VA = "0x18822C160", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, OOBOEDGJKIN
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
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public AOAHCJAKMBM HFAEDKNMEEN()
		{
			return default(AOAHCJAKMBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140", Slot = "4")]
		public bool Equals(SerializedBodyShapeId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x822C1D0", Offset = "0x822B5D0", VA = "0x18822C1D0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x822C270", Offset = "0x822B670", VA = "0x18822C270", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, OOBOEDGJKIN
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
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public MDKOOLPNNLA HFAEDKNMEEN()
		{
			return default(MDKOOLPNNLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140", Slot = "4")]
		public bool Equals(SerializedColorId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedColorId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x822C2E0", Offset = "0x822B6E0", VA = "0x18822C2E0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x822C380", Offset = "0x822B780", VA = "0x18822C380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, OOBOEDGJKIN, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xB9CB20", Offset = "0xB9BF20", VA = "0x180B9CB20")]
		public PECGMKADMMG HFAEDKNMEEN()
		{
			return default(PECGMKADMMG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x80B93D0", Offset = "0x80B87D0", VA = "0x1880B93D0", Slot = "4")]
		public bool Equals(SerializedCombinationId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x822C3F0", Offset = "0x822B7F0", VA = "0x18822C3F0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedCombinationId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x822C4B0", Offset = "0x822B8B0", VA = "0x18822C4B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x996AE0", Offset = "0x995EE0", VA = "0x180996AE0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x822C4A0", Offset = "0x822B8A0", VA = "0x18822C4A0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, OOBOEDGJKIN
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
		[Cpp2IlInjected.Address(RVA = "0x11117A0", Offset = "0x1110BA0", VA = "0x1811117A0")]
		public SerializedCustomAvatarItemId(Guid KDBHLLEACIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public static SerializedCustomAvatarItemId LFGAKOBOICN(Guid KDBHLLEACIN)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x822C520", Offset = "0x822B920", VA = "0x18822C520", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140")]
		public static bool PEOCKCCHEIN(SerializedCustomAvatarItemId KGCKEJLFPJB, SerializedCustomAvatarItemId HKELKGIPNGP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x822C5C0", Offset = "0x822B9C0", VA = "0x18822C5C0")]
		public static bool OGMAAAEFFPP(SerializedCustomAvatarItemId KGCKEJLFPJB, SerializedCustomAvatarItemId HKELKGIPNGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x822C5E0", Offset = "0x822B9E0", VA = "0x18822C5E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, OOBOEDGJKIN
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
		[Cpp2IlInjected.Address(RVA = "0x822C6F0", Offset = "0x822BAF0", VA = "0x18822C6F0")]
		public static SerializedEquipmentSkinId IFKDBMKJNLP()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public HHJMMHNPOOC HFAEDKNMEEN()
		{
			return default(HHJMMHNPOOC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x822C650", Offset = "0x822BA50", VA = "0x18822C650", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x822C720", Offset = "0x822BB20", VA = "0x18822C720", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, OOBOEDGJKIN
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
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public IAPKGHKBDIJ HFAEDKNMEEN()
		{
			return default(IAPKGHKBDIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x822C790", Offset = "0x822BB90", VA = "0x18822C790", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x822C830", Offset = "0x822BC30", VA = "0x18822C830", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, OOBOEDGJKIN
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
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public BBKFOPKBGOL HFAEDKNMEEN()
		{
			return default(BBKFOPKBGOL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140", Slot = "4")]
		public bool Equals(SerializedFaceShapeId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x822C8A0", Offset = "0x822BCA0", VA = "0x18822C8A0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x822C940", Offset = "0x822BD40", VA = "0x18822C940", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, OOBOEDGJKIN
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
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790")]
		public PKEDJEKJOIK HFAEDKNMEEN()
		{
			return default(PKEDJEKJOIK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140", Slot = "4")]
		public bool Equals(SerializedHairPatternId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedHairPatternId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x822C9B0", Offset = "0x822BDB0", VA = "0x18822C9B0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x822C140", Offset = "0x822B540", VA = "0x18822C140")]
		public static bool PEOCKCCHEIN(SerializedHairPatternId KGCKEJLFPJB, SerializedHairPatternId HKELKGIPNGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x822CA50", Offset = "0x822BE50", VA = "0x18822CA50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, OOBOEDGJKIN
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
		[Cpp2IlInjected.Address(RVA = "0x1111790", Offset = "0x1110B90", VA = "0x181111790", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x80B93D0", Offset = "0x80B87D0", VA = "0x1880B93D0", Slot = "4")]
		public bool Equals(SerializedMaterialId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x822CAC0", Offset = "0x822BEC0", VA = "0x18822CAC0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7708FF0", Offset = "0x77083F0", VA = "0x187708FF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7708E60", Offset = "0x7708260", VA = "0x187708E60", Slot = "5")]
		public int CompareTo(SerializedMaterialId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x822CB60", Offset = "0x822BF60", VA = "0x18822CB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class AFKFBFPBMPO : IKKNLBGAIJE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AFKFBFPBMPO DNEPPKLGBFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8219B50", Offset = "0x8218F50", VA = "0x188219B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public CHOCLPPHKEE<LALAGECKOGA> EKPHPKKEOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8219A30", Offset = "0x8218E30", VA = "0x188219A30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CHOCLPPHKEE<HHJMMHNPOOC> CMJIIHMHPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8219AF0", Offset = "0x8218EF0", VA = "0x188219AF0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CHOCLPPHKEE<PKEDJEKJOIK> LDMBFFJFKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8219C10", Offset = "0x8219010", VA = "0x188219C10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CHOCLPPHKEE<PECGMKADMMG> JAAAIEDMJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x82199D0", Offset = "0x8218DD0", VA = "0x1882199D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CHOCLPPHKEE<MDKOOLPNNLA> OLHEHPEENIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8219A90", Offset = "0x8218E90", VA = "0x188219A90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CHOCLPPHKEE<BBKFOPKBGOL> EPLPMJMFJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8219C70", Offset = "0x8219070", VA = "0x188219C70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CHOCLPPHKEE<AOAHCJAKMBM> COKGNPANNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8219970", Offset = "0x8218D70", VA = "0x188219970", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CHOCLPPHKEE<IAPKGHKBDIJ> EEMKDHJIAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8219BB0", Offset = "0x8218FB0", VA = "0x188219BB0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class KJGMJENHGEC
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x822A240", Offset = "0x8229640", VA = "0x18822A240")]
	public static Guid BPFOKCDGIGC(string HNHKIDAKLJF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x822A2F0", Offset = "0x82296F0", VA = "0x18822A2F0")]
	public static bool DCNABFJEJOP(string HNHKIDAKLJF, [Out] Guid KDBHLLEACIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GEGIBNJFLHP : BMAOANLOBOM<LALAGECKOGA>, IMDHMAINHLG<LALAGECKOGA>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x821B920", Offset = "0x821AD20", VA = "0x18821B920", Slot = "4")]
	public IEnumerable<(LALAGECKOGA, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x821B900", Offset = "0x821AD00", VA = "0x18821B900", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8219CD0", Offset = "0x82190D0", VA = "0x188219CD0", Slot = "6")]
	public LALAGECKOGA AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(LALAGECKOGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public GEGIBNJFLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FEGBPGLOEEN : BMAOANLOBOM<AOAHCJAKMBM>, IMDHMAINHLG<AOAHCJAKMBM>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x821B560", Offset = "0x821A960", VA = "0x18821B560", Slot = "4")]
	public IEnumerable<(AOAHCJAKMBM, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD5A0F0", Offset = "0xD594F0", VA = "0x180D5A0F0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8219CD0", Offset = "0x82190D0", VA = "0x188219CD0", Slot = "6")]
	public AOAHCJAKMBM AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(AOAHCJAKMBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public FEGBPGLOEEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KAEGMLGNCAD : BMAOANLOBOM<MDKOOLPNNLA>, IMDHMAINHLG<MDKOOLPNNLA>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8220570", Offset = "0x821F970", VA = "0x188220570", Slot = "4")]
	public IEnumerable<(MDKOOLPNNLA, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xD5A0F0", Offset = "0xD594F0", VA = "0x180D5A0F0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8219CD0", Offset = "0x82190D0", VA = "0x188219CD0", Slot = "6")]
	public MDKOOLPNNLA AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(MDKOOLPNNLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public KAEGMLGNCAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DFOFNECFFLG : BMAOANLOBOM<PECGMKADMMG>, IMDHMAINHLG<PECGMKADMMG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly IMDHMAINHLG<PBNOFEILNDB> GKGHFHJJNHL;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x99CAA0", Offset = "0x99BEA0", VA = "0x18099CAA0")]
	public DFOFNECFFLG(IMDHMAINHLG<PBNOFEILNDB> GKGHFHJJNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x80B95B0", Offset = "0x80B89B0", VA = "0x1880B95B0", Slot = "4")]
	public IEnumerable<(PECGMKADMMG, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8219D90", Offset = "0x8219190", VA = "0x188219D90", Slot = "6")]
	public PECGMKADMMG AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(PECGMKADMMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8219FD0", Offset = "0x82193D0", VA = "0x188219FD0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KGJGHFJJJBG : BMAOANLOBOM<HHJMMHNPOOC>, IMDHMAINHLG<HHJMMHNPOOC>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8222630", Offset = "0x8221A30", VA = "0x188222630", Slot = "4")]
	public IEnumerable<(HHJMMHNPOOC, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD5A0F0", Offset = "0xD594F0", VA = "0x180D5A0F0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8219CD0", Offset = "0x82190D0", VA = "0x188219CD0", Slot = "6")]
	public HHJMMHNPOOC AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(HHJMMHNPOOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public KGJGHFJJJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KNPJMBCGEAI : BMAOANLOBOM<IAPKGHKBDIJ>, IMDHMAINHLG<IAPKGHKBDIJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x822A3C0", Offset = "0x82297C0", VA = "0x18822A3C0", Slot = "4")]
	public IEnumerable<(IAPKGHKBDIJ, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xD5A0F0", Offset = "0xD594F0", VA = "0x180D5A0F0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8219CD0", Offset = "0x82190D0", VA = "0x188219CD0", Slot = "6")]
	public IAPKGHKBDIJ AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(IAPKGHKBDIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public KNPJMBCGEAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OFHLLKEAPMP : BMAOANLOBOM<BBKFOPKBGOL>, IMDHMAINHLG<BBKFOPKBGOL>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x822BC80", Offset = "0x822B080", VA = "0x18822BC80", Slot = "4")]
	public IEnumerable<(BBKFOPKBGOL, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xD5A0F0", Offset = "0xD594F0", VA = "0x180D5A0F0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8219CD0", Offset = "0x82190D0", VA = "0x188219CD0", Slot = "6")]
	public BBKFOPKBGOL AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(BBKFOPKBGOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public OFHLLKEAPMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DKCOMHKAPFI : BMAOANLOBOM<PKEDJEKJOIK>, IMDHMAINHLG<PKEDJEKJOIK>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x821A010", Offset = "0x8219410", VA = "0x18821A010", Slot = "4")]
	public IEnumerable<(PKEDJEKJOIK, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xD5A0F0", Offset = "0xD594F0", VA = "0x180D5A0F0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8219CD0", Offset = "0x82190D0", VA = "0x188219CD0", Slot = "6")]
	public PKEDJEKJOIK AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(PKEDJEKJOIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public DKCOMHKAPFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BMAOANLOBOM<TModern> : IMDHMAINHLG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> BMADEEOLAAN();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string ALHCPFGPADE(string FEHKMADEKDH);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class CBBLBPPCBBK : BMAOANLOBOM<PBNOFEILNDB>, IMDHMAINHLG<PBNOFEILNDB>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x816E6D0", Offset = "0x816DAD0", VA = "0x18816E6D0", Slot = "4")]
	public IEnumerable<(PBNOFEILNDB, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xD5A0F0", Offset = "0xD594F0", VA = "0x180D5A0F0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8219CD0", Offset = "0x82190D0", VA = "0x188219CD0", Slot = "6")]
	public PBNOFEILNDB AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(PBNOFEILNDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
	public CBBLBPPCBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class NOHAFLFJGAA<TModern> : CHOCLPPHKEE<TModern>, IMDHMAINHLG<TModern> where TModern : IEquatable<TModern>, OOBOEDGJKIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> NGDGMOAKAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> DHHCGHAICFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly BMAOANLOBOM<TModern> BMFFBLNHJGD;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x50EC6B0", Offset = "0x50EBAB0", VA = "0x1850EC6B0")]
	public NOHAFLFJGAA(BMAOANLOBOM<TModern> BMFFBLNHJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x50E9820", Offset = "0x50E8C20", VA = "0x1850E9820", Slot = "5")]
	public TModern AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x50EA790", Offset = "0x50E9B90", VA = "0x1850EA790", Slot = "4")]
	public string ELFKGOBGGMD(TModern LHJFMKACFII)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class EBJMMMABOAP : IKKNLBGAIJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NOHAFLFJGAA<LALAGECKOGA> GJLFOGEPEHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NOHAFLFJGAA<HHJMMHNPOOC> EJJDKPELNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NOHAFLFJGAA<PKEDJEKJOIK> HEFFFOCOPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NOHAFLFJGAA<PBNOFEILNDB> GKGHFHJJNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NOHAFLFJGAA<PECGMKADMMG> IFODOMMDEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NOHAFLFJGAA<MDKOOLPNNLA> ODCFJIHJJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NOHAFLFJGAA<BBKFOPKBGOL> HKOBCBBDDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NOHAFLFJGAA<AOAHCJAKMBM> ANPKDLGIDMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private NOHAFLFJGAA<IAPKGHKBDIJ> EDBEHDGLFNF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public CHOCLPPHKEE<LALAGECKOGA> EKPHPKKEOED
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9943E0", Offset = "0x9937E0", VA = "0x1809943E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CHOCLPPHKEE<HHJMMHNPOOC> CMJIIHMHPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9931C0", Offset = "0x9925C0", VA = "0x1809931C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CHOCLPPHKEE<PKEDJEKJOIK> LDMBFFJFKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public CHOCLPPHKEE<PECGMKADMMG> JAAAIEDMJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9944C0", Offset = "0x9938C0", VA = "0x1809944C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public CHOCLPPHKEE<MDKOOLPNNLA> OLHEHPEENIP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9943F0", Offset = "0x9937F0", VA = "0x1809943F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public CHOCLPPHKEE<BBKFOPKBGOL> EPLPMJMFJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x994360", Offset = "0x993760", VA = "0x180994360", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public CHOCLPPHKEE<AOAHCJAKMBM> COKGNPANNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9943C0", Offset = "0x9937C0", VA = "0x1809943C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public CHOCLPPHKEE<IAPKGHKBDIJ> EEMKDHJIAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x993A70", Offset = "0x992E70", VA = "0x180993A70", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x821A690", Offset = "0x8219A90", VA = "0x18821A690")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	[UsedImplicitly]
	internal static void OPNOJEPKKPP(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x821A700", Offset = "0x8219B00", VA = "0x18821A700")]
	[RecRoom.NoEngine.Common.Preserve]
	public EBJMMMABOAP()
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
