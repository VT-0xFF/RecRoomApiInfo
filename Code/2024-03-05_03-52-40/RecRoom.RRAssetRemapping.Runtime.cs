using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HNDBFIGNABK : MEPLMICHKOM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex MCMGEIAFHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly GONAOIFIFNM ANFLODDNJCM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x686D9B0", Offset = "0x686C7B0", VA = "0x18686D9B0")]
	[HBAMLEIOGOF(BHCECOANHAK.GameOnly)]
	[UsedImplicitly]
	private static void JFKEJFLLBEE(CMADEFPIMOE HJBDMCEIPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x686D950", Offset = "0x686C750", VA = "0x18686D950")]
	[UsedImplicitly]
	[HBAMLEIOGOF(BHCECOANHAK.EditorOnly)]
	private static void EDNLJFIKDCL(CMADEFPIMOE HJBDMCEIPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	[Preserve]
	public HNDBFIGNABK([BMAJFBAIDDE(null)] GONAOIFIFNM ANFLODDNJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x686D490", Offset = "0x686C290", VA = "0x18686D490", Slot = "4")]
	public string CDDFPMJNNJO(PFPAGMCKFGF PMNEDIFJMIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x686CDD0", Offset = "0x686BBD0", VA = "0x18686CDD0", Slot = "5")]
	public PFPAGMCKFGF APHAODHFANA(string PMNEDIFJMIN)
	{
		return default(PFPAGMCKFGF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NPEEPGMBHPM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68731D0", Offset = "0x6871FD0", VA = "0x1868731D0")]
	public static GONAOIFIFNM NCCLPENHBOO()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, BJPIAGJCMGK
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

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
		public SerializedAvatarItemId(ADGNDEDLINL FJIJLBIGEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public ADGNDEDLINL APHAODHFANA()
		{
			return default(ADGNDEDLINL);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
		public Guid EPGMPHNBOBG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6873B70", Offset = "0x6872970", VA = "0x186873B70", Slot = "4")]
		public bool Equals(SerializedAvatarItemId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8FBDC0", Offset = "0x8FABC0", VA = "0x1808FBDC0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6873AD0", Offset = "0x68728D0", VA = "0x186873AD0", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8FBFE0", Offset = "0x8FADE0", VA = "0x1808FBFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6873B90", Offset = "0x6872990", VA = "0x186873B90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, BJPIAGJCMGK
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
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public MEPNECKLGOF APHAODHFANA()
		{
			return default(MEPNECKLGOF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
		public Guid EPGMPHNBOBG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6873B70", Offset = "0x6872970", VA = "0x186873B70", Slot = "4")]
		public bool Equals(SerializedBodyShapeId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8FBDC0", Offset = "0x8FABC0", VA = "0x1808FBDC0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6873C00", Offset = "0x6872A00", VA = "0x186873C00", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8FBFE0", Offset = "0x8FADE0", VA = "0x1808FBFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6873CA0", Offset = "0x6872AA0", VA = "0x186873CA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, BJPIAGJCMGK
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
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
		public Guid EPGMPHNBOBG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public FHBFAIODCNH APHAODHFANA()
		{
			return default(FHBFAIODCNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6873B70", Offset = "0x6872970", VA = "0x186873B70", Slot = "4")]
		public bool Equals(SerializedColorId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8FBDC0", Offset = "0x8FABC0", VA = "0x1808FBDC0", Slot = "5")]
		public int CompareTo(SerializedColorId EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6873D10", Offset = "0x6872B10", VA = "0x186873D10", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8FBFE0", Offset = "0x8FADE0", VA = "0x1808FBFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6873DB0", Offset = "0x6872BB0", VA = "0x186873DB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, BJPIAGJCMGK, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[SerializeField]
		private SerializedMaterialId materialId1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[SerializeField]
		private SerializedMaterialId materialId2;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6873E20", Offset = "0x6872C20", VA = "0x186873E20")]
		public GMFGMGAOABD APHAODHFANA()
		{
			return default(GMFGMGAOABD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
		public Guid EPGMPHNBOBG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x68740B0", Offset = "0x6872EB0", VA = "0x1868740B0")]
		public SerializedCombinationId(GMFGMGAOABD ECMJEGFKPHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x6873F30", Offset = "0x6872D30", VA = "0x186873F30")]
		private void OHKOPPCHOGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6701800", Offset = "0x6700600", VA = "0x186701800", Slot = "4")]
		public bool Equals(SerializedCombinationId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6873E80", Offset = "0x6872C80", VA = "0x186873E80", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8FBFE0", Offset = "0x8FADE0", VA = "0x1808FBFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8FBDC0", Offset = "0x8FABC0", VA = "0x1808FBDC0", Slot = "5")]
		public int CompareTo(SerializedCombinationId EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6874040", Offset = "0x6872E40", VA = "0x186874040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6874030", Offset = "0x6872E30", VA = "0x186874030", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, BJPIAGJCMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x68740E0", Offset = "0x6872EE0", VA = "0x1868740E0")]
		public static SerializedEquipmentSkinId ACKPMEPMCEO()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
		public Guid EPGMPHNBOBG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public GEDDPJGCMIG APHAODHFANA()
		{
			return default(GEDDPJGCMIG);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6873B70", Offset = "0x6872970", VA = "0x186873B70", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6874110", Offset = "0x6872F10", VA = "0x186874110", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8FBDC0", Offset = "0x8FABC0", VA = "0x1808FBDC0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8FBFE0", Offset = "0x8FADE0", VA = "0x1808FBFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x68741B0", Offset = "0x6872FB0", VA = "0x1868741B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, BJPIAGJCMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
		public Guid EPGMPHNBOBG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public IHGNPHBMLMN APHAODHFANA()
		{
			return default(IHGNPHBMLMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6873B70", Offset = "0x6872970", VA = "0x186873B70", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8FBDC0", Offset = "0x8FABC0", VA = "0x1808FBDC0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6874220", Offset = "0x6873020", VA = "0x186874220", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8FBFE0", Offset = "0x8FADE0", VA = "0x1808FBFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x68742C0", Offset = "0x68730C0", VA = "0x1868742C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, BJPIAGJCMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
		public Guid EPGMPHNBOBG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public FLODCCCKFPK APHAODHFANA()
		{
			return default(FLODCCCKFPK);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6873B70", Offset = "0x6872970", VA = "0x186873B70", Slot = "4")]
		public bool Equals(SerializedFaceShapeId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8FBDC0", Offset = "0x8FABC0", VA = "0x1808FBDC0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6874330", Offset = "0x6873130", VA = "0x186874330", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8FBFE0", Offset = "0x8FADE0", VA = "0x1808FBFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68743D0", Offset = "0x68731D0", VA = "0x1868743D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, BJPIAGJCMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
		public SerializedHairPatternId(GKCFIGPLEPM FJIJLBIGEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
		public Guid EPGMPHNBOBG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public GKCFIGPLEPM APHAODHFANA()
		{
			return default(GKCFIGPLEPM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6873B70", Offset = "0x6872970", VA = "0x186873B70", Slot = "4")]
		public bool Equals(SerializedHairPatternId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8FBDC0", Offset = "0x8FABC0", VA = "0x1808FBDC0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6874440", Offset = "0x6873240", VA = "0x186874440", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8FBFE0", Offset = "0x8FADE0", VA = "0x1808FBFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6873B70", Offset = "0x6872970", VA = "0x186873B70")]
		public static bool EILLJGMDDAM(SerializedHairPatternId LDPIALBNJEB, SerializedHairPatternId HLCIAKLFNHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x68744E0", Offset = "0x68732E0", VA = "0x1868744E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, BJPIAGJCMGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private ulong guidLow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		private ulong guidHigh;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1DAD510", Offset = "0x1DAC310", VA = "0x181DAD510")]
		public SerializedMaterialId(KGAHOAGJHCA FJIJLBIGEAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0", Slot = "6")]
		public Guid EPGMPHNBOBG()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86A5B0", Offset = "0x8693B0", VA = "0x18086A5B0")]
		public KGAHOAGJHCA APHAODHFANA()
		{
			return default(KGAHOAGJHCA);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6701800", Offset = "0x6700600", VA = "0x186701800", Slot = "4")]
		public bool Equals(SerializedMaterialId EDOEJIMPOFP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6874550", Offset = "0x6873350", VA = "0x186874550", Slot = "0")]
		public override bool Equals(object KDHDNCADFDJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8FBFE0", Offset = "0x8FADE0", VA = "0x1808FBFE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6701800", Offset = "0x6700600", VA = "0x186701800")]
		public static bool EILLJGMDDAM(SerializedMaterialId LDPIALBNJEB, SerializedMaterialId HLCIAKLFNHE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x8FBDC0", Offset = "0x8FABC0", VA = "0x1808FBDC0", Slot = "5")]
		public int CompareTo(SerializedMaterialId EDOEJIMPOFP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x68745F0", Offset = "0x68733F0", VA = "0x1868745F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PMCDMDFEHEJ : GONAOIFIFNM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static PMCDMDFEHEJ ACHMAPLCKNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6873830", Offset = "0x6872630", VA = "0x186873830")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public NHJEHOCHOJO<ADGNDEDLINL> BIMPJOKNCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6873770", Offset = "0x6872570", VA = "0x186873770", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public NHJEHOCHOJO<GEDDPJGCMIG> AHAGKJGEONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x68737D0", Offset = "0x68725D0", VA = "0x1868737D0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NHJEHOCHOJO<GKCFIGPLEPM> OBFLBMOHPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x68739B0", Offset = "0x68727B0", VA = "0x1868739B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public NHJEHOCHOJO<GMFGMGAOABD> LKMHAKHNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6873A10", Offset = "0x6872810", VA = "0x186873A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public NHJEHOCHOJO<FHBFAIODCNH> EDDIEPEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6873890", Offset = "0x6872690", VA = "0x186873890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public NHJEHOCHOJO<FLODCCCKFPK> INCHLMLNCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6873A70", Offset = "0x6872870", VA = "0x186873A70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public NHJEHOCHOJO<MEPNECKLGOF> HBACLGIMKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6873950", Offset = "0x6872750", VA = "0x186873950", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public NHJEHOCHOJO<IHGNPHBMLMN> JLAOIBADHAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x68738F0", Offset = "0x68726F0", VA = "0x1868738F0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class COLJHALJPLM
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x68692D0", Offset = "0x68680D0", VA = "0x1868692D0")]
	public static Guid DPFODBKGEOM(string OPGPAEHKFPC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6869380", Offset = "0x6868180", VA = "0x186869380")]
	public static bool EAIKEPMLHLP(string OPGPAEHKFPC, [Out] Guid MAAFBDMNKAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KOPOIAMKDAG : FFCBMGGMHMD<ADGNDEDLINL>, AIBPFEJCPAK<ADGNDEDLINL>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x686E560", Offset = "0x686D360", VA = "0x18686E560", Slot = "4")]
	public IEnumerable<(ADGNDEDLINL, string)> MJINHOJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68731B0", Offset = "0x6871FB0", VA = "0x1868731B0", Slot = "5")]
	public string NBMAONAOBKK(string KLJPBLHIECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6860F20", Offset = "0x685FD20", VA = "0x186860F20", Slot = "6")]
	public ADGNDEDLINL GAMEKFHBONO(string KLJPBLHIECD)
	{
		return default(ADGNDEDLINL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public KOPOIAMKDAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ABHLFFACAJH : FFCBMGGMHMD<MEPNECKLGOF>, AIBPFEJCPAK<MEPNECKLGOF>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6860FE0", Offset = "0x685FDE0", VA = "0x186860FE0", Slot = "4")]
	public IEnumerable<(MEPNECKLGOF, string)> MJINHOJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8FDD50", Offset = "0x8FCB50", VA = "0x1808FDD50", Slot = "5")]
	public string NBMAONAOBKK(string KLJPBLHIECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6860F20", Offset = "0x685FD20", VA = "0x186860F20", Slot = "6")]
	public MEPNECKLGOF GAMEKFHBONO(string KLJPBLHIECD)
	{
		return default(MEPNECKLGOF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public ABHLFFACAJH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EGHJMOJGOFJ : FFCBMGGMHMD<FHBFAIODCNH>, AIBPFEJCPAK<FHBFAIODCNH>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x686AD10", Offset = "0x6869B10", VA = "0x18686AD10", Slot = "4")]
	public IEnumerable<(FHBFAIODCNH, string)> MJINHOJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x8FDD50", Offset = "0x8FCB50", VA = "0x1808FDD50", Slot = "5")]
	public string NBMAONAOBKK(string KLJPBLHIECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6860F20", Offset = "0x685FD20", VA = "0x186860F20", Slot = "6")]
	public FHBFAIODCNH GAMEKFHBONO(string KLJPBLHIECD)
	{
		return default(FHBFAIODCNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EGHJMOJGOFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CHELKACOPKM : FFCBMGGMHMD<GMFGMGAOABD>, AIBPFEJCPAK<GMFGMGAOABD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly AIBPFEJCPAK<KGAHOAGJHCA> PMFDFPILJND;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7C8480", Offset = "0x7C7280", VA = "0x1807C8480")]
	public CHELKACOPKM(AIBPFEJCPAK<KGAHOAGJHCA> PMFDFPILJND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67029F0", Offset = "0x67017F0", VA = "0x1867029F0", Slot = "4")]
	public IEnumerable<(GMFGMGAOABD, string)> MJINHOJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6868F90", Offset = "0x6867D90", VA = "0x186868F90", Slot = "6")]
	public GMFGMGAOABD GAMEKFHBONO(string KLJPBLHIECD)
	{
		return default(GMFGMGAOABD);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6869290", Offset = "0x6868090", VA = "0x186869290", Slot = "5")]
	public string NBMAONAOBKK(string KLJPBLHIECD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BPIGDCIFPOA : FFCBMGGMHMD<GEDDPJGCMIG>, AIBPFEJCPAK<GEDDPJGCMIG>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6861380", Offset = "0x6860180", VA = "0x186861380", Slot = "4")]
	public IEnumerable<(GEDDPJGCMIG, string)> MJINHOJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8FDD50", Offset = "0x8FCB50", VA = "0x1808FDD50", Slot = "5")]
	public string NBMAONAOBKK(string KLJPBLHIECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6860F20", Offset = "0x685FD20", VA = "0x186860F20", Slot = "6")]
	public GEDDPJGCMIG GAMEKFHBONO(string KLJPBLHIECD)
	{
		return default(GEDDPJGCMIG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public BPIGDCIFPOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EENHEPHGFLM : FFCBMGGMHMD<IHGNPHBMLMN>, AIBPFEJCPAK<IHGNPHBMLMN>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6869450", Offset = "0x6868250", VA = "0x186869450", Slot = "4")]
	public IEnumerable<(IHGNPHBMLMN, string)> MJINHOJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8FDD50", Offset = "0x8FCB50", VA = "0x1808FDD50", Slot = "5")]
	public string NBMAONAOBKK(string KLJPBLHIECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6860F20", Offset = "0x685FD20", VA = "0x186860F20", Slot = "6")]
	public IHGNPHBMLMN GAMEKFHBONO(string KLJPBLHIECD)
	{
		return default(IHGNPHBMLMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public EENHEPHGFLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JJPABAJMHAN : FFCBMGGMHMD<FLODCCCKFPK>, AIBPFEJCPAK<FLODCCCKFPK>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x686E140", Offset = "0x686CF40", VA = "0x18686E140", Slot = "4")]
	public IEnumerable<(FLODCCCKFPK, string)> MJINHOJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8FDD50", Offset = "0x8FCB50", VA = "0x1808FDD50", Slot = "5")]
	public string NBMAONAOBKK(string KLJPBLHIECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6860F20", Offset = "0x685FD20", VA = "0x186860F20", Slot = "6")]
	public FLODCCCKFPK GAMEKFHBONO(string KLJPBLHIECD)
	{
		return default(FLODCCCKFPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public JJPABAJMHAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class HPOIKIDGAFN : FFCBMGGMHMD<GKCFIGPLEPM>, AIBPFEJCPAK<GKCFIGPLEPM>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x686DAC0", Offset = "0x686C8C0", VA = "0x18686DAC0", Slot = "4")]
	public IEnumerable<(GKCFIGPLEPM, string)> MJINHOJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x8FDD50", Offset = "0x8FCB50", VA = "0x1808FDD50", Slot = "5")]
	public string NBMAONAOBKK(string KLJPBLHIECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6860F20", Offset = "0x685FD20", VA = "0x186860F20", Slot = "6")]
	public GKCFIGPLEPM GAMEKFHBONO(string KLJPBLHIECD)
	{
		return default(GKCFIGPLEPM);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public HPOIKIDGAFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FFCBMGGMHMD<TModern> : AIBPFEJCPAK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> MJINHOJIBLC();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string NBMAONAOBKK(string KLJPBLHIECD);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OPODHPBMMKP : FFCBMGGMHMD<KGAHOAGJHCA>, AIBPFEJCPAK<KGAHOAGJHCA>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x67B6B60", Offset = "0x67B5960", VA = "0x1867B6B60", Slot = "4")]
	public IEnumerable<(KGAHOAGJHCA, string)> MJINHOJIBLC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x8FDD50", Offset = "0x8FCB50", VA = "0x1808FDD50", Slot = "5")]
	public string NBMAONAOBKK(string KLJPBLHIECD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6860F20", Offset = "0x685FD20", VA = "0x186860F20", Slot = "6")]
	public KGAHOAGJHCA GAMEKFHBONO(string KLJPBLHIECD)
	{
		return default(KGAHOAGJHCA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
	public OPODHPBMMKP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class BFDDOHHOJGJ<TModern> : NHJEHOCHOJO<TModern>, AIBPFEJCPAK<TModern> where TModern : IEquatable<TModern>, BJPIAGJCMGK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> EDEDGBMFIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> OJIJFJOBJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly FFCBMGGMHMD<TModern> EHHANKCBPNK;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4770F80", Offset = "0x476FD80", VA = "0x184770F80")]
	public BFDDOHHOJGJ(FFCBMGGMHMD<TModern> EHHANKCBPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x476D8F0", Offset = "0x476C6F0", VA = "0x18476D8F0", Slot = "5")]
	public TModern GAMEKFHBONO(string KLJPBLHIECD)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x476D7B0", Offset = "0x476C5B0", VA = "0x18476D7B0", Slot = "4")]
	public string BGEDLCDNPNN(TModern APEKBCGJMMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PDBCLBOELKM : GONAOIFIFNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private BFDDOHHOJGJ<ADGNDEDLINL> MMDCEPMFIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private BFDDOHHOJGJ<GEDDPJGCMIG> FFJNKFPEOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private BFDDOHHOJGJ<GKCFIGPLEPM> LEPAJINIMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private BFDDOHHOJGJ<KGAHOAGJHCA> PMFDFPILJND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private BFDDOHHOJGJ<GMFGMGAOABD> DGDPCCLFAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private BFDDOHHOJGJ<FHBFAIODCNH> KHNHJKBINPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private BFDDOHHOJGJ<FLODCCCKFPK> EOLIJPFNHEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private BFDDOHHOJGJ<MEPNECKLGOF> EIIJPJFPBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private BFDDOHHOJGJ<IHGNPHBMLMN> KLAODNEFKNK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NHJEHOCHOJO<ADGNDEDLINL> BIMPJOKNCOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B8400", Offset = "0x7B7200", VA = "0x1807B8400", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NHJEHOCHOJO<GEDDPJGCMIG> AHAGKJGEONK
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public NHJEHOCHOJO<GKCFIGPLEPM> OBFLBMOHPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B60", Offset = "0x7B7960", VA = "0x1807B8B60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public NHJEHOCHOJO<GMFGMGAOABD> LKMHAKHNMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public NHJEHOCHOJO<FHBFAIODCNH> EDDIEPEJAON
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B8F30", Offset = "0x7B7D30", VA = "0x1807B8F30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NHJEHOCHOJO<FLODCCCKFPK> INCHLMLNCNB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8B40", Offset = "0x7B7940", VA = "0x1807B8B40", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public NHJEHOCHOJO<MEPNECKLGOF> HBACLGIMKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB70", Offset = "0x7BD970", VA = "0x1807BEB70", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NHJEHOCHOJO<IHGNPHBMLMN> JLAOIBADHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7BB8D0", Offset = "0x7BA6D0", VA = "0x1807BB8D0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6873220", Offset = "0x6872020", VA = "0x186873220")]
	[HBAMLEIOGOF(EOCHJKOJDMN.Root, BHCECOANHAK.GameOnly)]
	[UsedImplicitly]
	private static void GJIOLPICKKJ(CMADEFPIMOE HJBDMCEIPLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6873290", Offset = "0x6872090", VA = "0x186873290")]
	[Preserve]
	public PDBCLBOELKM()
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
