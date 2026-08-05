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
public interface GHFLNLLKPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HDLECFKEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object JFANEBLCHAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HFEEKLKHJDM<T> : GHFLNLLKPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T FHONEBOCBPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BDCMMKCGAGK<T> : global::HFEEKLKHJDM<T>, GHFLNLLKPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool HDLECFKEHJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T FHONEBOCBPE
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
public interface BEKLLBIIBDM<T> : global::BDCMMKCGAGK<T>, global::HFEEKLKHJDM<T>, GHFLNLLKPCE
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool BHKHKGGOOBD
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
	public struct OverridableInt : global::HFEEKLKHJDM<int>, GHFLNLLKPCE
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
			[Cpp2IlInjected.Address(RVA = "0x6D1240", Offset = "0x6CFA40", VA = "0x1806D1240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1EA8970", Offset = "0x1EA7170", VA = "0x181EA8970", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x7F76F0", Offset = "0x7F5EF0", VA = "0x1807F76F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1EA88D0", Offset = "0x1EA70D0", VA = "0x181EA88D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::HFEEKLKHJDM<string>, GHFLNLLKPCE
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
			[Cpp2IlInjected.Address(RVA = "0x6D1240", Offset = "0x6CFA40", VA = "0x1806D1240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7579D0", Offset = "0x7561D0", VA = "0x1807579D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x7579D0", Offset = "0x7561D0", VA = "0x1807579D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1EA89C0", Offset = "0x1EA71C0", VA = "0x181EA89C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::BDCMMKCGAGK<InnerType>, global::HFEEKLKHJDM<InnerType>, GHFLNLLKPCE where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool HDLECFKEHJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType FHONEBOCBPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object JFANEBLCHAP
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x32D31B0", Offset = "0x32D19B0", VA = "0x1832D31B0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x32D2F20", Offset = "0x32D1720", VA = "0x1832D2F20")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x32D2FE0", Offset = "0x32D17E0", VA = "0x1832D2FE0")]
		public MutableOverridableBase(bool DDFNJEFLLHO, [NotNull] InnerType CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x32D2BE0", Offset = "0x32D13E0", VA = "0x1832D2BE0", Slot = "15")]
		public void NLIONKHOHDJ(global::HFEEKLKHJDM<InnerType> NADIPGLPIOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x32D2710", Offset = "0x32D0F10", VA = "0x1832D2710", Slot = "16")]
		public void AECOPHMDBCG(global::HFEEKLKHJDM<InnerType> IIKMMJKCGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x32D2CB0", Offset = "0x32D14B0", VA = "0x1832D2CB0", Slot = "17")]
		public virtual void PKLFPAMOGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType LOPDKNPMGDK();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void OHMFMOMIGEK(ProtobufType MDHBBFHLKKH);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void EBJLJHGHDPB(byte[] FBOPNKEGFCC);
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
			[Cpp2IlInjected.Address(RVA = "0x6F8740", Offset = "0x6F6F40", VA = "0x1806F8740", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F8750", Offset = "0x6F6F50", VA = "0x1806F8750", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x269EFA0", Offset = "0x269D7A0", VA = "0x18269EFA0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x26B3840", Offset = "0x26B2040", VA = "0x1826B3840")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x34AC4C0", Offset = "0x34AACC0", VA = "0x1834AC4C0")]
		public SerializedMutableOverridableBase(bool DDFNJEFLLHO, InnerType CCIMHDCKHOF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, HGEKJIEBJKH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8870", Offset = "0x1EA7070", VA = "0x181EA8870")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8800", Offset = "0x1EA7000", VA = "0x181EA8800")]
		public MutableOverridableObscuredInt(bool DDFNJEFLLHO, ObscuredInt CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8730", Offset = "0x1EA6F30", VA = "0x181EA8730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8490", Offset = "0x1EA6C90", VA = "0x181EA8490", Slot = "20")]
		public override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8670", Offset = "0x1EA6E70", VA = "0x181EA8670", Slot = "19")]
		public override void OHMFMOMIGEK(HGEKJIEBJKH MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8590", Offset = "0x1EA6D90", VA = "0x181EA8590", Slot = "18")]
		public override HGEKJIEBJKH LOPDKNPMGDK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, CLFJHIPIMKJ>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1EA83C0", Offset = "0x1EA6BC0", VA = "0x181EA83C0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8420", Offset = "0x1EA6C20", VA = "0x181EA8420")]
		public MutableOverridableObscuredFloat(bool DDFNJEFLLHO, ObscuredFloat CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1EA82F0", Offset = "0x1EA6AF0", VA = "0x181EA82F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8030", Offset = "0x1EA6830", VA = "0x181EA8030", Slot = "20")]
		public override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8220", Offset = "0x1EA6A20", VA = "0x181EA8220", Slot = "19")]
		public override void OHMFMOMIGEK(CLFJHIPIMKJ MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8130", Offset = "0x1EA6930", VA = "0x181EA8130", Slot = "18")]
		public override CLFJHIPIMKJ LOPDKNPMGDK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, ADMGANPPPGO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7330", Offset = "0x1EA5B30", VA = "0x181EA7330")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7FC0", Offset = "0x1EA67C0", VA = "0x181EA7FC0")]
		public MutableOverridableObscuredBool(bool DDFNJEFLLHO, ObscuredBool CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7EF0", Offset = "0x1EA66F0", VA = "0x181EA7EF0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7C50", Offset = "0x1EA6450", VA = "0x181EA7C50", Slot = "20")]
		public override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7E30", Offset = "0x1EA6630", VA = "0x181EA7E30", Slot = "19")]
		public override void OHMFMOMIGEK(ADMGANPPPGO MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7D50", Offset = "0x1EA6550", VA = "0x181EA7D50", Slot = "18")]
		public override ADMGANPPPGO LOPDKNPMGDK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::BEKLLBIIBDM<ObscuredBool>, global::BDCMMKCGAGK<ObscuredBool>, global::HFEEKLKHJDM<ObscuredBool>, GHFLNLLKPCE
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F9B80", Offset = "0x6F8380", VA = "0x1806F9B80", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F9710", Offset = "0x6F7F10", VA = "0x1806F9710", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7330", Offset = "0x1EA5B30", VA = "0x181EA7330")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x1EA72B0", Offset = "0x1EA5AB0", VA = "0x181EA72B0")]
		public void NLIONKHOHDJ(MutableOverridableDefaultableObscuredBool IIKMMJKCGDO)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, HGEKJIEBJKH> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x3D07580", Offset = "0x3D05D80", VA = "0x183D07580", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3D07660", Offset = "0x3D05E60", VA = "0x183D07660", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x3408FA0", Offset = "0x34077A0", VA = "0x183408FA0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D07550", Offset = "0x3D05D50", VA = "0x183D07550")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3B31740", Offset = "0x3B2FF40", VA = "0x183B31740")]
		public SerializedMutableOverridableObscuredEnum(bool DDFNJEFLLHO, TObsEnum CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3D07330", Offset = "0x3D05B30", VA = "0x183D07330", Slot = "18")]
		public sealed override HGEKJIEBJKH LOPDKNPMGDK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3D073E0", Offset = "0x3D05BE0", VA = "0x183D073E0", Slot = "19")]
		public sealed override void OHMFMOMIGEK(HGEKJIEBJKH MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3D07230", Offset = "0x3D05A30", VA = "0x183D07230", Slot = "20")]
		public sealed override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3D074F0", Offset = "0x3D05CF0", VA = "0x183D074F0", Slot = "17")]
		public sealed override void PKLFPAMOGPP()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, IDOOICDJCOI>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x1EA7B80", Offset = "0x1EA6380", VA = "0x181EA7B80", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x1EA7BC0", Offset = "0x1EA63C0", VA = "0x181EA7BC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7A90", Offset = "0x1EA6290", VA = "0x181EA7A90")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7B20", Offset = "0x1EA6320", VA = "0x181EA7B20")]
		public MutableOverridableListObscuredString(bool DDFNJEFLLHO, List<ObscuredString> CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1EA79F0", Offset = "0x1EA61F0", VA = "0x181EA79F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7980", Offset = "0x1EA6180", VA = "0x181EA7980", Slot = "17")]
		public override void PKLFPAMOGPP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1EA73A0", Offset = "0x1EA5BA0", VA = "0x181EA73A0", Slot = "20")]
		public override void EBJLJHGHDPB(byte[] FBOPNKEGFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1EA7660", Offset = "0x1EA5E60", VA = "0x181EA7660", Slot = "19")]
		public override void OHMFMOMIGEK(IDOOICDJCOI MDHBBFHLKKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1EA74A0", Offset = "0x1EA5CA0", VA = "0x181EA74A0", Slot = "18")]
		public override IDOOICDJCOI LOPDKNPMGDK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::HFEEKLKHJDM<Vector3>, GHFLNLLKPCE
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
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6D1240", Offset = "0x6CFA40", VA = "0x1806D1240", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x1EA8B10", Offset = "0x1EA7310", VA = "0x181EA8B10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x79CE80", Offset = "0x79B680", VA = "0x18079CE80", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8AF0", Offset = "0x1EA72F0", VA = "0x181EA8AF0")]
		public OverridableVector3(Vector3 CCIMHDCKHOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8A50", Offset = "0x1EA7250", VA = "0x181EA8A50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1EA8A30", Offset = "0x1EA7230", VA = "0x181EA8A30")]
		public static OverridableVector3 EDIIAGKPKGG(Vector3 OGAPHEEOKGM)
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
