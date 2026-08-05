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
public interface AKHKPHCJBME
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CGLMPAIIGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object GIGFHLDOIHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MBFAKEEJNHO<T> : AKHKPHCJBME
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GKJDMOHHLPD<T> : MBFAKEEJNHO<T>, AKHKPHCJBME
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool CGLMPAIIGMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ABLHJAOAOGP
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
public interface PGDJNKHJKAF<T> : GKJDMOHHLPD<T>, MBFAKEEJNHO<T>, AKHKPHCJBME
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OHENKFOOCNH
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
	public struct OverridableInt : MBFAKEEJNHO<int>, AKHKPHCJBME
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
			[Cpp2IlInjected.Address(RVA = "0xF400B0", Offset = "0xF3F2B0", VA = "0x180F400B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7C5C010", Offset = "0x7C5B210", VA = "0x187C5C010", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2E1D960", Offset = "0x2E1CB60", VA = "0x182E1D960", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BF70", Offset = "0x7C5B170", VA = "0x187C5BF70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : MBFAKEEJNHO<string>, AKHKPHCJBME
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
			[Cpp2IlInjected.Address(RVA = "0xF400B0", Offset = "0xF3F2B0", VA = "0x180F400B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xDAB610", Offset = "0xDAA810", VA = "0x180DAB610", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xDAB610", Offset = "0xDAA810", VA = "0x180DAB610", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C060", Offset = "0x7C5B260", VA = "0x187C5C060", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : GKJDMOHHLPD<InnerType>, MBFAKEEJNHO<InnerType>, AKHKPHCJBME where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool CGLMPAIIGMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType ABLHJAOAOGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object GIGFHLDOIHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x29A98D0", Offset = "0x29A8AD0", VA = "0x1829A98D0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x536BB70", Offset = "0x536AD70", VA = "0x18536BB70")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x536BBA0", Offset = "0x536ADA0", VA = "0x18536BBA0")]
		public MutableOverridableBase(bool KNLNPCEFPJN, [NotNull] InnerType MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x536BAB0", Offset = "0x536ACB0", VA = "0x18536BAB0", Slot = "15")]
		public void MOGCPGEODAD(MBFAKEEJNHO<InnerType> IGOGNOGJADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x536B750", Offset = "0x536A950", VA = "0x18536B750", Slot = "16")]
		public void MAHOJFGCJHM(MBFAKEEJNHO<InnerType> FNJGMJGALLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x536B2F0", Offset = "0x536A4F0", VA = "0x18536B2F0", Slot = "17")]
		public virtual void AJIPEHIHHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType MIAHOBKNAGO();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void BPMMDHMKOIE(ProtobufType MLFKMODPGPM);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void IPCPOIJKNCG(byte[] KHJKPHCPJCK);
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
			[Cpp2IlInjected.Address(RVA = "0xC8C5E0", Offset = "0xC8B7E0", VA = "0x180C8C5E0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xC8C5D0", Offset = "0xC8B7D0", VA = "0x180C8C5D0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xDD7B40", Offset = "0xDD6D40", VA = "0x180DD7B40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x44F4310", Offset = "0x44F3510", VA = "0x1844F4310")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x585A470", Offset = "0x5859670", VA = "0x18585A470")]
		public SerializedMutableOverridableBase(bool KNLNPCEFPJN, InnerType MLCDCHNOCFI)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, BLPJMIIEPGO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BEA0", Offset = "0x7C5B0A0", VA = "0x187C5BEA0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BF00", Offset = "0x7C5B100", VA = "0x187C5BF00")]
		public MutableOverridableObscuredInt(bool KNLNPCEFPJN, ObscuredInt MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BDD0", Offset = "0x7C5AFD0", VA = "0x187C5BDD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BC20", Offset = "0x7C5AE20", VA = "0x187C5BC20", Slot = "20")]
		public override void IPCPOIJKNCG(byte[] KHJKPHCPJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BB70", Offset = "0x7C5AD70", VA = "0x187C5BB70", Slot = "19")]
		public override void BPMMDHMKOIE(BLPJMIIEPGO MLFKMODPGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BCF0", Offset = "0x7C5AEF0", VA = "0x187C5BCF0", Slot = "18")]
		public override BLPJMIIEPGO MIAHOBKNAGO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, OCKMEABKELP>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BAA0", Offset = "0x7C5ACA0", VA = "0x187C5BAA0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5BB00", Offset = "0x7C5AD00", VA = "0x187C5BB00")]
		public MutableOverridableObscuredFloat(bool KNLNPCEFPJN, ObscuredFloat MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B9D0", Offset = "0x7C5ABD0", VA = "0x187C5B9D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B810", Offset = "0x7C5AA10", VA = "0x187C5B810", Slot = "20")]
		public override void IPCPOIJKNCG(byte[] KHJKPHCPJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B750", Offset = "0x7C5A950", VA = "0x187C5B750", Slot = "19")]
		public override void BPMMDHMKOIE(OCKMEABKELP MLFKMODPGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B8E0", Offset = "0x7C5AAE0", VA = "0x187C5B8E0", Slot = "18")]
		public override OCKMEABKELP MIAHOBKNAGO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, JKIEJHOAADF>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A970", Offset = "0x7C59B70", VA = "0x187C5A970")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B6E0", Offset = "0x7C5A8E0", VA = "0x187C5B6E0")]
		public MutableOverridableObscuredBool(bool KNLNPCEFPJN, ObscuredBool MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B610", Offset = "0x7C5A810", VA = "0x187C5B610", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B3C0", Offset = "0x7C5A5C0", VA = "0x187C5B3C0", Slot = "20")]
		public override void IPCPOIJKNCG(byte[] KHJKPHCPJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B300", Offset = "0x7C5A500", VA = "0x187C5B300", Slot = "19")]
		public override void BPMMDHMKOIE(JKIEJHOAADF MLFKMODPGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B490", Offset = "0x7C5A690", VA = "0x187C5B490", Slot = "18")]
		public override JKIEJHOAADF MIAHOBKNAGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B580", Offset = "0x7C5A780", VA = "0x187C5B580", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, PGDJNKHJKAF<ObscuredBool>, GKJDMOHHLPD<ObscuredBool>, MBFAKEEJNHO<ObscuredBool>, AKHKPHCJBME
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9F2490", Offset = "0x9F1690", VA = "0x1809F2490", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x9F24F0", Offset = "0x9F16F0", VA = "0x1809F24F0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A970", Offset = "0x7C59B70", VA = "0x187C5A970")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A8F0", Offset = "0x7C59AF0", VA = "0x187C5A8F0")]
		public void MOGCPGEODAD(MutableOverridableDefaultableObscuredBool FNJGMJGALLH)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, BLPJMIIEPGO> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x585A900", Offset = "0x5859B00", VA = "0x18585A900", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x585AA80", Offset = "0x5859C80", VA = "0x18585AA80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x499BBD0", Offset = "0x499ADD0", VA = "0x18499BBD0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x585A8C0", Offset = "0x5859AC0", VA = "0x18585A8C0")]
		public SerializedMutableOverridableObscuredEnum(bool KNLNPCEFPJN, TObsEnum MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x585A7D0", Offset = "0x58599D0", VA = "0x18585A7D0", Slot = "18")]
		public sealed override BLPJMIIEPGO MIAHOBKNAGO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x585A5F0", Offset = "0x58597F0", VA = "0x18585A5F0", Slot = "19")]
		public sealed override void BPMMDHMKOIE(BLPJMIIEPGO MLFKMODPGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x585A6F0", Offset = "0x58598F0", VA = "0x18585A6F0", Slot = "20")]
		public sealed override void IPCPOIJKNCG(byte[] KHJKPHCPJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x585A570", Offset = "0x5859770", VA = "0x18585A570", Slot = "17")]
		public sealed override void AJIPEHIHHNF()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, JLLIMDEJOIA>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7C5B230", Offset = "0x7C5A430", VA = "0x187C5B230", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7C5B270", Offset = "0x7C5A470", VA = "0x187C5B270", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B190", Offset = "0x7C5A390", VA = "0x187C5B190")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B130", Offset = "0x7C5A330", VA = "0x187C5B130")]
		public MutableOverridableListObscuredString(bool KNLNPCEFPJN, List<ObscuredString> MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7C5B090", Offset = "0x7C5A290", VA = "0x187C5B090", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7C5A9E0", Offset = "0x7C59BE0", VA = "0x187C5A9E0", Slot = "17")]
		public override void AJIPEHIHHNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7C5ADE0", Offset = "0x7C59FE0", VA = "0x187C5ADE0", Slot = "20")]
		public override void IPCPOIJKNCG(byte[] KHJKPHCPJCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AA70", Offset = "0x7C59C70", VA = "0x187C5AA70", Slot = "19")]
		public override void BPMMDHMKOIE(JLLIMDEJOIA MLFKMODPGPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7C5AEB0", Offset = "0x7C5A0B0", VA = "0x187C5AEB0", Slot = "18")]
		public override JLLIMDEJOIA MIAHOBKNAGO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : MBFAKEEJNHO<Vector3>, AKHKPHCJBME
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
			[Cpp2IlInjected.Address(RVA = "0xF400B0", Offset = "0xF3F2B0", VA = "0x180F400B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5C190", Offset = "0x7C5B390", VA = "0x187C5C190", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x50ADBF0", Offset = "0x50ACDF0", VA = "0x1850ADBF0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5495010", Offset = "0x5494210", VA = "0x185495010")]
		public OverridableVector3(Vector3 MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5B80F10", Offset = "0x5B80110", VA = "0x185B80F10")]
		public OverridableVector3(bool KNLNPCEFPJN, Vector3 MLCDCHNOCFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C0F0", Offset = "0x7C5B2F0", VA = "0x187C5C0F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7C5C0D0", Offset = "0x7C5B2D0", VA = "0x187C5C0D0")]
		public static OverridableVector3 NEKLFDMHCNA(Vector3 KFEGNKODPFP)
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
