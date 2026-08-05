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
		[Cpp2IlInjected.Address(RVA = "0x868DF10", Offset = "0x868D110", VA = "0x18868DF10", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x274B560", Offset = "0x274A760", VA = "0x18274B560")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public class EFAGJPCJCMG : CFNDNEHKGBA
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private static readonly Regex LOGDBHLOCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly AOEMIOEJPMI BBINOBLDFML;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x867BD90", Offset = "0x867AF90", VA = "0x18867BD90")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	[UsedImplicitly]
	internal static void CNMFKDBOHKK(FJCFOKJAKFO CBAPLOOHOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x867C140", Offset = "0x867B340", VA = "0x18867C140")]
	[UsedImplicitly]
	internal static void ENJODGOCPHL(FJCFOKJAKFO CBAPLOOHOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	[RecRoom.NoEngine.Common.Preserve]
	public EFAGJPCJCMG([NGLIAOPBMFM(null)] AOEMIOEJPMI BBINOBLDFML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x867BE00", Offset = "0x867B000", VA = "0x18867BE00", Slot = "4")]
	public string ELKKKBEIKKA(GHAADPGGCEA GLMNBNPBGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x867B8C0", Offset = "0x867AAC0", VA = "0x18867B8C0", Slot = "5")]
	public GHAADPGGCEA BHIBMPPAILM(string GLMNBNPBGCG)
	{
		return default(GHAADPGGCEA);
	}
}
namespace RecRoom.AssetIds
{
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public struct SerializedAvatarItemId : IEquatable<SerializedAvatarItemId>, IComparable<SerializedAvatarItemId>, DAGBLJJIGGP
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
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public OEOKECIEANE BHIBMPPAILM()
		{
			return default(OEOKECIEANE);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410", Slot = "4")]
		public bool Equals(SerializedAvatarItemId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedAvatarItemId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x868D370", Offset = "0x868C570", VA = "0x18868D370", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x868D430", Offset = "0x868C630", VA = "0x18868D430", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct SerializedBodyShapeId : IEquatable<SerializedBodyShapeId>, IComparable<SerializedBodyShapeId>, DAGBLJJIGGP
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
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public OJOJMJHDBPN BHIBMPPAILM()
		{
			return default(OJOJMJHDBPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410", Slot = "4")]
		public bool Equals(SerializedBodyShapeId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedBodyShapeId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x868D4A0", Offset = "0x868C6A0", VA = "0x18868D4A0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x868D540", Offset = "0x868C740", VA = "0x18868D540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct SerializedColorId : IEquatable<SerializedColorId>, IComparable<SerializedColorId>, DAGBLJJIGGP
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
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public HKNPJKNHOAH BHIBMPPAILM()
		{
			return default(HKNPJKNHOAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410", Slot = "4")]
		public bool Equals(SerializedColorId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedColorId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x868D5B0", Offset = "0x868C7B0", VA = "0x18868D5B0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x868D650", Offset = "0x868C850", VA = "0x18868D650", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct SerializedCombinationId : IEquatable<SerializedCombinationId>, IComparable<SerializedCombinationId>, DAGBLJJIGGP, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Guid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		[SerializeField]
		private SerializedMaterialId materialId0;

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xD9D5F0", Offset = "0xD9C7F0", VA = "0x180D9D5F0")]
		public BEJJMAFOJDH BHIBMPPAILM()
		{
			return default(BEJJMAFOJDH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8518E80", Offset = "0x8518080", VA = "0x188518E80", Slot = "4")]
		public bool Equals(SerializedCombinationId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x868D6C0", Offset = "0x868C8C0", VA = "0x18868D6C0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedCombinationId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x868D780", Offset = "0x868C980", VA = "0x18868D780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA02C60", Offset = "0xA01E60", VA = "0x180A02C60", Slot = "7")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x868D770", Offset = "0x868C970", VA = "0x18868D770", Slot = "8")]
		public void OnAfterDeserialize()
		{
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct SerializedCustomAvatarItemId : IEquatable<SerializedCustomAvatarItemId>, IComparable<SerializedCustomAvatarItemId>, DAGBLJJIGGP
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

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool IsEmpty
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x868D920", Offset = "0x868CB20", VA = "0x18868D920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x13066A0", Offset = "0x13058A0", VA = "0x1813066A0")]
		public SerializedCustomAvatarItemId(Guid DJOIAEMCFDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public static SerializedCustomAvatarItemId AEIGGNOOJAG(Guid DJOIAEMCFDK)
		{
			return default(SerializedCustomAvatarItemId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410", Slot = "4")]
		public bool Equals(SerializedCustomAvatarItemId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedCustomAvatarItemId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x868D7F0", Offset = "0x868C9F0", VA = "0x18868D7F0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410")]
		public static bool EEDHALGLIEL(SerializedCustomAvatarItemId KEAFHNNEEAN, SerializedCustomAvatarItemId FNKKBNJEBAC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x868D890", Offset = "0x868CA90", VA = "0x18868D890")]
		public static bool JGFOFPDALHN(SerializedCustomAvatarItemId KEAFHNNEEAN, SerializedCustomAvatarItemId FNKKBNJEBAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x868D8B0", Offset = "0x868CAB0", VA = "0x18868D8B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct SerializedEquipmentSkinId : IEquatable<SerializedEquipmentSkinId>, IComparable<SerializedEquipmentSkinId>, DAGBLJJIGGP
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

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x868D980", Offset = "0x868CB80", VA = "0x18868D980")]
		public static SerializedEquipmentSkinId CDHAMFDBGPM()
		{
			return default(SerializedEquipmentSkinId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public PGGHHLMNFIJ BHIBMPPAILM()
		{
			return default(PGGHHLMNFIJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410", Slot = "4")]
		public bool Equals(SerializedEquipmentSkinId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x868D9B0", Offset = "0x868CBB0", VA = "0x18868D9B0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedEquipmentSkinId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x868DA50", Offset = "0x868CC50", VA = "0x18868DA50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct SerializedFaceFeatureId : IEquatable<SerializedFaceFeatureId>, IComparable<SerializedFaceFeatureId>, DAGBLJJIGGP
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

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public JCDBDFLIABB BHIBMPPAILM()
		{
			return default(JCDBDFLIABB);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410", Slot = "4")]
		public bool Equals(SerializedFaceFeatureId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedFaceFeatureId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x868DAC0", Offset = "0x868CCC0", VA = "0x18868DAC0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x868DB60", Offset = "0x868CD60", VA = "0x18868DB60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct SerializedFaceShapeId : IEquatable<SerializedFaceShapeId>, IComparable<SerializedFaceShapeId>, DAGBLJJIGGP
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

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public CNFNKEGPECP BHIBMPPAILM()
		{
			return default(CNFNKEGPECP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410", Slot = "4")]
		public bool Equals(SerializedFaceShapeId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedFaceShapeId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x868DBD0", Offset = "0x868CDD0", VA = "0x18868DBD0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x868DC70", Offset = "0x868CE70", VA = "0x18868DC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SerializedHairPatternId : IEquatable<SerializedHairPatternId>, IComparable<SerializedHairPatternId>, DAGBLJJIGGP
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

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0")]
		public OLEIELPNAGH BHIBMPPAILM()
		{
			return default(OLEIELPNAGH);
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410", Slot = "4")]
		public bool Equals(SerializedHairPatternId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedHairPatternId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x868DCE0", Offset = "0x868CEE0", VA = "0x18868DCE0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x868D410", Offset = "0x868C610", VA = "0x18868D410")]
		public static bool EEDHALGLIEL(SerializedHairPatternId KEAFHNNEEAN, SerializedHairPatternId FNKKBNJEBAC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x868DD80", Offset = "0x868CF80", VA = "0x18868DD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct SerializedMaterialId : IEquatable<SerializedMaterialId>, IComparable<SerializedMaterialId>, DAGBLJJIGGP
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

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1102FD0", Offset = "0x11021D0", VA = "0x181102FD0", Slot = "6")]
		public Guid BJECEMDGOJE()
		{
			return default(Guid);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x8518E80", Offset = "0x8518080", VA = "0x188518E80", Slot = "4")]
		public bool Equals(SerializedMaterialId CMOCFNBHPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x868DDF0", Offset = "0x868CFF0", VA = "0x18868DDF0", Slot = "0")]
		public override bool Equals(object KFMNDOMPAMC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7AD5170", Offset = "0x7AD4370", VA = "0x187AD5170", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7AD4FE0", Offset = "0x7AD41E0", VA = "0x187AD4FE0", Slot = "5")]
		public int CompareTo(SerializedMaterialId CMOCFNBHPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x868DEA0", Offset = "0x868D0A0", VA = "0x18868DEA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class MKFHDLLJBDI : AOEMIOEJPMI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static MKFHDLLJBDI AIBLJDBPKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8686590", Offset = "0x8685790", VA = "0x188686590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public BPMBCBHNICN<OEOKECIEANE> FIDKHJJIOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x8686830", Offset = "0x8685A30", VA = "0x188686830", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public BPMBCBHNICN<PGGHHLMNFIJ> CFFOBKOLDKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8686710", Offset = "0x8685910", VA = "0x188686710", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public BPMBCBHNICN<OLEIELPNAGH> CDLJMHFBMLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x86867D0", Offset = "0x86859D0", VA = "0x1886867D0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public BPMBCBHNICN<BEJJMAFOJDH> CPFLDPAIACH
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x86866B0", Offset = "0x86858B0", VA = "0x1886866B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public BPMBCBHNICN<HKNPJKNHOAH> MLMDHLJDOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8686650", Offset = "0x8685850", VA = "0x188686650", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public BPMBCBHNICN<CNFNKEGPECP> NBCELIJLKPC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8686890", Offset = "0x8685A90", VA = "0x188686890", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public BPMBCBHNICN<OJOJMJHDBPN> DGLEFNMPNON
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8686770", Offset = "0x8685970", VA = "0x188686770", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public BPMBCBHNICN<JCDBDFLIABB> NMIAIMJJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x86865F0", Offset = "0x86857F0", VA = "0x1886865F0", Slot = "11")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class BELIMBMOBBB
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x867B120", Offset = "0x867A320", VA = "0x18867B120")]
	public static Guid FIFNFOKHOGD(string DFMIHOALFBL)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x867B1D0", Offset = "0x867A3D0", VA = "0x18867B1D0")]
	public static bool NIGDKDDNNEC(string DFMIHOALFBL, [Out] Guid DJOIAEMCFDK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ONFIFFOLNIK : BJFOEEGMBMI<OEOKECIEANE>, CMGILKNKJCI<OEOKECIEANE>
{
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x8688720", Offset = "0x8687920", VA = "0x188688720", Slot = "4")]
	public IEnumerable<(OEOKECIEANE, string)> HFMEJAMLCFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x8688700", Offset = "0x8687900", VA = "0x188688700", Slot = "5")]
	public string GONDJDMLCAF(string GDCLABHLNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x867AC40", Offset = "0x8679E40", VA = "0x18867AC40", Slot = "6")]
	public OEOKECIEANE EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return default(OEOKECIEANE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public ONFIFFOLNIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class EENENNDPINH : BJFOEEGMBMI<OJOJMJHDBPN>, CMGILKNKJCI<OJOJMJHDBPN>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x867B520", Offset = "0x867A720", VA = "0x18867B520", Slot = "4")]
	public IEnumerable<(OJOJMJHDBPN, string)> HFMEJAMLCFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xA7D9B0", Offset = "0xA7CBB0", VA = "0x180A7D9B0", Slot = "5")]
	public string GONDJDMLCAF(string GDCLABHLNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x867AC40", Offset = "0x8679E40", VA = "0x18867AC40", Slot = "6")]
	public OJOJMJHDBPN EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return default(OJOJMJHDBPN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public EENENNDPINH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class GNANJENMDBG : BJFOEEGMBMI<HKNPJKNHOAH>, CMGILKNKJCI<HKNPJKNHOAH>
{
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x867C8C0", Offset = "0x867BAC0", VA = "0x18867C8C0", Slot = "4")]
	public IEnumerable<(HKNPJKNHOAH, string)> HFMEJAMLCFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0xA7D9B0", Offset = "0xA7CBB0", VA = "0x180A7D9B0", Slot = "5")]
	public string GONDJDMLCAF(string GDCLABHLNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x867AC40", Offset = "0x8679E40", VA = "0x18867AC40", Slot = "6")]
	public HKNPJKNHOAH EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return default(HKNPJKNHOAH);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public GNANJENMDBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EBONEOGAALC : BJFOEEGMBMI<BEJJMAFOJDH>, CMGILKNKJCI<BEJJMAFOJDH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly CMGILKNKJCI<MMELFCDMHLE> OEMDMDPAEDA;

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0xA0F6B0", Offset = "0xA0E8B0", VA = "0x180A0F6B0")]
	public EBONEOGAALC(CMGILKNKJCI<MMELFCDMHLE> OEMDMDPAEDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x851A880", Offset = "0x8519A80", VA = "0x18851A880", Slot = "4")]
	public IEnumerable<(BEJJMAFOJDH, string)> HFMEJAMLCFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x867B2A0", Offset = "0x867A4A0", VA = "0x18867B2A0", Slot = "6")]
	public BEJJMAFOJDH EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return default(BEJJMAFOJDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x867B4E0", Offset = "0x867A6E0", VA = "0x18867B4E0", Slot = "5")]
	public string GONDJDMLCAF(string GDCLABHLNIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class KPKMIFICBJB : BJFOEEGMBMI<PGGHHLMNFIJ>, CMGILKNKJCI<PGGHHLMNFIJ>
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x867E980", Offset = "0x867DB80", VA = "0x18867E980", Slot = "4")]
	public IEnumerable<(PGGHHLMNFIJ, string)> HFMEJAMLCFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0xA7D9B0", Offset = "0xA7CBB0", VA = "0x180A7D9B0", Slot = "5")]
	public string GONDJDMLCAF(string GDCLABHLNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x867AC40", Offset = "0x8679E40", VA = "0x18867AC40", Slot = "6")]
	public PGGHHLMNFIJ EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return default(PGGHHLMNFIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public KPKMIFICBJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class OEPEKGABHLO : BJFOEEGMBMI<JCDBDFLIABB>, CMGILKNKJCI<JCDBDFLIABB>
{
	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x8686E40", Offset = "0x8686040", VA = "0x188686E40", Slot = "4")]
	public IEnumerable<(JCDBDFLIABB, string)> HFMEJAMLCFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xA7D9B0", Offset = "0xA7CBB0", VA = "0x180A7D9B0", Slot = "5")]
	public string GONDJDMLCAF(string GDCLABHLNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x867AC40", Offset = "0x8679E40", VA = "0x18867AC40", Slot = "6")]
	public JCDBDFLIABB EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return default(JCDBDFLIABB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public OEPEKGABHLO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AFLKHFICBDF : BJFOEEGMBMI<CNFNKEGPECP>, CMGILKNKJCI<CNFNKEGPECP>
{
	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x867AD00", Offset = "0x8679F00", VA = "0x18867AD00", Slot = "4")]
	public IEnumerable<(CNFNKEGPECP, string)> HFMEJAMLCFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0xA7D9B0", Offset = "0xA7CBB0", VA = "0x180A7D9B0", Slot = "5")]
	public string GONDJDMLCAF(string GDCLABHLNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x867AC40", Offset = "0x8679E40", VA = "0x18867AC40", Slot = "6")]
	public CNFNKEGPECP EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return default(CNFNKEGPECP);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public AFLKHFICBDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class EKOHPJGOLGG : BJFOEEGMBMI<OLEIELPNAGH>, CMGILKNKJCI<OLEIELPNAGH>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x867C240", Offset = "0x867B440", VA = "0x18867C240", Slot = "4")]
	public IEnumerable<(OLEIELPNAGH, string)> HFMEJAMLCFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0xA7D9B0", Offset = "0xA7CBB0", VA = "0x180A7D9B0", Slot = "5")]
	public string GONDJDMLCAF(string GDCLABHLNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x867AC40", Offset = "0x8679E40", VA = "0x18867AC40", Slot = "6")]
	public OLEIELPNAGH EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return default(OLEIELPNAGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public EKOHPJGOLGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface BJFOEEGMBMI<TModern> : CMGILKNKJCI<TModern>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<(TModern, string)> HFMEJAMLCFG();

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(Slot = "1")]
	string GONDJDMLCAF(string GDCLABHLNIK);
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class HFIIEHGMOOP : BJFOEEGMBMI<MMELFCDMHLE>, CMGILKNKJCI<MMELFCDMHLE>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x85CF9A0", Offset = "0x85CEBA0", VA = "0x1885CF9A0", Slot = "4")]
	public IEnumerable<(MMELFCDMHLE, string)> HFMEJAMLCFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0xA7D9B0", Offset = "0xA7CBB0", VA = "0x180A7D9B0", Slot = "5")]
	public string GONDJDMLCAF(string GDCLABHLNIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x867AC40", Offset = "0x8679E40", VA = "0x18867AC40", Slot = "6")]
	public MMELFCDMHLE EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return default(MMELFCDMHLE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0xA07160", Offset = "0xA06360", VA = "0x180A07160")]
	public HFIIEHGMOOP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class EGIJDIKNOEP<TModern> : BPMBCBHNICN<TModern>, CMGILKNKJCI<TModern> where TModern : IEquatable<TModern>, DAGBLJJIGGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly Dictionary<TModern, string> GMDEONCBHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly Dictionary<string, TModern> LGFJPPHMINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly BJFOEEGMBMI<TModern> OGOADPEMNJG;

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4678600", Offset = "0x4677800", VA = "0x184678600")]
	public EGIJDIKNOEP(BJFOEEGMBMI<TModern> OGOADPEMNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4677080", Offset = "0x4676280", VA = "0x184677080", Slot = "5")]
	public TModern EFMFJMDCHHI(string GDCLABHLNIK)
	{
		return (TModern)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4676200", Offset = "0x4675400", VA = "0x184676200", Slot = "4")]
	public string BLEJNCFPODI(TModern HLHIJMEFGCE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NKBENHONAHI : AOEMIOEJPMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private EGIJDIKNOEP<OEOKECIEANE> MPJFODBNMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private EGIJDIKNOEP<PGGHHLMNFIJ> CCHDLIGOMLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private EGIJDIKNOEP<OLEIELPNAGH> JCFHEKCNNFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private EGIJDIKNOEP<MMELFCDMHLE> OEMDMDPAEDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private EGIJDIKNOEP<BEJJMAFOJDH> FFPPFJMDEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private EGIJDIKNOEP<HKNPJKNHOAH> ELEPDMNKCCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private EGIJDIKNOEP<CNFNKEGPECP> OMFLOACMGNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private EGIJDIKNOEP<OJOJMJHDBPN> JMGNJDGFNNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private EGIJDIKNOEP<JCDBDFLIABB> LKKIPBLHDJP;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public BPMBCBHNICN<OEOKECIEANE> FIDKHJJIOKB
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA011A0", Offset = "0xA003A0", VA = "0x180A011A0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public BPMBCBHNICN<PGGHHLMNFIJ> CFFOBKOLDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public BPMBCBHNICN<OLEIELPNAGH> CDLJMHFBMLA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA00FB0", Offset = "0xA001B0", VA = "0x180A00FB0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public BPMBCBHNICN<BEJJMAFOJDH> CPFLDPAIACH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA09ED0", Offset = "0xA090D0", VA = "0x180A09ED0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public BPMBCBHNICN<HKNPJKNHOAH> MLMDHLJDOAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xA00F50", Offset = "0xA00150", VA = "0x180A00F50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BPMBCBHNICN<CNFNKEGPECP> NBCELIJLKPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0xA00F70", Offset = "0xA00170", VA = "0x180A00F70", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public BPMBCBHNICN<OJOJMJHDBPN> DGLEFNMPNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xA0D650", Offset = "0xA0C850", VA = "0x180A0D650", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BPMBCBHNICN<JCDBDFLIABB> NMIAIMJJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xA00360", Offset = "0x9FF560", VA = "0x180A00360", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x86868F0", Offset = "0x8685AF0", VA = "0x1886868F0")]
	[MGCKGAIBEHC.PCMIGKEOIEO.MAPPJIPMPIK]
	[UsedImplicitly]
	internal static void JEGDMFJDHHB(FJCFOKJAKFO CBAPLOOHOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x8686960", Offset = "0x8685B60", VA = "0x188686960")]
	[RecRoom.NoEngine.Common.Preserve]
	public NKBENHONAHI()
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
