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
public class HLNFJIAGGPO : JHHOAOJAKLB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex EMCKPMEIKJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly GPOLAKEALAF DCBDMMLDONE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69E15F0", Offset = "0x69E07F0", VA = "0x1869E15F0")]
	[KEFCCLBEAOJ(CMEECPGEPNF.GameOnly)]
	[UsedImplicitly]
	private static void MOJFLBKELFO(LEHDPNIFNIH AJCCGGFMFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69E0ED0", Offset = "0x69E00D0", VA = "0x1869E0ED0")]
	[UsedImplicitly]
	[KEFCCLBEAOJ(CMEECPGEPNF.EditorOnly)]
	private static void GKBJLJDJLLF(LEHDPNIFNIH AJCCGGFMFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	[Preserve]
	public HLNFJIAGGPO([GAGPBLHNPNO(null)] GPOLAKEALAF DCBDMMLDONE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69E1660", Offset = "0x69E0860", VA = "0x1869E1660", Slot = "4")]
	public string OHDBDPJBHPM(KJPHDDIDNHP CCAOJBHBKKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69E0F30", Offset = "0x69E0130", VA = "0x1869E0F30", Slot = "5")]
	public KJPHDDIDNHP LKMADFBDLGL(string CCAOJBHBKKC)
	{
		return default(KJPHDDIDNHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OCOGODLJCIO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69E23B0", Offset = "0x69E15B0", VA = "0x1869E23B0")]
	public static GPOLAKEALAF CCBPKGOHDMG()
	{
		return null;
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, CMCGFHCJJCJ
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
		[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
		public SerializedAvatarItemId(JEAGJPCCODB JNIKIHKLGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public JEAGJPCCODB LKMADFBDLGL()
		{
			return default(JEAGJPCCODB);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
		public Guid FCDJDDEIANC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x69E7530", Offset = "0x69E6730", VA = "0x1869E7530", Slot = "4")]
		public bool Equals(SerializedAvatarItemId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x921B80", Offset = "0x920D80", VA = "0x180921B80", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x69E7490", Offset = "0x69E6690", VA = "0x1869E7490", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x921E20", Offset = "0x921020", VA = "0x180921E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x69E7550", Offset = "0x69E6750", VA = "0x1869E7550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, CMCGFHCJJCJ
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
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public CPLNGBDKCMH LKMADFBDLGL()
		{
			return default(CPLNGBDKCMH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
		public Guid FCDJDDEIANC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69E7530", Offset = "0x69E6730", VA = "0x1869E7530", Slot = "4")]
		public bool Equals(SerializedBodyShapeId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x921B80", Offset = "0x920D80", VA = "0x180921B80", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x69E75C0", Offset = "0x69E67C0", VA = "0x1869E75C0", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x921E20", Offset = "0x921020", VA = "0x180921E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69E7660", Offset = "0x69E6860", VA = "0x1869E7660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, CMCGFHCJJCJ
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
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
		public Guid FCDJDDEIANC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public BIIGIEBHNIJ LKMADFBDLGL()
		{
			return default(BIIGIEBHNIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69E7530", Offset = "0x69E6730", VA = "0x1869E7530", Slot = "4")]
		public bool Equals(SerializedColorId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x921B80", Offset = "0x920D80", VA = "0x180921B80", Slot = "5")]
		public int CompareTo(SerializedColorId NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69E76D0", Offset = "0x69E68D0", VA = "0x1869E76D0", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x921E20", Offset = "0x921020", VA = "0x180921E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x69E7770", Offset = "0x69E6970", VA = "0x1869E7770", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, CMCGFHCJJCJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x69E7990", Offset = "0x69E6B90", VA = "0x1869E7990")]
		public HNNJKOJEHLP LKMADFBDLGL()
		{
			return default(HNNJKOJEHLP);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
		public Guid FCDJDDEIANC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69E7A70", Offset = "0x69E6C70", VA = "0x1869E7A70")]
		public SerializedCombinationId(HNNJKOJEHLP KLDFNCBGOLA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69E7890", Offset = "0x69E6A90", VA = "0x1869E7890")]
		private void GPPGLGLMGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6874AD0", Offset = "0x6873CD0", VA = "0x186874AD0", Slot = "4")]
		public bool Equals(SerializedCombinationId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69E77E0", Offset = "0x69E69E0", VA = "0x1869E77E0", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x921E20", Offset = "0x921020", VA = "0x180921E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x921B80", Offset = "0x920D80", VA = "0x180921B80", Slot = "5")]
		public int CompareTo(SerializedCombinationId NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69E7A00", Offset = "0x69E6C00", VA = "0x1869E7A00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69E79F0", Offset = "0x69E6BF0", VA = "0x1869E79F0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, CMCGFHCJJCJ
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
		[Cpp2IlInjected.Address(RVA = "0x69E7B40", Offset = "0x69E6D40", VA = "0x1869E7B40")]
		public static SerializedEquipmentSkinId GAFBJLGOKMO()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
		public Guid FCDJDDEIANC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public LCOFMHLCHJJ LKMADFBDLGL()
		{
			return default(LCOFMHLCHJJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69E7530", Offset = "0x69E6730", VA = "0x1869E7530", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69E7AA0", Offset = "0x69E6CA0", VA = "0x1869E7AA0", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x921B80", Offset = "0x920D80", VA = "0x180921B80", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x921E20", Offset = "0x921020", VA = "0x180921E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69E7B70", Offset = "0x69E6D70", VA = "0x1869E7B70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, CMCGFHCJJCJ
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
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
		public Guid FCDJDDEIANC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public LDNHAIONBAK LKMADFBDLGL()
		{
			return default(LDNHAIONBAK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x69E7530", Offset = "0x69E6730", VA = "0x1869E7530", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x921B80", Offset = "0x920D80", VA = "0x180921B80", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69E7BE0", Offset = "0x69E6DE0", VA = "0x1869E7BE0", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x921E20", Offset = "0x921020", VA = "0x180921E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69E7C80", Offset = "0x69E6E80", VA = "0x1869E7C80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, CMCGFHCJJCJ
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
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
		public Guid FCDJDDEIANC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public KBMOELFNJEP LKMADFBDLGL()
		{
			return default(KBMOELFNJEP);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x69E7530", Offset = "0x69E6730", VA = "0x1869E7530", Slot = "4")]
		public bool Equals(SerializedFaceShapeId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x921B80", Offset = "0x920D80", VA = "0x180921B80", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x69E7CF0", Offset = "0x69E6EF0", VA = "0x1869E7CF0", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x921E20", Offset = "0x921020", VA = "0x180921E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x69E7D90", Offset = "0x69E6F90", VA = "0x1869E7D90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, CMCGFHCJJCJ
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
		[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
		public SerializedHairPatternId(CBAFNFNJIBK JNIKIHKLGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
		public Guid FCDJDDEIANC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public CBAFNFNJIBK LKMADFBDLGL()
		{
			return default(CBAFNFNJIBK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x69E7530", Offset = "0x69E6730", VA = "0x1869E7530", Slot = "4")]
		public bool Equals(SerializedHairPatternId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x921B80", Offset = "0x920D80", VA = "0x180921B80", Slot = "5")]
		public int CompareTo(SerializedHairPatternId NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x69E7E00", Offset = "0x69E7000", VA = "0x1869E7E00", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x921E20", Offset = "0x921020", VA = "0x180921E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x69E7530", Offset = "0x69E6730", VA = "0x1869E7530")]
		public static bool AIPCENMEJFE(SerializedHairPatternId EBKLEGBLPGD, SerializedHairPatternId JCPNHMOLDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x69E7EA0", Offset = "0x69E70A0", VA = "0x1869E7EA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, CMCGFHCJJCJ
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
		[Cpp2IlInjected.Address(RVA = "0x1E4A460", Offset = "0x1E49660", VA = "0x181E4A460")]
		public SerializedMaterialId(OKFEMKEKNOO JNIKIHKLGAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70", Slot = "6")]
		public Guid FCDJDDEIANC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x87DF70", Offset = "0x87D170", VA = "0x18087DF70")]
		public OKFEMKEKNOO LKMADFBDLGL()
		{
			return default(OKFEMKEKNOO);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6874AD0", Offset = "0x6873CD0", VA = "0x186874AD0", Slot = "4")]
		public bool Equals(SerializedMaterialId NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x69E7F10", Offset = "0x69E7110", VA = "0x1869E7F10", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x921E20", Offset = "0x921020", VA = "0x180921E20", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6874AD0", Offset = "0x6873CD0", VA = "0x186874AD0")]
		public static bool AIPCENMEJFE(SerializedMaterialId EBKLEGBLPGD, SerializedMaterialId JCPNHMOLDGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x921B80", Offset = "0x920D80", VA = "0x180921B80", Slot = "5")]
		public int CompareTo(SerializedMaterialId NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x69E7FB0", Offset = "0x69E71B0", VA = "0x1869E7FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AIODJKIEOAI : GPOLAKEALAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static AIODJKIEOAI KMGHIJMKCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x69D4B30", Offset = "0x69D3D30", VA = "0x1869D4B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public LIAFPDFNCIE<JEAGJPCCODB> IIICBPHCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69D4B90", Offset = "0x69D3D90", VA = "0x1869D4B90", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LIAFPDFNCIE<LCOFMHLCHJJ> NJOJJDCJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69D4A70", Offset = "0x69D3C70", VA = "0x1869D4A70", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LIAFPDFNCIE<CBAFNFNJIBK> IHICHJLHGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x69D49B0", Offset = "0x69D3BB0", VA = "0x1869D49B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public LIAFPDFNCIE<HNNJKOJEHLP> ABDHAKMKIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69D4A10", Offset = "0x69D3C10", VA = "0x1869D4A10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public LIAFPDFNCIE<BIIGIEBHNIJ> JGPOIBHBBPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x69D4950", Offset = "0x69D3B50", VA = "0x1869D4950", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public LIAFPDFNCIE<KBMOELFNJEP> AONLEBNIFKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x69D4BF0", Offset = "0x69D3DF0", VA = "0x1869D4BF0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public LIAFPDFNCIE<CPLNGBDKCMH> BOABNKBAHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x69D48F0", Offset = "0x69D3AF0", VA = "0x1869D48F0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public LIAFPDFNCIE<LDNHAIONBAK> CBJOAFBBLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69D4AD0", Offset = "0x69D3CD0", VA = "0x1869D4AD0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public static class ILNLHPPMHDA
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69E1BB0", Offset = "0x69E0DB0", VA = "0x1869E1BB0")]
	public static Guid CHGNAODFDIP(string BGANOCMPFBP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69E1C60", Offset = "0x69E0E60", VA = "0x1869E1C60")]
	public static bool KMDIAEJINJG(string BGANOCMPFBP, [Out] Guid IKOKEKHMFKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class PJNDPHKFOMF : MIMAPIFGABA<JEAGJPCCODB>, ANCKFOKNMGP<JEAGJPCCODB>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69E2400", Offset = "0x69E1600", VA = "0x1869E2400", Slot = "4")]
	public IEnumerable<(JEAGJPCCODB, string)> AAGNHADALMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69E7050", Offset = "0x69E6250", VA = "0x1869E7050", Slot = "5")]
	public string HPELBPGMJIK(string OPEMFPOCFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69D4FF0", Offset = "0x69D41F0", VA = "0x1869D4FF0", Slot = "6")]
	public JEAGJPCCODB IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return default(JEAGJPCCODB);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public PJNDPHKFOMF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BACMCDHBIEJ : MIMAPIFGABA<CPLNGBDKCMH>, ANCKFOKNMGP<CPLNGBDKCMH>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69D4C50", Offset = "0x69D3E50", VA = "0x1869D4C50", Slot = "4")]
	public IEnumerable<(CPLNGBDKCMH, string)> AAGNHADALMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x923B30", Offset = "0x922D30", VA = "0x180923B30", Slot = "5")]
	public string HPELBPGMJIK(string OPEMFPOCFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69D4FF0", Offset = "0x69D41F0", VA = "0x1869D4FF0", Slot = "6")]
	public CPLNGBDKCMH IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return default(CPLNGBDKCMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public BACMCDHBIEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class CIPGLDCNIMD : MIMAPIFGABA<BIIGIEBHNIJ>, ANCKFOKNMGP<BIIGIEBHNIJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69DD210", Offset = "0x69DC410", VA = "0x1869DD210", Slot = "4")]
	public IEnumerable<(BIIGIEBHNIJ, string)> AAGNHADALMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x923B30", Offset = "0x922D30", VA = "0x180923B30", Slot = "5")]
	public string HPELBPGMJIK(string OPEMFPOCFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69D4FF0", Offset = "0x69D41F0", VA = "0x1869D4FF0", Slot = "6")]
	public BIIGIEBHNIJ IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return default(BIIGIEBHNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public CIPGLDCNIMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FNDKMNNLDGB : MIMAPIFGABA<HNNJKOJEHLP>, ANCKFOKNMGP<HNNJKOJEHLP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly ANCKFOKNMGP<OKFEMKEKNOO> PGLAPHKEJKH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7B8790", Offset = "0x7B7990", VA = "0x1807B8790")]
	public FNDKMNNLDGB(ANCKFOKNMGP<OKFEMKEKNOO> PGLAPHKEJKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x68763C0", Offset = "0x68755C0", VA = "0x1868763C0", Slot = "4")]
	public IEnumerable<(HNNJKOJEHLP, string)> AAGNHADALMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69E0BD0", Offset = "0x69DFDD0", VA = "0x1869E0BD0", Slot = "6")]
	public HNNJKOJEHLP IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return default(HNNJKOJEHLP);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69E0B90", Offset = "0x69DFD90", VA = "0x1869E0B90", Slot = "5")]
	public string HPELBPGMJIK(string OPEMFPOCFNH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CEMCCGEMHEH : MIMAPIFGABA<LCOFMHLCHJJ>, ANCKFOKNMGP<LCOFMHLCHJJ>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69D50B0", Offset = "0x69D42B0", VA = "0x1869D50B0", Slot = "4")]
	public IEnumerable<(LCOFMHLCHJJ, string)> AAGNHADALMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x923B30", Offset = "0x922D30", VA = "0x180923B30", Slot = "5")]
	public string HPELBPGMJIK(string OPEMFPOCFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69D4FF0", Offset = "0x69D41F0", VA = "0x1869D4FF0", Slot = "6")]
	public LCOFMHLCHJJ IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return default(LCOFMHLCHJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public CEMCCGEMHEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class EAAEGDCFCDK : MIMAPIFGABA<LDNHAIONBAK>, ANCKFOKNMGP<LDNHAIONBAK>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69DF2D0", Offset = "0x69DE4D0", VA = "0x1869DF2D0", Slot = "4")]
	public IEnumerable<(LDNHAIONBAK, string)> AAGNHADALMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x923B30", Offset = "0x922D30", VA = "0x180923B30", Slot = "5")]
	public string HPELBPGMJIK(string OPEMFPOCFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69D4FF0", Offset = "0x69D41F0", VA = "0x1869D4FF0", Slot = "6")]
	public LDNHAIONBAK IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return default(LDNHAIONBAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EAAEGDCFCDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class PPKFAIFNJNB : MIMAPIFGABA<KBMOELFNJEP>, ANCKFOKNMGP<KBMOELFNJEP>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69E7070", Offset = "0x69E6270", VA = "0x1869E7070", Slot = "4")]
	public IEnumerable<(KBMOELFNJEP, string)> AAGNHADALMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x923B30", Offset = "0x922D30", VA = "0x180923B30", Slot = "5")]
	public string HPELBPGMJIK(string OPEMFPOCFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69D4FF0", Offset = "0x69D41F0", VA = "0x1869D4FF0", Slot = "6")]
	public KBMOELFNJEP IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return default(KBMOELFNJEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public PPKFAIFNJNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class LIGCHAJLOJJ : MIMAPIFGABA<CBAFNFNJIBK>, ANCKFOKNMGP<CBAFNFNJIBK>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69E1D30", Offset = "0x69E0F30", VA = "0x1869E1D30", Slot = "4")]
	public IEnumerable<(CBAFNFNJIBK, string)> AAGNHADALMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x923B30", Offset = "0x922D30", VA = "0x180923B30", Slot = "5")]
	public string HPELBPGMJIK(string OPEMFPOCFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69D4FF0", Offset = "0x69D41F0", VA = "0x1869D4FF0", Slot = "6")]
	public CBAFNFNJIBK IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return default(CBAFNFNJIBK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public LIGCHAJLOJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface MIMAPIFGABA<TModern> : ANCKFOKNMGP<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> AAGNHADALMI();

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string HPELBPGMJIK(string OPEMFPOCFNH);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EGDIKNFJDEM : MIMAPIFGABA<OKFEMKEKNOO>, ANCKFOKNMGP<OKFEMKEKNOO>
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x692A530", Offset = "0x6929730", VA = "0x18692A530", Slot = "4")]
	public IEnumerable<(OKFEMKEKNOO, string)> AAGNHADALMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x923B30", Offset = "0x922D30", VA = "0x180923B30", Slot = "5")]
	public string HPELBPGMJIK(string OPEMFPOCFNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x69D4FF0", Offset = "0x69D41F0", VA = "0x1869D4FF0", Slot = "6")]
	public OKFEMKEKNOO IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return default(OKFEMKEKNOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public EGDIKNFJDEM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JKAEHDLGCFG<TModern> : LIAFPDFNCIE<TModern>, ANCKFOKNMGP<TModern> where TModern : IEquatable<TModern>, CMCGFHCJJCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<TModern, string> OGILEMJNIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<string, TModern> HIBDIPFJHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly MIMAPIFGABA<TModern> LLBFNGDMMCN;

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3C25E60", Offset = "0x3C25060", VA = "0x183C25E60")]
	public JKAEHDLGCFG(MIMAPIFGABA<TModern> LLBFNGDMMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x3C24300", Offset = "0x3C23500", VA = "0x183C24300", Slot = "5")]
	public TModern IEBCFEBKCFG(string OPEMFPOCFNH)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x3C24830", Offset = "0x3C23A30", VA = "0x183C24830", Slot = "4")]
	public string KBPJPEFBEHA(TModern CHLGJGIOOEM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CFCEIBMNHLO : GPOLAKEALAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private JKAEHDLGCFG<JEAGJPCCODB> HEPCJIABOCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private JKAEHDLGCFG<LCOFMHLCHJJ> ELPPLLOAFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private JKAEHDLGCFG<CBAFNFNJIBK> CNFHONIGEOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private JKAEHDLGCFG<OKFEMKEKNOO> PGLAPHKEJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private JKAEHDLGCFG<HNNJKOJEHLP> PPFEHNBMEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private JKAEHDLGCFG<BIIGIEBHNIJ> LPOJGIPBJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private JKAEHDLGCFG<KBMOELFNJEP> ENIHPMPBOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private JKAEHDLGCFG<CPLNGBDKCMH> JJEEFIFOBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private JKAEHDLGCFG<LDNHAIONBAK> BDAMNPLJBLM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public LIAFPDFNCIE<JEAGJPCCODB> IIICBPHCMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public LIAFPDFNCIE<LCOFMHLCHJJ> NJOJJDCJGFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public LIAFPDFNCIE<CBAFNFNJIBK> IHICHJLHGNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public LIAFPDFNCIE<HNNJKOJEHLP> ABDHAKMKIOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public LIAFPDFNCIE<BIIGIEBHNIJ> JGPOIBHBBPI
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x7B62D0", Offset = "0x7B54D0", VA = "0x1807B62D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public LIAFPDFNCIE<KBMOELFNJEP> AONLEBNIFKM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1A0", Offset = "0x7BD3A0", VA = "0x1807BE1A0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public LIAFPDFNCIE<CPLNGBDKCMH> BOABNKBAHOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x7B6020", Offset = "0x7B5220", VA = "0x1807B6020", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public LIAFPDFNCIE<LDNHAIONBAK> CBJOAFBBLBE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x69DCCC0", Offset = "0x69DBEC0", VA = "0x1869DCCC0")]
	[KEFCCLBEAOJ(BDECECCJEGA.Root, CMEECPGEPNF.GameOnly)]
	[UsedImplicitly]
	private static void HOAPDFIGOHL(LEHDPNIFNIH AJCCGGFMFPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x69DCD30", Offset = "0x69DBF30", VA = "0x1869DCD30")]
	[Preserve]
	public CFCEIBMNHLO()
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
