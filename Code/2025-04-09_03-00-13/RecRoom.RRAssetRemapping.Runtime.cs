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
		[Cpp2IlInjected.Address(RVA = "0x8278090", Offset = "0x8277490", VA = "0x188278090", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x2553680", Offset = "0x2552A80", VA = "0x182553680")]
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
	[Cpp2IlInjected.Address(RVA = "0x82660B0", Offset = "0x82654B0", VA = "0x1882660B0")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	[UsedImplicitly]
	internal static void FJKHLPMEJLC(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8266120", Offset = "0x8265520", VA = "0x188266120")]
	[UsedImplicitly]
	internal static void FOMJPOKODJK(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	[RecRoom.NoEngine.Common.Preserve]
	public EJJEJKAFFIP([CMKKAFOAFJE(null)] IKKNLBGAIJE JJHCKCDCEDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8266640", Offset = "0x8265A40", VA = "0x188266640", Slot = "4")]
	public string PELCBGJOJPC(FEJKALOKOAI PJCOHHCODGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8266180", Offset = "0x8265580", VA = "0x188266180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540")]
		public LALAGECKOGA HFAEDKNMEEN()
		{
			return default(LALAGECKOGA);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600", Slot = "4")]
		public bool Equals(SerializedAvatarItemId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8277560", Offset = "0x8276960", VA = "0x188277560", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x8277620", Offset = "0x8276A20", VA = "0x188277620", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540")]
		public AOAHCJAKMBM HFAEDKNMEEN()
		{
			return default(AOAHCJAKMBM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600", Slot = "4")]
		public bool Equals(SerializedBodyShapeId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8277690", Offset = "0x8276A90", VA = "0x188277690", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8277730", Offset = "0x8276B30", VA = "0x188277730", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540")]
		public MDKOOLPNNLA HFAEDKNMEEN()
		{
			return default(MDKOOLPNNLA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600", Slot = "4")]
		public bool Equals(SerializedColorId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedColorId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82777A0", Offset = "0x8276BA0", VA = "0x1882777A0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8277840", Offset = "0x8276C40", VA = "0x188277840", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0xBA3F00", Offset = "0xBA3300", VA = "0x180BA3F00")]
		public PECGMKADMMG HFAEDKNMEEN()
		{
			return default(PECGMKADMMG);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x81048A0", Offset = "0x8103CA0", VA = "0x1881048A0", Slot = "4")]
		public bool Equals(SerializedCombinationId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82778B0", Offset = "0x8276CB0", VA = "0x1882778B0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedCombinationId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8277970", Offset = "0x8276D70", VA = "0x188277970", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA90", Offset = "0x9ABE90", VA = "0x1809ACA90", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8277960", Offset = "0x8276D60", VA = "0x188277960", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x11095C0", Offset = "0x11089C0", VA = "0x1811095C0")]
		public SerializedCustomAvatarItemId(Guid KDBHLLEACIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540")]
		public static SerializedCustomAvatarItemId LFGAKOBOICN(Guid KDBHLLEACIN)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82779E0", Offset = "0x8276DE0", VA = "0x1882779E0", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600")]
		public static bool PEOCKCCHEIN(SerializedCustomAvatarItemId KGCKEJLFPJB, SerializedCustomAvatarItemId HKELKGIPNGP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8277A80", Offset = "0x8276E80", VA = "0x188277A80")]
		public static bool OGMAAAEFFPP(SerializedCustomAvatarItemId KGCKEJLFPJB, SerializedCustomAvatarItemId HKELKGIPNGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8277AA0", Offset = "0x8276EA0", VA = "0x188277AA0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8277BB0", Offset = "0x8276FB0", VA = "0x188277BB0")]
		public static SerializedEquipmentSkinId IFKDBMKJNLP()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540")]
		public HHJMMHNPOOC HFAEDKNMEEN()
		{
			return default(HHJMMHNPOOC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8277B10", Offset = "0x8276F10", VA = "0x188277B10", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8277BE0", Offset = "0x8276FE0", VA = "0x188277BE0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540")]
		public IAPKGHKBDIJ HFAEDKNMEEN()
		{
			return default(IAPKGHKBDIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8277C50", Offset = "0x8277050", VA = "0x188277C50", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8277CF0", Offset = "0x82770F0", VA = "0x188277CF0", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540")]
		public BBKFOPKBGOL HFAEDKNMEEN()
		{
			return default(BBKFOPKBGOL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600", Slot = "4")]
		public bool Equals(SerializedFaceShapeId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8277D60", Offset = "0x8277160", VA = "0x188277D60", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8277E00", Offset = "0x8277200", VA = "0x188277E00", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540")]
		public PKEDJEKJOIK HFAEDKNMEEN()
		{
			return default(PKEDJEKJOIK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600", Slot = "4")]
		public bool Equals(SerializedHairPatternId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedHairPatternId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8277E70", Offset = "0x8277270", VA = "0x188277E70", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8277600", Offset = "0x8276A00", VA = "0x188277600")]
		public static bool PEOCKCCHEIN(SerializedHairPatternId KGCKEJLFPJB, SerializedHairPatternId HKELKGIPNGP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8277F10", Offset = "0x8277310", VA = "0x188277F10", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x1109540", Offset = "0x1108940", VA = "0x181109540", Slot = "6")]
		public Guid BCKHHONMOOC()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x81048A0", Offset = "0x8103CA0", VA = "0x1881048A0", Slot = "4")]
		public bool Equals(SerializedMaterialId KNCKFHOKGJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8277F80", Offset = "0x8277380", VA = "0x188277F80", Slot = "0")]
		public override bool Equals(object BLFGIKOAKOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77561C0", Offset = "0x77555C0", VA = "0x1877561C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7756030", Offset = "0x7755430", VA = "0x187756030", Slot = "5")]
		public int CompareTo(SerializedMaterialId KNCKFHOKGJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x8278020", Offset = "0x8277420", VA = "0x188278020", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x8265020", Offset = "0x8264420", VA = "0x188265020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public CHOCLPPHKEE<LALAGECKOGA> EKPHPKKEOED
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8264F00", Offset = "0x8264300", VA = "0x188264F00", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CHOCLPPHKEE<HHJMMHNPOOC> CMJIIHMHPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8264FC0", Offset = "0x82643C0", VA = "0x188264FC0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CHOCLPPHKEE<PKEDJEKJOIK> LDMBFFJFKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x82650E0", Offset = "0x82644E0", VA = "0x1882650E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public CHOCLPPHKEE<PECGMKADMMG> JAAAIEDMJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8264EA0", Offset = "0x82642A0", VA = "0x188264EA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public CHOCLPPHKEE<MDKOOLPNNLA> OLHEHPEENIP
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8264F60", Offset = "0x8264360", VA = "0x188264F60", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public CHOCLPPHKEE<BBKFOPKBGOL> EPLPMJMFJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8265140", Offset = "0x8264540", VA = "0x188265140", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public CHOCLPPHKEE<AOAHCJAKMBM> COKGNPANNAI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8264E40", Offset = "0x8264240", VA = "0x188264E40", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public CHOCLPPHKEE<IAPKGHKBDIJ> EEMKDHJIAPI
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8265080", Offset = "0x8264480", VA = "0x188265080", Slot = "11")]
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
	[Cpp2IlInjected.Address(RVA = "0x8275700", Offset = "0x8274B00", VA = "0x188275700")]
	public static Guid BPFOKCDGIGC(string HNHKIDAKLJF)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x82757B0", Offset = "0x8274BB0", VA = "0x1882757B0")]
	public static bool DCNABFJEJOP(string HNHKIDAKLJF, [Out] Guid KDBHLLEACIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GEGIBNJFLHP : BMAOANLOBOM<LALAGECKOGA>, IMDHMAINHLG<LALAGECKOGA>
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x8266DE0", Offset = "0x82661E0", VA = "0x188266DE0", Slot = "4")]
	public IEnumerable<(LALAGECKOGA, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8266DC0", Offset = "0x82661C0", VA = "0x188266DC0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x82651A0", Offset = "0x82645A0", VA = "0x1882651A0", Slot = "6")]
	public LALAGECKOGA AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(LALAGECKOGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public GEGIBNJFLHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class FEGBPGLOEEN : BMAOANLOBOM<AOAHCJAKMBM>, IMDHMAINHLG<AOAHCJAKMBM>
{
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x8266A20", Offset = "0x8265E20", VA = "0x188266A20", Slot = "4")]
	public IEnumerable<(AOAHCJAKMBM, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xD5ECF0", Offset = "0xD5E0F0", VA = "0x180D5ECF0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x82651A0", Offset = "0x82645A0", VA = "0x1882651A0", Slot = "6")]
	public AOAHCJAKMBM AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(AOAHCJAKMBM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public FEGBPGLOEEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class KAEGMLGNCAD : BMAOANLOBOM<MDKOOLPNNLA>, IMDHMAINHLG<MDKOOLPNNLA>
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x826BA30", Offset = "0x826AE30", VA = "0x18826BA30", Slot = "4")]
	public IEnumerable<(MDKOOLPNNLA, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0xD5ECF0", Offset = "0xD5E0F0", VA = "0x180D5ECF0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x82651A0", Offset = "0x82645A0", VA = "0x1882651A0", Slot = "6")]
	public MDKOOLPNNLA AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(MDKOOLPNNLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x9B2970", Offset = "0x9B1D70", VA = "0x1809B2970")]
	public DFOFNECFFLG(IMDHMAINHLG<PBNOFEILNDB> GKGHFHJJNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8104A80", Offset = "0x8103E80", VA = "0x188104A80", Slot = "4")]
	public IEnumerable<(PECGMKADMMG, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x8265260", Offset = "0x8264660", VA = "0x188265260", Slot = "6")]
	public PECGMKADMMG AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(PECGMKADMMG);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x82654A0", Offset = "0x82648A0", VA = "0x1882654A0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KGJGHFJJJBG : BMAOANLOBOM<HHJMMHNPOOC>, IMDHMAINHLG<HHJMMHNPOOC>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x826DAF0", Offset = "0x826CEF0", VA = "0x18826DAF0", Slot = "4")]
	public IEnumerable<(HHJMMHNPOOC, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0xD5ECF0", Offset = "0xD5E0F0", VA = "0x180D5ECF0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x82651A0", Offset = "0x82645A0", VA = "0x1882651A0", Slot = "6")]
	public HHJMMHNPOOC AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(HHJMMHNPOOC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public KGJGHFJJJBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KNPJMBCGEAI : BMAOANLOBOM<IAPKGHKBDIJ>, IMDHMAINHLG<IAPKGHKBDIJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x8275880", Offset = "0x8274C80", VA = "0x188275880", Slot = "4")]
	public IEnumerable<(IAPKGHKBDIJ, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xD5ECF0", Offset = "0xD5E0F0", VA = "0x180D5ECF0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x82651A0", Offset = "0x82645A0", VA = "0x1882651A0", Slot = "6")]
	public IAPKGHKBDIJ AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(IAPKGHKBDIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public KNPJMBCGEAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OFHLLKEAPMP : BMAOANLOBOM<BBKFOPKBGOL>, IMDHMAINHLG<BBKFOPKBGOL>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x8277140", Offset = "0x8276540", VA = "0x188277140", Slot = "4")]
	public IEnumerable<(BBKFOPKBGOL, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0xD5ECF0", Offset = "0xD5E0F0", VA = "0x180D5ECF0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x82651A0", Offset = "0x82645A0", VA = "0x1882651A0", Slot = "6")]
	public BBKFOPKBGOL AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(BBKFOPKBGOL);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
	public OFHLLKEAPMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class DKCOMHKAPFI : BMAOANLOBOM<PKEDJEKJOIK>, IMDHMAINHLG<PKEDJEKJOIK>
{
	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x82654E0", Offset = "0x82648E0", VA = "0x1882654E0", Slot = "4")]
	public IEnumerable<(PKEDJEKJOIK, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0xD5ECF0", Offset = "0xD5E0F0", VA = "0x180D5ECF0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x82651A0", Offset = "0x82645A0", VA = "0x1882651A0", Slot = "6")]
	public PKEDJEKJOIK AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(PKEDJEKJOIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x81B9BA0", Offset = "0x81B8FA0", VA = "0x1881B9BA0", Slot = "4")]
	public IEnumerable<(PBNOFEILNDB, string)> BMADEEOLAAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0xD5ECF0", Offset = "0xD5E0F0", VA = "0x180D5ECF0", Slot = "5")]
	public string ALHCPFGPADE(string FEHKMADEKDH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x82651A0", Offset = "0x82645A0", VA = "0x1882651A0", Slot = "6")]
	public PBNOFEILNDB AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return default(PBNOFEILNDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x9B8350", Offset = "0x9B7750", VA = "0x1809B8350")]
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
	[Cpp2IlInjected.Address(RVA = "0x510D6C0", Offset = "0x510CAC0", VA = "0x18510D6C0")]
	public NOHAFLFJGAA(BMAOANLOBOM<TModern> BMFFBLNHJGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x510A7E0", Offset = "0x5109BE0", VA = "0x18510A7E0", Slot = "5")]
	public TModern AHLBDDIHAJI(string FEHKMADEKDH)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x510B7A0", Offset = "0x510ABA0", VA = "0x18510B7A0", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AA3B0", Offset = "0x9A97B0", VA = "0x1809AA3B0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public CHOCLPPHKEE<HHJMMHNPOOC> CMJIIHMHPGG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public CHOCLPPHKEE<PKEDJEKJOIK> LDMBFFJFKPL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9A91D0", Offset = "0x9A85D0", VA = "0x1809A91D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public CHOCLPPHKEE<PECGMKADMMG> JAAAIEDMJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public CHOCLPPHKEE<MDKOOLPNNLA> OLHEHPEENIP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9AA3C0", Offset = "0x9A97C0", VA = "0x1809AA3C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public CHOCLPPHKEE<BBKFOPKBGOL> EPLPMJMFJJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9AA330", Offset = "0x9A9730", VA = "0x1809AA330", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public CHOCLPPHKEE<AOAHCJAKMBM> COKGNPANNAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9AA390", Offset = "0x9A9790", VA = "0x1809AA390", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public CHOCLPPHKEE<IAPKGHKBDIJ> EEMKDHJIAPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9A9A60", Offset = "0x9A8E60", VA = "0x1809A9A60", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x8265B60", Offset = "0x8264F60", VA = "0x188265B60")]
	[NOCPMGCIOME.CBODKAAMPCM.HHBOMGFEMJK]
	[UsedImplicitly]
	internal static void OPNOJEPKKPP(DHLGDCALOEP EOJAEMANAOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8265BD0", Offset = "0x8264FD0", VA = "0x188265BD0")]
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
