using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.NoEngine.Common;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DKJJJNKAIPB : FLKKBKBNNPM
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NPOEEMCCCNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly GOBHNINCLDO FMIBDJKLCNG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x663A720", Offset = "0x6639120", VA = "0x18663A720")]
	[BBBFDPEBAMC(HLEKCCEDPHP.GameOnly)]
	private static void KKNBNMHPDDL(AFDLAPABCDH BEFGBMMMDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x663A200", Offset = "0x6638C00", VA = "0x18663A200")]
	[BBBFDPEBAMC(HLEKCCEDPHP.EditorOnly)]
	private static void FPCLMIMADKF(AFDLAPABCDH BEFGBMMMDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	[Preserve]
	public DKJJJNKAIPB([KNBPONIPMPA(null)] GOBHNINCLDO FMIBDJKLCNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x663A260", Offset = "0x6638C60", VA = "0x18663A260", Slot = "4")]
	public string JLKDILEIJOC(ACAMCBLFLNF KIEPLBLJKOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6639B40", Offset = "0x6638540", VA = "0x186639B40", Slot = "5")]
	public ACAMCBLFLNF DCJJDHFPDEL(string KIEPLBLJKOI)
	{
		return default(ACAMCBLFLNF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JMMLHBHJAFC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x663BBE0", Offset = "0x663A5E0", VA = "0x18663BBE0")]
	public static GOBHNINCLDO FFEDGDKOIBD()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, LBKHMHDHHFA
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
		[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
		public SerializedAvatarItemId(KFFIPGPICBA KABOEEEDCAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public KFFIPGPICBA DCJJDHFPDEL()
		{
			return default(KFFIPGPICBA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
		public Guid PLCAAILKEAB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x663C9C0", Offset = "0x663B3C0", VA = "0x18663C9C0", Slot = "4")]
		public bool Equals(SerializedAvatarItemId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x663C920", Offset = "0x663B320", VA = "0x18663C920", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x663C9E0", Offset = "0x663B3E0", VA = "0x18663C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x663C9F0", Offset = "0x663B3F0", VA = "0x18663C9F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, LBKHMHDHHFA
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
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public KFCBMNELBDJ DCJJDHFPDEL()
		{
			return default(KFCBMNELBDJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
		public Guid PLCAAILKEAB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x663C9C0", Offset = "0x663B3C0", VA = "0x18663C9C0", Slot = "4")]
		public bool Equals(SerializedBodyShapeId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x663CA60", Offset = "0x663B460", VA = "0x18663CA60", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x663C9E0", Offset = "0x663B3E0", VA = "0x18663C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x663CB00", Offset = "0x663B500", VA = "0x18663CB00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, LBKHMHDHHFA
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
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
		public Guid PLCAAILKEAB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public LDDIEGIGADA DCJJDHFPDEL()
		{
			return default(LDDIEGIGADA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x663C9C0", Offset = "0x663B3C0", VA = "0x18663C9C0", Slot = "4")]
		public bool Equals(SerializedColorId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializedColorId CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x663CB70", Offset = "0x663B570", VA = "0x18663CB70", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x663C9E0", Offset = "0x663B3E0", VA = "0x18663C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x663CC10", Offset = "0x663B610", VA = "0x18663CC10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, LBKHMHDHHFA, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x663CC80", Offset = "0x663B680", VA = "0x18663CC80")]
		public PMEHEMKJJKD DCJJDHFPDEL()
		{
			return default(PMEHEMKJJKD);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
		public Guid PLCAAILKEAB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x663CF10", Offset = "0x663B910", VA = "0x18663CF10")]
		public SerializedCombinationId(PMEHEMKJJKD FEIDOPAMLBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x663CDA0", Offset = "0x663B7A0", VA = "0x18663CDA0")]
		private void PIBJEMFCACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x609A860", Offset = "0x6099260", VA = "0x18609A860", Slot = "4")]
		public bool Equals(SerializedCombinationId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x663CCE0", Offset = "0x663B6E0", VA = "0x18663CCE0", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x663C9E0", Offset = "0x663B3E0", VA = "0x18663C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializedCombinationId CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x663CEA0", Offset = "0x663B8A0", VA = "0x18663CEA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x78F210", Offset = "0x78DC10", VA = "0x18078F210", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x663CD90", Offset = "0x663B790", VA = "0x18663CD90", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, LBKHMHDHHFA
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
		[Cpp2IlInjected.Address(RVA = "0x663CF40", Offset = "0x663B940", VA = "0x18663CF40")]
		public static SerializedEquipmentSkinId COHMHGLPFAF()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
		public Guid PLCAAILKEAB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public DHLFHOCNJLN DCJJDHFPDEL()
		{
			return default(DHLFHOCNJLN);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x663C9C0", Offset = "0x663B3C0", VA = "0x18663C9C0", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x663CF70", Offset = "0x663B970", VA = "0x18663CF70", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x663C9E0", Offset = "0x663B3E0", VA = "0x18663C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x663D010", Offset = "0x663BA10", VA = "0x18663D010", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, LBKHMHDHHFA
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
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
		public Guid PLCAAILKEAB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public PAHDNPHKCJJ DCJJDHFPDEL()
		{
			return default(PAHDNPHKCJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x663C9C0", Offset = "0x663B3C0", VA = "0x18663C9C0", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x663D080", Offset = "0x663BA80", VA = "0x18663D080", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x663C9E0", Offset = "0x663B3E0", VA = "0x18663C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x663D120", Offset = "0x663BB20", VA = "0x18663D120", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, LBKHMHDHHFA
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
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
		public Guid PLCAAILKEAB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public NCENGMDHCAF DCJJDHFPDEL()
		{
			return default(NCENGMDHCAF);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x663C9C0", Offset = "0x663B3C0", VA = "0x18663C9C0", Slot = "4")]
		public bool Equals(SerializedFaceShapeId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x663D190", Offset = "0x663BB90", VA = "0x18663D190", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x663C9E0", Offset = "0x663B3E0", VA = "0x18663C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x663D230", Offset = "0x663BC30", VA = "0x18663D230", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, LBKHMHDHHFA
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
		[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
		public SerializedHairPatternId(NOOHJJBPINN KABOEEEDCAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
		public Guid PLCAAILKEAB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public NOOHJJBPINN DCJJDHFPDEL()
		{
			return default(NOOHJJBPINN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x663C9C0", Offset = "0x663B3C0", VA = "0x18663C9C0", Slot = "4")]
		public bool Equals(SerializedHairPatternId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x663D2A0", Offset = "0x663BCA0", VA = "0x18663D2A0", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x663C9E0", Offset = "0x663B3E0", VA = "0x18663C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x663C9C0", Offset = "0x663B3C0", VA = "0x18663C9C0")]
		public static bool JGKBBKJJNFA(SerializedHairPatternId GHGBJDGFDKJ, SerializedHairPatternId PHPPILHFFME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x663D340", Offset = "0x663BD40", VA = "0x18663D340", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, LBKHMHDHHFA
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
		[Cpp2IlInjected.Address(RVA = "0x1D18170", Offset = "0x1D16B70", VA = "0x181D18170")]
		public SerializedMaterialId(ABKJACHDCEH KABOEEEDCAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0", Slot = "6")]
		public Guid PLCAAILKEAB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F92D0", Offset = "0x7F7CD0", VA = "0x1807F92D0")]
		public ABKJACHDCEH DCJJDHFPDEL()
		{
			return default(ABKJACHDCEH);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x609A860", Offset = "0x6099260", VA = "0x18609A860", Slot = "4")]
		public bool Equals(SerializedMaterialId CGDFJMJIABO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x663D3B0", Offset = "0x663BDB0", VA = "0x18663D3B0", Slot = "0")]
		public override bool Equals(object GKNPKJAGNGH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x663C9E0", Offset = "0x663B3E0", VA = "0x18663C9E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x609A860", Offset = "0x6099260", VA = "0x18609A860")]
		public static bool JGKBBKJJNFA(SerializedMaterialId GHGBJDGFDKJ, SerializedMaterialId PHPPILHFFME)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x609A7C0", Offset = "0x60991C0", VA = "0x18609A7C0", Slot = "5")]
		public int CompareTo(SerializedMaterialId CGDFJMJIABO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x663D450", Offset = "0x663BE50", VA = "0x18663D450", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class HEGMAFOJCKO : GOBHNINCLDO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static HEGMAFOJCKO KHPIFBDMEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x663B840", Offset = "0x663A240", VA = "0x18663B840")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public DHGPPPAEMPD<KFFIPGPICBA> FJCCLJPDLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x663B8A0", Offset = "0x663A2A0", VA = "0x18663B8A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public DHGPPPAEMPD<DHLFHOCNJLN> EHLBNFBEKFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x663BA20", Offset = "0x663A420", VA = "0x18663BA20", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DHGPPPAEMPD<NOOHJJBPINN> NOKMNKAPMEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x663BB40", Offset = "0x663A540", VA = "0x18663BB40", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public DHGPPPAEMPD<PMEHEMKJJKD> GHCCGFBAIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x663B9C0", Offset = "0x663A3C0", VA = "0x18663B9C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DHGPPPAEMPD<LDDIEGIGADA> JHOBFAPJJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x663B960", Offset = "0x663A360", VA = "0x18663B960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public DHGPPPAEMPD<NCENGMDHCAF> GCHLIPLAEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x663BAE0", Offset = "0x663A4E0", VA = "0x18663BAE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public DHGPPPAEMPD<KFCBMNELBDJ> NPCMGIGEOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x663B900", Offset = "0x663A300", VA = "0x18663B900", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public DHGPPPAEMPD<PAHDNPHKCJJ> JPGJCMFOEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x663BA80", Offset = "0x663A480", VA = "0x18663BA80", Slot = "11")]
		get
		{
			return null;
		}
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	internal class AssetIdMappingJsonData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public string comment;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public SortedDictionary<string, string> modernToLegacy;

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x66399D0", Offset = "0x66383D0", VA = "0x1866399D0")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class BCFGCKNLEOB
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6639AB0", Offset = "0x66384B0", VA = "0x186639AB0")]
	public static string IJHEDBEBIAH(this Guid DMMBGEACBPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6639A80", Offset = "0x6638480", VA = "0x186639A80")]
	public static Guid CODMCKAHHOE(string BCECPAFKIIF)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MHJGOBCGOOK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> LNHIPGGBNCO(IEnumerable<(string modernStr, string legacyStr)> HABLOMBNAGE);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class PLCMKNLHNCA
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class GOFDEFEEFHI : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private (string, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private AssetIdMappingJsonData jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public AssetIdMappingJsonData <>3__jsonData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private SortedDictionary<string, string>.Enumerator <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		private (string, string) System.Collections.Generic.IEnumerator<(System.String,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xA30D40", Offset = "0xA2F740", VA = "0x180A30D40", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((string, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x663B760", Offset = "0x663A160", VA = "0x18663B760", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1C13C70", Offset = "0x1C12670", VA = "0x181C13C70")]
		[DebuggerHidden]
		public GOFDEFEEFHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x663B7B0", Offset = "0x663A1B0", VA = "0x18663B7B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x663B3B0", Offset = "0x6639DB0", VA = "0x18663B3B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x663B610", Offset = "0x663A010", VA = "0x18663B610")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x663B710", Offset = "0x663A110", VA = "0x18663B710", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x663B660", Offset = "0x663A060", VA = "0x18663B660", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x663B660", Offset = "0x663A060", VA = "0x18663B660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x2779FE0", Offset = "0x27789E0", VA = "0x182779FE0")]
	internal static IEnumerable<(TModern, string)> DFBALIAHHGL<TModern>(string PFEHAKJCIOF, MHJGOBCGOOK<TModern> CPPGDFGKJAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x663C110", Offset = "0x663AB10", VA = "0x18663C110")]
	[IteratorStateMachine(typeof(GOFDEFEEFHI))]
	private static IEnumerable<(string, string)> HGBKLPJIAFA(AssetIdMappingJsonData HJFFINHBPLE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class EBAODKEAGOH
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x663A990", Offset = "0x6639390", VA = "0x18663A990")]
	public static Guid GCJNMEHGMHJ(string KHAOCOCEMNO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x663A8C0", Offset = "0x66392C0", VA = "0x18663A8C0")]
	public static bool CDDOKFGMIBJ(string KHAOCOCEMNO, [Out] Guid DMMBGEACBPP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class ECJADGNOLHC<TModern> : JGNDAEGANEL<TModern>, MHJGOBCGOOK<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class NLJEPNLDGDE : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private (TModern, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonValues;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ECJADGNOLHC<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xE36470", Offset = "0xE34E70", VA = "0x180E36470", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TModern, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x34ADAB0", Offset = "0x34AC4B0", VA = "0x1834ADAB0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xE28BF0", Offset = "0xE275F0", VA = "0x180E28BF0")]
		[DebuggerHidden]
		public NLJEPNLDGDE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3269050", Offset = "0x3267A50", VA = "0x183269050", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3E99400", Offset = "0x3E97E00", VA = "0x183E99400", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x3E99A30", Offset = "0x3E98430", VA = "0x183E99A30")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3E99C40", Offset = "0x3E98640", VA = "0x183E99C40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x3E99B70", Offset = "0x3E98570", VA = "0x183E99B70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x3634910", Offset = "0x3633310", VA = "0x183634910", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern AKOABCODAMI(Guid DMMBGEACBPP);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3233B80", Offset = "0x3232580", VA = "0x183233B80", Slot = "4")]
	public TModern NCIAIPDIHCG(string IGGHIBIPKNP)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x3233A20", Offset = "0x3232420", VA = "0x183233A20", Slot = "5")]
	[IteratorStateMachine(typeof(ECJADGNOLHC<>.NLJEPNLDGDE))]
	public IEnumerable<(TModern, string)> LNHIPGGBNCO(IEnumerable<(string modernStr, string legacyStr)> CCHLBHBICMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x795DF0", Offset = "0x7947F0", VA = "0x180795DF0")]
	protected ECJADGNOLHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ECOLFKGBDAF : ECJADGNOLHC<KFFIPGPICBA>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xE41660", Offset = "0xE40060", VA = "0x180E41660", Slot = "6")]
	protected override KFFIPGPICBA AKOABCODAMI(Guid DMMBGEACBPP)
	{
		return default(KFFIPGPICBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x663AA40", Offset = "0x6639440", VA = "0x18663AA40")]
	internal static string NJMPDKDEPHH(string IGGHIBIPKNP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x663AA60", Offset = "0x6639460", VA = "0x18663AA60")]
	public ECOLFKGBDAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ODLGHBJIHBK : ECJADGNOLHC<KFCBMNELBDJ>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xE41660", Offset = "0xE40060", VA = "0x180E41660", Slot = "6")]
	protected override KFCBMNELBDJ AKOABCODAMI(Guid DMMBGEACBPP)
	{
		return default(KFCBMNELBDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x663C090", Offset = "0x663AA90", VA = "0x18663C090")]
	public ODLGHBJIHBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NFIIJHMJJNC : ECJADGNOLHC<LDDIEGIGADA>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xE41660", Offset = "0xE40060", VA = "0x180E41660", Slot = "6")]
	protected override LDDIEGIGADA AKOABCODAMI(Guid DMMBGEACBPP)
	{
		return default(LDDIEGIGADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x663C010", Offset = "0x663AA10", VA = "0x18663C010")]
	public NFIIJHMJJNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class KAFGDKBEDJG : JGNDAEGANEL<PMEHEMKJJKD>, MHJGOBCGOOK<PMEHEMKJJKD>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class FGPMNPKEEGE : IEnumerable<(PMEHEMKJJKD, string)>, IEnumerable, IEnumerator<(PMEHEMKJJKD, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (PMEHEMKJJKD, string) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private IEnumerable<(string modernStr, string legacyStr)> jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public IEnumerable<(string modernStr, string legacyStr)> <>3__jsonStrings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public KAFGDKBEDJG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (PMEHEMKJJKD, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x32D36B0", Offset = "0x32D20B0", VA = "0x1832D36B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((PMEHEMKJJKD, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x663B2D0", Offset = "0x6639CD0", VA = "0x18663B2D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x663B380", Offset = "0x6639D80", VA = "0x18663B380")]
		[DebuggerHidden]
		public FGPMNPKEEGE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x663B340", Offset = "0x6639D40", VA = "0x18663B340", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x663AAA0", Offset = "0x66394A0", VA = "0x18663AAA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x663B100", Offset = "0x6639B00", VA = "0x18663B100")]
		private void OEKMCAOJCOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x663B280", Offset = "0x6639C80", VA = "0x18663B280", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x663B1C0", Offset = "0x6639BC0", VA = "0x18663B1C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(PMEHEMKJJKD, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x663B1C0", Offset = "0x6639BC0", VA = "0x18663B1C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly JGNDAEGANEL<ABKJACHDCEH> MBPHILFHAAH;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7904D0", Offset = "0x78EED0", VA = "0x1807904D0")]
	public KAFGDKBEDJG(JGNDAEGANEL<ABKJACHDCEH> MBPHILFHAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x663BCD0", Offset = "0x663A6D0", VA = "0x18663BCD0", Slot = "4")]
	public PMEHEMKJJKD NCIAIPDIHCG(string IGGHIBIPKNP)
	{
		return default(PMEHEMKJJKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x663BC30", Offset = "0x663A630", VA = "0x18663BC30", Slot = "5")]
	[IteratorStateMachine(typeof(FGPMNPKEEGE))]
	public IEnumerable<(PMEHEMKJJKD, string)> LNHIPGGBNCO(IEnumerable<(string modernStr, string legacyStr)> HABLOMBNAGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x663BFD0", Offset = "0x663A9D0", VA = "0x18663BFD0")]
	internal static string NJMPDKDEPHH(string IGGHIBIPKNP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class DHPCBIEJMJF : ECJADGNOLHC<DHLFHOCNJLN>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xE41660", Offset = "0xE40060", VA = "0x180E41660", Slot = "6")]
	protected override DHLFHOCNJLN AKOABCODAMI(Guid DMMBGEACBPP)
	{
		return default(DHLFHOCNJLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6639B00", Offset = "0x6638500", VA = "0x186639B00")]
	public DHPCBIEJMJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BPPBACGCMIL : ECJADGNOLHC<PAHDNPHKCJJ>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE41660", Offset = "0xE40060", VA = "0x180E41660", Slot = "6")]
	protected override PAHDNPHKCJJ AKOABCODAMI(Guid DMMBGEACBPP)
	{
		return default(PAHDNPHKCJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6639AC0", Offset = "0x66384C0", VA = "0x186639AC0")]
	public BPPBACGCMIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ODLPEKDAMCE : ECJADGNOLHC<NCENGMDHCAF>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xE41660", Offset = "0xE40060", VA = "0x180E41660", Slot = "6")]
	protected override NCENGMDHCAF AKOABCODAMI(Guid DMMBGEACBPP)
	{
		return default(NCENGMDHCAF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x663C0D0", Offset = "0x663AAD0", VA = "0x18663C0D0")]
	public ODLPEKDAMCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class NMKLHLOFOFK : ECJADGNOLHC<NOOHJJBPINN>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE41660", Offset = "0xE40060", VA = "0x180E41660", Slot = "6")]
	protected override NOOHJJBPINN AKOABCODAMI(Guid DMMBGEACBPP)
	{
		return default(NOOHJJBPINN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x663C050", Offset = "0x663AA50", VA = "0x18663C050")]
	public NMKLHLOFOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class JKLJAALIJAM : ECJADGNOLHC<ABKJACHDCEH>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xE41660", Offset = "0xE40060", VA = "0x180E41660", Slot = "6")]
	protected override ABKJACHDCEH AKOABCODAMI(Guid DMMBGEACBPP)
	{
		return default(ABKJACHDCEH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x663BBA0", Offset = "0x663A5A0", VA = "0x18663BBA0")]
	public JKLJAALIJAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class INBBDDOHCGI<TModern> : DHGPPPAEMPD<TModern>, JGNDAEGANEL<TModern> where TModern : IEquatable<TModern>, LBKHMHDHHFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> HOIAPBPBFAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> BOKCFHPHFBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> CEOAKNPFNHN;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x384FEA0", Offset = "0x384E8A0", VA = "0x18384FEA0")]
	public INBBDDOHCGI(TextAsset IMLBDCIDEOK, MHJGOBCGOOK<TModern> CPPGDFGKJAI, [CanBeNull] Func<string, string> CEOAKNPFNHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x384D2E0", Offset = "0x384BCE0", VA = "0x18384D2E0", Slot = "5")]
	public TModern NCIAIPDIHCG(string IGGHIBIPKNP)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x384C390", Offset = "0x384AD90", VA = "0x18384C390", Slot = "4")]
	public string IAHFHKHIJIH(TModern OMNEJKNOGCI)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, GOBHNINCLDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private TextAsset avatarItemIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private TextAsset combinationIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private TextAsset equipmentSkinIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private TextAsset hairPatternIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private TextAsset materialIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private TextAsset colorIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private TextAsset faceShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private TextAsset bodyShapeIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[SerializeField]
		private TextAsset faceFeatureIdsJson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private INBBDDOHCGI<KFFIPGPICBA> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private INBBDDOHCGI<DHLFHOCNJLN> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private INBBDDOHCGI<NOOHJJBPINN> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private INBBDDOHCGI<ABKJACHDCEH> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private INBBDDOHCGI<PMEHEMKJJKD> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private INBBDDOHCGI<LDDIEGIGADA> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private INBBDDOHCGI<NCENGMDHCAF> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private INBBDDOHCGI<KFCBMNELBDJ> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private INBBDDOHCGI<PAHDNPHKCJJ> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DHGPPPAEMPD<KFFIPGPICBA> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x78FC80", Offset = "0x78E680", VA = "0x18078FC80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public DHGPPPAEMPD<DHLFHOCNJLN> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x78FCB0", Offset = "0x78E6B0", VA = "0x18078FCB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public DHGPPPAEMPD<NOOHJJBPINN> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x791C70", Offset = "0x790670", VA = "0x180791C70", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public DHGPPPAEMPD<ABKJACHDCEH> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x7978C0", Offset = "0x7962C0", VA = "0x1807978C0", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public DHGPPPAEMPD<PMEHEMKJJKD> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x7978D0", Offset = "0x7962D0", VA = "0x1807978D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public DHGPPPAEMPD<LDDIEGIGADA> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x797700", Offset = "0x796100", VA = "0x180797700", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public DHGPPPAEMPD<NCENGMDHCAF> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8DFB20", Offset = "0x8DE520", VA = "0x1808DFB20", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public DHGPPPAEMPD<KFCBMNELBDJ> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x797760", Offset = "0x796160", VA = "0x180797760", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public DHGPPPAEMPD<PAHDNPHKCJJ> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x863F90", Offset = "0x862990", VA = "0x180863F90", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x663C190", Offset = "0x663AB90", VA = "0x18663C190")]
		[BBBFDPEBAMC(JFAJKKONDHJ.Root, HLEKCCEDPHP.GameOnly)]
		private static void JIGGKFLPKDA(AFDLAPABCDH BEFGBMMMDBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x663C210", Offset = "0x663AC10", VA = "0x18663C210")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81C660", Offset = "0x81B060", VA = "0x18081C660")]
		public RuntimeIdAssetMappers()
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
