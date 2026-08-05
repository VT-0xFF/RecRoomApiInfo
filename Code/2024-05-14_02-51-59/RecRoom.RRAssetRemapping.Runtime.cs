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
public class AKBHNAKDACA : BKPNIJLCEAN
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex NDDNKIDKKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MELEAMAAHID ODOCDPLLFBN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F150", Offset = "0x6B2DB50", VA = "0x186B2F150")]
	[JCOMPLNHMEG(AOHDMBIABEL.GameOnly)]
	[UsedImplicitly]
	private static void GHEMDLAGGBM(ICKBMMGCCPN AIGNNHACHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F880", Offset = "0x6B2E280", VA = "0x186B2F880")]
	[UsedImplicitly]
	[JCOMPLNHMEG(AOHDMBIABEL.EditorOnly)]
	private static void PIAPHKDNBIH(ICKBMMGCCPN AIGNNHACHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	[Preserve]
	public AKBHNAKDACA([JDJLHBHAJCP(null)] MELEAMAAHID ODOCDPLLFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B2EC90", Offset = "0x6B2D690", VA = "0x186B2EC90", Slot = "4")]
	public string BOALAEMEPIG(IMADIEACKLJ KAPFFOPPBJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F1C0", Offset = "0x6B2DBC0", VA = "0x186B2F1C0", Slot = "5")]
	public IMADIEACKLJ HIBHLHEFCGJ(string KAPFFOPPBJF)
	{
		return default(IMADIEACKLJ);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, KMKAGJMEMOH
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

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E79380", Offset = "0x1E77D80", VA = "0x181E79380")]
		public SerializedAvatarItemId(NNIELEFOFHC MCGNHGLIJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public NNIELEFOFHC HIBHLHEFCGJ()
		{
			return default(NNIELEFOFHC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
		public Guid BCMAPEBNHJB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B41280", Offset = "0x6B3FC80", VA = "0x186B41280", Slot = "4")]
		public bool Equals(SerializedAvatarItemId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x931FF0", Offset = "0x9309F0", VA = "0x180931FF0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B411E0", Offset = "0x6B3FBE0", VA = "0x186B411E0", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x932210", Offset = "0x930C10", VA = "0x180932210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B412A0", Offset = "0x6B3FCA0", VA = "0x186B412A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, KMKAGJMEMOH
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

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public BENBKFHMAMC HIBHLHEFCGJ()
		{
			return default(BENBKFHMAMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
		public Guid BCMAPEBNHJB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B41280", Offset = "0x6B3FC80", VA = "0x186B41280", Slot = "4")]
		public bool Equals(SerializedBodyShapeId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x931FF0", Offset = "0x9309F0", VA = "0x180931FF0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6B41310", Offset = "0x6B3FD10", VA = "0x186B41310", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x932210", Offset = "0x930C10", VA = "0x180932210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6B413B0", Offset = "0x6B3FDB0", VA = "0x186B413B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, KMKAGJMEMOH
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

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
		public Guid BCMAPEBNHJB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public DLPMGCADPIG HIBHLHEFCGJ()
		{
			return default(DLPMGCADPIG);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B41280", Offset = "0x6B3FC80", VA = "0x186B41280", Slot = "4")]
		public bool Equals(SerializedColorId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x931FF0", Offset = "0x9309F0", VA = "0x180931FF0", Slot = "5")]
		public int CompareTo(SerializedColorId HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6B41420", Offset = "0x6B3FE20", VA = "0x186B41420", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x932210", Offset = "0x930C10", VA = "0x180932210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6B414C0", Offset = "0x6B3FEC0", VA = "0x186B414C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, KMKAGJMEMOH, ISerializationCallbackReceiver
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

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6B415E0", Offset = "0x6B3FFE0", VA = "0x186B415E0")]
		public KHIGNFPBAIG HIBHLHEFCGJ()
		{
			return default(KHIGNFPBAIG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
		public Guid BCMAPEBNHJB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6B417C0", Offset = "0x6B401C0", VA = "0x186B417C0")]
		public SerializedCombinationId(KHIGNFPBAIG JEKGFECKEBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6B41640", Offset = "0x6B40040", VA = "0x186B41640")]
		private void IJDMMDKBDDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69CF3C0", Offset = "0x69CDDC0", VA = "0x1869CF3C0", Slot = "4")]
		public bool Equals(SerializedCombinationId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6B41530", Offset = "0x6B3FF30", VA = "0x186B41530", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x932210", Offset = "0x930C10", VA = "0x180932210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x931FF0", Offset = "0x9309F0", VA = "0x180931FF0", Slot = "5")]
		public int CompareTo(SerializedCombinationId HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6B41750", Offset = "0x6B40150", VA = "0x186B41750", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C34B0", Offset = "0x7C1EB0", VA = "0x1807C34B0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6B41740", Offset = "0x6B40140", VA = "0x186B41740", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, KMKAGJMEMOH
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

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6B41890", Offset = "0x6B40290", VA = "0x186B41890")]
		public static SerializedEquipmentSkinId OBIPFNEEGLA()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
		public Guid BCMAPEBNHJB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public IONCKFMPFKP HIBHLHEFCGJ()
		{
			return default(IONCKFMPFKP);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6B41280", Offset = "0x6B3FC80", VA = "0x186B41280", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6B417F0", Offset = "0x6B401F0", VA = "0x186B417F0", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x931FF0", Offset = "0x9309F0", VA = "0x180931FF0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x932210", Offset = "0x930C10", VA = "0x180932210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6B418C0", Offset = "0x6B402C0", VA = "0x186B418C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, KMKAGJMEMOH
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

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
		public Guid BCMAPEBNHJB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public FMIFMPDKCJC HIBHLHEFCGJ()
		{
			return default(FMIFMPDKCJC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6B41280", Offset = "0x6B3FC80", VA = "0x186B41280", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x931FF0", Offset = "0x9309F0", VA = "0x180931FF0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6B41930", Offset = "0x6B40330", VA = "0x186B41930", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x932210", Offset = "0x930C10", VA = "0x180932210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6B419D0", Offset = "0x6B403D0", VA = "0x186B419D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, KMKAGJMEMOH
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

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
		public Guid BCMAPEBNHJB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public NPPGCJBCMBB HIBHLHEFCGJ()
		{
			return default(NPPGCJBCMBB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6B41280", Offset = "0x6B3FC80", VA = "0x186B41280", Slot = "4")]
		public bool Equals(SerializedFaceShapeId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x931FF0", Offset = "0x9309F0", VA = "0x180931FF0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6B41A40", Offset = "0x6B40440", VA = "0x186B41A40", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x932210", Offset = "0x930C10", VA = "0x180932210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6B41AE0", Offset = "0x6B404E0", VA = "0x186B41AE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, KMKAGJMEMOH
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

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
		public Guid BCMAPEBNHJB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public GNIEBFPNHCO HIBHLHEFCGJ()
		{
			return default(GNIEBFPNHCO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6B41280", Offset = "0x6B3FC80", VA = "0x186B41280", Slot = "4")]
		public bool Equals(SerializedHairPatternId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x931FF0", Offset = "0x9309F0", VA = "0x180931FF0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6B41B50", Offset = "0x6B40550", VA = "0x186B41B50", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x932210", Offset = "0x930C10", VA = "0x180932210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6B41280", Offset = "0x6B3FC80", VA = "0x186B41280")]
		public static bool PIEEFOPMNNK(SerializedHairPatternId OLKIFIEFDII, SerializedHairPatternId AEIEBLGGCGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6B41BF0", Offset = "0x6B405F0", VA = "0x186B41BF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, KMKAGJMEMOH
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

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1E79380", Offset = "0x1E77D80", VA = "0x181E79380")]
		public SerializedMaterialId(OHMKPBHEIEO MCGNHGLIJDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10", Slot = "6")]
		public Guid BCMAPEBNHJB()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88DB10", Offset = "0x88C510", VA = "0x18088DB10")]
		public OHMKPBHEIEO HIBHLHEFCGJ()
		{
			return default(OHMKPBHEIEO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x69CF3C0", Offset = "0x69CDDC0", VA = "0x1869CF3C0", Slot = "4")]
		public bool Equals(SerializedMaterialId HKMMPHJFKEA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6B41C60", Offset = "0x6B40660", VA = "0x186B41C60", Slot = "0")]
		public override bool Equals(object COMOOAEHALC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x932210", Offset = "0x930C10", VA = "0x180932210", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69CF3C0", Offset = "0x69CDDC0", VA = "0x1869CF3C0")]
		public static bool PIEEFOPMNNK(SerializedMaterialId OLKIFIEFDII, SerializedMaterialId AEIEBLGGCGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x931FF0", Offset = "0x9309F0", VA = "0x180931FF0", Slot = "5")]
		public int CompareTo(SerializedMaterialId HKMMPHJFKEA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6B41D00", Offset = "0x6B40700", VA = "0x186B41D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public class LNKOJPJDGFB : MELEAMAAHID
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static LNKOJPJDGFB AINFBDJPIJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E9E0", Offset = "0x6B3D3E0", VA = "0x186B3E9E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public FKMAIDJKEAO<NNIELEFOFHC> FBKIDFGNPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E860", Offset = "0x6B3D260", VA = "0x186B3E860", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public FKMAIDJKEAO<IONCKFMPFKP> JILIOOLDALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E980", Offset = "0x6B3D380", VA = "0x186B3E980", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public FKMAIDJKEAO<GNIEBFPNHCO> ICGGOCBOKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E920", Offset = "0x6B3D320", VA = "0x186B3E920", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public FKMAIDJKEAO<KHIGNFPBAIG> PJOCKLCMOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E8C0", Offset = "0x6B3D2C0", VA = "0x186B3E8C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public FKMAIDJKEAO<DLPMGCADPIG> CDCKIGIDBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E800", Offset = "0x6B3D200", VA = "0x186B3E800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public FKMAIDJKEAO<NPPGCJBCMBB> DAOJLIBNDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E6E0", Offset = "0x6B3D0E0", VA = "0x186B3E6E0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public FKMAIDJKEAO<BENBKFHMAMC> HJDKIGMEILA
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E7A0", Offset = "0x6B3D1A0", VA = "0x186B3E7A0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public FKMAIDJKEAO<FMIFMPDKCJC> EAGKGPBBLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6B3E740", Offset = "0x6B3D140", VA = "0x186B3E740", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class IFIAPPFHPOB
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E560", Offset = "0x6B3CF60", VA = "0x186B3E560")]
	public static Guid HHCHDHPMAEA(string PDPPPKLBGLF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E610", Offset = "0x6B3D010", VA = "0x186B3E610")]
	public static bool JAMMKJOPPBF(string PDPPPKLBGLF, [Out] Guid JHOGCCPFJGM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GFJKCJBFMII : OGJKGONAFHP<NNIELEFOFHC>, JDGEMIEKOBG<NNIELEFOFHC>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6B39910", Offset = "0x6B38310", VA = "0x186B39910", Slot = "4")]
	public IEnumerable<(NNIELEFOFHC, string)> KOBKFLAELPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6B398F0", Offset = "0x6B382F0", VA = "0x186B398F0", Slot = "5")]
	public string HDKLABCEKJL(string MDNEILIKEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E680", Offset = "0x6B2D080", VA = "0x186B2E680", Slot = "6")]
	public NNIELEFOFHC BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return default(NNIELEFOFHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public GFJKCJBFMII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PFHOBOADECC : OGJKGONAFHP<BENBKFHMAMC>, JDGEMIEKOBG<BENBKFHMAMC>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6B40E40", Offset = "0x6B3F840", VA = "0x186B40E40", Slot = "4")]
	public IEnumerable<(BENBKFHMAMC, string)> KOBKFLAELPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x933CC0", Offset = "0x9326C0", VA = "0x180933CC0", Slot = "5")]
	public string HDKLABCEKJL(string MDNEILIKEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E680", Offset = "0x6B2D080", VA = "0x186B2E680", Slot = "6")]
	public BENBKFHMAMC BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return default(BENBKFHMAMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public PFHOBOADECC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PBFDHONLJJN : OGJKGONAFHP<DLPMGCADPIG>, JDGEMIEKOBG<DLPMGCADPIG>
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ED80", Offset = "0x6B3D780", VA = "0x186B3ED80", Slot = "4")]
	public IEnumerable<(DLPMGCADPIG, string)> KOBKFLAELPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x933CC0", Offset = "0x9326C0", VA = "0x180933CC0", Slot = "5")]
	public string HDKLABCEKJL(string MDNEILIKEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E680", Offset = "0x6B2D080", VA = "0x186B2E680", Slot = "6")]
	public DLPMGCADPIG BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return default(DLPMGCADPIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public PBFDHONLJJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NHFLPLMPBDG : OGJKGONAFHP<KHIGNFPBAIG>, JDGEMIEKOBG<KHIGNFPBAIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly JDGEMIEKOBG<OHMKPBHEIEO> DLGDOFOEJKM;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7D1F10", Offset = "0x7D0910", VA = "0x1807D1F10")]
	public NHFLPLMPBDG(JDGEMIEKOBG<OHMKPBHEIEO> DLGDOFOEJKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69D0150", Offset = "0x69CEB50", VA = "0x1869D0150", Slot = "4")]
	public IEnumerable<(KHIGNFPBAIG, string)> KOBKFLAELPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EA40", Offset = "0x6B3D440", VA = "0x186B3EA40", Slot = "6")]
	public KHIGNFPBAIG BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return default(KHIGNFPBAIG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ED40", Offset = "0x6B3D740", VA = "0x186B3ED40", Slot = "5")]
	public string HDKLABCEKJL(string MDNEILIKEFH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DHAPJEJDOLF : OGJKGONAFHP<IONCKFMPFKP>, JDGEMIEKOBG<IONCKFMPFKP>
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6B30000", Offset = "0x6B2EA00", VA = "0x186B30000", Slot = "4")]
	public IEnumerable<(IONCKFMPFKP, string)> KOBKFLAELPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x933CC0", Offset = "0x9326C0", VA = "0x180933CC0", Slot = "5")]
	public string HDKLABCEKJL(string MDNEILIKEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E680", Offset = "0x6B2D080", VA = "0x186B2E680", Slot = "6")]
	public IONCKFMPFKP BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return default(IONCKFMPFKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public DHAPJEJDOLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EFEEAJHACBO : OGJKGONAFHP<FMIFMPDKCJC>, JDGEMIEKOBG<FMIFMPDKCJC>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6B37C10", Offset = "0x6B36610", VA = "0x186B37C10", Slot = "4")]
	public IEnumerable<(FMIFMPDKCJC, string)> KOBKFLAELPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x933CC0", Offset = "0x9326C0", VA = "0x180933CC0", Slot = "5")]
	public string HDKLABCEKJL(string MDNEILIKEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E680", Offset = "0x6B2D080", VA = "0x186B2E680", Slot = "6")]
	public FMIFMPDKCJC BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return default(FMIFMPDKCJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public EFEEAJHACBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ELDEKPMBENG : OGJKGONAFHP<NPPGCJBCMBB>, JDGEMIEKOBG<NPPGCJBCMBB>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6B394D0", Offset = "0x6B37ED0", VA = "0x186B394D0", Slot = "4")]
	public IEnumerable<(NPPGCJBCMBB, string)> KOBKFLAELPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x933CC0", Offset = "0x9326C0", VA = "0x180933CC0", Slot = "5")]
	public string HDKLABCEKJL(string MDNEILIKEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E680", Offset = "0x6B2D080", VA = "0x186B2E680", Slot = "6")]
	public NPPGCJBCMBB BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return default(NPPGCJBCMBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public ELDEKPMBENG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class BMNNKDBIPOD : OGJKGONAFHP<GNIEBFPNHCO>, JDGEMIEKOBG<GNIEBFPNHCO>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6B2F980", Offset = "0x6B2E380", VA = "0x186B2F980", Slot = "4")]
	public IEnumerable<(GNIEBFPNHCO, string)> KOBKFLAELPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x933CC0", Offset = "0x9326C0", VA = "0x180933CC0", Slot = "5")]
	public string HDKLABCEKJL(string MDNEILIKEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E680", Offset = "0x6B2D080", VA = "0x186B2E680", Slot = "6")]
	public GNIEBFPNHCO BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return default(GNIEBFPNHCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public BMNNKDBIPOD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OGJKGONAFHP<TModern> : JDGEMIEKOBG<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> KOBKFLAELPD();

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HDKLABCEKJL(string MDNEILIKEFH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class ADNEHMOGIAD : OGJKGONAFHP<OHMKPBHEIEO>, JDGEMIEKOBG<OHMKPBHEIEO>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6A842C0", Offset = "0x6A82CC0", VA = "0x186A842C0", Slot = "4")]
	public IEnumerable<(OHMKPBHEIEO, string)> KOBKFLAELPD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x933CC0", Offset = "0x9326C0", VA = "0x180933CC0", Slot = "5")]
	public string HDKLABCEKJL(string MDNEILIKEFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E680", Offset = "0x6B2D080", VA = "0x186B2E680", Slot = "6")]
	public OHMKPBHEIEO BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return default(OHMKPBHEIEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
	public ADNEHMOGIAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NLDBCKLAKHD<TModern> : FKMAIDJKEAO<TModern>, JDGEMIEKOBG<TModern> where TModern : IEquatable<TModern>, KMKAGJMEMOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> JKNFNHANPAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> HAAHMLLDCJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly OGJKGONAFHP<TModern> DJALPDBFNMB;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x40E14B0", Offset = "0x40DFEB0", VA = "0x1840E14B0")]
	public NLDBCKLAKHD(OGJKGONAFHP<TModern> DJALPDBFNMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x40DF790", Offset = "0x40DE190", VA = "0x1840DF790", Slot = "5")]
	public TModern BMNFHNKFAPP(string MDNEILIKEFH)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x40E07C0", Offset = "0x40DF1C0", VA = "0x1840E07C0", Slot = "4")]
	public string CHPDKBHPKII(TModern GAAGIMOFBBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class AGJELBBPNBL : MELEAMAAHID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NLDBCKLAKHD<NNIELEFOFHC> BCKMGBNNEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private NLDBCKLAKHD<IONCKFMPFKP> IIADJGIDFLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NLDBCKLAKHD<GNIEBFPNHCO> BDGIJAJCPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NLDBCKLAKHD<OHMKPBHEIEO> DLGDOFOEJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private NLDBCKLAKHD<KHIGNFPBAIG> KLLJCABNCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NLDBCKLAKHD<DLPMGCADPIG> KNELLMIMIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private NLDBCKLAKHD<NPPGCJBCMBB> EIFAGDPDMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private NLDBCKLAKHD<BENBKFHMAMC> MODDGDEEIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NLDBCKLAKHD<FMIFMPDKCJC> KHDMPDLCCKN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public FKMAIDJKEAO<NNIELEFOFHC> FBKIDFGNPCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x7C4D30", Offset = "0x7C3730", VA = "0x1807C4D30", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public FKMAIDJKEAO<IONCKFMPFKP> JILIOOLDALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public FKMAIDJKEAO<GNIEBFPNHCO> ICGGOCBOKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public FKMAIDJKEAO<KHIGNFPBAIG> PJOCKLCMOCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7C8F90", Offset = "0x7C7990", VA = "0x1807C8F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public FKMAIDJKEAO<DLPMGCADPIG> CDCKIGIDBGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AC0", Offset = "0x7C44C0", VA = "0x1807C5AC0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public FKMAIDJKEAO<NPPGCJBCMBB> DAOJLIBNDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AB0", Offset = "0x7C44B0", VA = "0x1807C5AB0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public FKMAIDJKEAO<BENBKFHMAMC> HJDKIGMEILA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7C9C10", Offset = "0x7C8610", VA = "0x1807C9C10", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FKMAIDJKEAO<FMIFMPDKCJC> EAGKGPBBLEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7C6940", Offset = "0x7C5340", VA = "0x1807C6940", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E740", Offset = "0x6B2D140", VA = "0x186B2E740")]
	[JCOMPLNHMEG(EEKBGOJGGBC.Root, AOHDMBIABEL.GameOnly)]
	[UsedImplicitly]
	private static void PPNLMJNBNPK(ICKBMMGCCPN AIGNNHACHNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B2E7B0", Offset = "0x6B2D1B0", VA = "0x186B2E7B0")]
	[Preserve]
	public AGJELBBPNBL()
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
