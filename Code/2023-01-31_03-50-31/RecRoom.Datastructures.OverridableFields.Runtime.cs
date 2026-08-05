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
public interface NOPJMPJBMFE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JIPAPGFCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object AAJOHECPCLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JNLDJFDLOFH<T> : NOPJMPJBMFE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DEFGGGGNPBC<T> : global::JNLDJFDLOFH<T>, NOPJMPJBMFE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool JIPAPGFCFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T FBCEGMCNEND
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
public interface DLPIIMNGPBI<T> : global::DEFGGGGNPBC<T>, global::JNLDJFDLOFH<T>, NOPJMPJBMFE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool EEGNAFFNOKJ
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
	public struct OverridableInt : global::JNLDJFDLOFH<int>, NOPJMPJBMFE
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
			[Cpp2IlInjected.Address(RVA = "0xA6E1D0", Offset = "0xA6CFD0", VA = "0x180A6E1D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x2244A40", Offset = "0x2243840", VA = "0x182244A40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9FD200", Offset = "0x9FC000", VA = "0x1809FD200", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x22449A0", Offset = "0x22437A0", VA = "0x1822449A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::JNLDJFDLOFH<string>, NOPJMPJBMFE
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
			[Cpp2IlInjected.Address(RVA = "0xA6E1D0", Offset = "0xA6CFD0", VA = "0x180A6E1D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x775520", Offset = "0x774320", VA = "0x180775520", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x775520", Offset = "0x774320", VA = "0x180775520", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2244A90", Offset = "0x2243890", VA = "0x182244A90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::DEFGGGGNPBC<InnerType>, global::JNLDJFDLOFH<InnerType>, NOPJMPJBMFE where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool JIPAPGFCFAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType FBCEGMCNEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object AAJOHECPCLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x3A5D120", Offset = "0x3A5BF20", VA = "0x183A5D120", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3B9CB80", Offset = "0x3B9B980", VA = "0x183B9CB80")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3B9CC40", Offset = "0x3B9BA40", VA = "0x183B9CC40")]
		public MutableOverridableBase(bool BNLLEIFBLFH, [NotNull] InnerType DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C260", Offset = "0x3B9B060", VA = "0x183B9C260", Slot = "15")]
		public void KPBIPDAFKDB(global::JNLDJFDLOFH<InnerType> CHPCNANKPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C730", Offset = "0x3B9B530", VA = "0x183B9C730", Slot = "16")]
		public void OHCGLANLMCK(global::JNLDJFDLOFH<InnerType> KICLNADFIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3B9C150", Offset = "0x3B9AF50", VA = "0x183B9C150", Slot = "17")]
		public virtual void IOEAEKKNKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType GIJKOBNHOGF();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void FOIGKOCDDBB(ProtobufType CLAOGJNMEBM);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void HKDLBNMNPNK(byte[] CGOJOMKNLND);
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
			[Cpp2IlInjected.Address(RVA = "0x73B600", Offset = "0x73A400", VA = "0x18073B600", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x73AEE0", Offset = "0x739CE0", VA = "0x18073AEE0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x28D1DD0", Offset = "0x28D0BD0", VA = "0x1828D1DD0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x299DE60", Offset = "0x299CC60", VA = "0x18299DE60")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x37BCFD0", Offset = "0x37BBDD0", VA = "0x1837BCFD0")]
		public SerializedMutableOverridableBase(bool BNLLEIFBLFH, InnerType DFEOJBAFBHE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, PAPJNFCALKE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2244940", Offset = "0x2243740", VA = "0x182244940")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x22448D0", Offset = "0x22436D0", VA = "0x1822448D0")]
		public MutableOverridableObscuredInt(bool BNLLEIFBLFH, ObscuredInt DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2244800", Offset = "0x2243600", VA = "0x182244800", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x2244700", Offset = "0x2243500", VA = "0x182244700", Slot = "20")]
		public override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x2244560", Offset = "0x2243360", VA = "0x182244560", Slot = "19")]
		public override void FOIGKOCDDBB(PAPJNFCALKE CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x2244620", Offset = "0x2243420", VA = "0x182244620", Slot = "18")]
		public override PAPJNFCALKE GIJKOBNHOGF()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, MHHGGJIDGFO>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x2244490", Offset = "0x2243290", VA = "0x182244490")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x22444F0", Offset = "0x22432F0", VA = "0x1822444F0")]
		public MutableOverridableObscuredFloat(bool BNLLEIFBLFH, ObscuredFloat DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x22443C0", Offset = "0x22431C0", VA = "0x1822443C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x22442C0", Offset = "0x22430C0", VA = "0x1822442C0", Slot = "20")]
		public override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2244100", Offset = "0x2242F00", VA = "0x182244100", Slot = "19")]
		public override void FOIGKOCDDBB(MHHGGJIDGFO CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x22441D0", Offset = "0x2242FD0", VA = "0x1822441D0", Slot = "18")]
		public override MHHGGJIDGFO GIJKOBNHOGF()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, EPAHJEPJCKA>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x22433C0", Offset = "0x22421C0", VA = "0x1822433C0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2244090", Offset = "0x2242E90", VA = "0x182244090")]
		public MutableOverridableObscuredBool(bool BNLLEIFBLFH, ObscuredBool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2243FC0", Offset = "0x2242DC0", VA = "0x182243FC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x2243E80", Offset = "0x2242C80", VA = "0x182243E80", Slot = "20")]
		public override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x2243CE0", Offset = "0x2242AE0", VA = "0x182243CE0", Slot = "19")]
		public override void FOIGKOCDDBB(EPAHJEPJCKA CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x2243DA0", Offset = "0x2242BA0", VA = "0x182243DA0", Slot = "18")]
		public override EPAHJEPJCKA GIJKOBNHOGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x2243F80", Offset = "0x2242D80", VA = "0x182243F80", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::DLPIIMNGPBI<ObscuredBool>, global::DEFGGGGNPBC<ObscuredBool>, global::JNLDJFDLOFH<ObscuredBool>, NOPJMPJBMFE
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x733990", Offset = "0x732790", VA = "0x180733990", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7335F0", Offset = "0x7323F0", VA = "0x1807335F0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x22433C0", Offset = "0x22421C0", VA = "0x1822433C0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x2243340", Offset = "0x2242140", VA = "0x182243340")]
		public void KPBIPDAFKDB(MutableOverridableDefaultableObscuredBool KICLNADFIEK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, PAPJNFCALKE> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4945BE0", Offset = "0x49449E0", VA = "0x184945BE0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x4945CC0", Offset = "0x4944AC0", VA = "0x184945CC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x39542B0", Offset = "0x39530B0", VA = "0x1839542B0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4945BB0", Offset = "0x49449B0", VA = "0x184945BB0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3BA8860", Offset = "0x3BA7660", VA = "0x183BA8860")]
		public SerializedMutableOverridableObscuredEnum(bool BNLLEIFBLFH, TObsEnum DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x49459A0", Offset = "0x49447A0", VA = "0x1849459A0", Slot = "18")]
		public sealed override PAPJNFCALKE GIJKOBNHOGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4945890", Offset = "0x4944690", VA = "0x184945890", Slot = "19")]
		public sealed override void FOIGKOCDDBB(PAPJNFCALKE CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4945A50", Offset = "0x4944850", VA = "0x184945A50", Slot = "20")]
		public sealed override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4945B50", Offset = "0x4944950", VA = "0x184945B50", Slot = "17")]
		public sealed override void IOEAEKKNKLB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, PDGCHHIKJHJ>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x2243C10", Offset = "0x2242A10", VA = "0x182243C10", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2243C50", Offset = "0x2242A50", VA = "0x182243C50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x2243B20", Offset = "0x2242920", VA = "0x182243B20")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x2243BB0", Offset = "0x22429B0", VA = "0x182243BB0")]
		public MutableOverridableListObscuredString(bool BNLLEIFBLFH, List<ObscuredString> DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x2243A80", Offset = "0x2242880", VA = "0x182243A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x2243A10", Offset = "0x2242810", VA = "0x182243A10", Slot = "17")]
		public override void IOEAEKKNKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x2243910", Offset = "0x2242710", VA = "0x182243910", Slot = "20")]
		public override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x2243430", Offset = "0x2242230", VA = "0x182243430", Slot = "19")]
		public override void FOIGKOCDDBB(PDGCHHIKJHJ CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x2243750", Offset = "0x2242550", VA = "0x182243750", Slot = "18")]
		public override PDGCHHIKJHJ GIJKOBNHOGF()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::JNLDJFDLOFH<Vector3>, NOPJMPJBMFE
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
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA6E1D0", Offset = "0xA6CFD0", VA = "0x180A6E1D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x2244BE0", Offset = "0x22439E0", VA = "0x182244BE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x91EF90", Offset = "0x91DD90", VA = "0x18091EF90", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x2244BC0", Offset = "0x22439C0", VA = "0x182244BC0")]
		public OverridableVector3(Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x2244B20", Offset = "0x2243920", VA = "0x182244B20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x2244B00", Offset = "0x2243900", VA = "0x182244B00")]
		public static OverridableVector3 LFOOIECCIPM(Vector3 EKFKNNJJKLD)
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
