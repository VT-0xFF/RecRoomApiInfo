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
public interface CBPGHGOPHGB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JMJBNKCBJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	object BHOFCOLGALN
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EGFGDHBHGIP<T> : CBPGHGOPHGB
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	T ONBMIOJBCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BEOABMPMLCK<T> : global::EGFGDHBHGIP<T>, CBPGHGOPHGB
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	new bool JMJBNKCBJDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	new T ONBMIOJBCHK
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
public interface JBMDAANCMHD<T> : global::BEOABMPMLCK<T>, global::EGFGDHBHGIP<T>, CBPGHGOPHGB
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool CLAINHJGFBG
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
	public struct OverridableInt : global::EGFGDHBHGIP<int>, CBPGHGOPHGB
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
			[Cpp2IlInjected.Address(RVA = "0x8703F0", Offset = "0x86EDF0", VA = "0x1808703F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x1E4C500", Offset = "0x1E4AF00", VA = "0x181E4C500", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x865090", Offset = "0x863A90", VA = "0x180865090", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C460", Offset = "0x1E4AE60", VA = "0x181E4C460", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct OverridableString : global::EGFGDHBHGIP<string>, CBPGHGOPHGB
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
			[Cpp2IlInjected.Address(RVA = "0x8703F0", Offset = "0x86EDF0", VA = "0x1808703F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x875BC0", Offset = "0x8745C0", VA = "0x180875BC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public string Value
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0x875BC0", Offset = "0x8745C0", VA = "0x180875BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C550", Offset = "0x1E4AF50", VA = "0x181E4C550", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class MutableOverridableBase<T, InnerType, ProtobufType> : global::BEOABMPMLCK<InnerType>, global::EGFGDHBHGIP<InnerType>, CBPGHGOPHGB where T : MutableOverridableBase<T, InnerType, ProtobufType> where ProtobufType : IMessage<ProtobufType>
	{
		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public abstract bool JMJBNKCBJDC
		{
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(Slot = "11")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(Slot = "12")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public abstract InnerType ONBMIOJBCHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "14")]
			set;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public object BHOFCOLGALN
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x371AB10", Offset = "0x3719510", VA = "0x18371AB10", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3909140", Offset = "0x3907B40", VA = "0x183909140")]
		public MutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3909200", Offset = "0x3907C00", VA = "0x183909200")]
		public MutableOverridableBase(bool CFDAOEONPIF, [NotNull] InnerType MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3908970", Offset = "0x3907370", VA = "0x183908970", Slot = "15")]
		public void APIAKKIDNIF(global::EGFGDHBHGIP<InnerType> PLCJFCHNHPI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3908F70", Offset = "0x3907970", VA = "0x183908F70", Slot = "16")]
		public void KCMGAHNKFOP(global::EGFGDHBHGIP<InnerType> EHBPAFKHADK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3908A40", Offset = "0x3907440", VA = "0x183908A40", Slot = "17")]
		public virtual void CIPJLEDKNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "18")]
		public abstract ProtobufType OFJEEAPGMMC();

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract void JBNOKFEMBLI(ProtobufType FEHGINJICFG);

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract void BLEPGBAHPPI(byte[] NAEGCIMEDAI);
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
			[Cpp2IlInjected.Address(RVA = "0x7E6A20", Offset = "0x7E5420", VA = "0x1807E6A20", Slot = "11")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7E6AC0", Offset = "0x7E54C0", VA = "0x1807E6AC0", Slot = "12")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public override InnerType Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "13")]
			get
			{
				return (InnerType)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x337FBF0", Offset = "0x337E5F0", VA = "0x18337FBF0", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x25114D0", Offset = "0x250FED0", VA = "0x1825114D0")]
		public SerializedMutableOverridableBase()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x46B47A0", Offset = "0x46B31A0", VA = "0x1846B47A0")]
		public SerializedMutableOverridableBase(bool CFDAOEONPIF, InnerType MFBGAMJDOKA)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class MutableOverridableObscuredInt : SerializedMutableOverridableBase<MutableOverridableObscuredInt, ObscuredInt, AONPNNKIMGO>
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C400", Offset = "0x1E4AE00", VA = "0x181E4C400")]
		public MutableOverridableObscuredInt()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C390", Offset = "0x1E4AD90", VA = "0x181E4C390")]
		public MutableOverridableObscuredInt(bool CFDAOEONPIF, ObscuredInt MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C2C0", Offset = "0x1E4ACC0", VA = "0x181E4C2C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C020", Offset = "0x1E4AA20", VA = "0x181E4C020", Slot = "20")]
		public override void BLEPGBAHPPI(byte[] NAEGCIMEDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C120", Offset = "0x1E4AB20", VA = "0x181E4C120", Slot = "19")]
		public override void JBNOKFEMBLI(AONPNNKIMGO FEHGINJICFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C1E0", Offset = "0x1E4ABE0", VA = "0x181E4C1E0", Slot = "18")]
		public override AONPNNKIMGO OFJEEAPGMMC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class MutableOverridableObscuredFloat : SerializedMutableOverridableBase<MutableOverridableObscuredFloat, ObscuredFloat, GMCPCKJOIIL>
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BF50", Offset = "0x1E4A950", VA = "0x181E4BF50")]
		public MutableOverridableObscuredFloat()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BFB0", Offset = "0x1E4A9B0", VA = "0x181E4BFB0")]
		public MutableOverridableObscuredFloat(bool CFDAOEONPIF, ObscuredFloat MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BE80", Offset = "0x1E4A880", VA = "0x181E4BE80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BBC0", Offset = "0x1E4A5C0", VA = "0x181E4BBC0", Slot = "20")]
		public override void BLEPGBAHPPI(byte[] NAEGCIMEDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BCC0", Offset = "0x1E4A6C0", VA = "0x181E4BCC0", Slot = "19")]
		public override void JBNOKFEMBLI(GMCPCKJOIIL FEHGINJICFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BD90", Offset = "0x1E4A790", VA = "0x181E4BD90", Slot = "18")]
		public override GMCPCKJOIIL OFJEEAPGMMC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class MutableOverridableObscuredBool : SerializedMutableOverridableBase<MutableOverridableObscuredBool, ObscuredBool, GAGJECBHKNI>, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x1E4AE80", Offset = "0x1E49880", VA = "0x181E4AE80")]
		public MutableOverridableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BB50", Offset = "0x1E4A550", VA = "0x181E4BB50")]
		public MutableOverridableObscuredBool(bool CFDAOEONPIF, ObscuredBool MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BA80", Offset = "0x1E4A480", VA = "0x181E4BA80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B7A0", Offset = "0x1E4A1A0", VA = "0x181E4B7A0", Slot = "20")]
		public override void BLEPGBAHPPI(byte[] NAEGCIMEDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B8A0", Offset = "0x1E4A2A0", VA = "0x181E4B8A0", Slot = "19")]
		public override void JBNOKFEMBLI(GAGJECBHKNI FEHGINJICFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B960", Offset = "0x1E4A360", VA = "0x181E4B960", Slot = "18")]
		public override GAGJECBHKNI OFJEEAPGMMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x1E4BA40", Offset = "0x1E4A440", VA = "0x181E4BA40", Slot = "22")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "21")]
		public void OnBeforeSerialize()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class MutableOverridableDefaultableObscuredBool : MutableOverridableObscuredBool, global::JBMDAANCMHD<ObscuredBool>, global::BEOABMPMLCK<ObscuredBool>, global::EGFGDHBHGIP<ObscuredBool>, CBPGHGOPHGB
	{
		[Cpp2IlInjected.Token(Token = "0x17000012")]
		[SerializeField]
		public bool IsDefault
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x8E9E30", Offset = "0x8E8830", VA = "0x1808E9E30", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x8E9FC0", Offset = "0x8E89C0", VA = "0x1808E9FC0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x1E4AE80", Offset = "0x1E49880", VA = "0x181E4AE80")]
		public MutableOverridableDefaultableObscuredBool()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x1E4AE00", Offset = "0x1E49800", VA = "0x181E4AE00")]
		public void APIAKKIDNIF(MutableOverridableDefaultableObscuredBool EHBPAFKHADK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class SerializedMutableOverridableObscuredEnum<TObsEnum, T> : SerializedMutableOverridableBase<SerializedMutableOverridableObscuredEnum<TObsEnum, T>, TObsEnum, AONPNNKIMGO> where TObsEnum : ObscuredEnum<T>, new() where T : struct, Enum
	{
		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public sealed override TObsEnum Value
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x46B4C60", Offset = "0x46B3660", VA = "0x1846B4C60", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x46B4D40", Offset = "0x46B3740", VA = "0x1846B4D40", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3898FF0", Offset = "0x38979F0", VA = "0x183898FF0")]
		public SerializedMutableOverridableObscuredEnum()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x46B4C30", Offset = "0x46B3630", VA = "0x1846B4C30")]
		public SerializedMutableOverridableObscuredEnum(TObsEnum MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x46B4C00", Offset = "0x46B3600", VA = "0x1846B4C00")]
		public SerializedMutableOverridableObscuredEnum(bool CFDAOEONPIF, TObsEnum MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x46B4B50", Offset = "0x46B3550", VA = "0x1846B4B50", Slot = "18")]
		public sealed override AONPNNKIMGO OFJEEAPGMMC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x46B4A40", Offset = "0x46B3440", VA = "0x1846B4A40", Slot = "19")]
		public sealed override void JBNOKFEMBLI(AONPNNKIMGO FEHGINJICFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x46B48E0", Offset = "0x46B32E0", VA = "0x1846B48E0", Slot = "20")]
		public sealed override void BLEPGBAHPPI(byte[] NAEGCIMEDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x46B49E0", Offset = "0x46B33E0", VA = "0x1846B49E0", Slot = "17")]
		public sealed override void CIPJLEDKNPD()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class MutableOverridableListObscuredString : SerializedMutableOverridableBase<MutableOverridableListObscuredString, List<ObscuredString>, ELICHGJLJAG>
	{
		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public override List<ObscuredString> Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x1E4B6D0", Offset = "0x1E4A0D0", VA = "0x181E4B6D0", Slot = "13")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x1E4B710", Offset = "0x1E4A110", VA = "0x181E4B710", Slot = "14")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B5E0", Offset = "0x1E49FE0", VA = "0x181E4B5E0")]
		public MutableOverridableListObscuredString()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B670", Offset = "0x1E4A070", VA = "0x181E4B670")]
		public MutableOverridableListObscuredString(bool CFDAOEONPIF, List<ObscuredString> MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B540", Offset = "0x1E49F40", VA = "0x181E4B540", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x1E4AFF0", Offset = "0x1E499F0", VA = "0x181E4AFF0", Slot = "17")]
		public override void CIPJLEDKNPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x1E4AEF0", Offset = "0x1E498F0", VA = "0x181E4AEF0", Slot = "20")]
		public override void BLEPGBAHPPI(byte[] NAEGCIMEDAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B060", Offset = "0x1E49A60", VA = "0x181E4B060", Slot = "19")]
		public override void JBNOKFEMBLI(ELICHGJLJAG FEHGINJICFG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x1E4B380", Offset = "0x1E49D80", VA = "0x181E4B380", Slot = "18")]
		public override ELICHGJLJAG OFJEEAPGMMC()
		{
			return null;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct OverridableVector3 : global::EGFGDHBHGIP<Vector3>, CBPGHGOPHGB
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
			[Cpp2IlInjected.Address(RVA = "0x8703F0", Offset = "0x86EDF0", VA = "0x1808703F0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public object ObjectValue
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x1E4C6A0", Offset = "0x1E4B0A0", VA = "0x181E4C6A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public Vector3 Value
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x8BAE60", Offset = "0x8B9860", VA = "0x1808BAE60", Slot = "4")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C680", Offset = "0x1E4B080", VA = "0x181E4C680")]
		public OverridableVector3(Vector3 MFBGAMJDOKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C5E0", Offset = "0x1E4AFE0", VA = "0x181E4C5E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x1E4C5C0", Offset = "0x1E4AFC0", VA = "0x181E4C5C0")]
		public static OverridableVector3 EHMKDPHHPBI(Vector3 GNMCFHMDDGA)
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
