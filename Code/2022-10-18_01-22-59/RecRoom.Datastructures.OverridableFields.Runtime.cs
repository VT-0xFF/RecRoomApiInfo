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
			[Cpp2IlInjected.Address(RVA = "0x8D7DB0", Offset = "0x8D6DB0", VA = "0x1808D7DB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C020", Offset = "0x5E7B020", VA = "0x185E7C020", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8B0600", Offset = "0x8AF600", VA = "0x1808B0600", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BF80", Offset = "0x5E7AF80", VA = "0x185E7BF80", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D7DB0", Offset = "0x8D6DB0", VA = "0x1808D7DB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB00", Offset = "0x6ACB00", VA = "0x1806ADB00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB00", Offset = "0x6ACB00", VA = "0x1806ADB00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C070", Offset = "0x5E7B070", VA = "0x185E7C070", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x219C3F0", Offset = "0x219B3F0", VA = "0x18219C3F0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x219C160", Offset = "0x219B160", VA = "0x18219C160")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x219C220", Offset = "0x219B220", VA = "0x18219C220")]
		public MutableOverridableBase(bool ACBPCJELHDI, [NotNull] InnerType IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x219BCD0", Offset = "0x219ACD0", VA = "0x18219BCD0", Slot = "15")]
		public void NKALEANECIN(global::IMJDMJFKGDH<InnerType> CLPBMCBAIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x219B840", Offset = "0x219A840", VA = "0x18219B840", Slot = "16")]
		public void JACHHKBDHDB(global::IMJDMJFKGDH<InnerType> HNOJKNGFFBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x219B7E0", Offset = "0x219A7E0", VA = "0x18219B7E0", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A250", VA = "0x18065B250", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A270", VA = "0x18065B270", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x6560C0", VA = "0x1806570C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x14B3450", Offset = "0x14B2450", VA = "0x1814B3450", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x1767530", Offset = "0x1766530", VA = "0x181767530")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3304EF0", Offset = "0x3303EF0", VA = "0x183304EF0")]
		public SerializedMutableOverridableBase(bool ACBPCJELHDI, InnerType IGJPNMBCJPK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, MEEILDALLDL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BF20", Offset = "0x5E7AF20", VA = "0x185E7BF20")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BEB0", Offset = "0x5E7AEB0", VA = "0x185E7BEB0")]
		public MutableOverridableObscuredInt(bool ACBPCJELHDI, ObscuredInt IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BDE0", Offset = "0x5E7ADE0", VA = "0x185E7BDE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BC20", Offset = "0x5E7AC20", VA = "0x185E7BC20", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BD20", Offset = "0x5E7AD20", VA = "0x185E7BD20", Slot = "19")]
		public override void KPEGJMKGOHJ(MEEILDALLDL LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BB40", Offset = "0x5E7AB40", VA = "0x185E7BB40", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E7BA70", Offset = "0x5E7AA70", VA = "0x185E7BA70")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7BAD0", Offset = "0x5E7AAD0", VA = "0x185E7BAD0")]
		public MutableOverridableObscuredFloat(bool ACBPCJELHDI, ObscuredFloat IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B9A0", Offset = "0x5E7A9A0", VA = "0x185E7B9A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B7D0", Offset = "0x5E7A7D0", VA = "0x185E7B7D0", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B8D0", Offset = "0x5E7A8D0", VA = "0x185E7B8D0", Slot = "19")]
		public override void KPEGJMKGOHJ(JOLFIFGLHLH LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B6E0", Offset = "0x5E7A6E0", VA = "0x185E7B6E0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E7A9E0", Offset = "0x5E799E0", VA = "0x185E7A9E0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B670", Offset = "0x5E7A670", VA = "0x185E7B670")]
		public MutableOverridableObscuredBool(bool ACBPCJELHDI, ObscuredBool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B5A0", Offset = "0x5E7A5A0", VA = "0x185E7B5A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B3E0", Offset = "0x5E7A3E0", VA = "0x185E7B3E0", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B4E0", Offset = "0x5E7A4E0", VA = "0x185E7B4E0", Slot = "19")]
		public override void KPEGJMKGOHJ(PDEGALLELKI LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B300", Offset = "0x5E7A300", VA = "0x185E7B300", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x6723D0", Offset = "0x6713D0", VA = "0x1806723D0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x77E1D0", Offset = "0x77D1D0", VA = "0x18077E1D0", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A9E0", Offset = "0x5E799E0", VA = "0x185E7A9E0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A960", Offset = "0x5E79960", VA = "0x185E7A960")]
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
			[Cpp2IlInjected.Address(RVA = "0x3305380", Offset = "0x3304380", VA = "0x183305380", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x3305460", Offset = "0x3304460", VA = "0x183305460", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1984940", Offset = "0x1983940", VA = "0x181984940")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3305350", Offset = "0x3304350", VA = "0x183305350")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2FB5A80", Offset = "0x2FB4A80", VA = "0x182FB5A80")]
		public SerializedMutableOverridableObscuredEnum(bool ACBPCJELHDI, TObsEnum IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x3305030", Offset = "0x3304030", VA = "0x183305030", Slot = "18")]
		public sealed override MEEILDALLDL CJMHGJCHINP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x3305240", Offset = "0x3304240", VA = "0x183305240", Slot = "19")]
		public sealed override void KPEGJMKGOHJ(MEEILDALLDL LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x3305140", Offset = "0x3304140", VA = "0x183305140", Slot = "20")]
		public sealed override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x33050E0", Offset = "0x33040E0", VA = "0x1833050E0", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E7B230", Offset = "0x5E7A230", VA = "0x185E7B230", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B270", Offset = "0x5E7A270", VA = "0x185E7B270", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B140", Offset = "0x5E7A140", VA = "0x185E7B140")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B1D0", Offset = "0x5E7A1D0", VA = "0x185E7B1D0")]
		public MutableOverridableListObscuredString(bool ACBPCJELHDI, List<ObscuredString> IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B0A0", Offset = "0x5E7A0A0", VA = "0x185E7B0A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AC10", Offset = "0x5E79C10", VA = "0x185E7AC10", Slot = "17")]
		public override void EJCGBCFCFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AC80", Offset = "0x5E79C80", VA = "0x185E7AC80", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AD80", Offset = "0x5E79D80", VA = "0x185E7AD80", Slot = "19")]
		public override void KPEGJMKGOHJ(CKDNEFCCAII LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AA50", Offset = "0x5E79A50", VA = "0x185E7AA50", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x8D7DB0", Offset = "0x8D6DB0", VA = "0x1808D7DB0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7C1C0", Offset = "0x5E7B1C0", VA = "0x185E7C1C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x204FEF0", Offset = "0x204EEF0", VA = "0x18204FEF0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C1A0", Offset = "0x5E7B1A0", VA = "0x185E7C1A0")]
		public OverridableVector3(Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C100", Offset = "0x5E7B100", VA = "0x185E7C100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E7C0E0", Offset = "0x5E7B0E0", VA = "0x185E7C0E0")]
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
