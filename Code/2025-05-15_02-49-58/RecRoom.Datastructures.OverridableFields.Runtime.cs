using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Cpp2IlInjected;
using Google.Protobuf;
using JetBrains.Annotations;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface EPDOKFNDCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NGAKDLHJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object MMGBJDNAHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EANDHCGMJHJ<T> : EPDOKFNDCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EFBKEHKDBDN<T> : EANDHCGMJHJ<T>, EPDOKFNDCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool NGAKDLHJJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface FLBAEONACII<T> : EFBKEHKDBDN<T>, EANDHCGMJHJ<T>, EPDOKFNDCNI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool MPMGFOLMENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Utils.OverridableFields
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct OverridableInt : EANDHCGMJHJ<int>, EPDOKFNDCNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private int value;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xF3E440", Offset = "0xF3CA40", VA = "0x180F3E440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7BF4820", Offset = "0x7BF2E20", VA = "0x187BF4820", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2DE0910", Offset = "0x2DDEF10", VA = "0x182DE0910", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4780", Offset = "0x7BF2D80", VA = "0x187BF4780", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : EANDHCGMJHJ<string>, EPDOKFNDCNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private string value;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xF3E440", Offset = "0xF3CA40", VA = "0x180F3E440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD8F1E0", Offset = "0xD8D7E0", VA = "0x180D8F1E0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4870", Offset = "0x7BF2E70", VA = "0x187BF4870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : EFBKEHKDBDN<InnerType>, EANDHCGMJHJ<InnerType>, EPDOKFNDCNI where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool NGAKDLHJJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType FPGFCMMHMJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object MMGBJDNAHJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x297CC40", Offset = "0x297B240", VA = "0x18297CC40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x53CA940", Offset = "0x53C8F40", VA = "0x1853CA940")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x53CA970", Offset = "0x53C8F70", VA = "0x1853CA970")]
		public MutableOverridableBase(bool NIJJCCHEIAO, [NotNull] InnerType OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x53CA2B0", Offset = "0x53C88B0", VA = "0x1853CA2B0", Slot = "15")]
		public void DBLOBBIGBLO(EANDHCGMJHJ<InnerType> IACIPAIGMFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x53CA730", Offset = "0x53C8D30", VA = "0x1853CA730", Slot = "16")]
		public void JDEFNGBGNOL(EANDHCGMJHJ<InnerType> MIJLJBIHDMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53CA7F0", Offset = "0x53C8DF0", VA = "0x1853CA7F0", Slot = "17")]
		public virtual void KGPJOLOPJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType IGIDBGLAKOE();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void OIDJBDMCBBO(ProtobufType OMEHHNGIHKJ);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void PDGFGGDNCCA(byte[] ONCKKNNNHJP);
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public abstract class SerializedMutableOverridableBase<T, InnerType, ProtobufType> : MutableOverridableBase<T, InnerType, ProtobufType> where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private InnerType value;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public override bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC8F7E0", Offset = "0xC8DDE0", VA = "0x180C8F7E0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC8F720", Offset = "0xC8DD20", VA = "0x180C8F720", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDCC450", Offset = "0xDCAA50", VA = "0x180DCC450", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x44C62B0", Offset = "0x44C48B0", VA = "0x1844C62B0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4AC6EB0", Offset = "0x4AC54B0", VA = "0x184AC6EB0")]
		public SerializedMutableOverridableBase(bool NIJJCCHEIAO, InnerType OHLIHBDBKCE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, ECOGCNGIKKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7BF46B0", Offset = "0x7BF2CB0", VA = "0x187BF46B0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4710", Offset = "0x7BF2D10", VA = "0x187BF4710")]
		public MutableOverridableObscuredInt(bool NIJJCCHEIAO, ObscuredInt OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7BF45E0", Offset = "0x7BF2BE0", VA = "0x187BF45E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4510", Offset = "0x7BF2B10", VA = "0x187BF4510", Slot = "20")]
		public override void PDGFGGDNCCA(byte[] ONCKKNNNHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4460", Offset = "0x7BF2A60", VA = "0x187BF4460", Slot = "19")]
		public override void OIDJBDMCBBO(ECOGCNGIKKJ OMEHHNGIHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4380", Offset = "0x7BF2980", VA = "0x187BF4380", Slot = "18")]
		public override ECOGCNGIKKJ IGIDBGLAKOE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, EJDGIJBLCBE>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF42B0", Offset = "0x7BF28B0", VA = "0x187BF42B0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4310", Offset = "0x7BF2910", VA = "0x187BF4310")]
		public MutableOverridableObscuredFloat(bool NIJJCCHEIAO, ObscuredFloat OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF41E0", Offset = "0x7BF27E0", VA = "0x187BF41E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4110", Offset = "0x7BF2710", VA = "0x187BF4110", Slot = "20")]
		public override void PDGFGGDNCCA(byte[] ONCKKNNNHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4050", Offset = "0x7BF2650", VA = "0x187BF4050", Slot = "19")]
		public override void OIDJBDMCBBO(EJDGIJBLCBE OMEHHNGIHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3F60", Offset = "0x7BF2560", VA = "0x187BF3F60", Slot = "18")]
		public override EJDGIJBLCBE IGIDBGLAKOE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, LAHFPFBLEBD>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3180", Offset = "0x7BF1780", VA = "0x187BF3180")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3EF0", Offset = "0x7BF24F0", VA = "0x187BF3EF0")]
		public MutableOverridableObscuredBool(bool NIJJCCHEIAO, ObscuredBool OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3E20", Offset = "0x7BF2420", VA = "0x187BF3E20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3D50", Offset = "0x7BF2350", VA = "0x187BF3D50", Slot = "20")]
		public override void PDGFGGDNCCA(byte[] ONCKKNNNHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3C00", Offset = "0x7BF2200", VA = "0x187BF3C00", Slot = "19")]
		public override void OIDJBDMCBBO(LAHFPFBLEBD OMEHHNGIHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3B10", Offset = "0x7BF2110", VA = "0x187BF3B10", Slot = "18")]
		public override LAHFPFBLEBD IGIDBGLAKOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3CC0", Offset = "0x7BF22C0", VA = "0x187BF3CC0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, FLBAEONACII<ObscuredBool>, EFBKEHKDBDN<ObscuredBool>, EANDHCGMJHJ<ObscuredBool>, EPDOKFNDCNI
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9EB560", Offset = "0x9E9B60", VA = "0x1809EB560", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9EB530", Offset = "0x9E9B30", VA = "0x1809EB530", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3180", Offset = "0x7BF1780", VA = "0x187BF3180")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3100", Offset = "0x7BF1700", VA = "0x187BF3100")]
		public void DBLOBBIGBLO(MutableOverridableDefaultableObscuredBool MIJLJBIHDMP)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, ECOGCNGIKKJ> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x58473F0", Offset = "0x58459F0", VA = "0x1858473F0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5847570", Offset = "0x5845B70", VA = "0x185847570", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4520960", Offset = "0x451EF60", VA = "0x184520960")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x58473B0", Offset = "0x58459B0", VA = "0x1858473B0")]
		public SerializedMutableOverridableObscuredEnum(bool NIJJCCHEIAO, TObsEnum OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5847060", Offset = "0x5845660", VA = "0x185847060", Slot = "18")]
		public sealed override ECOGCNGIKKJ IGIDBGLAKOE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x58471D0", Offset = "0x58457D0", VA = "0x1858471D0", Slot = "19")]
		public sealed override void OIDJBDMCBBO(ECOGCNGIKKJ OMEHHNGIHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x58472D0", Offset = "0x58458D0", VA = "0x1858472D0", Slot = "20")]
		public sealed override void PDGFGGDNCCA(byte[] ONCKKNNNHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5847150", Offset = "0x5845750", VA = "0x185847150", Slot = "17")]
		public sealed override void KGPJOLOPJJK()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, LDEGCAJGKBA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7BF3A40", Offset = "0x7BF2040", VA = "0x187BF3A40", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7BF3A80", Offset = "0x7BF2080", VA = "0x187BF3A80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7BF39A0", Offset = "0x7BF1FA0", VA = "0x187BF39A0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3940", Offset = "0x7BF1F40", VA = "0x187BF3940")]
		public MutableOverridableListObscuredString(bool NIJJCCHEIAO, List<ObscuredString> OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7BF38A0", Offset = "0x7BF1EA0", VA = "0x187BF38A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7BF33D0", Offset = "0x7BF19D0", VA = "0x187BF33D0", Slot = "17")]
		public override void KGPJOLOPJJK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF37D0", Offset = "0x7BF1DD0", VA = "0x187BF37D0", Slot = "20")]
		public override void PDGFGGDNCCA(byte[] ONCKKNNNHJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3460", Offset = "0x7BF1A60", VA = "0x187BF3460", Slot = "19")]
		public override void OIDJBDMCBBO(LDEGCAJGKBA OMEHHNGIHKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7BF31F0", Offset = "0x7BF17F0", VA = "0x187BF31F0", Slot = "18")]
		public override LDEGCAJGKBA IGIDBGLAKOE()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : EANDHCGMJHJ<Vector3>, EPDOKFNDCNI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private bool overrides;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private Vector3 value;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool Overrides
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xF3E440", Offset = "0xF3CA40", VA = "0x180F3E440", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7BF49A0", Offset = "0x7BF2FA0", VA = "0x187BF49A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x50C5D40", Offset = "0x50C4340", VA = "0x1850C5D40", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x54F0D40", Offset = "0x54EF340", VA = "0x1854F0D40")]
		public OverridableVector3(Vector3 OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5B694D0", Offset = "0x5B67AD0", VA = "0x185B694D0")]
		public OverridableVector3(bool NIJJCCHEIAO, Vector3 OHLIHBDBKCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4900", Offset = "0x7BF2F00", VA = "0x187BF4900", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7BF48E0", Offset = "0x7BF2EE0", VA = "0x187BF48E0")]
		public static OverridableVector3 OIFHDJNIHDL(Vector3 GCDAJLDGOIF)
		{
			return default(OverridableVector3);
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
