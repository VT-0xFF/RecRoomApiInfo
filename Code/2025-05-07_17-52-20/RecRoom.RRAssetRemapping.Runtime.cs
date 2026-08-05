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
		[Cpp2IlInjected.Address(RVA = "0x862F410", Offset = "0x862E410", VA = "0x18862F410", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2643640", Offset = "0x2642640", VA = "0x182643640")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class ABPOGPIHKFI : NGJIPCEJOIB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex KKENPPFNLNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly POAKPCMKJOA ABPDFJDNHFE;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x861CA10", Offset = "0x861BA10", VA = "0x18861CA10")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	[UsedImplicitly]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x861C670", Offset = "0x861B670", VA = "0x18861C670")]
	[UsedImplicitly]
	internal static void BMHNPALNOAJ(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ABPOGPIHKFI([DJIFKCCBBND(null)] POAKPCMKJOA ABPDFJDNHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x861C6D0", Offset = "0x861B6D0", VA = "0x18861C6D0", Slot = "4")]
	public string DFNAEDFOBIJ(KEEOBDBOKHK HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x861C1A0", Offset = "0x861B1A0", VA = "0x18861C1A0", Slot = "5")]
	public KEEOBDBOKHK AKDPGDCBDMI(string HPLMFDGMJFE)
	{
		return default(KEEOBDBOKHK);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, AKFPMLPANDI
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
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0")]
		public PJDNIEDEHFC AKDPGDCBDMI()
		{
			return default(PJDNIEDEHFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970", Slot = "4")]
		public bool Equals(SerializedAvatarItemId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x862E8D0", Offset = "0x862D8D0", VA = "0x18862E8D0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x862E990", Offset = "0x862D990", VA = "0x18862E990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, AKFPMLPANDI
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
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0")]
		public NBBDHCNOOIC AKDPGDCBDMI()
		{
			return default(NBBDHCNOOIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970", Slot = "4")]
		public bool Equals(SerializedBodyShapeId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x862EA00", Offset = "0x862DA00", VA = "0x18862EA00", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x862EAA0", Offset = "0x862DAA0", VA = "0x18862EAA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, AKFPMLPANDI
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
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0")]
		public ODFBDNOADGM AKDPGDCBDMI()
		{
			return default(ODFBDNOADGM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970", Slot = "4")]
		public bool Equals(SerializedColorId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedColorId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x862EB10", Offset = "0x862DB10", VA = "0x18862EB10", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x862EBB0", Offset = "0x862DBB0", VA = "0x18862EBB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, AKFPMLPANDI, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xF79DC0", Offset = "0xF78DC0", VA = "0x180F79DC0")]
		public DHMNCODBNBK AKDPGDCBDMI()
		{
			return default(DHMNCODBNBK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84BA550", Offset = "0x84B9550", VA = "0x1884BA550", Slot = "4")]
		public bool Equals(SerializedCombinationId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x862EC20", Offset = "0x862DC20", VA = "0x18862EC20", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedCombinationId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x862ECE0", Offset = "0x862DCE0", VA = "0x18862ECE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x862ECD0", Offset = "0x862DCD0", VA = "0x18862ECD0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, AKFPMLPANDI
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
		[Cpp2IlInjected.Address(RVA = "0x12010B0", Offset = "0x12000B0", VA = "0x1812010B0")]
		public SerializedCustomAvatarItemId(Guid DGNNPFFMIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0")]
		public static SerializedCustomAvatarItemId GBHDGEFJFAM(Guid DGNNPFFMIEE)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x862ED70", Offset = "0x862DD70", VA = "0x18862ED70", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970")]
		public static bool MMJMCICIDNJ(SerializedCustomAvatarItemId JOOBCOFNIAM, SerializedCustomAvatarItemId MCIIEEEAOOL)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x862ED50", Offset = "0x862DD50", VA = "0x18862ED50")]
		public static bool DIKHMNDIIDO(SerializedCustomAvatarItemId JOOBCOFNIAM, SerializedCustomAvatarItemId MCIIEEEAOOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x862EE10", Offset = "0x862DE10", VA = "0x18862EE10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, AKFPMLPANDI
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
		[Cpp2IlInjected.Address(RVA = "0x862EF20", Offset = "0x862DF20", VA = "0x18862EF20")]
		public static SerializedEquipmentSkinId IEBNEPNHPII()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0")]
		public JCHDCCIJPPE AKDPGDCBDMI()
		{
			return default(JCHDCCIJPPE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x862EE80", Offset = "0x862DE80", VA = "0x18862EE80", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x862EF50", Offset = "0x862DF50", VA = "0x18862EF50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, AKFPMLPANDI
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
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0")]
		public MCAONEJPGJL AKDPGDCBDMI()
		{
			return default(MCAONEJPGJL);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x862EFC0", Offset = "0x862DFC0", VA = "0x18862EFC0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x862F060", Offset = "0x862E060", VA = "0x18862F060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, AKFPMLPANDI
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
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0")]
		public CMKLJFNAGCE AKDPGDCBDMI()
		{
			return default(CMKLJFNAGCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970", Slot = "4")]
		public bool Equals(SerializedFaceShapeId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x862F0D0", Offset = "0x862E0D0", VA = "0x18862F0D0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x862F170", Offset = "0x862E170", VA = "0x18862F170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, AKFPMLPANDI
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
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0")]
		public MMHDKHFCIBF AKDPGDCBDMI()
		{
			return default(MMHDKHFCIBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970", Slot = "4")]
		public bool Equals(SerializedHairPatternId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedHairPatternId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x862F1E0", Offset = "0x862E1E0", VA = "0x18862F1E0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x862E970", Offset = "0x862D970", VA = "0x18862E970")]
		public static bool MMJMCICIDNJ(SerializedHairPatternId JOOBCOFNIAM, SerializedHairPatternId MCIIEEEAOOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x862F280", Offset = "0x862E280", VA = "0x18862F280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, AKFPMLPANDI
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
		[Cpp2IlInjected.Address(RVA = "0x12010C0", Offset = "0x12000C0", VA = "0x1812010C0", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84BA550", Offset = "0x84B9550", VA = "0x1884BA550", Slot = "4")]
		public bool Equals(SerializedMaterialId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x862F2F0", Offset = "0x862E2F0", VA = "0x18862F2F0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2BA0", Offset = "0x7AE1BA0", VA = "0x187AE2BA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7AE2A10", Offset = "0x7AE1A10", VA = "0x187AE2A10", Slot = "5")]
		public int CompareTo(SerializedMaterialId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x862F3A0", Offset = "0x862E3A0", VA = "0x18862F3A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class BEHLMFHPBHA : POAKPCMKJOA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static BEHLMFHPBHA MLIJHBGBMKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x861CBE0", Offset = "0x861BBE0", VA = "0x18861CBE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JNCCJLHKFDA<PJDNIEDEHFC> BCGHJGNPIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x861CE20", Offset = "0x861BE20", VA = "0x18861CE20", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JNCCJLHKFDA<JCHDCCIJPPE> PDHBJOPPDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x861CB20", Offset = "0x861BB20", VA = "0x18861CB20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JNCCJLHKFDA<MMHDKHFCIBF> NALOJAANKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x861CB80", Offset = "0x861BB80", VA = "0x18861CB80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JNCCJLHKFDA<DHMNCODBNBK> OJLBHIPICPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x861CC40", Offset = "0x861BC40", VA = "0x18861CC40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JNCCJLHKFDA<ODFBDNOADGM> LHACGMAPIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x861CD00", Offset = "0x861BD00", VA = "0x18861CD00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JNCCJLHKFDA<CMKLJFNAGCE> LGJALIOBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x861CD60", Offset = "0x861BD60", VA = "0x18861CD60", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JNCCJLHKFDA<NBBDHCNOOIC> DKPHLCHFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x861CDC0", Offset = "0x861BDC0", VA = "0x18861CDC0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JNCCJLHKFDA<MCAONEJPGJL> DCCBJCBGANI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x861CCA0", Offset = "0x861BCA0", VA = "0x18861CCA0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class PMMNPGIAJBP
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x862E820", Offset = "0x862D820", VA = "0x18862E820")]
	public static Guid INNFBMLBDLI(string EMJGDNEIDKA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x862E750", Offset = "0x862D750", VA = "0x18862E750")]
	public static bool IMKCHEJPMIF(string EMJGDNEIDKA, [Out] Guid DGNNPFFMIEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FHLMDKLLIMH : OMECPKCMFFO<PJDNIEDEHFC>, FMFMCJMIEMN<PJDNIEDEHFC>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x861D2E0", Offset = "0x861C2E0", VA = "0x18861D2E0", Slot = "4")]
	public IEnumerable<(PJDNIEDEHFC, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8621F30", Offset = "0x8620F30", VA = "0x188621F30", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x861D220", Offset = "0x861C220", VA = "0x18861D220", Slot = "6")]
	public PJDNIEDEHFC PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(PJDNIEDEHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public FHLMDKLLIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CALDGFABNON : OMECPKCMFFO<NBBDHCNOOIC>, FMFMCJMIEMN<NBBDHCNOOIC>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x861CE80", Offset = "0x861BE80", VA = "0x18861CE80", Slot = "4")]
	public IEnumerable<(NBBDHCNOOIC, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA74AA0", VA = "0x180A75AA0", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x861D220", Offset = "0x861C220", VA = "0x18861D220", Slot = "6")]
	public NBBDHCNOOIC PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(NBBDHCNOOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public CALDGFABNON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LHLNMDFOCEM : OMECPKCMFFO<ODFBDNOADGM>, FMFMCJMIEMN<ODFBDNOADGM>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x86231C0", Offset = "0x86221C0", VA = "0x1886231C0", Slot = "4")]
	public IEnumerable<(ODFBDNOADGM, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA74AA0", VA = "0x180A75AA0", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x861D220", Offset = "0x861C220", VA = "0x18861D220", Slot = "6")]
	public ODFBDNOADGM PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(ODFBDNOADGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public LHLNMDFOCEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GNNMFMPHDKF : OMECPKCMFFO<DHMNCODBNBK>, FMFMCJMIEMN<DHMNCODBNBK>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly FMFMCJMIEMN<PGCIDDDFGOL> HOIMPBFIOHF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9FE6D0", Offset = "0x9FD6D0", VA = "0x1809FE6D0")]
	public GNNMFMPHDKF(FMFMCJMIEMN<PGCIDDDFGOL> HOIMPBFIOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84BBDE0", Offset = "0x84BADE0", VA = "0x1884BBDE0", Slot = "4")]
	public IEnumerable<(DHMNCODBNBK, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8621F90", Offset = "0x8620F90", VA = "0x188621F90", Slot = "6")]
	public DHMNCODBNBK PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(DHMNCODBNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x8621F50", Offset = "0x8620F50", VA = "0x188621F50", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MGMGHKEOONA : OMECPKCMFFO<JCHDCCIJPPE>, FMFMCJMIEMN<JCHDCCIJPPE>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8625280", Offset = "0x8624280", VA = "0x188625280", Slot = "4")]
	public IEnumerable<(JCHDCCIJPPE, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA74AA0", VA = "0x180A75AA0", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x861D220", Offset = "0x861C220", VA = "0x18861D220", Slot = "6")]
	public JCHDCCIJPPE PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(JCHDCCIJPPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public MGMGHKEOONA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OMGOOJHCFAM : OMECPKCMFFO<MCAONEJPGJL>, FMFMCJMIEMN<MCAONEJPGJL>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x862CE90", Offset = "0x862BE90", VA = "0x18862CE90", Slot = "4")]
	public IEnumerable<(MCAONEJPGJL, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA74AA0", VA = "0x180A75AA0", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x861D220", Offset = "0x861C220", VA = "0x18861D220", Slot = "6")]
	public MCAONEJPGJL PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(MCAONEJPGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public OMGOOJHCFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KBDOAPOBAKL : OMECPKCMFFO<CMKLJFNAGCE>, FMFMCJMIEMN<CMKLJFNAGCE>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8622DA0", Offset = "0x8621DA0", VA = "0x188622DA0", Slot = "4")]
	public IEnumerable<(CMKLJFNAGCE, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA74AA0", VA = "0x180A75AA0", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x861D220", Offset = "0x861C220", VA = "0x18861D220", Slot = "6")]
	public CMKLJFNAGCE PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(CMKLJFNAGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public KBDOAPOBAKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JKFPNLOEHLN : OMECPKCMFFO<MMHDKHFCIBF>, FMFMCJMIEMN<MMHDKHFCIBF>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x86221D0", Offset = "0x86211D0", VA = "0x1886221D0", Slot = "4")]
	public IEnumerable<(MMHDKHFCIBF, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA74AA0", VA = "0x180A75AA0", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x861D220", Offset = "0x861C220", VA = "0x18861D220", Slot = "6")]
	public MMHDKHFCIBF PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(MMHDKHFCIBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public JKFPNLOEHLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface OMECPKCMFFO<TModern> : FMFMCJMIEMN<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> DNAJFBPDBAD();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string PACPFEMOCIB(string BGLOIEKEICN);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class PMBGLFKMHAA : OMECPKCMFFO<PGCIDDDFGOL>, FMFMCJMIEMN<PGCIDDDFGOL>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x8570F00", Offset = "0x856FF00", VA = "0x188570F00", Slot = "4")]
	public IEnumerable<(PGCIDDDFGOL, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA75AA0", Offset = "0xA74AA0", VA = "0x180A75AA0", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x861D220", Offset = "0x861C220", VA = "0x18861D220", Slot = "6")]
	public PGCIDDDFGOL PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(PGCIDDDFGOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	public PMBGLFKMHAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LMFGGCKCPNC<TModern> : JNCCJLHKFDA<TModern>, FMFMCJMIEMN<TModern> where TModern : IEquatable<TModern>, AKFPMLPANDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> FPBHEELOIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> IDGAJIGBJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly OMECPKCMFFO<TModern> NBHFAODHKKM;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x51264A0", Offset = "0x51254A0", VA = "0x1851264A0")]
	public LMFGGCKCPNC(OMECPKCMFFO<TModern> NBHFAODHKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x51234E0", Offset = "0x51224E0", VA = "0x1851234E0", Slot = "5")]
	public TModern PNCGAEDBIID(string BGLOIEKEICN)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5122860", Offset = "0x5121860", VA = "0x185122860", Slot = "4")]
	public string BIJHCFBJPFJ(TModern EAHHHOBLBNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JNNBAKHABDF : POAKPCMKJOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private LMFGGCKCPNC<PJDNIEDEHFC> JCMPMBLILEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private LMFGGCKCPNC<JCHDCCIJPPE> IHDFHHHKHEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private LMFGGCKCPNC<MMHDKHFCIBF> NHKENHBGOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private LMFGGCKCPNC<PGCIDDDFGOL> HOIMPBFIOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private LMFGGCKCPNC<DHMNCODBNBK> KAAFOIEFHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private LMFGGCKCPNC<ODFBDNOADGM> CJFLLBODHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private LMFGGCKCPNC<CMKLJFNAGCE> FOKLOOPCHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private LMFGGCKCPNC<NBBDHCNOOIC> PNADCPMDJCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private LMFGGCKCPNC<MCAONEJPGJL> CGIMPDHDHNH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public JNCCJLHKFDA<PJDNIEDEHFC> BCGHJGNPIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JNCCJLHKFDA<JCHDCCIJPPE> PDHBJOPPDED
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JNCCJLHKFDA<MMHDKHFCIBF> NALOJAANKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JNCCJLHKFDA<DHMNCODBNBK> OJLBHIPICPG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JNCCJLHKFDA<ODFBDNOADGM> LHACGMAPIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JNCCJLHKFDA<CMKLJFNAGCE> LGJALIOBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JNCCJLHKFDA<NBBDHCNOOIC> DKPHLCHFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9F17A0", Offset = "0x9F07A0", VA = "0x1809F17A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JNCCJLHKFDA<MCAONEJPGJL> DCCBJCBGANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8622850", Offset = "0x8621850", VA = "0x188622850")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	[UsedImplicitly]
	internal static void CPNCJILCPPN(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x86228C0", Offset = "0x86218C0", VA = "0x1886228C0")]
	[RecRoom.NoEngine.Common.Preserve]
	public JNNBAKHABDF()
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
