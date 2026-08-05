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
			[Cpp2IlInjected.Address(RVA = "0x84E5B0", Offset = "0x84D5B0", VA = "0x18084E5B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x60FCCE0", Offset = "0x60FBCE0", VA = "0x1860FCCE0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8441E0", Offset = "0x8431E0", VA = "0x1808441E0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60FCC40", Offset = "0x60FBC40", VA = "0x1860FCC40", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x84E5B0", Offset = "0x84D5B0", VA = "0x18084E5B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6D4B00", Offset = "0x6D3B00", VA = "0x1806D4B00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6D4B00", Offset = "0x6D3B00", VA = "0x1806D4B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x60FCD30", Offset = "0x60FBD30", VA = "0x1860FCD30", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x238EB60", Offset = "0x238DB60", VA = "0x18238EB60", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x238E8D0", Offset = "0x238D8D0", VA = "0x18238E8D0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x238E990", Offset = "0x238D990", VA = "0x18238E990")]
		public MutableOverridableBase(bool BNLLEIFBLFH, [NotNull] InnerType DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x238DFB0", Offset = "0x238CFB0", VA = "0x18238DFB0", Slot = "15")]
		public void KPBIPDAFKDB(global::JNLDJFDLOFH<InnerType> CHPCNANKPJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x238E480", Offset = "0x238D480", VA = "0x18238E480", Slot = "16")]
		public void OHCGLANLMCK(global::JNLDJFDLOFH<InnerType> KICLNADFIEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x238DEA0", Offset = "0x238CEA0", VA = "0x18238DEA0", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x682250", Offset = "0x681250", VA = "0x180682250", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x682270", Offset = "0x681270", VA = "0x180682270", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x67E0C0", Offset = "0x67D0C0", VA = "0x18067E0C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x13C9E90", Offset = "0x13C8E90", VA = "0x1813C9E90", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x13D7DF0", Offset = "0x13D6DF0", VA = "0x1813D7DF0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x2398F60", Offset = "0x2397F60", VA = "0x182398F60")]
		public SerializedMutableOverridableBase(bool BNLLEIFBLFH, InnerType DFEOJBAFBHE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, PAPJNFCALKE>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x60FCBE0", Offset = "0x60FBBE0", VA = "0x1860FCBE0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x60FCB70", Offset = "0x60FBB70", VA = "0x1860FCB70")]
		public MutableOverridableObscuredInt(bool BNLLEIFBLFH, ObscuredInt DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60FCAA0", Offset = "0x60FBAA0", VA = "0x1860FCAA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60FC9A0", Offset = "0x60FB9A0", VA = "0x1860FC9A0", Slot = "20")]
		public override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60FC800", Offset = "0x60FB800", VA = "0x1860FC800", Slot = "19")]
		public override void FOIGKOCDDBB(PAPJNFCALKE CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60FC8C0", Offset = "0x60FB8C0", VA = "0x1860FC8C0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x60FC730", Offset = "0x60FB730", VA = "0x1860FC730")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x60FC790", Offset = "0x60FB790", VA = "0x1860FC790")]
		public MutableOverridableObscuredFloat(bool BNLLEIFBLFH, ObscuredFloat DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60FC660", Offset = "0x60FB660", VA = "0x1860FC660", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60FC560", Offset = "0x60FB560", VA = "0x1860FC560", Slot = "20")]
		public override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60FC3A0", Offset = "0x60FB3A0", VA = "0x1860FC3A0", Slot = "19")]
		public override void FOIGKOCDDBB(MHHGGJIDGFO CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x60FC470", Offset = "0x60FB470", VA = "0x1860FC470", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x60FB660", Offset = "0x60FA660", VA = "0x1860FB660")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x60FC330", Offset = "0x60FB330", VA = "0x1860FC330")]
		public MutableOverridableObscuredBool(bool BNLLEIFBLFH, ObscuredBool DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x60FC260", Offset = "0x60FB260", VA = "0x1860FC260", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x60FC120", Offset = "0x60FB120", VA = "0x1860FC120", Slot = "20")]
		public override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x60FBF80", Offset = "0x60FAF80", VA = "0x1860FBF80", Slot = "19")]
		public override void FOIGKOCDDBB(EPAHJEPJCKA CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x60FC040", Offset = "0x60FB040", VA = "0x1860FC040", Slot = "18")]
		public override EPAHJEPJCKA GIJKOBNHOGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60FC220", Offset = "0x60FB220", VA = "0x1860FC220", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0", Slot = "21")]
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
			[Cpp2IlInjected.Address(RVA = "0x6993D0", Offset = "0x6983D0", VA = "0x1806993D0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x78A640", Offset = "0x789640", VA = "0x18078A640", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x60FB660", Offset = "0x60FA660", VA = "0x1860FB660")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x60FB5E0", Offset = "0x60FA5E0", VA = "0x1860FB5E0")]
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
			[Cpp2IlInjected.Address(RVA = "0x33F8D30", Offset = "0x33F7D30", VA = "0x1833F8D30", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x33F8E10", Offset = "0x33F7E10", VA = "0x1833F8E10", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x1E358F0", Offset = "0x1E348F0", VA = "0x181E358F0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x33F8D00", Offset = "0x33F7D00", VA = "0x1833F8D00")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x2399420", Offset = "0x2398420", VA = "0x182399420")]
		public SerializedMutableOverridableObscuredEnum(bool BNLLEIFBLFH, TObsEnum DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x33F8AF0", Offset = "0x33F7AF0", VA = "0x1833F8AF0", Slot = "18")]
		public sealed override PAPJNFCALKE GIJKOBNHOGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x33F89E0", Offset = "0x33F79E0", VA = "0x1833F89E0", Slot = "19")]
		public sealed override void FOIGKOCDDBB(PAPJNFCALKE CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x33F8BA0", Offset = "0x33F7BA0", VA = "0x1833F8BA0", Slot = "20")]
		public sealed override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x33F8CA0", Offset = "0x33F7CA0", VA = "0x1833F8CA0", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x60FBEB0", Offset = "0x60FAEB0", VA = "0x1860FBEB0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x60FBEF0", Offset = "0x60FAEF0", VA = "0x1860FBEF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x60FBDC0", Offset = "0x60FADC0", VA = "0x1860FBDC0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x60FBE50", Offset = "0x60FAE50", VA = "0x1860FBE50")]
		public MutableOverridableListObscuredString(bool BNLLEIFBLFH, List<ObscuredString> DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x60FBD20", Offset = "0x60FAD20", VA = "0x1860FBD20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x60FBCB0", Offset = "0x60FACB0", VA = "0x1860FBCB0", Slot = "17")]
		public override void IOEAEKKNKLB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x60FBBB0", Offset = "0x60FABB0", VA = "0x1860FBBB0", Slot = "20")]
		public override void HKDLBNMNPNK(byte[] CGOJOMKNLND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x60FB6D0", Offset = "0x60FA6D0", VA = "0x1860FB6D0", Slot = "19")]
		public override void FOIGKOCDDBB(PDGCHHIKJHJ CLAOGJNMEBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x60FB9F0", Offset = "0x60FA9F0", VA = "0x1860FB9F0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x84E5B0", Offset = "0x84D5B0", VA = "0x18084E5B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x60FCE80", Offset = "0x60FBE80", VA = "0x1860FCE80", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x2B33520", Offset = "0x2B32520", VA = "0x182B33520", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x60FCE60", Offset = "0x60FBE60", VA = "0x1860FCE60")]
		public OverridableVector3(Vector3 DFEOJBAFBHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x60FCDC0", Offset = "0x60FBDC0", VA = "0x1860FCDC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x60FCDA0", Offset = "0x60FBDA0", VA = "0x1860FCDA0")]
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
