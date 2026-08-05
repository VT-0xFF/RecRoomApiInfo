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
public class JDDKDBMNOCB : BPMIEHLMMAG
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex CAGCGLCHFFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly PDEPCHOOMEN LCAONHBKHIJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x663CE40", Offset = "0x663BC40", VA = "0x18663CE40")]
	[OKINHFAHPEJ(FNGNILODNLI.GameOnly)]
	private static void PFLOEECCCOH(LPFNGCMIAEC KNABOHCCJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x663C260", Offset = "0x663B060", VA = "0x18663C260")]
	[OKINHFAHPEJ(FNGNILODNLI.EditorOnly)]
	private static void AECPHEKJPLP(LPFNGCMIAEC KNABOHCCJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	[Preserve]
	public JDDKDBMNOCB([MCCEMKLKAEE(null)] PDEPCHOOMEN LCAONHBKHIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x663C980", Offset = "0x663B780", VA = "0x18663C980", Slot = "4")]
	public string OKNECDBNGHE(AILBBDICCKJ PIMDNKIGEGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x663C2C0", Offset = "0x663B0C0", VA = "0x18663C2C0", Slot = "5")]
	public AILBBDICCKJ HONCKFFEJNK(string PIMDNKIGEGF)
	{
		return default(AILBBDICCKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CKNAJAPPCHF
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x663B780", Offset = "0x663A580", VA = "0x18663B780")]
	public static PDEPCHOOMEN JBPNFCFKJPF()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, AICBJPBAAMI
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
		[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
		public SerializedAvatarItemId(CDLEDLCKHAK JDEPDKNELPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public CDLEDLCKHAK HONCKFFEJNK()
		{
			return default(CDLEDLCKHAK);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
		public Guid DACNCILMFOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x663E680", Offset = "0x663D480", VA = "0x18663E680", Slot = "4")]
		public bool Equals(SerializedAvatarItemId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x663E5E0", Offset = "0x663D3E0", VA = "0x18663E5E0", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x663E6A0", Offset = "0x663D4A0", VA = "0x18663E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x663E6B0", Offset = "0x663D4B0", VA = "0x18663E6B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, AICBJPBAAMI
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
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public JHPCEKNMCKO HONCKFFEJNK()
		{
			return default(JHPCEKNMCKO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
		public Guid DACNCILMFOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x663E680", Offset = "0x663D480", VA = "0x18663E680", Slot = "4")]
		public bool Equals(SerializedBodyShapeId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x663E720", Offset = "0x663D520", VA = "0x18663E720", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x663E6A0", Offset = "0x663D4A0", VA = "0x18663E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x663E7C0", Offset = "0x663D5C0", VA = "0x18663E7C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, AICBJPBAAMI
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
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
		public Guid DACNCILMFOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public NDMIKLIMBNE HONCKFFEJNK()
		{
			return default(NDMIKLIMBNE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x663E680", Offset = "0x663D480", VA = "0x18663E680", Slot = "4")]
		public bool Equals(SerializedColorId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializedColorId GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x663E830", Offset = "0x663D630", VA = "0x18663E830", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x663E6A0", Offset = "0x663D4A0", VA = "0x18663E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x663E8D0", Offset = "0x663D6D0", VA = "0x18663E8D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, AICBJPBAAMI, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x663E9F0", Offset = "0x663D7F0", VA = "0x18663E9F0")]
		public ELGDMANDNGP HONCKFFEJNK()
		{
			return default(ELGDMANDNGP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
		public Guid DACNCILMFOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x663EBD0", Offset = "0x663D9D0", VA = "0x18663EBD0")]
		public SerializedCombinationId(ELGDMANDNGP KPOOGALLLOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x663EA50", Offset = "0x663D850", VA = "0x18663EA50")]
		private void IDDGEPOPKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x609C010", Offset = "0x609AE10", VA = "0x18609C010", Slot = "4")]
		public bool Equals(SerializedCombinationId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x663E940", Offset = "0x663D740", VA = "0x18663E940", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x663E6A0", Offset = "0x663D4A0", VA = "0x18663E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializedCombinationId GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x663EB60", Offset = "0x663D960", VA = "0x18663EB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x790840", Offset = "0x78F640", VA = "0x180790840", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x663EB50", Offset = "0x663D950", VA = "0x18663EB50", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, AICBJPBAAMI
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
		[Cpp2IlInjected.Address(RVA = "0x663ECA0", Offset = "0x663DAA0", VA = "0x18663ECA0")]
		public static SerializedEquipmentSkinId KPFFJKCKOFJ()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
		public Guid DACNCILMFOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public CLFKLGFEMEP HONCKFFEJNK()
		{
			return default(CLFKLGFEMEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x663E680", Offset = "0x663D480", VA = "0x18663E680", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x663EC00", Offset = "0x663DA00", VA = "0x18663EC00", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x663E6A0", Offset = "0x663D4A0", VA = "0x18663E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x663ECD0", Offset = "0x663DAD0", VA = "0x18663ECD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, AICBJPBAAMI
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
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
		public Guid DACNCILMFOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public PGCIIFJHDEB HONCKFFEJNK()
		{
			return default(PGCIIFJHDEB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x663E680", Offset = "0x663D480", VA = "0x18663E680", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x663ED40", Offset = "0x663DB40", VA = "0x18663ED40", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x663E6A0", Offset = "0x663D4A0", VA = "0x18663E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x663EDE0", Offset = "0x663DBE0", VA = "0x18663EDE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, AICBJPBAAMI
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
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
		public Guid DACNCILMFOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public DKMAOPECEFA HONCKFFEJNK()
		{
			return default(DKMAOPECEFA);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x663E680", Offset = "0x663D480", VA = "0x18663E680", Slot = "4")]
		public bool Equals(SerializedFaceShapeId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x663EE50", Offset = "0x663DC50", VA = "0x18663EE50", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x663E6A0", Offset = "0x663D4A0", VA = "0x18663E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x663EEF0", Offset = "0x663DCF0", VA = "0x18663EEF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, AICBJPBAAMI
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
		[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
		public SerializedHairPatternId(KKEKFHMFPPO JDEPDKNELPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
		public Guid DACNCILMFOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public KKEKFHMFPPO HONCKFFEJNK()
		{
			return default(KKEKFHMFPPO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x663E680", Offset = "0x663D480", VA = "0x18663E680", Slot = "4")]
		public bool Equals(SerializedHairPatternId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x663EF60", Offset = "0x663DD60", VA = "0x18663EF60", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x663E6A0", Offset = "0x663D4A0", VA = "0x18663E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x663E680", Offset = "0x663D480", VA = "0x18663E680")]
		public static bool KFENMBPPCHH(SerializedHairPatternId PDAKJJLHJDL, SerializedHairPatternId KKCNPIHMPJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x663F000", Offset = "0x663DE00", VA = "0x18663F000", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, AICBJPBAAMI
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
		[Cpp2IlInjected.Address(RVA = "0x1D13320", Offset = "0x1D12120", VA = "0x181D13320")]
		public SerializedMaterialId(GHIHPNACBEL JDEPDKNELPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360", Slot = "6")]
		public Guid DACNCILMFOE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7F8360", Offset = "0x7F7160", VA = "0x1807F8360")]
		public GHIHPNACBEL HONCKFFEJNK()
		{
			return default(GHIHPNACBEL);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x609C010", Offset = "0x609AE10", VA = "0x18609C010", Slot = "4")]
		public bool Equals(SerializedMaterialId GDMGBCDFBAL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x663F070", Offset = "0x663DE70", VA = "0x18663F070", Slot = "0")]
		public override bool Equals(object FGANJEAKCMA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x663E6A0", Offset = "0x663D4A0", VA = "0x18663E6A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x609C010", Offset = "0x609AE10", VA = "0x18609C010")]
		public static bool KFENMBPPCHH(SerializedMaterialId PDAKJJLHJDL, SerializedMaterialId KKCNPIHMPJA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x609BFF0", Offset = "0x609ADF0", VA = "0x18609BFF0", Slot = "5")]
		public int CompareTo(SerializedMaterialId GDMGBCDFBAL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x663F110", Offset = "0x663DF10", VA = "0x18663F110", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class JMDLGOBIDIB : PDEPCHOOMEN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static JMDLGOBIDIB CEIKCOHBGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x663CFE0", Offset = "0x663BDE0", VA = "0x18663CFE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public HCMHGIJPDCF<CDLEDLCKHAK> PPHAKFBILIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x663D040", Offset = "0x663BE40", VA = "0x18663D040", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public HCMHGIJPDCF<CLFKLGFEMEP> HOOBKMPDLDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x663D1C0", Offset = "0x663BFC0", VA = "0x18663D1C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HCMHGIJPDCF<KKEKFHMFPPO> BIEDNOPOPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x663D2E0", Offset = "0x663C0E0", VA = "0x18663D2E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public HCMHGIJPDCF<ELGDMANDNGP> PCOFIBAPKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x663D160", Offset = "0x663BF60", VA = "0x18663D160", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public HCMHGIJPDCF<NDMIKLIMBNE> PFPAHLONELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x663D100", Offset = "0x663BF00", VA = "0x18663D100", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public HCMHGIJPDCF<DKMAOPECEFA> JLFHOOLOHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x663D280", Offset = "0x663C080", VA = "0x18663D280", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public HCMHGIJPDCF<JHPCEKNMCKO> HHCPKCOCBHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x663D0A0", Offset = "0x663BEA0", VA = "0x18663D0A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public HCMHGIJPDCF<PGCIIFJHDEB> NHGELFNHGBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x663D220", Offset = "0x663C020", VA = "0x18663D220", Slot = "11")]
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
		[Cpp2IlInjected.Address(RVA = "0x663B690", Offset = "0x663A490", VA = "0x18663B690")]
		public AssetIdMappingJsonData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
internal static class FPMOLFIHPMP
{
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x663C120", Offset = "0x663AF20", VA = "0x18663C120")]
	public static string ACDIOBKAKMK(this Guid FILMEIPENDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x663C130", Offset = "0x663AF30", VA = "0x18663C130")]
	public static Guid NKPADGJBODK(string MMAOJEELIHP)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface EEAEAFEDCMG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> JJOLGMIHJJJ(IEnumerable<(string modernStr, string legacyStr)> EKIPAOKPLEO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
internal static class IOLEPHEKPFH
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class POKIGPKAPOA : IEnumerable<(string, string)>, IEnumerable, IEnumerator<(string, string)>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xA302A0", Offset = "0xA2F0A0", VA = "0x180A302A0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x663DD70", Offset = "0x663CB70", VA = "0x18663DD70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1C13E20", Offset = "0x1C12C20", VA = "0x181C13E20")]
		[DebuggerHidden]
		public POKIGPKAPOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x663DDC0", Offset = "0x663CBC0", VA = "0x18663DDC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x663DA10", Offset = "0x663C810", VA = "0x18663DA10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x663D9C0", Offset = "0x663C7C0", VA = "0x18663D9C0")]
		private void BFEOCPBHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x663DD20", Offset = "0x663CB20", VA = "0x18663DD20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x663DC70", Offset = "0x663CA70", VA = "0x18663DC70", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(string, string)> System.Collections.Generic.IEnumerable<(System.String,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x663DC70", Offset = "0x663CA70", VA = "0x18663DC70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x25EEAF0", Offset = "0x25ED8F0", VA = "0x1825EEAF0")]
	internal static IEnumerable<(TModern, string)> ABPDDJNPFKA<TModern>(string GCJFMHLPIPB, EEAEAFEDCMG<TModern> HHKDCODJGJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x663C1E0", Offset = "0x663AFE0", VA = "0x18663C1E0")]
	[IteratorStateMachine(typeof(POKIGPKAPOA))]
	private static IEnumerable<(string, string)> EKDMMPDECHC(AssetIdMappingJsonData LFFHAADGNFN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class JMNOCBLNJMC
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x663D340", Offset = "0x663C140", VA = "0x18663D340")]
	public static Guid CAMFABFLCDI(string GCPACPJPAOO)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x663D3F0", Offset = "0x663C1F0", VA = "0x18663D3F0")]
	public static bool LFAHCHBHLKJ(string GCPACPJPAOO, [Out] Guid FILMEIPENDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class DELEDOIJAEE<TModern> : JJLDANJCAEO<TModern>, EEAEAFEDCMG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[CompilerGenerated]
	private sealed class HGKJDJDPHAL : IEnumerable<(TModern, string)>, IEnumerable, IEnumerator<(TModern, string)>, IEnumerator, IDisposable
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
		public DELEDOIJAEE<TModern> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		private (TModern, string) System.Collections.Generic.IEnumerator<(TModern,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xE35110", Offset = "0xE33F10", VA = "0x180E35110", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x34C2CF0", Offset = "0x34C1AF0", VA = "0x1834C2CF0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0xE2D1B0", Offset = "0xE2BFB0", VA = "0x180E2D1B0")]
		[DebuggerHidden]
		public HGKJDJDPHAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x3368F90", Offset = "0x3367D90", VA = "0x183368F90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x3750DE0", Offset = "0x374FBE0", VA = "0x183750DE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x374F5A0", Offset = "0x374E3A0", VA = "0x18374F5A0")]
		private void BFEOCPBHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x3751450", Offset = "0x3750250", VA = "0x183751450", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x37510D0", Offset = "0x374FED0", VA = "0x1837510D0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TModern, string)> System.Collections.Generic.IEnumerable<(TModern,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x366C9F0", Offset = "0x366B7F0", VA = "0x18366C9F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract TModern HIANLGHOCPI(Guid FILMEIPENDI);

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4F3C570", Offset = "0x4F3B370", VA = "0x184F3C570", Slot = "4")]
	public TModern ACJPGEJADOI(string FDJJJGJPNBK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4F3C6C0", Offset = "0x4F3B4C0", VA = "0x184F3C6C0", Slot = "5")]
	[IteratorStateMachine(typeof(DELEDOIJAEE<>.HGKJDJDPHAL))]
	public IEnumerable<(TModern, string)> JJOLGMIHJJJ(IEnumerable<(string modernStr, string legacyStr)> DOPPGOKKPPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
	protected DELEDOIJAEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class KOJJGOCEINA : DELEDOIJAEE<CDLEDLCKHAK>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3F7D0", VA = "0x180E409D0", Slot = "6")]
	protected override CDLEDLCKHAK HIANLGHOCPI(Guid FILMEIPENDI)
	{
		return default(CDLEDLCKHAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x663D540", Offset = "0x663C340", VA = "0x18663D540")]
	internal static string NGJBJEKGHNL(string FDJJJGJPNBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x663D560", Offset = "0x663C360", VA = "0x18663D560")]
	public KOJJGOCEINA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class HIGMCMFKIKD : DELEDOIJAEE<JHPCEKNMCKO>
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3F7D0", VA = "0x180E409D0", Slot = "6")]
	protected override JHPCEKNMCKO HIANLGHOCPI(Guid FILMEIPENDI)
	{
		return default(JHPCEKNMCKO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x663C1A0", Offset = "0x663AFA0", VA = "0x18663C1A0")]
	public HIGMCMFKIKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KMDCIJEAHIE : DELEDOIJAEE<NDMIKLIMBNE>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3F7D0", VA = "0x180E409D0", Slot = "6")]
	protected override NDMIKLIMBNE HIANLGHOCPI(Guid FILMEIPENDI)
	{
		return default(NDMIKLIMBNE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x663D500", Offset = "0x663C300", VA = "0x18663D500")]
	public KMDCIJEAHIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OLMPFNBBANM : JJLDANJCAEO<ELGDMANDNGP>, EEAEAFEDCMG<ELGDMANDNGP>
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class CNDIJHPJKDO : IEnumerable<(ELGDMANDNGP, string)>, IEnumerable, IEnumerator<(ELGDMANDNGP, string)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private (ELGDMANDNGP, string) <>2__current;

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
		public OLMPFNBBANM <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private IEnumerator<(string modernStr, string legacyStr)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private (ELGDMANDNGP, string) System.Collections.Generic.IEnumerator<(RecRoom.AssetIds.CombinationId,System.String)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x33087C0", Offset = "0x33075C0", VA = "0x1833087C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((ELGDMANDNGP, string));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x663C000", Offset = "0x663AE00", VA = "0x18663C000", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x663C0B0", Offset = "0x663AEB0", VA = "0x18663C0B0")]
		[DebuggerHidden]
		public CNDIJHPJKDO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x663C070", Offset = "0x663AE70", VA = "0x18663C070", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x663B890", Offset = "0x663A690", VA = "0x18663B890", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x663B7D0", Offset = "0x663A5D0", VA = "0x18663B7D0")]
		private void BFEOCPBHPDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x663BFB0", Offset = "0x663ADB0", VA = "0x18663BFB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x663BEF0", Offset = "0x663ACF0", VA = "0x18663BEF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(ELGDMANDNGP, string)> System.Collections.Generic.IEnumerable<(RecRoom.AssetIds.CombinationId,System.String)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x663BEF0", Offset = "0x663ACF0", VA = "0x18663BEF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly JJLDANJCAEO<GHIHPNACBEL> ECPCNODOJGB;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x791D40", Offset = "0x790B40", VA = "0x180791D40")]
	public OLMPFNBBANM(JJLDANJCAEO<GHIHPNACBEL> ECPCNODOJGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x663D5E0", Offset = "0x663C3E0", VA = "0x18663D5E0", Slot = "4")]
	public ELGDMANDNGP ACJPGEJADOI(string FDJJJGJPNBK)
	{
		return default(ELGDMANDNGP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x663D8E0", Offset = "0x663C6E0", VA = "0x18663D8E0", Slot = "5")]
	[IteratorStateMachine(typeof(CNDIJHPJKDO))]
	public IEnumerable<(ELGDMANDNGP, string)> JJOLGMIHJJJ(IEnumerable<(string modernStr, string legacyStr)> EKIPAOKPLEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x663D980", Offset = "0x663C780", VA = "0x18663D980")]
	internal static string NGJBJEKGHNL(string FDJJJGJPNBK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JOFCAMECGMG : DELEDOIJAEE<CLFKLGFEMEP>
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3F7D0", VA = "0x180E409D0", Slot = "6")]
	protected override CLFKLGFEMEP HIANLGHOCPI(Guid FILMEIPENDI)
	{
		return default(CLFKLGFEMEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x663D4C0", Offset = "0x663C2C0", VA = "0x18663D4C0")]
	public JOFCAMECGMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HAKCODOJNAM : DELEDOIJAEE<PGCIIFJHDEB>
{
	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3F7D0", VA = "0x180E409D0", Slot = "6")]
	protected override PGCIIFJHDEB HIANLGHOCPI(Guid FILMEIPENDI)
	{
		return default(PGCIIFJHDEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x663C160", Offset = "0x663AF60", VA = "0x18663C160")]
	public HAKCODOJNAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class BGPMGBFMEBM : DELEDOIJAEE<DKMAOPECEFA>
{
	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3F7D0", VA = "0x180E409D0", Slot = "6")]
	protected override DKMAOPECEFA HIANLGHOCPI(Guid FILMEIPENDI)
	{
		return default(DKMAOPECEFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x663B740", Offset = "0x663A540", VA = "0x18663B740")]
	public BGPMGBFMEBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FFAPKKCHBFG : DELEDOIJAEE<KKEKFHMFPPO>
{
	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3F7D0", VA = "0x180E409D0", Slot = "6")]
	protected override KKEKFHMFPPO HIANLGHOCPI(Guid FILMEIPENDI)
	{
		return default(KKEKFHMFPPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x663C0E0", Offset = "0x663AEE0", VA = "0x18663C0E0")]
	public FFAPKKCHBFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class MHEOCLDOHEN : DELEDOIJAEE<GHIHPNACBEL>
{
	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0xE409D0", Offset = "0xE3F7D0", VA = "0x180E409D0", Slot = "6")]
	protected override GHIHPNACBEL HIANLGHOCPI(Guid FILMEIPENDI)
	{
		return default(GHIHPNACBEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x663D5A0", Offset = "0x663C3A0", VA = "0x18663D5A0")]
	public MHEOCLDOHEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class ADPGGFHKMMI<TModern> : HCMHGIJPDCF<TModern>, JJLDANJCAEO<TModern> where TModern : IEquatable<TModern>, AICBJPBAAMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TModern, string> IDDNGDFDPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<string, TModern> EFOHDDPHACJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[CanBeNull]
	private readonly Func<string, string> ALKELBNEDFL;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x36890D0", Offset = "0x3687ED0", VA = "0x1836890D0")]
	public ADPGGFHKMMI(TextAsset JKKKLDDJMHJ, EEAEAFEDCMG<TModern> HHKDCODJGJC, [CanBeNull] Func<string, string> ALKELBNEDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x36864C0", Offset = "0x36852C0", VA = "0x1836864C0", Slot = "5")]
	public TModern ACJPGEJADOI(string FDJJJGJPNBK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x36880A0", Offset = "0x3686EA0", VA = "0x1836880A0", Slot = "4")]
	public string CBGOCCBFLJF(TModern MGKFCFCJODA)
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class RuntimeIdAssetMappers : ScriptableObject, PDEPCHOOMEN
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
		private ADPGGFHKMMI<CDLEDLCKHAK> avatarItemIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private ADPGGFHKMMI<CLFKLGFEMEP> equipmentSkinIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private ADPGGFHKMMI<KKEKFHMFPPO> hairPatternIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private ADPGGFHKMMI<GHIHPNACBEL> materialIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private ADPGGFHKMMI<ELGDMANDNGP> combinationIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		private ADPGGFHKMMI<NDMIKLIMBNE> colorIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private ADPGGFHKMMI<DKMAOPECEFA> faceShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private ADPGGFHKMMI<JHPCEKNMCKO> bodyShapeIdLegacyMapper;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private ADPGGFHKMMI<PGCIIFJHDEB> faceFeatureIdLegacyMapper;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public HCMHGIJPDCF<CDLEDLCKHAK> AvatarItemIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0x78D1E0", Offset = "0x78BFE0", VA = "0x18078D1E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public HCMHGIJPDCF<CLFKLGFEMEP> EquipmentSkinIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x78E210", Offset = "0x78D010", VA = "0x18078E210", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public HCMHGIJPDCF<KKEKFHMFPPO> HairPatternIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x78E0C0", Offset = "0x78CEC0", VA = "0x18078E0C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public HCMHGIJPDCF<GHIHPNACBEL> MaterialIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x798F00", Offset = "0x797D00", VA = "0x180798F00", Slot = "12")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public HCMHGIJPDCF<ELGDMANDNGP> CombinationIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x798FF0", Offset = "0x797DF0", VA = "0x180798FF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public HCMHGIJPDCF<NDMIKLIMBNE> ColorIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x798E90", Offset = "0x797C90", VA = "0x180798E90", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public HCMHGIJPDCF<DKMAOPECEFA> FaceShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0x8DE6C0", Offset = "0x8DD4C0", VA = "0x1808DE6C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public HCMHGIJPDCF<JHPCEKNMCKO> BodyShapeIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x798FA0", Offset = "0x797DA0", VA = "0x180798FA0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public HCMHGIJPDCF<PGCIIFJHDEB> FaceFeatureIdLegacyMapper
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x858ED0", Offset = "0x857CD0", VA = "0x180858ED0", Slot = "11")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x663DE50", Offset = "0x663CC50", VA = "0x18663DE50")]
		[OKINHFAHPEJ(OBFBFIBMGDJ.Root, FNGNILODNLI.GameOnly)]
		private static void ANEDGJPLFNN(LPFNGCMIAEC KNABOHCCJFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x663DED0", Offset = "0x663CCD0", VA = "0x18663DED0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x81B4D0", Offset = "0x81A2D0", VA = "0x18081B4D0")]
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
