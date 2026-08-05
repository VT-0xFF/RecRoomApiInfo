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
			[Cpp2IlInjected.Address(RVA = "0xF135B0", Offset = "0xF123B0", VA = "0x180F135B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B5C0", Offset = "0x5E7A3C0", VA = "0x185E7B5C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x85F7F0", Offset = "0x85E5F0", VA = "0x18085F7F0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B520", Offset = "0x5E7A320", VA = "0x185E7B520", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0xF135B0", Offset = "0xF123B0", VA = "0x180F135B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB00", Offset = "0x6AC900", VA = "0x1806ADB00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x6ADB00", Offset = "0x6AC900", VA = "0x1806ADB00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B610", Offset = "0x5E7A410", VA = "0x185E7B610", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x1FC42E0", Offset = "0x1FC30E0", VA = "0x181FC42E0", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4050", Offset = "0x1FC2E50", VA = "0x181FC4050")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1FC4110", Offset = "0x1FC2F10", VA = "0x181FC4110")]
		public MutableOverridableBase(bool ACBPCJELHDI, [NotNull] InnerType IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3BC0", Offset = "0x1FC29C0", VA = "0x181FC3BC0", Slot = "15")]
		public void NKALEANECIN(global::IMJDMJFKGDH<InnerType> CLPBMCBAIDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1FC3730", Offset = "0x1FC2530", VA = "0x181FC3730", Slot = "16")]
		public void JACHHKBDHDB(global::IMJDMJFKGDH<InnerType> HNOJKNGFFBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1FC36D0", Offset = "0x1FC24D0", VA = "0x181FC36D0", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x65B250", Offset = "0x65A050", VA = "0x18065B250", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x65B270", Offset = "0x65A070", VA = "0x18065B270", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6570C0", Offset = "0x655EC0", VA = "0x1806570C0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x12DAB50", Offset = "0x12D9950", VA = "0x1812DAB50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x158F160", Offset = "0x158DF60", VA = "0x18158F160")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x312FA80", Offset = "0x312E880", VA = "0x18312FA80")]
		public SerializedMutableOverridableBase(bool ACBPCJELHDI, InnerType IGJPNMBCJPK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, MEEILDALLDL>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B4C0", Offset = "0x5E7A2C0", VA = "0x185E7B4C0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B450", Offset = "0x5E7A250", VA = "0x185E7B450")]
		public MutableOverridableObscuredInt(bool ACBPCJELHDI, ObscuredInt IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B380", Offset = "0x5E7A180", VA = "0x185E7B380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B1C0", Offset = "0x5E79FC0", VA = "0x185E7B1C0", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B2C0", Offset = "0x5E7A0C0", VA = "0x185E7B2C0", Slot = "19")]
		public override void KPEGJMKGOHJ(MEEILDALLDL LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B0E0", Offset = "0x5E79EE0", VA = "0x185E7B0E0", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E7B010", Offset = "0x5E79E10", VA = "0x185E7B010")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B070", Offset = "0x5E79E70", VA = "0x185E7B070")]
		public MutableOverridableObscuredFloat(bool ACBPCJELHDI, ObscuredFloat IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AF40", Offset = "0x5E79D40", VA = "0x185E7AF40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AD70", Offset = "0x5E79B70", VA = "0x185E7AD70", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AE70", Offset = "0x5E79C70", VA = "0x185E7AE70", Slot = "19")]
		public override void KPEGJMKGOHJ(JOLFIFGLHLH LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AC80", Offset = "0x5E79A80", VA = "0x185E7AC80", Slot = "18")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E79F80", Offset = "0x5E78D80", VA = "0x185E79F80")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AC10", Offset = "0x5E79A10", VA = "0x185E7AC10")]
		public MutableOverridableObscuredBool(bool ACBPCJELHDI, ObscuredBool IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AB40", Offset = "0x5E79940", VA = "0x185E7AB40", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A980", Offset = "0x5E79780", VA = "0x185E7A980", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E7AA80", Offset = "0x5E79880", VA = "0x185E7AA80", Slot = "19")]
		public override void KPEGJMKGOHJ(PDEGALLELKI LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A8A0", Offset = "0x5E796A0", VA = "0x185E7A8A0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0x6723D0", Offset = "0x6711D0", VA = "0x1806723D0", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8DC1D0", Offset = "0x8DAFD0", VA = "0x1808DC1D0", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x5E79F80", Offset = "0x5E78D80", VA = "0x185E79F80")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5E79F00", Offset = "0x5E78D00", VA = "0x185E79F00")]
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
			[Cpp2IlInjected.Address(RVA = "0x312FF10", Offset = "0x312ED10", VA = "0x18312FF10", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x312FFF0", Offset = "0x312EDF0", VA = "0x18312FFF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x17AC270", Offset = "0x17AB070", VA = "0x1817AC270")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x312FEE0", Offset = "0x312ECE0", VA = "0x18312FEE0")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x2DE0230", Offset = "0x2DDF030", VA = "0x182DE0230")]
		public SerializedMutableOverridableObscuredEnum(bool ACBPCJELHDI, TObsEnum IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x312FBC0", Offset = "0x312E9C0", VA = "0x18312FBC0", Slot = "18")]
		public sealed override MEEILDALLDL CJMHGJCHINP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x312FDD0", Offset = "0x312EBD0", VA = "0x18312FDD0", Slot = "19")]
		public sealed override void KPEGJMKGOHJ(MEEILDALLDL LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x312FCD0", Offset = "0x312EAD0", VA = "0x18312FCD0", Slot = "20")]
		public sealed override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x312FC70", Offset = "0x312EA70", VA = "0x18312FC70", Slot = "17")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E7A7D0", Offset = "0x5E795D0", VA = "0x185E7A7D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x5E7A810", Offset = "0x5E79610", VA = "0x185E7A810", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A6E0", Offset = "0x5E794E0", VA = "0x185E7A6E0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A770", Offset = "0x5E79570", VA = "0x185E7A770")]
		public MutableOverridableListObscuredString(bool ACBPCJELHDI, List<ObscuredString> IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A640", Offset = "0x5E79440", VA = "0x185E7A640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A1B0", Offset = "0x5E78FB0", VA = "0x185E7A1B0", Slot = "17")]
		public override void EJCGBCFCFCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A220", Offset = "0x5E79020", VA = "0x185E7A220", Slot = "20")]
		public override void EJHOFFNJMOA(byte[] LGBNDCPNDOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5E7A320", Offset = "0x5E79120", VA = "0x185E7A320", Slot = "19")]
		public override void KPEGJMKGOHJ(CKDNEFCCAII LFFEAHLLHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5E79FF0", Offset = "0x5E78DF0", VA = "0x185E79FF0", Slot = "18")]
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
			[Cpp2IlInjected.Address(RVA = "0xF135B0", Offset = "0xF123B0", VA = "0x180F135B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E7B760", Offset = "0x5E7A560", VA = "0x185E7B760", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x1E77DE0", Offset = "0x1E76BE0", VA = "0x181E77DE0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B740", Offset = "0x5E7A540", VA = "0x185E7B740")]
		public OverridableVector3(Vector3 IGJPNMBCJPK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B6A0", Offset = "0x5E7A4A0", VA = "0x185E7B6A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E7B680", Offset = "0x5E7A480", VA = "0x185E7B680")]
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
