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
public interface HDMBMDECICI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool CBILPNNFOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object KANCMOLCBLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IMJDMJFKGDH<T> : HDMBMDECICI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T AAFFKFKIJDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LNOBGDLHBCO<T> : global::IMJDMJFKGDH<T>, HDMBMDECICI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool CBILPNNFOOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T AAFFKFKIJDJ
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
public interface DDMHEGPGMID<T> : global::LNOBGDLHBCO<T>, global::IMJDMJFKGDH<T>, HDMBMDECICI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool FPFHMILPFHP
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
	public struct OverridableInt : global::IMJDMJFKGDH<int>, HDMBMDECICI
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
			[Cpp2IlInjected.Address(RVA = "0x7489D0", Offset = "0x7477D0", VA = "0x1807489D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A120", Offset = "0x5E78F20", VA = "0x185E7A120", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x73E0B0", Offset = "0x73CEB0", VA = "0x18073E0B0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A080", Offset = "0x5E78E80", VA = "0x185E7A080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::IMJDMJFKGDH<string>, HDMBMDECICI
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
			[Cpp2IlInjected.Address(RVA = "0x7489D0", Offset = "0x7477D0", VA = "0x1807489D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x96F5C0", Offset = "0x96E3C0", VA = "0x18096F5C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x96F5C0", Offset = "0x96E3C0", VA = "0x18096F5C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A170", Offset = "0x5E78F70", VA = "0x185E7A170", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::LNOBGDLHBCO<InnerType>, global::IMJDMJFKGDH<InnerType>, HDMBMDECICI where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool CBILPNNFOOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType AAFFKFKIJDJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object KANCMOLCBLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x1E83950", Offset = "0x1E82750", VA = "0x181E83950", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1E836C0", Offset = "0x1E824C0", VA = "0x181E836C0")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E83780", Offset = "0x1E82580", VA = "0x181E83780")]
		public MutableOverridableBase(bool ACBPCJELHDI, [NotNull] InnerType IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1E83230", Offset = "0x1E82030", VA = "0x181E83230", Slot = "15")]
		public void NKALEANECIN(global::IMJDMJFKGDH<InnerType> CLPBMCBAIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E82DA0", Offset = "0x1E81BA0", VA = "0x181E82DA0", Slot = "16")]
		public void JACHHKBDHDB(global::IMJDMJFKGDH<InnerType> HNOJKNGFFBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1E82D40", Offset = "0x1E81B40", VA = "0x181E82D40", Slot = "17")]
		public virtual void EJCGBCFCFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType CJMHGJCHINP();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void KPEGJMKGOHJ(ProtobufType LFFEAHLLHAI);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void EJHOFFNJMOA(byte[] LGBNDCPNDOM);
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
			[Cpp2IlInjected.Address(RVA = "0x6B19D0", Offset = "0x6B07D0", VA = "0x1806B19D0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6B1A00", Offset = "0x6B0800", VA = "0x1806B1A00", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1199BC0", Offset = "0x11989C0", VA = "0x181199BC0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x144DDD0", Offset = "0x144CBD0", VA = "0x18144DDD0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3025050", Offset = "0x3023E50", VA = "0x183025050")]
		public SerializedMutableOverridableBase(bool ACBPCJELHDI, InnerType IGJPNMBCJPK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, MEEILDALLDL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A020", Offset = "0x5E78E20", VA = "0x185E7A020")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E79FB0", Offset = "0x5E78DB0", VA = "0x185E79FB0")]
		public MutableOverridableObscuredInt(bool ACBPCJELHDI, ObscuredInt IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E79EE0", Offset = "0x5E78CE0", VA = "0x185E79EE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E79D20", Offset = "0x5E78B20", VA = "0x185E79D20", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E79E20", Offset = "0x5E78C20", VA = "0x185E79E20", Slot = "19")]
		public override void KPEGJMKGOHJ(MEEILDALLDL LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E79C40", Offset = "0x5E78A40", VA = "0x185E79C40", Slot = "18")]
		public override MEEILDALLDL CJMHGJCHINP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, JOLFIFGLHLH>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5E79B70", Offset = "0x5E78970", VA = "0x185E79B70")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E79BD0", Offset = "0x5E789D0", VA = "0x185E79BD0")]
		public MutableOverridableObscuredFloat(bool ACBPCJELHDI, ObscuredFloat IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E79AA0", Offset = "0x5E788A0", VA = "0x185E79AA0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5E798D0", Offset = "0x5E786D0", VA = "0x185E798D0", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E799D0", Offset = "0x5E787D0", VA = "0x185E799D0", Slot = "19")]
		public override void KPEGJMKGOHJ(JOLFIFGLHLH LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5E797E0", Offset = "0x5E785E0", VA = "0x185E797E0", Slot = "18")]
		public override JOLFIFGLHLH CJMHGJCHINP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, PDEGALLELKI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5E78AE0", Offset = "0x5E778E0", VA = "0x185E78AE0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E79770", Offset = "0x5E78570", VA = "0x185E79770")]
		public MutableOverridableObscuredBool(bool ACBPCJELHDI, ObscuredBool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5E796A0", Offset = "0x5E784A0", VA = "0x185E796A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E794E0", Offset = "0x5E782E0", VA = "0x185E794E0", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E795E0", Offset = "0x5E783E0", VA = "0x185E795E0", Slot = "19")]
		public override void KPEGJMKGOHJ(PDEGALLELKI LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E79400", Offset = "0x5E78200", VA = "0x185E79400", Slot = "18")]
		public override PDEGALLELKI CJMHGJCHINP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::DDMHEGPGMID<ObscuredBool>, global::LNOBGDLHBCO<ObscuredBool>, global::IMJDMJFKGDH<ObscuredBool>, HDMBMDECICI
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x65BD70", Offset = "0x65AB70", VA = "0x18065BD70", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7B1470", Offset = "0x7B0270", VA = "0x1807B1470", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E78AE0", Offset = "0x5E778E0", VA = "0x185E78AE0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E78A60", Offset = "0x5E77860", VA = "0x185E78A60")]
		public void NKALEANECIN(MutableOverridableDefaultableObscuredBool HNOJKNGFFBE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, MEEILDALLDL> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x30254E0", Offset = "0x30242E0", VA = "0x1830254E0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x30255C0", Offset = "0x30243C0", VA = "0x1830255C0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x166B340", Offset = "0x166A140", VA = "0x18166B340")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x30254B0", Offset = "0x30242B0", VA = "0x1830254B0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2C9E650", Offset = "0x2C9D450", VA = "0x182C9E650")]
		public SerializedMutableOverridableObscuredEnum(bool ACBPCJELHDI, TObsEnum IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3025190", Offset = "0x3023F90", VA = "0x183025190", Slot = "18")]
		public sealed override MEEILDALLDL CJMHGJCHINP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x30253A0", Offset = "0x30241A0", VA = "0x1830253A0", Slot = "19")]
		public sealed override void KPEGJMKGOHJ(MEEILDALLDL LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x30252A0", Offset = "0x30240A0", VA = "0x1830252A0", Slot = "20")]
		public sealed override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x3025240", Offset = "0x3024040", VA = "0x183025240", Slot = "17")]
		public sealed override void EJCGBCFCFCI()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, CKDNEFCCAII>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5E79330", Offset = "0x5E78130", VA = "0x185E79330", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5E79370", Offset = "0x5E78170", VA = "0x185E79370", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E79240", Offset = "0x5E78040", VA = "0x185E79240")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E792D0", Offset = "0x5E780D0", VA = "0x185E792D0")]
		public MutableOverridableListObscuredString(bool ACBPCJELHDI, List<ObscuredString> IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E791A0", Offset = "0x5E77FA0", VA = "0x185E791A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E78D10", Offset = "0x5E77B10", VA = "0x185E78D10", Slot = "17")]
		public override void EJCGBCFCFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E78D80", Offset = "0x5E77B80", VA = "0x185E78D80", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5E78E80", Offset = "0x5E77C80", VA = "0x185E78E80", Slot = "19")]
		public override void KPEGJMKGOHJ(CKDNEFCCAII LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5E78B50", Offset = "0x5E77950", VA = "0x185E78B50", Slot = "18")]
		public override CKDNEFCCAII CJMHGJCHINP()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::IMJDMJFKGDH<Vector3>, HDMBMDECICI
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
			[Cpp2IlInjected.Address(RVA = "0x7489D0", Offset = "0x7477D0", VA = "0x1807489D0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A2C0", Offset = "0x5E790C0", VA = "0x185E7A2C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1D373F0", Offset = "0x1D361F0", VA = "0x181D373F0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A2A0", Offset = "0x5E790A0", VA = "0x185E7A2A0")]
		public OverridableVector3(Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A200", Offset = "0x5E79000", VA = "0x185E7A200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A1E0", Offset = "0x5E78FE0", VA = "0x185E7A1E0")]
		public static OverridableVector3 PAAEKNCKHBI(Vector3 BIILFBFAAOF)
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
