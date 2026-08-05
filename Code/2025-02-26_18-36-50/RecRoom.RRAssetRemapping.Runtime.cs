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
		[Cpp2IlInjected.Address(RVA = "0x7DF7920", Offset = "0x7DF6D20", VA = "0x187DF7920", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x242AF30", Offset = "0x242A330", VA = "0x18242AF30")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class GLGEJNCMOHE : EKLILNCOKGK
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex KCFHGMEOECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly OPIFMDAOECG KAKBMLMFMPN;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0E10", Offset = "0x7DF0210", VA = "0x187DF0E10")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	[UsedImplicitly]
	internal static void AOKDCDMDNDH(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0E80", Offset = "0x7DF0280", VA = "0x187DF0E80")]
	[UsedImplicitly]
	internal static void GCBIDINOMFO(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	[RecRoom.NoEngine.Common.Preserve]
	public GLGEJNCMOHE([IBJCGEMJMJL(null)] OPIFMDAOECG KAKBMLMFMPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7DF13B0", Offset = "0x7DF07B0", VA = "0x187DF13B0", Slot = "4")]
	public string IMJDHHAECMF(HAHPCGIIIOL IOJLNNHDMIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0EE0", Offset = "0x7DF02E0", VA = "0x187DF0EE0", Slot = "5")]
	public HAHPCGIIIOL GFOCOOKFNLL(string IOJLNNHDMIE)
	{
		return default(HAHPCGIIIOL);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, IFCLNAHLMPM
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
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0")]
		public FFPOHEDMPPG GFOCOOKFNLL()
		{
			return default(FFPOHEDMPPG);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80", Slot = "4")]
		public bool Equals(SerializedAvatarItemId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6DE0", Offset = "0x7DF61E0", VA = "0x187DF6DE0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6EA0", Offset = "0x7DF62A0", VA = "0x187DF6EA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, IFCLNAHLMPM
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
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0")]
		public BLMLNFKIBJD GFOCOOKFNLL()
		{
			return default(BLMLNFKIBJD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80", Slot = "4")]
		public bool Equals(SerializedBodyShapeId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6F10", Offset = "0x7DF6310", VA = "0x187DF6F10", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6FB0", Offset = "0x7DF63B0", VA = "0x187DF6FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, IFCLNAHLMPM
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
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0")]
		public OIJBGBIBLJK GFOCOOKFNLL()
		{
			return default(OIJBGBIBLJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80", Slot = "4")]
		public bool Equals(SerializedColorId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedColorId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7020", Offset = "0x7DF6420", VA = "0x187DF7020", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF70C0", Offset = "0x7DF64C0", VA = "0x187DF70C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, IFCLNAHLMPM, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xACB980", Offset = "0xACAD80", VA = "0x180ACB980")]
		public MCCAPFKCCCM GFOCOOKFNLL()
		{
			return default(MCCAPFKCCCM);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x7C83FD0", Offset = "0x7C833D0", VA = "0x187C83FD0", Slot = "4")]
		public bool Equals(SerializedCombinationId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7130", Offset = "0x7DF6530", VA = "0x187DF7130", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedCombinationId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7DF71F0", Offset = "0x7DF65F0", VA = "0x187DF71F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x94AA60", Offset = "0x949E60", VA = "0x18094AA60", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7DF71E0", Offset = "0x7DF65E0", VA = "0x187DF71E0", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, IFCLNAHLMPM
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
		[Cpp2IlInjected.Address(RVA = "0x1034AA0", Offset = "0x1033EA0", VA = "0x181034AA0")]
		public SerializedCustomAvatarItemId(Guid JINNLDEOCMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0")]
		public static SerializedCustomAvatarItemId HALJHAEPHLG(Guid JINNLDEOCMO)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7260", Offset = "0x7DF6660", VA = "0x187DF7260", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80")]
		public static bool BFIJCNNIIMH(SerializedCustomAvatarItemId HJGDMEAJFEI, SerializedCustomAvatarItemId OHAJMMPIMHB)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7300", Offset = "0x7DF6700", VA = "0x187DF7300")]
		public static bool HKDAGECLGLD(SerializedCustomAvatarItemId HJGDMEAJFEI, SerializedCustomAvatarItemId OHAJMMPIMHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7320", Offset = "0x7DF6720", VA = "0x187DF7320", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, IFCLNAHLMPM
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
		[Cpp2IlInjected.Address(RVA = "0x7DF7430", Offset = "0x7DF6830", VA = "0x187DF7430")]
		public static SerializedEquipmentSkinId FDBPCABBOJB()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0")]
		public FAKGGEAKAGO GFOCOOKFNLL()
		{
			return default(FAKGGEAKAGO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7390", Offset = "0x7DF6790", VA = "0x187DF7390", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7460", Offset = "0x7DF6860", VA = "0x187DF7460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, IFCLNAHLMPM
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
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0")]
		public EJPJNNNFMKK GFOCOOKFNLL()
		{
			return default(EJPJNNNFMKK);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF74D0", Offset = "0x7DF68D0", VA = "0x187DF74D0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7570", Offset = "0x7DF6970", VA = "0x187DF7570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, IFCLNAHLMPM
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
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0")]
		public BFBNNFENAIB GFOCOOKFNLL()
		{
			return default(BFBNNFENAIB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80", Slot = "4")]
		public bool Equals(SerializedFaceShapeId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7DF75E0", Offset = "0x7DF69E0", VA = "0x187DF75E0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7680", Offset = "0x7DF6A80", VA = "0x187DF7680", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, IFCLNAHLMPM
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
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0")]
		public ICPMIFBJODI GFOCOOKFNLL()
		{
			return default(ICPMIFBJODI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80", Slot = "4")]
		public bool Equals(SerializedHairPatternId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF76F0", Offset = "0x7DF6AF0", VA = "0x187DF76F0", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF6E80", Offset = "0x7DF6280", VA = "0x187DF6E80")]
		public static bool BFIJCNNIIMH(SerializedHairPatternId HJGDMEAJFEI, SerializedHairPatternId OHAJMMPIMHB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7790", Offset = "0x7DF6B90", VA = "0x187DF7790", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, IFCLNAHLMPM
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
		[Cpp2IlInjected.Address(RVA = "0x10349D0", Offset = "0x1033DD0", VA = "0x1810349D0", Slot = "6")]
		public Guid OPOKBIINDAM()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7C83FD0", Offset = "0x7C833D0", VA = "0x187C83FD0", Slot = "4")]
		public bool Equals(SerializedMaterialId OKCHLIEAIJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7DF7800", Offset = "0x7DF6C00", VA = "0x187DF7800", Slot = "0")]
		public override bool Equals(object GMFKPONAANG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x72F6470", Offset = "0x72F5870", VA = "0x1872F6470", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x72F62E0", Offset = "0x72F56E0", VA = "0x1872F62E0", Slot = "5")]
		public int CompareTo(SerializedMaterialId OKCHLIEAIJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7DF78B0", Offset = "0x7DF6CB0", VA = "0x187DF78B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class GOIICPJAKLE : OPIFMDAOECG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static GOIICPJAKLE IMFIEPMCPDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7DF19D0", Offset = "0x7DF0DD0", VA = "0x187DF19D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public BMLBHIEMCPF<FFPOHEDMPPG> FCFBMHGAJLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7DF18B0", Offset = "0x7DF0CB0", VA = "0x187DF18B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BMLBHIEMCPF<FAKGGEAKAGO> CMPPFDNBECL
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7DF17F0", Offset = "0x7DF0BF0", VA = "0x187DF17F0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BMLBHIEMCPF<ICPMIFBJODI> GPLLECHHHHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1790", Offset = "0x7DF0B90", VA = "0x187DF1790", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BMLBHIEMCPF<MCCAPFKCCCM> ALBCKHHIPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1910", Offset = "0x7DF0D10", VA = "0x187DF1910", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BMLBHIEMCPF<OIJBGBIBLJK> NMEAFJINMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1A30", Offset = "0x7DF0E30", VA = "0x187DF1A30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BMLBHIEMCPF<BFBNNFENAIB> PJHLIAMAMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1970", Offset = "0x7DF0D70", VA = "0x187DF1970", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BMLBHIEMCPF<BLMLNFKIBJD> GJBFOMEHGEB
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1A90", Offset = "0x7DF0E90", VA = "0x187DF1A90", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BMLBHIEMCPF<EJPJNNNFMKK> PJDJIANCNLA
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF1850", Offset = "0x7DF0C50", VA = "0x187DF1850", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class GFDAGNJFCOM
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0C90", Offset = "0x7DF0090", VA = "0x187DF0C90")]
	public static Guid ADPGFPFGDDC(string LDHHFEGBKBN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7DF0D40", Offset = "0x7DF0140", VA = "0x187DF0D40")]
	public static bool OPGNJJFALBA(string LDHHFEGBKBN, [Out] Guid JINNLDEOCMO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NKPPIONAGJL : LOBKNKFDLGE<FFPOHEDMPPG>, KPAPMGFPBPM<FFPOHEDMPPG>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7DF2170", Offset = "0x7DF1570", VA = "0x187DF2170", Slot = "4")]
	public IEnumerable<(FFPOHEDMPPG, string)> CCJFEHMKJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DF6DC0", Offset = "0x7DF61C0", VA = "0x187DF6DC0", Slot = "5")]
	public string DOCCDGMAFJI(string ICADNHAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4FA0", Offset = "0x7DE43A0", VA = "0x187DE4FA0", Slot = "6")]
	public FFPOHEDMPPG PEFELHAFJKK(string ICADNHAJGEB)
	{
		return default(FFPOHEDMPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public NKPPIONAGJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BJPBEGBINIE : LOBKNKFDLGE<BLMLNFKIBJD>, KPAPMGFPBPM<BLMLNFKIBJD>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4C00", Offset = "0x7DE4000", VA = "0x187DE4C00", Slot = "4")]
	public IEnumerable<(BLMLNFKIBJD, string)> CCJFEHMKJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xCBABF0", Offset = "0xCB9FF0", VA = "0x180CBABF0", Slot = "5")]
	public string DOCCDGMAFJI(string ICADNHAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4FA0", Offset = "0x7DE43A0", VA = "0x187DE4FA0", Slot = "6")]
	public BLMLNFKIBJD PEFELHAFJKK(string ICADNHAJGEB)
	{
		return default(BLMLNFKIBJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public BJPBEGBINIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FOEBGPKICEE : LOBKNKFDLGE<OIJBGBIBLJK>, KPAPMGFPBPM<OIJBGBIBLJK>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7DEEBD0", Offset = "0x7DEDFD0", VA = "0x187DEEBD0", Slot = "4")]
	public IEnumerable<(OIJBGBIBLJK, string)> CCJFEHMKJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xCBABF0", Offset = "0xCB9FF0", VA = "0x180CBABF0", Slot = "5")]
	public string DOCCDGMAFJI(string ICADNHAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4FA0", Offset = "0x7DE43A0", VA = "0x187DE4FA0", Slot = "6")]
	public OIJBGBIBLJK PEFELHAFJKK(string ICADNHAJGEB)
	{
		return default(OIJBGBIBLJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public FOEBGPKICEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class FKPPDEHLHDP : LOBKNKFDLGE<MCCAPFKCCCM>, KPAPMGFPBPM<MCCAPFKCCCM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly KPAPMGFPBPM<EPLPMCOHIDD> DJKOCMELJDP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x951BA0", Offset = "0x950FA0", VA = "0x180951BA0")]
	public FKPPDEHLHDP(KPAPMGFPBPM<EPLPMCOHIDD> DJKOCMELJDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C842F0", Offset = "0x7C836F0", VA = "0x187C842F0", Slot = "4")]
	public IEnumerable<(MCCAPFKCCCM, string)> CCJFEHMKJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE990", Offset = "0x7DEDD90", VA = "0x187DEE990", Slot = "6")]
	public MCCAPFKCCCM PEFELHAFJKK(string ICADNHAJGEB)
	{
		return default(MCCAPFKCCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7DEE950", Offset = "0x7DEDD50", VA = "0x187DEE950", Slot = "5")]
	public string DOCCDGMAFJI(string ICADNHAJGEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class ECGFDMKFCHF : LOBKNKFDLGE<FAKGGEAKAGO>, KPAPMGFPBPM<FAKGGEAKAGO>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7DE5060", Offset = "0x7DE4460", VA = "0x187DE5060", Slot = "4")]
	public IEnumerable<(FAKGGEAKAGO, string)> CCJFEHMKJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xCBABF0", Offset = "0xCB9FF0", VA = "0x180CBABF0", Slot = "5")]
	public string DOCCDGMAFJI(string ICADNHAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4FA0", Offset = "0x7DE43A0", VA = "0x187DE4FA0", Slot = "6")]
	public FAKGGEAKAGO PEFELHAFJKK(string ICADNHAJGEB)
	{
		return default(FAKGGEAKAGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public ECGFDMKFCHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class FDBONPIILIL : LOBKNKFDLGE<EJPJNNNFMKK>, KPAPMGFPBPM<EJPJNNNFMKK>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7DED090", Offset = "0x7DEC490", VA = "0x187DED090", Slot = "4")]
	public IEnumerable<(EJPJNNNFMKK, string)> CCJFEHMKJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xCBABF0", Offset = "0xCB9FF0", VA = "0x180CBABF0", Slot = "5")]
	public string DOCCDGMAFJI(string ICADNHAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4FA0", Offset = "0x7DE43A0", VA = "0x187DE4FA0", Slot = "6")]
	public EJPJNNNFMKK PEFELHAFJKK(string ICADNHAJGEB)
	{
		return default(EJPJNNNFMKK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public FDBONPIILIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class EJKDOJKHMHO : LOBKNKFDLGE<BFBNNFENAIB>, KPAPMGFPBPM<BFBNNFENAIB>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7DECC70", Offset = "0x7DEC070", VA = "0x187DECC70", Slot = "4")]
	public IEnumerable<(BFBNNFENAIB, string)> CCJFEHMKJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xCBABF0", Offset = "0xCB9FF0", VA = "0x180CBABF0", Slot = "5")]
	public string DOCCDGMAFJI(string ICADNHAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4FA0", Offset = "0x7DE43A0", VA = "0x187DE4FA0", Slot = "6")]
	public BFBNNFENAIB PEFELHAFJKK(string ICADNHAJGEB)
	{
		return default(BFBNNFENAIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public EJKDOJKHMHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class IFINLODHCFB : LOBKNKFDLGE<ICPMIFBJODI>, KPAPMGFPBPM<ICPMIFBJODI>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7DF1AF0", Offset = "0x7DF0EF0", VA = "0x187DF1AF0", Slot = "4")]
	public IEnumerable<(ICPMIFBJODI, string)> CCJFEHMKJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xCBABF0", Offset = "0xCB9FF0", VA = "0x180CBABF0", Slot = "5")]
	public string DOCCDGMAFJI(string ICADNHAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4FA0", Offset = "0x7DE43A0", VA = "0x187DE4FA0", Slot = "6")]
	public ICPMIFBJODI PEFELHAFJKK(string ICADNHAJGEB)
	{
		return default(ICPMIFBJODI);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public IFINLODHCFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LOBKNKFDLGE<TModern> : KPAPMGFPBPM<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> CCJFEHMKJCK();

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string DOCCDGMAFJI(string ICADNHAJGEB);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EKLCCJPAGBI : LOBKNKFDLGE<EPLPMCOHIDD>, KPAPMGFPBPM<EPLPMCOHIDD>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7D39410", Offset = "0x7D38810", VA = "0x187D39410", Slot = "4")]
	public IEnumerable<(EPLPMCOHIDD, string)> CCJFEHMKJCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xCBABF0", Offset = "0xCB9FF0", VA = "0x180CBABF0", Slot = "5")]
	public string DOCCDGMAFJI(string ICADNHAJGEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4FA0", Offset = "0x7DE43A0", VA = "0x187DE4FA0", Slot = "6")]
	public EPLPMCOHIDD PEFELHAFJKK(string ICADNHAJGEB)
	{
		return default(EPLPMCOHIDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
	public EKLCCJPAGBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class IEBDFIICCAG<TModern> : BMLBHIEMCPF<TModern>, KPAPMGFPBPM<TModern> where TModern : IEquatable<TModern>, IFCLNAHLMPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> FFFPBDPADDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> ONGMMLBEGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly LOBKNKFDLGE<TModern> KEIHABNFADN;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x471D0B0", Offset = "0x471C4B0", VA = "0x18471D0B0")]
	public IEBDFIICCAG(LOBKNKFDLGE<TModern> KEIHABNFADN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x471A870", Offset = "0x4719C70", VA = "0x18471A870", Slot = "5")]
	public TModern PEFELHAFJKK(string ICADNHAJGEB)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x47191C0", Offset = "0x47185C0", VA = "0x1847191C0", Slot = "4")]
	public string IFCAOIHFKDD(TModern BFOKEGDOOJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AFMMABCAGNM : OPIFMDAOECG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private IEBDFIICCAG<FFPOHEDMPPG> FGHEPOKGNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private IEBDFIICCAG<FAKGGEAKAGO> OJJPFMKFGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private IEBDFIICCAG<ICPMIFBJODI> BHLABOOAKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private IEBDFIICCAG<EPLPMCOHIDD> DJKOCMELJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private IEBDFIICCAG<MCCAPFKCCCM> BOOGKCDOEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private IEBDFIICCAG<OIJBGBIBLJK> BBNDMMNCMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private IEBDFIICCAG<BFBNNFENAIB> GFFPKMCKCNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private IEBDFIICCAG<BLMLNFKIBJD> GKNMIIPKBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private IEBDFIICCAG<EJPJNNNFMKK> FGHEFEOENEA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BMLBHIEMCPF<FFPOHEDMPPG> FCFBMHGAJLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x949410", Offset = "0x948810", VA = "0x180949410", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BMLBHIEMCPF<FAKGGEAKAGO> CMPPFDNBECL
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x94B6B0", Offset = "0x94AAB0", VA = "0x18094B6B0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BMLBHIEMCPF<ICPMIFBJODI> GPLLECHHHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x94B800", Offset = "0x94AC00", VA = "0x18094B800", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BMLBHIEMCPF<MCCAPFKCCCM> ALBCKHHIPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x94DBC0", Offset = "0x94CFC0", VA = "0x18094DBC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BMLBHIEMCPF<OIJBGBIBLJK> NMEAFJINMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x94BDD0", Offset = "0x94B1D0", VA = "0x18094BDD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BMLBHIEMCPF<BFBNNFENAIB> PJHLIAMAMIO
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x94B9D0", Offset = "0x94ADD0", VA = "0x18094B9D0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BMLBHIEMCPF<BLMLNFKIBJD> GJBFOMEHGEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x94FAF0", Offset = "0x94EEF0", VA = "0x18094FAF0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BMLBHIEMCPF<EJPJNNNFMKK> PJDJIANCNLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x94FD70", Offset = "0x94F170", VA = "0x18094FD70", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7DE46B0", Offset = "0x7DE3AB0", VA = "0x187DE46B0")]
	[HLOHOCOKELO.IDGFAEKKODB.GGCNFHIOHEN]
	[UsedImplicitly]
	internal static void NADFCFLHLDK(GFKEMDIOCPC BFAKMKOHPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x7DE4720", Offset = "0x7DE3B20", VA = "0x187DE4720")]
	[RecRoom.NoEngine.Common.Preserve]
	public AFMMABCAGNM()
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
