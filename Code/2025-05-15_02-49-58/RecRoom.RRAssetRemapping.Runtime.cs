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
		[Cpp2IlInjected.Address(RVA = "0x8614D70", Offset = "0x8613370", VA = "0x188614D70", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2645EC0", Offset = "0x26444C0", VA = "0x182645EC0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8602380", Offset = "0x8600980", VA = "0x188602380")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	[UsedImplicitly]
	internal static void MAKIPFCGLCJ(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8601FE0", Offset = "0x86005E0", VA = "0x188601FE0")]
	[UsedImplicitly]
	internal static void BMHNPALNOAJ(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	[RecRoom.NoEngine.Common.Preserve]
	public ABPOGPIHKFI([DJIFKCCBBND(null)] POAKPCMKJOA ABPDFJDNHFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8602040", Offset = "0x8600640", VA = "0x188602040", Slot = "4")]
	public string DFNAEDFOBIJ(KEEOBDBOKHK HPLMFDGMJFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8601B10", Offset = "0x8600110", VA = "0x188601B10", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public PJDNIEDEHFC AKDPGDCBDMI()
		{
			return default(PJDNIEDEHFC);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8614240", Offset = "0x8612840", VA = "0x188614240", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8614300", Offset = "0x8612900", VA = "0x188614300", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public NBBDHCNOOIC AKDPGDCBDMI()
		{
			return default(NBBDHCNOOIC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8614370", Offset = "0x8612970", VA = "0x188614370", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8614410", Offset = "0x8612A10", VA = "0x188614410", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public ODFBDNOADGM AKDPGDCBDMI()
		{
			return default(ODFBDNOADGM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0", Slot = "4")]
		public bool Equals(SerializedColorId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedColorId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8614480", Offset = "0x8612A80", VA = "0x188614480", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8614520", Offset = "0x8612B20", VA = "0x188614520", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xF8C400", Offset = "0xF8AA00", VA = "0x180F8C400")]
		public DHMNCODBNBK AKDPGDCBDMI()
		{
			return default(DHMNCODBNBK);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x849FF60", Offset = "0x849E560", VA = "0x18849FF60", Slot = "4")]
		public bool Equals(SerializedCombinationId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8614590", Offset = "0x8612B90", VA = "0x188614590", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedCombinationId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8614650", Offset = "0x8612C50", VA = "0x188614650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8614640", Offset = "0x8612C40", VA = "0x188614640", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x1215810", Offset = "0x1213E10", VA = "0x181215810")]
		public SerializedCustomAvatarItemId(Guid DGNNPFFMIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public static SerializedCustomAvatarItemId GBHDGEFJFAM(Guid DGNNPFFMIEE)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x86146E0", Offset = "0x8612CE0", VA = "0x1886146E0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0")]
		public static bool MMJMCICIDNJ(SerializedCustomAvatarItemId JOOBCOFNIAM, SerializedCustomAvatarItemId MCIIEEEAOOL)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x86146C0", Offset = "0x8612CC0", VA = "0x1886146C0")]
		public static bool DIKHMNDIIDO(SerializedCustomAvatarItemId JOOBCOFNIAM, SerializedCustomAvatarItemId MCIIEEEAOOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8614780", Offset = "0x8612D80", VA = "0x188614780", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8614890", Offset = "0x8612E90", VA = "0x188614890")]
		public static SerializedEquipmentSkinId IEBNEPNHPII()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public JCHDCCIJPPE AKDPGDCBDMI()
		{
			return default(JCHDCCIJPPE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86147F0", Offset = "0x8612DF0", VA = "0x1886147F0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86148C0", Offset = "0x8612EC0", VA = "0x1886148C0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public MCAONEJPGJL AKDPGDCBDMI()
		{
			return default(MCAONEJPGJL);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8614930", Offset = "0x8612F30", VA = "0x188614930", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86149D0", Offset = "0x8612FD0", VA = "0x1886149D0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public CMKLJFNAGCE AKDPGDCBDMI()
		{
			return default(CMKLJFNAGCE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8614A40", Offset = "0x8613040", VA = "0x188614A40", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8614AE0", Offset = "0x86130E0", VA = "0x188614AE0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820")]
		public MMHDKHFCIBF AKDPGDCBDMI()
		{
			return default(MMHDKHFCIBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0", Slot = "4")]
		public bool Equals(SerializedHairPatternId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8614B50", Offset = "0x8613150", VA = "0x188614B50", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86142E0", Offset = "0x86128E0", VA = "0x1886142E0")]
		public static bool MMJMCICIDNJ(SerializedHairPatternId JOOBCOFNIAM, SerializedHairPatternId MCIIEEEAOOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8614BF0", Offset = "0x86131F0", VA = "0x188614BF0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1215820", Offset = "0x1213E20", VA = "0x181215820", Slot = "6")]
		public Guid ALEBNNAILDG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x849FF60", Offset = "0x849E560", VA = "0x18849FF60", Slot = "4")]
		public bool Equals(SerializedMaterialId MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8614C60", Offset = "0x8613260", VA = "0x188614C60", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7AB2280", Offset = "0x7AB0880", VA = "0x187AB2280", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7AB20F0", Offset = "0x7AB06F0", VA = "0x187AB20F0", Slot = "5")]
		public int CompareTo(SerializedMaterialId MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8614D00", Offset = "0x8613300", VA = "0x188614D00", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8602550", Offset = "0x8600B50", VA = "0x188602550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public JNCCJLHKFDA<PJDNIEDEHFC> BCGHJGNPIKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8602790", Offset = "0x8600D90", VA = "0x188602790", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public JNCCJLHKFDA<JCHDCCIJPPE> PDHBJOPPDED
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8602490", Offset = "0x8600A90", VA = "0x188602490", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JNCCJLHKFDA<MMHDKHFCIBF> NALOJAANKDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x86024F0", Offset = "0x8600AF0", VA = "0x1886024F0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public JNCCJLHKFDA<DHMNCODBNBK> OJLBHIPICPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x86025B0", Offset = "0x8600BB0", VA = "0x1886025B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public JNCCJLHKFDA<ODFBDNOADGM> LHACGMAPIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8602670", Offset = "0x8600C70", VA = "0x188602670", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public JNCCJLHKFDA<CMKLJFNAGCE> LGJALIOBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x86026D0", Offset = "0x8600CD0", VA = "0x1886026D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JNCCJLHKFDA<NBBDHCNOOIC> DKPHLCHFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8602730", Offset = "0x8600D30", VA = "0x188602730", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JNCCJLHKFDA<MCAONEJPGJL> DCCBJCBGANI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8602610", Offset = "0x8600C10", VA = "0x188602610", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x8614190", Offset = "0x8612790", VA = "0x188614190")]
	public static Guid INNFBMLBDLI(string EMJGDNEIDKA)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x86140C0", Offset = "0x86126C0", VA = "0x1886140C0")]
	public static bool IMKCHEJPMIF(string EMJGDNEIDKA, [Out] Guid DGNNPFFMIEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FHLMDKLLIMH : OMECPKCMFFO<PJDNIEDEHFC>, FMFMCJMIEMN<PJDNIEDEHFC>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8602C50", Offset = "0x8601250", VA = "0x188602C50", Slot = "4")]
	public IEnumerable<(PJDNIEDEHFC, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x86078A0", Offset = "0x8605EA0", VA = "0x1886078A0", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8602B90", Offset = "0x8601190", VA = "0x188602B90", Slot = "6")]
	public PJDNIEDEHFC PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(PJDNIEDEHFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public FHLMDKLLIMH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CALDGFABNON : OMECPKCMFFO<NBBDHCNOOIC>, FMFMCJMIEMN<NBBDHCNOOIC>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x86027F0", Offset = "0x8600DF0", VA = "0x1886027F0", Slot = "4")]
	public IEnumerable<(NBBDHCNOOIC, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA89310", Offset = "0xA87910", VA = "0x180A89310", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x8602B90", Offset = "0x8601190", VA = "0x188602B90", Slot = "6")]
	public NBBDHCNOOIC PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(NBBDHCNOOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public CALDGFABNON()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LHLNMDFOCEM : OMECPKCMFFO<ODFBDNOADGM>, FMFMCJMIEMN<ODFBDNOADGM>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x8608B30", Offset = "0x8607130", VA = "0x188608B30", Slot = "4")]
	public IEnumerable<(ODFBDNOADGM, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xA89310", Offset = "0xA87910", VA = "0x180A89310", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x8602B90", Offset = "0x8601190", VA = "0x188602B90", Slot = "6")]
	public ODFBDNOADGM PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(ODFBDNOADGM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F86D0", Offset = "0x9F6CD0", VA = "0x1809F86D0")]
	public GNNMFMPHDKF(FMFMCJMIEMN<PGCIDDDFGOL> HOIMPBFIOHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84A1750", Offset = "0x849FD50", VA = "0x1884A1750", Slot = "4")]
	public IEnumerable<(DHMNCODBNBK, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8607900", Offset = "0x8605F00", VA = "0x188607900", Slot = "6")]
	public DHMNCODBNBK PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(DHMNCODBNBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x86078C0", Offset = "0x8605EC0", VA = "0x1886078C0", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class MGMGHKEOONA : OMECPKCMFFO<JCHDCCIJPPE>, FMFMCJMIEMN<JCHDCCIJPPE>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x860ABF0", Offset = "0x86091F0", VA = "0x18860ABF0", Slot = "4")]
	public IEnumerable<(JCHDCCIJPPE, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xA89310", Offset = "0xA87910", VA = "0x180A89310", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8602B90", Offset = "0x8601190", VA = "0x188602B90", Slot = "6")]
	public JCHDCCIJPPE PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(JCHDCCIJPPE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public MGMGHKEOONA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OMGOOJHCFAM : OMECPKCMFFO<MCAONEJPGJL>, FMFMCJMIEMN<MCAONEJPGJL>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8612800", Offset = "0x8610E00", VA = "0x188612800", Slot = "4")]
	public IEnumerable<(MCAONEJPGJL, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA89310", Offset = "0xA87910", VA = "0x180A89310", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x8602B90", Offset = "0x8601190", VA = "0x188602B90", Slot = "6")]
	public MCAONEJPGJL PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(MCAONEJPGJL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public OMGOOJHCFAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KBDOAPOBAKL : OMECPKCMFFO<CMKLJFNAGCE>, FMFMCJMIEMN<CMKLJFNAGCE>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8608710", Offset = "0x8606D10", VA = "0x188608710", Slot = "4")]
	public IEnumerable<(CMKLJFNAGCE, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xA89310", Offset = "0xA87910", VA = "0x180A89310", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x8602B90", Offset = "0x8601190", VA = "0x188602B90", Slot = "6")]
	public CMKLJFNAGCE PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(CMKLJFNAGCE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public KBDOAPOBAKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class JKFPNLOEHLN : OMECPKCMFFO<MMHDKHFCIBF>, FMFMCJMIEMN<MMHDKHFCIBF>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8607B40", Offset = "0x8606140", VA = "0x188607B40", Slot = "4")]
	public IEnumerable<(MMHDKHFCIBF, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xA89310", Offset = "0xA87910", VA = "0x180A89310", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x8602B90", Offset = "0x8601190", VA = "0x188602B90", Slot = "6")]
	public MMHDKHFCIBF PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(MMHDKHFCIBF);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x8556870", Offset = "0x8554E70", VA = "0x188556870", Slot = "4")]
	public IEnumerable<(PGCIDDDFGOL, string)> DNAJFBPDBAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xA89310", Offset = "0xA87910", VA = "0x180A89310", Slot = "5")]
	public string PACPFEMOCIB(string BGLOIEKEICN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x8602B90", Offset = "0x8601190", VA = "0x188602B90", Slot = "6")]
	public PGCIDDDFGOL PNCGAEDBIID(string BGLOIEKEICN)
	{
		return default(PGCIDDDFGOL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[Cpp2IlInjected.Address(RVA = "0x5154D70", Offset = "0x5153370", VA = "0x185154D70")]
	public LMFGGCKCPNC(OMECPKCMFFO<TModern> NBHFAODHKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5151EC0", Offset = "0x51504C0", VA = "0x185151EC0", Slot = "5")]
	public TModern PNCGAEDBIID(string BGLOIEKEICN)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5151240", Offset = "0x514F840", VA = "0x185151240", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public JNCCJLHKFDA<JCHDCCIJPPE> PDHBJOPPDED
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public JNCCJLHKFDA<MMHDKHFCIBF> NALOJAANKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public JNCCJLHKFDA<DHMNCODBNBK> OJLBHIPICPG
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JNCCJLHKFDA<ODFBDNOADGM> LHACGMAPIEO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public JNCCJLHKFDA<CMKLJFNAGCE> LGJALIOBDFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public JNCCJLHKFDA<NBBDHCNOOIC> DKPHLCHFEMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7A0", Offset = "0x9E9DA0", VA = "0x1809EB7A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public JNCCJLHKFDA<MCAONEJPGJL> DCCBJCBGANI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x86081C0", Offset = "0x86067C0", VA = "0x1886081C0")]
	[AOJMKBDAFKB.IKKICAJLINL.MBDDKLBABPO]
	[UsedImplicitly]
	internal static void CPNCJILCPPN(AINJBKKEAIL PJLGMBBLBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8608230", Offset = "0x8606830", VA = "0x188608230")]
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
