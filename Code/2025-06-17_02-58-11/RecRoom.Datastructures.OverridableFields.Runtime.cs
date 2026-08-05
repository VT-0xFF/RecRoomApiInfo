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
public interface EIJNNLIBKPI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OCCKAFKDGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object AJLJLFFBIPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface JDBBDHDIDOO<T> : EIJNNLIBKPI
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T AMCECKEAKLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GDDLOCLLNKN<T> : JDBBDHDIDOO<T>, EIJNNLIBKPI
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool OCCKAFKDGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T AMCECKEAKLL
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
public interface HMICCOFNJGP<T> : GDDLOCLLNKN<T>, JDBBDHDIDOO<T>, EIJNNLIBKPI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool KCDNGDMOHNL
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
	public struct OverridableInt : JDBBDHDIDOO<int>, EIJNNLIBKPI
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
			[Cpp2IlInjected.Address(RVA = "0xF88870", Offset = "0xF87270", VA = "0x180F88870", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7D0C620", Offset = "0x7D0B020", VA = "0x187D0C620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x2FA2F60", Offset = "0x2FA1960", VA = "0x182FA2F60", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C580", Offset = "0x7D0AF80", VA = "0x187D0C580", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : JDBBDHDIDOO<string>, EIJNNLIBKPI
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
			[Cpp2IlInjected.Address(RVA = "0xF88870", Offset = "0xF87270", VA = "0x180F88870", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xA85B50", Offset = "0xA84550", VA = "0x180A85B50", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xA85B50", Offset = "0xA84550", VA = "0x180A85B50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C670", Offset = "0x7D0B070", VA = "0x187D0C670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : GDDLOCLLNKN<InnerType>, JDBBDHDIDOO<InnerType>, EIJNNLIBKPI where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool OCCKAFKDGEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType AMCECKEAKLL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object AJLJLFFBIPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x2B0A700", Offset = "0x2B09100", VA = "0x182B0A700", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x54E7E40", Offset = "0x54E6840", VA = "0x1854E7E40")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x54E7E70", Offset = "0x54E6870", VA = "0x1854E7E70")]
		public MutableOverridableBase(bool JFPNIBPHEBA, [NotNull] InnerType PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x54E7B20", Offset = "0x54E6520", VA = "0x1854E7B20", Slot = "15")]
		public void MGGDHBOJBCN(JDBBDHDIDOO<InnerType> OECIMOKICEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x54E7570", Offset = "0x54E5F70", VA = "0x1854E7570", Slot = "16")]
		public void LKOOONLLMMI(JDBBDHDIDOO<InnerType> NDNHELJMDCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x54E7420", Offset = "0x54E5E20", VA = "0x1854E7420", Slot = "17")]
		public virtual void ALHGHPCNMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType FGPGBIKONNA();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void LANJHAJCFNH(ProtobufType PEBOFPGMBDK);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void AIBEGBMEHAN(byte[] JGEJFEIHFMA);
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
			[Cpp2IlInjected.Address(RVA = "0xA97A50", Offset = "0xA96450", VA = "0x180A97A50", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA979E0", Offset = "0xA963E0", VA = "0x180A979E0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE61320", Offset = "0xE5FD20", VA = "0x180E61320", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x465BD60", Offset = "0x465A760", VA = "0x18465BD60")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4C529E0", Offset = "0x4C513E0", VA = "0x184C529E0")]
		public SerializedMutableOverridableBase(bool JFPNIBPHEBA, InnerType PCDAHJCDHHF)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, BNIGIHOPBAI>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C4B0", Offset = "0x7D0AEB0", VA = "0x187D0C4B0")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C510", Offset = "0x7D0AF10", VA = "0x187D0C510")]
		public MutableOverridableObscuredInt(bool JFPNIBPHEBA, ObscuredInt PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C3E0", Offset = "0x7D0ADE0", VA = "0x187D0C3E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C180", Offset = "0x7D0AB80", VA = "0x187D0C180", Slot = "20")]
		public override void AIBEGBMEHAN(byte[] JGEJFEIHFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C330", Offset = "0x7D0AD30", VA = "0x187D0C330", Slot = "19")]
		public override void LANJHAJCFNH(BNIGIHOPBAI PEBOFPGMBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C250", Offset = "0x7D0AC50", VA = "0x187D0C250", Slot = "18")]
		public override BNIGIHOPBAI FGPGBIKONNA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, LGLHHFFPPEB>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C0B0", Offset = "0x7D0AAB0", VA = "0x187D0C0B0")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C110", Offset = "0x7D0AB10", VA = "0x187D0C110")]
		public MutableOverridableObscuredFloat(bool JFPNIBPHEBA, ObscuredFloat PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BFE0", Offset = "0x7D0A9E0", VA = "0x187D0BFE0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BD60", Offset = "0x7D0A760", VA = "0x187D0BD60", Slot = "20")]
		public override void AIBEGBMEHAN(byte[] JGEJFEIHFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BF20", Offset = "0x7D0A920", VA = "0x187D0BF20", Slot = "19")]
		public override void LANJHAJCFNH(LGLHHFFPPEB PEBOFPGMBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BE30", Offset = "0x7D0A830", VA = "0x187D0BE30", Slot = "18")]
		public override LGLHHFFPPEB FGPGBIKONNA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, GIOJJCKJBHP>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7D0AFA0", Offset = "0x7D099A0", VA = "0x187D0AFA0")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BCF0", Offset = "0x7D0A6F0", VA = "0x187D0BCF0")]
		public MutableOverridableObscuredBool(bool JFPNIBPHEBA, ObscuredBool PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BC20", Offset = "0x7D0A620", VA = "0x187D0BC20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B910", Offset = "0x7D0A310", VA = "0x187D0B910", Slot = "20")]
		public override void AIBEGBMEHAN(byte[] JGEJFEIHFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BAD0", Offset = "0x7D0A4D0", VA = "0x187D0BAD0", Slot = "19")]
		public override void LANJHAJCFNH(GIOJJCKJBHP PEBOFPGMBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B9E0", Offset = "0x7D0A3E0", VA = "0x187D0B9E0", Slot = "18")]
		public override GIOJJCKJBHP FGPGBIKONNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7D0BB90", Offset = "0x7D0A590", VA = "0x187D0BB90", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, HMICCOFNJGP<ObscuredBool>, GDDLOCLLNKN<ObscuredBool>, JDBBDHDIDOO<ObscuredBool>, EIJNNLIBKPI
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA10D70", Offset = "0xA0F770", VA = "0x180A10D70", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA10D60", Offset = "0xA0F760", VA = "0x180A10D60", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7D0AFA0", Offset = "0x7D099A0", VA = "0x187D0AFA0")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7D0AF20", Offset = "0x7D09920", VA = "0x187D0AF20")]
		public void MGGDHBOJBCN(MutableOverridableDefaultableObscuredBool NDNHELJMDCG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, BNIGIHOPBAI> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x598AB70", Offset = "0x5989570", VA = "0x18598AB70", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x598AC80", Offset = "0x5989680", VA = "0x18598AC80", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x467DD70", Offset = "0x467C770", VA = "0x18467DD70")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x598AB50", Offset = "0x5989550", VA = "0x18598AB50")]
		public SerializedMutableOverridableObscuredEnum(bool JFPNIBPHEBA, TObsEnum PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x598A960", Offset = "0x5989360", VA = "0x18598A960", Slot = "18")]
		public sealed override BNIGIHOPBAI FGPGBIKONNA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x598AA50", Offset = "0x5989450", VA = "0x18598AA50", Slot = "19")]
		public sealed override void LANJHAJCFNH(BNIGIHOPBAI PEBOFPGMBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x598A810", Offset = "0x5989210", VA = "0x18598A810", Slot = "20")]
		public sealed override void AIBEGBMEHAN(byte[] JGEJFEIHFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x598A8F0", Offset = "0x59892F0", VA = "0x18598A8F0", Slot = "17")]
		public sealed override void ALHGHPCNMCL()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, CGCGFFPFGPG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7D0B840", Offset = "0x7D0A240", VA = "0x187D0B840", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x7D0B880", Offset = "0x7D0A280", VA = "0x187D0B880", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B7A0", Offset = "0x7D0A1A0", VA = "0x187D0B7A0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B740", Offset = "0x7D0A140", VA = "0x187D0B740")]
		public MutableOverridableListObscuredString(bool JFPNIBPHEBA, List<ObscuredString> PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B6A0", Offset = "0x7D0A0A0", VA = "0x187D0B6A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B0E0", Offset = "0x7D09AE0", VA = "0x187D0B0E0", Slot = "17")]
		public override void ALHGHPCNMCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B010", Offset = "0x7D09A10", VA = "0x187D0B010", Slot = "20")]
		public override void AIBEGBMEHAN(byte[] JGEJFEIHFMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B350", Offset = "0x7D09D50", VA = "0x187D0B350", Slot = "19")]
		public override void LANJHAJCFNH(CGCGFFPFGPG PEBOFPGMBDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x7D0B170", Offset = "0x7D09B70", VA = "0x187D0B170", Slot = "18")]
		public override CGCGFFPFGPG FGPGBIKONNA()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : JDBBDHDIDOO<Vector3>, EIJNNLIBKPI
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
			[Cpp2IlInjected.Address(RVA = "0xF88870", Offset = "0xF87270", VA = "0x180F88870", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x7D0C7A0", Offset = "0x7D0B1A0", VA = "0x187D0C7A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x5269260", Offset = "0x5267C60", VA = "0x185269260", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x562CD00", Offset = "0x562B700", VA = "0x18562CD00")]
		public OverridableVector3(Vector3 PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5C99630", Offset = "0x5C98030", VA = "0x185C99630")]
		public OverridableVector3(bool JFPNIBPHEBA, Vector3 PCDAHJCDHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C700", Offset = "0x7D0B100", VA = "0x187D0C700", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7D0C6E0", Offset = "0x7D0B0E0", VA = "0x187D0C6E0")]
		public static OverridableVector3 HNONLACFBHP(Vector3 KPILPFEAJHA)
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
