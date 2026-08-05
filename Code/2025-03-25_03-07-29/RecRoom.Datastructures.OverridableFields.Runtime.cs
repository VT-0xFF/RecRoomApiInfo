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
public interface IFDKECCAFFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool APADMOENLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object MCIKBFONPAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ODFHEOAMGMN<T> : IFDKECCAFFP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T HNMCNCHEPGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KAJPAOMBABP<T> : ODFHEOAMGMN<T>, IFDKECCAFFP
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool APADMOENLFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T HNMCNCHEPGK
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
public interface AMKKLIALGED<T> : KAJPAOMBABP<T>, ODFHEOAMGMN<T>, IFDKECCAFFP
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool DJGCGDJIJOC
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
	public struct OverridableInt : ODFHEOAMGMN<int>, IFDKECCAFFP
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
			[Cpp2IlInjected.Address(RVA = "0xE49B00", Offset = "0xE48F00", VA = "0x180E49B00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x77D8910", Offset = "0x77D7D10", VA = "0x1877D8910", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2C8A510", Offset = "0x2C89910", VA = "0x182C8A510", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x77D8870", Offset = "0x77D7C70", VA = "0x1877D8870", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : ODFHEOAMGMN<string>, IFDKECCAFFP
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
			[Cpp2IlInjected.Address(RVA = "0xE49B00", Offset = "0xE48F00", VA = "0x180E49B00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCDD060", Offset = "0xCDC460", VA = "0x180CDD060", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCDD060", Offset = "0xCDC460", VA = "0x180CDD060", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x77D8960", Offset = "0x77D7D60", VA = "0x1877D8960", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : KAJPAOMBABP<InnerType>, ODFHEOAMGMN<InnerType>, IFDKECCAFFP where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool APADMOENLFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType HNMCNCHEPGK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object MCIKBFONPAM
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2825440", Offset = "0x2824840", VA = "0x182825440", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4FE2D20", Offset = "0x4FE2120", VA = "0x184FE2D20")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4FE2D50", Offset = "0x4FE2150", VA = "0x184FE2D50")]
		public MutableOverridableBase(bool CEKNINAGLLA, [NotNull] InnerType FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4FE29C0", Offset = "0x4FE1DC0", VA = "0x184FE29C0", Slot = "15")]
		public void IBNDPJGCLBG(ODFHEOAMGMN<InnerType> NAPPKJDDPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4FE2900", Offset = "0x4FE1D00", VA = "0x184FE2900", Slot = "16")]
		public void GHNGGIODPCD(ODFHEOAMGMN<InnerType> JAPIEEBOJEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4FE2450", Offset = "0x4FE1850", VA = "0x184FE2450", Slot = "17")]
		public virtual void CNJFGCHCFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType PAACKGIFGKO();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void GFHPNPNMOOG(ProtobufType FJINBMBKNIJ);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void PDLHPJKMBEN(byte[] DLHDJNKFJOG);
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
			[Cpp2IlInjected.Address(RVA = "0xBD2B40", Offset = "0xBD1F40", VA = "0x180BD2B40", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBD2770", Offset = "0xBD1B70", VA = "0x180BD2770", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xD268B0", Offset = "0xD25CB0", VA = "0x180D268B0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x41C9C80", Offset = "0x41C9080", VA = "0x1841C9C80")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x47506A0", Offset = "0x474FAA0", VA = "0x1847506A0")]
		public SerializedMutableOverridableBase(bool CEKNINAGLLA, InnerType FIIKLGCIAGG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, IIHBKBLADKA>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x77D87A0", Offset = "0x77D7BA0", VA = "0x1877D87A0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x77D8800", Offset = "0x77D7C00", VA = "0x1877D8800")]
		public MutableOverridableObscuredInt(bool CEKNINAGLLA, ObscuredInt FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x77D86D0", Offset = "0x77D7AD0", VA = "0x1877D86D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x77D8600", Offset = "0x77D7A00", VA = "0x1877D8600", Slot = "20")]
		public override void PDLHPJKMBEN(byte[] DLHDJNKFJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x77D8470", Offset = "0x77D7870", VA = "0x1877D8470", Slot = "19")]
		public override void GFHPNPNMOOG(IIHBKBLADKA FJINBMBKNIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x77D8520", Offset = "0x77D7920", VA = "0x1877D8520", Slot = "18")]
		public override IIHBKBLADKA PAACKGIFGKO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, EDHJGMLCMHA>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x77D83A0", Offset = "0x77D77A0", VA = "0x1877D83A0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x77D8400", Offset = "0x77D7800", VA = "0x1877D8400")]
		public MutableOverridableObscuredFloat(bool CEKNINAGLLA, ObscuredFloat FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x77D82D0", Offset = "0x77D76D0", VA = "0x1877D82D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x77D8200", Offset = "0x77D7600", VA = "0x1877D8200", Slot = "20")]
		public override void PDLHPJKMBEN(byte[] DLHDJNKFJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x77D8050", Offset = "0x77D7450", VA = "0x1877D8050", Slot = "19")]
		public override void GFHPNPNMOOG(EDHJGMLCMHA FJINBMBKNIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x77D8110", Offset = "0x77D7510", VA = "0x1877D8110", Slot = "18")]
		public override EDHJGMLCMHA PAACKGIFGKO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, KFIPKGFLFDI>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x77D7270", Offset = "0x77D6670", VA = "0x1877D7270")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x77D7FE0", Offset = "0x77D73E0", VA = "0x1877D7FE0")]
		public MutableOverridableObscuredBool(bool CEKNINAGLLA, ObscuredBool FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x77D7F10", Offset = "0x77D7310", VA = "0x1877D7F10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x77D7E40", Offset = "0x77D7240", VA = "0x1877D7E40", Slot = "20")]
		public override void PDLHPJKMBEN(byte[] DLHDJNKFJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x77D7C00", Offset = "0x77D7000", VA = "0x1877D7C00", Slot = "19")]
		public override void GFHPNPNMOOG(KFIPKGFLFDI FJINBMBKNIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x77D7D50", Offset = "0x77D7150", VA = "0x1877D7D50", Slot = "18")]
		public override KFIPKGFLFDI PAACKGIFGKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x77D7CC0", Offset = "0x77D70C0", VA = "0x1877D7CC0", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x991340", Offset = "0x990740", VA = "0x180991340", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, AMKKLIALGED<ObscuredBool>, KAJPAOMBABP<ObscuredBool>, ODFHEOAMGMN<ObscuredBool>, IFDKECCAFFP
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x9932A0", Offset = "0x9926A0", VA = "0x1809932A0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x993530", Offset = "0x992930", VA = "0x180993530", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x77D7270", Offset = "0x77D6670", VA = "0x1877D7270")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x77D71F0", Offset = "0x77D65F0", VA = "0x1877D71F0")]
		public void IBNDPJGCLBG(MutableOverridableDefaultableObscuredBool JAPIEEBOJEA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, IIHBKBLADKA> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x550DDB0", Offset = "0x550D1B0", VA = "0x18550DDB0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x550DF30", Offset = "0x550D330", VA = "0x18550DF30", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x482D370", Offset = "0x482C770", VA = "0x18482D370")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x550DD70", Offset = "0x550D170", VA = "0x18550DD70")]
		public SerializedMutableOverridableObscuredEnum(bool CEKNINAGLLA, TObsEnum FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x550DBA0", Offset = "0x550CFA0", VA = "0x18550DBA0", Slot = "18")]
		public sealed override IIHBKBLADKA PAACKGIFGKO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x550DAA0", Offset = "0x550CEA0", VA = "0x18550DAA0", Slot = "19")]
		public sealed override void GFHPNPNMOOG(IIHBKBLADKA FJINBMBKNIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x550DC90", Offset = "0x550D090", VA = "0x18550DC90", Slot = "20")]
		public sealed override void PDLHPJKMBEN(byte[] DLHDJNKFJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x550DA20", Offset = "0x550CE20", VA = "0x18550DA20", Slot = "17")]
		public sealed override void CNJFGCHCFHB()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, DJMAJKKHOAF>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x77D7B30", Offset = "0x77D6F30", VA = "0x1877D7B30", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x77D7B70", Offset = "0x77D6F70", VA = "0x1877D7B70", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x77D7A90", Offset = "0x77D6E90", VA = "0x1877D7A90")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x77D7A30", Offset = "0x77D6E30", VA = "0x1877D7A30")]
		public MutableOverridableListObscuredString(bool CEKNINAGLLA, List<ObscuredString> FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x77D7990", Offset = "0x77D6D90", VA = "0x1877D7990", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x77D72E0", Offset = "0x77D66E0", VA = "0x1877D72E0", Slot = "17")]
		public override void CNJFGCHCFHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x77D78C0", Offset = "0x77D6CC0", VA = "0x1877D78C0", Slot = "20")]
		public override void PDLHPJKMBEN(byte[] DLHDJNKFJOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x77D7370", Offset = "0x77D6770", VA = "0x1877D7370", Slot = "19")]
		public override void GFHPNPNMOOG(DJMAJKKHOAF FJINBMBKNIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x77D76E0", Offset = "0x77D6AE0", VA = "0x1877D76E0", Slot = "18")]
		public override DJMAJKKHOAF PAACKGIFGKO()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : ODFHEOAMGMN<Vector3>, IFDKECCAFFP
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
			[Cpp2IlInjected.Address(RVA = "0xE49B00", Offset = "0xE48F00", VA = "0x180E49B00", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x77D8A90", Offset = "0x77D7E90", VA = "0x1877D8A90", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x4D68270", Offset = "0x4D67670", VA = "0x184D68270", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x511A1B0", Offset = "0x51195B0", VA = "0x18511A1B0")]
		public OverridableVector3(Vector3 FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x57FCE80", Offset = "0x57FC280", VA = "0x1857FCE80")]
		public OverridableVector3(bool CEKNINAGLLA, Vector3 FIIKLGCIAGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x77D89F0", Offset = "0x77D7DF0", VA = "0x1877D89F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x77D89D0", Offset = "0x77D7DD0", VA = "0x1877D89D0")]
		public static OverridableVector3 MDKCMNAEKLA(Vector3 NMBONOELKFM)
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
