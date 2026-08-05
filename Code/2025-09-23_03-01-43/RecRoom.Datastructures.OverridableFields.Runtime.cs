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
public interface JILFFLNMEJH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GJHFGIMEMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object ANCKHJFLNDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface AHBFEJHJCDM<T> : JILFFLNMEJH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T CECIKJNPCJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GDCBLLKEDKP<T> : AHBFEJHJCDM<T>, JILFFLNMEJH
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool GJHFGIMEMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T CECIKJNPCJO
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
public interface EFNHBAELGBA<T> : GDCBLLKEDKP<T>, AHBFEJHJCDM<T>, JILFFLNMEJH
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PJBOAMKODHD
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
	public struct OverridableInt : AHBFEJHJCDM<int>, JILFFLNMEJH
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
			[Cpp2IlInjected.Address(RVA = "0x10D68B0", Offset = "0x10D4EB0", VA = "0x1810D68B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x84BBC20", Offset = "0x84BA220", VA = "0x1884BBC20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x30A0350", Offset = "0x309E950", VA = "0x1830A0350", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84BBB80", Offset = "0x84BA180", VA = "0x1884BBB80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : AHBFEJHJCDM<string>, JILFFLNMEJH
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
			[Cpp2IlInjected.Address(RVA = "0x10D68B0", Offset = "0x10D4EB0", VA = "0x1810D68B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB562D0", Offset = "0xB548D0", VA = "0x180B562D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB562D0", Offset = "0xB548D0", VA = "0x180B562D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84BBC70", Offset = "0x84BA270", VA = "0x1884BBC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : GDCBLLKEDKP<InnerType>, AHBFEJHJCDM<InnerType>, JILFFLNMEJH where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool GJHFGIMEMNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType CECIKJNPCJO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object ANCKHJFLNDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2D7FA40", Offset = "0x2D7E040", VA = "0x182D7FA40", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5A68680", Offset = "0x5A66C80", VA = "0x185A68680")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5A686B0", Offset = "0x5A66CB0", VA = "0x185A686B0")]
		public MutableOverridableBase(bool POOIFFHGDKN, [NotNull] InnerType KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5A67DB0", Offset = "0x5A663B0", VA = "0x185A67DB0", Slot = "15")]
		public void ABNIADDPAID(AHBFEJHJCDM<InnerType> OIAKIODILPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5A683A0", Offset = "0x5A669A0", VA = "0x185A683A0", Slot = "16")]
		public void JOENHKFEPHF(AHBFEJHJCDM<InnerType> AAGCKLPFJME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5A68110", Offset = "0x5A66710", VA = "0x185A68110", Slot = "17")]
		public virtual void JGIFDBJEMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType PKPKFKAFIOK();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void MLLMDDPIOKB(ProtobufType KIOOMNMOOJP);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void MFKFIKABIFA(byte[] GEKLIKDOPEH);
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
			[Cpp2IlInjected.Address(RVA = "0xAFE8C0", Offset = "0xAFCEC0", VA = "0x180AFE8C0", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xB82B90", Offset = "0xB81190", VA = "0x180B82B90", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xFA4470", Offset = "0xFA2A70", VA = "0x180FA4470", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4620370", Offset = "0x461E970", VA = "0x184620370")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5B95FB0", Offset = "0x5B945B0", VA = "0x185B95FB0")]
		public SerializedMutableOverridableBase(bool POOIFFHGDKN, InnerType KOPHBHGIACG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, IEKLAMFEICH>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84BBAB0", Offset = "0x84BA0B0", VA = "0x1884BBAB0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84BBB10", Offset = "0x84BA110", VA = "0x1884BBB10")]
		public MutableOverridableObscuredInt(bool POOIFFHGDKN, ObscuredInt KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84BB9E0", Offset = "0x84B9FE0", VA = "0x1884BB9E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84BB770", Offset = "0x84B9D70", VA = "0x1884BB770", Slot = "20")]
		public override void MFKFIKABIFA(byte[] GEKLIKDOPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84BB850", Offset = "0x84B9E50", VA = "0x1884BB850", Slot = "19")]
		public override void MLLMDDPIOKB(IEKLAMFEICH KIOOMNMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x84BB900", Offset = "0x84B9F00", VA = "0x1884BB900", Slot = "18")]
		public override IEKLAMFEICH PKPKFKAFIOK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, CACODBJFEFO>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84BB6A0", Offset = "0x84B9CA0", VA = "0x1884BB6A0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84BB700", Offset = "0x84B9D00", VA = "0x1884BB700")]
		public MutableOverridableObscuredFloat(bool POOIFFHGDKN, ObscuredFloat KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x84BB5D0", Offset = "0x84B9BD0", VA = "0x1884BB5D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84BB340", Offset = "0x84B9940", VA = "0x1884BB340", Slot = "20")]
		public override void MFKFIKABIFA(byte[] GEKLIKDOPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84BB420", Offset = "0x84B9A20", VA = "0x1884BB420", Slot = "19")]
		public override void MLLMDDPIOKB(CACODBJFEFO KIOOMNMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x84BB4E0", Offset = "0x84B9AE0", VA = "0x1884BB4E0", Slot = "18")]
		public override CACODBJFEFO PKPKFKAFIOK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, PBDDNLANJNA>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x84BA550", Offset = "0x84B8B50", VA = "0x1884BA550")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x84BB2D0", Offset = "0x84B98D0", VA = "0x1884BB2D0")]
		public MutableOverridableObscuredBool(bool POOIFFHGDKN, ObscuredBool KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84BB200", Offset = "0x84B9800", VA = "0x1884BB200", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84BAEE0", Offset = "0x84B94E0", VA = "0x1884BAEE0", Slot = "20")]
		public override void MFKFIKABIFA(byte[] GEKLIKDOPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84BAFC0", Offset = "0x84B95C0", VA = "0x1884BAFC0", Slot = "19")]
		public override void MLLMDDPIOKB(PBDDNLANJNA KIOOMNMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84BB110", Offset = "0x84B9710", VA = "0x1884BB110", Slot = "18")]
		public override PBDDNLANJNA PKPKFKAFIOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84BB080", Offset = "0x84B9680", VA = "0x1884BB080", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xAA8980", Offset = "0xAA6F80", VA = "0x180AA8980", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, EFNHBAELGBA<ObscuredBool>, GDCBLLKEDKP<ObscuredBool>, AHBFEJHJCDM<ObscuredBool>, JILFFLNMEJH
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xAA5700", Offset = "0xAA3D00", VA = "0x180AA5700", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xAA54D0", Offset = "0xAA3AD0", VA = "0x180AA54D0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x84BA550", Offset = "0x84B8B50", VA = "0x1884BA550")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x84BA4D0", Offset = "0x84B8AD0", VA = "0x1884BA4D0")]
		public void ABNIADDPAID(MutableOverridableDefaultableObscuredBool AAGCKLPFJME)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, IEKLAMFEICH> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5F179C0", Offset = "0x5F15FC0", VA = "0x185F179C0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x5F17AF0", Offset = "0x5F160F0", VA = "0x185F17AF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x52AED10", Offset = "0x52AD310", VA = "0x1852AED10")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5F179A0", Offset = "0x5F15FA0", VA = "0x185F179A0")]
		public SerializedMutableOverridableObscuredEnum(bool POOIFFHGDKN, TObsEnum KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5F178B0", Offset = "0x5F15EB0", VA = "0x185F178B0", Slot = "18")]
		public sealed override IEKLAMFEICH PKPKFKAFIOK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5F177B0", Offset = "0x5F15DB0", VA = "0x185F177B0", Slot = "19")]
		public sealed override void MLLMDDPIOKB(IEKLAMFEICH KIOOMNMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5F176D0", Offset = "0x5F15CD0", VA = "0x185F176D0", Slot = "20")]
		public sealed override void MFKFIKABIFA(byte[] GEKLIKDOPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5F17660", Offset = "0x5F15C60", VA = "0x185F17660", Slot = "17")]
		public sealed override void JGIFDBJEMCA()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, FOPMFJKNNEO>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x84BAE10", Offset = "0x84B9410", VA = "0x1884BAE10", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x84BAE50", Offset = "0x84B9450", VA = "0x1884BAE50", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84BAD70", Offset = "0x84B9370", VA = "0x1884BAD70")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84BAD10", Offset = "0x84B9310", VA = "0x1884BAD10")]
		public MutableOverridableListObscuredString(bool POOIFFHGDKN, List<ObscuredString> KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84BAC70", Offset = "0x84B9270", VA = "0x1884BAC70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x84BA5C0", Offset = "0x84B8BC0", VA = "0x1884BA5C0", Slot = "17")]
		public override void JGIFDBJEMCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84BA650", Offset = "0x84B8C50", VA = "0x1884BA650", Slot = "20")]
		public override void MFKFIKABIFA(byte[] GEKLIKDOPEH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84BA730", Offset = "0x84B8D30", VA = "0x1884BA730", Slot = "19")]
		public override void MLLMDDPIOKB(FOPMFJKNNEO KIOOMNMOOJP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84BAA90", Offset = "0x84B9090", VA = "0x1884BAA90", Slot = "18")]
		public override FOPMFJKNNEO PKPKFKAFIOK()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : AHBFEJHJCDM<Vector3>, JILFFLNMEJH
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
			[Cpp2IlInjected.Address(RVA = "0x10D68B0", Offset = "0x10D4EB0", VA = "0x1810D68B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x84BBDA0", Offset = "0x84BA3A0", VA = "0x1884BBDA0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xAFDAB0", Offset = "0xAFC0B0", VA = "0x180AFDAB0", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5B651A0", Offset = "0x5B637A0", VA = "0x185B651A0")]
		public OverridableVector3(Vector3 KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6262660", Offset = "0x6260C60", VA = "0x186262660")]
		public OverridableVector3(bool POOIFFHGDKN, Vector3 KOPHBHGIACG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x84BBD00", Offset = "0x84BA300", VA = "0x1884BBD00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x84BBCE0", Offset = "0x84BA2E0", VA = "0x1884BBCE0")]
		public static OverridableVector3 HNGLNPFKABH(Vector3 IKJAADLGNCL)
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
